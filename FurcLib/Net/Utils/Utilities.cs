using System.Net;
using System.Net.NetworkInformation;

namespace Furcadia.Net.Utils
{
    /// <summary>
    /// Generic Furcadia Network Utilities
    /// </summary>
    public class Utilities
    {
        #region Private Fields

        /// <summary>
        /// Set Encoders to win 1252 encoding
        /// </summary>
        private const int EncoderPage = 1252;

        #endregion Private Fields

        #region Public Methods

        /// <summary>
        /// Checks TCP port and scans for an available TCP port on the host system
        /// </summary>
        /// <param name="port">
        /// ref TCP Port
        /// </param>
        /// <returns>
        /// True when a port is found available
        /// </returns>
        public bool PortOpen(ref int port)
        {
            // Evaluate current system tcp connections. This is the same information provided by the
            // netstat command line application, just in .Net strongly-typed object form. We will
            // look through the list, and if our port we would like to use in our TcpClient is
            // occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties__1 = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties__1.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    return false;
                }
            }
            return true;
            // At this point, if isAvailable is true, we can proceed accordingly.
        }

        #endregion Public Methods

        #region Public Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Utilities()
        {
        }

        #endregion Public Constructors



        #region Private Fields

        /// <summary>
        /// Game server DNS (Furcadia v31c)
        /// <para>
        /// update to library config file?
        /// </para>
        /// </summary>
        private static string gameserverhost = "lightbringer.furcadia.com";

        /// <summary>
        /// Game Server IP (Furcadia v31c)
        /// <para>
        /// update to library config file?
        /// </para>
        /// </summary>
        private static string gameserverip = "72.52.134.168";

        /// <summary>
        /// Pounce Server Host (Furcadia v31c)
        /// <para>
        /// update to library config file?
        /// </para>
        /// </summary>
        private static string pounceserverhost = "on.furcadia.com";

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Gets or sets the Furcadia server host (i.e lightbringer.furcadia.com). (Furcadia v31c)
        /// </summary>
        public static string GameServerHost
        {
            get { return gameserverhost; }
            set { gameserverhost = value; }
        }

        /// <summary>
        /// Gets or sets the IP of the Furcadia server. (Furcadia v31c)
        /// <para>
        /// update to library config file?
        /// </para>
        /// </summary>
        public static IPAddress GameServerIp
        {
            get { return IPAddress.Parse(gameserverip); }
            set { gameserverip = value.ToString(); }
        }

        /// <summary>
        /// Master Config set Encoders to Win 1252 encoding.
        /// </summary>
        public static int GetEncoding { get { return EncoderPage; } }

        /// <summary>
        /// Gets or sets the Furcadia Pounce Server host (IE on.furcadia.com). (Furcadia v31c)
        /// </summary>
        public static string PounceServerHost
        {
            get { return pounceserverhost; }
            set { pounceserverhost = value; }
        }

        #endregion Public Properties
    }
}