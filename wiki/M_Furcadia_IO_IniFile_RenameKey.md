# IniFile.RenameKey Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Renames an existing key returns true on success, false if the key didn't exist or there was another section with the same sNewKey

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool RenameKey(
	string sSection,
	string sKey,
	string sNewKey
)
```

**VB**<br />
``` VB
Public Function RenameKey ( 
	sSection As String,
	sKey As String,
	sNewKey As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim sKey As String
Dim sNewKey As String
Dim returnValue As Boolean

returnValue = instance.RenameKey(sSection, 
	sKey, sNewKey)
```

**C++**<br />
``` C++
public:
bool RenameKey(
	String^ sSection, 
	String^ sKey, 
	String^ sNewKey
)
```

**F#**<br />
``` F#
member RenameKey : 
        sSection : string * 
        sKey : string * 
        sNewKey : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd><dt>sNewKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s new key.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.RenameKey(System.String,System.String,System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />