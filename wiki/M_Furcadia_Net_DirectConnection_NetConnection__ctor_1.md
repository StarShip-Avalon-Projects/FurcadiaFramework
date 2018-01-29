# NetConnection Constructor (IPAddress, Int32)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Connect to game server with Host IP address and Specified port

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public NetConnection(
	IPAddress ip,
	int port
)
```

**VB**<br />
``` VB
Public Sub New ( 
	ip As IPAddress,
	port As Integer
)
```

**VB Usage**<br />
``` VB Usage
Dim ip As IPAddress
Dim port As Integer

Dim instance As New NetConnection(ip, port)
```

**C++**<br />
``` C++
public:
NetConnection(
	IPAddress^ ip, 
	int port
)
```

**F#**<br />
``` F#
new : 
        ip : IPAddress * 
        port : int -> NetConnection
```


#### Parameters
&nbsp;<dl><dt>ip</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s128tyf6" target="_blank">System.Net.IPAddress</a><br />Game Server IP</dd><dt>port</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Game Server port</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_NetConnection">NetConnection Class</a><br /><a href="Overload_Furcadia_Net_DirectConnection_NetConnection__ctor">NetConnection Overload</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />