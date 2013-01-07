/* File: dcodlzw.c
   Author: David Bourgin
   Creation date: 25/3/95
   Last update: 12/10/95
   Purpose: Example of Lzw decoding with a file source to decompress.
*/

using System;
using System.IO;

namespace Furcadia.Compression.Lzw
{
    public class LzwDecoder
	{
		/* Global variables. */
		BinaryReader _sourceFile;
		BinaryWriter _destFile;

		ulong _valToRead;
		byte _bitCounterToRead;

		class DictionaryLink 
		{
			public byte Character;
			public DictionaryLink Predecessor;
		}

		uint _indexDic;
		/* Word counter already known in the dictionary. */
		byte _bitCounterDecoding;
		/* Bit counter in the decoding. */

		const int Exp2DicMax = 12;
		/* 2^EXP2_DIC_MAX gives the maximum word counter in the dictionary during *all* the compressions.
		   Possible values: 3 to 25.
		   Attention: Beyond 12, you can have some errors of memory allocation
		   depending on your compiler and your computer. */
		uint _indexDicMax;
		/* index_dic_max gives the maximum word counter in the dictionary during *one* compression.
		   This constant is restricted to the range of end_information_code to 2^EXP2_DIC_MAX. */
		const byte BitCounterMinDecoding = 9;
		/* Bit counter to encode 'initialization_code'. */
		uint _initializationCode;
		uint _endInformationCode;
		/* initialization_code and end_information_code are both consecutive
		   coming up just after the last known word in the initial dictionary. */

		DictionaryLink[] _dictionary;

		//the Furc files are xored by 0xFF, so we gota take it out
		byte ReadByte()
		{
			return (byte)(_sourceFile.ReadByte()^0xff);
		}

		void CreateDictionary()
			/* Returned parameters: None.
			   Action: First initialization of the dictionary when we start an decoding.
			   Errors: None if there is enough room.
			*/
		{
			uint i;

			_dictionary = new DictionaryLink[1<<Exp2DicMax];

			_indexDicMax=1<<12;
			_initializationCode=1<<(BitCounterMinDecoding-1);

			_endInformationCode=_initializationCode+1;
			for (i=0;i<_indexDicMax;i++)
			{
				_dictionary[i] = new DictionaryLink();
				if (i<_initializationCode)
					_dictionary[i].Character=(byte)i;
			}
			_indexDic=_endInformationCode+1;
			_bitCounterDecoding=BitCounterMinDecoding;
		}

		void ResetDictionary()
			/* Returned parameters: None.
			   Action: Initialization of the dictionary during the decoding.
			   The dictionary must have been initialized once by 'init_dictionary1'.
			   Errors: None.
			*/
		{
			uint i;

			for (i=_initializationCode;i<_indexDicMax;i++)
				_dictionary[i].Predecessor=null;
			_indexDic=_endInformationCode+1;
			_bitCounterDecoding=BitCounterMinDecoding;
		}

		void WriteLink(DictionaryLink chainage)
			/* Returned parameters: 'character' can have been modified.
			   Action: Sends the string in the output stream given by the 'link' of the Lzw dictionary.
			   'character' contains to the end of the routine the first character of the string.
			   Errors: None (except a possible overflow of the operational stack allocated
			   by the program, which must allows at least 8*INDEX_DIC_MAX bytes, corresponding
			   to an exceptional case.
			*/
		{
			if (chainage.Predecessor!=null)
			{
				WriteLink(chainage.Predecessor);
			}
			else 
			{
				_character=chainage.Character;
			}
			_destFile.Write(chainage.Character);
		}

		//This is the last character of the chain that was written
		byte _character;
		byte WriteString(uint predCode,uint currentCode,byte firstChar)
			/* Returned parameters: Returns a byte.
			   Action: Writes the string of bytes associated to 'current_node' and returns
			   the first character of this string.
			   Errors: None.
			*/
		{
			if (currentCode<_indexDic)
				WriteLink(_dictionary[currentCode] );
			else 
			{
				WriteLink(_dictionary[predCode] );
				_destFile.Write(firstChar);
			}
			return _character;
		}

		void AddString(uint code, byte firstChar)
			/* Returned parameters: None.
			   Action: Adds the string given by 'code' to the dictionary.
			   Errors: None.
			*/
		{
			_dictionary[_indexDic].Character=firstChar;
			_dictionary[_indexDic].Predecessor=_dictionary[code];
			_indexDic++;
			if (_indexDic+1==(1<<_bitCounterDecoding))
				_bitCounterDecoding++;
		}

		uint ReadCodeLr()
			/* Returned parameters: Returns the value of code.
			   Action: Returns the value coded on 'bit_counter_decoding' bits from the stream of input codes.
			   The bits are stored from left to right. Example: aaabbbbcccc is written:
			   Bits     7 6 5 4 3 2 1 0
			   Byte 1   a a a b b b b c
			   Byte 2   c c c ? ? ? ? ?
			   Errors: An input/output error could disturb the running of the program.
			*/
		{
		    while (_bitCounterToRead<_bitCounterDecoding)
			{
				_valToRead=(_valToRead<<8)|ReadByte();
				_bitCounterToRead += 8;
			}
			_bitCounterToRead -= _bitCounterDecoding;
			uint readCode = (uint)_valToRead>>_bitCounterToRead;
			_valToRead &= (ulong) ((1<<_bitCounterToRead)-1);
			return readCode;
		}

		void LzwDecoding()
			/* Returned parameters: None.
			   Action: Compresses with Lzw method all bytes read by the function 'read_code_??'.
			   (where '??' is 'lr' or 'rl', depending on how you stored the bits in the compressed stream.
			   Errors: An input/output error could disturb the running of the program.
			*/
		{
		    uint predCode = 0;
		    byte firstChar = 0;

			if(_sourceFile.PeekChar() != -1)
			{
				CreateDictionary();
				uint currentCode = ReadCodeLr();
				if (currentCode!=_initializationCode)
				{
					throw new ApplicationException("Fichier de codes invalide!");
				}
				if ((currentCode=ReadCodeLr())<_initializationCode)
				{
					firstChar=WriteString(predCode,currentCode,firstChar);
					predCode=currentCode;
					currentCode=ReadCodeLr();
				}
				else 
				{
					throw new ApplicationException("Fichier de codes invalide2!");
				}
				while (currentCode!=_endInformationCode)
				{
					if (currentCode==_initializationCode)
					{
						ResetDictionary();
						currentCode=ReadCodeLr();
						if (currentCode<_initializationCode)
						{
							firstChar=WriteString(predCode,currentCode,firstChar);
							predCode=currentCode;
							currentCode=ReadCodeLr();
						}
					}
					else 
					{
						if (currentCode>_indexDic)
						{
							throw new ApplicationException("Fichier de codes invalide!");
						}

						if (_indexDic==_indexDicMax)
						{
							throw new ApplicationException("Depassement de capacite du dictionary!\n");
						}
						firstChar=WriteString(predCode,currentCode,firstChar);
						AddString(predCode,firstChar);
						predCode=currentCode;
						currentCode=ReadCodeLr();
					}
				}
			}
		}

        private void Run(BinaryReader inStream, BinaryWriter outStream)
		{
            _sourceFile = inStream;
            _destFile = outStream;
			LzwDecoding();
			_destFile.Flush();
			//I'm not disposing of the reader or the writer because I don't want it
			// to close the underlying stream.
		}

        public static void LzwDecode(BinaryReader inStream, BinaryWriter outStream)
		{
			var decoder = new LzwDecoder();
			decoder.Run( inStream, outStream );
		}
	}
}