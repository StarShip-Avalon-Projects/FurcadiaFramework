using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Furcadia.Drawing.Graphics;
using Furcadia.IO;
using System.Drawing;
using Furcadia.Drawing;
using System.Drawing.Imaging;

namespace FurcadiaFramework_Example.Demo
{
    public class GraphicsDemo : IDemo
    {
        private delegate void Invoker();
        public GraphicsDemo() { }

        #region IDemo Members

        public void Run()
        {
            Form f = new Form();
            f.Text = "Graphics Demo";
            PictureBox pic = new PictureBox();
            pic.Height = 100;
            pic.Width = 100;
            pic.Dock = DockStyle.Fill;
            pic.AutoSize = true;

            f.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            f.AutoSize = true;
            f.Width = 100;
            f.Height = 100;

            System.Timers.Timer timer = new System.Timers.Timer(1000);

            f.Load += delegate
            {
                if (!timer.Enabled) timer.Start();
            };
            f.FormClosed += delegate
            {
                if (timer.Enabled) timer.Stop();
            };

            FurcadiaShapes shape = new FurcadiaShapes(Paths.GetDefaultPatchPath() + "buttons.fox");
            Bitmap[] anims = Helper.ToBitmapArray(shape);
            Random rand = new Random();
            timer.Elapsed += delegate
            {
                if (f.InvokeRequired)
                {
                    try
                    {
                        f.Invoke(new Invoker(delegate
                        {
                            pic.Image = anims[rand.Next() % anims.Length];
                        }));
                    }
                    catch { }
                }
                else pic.Image = anims[rand.Next() % anims.Length];

            };

            f.Controls.Add(pic);
            f.ShowDialog();
        }

        #endregion
    }
}
