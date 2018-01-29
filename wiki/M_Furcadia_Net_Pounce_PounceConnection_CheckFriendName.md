# PounceConnection.CheckFriendName Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Checks a friend's name to make sure it is a valid alpha numeric (a-z0-9). 
Furcadia short-name format is lowercase alpha-numeric strings


**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool CheckFriendName(
	string shortNFriend
)
```

**VB**<br />
``` VB
Public Function CheckFriendName ( 
	shortNFriend As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As PounceConnection
Dim shortNFriend As String
Dim returnValue As Boolean

returnValue = instance.CheckFriendName(shortNFriend)
```

**C++**<br />
``` C++
public:
bool CheckFriendName(
	String^ shortNFriend
)
```

**F#**<br />
``` F#
member CheckFriendName : 
        shortNFriend : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>shortNFriend</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Name of Friend.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True: Friend name is fine. False otherwise.

## See Also


#### Reference
<a href="T_Furcadia_Net_Pounce_PounceConnection">PounceConnection Class</a><br /><a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />