# ProxySession.SendToServer Method (String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Send a raw instruction to Server through the Load Balancer

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public override void SendToServer(
	string message
)
```

**VB**<br />
``` VB
Public Overrides Sub SendToServer ( 
	message As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim message As String

instance.SendToServer(message)
```

**C++**<br />
``` C++
public:
virtual void SendToServer(
	String^ message
) override
```

**F#**<br />
``` F#
abstract SendToServer : 
        message : string -> unit 
override SendToServer : 
        message : string -> unit 
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Client to server Instruction</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="Overload_Furcadia_Net_Proxy_ProxySession_SendToServer">SendToServer Overload</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />