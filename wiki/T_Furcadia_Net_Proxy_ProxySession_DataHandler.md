# ProxySession.DataHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Send Data to Furcadia Client or Game Server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void DataHandler(
	string Message,
	EventArgs e
)
```

**VB**<br />
``` VB
Public Delegate Sub DataHandler ( 
	Message As String,
	e As EventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New DataHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void DataHandler(
	String^ Message, 
	EventArgs^ e
)
```

**F#**<br />
``` F#
type DataHandler = 
    delegate of 
        Message : string * 
        e : EventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>Message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Raw instruction to send</dd><dt>e</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br />Client or Server Event Arguments with Instruction type</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />