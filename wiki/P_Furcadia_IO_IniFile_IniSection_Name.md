# IniFile.IniSection.Name Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Returns the section name

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string Name { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Name As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection
Dim value As String

value = instance.Name

```

**C++**<br />
``` C++
public:
property String^ Name {
	String^ get ();
}
```

**F#**<br />
``` F#
member Name : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The name.

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />