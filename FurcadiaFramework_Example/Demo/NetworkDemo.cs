using System;
using System.Collections.Generic;
using System.Text;
using Furcadia.Net;
using System.Windows.Forms;

namespace FurcadiaFramework_Example.Demo
{
    delegate void Invoker();
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
			button.Dock = DockStyle.Top;
			
			TextBox tBox = new TextBox();
			RichTextBox output = new RichTextBox();
			output.Top = tBox.Height;
			output.Dock = DockStyle.Bottom;
			
			NetProxy proxy = new NetProxy(6500);
			/*	UNCOMMENT the line below this one if you have Furnarchy2 installed.
				CAUTION: IT IS A LITTLE BUGGY.
			*/
			//proxy.SetProcess(@"C:\Program Files\Furnarchy2\launch.exe");
			
			proxy.Connected += delegate {
				Write (f, "Connection(Client: " + proxy.IsClientConnected + " Server: " + proxy.IsServerConnected + ")");
			};
			proxy.ClientData += delegate(string data) {
                if (output.InvokeRequired)
                {
                    output.Invoke(new Invoker(delegate { output.AppendText("\nCLIENT: " + data); }));
                }
                else output.AppendText("\nCLIENT: " + data);
				//Must return the data and without a newline.
				//Modify your description!
				if (data.StartsWith("desc"))
					data += " [Connected using: [<a href=\"http://furcadia.codeplex.com/\">Furcadia Framework</a>]";
				
                Write (f, "Connection(Client: " + proxy.IsClientConnected + " Server: " + proxy.IsServerConnected + ")");			
				return data;
			};
			proxy.ServerData += delegate(string data) {
                if (output.InvokeRequired)
                {
                    output.Invoke(new Invoker(delegate { output.AppendText("\nSERVER: " + data); }));
                }
                else output.AppendText("\nSERVER: " + data);
                
				return data;
			};
			
			proxy.ClientExited += delegate {
                if (output.InvokeRequired)
                {
                    output.Invoke(new Invoker(delegate { output.AppendText("\nClient exited."); }));
                    proxy.Kill ();
                }
                else output.AppendText("\nClient exited.");
				Write(button,"Connect");
				
				Write (f, "Connection(Client: " + proxy.IsClientConnected + " Server: " + proxy.IsServerConnected + ")");
			};
			
			proxy.Error += delegate(Exception e) {
                if (output.InvokeRequired)
                {
                    output.Invoke(new Invoker(delegate { output.AppendText("\nERROR: " + e.Message); }));
                }
                else output.AppendText("\nERROR: " + e.Message);
			};
			
			button.Click += delegate {
                if (button.Text == "Connect")
                {
                	Write(button,"Disconnect");
                    proxy.Connect();
                }
                else if (button.Text == "Disconnect")
                {
                    Write(button,"Connect");
                    proxy.Kill();
                }
                Write (f, "Connection(Client: " + proxy.IsClientConnected + " Server: " + proxy.IsServerConnected + ")");
			};

            f.FormClosing += delegate
            {
                proxy.Kill();
            	Write (f, "Connection(Client: " + proxy.IsClientConnected + " Server: " + proxy.IsServerConnected + ")");
            };
			f.Controls.Add(output);
			f.Controls.Add(button);
            f.ShowDialog();
		}
		
		public void Write(Control control, string text){
			if (control.InvokeRequired){
				control.Invoke(new Invoker(delegate{
					control.Text = text;
				}));
			}else control.Text = text;
		}
    }
}
