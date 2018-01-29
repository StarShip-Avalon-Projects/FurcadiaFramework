# ProxySession.ProcessServerInstruction Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "E:Furcadia.Net.Proxy.ProxySession.ProcessServerInstruction"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ProxySession.ProcessInstruction ProcessServerInstruction
```

**VB**<br />
``` VB
Public Event ProcessServerInstruction As ProxySession.ProcessInstruction
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim handler As ProxySession.ProcessInstruction

AddHandler instance.ProcessServerInstruction, handler

```

**C++**<br />
``` C++
public:
 event ProxySession.ProcessInstruction^ ProcessServerInstruction {
	void add (ProxySession.ProcessInstruction^ value);
	void remove (ProxySession.ProcessInstruction^ value);
}
```

**F#**<br />
``` F#
member ProcessServerInstruction : IEvent<ProxySession.ProcessInstruction,
    ParseServerArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_Proxy_ProxySession_ProcessInstruction">Furcadia.Net.Proxy.ProxySession.ProcessInstruction</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />