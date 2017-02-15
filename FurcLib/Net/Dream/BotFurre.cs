using System;

namespace Furcadia.Net
{
    /// <summary>
    /// Settings for the Bot Furre
    /// </summary>
    public class BotFurre
    {
        private TimeSpan _AFK;
        private string _ColorType, _Color, _Desc, _Name, _Owner, _Msg, _Password, _Script;
        private uint _ID, _Shape, _ITEM, _Logins, _Flag;
        private int _X, _Y;

        /// <summary>
        /// </summary>
        public BotFurre()
        {
            _Color = string.Empty;
            _Desc = string.Empty;
            _Name = string.Empty;
            _Owner = string.Empty;
            _X = 0;
            _Y = 0;
            _Msg = string.Empty;
            _Script = string.Empty;
            _Password = string.Empty;
            _ID = 0;
            _ITEM = 0;
            _Logins = 0;
            _ColorType = string.Empty;
        }

        public TimeSpan AFK
        {
            get { return _AFK; }
            set { _AFK = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public string ColorType
        {
            get { return _ColorType; }
            set { _ColorType = value; }
        }

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        public uint Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
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

        public string Msg
        {
            get { return _Msg; }
            set { _Msg = value; }
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

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Script
        {
            get { return _Script; }
            set { _Script = value; }
        }

        public uint Shape
        {
            get { return _Shape; }
            set { _Shape = value; }
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
    }
}