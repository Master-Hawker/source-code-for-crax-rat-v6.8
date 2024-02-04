// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.GeoIP
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Net;

#nullable disable
namespace Craxs_Rat
{
  public class GeoIP
  {
    public GeoIP(string FileLocationd)
    {
      ((Keylogger) this).CountryName = new string[253]
      {
        EXGuarder.\u003606E1132,
        EXGuarder.\u00328547805,
        EXGuarder.\u0030B6C326E,
        EXGuarder.\u00326564A08,
        EXGuarder.\u00332201C59,
        EXGuarder.\u003692B5272,
        EXGuarder.\u0035F09051F,
        EXGuarder.\u00302452051,
        EXGuarder.\u0032C2A3553,
        EXGuarder.\u00369466028,
        EXGuarder.\u0035E625B78,
        EXGuarder.\u003124B5B1E,
        EXGuarder.\u00363025849,
        EXGuarder.\u0036A770811,
        EXGuarder.\u00303274960,
        EXGuarder.\u0032C074C47,
        EXGuarder.\u003524C2470,
        EXGuarder.\u00367140464,
        EXGuarder.\u0030D6B022D,
        EXGuarder.\u003293B3C15,
        EXGuarder.\u003233D400F,
        EXGuarder.\u003581A3021,
        EXGuarder.\u00344566D69,
        EXGuarder.\u00360527066,
        EXGuarder.\u00331597342,
        EXGuarder.\u003355D4166,
        EXGuarder.\u003762C3629,
        EXGuarder.\u00360511536,
        EXGuarder.\u0031A74483B,
        EXGuarder.\u00306303856,
        EXGuarder.\u0032046635A,
        EXGuarder.\u0032E3D2808,
        EXGuarder.\u003214C2F02,
        EXGuarder.\u0034F070122,
        EXGuarder.\u00319322F22,
        EXGuarder.\u0030075414B,
        EXGuarder.\u003166F3B11,
        EXGuarder.\u00345575977,
        EXGuarder.\u0035D596B2C,
        EXGuarder.\u0031A24246A,
        EXGuarder.\u0031D4D4401,
        EXGuarder.\u003084A4C10,
        EXGuarder.\u00310054554,
        EXGuarder.\u0037719031F,
        EXGuarder.\u00367480E20,
        EXGuarder.\u00309306401,
        EXGuarder.\u0032729515E,
        EXGuarder.\u0033C776564,
        EXGuarder.\u0035F3D2E29,
        EXGuarder.\u00357485F56,
        EXGuarder.\u0031C45164D,
        EXGuarder.\u0034516190B,
        EXGuarder.\u003043D1247,
        EXGuarder.\u00372387753,
        EXGuarder.\u00360365126,
        EXGuarder.\u003295B1D0D,
        EXGuarder.\u0032F5C0171,
        EXGuarder.\u0037037350C,
        EXGuarder.\u003311E0479,
        EXGuarder.\u0030F6A626B,
        EXGuarder.\u00326267364,
        EXGuarder.\u00353312D75,
        EXGuarder.\u0032A50625C,
        EXGuarder.\u00342332943,
        EXGuarder.\u0031E6A4535,
        EXGuarder.\u003354A3D24,
        EXGuarder.\u0031C5D0623,
        EXGuarder.\u00375062B2B,
        EXGuarder.\u00306727557,
        EXGuarder.\u00367213F3C,
        EXGuarder.\u0031C124841,
        EXGuarder.\u0034F623003,
        EXGuarder.\u0031D314D0B,
        EXGuarder.\u003701B231C,
        EXGuarder.\u0035E292F49,
        EXGuarder.\u0030E621E18,
        EXGuarder.\u003436F271C,
        EXGuarder.\u00339003038,
        EXGuarder.\u0035B6F125F,
        EXGuarder.\u00318114D5F,
        EXGuarder.\u00326496C53,
        EXGuarder.\u003570F2428,
        EXGuarder.\u00302707352,
        EXGuarder.\u003531E603C,
        EXGuarder.\u0033C654205,
        EXGuarder.\u00306687875,
        EXGuarder.\u003363A5327,
        EXGuarder.\u00356606D65,
        EXGuarder.\u00348737976,
        EXGuarder.\u0035E191A4C,
        EXGuarder.\u00375582172,
        EXGuarder.\u0033836295D,
        EXGuarder.\u003392D4029,
        EXGuarder.\u00352743D44,
        EXGuarder.\u00326501F67,
        EXGuarder.\u003603E6531,
        EXGuarder.\u003724E4D6D,
        EXGuarder.\u0037330760F,
        EXGuarder.\u00367482D38,
        EXGuarder.\u0031D636321,
        EXGuarder.\u00337201C11,
        EXGuarder.\u0036F73505C,
        EXGuarder.\u0032B6E1913,
        EXGuarder.\u0030A02403A,
        EXGuarder.\u0031829474F,
        EXGuarder.\u0035949616E,
        EXGuarder.\u0032F310E23,
        EXGuarder.\u00346635619,
        EXGuarder.\u00324527206,
        EXGuarder.\u003673E4D45,
        EXGuarder.\u0030B43546D,
        EXGuarder.\u0031C5E0574,
        EXGuarder.\u0036C273322,
        EXGuarder.\u003240E4C12,
        EXGuarder.\u00352652C5E,
        EXGuarder.\u00379434175,
        EXGuarder.\u0035469555F,
        EXGuarder.\u00368596A3E,
        EXGuarder.\u0036F09395F,
        EXGuarder.\u00372502C5B,
        EXGuarder.\u003451A6556,
        EXGuarder.\u00377432C4A,
        EXGuarder.\u00342315522,
        EXGuarder.\u00314244939,
        EXGuarder.\u0037105342E,
        EXGuarder.\u00300302042,
        EXGuarder.\u0034E105F74,
        EXGuarder.\u0032D703406,
        EXGuarder.\u0036D440C2B,
        EXGuarder.\u00325332641,
        EXGuarder.\u00333101640,
        EXGuarder.\u0033139490B,
        EXGuarder.\u0033C12493B,
        EXGuarder.\u00337222053,
        EXGuarder.\u00336417441,
        EXGuarder.\u00362644044,
        EXGuarder.\u00305432D38,
        EXGuarder.\u0035605664B,
        EXGuarder.\u00347224972,
        EXGuarder.\u0034C1C6427,
        EXGuarder.\u00340192146,
        EXGuarder.\u0036257256F,
        EXGuarder.\u0035D0A3879,
        EXGuarder.\u00375054115,
        EXGuarder.\u0034F720622,
        EXGuarder.\u0034759541E,
        EXGuarder.\u003185E5731,
        EXGuarder.\u0036143664F,
        EXGuarder.\u00311520912,
        EXGuarder.\u00359451700,
        EXGuarder.\u003061E1F2A,
        EXGuarder.\u00344614A56,
        EXGuarder.\u00329061636,
        EXGuarder.\u0030E2A5B5B,
        EXGuarder.\u003123A7930,
        EXGuarder.\u0034D787106,
        EXGuarder.\u003743B442F,
        EXGuarder.\u00339762519,
        EXGuarder.\u00349703114,
        EXGuarder.\u00362280D1D,
        EXGuarder.\u00329173E04,
        EXGuarder.\u00312646913,
        EXGuarder.\u00354080943,
        EXGuarder.\u0031D176A17,
        EXGuarder.\u0032A366159,
        EXGuarder.\u0031B761D72,
        EXGuarder.\u0036D66105A,
        EXGuarder.\u00370303175,
        EXGuarder.\u003543E1D27,
        EXGuarder.\u00305384166,
        EXGuarder.\u0030560430B,
        EXGuarder.\u003186B0926,
        EXGuarder.\u00304506300,
        EXGuarder.\u003240D684A,
        EXGuarder.\u0036129726F,
        EXGuarder.\u00325655A50,
        EXGuarder.\u0035E341B2C,
        EXGuarder.\u00365423357,
        EXGuarder.\u0034A3C5F75,
        EXGuarder.\u0035D474237,
        EXGuarder.\u00319713D31,
        EXGuarder.\u0037253314D,
        EXGuarder.\u00358613516,
        EXGuarder.\u00302322F31,
        EXGuarder.\u003406B4423,
        EXGuarder.\u00305446C2B,
        EXGuarder.\u0034C392C76,
        EXGuarder.\u003473F0762,
        EXGuarder.\u0036076265C,
        EXGuarder.\u00305373855,
        EXGuarder.\u0032F45566E,
        EXGuarder.\u0033E582C30,
        EXGuarder.\u00346370546,
        EXGuarder.\u003565E780E,
        EXGuarder.\u0030A5E7141,
        EXGuarder.\u003650C4361,
        EXGuarder.\u00358204051,
        EXGuarder.\u003175B6F78,
        EXGuarder.\u00368321222,
        EXGuarder.\u00339752350,
        EXGuarder.\u0035C19175F,
        EXGuarder.\u003771E6601,
        EXGuarder.\u0034F75146D,
        EXGuarder.\u00327295E22,
        EXGuarder.\u003631E691C,
        EXGuarder.\u0032E746A60,
        EXGuarder.\u0036C0F1507,
        EXGuarder.\u0031C066457,
        EXGuarder.\u00348067405,
        EXGuarder.\u0033D112A6C,
        EXGuarder.\u00332414577,
        EXGuarder.\u0035B44534C,
        EXGuarder.\u0032B000F2B,
        EXGuarder.\u00336073638,
        EXGuarder.\u0035C6F2B66,
        EXGuarder.\u0033F1A601A,
        EXGuarder.\u00320096C42,
        EXGuarder.\u0035E744D6D,
        EXGuarder.\u003081F6277,
        EXGuarder.\u0034735034F,
        EXGuarder.\u003292E0345,
        EXGuarder.\u0031D494E75,
        EXGuarder.\u00312377257,
        EXGuarder.\u00356102F06,
        EXGuarder.\u003283D6A23,
        EXGuarder.\u0036A416362,
        EXGuarder.\u003190C1141,
        EXGuarder.\u0030B6E2120,
        EXGuarder.\u0031E795F79,
        EXGuarder.\u00376205A41,
        EXGuarder.\u0032C03503D,
        EXGuarder.\u0031B707529,
        EXGuarder.\u00368365077,
        EXGuarder.\u003583C3157,
        EXGuarder.\u00356734876,
        EXGuarder.\u00307381321,
        EXGuarder.\u00339362054,
        EXGuarder.\u00308283225,
        EXGuarder.\u003610A0C41,
        EXGuarder.\u0033A076929,
        EXGuarder.\u003755E7040,
        EXGuarder.\u00312320A76,
        EXGuarder.\u003761F3643,
        EXGuarder.\u003743F535B,
        EXGuarder.\u00302143401,
        EXGuarder.\u0033F377245,
        EXGuarder.\u0033D72463E,
        EXGuarder.\u00362483E0C,
        EXGuarder.\u00367492615,
        EXGuarder.\u003691D0F4F,
        EXGuarder.\u0035E40403F,
        EXGuarder.\u00311602822,
        EXGuarder.\u00326613151
      };
      ((Keylogger) this).CountryCode = new string[254]
      {
        EXGuarder.\u003606E1132,
        EXGuarder.\u0034F742D78,
        EXGuarder.\u003093F3607,
        EXGuarder.\u00358653D1C,
        EXGuarder.\u00300790F19,
        EXGuarder.\u00358797937,
        EXGuarder.\u003756D1C75,
        EXGuarder.\u0033E485219,
        EXGuarder.\u003295C4717,
        EXGuarder.\u0036D695C77,
        EXGuarder.\u0035572431C,
        EXGuarder.\u003155A7943,
        EXGuarder.\u0033024781D,
        EXGuarder.\u0032D6D6F0A,
        EXGuarder.\u003074D7759,
        EXGuarder.\u00366266C50,
        EXGuarder.\u003412A3C3B,
        EXGuarder.\u003136E3E17,
        EXGuarder.\u0033D243903,
        EXGuarder.\u003500D1A01,
        EXGuarder.\u0034D533F11,
        EXGuarder.\u00362341648,
        EXGuarder.\u0036D1C7058,
        EXGuarder.\u0036C11134B,
        EXGuarder.\u0035F331946,
        EXGuarder.\u0033511261C,
        EXGuarder.\u0031E322461,
        EXGuarder.\u003535F3646,
        EXGuarder.\u00331276342,
        EXGuarder.\u0032257180E,
        EXGuarder.\u0036F2E6036,
        EXGuarder.\u00373761B6D,
        EXGuarder.\u00349090B24,
        EXGuarder.\u0030864644A,
        EXGuarder.\u0035C495046,
        EXGuarder.\u0034421506A,
        EXGuarder.\u0030C1B2928,
        EXGuarder.\u00345090634,
        EXGuarder.\u0030C086555,
        EXGuarder.\u003323F1161,
        EXGuarder.\u003753F056C,
        EXGuarder.\u00371255F4F,
        EXGuarder.\u0036067525B,
        EXGuarder.\u00315180429,
        EXGuarder.\u0033628364D,
        EXGuarder.\u0033131464E,
        EXGuarder.\u0037021714B,
        EXGuarder.\u003743D4269,
        EXGuarder.\u00354523723,
        EXGuarder.\u0032B036F15,
        EXGuarder.\u00309176F18,
        EXGuarder.\u0035B587024,
        EXGuarder.\u0036B1A7338,
        EXGuarder.\u0034C705B09,
        EXGuarder.\u00369336730,
        EXGuarder.\u0031819342F,
        EXGuarder.\u0035F15451B,
        EXGuarder.\u0031B196443,
        EXGuarder.\u003232B2471,
        EXGuarder.\u0036E3F5373,
        EXGuarder.\u0035F72076D,
        EXGuarder.\u0031639185D,
        EXGuarder.\u0036D243E11,
        EXGuarder.\u00363480164,
        EXGuarder.\u0031A253B05,
        EXGuarder.\u0033E6A161F,
        EXGuarder.\u0030420655F,
        EXGuarder.\u003706B3766,
        EXGuarder.\u00362492D22,
        EXGuarder.\u00314682207,
        EXGuarder.\u003223C6F78,
        EXGuarder.\u0037330644D,
        EXGuarder.\u0033A5A7750,
        EXGuarder.\u0033D110D68,
        EXGuarder.\u00360730547,
        EXGuarder.\u003695A1040,
        EXGuarder.\u00337194E63,
        EXGuarder.\u003573F5140,
        EXGuarder.\u00367577643,
        EXGuarder.\u00319062A74,
        EXGuarder.\u00322645F3D,
        EXGuarder.\u0032F2E4667,
        EXGuarder.\u0033E400C47,
        EXGuarder.\u003293D6631,
        EXGuarder.\u0033951582E,
        EXGuarder.\u00329586F2F,
        EXGuarder.\u00338703A22,
        EXGuarder.\u0030A574829,
        EXGuarder.\u00330696247,
        EXGuarder.\u003103A3A64,
        EXGuarder.\u0033E4F1804,
        EXGuarder.\u0034E6E5F08,
        EXGuarder.\u00331293118,
        EXGuarder.\u0036A573150,
        EXGuarder.\u0031F433C31,
        EXGuarder.\u00345434A57,
        EXGuarder.\u0031D457300,
        EXGuarder.\u00322505B61,
        EXGuarder.\u00315392047,
        EXGuarder.\u003354A1117,
        EXGuarder.\u00361603003,
        EXGuarder.\u0036C3B5F24,
        EXGuarder.\u0030F780664,
        EXGuarder.\u00372654E44,
        EXGuarder.\u003144A785F,
        EXGuarder.\u0030D272112,
        EXGuarder.\u0036331295E,
        EXGuarder.\u00329782317,
        EXGuarder.\u003766B715C,
        EXGuarder.\u0030C261C1E,
        EXGuarder.\u0031F451932,
        EXGuarder.\u0035E69494E,
        EXGuarder.\u0035E754E1D,
        EXGuarder.\u0036A050A53,
        EXGuarder.\u003003C7205,
        EXGuarder.\u003610D1F53,
        EXGuarder.\u003454A721D,
        EXGuarder.\u0031A75324E,
        EXGuarder.\u0036A042F2A,
        EXGuarder.\u00367225C2B,
        EXGuarder.\u0031633540A,
        EXGuarder.\u0030474536F,
        EXGuarder.\u0031D23331A,
        EXGuarder.\u0035E2D5519,
        EXGuarder.\u0032B0B3E45,
        EXGuarder.\u0031A682E38,
        EXGuarder.\u00353670E47,
        EXGuarder.\u003560A576C,
        EXGuarder.\u003650F6807,
        EXGuarder.\u0034F404E69,
        EXGuarder.\u00339186050,
        EXGuarder.\u003502C5712,
        EXGuarder.\u0036A1E733A,
        EXGuarder.\u00325142208,
        EXGuarder.\u00301693013,
        EXGuarder.\u00351745F39,
        EXGuarder.\u0036019076F,
        EXGuarder.\u0037813764F,
        EXGuarder.\u00331604E6F,
        EXGuarder.\u00348677838,
        EXGuarder.\u00370686546,
        EXGuarder.\u00300594A59,
        EXGuarder.\u0030F5B031D,
        EXGuarder.\u00369781E50,
        EXGuarder.\u00308033223,
        EXGuarder.\u00307650A3A,
        EXGuarder.\u0032748491F,
        EXGuarder.\u0032E56064D,
        EXGuarder.\u00303226F48,
        EXGuarder.\u00373140E70,
        EXGuarder.\u0035F783768,
        EXGuarder.\u0037600730D,
        EXGuarder.\u0032B360013,
        EXGuarder.\u0033F22405C,
        EXGuarder.\u003696E5131,
        EXGuarder.\u00305661F3C,
        EXGuarder.\u00328463111,
        EXGuarder.\u003006F665A,
        EXGuarder.\u0035A343141,
        EXGuarder.\u00329085330,
        EXGuarder.\u0036E476E2B,
        EXGuarder.\u0034A797102,
        EXGuarder.\u00322345D34,
        EXGuarder.\u00379610452,
        EXGuarder.\u003713E583A,
        EXGuarder.\u00327561E76,
        EXGuarder.\u003170F6B3C,
        EXGuarder.\u00356026956,
        EXGuarder.\u003374E0E46,
        EXGuarder.\u00324740E42,
        EXGuarder.\u003262D255B,
        EXGuarder.\u00327464F1D,
        EXGuarder.\u00344127452,
        EXGuarder.\u0030F737153,
        EXGuarder.\u003014B3742,
        EXGuarder.\u00312551A2C,
        EXGuarder.\u0032F0F4639,
        EXGuarder.\u0036172365E,
        EXGuarder.\u0036061652F,
        EXGuarder.\u003731C0B37,
        EXGuarder.\u0035F1B3239,
        EXGuarder.\u003544B1B2F,
        EXGuarder.\u0030D052047,
        EXGuarder.\u0033D714B08,
        EXGuarder.\u0035C5F463B,
        EXGuarder.\u003310E551E,
        EXGuarder.\u00310531C2B,
        EXGuarder.\u003291C3E59,
        EXGuarder.\u00332053659,
        EXGuarder.\u003713F5F0C,
        EXGuarder.\u0034F24190C,
        EXGuarder.\u00300196630,
        EXGuarder.\u0032702365D,
        EXGuarder.\u003111B7676,
        EXGuarder.\u003085B0E66,
        EXGuarder.\u00364174665,
        EXGuarder.\u0033D243E5B,
        EXGuarder.\u003524F3E37,
        EXGuarder.\u003356B1033,
        EXGuarder.\u0035B364467,
        EXGuarder.\u003732B654C,
        EXGuarder.\u0033142290A,
        EXGuarder.\u0036B082B3E,
        EXGuarder.\u00315744D6C,
        EXGuarder.\u0033F3A4225,
        EXGuarder.\u003175D0825,
        EXGuarder.\u0033C022428,
        EXGuarder.\u00318702458,
        EXGuarder.\u00320252136,
        EXGuarder.\u00316195716,
        EXGuarder.\u00313271951,
        EXGuarder.\u003675A0276,
        EXGuarder.\u0036B764C09,
        EXGuarder.\u003225E3667,
        EXGuarder.\u0033E0C6A01,
        EXGuarder.\u00374252F23,
        EXGuarder.\u0035B320C33,
        EXGuarder.\u00300726058,
        EXGuarder.\u003760B7264,
        EXGuarder.\u00319046D1B,
        EXGuarder.\u0036D6F6206,
        EXGuarder.\u003422C550B,
        EXGuarder.\u00369137836,
        EXGuarder.\u003126D415B,
        EXGuarder.\u0032051340B,
        EXGuarder.\u003373C4D6D,
        EXGuarder.\u0032F681F24,
        EXGuarder.\u00346285C6D,
        EXGuarder.\u0031D654110,
        EXGuarder.\u0035D441434,
        EXGuarder.\u00337373D41,
        EXGuarder.\u0033F2C1E13,
        EXGuarder.\u00317772545,
        EXGuarder.\u0035D211526,
        EXGuarder.\u00313736B2A,
        EXGuarder.\u003275B793F,
        EXGuarder.\u003690C2208,
        EXGuarder.\u0033F310177,
        EXGuarder.\u003282C3C61,
        EXGuarder.\u003256B0078,
        EXGuarder.\u003225F3F79,
        EXGuarder.\u0036203316F,
        EXGuarder.\u00329264C22,
        EXGuarder.\u0036B713B42,
        EXGuarder.\u0030E5E1C2D,
        EXGuarder.\u003276C3924,
        EXGuarder.\u0032C440E75,
        EXGuarder.\u003645E064C,
        EXGuarder.\u0030603410A,
        EXGuarder.\u0033B5B1B02,
        EXGuarder.\u00376002848,
        EXGuarder.\u0034F1F2A52,
        EXGuarder.\u003421F311F,
        EXGuarder.\u003580F7368
      };
      ((Keylogger) this).CountryNump = new string[(int) byte.MaxValue]
      {
        EXGuarder.\u0030845083C,
        EXGuarder.\u003326B5F3B,
        EXGuarder.\u0033E581712,
        EXGuarder.\u0032D425942,
        EXGuarder.\u0030B001D73,
        EXGuarder.\u0036214473F,
        EXGuarder.\u0031153544B,
        EXGuarder.\u003356B4373,
        EXGuarder.\u00378380956,
        EXGuarder.\u00315181943,
        EXGuarder.\u0034333646E,
        EXGuarder.\u0036D744A6D,
        EXGuarder.\u00308524707,
        EXGuarder.\u0033A46474A,
        EXGuarder.\u00328414E08,
        EXGuarder.\u00302796A13,
        EXGuarder.\u0033C580B68,
        EXGuarder.\u0032038645F,
        EXGuarder.\u0033466243B,
        EXGuarder.\u003174D596E,
        EXGuarder.\u003534E1E36,
        EXGuarder.\u0035140090F,
        EXGuarder.\u00307086128,
        EXGuarder.\u003520E0E07,
        EXGuarder.\u003056B5D5F,
        EXGuarder.\u00322777871,
        EXGuarder.\u0031E572370,
        EXGuarder.\u003464B1835,
        EXGuarder.\u003565D2A18,
        EXGuarder.\u003000E084C,
        EXGuarder.\u0036D50423D,
        EXGuarder.\u00351005504,
        EXGuarder.\u0033C30272C,
        EXGuarder.\u0030E1B6714,
        EXGuarder.\u00346046E62,
        EXGuarder.\u00314754428,
        EXGuarder.\u0030E3A295E,
        EXGuarder.\u003285D2341,
        EXGuarder.\u0034E530333,
        EXGuarder.\u0033349574B,
        EXGuarder.\u0030F021429,
        EXGuarder.\u0034F29701B,
        EXGuarder.\u003056C2B75,
        EXGuarder.\u00308106A0A,
        EXGuarder.\u003252D0A1E,
        EXGuarder.\u003453E3858,
        EXGuarder.\u00348733050,
        EXGuarder.\u00318555916,
        EXGuarder.\u00364333423,
        EXGuarder.\u003285E746B,
        EXGuarder.\u00352275D4A,
        EXGuarder.\u0034D1E190F,
        EXGuarder.\u0031F5D4823,
        EXGuarder.\u0030A5F4C00,
        EXGuarder.\u003573A092C,
        EXGuarder.\u0033D287162,
        EXGuarder.\u0035D654137,
        EXGuarder.\u003186B4555,
        EXGuarder.\u003361E422A,
        EXGuarder.\u00337275C32,
        EXGuarder.\u00320262E03,
        EXGuarder.\u0036D105823,
        EXGuarder.\u0034B03216F,
        EXGuarder.\u0031F076939,
        EXGuarder.\u00324656F57,
        EXGuarder.\u0033C44545E,
        EXGuarder.\u00301465E21,
        EXGuarder.\u00371487270,
        EXGuarder.\u00378522E66,
        EXGuarder.\u003461A1146,
        EXGuarder.\u0035A756124,
        EXGuarder.\u0030D602D2C,
        EXGuarder.\u00323482A0A,
        EXGuarder.\u0032C1C025F,
        EXGuarder.\u0031D1D3633,
        EXGuarder.\u0030E673278,
        EXGuarder.\u0034A766A31,
        EXGuarder.\u0033E482411,
        EXGuarder.\u0030C333251,
        EXGuarder.\u00340012632,
        EXGuarder.\u0031337004D,
        EXGuarder.\u00337783B10,
        EXGuarder.\u0035E634533,
        EXGuarder.\u0032F375E24,
        EXGuarder.\u00319086216,
        EXGuarder.\u0035D484201,
        EXGuarder.\u003222F0040,
        EXGuarder.\u0035D1C4643,
        EXGuarder.\u00349624931,
        EXGuarder.\u003774F4D23,
        EXGuarder.\u0031A595369,
        EXGuarder.\u003614C6163,
        EXGuarder.\u00331022973,
        EXGuarder.\u00312504D3B,
        EXGuarder.\u0034736203A,
        EXGuarder.\u0032E452223,
        EXGuarder.\u00323340C25,
        EXGuarder.\u003745F602E,
        EXGuarder.\u0033E1A1F45,
        EXGuarder.\u00310351C06,
        EXGuarder.\u003796C1D79,
        EXGuarder.\u0030B640743,
        EXGuarder.\u0034A34072C,
        EXGuarder.\u003610F4A6D,
        EXGuarder.\u0036F743B0C,
        EXGuarder.\u0031D084579,
        EXGuarder.\u00375471548,
        EXGuarder.\u00304786404,
        EXGuarder.\u003182F1F48,
        EXGuarder.\u0037070150A,
        EXGuarder.\u0037146275C,
        EXGuarder.\u00307371B6F,
        EXGuarder.\u00353200965,
        EXGuarder.\u003202E360E,
        EXGuarder.\u0035145145A,
        EXGuarder.\u00311623323,
        EXGuarder.\u0036D6B3234,
        EXGuarder.\u0036F631459,
        EXGuarder.\u003473C5A2A,
        EXGuarder.\u0032C201C19,
        EXGuarder.\u0034B1C231A,
        EXGuarder.\u0033F565103,
        EXGuarder.\u0033C19632E,
        EXGuarder.\u003573D5D51,
        EXGuarder.\u0030B776D40,
        EXGuarder.\u00348392B16,
        EXGuarder.\u003126C6075,
        EXGuarder.\u0032E3B2B38,
        EXGuarder.\u0030B020A43,
        EXGuarder.\u0033076735C,
        EXGuarder.\u00369480304,
        EXGuarder.\u0032D556D14,
        EXGuarder.\u00342297044,
        EXGuarder.\u00316251938,
        EXGuarder.\u003676C560F,
        EXGuarder.\u003605F761E,
        EXGuarder.\u0031B0B1363,
        EXGuarder.\u00309266D43,
        EXGuarder.\u0030A4E4064,
        EXGuarder.\u003424F0618,
        EXGuarder.\u003341D4E1F,
        EXGuarder.\u00305253047,
        EXGuarder.\u00310333B4A,
        EXGuarder.\u00367143052,
        EXGuarder.\u0035E1C1357,
        EXGuarder.\u00345165716,
        EXGuarder.\u00336474B0D,
        EXGuarder.\u00329387557,
        EXGuarder.\u00337372E72,
        EXGuarder.\u0035E6B0251,
        EXGuarder.\u00351371B50,
        EXGuarder.\u0032D615776,
        EXGuarder.\u003333D401C,
        EXGuarder.\u003084E691B,
        EXGuarder.\u0031A6E6A22,
        EXGuarder.\u003255D6275,
        EXGuarder.\u0030A6F7410,
        EXGuarder.\u0030573311A,
        EXGuarder.\u00325460B79,
        EXGuarder.\u00368750C06,
        EXGuarder.\u0033F251C5F,
        EXGuarder.\u00324686B1C,
        EXGuarder.\u00341061C3F,
        EXGuarder.\u0035668183A,
        EXGuarder.\u003745A3753,
        EXGuarder.\u00306225022,
        EXGuarder.\u00315193279,
        EXGuarder.\u0033B246745,
        EXGuarder.\u0035D306D27,
        EXGuarder.\u003272E2054,
        EXGuarder.\u0032D4A0423,
        EXGuarder.\u0035677731E,
        EXGuarder.\u00370032B64,
        EXGuarder.\u0032D320A44,
        EXGuarder.\u00307680F56,
        EXGuarder.\u0035B4A774C,
        EXGuarder.\u0034113251A,
        EXGuarder.\u0033934074A,
        EXGuarder.\u00355092064,
        EXGuarder.\u0035B454D31,
        EXGuarder.\u003715D5804,
        EXGuarder.\u003403A1F0E,
        EXGuarder.\u0030C062F19,
        EXGuarder.\u0035A233A61,
        EXGuarder.\u003142C2F4F,
        EXGuarder.\u0033C36395F,
        EXGuarder.\u0031C2C596E,
        EXGuarder.\u0031B3E1664,
        EXGuarder.\u0033C657207,
        EXGuarder.\u0033A4B7840,
        EXGuarder.\u00377645B78,
        EXGuarder.\u00344572045,
        EXGuarder.\u0034E0C1308,
        EXGuarder.\u00308070F6B,
        EXGuarder.\u00333631103,
        EXGuarder.\u003283C1F14,
        EXGuarder.\u0033B3D3E0D,
        EXGuarder.\u00349693603,
        EXGuarder.\u003484E014B,
        EXGuarder.\u0035776123F,
        EXGuarder.\u00347143E3C,
        EXGuarder.\u003582A5758,
        EXGuarder.\u0034A031026,
        EXGuarder.\u003543E7056,
        EXGuarder.\u00342494943,
        EXGuarder.\u0033F4A7755,
        EXGuarder.\u0035B013668,
        EXGuarder.\u00322324F0D,
        EXGuarder.\u003122F2046,
        EXGuarder.\u00325411A57,
        EXGuarder.\u0032A4F6B18,
        EXGuarder.\u003556D4B22,
        EXGuarder.\u00378424265,
        EXGuarder.\u00377412513,
        EXGuarder.\u003713D7104,
        EXGuarder.\u0031D032C23,
        EXGuarder.\u00308456948,
        EXGuarder.\u003161C1721,
        EXGuarder.\u003410F2C77,
        EXGuarder.\u00356677237,
        EXGuarder.\u0037844606E,
        EXGuarder.\u0034B300036,
        EXGuarder.\u0036D755C22,
        EXGuarder.\u00345411F00,
        EXGuarder.\u00307291D71,
        EXGuarder.\u0033215175F,
        EXGuarder.\u00337256108,
        EXGuarder.\u00315511C72,
        EXGuarder.\u00371562B78,
        EXGuarder.\u003435B781A,
        EXGuarder.\u003611E670F,
        EXGuarder.\u003232F0D4E,
        EXGuarder.\u00313041E06,
        EXGuarder.\u0033F064972,
        EXGuarder.\u00312343B3F,
        EXGuarder.\u00346733435,
        EXGuarder.\u0030E706D47,
        EXGuarder.\u003691F4D32,
        EXGuarder.\u0034E350A6A,
        EXGuarder.\u003026D674F,
        EXGuarder.\u0035E2C300A,
        EXGuarder.\u0036E041246,
        EXGuarder.\u0031D124976,
        EXGuarder.\u003390C534C,
        EXGuarder.\u0030902254D,
        EXGuarder.\u0034A3C694F,
        EXGuarder.\u0035048293E,
        EXGuarder.\u00322723F61,
        EXGuarder.\u00375036B3C,
        EXGuarder.\u003423E551F,
        EXGuarder.\u003681A7144,
        EXGuarder.\u0030C586211,
        EXGuarder.\u0033B6C192C,
        EXGuarder.\u00339141263,
        EXGuarder.\u00304763768
      };
      if (!System.IO.File.Exists(FileLocationd))
        return;
      FileStream fileStream = new FileStream(FileLocationd, FileMode.Open, FileAccess.Read);
      ((Keylogger) this).MS = new MemoryStream();
      byte[] numArray = new byte[257];
      while (fileStream.Read(numArray, 0, numArray.Length) != 0)
        ((Keylogger) this).MS.Write(numArray, 0, numArray.Length);
      fileStream.Dispose();
      fileStream.Close();
    }

    private long ConvertIPAddressToNumber(IPAddress IPA)
    {
      string[] strArray = Strings.Split(IPA.ToString(), EXGuarder.\u00356081560);
      if (Information.UBound((Array) strArray) != 3)
        goto label_5;
label_1:
      int num1 = 1543551218;
label_2:
      long number;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 ^ ~((~(1216405016 ^ 1331616923) - (~-1502494335 - --1765861824)) * -185828365) ^ -569158733 * (--1525821805 + (-1402175398 - ~91913572))) - 538032866) - ~1668635934 ^ -1238083628)) % 5U)
        {
          case 0:
            num1 = (int) num2 * -433508657 ^ 331276425;
            continue;
          case 1:
            goto label_5;
          case 3:
            number = checked ((long) Math.Round(unchecked (16777216.0 * Conversions.ToDouble(strArray[0]) + 65536.0 * Conversions.ToDouble(strArray[1]) + 256.0 * Conversions.ToDouble(strArray[2]) + Conversions.ToDouble(strArray[3]))));
            num1 = (int) num2 * -1478195469 ^ 2059134270;
            continue;
          case 4:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return number;
label_5:
      number = 0L;
      num1 = 1898089429;
      goto label_2;
    }

    public string LookupCountryCode(IPAddress IPA)
    {
      return ((Keylogger) this).CountryCode[checked ((int) this.SeekCountry(0L, this.ConvertIPAddressToNumber(IPA), 31))];
    }

    public string LookupCountryNump(IPAddress IPA)
    {
      return ((Keylogger) this).CountryNump[checked ((int) this.SeekCountry(0L, this.ConvertIPAddressToNumber(IPA), 31))];
    }

    public string LookupCountryNump(string IPAa)
    {
      IPAddress IPA;
      string str1;
      try
      {
        IPA = IPAddress.Parse(IPAa);
      }
      catch (FormatException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        FormatException ex2 = ex1;
label_2:
        int num1 = -606297342;
        string str2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) --~num1) % 4U)
          {
            case 1:
              ProjectData.SetProjectError((Exception) ex2);
              str2 = EXGuarder.\u0036F30296F;
              num1 = (int) num2 * -1439401104 ^ 153965489;
              continue;
            case 2:
              ProjectData.ClearProjectError();
              str1 = str2;
              num1 = (int) num2 * -1719449347 ^ 363873469;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_6;
          }
        }
label_6:
        ProjectData.ClearProjectError();
        goto label_8;
      }
      str1 = this.LookupCountryNump(IPA);
label_8:
      return str1;
    }

    public string LookupCountryCode(string IPA)
    {
      IPAddress IPA1;
      string str1;
      try
      {
        IPA1 = IPAddress.Parse(IPA);
      }
      catch (FormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
label_2:
        int num1 = 1677501990;
        string str2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(num1 - ((-(-134003309 - 254702798) + ((11288695 ^ -939662046) + -862703045)) * 1458775119 - -~(-1423889786 - -1402535260 ^ 1221884735))) + (-705059197 * ~1076931813 + (~195447780 + (-1205468323 - 1674706218))))) % 5U)
          {
            case 0:
              str1 = str2;
              num1 = (int) num2 * 2041253572 ^ -1862940044;
              continue;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num2 * -1878948727 ^ 454284673;
              continue;
            case 2:
              goto label_2;
            case 4:
              str2 = EXGuarder.\u003634C6E76;
              num1 = (int) num2 * 486088821 ^ 235663519;
              continue;
            default:
              goto label_11;
          }
        }
      }
      string str3 = this.LookupCountryCode(IPA1);
label_8:
      int num3 = 645119281;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) (~(num3 - ((-(-134003309 - 254702798) + ((11288695 ^ -939662046) + -862703045)) * 1458775119 - -~(-1423889786 - -1402535260 ^ 1221884735))) + (-705059197 * ~1076931813 + (~195447780 + (-1205468323 - 1674706218))))) % 3U)
        {
          case 1:
            str1 = str3;
            num3 = (int) num4 * 1749624332 ^ -1727921935;
            continue;
          case 2:
            goto label_8;
          default:
            goto label_11;
        }
      }
label_11:
      return str1;
    }

    public string LookupCountryName(IPAddress addr)
    {
      return ((Keylogger) this).CountryName[checked ((int) this.SeekCountry(0L, this.ConvertIPAddressToNumber(addr), 31))];
    }

    public string LookupCountryName(string IPA)
    {
      IPAddress addr;
      string str1;
      try
      {
        addr = IPAddress.Parse(IPA);
      }
      catch (FormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
label_2:
        int num1 = 622949779;
        while (true)
        {
          int num2 = num1;
          uint num3;
          string str2;
          switch ((num3 = (uint) (543234775 * -225836065 - (-~(-681181332 - (~-991925204 - -243168767)) - num2) - (~~596176838 + ((711245442 ^ -180541994) + -2006154503 * 1504276987)) - (1043092678 * -122195295 - 568464511 * 768993175) - ~-1430484026 ^ -2113052404)) % 5U)
          {
            case 0:
              goto label_2;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * -435646186 ^ 736845863;
              continue;
            case 2:
              str2 = EXGuarder.\u003455D4863;
              num1 = (int) num3 * -1290755605 ^ -1535431806;
              continue;
            case 3:
              str1 = str2;
              num1 = (int) num3 * -1842635292 ^ 1241200298;
              continue;
            default:
              goto label_11;
          }
        }
      }
      string str3 = this.LookupCountryName(addr);
label_8:
      int num4 = 1262278813;
      while (true)
      {
        int num5 = num4;
        uint num6;
        switch ((num6 = (uint) (543234775 * -225836065 - (-~(-681181332 - (~-991925204 - -243168767)) - num5) - (~~596176838 + ((711245442 ^ -180541994) + -2006154503 * 1504276987)) - (1043092678 * -122195295 - 568464511 * 768993175) - ~-1430484026 ^ -2113052404)) % 3U)
        {
          case 1:
            str1 = str3;
            num4 = (int) num6 * -781163587 ^ 1766962431;
            continue;
          case 2:
            goto label_8;
          default:
            goto label_11;
        }
      }
label_11:
      return str1;
    }

    private long vbShiftLeft(long Value, int Count)
    {
      long num1 = Value;
      int num2 = Count;
      int num3 = 1;
label_1:
      int num4 = -1382610325;
      while (true)
      {
        uint num5;
        switch ((num5 = (uint) ((-(-num4 + ~-(-105114971 + 1639238632)) * -1212546041 + ~728821912) * -1831553507)) % 5U)
        {
          case 0:
            checked { num1 *= 2L; }
            checked { ++num3; }
            num4 = -1018850513;
            continue;
          case 1:
            num4 = (int) num5 * 363640326 ^ 2032527407;
            continue;
          case 2:
            int num6;
            num4 = num6 = num3 <= num2 ? -585979684 : (num6 = 884043318);
            continue;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_6:
      return num1;
    }

    private long vbShiftRight(long Value, int Count)
    {
      long num1 = Value;
label_1:
      int num2 = 214506777;
      long num3;
      while (true)
      {
        int num4 = num2;
        uint num5;
        int num6;
        int num7;
        switch ((num5 = (uint) ((1324154080 - -2088203485 - -1133362332 - (-736018729 + -1730286032) - num4 * -1306735801 * 850037055 - -~-721004282) * 1744382755 ^ 48378813)) % 8U)
        {
          case 0:
            num2 = (int) num5 * -2024748700 ^ -1575961461;
            continue;
          case 1:
            num1 = checked ((long) Math.Round(unchecked ((double) num1 / 2.0)));
            num2 = -1741837550;
            continue;
          case 2:
            goto label_1;
          case 3:
            num7 = Count;
            num6 = 1;
            num2 = (int) num5 * -1426292924 ^ 914237080;
            continue;
          case 4:
            num3 = num1;
            num2 = (int) num5 * 489178228 ^ 227530981;
            continue;
          case 5:
            int num8;
            num2 = num8 = num6 <= num7 ? -1558212257 : (num8 = 1243147576);
            continue;
          case 6:
            checked { ++num6; }
            num2 = (int) num5 * 1626538282 ^ -233746793;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return num3;
    }

    private long SeekCountry(long StartOffset, long IPNumber, int SearchDepth)
    {
      byte[] buffer = new byte[7];
      long[] numArray = new long[3];
      if (SearchDepth == 0)
        ;
      try
      {
        ((Keylogger) this).MS.Seek(checked (6L * StartOffset), SeekOrigin.Begin);
        ((Keylogger) this).MS.Read(buffer, 0, 6);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      int index = 0;
label_4:
      int num1 = 165045674;
      int num2;
      int num3;
      long num4;
      long num5;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) ~(~num1 * 1361591719)) % 21U)
        {
          case 0:
            num5 = num4;
            num1 = 719730263;
            continue;
          case 2:
            numArray[index] = 0L;
            num3 = 0;
            num1 = 1635600934;
            continue;
          case 3:
            // ISSUE: variable of a reference type
            long& local;
            // ISSUE: explicit reference operation
            long num7 = checked (^(local = ref numArray[index]) + this.vbShiftLeft((long) num2, num3 * 8));
            local = num7;
            checked { ++num3; }
            num1 = -787610814;
            continue;
          case 4:
            int num8;
            num1 = num8 = (IPNumber & this.vbShiftLeft(1L, SearchDepth)) <= 0L ? 1025138504 : (num8 = -614727665);
            continue;
          case 5:
            num4 = this.SeekCountry(numArray[1], IPNumber, checked (SearchDepth - 1));
            num1 = -1036599119;
            continue;
          case 6:
            num2 = (int) buffer[checked (index * 3 + num3)];
            int num9;
            num1 = num9 = num2 >= 0 ? 1058101856 : (num9 = 429300603);
            continue;
          case 7:
            goto label_4;
          case 8:
            num1 = (int) num6 * 1353440152 ^ 568989545;
            continue;
          case 9:
            num4 = this.SeekCountry(numArray[0], IPNumber, checked (SearchDepth - 1));
            num1 = -1036599119;
            continue;
          case 10:
            int num10 = index > 1 ? 1448486005 : (num10 = 822084656);
            num1 = num10 ^ (int) num6 * -1644216162;
            continue;
          case 11:
            int num11 = num3 <= 2 ? 34447370 : (num11 = -1425173855);
            num1 = num11 ^ (int) num6 * -1951009961;
            continue;
          case 12:
            num4 = checked (numArray[1] - Keylogger.CountryBegin);
            num1 = (int) num6 * -1393095045 ^ -2130501941;
            continue;
          case 13:
            checked { ++index; }
            num1 = -110367925;
            continue;
          case 14:
            num4 = checked (numArray[0] - Keylogger.CountryBegin);
            num1 = (int) num6 * -765672747 ^ 953362430;
            continue;
          case 15:
            checked { num2 += 256; }
            num1 = 1058101856;
            continue;
          case 16:
            int num12 = numArray[1] < Keylogger.CountryBegin ? -1240204978 : (num12 = 1945230660);
            num1 = num12 ^ (int) num6 * -999827356;
            continue;
          case 17:
            num1 = (int) num6 * 1202397970 ^ -1041075782;
            continue;
          case 18:
            num1 = (int) num6 * -303617561 ^ -1422498850;
            continue;
          case 19:
            int num13;
            num1 = num13 = numArray[0] < Keylogger.CountryBegin ? 447340649 : (num13 = 1232664127);
            continue;
          case 20:
            num1 = (int) num6 * 767301562 ^ -1170574060;
            continue;
          default:
            goto label_25;
        }
      }
label_25:
      return num5;
    }

    public static string GetCountryName(string ipc)
    {
      // ISSUE: reference to a compiler-generated field
      string inputtext = Data.VB\u0024StateMachine_39_HandelData.GeoIP0.LookupCountryName(ipc.Trim());
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = -89169363;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~-(-num1 - -(-1588812042 - (-710906036 ^ -273257651)) * 458238641)) % 7U)
        {
          case 0:
            inputtext = Codes.Translate(inputtext, EXGuarder.\u0032D526F2D, EXGuarder.\u00314063107);
            num1 = -1002498482;
            continue;
          case 1:
            int num3 = Operators.CompareString(language, EXGuarder.\u00363784315, false) != 0 ? -1218744224 : (num3 = 1916990222);
            num1 = num3 ^ (int) num2 * 1304117593;
            continue;
          case 2:
            inputtext = Codes.Translate(inputtext, EXGuarder.\u0032D526F2D, EXGuarder.\u00369036371);
            num1 = (int) num2 * 504901158 ^ 1732608052;
            continue;
          case 3:
            int num4 = Operators.CompareString(language, EXGuarder.\u00310357130, false) == 0 ? -83619443 : (num4 = -890752228);
            num1 = num4 ^ (int) num2 * -206320842;
            continue;
          case 4:
            num1 = (int) num2 * 828895129 ^ -103855562;
            continue;
          case 5:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_8:
      return inputtext;
    }

    public static Image ThisIp(string ipc)
    {
      // ISSUE: reference to a compiler-generated field
      string upper = Data.VB\u0024StateMachine_39_HandelData.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper();
      // ISSUE: reference to a compiler-generated field
      int num1 = Array.IndexOf<string>(((Keylogger) Data.VB\u0024StateMachine_39_HandelData.GeoIP0).CountryCode, upper);
label_1:
      int num2 = -1460565683;
      int num3;
      int index;
      while (true)
      {
        uint num4;
        switch ((num4 = (uint) ((~(num2 - ~--~-531006969 * 1118626801) ^ ~(1811305452 - -335297222) - 185008479 * -1435613400) * -528115203 * 1866349941 - -1698575702)) % 11U)
        {
          case 0:
            int num5 = num3 != -1 ? 713379686 : (num5 = 891508107);
            num2 = num5 ^ (int) num4 * 997026156;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            index = Data.VB\u0024StateMachine_39_HandelData.imageFlags.Images.IndexOfKey(upper);
            num2 = (int) num4 * 1268641594 ^ -66501937;
            continue;
          case 2:
            int num6;
            // ISSUE: reference to a compiler-generated field
            num2 = num6 = num3 != ((Keylogger) Data.VB\u0024StateMachine_39_HandelData.GeoIP0).CountryName.Length ? -954730185 : (num6 = -2110326902);
            continue;
          case 3:
            num1 = 0;
            num2 = (int) num4 * 1988764725 ^ -844761991;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            if (num3 > ((Keylogger) Data.VB\u0024StateMachine_39_HandelData.GeoIP0).CountryName.Length)
            {
              num2 = 682982731;
              continue;
            }
            goto label_13;
          case 5:
            goto label_1;
          case 6:
            checked { --num1; }
            index = -1;
            num2 = (int) num4 * 418101833 ^ 609322521;
            continue;
          case 7:
            num3 = num1;
            num2 = (int) num4 * 247163352 ^ 1439292785;
            continue;
          case 9:
            goto label_13;
          case 10:
            goto label_9;
          default:
            goto label_12;
        }
      }
label_9:
      index = -1;
      goto label_13;
label_12:
      index = -1;
label_13:
      Image image;
      try
      {
        if (index == -1)
          goto label_17;
label_14:
        int num7 = -1511134031;
label_15:
        while (true)
        {
          uint num8;
          switch ((num8 = (uint) ((~(num7 - ~--~-531006969 * 1118626801) ^ ~(1811305452 - -335297222) - 185008479 * -1435613400) * -528115203 * 1866349941 - -1698575702)) % 4U)
          {
            case 0:
              goto label_14;
            case 2:
              num7 = (int) num8 * 560741244 ^ 524903216;
              continue;
            case 3:
              goto label_17;
            default:
              goto label_18;
          }
        }
label_18:
        // ISSUE: reference to a compiler-generated field
        image = Data.VB\u0024StateMachine_39_HandelData.imageFlags.Images[index];
        goto label_20;
label_17:
        // ISSUE: reference to a compiler-generated field
        index = Data.VB\u0024StateMachine_39_HandelData.imageFlags.Images.IndexOfKey(EXGuarder.\u00331605335.ToUpper());
        num7 = 574632536;
        goto label_15;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        // ISSUE: reference to a compiler-generated field
        image = Data.VB\u0024StateMachine_39_HandelData.imageFlags.Images[0];
        ProjectData.ClearProjectError();
      }
label_20:
      return image;
    }
  }
}
