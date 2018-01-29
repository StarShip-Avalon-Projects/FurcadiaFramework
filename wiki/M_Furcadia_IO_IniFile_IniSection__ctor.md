# IniFile.IniSection Constructor 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Constuctor so objects are internally managed

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
protected IniSection(
	IniFile parent,
	string sSection
)
```

**VB**<br />
``` VB
Protected Sub New ( 
	parent As IniFile,
	sSection As String
)
```

**VB Usage**<br />
``` VB Usage
Dim parent As IniFile
Dim sSection As String

Dim instance As New IniFile.IniSection(parent, 
	sSection)
```

**C++**<br />
``` C++
protected:
IniSection(
	IniFile^ parent, 
	String^ sSection
)
```

**F#**<br />
``` F#
new : 
        parent : IniFile * 
        sSection : string -> IniSection
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Furcadia_IO_IniFile">Furcadia.IO.IniFile</a><br />The parent.</dd><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />