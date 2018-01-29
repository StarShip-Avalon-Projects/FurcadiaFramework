# Logger.Assert(*T*) Method (Func(Boolean), String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "M:Furcadia.Logging.Logger.Assert``1(System.Func{System.Boolean},System.String)"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool Assert<T>(
	Func<bool> cond,
	string failMsg
)

```

**VB**<br />
``` VB
Public Shared Function Assert(Of T) ( 
	cond As Func(Of Boolean),
	failMsg As String
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim cond As Func(Of Boolean)
Dim failMsg As String
Dim returnValue As Boolean

returnValue = Logger.Assert(cond, failMsg)
```

**C++**<br />
``` C++
public:
generic<typename T>
static bool Assert(
	Func<bool>^ cond, 
	String^ failMsg
)
```

**F#**<br />
``` F#
static member Assert : 
        cond : Func<bool> * 
        failMsg : string -> bool 

```


#### Parameters
&nbsp;<dl><dt>cond</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/bb534960" target="_blank">System.Func</a>(<a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>)<br />\[Missing <param name="cond"/> documentation for "M:Furcadia.Logging.Logger.Assert``1(System.Func{System.Boolean},System.String)"\]</dd><dt>failMsg</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="failMsg"/> documentation for "M:Furcadia.Logging.Logger.Assert``1(System.Func{System.Boolean},System.String)"\]</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>\[Missing <typeparam name="T"/> documentation for "M:Furcadia.Logging.Logger.Assert``1(System.Func{System.Boolean},System.String)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />\[Missing <returns> documentation for "M:Furcadia.Logging.Logger.Assert``1(System.Func{System.Boolean},System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="Overload_Furcadia_Logging_Logger_Assert">Assert Overload</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />