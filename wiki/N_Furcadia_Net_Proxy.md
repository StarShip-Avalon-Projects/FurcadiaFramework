# Furcadia.Net.Proxy Namespace
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "N:Furcadia.Net.Proxy"\]


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession">ProxySession</a></td><td>
This Instance handles the current Furcadia Session. 
Part1: Manage MonkeySpeak Engine Start,Stop,Restart. System Variables, MonkeySpeak Execution Triggers

Part2: Furcadia Proxy Controls, In/Out Ports, Host, Character Ini file. Connect, Disconnect, Reconnect

Part2a: Proxy Functions do link to Monkey Speak trigger execution

Part3: This Class Links loosely to the GUI</td></tr></table>

## Structures
&nbsp;<table><tr><th></th><th>Structure</th><th>Description</th></tr><tr><td>![Public structure](media/pubstructure.gif "Public structure")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_Rep">ProxySession.Rep</a></td><td></td></tr></table>

## Delegates
&nbsp;<table><tr><th></th><th>Delegate</th><th>Description</th></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_ClientStatusChangedEventHandler">ProxySession.ClientStatusChangedEventHandler</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_DataHandler">ProxySession.DataHandler</a></td><td>
Send Data to Furcadia Client or Game Server</td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_OnErrorEventHandler">ProxySession.OnErrorEventHandler</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_ProcessChannel">ProxySession.ProcessChannel</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_ProcessInstruction">ProxySession.ProcessInstruction</a></td><td>
Send Server to Client Instruction object to Sub-classed for handling.</td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_ServerStatusChangedEventHandler">ProxySession.ServerStatusChangedEventHandler</a></td><td></td></tr><tr><td>![Public delegate](media/pubdelegate.gif "Public delegate")</td><td><a href="T_Furcadia_Net_Proxy_ProxySession_ThroatTiredEnabled">ProxySession.ThroatTiredEnabled</a></td><td>
Throat Tired even handler</td></tr></table>&nbsp;
