# IniFile.IniSection.IniKey.SetName Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sets the key name Returns true on success, fails if the section name sKey already exists

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool SetName(
	string sKey
)
```

**VB**<br />
``` VB
Public Function SetName ( 
	sKey As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection.IniKey
Dim sKey As String
Dim returnValue As Boolean

returnValue = instance.SetName(sKey)
```

**C++**<br />
``` C++
public:
bool SetName(
	String^ sKey
)
```

**F#**<br />
``` F#
member SetName : 
        sKey : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.IniSection.IniKey.SetName(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection_IniKey">IniFile.IniSection.IniKey Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />