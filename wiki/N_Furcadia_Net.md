# Furcadia.Net Namespace
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "N:Furcadia.Net"\]


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetChannelEventArgs">NetChannelEventArgs</a></td><td></td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetClientEventArgs">NetClientEventArgs</a></td><td>
Client Status Event Arguments.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetMessage">NetMessage</a></td><td>
Default.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetProxy">NetProxy</a></td><td>
Furcadia base proxy connect between Client and Server. This is a low level class that handles the raw connections and furcadia proxy/firewall settings. 
We don't have TLS/SSL handling here, so therefore, Furcadia Settings for this are disabled</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetProxyException">NetProxyException</a></td><td>
Desctiption of NetProxyException.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_NetServerEventArgs">NetServerEventArgs</a></td><td>
Game Server Status Event Arguments</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_ParseChannelArgs">ParseChannelArgs</a></td><td>
Parse Server Instruction set</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_ParseServerArgs">ParseServerArgs</a></td><td>
Parse Server Instruction set</td></tr></table>

## Interfaces
&nbsp;<table><tr><th></th><th>Interface</th><th>Description</th></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Furcadia_Net_INetMessage">INetMessage</a></td><td></td></tr></table>

## Delegates
&nbsp;<table><tr><th></th><th>Delegate</th><th>Description</th></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_NetProxy_ActionDelegate">NetProxy.ActionDelegate</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_NetProxy_DataEventHandler">NetProxy.DataEventHandler</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_NetProxy_DataEventHandler2">NetProxy.DataEventHandler2</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_NetProxy_ErrorEventHandler">NetProxy.ErrorEventHandler</a></td><td></td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Furcadia_Net_ConnectionPhase">ConnectionPhase</a></td><td>
Connection Status</td></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Furcadia_Net_ServerInstructionType">ServerInstructionType</a></td><td>
Server to Client Instruction set. (Furcadia v31c) 
This is the set that FF3PP understands and uses.

these can change with each Furcadia update.</td></tr></table>&nbsp;
