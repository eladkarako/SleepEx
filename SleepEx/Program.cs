using System;
using System.Runtime.InteropServices;

namespace SleepEx{
  public class Program{

    [DllImport("kernel32.dll")]
    static extern int SleepEx(
      UInt32 dwMilliseconds,
      bool bAlertable);

    [STAThread]
    public static void Main(string[] args){
      UInt32 value = 0;
      Environment.ExitCode = 1;

      try {
        value = Convert.ToUInt32(args[0]);
        Environment.ExitCode = 0;
      } catch (Exception) {}

      SleepEx(value, true);
    }
  }
}