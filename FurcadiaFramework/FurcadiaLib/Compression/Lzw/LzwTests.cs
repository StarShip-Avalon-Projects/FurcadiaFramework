/* I commented it out because I don't want furclib to depend on Nunit.  This needs to get migrated to a test project.
using System;
using NUnit.Framework;

namespace Furcadia.Compression.Lzw
{
	/// <summary>
	/// Summary description for CompressionTest.
	/// </summary>
	[TestFixture]
	public class LzwTests
	{
		public LzwTests()
		{
		}

		[Test]
		public void CompressNullTest()
		{
			using (System.IO.MemoryStream inStream = new System.IO.MemoryStream( 1000000 ))
			using (System.IO.MemoryStream compressedStream = new System.IO.MemoryStream( 10000 ))
            using (System.IO.MemoryStream decompressedStream = new System.IO.MemoryStream(1000000))
            using (System.IO.BinaryReader inStreamReader = new System.IO.BinaryReader(inStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryWriter compressedWriter = new System.IO.BinaryWriter(compressedStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryReader compressReader = new System.IO.BinaryReader(compressedStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryWriter decompressWriter = new System.IO.BinaryWriter(decompressedStream, System.Text.Encoding.ASCII))
            {
                for (int i = 0; i < 1000000; i++)
                    inStream.WriteByte(0);
                inStream.Position = 0;


                LzwEncoder.LzwEncode(inStreamReader, compressedWriter);

                compressedStream.Position = 0;

                LzwDecoder.LzwDecode(compressReader, decompressWriter);

                inStream.Position = 0;
                decompressedStream.Position = 0;
                Assert.AreEqual(inStream.Length, decompressedStream.Length);
                Assert.AreEqual(inStream.ToArray(), decompressedStream.ToArray());
            }
		}

		[Test]
		public void CompressRandomTest()
		{
            using (System.IO.MemoryStream inStream = new System.IO.MemoryStream( 1000000 ))
			using (System.IO.MemoryStream compressedStream = new System.IO.MemoryStream( 10000 ))
            using (System.IO.MemoryStream decompressedStream = new System.IO.MemoryStream(1000000))
            using (System.IO.BinaryReader inStreamReader = new System.IO.BinaryReader(inStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryWriter compressedWriter = new System.IO.BinaryWriter(compressedStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryReader compressReader = new System.IO.BinaryReader(compressedStream, System.Text.Encoding.ASCII))
            using (System.IO.BinaryWriter decompressWriter = new System.IO.BinaryWriter(decompressedStream, System.Text.Encoding.ASCII))
            {

                System.Random rand = new Random(1);
                for (int i = 0; i < 1000000; i++)
                    inStream.WriteByte((byte)rand.Next(byte.MaxValue));
                inStream.Position = 0;

                LzwEncoder.LzwEncode(inStreamReader, compressedWriter);

                compressedStream.Position = 0;

                LzwDecoder.LzwDecode(compressReader, decompressWriter);

                inStream.Position = 0;
                decompressedStream.Position = 0;
                Assert.AreEqual(inStream.Length, decompressedStream.Length);
                Assert.AreEqual(inStream.ToArray(), decompressedStream.ToArray());
            }
		}
	}
}
*/