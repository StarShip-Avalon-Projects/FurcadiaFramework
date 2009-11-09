using System;
using System.Collections.Generic;
using System.Text;
using Furcadia.Net;
using System.Windows.Forms;

namespace FurcadiaFramework_Example.Demo
{
    public class NetworkDemo : IDemo
    {
        public NetworkDemo()
        {
			NetProxy proxy = new NetProxy(6500);
        }
		
		public void Run(){
			NetProxy proxy = new NetProxy(6500);
			proxy.ClientData += delegate(string data) {
				Console.Write("CLIENT: "+data+"\n");
				//Must return the data without a newline.
				//If you modify it return the modified data.
				return data;
			};
			proxy.ServerData += delegate(string data) {
				Console.Write("SERV: "+data+"\n");
				return data;
			};
			Form f = new Form();
            f.Text = "Network Proxy Demo";
			Button button = new Button();
            button.Text = "Connect";
			Button send = new Button();
			TextBox tBox = new TextBox();

			button.Dock = DockStyle.Top;
			button.Click += delegate {
                if (button.Text == "Connect")
                {
                    button.Text = "Disconnect";
                    proxy.Connect();
                }
                else if (button.Text == "Disconnect")
                {
                    button.Text = "Connect";
                    proxy.Kill();
                }
			};
			f.Controls.Add(button);
            f.ShowDialog();
		}
    }
}
