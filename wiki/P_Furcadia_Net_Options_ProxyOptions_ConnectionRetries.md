# ProxyOptions.ConnectionRetries Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets the connection retries.

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Options">Furcadia.Net.Options</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public int ConnectionRetries { get; set; }
```

**VB**<br />
``` VB
Public Property ConnectionRetries As Integer
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxyOptions
Dim value As Integer

value = instance.ConnectionRetries

instance.ConnectionRetries = value
```

**C++**<br />
``` C++
public:
property int ConnectionRetries {
	int get ();
	void set (int value);
}
```

**F#**<br />
``` F#
member ConnectionRetries : int with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a><br />Number of reconnection attempts 

 Default: 5 tries

## See Also


#### Reference
<a href="T_Furcadia_Net_Options_ProxyOptions">ProxyOptions Class</a><br /><a href="N_Furcadia_Net_Options">Furcadia.Net.Options Namespace</a><br />