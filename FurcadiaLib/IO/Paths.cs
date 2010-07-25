/****NOTICE: DO NOT REMOVE
 * Credits go to Artex for helping me fix Path issues and
 * contributing his code.
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
    
    	private static string _FurcadiaDocpath;
    	/// <summary>
    	/// Gets the location of the Furcadia folder located in "My Documents"
    	/// </summary>
    	/// <returns>
    	/// A <see cref="System.String"/> containing the location of Furcadia folder in "My Documents".
    	/// </returns>
    	public static string GetFurcadiaDocPath()
    	{
    		if (!String.IsNullOrEmpty(_FurcadiaDocpath)) return _FurcadiaDocpath;
            string path = GetLocaldirPath();
            if (String.IsNullOrEmpty(path))
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
    					"Furcadia");

    		if (Directory.Exists(path))
    		{
    			_FurcadiaDocpath = path;
    			return _FurcadiaDocpath;
    		}
    		throw new DirectoryNotFoundException("Furcadia documents path not found.\n" + path);
    	}
    	
        /// <summary>
        /// Determines the registry path by platform. (x32/x64)
        /// Thanks to Ioka for this one.
        /// </summary>
        /// <returns>
        /// A path to the Furcadia registry folder or NullReferenceException.
        /// </returns>
        public static string GetRegistryPath()
        {
        	//64x & 32x Untested but should work
            if (IntPtr.Size == 64) //64 bit
                return @"SOFTWARE\Wow6432Node\Dragon's Eye Productions\Furcadia\";
            else if (IntPtr.Size == 32) //32 bit
                return @"SOFTWARE\Dragon's Eye Productions\Furcadia\";
            else return @"SOFTWARE\Dragon's Eye Productions\Furcadia\";
        }

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
                if (IntPtr.Size == 4) //32 bit
                    regkey = regkey.OpenSubKey(GetRegistryPath() + "Programs", false);
                else if (IntPtr.Size == 8) //64 bit
                    regkey = regkey.OpenSubKey(GetRegistryPath() + "Programs", false);
                path = regkey.GetValue("path").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path)){
                    _installpath = path;
                    return _installpath; // Path found
                }
            }
            catch{
            }

            // Making a guess from the FurcadiaDefaultPath property.
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        "Furcadia");
            if (System.IO.Directory.Exists(path))
            {
                _installpath = path;
                return _installpath; // Path found
            }

            // All options were exhausted - assume Furcadia not installed.
            throw new DirectoryNotFoundException("Furcadia Install path not found.");
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
                regkey = regkey.OpenSubKey(GetRegistryPath() + "Patches", false);
                path = regkey.GetValue("default").ToString();
                regkey.Close();
                if (System.IO.Directory.Exists(path))
                {
                    _defaultpatchpath = path;
                    return _defaultpatchpath; // Path found
                }
            }
            catch{ //NullReference Exception = regkey not found.
            }

            // Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
            path = GetInstallPath();
            if (path == string.Empty)
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        "Furcadia");

            path = Path.Combine(path,"/patches/default");

            if (System.IO.Directory.Exists(path))
            {
                _defaultpatchpath = path;
                return _defaultpatchpath; // Path found
            }

            // All options were exhausted - assume Furcadia not installed.
            throw new DirectoryNotFoundException("Furcadia Install path not found.");
        }

        private static string _localsettingspath;
        /// <summary>
        /// Get the path to the Local Settings directory for Furcadia.
        /// </summary>
        /// <returns>Furcadia local settings directory.</returns>
        public static string GetLocalSettingsPath()
        {
            if (!string.IsNullOrEmpty(_localsettingspath)) return _localsettingspath;
            else _localsettingspath = GetLocaldirPath();
            if (String.IsNullOrEmpty(_localsettingspath))
                _localsettingspath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
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
            if (!String.IsNullOrEmpty(_cachepath)) return _cachepath;
            else _cachepath = GetLocaldirPath();
            if (String.IsNullOrEmpty(_cachepath))
                _cachepath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                        "Dragon's Eye Productions/Furcadia");
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
                throw new DirectoryNotFoundException("Path not found in localdir.ini"); // localdir.ini found, but the path in it is missing.
            _localdirpath = path;
            return _localdirpath; // Localdir path found!
        }
    }
}
