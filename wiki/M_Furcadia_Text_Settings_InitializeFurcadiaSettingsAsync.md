# Settings.InitializeFurcadiaSettingsAsync Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Initializes the furcadia settings asynchronous.

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public Task InitializeFurcadiaSettingsAsync(
	string path = null
)
```

**VB**<br />
``` VB
Public Function InitializeFurcadiaSettingsAsync ( 
	Optional path As String = Nothing
) As Task
```

**VB Usage**<br />
``` VB Usage
Dim instance As Settings
Dim path As String
Dim returnValue As Task

returnValue = instance.InitializeFurcadiaSettingsAsync(path)
```

**C++**<br />
``` C++
public:
Task^ InitializeFurcadiaSettingsAsync(
	String^ path = nullptr
)
```

**F#**<br />
``` F#
member InitializeFurcadiaSettingsAsync : 
        ?path : string 
(* Defaults:
        let _path = defaultArg path null
*)
-> Task 

```


#### Parameters
&nbsp;<dl><dt>path (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The path.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd235678" target="_blank">Task</a><br />\[Missing <returns> documentation for "M:Furcadia.Text.Settings.InitializeFurcadiaSettingsAsync(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_Text_Settings">Settings Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />