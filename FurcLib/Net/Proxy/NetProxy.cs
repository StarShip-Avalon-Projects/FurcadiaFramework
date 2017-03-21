using Furcadia.IO;
using System;
using System.Threading;

namespace Furcadia.Net
{
    [CLSCompliant(true)]
    public class NetProxy : BaseProxy, IDisposable
    {
        #region Public Fields

        /// <summary>
        /// </summary>
        public static DREAM Dream = new DREAM();

        public static FURRE Player = new FURRE();

        private int reconnectmax = 5;

        /// <summary>
        /// </summary>
        private int RelogCounter;

        /// <summary>
        /// Maximum tries to reconnect to the server
        /// </summary>
        public int ReconnectMax
        {
            get { return reconnectmax; }
            set { reconnectmax = value; }
        }

        #endregion Public Fields

        #region Protected Fields

        protected short loggingIn = 0;

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
        private Mutex FurcMutex;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// </summary>
        public NetProxy()
        {
            ServerParser = new ParseServer(ref Dream, ref Player);
            ServQue = new ServerQue();
            ServQue.QueSent += OnServerSent;
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

        public short LoggingIn
        {
            get { return loggingIn; }
            set { loggingIn = value; }
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
                    if (FurcMutex != null) FurcMutex.Dispose();

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