/* File: codlzw.c
   Author: David Bourgin
   Creation date: 25/3/95
   Last update: 12/10/95
   Purpose: Example of Lzw encoding with a file source to compress.
*/

using System.IO;

namespace Furcadia.Compression.Lzw
{
	public class LzwEncoder
	{
		/* Global variables. */
		BinaryReader _sourceFile;
		BinaryWriter _destFile;

	    readonly Checksums.Crc32 _crc = new Checksums.Crc32();

		ulong _valToWrite;
		byte _bitCounterToWrite;

		class DictionaryValue
		{
		    public byte Character;
			public uint Code;
			public DictionaryValue LeftPtr;
			public DictionaryValue RightPtr;
		};

		uint _indexDic;
		/* Word counter already known in the dictionary. */
		byte _bitCounterEncoding;
		/* Bit counter in the encoding. */

		const int Exp2DicMax = 12;
		/* 2^EXP2_DIC_MAX gives the maximum word counter in the dictionary during *all* the compressions.
		   Possible values: 3 to 25.
		   Attention: Beyond 12, you can have some errors of memory allocation
		   depending on your compiler and your computer. */
	    private const uint IndexDicMax = 1 << 12;
	    /* index_dic_max gives the maximum word counter in the dictionary during *one* compression.
		   This constant is restricted to the range of end_information_code to 2^EXP2_DIC_MAX. */
		const uint InitializationCode=(1<<8);
		const uint EndInformationCode=(1<<8)+1;
		/* initialization_code and end_information_code are both consecutive
		   coming up just after the last known word in the initial dictionary. */

		DictionaryValue[] _dictionary;

		void WriteByte( byte value )
		{
			_destFile.Write((byte)(value^0xff));
		}

		byte ReadByte()
		{
			byte value = _sourceFile.ReadByte();
			_crc.Update(value);
			return value;
		}

		public long CrcValue
		{
			get
			{
				return _crc.Value;
			}
		}

		void CreateDictionary()
			/* Returned parameters: None.
			   Action: First initialization of the dictionary when we start an encoding.
			   Errors: None if there is enough room.
			*/
		{
			uint i;

			_dictionary = new DictionaryValue[1<<Exp2DicMax];

			for (i=0;i<IndexDicMax;i++)
			{
				_dictionary[i] = new DictionaryValue();
				_dictionary[i].Code = i;
				if( i <= EndInformationCode )
					_dictionary[i].Character=(byte)i;
			}
			_indexDic=EndInformationCode+1;
			_bitCounterEncoding=9;
		}

		void ResetDictionary()
			/* Returned parameters: None.
			   Action: Initialization of the dictionary during the encoding.
			   Errors: None.
			*/
		{
			uint i;

			for (i=0;i<IndexDicMax;i++)
			{
				_dictionary[i].LeftPtr=null;
				_dictionary[i].RightPtr=null;
			}
			_indexDic=EndInformationCode+1;
			_bitCounterEncoding=9;
		}

		DictionaryValue find_node(DictionaryValue currentNode,byte symbol)
			/* Returned parameters: Returns a node in the tree of the dictionary.
			   Action: Looks for 'symbol' from 'current_node'.
			   This research is made from the left pointer of 'current_node'
			   (if the left pointer wasn't equal to null) and then move to all the right
			   pointers until we reach the node containing 'symbol' or the last node which
			   right pointer is null.
			   Errors: If the symbol has not been found out, (current_node=returned node) or (CHAR_DIC_VAL(returned node)#symbol).
			   The 'current_node' given to this routine must never be equal to null.
			*/
		{
		    if (currentNode.LeftPtr==null)
				return currentNode;
		
            DictionaryValue newNode = currentNode.LeftPtr;
		    while ((newNode.Character!=symbol)&&(newNode.RightPtr!=null))
		        newNode=newNode.RightPtr;
		    return newNode;
		}

		void AddNode(DictionaryValue currentNode,DictionaryValue newNode,byte symbol)
			/* Returned parameters: None.
			   Action: Creates a new_node in the tree of dictionary.
			   The summoning of this routine is normally done after a call to to find_node.
			   Errors: None.
			*/
		{
			_dictionary[_indexDic].Character=symbol;
			if (currentNode==newNode)
				newNode.LeftPtr=_dictionary[_indexDic];
			else
				newNode.RightPtr=_dictionary[_indexDic];
			_indexDic++;
			if (_indexDic==(1 << _bitCounterEncoding))
				_bitCounterEncoding++;
		}

		void WriteCodeLr(uint value)
			/* Returned parameters: None.
			   Action: Sends the value coded on 'bit_counter_encoding' bits in the stream of output codes.
			   The bits are stored from right to left. Example: aaabbbbcccc is written:
			   Bits     7 6 5 4 3 2 1 0
			   Byte 1   a a a b b b b c
			   Byte 2   c c c ? ? ? ? ?
			   Errors: An input/output error could disturb the running of the program.
			*/
		{
			_valToWrite=(_valToWrite << _bitCounterEncoding) | value;
			_bitCounterToWrite += _bitCounterEncoding;
			while (_bitCounterToWrite>=8)
			{
				_bitCounterToWrite -= 8;
				WriteByte((byte)(_valToWrite >> _bitCounterToWrite));
				_valToWrite &= (ulong)((1<< _bitCounterToWrite)-1);
			}
		}

		void CompleteEncodingLr()
			/* Returned parameters: None.
			   Action: Adds 0-bits to the last byte to write, if any.
			   This procedure is to be considered with the procedure write_code_lr.
			   Errors: An input/output error could disturb the running of the program.
			*/
		{
			if (_bitCounterToWrite>0)
				WriteByte((byte)(_valToWrite << (8-_bitCounterToWrite)));
			_valToWrite=_bitCounterToWrite=0;
		}

		void Lzwencoding()
			/* Returned parameters: None.
			   Action: Compresses with Lzw method all bytes read by the function 'read_input'.
			   Errors: An input/output error could disturb the running of the program.
			*/
		{
		    _crc.Reset();

			if (_sourceFile.PeekChar() != -1)
			{
				CreateDictionary();
				WriteCodeLr(InitializationCode);
				DictionaryValue currentNode = _dictionary[ReadByte()];
				while (_sourceFile.PeekChar() != -1)
				{
					byte symbol = ReadByte();
					DictionaryValue newNode = find_node(currentNode,symbol);
					if ((newNode!=currentNode)&&(newNode.Character==symbol))
						currentNode=newNode;
					else 
					{
						WriteCodeLr(currentNode.Code);
						AddNode(currentNode,newNode,symbol);
						if (_indexDic==IndexDicMax)
						{
							WriteCodeLr(InitializationCode);
							ResetDictionary();
						}
						currentNode=_dictionary[symbol];
					}
				}
				WriteCodeLr(currentNode.Code);
				WriteCodeLr(EndInformationCode);
				CompleteEncodingLr();
			}
		}

		private LzwEncoder()
		{
		}

        private void Run(BinaryReader inFile, BinaryWriter outFile)
		{
			//We have to set the econding so peek won't throw an exception
            _sourceFile = inFile;
            _destFile = outFile;
			Lzwencoding();
			//I'm not disposing of the reader or the writer because I don't want it
			// to close the underlying stream.
		}

        public static int LzwEncode(BinaryReader inFile, BinaryWriter outFile)
		{
			var encoder = new LzwEncoder();
			encoder.Run( inFile, outFile );
			return (int) encoder.CrcValue;
		}
	}
}