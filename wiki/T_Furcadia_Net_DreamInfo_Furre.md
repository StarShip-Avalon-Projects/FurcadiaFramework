# Furre Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Class for Proxies and bots to use Furrre Data provided by the game server.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Net.DreamInfo.Furre<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class Furre : IFurre
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class Furre
	Implements IFurre
```

**VB Usage**<br />
``` VB Usage
Dim instance As Furre
```

**C++**<br />
``` C++
[SerializableAttribute]
public ref class Furre : IFurre
```

**F#**<br />
``` F#
[<SerializableAttribute>]
type Furre =  
    class
        interface IFurre
    end
```

The Furre type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre__ctor">Furre()</a></td><td>
Initializes a new instance of the Furre class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre__ctor_1">Furre(Int32)</a></td><td>
Initializes a new instance of the Furre class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre__ctor_3">Furre(String)</a></td><td>
Furre Constructor with Name</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre__ctor_2">Furre(Int32, String)</a></td><td>
Initializes a new instance of the Furre class</td></tr></table>&nbsp;
<a href="#furre-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_AfkTime">AfkTime</a></td><td>
Away from keyboard time</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_BeekinBadge">BeekinBadge</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Direction">Direction</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_FloorObjectCurrent">FloorObjectCurrent</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_FloorObjectOld">FloorObjectOld</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_FurreColors">FurreColors</a></td><td>
Furcadia Color Code (v31c)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_FurreDescription">FurreDescription</a></td><td>
Furcadia Description</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_FurreID">FurreID</a></td><td>
Furre ID</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Gender">Gender</a></td><td> **Obsolete. **</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Group">Group</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_LastPosition">LastPosition</a></td><td>
The Position the Furre Moved from</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_LastStat">LastStat</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Level">Level</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Message">Message</a></td><td>
Last Message Furre had</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Name">Name</a></td><td>
Furcadia Name</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_PawObjectCurrent">PawObjectCurrent</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_PawObjectOld">PawObjectOld</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Pose">Pose</a></td><td>
Furre Pose</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Position">Position</a></td><td>
Current position where the Furre is standing</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_ShortName">ShortName</a></td><td>
Furcadia Shortname format for Furre Name</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_Visible">Visible</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Furre_WasVisible">WasVisible</a></td><td></td></tr></table>&nbsp;
<a href="#furre-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_Equals">Equals</a></td><td>

 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_GetHashCode">GetHashCode</a></td><td>

 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_ToFurcadiaID">ToFurcadiaID()</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_ToFurcadiaID_1">ToFurcadiaID(Func(IFurre, Int32))</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_ToString">ToString()</a></td><td>

 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">Object.ToString()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_ToString_1">ToString(Func(IFurre, String))</a></td><td></td></tr></table>&nbsp;
<a href="#furre-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_op_Equality">Equality</a></td><td></td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_DreamInfo_Furre_op_Inequality">Inequality</a></td><td></td></tr></table>&nbsp;
<a href="#furre-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#furre-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />