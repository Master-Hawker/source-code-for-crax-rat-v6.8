// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.clsComputerInfo
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

#nullable disable
namespace Craxs_Rat
{
  public class clsComputerInfo
  {
    public static string GetProcessorID()
    {
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery) new SelectQuery(EXGuarder.\u0034C35182E));
      ManagementObjectCollection.ManagementObjectEnumerator enumerator;
      string processorId;
      try
      {
        enumerator = managementObjectSearcher.Get().GetEnumerator();
        if (enumerator.MoveNext())
          goto label_4;
label_2:
        int num1 = 1167154690;
label_3:
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-966463430 - (~-num2 + -(-1412019621 - (-1613286167 ^ -251760268)) ^ -173549259 ^ -1628017435))) % 4U)
        {
          case 0:
            goto label_2;
          case 2:
            break;
          default:
            goto label_10;
        }
label_4:
        processorId = enumerator.Current[EXGuarder.\u003092E6855].ToString();
        num1 = 1600376452;
        goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
label_6:
          int num4 = 40889244;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) (-966463430 - (~-num5 + -(-1412019621 - (-1613286167 ^ -251760268)) ^ -173549259 ^ -1628017435))) % 3U)
            {
              case 0:
                goto label_6;
              case 2:
                enumerator.Dispose();
                num4 = (int) num6 * -1412822627 ^ -211622382;
                continue;
              default:
                goto label_9;
            }
          }
        }
label_9:;
      }
label_10:
      return processorId;
    }

    public static string GenerateHash(string input)
    {
      byte[] hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input + clsComputerInfo.GetVolumeSerial(EXGuarder.\u0036E271C14)));
      Func<byte, string> func;
      // ISSUE: reference to a compiler-generated field
      if (clsComputerInfo._Closure\u0024__.\u0024I3\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        func = clsComputerInfo._Closure\u0024__.\u0024I3\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        clsComputerInfo._Closure\u0024__.\u0024I3\u002D0 = func = new Func<byte, string>(AsyncLock.VB\u0024StateMachine_2_LockAsync.\u0024I._Lambda\u0024__3\u002D0);
      }
      return string.Concat(Enumerable.Select<byte, string>((IEnumerable<byte>) hash, func));
    }

    internal static string GetVolumeSerial(string strDriveLetter = "C")
    {
      ManagementObject managementObject = new ManagementObject(string.Format(EXGuarder.\u0035671561F, (object) strDriveLetter));
label_1:
      int num1 = 459785101;
      string volumeSerial;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * 1608443049 * 429107673 * -758943199 ^ ~(1520519991 * -433134909) ^ -1112770096 - -279702556 ^ -1947389778)) % 4U)
        {
          case 1:
            managementObject.Get();
            num1 = (int) num2 * -769326363 ^ -1482712737;
            continue;
          case 2:
            volumeSerial = managementObject[EXGuarder.\u0034E272253].ToString();
            num1 = (int) num2 * 948945869 ^ 1805003598;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return volumeSerial;
    }

    static clsComputerInfo()
    {
      // ISSUE: reference to a compiler-generated field
      AsyncLock.VB\u0024StateMachine_2_LockAsync.\u0024I = (clsComputerInfo._Closure\u0024__) new clsComputerInfo();
    }
  }
}
