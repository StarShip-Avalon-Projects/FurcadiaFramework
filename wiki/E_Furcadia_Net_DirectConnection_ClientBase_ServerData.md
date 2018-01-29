# ClientBase.ServerData Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This is triggered when the Server sends data to the client. Doesn't expect a return value.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ClientBase.DataEventHandler2 ServerData
```

**VB**<br />
``` VB
Public Event ServerData As ClientBase.DataEventHandler2
```

**VB Usage**<br />
``` VB Usage
Dim instance As ClientBase
Dim handler As ClientBase.DataEventHandler2

AddHandler instance.ServerData, handler

```

**C++**<br />
``` C++
public:
 event ClientBase.DataEventHandler2^ ServerData {
	void add (ClientBase.DataEventHandler2^ value);
	void remove (ClientBase.DataEventHandler2^ value);
}
```

**F#**<br />
``` F#
member ServerData : IEvent<ClientBase.DataEventHandler2,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_DirectConnection_ClientBase_DataEventHandler2">Furcadia.Net.DirectConnection.ClientBase.DataEventHandler2</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase Class</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />