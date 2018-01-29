# ProxySession.OnErrorEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Proxy.ProxySession.OnErrorEventHandler"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void OnErrorEventHandler(
	Object sender,
	EventArgs e
)
```

**VB**<br />
``` VB
Public Delegate Sub OnErrorEventHandler ( 
	sender As Object,
	e As EventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New OnErrorEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void OnErrorEventHandler(
	Object^ sender, 
	EventArgs^ e
)
```

**F#**<br />
``` F#
type OnErrorEventHandler = 
    delegate of 
        sender : Object * 
        e : EventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br /></dd><dt>e</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br /></dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />