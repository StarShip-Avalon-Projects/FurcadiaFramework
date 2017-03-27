using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Furcadia.Text
{
    public class IniParser
    {
        #region Private Fields

        private string iniFilePath;
        private Hashtable keyPairs = new Hashtable();

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Opens the INI file at the given path and enumerates the values in the IniParser.
        /// </summary>
        /// <param name="iniPath">
        /// Full path to INI file.
        /// </param>
        public IniParser(string iniPath)
        {
            StreamReader iniFile = null;
            string strLine = null;
            string currentRoot = null;
            string[] keyPair = null;

            iniFilePath = iniPath;

            if (File.Exists(iniPath))
            {
                try
                {
                    using (iniFile = new StreamReader(iniPath))
                    {
                        strLine = iniFile.ReadLine();

                        while (iniFile.Peek() >= 0)
                        {
                            strLine = iniFile.ReadLine().Trim().ToUpper();

                            if (strLine != "")
                            {
                                if (strLine.StartsWith("[") && strLine.EndsWith("]"))
                                {
                                    currentRoot = strLine.Substring(1, strLine.Length - 2);
                                }
                                else
                                {
                                    if (strLine.StartsWith("#"))
                                    {
                                        // assuming comments start with the apostrophe do nothing
                                    }
                                    else
                                    {
                                        keyPair = strLine.Split(new char[] { '=' }, 2);

                                        SectionPair sectionPair;
                                        string value = null;

                                        if (currentRoot == null)
                                            currentRoot = "ROOT";

                                        sectionPair.Section = currentRoot;
                                        sectionPair.Key = keyPair[0];

                                        if (keyPair.Length > 1)
                                            value = keyPair[1];

                                        keyPairs.Add(sectionPair, value);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                throw new FileNotFoundException("Unable to locate " + iniPath);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Adds or replaces a setting to the table to be saved.
        /// </summary>
        /// <param name="sectionName">
        /// Section to add under.
        /// </param>
        /// <param name="settingName">
        /// Key name to add.
        /// </param>
        /// <param name="settingValue">
        /// Value of key.
        /// </param>
        public void AddSetting(string sectionName, string settingName, string settingValue)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName.ToUpper();
            sectionPair.Key = settingName.ToUpper();

            if (keyPairs.ContainsKey(sectionPair))
                keyPairs.Remove(sectionPair);

            keyPairs.Add(sectionPair, settingValue);
        }

        /// <summary>
        /// Adds or replaces a setting to the table to be saved with a null value.
        /// </summary>
        /// <param name="sectionName">
        /// Section to add under.
        /// </param>
        /// <param name="settingName">
        /// Key name to add.
        /// </param>
        public void AddSetting(string sectionName, string settingName)
        {
            AddSetting(sectionName, settingName, null);
        }

        /// <summary>
        /// Remove a setting.
        /// </summary>
        /// <param name="sectionName">
        /// Section to add under.
        /// </param>
        /// <param name="settingName">
        /// Key name to add.
        /// </param>
        public void DeleteSetting(string sectionName, string settingName)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName.ToUpper();
            sectionPair.Key = settingName.ToUpper();

            if (keyPairs.ContainsKey(sectionPair))
                keyPairs.Remove(sectionPair);
        }

        /// <summary>
        /// Enumerates all lines for given section.
        /// </summary>
        /// <param name="sectionName">
        /// Section to enum.
        /// </param>
        public string[] EnumSection(string sectionName)
        {
            List<string> tmpArray = new List<string>();

            foreach (SectionPair pair in keyPairs.Keys)
            {
                if (pair.Section == sectionName.ToUpper())
                    tmpArray.Add(pair.Key);
            }

            return (string[])tmpArray.ToArray();
        }

        /// <summary>
        /// Returns the value for the given section, key pair.
        /// </summary>
        /// <param name="sectionName">
        /// Section name.
        /// </param>
        /// <param name="settingName">
        /// Key name.
        /// </param>
        public string GetSetting(string sectionName, string settingName)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName.ToUpper();
            sectionPair.Key = settingName.ToUpper();

            return (string)keyPairs[sectionPair];
        }

        /// <summary>
        /// Save settings to new file.
        /// </summary>
        /// <param name="newFilePath">
        /// New file path.
        /// </param>
        public void SaveSettings(string newFilePath)
        {
            List<string> sections = new List<string>();
            string tmpValue = "";
            string strToSave = "";

            foreach (SectionPair sectionPair in keyPairs.Keys)
            {
                if (!sections.Contains(sectionPair.Section))
                    sections.Add(sectionPair.Section);
            }

            foreach (string section in sections)
            {
                strToSave += ("[" + section + "]\r\n");

                foreach (SectionPair sectionPair in keyPairs.Keys)
                {
                    if (sectionPair.Section == section)
                    {
                        tmpValue = (string)keyPairs[sectionPair];

                        if (tmpValue != null)
                            tmpValue = "=" + tmpValue;

                        strToSave += (sectionPair.Key + tmpValue + "\r\n");
                    }
                }

                strToSave += "\r\n";
            }

            try
            {
                TextWriter tw = new StreamWriter(newFilePath);
                tw.Write(strToSave);
                tw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Save settings back to ini file.
        /// </summary>
        public void SaveSettings()
        {
            SaveSettings(iniFilePath);
        }

        #endregion Public Methods

        #region Private Structs

        private struct SectionPair
        {
            #region Public Fields

            public string Key;
            public string Section;

            #endregion Public Fields
        }

        #endregion Private Structs
    }
}