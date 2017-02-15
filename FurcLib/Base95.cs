/* Author: Artex (aka, 1337)
 * Base95 Format.
 * Uses: I have no idea.  Enjoy!
 * P.S: jk above...
*/

using System;
using System.Text;

namespace Furcadia
{
    public class Base95 : IComparable<uint>, IEquatable<uint>
    {
        public const byte CHAR_OFFSET = (byte)' ';
        public const byte BASE = 95;
        public uint Value;

        /*** Constructor ***/

        public Base95() : this(0)
        {
        }

        public Base95(uint n)
        {
            Value = n;
        }

        public Base95(string s)
        {
            FromString(s);
        }

        #region Conversion Operators

        public static implicit operator Base95(uint n)
        {
            return new Base95(n);
        }

        public static implicit operator Base95(ushort n)
        {
            return new Base95(n);
        }

        public static implicit operator Base95(string s)
        {
            return new Base95(s);
        }

        public static implicit operator uint(Base95 b95n)
        {
            return b95n.Value;
        }

        public static explicit operator ushort(Base95 b95n)
        {
            return (ushort)b95n.Value;
        }

        public static implicit operator string(Base95 b95n)
        {
            return b95n.ToString();
        }

        public static implicit operator byte[] (Base95 b95n)
        {
            return b95n.ToByteArray();
        }

        #endregion Conversion Operators

        #region Other Operators

        public static Base95 operator +(Base95 n1, Base95 n2)
        {
            return new Base95(n1.Value + n2.Value);
        }

        public static Base95 operator -(Base95 n1, Base95 n2)
        {
            return new Base95(n1.Value - n2.Value);
        }

        public static Base95 operator *(Base95 n1, Base95 n2)
        {
            return new Base95(n1.Value * n2.Value);
        }

        public static Base95 operator /(Base95 n1, Base95 n2)
        {
            return new Base95(n1.Value / n2.Value);
        }

        public static Base95 operator %(Base95 n1, Base95 n2)
        {
            return new Base95(n1.Value % n2.Value);
        }

        public static bool operator ==(Base95 n1, Base95 n2)
        {
            return n1.Equals(n2);
        }

        public static bool operator !=(Base95 n1, Base95 n2)
        {
            return !(n1 == n2);
        }

        public static bool operator <(Base95 n1, Base95 n2)
        {
            return n1.Value < n2.Value;
        }

        public static bool operator >(Base95 n1, Base95 n2)
        {
            return n1.Value > n2.Value;
        }

        #endregion Other Operators

        /*** Static Functions ***/

        public static string ConvertToBase95(uint num)
        {
            return ConvertToBase95(num, 0);
        }

        public static string ConvertToBase95(uint num, int nDigits)
        {
            StringBuilder b95str = new StringBuilder("");
            uint ch;

            // Conversion
            while (num > 0)
            {
                ch = (num % 95) + CHAR_OFFSET; num /= 95;
                b95str.Insert(0, (byte)ch);
            }

            // Applying padding if necessary.
            if (nDigits > 0)
            {
                if (b95str.Length < nDigits)
                    return b95str.Insert(0, new String((char)CHAR_OFFSET, nDigits - b95str.Length)).ToString();
                if (b95str.Length > nDigits)
                    return new String((char)(CHAR_OFFSET + BASE - 1), nDigits);
            }

            return b95str.ToString();
        }

        public static uint ConvertFromBase95(string b95str)
        {
            uint num = 0;
            uint mod = 1;

            // Conversion
            for (int i = b95str.Length - 1; i >= 0; i--)
            {
                num += (uint)(((int)b95str[i] - CHAR_OFFSET) * mod);
                mod *= 95;
            }

            return num;
        }

        /*** Methods ***/

        public override string ToString()
        {
            return ConvertToBase95(Value);
        }

        public string ToString(int nDigits)
        {
            return ConvertToBase95(Value, nDigits);
        }

        public byte[] ToByteArray()
        {
            return ToByteArray(0);
        }

        public byte[] ToByteArray(int nDigits)
        {
            System.Text.ASCIIEncoding enc = new ASCIIEncoding();
            return enc.GetBytes(ToString(nDigits));
        }

        public uint FromString(string s)
        {
            return Value = ConvertFromBase95(s);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Base95))
                return false;
            return this.Value == ((Base95)obj).Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Interface Implementation

        public int CompareTo(uint other)
        {
            return Value.CompareTo(other);
        }

        public bool Equals(uint other)
        {
            return Value.Equals(other);
        }

        #endregion Interface Implementation
    }
}