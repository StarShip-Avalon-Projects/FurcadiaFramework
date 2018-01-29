# Paths.SettingsPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Personal settings path - contains all the Furcadia settings for each user that uses it. 

 Default (VISTA+): %USERPROFILE%\Local\AppData\Dragon's Eye Productions\Furcadia

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string SettingsPath { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property SettingsPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.SettingsPath

```

**C++**<br />
``` C++
public:
property String^ SettingsPath {
	String^ get ();
}
```

**F#**<br />
``` F#
member SettingsPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />