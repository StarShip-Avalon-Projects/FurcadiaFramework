/*
 * Created by SharpDevelop.
 * User: Gerolkae
 * Date: 5/9/2016
 * Time: 9:59 PM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Runtime.Serialization;

namespace Furcadia.Net
{
    /// <summary>
    /// Desctiption of NetProxyException.
    /// </summary>
    [Serializable]
    public class NetProxyException : Exception, ISerializable
    {
        public NetProxyException()
        {
        }

        public NetProxyException(string message) : base(message)
        {
        }

        public NetProxyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        // This constructor is needed for serialization.
        protected NetProxyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public delegate void ServerDisConnectedHandler();
}