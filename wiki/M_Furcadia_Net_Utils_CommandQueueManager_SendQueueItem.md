# CommandQueueManager.SendQueueItem Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Incoming Messages for server processing

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public virtual void SendQueueItem(
	string data
)
```

**VB**<br />
``` VB
Public Overridable Sub SendQueueItem ( 
	data As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As CommandQueueManager
Dim data As String

instance.SendQueueItem(data)
```

**C++**<br />
``` C++
public:
virtual void SendQueueItem(
	String^ data
)
```

**F#**<br />
``` F#
abstract SendQueueItem : 
        data : string -> unit 
override SendQueueItem : 
        data : string -> unit 
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Raw Client to Server Instruction.</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Utils_CommandQueueManager">CommandQueueManager Class</a><br /><a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils Namespace</a><br />