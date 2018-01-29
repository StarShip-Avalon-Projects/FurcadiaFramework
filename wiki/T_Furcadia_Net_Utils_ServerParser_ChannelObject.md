# ChannelObject Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Base Server Instruction object for Channel Processing


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">Furcadia.Net.Utils.ServerParser.BaseServerInstruction</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.Utils.ServerParser.ChannelObject<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Furcadia_Net_Utils_ServerParser_DiceRolls">Furcadia.Net.Utils.ServerParser.DiceRolls</a><br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class ChannelObject : BaseServerInstruction
```

**VB**<br />
``` VB
Public Class ChannelObject
	Inherits BaseServerInstruction
```

**VB Usage**<br />
``` VB Usage
Dim instance As ChannelObject
```

**C++**<br />
``` C++
public ref class ChannelObject : public BaseServerInstruction
```

**F#**<br />
``` F#
type ChannelObject =  
    class
        inherit BaseServerInstruction
    end
```

The ChannelObject type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Utils_ServerParser_ChannelObject__ctor">ChannelObject</a></td><td>
Initializes a new instance of the ChannelObject class</td></tr></table>&nbsp;
<a href="#channelobject-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_ChannelObject_ChannelText">ChannelText</a></td><td>
Raw unformatted channel text</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_ChannelObject_DynamicChannel">DynamicChannel</a></td><td>
Dynamic Channel filter</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_ChannelObject_FormattedChannelText">FormattedChannelText</a></td><td>
returns Clear Text to display in a log</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_InstructionType">InstructionType</a></td><td>
Which Server to Client Instruction are we?
 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_ChannelObject_Player">Player</a></td><td>
Active Triggering avatar</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_RawInstruction">RawInstruction</a></td><td>
Raw Server to Client instruction
 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr></table>&nbsp;
<a href="#channelobject-class">Back to Top</a>

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
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_ToString">ToString</a></td><td> (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr></table>&nbsp;
<a href="#channelobject-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_instructionType">instructionType</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr></table>&nbsp;
<a href="#channelobject-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#channelobject-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser Namespace</a><br />