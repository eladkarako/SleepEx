#region Using directives
using System;
using System.Reflection;
using System.Runtime.InteropServices;

#endregion
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle ("SleepEx")]
[assembly: AssemblyDescription ("A Program to get a number from the command-line-argument and sleep its exactly-value. Number should be positive number from 0 up to a 32bit number, incalid cases will fallback to sleeping with the value 0, value is milliseconds, 5000 will sleep 5 seconds. Note that sleep-accuracy depands on the CPU clock, so values such as 1234 will not say the program will actually sleep for that amount of milliseconds exactly. Sleeping 0 is like yeild the current thread. I/O will not be blocked during the sleep. Exit codes are 0 for success sleep or if I/O break before sleep finished (CTRL+C for example), 1 is for an invalid value (sleep will still be executed with value 0).")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("Elad Karako")]
[assembly: AssemblyProduct ("SleepEx")]
[assembly: AssemblyCopyright ("UnLicensed (Public Domain). 2018. ")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible (false)]
// The assembly version has following format :
//
// Major.Minor.Build.Revision
//
// You can specify all the values or you can use the default the Revision and 
// Build Numbers by using the '*' as shown below:
[assembly: AssemblyVersion ("1.0.*")]
[assembly: Guid ("63009fff-e6b4-461c-8615-cca8c85ff6e9")]
