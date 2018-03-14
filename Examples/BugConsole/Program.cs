using Furcadia.Logging;
using Furcadia.Net;
using Furcadia.Net.Options;
using Furcadia.Net.Proxy;
using Furcadia.Net.Utils.ServerParser;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace BugConsole
{
    internal class Program
    {
        #region Internal Fields

        internal const ConsoleColor originalBackground = ConsoleColor.DarkGreen;
        internal const ConsoleColor originalForground = ConsoleColor.Cyan;

        #endregion Internal Fields

        #region Private Fields

        private static int currentRow;
        private static int origCol;
        private static int origHeight;
        private static int origRow;
        private static ProxySession proxy;
        private static ProxyOptions proxyOptions;

        #endregion Private Fields

        #region Internal Methods

        internal static void PrintLog(string message, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;

            WriteParagraphAt(message, 0, ref currentRow);

            Console.BackgroundColor = originalBackground;
            Console.ForegroundColor = originalForground;
            PrintPrompt("Command :> ");
        }

        #endregion Internal Methods

        #region Protected Methods

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        protected static void WriteParagraphAt(string s, int x, ref int y)
        {
            try
            {
                var words = s.Split(' ');
                var lines = words.Skip(1).Aggregate(words.Take(1).ToList(), (l, w) =>
                {
                    if (l.Last().Length + w.Length >= 80)
                    {
                        if (!string.IsNullOrWhiteSpace(w))
                            l.Add(w);
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(w))
                            l[l.Count - 1] += " " + w;
                    }
                    return l;
                });
                Console.SetCursorPosition(origCol + x, origRow + y);
                foreach (string line in lines)
                {
                    Console.Write(line);
                }
                y += lines.Count;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        #endregion Protected Methods

        #region Private Methods

        private static void Initialize()
        {
            Logger.InfoEnabled = true;
            Logger.SuppressSpam = false;
            Logger.ErrorEnabled = true;
            Logger.WarningEnabled = true;
            Logger.SingleThreaded = true;
            Logger.DebugEnabled = false;
            Logger.LogOutput = new MultiLogOutput(new Logging.ConsoleLogOutput(), new FileLogOutput(AppDomain.CurrentDomain.BaseDirectory, Level.Debug), new FileLogOutput(AppDomain.CurrentDomain.BaseDirectory, Level.Error));

            proxyOptions = new ProxyOptions();

            ResetConsole();
        }

        private static void Main(string[] args)
        {
            Initialize();
            Boolean quitNow = false;
            Console.Title = AppDomain.CurrentDomain.FriendlyName;
            PrintHeader($"{Process.GetCurrentProcess().ProcessName}: Powered byt Furcadia Framework for Third Party Programs");
            PrintHeader($"{new string('-', Console.WindowWidth)}");
            while (!quitNow)
            {
                PrintPrompt("Command :> ");

                string[] command = Console.ReadLine().Split(new char[] { ' ' }, 2);

                switch (command[0])
                {
                    case "?":
                    case "!help":
                        PrintHeader("Help Content");
                        PrintHeader(new string('-', 12));
                        PrintHeader("Commands:");
                        PrintHeader("\t!version");
                        PrintHeader("\t!quit");
                        PrintHeader("\t!debug");
                        PrintHeader("\tconnect");
                        PrintHeader("\t!disconnect");
                        break;

                    case "!version":
                        PrintHeader($"Version information:");
                        PrintHeader(new string('-', 20));
                        PrintHeader("");
                        Assembly assem = Assembly.GetExecutingAssembly();
                        AssemblyName aName = assem.GetName();
                        PrintHeader($"Product: {aName.Name}");
                        PrintHeader($"Version: {aName.Version.ToString()}");
                        assem = Assembly.LoadFrom("FurcadiaLib.dll");
                        aName = assem.GetName();
                        PrintHeader($"Product: {aName.Name}");
                        PrintHeader($"Version: {aName.Version.ToString()}");
                        break;

                    case "!quit":
                        quitNow = true;
                        break;

                    case "!debug":
                        Logger.DebugEnabled = !Logger.DebugEnabled;
                        PrintHeader($"Debugging set to: {Logger.DebugEnabled}");
                        break;

                    case "connect":
                        if (proxy != null && proxy.IsServerSocketConnected)
                        {
                            Logger.Info("Already connected to Furcadia");
                            break;
                        }
                        else
                        {
                            StartProxy();
                        }
                        break;

                    case "!disconnect":
                        if (proxy != null && proxy.IsServerSocketConnected)
                        {
                            StopProxy();
                        }
                        else
                        {
                            Logger.Info("Not connected to Furcadia");
                        }
                        break;

                    default:
                        if (proxy == null || !proxy.IsServerSocketConnected)
                        {
                            PrintHeader($"Unknown Command {command.ToString(' ')}");
                        }
                        else
                        {
                            proxy.SendFormattedTextToServer(command.ToString(' '));
                        }
                        break;
                }
            }
            if (proxy != null)
            {
                if (proxy.IsServerSocketConnected)
                    proxy.Disconnect();
                proxy.Dispose();
            }
        }

        static private void onClientDataReceived(string data)
        {
            proxy.SendToServer(data);
        }

        static private void onError(Exception e, object o)
        {
            Logger.Error($"{o} \n {e}");
        }

        static private void onServerChannelReceived(object data, ParseChannelArgs e)
        {
            if (data is ChannelObject Chan)
                PrintLog($"[{e.Channel}]: {Chan.FormattedChannelText}", ConsoleColor.White);
        }

        static private void onServerDataReceived(string data)
        {
            if (proxy.ServerConnectPhase == ConnectionPhase.MOTD)
                PrintLog($"S:> {data}", ConsoleColor.White);
            proxy.SendToClient(data);
        }

        private static void PrintHeader(string message)
        {
            WriteParagraphAt(message, 0, ref currentRow);
        }

        private static void PrintPrompt(string message)
        {
            if (currentRow >= origHeight - 1)
            {
                var diff = origHeight - currentRow;
                origHeight += diff;
            }
            WriteAt(new string(' ', Console.WindowWidth), 0, origHeight);
            WriteAt(message, 0, origHeight);
        }

        private static void ResetConsole()
        {
            Console.ForegroundColor = originalForground;
            Console.BackgroundColor = originalBackground;
            Console.Clear();

            currentRow = Console.WindowTop;
            origRow = Console.WindowTop;
            origCol = Console.WindowLeft;
            origHeight = Console.WindowHeight;
        }

        private static void StartProxy()
        {
            proxy = new ProxySession(proxyOptions);
            proxy.Error += onError;
            proxy.ProcessServerChannelData += onServerChannelReceived;
            proxy.ServerData2 += onServerDataReceived;
            proxy.ClientData2 += onClientDataReceived;
            proxy.Connect();
        }

        private static void StopProxy()
        {
            proxy.Disconnect();

            proxy.Error -= onError;
            proxy.ProcessServerChannelData -= onServerChannelReceived;
            proxy.ServerData2 -= onServerDataReceived;
            proxy.ClientData2 -= onClientDataReceived;
            proxy.Dispose();
        }

        #endregion Private Methods
    }
}