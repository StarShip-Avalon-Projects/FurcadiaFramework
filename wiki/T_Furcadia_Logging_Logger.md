# Logger Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Logging.Logger"\]


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Logging.Logger<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Logging">Furcadia.Logging</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public static class Logger
```

**VB**<br />
``` VB
Public NotInheritable Class Logger
```

**VB Usage**<br />
``` VB Usage

```

**C++**<br />
``` C++
public ref class Logger abstract sealed
```

**F#**<br />
``` F#
[<AbstractClassAttribute>]
[<SealedAttribute>]
type Logger =  class end
```

The Logger type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_DebugEnabled">DebugEnabled</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_ErrorEnabled">ErrorEnabled</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_InfoEnabled">InfoEnabled</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_LogCallingMethod">LogCallingMethod</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_LogOutput">LogOutput</a></td><td>
Sets the <a href="T_Furcadia_Logging_ILogOutput">ILogOutput</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_MessagesExpire">MessagesExpire</a></td><td>
Gets or sets the messages expire time limit. Messages that have expired are removed from history. This property used in conjunction with SupressSpam = true prevents too much memory from being used over time</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_SingleThreaded">SingleThreaded</a></td><td>
Gets or sets a value indicating whether [single threaded].</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_SuppressSpam">SuppressSpam</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Furcadia_Logging_Logger_WarningEnabled">WarningEnabled</a></td><td /></tr></table>&nbsp;
<a href="#logger-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Assert">Assert(Boolean, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Assert_1">Assert(Func(Boolean), String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Assert__1">Assert(T)(Boolean, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Assert__1_1">Assert(T)(Func(Boolean), String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Debug">Debug(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Debug__1">Debug(T)(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Disable__1">Disable(T)</a></td><td>
Disables logging for the specified type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Error">Error(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Error__1">Error(T)(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Fails">Fails(Boolean, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Fails_1">Fails(Func(Boolean), String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Fails__1">Fails(T)(Boolean, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Fails__1_1">Fails(T)(Func(Boolean), String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Info">Info(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Info__1">Info(T)(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Warn">Warn(Object, String)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Logging_Logger_Warn__1">Warn(T)(Object, String)</a></td><td /></tr></table>&nbsp;
<a href="#logger-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")![Static member](media/static.gif "Static member")</td><td><a href="E_Furcadia_Logging_Logger_SpamFound">SpamFound</a></td><td /></tr></table>&nbsp;
<a href="#logger-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Logging">Furcadia.Logging Namespace</a><br />