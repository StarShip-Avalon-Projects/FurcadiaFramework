namespace Furcadia.Text
{
    /// <summary>
    /// Furcadia (v31) Color string format.
    /// </summary>
    public class ColorString
    {
        #region Private Fields

        private string colorstring;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Default Construtor
        /// </summary>
        public ColorString()
        {
        }

        /// <summary>
        /// Constructor with ColorStrinhg code
        /// </summary>
        /// <param name="Colors">
        /// Color String
        /// </param>
        public ColorString(string Colors)
        {
            if (Colors.StartsWith("w"))
                colorstring = Colors;
            else if (Colors.StartsWith("t"))
            {
                colorstring = ConvertString(Colors);
            }
            else
            {
                colorstring = "default";
            }

            _Special = Base220.ConvertFromBase220(colorstring.Substring(13, 1));

            _DSSpecies = SpeciesTable.SpecNum(colorstring, _Special);
            _Wings = SpeciesTable.WingsNum(colorstring, _Special);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// </summary>
        /// <returns>
        /// Correctly formatted Furcadia color-string
        /// </returns>
        public override string ToString()
        {
            return colorstring;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Convert Outdated Color codes to Furcadia v31c
        /// </summary>
        /// <param name="Colors">
        /// Outdated color code
        /// </param>
        /// <returns>
        /// </returns>
        private string ConvertString(string Colors)
        {
            System.Console.WriteLine("Converted color code to Furcadia v31c");
            return string.Format("w");
        }

        #endregion Private Methods

        #region Public Properties

        /// <summary>
        /// Avatar Gender
        /// </summary>
        public int Gender
        {
            get
            {
                return Base220.ConvertFromBase220(colorstring[11].ToString());
            }
        }

        /// <summary>
        /// Avatar Species
        /// </summary>
        public int Species
        {
            get
            {
                return Base220.ConvertFromBase220(colorstring[12].ToString());
            }
        }

        #endregion Public Properties
    }
}