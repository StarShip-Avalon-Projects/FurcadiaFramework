# ProxySession.ServerStatusChanged Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Track the Server Status

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ProxySession.ServerStatusChangedEventHandler ServerStatusChanged
```

**VB**<br />
``` VB
Public Event ServerStatusChanged As ProxySession.ServerStatusChangedEventHandler
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim handler As ProxySession.ServerStatusChangedEventHandler

AddHandler instance.ServerStatusChanged, handler

```

**C++**<br />
``` C++
public:
 event ProxySession.ServerStatusChangedEventHandler^ ServerStatusChanged {
	void add (ProxySession.ServerStatusChangedEventHandler^ value);
	void remove (ProxySession.ServerStatusChangedEventHandler^ value);
}
```

**F#**<br />
``` F#
member ServerStatusChanged : IEvent<ProxySession.ServerStatusChangedEventHandler,
    NetServerEventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_Proxy_ProxySession_ServerStatusChangedEventHandler">Furcadia.Net.Proxy.ProxySession.ServerStatusChangedEventHandler</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />