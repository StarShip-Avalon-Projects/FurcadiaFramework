# FurcadiaMarkup.NameFilter Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "F:Furcadia.Text.FurcadiaMarkup.NameFilter"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string NameFilter = "<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") ?>(.{2,64})</name>"
```

**VB**<br />
``` VB
Public Const NameFilter As String = "<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") ?>(.{2,64})</name>"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.NameFilter

```

**C++**<br />
``` C++
public:
literal String^ NameFilter = "<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") ?>(.{2,64})</name>"
```

**F#**<br />
``` F#
static val mutable NameFilter: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />