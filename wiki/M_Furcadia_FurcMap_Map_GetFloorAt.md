# Map.GetFloorAt Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Get the floor number from a tile

**Namespace:**&nbsp;<a href="N_Furcadia_FurcMap">Furcadia.FurcMap</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public int GetFloorAt(
	int x,
	int y
)
```

**VB**<br />
``` VB
Public Function GetFloorAt ( 
	x As Integer,
	y As Integer
) As Integer
```

**VB Usage**<br />
``` VB Usage
Dim instance As Map
Dim x As Integer
Dim y As Integer
Dim returnValue As Integer

returnValue = instance.GetFloorAt(x, y)
```

**C++**<br />
``` C++
public:
int GetFloorAt(
	int x, 
	int y
)
```

**F#**<br />
``` F#
member GetFloorAt : 
        x : int * 
        y : int -> int 

```


#### Parameters
&nbsp;<dl><dt>x</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />x coordinate</dd><dt>y</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Y coordinate</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a><br />The floor number

## See Also


#### Reference
<a href="T_Furcadia_FurcMap_Map">Map Class</a><br /><a href="N_Furcadia_FurcMap">Furcadia.FurcMap Namespace</a><br />