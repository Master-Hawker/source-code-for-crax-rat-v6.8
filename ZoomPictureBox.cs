// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ZoomPictureBox
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  [ToolboxBitmap("ZoomPictureBox.bmp")]
  public class ZoomPictureBox : UserControl
  {
    public static string ShowScrenShotTip;
    public static string ShowScrenReadTip;
    public static string Selectedsound;
    public static string Selectedqulity;
    private IContainer components;
    public int MouseWheelDivisor;
    public int MinimumImageWidth;
    public int MinimumImageHeight;
    public double MaximumZoomFactor;
    public bool EnableMouseWheelZooming;
    public bool EnableMouseDragging;
    private Rectangle _ImageBounds;
    private double _ZoomFactor;

    public ZoomPictureBox()
    {
      // ISSUE: unable to decompile the method.
    }

    [Category("_ZoomPictureBox")]
    public Image Image
    {
      get => ((ZoomPictureBox.ZoomType) this)._Image;
      set
      {
        ((ZoomPictureBox.ZoomType) this)._Image = value;
        this.InitializeImage();
      }
    }

    [Category("_ZoomPictureBox")]
    [DefaultValue(0)]
    public ZoomPictureBox.ZoomType ZoomMode
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
      set
      {
        // ISSUE: unable to decompile the method.
      }
    }

    [Browsable(false)]
    public double ZoomFactor
    {
      get => this._ZoomFactor;
      set
      {
        this._ZoomFactor = this.ValidateZoomFactor(value);
label_1:
        int num1 = -564674424;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(num1 ^ ~-(348514439 - 568108498) - (1160347067 * (-2068431561 * -548027077) ^ -121684370 - ~-2131058592) - -1378466137 * 1155836216) * 719289461 - (-432803640 * -1879828085 - -672170370) ^ -1697574052 * 388968413) + 559039717)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              this.Invalidate(this._ImageBounds);
              num1 = (int) num2 * 1039901984 ^ 1809228552;
              continue;
            case 2:
              this.Invalidate(this._ImageBounds);
              num1 = (int) num2 * 1695655056 ^ 209721545;
              continue;
            case 3:
              this._ImageBounds = this.GetZoomedBounds();
              num1 = (int) num2 * 1987032837 ^ -247421009;
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
    }

    [Browsable(false)]
    public Point ImagePosition
    {
      get => this._ImageBounds.Location;
      set => this._ImageBounds.Location = value;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (this.EnableMouseDragging)
      {
label_1:
        int num1 = 2016811863;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((~(1565311744 ^ -182303735) - (~118922607 + ~-278839840) - (num2 ^ ~(103360089 * -1782442150 - 1120701653 * -1911100633) ^ (219797499 - 308349194 - 1198908118) * 1762958503 ^ -((~-762502638 ^ -743762366 ^ -380656142) * -169520547) ^ 1421893525 - (--520198825 ^ ~~-1752094430))) * 932637047 * 1798213009)) % 5U)
          {
            case 0:
              ((ZoomPictureBox.ZoomType) this)._startDrag = e.Location;
              num1 = (int) num3 * -1188274022 ^ 1650235629;
              continue;
            case 1:
              int num4 = e.Button != MouseButtons.Left ? -781779050 : (num4 = -37373800);
              num1 = num4 ^ (int) num3 * 1987488805;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((ZoomPictureBox.ZoomType) this)._dragging = true;
              num1 = (int) num3 * 1109092051 ^ -687137962;
              continue;
            default:
              goto label_6;
          }
        }
      }
label_6:
      base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (((ZoomPictureBox.ZoomType) this)._dragging)
      {
label_1:
        int num1 = -1183426807;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 - -~~~294799977 ^ -996046015 * (509849524 - 1243184669) * -1745049179 * 1878135701) * 634035281 * 1915916847 - 1168012369)) % 7U)
          {
            case 1:
              // ISSUE: variable of a reference type
              Rectangle& local1;
              // ISSUE: explicit reference operation
              int num3 = checked ((^(local1 = ref this._ImageBounds)).X + e.X - ((ZoomPictureBox.ZoomType) this)._startDrag.X);
              local1.X = num3;
              num1 = (int) num2 * -1228150683 ^ -580407483;
              continue;
            case 2:
              this.Invalidate(this._ImageBounds);
              num1 = (int) num2 * -1334955748 ^ 131598891;
              continue;
            case 3:
              this.Invalidate(this._ImageBounds);
              num1 = (int) num2 * 1444046729 ^ -1718166422;
              continue;
            case 4:
              ((ZoomPictureBox.ZoomType) this)._startDrag = e.Location;
              num1 = (int) num2 * 1393164884 ^ 1674231078;
              continue;
            case 5:
              // ISSUE: variable of a reference type
              Rectangle& local2;
              // ISSUE: explicit reference operation
              int num4 = checked ((^(local2 = ref this._ImageBounds)).Y + e.Y - ((ZoomPictureBox.ZoomType) this)._startDrag.Y);
              local2.Y = num4;
              num1 = (int) num2 * -113387394 ^ -1553271324;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_8;
          }
        }
      }
label_8:
      base.OnMouseMove(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (!((ZoomPictureBox.ZoomType) this)._dragging)
        goto label_6;
label_1:
      int num1 = 207745193;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 - 1969768467 * (-(162113909 + (1476272064 + 2057100064)) - 715594796) ^ ~(331488767 + (-1805256816 - 1883521250) + (350331147 * 560801663 ^ 1049238057 + 1745239999))) - (-964946086 * -1793926839 + ~1293557030 + ((2105863639 ^ -1867410283) + -587097963 * -570400267)))) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((ZoomPictureBox.ZoomType) this)._dragging = false;
            num1 = (int) num2 * -1520707617 ^ -1394117338;
            continue;
          case 2:
            this.Invalidate();
            num1 = (int) num2 * -1377718820 ^ -1655650410;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_6:
      base.OnMouseUp(e);
      num1 = 286483086;
      goto label_2;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      this.Select();
      base.OnMouseEnter(e);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      if (!this.EnableMouseWheelZooming)
        goto label_4;
label_1:
      int num1 = 1557181590;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        double zoomFactor;
        switch ((num3 = (uint) (~(~1067045416 ^ -1613157229 * 1793424272) - (num2 ^ ~-321460387 ^ -639038591 * -(834772855 - 1512478829 + (688479828 - 883250781))))) % 6U)
        {
          case 0:
            goto label_4;
          case 1:
            zoomFactor *= 1.0 + (double) e.Delta / (double) this.MouseWheelDivisor;
            this.ZoomFactor = zoomFactor;
            num1 = (int) num3 * -1785661037 ^ 1196840100;
            continue;
          case 2:
            zoomFactor = this._ZoomFactor;
            num1 = (int) num3 * -343590208 ^ 157413862;
            continue;
          case 3:
            int num4 = !this.Bounds.Contains(this.PointToClient(Control.MousePosition)) ? 539623056 : (num4 = 468262712);
            num1 = num4 ^ (int) num3 * -1565306977;
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
label_4:
      base.OnMouseWheel(e);
      num1 = -1956797360;
      goto label_2;
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      if (this._ZoomFactor <= 4.0)
        goto label_6;
label_1:
      int num1 = 1307350019;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-68030198 * 1115519907 - ~~((num2 ^ -(--1111006990 - (1924877846 + 385977841) - ~(-457617337 ^ -1657861253) - ~(-1465635329 - -189909155 - (-54887014 - 1853260105)))) - -253642357 * -(--1640549458 + ~-94373355))) * 2071247119)) % 9U)
        {
          case 0:
            num1 = (int) num3 * -1316375902 ^ -387183657;
            continue;
          case 1:
            pe.Graphics.DrawImage(((ZoomPictureBox.ZoomType) this)._Image, this._ImageBounds);
            num1 = (int) num3 * 73956659 ^ 1188027986;
            continue;
          case 2:
            base.OnPaint(pe);
            num1 = 1536292312;
            continue;
          case 3:
            goto label_6;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          case 6:
            int num4;
            num1 = num4 = ((ZoomPictureBox.ZoomType) this)._Image == null ? -1574118851 : (num4 = -1350791035);
            continue;
          case 7:
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            num1 = (int) num3 * -1507383352 ^ 941807387;
            continue;
          case 8:
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            num1 = (int) num3 * 1455556535 ^ -1495127723;
            continue;
          default:
            goto label_11;
        }
      }
label_3:
      return;
label_11:
      return;
label_6:
      pe.Graphics.InterpolationMode = InterpolationMode.Default;
      num1 = -941950801;
      goto label_2;
    }

    protected override void OnParentChanged(EventArgs e)
    {
      this.InitializeImage();
      base.OnParentChanged(e);
    }

    private void InitializeImage()
    {
      if (((ZoomPictureBox.ZoomType) this)._Image == null)
        goto label_5;
label_1:
      int num1 = -1595734378;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((~(-1718580219 - (-875247184 - 980271312) ^ -593637271 - 1975923633 ^ --293163824) - (-(--677457629 ^ -(-376443467 ^ 461708733 ^ 806294221 ^ -727676438)) - num2) - 441387787 ^ 382685856 - -742634730 + (-1254496773 - 435683715)) + -961123055 - 1688664739)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            this.ZoomFactor = this.FitImageToControl();
            this._ImageBounds = this.CenterImageBounds();
            num1 = (int) num3 * 760438478 ^ -466686651;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.Invalidate();
      num1 = 434297453;
      goto label_2;
    }

    private double ValidateZoomFactor(double zoom)
    {
      zoom = Math.Min(zoom, this.MaximumZoomFactor);
      if (((ZoomPictureBox.ZoomType) this)._Image == null)
        goto label_5;
label_1:
      int num1 = 1943094468;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (--(num1 + (~((769566059 ^ -1440532380 ^ -1167651883) - (-2107528218 - -102723862 + (-1778306845 ^ 2079940153))) + (-1198431441 - (~-2000750882 ^ -339723919 - 1757521679)) * 590529457)) * 1100078929 * -1518650919 ^ -1122524431)) % 7U)
        {
          case 0:
            zoom = (double) this.MinimumImageWidth / (double) ((ZoomPictureBox.ZoomType) this)._Image.Width;
            num1 = (int) num2 * -393669167 ^ -1369682729;
            continue;
          case 1:
            zoom = (double) this.MinimumImageHeight / (double) ((ZoomPictureBox.ZoomType) this)._Image.Height;
            num1 = (int) num2 * -490114966 ^ -1690146960;
            continue;
          case 2:
            int num3;
            num1 = num3 = checked ((int) Math.Round(unchecked ((double) ((ZoomPictureBox.ZoomType) this)._Image.Height * zoom))) >= this.MinimumImageHeight ? 668802456 : (num3 = 1759822630);
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_5;
          case 5:
            int num4 = checked ((int) Math.Round(unchecked ((double) ((ZoomPictureBox.ZoomType) this)._Image.Width * zoom))) >= this.MinimumImageWidth ? -559644394 : (num4 = 1154536361);
            num1 = num4 ^ (int) num2 * -1257296317;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      double num5;
      return num5;
label_5:
      num5 = zoom;
      num1 = -1723565112;
      goto label_2;
    }

    public void RefreshLocation() => this.InitializeImage();

    private double FitImageToControl()
    {
      if (!(this.ClientSize == Size.Empty))
        goto label_4;
label_1:
      int num1 = 284857563;
label_2:
      double num2;
      double control;
      while (true)
      {
        int num3 = num1;
        uint num4;
        double num5;
        Size clientSize;
        switch ((num4 = (uint) (329143958 - (~24125427 - (-(num3 - ~~(-2051357391 * (184197547 * 77399159) + 458001707) + (1527103147 - (-299681384 - -1225424453) - ~(1793148835 ^ 1118751905)) * 648292483) - 17623519)))) % 11U)
        {
          case 1:
            clientSize = this.ClientSize;
            num1 = (int) num4 * -710182684 ^ -40831333;
            continue;
          case 2:
            int num6 = num2 <= num5 ? 1292641361 : (num6 = -243052971);
            num1 = num6 ^ (int) num4 * -598391592;
            continue;
          case 3:
            control = (double) clientSize.Width / (double) ((ZoomPictureBox.ZoomType) this)._Image.Width;
            num1 = (int) num4 * -841739768 ^ 147481887;
            continue;
          case 4:
            num1 = (int) num4 * -575650690 ^ 609862852;
            continue;
          case 5:
            goto label_4;
          case 6:
            clientSize = this.ClientSize;
            num1 = (int) num4 * 2114936332 ^ 1896094141;
            continue;
          case 7:
            clientSize = this.ClientSize;
            control = (double) clientSize.Height / (double) ((ZoomPictureBox.ZoomType) this)._Image.Height;
            num1 = -135910326;
            continue;
          case 8:
            control = 1.0;
            num1 = (int) num4 * 179847432 ^ -1564792606;
            continue;
          case 9:
            double width = (double) clientSize.Width;
            clientSize = this.ClientSize;
            double height = (double) clientSize.Height;
            num5 = width / height;
            num1 = (int) num4 * 55639729 ^ 427098259;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_12:
      return control;
label_4:
      num2 = (double) ((ZoomPictureBox.ZoomType) this)._Image.Width / (double) ((ZoomPictureBox.ZoomType) this)._Image.Height;
      num1 = 116570930;
      goto label_2;
    }

    private Rectangle CenterImageBounds()
    {
      int width = checked ((int) Math.Round(unchecked ((double) ((ZoomPictureBox.ZoomType) this)._Image.Width * this._ZoomFactor)));
      int height = checked ((int) Math.Round(unchecked ((double) ((ZoomPictureBox.ZoomType) this)._Image.Height * this._ZoomFactor)));
      Size clientSize = this.ClientSize;
label_1:
      int num1 = 1779384659;
      int x;
      int y;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (541966016 - (1589733811 * 1037141427 - ~((~-545962025 + (-448649963 ^ -1995467201) * 390523457 - (num2 ^ ~(30839918 - 338888394 - -1258224125 * 1789137556) - -1927596076 + (~-25741586 ^ -2002954213))) * 814996811)))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            x = checked (clientSize.Width - width) / 2;
            clientSize = this.ClientSize;
            y = checked (clientSize.Height - height) / 2;
            num1 = (int) num3 * 1987712844 ^ 461600594;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return new Rectangle(x, y, width, height);
    }

    private Rectangle GetZoomedBounds()
    {
      // ISSUE: unable to decompile the method.
    }

    private Point FindZoomCenter(ZoomPictureBox.ZoomType type)
    {
      // ISSUE: unable to decompile the method.
    }

    public enum ZoomType
    {
    }
  }
}
