using Furcadia.Net.Utils;
using System;

namespace Furcadia.Net
{
    /// <summary>
    /// Generic Proxy handler for any derived Proxy.
    /// </summary>
    /// <remarks>
    /// Here we manage the Current Dream infomation and the Triggering Furre as part of our proxy connection.
    /// </remarks>
    [CLSCompliant(true)]
    public class NetProxy : BaseProxy, IDisposable
    {
        #region Public Fields

        /// <summary>
        /// Current active dream info our proxy is in.
        /// </summary>
        public static DREAM Dream = new DREAM();

        /// <summary>
        /// Current triggering furre
        /// </summary>
        public static FURRE Player = new FURRE();

        #endregion Public Fields

        #region Protected Fields

        /// <summary>
        /// ServerData Parser
        /// </summary>
        protected ParseServer ServerParser;

        /// <summary>
        /// Snap in Send to server Buffer
        /// </summary>
        protected ServerQue ServQue;

        #endregion Protected Fields

        #region Private Fields

        private static int _FurcProcessId;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// NetProxy Constructor with defaults
        /// </summary>
        public NetProxy()
        {
            ServerParser = new Net.Utils.ParseServer(ref Dream, ref Player);
            ServQue = new ServerQue();
            ServQue.OnServerSendMessage += OnServerSent;
        }

        #endregion Public Constructors

        #region Public Properties

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

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// </summary>
        /// <param name="ID">
        /// </param>
        /// <returns>
        /// </returns>
        public FURRE fIDtoFurre(int ID)
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

        /// <summary>
        /// Server Que handler
        /// <para>
        /// Be careful not to Overload the server Buffer
        /// </para>
        /// </summary>
        /// <param name="source">
        /// </param>
        /// <param name="e">
        /// Event Args
        /// </param>
        public void OnServerSent(object source, System.EventArgs e)
        {
            SendServer(source.ToString());
        }

        /// <summary>
        /// Forward calls to our Proxy buffer
        /// </summary>
        /// <param name="message">
        /// </param>
        public override void SendServer(string message)
        {
            ServQue.SendToServer(message);
        }

        #endregion Public Methods

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
                    if (ServQue != null)
                        ServQue.Dispose(disposing);
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