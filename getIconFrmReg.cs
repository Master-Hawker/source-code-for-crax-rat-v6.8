// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.getIconFrmReg
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class getIconFrmReg
  {
    public Bitmap FLAG;
    public string TEXT;
    public int sizeHeight;

    public static Bitmap GetFileIcon(string fileExt)
    {
      int num1 = 1;
label_1:
      int num2 = 953820732;
      Bitmap fileIcon;
      while (true)
      {
        int num3 = num2;
        uint num4;
        Bitmap bitmap;
        getIconFrmReg.SHFILEINFO psfi;
        switch ((num4 = (uint) (-(1116095768 - (~num3 - (-~(1381200424 - 1095822480) + ((-819833376 ^ -70673210 ^ -227439768 - 773923921) + (1110977769 ^ -1897989328 * -1184967351)))) * 2045002263) * 749826213)) % 10U)
        {
          case 0:
            fileIcon = bitmap;
            num2 = (int) num4 * 1598930321 ^ -399276921;
            continue;
          case 1:
            RefreshExplorer.SHGetFileInfo(fileExt, 128, ref psfi, Marshal.SizeOf((object) psfi), 256 | num1 | 16);
            num2 = (int) num4 * 1719852135 ^ -1130626916;
            continue;
          case 2:
            int num5 = Operators.CompareString(Settings.FM_IC_Size, EXGuarder.\u0036F1E7465, false) != 0 ? -2102946283 : (num5 = -1964936780);
            num2 = num5 ^ (int) num4 * 1579170338;
            continue;
          case 4:
            psfi = new getIconFrmReg.SHFILEINFO();
            num2 = -957896188;
            continue;
          case 5:
            bitmap = Icon.FromHandle(psfi.hIcon).ToBitmap();
            RefreshExplorer.DestroyIcon(psfi.hIcon);
            num2 = (int) num4 * -1742912232 ^ -712613362;
            continue;
          case 6:
            num1 = 0;
            num2 = (int) num4 * 149097180 ^ -1725800330;
            continue;
          case 7:
            num1 = 1;
            num2 = -792771530;
            continue;
          case 8:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(SecurityKey&) ref psfi).szDisplayName = new string(char.MinValue, 260);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(SecurityKey&) ref psfi).szTypeName = new string(char.MinValue, 80);
            num2 = (int) num4 * -1293449750 ^ -973833617;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_11;
        }
      }
label_11:
      return fileIcon;
    }

    [DllImport("shell32.dll")]
    private static extern int SHGetFileInfoW(
      [MarshalAs(UnmanagedType.LPTStr), In] string pszPath,
      int dwFileAttributes,
      ref getIconFrmReg.SHFILEINFOW psfi,
      int cbFileInfo,
      int uFlags);

    public static Bitmap GetIcon(string PathName, bool LargeIco)
    {
      getIconFrmReg.SHFILEINFOW psfi = new getIconFrmReg.SHFILEINFOW();
label_1:
      int num1 = -789351950;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-num1 * -389788241 + (1380390816 - 711938069 - (634143444 ^ -1353031609)) - (1567247801 - 1709460568) - -383256562)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            int num3 = !LargeIco ? 1683061972 : (num3 = -567695605);
            num1 = num3 ^ (int) num2 * 1595419247;
            continue;
          case 2:
            getIconFrmReg.SHGetFileInfoW(PathName, 0, ref psfi, Marshal.SizeOf((object) psfi), 256);
            num1 = (int) num2 * -1075017317 ^ -2130119457;
            continue;
          case 3:
            getIconFrmReg.SHGetFileInfoW(PathName, 0, ref psfi, Marshal.SizeOf((object) psfi), 257);
            num1 = -1696650734;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      Bitmap bitmap = Icon.FromHandle(psfi.hIcon).ToBitmap();
      RefreshExplorer.DestroyIcon(psfi.hIcon);
      return bitmap;
    }

    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 575291471;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - ~-((560459009 ^ 1566524041) + (-524620050 - 1199328013) ^ -(1928865049 - 297794620)) ^ (-1091893631 - 763269741 * -1082345843 ^ -(923930610 - 1093626138)) - ~((-446602826 ^ -755240148) - -1013020488)) + ~-(1063468153 - 1378362606)) * -708201377)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3 = ((SecurityKey) this).components == null ? 464541394 : (num3 = 357849867);
              num1 = num3 ^ (int) num2 * -524977369;
              continue;
            case 2:
              ((SecurityKey) this).components.Dispose();
              num1 = (int) num2 * 790667400 ^ -694126939;
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
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Form) this).Dispose(disposing));
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((SecurityKey) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
label_1:
      int num1 = -689709471;
      DataGridViewCellStyle gridViewCellStyle2;
      DataGridViewCellStyle gridViewCellStyle3;
      DataGridViewCellStyle gridViewCellStyle4;
      DataGridViewCellStyle gridViewCellStyle5;
      DataGridViewCellStyle gridViewCellStyle6;
      DataGridViewCellStyle gridViewCellStyle7;
      DataGridViewCellStyle gridViewCellStyle8;
      DataGridViewCellStyle gridViewCellStyle9;
      DataGridViewCellStyle gridViewCellStyle10;
      ComponentResourceManager componentResourceManager;
      DataGridViewCellStyle gridViewCellStyle11;
      DataGridViewCellStyle gridViewCellStyle12;
      DataGridViewCellStyle gridViewCellStyle13;
      DataGridViewCellStyle gridViewCellStyle14;
      DataGridViewCellStyle gridViewCellStyle15;
      DataGridViewCellStyle gridViewCellStyle16;
      DataGridViewCellStyle gridViewCellStyle17;
      DataGridViewCellStyle gridViewCellStyle18;
      DataGridViewCellStyle gridViewCellStyle19;
      DataGridViewCellStyle gridViewCellStyle20;
      DataGridViewCellStyle gridViewCellStyle21;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~num1 ^ --1298374298 - -1336126001 * -6133531 - (996220995 * -382249436 + (795156648 + 2065901421)))) % 486U)
        {
          case 0:
            ((Settings) this).DGV9.BorderStyle = BorderStyle.None;
            ((Settings) this).DGV9.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 965232375 ^ 1631073377;
            continue;
          case 1:
            gridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle20.BackColor = Color.Black;
            gridViewCellStyle20.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle20.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle20.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -919032467 ^ 302599886;
            continue;
          case 2:
            ((Settings) this).DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -43866166 ^ -1176024835;
            continue;
          case 3:
            ((Settings) this).DGV9.Name = EXGuarder.\u0036A125658;
            num1 = (int) num2 * 953845171 ^ 764760303;
            continue;
          case 4:
            ((Settings) this).DGV9.AllowUserToResizeRows = false;
            num1 = (int) num2 * -1892342034 ^ 1961127843;
            continue;
          case 5:
            ((Settings) this).DGV1.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 507136932 ^ -77345051;
            continue;
          case 6:
            ((Settings) this).DL.BackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -578371055 ^ -639319505;
            continue;
          case 7:
            ((Settings) this).DGV6.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV6.RowHeadersVisible = false;
            num1 = (int) num2 * -545421619 ^ -1971367197;
            continue;
          case 8:
            ((Settings) this).DGV3.Location = new Point(0, 362);
            num1 = (int) num2 * 378627691 ^ 1916839993;
            continue;
          case 9:
            ((Settings) this).DataGridViewTextBoxColumn8.Name = EXGuarder.\u003354B4C42;
            num1 = (int) num2 * -365899465 ^ 387862358;
            continue;
          case 10:
            gridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * 358087253 ^ 1388654374;
            continue;
          case 11:
            gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * 3203186 ^ -112154012;
            continue;
          case 12:
            ((Settings) this).DGV7.AllowUserToResizeColumns = false;
            ((Settings) this).DGV7.AllowUserToResizeRows = false;
            num1 = (int) num2 * 1205903588 ^ -1370144111;
            continue;
          case 13:
            ((Settings) this).DGV7.TabIndex = 18;
            num1 = (int) num2 * -1822576975 ^ 1103094062;
            continue;
          case 14:
            ((Settings) this).DGV4.ColumnHeadersDefaultCellStyle = gridViewCellStyle14;
            num1 = (int) num2 * -849629112 ^ -617857310;
            continue;
          case 15:
            ((Settings) this).DGV2.DefaultCellStyle = gridViewCellStyle12;
            num1 = (int) num2 * 22944159 ^ -602583227;
            continue;
          case 16:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label6);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV4);
            num1 = (int) num2 * -776430205 ^ -1402665276;
            continue;
          case 17:
            ((Settings) this).DGV7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -1664531463 ^ -997722118;
            continue;
          case 18:
            ((Settings) this).Label4.BackColor = Color.FromArgb(35, 35, 35);
            ((Settings) this).Label4.Dock = DockStyle.Top;
            num1 = (int) num2 * 1300104390 ^ 2069260566;
            continue;
          case 19:
            ((Settings) this).DGV6.BackgroundColor = Color.Black;
            num1 = (int) num2 * 1868025027 ^ 436675373;
            continue;
          case 20:
            ((Settings) this).Label9.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -1342672995 ^ 1064020478;
            continue;
          case 21:
            ((Settings) this).DGV3.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * 1945533122 ^ -533019574;
            continue;
          case 22:
            ((Form) this).Opacity = 0.0;
            ((Form) this).Text = EXGuarder.\u003104B0A5F;
            num1 = (int) num2 * 927809361 ^ -329689508;
            continue;
          case 23:
            gridViewCellStyle17 = new DataGridViewCellStyle();
            gridViewCellStyle10 = new DataGridViewCellStyle();
            componentResourceManager = new ComponentResourceManager(typeof (Settings));
            gridViewCellStyle14 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1333384081 ^ -744471337;
            continue;
          case 24:
            gridViewCellStyle5 = new DataGridViewCellStyle();
            num1 = (int) num2 * 63671911 ^ 386868324;
            continue;
          case 25:
            ((Settings) this).Clr9ToolStripMenuItem.Name = EXGuarder.\u0031C32490D;
            num1 = (int) num2 * -314513880 ^ -1019723418;
            continue;
          case 26:
            gridViewCellStyle16.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle16.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle16.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -642978919 ^ -1159934206;
            continue;
          case 27:
            ((Settings) this).Label3.Size = new Size(352, 24);
            num1 = (int) num2 * 854480985 ^ -1810100335;
            continue;
          case 28:
            ((ISupportInitialize) ((Settings) this).DGV5).BeginInit();
            ((ISupportInitialize) ((Settings) this).DGV4).BeginInit();
            ((ISupportInitialize) ((Settings) this).DGV3).BeginInit();
            ((ISupportInitialize) ((Settings) this).DGV2).BeginInit();
            num1 = (int) num2 * 1379229141 ^ 1241260176;
            continue;
          case 29:
            ((Settings) this).DGV1.EnableHeadersVisualStyles = false;
            ((Settings) this).DGV1.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -1254099296 ^ 1293892565;
            continue;
          case 30:
            ((Settings) this).DGV3.TabIndex = 10;
            ((Settings) this).DataGridViewTextBoxColumn3.HeaderText = EXGuarder.\u003584C3A15;
            ((Settings) this).DataGridViewTextBoxColumn3.Name = EXGuarder.\u003345F3473;
            num1 = (int) num2 * -479837556 ^ 1165053724;
            continue;
          case 31:
            ((Settings) this).DGV4.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 743254011 ^ 1820431407;
            continue;
          case 32:
            ((ISupportInitialize) ((Settings) this).DGV7).BeginInit();
            num1 = (int) num2 * 1675795862 ^ 304629474;
            continue;
          case 33:
            ((Settings) this).DefaultToolStripMenuItem.Name = EXGuarder.\u0034B3D513A;
            num1 = (int) num2 * -450789657 ^ 110754013;
            continue;
          case 34:
            ((Settings) this).DGV2.Location = new Point(0, 263);
            ((Settings) this).DGV2.Name = EXGuarder.\u0031F462638;
            num1 = (int) num2 * 1676305696 ^ 1661744630;
            continue;
          case 35:
            ((Settings) this).Label6.Padding = new Padding(0, 0, 0, 4);
            ((Settings) this).Label6.Size = new Size(352, 24);
            num1 = (int) num2 * -245364506 ^ -1808658189;
            continue;
          case 36:
            gridViewCellStyle6.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 907751324 ^ -1927710959;
            continue;
          case 37:
            ((Settings) this).Label3.Text = EXGuarder.\u0033E6E5A62;
            ((Settings) this).Label3.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -574559293 ^ 1307979667;
            continue;
          case 38:
            ((Settings) this).DataGridViewComboBoxColumn6.DisplayStyleForCurrentCellOnly = true;
            num1 = (int) num2 * -1053541919 ^ 1367269495;
            continue;
          case 39:
            ((Settings) this).DGV1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ((Settings) this).DGV1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 2061207765 ^ 988897368;
            continue;
          case 40:
            ((Settings) this).DGV1.AllowUserToAddRows = false;
            ((Settings) this).DGV1.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 675052520 ^ 1501940555;
            continue;
          case 42:
            ((Settings) this).Label3.Dock = DockStyle.Top;
            num1 = (int) num2 * 907877590 ^ -1778066849;
            continue;
          case 43:
            gridViewCellStyle21.BackColor = Color.Black;
            gridViewCellStyle21.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle21.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle21.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            gridViewCellStyle21.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle21.WrapMode = DataGridViewTriState.False;
            ((Settings) this).DGV3.DefaultCellStyle = gridViewCellStyle21;
            num1 = (int) num2 * 187708829 ^ -857949911;
            continue;
          case 44:
            ((Settings) this).DGV8.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV8.RowHeadersVisible = false;
            ((Settings) this).DGV8.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * 2137641180 ^ -1618208447;
            continue;
          case 45:
            gridViewCellStyle7.BackColor = Color.Black;
            num1 = (int) num2 * -2085290667 ^ -705198800;
            continue;
          case 46:
            ((Settings) this).DGV8.ColumnHeadersVisible = false;
            num1 = (int) num2 * 2116741300 ^ 771199634;
            continue;
          case 47:
            ((Settings) this).Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            num1 = (int) num2 * 781409133 ^ 341993448;
            continue;
          case 48:
            ((Settings) this).DataGridViewComboBoxColumn8.DisplayStyleForCurrentCellOnly = true;
            num1 = (int) num2 * -1095165931 ^ 1569449442;
            continue;
          case 49:
            ((Settings) this).TOpacity.Interval = 1;
            num1 = (int) num2 * 50829996 ^ -1450745728;
            continue;
          case 50:
            ((Settings) this).Label2.Size = new Size(352, 24);
            num1 = (int) num2 * -35337567 ^ -988751464;
            continue;
          case 51:
            ((Settings) this).DGV2.AllowUserToResizeRows = false;
            num1 = (int) num2 * -1327593826 ^ -1946630566;
            continue;
          case 52:
            ((ISupportInitialize) ((Settings) this).DGV6).BeginInit();
            num1 = (int) num2 * -1031073363 ^ -989786884;
            continue;
          case 53:
            ((Settings) this).DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV1.Size = new Size(352, 75);
            ((Settings) this).DGV1.TabIndex = 6;
            num1 = (int) num2 * 203737913 ^ -1254312307;
            continue;
          case 54:
            ((Settings) this).Label1.TabIndex = 0;
            num1 = (int) num2 * -824391234 ^ 1632759297;
            continue;
          case 55:
            ((Settings) this).DGV9.Size = new Size(352, 75);
            ((Settings) this).DGV9.TabIndex = 22;
            num1 = (int) num2 * -873736205 ^ -1263541314;
            continue;
          case 56:
            ((Settings) this).DataGridViewComboBoxColumn6.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * -1774621456 ^ 709928244;
            continue;
          case 57:
            ((Settings) this).DataGridViewComboBoxColumn8 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label10 = new Label();
            ((Settings) this).DGV8 = new DataGridView();
            ((Settings) this).DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -984012517 ^ -1421144659;
            continue;
          case 58:
            ((ISupportInitialize) ((Settings) this).DGV6).EndInit();
            num1 = (int) num2 * -1866460404 ^ 1852931444;
            continue;
          case 59:
            ((Settings) this).DGV3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -546163139 ^ -875079560;
            continue;
          case 60:
            ((Settings) this).Panel2.Controls.Add((Control) ((Settings) this).SV);
            ((Settings) this).Panel2.Controls.Add((Control) ((Settings) this).DL);
            num1 = (int) num2 * 724052273 ^ -895385837;
            continue;
          case 61:
            gridViewCellStyle15 = new DataGridViewCellStyle();
            gridViewCellStyle9 = new DataGridViewCellStyle();
            gridViewCellStyle11 = new DataGridViewCellStyle();
            num1 = (int) num2 * -2066380722 ^ -726605843;
            continue;
          case 62:
            ((Settings) this).DGV2.AllowUserToAddRows = false;
            num1 = (int) num2 * -963134055 ^ -1240519401;
            continue;
          case 63:
            ((Settings) this).DGV6.ColumnHeadersVisible = false;
            ((Settings) this).DGV6.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn6, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn5);
            gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1323962197 ^ -1205617158;
            continue;
          case 64:
            ((Settings) this).DGV4.TabIndex = 12;
            ((Settings) this).DataGridViewTextBoxColumn4.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * -1580626632 ^ -224076796;
            continue;
          case 65:
            ((Settings) this).DataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            ((Settings) this).DataGridViewComboBoxColumn1.FlatStyle = FlatStyle.System;
            ((Settings) this).DataGridViewComboBoxColumn1.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * -1343802078 ^ 1870003287;
            continue;
          case 66:
            ((Settings) this).Column3.HeaderText = EXGuarder.\u00330180B63;
            ((Settings) this).Column3.ImageLayout = DataGridViewImageCellLayout.Stretch;
            num1 = (int) num2 * -1552198659 ^ -2052725588;
            continue;
          case 67:
            ((Settings) this).Label9.Padding = new Padding(0, 0, 0, 4);
            ((Settings) this).Label9.Size = new Size(352, 24);
            num1 = (int) num2 * -779241966 ^ -1025734254;
            continue;
          case 68:
            ((Settings) this).DGV5.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 955787536 ^ 469323532;
            continue;
          case 69:
            gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -794303532 ^ -437479695;
            continue;
          case 70:
            ((Settings) this).DGV5.AllowUserToDeleteRows = false;
            ((Settings) this).DGV5.AllowUserToResizeColumns = false;
            num1 = (int) num2 * -664560930 ^ 1430167727;
            continue;
          case 71:
            ((Settings) this).DGV8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 723308886 ^ 351178098;
            continue;
          case 72:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 467418667 ^ 669137266;
            continue;
          case 73:
            gridViewCellStyle14.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle14.ForeColor = Color.White;
            gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 1161907685 ^ 524775961;
            continue;
          case 74:
            ((Settings) this).DataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label2 = new Label();
            ((Settings) this).DGV0 = new DataGridView();
            num1 = (int) num2 * 1756445591 ^ 305968530;
            continue;
          case 75:
            ((Settings) this).Label4 = new Label();
            ((Settings) this).DGV2 = new DataGridView();
            num1 = (int) num2 * -1621294380 ^ -710912027;
            continue;
          case 76:
            ((Settings) this).DGV6.ScrollBars = ScrollBars.None;
            ((Settings) this).DGV6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 1225096796 ^ 729244523;
            continue;
          case 77:
            ((Settings) this).Clr8ToolStripMenuItem.Size = new Size(143, 22);
            num1 = (int) num2 * -2101379868 ^ -77231192;
            continue;
          case 78:
            ((Settings) this).DGV1.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1020814034 ^ -2126099827;
            continue;
          case 79:
            ((Settings) this).Clr4ToolStripMenuItem.Name = EXGuarder.\u0031660390D;
            ((Settings) this).Clr4ToolStripMenuItem.Size = new Size(143, 22);
            num1 = (int) num2 * 353780003 ^ 688904486;
            continue;
          case 80:
            ((Settings) this).Label8.TextAlign = ContentAlignment.MiddleLeft;
            ((Settings) this).DGV6.AllowUserToAddRows = false;
            ((Settings) this).DGV6.AllowUserToDeleteRows = false;
            ((Settings) this).DGV6.AllowUserToResizeColumns = false;
            num1 = (int) num2 * -164537414 ^ 2097236167;
            continue;
          case 81:
            ((Settings) this).DGV4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * 523565531 ^ -1018698007;
            continue;
          case 82:
            gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * -1834158045 ^ -1029869080;
            continue;
          case 83:
            ((Settings) this).DGV4.BackgroundColor = Color.Black;
            ((Settings) this).DGV4.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1698307966 ^ -146673823;
            continue;
          case 84:
            ((Settings) this).DGV7.Location = new Point(0, 758);
            ((Settings) this).DGV7.Name = EXGuarder.\u00306452D56;
            num1 = (int) num2 * -152771806 ^ 1252595785;
            continue;
          case 85:
            gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -1487902677 ^ -1344314500;
            continue;
          case 86:
            ((Settings) this).DGV6.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 2085253936 ^ 699819869;
            continue;
          case 87:
            ((Settings) this).DGV5.ColumnHeadersVisible = false;
            num1 = (int) num2 * 68742904 ^ -422946396;
            continue;
          case 88:
            gridViewCellStyle9.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle9.ForeColor = Color.White;
            num1 = (int) num2 * -132742049 ^ 580238363;
            continue;
          case 89:
            ((Settings) this).ctxPacket.Name = EXGuarder.\u00332372424;
            ((Settings) this).ctxPacket.ShowImageMargin = false;
            num1 = (int) num2 * 2073316177 ^ 1694357810;
            continue;
          case 90:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label7);
            num1 = (int) num2 * -1039609467 ^ 1182701485;
            continue;
          case 91:
            ((Settings) this).DGV8.AllowUserToDeleteRows = false;
            ((Settings) this).DGV8.AllowUserToResizeColumns = false;
            ((Settings) this).DGV8.AllowUserToResizeRows = false;
            num1 = (int) num2 * -409481124 ^ 1510959666;
            continue;
          case 92:
            ((Settings) this).DGV3.Dock = DockStyle.Top;
            ((Settings) this).DGV3.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * -1457342644 ^ 1705257636;
            continue;
          case 93:
            gridViewCellStyle16 = new DataGridViewCellStyle();
            num1 = (int) num2 * 906926540 ^ 119215277;
            continue;
          case 94:
            ((Settings) this).DataGridViewTextBoxColumn2.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * 1755103647 ^ -56154359;
            continue;
          case 95:
            gridViewCellStyle17.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -962372607 ^ -1269022143;
            continue;
          case 96:
            gridViewCellStyle11.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle11.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            gridViewCellStyle11.SelectionForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * -1275850691 ^ 1935492065;
            continue;
          case 97:
            ((Settings) this).Label8.Padding = new Padding(0, 0, 0, 4);
            ((Settings) this).Label8.Size = new Size(352, 24);
            ((Settings) this).Label8.TabIndex = 17;
            num1 = (int) num2 * -702747012 ^ 1473001827;
            continue;
          case 98:
            ((Settings) this).DGV0.Name = EXGuarder.\u0037053270E;
            ((Settings) this).DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * 596586149 ^ 540432784;
            continue;
          case 99:
            ((ISupportInitialize) ((Settings) this).DGV0).EndInit();
            ((Settings) this).Panel2.ResumeLayout(false);
            num1 = (int) num2 * -19893046 ^ -2086503854;
            continue;
          case 100:
            ((Settings) this).DGV7.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 2109775946 ^ -46380776;
            continue;
          case 101:
            ((Settings) this).Column2.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * -1274644807 ^ 752072001;
            continue;
          case 102:
            ((Settings) this).DGV1.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * -192982970 ^ -1908221077;
            continue;
          case 103:
            ((Settings) this).Label7.Location = new Point(0, 635);
            num1 = (int) num2 * -317763093 ^ 788896452;
            continue;
          case 104:
            ((Settings) this).Label6.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 1630190769 ^ -1965461379;
            continue;
          case 105:
            ((Settings) this).DGV4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV4.Size = new Size(352, 75);
            num1 = (int) num2 * -1255842461 ^ -982910859;
            continue;
          case 106:
            ((Settings) this).Label2.TabIndex = 5;
            ((Settings) this).Label2.Text = EXGuarder.\u003365B4535;
            ((Settings) this).Label2.TextAlign = ContentAlignment.MiddleLeft;
            ((Settings) this).DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -1796638104 ^ 820890624;
            continue;
          case 107:
            ((Settings) this).ctxPacket = new ContextMenuStrip(((SecurityKey) this).components);
            num1 = (int) num2 * 1418419996 ^ 904900485;
            continue;
          case 108:
            ((Settings) this).DGV5.BackgroundColor = Color.Black;
            num1 = (int) num2 * 1730338064 ^ -1570454820;
            continue;
          case 109:
            ((Settings) this).DGV5.TabIndex = 14;
            num1 = (int) num2 * 131908394 ^ -253992617;
            continue;
          case 110:
            ((Settings) this).Column1 = new DataGridViewTextBoxColumn();
            ((Settings) this).Column2 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label1 = new Label();
            num1 = (int) num2 * -994817283 ^ -1224282603;
            continue;
          case 111:
            ((Settings) this).DGV1.Dock = DockStyle.Top;
            num1 = (int) num2 * 725478950 ^ -1946748338;
            continue;
          case 112:
            ((Settings) this).DGV3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV3.RowHeadersVisible = false;
            num1 = (int) num2 * 1928667475 ^ 974281365;
            continue;
          case 113:
            ((Settings) this).Panel2.Dock = DockStyle.Bottom;
            ((Settings) this).Panel2.Location = new Point(0, 354);
            ((Settings) this).Panel2.Name = EXGuarder.\u0035B016972;
            num1 = (int) num2 * 770220177 ^ -828188189;
            continue;
          case 114:
            ((Settings) this).DGV9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * -1037107480 ^ -1224186519;
            continue;
          case 115:
            ((Settings) this).Label1.Text = EXGuarder.\u0033A615329;
            ((Settings) this).Label1.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 933955195 ^ -1403791761;
            continue;
          case 116:
            ((Settings) this).DGV9.AllowUserToResizeColumns = false;
            num1 = (int) num2 * -617817256 ^ 322047436;
            continue;
          case 117:
            ((Settings) this).DataGridViewComboBoxColumn6.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * 732062272 ^ 1041430562;
            continue;
          case 118:
            ((Settings) this).DataGridViewTextBoxColumn6.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn5.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * -1806116654 ^ 1744576825;
            continue;
          case 119:
            ((Settings) this).DGV7.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -372033458 ^ -135659864;
            continue;
          case 120:
            gridViewCellStyle12 = new DataGridViewCellStyle();
            gridViewCellStyle13 = new DataGridViewCellStyle();
            num1 = (int) num2 * 326252732 ^ -1933426809;
            continue;
          case 121:
            gridViewCellStyle12.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -1426188928 ^ -2098544513;
            continue;
          case 122:
            gridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -715159783 ^ -804694055;
            continue;
          case 123:
            ((Settings) this).DGV7.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV7.RowHeadersVisible = false;
            num1 = (int) num2 * 827466014 ^ -1285751118;
            continue;
          case 124:
            ((Settings) this).DGV3 = new DataGridView();
            num1 = (int) num2 * 2055491522 ^ -1743751357;
            continue;
          case 125:
            ((Settings) this).DGV6.Size = new Size(352, 75);
            ((Settings) this).DGV6.TabIndex = 16;
            num1 = (int) num2 * 982649392 ^ -142502766;
            continue;
          case 126:
            ((Settings) this).DGV4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1080777151 ^ -346725911;
            continue;
          case (uint) sbyte.MaxValue:
            ((Settings) this).Label8.BackColor = Color.FromArgb(35, 35, 35);
            ((Settings) this).Label8.Dock = DockStyle.Top;
            num1 = (int) num2 * 1617117209 ^ 1671811570;
            continue;
          case 128:
            ((Settings) this).DGV9.EditMode = DataGridViewEditMode.EditOnEnter;
            ((Settings) this).DGV9.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -1921568633 ^ 1180709887;
            continue;
          case 129:
            ((Settings) this).DataGridViewComboBoxColumn6 = new DataGridViewComboBoxColumn();
            num1 = (int) num2 * -1278714393 ^ 274617417;
            continue;
          case 130:
            ((Settings) this).DGV4.AllowUserToAddRows = false;
            num1 = (int) num2 * -1440804395 ^ -1799780955;
            continue;
          case 131:
            ((Settings) this).DGV7.DefaultCellStyle = gridViewCellStyle11;
            ((Settings) this).DGV7.Dock = DockStyle.Top;
            ((Settings) this).DGV7.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * -1920814584 ^ -314879756;
            continue;
          case 132:
            ((Settings) this).DGV6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -1400424959 ^ -302626316;
            continue;
          case 133:
            ((Settings) this).DataGridViewTextBoxColumn2.Name = EXGuarder.\u003405F5821;
            ((Settings) this).DataGridViewTextBoxColumn2.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * 1095054877 ^ 168673911;
            continue;
          case 134:
            ((Settings) this).DGV4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 191329301 ^ -922581585;
            continue;
          case 135:
            gridViewCellStyle19.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle19.ForeColor = Color.White;
            num1 = (int) num2 * -603141076 ^ -2140101750;
            continue;
          case 136:
            ((Settings) this).DGV6.BorderStyle = BorderStyle.None;
            ((Settings) this).DGV6.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1669518604 ^ 1705794616;
            continue;
          case 137:
            gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle18.BackColor = Color.Black;
            num1 = (int) num2 * -151838241 ^ -1773627274;
            continue;
          case 138:
            ((Settings) this).DGV7.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1284445473 ^ -1593894822;
            continue;
          case 139:
            gridViewCellStyle9.BackColor = Color.Black;
            num1 = (int) num2 * 876755224 ^ 1771902528;
            continue;
          case 140:
            ((Settings) this).DGV8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -649732980 ^ -823630339;
            continue;
          case 141:
            ((Settings) this).Label10.Dock = DockStyle.Top;
            num1 = (int) num2 * -60175974 ^ 1938459116;
            continue;
          case 142:
            ((ISupportInitialize) ((Settings) this).DGV1).BeginInit();
            num1 = (int) num2 * -1623452827 ^ -197135619;
            continue;
          case 143:
            ((Settings) this).Label6.Dock = DockStyle.Top;
            ((Settings) this).Label6.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -10388867 ^ 56217568;
            continue;
          case 144:
            ((Settings) this).DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ((Settings) this).DGV3.ColumnHeadersVisible = false;
            num1 = (int) num2 * 883493380 ^ -746194887;
            continue;
          case 145:
            ((Settings) this).DataGridViewTextBoxColumn9.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * 449001325 ^ -2081252822;
            continue;
          case 146:
            ((Settings) this).DGV3.EnableHeadersVisualStyles = false;
            ((Settings) this).DGV3.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -813358053 ^ 228938940;
            continue;
          case 147:
            ((Settings) this).DataGridViewTextBoxColumn9.Name = EXGuarder.\u0031E011149;
            num1 = (int) num2 * 213132319 ^ 1818423335;
            continue;
          case 148:
            ((Settings) this).DGV5.Location = new Point(0, 560);
            ((Settings) this).DGV5.Name = EXGuarder.\u00366651C3E;
            num1 = (int) num2 * -707584611 ^ 1280235326;
            continue;
          case 149:
            ((Settings) this).DGV1.Location = new Point(0, 164);
            num1 = (int) num2 * -120800145 ^ -1778513448;
            continue;
          case 150:
            ((Settings) this).SV.TabIndex = 14;
            ((Settings) this).SV.Text = EXGuarder.\u0031C3F415A;
            ((Settings) this).SV.UseVisualStyleBackColor = false;
            num1 = (int) num2 * 433052525 ^ -841998878;
            continue;
          case 151:
            ((Settings) this).Clr5ToolStripMenuItem.Size = new Size(143, 22);
            num1 = (int) num2 * -658540264 ^ 466919408;
            continue;
          case 152:
            ((Settings) this).DGV7.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1112699333 ^ 353263157;
            continue;
          case 153:
            ((Settings) this).DGV9.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * 1679718614 ^ 417053186;
            continue;
          case 154:
            gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            ((Settings) this).DGV1.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
            num1 = (int) num2 * -88366694 ^ 858576165;
            continue;
          case 155:
            ((Settings) this).DGV6.AllowUserToResizeRows = false;
            num1 = (int) num2 * 1580966401 ^ 1555428757;
            continue;
          case 156:
            ((Settings) this).DataGridViewComboBoxColumn6.Name = EXGuarder.\u0033839722C;
            num1 = (int) num2 * 1689056453 ^ -1298614639;
            continue;
          case 157:
            ((Settings) this).Clr5ToolStripMenuItem.Name = EXGuarder.\u0031C042B1F;
            num1 = (int) num2 * 1904059518 ^ 1654253735;
            continue;
          case 158:
            ((Settings) this).DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ((Settings) this).DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -435565222 ^ -1925276746;
            continue;
          case 159:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV0);
            num1 = (int) num2 * 1907788979 ^ 1812793322;
            continue;
          case 160:
            ((Settings) this).DataGridViewTextBoxColumn4.Name = EXGuarder.\u00306112370;
            ((Settings) this).DataGridViewTextBoxColumn4.ReadOnly = true;
            num1 = (int) num2 * 224740034 ^ -1249639976;
            continue;
          case 161:
            ((Settings) this).Column1.Name = EXGuarder.\u0033E040631;
            ((Settings) this).Column1.ReadOnly = true;
            ((Settings) this).Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).Column2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * 1487122506 ^ -1796185811;
            continue;
          case 162:
            gridViewCellStyle8.BackColor = Color.Black;
            gridViewCellStyle8.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1131515119 ^ 1125035865;
            continue;
          case 163:
            ((Settings) this).clr_1 = new ToolStripMenuItem();
            num1 = (int) num2 * 1319991334 ^ 1052423949;
            continue;
          case 164:
            ((Settings) this).DGV0.BackgroundColor = Color.Black;
            ((Settings) this).DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 2111250860 ^ -1005658233;
            continue;
          case 165:
            ((Settings) this).Label6 = new Label();
            num1 = (int) num2 * 1765585603 ^ 603613561;
            continue;
          case 166:
            ((Settings) this).Label8.Location = new Point(0, 734);
            num1 = (int) num2 * -843197315 ^ 566312968;
            continue;
          case 167:
            ((Settings) this).DGV6.ColumnHeadersDefaultCellStyle = gridViewCellStyle19;
            num1 = (int) num2 * -1532570927 ^ 403448989;
            continue;
          case 168:
            ((Settings) this).DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ((Settings) this).DGV2.ColumnHeadersVisible = false;
            ((Settings) this).DGV2.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn2, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn2);
            num1 = (int) num2 * -932700133 ^ 316795879;
            continue;
          case 169:
            gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -2128876579 ^ -1584902519;
            continue;
          case 170:
            ((Settings) this).Clr5ToolStripMenuItem.Text = EXGuarder.\u00336734123;
            num1 = (int) num2 * -1600459430 ^ -478673230;
            continue;
          case 171:
            ((Settings) this).DGV1.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn1, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn1);
            num1 = (int) num2 * 1833347608 ^ 1899858827;
            continue;
          case 172:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label2);
            num1 = (int) num2 * 732157843 ^ -817680461;
            continue;
          case 173:
            ((Settings) this).Label4.Padding = new Padding(0, 0, 0, 4);
            num1 = (int) num2 * -307314161 ^ 630323225;
            continue;
          case 174:
            gridViewCellStyle17.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            ((Settings) this).DGV5.DefaultCellStyle = gridViewCellStyle17;
            num1 = (int) num2 * 1406913079 ^ -1324630659;
            continue;
          case 175:
            gridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -1014424069 ^ 2095642260;
            continue;
          case 176:
            ((Settings) this).Label7.Text = EXGuarder.\u0032A65025F;
            num1 = (int) num2 * 1399924034 ^ -189881250;
            continue;
          case 177:
            ((Settings) this).DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -1971548743 ^ -637709829;
            continue;
          case 178:
            ((Settings) this).DataGridViewTextBoxColumn3.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            ((Settings) this).DataGridViewComboBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            ((Settings) this).DataGridViewComboBoxColumn3.FlatStyle = FlatStyle.System;
            ((Settings) this).DataGridViewComboBoxColumn3.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * -721440344 ^ -968351625;
            continue;
          case 179:
            ((ISupportInitialize) ((Settings) this).DGV4).EndInit();
            num1 = (int) num2 * -1053194082 ^ 1521047135;
            continue;
          case 180:
            ((Settings) this).DGV7.ColumnHeadersVisible = false;
            ((Settings) this).DGV7.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn7, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn6);
            num1 = (int) num2 * 1749101306 ^ 1715061063;
            continue;
          case 181:
            ((Settings) this).ctxPacket.Size = new Size(144, 224);
            num1 = (int) num2 * -454636059 ^ -1271800208;
            continue;
          case 182:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV8);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label9);
            num1 = (int) num2 * 1449294404 ^ 1853595151;
            continue;
          case 183:
            ((Settings) this).DGV8.DefaultCellStyle = gridViewCellStyle15;
            num1 = (int) num2 * -289867047 ^ 1601915417;
            continue;
          case 184:
            ((Settings) this).Panel1.Dock = DockStyle.Fill;
            ((Settings) this).Panel1.Location = new Point(0, 0);
            ((Settings) this).Panel1.Name = EXGuarder.\u00355583E44;
            num1 = (int) num2 * -1141004843 ^ -614113137;
            continue;
          case 185:
            ((Settings) this).DGV9.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -1554660070 ^ -547832895;
            continue;
          case 186:
            ((Settings) this).DGV4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ((Settings) this).DGV4.ColumnHeadersVisible = false;
            num1 = (int) num2 * -1197036775 ^ 1973024152;
            continue;
          case 187:
            ((Settings) this).DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 64158315 ^ -1969268000;
            continue;
          case 188:
            ((Settings) this).DataGridViewTextBoxColumn7.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn6.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * -799269069 ^ 1354148978;
            continue;
          case 189:
            ((ISupportInitialize) ((Settings) this).DGV2).EndInit();
            ((ISupportInitialize) ((Settings) this).DGV1).EndInit();
            num1 = (int) num2 * -716837377 ^ -894515928;
            continue;
          case 190:
            gridViewCellStyle12.BackColor = Color.Black;
            num1 = (int) num2 * -1754576082 ^ -123344902;
            continue;
          case 191:
            ((Settings) this).DataGridViewComboBoxColumn1.Name = EXGuarder.\u0032C1D131A;
            ((Settings) this).DataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.False;
            ((Settings) this).Label2.BackColor = Color.FromArgb(35, 35, 35);
            ((Settings) this).Label2.Dock = DockStyle.Top;
            ((Settings) this).Label2.ForeColor = Color.FromArgb(190, 190, 190);
            ((Settings) this).Label2.Location = new Point(0, 140);
            ((Settings) this).Label2.Name = EXGuarder.\u0035F446E15;
            ((Settings) this).Label2.Padding = new Padding(0, 0, 0, 4);
            num1 = (int) num2 * -1559012569 ^ -2106875669;
            continue;
          case 192:
            gridViewCellStyle18 = new DataGridViewCellStyle();
            num1 = (int) num2 * 455013282 ^ 2048758342;
            continue;
          case 193:
            ((Settings) this).DGV9.ColumnHeadersVisible = false;
            num1 = (int) num2 * -1887255382 ^ 1588061754;
            continue;
          case 194:
            ((Settings) this).Label10.ForeColor = Color.FromArgb(190, 190, 190);
            ((Settings) this).Label10.Location = new Point(0, 932);
            ((Settings) this).Label10.Name = EXGuarder.\u003000F221E;
            num1 = (int) num2 * 1464906645 ^ 481967089;
            continue;
          case 195:
            gridViewCellStyle10.NullValue = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject(EXGuarder.\u00313150349));
            num1 = (int) num2 * -1955820685 ^ -1157069498;
            continue;
          case 196:
            ((Settings) this).Clr6ToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -2001823186 ^ -2036482208;
            continue;
          case 197:
            gridViewCellStyle5.BackColor = Color.Black;
            num1 = (int) num2 * -735420169 ^ -1976773562;
            continue;
          case 198:
            gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -413612088 ^ -449948598;
            continue;
          case 199:
            gridViewCellStyle12.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -1278489761 ^ 1188034688;
            continue;
          case 200:
            ((Settings) this).Label9.Dock = DockStyle.Top;
            ((Settings) this).Label9.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 388096432 ^ -179302368;
            continue;
          case 201:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV5);
            num1 = (int) num2 * 173333182 ^ -2142997512;
            continue;
          case 202:
            gridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            ((Settings) this).DGV9.DefaultCellStyle = gridViewCellStyle16;
            ((Settings) this).DGV9.Dock = DockStyle.Top;
            num1 = (int) num2 * 495140113 ^ 583565336;
            continue;
          case 203:
            ((Settings) this).DataGridViewTextBoxColumn8.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.NotSortable;
            num1 = (int) num2 * -1638183306 ^ -1567422948;
            continue;
          case 204:
            ((Settings) this).DataGridViewComboBoxColumn5 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label7 = new Label();
            num1 = (int) num2 * 103882127 ^ 565943586;
            continue;
          case 205:
            ((Settings) this).DGV8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * -1427855574 ^ 2015904138;
            continue;
          case 206:
            ((Settings) this).DGV6.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 925258586 ^ 1035240281;
            continue;
          case 207:
            ((Settings) this).DataGridViewTextBoxColumn6.Name = EXGuarder.\u0033E3D6F39;
            num1 = (int) num2 * 1264598142 ^ 769955442;
            continue;
          case 208:
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * -1048120525 ^ -1208766944;
            continue;
          case 209:
            ((Settings) this).Clr8ToolStripMenuItem = new ToolStripMenuItem();
            ((Settings) this).Clr9ToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1386160279 ^ -254605013;
            continue;
          case 210:
            ((Settings) this).DGV5 = new DataGridView();
            ((Settings) this).DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1908001456 ^ -859256583;
            continue;
          case 211:
            ((Settings) this).DGV6.DefaultCellStyle = gridViewCellStyle7;
            num1 = (int) num2 * 316274210 ^ 536265747;
            continue;
          case 212:
            gridViewCellStyle17.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -421246577 ^ -1835269966;
            continue;
          case 213:
            ((Settings) this).DataGridViewComboBoxColumn6.Resizable = DataGridViewTriState.False;
            num1 = (int) num2 * 778746252 ^ -1659462939;
            continue;
          case 214:
            ((Settings) this).DGV8.Location = new Point(0, 857);
            ((Settings) this).DGV8.Name = EXGuarder.\u0034E4D6C5E;
            num1 = (int) num2 * 1159598156 ^ 1542799790;
            continue;
          case 215:
            ((Settings) this).Label6.Location = new Point(0, 536);
            num1 = (int) num2 * -1121255037 ^ 1217159231;
            continue;
          case 216:
            gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 2059626826 ^ 429805197;
            continue;
          case 217:
            ((Settings) this).DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -789923951 ^ 1121377076;
            continue;
          case 218:
            ((Settings) this).DGV9 = new DataGridView();
            num1 = (int) num2 * 876127801 ^ 1643365790;
            continue;
          case 219:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV2);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label3);
            num1 = (int) num2 * 456580191 ^ -1006445833;
            continue;
          case 220:
            ((Settings) this).clr_1.Size = new Size(143, 22);
            num1 = (int) num2 * 1638959985 ^ 1689650282;
            continue;
          case 221:
            gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 446906030 ^ -646986866;
            continue;
          case 222:
            gridViewCellStyle7.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle7.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * 1472644158 ^ 1910183908;
            continue;
          case 223:
            gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1436518668 ^ -187802624;
            continue;
          case 224:
            ((Settings) this).Label7.Dock = DockStyle.Top;
            ((Settings) this).Label7.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1555696181 ^ 1779934381;
            continue;
          case 225:
            gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle15.BackColor = Color.Black;
            gridViewCellStyle15.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle15.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -1435989587 ^ 53308017;
            continue;
          case 226:
            ((Settings) this).Label9.TabIndex = 19;
            num1 = (int) num2 * 173517998 ^ -1133681686;
            continue;
          case 227:
            ((ISupportInitialize) ((Settings) this).DGV8).EndInit();
            ((ISupportInitialize) ((Settings) this).DGV7).EndInit();
            num1 = (int) num2 * -1645324585 ^ -13933315;
            continue;
          case 228:
            ((Settings) this).clr_2.Name = EXGuarder.\u003272F5379;
            ((Settings) this).clr_2.Size = new Size(143, 22);
            ((Settings) this).clr_2.Text = EXGuarder.\u00359757049;
            ((Settings) this).Clr3ToolStripMenuItem.Name = EXGuarder.\u0036C5C486E;
            num1 = (int) num2 * -180116380 ^ 423049577;
            continue;
          case 229:
            ((Settings) this).Label7.Name = EXGuarder.\u00326654B26;
            ((Settings) this).Label7.Padding = new Padding(0, 0, 0, 4);
            num1 = (int) num2 * -606791652 ^ -2086071451;
            continue;
          case 230:
            ((Settings) this).DataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            ((Settings) this).DataGridViewComboBoxColumn4.DisplayStyleForCurrentCellOnly = true;
            ((Settings) this).DataGridViewComboBoxColumn4.FlatStyle = FlatStyle.System;
            ((Settings) this).DataGridViewComboBoxColumn4.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * -1927444221 ^ -2056131333;
            continue;
          case 231:
            gridViewCellStyle19 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1493399952 ^ -614777286;
            continue;
          case 232:
            ((Settings) this).Clr6ToolStripMenuItem.Name = EXGuarder.\u00329313041;
            ((Settings) this).Clr6ToolStripMenuItem.Size = new Size(143, 22);
            ((Settings) this).Clr6ToolStripMenuItem.Text = EXGuarder.\u0035D404770;
            ((Settings) this).Clr7ToolStripMenuItem.Name = EXGuarder.\u003220E0B4A;
            ((Settings) this).Clr7ToolStripMenuItem.Size = new Size(143, 22);
            ((Settings) this).Clr7ToolStripMenuItem.Text = EXGuarder.\u0033E2B6946;
            ((Settings) this).Clr8ToolStripMenuItem.Name = EXGuarder.\u00374295868;
            num1 = (int) num2 * -933199402 ^ -776001707;
            continue;
          case 233:
            ((Settings) this).DGV0.TabIndex = 4;
            num1 = (int) num2 * -230144981 ^ -1129523695;
            continue;
          case 234:
            ((Settings) this).Clr8ToolStripMenuItem.Text = EXGuarder.\u0035A580E6F;
            num1 = (int) num2 * -1115665954 ^ 942374759;
            continue;
          case 235:
            gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -398071227 ^ 175970381;
            continue;
          case 236:
            ((Settings) this).Column2.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * 1305588622 ^ -1368239219;
            continue;
          case 237:
            ((Settings) this).DGV0.EditMode = DataGridViewEditMode.EditOnEnter;
            ((Settings) this).DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 763742893 ^ -1297079632;
            continue;
          case 238:
            ((Settings) this).DataGridViewComboBoxColumn8.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * 303249685 ^ -106275479;
            continue;
          case 239:
            ((Settings) this).DataGridViewTextBoxColumn7.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * -1518523115 ^ 1419249345;
            continue;
          case 240:
            ((Settings) this).DGV1.BackgroundColor = Color.Black;
            num1 = (int) num2 * -1233102364 ^ -572501602;
            continue;
          case 241:
            ((Settings) this).DGV9.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -1880409241 ^ 1522303494;
            continue;
          case 242:
            ((Settings) this).DataGridViewComboBoxColumn3 = new DataGridViewComboBoxColumn();
            num1 = (int) num2 * 1488764986 ^ 404676861;
            continue;
          case 243:
            ((Settings) this).DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ((Settings) this).DGV1.ColumnHeadersVisible = false;
            num1 = (int) num2 * 321679590 ^ 2078675673;
            continue;
          case 244:
            gridViewCellStyle4.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle4.ForeColor = Color.White;
            gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -982097439 ^ 720058585;
            continue;
          case 245:
            ((Settings) this).DGV9.BackgroundColor = Color.Black;
            num1 = (int) num2 * 474088248 ^ 757593980;
            continue;
          case 246:
            gridViewCellStyle1.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.White;
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * -991918698 ^ -1360501778;
            continue;
          case 247:
            gridViewCellStyle13.ForeColor = Color.White;
            num1 = (int) num2 * 913388695 ^ 890633813;
            continue;
          case 248:
            gridViewCellStyle13.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1982662561 ^ 1558394427;
            continue;
          case 249:
            ((Settings) this).Clr3ToolStripMenuItem.Size = new Size(143, 22);
            ((Settings) this).Clr3ToolStripMenuItem.Text = EXGuarder.\u00316065E2D;
            num1 = (int) num2 * 203313777 ^ 2113783780;
            continue;
          case 250:
            ((Settings) this).Label4.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -308802480 ^ -579734742;
            continue;
          case 251:
            gridViewCellStyle7.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 364278951 ^ 205611895;
            continue;
          case 252:
            ((Settings) this).Panel2.SuspendLayout();
            num1 = (int) num2 * 2080598299 ^ 905233165;
            continue;
          case 253:
            ((Settings) this).DGV3.AllowUserToDeleteRows = false;
            ((Settings) this).DGV3.AllowUserToResizeColumns = false;
            ((Settings) this).DGV3.AllowUserToResizeRows = false;
            ((Settings) this).DGV3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -1831238199 ^ 972229456;
            continue;
          case 254:
            ((Settings) this).DGV2.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * -1810435294 ^ -1871676742;
            continue;
          case (uint) byte.MaxValue:
            ((Settings) this).DataGridViewComboBoxColumn2.Name = EXGuarder.\u0033C114252;
            ((Settings) this).DataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.False;
            ((Settings) this).Label3.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * 819080571 ^ 1165810223;
            continue;
          case 256:
            gridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 300230306 ^ -91265069;
            continue;
          case 257:
            ((Settings) this).Label1.Padding = new Padding(0, 0, 0, 4);
            ((Settings) this).Label1.Size = new Size(352, 24);
            num1 = (int) num2 * 1143556745 ^ 1783231819;
            continue;
          case 258:
            ((Settings) this).SV.BackColor = Color.FromArgb(190, 190, 190);
            ((Settings) this).SV.FlatStyle = FlatStyle.Flat;
            ((Settings) this).SV.ForeColor = Color.Black;
            ((Settings) this).SV.Location = new Point(285, 8);
            ((Settings) this).SV.Name = EXGuarder.\u0035904756C;
            ((Settings) this).SV.Size = new Size(81, 23);
            num1 = (int) num2 * 1075085847 ^ 1437531752;
            continue;
          case 259:
            ((Settings) this).DataGridViewComboBoxColumn4 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label5 = new Label();
            num1 = (int) num2 * 1760374851 ^ -796937701;
            continue;
          case 260:
            ((Settings) this).DGV5.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ((Settings) this).DGV5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle6.BackColor = Color.Black;
            num1 = (int) num2 * 1468489473 ^ 784960478;
            continue;
          case 261:
            ((Settings) this).DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
            num1 = (int) num2 * -1034159775 ^ -1859892769;
            continue;
          case 262:
            ((Settings) this).DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -51699854 ^ 1529784273;
            continue;
          case 263:
            ((Settings) this).Label7.TabIndex = 15;
            num1 = (int) num2 * 273671301 ^ -1755967763;
            continue;
          case 264:
            ((Settings) this).DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ((Settings) this).DGV1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -57885252 ^ 397239810;
            continue;
          case 265:
            gridViewCellStyle17.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1985491991 ^ 288326816;
            continue;
          case 266:
            ((Settings) this).DataGridViewTextBoxColumn7.Name = EXGuarder.\u00372677339;
            num1 = (int) num2 * 504063727 ^ 1481292340;
            continue;
          case 267:
            ((Settings) this).DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 1811608117 ^ -1005677457;
            continue;
          case 268:
            ((Settings) this).DL.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num2 * -1236173057 ^ -588203210;
            continue;
          case 269:
            ((Settings) this).clr_2 = new ToolStripMenuItem();
            ((Settings) this).Clr3ToolStripMenuItem = new ToolStripMenuItem();
            ((Settings) this).Clr4ToolStripMenuItem = new ToolStripMenuItem();
            ((Settings) this).Clr5ToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1102278914 ^ -32352564;
            continue;
          case 270:
            gridViewCellStyle16.SelectionForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * 10939578 ^ 1923295772;
            continue;
          case 271:
            gridViewCellStyle5.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -2040701710 ^ -1006468202;
            continue;
          case 272:
            ((Settings) this).Label7.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1302379840 ^ -875783243;
            continue;
          case 273:
            ((Settings) this).DGV3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 752522734 ^ -517041459;
            continue;
          case 274:
            ((Settings) this).DGV6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -630100724 ^ 1422424185;
            continue;
          case 275:
            ((Settings) this).DL.FlatStyle = FlatStyle.Flat;
            ((Settings) this).DL.ForeColor = Color.Black;
            num1 = (int) num2 * 1264539468 ^ 135004355;
            continue;
          case 276:
            ((Settings) this).DGV2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * 1572362124 ^ 2026796336;
            continue;
          case 277:
            ((Settings) this).Label10.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -1849629582 ^ -572327951;
            continue;
          case 278:
            ((Settings) this).DataGridViewTextBoxColumn9.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn8.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * -1658635830 ^ -1839289512;
            continue;
          case 279:
            ((Settings) this).DGV2.BackgroundColor = Color.Black;
            ((Settings) this).DGV2.BorderStyle = BorderStyle.None;
            ((Settings) this).DGV2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1950697079 ^ 801484053;
            continue;
          case 280:
            goto label_1;
          case 281:
            ((Settings) this).Label8.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1743389796 ^ -865947996;
            continue;
          case 282:
            ((Settings) this).DataGridViewTextBoxColumn1.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * -1611186864 ^ -641575064;
            continue;
          case 283:
            ((Settings) this).Column2.DisplayStyleForCurrentCellOnly = true;
            num1 = (int) num2 * -1328648127 ^ 1640772909;
            continue;
          case 284:
            ((Settings) this).Label6.Name = EXGuarder.\u003216E4D67;
            num1 = (int) num2 * 914526949 ^ 626346511;
            continue;
          case 285:
            ((Settings) this).DGV2.AllowUserToDeleteRows = false;
            num1 = (int) num2 * -2046949681 ^ -145231374;
            continue;
          case 286:
            ((Settings) this).DGV7.AllowUserToAddRows = false;
            num1 = (int) num2 * 973236456 ^ -700059452;
            continue;
          case 287:
            ((Settings) this).Panel1.Size = new Size(369, 354);
            ((Settings) this).Panel1.TabIndex = 1;
            ((Settings) this).DGV9.AllowUserToAddRows = false;
            ((Settings) this).DGV9.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 475362096 ^ 923656182;
            continue;
          case 288:
            ((Settings) this).Column1.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * 722040941 ^ -1829377649;
            continue;
          case 289:
            ((Settings) this).DGV0.DefaultCellStyle = gridViewCellStyle20;
            num1 = (int) num2 * -49986606 ^ -1081618534;
            continue;
          case 290:
            ((Settings) this).Clr9ToolStripMenuItem.Size = new Size(143, 22);
            ((Settings) this).Clr9ToolStripMenuItem.Text = EXGuarder.\u00311023B79;
            num1 = (int) num2 * 1804207422 ^ -2073032041;
            continue;
          case 291:
            ((Settings) this).DGV6.GridColor = Color.FromArgb(42, 42, 42);
            ((Settings) this).DGV6.Location = new Point(0, 659);
            ((Settings) this).DGV6.Name = EXGuarder.\u00352037334;
            num1 = (int) num2 * -1512922736 ^ -1656106691;
            continue;
          case 292:
            ((Settings) this).Column3.Resizable = DataGridViewTriState.False;
            ((Settings) this).Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            ((Settings) this).Column3.Width = 5;
            num1 = (int) num2 * -717412997 ^ 102845218;
            continue;
          case 293:
            ((Settings) this).Label3.ForeColor = Color.FromArgb(190, 190, 190);
            ((Settings) this).Label3.Location = new Point(0, 239);
            ((Settings) this).Label3.Name = EXGuarder.\u0032C4D0468;
            num1 = (int) num2 * -305195816 ^ -1658045605;
            continue;
          case 294:
            ((Settings) this).DGV5.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * -1282310823 ^ 911671321;
            continue;
          case 295:
            gridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -1415153119 ^ 180146962;
            continue;
          case 296:
            ((Settings) this).DGV8.BorderStyle = BorderStyle.None;
            ((Settings) this).DGV8.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1934053354 ^ 1564782249;
            continue;
          case 297:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label4);
            num1 = (int) num2 * -1698090214 ^ 704925519;
            continue;
          case 298:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV3);
            num1 = (int) num2 * -1349438616 ^ -2023294725;
            continue;
          case 299:
            ((Settings) this).DGV5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * 848589265 ^ -1877706422;
            continue;
          case 300:
            ((Settings) this).ctxPacket.Items.AddRange(new ToolStripItem[10]
            {
              (ToolStripItem) ((Settings) this).DefaultToolStripMenuItem,
              (ToolStripItem) ((Settings) this).clr_1,
              (ToolStripItem) ((Settings) this).clr_2,
              (ToolStripItem) ((Settings) this).Clr3ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr4ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr5ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr6ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr7ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr8ToolStripMenuItem,
              (ToolStripItem) ((Settings) this).Clr9ToolStripMenuItem
            });
            num1 = (int) num2 * -12045832 ^ -1574025753;
            continue;
          case 301:
            ((Settings) this).Label9.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -54167598 ^ -687232386;
            continue;
          case 302:
            gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ((Settings) this).DGV5.ColumnHeadersDefaultCellStyle = gridViewCellStyle6;
            num1 = (int) num2 * 385413629 ^ -763237841;
            continue;
          case 303:
            ((Settings) this).DGV9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * -725277554 ^ 1401468747;
            continue;
          case 304:
            ((Control) this).SuspendLayout();
            num1 = (int) num2 * -201311070 ^ -218724967;
            continue;
          case 305:
            ((Settings) this).DGV1.DefaultCellStyle = gridViewCellStyle8;
            num1 = (int) num2 * 1874720567 ^ 1540140466;
            continue;
          case 306:
            ((Settings) this).DGV2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV2.RowHeadersVisible = false;
            num1 = (int) num2 * 208091237 ^ -1408125687;
            continue;
          case 307:
            ((ISupportInitialize) ((Settings) this).DGV8).BeginInit();
            num1 = (int) num2 * 503815077 ^ -782596165;
            continue;
          case 308:
            gridViewCellStyle20 = new DataGridViewCellStyle();
            num1 = (int) num2 * -2053718895 ^ -756902440;
            continue;
          case 309:
            ((Settings) this).TOpacity = new Timer(((SecurityKey) this).components);
            num1 = (int) num2 * 1122307025 ^ -306058848;
            continue;
          case 310:
            ((Settings) this).DGV7.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1979293350 ^ 1631067074;
            continue;
          case 311:
            ((Settings) this).DataGridViewComboBoxColumn8.HeaderText = EXGuarder.\u00330180B63;
            ((Settings) this).DataGridViewComboBoxColumn8.Name = EXGuarder.\u0031509351A;
            ((Settings) this).DataGridViewComboBoxColumn8.Resizable = DataGridViewTriState.False;
            num1 = (int) num2 * -1621561860 ^ 1557035457;
            continue;
          case 312:
            ((Settings) this).DGV0.Dock = DockStyle.Top;
            num1 = (int) num2 * 204552920 ^ 1847958719;
            continue;
          case 313:
            ((Settings) this).DGV2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 30317476 ^ 1715099553;
            continue;
          case 314:
            ((Settings) this).Label5.Dock = DockStyle.Top;
            ((Settings) this).Label5.ForeColor = Color.FromArgb(190, 190, 190);
            ((Settings) this).Label5.Location = new Point(0, 437);
            num1 = (int) num2 * -1603006186 ^ 541210834;
            continue;
          case 315:
            gridViewCellStyle8.SelectionForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * -1522040294 ^ 1155947880;
            continue;
          case 316:
            ((Settings) this).DGV8.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -1568518548 ^ 28298863;
            continue;
          case 317:
            ((Settings) this).Column3 = new DataGridViewImageColumn();
            num1 = (int) num2 * -666991347 ^ -2045267030;
            continue;
          case 318:
            ((Settings) this).DGV3.AllowUserToAddRows = false;
            num1 = (int) num2 * 66635165 ^ 470051453;
            continue;
          case 319:
            ((Settings) this).DGV7.BackgroundColor = Color.Black;
            num1 = (int) num2 * 1956768749 ^ -1826795100;
            continue;
          case 320:
            ((Form) this).ClientSize = new Size(369, 388);
            num1 = (int) num2 * 1559143859 ^ 2107598034;
            continue;
          case 321:
            ((Settings) this).ctxPacket.SuspendLayout();
            num1 = (int) num2 * 2007394404 ^ 1031164250;
            continue;
          case 322:
            ((Settings) this).Label5.Name = EXGuarder.\u0034A216B46;
            num1 = (int) num2 * 1519071364 ^ 753581700;
            continue;
          case 323:
            ((ISupportInitialize) ((Settings) this).DGV3).EndInit();
            num1 = (int) num2 * -1105734377 ^ 336100454;
            continue;
          case 324:
            ((Settings) this).DGV5.Size = new Size(352, 75);
            num1 = (int) num2 * 693161885 ^ -171849357;
            continue;
          case 325:
            ((Settings) this).Column3.DefaultCellStyle = gridViewCellStyle10;
            ((Settings) this).Column3.FillWeight = 21f;
            num1 = (int) num2 * 1794435054 ^ -1648098248;
            continue;
          case 326:
            ((Settings) this).DGV0.AllowUserToDeleteRows = false;
            ((Settings) this).DGV0.AllowUserToResizeColumns = false;
            ((Settings) this).DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -700237284 ^ 1823541890;
            continue;
          case 327:
            ((Settings) this).DGV2.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 625831751 ^ -1483745485;
            continue;
          case 328:
            ((Settings) this).DGV4 = new DataGridView();
            ((Settings) this).DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -655801442 ^ 1063328487;
            continue;
          case 329:
            gridViewCellStyle6.ForeColor = Color.White;
            num1 = (int) num2 * -1168482676 ^ 983906279;
            continue;
          case 330:
            ((Settings) this).DGV4.Name = EXGuarder.\u0034B071309;
            num1 = (int) num2 * -518875781 ^ 914090028;
            continue;
          case 331:
            gridViewCellStyle11.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1931233709 ^ -1215381929;
            continue;
          case 332:
            ((ISupportInitialize) ((Settings) this).DGV5).EndInit();
            num1 = (int) num2 * -853190856 ^ 2108694259;
            continue;
          case 333:
            gridViewCellStyle14.BackColor = Color.Black;
            num1 = (int) num2 * -1666591893 ^ 711377452;
            continue;
          case 334:
            gridViewCellStyle2 = new DataGridViewCellStyle();
            num1 = (int) num2 * 703007445 ^ 2041494856;
            continue;
          case 335:
            ((Settings) this).Panel2.BackColor = Color.Black;
            num1 = (int) num2 * 822040807 ^ -859600085;
            continue;
          case 336:
            gridViewCellStyle18.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 2141757193 ^ 61334268;
            continue;
          case 337:
            ((Settings) this).DataGridViewComboBoxColumn5.Resizable = DataGridViewTriState.False;
            ((Settings) this).Label7.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -160306432 ^ 84136774;
            continue;
          case 338:
            ((Settings) this).DGV6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * -1034043759 ^ -1656978419;
            continue;
          case 339:
            gridViewCellStyle20.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -555780722 ^ -1478083875;
            continue;
          case 340:
            ((Settings) this).Label5.Padding = new Padding(0, 0, 0, 4);
            ((Settings) this).Label5.Size = new Size(352, 24);
            ((Settings) this).Label5.TabIndex = 11;
            ((Settings) this).Label5.Text = EXGuarder.\u003385B430D;
            num1 = (int) num2 * -519347110 ^ -1331787965;
            continue;
          case 341:
            ((Settings) this).DGV1.AllowUserToResizeRows = false;
            num1 = (int) num2 * 642229789 ^ -132732351;
            continue;
          case 342:
            ((Settings) this).Label8.Name = EXGuarder.\u00342663F20;
            num1 = (int) num2 * -362446559 ^ -1795793813;
            continue;
          case 343:
            ((Settings) this).Label6.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 595678084 ^ -1653542366;
            continue;
          case 344:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 749421673 ^ 257209724;
            continue;
          case 345:
            gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle17.BackColor = Color.Black;
            num1 = (int) num2 * 1487666953 ^ -846610736;
            continue;
          case 346:
            gridViewCellStyle12.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle12.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 331217906 ^ 725770309;
            continue;
          case 347:
            ((Settings) this).DGV2.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * 65021059 ^ 1003638044;
            continue;
          case 348:
            gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 592619484 ^ -1324628391;
            continue;
          case 349:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label1);
            num1 = (int) num2 * -1927391617 ^ 384046269;
            continue;
          case 350:
            ((Settings) this).DataGridViewComboBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            ((Settings) this).DataGridViewComboBoxColumn2.FlatStyle = FlatStyle.System;
            ((Settings) this).DataGridViewComboBoxColumn2.HeaderText = EXGuarder.\u00330180B63;
            num1 = (int) num2 * 627182435 ^ -1656600903;
            continue;
          case 351:
            ((Settings) this).DGV7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV7.Size = new Size(352, 75);
            num1 = (int) num2 * -2087387489 ^ -2067688068;
            continue;
          case 352:
            ((Settings) this).DGV4.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * -14331355 ^ -2050330283;
            continue;
          case 353:
            ((Settings) this).Label3.Padding = new Padding(0, 0, 0, 4);
            num1 = (int) num2 * -294768431 ^ 971545838;
            continue;
          case 354:
            ((Settings) this).DataGridViewComboBoxColumn7.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            ((Settings) this).DataGridViewComboBoxColumn7.DisplayStyleForCurrentCellOnly = true;
            ((Settings) this).DataGridViewComboBoxColumn7.FlatStyle = FlatStyle.System;
            ((Settings) this).DataGridViewComboBoxColumn7.HeaderText = EXGuarder.\u00330180B63;
            ((Settings) this).DataGridViewComboBoxColumn7.Name = EXGuarder.\u0031114751C;
            num1 = (int) num2 * 1606078334 ^ 1948976350;
            continue;
          case 355:
            ((Settings) this).DGV9.RowHeadersVisible = false;
            ((Settings) this).DGV9.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * 2057548683 ^ 961886047;
            continue;
          case 356:
            ((Settings) this).Column2.Name = EXGuarder.\u00354212F4D;
            ((Settings) this).Column2.Resizable = DataGridViewTriState.False;
            ((Settings) this).Label1.BackColor = Color.FromArgb(35, 35, 35);
            ((Settings) this).Label1.Dock = DockStyle.Top;
            ((Settings) this).Label1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -421310261 ^ -86126031;
            continue;
          case 357:
            ((Settings) this).DL.Location = new Point(198, 8);
            num1 = (int) num2 * 987754805 ^ 898597033;
            continue;
          case 358:
            gridViewCellStyle3.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle3.ForeColor = Color.White;
            num1 = (int) num2 * 1823736309 ^ 985832797;
            continue;
          case 359:
            ((ISupportInitialize) ((Settings) this).DGV0).BeginInit();
            num1 = (int) num2 * 2145876722 ^ 685924328;
            continue;
          case 360:
            ((Settings) this).DGV9.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * -794110240 ^ -1931612895;
            continue;
          case 361:
            ((Settings) this).DGV4.Location = new Point(0, 461);
            num1 = (int) num2 * 1531876509 ^ 1624705339;
            continue;
          case 362:
            gridViewCellStyle15.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            gridViewCellStyle15.SelectionForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * 1222225270 ^ -641485693;
            continue;
          case 363:
            gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * 124677799 ^ 1414812942;
            continue;
          case 364:
            ((Settings) this).Label4.Text = EXGuarder.\u0034D4C3C66;
            ((Settings) this).Label4.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -402726221 ^ 1279383100;
            continue;
          case 365:
            ((Settings) this).Label7.Size = new Size(352, 24);
            num1 = (int) num2 * -1834351905 ^ 1285475562;
            continue;
          case 366:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label5);
            num1 = (int) num2 * 1345182165 ^ -813936098;
            continue;
          case 367:
            ((Settings) this).DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -863212248 ^ -1317239988;
            continue;
          case 368:
            ((Settings) this).DataGridViewTextBoxColumn1.Name = EXGuarder.\u0031C5C0417;
            num1 = (int) num2 * -1793852366 ^ 2106712667;
            continue;
          case 369:
            gridViewCellStyle8.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle8.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -1398579149 ^ -853449546;
            continue;
          case 370:
            ((Settings) this).DL.Name = EXGuarder.\u00305765277;
            num1 = (int) num2 * -1234976565 ^ -1631069402;
            continue;
          case 371:
            ((Settings) this).DGV5.AllowUserToResizeRows = false;
            ((Settings) this).DGV5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ((Settings) this).DGV5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -1745298581 ^ 1672214745;
            continue;
          case 372:
            ((Settings) this).DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ((Settings) this).DGV0.ColumnHeadersVisible = false;
            ((Settings) this).DGV0.Columns.AddRange((DataGridViewColumn) ((Settings) this).Column1, (DataGridViewColumn) ((Settings) this).Column2);
            num1 = (int) num2 * -1250084835 ^ 498484119;
            continue;
          case 373:
            ((Settings) this).DGV8.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -655301961 ^ -467694321;
            continue;
          case 374:
            ((Settings) this).DGV2.Dock = DockStyle.Top;
            num1 = (int) num2 * -648778427 ^ -778701229;
            continue;
          case 375:
            gridViewCellStyle8 = new DataGridViewCellStyle();
            num1 = (int) num2 * 624026512 ^ 972019858;
            continue;
          case 376:
            ((Settings) this).DataGridViewTextBoxColumn6.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * 886418265 ^ 2115698685;
            continue;
          case 377:
            ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
            ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * -1585930436 ^ 1458687546;
            continue;
          case 378:
            ((Settings) this).Label9.Text = EXGuarder.\u0032F670E69;
            num1 = (int) num2 * -1079622157 ^ -11863961;
            continue;
          case 379:
            ((Settings) this).DGV8.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -1575335372 ^ 1401767317;
            continue;
          case 380:
            ((Settings) this).DGV4.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * 106742108 ^ -997239612;
            continue;
          case 381:
            gridViewCellStyle3.BackColor = Color.Black;
            num1 = (int) num2 * -31256681 ^ 1541935813;
            continue;
          case 382:
            ((Settings) this).DGV4.RowHeadersVisible = false;
            num1 = (int) num2 * -921069387 ^ 573620678;
            continue;
          case 383:
            ((Settings) this).DGV0.Size = new Size(352, 116);
            num1 = (int) num2 * -473294491 ^ 1727173632;
            continue;
          case 384:
            ((Settings) this).DGV9.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn9, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn8);
            gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle16.BackColor = Color.Black;
            num1 = (int) num2 * 2026811744 ^ -756572402;
            continue;
          case 385:
            ((Settings) this).DGV5.AllowUserToAddRows = false;
            num1 = (int) num2 * 1470532082 ^ 1661863068;
            continue;
          case 386:
            ((Settings) this).DGV9.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            ((Settings) this).DGV9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * -1337598468 ^ -1563073755;
            continue;
          case 387:
            gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ((Settings) this).DGV7.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
            num1 = (int) num2 * 1417570635 ^ 1261470989;
            continue;
          case 388:
            ((Settings) this).DGV6.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * 1240386093 ^ 340836076;
            continue;
          case 389:
            ((Settings) this).DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -1353463081 ^ -635859285;
            continue;
          case 390:
            ((Settings) this).DGV1.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * 1212152284 ^ -615652615;
            continue;
          case 391:
            gridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle19.BackColor = Color.Black;
            num1 = (int) num2 * 554749088 ^ 1636896271;
            continue;
          case 392:
            gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * -1895836954 ^ 1989349579;
            continue;
          case 393:
            ((Settings) this).DGV5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 1947473871 ^ -1235432737;
            continue;
          case 394:
            ((Settings) this).Label8 = new Label();
            ((Settings) this).DGV6 = new DataGridView();
            num1 = (int) num2 * 2100547825 ^ -2007901103;
            continue;
          case 395:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV7);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label8);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV6);
            num1 = (int) num2 * 360421084 ^ 2055351198;
            continue;
          case 396:
            ((Settings) this).DGV7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            num1 = (int) num2 * 2045659737 ^ -2084606404;
            continue;
          case 397:
            ((Settings) this).DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV2.Size = new Size(352, 75);
            ((Settings) this).DGV2.TabIndex = 8;
            num1 = (int) num2 * -983099122 ^ -159705116;
            continue;
          case 398:
            ((Settings) this).DGV8.AllowUserToAddRows = false;
            num1 = (int) num2 * 587802716 ^ 2066507207;
            continue;
          case 399:
            ((Settings) this).DataGridViewTextBoxColumn1.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ((Settings) this).DataGridViewComboBoxColumn1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            num1 = (int) num2 * 1663043368 ^ 959154149;
            continue;
          case 400:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV1);
            num1 = (int) num2 * 358474325 ^ -1350271700;
            continue;
          case 401:
            ((Settings) this).DGV6.Dock = DockStyle.Top;
            num1 = (int) num2 * -944694082 ^ 946063134;
            continue;
          case 402:
            ((Settings) this).DGV7.ScrollBars = ScrollBars.None;
            num1 = (int) num2 * 1127848608 ^ -1014389783;
            continue;
          case 403:
            ((Settings) this).DataGridViewComboBoxColumn5.DisplayStyleForCurrentCellOnly = true;
            num1 = (int) num2 * -2006624468 ^ 1406316501;
            continue;
          case 404:
            ((Settings) this).DGV4.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 1175124824 ^ -1853913041;
            continue;
          case 405:
            ((Settings) this).SV = new Button();
            ((Settings) this).DL = new Button();
            ((Settings) this).Panel2 = new Panel();
            num1 = (int) num2 * 80623923 ^ 638026226;
            continue;
          case 406:
            gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -849052633 ^ -556284600;
            continue;
          case 407:
            ((Settings) this).Panel1.AutoScroll = true;
            ((Settings) this).Panel1.BackColor = Color.DimGray;
            num1 = (int) num2 * -850085979 ^ -772074153;
            continue;
          case 408:
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).DGV9);
            ((Settings) this).Panel1.Controls.Add((Control) ((Settings) this).Label10);
            num1 = (int) num2 * -1587056939 ^ -795820250;
            continue;
          case 409:
            ((Settings) this).DataGridViewTextBoxColumn5.FillWeight = 178.6802f;
            ((Settings) this).DataGridViewTextBoxColumn5.HeaderText = EXGuarder.\u003584C3A15;
            ((Settings) this).DataGridViewTextBoxColumn5.Name = EXGuarder.\u0036E114911;
            ((Settings) this).DataGridViewTextBoxColumn5.ReadOnly = true;
            ((Settings) this).DataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
            num1 = (int) num2 * -350720546 ^ -1956919813;
            continue;
          case 410:
            ((Settings) this).Panel1.SuspendLayout();
            ((ISupportInitialize) ((Settings) this).DGV9).BeginInit();
            num1 = (int) num2 * 2089721233 ^ 590555113;
            continue;
          case 411:
            ((Settings) this).Label5.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -2016150196 ^ 2044670108;
            continue;
          case 412:
            ((Settings) this).DGV8.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn8, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn7);
            num1 = (int) num2 * 1003404429 ^ 1214653999;
            continue;
          case 413:
            gridViewCellStyle4 = new DataGridViewCellStyle();
            num1 = (int) num2 * 403801955 ^ -1236618880;
            continue;
          case 414:
            gridViewCellStyle4.BackColor = Color.Black;
            num1 = (int) num2 * 1747977152 ^ -152478984;
            continue;
          case 415:
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1845710215 ^ -1690189302;
            continue;
          case 416:
            ((Settings) this).DefaultToolStripMenuItem.Size = new Size(143, 22);
            ((Settings) this).DefaultToolStripMenuItem.Text = EXGuarder.\u00340471A1C;
            ((Settings) this).clr_1.Name = EXGuarder.\u00304767841;
            num1 = (int) num2 * -1888658038 ^ 1522664840;
            continue;
          case 417:
            ((Settings) this).DGV9.Location = new Point(0, 956);
            num1 = (int) num2 * 435165092 ^ 78912339;
            continue;
          case 418:
            ((Settings) this).Label4.Location = new Point(0, 338);
            ((Settings) this).Label4.Name = EXGuarder.\u0031A2F2D38;
            num1 = (int) num2 * 1103317996 ^ 391100981;
            continue;
          case 419:
            ((Settings) this).DGV5.Dock = DockStyle.Top;
            ((Settings) this).DGV5.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * -1928405773 ^ -1835246567;
            continue;
          case 420:
            gridViewCellStyle7.SelectionForeColor = Color.FromArgb(240, 240, 240);
            gridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -757686367 ^ 803328127;
            continue;
          case 421:
            gridViewCellStyle11.BackColor = Color.Black;
            num1 = (int) num2 * 1658163983 ^ -2080345966;
            continue;
          case 422:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 1951365212 ^ -1125503286;
            continue;
          case 423:
            ((Settings) this).DGV3.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn3, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn3);
            num1 = (int) num2 * 2017005489 ^ 528577513;
            continue;
          case 424:
            gridViewCellStyle7 = new DataGridViewCellStyle();
            gridViewCellStyle6 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1105665383 ^ -176160029;
            continue;
          case 425:
            gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            num1 = (int) num2 * 2029923529 ^ 278808578;
            continue;
          case 426:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle2.ForeColor = Color.White;
            num1 = (int) num2 * 1598179513 ^ -619700584;
            continue;
          case 427:
            ((Settings) this).Label1.Name = EXGuarder.\u0034A476E0B;
            num1 = (int) num2 * -1028722579 ^ -1936464588;
            continue;
          case 428:
            ((Settings) this).DGV0.ScrollBars = ScrollBars.None;
            ((Settings) this).DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 759708940 ^ 1539049993;
            continue;
          case 429:
            ((Settings) this).Label10.Size = new Size(352, 24);
            ((Settings) this).Label10.TabIndex = 21;
            ((Settings) this).Label10.Text = EXGuarder.\u003293A793E;
            ((Settings) this).Label10.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -841900297 ^ 1517552247;
            continue;
          case 430:
            ((Settings) this).ctxPacket.ResumeLayout(false);
            num1 = (int) num2 * 54241945 ^ -738430737;
            continue;
          case 431:
            ((Settings) this).DGV3.Name = EXGuarder.\u00332425E42;
            num1 = (int) num2 * 1905989422 ^ -719331442;
            continue;
          case 432:
            ((Settings) this).DGV8.Dock = DockStyle.Top;
            ((Settings) this).DGV8.EditMode = DataGridViewEditMode.EditOnEnter;
            num1 = (int) num2 * -131662532 ^ 1392235662;
            continue;
          case 433:
            ((Settings) this).DGV8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV8.Size = new Size(352, 75);
            ((Settings) this).DGV8.TabIndex = 20;
            ((Settings) this).DataGridViewTextBoxColumn8.HeaderText = EXGuarder.\u003584C3A15;
            num1 = (int) num2 * -349156023 ^ -276291962;
            continue;
          case 434:
            ((Settings) this).SV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num2 * -723654565 ^ -195604920;
            continue;
          case 435:
            ((Settings) this).Clr4ToolStripMenuItem.Text = EXGuarder.\u00341421D3E;
            num1 = (int) num2 * -398038626 ^ 739886073;
            continue;
          case 436:
            ((Settings) this).Panel2.Size = new Size(369, 34);
            ((Settings) this).Panel2.TabIndex = 16;
            num1 = (int) num2 * 1385647983 ^ -1152991941;
            continue;
          case 437:
            ((Settings) this).DataGridViewComboBoxColumn5.HeaderText = EXGuarder.\u00330180B63;
            ((Settings) this).DataGridViewComboBoxColumn5.Name = EXGuarder.\u0033B636933;
            num1 = (int) num2 * -305138050 ^ -605416827;
            continue;
          case 438:
            ((Settings) this).DGV5.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV5.RowHeadersVisible = false;
            num1 = (int) num2 * 1808845033 ^ 876801768;
            continue;
          case 439:
            gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -129386900 ^ -928102783;
            continue;
          case 440:
            ((Settings) this).Panel1 = new Panel();
            num1 = (int) num2 * 470008123 ^ 996813536;
            continue;
          case 441:
            ((Settings) this).DGV7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * -124949810 ^ 1506970351;
            continue;
          case 442:
            ((Settings) this).DL.Size = new Size(81, 23);
            ((Settings) this).DL.TabIndex = 15;
            ((Settings) this).DL.Text = EXGuarder.\u003220F0737;
            ((Settings) this).DL.UseVisualStyleBackColor = false;
            num1 = (int) num2 * 1616845917 ^ 393424785;
            continue;
          case 443:
            ((Settings) this).DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((Settings) this).DataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label3 = new Label();
            num1 = (int) num2 * -1311582920 ^ -1990574205;
            continue;
          case 444:
            ((Settings) this).DGV8.BackgroundColor = Color.Black;
            num1 = (int) num2 * -24331056 ^ 1056106770;
            continue;
          case 445:
            ((Settings) this).DGV1 = new DataGridView();
            num1 = (int) num2 * -1783183281 ^ 1951738840;
            continue;
          case 446:
            ((Settings) this).DGV8.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
            num1 = (int) num2 * 304636818 ^ 1685467763;
            continue;
          case 447:
            gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1919402908 ^ -1299580681;
            continue;
          case 448:
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -590465346 ^ -1580781514;
            continue;
          case 449:
            ((Settings) this).DefaultToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1246570635 ^ 349433928;
            continue;
          case 450:
            ((Settings) this).Label9.Location = new Point(0, 833);
            ((Settings) this).Label9.Name = EXGuarder.\u003155A3314;
            num1 = (int) num2 * 343264768 ^ -313272563;
            continue;
          case 451:
            ((Settings) this).DGV0.Location = new Point(0, 24);
            num1 = (int) num2 * 214008797 ^ -444125029;
            continue;
          case 452:
            ((Control) this).Controls.Add((Control) ((Settings) this).Panel1);
            ((Control) this).Controls.Add((Control) ((Settings) this).Panel2);
            ((Control) this).Name = EXGuarder.\u003104B0A5F;
            num1 = (int) num2 * -115922963 ^ 1181314628;
            continue;
          case 453:
            gridViewCellStyle5.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -405191889 ^ -1248177392;
            continue;
          case 454:
            ((Settings) this).Column3.Name = EXGuarder.\u00309286334;
            num1 = (int) num2 * 88592479 ^ -558966982;
            continue;
          case 455:
            ((Settings) this).Label6.TabIndex = 13;
            ((Settings) this).Label6.Text = EXGuarder.\u00372634172;
            num1 = (int) num2 * -363648098 ^ 1757081311;
            continue;
          case 456:
            ((Settings) this).Label5.BackColor = Color.FromArgb(35, 35, 35);
            num1 = (int) num2 * -612447595 ^ 124737262;
            continue;
          case 457:
            ((Settings) this).DGV2.AllowUserToResizeColumns = false;
            num1 = (int) num2 * -984484928 ^ 423799927;
            continue;
          case 458:
            ((Settings) this).Panel1.ResumeLayout(false);
            ((ISupportInitialize) ((Settings) this).DGV9).EndInit();
            num1 = (int) num2 * -861570203 ^ -1395205625;
            continue;
          case 459:
            ((Settings) this).DGV4.AllowUserToResizeRows = false;
            num1 = (int) num2 * 828901649 ^ -1104367972;
            continue;
          case 460:
            ((Settings) this).clr_1.Text = EXGuarder.\u0033C085927;
            num1 = (int) num2 * -1022086398 ^ -917943322;
            continue;
          case 461:
            ((Settings) this).DGV3.ScrollBars = ScrollBars.None;
            ((Settings) this).DGV3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((Settings) this).DGV3.Size = new Size(352, 75);
            num1 = (int) num2 * 136005278 ^ 1508199800;
            continue;
          case 462:
            ((Settings) this).Label3.TabIndex = 7;
            num1 = (int) num2 * 7207272 ^ -1318758729;
            continue;
          case 463:
            ((Settings) this).DataGridViewComboBoxColumn4.Name = EXGuarder.\u003480F3B1B;
            ((Settings) this).DataGridViewComboBoxColumn4.Resizable = DataGridViewTriState.False;
            num1 = (int) num2 * 1686890317 ^ -754968995;
            continue;
          case 464:
            ((Settings) this).DGV7.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 277005172 ^ -1674243014;
            continue;
          case 465:
            gridViewCellStyle18.Font = new Font(EXGuarder.\u00358055312, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle18.ForeColor = Color.FromArgb(190, 190, 190);
            gridViewCellStyle18.SelectionBackColor = Color.FromArgb(51, 153, (int) byte.MaxValue);
            num1 = (int) num2 * -398560103 ^ 453498871;
            continue;
          case 466:
            ((Settings) this).DGV4.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn4, (DataGridViewColumn) ((Settings) this).DataGridViewComboBoxColumn4);
            num1 = (int) num2 * 1459062680 ^ 1375590131;
            continue;
          case 467:
            ((Settings) this).DGV3.BackgroundColor = Color.Black;
            ((Settings) this).DGV3.BorderStyle = BorderStyle.None;
            ((Settings) this).DGV3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 1793081452 ^ 712683925;
            continue;
          case 468:
            ((Settings) this).Label4.Size = new Size(352, 24);
            ((Settings) this).Label4.TabIndex = 9;
            num1 = (int) num2 * -948446341 ^ 1237987452;
            continue;
          case 469:
            ((Settings) this).Label10.Padding = new Padding(0, 0, 0, 4);
            num1 = (int) num2 * 1052703631 ^ -439751304;
            continue;
          case 470:
            ((Settings) this).DGV5.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1540202805 ^ 2014060966;
            continue;
          case 471:
            ((Settings) this).DataGridViewComboBoxColumn5.FlatStyle = FlatStyle.System;
            num1 = (int) num2 * 1450364581 ^ 664447158;
            continue;
          case 472:
            ((Settings) this).DGV5.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * 965360669 ^ -1881280682;
            continue;
          case 473:
            ((Settings) this).Label1.Location = new Point(0, 0);
            num1 = (int) num2 * 981252166 ^ -749600141;
            continue;
          case 474:
            gridViewCellStyle3 = new DataGridViewCellStyle();
            gridViewCellStyle21 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1200721744 ^ -691322690;
            continue;
          case 475:
            gridViewCellStyle13.BackColor = Color.Black;
            num1 = (int) num2 * -60162486 ^ 1971236390;
            continue;
          case 476:
            ((Settings) this).DGV5.Columns.AddRange((DataGridViewColumn) ((Settings) this).DataGridViewTextBoxColumn5, (DataGridViewColumn) ((Settings) this).Column3);
            num1 = (int) num2 * 2018957881 ^ -492243833;
            continue;
          case 477:
            ((Settings) this).DGV2.EditMode = DataGridViewEditMode.EditOnEnter;
            ((Settings) this).DGV2.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -1274274606 ^ -471568211;
            continue;
          case 478:
            ((Settings) this).DGV4.DefaultCellStyle = gridViewCellStyle18;
            ((Settings) this).DGV4.Dock = DockStyle.Top;
            ((Settings) this).DGV4.EditMode = DataGridViewEditMode.EditOnEnter;
            ((Settings) this).DGV4.EnableHeadersVisualStyles = false;
            ((Settings) this).DGV4.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -188606498 ^ 1868276031;
            continue;
          case 479:
            ((Settings) this).DGV4.AllowUserToDeleteRows = false;
            num1 = (int) num2 * -2000541767 ^ 818578467;
            continue;
          case 480:
            ((Settings) this).Clr7ToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -1344078058 ^ 1430770715;
            continue;
          case 481:
            ((Settings) this).DataGridViewComboBoxColumn3.Name = EXGuarder.\u0032D6A2B2C;
            ((Settings) this).DataGridViewComboBoxColumn3.Resizable = DataGridViewTriState.False;
            num1 = (int) num2 * 484605758 ^ -722814584;
            continue;
          case 482:
            ((Settings) this).DataGridViewComboBoxColumn7 = new DataGridViewComboBoxColumn();
            ((Settings) this).Label9 = new Label();
            ((Settings) this).DGV7 = new DataGridView();
            ((Settings) this).DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -173498642 ^ -1491959139;
            continue;
          case 483:
            ((Settings) this).DGV1.Name = EXGuarder.\u003035E3463;
            ((Settings) this).DGV1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ((Settings) this).DGV1.RowHeadersVisible = false;
            num1 = (int) num2 * 265033385 ^ -1270673191;
            continue;
          case 484:
            ((Settings) this).DataGridViewComboBoxColumn7.Resizable = DataGridViewTriState.False;
            num1 = (int) num2 * -1467900468 ^ -1667760554;
            continue;
          case 485:
            ((Settings) this).Label8.Text = EXGuarder.\u003681E2B66;
            num1 = (int) num2 * -1212173710 ^ -1448622586;
            continue;
          default:
            goto label_487;
        }
      }
label_487:
      ((Control) this).ResumeLayout(false);
    }

    private struct SHFILEINFO
    {
      public DateTime start;
      public bool startTime;
      public static string FLAGS_PERFORMANCE;
      public static string LOCATION_NOTICETIGHT;
      public static string SOHW_ALERT;
    }

    public enum IconSize
    {
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFILEINFOW
    {
      public static string EFFECTS_CAM;
      public static string STYLE_MAPS;
      public static string SAVING_DATA;
      public static string CAM_Quality;
      public static Color DefaultColor_Foreground;
    }
  }
}
