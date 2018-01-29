# Logger.SpamFound Event
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "E:Furcadia.Logging.Logger.SpamFound"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static event Action<LogMessage> SpamFound
```

**VB**<br />
``` VB
Public Shared Event SpamFound As Action(Of LogMessage)
```

**VB Usage**<br />
``` VB Usage
Dim handler As Action(Of LogMessage)

AddHandler Logger.SpamFound, handler

```

**C++**<br />
``` C++
public:
static  event Action<LogMessage>^ SpamFound {
	void add (Action<LogMessage>^ value);
	void remove (Action<LogMessage>^ value);
}
```

**F#**<br />
``` F#
member SpamFound : IEvent<Action<LogMessage>,
    EventArgs>

```


#### Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/018hxwa8" target="_blank">System.Action</a>(<a href="T_Furcadia_Logging_LogMessage">LogMessage</a>)

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />