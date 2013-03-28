using System;
using System.Collections.Generic;
using System.Text;
using Furcadia.Net;
using System.Windows.Forms;

namespace FurcadiaFramework_Example.Demo
{
	/// <summary>
	/// 
	/// </summary>
	public class FriendStatusDemo : IDemo
	{
		private delegate void Invoker();
		PounceConnection pounce;
		/// <summary>
		/// 
		/// </summary>
		public FriendStatusDemo()
		{

		}
		#region IDemo Members
		/// <summary>
		/// 
		/// </summary>
		public void Run()
		{
			pounce = new PounceConnection("http://on.furcadia.com/q/", null);
			Form f = new Form();
			f.Text = "Frind Status Checkr (Misspelled Version)";
			f.AutoScroll = true;
			f.Width = 200;
			f.Height = 150;

			SplitContainer container = new SplitContainer();
			container.Orientation = Orientation.Horizontal;
			container.Dock = DockStyle.Fill;
			container.SplitterDistance = 15;
			RichTextBox statusBox = new RichTextBox();
			statusBox.Top = 15;
			statusBox.ReadOnly = true;
			statusBox.Dock = DockStyle.Fill;

			TextBox input = new TextBox();
			input.Dock = DockStyle.Top;
			input.KeyDown += delegate(object sender, KeyEventArgs e) {
				if (e.KeyCode == Keys.Enter)
				{
					pounce.RemoveFriends();
					foreach (string friend in input.Text.Split(','))
						if (!String.IsNullOrEmpty(friend)) pounce.AddFriend(friend);
					pounce.ConnectAsync();
					statusBox.AppendText("Retrieving...\n");
				}
				
			};

			pounce.Response += delegate(string[] friends, string[] dreams)
			{
				foreach (string friend in friends)
				{
					if (statusBox.InvokeRequired)
						statusBox.Invoke(new Invoker(delegate
						{
							statusBox.AppendText(friend + " is Online!\n");
						}));
					else statusBox.AppendText(friend + " is Online!\n");
				}

				foreach (string dream in dreams)
				{
					if (statusBox.InvokeRequired)
						statusBox.Invoke(new Invoker(delegate
						{
							statusBox.AppendText(dream + " is uploaded!\n");
						}));
					else statusBox.AppendText(dream + " is uploaded!\n");
				}

				//Display total num of furres online and dream number count in title.
				if (f.InvokeRequired)
					f.Invoke(new Invoker(delegate
					{
						f.Text = "Total: " + pounce.TotalFurresOnline + "Dreams: " + pounce.NumberOfDreamsOnMainMaps;
					}));
				else f.Text = "Total: " + pounce.TotalFurresOnline + "Dreams: " + pounce.NumberOfDreamsOnMainMaps;
				pounce.Kill();
			};
			f.HelpButton = true;
			f.HelpRequested += delegate
			{
				MessageBox.Show("Type into the box the names (shortname only) separated by a comma (,) [i.e Bob, CharlieOmega, alphacentauri]");
			};
			f.HelpButtonClicked += delegate
			{
				MessageBox.Show("Type into the box the names (shortname only) separated by a comma (,) [i.e Bob, CharlieOmega, alphacentauri]");
			};
			container.Panel1.Controls.Add(input);
			container.Panel2.Controls.Add(statusBox);
			f.Controls.Add(container);
			MessageBox.Show("FriendStatusDemo: Hit F1 at anytime for another popup like this with instructions.");
			f.ShowDialog();
		}

		#endregion
	}
}
