# Paths.LogsPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

**Note: This API is now obsolete.**

Logs path - contains session logs for each character and a sub-folder with whisper logs, should Pounce be enabled. 
Default: My Documents\Furcadia\Logs


**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")]
public string LogsPath { get; }
```

**VB**<br />
``` VB
<ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")>
Public ReadOnly Property LogsPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.LogsPath

```

**C++**<br />
``` C++
public:
[ObsoleteAttribute(L"As of The Second Dreaming, Tis is now legacy")]
property String^ LogsPath {
	String^ get ();
}
```

**F#**<br />
``` F#
[<ObsoleteAttribute("As of The Second Dreaming, Tis is now legacy")>]
member LogsPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />