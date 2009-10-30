/*Log Header
 *Format: (date,Version) AuthorName, Changes (i.e lines, or function listings).
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Furcadia.Net
{
    public class PounceConnection : INetConnection
    {
        private HttpWebRequest request;
        private HttpWebResponse response;

        private string _url;
        private string responseBody;
        private int _timelimit;
        private int statusCode;
        private string[] _friends;

        public string RawResponse { get { return responseBody; } }
        public int TimeLimit { get { return _timelimit; } }
        public string Headers { get { return GetHeaders(); } }

        /// <summary>
        /// Passes:
        /// list of online players
        /// </summary>
        public event Action<string[]> Response;

        /// <summary>
        /// A http web request 
        /// </summary>
        /// <param name="url">Url (i.e http://on.furcadia.com) or if you have a custom online check server use that instead</param>
        /// <param name="shortN_friends">Friends (shortname) (i.e emeraldflame instead of Emerald|Flame)</param>
        public PounceConnection(string url, params string[] shortN_friends)
        {
            _url = url;
            for (int i = 0; i <= shortN_friends.Length - 1;i++ )
            {
                if (IsValidAlphaNumeric(shortN_friends[i].ToLower()) == false)
                    throw new FormatException("\"" + shortN_friends[i].ToLower() + "\" is not AlphaNumeric. (Credit: Dream Dancer)");
                else shortN_friends.SetValue(shortN_friends[i].ToLower(), i);
            }
            _friends = shortN_friends;
        }

        private bool IsValidAlphaNumeric(string inputStr)
        {
            //make sure the user provided us with data to check
            //if not then return false
            if (string.IsNullOrEmpty(inputStr))
                return false;

            //now we need to loop through the string, examining each character
            for (int i = 0; i < inputStr.Length; i++)
            {
                //if this character isn't a letter and it isn't a number then return false
                //because it means this isn't a valid alpha numeric string
                if (!(char.IsLetter(inputStr[i])) && (!(char.IsNumber(inputStr[i]))))
                    return false;
            }
            //we made it this far so return true
            return true;
        }

        public void Request(string url)
        {
            StringBuilder respBody = new StringBuilder();

            string friends = string.Empty;
            foreach (string friend in _friends)
                friends += friend + "&";
            Console.WriteLine(friends);
            if (_friends.Length > 0)
                this.request = (HttpWebRequest)WebRequest.Create(url + "/q/?" + friends);
            else return;

            try
            {
                Console.WriteLine(this.request.KeepAlive);
                this.request.KeepAlive = true;
                this.response = (HttpWebResponse)this.request.GetResponse();
                byte[] buf = new byte[8192];
                Stream respStream = this.response.GetResponseStream();
                int count = 0;
                do
                {
                    count = respStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                        respBody.Append(Encoding.ASCII.GetString(buf, 0, count));
                }
                while (count > 0);

                this.responseBody = respBody.ToString();
                this._timelimit = int.Parse(responseBody.Substring(responseBody.IndexOf('T')+1, responseBody.IndexOf("\n")));
                this.statusCode = (int)(HttpStatusCode)this.response.StatusCode;
                string[] onln = this.responseBody.Split(new char[] {'\n'},StringSplitOptions.RemoveEmptyEntries);
                var list = onln.ToList();
                if (list.Count >= 3)
                {
                    list.RemoveAt(0);
                    list.RemoveAt(list.Count-1);
                    if (Response != null) Response(list.ToArray());
                }
            }
            catch (WebException ex)
            {
                this.response = (HttpWebResponse)ex.Response;
                this.responseBody = "No Server Response";
            }
        }

        private string GetHeaders()
        {
            if (response == null)
                return "No Server Response";
            else
            {
                StringBuilder headers = new StringBuilder();
                for (int i = 0; i < this.response.Headers.Count; ++i)
                    headers.Append(String.Format("{0}: {1}\n",
                        response.Headers.Keys[i], response.Headers[i]));

                return headers.ToString();
            }
        }

        public void Connect()
        {
            if (string.IsNullOrEmpty(_url) == false )this.Request(_url);
        }

        public void Kill()
        {
            response.Close();
        }
    }
}
