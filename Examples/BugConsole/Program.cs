using Furcadia.Logging;
using Furcadia.Net.Options;
using Furcadia.Net.Proxy;
using System;

namespace BugConsole
{
    internal class Program
    {
        #region Private Fields

        private static ProxySession proxy;
        private static ProxyOptions ProxyOptions;

        #endregion Private Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("type connect when ready");
                string cmd = Console.ReadLine();

                if (cmd.ToLower() == "connect")
                {
                    if (proxy is null)
                    {
                        ProxyOptions = new ProxyOptions();
                        proxy = new ProxySession(ProxyOptions);
                        proxy.ClientData2 += onClientDataReceived;
                        proxy.ServerData2 += onServerDataReceived;
                        proxy.Error += (e, o) => onError(e, o);
                        // We need a Character.ini file to work with -Gerolkae
                        proxy.Connect();
                    }
                    else if (!proxy.IsServerSocketConnected)
                    {
                        proxy.Connect();
                    }
                }
            }
        }

        static private void onClientDataReceived(string data)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("C>: " + data);
            Console.ResetColor();
            proxy.SendToServer(data);
        }

        static private void onServerDataReceived(string data)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("S>: " + data);
            Console.ResetColor();
            proxy.SendToClient(data);
        }

        static private void onError(Exception e, object o)
        {
            Logger.Error($"{o} \n {e}");
        }

        #endregion Private Methods
    }
}