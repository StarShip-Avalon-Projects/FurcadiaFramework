#region Credit
/*
CREDIT: Kylix http://forums.furcadia.com/index.php?furcadia_session_id=12550-ucpo-pet&showtopic=45869&hl=kylix+fox
*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Furcadia.IO;
using System.IO;

namespace Furcadia.Drawing.Graphics
{
	public class FurcadiaShapesException : System.ApplicationException
	{
		public FurcadiaShapesException(string msg)
			: base(msg)
		{
		}
	}

	public class FurcadiaPaletteException : System.ApplicationException
	{
		public FurcadiaPaletteException(string msg)
			: base(msg)
		{
		}
	}

	public struct Frame
	{
		[FlagsAttribute]
		public enum FrameFormats : ushort
		{
			Format8Bit = 1,
			FormatRGB
		}

		public struct Pos
		{
			public short X;
			public short Y;
		}

		public FrameFormats FrameFormat;
		public ushort Width;
		public ushort Height;
		public Pos FramePos;
		public Pos FurrePos;
		public uint ImageDataSize;
		public byte[] ImageData;
	}

	public struct Shape
	{
		[FlagsAttribute]
		public enum ShapeFlags : ushort
		{
			Walkable = 1,
			Gettable = 2,
			Sittable = 4
		}

		public ShapeFlags Flags;
		public short ShapeNum;
		public ushort NumFrames;
		public ushort NumSteps;

		public Frame[] Frames;
		public StepBlock[] KitterSpeak;
	}

	public struct StepBlock
	{
		public enum StepBlockStepTypes : ushort
		{
			Frame = 1,
			Delay,
			Loop,
			Jump,
			PosX,
			PosY,
			FurreX,
			FurreY,
			DrawFront,
			DrawBehind,
			AutoFrameDelay,
			Stop,
			CameraState
		}

		public StepBlockStepTypes StepType;
		public short Value;
		public short CounterMax;
	}

	public class FurcadiaShapes
	{
		public string Header;
		public int Version;
		public int NumShapes;
		public int Generator;
		public int Encryption;
		public int Reserved1;
		public int Reserved2;
		public Shape[] Shapes;

		public FurcadiaShapes(string path)
		{
			/* Don't fiddle with extensions */
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);
			string header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4)).ToLower();
			br.Close();
			switch (header)
			{
				case "fshx":
					loadFOX(path);
					break;
				case "fsh2":
					loadFS2(path);
					break;
				default:
					loadFSH(path);
					break;
			}
		}

		void loadFOX(string path)
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Retrieve header information */
			Header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4));
			Version = br.ReadInt32();
			NumShapes = br.ReadInt32();
			Generator = br.ReadInt32();
			Encryption = br.ReadInt32();
			if (Encryption > 0)
			{
				br.Close();
				throw new FurcadiaShapesException("The FOX file (" + path + ") is encrypted and will not be opened.");
			}
			Reserved1 = br.ReadInt32();
			Reserved2 = br.ReadInt32();

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++)
			{
				/* Retrieve shape header information */
				Shapes[s].Flags = (Furcadia.Drawing.Graphics.Shape.ShapeFlags)br.ReadUInt16();
				Shapes[s].ShapeNum = br.ReadInt16();
				Shapes[s].NumFrames = br.ReadUInt16();
				Shapes[s].NumSteps = br.ReadUInt16();

				/* Loop through the frames */
				Shapes[s].Frames = new Frame[Shapes[s].NumFrames];
				for (int f = 0; f < Shapes[s].NumFrames; f++)
				{
					/* Retrieve frame information */
					Shapes[s].Frames[f].FrameFormat = (Furcadia.Drawing.Graphics.Frame.FrameFormats)br.ReadUInt16();
					Shapes[s].Frames[f].Width = br.ReadUInt16();
					Shapes[s].Frames[f].Height = br.ReadUInt16();
					Shapes[s].Frames[f].FramePos.X = br.ReadInt16();
					Shapes[s].Frames[f].FramePos.Y = br.ReadInt16();
					Shapes[s].Frames[f].FurrePos.X = br.ReadInt16();
					Shapes[s].Frames[f].FurrePos.Y = br.ReadInt16();
					Shapes[s].Frames[f].ImageDataSize = br.ReadUInt32();
					Shapes[s].Frames[f].ImageData = br.ReadBytes((int)Shapes[s].Frames[f].ImageDataSize);
				}

				/* Loop through the KitterSpeak */
				Shapes[s].KitterSpeak = new StepBlock[Shapes[s].NumSteps];
				for (int k = 0; k < Shapes[s].NumSteps; k++)
				{
					/* Retrieve KitterSpeak information */
					Shapes[s].KitterSpeak[k].StepType = (StepBlock.StepBlockStepTypes)br.ReadUInt16();
					Shapes[s].KitterSpeak[k].Value = br.ReadInt16();
					Shapes[s].KitterSpeak[k].CounterMax = br.ReadInt16();
				}
			}

			br.Close();
		}

		void loadFSH(string path)
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Assume/retrieve header information */
			Header = "FSH1";
			Version = 1;
			NumShapes = (int)br.ReadUInt16();
			Generator = 0;
			Encryption = 0;
			Reserved1 = 0;
			Reserved2 = 0;

			/* Skip over chunk sizes */
			for (int s = 0; s < NumShapes; s++) br.ReadUInt16();

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++)
			{
				Shapes[s].Flags = 0;
				Shapes[s].ShapeNum = 0;
				Shapes[s].NumFrames = 1;
				Shapes[s].NumSteps = 0;

				Shapes[s].Frames = new Frame[1];
				Shapes[s].Frames[0].FrameFormat = Frame.FrameFormats.Format8Bit;
				Shapes[s].Frames[0].Width = (ushort)br.ReadByte();
				Shapes[s].Frames[0].Height = (ushort)br.ReadByte();
				Shapes[s].Frames[0].FramePos.X = (short)br.ReadSByte();
				Shapes[s].Frames[0].FramePos.Y = (short)br.ReadSByte();
				Shapes[s].Frames[0].FurrePos.X = (short)0;
				Shapes[s].Frames[0].FurrePos.Y = (short)0;
				Shapes[s].Frames[0].ImageDataSize = (uint)(Shapes[s].Frames[0].Width * Shapes[s].Frames[0].Height);
				Shapes[s].Frames[0].ImageData = br.ReadBytes((int)Shapes[s].Frames[0].ImageDataSize);
			}

			br.Close();

			loadFBJ(path);
		}

		void loadFS2(string path)
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(path).BaseStream);

			/* Assume/retrieve header information */
			Header = System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(4)); br.ReadByte();
			Version = Convert.ToInt32(System.Text.ASCIIEncoding.ASCII.GetString(br.ReadBytes(3)));
			NumShapes = br.ReadInt32();
			Generator = 0;
			Encryption = br.ReadInt32();
			if (Encryption > 0)
			{
				br.Close();
				throw new FurcadiaShapesException("The FS2 file (" + path + ") is encrypted and will not be opened.");
			}
			Reserved1 = 0;
			Reserved2 = 0;

			/* Loop through the shapes */
			Shapes = new Shape[NumShapes];
			for (int s = 0; s < NumShapes; s++)
			{
				Shapes[s].Flags = 0;
				Shapes[s].NumFrames = 1;
				Shapes[s].NumSteps = 0;

				Shapes[s].Frames = new Frame[1];
				Shapes[s].Frames[0].FrameFormat = Frame.FrameFormats.Format8Bit;
				Shapes[s].Frames[0].Width = (ushort)br.ReadByte();
				Shapes[s].Frames[0].Height = (ushort)br.ReadByte();
				Shapes[s].Frames[0].FramePos.X = (short)br.ReadSByte();
				Shapes[s].Frames[0].FramePos.Y = (short)br.ReadSByte();
				Shapes[s].Frames[0].FurrePos.X = (short)0;
				Shapes[s].Frames[0].FurrePos.Y = (short)0;
				Shapes[s].ShapeNum = br.ReadInt16();
				Shapes[s].Frames[0].ImageDataSize = (uint)(Shapes[s].Frames[0].Width * Shapes[s].Frames[0].Height);
				Shapes[s].Frames[0].ImageData = br.ReadBytes((int)Shapes[s].Frames[0].ImageDataSize);
			}

			br.Close();

			try
			{
				loadFBJ(path);
			}
			catch
			{
				/* If it can't load the FBJ, oh well */
			}
		}

		[FlagsAttribute]
		private enum FBJFlags : byte
		{
			Walkable = 1,
			Gettable = 2,
			Sittable = 4,
			FurreX = 8,
			FurreY = 16
		}

		void loadFBJ(string path)
		{
			string file = changeExtension(path, "fbj");
			if (!File.Exists(file)) return;
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(file).BaseStream);

			/* Ignore header */
			br.ReadBytes(4);
			int chunkCount = br.ReadInt32();

			/* Read object definitions */
			for (int f = 0; f < chunkCount; f++)
			{
				byte thisFlag = br.ReadByte();
				Shapes[f].Flags = (Shape.ShapeFlags)(thisFlag & 0x07);

				if ((thisFlag & ((byte)FBJFlags.FurreX)) > 0)
				{
					Shapes[f].Frames[0].FurrePos.X = (short)br.ReadSByte();

					if ((thisFlag & ((byte)FBJFlags.FurreY)) > 0) Shapes[f].Frames[0].FurrePos.Y = (short)br.ReadSByte();
				}
				else if ((thisFlag & ((byte)FBJFlags.FurreY)) > 0)
				{
					Shapes[f].Frames[0].FurrePos.Y = (short)br.ReadSByte();
				}
			}

			br.Close();
		}

		string changeExtension(string path, string newExtension)
		{
			char[] delims = { '/', '\\' };
			string[] structure = path.Split(delims);
			string fullfile = structure[structure.GetUpperBound(0)];
			string filename = fullfile.Substring(0, fullfile.LastIndexOf('.'));
			string filepath = path.Substring(0, path.LastIndexOfAny(delims) + 1);
			return (filepath + filename + "." + newExtension);
		}

		
		public System.Drawing.Bitmap ToBitmap(Furcadia.Drawing.Graphics.Frame frame, Palette pal)
		{
			/* Create a new bitmap */
			try
			{
				System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(frame.Width, frame.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height);
				System.Drawing.Imaging.BitmapData bmpData =
					bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
					bmp.PixelFormat);

				/* Set up the bitmap data for use */
				IntPtr ptr = bmpData.Scan0;
				int bytes = bmpData.Stride * bmp.Height;
				byte[] rgbValues = new byte[bytes];

				/* Copy the image data over */
				if (frame.FrameFormat == Frame.FrameFormats.Format8Bit)
				{
					int bpos, ipos = (int)frame.ImageDataSize - 1;
					for (int y = 0; y < bmpData.Height; y++)
					{
						/* Alignment and flip */
						bpos = bmpData.Stride * (y + 1) - (bmpData.Stride - bmpData.Width * 4) - 1;

						/* Pixel assignment */
						for (int x = 0; x < bmpData.Width; x++)
						{
							rgbValues[bpos--] = pal.Colors[frame.ImageData[ipos]].A;
							rgbValues[bpos--] = pal.Colors[frame.ImageData[ipos]].R;
							rgbValues[bpos--] = pal.Colors[frame.ImageData[ipos]].G;
							rgbValues[bpos--] = pal.Colors[frame.ImageData[ipos--]].B;
						}
					}
					/* Save the bitmap */
					System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
					bmp.UnlockBits(bmpData);

				}
				else
				{
#warning 24-bit is not supported in this version. For updates: http://furcadia.codeplex.com/
					//24 bit support
				}
				return bmp;
			}
			catch
			{
				/* Because we don't care if it didn't render */
				return null;
			}
		}
		
		
	}

	public class Palette
	{
		public readonly Color[] Colors;

		/// <summary>
		/// title261.pcx
		/// </summary>
		public static Palette Default
		{
			get { return new Palette(Paths.GetDefaultPatchPath()+"/title261.pcx"); }
		}

		public Palette(string pcxPath)
		{
			byte[] colors;

			/* Open the PCX and rip out the palette (with verification!) */
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.StreamReader(pcxPath).BaseStream);
			br.BaseStream.Seek(-769, System.IO.SeekOrigin.End);
			if (br.ReadByte() != 12)
			{
				br.Close();
				throw new FurcadiaPaletteException("A 256-color palette was not found in file (" + pcxPath + ").");
			}
			colors = br.ReadBytes(768);
			br.Close();

			/* Reorganize the data into a Color class array */
			Color[] cols = new Color[256];
			cols[0] = System.Drawing.Color.FromArgb(0, 0, 0, 0);
			for (int i = 1; i < 256; i++)
			{
				cols[i] = Color.FromArgb(colors[i * 3], colors[i * 3 + 1], colors[i * 3 + 2]);
			}
			Colors = cols;
		}
	}
}