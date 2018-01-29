# PounceConnection.PounceResponse Delegate
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Pounce.PounceConnection.PounceResponse"\]

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public delegate void PounceResponse(
	string[] friends,
	string[] dreams
)
```

**VB**<br />
``` VB
Public Delegate Sub PounceResponse ( 
	friends As String(),
	dreams As String()
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As New PounceResponse(AddressOf HandlerMethod)
```

**C++**<br />
``` C++
public delegate void PounceResponse(
	array<String^>^ friends, 
	array<String^>^ dreams
)
```

**F#**<br />
``` F#
type PounceResponse = 
    delegate of 
        friends : string[] * 
        dreams : string[] -> unit
```


#### Parameters
&nbsp;<dl><dt>friends</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />Friends list</dd><dt>dreams</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />Dream list.</dd></dl>

## See Also


#### Reference
<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce Namespace</a><br />