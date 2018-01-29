# ServerQue Constructor (Int32, UInt32)
This stuff is still in the planning stages. Any questions or Comments are welcome. _**\[This is preliminary documentation and is subject to change.\]**_

Queue Manager constructor

**Namespace:**&nbsp;<a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils</a><br />**Assembly:**&nbsp;FurcadiaLib (in FurcadiaLib.dll) Version: 2.19.PreAlpha 42

## Syntax

**C#**<br />
``` C#
public ServerQue(
	int ThroatTiredTime,
	uint PingTimerTime = 30
)
```

**VB**<br />
``` VB
Public Sub New ( 
	ThroatTiredTime As Integer,
	Optional PingTimerTime As UInteger = 30
)
```

**VB Usage**<br />
``` VB Usage
Dim ThroatTiredTime As Integer
Dim PingTimerTime As UInteger

Dim instance As New ServerQue(ThroatTiredTime, 
	PingTimerTime)
```

**C++**<br />
``` C++
public:
ServerQue(
	int ThroatTiredTime, 
	unsigned int PingTimerTime = 30
)
```

**F#**<br />
``` F#
new : 
        ThroatTiredTime : int * 
        ?PingTimerTime : uint32 
(* Defaults:
        let _PingTimerTime = defaultArg PingTimerTime 30
*)
-> ServerQue
```


#### Parameters
&nbsp;<dl><dt>ThroatTiredTime</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Delay time to pause for Throat Tired Syndrome</dd><dt>PingTimerTime (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/ctys3981" target="_blank">System.UInt32</a><br />Optional ping the game server time in seconds</dd></dl>

## See Also


#### Reference
<a href="T_Furcadia_Net_Utils_ServerQue">ServerQue Class</a><br /><a href="Overload_Furcadia_Net_Utils_ServerQue__ctor">ServerQue Overload</a><br /><a href="N_Furcadia_Net_Utils">Furcadia.Net.Utils Namespace</a><br />