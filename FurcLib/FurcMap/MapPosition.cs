using System;

namespace Furcadia.FurcMap
{
    [CLSCompliant(true)]
    public class MapPosition
    {
        #region Public Fields

        public int floorNumber, objectNumber, wallNumber, regionNumber, effectNumber;
        public int x, y;

        #endregion Public Fields

        #region Public Constructors

        public MapPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public MapPosition(int x, int y, Map map)
        {
            this.x = x;
            this.y = y;
            this.floorNumber = map.getFloorAt(x, y);
            this.objectNumber = map.getObjectAt(x, y);
            this.wallNumber = map.getWallAt(x, y);
            this.regionNumber = map.getRegionAt(x, y);
            this.effectNumber = map.getEffectAt(x, y);
        }

        #endregion Public Constructors
    }
}