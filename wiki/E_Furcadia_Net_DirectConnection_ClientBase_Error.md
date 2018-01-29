# ClientBase.Error Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This is triggered when a handled Exception is thrown.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event ClientBase.ErrorEventHandler Error
```

**VB**<br />
``` VB
Public Event Error As ClientBase.ErrorEventHandler
```

**VB Usage**<br />
``` VB Usage
Dim instance As ClientBase
Dim handler As ClientBase.ErrorEventHandler

AddHandler instance.Error, handler

```

**C++**<br />
``` C++
public:
 event ClientBase.ErrorEventHandler^ Error {
	void add (ClientBase.ErrorEventHandler^ value);
	void remove (ClientBase.ErrorEventHandler^ value);
}
```

**F#**<br />
``` F#
member Error : IEvent<ClientBase.ErrorEventHandler,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_DirectConnection_ClientBase_ErrorEventHandler">Furcadia.Net.DirectConnection.ClientBase.ErrorEventHandler</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase Class</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />