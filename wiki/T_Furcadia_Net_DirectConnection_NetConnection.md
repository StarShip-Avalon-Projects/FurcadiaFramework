# NetConnection Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Direct Furcadia game server connection with included server load balancer.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Furcadia_Net_DirectConnection_ClientBase">Furcadia.Net.DirectConnection.ClientBase</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.DirectConnection.NetConnection<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class NetConnection : ClientBase
```

**VB**<br />
``` VB
Public Class NetConnection
	Inherits ClientBase
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetConnection
```

**C++**<br />
``` C++
public ref class NetConnection : public ClientBase
```

**F#**<br />
``` F#
type NetConnection =  
    class
        inherit ClientBase
    end
```

The NetConnection type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_NetConnection__ctor">NetConnection()</a></td><td>
Default Constructor</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_NetConnection__ctor_1">NetConnection(IPAddress, Int32)</a></td><td>
Connect to game server with Host IP address and Specified port</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_NetConnection__ctor_2">NetConnection(String, Int32)</a></td><td>
Connect to game server with Host DNS and Specified port</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DirectConnection_ClientBase_EndPoint">EndPoint</a></td><td>
Game Server IP/Port
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_DirectConnection_ClientBase_IsServerConnected">IsServerConnected</a></td><td>
Proxy is connected, or not.
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_NetConnection_Connect">Connect</a></td><td>
Connect to game server
 (Overrides <a href="M_Furcadia_Net_DirectConnection_ClientBase_Connect">ClientBase.Connect()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_ClientBase_Dispose">Dispose()</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Furcadia_Net_DirectConnection_ClientBase_Dispose_1">Dispose(Boolean)</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_NetConnection_SendServer">SendServer(String)</a></td><td>
Send a message to the Game Server
 (Overrides <a href="M_Furcadia_Net_DirectConnection_ClientBase_SendServer_1">ClientBase.SendServer(String)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_DirectConnection_ClientBase_SendServer">SendServer(INetMessage)</a></td><td>
Sends the text to the game server
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_DirectConnection_ClientBase_Connected">Connected</a></td><td>
This is triggered when the
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_DirectConnection_ClientBase_Error">Error</a></td><td>
This is triggered when a handled Exception is thrown.
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_DirectConnection_ClientBase_ServerData">ServerData</a></td><td>
This is triggered when the Server sends data to the client. Doesn't expect a return value.
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_DirectConnection_ClientBase_ServerDisConnected">ServerDisConnected</a></td><td>
This is triggered when the Server Disconnects
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_DirectConnection_ClientBase_FurcadiaUtilities">FurcadiaUtilities</a></td><td>
Furcadia Utilities
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="F_Furcadia_Net_DirectConnection_ClientBase_FurcPath">FurcPath</a></td><td>
Furcadia Path Collection
 (Inherited from <a href="T_Furcadia_Net_DirectConnection_ClientBase">ClientBase</a>.)</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#netconnection-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_DirectConnection">Furcadia.Net.DirectConnection Namespace</a><br />