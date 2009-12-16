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
        private bool is_testing;

        public GraphicsDemo() { }

        #region IDemo Members

        public void Run()
        {
            Form f = new Form();
            f.Text = "Graphics Demo";

            Label desc = new Label();
            desc.Text = "Hold F5 for 24 bit image test.";
            desc.AutoSize = true;
            desc.Top = 0;
            desc.Left = 0;

            PictureBox pic = new PictureBox();
            pic.Height = 100;
            pic.Width = 100;
            pic.Top = desc.Height;
            pic.Left = 0;
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

            f.KeyDown += delegate(object sender, KeyEventArgs e) { 
                if (e.KeyCode == Keys.F5) 
                    is_testing = true; 
            else is_testing = false; };

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
                            pic.Top = desc.Height;
                            if (!is_testing)
                                pic.Image = anims[rand.Next() % anims.Length];
                            else {
                                throw new NotImplementedException();
                            }
                        }));
                    }
                    catch { }
                }
                else {
                    if (!is_testing)
                        pic.Image = anims[rand.Next() % anims.Length];
                    else
                    {
                        throw new NotImplementedException();
                    }
                }

            };

            f.Controls.Add(pic);
            f.ShowDialog();
        }

        #endregion
    }
}
