/****NOTICE: DO NOT REMOVE
 * Credits go to Artex for helping me fix Path issues and
 * contributing some of his code.
 ****NOTICE: DO NOT REMOVE.*/

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace Furcadia.IO
{
    /// <summary>
    /// Contains functions for getting some base paths related to Furcadia.
    /// </summary>
    public class Paths
    {

        private static string _installpath;
        /// <summary>
        /// Find the path to Furcadia data files currently installed on this
        /// system.
        /// </summary>
        /// <returns>Path to the Furcadia program folder or null if not found/not installed.</returns>
        public static string GetInstallPath()
        {
            //If path already found return it.
            if (!string.IsNullOrEmpty(_installpath)) return _installpath;
            string path;

            // Checking registry for a path first of all.
            RegistryKey regkey = Registry.LocalMachine;
            try
			{
                regkey = regkey.OpenSubKey(@"SOFTWARE\Dragon's Eye Productions\Furcadia\Programs", false);
                path = regkey.GetValue("path").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path)){
                    _installpath = path;
                    return path; // Path found
                }
            }
            catch(Exception e)
            {
				Console.WriteLine(e);
                Console.ReadKey();
            }

            // Making a guess from the FurcadiaDefaultPath property.
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        "/Furcadia");
            if (System.IO.Directory.Exists(path))
            {
                _installpath = path;
                return path; // Path found
            }

            // All options were exhausted - assume Furcadia not installed.
            throw new DirectoryNotFoundException();
        }

        private static string _defaultpatchpath;
        /// <summary>
        /// Find the path to the default patch folder on the current machine.
        /// </summary>
        /// <returns>Path to the default patch folder or null if not found.</returns>
        public static string GetDefaultPatchPath()
        {
            //If path already found return it.
            if (!string.IsNullOrEmpty(_defaultpatchpath)) return _defaultpatchpath;
            string path;

            // Checking registry for a path first of all.
            RegistryKey regkey = Registry.LocalMachine;
            try
            {
                regkey = regkey.OpenSubKey(@"SOFTWARE\Dragon's Eye Productions\Furcadia\Patches", false);
                path = regkey.GetValue("default").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path))
                {
                    _defaultpatchpath = path;
                    return path; // Path found
                }
            }
            catch{ //NullReference Exception = regkey not found.
            }

            // Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
            path = GetInstallPath();
            if (path == string.Empty)
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        "/Furcadia");

            path = Path.Combine(path,"/patches/default");

            if (System.IO.Directory.Exists(path))
            {
                _defaultpatchpath = path;
                return path; // Path found
            }

            // All options were exhausted - assume Furcadia not installed.
            return null;
        }

        private static string _localsettingspath;
        /// <summary>
        /// Get the path to the Local Settings directory for Furcadia.
        /// </summary>
        /// <returns>Furcadia local settings directory.</returns>
        public static string GetLocalSettingsPath()
        {
            if (!string.IsNullOrEmpty(_localsettingspath)) return _localsettingspath;
            else _localsettingspath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Dragon's Eye Productions/Furcadia");
            return _localsettingspath;
        }

        private static string _cachepath;
        /// <summary>
        /// Get the All Users Application Data path for Furcadia.
        /// </summary>
        /// <returns>All Users Application Data path for Furcadia.</returns>
        public static string GetCachePath()
        {
            if (!string.IsNullOrEmpty(_cachepath)) return _cachepath;
            else _cachepath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                        "/Dragon's Eye Productions/Furcadia");
            return _cachepath;
        }

        private static string _localdirpath;
        /// <summary>
        /// Find the current localdir path where data files would be stored
        /// on the current machine.
        /// </summary>
        /// <returns>Path to the data folder from localdir.ini or null if not found.</returns>
        public static string GetLocaldirPath()
        {
            if (!string.IsNullOrEmpty(_localdirpath)) return _localdirpath;
            string path;
            string install_path = GetInstallPath();

            // If we can't find Furc, we won't find localdir.ini
            if (install_path == null)
                return null; // Furcadia install path not found.

            // Try to locate localdir.ini
            string ini_path = String.Format("{0}/localdir.ini", install_path);
            if (!System.IO.File.Exists(ini_path))
                return null; // localdir.ini not found - regular path structure applies.

            // Read localdir.ini for remote path and verify it.
            StreamReader sr = new StreamReader(ini_path);
            path = sr.ReadLine();
            path.Trim();
            sr.Close();

            if (!System.IO.Directory.Exists(path))
                return null; // localdir.ini found, but the path in it is missing.
            _localdirpath = path;
            return path; // Localdir path found!
        }
    }
}
