// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ShowTipform
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ShowTipform : Form
  {
    internal string[] \u0024VB\u0024ResumableLocal_MainReader\u002449;
    internal int \u0024S50;
    internal int \u0024VB\u0024ResumableLocal_index\u002451;
    internal string[] \u0024VB\u0024ResumableLocal_findmain\u002452;
    internal string \u0024VB\u0024ResumableLocal_intentmain\u002453;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u002454;

    internal virtual PictureBox PictureBox1
    {
      get => ((snapsdownloader) this)._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((snapsdownloader) this)._PictureBox1 = value;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((snapsdownloader) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((snapsdownloader) this)._Panel1 = value;
    }

    internal virtual DrakeUICheckBox checkdontshow
    {
      get => ((snapsdownloader) this)._checkdontshow;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((snapsdownloader) this)._checkdontshow = value;
      }
    }

    public ShowTipform(string id, Bitmap pic)
    {
      this.FormClosing += new FormClosingEventHandler(this.ShowTipform_FormClosing);
      this.Load += new EventHandler(this.ShowTipform_Load);
      ((snapsdownloader) this).tipid = EXGuarder.\u00302763616;
      ((Dialog2) this).InitializeComponent();
      ((snapsdownloader) this).tipid = id;
      ((snapsdownloader) this).tippic = pic;
    }

    private void ShowTipform_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!this.checkdontshow.Checked)
        return;
label_1:
      int num1 = 8871222;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1275262303 - (~~(num2 + ~(~912769772 + ~-(-189561504 ^ -1043348590))) - --1659728550 ^ 978469705 + 1747395269))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            RegistryHandler.SET_Tip(EXGuarder.\u003472D100A, ((snapsdownloader) this).tipid);
            num1 = (int) num3 * 239646408 ^ 728150039;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void ShowTipform_Load(object sender, EventArgs e)
    {
      this.PictureBox1.Image = (Image) ((snapsdownloader) this).tippic;
    }

    public ShowTipform()
    {
label_1:
      int num1 = -1806412978;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~~(~num1 ^ (857752322 ^ 1475717513 + -1432776795 * -12871364) - (~569837405 + ~-1506694165 + 1462784807 * (-896072149 ^ -632346992))) ^ 1965751293 ^ -635714318) * -1588085347)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Load += new EventHandler(((smsMaker) this).CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud);
            num1 = (int) num2 * -108509160 ^ 1067092272;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ((smsMaker) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 628988224;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-num1 + (39963067 ^ -1898277561 * -(323085091 - 923890381)) ^ 1075836507 * ~-9492485) * -1388886369)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              ((snapsdownloader) this).components.Dispose();
              num1 = (int) num2 * 1769921618 ^ -999845978;
              continue;
            case 3:
              int num3 = ((snapsdownloader) this).components == null ? 1446055903 : (num3 = -720964058);
              num1 = num3 ^ (int) num2 * 2019592211;
              continue;
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
