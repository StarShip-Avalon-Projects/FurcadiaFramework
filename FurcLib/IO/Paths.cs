/****NOTICE: DO NOT REMOVE
 * Credits go to Artex for helping me fix Path issues and
 * contributing his code.
 ****NOTICE: DO NOT REMOVE.*
*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path
 *  (June 1, 2016) Gerolkae, Added possible missing Registry Paths for X86/x64 Windows and Mono Support. Wine Support also contains these corrections
 */

/*
 * Theory Check all known default paths
 * check localdir.ini
 * then Check Each Registry Hives for active CPU type
 * Then Check each Hive For default 32bit path (Non wow6432node)
 * then Check Wine Varants (C++ Win32 client)
 * then Check Mono Versions for beforementioned (C# Client)
 * then check Default Drive folder Paths
 * If all Fail... Throw FurcadiaNotInstalled Excempt
 * Clients Should check for this error and then ask the user where to manually locate Furc
 */

using Microsoft.Win32;
using System;
using System.IO;

namespace Furcadia.IO
{
    /// <summary>
    /// This class contains all the paths related to the users furcadia installation.
    ///<para>***NOTICE: DO NOT REMOVE***</para>
    ///<para> Credits go to Artex for helping me fix Path issues and contributing his code.</para>
    ///<para>***NOTICE: DO NOT REMOVE.***</para>
    ///<para>Log Header</para>
    ///<para>Format: (date,Version) AuthorName, Changes.</para>
    ///<para> (Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path</para>
    ///<para>  (June 1, 2016) Gerolkae, Added possible missing Registry Paths for x86/x64 Windows and Mono Support. Wine Support also contains these corrections.</para>
    /// </summary>
    public class Paths
    {
        private const string RegPathx32 = @"SOFTWARE\Dragon's Eye Productions\Furcadia\";
        private const string RegPathx64 = @"SOFTWARE\Wow6432Node\Dragon's Eye Productions\Furcadia\";

        #region Constructors

        /// <summary>
        /// Defines the base path for the Furcadia Directory
        /// </summary>
        public Paths()
        {
            _installpath = null;
        }

        /// <summary>
        /// Defines the base path for the Furcadia Directory Throws FurcadiaNotFound exception if
        /// furcadia.exe cannot be found in specified path
        /// </summary>
        /// <param name="path">
        /// </param>
        public Paths(string path)
        {
            if (path == "")
                _installpath = null;
            _installpath = path;
        }

        #endregion Constructors

        private static string _cachepath;
        private static string _FurcadiaCharactersPath = null;

        private static string _FurcadiaDocpath;

        private static string _installpath;

        private static string _localdirpath;

        private static string _localsettingspath;

        private string _defaultpatchpath;

        private string _dynavpath;

        /// <summary>
        /// Determines the registry path by platform. (x32/x64) Thanks to Ioka for this one.
        /// </summary>
        /// <returns>
        /// A path to the Furcadia registry folder or NullReferenceException.
        /// </returns>
        public static string ProgramFilesX86()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }
            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

        /// <summary>
        /// Get the All Users Application Data path for Furcadia.
        /// </summary>
        /// <returns>
        /// All Users Application Data path for Furcadia.
        /// </returns>
        public string GetCachePath()
        {
            if (!string.IsNullOrEmpty(_cachepath)) return _cachepath;
            else _cachepath = GetLocaldirPath();
            if (string.IsNullOrEmpty(_cachepath))
                _cachepath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                                          "Dragon's Eye Productions" + Path.DirectorySeparatorChar + "Furcadia");
            return _cachepath;
        }

        /// <summary>
        /// Find the path to the default patch folder on the current machine.
        /// </summary>
        /// <returns>
        /// Path to the default patch folder or null if not found.
        /// </returns>
        public string GetDefaultPatchPath()
        {
            //If path already found return it.
            if (!string.IsNullOrEmpty(_defaultpatchpath)) return _defaultpatchpath;
            string path;

            // Checking registry for a path first of all.
            if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                // Current Hive with x64 CPU Check
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkey = Hive.OpenSubKey(RegPathx64 + "Patches", false))
                        {
                            if (regkey != null)
                            {
                                path = regkey.GetValue("default").ToString();
                                if (Directory.Exists(path))
                                {
                                    _defaultpatchpath = path;
                                    return _defaultpatchpath; // Path found
                                }
                            }
                        }
                    }
                    catch { }//Ditch the Exceptions
                }

                // Local Machine Hive with x64 CPU Check
                using (RegistryKey Hive = Registry.LocalMachine)
                {
                    try
                    {
                        using (RegistryKey regkey = Hive.OpenSubKey(RegPathx64 + "Patches", false))
                        {
                            if (regkey != null)
                            {
                                path = regkey.GetValue("default").ToString();
                                if (Directory.Exists(path))
                                {
                                    _defaultpatchpath = path;
                                    return _defaultpatchpath; // Path found
                                }
                            }
                        }
                    }
                    catch { }//Ditch the Exceptions
                }
                using (RegistryKey Hive = Registry.LocalMachine)
                {
                    try
                    {
                        using (RegistryKey regkey = Hive.OpenSubKey(RegPathx32 + "Patches", false))
                        {
                            if (regkey != null)
                            {
                                path = regkey.GetValue("default").ToString();
                                if (Directory.Exists(path))
                                {
                                    _defaultpatchpath = path;
                                    return _defaultpatchpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkey = Hive.OpenSubKey(RegPathx32 + "Patches", false))
                        {
                            if (regkey != null)
                            {
                                path = regkey.GetValue("default").ToString();
                                if (Directory.Exists(path))
                                {
                                    _defaultpatchpath = path;
                                    return _defaultpatchpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }

                // Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
                path = GetInstallPath();
                if (string.IsNullOrEmpty(path))
                    path = Path.Combine(ProgramFilesX86(), "Furcadia");

                path = Path.Combine(path, "/patches/default");
            }
            else
            {
                // Search Wine paths if Wine is used
                //TODO: Check c# Client
                path = RegistryExplorerForWine.ReadSubKey("HKEY_LOCAL_MACHINE\\" + GetRegistryPath() + "Patches", "default");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + GetRegistryPath() + "Patches", "default");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_LOCAL_MACHINE\\" + RegPathx32 + "Patches", "Default");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + RegPathx32 + "Patches", "default");
            }
            if (Directory.Exists(path))
            {
                _defaultpatchpath = path;
                return _defaultpatchpath; // Path found
            }

            #region "Mono Runtime"

            //Prep for c# Client Mono install
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
            {
                // Current Hive with x64 CPU Check
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkey = Hive.OpenSubKey(RegPathx64 + "Patches", false))
                        {
                            if (regkey != null)
                            {
                                path = regkey.GetValue("default").ToString();
                                if (Directory.Exists(path))
                                {
                                    _defaultpatchpath = path;
                                    return _defaultpatchpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }
            }

            // Local Machine Hive with x64 CPU Check
            using (RegistryKey Hive = Registry.LocalMachine)
            {
                try
                {
                    using (RegistryKey regkey = Hive.OpenSubKey(RegPathx64 + "Patches", false))
                    {
                        if (regkey != null)
                        {
                            path = regkey.GetValue("default").ToString();
                            if (Directory.Exists(path))
                            {
                                _defaultpatchpath = path;
                                return _defaultpatchpath; // Path found
                            }
                        }
                    }
                }
                catch { } //Ditch the Exceptions
            }
            using (RegistryKey Hive = Registry.LocalMachine)
            {
                try
                {
                    using (RegistryKey regkey = Hive.OpenSubKey(RegPathx32 + "Patches", false))
                    {
                        if (regkey != null)
                        {
                            path = regkey.GetValue("default").ToString();
                            if (Directory.Exists(path))
                            {
                                _defaultpatchpath = path;
                                return _defaultpatchpath; // Path found
                            }
                        }
                    }
                }
                catch { } //Ditch the Exceptions
            }
            using (RegistryKey Hive = Registry.CurrentUser)
            {
                try
                {
                    using (RegistryKey regkey = Hive.OpenSubKey(RegPathx32 + "Patches", false))
                    {
                        if (regkey != null)
                        {
                            path = regkey.GetValue("default").ToString();
                            if (Directory.Exists(path))
                            {
                                _defaultpatchpath = path;
                                return _defaultpatchpath; // Path found
                            }
                        }
                    }
                    if (Directory.Exists(path))
                    {
                        _defaultpatchpath = path;
                        return _defaultpatchpath; // Path found
                    }
                }
                catch { } //Ditch the Exceptions
            }

            #endregion "Mono Runtime"

            // All options were exhausted - assume Furcadia not installed.
            throw new DirectoryNotFoundException("Furcadia Install path not found.");
        }

        /// <summary>
        /// Get the All Dynamic Avatar path for Furcadia.
        /// </summary>
        /// <returns>
        /// All Dynamic Avatar path for Furcadia.
        /// </returns>
        public string GetDynAvatarPath()
        {
            if (!string.IsNullOrEmpty(_dynavpath)) return _dynavpath;
            else _dynavpath = GetLocaldirPath();
            if (string.IsNullOrEmpty(_dynavpath))
                _dynavpath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                                          "Dragon's Eye Productions" + Path.DirectorySeparatorChar + "Furcadia" + Path.DirectorySeparatorChar + "Dynamic Avatars");
            return _dynavpath;
        }

        /// <summary>
        /// Gets the location of the Furcadia Character Files
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> containing the location of Furcadia Characters folder in
        /// "My Documents".
        /// </returns>
        public string GetFurcadiaCharactersPath()
        {
            if (!string.IsNullOrEmpty(_FurcadiaCharactersPath)) return _FurcadiaCharactersPath;
            string path = Path.Combine(GetFurcadiaDocPath(), "Furcadia Characters");
            if (!Directory.Exists(path))
                path = GetFurcadiaDocPath();
            if (Directory.Exists(path))
            {
                _FurcadiaCharactersPath = path;
                return _FurcadiaCharactersPath;
            }
            throw new FurcadiaNotFoundException("Furcadia Characters path not found.\n" + path);
        }

        /// <summary>
        /// Gets the location of the Furcadia folder located in "My Documents"
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> containing the location of Furcadia folder in "My Documents".
        /// </returns>
        public string GetFurcadiaDocPath()
        {
            if (!string.IsNullOrEmpty(_FurcadiaDocpath)) return _FurcadiaDocpath;
            string path = GetLocaldirPath();
            if (string.IsNullOrEmpty(path))
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                    "Furcadia");

            if (Directory.Exists(path))
            {
                _FurcadiaDocpath = path;
                return _FurcadiaDocpath;
            }
            throw new FurcadiaNotFoundException("Furcadia documents path not found.\n" + path);
        }

        /// <summary>
        /// Find the path to Furcadia data files currently installed on this system.
        /// </summary>
        /// <returns>
        /// Path to the Furcadia program folder or null if not found/not installed.
        /// </returns>
        public string GetInstallPath()
        {
            //If path already found return it.
            if (!string.IsNullOrEmpty(_installpath)) return _installpath;
            string path = null;

            // Checking registry for a path (WINDOWS ONLY)
            if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                // Current User Hive with x64 CPU Check
                if (Environment.Is64BitOperatingSystem)
                {
                    using (RegistryKey Hive = Registry.CurrentUser)
                    {
                        try
                        {
                            using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx64 + "Programs", false))
                                if (regkeyPath != null)
                                {
                                    path = regkeyPath.GetValue("path").ToString();
                                    if (Directory.Exists(path))
                                    {
                                        _installpath = path;
                                        return _installpath; // Path found
                                    }
                                }
                        }
                        catch { } //Ditch the Exceptions
                    }

                    // Local Machine Hive with x64 CPU Check
                    using (RegistryKey Hive = Registry.LocalMachine)
                    {
                        try
                        {
                            using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx64 + "Programs", false))
                                if (regkeyPath != null)
                                {
                                    path = regkeyPath.GetValue("path").ToString();
                                    if (Directory.Exists(path))
                                    {
                                        _installpath = path;
                                        return _installpath; // Path found
                                    }
                                }
                        }
                        catch { } //Ditch the Exceptions
                    }
                }

                // Current User Hive with x86 CPU Check Failed
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx32 + "Programs", false))
                        {
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }

                using (RegistryKey Hive = Registry.LocalMachine)
                {
                    try
                    {
                        using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx32 + "Programs", false))
                        {
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }

                // Making a guess from the FurcadiaDefaultPath property.
                path = Path.Combine(ProgramFilesX86(), "Furcadia");
                if (Directory.Exists(path))
                {
                    _installpath = path;
                    return _installpath; // Path found
                }
            }
            // Scanning registry for a path (NON-WINDOWS ONLY)
            else
            {
                path = RegistryExplorerForWine.ReadSubKey("\\HKEY_LOCAL_MACHINE\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_LOCAL_MACHINE\\" + RegPathx32.Replace("\\", "/") + "Programs", "Path");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + RegPathx32.Replace("\\", "/") + "Programs", "Path");
                if (Directory.Exists(path))
                {
                    _installpath = path;
                    return _installpath; // Path found
                }
            }

            #region "Mono Runtime"

            //Prep for c# Client Mono install
            // Wine don't have the registry lets Try Mono
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
            {
                // Current User Hive with x64 CPU Check
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx64 + "Programs", false))
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                    }
                    catch { } //Ditch the Exceptions
                }

                // Local Machine Hive with x64 CPU Check
                using (RegistryKey Hive = Registry.LocalMachine)
                {
                    try
                    {
                        using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx64 + "Programs", false))
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                    }
                    catch { } //Ditch the Exceptions
                }

                // Current User Hive with x64 CPU Check Failed
                using (RegistryKey Hive = Registry.CurrentUser)
                {
                    try
                    {
                        using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx32 + "Programs", false))
                        {
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                        }
                    }
                    catch { } //Ditch the Exceptions
                }

                using (RegistryKey Hive = Registry.LocalMachine)
                {
                    using (RegistryKey regkeyPath = Hive.OpenSubKey(RegPathx32 + "Programs", false))
                    {
                        try
                        {
                            if (regkeyPath != null)
                            {
                                path = regkeyPath.GetValue("path").ToString();
                                if (Directory.Exists(path))
                                {
                                    _installpath = path;
                                    return _installpath; // Path found
                                }
                            }
                        }
                        catch { } //Ditch the Exceptions
                    }
                }
                // All options were exhausted - assume Furcadia not installed.
                if (Directory.Exists(path))
                {
                    _installpath = path;
                    return _installpath; // Path found
                }
            }
            throw new FurcadiaNotFoundException("Furcadia Install path not found." + "\n" + path);

            #endregion "Mono Runtime"
        }

        /// <summary>
        /// Find the current localdir path where data files would be stored on the current machine.
        /// </summary>
        /// <returns>
        /// Path to the data folder from localdir.ini or null if not found.
        /// </returns>
        public string GetLocaldirPath()
        {
            if (!string.IsNullOrEmpty(_localdirpath)) return _localdirpath;
            string path;
            string install_path = GetInstallPath();

            // If we can't find Furc, we won't find localdir.ini
            if (install_path == null)
                return null; // Furcadia install path not found.

            // Try to locate localdir.ini
            string ini_path = string.Format("{0}/localdir.ini", install_path);
            if (!File.Exists(ini_path))
                return null; // localdir.ini not found - regular path structure applies.

            // Read localdir.ini for remote path and verify it.
            using (StreamReader sr = new StreamReader(ini_path))
            {
                path = sr.ReadLine();
                if (!string.IsNullOrEmpty(path))
                    path.Trim();
                sr.Close();
            }
            if (string.IsNullOrEmpty(path))
                path = install_path;
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("Path not found in localdir.ini"); // localdir.ini found, but the path in it is missing.
            _localdirpath = path;
            return _localdirpath; // Localdir path found!
        }

        /// <summary>
        /// Get the path to the Local Settings directory for Furcadia.
        /// </summary>
        /// <returns>
        /// Furcadia local settings directory.
        /// </returns>
        public string GetLocalSettingsPath()
        {
            if (!string.IsNullOrEmpty(_localsettingspath)) return _localsettingspath;
            else
            {
                string p = GetLocaldirPath();
                if (!string.IsNullOrEmpty(p))
                    _localsettingspath = Path.Combine(p, "settings");
            }
            if (string.IsNullOrEmpty(GetLocaldirPath()))
                _localsettingspath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Dragon's Eye Productions" + Path.DirectorySeparatorChar + "Furcadia");
            return _localsettingspath;
        }

        /// <summary>
        /// Determines the registry path by platform. (x32/x64) Thanks to Ioka for this one.
        /// </summary>
        /// <returns>
        /// A path to the Furcadia registry folder or NullReferenceException.
        /// </returns>
        public string GetRegistryPath()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return RegPathx64;
            }
            return RegPathx32;
        }
    }
}