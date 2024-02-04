// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Notif_Sound
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class Notif_Sound
  {
    public static VB\u0024AnonymousDelegate_0 \u0024I228\u002D4;
    public static VB\u0024AnonymousDelegate_0 \u0024I229\u002D0;
    public static VB\u0024AnonymousDelegate_0 \u0024I229\u002D1;
    public static VB\u0024AnonymousDelegate_0 \u0024I229\u002D2;
    public static VB\u0024AnonymousDelegate_0 \u0024I229\u002D3;

    public Notif_Sound()
    {
label_1:
      int num1 = -517828114;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --(num1 ^ (-(-206933612 ^ 2013211486 ^ 2140848918 - -2001474396) ^ -(-530914226 - 2028278006) + (668520424 ^ 115662227 ^ 183870117 - 932693739)) - (~~(1162928288 + 171792661) - -490175524))) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            ((Settings) this).Snds = new Dictionary<string, string>();
            num1 = (int) num2 * 609635530 ^ 1284894489;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ((Settings) this).sndcnt = 0;
    }

    [DllImport("winmm.dll")]
    private static extern int mciSendStringW(
      [MarshalAs(UnmanagedType.LPTStr)] string lpszCommand,
      [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszReturnString,
      uint cchReturn,
      IntPtr hwndCallback);
  }
}
