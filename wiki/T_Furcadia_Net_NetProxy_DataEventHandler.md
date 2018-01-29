# NetProxy.DataEventHandler Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.NetProxy.DataEventHandler"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate string DataEventHandler(
	string data
)
```

**VB**<br />
``` VB
Public Delegate Function DataEventHandler ( 
	data As String
) As String
```

**VB Usage**<br />
``` VB Usage
Dim instance As New DataEventHandler(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate String^ DataEventHandler(
	String^ data
)
```

**F#**<br />
``` F#
type DataEventHandler = 
    delegate of 
        data : string -> string
```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br /></dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />