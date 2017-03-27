using System;

namespace Furcadia
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class LegacyAttribute : Attribute
    {
        #region Private Fields

        /// <summary>
        /// Furcadia Release version.
        /// </summary>
        private string furcadiaversion;

        /// <summary>
        /// Reason
        /// </summary>
        private string Reason;

        #endregion Private Fields

        #region Public Constructors

        public LegacyAttribute()
        {
        }

        public LegacyAttribute(string reason)
        {
            this.Reason = reason;
        }

        public LegacyAttribute(string reason, string Version)
        {
            this.Reason = reason;
            this.furcadiaversion = Version;
        }

        #endregion Public Constructors
    }
}