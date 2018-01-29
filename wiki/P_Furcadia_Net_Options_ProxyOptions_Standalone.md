# ProxyOptions.Standalone Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Allow the connection to stay open after the client drops?

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Options">Furcadia.Net.Options</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool Standalone { get; set; }
```

**VB**<br />
``` VB
Public Property Standalone As Boolean
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxyOptions
Dim value As Boolean

value = instance.Standalone

instance.Standalone = value
```

**C++**<br />
``` C++
public:
property bool Standalone {
	bool get ();
	void set (bool value);
}
```

**F#**<br />
``` F#
member Standalone : bool with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>

## Remarks
if standalone is enabled.. then we can skip, Furcadia Client Login with Firewall/Proxy settings and manage the client triggers ourselves

## See Also


#### Reference
<a href="T_Furcadia_Net_Options_ProxyOptions">ProxyOptions Class</a><br /><a href="N_Furcadia_Net_Options">Furcadia.Net.Options Namespace</a><br />