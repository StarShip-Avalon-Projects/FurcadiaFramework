# IniFile.IniSection.GetKey Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Returns a IniKey object to the key by name, NULL if it was not found

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public IniFile.IniSection.IniKey GetKey(
	string sKey
)
```

**VB**<br />
``` VB
Public Function GetKey ( 
	sKey As String
) As IniFile.IniSection.IniKey
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile.IniSection
Dim sKey As String
Dim returnValue As IniFile.IniSection.IniKey

returnValue = instance.GetKey(sKey)
```

**C++**<br />
``` C++
public:
IniFile.IniSection.IniKey^ GetKey(
	String^ sKey
)
```

**F#**<br />
``` F#
member GetKey : 
        sKey : string -> IniFile.IniSection.IniKey 

```


#### Parameters
&nbsp;<dl><dt>sKey</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />The s key.</dd></dl>

#### Return Value
Type: <a href="T_Furcadia_IO_IniFile_IniSection_IniKey">IniFile.IniSection.IniKey</a><br />\[Missing <returns> documentation for "M:Furcadia.IO.IniFile.IniSection.GetKey(System.String)"\]

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile_IniSection">IniFile.IniSection Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />