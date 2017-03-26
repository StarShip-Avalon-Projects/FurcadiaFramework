namespace Furcadia.Net.Utils
{
    /// <summary>
    /// Connection Status
    /// </summary>
    public enum Phase
    {
        /// <summary>
        /// Default errof
        /// </summary>
        error = -1,

        /// <summary>
        /// Initialize Connection
        /// </summary>
        Init,

        /// <summary>
        /// Connection started
        /// </summary>
        Connecting,

        /// <summary>
        /// Reconnection flag
        /// </summary>
        Reconnection,

        /// <summary>
        /// Message of the Day
        /// <para>
        /// IE: Good Morning Dave...
        /// </para>
        /// </summary>
        MOTD,

        /// <summary>
        /// Login Account,Password, Character Name
        /// </summary>
        Auth,

        /// <summary>
        /// Connection established
        /// </summary>
        Connected,

        /// <summary>
        /// Connection lost
        /// </summary>
        Disconnected,

        /// <summary>
        /// Setting Furcadia Proxy/Firewall settings
        /// </summary>
        SettingsSet,

        /// <summary>
        /// Furcadia Settings restored
        /// </summary>
        SettingsRestore,

        /// <summary>
        /// Furcadia Client has Disconnected from the proxy
        /// </summary>
        ClientDisconnected,

        /// <summary>
        /// Furcadia Client has closed.
        /// </summary>
        ClientClosed
    }

    /// <summary>
    /// Client Status Event Arguments.
    /// </summary>
    public class NetClientArgs : System.EventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">
        /// Optional Message
        /// </param>
        /// <param name="phase">
        /// Connection Phase
        /// </param>
        public NetClientArgs(Phase phase, string message = null)
        {
            ConnectionPhase = phase;
            Message = message;
        }

        #endregion Public Constructors

        #region Public Fields

        /// <summary>
        /// Status of the Furcadia Client Connection
        /// </summary>
        public Phase ConnectionPhase;

        /// <summary>
        /// optional string message
        /// </summary>
        public string Message;

        #endregion Public Fields
    }

    /// <summary>
    /// Server Status Event Arguments
    /// </summary>
    public class NetServerArgs : System.EventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="phase">
        /// Server Connection Phase
        /// </param>
        /// <param name="message">
        /// Optional Message
        /// </param>
        public NetServerArgs(Phase phase, string message = null)
        {
            ConnectionPhase = phase;
            Message = message;
        }

        #endregion Public Constructors

        #region Public Fields

        /// <summary>
        /// Status of the Server Connection
        /// </summary>
        public Phase ConnectionPhase;

        /// <summary>
        /// optional string message
        /// </summary>
        public string Message;

        #endregion Public Fields
    }
}