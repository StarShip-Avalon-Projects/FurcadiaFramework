using System;

namespace Furcadia.Text
{
    /// <summary>
    /// Furcadia Character.ini
    /// </summary>
    [Obsolete("Furcadia has switched to Account Login", false)]
    [Legacy("Character.ini files are being replaced with the Furcadia Account System", "v30")]
    public class Character
    {
        #region Public Fields

        private int lastlogin;

        private int logins;

        /// <summary>
        /// Furcadia Color String
        /// </summary>
        public string ColorString
        { get; set; }

        /// <summary>
        /// Description text
        /// </summary>
        public string Description
        { get; set; }

        /// <summary>
        /// Last time the character logged in (UNIX Time stamp?)
        /// </summary>
        public int LastLogin
        { get { return lastlogin; } set { lastlogin = value; } }

        /// <summary>
        /// </summary>
        public int Logins
        { get { return logins; } set { logins = value; } }

        /// <summary>
        /// </summary>
        public string Name
        { get; set; }

        /// <summary>
        /// Character Password
        /// </summary>
        public string Password
        { get; set; }

        #endregion Public Fields

        #region Public Methods

        /// <summary>
        /// Loads a Character.Ini file
        /// </summary>
        /// <param name="iniFile">
        /// </param>
        /// <returns>
        /// Character Class
        /// </returns>
        public Character Load(string iniFile)
        {
            Character newToon = new Character();
            try
            {
                System.Collections.Hashtable iniData = Settings.Load(iniFile);
                newToon.Name = (string)iniData["Name"];
                newToon.Description = (string)iniData["Desc"];
                newToon.ColorString = (string)iniData["Color"];
                newToon.Password = (string)iniData["Password"];
                int.TryParse((string)iniData["Logins"], out newToon.logins);
                int.TryParse((string)iniData["LastLogin"], out newToon.lastlogin);
            }
            catch
            {
            }
            return newToon;
        }

        #endregion Public Methods
    }
}