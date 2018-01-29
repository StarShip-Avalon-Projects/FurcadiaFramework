# Paths.TemporaryFilesPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Temporary files path - contains downloaded and uploaded files that are either used to upload packages or download them for extraction. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Files

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string TemporaryFilesPath { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property TemporaryFilesPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.TemporaryFilesPath

```

**C++**<br />
``` C++
public:
property String^ TemporaryFilesPath {
	String^ get ();
}
```

**F#**<br />
``` F#
member TemporaryFilesPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />