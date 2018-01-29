# ClientBase.EndPoint Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Game Server IP/Port

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public IPEndPoint EndPoint { get; set; }
```

**VB**<br />
``` VB
Public Property EndPoint As IPEndPoint
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ClientBase
Dim value As IPEndPoint

value = instance.EndPoint

instance.EndPoint = value
```

**C++**<br />
``` C++
public:
property IPEndPoint^ EndPoint {
	IPEndPoint^ get ();
	void set (IPEndPoint^ value);
}
```

**F#**<br />
``` F#
member EndPoint : IPEndPoint with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/fzszfbba" target="_blank">IPEndPoint</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase Class</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />