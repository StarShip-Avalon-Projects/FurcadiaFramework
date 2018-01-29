# Logger.LogOutput Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Sets the <a href="T_Furcadia_Logging_ILogOutput">ILogOutput</a>.

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static ILogOutput LogOutput { get; set; }
```

**VB**<br />
``` VB
Public Shared Property LogOutput As ILogOutput
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim value As ILogOutput

value = Logger.LogOutput

Logger.LogOutput = value
```

**C++**<br />
``` C++
public:
static property ILogOutput^ LogOutput {
	ILogOutput^ get ();
	void set (ILogOutput^ value);
}
```

**F#**<br />
``` F#
static member LogOutput : ILogOutput with get, set

```


#### Property Value
Type: <a href="T_Furcadia_Logging_ILogOutput">ILogOutput</a>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="http://msdn2.microsoft.com/en-us/library/27426hcy" target="_blank">ArgumentNullException</a></td><td>output</td></tr></table>

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />