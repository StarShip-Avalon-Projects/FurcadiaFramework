# ProxySession.ProcessChannel Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Proxy.ProxySession.ProcessChannel"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ProcessChannel(
	Object sender,
	ParseChannelArgs Args
)
```

**VB**<br />
``` VB
Public Delegate Sub ProcessChannel ( 
	sender As Object,
	Args As ParseChannelArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ProcessChannel(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ProcessChannel(
	Object^ sender, 
	ParseChannelArgs^ Args
)
```

**F#**<br />
``` F#
type ProcessChannel = 
    delegate of 
        sender : Object * 
        Args : ParseChannelArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />ChannelObject</dd><dt>Args</dt><dd>Type: <a href="T_Furcadia_Net_ParseChannelArgs">Furcadia.Net.ParseChannelArgs</a><br /></dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />