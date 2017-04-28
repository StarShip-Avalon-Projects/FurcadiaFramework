using Furcadia.Net.Options;

namespace BugProxy.Net
{
    /// <summary>
    /// Special BugProxy settings
    /// <para>
    /// change these to suit you're needs
    /// </para>
    /// </summary>
    public class BugProxyOptions : ProxySessionOptions
    {
        #region Public Constructors

        public BugProxyOptions() : base()
        {
            // Furcadia.Net.Proxy.ProxySession connection Options
            this.LocalhostPort = 6700;
            CharacterIniFile = "silvermonkey.ini";
            this.ReconnectAttempts = 5;
            this.ReconnectTimeOutDelay = 45;
            this.GameServerHost = "lightbringer.furcadia.com";
            this.GameServerPort = 6500;
        }

        public BugProxyOptions(string CharacterIni) : this()
        {
            this.CharacterIniFile = CharacterIni;
            // Add any Customic=zations here for Local BugProxySession.
        }

        #endregion Public Constructors
    }
}