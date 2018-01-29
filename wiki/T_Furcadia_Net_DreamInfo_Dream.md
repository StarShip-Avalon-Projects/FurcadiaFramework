# Dream Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Current Dream information


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Net.DreamInfo.Dream<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[CLSCompliantAttribute(true)]
public class Dream : IDream
```

**VB**<br />
``` VB
<CLSCompliantAttribute(true)>
Public Class Dream
	Implements IDream
```

**VB Usage**<br />
``` VB Usage
Dim instance As Dream
```

**C++**<br />
``` C++
[CLSCompliantAttribute(true)]
public ref class Dream : IDream
```

**F#**<br />
``` F#
[<CLSCompliantAttribute(true)>]
type Dream =  
    class
        interface IDream
    end
```

The Dream type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream__ctor">Dream</a></td><td>
Initializes a new instance of the Dream class.</td></tr></table>&nbsp;
<a href="#dream-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_BookMark">BookMark</a></td><td>
Gets or sets the book make.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_DreamOwner">DreamOwner</a></td><td>
Dreams uploader character</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_FileName">FileName</a></td><td>
File name for the dream cache stored on disk</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_Furres">Furres</a></td><td>
Dream List Furcadia requires Clients to handle thier own Dream Lists See 
http://dev.furcadia.com/docs New Movement for Spawn and Remove packets

**Spawn is out dated. New information requires a 4byte for AFK flag at the end

As of V31, Color code has changed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_IsModern">IsModern</a></td><td>
Is this dream Modern Mode?</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_IsPermanent">IsPermanent</a></td><td>
Gets a value indicating whether this dream is permament.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_Lines">Lines</a></td><td>
Number of DS Lines</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_Name">Name</a></td><td>
Name of the dream</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_Rating">Rating</a></td><td>
Furcadia Dream rating</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_Title">Title</a></td><td>
Dream title</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_Dream_URL">URL</a></td><td>
Dreams full Furcadia Drean URL 
IE: 'fdl furc://DreamOwner:DreamTitle/EntryCode#</td></tr></table>&nbsp;
<a href="#dream-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_Equals">Equals</a></td><td>
Determines whether the specified <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>, is equal to this instance.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_GetHashCode">GetHashCode</a></td><td>
Returns a hash code for this instance.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_Load">Load</a></td><td>
Loads the specified dream information from a <a href="T_Furcadia_Net_Utils_ServerParser_LoadDream">LoadDream</a> event.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_ToString">ToString</a></td><td>
Returns a <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a> that represents this instance.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">Object.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#dream-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_op_Equality">Equality</a></td><td>
Implements the operator ==.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_DreamInfo_Dream_op_Inequality">Inequality</a></td><td>
Implements the operator !=.</td></tr></table>&nbsp;
<a href="#dream-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#dream-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />