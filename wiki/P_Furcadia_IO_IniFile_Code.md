# IniFile.Code Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

If a Code section is detected, It's the last section in the ini file and all lines are read into here. 

 this is for DSC systyle wizard scripts

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string Code { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Code As String
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim value As String

value = instance.Code

```

**C++**<br />
``` C++
public:
property String^ Code {
	String^ get ();
}
```

**F#**<br />
``` F#
member Code : string with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The code.

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />