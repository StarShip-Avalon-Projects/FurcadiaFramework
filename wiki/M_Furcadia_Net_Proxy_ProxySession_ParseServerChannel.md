# ProxySession.ParseServerChannel Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Parse Channel Data

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void ParseServerChannel(
	string data,
	bool Handled
)
```

**VB**<br />
``` VB
Public Sub ParseServerChannel ( 
	data As String,
	Handled As Boolean
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
Dim data As String
Dim Handled As Boolean

instance.ParseServerChannel(data, Handled)
```

**C++**<br />
``` C++
public:
void ParseServerChannel(
	String^ data, 
	bool Handled
)
```

**F#**<br />
``` F#
member ParseServerChannel : 
        data : string * 
        Handled : bool -> unit 

```


#### Parameters
&nbsp;<dl><dt>data</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Raw Game Server to Client instruction</dd><dt>Handled</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />Is this data already handled?</dd></dl>

## Remarks
This is derived content from the Furcadia Dev Docs and Furcadia Technical Resources 
Update 23 Avatar Movement http://dev.furcadia.com/docs/023_new_movement.pdf

Update 27 Movement http://dev.furcadia.com/docs/027_movement.html

FTR http://ftr.icerealm.org/ref-instructions/


## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />