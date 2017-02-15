using Furcadia.IO;
using System;
using System.Collections.Generic;

//using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

/// using System.Timers.Timer;

namespace Furcadia.Net
{
    /// <summary>
    /// NetConnection
    /// <para>Derived from NetProxy for Stand a lone connections</para>
    ///
    ///<para>Log Header</para>
    ///<para>Format: (date,Version) AuthorName, Changes.</para>
    ///<para> (?,2007) Kylix, Initial Coder and SimpleProxy project manager</para>
    ///<para> (Oct 27,2009) Squizzle, Added NetMessage, delegates, and NetProxy wrapper class.</para>
    ///<para>(July 26, 2011) Gerolkae, added setting.ini switch for proxy.ini</para>
    ///<para> (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path</para>
    /// </summary>
    public class NetConnection
    {
        #region Event Handling

        /// <summary>
        /// </summary>
        public delegate void ActionDelegate();

        /// <summary>
        /// </summary>
        /// <param name="data">
        /// </param>
        public delegate void DataEventHandler2(string data);

        /// <summary>
        /// </summary>
        /// <param name="e">
        /// </param>
        /// <param name="o">
        /// </param>
        /// <param name="n">
        /// </param>
        public delegate void ErrorEventHandler(Exception e, Object o, String n);

        //public delegate void ErrorEventHandler(Exception e);
        /// <summary>
        ///This is triggered when the
        /// </summary>
        public event ActionDelegate Connected;

        /// <summary>
        /// This is triggered when a handled Exception is thrown.
        /// </summary>
        public event ErrorEventHandler Error;

        /// <summary>
        /// This is triggered when the Server sends data to the client. Doesn't expect a return value.
        /// </summary>
        public event DataEventHandler2 ServerData;

        /// <summary>
        ///This is triggered when the Server Disconnects
        /// </summary>
        public event ActionDelegate ServerDisConnected;

        #endregion Event Handling

        #region Private Declarations

        /// <summary>
        /// Max buffer size
        /// </summary>
        private static int BUFFER_CAP = 1024;

        private static int ENCODE_PAGE = 1252;
        private IPEndPoint _endpoint;
        private string _ServerLeftOvers;
        private bool CConnected = false;
        private TcpClient server;
        private byte[] serverBuffer = new byte[BUFFER_CAP];
        private string serverBuild;

        #endregion Private Declarations

        #region Constructors

        /// <summary>
        /// </summary>
        public Paths FurcPath;

        /// <summary>
        /// </summary>
        public NetConnection()
        {
            FurcPath = new Paths();
            string SetPath = FurcPath.GetLocalSettingsPath();
            string SetFile = "/settings.ini";
            string[] sett = FurcIni.LoadFurcadiaSettings(SetPath, SetFile);
            int port = Convert.ToInt32(FurcIni.GetUserSetting("PreferredServerPort", sett));
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// </summary>
        /// <param name="port">
        /// </param>
        public NetConnection(int port)
        {
            FurcPath = new Paths();
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// </summary>
        /// <param name="host">
        /// </param>
        /// <param name="port">
        /// </param>
        public NetConnection(string host, int port)
        {
            FurcPath = new Paths();
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// </summary>
        /// <param name="ip">
        /// </param>
        /// <param name="port">
        /// </param>
        public NetConnection(IPAddress ip, int port)
        {
            FurcPath = new Paths();
            try
            {
                _endpoint = new IPEndPoint(ip, port);
            }
            catch { }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Proxy is connected, or not.
        /// </summary>
        public bool IsServerConnected
        {
            get
            {
                if (server != null)
                    return server.Connected;
                else
                    return false;
            }
        }

        #endregion Properties

        #region Public Static Properties

        /// <summary>
        /// </summary>
        public static int BufferCapacity
        {
            get
            {
                return BUFFER_CAP;
            }
        }

        /// <summary>
        /// </summary>
        public static int EncoderPage
        {
            get
            {
                return ENCODE_PAGE;
            }
        }

        #endregion Public Static Properties

        #region Public Methods

        /// <summary>
        /// Connects to the Furcadia Server and starts the mini proxy.
        /// </summary>
        public void Connect()
        {
            //Start the async connect operation
            server = new TcpClient();
            server.BeginConnect(_endpoint.Address, _endpoint.Port, new AsyncCallback(AsyncListener), server);
        }

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Terminates the connection.
        /// </summary>
        public void Kill()
        {
            try
            {
                if (server != null && server.Connected == true)
                {
                    NetworkStream serverStream = server.GetStream();
                    if (serverStream != null)
                    {
                        serverStream.Flush();
                        serverStream.Dispose();
                        serverStream.Close();
                    }
                    server.Close();
                }
            }
            catch (Exception e) { Error?.Invoke(e, this, "Kill()"); }
        }

        /// <summary>
        /// Sends the text to the game server
        /// </summary>
        /// <param name="message">
        /// </param>
        public void SendServer(INetMessage message)
        {
            SendServer(message.GetString());
        }

        /// <summary>
        /// Sends Data to the Game server
        /// </summary>
        /// <param name="message">
        /// </param>
        public void SendServer(string message)
        {
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message), 0, System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message).Length);
            }
            catch (Exception e)
            {
                Error?.Invoke(e, this, "SendServer");
                ServerDisConnected?.Invoke();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Free other state (managed objects).
            }
            // Free your own state (unmanaged objects). Set large fields to null.
        }

        #endregion Public Methods

        #region Private Methods

        private object lck = new object();

        private void AsyncListener(IAsyncResult ar)
        {
            try
            {
                // Connects to the server
                server = new TcpClient(Util.Host, _endpoint.Port);
                if (!server.Connected) throw new Exception("There was a problem connecting to the server.");

                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);

                Connected?.Invoke();
            }
            catch (Exception e) { Error?.Invoke(e, this, "AsyncListener()"); }
        }

        private void GetServerData(IAsyncResult ar)
        {
            lock (lck)
            {
                try
                {
                    if (IsServerConnected == false)
                    {
                        throw new SocketException((int)SocketError.NotConnected);
                    }
                    else
                    {
                        List<string> lines = new List<string>();
                        int read = server.GetStream().EndRead(ar);

                        if (read == 0)
                        {
                            ServerDisConnected?.Invoke(); return;
                        }
                        //If we have left over data add it to this server build
                        if (!string.IsNullOrEmpty(_ServerLeftOvers) && _ServerLeftOvers.Length > 0)
                            serverBuild += _ServerLeftOvers;
                        serverBuild = System.Text.Encoding.GetEncoding(EncoderPage).GetString(serverBuffer, 0, read);

                        while (server.GetStream().DataAvailable == true)
                        {
                            int pos = server.GetStream().Read(serverBuffer, 0, serverBuffer.Length);
                            serverBuild += System.Text.Encoding.GetEncoding(EncoderPage).GetString(serverBuffer, 0, pos);
                        }
                        lines.AddRange(serverBuild.Split('\n'));
                        if (!serverBuild.EndsWith("\n"))
                        {
                            _ServerLeftOvers += lines[lines.Count - 1];
                            lines.RemoveAt(lines.Count - 1);
                        }

                        for (int i = 0; i < lines.Count; i++)
                        {
                            ServerData?.Invoke(lines[i]);
                        }
                    }
                }
                catch (Exception e)
                {
                    // if (IsServerConnected == true) ServerDisConnected();
                    Error?.Invoke(e, this, "GetServerData()");
                    ServerDisConnected?.Invoke();
                    return;
                } //else throw e;
                  // Detect if client disconnected
                if (IsServerConnected && serverBuild.Length < 1 || IsServerConnected == false)
                {
                    ServerDisConnected?.Invoke();
                }

                if (IsServerConnected && serverBuild.Length > 0)
                    server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
            }
        }

        #endregion Private Methods
    }
}