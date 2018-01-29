# ProxyOptions.CharacterIniFile Property 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Character Ini file to connect to the Game server with

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Options">Furcadia.Net.Options</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public string CharacterIniFile { get; set; }
```

**VB**<br />
``` VB
Public Property CharacterIniFile As String
	Get
	Set
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxyOptions
Dim value As String

value = instance.CharacterIniFile

instance.CharacterIniFile = value
```

**C++**<br />
``` C++
public:
property String^ CharacterIniFile {
	String^ get ();
	void set (String^ value);
}
```

**F#**<br />
``` F#
member CharacterIniFile : string with get, set

```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## Remarks

Furcadia.Exe Command Line options

If only a Character.ini is Specified then NetProxy will Connect with Legacy Connection.

If NoArguments specified then we'll login with Account Login window

If we use -url="" We can Open the client and the server will select the character for us and bypass the Account Login Screen and the Game News feed


## See Also


#### Reference
<a href="T_Furcadia_Net_Options_ProxyOptions">ProxyOptions Class</a><br /><a href="N_Furcadia_Net_Options">Furcadia.Net.Options Namespace</a><br />