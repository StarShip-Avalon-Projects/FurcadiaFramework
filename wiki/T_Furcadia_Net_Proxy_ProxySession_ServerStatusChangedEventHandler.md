# ProxySession.ServerStatusChangedEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Proxy.ProxySession.ServerStatusChangedEventHandler"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ServerStatusChangedEventHandler(
	Object Sender,
	NetServerEventArgs e
)
```

**VB**<br />
``` VB
Public Delegate Sub ServerStatusChangedEventHandler ( 
	Sender As Object,
	e As NetServerEventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ServerStatusChangedEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ServerStatusChangedEventHandler(
	Object^ Sender, 
	NetServerEventArgs^ e
)
```

**F#**<br />
``` F#
type ServerStatusChangedEventHandler = 
    delegate of 
        Sender : Object * 
        e : NetServerEventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>Sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br /></dd><dt>e</dt><dd>Type: <a href="T_Furcadia_Net_NetServerEventArgs">Furcadia.Net.NetServerEventArgs</a><br /></dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />