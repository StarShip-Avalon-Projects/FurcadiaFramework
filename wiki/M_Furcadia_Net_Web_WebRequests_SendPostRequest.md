# WebRequests.SendPostRequest Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Retriev Account information from the Furcadia Log-On server

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static string SendPostRequest(
	string PostData,
	string url
)
```

**VB**<br />
``` VB
Public Shared Function SendPostRequest ( 
	PostData As String,
	url As String
) As String
```

**VB Usage**<br />
``` VB Usage
Dim PostData As String
Dim url As String
Dim returnValue As String

returnValue = WebRequests.SendPostRequest(PostData, 
	url)
```

**C++**<br />
``` C++
public:
static String^ SendPostRequest(
	String^ PostData, 
	String^ url
)
```

**F#**<br />
``` F#
static member SendPostRequest : 
        PostData : string * 
        url : string -> string 

```


#### Parameters
&nbsp;<dl><dt>PostData</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="PostData"/> documentation for "M:Furcadia.Net.Web.WebRequests.SendPostRequest(System.String,System.String)"\]</dd><dt>url</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />\[Missing <param name="url"/> documentation for "M:Furcadia.Net.Web.WebRequests.SendPostRequest(System.String,System.String)"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a><br />Furcadia Account information including Characters and thier costumes

## See Also


#### Reference
<a href="T_Furcadia_Net_Web_WebRequests">WebRequests Class</a><br /><a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />