# SleepEx

[C#] kernel32.dll SleepEx Windows-API. 

Simple console-program to sleep the exact amount of milliseconds by the passed-argument, 
accuracy still depends on CPU clock.

Accepting values from 0 (thread-yield) to a 32bit number. 

Exit codes are 0(success sleep or I/O interrupt such as CTRL+C) or 1 for invalid value 
(program will still "sleeps" for 0 seconds). 

Will not freeze window since it uses SleepEx from kernel32.dll (https://msdn.microsoft.com/en-us/library/windows/desktop/ms686307(v=vs.85).aspx) with bAlertable set to true. 

Include program-icon and manifest from https://github.com/eladkarako/manifest .

Binaries included.
