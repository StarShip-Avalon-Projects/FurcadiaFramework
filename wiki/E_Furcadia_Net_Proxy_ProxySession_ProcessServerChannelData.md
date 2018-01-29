# ProxySession.ProcessServerChannelData Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Process Display Text and Channels

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ProxySession.ProcessChannel ProcessServerChannelData
```

**VB**<br />
``` VB
Public Event ProcessServerChannelData As ProxySession.ProcessChannel
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim handler As ProxySession.ProcessChannel

AddHandler instance.ProcessServerChannelData, handler

```

**C++**<br />
``` C++
public:
 event ProxySession.ProcessChannel^ ProcessServerChannelData {
	void add (ProxySession.ProcessChannel^ value);
	void remove (ProxySession.ProcessChannel^ value);
}
```

**F#**<br />
``` F#
member ProcessServerChannelData : IEvent<ProxySession.ProcessChannel,
    ParseChannelArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_Proxy_ProxySession_ProcessChannel">Furcadia.Net.Proxy.ProxySession.ProcessChannel</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />