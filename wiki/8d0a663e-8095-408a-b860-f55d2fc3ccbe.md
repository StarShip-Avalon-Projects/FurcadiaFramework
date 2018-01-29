# Welcome to FFF3PP

Welcome to Furcadia Frame Work for Third Party Programs.


Furcadia Framework is intended to help the community develop Third Party Applications using the .NET Framework. This library includes all the basic functionality for working with the Furcadia Client, associated programs, and services.


Copies of this document will be included as a Compiled Help File (*.chm) in each release of the SDK. All current documentation will be stored at our <a href="https://starship-avalon-projects.github.io/FurcadiaFramework/">GitHub Repository</a>. Alternatively, you can download this document in a Compiled Help File format <a href="https://starship-avalon-projects.github.io/FurcadiaFramework/Furcadia_Framework_Help.chm">here</a>.



## Project Description

We're Currently working on a ProxySession Class in the Furcadia Framework Library. This Class is intended to be a drop in replacement for NetProxy and will include the bells and whistles for basic operation. To assist us in further development of the library, we have under taken a mission to document all aspects of Furcadia that we can. From file specificifications and configurations to items lists and patch information, this project intends to capture it all for both legacy and modern Furcadia.


Anyone is welcome to contribute to this project. Our aim is to support the community in any area we can. This often requires updating older documentation in the depths of the internet and bringing it to one community supported arena.
&nbsp;<ol><li>
**Client to Server Queue Manager(<a href="T_Furcadia_Net_Utils_ServerQue">Furcadia.Net.Utils.ServerQue</a> )** This will Absorb all the SendToServer instructions and spoon feed them to the game server without overloading the Servers' Buffer. In here we'll handle Throat-Tired Syndrome and NoEndurance.</li><li>
**Dream Patron List Manager(Furcadia.Net.Dream)** This will maintain a list of players in the current dream and keep track of basic stats such as current player position, costume settings, taking advantage of <a href="http://cms.furcadia.com/creations/dreammaking/dragonspeak/dsparams" title="DragonSpeak Parameters">DragonSpeak Parameters</a>.</li><li>
**Pounce Connection(<a href="N_Furcadia_Net_Pounce">Furcadia.Net.Pounce</a>)** Player online detection.</li><li>
**Account Log-on** Directly connecting to the Furcadia API using character .INI files for legacy support.</li><li>
**Server to Client Instruction Handling(<a href="N_Furcadia_Net_Utils_ServerParser">Furcadia.Net.Utils.ServerParser</a>)** Parsing Server data for basic Proxy operation with events leading out for custom code links. The events will return Server Data and EventArgs. This will apply to Text channel parsing as well.</li><li>
**SSL/TLS Connection** Handling of game server Security Certificates for an encrypted connection.</li></ol>

## See Also


#### Other Resources
<a href="1711b873-c91f-4780-8e67-6c39206cb317.md">BugTraq (Bug Reports)</a><br /><a href="64d441eb-864b-4f9e-994f-2d87632ea597.md">About</a><br /><a href="4340cd61-7802-4111-a144-fc835a39faf6.md">VersionHistory</a><br />