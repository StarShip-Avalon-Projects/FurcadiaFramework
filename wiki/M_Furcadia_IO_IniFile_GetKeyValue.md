# IniFile.GetKeyValue Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets the key value.

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string GetKeyValue(
	string sSection,
	string sKey
)
```

**VB**<br />
``` VB
Public Function GetKeyValue ( 
	sSection As String,
	sKey As String
) As String
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim sKey As String
Dim returnValue As String

returnValue = instance.GetKeyValue(sSection, 
	sKey)
```

**C++**<br />
``` C++
public:
String^ GetKeyValue(
	String^ sSection, 
	String^ sKey
)
```

**F#**<br />
``` F#
member GetKeyValue : 
        sSection : string * 
        sKey : string -> string 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.GetKeyValue(System.String,System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />