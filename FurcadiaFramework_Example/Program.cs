
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Furcadia.Drawing;
using Furcadia.Drawing.Graphics;
using Furcadia.IO;
using System.Drawing.Imaging;
using Furcadia.Net;
using FurcadiaFramework_Example.Demo;
using System.Collections;


namespace FurcadiaFramework_Example
{
	class Program
	{
		static int Main(string[] args)
		{
			Queue queue = new Queue();
			queue.Enqueue(new GraphicsDemo());
			//queue.Enqueue(new NetworkDemo());
			//queue.Enqueue(new FriendStatusDemo());
			while (queue.Count > 0)
			{
				((IDemo)queue.Dequeue()).Run();
				queue.TrimToSize();
			}
			return 0;
		}
	}
}
