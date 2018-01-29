# Paths.TemporaryPatchesPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Temporary patch path - contains downloaded temporary patches. This technology is never in use, yet supported, so this folder is always empty. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Patches

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string TemporaryPatchesPath { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property TemporaryPatchesPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.TemporaryPatchesPath

```

**C++**<br />
``` C++
public:
property String^ TemporaryPatchesPath {
	String^ get ();
}
```

**F#**<br />
``` F#
member TemporaryPatchesPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />