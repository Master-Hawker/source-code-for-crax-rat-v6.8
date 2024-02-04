// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.MyWebClient
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using System;
using System.Net;
using System.Runtime.InteropServices;

#nullable disable
namespace Craxs_Rat
{
  public class MyWebClient : WebClient
  {
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CheckRemoteDebuggerPresent(
      IntPtr hProcess,
      [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);
  }
}
