# NetProxy.ServerConnected Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "E:Furcadia.Net.NetProxy.ServerConnected"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
protected event NetProxy.ActionDelegate ServerConnected
```

**VB**<br />
``` VB
Protected Event ServerConnected As NetProxy.ActionDelegate
```

**VB Usage**<br />
``` VB Usage
Dim handler As NetProxy.ActionDelegate

AddHandler Me.ServerConnected, handler

```

**C++**<br />
``` C++
protected:
 event NetProxy.ActionDelegate^ ServerConnected {
	void add (NetProxy.ActionDelegate^ value);
	void remove (NetProxy.ActionDelegate^ value);
}
```

**F#**<br />
``` F#
member ServerConnected : IEvent<NetProxy.ActionDelegate,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_NetProxy_ActionDelegate">Furcadia.Net.NetProxy.ActionDelegate</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />