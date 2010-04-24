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
        private string _responseBody;
        private int _statusCode;
        private int _timelimit;
        private int _num_dreams_mainmaps;
        private List<string> _friends = new List<string>();
		private int _totalOnline;

		/// <summary>
		/// When a response from the server is recieved this property will contain
		/// the raw HTTP string.
		/// </summary>
        public string RawResponse { get { return _responseBody; } }
        /// <summary>
        /// The amount of time allowed between subsequent online check requests.
        /// (Obsolete) 
        /// </summary>
        [Obsolete]
        public int TimeLimit { get {return _timelimit; } }

		/// <summary>
		/// Total online Furre count retrieved from a online check request
		/// </summary>
		public int TotalFurresOnline {
			get { return _totalOnline; }
			set { _totalOnline = value; }
		}

		public int NumberOfDreamsOnMainMaps {
			get { return _num_dreams_mainmaps; }
		}
		
        /// <summary>
        /// Called when a online check request sends a response.  First argument is a list of players online.
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
                    AddFriend(friend);
                }
            }
        }

        internal bool IsValidAlphaNumeric(string inputStr)
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

        internal void Request (string url)
        {
        	string friends = string.Empty;
        	foreach (string friend in _friends)
        		friends += "u[]=" + friend + "&"; //u[]=jack&u[]=jill&u[]=hill
            request = (HttpWebRequest)WebRequest.Create(((url.EndsWith("/"))?url : url +"/") + "q/?" + friends);
            try
            {
                request.BeginGetResponse(new AsyncCallback(RespCallback),null);
            }
            catch
            {
                this._responseBody = "No Server Response";
            }
        }

		internal void RespCallback (IAsyncResult ar)
		{
			byte[] buf = new byte[1024];
			StringBuilder respBody = new StringBuilder ();
			HttpWebResponse resp = (HttpWebResponse)request.EndGetResponse (ar);
			Stream respStream = resp.GetResponseStream ();
			// number of bytes read
			int count = 0;
			do
            {
				count = respStream.Read (buf, 0, buf.Length);
				if (count != 0)
					respBody.Append (System.Text.Encoding.ASCII.GetString (buf, 0, count));
			}
            while (count > 0);
		

            this._responseBody = respBody.ToString ();
			if (_responseBody != string.Empty)
            {
				// Not really useful for getting friend online status but store it anyways!
				this._statusCode = (int)(HttpStatusCode)resp.StatusCode;
				// Split the responseBody by '\n' into an array
				string[] onln = this._responseBody.Split (new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
				// the get request time limit (normally 15000) (Squizzle's Note: now timelimit is 30000ms as seen April 23, 2010.)
				this._timelimit = int.Parse (onln[0].Substring (1));
				List<string> list = new List<string> (onln);
				if (list.Count >= 3)
                {
					// Remove the first element T30000
					list.RemoveAt (0);
					_totalOnline = Convert.ToInt32 (list[list.Count - 1].Substring (1));
					list.RemoveAt (list.Count - 1);
					_num_dreams_mainmaps = Convert.ToInt32 (list[list.Count - 1].Substring (1));
                    list.RemoveAt (list.Count - 1);
                    // Trim the + from the beginning of the name.
                    for (int i = 0; i <= list.Count - 1; i++) list[i] = list[i].Remove(0, 1);
                    if (Response != null) Response(list.ToArray());
                }
				resp.Close();
            }
		}
		
		/// <summary>
		/// Connects to the online check server (thingy) and sends a online check request 
		/// </summary>
        public void Connect()
        {
            if (string.IsNullOrEmpty(_url) == false && Uri.IsWellFormedUriString(_url,UriKind.RelativeOrAbsolute))this.Request(_url);
        }
		
		/// <summary>
		/// Connects asynchronously to the online check server without affecting the executing thread.
		/// </summary>
		public void ConnectAsync(){
            if (string.IsNullOrEmpty(_url) == false && 
			    Uri.IsWellFormedUriString(_url,UriKind.RelativeOrAbsolute))
			{
				ThreadPool.QueueUserWorkItem(
					new WaitCallback(delegate{this.Request(_url);}));
			}
		}

		/// <summary>
		/// Adds a friend to a list of friends.
		/// Throws a Exception on non alphanumeric string.
		/// </summary>
		/// <param name="name">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>.
		/// True if successfully added friend name.
		/// False if name already added.
		/// </returns>
        public bool AddFriend(string name)
        {
        	if (IsValidAlphaNumeric (name.ToLower ())) {
        		if (_friends.Contains(name.ToLower())==false){
            		_friends.Add(name.ToLower ());
            		return true;
            	}
            }
            else throw new Exception(name + " is not valid alphanumeric (a-z0-9).");
            return false;
        }

        public bool RemoveFriend(string name)
        {
        	if (_friends.Contains(name)){
            	_friends.Remove(name);
            	return true;
            }
            return false;
        }

        public void ClearFriends()
        {
            _friends.Clear();
        }

        public bool ClearFriend(string shortname)
        {
            if (_friends.Contains(shortname))
            {
                _friends.Remove(shortname);
                return true;
            }
            return false;
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
            if (request != null) { request.Abort(); }
        }
    }
}
