# ClientBase.SendServer Method (String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sends Data to the Game server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual void SendServer(
	string message
)
```

**VB**<br />
``` VB
Public Overridable Sub SendServer ( 
	message As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As ClientBase
Dim message As String

instance.SendServer(message)
```

**C++**<br />
``` C++
public:
virtual void SendServer(
	String^ message
)
```

**F#**<br />
``` F#
abstract SendServer : 
        message : string -> unit 
override SendServer : 
        message : string -> unit 
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />string to send to game server</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase Class</a><br /><a href="Overload_Furcadia_Net_DirectConnection_ClientBase_SendServer">SendServer Overload</a><br /><a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />