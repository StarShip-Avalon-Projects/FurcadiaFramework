# Variable.Inequality Operator 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Implements the operator !=.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool operator !=(
	Variable varA,
	Variable varB
)
```

**VB**<br />
``` VB
Public Shared Operator <> ( 
	varA As Variable,
	varB As Variable
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim varA As Variable
Dim varB As Variable
Dim returnValue As Boolean

returnValue = (varA <> varB)
```

**C++**<br />
``` C++
public:
static bool operator !=(
	Variable^ varA, 
	Variable^ varB
)
```

**F#**<br />
``` F#
static let inline (<>)
        varA : Variable * 
        varB : Variable  : bool
```


#### Parameters
&nbsp;<dl><dt>varA</dt><dd>Type: <a href="T_Furcadia_Net_Web_Variable">Furcadia.Net.Web.Variable</a><br />The variable a.</dd><dt>varB</dt><dd>Type: <a href="T_Furcadia_Net_Web_Variable">Furcadia.Net.Web.Variable</a><br />The variable b.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />The result of the operator.

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_Variable">Variable Class</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />