using Furcadia.Net.Options;
using Furcadia.Net.Proxy;
using System;

namespace BugConsole
{
    internal class Program
    {
        #region Private Fields

        private static ProxySession proxy;
        private static ProxySessionOptions ProxyOptions;

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
                        ProxyOptions = new BugProxy.Net.BugProxyOptions();
                        proxy = new ProxySession(ref ProxyOptions);
                        proxy.ClientData2 += onClientDataReceived;
                        proxy.ServerData2 += onServerDataReceived;
                        // We need a Character.ini file to work with -Gerolkae
                        proxy.Connect();
                    }
                    else if (!proxy.IsServerConnected)
                    {
                        proxy.Connect();
                    }
                }
            }
        }

        static private void onClientDataReceived(string data)
        {
            Console.WriteLine("C>: " + data);
            proxy.SendToServer(data);
        }

        static private void onServerDataReceived(string data)
        {
            Console.WriteLine("S>: " + data);
            proxy.SendToClient(data);
        }

        #endregion Private Methods
    }
}