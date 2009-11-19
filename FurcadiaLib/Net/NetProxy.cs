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
using Furcadia.IO;
using System.Net.NetworkInformation;

namespace Furcadia.Net
{

    public class NetProxy : Object
    {
        #region Event Handling
        public delegate void ActionDelegate();
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
        public event ActionDelegate ClientExited;

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
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
            }
            catch { }
        }

        public NetProxy(int port, int lport)
        {
            _lport = lport;
            try
            {
            _endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
            }
            catch { }
        }

        public NetProxy(string host, int port)
        {
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
            }
            catch { }
        }

        public NetProxy(string host, int port, int lport)
        {
            _lport = lport;
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
            }
            catch { }
        }

        public NetProxy(IPAddress ip, int port)
        {
            try
            {
                _endpoint = new IPEndPoint(ip, port);
            }
            catch { }
        }
        public NetProxy(IPAddress ip, int port, int lport)
        {
            _lport = lport;
            try
            {
                _endpoint = new IPEndPoint(ip, port);
            }
            catch { }
        }

        public NetProxy(IPEndPoint endpoint, int lport)
        {
            _lport = lport;
            try
            {
                _endpoint = endpoint;
            }
            catch { }
        }

        #endregion

        #region Properties

		private string _proc, _procpath;
        /// <summary>
        /// Process to start. (default: Furcadia.exe)
        /// </summary>
        public string Process
        {
            get { return _proc;}
            set { _proc=value; }
        }

        public string ProcessPath
        {
            get { return _procpath; }
            set { _procpath = value; }
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the startup Process to the associated file. (default: %FurcadiaInstallPath%/Furcadia.exe)
        /// </summary>
        /// <param name="file">Process full path and file name.</param>
        public void SetProcess(string file)
        {
            if (!File.Exists(file)) throw new FileNotFoundException();
            ProcessPath = Path.GetDirectoryName(file);
            Process = Path.GetFileName(file);
        }
        /// <summary>
        /// Connects to the Furcadia Server and starts the mini proxy.
        /// </summary>
        public void Connect()
        {
            try
            {
                string proxyIni = "localhost " + _lport.ToString();
                FileStream proxyStream = new FileStream(Paths.GetInstallPath() + "/proxy.ini", FileMode.Create);
                proxyStream.Write(System.Text.Encoding.GetEncoding(_code).GetBytes(proxyIni), 0, proxyIni.Length);
                proxyStream.Close();
                if (listen != null)
                {
                    listen.Start();
                    listen.BeginAcceptTcpClient(new AsyncCallback(AsyncListener), listen);
                }
                else
                {
                    bool isAvailable = true;
                    IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                    TcpConnectionInformation[] tcpInfoArray = ipGlobalProperties.GetActiveTcpConnections();

                    foreach (TcpConnectionInformation tcpi in tcpInfoArray)
                    {
                        if (tcpi.LocalEndPoint.Port == this._endpoint.Port)
                        {
                            Console.WriteLine(tcpi.State);
                            isAvailable = false;
                            break;
                        }
                    }
                    if (isAvailable)
                    {
                        listen = new TcpListener(IPAddress.Any, _lport);
                        listen.Start();
                        listen.BeginAcceptTcpClient(new AsyncCallback(AsyncListener), listen);
                    }
                    else throw new Exception("Port " + _lport.ToString() + " is being used.");

                }
                
                //Run
                if (string.IsNullOrEmpty(ProcessPath)) ProcessPath = Paths.GetInstallPath();
                //check ProcessPath is not a directory
                if (!Directory.Exists(ProcessPath)) throw new DirectoryNotFoundException();
                Directory.SetCurrentDirectory(ProcessPath);
                if (string.IsNullOrEmpty(Process)) Process = "Furcadia.exe";
                if (!File.Exists(Process)) throw new Exception("Client executable '"+Process+"' not found.");
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start(Process);
                proc.EnableRaisingEvents = true;
                proc.Exited += delegate { if (this.ClientExited != null) this.ClientExited(); };
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
        }

        public void SendClient(INetMessage message)
        {
            try
            {
                if (client.GetStream().CanWrite)
                    client.GetStream().Write(System.Text.Encoding.GetEncoding(_code).GetBytes(message.GetString()), 0, System.Text.Encoding.GetEncoding(_code).GetBytes(message.GetString()).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
        }

        public void SendServer(INetMessage message)
        {
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(System.Text.Encoding.GetEncoding(_code).GetBytes(message.GetString()), 0, System.Text.Encoding.GetEncoding(_code).GetBytes(message.GetString()).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
        }

        public void SendServer(string message)
        {
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(System.Text.Encoding.GetEncoding(_code).GetBytes(message), 0, System.Text.Encoding.GetEncoding(_code).GetBytes(message).Length);
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
        }

        /// <summary>
        /// Terminates the connection.
        /// </summary>
        public void Kill()
        {
            try
            {
                client.GetStream().Close();
                server.GetStream().Close();
                client.Close();
                server.Close();
            }
            catch{ }
        }

        #endregion

        #region Private Methods
        private void AsyncListener(IAsyncResult ar)
        {
            try
            {
                try
                {
                    client = listen.EndAcceptTcpClient(ar);
                }
                catch (SocketException se) { if (se.ErrorCode > 0) throw se; }
                listen.Stop();
                // Connect to the server
                server = new TcpClient(Util.Host,_endpoint.Port);

                if (!server.Connected) throw new Exception("There was a problem connecting to the server.");
                client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
            }
            catch (Exception e) { if (Error != null) Error(e);}
        }

        private void GetClientData(IAsyncResult ar)
        {
            try
            {
                if (client.Connected == false) return;

                List<string> lines = new List<string>();
                int read = client.GetStream().EndRead(ar);
                clientBuild = System.Text.Encoding.GetEncoding(_code).GetString(clientBuffer, 0, read);
                while (client.GetStream().DataAvailable)
                    clientBuild += System.Text.Encoding.GetEncoding(_code).GetString(clientBuffer, 0, client.GetStream().Read(clientBuffer, 0, clientBuffer.Length));
                lines.AddRange(clientBuild.Split('\n'));
                for (int i = 0; i < lines.Count; i++)
                {
                    INetMessage msg = new NetMessage();
					if (ClientData != null) msg.Write(ClientData(lines[i]));
					else msg.Write(lines[i] + "\n");
					if (msg.GetString().EndsWith("\n") == false) msg.Write("\n");
                    SendServer(msg);
                }
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
            if (client.Connected && clientBuild.Length >= 1)
            {
                client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
            }
        }

        private void GetServerData(IAsyncResult ar)
        {
            try
            {
                if (server.Connected == false) return;

                List<string> lines = new List<string>();
                int read = server.GetStream().EndRead(ar);
                if (!string.IsNullOrEmpty(_ServerLeftOvers)) serverBuild += _ServerLeftOvers;
                serverBuild = System.Text.Encoding.GetEncoding(_code).GetString(serverBuffer, 0, read);
                while (server.GetStream().DataAvailable)
                    serverBuild += System.Text.Encoding.GetEncoding(_code).GetString(serverBuffer, 0, server.GetStream().Read(serverBuffer, 0, serverBuffer.Length));
                lines.AddRange(serverBuild.Split('\n'));
                for (int i = 0; i < lines.Count; i++)
                {
                    if (!lines[i].Contains("\n"))
                    {
                        _ServerLeftOvers += lines[i] + "\n";
                    }
                    if (i < lines.Count)
                    {
                        NetMessage msg = new NetMessage();
                        msg.Write(((ServerData != null) ? ServerData(lines[i]) : lines[i]) + "\n");
                        SendClient(msg);
                    }
                }
            }
            catch (Exception e) { if (Error != null) Error(e); else throw e; }
            if (server.Connected && serverBuild.Length != 0)
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
        }
        #endregion
    }
}
