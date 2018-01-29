# ProxySession.ClientStatus Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Client Connection status

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ConnectionPhase ClientStatus { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ClientStatus As ConnectionPhase
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim value As ConnectionPhase

value = instance.ClientStatus

```

**C++**<br />
``` C++
public:
property ConnectionPhase ClientStatus {
	ConnectionPhase get ();
}
```

**F#**<br />
``` F#
member ClientStatus : ConnectionPhase with get

```


#### Return Value
Type: <a href="T_Furcadia_Net_ConnectionPhase">ConnectionPhase</a><br />Status tog the Furcadia Client

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />