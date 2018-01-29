# ProxySession Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This Instance handles the current Furcadia Session. 
Part1: Manage MonkeySpeak Engine Start,Stop,Restart. System Variables, MonkeySpeak Execution Triggers

Part2: Furcadia Proxy Controls, In/Out Ports, Host, Character Ini file. Connect, Disconnect, Reconnect

Part2a: Proxy Functions do link to Monkey Speak trigger execution

Part3: This Class Links loosely to the GUI



## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Furcadia_Net_NetProxy">Furcadia.Net.NetProxy</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.Proxy.ProxySession<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class ProxySession : NetProxy, 
	IDisposable
```

**VB**<br />
``` VB
Public Class ProxySession
	Inherits NetProxy
	Implements IDisposable
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxySession
```

**C++**<br />
``` C++
public ref class ProxySession : public NetProxy, 
	IDisposable
```

**F#**<br />
``` F#
type ProxySession =  
    class
        inherit NetProxy
        interface IDisposable
    end
```

The ProxySession type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession__ctor">ProxySession()</a></td><td>
Initializes a new instance of the ProxySession class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Proxy_ProxySession__ctor_1">ProxySession(ProxyOptions)</a></td><td>
Initializes a new instance of the ProxySession class</td></tr></table>&nbsp;
<a href="#proxysession-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_BanishList">BanishList</a></td><td>
Gets the banish list.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_BanishName">BanishName</a></td><td>
Current Name for Banish Operations 
We mirror Furcadia's Banish system for efficiency</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_BufferCapacity">BufferCapacity</a></td><td>
Gets the buffer capacity.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_Channel">Channel</a></td><td>
Channel name?</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ClientConnectPhase">ClientConnectPhase</a></td><td>
Current Connection Phase</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ClientStatus">ClientStatus</a></td><td>
Client Connection status</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ConnectedFurre">ConnectedFurre</a></td><td>
Connected Furre (Who we are)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_CurrentConnectionAttempt">CurrentConnectionAttempt</a></td><td>
Gets the current connection attempt.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_Dream">Dream</a></td><td>
Current Dream Information with Furre List</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_EncoderPage">EncoderPage</a></td><td>
Encodig 

 DEFAULT: Windows 1252
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ErrorMsg">ErrorMsg</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ErrorNum">ErrorNum</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_FurcadiaClientIsRunning">FurcadiaClientIsRunning</a></td><td>
Gets a value indicating whether [the Furcadia lient is a running process].
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_FurcadiaProcessID">FurcadiaProcessID</a></td><td>
Gets the furcadia process identifier.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_HasShare">HasShare</a></td><td>
We have Dream Share or We are Dream owner</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_InDream">InDream</a></td><td></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_IsClientSocketConnected">IsClientSocketConnected</a></td><td>
Gets a value indicating whether this instance is client socket connected.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_IsServerSocketConnected">IsServerSocketConnected</a></td><td>
Check our connection status to the game server
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_NetProxy_Options">Options</a></td><td>
Gets or sets the options.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_Player">Player</a></td><td>
Current Triggering player</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ServerConnectPhase">ServerConnectPhase</a></td><td>
Current server connection phase</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ServerStatus">ServerStatus</a></td><td>
Server Connection status</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_StandAlone">StandAlone</a></td><td>
Allows the Furcadia Client to Disconnect from the session, allowing the session to remain connected to the game server</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Proxy_ProxySession_ThroatTired">ThroatTired</a></td><td>
ServerQueue Throat Tired Mode 
When set, a <a href="http://msdn2.microsoft.com/en-us/library/saba8ksx" target="_blank">Timer</a> is created to make us wait till the time is clear to resume.</td></tr></table>&nbsp;
<a href="#proxysession-class">Back to Top</a>

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
<a href="#proxysession-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientConnected">ClientConnected</a></td><td> (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ClientData2">ClientData2</a></td><td>
This is triggered when the Client sends data to the server. Expects a return value.
 (Overrides <a href="E_Furcadia_Net_NetProxy_ClientData2">NetProxy.ClientData2</a>.)</td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientDisconnected">ClientDisconnected</a></td><td>
This is triggered when the Client Disconnects
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ClientExited">ClientExited</a></td><td>
Occurs when the furcadia client exits.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ClientStatusChanged">ClientStatusChanged</a></td><td>
Track the Furcadia Client status</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_Error">Error</a></td><td>
This is triggered when a handled Exception is thrown.
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ProcessServerChannelData">ProcessServerChannelData</a></td><td>
Process Display Text and Channels</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ProcessServerInstruction">ProcessServerInstruction</a></td><td></td></tr><tr><td>![Protected event](media/protevent.gif "Protected event")</td><td><a href="E_Furcadia_Net_NetProxy_ServerConnected">ServerConnected</a></td><td> (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ServerData2">ServerData2</a></td><td>
This is triggered when the Server sends data to the client. Doesn't expect a return value.
 (Overrides <a href="E_Furcadia_Net_NetProxy_ServerData2">NetProxy.ServerData2</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_NetProxy_ServerDisconnected">ServerDisconnected</a></td><td>
This is triggered when the Server Disconnects
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Furcadia_Net_Proxy_ProxySession_ServerStatusChanged">ServerStatusChanged</a></td><td>
Track the Server Status</td></tr></table>&nbsp;
<a href="#proxysession-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_NetProxy_FurcadiaUtilities">FurcadiaUtilities</a></td><td>
Furcadia Utilities
 (Inherited from <a href="T_Furcadia_Net_NetProxy">NetProxy</a>.)</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="F_Furcadia_Net_Proxy_ProxySession_Repq">Repq</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="F_Furcadia_Net_Proxy_ProxySession_TroatTiredEventHandler">TroatTiredEventHandler</a></td><td /></tr></table>&nbsp;
<a href="#proxysession-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#proxysession-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />