# Base95&nbsp;Implicit Conversion (Base95 to Byte[])
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Text.Base95.op_Implicit(Furcadia.Text.Base95)~System.Byte[]"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static implicit operator byte[] (
	Base95 b95n
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	b95n As Base95
) As Byte()
```

**VB Usage**<br />
``` VB Usage
Dim input As Base95
Dim output As Byte()

output = CType(input, Byte())
```

**C++**<br />
``` C++
static implicit operator array<unsigned char>^ (
	Base95^ b95n
)
```

**F#**<br />
``` F#

```


#### Parameters
&nbsp;<dl><dt>b95n</dt><dd>Type: <a href="T_Furcadia_Text_Base95">Furcadia.Text.Base95</a><br />\[Missing <param name="b95n"/> documentation for "M:Furcadia.Text.Base95.op_Implicit(Furcadia.Text.Base95)~System.Byte[]"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/yyb1w04y" target="_blank">Byte</a>[]<br />\[Missing <returns> documentation for "M:Furcadia.Text.Base95.op_Implicit(Furcadia.Text.Base95)~System.Byte[]"\]

## See Also


#### Reference
<a href="T_Furcadia_Text_Base95">Base95 Class</a><br /><a href="Overload_Furcadia_Text_Base95_op_Implicit">Implicit Overload</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />