/****NOTICE: DO NOT REMOVE
 * Credits go to Artex for helping me fix Path issues and
 * contributing his code.
 ****NOTICE: DO NOT REMOVE.*/

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

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
            if (OSBitness.Is64BitOperatingSystem())
            {
                return @"SOFTWARE\Wow6432Node\Dragon's Eye Productions\Furcadia\";
            }
            else
            {
                return @"SOFTWARE\Dragon's Eye Productions\Furcadia\";
            }
        }

        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
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
            string path = null;

            // Checking registry for a path (WINDOWS ONLY)
            if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                RegistryKey regkey = Registry.LocalMachine;
                try
                {
                    regkey = regkey.OpenSubKey(GetRegistryPath() + "Programs", false);
                    path = regkey.GetValue("path").ToString();
                    regkey.Close();
                    if (System.IO.Directory.Exists(path))
                    {
                        _installpath = path;
                        return _installpath; // Path found
                    }
                }
                catch
                {
                }

                // Making a guess from the FurcadiaDefaultPath property.
                path = Path.Combine(ProgramFilesx86(),
                                    "Furcadia");
            }
            // Scanning registry for a path (NON-WINDOWS ONLY)
            else
            {
                path = RegistryExplorerForWine.ReadSubKey("\\HKEY_LOCAL_MACHINE\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
                if (path == null)
                    path = RegistryExplorerForWine.ReadSubKey("\\HKEY_CURRENT_USER\\" + GetRegistryPath().Replace("\\", "/") + "Programs", "Path");
            }
            if (System.IO.Directory.Exists(path))
            {
                _installpath = path;
                return _installpath; // Path found
            }
            // All options were exhausted - assume Furcadia not installed.
            throw new DirectoryNotFoundException("Furcadia Install path not found." + "\n" + path);
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
            if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
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
                catch
                { //NullReference Exception = regkey not found.
                }

                // Making a guess from the FurcadiaPath or FurcadiaDefaultPath property.
                path = GetInstallPath();
                if (path == string.Empty)
                    path = Path.Combine(ProgramFilesx86(), "Furcadia");

                path = Path.Combine(path, "/patches/default");
            }
            else
            {
                path = RegistryExplorerForWine.ReadSubKey("HKEY_LOCAL_MACHINE\\" + GetRegistryPath() + "Patches", "default");
            }
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
                _localsettingspath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
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


        #region MSPL Code
        // Source: http://1code.codeplex.com/SourceControl/changeset/view/39074#842775
        /***************************************************************************\
        * Portions of this source are subject to the Microsoft Public License.
        * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
        * All other rights reserved.
        * 
        * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
        * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
        * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
        \***************************************************************************/

        private static class OSBitness
        {
            #region Is64BitOperatingSystem (IsWow64Process)

            /// <summary>
            /// The function determines whether the current operating system is a 
            /// 64-bit operating system.
            /// </summary>
            /// <returns>
            /// The function returns true if the operating system is 64-bit; 
            /// otherwise, it returns false.
            /// </returns>
            public static bool Is64BitOperatingSystem()
            {
                if (IntPtr.Size == 8)  // 64-bit programs run only on Win64
                {
                    return true;
                }
                else  // 32-bit programs run on both 32-bit and 64-bit Windows
                {
                    // Detect whether the current process is a 32-bit process 
                    // running on a 64-bit system.
                    bool flag;
                    return ((DoesWin32MethodExist("kernel32.dll", "IsWow64Process") &&
                        IsWow64Process(GetCurrentProcess(), out flag)) && flag);
                }
            }

            /// <summary>
            /// The function determins whether a method exists in the export 
            /// table of a certain module.
            /// </summary>
            /// <param name="moduleName">The name of the module</param>
            /// <param name="methodName">The name of the method</param>
            /// <returns>
            /// The function returns true if the method specified by methodName 
            /// exists in the export table of the module specified by moduleName.
            /// </returns>
            static bool DoesWin32MethodExist(string moduleName, string methodName)
            {
                IntPtr moduleHandle = GetModuleHandle(moduleName);
                if (moduleHandle == IntPtr.Zero)
                {
                    return false;
                }
                return (GetProcAddress(moduleHandle, methodName) != IntPtr.Zero);
            }

            [DllImport("kernel32.dll")]
            static extern IntPtr GetCurrentProcess();

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            static extern IntPtr GetModuleHandle(string moduleName);

            [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
            static extern IntPtr GetProcAddress(IntPtr hModule,
                [MarshalAs(UnmanagedType.LPStr)]string procName);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

            #endregion
        }
        #endregion

    }

}
