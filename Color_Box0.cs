// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Color_Box0
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Color_Box0 : Form
  {
    private bool BoxTitlePaintEventArgsWait;
    public static readonly CallsManager._Closure\u0024__ \u0024I;
    public static WaitCallback \u0024IR77\u002D1;
    public static WaitCallback \u0024IR78\u002D2;
    private IContainer components;

    internal virtual PictureBox C_Box3
    {
      get => ((CraxsSettings) this)._C_Box3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._C_Box3 = value;
    }

    internal virtual PictureBox C_Box2
    {
      get => ((CraxsSettings) this)._C_Box2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.C_Box2_Paint);
label_1:
        int num1 = -665278531;
        PictureBox cBox2;
        MouseEventHandler mouseEventHandler1;
        MouseEventHandler mouseEventHandler2;
        MouseEventHandler mouseEventHandler3;
        EventHandler eventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(((num1 ^ -~1900111138 * -734704547 + ((-677838275 ^ -1943748214) - -1657976750) * -1499845287 ^ --1669702809 + (129483611 * (790996148 ^ -1563335341) ^ -405350267 * -824255639 - 711144395)) + (1864649277 * -258225035 ^ -(1370118441 - 1314269951) ^ ~(1903747930 ^ 1378650213)) ^ 677700722 * 35176887 - (1907627415 - 326145266) + (-1510121464 ^ 2125662838) * 1320957117) - -~251868223)) % 15U)
          {
            case 0:
              cBox2.MouseUp -= mouseEventHandler3;
              cBox2.Click -= eventHandler;
              num1 = (int) num2 * 1958654142 ^ -186679441;
              continue;
            case 1:
              cBox2 = ((CraxsSettings) this)._C_Box2;
              int num3 = cBox2 == null ? -193674099 : (num3 = -633174820);
              num1 = num3 ^ (int) num2 * 269726528;
              continue;
            case 2:
              cBox2.MouseDown += mouseEventHandler2;
              cBox2.MouseMove += mouseEventHandler1;
              num1 = (int) num2 * 1700186663 ^ 240131160;
              continue;
            case 3:
              ((CraxsSettings) this)._C_Box2 = value;
              num1 = -62904167;
              continue;
            case 4:
              int num4 = cBox2 == null ? 585250899 : (num4 = 1390764996);
              num1 = num4 ^ (int) num2 * 1855001838;
              continue;
            case 5:
              goto label_1;
            case 6:
              cBox2.MouseMove -= mouseEventHandler1;
              num1 = (int) num2 * -850803048 ^ 812070891;
              continue;
            case 7:
              cBox2.Paint -= paintEventHandler;
              cBox2.MouseDown -= mouseEventHandler2;
              num1 = (int) num2 * 1223870855 ^ 923347702;
              continue;
            case 8:
              cBox2.MouseUp += mouseEventHandler3;
              cBox2.Click += eventHandler;
              num1 = (int) num2 * -1878903814 ^ 1795350469;
              continue;
            case 9:
              goto label_3;
            case 10:
              mouseEventHandler1 = new MouseEventHandler(this.C_Box2_MouseMove);
              num1 = (int) num2 * 1485408110 ^ 2071960215;
              continue;
            case 11:
              mouseEventHandler2 = new MouseEventHandler(this.C_Box2_MouseDown);
              num1 = (int) num2 * -410433726 ^ -772827226;
              continue;
            case 12:
              mouseEventHandler3 = new MouseEventHandler(this.C_Box2_MouseUp);
              eventHandler = new EventHandler(this.C_Box2_Click);
              num1 = (int) num2 * 733011492 ^ -1214602447;
              continue;
            case 13:
              cBox2.Paint += paintEventHandler;
              num1 = (int) num2 * -1359646080 ^ -142353860;
              continue;
            case 14:
              cBox2 = ((CraxsSettings) this)._C_Box2;
              num1 = (int) num2 * -345900100 ^ -266620991;
              continue;
            default:
              goto label_17;
          }
        }
label_3:
        return;
label_17:;
      }
    }

    internal virtual Button BTN_OK
    {
      get => ((CraxsSettings) this)._BTN_OK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BTN_OK_Click);
label_1:
        int num1 = -544619944;
        Button btnOk;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((-(num1 * 1944296071) ^ 1086436592) - --1058865195 * -901126875) * 680818943)) % 8U)
          {
            case 0:
              ((CraxsSettings) this)._BTN_OK = value;
              num1 = 1867158700;
              continue;
            case 1:
              goto label_3;
            case 2:
              btnOk = ((CraxsSettings) this)._BTN_OK;
              int num3 = btnOk == null ? 352045262 : (num3 = 1278298562);
              num1 = num3 ^ (int) num2 * 1373949996;
              continue;
            case 3:
              int num4 = btnOk == null ? 1829066428 : (num4 = -1268270570);
              num1 = num4 ^ (int) num2 * 1043417449;
              continue;
            case 4:
              btnOk.Click -= eventHandler;
              num1 = (int) num2 * -1450176913 ^ 3302698;
              continue;
            case 5:
              goto label_1;
            case 6:
              btnOk = ((CraxsSettings) this)._BTN_OK;
              num1 = (int) num2 * -1226245281 ^ 2103743771;
              continue;
            case 7:
              btnOk.Click += eventHandler;
              num1 = (int) num2 * 1902927203 ^ -414442374;
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

    internal virtual PictureBox C_Box0
    {
      get => ((CraxsSettings) this)._C_Box0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.C_Box0_Paint);
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.C_Box0_MouseDown);
label_1:
        int num1 = 1659168458;
        PictureBox cBox0;
        MouseEventHandler mouseEventHandler2;
        MouseEventHandler mouseEventHandler3;
        EventHandler eventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-~(num1 ^ ~(1218850797 * ~-1312203243) + --915052804 + (82671945 + ~-1652215171 - (-1699446459 - 2086114678 + ~2014952222) - (-1052519231 - -1665557342 - --511418528) * 380776247)) - 2042443625 * (-893617934 - 724295906))) % 14U)
          {
            case 0:
              cBox0.MouseUp -= mouseEventHandler3;
              num1 = (int) num2 * 672170722 ^ 1676278806;
              continue;
            case 1:
              cBox0.MouseDown -= mouseEventHandler1;
              cBox0.MouseMove -= mouseEventHandler2;
              num1 = (int) num2 * -686305965 ^ 552882357;
              continue;
            case 2:
              cBox0.Click -= eventHandler;
              num1 = (int) num2 * -1047851793 ^ 464653993;
              continue;
            case 3:
              cBox0.MouseDown += mouseEventHandler1;
              num1 = (int) num2 * -456195290 ^ 1234616678;
              continue;
            case 4:
              mouseEventHandler2 = new MouseEventHandler(this.C_Box0_MouseMove);
              num1 = (int) num2 * -1693023154 ^ 1734946063;
              continue;
            case 5:
              mouseEventHandler3 = new MouseEventHandler(this.C_Box0_MouseUp);
              eventHandler = new EventHandler(this.C_Box0_Click);
              num1 = (int) num2 * -735736069 ^ 752343728;
              continue;
            case 6:
              cBox0.Paint += paintEventHandler;
              num1 = (int) num2 * -1961236750 ^ -1451275325;
              continue;
            case 7:
              ((CraxsSettings) this)._C_Box0 = value;
              cBox0 = ((CraxsSettings) this)._C_Box0;
              int num3;
              num1 = num3 = cBox0 == null ? 1279781921 : (num3 = 1241343410);
              continue;
            case 8:
              cBox0.Paint -= paintEventHandler;
              num1 = (int) num2 * -1653805494 ^ 1943034299;
              continue;
            case 9:
              goto label_3;
            case 10:
              cBox0.MouseMove += mouseEventHandler2;
              cBox0.MouseUp += mouseEventHandler3;
              num1 = (int) num2 * 953400155 ^ -1942574935;
              continue;
            case 11:
              cBox0 = ((CraxsSettings) this)._C_Box0;
              int num4 = cBox0 == null ? 388887577 : (num4 = -1026649566);
              num1 = num4 ^ (int) num2 * 1119056414;
              continue;
            case 12:
              goto label_1;
            case 13:
              cBox0.Click += eventHandler;
              num1 = (int) num2 * -670047587 ^ -389525960;
              continue;
            default:
              goto label_16;
          }
        }
label_3:
        return;
label_16:;
      }
    }

    internal virtual System.Windows.Forms.Timer ti
    {
      get => ((CraxsSettings) this)._ti;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ti_Tick);
label_1:
        int num1 = -91579267;
        while (true)
        {
          int num2 = num1;
          uint num3;
          System.Windows.Forms.Timer ti;
          switch ((num3 = (uint) -(((1463087110 + --1528012437 + (-1059238909 ^ 559860391 ^ 926981493 - -1342142339) ^ ~(-180690877 * 1061586605) + (112227672 + 1125374959 ^ -2098108527)) - (num2 ^ ~(~-(-751090182 ^ -1918063365) ^ -595722621 - 1405031303 + --1488426706 + (-1488017358 ^ -428495331) * -1309394025))) * 1970147535)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              ti.Tick += eventHandler;
              num1 = (int) num3 * -875226292 ^ 231248064;
              continue;
            case 2:
              ti.Tick -= eventHandler;
              num1 = (int) num3 * 103118900 ^ -1104729040;
              continue;
            case 3:
              goto label_1;
            case 4:
              ti = ((CraxsSettings) this)._ti;
              num1 = (int) num3 * -1296753696 ^ 213573154;
              continue;
            case 5:
              ((CraxsSettings) this)._ti = value;
              ti = ((CraxsSettings) this)._ti;
              int num4;
              num1 = num4 = ti == null ? -331123960 : (num4 = 422045419);
              continue;
            case 6:
              int num5 = ti == null ? 413286677 : (num5 = -2081840767);
              num1 = num5 ^ (int) num3 * 250042751;
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

    internal virtual CheckBox CK1
    {
      get => ((CraxsSettings) this)._CK1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.CK1_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.CK1_MouseUp);
label_1:
        int num1 = 2093118405;
        CheckBox ck1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(~~~num1 - (-188880415 ^ -874618462))) % 8U)
          {
            case 0:
              ck1.MouseDown -= mouseEventHandler1;
              ck1.MouseUp -= mouseEventHandler2;
              num1 = (int) num2 * -514650893 ^ -157775935;
              continue;
            case 1:
              ck1.MouseDown += mouseEventHandler1;
              ck1.MouseUp += mouseEventHandler2;
              num1 = (int) num2 * 1803510256 ^ -1820118016;
              continue;
            case 2:
              ((CraxsSettings) this)._CK1 = value;
              ck1 = ((CraxsSettings) this)._CK1;
              num1 = -1171648225;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num3 = ck1 == null ? -387159216 : (num3 = -781851750);
              num1 = num3 ^ (int) num2 * 1708424728;
              continue;
            case 5:
              int num4 = ck1 == null ? -2018304023 : (num4 = 1146557331);
              num1 = num4 ^ (int) num2 * -1958112504;
              continue;
            case 6:
              ck1 = ((CraxsSettings) this)._CK1;
              num1 = (int) num2 * -115538905 ^ -571167484;
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

    internal virtual PictureBox BoxTitle
    {
      get => ((CraxsSettings) this)._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.BoxTitle_Resize);
label_1:
        int num1 = -56434969;
        PictureBox boxTitle;
        EventHandler eventHandler2;
        PaintEventHandler paintEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - (-1489927760 - -(1602774835 - -1836384402 ^ -301480000 ^ -1871396214) - (-1287001002 ^ -(-2129754222 - 4939685 + --1193794292)))) + -(1194509533 - 1812574803 - (-133860878 - 2010102259))) * 1130968279 - (1832779666 - -34412369))) % 13U)
          {
            case 0:
              goto label_1;
            case 1:
              boxTitle = ((CraxsSettings) this)._BoxTitle;
              num1 = (int) num2 * -1443273677 ^ -1024878044;
              continue;
            case 2:
              eventHandler2 = new EventHandler(this.BoxTitle_Click);
              boxTitle = ((CraxsSettings) this)._BoxTitle;
              num1 = (int) num2 * 143557937 ^ -798670686;
              continue;
            case 3:
              boxTitle.Click += eventHandler2;
              num1 = (int) num2 * 79976307 ^ -1391128572;
              continue;
            case 4:
              boxTitle.Resize -= eventHandler1;
              num1 = (int) num2 * 604706547 ^ -1854712971;
              continue;
            case 5:
              int num3 = boxTitle == null ? 623554816 : (num3 = -150195255);
              num1 = num3 ^ (int) num2 * 486914677;
              continue;
            case 6:
              int num4 = boxTitle == null ? 767365849 : (num4 = -1853711086);
              num1 = num4 ^ (int) num2 * 101009636;
              continue;
            case 7:
              boxTitle.Paint -= paintEventHandler;
              boxTitle.Click -= eventHandler2;
              num1 = (int) num2 * -738480048 ^ 2001027574;
              continue;
            case 8:
              goto label_3;
            case 9:
              boxTitle.Paint += paintEventHandler;
              num1 = (int) num2 * -109391767 ^ 1586069136;
              continue;
            case 10:
              ((CraxsSettings) this)._BoxTitle = value;
              num1 = 1000891274;
              continue;
            case 11:
              paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
              num1 = (int) num2 * -1739847337 ^ -1974070541;
              continue;
            case 12:
              boxTitle.Resize += eventHandler1;
              num1 = (int) num2 * 1039065498 ^ 2145074403;
              continue;
            default:
              goto label_15;
          }
        }
label_3:
        return;
label_15:;
      }
    }

    private void SpyStyle()
    {
      this.BoxTitle.BackColor = Settings.DefaultColor_Background;
      this.BackColor = Settings.DefaultColor_Background;
      IEnumerator<Button> enumerator1;
      try
      {
        enumerator1 = this.Controls.OfType<Button>().GetEnumerator();
label_2:
        int num1 = -2116379503;
        Button current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 + (~(1908778186 + (-1366235095 - 1460892539) ^ -1912894259) ^ ~(767560180 + 1448167439 + 564997791 * -719929025) ^ ~(202645139 - 1671902171) + (~-661247606 - 2014209410))) ^ ~-~1192424303)) % 6U)
          {
            case 0:
              current.BackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.ForeColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * -1053731840 ^ 1733635135;
              continue;
            case 2:
              num1 = (int) num2 * 171745618 ^ 1490283111;
              continue;
            case 3:
              goto label_2;
            case 4:
              int num3;
              num1 = num3 = enumerator1.MoveNext() ? 1195885900 : (num3 = 644870502);
              continue;
            case 5:
              current = enumerator1.Current;
              num1 = 2091052651;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_9:
          int num4 = 2030498610;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) (~(num4 + (~(1908778186 + (-1366235095 - 1460892539) ^ -1912894259) ^ ~(767560180 + 1448167439 + 564997791 * -719929025) ^ ~(202645139 - 1671902171) + (~-661247606 - 2014209410))) ^ ~-~1192424303)) % 3U)
            {
              case 1:
                enumerator1.Dispose();
                num4 = (int) num5 * 915383350 ^ 1412564313;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_13:
      IEnumerator<CheckBox> enumerator2;
      try
      {
        enumerator2 = this.Controls.OfType<CheckBox>().GetEnumerator();
label_14:
        int num6 = 1822354119;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) (~(num6 + (~(1908778186 + (-1366235095 - 1460892539) ^ -1912894259) ^ ~(767560180 + 1448167439 + 564997791 * -719929025) ^ ~(202645139 - 1671902171) + (~-661247606 - 2014209410))) ^ ~-~1192424303)) % 5U)
          {
            case 0:
              int num8;
              num6 = num8 = enumerator2.MoveNext() ? 1149022906 : (num8 = 1923757682);
              continue;
            case 1:
              num6 = (int) num7 * -1149759122 ^ 686063871;
              continue;
            case 2:
              CheckBox current = enumerator2.Current;
              current.BackColor = Settings.DefaultColor_Background;
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num6 = 1852572707;
              continue;
            case 3:
              goto label_14;
            case 4:
              goto label_23;
            default:
              goto label_19;
          }
        }
label_23:
        return;
label_19:;
      }
      finally
      {
        if (enumerator2 != null)
        {
label_21:
          int num9 = 1149120288;
          while (true)
          {
            uint num10;
            switch ((num10 = (uint) (~(num9 + (~(1908778186 + (-1366235095 - 1460892539) ^ -1912894259) ^ ~(767560180 + 1448167439 + 564997791 * -719929025) ^ ~(202645139 - 1671902171) + (~-661247606 - 2014209410))) ^ ~-~1192424303)) % 3U)
            {
              case 0:
                goto label_21;
              case 1:
                enumerator2.Dispose();
                num9 = (int) num10 * -81862293 ^ -747123012;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
    }

    public Color_Box0()
    {
      this.Load += new EventHandler(this.Color_Box0_Load);
      this.Activated += new EventHandler(this.Color_Box0_Activated);
      this.Deactivate += new EventHandler(this.Color_Box0_Deactivate);
      ((CraxsSettings) this).BoxTitlePaintEventArgsWait = false;
      ((CraxsSettings) this).Programmatically = false;
      ((CraxsSettings) this).default_color = Color.Yellow;
      ((CraxsSettings) this)._new_color = Color.Yellow;
      ((CraxsSettings) this).p1 = new Point(0, 0);
      ((CraxsSettings) this).s_mouse1 = false;
      ((CraxsSettings) this).p0 = new Point();
      ((CraxsSettings) this).s_mouse0 = false;
      ((CraxsSettings) this).TEXT_COLOR = EXGuarder.\u00307381855;
      ((ClipboardManager) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void Color_Box0_Load(object sender, EventArgs e)
    {
      this.SpyStyle();
label_1:
      int num1 = -1066118553;
      while (true)
      {
        int num2 = num1;
        uint num3;
        object[] e1;
        object[] e2;
        switch ((num3 = (uint) (~(1855588935 - -((num2 ^ -2140098659 * (~(1396417730 + 57293671) * -648651771) + (454358100 + (~1837273543 ^ 2038279217 - 1177352165) * 1969247059)) * -614659407)) - 1614240770)) % 18U)
        {
          case 0:
            ((CraxsSettings) this).G = Graphics.FromImage((Image) ((CraxsSettings) this).Bmp);
            num1 = (int) num3 * -431862002 ^ -1680767068;
            continue;
          case 1:
            ((CraxsSettings) this).Programmatically = false;
            ((CraxsSettings) this).BoxTitlePaintEventArgsWait = true;
            num1 = (int) num3 * -2095859486 ^ -1348793296;
            continue;
          case 2:
            ((CraxsSettings) this).p0 = new Point(1, 1);
            num1 = (int) num3 * 941832611 ^ 1634758659;
            continue;
          case 3:
            ((CraxsSettings) this).Bmp = new Bitmap(1, 1);
            num1 = (int) num3 * -775844649 ^ 2130278605;
            continue;
          case 4:
            this._Update0(e1, (Control) this.C_Box2);
            num1 = (int) num3 * -953641874 ^ 648301144;
            continue;
          case 5:
            this.BTN_OK.Font = Settings.f;
            this.TopMost = true;
            num1 = (int) num3 * 582746046 ^ 1087092673;
            continue;
          case 6:
            goto label_1;
          case 7:
            ((CraxsSettings) this).p0 = Settings.po1;
            num1 = 1304004141;
            continue;
          case 8:
            int num4 = !(Settings.po1 == new Point()) ? -2031164957 : (num4 = 440987346);
            num1 = num4 ^ (int) num3 * -1505634339;
            continue;
          case 9:
            ((CraxsSettings) this).Programmatically = true;
            num1 = (int) num3 * 628377087 ^ -638907832;
            continue;
          case 10:
            e2 = new object[2]
            {
              (object) ((CraxsSettings) this).p1.X,
              (object) ((CraxsSettings) this).p1.Y
            };
            num1 = -1164684943;
            continue;
          case 11:
            ((CraxsSettings) this).p1 = Settings.po2;
            num1 = -1639824656;
            continue;
          case 12:
            goto label_3;
          case 13:
            this._Update1(e2, (Control) this.C_Box0);
            num1 = (int) num3 * -1683095639 ^ 145951193;
            continue;
          case 14:
            this.C_Box2.Invalidate();
            int num5 = !(Settings.po2 == new Point()) ? 768887549 : (num5 = 1120136431);
            num1 = num5 ^ (int) num3 * -1822557589;
            continue;
          case 15:
            ((CraxsSettings) this).p1 = new Point(1, 1);
            num1 = (int) num3 * 372541977 ^ -1570095739;
            continue;
          case 16:
            this.C_Box0.Invalidate();
            num1 = (int) num3 * -34301321 ^ -1239834389;
            continue;
          case 17:
            e1 = new object[2]
            {
              (object) ((CraxsSettings) this).p0.X,
              (object) ((CraxsSettings) this).p0.Y
            };
            num1 = 1427237132;
            continue;
          default:
            goto label_20;
        }
      }
label_3:
      return;
label_20:;
    }

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetKeyState(long nVirtKey);

    private void C_Box0_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      Rectangle rect1 = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
      LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush(rect1, Color.White, ((CraxsSettings) this).default_color, LinearGradientMode.Horizontal);
      try
      {
        graphics.FillRectangle((Brush) linearGradientBrush1, rect1);
      }
      finally
      {
        if (linearGradientBrush1 != null)
        {
label_3:
          int num1 = 1090127965;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ((-num1 - (1601576203 * (2136707589 + ~-1121182915) + -~~1128584524) - -(-1220129432 * 1272170009 + -527421767 * 189487748) - 1306339247) * -41519351)) % 3U)
            {
              case 0:
                goto label_3;
              case 2:
                linearGradientBrush1.Dispose();
                num1 = (int) num2 * -1092859280 ^ 1269481564;
                continue;
              default:
                goto label_6;
            }
          }
        }
label_6:;
      }
      Rectangle rect2 = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
      LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rect2, Color.Transparent, Color.Black, LinearGradientMode.Vertical);
      try
      {
        graphics.FillRectangle((Brush) linearGradientBrush2, rect2);
label_9:
        int num3 = -1940959149;
        int num4;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) ((-num3 - (1601576203 * (2136707589 + ~-1121182915) + -~~1128584524) - -(-1220129432 * 1272170009 + -527421767 * 189487748) - 1306339247) * -41519351)) % 4U)
          {
            case 1:
              num4 = checked (this.C_Box0.Height - 7);
              num3 = (int) num5 * -252487551 ^ 253761899;
              continue;
            case 2:
              graphics.DrawLine(new Pen(Color.Black, 5f), 0, num4, this.C_Box0.Width, num4);
              num3 = (int) num5 * -439165042 ^ -367516036;
              continue;
            case 3:
              goto label_9;
            default:
              goto label_19;
          }
        }
      }
      finally
      {
        if (linearGradientBrush2 != null)
        {
label_14:
          int num6 = -1519528044;
          while (true)
          {
            uint num7;
            switch ((num7 = (uint) ((-num6 - (1601576203 * (2136707589 + ~-1121182915) + -~~1128584524) - -(-1220129432 * 1272170009 + -527421767 * 189487748) - 1306339247) * -41519351)) % 3U)
            {
              case 0:
                goto label_14;
              case 2:
                linearGradientBrush2.Dispose();
                num6 = (int) num7 * 272110897 ^ -1879522021;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_19:
label_20:
      int num8 = 677735008;
      Pen pen;
      Bitmap bitmap;
      Color pixel;
      Rectangle rect3;
      while (true)
      {
        uint num9;
        switch ((num9 = (uint) ((-num8 - (1601576203 * (2136707589 + ~-1121182915) + -~~1128584524) - -(-1220129432 * 1272170009 + -527421767 * 189487748) - 1306339247) * -41519351)) % 19U)
        {
          case 0:
            bitmap.Dispose();
            ((CraxsSettings) this)._new_color = pixel;
            num8 = (int) num9 * 1130179326 ^ 1770904336;
            continue;
          case 1:
            int num10 = ((CraxsSettings) this).p1 == new Point() ? 1455276846 : (num10 = -236969664);
            num8 = num10 ^ (int) num9 * 780538117;
            continue;
          case 2:
            num8 = (int) num9 * 1583092074 ^ -485535026;
            continue;
          case 3:
            bitmap = new Bitmap(this.C_Box0.ClientSize.Width, this.C_Box0.Height);
            num8 = (int) num9 * 1834769962 ^ 1443648818;
            continue;
          case 4:
            pen = new Pen(Color.White, 1f);
            num8 = (int) num9 * 1396309031 ^ -587813188;
            continue;
          case 5:
            this.C_Box3.Refresh();
            num8 = (int) num9 * -809148611 ^ -1345310905;
            continue;
          case 6:
            e.Graphics.DrawEllipse(pen, rect3);
            num8 = 1651663369;
            continue;
          case 7:
            int num11 = checked ((int) Math.Round(unchecked ((double) this.C_Box0.Height / 2.0))) >= ((CraxsSettings) this).p1.Y ? 366680889 : (num11 = 1957549633);
            num8 = num11 ^ (int) num9 * 120130199;
            continue;
          case 8:
            this.C_Box0.DrawToBitmap(bitmap, this.C_Box0.ClientRectangle);
            num8 = (int) num9 * 263499914 ^ 1680155994;
            continue;
          case 9:
            goto label_20;
          case 10:
            pen = new Pen(Color.Black, 1f);
            num8 = -1885034466;
            continue;
          case 11:
            this.C_Box3.BackColor = ((CraxsSettings) this)._new_color;
            num8 = 1349906980;
            continue;
          case 12:
            goto label_22;
          case 13:
            pixel = bitmap.GetPixel(((CraxsSettings) this).p1.X, ((CraxsSettings) this).p1.Y);
            num8 = (int) num9 * 1467872911 ^ 522898992;
            continue;
          case 14:
            int num12 = !(bitmap.Width > ((CraxsSettings) this).p1.X & bitmap.Height > ((CraxsSettings) this).p1.Y) ? -714878302 : (num12 = 1664437921);
            num8 = num12 ^ (int) num9 * 1748845696;
            continue;
          case 15:
            this.Title(new object[3]
            {
              (object) this.C_Box3.BackColor.R,
              (object) this.C_Box3.BackColor.G,
              (object) this.C_Box3.BackColor.B
            });
            num8 = (int) num9 * -176270109 ^ 37337096;
            continue;
          case 16:
            rect3 = new Rectangle(checked (((CraxsSettings) this).p1.X - 5), checked (((CraxsSettings) this).p1.Y - 5), 10, 10);
            num8 = 1308286948;
            continue;
          case 17:
            rect3 = new Rectangle(checked (((CraxsSettings) this).p1.X - 7), checked (((CraxsSettings) this).p1.Y - 7), 14, 14);
            num8 = (int) num9 * -1006468692 ^ 2136802279;
            continue;
          case 18:
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int num13 = !((CraxsSettings) this).s_mouse1 ? 1693015980 : (num13 = -1294636103);
            num8 = num13 ^ (int) num9 * -494681433;
            continue;
          default:
            goto label_16;
        }
      }
label_22:
      return;
label_16:;
    }

    private void C_Box0_MouseDown(object sender, MouseEventArgs e)
    {
      ((CraxsSettings) this).s_mouse1 = true;
label_1:
      int num1 = 74708306;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-135738877 ^ -253174867) - (num2 - (-(979667160 - 1686165290 + (-784635400 ^ 1629200769) ^ --1208506798) ^ ~100176403 - -642911937 * -824921477) - (-1917480423 * (1040127300 * 1856252987) - ~(382097330 * 1085349863)) * -399627385 ^ -(-31284814 ^ -2057722815 ^ -688380320)))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this._Update1(new object[2]
            {
              (object) e.X,
              (object) e.Y
            }, (Control) this.C_Box0);
            num1 = (int) num3 * 122771574 ^ -679509246;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void _Update1(object[] e, Control c)
    {
      if (!(((CraxsSettings) this).s_mouse1 | ((CraxsSettings) this).Programmatically))
        return;
label_1:
      int num1 = 510905247;
      Size clientSize;
      Bitmap bitmap;
      Color pixel;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 * 1669579531) ^ ~(385674660 - 389500633 + (1271284741 - 99435667))) + (--417184279 - --21611467) - 853566645)) % 12U)
        {
          case 0:
            goto label_14;
          case 1:
            clientSize = c.ClientSize;
            num1 = (int) num2 * 1850835941 ^ 1632639555;
            continue;
          case 2:
            ((CraxsSettings) this).p1.Y = Conversions.ToInteger(e[1]);
            num1 = (int) num2 * 1533039168 ^ 1550361115;
            continue;
          case 3:
            bitmap = new Bitmap(clientSize.Width, c.Height);
            num1 = (int) num2 * -1287401388 ^ -998869054;
            continue;
          case 4:
            Settings.po2 = new Point(((CraxsSettings) this).p1.X, ((CraxsSettings) this).p1.Y);
            num1 = (int) num2 * -1238940256 ^ -1753083152;
            continue;
          case 5:
            ((CraxsSettings) this)._new_color = pixel;
            c.Refresh();
            num1 = (int) num2 * 2131006242 ^ -804497037;
            continue;
          case 6:
            goto label_1;
          case 7:
            c.DrawToBitmap(bitmap, c.ClientRectangle);
            int num3 = !Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object) bitmap.Width, e[0], false), Operators.CompareObjectGreater((object) bitmap.Height, e[1], false))) ? 878703792 : (num3 = 488396365);
            num1 = num3 ^ (int) num2 * -436160021;
            continue;
          case 8:
            int num4 = !Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], (object) checked (c.Width - 7), false)), Operators.NotObject(Operators.CompareObjectLess(e[0], (object) 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], (object) checked (c.Height - 7), false))), Operators.NotObject(Operators.CompareObjectLess(e[1], (object) 1, false)))) ? 987088275 : (num4 = -1114030958);
            num1 = num4 ^ (int) num2 * 478156756;
            continue;
          case 9:
            pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
            bitmap.Dispose();
            num1 = (int) num2 * 454588135 ^ 617686655;
            continue;
          case 10:
            c.Invalidate();
            num1 = -1160855661;
            continue;
          case 11:
            ((CraxsSettings) this).p1.X = Conversions.ToInteger(e[0]);
            num1 = (int) num2 * -1666563329 ^ 370241748;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void C_Box0_MouseMove(object sender, MouseEventArgs e)
    {
      if (!((CraxsSettings) this).s_mouse1)
        return;
label_1:
      int num1 = -2118815022;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-~((~(-1230190428 - -905717243) ^ -(-1605204067 ^ 787430670)) - (~num2 ^ ~-(--1149798836 - -1888314661 * 596036731))) + 1271243090)) % 6U)
        {
          case 0:
            goto label_8;
          case 1:
            int num4 = !Operators.ConditionalCompareObjectEqual(this.C_Box0.Tag, (object) null, false) ? -1734592094 : (num4 = 1486280147);
            num1 = num4 ^ (int) num3 * 1000192766;
            continue;
          case 2:
            Cursor.Clip = this.C_Box0.RectangleToScreen(new Rectangle(1, 1, checked (this.C_Box0.Width - 7), checked (this.C_Box0.Height - 7)));
            num1 = (int) num3 * 2120387778 ^ 765715708;
            continue;
          case 3:
            this._Update1(new object[2]
            {
              (object) e.X,
              (object) e.Y
            }, (Control) this.C_Box0);
            num1 = -1722970621;
            continue;
          case 4:
            goto label_1;
          case 5:
            this.C_Box0.Tag = (object) true;
            num1 = (int) num3 * 495395228 ^ 1514007496;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void C_Box0_MouseUp(object sender, MouseEventArgs e)
    {
      ((CraxsSettings) this).s_mouse1 = false;
label_1:
      int num1 = -1214879642;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-num1 * -555188171 * 385303447)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.C_Box0.Tag = (object) null;
            this.C_Box0.Invalidate();
            num1 = (int) num2 * -1816750275 ^ -439845670;
            continue;
          case 2:
            Cursor.Clip = new Rectangle();
            num1 = (int) num2 * 345888646 ^ 399257949;
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

    private void C_Box2_Paint(object sender, PaintEventArgs e)
    {
      LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), this.C_Box2.ClientSize), Color.Red, Color.Blue, 0.0f);
      try
      {
        ColorBlend colorBlend = new ColorBlend();
        colorBlend.Positions = new float[7]
        {
          0.0f,
          0.1f,
          0.284f,
          0.5f,
          0.668f,
          0.9f,
          1f
        };
label_2:
        int num1 = -858865013;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-(num1 ^ -((1005443973 ^ -1651489108 ^ 1826250926 + 381324475) - -(-1124975171 * 1397833987)) ^ -(443360320 - 1163777153) + (-1035388538 - 410885985) - (1173719773 - -847201555 - ~-945551774 - 941095697 * ~1145295351)) ^ -1884755155)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              e.Graphics.FillRectangle((Brush) linearGradientBrush, this.C_Box2.ClientRectangle);
              num1 = (int) num2 * -546675227 ^ 1947029950;
              continue;
            case 2:
              colorBlend.Colors = new Color[7]
              {
                Color.Purple,
                Color.Red,
                Color.Yellow,
                Color.Lime,
                Color.Cyan,
                Color.Blue,
                Color.LightBlue
              };
              num1 = (int) num2 * 1836297880 ^ 2038857676;
              continue;
            case 3:
              linearGradientBrush.InterpolationColors = colorBlend;
              num1 = (int) num2 * 308329050 ^ 1121327656;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (linearGradientBrush != null)
        {
label_9:
          int num3 = -339122849;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) -(-(num3 ^ -((1005443973 ^ -1651489108 ^ 1826250926 + 381324475) - -(-1124975171 * 1397833987)) ^ -(443360320 - 1163777153) + (-1035388538 - 410885985) - (1173719773 - -847201555 - ~-945551774 - 941095697 * ~1145295351)) ^ -1884755155)) % 3U)
            {
              case 1:
                linearGradientBrush.Dispose();
                num3 = (int) num4 * -1736950473 ^ 112247543;
                continue;
              case 2:
                goto label_9;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      if (((CraxsSettings) this).p0 == new Point())
        return;
label_15:
      int num5 = -215452388;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) -(-(num5 ^ -((1005443973 ^ -1651489108 ^ 1826250926 + 381324475) - -(-1124975171 * 1397833987)) ^ -(443360320 - 1163777153) + (-1035388538 - 410885985) - (1173719773 - -847201555 - ~-945551774 - 941095697 * ~1145295351)) ^ -1884755155)) % 4U)
        {
          case 0:
            goto label_15;
          case 1:
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            num5 = (int) num6 * -1131232524 ^ 34654334;
            continue;
          case 2:
            goto label_11;
          case 3:
            Rectangle rect = new Rectangle(checked (((CraxsSettings) this).p0.X - 3), -1, 5, checked (this.C_Box2.Height - 3));
            Pen pen = new Pen(Color.Black, 1f);
            e.Graphics.DrawRectangle(pen, rect);
            num5 = (int) num6 * -1971783600 ^ -1213377073;
            continue;
          default:
            goto label_7;
        }
      }
label_11:
      return;
label_7:;
    }

    private void C_Box2_MouseDown(object sender, MouseEventArgs e)
    {
      ((CraxsSettings) this).s_mouse0 = true;
      this._Update0(new object[2]
      {
        (object) e.X,
        (object) e.Y
      }, (Control) this.C_Box2);
    }

    private void _Update0(object[] e, Control c)
    {
      if (!(((CraxsSettings) this).s_mouse0 | ((CraxsSettings) this).Programmatically))
        return;
label_1:
      int num1 = 1763720512;
      Size clientSize;
      Bitmap bitmap;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-(num1 + ~(1356473841 - 1703222908 + (1398089695 - 1475274567) - -409999503 * ~-787237684) * -1235350935) ^ (723068924 - 664877713 ^ -490989472 - -1409837773) + -~-1272004856 ^ (1843973276 ^ -1300891517) + (-1504226509 - 247364162)) * 1989359459)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            c.DrawToBitmap(bitmap, c.ClientRectangle);
            num1 = (int) num2 * -1266964171 ^ -2050862849;
            continue;
          case 2:
            Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
            bitmap.Dispose();
            ((CraxsSettings) this).default_color = pixel;
            this.C_Box0.Invalidate();
            num1 = (int) num2 * 295827271 ^ -1401054566;
            continue;
          case 3:
            int num3 = !Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object) bitmap.Width, e[0], false), Operators.CompareObjectGreater((object) bitmap.Height, e[1], false))) ? 691423995 : (num3 = 699799358);
            num1 = num3 ^ (int) num2 * -527226511;
            continue;
          case 4:
            clientSize = c.ClientSize;
            num1 = (int) num2 * -510559809 ^ -1086285826;
            continue;
          case 5:
            bitmap = new Bitmap(clientSize.Width, c.Height);
            num1 = (int) num2 * 1488058271 ^ 1198964338;
            continue;
          case 6:
            c.Invalidate();
            num1 = -1468018731;
            continue;
          case 7:
            ((CraxsSettings) this).p0.Y = Conversions.ToInteger(e[1]);
            Settings.po1 = new Point(((CraxsSettings) this).p0.X, ((CraxsSettings) this).p0.Y);
            num1 = (int) num2 * 1950333676 ^ 2072172053;
            continue;
          case 8:
            ((CraxsSettings) this).p0.X = Conversions.ToInteger(e[0]);
            num1 = (int) num2 * -1372561742 ^ -630365400;
            continue;
          case 9:
            goto label_13;
          case 10:
            int num4 = !Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], (object) checked (c.Width - 7), false)), Operators.NotObject(Operators.CompareObjectLess(e[0], (object) 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], (object) checked (c.Height - 7), false))), Operators.NotObject(Operators.CompareObjectLess(e[1], (object) 1, false)))) ? -529986404 : (num4 = 801685325);
            num1 = num4 ^ (int) num2 * 1877162241;
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private void C_Box2_MouseMove(object sender, MouseEventArgs e)
    {
      if (!((CraxsSettings) this).s_mouse0)
        return;
label_1:
      int num1 = -1229173702;
      object[] e1;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(-~num1 - (1397778563 + 1971771722 - (1700625655 - 438444900) - ---2125503091)) ^ -533723358)) % 7U)
        {
          case 0:
            this.C_Box2.Tag = (object) true;
            num1 = (int) num2 * 574471361 ^ -1856127096;
            continue;
          case 1:
            goto label_9;
          case 2:
            int num3 = !Operators.ConditionalCompareObjectEqual(this.C_Box2.Tag, (object) null, false) ? 857908787 : (num3 = 439228786);
            num1 = num3 ^ (int) num2 * 1663555315;
            continue;
          case 3:
            e1 = new object[2]{ (object) e.X, (object) e.Y };
            num1 = -2121566116;
            continue;
          case 4:
            this._Update0(e1, (Control) this.C_Box2);
            num1 = (int) num2 * 532736426 ^ -1084095385;
            continue;
          case 5:
            goto label_1;
          case 6:
            Cursor.Clip = this.C_Box2.RectangleToScreen(new Rectangle(1, 1, checked (this.C_Box2.Width - 7), checked (this.C_Box2.Height - 7)));
            num1 = (int) num2 * -195515951 ^ -1628119455;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void C_Box2_MouseUp(object sender, MouseEventArgs e)
    {
      ((CraxsSettings) this).s_mouse0 = false;
      Rectangle rectangle = new Rectangle();
label_1:
      int num1 = -1144953896;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~-((num1 + ((375295960 ^ -1281650315 - 557626658 ^ ~(1317540799 * -250733010) - 463169282) - -546757249 * (-1705090029 - (390803817 - 1702949814) + (-64999129 - 1977214702 - ~-1248417520))) ^ 877786503 * (887498846 * 79580947) ^ 445760353 ^ -1709822740) - -344886596)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.C_Box2.Tag = (object) null;
            num1 = (int) num2 * 911544947 ^ 785063136;
            continue;
          case 3:
            Cursor.Clip = rectangle;
            num1 = (int) num2 * -1515499743 ^ 2119505604;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void ti_Tick(object sender, EventArgs e)
    {
      try
      {
        ((CraxsSettings) this).G.CopyFromScreen(new Point((Size) Cursor.Position), Point.Empty, ((CraxsSettings) this).Bmp.Size);
label_1:
        int num1 = -985284362;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --~(num1 ^ 1043703301 * (-404907891 * -1084336032) * 1268080619)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              PictureBox cBox3 = this.C_Box3;
              Color color1 = ((CraxsSettings) this).Bmp.GetPixel(0, 0);
              int r = (int) color1.R;
              color1 = ((CraxsSettings) this).Bmp.GetPixel(0, 0);
              int g = (int) color1.G;
              color1 = ((CraxsSettings) this).Bmp.GetPixel(0, 0);
              int b = (int) color1.B;
              Color color2 = Color.FromArgb(r, g, b);
              cBox3.BackColor = color2;
              object[] objArray = new object[3];
              color1 = this.C_Box3.BackColor;
              objArray[0] = (object) color1.R;
              color1 = this.C_Box3.BackColor;
              objArray[1] = (object) color1.G;
              color1 = this.C_Box3.BackColor;
              objArray[2] = (object) color1.B;
              this.Title(objArray);
              num1 = (int) num2 * -1535477584 ^ 136764548;
              continue;
            case 2:
              goto label_1;
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

    private void Title(object[] obj)
    {
      ((CraxsSettings) this).TEXT_COLOR = string.Format(EXGuarder.\u00300423F61, RuntimeHelpers.GetObjectValue(obj[0]), RuntimeHelpers.GetObjectValue(obj[1]), RuntimeHelpers.GetObjectValue(obj[2]));
      this.BoxTitle.Refresh();
    }

    private void CK1_MouseDown(object sender, MouseEventArgs e)
    {
      this.ti.Enabled = true;
label_1:
      int num1 = 1398206515;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 + 556701535 * (~(559095084 - 29874663) ^ (1463620930 ^ -13655312) - -862212074) ^ 445186627 * -1947882671 * 1961284691 ^ 366254098) - -(-617844847 - 242483250))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CK1.Checked = true;
            num1 = (int) num2 * -270632932 ^ -1465782528;
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

    private void CK1_MouseUp(object sender, MouseEventArgs e)
    {
      this.ti.Enabled = false;
      this.CK1.Checked = false;
    }

    private void BTN_OK_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void Color_Box0_Activated(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    private void Color_Box0_Deactivate(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    private void BoxTitle_Resize(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    private void C_Box0_Click(object sender, EventArgs e)
    {
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((CraxsSettings) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = -1546921192;
      string textColor;
      Brush brush1;
      Size size1;
      Brush brush2;
      Size size2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(-num1 * -748214527) - 2145633674 - -1336276030)) % 10U)
        {
          case 0:
            brush1 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            num1 = (int) num2 * 53637283 ^ 1178921900;
            continue;
          case 1:
            textColor = ((CraxsSettings) this).TEXT_COLOR;
            num1 = (int) num2 * -2134199139 ^ -1161159125;
            continue;
          case 2:
            Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (size2.Height + 5));
            e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
            num1 = (int) num2 * -631775973 ^ -578951629;
            continue;
          case 3:
            size2 = TextRenderer.MeasureText(textColor, Settings.f);
            num1 = (int) num2 * 37678071 ^ -1554259174;
            continue;
          case 4:
            goto label_1;
          case 5:
            Color defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            num1 = (int) num2 * 1795929219 ^ 1606659166;
            continue;
          case 6:
            e.Graphics.DrawString(textColor, Settings.f, brush1, 0.0f, 2f);
            size1 = TextRenderer.MeasureText(EXGuarder.\u0036C1D3957, Settings.f);
            int num3 = this.BoxTitle.Height == checked (size1.Height + 3) ? -1717391083 : (num3 = -78757554);
            num1 = num3 ^ (int) num2 * 1268401318;
            continue;
          case 7:
            Color backColor = this.BoxTitle.BackColor;
            int r = (int) backColor.R;
            backColor = this.BoxTitle.BackColor;
            int g = (int) backColor.G;
            backColor = this.BoxTitle.BackColor;
            int b = (int) backColor.B;
            brush2 = (Brush) new SolidBrush(Color.FromArgb(170, r, g, b));
            num1 = (int) num2 * 1204530980 ^ 106653004;
            continue;
          case 8:
            goto label_12;
          case 9:
            this.BoxTitle.Height = checked (size1.Height + 3);
            num1 = (int) num2 * -536314455 ^ 115264978;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    private void BoxTitle_Click(object sender, EventArgs e)
    {
    }

    private void C_Box2_Click(object sender, EventArgs e)
    {
    }

    public Color_Box0()
    {
label_1:
      int num1 = 1666988149;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-(num1 + ((2073103095 ^ -1097231608) * -1487848905 - ~--1061152022 + -(534916649 * -896874541) + --1566187167)) * -82332489 * 2113190899) ^ -1869723761)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Deactivate += new EventHandler(((ContactsManager) this).AngelAndroidForm_Deactivate);
            ((CraxsSettings) this).Title = EXGuarder.\u0031C2C6A0D;
            num1 = (int) num2 * 1550638532 ^ -267210510;
            continue;
          case 2:
            ((ContactsManager) this).InitializeComponent();
            num1 = (int) num2 * 32669485 ^ 1961343829;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.Load += new EventHandler(((ContactsManager) this).ContactsManager_Load);
            this.Activated += new EventHandler(((ContactsManager) this).AngelAndroidForm_Activated);
            num1 = (int) num2 * 301170118 ^ 593434376;
            continue;
          case 5:
            ((Dialog1) this).BoxTitlePaintEventArgsWait = false;
            num1 = (int) num2 * -248924216 ^ 1395799223;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1972410825;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~(num1 * -1292179125) + (~323824033 ^ 771397102 ^ -174323131))) % 4U)
          {
            case 0:
              ((CraxsSettings) this).components.Dispose();
              num1 = (int) num2 * 1363424921 ^ 76320824;
              continue;
            case 1:
              int num3 = ((CraxsSettings) this).components == null ? 1883930792 : (num3 = 1742140830);
              num1 = num3 ^ (int) num2 * 779768084;
              continue;
            case 2:
              goto label_3;
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
