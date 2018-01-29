# IniFile.IniSection.SetName Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sets the section name, returns true on success, fails if the section name sSection already exists

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool SetName(
	string sSection
)
```

**VB**<br />
``` VB
Public Function SetName ( 
	sSection As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection
Dim sSection As String
Dim returnValue As Boolean

returnValue = instance.SetName(sSection)
```

**C++**<br />
``` C++
public:
bool SetName(
	String^ sSection
)
```

**F#**<br />
``` F#
member SetName : 
        sSection : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.IniSection.SetName(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />