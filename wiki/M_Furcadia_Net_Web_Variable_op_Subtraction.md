# Variable.Subtraction Operator 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Implements the operator -.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static Variable operator -(
	Variable varA,
	double num
)
```

**VB**<br />
``` VB
Public Shared Operator - ( 
	varA As Variable,
	num As Double
) As Variable
```

**VB Usage**<br />
``` VB Usage
Dim varA As Variable
Dim num As Double
Dim returnValue As Variable

returnValue = (varA - num)
```

**C++**<br />
``` C++
public:
static Variable^ operator -(
	Variable^ varA, 
	double num
)
```

**F#**<br />
``` F#
static let inline (-)
        varA : Variable * 
        num : float  : Variable
```


#### Parameters
&nbsp;<dl><dt>varA</dt><dd>Type: <a href="T_Furcadia_Net_Web_Variable">Furcadia.Net.Web.Variable</a><br />The variable a.</dd><dt>num</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />The number.</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_Net_Web_Variable">Variable</a><br />The result of the operator.

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_Variable">Variable Class</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />