using System;
using System.Collections.Generic;
using System.Text;
using Furcadia.Drawing.Graphics;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Furcadia.Drawing
{
    public static class Helper
    {
        public static Bitmap[] ToBitmapArray(FurcadiaShapes toConvert)
        {
            List<Bitmap> bitmaps = new List<Bitmap>();
            Palette pal = Palette.Default;
            Shape[] shapes = toConvert.Shapes;
            foreach (Shape shape in shapes)
            {
                foreach (Frame frame in shape.Frames)
                {
                    if (frame.ImageDataSize > 0)
                        bitmaps.Add(new Bitmap(toConvert.Render(frame, pal)));
                }
            }
            return bitmaps.ToArray();
        }

        public static Bitmap[] ToBitmapArrayEx(FurcadiaShapes toConvert)
        {
            Palette pal = Palette.Default;
            Shape[] shapes = toConvert.Shapes;
            List<Bitmap> bitmaps = new List<Bitmap>();
            MemoryStream stream = null;
            foreach (Shape shape in shapes)
            {
                if (stream == null) stream = new MemoryStream();
                foreach (Frame frame in shape.Frames)
                {
                    Bitmap newBit = toConvert.Render(frame, pal);
                    if (stream == null) stream = new MemoryStream();
                    if (newBit != null) newBit.Save(stream,ImageFormat.Png);
                }
                if (stream != null && stream.Length > 0)
                {
                    bitmaps.Add(new Bitmap(stream));
                    stream.Close();
                    stream = null;
                }
            }
            return bitmaps.ToArray();
        }
    }
}
