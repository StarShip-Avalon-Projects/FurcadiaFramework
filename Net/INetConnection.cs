/*Log Header
 *Format: (date,Version) AuthorName, Changes.
 * (Oct 27,2009,0.1) Squizzle, Initial Developer.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furcadia.Net
{
    public interface INetConnection
    {
        void Connect();
        void Kill();
    }
}
