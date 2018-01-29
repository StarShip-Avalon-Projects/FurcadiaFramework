# Variable&nbsp;Implicit Conversion (Variable to String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Performs an implicit conversion from <a href="T_Furcadia_Net_Web_Variable">Variable</a> to <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static implicit operator string (
	Variable var
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	var As Variable
) As String
```

**VB Usage**<br />
``` VB Usage
Dim input As Variable
Dim output As String

output = CType(input, String)
```

**C++**<br />
``` C++
static implicit operator String^ (
	Variable^ var
)
```

**F#**<br />
``` F#

```


#### Parameters
&nbsp;<dl><dt>var</dt><dd>Type: <a href="T_Furcadia_Net_Web_Variable">Furcadia.Net.Web.Variable</a><br />The variable.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The result of the conversion.

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_Variable">Variable Class</a><br /><a href="Overload_Furcadia_Net_Web_Variable_op_Implicit">Implicit Overload</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />