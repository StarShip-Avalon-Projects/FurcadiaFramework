
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Furcadia.Drawing;
using Furcadia.Drawing.Graphics;
using Furcadia.IO;
using System.Drawing.Imaging;


namespace FurcadiaFramework_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            FurcadiaShapes file = new FurcadiaShapes(Paths.GetDefaultPatchPath() + "/buttons.fox");
            Bitmap[] bitmaps = Helper.ToBitmapArray(file);

            Form main = new Form();
            main.Text = "!";
            main.Width = 50;
            main.Height = 50;
            main.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            main.AutoSize = true;

            
            Button button1 = new Button();
            button1.AutoSize = true;
            button1.Text = "Random";

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Top = button1.Height + 2;

            main.Controls.Add(button1);
            main.Controls.Add(pictureBox1);

            button1.Click += delegate
            {
                Random rand = new Random();
                pictureBox1.Image = bitmaps[(rand.Next() % bitmaps.Length)];
            };
            Application.Run(main);
        }
    }
}
