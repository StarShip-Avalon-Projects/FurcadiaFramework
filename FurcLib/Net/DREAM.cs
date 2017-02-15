using System;
using System.Collections.Generic;

namespace Furcadia.Net
{
    /// <summary>
    /// Current Dream information
    /// </summary>
    [CLSCompliant(true)]
    public class DREAM : IDisposable
    {
        /// <summary>
        /// Dream List
        /// Furcadia requires Clients to handle thier own Dream Lists
        /// See http://dev.furcadia.com/docs New Movement for Spawn and Remove packets
        /// **Spawn is out dated.
        ///   New information requires a 4byte for AFK flag at the end
        /// </summary>
        public FURREList FurreList;

        private string _Name, _Title, _Lines, _Rating, _URL, _Owner;

        public int Default { get; set; }

        public DREAM()
        {
            FurreList = new FURREList();
        }

        public string Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Lines
        {
            get { return _Lines; }
            set { _Lines = value; }
        }

        public string Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }

        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

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

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DREAM() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}