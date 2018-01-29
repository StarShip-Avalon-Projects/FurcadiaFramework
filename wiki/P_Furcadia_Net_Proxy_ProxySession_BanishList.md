# ProxySession.BanishList Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets the banish list.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public List<string> BanishList { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property BanishList As List(Of String)
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim value As List(Of String)

value = instance.BanishList

```

**C++**<br />
``` C++
public:
property List<String^>^ BanishList {
	List<String^>^ get ();
}
```

**F#**<br />
``` F#
member BanishList : List<string> with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/6sh2ey19" target="_blank">List</a>(<a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>)<br />The banish list.

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />