using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Furcadia.FurcMap
{
    public class Map
    {
        private List<String> headerLines = new List<String>();
        private Dictionary<String, String> mapData = new Dictionary<String, String>();

        private int width, height;

        private byte[] mapMatrix, floors, objects, walls, regions, effects;

        internal int bytesLayerCount
        {
            get
            {
                return ((width * 2) * height);
            }
        }

        /// <summary>
        /// The actual width of the map
        /// </summary>
        public int Width
        {
            get { return this.width * 2; }
        }

        /// <summary>
        /// The actual height of the map
        /// </summary>
        public int Height
        {
            get { return this.height; }
        }

        internal Map()
        {

        }

        /// <summary>
        /// Creates a new empty map with the specified width and height
        /// </summary>
        /// <param name="width">The width of the map</param>
        /// <param name="height">The height of the map</param>
        public Map(int width, int height)
        {
            this.width = width / 2;
            this.height = height;

            floors = new byte[this.bytesLayerCount];
            objects = new byte[this.bytesLayerCount];
            walls = new byte[this.bytesLayerCount];
            regions = new byte[this.bytesLayerCount];
            effects = new byte[this.bytesLayerCount];

            String mapData = String.Format(Properties.Resources.DefaultMapData, this.height, this.width, "");
            String[] mapLines = mapData.Split(new String[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (String line in mapLines)
            {
                this.headerLines.Add(line);
                if (line.Contains("="))
                {
                    String[] vals = line.Split(new char[] { '=' }, 2);
                    this.mapData.Add(vals[0], vals[1]);
                }
                else if (line == "BODY")
                    break;
            }

            byte[] mapMatrix = new byte[this.bytesLayerCount * 5];
            this.mapMatrix = mapMatrix;
        }

        internal bool ParseMatrix(byte[] matrix)
        {
            if (matrix.Length != this.bytesLayerCount * 5)
            {
                Console.WriteLine("Something is wrong here...");
                return false;
            }
            this.mapMatrix = matrix;

            for (int i = 0; i < this.bytesLayerCount; i++)
                floors[i] = matrix[i];

            for (int i = 0; i < this.bytesLayerCount; i++)
            {
                objects[i] = matrix[i + this.bytesLayerCount];
            }

            for (int i = 0; i < this.bytesLayerCount; i++)
            {
                walls[i] = matrix[i + (this.bytesLayerCount * 2)];
            }

            for (int i = 0; i < this.bytesLayerCount; i++)
            {
                regions[i] = matrix[i + (this.bytesLayerCount * 3)];
            }

            for (int i = 0; i < this.bytesLayerCount; i++)
            {
                effects[i] = matrix[i + (this.bytesLayerCount * 4)];
            }


            return true;
        }

        /// <summary>
        /// Loads a map from a file
        /// </summary>
        /// <param name="filename">The file to load the map from</param>
        /// <exception cref="InvalidDataException">Thrown if the width and height of the map is not known (corrupt file)</exception>
        /// <returns>The map</returns>
        public static Map LoadFrom(String filename)
        {
            Map m = new Map();

            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            String currentLine = "" + br.ReadChar();
            while (true)
            {
                currentLine += br.ReadChar();

                if (currentLine.EndsWith("\n"))
                {
                    m.headerLines.Add(currentLine.Replace("\n", ""));
                    if (currentLine.Contains("="))
                    {
                        String[] vals = currentLine.Split(new char[] { '=' }, 2);

                        if (!m.mapData.ContainsKey(vals[0]))
                            m.mapData.Add(vals[0], vals[1]);
                        else
                            m.mapData[vals[0]] = vals[1];
                    }
                    else if (currentLine == "BODY\n")
                        break;

                    currentLine = "";
                }
            }

            if (m.mapData.ContainsKey("width") && m.mapData.ContainsKey("height"))
            {
                m.width = int.Parse(m.mapData["width"]);
                m.height = int.Parse(m.mapData["height"]);
            }
            else
            {
                throw new InvalidDataException("Unable to determine width & height of the map");
            }

            m.floors = new byte[m.bytesLayerCount];
            m.objects = new byte[m.bytesLayerCount];
            m.walls = new byte[m.bytesLayerCount];
            m.regions = new byte[m.bytesLayerCount];
            m.effects = new byte[m.bytesLayerCount];

            List<byte> mapMatrix = new List<byte>();
            int read = 0;
            byte[] buffer = new byte[1024];
            do
            {
                read = br.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < read; i++)
                    mapMatrix.Add(buffer[i]);

            } while (read > 0);

            br.Close();
            fs.Close();

            m.ParseMatrix(mapMatrix.ToArray());

            return m;
        }

        private int getPosFrom(int x, int y)
        {
            return ((this.height * (x / 2) + y) * 2);
        }

        /// <summary>
        /// Get the floor number from a tile
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The floor number</returns>
        public ushort getFloorAt(int x, int y)
        {
            int pos = getPosFrom(x, y);

            return (ushort)floors[pos];
        }

        /// <summary>
        /// Set the floor number at a tile specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="floorNumber"></param>
        public void setPosAt(int x, int y, ushort floorNumber)
        {
            int pos = getPosFrom(x, y);

            floors[pos] = (byte)floorNumber;
        }

        /// <summary>
        /// Get the object number from a tile
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The object number</returns>
        public ushort getObjectAt(int x, int y)
        {
            int pos = getPosFrom(x, y);

            return (ushort)objects[pos];
        }

        /// <summary>
        /// Set the object number at a tile specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="floorNumber"></param>
        public void setObjectAt(int x, int y, ushort objectNumber)
        {
            int pos = getPosFrom(x, y);

            objects[pos] = (byte)objectNumber;
        }

        /// <summary>
        /// Get the wall number from a tile
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The wall number</returns>
        public ushort getWallAt(int x, int y)
        {
            int pos = (this.height * x + y);

            return (ushort)walls[pos];
        }

        /// <summary>
        /// Set the wall number at a tile specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="floorNumber"></param>
        public void setWallAt(int x, int y, ushort wallNumber)
        {
            int pos = (this.height * x + y);

            walls[pos] = (byte)wallNumber;
        }

        /// <summary>
        /// Get the region number from a tile
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The region number</returns>
        public ushort getRegionAt(int x, int y)
        {
            int pos = getPosFrom(x, y);

            return (ushort)regions[pos];
        }

        /// <summary>
        /// Set the region number at a tile specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="floorNumber"></param>
        public void setRegionAt(int x, int y, ushort regionNumber)
        {
            int pos = getPosFrom(x, y);

            regions[pos] = (byte)regionNumber;
        }

        /// <summary>
        /// Get the effect number from a tile
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The effect number</returns>
        public ushort getEffectAt(int x, int y)
        {
            int pos = getPosFrom(x, y);

            return (ushort)effects[pos];
        }

        /// <summary>
        /// Set the effect number at a tile specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="floorNumber"></param>
        public void setEffectAt(int x, int y, ushort effectNumber)
        {
            int pos = getPosFrom(x, y);

            effects[pos] = (byte)effectNumber;
        }

        /// <summary>
        /// Get a MapPosition object from the position specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public MapPosition getMapPos(int x, int y)
        {
            return new MapPosition(x, y, this);
        }

        /// <summary>
        /// Get a MapTile object from the position specified by x & y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public MapTile getMapTile(int x, int y)
        {
            return new MapTile(x, y, this);
        }

        /// <summary>
        /// Save the map to a file
        /// </summary>
        /// <param name="filename">The filename to save to</param>
        /// <param name="overwrite">If a file with that name already exist, should we overwrite it?</param>
        /// <returns>True if the save was a success, False if not</returns>
        public bool Save(String filename, bool overwrite = true)
        {
            if (File.Exists(filename) && !overwrite)
                return false;

            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter sw = new BinaryWriter(fs, Encoding.ASCII);

            String headerData = "";
            foreach (String line in this.headerLines)
                headerData += line + "\n";

            byte[] headerDataBytes = Encoding.ASCII.GetBytes(headerData);

            sw.Write(headerDataBytes);
            sw.Write(this.floors);
            sw.Write(this.objects);
            sw.Write(this.walls);
            sw.Write(this.regions);
            sw.Write(this.effects);

            sw.Close();
            fs.Close();

            return true;
        }
    }
}
