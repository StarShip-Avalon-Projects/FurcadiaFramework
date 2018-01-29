# NetProxy Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Furcadia base proxy connect between Client and Server. This is a low level class that handles the raw connections and furcadia proxy/firewall settings. 
We don't have TLS/SSL handling here, so therefore, Furcadia Settings for this are disabled



## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Net.NetProxy<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Furcadia_Net_Proxy_ProxySession">Furcadia.Net.Proxy.ProxySession</a><br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class NetProxy : IDisposable
```

**VB**<br />
``` VB
Public Class NetProxy
	Implements IDisposable
```

**VB Usage**<br />
``` VB Usage
Dim instance As NetProxy
```

**C++**<br />
``` C++
public ref class NetProxy : IDisposable
```

**F#**<br />
``` F#
type NetProxy =  
    class
        interface IDisposable
    end
```

The NetProxy type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor">NetProxy()</a></td><td>
Connect to game server with default settings</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor_2">NetProxy(Int32)</a></td><td>
Initializes a new instance of the NetProxy class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor_1">NetProxy(ProxyOptions)</a></td><td>
Connect to Furcadia with Proxy Options</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor_3">NetProxy(Int32, Int32)</a></td><td>
Initializes a new instance of the NetProxy class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor_4">NetProxy(String, Int32)</a></td><td>
Initializes a new instance of the NetProxy class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy__ctor_5">NetProxy(String, Int32, Int32)</a></td><td>
Connect to the Game serer by Host name to IP address</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_BufferCapacity">BufferCapacity</a></td><td>
Gets the buffer capacity.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_CurrentConnectionAttempt">CurrentConnectionAttempt</a></td><td>
Gets the current connection attempt.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_EncoderPage">EncoderPage</a></td><td>
Encodig 

 DEFAULT: Windows 1252</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_FurcadiaClientIsRunning">FurcadiaClientIsRunning</a></td><td>
Gets a value indicating whether [the Furcadia lient is a running process].</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_FurcadiaProcessID">FurcadiaProcessID</a></td><td>
Gets the furcadia process identifier.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_IsClientSocketConnected">IsClientSocketConnected</a></td><td>
Gets a value indicating whether this instance is client socket connected.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_IsServerSocketConnected">IsServerSocketConnected</a></td><td>
Check our connection status to the game server</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_Options">Options</a></td><td>
Gets or sets the options.</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_ClientDisconnect">ClientDisconnect</a></td><td>
Disconnect from the Furcadia client</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_CloseClient">CloseClient</a></td><td>
Disconnects the furcadia client and Closes the application</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_Connect">Connect</a></td><td>
Connects to the Furcadia Server and starts the mini proxy.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_Disconnect">Disconnect</a></td><td>
Disconnect from the Furcadia gameserver and Furcadia client</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_Dispose">Dispose</a></td><td>
Releases all resources used by the NetProxy</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Furcadia_Net_NetProxy_SendError">SendError</a></td><td>
send errors to the error handler</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToClient_1">SendToClient(String)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToClient">SendToClient(INetMessage)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToServer_1">SendToServer(String)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToServer">SendToServer(INetMessage)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientConnected">ClientConnected</a></td><td /></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientData2">ClientData2</a></td><td>
This is triggered when the Client sends data to the server. Expects a return value.</td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientDisconnected">ClientDisconnected</a></td><td>
This is triggered when the Client Disconnects</td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientExited">ClientExited</a></td><td>
Occurs when the furcadia client exits.</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_Error">Error</a></td><td>
This is triggered when a handled Exception is thrown.</td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ServerConnected">ServerConnected</a></td><td /></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_ServerData2">ServerData2</a></td><td>
This is triggered when the Server sends data to the client. Doesn't expect a return value.</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_ServerDisconnected">ServerDisconnected</a></td><td>
This is triggered when the Server Disconnects</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_NetProxy_FurcadiaUtilities">FurcadiaUtilities</a></td><td>
Furcadia Utilities</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#netproxy-class">Back to Top</a>

## Remarks


## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />