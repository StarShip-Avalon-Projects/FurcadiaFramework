﻿/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

namespace Furcadia.Net
{
    public interface INetMessage
    {
        #region Public Methods

        string GetString();

        void Write(string data);

        void Write(byte[] data);

        #endregion Public Methods
    }
}