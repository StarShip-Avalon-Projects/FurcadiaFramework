using Furcadia.FurcMap;

namespace FurcMapTest
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            Map m = new Map(100, 100);
            m.Name = "Hello World!";
            m.EncodeDream = true;
            m.setFloorAt(0, 0, 32);
            m.Save("test.map", true);
        }

        #endregion Private Methods
    }
}