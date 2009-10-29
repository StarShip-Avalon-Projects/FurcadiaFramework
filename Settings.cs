/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Xml.Serialization;

namespace Furcadia
{
    public enum SettingsFormat
    {
        Ini,Xml
    }
    /// <summary>
    /// A simple way to load settings whether from ini or xml.
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Loads a xml file and returns a new instance of T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file"></param>
        /// <returns>Default of T (default(T)) on file not found.  Else it returns a instance of T.</returns>
        public static T Load<T>(string file)
        {
            if (!File.Exists(file)) return default(T);
            try
            {
                StringReader reader = new StringReader(File.ReadAllText(file));
                XmlSerializer xml = new XmlSerializer(typeof(T));
                Console.WriteLine(reader.ToString());
                object newO = (T)xml.Deserialize(reader);
                Console.WriteLine(newO);
                if (newO == null) return default(T);
                return (T)newO;
            }
            catch { return default(T); }
        }

        /// <summary>
        /// Loads an ini file and returns a key/value pair of values.
        /// (Note: It reads Key=Value pairs only.)
        /// (Add: Also the ini must be proper, one key/value per line.)
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A new Hashtable, or a empty Hashtable on file not found.</returns>
        public static Hashtable Load(string file)
        {
            Hashtable ret = new Hashtable();
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    //get key/value!
                    string[] key_value = line.Split('=');
                    if (key_value.Length == 2) ret.Add(key_value[0], key_value[1]);
                }
                return ret;
            }
            else { return ret; }
        }
    }
}
