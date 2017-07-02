using BeekinProxy.Net;
using System;
using System.Windows.Forms;

namespace BeekinProxy
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Private Fields

        private BeekinProxySession proxy;
        private BeekinProxyOptions ProxyOptions;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms
            // designer support.
            InitializeComponent();

            // TODO: Add constructor code after the InitializeComponent() call.
        }

        #endregion Public Constructors

        #region Private Methods

        private void Button1Click(object sender, EventArgs e)
        {
            if (proxy == null)
            {
                ProxyOptions = new BeekinProxyOptions();
                proxy = new BeekinProxySession(ProxyOptions);
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

        private void MainFormLoad(object sender, EventArgs e)
        {
        }

        private void onClientDataReceived(string data)
        {
            Console.WriteLine("<C>: " + data);
            proxy.SendToServer(data);
        }

        private void onServerDataReceived(string data)
        {
            Console.WriteLine("<S>: " + data);
            proxy.SendToClient(data);
        }

        #endregion Private Methods
    }
}