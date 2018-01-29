# IniFile.RemoveSection Method (String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Removes a section by its name sSection, returns trus on success

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool RemoveSection(
	string sSection
)
```

**VB**<br />
``` VB
Public Function RemoveSection ( 
	sSection As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sSection As String
Dim returnValue As Boolean

returnValue = instance.RemoveSection(sSection)
```

**C++**<br />
``` C++
public:
bool RemoveSection(
	String^ sSection
)
```

**F#**<br />
``` F#
member RemoveSection : 
        sSection : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>sSection</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s section.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.RemoveSection(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="Overload_Furcadia_IO_IniFile_RemoveSection">RemoveSection Overload</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />