using Furcadia.Drawing;
using Furcadia.Drawing.Graphics;
using Furcadia.IO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FurcadiaFramework_Example.Demo
{
    public class GraphicsDemo : IDemo
    {
        #region Public Constructors

        public GraphicsDemo()
        {
        }

        #endregion Public Constructors

        #region Private Delegates

        private delegate void Invoker();

        #endregion Private Delegates

        #region IDemo Members

        private Paths FurcPath;

        public void Run()
        {
            FurcPath = new Paths();
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

            #region Furcadia.Graphics implimentation here.

            FurcadiaShapes shape = new FurcadiaShapes(FurcPath.GetDefaultPatchPath() + "item.fox");
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
                                     pic.Image = null;
                                     pic.Image = anims[rand.Next() % anims.Length];
                                     pic.Top = desc.Height;
                                     pic.PerformLayout();
                                 }));
                    }
                    catch { }
                }
                else
                {
                    pic.Image = null;
                    pic.Image = anims[rand.Next() % anims.Length];
                    pic.Top = desc.Height;
                    pic.PerformLayout();
                }
            };

            #endregion Furcadia.Graphics implimentation here.

            f.Controls.Add(pic);
            f.ShowDialog();
        }

        #endregion IDemo Members
    }
}