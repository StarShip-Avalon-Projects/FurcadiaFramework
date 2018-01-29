# ParseServerArgs Constructor (ServerInstructionType, ConnectionPhase)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Constructor setting the current Server to Client Instruction type

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ParseServerArgs(
	ServerInstructionType ServerInstruction,
	ConnectionPhase phase
)
```

**VB**<br />
``` VB
Public Sub New ( 
	ServerInstruction As ServerInstructionType,
	phase As ConnectionPhase
)
```

**VB Usage**<br />
``` VB Usage
Dim ServerInstruction As ServerInstructionType
Dim phase As ConnectionPhase

Dim instance As New ParseServerArgs(ServerInstruction, 
	phase)
```

**C++**<br />
``` C++
public:
ParseServerArgs(
	ServerInstructionType ServerInstruction, 
	ConnectionPhase phase
)
```

**F#**<br />
``` F#
new : 
        ServerInstruction : ServerInstructionType * 
        phase : ConnectionPhase -> ParseServerArgs
```


#### Parameters
&nbsp;<dl><dt>ServerInstruction</dt><dd>Type: <a href="T_Furcadia_Net_ServerInstructionType">Furcadia.Net.ServerInstructionType</a><br />Current Execuring <a href="T_Furcadia_Net_ServerInstructionType">ServerInstructionType</a></dd><dt>phase</dt><dd>Type: <a href="T_Furcadia_Net_ConnectionPhase">Furcadia.Net.ConnectionPhase</a><br /></dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs Class</a><br /><a href="Overload_Furcadia_Net_ParseServerArgs__ctor">ParseServerArgs Overload</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />