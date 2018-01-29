# IniFile.IniSection.IniKey.Value Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sets or Gets the value of the key

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string Value { get; set; }
```

**VB**<br />
``` VB
Public Property Value As String
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection.IniKey
Dim value As String

value = instance.Value

instance.Value = value
```

**C++**<br />
``` C++
public:
property String^ Value {
	String^ get ();
	void set (String^ value);
}
```

**F#**<br />
``` F#
member Value : string with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The value.

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection_IniKey">IniFile.IniSection.IniKey Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />