# ProxySession.TextToServer Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Text Channel Prefixes (shout,whisper emote, Raw Server command) 
default to say or "normal spoken command"


**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void TextToServer(
	ref string data
)
```

**VB**<br />
``` VB
Public Sub TextToServer ( 
	ByRef data As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim data As String

instance.TextToServer(data)
```

**C++**<br />
``` C++
public:
void TextToServer(
	String^% data
)
```

**F#**<br />
``` F#
member TextToServer : 
        data : string byref -> unit 

```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="data"/> documentation for "M:Furcadia.Net.Proxy.ProxySession.TextToServer(System.String@)"\]</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />