# NetServerEventArgs Constructor (ConnectionPhase, ServerInstructionType)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Game Server Status Event Arguments

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public NetServerEventArgs(
	ConnectionPhase phase,
	ServerInstructionType Instruction
)
```

**VB**<br />
``` VB
Public Sub New ( 
	phase As ConnectionPhase,
	Instruction As ServerInstructionType
)
```

**VB Usage**<br />
``` VB Usage
Dim phase As ConnectionPhase
Dim Instruction As ServerInstructionType

Dim instance As New NetServerEventArgs(phase, Instruction)
```

**C++**<br />
``` C++
public:
NetServerEventArgs(
	ConnectionPhase phase, 
	ServerInstructionType Instruction
)
```

**F#**<br />
``` F#
new : 
        phase : ConnectionPhase * 
        Instruction : ServerInstructionType -> NetServerEventArgs
```


#### Parameters
&nbsp;<dl><dt>phase</dt><dd>Type: <a href="T_Furcadia_Net_ConnectionPhase">Furcadia.Net.ConnectionPhase</a><br />Server <a href="T_Furcadia_Net_ConnectionPhase">ConnectionPhase</a></dd><dt>Instruction</dt><dd>Type: <a href="T_Furcadia_Net_ServerInstructionType">Furcadia.Net.ServerInstructionType</a><br />Game <a href="T_Furcadia_Net_ServerInstructionType">ServerInstructionType</a> to client</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetServerEventArgs">NetServerEventArgs Class</a><br /><a href="Overload_Furcadia_Net_NetServerEventArgs__ctor">NetServerEventArgs Overload</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />