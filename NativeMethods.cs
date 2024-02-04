// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.NativeMethods
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

#nullable disable
namespace Craxs_Rat
{
  public class NativeMethods
  {
    [DllImport("user32.dll", SetLastError = true)]
    internal static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("gdi32.dll")]
    internal static extern IntPtr CreateCompatibleDC(IntPtr dc);

    [DllImport("gdi32.dll")]
    internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObj);

    [DllImport("gdi32.dll")]
    internal static extern IntPtr DeleteDC(IntPtr dc);

    [DllImport("gdi32.dll")]
    internal static extern IntPtr DeleteObject(IntPtr hObj);

    public unsafe NativeMethods(byte alpha)
    {
      *(NativeMethods.BLENDFUNCTION*) this = new NativeMethods.BLENDFUNCTION();
      ((RefreshExplorer.HChangeNotifyEventID) this).BlendOp = (byte) 0;
      ((RefreshExplorer.HChangeNotifyEventID) this).BlendFlags = (byte) 0;
      ((RefreshExplorer.HChangeNotifyEventID) this).SourceConstantAlpha = alpha;
      ((RefreshExplorer.HChangeNotifyEventID) this).AlphaFormat = (byte) 1;
    }

    public NativeMethods() => ((getIconFrmReg) this).sizeHeight = MyProject.Forms.Report.Height;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BLENDFUNCTION
    {
      static BLENDFUNCTION()
      {
        // ISSUE: reference to a compiler-generated method
        getIconFrmReg.SHFILEINFO.FLAGS_PERFORMANCE = MySettings.get_Settings().performance;
        // ISSUE: reference to a compiler-generated method
        getIconFrmReg.SHFILEINFO.LOCATION_NOTICETIGHT = MySettings.get_Settings().location;
        // ISSUE: reference to a compiler-generated method
        getIconFrmReg.SHFILEINFO.SOHW_ALERT = MySettings.get_Settings().show_alert;
label_1:
        int num1 = 1500624568;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-num1 + ~~((1428941697 ^ -1840228352) + --1565091111))) % 10U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.SHFILEINFOW.SAVING_DATA = MySettings.get_Settings().Saving_data;
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.SHFILEINFOW.CAM_Quality = MySettings.get_Settings().CAMQuality;
              getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground = Color.White;
              Settings.DefaultColor_Background = Color.FromArgb(40, 40, 40);
              Settings.DefaultColor_ColorTitles = Color.Blue;
              Settings.DefaultColor_NewColorFiles = Color.Red;
              num1 = (int) num2 * -658908381 ^ -699255415;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              Settings.NOTI_SOUND = MySettings.get_Settings().NOTI_SOUND;
              // ISSUE: reference to a compiler-generated method
              Settings.FLAGS_Visible = MySettings.get_Settings().Flags_Visible;
              // ISSUE: reference to a compiler-generated method
              Settings.FLAGS_Size = MySettings.get_Settings().Flags_Size;
              num1 = (int) num2 * 1978133852 ^ 1500000257;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.SHFILEINFOW.EFFECTS_CAM = MySettings.get_Settings().Effects_CAM;
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.SHFILEINFOW.STYLE_MAPS = MySettings.get_Settings().Style_Maps;
              num1 = (int) num2 * 1575183318 ^ 815215189;
              continue;
            case 4:
              goto label_1;
            case 5:
              Settings.ColumnsIndex = EXGuarder.\u00357297619;
              num1 = (int) num2 * -1947088268 ^ 1875660164;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated method
              Settings.NOTI_Round = MySettings.get_Settings().Round;
              num1 = (int) num2 * 2092153493 ^ -2001098566;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.IconSize.ENCODING8 = MySettings.get_Settings().encoding8;
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.IconSize.DISCONNECTED = MySettings.get_Settings().disconnected;
              num1 = (int) num2 * -750534309 ^ -339948924;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated method
              getIconFrmReg.IconSize.AUTO_FOCUS = MySettings.get_Settings().Auto_focus;
              num1 = (int) num2 * 909742410 ^ 1344155756;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated method
              Settings.SC_Status = MySettings.get_Settings().SStatus_Visible;
              // ISSUE: reference to a compiler-generated method
              Settings.FM_IC_Size = MySettings.get_Settings().FM_IC_Size;
              // ISSUE: reference to a compiler-generated method
              Settings.vRemoving_Duplicates = (object) MySettings.get_Settings().Removing_Duplicates;
              num1 = (int) num2 * 1356712541 ^ -1611560635;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        Settings.T_Interval = 1;
      }
    }

    internal struct RECT
    {
      private Random r;
      public string Ping_Json;
    }
  }
}
