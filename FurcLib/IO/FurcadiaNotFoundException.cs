/*
 * Created by SharpDevelop.
 * User: Gerolkae
 * Date: 5/7/2016
 * Time: 10:03 PM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Runtime.Serialization;

namespace Furcadia.IO
{
    /// <summary>
    /// Desctiption of FurcadiaNotFoundException.
    /// </summary>
    public class FurcadiaNotFoundException : Exception, ISerializable
    {
        public FurcadiaNotFoundException()
        {
        }

        public FurcadiaNotFoundException(string message) : base(message)
        {
        }

        public FurcadiaNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        // This constructor is needed for serialization.
        protected FurcadiaNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}