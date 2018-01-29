# Logger.SingleThreaded Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets a value indicating whether [single threaded].

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static bool SingleThreaded { get; set; }
```

**VB**<br />
``` VB
Public Shared Property SingleThreaded As Boolean
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim value As Boolean

value = Logger.SingleThreaded

Logger.SingleThreaded = value
```

**C++**<br />
``` C++
public:
static property bool SingleThreaded {
	bool get ();
	void set (bool value);
}
```

**F#**<br />
``` F#
static member SingleThreaded : bool with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />`true` if [single threaded]; otherwise, `false`.

## See Also


#### Reference
<a href="T_Furcadia_Logging_Logger">Logger Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />