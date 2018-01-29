# Variable.Addition Operator (Variable, String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Implements the operator +.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static Variable operator +(
	Variable varA,
	string str
)
```

**VB**<br />
``` VB
Public Shared Operator + ( 
	varA As Variable,
	str As String
) As Variable
```

**VB Usage**<br />
``` VB Usage
Dim varA As Variable
Dim str As String
Dim returnValue As Variable

returnValue = (varA + str)
```

**C++**<br />
``` C++
public:
static Variable^ operator +(
	Variable^ varA, 
	String^ str
)
```

**F#**<br />
``` F#
static let inline (+)
        varA : Variable * 
        str : string  : Variable
```


#### Parameters
&nbsp;<dl><dt>varA</dt><dd>Type: <a href="T_Furcadia_Net_Web_Variable">Furcadia.Net.Web.Variable</a><br />The variable a.</dd><dt>str</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The string.</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_Net_Web_Variable">Variable</a><br />The result of the operator.

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_Variable">Variable Class</a><br /><a href="Overload_Furcadia_Net_Web_Variable_op_Addition">Addition Overload</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />