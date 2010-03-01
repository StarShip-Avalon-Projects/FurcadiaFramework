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
        }
		
		public void Run(){
			Form f = new Form();
            f.Text = "Network Proxy Demo";
			Button button = new Button();
            button.Text = "Connect";
			Button send = new Button();
			TextBox tBox = new TextBox();
			RichTextBox output = new RichTextBox();
			output.Top = tBox.Height;
			output.Dock = DockStyle.Bottom;
			
			NetProxy proxy = new NetProxy(6500);
			/* UNCOMMENT the line below this one if you have Furnarchy2 installed. */
			//proxy.SetProcess(@"C:\Program Files\Furnarchy2\launch.exe");
			
			proxy.ClientData += delegate(string data) {
				output.AppendText("\nCLIENT: "+data);
				//Must return the data and without a newline.
				//Modify your description!
				if (data.StartsWith("desc"))
					data += " [<a href=\"http://furcadia.codeplex.com/\">Furcadia Framework</a>]";
				
				return data;
			};
			proxy.ServerData += delegate(string data) {
				output.AppendText("\nSERVER: "+data);
				return data;
			};
			
			proxy.ClientExited += delegate {
				output.AppendText("\nClient exited.");
				proxy.Kill();
				button.Text = "Connect";
			};
			
			proxy.Error += delegate(Exception e) {
				output.AppendText("\n"+e.Message);
			};
			
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
			f.Controls.Add(output);
			f.Controls.Add(button);
            f.ShowDialog();
		}
    }
}
