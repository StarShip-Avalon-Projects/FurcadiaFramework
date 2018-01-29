# IniFile.RemoveSection Method (IniFile.IniSection)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Removes section by object, returns trus on success

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool RemoveSection(
	IniFile.IniSection Section
)
```

**VB**<br />
``` VB
Public Function RemoveSection ( 
	Section As IniFile.IniSection
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim Section As IniFile.IniSection
Dim returnValue As Boolean

returnValue = instance.RemoveSection(Section)
```

**C++**<br />
``` C++
public:
bool RemoveSection(
	IniFile.IniSection^ Section
)
```

**F#**<br />
``` F#
member RemoveSection : 
        Section : IniFile.IniSection -> bool 

```


#### Parameters
&nbsp;<dl><dt>Section</dt><dd>Type: <a href="T_Furcadia_IO_IniFile_IniSection">Furcadia.IO.IniFile.IniSection</a><br />The section.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.RemoveSection(Furcadia.IO.IniFile.IniSection)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="Overload_Furcadia_IO_IniFile_RemoveSection">RemoveSection Overload</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />