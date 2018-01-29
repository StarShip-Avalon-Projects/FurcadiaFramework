# LogMessage.From Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Logging.LogMessage.From(Furcadia.Logging.Level,System.String,System.TimeSpan)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static Nullable<LogMessage> From(
	Level level,
	string msg,
	TimeSpan expireDuration
)
```

**VB**<br />
``` VB
Public Shared Function From ( 
	level As Level,
	msg As String,
	expireDuration As TimeSpan
) As Nullable(Of LogMessage)
```

**VB Usage**<br />
``` VB Usage
Dim level As Level
Dim msg As String
Dim expireDuration As TimeSpan
Dim returnValue As Nullable(Of LogMessage)

returnValue = LogMessage.From(level, msg, 
	expireDuration)
```

**C++**<br />
``` C++
public:
static Nullable<LogMessage> From(
	Level level, 
	String^ msg, 
	TimeSpan expireDuration
)
```

**F#**<br />
``` F#
static member From : 
        level : Level * 
        msg : string * 
        expireDuration : TimeSpan -> Nullable<LogMessage> 

```


#### Parameters
&nbsp;<dl><dt>level</dt><dd>Type: <a href="T_Furcadia_Logging_Level">Furcadia.Logging.Level</a><br />\[Missing <param name="level"/> documentation for "M:Furcadia.Logging.LogMessage.From(Furcadia.Logging.Level,System.String,System.TimeSpan)"\]</dd><dt>msg</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="msg"/> documentation for "M:Furcadia.Logging.LogMessage.From(Furcadia.Logging.Level,System.String,System.TimeSpan)"\]</dd><dt>expireDuration</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/269ew577" target="_blank">System.TimeSpan</a><br />\[Missing <param name="expireDuration"/> documentation for "M:Furcadia.Logging.LogMessage.From(Furcadia.Logging.Level,System.String,System.TimeSpan)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/b3h38hb0" target="_blank">Nullable</a>(<a href="T_Furcadia_Logging_LogMessage">LogMessage</a>)<br />\[Missing <returns> documentation for "M:Furcadia.Logging.LogMessage.From(Furcadia.Logging.Level,System.String,System.TimeSpan)"\]

## See Also


#### Reference
<a href="T_Furcadia_Logging_LogMessage">LogMessage Structure</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />