# Dream.Equality Operator 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Implements the operator ==.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool operator ==(
	Dream dreamA,
	IDream dreamB
)
```

**VB**<br />
``` VB
Public Shared Operator = ( 
	dreamA As Dream,
	dreamB As IDream
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim dreamA As Dream
Dim dreamB As IDream
Dim returnValue As Boolean

returnValue = (dreamA = dreamB)
```

**C++**<br />
``` C++
public:
static bool operator ==(
	Dream^ dreamA, 
	IDream^ dreamB
)
```

**F#**<br />
``` F#
static let inline (=)
        dreamA : Dream * 
        dreamB : IDream  : bool
```


#### Parameters
&nbsp;<dl><dt>dreamA</dt><dd>Type: <a href="T_Furcadia_Net_DreamInfo_Dream">Furcadia.Net.DreamInfo.Dream</a><br />The dream a.</dd><dt>dreamB</dt><dd>Type: <a href="T_Furcadia_Net_DreamInfo_IDream">Furcadia.Net.DreamInfo.IDream</a><br />The dream b.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />The result of the operator.

## See Also


#### Reference
<a href="T_Furcadia_Net_DreamInfo_Dream">Dream Class</a><br /><a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />