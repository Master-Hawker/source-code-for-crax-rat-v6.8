// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.RefreshExplorer
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
  internal sealed class RefreshExplorer
  {
    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SHGetFileInfo(
      string pszPath,
      int dwFileAttributes,
      ref getIconFrmReg.SHFILEINFO psfi,
      int cbFileInfo,
      int uFlags);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool DestroyIcon(IntPtr hIcon);

    [Flags]
    public enum HChangeNotifyFlags
    {
    }

    [Flags]
    public enum HChangeNotifyEventID
    {
      AC_SRC_OVER = 0,
      ULW_ALPHA = 2,
    }
  }
}
