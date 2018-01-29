# ProxySession.ClientStatusChanged Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Track the Furcadia Client status

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ProxySession.ClientStatusChangedEventHandler ClientStatusChanged
```

**VB**<br />
``` VB
Public Event ClientStatusChanged As ProxySession.ClientStatusChangedEventHandler
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim handler As ProxySession.ClientStatusChangedEventHandler

AddHandler instance.ClientStatusChanged, handler

```

**C++**<br />
``` C++
public:
 event ProxySession.ClientStatusChangedEventHandler^ ClientStatusChanged {
	void add (ProxySession.ClientStatusChangedEventHandler^ value);
	void remove (ProxySession.ClientStatusChangedEventHandler^ value);
}
```

**F#**<br />
``` F#
member ClientStatusChanged : IEvent<ProxySession.ClientStatusChangedEventHandler,
    NetClientEventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_Proxy_ProxySession_ClientStatusChangedEventHandler">Furcadia.Net.Proxy.ProxySession.ClientStatusChangedEventHandler</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />