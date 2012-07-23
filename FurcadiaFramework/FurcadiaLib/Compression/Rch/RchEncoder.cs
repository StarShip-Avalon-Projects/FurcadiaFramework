using System;
using System.IO;
using Furcadia.Compression.Checksums;
using Furcadia.Compression.Lzw;

namespace Furcadia.Compression.Rch
{
	/// <summary>
	/// Summary description for RchEncode.
	/// </summary>
	public class RchEncoder
	{
		RchHeader _header;

		#region Methods

		private void RunCompressToDirectory( Stream destination, Stream[] filesToInclude, string[] fileNames )
		{
			if( filesToInclude.Length != fileNames.Length )
				throw new ArgumentException( "filesToInclude.Length != fileNames.Length" );

			using( var writer = new BinaryWriter( destination, System.Text.Encoding.ASCII ) )
			{
				_header = new RchHeader();
				_header.Write( writer );
				for( int i = 0; i < filesToInclude.Length; i++ )
				{
					var file = new RchFile();
					file.FileName = fileNames[i];
					var reader = new BinaryReader( filesToInclude[i], System.Text.Encoding.ASCII );
					file.Write( reader, writer );
				}
				writer.Close();
			}
		}

		public static void CompressToDirectory( Stream destination, Stream[] filesToInclude, string[] fileNames )
		{
			var decoder = new RchEncoder();
			decoder.RunCompressToDirectory( destination, filesToInclude, fileNames );
		}

		#endregion

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


			public void Write( BinaryWriter writer )
			{
				writer.Write('F');
				writer.Write('R');
				writer.Write('0');
				writer.Write('1');
				writer.Write(Version);
				writer.Write(Timestamp);
				writer.Write(Reserved0);
				writer.Write(Reserved1);
				writer.Write(Reserved2);
				writer.Write(Reserved3);
			}

			#endregion

			#region Public Properties

		    public int Version { get; set; }
            public int Timestamp { get; set; }
            public int Reserved0 { get; set; }
            public int Reserved1 { get; set; }
            public int Reserved2 { get; set; }
            public int Reserved3 { get; set; }

		    #endregion
		}

		private class RchFile
		{
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

			public RchFile()
			{
				CompressionAlgo = 2;
			}

			#endregion

			#region Public Properties

		    public string FileName { get; set; }
            public int Version { get; set; }
            public int TimeStamp { get; set; }
            public int FileSize { get; set; }
            public int Crc32 { get; set; }
            public int CompressionAlgo { get; set; }

		    #endregion

			#region Public Methods

			public void Write( BinaryReader reader, BinaryWriter writer )
			{
				//We need to save our positon before doing anything...
				long startPosition = writer.BaseStream.Position;

				//Now write a fake header
				writer.Write( new byte[62] );

				WriteCompressedBlock( reader, writer );
				FileSize = (int)(writer.BaseStream.Position - startPosition - 62);

				long endPosition = writer.BaseStream.Position;

				//now go back to the start, and write the real header
				writer.BaseStream.Position = startPosition;
				WriteHeader( writer );

				//and move back to the real end
				writer.BaseStream.Position = endPosition;
			}

			private void WriteHeader( BinaryWriter writer )
			{
				var header = new char[2];
				header[0] = 'F';
				header[1] = 'Z';
				writer.Write(header);
				var fileNameBytes = new byte[40];
				System.Text.Encoding.ASCII.GetBytes(FileName, 0, FileName.Length, fileNameBytes, 0 );
				fileNameBytes[39] = 0;
				writer.Write( fileNameBytes );
				writer.Write(Version);
				writer.Write(TimeStamp);
				writer.Write(FileSize);
				writer.Write(Crc32);
				writer.Write(CompressionAlgo);
			}


			private void WriteCompressedBlock( BinaryReader reader, BinaryWriter writer )
			{
				//write all the stuff to a file
				switch( CompressionAlgo )
				{
					case 0:
						Crc32 = LzwEncoder.LzwEncode( reader, writer );
						break;
					case 1:
						byte[] data1 = reader.ReadBytes(FileSize);
						var crc = new Crc32();
						crc.Update( data1 );
						for( int i = 0; i < data1.Length; i++ )
						{
							var newData = (byte)(data1[i]^0xff);
							data1[i] = newData;
						}
						writer.Write( data1 );
						Crc32 = (int) crc.Value;
						break;
					case 2:
						Crc32 = (int) CRCTool.CalculateCRC( reader.BaseStream );
						//I had to make a change to the Compress Method not to close the
						//underlieing stream when compression is complete
						BZip2.BZip2.Compress( reader.BaseStream, writer.BaseStream, 9 );
						break;
					default:
						throw new ArgumentException( "File has an unknown Compression Format.");
				}

				//Reset the position to make sure we're in the right spot
			}

			#endregion
		}
	}
}
