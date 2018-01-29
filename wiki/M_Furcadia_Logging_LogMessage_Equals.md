# LogMessage.Equals Method 
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>, is equal to this instance.

**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public override bool Equals(
	Object obj
)
```

**VB**<br />
``` VB
Public Overrides Function Equals ( 
	obj As Object
) As Boolean
```

**VB Usage**<br />
``` VB Usage
Dim instance As LogMessage
Dim obj As Object
Dim returnValue As Boolean

returnValue = instance.Equals(obj)
```

**C++**<br />
``` C++
public:
virtual bool Equals(
	Object^ obj
) override
```

**F#**<br />
``` F#
abstract Equals : 
        obj : Object -> bool 
override Equals : 
        obj : Object -> bool 
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />The <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> to compare with this instance.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />`true` if the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a> is equal to this instance; otherwise, `false`.

## See Also


#### Reference
<a href="T_Furcadia_Logging_LogMessage">LogMessage Structure</a><br /><a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />