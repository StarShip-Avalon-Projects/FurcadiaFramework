using Furcadia.IO;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BugProxy
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Private Fields

        private BaseProxy proxy;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            InitializeComponent();

            // TODO: Add constructor code after the InitializeComponent() call.
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Checks TCP port and scans for an available TCP port on the host system
        /// </summary>
        /// <param name="port">
        /// ref int
        /// </param>
        /// <returns>
        /// True when a port is found available
        /// </returns>
        public bool PortOpen(ref int port)
        {
            // Evaluate current system tcp connections. This is the same information provided by the
            // netstat command line application, just in .Net strongly-typed object form. We will
            // look through the list, and if our port we would like to use in our TcpClient is
            // occupied, we will set isAvailable to false.
            IPGlobalProperties ipGlobalProperties__1 = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties__1.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
            {
                if (tcpi.LocalEndPoint.Port == port)
                {
                    return false;
                }
            }
            return true;
            // At this point, if isAvailable is true, we can proceed accordingly.
        }

        #endregion Public Methods

        #region Private Methods

        private void Button1Click(object sender, EventArgs e)
        {
            int port = 10000;

            if (!PortOpen(ref port))
            {
                for (int i = port; i <= port + 100; i++)
                {
                    if (PortOpen(ref i))
                    {
                        port = i;
                        break;
                    }
                }
            }

            proxy = new BaseProxy("lightbringer.furcadia.com", 6500, port);
            proxy.ClientData2 += onClientDataReceived;
            proxy.ServerData2 += onServerDataReceived;

            // We need a Character.ini file to work with -Gerolkae
            Paths furcpath = new Paths();
            proxy.ProcessCMD = Path.Combine(furcpath.GetFurcadiaCharactersPath(), "Furcadia.ini");

            proxy.Connect();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
        }

        private void onClientDataReceived(string data)
        {
            Console.WriteLine(data);
            proxy.SendServer(data + "\n");
        }

        private void onServerDataReceived(string data)
        {
            Console.WriteLine(data);
            proxy.SendClient(data + "\n");
        }

        #endregion Private Methods
    }
}