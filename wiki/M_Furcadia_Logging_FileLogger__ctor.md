# FileLogger Constructor 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Initializes a new instance of the <a href="T_Furcadia_Logging_FileLogger">FileLogger</a> class

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public FileLogger(
	Level level = Level.Error
)
```

**VB**<br />
``` VB
Public Sub New ( 
	Optional level As Level = Level.Error
)
```

**VB Usage**<br />
``` VB Usage
Dim level As Level

Dim instance As New FileLogger(level)
```

**C++**<br />
``` C++
public:
FileLogger(
	Level level = Level::Error
)
```

**F#**<br />
``` F#
new : 
        ?level : Level 
(* Defaults:
        let _level = defaultArg level Level.Error
*)
-> FileLogger
```


#### Parameters
&nbsp;<dl><dt>level (Optional)</dt><dd>Type: <a href="T_Furcadia_Logging_Level">Furcadia.Logging.Level</a><br />\[Missing <param name="level"/> documentation for "M:Furcadia.Logging.FileLogger.#ctor(Furcadia.Logging.Level)"\]</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Logging_FileLogger">FileLogger Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />