/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

using System.Text.RegularExpressions;

namespace Furcadia
{
    /// <summary>
    /// Utility class with helper functions.
    /// </summary>
    public class Util
    {
        #region Public Methods

        /// <summary>
        /// Takes a string and returns Furcadia's short name format
        /// </summary>
        /// <param name="name">
        /// Display name.
        /// </param>
        /// <returns>
        /// furcadia short-name format
        /// </returns>
        public static string FurcadiaShortName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return string.Empty;
            return Regex.Replace(name.ToLower(), "[^a-z0-9\0x0020_.;&|]+", string.Empty, RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.ExplicitCapture);
        }

        #endregion Public Methods
    }
}