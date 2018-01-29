# CharacterFlags.HasFlag Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Does the triggering furre have flags set?

**Namespace:**&nbsp;<a href="N_Furcadia_Movement">Furcadia.Movement</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool HasFlag(
	int FlagToCheck
)
```

**VB**<br />
``` VB
Public Function HasFlag ( 
	FlagToCheck As Integer
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As CharacterFlags
Dim FlagToCheck As Integer
Dim returnValue As Boolean

returnValue = instance.HasFlag(FlagToCheck)
```

**C++**<br />
``` C++
public:
bool HasFlag(
	int FlagToCheck
)
```

**F#**<br />
``` F#
member HasFlag : 
        FlagToCheck : int -> bool 

```


#### Parameters
&nbsp;<dl><dt>FlagToCheck</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Any one of the CHAR_FLAG_ set</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />true if the flag is set

## See Also


#### Reference
<a href="T_Furcadia_Movement_CharacterFlags">CharacterFlags Class</a><br /><a href="N_Furcadia_Movement">Furcadia.Movement Namespace</a><br />