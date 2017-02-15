using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furcadia.Drawing
{
    public class ViewArea
    {
        public int X;
        public int Y;
        public int length;
        public int height;
    }

    public static class VisibleArea
    {
        //Reference http://pastebin.com/QbnjwjNc
        public static ViewArea getTargetRectFromCenterCoord(int X, int Y)
        {
            // Set the size of the rectangle drawn around the player.
            // The +1 is the tile the player is on.
            ViewArea rec = null;
            //Dim tilesWide As UInt32 = extraTilesLeft + 7 + 1 + 7 + extraTilesRight
            //Dim tilesHigh As UInt32 = extraTilesTop + 8 + 1 + 8 + extraTilesBottom
            // NB: these lines *look* similar, but the numbers are for *completely* different reasons!
            //tilesWide = tilesWide * 2 ' * 2 as all X values are even: we count 0, 2, 4...
            //tilesHigh = tilesHigh * 2 ' * 2 as zig-zaggy vertical cols can fit twice as many tiles to a column

            // Set where in the map our visible (0,0) will be.
            int XoddOffset = 2;
            int YoddOffset = 0;
            if (IsOdd(Y))
            {
                XoddOffset = 0;
                YoddOffset = 1;
            }
            rec.X = X - 8 + XoddOffset;
            rec.Y = Y - 8 - 1;
            // 1 for the tile the user is in.
            rec.length = rec.X + 14;
            rec.height = rec.Y + 17 + YoddOffset;
            return rec;
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}