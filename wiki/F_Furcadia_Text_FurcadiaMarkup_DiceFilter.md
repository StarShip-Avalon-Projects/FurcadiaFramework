# FurcadiaMarkup.DiceFilter Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "F:Furcadia.Text.FurcadiaMarkup.DiceFilter"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string DiceFilter = "^<font color='roll'><img src='fsh://system.fsh:101' alt='@roll' /><channel name='(.*?)' /> <name shortname='([^ ]+)'>([^ ]+)</name> rolls (\d+)d(\d+)((-|\+)\d+)? ?(.*) & gets (\d+)\.</font>$"
```

**VB**<br />
``` VB
Public Const DiceFilter As String = "^<font color='roll'><img src='fsh://system.fsh:101' alt='@roll' /><channel name='(.*?)' /> <name shortname='([^ ]+)'>([^ ]+)</name> rolls (\d+)d(\d+)((-|\+)\d+)? ?(.*) & gets (\d+)\.</font>$"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.DiceFilter

```

**C++**<br />
``` C++
public:
literal String^ DiceFilter = "^<font color='roll'><img src='fsh://system.fsh:101' alt='@roll' /><channel name='(.*?)' /> <name shortname='([^ ]+)'>([^ ]+)</name> rolls (\d+)d(\d+)((-|\+)\d+)? ?(.*) & gets (\d+)\.</font>$"
```

**F#**<br />
``` F#
static val mutable DiceFilter: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />