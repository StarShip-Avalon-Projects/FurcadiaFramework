# Logger.Error Method (Object, String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Logging.Logger.Error(System.Object,System.String)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static void Error(
	Object msg,
	[CallerMemberNameAttribute] string memberName = ""
)
```

**VB**<br />
``` VB
Public Shared Sub Error ( 
	msg As Object,
	<CallerMemberNameAttribute> Optional memberName As String = ""
)
```

**VB Usage**<br />
``` VB Usage
Dim msg As Object
Dim memberName As StringLogger.Error(msg, memberName)
```

**C++**<br />
``` C++
public:
static void Error(
	Object^ msg, 
	[CallerMemberNameAttribute] String^ memberName = L""
)
```

**F#**<br />
``` F#
static member Error : 
        msg : Object * 
        [<CallerMemberNameAttribute>] ?memberName : string 
(* Defaults:
        let _memberName = defaultArg memberName ""
*)
-> unit 

```


#### Parameters
&nbsp;<dl><dt>msg</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="msg"/> documentation for "M:Furcadia.Logging.Logger.Error(System.Object,System.String)"\]</dd><dt>memberName (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="memberName"/> documentation for "M:Furcadia.Logging.Logger.Error(System.Object,System.String)"\]</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="Overload_Furcadia_Logging_Logger_Error">Error Overload</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />