/*Log Header
 *Format: (date,Version) AuthorName, Changes (i.e lines, or function listings).
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Furcadia.Net
{
    public class PounceConnection
    {
        public delegate void PounceResponse(string[] friends, string[] dreams);

        private HttpWebRequest request;
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        private string _url;
        private string _responseBody;
        private int _statusCode;
        private int _num_dreams_mainmaps;
        public List<string> _friends = new List<string>(), _dreams = new List<string>();
        private int _totalOnline;

        /// <summary>
        /// When a response from the server is recieved this property will contain
        /// the raw HTTP string.
        /// </summary>
        public string RawResponse { get { return _responseBody; } }

        /// <summary>
        /// Total online Furre count retrieved from a online check request
        /// </summary>
        public int TotalFurresOnline
        {
            get { return _totalOnline; }
            set { _totalOnline = value; }
        }

        public int NumberOfDreamsOnMainMaps
        {
            get { return _num_dreams_mainmaps; }
        }

        /// <summary>
        /// Called when a online check request sends a response.  First argument is a list of players online.
        /// </summary>
        public event PounceResponse Response;

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

        internal void Request(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(((url.EndsWith("/")) ? url : url + "/")); // /?" + requestString
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            try
            {
                request.BeginGetRequestStream(new AsyncCallback(BuffRespCallback), request);
                allDone.WaitOne();
            }
            catch
            {
                this._responseBody = "No Server Response";
            }
        }

        internal void BuffRespCallback(IAsyncResult ar)
        {
            HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
            Stream postStream = request.EndGetRequestStream(ar);
            string requestString = string.Empty;
            foreach (string friend in _friends)
                requestString += "u[]=" + friend + "&"; //u[]=jack&u[]=jill&u[]=hill
            foreach (string dream in _dreams)
                requestString += "d[]=" + dream.Substring(6) + "&";
            byte[] byteArray = Encoding.UTF8.GetBytes(requestString);
            //request.ContentLength = requestString.Length;
            // Write to the request stream.
            postStream.Write(byteArray, 0, requestString.Length);
            postStream.Close();
            try
            {
                request.BeginGetResponse(new AsyncCallback(RespCallback), request);
            }
            catch
            {
                this._responseBody = "No Server Response";
            }
        }

        internal void RespCallback(IAsyncResult ar)
        {
            try
            {
                // UTF8Encoding encoding;
                byte[] buf = new byte[1024];
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                StringBuilder respBody = new StringBuilder();
                HttpWebResponse resp = (HttpWebResponse)request.EndGetResponse(ar);
                //Stream streamResponse = resp.GetResponseStream();
                //StreamReader streamRead = new StreamReader(streamResponse);
                //string responseString = streamRead.ReadToEnd();
                Stream respStream = resp.GetResponseStream();
                // number of bytes read
                int count = 0;
                do
                {
                    count = respStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                        respBody.Append(System.Text.Encoding.UTF8.GetString(buf, 0, count));
                }
                while (count > 0);

                this._responseBody = respBody.ToString();
                if (_responseBody != string.Empty)
                {
                    // Not really useful for getting friend online status but store it anyways!
                    this._statusCode = (int)(HttpStatusCode)resp.StatusCode;
                    // Split the responseBody by '\n' into an array
                    string[] onln = this._responseBody.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    List<string> list = new List<string>(onln);
                    List<string> dreams = new List<string>();
                    List<string> friends = new List<string>();
                    if (list.Count >= 3)
                    {
                        // Remove the first element T30000
                        list.RemoveAt(0);
                        for (int i = 0; i <= list.Count - 1; i++)
                        {
                            //Must be a dream if it starts with...
                            if (list[i].StartsWith("#"))
                            {
                                list[i] = list[i].Remove(0, 2);
                                dreams.Add(list[i]);
                                list.RemoveAt(i);
                            }
                            if (list[i].StartsWith("@10"))
                            {
                                friends.Add(list[i].Substring(4));
                                list.RemoveAt(i);
                            }
                        }
                        //friends.ForEach(Console.Write);
                        _num_dreams_mainmaps = Convert.ToInt32(list[list.Count - 1].Substring(1));
                        list.RemoveAt(list.Count - 1);
                        _totalOnline = Convert.ToInt32(list[list.Count - 1].Substring(1));
                        list.RemoveAt(list.Count - 1);
                    }
                    if (Response != null) Response(friends.ToArray(), dreams.ToArray());
                }

                respStream.Close();

                // Release the HttpWebResponse
                resp.Close();
                allDone.Set();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Connects to the online check server and sends a online check request
        /// </summary>
        public void Connect()
        {
            if (string.IsNullOrEmpty(_url) == false && Uri.IsWellFormedUriString(_url, UriKind.RelativeOrAbsolute)) this.Request(_url);
        }

        /// <summary>
        /// Connects asynchronously to the online check server and sends a request without affecting the executing thread.
        /// </summary>
        public void ConnectAsync()
        {
            if (string.IsNullOrEmpty(_url) == false &&
                Uri.IsWellFormedUriString(_url, UriKind.RelativeOrAbsolute))
            {
                ThreadPool.QueueUserWorkItem(
                    new WaitCallback(delegate { this.Request(_url); }));
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
            name = name.ToLower();
            name = name.Replace(" ", "");
            if (IsValidAlphaNumeric(name))
            {
                if (_friends.Contains(name) == false)
                {
                    _friends.Add(name);
                    return true;
                }
            }
            else throw new Exception(name + " is not valid alphanumeric (a-z0-9).");
            return false;
        }

        public bool RemoveFriend(string name)
        {
            if (_friends.Contains(name))
            {
                _friends.Remove(name);
                return true;
            }
            return false;
        }

        public void RemoveFriends()
        {
            _friends.Clear();
        }

        /// <summary>
        /// Iterates through friend's names to make sure they are valid alpha numeric (a-z0-9).
        /// </summary>
        /// <returns>True: All friends names are fine.  False otherwise.</returns>
        public bool CheckFriendNames()
        {
            for (int i = 0; i <= _friends.Count - 1; i++)
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
            }
            else { return false; }
        }

        public void Kill()
        {
            if (request != null) { request.Abort(); }
        }
    }
}