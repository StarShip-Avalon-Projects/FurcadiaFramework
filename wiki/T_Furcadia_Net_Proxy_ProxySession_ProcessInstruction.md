# ProxySession.ProcessInstruction Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Send Server to Client Instruction object to Sub-classed for handling.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ProcessInstruction(
	Object sender,
	ParseServerArgs Args
)
```

**VB**<br />
``` VB
Public Delegate Sub ProcessInstruction ( 
	sender As Object,
	Args As ParseServerArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ProcessInstruction(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ProcessInstruction(
	Object^ sender, 
	ParseServerArgs^ Args
)
```

**F#**<br />
``` F#
type ProcessInstruction = 
    delegate of 
        sender : Object * 
        Args : ParseServerArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Server Instruction Object</dd><dt>Args</dt><dd>Type: <a href="T_Furcadia_Net_ParseServerArgs">Furcadia.Net.ParseServerArgs</a><br /></dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />