# IniParser.DeleteSetting Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Remove a setting.

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void DeleteSetting(
	string sectionName,
	string settingName
)
```

**VB**<br />
``` VB
Public Sub DeleteSetting ( 
	sectionName As String,
	settingName As String
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniParser
Dim sectionName As String
Dim settingName As String

instance.DeleteSetting(sectionName, settingName)
```

**C++**<br />
``` C++
public:
void DeleteSetting(
	String^ sectionName, 
	String^ settingName
)
```

**F#**<br />
``` F#
member DeleteSetting : 
        sectionName : string * 
        settingName : string -> unit 

```


#### Parameters
&nbsp;<dl><dt>sectionName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Section to add under.</dd><dt>settingName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Key name to add.</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Text_IniParser">IniParser Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />