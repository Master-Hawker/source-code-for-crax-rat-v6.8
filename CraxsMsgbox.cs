// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CraxsMsgbox
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class CraxsMsgbox : Form
  {
    public Client ClassClient;
    private IContainer components;

    [field: AccessedThroughProperty("Panel1")]
    internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon nobtn
    {
      get => this._nobtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon nobtn = this._nobtn;
label_1:
        int num1 = -1848713015;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 * -361938373 * -185452315) - ~(685981122 * 1064451449))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              nobtn.Click += eventHandler;
              num1 = (int) num2 * 469557572 ^ -734658848;
              continue;
            case 2:
              nobtn = this._nobtn;
              num1 = (int) num2 * -1486037791 ^ 4244200;
              continue;
            case 3:
              int num3 = nobtn == null ? -532260296 : (num3 = -1538928370);
              num1 = num3 ^ (int) num2 * -1642491751;
              continue;
            case 4:
              int num4 = nobtn == null ? 192590572 : (num4 = -831734881);
              num1 = num4 ^ (int) num2 * 770394430;
              continue;
            case 5:
              this._nobtn = value;
              num1 = 1097914816;
              continue;
            case 6:
              goto label_3;
            case 7:
              nobtn.Click -= eventHandler;
              num1 = (int) num2 * -1286039874 ^ -1689458239;
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

    internal virtual DrakeUIButtonIcon okbtn
    {
      get => this._okbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = 1382234192;
        DrakeUIButtonIcon okbtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 ^ --1058548166 - (957417837 + 1379214453 * 676473867) ^ ~((-2096155315 ^ 1908994842 ^ 1494832855) - 770670475 * ~-722228110)) - (-197437338 - 695605695 - ~-101927706) + 1115712153 * 1507243140)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              okbtn = this._okbtn;
              int num3 = okbtn == null ? 1382635048 : (num3 = -6559194);
              num1 = num3 ^ (int) num2 * -1819710965;
              continue;
            case 2:
              okbtn = this._okbtn;
              num1 = (int) num2 * 1299366314 ^ -1160504736;
              continue;
            case 3:
              goto label_3;
            case 4:
              okbtn.Click -= eventHandler;
              num1 = (int) num2 * -2071342695 ^ -1909213289;
              continue;
            case 5:
              int num4 = okbtn == null ? -1292335075 : (num4 = -1170410799);
              num1 = num4 ^ (int) num2 * -214131857;
              continue;
            case 6:
              this._okbtn = value;
              num1 = -72349329;
              continue;
            case 7:
              okbtn.Click += eventHandler;
              num1 = (int) num2 * -1691631632 ^ -1401017202;
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

    [field: AccessedThroughProperty("msgtext")]
    internal virtual Label msgtext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("titletext")]
    internal virtual DrakeUITitlePanel titletext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Panel Panel2
    {
      get => ((CraxsMsgbox.NativeStructs.MARGINS) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel2_Paint);
        Panel panel2 = ((CraxsMsgbox.NativeStructs.MARGINS) this)._Panel2;
        if (panel2 == null)
          goto label_6;
label_1:
        int num1 = -257710322;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~((num1 + (-(-1061421198 - -2021030307 * 499948983 - ~-219873589) - (726230945 ^ -(~-655975862 * 1821878761)))) * 239928001)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              panel2.Paint -= paintEventHandler;
              num1 = (int) num2 * -296363316 ^ -1129725052;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_1;
            case 4:
              panel2.Paint += paintEventHandler;
              num1 = (int) num2 * -1194982654 ^ 1143136206;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:
        return;
label_6:
        ((CraxsMsgbox.NativeStructs.MARGINS) this)._Panel2 = value;
        panel2 = ((CraxsMsgbox.NativeStructs.MARGINS) this)._Panel2;
        num1 = panel2 == null ? 635300924 : (num1 = 499096093);
        goto label_2;
      }
    }

    internal virtual Timer Timer1
    {
      get => ((CraxsMsgbox.NativeStructs.MARGINS) this)._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        Timer timer1 = ((CraxsMsgbox.NativeStructs.MARGINS) this)._Timer1;
label_1:
        int num1 = -290349326;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(~(-1091895973 - -1947334846 + (563439634 ^ 235799125)) - ~~num2)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              timer1.Tick += eventHandler;
              num1 = (int) num3 * 2138113716 ^ -1011991102;
              continue;
            case 2:
              int num4 = timer1 == null ? -1920837169 : (num4 = -326190446);
              num1 = num4 ^ (int) num3 * 1898467672;
              continue;
            case 3:
              goto label_1;
            case 4:
              timer1.Tick -= eventHandler;
              num1 = (int) num3 * 1927699567 ^ -1063054303;
              continue;
            case 5:
              ((CraxsMsgbox.NativeStructs.MARGINS) this)._Timer1 = value;
              timer1 = ((CraxsMsgbox.NativeStructs.MARGINS) this)._Timer1;
              int num5;
              num1 = num5 = timer1 == null ? -324014362 : (num5 = -36234579);
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

    internal virtual PictureBox picbox
    {
      get => ((CraxsMsgbox.NativeStructs.MARGINS) this)._picbox;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((CraxsMsgbox.NativeStructs.MARGINS) this)._picbox = value;
      }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        this.CheckAeroEnabled();
        CreateParams createParams1 = base.CreateParams;
label_1:
        int num1 = -1759677420;
        CreateParams createParams2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~~(~(num1 ^ -((-1438821481 ^ -882935551) + (2036674381 - -1814108731) - ~-984368102) + 1922547179 * ((1075643731 ^ -2084695136) * 1330283433 ^ ~-2087811064)) * 1520047721)) % 7U)
          {
            case 0:
              goto label_1;
            case 2:
              createParams2 = createParams1;
              num1 = (int) num2 * 749411508 ^ -1992694824;
              continue;
            case 3:
              num1 = (int) num2 * -235584899 ^ 2120416573;
              continue;
            case 4:
              int num3 = ((CraxsMsgbox.NativeStructs.MARGINS) this).aeroEnabled ? -511904826 : (num3 = -201356744);
              num1 = num3 ^ (int) num2 * 483621500;
              continue;
            case 5:
              createParams2 = createParams1;
              num1 = -823382694;
              continue;
            case 6:
              createParams1.ClassStyle |= 131072;
              num1 = (int) num2 * 394322594 ^ -1333865919;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        return createParams2;
      }
    }

    protected override void WndProc(ref Message m)
    {
      int msg = m.Msg;
label_1:
      int num1 = -1659942403;
      CraxsMsgbox.NativeStructs.MARGINS pMarInset;
      int attrValue;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 * 1467451939 * -307020135 * 1701020823 + (1005207460 - 36243059)) * -63115215)) % 11U)
        {
          case 0:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(CraxsMsgbox.FormBoundsColors&) ref pMarInset).rightWidth = 1;
            num1 = (int) num2 * 688993839 ^ -351625367;
            continue;
          case 1:
            int num3 = msg == 133 ? 132268120 : (num3 = -1612271342);
            num1 = num3 ^ (int) num2 * 1238674207;
            continue;
          case 2:
            CraxsMsgbox.NativeStructs.DwmExtendFrameIntoClientArea(this.Handle, ref pMarInset);
            num1 = (int) num2 * -1128272792 ^ 305588204;
            continue;
          case 3:
            CraxsMsgbox.NativeMethods.DwmSetWindowAttribute(this.Handle, 2, ref attrValue, 4);
            pMarInset = new CraxsMsgbox.NativeStructs.MARGINS();
            num1 = (int) num2 * 824915969 ^ 1041977666;
            continue;
          case 4:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(Craxspopup&) ref pMarInset).bottomHeight = 1;
            num1 = (int) num2 * 1921305452 ^ -1170675349;
            continue;
          case 5:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(CraxsMsgbox.FormBoundsColors&) ref pMarInset).topHeight = 1;
            num1 = (int) num2 * -1871138339 ^ -142332770;
            continue;
          case 6:
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            (^(CraxsMsgbox.FormBoundsColors&) ref pMarInset).leftWidth = 1;
            num1 = (int) num2 * 998973235 ^ -1245746213;
            continue;
          case 7:
            attrValue = 2;
            int num4;
            num1 = num4 = !((CraxsMsgbox.NativeStructs.MARGINS) this).aeroEnabled ? -615882636 : (num4 = -1094642401);
            continue;
          case 8:
            goto label_1;
          case 9:
            num1 = (int) num2 * 1789422562 ^ 1618113030;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      base.WndProc(ref m);
    }

    private void CheckAeroEnabled()
    {
      if (Environment.OSVersion.Version.Major < 6)
        goto label_7;
label_1:
      int num1 = -697821785;
label_2:
      int pfEnabled;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 * 837845083 * 804553393) - -~823840760 - (1027050912 ^ -277496710) - 74357147)) % 6U)
        {
          case 0:
            CraxsMsgbox.NativeMethods.DwmIsCompositionEnabled(ref pfEnabled);
            ((CraxsMsgbox.NativeStructs.MARGINS) this).aeroEnabled = pfEnabled == 1;
            num1 = (int) num2 * 1425920183 ^ 141495536;
            continue;
          case 1:
            goto label_7;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            pfEnabled = 0;
            num1 = (int) num2 * 47635090 ^ 697187211;
            continue;
          case 5:
            num1 = (int) num2 * 618402516 ^ 1987735178;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_7:
      ((CraxsMsgbox.NativeStructs.MARGINS) this).aeroEnabled = false;
      num1 = 349001374;
      goto label_2;
    }

    public CraxsMsgbox(string t, string m, bool no, Bitmap ico)
    {
label_1:
      int num1 = 71629473;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~--((num1 - (1535703768 * 2012776681 ^ -(-(1307738219 * -2115792924) + ((1542264375 ^ 722486057) + --1457561204)))) * 504548673 + (2139108394 * 302297855 ^ (-1588392077 ^ -1207177915) + ~-441625951))) % 8U)
        {
          case 0:
            ((craxscallslog) this).InitializeComponent();
            num1 = (int) num2 * -1045777752 ^ -2067202067;
            continue;
          case 1:
            ((CraxsMsgbox.NativeConstants) this).borderRadius = 30;
            ((CraxsMsgbox.NativeConstants) this).borderSize = 3;
            ((CraxsMsgbox.FormBoundsColors) this).borderColor = Color.Transparent;
            num1 = (int) num2 * -1020291562 ^ -1788530055;
            continue;
          case 2:
            this.titletext.Text = t;
            this.msgtext.Text = m;
            int num3 = no ? -360477609 : (num3 = 1088185048);
            num1 = num3 ^ (int) num2 * -1366735450;
            continue;
          case 3:
            this.nobtn.Visible = false;
            num1 = (int) num2 * -652218455 ^ 141073368;
            continue;
          case 5:
            this.Paint += new PaintEventHandler(this.CraxsMsgbox_Paint);
            ((CraxsMsgbox.NativeStructs.MARGINS) this).aeroEnabled = true;
            num1 = (int) num2 * 1680326958 ^ 1451769272;
            continue;
          case 6:
            this.Load += new EventHandler(this.CraxsMsgbox_Load);
            num1 = (int) num2 * 881694667 ^ -1205617968;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_9:
      this.picbox.Image = (Image) ico;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Yes;
label_1:
      int num1 = -1274079958;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(~num1 - -((-208547327 - 624807899) * -293188569 ^ -349018113 * -344987578 ^ ~650866868)) ^ 226976725) * -2043765013)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.Close();
            num1 = (int) num2 * -73940632 ^ 847894400;
            continue;
          case 2:
            this.Timer1.Stop();
            num1 = (int) num2 * 1975097957 ^ -1104259849;
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

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Timer1.Stop();
label_1:
      int num1 = 1736892590;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((~(~num1 * -854343589) - (-108990915 + (1907971554 + 1892388357))) * -980266717)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Close();
            num1 = (int) num2 * 1140018213 ^ 1483082231;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void CraxsMsgbox_Load(object sender, EventArgs e)
    {
      this.CenterToScreen();
      this.Timer1.Start();
    }

    private void FormRegionAndBorder(
      Form form,
      float radius,
      Graphics graph,
      Color borderColor,
      float borderSize)
    {
      if (this.WindowState == FormWindowState.Minimized)
        return;
      GraphicsPath roundedPath = this.GetRoundedPath(form.ClientRectangle, radius);
      try
      {
        Pen pen = new Pen(borderColor, borderSize);
        try
        {
          Matrix matrix = new Matrix();
          try
          {
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            form.Region = new System.Drawing.Region(roundedPath);
label_5:
            int num1 = -505433014;
            Rectangle clientRectangle;
            float scaleX;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ~(-(-num1 * 61449581 ^ -132569521 * -~-292356802) * -766988403)) % 8U)
              {
                case 0:
                  scaleX = (float) (1.0 - ((double) borderSize + 1.0) / (double) clientRectangle.Width);
                  num1 = (int) num2 * -499916828 ^ 1023585592;
                  continue;
                case 1:
                  graph.Transform = matrix;
                  graph.DrawPath(pen, roundedPath);
                  num1 = (int) num2 * 1448635433 ^ 1643397604;
                  continue;
                case 2:
                  int num3 = (double) borderSize < 1.0 ? -1933689047 : (num3 = 1965250263);
                  num1 = num3 ^ (int) num2 * 91690086;
                  continue;
                case 3:
                  goto label_5;
                case 4:
                  float scaleY = (float) (1.0 - ((double) borderSize + 1.0) / (double) clientRectangle.Height);
                  matrix.Scale(scaleX, scaleY);
                  num1 = (int) num2 * 4268069 ^ 912831186;
                  continue;
                case 5:
                  goto label_24;
                case 6:
                  matrix.Translate(borderSize / 1.6f, borderSize / 1.6f);
                  num1 = (int) num2 * 1305039877 ^ -1233216417;
                  continue;
                case 7:
                  clientRectangle = form.ClientRectangle;
                  num1 = (int) num2 * 1213087629 ^ 850728671;
                  continue;
                default:
                  goto label_21;
              }
            }
label_24:
            return;
label_21:;
          }
          finally
          {
            if (matrix != null)
            {
label_14:
              int num4 = 497848193;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) ~(-(-num4 * 61449581 ^ -132569521 * -~-292356802) * -766988403)) % 3U)
                {
                  case 1:
                    matrix.Dispose();
                    num4 = (int) num5 * 1844170477 ^ 1096123487;
                    continue;
                  case 2:
                    goto label_14;
                  default:
                    goto label_17;
                }
              }
            }
label_17:;
          }
        }
        finally
        {
          if (pen != null)
          {
label_19:
            int num6 = -457834586;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) ~(-(-num6 * 61449581 ^ -132569521 * -~-292356802) * -766988403)) % 3U)
              {
                case 0:
                  goto label_19;
                case 1:
                  pen.Dispose();
                  num6 = (int) num7 * 1485659489 ^ 1151530597;
                  continue;
                default:
                  goto label_23;
              }
            }
          }
label_23:;
        }
      }
      finally
      {
        if (roundedPath != null)
        {
label_26:
          int num8 = -427489648;
          while (true)
          {
            uint num9;
            switch ((num9 = (uint) ~(-(-num8 * 61449581 ^ -132569521 * -~-292356802) * -766988403)) % 3U)
            {
              case 1:
                roundedPath.Dispose();
                num8 = (int) num9 * -433322990 ^ -94609058;
                continue;
              case 2:
                goto label_26;
              default:
                goto label_30;
            }
          }
        }
label_30:;
      }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
    {
      GraphicsPath graphicsPath = new GraphicsPath();
      float num1 = radius * 2f;
label_1:
      int num2 = -2038227792;
      GraphicsPath roundedPath;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~(~(num2 * 745870285) - (-1301859543 ^ 877468929 - 2145910189 - (49923126 ^ -1300162879)) - 69199551 + (820776526 ^ 275356187))) % 8U)
        {
          case 1:
            roundedPath = graphicsPath;
            num2 = (int) num3 * 10922269 ^ 1415612831;
            continue;
          case 2:
            goto label_1;
          case 3:
            graphicsPath.AddArc((float) rect.Right - num1, (float) rect.Y, num1, num1, 270f, 90f);
            num2 = (int) num3 * -73359904 ^ 1797579830;
            continue;
          case 4:
            graphicsPath.AddArc((float) rect.Right - num1, (float) rect.Bottom - num1, num1, num1, 0.0f, 90f);
            num2 = (int) num3 * 596135179 ^ 476973543;
            continue;
          case 5:
            graphicsPath.AddArc((float) rect.X, (float) rect.Bottom - num1, num1, num1, 90f, 90f);
            graphicsPath.CloseFigure();
            num2 = (int) num3 * -165602255 ^ -419460198;
            continue;
          case 6:
            graphicsPath.StartFigure();
            num2 = (int) num3 * -966490137 ^ 1598895895;
            continue;
          case 7:
            graphicsPath.AddArc((float) rect.X, (float) rect.Y, num1, num1, 180f, 90f);
            num2 = (int) num3 * 1456094780 ^ 1634312045;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return roundedPath;
    }

    private void ControlRegionAndBorder(
      Control control,
      float radius,
      Graphics graph,
      Color borderColor)
    {
      GraphicsPath roundedPath = this.GetRoundedPath(control.ClientRectangle, radius);
      try
      {
        Pen pen = new Pen(borderColor, 1f);
        try
        {
          graph.SmoothingMode = SmoothingMode.AntiAlias;
label_3:
          int num1 = -1357440301;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (~-((num1 + (~(-1229922187 ^ -175485424 ^ -1317319724 ^ 679697648 ^ -348802866 * -643498121) ^ --1003861965 + 1838006421)) * 1625580695) - 1514785119 * -104988203 - 228974044)) % 3U)
            {
              case 0:
                goto label_3;
              case 1:
                control.Region = new System.Drawing.Region(roundedPath);
                graph.DrawPath(pen, roundedPath);
                num1 = (int) num2 * -511086861 ^ 1501127344;
                continue;
              case 2:
                goto label_15;
              default:
                goto label_11;
            }
          }
label_15:
          return;
label_11:;
        }
        finally
        {
          if (pen != null)
          {
label_7:
            int num3 = -167493409;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) (~-((num3 + (~(-1229922187 ^ -175485424 ^ -1317319724 ^ 679697648 ^ -348802866 * -643498121) ^ --1003861965 + 1838006421)) * 1625580695) - 1514785119 * -104988203 - 228974044)) % 3U)
              {
                case 0:
                  goto label_7;
                case 1:
                  pen.Dispose();
                  num3 = (int) num4 * -1045023180 ^ -346791491;
                  continue;
                default:
                  goto label_10;
              }
            }
          }
label_10:;
        }
      }
      finally
      {
        if (roundedPath != null)
        {
label_13:
          int num5 = 770093398;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) (~-((num5 + (~(-1229922187 ^ -175485424 ^ -1317319724 ^ 679697648 ^ -348802866 * -643498121) ^ --1003861965 + 1838006421)) * 1625580695) - 1514785119 * -104988203 - 228974044)) % 3U)
            {
              case 0:
                goto label_13;
              case 2:
                roundedPath.Dispose();
                num5 = (int) num6 * -1971898458 ^ -1294287724;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    private void DrawPath(Rectangle rectForm, Graphics graphics, Color color)
    {
      GraphicsPath roundedPath = this.GetRoundedPath(rectForm, (float) ((CraxsMsgbox.NativeConstants) this).borderRadius);
      try
      {
        Pen pen = new Pen(color, 3f);
        try
        {
          graphics.DrawPath(pen, roundedPath);
        }
        finally
        {
          if (pen != null)
          {
label_4:
            int num1 = -985107339;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ~(~-(num1 * -380708925 * 1423803481) * -1092444463)) % 3U)
              {
                case 1:
                  pen.Dispose();
                  num1 = (int) num2 * -1649121108 ^ 1302128205;
                  continue;
                case 2:
                  goto label_4;
                default:
                  goto label_7;
              }
            }
          }
label_7:;
        }
      }
      finally
      {
        if (roundedPath != null)
        {
label_9:
          int num3 = -1418091063;
          while (true)
          {
            uint num4;
            switch ((num4 = (uint) ~(~-(num3 * -380708925 * 1423803481) * -1092444463)) % 3U)
            {
              case 0:
                goto label_9;
              case 2:
                roundedPath.Dispose();
                num3 = (int) num4 * 512731317 ^ 1852507712;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
    }

    private CraxsMsgbox.FormBoundsColors GetFormBoundsColors()
    {
      CraxsMsgbox.FormBoundsColors formBoundsColors = new CraxsMsgbox.FormBoundsColors();
      Bitmap bitmap = new Bitmap(1, 1);
      try
      {
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        try
        {
          Rectangle rectangle = new Rectangle(0, 0, 1, 1);
label_3:
          int num1 = -767815620;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ((num1 - -1855366909 * ~(-860246119 * (2016509991 - 1354950526) - ((1597422080 ^ 66290076) + (584039717 - 681046346))) ^ ~-1828107085) + ~(-1688602912 - 521485945) * -696114249)) % 13U)
            {
              case 0:
                graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
                num1 = (int) num2 * 1163640762 ^ -1025060257;
                continue;
              case 1:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                (^(Craxspopup&) ref formBoundsColors).BottomRightColor = bitmap.GetPixel(0, 0);
                num1 = (int) num2 * -1499319132 ^ 882280851;
                continue;
              case 2:
                rectangle.X = this.Bounds.Right;
                rectangle.Y = this.Bounds.Y;
                num1 = (int) num2 * 707605808 ^ -1558505417;
                continue;
              case 3:
                rectangle.X = this.Bounds.X;
                rectangle.Y = this.Bounds.Bottom;
                num1 = (int) num2 * 1800391981 ^ 812148478;
                continue;
              case 4:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                (^(Craxspopup&) ref formBoundsColors).TopRightColor = bitmap.GetPixel(0, 0);
                num1 = (int) num2 * -1459783039 ^ 1402331537;
                continue;
              case 5:
                graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                (^(Craxspopup&) ref formBoundsColors).BottomLeftColor = bitmap.GetPixel(0, 0);
                num1 = (int) num2 * -63772836 ^ 1869398694;
                continue;
              case 6:
                rectangle.X = checked (this.Bounds.X - 1);
                num1 = (int) num2 * 731855312 ^ -600716046;
                continue;
              case 7:
                goto label_3;
              case 8:
                rectangle.Y = this.Bounds.Bottom;
                num1 = (int) num2 * -1062067171 ^ -1557709952;
                continue;
              case 10:
                graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
                num1 = (int) num2 * 645051082 ^ 2033079875;
                continue;
              case 11:
                rectangle.X = this.Bounds.Right;
                num1 = (int) num2 * 249620521 ^ -1767269525;
                continue;
              case 12:
                rectangle.Y = this.Bounds.Y;
                graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                (^(Craxspopup&) ref formBoundsColors).TopLeftColor = bitmap.GetPixel(0, 0);
                num1 = (int) num2 * -1928661077 ^ 1513222522;
                continue;
              default:
                goto label_26;
            }
          }
        }
        finally
        {
          if (graphics != null)
          {
label_17:
            int num3 = -2057073617;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) ((num3 - -1855366909 * ~(-860246119 * (2016509991 - 1354950526) - ((1597422080 ^ 66290076) + (584039717 - 681046346))) ^ ~-1828107085) + ~(-1688602912 - 521485945) * -696114249)) % 3U)
              {
                case 1:
                  graphics.Dispose();
                  num3 = (int) num4 * 1702333453 ^ -702347324;
                  continue;
                case 2:
                  goto label_17;
                default:
                  goto label_20;
              }
            }
          }
label_20:;
        }
      }
      finally
      {
        if (bitmap != null)
        {
label_22:
          int num5 = 2134954763;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) ((num5 - -1855366909 * ~(-860246119 * (2016509991 - 1354950526) - ((1597422080 ^ 66290076) + (584039717 - 681046346))) ^ ~-1828107085) + ~(-1688602912 - 521485945) * -696114249)) % 3U)
            {
              case 1:
                bitmap.Dispose();
                num5 = (int) num6 * 1970120548 ^ -1058399121;
                continue;
              case 2:
                goto label_22;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      return formBoundsColors;
    }

    private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
label_1:
      int num1 = -1332406238;
      CraxsMsgbox.FormBoundsColors formBoundsColors;
      Rectangle rectForm1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        Rectangle rectForm2;
        Rectangle clientRectangle;
        int height;
        int width;
        Rectangle rectForm3;
        switch ((num3 = (uint) (-825674359 - ~(-num2 * -949038963 - (--1268937740 - -1709174380 * 1436763629 + (-43328026 * -498548389 ^ 580714849 * 1013004355))))) % 10U)
        {
          case 0:
            this.DrawPath(clientRectangle, e.Graphics, formBoundsColors.TopLeftColor);
            num1 = (int) num3 * 2051982085 ^ 1909093386;
            continue;
          case 1:
            rectForm2 = new Rectangle(clientRectangle.X, checked (clientRectangle.Bottom - height), width, height);
            num1 = (int) num3 * 1978741777 ^ -1857082570;
            continue;
          case 2:
            this.DrawPath(rectForm2, e.Graphics, formBoundsColors.BottomLeftColor);
            num1 = (int) num3 * 1754658868 ^ -688028380;
            continue;
          case 3:
            goto label_1;
          case 5:
            rectForm1 = new Rectangle(checked (clientRectangle.Right - width), checked (clientRectangle.Bottom - height), width, height);
            num1 = (int) num3 * -1572925189 ^ 1504797470;
            continue;
          case 6:
            width = checked ((int) Math.Round(unchecked ((double) clientRectangle.Width / 2.0)));
            height = checked ((int) Math.Round(unchecked ((double) clientRectangle.Height / 2.0)));
            formBoundsColors = this.GetFormBoundsColors();
            num1 = (int) num3 * -1506758500 ^ -490032603;
            continue;
          case 7:
            clientRectangle = this.ClientRectangle;
            num1 = (int) num3 * 850702042 ^ 1949982965;
            continue;
          case 8:
            this.DrawPath(rectForm3, e.Graphics, formBoundsColors.TopRightColor);
            num1 = (int) num3 * 178476209 ^ -584268458;
            continue;
          case 9:
            rectForm3 = new Rectangle(checked (clientRectangle.Right - width), clientRectangle.Y, width, height);
            num1 = (int) num3 * 875640706 ^ 316704609;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      this.DrawPath(rectForm1, e.Graphics, formBoundsColors.BottomRightColor);
      this.FormRegionAndBorder((Form) this, (float) ((CraxsMsgbox.NativeConstants) this).borderRadius, e.Graphics, ((CraxsMsgbox.FormBoundsColors) this).borderColor, (float) ((CraxsMsgbox.NativeConstants) this).borderSize);
    }

    private void Panel2_Paint(object sender, PaintEventArgs e)
    {
      this.ControlRegionAndBorder((Control) this.Panel2, (float) ((CraxsMsgbox.NativeConstants) this).borderRadius - (float) ((CraxsMsgbox.NativeConstants) this).borderSize / 2f, e.Graphics, ((CraxsMsgbox.FormBoundsColors) this).borderColor);
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      this.TopMost = true;
      this.BringToFront();
    }

    public CraxsMsgbox()
    {
    }

    public CraxsMsgbox()
    {
    }

    public class NativeStructs
    {
      [DllImport("dwmapi")]
      public static extern int DwmExtendFrameIntoClientArea(
        IntPtr hWnd,
        ref CraxsMsgbox.NativeStructs.MARGINS pMarInset);

      public struct MARGINS
      {
        private bool aeroEnabled;
      }
    }

    public class NativeMethods
    {
      [DllImport("dwmapi")]
      internal static extern int DwmSetWindowAttribute(
        IntPtr hwnd,
        int attr,
        ref int attrValue,
        int attrSize);

      [DllImport("dwmapi.dll")]
      public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

      [DebuggerNonUserCode]
      protected virtual void Dispose(bool disposing)
      {
        try
        {
          if (!disposing)
            return;
label_1:
          int num1 = 430448981;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (-(-~(num1 ^ (~(1629809041 - 1476810850) ^ -168215991) + -(865363997 - 2009303742) ^ (433796331 - 1887896025 ^ 935467599 ^ -768354695) - 287173190 + (-(-1865583933 * 675127937) - ~--1969195864)) * -1495526285) - 1060956067)) % 4U)
            {
              case 0:
                goto label_3;
              case 1:
                int num3 = ((Craxspopup) this).components == null ? 463726874 : (num3 = 165770192);
                num1 = num3 ^ (int) num2 * 1965569994;
                continue;
              case 2:
                ((Craxspopup) this).components.Dispose();
                num1 = (int) num2 * 451295606 ^ 2043595604;
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
          // ISSUE: explicit non-virtual call
          __nonvirtual (((Form) this).Dispose(disposing));
        }
      }
    }

    public class NativeConstants
    {
      private int borderRadius;
      private int borderSize;

      [DebuggerStepThrough]
      private void InitializeComponent()
      {
        ((Craxspopup) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
        int num1 = 1773573667;
        ComponentResourceManager componentResourceManager;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-(num1 * 1656881601 ^ 299861135 * (-1519747023 * ~-1002444783 - -216865175))) % 79U)
          {
            case 0:
              ((Craxspopup) this).Panel5.TabIndex = 4;
              num1 = (int) num2 * -677326448 ^ 1377963325;
              continue;
            case 1:
              ((Craxspopup) this).DrakeUIButtonIcon2.Cursor = Cursors.Hand;
              num1 = (int) num2 * -246446827 ^ -2094769254;
              continue;
            case 2:
              ((Craxspopup) this).notifitext.TextAlign = HorizontalAlignment.Center;
              ((Craxspopup) this).ToolTips.BackColor = Color.Black;
              num1 = (int) num2 * -1619924218 ^ 1017528924;
              continue;
            case 3:
              ((Craxspopup) this).checkbutton.RectDisableColor = Color.FromArgb(227, 242, 253);
              num1 = (int) num2 * 262733902 ^ -192742275;
              continue;
            case 4:
              ((Craxspopup) this).DrakeUIButtonIcon2.Radius = 15;
              num1 = (int) num2 * -210456703 ^ 93017594;
              continue;
            case 5:
              ((Craxspopup) this).checkbutton.Size = new Size(72, 30);
              num1 = (int) num2 * -238583269 ^ -182269218;
              continue;
            case 6:
              ((Control) this).BackgroundImage = (Image) componentResourceManager.GetObject(EXGuarder.\u00330733437);
              num1 = (int) num2 * -1918763529 ^ 530551669;
              continue;
            case 7:
              ((Craxspopup) this).Panel1 = new Panel();
              num1 = (int) num2 * 2097773818 ^ 1756625520;
              continue;
            case 8:
              ((Craxspopup) this).checkbutton.Font = new Font(EXGuarder.\u00340744578, 12f);
              ((Craxspopup) this).checkbutton.Location = new Point(398, 96);
              num1 = (int) num2 * -1182772437 ^ -18671971;
              continue;
            case 9:
              ((Control) this).SuspendLayout();
              num1 = (int) num2 * -1496855921 ^ 28557174;
              continue;
            case 10:
              ((Craxspopup) this).Panel5.Controls.Add((Control) ((Craxspopup) this).notifitext);
              ((Craxspopup) this).Panel5.Dock = DockStyle.Fill;
              ((Craxspopup) this).Panel5.Location = new Point(17, 133);
              ((Craxspopup) this).Panel5.Name = EXGuarder.\u0032C66240B;
              num1 = (int) num2 * -1215708521 ^ 1324425186;
              continue;
            case 11:
              ((Craxspopup) this).Panel4.Size = new Size(453, 21);
              num1 = (int) num2 * 518573997 ^ -34464635;
              continue;
            case 12:
              ((Craxspopup) this).ToolTips.SetToolTip((Control) ((Craxspopup) this).DrakeUIButtonIcon1, EXGuarder.\u003115B4F55);
              ((Craxspopup) this).checkbutton.Cursor = Cursors.Hand;
              num1 = (int) num2 * 1729553871 ^ 655728355;
              continue;
            case 13:
              ((Craxspopup) this).Panel3.Dock = DockStyle.Right;
              num1 = (int) num2 * 635382714 ^ -1381580688;
              continue;
            case 14:
              ((Craxspopup) this).DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
              num1 = (int) num2 * 1704645204 ^ 114696126;
              continue;
            case 15:
              ((Craxspopup) this).DrakeUIButtonIcon1.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
              num1 = (int) num2 * -255446119 ^ -1019479152;
              continue;
            case 16:
              ((Craxspopup) this).Panel4.Dock = DockStyle.Bottom;
              num1 = (int) num2 * -1260205034 ^ 1078223426;
              continue;
            case 17:
              ((Craxspopup) this).notifitext.ForeColor = Color.White;
              num1 = (int) num2 * 640615940 ^ -2002906479;
              continue;
            case 18:
              ((Craxspopup) this).Panel5.BackColor = Color.Black;
              num1 = (int) num2 * -1447722420 ^ -1508244928;
              continue;
            case 19:
              goto label_3;
            case 20:
              ((Craxspopup) this).notifitext = new TextBox();
              ((Craxspopup) this).ToolTips = new DrakeUIToolTip(((Craxspopup) this).components);
              num1 = (int) num2 * 1119420626 ^ -1249726973;
              continue;
            case 21:
              ((Craxspopup) this).Panel4.Location = new Point(17, 399);
              num1 = (int) num2 * 92349708 ^ -925418657;
              continue;
            case 22:
              ((Craxspopup) this).notifitext.Margin = new Padding(4);
              ((Craxspopup) this).notifitext.Multiline = true;
              ((Craxspopup) this).notifitext.Name = EXGuarder.\u0034A67331D;
              ((Craxspopup) this).notifitext.ScrollBars = ScrollBars.Vertical;
              ((Craxspopup) this).notifitext.Size = new Size(453, 266);
              ((Craxspopup) this).notifitext.TabIndex = 2;
              num1 = (int) num2 * 1847091769 ^ -1307225007;
              continue;
            case 23:
              ((Control) this).ResumeLayout(false);
              num1 = (int) num2 * 1914775888 ^ -1195250660;
              continue;
            case 24:
              ((Craxspopup) this).DrakeUIButtonIcon2.Name = EXGuarder.\u00360266D63;
              num1 = (int) num2 * 1525058225 ^ -1861534100;
              continue;
            case 25:
              ((Craxspopup) this).DrakeUIButtonIcon1.Location = new Point(242, 96);
              ((Craxspopup) this).DrakeUIButtonIcon1.Name = EXGuarder.\u003240F065A;
              num1 = (int) num2 * -263981979 ^ 43665632;
              continue;
            case 26:
              ((Craxspopup) this).Panel4.Name = EXGuarder.\u0036B0E6928;
              num1 = (int) num2 * -785302219 ^ -1523734936;
              continue;
            case 27:
              ((Control) this).Controls.Add((Control) ((Craxspopup) this).Panel2);
              ((Control) this).Controls.Add((Control) ((Craxspopup) this).Panel1);
              num1 = (int) num2 * 910655311 ^ 261662331;
              continue;
            case 28:
              ((Craxspopup) this).ToolTips.ForeColor = Color.White;
              num1 = (int) num2 * 1340082570 ^ 573877896;
              continue;
            case 29:
              ((Craxspopup) this).notifitext.BackColor = Color.Black;
              ((Craxspopup) this).notifitext.BorderStyle = BorderStyle.None;
              num1 = (int) num2 * 1013216648 ^ -1902227058;
              continue;
            case 30:
              ((Craxspopup) this).DrakeUIButtonIcon1.Cursor = Cursors.Hand;
              num1 = (int) num2 * 1881871166 ^ 680262009;
              continue;
            case 31:
              ((Craxspopup) this).Panel2.Location = new Point(0, 133);
              num1 = (int) num2 * -314350786 ^ -1698281343;
              continue;
            case 32:
              ((Craxspopup) this).Panel1.SuspendLayout();
              num1 = (int) num2 * -299474935 ^ -480853813;
              continue;
            case 33:
              ((Craxspopup) this).checkbutton.Style = UIStyle.Custom;
              num1 = (int) num2 * 43114542 ^ -860286415;
              continue;
            case 34:
              ((Craxspopup) this).DrakeUIButtonIcon2.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
              ((Craxspopup) this).DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
              num1 = (int) num2 * 192368538 ^ -1171558351;
              continue;
            case 35:
              ((Form) this).FormBorderStyle = FormBorderStyle.None;
              ((Control) this).Name = EXGuarder.\u003793B4D0A;
              num1 = (int) num2 * 364716933 ^ -862073453;
              continue;
            case 36:
              ((Craxspopup) this).notifitext.Dock = DockStyle.Fill;
              ((Craxspopup) this).notifitext.Font = new Font(EXGuarder.\u00340744578, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
              num1 = (int) num2 * 321398704 ^ 818001656;
              continue;
            case 37:
              ((Craxspopup) this).Panel5.PerformLayout();
              num1 = (int) num2 * -759846023 ^ 106571419;
              continue;
            case 38:
              ((Craxspopup) this).Panel3.Location = new Point(470, 133);
              ((Craxspopup) this).Panel3.Name = EXGuarder.\u00349357200;
              ((Craxspopup) this).Panel3.Size = new Size(17, 287);
              num1 = (int) num2 * -651756400 ^ 937432321;
              continue;
            case 39:
              ((Craxspopup) this).DrakeUIButtonIcon1.Radius = 15;
              num1 = (int) num2 * 871041676 ^ 2045190927;
              continue;
            case 40:
              ((Craxspopup) this).checkbutton.FillColor = Color.Black;
              num1 = (int) num2 * -651797260 ^ -1332370389;
              continue;
            case 41:
              ((Craxspopup) this).Panel2 = new Panel();
              ((Craxspopup) this).Panel3 = new Panel();
              num1 = (int) num2 * -89818154 ^ 460258268;
              continue;
            case 42:
              ((Craxspopup) this).ToolTips.OwnerDraw = true;
              num1 = (int) num2 * 1228157344 ^ -1317898591;
              continue;
            case 43:
              ((Craxspopup) this).DrakeUIButtonIcon2.Size = new Size(72, 30);
              ((Craxspopup) this).DrakeUIButtonIcon2.Style = UIStyle.Custom;
              ((Craxspopup) this).DrakeUIButtonIcon2.Symbol = 61544;
              num1 = (int) num2 * -2110223116 ^ 1780882306;
              continue;
            case 44:
              ((Craxspopup) this).notifitext.Location = new Point(0, 0);
              num1 = (int) num2 * -1266240042 ^ 162498200;
              continue;
            case 45:
              ((Control) this).DoubleBuffered = true;
              num1 = (int) num2 * 1571393655 ^ -446682150;
              continue;
            case 46:
              ((Craxspopup) this).Panel2.Name = EXGuarder.\u003394A5F45;
              ((Craxspopup) this).Panel2.Size = new Size(17, 287);
              ((Craxspopup) this).Panel2.TabIndex = 1;
              ((Craxspopup) this).Panel3.BackColor = Color.Transparent;
              num1 = (int) num2 * 860417333 ^ -344678130;
              continue;
            case 47:
              ((Craxspopup) this).DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
              num1 = (int) num2 * -2068759480 ^ 278716202;
              continue;
            case 48:
              ((Control) this).Controls.Add((Control) ((Craxspopup) this).Panel5);
              ((Control) this).Controls.Add((Control) ((Craxspopup) this).Panel4);
              ((Control) this).Controls.Add((Control) ((Craxspopup) this).Panel3);
              num1 = (int) num2 * -523829270 ^ -203156671;
              continue;
            case 49:
              ((Craxspopup) this).Panel3.TabIndex = 2;
              num1 = (int) num2 * -209405700 ^ 1740329918;
              continue;
            case 50:
              ((Craxspopup) this).DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
              ((Craxspopup) this).DrakeUIButtonIcon1.Size = new Size(72, 30);
              ((Craxspopup) this).DrakeUIButtonIcon1.Style = UIStyle.Custom;
              ((Craxspopup) this).DrakeUIButtonIcon1.StyleCustomMode = true;
              num1 = (int) num2 * 1484604719 ^ -86681543;
              continue;
            case 51:
              ((Craxspopup) this).Panel4.TabIndex = 3;
              num1 = (int) num2 * -408153975 ^ 1838168016;
              continue;
            case 52:
              ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
              ((Form) this).BackColor = Color.DarkRed;
              num1 = (int) num2 * -540514585 ^ -122012516;
              continue;
            case 53:
              ((Craxspopup) this).ToolTips.SetToolTip((Control) ((Craxspopup) this).DrakeUIButtonIcon2, EXGuarder.\u0035A692013);
              num1 = (int) num2 * 1402328286 ^ -1022558099;
              continue;
            case 54:
              ((Craxspopup) this).DrakeUIButtonIcon1.Symbol = 61639;
              num1 = (int) num2 * -1339452759 ^ -1317033585;
              continue;
            case 55:
              ((Craxspopup) this).Panel4 = new Panel();
              ((Craxspopup) this).Panel5 = new Panel();
              num1 = (int) num2 * -59608470 ^ -1507362296;
              continue;
            case 56:
              ((Craxspopup) this).Panel5.Size = new Size(453, 266);
              num1 = (int) num2 * -965798111 ^ -1223083842;
              continue;
            case 57:
              ((Craxspopup) this).Panel1.TabIndex = 0;
              num1 = (int) num2 * 609443342 ^ 1688836796;
              continue;
            case 58:
              ((Control) this).BackgroundImageLayout = ImageLayout.Zoom;
              ((Form) this).ClientSize = new Size(487, 420);
              num1 = (int) num2 * -899211204 ^ 528343402;
              continue;
            case 59:
              componentResourceManager = new ComponentResourceManager(typeof (Craxspopup));
              num1 = (int) num2 * -1992602473 ^ 1926988795;
              continue;
            case 60:
              ((Craxspopup) this).Panel5.ResumeLayout(false);
              num1 = (int) num2 * 1687710865 ^ 1182249696;
              continue;
            case 61:
              ((Form) this).Text = EXGuarder.\u003793B4D0A;
              ((Craxspopup) this).Panel1.ResumeLayout(false);
              num1 = (int) num2 * 1274215292 ^ 977919806;
              continue;
            case 62:
              ((Craxspopup) this).Panel1.Dock = DockStyle.Top;
              ((Craxspopup) this).Panel1.Location = new Point(0, 0);
              ((Craxspopup) this).Panel1.Name = EXGuarder.\u003301D7627;
              ((Craxspopup) this).Panel1.Size = new Size(487, 133);
              num1 = (int) num2 * 980917235 ^ -1114038631;
              continue;
            case 63:
              ((Craxspopup) this).Panel1.BackColor = Color.Transparent;
              ((Craxspopup) this).Panel1.Controls.Add((Control) ((Craxspopup) this).DrakeUIButtonIcon2);
              ((Craxspopup) this).Panel1.Controls.Add((Control) ((Craxspopup) this).DrakeUIButtonIcon1);
              num1 = (int) num2 * 645155581 ^ -1099154111;
              continue;
            case 64:
              ((Craxspopup) this).Panel2.Dock = DockStyle.Left;
              num1 = (int) num2 * -1700605040 ^ 338587801;
              continue;
            case 65:
              ((Craxspopup) this).DrakeUIButtonIcon1.FillColor = Color.Black;
              num1 = (int) num2 * -634276685 ^ -721056671;
              continue;
            case 66:
              ((Craxspopup) this).Panel1.Controls.Add((Control) ((Craxspopup) this).checkbutton);
              num1 = (int) num2 * -228767780 ^ 1748776146;
              continue;
            case 67:
              ((Craxspopup) this).DrakeUIButtonIcon1.Font = new Font(EXGuarder.\u00340744578, 12f);
              num1 = (int) num2 * 1528096940 ^ -324843370;
              continue;
            case 68:
              ((Craxspopup) this).checkbutton.Symbol = 61453;
              ((Craxspopup) this).checkbutton.TabIndex = 1;
              ((Craxspopup) this).ToolTips.SetToolTip((Control) ((Craxspopup) this).checkbutton, EXGuarder.\u00314410134);
              ((Craxspopup) this).Panel2.BackColor = Color.Transparent;
              num1 = (int) num2 * -103603534 ^ -1405136019;
              continue;
            case 69:
              ((Craxspopup) this).ToolTips.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
              ((ContainerControl) this).AutoScaleDimensions = new SizeF(8f, 16f);
              num1 = (int) num2 * -696395742 ^ -1700690250;
              continue;
            case 70:
              ((Craxspopup) this).checkbutton = new DrakeUIButtonIcon();
              num1 = (int) num2 * -455420398 ^ -1083841700;
              continue;
            case 71:
              ((Craxspopup) this).checkbutton.Name = EXGuarder.\u0033259054C;
              ((Craxspopup) this).checkbutton.Radius = 15;
              ((Craxspopup) this).checkbutton.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
              num1 = (int) num2 * 154325406 ^ 83044659;
              continue;
            case 72:
              ((Craxspopup) this).Panel5.SuspendLayout();
              num1 = (int) num2 * 1732961741 ^ -2098950878;
              continue;
            case 73:
              ((Craxspopup) this).Panel4.BackColor = Color.Transparent;
              num1 = (int) num2 * -246284153 ^ -1172945319;
              continue;
            case 74:
              ((Craxspopup) this).DrakeUIButtonIcon2.Location = new Point(320, 96);
              num1 = (int) num2 * -1063977570 ^ -1849083512;
              continue;
            case 75:
              ((Craxspopup) this).DrakeUIButtonIcon2.TabIndex = 3;
              num1 = (int) num2 * 865261776 ^ -1214063274;
              continue;
            case 76:
              ((Craxspopup) this).DrakeUIButtonIcon2.FillColor = Color.Black;
              ((Craxspopup) this).DrakeUIButtonIcon2.Font = new Font(EXGuarder.\u00340744578, 12f);
              num1 = (int) num2 * -123306234 ^ -1136845696;
              continue;
            case 77:
              ((Craxspopup) this).DrakeUIButtonIcon1.TabIndex = 2;
              num1 = (int) num2 * 1347733227 ^ -1959180470;
              continue;
            case 78:
              goto label_1;
            default:
              goto label_81;
          }
        }
label_3:
        return;
label_81:;
      }
    }

    private struct FormBoundsColors
    {
      private Color borderColor;
      public int leftWidth;
      public int rightWidth;
      public int topHeight;
    }
  }
}
