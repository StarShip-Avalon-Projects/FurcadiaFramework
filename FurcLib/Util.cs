/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

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

        private static string _ip = "72.232.1.177";

        /// <summary>
        /// Gets or sets the IP of the Furcadia server. (Note(7/22/2010): Do not use this. The IP may
        /// be wrong. Use Furcadia.Util.Host instead.
        /// </summary>
        public static IPAddress Ip
        {
            get { return IPAddress.Parse(_ip); }
            set { _ip = value.ToString(); }
        }

        /// <summary>
        /// </summary>
        /// <param name="str">
        /// </param>
        /// <returns>
        /// </returns>
        public static int Base220ToUInt(string str)
        {
            CharEnumerator breakdown;
            int value = 0;
            int i, length = str.Length;
            breakdown = str.GetEnumerator();
            breakdown.MoveNext();
            for (i = 0; i < length - 1; i++)
            {
                value += Convert.ToByte(breakdown.Current - 35) * (220 ^ 1);
                breakdown.MoveNext();
            }
            return value;
        }

        public static string UIntToBase220(uint num, int size)
        {
            int i;
            byte tbyte;
            StringBuilder build = new StringBuilder();
            for (i = 1; i <= size; i++)
            {
                tbyte = Convert.ToByte(num % 220);
                num /= 220;
                build.Append(Convert.ToChar(tbyte + 35));
            }
            return build.ToString();
        }

        /// <summary>
        /// Takes a string and returns Furcadia's short name format
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <returns>
        /// </returns>
        public static string FurcadiaShortName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;
            return Regex.Replace(name.ToLower(), "[^a-z0-9\0x0020_.;&|]+", string.Empty);
        }
    }
}