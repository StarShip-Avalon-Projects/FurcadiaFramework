# Map.Save Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Save the map to a file

**Namespace:**&nbsp;<a href="N_Furcadia_FurcMap">Furcadia.FurcMap</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool Save(
	string filename,
	bool overwrite = true
)
```

**VB**<br />
``` VB
Public Function Save ( 
	filename As String,
	Optional overwrite As Boolean = true
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As Map
Dim filename As String
Dim overwrite As Boolean
Dim returnValue As Boolean

returnValue = instance.Save(filename, 
	overwrite)
```

**C++**<br />
``` C++
public:
bool Save(
	String^ filename, 
	bool overwrite = true
)
```

**F#**<br />
``` F#
member Save : 
        filename : string * 
        ?overwrite : bool 
(* Defaults:
        let _overwrite = defaultArg overwrite true
*)
-> bool 

```


#### Parameters
&nbsp;<dl><dt>filename</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The filename to save to</dd><dt>overwrite (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />If a file with that name already exist, should we overwrite it?</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True if the save was a success, False if not

## See Also


#### Reference
<a href="T_Furcadia_FurcMap_Map">Map Class</a><br /><a href="N_Furcadia_FurcMap">Furcadia.FurcMap Namespace</a><br />