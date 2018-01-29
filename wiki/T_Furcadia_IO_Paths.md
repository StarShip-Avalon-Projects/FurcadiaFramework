# Paths Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

This class contains all the paths related to the users furcadia installation. 
***NOTICE: DO NOT REMOVE***

Credits go to Artex for helping me fix Path issues and contributing his code.

***NOTICE: DO NOT REMOVE.***

Log Header

Format: (date,Version) AuthorName, Changes.

(Mar 12,2014,0.2.12) Gerolkae, Adapted Paths to work with a Supplied path

(June 1, 2016) Gerolkae, Added possible missing Registry Paths for x86/x64 Windows and Mono Support. Wine Support also contains these corrections.



## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.IO.Paths<br />
**Namespace:**&nbsp;<a href="N_Furcadia_IO">Furcadia.IO</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public class Paths
```

**VB**<br />
``` VB
Public Class Paths
```

**VB Usage**<br />
``` VB Usage
Dim instance As Paths
```

**C++**<br />
``` C++
public ref class Paths
```

**F#**<br />
``` F#
type Paths =  class end
```

The Paths type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_IO_Paths__ctor">Paths()</a></td><td>
Load Default Furcadia Paths</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_IO_Paths__ctor_1">Paths(String)</a></td><td>
Load Paths Based on *path*</td></tr></table>&nbsp;
<a href="#paths-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_CachePath">CachePath</a></td><td>
Cache path - contains all the Furcadia cache and resides in the global user space. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_CharacterPath">CharacterPath</a></td><td> **Obsolete. **
Character file path - contains furcadia.ini files with login information for each character. 

 Default: My Documents\Furcadia\Furcadia Characters\</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultCachePath">DefaultCachePath</a></td><td>
c:\Program Data\</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultCharacterPath">DefaultCharacterPath</a></td><td> **Obsolete. **
Default Character Path</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultDreamsPath">DefaultDreamsPath</a></td><td>
Personal Dreams Folder</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultFurcadiaPath">DefaultFurcadiaPath</a></td><td>
Default Furcadia install folder - this path is used by default to install Furcadia to. 

 Default: c:\Program Files\Furcadia</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultGlobalMapsPath">DefaultGlobalMapsPath</a></td><td>
Main Maps Default path</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultGlobalSkinsPath">DefaultGlobalSkinsPath</a></td><td>
default skins</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultLocalSkinsPath">DefaultLocalSkinsPath</a></td><td>
default local skins</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultLogsPath">DefaultLogsPath</a></td><td> **Obsolete. **
default personal log folder</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultPatchPath">DefaultPatchPath</a></td><td>
Path to the default patch (graphics, sounds, layout) folder used to display Furcadia itself, its tools and environment. 

 Default: c:\Program Files\Furcadia\patches\default</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultPermanentMapsCachePath">DefaultPermanentMapsCachePath</a></td><td>
Default Main Maps</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultPersonalDataPath">DefaultPersonalDataPath</a></td><td>
Default Documents\Furcadia</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultPortraitCachePath">DefaultPortraitCachePath</a></td><td>
Portrait cache</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultScreenshotsPath">DefaultScreenshotsPath</a></td><td>
Furcadia Screen Shots default folder</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultSettingsPath">DefaultSettingsPath</a></td><td>
User App Data Settings</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultTemporaryDreamsPath">DefaultTemporaryDreamsPath</a></td><td>
Temporary dreams</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultTemporaryFilesPath">DefaultTemporaryFilesPath</a></td><td>
Default Temporary Files</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultTemporaryPatchesPath">DefaultTemporaryPatchesPath</a></td><td>
Temporary patches</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DefaultWhisperLogsPath">DefaultWhisperLogsPath</a></td><td> **Obsolete. **
Whisper Logs</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_DreamsPath">DreamsPath</a></td><td>
Dreams path - contains Furcadia dreams made by the player. Default: My Documents\Furcadia\Dreams</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_FurcadiaLocaldirPath">FurcadiaLocaldirPath</a></td><td>
Furcadia Localdir path - this path (when explicitly set), indicates the whereabouts of the data files used in Furcadia. If localdir.ini is present in the Furcadia folder, Furcadia.exe will load those files from the specific path and not the regular ones. Default: -NONE-</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_FurcadiaPath">FurcadiaPath</a></td><td>
Furcadia install path - this path corresponds to the path where Furcadia is installed on the current machine. If Furcadia is not found, this property will be null.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_GlobalMapsPath">GlobalMapsPath</a></td><td>
Path to the global maps, distributed with Furcadia and loadable during game play in some main dreams. 
Default: c:\Program Files\Furcadia\maps</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_GlobalSkinsPath">GlobalSkinsPath</a></td><td>
Path to the global skins that change Furcadia's graphical layout. They are stored in the Furcadia program files folder. 
Default: c:\Program Files\Furcadia\skins</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_LocaldirPath">LocaldirPath</a></td><td>
LocalDir path - a specific path where all the player-specific and cache data is stored in its classic form. Used mainly to retain the classic path structure or to run Furcadia from a removable disk.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_LocalSkinsPath">LocalSkinsPath</a></td><td>
Local skins path - contains Furcadia skins used locally by each user. 
Default: My Documents\Furcadia\Skins</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_LogsPath">LogsPath</a></td><td> **Obsolete. **
Logs path - contains session logs for each character and a sub-folder with whisper logs, should Pounce be enabled. 
Default: My Documents\Furcadia\Logs</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_PermanentMapsCachePath">PermanentMapsCachePath</a></td><td>
Permanent Maps cache path - contains downloaded main maps such as the festival maps or other DEP-specific customized dreams. 
Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Permanent Maps</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_PersonalDataPath">PersonalDataPath</a></td><td>
Personal data path - contains user-specific files such as logs, patches, screen shots and character files. 
Default: My Documents\Furcadia\</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_PortraitCachePath">PortraitCachePath</a></td><td>
Portrait cache path - contains downloaded portraits and desctags cache for faster loading and bandwidth optimization. 
Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Portrait Cache</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_ScreenshotsPath">ScreenshotsPath</a></td><td>
Screen shots path - contains screen shot files taken by Furcadia with the CTRL+F1 hotkey. At the time of writing, in PNG format. 
Default: My Documents\Furcadia\Screenshots</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_SettingsPath">SettingsPath</a></td><td>
Personal settings path - contains all the Furcadia settings for each user that uses it. 

 Default (VISTA+): %USERPROFILE%\Local\AppData\Dragon's Eye Productions\Furcadia</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_TemporaryDreamsPath">TemporaryDreamsPath</a></td><td>
Temporary dreams path - contains downloaded player dreams for subsequent loading. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Dreams</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_TemporaryFilesPath">TemporaryFilesPath</a></td><td>
Temporary files path - contains downloaded and uploaded files that are either used to upload packages or download them for extraction. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Files</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_TemporaryPatchesPath">TemporaryPatchesPath</a></td><td>
Temporary patch path - contains downloaded temporary patches. This technology is never in use, yet supported, so this folder is always empty. 

 Default: %ALLUSERSPROFILE%\Dragon's Eye Productions\Furcadia\Temporary Patches</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_UsingLocaldir">UsingLocaldir</a></td><td>
Has LoclDir.ini been detected?</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Furcadia_IO_Paths_WhisperLogsPath">WhisperLogsPath</a></td><td> **Obsolete. **
Whisper logs path - contains whisper logs for each character whispered, recorded by Pounce with the whisper windows. Default: My Documents\Furcadia\Logs\Whispers</td></tr></table>&nbsp;
<a href="#paths-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_IO_Paths_GetDefaultPatchPath">GetDefaultPatchPath</a></td><td>
Find the path to the default patch folder on the current machine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_IO_Paths_GetFurcadiaInstallPath">GetFurcadiaInstallPath</a></td><td>
Find the path to Furcadia data files currently installed on this system.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_IO_Paths_GetFurcadiaLocaldirPath">GetFurcadiaLocaldirPath</a></td><td>
Find the current localdir path where data files would be stored on the current machine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#paths-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#paths-class">Back to Top</a>

## Remarks
Theory check all known default paths 
check localdir.ini

then check each registry hives for active CPU type

Then check each give for default 32bit path(Non wow6432node)

then check Wine variants(C++ Win32 client)

then check Mono Versions for before mentioned(C#? Client)

then check default drive folder paths

If all Fail... Throw <a href="T_Furcadia_IO_FurcadiaNotFoundException">FurcadiaNotFoundException</a> exception

Clients Should check for this error and then ask the user where to manually locate Furccadia


## See Also


#### Reference
<a href="N_Furcadia_IO">Furcadia.IO Namespace</a><br />