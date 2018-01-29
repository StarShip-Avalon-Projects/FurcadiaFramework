# Paths.LocaldirPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

LocalDir path - a specific path where all the player-specific and cache data is stored in its classic form. Used mainly to retain the classic path structure or to run Furcadia from a removable disk.

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string LocaldirPath { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property LocaldirPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.LocaldirPath

```

**C++**<br />
``` C++
public:
property String^ LocaldirPath {
	String^ get ();
}
```

**F#**<br />
``` F#
member LocaldirPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />