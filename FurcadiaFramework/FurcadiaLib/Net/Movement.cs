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

    public  struct FURRE
    {

        private string _Name;
        private string _Color;
        private string _Desc;
        private char _ColorType;
        private uint _X;
        private uint _Y;
        private uint _ID;
        private uint _Position;
        private string _Shape;
        private int _Flag;
        private TimeSpan _AFK;


        public  string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public  string ShortName
        {
            get { return Regex.Replace(_Name.ToLower(), "[^a-zA-Z0-9\0x0020_.]+", ""); }
        }
       
        public  char ColorType
        {
            get { return _ColorType; }
            set { _ColorType = value; }
        }

        // frames = 1 + Position + (Direction * 4) + (Species * 20)
        // specis mod 20
        public  uint Position
        {
            get  { 
           return Base220.ConvertFromBase220(_Shape) % 20;
            
            }
        }
        public uint Direction
        {
            get { return Position / 4; }
        }
        public string Shape
        {
            get { return _Shape; }
            set { _Shape = value; }
        }

        public  string Color
        {
            get { return _Color; }
            set { _Color = value; }

        }
        public  string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }
        public  uint X
        {
            get { return _X; }
            set { _X = value; }
        }
        public  uint Y
        {
            get { return _Y; }
            set { _Y = value; }

        }
        public  uint ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public  int Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }
        public   TimeSpan AFK
        {
            get { return _AFK; }
            set { _AFK = value; }
        }
        public uint trousers
        {
            get { return Base220.ConvertFromBase220(_Color.Substring(10, 1)); }
        }
        public  uint Gender
        {
            get { return Base220.ConvertFromBase220(_Color.Substring(11, 1)); }
        }
        public  uint Species
        {
            get { return Base220.ConvertFromBase220(_Color.Substring(12, 1)); }
        }

        public  uint Special
        {
            get { return Base220.ConvertFromBase220(_Color.Substring(13, 1)); }
        }
        public void Clear()
        {
            _Name = "";
            _ColorType = '\0';
            _Color = "";
            _Desc = "";
            _X = 0;
            _Y = 0;
            _Shape = "";
            _ID = 0;
            _Flag = 0;
            _AFK = new TimeSpan(0, 0, 0, 0, 0);
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
    public class Color
    {

/************************************************************************/
/* avatar.gm                                                            */
/* Import script defining avatar public constants and                   */
/* functions to extract avatar information from frame numbers           */
/************************************************************************/

        public const uint AVCLASS_MIN = 1;
        public enum AVCLASS
        {
           
           RODENT        = 1,
           EQUINE        = 21,
           FELINE        = 41,
           CANINE        = 61,
           MUSTELINE     = 81,
           LAPINE        = 101,
           RODENTCW      = 121,
           EQUINECW      = 141,
           FELINECW      = 161,
           CANINECW      = 181,
           MUSTELINECW   = 201,
           KIWI          = 221,
           LAPINECW      = 241,
           DRAGON        = 261,
           PHOENIX       = 281,

           RODENTTW      = 501,
           EQUINETW      = 521,
           FELINETW      = 541,
           CANINETW      = 561,
           MUSTELINETW   = 581,
           LAPINETW      = 601,
           RODENTFW      = 661,
           EQUINEFW      = 681,
           FELINEFW      = 701,
           CANINEFW      = 721,
           MUSTELINEFW   = 741,
           LAPINEFW      = 761,
           GRYFFE        = 781,
           EAGLE         = 801,
           RODENTBW      = 821,
           EQUINEBW      = 841,
           FELINEBW      = 861,
           CANINEBW      = 881,
           MUSTELINEBW   = 901,
           LAPINEBW      = 921,
           SCIURINE      = 941,
           SCIURINECW    = 961,
           SCIURINETW    = 981,
           SCIURINEFW    = 1001,
           SCIURINEBW    = 1021,
           BOVINE        = 1041,
           BOVINECW      = 1061,
           BOVINETW      = 1081,
           BOVINEFW      = 1101,
           BOVINEBW      = 1121,
           RODENTPW      = 1141,
           EQUINEPW      = 1161,
           FELINEPW      = 1181,
           CANINEPW      = 1201,
           MUSTELINEPW   = 1221,
           LAPINEPW      = 1241,
           SCIURINEPW    = 1261,
           BOVINEPW      = 1281,
           PIXIE         = 1301,
           KITTER        = 1321,
           WOLVEN        = 1341,
           URSINE        = 1361,
           URSINECW      = 1381,
           URSINETW      = 1401,
           URSINEFW      = 1421,
           URSINEBW      = 1441,
           URSINEPW      = 1461,
           TYGARD        = 1481,
           LEONEN        = 1501,
           WEREWOLF      = 1521,
           PENGUIN       = 1541,
           BAT           = 1561,
           FOXEN         = 1581,
           FLOXEN        = 1601,
           UNICORN       = 1621,
           FURLINGM      = 1641,
           FURLINGF      = 1661,
           CHINCHILLA    = 1681,
           TOASTER       = 1701,
           BUGGE         = 1721,
           KIRIN         = 1741,
           KIRINCLOUD    = 1761,
           NOBLECANINEM  = 1781,
           NOBLECANINEF  = 1801,
           NOBLEFELINEM  = 1821,
           NOBLEFELINEF  = 1841,
           REINDEER      = 1861,
           CATTEN        = 1881,
           OWLEN         = 1901,
           LOVEBIRD      = 1921,
           RABBEN        = 1941,
           NOBLEEQUINEM  = 1961,
           NOBLEEQUINEF  = 1981,
           WOOLIE        = 2001,
           TOYTLE        = 2021,
           TUSKER        = 2041,
           NOBLERODENTM  = 2061,
           NOBLERODENTF  = 2081,
           NOBLEHUMANM   = 2101,
           NOBLEHUMANF   = 2121,
           PANOOKI       = 2141,
           NAGA          = 2161,

//Locals
           LOCAL1        = 7001,
           LOCAL2        = 7021,
           LOCAL3        = 7041,
           LOCAL4        = 7061,
           LOCAL5        = 7081,
           LOCAL6        = 7101,
           LOCAL7        = 7121,
           LOCAL8        = 7141,
           LOCAL9        = 7161,
           LOCAL10       = 7181,
           LOCAL11       = 7201,
           LOCAL12       = 7221,
//Dynamic Slots
           DYN1        = 10001,
           DYN2        = 10021,
           DYN3        = 10041,
           DYN4        = 10061,
           DYN5        = 10081,
           DYN6        = 10101,
           DYN7        = 10121,
           DYN8        = 10141,
           DYN9        = 10161,
           DYN10       = 10181,
           DYN11       = 10201,
           DYN12       = 10221,
           DYN13       = 10241,
           DYN14       = 10261,
           DYN15       = 10281,
           DYN16       = 10301,
           DYN17       = 10321,
           DYN18       = 10341,
           DYN19       = 10361,
           DYN20       = 10381,

           
        }
public const uint AVCLASS_MAX = 10400; //7240; //2060;
        public enum AVPOSE{
            SIT   = 0,
            WALK0 = 1,
            STAND = 2,
            WALK1 = 3,
            LIE   = 4,
        }
        public enum AVDIR{
            SW = 0,
            SE = 1,
            NW = 2,
            NE = 3,
        }
//public enum av_FRAME2CLASS
//{
//   AVCLASS_RODENT,
//   AVCLASS_EQUINE,
//   AVCLASS_FELINE,
//   AVCLASS_CANINE,
//   AVCLASS_MUSTELINE,
//   AVCLASS_LAPINE,
//   AVCLASS_RODENTCW,
//   AVCLASS_EQUINECW,
//   AVCLASS_FELINECW,
//   AVCLASS_CANINECW,
//   AVCLASS_MUSTELINECW,
//   AVCLASS_KIWI,
//   AVCLASS_LAPINECW,
//   AVCLASS_DRAGON,
//   AVCLASS_PHOENIX,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_RODENTTW,
//   AVCLASS_EQUINETW,
//   AVCLASS_FELINETW,
//   AVCLASS_CANINETW,
//   AVCLASS_MUSTELINETW,
//   AVCLASS_LAPINETW,
//   AVCLASS_MIN,
//   AVCLASS_MIN,
//   AVCLASS_RODENTFW,
//   AVCLASS_EQUINEFW,
//   AVCLASS_FELINEFW,
//   AVCLASS_CANINEFW,
//   AVCLASS_MUSTELINEFW,
//   AVCLASS_LAPINEFW,
//   AVCLASS_GRYFFE,
//   AVCLASS_EAGLE,
//   AVCLASS_RODENTBW,
//   AVCLASS_EQUINEBW,
//   AVCLASS_FELINEBW,
//   AVCLASS_CANINEBW,
//   AVCLASS_MUSTELINEBW,
//   AVCLASS_LAPINEBW,
//   AVCLASS_SCIURINE,
//   AVCLASS_SCIURINECW,
//   AVCLASS_SCIURINETW,
//   AVCLASS_SCIURINEFW,
//   AVCLASS_SCIURINEBW,
//   AVCLASS_BOVINE,
//   AVCLASS_BOVINECW,
//   AVCLASS_BOVINETW,
//   AVCLASS_BOVINEFW,
//   AVCLASS_BOVINEBW,
//   AVCLASS_RODENTPW,
//   AVCLASS_EQUINEPW,
//   AVCLASS_FELINEPW,
//   AVCLASS_CANINEPW,
//   AVCLASS_MUSTELINEPW,
//   AVCLASS_LAPINEPW,
//   AVCLASS_SCIURINEPW,
//   AVCLASS_BOVINEPW,
//   AVCLASS_PIXIE,
//   AVCLASS_KITTER,
//   AVCLASS_WOLVEN,
//   AVCLASS_URSINE,
//   AVCLASS_URSINECW,
//   AVCLASS_URSINETW,
//   AVCLASS_URSINEFW,
//   AVCLASS_URSINEBW,
//   AVCLASS_URSINEPW,
//   AVCLASS_TYGARD,
//   AVCLASS_LEONEN,
//   AVCLASS_WEREWOLF,
//   AVCLASS_PENGUIN,
//   AVCLASS_BAT,
//   AVCLASS_FOXEN,
//   AVCLASS_FLOXEN,
//   AVCLASS_UNICORN,
//   AVCLASS_FURLINGM,
//   AVCLASS_FURLINGF,
//   AVCLASS_CHINCHILLA,
//   AVCLASS_TOASTER,
//   AVCLASS_BUGGE,
//   AVCLASS_KIRIN,
//   AVCLASS_KIRINCLOUD,
//   AVCLASS_NOBLECANINEM,
//   AVCLASS_NOBLECANINEF,
//   AVCLASS_NOBLEFELINEM,
//   AVCLASS_NOBLEFELINEF,
//   AVCLASS_REINDEER,
//   AVCLASS_CATTEN,
//   AVCLASS_OWLEN,
//   AVCLASS_LOVEBIRD,
//   AVCLASS_RABBEN,
//   AVCLASS_NOBLEEQUINEM,
//   AVCLASS_NOBLEEQUINEF,
//   AVCLASS_WOOLIE,
//   AVCLASS_TOYTLE,
//   AVCLASS_TUSKER,
//   AVCLASS_NOBLERODENTM,
//   AVCLASS_NOBLERODENTF,
//   AVCLASS_NOBLEHUMANM,
//   AVCLASS_NOBLEHUMANF,
//   AVCLASS_PANOOKI,
//   AVCLASS_NAGA
//}

public enum av_FRAME2LOCALCLASS   //Separated due to massive number jump
{
   AVCLASS_LOCAL1,
   AVCLASS_LOCAL2,
   AVCLASS_LOCAL3,
   AVCLASS_LOCAL4, 
   AVCLASS_LOCAL5,
   AVCLASS_LOCAL6,
   AVCLASS_LOCAL7,
   AVCLASS_LOCAL8,
   AVCLASS_LOCAL9,
   AVCLASS_LOCAL10,
   AVCLASS_LOCAL11,
   AVCLASS_LOCAL12  
}

public enum av_FRAME2DYNCLASS  //Also separated due to large jumps
{
   AVCLASS_DYN1,
   AVCLASS_DYN2,
   AVCLASS_DYN3,
   AVCLASS_DYN4,
   AVCLASS_DYN5,
   AVCLASS_DYN6,
   AVCLASS_DYN7,
   AVCLASS_DYN8,
   AVCLASS_DYN9,
   AVCLASS_DYN10,
   AVCLASS_DYN11,
   AVCLASS_DYN12,
   AVCLASS_DYN13,
   AVCLASS_DYN14,
   AVCLASS_DYN15,
   AVCLASS_DYN16,
   AVCLASS_DYN17,
   AVCLASS_DYN18,
   AVCLASS_DYN19,
   AVCLASS_DYN20
}

public enum av_FRAME2DIR 
{
   AVDIR_SW,
   AVDIR_SE,
   AVDIR_NW,
   AVDIR_NE,
}

public enum av_FRAME2DIR2 
{
   AVDIR_SW,
   AVDIR_SE,
   AVDIR_NE,
   AVDIR_NW,
}

public enum av_FRAME2POSE 
{
   AVPOSE_SIT,
   AVPOSE_WALK0,
   AVPOSE_STAND,
   AVPOSE_WALK1,
   AVPOSE_LIE,
}

        static DataTable GetTable()
        {
            DataTable ColorTable = new DataTable();
            ColorTable.Columns.Add("species", typeof(AVCLASS));
            ColorTable.Columns.Add("dir", typeof(AVDIR));
            ColorTable.Columns.Add("pose", typeof(AVPOSE));
            ColorTable.Rows.Add();
            return ColorTable;
        }

/** Extracts info from a frame.
* 'frame' should be an integer.
* Returns a table with 'class', 'dir', and 'pose' keys. */
//public uint av_frameInfo( uint frame )
//{




// av_FRAME2LOCALCLASS test =  av_FRAME2LOCALCLASS.GetName((frame - 10001) / 20);
     
     
     
//  DataTable ColorTable = GetTable();
//   if (frame >= AVCLASS_MIN && frame <= AVCLASS_MAX)
//   {
//      if (frame >= 7000) { //Localspecies
//       if (frame >= 10000) { //Dynamics
//         ColorTable.species = av_FRAME2DYNCLASS[ (frame - 10001) / 20 ];
//         } else { //LS
//      info.class = av_FRAME2LOCALCLASS.   [ (frame - 7001) / 20 ];
//       }
//       } else { //Normal species range
//      info.class = av_FRAME2CLASS[ (frame - 1) / 20 ]; 
//       }
//      frame -= info.class;
         
//      if (frame <= 15)
//      {
//         if (info.class != AVCLASS_KIWI) {
//            info.dir  = av_FRAME2DIR[ frame / 4 ];
//         }
//         else {
//            info.dir  = av_FRAME2DIR2[ frame / 4 ];
//         }
            
//         info.pose = av_FRAME2POSE[ frame % 4 ];
//      }
//      else
//      {
//         info.dir  = av_FRAME2DIR2[ frame - 16 ];
//         info.pose = av_FRAME2POSE[ 4 ];
//      }
//   }
   
//   return info;
//};

/** Converts avatar info into a frame number.
* 'info' should be a table with class, dir, and pose keys.
* Returns an integer. */
//public av_makeFrame = function( info )
//{
//   frame = info.class;
      
//   if (info.pose < AVPOSE_LIE) 
//   {
//      if (info.class != AVCLASS_KIWI) {
//         frame += info.dir * 4 + info.pose;
//      }
//      else {
//         frame += av_FRAME2DIR2[ info.dir ] * 4 + info.pose;
//      }      
//   }
//   else {
//      frame += 16 + av_FRAME2DIR2[ info.dir ];
//   }
   
//   if (frame >= AVCLASS_MIN && frame <= AVCLASS_MAX) {
//      return frame;
//   }
   
//   return AVCLASS_MIN;
//};


    }



}
