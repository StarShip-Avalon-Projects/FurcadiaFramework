# ProxySession Events
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

The <a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession</a> type exposes the following members.


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
<a href="#proxysession-events">Back to Top</a>

## See Also


#### Reference
<a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession Class</a><br /><a href="N_Furcadia_Net_Proxy">Furcadia.Net.Proxy Namespace</a><br />