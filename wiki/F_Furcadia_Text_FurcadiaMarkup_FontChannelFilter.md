# FurcadiaMarkup.FontChannelFilter Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_



 font = 1 

 system.fhs =2 

 system alt = 3 

 Channel Name = 4 

 Text = 5

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string FontChannelFilter = "^<font color='([^']*?)'>(<img src='(fsh://system.fsh:([^']*)|http://apollo.furcadia.com/cache/(.*?))' (alt='(.*?)' )?/>)?(<channel name='(.*?)' />)?(.*?)</font>$"
```

**VB**<br />
``` VB
Public Const FontChannelFilter As String = "^<font color='([^']*?)'>(<img src='(fsh://system.fsh:([^']*)|http://apollo.furcadia.com/cache/(.*?))' (alt='(.*?)' )?/>)?(<channel name='(.*?)' />)?(.*?)</font>$"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.FontChannelFilter

```

**C++**<br />
``` C++
public:
literal String^ FontChannelFilter = "^<font color='([^']*?)'>(<img src='(fsh://system.fsh:([^']*)|http://apollo.furcadia.com/cache/(.*?))' (alt='(.*?)' )?/>)?(<channel name='(.*?)' />)?(.*?)</font>$"
```

**F#**<br />
``` F#
static val mutable FontChannelFilter: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />