# IniFile.IniSection.IniKey Constructor 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Constuctor so objects are internally managed

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
protected IniKey(
	IniFile.IniSection parent,
	string sKey
)
```

**VB**<br />
``` VB
Protected Sub New ( 
	parent As IniFile.IniSection,
	sKey As String
)
```

**VB Usage**<br />
``` VB Usage
Dim parent As IniFile.IniSection
Dim sKey As String

Dim instance As New IniFile.IniSection.IniKey(parent, 
	sKey)
```

**C++**<br />
``` C++
protected:
IniKey(
	IniFile.IniSection^ parent, 
	String^ sKey
)
```

**F#**<br />
``` F#
new : 
        parent : IniFile.IniSection * 
        sKey : string -> IniKey
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Furcadia_IO_IniFile_IniSection">Furcadia.IO.IniFile.IniSection</a><br />The parent.</dd><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection_IniKey">IniFile.IniSection.IniKey Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />