# FurreList Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Furre List information for a Furcadia Dream 
This class acts like an enhanced List(of <T>) because you can Select a Furre by Item as well as index



## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Net.DreamInfo.FurreList<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class FurreList : IList<Furre>, 
	ICollection<Furre>, IEnumerable<Furre>, IEnumerable, 
	ICollection
```

**VB**<br />
``` VB
Public Class FurreList
	Implements IList(Of Furre), ICollection(Of Furre), 
	IEnumerable(Of Furre), IEnumerable, ICollection
```

**VB Usage**<br />
``` VB Usage
Dim instance As FurreList
```

**C++**<br />
``` C++
public ref class FurreList : IList<Furre^>, 
	ICollection<Furre^>, IEnumerable<Furre^>, IEnumerable, 
	ICollection
```

**F#**<br />
``` F#
type FurreList =  
    class
        interface IList<Furre>
        interface ICollection<Furre>
        interface IEnumerable<Furre>
        interface IEnumerable
        interface ICollection
    end
```

The FurreList type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList__ctor">FurreList</a></td><td>
Initializes a new instance of the FurreList class</td></tr></table>&nbsp;
<a href="#furrelist-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_Count">Count</a></td><td>
Number of Avatars in the Dream</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_IsReadOnly">IsReadOnly</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_IsSynchronized">IsSynchronized</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_Item_1">Item(Int32)</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_Item">Item(Furre)</a></td><td>
Gets or set the Furre at index of fur</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_SyncRoot">SyncRoot</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DreamInfo_FurreList_ToIList">ToIList</a></td><td>
Convert Furre List to <a href="http://msdn2.microsoft.com/en-us/library/30ft6hw7" target="_blank">IList</a></td></tr></table>&nbsp;
<a href="#furrelist-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Add">Add</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Clear">Clear</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Contains_1">Contains(Int32)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Contains_2">Contains(String)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Contains">Contains(Furre)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_CopyTo_1">CopyTo(Array, Int32)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_CopyTo">CopyTo(Furre[], Int32)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_GerFurreByName">GerFurreByName</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_GetEnumerator">GetEnumerator</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_GetFurreByID_1">GetFurreByID(Int32)</a></td><td>
get a Furre from the Furrelist by its integer idd</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_GetFurreByID">GetFurreByID(Base220)</a></td><td>
Get's a Furre from the Dream List bu it's ID</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_IndexOf">IndexOf</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Insert">Insert</a></td><td></td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Remove_1">Remove(Int32)</a></td><td>
Removes a Furre based on their Furre ID</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_Remove">Remove(Furre)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DreamInfo_FurreList_RemoveAt">RemoveAt</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#furrelist-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Net_DreamInfo_FurreList_fList">fList</a></td><td></td></tr></table>&nbsp;
<a href="#furrelist-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#furrelist-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_DreamInfo">Furcadia.Net.DreamInfo Namespace</a><br />