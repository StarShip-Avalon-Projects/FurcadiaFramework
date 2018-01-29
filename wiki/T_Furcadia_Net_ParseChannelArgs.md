# ParseChannelArgs Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Parse Server Instruction set


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Furcadia_Net_ParseServerArgs">Furcadia.Net.ParseServerArgs</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.ParseChannelArgs<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ParseChannelArgs : ParseServerArgs
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ParseChannelArgs
	Inherits ParseServerArgs
```

**VB Usage**<br />
``` VB Usage
Dim instance As ParseChannelArgs
```

**C++**<br />
``` C++
[SerializableAttribute]
public ref class ParseChannelArgs : public ParseServerArgs
```

**F#**<br />
``` F#
[<SerializableAttribute>]
type ParseChannelArgs =  
    class
        inherit ParseServerArgs
    end
```

The ParseChannelArgs type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_ParseChannelArgs__ctor">ParseChannelArgs()</a></td><td>
Initializes a new instance of the ParseChannelArgs class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_ParseChannelArgs__ctor_1">ParseChannelArgs(ServerInstructionType, ConnectionPhase)</a></td><td>
Initializes a new instance of the ParseChannelArgs class</td></tr></table>&nbsp;
<a href="#parsechannelargs-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_ParseChannelArgs_Channel">Channel</a></td><td>
Server Text Channel</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_ParseServerArgs_ServerConnectedPhase">ServerConnectedPhase</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_ParseServerArgs_ServerData">ServerData</a></td><td>
optional string message
 (Inherited from <a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_ParseServerArgs_ServerInstruction">ServerInstruction</a></td><td>
Server to Client Instruction Type
 (Inherited from <a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs</a>.)</td></tr></table>&nbsp;
<a href="#parsechannelargs-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_ParseServerArgs_ToString">ToString</a></td><td>
Returns a <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a> that represents this instance.
 (Inherited from <a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs</a>.)</td></tr></table>&nbsp;
<a href="#parsechannelargs-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#parsechannelargs-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />