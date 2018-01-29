# Utilities.PortOpen Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Checks TCP port and scans for an available TCP port on the host system

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool PortOpen(
	int port
)
```

**VB**<br />
``` VB
Public Shared Function PortOpen ( 
	port As Integer
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim port As Integer
Dim returnValue As Boolean

returnValue = Utilities.PortOpen(port)
```

**C++**<br />
``` C++
public:
static bool PortOpen(
	int port
)
```

**F#**<br />
``` F#
static member PortOpen : 
        port : int -> bool 

```


#### Parameters
&nbsp;<dl><dt>port</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />ref TCP Port</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True when a port is found available

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/3w1b3114" target="_blank">ArgumentException</a></td><td>Thrown when *port* is 0</td></tr></table>

## See Also


#### Reference
<a href="T_Furcadia_Net_Utils_Utilities">Utilities Class</a><br /><a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils Namespace</a><br />