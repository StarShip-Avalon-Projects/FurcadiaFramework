# NetProxy.CurrentConnectionAttempt Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets the current connection attempt.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public int CurrentConnectionAttempt { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property CurrentConnectionAttempt As Integer
	Get
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim value As Integer

value = instance.CurrentConnectionAttempt

```

**C++**<br />
``` C++
public:
property int CurrentConnectionAttempt {
	int get ();
}
```

**F#**<br />
``` F#
member CurrentConnectionAttempt : int with get

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a><br />The current connection attempt.

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />