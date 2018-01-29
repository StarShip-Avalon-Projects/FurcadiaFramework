# MultiLogOutput Constructor 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Initializes a new instance of the <a href="T_Furcadia_Logging_MultiLogOutput">MultiLogOutput</a> class

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public MultiLogOutput(
	params ILogOutput[] outputs
)
```

**VB**<br />
``` VB
Public Sub New ( 
	ParamArray outputs As ILogOutput()
)
```

**VB Usage**<br />
``` VB Usage
Dim outputs As ILogOutput()

Dim instance As New MultiLogOutput(outputs)
```

**C++**<br />
``` C++
public:
MultiLogOutput(
	... array<ILogOutput^>^ outputs
)
```

**F#**<br />
``` F#
new : 
        outputs : ILogOutput[] -> MultiLogOutput
```


#### Parameters
&nbsp;<dl><dt>outputs</dt><dd>Type: <a href="T_Furcadia_Logging_ILogOutput">Furcadia.Logging.ILogOutput</a>[]<br />\[Missing <param name="outputs"/> documentation for "M:Furcadia.Logging.MultiLogOutput.#ctor(Furcadia.Logging.ILogOutput[])"\]</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Logging_MultiLogOutput">MultiLogOutput Class</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />