/*Log Header
 *Format: (date,Version) AuthorName, Changes (i.e lines, or function listings).
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

//TODO: Update for Dreams and Channels
//TODO: Clean Code, Descriptive Variable Names

using Furcadia.Net.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using static Furcadia.Util;

namespace Furcadia.Net
{
    /// <summary>
    /// Base class for handling the Pounce Server Connections
    /// </summary>
    public class PounceConnection : IDisposable
    {
        #region Public Properties

        /// <summary>
        /// Set the Encoder to win 1252 encoding
        /// </summary>
        public static int EncoderPage
        {
            get
            {
                return Utilities.GetEncoding;// ENCODE_PAGE;
            }
        }

        #endregion Public Properties

        #region Public Fields

        /// <summary>
        /// </summary>
        [CLSCompliant(false)]
        public List<string> _friends = new List<string>(), _dreams = new List<string>();

        #endregion Public Fields

        #region Private Fields

        private static ManualResetEvent allDone = new ManualResetEvent(false);

        private int _num_dreams_mainmaps;

        private string _responseBody;

        /// <summary>
        /// </summary>
        private int _statusCode;

        private int _totalOnline;

        private string _url = string.Format("http://{0}", Utilities.PounceServerHost);

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// A HTTP web request
        /// </summary>
        /// <param name="url">
        /// Url (i.e http://on.furcadia.com) or if you have a custom on-line check server use that instead
        /// </param>
        /// <param name="shortN_friends">
        /// Friends (shortname) (i.e emeraldflame instead of Emerald|Flame)
        /// </param>
        public PounceConnection(string url, params string[] shortN_friends)
        {
            if (!string.IsNullOrEmpty(url))
                _url = url;
            //Make sure we have some friends.?
            if (shortN_friends != null && shortN_friends.Length > 0)
            {
                foreach (string friend in shortN_friends)
                {
                    AddFriend(friend);
                }
            }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public PounceConnection()
        {
        }

        #endregion Public Constructors

        #region Public Delegates

        /// <summary>
        /// </summary>
        /// <param name="friends">
        /// Friends list
        /// </param>
        /// <param name="dreams">
        /// Dream list.
        /// </param>
        public delegate void PounceResponse(string[] friends, string[] dreams);

        #endregion Public Delegates

        #region Public Events

        /// <summary>
        /// Called when a on-line check request sends a response. First argument is a list of players on-line.
        /// </summary>
        public event PounceResponse Response;

        #endregion Public Events



        #region Public Properties

        /// <summary>
        /// </summary>
        public int NumberOfDreamsOnMainMaps
        {
            get { return _num_dreams_mainmaps; }
        }

        /// <summary>
        /// When a response from the server is received this property will contain the raw HTTP string.
        /// </summary>
        public string RawResponse
        { get { return _responseBody; } }

        /// <summary>
        /// Total on-line Furre count retrieved from an on-line check request
        /// </summary>
        public int TotalFurresOnline
        {
            get { return _totalOnline; }
            set { _totalOnline = value; }
        }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Adds a friend to a list of friends. Throws a Exception on non alphanumeric string.
        /// </summary>
        /// <param name="name">
        /// A <see cref="System.String"/>
        /// </param>
        /// <returns>
        /// A <see cref="System.Boolean"/>. True if successfully added friend name. False if name
        /// already added.
        /// </returns>
        public bool AddFriend(string name)
        {
            name = FurcadiaShortName(name);
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

        /// <summary>
        /// Iterates through friend's names to make sure they are valid alpha numeric (a-z0-9).
        /// </summary>
        /// <returns>
        /// True: All friends names are fine. False otherwise.
        /// </returns>
        public bool CheckFriendNames()
        {
            for (int i = 0; i <= _friends.Count - 1; i++)
                if (!IsValidAlphaNumeric(_friends[i])) return false;
            return true;
        }

        /// <summary>
        /// Removes everyone from the friends list.
        /// </summary>
        public void ClearFriends()
        {
            _friends.Clear();
        }

        /// <summary>
        /// Connects to the on-line check server and sends a on-line check request
        /// </summary>
        public void Connect()
        {
            if (!string.IsNullOrEmpty(_url) && Uri.IsWellFormedUriString(_url, UriKind.RelativeOrAbsolute)) this.Request(_url);
        }

        /// <summary>
        /// Connects asynchronously to the on-line check server and sends a request without affecting
        /// the executing thread.
        /// </summary>
        public void ConnectAsync()
        {
            if (!string.IsNullOrEmpty(_url) && Uri.IsWellFormedUriString(_url, UriKind.RelativeOrAbsolute))
            {
                ThreadPool.QueueUserWorkItem(
                    new WaitCallback(delegate { this.Request(_url); }));
            }
        }

        /// <summary>
        /// Removes specified name from the list
        /// </summary>
        /// <param name="name">
        /// Furre Name
        /// </param>
        /// <returns>
        /// True on success
        /// </returns>
        public bool RemoveFriend(string name)
        {
            name = FurcadiaShortName(name);
            if (_friends.Contains(name))
            {
                _friends.Remove(name);
                return true;
            }
            return false;
        }

        #endregion Public Methods

        #region Internal Methods

        /// <summary>
        /// Checks a friend's name to make sure it is a valid alpha numeric (a-z0-9).
        /// <para>
        /// Furcadia short-name format is lowercase alpha-numeric strings
        /// </para>
        /// </summary>
        /// <param name="shortNFriend">
        /// Name of Friend.
        /// </param>
        /// <returns>
        /// True: Friend name is fine. False otherwise.
        /// </returns>
        public bool CheckFriendName(string shortNFriend)
        {
            int id = _friends.IndexOf(shortNFriend);
            if (id != -1)
            {
                return IsValidAlphaNumeric(_friends[id]);
            }
            else { return false; }
        }

        internal void BuffRespCallback(IAsyncResult ar)
        {
            HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
            using (Stream postStream = request.EndGetRequestStream(ar))
            {
                string requestString = string.Empty;
                foreach (string friend in _friends)
                    requestString += "u[]=" + friend + "&"; //u[]=jack&u[]=jill&u[]=hill
                foreach (string dream in _dreams)
                    requestString += "d[]=" + dream.Substring(6) + "&";
                byte[] byteArray = Encoding.GetEncoding(EncoderPage).GetBytes(requestString);
                // Write to the request stream.
                postStream.Write(byteArray, 0, requestString.Length);
                postStream.Close();
            }
            try
            {
                request.BeginGetResponse(new AsyncCallback(RespCallback), request);
            }
            catch
            {
                this._responseBody = "No Server Response";
            }
        }

        /// <summary>
        /// Checks a string to see if is it alpha numeric
        /// </summary>
        /// <param name="inputStr">
        /// Input String
        /// </param>
        /// <returns>
        /// True if inputStr is alpha numeric
        /// </returns>
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

        /// <summary>
        /// Sends the "POST" request to the Pounce Server.
        /// </summary>
        /// <param name="url">
        /// Optional URL, Defaults to http://on.furcadia.com
        /// </param>
        internal void Request(string url = null)
        {
            if (!string.IsNullOrEmpty(url))
                _url = url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(((_url.EndsWith("/")) ? _url : _url + "/")); // /?" + requestString
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

        internal void RespCallback(IAsyncResult ar)
        {
            try
            {
                // UTF8Encoding encoding;
                byte[] buf = new byte[1024];
                HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                StringBuilder respBody = new StringBuilder();
                using (HttpWebResponse resp = (HttpWebResponse)request.EndGetResponse(ar))
                {
                    using (Stream respStream = resp.GetResponseStream())
                    {
                        // number of bytes read
                        int count = 0;
                        do
                        {
                            count = respStream.Read(buf, 0, buf.Length);
                            if (count != 0)
                                respBody.Append(Encoding.GetEncoding(EncoderPage).GetString(buf, 0, count));
                        }
                        while (count > 0);

                        this._responseBody = respBody.ToString();

                        if (_responseBody != string.Empty)
                        {
                            // Not really useful for getting friend on-line status but store it anyways!
                            this._statusCode = (int)resp.StatusCode;
                            // Split the responseBody by '\n' into an array
                            string[] onln = this._responseBody.Split(new char[] { '\n', 'r' }, StringSplitOptions.RemoveEmptyEntries);
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

                                _num_dreams_mainmaps = Convert.ToInt32(list[list.Count - 1].Substring(1));
                                list.RemoveAt(list.Count - 1);
                                _totalOnline = Convert.ToInt32(list[list.Count - 1].Substring(1));
                                list.RemoveAt(list.Count - 1);
                            }
                            Response?.Invoke(friends.ToArray(), dreams.ToArray());
                        }

                        respStream.Close();
                    }

                    // Release the HttpWebResponse
                    resp.Close();
                    allDone.Set();
                }
            }
            catch
            {
            }
        }

        #endregion Internal Methods

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        /// <summary>
        /// Implement disposal pattern
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~PounceConnection() { // Do not change this code. Put cleanup
        // code in Dispose(bool disposing) above. Dispose(false); }

        #endregion IDisposable Support
    }
}