# ObjectExtensions.AsInt16 Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsInt16(System.Object,System.Int16)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Extensions">Furcadia.Extensions</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static short AsInt16(
	this Object obj,
	short default = -1
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsInt16 ( 
	obj As Object,
	Optional default As Short = -1
) As Short
```

**VB Usage**<br />
``` VB Usage
Dim obj As Object
Dim default As Short
Dim returnValue As Short

returnValue = obj.AsInt16(default)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static short AsInt16(
	Object^ obj, 
	short default = -1
)
```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member AsInt16 : 
        obj : Object * 
        ?default : int16 
(* Defaults:
        let _default = defaultArg default -1
*)
-> int16 

```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="obj"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsInt16(System.Object,System.Int16)"\]</dd><dt>default (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e07e6fds" target="_blank">System.Int16</a><br />\[Missing <param name="default"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsInt16(System.Object,System.Int16)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/e07e6fds" target="_blank">Int16</a><br />\[Missing <returns> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsInt16(System.Object,System.Int16)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions Class</a><br /><a href="N_Furcadia_Extensions">Furcadia.Extensions Namespace</a><br />