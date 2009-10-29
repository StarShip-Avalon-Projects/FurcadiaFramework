/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (?) Kylix, Initial Coder
 * (Oct 27,2009,0.1) Squizzle, Added NetMessage, delegates, and NetProxy class.
 * 
*/

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Furcadia.Net
{

    public class NetProxy : INetConnection
    {
        #region Event Handling
        public delegate string DataEventHandler(string data);
        public delegate void AnyEventHandler(params object[] datas);
        public delegate void ErrorEventHandler(Exception e);
        /// <summary>
        /// This is triggered when the Server sends data to the client.
        /// </summary>
        public event DataEventHandler ServerData;
        /// <summary>
        /// This is triggered when the Client sends data to the server.
        /// </summary>
        public event DataEventHandler ClientData;

        /// <summary>
        /// This is triggered when the user has exited/logoff Furcadia and the Furcadia
        /// client is closed.
        /// </summary>
        public event Action ClientExited;

        /// <summary>
        /// This is triggered when a handled Exception is thrown.
        /// </summary>
        public event ErrorEventHandler Error;
        #endregion

        #region Private Declarations
        private IPEndPoint _endpoint;
        private TcpClient server;
        private TcpClient client;
        private TcpListener listen;

        private byte[] clientBuffer = new byte[4000], serverBuffer = new byte[4000];
        private string _ServerLeftOvers;
        private string clientBuild, serverBuild;
        private int _lport = 6700;
        private int _code = 1252;
        #endregion

        #region Constructors

        public NetProxy(int port)
        {
            _endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
        }
        public NetProxy(string host, int port)
        {
            _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
        }

        public NetProxy(IPAddress ip, int port)
        {
            _endpoint = new IPEndPoint(ip, port);
        }

        public NetProxy(IPEndPoint endpoint)
        {
            _endpoint = endpoint;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint">Ip and port to the Furcadia server.</param>
        /// <param name="localPort">The local port to connect the listener, (default is 6700)</param>
        public NetProxy(IPEndPoint endpoint, int localPort)
        {
            _lport = localPort;
            _endpoint = endpoint;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip">Furcadia server ip address</param>
        /// <param name="port">The Furcadia port. (default is 6500)</param>
        /// <param name="localPort">The local port to connect the listener, (default is 6700)</param>
        public NetProxy(IPAddress ip, int port, int localPort)
        {
            _lport = localPort;
            _endpoint = new IPEndPoint(ip, port);
        }

        /// <summary>
        /// Note: NetConnection does not connect to Furcadia.  Furcadia must be
        /// started before a connection can be made.  The connection is THROUGH
        /// Furcadia not to it.
        /// </summary>
        /// <param name="host">The Furcadia host. (default is "lightbringer.furcadia.com")</param>
        /// <param name="port">The Furcadia port. (default is 6500)</param>
        /// <param name="localPort">The local port to connect the listener, (default is 6700)</param>
        public NetProxy(string host, int port, int localPort)
        {
            _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);

        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Start the Furcadia.exe and run the listener.
        /// </summary>
        /// <param name="character">This will be passed as a argument to Furcadia.exe  (There is no default)</param>
        public void Connect()
        {
            try
            {
                string proxyIni = "localhost " + _lport.ToString();
                FileStream proxyStream = new FileStream(Util.Path + "proxy.ini", FileMode.Create);
                proxyStream.Write(Encoding.GetEncoding(_code).GetBytes(proxyIni), 0, proxyIni.Length);
                proxyStream.Close();

                listen = new TcpListener(IPAddress.Any,_lport);
                listen.Start();
                listen.BeginAcceptTcpClient(new AsyncCallback(AsyncListener), listen);
                //Run
                Directory.SetCurrentDirectory(Util.Path);
                if (!File.Exists("Furcadia.exe")) throw new Exception("Client executable 'Furcadia.exe' not found.");
                var proc = System.Diagnostics.Process.Start("Furcadia.exe");
                proc.EnableRaisingEvents = true;
                proc.Exited += delegate { if (this.ClientExited != null) this.ClientExited(); };
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }

        public void SendClient(INetMessage message)
        {
            try
            {
                if (client.GetStream().CanWrite)
                    client.GetStream().Write(Encoding.GetEncoding(_code).GetBytes(message.GetString()), 0, Encoding.GetEncoding(_code).GetBytes(message.GetString()).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }

        public void SendClient(string message)
        {
            try
            {
                if (client.GetStream().CanWrite)
                    client.GetStream().Write(Encoding.GetEncoding(_code).GetBytes(message), 0, Encoding.GetEncoding(_code).GetBytes(message).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }

        public void SendServer(INetMessage message)
        {
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(Encoding.GetEncoding(_code).GetBytes(message.GetString()), 0, Encoding.GetEncoding(_code).GetBytes(message.GetString()).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }

        public void SendServer(string message)
        {
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(Encoding.GetEncoding(_code).GetBytes(message), 0, Encoding.GetEncoding(_code).GetBytes(message).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }
        /// <summary>
        /// Terminates the connection.
        /// </summary>
        public void Kill()
        {
            try
            {
                server.Close();
                client.Close();
            }
            catch (Exception e) { if (Error != null) Error(e); }
        }
        #endregion

        #region Private Methods
        private void AsyncListener(IAsyncResult ar)
        {
            try
            {
                client = listen.EndAcceptTcpClient(ar);
                listen.Stop();
                // Connect to the server
                server = new TcpClient(Util.Host,_endpoint.Port);

                if (!server.Connected) throw new Exception("There was a problem connecting to the server.");
		        client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
            }
            catch(Exception e) { if (Error != null) Error(e); }
        }

        private void GetClientData(IAsyncResult ar)
        {
            List<string> lines = new List<string>();
            int read = client.GetStream().EndRead(ar);
            clientBuild = Encoding.GetEncoding(_code).GetString(clientBuffer, 0, read);
            while (client.GetStream().DataAvailable)
                clientBuild += Encoding.GetEncoding(_code).GetString(clientBuffer, 0, client.GetStream().Read(clientBuffer, 0, clientBuffer.Length));
            lines.AddRange(clientBuild.Split('\n'));
            for (int i = 0; i < lines.Count; i++)
            {
                NetMessage msg = new NetMessage();
                msg.Write(ClientData(lines[i]) + "\n");
                SendServer(msg);
            }

            if (client.Connected && clientBuild.Length >= 1)
            {
                client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
            }
        }

        private void GetServerData(IAsyncResult ar)
        {
            List<string> lines = new List<string>();
            int read = server.GetStream().EndRead(ar);
            if (!string.IsNullOrEmpty(_ServerLeftOvers))serverBuild += _ServerLeftOvers;
            serverBuild = Encoding.GetEncoding(_code).GetString(serverBuffer, 0, read);
            while (server.GetStream().DataAvailable)
                serverBuild += Encoding.GetEncoding(_code).GetString(serverBuffer, 0, server.GetStream().Read(serverBuffer, 0, serverBuffer.Length));
            lines.AddRange(serverBuild.Split('\n'));
            for (int i = 0; i < lines.Count; i++)
            {
                if (!lines[i].Contains("\n"))
                {
                    _ServerLeftOvers += lines[i] + "\n";
                    //lines.RemoveAt(i);
                }
                if (i < lines.Count)
                {
                    NetMessage msg = new NetMessage();
                    msg.Write(ServerData(lines[i]) + "\n");
                    SendClient(msg);
                }
            }
            if (server.Connected && serverBuild.Length != 0)
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
        }
        #endregion
    }
}
