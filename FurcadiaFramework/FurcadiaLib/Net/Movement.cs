using System;
using System.Collections.Generic;
using System.Text;

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
        private uint _X;
        private uint _Y;
        private uint _ID;
        private uint _Flag;
        private TimeSpan _AFK;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
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
        public uint X
        {
            get { return _X; }
            set { _X = value; }
        }
        public uint Y
        {
            get { return _Y; }
            set { _Y = value; }

        }
        public uint ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public uint Flag
        {
            get { return _Flag; }
            set { _Flag = value; }
        }
        public TimeSpan AFK
        {
            get { return _AFK; }
            set { _AFK = value; }
        }
    }

    /// <summary>
    /// Furcadia reconmended Material to support thier Protocol Standards
    /// </summary>
    class Movement
    {
        public enum Flags
        {
        CHAR_FLAG_HAS_PROFILE = 1, 
        CHAR_FLAG_SET_VISIBLE = 2,
        CHAR_FLAG_NEW_AVATAR = 4,
        }

        
    }
}
