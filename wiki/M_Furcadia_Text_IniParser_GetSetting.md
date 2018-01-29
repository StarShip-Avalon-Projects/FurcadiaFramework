# IniParser.GetSetting Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Returns the value for the given section, key pair.

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string GetSetting(
	string sectionName,
	string settingName
)
```

**VB**<br />
``` VB
Public Function GetSetting ( 
	sectionName As String,
	settingName As String
) As String
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniParser
Dim sectionName As String
Dim settingName As String
Dim returnValue As String

returnValue = instance.GetSetting(sectionName, 
	settingName)
```

**C++**<br />
``` C++
public:
String^ GetSetting(
	String^ sectionName, 
	String^ settingName
)
```

**F#**<br />
``` F#
member GetSetting : 
        sectionName : string * 
        settingName : string -> string 

```


#### Parameters
&nbsp;<dl><dt>sectionName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Section name.</dd><dt>settingName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Key name.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />\[Missing <returns> documentation for "M:Furcadia.Text.IniParser.GetSetting(System.String,System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_Text_IniParser">IniParser Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />