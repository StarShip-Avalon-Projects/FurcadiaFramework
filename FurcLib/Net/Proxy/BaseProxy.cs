/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (?,2007) Kylix, Initial Coder and SimpleProxy project manager
 * (Oct 27,2009) Squizzle, Added NetMessage, delegates, and NetProxy wrapper class.
 * (July 26, 2011) Gerolkae, added setting.ini switch for proxy.ini
 * (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path
 * (March 2017, 2.1.x) Gerolkae, Furcadia V31 support.
 */

using Furcadia.IO;
using Furcadia.Net.Utils;
using Furcadia.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace Furcadia.Net
{
    /// <summary>
    /// Base proxy class to connect to Furcadia game server.
    /// <para>
    /// Currently only a furcadia character.ini file is supported.
    /// </para>
    /// </summary>
    /// <remarks>
    /// here we provide the base proxy class. Our Purpose is to connect to the Furcadia Game server
    /// with the raw sever to client instructions as Line Feed "\n" delimited text.
    /// <para>
    /// We modify furcadia's settings.ini file Firewall settings and disable the SSL/TLS connection
    /// for the Furcadia Client.
    /// <para>
    /// Once we have connected we attempt to restore the setting.ini file to its previous status
    /// after a ten-second delay to allow a Furcadia News update.
    /// </para>
    /// </para>
    /// </remarks>
    public class BaseProxy : IDisposable
    {
        #region Event Handling

        /// <summary>
        /// This is triggered when the Client sends data to the server. Expects a return value.
        /// </summary>
        public EventHandler ClientData2;

        /// <summary>
        /// Furcadia Client connection status event
        /// </summary>
        public EventHandler<NetClientArgs> OnClientStatusChanged;

        /// <summary>
        /// Furcadia Server Connection status event
        /// </summary>
        public EventHandler<NetServerArgs> OnServerStatusChanged;

        /// <summary>
        /// </summary>
        public delegate void ActionDelegate();

        /// <summary>
        /// </summary>
        /// <param name="data">
        /// </param>
        /// <returns>
        /// </returns>
        public delegate string DataEventHandler(string data);

        /// <summary>
        /// </summary>
        public delegate void DataEventHandler2(string data);

        /// <summary>
        /// </summary>
        /// <param name="e">
        /// Executing Exeception
        /// </param>
        /// <param name="o">
        /// Object
        /// </param>
        /// <param name="n">
        /// </param>
        public delegate void ErrorEventHandler(Exception e, object o, string n);

        /// <summary>
        /// This is triggered when the Client sends data to the server.
        /// </summary>
        public event DataEventHandler ClientData;

        //public delegate void ErrorEventHandler(Exception e);

        /// <summary>
        /// This is triggered when a handled Exception is thrown.
        /// </summary>
        public event ErrorEventHandler Error;

        /// <summary>
        /// This is Triggered when Furcadia "settings.ini" is restored to previous settings before
        /// proxy was used.
        /// </summary>
        public event ActionDelegate FurcSettingsRestored;

        /// <summary>
        /// This is triggered when the Server sends data to the client. Expects a return Value
        /// </summary>
        public event DataEventHandler ServerData;

        /// <summary>
        /// This is triggered when the Server sends data to the client. Doesn't expect a return value.
        /// </summary>
        public event DataEventHandler2 ServerData2;

        #endregion Event Handling

        #region Private Declarations

        /// <summary>
        /// Local host TCP Port
        /// </summary>
        [CLSCompliant(false)]
        public static int _lport = 6700;

        private static bool _StandAloneMode = false, Clientflag = true;

        /// <summary>
        /// Furcadia Settings to backup,
        /// <para>
        /// Proxy/Firewall and SSL/TLS settings.
        /// </para>
        /// </summary>
        private static string[] BackupSettings;

        /// <summary>
        /// Max buffer size
        /// </summary>
        private static int BUFFER_CAP = 2048;

        private static System.Timers.Timer NewsTimer;

        private IPEndPoint _endpoint;

        private string _proc = "Furcadia.exe", _procpath, _procCMD = "-pick";

        private int _procID;

        private string _ServerLeftOvers;

        private bool CConnected = false;

        private TcpClient client = new TcpClient();

        private byte[] clientBuffer = new byte[BUFFER_CAP], serverBuffer = new byte[BUFFER_CAP];

        private string clientBuild, serverBuild;

        /// <summary>
        /// Protect Furcadia Settings.ini from multiple instances attempting to modify settings.
        /// </summary>
        private Mutex FurcMutex;

        private TcpListener listen;
        private TcpClient server;

        #endregion Private Declarations

        #region Private Fields

        /// <summary>
        /// Use proxy.ini if it exists. otherwise use settings.ini.
        /// </summary>
        private Boolean UseProxyIni;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Furcadia Default Paths
        /// </summary>
        public Paths FurcPath = new Paths();

        /// <summary>
        /// Default NetProxy Constructor
        /// </summary>
        public BaseProxy()
        {
            FurcPath = new Paths();
            string SetPath = FurcPath.GetLocalSettingsPath();
            string SetFile = "/settings.ini";
            string[] sett = FurcIni.LoadFurcadiaSettings(SetPath, SetFile);
            int port = Convert.ToInt32(FurcIni.GetUserSetting("PreferredServerPort", sett));
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Utilities.GameServerHost).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// NetProcy Constructor with Server Port
        /// </summary>
        /// <param name="port">
        /// Server Port
        /// </param>
        public BaseProxy(int port)
        {
            FurcPath = new Paths();
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Utilities.GameServerHost).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// Net Proxy Constructor with Server and Local-Host ports
        /// </summary>
        /// <param name="port">
        /// Server Port
        /// </param>
        /// <param name="lport">
        /// Local-host Port
        /// </param>
        public BaseProxy(int port, int lport)
        {
            FurcPath = new Paths();
            _lport = lport;
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(Utilities.GameServerHost).AddressList[0], port);
            }
            catch { }
        }

        /// <summary>
        /// </summary>
        /// <param name="host">
        /// Game Server Host-name
        /// </param>
        /// <param name="port">
        /// Game Server Port
        /// </param>
        public BaseProxy(string host, int port)
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
        /// <param name="host">
        /// Game-Server Host-name
        /// </param>
        /// <param name="port">
        /// Server Port
        /// </param>
        /// <param name="lport">
        /// Local-Host Port
        /// </param>
        public BaseProxy(string host, int port, int lport)
        {
            FurcPath = new Paths();
            _lport = lport;
            try
            {
                _endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
            }
            catch { }
        }

        public BaseProxy(IPAddress ip, int port)
        {
            FurcPath = new Paths();
            try
            {
                _endpoint = new IPEndPoint(ip, port);
            }
            catch { }
        }

        public BaseProxy(IPAddress ip, int port, int lport)
        {
            FurcPath = new Paths();
            _lport = lport;
            try
            {
                _endpoint = new IPEndPoint(ip, port);
            }
            catch { }
        }

        public BaseProxy(IPEndPoint endpoint, int lport)
        {
            FurcPath = new Paths();
            _lport = lport;
            try
            {
                _endpoint = endpoint;
            }
            catch { }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Is the Furcadia Client connected to our proxy?
        /// </summary>
        public bool IsClientConnected
        {
            get
            {
                if (client != null)
                    return client.Connected;
                else
                    return false;
            }
        }

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

        /// <summary>
        /// Process to start. (default: Furcadia.exe)
        /// </summary>
        public string Process
        {
            get { return _proc; }
            set { _proc = value; }
        }

        /// <summary>
        /// Command to pass (default: -pick)
        /// </summary>
        public string ProcessCMD
        {
            get { return _procCMD; }
            set { _procCMD = value; }
        }

        /// <summary>
        /// Process path (default: none)
        /// </summary>
        public string ProcessPath
        {
            get
            {
                return _procpath;
            }
            set
            {
                FurcPath = new Paths(value);
                _procpath = value;
            }
        }

        /// <summary>
        /// Process ID for closing Furcadia.exe
        /// </summary>
        public int ProcID
        {
            get { return _procID; }
            set { _procID = value; }
        }

        /// <summary>
        /// Standalone Mode Keep Connection after Client Closes/Disconnects
        /// </summary>
        public bool StandAloneMode
        {
            get { return _StandAloneMode; }
            set { _StandAloneMode = value; }
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
        /// Set the Encoder to win 1252 encoding
        /// </summary>
        public static int EncoderPage
        {
            get
            {
                return Utilities.GetEncoding;// ENCODE_PAGE;
            }
        }

        #endregion Public Static Properties

        #region Public Methods

        /// <summary>
        /// Closes the Client Connection
        /// </summary>
        public void CloseClient()
        {
            try
            {
                if (listen != null) listen.Stop();
                if (client != null && client.Connected == true)
                {
                    NetworkStream clientStream = client.GetStream();
                    if (clientStream != null)
                    {
                        clientStream.Flush();
                        clientStream.Close();
                        clientStream.Dispose();
                    }

                    client.Close();
                    client.Dispose();
                }
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "CloseClient()");
            }
        }

        /// <summary>
        /// Connects to the Furcadia Server and starts the mini proxy.
        /// </summary>
        public virtual void Connect()
        {
            try
            {
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
                        if (tcpi.LocalEndPoint.Port == _endpoint.Port)
                        {
                            isAvailable = false;
                            break;
                        }
                    }
                    if (isAvailable)
                    {
                        try
                        {
                            listen = new TcpListener(IPAddress.Any, _lport);
                            listen.Start();
                            listen.BeginAcceptTcpClient(new AsyncCallback(AsyncListener), listen);
                        }
                        catch
                        {
                            _lport++;
                            listen = new TcpListener(IPAddress.Any, _lport);
                            listen.Start();
                            listen.BeginAcceptTcpClient(new AsyncCallback(AsyncListener), listen);
                        }
                    }
                    else throw new NetProxyException("Port " + _lport.ToString() + " is being used.");
                }

                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                FurcMutex = new Mutex(false, "FurcadiaFrameWork" + userName);
                if (!FurcMutex.WaitOne(100, false))
                {
                    Console.WriteLine("Another instance of Furcadia Framework is running.");
                    // Abort Connection Process

                    return;
                }
                string proxyIni = "localhost " + _lport.ToString();
                FurcPath = new Paths(_procpath);
                // UAC Perms Needed to Create proxy.ini Win 7 Change your UAC Level or add file
                // create Permissions to [%program files%/furcadia] Maybe Do this at install
                string fIni = Path.Combine(FurcPath.GetInstallPath(), "proxy.ini");
                // Check proxy.ini if it exists then use it

                // otherwise use settings.ini to avoid UAC issues on %Program Files%
                if (File.Exists(proxyIni))
                    File.Delete(proxyIni);
                UseProxyIni = false;
                BackupSettings = Settings.InitializeFurcadiaSettings(FurcPath.GetLocalSettingsPath());

                //Run
                if (string.IsNullOrEmpty(ProcessPath)) ProcessPath = FurcPath.GetInstallPath();
                //check ProcessPath is not a directory
                if (!Directory.Exists(ProcessPath)) throw new NetProxyException("Process path not found.");
                if (!File.Exists(Path.Combine(ProcessPath, Process))) throw new NetProxyException("Client executable '" + Process + "' not found.");
                Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = true;
                proc.StartInfo.FileName = Process;
                proc.StartInfo.Arguments = ProcessCMD;
                proc.StartInfo.WorkingDirectory = ProcessPath;
                proc.Start();
                proc.Exited += delegate
                {
                    NetClientArgs Args = new NetClientArgs(Phase.ClientDisconnected);
                    OnClientStatusChanged(this, Args);
                    CConnected = false;
                };
                ProcID = proc.Id;
                CConnected = true;
            }
            catch (NetProxyException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error(e, this, "Connect()");
                else throw e;
            }
        }

        /// <summary>
        /// Implement IDisposable.
        /// </summary>
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
                if (BackupSettings != null)
                    Settings.RestoreFurcadiaSettings(BackupSettings);
                if (listen != null) listen.Stop();

                if (client != null && client.Connected == true)
                {
                    NetworkStream clientStream = client.GetStream();
                    if (clientStream != null)
                    {
                        clientStream.Flush();
                        clientStream.Dispose();
                        clientStream.Close();
                    }

                    client.Close();
                    client.Dispose();
                }

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
                    server.Dispose();
                }
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "Dispose()");
            }
        }

        /// <summary>
        /// Sends a raw command to Furcadia Client
        /// </summary>
        /// <param name="message">
        /// </param>
        public virtual void SendClient(INetMessage message)
        {
            SendClient(message.GetString());
        }

        /// <summary>
        /// Sends a raw command to the Furcadia client
        /// </summary>
        /// <param name="message">
        /// </param>
        public virtual void SendClient(string message)
        {
            try
            {
                if (client.Client != null && client.GetStream().CanWrite == true && client.Connected == true)
                    client.GetStream().Write(System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message), 0, System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message).Length);
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "SendClient()");
            }
        }

        /// <summary>
        /// Sends a raw command to the game serer
        /// </summary>
        /// <param name="message">
        /// </param>
        public void SendServer(INetMessage message)
        {
            SendServer(message.GetString());
        }

        /// <summary>
        /// Sends a raw command to the game serer
        /// </summary>
        /// <param name="message">
        /// Raw instruction to send to server
        /// </param>
        public virtual void SendServer(string message)

        {
            if (!message.EndsWith("\n"))
                message += '\n';
            try
            {
                if (server.GetStream().CanWrite)
                    server.GetStream().Write(System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message), 0, System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message).Length);
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "SendServer");
                NetServerArgs Args = new NetServerArgs(Phase.Disconnected);
                OnServerStatusChanged(this, Args);
            }
        }

        /// <summary>
        /// Sets the startup Process to the associated file. (default: %FurcadiaInstallPath%/Furcadia.exe)
        /// </summary>
        /// <param name="file">
        /// Process full path and file name.
        /// </param>
        public void SetProcess(string file)
        {
            if (!File.Exists(file)) throw new FileNotFoundException("File not found.", file);
            ProcessPath = Path.GetDirectoryName(file);
            Process = Path.GetFileName(file);
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (BackupSettings != null)
                    Settings.RestoreFurcadiaSettings(BackupSettings);
                if (FurcMutex != null) FurcMutex.Dispose();
                // Free other state (managed objects).
            }
            // Free your own state (unmanaged objects). Set large fields to null.
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Asynchronously listen for client/server instructions
        /// </summary>
        /// <param name="ar">
        /// IAsyncResult
        /// </param>
        private void AsyncListener(IAsyncResult ar)
        {
            try
            {
                try
                {
                    client = listen.EndAcceptTcpClient(ar);
                }
                catch (SocketException se)
                {
                    listen.Stop();
                    if (se.ErrorCode > 0) throw se;
                }
                //listen.Stop();
                // Connects to the server
                server = new TcpClient(Utilities.GameServerHost, _endpoint.Port);
                if (!server.Connected) throw new Exception("There was a problem connecting to the server.");

                client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);

                NetClientArgs Args = new NetClientArgs(Phase.SettingsSet);
                OnClientStatusChanged(this, Args);

                Clientflag = true;
                // Delete proxy.ini or restore settings.ini
                if (UseProxyIni)
                {
                    if (File.Exists(FurcPath.GetInstallPath() + "proxy.ini"))
                        File.Delete(FurcPath.GetInstallPath() + "proxy.ini");
                }
                // reset settings.ini 10second delay timer
                NewsTimer = new System.Timers.Timer(10000);
                NewsTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                NewsTimer.Enabled = true;
                NewsTimer.AutoReset = false;
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "AsyncListener()");
            }
        }

        private void GetClientData(IAsyncResult ar)
        {
            try
            {
                if (client.Connected == false)
                {
                    throw new SocketException((int)SocketError.NotConnected);
                }
                List<string> lines = new List<string>();

                //read = number of bytes read
                int read = client.GetStream().EndRead(ar);
                //ClientBuild is a string containing data read off the clientBuffer
                clientBuild = System.Text.Encoding.GetEncoding(EncoderPage).GetString(clientBuffer, 0, read);
                while (client.GetStream().DataAvailable)
                {
                    //clientBuffer.Length = NetProxy.BUFFER_CAP

                    if (clientBuffer.Length <= 0)
                    {
                        NetClientArgs Args = new NetClientArgs(Phase.ClientDisconnected);
                        OnClientStatusChanged(this, Args);
                    }
                    int pos = client.GetStream().Read(clientBuffer, 0, clientBuffer.Length);
                    clientBuild += System.Text.Encoding.GetEncoding(EncoderPage).GetString(clientBuffer, 0, pos);
                }

                //Every instruction ends with '\n'
                //Split function removes the last character
                lines.AddRange(clientBuild.Split('\n'));
                for (int i = 0; i < lines.Count; i++)
                {
                    ClientData2(lines[i], System.EventArgs.Empty);
                    // we want ServerConnected and Check for null data Application may intentionally
                    // return ClientData = null to Avoid "Throat Tired" Syndrome. Let Application
                    // handle packet routing.
                    if (IsServerConnected == true && ClientData != null)
                    {
                        INetMessage msg = new NetMessage();
                        //Send the line to the ClientData event and write the return value to a new NetMessage
                        msg.Write(ClientData(lines[i]));
                        //If the NetMessage doesn't have '\n' at the end add it
                        //The '\n' separates the server/client protocols
                        if (msg.GetString().EndsWith("\n") == false) msg.Write("\n");
                        //Send it on it's way...
                        SendServer(msg);
                    }
                }
            }
            catch
            {// We don't care if there's an exception here.. We're Disconnecting any way
                if (client.Connected == true)
                {
                    NetClientArgs Args = new NetClientArgs(Phase.Disconnected);
                    OnClientStatusChanged(this, Args);
                }
                return;
            } // else throw e;
            if (IsClientConnected && clientBuild.Length < 1 || IsClientConnected == false)
            {
                NetClientArgs Args = new NetClientArgs(Phase.Disconnected);
                OnClientStatusChanged(this, Args);
            }
            if (client.Connected == true && clientBuild.Length >= 1)
            {
                client.GetStream().BeginRead(clientBuffer, 0, clientBuffer.Length, new AsyncCallback(GetClientData), client);
            }
        }

        private void GetServerData(IAsyncResult ar)
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

                    if (read < 1)
                    {
                        NetServerArgs Args = new NetServerArgs(Phase.Disconnected);
                        OnServerStatusChanged(this, Args);
                        return;
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
                        ServerData2?.Invoke(lines[i]);
                        if (IsClientConnected == true && ServerData != null &&
                            ServerData(lines[i]) != "" && ServerData(lines[i]) != null)
                        {
                            if (i < lines.Count)
                            {
                                NetMessage msg = new NetMessage();
                                msg.Write(ServerData(lines[i]) + '\n');
                                SendClient(msg);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (Error != null)
                    Error?.Invoke(e, this, "GetServerData()");
                return;
            } //else throw e;
              // Detect if client disconnected
            if (IsServerConnected && serverBuild.Length < 1 || IsServerConnected == false)
            {
                NetServerArgs Args = new NetServerArgs(Phase.Disconnected);
                OnServerStatusChanged(this, Args);
            }

            if (IsServerConnected && serverBuild.Length > 0)
                server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
        }

        /// <summary>
        /// Restores Furcadia Firewall/TLS settings
        /// <para>
        /// This allows a 10 second delay for client news feeder update
        /// </para>
        /// </summary>
        /// <param name="source">
        /// Timer Object
        /// </param>
        /// <param name="e">
        /// Elapsed Event Arguments
        /// </param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            /// reset settings.ini
            Settings.RestoreFurcadiaSettings(BackupSettings);
            BackupSettings = null;
            FurcSettingsRestored?.Invoke();
        }

        #endregion Private Methods
    }
}