// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.GetCountryName
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  public sealed class GetCountryName
  {
    public GetCountryName()
      : this()
    {
label_1:
      int num1 = 450683715;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~num1 * 1594030953 * -1171871125 - 1350839288 * -1576654737 + 2050285354)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Icons) this).InitializeComponent();
            num1 = (int) num2 * 1595198926 ^ 484613288;
            continue;
          case 2:
            ((Form) this).Load += new EventHandler(((Icons) this).Icons_Load);
            num1 = (int) num2 * -280003285 ^ -783445802;
            continue;
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
  }
}
