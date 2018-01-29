# CommandQueueManager.QueueEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Event Handler to notify calling class data has been sent to the game server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void QueueEventHandler(
	Object sender,
	EventArgs args
)
```

**VB**<br />
``` VB
Public Delegate Sub QueueEventHandler ( 
	sender As Object,
	args As EventArgs
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New QueueEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void QueueEventHandler(
	Object^ sender, 
	EventArgs^ args
)
```

**F#**<br />
``` F#
type QueueEventHandler = 
    delegate of 
        sender : Object * 
        args : EventArgs -> unit
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />raw client to server instruction</dd><dt>args</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br />System.EventArgs. (Unused)</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils Namespace</a><br />