// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.infoServer
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

#nullable disable
namespace Craxs_Rat
{
  [StandardModule]
  internal sealed class infoServer
  {
    public const Codes.EXECUTION_STATE ES_SYSTEM_REQUIRED = ; // Unable to render the field
    public const Codes.EXECUTION_STATE ES_DISPLAY_REQUIRED = ; // Unable to render the field
    public const Codes.EXECUTION_STATE ES_CONTINUOUS = ; // Unable to render the field
    public Random \u0024VB\u0024Local_random;

    protected virtual WebRequest GetWebRequest(Uri address)
    {
      // ISSUE: explicit non-virtual call
      WebRequest webRequest = __nonvirtual (((WebClient) this).GetWebRequest(address));
label_1:
      int num1 = -1339582509;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((((-868448464 ^ -1923344605 - ~-1074372885) - ((num2 ^ -685823600 * 129310101 - 893723657 + (-~(981061903 ^ -835518478) + -(2108847642 + 1642043015 ^ -114336975 * 58790729))) - (-1062119071 * (-60979486 - 1999123024) - -~-1003672720 - -356500041 * ~~65838905))) * 1076937699 ^ -121734692) * 449790617)) % 5U)
        {
          case 1:
            int num4 = !(webRequest is HttpWebRequest) ? 321542376 : (num4 = 102225940);
            num1 = num4 ^ (int) num3 * 1471265473;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num3 * -1870664654 ^ -2125945301;
            continue;
          case 4:
            ((HttpWebRequest) webRequest).ClientCertificates.Add(new X509Certificate());
            num1 = (int) num3 * -1060675047 ^ 745084238;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return webRequest;
    }
  }
}
