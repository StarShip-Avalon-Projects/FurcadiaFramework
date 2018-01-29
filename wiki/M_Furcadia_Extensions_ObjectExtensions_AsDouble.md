# ObjectExtensions.AsDouble Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsDouble(System.Object,System.Double)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Extensions">Furcadia.Extensions</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static double AsDouble(
	this Object obj,
	double default = -1
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsDouble ( 
	obj As Object,
	Optional default As Double = -1
) As Double
```

**VB Usage**<br />
``` VB Usage
Dim obj As Object
Dim default As Double
Dim returnValue As Double

returnValue = obj.AsDouble(default)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static double AsDouble(
	Object^ obj, 
	double default = -1
)
```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member AsDouble : 
        obj : Object * 
        ?default : float 
(* Defaults:
        let _default = defaultArg default -1
*)
-> float 

```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="obj"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsDouble(System.Object,System.Double)"\]</dd><dt>default (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">System.Double</a><br />\[Missing <param name="default"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsDouble(System.Object,System.Double)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a><br />\[Missing <returns> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsDouble(System.Object,System.Double)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions Class</a><br /><a href="N_Furcadia_Extensions">Furcadia.Extensions Namespace</a><br />