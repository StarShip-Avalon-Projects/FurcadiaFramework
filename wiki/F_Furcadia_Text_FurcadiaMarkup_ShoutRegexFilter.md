# FurcadiaMarkup.ShoutRegexFilter Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "F:Furcadia.Text.FurcadiaMarkup.ShoutRegexFilter"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string ShoutRegexFilter = "<font color=('(shout)'|"(shout)")>\{S\} <name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}")>(.{2,64})</name>(.*)shouts: (.*?)</font>"
```

**VB**<br />
``` VB
Public Const ShoutRegexFilter As String = "<font color=('(shout)'|"(shout)")>\{S\} <name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}")>(.{2,64})</name>(.*)shouts: (.*?)</font>"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.ShoutRegexFilter

```

**C++**<br />
``` C++
public:
literal String^ ShoutRegexFilter = "<font color=('(shout)'|"(shout)")>\{S\} <name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}")>(.{2,64})</name>(.*)shouts: (.*?)</font>"
```

**F#**<br />
``` F#
static val mutable ShoutRegexFilter: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />