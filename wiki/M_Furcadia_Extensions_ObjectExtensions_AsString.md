# ObjectExtensions.AsString Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsString(System.Object,System.String)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Extensions">Furcadia.Extensions</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static string AsString(
	this Object obj,
	string default = null
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AsString ( 
	obj As Object,
	Optional default As String = Nothing
) As String
```

**VB Usage**<br />
``` VB Usage
Dim obj As Object
Dim default As String
Dim returnValue As String

returnValue = obj.AsString(default)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ AsString(
	Object^ obj, 
	String^ default = nullptr
)
```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member AsString : 
        obj : Object * 
        ?default : string 
(* Defaults:
        let _default = defaultArg default null
*)
-> string 

```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="obj"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsString(System.Object,System.String)"\]</dd><dt>default (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="default"/> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsString(System.Object,System.String)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />\[Missing <returns> documentation for "M:Furcadia.Extensions.ObjectExtensions.AsString(System.Object,System.String)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions Class</a><br /><a href="N_Furcadia_Extensions">Furcadia.Extensions Namespace</a><br />