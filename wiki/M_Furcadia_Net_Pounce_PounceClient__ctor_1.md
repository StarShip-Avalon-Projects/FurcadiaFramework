# PounceClient Constructor (String[], String[])
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Set up the default Pounce Client and Friends List and Dream List 
Pounce server updates on a 30 second cron-job and returns a list of Furres Currently on-line


**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public PounceClient(
	string[] FurreList,
	string[] DreamList
)
```

**VB**<br />
``` VB
Public Sub New ( 
	FurreList As String(),
	DreamList As String()
)
```

**VB Usage**<br />
``` VB Usage
Dim FurreList As String()
Dim DreamList As String()

Dim instance As New PounceClient(FurreList, 
	DreamList)
```

**C++**<br />
``` C++
public:
PounceClient(
	array<String^>^ FurreList, 
	array<String^>^ DreamList
)
```

**F#**<br />
``` F#
new : 
        FurreList : string[] * 
        DreamList : string[] -> PounceClient
```


#### Parameters
&nbsp;<dl><dt>FurreList</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />Furre List as string array</dd><dt>DreamList</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />dream list as s string array</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Pounce_PounceClient">PounceClient Class</a><br /><a href="Overload_Furcadia_Net_Pounce_PounceClient__ctor">PounceClient Overload</a><br /><a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />