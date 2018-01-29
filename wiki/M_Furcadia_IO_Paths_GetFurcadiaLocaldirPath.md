# Paths.GetFurcadiaLocaldirPath Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Find the current localdir path where data files would be stored on the current machine.

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string GetFurcadiaLocaldirPath()
```

**VB**<br />
``` VB
Public Function GetFurcadiaLocaldirPath As String
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
Dim returnValue As String

returnValue = instance.GetFurcadiaLocaldirPath()
```

**C++**<br />
``` C++
public:
String^ GetFurcadiaLocaldirPath()
```

**F#**<br />
``` F#
member GetFurcadiaLocaldirPath : unit -> string 

```


#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />Path to the data folder from localdir.ini or null if not found.

## See Also


#### Reference
<a href="T_Furcadia_IO_Paths">Paths Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />