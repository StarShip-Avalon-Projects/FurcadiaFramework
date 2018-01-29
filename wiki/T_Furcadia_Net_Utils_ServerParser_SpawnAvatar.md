# SpawnAvatar Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Process the Spaw Avatar Instruction


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">Furcadia.Net.Utils.ServerParser.BaseServerInstruction</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.Utils.ServerParser.SpawnAvatar<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class SpawnAvatar : BaseServerInstruction
```

**VB**<br />
``` VB
Public Class SpawnAvatar
	Inherits BaseServerInstruction
```

**VB Usage**<br />
``` VB Usage
Dim instance As SpawnAvatar
```

**C++**<br />
``` C++
public ref class SpawnAvatar : public BaseServerInstruction
```

**F#**<br />
``` F#
type SpawnAvatar =  
    class
        inherit BaseServerInstruction
    end
```

The SpawnAvatar type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Utils_ServerParser_SpawnAvatar__ctor">SpawnAvatar</a></td><td>
Initializes a new instance of the SpawnAvatar class</td></tr></table>&nbsp;
<a href="#spawnavatar-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_InstructionType">InstructionType</a></td><td>
Which Server to Client Instruction are we?
 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_SpawnAvatar_player">player</a></td><td>
the Active Player</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_SpawnAvatar_PlayerFlags">PlayerFlags</a></td><td>
Spawing plags</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_RawInstruction">RawInstruction</a></td><td>
Raw Server to Client instruction
 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr></table>&nbsp;
<a href="#spawnavatar-class">Back to Top</a>

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
<a href="#spawnavatar-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_Utils_ServerParser_BaseServerInstruction_instructionType">instructionType</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_Utils_ServerParser_BaseServerInstruction">BaseServerInstruction</a>.)</td></tr></table>&nbsp;
<a href="#spawnavatar-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#spawnavatar-class">Back to Top</a>

## Remarks
"<" + user id + x + y + shape number + name + color code + flag + linefeed 
<a href="http://dev.furcadia.com/docs/027_movement.html" target="_blank">http://dev.furcadia.com/docs/027_movement.html</a>


## See Also


#### Reference
<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser Namespace</a><br />