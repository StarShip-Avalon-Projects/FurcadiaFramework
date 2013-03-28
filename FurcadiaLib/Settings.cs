﻿/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using Furcadia.Net;

using Furcadia.IO;

namespace Furcadia
{



    /// <summary>
    /// A simple way to load settings whether from ini or xml.
    /// </summary>
    public class Settings
    {
        /// setting path
        /// setting file
        /// setting fields
        static string sPath = Paths.GetLocalSettingsPath();
        static string sFile = "/settings.ini";
    
        static string[] Keys = new string[4] {"UseProxyOrFirewall", "ProxyHost", "ProxyPort", "SessionCloseCheck"};
        static string[] values = new string[4] { "Yes", "localhost", NetProxy._lport.ToString(), "no" };
        static private string[] FurcSettings;
        private static string[] BackupSettings;

        /// Load and Store settings.ini with backup
        public static Boolean InitializeFurcadiaSettings()
        {
            Boolean Check;
          FurcSettings =  FurcIni.LoadFurcadiaSettings(sPath, sFile);
          BackupSettings = FurcSettings;
          if (FurcSettings != null) Check = true;
          if (BackupSettings != null) Check = true;
          else { Check = false; }
           for (int Key = 0; Key < Keys.Length; Key++)
           {
               Check = Check & FurcIni.SetUserSetting(Keys[Key], values[Key], FurcSettings);
           }
            /// Save settings.ini?
            Check = Check & FurcIni.SaveFurcadiaSettings(sPath, sFile, FurcSettings);
            return Check; 
        }


        /// restore from backup settings.ini

        public static Boolean RestoreFurcadiaSettings()
        {
            Boolean Check;
            /// Get the New Changes by Furcadia Suite
            FurcSettings = FurcIni.LoadFurcadiaSettings(sPath, sFile);
                 if (BackupSettings != null) Check = true;
            else { Check = false; }
            for (int Key = 0; Key < Keys.Length; Key++)
            {
                /// Capture Back up Fields 
                string Value = FurcIni.GetUserSetting(Keys[Key], BackupSettings);
                /// Use Backup for Settings
                Check = Check & FurcIni.SetUserSetting(Keys[Key], Value, FurcSettings);
            }
            /// Save settings.ini
            Check = Check & FurcIni.SaveFurcadiaSettings(sPath, sFile, FurcSettings);
            return Check;
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
                    string[] key_value = line.Split(new char[]{'='},2);
                    if (key_value.Length == 2) ret.Add(key_value[0], key_value[1]);
                }
                return ret;
            }
            else { throw new FileNotFoundException(file); }
        }


        }
    }
