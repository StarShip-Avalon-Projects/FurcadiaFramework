# PounceConnection Constructor (String, String[], String[])
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

A HTTP web request

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public PounceConnection(
	string url,
	string[] shortN_friends,
	string[] Dreams
)
```

**VB**<br />
``` VB
Public Sub New ( 
	url As String,
	shortN_friends As String(),
	Dreams As String()
)
```

**VB Usage**<br />
``` VB Usage
Dim url As String
Dim shortN_friends As String()
Dim Dreams As String()

Dim instance As New PounceConnection(url, shortN_friends, 
	Dreams)
```

**C++**<br />
``` C++
public:
PounceConnection(
	String^ url, 
	array<String^>^ shortN_friends, 
	array<String^>^ Dreams
)
```

**F#**<br />
``` F#
new : 
        url : string * 
        shortN_friends : string[] * 
        Dreams : string[] -> PounceConnection
```


#### Parameters
&nbsp;<dl><dt>url</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Url (i.e http://on.furcadia.com) or if you have a custom on-line check server use that instead</dd><dt>shortN_friends</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />Friends (shortname) (i.e emeraldflame instead of Emerald|Flame)</dd><dt>Dreams</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />String Array of Dreams</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Pounce_PounceConnection">PounceConnection Class</a><br /><a href="Overload_Furcadia_Net_Pounce_PounceConnection__ctor">PounceConnection Overload</a><br /><a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />