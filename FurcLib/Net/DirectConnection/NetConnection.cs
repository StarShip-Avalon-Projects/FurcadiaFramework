using Furcadia.Net.Utils;
using System;

namespace Furcadia.Net.DirectConnection
{
    /// <summary>
    /// Direct Furcadia game server connection with included server load balancer.
    /// </summary>
    public class NetConnection : ClientBase
    {
        /// <summary>
        /// Message to server load balancing.
        /// </summary>
        private ServerQue ServerBalancer;

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

        /// <summary>
        /// Let the Server Balancer control the message load to the server
        /// </summary>
        /// <param name="message">
        /// 0Message from the Server Queue
        /// </param>
        /// <param name="e">
        /// event Arguments
        /// </param>
        private void MessageSentToServer(object message, EventArgs e)
        {
            base.SendServer((string)message);
        }
    }
}