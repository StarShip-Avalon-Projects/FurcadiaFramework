# FurreList.ToIList Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Convert Furre List to <a href="http://msdn2.microsoft.com/en-us/library/30ft6hw7" target="_blank">IList</a>

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public IList<Furre> ToIList { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ToIList As IList(Of Furre)
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As FurreList
Dim value As IList(Of Furre)

value = instance.ToIList

```

**C++**<br />
``` C++
public:
property IList<Furre^>^ ToIList {
	IList<Furre^>^ get ();
}
```

**F#**<br />
``` F#
member ToIList : IList<Furre> with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">IList</a>(<a href="T_Furcadia_Net_DreamInfo_Furre">Furre</a>)

## See Also


#### Reference
<a href="T_Furcadia_Net_DreamInfo_FurreList">FurreList Class</a><br /><a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />