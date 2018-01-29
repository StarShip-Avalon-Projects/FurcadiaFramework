# FurcadiaMarkup Class
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Furcadia Markup Language (FML) REGEX


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Furcadia.Text.FurcadiaMarkup<br />
**Namespace:**&nbsp;<a href="N_Furcadia_Text">Furcadia.Text</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public sealed class FurcadiaMarkup
```

**VB**<br />
``` VB
Public NotInheritable Class FurcadiaMarkup
```

**VB Usage**<br />
``` VB Usage
Dim instance As FurcadiaMarkup
```

**C++**<br />
``` C++
public ref class FurcadiaMarkup sealed
```

**F#**<br />
``` F#
[<SealedAttribute>]
type FurcadiaMarkup =  class end
```

The FurcadiaMarkup type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Furcadia_Text_FurcadiaMarkup__ctor">FurcadiaMarkup</a></td><td>
Initializes a new instance of the FurcadiaMarkup class</td></tr></table>&nbsp;
<a href="#furcadiamarkup-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Furcadia_Text_FurcadiaMarkup_ChannelTag">ChannelTag</a></td><td>
Format Channel Tags 
<channel name='@channelname' /></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#furcadiamarkup-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_ChannelNameFilter">ChannelNameFilter</a></td><td>
Dynamic Channel tags 
<channel name='@channelName' / ></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_CookieToMeREGEX">CookieToMeREGEX</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_DescFilter">DescFilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_DescTagRegex">DescTagRegex</a></td><td>
Pesky Desc tags filter</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_DiceFilter">DiceFilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_EmoteRegexFilter">EmoteRegexFilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_FontChannelFilter">FontChannelFilter</a></td><td>


 font = 1 

 system.fhs =2 

 system alt = 3 

 Channel Name = 4 

 Text = 5</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_Iconfilter">Iconfilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_NameFilter">NameFilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_NameRegex">NameRegex</a></td><td>
Filter the Name Markup</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_QueryCommand">QueryCommand</a></td><td>
Queries (join, summon, lead follow, cuddle)</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_ShoutRegexFilter">ShoutRegexFilter</a></td><td /></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_UrlFilter">UrlFilter</a></td><td>
Regex for working with HTML URLS</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_WhisperRegex">WhisperRegex</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_YouEatCookieFilter">YouEatCookieFilter</a></td><td /></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_YouSayFilter">YouSayFilter</a></td><td></td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_YouShoutFilter">YouShoutFilter</a></td><td /></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Furcadia_Text_FurcadiaMarkup_YouWhisperRegex">YouWhisperRegex</a></td><td>
Whispers Name</td></tr></table>&nbsp;
<a href="#furcadiamarkup-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsDouble">AsDouble</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt16">AsInt16</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt32">AsInt32</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsInt64">AsInt64</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Furcadia_Extensions_ObjectExtensions_AsString">AsString</a></td><td> (Defined by <a href="T_Furcadia_Extensions_ObjectExtensions">ObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#furcadiamarkup-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Furcadia_Text">Furcadia.Text Namespace</a><br />