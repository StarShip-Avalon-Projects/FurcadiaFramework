using Furcadia.Drawing.Graphics;
using System.Collections.Generic;
using System.Drawing;

namespace Furcadia.Drawing
{
    public static class Helper
    {
        #region Public Methods

        /// <summary>
        /// Converts a Char to Desc Tag
        /// </summary>
        /// <param name="c">
        /// </param>
        /// <returns>
        /// </returns>
        public static int CharToDescTag(char c)
        {
            return (int)(c - 33);
        }

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
                        bitmaps.Add(toConvert.ToBitmap(frame, pal));
                }
            }
            return bitmaps.ToArray();
        }

        #endregion Public Methods
    }
}