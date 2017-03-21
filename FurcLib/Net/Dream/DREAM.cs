using System;

namespace Furcadia.Net
{
    /// <summary>
    /// Current Dream information
    /// </summary>
    [CLSCompliant(true)]
    public class DREAM : IDisposable
    {
        #region Public Fields

        /// <summary>
        /// Dream List Furcadia requires Clients to handle thier own Dream Lists See
        /// <para>
        /// http://dev.furcadia.com/docs New Movement for Spawn and Remove packets
        /// </para>
        /// <para>
        /// **Spawn is out dated. New information requires a 4byte for AFK flag at the end
        /// </para>
        /// <para>
        /// As of V31, Color code has changed.
        /// </para>
        /// </summary>
        public FURREList FurreList;

        #endregion Public Fields

        #region Private Fields

        /// <summary>
        /// private variables
        /// </summary>
        private string _Name, _Title, _Lines, _Rating, _URL, _Owner;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// List of Furres in the dream.
        /// </summary>
        public DREAM()
        {
            FurreList = new FURREList();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Number of DS Lines
        /// </summary>
        public string Lines
        {
            get { return _Lines; }
            set { _Lines = value; }
        }

        /// <summary>
        /// Name of the dream
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Dreams uploader character
        /// </summary>
        public string Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        /// <summary>
        /// Furcadia Dream rating
        /// </summary>
        public string Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }

        /// <summary>
        /// Dream title
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        /// <summary>
        /// Dreams full Furcadia Drean URL
        /// <para>
        /// IE: 'fdl furc://DreamOwner:DreamTitle/EntryCode#
        /// </para>
        /// </summary>
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }

        #endregion Public Properties

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

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
        //       unmanaged resources. ~DREAM() { // Do not change this code. Put cleanup code in
        // Dispose(bool disposing) above. Dispose(false); }

        #endregion IDisposable Support
    }
}