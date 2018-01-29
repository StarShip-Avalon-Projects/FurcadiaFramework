# IniFile.SetKeyValue Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sets a KeyValuePair in a certain section

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool SetKeyValue(
	string sSection,
	string sKey,
	string sValue
)
```

**VB**<br />
``` VB
Public Function SetKeyValue ( 
	sSection As String,
	sKey As String,
	sValue As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim sKey As String
Dim sValue As String
Dim returnValue As Boolean

returnValue = instance.SetKeyValue(sSection, 
	sKey, sValue)
```

**C++**<br />
``` C++
public:
bool SetKeyValue(
	String^ sSection, 
	String^ sKey, 
	String^ sValue
)
```

**F#**<br />
``` F#
member SetKeyValue : 
        sSection : string * 
        sKey : string * 
        sValue : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd><dt>sValue</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s value.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.SetKeyValue(System.String,System.String,System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />