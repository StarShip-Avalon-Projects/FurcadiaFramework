using Furcadia.IO;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Furcadia.Net
{
    /// <summary>
    /// Generic Proxy handler
    /// <para>
    /// Full functional proxy engine
    /// </para>
    /// <para>
    /// Tracks the Furcadia Connection
    /// </para>
    /// <para>
    /// Dream Status? FurreList DreamOwner Dream Title
    /// </para>
    /// </summary>
    [CLSCompliant(true)]
    public class ProxySession : IDisposable
    {
        /// <summary>
        /// base proxy class
        /// </summary>
        protected NetProxy FurcadiaProxy;

        /// <summary>
        /// Snap in Send to server Buffer
        /// </summary>
        protected ServerQue ServQue;

        /// <summary>
        /// ServerData Parser
        /// </summary>
        protected ParseServer ServerParser;

        public static DREAM Dream = new DREAM();
        public static FURRE Player = new FURRE();

        public Mutex FurcMutex;

        private static int _FurcProcessId;
        protected bool NoEndurance = false;
        protected bool ThroatTired = false;

        protected Queue<string> BadgeTag = new Queue<string>(10);
        protected Queue<string> LookQue = new Queue<string>(10);
        protected Queue<string> SpeciesTag = new Queue<string>(10);

        protected Timer ReconnectTimer;
        protected Timer ReconnectTimeOutTimer;
        protected Timer TroatTiredDelay;
        public int RelogCounter;

        protected short loggingin = 0;

        public short LoggingIn
        {
            get { return loggingin; }
            set { loggingin = value; }
        }

        protected void TroatTiredDelayTick(object state)
        {
            ThroatTired = false;
            this.TroatTiredDelay.Dispose();
        }

        /// <summary>
        /// Current Process ID of the Furcadia Client we're connected too
        /// </summary>
        /// <returns>
        /// Furcadia Process Id
        /// </returns>
        public static int FurcProcessId
        {
            get { return _FurcProcessId; }
            set { _FurcProcessId = value; }
        }

        protected event NetProxy.ErrorEventHandler error;

        protected event NetProxy.DataEventHandler2 ClientDataReceived;

        protected event NetProxy.DataEventHandler2 ServerDataReceived;

        protected event NetProxy.ActionDelegate ServerDisConnected;

        protected event NetProxy.ActionDelegate ClientExited;

        protected event NetProxy.ActionDelegate Connected;

        /// <summary>
        /// </summary>
        public ProxySession()
        {
            ServerParser = new ParseServer(ref Dream, ref Player);
            FurcadiaProxy = new NetProxy();
            FurcadiaProxy.Error += error;
            FurcadiaProxy.ClientData2 += ClientDataReceived;
            FurcadiaProxy.ServerData2 += ServerDataReceived;
            FurcadiaProxy.Connected += Connected;
            ServQue = new ServerQue();
            ServQue.QueSent += OnServerSent;
        }

        /// <summary>
        /// Server Que handler
        /// <para>
        /// Be careful not to Overload the server Buffer
        /// </para>
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="">
        /// </param>
        public void OnServerSent(object source, System.EventArgs e)
        {
            FurcadiaProxy.SendServer(source.ToString());
        }

        /// <summary>
        /// Forward calls to our Proxy buffer
        /// </summary>
        /// <param name="message">
        /// </param>
        public void SendServer(string message)
        {
            ServQue.SndToServer(message);
        }

        /// <summary>
        /// Sends Data to the Client
        /// </summary>
        /// <param name="message">
        /// </param>
        public virtual void SendClient(string message)
        {
            FurcadiaProxy.SendClient(message);
        }

        /// <summary>
        /// </summary>
        /// <param name="ID">
        /// </param>
        /// <returns>
        /// </returns>
        public FURRE fIDtoFurre(ref int ID)
        {
            foreach (FURRE Char in Dream.FurreList)
            {
                if (Char.ID == ID)
                {
                    return Char;
                }
            }
            return null;
        }

        //        protected virtual void ReconnectTick(object state)
        //        {
        //#if DEBUG
        //            Console.WriteLine("ReconnectTick()");
        //#endif
        //            TimeSpan Ts = TimeSpan.FromSeconds(45);
        //           ReconnectTimeOutTimer = new Timer(ReconnectTimeOutTick, null, Ts, Ts);

        // if (Main.MainSettings.CloseProc & ProcExit == false) { KillProc(FurcProcessId); } if
        // ((FurcadiaProxy != null)) { FurcadiaProxy.Kill(); } try { ConnectBot(); } catch
        // (NetProxyException Ex) { // if ((FurcMutex != null)) { FurcMutex.Close();
        // FurcMutex.Dispose(); } DisconnectBot(); sndDisplay("Connection Aborting: " + Ex.Message); }

        // }

        // private void ReconnectTimeOutTick(object Obj) { if (InvokeRequired) { object[] dataArray =
        // { Obj }; Invoke(new UpDateBtn_GoCallback3(ReconnectTimeOutTick), dataArray);

        //#if DEBUG
        //                Console.WriteLine("ReconnectTimeOutTick()");
        //                Console.WriteLine(string.Format("ReLogCounter: {0}",  RelogCounter.ToString()));
        //#endif

        // //DisconnectBot() if (MainSettings.CloseProc & ProcExit == false) { KillProc(FurcProcessId);

        // } if ((FurcadiaProxy != null)) { FurcadiaProxy.Kill(); }

        // try { ConnectBot(); sndDisplay("Reconnect attempt: " + ReLogCounter.ToString()); if
        // (ReLogCounter == MainSettings.ReconnectMax) { ReconnectTimeOutTimer.Dispose();
        // sndDisplay("Reconnect attempts exceeded.");

        // //event reconnect exceded

        // //BTN_Go.Text = "Go!" //TS_Status_Server.Image = My.Resources.images2
        // //TS_Status_Client.Image = My.Resources.images2 //ConnectTrayIconMenuItem.Enabled = False
        // //DisconnectTrayIconMenuItem.Enabled = True if ((FurcMutex != null)) { FurcMutex.Close();
        // FurcMutex.Dispose(); }

        // } ReLogCounter += 1; } catch (NetProxyException Ex) { // if ((FurcMutex != null)) {
        // FurcMutex.Close(); FurcMutex.Dispose(); } DisconnectBot(); sndDisplay("Connection
        // Aborting: " + Ex.Message);

        // } } }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~ProxySession() { // Do not change this code. Put cleanup code
        // in Dispose(bool disposing) above. Dispose(false); }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}