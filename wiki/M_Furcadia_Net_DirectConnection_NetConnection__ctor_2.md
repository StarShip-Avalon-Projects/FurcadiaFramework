# NetConnection Constructor (String, Int32)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Connect to game server with Host DNS and Specified port

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public NetConnection(
	string host,
	int port
)
```

**VB**<br />
``` VB
Public Sub New ( 
	host As String,
	port As Integer
)
```

**VB Usage**<br />
``` VB Usage
Dim host As String
Dim port As Integer

Dim instance As New NetConnection(host, port)
```

**C++**<br />
``` C++
public:
NetConnection(
	String^ host, 
	int port
)
```

**F#**<br />
``` F#
new : 
        host : string * 
        port : int -> NetConnection
```


#### Parameters
&nbsp;<dl><dt>host</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Game Server Host name</dd><dt>port</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Game server TCP Port</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_NetConnection">NetConnection Class</a><br /><a href="Overload_Furcadia_Net_DirectConnection_NetConnection__ctor">NetConnection Overload</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />