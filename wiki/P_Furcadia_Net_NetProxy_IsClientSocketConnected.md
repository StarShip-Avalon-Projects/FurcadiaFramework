# NetProxy.IsClientSocketConnected Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets a value indicating whether this instance is client socket connected.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool IsClientSocketConnected { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property IsClientSocketConnected As Boolean
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim value As Boolean

value = instance.IsClientSocketConnected

```

**C++**<br />
``` C++
public:
property bool IsClientSocketConnected {
	bool get ();
}
```

**F#**<br />
``` F#
member IsClientSocketConnected : bool with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />`true` if this instance is client socket connected; otherwise, `false`.

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />