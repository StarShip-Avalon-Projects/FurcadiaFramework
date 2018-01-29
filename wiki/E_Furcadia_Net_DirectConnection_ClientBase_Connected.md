# ClientBase.Connected Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This is triggered when the

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ClientBase.ActionDelegate Connected
```

**VB**<br />
``` VB
Public Event Connected As ClientBase.ActionDelegate
```

**VB Usage**<br />
``` VB Usage
Dim instance As ClientBase
Dim handler As ClientBase.ActionDelegate

AddHandler instance.Connected, handler

```

**C++**<br />
``` C++
public:
 event ClientBase.ActionDelegate^ Connected {
	void add (ClientBase.ActionDelegate^ value);
	void remove (ClientBase.ActionDelegate^ value);
}
```

**F#**<br />
``` F#
member Connected : IEvent<ClientBase.ActionDelegate,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_DirectConnection_ClientBase_ActionDelegate">Furcadia.Net.DirectConnection.ClientBase.ActionDelegate</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase Class</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />