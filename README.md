# DebugBreakF12

Demonstrates that when native debugging is enabled, the F12 key is no longer usable.

Instead, you get the following:

> A breakpoint instruction (__debugbreak() statement or a similar call) was executed in DebugBreakF12.exe.

The call stack does not permit to spot where this comes from:

```
>	ntdll.dll!DbgBreakPoint()	Unknown	Symbols loaded.
 	ntdll.dll!DbgUiRemoteBreakin()	Unknown	Symbols loaded.
 	kernel32.dll!BaseThreadInitThunk()	Unknown	Symbols loaded.
 	ntdll.dll!RtlUserThreadStart()	Unknown	Symbols loaded.
```

Trying to play with the value of [AeDebug](https://learn.microsoft.com/en-us/previous-versions/windows/it-pro/windows-2000-server/cc939482(v=technet.10)) in registry in order to disable this has no effect.

Environment:
- Microsoft Windows [Version 10.0.19044.2251]
- OpenTK 4.7.5
- Visual Studio 2022, Version 17.4.1, VisualStudio.17.Release/17.4.1+33110.190
