# PounceConnection.AddFriend Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Adds a friend to a list of friends. Throws a Exception on non alphanumeric string.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool AddFriend(
	string name
)
```

**VB**<br />
``` VB
Public Function AddFriend ( 
	name As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As PounceConnection
Dim name As String
Dim returnValue As Boolean

returnValue = instance.AddFriend(name)
```

**C++**<br />
``` C++
public:
bool AddFriend(
	String^ name
)
```

**F#**<br />
``` F#
member AddFriend : 
        name : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />A <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a></dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />A <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>. True if successfully added friend name. False if name already added.

## See Also


#### Reference
<a href="T_Furcadia_Net_Pounce_PounceConnection">PounceConnection Class</a><br /><a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />