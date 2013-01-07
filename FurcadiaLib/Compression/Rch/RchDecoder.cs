using System;
using System.IO;
using Furcadia.Compression.Lzw;

namespace Furcadia.Compression.Rch
{
	/// <summary>
	/// Summary description for RchDecoder.
	/// </summary>
	public class RchDecoder
	{
		RchHeader _header;
		private RchDecoder()
		{
		}

		private void RunDecompressToDirectory( Stream source, string directoryName )
		{
			using(var reader = new BinaryReader( source, System.Text.Encoding.ASCII ))
			{
				_header = new RchHeader( reader );
				while( reader.PeekChar() != -1 )
				{
					var file = new RchFile( reader );
					var writer = new BinaryWriter( new FileStream( directoryName + 
						"/" + file.FileName, FileMode.CreateNew ), System.Text.Encoding.ASCII );
					file.DecompressBlock( reader, writer );
				}
				reader.Close();
			}

		}

		public static void DecompressToDirectory( Stream source, string directoryName )
		{
			var decoder = new RchDecoder();
			decoder.RunDecompressToDirectory( source, directoryName );
		}

		private class RchHeader
		{
			#region De/Constructor

			//0            4       'FR01'
			//4            4       Version
			//8            4       Timestamp (time_t)  They no longer use the timestamp, so
			//										 it's usually 0
			//12           4       Reserved (0)
			//16           4       Reserved (0)
			//20           4       Reserved (0)
			//24           4       Reserved (0)
			//28-                  Filechunks (no way of telling how many)

			public RchHeader( BinaryReader reader )
			{
				char[] header = reader.ReadChars(4);
				if( header[0] != 'F' || header[1] != 'R' || header[2] != '0' || header[3] != '1' )
					throw new ArgumentException( "Bad Rch Header" );

				Version = reader.ReadInt32();
				TimeStamp = reader.ReadInt32();
				Reserved0 = reader.ReadInt32();
				Reserved1 = reader.ReadInt32();
				Reserved2 = reader.ReadInt32();
				Reserved3 = reader.ReadInt32();
			}

			#endregion

			#region Public Properties

		    public int Version { get; private set; }
            public int TimeStamp { get; private set; }
		    public int Reserved0 { get; private set; }
		    public int Reserved1 { get; private set; }
		    public int Reserved2 { get; private set; }
		    public int Reserved3 { get; private set; }

		    #endregion
		}

		private class RchFile
		{
			#region Private Fields

		    #endregion

			#region De/Constructor

			//Rch-File Chunk
			//Position     Size    Desc
			//0            2       'FZ'
			//2            40      FileName (blank=nulls)
			//42           4       Version (of what, I wonder?)
			//46           4       Timestamp (time_t)  They no longer use the timestamp, so
			//							it's usually 0
			//50           4       File size (int)
			//54           4       File CRC-32
			//58           4       Compression_algo
			//62-          -       Data (compressed with David Bourgin's Lzw

			public RchFile( BinaryReader reader )
			{
				char[] header = reader.ReadChars(2);
				if( header[0] != 'F' || header[1] != 'Z' )
					throw new ArgumentException( "Invalid Block in .Rch file" );
				FileName = System.Text.Encoding.ASCII.GetString(reader.ReadBytes(40)).Replace("\0", "" );
				Version = reader.ReadInt32();
				TimeStamp = reader.ReadInt32();
				FileSize = reader.ReadInt32();
				Crc32 = reader.ReadInt32();
				CompressionAlgo = reader.ReadInt32();
			}

			#endregion

			#region Public Properties

		    public string FileName { get; private set; }
            public int Version { get; private set; }
            public int TimeStamp { get; private set; }
            public int FileSize { get; private set; }
            public int Crc32 { get; private set; }
            public int CompressionAlgo { get; private set; }

		    #endregion

			#region Public Methods

			public void DecompressBlock( BinaryReader reader, BinaryWriter writer )
			{
				long startPoint = reader.BaseStream.Position;
				//write all the stuff  to a file
				switch( CompressionAlgo )
				{
					case 0:
						LzwDecoder.LzwDecode( reader, writer );
						break;
					case 1:
						byte[] data1 = reader.ReadBytes(FileSize);
						for( int i = 0; i < data1.Length; i++ )
						{
							data1[i] = (byte)(data1[i]^0xff);
						}
						writer.Write( data1 );
						break;
					case 2:
						BZip2.BZip2.Decompress( reader.BaseStream, writer.BaseStream );
						break;
					default:
						byte[] data = reader.ReadBytes(FileSize);
						writer.Write( data );
						break;
				}

				//Reset the position to make sure we're in the right spot
				reader.BaseStream.Position = startPoint + FileSize;
			}

			#endregion
		}
	}
}
