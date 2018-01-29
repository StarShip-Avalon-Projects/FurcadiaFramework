# IniFile.GetSection Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets the section.

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public IniFile.IniSection GetSection(
	string sSection
)
```

**VB**<br />
``` VB
Public Function GetSection ( 
	sSection As String
) As IniFile.IniSection
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim returnValue As IniFile.IniSection

returnValue = instance.GetSection(sSection)
```

**C++**<br />
``` C++
public:
IniFile.IniSection^ GetSection(
	String^ sSection
)
```

**F#**<br />
``` F#
member GetSection : 
        sSection : string -> IniFile.IniSection 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.GetSection(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />