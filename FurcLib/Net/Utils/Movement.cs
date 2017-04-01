namespace Furcadia.Net.Utils
{
    /// <summary>
    /// Furcadia reconmended Material to support thier Protocol Standards
    /// </summary>
    public class Movement
    {
        #region Public Enums

        /// <summary>
        /// Character Flags
        /// </summary>
        public enum Flags
        {
            /// <summary>
            /// Character has no Flags set
            /// </summary>
            CHAR_FLAG_NONE,

            /// <summary>
            /// Character has a Web Profile page.
            /// <para>
            /// As of Furcadia V31 This is not yet used
            /// </para>
            /// </summary>
            CHAR_FLAG_HAS_PROFILE = 1,

            /// <summary>
            /// </summary>
            CHAR_FLAG_SET_VISIBLE = 2,

            /// <summary>
            /// Shown for new arrivals to the dream
            /// </summary>
            CHAR_FLAG_NEW_AVATAR = 4,
        }

        #endregion Public Enums
    }
}