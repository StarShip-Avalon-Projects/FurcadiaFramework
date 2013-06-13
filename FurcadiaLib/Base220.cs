/* Author: Artex (aka, 1337)
 * Base95 Format.
 * Uses: I have no idea.  Enjoy!
 * P.S: jk above...
*/
using System;
using System.Text;
using Furcadia.Net;
namespace Furcadia
{
	/// <summary>
	/// 
	/// </summary>
	public class Base220 : IComparable<uint>, IEquatable<uint>
	{
		public const byte CHAR_OFFSET = (byte)'#';
		public const byte BASE = 220;
		public uint Value;

		/*** Constructor ***/
		public Base220() : this(0) { }
		public Base220(uint n) { Value = n; }
		public Base220(string s) { FromString(s); }

		#region Conversion Operators
		public static implicit operator Base220(uint n) { return new Base220(n); }
		public static implicit operator Base220(ushort n) { return new Base220(n); }
		public static implicit operator Base220(string s) { return new Base220(s); }
		public static implicit operator uint(Base220 b220n) { return b220n.Value; }
		public static explicit operator ushort(Base220 b220n) { return (ushort)b220n.Value; }
		public static implicit operator string(Base220 b220n) { return b220n.ToString(); }
		public static implicit operator byte[](Base220 b220n) { return b220n.ToByteArray(); }
		#endregion
		#region Other Operators
		public static Base220 operator +(Base220 n1, Base220 n2)
		{
			return new Base220(n1.Value + n2.Value);
		}
		public static Base220 operator -(Base220 n1, Base220 n2)
		{
			return new Base220(n1.Value - n2.Value);
		}
		public static Base220 operator *(Base220 n1, Base220 n2)
		{
			return new Base220(n1.Value * n2.Value);
		}
		public static Base220 operator /(Base220 n1, Base220 n2)
		{
			return new Base220(n1.Value / n2.Value);
		}
		public static Base220 operator %(Base220 n1, Base220 n2)
		{
			return new Base220(n1.Value % n2.Value);
		}
		public static bool operator ==(Base220 n1, Base220 n2)
		{
			return n1.Equals(n2);
		}
		public static bool operator !=(Base220 n1, Base220 n2)
		{
			return !(n1 == n2);
		}
		public static bool operator <(Base220 n1, Base220 n2)
		{
			return n1.Value < n2.Value;
		}
		public static bool operator >(Base220 n1, Base220 n2)
		{
			return n1.Value > n2.Value;
		}
		#endregion

		/*** Static Functions ***/
		public static string ConvertToBase220(uint num)
		{
			return ConvertToBase220(num, 0);
		}
		public static string ConvertToBase220(uint num, int nDigits)
		{
			StringBuilder b220str = new StringBuilder("");
			uint ch;

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
		public static uint ConvertFromBase220(string b220str)
		{
			uint num = 0;
			uint mod = 1;

			// Conversion
            for (int i = 0; i < b220str.Length; i++)
			{
				num += (uint)(((int)b220str[i] - CHAR_OFFSET) * mod);
				mod *= 220;
			}

			return num;
		}

		/*** Methods ***/
		public override string ToString()
		{
			return ConvertToBase220(Value);
		}
		public string ToString(int nDigits)
		{
			return ConvertToBase220(Value, nDigits);
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
		public uint FromString(string s)
		{
			return Value = ConvertFromBase220(s);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Base220))
				return false;
			return this.Value == ((Base220)obj).Value;
		}
		
		public override int GetHashCode ()
		{
			return base.GetHashCode ();
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
		#endregion
	}
}