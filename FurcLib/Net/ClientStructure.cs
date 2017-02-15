using System;

namespace Furcadia.Net
{
    public class ClientStruct
    {
        public struct BOT
        {
            private string _ColorType, _Color, _Desc, _Name, _Owner, _Msg, _Password, _Script;
            private uint _ID, _Shape, _ITEM, _Logins, _Flag;
            private int _X, _Y;
            private TimeSpan _AFK;

            public uint Flag
            {
                get { return _Flag; }
                set { _Flag = value; }
            }

            public string ColorType
            {
                get { return _ColorType; }
                set { _ColorType = value; }
            }

            public string Color
            {
                get { return _Color; }
                set { _Color = value; }
            }

            public uint Shape
            {
                get { return _Shape; }
                set { _Shape = value; }
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

            public uint ID
            {
                get { return _ID; }
                set { _ID = value; }
            }

            public uint ITEM
            {
                get { return _ITEM; }
                set { _ITEM = value; }
            }

            public uint LOGINS
            {
                get { return _Logins; }
                set { _Logins = value; }
            }

            public TimeSpan AFK
            {
                get { return _AFK; }
                set { _AFK = value; }
            }

            public void Clear()
            {
                _Color = "";
                _Desc = "";
                _Name = "";
                _Owner = "";
                _X = 0;
                _Y = 0;
                _Msg = "";
                _Script = "";
                _Password = "";
                _ID = 0;
                _ITEM = 0;
                _Logins = 0;
                _ColorType = "";
            }
        }
    }
}