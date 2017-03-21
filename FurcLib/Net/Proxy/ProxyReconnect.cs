using System;
using System.Threading;

namespace Furcadia.Net
{
    internal class ProxyReconnect : IDisposable
    {
        #region Protected Fields

        /// <summary>
        /// Connection Time Out timer.
        /// <para>
        /// How long to wait before closing the Connection and starting the Next reconnect attempt
        /// </para>
        /// </summary>
        protected Timer ReconnectTimeOutTimer;

        /// <summary>
        /// delay till the next reconnect attempt
        /// </summary>
        protected Timer ReconnectTimer;

        #endregion Protected Fields

        #region Private Fields

        /// <summary>
        /// Max tries to reconnect to server before aborting
        /// </summary>
        private int reconnectmax = 5;

        /// <summary>
        /// </summary>
        private int RelogCounter;

        #endregion Private Fields

        #region Public Constructors

        public ProxyReconnect()
        {
        }

        #endregion Public Constructors

        #region Public Properties

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
        /// </summary>
        /// <param name="state">
        /// </param>
        protected virtual void ReconnectTick(object state)
        {
#if DEBUG
            Console.WriteLine("ReconnectTick()");
#endif
            TimeSpan Ts = TimeSpan.FromSeconds(45);
            ReconnectTimeOutTimer = new Timer(ReconnectTimeOutTick, null, Ts, Ts);

            //if (Main.MainSettings.CloseProc & ProcExit == false)
            //{
            //    KillProc(FurcProcessId);
            //}
            try
            {
                Connect();
            }
            catch (NetProxyException Ex)
            {
                if ((FurcMutex != null))
                {
                    FurcMutex.Close();
                    FurcMutex.Dispose();
                }
                Kill();
                // sndDisplay("Connection Aborting: " + Ex.Message);
            }
        }

        #endregion Protected Methods

        #region Private Methods

        private void ReconnectTimeOutTick(object Obj)
        {
#if DEBUG
            Console.WriteLine("ReconnectTimeOutTick()");
            Console.WriteLine(string.Format("ReLogCounter: {0}", RelogCounter.ToString()));
#endif

            try
            {
                Connect();
                //sndDisplay("Reconnect attempt: " + ReLogCounter.ToString());
                if (RelogCounter == reconnectmax)
                {
                    ReconnectTimeOutTimer.Dispose();
                    //sndDisplay("Reconnect attempts exceeded.");

                    //event reconnect exceded

                    //BTN_Go.Text = "Go!" //TS_Status_Server.Image = My.Resources.images2
                    //TS_Status_Client.Image = My.Resources.images2 //ConnectTrayIconMenuItem.Enabled = False
                    //DisconnectTrayIconMenuItem.Enabled = True if ((FurcMutex != null)) { FurcMutex.Close();
                    FurcMutex.Dispose();
                }
            }
            finally
            { //
                if (FurcMutex != null)
                {
                    FurcMutex.Close();
                    FurcMutex.Dispose();
                }

                Kill();
                //sndDisplay("Connection Aborting: " + Ex.Message);
            }

            RelogCounter++;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
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

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ProxyReconnect() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #endregion Private Methods
    }
}