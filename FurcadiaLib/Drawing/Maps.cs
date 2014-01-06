using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Furcadia.Drawing
{
    public struct Tile
    {
        public ushort Object;
        public ushort Floor;
        public byte WallNW;
        public byte WallNE;
        public ushort Region;
        public ushort Effect;
    }
    
    public class Maps
    {
        //--- Data Members ---//
        uint iHeight = 0;
        uint iWidth = 0;
        double version = 0;
        Tile[,] map;
        Dictionary<string,string> headers = new Dictionary<string,string>();

        //--- Properties ---//
        public uint Height
        {
            get { return iHeight; }
        }

        public uint Width
        {
            get { return iWidth; }
        }
        public double Version
        {
            get { return version; }
        }
        //--- Static Functions ---//
        public static Maps CreateInstance()
        {
            return new Maps();
        }
        public static Maps CreateInstance(string filename)
        {
            Maps md = CreateInstance();
            md.LoadMap(filename);
            return md;
        }

        //--- Object Methods ---//
        public void LoadMap(string filename)
        {
            headers.Clear();

            // If it doesn't exist, throw 'em out.
            if (!File.Exists(filename))
                throw new FileNotFoundException("Map file does not exist", filename);

            Stream file = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read);

            // We'll need this to read the plaintext header.
            StreamReader sr = new StreamReader(file);
            string line;
            line = sr.ReadLine();
            if (line == null)
            {
                sr.Close();
                throw new Exception("Empty file");
            }

            // Test if it's a Furc map.
            if (!line.StartsWith("MAP V01."))
            {
                sr.Close();
                throw new Exception("Not a Furcadia map or format not supported");
            }
            double.TryParse(line.Substring(5), out version);
            
            int pos = line.Length + 1;
            headers.Add("map_signature", line.Trim());

            // Go through the rest of the headers.
            string[] separators = {"="};

            while (true)
            {
                line = sr.ReadLine();
                if (sr.EndOfStream)
                {
                    sr.Close();
                    throw new Exception("Premature End of File");
                }

                pos += line.Length + 1;
                line.Trim();
                if (line == "BODY")
                    break;

                string[] buffer = line.Split(separators, 2, StringSplitOptions.None);
                if (headers.ContainsKey(buffer[0]))
                    headers.Remove(buffer[0]);
                headers.Add(buffer[0], buffer[1]);
            }

            // Set height/width and check for encryption.
            if (Convert.ToInt16(headers["encoded"]) > 0)
            {
                sr.Close();
                throw new Exception("Map file is encrypted");
            }

            iHeight = Convert.ToUInt32(headers["height"]);
            iWidth = Convert.ToUInt32(headers["width"]);

            // Prime the tile grid.
            map = new Tile[iHeight, iWidth];

            // Binary data reading starts here.
            BinaryReader br = new BinaryReader(file);
            br.BaseStream.Position = pos;
            

            // Reading floors
            for (uint x = 0; x < iWidth; x++)
                for (uint y = 0; y < iHeight; y++)
                    map[y, x].Floor = br.ReadUInt16();

            // Reading objects
            for (uint x = 0; x < iWidth; x++)
                for (uint y = 0; y < iHeight; y++)
                    map[y, x].Object = br.ReadUInt16();

            // Reading walls (NW,NE)
            for (uint x = 0; x < iWidth; x++)
            {
                for (uint y = 0; y < iHeight; y++)
                {
                    map[y, x].WallNW = br.ReadByte();
                    map[y, x].WallNE = br.ReadByte();
                }
            }
            if (version > 1.3)
            {
                // Reading regions
                for (uint x = 0; x < iWidth; x++)
                    for (uint y = 0; y < iHeight; y++)
                        map[y, x].Region = br.ReadUInt16();

                // Reading effects
                for (uint x = 0; x < iWidth; x++)
                    for (uint y = 0; y < iHeight; y++)
                        map[y, x].Effect = br.ReadUInt16();
            }


            // Success :D
            br.Close();
        }

        public void SaveMap(string filename)
        {
            Stream file = File.Open(filename, FileMode.Create, FileAccess.Write, FileShare.None);

            // Writing headers.
            try
            {
                StreamWriter sw = new StreamWriter(file);
                //sw.Write(headers["map_signature"] + "\n");
                sw.Write("MAP V1.4\n", version);
                foreach (string key in headers.Keys)
                {
                    if (key != "map_signature")
                        sw.Write("{0}={1}\n", key, headers[key]);
                }

                sw.Write("BODY\n");
                sw.Flush();

                // Writing data.
                BinaryWriter bw = new BinaryWriter(file);
                for (uint x = 0; x < iWidth; x++)
                    for (uint y = 0; y < iHeight; y++)
                        bw.Write(map[y, x].Floor);
                for (uint x = 0; x < iWidth; x++)
                    for (uint y = 0; y < iHeight; y++)
                        bw.Write(map[y, x].Object);
                for (uint x = 0; x < iWidth; x++)
                {
                    for (uint y = 0; y < iHeight; y++)
                    {
                        bw.Write(map[y, x].WallNW);
                        bw.Write(map[y, x].WallNE);
                    }
                }
                
                    for (uint x = 0; x < iWidth; x++)
                        for (uint y = 0; y < iHeight; y++)
                            bw.Write(map[y, x].Region);
                    for (uint x = 0; x < iWidth; x++)
                        for (uint y = 0; y < iHeight; y++)
                            bw.Write(map[y, x].Effect);

                bw.Close();
            }
            catch
            {
                file.Close(); // If we don't close it here, it'll be stuck open.
                throw;
            }
        }

        //-- GET --//
        public string GetHeader(string headerName)
        {
            return headers[headerName];
        }

        public Tile GetTile(uint x, uint y)
        {
            return map[y, x];
        }

        public ushort GetObject(uint x, uint y)
        {
            return (InRange(x,y)) ? map[y, x].Object : (ushort)0;
        }

        public ushort GetFloor(uint x, uint y)
        {
            return (InRange(x, y)) ? map[y, x].Floor : (ushort)0;
        }

        public byte GetWallNw(uint x, uint y)
        {
            return (InRange(x, y)) ? map[y, x].WallNW : (byte)0;
        }

        public byte GetWallNe(uint x, uint y)
        {
            return (InRange(x, y)) ? map[y, x].WallNE : (byte)0;
        }
        public ushort GetRegion(uint x, uint y)
        {
            return (InRange(x, y)) ? map[y, x].Region : (ushort)0;
        }
        public ushort GetEffect(uint x, uint y)
        {
            return (InRange(x, y)) ? map[y, x].Effect : (ushort)0;
        }

        //-- SET --//
        public void SetHeader(string headerName, string value)
        {
            headers[headerName] = value;
        }

        public void SetTile(uint x, uint y, Tile t)
        {
            map[y, x] = t;
        }

        public void SetObject(uint x, uint y, ushort obj)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].Object = obj;
        }

        public void SetFloor(uint x, uint y, ushort floor)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].Floor = floor;
        }

        public void SetWallNw(uint x, uint y, byte wall)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].WallNW = wall;
        }

        public void SetWallNe(uint x, uint y, byte wall)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].WallNE = wall;
        }

        public void SetRegion(uint x, uint y, ushort region)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].Region = region;
        }
        public void SetEffect(uint x, uint y, ushort effect)
        {
            if (!InRange(x, y))
                throw new Exception("Coordinates out of range! (" + x.ToString() + "," + y.ToString() + ")");
            map[y, x].Effect = effect;
        }

        //-- Private Methods --//
        private bool InRange(uint x, uint y)
        {
            return (x < iWidth && y < iHeight);
        }
    }
}
