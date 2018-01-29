# ServerQue.SendServerEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Event Handler to notify calling class data has been sent to the game server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void SendServerEventHandler(
	string message,
	EventArgs args
)
```

**VB**<br />
``` VB
Public Delegate Sub SendServerEventHandler ( 
	message As String,
	args As EventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New SendServerEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void SendServerEventHandler(
	String^ message, 
	EventArgs^ args
)
```

**F#**<br />
``` F#
type SendServerEventHandler = 
    delegate of 
        message : string * 
        args : EventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />raw client to server instruction</dd><dt>args</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br />System.EventArgs. (Unused)</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils Namespace</a><br />