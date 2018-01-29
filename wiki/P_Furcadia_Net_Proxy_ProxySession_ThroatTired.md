# ProxySession.ThroatTired Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

ServerQueue Throat Tired Mode 
When set, a <a href="http://msdn2.microsoft.com/en-us/library/saba8ksx" target="_blank">Timer</a> is created to make us wait till the time is clear to resume.


**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool ThroatTired { get; set; }
```

**VB**<br />
``` VB
Public Property ThroatTired As Boolean
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim value As Boolean

value = instance.ThroatTired

instance.ThroatTired = value
```

**C++**<br />
``` C++
public:
property bool ThroatTired {
	bool get ();
	void set (bool value);
}
```

**F#**<br />
``` F#
member ThroatTired : bool with get, set

```


#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />State <a href="P_Furcadia_Net_Utils_ServerQue_ThroatTired">ThroatTired</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />