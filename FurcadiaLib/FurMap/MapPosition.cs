using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furcadia.FurcMap
{
    public class MapPosition
    {
        public ushort floornumber, objectnumber, wallnumber, regionnumber, effectnumber;
        public int x, y;

        public MapPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public MapPosition(int x, int y, Map map)
        {
            this.x = x;
            this.y = y;
            this.floornumber = map.getFloorAt(x, y);
            this.objectnumber = map.getObjectAt(x, y);
            this.wallnumber = map.getWallAt(x, y);
            this.regionnumber = map.getRegionAt(x, y);
            this.effectnumber = map.getEffectAt(x, y);
        }
    }
}
