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
            // Default Proxy Options
            //
            // this.LocalhostPort = 6700; this.ReconnectAttempts = 5;
            // this.ReconnectTimeOutDelay = 45; this.GameServerHost =
            // "lightbringer.furcadia.com"; this.GameServerPort = 6500;
            CharacterIniFile = "-followurl=furc://vinca/";
        }

        public BugProxyOptions(string CharacterIni) : this()
        {
            // Furcadia.Exe Command Line options If only a Character.ini is
            // Specified then NetProxy will Connect with Legacy Connection.
            // If NoArguments specified then we'll login with Account Login
            // window if we use -url="" We can Open the client and the
            // server will select the character for us and bypass the
            // Account Login Screen and the Game News feed
            this.CharacterIniFile = CharacterIni;

            // Add any Customic=zations here for Local BugProxySession.
        }

        #endregion Public Constructors
    }
}