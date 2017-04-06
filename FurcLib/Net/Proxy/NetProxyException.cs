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

namespace Furcadia.Net.Proxy
{
    public delegate void ServerDisConnectedHandler();

    /// <summary>
    /// Desctiption of NetProxyException.
    /// </summary>
    [Serializable]
    public class NetProxyException : Exception, ISerializable
    {
        #region Public Constructors

        public NetProxyException()
        {
        }

        public NetProxyException(string message) : base(message)
        {
        }

        public NetProxyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion Public Constructors

        #region Protected Constructors

        // This constructor is needed for serialization.
        protected NetProxyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion Protected Constructors
    }
}