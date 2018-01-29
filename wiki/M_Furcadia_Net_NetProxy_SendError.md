# NetProxy.SendError Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

send errors to the error handler

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
protected virtual void SendError(
	Exception e,
	Object o
)
```

**VB**<br />
``` VB
Protected Overridable Sub SendError ( 
	e As Exception,
	o As Object
)
```

**VB Usage**<br />
``` VB Usage
Dim e As Exception
Dim o As Object

Me.SendError(e, o)
```

**C++**<br />
``` C++
protected:
virtual void SendError(
	Exception^ e, 
	Object^ o
)
```

**F#**<br />
``` F#
abstract SendError : 
        e : Exception * 
        o : Object -> unit 
override SendError : 
        e : Exception * 
        o : Object -> unit 
```


#### Parameters
&nbsp;<dl><dt>e</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/c18k6c59" target="_blank">System.Exception</a><br />\[Missing <param name="e"/> documentation for "M:Furcadia.Net.NetProxy.SendError(System.Exception,System.Object)"\]</dd><dt>o</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="o"/> documentation for "M:Furcadia.Net.NetProxy.SendError(System.Exception,System.Object)"\]</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_NetProxy">NetProxy Class</a><br /><a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />