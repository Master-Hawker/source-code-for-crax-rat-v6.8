// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ScreenLoger
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ScreenLoger : Form
  {
    internal virtual TextBox Logs
    {
      get => ((ScreenShoter) this)._Logs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Logs = value;
    }

    public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsfewxc()
    {
      ((PermissionsManager.updatedele) this).InitializeComponent();
    }

    public ScreenLoger()
    {
label_1:
      int num1 = 1572266803;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 * -900711743 ^ -~(-43665521 * (-669808856 * 152386503))) ^ -(542385335 + 1318013354)) * 2098156225 - 1343343244)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsfewxc();
            num1 = (int) num2 * 657702834 ^ -1656787285;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public ScreenLoger()
    {
      this.Load += new EventHandler(((ScreenReader) this).CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq);
      this.FormClosing += new FormClosingEventHandler(((ScreenReader) this).ScreenReader_FormClosing);
      ((ScreenShoter) this).Title = EXGuarder.\u0033A6C0655;
      ((ScreenShoter) this).firstclick = (object) true;
      ((ScreenShoter) this).tiks = 0;
      ((ScreenShoter) this).Swaping = false;
      ((ScreenShoter) this).isdown = false;
      ((ScreenShoter) this).isclick = false;
      ((ScreenReader) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -621194404;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(~num1 - (112887631 - 1526573505)) - 1600317488) - -971282127)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((ScreenShoter) this).components.Dispose();
              num1 = (int) num2 * 1847134438 ^ 1467955259;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = ((ScreenShoter) this).components == null ? 1000457761 : (num3 = 1585227546);
              num1 = num3 ^ (int) num2 * -831297116;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
      finally
      {
        base.Dispose(disposing);
      }
    }
  }
}
