# Remapper.Remap Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Drawing_Graphics">Furcadia.Drawing.Graphics</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static Bitmap Remap(
	byte[] source,
	int width,
	int height,
	string colourcode,
	int highlight
)
```

**VB**<br />
``` VB
Public Shared Function Remap ( 
	source As Byte(),
	width As Integer,
	height As Integer,
	colourcode As String,
	highlight As Integer
) As Bitmap
```

**VB Usage**<br />
``` VB Usage
Dim source As Byte()
Dim width As Integer
Dim height As Integer
Dim colourcode As String
Dim highlight As Integer
Dim returnValue As Bitmap

returnValue = Remapper.Remap(source, 
	width, height, colourcode, highlight)
```

**C++**<br />
``` C++
public:
static Bitmap^ Remap(
	array<unsigned char>^ source, 
	int width, 
	int height, 
	String^ colourcode, 
	int highlight
)
```

**F#**<br />
``` F#
static member Remap : 
        source : byte[] * 
        width : int * 
        height : int * 
        colourcode : string * 
        highlight : int -> Bitmap 

```


#### Parameters
&nbsp;<dl><dt>source</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/yyb1w04y" target="_blank">System.Byte</a>[]<br />\[Missing <param name="source"/> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]</dd><dt>width</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />\[Missing <param name="width"/> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]</dd><dt>height</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />\[Missing <param name="height"/> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]</dd><dt>colourcode</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="colourcode"/> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]</dd><dt>highlight</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />\[Missing <param name="highlight"/> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/4e7y164x" target="_blank">Bitmap</a><br />\[Missing <returns> documentation for "M:Furcadia.Drawing.Graphics.Remapper.Remap(System.Byte[],System.Int32,System.Int32,System.String,System.Int32)"\]

## See Also


#### Reference
<a href="T_Furcadia_Drawing_Graphics_Remapper">Remapper Class</a><br /><a href="N_Furcadia_Drawing_Graphics">Furcadia.Drawing.Graphics Namespace</a><br />