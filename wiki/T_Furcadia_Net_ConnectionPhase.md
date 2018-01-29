# ConnectionPhase Enumeration
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Connection Status

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[CLSCompliantAttribute(true)]
public enum ConnectionPhase
```

**VB**<br />
``` VB
<CLSCompliantAttribute(true)>
Public Enumeration ConnectionPhase
```

**VB Usage**<br />
``` VB Usage
Dim instance As ConnectionPhase
```

**C++**<br />
``` C++
[CLSCompliantAttribute(true)]
public enum class ConnectionPhase
```

**F#**<br />
``` F#
[<CLSCompliantAttribute(true)>]
type ConnectionPhase
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.error">**error**</td><td>-1</td><td>Default Error 
Halt Game Server and Client Connection Procedure</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.Init">**Init**</td><td>0</td><td>Initialize Connection</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.Connecting">**Connecting**</td><td>1</td><td>Connection started</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.MOTD">**MOTD**</td><td>2</td><td>Message of the Day 
IE: Good Morning Dave...</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.Auth">**Auth**</td><td>3</td><td>Login Account,Password, Character Name</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.Connected">**Connected**</td><td>4</td><td>Connection established</td></tr><tr><td /><td target="F:Furcadia.Net.ConnectionPhase.Disconnected">**Disconnected**</td><td>5</td><td>Connection lost</td></tr></table>

## Remarks
Credit to Artex for his open source projects use this method 
Reference http://dev.furcadia.com/docs/027_movement.html


## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />