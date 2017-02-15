/* Author: Artex (aka, 1337)
 * Base95 Format.
 * Uses: I have no idea.  Enjoy!
 * P.S: jk above...
*/

using Furcadia.Net;
using System;
using System.Text;

namespace Furcadia
{
    /// <summary>
    /// </summary>
    public class Base220 : IComparable<int>, IEquatable<int>
    {
        private const byte BASE = 220;
        private const byte CHAR_OFFSET = (byte)'#';
        private int Value;

        /*** Constructor ***/

        public Base220() : this(0)
        {
        }

        public Base220(int n)
        {
            Value = n;
        }

        public Base220(string s)
        {
            FromString(s);
        }

        #region Conversion Operators

        public static explicit operator short(Base220 b220n)
        {
            return (short)b220n.Value;
        }

        public static implicit operator Base220(int n)
        {
            return new Base220(n);
        }

        public static implicit operator Base220(short n)
        {
            return new Base220(n);
        }

        public static implicit operator Base220(string s)
        {
            return new Base220(s);
        }

        public static implicit operator byte[] (Base220 b220n)
        {
            return b220n.ToByteArray();
        }

        public static implicit operator int(Base220 b220n)
        {
            return b220n.Value;
        }

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

        public static string ConvertToBase220(int num)
        {
            return ConvertToBase220(num, 0);
        }

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

        public override bool Equals(object obj)
        {
            if (!(obj is Base220))
                return false;
            return this.Value == ((Base220)obj).Value;
        }

        public int FromString(string s)
        {
            return Value = ConvertFromBase220(s);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public byte[] ToByteArray()
        {
            return ToByteArray(0);
        }

        public byte[] ToByteArray(int nDigits)
        {
            // System.Text.Encoding.GetEncoding(EncoderPage).GetBytes

            return System.Text.Encoding.GetEncoding(NetProxy.EncoderPage).GetBytes(ToString(nDigits));
        }

        public override string ToString()
        {
            return ConvertToBase220(Value);
        }

        public string ToString(int nDigits)
        {
            return ConvertToBase220(Value, nDigits);
        }

        #region Interface Implementation

        public int CompareTo(int other)
        {
            return Value.CompareTo(other);
        }

        public bool Equals(int other)
        {
            return Value.Equals(other);
        }

        #endregion Interface Implementation
    }
}