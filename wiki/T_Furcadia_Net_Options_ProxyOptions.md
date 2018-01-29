# ProxyOptions Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Configuration options for NetProxy


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Furcadia_Net_Options_ClientOptions">Furcadia.Net.Options.ClientOptions</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Furcadia.Net.Options.ProxyOptions<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Net_Options">Furcadia.Net.Options</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class ProxyOptions : ClientOptions
```

**VB**<br />
``` VB
Public Class ProxyOptions
	Inherits ClientOptions
```

**VB Usage**<br />
``` VB Usage
Dim instance As ProxyOptions
```

**C++**<br />
``` C++
public ref class ProxyOptions : public ClientOptions
```

**F#**<br />
``` F#
type ProxyOptions =  
    class
        inherit ClientOptions
    end
```

The ProxyOptions type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Net_Options_ProxyOptions__ctor">ProxyOptions</a></td><td>
Default settings 
localhostport = 6700

furcprocess = "Furcadia.exe"</td></tr></table>&nbsp;
<a href="#proxyoptions-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_CharacterIniFile">CharacterIniFile</a></td><td>
Character Ini file to connect to the Game server with</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_ConnectionRetries">ConnectionRetries</a></td><td>
Gets or sets the connection retries.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_ConnectionTimeOut">ConnectionTimeOut</a></td><td>
Gets or sets the connection time out.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_FurcadiaInstallPath">FurcadiaInstallPath</a></td><td>
Furcadia working folder path to the Client install we want to use</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_FurcadiaProcess">FurcadiaProcess</a></td><td>
Furcadia Client executable</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ClientOptions_GameServerHost">GameServerHost</a></td><td>
Host name or IP of the game server
 (Inherited from <a href="T_Furcadia_Net_Options_ClientOptions">ClientOptions</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ClientOptions_GameServerPort">GameServerPort</a></td><td>
Game server TCP Port
 (Inherited from <a href="T_Furcadia_Net_Options_ClientOptions">ClientOptions</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_LocalhostPort">LocalhostPort</a></td><td>
Localhost TCP port</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_ProxyHost">ProxyHost</a></td><td>
Host name or IP Address for the proxy server 

 Defaults to "localhost'</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_Net_Options_ProxyOptions_Standalone">Standalone</a></td><td>
Allow the connection to stay open after the client drops?</td></tr></table>&nbsp;
<a href="#proxyoptions-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#proxyoptions-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_Options_ClientOptions_FurcadiaFilePaths">FurcadiaFilePaths</a></td><td>
Furcadia Paths File Path Structure.
 (Inherited from <a href="T_Furcadia_Net_Options_ClientOptions">ClientOptions</a>.)</td></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Furcadia_Net_Options_ClientOptions_FurcadiaUtilities">FurcadiaUtilities</a></td><td>
Furcadia Utilities
 (Inherited from <a href="T_Furcadia_Net_Options_ClientOptions">ClientOptions</a>.)</td></tr></table>&nbsp;
<a href="#proxyoptions-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#proxyoptions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Net_Options">Furcadia.Net.Options Namespace</a><br />