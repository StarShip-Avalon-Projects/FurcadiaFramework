# Map.LoadFrom Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Loads a map from a file

**Namespace:**&nbsp;<a href="N_Furcadia_FurcMap">Furcadia.FurcMap</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static Map LoadFrom(
	string filename
)
```

**VB**<br />
``` VB
Public Shared Function LoadFrom ( 
	filename As String
) As Map
```

**VB Usage**<br />
``` VB Usage
Dim filename As String
Dim returnValue As Map

returnValue = Map.LoadFrom(filename)
```

**C++**<br />
``` C++
public:
static Map^ LoadFrom(
	String^ filename
)
```

**F#**<br />
``` F#
static member LoadFrom : 
        filename : string -> Map 

```


#### Parameters
&nbsp;<dl><dt>filename</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The file to load the map from</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_FurcMap_Map">Map</a><br />The map

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/ms143418" target="_blank">InvalidDataException</a></td><td>Thrown if the width and height of the map is not known (corrupt file)</td></tr></table>

## See Also


#### Reference
<a href="T_Furcadia_FurcMap_Map">Map Class</a><br /><a href="N_Furcadia_FurcMap">Furcadia.FurcMap Namespace</a><br />