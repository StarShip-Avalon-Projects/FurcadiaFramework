# ServerInstructionType Enumeration
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Server to Client Instruction set. (Furcadia v31c) 
This is the set that FF3PP understands and uses.

these can change with each Furcadia update.


**Namespace:**&nbsp;<a href="N_Furcadia_Net">Furcadia.Net</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public enum ServerInstructionType
```

**VB**<br />
``` VB
Public Enumeration ServerInstructionType
```

**VB Usage**<br />
``` VB Usage
Dim instance As ServerInstructionType
```

**C++**<br />
``` C++
public enum class ServerInstructionType
```

**F#**<br />
``` F#
type ServerInstructionType
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.Unknown">**Unknown**</td><td>-1</td><td>Unknown Instruction, 
Needs further research</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.None">**None**</td><td>0</td><td>No instruction Nessary</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.SpawnAvatar">**SpawnAvatar**</td><td>1</td><td>Spawns a new Furre in the dream furre list because they have joing the Dream we're in 

 '<' + user id + x + y + shape number + name + color code + flag + linefeed 

 sender object is Type SpawnAvatar()</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.RemoveAvatar">**RemoveAvatar**</td><td>2</td><td>Remove the Avatar from the Dream Furre list because they have left the dream 

 ')' + user id + linefeed 

 Source: Furcatia Technical Resources 

 sender object is Type RemoveAvatar()</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.HideAvatar">**HideAvatar**</td><td>3</td><td>Hide Avatar from display (Invisible?)</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.AnimatedMoveAvatar">**AnimatedMoveAvatar**</td><td>4</td><td>Move and animate the Active Furre to the next location 

 sender object is Type Furre()</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.MoveAvatar">**MoveAvatar**</td><td>5</td><td>Move the current active furre to the next locatiomn 

 sender object is Type Furre</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.DisplayText">**DisplayText**</td><td>6</td><td>Display formated Text. 
Mostly Furcadia Markup but other stuff too</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.UpdateColorString">**UpdateColorString**</td><td>7</td><td>Update the Triggering Furre ColorCode 
'B' + user id + shape + color code + linefeed</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.LoadDreamEvent">**LoadDreamEvent**</td><td>8</td><td>Download Dream Data 
IE: ]q pmnaiagreen 3318793420 modern

respond with client command when furcadia client is not available "vasecodegamma"</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.UniqueUserId">**UniqueUserId**</td><td>9</td><td>Unique User ID 

]z UID[*] 

This instruction is sent as a response to the uid command. The purpose of this is unclear. 

 Credits Artex, FTR</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.SetOwnId">**SetOwnId**</td><td>10</td><td>Set Own ID 

 ]BUserID[*] 

This instruction informs the client of which user-name is it logged into. Knowing your own UserID can help you find your own avatar within the dream. 

Credits Artex, FTR</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.BookmarkDream">**BookmarkDream**</td><td>11</td><td>Dream Book Mark 

Triggers Pounce to add the dream to the list marked temporary</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.LookResponse">**LookResponse**</td><td>12</td><td>received after a look at furre command 

 sender object is Type Furre</td></tr><tr><td /><td target="F:Furcadia.Net.ServerInstructionType.EnterDream">**EnterDream**</td><td>13</td><td>Entering a new dream</td></tr></table>

## See Also


#### Reference
<a href="N_Furcadia_Net">Furcadia.Net Namespace</a><br />