namespace Furcadia.Net.Account
{
    /// <summary>
    /// Furcadia Modern Login feature
    /// <para>
    /// E-Mail and password based accounts.
    /// </para>
    /// </summary>
    public class AccountInfo
    {
        #region Public Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public AccountInfo()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Furcadia API Key
        /// <para>
        /// See remarks for DEP/CS NDA
        /// </para>
        /// </summary>
        /// <remarks>
        /// This intellectual property is owned and controlled by DEP/CS as per their Third Party
        /// Nondisclosure Agreement (NDA). This cannot be redistributed with out their consent. Every
        /// Measure to protect this key is required, this include Obfuscation/Encryption. Clear Text
        /// form is Prohibited.
        /// </remarks>
        public string ApiKey { get; set; }

        /// <summary>
        /// Account E-Mail address
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Account Password
        /// </summary>
        public string Password { get; set; }

        #endregion Public Properties
    }
}