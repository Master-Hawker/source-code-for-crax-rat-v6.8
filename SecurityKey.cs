// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.SecurityKey
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class SecurityKey
  {
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_DRIVEREMOVED = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_EXTENDED_EVENT = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_FREESPACE = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_MEDIAINSERTED = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_MEDIAREMOVED = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_MKDIR = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_NETSHARE = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_NETUNSHARE = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_RENAMEFOLDER = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_RENAMEITEM = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_RMDIR = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_SERVERDISCONNECT = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_UPDATEDIR = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_UPDATEIMAGE = ; // Unable to render the field
    public static byte f0053E1;
    private const int SHGFI_ICON = 256;
    public static byte f0053E3;
    private const int FILE_ATTRIBUTE_NORMAL = 128;
    public static byte f0053E5;
    private const int SHGFI_SMALLICON = 1;
    public IntPtr hIcon;
    public int iIcon;
    public int dwAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    public string szTypeName;
    [SpecialName]
    public int value__;
    public const getIconFrmReg.IconSize SHGFI_LARGEICON = ; // Unable to render the field
    public const getIconFrmReg.IconSize SHGFI_SMALLICON = ; // Unable to render the field
    public IntPtr hIcon;
    public int iIcon;
    public int dwAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    public string szTypeName;
    private IContainer components;

    public static string Key()
    {
      checked { ++Client.count; }
      return Conversions.ToString(Client.count) + SecurityKey.GenRandom(3) + Conversions.ToString(DateTime.Now.Millisecond);
    }

    public static string GenRandom(int Length)
    {
      string str1 = (string) null;
label_1:
      int num1 = 577459556;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int num4;
        int num5;
        string str2;
        switch ((num3 = (uint) ~-(~((377907485 * 1122855455 + (803826420 - 216447669) - (~1691134198 - (1692700867 ^ 1459545063)) ^ -226552305 * (9407988 + ~-714876274)) - num2 * -1499366375) * 527020939)) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            num5 = Length;
            num4 = 1;
            num1 = (int) num3 * -1893998470 ^ -1509011021;
            continue;
          case 2:
            Thread.Sleep(5);
            num1 = 380622851;
            continue;
          case 3:
            Random random = new Random(DateAndTime.Now.Millisecond);
            str1 += Conversions.ToString(str2[random.Next(0, str2.Length)]);
            checked { ++num4; }
            num1 = (int) num3 * 1190941993 ^ -1013547516;
            continue;
          case 5:
            num1 = (int) num3 * -650287261 ^ -660933088;
            continue;
          case 6:
            str2 = EXGuarder.\u0030B55631C;
            num1 = (int) num3 * -1027460428 ^ -1033984891;
            continue;
          case 7:
            int num6;
            num1 = num6 = num4 <= num5 ? -553772816 : (num6 = 1411612902);
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return str1;
    }

    public SecurityKey()
      : this()
    {
label_1:
      int num1 = 528704112;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-((num1 ^ ~~-177141571 - 1675246983 * -1579663362 * -766992335 - (--204424321 * -170201187 - 13405866) ^ -(~932517852 + (1120284682 - 46817341 ^ 2047427466))) + (~-1669001957 + --586311718 * 1714210549 ^ 2144899258 - -1746567335 ^ -2021625161 - -1058176918 ^ -228830971 * (97074306 - -1343603466)) - (~65461470 - (1178490114 - 1140848753)) * -1402840163)) % 8U)
        {
          case 0:
            ((Client) this).CareatSize = new Size(6, 12);
            num1 = (int) num2 * -2060770045 ^ 2121330938;
            continue;
          case 1:
            ((Client) this).Title = EXGuarder.\u003003D2B6C;
            ((Client) this).rect = new Rectangle();
            num1 = (int) num2 * 1090077292 ^ -1148725247;
            continue;
          case 2:
            goto label_3;
          case 3:
            ((Client) this).ignore = false;
            ((Client) this).IAMNew = true;
            ((ShellTerminal) this).InitializeComponent();
            num1 = (int) num2 * -288493525 ^ -598120770;
            continue;
          case 4:
            ((Client) this).hidCareat = -1;
            num1 = (int) num2 * 653728879 ^ -741545963;
            continue;
          case 5:
            ((Client) this).TAGx = EXGuarder.\u003433F722F;
            num1 = (int) num2 * 619528159 ^ 1056744751;
            continue;
          case 6:
            goto label_1;
          case 7:
            ((Form) this).Load += new EventHandler(((ShellTerminal) this).ShellTerminal_Load);
            num1 = (int) num2 * -320540324 ^ -896964934;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:;
    }

    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1874956988;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 * -2049136401 ^ ~(828922229 * ~1210152288)) * 1097214457 ^ -~1460583595) * 393772409 - -1262483862)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num3 = ((Client) this).components == null ? -924689827 : (num3 = 235860035);
              num1 = num3 ^ (int) num2 * -210542160;
              continue;
            case 3:
              ((Client) this).components.Dispose();
              num1 = (int) num2 * 315570499 ^ -1766872804;
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
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Form) this).Dispose(disposing));
      }
    }
  }
}
