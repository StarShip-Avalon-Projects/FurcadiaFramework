# FurreList.Item Property (Int32)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "P:Furcadia.Net.DreamInfo.FurreList.Item(System.Int32)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public Furre this[
	int index
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	index As Integer
) As Furre
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As FurreList
Dim index As Integer
Dim value As Furre

value = instance(index)

instance(index) = value
```

**C++**<br />
``` C++
public:
virtual property Furre^ default[int index] {
	Furre^ get (int index) sealed;
	void set (int index, Furre^ value) sealed;
}
```

**F#**<br />
``` F#
abstract Item : Furre with get, set
override Item : Furre with get, set
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br /></dd></dl>

#### Return Value
Type: <a href="T_Furcadia_Net_DreamInfo_Furre">Furre</a><br />

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/ewthkb10" target="_blank">IList(T).Item(Int32)</a><br />

## See Also


#### Reference
<a href="T_Furcadia_Net_DreamInfo_FurreList">FurreList Class</a><br /><a href="Overload_Furcadia_Net_DreamInfo_FurreList_Item">Item Overload</a><br /><a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />