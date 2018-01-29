# Paths.FurcadiaLocaldirPath Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Furcadia Localdir path - this path (when explicitly set), indicates the whereabouts of the data files used in Furcadia. If localdir.ini is present in the Furcadia folder, Furcadia.exe will load those files from the specific path and not the regular ones. Default: -NONE-

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string FurcadiaLocaldirPath { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property FurcadiaLocaldirPath As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim value As String

value = instance.FurcadiaLocaldirPath

```

**C++**<br />
``` C++
public:
property String^ FurcadiaLocaldirPath {
	String^ get ();
}
```

**F#**<br />
``` F#
member FurcadiaLocaldirPath : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />