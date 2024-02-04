// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.MultiSounds
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  public class MultiSounds
  {
    public static VB\u0024AnonymousDelegate_0 \u0024I229\u002D4;
    public string \u0024VB\u0024Local_re;

    public bool AddSound(string SoundName, string SndFilePath)
    {
      if (!(Operators.CompareString(SoundName.Trim(), EXGuarder.\u0030C3E6C16, false) == 0 | !File.Exists(SndFilePath)))
        goto label_4;
label_1:
      int num1 = -1142213360;
label_2:
      bool flag;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((270790261 - 1124434838 - ~(~(num2 - ~(-1192854889 * 966750631 * 809199935 - 1426520189)) ^ 278942809 - ((-775366315 ^ 2094312702) - (1479059197 - -542472639)))) * 984310797)) % 8U)
        {
          case 1:
            ((Settings) this).Snds.Add(SoundName, EXGuarder.\u0035A271621 + ((Settings) this).sndcnt.ToString());
            num1 = -2035910687;
            continue;
          case 2:
            goto label_4;
          case 3:
            num1 = (int) num3 * 2031641908 ^ 2037586654;
            continue;
          case 4:
            goto label_1;
          case 5:
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num4 = checked (^(local = ref ((Settings) this).sndcnt) + 1);
            local = num4;
            flag = true;
            num1 = (int) num3 * -520443205 ^ 807577421;
            continue;
          case 6:
            flag = false;
            num1 = (int) num3 * 128443502 ^ 584211371;
            continue;
          case 7:
            flag = false;
            num1 = (int) num3 * 1454683457 ^ 845152685;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return flag;
label_4:
      num1 = Notif_Sound.mciSendStringW(EXGuarder.\u00315597741 + SndFilePath + EXGuarder.\u00343580609 + ((Settings) this).sndcnt.ToString(), (StringBuilder) null, 0U, IntPtr.Zero) == 0 ? 1079140453 : (num1 = 1715894075);
      goto label_2;
    }

    public bool Play(string SoundName)
    {
      if (((Settings) this).Snds.ContainsKey(SoundName))
        goto label_3;
label_1:
      int num1 = -727370078;
label_2:
      bool flag;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-(~num1 * 201961405) ^ ~(-982777017 * 1735241169))) % 9U)
        {
          case 0:
            int num3 = Notif_Sound.mciSendStringW(EXGuarder.\u0032F725C43 + ((Settings) this).Snds[SoundName], (StringBuilder) null, 0U, IntPtr.Zero) == 0 ? -1211809821 : (num3 = 1910717873);
            num1 = num3 ^ (int) num2 * -620881334;
            continue;
          case 1:
            flag = false;
            num1 = (int) num2 * -1425295974 ^ 1120965927;
            continue;
          case 2:
            num1 = (int) num2 * -617451789 ^ 904926420;
            continue;
          case 3:
            flag = false;
            num1 = (int) num2 * 1792940143 ^ -2114859921;
            continue;
          case 4:
            goto label_1;
          case 5:
            num1 = (int) num2 * -1598895423 ^ -817298884;
            continue;
          case 6:
            flag = true;
            num1 = 1362044113;
            continue;
          case 7:
            goto label_3;
          default:
            goto label_10;
        }
      }
label_10:
      return flag;
label_3:
      Notif_Sound.mciSendStringW(EXGuarder.\u00360567531 + ((Settings) this).Snds[SoundName] + EXGuarder.\u0036B62323D, (StringBuilder) null, 0U, IntPtr.Zero);
      num1 = -332283057;
      goto label_2;
    }

    static MultiSounds()
    {
      Settings.FontDrawString = (Font) null;
label_1:
      int num1 = 1213959339;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-num1 ^ -(-~-1390691624 * 268198193)) * -1689386433 ^ -563595045 ^ ~-1749250642)) % 8U)
        {
          case 0:
            Settings.MY_Path = Application.StartupPath + EXGuarder.\u0037349495C;
            num1 = (int) num2 * -735946127 ^ 1745393430;
            continue;
          case 1:
            Settings.res_Path = Application.StartupPath + EXGuarder.\u003233D0B3A;
            Settings.res_Path_iconsapps = Application.StartupPath + EXGuarder.\u00308516775;
            num1 = (int) num2 * -381228415 ^ -1044986399;
            continue;
          case 2:
            Settings.users = EXGuarder.\u00311164302;
            Settings.nameRAT = EXGuarder.\u0031B427067;
            num1 = (int) num2 * 1843536878 ^ -432129346;
            continue;
          case 3:
            Settings.Storepath = Application.StartupPath + EXGuarder.\u0034B061C57;
            Settings.Junkpath = Application.StartupPath + EXGuarder.\u0035752463F;
            Settings.CrashsPath = Application.StartupPath + EXGuarder.\u00321767537;
            num1 = (int) num2 * 844180397 ^ 1399808522;
            continue;
          case 4:
            Settings.f = (Font) null;
            num1 = (int) num2 * -382033253 ^ -1183206741;
            continue;
          case 5:
            goto label_3;
          case 6:
            Settings.domen = EXGuarder.\u00371162675;
            num1 = (int) num2 * -1778812855 ^ 411398087;
            continue;
          case 7:
            goto label_1;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:;
    }

    public static Bitmap CheckAdmin(bool isadmin)
    {
      if (!isadmin)
        goto label_5;
label_1:
      int num1 = 1292161318;
label_2:
      Bitmap bitmap;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(-(num1 - (~-~~1818350698 + ((-1042923492 ^ 910486716) + ~-593263032 ^ -1490840393 * (-494048916 - -2039607332) ^ ~~--589104700))) ^ -(210194715 * (283786549 - 88770798))) ^ -117131483)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            bitmap = Craxs_Rat.My.Resources.Resources.shieldon;
            num1 = (int) num2 * -1802571056 ^ 863784513;
            continue;
          case 2:
            goto label_5;
          case 3:
            num1 = (int) num2 * 628587099 ^ 1480796094;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return bitmap;
label_5:
      bitmap = Craxs_Rat.My.Resources.Resources.shieldoff;
      num1 = 1226714329;
      goto label_2;
    }
  }
}
