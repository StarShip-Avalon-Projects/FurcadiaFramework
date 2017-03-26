using Furcadia.Net.Utils;
using System;
using System.Collections.Generic;

namespace Furcadia.Net
{
    /// <summary>
    /// Base Furcadia Session Class
    /// </summary>
    /// <remarks>
    /// Here we provide a reconnection system in case there is an error in the Furcadia connection.
    /// </remarks>
    public class ProxySession : NetProxy, IDisposable
    {
        #region Private Fields

        /// <summary>
        /// Furcadia Reconnection system.
        /// </summary>
        private Net.Utils.ProxyReconnect FurcReconnect;

        #endregion Private Fields

        #region Protected Fields

        protected Queue<string> BadgeTag = new Queue<string>(10);
        protected Queue<string> LookQue = new Queue<string>(10);
        protected Queue<string> SpeciesTag = new Queue<string>(10);

        #endregion Protected Fields

        #region Public Constructors

        /// <summary>
        /// </summary>
        public ProxySession()
        {
            NewFurcReconnect();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// </summary>
        public void Connect(object sender, System.EventArgs e)
        {
            base.Connect();
        }

        /// <summary>
        /// Connect to the Furcadia Server.
        /// <para>
        /// Overrides base Connect() to use out Reconnect system.
        /// </para>
        /// </summary>
        public override void Connect()
        {
            FurcReconnect.Start();
        }

        /// <summary>
        /// </summary>
        public void NewFurcReconnect()
        {
            //Reconnection System
            FurcReconnect = new ProxyReconnect();
            FurcReconnect.OnStartProxyConnect += Connect;
            FurcReconnect.OnConnectTimeOut += ConnectionTimedOut;
            FurcReconnect.OnAttemptsExceded += AttemptsExceded;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender">
        /// </param>
        /// <param name="e">
        /// </param>
        private void AttemptsExceded(object sender, EventArgs e)
        {
            //Proxy.Disconnect;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// We timed out connecting, Disconnect proxy and wait till next reconnect.
        /// </summary>
        /// <param name="sender">
        /// </param>
        /// <param name="e">
        /// </param>
        private void ConnectionTimedOut(object sender, System.EventArgs e)
        {
            //Proxy.Disconnect();
        }

        #endregion Private Methods

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (FurcReconnect != null)
                        FurcReconnect.Dispose(disposing);
                    base.Dispose(disposing);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~ProxySession() { // Do not change this code. Put cleanup code
        //       in Dispose(bool
        // disposing) above. Dispose(false); }

        #endregion IDisposable Support
    }
}