// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Notifications
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using System.Drawing;

#nullable disable
namespace Craxs_Rat
{
  public sealed class Notifications
  {
    public string Check_Json;
    public string Checkv2_Json;
    public string Session;
    public string IDC_Json;
    public string Secritkey;

    static Notifications()
    {
      Settings.po1 = new Point();
label_1:
      int num1 = 1910899173;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-~~~num1 * 1685213029)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            Settings.po2 = new Point();
            num1 = (int) num2 * 210529255 ^ 247691283;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }
  }
}
