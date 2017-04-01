using System;

namespace Furcadia
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class LegacyAttribute : Attribute
    {
        #region Private Fields

        private const string FurcVersion = "29";

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
            this.furcadiaversion = FurcVersion;
            this.Reason = "No reason given";
        }

        public LegacyAttribute(string reason)
        {
            this.furcadiaversion = FurcVersion;
            this.Reason = reason;
        }

        public LegacyAttribute(string reason, string Version)
        {
            this.Reason = reason;
            this.furcadiaversion = Version;
        }

        public override string ToString()
        {
            string value = string.Format("Furcadia Version : {0}", furcadiaversion);
            if (!string.IsNullOrEmpty(furcadiaversion))
            {
                value += string.Format("\n\rReason: {0}", Reason);
            }
            return value;
        }

        #endregion Public Constructors
    }
}