# NetProxy.Options Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets the options.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual ProxyOptions Options { get; set; }
```

**VB**<br />
``` VB
Public Overridable Property Options As ProxyOptions
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
Dim value As ProxyOptions

value = instance.Options

instance.Options = value
```

**C++**<br />
``` C++
public:
virtual property ProxyOptions^ Options {
	ProxyOptions^ get ();
	void set (ProxyOptions^ value);
}
```

**F#**<br />
``` F#
abstract Options : ProxyOptions with get, set
override Options : ProxyOptions with get, set
```


#### Property Value
Type: <a href="T_Furcadia_Net_Options_ProxyOptions">ProxyOptions</a><br />The options.

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />