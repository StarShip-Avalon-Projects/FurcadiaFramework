/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;
using System.IO;

namespace Furcadia
{
    /// <summary>
    /// Utility class with helper functions.
    /// </summary>
    public static class Util
    {
        private static string _host = "lightbringer.furcadia.com";

        /// <summary>
        /// Gets or sets the Furcadia server host (i.e lightbringer.furcadia.com).
        /// </summary>
        public static string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        private static string _ip = "72.36.220.249";
        /// <summary>
        /// Gets or sets the IP of the Furcadia server.
        /// </summary>
        public static IPAddress Ip
        {
            get { return IPAddress.Parse(_ip); }
            set { _ip = value.ToString(); }
        }
    }
}
