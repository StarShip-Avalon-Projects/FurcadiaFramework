# IniFile.RenameSection Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Renames an existing section returns true on success, false if the section didn't exist or there was another section with the same sNewSection

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool RenameSection(
	string sSection,
	string sNewSection
)
```

**VB**<br />
``` VB
Public Function RenameSection ( 
	sSection As String,
	sNewSection As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim sNewSection As String
Dim returnValue As Boolean

returnValue = instance.RenameSection(sSection, 
	sNewSection)
```

**C++**<br />
``` C++
public:
bool RenameSection(
	String^ sSection, 
	String^ sNewSection
)
```

**F#**<br />
``` F#
member RenameSection : 
        sSection : string * 
        sNewSection : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd><dt>sNewSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s new section.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.RenameSection(System.String,System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />