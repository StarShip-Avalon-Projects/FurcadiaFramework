# FurcadiaMarkup.ChannelTag Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Format Channel Tags 
<channel name='@channelname' />


**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool ChannelTag(
	ref string serverData,
	string replaceText
)
```

**VB**<br />
``` VB
Public Shared Function ChannelTag ( 
	ByRef serverData As String,
	replaceText As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim serverData As String
Dim replaceText As String
Dim returnValue As Boolean

returnValue = FurcadiaMarkup.ChannelTag(serverData, 
	replaceText)
```

**C++**<br />
``` C++
public:
static bool ChannelTag(
	String^% serverData, 
	String^ replaceText
)
```

**F#**<br />
``` F#
static member ChannelTag : 
        serverData : string byref * 
        replaceText : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>serverData</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Raw server data string</dd><dt>replaceText</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Reg ex supported text replacement</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True on a successful match

## See Also


#### Reference
<a href="T_Furcadia_Text_FurcadiaMarkup">FurcadiaMarkup Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />