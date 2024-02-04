// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.CustomFont
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class CustomFont
  {
    internal Form \u0024VB\u0024Local_o;

    static CustomFont() => Settings.privateFonts = (PrivateFontCollection) null;

    [SpecialName]
    public static Font get_LoadFont(string name, int size, FontStyle style)
    {
      Settings.privateFonts = new PrivateFontCollection();
label_1:
      int num1 = -1766325055;
      Font loadFont;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(num1 - -(~~(155951525 - 1235874888) - (-643716371 - ~(77206985 - 572246682)))) * -175201513 * 1958777327 ^ -1362141904 - 1705180279) - -1170152503)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            Settings.privateFonts.AddFontFile(Settings.res_Path + EXGuarder.\u0031B700228 + name);
            num1 = (int) num2 * 806944921 ^ 1337224566;
            continue;
          case 3:
            loadFont = new Font(Settings.privateFonts.Families[0], (float) size, style);
            num1 = (int) num2 * 908357275 ^ 1663784919;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return loadFont;
    }
  }
}
