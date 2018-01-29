# NetClientEventArgs Constructor (ConnectionPhase, String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Constructor

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public NetClientEventArgs(
	ConnectionPhase phase,
	string clientdata = null
)
```

**VB**<br />
``` VB
Public Sub New ( 
	phase As ConnectionPhase,
	Optional clientdata As String = Nothing
)
```

**VB Usage**<br />
``` VB Usage
Dim phase As ConnectionPhase
Dim clientdata As String

Dim instance As New NetClientEventArgs(phase, clientdata)
```

**C++**<br />
``` C++
public:
NetClientEventArgs(
	ConnectionPhase phase, 
	String^ clientdata = nullptr
)
```

**F#**<br />
``` F#
new : 
        phase : ConnectionPhase * 
        ?clientdata : string 
(* Defaults:
        let _clientdata = defaultArg clientdata null
*)
-> NetClientEventArgs
```


#### Parameters
&nbsp;<dl><dt>phase</dt><dd>Type: <a href="T_Furcadia_Net_ConnectionPhase">Furcadia.Net.ConnectionPhase</a><br />Connection Phase</dd><dt>clientdata (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Optional Message</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetClientEventArgs">NetClientEventArgs Class</a><br /><a href="Overload_Furcadia_Net_NetClientEventArgs__ctor">NetClientEventArgs Overload</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />