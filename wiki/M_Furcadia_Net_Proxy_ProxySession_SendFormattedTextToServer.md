# ProxySession.SendFormattedTextToServer Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Format basic furcadia commands and send to server 
We also mirror the client to server banish system.

This maybe a good place to place Proxy/Bot commands for controls

default to say or "normal spoken command"


**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual void SendFormattedTextToServer(
	string data
)
```

**VB**<br />
``` VB
Public Overridable Sub SendFormattedTextToServer ( 
	data As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim data As String

instance.SendFormattedTextToServer(data)
```

**C++**<br />
``` C++
public:
virtual void SendFormattedTextToServer(
	String^ data
)
```

**F#**<br />
``` F#
abstract SendFormattedTextToServer : 
        data : string -> unit 
override SendFormattedTextToServer : 
        data : string -> unit 
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Raw Client to Server instruction</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />