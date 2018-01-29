# ArrayExtensions.ToString(*T*) Method (*T*[], Char)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Extensions.ArrayExtensions.ToString``1(``0[],System.Char)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Extensions">Furcadia.Extensions</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static string ToString<T>(
	this T[] arr,
	char seperator = ','
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ToString(Of T) ( 
	arr As T(),
	Optional seperator As Char = ","C
) As String
```

**VB Usage**<br />
``` VB Usage
Dim arr As T()
Dim seperator As Char
Dim returnValue As String

returnValue = arr.ToString(seperator)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
static String^ ToString(
	array<T>^ arr, 
	wchar_t seperator = L','
)
```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member ToString : 
        arr : 'T[] * 
        ?seperator : char 
(* Defaults:
        let _seperator = defaultArg seperator ','
*)
-> string 

```


#### Parameters
&nbsp;<dl><dt>arr</dt><dd>Type: *T*[]<br />\[Missing <param name="arr"/> documentation for "M:Furcadia.Extensions.ArrayExtensions.ToString``1(``0[],System.Char)"\]</dd><dt>seperator (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/k493b04s" target="_blank">System.Char</a><br />\[Missing <param name="seperator"/> documentation for "M:Furcadia.Extensions.ArrayExtensions.ToString``1(``0[],System.Char)"\]</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>\[Missing <typeparam name="T"/> documentation for "M:Furcadia.Extensions.ArrayExtensions.ToString``1(``0[],System.Char)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />\[Missing <returns> documentation for "M:Furcadia.Extensions.ArrayExtensions.ToString``1(``0[],System.Char)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type . When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Furcadia_Extensions_ArrayExtensions">ArrayExtensions Class</a><br /><a href="Overload_Furcadia_Extensions_ArrayExtensions_ToString">ToString Overload</a><br /><a href="N_Furcadia_Extensions">Furcadia.Extensions Namespace</a><br />