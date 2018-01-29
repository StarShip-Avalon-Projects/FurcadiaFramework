# DreamBookmark.Name Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets the name.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string Name { get; set; }
```

**VB**<br />
``` VB
Public Property Name As String
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As DreamBookmark
Dim value As String

value = instance.Name

instance.Name = value
```

**C++**<br />
``` C++
public:
virtual property String^ Name {
	String^ get () sealed;
	void set (String^ value) sealed;
}
```

**F#**<br />
``` F#
abstract Name : string with get, set
override Name : string with get, set
```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />The name.

#### Implements
<a href="P_Furcadia_Net_DreamInfo_IDream_Name">IDream.Name</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/6byb74h9" target="_blank">NotImplementedException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_Furcadia_Net_Utils_ServerParser_DreamBookmark">DreamBookmark Class</a><br /><a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser Namespace</a><br />