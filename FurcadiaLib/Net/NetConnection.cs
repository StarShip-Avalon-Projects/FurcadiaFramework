/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (?,2007) Kylix, Initial Coder and SimpleProxy project manager
 * (Oct 27,2009) Squizzle, Added NetMessage, delegates, and NetProxy wrapper class.
 * (July 26, 2011) Gerolkae, added setting.ini switch for proxy.ini
 * (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path
 */

using System;
using System.Diagnostics;
using System.Security.Permissions;
//using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using Furcadia.IO;
using System.Net.NetworkInformation;

using System.Timers;
/// using System.Timers.Timer;

namespace Furcadia.Net
{
	
	public class NetConnection
	{

		#region Event Handling
		public delegate void ActionDelegate();
		public delegate void DataEventHandler2(string data);

        public delegate void ErrorEventHandler(Exception e, Object o, String n);
        //public delegate void ErrorEventHandler(Exception e);
		/// <summary>
		///This is triggered when the 
		/// </summary>
		public event ActionDelegate Connected;
		/// <summary>
		///This is triggered when the Server Disconnects
		/// </summary>
		public event ActionDelegate ServerDisConnected;



		/// <summary>
		/// This is triggered when the Server sends data to the client. Doesn't expect a return value.
		/// </summary>
		public event DataEventHandler2 ServerData;

		/// <summary>
		/// This is triggered when a handled Exception is thrown.
		/// </summary>
		public event ErrorEventHandler Error;



		#endregion

		#region Private Declarations
		/// <summary>
		/// Max buffer size
		/// </summary>
		private static int BUFFER_CAP = 1024;
		private static int ENCODE_PAGE = 1252;
		private bool CConnected = false;
		private IPEndPoint _endpoint;
		private TcpClient server;
		private byte[] serverBuffer = new byte[BUFFER_CAP];
		private string _ServerLeftOvers;
		private string  serverBuild;

	  
		#endregion

		#region Constructors
        public Paths FurcPath;
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

		public NetConnection(int port)
		{
            FurcPath = new Paths();
			try
			{
				_endpoint = new IPEndPoint(Dns.GetHostEntry(Furcadia.Util.Host).AddressList[0], port);
			}
			catch { }
		}


		public NetConnection(string host, int port)
		{
            FurcPath = new Paths();
			try
			{
				_endpoint = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
			}
			catch { }
		}



		public NetConnection(IPAddress ip, int port)
		{
            FurcPath = new Paths();
			try
			{
				_endpoint = new IPEndPoint(ip, port);
			}
			catch { }
		}



		#endregion

		#region Properties
		

		/// <summary>
		/// Proxy is connected, or not.
		/// </summary>
		public bool IsServerConnected
		{
			get {
				if (server != null)
					return server.Connected;
				else
					return false; }
		}



		#endregion
		
		#region Public Static Properties
		public static int BufferCapacity{
			get{
				return BUFFER_CAP;
			}
		}
		
		public static int EncoderPage {
			get{
				return ENCODE_PAGE;
			}
		}
		#endregion

		#region Public Methods




		/// <summary>
		/// Connects to the Furcadia Server and starts the mini proxy.
		/// </summary>
		public void Connect()
		{
        
            //Start the async connect operation
            server = new TcpClient();
            server.BeginConnect(_endpoint.Address,_endpoint.Port, new AsyncCallback(AsyncListener), server);
		}


		public void SendServer (INetMessage message)
		{
			SendServer(message.GetString());
		}

		public void SendServer (string message)
		{
			try
			{
             
				if (server.GetStream ().CanWrite)
					server.GetStream ().Write (System.Text.Encoding.GetEncoding (EncoderPage).GetBytes (message), 0, System.Text.Encoding.GetEncoding(EncoderPage).GetBytes(message).Length);
			}
			catch (Exception e) 
            {
                if (Error != null) Error(e, this, "SendServer");
                if (ServerDisConnected != null) ServerDisConnected();
            }
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
					if (serverStream != null ) 
					{
						serverStream.Flush();
						serverStream.Dispose();
						serverStream.Close();
					}
				   server.Close();
				}
				
				
			}
			catch (Exception e) { if (Error != null) Error(e,this, "Kill()"); }
		}

		//Implement IDisposable.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				// Free other state (managed objects).
			}
			// Free your own state (unmanaged objects).
			// Set large fields to null.
		}


		#endregion

		#region Private Methods
		private void AsyncListener(IAsyncResult ar)
		{
			try
			{
				// Connects to the server
				server = new TcpClient(Util.Host,_endpoint.Port);
			if (!server.Connected) throw new Exception("There was a problem connecting to the server.");
				
				server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);

				if (Connected != null)
				{
					Connected();
									
				}
			}
			catch (Exception e) { if (Error != null) Error(e,this, "AsyncListener()");}
		}



private object lck = new object();
	
		private void GetServerData (IAsyncResult ar)
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
                            if (ServerDisConnected != null) { ServerDisConnected(); }
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
                            if ( ServerData != null)
                                ServerData(lines[i]);
                        }
                    }
                }
			
			catch (Exception e) 
			{
			   // if (IsServerConnected == true) ServerDisConnected();
				if (Error != null) Error(e, this, "GetServerData()");
                if (ServerDisConnected != null) ServerDisConnected();
                return;
			} //else throw e;
			// Detect if client disconnected
            if (IsServerConnected && serverBuild.Length < 1 || IsServerConnected == false)
            {
                if (ServerDisConnected != null) ServerDisConnected();

            }
               
			if (IsServerConnected && serverBuild.Length > 0)
				server.GetStream().BeginRead(serverBuffer, 0, serverBuffer.Length, new AsyncCallback(GetServerData), server);
							 
		}}
		#endregion
	}
}
