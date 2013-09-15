using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
namespace Furcadia.Net
{
    /// <summary>
    /// Current Dream information
    /// </summary>
    public class DREAM
    {
         /// <summary>
        /// Dream List
        /// Furcadia requires Clients to handle thier own Dream Lists
        /// See http://dev.furcadia.com/docs New Movement for Spawn and Remove packets
        /// **Spawn is out dated. 
        ///   New information requires a 4byte for AFK flag at the end
        /// </summary>
        public static Dictionary<uint, FURRE> List = new Dictionary<uint, FURRE>();

        private string _Name, _Title, _Lines, _Rating, _URL, _Owner;

        public string Owner
        {
            get { return _Owner; }
            set { _Owner = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string Lines
        {
            get { return _Lines; }
            set { _Lines = value; }
        }
        public string Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
        }
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        public void Clear()
        {
            List.Clear();
            _Owner = "";
            _Name = "";
            _Title = "";
            _Lines = "";
            _Rating = "";
            _URL = "";
        }

    }

     
        public struct FURRE
        {

            private string _Name;
            private string _Color;
            private string _Desc;
            private string _Message;
            private char _ColorType;
            private uint _X;
            private uint _Y;
            private uint _SourceX;
            private uint _SourceY;
            private uint _ID;
            private int _Gender;
            private int _Species;
            private int _Special;
            private int _DSSpecies;
            private uint _Position;
            private uint _Shape;
            private int _Flag;
            private TimeSpan _AFK;
            private int _LastStat;
            private int _Wings;
            private bool _Visible;
            private bool _WasVisible;
            private string _badge;
            private string _tag;
            private int _group;
            private int _level; 
            private int _option;
            private int _option1;
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public string Message
            {
                get { return _Message; }
                set { _Message = value; }
            }
            public string ShortName
            {
                get
                {
                    return Regex.Replace(_Name.ToLower(), "[^a-z0-9\0x0020_.]+", "");

                }
            }

            public char ColorType
            {
                get { return _ColorType; }
                set { _ColorType = value; }
            }

            public uint Shape
            {
                get { return _Shape; }
                set 
                {
                    _LastStat = 1;
                    _Shape = value; 
                }
            }
            public Avatar.Frame FrameInfo
            {
                get 
                {
                     return Avatar.SpecNum((int)_Shape);
                }
            }
            public string Color
            {
                get { return _Color; }
                set
                {
                    _Color = value;
                    if (_Color.Length == 14)
                    {
                         _Species = (int) Base220.ConvertFromBase220(_Color.Substring(12, 1));
                         _Gender = (int) Base220.ConvertFromBase220(_Color.Substring(11, 1));
                         _Special = (int) Base220.ConvertFromBase220(_Color.Substring(13, 1));

                        _DSSpecies = SpeciesTable.SpecNum((int)_Species, (int)_Special);
                        _Wings = SpeciesTable.WingsNum((int)_Species, (int)_Special);
                        _LastStat = 0;
                    }
                }

            }
            public string Desc
            {
                get { return _Desc; }
                set { _Desc = value; }
            }
            public uint X
            {
                get { return _X; }
                set 
                {
                    _SourceX = _X;
                    _X = value; 
                }
            }
            public uint Y
            {
                get { return _Y; }
                set 
                {
                    _SourceY = _Y;
                    _Y = value; 
                }

            }
            public uint SourceX
            {
                get { return _SourceX; }
                set {}
            }
            public uint SourceY
            {
                get { return _SourceY; }
                set {}
            }
            public uint ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            public int Flag
            {
                get { return _Flag; }
                set { _Flag = value; }
            }
            public string Badge
            {
                get { return _badge; }
                set 
                {
                    _badge = value;
                    _tag = Badges.GetTag(_badge);
                    _group = Badges.GetGroup(_badge);
                    _level = Badges.GetLevel(_badge);
                }
            }
            public string Tag
            {
                get { return _tag; }
            }
            public int Group
            {
                get { return _group; }
            }
            public int Level
            {
                get { return _level; }
            }
            public int Option
            {
                get { return _option; }
                set { _option = value; }
            }
            public int Option1
            {
                get { return _option1; }
                set { _option1 = value; }
            }
            public TimeSpan AFK
            {
                get { return _AFK; }
                set { _AFK = value; }
            }
            public int LastStat
            {
                get { return _LastStat; }
            }
            public  int Gender
            {
                get { return _Gender; }
             
            }
            public  int Species
            {
                get { return _Species; }
             
            }
            public  int DSSpecies
            {
                get { return _DSSpecies; }

            }
            public int Wings
            {
                get { return _Wings; }

            }
            public int Special
            {
                get { return _Special; }
                set { _Special = value; }
            }
            public bool Visible
            {
                get { return _Visible; }
                set
                {
                    _WasVisible = _Visible;
                    _Visible = value; 
                }
            }
            public bool WasVisible
            {
                get { return _WasVisible; }
            }
            public void Clear()
            {
                _Name = "";
                _Message = "";
                _ColorType = '\0';
                _Color = "#";
                _Desc = null;
                _X = 0;
                _Y = 0;
                _SourceX = 0;
                _SourceY = 0;
                _Shape = 0;
                _ID = 0;
                _Flag = 0;
                _tag = "";
                _badge = "";
                _group = 0;
                _level = 0;
                _option = 0;
                _option1 = 0;
                _AFK = new TimeSpan(0, 0, 0, 0, 0);

                // -1 means these haven't been set yet
                _Species = -1;
                _Gender = -1;
                _Special = -1;
                _DSSpecies = -1;
                _LastStat = -1;
                _Wings = -1;
                _Visible = false;
                _WasVisible = false;
            }
        
    }

    /// <summary>
    /// Furcadia reconmended Material to support thier Protocol Standards
    /// </summary>
    public class Movement
    {
        public enum Flags
        {
        CHAR_FLAG_HAS_PROFILE = 1, 
        CHAR_FLAG_SET_VISIBLE = 2,
        CHAR_FLAG_NEW_AVATAR = 4,
        }
      
    }
  



}
