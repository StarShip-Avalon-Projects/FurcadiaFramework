# ProxySession.ClientStatusChangedEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Proxy.ProxySession.ClientStatusChangedEventHandler"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ClientStatusChangedEventHandler(
	Object Sender,
	NetClientEventArgs e
)
```

**VB**<br />
``` VB
Public Delegate Sub ClientStatusChangedEventHandler ( 
	Sender As Object,
	e As NetClientEventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ClientStatusChangedEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ClientStatusChangedEventHandler(
	Object^ Sender, 
	NetClientEventArgs^ e
)
```

**F#**<br />
``` F#
type ClientStatusChangedEventHandler = 
    delegate of 
        Sender : Object * 
        e : NetClientEventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>Sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br /></dd><dt>e</dt><dd>Type: <a href="T_Furcadia_Net_NetClientEventArgs">Furcadia.Net.NetClientEventArgs</a><br /></dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />