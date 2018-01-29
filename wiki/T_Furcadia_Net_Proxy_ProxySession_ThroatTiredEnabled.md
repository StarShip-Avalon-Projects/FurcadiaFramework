# ProxySession.ThroatTiredEnabled Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Throat Tired even handler

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ThroatTiredEnabled(
	bool enable
)
```

**VB**<br />
``` VB
Public Delegate Sub ThroatTiredEnabled ( 
	enable As Boolean
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ThroatTiredEnabled(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ThroatTiredEnabled(
	bool enable
)
```

**F#**<br />
``` F#
type ThroatTiredEnabled = 
    delegate of 
        enable : bool -> unit
```


#### Parameters
&nbsp;<dl><dt>enable</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />if set to `true` [enable].</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />