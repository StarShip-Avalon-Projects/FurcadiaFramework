# Paths.CharacterPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

**Note: This API is now obsolete.**

Character file path - contains furcadia.ini files with login information for each character. 

 Default: My Documents\Furcadia\Furcadia Characters\

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")]
public string CharacterPath { get; }
```

**VB**<br />
``` VB
<ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")>
Public ReadOnly Property CharacterPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.CharacterPath

```

**C++**<br />
``` C++
public:
[ObsoleteAttribute(L"As of The Second Dreaming, Tis is now legacy")]
property String^ CharacterPath {
	String^ get ();
}
```

**F#**<br />
``` F#
[<ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")>]
member CharacterPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />