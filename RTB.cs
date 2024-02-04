// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.RTB
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using dummy_ptr;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  public class RTB : RichTextBox
  {
    internal int \u0024VB\u0024ResumableLocal_vul0\u0024477;

    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.Modifiers != Keys.Control)
        goto label_6;
label_1:
      int num1 = 1462646926;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((-num1 + (~853057175 ^ ~(2135535131 + 1424567710))) * 1952647203 ^ 1962306198 - 492551567 * 2026415233) + (1138293584 ^ 1893913831))) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).ctrlPressed = true;
            num1 = (int) num2 * -725082310 ^ 519733319;
            continue;
          case 2:
            goto label_6;
          case 3:
            RTB.HideCaret(this.Handle);
            num1 = (int) num2 * -65659544 ^ -956910776;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_6:
      base.OnKeyDown(e);
      num1 = 425191249;
      goto label_2;
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).ctrlPressed = false;
label_1:
      int num1 = 1002430120;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(~num1 - -1074669953 * (357113286 ^ -(724600691 * 1003296761))) - --2092990204 + 605474096)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            base.OnKeyUp(e);
            num1 = (int) num2 * -69542517 ^ 1380866720;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      RTB.HideCaret(this.Handle);
    }

    [DllImport("user32.dll")]
    public static extern bool HideCaret(IntPtr hwnd);

    public RTB()
      : this()
    {
      ((Form) this).Load += new EventHandler(((Upload) this).Upload_Load);
      ((Form) this).Closing += new CancelEventHandler(((Upload) this).Upload_Closing);
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).FileStream = (FileStream) null;
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Upstream = 0L;
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._stream = 0L;
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).Title = EXGuarder.\u00305475049;
      ((Upload) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -35625067;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(---(-((~(2016079105 + 475239361) ^ -(1969786776 - 88746574)) + 427652945 * (--2078554063 - -1805837907)) - num2) * 985360503)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components == null ? 1817723304 : (num4 = -1383463951);
              num1 = num4 ^ (int) num3 * 279043986;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).components.Dispose();
              num1 = (int) num3 * 1281557890 ^ -2085650236;
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
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Form) this).Dispose(disposing));
      }
    }
  }
}
