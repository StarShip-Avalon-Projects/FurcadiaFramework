using Furcadia.Net.Utils;
using System;
using System.Net;

namespace Furcadia.Net.DirectConnection
{
    /// <summary>
    /// Direct Furcadia game server connection with included server load balancer.
    /// </summary>
    public class NetConnection : ClientBase
    {
        #region Private Fields

        /// <summary>
        /// Message to server load balancing.
        /// </summary>
        private ServerQue ServerBalancer;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NetConnection() : base()
        {
            ServerBalancer = new ServerQue();
            ServerBalancer.OnServerSendMessage += MessageSentToServer;
        }

        /// <summary>
        /// Connect to game server with Host DNS and Specified port
        /// </summary>
        /// <param name="host">
        /// Game Server Host name
        /// </param>
        /// <param name="port">
        /// Game server TCP Port
        /// </param>
        public NetConnection(string host, int port) : base(host, port)
        {
        }

        /// <summary>
        /// Connect to game server with Host IP address and Specified port
        /// </summary>
        /// <param name="ip">
        /// Game Server IP
        /// </param>
        /// <param name="port">
        /// Game Server port
        /// </param>
        public NetConnection(IPAddress ip, int port) : base(ip, port)
        {
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Connect to game server
        /// </summary>
        public override void Connect()
        {
            base.Connect();
        }

        /// <summary>
        /// Send a message to the Game Server
        /// </summary>
        /// <param name="message">
        /// </param>
        public override void SendServer(string message)
        {
            ServerBalancer.SendToServer(message);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Let the Server Balancer control the message load to the server
        /// </summary>
        /// <param name="message">
        /// Message from the Server Queue
        /// </param>
        /// <param name="e">
        /// event Arguments
        /// </param>
        private void MessageSentToServer(object message, EventArgs e)
        {
            base.SendServer((string)message);
        }

        #endregion Private Methods
    }
}