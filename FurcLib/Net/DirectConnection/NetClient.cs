using Furcadia.Net.Utils;
using Furcadia.Text;

namespace Furcadia.Net.DirectConnection
{
    /// <summary>
    /// Stuff for Handling Game server Connection
    /// <para>
    /// Server Parser for
    /// </para>
    /// </summary>
    public class NetClient : NetConnection
    {
        #region Private Fields

        private Character newToon;

        /// <summary>
        /// Parse Server to Client Instruction set
        /// </summary>
        private ParseServer ServerParser;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Selected Character to connect to Game Server
        /// </summary>
        public Character character
        {
            get { return newToon; }
            set { newToon = value; }
        }

        #endregion Public Properties

        #region Public Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public NetClient() : base()
        {
            newToon = null;
        }

        /// <summary>
        /// Furcadia Legasy style client connection to game server.
        /// <para>
        /// We use manual settings here
        /// </para>
        /// </summary>
        /// <param name="CharacterName">
        /// name of the Character
        /// </param>
        /// <param name="CharacterPassword">
        /// Character Password
        /// </param>
        /// <param name="ColorString">
        /// Furcadia Color String
        /// </param>
        /// <param name="Description">
        /// Optional Description
        /// </param>
        public NetClient(string CharacterName, string CharacterPassword, string ColorString, string Description = null)
        {
            newToon = new Character();
            newToon.Name = CharacterName;
            newToon.Password = CharacterPassword;
            newToon.ColorString = ColorString;
            if (string.IsNullOrEmpty(Description))
                newToon.Description = "Furcadia legacy client powered by Furcadia Framework For Third Party Programs";
            else
                newToon.Description = Description;
        }

        /// <summary>
        /// Load Furcadia Legacy Client with a specified Character.ini file
        /// </summary>
        /// <param name="CharacterIni">
        /// Character.ini file path
        /// </param>
        public NetClient(string CharacterIni)
        {
            newToon = new Character();
            newToon.Load(CharacterIni);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Connect to Game Server
        /// </summary>
        public override void Connect()
        {
            if (newToon == null)
                throw new System.ArgumentException("Fiurcadia Legacy Character.ini cannot be null!!!");
            base.Connect();
        }

        #endregion Public Methods
    }
}