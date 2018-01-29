# NetProxy.ClientExited Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Occurs when the furcadia client exits.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
protected event EventHandler ClientExited
```

**VB**<br />
``` VB
Protected Event ClientExited As EventHandler
```

**VB Usage**<br />
``` VB Usage
Dim handler As EventHandler

AddHandler Me.ClientExited, handler

```

**C++**<br />
``` C++
protected:
 event EventHandler^ ClientExited {
	void add (EventHandler^ value);
	void remove (EventHandler^ value);
}
```

**F#**<br />
``` F#
member ClientExited : IEvent<EventHandler,
    EventArgs>

```


#### Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/xhb70ccc" target="_blank">System.EventHandler</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />