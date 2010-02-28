/*Log Header
 *Format: (date,Version) AuthorName, Changes (i.e lines, or function listings).
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading;

namespace Furcadia.Net
{
    public class PounceConnection
	{
		private HttpWebRequest request;
		
        private string _url;
        private string responseBody;
        private int _timelimit;
        private int statusCode;
        private List<string> _friends = new List<string>();
        private bool aborted;
		private int _totalOnline;

		/// <summary>
		/// When a response from the server is recieved this property will contain
		/// the raw HTTP string.
		/// </summary>
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
            //Make sure we have some friends..  no loners here, amirite?
            if (shortN_friends != null && shortN_friends.Length > 0)
            {
                foreach (string friend in shortN_friends)
                {
                    //Check for validity
                    AddFriend(friend);
                }
            }
        }

        public int TotalFurresOnline { get{
				return _totalOnline;
			}
			set {
				_totalOnline = value;
			}
		}

        private bool IsValidAlphaNumeric(string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
                return false;

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!(char.IsLetter(inputStr[i])) && (!(char.IsNumber(inputStr[i]))))
                    return false;
            }
            return true;
        }

        private void Request(string url)
        {
            string friends = string.Empty;
            foreach (string friend in _friends)
                friends += friend + "&"; //jack&jill&hill
            if (aborted) return;
            request = (HttpWebRequest)WebRequest.Create(url + "/q/?" + friends);
            try
            {
                request.BeginGetResponse(new AsyncCallback(RespCallback),null);
            }
            catch
            {
                this.responseBody = "No Server Response";
            }
        }

		private void RespCallback(IAsyncResult ar){
            byte[] buf = new byte[1024];
            StringBuilder respBody = new StringBuilder();
			HttpWebResponse resp = (HttpWebResponse)request.EndGetResponse(ar);
            Stream respStream = resp.GetResponseStream();
            // number of bytes read
            int count = 0;
            do
            {
                count = respStream.Read(buf, 0, buf.Length);
                if (count != 0)
                    respBody.Append(System.Text.Encoding.ASCII.GetString(buf, 0, count));
            }
            while (count > 0);

            this.responseBody = respBody.ToString();
            if (responseBody != string.Empty)
            {
                // Not really useful for getting friend online status
                this.statusCode = (int)(HttpStatusCode)resp.StatusCode;
                // Split the responseBody by '\n' into an array
                string[] onln = this.responseBody.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                // the get request time limit (normally 15000)
                this._timelimit = int.Parse(onln[0].Substring(1));
                List<string> list = new List<string>(onln);
                if (list.Count >= 3)
                {
                    // Remove the first element T15000
                    list.RemoveAt(0);
                    TotalFurresOnline = Convert.ToInt32(list[list.Count - 1].Substring(1));
                    // Remove the last element # Furres online.
                    list.RemoveAt(list.Count - 1);
                    // Trim the + from the beginning of the name.
                    for (int i = 0; i <= list.Count - 1; i++) list[i] = list[i].Remove(0, 1);
                    if (Response != null) Response(list.ToArray());
                }
				resp.Close();
            }
		}
		
        public void Connect()
        {
            aborted = false;
            if (string.IsNullOrEmpty(_url) == false && Uri.IsWellFormedUriString(_url,UriKind.RelativeOrAbsolute))this.Request(_url);
        }
		
		/// <summary>
		/// Connects asynchronously without affecting the main thread. 
		/// </summary>
		public void ConnectAsync(){
			aborted = false;
            if (string.IsNullOrEmpty(_url) == false && 
			    Uri.IsWellFormedUriString(_url,UriKind.RelativeOrAbsolute))
			{
				ThreadPool.QueueUserWorkItem(
					new WaitCallback(delegate{this.Request(_url);}));
			}
		}

        public void AddFriend(string name)
        {
            if (IsValidAlphaNumeric(name.ToLower()))
                _friends.Add(name.ToLower());
            else throw new Exception(name + " is not valid alphanumeric (a-z0-9).");
        }

        public void RemoveFriend(string name)
        {
            _friends.Remove(name);
        }

        public void ClearFriends()
        {
            _friends.Clear();
        }

        /// <summary>
        /// Iterates through friend's names to make sure they are valid alpha numeric (a-z0-9).
        /// </summary>
        /// <returns>True: All friends names are fine.  False otherwise.</returns>
        public bool CheckFriendNames()
        {
            for (int i = 0; i <= _friends.Count - 1;i++ )
                if (!IsValidAlphaNumeric(_friends[i])) return false;
            return true;
        }
		
        /// <summary>
        /// Checks a friend's name to make sure it is a valid alpha numeric (a-z0-9).
        /// </summary>
        /// <returns>True: Friend name is fine.  False otherwise.</returns>
		public bool CheckFriendName(string shortNFriend)
		{
			int id = _friends.IndexOf(shortNFriend);
			if (id != -1)
			{
				return IsValidAlphaNumeric(_friends[id]);
			}else {return false;}
		}

        public void Kill()
        {
            //if (timer != null && timer.Enabled) timer.Stop();
            if (request != null) { request.Abort(); aborted = true; }
        }
    }
}
