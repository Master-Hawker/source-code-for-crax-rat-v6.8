// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CustomFontDrawString
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class CustomFontDrawString
  {
    internal int \u0024VB\u0024Local_interval;

    [DllImport("shell32.dll")]
    public static extern void SHChangeNotify(
      RefreshExplorer.HChangeNotifyEventID wEventID,
      RefreshExplorer.HChangeNotifyFlags uFlags,
      IntPtr dwItem1,
      IntPtr dwItem2);

    public static void EnvRefresh()
    {
      CustomFontDrawString.SHChangeNotify((RefreshExplorer.HChangeNotifyEventID) 134217728, (RefreshExplorer.HChangeNotifyFlags) 0, IntPtr.Zero, IntPtr.Zero);
    }
  }
}
