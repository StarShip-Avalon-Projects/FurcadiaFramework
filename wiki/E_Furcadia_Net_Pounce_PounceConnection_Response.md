# PounceConnection.Response Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Called when a on-line check request sends a response. First argument is a list of players on-line.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public event PounceConnection.PounceResponse Response
```

**VB**<br />
``` VB
Public Event Response As PounceConnection.PounceResponse
```

**VB Usage**<br />
``` VB Usage
Dim instance As PounceConnection
Dim handler As PounceConnection.PounceResponse

AddHandler instance.Response, handler

```

**C++**<br />
``` C++
public:
 event PounceConnection.PounceResponse^ Response {
	void add (PounceConnection.PounceResponse^ value);
	void remove (PounceConnection.PounceResponse^ value);
}
```

**F#**<br />
``` F#
member Response : IEvent<PounceConnection.PounceResponse,
    EventArgs>

```


#### Value
Type: <a href="T_Furcadia_Net_Pounce_PounceConnection_PounceResponse">Furcadia.Net.Pounce.PounceConnection.PounceResponse</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Pounce_PounceConnection">PounceConnection Class</a><br /><a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />