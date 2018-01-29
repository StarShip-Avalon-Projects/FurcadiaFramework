# FurcadiaMarkup.UrlFilter Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Regex for working with HTML URLS

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string UrlFilter = "<a href='?"?(.*?)'?"?>(.*?)</a>"
```

**VB**<br />
``` VB
Public Const UrlFilter As String = "<a href='?"?(.*?)'?"?>(.*?)</a>"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.UrlFilter

```

**C++**<br />
``` C++
public:
literal String^ UrlFilter = "<a href='?"?(.*?)'?"?>(.*?)</a>"
```

**F#**<br />
``` F#
static val mutable UrlFilter: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />