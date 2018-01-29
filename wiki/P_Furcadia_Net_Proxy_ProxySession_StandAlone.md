# ProxySession.StandAlone Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Allows the Furcadia Client to Disconnect from the session, allowing the session to remain connected to the game server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool StandAlone { get; set; }
```

**VB**<br />
``` VB
Public Property StandAlone As Boolean
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim value As Boolean

value = instance.StandAlone

instance.StandAlone = value
```

**C++**<br />
``` C++
public:
property bool StandAlone {
	bool get ();
	void set (bool value);
}
```

**F#**<br />
``` F#
member StandAlone : bool with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />