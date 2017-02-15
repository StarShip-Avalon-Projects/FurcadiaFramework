namespace Furcadia.Drawing
{
    public class FurrePosition
    {
        public int x { get; set; }
        public int y { get; set; }

        public FurrePosition()
        {
        }

        public FurrePosition(int X, int Y)
        {
            y = y;
            x = x;
        }

        public FurrePosition(FurrePosition Position)
        {
            x = Position.x;
            y = Position.y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x.ToString(), y.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() == typeof(FurrePosition))
            {
                FurrePosition ob = (FurrePosition)obj;
                return ob.y == y && ob.x == x;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}