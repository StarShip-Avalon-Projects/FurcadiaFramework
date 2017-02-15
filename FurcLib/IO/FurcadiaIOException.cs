/*
 * Created by SharpDevelop.
 * User: Gerolkae
 * Date: 5/7/2016
 * Time: 9:16 PM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Runtime.Serialization;

namespace Furcadia.IO
{
    /// <summary>
    /// Desctiption of FurcadiaIOException.
    /// </summary>
    public class FurcadiaIOException : Exception, ISerializable
    {
        public FurcadiaIOException()
        {
        }

        public FurcadiaIOException(string message) : base(message)
        {
        }

        public FurcadiaIOException(string message, Exception innerException) : base(message, innerException)
        {
        }

        // This constructor is needed for serialization.
        protected FurcadiaIOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}