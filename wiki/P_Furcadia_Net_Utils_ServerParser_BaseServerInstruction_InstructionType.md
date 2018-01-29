# BaseServerInstruction.InstructionType Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Which Server to Client Instruction are we?

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[CLSCompliantAttribute(false)]
public ServerInstructionType InstructionType { get; set; }
```

**VB**<br />
``` VB
<CLSCompliantAttribute(false)>
Public Property InstructionType As ServerInstructionType
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As BaseServerInstruction
Dim value As ServerInstructionType

value = instance.InstructionType

instance.InstructionType = value
```

**C++**<br />
``` C++
public:
[CLSCompliantAttribute(false)]
property ServerInstructionType InstructionType {
	ServerInstructionType get ();
	void set (ServerInstructionType value);
}
```

**F#**<br />
``` F#
[<CLSCompliantAttribute(false)>]
member InstructionType : ServerInstructionType with get, set

```


#### Property Value
Type: <a href="T_Furcadia_Net_ServerInstructionType">ServerInstructionType</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction Class</a><br /><a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser Namespace</a><br />