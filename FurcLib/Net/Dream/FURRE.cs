using Furcadia.Drawing;
using Furcadia.Text;
using System;
using static Furcadia.Util;

namespace Furcadia.Net
{
    /// <summary>
    /// Class for Proxies and bots to use Furrre Data provided by the game server.
    /// </summary>
    public class FURRE
    {
        #region Private Fields

        private int _AFK;
        private string _badge;
        private string _Color;
        private char _ColorType;
        private string _Desc;
        private int _DSSpecies;
        private int _Flag;
        private uint _FloorObjectCurrent;
        private uint _FloorObjectOld;
        private int _Gender;
        private int _group;
        private int _ID;
        private int _LastStat;
        private int _level;
        private string _Message;
        private string _Name;
        private int _option;
        private int _option1;
        private uint _PawObjectCurrent;
        private uint _PawObjectOld;
        private int _Shape;
        private int _Special;
        private int _Species;
        private string _tag;
        private bool _Visible;
        private bool _WasVisible;
        private int _Wings;
        private FurrePosition Location;
        private FurrePosition SourceLocation;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// </summary>
        public FURRE()
        {
            _ColorType = '\0';
            _Color = "#";
            Location = new FurrePosition();
            LastPosition = new FurrePosition();
            // -1 means these haven't been set yet
            _Species = -1;
            _Gender = -1;
            _Special = -1;
            _DSSpecies = -1;
            _LastStat = -1;
            _Wings = -1;
        }

        /// <summary>
        /// </summary>
        /// <param name="FurreID">
        /// </param>
        public FURRE(int FurreID)
        {
            _ID = FurreID;
            _ColorType = '\0';
            _Color = "#";
            Location = new FurrePosition();
            LastPosition = new FurrePosition();
            // -1 means these haven't been set yet
            _Species = -1;
            _Gender = -1;
            _Special = -1;
            _DSSpecies = -1;
            _LastStat = -1;
            _Wings = -1;
        }

        /// <summary>
        /// Furre Constructor with Name
        /// </summary>
        /// <param name="Name">
        /// </param>
        public FURRE(string Name)
        {
            _Name = Name;
            _ColorType = '\0';
            _Color = "#";
            Location = new FurrePosition();
            LastPosition = new FurrePosition();
            // -1 means these haven't been set yet
            _Species = -1;
            _Gender = -1;
            _Special = -1;
            _DSSpecies = -1;
            _LastStat = -1;
            _Wings = -1;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Away from keyboard time
        /// </summary>
        public int AFK
        {
            get { return _AFK; }
            set { _AFK = value; }
        }

        /// <summary>
        /// </summary>
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

        /// <summary>
        /// Furcadia Color Code
        /// </summary>
        public string Color
        {
            //TODO: Move section to a Costume Sub Class
            // Furcadia now supports Costumes through Online FurEd
            get { return _Color; }
            set
            {
                _Color = value;

                // Color Tag expanded 2 bytes
                if (_Color.Length == 14)
                {
                    _Species = Base220.ConvertFromBase220(_Color.Substring(12, 1));
                    _Gender = Base220.ConvertFromBase220(_Color.Substring(11, 1));
                    _Special = Base220.ConvertFromBase220(_Color.Substring(13, 1));

                    _DSSpecies = SpeciesTable.SpecNum(_Species, _Special);
                    _Wings = SpeciesTable.WingsNum(_Species, _Special);
                    _LastStat = 0;
                }
            }
        }

        /// <summary>
        /// </summary>
        public char ColorType
        {
            get { return _ColorType; }
            set { _ColorType = value; }
        }

        /// <summary>
        /// Furcadia Description
        /// </summary>
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        /// <summary>
        /// </summary>
        public int DSSpecies
        {
            get { return _DSSpecies; }
        }

        /// <summary>
        /// </summary>
        public int Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }

        /// <summary>
        /// </summary>
        public uint FloorObjectCurrent
        {
            get { return _FloorObjectCurrent; }
            set
            {
                _FloorObjectOld = _FloorObjectCurrent;
                _FloorObjectCurrent = value;
            }
        }

        /// <summary>
        /// </summary>
        public uint FloorObjectOld
        {
            get { return _FloorObjectOld; }
            set { _FloorObjectOld = value; }
        }

        /// <summary>
        /// </summary>
        public Avatar.Frame FrameInfo
        {
            get
            {
                return Avatar.SpecNum(_Shape);
            }
        }

        /// <summary>
        /// </summary>
        public int Gender
        {
            get { return _Gender; }
        }

        /// <summary>
        /// </summary>
        public int Group
        {
            get { return _group; }
        }

        /// <summary>
        /// Furre ID
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// The Position the Furre Moved from
        /// </summary>
        public FurrePosition LastPosition
        {
            get { return SourceLocation; }
            set { SourceLocation = value; }
        }

        /// <summary>
        /// </summary>
        public int LastStat
        {
            get { return _LastStat; }
        }

        /// <summary>
        /// </summary>
        public int Level
        {
            get { return _level; }
        }

        /// <summary>
        /// Last Message Furre had
        /// </summary>
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>
        /// Furcadia Name
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// </summary>
        public int Option
        {
            get { return _option; }
            set { _option = value; }
        }

        /// <summary>
        /// </summary>
        public int Option1
        {
            get { return _option1; }
            set { _option1 = value; }
        }

        /// <summary>
        /// </summary>
        public uint PawObjectCurrent
        {
            get { return _PawObjectCurrent; }
            set
            {
                _PawObjectOld = _PawObjectCurrent;
                _PawObjectCurrent = value;
            }
        }

        /// <summary>
        /// </summary>
        public uint PawObjectOld
        {
            get { return _PawObjectOld; }
            set { _PawObjectOld = value; }
        }

        /// <summary>
        /// Current position where the Furre is standing
        /// </summary>
        public FurrePosition Position
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }

        /// <summary>
        /// </summary>
        public int Shape
        {
            get { return _Shape; }
            set
            {
                _LastStat = 1;
                _Shape = value;
            }
        }

        /// <summary>
        /// Furcadia Shortname format for Furre Name
        /// </summary>
        public string ShortName
        {
            get
            {
                return FurcadiaShortName(_Name);
            }
        }

        /// <summary>
        /// the X Position the Furre moved from
        /// <para>
        /// Obsolete. Use LasPosition as FurrePosition
        /// </para>
        /// </summary>
        [Obsolete]
        public int SourceX
        {
            get { return LastPosition.x; }
            set { LastPosition.x = value; }
        }

        /// <summary>
        /// the Y Position the Furre moved from
        /// <para>
        /// Obsolete. Use LasPosition as FurrePosition
        /// </para>
        /// </summary>
        [Obsolete]
        public int SourceY
        {
            get { return LastPosition.y; }
            set { LastPosition.y = value; }
        }

        /// <summary>
        /// </summary>
        public int Special
        {
            get { return _Special; }
            set { _Special = value; }
        }

        /// <summary>
        /// </summary>
        public int Species
        {
            get { return _Species; }
        }

        /// <summary>
        /// </summary>
        public string Tag
        {
            get { return _tag; }
        }

        /// <summary>
        /// </summary>
        public bool Visible
        {
            get { return _Visible; }
            set
            {
                _WasVisible = _Visible;
                _Visible = value;
            }
        }

        /// <summary>
        /// </summary>
        public bool WasVisible
        {
            get { return _WasVisible; }
        }

        /// <summary>
        /// </summary>
        public int Wings
        {
            get { return _Wings; }
        }

        /// <summary>
        /// the X Position the Furre is currently standing at
        /// <para>
        /// Obsolete. Use Position as FurrePosition
        /// </para>
        /// </summary>
        [Obsolete]
        public int X
        {
            get { return Position.x; }
            set { Position.x = value; }
        }

        /// <summary>
        /// the Y Position the Furre Standing At
        /// <para>
        /// Obsolete. Use Position as FurrePosition
        /// </para>
        /// </summary>
        [Obsolete]
        public int Y
        {
            get { return Position.y; }
            set { Position.y = value; }
        }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// </summary>
        /// <param name="obj">
        /// </param>
        /// <returns>
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() == typeof(FURRE))
            {
                FURRE ob = (FURRE)obj;
                if (string.IsNullOrEmpty(ShortName))
                    return ob.ID == ID;
                return ob.ShortName == ShortName;
            }
            return base.Equals(obj);
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public int ToFurcadiaID()
        {
            return _ID;
        }

        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <returns>
        /// </returns>
        public int ToFurcadiaID(Func<FURRE, int> format)
        {
            if (format != null)
                return format(this);
            return ToFurcadiaID();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }

        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <returns>
        /// </returns>
        public string ToString(Func<FURRE, string> format)
        {
            if (format != null)
                return format(this);
            return this.ToString();
        }

        #endregion Public Methods
    }
}