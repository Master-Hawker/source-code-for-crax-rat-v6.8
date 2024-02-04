// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.DebugProtect1
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Craxs_Rat
{
  internal class DebugProtect1
  {
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool IsDebuggerPresent();

    public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatshrtrthrthdrfxc()
    {
    }

    static DebugProtect1()
    {
      RegistryHandler.mainpath = EXGuarder.\u003244F5C3B;
label_1:
      int num1 = -1181343807;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-~-(num1 - (~-478341824 ^ --((157626916 ^ 1547567784) - -892834885)))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            ZoomPictureBox.ShowScrenShotTip = EXGuarder.\u0034014745E;
            num1 = (int) num2 * -570181961 ^ 1831363648;
            continue;
          case 3:
            ZoomPictureBox.ShowScrenReadTip = EXGuarder.\u00363540248;
            num1 = (int) num2 * 733939268 ^ 877654222;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      ZoomPictureBox.Selectedsound = EXGuarder.\u0030A016D57;
      ZoomPictureBox.Selectedqulity = EXGuarder.\u0032F0F2C2C;
    }

    public static void iniliz()
    {
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
        try
        {
          if (registryKey2 == null)
          {
label_2:
            int num1 = 1799249294;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (~(-(num1 * -957812179) - -1534326474) - 733844185 - 2062363241)) % 3U)
              {
                case 0:
                  goto label_2;
                case 2:
                  registryKey2 = registryKey1.CreateSubKey(RegistryHandler.mainpath);
                  num1 = (int) num2 * -447184813 ^ 1775379283;
                  continue;
                default:
                  goto label_6;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_6:
        registryKey2.Close();
label_7:
        int num3 = 1737073043;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~(-(num3 * -957812179) - -1534326474) - 733844185 - 2062363241)) % 3U)
          {
            case 0:
              goto label_17;
            case 1:
              registryKey1.Close();
              num3 = (int) num4 * 238473182 ^ -1484689341;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_15;
          }
        }
label_17:
        return;
label_15:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_13:
        int num5 = 1943537711;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) (~(-(num5 * -957812179) - -1534326474) - 733844185 - 2062363241)) % 3U)
          {
            case 0:
              goto label_13;
            case 1:
              goto label_11;
            case 2:
              ProjectData.ClearProjectError();
              num5 = (int) num6 * 1044818872 ^ -1443934345;
              continue;
            default:
              goto label_9;
          }
        }
label_11:
        return;
label_9:;
      }
    }
  }
}
