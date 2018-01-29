# NetProxy.FurcadiaClientIsRunning Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets a value indicating whether [the Furcadia lient is a running process].

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool FurcadiaClientIsRunning { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property FurcadiaClientIsRunning As Boolean
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim value As Boolean

value = instance.FurcadiaClientIsRunning

```

**C++**<br />
``` C++
public:
property bool FurcadiaClientIsRunning {
	bool get ();
}
```

**F#**<br />
``` F#
member FurcadiaClientIsRunning : bool with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />`true` if [furcadia client is a running process]; otherwise, `false`.

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />