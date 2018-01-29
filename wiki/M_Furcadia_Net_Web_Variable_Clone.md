# Variable.Clone Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Net.Web.Variable.Clone(System.Boolean)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public Variable Clone(
	bool asConstant = false
)
```

**VB**<br />
``` VB
Public Function Clone ( 
	Optional asConstant As Boolean = false
) As Variable
```

**VB Usage**<br />
``` VB Usage
Dim instance As Variable
Dim asConstant As Boolean
Dim returnValue As Variable

returnValue = instance.Clone(asConstant)
```

**C++**<br />
``` C++
public:
Variable^ Clone(
	bool asConstant = false
)
```

**F#**<br />
``` F#
member Clone : 
        ?asConstant : bool 
(* Defaults:
        let _asConstant = defaultArg asConstant false
*)
-> Variable 

```


#### Parameters
&nbsp;<dl><dt>asConstant (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />Clone as Constant</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_Net_Web_Variable">Variable</a><br />\[Missing <returns> documentation for "M:Furcadia.Net.Web.Variable.Clone(System.Boolean)"\]

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_Variable">Variable Class</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />