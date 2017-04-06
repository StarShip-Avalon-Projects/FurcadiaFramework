/* Author: Artex (aka, 1337)
 * Base95 Format.
 * Uses: I have no idea.  Enjoy!
 * P.S: jk above...
*/

using Furcadia.Net.Utils;
using System;
using System.Text;

namespace Furcadia.Text
{
    /// <summary>
    /// </summary>
    public class Base220 : IComparable<int>, IEquatable<int>
    {
        #region Private Fields

        private const byte BASE = 220;
        private const byte CHAR_OFFSET = (byte)'#';
        private int Value;

        #endregion Private Fields

        /*** Constructor ***/

        #region Public Constructors

        /// <summary>
        /// </summary>
        public Base220() : this(0)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="n">
        /// </param>
        public Base220(int n)
        {
            Value = n;
        }

        /// <summary>
        /// </summary>
        /// <param name="s">
        /// </param>
        public Base220(string s)
        {
            FromString(s);
        }

        #endregion Public Constructors

        #region Conversion Operators

        /// <summary>
        /// </summary>
        /// <param name="b220n">
        /// </param>
        public static explicit operator short(Base220 b220n)
        {
            return (short)b220n.Value;
        }

        /// <summary>
        /// </summary>
        /// <param name="n">
        /// </param>
        public static implicit operator Base220(int n)
        {
            return new Base220(n);
        }

        /// <summary>
        /// </summary>
        /// <param name="n">
        /// </param>
        public static implicit operator Base220(short n)
        {
            return new Base220(n);
        }

        /// <summary>
        /// </summary>
        /// <param name="s">
        /// </param>
        public static implicit operator Base220(string s)
        {
            return new Base220(s);
        }

        /// <summary>
        /// </summary>
        /// <param name="b220n">
        /// </param>
        public static implicit operator byte[] (Base220 b220n)
        {
            return b220n.ToByteArray();
        }

        /// <summary>
        /// </summary>
        /// <param name="b220n">
        /// </param>
        public static implicit operator int(Base220 b220n)
        {
            return b220n.Value;
        }

        /// <summary>
        /// </summary>
        /// <param name="b220n">
        /// </param>
        public static implicit operator string(Base220 b220n)
        {
            return b220n.ToString();
        }

        #endregion Conversion Operators

        #region Other Operators

        public static Base220 operator -(Base220 n1, Base220 n2)
        {
            return new Base220(n1.Value - n2.Value);
        }

        public static bool operator !=(Base220 n1, Base220 n2)
        {
            return !(n1 == n2);
        }

        public static Base220 operator %(Base220 n1, Base220 n2)
        {
            return new Base220(n1.Value % n2.Value);
        }

        public static Base220 operator *(Base220 n1, Base220 n2)
        {
            return new Base220(n1.Value * n2.Value);
        }

        public static Base220 operator /(Base220 n1, Base220 n2)
        {
            return new Base220(n1.Value / n2.Value);
        }

        public static Base220 operator +(Base220 n1, Base220 n2)
        {
            return new Base220(n1.Value + n2.Value);
        }

        public static bool operator <(Base220 n1, Base220 n2)
        {
            return n1.Value < n2.Value;
        }

        public static bool operator ==(Base220 n1, Base220 n2)
        {
            return n1.Equals(n2);
        }

        public static bool operator >(Base220 n1, Base220 n2)
        {
            return n1.Value > n2.Value;
        }

        #endregion Other Operators

        /*** Static Functions ***/

        #region Public Methods

        public static int ConvertFromBase220(string b220str)
        {
            int num = 0;
            int mod = 1;

            // Conversion
            for (int i = 0; i < b220str.Length; i++)
            {
                num += (b220str[i] - CHAR_OFFSET) * mod;
                mod *= 220;
            }

            return num;
        }

        /// <summary>
        /// </summary>
        /// <param name="num">
        /// </param>
        /// <returns>
        /// </returns>
        public static string ConvertToBase220(int num)
        {
            return ConvertToBase220(num, 0);
        }

        /// <summary>
        /// </summary>
        /// <param name="num">
        /// </param>
        /// <param name="nDigits">
        /// </param>
        /// <returns>
        /// </returns>
        public static string ConvertToBase220(int num, int nDigits)
        {
            StringBuilder b220str = new StringBuilder("");
            int ch;

            // Conversion
            while (num > 0)
            {
                ch = (num % 220) + CHAR_OFFSET; num /= 220;
                b220str.Append((char)ch);
            }

            // Applying padding if necessary.
            if (nDigits > 0)
            {
                if (b220str.Length < nDigits)
                    return b220str.Append(new String((char)CHAR_OFFSET, nDigits - b220str.Length)).ToString();
                if (b220str.Length > nDigits)
                    return new String((char)(CHAR_OFFSET + BASE - 1), nDigits);
            }

            return b220str.ToString();
        }

        /*** Methods ***/

        /// <summary>
        /// </summary>
        /// <param name="obj">
        /// </param>
        /// <returns>
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Base220))
                return false;
            return this.Value == ((Base220)obj).Value;
        }

        /// <summary>
        /// </summary>
        /// <param name="s">
        /// </param>
        /// <returns>
        /// </returns>
        public int FromString(string s)
        {
            return Value = ConvertFromBase220(s);
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public byte[] ToByteArray()
        {
            return ToByteArray(0);
        }

        /// <summary>
        /// </summary>
        /// <param name="nDigits">
        /// </param>
        /// <returns>
        /// </returns>
        public byte[] ToByteArray(int nDigits)
        {
            // System.Text.Encoding.GetEncoding(EncoderPage).GetBytes

            return System.Text.Encoding.GetEncoding(Utilities.GetEncoding).GetBytes(ToString(nDigits));
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public override string ToString()
        {
            return ConvertToBase220(Value);
        }

        /// <summary>
        /// </summary>
        /// <param name="nDigits">
        /// </param>
        /// <returns>
        /// </returns>
        public string ToString(int nDigits)
        {
            return ConvertToBase220(Value, nDigits);
        }

        #endregion Public Methods

        #region Interface Implementation

        /// <summary>
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public int CompareTo(int other)
        {
            return Value.CompareTo(other);
        }

        /// <summary>
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        public bool Equals(int other)
        {
            return Value.Equals(other);
        }

        #endregion Interface Implementation
    }
}