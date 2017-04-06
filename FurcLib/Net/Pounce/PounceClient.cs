using System;
using System.Collections.Generic;
using System.Threading;
using static Furcadia.Util;

namespace Furcadia.Net.Pounce
{
    /// <summary>
    /// Generic Class to use the Pounce server
    /// <para>
    /// TODO: Read default lists(Furres, Dreams, Channels) from Furcadia Online.ini
    /// </para>
    /// </summary>
    public class PounceClient : PounceConnection, IDisposable
    {
        #region Public Constructors

        /// <summary>
        /// Default Constructor
        /// <para>
        /// Pounce server updates on a 30 second cron-job
        /// </para>
        /// </summary>
        public PounceClient() : base("http://on.furcadia.com/q/", null, null)
        {
            PounceTimer = new Timer(smPounceSend, this,
                TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));
        }

        #endregion Public Constructors

        #region Private Fields

        private Dictionary<string, PounceFurre> _furreList = new Dictionary<string, PounceFurre>();

        private string _onlineList;

        private System.DateTime lastaccess;

        private Timer PounceTimer;

        private int usingPounce = 0;
        private int UsingPounce1;

        #endregion Private Fields

        #region Public Properties

        private string onlinelist;

        /// <summary>
        /// </summary>
        public List<PounceFurre> FurreList { get; private set; }

        /// <summary>
        /// File path to List of furres to check online status
        /// </summary>
        public string OnlineList
        {
            get { return onlinelist; }
            set { onlinelist = value; }
        }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// Send request to Pounce server at 30 second interval
        /// </summary>
        /// <param name="sender">
        /// </param>
        private void smPounceSend(object sender)
        {
            if ((0 == Interlocked.Exchange(ref UsingPounce1, 1)))
            {
                ClearFriends();
                foreach (PounceFurre Furre in FurreList)
                {
                    if (!string.IsNullOrEmpty(Furre.Name))
                    {
                        AddFriend(FurcadiaShortName(Furre.Name));
                    }
                }
                ConnectAsync();
                Interlocked.Exchange(ref UsingPounce1, 0);
            }
        }

        #endregion Private Methods

        #region Public Classes

        /// <summary>
        /// </summary>
        public class PounceFurre
        {
            #region "Public Fields"

            private bool _online;

            private bool _wasOnline;

            /// <summary>
            /// Furre Name
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Furre Currently online
            /// </summary>
            public bool Online
            {
                get { return _online; }
                set { this._online = value; }
            }

            /// <summary>
            /// Furre Previous Online State
            /// </summary>
            public bool WasOnline
            {
                get { return _wasOnline; }
                set { this._wasOnline = value; }
            }

            #endregion "Public Fields"
        }

        #endregion Public Classes
    }
}