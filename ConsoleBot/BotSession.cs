using Furcadia.IO;
using Furcadia.Net.DirectConnection;
using Furcadia.Net.Options;
using Furcadia.Net.Proxy;
using System;
using System.Net.NetworkInformation;

namespace BugProxy.Net

{
    /// <summary>
    /// </summary>
    public class BotSession : NetConnection, IDisposable
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BotSession"/> class.
        /// </summary>
        /// <param name="Options"></param>
        public BotSession(ClientOptions Options) : base(Options)
        {
        }

        #endregion Public Constructors
    }
}