using System;
using System.Threading;

namespace Furcadia.Net.Pounce
{
    /// <summary>
    /// Generic Pounce Client class.
    /// <para>
    /// Pounce Server runs on a 30 second Cron-Job
    /// </para>
    /// </summary>
    public class PounceClient : PounceConnection, IDisposable
    {
        #region Private Fields

        /// <summary>
        /// Pounce Timer on 30 second Interval
        /// </summary>
        private Timer PounceTimer;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Defailt Constructor
        /// </summary>
        public PounceClient() : base()
        {
            PounceTimer = new Timer(PounceCallBack, null, 0, 3000);
        }

        /// <summary>
        /// </summary>
        /// <param name="url">
        /// Pounce Server URL IE: on.furcadia.com
        /// </param>
        /// <param name="shortN_friends">
        /// Friends List in Furcadia Short-name format
        /// </param>
        public PounceClient(string url, params string[] shortN_friends) : base(url, shortN_friends)
        {
            // Initialize Defaults
            new PounceClient();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// Process Our Lists to see whose on or off line
        /// </summary>
        /// <param name="state">
        /// </param>
        private void PounceCallBack(object state)
        {
            ConnectAsync();
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
                    if (PounceTimer != null)
                        PounceTimer.Dispose();
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