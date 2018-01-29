# FurreList.Item Property (Furre)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or set the Furre at index of fur

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public Furre this[
	Furre fur
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	fur As Furre
) As Furre
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As FurreList
Dim fur As Furre
Dim value As Furre

value = instance(fur)

instance(fur) = value
```

**C++**<br />
``` C++
public:
property Furre^ default[Furre^ fur] {
	Furre^ get (Furre^ fur);
	void set (Furre^ fur, Furre^ value);
}
```

**F#**<br />
``` F#
member Item : Furre with get, set

```


#### Parameters
&nbsp;<dl><dt>fur</dt><dd>Type: <a href="T_Furcadia_Net_DreamInfo_Furre">Furcadia.Net.DreamInfo.Furre</a><br />Furre</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_Net_DreamInfo_Furre">Furre</a><br />

## See Also


#### Reference
<a href="T_Furcadia_Net_DreamInfo_FurreList">FurreList Class</a><br /><a href="Overload_Furcadia_Net_DreamInfo_FurreList_Item">Item Overload</a><br /><a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />