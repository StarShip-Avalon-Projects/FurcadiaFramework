# NetProxy.ServerData2 Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This is triggered when the Server sends data to the client. Doesn't expect a return value.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual event NetProxy.DataEventHandler2 ServerData2
```

**VB**<br />
``` VB
Public Overridable Event ServerData2 As NetProxy.DataEventHandler2
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim handler As NetProxy.DataEventHandler2

AddHandler instance.ServerData2, handler

```

**C++**<br />
``` C++
public:
virtual  event NetProxy.DataEventHandler2^ ServerData2 {
	void add (NetProxy.DataEventHandler2^ value);
	void remove (NetProxy.DataEventHandler2^ value);
}
```

**F#**<br />
``` F#
abstract ServerData2 : IEvent<NetProxy.DataEventHandler2,
    EventArgs>
override ServerData2 : IEvent<NetProxy.DataEventHandler2,
    EventArgs>
```


#### Value
Type: <a href="T_Furcadia_Net_NetProxy_DataEventHandler2">Furcadia.Net.NetProxy.DataEventHandler2</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />