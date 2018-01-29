# Variable Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Furcadia.Net.Web.Variable"\]


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Net.Web.Variable<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_Web">Furcadia.Net.Web</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
[CLSCompliantAttribute(false)]
public class Variable : IVariable, IEquatable<IVariable>
```

**VB**<br />
``` VB
<SerializableAttribute>
<CLSCompliantAttribute(false)>
Public Class Variable
	Implements IVariable, IEquatable(Of IVariable)
```

**VB Usage**<br />
``` VB Usage
Dim instance As Variable
```

**C++**<br />
``` C++
[SerializableAttribute]
[CLSCompliantAttribute(false)]
public ref class Variable : IVariable, 
	IEquatable<IVariable^>
```

**F#**<br />
``` F#
[<SerializableAttribute>]
[<CLSCompliantAttribute(false)>]
type Variable =  
    class
        interface IVariable
        interface IEquatable<IVariable>
    end
```

The Variable type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Web_Variable_IsConstant">IsConstant</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Web_Variable_Name">Name</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Web_Variable_Value">Value</a></td><td /></tr></table>&nbsp;
<a href="#variable-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Web_Variable_Clone">Clone</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Web_Variable_Equals_1">Equals(Object)</a></td><td> (Overrides <a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Web_Variable_Equals">Equals(IVariable)</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Web_Variable_GetHashCode">GetHashCode</a></td><td>
Returns the hash code for this instance.
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Web_Variable_ToString">ToString</a></td><td>
Returns a const identifier if the variable is constant followed by name, 
otherwise just the name is returned.

 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">Object.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#variable-class">Back to Top</a>

## Operators
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Addition">Addition(Variable, Double)</a></td><td>
Implements the operator +.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Addition_1">Addition(Variable, String)</a></td><td>
Implements the operator +.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Division">Division</a></td><td>
Implements the operator /.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Equality">Equality</a></td><td>
Implements the operator ==.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Implicit">Implicit(Variable to String)</a></td><td>
Performs an implicit conversion from Variable to <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Implicit_1">Implicit(Variable to Double)</a></td><td>
Performs an implicit conversion from Variable to <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a>.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Inequality">Inequality</a></td><td>
Implements the operator !=.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Multiply">Multiply</a></td><td>
Implements the operator *.</td></tr><tr><td>![Public operator](media/puboperator.gif "Public operator")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Net_Web_Variable_op_Subtraction">Subtraction</a></td><td>
Implements the operator -.</td></tr></table>&nbsp;
<a href="#variable-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Net_Web_Variable_NoValue">NoValue</a></td><td /></tr></table>&nbsp;
<a href="#variable-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#variable-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_Web">Furcadia.Net.Web Namespace</a><br />