/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Furcadia.Net
{
    public interface INetMessage
    {

        byte[] GetBuffer();

        string GetString();

        void Write(string data);

        void Write(byte[] data);
    }
}
