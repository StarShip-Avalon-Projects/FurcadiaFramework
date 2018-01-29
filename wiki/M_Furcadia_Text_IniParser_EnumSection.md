# IniParser.EnumSection Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Enumerates all lines for given section.

**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string[] EnumSection(
	string sectionName
)
```

**VB**<br />
``` VB
Public Function EnumSection ( 
	sectionName As String
) As String()
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniParser
Dim sectionName As String
Dim returnValue As String()

returnValue = instance.EnumSection(sectionName)
```

**C++**<br />
``` C++
public:
array<String^>^ EnumSection(
	String^ sectionName
)
```

**F#**<br />
``` F#
member EnumSection : 
        sectionName : string -> string[] 

```


#### Parameters
&nbsp;<dl><dt>sectionName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Section to enum.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>[]<br />\[Missing <returns> documentation for "M:Furcadia.Text.IniParser.EnumSection(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_Text_IniParser">IniParser Class</a><br /><a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />