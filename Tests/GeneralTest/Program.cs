using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Furcadia.FurcMap;

namespace FurcMapTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Map m = new Map(100, 100);
            m.Name = "Hello World!";
            m.EncodeDream = true;
            m.setFloorAt(0, 0, 32);
            m.Save("test.map", true);

        }
    }
}
