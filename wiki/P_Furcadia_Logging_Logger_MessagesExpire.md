# Logger.MessagesExpire Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets the messages expire time limit. Messages that have expired are removed from history. This property used in conjunction with SupressSpam = true prevents too much memory from being used over time

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static TimeSpan MessagesExpire { get; set; }
```

**VB**<br />
``` VB
Public Shared Property MessagesExpire As TimeSpan
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim value As TimeSpan

value = Logger.MessagesExpire

Logger.MessagesExpire = value
```

**C++**<br />
``` C++
public:
static property TimeSpan MessagesExpire {
	TimeSpan get ();
	void set (TimeSpan value);
}
```

**F#**<br />
``` F#
static member MessagesExpire : TimeSpan with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/269ew577" target="_blank">TimeSpan</a><br />The messages expire time limit.

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />