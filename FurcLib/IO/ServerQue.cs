using System;
using System.Collections.Generic;
using System.Threading;

namespace Furcadia.IO
{
    /// <summary>
    /// Balance the load to the server
    /// <para>Handles Throat-Tired and No Endurance</para>
    /// </summary>
    public class ServerQue
    {
        private double g_mass = 0;
        public const int MASS_DEFAULT = 80;
        public const int MASS_SPEECH = 1000;
        public const int MASS_CRITICAL = 1600;
        public const int MASS_NOENDURANCE = 2048;

        private const int MASS_DECAYPS = 400;

        private Queue<string> ServerStack = new Queue<string>(500);

        public delegate void SendServerEventHandler(object message, System.EventArgs args);

        public event SendServerEventHandler QueSent;

        private System.Threading.Timer TroatTiredProc;
        private System.Threading.Timer TroatTiredDelay;
        private System.Threading.Timer PingTimer;

        private ServerQue(string message)
        {
        }

        private const char LF = '\n';

        #region "Connection Timers"

        /// <summary>
        /// NoEndurance. Send data at the speed of the server
        /// </summary>
        private bool noendurance;

        public bool NoEndurance
        {
            get { return noendurance; }
            set { noendurance = value; }
        }

        /// <summary>
        /// Throat Tired System.
        /// <para>Pause sending data to server if we get a message we tried to send too much at one time</para>
        /// </summary>
        private bool throattired;

        public bool ThroatTired
        {
            get { return throattired; }
            set { throattired = value; }
        }

        private int usingPing = 0;

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

        private DateTime TickTime = DateTime.Now;
        private int usingResource = 0;

        public void TroatTiredProcTick(object state)
        {
            if ((0 == Interlocked.Exchange(ref usingResource, 1)))
            {
                double seconds = DateTime.Now.Subtract(TickTime).Milliseconds;
                on_Tick(seconds);
                TickTime = DateTime.Now;
                Interlocked.Exchange(ref usingResource, 0);
            }
        }

        /// <summary>
        /// Load Balancing Function
        /// <para>this makes sure we don't over load what the server can handle</para>
        /// <para>Bot has 2 modes of operation</para>
        /// <para>Mode 1 Normal. Prepare for Throat Tired syndrome</para>
        /// <para>Mode 2 NoEndurance. Send data to server as fast as it can handle with lout overloading its buffer</para>
        /// </summary>
        /// <param name="dt"></param>
        public void on_Tick(double dt)
        {
            if (ServerStack.Count == 0)
                return;
            if (dt != 0)
            {
                dt = Math.Round(dt, 0) + 1;
            }

            ///* Send buffered speech. */
            double decay = Math.Round(dt * MASS_DECAYPS / 1000f, 0);
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
                ///* just send everything right away */
                while (ServerStack.Count > 0 & g_mass <= MASS_CRITICAL)
                {
                    g_mass += ServerStack.Peek().Length + MASS_DEFAULT;
                    QueSent(ServerStack.Dequeue() + LF, System.EventArgs.Empty);
                }
            }
            else if (!ThroatTired)
            {
                // Only send a speech line if the mass will be under the limit. */
                while (ServerStack.Count > 0 & g_mass + MASS_SPEECH <= MASS_CRITICAL)
                {
                    g_mass += ServerStack.Peek().Length + MASS_DEFAULT;
                    QueSent(ServerStack.Dequeue() + LF, System.EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Incoming Messages for server processing
        ///
        /// </summary>
        /// <param name="data"></param>
        public void SndToServer(string data)
        {
            if (string.IsNullOrEmpty(data))
                return;
            ServerStack.Enqueue(data);
            if (g_mass + MASS_SPEECH <= MASS_CRITICAL)
            {
                on_Tick(0);
            }
        }

        private void TroatTiredDelayTick(object state)
        {
            ThroatTired = false;
            TroatTiredDelay.Dispose();
        }

        //dispose?
        public ServerQue()
        {
            if ((TroatTiredDelay != null))
                TroatTiredDelay.Dispose();
            ThroatTired = false;
            ServerStack.Clear();
            g_mass = 0;
        }

        #endregion "Connection Timers"

        protected virtual void OnServerSent()
        {
            if (QueSent != null)
                QueSent(this, System.EventArgs.Empty);
        }
    }
}