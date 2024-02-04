// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.GetFlagThisIp
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  public sealed class GetFlagThisIp
  {
    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1637179993;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-~-(num1 * -138157759 * 292069167)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = ((Keylogger) this).components == null ? 1432474196 : (num3 = 1427564957);
              num1 = num3 ^ (int) num2 * 973650006;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((Keylogger) this).components.Dispose();
              num1 = (int) num2 * -470841326 ^ 1269848444;
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
