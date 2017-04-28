using Furcadia.IO;
using Furcadia.Text;
using System.Collections.Generic;
using System.IO;

namespace BugProxy.IO
{
    public class CharacterIniList
    {
        #region Private Fields

        private static Paths FurcPath;

        private List<Character> characterlist = new List<Character>();

        #endregion Private Fields

        #region Public Constructors

        public CharacterIniList()
        {
            string[] CharacterFiles = Directory.GetFiles(FurcPath.GetFurcadiaCharactersPath(), "*.ini");
            foreach (var character in CharacterFiles)
            {
                Character Char = new Character();
                characterlist.Add(Char.Load(character));
            }
        }

        #endregion Public Constructors

        //
    }
}