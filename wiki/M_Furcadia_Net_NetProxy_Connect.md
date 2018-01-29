# NetProxy.Connect Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Connects to the Furcadia Server and starts the mini proxy.

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual void Connect()
```

**VB**<br />
``` VB
Public Overridable Sub Connect
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy

instance.Connect()
```

**C++**<br />
``` C++
public:
virtual void Connect()
```

**F#**<br />
``` F#
abstract Connect : unit -> unit 
override Connect : unit -> unit 
```


## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_Furcadia_Net_NetProxyException">NetProxyException</a></td><td>Could not fine available localhost port or there is a problem with the Proxy server or Process path not found. or Client executable '" + options.FurcadiaProcess + "' not found.</td></tr></table>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />