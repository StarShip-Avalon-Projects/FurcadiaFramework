/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
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

        /// <summary>
        /// Gets the path to the Furcadia program folder.
        /// </summary>
        public static string Path
        {
            get
            {
                try
                {
                    object ret = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Dragon's Eye Productions\Furcadia\Programs", "Path", null);
                    if (ret == null)
                        ret = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Dragon's Eye Productions\Furcadia\Programs", "Path", null);
                    if (ret == null)
                        throw new NullReferenceException("Registry value to Furcadia's default directory not found. Do you have Furcadia installed on your system?");
                    if (ret != null ) 
                        if (!ret.ToString().EndsWith(@"\")) ret = ret.ToString() +  @"\";
                        return ret.ToString();
                }
                catch { 
                    throw new NullReferenceException("There was an error trying to retrieve the Furcadia default directory path information. Do you have Furcadia installed on your system?"); }
            }
        }
    }
}
