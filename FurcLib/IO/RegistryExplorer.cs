using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Furcadia.IO
{
    internal class RegistryExplorerForWine
    {
        internal static string FormatWineHDDir(string path)
        {
            string _s = path.Substring(0, 1);
            string newPath = path.Remove(0, 3);
            //newPath = newPath.Replace("\\",Path.DirectorySeparatorChar.ToString());
            switch (_s.ToLower())
            {
                case "c":
                    return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/.wine/drive_c/" + newPath;
            }
            return path;
        }

        internal static string ReadSubKey(string regPath, string key)
        {
            string path = null;
            ProcessStartInfo startinfo = new ProcessStartInfo("regedit", "/S /E " + "tmp.reg " + "\"" + regPath + "\"");
            Process proc = Process.Start(startinfo);
            proc.Close();

            int _timeout = 0;
            while (File.Exists("tmp.reg") == false && _timeout < 10)
            {
                _timeout++;
                Thread.Sleep(100);
            }

            FileStream fs = TryOpenFile("tmp.reg", FileMode.Open, FileAccess.Read, FileShare.Read, 3, 1000);
            if (fs != null)
            {
                path = parseRegFile(fs, key);
                path = path.Remove(0, path.IndexOf('=') + 1);
                File.Delete("tmp.reg");
                if (path != null)
                {
                    path = FormatWineHDDir(path);
                }
            }
            return path;
        }

        #region UGLY Wine Registry Code

        internal static string parseRegFile(FileStream file, string key)
        {
            StreamReader reader = new StreamReader(file);
            List<string> lines = new List<string>();
            string _l = null;
            while ((_l = reader.ReadLine()) != null)
            {
                lines.Add(_l);
            }
            for (int i = 1; i <= lines.Count - 1; i++)
            {
                if (lines[i].Length > 4 && lines[i].Contains(key))
                {
                    string line = lines[i].Substring(1, lines[i].Length - 1);
                    line = line.Replace("\"", "").Replace(@"\\", "/");
                    return line;
                }
            }
            return null;
        }

        internal static FileStream TryOpenFile(string filePath, FileMode fileMode, FileAccess fileAccess, FileShare fileShare, int maximumAttempts, int attemptWaitMS)
        {
            FileStream fs = null;
            int attempts = 0;
            while (true)
            {
                try
                {
                    fs = File.Open(filePath, fileMode, fileAccess, fileShare);
                    break;
                }
                catch (IOException ioEx)
                {
                    attempts++;
                    if (attempts > maximumAttempts)
                    {
                        fs = null;
                        break;
                    }
                    else
                    {
                        Thread.Sleep(attemptWaitMS);
                    }
                }
            }
            return fs;
        }

        #endregion UGLY Wine Registry Code
    }
}