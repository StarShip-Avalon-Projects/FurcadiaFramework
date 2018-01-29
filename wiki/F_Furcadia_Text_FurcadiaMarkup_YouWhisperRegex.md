# FurcadiaMarkup.YouWhisperRegex Field
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Whispers Name

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public const string YouWhisperRegex = "^<font color=('(whisper)'|"(whisper)")>\[ ?You whisper "(.*?)" to ?<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") forced(=('forced')|("forced")?) src='whisper-to'>(.*?)</name>\. \]</font>$"
```

**VB**<br />
``` VB
Public Const YouWhisperRegex As String = "^<font color=('(whisper)'|"(whisper)")>\[ ?You whisper "(.*?)" to ?<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") forced(=('forced')|("forced")?) src='whisper-to'>(.*?)</name>\. \]</font>$"
```

**VB Usage**<br />
``` VB Usage
Dim value As String

value = FurcadiaMarkup.YouWhisperRegex

```

**C++**<br />
``` C++
public:
literal String^ YouWhisperRegex = "^<font color=('(whisper)'|"(whisper)")>\[ ?You whisper "(.*?)" to ?<name shortname=('[a-z0-9]{2,64}'|"[a-z0-9]{2,64}") forced(=('forced')|("forced")?) src='whisper-to'>(.*?)</name>\. \]</font>$"
```

**F#**<br />
``` F#
static val mutable YouWhisperRegex: string
```


#### Field Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />