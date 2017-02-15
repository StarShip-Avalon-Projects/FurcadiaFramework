using Furcadia.Net;

namespace Furcadia.IO
{
    /// <summary>
    /// Parsing Server Data with Events
    /// </summary>
    public class ParseServer
    {
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

        public event ParsedChannelEventHandler ChannelParsed;

        public event ParsedDataEventHandler DataParsed;

        /// <summary>
        /// Current Furcadia Dream
        /// </summary>
        protected DREAM FurcadiaDream;

        /// <summary>
        /// Current Triggering Furre
        /// </summary>
        protected FURRE FurcadiaPlayer;

        //protected FURRE FurcadiaBot;

        /// <summary>
        /// Furcadia text channel
        /// </summary>
        protected string Channel;

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

        /// <summary>
        /// Parse the text channels coming from the server
        /// </summary>
        /// <param name="data">
        /// </param>
        /// <param name="handled">
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
    }
}