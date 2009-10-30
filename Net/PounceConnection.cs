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
using System.Timers;
using System.Windows.Forms;

namespace Furcadia.Net
{
    public class PounceConnection : INetConnection
    {
        private HttpWebRequest request;
        private HttpWebResponse response;

        private System.Timers.Timer timer;

        private string _url;
        private string responseBody;
        private int _timelimit;
        private int statusCode;
        private string[] _friends;
        private bool aborted;

        public string RawResponse { get { return responseBody; } }
        public int TimeLimit { get { return _timelimit; } }

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
            string friends = string.Empty;
            foreach (string friend in _friends)
                friends += friend + "&";
            if (_friends.Length > 0)
            {
                Action a = delegate
                {
                    if (aborted) return;
                    this.request = (HttpWebRequest)WebRequest.Create(url + "/q/?" + friends);
                    try
                    {
                        StringBuilder respBody = new StringBuilder();
                        byte[] buf = new byte[8192];
                        this.response = (HttpWebResponse)this.request.GetResponse();
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
                        if (responseBody != string.Empty)
                        {
                            this.statusCode = (int)(HttpStatusCode)this.response.StatusCode;
                            string[] onln = this.responseBody.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            this._timelimit = int.Parse(onln[0].Substring(1));
                            var list = onln.ToList();
                            if (list.Count >= 3)
                            {
                                list.RemoveAt(0);
                                list.RemoveAt(list.Count - 1);
                                if (Response != null) Response(list.ToArray());
                            }
                        }
                    }
                    catch (WebException ex)
                    {
                        this.response = (HttpWebResponse)ex.Response;
                        this.responseBody = "No Server Response";
                    }
                };
                AsyncCallback asyncExecute = null;
                asyncExecute = new AsyncCallback(delegate(IAsyncResult ar)
                {
                    a.EndInvoke(ar);
                    if (timer == null || timer.Enabled == false)
                    {
                        if (_timelimit == 0) _timelimit = 15000;
                        timer = new System.Timers.Timer(Convert.ToDouble(_timelimit));
                        timer.Elapsed += delegate
                        {
                            if (asyncExecute != null) a.BeginInvoke(asyncExecute, a);
                        };
                        timer.Enabled = true;
                        timer.Start();
                    }
                });
                a.BeginInvoke(asyncExecute, a);
            }
            else return;
        }

        public void Connect()
        {
            aborted = false;
            if (string.IsNullOrEmpty(_url) == false )this.Request(_url);
        }

        public void Kill()
        {
            if (timer != null && timer.Enabled) timer.Stop();
            if (request != null) { request.Abort(); aborted = true; }
            if (response != null) response.Close();
        }
    }
}
