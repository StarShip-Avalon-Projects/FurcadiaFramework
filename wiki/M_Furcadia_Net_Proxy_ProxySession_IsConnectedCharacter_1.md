# ProxySession.IsConnectedCharacter Method (Furre)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Is the target furre the connected characyer?

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public bool IsConnectedCharacter(
	Furre Fur
)
```

**VB**<br />
``` VB
Public Function IsConnectedCharacter ( 
	Fur As Furre
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim Fur As Furre
Dim returnValue As Boolean

returnValue = instance.IsConnectedCharacter(Fur)
```

**C++**<br />
``` C++
public:
bool IsConnectedCharacter(
	Furre^ Fur
)
```

**F#**<br />
``` F#
member IsConnectedCharacter : 
        Fur : Furre -> bool 

```


#### Parameters
&nbsp;<dl><dt>Fur</dt><dd>Type: <a href="T_Furcadia_Net_DreamInfo_Furre">Furcadia.Net.DreamInfo.Furre</a><br /><a href="T_Furcadia_Net_DreamInfo_Furre">Furre</a></dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True if Fur is the Connected Furre

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="Overload_Furcadia_Net_Proxy_ProxySession_IsConnectedCharacter">IsConnectedCharacter Overload</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />