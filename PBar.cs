// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.PBar
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  public class PBar : ProgressBar
  {
    protected override CreateParams CreateParams
    {
      [SpecialName] get
      {
        CreateParams createParams = __nonvirtual (((ProgressBar) this).CreateParams);
        createParams.Style |= 4;
        return createParams;
      }
    }
  }
}
