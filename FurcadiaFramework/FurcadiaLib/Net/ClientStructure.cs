using System;
using System.Collections.Generic;
using System.Text;

namespace Furcadia.Net
{
    public class ClientStruct
    {
       
        public class DREAM
        {
            public static Dictionary<string, FURRE> Furres = new Dictionary<string, FURRE>();
            private string _Name, _Title, _Lines,  _Rating, _URL, _Owner;
            
            public  string Owner
            {
               get { return _Owner;  }
               set { _Owner = value;  }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public  string Title
            {
               get { return _Title;  }
               set { _Title = value;  }
            }
            public string Lines
            {
                get { return _Lines; }
                set { _Lines = value; }
            }
            public  string Rating
            {
               get { return _Rating;  }
               set { _Rating = value;  }
            }
            public  string URL
            {
               get { return _URL;  }
               set { _URL = value;  }
            }
            
            
            public void Clear()
            {
                Furres.Clear();
                _Owner = "";
                _Name = "";
                _Title = "";
                _Lines = "";
                _Rating = "";
                _URL = "";
            }
        }
        public  struct BOT
        {
            private string _Color, _Desc,_Name, _Owner, _Msg, _Password, _Script;
            private int _X, _Y, _ID, _ITEM, _Logins;
            public string Color
            {
                get { return _Color; }
                set { _Color = value; }
            }
            public string Desc
            {
                get { return _Desc; }
                set { _Desc = value; }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public string Owner
            {
                get { return _Owner; }
                set { _Owner = value; }
            }
            public string Msg
            {
                get { return _Msg; }
                set { _Msg = value; }
            }
            public string Script
            {
                get { return _Script; }
                set { _Script = value; }
            }
            public string Password
            {
                get { return _Password; }
                set { _Password = value; }
            }
            public int X
            {
                get { return _X; }
                set { _X = value; }
            }
            public int Y
            {
                get { return _Y; }
                set { _Y = value; }
            }
            public int ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            public int ITEM
            {
                get { return _ITEM; }
                set { _ITEM = value; }
            }
            public int LOGINS
            {
                get { return _Logins; }
                set { _Logins = value; }
            }
            public void Clear()
            {
             _Color = " ";
             _Desc = " ";
             _Name = " ";
             _Owner = " ";
             _X = 0;
             _Y = 0;
             _Msg = " ";
             _Script = " ";
             _Password = " ";
             _ID = 0;
             _ITEM = 0;
             _Logins = 0;
            }
        }
        public struct FURRE
        {

        private string _Name;
        private string _Color;
        private string _Desc;
        private uint _X;
        private uint _Y;
        private string _Msg;
        private uint _ID;
        public uint EID;

        public string Name 
        {
            get {return _Name;}
            set { _Name = value;}
        }
        public string Color
        {
            get {return _Color; }
            set {_Color = value;}
        
        }
        public string Desc
        {
            get { return _Desc;}
            set { _Desc = value; }
        }
        public uint X
        {
            get { return _X; }
            set { _X = value; }
        }
        public uint  Y
        {
            get { return _Y;}
            set { _Y = value;}
             
        }
        public string Msg {
            get {return _Msg;}
            set { _Msg = value;}
             
        }
        public uint ID
        {
            get { return _ID;}
            set { _ID = value;}
        }
    }
}
}