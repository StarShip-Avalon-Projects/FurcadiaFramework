# ProxySession.ServerStatus Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Server Connection status

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ConnectionPhase ServerStatus { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ServerStatus As ConnectionPhase
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim value As ConnectionPhase

value = instance.ServerStatus

```

**C++**<br />
``` C++
public:
property ConnectionPhase ServerStatus {
	ConnectionPhase get ();
}
```

**F#**<br />
``` F#
member ServerStatus : ConnectionPhase with get

```


#### Return Value
Type: <a href="T_Furcadia_Net_ConnectionPhase">ConnectionPhase</a><br />Status of the Furcadia Game server

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />