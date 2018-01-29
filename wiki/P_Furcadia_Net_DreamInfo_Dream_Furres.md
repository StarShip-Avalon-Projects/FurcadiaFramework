# Dream.Furres Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Dream List Furcadia requires Clients to handle thier own Dream Lists See 
http://dev.furcadia.com/docs New Movement for Spawn and Remove packets

**Spawn is out dated. New information requires a 4byte for AFK flag at the end

As of V31, Color code has changed.


**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public FurreList Furres { get; set; }
```

**VB**<br />
``` VB
Public Property Furres As FurreList
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As Dream
Dim value As FurreList

value = instance.Furres

instance.Furres = value
```

**C++**<br />
``` C++
public:
property FurreList^ Furres {
	FurreList^ get ();
	void set (FurreList^ value);
}
```

**F#**<br />
``` F#
member Furres : FurreList with get, set

```


#### Property Value
Type: <a href="T_Furcadia_Net_DreamInfo_FurreList">FurreList</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_DreamInfo_Dream">Dream Class</a><br /><a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />