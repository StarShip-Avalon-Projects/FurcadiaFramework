# IniParser.AddSetting Method (String, String, String)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Adds or replaces a setting to the table to be saved.

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void AddSetting(
	string sectionName,
	string settingName,
	string settingValue
)
```

**VB**<br />
``` VB
Public Sub AddSetting ( 
	sectionName As String,
	settingName As String,
	settingValue As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniParser
Dim sectionName As String
Dim settingName As String
Dim settingValue As String

instance.AddSetting(sectionName, settingName, 
	settingValue)
```

**C++**<br />
``` C++
public:
void AddSetting(
	String^ sectionName, 
	String^ settingName, 
	String^ settingValue
)
```

**F#**<br />
``` F#
member AddSetting : 
        sectionName : string * 
        settingName : string * 
        settingValue : string -> unit 

```


#### Parameters
&nbsp;<dl><dt>sectionName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Section to add under.</dd><dt>settingName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Key name to add.</dd><dt>settingValue</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Value of key.</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Text_IniParser">IniParser Class</a><br /><a href="Overload_Furcadia_Text_IniParser_AddSetting">AddSetting Overload</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />