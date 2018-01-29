# IniFile.Load Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Loads the Reads the data in the ini file into the IniFile object

**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public void Load(
	string sFileName,
	bool bMerge = false
)
```

**VB**<br />
``` VB
Public Sub Load ( 
	sFileName As String,
	Optional bMerge As Boolean = false
)
```

**VB Usage**<br />
``` VB Usage
Dim instance As IniFile
Dim sFileName As String
Dim bMerge As Boolean

instance.Load(sFileName, bMerge)
```

**C++**<br />
``` C++
public:
void Load(
	String^ sFileName, 
	bool bMerge = false
)
```

**F#**<br />
``` F#
member Load : 
        sFileName : string * 
        ?bMerge : bool 
(* Defaults:
        let _bMerge = defaultArg bMerge false
*)
-> unit 

```


#### Parameters
&nbsp;<dl><dt>sFileName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Name of the s file.</dd><dt>bMerge (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />if set to `true` [b merge].</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_IO_IniFile">IniFile Class</a><br /><a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />