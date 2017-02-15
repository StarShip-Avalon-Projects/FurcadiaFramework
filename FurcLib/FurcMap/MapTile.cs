namespace Furcadia.FurcMap
{
    public class MapTile
    {
        public int floorNumber, objectNumber, wallNENumber, wallNWNumber, regionNumber, effectNumber;
        public int x, y;

        public MapTile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public MapTile(int x, int y, Map map)
        {
            this.x = x;
            this.y = y;
            this.floorNumber = map.getFloorAt(x, y);
            this.objectNumber = map.getObjectAt(x, y);
            this.regionNumber = map.getRegionAt(x, y);
            this.effectNumber = map.getEffectAt(x, y);

            if (x % 2 == 0)
            {
                this.wallNENumber = map.getWallAt(x + 1, y);
                this.wallNWNumber = map.getWallAt(x, y);
            }
            else
            {
                this.wallNENumber = map.getWallAt(x, y);
                this.wallNWNumber = map.getWallAt(x - 1, y);
            }
        }
    }
}