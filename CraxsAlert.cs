// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CraxsAlert
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.Management;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class CraxsAlert
  {
    public static void ShowWarning(string msg)
    {
      alertform alertform = new alertform(msg);
label_1:
      int num1 = -1832876039;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 * -174618599) ^ -((333572384 ^ -437735140) * -537543029))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            alertform.backpanel.FillColor = Color.Black;
            alertform.lidlamb.ForeColor = Color.Orange;
            num1 = (int) num2 * -1768455261 ^ 900047331;
            continue;
          case 2:
            alertform.alertimage.Image = (Image) Craxs_Rat.My.Resources.Resources.warning48px;
            num1 = (int) num2 * 524887098 ^ 1629101298;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      alertform.backpanel.RectColor = Color.Orange;
      alertform.Show();
    }

    public static void Showinformation(string msg)
    {
      alertform alertform = new alertform(msg);
label_1:
      int num1 = -814690168;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~~~(num1 * -515577221) + -1492611641 * -1877579841) * -360248177)) % 5U)
        {
          case 0:
            alertform.backpanel.RectColor = Color.LightSkyBlue;
            num1 = (int) num2 * 1971188413 ^ -1934068543;
            continue;
          case 1:
            alertform.alertimage.Image = (Image) Craxs_Rat.My.Resources.Resources.information48px;
            alertform.backpanel.FillColor = Color.Black;
            alertform.lidlamb.ForeColor = Color.LightSkyBlue;
            num1 = (int) num2 * 1781671027 ^ -378951439;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            alertform.Show();
            num1 = (int) num2 * -1941178488 ^ 1267315054;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public static void ShowError(string msg)
    {
      alertform alertform = new alertform(msg);
      alertform.alertimage.Image = (Image) Craxs_Rat.My.Resources.Resources.error48px;
      alertform.backpanel.FillColor = Color.Black;
      alertform.lidlamb.ForeColor = Color.Red;
      alertform.backpanel.RectColor = Color.Red;
      alertform.Show();
    }

    public static string GetSerialNumber()
    {
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery) new SelectQuery(EXGuarder.\u0037169753E));
      ManagementObjectCollection.ManagementObjectEnumerator enumerator;
      string serialNumber;
      try
      {
        enumerator = managementObjectSearcher.Get().GetEnumerator();
        if (enumerator.MoveNext())
          goto label_5;
label_2:
        int num1 = -131342681;
label_3:
        ManagementObject current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((~num1 ^ -781105180 ^ ~(1782126269 - 1047305980 ^ 1680241343 - -1267567576)) * -507429407)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_5;
            case 4:
              serialNumber = current[EXGuarder.\u0036550064F].ToString();
              num1 = (int) num2 * -1995871381 ^ -2029730136;
              continue;
            default:
              goto label_11;
          }
        }
label_5:
        current = (ManagementObject) enumerator.Current;
        num1 = 1780092126;
        goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
label_7:
          int num3 = 1848511427;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) -((~num3 ^ -781105180 ^ ~(1782126269 - 1047305980 ^ 1680241343 - -1267567576)) * -507429407)) % 3U)
            {
              case 1:
                enumerator.Dispose();
                num3 = (int) num4 * -632256544 ^ 70811545;
                continue;
              case 2:
                goto label_7;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      return serialNumber;
    }
  }
}
