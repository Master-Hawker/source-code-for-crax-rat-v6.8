// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ListData
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  public sealed class ListData
  {
    internal int \u0024S459;
    internal string \u0024VB\u0024ResumableLocal_ea\u0024460;
    internal string[] \u0024VB\u0024ResumableLocal_ay\u0024461;
    internal Exception \u0024VB\u0024ResumableLocal_ex\u0024462;
    internal string[] \u0024VB\u0024ResumableLocal_SPL\u0024463;
    internal string \u0024VB\u0024ResumableLocal_handle\u0024464;

    [SpecialName]
    protected virtual CreateParams get_CreateParams()
    {
      // ISSUE: explicit non-virtual call
      CreateParams createParams = __nonvirtual (((ProgressBar) this).CreateParams);
      createParams.Style |= 4;
      return createParams;
    }
  }
}
