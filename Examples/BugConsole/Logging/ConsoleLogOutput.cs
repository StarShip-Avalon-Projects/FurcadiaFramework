#region Usings

using Furcadia.Logging;
using System;
using System.Diagnostics;
using System.Text;

#endregion Usings

namespace BugConsole.Logging
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Furcadia.Logging.ILogOutput" />
    public class ConsoleLogOutput : ILogOutput
    {
        ///private static readonly DateTime startTime = new DateTime();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogOutput"/> class.
        /// </summary>
        public ConsoleLogOutput()
        {
        }

        /// <summary>
        /// Builds the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <returns></returns>
        protected LogMessage BuildMessage(ref LogMessage msg)
        {
            var level = msg.Level;
            var text = msg.message;
            var sb = new StringBuilder();
            sb.Append('[')
              .Append(level.ToString().ToUpper())
              .Append(']')
              .Append("Thread+" + msg.Thread.ManagedThreadId)
              .Append(' ')
              //.Append(msg.TimeStamp.ToString("dd-MMM-yyyy")).Append(' ')
              .Append((msg.TimeStamp - Process.GetCurrentProcess().StartTime).ToString(@"hh\:mm\:ss\:fff"))
              .Append(" - ")
              .Append(text);
            msg.message = sb.ToString();
            return msg;
        }

        /// <summary>
        /// Logs the specified log MSG.
        /// </summary>
        /// <param name="logMsg">The log MSG.</param>
        public virtual void Log(LogMessage logMsg)
        {
            if (logMsg.message == null)
                return;

            logMsg = BuildMessage(ref logMsg);
            var msg = logMsg.message;
            ConsoleColor color = Program.originalForground;
            try
            {
                switch (logMsg.Level)
                {
                    case Level.Debug:
                        color = ConsoleColor.DarkGray;
                        break;

                    case Level.Warning:
                        color = ConsoleColor.DarkYellow;
                        break;

                    case Level.Error:
                        color = ConsoleColor.Red;
                        break;

                    case Level.Info:
                        color = ConsoleColor.White;
                        break;
                }
            }
            catch
            {
            }
            if (Debugger.IsAttached)
                Debug.WriteLine(msg);
            Program.PrintLog(msg, color);
        }
    }
}