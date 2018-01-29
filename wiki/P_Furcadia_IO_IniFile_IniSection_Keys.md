# IniFile.IniSection.Keys Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Returns all the keys in a section

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ICollection Keys { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Keys As ICollection
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection
Dim value As ICollection

value = instance.Keys

```

**C++**<br />
``` C++
public:
property ICollection^ Keys {
	ICollection^ get ();
}
```

**F#**<br />
``` F#
member Keys : ICollection with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/b1ht6113" target="_blank">ICollection</a><br />The keys.

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />