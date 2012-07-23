using System;

namespace Furcadia.Compression.Checksums
{
	/// <summary>
	/// Summary description for CRCStream.
	/// </summary>
	public sealed class CRCTool
	{
		private CRCTool()
		{
		}

		public static long CalculateCRC( System.IO.Stream inStream )
		{
			return CalculateCRC( inStream, null, 0, inStream.Length );
		}

		public static long CalculateCRC( System.IO.Stream inStream, 
			long length)
		{
			return CalculateCRC( inStream, null, inStream.Position, length );
		}

		public static long CalculateCRC( System.IO.Stream inStream, 
			IChecksum checksum,
			long startPoint, long length)
		{
			if( inStream == null )
				throw new ArgumentNullException( "inStream", "inStream can not be null." );

			if( checksum == null )
				checksum = new Crc32();
			
			if( !inStream.CanSeek || !inStream.CanRead )
				throw new ArgumentException( "inStream must be readable and seekable", "inStream" );
			//save the current position for later
			long position = inStream.Position;
			inStream.Position = startPoint;

			//now read the file in blocks, then dump it through the crc.
			long remainingLength = length;
			while( remainingLength > 0 )
			{
				int dataToRead = (int)remainingLength;
				if( dataToRead > 2048 )
					dataToRead = 2048;
				byte[] data = new byte[2048];
				if( dataToRead != inStream.Read( data, 0, dataToRead ) )
					throw new System.IO.IOException( "Ran out of data" );

				checksum.Update( data, 0, dataToRead );

				remainingLength -= dataToRead;
			}

			//now restore the position
			inStream.Position = position;
			return checksum.Value;
		}
	}
}
