# NetProxy.ErrorEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.NetProxy.ErrorEventHandler"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void ErrorEventHandler(
	Exception e,
	Object o
)
```

**VB**<br />
``` VB
Public Delegate Sub ErrorEventHandler ( 
	e As Exception,
	o As Object
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New ErrorEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void ErrorEventHandler(
	Exception^ e, 
	Object^ o
)
```

**F#**<br />
``` F#
type ErrorEventHandler = 
    delegate of 
        e : Exception * 
        o : Object -> unit
```


#### Parameters
&nbsp;<dl><dt>e</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">System.Exception</a><br />The e.</dd><dt>o</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />The o.</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />