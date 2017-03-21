using System;
using System.Collections.Generic;

namespace Furcadia.Net
{
    /// <summary>
    /// Generic Proxy handler
    /// <para>
    /// Full functional proxy engine
    /// </para>
    /// <para>
    /// Tracks the Furcadia Connection
    /// </para>
    /// <para>
    /// Dream Status? FurreList DreamOwner Dream Title
    /// </para>
    /// </summary>
    public class ProxySession : NetProxy, IDisposable
    {
        #region Protected Fields

        protected Queue<string> BadgeTag = new Queue<string>(10);
        protected Queue<string> LookQue = new Queue<string>(10);
        protected Queue<string> SpeciesTag = new Queue<string>(10);

        #endregion Protected Fields

        #region Public Constructors

        public ProxySession()
        {
        }

        #endregion Public Constructors
    }
}