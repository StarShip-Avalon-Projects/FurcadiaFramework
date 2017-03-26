using System;

namespace BugGe_OH
{
    internal class Program
    {
        #region Private Fields

        private static FurcadiaSession FurcSession;

        #endregion Private Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            FurcSession = new FurcadiaSession();

            Console.ReadLine();
        }

        #endregion Private Methods
    }
}