# NetProxy.Error Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This is triggered when a handled Exception is thrown.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event NetProxy.ErrorEventHandler Error
```

**VB**<br />
``` VB
Public Event Error As NetProxy.ErrorEventHandler
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim handler As NetProxy.ErrorEventHandler

AddHandler instance.Error, handler

```

**C++**<br />
``` C++
public:
 event NetProxy.ErrorEventHandler^ Error {
	void add (NetProxy.ErrorEventHandler^ value);
	void remove (NetProxy.ErrorEventHandler^ value);
}
```

**F#**<br />
``` F#
member Error : IEvent<NetProxy.ErrorEventHandler,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_NetProxy_ErrorEventHandler">Furcadia.Net.NetProxy.ErrorEventHandler</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />