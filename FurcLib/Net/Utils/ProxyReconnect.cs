using System;
using System.Threading;

namespace Furcadia.Net.Utils
{
    internal class ProxyReconnect : IDisposable
    {
        #region Private Fields

        private bool isrunning;

        /// <summary>
        /// Max tries to reconnect to server before aborting
        /// </summary>
        private int reconnectmax;

        /// <summary>
        /// the time delay for the current connection attempt in seconds
        /// </summary>
        private TimeSpan reconnecttimeout;

        /// <summary>
        /// Connection Time Out timer.
        /// <para>
        /// How long to wait before closing the Connection and starting the Next reconnect attempt
        /// </para>
        /// </summary>
        private Timer ReconnectTimeOutTimer;

        /// <summary>
        /// delay till the next reconnect attempt
        /// </summary>
        private Timer ReconnectTimer;

        /// <summary>
        /// Current Attempt to reconnect
        /// </summary>
        private int RelogCounter;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Defaults to max 5 connects and delay cycle of 45 seconds.
        /// </summary>
        public ProxyReconnect()
        {
            isrunning = false;
            RelogCounter = 0;
            reconnectmax = 5;
            reconnecttimeout = TimeSpan.FromSeconds(45 / 2);
        }

        /// <summary>
        /// </summary>
        /// <param name="Attempts">
        /// Number of max reconnect attempts
        /// </param>
        /// <param name="TimeOutDelay">
        /// Cycle delay in seconds
        /// </param>
        public ProxyReconnect(int Attempts, int TimeOutDelay)
        {
            isrunning = false;
            RelogCounter = 0;
            reconnectmax = Attempts;
            reconnecttimeout = TimeSpan.FromSeconds(TimeOutDelay / 2);
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// the time delay for the current connection attempt in seconds.
        /// </summary>
        public int ConnectionTimeOut
        {
            get { return reconnecttimeout.Seconds * 2; }
            set { reconnecttimeout = TimeSpan.FromSeconds(value / 2); }
        }

        /// <summary>
        /// Is there a reconnection process running?
        /// </summary>
        public bool IsRunning
        {
            get { return isrunning; }
        }

        /// <summary>
        /// Maximum tries to reconnect to the server
        /// </summary>
        public int ReconnectMax
        {
            get { return reconnectmax; }
            set { reconnectmax = value; }
        }

        #endregion Public Properties

        #region Protected Methods

        /// <summary>
        /// this begins the Connection Attempt
        /// <para>
        /// IE: Proxy.Connect()
        /// </para>
        /// </summary>
        /// <param name="state">
        /// </param>
        protected virtual void ReconnectAttemptTick(object state)
        {
#if DEBUG
            Console.WriteLine("ReconnectAttemptTick()");
#endif

            if (ReconnectTimeOutTimer == null)
                ReconnectTimeOutTimer = new Timer(ReconnectTimeOutTick, state, reconnecttimeout, TimeSpan.MaxValue);
            else
                ReconnectTimeOutTimer.Change(reconnecttimeout, TimeSpan.MaxValue);

            OnStartProxyConnect(string.Format("Reconnect attempt {0}/{1} begin.", RelogCounter, reconnectmax.ToString()), System.EventArgs.Empty);

            //Stop current timer and wait for ReconnectTimeOutTimer to time out
            ReconnectTimer.Change(Timeout.Infinite, Timeout.Infinite);
            //if (Main.MainSettings.CloseProc & ProcExit == false)
            //{
            //    KillProc(FurcProcessId);
            //}
            //try
            //{
            //    Connect();
            //}
            //catch (NetProxyException Ex)
            //{
            //    if ((FurcMutex != null))
            //    {
            //        FurcMutex.Close();
            //        FurcMutex.Dispose();
            //    }
            //    Kill();
            //    sndDisplay("Connection Aborting: " + Ex.Message);
            //}
        }

        #endregion Protected Methods

        #region Private Methods

        /// <summary>
        /// Current Attempt timed out, begin the next attempt
        /// </summary>
        /// <param name="Obj">
        /// State Object
        /// </param>
        private void ReconnectTimeOutTick(object Obj)
        {
#if DEBUG
            Console.WriteLine("ReconnectTimeOutTick()");
            Console.WriteLine();
#endif
            if (RelogCounter >= reconnectmax)
            {
                OnAttemptsExceded(string.Format("Connection attempts exceeded!!!"), System.EventArgs.Empty);
                Dispose(true);
                return;
            }
            OnConnectTimeOut(string.Format("Connection attempt timed out."), System.EventArgs.Empty);

            //Begin next connection attempt in x seconds
            if (ReconnectTimeOutTimer == null)
                ReconnectTimeOutTimer = new Timer(ReconnectAttemptTick, Obj, reconnecttimeout, TimeSpan.MaxValue);
            else
                ReconnectTimeOutTimer.Change(reconnecttimeout, TimeSpan.MaxValue);

            //stop current timer and wait for reconnectTimeOut timer to finish
            ReconnectTimer.Change(Timeout.Infinite, Timeout.Infinite);

            //try
            //{
            //    Connect();
            //    //sndDisplay("Reconnect attempt: " + ReLogCounter.ToString());
            //    if (RelogCounter == reconnectmax)
            //    {
            //        ReconnectTimeOutTimer.Dispose();
            //        //sndDisplay("Reconnect attempts exceeded.");

            // //event reconnect exceded

            //        //BTN_Go.Text = "Go!" //TS_Status_Server.Image = My.Resources.images2
            //        //TS_Status_Client.Image = My.Resources.images2 //ConnectTrayIconMenuItem.Enabled = False
            //        //DisconnectTrayIconMenuItem.Enabled = True if ((FurcMutex != null)) { FurcMutex.Close();
            //        FurcMutex.Dispose();
            //    }
            //}
            //finally
            //{ //
            //    if (FurcMutex != null)
            //    {
            //        FurcMutex.Close();
            //        FurcMutex.Dispose();
            //    }

            //    Kill();
            //    //sndDisplay("Connection Aborting: " + Ex.Message);
            //}

            RelogCounter++;
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (ReconnectTimeOutTimer != null)
                        ReconnectTimeOutTimer.Dispose();
                    if (ReconnectTimer != null)
                        ReconnectTimer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~ProxyReconnect() { // Do not change this code. Put cleanup
        // code in Dispose(bool disposing) above. Dispose(false); }

        #endregion IDisposable Support

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        /// Skips the current connection attempt and go to ReconnectTimeOutTimer
        /// </summary>
        public virtual void SkipAttempt()
        {
            ReconnectTimeOutTick(null);
        }

        /// <summary>
        /// Starts the reconnection sequence.
        /// </summary>
        public void Start()
        {
            if (isrunning)
                throw new Exception("Reconnection process has already started!");
            //begin the process immediately
            ReconnectTimeOutTimer = new Timer(ReconnectAttemptTick, null, TimeSpan.Zero, reconnecttimeout);
            isrunning = true;
        }

        /// <summary>
        /// Stops the reconnection sequence.
        /// </summary>
        public void Stop()
        {
            ReconnectTimeOutTimer.Change(Timeout.Infinite, Timeout.Infinite);
            ReconnectTimer.Change(Timeout.Infinite, Timeout.Infinite);
            isrunning = false;
        }

        #endregion Public Methods

        #region Reconnect Events

        /// <summary>
        /// We failed to reconnect and we aborted.
        /// </summary>
        public EventHandler OnAttemptsExceded;

        /// <summary>
        /// Current connection to server timed out,
        /// <para>
        /// Stop the connection attempt and wait for the next attempt
        /// </para>
        /// <para>
        /// IE: Proxy.Disconnect()
        /// </para>
        /// </summary>
        public EventHandler OnConnectTimeOut;

        /// <summary>
        /// we've started the connection attempt
        /// <para>
        /// IE: Proxy.Connect()
        /// </para>
        /// </summary>
        public EventHandler OnStartProxyConnect;

        #endregion Reconnect Events
    }
}