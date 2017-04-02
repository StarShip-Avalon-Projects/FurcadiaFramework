/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 *
*/

using System.Text;

namespace Furcadia.Net
{
    /// <summary>
    /// Default.
    /// </summary>
    public class NetMessage : INetMessage
    {
        #region Private Fields

        private StringBuilder _data;

        #endregion Private Fields

        #region Public Constructors

        public NetMessage()
        {
            _data = new StringBuilder();
        }

        #endregion Public Constructors

        #region Public Methods

        public string GetString()
        {
            return _data.ToString();
        }

        public void Write(string data)
        {
            _data.Append(data);
        }

        public void Write(byte[] data)
        {
            _data.Append(Encoding.GetEncoding(BaseProxy.EncoderPage).GetString(data));
        }

        #endregion Public Methods
    }
}