# IniFile.AddSection Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Adds a section to the IniFile object, returns a IniSection object to the new or existing object

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public IniFile.IniSection AddSection(
	string sSection
)
```

**VB**<br />
``` VB
Public Function AddSection ( 
	sSection As String
) As IniFile.IniSection
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim returnValue As IniFile.IniSection

returnValue = instance.AddSection(sSection)
```

**C++**<br />
``` C++
public:
IniFile.IniSection^ AddSection(
	String^ sSection
)
```

**F#**<br />
``` F#
member AddSection : 
        sSection : string -> IniFile.IniSection 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.AddSection(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />