using Furcadia.IO;
using Furcadia.Net.Options;
using Furcadia.Net.Proxy;
using System;
using System.Net.NetworkInformation;

namespace BugProxy.Net

{
    /// <summary>
    /// </summary>
    public class BugProxySession : ProxySession, IDisposable
    {
        #region Private Fields

        private Paths FurcPath;
        private ProxyOptions options;

        #endregion Private Fields

        #region Public Methods

        /// <summary>
        /// Checks TCP port and scans for an available TCP port on the host system
        /// </summary>
        /// <param name="port">
        /// ref int
        /// </param>
        /// <returns>
        /// True when a port is found available
        /// </returns>
        public bool PortOpen(ref int port)
        {
            // Evaluate current system tcp connections. This is the same
            // information provided by the netstat command line application,
            // just in .Net strongly-typed object form. We will look through
            // the list, and if our port we would like to use in our
            // TcpClient is occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties__1 = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties__1.GetActiveTcpConnections();
            bool result = true;
            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    result = false;
                }
            }
            return result;
            // At this point, if isAvailable is true, we can proceed accordingly.
        }

        #endregion Public Methods

        #region Public Constructors

        public BugProxySession(ProxyOptions Options) : base(Options)
        {
            options = Options;
        }

        public class ProxySessionOptions
        {
        }

        #endregion Public Constructors
    }
}