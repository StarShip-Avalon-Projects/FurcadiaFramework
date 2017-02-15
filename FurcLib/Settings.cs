/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * (Unknown) Gerolkae, Switched proxy.ini to settings.ini firewall settings to support Vista+
 * (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to wirk with a Supplied path
*/

using Furcadia.IO;
using Furcadia.Net;
using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace Furcadia
{
    /// <summary>
    /// A simple way to load settings whether from ini or xml.
    /// </summary>
    public static class Settings
    {
        /// setting path
        /// setting file
        /// setting fields
        ///

        private static Paths FurcPath = new Paths();

        //static Paths FurcPath = new Paths();
        private static string sPath = FurcPath.GetLocalSettingsPath();

        private static string sFile = "settings.ini";

        private static string[] Keys = new string[9] { "UseProxyOrFirewall", "ProxyHost", "ProxyPort", "SessionCloseCheck", "ProxyHostType", "ProxyCustomType", "ProxyCustomData", "ProxyApplyToFs", "UseTls" };
        private static string[] values = new string[9] { "Yes", "localhost", NetProxy._lport.ToString(), "no", "0", "0", "CONNECT %host% %port%", "no", "no" };

        /// Load and Store settings.ini with backup
        public static string[] InitializeFurcadiaSettings(string path = null)
        {
            string[] FurcSettings = FurcIni.LoadFurcadiaSettings(sPath, sFile);
            string[] Backup = FurcIni.LoadFurcadiaSettings(sPath, sFile);
            for (int Key = 0; Key < Keys.Length; Key++)
            {
                FurcIni.SetUserSetting(Keys[Key], values[Key], FurcSettings);
            }
            /// Save settings.ini?
            FurcIni.SaveFurcadiaSettings(sPath, sFile, FurcSettings);
            return Backup;
        }

        /// restore from backup settings.ini

        public static void RestoreFurcadiaSettings(string[] BackupSettings)
        {
            /// Get the New Changes by Furcadia Suite
            string[] FurcSettings = FurcIni.LoadFurcadiaSettings(sPath, sFile);

            for (int Key = 0; Key < Keys.Length; Key++)
            {
                /// Capture Back up Fields
                string Value = FurcIni.GetUserSetting(Keys[Key], BackupSettings);
                /// Use Backup for Settings
                FurcIni.SetUserSetting(Keys[Key], Value, FurcSettings);
            }
            /// Save settings.ini
            FurcIni.SaveFurcadiaSettings(sPath, sFile, FurcSettings);
        }

        /// <summary>
        /// Loads a xml file and returns a new instance of T. T must be Xml Deserializable!
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
        /// (Add: Also the ini must be proper, one key/value per line. No section garbage.)
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
                    string[] key_value = line.Split(new char[] { '=' }, 2);
                    if (key_value.Length == 2) ret.Add(key_value[0], key_value[1]);
                }
                return ret;
            }
            else { throw new FileNotFoundException(file); }
        }
    }
}