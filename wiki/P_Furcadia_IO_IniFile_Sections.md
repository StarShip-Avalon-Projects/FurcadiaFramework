# IniFile.Sections Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets the sections.

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ICollection Sections { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Sections As ICollection
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim value As ICollection

value = instance.Sections

```

**C++**<br />
``` C++
public:
property ICollection^ Sections {
	ICollection^ get ();
}
```

**F#**<br />
``` F#
member Sections : ICollection with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/b1ht6113" target="_blank">ICollection</a><br />The sections.

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />