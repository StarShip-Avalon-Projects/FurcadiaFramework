namespace Furcadia.Net.Account
{
    /// <summary>
    /// Furcadia Modern Login feature
    /// <para>
    /// E-Mail and password based accounts.
    /// </para>
    /// </summary>
    public class CharacterInfo : AccountInfo
    {
        #region Public Constructors

        /// <summary>
        /// </summary>
        public CharacterInfo() : base()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Character Name to use with this login
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Costume to use with Selected Character
        /// </summary>
        public string Costume { get; set; }

        #endregion Public Properties
    }
}