namespace Furcadia
{
    public struct Character
    {
        public string Name;
        public string ColorString;
        public string Description;
        public int Logins;
        public int LastLogin;

        public static Character Load(string iniFile)
        {
            Character newToon = new Character();
            try
            {
                System.Collections.Hashtable iniData = Furcadia.Settings.Load(iniFile);
                newToon.Name = (string)iniData["Name"];
                newToon.Description = (string)iniData["Desc"];
                newToon.ColorString = (string)iniData["Color"];
                int.TryParse((string)iniData["Logins"], out newToon.Logins);
                int.TryParse((string)iniData["LastLogin"], out newToon.LastLogin);
            }
            catch
            {
            }
            return newToon;
        }
    }
}