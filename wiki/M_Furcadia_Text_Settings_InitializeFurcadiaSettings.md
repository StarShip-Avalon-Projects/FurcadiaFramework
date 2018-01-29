# Settings.InitializeFurcadiaSettings Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Lets back up our Proxy/Firewall settings and then set the new settings for the Furcadia Client

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void InitializeFurcadiaSettings(
	string path = null
)
```

**VB**<br />
``` VB
Public Sub InitializeFurcadiaSettings ( 
	Optional path As String = Nothing
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As Settings
Dim path As String

instance.InitializeFurcadiaSettings(path)
```

**C++**<br />
``` C++
public:
void InitializeFurcadiaSettings(
	String^ path = nullptr
)
```

**F#**<br />
``` F#
member InitializeFurcadiaSettings : 
        ?path : string 
(* Defaults:
        let _path = defaultArg path null
*)
-> unit 

```


#### Parameters
&nbsp;<dl><dt>path (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Furcadia Settings.ini path</dd></dl>

#### Return Value
Type: <br />Backup Settings for restoring later

## See Also


#### Reference
<a href="T_Furcadia_Text_Settings">Settings Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />