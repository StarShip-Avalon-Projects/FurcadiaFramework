# ProxySession Methods
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

The <a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_ClientDisconnect">ClientDisconnect</a></td><td>
Disconnect from the Furcadia client
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_CloseClient">CloseClient</a></td><td>
Disconnects the furcadia client and Closes the application
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_Connect">Connect</a></td><td>
Connect the Proxy to the Furcadia Game server
 (Overrides <a href="M_Furcadia_Net_NetProxy_Connect">NetProxy.Connect()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_Disconnect">Disconnect</a></td><td>
Disconnect from the Furcadia gameserver and Furcadia client
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_Dispose">Dispose</a></td><td>
implementation of Dispose pattern callable by consumers.
 (Overrides <a href="M_Furcadia_Net_NetProxy_Dispose">NetProxy.Dispose()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_GetEnumInt__1">GetEnumInt(T)</a></td><td></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_IsConnectedCharacter">IsConnectedCharacter()</a></td><td>
Are we the current executing character?</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_IsConnectedCharacter_1">IsConnectedCharacter(Furre)</a></td><td>
Is the target furre the connected characyer?</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_ParseServerChannel">ParseServerChannel</a></td><td>
Parse Channel Data</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_ParseServerData">ParseServerData</a></td><td>
Parse Server Data</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Furcadia_Net_NetProxy_SendError">SendError</a></td><td>
send errors to the error handler
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_SendFormattedTextToServer">SendFormattedTextToServer</a></td><td>
Format basic furcadia commands and send to server 
We also mirror the client to server banish system.

This maybe a good place to place Proxy/Bot commands for controls

default to say or "normal spoken command"</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_SendToClient">SendToClient(String)</a></td><td>
Send a raw instruction to the client
 (Overrides <a href="M_Furcadia_Net_NetProxy_SendToClient_1">NetProxy.SendToClient(String)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToClient">SendToClient(INetMessage)</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_SendToServer">SendToServer(String)</a></td><td>
Send a raw instruction to Server through the Load Balancer
 (Overrides <a href="M_Furcadia_Net_NetProxy_SendToServer_1">NetProxy.SendToServer(String)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_NetProxy_SendToServer">SendToServer(INetMessage)</a></td><td>

 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession_TextToServer">TextToServer</a></td><td>
Text Channel Prefixes (shout,whisper emote, Raw Server command) 
default to say or "normal spoken command"</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#proxysession-methods">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#proxysession-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />