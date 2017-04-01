namespace Furcadia.Net.Utils
{
    /// <summary>
    /// Server to Client Instructions
    /// </summary>
    public enum ServerInstructionType
    {
        /// <summary>
        /// Unknown Instruction,
        /// <para>
        /// Needs further research
        /// </para>
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// Spawns a new Furre in the dream
        /// </summary>
        /// <remarks>
        /// </remarks>
        SpawnAvatar,

        /// <summary>
        /// Display formated Text.
        /// <para>
        /// Mostly Furcadia Markup but other stuff too
        /// </para>
        /// </summary>
        /// <remarks>
        /// Prefix "("
        /// <para>
        /// This instruction displays the specific text in the user's chatbox. The data may be
        /// formatted with HTML-equivalent and Furcadia-specific tags, as well as emoticons (stuff
        /// like "#SA").
        /// </para>
        /// </remarks>
        DisplayText
    }

    /// <summary>
    /// Parsing Server Data with Events
    /// </summary>
    public class ParseServer
    {
        #region Protected Fields

        /// <summary>
        /// Furcadia text channel
        /// </summary>
        protected string Channel;

        /// <summary>
        /// Current Furcadia Dream
        /// </summary>
        protected DREAM FurcadiaDream;

        /// <summary>
        /// Current Triggering Furre
        /// </summary>
        protected FURRE FurcadiaPlayer;

        #endregion Protected Fields

        #region Public Constructors

        //protected FURRE FurcadiaBot;
        /// <summary>
        /// </summary>
        /// <param name="Dream">
        /// Current Furcadia Dream
        /// </param>
        /// <param name="Player">
        /// Current Triggering Furre
        /// </param>
        public ParseServer(ref DREAM Dream, ref FURRE Player)
        {
            FurcadiaDream = Dream;
            FurcadiaPlayer = Player;
        }

        #endregion Public Constructors

        #region Public Delegates

        /// <summary>
        /// Event fired when we have successful parsed Channel Data
        /// </summary>
        /// <param name="o">
        /// </param>
        /// <param name="e">
        /// </param>
        public delegate void ParsedChannelEventHandler(object o, System.EventArgs e);

        /// <summary>
        /// Fired when we have parsed channel data
        /// </summary>
        /// <param name="o">
        /// </param>
        /// <param name="e">
        /// </param>
        public delegate void ParsedDataEventHandler(object o, System.EventArgs e);

        #endregion Public Delegates

        #region Public Events

        /// <summary>
        /// Text Channels have been parsed <seealso cref="ServerInstructionType.DisplayText"/>
        /// </summary>
        public event ParsedChannelEventHandler ChannelParsed;

        /// <summary>
        /// Generic Server Instruction Parsed event <seealso cref="ServerInstructionType"/>
        /// </summary>
        public event ParsedDataEventHandler DataParsed;

        #endregion Public Events

        #region Public Methods

        /// <summary>
        /// Parse the text channels coming from the server
        /// </summary>
        /// <param name="data">
        /// Raw server data for channels
        /// </param>
        /// <param name="handled">
        /// Is the current channel Handled properly?
        /// </param>
        public virtual void ParseServerChannel(string data, out bool handled)
        {
            handled = true;
            data = data.Substring(1);

            if (!handled)
            {
                ChannelParsed?.Invoke(data, System.EventArgs.Empty);
                handled = false;
            }
        }

        /// <summary>
        /// Parse the raw data coming from the Game Server
        /// <para>
        /// if the Data is a <see cref="ServerInstructionType.DisplayText"/> instruction, send the
        /// data to <see cref="ParseServerChannel"/>
        /// </para>
        /// </summary>
        /// <param name="data">
        /// Raw Server Data aka Server Instruction
        /// <para>
        /// ref=http://ftr.icerealm.org/ref-instructions/
        /// </para>
        /// </param>
        /// <param name="handled">
        /// </param>
        public virtual void ParseServerData(string data, out bool handled)
        {
            handled = false;

            //Send all text data to Channel Parsing
            if (data.StartsWith("("))
            {
                ParseServerChannel(data, out handled);
            }
            if (!handled)
                DataParsed?.Invoke(data, System.EventArgs.Empty);
        }

        #endregion Public Methods
    }

    /// <summary>
    /// Server Instruction Object
    /// </summary>
    public class ServerInstruction
    {
        #region Private Fields

        private string raw;

        private ServerInstructionType type;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sType">
        /// Instruction Type.
        /// </param>
        /// <param name="Raw">
        /// Raw Instruction
        /// </param>
        public ServerInstruction(ServerInstructionType sType, string Raw)
        {
            type = sType;
            raw = Raw;
        }

        #endregion Public Constructors
    }
}