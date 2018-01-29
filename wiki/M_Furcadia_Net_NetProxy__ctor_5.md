# NetProxy Constructor (String, Int32, Int32)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Connect to the Game serer by Host name to IP address

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public NetProxy(
	string host,
	int port,
	int lport
)
```

**VB**<br />
``` VB
Public Sub New ( 
	host As String,
	port As Integer,
	lport As Integer
)
```

**VB Usage**<br />
``` VB Usage
Dim host As String
Dim port As Integer
Dim lport As Integer

Dim instance As New NetProxy(host, port, 
	lport)
```

**C++**<br />
``` C++
public:
NetProxy(
	String^ host, 
	int port, 
	int lport
)
```

**F#**<br />
``` F#
new : 
        host : string * 
        port : int * 
        lport : int -> NetProxy
```


#### Parameters
&nbsp;<dl><dt>host</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />GameServer Ip address or hostname</dd><dt>port</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Game server port</dd><dt>lport</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Localhost port</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="Overload_Furcadia_Net_NetProxy__ctor">NetProxy Overload</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />