/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (March 2017, 0.1) Gerolkae, Initial creation
 */

using System;
using System.Collections.Generic;
using System.Threading;

namespace Furcadia.Net.Utils
{
    /// <summary>
    /// Balance the load to the server
    /// <para>
    /// Handles Throat-Tired and No Endurance
    /// </para>
    /// </summary>
    public class ServerQue : IDisposable
    {
        #region Internal Fields

        internal const int MASS_NOENDURANCE = 2048;

        #endregion Internal Fields

        #region Private Fields

        private const int MASS_CRITICAL = 1600;
        private const int MASS_DECAYPS = 400;
        private const int MASS_DEFAULT = 80;
        private const int MASS_SPEECH = 1000;
        private double g_mass = 0;

        private System.Threading.Timer PingTimer;
        private System.Threading.Timer QueueTimer;

        /// <summary>
        /// Stack of commands to the server
        /// </summary>
        private Queue<string> ServerStack = new Queue<string>(500);

        private System.Threading.Timer TroatTiredDelay;

        #endregion Private Fields

        #region Private Constructors

        private object QueueTimerState = new object();

        private ServerQue(string message)
        {
            object QueueTimerState = new object();
            QueueTimer = new System.Threading.Timer(TroatTiredProcessTick, QueueTimerState, 0, 75);
        }

        #endregion Private Constructors

        #region Public Delegates

        /// <summary>
        /// Event Handler to notify calling class data has been sent to the game server
        /// </summary>
        /// <param name="message">
        /// </param>
        /// <param name="args">
        /// </param>
        public delegate void SendServerEventHandler(object message, System.EventArgs args);

        #endregion Public Delegates

        #region Connection Timers

        /// <summary>
        /// NoEndurance. Send data at the speed of the server
        /// </summary>
        private bool noendurance;

        /// <summary>
        /// Throat Tired System.
        /// <para>
        /// Pause sending data to server if we get a message we tried to send too much at one time
        /// </para>
        /// </summary>
        private bool throattired;

        private DateTime TickTime = DateTime.Now;

        /// <summary>
        /// ping interlock exchange
        /// </summary>
        private int usingPing = 0;

        /// <summary>
        /// throat tired interlock exchange
        /// </summary>
        private int usingThroatTired = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public ServerQue()
        {
            ThroatTired = false;
            ServerStack.Clear();
            g_mass = 0;
        }

        /// <summary>
        /// Is the connect `noendurance enabled?
        /// </summary>
        public bool NoEndurance
        {
            get { return noendurance; }
            set { noendurance = value; }
        }

        /// <summary>
        /// If Proxy get "Your throat is tired" Pause for a number of seconds
        /// </summary>
        public bool ThroatTired
        {
            get { return throattired; }
            set { throattired = value; }
        }

        /// <summary>
        /// Load Balancing Function
        /// <para>
        /// this makes sure we don't over load what the server can handle
        /// </para>
        /// <para>
        /// Proxy has 2 modes of operation
        /// </para>
        /// <para>
        /// Mode 1 Normal. handles Throat Tired syndrome with a time out timer to resume
        /// </para>
        /// <para>
        /// Mode 2 NoEndurance. Send data to server as fast as it can handle with out overloading its buffer
        /// </para>
        /// </summary>
        /// <param name="DelayTime">
        /// Delay Time in Milliseconds
        /// </param>
        public void QueueTick(double DelayTime)
        {
            if (ServerStack.Count == 0)
                return;
            if (DelayTime != 0)
            {
                DelayTime = Math.Round(DelayTime, 0) + 1;
            }

            /* Send buffered speech. */
            double decay = Math.Round(DelayTime * MASS_DECAYPS / 1000f, 0);
            if ((decay > g_mass))
            {
                g_mass = 0;
            }
            else
            {
                g_mass -= decay;
            }

            if (noendurance)
            {
                /* just send everything right away */
                while (ServerStack.Count > 0 & g_mass <= MASS_CRITICAL)
                {
                    g_mass += ServerStack.Peek().Length + MASS_DEFAULT;
                    OnServerSendMessage(ServerStack.Dequeue(), System.EventArgs.Empty);
                }
            }
            else if (!ThroatTired)
            {
                // Only send a speech line if the mass will be under the limit. */
                while (ServerStack.Count > 0 & g_mass + MASS_SPEECH <= MASS_CRITICAL)
                {
                    g_mass += ServerStack.Peek().Length + MASS_DEFAULT;
                    OnServerSendMessage(ServerStack.Dequeue(), System.EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Incoming Messages for server processing
        /// </summary>
        /// <param name="data">
        /// </param>
        public void SendToServer(string data)
        {
            if (string.IsNullOrEmpty(data))
                return;
            ServerStack.Enqueue(data);
            if (g_mass + MASS_SPEECH <= MASS_CRITICAL)
            {
                QueueTick(0);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="state">
        /// </param>
        public void TroatTiredProcessTick(object state)
        {
            if (0 == Interlocked.Exchange(ref usingThroatTired, 1))
            {
                double seconds = DateTime.Now.Subtract(TickTime).Milliseconds;
                QueueTick(seconds);
                TickTime = DateTime.Now;
                Interlocked.Exchange(ref usingThroatTired, 0);
            }
        }

        private void PingTimerTick(object state)
        {
            if ((0 == Interlocked.Exchange(ref usingPing, 1)))
            {
                if (g_mass + MASS_SPEECH <= MASS_CRITICAL)
                {
                    ServerStack.Enqueue("Ping");
                }
                Interlocked.Exchange(ref usingPing, 0);
            }
        }

        private void TroatTiredDelayTick(object state)
        {
            ThroatTired = false;
            TroatTiredDelay.Dispose();
        }

        #endregion Connection Timers

        #region Protected Methods

        /// <summary>
        /// Message to Server Event.
        /// </summary>
        public EventHandler OnServerSendMessage;

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        /// <summary>
        /// This code added to correctly implement the disposable pattern.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    if (TroatTiredDelay != null)
                        TroatTiredDelay.Dispose();
                    PingTimer.Dispose();
                    QueueTimer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~ServerQue() { // Do not change this code. Put cleanup code in
        // Dispose(bool disposing) above. Dispose(false); }

        #endregion IDisposable Support

        #endregion Protected Methods
    }
}