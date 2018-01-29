# NetClientEventArgs.ConnectPhase Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Status of the Furcadia Client Connection

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ConnectionPhase ConnectPhase { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ConnectPhase As ConnectionPhase
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetClientEventArgs
Dim value As ConnectionPhase

value = instance.ConnectPhase

```

**C++**<br />
``` C++
public:
property ConnectionPhase ConnectPhase {
	ConnectionPhase get ();
}
```

**F#**<br />
``` F#
member ConnectPhase : ConnectionPhase with get

```


#### Property Value
Type: <a href="T_Furcadia_Net_ConnectionPhase">ConnectionPhase</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetClientEventArgs">NetClientEventArgs Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />